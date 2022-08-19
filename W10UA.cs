namespace cripsy_winupd
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

            iconLoading.Location = new Point((sw / 2) - iconLoading.Width / 2, (sh / 2) - iconLoading.Height / 2);
            label1.Location = new Point(label1.Location.X, (label1.Height * 20));
            //updatesLabel.Location = new Point((sw / 2) - updatesLabel.Width / 2, (sh / 2) - updatesLabel.Height / 2 + 24);
            //iconLoading.Location = new Point((sw / 2) - iconLoading.Width / 2, (sh / 2) - iconLoading.Height / 2);
        }
    }
}