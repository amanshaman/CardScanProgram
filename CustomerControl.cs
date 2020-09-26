using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardScanProgram
{
    class CustomerControl
    {
        //file is at bin/debug by default
        private string filepath = "CustomerData.txt";
        public void AddRecord(string cardCode, string name, string cardType, DateTime registrationDate)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(this.filepath, true))
                {
                    file.WriteLine(cardCode + "," + name + "," + cardType + "," + registrationDate.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public string[] SearchRecord(string record)
        {
            try
            {
                foreach (var line in System.IO.File.ReadAllLines(this.filepath))
                {
                    string[] temp = line.Split(',');
                    if (temp[0] == record)
                    {
                        Console.WriteLine(line.ToString());
                        return temp;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }
    }
}
