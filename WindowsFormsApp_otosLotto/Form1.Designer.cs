namespace WindowsFormsApp_otosLotto
{
    partial class Form_otosLotto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_otosLotto));
            this.button_sorsolas = new System.Windows.Forms.Button();
            this.label_nyeroSzamok = new System.Windows.Forms.Label();
            this.label_megjatszott = new System.Windows.Forms.Label();
            this.label_talalat = new System.Windows.Forms.Label();
            this.panel_szamok = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_sorsolas
            // 
            this.button_sorsolas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_sorsolas.Image = global::WindowsFormsApp_otosLotto.Properties.Resources.shamrock_lucky_icon;
            this.button_sorsolas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sorsolas.Location = new System.Drawing.Point(199, 354);
            this.button_sorsolas.Name = "button_sorsolas";
            this.button_sorsolas.Size = new System.Drawing.Size(103, 38);
            this.button_sorsolas.TabIndex = 1;
            this.button_sorsolas.Text = "Sorsolás";
            this.button_sorsolas.UseVisualStyleBackColor = true;
            this.button_sorsolas.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_nyeroSzamok
            // 
            this.label_nyeroSzamok.AutoSize = true;
            this.label_nyeroSzamok.ForeColor = System.Drawing.Color.Green;
            this.label_nyeroSzamok.Location = new System.Drawing.Point(346, 344);
            this.label_nyeroSzamok.Name = "label_nyeroSzamok";
            this.label_nyeroSzamok.Size = new System.Drawing.Size(83, 13);
            this.label_nyeroSzamok.TabIndex = 2;
            this.label_nyeroSzamok.Text = "Nyerőszámok ->";
            // 
            // label_megjatszott
            // 
            this.label_megjatszott.AutoSize = true;
            this.label_megjatszott.Location = new System.Drawing.Point(346, 367);
            this.label_megjatszott.Name = "label_megjatszott";
            this.label_megjatszott.Size = new System.Drawing.Size(73, 13);
            this.label_megjatszott.TabIndex = 3;
            this.label_megjatszott.Text = "Megjátszott ->";
            // 
            // label_talalat
            // 
            this.label_talalat.AutoSize = true;
            this.label_talalat.ForeColor = System.Drawing.Color.Red;
            this.label_talalat.Location = new System.Drawing.Point(346, 390);
            this.label_talalat.Name = "label_talalat";
            this.label_talalat.Size = new System.Drawing.Size(51, 13);
            this.label_talalat.TabIndex = 4;
            this.label_talalat.Text = "Találat ->";
            // 
            // panel_szamok
            // 
            this.panel_szamok.AutoSize = true;
            this.panel_szamok.Location = new System.Drawing.Point(23, 27);
            this.panel_szamok.Name = "panel_szamok";
            this.panel_szamok.Size = new System.Drawing.Size(752, 296);
            this.panel_szamok.TabIndex = 5;
            // 
            // Form_otosLotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_szamok);
            this.Controls.Add(this.label_talalat);
            this.Controls.Add(this.label_megjatszott);
            this.Controls.Add(this.label_nyeroSzamok);
            this.Controls.Add(this.button_sorsolas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_otosLotto";
            this.Text = "Lottósorsolás";
            this.Load += new System.EventHandler(this.Form_otosLotto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_sorsolas;
        private System.Windows.Forms.Label label_nyeroSzamok;
        private System.Windows.Forms.Label label_megjatszott;
        private System.Windows.Forms.Label label_talalat;
        private System.Windows.Forms.Panel panel_szamok;
    }
}

