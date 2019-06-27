using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_lesson8B
{
    public partial class Lab08Form : Form
    {
        // class properties
        public string UserName { get; set; }
        public float UserAge { get; set; }
        /// <summary>
        /// this is the constructor for Lab08Form
        /// </summary>
        public Lab08Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this is the event handler for the Lab08Form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab08Form_Load(object sender, EventArgs e)
        {
            ClearFrom();
        }
        /// <summary>
        /// this is the even handler for the SubmitBottum click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;
            //option A
            // UserAge = Convert.ToSingle(AgeTextBox.Text);
            //option B *the best
            UserAge = float.Parse(AgeTextBox.Text);
            /* //option C
             float tempFloat;
             bool result= float.TryParse(AgeTextBox.Text, out tempFloat);
             UserAge = tempFloat;    */
            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;
            ClearFrom();
        }
        /// <summary>
        /// this methods clears the textboxes on the form and reset other properties
        /// </summary>
        private void ClearFrom()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
            SubmitButton.Enabled = false;
        }
                
        /// <summary>
        /// this is the event handler for the agetextbox textchanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgetextBox_TextChanged(object sender, EventArgs e)
        {
            //simple input validation
            try
            {
                float.Parse(AgeTextBox.Text);
                SubmitButton.Enabled = true;
            }
            catch 
            {
                SubmitButton.Enabled = false;
            }
            
        }
       
        /// <summary>
        /// this is the event handler for the nametextbox taxtchanged event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length < 2) ? false : true;                               

        }
    }
}
