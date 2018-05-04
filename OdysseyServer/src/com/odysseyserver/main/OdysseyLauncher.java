package com.odysseyserver.main;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.nio.file.Files;

import org.jdom2.Document;
import org.jdom2.Element;
import org.jdom2.JDOMException;
import org.jdom2.input.SAXBuilder;
import org.jdom2.output.Format;
import org.jdom2.output.XMLOutputter;

import com.odysseyserver.facade.OdysseyServerFacade;
import com.sun.org.apache.xerces.internal.impl.dv.util.Base64;

public class OdysseyLauncher {

	public static void main(String[] args) throws FileNotFoundException, IOException, JDOMException {

		// Crear documento
		Document doc = new Document();

		// Raíz
		Element root = new Element("Cancion");

		// ID
		Element id = new Element("id").setText("00");

		// Canción
		
		byte[] song = getByteSongArray(new File("C:\\Users\\jorte\\Desktop\\Live In the moment.mp3"));
		String songString = Base64.encode(song);
		Element nombre = new Element("name").setText( "Live in the moment.mp3");
		Element data = new Element("song").setText(songString);
				
		doc.setRootElement(root);
		root.addContent(id);
		root.addContent(nombre);
		root.addContent(data);

		System.out.println(id.getText());
		
		createXML(doc);
		
		OdysseyServerFacade.administrarXML(doc);

		

	}

	public static void createXML(Document doc) throws FileNotFoundException, IOException {
		XMLOutputter xmlOutputter = new XMLOutputter(Format.getPrettyFormat());
		xmlOutputter.output(doc, new FileOutputStream("data/xmldata/prueba3.xml"));
		System.out.println("Se guardó con éxito");
//		 System.out.println(doc.getRootElement().getName());
//		 System.out.println(doc.getRootElement().getChild("data").getAttributeValue("username"));
//		 System.out.println(doc.getRootElement().getChild("data").getAttributeValue("password"));
//		 System.out.println(doc.getRootElement().getChild("data").getAttributeValue("name"));
//		 System.out.println(doc.getRootElement().getChild("data").getAttributeValue("lastname"));
	}

	private static org.jdom2.Document useSAXParser(String fileName) throws JDOMException, IOException {
		SAXBuilder saxBuilder = new SAXBuilder();
		return saxBuilder.build(new File(fileName));
	}
	
	public static byte[] getByteSongArray(File f) throws IOException {
		byte[] buff = Files.readAllBytes(f.toPath());
		
		System.out.println(buff.length);
		return buff;
	}

}
