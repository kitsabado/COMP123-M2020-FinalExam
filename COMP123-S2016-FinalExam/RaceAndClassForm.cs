using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
     * Date Last Modified   : July 23, 2020
     * 
     * Program Description  : This program simulates a lotto game in
     * which the player will be able to select a lotto game then the
     * program will be able to generate lottery tickets with random
     * numbers inside
     * 
     * Revision History     : 
     * 
     * Date         Author          Revision
     * 2020-08-21   kitsabado       Added a code in RaceRadioButton_CheckedChanged method
     * 
     * 
     * <summary>
     * This is the driver class
     * </summary>
     * 
     * @class Program
     ***************************************************************************************************/

    public partial class RaceAndClassForm : Form
    {
        public AbilityGeneratorForm previousForm;
        private string _selectedRace;


        public RaceAndClassForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Race = this._selectedRace;

            // Step 1 - show the parent form
            this.previousForm.Show();

            // Step 2 - close this form
            this.Close();
        }

        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRace = (RadioButton)sender;

            this._selectedRace = selectedRace.Text;

            //Added to automatically add the race to character when radio button is clicked
            Character character = Program.character;

            character.Race = this._selectedRace;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            FinalForm finalForm = new FinalForm();
            finalForm.previousForm = this;

            finalForm.Show();
            this.Hide();
        }
    }
}
