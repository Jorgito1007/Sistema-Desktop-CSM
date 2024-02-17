namespace Ginmasio
{
    partial class Frm_Calificaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbgrupos = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdocente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtcodasig = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtasignatura = new System.Windows.Forms.TextBox();
            this.txtturno = new System.Windows.Forms.TextBox();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.txtareaconocimiento = new System.Windows.Forms.TextBox();
            this.btnmostrarlista = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridLista = new System.Windows.Forms.DataGridView();
            this.btnnotas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbgrupo = new System.Windows.Forms.ComboBox();
            this.cbgrupos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLista)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(463, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = " REGISTRO DE CALIFICACIONES";
            // 
            // cbgrupos
            // 
            this.cbgrupos.Controls.Add(this.label2);
            this.cbgrupos.Controls.Add(this.txtdocente);
            this.cbgrupos.Controls.Add(this.btnBuscar);
            this.cbgrupos.Controls.Add(this.txtcedula);
            this.cbgrupos.Controls.Add(this.label7);
            this.cbgrupos.Location = new System.Drawing.Point(13, 61);
            this.cbgrupos.Name = "cbgrupos";
            this.cbgrupos.Size = new System.Drawing.Size(1001, 86);
            this.cbgrupos.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "DOCENTE:";
            // 
            // txtdocente
            // 
            this.txtdocente.Enabled = false;
            this.txtdocente.Location = new System.Drawing.Point(124, 57);
            this.txtdocente.Name = "txtdocente";
            this.txtdocente.Size = new System.Drawing.Size(389, 20);
            this.txtdocente.TabIndex = 40;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Location = new System.Drawing.Point(538, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 23);
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(296, 15);
            this.txtcedula.Multiline = true;
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(209, 23);
            this.txtcedula.TabIndex = 38;
            this.txtcedula.Text = "No Cédula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "NÚMERO DE CEDULA DEL DOCENTE:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbgrupo);
            this.panel2.Controls.Add(this.txtcodasig);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtasignatura);
            this.panel2.Controls.Add(this.txtturno);
            this.panel2.Controls.Add(this.txtcarrera);
            this.panel2.Controls.Add(this.txtareaconocimiento);
            this.panel2.Controls.Add(this.btnmostrarlista);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(13, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 152);
            this.panel2.TabIndex = 8;
            // 
            // txtcodasig
            // 
            this.txtcodasig.Enabled = false;
            this.txtcodasig.Location = new System.Drawing.Point(671, 104);
            this.txtcodasig.Name = "txtcodasig";
            this.txtcodasig.Size = new System.Drawing.Size(100, 20);
            this.txtcodasig.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(513, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 16);
            this.label9.TabIndex = 56;
            this.label9.Text = "CÓDIGO_ASIGNATURA:";
            // 
            // txtasignatura
            // 
            this.txtasignatura.Enabled = false;
            this.txtasignatura.Location = new System.Drawing.Point(116, 104);
            this.txtasignatura.Name = "txtasignatura";
            this.txtasignatura.Size = new System.Drawing.Size(367, 20);
            this.txtasignatura.TabIndex = 55;
            // 
            // txtturno
            // 
            this.txtturno.Enabled = false;
            this.txtturno.Location = new System.Drawing.Point(639, 63);
            this.txtturno.Name = "txtturno";
            this.txtturno.Size = new System.Drawing.Size(196, 20);
            this.txtturno.TabIndex = 54;
            // 
            // txtcarrera
            // 
            this.txtcarrera.Enabled = false;
            this.txtcarrera.Location = new System.Drawing.Point(116, 63);
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(389, 20);
            this.txtcarrera.TabIndex = 53;
            // 
            // txtareaconocimiento
            // 
            this.txtareaconocimiento.Enabled = false;
            this.txtareaconocimiento.Location = new System.Drawing.Point(184, 26);
            this.txtareaconocimiento.Name = "txtareaconocimiento";
            this.txtareaconocimiento.Size = new System.Drawing.Size(353, 20);
            this.txtareaconocimiento.TabIndex = 51;
            // 
            // btnmostrarlista
            // 
            this.btnmostrarlista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.btnmostrarlista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmostrarlista.Enabled = false;
            this.btnmostrarlista.FlatAppearance.BorderSize = 0;
            this.btnmostrarlista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btnmostrarlista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmostrarlista.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrarlista.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnmostrarlista.Location = new System.Drawing.Point(880, 63);
            this.btnmostrarlista.Name = "btnmostrarlista";
            this.btnmostrarlista.Size = new System.Drawing.Size(105, 49);
            this.btnmostrarlista.TabIndex = 42;
            this.btnmostrarlista.Text = "Mostrar Lista";
            this.btnmostrarlista.UseVisualStyleBackColor = false;
            this.btnmostrarlista.Click += new System.EventHandler(this.btnmostrarlista_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 50;
            this.label8.Text = "ASIGNATURA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(577, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "GRUPO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(578, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "TURNO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "CARRERA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "ÁREA DEL CONOCIMIENTO:";
            // 
            // dataGridLista
            // 
            this.dataGridLista.AllowUserToAddRows = false;
            this.dataGridLista.AllowUserToDeleteRows = false;
            this.dataGridLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridLista.Location = new System.Drawing.Point(83, 12);
            this.dataGridLista.Name = "dataGridLista";
            this.dataGridLista.Size = new System.Drawing.Size(851, 205);
            this.dataGridLista.TabIndex = 9;
            // 
            // btnnotas
            // 
            this.btnnotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.btnnotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnotas.Enabled = false;
            this.btnnotas.FlatAppearance.BorderSize = 0;
            this.btnnotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btnnotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnotas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnotas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnnotas.Location = new System.Drawing.Point(498, 234);
            this.btnnotas.Name = "btnnotas";
            this.btnnotas.Size = new System.Drawing.Size(105, 49);
            this.btnnotas.TabIndex = 43;
            this.btnnotas.Text = "Grabar Notas";
            this.btnnotas.UseVisualStyleBackColor = false;
            this.btnnotas.Click += new System.EventHandler(this.btnnotas_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridLista);
            this.panel3.Controls.Add(this.btnnotas);
            this.panel3.Location = new System.Drawing.Point(12, 325);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1002, 295);
            this.panel3.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UNCSM.Properties.Resources.calificaciones;
            this.pictureBox1.Location = new System.Drawing.Point(410, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // cbgrupo
            // 
            this.cbgrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.cbgrupo.CausesValidation = false;
            this.cbgrupo.ForeColor = System.Drawing.SystemColors.Info;
            this.cbgrupo.FormattingEnabled = true;
            this.cbgrupo.Location = new System.Drawing.Point(638, 25);
            this.cbgrupo.Name = "cbgrupo";
            this.cbgrupo.Size = new System.Drawing.Size(156, 21);
            this.cbgrupo.TabIndex = 58;
            // 
            // Frm_Calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbgrupos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Calificaciones";
            this.Text = "Frm_Calificaciones";
            this.cbgrupos.ResumeLayout(false);
            this.cbgrupos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLista)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel cbgrupos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdocente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnmostrarlista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridLista;
        private System.Windows.Forms.TextBox txtasignatura;
        private System.Windows.Forms.TextBox txtturno;
        private System.Windows.Forms.TextBox txtcarrera;
        private System.Windows.Forms.TextBox txtareaconocimiento;
        private System.Windows.Forms.TextBox txtcodasig;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnnotas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbgrupo;
    }
}