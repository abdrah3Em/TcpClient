using SuperSimpleTcp;
using System.Text;

namespace TcpClient
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

       
        SimpleTcpClient client;
        private void ClientForm_Load(object sender, EventArgs e)
        {
            client = new(txtIP.Text);
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataRecieved;
            client.Events.Disconnected += Events_Disconnected;
            btnSend.Enabled = false;



        }



        //client events//
        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
          
                txtinfo.Text += $"Server Disconnected.{Environment.NewLine}";
            });


        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {

                txtinfo.Text += $"Server Connected.{Environment.NewLine}";
               
            });


        }

        private void Events_DataRecieved(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {

                txtinfo.Text += $"Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            
            });

        }
        //client events//






        private void btnConnect_Click(object sender, EventArgs e)
        {

            try
            {
                client.Connect();
                btnSend.Enabled = true;
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }


        private void btnSend_Click(object sender, EventArgs e)
        {

            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(txtMessage.Text))
                {
                    client.Send(txtMessage.Text);
                    txtinfo.Text += $"Me: {txtMessage.Text}{Environment.NewLine}";
                    txtMessage.Text = string.Empty;

                }

            }
        }

    }
}