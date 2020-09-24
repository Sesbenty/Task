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

            gameObjects.Add(player);
        }

        public override void Unload()
        {
            throw new NotImplementedException();
        }
    }
}
