using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace GlobalCounter {
    public sealed partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            main();
            
            Keys k;
            ghk = new KeyHandler(Keys.NumPad0, this);
            k = Keys.NumPad0;
            ghk.Register();
            textBox1.KeyDown += (s, e) => {
                if (!(e.KeyCode == k)) {
                    k = e.KeyCode;
                    textBox1.Text = k.ToString();
                    ghk.Unregiser();
                    ghk = new KeyHandler(k, this);
                    ghk.Register();
                    butIncr.Focus(); 
                }
            };
            
            updateIcon();
        }
        int count;

        private KeyHandler ghk;

        public void main() {
            if (!System.IO.File.Exists(@"count.txt")) { System.IO.File.Create(@"count.txt"); }
            string fileCount = System.IO.File.ReadAllText(@"count.txt");
            Int32.TryParse(fileCount, out count);
            
            IconHandler.GetIcon(count.ToString());
            countLabel.Text = count.ToString();
        }

        private void butIncr_Click(object sender, EventArgs e) {
            count++;
            countLabel.Text = count.ToString();
            saveNum();
        }   
            
        private void butDecr_Click(object sender, EventArgs e) {
            count--;
            
            countLabel.Text = count.ToString();
            saveNum();
        }   
        private void saveNum() {
            System.IO.File.WriteAllText(@"count.txt", count.ToString());
            updateIcon();
            
        }

        private void updateIcon() {
            notifyIconMain.Icon = IconHandler.GetIcon(count.ToString());
            notifyIconMain.Text = count.ToString();
            notifyIconMain.BalloonTipText = count.ToString();
        }

        private void HandleHotkey() {
            count++;
            countLabel.Text = count.ToString();
            saveNum();
        }

        protected override void WndProc(ref Message m) {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }

        private void butReset_Click(object sender, EventArgs e) {
            DialogResult confirm = MessageBox.Show("This will reset the counter, Are you sure?", "Reset counter?", MessageBoxButtons.YesNo);
            if(confirm == DialogResult.Yes) { count = 0; countLabel.Text = count.ToString(); saveNum(); }
        }
        
    }

    public sealed class IconHandler {
        public static Icon GetIcon(string text) {
            Bitmap bitmap = new Bitmap(32, 32);
            string iconPath = @"xicon.ico";
            Icon icon = new Icon(iconPath);
            System.Drawing.Font drawFont = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);

            System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(bitmap);

            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            graphics.DrawIcon(icon, 0, 0);
            graphics.DrawString(text, drawFont, drawBrush, 1, 2);
            Icon createdIcon = Icon.FromHandle(bitmap.GetHicon());

            drawFont.Dispose();
            drawBrush.Dispose();
            graphics.Dispose();
            bitmap.Dispose();

            return createdIcon;
        }
    }

    internal static class Constants {
        //windows message id for hotkey
        public const int WM_HOTKEY_MSG_ID = 0x0312;
    }

    public sealed class KeyHandler {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private int key;
        private IntPtr hWnd;
        private int id;

        public KeyHandler(Keys key, Form form) {
            this.key = (int)key;
            this.hWnd = form.Handle;
            id = this.GetHashCode();
        }

        public override int GetHashCode() {
            return key ^ hWnd.ToInt32();
        }

        public bool Register() {
            return RegisterHotKey(hWnd, id, 0, key);
        }

        public bool Unregiser() {
            return UnregisterHotKey(hWnd, id);
        }

    }
}
