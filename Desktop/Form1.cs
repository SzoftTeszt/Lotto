namespace Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 91; i++)
            {
                CheckBox cb = new CheckBox();
                cb.Text = i.ToString();

                cb.Left = ((i-1)%10)*55+40;
                cb.Top = ((i-1)/10)*50+40;
                cb.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                cb.AutoSize = true;
                panel1.Controls.Add(cb);

            }
            
        }
    }
}
