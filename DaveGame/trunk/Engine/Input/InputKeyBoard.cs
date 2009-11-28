using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace Engine
{
    public sealed class InputKeyBoard : GameComponent
    {
        public delegate void KeyEventHandler(KeyboardState keyNewState, KeyboardState keyOldState);
        public static event KeyEventHandler KeyEvent;

        static KeyboardState keyNewState, keyOldState;

        public InputKeyBoard(Game game)
            : base(game)
        { }

        public override void Update(GameTime gameTime)
        {
            keyOldState = keyNewState;
            keyNewState = Keyboard.GetState();

            if ((Game.IsActive && (keyNewState.GetPressedKeys().Length > 0 || keyOldState.GetPressedKeys().Length > 0) && KeyEvent != null))
                KeyEvent(keyNewState, keyOldState);
        }
    }
}
