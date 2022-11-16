using System.Diagnostics;

namespace GameEngine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Value = 300;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    image1.ImageLocation = imageLocation;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            image1.Size = new Size(trackBar1.Value, image1.Size.Height);
            image1.Left = (ClientSize.Width - image1.Width) / 2;
            image1.Left = (ClientSize.Height - image1.Height) / 2;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (image1.ImageLocation != "")
                {
                    image1.ImageLocation = "";
                }
                else
                {
                    MessageBox.Show("Error", "Image does not exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void movingObject_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        int newX = 0;
        int newY = 0;

        private void Up_Tick(object sender, EventArgs e)
        {
            newX = Cursor.Position.X - 250;
            newY = Cursor.Position.Y - 350;
            image1.Location = new Point(newX, newY);
        }


        private void image1_Click(object sender, EventArgs e)
        {
            Up.Enabled = true;

        }

        private void image1_DoubleClick(object sender, EventArgs e)
        {
            Up.Enabled = false;
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            Up.Enabled = false;
        }
    }
}