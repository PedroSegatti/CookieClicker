namespace CookieClicker
{
    public partial class Form1 : Form
    {
        private int _ticks;
        private int _clicks;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            //Configurações do Cookie
            timer1.Start();
            label2.Text = $"CLICKS: {_clicks}";
            _clicks++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Configurações do Timer
            _ticks++;
            label1.Text = $"TEMPO: {_ticks}";


            if (_ticks == 11)
            {
                timer1.Stop();
                label1.Text = "Fim de Jogo";
                label2.Text = $"Seus Cliques: {_clicks}";
                _ticks = 0;
                _clicks = 0;
                MessageBox.Show("O Tempo Acabou");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Configurações do Refresh do Jogo
            timer1.Stop();
            _clicks = 0;
            _ticks = 0;
            label1.Text = "TEMPO: 10";
            label2.Text = "CLICKS: 0";
        }
    }
}