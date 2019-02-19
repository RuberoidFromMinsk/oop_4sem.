using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class TextCalculatorMainWindow : Form
    {
        public TextCalculatorMainWindow()
        {
            InitializeComponent();
        }

        private void concatBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    userInput1.Text == "" &&
                    userInput2.Text == "" &&
                    userInput3.Text == ""
                    )
                {
                    throw new Exception();
                }

                outputField.Text =
                TextCalculator.ConcatStrings(
                    TextCalculator.ConcatStrings(userInput1.Text, userInput2.Text),
                    userInput3.Text
                    );
            }
            catch (Exception)
            {
                outputField.Text = "Enter text first";
            }
        }

        private void SubstrToSubstrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    userInput1.Text == "" ||
                    userInput2.Text == "" ||
                    userInput3.Text == ""
                    )
                {
                    throw new Exception();
                }

                outputField.Text = TextCalculator.SubstrReplace(
                   userInput1.Text,
                   userInput2.Text,
                   userInput3.Text
                   );
            }
            catch (Exception)
            {
                outputField.Text = "Invalid input";
            }
        }

        private void removeSubstrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                outputField.Text = TextCalculator.RemoveSubstr(
                userInput1.Text,
                userInput2.Text == "" ? userInput3.Text : userInput2.Text
                );
            }
            catch (Exception)
            {
                outputField.Text = "Invalid input";
            }
        }

        private void charByIndexBtn_Click(object sender, EventArgs e)
        {
            try
            {
                outputField.Text = TextCalculator.GetCharByIndex(
                userInput1.Text,
                Convert.ToInt32(userInput2.Text)
                )
                .ToString();
            }
            catch (Exception)
            {
                outputField.Text = "Invalid input";
            }
        }

        private void stringLengthBtn_Click(object sender, EventArgs e)
        {
            try
            {
                outputField.Text = userInput1.Text != "" ?
                TextCalculator.GetStringLength(userInput1.Text).ToString() :
                userInput2.Text != "" ?
                TextCalculator.GetStringLength(userInput2.Text).ToString() :
                userInput3.Text != "" ?
                TextCalculator.GetStringLength(userInput3.Text).ToString() :
                throw new Exception();
            }
            catch (Exception)
            {
                outputField.Text = "Enter text first";
            }

        }

        private void doubleVowelsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                outputField.Text = userInput1.Text != "" ?
                TextCalculator.GetDoubledVowels(userInput1.Text) :
                userInput2.Text != "" ?
                TextCalculator.GetDoubledVowels(userInput2.Text) :
                userInput3.Text != "" ?
                TextCalculator.GetDoubledVowels(userInput3.Text) :
                throw new Exception();
            }
            catch (Exception)
            {
                outputField.Text = "Enter text first";
            }
        }

        private void userInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputLabel1_Click(object sender, EventArgs e)
        {

        }

        private void userInput2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
