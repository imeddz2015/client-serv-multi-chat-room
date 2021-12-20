namespace ChatClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sendTextButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.nickNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.connectToAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendTextButton
            // 
            this.sendTextButton.Location = new System.Drawing.Point(551, 278);
            this.sendTextButton.Name = "sendTextButton";
            this.sendTextButton.Size = new System.Drawing.Size(75, 20);
            this.sendTextButton.TabIndex = 0;
            this.sendTextButton.Text = "Send";
            this.sendTextButton.UseVisualStyleBackColor = true;
            this.sendTextButton.Click += new System.EventHandler(this.sendTextButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(5, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(377, 254);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(540, 20);
            this.textBox1.TabIndex = 2;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(391, 220);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(239, 23);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // nickNameTextBox
            // 
            this.nickNameTextBox.Location = new System.Drawing.Point(454, 9);
            this.nickNameTextBox.Name = "nickNameTextBox";
            this.nickNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.nickNameTextBox.TabIndex = 4;
            this.nickNameTextBox.Text = "Guest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "NickName:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(391, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 186);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // connectToAllButton
            // 
            this.connectToAllButton.Location = new System.Drawing.Point(391, 249);
            this.connectToAllButton.Name = "connectToAllButton";
            this.connectToAllButton.Size = new System.Drawing.Size(239, 23);
            this.connectToAllButton.TabIndex = 7;
            this.connectToAllButton.Text = "Connect to all rooms";
            this.connectToAllButton.UseVisualStyleBackColor = true;
            this.connectToAllButton.Click += new System.EventHandler(this.connectToAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(636, 306);
            this.Controls.Add(this.connectToAllButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nickNameTextBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.sendTextButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendTextButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox nickNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button connectToAllButton;
    }
}

