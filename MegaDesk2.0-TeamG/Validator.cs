using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk_Melo
{
    class Validator
    {
        static public bool ValidateWidth(int input, out string errorMessage)
        {
            
            if (input < Desk.MINIMUM_WIDTH || input > Desk.MAXIMUM_WIDTH)
            {
                errorMessage = "Width out of constraints!\n" +
                    $"Please make sure the input is not lower than {Desk.MINIMUM_WIDTH} and bigger than {Desk.MAXIMUM_WIDTH} inches";
                return false;
            }
            errorMessage = "";
            return true;
        }

        static public bool ValidateDepth(int input, out string errorMessage)
        {

            if (input < Desk.MINIMUM_DEPTH || input > Desk.MAXIMUM_DEPTH)
            {
                errorMessage = "Depth out of constraints!\n" +
                    $"Please make sure the input is not lower than {Desk.MINIMUM_DEPTH} and bigger than {Desk.MAXIMUM_DEPTH} inches";
                return false;
            }
            errorMessage = "";
            return true;
        }

        static public bool ValidateNumDrawers(int input, out string errorMessage)
        {

            if (input < 0 || input > 7)
            {
                errorMessage = "Number of drawers should not be greater than 7 and less than 0!";
                    
                return false;
            }
            errorMessage = "";
            return true;
        }

        static public bool ValidateName(string input, out string errorMessage)
        {

            if (input.Length == 0 || !input.Contains(" "))
            {
                errorMessage = "Enter your full name!";
                return false;
            }
            errorMessage = "";
            return true;
        }
    }
}
