package com.odysseyserver.usermanagement;

import org.jdom2.Document;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;

import com.odysseyserver.tools.CreadorXML;

public class GestorAmigos {

	/**
	 * Agrega un nuevo amigo al usuario respectivo
	 * 
	 * @param xmlDoc
	 *            Documento XML con la información
	 * @param listaUsuarios
	 *            JSONArray que contiene los usuarios
	 */
	public static void agregarAmigo(Document xmlDoc, JSONArray listaUsuarios) {

		String nombreUsuario = (String) xmlDoc.getRootElement().getChildText("usuario");
		String amigoUsuario = (String) xmlDoc.getRootElement().getChildText("amigo");
		boolean agregado = false;
		for (int i = 0; i < listaUsuarios.size(); i++) {
			String amigo = (String) ((JSONObject) (listaUsuarios.get(i))).get("username");
			System.out.println(amigoUsuario + " " + amigo);
			if (amigoUsuario.equals(amigo)) {
				for (int j = 0; j < listaUsuarios.size(); j++) {
					JSONObject usuarioTemp = (JSONObject) (listaUsuarios.get(j));
					System.out.println("Entró " + (String) usuarioTemp.get("username"));
					if (nombreUsuario.equals((String) usuarioTemp.get("username"))) {
						JSONArray tempList = (JSONArray) (usuarioTemp.get("amigos"));
						if (!tempList.contains(amigoUsuario)) {
							tempList.add(amigoUsuario);
							System.out.println("ArrayUsuario " + tempList.toJSONString());
							usuarioTemp.replace("amigos", tempList);
							listaUsuarios.set(j, usuarioTemp);
							agregado = true;
							GestorJSONUsuario.reescribirXML(listaUsuarios);
						} else {
							CreadorXML.responderTrueFalse(false);
						}
						break;
					}
				}
				break;
			}
		}

		if (agregado) {
			CreadorXML.responderTrueFalse(true);
		} else {
			CreadorXML.responderTrueFalse(false);
		}

	}

	/**
	 * Retorna lista de amigos que tiene el usuario
	 * 
	 * @param xmlDocument
	 *            XML con la información de solicitud
	 * @param listaUsuarios
	 *            Usuarios registrados
	 */
	public static void retornarListaAmigos(Document xmlDocument, JSONArray listaUsuarios) {
		String usuario = xmlDocument.getRootElement().getChildText("usuario");
		JSONArray amigos = null;
		for (int i = 0; i < listaUsuarios.size(); i++) {
			JSONObject usuarioTemp = (JSONObject) (listaUsuarios.get(i));
			System.out.println((String) usuarioTemp.get("username") + " " + usuario);
			if (usuario.equals((String) usuarioTemp.get("username"))) {
				amigos = (JSONArray) usuarioTemp.get("amigos");
				break;
			}
		}
		if (amigos != null) {
			if (amigos.size() != 0) {
				CreadorXML.responderAmigos(amigos, listaUsuarios);
			} else {
				CreadorXML.responderTrueFalse(false);
			}
		} else {
			CreadorXML.responderTrueFalse(false);
		}
	}

	/**
	 * Agrega una nueva recomendacion a un usuario
	 * 
	 * @param xmlDoc
	 *            Documento XML con la información
	 * @param listaUsuarios
	 *            JSONArray que contiene los usuarios
	 */
	@SuppressWarnings("unchecked")
	public static void recomendar(Document xmlDoc, JSONArray listaUsuarios) {
		String usuario = (String) xmlDoc.getRootElement().getChildText("usuario");
		String amigo = (String) xmlDoc.getRootElement().getChildText("amigo");
		String recomendacion = (String) xmlDoc.getRootElement().getChildText("cancion");
		String artista = (String) xmlDoc.getRootElement().getChildText("artista");
		for (int i = 0; i < listaUsuarios.size(); i++) {
			JSONObject temp = (JSONObject) (listaUsuarios.get(i));
			System.out.println(amigo + " " + (String) temp.get("username"));
			if (amigo.equals((String) temp.get("username"))) {
				JSONArray recomendaciones = (JSONArray) temp.get("notificacion");
				recomendaciones
						.add(usuario + " te ha recomendado " + recomendacion + " de " + artista + " escúchala ya.");
				temp.replace("notificacion", recomendaciones);
				listaUsuarios.set(i, temp);
				GestorJSONUsuario.reescribirXML(listaUsuarios);
				System.out.println(recomendaciones.toJSONString());
				CreadorXML.responderTrueFalse(true);
				break;
			}
		}
	}

	/**
	 * Notifica al usuario las recomendaciones que le han mostrado
	 * 
	 * @param xmlDoc
	 *            Documento XML con la informacion
	 * @param listaUsuarios
	 *            Usuarios registrados en la aplicacion
	 */
	@SuppressWarnings("unchecked")
	public static void notificar(Document xmlDoc, JSONArray listaUsuarios) {
		String usuario = (String) xmlDoc.getRootElement().getChildText("usuario");
		JSONArray notificaciones = null;
		for (int i = 0; i < listaUsuarios.size(); i++) {
			JSONObject temp = (JSONObject) listaUsuarios.get(i);
			if (usuario.equals((String) temp.get("username"))) {
				notificaciones = (JSONArray) temp.get("notificacion");
				temp.replace("notificacion", new JSONArray());
				listaUsuarios.set(i, temp);
				GestorJSONUsuario.reescribirXML(listaUsuarios);
				break;
			}
		}

		if (notificaciones != null) {
			if (notificaciones.size() != 0) {
				CreadorXML.responderNotificacion(notificaciones);
			} else {
				CreadorXML.responderTrueFalse(false);
			}

		} else {
			CreadorXML.responderTrueFalse(false);
		}
	}

}
