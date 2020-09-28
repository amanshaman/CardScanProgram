using System;
using System.Collections.Generic;
using System.Text;

namespace CardScanProgram
{
    static class NewCustomer
    {
        static public string cardCode;
        static public DateTime registrationDate;
        static public string name;
        static public string cardType;


        static public string GetAllValues()
        {
            return (NewCustomer.cardCode + " " + NewCustomer.registrationDate.ToString() +
                " " + NewCustomer.name + " " + NewCustomer.cardType);
        }

        static public Boolean Clear()
        {
            try
            {
                cardCode = "";                
                name = "";
                cardType = "";

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        
    }
}
