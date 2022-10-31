using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    public class SaveLoad
    {
        public void saveData()
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\user\\source\\repos\\GameConsole\\GameConsole\\saveData.txt");
            //Write a line of text
            int a = 12;
            sw.Write(a);
            sw.Close();
        }

        public void loadData()
        {
            StreamReader streamReader = new StreamReader("C:\\Users\\user\\source\\repos\\GameConsole\\GameConsole\\saveData.txt");
            String line = streamReader.ReadLine();
            int a = int.Parse(line);
            Console.WriteLine("Saved Data is " + a);
            streamReader.Close();
            Console.ReadLine();
        }
    }
}
