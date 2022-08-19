namespace WinFormsApp1
{
    public partial class W10UA : Form
    {
        public W10UA()
        {
            // Default stuff to initialize component, remove form border and make it fullscreen
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Cursor.Hide();

            int sw = Screen.PrimaryScreen.WorkingArea.Width;
            int sh = Screen.PrimaryScreen.WorkingArea.Height;

            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Location = new Point((sw / 2) - webBrowser.Width / 2, (sh / 2) - webBrowser.Height / 2);
            webBrowser.Navigate("https://images-ext-2.discordapp.net/external/h11YLsVtNwY34pvZ_RNqJj7i6M4uLxru4SyGtNnB-yA/https/c.tenor.com/nVrOU5N9UZYAAAAd/windows-update.gif");
            Controls.Add(webBrowser);
        }
    }
}