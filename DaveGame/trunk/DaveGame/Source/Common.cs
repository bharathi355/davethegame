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
using System.Reflection;
using System.Diagnostics;

namespace DaveGame
{
    static class Common
    {
        #region Assembly
        /// <summary> Exe neve </summary>
        static string GetAssemblyName()
        {
            return Assembly.GetExecutingAssembly().GetName().Name;
        }

        /// <summary> Exe aktuális verzió száma </summary>
        public static string GetAssemblyVersion()
        {
            return String.Format("{0} v.: {1}", GetAssemblyName(), Assembly.GetExecutingAssembly().GetName().Version);
        }

        /// <summary> Bolondvédelem: Megnézi ez a program fut e már még egy példányban </summary>
        public static bool IsExeRunning()
        {
            var name = GetAssemblyName();
            return (Process.GetProcessesByName(GetAssemblyName()).Length > 1);
        }
        #endregion
    }
}