namespace Forms
{
    partial class FrmMenuPrincipal
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
            btnAgregar = new Button();
            lblUsuario = new Label();
            pnlFormulario = new Panel();
            btnBasquet = new Button();
            btnFutbol = new Button();
            btnVoley = new Button();
            btnMostrar = new Button();
            pnlFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkSlateBlue;
            btnAgregar.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Location = new Point(12, 82);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 32);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar equipo";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.DarkSlateBlue;
            lblUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(55, 39);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            lblUsuario.Click += lblUsuario_Click_1;
            // 
            // pnlFormulario
            // 
            pnlFormulario.BackColor = Color.SteelBlue;
            pnlFormulario.Controls.Add(btnBasquet);
            pnlFormulario.Controls.Add(btnFutbol);
            pnlFormulario.Controls.Add(btnVoley);
            pnlFormulario.Location = new Point(158, 12);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(896, 472);
            pnlFormulario.TabIndex = 2;
            pnlFormulario.Paint += panel1_Paint;
            // 
            // btnBasquet
            // 
            btnBasquet.BackColor = Color.SlateBlue;
            btnBasquet.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnBasquet.FlatStyle = FlatStyle.Flat;
            btnBasquet.ForeColor = SystemColors.ActiveCaptionText;
            btnBasquet.Location = new Point(22, 54);
            btnBasquet.Name = "btnBasquet";
            btnBasquet.Size = new Size(140, 32);
            btnBasquet.TabIndex = 5;
            btnBasquet.Text = "Basquet";
            btnBasquet.UseVisualStyleBackColor = false;
            btnBasquet.Click += btnBasquet_Click;
            // 
            // btnFutbol
            // 
            btnFutbol.BackColor = Color.SlateBlue;
            btnFutbol.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnFutbol.FlatStyle = FlatStyle.Flat;
            btnFutbol.ForeColor = SystemColors.ActiveCaptionText;
            btnFutbol.Location = new Point(22, 4);
            btnFutbol.Name = "btnFutbol";
            btnFutbol.Size = new Size(140, 32);
            btnFutbol.TabIndex = 4;
            btnFutbol.Text = "Futbol";
            btnFutbol.UseVisualStyleBackColor = false;
            btnFutbol.Click += btnFutbol_Click;
            // 
            // btnVoley
            // 
            btnVoley.BackColor = Color.SlateBlue;
            btnVoley.Cursor = Cursors.No;
            btnVoley.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnVoley.FlatStyle = FlatStyle.Flat;
            btnVoley.ForeColor = SystemColors.ActiveCaptionText;
            btnVoley.ImageAlign = ContentAlignment.BottomCenter;
            btnVoley.Location = new Point(22, 108);
            btnVoley.Name = "btnVoley";
            btnVoley.Size = new Size(140, 32);
            btnVoley.TabIndex = 3;
            btnVoley.Text = "Voley";
            btnVoley.TextAlign = ContentAlignment.BottomCenter;
            btnVoley.UseVisualStyleBackColor = false;
            btnVoley.Click += btnVoley_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.DarkSlateBlue;
            btnMostrar.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.ForeColor = SystemColors.ActiveCaptionText;
            btnMostrar.Location = new Point(12, 123);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(140, 32);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1080, 513);
            Controls.Add(btnMostrar);
            Controls.Add(pnlFormulario);
            Controls.Add(lblUsuario);
            Controls.Add(btnAgregar);
            Name = "FrmMenuPrincipal";
            Text = "FrmMenuPrincipal";
            FormClosing += FrmMenuPrincipal_FormClosing;
            Load += FrmMenuPrincipal_Load;
            pnlFormulario.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label lblUsuario;
        private Panel pnlFormulario;
        private Button btnFutbol;
        private Button btnVoley;
        private Button btnBasquet;
        private Button btnMostrar;
    }
}