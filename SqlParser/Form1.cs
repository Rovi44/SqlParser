using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlParser.Clases;
using System.Data.SqlClient;

namespace SqlParser
{
    public partial class Form1 : Form
    {
        connect conexion;
 
        public Form1()
        {
            conexion = new connect();
            List<string> bases = conexion.actualizarBases();
            InitializeComponent();
            cbDataBases.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (string actual in bases)
            {
                cbDataBases.Items.Add(actual);
            }
            if (cbDataBases.Items.Count > 0)
            {
                cbDataBases.SelectedIndex = 0;
            }
        }

        private void ActualizarBDD()
        {
            bdd.Nodes.Clear();
            List<string> tablas;
            TreeNode[] nodos;
            List<string> bases = conexion.actualizarBases();
            foreach (string actual in bases)
            {
                tablas = conexion.getTablas(actual);
                nodos = new TreeNode[tablas.Count];
                for (int i = 0; i < tablas.Count; i++)
                {
                    nodos[i] = new TreeNode(tablas[i]);
                }
                TreeNode nuevo = new TreeNode(actual, nodos);
                bdd.Nodes.Add(nuevo);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarBDD();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            cbDataBases.Items.Clear();
            List<string> bases = conexion.actualizarBases();
            foreach (string actual in bases)
                cbDataBases.Items.Add(actual);
            if (cbDataBases.Items.Count > 0)
            {
                cbDataBases.SelectedIndex = 0;
            }
        }
    }
}
