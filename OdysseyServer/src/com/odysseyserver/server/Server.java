package com.odysseyserver.server;

import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.DataInputStream;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;

import org.jdom2.Document;
import org.jdom2.JDOMException;
import org.jdom2.input.SAXBuilder;
import org.xml.sax.SAXException;

import com.sun.org.apache.xerces.internal.impl.dv.util.Base64;


public class Server extends Thread{
    public static void main(String[] args) throws Exception {
        
        ServerSocket serversocket = new ServerSocket(11000, 10);
        DataInputStream in;
		while (true) {
				Socket client = serversocket.accept();
				
				in = new DataInputStream(client.getInputStream());
				
				//String mensaje = in.readUTF();
									
				byte[] buffer = new byte[146];
	            in.read(buffer);
	            
	           
	            FileOutputStream nuevoMensaje = new FileOutputStream("data/xmldata/nuevaCancion.xml");
	            
	            System.out.println("Hola3");
	            
	            nuevoMensaje.write(buffer);
	            
	            Document info = conversorXML("C:\\Users\\Christian\\Desktop\\Odyssey\\OdysseyServer\\data\\xmldata\\nuevaCancion.xml");
	            System.out.println(info);
	            System.out.println(info.getClass());
	            System.out.println("");
	            
	            client.close();
			}

		}
		
    public static org.jdom2.Document conversorXML(String fileName) throws JDOMException, IOException {
		SAXBuilder saxBuilder = new SAXBuilder();
		return saxBuilder.build(new File(fileName));
	}
}