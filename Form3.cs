using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace Periodni_sistem {
    public partial class Form3 : Form {
        public Form3(string _ime_elementa, bool _dark_mode) {
            InitializeComponent();
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
        private JsonNode json_data;
        private bool dark_mode;
        private void Form3_Load(object sender, EventArgs e) {
            change_dark_mode();
            this.Text = ime_elementa;
            this.AllowDrop = true;
            using (var streamReader = new StreamReader(Directory.GetCurrentDirectory() + @"\elements_info", Encoding.UTF8))
                json_data = JsonSerializer.Deserialize<JsonNode>(streamReader.ReadToEnd());
            redni_broj_label.Text = json_data[ime_elementa]["redni_broj"].ToString();
            maseni_broj_label.Text = json_data[ime_elementa]["maseni_broj"].ToString();
            opis_label.Text = json_data[ime_elementa]["opis"].ToString();
            string path_file = Directory.GetCurrentDirectory() + @"\images\" + ime_elementa;
            if (File.Exists(path_file))
                try {
                    using (var bmp_file = new Bitmap(path_file))
                        element_picturebox.BackgroundImage = new Bitmap(bmp_file);
                } catch { }
        }

        private void add_image_button_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            Bitmap box = element_picturebox.BackgroundImage as Bitmap;
            string dir = Directory.GetCurrentDirectory() + @"\images\" + ime_elementa;
            dialog.InitialDirectory = Directory.GetCurrentDirectory() + @"\images\";
            dialog.Filter = "Images (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK) {
                element_picturebox.BackgroundImage = image_format(new Bitmap(dialog.FileName));
                if (element_picturebox.BackgroundImage != null)
                    using (var stream = new FileStream(dir, FileMode.Create))
                        element_picturebox.BackgroundImage.Save(stream, ImageFormat.Jpeg);
                else
                    element_picturebox.BackgroundImage = box;
            }
        }

        private Bitmap image_format(Bitmap input) {
            if (input.Width < 160 || input.Height < 160) {
                MessageBox.Show("Slika previse mala (min. 160x160)");
                return null;
            }
            double dbl = (double)input.Width / (double)input.Height;
            Bitmap resized_image;
            if ((int)((double)160 * dbl) >= 160)
                resized_image = new Bitmap(input, (int)((double)160 * dbl), 160);
            else
                resized_image = new Bitmap(input, 160, (int)((double)160 / dbl));
            return resized_image.Clone(new Rectangle(new Point((resized_image.Width / 2) - 80), new Size(160, 160)), resized_image.PixelFormat);
        }

        private void element_picturebox_DragEnter(object sender, DragEventArgs e) {
            Console.WriteLine("correct");
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null) {
                var filenames = data as string[];
                if (filenames.Length > 0)
                    using (var bmp_file = new Bitmap(filenames[0]))
                        element_picturebox.BackgroundImage = new Bitmap(bmp_file);
            }
        }

        private void element_picturebox_DragDrop(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;
        }

        private void change_dark_mode() {
            if (dark_mode) {
                this.BackColor = Color.FromArgb(255 - this.BackColor.R, 255 - this.BackColor.G, 255 - this.BackColor.B);
                panel2.BackColor = Color.FromArgb(255 - panel2.BackColor.R, 255 - panel2.BackColor.G, 255 - panel2.BackColor.B);
                label1.ForeColor = Color.FromArgb(255 - label1.ForeColor.R, 255 - label1.ForeColor.G, 255 - label1.ForeColor.B);
                redni_broj_label.ForeColor = Color.FromArgb(255 - redni_broj_label.ForeColor.R, 255 - redni_broj_label.ForeColor.G, 255 - redni_broj_label.ForeColor.B);
                label2.ForeColor = Color.FromArgb(255 - label2.ForeColor.R, 255 - label2.ForeColor.G, 255 - label2.ForeColor.B);
                maseni_broj_label.ForeColor = Color.FromArgb(255 - maseni_broj_label.ForeColor.R, 255 - maseni_broj_label.ForeColor.G, 255 - maseni_broj_label.ForeColor.B);
                opis_label.ForeColor = Color.FromArgb(255 - opis_label.ForeColor.R, 255 - opis_label.ForeColor.G, 255 - opis_label.ForeColor.B);
                panel1.BackColor = Color.FromArgb(255 - panel1.BackColor.R, 255 - panel1.BackColor.G, 255 - panel1.BackColor.B);
                add_image_button.BackColor = Color.LightGray;
                element_picturebox.BackColor = Color.FromArgb(255 - element_picturebox.BackColor.R, 255 - element_picturebox.BackColor.G, 255 - element_picturebox.BackColor.B);
            }
        }
    }
}
