namespace ChatApp
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
            groupBox1 = new GroupBox();
            TextLocalPort = new TextBox();
            TextLocalIp = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            TextRemotePort = new TextBox();
            TextRemoteIp = new TextBox();
            label4 = new Label();
            label3 = new Label();
            buttonStart = new Button();
            TextMessages = new TextBox();
            listMessages = new ListBox();
            buttonSend = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TextLocalPort);
            groupBox1.Controls.Add(TextLocalIp);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Me";
            // 
            // TextLocalPort
            // 
            TextLocalPort.Location = new Point(133, 97);
            TextLocalPort.Name = "TextLocalPort";
            TextLocalPort.Size = new Size(221, 31);
            TextLocalPort.TabIndex = 4;
            // 
            // TextLocalIp
            // 
            TextLocalIp.Location = new Point(133, 39);
            TextLocalIp.Name = "TextLocalIp";
            TextLocalIp.Size = new Size(221, 31);
            TextLocalIp.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 97);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 4;
            label2.Text = "Port";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 39);
            label1.Name = "label1";
            label1.Size = new Size(27, 25);
            label1.TabIndex = 3;
            label1.Text = "IP";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TextRemotePort);
            groupBox2.Controls.Add(TextRemoteIp);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(435, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(368, 150);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Friend";
            // 
            // TextRemotePort
            // 
            TextRemotePort.Location = new Point(133, 97);
            TextRemotePort.Name = "TextRemotePort";
            TextRemotePort.Size = new Size(221, 31);
            TextRemotePort.TabIndex = 4;
            // 
            // TextRemoteIp
            // 
            TextRemoteIp.Location = new Point(133, 39);
            TextRemoteIp.Name = "TextRemoteIp";
            TextRemoteIp.Size = new Size(221, 31);
            TextRemoteIp.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 97);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 4;
            label4.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 39);
            label3.Name = "label3";
            label3.Size = new Size(27, 25);
            label3.TabIndex = 4;
            label3.Text = "IP";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(854, 78);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(112, 34);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Connect";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // TextMessages
            // 
            TextMessages.Location = new Point(12, 567);
            TextMessages.Name = "TextMessages";
            TextMessages.Size = new Size(824, 31);
            TextMessages.TabIndex = 4;
            // 
            // listMessages
            // 
            listMessages.FormattingEnabled = true;
            listMessages.ItemHeight = 25;
            listMessages.Location = new Point(12, 179);
            listMessages.Name = "listMessages";
            listMessages.Size = new Size(926, 379);
            listMessages.TabIndex = 5;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(854, 566);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(112, 34);
            buttonSend.TabIndex = 6;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 610);
            Controls.Add(buttonSend);
            Controls.Add(listMessages);
            Controls.Add(TextMessages);
            Controls.Add(buttonStart);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Chat App";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonStart;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox TextLocalIp;
        private TextBox TextLocalPort;
        private TextBox TextRemotePort;
        private TextBox TextRemoteIp;
        private TextBox TextMessages;
        private ListBox listMessages;
        private Button buttonSend;

    }
}