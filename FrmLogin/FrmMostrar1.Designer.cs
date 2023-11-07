namespace Forms
{
    partial class FrmMostrar1
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
            dtgMostrar = new DataGridView();
            btnJugadores = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgMostrar).BeginInit();
            SuspendLayout();
            // 
            // dtgMostrar
            // 
            dtgMostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMostrar.Location = new Point(12, 12);
            dtgMostrar.MultiSelect = false;
            dtgMostrar.Name = "dtgMostrar";
            dtgMostrar.ReadOnly = true;
            dtgMostrar.RowTemplate.Height = 25;
            dtgMostrar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgMostrar.Size = new Size(856, 378);
            dtgMostrar.TabIndex = 0;
            dtgMostrar.SelectionChanged += dtgMostrar_SelectionChanged;
            // 
            // btnJugadores
            // 
            btnJugadores.BackColor = Color.SlateBlue;
            btnJugadores.Cursor = Cursors.No;
            btnJugadores.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnJugadores.FlatStyle = FlatStyle.Flat;
            btnJugadores.ForeColor = SystemColors.ActiveCaptionText;
            btnJugadores.ImageAlign = ContentAlignment.BottomCenter;
            btnJugadores.Location = new Point(46, 421);
            btnJugadores.Name = "btnJugadores";
            btnJugadores.Size = new Size(140, 27);
            btnJugadores.TabIndex = 7;
            btnJugadores.Text = "Ver Jugadores";
            btnJugadores.TextAlign = ContentAlignment.BottomCenter;
            btnJugadores.UseVisualStyleBackColor = false;
            btnJugadores.Click += btnJugadores_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SlateBlue;
            btnEliminar.Cursor = Cursors.No;
            btnEliminar.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.ImageAlign = ContentAlignment.BottomCenter;
            btnEliminar.Location = new Point(243, 421);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 27);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmMostrar1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(880, 460);
            Controls.Add(btnEliminar);
            Controls.Add(btnJugadores);
            Controls.Add(dtgMostrar);
            Name = "FrmMostrar1";
            Text = "FrmMostrar";
            Load += FrmMostrar1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgMostrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgMostrar;
        private Button btnJugadores;
        private Button btnEliminar;
    }
}