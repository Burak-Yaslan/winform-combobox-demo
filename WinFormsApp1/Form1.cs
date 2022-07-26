namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Region> r_list = new List<Region>();
            r_list.Add(new Region() { Id = 1, Name = "Marmara" });
            r_list.Add(new Region() { Id = 2, Name = "Karadeniz" });
            r_list.Add(new Region() { Id = 3, Name = "Ege" });

            foreach (Region r in r_list)
            {
                boxRegion.Items.Add(r.Name);
            }

            //boxRegion.Items.Add("Marmara");
            //boxRegion.Items.Add("Karadeniz");
            //boxRegion.Items.Add("Ege");


        }

        private void boxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<City> c_list = new List<City>();
            c_list.Add(new City() { Id = 1, Name = "Ýstanbul" });
            c_list.Add(new City() { Id = 2, Name = "Tekirdað" });
            c_list.Add(new City() { Id = 3, Name = "Bursa" });

            c_list.Add(new City() { Id = 4, Name = "Trabzon" });
            c_list.Add(new City() { Id = 5, Name = "Rize" });
            c_list.Add(new City() { Id = 6, Name = "Samsun" });

            c_list.Add(new City() { Id = 7, Name = "Ýzmir" });
            c_list.Add(new City() { Id = 8, Name = "Manisa" });
            c_list.Add(new City() { Id = 9, Name = "Aydýn" });

            boxCity.Items.Clear();
            if (boxRegion.SelectedItem == "Marmara")
            {

                foreach (City c in c_list)
                {
                    if(c.Id <=3)
                    {
                        boxCity.Items.Add(c.Name);
                    }
                }
                //boxCity.Items.Add("Ýstanbul");
                //boxCity.Items.Add("Tekirdað");
                //boxCity.Items.Add("Bursa");
            }
            else if (boxRegion.SelectedItem == "Karadeniz")
            {
                foreach (City c in c_list)
                {
                    if (c.Id > 3 && c.Id <=6)
                    {
                        boxCity.Items.Add(c.Name);
                    }
                }

                //boxCity.Items.Add("Trabzon");
                //boxCity.Items.Add("Rize");
                //boxCity.Items.Add("Samsun");
            }
            else if (boxRegion.SelectedItem == "Ege")
            {
                foreach (City c in c_list)
                {
                    if (c.Id > 6 && c.Id <=9)
                    {
                        boxCity.Items.Add(c.Name);
                    }
                }

                //boxCity.Items.Add("Ýzmir");
                //boxCity.Items.Add("Manisa");
                //boxCity.Items.Add("Aydýn");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string region = (string)boxRegion.SelectedItem;
            string city = (string)boxCity.SelectedItem;

            MessageBox.Show("Seçilen bölge: "+ region + "\nSeçilen Þehir: "+city);
        }
    }
}