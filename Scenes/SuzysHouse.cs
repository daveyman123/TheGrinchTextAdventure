using System;
using System.Collections.Generic;
using System.Text;

namespace TheGrinch.Scenes
{
    class SuzysHouse : Scene
    {
        public SuzysHouse(Game game) : base(game)
        {

        }
        public override void Run()
        {
            scenes.Add(this.GetType().Name);
        }
    }
}
