using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<int> collection;

      
        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            int collectionSize = 0;

            try
            {
                collectionSize = Convert.ToInt32(userSizeInput.Text);
            }
            catch (Exception)
            {
                listField.Text = "Invalid size.";
            }

            collection = GenerateList(collectionSize);
            listField.Clear();

            foreach (var item in collection)
            { 
                listField.AppendText($"{item}\n");
            }
        }

        private void AscendingBtn_Click(object sender, EventArgs e)
        {
            var sortedCollection = SortCollection(collection);

            listField.Clear();

            foreach (var item in sortedCollection)
            {
                listField.AppendText($"{item}\n");
            }
        }

        private void DescendingBtn_Click(object sender, EventArgs e)
        {
            var sortedCollection = SortCollection(collection, true);

            listField.Clear();

            foreach (var item in sortedCollection)
            {
                listField.AppendText($"{item}\n");
            }
        }

        
        private List<int> GenerateList(int size)
        {
            var newList = new List<int>();
            var random = new Random();

            for (int i = 0; i < size; i++)
            {
                newList.Add(random.Next(-100, 100));
            }

            return newList;
        }

        private IOrderedEnumerable<int> SortCollection(IEnumerable<int> collection, bool byDescending = false)
        {
            IOrderedEnumerable<int> sortedCollection;

            if (byDescending)
            {
                sortedCollection = from item in collection
                                   orderby item
                                   descending
                                   select item;
            }
            else
            {
                sortedCollection = from item in collection
                                   orderby item
                                   select item;
            }

            return sortedCollection;
        }

        private void RangeBtn_Click(object sender, EventArgs e)
        {
            var selectedCollection = from item in collection
                                           where item > 0
                                           select item;

            resultField.Clear();

            foreach (var item in selectedCollection)
            {
                resultField.AppendText($"{item}\n");
            }
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {                                   
            resultField.Clear();

            resultField.Text = collection.Min().ToString();
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            resultField.Clear();

            resultField.Text = collection.Max().ToString();
        }


    }
}
