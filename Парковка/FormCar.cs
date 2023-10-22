using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Парковка
{
    public partial class FormCar : Form
    {

        private SportCar car;
        public FormCar()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCars.Width, pictureBoxCars.Height);
            Graphics gr = Graphics.FromImage(bmp);
            car.DrawCar(gr);
            pictureBoxCars.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new SportCar(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
            Color.Yellow, true, true, true);
            car.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCars.Width,
            pictureBoxCars.Height);
            Draw();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    car.MoveTransport(SportCar.Direction.Up);
                    break;
                case "buttonDown":
                    car.MoveTransport(SportCar.Direction.Down);
                    break;
                case "buttonLeft":
                    car.MoveTransport(SportCar.Direction.Left);
                    break;
                case "buttonRight":
                    car.MoveTransport(SportCar.Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
