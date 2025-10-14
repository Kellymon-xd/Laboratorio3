using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio3
{
    public class GestorNumeros
    {
        private List<int> numeros = new List<int>();
        private Random random = new Random();
        public void ActualizarGrids(DataGridView dgvNumbers)
        {
            if (dgvNumbers == null) return;
            dgvNumbers.Columns.Clear();
            dgvNumbers.Rows.Clear();

            dgvNumbers.ColumnHeadersVisible = false;
            dgvNumbers.RowHeadersVisible = false;

            int totalNumbers = numeros.Count;
            int filas = 7;

            int columnas = (int)Math.Ceiling(totalNumbers / (double)filas);
            if (columnas == 0) columnas = 1;

            for (int c = 0; c < columnas; c++)
                dgvNumbers.Columns.Add($"col{c}", "");

            dgvNumbers.RowCount = filas;

            for (int i = 0; i < totalNumbers; i++)
            {
                int row = i / columnas;
                int col = i % columnas;

                if (row < filas && col < columnas)
                    dgvNumbers[col, row].Value = numeros[i];
            }

            dgvNumbers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            int altoFila = dgvNumbers.ClientSize.Height / filas;
            foreach (DataGridViewRow row in dgvNumbers.Rows)
                row.Height = altoFila;
        }
        public bool agregarNumManual(int cantidad, Form frme2) {
                for (int i = 0; i < cantidad; i++)
                {
                    Dialogo dlgNumero = new Dialogo();
                    dlgNumero.Titulo = $"Ingrese el valor No. {i + 1}:";
                    dlgNumero.AplicarEstiloForm(frme2);
                    dlgNumero.AplicarEstiloBoton(dlgNumero, Color.LavenderBlush);

                    if (dlgNumero.ShowDialog() == DialogResult.OK)
                    {
                        if (int.TryParse(dlgNumero.ValorIngresado, out int valor) && valor > 0)
                        {
                            numeros.Add(valor);
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
                        cantidad = 0;
                        return false;
                    }
                }
                return true;
        }

        public bool eliminarNum(Form frme2)
        {
            Dialogo dlgEliminar = new Dialogo();
            dlgEliminar.Titulo = "Ingrese el número a eliminar:";

            dlgEliminar.AplicarEstiloForm(frme2);
            dlgEliminar.AplicarEstiloBoton(dlgEliminar, Color.LavenderBlush);

            if (dlgEliminar.ShowDialog() == DialogResult.OK)
            {
                int numeroEliminar;
                if (int.TryParse(dlgEliminar.ValorIngresado, out numeroEliminar)
                    && numeros.Contains(numeroEliminar))
                {
                    var resultado = MessageBox.Show(
                        $"¿Está seguro que desea eliminar el número {numeroEliminar}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        int eliminados = numeros.RemoveAll(x => x == numeroEliminar);

                        if (eliminados > 0)
                        {
                            MessageBox.Show($"Se eliminaron {eliminados} coincidencias del número {numeroEliminar}.");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el número en la lista.");
                            return false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Número inválido o no encontrado.");
                }
            }
            return false;
        }

        public void agregarNumAleatorio(int cantidad) {
            numeros.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                numeros.Add(random.Next(1, 101));
            }
        }
        public List<int> getNumeros() {
        return numeros;
        }
    }
}