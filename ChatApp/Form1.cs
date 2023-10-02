using System.Net;
using System.Text;
using System.Net.Sockets;

namespace ChatApp
{
    public partial class Form1 : Form
    {
        Socket sck; // Socket allow us to send and receive data.
        EndPoint epLocal, epRemote; // EndPoint encapsulates an IP address and a port number, also allow us to work with network endpoints effectively in socket porgramming.
        byte[] buffer; // this will be use for receiving and sending messages.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // setup socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //get user IP
            TextLocalIp.Text = GetLocalIP();
            TextRemoteIp.Text = GetLocalIP();
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // binding socket
            epLocal = new IPEndPoint(IPAddress.Parse(TextLocalIp.Text), Convert.ToInt32(TextLocalPort.Text));
            // binding local IP with socket
            sck.Bind(epLocal);

            // connecting with remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(TextRemoteIp.Text), Convert.ToInt32(TextRemotePort.Text));
            // connecting with socket
            sck.Connect(epRemote);

            // Listening the specific port 
            buffer = new byte[4096];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        private void MessageCallBack(IAsyncResult asyncResult)
        {
            try
            {
                // declaring byte array for receving data
                byte[] receivedData = new byte[4096];
                receivedData = (byte[])asyncResult.AsyncState;

                // converting byte[] to string 
                ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
                string receivedMessage = aSCIIEncoding.GetString(receivedData);

                // adding this message into Listbox
                listMessages.Items.Add("Friend: " + receivedMessage);

                // to call back again
                buffer = new byte[4096];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            // convert string to byte[]
            ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
            byte[] sendingMessage= new byte[4096];  
            sendingMessage = aSCIIEncoding.GetBytes(TextMessages.Text);

            // sending the Encoded message
            sck.Send(sendingMessage);

            // adding the listbox
            listMessages.Items.Add("Me: " + TextMessages.Text);
            TextMessages.Text = "";
        }
    }
}