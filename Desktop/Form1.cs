using System.Collections.Immutable;

namespace Desktop
{
    public partial class Form1 : Form
    {
        private List<int> selectedNumbers = new List<int>();
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

                cb.Left = ((i - 1) % 10) * 55 + 40;
                cb.Top = ((i - 1) / 10) * 50 + 40;
                cb.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                cb.AutoSize = true;
                cb.CheckedChanged += select;
                panel1.Controls.Add(cb);

            }
            btnSorsol.Enabled = false;

            lblSorsolt.Text = "";
            lblSelectedNumbers.Text = "";
            lblTalalt.Text = "";

        }

        private void letilt()
        {
            foreach (var item in panel1.Controls)
            {
                if (item is CheckBox cb && !cb.Checked)
                {
                    cb.Enabled = false;
                }
            }
            btnSorsol.Enabled = true;
        }
        private void engedelyez()
        {
            foreach (var item in panel1.Controls)
            {
                if (item is CheckBox cb)
                {
                    cb.Enabled = true;
                }
            }
            btnSorsol.Enabled = false;
        }

        private void select(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            int szam = Convert.ToInt32(cb.Text);
            if (selectedNumbers.Contains(szam))
            {
                selectedNumbers.Remove(szam);
            }
            else
            {
                selectedNumbers.Add(szam);
                selectedNumbers.Sort();
            }
            lblSelectedNumbers.Text = String.Join(",", selectedNumbers);
            if (selectedNumbers.Count == 5) letilt();
            if (selectedNumbers.Count == 4) engedelyez();
            lblSorsolt.Text = "";
            lblTalalt.Text = "";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTorol_Click(object sender, EventArgs e)
        {

            //lblSelectedNumbers.Text = "";
            foreach (var item in panel1.Controls)
            {
                if (item is CheckBox cb)
                {
                    cb.Checked = false;
                }
            }

            lblSorsolt.Text = "";
            lblTalalt.Text = "";

            //selectedNumbers.Clear();
        }

        private void btnSorsol_Click(object sender, EventArgs e)
        {
            HashSet<int> sorsolt = new HashSet<int>();
            Random rnd = new Random();

            do { 
                sorsolt.Add(rnd.Next(1, 91));
            } while (sorsolt.Count < 5);

            var t = sorsolt.ToList();
            t.Sort();

            lblSorsolt.Text = String.Join(",", t);
            var kitalalt = selectedNumbers.Intersect(sorsolt).ToList();
            kitalalt.Sort();
            lblTalalt.Text = String.Join(",", kitalalt);   
        }
    }
}
