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
            btnVoley = new Button();
            btnBasquet = new Button();
            btnFutbol = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgMostrar).BeginInit();
            SuspendLayout();
            // 
            // dtgMostrar
            // 
            dtgMostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMostrar.Location = new Point(12, 12);
            dtgMostrar.Name = "dtgMostrar";
            dtgMostrar.RowTemplate.Height = 25;
            dtgMostrar.Size = new Size(856, 376);
            dtgMostrar.TabIndex = 0;
            // 
            // btnVoley
            // 
            btnVoley.BackColor = Color.SlateBlue;
            btnVoley.Cursor = Cursors.No;
            btnVoley.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnVoley.FlatStyle = FlatStyle.Flat;
            btnVoley.ForeColor = SystemColors.ActiveCaptionText;
            btnVoley.ImageAlign = ContentAlignment.BottomCenter;
            btnVoley.Location = new Point(23, 394);
            btnVoley.Name = "btnVoley";
            btnVoley.Size = new Size(140, 27);
            btnVoley.TabIndex = 4;
            btnVoley.Text = "Ver voley";
            btnVoley.TextAlign = ContentAlignment.BottomCenter;
            btnVoley.UseVisualStyleBackColor = false;
            btnVoley.Click += btnVoley_Click;
            // 
            // btnBasquet
            // 
            btnBasquet.BackColor = Color.SlateBlue;
            btnBasquet.Cursor = Cursors.No;
            btnBasquet.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnBasquet.FlatStyle = FlatStyle.Flat;
            btnBasquet.ForeColor = SystemColors.ActiveCaptionText;
            btnBasquet.ImageAlign = ContentAlignment.BottomCenter;
            btnBasquet.Location = new Point(169, 394);
            btnBasquet.Name = "btnBasquet";
            btnBasquet.Size = new Size(140, 27);
            btnBasquet.TabIndex = 5;
            btnBasquet.Text = "Ver Basquet";
            btnBasquet.TextAlign = ContentAlignment.BottomCenter;
            btnBasquet.UseVisualStyleBackColor = false;
            btnBasquet.Click += btnBasquet_Click;
            // 
            // btnFutbol
            // 
            btnFutbol.BackColor = Color.SlateBlue;
            btnFutbol.Cursor = Cursors.No;
            btnFutbol.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnFutbol.FlatStyle = FlatStyle.Flat;
            btnFutbol.ForeColor = SystemColors.ActiveCaptionText;
            btnFutbol.ImageAlign = ContentAlignment.BottomCenter;
            btnFutbol.Location = new Point(315, 394);
            btnFutbol.Name = "btnFutbol";
            btnFutbol.Size = new Size(140, 27);
            btnFutbol.TabIndex = 6;
            btnFutbol.Text = "Ver Futbol";
            btnFutbol.TextAlign = ContentAlignment.BottomCenter;
            btnFutbol.UseVisualStyleBackColor = false;
            btnFutbol.Click += btnFutbol_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.SlateBlue;
            btnModificar.Cursor = Cursors.No;
            btnModificar.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.ActiveCaptionText;
            btnModificar.ImageAlign = ContentAlignment.BottomCenter;
            btnModificar.Location = new Point(574, 394);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(104, 24);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.BottomCenter;
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // FrmMostrar1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(880, 433);
            Controls.Add(btnModificar);
            Controls.Add(btnFutbol);
            Controls.Add(btnBasquet);
            Controls.Add(btnVoley);
            Controls.Add(dtgMostrar);
            Name = "FrmMostrar1";
            Text = "FrmMostrar";
            Load += FrmMostrar1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgMostrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgMostrar;
        private Button btnVoley;
        private Button btnBasquet;
        private Button btnFutbol;
        private Button btnModificar;
    }
}