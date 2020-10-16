using System;
using System.Windows.Forms;

namespace GetHealthySkelet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null &&
                numericUpDown3.Value < 120 &&
                numericUpDown2.Value > 20 && numericUpDown2.Value < 250 &&
                numericUpDown1.Value > 5 && numericUpDown1.Value < 600 &&
                numericUpDown4.Value < 50)
            {
                Program.gc.AddGebruiker(comboBox1.SelectedIndex,
                Convert.ToInt32(numericUpDown3.Value),
                Convert.ToInt32(numericUpDown2.Value),
                Convert.ToInt32(numericUpDown1.Value),
                Convert.ToInt32(numericUpDown4.Value),
                radioButton2.Checked,
                checkBox1.Checked);

                MessageBox.Show("Gebruiker succesvol toegevoegd!");

                Form3 f3 = new Form3();
                f3.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Oeps, het lijkt erop dat uw gegevens niet helemaal juist zijn...");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
