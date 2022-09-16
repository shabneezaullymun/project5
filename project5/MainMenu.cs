using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project5
{
    internal class MainMenu : MenuInterface
    {
        private string[] option;
        public MainMenu(string[] option)
        {
            this.option = option;
        }

        public virtual void DisplayOption()
        {
            for (int i = 0; i < option.Length; i++)
            {
                Console.Write(i+" "+ option[i]+ "    ");
            }
        }
        public virtual int Run()
        {   
            Console.Write(" \nEnter your choice  ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}

