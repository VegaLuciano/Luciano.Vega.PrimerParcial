namespace Forms
{
    partial class FrmMostrar
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
            ((System.ComponentModel.ISupportInitialize)dtgMostrar).BeginInit();
            SuspendLayout();
            // 
            // dtgMostrar
            // 
            dtgMostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMostrar.Location = new Point(12, 21);
            dtgMostrar.Name = "dtgMostrar";
            dtgMostrar.RowTemplate.Height = 25;
            dtgMostrar.Size = new Size(653, 265);
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
            btnVoley.Location = new Point(66, 304);
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
            btnBasquet.Location = new Point(244, 304);
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
            btnFutbol.Location = new Point(428, 304);
            btnFutbol.Name = "btnFutbol";
            btnFutbol.Size = new Size(140, 27);
            btnFutbol.TabIndex = 6;
            btnFutbol.Text = "Ver Futbol";
            btnFutbol.TextAlign = ContentAlignment.BottomCenter;
            btnFutbol.UseVisualStyleBackColor = false;
            btnFutbol.Click += btnFutbol_Click;
            // 
            // FrmMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(677, 343);
            Controls.Add(btnFutbol);
            Controls.Add(btnBasquet);
            Controls.Add(btnVoley);
            Controls.Add(dtgMostrar);
            Name = "FrmMostrar";
            Text = "FrmMostrar";
            ((System.ComponentModel.ISupportInitialize)dtgMostrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgMostrar;
        private Button btnVoley;
        private Button btnBasquet;
        private Button btnFutbol;
    }
}