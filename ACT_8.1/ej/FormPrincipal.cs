using ej.Models;
using System.Net;
namespace ej
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        List<Cuenta> cuentas = new List<Cuenta>();

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Cuenta nuevaCuenta;
            string nom = tbNombre.Text;
            int DNI = Convert.ToInt32(tbDNI.Text);
            double importe = Convert.ToDouble(tbImporte.Text);
            Cuenta cuentaDNI = new Cuenta(DNI);
            cuentas.Sort();
            int idx = cuentas.BinarySearch(cuentaDNI);
            if (idx >= 0)
            {
                cuentas[idx].Nombre = nom;
                cuentas[idx].Importe += importe;
                btnActualizar.PerformClick();
            }
            else
            {
                nuevaCuenta = new Cuenta(nom, DNI, importe);
                cuentas.Add(nuevaCuenta);
            }
            tbNombre.Clear();
            tbDNI.Clear();
            tbImporte.Clear();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lsbActualizar.Items.Clear();
            foreach (Cuenta cuenta in cuentas)
            {
                lsbActualizar.Items.Add(cuenta);
            }
        }
        private void lsbActualizar_SelectedValueChanged(object sender, EventArgs e)
        {
            Cuenta? cuentaSeleccionada = lsbActualizar.SelectedItem as Cuenta;
            if (cuentaSeleccionada != null)
            {
                tbNombre.Text = cuentaSeleccionada.Nombre;
                tbDNI.Text = cuentaSeleccionada.DNI.ToString();
                tbImporte.Text = cuentaSeleccionada.Importe.ToString();
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            cuentas = new List<Cuenta>();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                while (sr.EndOfStream == false)
                {
                    string cadena = sr.ReadLine();
                    string dni = cadena.Substring(0, 9);
                    string nombre = cadena.Substring(9, 10).Trim();
                    string importe = cadena.Substring(19, 9);
                    Cuenta c = new Cuenta(nombre, Convert.ToInt32(dni), Convert.ToDouble(importe));
                    if (c != null)
                    {
                        cuentas.Sort();
                        int idx = cuentas.BinarySearch(c);
                        if (idx >= 0)
                        {
                            cuentas[idx].Nombre = c.Nombre;
                            cuentas[idx].Importe += c.Importe;
                        }
                        else
                        {
                            cuentas.Add(c);
                        }
                    }
                }
                if (fs != null) { fs.Close(); }
            }

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            saveFileDialog1.Filter = "Archivos de texto(*txt)|*.txt|Todos los archivos|*.*";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                foreach(Cuenta c in cuentas)
                {
                    sw.WriteLine($"{c.Nombre};{c.DNI};{c.Importe:f2}");
                }
                sw.Close();
            }
        }
    }
}
