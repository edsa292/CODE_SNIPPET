namespace NotifyIcon_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Enviar Notificaci√≥";
            notifyIcon1.BalloonTipText = "Notificaci√≥ enviada desde la aplicaci√≥";
            notifyIcon1.ShowBalloonTip(5000);
        }
    }
}
