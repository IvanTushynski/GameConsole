using GameConsole;

internal class Program
{
    private static void Main(string[] args)
    {

        SaveLoad saveLoad = new SaveLoad();



        int i = 1;
        while (i > 0)
        {
            Console.WriteLine("Press 1(Save) or 2(Load) or 3");
            String selectNumbers;
            selectNumbers = Console.ReadLine();
            if (selectNumbers == "1")
            {
                saveLoad.saveData();
            }
            else if (selectNumbers == "2")
            {
                saveLoad.loadData();
            }
            else if (selectNumbers == "3")
            {
                break;
            }
            i++;
        }
    }
}