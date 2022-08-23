namespace Gacha_Simulator
{
    public partial class Gacha : Form
    {
        Random r = new Random();
        public Gacha()
        {
            InitializeComponent();
        }

        private void Gacha_Load(object sender, EventArgs e)
        {
            //GetCardOrCharacter(image1);
            //GetCardOrCharacter(image2);
            //GetCardOrCharacter(image3);
            //GetCardOrCharacter(image4);
            //GetCardOrCharacter(image5);
            //GetCardOrCharacter(image6);
            //GetCardOrCharacter(image7);
            //GetCardOrCharacter(image8);
            //GetCardOrCharacter(image9);
            //GetCardOrCharacter(image10);


            //Show3StarCard(image1);
            //Show3StarCard(image2);
            //Show3StarCard(image3);
            //Show3StarCard(image4);
            //Show3StarCard(image5);
            //Show3StarCard(image6);
            //Show3StarCard(image7);
            //Show3StarCard(image8);
            //Show3StarCard(image9);
            //Show3StarCard(image10);
        }

        private void GetCardOrCharacter(PictureBox image, Panel panel)
        {
            int num = r.Next(1, 101);
            if (num >= 1 && num <= 45) Show3StarCard(image, panel);
            else if (num >= 46 && num <= 85) Show4StarCard(image);
            else if (num >= 86 && num <= 95) Show5StarCard(image, panel);
            else ShowCharacter(image, panel);
        }

        private void Show3StarCard(PictureBox image, Panel panel)
        {
            int fileCount = (from file in Directory.EnumerateFiles(@"image\3 stars cards", "*.png", SearchOption.AllDirectories)
                             select file).Count();
            int num = r.Next(1, fileCount + 1);
            //image.ImageLocation = ("../" + num.ToString() + ".png");
            image.Image = Image.FromFile(@"image\3 stars cards\" + num.ToString() + ".png");
            image.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Show4StarCard(PictureBox image)
        {
            int fileCount = (from file in Directory.EnumerateFiles(@"image\4 stars cards", "*.png", SearchOption.AllDirectories)
                             select file).Count();
            int num = r.Next(1, fileCount + 1);
            image.Image = Image.FromFile(@"image\4 stars cards\" + num.ToString() + ".png");
            image.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Show5StarCard(PictureBox image, Panel panel)
        {
            int fileCount = (from file in Directory.EnumerateFiles(@"image\5 stars cards", "*.png", SearchOption.AllDirectories)
                             select file).Count();
            int num = r.Next(1, fileCount + 1);
            image.Image = Image.FromFile(@"image\5 stars cards\" + num.ToString() + ".png");
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            panel.BackColor = Color.Blue;
        }

        private void ShowCharacter(PictureBox image, Panel panel)
        {
            int fileCount = (from file in Directory.EnumerateFiles(@"image\characters", "*.png", SearchOption.AllDirectories)
                             select file).Count();
            int num = r.Next(1, fileCount + 1);
            image.Image = Image.FromFile(@"image\characters\" + num.ToString() + ".png");
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            panel.BackColor= Color.Red;
        }

        private void prayOnce_Click(object sender, EventArgs e)
        {
            Reset();
            GetCardOrCharacter(image1, panel1);
        }

        private void pray10Times_Click(object sender, EventArgs e)
        {
            Reset();
            GetCardOrCharacter(image1, panel1);
            GetCardOrCharacter(image2, panel2);
            GetCardOrCharacter(image3, panel3);
            GetCardOrCharacter(image4, panel4);
            GetCardOrCharacter(image5, panel5);
            GetCardOrCharacter(image6, panel6);
            GetCardOrCharacter(image7, panel7);
            GetCardOrCharacter(image8, panel8);
            GetCardOrCharacter(image9, panel9);
            GetCardOrCharacter(image10, panel10);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            image1.Image = null;
            panel1.BackColor = Color.Transparent;
            image2.Image = null;
            panel2.BackColor = Color.Transparent;
            image3.Image = null;
            panel3.BackColor = Color.Transparent;
            image4.Image = null;
            panel4.BackColor = Color.Transparent;
            image5.Image = null;
            panel5.BackColor = Color.Transparent;
            image6.Image = null;
            panel6.BackColor = Color.Transparent;
            image7.Image = null;
            panel7.BackColor = Color.Transparent;
            image8.Image = null;
            panel8.BackColor = Color.Transparent;
            image9.Image = null;
            panel9.BackColor = Color.Transparent;
            image10.Image = null;
            panel10.BackColor = Color.Transparent;
        }
    }
}