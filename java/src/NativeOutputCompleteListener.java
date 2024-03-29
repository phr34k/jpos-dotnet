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

public class NativeOutputCompleteListener implements jpos.events.OutputCompleteListener
{
  public native void Scanner_DataEvent(OutputCompleteEvent e);
  //callback from scanner
  public void outputCompleteOccurred(OutputCompleteEvent e)
  {    
  	Object c = e.getSource();
  	System.out.println(c.toString());
    Scanner_DataEvent(e);
  }	
}