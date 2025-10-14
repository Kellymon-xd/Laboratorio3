using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio3
{
    public class ActualizarGrid
    {
        public void ActualizarGrids(DataGridView dgvNumbers, List<int> numeros)
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
    }
}
