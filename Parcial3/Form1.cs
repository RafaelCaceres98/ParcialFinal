using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Parcial3
{
    public partial class Form1 : Form
    {
        public LacteosService LacteosService;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            var ruta = openFile.FileName;
            MessageBox.Show(ruta);
            LacteosService = new LacteosService(ConfigConection.Connection);
            IList<Lacteos> LacteosMalos = new List<Lacteos>();
            IList<Lacteos> LacteosBuenos = new List<Lacteos>();
            foreach (var item in LacteosService.CargarArchivo(ruta))
            {
                if (item.CalcularPago() != item.TotalPago)
                {
                    LacteosMalos.Add(item);
                }
                else
                {
                    LacteosBuenos.Add(item);
                }
            }

            MessageBox.Show("Lacteos Malos " + LacteosBuenos.Count);
        }
    }
}
