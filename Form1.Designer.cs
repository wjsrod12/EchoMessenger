namespace EchoMessenger
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
            lblTitle = new Label();
            lstMsg = new ListBox();
            btnSend = new Button();
            txtBox = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.Orange;
            lblTitle.Location = new Point(34, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Echo Messenger";
            // 
            // lstMsg
            // 
            lstMsg.FormattingEnabled = true;
            lstMsg.Location = new Point(34, 65);
            lstMsg.Name = "lstMsg";
            lstMsg.Size = new Size(603, 289);
            lstMsg.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(514, 369);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(110, 36);
            btnSend.TabIndex = 2;
            btnSend.Text = "button1";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtBox
            // 
            txtBox.Location = new Point(34, 377);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(474, 23);
            txtBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBox);
            Controls.Add(btnSend);
            Controls.Add(lstMsg);
            Controls.Add(lblTitle);
            ForeColor = Color.DarkOrange;
            Name = "Form1";
            Text = "Echo Messenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox lstMsg;
        private Button btnSend;
        private TextBox txtBox;
    }
}
