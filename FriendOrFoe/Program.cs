using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendOrFoe
{
    class MainClass
    {

        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            List<string> friend = new List<string>();
            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i].Length <= 4)
            //    {
            //        friend.Add(names[i]);
            //    }
            //}

            return names.Where(name => name.Length <= 4);
        }
        public static void Main(string[] args)
        {
            
            string[] FoF = { "Tim", "Kathryn", "Johnation" };
            IEnumerable<string> Friends = FriendOrFoe(FoF);

            foreach (string friend in Friends)
            {
                Console.WriteLine(friend);
            }

            Console.ReadKey();
        }

       

    }
}
