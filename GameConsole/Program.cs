using GameConsole;

internal class Program
{
    private static void Main(string[] args)
    {

        SaveLoad saveLoad = new SaveLoad();



      for(int i = 1; i > 0; i++)
        {
            Console.WriteLine("-----Press 1(Save/Load) : 4(exit)-----");
            String selectNumbers;
            selectNumbers = Console.ReadLine();
            if (selectNumbers == "1")
            {
                saveLoad.saveDataMenu();
            }
            else if (selectNumbers == "4")
            {
                break;
            }
        }
    }
}