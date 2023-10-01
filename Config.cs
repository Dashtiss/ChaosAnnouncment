using System.ComponentModel;
using Exiled.API.Interfaces;

namespace ChaosAnnouncment
{
    public class Config : IConfig
    {
        /// <inheritdoc/>
        public bool IsEnabled { get; set; } = true;
        /// <inheritdoc/>
        public bool Debug { get; set; } = false;
        [Description("What will cassie say when chaos spawns")]
        public string CassieAnnouncement { get; set; } = "Unknown Military Group has entered the facility. Designated The Chaos Insurgency";
    }
}