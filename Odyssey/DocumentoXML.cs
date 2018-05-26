using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;
using System.Data;

namespace Odyssey
{
    
    class DocumentoXML
    {

        public static XmlDocument agregaCancion(String stringSong, String nombre, String artista)
        {
            XmlDocument song = new XmlDocument();

            XmlElement raiz = song.CreateElement("Cancion");
            song.AppendChild(raiz);

            XmlElement id = song.CreateElement("id");
            raiz.AppendChild(id);
            id.AppendChild(song.CreateTextNode("00"));

            XmlElement nombre1 = song.CreateElement("name");
            raiz.AppendChild(nombre1);
            nombre1.AppendChild(song.CreateTextNode(nombre));

            XmlElement artista1 = song.CreateElement("artista");
            raiz.AppendChild(artista1);
            artista1.AppendChild(song.CreateTextNode(artista));

            XmlElement cancion = song.CreateElement("song");
            raiz.AppendChild(cancion);
            cancion.AppendChild(song.CreateTextNode(stringSong));


            //song.Save("Xml/song.xml");

            return song;
        }

        public static XmlDocument ingresaUsuario(String user, String pass)
        {
            XmlDocument sesion = new XmlDocument();

            XmlElement raiz = sesion.CreateElement("Inicio");
            sesion.AppendChild(raiz);

            XmlElement id = sesion.CreateElement("id");
            id.AppendChild(sesion.CreateTextNode("01"));
            raiz.AppendChild(id);

            XmlElement usuario = sesion.CreateElement("Usuario");
            raiz.AppendChild(usuario);

            XmlElement nombreUsuario = sesion.CreateElement("NombreUsuario");
            XmlElement contrasena = sesion.CreateElement("Contrasena");
            nombreUsuario.AppendChild(sesion.CreateTextNode(user));
            usuario.AppendChild(nombreUsuario);
            contrasena.AppendChild(sesion.CreateTextNode(pass));
            usuario.AppendChild(contrasena);

            //sesion.Save("Xml\\sesion.xml");
            return sesion;
        }

        public static XmlDocument registraUsuario(String username, String nombres, String edad, String pass, String generos)
        {
            XmlDocument nuevoUsuario = new XmlDocument();
            XmlElement raiz = nuevoUsuario.CreateElement("Inicio");
            nuevoUsuario.AppendChild(raiz);
            

            XmlElement id = nuevoUsuario.CreateElement("id");
            id.AppendChild(nuevoUsuario.CreateTextNode("00"));
            raiz.AppendChild(id);

            XmlElement user = nuevoUsuario.CreateElement("NombreUsuario");
            user.AppendChild(nuevoUsuario.CreateTextNode(username));
            raiz.AppendChild(user);

            XmlElement nombreApellido = nuevoUsuario.CreateElement("NombreApellidos");
            nombreApellido.AppendChild(nuevoUsuario.CreateTextNode(nombres));
            raiz.AppendChild(nombreApellido);

            XmlElement edad1 = nuevoUsuario.CreateElement("Edad");
            edad1.AppendChild(nuevoUsuario.CreateTextNode(edad));
            raiz.AppendChild(edad1);

            XmlElement password = nuevoUsuario.CreateElement("Contrasena");
            password.AppendChild(nuevoUsuario.CreateTextNode(pass));
            raiz.AppendChild(password);

            XmlElement generos1 = nuevoUsuario.CreateElement("Generos");
            generos1.AppendChild(nuevoUsuario.CreateTextNode(generos));
            raiz.AppendChild(generos1);

            //nuevoUsuario.Save("Xml\\nuevoUsuario.xml");
            return nuevoUsuario;
        }

        public static XmlDocument ordenamiento(String tipo)
        {
            XmlDocument orden = new XmlDocument();
            XmlElement raiz = orden.CreateElement("Ordenar");
            orden.AppendChild(raiz);

            XmlElement id = orden.CreateElement("id");
            id.AppendChild(orden.CreateTextNode(tipo));
            raiz.AppendChild(id);

            orden.Save("orden.xml");
            return orden;

        }

        public static XmlDocument listaAmigos(String usuarioActual)
        {
            XmlDocument lista = new XmlDocument();
            XmlElement raiz = lista.CreateElement("Amigo");
            lista.AppendChild(raiz);

            XmlElement id = lista.CreateElement("id");
            id.AppendChild(lista.CreateTextNode("01"));
            raiz.AppendChild(id);

            XmlElement solicitar = lista.CreateElement("usuario");
            solicitar.AppendChild(lista.CreateTextNode(usuarioActual));
            raiz.AppendChild(solicitar);

            return lista;
        }

        public static XmlDocument nuevoAmigo(String usuarioActual, String amigo)
        {
            XmlDocument nuevoXml = new XmlDocument();

            XmlElement raiz = nuevoXml.CreateElement("Amigo");
            nuevoXml.AppendChild(raiz);

            XmlElement id = nuevoXml.CreateElement("id");
            id.AppendChild(nuevoXml.CreateTextNode("00"));
            raiz.AppendChild(id);

            XmlElement usuarioActual1 = nuevoXml.CreateElement("usuario");
            usuarioActual1.AppendChild(nuevoXml.CreateTextNode(usuarioActual));
            raiz.AppendChild(usuarioActual1);

            XmlElement amigo1 = nuevoXml.CreateElement("amigo");
            amigo1.AppendChild(nuevoXml.CreateTextNode(amigo));
            raiz.AppendChild(amigo1);

            return nuevoXml;
        }

        public static XmlDocument recomendar(String usuarioActual, String amigo, String cancion, String artista)
        {
            XmlDocument recomendar = new XmlDocument();

            XmlElement raiz = recomendar.CreateElement("Amigo");
            recomendar.AppendChild(raiz);

            XmlElement id = recomendar.CreateElement("id");
            id.AppendChild(recomendar.CreateTextNode("03"));
            raiz.AppendChild(id);

            XmlElement usuarioActual1 = recomendar.CreateElement("usuario");
            usuarioActual1.AppendChild(recomendar.CreateTextNode(usuarioActual));
            raiz.AppendChild(usuarioActual1);

            XmlElement amigo1 = recomendar.CreateElement("amigo");
            amigo1.AppendChild(recomendar.CreateTextNode(amigo));
            raiz.AppendChild(amigo1);

            XmlElement cancion1 = recomendar.CreateElement("cancion");
            cancion1.AppendChild(recomendar.CreateTextNode(cancion));
            raiz.AppendChild(cancion1);

            XmlElement artista1 = recomendar.CreateElement("artista");
            artista1.AppendChild(recomendar.CreateTextNode(artista));
            raiz.AppendChild(artista1);

            return recomendar;
        }

        public static XmlDocument notificaciones(String usuarioActual)
        {
            XmlDocument notificacion = new XmlDocument();

            XmlElement raiz = notificacion.CreateElement("Amigo");
            notificacion.AppendChild(raiz);

            XmlElement id = notificacion.CreateElement("id");
            id.AppendChild(notificacion.CreateTextNode("02"));
            raiz.AppendChild(id);

            XmlElement usuarioActual1 = notificacion.CreateElement("usuario");
            usuarioActual1.AppendChild(notificacion.CreateTextNode(usuarioActual));
            raiz.AppendChild(usuarioActual1);

            return notificacion;
        }

        public static XmlDocument solicitarCancion(String cancion, String artista)
        {
            XmlDocument solicitar = new XmlDocument();

            XmlElement raiz = solicitar.CreateElement("Reproducir");
            solicitar.AppendChild(raiz);

            XmlElement id = solicitar.CreateElement("id");
            id.AppendChild(solicitar.CreateTextNode("00"));
            raiz.AppendChild(id);

            XmlElement cancion1 = solicitar.CreateElement("cancion");
            cancion1.AppendChild(solicitar.CreateTextNode(cancion));
            raiz.AppendChild(cancion1);

            XmlElement artista1 = solicitar.CreateElement("artista");
            artista1.AppendChild(solicitar.CreateTextNode(artista));
            raiz.AppendChild(artista1);

            solicitar.Save("cancion.xml");
            return solicitar;
        }

        public static XmlDocument modificarData(String nombreActual, String artistaActual, String nombre, 
            String artista, String album, String genero, String calificacion)
        {
            XmlDocument modificar = new XmlDocument();

            XmlElement raiz = modificar.CreateElement("Cancion");
            modificar.AppendChild(raiz);

            XmlElement id = modificar.CreateElement("id");
            id.AppendChild(modificar.CreateTextNode("01"));
            raiz.AppendChild(id);

            XmlElement actual = modificar.CreateElement("actual");
            raiz.AppendChild(actual);

            XmlElement nombreActual1 = modificar.CreateElement("nombre");
            nombreActual1.AppendChild(modificar.CreateTextNode(nombreActual));
            actual.AppendChild(nombreActual1);

            XmlElement artistaActual1 = modificar.CreateElement("artista");
            artistaActual1.AppendChild(modificar.CreateTextNode(artistaActual));
            actual.AppendChild(artistaActual1);

            XmlElement nuevo = modificar.CreateElement("nuevo");
            raiz.AppendChild(nuevo);

            XmlElement nuevoNombre = modificar.CreateElement("nombre");
            nuevoNombre.AppendChild(modificar.CreateTextNode(nombre));
            nuevo.AppendChild(nuevoNombre);

            XmlElement nuevoArtista = modificar.CreateElement("artista");
            nuevoArtista.AppendChild(modificar.CreateTextNode(artista));
            nuevo.AppendChild(nuevoArtista);

            XmlElement nuevoAlbum = modificar.CreateElement("album");
            nuevoAlbum.AppendChild(modificar.CreateTextNode(album));
            nuevo.AppendChild(nuevoAlbum);

            XmlElement nuevoGenero = modificar.CreateElement("genero");
            nuevoGenero.AppendChild(modificar.CreateTextNode(genero));
            nuevo.AppendChild(nuevoGenero);

            XmlElement nuevaCalificacion = modificar.CreateElement("calificacion");
            nuevaCalificacion.AppendChild(modificar.CreateTextNode(calificacion));
            nuevo.AppendChild(nuevaCalificacion);

            modificar.Save("modificar.xml");

            return modificar;

        }
    }
}
