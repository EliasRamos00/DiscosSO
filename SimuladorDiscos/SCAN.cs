using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorDiscos
{
    public partial class SCAN : Form
    {

            #region VARIABLES
           
            int segundosEnProceso = 0;
           
            int tiempoRow;
            int j = 0;
            int segundos = 0;
            int diff = 0;
            int primeraPista;
            int pistaComparar;
            Random r;
            int countLlegada = -1;
            //Stopwatch stw;
            int tiempo = 1;
            int pista = 0;
            int esperaAcomulado = 0;
            int distbaja = 0;
            int rowAEjecutar;
            int indexMasBaja;
            int ñ;
            int pistaSiguiente;
            int indexSeleccionadoPrimero;
            Boolean arriba = true;
            Proceso[] pr = new Proceso[20];
            
            List<int> yaestan = new List<int>();

            #endregion

            #region CONSTRUCTORES
            public SCAN()
            {
                InitializeComponent();
                btnStop.Hide();
            }




        #endregion

        #region METODOS

        public void masCercano(int pistaActual)
        {
            arriba = true;
            distbaja = 500;
            for (int i = 0; i < 10; i++)
            {
                
                    if (pr[i].prioridad != pr[indexSeleccionadoPrimero].prioridad)
                    {
                        pistaComparar = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                        diff = pistaComparar - pistaActual;
                        diff = Math.Abs(diff);
                        if (diff <= distbaja && pistaComparar>= pistaActual && BuscarRepetidos(i))
                        {
                            distbaja = diff;
                            indexMasBaja = i;
                            arriba = false;
                        }

                    }

                
            }
            for (int i = 0; i < 10; i++)
            {
                if (arriba)
                {

                    if (pr[i].prioridad != pr[indexSeleccionadoPrimero].prioridad)
                    {
                        pistaComparar = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                        diff = pistaComparar - pistaActual;
                        diff = Math.Abs(diff);
                        if (diff <= distbaja && diff != 0 && BuscarRepetidos(i))
                        {

                            distbaja = diff;
                            indexMasBaja = i;
                        }

                    }

                }
            }
        }
            public int GenerarTiempo()
            {
                int Local_random;
                Local_random = r.Next(15) + 7;
                return Local_random;
            }
            public int GenerarPista()
            {
                int Local_random;
                Local_random = (r.Next(500) + 1);
                return Local_random;
            }
            private Proceso generarNP()
            {
                r = new Random(System.DateTime.Now.Millisecond);
                string aux = "";
                int Local_random;
                for (int i = 0; i < 5; i++)
                {
                    Local_random = r.Next(15);
                    switch (Local_random)
                    {
                        case 10:
                            aux += "A";
                            break;
                        case 11:
                            aux += "B";
                            break;
                        case 12:
                            aux += "C";
                            break;
                        case 13:
                            aux += "D";
                            break;
                        case 14:
                            aux += "E";
                            break;
                        case 15:
                            aux += "F";
                            break;
                        default:
                            aux += "" + Local_random;
                            break;
                    }
                }
                tiempo = GenerarTiempo();
                pista = GenerarPista();
                countLlegada++;
                return new Proceso(aux, countLlegada, tiempo, pista, tiempo);//string n, int ll, int cpu, int prio,int t
            }
            private void Acomodar(Proceso p)
            {
                pr[countLlegada] = p;
            }
            private void ActualizarFilas()
            {

                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];
                string nombre = pr[j].nombre;
                int Llegada = pr[j].llegada;
                int CPU = pr[j].cpu;
                int Prio = pr[j].prioridad;
                int Tiempo = pr[j].tiempo;
                // Add the data: cpu, prioridad, tiempo, tiempor, tiempoe;
                row.Cells["dgvProceso"].Value = nombre;
                row.Cells["dgvLlegada"].Value = countLlegada;
                row.Cells["dgvCPU"].Value = tiempo;
                row.Cells["dgvPrioridad"].Value = pista;
                row.Cells["dgvTiempo"].Value = tiempo;
                //row.Cells["dgvTiempoRetorno"].Value = "0";
                row.Cells["dgvTiempoEspera"].Value = "0";
                j++;

            }
            private void tiempoSelectedRow()
            {
                dataGridView1.Rows[rowAEjecutar].Selected = true;
                tiempoRow = Convert.ToInt32(dataGridView1.Rows[rowAEjecutar].Cells[4].Value);
            }
            private void tiempoSelectedRow2(int row)
            {

                dataGridView1.Rows[row].Selected = true;
                tiempoRow = Convert.ToInt32(dataGridView1.Rows[row].Cells[4].Value);
                indexSeleccionadoPrimero = row;


            }
            public void aEjecutar()
            {
                rowAEjecutar = pr[indexMasBaja].llegada;
                tiempoSelectedRow2(rowAEjecutar);
            }
            public Boolean BuscarRepetidos(int j)
            {
                if (yaestan.Count >= 0)
                {
                    for (int i = 0; i < yaestan.Count; i++)
                    {
                        if (j == yaestan[i])
                        {
                            return false;
                        }
                    }

                }

                return true;
            }


            private Boolean terminoProceso()
            {
                if (tiempoRow == segundosEnProceso)
                {
                    dataGridView1.Rows[rowAEjecutar].Cells[5].Value = esperaAcomulado;
                    esperaAcomulado = segundosEnProceso + esperaAcomulado;
                    segundosEnProceso = 0;
                    tiempoRow = 0;
                    dataGridView1.Rows[rowAEjecutar].DefaultCellStyle.BackColor = Color.Yellow;
                    pistaSiguiente = Convert.ToInt32(dataGridView1.Rows[rowAEjecutar].Cells[3].Value);
                    dataGridView1.Rows[rowAEjecutar].Selected = false;
                    yaestan.Add(rowAEjecutar);
                    masCercano(pistaSiguiente);
                    aEjecutar();


                    Fila++; k++;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            #endregion

            #region EVENTOS

            #endregion

            private void btnStart_Click(object sender, EventArgs e)
            {
                btnStop.Show();
                 btnStart.Hide();
                timer.Enabled = true;
                for (int i = 0; i <= 9; i++)
                {
                    Acomodar(generarNP());
                    ActualizarFilas();
                    Thread.Sleep(7);

                }
            }

            private void lblTimer_TextChanged(object sender, EventArgs e)
            {
                btnStart.Enabled = false;
                if (ñ == 0)
                {
                    primeraPista = Convert.ToInt32(dataGridView1.Rows[0].Cells[3].Value);

                    masCercano(primeraPista);
                }
                ñ = 1;
                if (tiempoRow == 0)
                {
                    tiempoSelectedRow();
                    if (terminoProceso())
                    {
                        dataGridView1.Rows[rowAEjecutar].DefaultCellStyle.BackColor = Color.Yellow;

                    }


                }
                if (terminoProceso())
                {
                    dataGridView1.Rows[rowAEjecutar].DefaultCellStyle.BackColor = Color.Yellow;

                }
                if (segundos == 200)
                {

                    timer.Enabled = false;

                }

            }

            private void timer_Tick(object sender, EventArgs e)
            {
                segundos++;
                segundosEnProceso++;
                lblTimer.Text = segundos.ToString();
                if (yaestan.Count == 10)
                {
                    timer.Enabled = false;
                    dataGridView1.Rows[rowAEjecutar].Selected = false;
                }
            }

            private void btnBack_Click(object sender, EventArgs e)
            {
                this.Hide();
                Menu nuevoForm = new Menu();
                nuevoForm.ShowDialog();
            }

            private void btnStop_Click(object sender, EventArgs e)
            {


                if (timer.Enabled)
                {
                    btnStop.Text = "Reanudar";
                    timer.Stop();
                    return;
                }

                if (!timer.Enabled)
                {
                    btnStop.Text = "Detener";
                    timer.Start();
                    return;
                }


            }
        }

    }

