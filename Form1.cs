namespace CatchButton
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCatch_MouseEnter(object sender, EventArgs e)
        {
            // 클릭하다 놓치면 -10
            if (Control.MouseButtons == MouseButtons.Left)
            {
                score -= 10;
                this.Text = $"점수 : {score}";
            }
            score -= 10;


            // 놓쳤을 때 소리
            System.Media.SystemSounds.Asterisk.Play();

            // 버튼 도망
            int maxX = this.ClientSize.Width - btnCatch.Width;
            int maxY = this.ClientSize.Height - btnCatch.Height;

            int x = rand.Next(0, maxX);
            int y = rand.Next(0, maxY);

            await Task.Delay(1000);

            btnCatch.Location = new Point(x, y);

            this.Text = $"점수 : {score}";
        }

        private void btnCatch_Click(object sender, EventArgs e)
        {
            // 잡았을 때 소리
            System.Media.SystemSounds.Beep.Play();
            score += 110;

            int newWidth = (int)(btnCatch.Width * 0.9);
            int newHeight = (int)(btnCatch.Height * 0.9);

            btnCatch.Size = new Size(newWidth, newHeight);

            this.Text = $"점수 : {score}";

            MessageBox.Show("축하합니다!");
        }
    }
}