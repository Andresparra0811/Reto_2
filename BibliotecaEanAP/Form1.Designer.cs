namespace BibliotecaEanAP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Nuevo = new System.Windows.Forms.Button();
            this.borrarbutt = new System.Windows.Forms.Button();
            this.editarbutt = new System.Windows.Forms.Button();
            this.añadirbutt = new System.Windows.Forms.Button();
            this.buscatbutt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Libro = new System.Windows.Forms.GroupBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txteditorial = new System.Windows.Forms.TextBox();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Libro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Snow;
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.Controls.Add(this.Nuevo);
            this.splitContainer1.Panel2.Controls.Add(this.borrarbutt);
            this.splitContainer1.Panel2.Controls.Add(this.editarbutt);
            this.splitContainer1.Panel2.Controls.Add(this.añadirbutt);
            this.splitContainer1.Panel2.Controls.Add(this.buscatbutt);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.Libro);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1346, 655);
            this.splitContainer1.SplitterDistance = 962;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(60, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(856, 482);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 95);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(326, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(361, 50);
            this.label7.TabIndex = 0;
            this.label7.Text = "LISTA LIBROS";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nuevo.FlatAppearance.BorderSize = 0;
            this.Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
            this.Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevo.Location = new System.Drawing.Point(0, 465);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Nuevo.Size = new System.Drawing.Size(380, 38);
            this.Nuevo.TabIndex = 17;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = false;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // borrarbutt
            // 
            this.borrarbutt.BackColor = System.Drawing.Color.Coral;
            this.borrarbutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrarbutt.FlatAppearance.BorderSize = 0;
            this.borrarbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarbutt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarbutt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.borrarbutt.Image = ((System.Drawing.Image)(resources.GetObject("borrarbutt.Image")));
            this.borrarbutt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrarbutt.Location = new System.Drawing.Point(0, 500);
            this.borrarbutt.Name = "borrarbutt";
            this.borrarbutt.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.borrarbutt.Size = new System.Drawing.Size(380, 38);
            this.borrarbutt.TabIndex = 16;
            this.borrarbutt.Text = "Borrar";
            this.borrarbutt.UseVisualStyleBackColor = false;
            this.borrarbutt.Click += new System.EventHandler(this.borrarbutt_Click);
            // 
            // editarbutt
            // 
            this.editarbutt.BackColor = System.Drawing.Color.IndianRed;
            this.editarbutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarbutt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editarbutt.FlatAppearance.BorderSize = 0;
            this.editarbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarbutt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarbutt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editarbutt.Image = ((System.Drawing.Image)(resources.GetObject("editarbutt.Image")));
            this.editarbutt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editarbutt.Location = new System.Drawing.Point(0, 534);
            this.editarbutt.Name = "editarbutt";
            this.editarbutt.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.editarbutt.Size = new System.Drawing.Size(380, 41);
            this.editarbutt.TabIndex = 15;
            this.editarbutt.Text = "Editar";
            this.editarbutt.UseVisualStyleBackColor = false;
            this.editarbutt.Click += new System.EventHandler(this.editarbutt_Click);
            // 
            // añadirbutt
            // 
            this.añadirbutt.BackColor = System.Drawing.Color.Purple;
            this.añadirbutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.añadirbutt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.añadirbutt.FlatAppearance.BorderSize = 0;
            this.añadirbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.añadirbutt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añadirbutt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.añadirbutt.Image = ((System.Drawing.Image)(resources.GetObject("añadirbutt.Image")));
            this.añadirbutt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.añadirbutt.Location = new System.Drawing.Point(0, 575);
            this.añadirbutt.Name = "añadirbutt";
            this.añadirbutt.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.añadirbutt.Size = new System.Drawing.Size(380, 42);
            this.añadirbutt.TabIndex = 14;
            this.añadirbutt.Text = "Añadir";
            this.añadirbutt.UseVisualStyleBackColor = false;
            this.añadirbutt.Click += new System.EventHandler(this.button2_Click);
            // 
            // buscatbutt
            // 
            this.buscatbutt.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buscatbutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscatbutt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buscatbutt.FlatAppearance.BorderSize = 0;
            this.buscatbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscatbutt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscatbutt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buscatbutt.Image = ((System.Drawing.Image)(resources.GetObject("buscatbutt.Image")));
            this.buscatbutt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscatbutt.Location = new System.Drawing.Point(0, 617);
            this.buscatbutt.Name = "buscatbutt";
            this.buscatbutt.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buscatbutt.Size = new System.Drawing.Size(380, 38);
            this.buscatbutt.TabIndex = 13;
            this.buscatbutt.Text = "Buscar";
            this.buscatbutt.UseVisualStyleBackColor = false;
            this.buscatbutt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbusqueda);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(3, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 65);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(71, 36);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(268, 20);
            this.txtbusqueda.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "TÍTULO";
            // 
            // Libro
            // 
            this.Libro.Controls.Add(this.txtcantidad);
            this.Libro.Controls.Add(this.txtprecio);
            this.Libro.Controls.Add(this.txteditorial);
            this.Libro.Controls.Add(this.txtautor);
            this.Libro.Controls.Add(this.txttitulo);
            this.Libro.Controls.Add(this.txtcodigo);
            this.Libro.Controls.Add(this.label6);
            this.Libro.Controls.Add(this.label5);
            this.Libro.Controls.Add(this.label4);
            this.Libro.Controls.Add(this.label3);
            this.Libro.Controls.Add(this.label2);
            this.Libro.Controls.Add(this.label1);
            this.Libro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Libro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Libro.Location = new System.Drawing.Point(3, 104);
            this.Libro.Name = "Libro";
            this.Libro.Size = new System.Drawing.Size(377, 212);
            this.Libro.TabIndex = 1;
            this.Libro.TabStop = false;
            this.Libro.Text = "Datos Libro";
            this.Libro.Enter += new System.EventHandler(this.Libro_Enter);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(85, 182);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(268, 20);
            this.txtcantidad.TabIndex = 11;
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(85, 152);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(268, 20);
            this.txtprecio.TabIndex = 10;
            // 
            // txteditorial
            // 
            this.txteditorial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteditorial.Location = new System.Drawing.Point(85, 122);
            this.txteditorial.Name = "txteditorial";
            this.txteditorial.Size = new System.Drawing.Size(268, 20);
            this.txteditorial.TabIndex = 9;
            // 
            // txtautor
            // 
            this.txtautor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtautor.Location = new System.Drawing.Point(85, 92);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(268, 20);
            this.txtautor.TabIndex = 8;
            // 
            // txttitulo
            // 
            this.txttitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.Location = new System.Drawing.Point(85, 62);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(268, 20);
            this.txttitulo.TabIndex = 7;
            this.txttitulo.TextChanged += new System.EventHandler(this.txttitulo_TextChanged);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(85, 32);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(268, 20);
            this.txtcodigo.TabIndex = 6;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "CANTIDAD";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "PRECIO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "EDITORIAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "AUTOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÍTULO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÓDIGO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1346, 655);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Libro.ResumeLayout(false);
            this.Libro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Libro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txteditorial;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button borrarbutt;
        private System.Windows.Forms.Button editarbutt;
        private System.Windows.Forms.Button añadirbutt;
        private System.Windows.Forms.Button buscatbutt;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}

