using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace Periodni_sistem {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region . DON'T CHANGE .

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void top_panel_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void close_button_Click(object sender, EventArgs e) {
            this.Close();
            Environment.Exit(0);
        }

        private void minimise_button_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        private JsonNode json_data;
        private string info_dir = Directory.GetCurrentDirectory() + @"\elements_info";
        private bool add_element_true = false, remove_element_true = false, dark_mode = false;
        private void Form1_Load(object sender, EventArgs e) {
            if (!File.Exists(info_dir)) {
                var empty_txt = Encoding.UTF8.GetBytes("{}");
                using (FileStream writer = File.Create(info_dir)) {
                    writer.Write(empty_txt, 0, empty_txt.Length);
                    writer.Close();
                }
            }
            load_json();
        }

        private void load_json() {
            using (var streamReader = new StreamReader(info_dir, Encoding.UTF8))
                json_data = JsonSerializer.Deserialize<JsonNode>(streamReader.ReadToEnd());
        }

        #region . ELEMENTS BUTTONS .

        private void element_button_click(object sender, EventArgs e) {
            Button btn = sender as Button;
            if (add_element_true == true) {
                Form2 f2 = new Form2(btn.Name, dark_mode);
                f2.ShowDialog();
            }
            if (remove_element_true == true) {
                if (MessageBox.Show("Da li želite da uklonite informacije o elementu: " + btn.Name, "?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1).ToString() == "Yes") {
                    JsonObject obj = json_data.AsObject();
                    string photo_path = Directory.GetCurrentDirectory() + @"\images\" + btn.Name;
                    obj.Remove(btn.Name);
                    element_info.RemoveAll();
                    using (var streamWriter = new StreamWriter(info_dir, append: false))
                        streamWriter.Write(JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true }));
                    if (File.Exists(photo_path))
                        File.Delete(photo_path);
                }
            }
            if (!(remove_element_true == true || add_element_true == true)) {
                if (json_data[btn.Name] != null) {
                    Form3 f3 = new Form3(btn.Name, dark_mode);
                    f3.ShowDialog();
                } else {
                    MessageBox.Show("Nema unetih informacija o elementu");
                }
            }
            add_element_true = false;
            remove_element_true = false;
            load_json();
        }

        private ToolTip element_info = new ToolTip();
        private void element_button_hover(object sender, EventArgs e) {
            Button btn = sender as Button;
            element_info.ToolTipTitle = btn.Name;
            string toolbar_show_text;
            if (json_data[btn.Name] != null) {
                element_info.ToolTipIcon = ToolTipIcon.Info;
                toolbar_show_text = "Redni broj: " + json_data[btn.Name]["redni_broj"].ToString() + "\t"
                + "Maseni broj: " + json_data[btn.Name]["maseni_broj"].ToString() + "\n"
                + json_data[btn.Name]["opis"].ToString();
            } else {
                element_info.ToolTipIcon = ToolTipIcon.Error;
                toolbar_show_text = "Nema dodatih informacija o elementu!";
            }
            element_info.Show(toolbar_show_text, btn, Convert.ToInt32(btn.Size.Width * 1.1), 0);
        }

        private void element_button_leave(object sender, EventArgs e) {
            element_info.RemoveAll();
        }
        
        private void remove_element_button_Click(object sender, EventArgs e) {
            MessageBox.Show("Klikni na element kome hoćeš da ukloniš informacije");
            remove_element_true = true;
            add_element_true = false;
        }

        private void prikazi_info_button_Click(object sender, EventArgs e) {
            add_element_true = false;
            remove_element_true = false;
        }

        private void remove_all_elements_button_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Da li želite da UKLONITE SVE elemente?", "?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1).ToString() == "Yes") {
                JsonObject obj = json_data.AsObject();
                obj.Clear();
                element_info.RemoveAll();
                string dir = Directory.GetCurrentDirectory() + @"\images";
                foreach (string filename in Directory.GetFiles(dir))
                    File.Delete(filename);
                using (var streamWriter = new StreamWriter(info_dir, append: false))
                    streamWriter.Write(JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true }));
            }
            load_json();
        }

        private void add_element_button_Click(object sender, EventArgs e) {
            MessageBox.Show("Klikni na element kome hoćeš da promeniš/dodas informacije");
            add_element_true = true;
            remove_element_true = false;
        }

        private void dark_mode_button_CheckedChanged(object sender, EventArgs e) {
            CheckBox chk = sender as CheckBox;
            if (chk.Checked) {
                dark_mode = true;
                dark_mode_button.Text = "Dark";
                this.BackColor = Color.FromArgb(255 - this.BackColor.R, 255 - this.BackColor.G, 255 - this.BackColor.B);
                top_panel.BackColor = Color.FromArgb(255 - top_panel.BackColor.R, 255 - top_panel.BackColor.G, 255 - top_panel.BackColor.B);
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                label10.ForeColor = Color.White;
                label11.ForeColor = Color.White;
                label12.ForeColor = Color.White;
                label13.ForeColor = Color.White;
                label14.ForeColor = Color.White;
                label15.ForeColor = Color.White;
                label16.ForeColor = Color.White;
                label17.ForeColor = Color.White;
                label18.ForeColor = Color.White;
                label19.ForeColor = Color.White;
                label20.ForeColor = Color.White;
                label21.ForeColor = Color.White;
                label22.ForeColor = Color.White;
                label23.ForeColor = Color.White;
                label24.ForeColor = Color.White;
                label25.ForeColor = Color.White;
                panel1.BackColor = Color.FromArgb(255 - panel1.BackColor.R, 255 - panel1.BackColor.G, 255 - panel1.BackColor.B);
                panel2.BackColor = Color.FromArgb(255 - panel2.BackColor.R, 255 - panel2.BackColor.G, 255 - panel2.BackColor.B);
                panel7.BackColor = Color.FromArgb(255 - panel7.BackColor.R, 255 - panel7.BackColor.G, 255 - panel7.BackColor.B);
                label26.ForeColor = Color.White;
                label27.ForeColor = Color.White;
                label28.ForeColor = Color.White;
                label29.ForeColor = Color.White;
            } else {
                dark_mode = false;
                dark_mode_button.Text = "Light";
                this.BackColor = Color.White;
                top_panel.BackColor = Color.LightGray;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
                label15.ForeColor = Color.Black;
                label16.ForeColor = Color.Black;
                label17.ForeColor = Color.Black;
                label18.ForeColor = Color.Black;
                label19.ForeColor = Color.Black;
                label20.ForeColor = Color.Black;
                label21.ForeColor = Color.Black;
                label22.ForeColor = Color.Black;
                label23.ForeColor = Color.Black;
                label24.ForeColor = Color.Black;
                label25.ForeColor = Color.Black;
                panel1.BackColor = Color.WhiteSmoke;
                panel2.BackColor = Color.WhiteSmoke;
                panel7.BackColor = Color.WhiteSmoke;
                label26.ForeColor = Color.Black;
                label27.ForeColor = Color.Black;
                label28.ForeColor = Color.Black;
                label29.ForeColor = Color.Black;
            }
        }

        #endregion
    }
}
