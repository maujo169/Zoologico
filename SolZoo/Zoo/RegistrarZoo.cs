using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class RegistrarZoo : Form
    {
        public List<Zoologico> ZooRegistro = new List<Zoologico>();
        public HashSet<string> paises = new HashSet<string>();

        public RegistrarZoo(List<Zoologico> pZoo, HashSet<string> paises)
        {
            InitializeComponent();
            ZooRegistro = pZoo;
            this.paises = paises;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BTN_Zoo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiarCampos()
        {
            TBX_Nombre.Clear();
            TBX_Pais.Clear();
            TBX_Ciudad.Clear();
            TBX_PresupuestoAnual.Clear();
            TBX_Tam.Clear();
            TBX_Nombre.Focus();
        }

        public bool AgregarZoo(Zoologico zoo)
        {
            bool existe =  ZooRegistro.Any(x => x.Nombre.Equals(zoo.Nombre));
            if (!existe)
            {
                ZooRegistro.Add(zoo);
                return true;
            }
            else
                return false;
        }

        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            if(TBX_Pais.Text == "" || TBX_Nombre.Text == " " ||
                TBX_Ciudad.Text == "" || TBX_PresupuestoAnual.Text == "" || TBX_Tam.Text == "")
            {
                MessageBox.Show("Llenar campos para guardar");
            }
            else
            {
                Zoologico zoo = new Zoologico()
                {
                    ID = ZooRegistro.Count,
                    Nombre = TBX_Nombre.Text,
                    Pais = TBX_Pais.Text,
                    Ciudad = TBX_Ciudad.Text,
                    PresupuestoAnual = Convert.ToDouble(TBX_PresupuestoAnual.Text),
                    Tam = Convert.ToDouble(TBX_Tam.Text)
                };
                if (!AgregarZoo(zoo))
                    MessageBox.Show("El zoologico que intenta registrar ya existe");
                else
                    paises.Add(TBX_Pais.Text);
            }
            LimpiarCampos();
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void TBX_PresupuestoAnual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }

        private void TBX_Tam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }
    }
}
