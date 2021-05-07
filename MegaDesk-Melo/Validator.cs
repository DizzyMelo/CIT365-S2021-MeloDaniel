using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk_Melo
{
    class Validator
    {
        static public int ValidateWidth(String input)
        {
            int value = 0;
            try 
            { 
                value = Convert.ToInt32(input);
            }
            catch(FormatException)
            {
                throw new FormatException("Please, make sure you provide a whole number!");
            }

            if (value < Desk.MINIMUM_WIDTH || value > Desk.MAXIMUM_WIDTH)
            {
                throw new ArgumentException("Width out of constraints!\n" +
                    $"Please make sure the input is not lower than {Desk.MINIMUM_WIDTH} and bigger than {Desk.MAXIMUM_WIDTH} inches");
            }
            return value;
        }

        static public int ValidateDepth(String input)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(input);
            }
            catch (FormatException)
            {
                throw new FormatException("Please, make sure you provide a whole number!");
            }

            if (value < Desk.MINIMUM_DEPTH || value > Desk.MAXIMUM_DEPTH)
            {
                throw new ArgumentException("Depth out of constraints!\n" +
                    $"Please make sure the input is not lower than {Desk.MINIMUM_DEPTH} and bigger than {Desk.MAXIMUM_DEPTH} inches");
            }
            return value;
        }
    }
}
