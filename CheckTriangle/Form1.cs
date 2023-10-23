using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace CheckTriangle
{
    public partial class CheckTriangle : Form
    {
        public CheckTriangle()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            double firstSideSize;
            double secondSideSize;
            double thirdSideSize;

            if (double.TryParse(FirstSideSizeTextBox.Text, out firstSideSize)
                && double.TryParse(SecondSideSizeTextBox.Text, out secondSideSize)
                && double.TryParse(ThirdSideSizeTextBox.Text, out thirdSideSize))

            {
                if (firstSideSize + secondSideSize > thirdSideSize && secondSideSize + thirdSideSize > firstSideSize
                    && thirdSideSize + firstSideSize > secondSideSize && firstSideSize > 0 && secondSideSize > 0
                    && thirdSideSize > 0)
                {
                    if (firstSideSize == secondSideSize && secondSideSize == thirdSideSize)
                    {
                        ResultLabel.Text = "Треугольник равносторонний";
                    }

                    else if (firstSideSize == secondSideSize || firstSideSize == thirdSideSize 
                        || secondSideSize == thirdSideSize)
                    {
                        ResultLabel.Text = "Треугольник равнобедренный";
                    }

                    else
                    {
                        ResultLabel.Text = "Треугольник разносторонний";
                    }
                }
                else
                {
                    ResultLabel.Text = "Треугольника не сущетсвует и (или)\n одна из его сторон равна 0";
                }
            }
            else
            {
                ResultLabel.Text = "Вводите цифры!";
            }

        }
    }

}
