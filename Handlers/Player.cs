using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;

namespace ChaosDisarmer.Handlers
{
    class Player
    {
        public void OnChangedRole(ChangedRoleEventArgs ev)
        {
            var Config = new Config();
            if (Config.debug)
            {
                Log.Debug($"{ev.Player} changed from {ev.OldRole} to {ev.Player.Role}");
            }

            try
            {
                if (ev.Player.Role == RoleType.ChaosInsurgency)
                {
                    ev.Player.AddItem(ItemType.Disarmer);
                }
                if (Config.debug)
                {
                    Log.Debug($"Gave {ev.Player} a Disarmer");
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Unable to give player ({ev.Player}) a Disarmer");
                Log.Error($"Exception: {ex}");
            }
        }
    }
}
