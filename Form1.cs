using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renewindow
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SetWindowText(IntPtr hWnd, string lpString);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox2.Text;
            string windowName = login; 

            IntPtr hwnd = FindWindow(null, textBox1.Text); 
            if (hwnd != IntPtr.Zero)
            {
                SetWindowText(hwnd, windowName);
               
            }
            else
            {
                MessageBox.Show("ты сделал что-то не так");
            }

            
        }
    }
}
