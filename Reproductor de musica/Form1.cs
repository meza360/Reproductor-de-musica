using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Reproductor_de_musica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region variables
        //bool play = false;
        string[] archivos;
        string[] rutas;
        #endregion variables
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void agregar_archivos_Click(object sender, EventArgs e)
        {
            OpenFileDialog cuadro = new OpenFileDialog();
            cuadro.Multiselect = true;
            if (cuadro.ShowDialog() == DialogResult.OK)
            {
                archivos = cuadro.SafeFileNames;
                rutas = cuadro.FileNames;
                foreach (var mp3 in archivos)
                {
                    lista.Items.Add(mp3);
                }
            }
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            reproductor.URL = rutas[lista.SelectedIndex];
        }
    }
}
