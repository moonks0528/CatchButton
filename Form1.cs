using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCatch_MouseEnter(object sender, EventArgs e)
        {
            //버튼 도망
            int maxX = this.ClientSize.Width - btnCatch.Width;
            int maxY = this.ClientSize.Height - btnCatch.Height;

            int x = rand.Next(0, maxX);
            int y = rand.Next(0, maxY);

            btnCatch.Location = new Point(x, y);

            this.Text = $"버튼 좌표 : {x}, {y}";
        }
    }
}
