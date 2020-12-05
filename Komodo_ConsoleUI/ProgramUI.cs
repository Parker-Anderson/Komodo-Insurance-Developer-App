﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komodo_Repo;


namespace Komodo_ConsoleUI
{
    public class ProgramUI
    {
        public void Run()
        {

            Menu();

        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select a Menu Option:\n" +
                    "1. View Developer List.\n" +
                    "2. View Team List.\n" +
                    "3. View Developers Needing PluralSight Access.\n" +
                    "4. Create New Team.\n" +
                    "5. Add Developer(s) to Team.\n" +
                    "6. Remove Developer from Team.\n" +
                    "7. Exit.");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ViewDevList();
                        break;
                    case "2":
                        ViewTeamList();
                        break;
                    case "3":
                        NeedPSList();
                        break;
                    case "4":
                        CreateTeam();
                        break;
                    case "5":
                        AddDev();
                        
                        Console.WriteLine("Do you want to add another Developer? y/n:");
                        string choice = Console.ReadLine();
                        while (choice == "y")
                        {
                            AddDev();
                            Console.WriteLine("Do you want to add another Developer? y/n:");
                            string loopchoice = Console.ReadLine();
                            if(loopchoice == "y")
                            {
                                AddDev();
                            }
                            else
                            {
                                break;
                            }
                           
                      

                        }
                  
                        break;
                    case "6":
                        RemoveDev();
                        
                        break;
                    case "7":
                        Console.WriteLine("Goodbye.");
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Please Enter a Valid Selection.");
                        break;


                }
                Console.WriteLine("Press Any Key to Continue:");
                Console.ReadKey();
                Console.Clear();


            }
        }
        private void ViewDevList()
        {
            //List<Developer> developers = _devList.GetDevList();
            
            

        }

        private void ViewTeamList()
        {
            //List<DevTeam> listofTeams = _devTeams.GetTeamList();

        }

        private void NeedPSList()
        {
            //List<Developer> needPSList = _devList.NeedsPSList();
            

        }

        private void CreateTeam()
        {
            DevTeam newTeam = new DevTeam();

            Console.WriteLine("Enter the Name of the Team:");
            newTeam.TeamName = Console.ReadLine();
            Console.WriteLine("Enter the Team ID number:");
            string teamIDString = Console.ReadLine();
            int newTeamID = int.Parse(teamIDString);
            newTeam.TeamID = newTeamID;
            Console.WriteLine("Add Team Members from Main Menu.");
            

            
        }

        private void AddDev()
        {
            Developer newDev = new Developer();

            Console.WriteLine("Enter the Name of the Developer:");
            newDev.DevName = Console.ReadLine();
            Console.WriteLine("Enter the Unique Developer ID number:");
            string devidstring = Console.ReadLine();
            int devid = int.Parse(devidstring);
            newDev.DevID = devid;


        }

        private void RemoveDev()
        {
            //RemoveDevFromList

        }
    }

    
}