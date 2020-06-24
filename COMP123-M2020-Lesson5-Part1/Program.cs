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
            float playerSpeed = 20.0f; // 20 units

            Player player = new Player();

            player.RaiseShields();
            player.transform.position = new Vector2D(100.0f, 100.0f);
            Console.WriteLine(player.ToString());

            player.transform.position += Vector2D.Up() * playerSpeed;
            Console.WriteLine(player.ToString());

            // listen for any key
            Console.ReadLine();
        }
    }
}
