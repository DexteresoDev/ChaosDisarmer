using Exiled.API.Interfaces;
using System.ComponentModel;

namespace ChaosDisarmer
{
    public sealed class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;
        [Description("Will the plugin outout debug information?")]
        public bool debug { get; set; } = false;
    }
}
