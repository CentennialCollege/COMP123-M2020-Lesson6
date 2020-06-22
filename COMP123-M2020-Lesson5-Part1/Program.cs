using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            GameObject player = new GameObject("Player");

            //player.transform.position = new Vector2D();

            Console.WriteLine(player.ToString());

            // listen for any key
            Console.ReadLine();
        }
    }
}
