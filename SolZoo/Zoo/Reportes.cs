using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Zoo
{
    public partial class Reportes : Form
    {
        public List<Zoologico> zooReportes { get; set; }
        public HashSet<string> paises { get; set; }
        Dictionary<string, long> clasesEspecies;

        public Reportes(List<Zoologico> pZoo, HashSet<string> paises)
        {
            InitializeComponent();
            zooReportes = pZoo;
            this.paises = paises;
            DGVDatos.Enabled = false;
            clasesEspecies = new Dictionary<string, long>();
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

        private void Reportes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public List<Zoologico> FiltrarPorPais(string pais)
        {
            return zooReportes.FindAll(z => z.Pais.Equals(pais));
        }

        public List<Zoologico> FiltrarPorEspeciesEnExtincionDeMayorAMenor()
        {
            return zooReportes.OrderByDescending(z => z.cantEspeciesEnExtinción).ToList();
        }

        public List<Zoologico> FiltrarZooPorPresupuesto()
        {
            return zooReportes.OrderBy(z => z.PresupuestoAnual).ToList();
        }

        public List<Zoologico> FiltrarZooSinEspeciesEnExtincion()
        {
            return zooReportes.FindAll(z => z.cantEspeciesEnExtinción == 0);
        }

        public void Recorrer()
        {
            long mamiferos = 0, aves = 0, anfibios = 0, reptiles = 0;
            for(int i = 0; i < zooReportes.Count; i++)
            {
                for(int j = 0; j < zooReportes.ElementAt(i).Especies.Count; j++)
                {
                    var seleccionado = zooReportes.ElementAt(i).Especies.ElementAt(j);
                    if (seleccionado.ClaseAnimal == "Mamifero")
                    {
                        mamiferos += seleccionado.cantAnimales;
                    }
                    if (seleccionado.ClaseAnimal == "Ave")
                    {
                        aves += seleccionado.cantAnimales;
                    }
                    if (seleccionado.ClaseAnimal == "Anfibio")
                    {
                        anfibios += seleccionado.cantAnimales;
                    }
                    if (seleccionado.ClaseAnimal == "Reptil")
                    {
                        reptiles += seleccionado.cantAnimales;
                    }
                }
            }

            clasesEspecies.Add("Mamiferos", mamiferos);
            clasesEspecies.Add("Aves", aves);
            clasesEspecies.Add("Anfibios", anfibios);
            clasesEspecies.Add("Reptiles", reptiles);

        }

        public void LlenarDGV(string aaa)
        {
            DGVDatos.DataSource = null;
            DGVDatos.DataSource = FiltrarPorPais(aaa);
        }

        private void CBX_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarDGV(CBX_Pais.SelectedItem.ToString());
        }

        private void CBX_TipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBX_Pais.Text = "";
            CBX_Pais.Enabled = false;
            DGVDatos.ClearSelection();
            DGVDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (CBX_TipoReporte.SelectedIndex == 0)
            {
                CBX_Pais.Enabled = true;
                CBX_Pais.DataSource = paises.ToList();
                DGVDatos.Columns[0].Width = 30;
            }
            else if(CBX_TipoReporte.SelectedIndex == 1)
            {
                DGVDatos.DataSource = null;
                DGVDatos.DataSource = FiltrarPorEspeciesEnExtincionDeMayorAMenor();
                DGVDatos.Columns[0].Width = 30;
            }
            else if(CBX_TipoReporte.SelectedIndex == 2)
            {
                DGVDatos.DataSource = null;
                DGVDatos.DataSource = FiltrarZooPorPresupuesto();
                DGVDatos.Columns[0].Width = 30;
            }
            else if (CBX_TipoReporte.SelectedIndex == 3)
            {
                DGVDatos.DataSource = null;
                DGVDatos.DataSource = FiltrarZooSinEspeciesEnExtincion();
                DGVDatos.Columns[0].Width = 30;
            }
            else if (CBX_TipoReporte.SelectedIndex == 4)
            {
                Recorrer();
                DGVDatos.DataSource = null;
                DGVDatos.DataSource = clasesEspecies.OrderByDescending(z => z.Value).ToList();
                DGVDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGVDatos.Columns[0].HeaderText = "Clase";
                DGVDatos.Columns[1].HeaderText = "Cantidad de animales";
            }
        }
    }
}
