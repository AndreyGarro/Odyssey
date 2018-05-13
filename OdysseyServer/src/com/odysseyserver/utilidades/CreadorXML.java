package com.odysseyserver.utilidades;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

import org.jdom2.Document;
import org.jdom2.Element;
import org.jdom2.output.Format;
import org.jdom2.output.XMLOutputter;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;

import com.odysseyserver.facade.OdysseyServerFacade;
import com.odysseyserver.listas.CircularList;

/**
 * Contiene todo el funcinamiento relacionado a los XML
 * 
 * @author jorte
 *
 */
public class CreadorXML {	

	/**
	 * Crea un XML con respuesta True o False para el cliente
	 * 
	 * @param valor
	 *            true / false
	 */
	public static void responderTrueFalse(boolean valor) {
		Document document = new Document();
		Element root = new Element("Respuesta");
		Element child = new Element("valor");
		if (valor) {
			child.setText("true");
			root.addContent(child);
		} else {
			child.setText("false");
			root.addContent(child);
		}
		document.setRootElement(root);
		guardarXmlEnvio(document);
	}

	/**
	 * Guarda el XML en disco para que el server lo pueda extraer
	 * 
	 * @param doc
	 *            XML con la información a guardar
	 */
	private static void guardarXmlEnvio(Document doc) {
		XMLOutputter xmlOutputter = new XMLOutputter(Format.getPrettyFormat());
		try {
			xmlOutputter.output(doc, new FileOutputStream("data\\xmldata\\respuesta.xml"));
			OdysseyServerFacade facade = OdysseyServerFacade.getInstance();
			facade.modificarMensajeCliente();
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	public static void responderOrdenado(CircularList<Integer> listaOrden,  JSONArray jsonMusic){
		Document document =  new Document();
		Element root =  new Element("Respuesta");
		for (int i = 0; i < listaOrden.getLength(); i++) {
			Element cancion =  new Element("Cancion");
			JSONObject cancionTemp = (JSONObject) jsonMusic.get(listaOrden.find(i));
			cancion.setAttribute("nombre", (String) cancionTemp.get("nombre"));
			cancion.setAttribute("artista", (String) cancionTemp.get("artista"));
			cancion.setAttribute("album", (String) cancionTemp.get("album"));
			cancion.setAttribute("genero", (String) cancionTemp.get("genero"));
			cancion.setAttribute("ano", (String) cancionTemp.get("año"));
			cancion.setAttribute("calificacion", (String) cancionTemp.get("calificacion"));
			cancion.setAttribute("letra", (String) cancionTemp.get("letra"));
			root.addContent(cancion);
		}
		XMLOutputter xmlOutputter = new XMLOutputter(Format.getPrettyFormat());
		try {
			xmlOutputter.output(document, new FileOutputStream("data\\xmldata\\prueba.xml"));
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

}
