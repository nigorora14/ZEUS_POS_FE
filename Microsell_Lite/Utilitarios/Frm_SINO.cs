﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPV_Capa_Negocio;

namespace Microsell_Lite.Utilitarios
{
    public partial class Frm_SINO : Form
    {
        public Frm_SINO()
        {
            InitializeComponent();
        }
        RN_Categoria obj = new RN_Categoria();
        private void Frm_Reg_Prod_Load(object sender, EventArgs e)
        {
            
        }

        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
            

            if (e.Button == MouseButtons.Left)
            {
                Utilitario obj = new Utilitario();
                obj.Mover_formulario(this);
            }
        }

        
        public bool editar = false;

        private void btn_NO_Click(object sender, EventArgs e)
        {
            this.Tag = "NO";
            this.Close();
        }

        private void btn_SI_Click(object sender, EventArgs e)
        {
            this.Tag = "SI";
            this.Close();
        }

        private void lbl_msm_Click(object sender, EventArgs e)
        {

        }
    }
}
