using System;
using System.Collections.Generic;
using System.Text;

namespace TheGrinch.Scenes
{
    class SusysHouse : Scene
    {
        public SusysHouse(Game game) : base(game)
        {

        }
        public override void Run()
        {
            scenes.Add(this.GetType().Name);
        }
    }
}
