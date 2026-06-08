using MySwitch.MyControls;
namespace MySwitch
{
    public partial class Form1 : Form
    {
        int prevX = 0, prevY = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void modernSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            statusButton1.Enabled = modernSwitch1.Checked;
        }

        private void statusButton1_Click(object sender, EventArgs e)
        {
            var status = sender as StatusButton;
            status.IndicatorPosition = status.IndicatorPosition switch
            {
                StatusButton.IndicatorLocation.TopLeft => StatusButton.IndicatorLocation.TopRight,
                StatusButton.IndicatorLocation.TopRight => StatusButton.IndicatorLocation.BottomRight,
                StatusButton.IndicatorLocation.BottomRight => StatusButton.IndicatorLocation.BottomLeft,
                StatusButton.IndicatorLocation.BottomLeft => StatusButton.IndicatorLocation.TopLeft,
                _ => status.IndicatorPosition
            };
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            //var mouseX = e.X;
            //var mouseY = e.Y;
            //if (prevX != mouseX || prevY != mouseY)
            //{
            //    Left += mouseX - prevX;
            //    Top += mouseY - prevY;
            //    prevX = mouseX; 
            //    prevY = mouseY;
            //}
        }

        private void statusButton1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Status Button Clicked!");  
        }
    }
}
