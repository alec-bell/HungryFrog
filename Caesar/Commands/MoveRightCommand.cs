using Caesar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar.Commands
{
    class MoveRightCommand : ICommand
    {
        private PlayerContext player;

        public MoveRightCommand(PlayerContext player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.MoveRight();
        }
    }
}
