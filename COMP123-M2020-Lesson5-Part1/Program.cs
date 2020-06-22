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
            Player player = new Player();

            Enemy greenEnemy = new Enemy("Green Enemy");

            Enemy redEnemy = new Enemy("Red Enemy");

            BossEnemy bossEnemy = new BossEnemy();

            player.RaiseShields();
            player.transform.position = new Vector2D(100.0f, 100.0f);
            Console.WriteLine(player.ToString());

            greenEnemy.FireBullet();
            greenEnemy.transform.position = new Vector2D(60.0f, 80.0f);
            Console.WriteLine(greenEnemy.ToString());

            redEnemy.FireBullet();
            redEnemy.transform.position = new Vector2D();
            Console.WriteLine(redEnemy.ToString());

            bossEnemy.FireBullet();
            bossEnemy.transform.position = new Vector2D(200.0f, 200.0f);
            Console.WriteLine(bossEnemy.ToString());

            // listen for any key
            Console.ReadLine();
        }
    }
}
