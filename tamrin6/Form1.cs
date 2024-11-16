using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamrin6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCar_Click(object sender, EventArgs e)
        {
            vehicle car = new Car();
            car.start();
        }

        private void ButtonBike_Click(object sender, EventArgs e)
        {
            vehicle bake = new Bake();
            bake.start();
        }
    }
    public abstract class vehicle
    {
        public abstract void start();
    }
    public class Car : vehicle
    {
        public override void start()
        {
            MessageBox.Show("After we start, you can enjoy your journey with peace of mind");
        }
    }
        public class Bake : vehicle
        {
            public override void start()
            {
                MessageBox.Show("After starting with the bike, your legs will start to get tired");
            }
        }
    }

