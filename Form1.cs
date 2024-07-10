using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace YardManagement
{
    public partial class Form1 : Form
    {
        private Dictionary<int, PictureBox> pictureBoxDictionary = new Dictionary<int, PictureBox>();
        private Dictionary<int, Label> labelDictionary = new Dictionary<int, Label>();
        private Point targetPosition;
        private System.Windows.Forms.TextBox textBoxCoilId;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.PictureBox crane;
        private System.Windows.Forms.CheckBox checkBoxChangeImage;
        private System.Windows.Forms.Label labelCoilId;
        private System.Windows.Forms.Label labelLabel;

        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
            crane.SendToBack(); // Send crane to back after initializing the grid
        }

        private void InitializeGrid()
        {
            int pictureBoxWidth = 100;
            int pictureBoxHeight = 100;
            int spacing = 10;
            // Create column number labels
            for (int col = 0; col < 10; col++)
            {
                Label columnLabel = new Label
                {
                    Name = $"columnLabel{col}",
                    Size = new Size(pictureBoxWidth, 20),
                    Location = new Point(50 + (col * (pictureBoxWidth + spacing)), 70), // Adjust the y position as needed
                    Text = $"Column {col}",
                    TextAlign = ContentAlignment.MiddleCenter
                };
                this.Controls.Add(columnLabel);
            }

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    int index = row * 10 + col;

                    PictureBox pictureBox = new PictureBox
                    {
                        Name = $"pictureBox{index}",
                        Size = new Size(pictureBoxWidth, pictureBoxHeight),
                        Location = new Point(50 + (col * (pictureBoxWidth + spacing)), 100 + (row * (pictureBoxHeight + spacing))),
                        Image = Properties.Resources.Cut_back,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };

                    Label label = new Label
                    {
                        Name = $"label{index}",
                        Size = new Size(pictureBoxWidth, 20),
                        Location = new Point(50 + (col * (pictureBoxWidth + spacing)), 100 + pictureBoxHeight + (row * (pictureBoxHeight + spacing))),
                        Text = $"Position {index}",
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    pictureBoxDictionary.Add(index, pictureBox);
                    labelDictionary.Add(index, label);
                    this.Controls.Add(pictureBox);
                    this.Controls.Add(label);
                }
            }
        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCoilId.Text, out int id) && pictureBoxDictionary.ContainsKey(id))
            {
                targetPosition = pictureBoxDictionary[id].Location;
                MoveCrane(id);
            }
            else
            {
                MessageBox.Show("Please enter a valid coil ID.");
            }
        }

        private void MoveCrane(int id)
        {
            Timer timer = new Timer { Interval = 10 };
            timer.Tick += (sender, e) =>
            {
                int step = 5; // step size

                // Move crane horizontally
                if (crane.Location.X != targetPosition.X)
                {
                    int direction = targetPosition.X > crane.Location.X ? 1 : -1;
                    int remainingDistance = Math.Abs(targetPosition.X - crane.Location.X);
                    crane.Left += direction * Math.Min(step, remainingDistance);
                }

                else
                {
                    timer.Stop();
                    crane.Location = new Point(targetPosition.X, crane.Location.Y);

                    if (checkBoxChangeImage.Checked)
                    {
                        pictureBoxDictionary[id].Image = Properties.Resources.Coil;
                    }
                    else
                    {
                        pictureBoxDictionary[id].Image = Properties.Resources.Cut_back;
                    }

                    if (!string.IsNullOrWhiteSpace(textBoxLabel.Text))
                    {
                        labelDictionary[id].Text = textBoxLabel.Text;
                    }
                }
            };
            timer.Start();
        }
    }
}