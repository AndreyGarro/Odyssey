package com.odysseyserver.server;

import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Scanner;

import org.jdom2.Document;
import org.jdom2.JDOMException;
import org.jdom2.input.SAXBuilder;

import com.odysseyserver.facade.OdysseyServerFacade;

public class Server implements Runnable {
	
	private Document SendMessage;
	private ServerSocket serverSocket;

	public Server() {
		SendMessage = null;

		try {
			serverSocket = new ServerSocket(11000, 10);
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	public void run() {
		OdysseyServerFacade facade = OdysseyServerFacade.getInstance();
		ServerSocket serversocket = null;

		while (true) {

			try {
				Socket client = serversocket.accept();
				Scanner scanner = new Scanner(client.getInputStream());

				String xmlLine;
				String xml = "";

				while (true) {
					xmlLine = scanner.nextLine();
					xml += xmlLine + "\n";
					if (xmlLine.equals("</Cancion>") || xmlLine.equals("</Inicio>") || xmlLine.equals("</Reproducir>")
							|| xmlLine.equals("</Busqueda>") || xmlLine.equals("</Navegar>")
							|| xmlLine.equals("</Ordenar>") || xmlLine.equals("</Amigo>")) {
						break;
					}
				}

				byte[] buffer = xml.getBytes();

				FileOutputStream nuevoMensaje = new FileOutputStream("data\\xmldata\\nuevoMensaje.xml");

				nuevoMensaje.write(buffer);

				Document info = conversorXML("data\\xmldata\\nuevoMensaje.xml");

				facade.administrarXML(info);

				while (SendMessage == null) {
				}

				PrintWriter pw = new PrintWriter(client.getOutputStream(), true);
				pw.println(converseByte(SendMessage));
				
				SendMessage = null;
				
				client.close();
				

			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			} catch (JDOMException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}

	}

	public org.jdom2.Document conversorXML(String fileName) throws JDOMException, IOException {
		SAXBuilder saxBuilder = new SAXBuilder();
		return saxBuilder.build(new File(fileName));
	}

	public void sendCliente(Document sendMessage) {
		this.SendMessage = sendMessage;
	}

	private byte[] converseByte(Document messageToArray) throws IOException {
		ByteArrayOutputStream out = new ByteArrayOutputStream();
		ObjectOutputStream os = new ObjectOutputStream(out);
		os.writeObject(messageToArray);
		return out.toByteArray();
	}

}