using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Xml;

public class SocketCliente    
{
    private static XmlDocument mensajeEntregado;

    private static void StartClient(MemoryStream mensaje)
    {
        TcpClient cliente = new TcpClient();
        mensajeEntregado = new XmlDocument();
        cliente.Connect("192.168.43.173", 11000);


        Stream stream = cliente.GetStream(); 

        // Envía el mensaje en byte[]

        byte[] enviar = mensaje.ToArray();

        stream.Write(enviar, 0, enviar.Length);


        stream.Flush();
        stream.Close();
        cliente.Close();

        TcpClient cliente2 = new TcpClient();
        cliente2.Connect("192.168.43.173", 11000);
        Stream stream1 = cliente2.GetStream();
        
        StreamReader respuesta = new StreamReader(stream1);

        string respuestaStr = "";
        string respuestaXML = "";
        while(respuestaStr != null)
        {
            respuestaStr = respuesta.ReadLine();
            respuestaXML += respuestaStr;
        }

        XmlDocument mensajeFinal = new XmlDocument();
        mensajeFinal.LoadXml(respuestaXML);
  
        
        cliente2.Close();

        mensajeEntregado = mensajeFinal;

    }

    public static XmlDocument SendServidor(XmlDocument xml)
    {
        MemoryStream mensaje = new MemoryStream();
        xml.Save(mensaje);
        var th1 = new Thread(()=>StartClient(mensaje));
        th1.Start();
        th1.Join();
        return mensajeEntregado;
    }
}       