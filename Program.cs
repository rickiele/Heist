using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make it pretty
            Console.Title = "Heist";
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Plan Your Heist!");

            // Prompt user to answer questions
            Console.WriteLine("What's your team member's name?");
            string MemberName = Console.ReadLine();

            Console.WriteLine("What's your team member's skill level?");
            int MemberSkillLevel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's your team member's courage level?");
            decimal MemberCourageLevel = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(@$"Your Team Member's stats:
            Name: {MemberName}
            Skill Level: {MemberSkillLevel}
            Courage Level: {MemberCourageLevel}");

            // Instantiate HeistPeeps to have a new member
            TeamMember HeistPeeps = new TeamMember(MemberName, MemberSkillLevel, MemberCourageLevel);

            // List to store the new members
            List<TeamMember> HeistMembers = new List<TeamMember>()
            {
                HeistPeeps

            };

            // Loop over each team member to display them
            foreach (TeamMember peep in HeistMembers)
            {
                Console.WriteLine(@$"Heist Team 
                Name:{peep.Name} 
                Skill Level: {peep.SkillLevel} 
                Courage Level: {peep.CourageFactor}");
            }





        }
    }
}
