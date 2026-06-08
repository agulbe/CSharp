namespace Ders11a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDogum.Text = dateTimePicker1.Value.ToShortDateString();
            lblDogum.Text += "\nDoğum Yılı: "+ dateTimePicker1.Value.Year.ToString();
            lblDogum.Text += "\nDoğum Ayı: " + dateTimePicker1.Value.Month.ToString();
            lblDogum.Text += "\nDoğum Günü: " + dateTimePicker1.Value.Day.ToString();
            lblDogum.Text += "\nDoğum Günü: " + dateTimePicker1.Value.DayOfWeek.ToString();
            lblDogum.Text += "\nDoğum Günü: " + dateTimePicker1.Value.DayOfYear.ToString();
            lblDogum.Text += "\nDoğum Günü: " + dateTimePicker1.Value.TimeOfDay.ToString();
            lblDogum.Text += "\nSaat: " + dateTimePicker1.Value.Hour.ToString();
            lblDogum.Text += "\nDakika: " + dateTimePicker1.Value.Minute.ToString();
            lblDogum.Text += "\nSaniye: " + dateTimePicker1.Value.Second.ToString();  
            
            dateTimePicker1.Format = DateTimePickerFormat.Long;
            
        }
    }
}
