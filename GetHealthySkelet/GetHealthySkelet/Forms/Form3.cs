using System;
using System.Windows.Forms;

namespace GetHealthySkelet
{
    public partial class Form3 : Form
    {
        int hoeveelheid = 0;

        UitkomstController uC = new UitkomstController();

        public Form3()
        {
            InitializeComponent();

            for (int i = 0; i < 100; i++)
            {
                Program.pc.createProduct(hoeveelheid);
                listBox1.Items.Add(Program.pc.ProductList[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Invoer berekening
            double calorieën = 0;
            double totaleVetten = 0;
            double verzadigdeVetten = 0;
            double koolhydraten = 0;
            double suikers = 0;
            double eiwitten = 0;
            double zouten = 0;

            foreach (Product product in listBox2.Items)
            {
                calorieën += product.calorieën;
                totaleVetten += product.totaleVetten;
                verzadigdeVetten += product.verzadigdeVetten;
                koolhydraten += product.koolhydraten;
                suikers += product.suikers;
                eiwitten += product.eiwitten;
                zouten += product.zouten;

                if (product.hoeveelheid == 0)
                {
                    calorieën *= 5;
                    totaleVetten *= 5;
                    verzadigdeVetten *= 5;
                    koolhydraten *= 5;
                    suikers *= 5;
                    eiwitten *= 5;
                    zouten *= 5;
                }
                else if (product.hoeveelheid == 1)
                {
                    calorieën *= 2.5;
                    totaleVetten *= 2.5;
                    verzadigdeVetten *= 2.5;
                    koolhydraten *= 2.5;
                    suikers *= 2.5;
                    eiwitten *= 2.5;
                    zouten *= 2.5;
                }
                else if (product.hoeveelheid == 3)
                {
                    calorieën *= 0.5;
                    totaleVetten *= 0.5;
                    verzadigdeVetten *= 0.5;
                    koolhydraten *= 0.5;
                    suikers *= 0.5;
                    eiwitten *= 0.5;
                    zouten *= 0.5;
                }
                else if (product.hoeveelheid == 4)
                {
                    calorieën *= 0.1;
                    totaleVetten *= 0.1;
                    verzadigdeVetten *= 0.1;
                    koolhydraten *= 0.1;
                    suikers *= 0.1;
                    eiwitten *= 0.1;
                    zouten *= 0.1;
                }
            }

            Program.ic.AddInvoer(calorieën, totaleVetten, verzadigdeVetten, koolhydraten, suikers, eiwitten, zouten);

            //Uitkomst berekening
            uC.BerekenActiviteit();
            uC.BerekenBMI();

            uC.BerekenCalorieën();
            uC.BerekenTotaleVetten();
            uC.BerekenVerzadigdeVetten();
            uC.BerekenKoolhydraten();
            uC.BerekenSuikers();
            uC.BerekenEiwitten();
            uC.BerekenZouten();

            MessageBox.Show("Berekening compleet!");

            Form5 f5 = new Form5();
            f5.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hier wordt de index van comboBox1 de hoeveelheid van het product. Zo kan ik later zeggen dat index 2 bijvoorbeeld 200 gram is.
            Program.pc.ProductList[listBox1.SelectedIndex].hoeveelheid = comboBox1.SelectedIndex;

            if (Program.pc.ProductList[listBox1.SelectedIndex].hoeveelheid != -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Voer alstublieft de hoeveelheid in voor het toevoegen");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (textBox1.Text != "")
            {
                foreach (Product product in Program.pc.ProductList)
                {
                    if (product.ToString().Contains(textBox1.Text) == true)
                    {
                        listBox1.Items.Add(product);
                    }
                }
            }
            else
            {
                foreach (Product product in Program.pc.ProductList)
                {
                    listBox1.Items.Add(product);
                }
            }
        }
    }
}
