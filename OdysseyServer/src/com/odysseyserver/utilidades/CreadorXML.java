package com.odysseyserver.utilidades;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

import org.jdom2.Document;
import org.jdom2.Element;
import org.jdom2.output.Format;
import org.jdom2.output.XMLOutputter;

import com.odysseyserver.facade.OdysseyServerFacade;

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
		System.out.println("Entré a guardar el XML de respuesta");
		Element child = new Element("valor");
		if (valor) {
			child.setText("false");
			root.addContent(child);
		} else {
			child.setText("true");
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

}
