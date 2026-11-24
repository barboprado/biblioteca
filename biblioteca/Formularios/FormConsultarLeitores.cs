using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using biblioteca.contexto;
using biblioteca.Models;

namespace biblioteca.Formularios
{
    public partial class FormConsultarLeitores : Form
    {
        public FormConsultarLeitores()
        {
            InitializeComponent();
            cbLeitor.DataSource=ContextoBD.leitores.ToList();
            cbLeitor.SelectedIndex = -1;
        }

        private void cbLeitor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
