using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    public class SaveLoad : Player
    {
        public void saveDataLevel()
        {
            StreamWriter sw = new StreamWriter("files/saveDataLevel.txt");
            int levelDataSave = level;
            sw.Write(levelDataSave);
            sw.Close();
        }

        public int loadDataLevel()
        {
            StreamReader streamReader = new StreamReader("files/saveDataLevel.txt");
            String line = streamReader.ReadLine();
            int levelDataLoad = int.Parse(line);
            streamReader.Close();
            Console.ReadLine();
            return levelDataLoad;
        }

        public void saveDataMenu()
        {

            for (int j = 1; j > 0; j++)
            {
                Console.WriteLine("-----Press 1(Save) : 2(Load) : 3(stats) : 4(to Menu)-----");
                String selectNumbers;
                selectNumbers = Console.ReadLine();
                if (selectNumbers == "1")
                {
                    saveDataLevel();
                }
                else if (selectNumbers == "2")
                {
                    loadDataLevel();
                }
                else if (selectNumbers == "3")
                {
                    Console.WriteLine("Attack: " + GetAttack());
                    Console.WriteLine("Defence: " + GetDefense());
                    Console.WriteLine("Health: " + GetHealth());
                    Console.WriteLine("Level: " + GetLevel());

                }
                else if (selectNumbers == "4")
                {
                    break;
                }
            }
        }

    }
}
