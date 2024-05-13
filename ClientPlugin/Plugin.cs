using Sandbox.Game;
using System;
using VRage.Plugins;

namespace ClientPlugin
{
    // ReSharper disable once UnusedType.Global
    public class Plugin : IPlugin, IDisposable
    {
        public void Init(object gameInstance)
        {
            MyPlatformGameSettings.SHOW_QUICKSTART_MENU_BUTTON = false;
        }

        public void Dispose()
        {

        }

        public void Update()
        {
            
        }
    }
}