using System;
using System.Collections.Generic;

namespace Practice{
    class IceCream
    {
        public static string GetFlavor()
        {
            List<string> flavors = new List<string>() {
                "chocolate",
                "cookies",
                "strawberry",
                "green tea",
                "nuts"
            };
            Random rand = new Random();
            return flavors[rand.Next(flavors.Count)];
        }

        public static Dictionary<string, string> getUsers()
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            List<string> people = new List<string>() { "Tim", "Martin", "Nikki", "Sara" };
            foreach (string person in people)
            {
                users[person] = GetFlavor();
            }
            return users;
        }

    }
}