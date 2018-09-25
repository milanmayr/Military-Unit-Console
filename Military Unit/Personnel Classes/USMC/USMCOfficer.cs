﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit.Personnel_Classes.USMC
{
    class USMCOfficer : PersonnelBase
    {
        public USMCOfficer()
            : base() { }

        // TODO: write CreatePersonnel override for USMC Officers
        public override void CreatePersonnel()
        {
            Console.Write("Input your Marine's first name: ");
            this.FirstName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Input your Marine's last name: ");
            this.LastName = Console.ReadLine();
            Console.WriteLine();

            string[] rankArray = new string[10];
            for (int i = 1; i < 10; i++)
            {
                rankArray[i] = Enum.GetName(typeof(USMCOfficerRank), i);
            }

            Console.WriteLine();

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("#" + i + " - " + rankArray[i]);
            }

            Console.Write("\nInput your Marine's rank #: ");

            int x = Convert.ToInt32(Console.ReadLine());
            this.Rank = ((USMCOfficerRank)x).ToString();

            Console.WriteLine();

            Console.Write("Input your Marine's date of birth (yyyy,mm,dd): ");

            this.DOB = DateTime.Parse(Console.ReadLine());
        }

    }
}