package org.jumpmind.pos.javapos.sim.ui;

import java.awt.Dimension;
import java.awt.GridBagConstraints;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.InputStreamReader;
import java.util.HashMap;
import java.util.Map;
import java.util.TreeSet;
import java.io.File;

import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JTextField;
import javax.swing.SwingUtilities;

import jpos.JposConst;
import jpos.JposException;
import jpos.Scanner;
import jpos.events.DataEvent;
import jpos.services.EventCallbacks;

import org.jdom2.Document;
import org.jdom2.Element;
import org.jdom2.input.SAXBuilder;
import org.jumpmind.pos.javapos.sim.SimulatedScannerService;

public class SimulatedScannerPanel extends BaseSimulatedPanel {

    // static java.awt.Font customFont;
    protected static final long serialVersionUID = -3371467403985283645L;

    protected static SimulatedScannerPanel me = new SimulatedScannerPanel();
    protected SimulatedScannerService deviceCallback;
    protected Map<String, String> items = new HashMap<String, String>();
    protected String selectedItem;

    public SimulatedScannerService getDeviceCallback() {
        return deviceCallback;
    }

    public void setDeviceCallback(SimulatedScannerService deviceCallback) {
        this.deviceCallback = deviceCallback;
    }

    public static SimulatedScannerPanel getInstance() {
        return me;
    }



    public void init() {
        /*
        try {
            String path = java.lang.System.getenv("JAVA_FONT");
            if( path == null ) path = "Fonts/custom_font.ttf";
 

            //create the font to use. Specify the size!
            customFont = java.awt.Font.createFont(java.awt.Font.TRUETYPE_FONT, new java.io.File(path)).deriveFont(12f);
            java.awt.GraphicsEnvironment ge = java.awt.GraphicsEnvironment.getLocalGraphicsEnvironment();
            //register the font
            ge.registerFont(customFont);
        } catch (java.io.IOException e) {
            e.printStackTrace();
        } catch(java.awt.FontFormatException e) {
            e.printStackTrace();
        }
        */
    	
    	this.setName("SimulatedScanner");

        /*
        if( customFont == null )
        {
            System.out.println("customFont is null. ");  
        }
        else
        {
            System.out.println("customFont is loaded. ");  
        }
        */

        /*
        java.awt.GraphicsEnvironment ge;  
        ge = java.awt.GraphicsEnvironment.getLocalGraphicsEnvironment();  

        String[] names = ge.getAvailableFontFamilyNames();
        java.awt.Font[] allFonts = ge.getAllFonts();

        for(int x=0; x<names.length; x++)
            System.out.println(names[x]);

        for(int x=0; x<allFonts.length; x++){           
            System.out.println(allFonts[x].getName());
            System.out.println(allFonts[x].getFontName());
            System.out.println(allFonts[x].getFamily());
            System.out.println(allFonts[x].getPSName());
        }  
        */

        final JButton button = new JButton("Scan Value In Text Box");
        button.setName("ScanValue");
        //if( customFont != null ) button.setFont(customFont);        
        final JTextField textField = new JTextField();
        textField.setName("ScanValue");
        //if( customFont != null ) textField.setFont(customFont);        
        
        loadItems();

        JComboBox cbItems = new JComboBox(loadScannerItemBeans());
        cbItems.setName("ScannerItems");
        if (cbItems != null && cbItems.getItemCount() > 0) {
        	String label = (String) cbItems.getItemAt(0);
            String item = items.get(label);

            textField.setText(item);
        }
        cbItems.addActionListener(new ActionListener() {
            public void actionPerformed(final ActionEvent e) {
                SwingUtilities.invokeLater(new Runnable() {
                    public void run() {
                        JComboBox cb = (JComboBox) e.getSource();
                        String label = (String) cb.getSelectedItem();
                        String item = items.get(label);

                        textField.setText(item);

                    }
                });

            }
        });

        textField.setSize(200, 20);
        textField.setPreferredSize(new Dimension(200, 20));
        textField.select(0, textField.getText().length());

        button.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {

                textField.select(0, textField.getText().length());

                final byte[] textFieldValue = textField.getText().getBytes();

                Runnable r = new Runnable() {
                    public void run() {
                        if (deviceCallback.getCallbacks() != null) {
                            Scanner scanner = new Scanner();
                            DataEvent evt = new DataEvent(scanner,
                                    JposConst.JPOS_SUCCESS);

                            deviceCallback.setScanData(textFieldValue);
                            try {
                                if (deviceCallback.getAutoDisable()) {
                                    deviceCallback.setDeviceEnabled(false);
                                }
                            } catch (JposException ex) {
                                ex.printStackTrace();
                            }

                            EventCallbacks callbacks = deviceCallback
                                    .getCallbacks();
                            if (callbacks != null) {
                                callbacks.fireDataEvent(evt);
                            }
                        }
                    }
                };

                new Thread(r).start();

            }
        });

        GridBagConstraints c = new GridBagConstraints();

        addToGridBag(0, 0, 0, textField, c, this);
        addToGridBag(0, 1, 0, button, c, this);
        addToGridBag(1, 0, 2, cbItems, c, this);

        setInitialized(true);

    }

    public void loadItems() {
        SAXBuilder builder = new SAXBuilder();
        Document doc = null;
        String xmlFile = "/org/jumpmind/pos/javapos/sim/SimulatedScannerService.xml";
        File f = new File(xmlFile); 
        if(f.exists() && f.isFile()) 
        {
            try {
                doc = builder
                        .build(new InputStreamReader(SimulatedScannerService.class
                                .getResourceAsStream(xmlFile)));
                Element scanner = doc.getRootElement();
                for (Object scannerObj : scanner.getChildren()) {
                    Element itemXML = (Element) scannerObj;

                    items.put(readElement(itemXML, "label"), readElement(itemXML,
                            "id"));
                }
            } catch (Exception e) {
                logger.error("Unable to preload items from " + xmlFile);
                e.printStackTrace();
            }
        }
    }

    public Object[] loadScannerItemBeans() {
        Object[] val = null;
        if (items != null) {
            val = new TreeSet<String>(items.keySet()).toArray();
        }
        return val;
    }

}
