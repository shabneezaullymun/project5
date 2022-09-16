using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project5
{
    //menu for education
    internal class experienceMenu : MainMenu
    {

        private string[] option;
        private string[] description;

        public experienceMenu(string[] option,string [] description) : base(option)
        {
            this.description = description;
        }
        public override void DisplayOption()
        {
            base.DisplayOption();
            while (true)
            {
                int selectedValue = Run();
                for(int i = 0; i < description.Length; i++)
                {
                    if (selectedValue == i)
                    {
                        Console.WriteLine(description[i]);
                        break;
                    }
                }
            }
        }
        public override int Run()
        {
            Console.WriteLine("\nEnter your choice");
            int choice = int.Parse(Console.ReadLine());
            if(choice == -1)
            {
                cv cv = new cv();
                cv.back();
            }
            return choice;
        }
    }
}





