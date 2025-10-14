using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Laboratorio3
{
    public partial class frmE3 : Form
    {
        public frmE3()
        {
            InitializeComponent();
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            if (VentasDelAño.setVentas())
            {
                createTables(VentasDelAño.getVentas());
            }
        }

        private void createTables(float[] ventas) {
            ventas = ventas.OrderBy(v => v).ToArray();

            int columnas = 5;


            dgvVentas.Columns.Clear();
            for (int i = 0; i < columnas; i++)
            {
                dgvVentas.Columns.Add("", "");
            }
            
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.ColumnHeadersVisible = false;
            dgvVentas.Rows.Clear();


            dgvVentasF.Columns.Clear();
            for (int i = 0; i < columnas; i++)
            {
                dgvVentasF.Columns.Add("", "");
            }
            
            dgvVentasF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentasF.RowHeadersVisible = false;
            dgvVentasF.ColumnHeadersVisible = false;
            dgvVentasF.Rows.Clear();

            for (int i = 0; i < ventas.Length; i += columnas)
            {
                var fila = new object[columnas];
                for (int j = 0; j < columnas; j++)
                {
                    if (i + j < ventas.Length)
                        fila[j] = ventas[i + j];
                }
                dgvVentas.Rows.Add(fila);
            }


            var ventasFiltradas = ventas.Where(v => v >= 75 && v <= 215).ToArray();
            for (int i = 0; i < ventasFiltradas.Length; i += columnas)
            {
                var fila = new object[columnas];
                for (int j = 0; j < columnas; j++)
                {
                    if (i + j < ventasFiltradas.Length)
                        fila[j] = ventasFiltradas[i + j];
                }
                dgvVentasF.Rows.Add(fila);
            }

            txtVentasRealizadas.Text = "" + VentasDelAño.getCantVentas();

        }
    }
}