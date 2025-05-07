namespace IoT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxPorts = new ComboBox();
            textBoxMemberId = new TextBox();
            buttonConnect = new Button();
            buttonSendCommand = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBoxPorts
            // 
            comboBoxPorts.FormattingEnabled = true;
            comboBoxPorts.Location = new Point(125, 8);
            comboBoxPorts.Name = "comboBoxPorts";
            comboBoxPorts.Size = new Size(121, 23);
            comboBoxPorts.TabIndex = 0;
            // 
            // textBoxMemberId
            // 
            textBoxMemberId.Location = new Point(342, 180);
            textBoxMemberId.Name = "textBoxMemberId";
            textBoxMemberId.Size = new Size(121, 23);
            textBoxMemberId.TabIndex = 1;
            textBoxMemberId.KeyDown += textBoxMemberId_KeyDown;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(261, 8);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(124, 23);
            buttonConnect.TabIndex = 2;
            buttonConnect.Text = "Connect Port";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // buttonSendCommand
            // 
            buttonSendCommand.Location = new Point(307, 223);
            buttonSendCommand.Name = "buttonSendCommand";
            buttonSendCommand.Size = new Size(188, 23);
            buttonSendCommand.TabIndex = 3;
            buttonSendCommand.Text = "SendCommand";
            buttonSendCommand.UseVisualStyleBackColor = true;
            buttonSendCommand.Click += buttonSendCommand_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 183);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 4;
            label1.Text = "Member ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 12);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 5;
            label2.Text = "Port to Controller";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSendCommand);
            Controls.Add(buttonConnect);
            Controls.Add(textBoxMemberId);
            Controls.Add(comboBoxPorts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPorts;
        private TextBox textBoxMemberId;
        private Button buttonConnect;
        private Button buttonSendCommand;
        private Label label1;
        private Label label2;
    }
}
