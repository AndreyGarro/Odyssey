package com.odysseyserver.server;

import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.ServerSocket;
import java.net.Socket;
import java.nio.file.Files;

import org.jdom2.Document;
import org.jdom2.JDOMException;
import org.jdom2.input.SAXBuilder;

import com.odysseyserver.facade.OdysseyServerFacade;

public class Server implements Runnable {
	
	private byte[] SendMessage;
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

		while (true) {

			try {
				Socket client = serverSocket.accept();
				
				BufferedReader scanner = new BufferedReader(new InputStreamReader(client.getInputStream()));

				
				String xmlLine = "";
				String xml = "";
				while(xmlLine != null) {
					xml += xmlLine;
					xmlLine = scanner.readLine();				
				}
				
				byte[] buffer = xml.getBytes();

				FileOutputStream nuevoMensaje = new FileOutputStream("data\\xmldata\\nuevoMensaje.xml");

				nuevoMensaje.write(buffer);

				Document info = conversorXML("data\\xmldata\\nuevoMensaje.xml");
				
				facade.administrarXML(info);
				
				client.close();	
				Socket clienteEnviar = serverSocket.accept();
				
				while(SendMessage == null) {
					System.out.println("Entró a modificar");
					sendCliente();
				}
				
				DataOutputStream send = new DataOutputStream(clienteEnviar.getOutputStream());
				send.write(SendMessage);
				
				System.out.println("Enviado");
				SendMessage = null;
				send.close();
				clienteEnviar.close();			

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

	public void sendCliente() {
		try {
			this.SendMessage = Files.readAllBytes(new File("data\\xmldata\\nuevoMensaje.xml").toPath());
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}