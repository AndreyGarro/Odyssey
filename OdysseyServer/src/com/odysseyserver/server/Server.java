package com.odysseyserver.server;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Scanner;

import org.jdom2.Document;
import org.jdom2.JDOMException;
import org.jdom2.input.SAXBuilder;

import com.odysseyserver.facade.OdysseyServerFacade;


public class Server extends Thread{
    public static void main(String[] args) throws Exception {
        ServerSocket serversocket = new ServerSocket(11000, 10);
		while (true) {
				Socket client = serversocket.accept();
				
				Scanner scanner = new Scanner(client.getInputStream());
				
				
				String xmlLine;
				String xml = "";
				
				while(true) {
					xmlLine = scanner.nextLine();
					xml += xmlLine+"\n";
					if (xmlLine.equals("</Cancion>")) {
						break;
					}					
				}
				
				byte[] buffer = xml.getBytes();
				
				FileOutputStream nuevoMensaje = new FileOutputStream("data/xmldata/nuevaCancion2.xml");
				
				nuevoMensaje.write(buffer);
				
				Document info = conversorXML("C:\\Users\\jorte\\Documents\\Algoritmos y estructuras de datos I\\Proyecto II\\OdysseyServer\\data\\xmldata\\nuevaCancion2.xml");
	            OdysseyServerFacade.administrarXML(info);
				
				client.close();
			}

		}
	
    public static org.jdom2.Document conversorXML(String fileName) throws JDOMException, IOException {
		SAXBuilder saxBuilder = new SAXBuilder();
		return saxBuilder.build(new File(fileName));
	}
}