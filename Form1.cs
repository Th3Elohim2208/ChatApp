using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient; // Solo una declaración
        private int listenPort;

        public Form1(int port)
        {
            InitializeComponent();
            InitializeSocket(port);
        }

        private void InitializeSocket(int port)
        {
            listenPort = port;
            try
            {
                udpClient = new UdpClient(listenPort); // Inicializa udpClient en el puerto especificado
                Thread receiveThread = new Thread(new ThreadStart(ReceiveMessages));
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"Error initializing socket: {ex.Message}");
                this.Close(); // Cierra el formulario si el puerto está en uso
            }
        }

        private void ReceiveMessages()
        {
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, listenPort);
            while (true)
            {
                byte[] data = udpClient.Receive(ref remoteEP);
                string message = Encoding.UTF8.GetString(data);
                this.Invoke(new MethodInvoker(delegate
                {
                    listBoxMessages.Items.Add($"Received from {remoteEP.Port}: {message}");
                }));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            udpClient?.Close(); // Cierra el cliente si no es nulo
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int destPort;
            if (int.TryParse(textBoxPort.Text, out destPort))
            {
                string message = textBoxMessage.Text;
                byte[] data = Encoding.UTF8.GetBytes(message);
                udpClient.Send(data, data.Length, "127.0.0.1", destPort);
                listBoxMessages.Items.Add($"Sent to {destPort}: {message}");
            }
            else
            {
                MessageBox.Show("Invalid port number");
            }
        }
    }
}
