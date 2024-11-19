using RoommateAppLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomMateAppLibrary
{
    public class RooommateSearch
    {
        private List<AccountLoginInfo> roommates; //info of possible roommates

        public RooommateSearch()
        {
            roommates = new List<AccountLoginInfo>();

        }

        public void SearchByName(string name)
        {
            var result = roommates.Where(r =>
                (r.FirstName != null && r.FirstName.Contains(name, StringComparison.OrdinalIgnoreCase)) ||
                (r.LastName != null && r.LastName.Contains(name, StringComparison.OrdinalIgnoreCase))
            ).ToList();

            if (result.Count > 0)
            {
                Console.WriteLine("Search results:");
                foreach (var roommate in result)
                {
                    Console.WriteLine($"Name: {roommate.FirstName} {roommate.LastName}, Username: {roommate.Username}");
                }
            }
            else
            {
                Console.WriteLine("No roommate found with that name:");
            }
        }
    }

    class Program //this would be wherever we use it to search
    {
        static void Mani(string[] args)
        {
            RooommateSearch search = new RooommateSearch();

            Console.WriteLine("Enter first or last name of the roommate you want to search:");
            string name = Console.ReadLine();

            search.SearchByName(name);
        }
    }
}