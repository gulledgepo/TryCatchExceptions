//Week 1 Assignment 1
//Chapter 12 Exercise 1, pg 834
//08/18/2017
//Program gets two values user input values, stores them, multiplies them
//and displays the product in a list box as well as both numbers and the product
//in a separate listbox. Emphasis is on exceptions for the try-catch block.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void ClearForms()
        {
            //Clear all forms called upon
            txtNumOne.Clear();
            txtNumTwo.Clear();
            lstNumOne.Items.Clear();
            lstNumTwo.Items.Clear();
            lstProduct.Items.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Call our Clear Forms
            ClearForms();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            //Create our three int variables
            int numberOne = 0;
            int numberTwo = 0;
            int product;
            //Our big try clause to make sure we can accomplish everything, with two exceptions to inform the user
            //of what went wrong
            try
            {
               //If our text boxes are null or empty we throw a new exception which will warn the user to fill out all fields
               if ((txtNumOne.Text == "" || txtNumOne.Text == null) || (txtNumTwo.Text == "" || txtNumTwo.Text == null)) throw new Exception();
               //We try to parse the two fields into int variables, if this can't happen it will trigger our FormatException catch
               numberOne = int.Parse(txtNumOne.Text);
               numberTwo = int.Parse(txtNumTwo.Text);
               //Set our product variable to a method that multiplies numberOne and numberTwo
               product = Multiply(numberOne, numberTwo);
               //We clear our the text fields
               txtNumOne.Clear();
               txtNumTwo.Clear();
               txtNumOne.Focus();
               lstProduct.Items.Add(product.ToString());
               lstNumOne.Items.Add(numberOne.ToString());
               lstNumTwo.Items.Add(numberTwo.ToString());
               txtNumOne.Focus();
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show(exc.Message);
            }
            //This catch runs when a non whole number or non-numeric character is entered
            catch (FormatException)
            {
               MessageBox.Show("Please ensure only whole numbers are entered in the fields.");
            }
            //This catch runs when a null or empty space is provided           
            catch (Exception)
            {
                MessageBox.Show("Please ensure all fields are filled out.");
            }

        }

        public int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //On load put the focus into text box number One
            txtNumOne.Focus();
        }
    }
}
