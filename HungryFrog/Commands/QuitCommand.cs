using HungryFrog.Interfaces;
using HungryFrog.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryFrog.Commands
{
    class QuitCommand : ICommand
    {
        Game1 game;

        public QuitCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Exit();
        }
    }
}
