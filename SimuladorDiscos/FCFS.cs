using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SimuladorDiscos
{
    public partial class FCFS : Form
    {
        #region VARIABLES
        int k = 0;
        int Fila = 0;
        int segundosEnProceso=0;
        Boolean proAct=false;
        int tiempoRow;
        int j = 0;
        int segundos = 0;
        Random r;
        int countLlegada=-1;
        //Stopwatch stw;
        int tiempo=1;
        int prioridad=0;
        int esperaAcomulado = 0;
        Proceso[] pr = new Proceso[20];
        #endregion
        #region CONSTRUCTORES
        public FCFS()
        {
            InitializeComponent();
        }
        #endregion
        #region METODOS
        public int GenerarTiempo() 
        {
            int Local_random;
            Local_random = r.Next(15)+7;   
            return Local_random;
        }
        public int GenerarPrioridad()
        {
            int Local_random;
            Local_random = (r.Next(3)+1)*87;
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
            prioridad = GenerarPrioridad();
            countLlegada ++;
            return new Proceso(aux,countLlegada, tiempo, prioridad, tiempo );//string n, int ll, int cpu, int prio,int t
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
                    row.Cells["dgvPrioridad"].Value = prioridad;
                    row.Cells["dgvTiempo"].Value = tiempo;
                    //row.Cells["dgvTiempoRetorno"].Value = "0";
                    row.Cells["dgvTiempoEspera"].Value = "0";
            j++;
                                      
        }
        private void Acomodar(Proceso p) 
        {                     
                pr[countLlegada] = p;     
        }

        private void tiempoSelectedRow()
        {
            if (k<=6)
            {
            dataGridView1.Rows[k].Selected = true;         
            tiempoRow=  Convert.ToInt32(dataGridView1.Rows[k].Cells[4].Value);
            }
            terminoProceso();
           

        }


        #endregion
        #region EVENTOS
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu form = new Menu();
            form.Show();
        }
        private void FCFS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            segundos++;
            segundosEnProceso++;
            lblTimer.Text = segundos.ToString();
        }
        private Boolean terminoProceso() 
        {
            if (tiempoRow == segundosEnProceso)
            {                
               dataGridView1.Rows[k].Cells[5].Value = esperaAcomulado;
                esperaAcomulado = segundosEnProceso + esperaAcomulado;
                segundosEnProceso = 0;
                tiempoRow = 0;
                dataGridView1.Rows[k].Selected = false;

                Fila++; k++;
                return true;
            }
            else 
            {
                return false;
            }  
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            for (int i = 0; i <= 6; i++)
            {
                Acomodar(generarNP());    
                ActualizarFilas();                
                Thread.Sleep(100);
            }

          
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

    private void lblTimer_TextChanged(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            if (tiempoRow == 0)
            {
                tiempoSelectedRow();

                if (terminoProceso())
                {
                    dataGridView1.Rows[Fila-1].DefaultCellStyle.BackColor = Color.Yellow;

                }


            }
            if (terminoProceso())
            {
                dataGridView1.Rows[Fila-1].DefaultCellStyle.BackColor = Color.Yellow;

            }
            if (segundos== 150) 
            {
                timer.Enabled = false;

            }


        }
        private void lblLabelTimer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FCFS nuevoForm = new FCFS();
            nuevoForm.Show();
        }
    }


        #endregion
    }
