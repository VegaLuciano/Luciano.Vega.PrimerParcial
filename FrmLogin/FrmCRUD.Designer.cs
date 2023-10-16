namespace Forms
{
    partial class FrmCRUD
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
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblNombreError = new Label();
            label1 = new Label();
            cmbDeporte = new ComboBox();
            lblDivision = new Label();
            cmbDivision = new ComboBox();
            label2 = new Label();
            txtNombreEntrenador = new TextBox();
            lblErrorNombreEntrenador = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            npdCantJugadores = new NumericUpDown();
            lblCantJugadores = new Label();
            lblCantTitulares = new Label();
            npdCantTitulares = new NumericUpDown();
            cpdCantSuplentes = new NumericUpDown();
            lblCanSuplentes = new Label();
            btnCargarPlanilla = new Button();
            ((System.ComponentModel.ISupportInitialize)npdCantJugadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdCantTitulares).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cpdCantSuplentes).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(56, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 27);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(56, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblNombreError
            // 
            lblNombreError.AutoSize = true;
            lblNombreError.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombreError.ForeColor = Color.Red;
            lblNombreError.Location = new Point(56, 91);
            lblNombreError.Name = "lblNombreError";
            lblNombreError.Size = new Size(62, 15);
            lblNombreError.TabIndex = 2;
            lblNombreError.Text = "lblNombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 131);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Deporte";
            // 
            // cmbDeporte
            // 
            cmbDeporte.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDeporte.FormattingEnabled = true;
            cmbDeporte.Location = new Point(56, 154);
            cmbDeporte.Name = "cmbDeporte";
            cmbDeporte.Size = new Size(121, 28);
            cmbDeporte.TabIndex = 4;
            // 
            // lblDivision
            // 
            lblDivision.AutoSize = true;
            lblDivision.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDivision.Location = new Point(295, 131);
            lblDivision.Name = "lblDivision";
            lblDivision.Size = new Size(62, 20);
            lblDivision.TabIndex = 5;
            lblDivision.Text = "Division";
            // 
            // cmbDivision
            // 
            cmbDivision.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDivision.FormattingEnabled = true;
            cmbDivision.Location = new Point(295, 154);
            cmbDivision.Name = "cmbDivision";
            cmbDivision.Size = new Size(121, 28);
            cmbDivision.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(295, 38);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 7;
            label2.Text = "Nombre del entrenador";
            // 
            // txtNombreEntrenador
            // 
            txtNombreEntrenador.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreEntrenador.Location = new Point(295, 61);
            txtNombreEntrenador.Name = "txtNombreEntrenador";
            txtNombreEntrenador.Size = new Size(170, 27);
            txtNombreEntrenador.TabIndex = 8;
            // 
            // lblErrorNombreEntrenador
            // 
            lblErrorNombreEntrenador.AutoSize = true;
            lblErrorNombreEntrenador.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorNombreEntrenador.ForeColor = Color.Red;
            lblErrorNombreEntrenador.Location = new Point(295, 91);
            lblErrorNombreEntrenador.Name = "lblErrorNombreEntrenador";
            lblErrorNombreEntrenador.Size = new Size(62, 15);
            lblErrorNombreEntrenador.TabIndex = 9;
            lblErrorNombreEntrenador.Text = "lblNombre";
            // 
            // npdCantJugadores
            // 
            npdCantJugadores.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            npdCantJugadores.Location = new Point(56, 225);
            npdCantJugadores.Name = "npdCantJugadores";
            npdCantJugadores.Size = new Size(68, 27);
            npdCantJugadores.TabIndex = 10;
            // 
            // lblCantJugadores
            // 
            lblCantJugadores.AutoSize = true;
            lblCantJugadores.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantJugadores.Location = new Point(56, 202);
            lblCantJugadores.Name = "lblCantJugadores";
            lblCantJugadores.Size = new Size(160, 20);
            lblCantJugadores.TabIndex = 11;
            lblCantJugadores.Text = "Cantidad de jugadores";
            // 
            // lblCantTitulares
            // 
            lblCantTitulares.AutoSize = true;
            lblCantTitulares.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantTitulares.Location = new Point(56, 264);
            lblCantTitulares.Name = "lblCantTitulares";
            lblCantTitulares.Size = new Size(147, 20);
            lblCantTitulares.TabIndex = 12;
            lblCantTitulares.Text = "Cantidad de titulares";
            // 
            // npdCantTitulares
            // 
            npdCantTitulares.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            npdCantTitulares.Location = new Point(56, 287);
            npdCantTitulares.Name = "npdCantTitulares";
            npdCantTitulares.Size = new Size(68, 27);
            npdCantTitulares.TabIndex = 13;
            // 
            // cpdCantSuplentes
            // 
            cpdCantSuplentes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cpdCantSuplentes.Location = new Point(56, 353);
            cpdCantSuplentes.Name = "cpdCantSuplentes";
            cpdCantSuplentes.Size = new Size(68, 27);
            cpdCantSuplentes.TabIndex = 15;
            // 
            // lblCanSuplentes
            // 
            lblCanSuplentes.AutoSize = true;
            lblCanSuplentes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCanSuplentes.Location = new Point(56, 330);
            lblCanSuplentes.Name = "lblCanSuplentes";
            lblCanSuplentes.Size = new Size(156, 20);
            lblCanSuplentes.TabIndex = 14;
            lblCanSuplentes.Text = "Cantidad de suplentes";
            // 
            // btnCargarPlanilla
            // 
            btnCargarPlanilla.Location = new Point(307, 211);
            btnCargarPlanilla.Name = "btnCargarPlanilla";
            btnCargarPlanilla.Size = new Size(109, 31);
            btnCargarPlanilla.TabIndex = 16;
            btnCargarPlanilla.Text = "Cargar planilla";
            btnCargarPlanilla.UseVisualStyleBackColor = true;
            btnCargarPlanilla.Click += btnCargarPlanilla_Click;
            // 
            // FrmCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 415);
            Controls.Add(btnCargarPlanilla);
            Controls.Add(cpdCantSuplentes);
            Controls.Add(lblCanSuplentes);
            Controls.Add(npdCantTitulares);
            Controls.Add(lblCantTitulares);
            Controls.Add(lblCantJugadores);
            Controls.Add(npdCantJugadores);
            Controls.Add(lblErrorNombreEntrenador);
            Controls.Add(txtNombreEntrenador);
            Controls.Add(label2);
            Controls.Add(cmbDivision);
            Controls.Add(lblDivision);
            Controls.Add(cmbDeporte);
            Controls.Add(label1);
            Controls.Add(lblNombreError);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Name = "FrmCRUD";
            Text = "FrmCRUD";
            Load += FrmCRUD_Load;
            ((System.ComponentModel.ISupportInitialize)npdCantJugadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdCantTitulares).EndInit();
            ((System.ComponentModel.ISupportInitialize)cpdCantSuplentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblNombreError;
        private Label label1;
        private ComboBox cmbDeporte;
        private Label lblDivision;
        private ComboBox cmbDivision;
        private Label label2;
        private TextBox txtNombreEntrenador;
        private Label lblErrorNombreEntrenador;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NumericUpDown npdCantJugadores;
        private Label lblCantJugadores;
        private Label lblCantTitulares;
        private NumericUpDown npdCantTitulares;
        private NumericUpDown cpdCantSuplentes;
        private Label lblCanSuplentes;
        private Button btnCargarPlanilla;
    }
}