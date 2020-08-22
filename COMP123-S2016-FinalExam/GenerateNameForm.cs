using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    /****************************************************************************************************
     * Author               : Kristopher G. Sabado
     * 
     * Studen Number        : 301118188
     * 
     * Date Last Modified   : August 21, 2020
     * 
     * Program Description  : This program simulates a lotto game in
     * which the player will be able to select a lotto game then the
     * program will be able to generate lottery tickets with random
     * numbers inside
     * 
     * Revision History     : 
     * 
     * Date         Author          Revision
     * 2020-08-21   kitsabado       Created GenerateNames method, edited GenerateNameForm_Load event,
     *                              edited GenerateButton click event, edited Next button click event
     * 
     * 
     * <summary>
     * This is the driver class
     * </summary>
     * 
     * @class Program
     ***************************************************************************************************/

    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void GenerateNames()
        {
            var rand = new Random();
            int indexFirst = rand.Next(FirstNameListBox.Items.Count);
            FirstNameTextBox.Text = FirstNameListBox.Items[indexFirst].ToString();

            int indexLast = rand.Next(LastNameListBox.Items.Count);
            LastNameTextBox.Text = LastNameListBox.Items[indexLast].ToString();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();

            Character character = Program.character;
            character.FirstName = FirstNameTextBox.Text;
            character.LastName = LastNameTextBox.Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm ability = new AbilityGeneratorForm();
            this.Hide();
            ability.Show();
            
        }
    }
}
