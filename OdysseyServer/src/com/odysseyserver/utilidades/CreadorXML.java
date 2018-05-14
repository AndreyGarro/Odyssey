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
	 *            XML con la informaci�n a guardar
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
			cancion.addContent(new Element("nombre").setText((String) cancionTemp.get("nombre")));
			cancion.addContent(new Element("artista").setText((String) cancionTemp.get("artista")));
			cancion.addContent(new Element("album").setText((String) cancionTemp.get("album")));
			cancion.addContent(new Element("genero").setText((String) cancionTemp.get("genero")));
			cancion.addContent(new Element("ano").setText(cancionTemp.get("a�o").toString()));
			cancion.addContent(new Element("calificacion").setText(cancionTemp.get("calificacion").toString()));
			cancion.addContent(new Element("letra").setText((String) cancionTemp.get("letra")));
			root.addContent(cancion);	
		}
		document.addContent(root);
		guardarXmlEnvio(document);
	}

}
