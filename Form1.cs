namespace IoT
{

    using System;
    using System.IO.Ports;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
            LoadAvailablePorts();
        }

        private void LoadAvailablePorts()
        {
            comboBoxPorts.Items.AddRange(SerialPort.GetPortNames());
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string selectedPort = comboBoxPorts.SelectedItem.ToString();

            serialPort = new SerialPort(selectedPort, 115200); // Match ESP32 baudrate
            serialPort.Open();

            MessageBox.Show("Connected to ESP32 on " + selectedPort);
        }

        private void buttonSendCommand_Click(object sender, EventArgs e)
        {
            string memberId = textBoxMemberId.Text;

            // Example: Simple lookup for paid members (replace with database)
            bool isPaid = CheckMembershipStatus(memberId);

            if (serialPort != null && serialPort.IsOpen)
            {
                string command = isPaid ? "ALLOW\n" : "DENY\n";
                serialPort.Write(command);
                MessageBox.Show("Command Sent: " + command.Trim());
            }
        }

        private void textBoxMemberId_KeyDown(object sender, KeyEventArgs e)
        {
            //for qr code reader

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // prevent "ding" sound on Enter
                ProcessMemberId(textBoxMemberId.Text.Trim());
            }
        }


        private void textBoxMemberId_KeyDown_master(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // prevent "ding" sound on Enter
                ProcessMemberId(textBoxMemberId.Text.Trim());
            }
        }

        private void ProcessMemberId(string memberId)
        {
            bool isPaid = CheckMembershipStatus(memberId);

            if (serialPort != null && serialPort.IsOpen)
            {
                string command = isPaid ? "ALLOW\n" : "DENY\n";
                serialPort.Write(command);
                MessageBox.Show($"Member: {memberId}\nCommand Sent: {command.Trim()}");
            }
            else
            {
                MessageBox.Show("Serial port not connected.");
            }

            textBoxMemberId.Clear();
        }


        private bool CheckMembershipStatus(string memberId)
        {
            // Example logic - replace with real database
            var paidMembers = new[] { "1001", "1002", "1003" };
            return Array.Exists(paidMembers, id => id == memberId);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
                serialPort.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBoxMemberId.Focus();
            this.Text = "Non-Natee Gate Controller";
        }


    }


}
