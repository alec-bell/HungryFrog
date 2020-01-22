using HungryFrog.Interfaces;
using HungryFrog.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryFrog.Commands
{
    class MoveDownCommand : ICommand
    {
        private PlayerContext player;

        public MoveDownCommand(PlayerContext player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.MoveDown();
        }
    }
}
