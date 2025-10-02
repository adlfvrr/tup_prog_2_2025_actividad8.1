using ej.Models;
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
    }
}
