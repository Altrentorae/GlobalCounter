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

namespace GlobalCounter {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            main();
            ghk = new KeyHandler(Keys.NumPad0, this);
            ghk.Register();
        }
        int count;

        private KeyHandler ghk;

        public void main() {
            string fileCount = System.IO.File.ReadAllText(@"count.txt");
            Int32.TryParse(fileCount, out count);
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

    public static class Constants {
        //windows message id for hotkey
        public const int WM_HOTKEY_MSG_ID = 0x0312;
    }

    public class KeyHandler {
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
