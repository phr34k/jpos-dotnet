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

public class NativeDataListener implements jpos.events.DataListener
{
  public native void Scanner_DataEvent(DataEvent e);
  //callback from scanner
  public void dataOccurred(DataEvent e)
  {    
  	Object c = e.getSource();
  	System.out.println(c.toString());
    Scanner_DataEvent(e);
  }	
}