namespace EchoMessenger
{
    partial class EchoMessenger
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
            lblText = new Label();
            lstMsgWindow = new ListBox();
            btnSend = new Button();
            txtMessage = new TextBox();
            lblCount = new Label();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(34, 22);
            lblText.Name = "lblText";
            lblText.Size = new Size(190, 32);
            lblText.TabIndex = 0;
            lblText.Text = "Echo Messenger";
            lblText.Click += label1_Click;
            // 
            // lstMsgWindow
            // 
            lstMsgWindow.FormattingEnabled = true;
            lstMsgWindow.Location = new Point(66, 78);
            lstMsgWindow.Name = "lstMsgWindow";
            lstMsgWindow.Size = new Size(644, 292);
            lstMsgWindow.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(622, 401);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(150, 46);
            btnSend.TabIndex = 2;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(234, 405);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(382, 39);
            txtMessage.TabIndex = 3;
            txtMessage.KeyDown += txtMessage_KeyDown;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(44, 415);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(168, 32);
            lblCount.TabIndex = 4;
            lblCount.Text = "현재 대화: 0개";
            // 
            // EchoMessenger
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 486);
            Controls.Add(lblCount);
            Controls.Add(txtMessage);
            Controls.Add(btnSend);
            Controls.Add(lstMsgWindow);
            Controls.Add(lblText);
            Name = "EchoMessenger";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblText;
        private ListBox lstMsgWindow;
        private Button btnSend;
        private TextBox txtMessage;
        private Label lblCount;
    }
}
