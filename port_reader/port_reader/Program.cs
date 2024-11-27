// See https://aka.ms/new-console-template for more information
using System.IO.Ports;

Console.WriteLine("Hello, World!");


string input = "";

SerialPort port = new SerialPort("COM7", 9600, Parity.None, 8, StopBits.One);
Console.WriteLine("Incoming Data:");
port.DataReceived += new
SerialDataReceivedEventHandler(port_DataReceived);
port.Open();
input = port.ReadLine();
Console.Read();

 void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
{
    int count = 10;// port.BytesToRead;
    byte[] ByteArray = new byte[count];
    port.Read(ByteArray, 0, count);
    Console.WriteLine(input);
    Console.WriteLine("----");
}