package com.odysseyserver.facade;

import java.io.IOException;

import org.jdom2.Document;

import com.odysseyserver.musicmanagement.GeneradorMusica;

public abstract class OdysseyServerFacade {

	public OdysseyServerFacade() {

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
	public static void administrarXML(Document doc) throws IOException {
		String id;
		switch (doc.getRootElement().getName()) {
		case "Inicio":
			id = doc.getRootElement().getChild("id").getText();
			if (id.equals("00")) {
				System.out.println("Registrar");
			} else if (id.equals("01")) {
				System.out.println("Inicia sesión");
			} else {
				throw new IOException();
			}
			break;
		case "Cancion":
			id = doc.getRootElement().getChild("id").getText();
			switch (id) {
			case "00":
				GeneradorMusica.guardarCancion(doc);
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
			id = doc.getRootElement().getChild("id").getAttribute("opCode").getValue();
			switch (id) {
			case "00":
				break;
			case "01":
				break;
			case "02":
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

}