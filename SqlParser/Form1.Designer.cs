namespace SqlParser
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SQL = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDataBases = new System.Windows.Forms.ComboBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.Administrar = new System.Windows.Forms.TabPage();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.bdd = new System.Windows.Forms.TreeView();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SQL.SuspendLayout();
            this.Administrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su cunsulta:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(21, 195);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(508, 117);
            this.txtResultado.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SQL);
            this.tabControl1.Controls.Add(this.Administrar);
            this.tabControl1.Location = new System.Drawing.Point(3, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 355);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // SQL
            // 
            this.SQL.BackColor = System.Drawing.Color.Transparent;
            this.SQL.Controls.Add(this.btnEjecutar);
            this.SQL.Controls.Add(this.label3);
            this.SQL.Controls.Add(this.cbDataBases);
            this.SQL.Controls.Add(this.txtConsulta);
            this.SQL.Controls.Add(this.label1);
            this.SQL.Controls.Add(this.txtResultado);
            this.SQL.Controls.Add(this.label2);
            this.SQL.Location = new System.Drawing.Point(4, 22);
            this.SQL.Name = "SQL";
            this.SQL.Padding = new System.Windows.Forms.Padding(3);
            this.SQL.Size = new System.Drawing.Size(548, 329);
            this.SQL.TabIndex = 0;
            this.SQL.Text = "SQL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usando:";
            // 
            // cbDataBases
            // 
            this.cbDataBases.FormattingEnabled = true;
            this.cbDataBases.Location = new System.Drawing.Point(219, 18);
            this.cbDataBases.Name = "cbDataBases";
            this.cbDataBases.Size = new System.Drawing.Size(122, 21);
            this.cbDataBases.TabIndex = 7;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(21, 59);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(508, 117);
            this.txtConsulta.TabIndex = 6;
            // 
            // Administrar
            // 
            this.Administrar.BackColor = System.Drawing.Color.Transparent;
            this.Administrar.Controls.Add(this.btnActualizar);
            this.Administrar.Controls.Add(this.bdd);
            this.Administrar.Location = new System.Drawing.Point(4, 22);
            this.Administrar.Name = "Administrar";
            this.Administrar.Padding = new System.Windows.Forms.Padding(3);
            this.Administrar.Size = new System.Drawing.Size(548, 329);
            this.Administrar.TabIndex = 1;
            this.Administrar.Text = "Administrar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(6, 6);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(108, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // bdd
            // 
            this.bdd.Location = new System.Drawing.Point(120, 6);
            this.bdd.Name = "bdd";
            this.bdd.Size = new System.Drawing.Size(302, 302);
            this.bdd.TabIndex = 0;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(347, 16);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(113, 23);
            this.btnEjecutar.TabIndex = 9;
            this.btnEjecutar.Text = "Ejecutar Comando";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 368);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.SQL.ResumeLayout(false);
            this.SQL.PerformLayout();
            this.Administrar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SQL;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.TabPage Administrar;
        private System.Windows.Forms.TreeView bdd;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDataBases;
        private System.Windows.Forms.Button btnEjecutar;
    }
}

