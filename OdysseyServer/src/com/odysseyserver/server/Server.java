package com.odysseyserver.server;

import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.StringReader;
import java.net.ServerSocket;
import java.net.Socket;
import java.nio.file.Files;

import org.jdom2.Document;
import org.jdom2.JDOMException;
import org.jdom2.input.SAXBuilder;

import com.odysseyserver.facade.OdysseyServerFacade;

/**
 * Servidor de OdysseyServer, procesa todo el funcionamiento de recibir y enviar
 * mensajes
 * 
 * @author jorte
 *
 */
public class Server implements Runnable {

	private byte[] SendMessage;
	private static Server instance;
	private ServerSocket serverSocket;
	private OdysseyServerFacade facade;

	private Server() {
		SendMessage = null;

		try {
			serverSocket = new ServerSocket(11000, 10);
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	public static Server getInstance() {
		if (instance == null) {
			instance = new Server();
		}
		return instance;
	}

	/**
	 * Se inicia el servidor para que procese la petición del cliente
	 */
	public void run() {
		
		facade = OdysseyServerFacade.getInstance();

		while (true) {

			try {
				Socket client = serverSocket.accept();

				// Recibe el mensaje
				BufferedReader scanner = new BufferedReader(new InputStreamReader(client.getInputStream()));
				String xmlLine = "";
				String xml = "";
				while (xmlLine != null) {
					xml += xmlLine;
					xmlLine = scanner.readLine();
				}

				// Se crea el XML a partir del String que llegó
				SAXBuilder sb = new SAXBuilder();
				Document info = sb.build(new StringReader(xml));

				// Se envía el nuevo XML al Facade para que se procese el trabajo
				facade.administrarXML(info);

				client.close();
				Socket clienteEnviar = serverSocket.accept();

				// Se espera a que el programa modifique el mensaje a responder para el cliente
				while (SendMessage == null) {
				}

				// Se envía el mensaje
				DataOutputStream send = new DataOutputStream(clienteEnviar.getOutputStream());
				send.write(SendMessage);

				// Se restablece el mensaje a enviar a nulo para evitar distintos problemas de
				// envío
				SendMessage = null;
				send.close();
				clienteEnviar.close();

			} catch (IOException e) {
				e.printStackTrace();
			} catch (JDOMException e) {
				e.printStackTrace();
			}
		}
	}

	/**
	 * Se modifica el valor del XML a enviar para el cliente
	 */
	public void sendCliente() {
		try {
			this.SendMessage = Files.readAllBytes(new File("data\\xmldata\\respuesta.xml").toPath());
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}