using Caesar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar.Commands
{
    class MoveUpCommand : ICommand
    {
        private PlayerContext player;

        public MoveUpCommand(PlayerContext player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.MoveUp();
        }
    }
}
