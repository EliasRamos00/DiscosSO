﻿using System;
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
    public partial class FCFS : Form
    {
        #region VARIABLES

        #endregion
        #region CONSTRUCTORES
        public FCFS()
        {
            InitializeComponent();
        }
        #endregion
        #region METODOS

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

        }
        #endregion
    }
}
