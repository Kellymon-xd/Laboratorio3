using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Laboratorio3
{
    public partial class frmE3 : Form
    {
        private float[] ventas;
        int cantVentas;
        public frmE3()
        {
            InitializeComponent();
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            Dialogo dlgCant = new Dialogo();
            dlgCant.Titulo = "Ingrese la cantidad de ventas:";

            if (dlgCant.ShowDialog() == DialogResult.OK)
            {
                
                if (int.TryParse(dlgCant.ValorIngresado, out cantVentas) && cantVentas>0)
                {
                    ventas = new float[cantVentas];
                    float valor;

                    for (int i = 0; i < cantVentas; i++)
                    {
                        Dialogo dlgVenta = new Dialogo();
                        dlgVenta.Titulo = $"Ingrese la venta No. {i + 1}:";

                        if (dlgVenta.ShowDialog() == DialogResult.OK)
                        {
                            if (float.TryParse(dlgVenta.ValorIngresado, out valor) && valor > 0)
                            {
                                float multiplicado = valor * 100;
                                if (Math.Floor(multiplicado) == multiplicado)
                                {
                                    ventas[i] = valor;
                                }
                                else
                                {
                                    MessageBox.Show("Número inválido: máximo 2 decimales.");
                                    i--;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Número inválido, intente de nuevo.");
                                i--;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Entrada cancelada.");
                            cantVentas = 0;
                            break;

                        }
                    }
                    if (cantVentas > 0)
                    {
                        createTables();
                    }
                }
                else
                {
                    MessageBox.Show("Cantidad inválida.");
                }
            }
        }

        private void createTables() {
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

            txtVentasRealizadas.Text = "" + cantVentas;

        }
    }
}