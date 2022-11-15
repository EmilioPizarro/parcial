namespace ParcialPav
{
    partial class AltaEquipo
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNroNuevoEquipo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreDeEquipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarJugador = new System.Windows.Forms.GroupBox();
            this.txtNroJugador = new System.Windows.Forms.MaskedTextBox();
            this.dgrEquipo = new System.Windows.Forms.DataGridView();
            this.NroJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroPosicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscarJugador = new System.Windows.Forms.Button();
            this.cmbPosicion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmarEquipo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.btnAgregarJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de nuevo equipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNroNuevoEquipo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbCategorias);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombreDeEquipo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(780, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales";
            // 
            // txtNroNuevoEquipo
            // 
            this.txtNroNuevoEquipo.Location = new System.Drawing.Point(167, 34);
            this.txtNroNuevoEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroNuevoEquipo.Name = "txtNroNuevoEquipo";
            this.txtNroNuevoEquipo.ReadOnly = true;
            this.txtNroNuevoEquipo.Size = new System.Drawing.Size(96, 23);
            this.txtNroNuevoEquipo.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nro nuevo equipo:";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(611, 79);
            this.cmbCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(160, 25);
            this.cmbCategorias.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categoría:";
            // 
            // txtNombreDeEquipo
            // 
            this.txtNombreDeEquipo.Location = new System.Drawing.Point(379, 79);
            this.txtNombreDeEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreDeEquipo.Name = "txtNombreDeEquipo";
            this.txtNombreDeEquipo.Size = new System.Drawing.Size(132, 23);
            this.txtNombreDeEquipo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de equipo:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(77, 79);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(132, 23);
            this.txtFecha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Controls.Add(this.txtNroJugador);
            this.btnAgregarJugador.Controls.Add(this.dgrEquipo);
            this.btnAgregarJugador.Controls.Add(this.label8);
            this.btnAgregarJugador.Controls.Add(this.btnAgregar);
            this.btnAgregarJugador.Controls.Add(this.btnBuscarJugador);
            this.btnAgregarJugador.Controls.Add(this.cmbPosicion);
            this.btnAgregarJugador.Controls.Add(this.label7);
            this.btnAgregarJugador.Controls.Add(this.txtNombreJugador);
            this.btnAgregarJugador.Controls.Add(this.label6);
            this.btnAgregarJugador.Controls.Add(this.label5);
            this.btnAgregarJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarJugador.Location = new System.Drawing.Point(36, 242);
            this.btnAgregarJugador.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Padding = new System.Windows.Forms.Padding(4);
            this.btnAgregarJugador.Size = new System.Drawing.Size(780, 418);
            this.btnAgregarJugador.TabIndex = 6;
            this.btnAgregarJugador.TabStop = false;
            this.btnAgregarJugador.Text = "Jugadores del equipo";
            this.btnAgregarJugador.Enter += new System.EventHandler(this.btnAgregarJugador_Enter);
            // 
            // txtNroJugador
            // 
            this.txtNroJugador.Location = new System.Drawing.Point(108, 45);
            this.txtNroJugador.Mask = "999";
            this.txtNroJugador.Name = "txtNroJugador";
            this.txtNroJugador.Size = new System.Drawing.Size(100, 23);
            this.txtNroJugador.TabIndex = 14;
            this.txtNroJugador.ValidatingType = typeof(int);
            // 
            // dgrEquipo
            // 
            this.dgrEquipo.AllowUserToAddRows = false;
            this.dgrEquipo.AllowUserToDeleteRows = false;
            this.dgrEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroJugador,
            this.NombreJugador,
            this.NroPosicion});
            this.dgrEquipo.Location = new System.Drawing.Point(12, 174);
            this.dgrEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.dgrEquipo.Name = "dgrEquipo";
            this.dgrEquipo.ReadOnly = true;
            this.dgrEquipo.RowHeadersWidth = 51;
            this.dgrEquipo.Size = new System.Drawing.Size(760, 238);
            this.dgrEquipo.TabIndex = 13;
            // 
            // NroJugador
            // 
            this.NroJugador.HeaderText = "Nro del jugador";
            this.NroJugador.MinimumWidth = 6;
            this.NroJugador.Name = "NroJugador";
            this.NroJugador.ReadOnly = true;
            this.NroJugador.Width = 150;
            // 
            // NombreJugador
            // 
            this.NombreJugador.HeaderText = "Nombre del jugador";
            this.NombreJugador.MinimumWidth = 6;
            this.NombreJugador.Name = "NombreJugador";
            this.NombreJugador.ReadOnly = true;
            this.NombreJugador.Width = 220;
            // 
            // NroPosicion
            // 
            this.NroPosicion.HeaderText = "Nro de posición";
            this.NroPosicion.MinimumWidth = 6;
            this.NroPosicion.Name = "NroPosicion";
            this.NroPosicion.ReadOnly = true;
            this.NroPosicion.Width = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 154);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Equipo formado:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(617, 84);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(155, 28);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar jugador";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscarJugador
            // 
            this.btnBuscarJugador.Location = new System.Drawing.Point(223, 42);
            this.btnBuscarJugador.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarJugador.Name = "btnBuscarJugador";
            this.btnBuscarJugador.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarJugador.TabIndex = 10;
            this.btnBuscarJugador.Text = "Buscar";
            this.btnBuscarJugador.UseVisualStyleBackColor = true;
            this.btnBuscarJugador.Click += new System.EventHandler(this.btnBuscarJugador_Click);
            // 
            // cmbPosicion
            // 
            this.cmbPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosicion.FormattingEnabled = true;
            this.cmbPosicion.Location = new System.Drawing.Point(448, 85);
            this.cmbPosicion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPosicion.Name = "cmbPosicion";
            this.cmbPosicion.Size = new System.Drawing.Size(160, 25);
            this.cmbPosicion.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Posicion:";
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.Location = new System.Drawing.Point(223, 85);
            this.txtNombreJugador.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.ReadOnly = true;
            this.txtNombreJugador.Size = new System.Drawing.Size(132, 23);
            this.txtNombreJugador.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre del jugador:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Jugador n°:";
            // 
            // btnConfirmarEquipo
            // 
            this.btnConfirmarEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarEquipo.Location = new System.Drawing.Point(661, 679);
            this.btnConfirmarEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmarEquipo.Name = "btnConfirmarEquipo";
            this.btnConfirmarEquipo.Size = new System.Drawing.Size(155, 28);
            this.btnConfirmarEquipo.TabIndex = 14;
            this.btnConfirmarEquipo.Text = "Confirmar equipo";
            this.btnConfirmarEquipo.UseVisualStyleBackColor = true;
            this.btnConfirmarEquipo.Click += new System.EventHandler(this.btnConfirmarEquipo_Click);
            // 
            // AltaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 724);
            this.Controls.Add(this.btnConfirmarEquipo);
            this.Controls.Add(this.btnAgregarJugador);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AltaEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaEquipo";
            this.Load += new System.EventHandler(this.AltaEquipo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.btnAgregarJugador.ResumeLayout(false);
            this.btnAgregarJugador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreDeEquipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox btnAgregarJugador;
        private System.Windows.Forms.DataGridView dgrEquipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscarJugador;
        private System.Windows.Forms.ComboBox cmbPosicion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreJugador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroPosicion;
        private System.Windows.Forms.Button btnConfirmarEquipo;
        private System.Windows.Forms.TextBox txtNroNuevoEquipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtNroJugador;
    }
}