using Laboratorio3;
using System;
using System.Windows.Forms;

public class VentasDelAño{

    private static float[] ventas;
    private static int cantVentas;

    public static bool setVentas() {
        Dialogo dlgCant = new Dialogo();
        dlgCant.Titulo = "Ingrese la cantidad de ventas:";

        if (dlgCant.ShowDialog() == DialogResult.OK)
        {

            if (int.TryParse(dlgCant.ValorIngresado, out cantVentas) && cantVentas > 0)
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
                        return false;
                        break;

                    }
                }
                if (cantVentas > 0)
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Cantidad inválida.");
                return false;
            }
        }
        return false;
    }
    public static float[] getVentas() 
    {
        return ventas;
    }
    public static float getCantVentas()
    {
        return cantVentas;
    }
}