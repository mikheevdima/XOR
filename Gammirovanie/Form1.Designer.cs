namespace Gammirovanie
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.зашифроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расшифроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chooseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 66);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зашифроватьToolStripMenuItem,
            this.расшифроватьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 48);
            // 
            // зашифроватьToolStripMenuItem
            // 
            this.зашифроватьToolStripMenuItem.Name = "зашифроватьToolStripMenuItem";
            this.зашифроватьToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.зашифроватьToolStripMenuItem.Text = "Зашифровать";
            // 
            // расшифроватьToolStripMenuItem
            // 
            this.расшифроватьToolStripMenuItem.Name = "расшифроватьToolStripMenuItem";
            this.расшифроватьToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.расшифроватьToolStripMenuItem.Text = "Расшифровать";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chooseToolStripMenuItem
            // 
            this.chooseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeToolStripMenuItem,
            this.decryptToolStripMenuItem});
            this.chooseToolStripMenuItem.Name = "chooseToolStripMenuItem";
            this.chooseToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.chooseToolStripMenuItem.Text = "Choose";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.codeToolStripMenuItem.Text = "Encrypt";
            this.codeToolStripMenuItem.Click += new System.EventHandler(this.codeToolStripMenuItem_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 65);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 65);
            this.button3.TabIndex = 8;
            this.button3.Text = "Copy to clipboard";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 548);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Scrambler";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem зашифроватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расшифроватьToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chooseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

