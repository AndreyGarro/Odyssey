using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Xml;

public class Cliente
{

    private static XmlDocument StartClient(MemoryStream mensaje)
    {
        XmlDocument xml = new XmlDocument();

        try
        {

            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

            Socket cliente = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                cliente.Connect(remoteEP);

                Console.WriteLine("Socket connected to {0}",
                    cliente.RemoteEndPoint.ToString());

                //Envio un XML con bytes
                int bytesSent = cliente.Send(mensaje.ToArray());
                /*
                // Recibo los bytes 
                MemoryStream recibido = new MemoryStream();
                int byteInPut = cliente.Receive(recibido.ToArray());

                //Convertir los bytes a XML
                MemoryStream ms = new MemoryStream(byteInPut);
                xml.Load(ms);
                Console.WriteLine(xml);
                //doc.Save("C:/Users/Christian/Desktop/pruebaCopia.xml");
                */

                cliente.Shutdown(SocketShutdown.Both);
                cliente.Close();

            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.ToString());
            }
            catch (SocketException se)
            {
                Console.WriteLine(se.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        Console.ReadKey();
        return xml;
    }
    public static void Main(String[] args)
    {
        XmlDocument xml = new XmlDocument();
        xml.Load("C:\\Users\\Christian\\Desktop\\prueba.xml");
        MemoryStream memory = new MemoryStream();
        xml.Save(memory);
        XmlDocument nuevo = StartClient(memory);


    }

    /*
    public static XmlDocument SendServidor(XmlDocument xml)
    {
        MemoryStream memory = new MemoryStream();
        xml.Save(memory);
        XmlDocument nuevo = StartClient(memory);
        return nuevo;
    }*/
}