using PresidentApp.Backend;

namespace PresidentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
           
        {
            string numOfYearsResiding = textBox1.Text;
            string birthday = textBox2.Text;
            string numOfTerms = textBox3.Text;
            if (numOfYearsResiding.Length == 0)
            {
                MessageBox.Show("Please Enter the Number of years you resided in the United States");
            }
            if (birthday.Length == 0)
            {
                MessageBox.Show("Please Enter a Birthdate");
            }
            else
            {
                DateTime birthdate;
                bool isValidDate = DateTime.TryParse(textBox2.Text, out birthdate);
                if (!isValidDate)
                {
                    MessageBox.Show("Please Enter your Birthdate in the format 'mm/dd/yyyy'");
                }

            }
            if (numOfTerms.Length == 0)
            {
                MessageBox.Show("Please Enter the number of terms you have served in the past");
            }
            bool isACitizen = checkBox1.Checked;
            bool isCorrupt = checkBox2.Checked;
            PresidentialAnalyzer presidentialAnalyzer = new PresidentialAnalyzer(isACitizen, birthday, int.Parse(numOfYearsResiding), int.Parse(numOfTerms), isCorrupt);
            MessageBox.Show(presidentialAnalyzer.Response());

        }

    }
}
