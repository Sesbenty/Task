using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Objects;
using System.Drawing;

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
            
        }

        public override void Unload()
        {
            throw new NotImplementedException();
        }
    }
}
