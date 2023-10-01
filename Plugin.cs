using Exiled.API.Features;
using System;
using Server = Exiled.Events.Handlers.Server;
namespace ChaosAnnouncment
{
    public class ChaosAnnouncements : Plugin<Config>
    {

        public EventsHandlers Handlers { get; private set; }
        /// <summary>
        /// Gets a static instance of this class.
        /// </summary>
        public static ChaosAnnouncements Instance { get; private set; }

        /// <inheritdoc/>
        public override string Name => "ChaosAnnouncement";

        /// <inheritdoc/>
        public override string Prefix => "ChaosAnnouncement";

        /// <inheritdoc/>
        public override Version RequiredExiledVersion => new Version(8, 0, 0);

        /// <inheritdoc/>
        public override string Author => "Dashtiss";

        /// <inheritdoc/>
        public override Version Version => new Version(1,0,0);

        public override void OnEnabled()
        {
            
            Handlers = new EventsHandlers(Config);
            try
            { 
 
                Server.RespawningTeam += Handlers.OnTeamRespawn;
                Log.Warn("Loaded the event succesfuly");
                base.OnEnabled();
            }
            catch (Exception ex)
            {
                Log.Error($"An error occurred while enabling ChaosAnnouncement: {ex}");
            }
        }
        public override void OnDisabled()
        {
            Handlers = null;
            Server.RespawningTeam -= Handlers.OnTeamRespawn;
            base.OnDisabled();
        }
    }

    
}
