namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;


            int nextX = rand.Next(0, maxX);
            int nextY = rand.Next(0, maxY);


            button1.Location = new Point(nextX, nextY);


            this.Text = $"버튼 좌표 - X: {nextX}, Y: {nextY}";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();

           
            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;

            
            button1.Location = new Point(rand.Next(0, maxX), rand.Next(0, maxY));

            this.Text = $"X: {button1.Location.X}, Y: {button1.Location.Y}";
        }
    }
}
