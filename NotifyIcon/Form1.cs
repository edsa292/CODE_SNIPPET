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
            notifyIcon1.BalloonTipTitle = "Enviar Notificació";
            notifyIcon1.BalloonTipText = "Notificació enviada desde la aplicació";
            notifyIcon1.ShowBalloonTip(5000);
        }
    }
}
