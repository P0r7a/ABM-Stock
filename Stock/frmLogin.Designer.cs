namespace Stock
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtus = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.btnacce = new System.Windows.Forms.Button();
            this.lblReg = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkContra = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctSalir = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 405);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 38;
            this.lineShape2.X2 = 554;
            this.lineShape2.Y1 = 212;
            this.lineShape2.Y2 = 212;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 38;
            this.lineShape1.X2 = 554;
            this.lineShape1.Y1 = 127;
            this.lineShape1.Y2 = 127;
            // 
            // txtus
            // 
            this.txtus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtus.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtus.ForeColor = System.Drawing.Color.DimGray;
            this.txtus.Location = new System.Drawing.Point(51, 128);
            this.txtus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtus.Name = "txtus";
            this.txtus.Size = new System.Drawing.Size(689, 27);
            this.txtus.TabIndex = 1;
            this.txtus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtus_KeyDown);
            this.txtus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtus_KeyPress);
            // 
            // txtcontra
            // 
            this.txtcontra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtcontra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontra.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontra.ForeColor = System.Drawing.Color.DimGray;
            this.txtcontra.Location = new System.Drawing.Point(52, 233);
            this.txtcontra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.PasswordChar = '*';
            this.txtcontra.Size = new System.Drawing.Size(689, 27);
            this.txtcontra.TabIndex = 2;
            this.txtcontra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcontra_KeyDown);
            this.txtcontra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontra_KeyPress);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.DimGray;
            this.Label.Location = new System.Drawing.Point(333, 37);
            this.Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(121, 46);
            this.Label.TabIndex = 3;
            this.Label.Text = "LOGIN";
            // 
            // btnacce
            // 
            this.btnacce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnacce.FlatAppearance.BorderSize = 0;
            this.btnacce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnacce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnacce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacce.ForeColor = System.Drawing.Color.LightGray;
            this.btnacce.Location = new System.Drawing.Point(57, 295);
            this.btnacce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnacce.Name = "btnacce";
            this.btnacce.Size = new System.Drawing.Size(684, 44);
            this.btnacce.TabIndex = 4;
            this.btnacce.Text = "ACCEDER";
            this.btnacce.UseVisualStyleBackColor = false;
            this.btnacce.Click += new System.EventHandler(this.btnacce_Click);
            // 
            // lblReg
            // 
            this.lblReg.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lblReg.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.LinkColor = System.Drawing.Color.White;
            this.lblReg.Location = new System.Drawing.Point(13, 343);
            this.lblReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(773, 53);
            this.lblReg.TabIndex = 5;
            this.lblReg.TabStop = true;
            this.lblReg.Text = "REGISTRARSE";
            this.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblReg_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(51, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(45, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "CONTRASEÑA";
            // 
            // chkContra
            // 
            this.chkContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkContra.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chkContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkContra.Location = new System.Drawing.Point(208, 188);
            this.chkContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkContra.Name = "chkContra";
            this.chkContra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkContra.Size = new System.Drawing.Size(63, 26);
            this.chkContra.TabIndex = 21;
            this.chkContra.UseVisualStyleBackColor = true;
            this.chkContra.CheckedChanged += new System.EventHandler(this.chkContra_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Stock.Properties.Resources.minus_circle_regular_24;
            this.pictureBox1.Location = new System.Drawing.Point(713, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Minimizar");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pctSalir
            // 
            this.pctSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pctSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctSalir.Image = global::Stock.Properties.Resources.x_circle;
            this.pctSalir.Location = new System.Drawing.Point(757, 0);
            this.pctSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctSalir.Name = "pctSalir";
            this.pctSalir.Size = new System.Drawing.Size(43, 39);
            this.pctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSalir.TabIndex = 6;
            this.pctSalir.TabStop = false;
            this.toolTip1.SetToolTip(this.pctSalir, "Cerrar");
            this.pctSalir.Click += new System.EventHandler(this.pctSalir_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkContra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctSalir);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.btnacce);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtus);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombre programa - Inicio de sesión";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox txtus;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button btnacce;
        private System.Windows.Forms.LinkLabel lblReg;
        private System.Windows.Forms.PictureBox pctSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkContra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

