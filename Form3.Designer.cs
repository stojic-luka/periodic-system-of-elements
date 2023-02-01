
namespace Periodni_sistem {
    partial class Form3 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.element_picturebox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.redni_broj_label = new System.Windows.Forms.Label();
            this.maseni_broj_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.opis_label = new System.Windows.Forms.Label();
            this.add_image_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.minimise_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.element_picturebox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // element_picturebox
            // 
            this.element_picturebox.BackColor = System.Drawing.Color.White;
            this.element_picturebox.Location = new System.Drawing.Point(12, 42);
            this.element_picturebox.Name = "element_picturebox";
            this.element_picturebox.Size = new System.Drawing.Size(160, 160);
            this.element_picturebox.TabIndex = 0;
            this.element_picturebox.TabStop = false;
            this.element_picturebox.DragDrop += new System.Windows.Forms.DragEventHandler(this.element_picturebox_DragDrop);
            this.element_picturebox.DragEnter += new System.Windows.Forms.DragEventHandler(this.element_picturebox_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(190, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Redni broj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(413, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maseni broj:";
            // 
            // redni_broj_label
            // 
            this.redni_broj_label.AutoSize = true;
            this.redni_broj_label.BackColor = System.Drawing.Color.Transparent;
            this.redni_broj_label.Location = new System.Drawing.Point(251, 48);
            this.redni_broj_label.Name = "redni_broj_label";
            this.redni_broj_label.Size = new System.Drawing.Size(10, 13);
            this.redni_broj_label.TabIndex = 6;
            this.redni_broj_label.Text = ".";
            // 
            // maseni_broj_label
            // 
            this.maseni_broj_label.AutoSize = true;
            this.maseni_broj_label.BackColor = System.Drawing.Color.Transparent;
            this.maseni_broj_label.Location = new System.Drawing.Point(481, 48);
            this.maseni_broj_label.Name = "maseni_broj_label";
            this.maseni_broj_label.Size = new System.Drawing.Size(10, 13);
            this.maseni_broj_label.TabIndex = 7;
            this.maseni_broj_label.Text = ".";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.opis_label);
            this.panel1.Location = new System.Drawing.Point(186, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 161);
            this.panel1.TabIndex = 8;
            // 
            // opis_label
            // 
            this.opis_label.Location = new System.Drawing.Point(8, 8);
            this.opis_label.Name = "opis_label";
            this.opis_label.Size = new System.Drawing.Size(436, 145);
            this.opis_label.TabIndex = 0;
            this.opis_label.Text = ".";
            // 
            // add_image_button
            // 
            this.add_image_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.add_image_button.Location = new System.Drawing.Point(43, 208);
            this.add_image_button.Name = "add_image_button";
            this.add_image_button.Size = new System.Drawing.Size(95, 24);
            this.add_image_button.TabIndex = 146;
            this.add_image_button.Text = "Dodaj sliku";
            this.add_image_button.UseVisualStyleBackColor = false;
            this.add_image_button.Click += new System.EventHandler(this.add_image_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.minimise_button);
            this.panel2.Controls.Add(this.close_button);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 30);
            this.panel2.TabIndex = 147;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.back_panel_MouseDown);
            // 
            // minimise_button
            // 
            this.minimise_button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimise_button.Location = new System.Drawing.Point(597, 3);
            this.minimise_button.Name = "minimise_button";
            this.minimise_button.Size = new System.Drawing.Size(24, 24);
            this.minimise_button.TabIndex = 149;
            this.minimise_button.Text = "-";
            this.minimise_button.UseVisualStyleBackColor = true;
            this.minimise_button.Click += new System.EventHandler(this.minimise_button_Click);
            // 
            // close_button
            // 
            this.close_button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.close_button.Location = new System.Drawing.Point(623, 3);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(24, 24);
            this.close_button.TabIndex = 148;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 245);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.add_image_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.maseni_broj_label);
            this.Controls.Add(this.redni_broj_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.element_picturebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Prikazi element";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.element_picturebox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox element_picturebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label redni_broj_label;
        private System.Windows.Forms.Label maseni_broj_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_image_button;
        private System.Windows.Forms.Label opis_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button minimise_button;
        private System.Windows.Forms.Button close_button;
    }
}