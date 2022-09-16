using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace project5
{
    internal class cv
    {
        public static int SelectedValue;
        public static MainMenu menu;
        
        public void start()
        {
            onlaunch();
            RunMainMenu();
        }
        public void RunMainMenu()
        {
            Console.WriteLine(" ");
            Console.WriteLine("------------------------Main Menu-------------------------\n");
            
            string[] option = {"Experience", "Education", "Skills", "Technological skills", "Contact Details" };

            menu = new MainMenu(option);
            menu.DisplayOption();

           
            while (true)
            { 
            SelectedValue = menu.Run();
            
                switch (SelectedValue)
                {
                case 0:
                    Console.WriteLine("\n----------------------Experience Menu---------------------- ");
                    string[] experience = { "Ceridain", "accenture","deloitte"};
                    string[] jobDescription = {"Trainee software Developer", "software Engineer", "Network engineer" };
                    menu = new experienceMenu(experience,jobDescription);
                    menu.DisplayOption();
                    back(); //pressed -1 to back to main menu
                    break;

                case 1:
                    Console.WriteLine("\n-----------------Education Menu---------------------");
                    string[] educationandtraining = {"BSc(Hons) Software Engineer", "Networking Training" };
                    string[] courseDescription = {"Module done during year 1:\n 1)Modelling \n 2)S/W engineering principle \n 3) Discrete structure \n 4)Database system \n 5)SVV", "About router and switches" };
                    menu = new experienceMenu(educationandtraining, courseDescription);
                    menu.DisplayOption();
                    back(); //pressed -1 to go back to main menu
                    break;
                case 2:
                        Console.WriteLine("\n My personal skills: ");
                    skills();

                    break;
                case 3:
                    Console.WriteLine("\n My Technological skills: ");
                    technologicalSkills();

                    break;
                case 4:
                    Console.WriteLine("\n My contact details :");
                    Console.WriteLine(" Name:Shabneez Aullymun\n email:shabneez@gmail.com\n telno:843989438");
                    break;
            }
                
            }
        }
        private void onlaunch()
        {
            Console.WriteLine(" Hi!!,\n My name is Shabneez Aullymun and I am looking for a job in the IT sector.\n Below are my full description of my experience, \nThank you"); 
        }
        private void skills()
        {
            //OverView of personal skills
            Console.WriteLine("I love reading books");
            back();
        }
        private void technologicalSkills()
        {
            //Overview of technological skills
            Console.WriteLine("c sharp, c++, java, mysql, automation");
            back();
        }
        public void back()
        {
           
            Console.WriteLine("Press -1 to go back ");
            int value = int.Parse(Console.ReadLine());
            if (value == -1)
            {
                Console.Clear();
                RunMainMenu();

            }
            
        }

    }
}
