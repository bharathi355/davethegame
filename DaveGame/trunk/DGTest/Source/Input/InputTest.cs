using DaveGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Engine;
using Microsoft.Xna.Framework.Input;

namespace DGTest
{
    [TestClass()]
    public class InputTest
    {
        Game game;

        #region Keyboard
        [TestMethod()]
        [DeploymentItem("DaveGame.exe")]
        public void InputKeyboardTest()
        {
            Game game = new Game();
            this.game = game;
            game.Window.Title = "InputKeyboard Test";
            InputKeyBoard.KeyEvent += InputKeyBoard_KeyEvent;

            game.Run();
        }

        void InputKeyBoard_KeyEvent(KeyboardState keyNewState, KeyboardState keyOldState)
        {
            if (keyNewState.IsKeyDown(Keys.Escape) && keyOldState.IsKeyUp(Keys.Escape)) game.Exit();

            if (keyNewState.IsKeyDown(Keys.Up) && keyOldState.IsKeyUp(Keys.Up)) game.Window.Title = "Up";
            if (keyNewState.IsKeyDown(Keys.Down) && keyOldState.IsKeyUp(Keys.Down)) game.Window.Title = "Down";
            if (keyNewState.IsKeyDown(Keys.Left) && keyOldState.IsKeyUp(Keys.Left)) game.Window.Title = "Left";
            if (keyNewState.IsKeyDown(Keys.Right) && keyOldState.IsKeyUp(Keys.Right)) game.Window.Title = "Right";
        }
        #endregion
    }
}