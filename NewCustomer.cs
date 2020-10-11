using System;
using System.Collections.Generic;
using System.Text;

namespace CardScanProgram
{
    static class NewCustomer
    {
        static public string CardCode { get; set; }
        static public DateTime RegistrationDate { get; set; }
        static public string Name { get; set; }
        static public string CardType { get; set; }


        static public string GetAllValues()
        {
            return (NewCustomer.CardCode + " " + NewCustomer.RegistrationDate.ToString() +
                " " + NewCustomer.Name + " " + NewCustomer.CardType);
        }

        static public Boolean Clear()
        {
            try
            {
                CardCode = "";                
                Name = "";
                CardType = "";

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        
    }
}
