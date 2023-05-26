namespace pryProductoCategoria.Vista
{
    partial class frmProductos
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDpro = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.NumericUpDown();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.NumericUpDown();
            txtIDcat = new System.Windows.Forms.TextBox();
            txtCategoria = new System.Windows.Forms.TextBox();
            txtEstadoCat = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionarCategoria = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.TABLAPRODUCTOS = new System.Windows.Forms.DataGridView();
            this.col_IDprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDcat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_EstadoCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLAPRODUCTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "TABLAS PRODUCTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "PRODUCTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "STOCK:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "PRECIO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID CAT.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "CATEGORIA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(563, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "ESTADO:";
            // 
            // txtIDpro
            // 
            this.txtIDpro.Location = new System.Drawing.Point(99, 154);
            this.txtIDpro.Name = "txtIDpro";
            this.txtIDpro.ReadOnly = true;
            this.txtIDpro.Size = new System.Drawing.Size(100, 22);
            this.txtIDpro.TabIndex = 16;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(417, 154);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(120, 22);
            this.txtStock.TabIndex = 17;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(236, 154);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(142, 22);
            this.txtProducto.TabIndex = 18;
            // 
            // txtPrecio
            // 
            this.txtPrecio.DecimalPlaces = 2;
            this.txtPrecio.Location = new System.Drawing.Point(606, 153);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 22);
            this.txtPrecio.TabIndex = 19;
            // 
            // txtIDcat
            // 
            txtIDcat.Location = new System.Drawing.Point(278, 276);
            txtIDcat.Name = "txtIDcat";
            txtIDcat.ReadOnly = true;
            txtIDcat.Size = new System.Drawing.Size(100, 22);
            txtIDcat.TabIndex = 20;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new System.Drawing.Point(403, 276);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.ReadOnly = true;
            txtCategoria.Size = new System.Drawing.Size(100, 22);
            txtCategoria.TabIndex = 21;
            // 
            // txtEstadoCat
            // 
            txtEstadoCat.Location = new System.Drawing.Point(552, 276);
            txtEstadoCat.Name = "txtEstadoCat";
            txtEstadoCat.ReadOnly = true;
            txtEstadoCat.Size = new System.Drawing.Size(100, 22);
            txtEstadoCat.TabIndex = 22;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Blue;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Location = new System.Drawing.Point(155, 347);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 45);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(280, 347);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 45);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(406, 347);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 45);
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(532, 347);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 45);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionarCategoria
            // 
            this.btnSeleccionarCategoria.BackColor = System.Drawing.Color.Aqua;
            this.btnSeleccionarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarCategoria.Location = new System.Drawing.Point(113, 227);
            this.btnSeleccionarCategoria.Name = "btnSeleccionarCategoria";
            this.btnSeleccionarCategoria.Size = new System.Drawing.Size(106, 56);
            this.btnSeleccionarCategoria.TabIndex = 27;
            this.btnSeleccionarCategoria.Text = "Seleccionar Categoria";
            this.btnSeleccionarCategoria.UseVisualStyleBackColor = false;
            this.btnSeleccionarCategoria.Click += new System.EventHandler(this.btnSeleccionarCategoria_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.Lime;
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.Location = new System.Drawing.Point(13, 13);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(106, 42);
            this.btnCategorias.TabIndex = 28;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // TABLAPRODUCTOS
            // 
            this.TABLAPRODUCTOS.AllowUserToAddRows = false;
            this.TABLAPRODUCTOS.AllowUserToDeleteRows = false;
            this.TABLAPRODUCTOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TABLAPRODUCTOS.BackgroundColor = System.Drawing.Color.White;
            this.TABLAPRODUCTOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TABLAPRODUCTOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TABLAPRODUCTOS.ColumnHeadersHeight = 50;
            this.TABLAPRODUCTOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_IDprod,
            this.col_Producto,
            this.col_Stock,
            this.col_Precio,
            this.col_IDcat,
            this.col_Categoria,
            this.col_EstadoCat});
            this.TABLAPRODUCTOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TABLAPRODUCTOS.EnableHeadersVisualStyles = false;
            this.TABLAPRODUCTOS.Location = new System.Drawing.Point(13, 445);
            this.TABLAPRODUCTOS.MultiSelect = false;
            this.TABLAPRODUCTOS.Name = "TABLAPRODUCTOS";
            this.TABLAPRODUCTOS.ReadOnly = true;
            this.TABLAPRODUCTOS.RowHeadersVisible = false;
            this.TABLAPRODUCTOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.TABLAPRODUCTOS.RowTemplate.Height = 24;
            this.TABLAPRODUCTOS.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TABLAPRODUCTOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TABLAPRODUCTOS.Size = new System.Drawing.Size(954, 202);
            this.TABLAPRODUCTOS.TabIndex = 29;
            this.TABLAPRODUCTOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLAPRODUCTOS_CellClick);
            // 
            // col_IDprod
            // 
            this.col_IDprod.HeaderText = "ID PROD.";
            this.col_IDprod.MinimumWidth = 6;
            this.col_IDprod.Name = "col_IDprod";
            this.col_IDprod.ReadOnly = true;
            // 
            // col_Producto
            // 
            this.col_Producto.HeaderText = "PRODUCTO";
            this.col_Producto.MinimumWidth = 6;
            this.col_Producto.Name = "col_Producto";
            this.col_Producto.ReadOnly = true;
            // 
            // col_Stock
            // 
            this.col_Stock.HeaderText = "STOCK";
            this.col_Stock.MinimumWidth = 6;
            this.col_Stock.Name = "col_Stock";
            this.col_Stock.ReadOnly = true;
            // 
            // col_Precio
            // 
            this.col_Precio.HeaderText = "PRECIO";
            this.col_Precio.MinimumWidth = 6;
            this.col_Precio.Name = "col_Precio";
            this.col_Precio.ReadOnly = true;
            // 
            // col_IDcat
            // 
            this.col_IDcat.HeaderText = "ID CAT.";
            this.col_IDcat.MinimumWidth = 6;
            this.col_IDcat.Name = "col_IDcat";
            this.col_IDcat.ReadOnly = true;
            // 
            // col_Categoria
            // 
            this.col_Categoria.HeaderText = "CATEGORIA";
            this.col_Categoria.MinimumWidth = 6;
            this.col_Categoria.Name = "col_Categoria";
            this.col_Categoria.ReadOnly = true;
            // 
            // col_EstadoCat
            // 
            this.col_EstadoCat.HeaderText = "ESTADO CAT.";
            this.col_EstadoCat.MinimumWidth = 6;
            this.col_EstadoCat.Name = "col_EstadoCat";
            this.col_EstadoCat.ReadOnly = true;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 680);
            this.Controls.Add(this.TABLAPRODUCTOS);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnSeleccionarCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(txtEstadoCat);
            this.Controls.Add(txtCategoria);
            this.Controls.Add(txtIDcat);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtIDpro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductos";
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLAPRODUCTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDpro;
        private System.Windows.Forms.NumericUpDown txtStock;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.NumericUpDown txtPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionarCategoria;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDcat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_EstadoCat;
        private System.Windows.Forms.DataGridView TABLAPRODUCTOS;
        public static System.Windows.Forms.TextBox txtIDcat;
        public static System.Windows.Forms.TextBox txtCategoria;
        public static System.Windows.Forms.TextBox txtEstadoCat;
    }
}