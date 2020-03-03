namespace OrlenLaboratorium
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGazySuche = new System.Windows.Forms.Button();
            this.btnOdzyskWodoru = new System.Windows.Forms.Button();
            this.btnGazyWodorowe = new System.Windows.Forms.Button();
            this.btnGazyPlynne = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz co chcesz obliczyć:";
            // 
            // btnGazySuche
            // 
            this.btnGazySuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGazySuche.Location = new System.Drawing.Point(50, 164);
            this.btnGazySuche.Name = "btnGazySuche";
            this.btnGazySuche.Size = new System.Drawing.Size(168, 41);
            this.btnGazySuche.TabIndex = 1;
            this.btnGazySuche.Text = "Gazy suche";
            this.btnGazySuche.UseVisualStyleBackColor = true;
            this.btnGazySuche.Click += new System.EventHandler(this.btnGazySuche_Click);
            // 
            // btnOdzyskWodoru
            // 
            this.btnOdzyskWodoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdzyskWodoru.Location = new System.Drawing.Point(224, 164);
            this.btnOdzyskWodoru.Name = "btnOdzyskWodoru";
            this.btnOdzyskWodoru.Size = new System.Drawing.Size(168, 41);
            this.btnOdzyskWodoru.TabIndex = 2;
            this.btnOdzyskWodoru.Text = "odzysk wodoru";
            this.btnOdzyskWodoru.UseVisualStyleBackColor = true;
            this.btnOdzyskWodoru.Click += new System.EventHandler(this.btnOdzyskWodoru_Click);
            // 
            // btnGazyWodorowe
            // 
            this.btnGazyWodorowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGazyWodorowe.Location = new System.Drawing.Point(398, 164);
            this.btnGazyWodorowe.Name = "btnGazyWodorowe";
            this.btnGazyWodorowe.Size = new System.Drawing.Size(168, 41);
            this.btnGazyWodorowe.TabIndex = 3;
            this.btnGazyWodorowe.Text = "Gazy wodorowe";
            this.btnGazyWodorowe.UseVisualStyleBackColor = true;
            // 
            // btnGazyPlynne
            // 
            this.btnGazyPlynne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGazyPlynne.Location = new System.Drawing.Point(572, 164);
            this.btnGazyPlynne.Name = "btnGazyPlynne";
            this.btnGazyPlynne.Size = new System.Drawing.Size(168, 41);
            this.btnGazyPlynne.TabIndex = 4;
            this.btnGazyPlynne.Text = "Gazy plynne";
            this.btnGazyPlynne.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OrlenLaboratorium.Properties.Resources.orlen;
            this.pictureBox1.Location = new System.Drawing.Point(272, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 109);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(773, 231);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGazyPlynne);
            this.Controls.Add(this.btnGazyWodorowe);
            this.Controls.Add(this.btnOdzyskWodoru);
            this.Controls.Add(this.btnGazySuche);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Orlen Analythics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGazySuche;
        private System.Windows.Forms.Button btnOdzyskWodoru;
        private System.Windows.Forms.Button btnGazyWodorowe;
        private System.Windows.Forms.Button btnGazyPlynne;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

