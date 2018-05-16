package com.odysseyserver.facade;

import java.io.IOException;

import org.jdom2.Document;

import com.odysseyserver.musicmanagement.GestorMusica;
import com.odysseyserver.server.Server;
import com.odysseyserver.usermanagement.GestorUsuario;

/**
 * Facade del servidor, este administra todos los procesos y solicitudes del
 * cliente, distribuye las tareas.
 * 
 * @author jorte
 *
 */
public class OdysseyServerFacade {

	private static OdysseyServerFacade instance;
	private GestorUsuario gestorUsuario;
	private GestorMusica gestorMusical;
	private Server servidor;

	private OdysseyServerFacade() {
		servidor = Server.getInstance();
		gestorMusical = GestorMusica.getInstance();
		gestorUsuario = GestorUsuario.getInstance();
	}

	public static OdysseyServerFacade getInstance() {
		if (instance == null) {
			instance = new OdysseyServerFacade();
		}
		return instance;
	}

	/**
	 * Recibe un documento XML que será evaluado para conocer el proceso que hará el
	 * servidor, este distribuirá la acción a la clase correspondiente.
	 * 
	 * @param doc
	 *            Document / Documento XML
	 * @throws IOException
	 *             Error en opCode
	 */
	public void administrarXML(Document doc) throws IOException {
		String id;
		switch (doc.getRootElement().getName()) {
		case "Inicio":
			id = doc.getRootElement().getChild("id").getText();
			if (id.equals("00")) {
				System.out.println("Registrar");
				gestorUsuario.registrar(doc);
			} else if (id.equals("01")) {
				System.out.println("Inicia sesión");
				gestorUsuario.verificarSesion(doc);
			} else {
				throw new IOException();
			}
			break;
		case "Cancion":
			id = doc.getRootElement().getChild("id").getText();
			switch (id) {
			case "00":
				System.out.println("Agregar Cancion");
				gestorMusical.agregarCancion(doc);
				break;
			case "01":
				break;
			case "02":
				break;
			case "03":
				break;
			default:
				throw new IOException("Error en opCode");
			}
			break;
		case "Reproducir":
			id = doc.getRootElement().getChild("id").getName();
			if (id.equals("00")) {

			} else if (id.equals("01")) {

			} else {
				throw new IOException("Error en opCode");
			}
			break;
		case "Busqueda":
			id = doc.getRootElement().getChild("id").getAttribute("opCode").getValue();
			switch (id) {
			case "00":
				break;
			case "01":
				break;
			case "02":
				break;
			case "03":
				break;
			default:
				throw new IOException("Error en opCode");
			}
			break;
		case "Navegar":
			break;
		case "Ordenar":
			id = doc.getRootElement().getChild("id").getText();
			switch (id) {
			case "00":
				gestorMusical.ordenarCancion();
				break;
			case "01":
				break;
			case "02":
				gestorMusical.ordenarAlbum();
				break;
			default:
				throw new IOException("Error en opCode");
			}
			break;
		case "Amigo":
			id = doc.getRootElement().getChild("id").getAttribute("opCode").getValue();
			if (id.equals("00")) {

			} else if (id.equals("01")) {

			} else {
				throw new IOException("Error en opCode");
			}
			break;
		default:
			throw new IOException("Raíz inválida");
		}
	}

	/*
	 * Modifica la información (XML) que se le enviará al cliente
	 */
	public void modificarMensajeCliente() {
		servidor.sendCliente();
	}

}