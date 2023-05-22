using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Formulars.DM;
using Formulars.PC;

namespace Formulars
{
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
        }

        private void ButtonPC_Click(object sender, EventArgs e)
        {
            var pcForm = new PlayerScreen(this);
            pcForm.Show();
            Hide();
        }

        private void ButtonDM_Click(object sender, EventArgs e)
        {
            var dmForm = new DungeonMasterScreen(this);
            dmForm.Show();
            Hide();
        }

        // Source: https://rjcodeadvance.com/iu-moderno-temas-multicolor-aleatorio-resaltar-boton-form-activo-winform-c/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Init_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void ButtonMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
