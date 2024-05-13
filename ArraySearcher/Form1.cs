using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySearcher
{
    public partial class Form1 : Form
    {
        private int[] intArray;
        private double[] doubleArray;
        public Form1()
        {
            InitializeComponent();
        }

        public static int Search<T>(T[] array, T searchKey) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(searchKey) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

       

        private void btnInt_Click_1(object sender, EventArgs e)
        {
            // Generate random int array
            Random random = new Random();
            intArray = new int[5];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(100);
            }

            // Display array in intTextBox
            displayBox.Text = String.Join(", ", intArray);
        }

        private void btnDouble_Click_1(object sender, EventArgs e)
        {
            // Generate random double array
            Random random = new Random();
            doubleArray = new double[5];
            for (int i = 0; i < doubleArray.Length; i++)
            {
                doubleArray[i] = Math.Round(random.NextDouble() * 99, 2);
            }

            // Display array in doubleTextBox
            displayBox.Text = String.Join(", ", doubleArray);

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            // Get search key
            int searchKey;
            double searchKeyDouble;
            bool isInt = int.TryParse(searchIndex.Text, out searchKey);
            bool isDouble = double.TryParse(searchIndex.Text, out searchKeyDouble);

            // Search int array
            int intIndex = Search<int>(intArray, searchKey);
            if (intIndex != -1)
            {
                resultBox.Text = $"{intIndex}";
                return;
            }

            // Search double array
            int doubleIndex = Search<double>(doubleArray, searchKeyDouble);
            if (doubleIndex != -1)
            {
                resultBox.Text = $"{doubleIndex}";
                return;
            }

            // If search key not found in either array
            resultBox.Text = "-1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
