namespace Serial
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nt1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nt2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nt3 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nt4 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nt5 = new System.Windows.Forms.TextBox();
            this.nt7 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nt6 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ConnectDisconnect = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.nt1);
            this.panel1.Location = new System.Drawing.Point(400, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 133);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.ClickedPanel);
            // 
            // nt1
            // 
            this.nt1.Location = new System.Drawing.Point(28, 45);
            this.nt1.Name = "nt1";
            this.nt1.Size = new System.Drawing.Size(100, 44);
            this.nt1.TabIndex = 0;
            this.nt1.Text = "1";
            this.nt1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.nt2);
            this.panel2.Location = new System.Drawing.Point(400, 273);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 133);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.ClickedPanel);
            // 
            // nt2
            // 
            this.nt2.Location = new System.Drawing.Point(26, 45);
            this.nt2.Name = "nt2";
            this.nt2.Size = new System.Drawing.Size(100, 44);
            this.nt2.TabIndex = 1;
            this.nt2.Text = "2";
            this.nt2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.nt3);
            this.panel3.Location = new System.Drawing.Point(400, 424);
            this.panel3.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 133);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.ClickedPanel);
            // 
            // nt3
            // 
            this.nt3.Location = new System.Drawing.Point(28, 45);
            this.nt3.Name = "nt3";
            this.nt3.Size = new System.Drawing.Size(100, 44);
            this.nt3.TabIndex = 2;
            this.nt3.Text = "3";
            this.nt3.Visible = false;
            this.nt3.TextChanged += new System.EventHandler(this.nt3_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.nt4);
            this.panel4.Location = new System.Drawing.Point(564, 273);
            this.panel4.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 133);
            this.panel4.TabIndex = 4;
            this.panel4.Click += new System.EventHandler(this.ClickedPanel);
            // 
            // nt4
            // 
            this.nt4.Location = new System.Drawing.Point(26, 45);
            this.nt4.Name = "nt4";
            this.nt4.Size = new System.Drawing.Size(100, 44);
            this.nt4.TabIndex = 3;
            this.nt4.Text = "4";
            this.nt4.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Controls.Add(this.nt5);
            this.panel5.Location = new System.Drawing.Point(728, 122);
            this.panel5.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(148, 133);
            this.panel5.TabIndex = 3;
            this.panel5.Click += new System.EventHandler(this.ClickedPanel);
            // 
            // nt5
            // 
            this.nt5.Location = new System.Drawing.Point(28, 45);
            this.nt5.Name = "nt5";
            this.nt5.Size = new System.Drawing.Size(100, 44);
            this.nt5.TabIndex = 4;
            this.nt5.Text = "5";
            this.nt5.Visible = false;
            // 
            // nt7
            // 
            this.nt7.Location = new System.Drawing.Point(28, 45);
            this.nt7.Name = "nt7";
            this.nt7.Size = new System.Drawing.Size(100, 44);
            this.nt7.TabIndex = 6;
            this.nt7.Text = "7";
            this.nt7.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Controls.Add(this.nt6);
            this.panel6.Location = new System.Drawing.Point(728, 273);
            this.panel6.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(148, 133);
            this.panel6.TabIndex = 2;
            this.panel6.Click += new System.EventHandler(this.ClickedPanel);
            // 
            // nt6
            // 
            this.nt6.Location = new System.Drawing.Point(26, 45);
            this.nt6.Name = "nt6";
            this.nt6.Size = new System.Drawing.Size(100, 44);
            this.nt6.TabIndex = 5;
            this.nt6.Text = "6";
            this.nt6.Visible = false;
            this.nt6.TextChanged += new System.EventHandler(this.nt6_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGray;
            this.panel7.Controls.Add(this.nt7);
            this.panel7.Location = new System.Drawing.Point(728, 424);
            this.panel7.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(148, 133);
            this.panel7.TabIndex = 2;
            this.panel7.Click += new System.EventHandler(this.ClickedPanel);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 45);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ConnectDisconnect
            // 
            this.ConnectDisconnect.Location = new System.Drawing.Point(91, 185);
            this.ConnectDisconnect.Name = "ConnectDisconnect";
            this.ConnectDisconnect.Size = new System.Drawing.Size(199, 60);
            this.ConnectDisconnect.TabIndex = 6;
            this.ConnectDisconnect.Text = "Connect";
            this.ConnectDisconnect.UseVisualStyleBackColor = true;
            this.ConnectDisconnect.Click += new System.EventHandler(this.ConnectDisconnect_Click);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 37;
            this.ListBox.Location = new System.Drawing.Point(46, 272);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(299, 448);
            this.ListBox.TabIndex = 7;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "Bearbeiten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2533, 1280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.ConnectDisconnect);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ConnectDisconnect;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nt1;
        private System.Windows.Forms.TextBox nt2;
        private System.Windows.Forms.TextBox nt3;
        private System.Windows.Forms.TextBox nt4;
        private System.Windows.Forms.TextBox nt7;
        private System.Windows.Forms.TextBox nt6;
        private System.Windows.Forms.TextBox nt5;
    }
}

