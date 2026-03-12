namespace CatchButton
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCatch_MouseEnter(object sender, EventArgs e)
        {
            if (Control.MouseButtons != MouseButtons.None)
                return;
            // 놓쳤을 때 소리
            System.Media.SystemSounds.Asterisk.Play();
            //System.Threading.Thread.Sleep(800);

            // 버튼 도망
            int maxX = this.ClientSize.Width - btnCatch.Width;
            int maxY = this.ClientSize.Height - btnCatch.Height;

            int x = rand.Next(0, maxX);
            int y = rand.Next(0, maxY);
            await Task.Delay(1000);
            btnCatch.Location = new Point(x, y);

            // 좌표 표시
            this.Text = $"버튼 좌표 : {x}, {y}";
        }

        private void btnCatch_Click(object sender, EventArgs e)
        {
            // 잡았을 때 소리
            System.Media.SystemSounds.Beep.Play();

            MessageBox.Show("축하합니다!");
        }
    }
}