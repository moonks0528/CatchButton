namespace CatchButton
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int score = 0;
        int x = 0;
        int y = 0;

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
                this.Text = $"점수 : {score}, 좌표 : {x}, {y}";
            }
            score -= 10;


            if (score <= -50)
            {
                MessageBox.Show("게임 오버!");
                btnCatch.Enabled = false;
                btnRestart.Visible = true;
                return;
            }

            // 놓쳤을 때 소리
            System.Media.SystemSounds.Asterisk.Play();

            // 버튼 도망
            int maxX = this.ClientSize.Width - btnCatch.Width;
            int maxY = this.ClientSize.Height - btnCatch.Height;

            x = rand.Next(0, maxX);
            y = rand.Next(0, maxY);

            await Task.Delay(1000);

            btnCatch.Location = new Point(x, y);

            this.Text = $"점수 : {score}, 좌표 : {x}, {y}";
        }

        private void btnCatch_Click(object sender, EventArgs e)
        {
            // 잡았을 때 소리
            System.Media.SystemSounds.Beep.Play();
            score += 110;
            //잡았을때 크기 작아지기 (90%size)
            int newWidth = (int)(btnCatch.Width * 0.9);
            int newHeight = (int)(btnCatch.Height * 0.9);

            btnCatch.Size = new Size(newWidth, newHeight);

            this.Text = $"점수 : {score}, 좌표 : {x}, {y}";
            MessageBox.Show("축하합니다!");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            score = 0;

            btnCatch.Size = new Size(623, 378);   // 원래 버튼 크기
            btnCatch.Location = new Point(344, 232); // 처음 위치

            btnCatch.Enabled = true;
            btnRestart.Visible = false;

            this.Text = $"점수 : {score}, 좌표 : 0, 0";
        }
    }
}