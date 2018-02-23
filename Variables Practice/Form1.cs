using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_Practice
{
    public partial class variablesPractice : Form
    {
        public variablesPractice()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            string hockeyPlayer = "Wayne Gretzky";
            int playerNumber = 99;

            textLabel.Text = hockeyPlayer + " is number " + playerNumber + ".";
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            int radius = 15;
            double pi = 3.14;
            double area = pi * radius * radius;

            textLabel.Text = "The area of a circle with a radius of " + radius + "cm is: \n" + area + "cm^2.";
        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            int width = 6;
            double area = length * width;
            double price = 19.95;
            double cost = area * price;

            textLabel.Text = "The area of a room with the dimensions of " + length + "m x " + width + "m is: " + area + "m^2. \n\nThe cost to carpet this area at $" +price+ " per square meter is: " +cost+ "m^2.";
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            double costShirt = 12.49;
            double tax = costShirt * 0.13;
            double totalCost = costShirt + tax;
            int bill = 20;
            double change = bill - totalCost;

            textLabel.Text = "Bill Of Sale \n\nShirt: $" + costShirt + "\n\nTax: $" + tax + "\nTotal: $" + totalCost + "\n\nAmount Given: $" + bill + "\nChange: $" + change;
        }
    }
}
