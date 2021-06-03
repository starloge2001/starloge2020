using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ChatServerForm : Form
    {
        public string bufferedList;
        public List<string> users = new List<string>();
        TcpListener server;
        public void AddText(string text)
        {
            myConsole.AppendText(text);
            myConsole.Select(myConsole.Text.Length, 0);
            myConsole.ScrollToCaret();
        }
        void ControlEnter(object sender, EventArgs e)
        {
            string input = ControlInput.Text;
            Controller(input);
            ControlInput.Text = string.Empty;
            ControlInput.Focus();
        }
        void RefreshChatters()
        {
            CheckForIllegalCrossThreadCalls = false;
            while (true)
            {
                bufferedList = "**userlist** ";
                ClientList.Items.Clear();
                foreach (string user in users)
                {
                    ClientList.Items.Add(user);
                    bufferedList += (user + " ");
                }
                Thread.Sleep(1000);
            }
        }
        void OpenServer(object s)
        {
            string serverIP = s.ToString().Substring("/open ".Length);
            TcpClient client = new TcpClient();
            const int Port = 4;
            IPEndPoint serverAddr = new IPEndPoint(IPAddress.Parse(serverIP), Port);
            server = new TcpListener(serverAddr);
            try
            {
                server.Start();
            }
            catch (SocketException )
            {
                MessageBox.Show("올바르지 않은 주소입니다.");
                return;
            }
            AddText(String.Format("Server Opened. [{0}]\r\n", serverAddr.ToString()));
            while (true)
            {
                try
                {
                    client = server.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string userID = Encoding.Default.GetString(buffer, 0, bytes);
                    users.Add(userID);
                    MyChatServer mychat = new MyChatServer(client, userID, this);
                    Thread serverThread = new Thread(new ThreadStart(mychat.Listen));
                    serverThread.IsBackground = true;
                    serverThread.Start();
                }
                catch (Exception ) { break; }
            }
            client.Close();
            server.Stop();
        }
        void CloseServer()
        {
            // 서버 닫는 처리
        }
        void Controller(string s)
        {
            if (s.Equals(string.Empty)) return;
            else if (s.Equals("/close"))
            {
                CloseServer();
                AddText("[Server] Closed.\r\n");
            }
            else if (s.StartsWith("/open "))
            {
                Thread open = new Thread(OpenServer);
                open.IsBackground = true;
                open.Start(s);
            }
        }
        public ChatServerForm()
        {
            InitializeComponent();
        }
        private void ControlInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) ControlEnter(sender, e);
        }

        private void ChatServerForm_Load(object sender, EventArgs e)
        {
            Thread refresher = new Thread(RefreshChatters);
            refresher.IsBackground = true;
            refresher.Start();
        }
        
    }
}
