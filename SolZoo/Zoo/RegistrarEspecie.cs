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
    public partial class RegistrarEspecie : Form
    {
        List<Zoologico> zooEspecies = new List<Zoologico>();

        public RegistrarEspecie(List<Zoologico> pZoo)
        {
            InitializeComponent();
            zooEspecies = pZoo;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void MostrarZoologicosCBX()
        {
            CBX_Zoo.DataSource = zooEspecies;
            CBX_Zoo.DisplayMember = "Nombre";
        }


        private void RegistrarEspecie_Load(object sender, EventArgs e)
        {
            MostrarZoologicosCBX();
        }

        public bool AgregarEspecie(EspecieAnimal especie, int index)
        {
            bool existe = zooEspecies.ElementAt(index).Especies.Any(e => e.NombreCientifico.Equals(especie.NombreCientifico) || e.NombreVulgar.Equals(especie.NombreVulgar));
            if (!existe)
            {
                zooEspecies.ElementAt(index).Especies.Add(especie);
                return true;
            }
            else
                return false;
        }

        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            if(TBX_NombreV.Text == "" || TBX_NombreC.Text == "" || TBX_CantAnimales.Text == "" ||
                CBX_Extincion.Text == "" || CBX_Clase.Text == "")
            {
                MessageBox.Show("Completar campos para añadir especie");
            }
            else
            {
                EspecieAnimal especie = new EspecieAnimal
                {
                    NombreVulgar = TBX_NombreV.Text,
                    NombreCientifico = TBX_NombreC.Text,
                    IDZoo = CBX_Zoo.SelectedIndex,
                    cantAnimales = Convert.ToInt32(TBX_CantAnimales.Text),
                    ClaseAnimal = CBX_Clase.Text,
                    PeligroExtinción = CBX_Extincion.Text == "Si" ? true : false
                };
                if (!AgregarEspecie(especie, CBX_Zoo.SelectedIndex))
                    MessageBox.Show("La especie que intenta registrar ya existe en el zoologico actual");
                else
                    if (especie.PeligroExtinción == true)
                    zooEspecies.ElementAt(CBX_Zoo.SelectedIndex).cantEspeciesEnExtinción++;
            }
        }

        private void TBX_CantAnimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }
    }
}
