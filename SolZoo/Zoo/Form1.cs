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

namespace Zoo
{
    public partial class Form1 : Form
    {

        List<Zoologico> ZooMAIN = new List<Zoologico>();
        HashSet<String> Paises = new HashSet<string>()
        {
            "None"
        };
        public bool volver = false;

        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);


        private void pictureBox1_Click(object sender, EventArgs e) { Application.Exit(); }
        private void pictureBox2_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void BTN_Zoo_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            RegistrarZoo frm = new RegistrarZoo(ZooMAIN, Paises);
            frm.ShowDialog(this);
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void BTN_Esp_Click(object sender, EventArgs e)
        {
            RegistrarEspecie frm = new RegistrarEspecie(ZooMAIN);
            frm.ShowDialog();
        }

        private void BTN_Reporte_Click(object sender, EventArgs e)
        {
            Reportes frm = new Reportes(ZooMAIN, Paises);
            frm.ShowDialog();
        }
    }
}
