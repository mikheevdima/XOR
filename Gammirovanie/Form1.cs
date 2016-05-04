using System;
using System.Text;
using System.Windows.Forms;

namespace Gammirovanie
{
    public partial class Form1 : Form
    {
       public string text;
       public int key;
       public byte[] arr;
       public string strCrypt ;


        public Form1()
        {
            InitializeComponent();
        }

        public static string Encrypt(byte[] arr, int key)
        {
           byte[] mass = new byte[arr.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = (byte) (arr[i] ^ key);
            }
            return Encoding.Unicode.GetString(mass);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            key = Convert.ToInt32(textBox2.Text);
            arr = Encoding.Unicode.GetBytes(text);
            strCrypt = Encrypt(arr, key);
            label3.Text = strCrypt;
            button3.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void codeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Encrypted text";
            label2.Text = "Key";
            button1.Text = "Encode";
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            label3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label3.Text);
        }

        public static string Decrypt(string encrypt, int key)
        {
            byte[] arr = Encoding.Unicode.GetBytes(encrypt);
            return Encrypt(arr,key);
        }

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Decrypted text";
            label2.Text = "Key";
            button2.Text = "Decode";
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = false;
            label3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            key = Convert.ToInt32(textBox2.Text);
            label3.Text = Decrypt(text,key);
            button3.Visible = true;
        }
    }
}
