using Exiled.API.Enums;
using Exiled.API.Features;
using System;

namespace ChaosDisarmer
{
    public class ChaosDisarmer : Plugin<Config>
    {
        private static readonly ChaosDisarmer Singleton = new ChaosDisarmer();
        public override string Name { get; } = "ChaosDisarmer";
        public override string Author { get; } = "Jatc251";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 11, 1);
        public override string Prefix { get; } = "chaosdisarmer";
        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        private Handlers.Player player;
        public static ChaosDisarmer Instance => Singleton;

        private ChaosDisarmer()
        {

        }

        public override void OnEnabled()
        {
            if (Config.IsEnabled)
            {
                Log.Debug("Thanks for using ChaosDisarmer by Jatc251.");
                RegisterEvents();
            }

        }

        public override void OnDisabled()
        {
            UnRegisterEvents();
        }

        public void RegisterEvents()
        {
            player = new Handlers.Player();
            Exiled.Events.Handlers.Player.ChangedRole += player.OnChangedRole;
        }

        public void UnRegisterEvents()
        {
            Exiled.Events.Handlers.Player.ChangedRole -= player.OnChangedRole;
            player = null;
        }
    }
}
