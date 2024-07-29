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
            textBoxMessage = new TextBox();
            textBoxPort = new TextBox();
            listBoxMessages = new ListBox();
            Enviar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxMessage
            // 
            textBoxMessage.AccessibleName = "textBoxMessage";
            textBoxMessage.Location = new Point(86, 75);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(222, 23);
            textBoxMessage.TabIndex = 1;
            textBoxMessage.TextChanged += textBox1_TextChanged;
            // 
            // textBoxPort
            // 
            textBoxPort.AccessibleName = "textBoxPort";
            textBoxPort.Location = new Point(86, 279);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(100, 23);
            textBoxPort.TabIndex = 2;
            textBoxPort.TextChanged += textBoxPort_TextChanged;
            // 
            // listBoxMessages
            // 
            listBoxMessages.AccessibleName = "listBoxMessages";
            listBoxMessages.FormattingEnabled = true;
            listBoxMessages.ItemHeight = 15;
            listBoxMessages.Location = new Point(492, 51);
            listBoxMessages.Name = "listBoxMessages";
            listBoxMessages.Size = new Size(296, 274);
            listBoxMessages.TabIndex = 3;
            // 
            // Enviar
            // 
            Enviar.Location = new Point(587, 378);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(75, 23);
            Enviar.TabIndex = 4;
            Enviar.Text = "Enviar";
            Enviar.UseVisualStyleBackColor = true;
            Enviar.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 37);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 5;
            label1.Text = "Mensaje";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 242);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 6;
            label2.Text = "Puerto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Enviar);
            Controls.Add(listBoxMessages);
            Controls.Add(textBoxPort);
            Controls.Add(textBoxMessage);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxMessage;
        private TextBox textBoxPort;
        private ListBox listBoxMessages;
        private Button Enviar;
        private Label label1;
        private Label label2;
    }
}
