using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace Periodni_sistem {
    public partial class Form2 : Form {
        public Form2(string _ime_elementa, bool _dark_mode) {
            InitializeComponent();
            element_display_label.Text = _ime_elementa;
            ime_elementa = _ime_elementa;
            dark_mode = _dark_mode;
        }

        #region . DON'T CHANGE .

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void back_panel_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void close_button_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void minimise_button_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        private string ime_elementa;
        private bool edit = false, dark_mode;

        private JsonNode json_data;
        private string info_dir = Directory.GetCurrentDirectory() + @"\elements_info";
        private void Form2_Load(object sender, EventArgs e) {
            change_dark_mode();
            using (var streamReader = new StreamReader(info_dir, Encoding.UTF8))
                json_data = JsonSerializer.Deserialize<JsonNode>(streamReader.ReadToEnd());
            if (json_data[ime_elementa] != null) {
                redni_broj.Text = json_data[ime_elementa]["redni_broj"].ToString();
                maseni_broj_full.Text = json_data[ime_elementa]["maseni_broj"].ToString();
                short_description_richtextbox.Text = json_data[ime_elementa]["opis"].ToString();
                edit = true;
            }
        }

        private void maseni_broj_full_TextChanged(object sender, EventArgs e) {
            if (!maseni_broj_full.Text.Trim().StartsWith(",") && !maseni_broj_full.Text.Trim().StartsWith(".") && maseni_broj_full.Text.Length > 0)
                maseni_broj.Text = Math.Round(double.Parse(maseni_broj_full.Text.Replace(",", "."))).ToString();
            else
                maseni_broj.Text = Math.Round(double.Parse("0" + maseni_broj_full.Text.Replace(",", "."))).ToString();
        }

        private void maseni_broj_full_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
            if ((maseni_broj_full.Text.IndexOf(',') > -1 || maseni_broj_full.Text.IndexOf('.') > -1) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void redni_broj_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void short_description_richtextbox_TextChanged(object sender, EventArgs e) {
            short_description_length_indicatior.Text = short_description_richtextbox.Text.Length.ToString() + " / 170";
        }

        private void save_button_Click(object sender, EventArgs e) {
            string _opis = short_description_richtextbox.Text;
            double _maseni_broj = Convert.ToDouble(maseni_broj_full.Text.Replace(",", "."));
            int _redni_broj = (int)Math.Round(Convert.ToDouble(redni_broj.Text));

            JsonObject obj = json_data.AsObject();
            if (edit)
                obj.Remove(ime_elementa);
            string new_json_string = "{ 'redni_broj' : '" + _redni_broj + "', 'maseni_broj' : '" + _maseni_broj + "', 'opis' : '" + _opis + "' }";
            JsonNode node = JsonSerializer.Deserialize<JsonNode>(new_json_string.Replace("'", '"'.ToString()));
            obj.Add(ime_elementa, node);

            var opts = new JsonSerializerOptions { WriteIndented = true };
            using (var streamWriter = new StreamWriter(info_dir, append: false))
                streamWriter.Write(JsonSerializer.Serialize(obj, opts));

            edit = false;
            this.Hide();
        }

        private void change_dark_mode() {
            if (dark_mode) {
                this.BackColor = Color.FromArgb(255 - this.BackColor.R, 255 - this.BackColor.G, 255 - this.BackColor.B);
                panel1.BackColor = Color.FromArgb(255 - panel1.BackColor.R, 255 - panel1.BackColor.G, 255 - panel1.BackColor.B);
                short_description_richtextbox.BackColor = Color.FromArgb(255 - short_description_richtextbox.BackColor.R, 255 - short_description_richtextbox.BackColor.G, 255 - short_description_richtextbox.BackColor.B);
                short_description_richtextbox.ForeColor = Color.FromArgb(255 - short_description_richtextbox.ForeColor.R, 255 - short_description_richtextbox.ForeColor.G, 255 - short_description_richtextbox.ForeColor.B);
                short_description_length_indicatior.ForeColor = Color.FromArgb(255 - short_description_length_indicatior.ForeColor.R, 255 - short_description_length_indicatior.ForeColor.G, 255 - short_description_length_indicatior.ForeColor.B);
                save_button.BackColor = Color.LightGray;
                label5.ForeColor = Color.FromArgb(255 - label5.ForeColor.R, 255 - label5.ForeColor.G, 255 - label5.ForeColor.B);
                label4.ForeColor = Color.FromArgb(255 - label4.ForeColor.R, 255 - label4.ForeColor.G, 255 - label4.ForeColor.B);
                label3.ForeColor = Color.FromArgb(255 - label3.ForeColor.R, 255 - label3.ForeColor.G, 255 - label3.ForeColor.B);
                label2.ForeColor = Color.FromArgb(255 - label2.ForeColor.R, 255 - label2.ForeColor.G, 255 - label2.ForeColor.B);
                label1.ForeColor = Color.FromArgb(255 - label1.ForeColor.R, 255 - label1.ForeColor.G, 255 - label1.ForeColor.B);
                element_display_label.BackColor = Color.FromArgb(255 - element_display_label.BackColor.R, 255 - element_display_label.BackColor.G, 255 - element_display_label.BackColor.B);
                element_display_label.ForeColor = Color.FromArgb(255 - element_display_label.ForeColor.R, 255 - element_display_label.ForeColor.G, 255 - element_display_label.ForeColor.B);
                maseni_broj.ForeColor = Color.FromArgb(255 - maseni_broj.ForeColor.R, 255 - maseni_broj.ForeColor.G, 255 - maseni_broj.ForeColor.B);
                maseni_broj.BackColor = Color.FromArgb(255 - maseni_broj.BackColor.R, 255 - maseni_broj.BackColor.G, 255 - maseni_broj.BackColor.B);
                redni_broj.ForeColor = Color.FromArgb(255 - redni_broj.ForeColor.R, 255 - redni_broj.ForeColor.G, 255 - redni_broj.ForeColor.B);
                redni_broj.BackColor = Color.FromArgb(255 - redni_broj.BackColor.R, 255 - redni_broj.BackColor.G, 255 - redni_broj.BackColor.B);
                maseni_broj_full.ForeColor = Color.FromArgb(255 - maseni_broj_full.ForeColor.R, 255 - maseni_broj_full.ForeColor.G, 255 - maseni_broj_full.ForeColor.B);
                maseni_broj_full.BackColor = Color.FromArgb(255 - maseni_broj_full.BackColor.R, 255 - maseni_broj_full.BackColor.G, 255 - maseni_broj_full.BackColor.B);
            }
        }
    }
}