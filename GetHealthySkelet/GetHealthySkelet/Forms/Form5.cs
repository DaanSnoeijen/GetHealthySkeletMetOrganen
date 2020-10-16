using System;
using System.Windows.Forms;

namespace GetHealthySkelet
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            textBox1.Text =
                "Minimale calorie inname: " + Program.uc.UitkomstList[0].minimaleCalorieën +
                ". Maximale calorie inname: " + Program.uc.UitkomstList[0].maximaleCalorieën +
                ". Uw calorie inname: " + Program.ic.InvoerList[0].calorieën;

            textBox2.Text =
                "Minimale vet inname: " + Program.uc.UitkomstList[0].minimaleTotaleVetten +
                ". Maximale vet inname: " + Program.uc.UitkomstList[0].maximaleTotaleVetten +
                ". Uw vet inname: " + Program.ic.InvoerList[0].totaleVetten;

            textBox3.Text =
                "Minimale verzadigde vet inname: " + Program.uc.UitkomstList[0].minimaleVerzagdigdeVetten +
                ". Maximale verzadigde vet inname: " + Program.uc.UitkomstList[0].maximaleVerzagdigdeVetten +
                ". Uw verzadigde vet inname: " + Program.ic.InvoerList[0].verzagdigdeVetten;

            textBox4.Text =
                "Minimale koolhydraat inname: " + Program.uc.UitkomstList[0].minimaleKoolhydraten +
                ". Maximale koolhydraat inname: " + Program.uc.UitkomstList[0].maximaleKoolhydraten +
                ". Uw koolhydraat inname: " + Program.ic.InvoerList[0].koolhydraten;

            textBox5.Text =
                "Minimale suiker inname: " + Program.uc.UitkomstList[0].minimaleSuikers +
                ". Maximale suiker inname: " + Program.uc.UitkomstList[0].maximaleSuikers +
                ". Uw suiker inname: " + Program.ic.InvoerList[0].suikers;

            textBox6.Text =
                "Minimale eiwit inname: " + Program.uc.UitkomstList[0].minimaleEiwitten +
                ". Maximale eiwit inname: " + Program.uc.UitkomstList[0].maximaleEiwitten +
                ". Uw eiwit inname: " + Program.ic.InvoerList[0].eiwitten;

            textBox7.Text =
                "Minimale zout inname: " + Program.uc.UitkomstList[0].minimaleZouten +
                ". Maximale zout inname: " + Program.uc.UitkomstList[0].maximaleZouten +
                ". Uw zout inname: " + Program.ic.InvoerList[0].zouten;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home f1 = new Home();
            f1.Show();
            this.Close();
        }
    }
}
