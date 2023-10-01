using Respawning;
using Log = Exiled.API.Features.Log;
using Exiled.Events.EventArgs.Server;

namespace ChaosAnnouncment
{
    public class EventsHandlers
    {
        private readonly Config Config;

        public EventsHandlers(Config config)
        {
            Config = config; // Initialize Config from the constructor
        }

        public void OnTeamRespawn(RespawningTeamEventArgs ev)
        {
            Log.Debug("Running Event");
            if (ev != null)
            {
                if (ev.NextKnownTeam == SpawnableTeamType.ChaosInsurgency)
                {
                    Exiled.API.Features.Cassie.Message(Config.CassieAnnouncement);
                }
            }
        }
    }
}

