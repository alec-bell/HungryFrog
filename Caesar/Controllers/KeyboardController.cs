using Caesar.Interfaces;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar.Controllers
{
    class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> controlMap;

        public KeyboardController(Dictionary<Keys, ICommand> controlMap)
        {
            this.controlMap = controlMap;
        }

        public void Update()
        {
            KeyboardState currentKeyboardState = Keyboard.GetState();
            Keys[] keysPressed = currentKeyboardState.GetPressedKeys();

            foreach (Keys key in keysPressed)
            {
                if (controlMap.ContainsKey(key))
                    controlMap[key].Execute();
            }
        }
    }
}
