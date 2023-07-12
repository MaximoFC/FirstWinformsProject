namespace ProyectodeLaboratorio
{
    public partial class Form1 : Form
    {
        Publico publico = new Publico();
        Entradas entradas = new Entradas();
        Detalles det = new Detalles();
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if ((metros2.Text.Length > 0) && (tribunas.Text.Length > 0) && (escenario.Text.Length > 0))
            {
                publico.metros_cuadrados = double.Parse(metros2.Text);
                publico.capacidad_tribunas = double.Parse(tribunas.Text);
                publico.porcentaje_escenario = double.Parse(escenario.Text);
                if (publico.metros_cuadrados > 0 && publico.capacidad_tribunas > 0 && publico.porcentaje_escenario > 0)
                {
                    resultado.Text = Convert.ToString((int)publico.calcular());
                }
                else
                {
                    MessageBox.Show("Debe ingresar valores positivos.");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar los valores correctamente");
            }
        }

        private void btnganancias_Click(object sender, EventArgs e)
        {
            if ((comunes.Text.Length > 0) && (vip.Text.Length > 0))
            {
                entradas.precio_comunes = double.Parse(comunes.Text);
                entradas.precio_vip = double.Parse(vip.Text);
                entradas.cantidad_entradas = publico.calcular();
                if (entradas.precio_comunes > 0 && entradas.precio_vip > 0)
                {
                    ganancias.Text = "$" + Convert.ToString((int)entradas.ganancias());
                }
                else
                {
                    MessageBox.Show("Debe ingresar valores positivos.");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar los valores correctamente.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (resultado.Text.Length > 0)
            {
                tabControl1.SelectTab(2);
            }
            else
            {
                MessageBox.Show("Debe calcular la cantidad de personas antes de pasar a la siguiente etapa.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ganancias.Text.Length > 0)
            {
                //relleno del vector de items
                det.items[0] = "Metros cuadrados";
                det.items[1] = "Capacidad de la tribuna";
                det.items[2] = "Porcentaje que ocupa el escenario";
                det.items[3] = "Cantidad de personas que podrán asistir";
                det.items[4] = "Precio de entradas comunes";
                det.items[5] = "Precio de entradas VIP";
                det.items[6] = "Ganancias por la venta de entradas";
                //relleno del vector de valores
                det.valores[0] = publico.metros_cuadrados;
                det.valores[1] = publico.capacidad_tribunas;
                det.valores[2] = publico.porcentaje_escenario;
                det.valores[3] = (int)publico.calcular();
                det.valores[4] = entradas.precio_comunes;
                det.valores[5] = entradas.precio_vip;
                det.valores[6] = Math.Round(entradas.ganancias(), 2);
                tabControl1.SelectTab(3);
                for (int i = 0; i < 7; i++)
                {
                    int n = GridDetalles.Rows.Add();    //Adiciona una fila al grid de detalles
                    GridDetalles.Rows[n].Cells[0].Value = det.items[i];
                    GridDetalles.Rows[n].Cells[1].Value = det.valores[i];
                }
                int m = GridDetalles.Rows.Add();
                GridDetalles.Rows[m].Cells[1].Value = "FIN DE LA EJECUCIÓN";

            }
            else
            {
                MessageBox.Show("Debe calcular la ganancia por la venta de entradas antes de ver los detalles.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            //se vacían los espacios que llenó el usuario
            metros2.Text = "";
            tribunas.Text = "";
            escenario.Text = "";
            resultado.Text = "";
            comunes.Text = "";
            vip.Text = "";
            ganancias.Text = "";
        }
    }
}