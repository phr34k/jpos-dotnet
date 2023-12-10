// reference library: https://github.com/emigonza/JavaPOS/tree/master/src/jpos

import jpos.JposException;
import jpos.events.DataEvent;
import jpos.events.ErrorEvent;
import jpos.events.StatusUpdateEvent;
import jpos.events.OutputCompleteEvent;
import jpos.events.DataListener;
import jpos.events.StatusUpdateListener;
import jpos.events.OutputCompleteListener;
import jpos.events.ErrorListener;
import jpos.JposConst;
import jpos.util.JposPropertiesConst;
import java.util.List;
import java.util.ArrayList;


public class Main implements jpos.events.DataListener, jpos.events.StatusUpdateListener, jpos.events.OutputCompleteListener, jpos.events.ErrorListener  {

  public void errorOccurred(ErrorEvent e)
  {
    //pass error occured to c#
    if ( e.getSource() instanceof jpos.Scanner) 
    {
      Scanner_ErrorEvent();  
    } 
    else if ( e.getSource() instanceof jpos.POSPrinter) 
    {
      Printer_ErrorEvent();  
    } 
    else if ( e.getSource() instanceof jpos.CashDrawer) 
    {
      Cashdrawer_ErrorEvent();  
    } 
  }

  //callback from scanner
  public void dataOccurred(DataEvent e)
  {
    //pass error occured to c#
    Scanner_StatusUpdateEvent();
  }

  public void statusUpdateOccurred(StatusUpdateEvent e)
  {
    //pass status update event c#    
    if ( e.getSource() instanceof jpos.Scanner) 
    {
      Scanner_StatusUpdateEvent();
    }   
    else if ( e.getSource() instanceof jpos.POSPrinter) 
    {
      Printer_StatusUpdateEvent();
    } 
    else if ( e.getSource() instanceof jpos.CashDrawer) 
    {
      Cashdrawer_StatusUpdateEvent();
    }     
  }

  public void outputCompleteOccurred(OutputCompleteEvent e)
  {
    //output complete notification    
    if ( e.getSource() instanceof jpos.POSPrinter) 
    {
      Printer_OutputCompleteEvent();
    } 
  }


  //these are defined with JNI.RegisterNatives call on: cshap/test/Program.cs
  public static native void Scanner_ErrorEvent();
  public static native void Scanner_StatusUpdateEvent();
  public static native void Printer_ErrorEvent();
  public static native void Printer_StatusUpdateEvent();
  public static native void Printer_OutputCompleteEvent();
  public static native void Cashdrawer_ErrorEvent();
  public static native void Cashdrawer_StatusUpdateEvent();
  public static Main _main = new Main();

  //TODO: Implement list of devices -> refresh populates this
  public List<Device> devices = new ArrayList<Device>();

	static jpos.Scanner __scanner = new jpos.Scanner();


  public static void initialize(jpos.BaseJposControl device)
  {  
    try 
    {
      device.open("Honeywell");      
      device.claim(1000);
      device.setDeviceEnabled(true);                  
      onDeviceClaimed(device);
            
      if ( device instanceof jpos.Scanner) 
      {
        jpos.Scanner _scanner = (jpos.Scanner)device;
        _scanner.getCapPowerReporting();
        _scanner.setDataEventEnabled(true);  
      }
    } 
    catch (JposException ex) 
    {
        System.out.println(ex.toString());
    }          
    finally
    {
      if ( device instanceof jpos.Scanner) 
      {
        jpos.Scanner _scanner = (jpos.Scanner)device;
        _scanner.addDataListener(_main);
        _scanner.addErrorListener(_main);            
        _scanner.addStatusUpdateListener(_main);            
      }     
    }
  }

  public static void deinitialize(jpos.BaseJposControl device)
  {  
    try 
    {
      //disable the device if it's enabled
      if( device.getState() != JposConst.JPOS_S_CLOSED && device.getDeviceEnabled() ) device.setDeviceEnabled(false);      
      //close the device if it's claimed
      if( device.getState() != JposConst.JPOS_S_CLOSED && device.getClaimed() ) {
          onDeviceReleased(device);
          device.close();        
      }

      //release the device if it's opened
      if( device.getState() != JposConst.JPOS_S_CLOSED) device.release();         
    } 
    catch (JposException ex) 
    {
        System.out.println(ex.toString());
    }          
    finally
    {
      if ( device instanceof jpos.Scanner) 
      {
        jpos.Scanner _scanner = (jpos.Scanner)device;
        _scanner.removeDataListener(_main);
        _scanner.removeErrorListener(_main);            
        _scanner.removeStatusUpdateListener(_main);      
      }        
    }
  }  


  public static void onDeviceClaimed(jpos.BaseJposControl device)
  {

  }

  public static void onDeviceReleased(jpos.BaseJposControl device)
  {

  }



  public static String getSignature(java.lang.reflect.Constructor m){
    String sig;
    try {
        java.lang.reflect.Field gSig = java.lang.reflect.Constructor.class.getDeclaredField("signature");
        gSig.setAccessible(true);
        sig = (String) gSig.get(m);
        if(sig!=null) return sig;
    } catch (IllegalAccessException | NoSuchFieldException e) { 
        //e.printStackTrace();
    }

    StringBuilder sb = new StringBuilder("(");
    for(Class<?> c : m.getParameterTypes()) 
        sb.append((sig=java.lang.reflect.Array.newInstance(c, 0).toString().replace(".","/"))
            .substring(1, sig.indexOf('@')));
    return sb.append(')')
        .append(
            "V"
        )
        .toString();
  }

  public static String getSignature(java.lang.reflect.Method m){
    String sig;
    try {
        java.lang.reflect.Field gSig = java.lang.reflect.Method.class.getDeclaredField("signature");
        gSig.setAccessible(true);
        sig = (String) gSig.get(m);
        if(sig!=null) return sig;
    } catch (IllegalAccessException | NoSuchFieldException e) { 
        //e.printStackTrace();
    }

    StringBuilder sb = new StringBuilder("(");
    for(Class<?> c : m.getParameterTypes()) 
        sb.append((sig=java.lang.reflect.Array.newInstance(c, 0).toString().replace(".","/"))
            .substring(1, sig.indexOf('@')));
    return sb.append(')')
        .append(
            m.getReturnType()==void.class?"V":
            (sig=java.lang.reflect.Array.newInstance(m.getReturnType(), 0).toString().replace(".","/")).substring(1, sig.indexOf('@'))
        )
        .toString();
  }

  public static String classToString(java.lang.Class retType, ArrayList<java.lang.Class> supportedClasses)
  {
        String retClass = "";
        if( retType.isPrimitive() ) 
        {
            if( retType == double.class )
            {
                retClass = "double";
            }
            else if( retType == float.class )
            {
                retClass = "double";
            }            
            else if( retType == long.class )
            {
                retClass = "long";
            }
            else if( retType == int.class )
            {
                retClass = "int";
            }
            else if( retType == short.class )
            {
                retClass = "short";
            }            
            else if( retType == void.class )
            {
                retClass = "void";
            }
            else if( retType == boolean.class )
            {
                retClass = "bool";
            }              
        }  
        else
        {
          if( retType == String.class )
          {
            retClass = "string";
          }
          else if( retType == byte[].class )
          {
            retClass = "byte[]";
          }          
          else
          {
            if( supportedClasses.contains(retType) )
            {
              retClass = retType.getName();
            }
            else
            {
              retClass = "JObject"; 
            }
          }
        }  

        return retClass;
  }


  public static String classToValue(java.lang.Class retType, String paramName, ArrayList<java.lang.Class> supportedClasses)
  {
        String retClass = "";
        if( retType.isPrimitive() ) 
        {
            if( retType == double.class )
            {
                retClass = String.format("new JValue(%s)", paramName);
            }
            else if( retType == float.class )
            {
                retClass = String.format("new JValue(%s)", paramName);
            }            
            else if( retType == long.class )
            {
                retClass = String.format("new JValue(%s)", paramName);
            }
            else if( retType == int.class )
            {
                retClass = String.format("new JValue(%s)", paramName);
            }
            else if( retType == short.class )
            {
                retClass = String.format("new JValue(%s)", paramName);
            }            
            else if( retType == void.class )
            {
                retClass = String.format("new JValue(%s)", paramName);
            }
            else if( retType == boolean.class )
            {
                retClass = String.format("new JValue(%s)", paramName);
            }              
        }  
        else
        {
          if( retType == String.class )
          {
            retClass = String.format("new JValue(JNI.NewString(%s))", paramName);
          }
          else if( retType == byte[].class )
          {
            retClass = String.format("new JValue(JNI.NewArray<sbyte>(%s.Length))", paramName);
          }          
          else
          {
            if( supportedClasses.contains(retType) )
            {
              retClass = String.format("new JValue(%s)", paramName); 
            }
            else
            {
              retClass = String.format("new JValue(%s)", paramName); 
            }
          }
        }  

        return retClass;
  }

  public static void test()
  {
      ArrayList<java.lang.Class> list = new ArrayList<java.lang.Class>();
      list.add(jpos.events.JposEvent.class);    
      list.add(jpos.events.ErrorEvent.class);
      list.add(jpos.events.DataEvent.class);
      list.add(jpos.events.StatusUpdateEvent.class);
      list.add(jpos.events.DirectIOEvent.class);
      list.add(jpos.events.OutputCompleteEvent.class);
      list.add(java.util.EventObject.class);
      
      list.add(jpos.BaseControl.class);
      list.add(jpos.BaseJposControl.class);      
      list.add(jpos.Scanner.class);
      list.add(jpos.CashDrawer.class);      
      list.add(jpos.CoinDispenser.class);     
      list.add(jpos.PINPad.class);     
      list.add(jpos.POSPrinter.class);    
      
      list.add(jpos.events.ErrorListener.class);
      list.add(jpos.events.OutputCompleteListener.class);
      list.add(jpos.events.StatusUpdateListener.class);
      list.add(jpos.events.DirectIOListener.class);
      list.add(jpos.events.DataListener.class);    

      list.add(jpos.JposException.class);  

      list.add(NativeDataListener.class);
      list.add(NativeStatusUpdateListener.class);        
      list.add(NativeErrorListener.class);   
      list.add(NativeOutputCompleteListener.class);   
      
      System.out.println("using System;");                
      System.out.println("using System.Diagnostics;");                
      System.out.println("using System.Runtime.InteropServices;");                      
      System.out.println("using JNISharp.NativeInterface;");                      
      System.out.println("using test.jpos;");     
      System.out.println("#pragma warning disable CS0108 // Member hides inherited member; missing new keyword");          
      
      System.out.println("");                
      System.out.println("namespace jpos.internals   {");                

      ArrayList<String> ignoredMethods = new ArrayList<String>();
      ignoredMethods.add("public final synchronized void jpos.events.JposEvent.updateSequenceNumber()");
      ignoredMethods.add("public static final synchronized long jpos.events.JposEvent.incrSequenceNumber()");
      ignoredMethods.add("public final void java.lang.Object.wait(long,int) throws java.lang.InterruptedException");
      ignoredMethods.add("public final native void java.lang.Object.wait(long) throws java.lang.InterruptedException");
      ignoredMethods.add("public boolean java.lang.Object.equals(java.lang.Object)");
      ignoredMethods.add("public native int java.lang.Object.hashCode()");
      ignoredMethods.add("public final native java.lang.Class java.lang.Object.getClass()");
      ignoredMethods.add("public final native void java.lang.Object.notify()");
      ignoredMethods.add("public final native void java.lang.Object.notifyAll()");
      ignoredMethods.add("public final void java.lang.Object.wait() throws java.lang.InterruptedException");
      ignoredMethods.add("public java.lang.String java.util.EventObject.toString()");      
      ignoredMethods.add("public final native java.lang.Class<?> java.lang.Object.getClass()");      
   
      for(int i = 0 ; i < list.size(); ++i )
      {
        java.lang.Class cls = list.get(i);
        java.lang.reflect.Method[] methods = cls.getDeclaredMethods();
        java.lang.reflect.Constructor[] constructors = cls.getDeclaredConstructors();        
        String value = cls.toString();

        
        ArrayList<java.lang.reflect.Method> filteredNatives = new ArrayList<java.lang.reflect.Method>();    
        ArrayList<java.lang.reflect.Method> filteredMethods = new ArrayList<java.lang.reflect.Method>();
        ArrayList<java.lang.reflect.Constructor> filteredConstructors = new ArrayList<java.lang.reflect.Constructor>();

        for(int k = 0 ; k < methods.length; ++k )
        {  
          if( ignoredMethods.contains(methods[k].toGenericString()))
          {
            continue;
          }

          if( (methods[k].getModifiers() & java.lang.reflect.Modifier.NATIVE) == java.lang.reflect.Modifier.NATIVE)
          {
            filteredNatives.add(methods[k]);
            continue;
          }
          
          if( (methods[k].getModifiers() & java.lang.reflect.Modifier.PRIVATE) == java.lang.reflect.Modifier.PRIVATE)
          {
            continue;
          }

          if( (methods[k].getModifiers() & java.lang.reflect.Modifier.PROTECTED) == java.lang.reflect.Modifier.PROTECTED)
          {
            continue;
          }          

          filteredMethods.add(methods[k]);
        }

        for(int k = 0 ; k < constructors.length; ++k )
        {  
          if( ignoredMethods.contains(constructors[k].toGenericString()))
          {
            continue;
          }

          filteredConstructors.add(constructors[k]);
        }        
        
        String fullyQualifiedClassNameOrig = cls.getName();                             
        String[] fullyQualifiedClassName = fullyQualifiedClassNameOrig.split("\\.");           
        String className = fullyQualifiedClassName[fullyQualifiedClassName.length - 1];
        String nameSpace = String.join(".", java.util.Arrays.copyOf(fullyQualifiedClassName, fullyQualifiedClassName.length - 1));

        if( nameSpace.length() > 0 )
        System.out.println(String.format("namespace %s {", nameSpace) );                
        java.lang.Class superCls = cls.getSuperclass();
        if( superCls != null )
        {
            if( list.contains(superCls) )
            {
              System.out.println(String.format("class %s : %s {", className, superCls.getName()) );                      
            }              
            else
            {

              if( Throwable.class.isAssignableFrom(superCls) )
              {
                System.out.println(String.format("class %s : JThrowable {", className) );                      
              }
              else
              {
                System.out.println(String.format("class %s : JObject {", className) );                      
              }
            }
        }
        else
        {
            System.out.println(String.format("class %s : JObject {", className) );                  
        }




if( filteredNatives.size() > 0 )
        {        
          System.out.println(String.format("public interface Native {", className) );                  
          //System.out.println(String.format("\tdelegate void ScannerDataEventInternal(IntPtr JNIEnv, IntPtr objectOrClasss, IntPtr listener, IntPtr device);", className));      

        System.out.println("");      
        for(int k = 0 ; k < filteredNatives.size(); ++k )
        {  
          

          //System.out.println(methods[k].getName());
          //System.out.println(methods[k].getParameterCount());
          //System.out.println(methods[k].toGenericString());
          //System.out.println(methods[k].getModifiers());
          //System.out.println(getSignature(methods[k]));       

          String methodName = filteredNatives.get(k).getName();
          int parameterLength = filteredNatives.get(k).getParameterCount();
          java.lang.Class retType = filteredNatives.get(k).getReturnType();
          java.lang.Class[] params = filteredNatives.get(k).getParameterTypes();          
          String retClass = classToString(retType, list);
          String[] paramType = new String[1 + params.length];
          String[] paramName = new String[1 + params.length];
          String[] paramClass = new String[1 + params.length];
          String[] paramPass = new String[1 + params.length];

          String[] nativeClass = new String[2 + params.length];
          nativeClass[0] = "IntPtr JNIEnv";
          nativeClass[1] = "IntPtr objectOrClasss";

          paramType[0] = className;
          paramName[0] = "self";          
          paramClass[0] = String.format("%s %s", className, "self");

          for( int j = 0; j < parameterLength; ++j ) {
            paramType[1 + j] = classToString(params[j], list);
            paramName[1 + j] = String.format("p%d", j);
            paramClass[1 + j] = classToString(params[j], list) + String.format(" p%d", j);
            paramPass[1 + j] = classToValue(params[j], String.format("p%d", j), list); 
            nativeClass[2 + j] = "IntPtr" + String.format(" p%d", j);
          }


          if( retType == String.class )
          {
            retClass = "string";
          }


          //System.out.println("\t[DebuggerNonUserCode]");                  
          System.out.print(String.format("\t\tpublic %s %s(", retClass, methodName)  );                  
          System.out.print(String.join(",", paramClass)  ); 
          System.out.println(");"); 
          
          //System.out.println("{}");     
          System.out.println("");          
        }   

          System.out.println("\t}");   
          System.out.println("\tinternal static Native? nativeEvents { get; set; }");           
        }

                       

        List<String> constructorBody = new ArrayList<String>();
        //public void Scanner_DataEvent(NativeDataListener p0,jpos.events.DataEvent p1)       
            
        
        constructorBody.add(String.format("\t_class = JNI.FindClass(\"%s\");", fullyQualifiedClassNameOrig.replace('.', '/')));
        constructorBody.add(String.format("\tif( _class == null ) throw new InvalidOperationException();"));          
        System.out.println(String.format("\tprotected static JClass _class;", fullyQualifiedClassNameOrig.replace('.', '/')));  

        for(int k = 0 ; k < filteredConstructors.size(); ++k )
        {  
          String sig = getSignature(filteredConstructors.get(k));
          System.out.println(String.format("\tprotected static string _%s%d = \"%s\";", "init", k, sig));  
        }

        for(int k = 0 ; k < filteredMethods.size(); ++k )
        {  
          String sig = getSignature(filteredMethods.get(k));
          System.out.println(String.format("\tprotected static string _%s%d = \"%s\";", filteredMethods.get(k).getName(), k, sig));  
        }

        for(int k = 0 ; k < filteredNatives.size(); ++k )
        {  
          String sig = getSignature(filteredNatives.get(k));
          System.out.println(String.format("\tprotected static string _%s%d = \"%s\";", filteredNatives.get(k).getName(), k, sig));  
        }                

        for(int k = 0 ; k < filteredConstructors.size(); ++k )
        {  
		  constructorBody.add(String.format("\t_m%s%d = _class.GetMethodID(\"%s\", _%s%d);", "init", k, "<init>", "init", k));
		  constructorBody.add(String.format("\tif( _m%s%d.Handle == IntPtr.Zero ) throw new InvalidOperationException();", "init", k, "<init>", "init", k));  
          System.out.println(String.format("\tprotected static JMethodID _m%s%d;", "init", k, "<init>", "init", k));  
        }     

        for(int k = 0 ; k < filteredMethods.size(); ++k )
        { 
		  constructorBody.add(String.format("\t_m%s%d = _class.GetMethodID(\"%s\", _%s%d);", filteredMethods.get(k).getName(), k, filteredMethods.get(k).getName(), filteredMethods.get(k).getName(), k));   
		  constructorBody.add(String.format("\tif( _m%s%d.Handle == IntPtr.Zero ) throw new InvalidOperationException();", filteredMethods.get(k).getName(), k, filteredMethods.get(k).getName(), filteredMethods.get(k).getName(), k));  
          System.out.println(String.format("\tprotected static JMethodID _m%s%d;", filteredMethods.get(k).getName(), k, filteredMethods.get(k).getName(), filteredMethods.get(k).getName(), k));  
        }                  

        System.out.println("");      

             

        System.out.println("\t[DebuggerNonUserCode]");                  
        System.out.println("\tpublic static bool IsInstanceOf(JObject except)");                          
        System.out.println("\t{");              
        System.out.println("\t  return JNI.IsInstanceOf(except, _class);");                  
        System.out.println("\t}");        

        System.out.println("\t[DebuggerNonUserCode]");                  
        System.out.println("\tprivate static Exception FromThrowable(JThrowable except)");                  
        System.out.println("\t{");                  
        System.out.println("\t  if (jpos.JposException.IsInstanceOf(except))");                  
        System.out.println("\t  {");       

        /*           
        System.out.println("\t    except.printStackTrace();");                  
        System.out.println("\t    int errorCode = JNI.CallMethod<int>(except, JExplorer._getErrorCode);");                  
        System.out.println("\t    int errorCodeExtended = JNI.CallMethod<int>(except, JExplorer._getErrorCodeExtended);");                  
        System.out.println("\t    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);");                  
        */

        System.out.println("\t    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });");                  
        System.out.println("\t    d.printStackTrace();");                  
        System.out.println("\t    int errorCode = d.getErrorCode();");
        System.out.println("\t    int errorCodeExtended = d.getErrorCodeExtended();");
        System.out.println("\t    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);");                      

        System.out.println("\t  }");  
        System.out.println("\t  else");  
        System.out.println("\t  {");  
        System.out.println("\t    except.printStackTrace();");  
        System.out.println("\t    return new JavaException(except.ToString());");  
        System.out.println("\t  }");  
        System.out.println("\t}");  
        


        System.out.println("");    
        System.out.println("\t[DebuggerNonUserCode]");                  
        System.out.println(String.format("\tpublic %s(JClone<JObject> obj) : base(obj) {} ", className, className)  );                  
        System.out.println("");      

        for(int k = 0 ; k < filteredConstructors.size(); ++k )
        {  
          

          //System.out.println(methods[k].getName());
          //System.out.println(methods[k].getParameterCount());
          //System.out.println(methods[k].toGenericString());
          //System.out.println(methods[k].getModifiers());
          //System.out.println(getSignature(methods[k]));       

          String methodName = filteredConstructors.get(k).getName();
          int parameterLength = filteredConstructors.get(k).getParameterCount();
          //java.lang.Class retType = filteredConstructors.get(k).getReturnType();
          java.lang.Class[] params = filteredConstructors.get(k).getParameterTypes();          
          //String retClass = classToString(retType, list);
          String[] paramClass = new String[params.length];
          String[] paramPass = new String[params.length];
          String[] paramPass2 = new String[params.length];
          for( int j = 0; j < parameterLength; ++j ) {
            paramClass[j] = classToString(params[j], list) + String.format(" p%d", j);
            paramPass[j] = classToValue(params[j], String.format("p%d", j), list); 
            paramPass2[j] = String.format("p%d", j); 
          }

          System.out.print(String.format("\tpublic %s(", className)  );                  
          System.out.print(String.join(",", paramClass)  ); 
          System.out.println(String.format(") : base(initialize(%s)) {}", String.join(",", paramPass2)));           

          System.out.println("\t[DebuggerNonUserCode]");                  
          System.out.print(String.format("\tprotected static JClone<JObject> initialize(", className)  );                  
          System.out.print(String.join(",", paramClass)  ); 
          System.out.println(") "); 
          
          //System.out.println("{}");     


          String hasReturnValue = null;

          System.out.println("\t{"); 

          System.out.print(String.format("\t    JObject ret = JNI.NewObject<JObject>(_class, _m%s%d", "init", k)); 
          hasReturnValue = "\t    return new JClone<JObject>() { Value = ret } ;";

          String parameters = String.join(",", paramPass );
          if( parameters.length() > 0 ) System.out.print(", "); 
          System.out.print(parameters); 
          System.out.println(");"); 

          System.out.println("\t    bool exception = JNI.ExceptionCheck();");                         
          System.out.println("\t    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();");           
          System.out.println("\t    if (exception)");           
          System.out.println("\t    {"); 
          System.out.println("\t        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);");                   
          System.out.println("\t    }");  

          if( hasReturnValue != null )
          {
              System.out.println(""); 
              System.out.println(hasReturnValue);    
          }
          System.out.println("\t}");  
          System.out.println(""); 
        }

        /*
        public JScanner(PosExplorer explorer)
        {
            jobj = JNI.NewObject<JObject>(JExplorer._scanner, JExplorer._scannerConstructor);
            
        }     
        */   

        if( filteredNatives.size() > 0 )
        {        


for(int k = 0 ; k < filteredNatives.size(); ++k )
        {  
          

          //System.out.println(methods[k].getName());
          //System.out.println(methods[k].getParameterCount());
          //System.out.println(methods[k].toGenericString());
          //System.out.println(methods[k].getModifiers());
          //System.out.println(getSignature(methods[k]));       

          String methodName = filteredNatives.get(k).getName();
          int parameterLength = filteredNatives.get(k).getParameterCount();
          java.lang.Class retType = filteredNatives.get(k).getReturnType();
          java.lang.Class[] params = filteredNatives.get(k).getParameterTypes();          
          String retClass = classToString(retType, list);
          String[] paramType = new String[params.length];
          String[] paramName = new String[params.length];
          String[] paramClass = new String[params.length];
          String[] paramPass = new String[params.length];
          boolean isStatic = (filteredNatives.get(k).getModifiers() & java.lang.reflect.Modifier.STATIC) == java.lang.reflect.Modifier.STATIC;


          String[] nativeClass = new String[2 + params.length];
          String[] nativePass = new String[1 + params.length];
          nativeClass[0] = "IntPtr JNIEnv";
          nativeClass[1] = "IntPtr objectOrClasss";
          if( isStatic == false ) 
          {
            nativePass[0] = "pobject";
          }
          else
          {
            nativePass[0] = "null"; 
          }

          for( int j = 0; j < parameterLength; ++j ) {
            paramType[j] = classToString(params[j], list);
            paramName[j] = String.format("p%d", j);
            paramClass[j] = classToString(params[j], list) + String.format(" p%d", j);
            paramPass[j] = classToValue(params[j], String.format("p%d", j), list); 
            nativeClass[2 + j] = "IntPtr" + String.format(" p%d", j);
            nativePass[1 + j] = String.format("pp%d", j);
          }

          System.out.println(String.format("\tdelegate void %sInternal(%s);", methodName, String.join(",", nativeClass)));      
        }     



        System.out.println(String.format("\tpublic static List<WeakReference<%s>> mapping = new List<WeakReference<%s>>();", className, className));      
        System.out.println(String.format("\tpublic static bool TryGet(IntPtr refz, out %s? l)", className));      
        System.out.println("\t{");      
        System.out.println(String.format("\t    %s? output = null;", className));      
        System.out.println("\t    var s = new JObject(refz, JNI.ReferenceType.Local);");      
        System.out.println("\t    for (int i = 0; i < mapping.Count; i++)");      
        System.out.println("\t    {");      
        System.out.println("\t        if (mapping[0].TryGetTarget(out output) && JNI.IsSameObject(output, s) == true)");      
        System.out.println("\t        {");      
        System.out.println("\t            l = output;");      
        System.out.println("\t            return true;");      
        System.out.println("\t        }");      
        System.out.println("\t    }");      
        System.out.println("\t");      
        System.out.println("\t    l = null;");      
        System.out.println("\t    return false;");      
        System.out.println("\t}");      

        System.out.println(String.format("\tpublic static void Register(%s c)", className));
        System.out.println("\t{");
        System.out.println(String.format("\t    mapping.Add(new WeakReference<%s>(c));", className));
        System.out.println("\t}");

        System.out.println(String.format("\tpublic static void Unregister(%s c)", className));
        System.out.println("\t{");
        System.out.println(String.format("\t    %s? output = null;", className));
        System.out.println("\t    mapping.RemoveAll((m) => m.TryGetTarget(out output) && object.ReferenceEquals(output, c));");
        System.out.println("\t}");

        
          //System.out.println(String.format("\tstatic %s()", className));      
          //System.out.println("\t{");      
          //System.out.println("\t    ");      

          for(int k = 0 ; k < filteredNatives.size(); ++k )
          {             
              //System.out.println(String.format("\tprotected static JMethodID _m%s%d = _class.GetMethodID(\"%s\", );", filteredNatives.get(k).getName(), k, filteredNatives.get(k).getName(), filteredNatives.get(k).getName(), k));  
              constructorBody.add(String.format("\t        %sInternal evt = %s;", filteredNatives.get(k).getName(), filteredNatives.get(k).getName()));      
          }

          constructorBody.add("\t    JNI.RegisterNatives(_class, new JNINativeMethod[] {");      
          for(int k = 0 ; k < filteredNatives.size(); ++k )
          {             
              //System.out.println(String.format("\tprotected static JMethodID _m%s%d = _class.GetMethodID(\"%s\", );", filteredNatives.get(k).getName(), k, filteredNatives.get(k).getName(), filteredNatives.get(k).getName(), k));  
              constructorBody.add(String.format("\t        new JNINativeMethod() { name = \"%s\", signature = _%s%d, fnPtr = Marshal.GetFunctionPointerForDelegate(evt) },", filteredNatives.get(k).getName(), filteredNatives.get(k).getName(), k));      
          }
          constructorBody.add("\t    });");      
          //System.out.println("\t}");      
        }


        System.out.println("");      
        for(int k = 0 ; k < filteredNatives.size(); ++k )
        {  
          

          //System.out.println(methods[k].getName());
          //System.out.println(methods[k].getParameterCount());
          //System.out.println(methods[k].toGenericString());
          //System.out.println(methods[k].getModifiers());
          //System.out.println(getSignature(methods[k]));       

          String methodName = filteredNatives.get(k).getName();
          int parameterLength = filteredNatives.get(k).getParameterCount();
          java.lang.Class retType = filteredNatives.get(k).getReturnType();
          java.lang.Class[] params = filteredNatives.get(k).getParameterTypes();          
          String retClass = classToString(retType, list);
          String[] paramType = new String[params.length];
          String[] paramName = new String[params.length];
          String[] paramClass = new String[params.length];
          String[] paramPass = new String[params.length];
          boolean isStatic = (filteredNatives.get(k).getModifiers() & java.lang.reflect.Modifier.STATIC) == java.lang.reflect.Modifier.STATIC;


          String[] nativeClass = new String[2 + params.length];
          String[] nativePass = new String[1 + params.length];
          nativeClass[0] = "IntPtr JNIEnv";
          nativeClass[1] = "IntPtr objectOrClasss";
          if( isStatic == false ) 
          {
            nativePass[0] = "pobject";
          }
          else
          {
            nativePass[0] = "null"; 
          }

          for( int j = 0; j < parameterLength; ++j ) {
            paramType[j] = classToString(params[j], list);
            paramName[j] = String.format("p%d", j);
            paramClass[j] = classToString(params[j], list) + String.format(" p%d", j);
            paramPass[j] = classToValue(params[j], String.format("p%d", j), list); 
            nativeClass[2 + j] = "IntPtr" + String.format(" p%d", j);
            nativePass[1 + j] = String.format("pp%d", j);
          }


          if( retType == String.class )
          {
            retClass = "string";
          }

          //System.out.println("\t[DebuggerNonUserCode]");                  
          System.out.print(String.format("\tprotected static void %s(", methodName)  );                  
          System.out.print(String.join(",", nativeClass)  ); 
          System.out.println(") ");         
          System.out.println("\t{"); 

          if( isStatic == false )
          System.out.println(String.format("\t    %s pobject = new %s(new JClone<JObject>() { Value = JNI.NewGlobalRef<JObject>(new JObject(%s, JNI.ReferenceType.Local)) });", className, className, "objectOrClasss"));                    
          for( int j = 0; j < parameterLength; ++j ) {
            System.out.println(String.format("\t    %s p%s = new %s(new JClone<JObject>() { Value = JNI.NewGlobalRef<JObject>(new JObject(%s, JNI.ReferenceType.Local)) });", paramType[j], paramName[j], paramType[j], paramName[j]));          
          }
          //System.out.println("\t    throw new NotImplementedException();");                         

          System.out.println(String.format("\t    nativeEvents?.Scanner_DataEvent(%s);", String.join(",", nativePass) ));                         

          
          System.out.println("\t}");  
          System.out.println(""); 



          //System.out.println("\t[DebuggerNonUserCode]");                  
          System.out.print(String.format("\tpublic %s %s(", retClass, methodName)  );                  
          System.out.print(String.join(",", paramClass)  ); 
          System.out.println(") "); 
          
          //System.out.println("{}");     


          String hasReturnValue = null;
          System.out.println("\t{"); 

          
          //String parameters = String.join(",", paramPass );
          //if( parameters.length() > 0 ) System.out.print(", "); 
          //System.out.print(parameters); 
          //System.out.println(");"); 
          System.out.println("\t    throw new NotImplementedException();");                         
          System.out.println("\t}");  
          System.out.println(""); 
        }        

        System.out.println("");      
        for(int k = 0 ; k < filteredMethods.size(); ++k )
        {  
          

          //System.out.println(methods[k].getName());
          //System.out.println(methods[k].getParameterCount());
          //System.out.println(methods[k].toGenericString());
          //System.out.println(methods[k].getModifiers());
          //System.out.println(getSignature(methods[k]));       

          String methodName = filteredMethods.get(k).getName();
          int parameterLength = filteredMethods.get(k).getParameterCount();
          java.lang.Class retType = filteredMethods.get(k).getReturnType();
          java.lang.Class[] params = filteredMethods.get(k).getParameterTypes();          
          String retClass = classToString(retType, list);
          String[] paramClass = new String[params.length];
          String[] paramPass = new String[params.length];
          for( int j = 0; j < parameterLength; ++j ) {
            paramClass[j] = classToString(params[j], list) + String.format(" p%d", j);
            paramPass[j] = classToValue(params[j], String.format("p%d", j), list); 
          }


          if( retType == String.class )
          {
            retClass = "string";
          }

          System.out.println("\t[DebuggerNonUserCode]");                  
          System.out.print(String.format("\tpublic %s %s(", retClass, methodName)  );                  
          System.out.print(String.join(",", paramClass)  ); 
          System.out.println(") "); 
          
          //System.out.println("{}");     


          String hasReturnValue = null;
          System.out.println("\t{"); 

          if( retType.isPrimitive() )
          {
            if( retType == void.class )
            {
              System.out.print(String.format("\t    JNI.CallVoidMethod(this, _m%s%d", methodName, k));     
              hasReturnValue = null;
            }
            else
            {
              System.out.print(String.format("\t    %s ret = JNI.CallMethod<%s>(this, _m%s%d", retClass, retClass, methodName, k ));               
              hasReturnValue = "\t    return ret;";
            }       
          }
          else
          {
            if( retType == byte[].class )
            {            
              System.out.print(String.format("\t    JArray<sbyte> ret = JNI.CallObjectMethod<JArray<sbyte>>(this, _m%s%d", methodName, k)); 
              hasReturnValue = "\t    return Array.ConvertAll(ret.GetElements(), (a) => (byte)a);";            
            }
            else if( retType == String.class )
            {
              System.out.print(String.format("\t    JString ret = JNI.CallObjectMethod<JString>(this, _m%s%d", methodName, k)); 
              hasReturnValue = "\t    return ret.GetString();";
            }
            else
            {            
              System.out.print(String.format("\t    JObject ret = JNI.CallObjectMethod<JObject>(this, _m%s%d", methodName, k)); 
              hasReturnValue = "\t    return ret;";
            }
          }



          String parameters = String.join(",", paramPass );
          if( parameters.length() > 0 ) System.out.print(", "); 
          System.out.print(parameters); 
          System.out.println(");"); 

          System.out.println("\t    bool exception = JNI.ExceptionCheck();");                         
          System.out.println("\t    if (exception)");           
          System.out.println("\t    {"); 
          System.out.println("\t        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);");                   
          System.out.println("\t    }");  

          if( hasReturnValue != null )
          {
              System.out.println(""); 
              System.out.println(hasReturnValue);    
          }
          System.out.println("\t}");  
          System.out.println(""); 
        }

        System.out.println("\t[DebuggerNonUserCode]");                  
        System.out.println(String.format("\tstatic %s()", className));                          
        System.out.println("\t{");              
        for(int k = 0 ; k < constructorBody.size(); ++k ) {
          System.out.println(String.format("  %s", constructorBody.get(k)));                  
        }
        System.out.println("\t}");   

        System.out.println(String.format("}") );        
        if( nameSpace.length() > 0 )
        System.out.println(String.format("}") );        
        System.out.println("");        
      }
      System.out.println(String.format("}") ); 
      System.out.println("#pragma warning restore CS0108 // Member hides inherited member; missing new keyword");            
  }


	public static void main(String[] args)
	{  		
    test();

    //example of setting the location of the jpos xml file
		if( args.length > 0 ) System.setProperty(JposPropertiesConst.JPOS_POPULATOR_FILE_PROP_NAME, args[0]);
		//System.setProperty(JposPropertiesConst.JPOS_POPULATOR_FILE_URL_PROP_NAME, "http://some-where-remote.com/jpos.xml");
  	

    //output to console
    //System.out.println("This is my first program in java");


    //example of how to call events on csharp side
    //Main.Scanner_ErrorEvent();
    //Main.Scanner_StatusUpdateEvent();
    //Main.Printer_ErrorEvent();
    //Main.Printer_StatusUpdateEvent();
    //Main.Printer_OutputCompleteEvent();
    //Main.Cashdrawer_ErrorEvent();
    //Main.Cashdrawer_StatusUpdateEvent();

      /*
    for( int i = 0; i < args.length; ++i ) {
      System.out.println(args[i]);
    }

    //example of how to open an device
    initialize(__scanner);
    deinitialize(__scanner);
    */

	}//End of main

  public static void print(String[] args) throws Exception
  {
    System.out.println("setting up repository" + args[0]);        
    System.setProperty(JposPropertiesConst.JPOS_POPULATOR_FILE_PROP_NAME, args[0]);
  }

}
