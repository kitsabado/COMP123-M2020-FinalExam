using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
     * 2020-07-23   kitsabado       Added FirstName and LastName properties
     * 
     * 
     * <summary>
     * This is the driver class
     * </summary>
     * 
     * @class Program
     ***************************************************************************************************/

    public class Character
    {
        public string Strength { get; set; }

        public string Dexterity { get; set; }

        public string Constitution { get; set; }

        public string Intelligence { get; set; }

        public string Wisdom { get; set; }

        public string Charisma { get; set; }

        public string Race { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}