using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Objects;
using System.Drawing;
using Task.Geometry;

namespace Task
{
    class GameBase : Game
    {
        public GameBase(Size Resolution):base(Resolution){

        }
        public override void Load()
        {
            GameObject player = new GameObject();
            Sprite sprtiePlayer = new Sprite(player, Properties.Resources.cat);
            player.AddComponent(sprtiePlayer);

            MoveInput input = new MoveInput(player, 200);
            player.AddComponent(input);

            GameObject player2 = new GameObject();
            Sprite sprtiePlayer2 = new Sprite(player2, Properties.Resources.cat);
            player2.AddComponent(sprtiePlayer2);

            MoveInput input2 = new MoveInput(player2, 400);
            player2.AddComponent(input2);
            player2.position.x = 100;

            GameObject enemy = new GameObject();
            Sprite spriteEnemy = new Sprite(enemy, Properties.Resources.bear, 200, 100);
            enemy.AddComponent(spriteEnemy);

            enemy.position.x = 200;

            gameObjects.Add(enemy);
            gameObjects.Add(player);
            gameObjects.Add(player2);


            Random rnd = new Random(100);
            for (int i = 0; i < 20; i++)
            {
                gameObjects.Add(box(new Vector2((float)rnd.NextDouble()*200,(float)rnd.NextDouble()*200)));
            } 

        }

        public GameObject box(Vector2 postion)
        {
            GameObject box = new GameObject();
            var p = new List<Vector2>();
            p.Add(new Vector2(0, 0));
            p.Add(new Vector2(200, 0));
            p.Add(new Vector2(0, 200));
            p.Add(new Vector2(200, 200));

            var l = new List<Point>();
            l.Add(new Point(0, 1));
            l.Add(new Point(1, 3));
            l.Add(new Point(3, 2));
            l.Add(new Point(2, 0));

            GeometryObject gbox = new GeometryObject(box, p, l);
            box.AddComponent(gbox);
            box.position = postion;

            return box;
        }

        public override void Unload()
        {
            throw new NotImplementedException();
        }
    }
}
