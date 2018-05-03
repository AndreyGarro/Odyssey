package com.odysseyserver.main;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

import org.jdom2.Document;
import org.jdom2.Element;
import org.jdom2.output.Format;
import org.jdom2.output.XMLOutputter;

import com.odysseyserver.facade.OdysseyServerFacade;


public class OdysseyLauncher {
	
	public static void main(String [] args) throws FileNotFoundException, IOException {
		
		// Crear documento 
		Document doc = new Document();
		
		// Raíz 
		Element root = new Element("Inicio");
		
		// ID
		Element id = new Element("id")
				.setAttribute("opCode", "01");
		
		// Canción
		Element data = new Element("data")
				.addContent(new Element("username", "ortegajosant"))
				.setAttribute("password", "12345678")
				.setAttribute("name", "Jose Antonio")
				.setAttribute("lastname", "Ortega González");
		doc.setRootElement(root);
		root.addContent(id);
		root.addContent(data);
		
		OdysseyServerFacade.administrarXML(doc);
		
	}
	
	public static void createXML(Document doc) throws FileNotFoundException, IOException {
		XMLOutputter xmlOutputter = new XMLOutputter(Format.getPrettyFormat());
		xmlOutputter.output(doc, new FileOutputStream("data/xmldata/prueba3.xml"));
		System.out.println("Se guardó con éxito");
		System.out.println(doc.getRootElement().getName());
		System.out.println(doc.getRootElement().getChild("data").getAttribute("username").getValue());
		System.out.println(doc.getRootElement().getChild("data").getAttribute("password").getValue());
		System.out.println(doc.getRootElement().getChild("data").getAttribute("name").getValue());
		System.out.println(doc.getRootElement().getChild("data").getAttribute("lastname").getValue());
	}
	
	

}
