using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorDiscos
{
    public partial class Menu : Form
    {
        #region VARIABLES

        #endregion
        #region CONSTRUCTORES
        public Menu()
        {
            InitializeComponent();
        }
        #endregion
        #region METODOS

        #endregion
        #region EVENTOS
        private void btnFCFS_Click(object sender, EventArgs e)
        {
            FCFS form = new FCFS();
            form.ShowDialog();
            //this.Hide();
        }
        private void btnSSTF_Click(object sender, EventArgs e)
        {
            SSTF form = new SSTF();
            form.ShowDialog();
            //this.Hide();
        }
        private void btnSCAN_Click(object sender, EventArgs e)
        {
            SCAN form = new SCAN();
            form.ShowDialog();
            //this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
