using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            Enemy redEnemy = new Enemy("Red Enemy");
            redEnemy.transform.position = new Vector2D(225.0f, 200.0f);
            Console.WriteLine(redEnemy.ToString());

            float distance = Vector2D.Distance(player.transform.position, redEnemy.transform.position);
            Console.WriteLine($"The Distance between the player and the red enemy is {distance}");

            player.Health -= redEnemy.FireBullet();
            Console.WriteLine(player.ToString());

            BossEnemy boss = new BossEnemy();
            boss.transform.position = Vector2D.Zero();
            Console.WriteLine(boss.ToString());

            float bossDistance = Vector2D.Distance(player.transform.position, boss.transform.position);
            Console.WriteLine($"The Distance between the player and the boss is {bossDistance}");

            player.Health -= boss.FireBullet();
            Console.WriteLine(player.ToString());


            // listen for any key
            Console.ReadLine();
        }
    }
}
