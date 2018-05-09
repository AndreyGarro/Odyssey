using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Odyssey
{
    class DocumentoXML : XmlDocument
    {

        public static XmlDocument agregaCancion(String stringSong)
        {
            XmlDocument song = new XmlDocument();

            XmlElement raiz = song.CreateElement("Cancion");
            song.AppendChild(raiz);

            XmlElement id = song.CreateElement("id");
            raiz.AppendChild(id);
            id.AppendChild(song.CreateTextNode("00"));

            XmlElement nombre = song.CreateElement("name");
            raiz.AppendChild(nombre);
            nombre.AppendChild(song.CreateTextNode("nombreCancion"));

            XmlElement cancion = song.CreateElement("song");
            raiz.AppendChild(cancion);
            cancion.AppendChild(song.CreateTextNode(stringSong));

            song.Save("Xml/song.xml");

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
    }
}
