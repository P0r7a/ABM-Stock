namespace Stock
{
    partial class ventanapr
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
            this.components = new System.ComponentModel.Container();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnEli = new System.Windows.Forms.Button();
            this.btnAña = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctSalir = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnusua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -6;
            this.lineShape1.X2 = 703;
            this.lineShape1.Y1 = 29;
            this.lineShape1.Y2 = 29;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(929, 532);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -7;
            this.lineShape2.X2 = 702;
            this.lineShape2.Y1 = 0;
            this.lineShape2.Y2 = 0;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusqueda.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.txtbusqueda.ForeColor = System.Drawing.Color.White;
            this.txtbusqueda.Location = new System.Drawing.Point(39, 0);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtbusqueda.MaxLength = 20;
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(307, 34);
            this.txtbusqueda.TabIndex = 2;
            this.txtbusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbusqueda_KeyDown);
            this.txtbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusqueda_KeyPress);
            this.txtbusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbusqueda_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(929, 489);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(674, 7);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBox1.Location = new System.Drawing.Point(598, 7);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 23);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Todo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnEli
            // 
            this.btnEli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEli.BackgroundImage = global::Stock.Properties.Resources.minus_regular_24gris;
            this.btnEli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEli.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEli.Location = new System.Drawing.Point(560, 4);
            this.btnEli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEli.Name = "btnEli";
            this.btnEli.Size = new System.Drawing.Size(32, 30);
            this.btnEli.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnEli, "Eliminar un Producto");
            this.btnEli.UseVisualStyleBackColor = false;
            this.btnEli.Click += new System.EventHandler(this.btnEli_Click);
            // 
            // btnAña
            // 
            this.btnAña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAña.BackgroundImage = global::Stock.Properties.Resources.plus_regular_24gris;
            this.btnAña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAña.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAña.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAña.Location = new System.Drawing.Point(522, 4);
            this.btnAña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAña.Name = "btnAña";
            this.btnAña.Size = new System.Drawing.Size(32, 30);
            this.btnAña.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnAña, "Añadir un producto");
            this.btnAña.UseVisualStyleBackColor = false;
            this.btnAña.Click += new System.EventHandler(this.btnAña_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Stock.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pctSalir
            // 
            this.pctSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pctSalir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctSalir.Image = global::Stock.Properties.Resources.x_circle;
            this.pctSalir.Location = new System.Drawing.Point(889, 0);
            this.pctSalir.Margin = new System.Windows.Forms.Padding(4);
            this.pctSalir.Name = "pctSalir";
            this.pctSalir.Size = new System.Drawing.Size(39, 36);
            this.pctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSalir.TabIndex = 10;
            this.pctSalir.TabStop = false;
            this.toolTip1.SetToolTip(this.pctSalir, "Cerrar");
            this.pctSalir.Click += new System.EventHandler(this.pctSalir_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnEdit.Image = global::Stock.Properties.Resources.bxs_edit_alt;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(402, 1);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 34);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEdit, "Editar algun producto");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Stock.Properties.Resources.minus_circle_regular_24;
            this.pictureBox2.Location = new System.Drawing.Point(851, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Minimizar");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnusua
            // 
            this.btnusua.Location = new System.Drawing.Point(358, 2);
            this.btnusua.Name = "btnusua";
            this.btnusua.Size = new System.Drawing.Size(37, 36);
            this.btnusua.TabIndex = 24;
            this.btnusua.Text = "Admin";
            this.btnusua.UseVisualStyleBackColor = true;
            this.btnusua.Visible = false;
            // 
            // ventanapr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(929, 532);
            this.Controls.Add(this.btnusua);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnEli);
            this.Controls.Add(this.btnAña);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pctSalir);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ventanapr";
            this.Opacity = 0.95D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ventanapr";
            this.Load += new System.EventHandler(this.ventanapr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox pctSalir;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAña;
        private System.Windows.Forms.Button btnEli;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnusua;
    }
}