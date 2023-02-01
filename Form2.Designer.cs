
namespace Periodni_sistem {
    partial class Form2 {
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
            this.element_display_label = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.short_description_length_indicatior = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maseni_broj_full = new System.Windows.Forms.TextBox();
            this.maseni_broj = new System.Windows.Forms.TextBox();
            this.redni_broj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.short_description_richtextbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimise_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // element_display_label
            // 
            this.element_display_label.BackColor = System.Drawing.SystemColors.MenuBar;
            this.element_display_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.element_display_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.element_display_label.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.element_display_label.Location = new System.Drawing.Point(181, 60);
            this.element_display_label.Name = "element_display_label";
            this.element_display_label.Size = new System.Drawing.Size(64, 68);
            this.element_display_label.TabIndex = 24;
            this.element_display_label.Text = "Ww";
            this.element_display_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(456, 161);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(58, 23);
            this.save_button.TabIndex = 23;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // short_description_length_indicatior
            // 
            this.short_description_length_indicatior.BackColor = System.Drawing.Color.Transparent;
            this.short_description_length_indicatior.Location = new System.Drawing.Point(414, 42);
            this.short_description_length_indicatior.Name = "short_description_length_indicatior";
            this.short_description_length_indicatior.Size = new System.Drawing.Size(100, 15);
            this.short_description_length_indicatior.TabIndex = 22;
            this.short_description_length_indicatior.Text = "0 / 170";
            this.short_description_length_indicatior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(176, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "maseni broj (A)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(23, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "redni/atomski broj (Z):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(54, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "maseni broj (A):";
            // 
            // maseni_broj_full
            // 
            this.maseni_broj_full.BackColor = System.Drawing.Color.Snow;
            this.maseni_broj_full.Location = new System.Drawing.Point(181, 134);
            this.maseni_broj_full.MaxLength = 6;
            this.maseni_broj_full.Name = "maseni_broj_full";
            this.maseni_broj_full.Size = new System.Drawing.Size(64, 20);
            this.maseni_broj_full.TabIndex = 18;
            this.maseni_broj_full.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maseni_broj_full.WordWrap = false;
            this.maseni_broj_full.TextChanged += new System.EventHandler(this.maseni_broj_full_TextChanged);
            this.maseni_broj_full.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maseni_broj_full_KeyPress);
            // 
            // maseni_broj
            // 
            this.maseni_broj.BackColor = System.Drawing.Color.Snow;
            this.maseni_broj.Location = new System.Drawing.Point(139, 60);
            this.maseni_broj.MaxLength = 3;
            this.maseni_broj.Name = "maseni_broj";
            this.maseni_broj.ReadOnly = true;
            this.maseni_broj.Size = new System.Drawing.Size(36, 20);
            this.maseni_broj.TabIndex = 17;
            this.maseni_broj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maseni_broj.WordWrap = false;
            // 
            // redni_broj
            // 
            this.redni_broj.BackColor = System.Drawing.Color.Snow;
            this.redni_broj.Location = new System.Drawing.Point(139, 108);
            this.redni_broj.MaxLength = 3;
            this.redni_broj.Name = "redni_broj";
            this.redni_broj.Size = new System.Drawing.Size(36, 20);
            this.redni_broj.TabIndex = 16;
            this.redni_broj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.redni_broj.WordWrap = false;
            this.redni_broj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.redni_broj_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(267, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kratak opis:";
            // 
            // short_description_richtextbox
            // 
            this.short_description_richtextbox.Location = new System.Drawing.Point(270, 60);
            this.short_description_richtextbox.MaxLength = 170;
            this.short_description_richtextbox.Name = "short_description_richtextbox";
            this.short_description_richtextbox.Size = new System.Drawing.Size(244, 94);
            this.short_description_richtextbox.TabIndex = 14;
            this.short_description_richtextbox.Text = "";
            this.short_description_richtextbox.TextChanged += new System.EventHandler(this.short_description_richtextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(178, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Element: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.minimise_button);
            this.panel1.Controls.Add(this.close_button);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 30);
            this.panel1.TabIndex = 25;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.back_panel_MouseDown);
            // 
            // minimise_button
            // 
            this.minimise_button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimise_button.Location = new System.Drawing.Point(485, 3);
            this.minimise_button.Name = "minimise_button";
            this.minimise_button.Size = new System.Drawing.Size(24, 24);
            this.minimise_button.TabIndex = 151;
            this.minimise_button.Text = "-";
            this.minimise_button.UseVisualStyleBackColor = true;
            this.minimise_button.Click += new System.EventHandler(this.minimise_button_Click);
            // 
            // close_button
            // 
            this.close_button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.close_button.Location = new System.Drawing.Point(511, 3);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(24, 24);
            this.close_button.TabIndex = 150;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 193);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.element_display_label);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.short_description_length_indicatior);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maseni_broj_full);
            this.Controls.Add(this.maseni_broj);
            this.Controls.Add(this.redni_broj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.short_description_richtextbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Dodaj/izmeni element";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label element_display_label;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label short_description_length_indicatior;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maseni_broj_full;
        private System.Windows.Forms.TextBox maseni_broj;
        private System.Windows.Forms.TextBox redni_broj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox short_description_richtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimise_button;
        private System.Windows.Forms.Button close_button;
    }
}