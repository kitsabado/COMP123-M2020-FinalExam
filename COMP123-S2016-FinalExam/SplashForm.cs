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
     * 2020-07-23   kitsabado       Created SplashForm on program start
     * 
     * 
     * <summary>
     * This is the driver class
     * </summary>
     * 
     * @class Program
     ***************************************************************************************************/

    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
    
        private void SplashForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer t = new Timer();
            t.Start();
            t.Tick += new EventHandler(t_Tick);
            
        }
        void t_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Close();
        }
    }
    
}
