namespace pryProductoCategoria.Vista
{
    partial class frmSeleccionarCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.TXTIDCAT = new System.Windows.Forms.TextBox();
            this.TXTCATEGORIA = new System.Windows.Forms.TextBox();
            this.TXTESTADO = new System.Windows.Forms.TextBox();
            this.TABLASELECCIONARCATEGORIA = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TABLASELECCIONARCATEGORIA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "::: Seleccionar Categoria :::";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtrar:";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(171, 107);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(300, 22);
            this.txtFiltrar.TabIndex = 2;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // TXTIDCAT
            // 
            this.TXTIDCAT.Location = new System.Drawing.Point(636, 211);
            this.TXTIDCAT.Name = "TXTIDCAT";
            this.TXTIDCAT.ReadOnly = true;
            this.TXTIDCAT.Size = new System.Drawing.Size(100, 22);
            this.TXTIDCAT.TabIndex = 3;
            // 
            // TXTCATEGORIA
            // 
            this.TXTCATEGORIA.Location = new System.Drawing.Point(636, 280);
            this.TXTCATEGORIA.Name = "TXTCATEGORIA";
            this.TXTCATEGORIA.ReadOnly = true;
            this.TXTCATEGORIA.Size = new System.Drawing.Size(100, 22);
            this.TXTCATEGORIA.TabIndex = 4;
            // 
            // TXTESTADO
            // 
            this.TXTESTADO.Location = new System.Drawing.Point(636, 341);
            this.TXTESTADO.Name = "TXTESTADO";
            this.TXTESTADO.ReadOnly = true;
            this.TXTESTADO.Size = new System.Drawing.Size(100, 22);
            this.TXTESTADO.TabIndex = 5;
            // 
            // TABLASELECCIONARCATEGORIA
            // 
            this.TABLASELECCIONARCATEGORIA.AllowUserToAddRows = false;
            this.TABLASELECCIONARCATEGORIA.AllowUserToDeleteRows = false;
            this.TABLASELECCIONARCATEGORIA.AllowUserToResizeColumns = false;
            this.TABLASELECCIONARCATEGORIA.AllowUserToResizeRows = false;
            this.TABLASELECCIONARCATEGORIA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TABLASELECCIONARCATEGORIA.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TABLASELECCIONARCATEGORIA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TABLASELECCIONARCATEGORIA.ColumnHeadersHeight = 50;
            this.TABLASELECCIONARCATEGORIA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Categoria,
            this.col_Estado});
            this.TABLASELECCIONARCATEGORIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TABLASELECCIONARCATEGORIA.EnableHeadersVisualStyles = false;
            this.TABLASELECCIONARCATEGORIA.Location = new System.Drawing.Point(21, 157);
            this.TABLASELECCIONARCATEGORIA.MultiSelect = false;
            this.TABLASELECCIONARCATEGORIA.Name = "TABLASELECCIONARCATEGORIA";
            this.TABLASELECCIONARCATEGORIA.ReadOnly = true;
            this.TABLASELECCIONARCATEGORIA.RowHeadersVisible = false;
            this.TABLASELECCIONARCATEGORIA.RowHeadersWidth = 51;
            this.TABLASELECCIONARCATEGORIA.RowTemplate.Height = 24;
            this.TABLASELECCIONARCATEGORIA.RowTemplate.ReadOnly = true;
            this.TABLASELECCIONARCATEGORIA.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TABLASELECCIONARCATEGORIA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TABLASELECCIONARCATEGORIA.Size = new System.Drawing.Size(536, 248);
            this.TABLASELECCIONARCATEGORIA.TabIndex = 6;
            this.TABLASELECCIONARCATEGORIA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLASELECCIONARCATEGORIA_CellClick);
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "ID";
            this.col_ID.MinimumWidth = 6;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_Categoria
            // 
            this.col_Categoria.HeaderText = "CATEGORIA";
            this.col_Categoria.MinimumWidth = 6;
            this.col_Categoria.Name = "col_Categoria";
            this.col_Categoria.ReadOnly = true;
            // 
            // col_Estado
            // 
            this.col_Estado.HeaderText = "ESTADO";
            this.col_Estado.MinimumWidth = 6;
            this.col_Estado.Name = "col_Estado";
            this.col_Estado.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "CATEGORIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(639, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "ESTADO";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Lime;
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.Enabled = false;
            this.btnSeleccionar.Location = new System.Drawing.Point(627, 65);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(121, 36);
            this.btnSeleccionar.TabIndex = 10;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(627, 107);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 36);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmSeleccionarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 512);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TABLASELECCIONARCATEGORIA);
            this.Controls.Add(this.TXTESTADO);
            this.Controls.Add(this.TXTCATEGORIA);
            this.Controls.Add(this.TXTIDCAT);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSeleccionarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSeleccionarCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.TABLASELECCIONARCATEGORIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.TextBox TXTIDCAT;
        private System.Windows.Forms.TextBox TXTCATEGORIA;
        private System.Windows.Forms.TextBox TXTESTADO;
        private System.Windows.Forms.DataGridView TABLASELECCIONARCATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Estado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
    }
}