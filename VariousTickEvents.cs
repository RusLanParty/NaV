using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Native;

namespace NaV
{
    internal class VariousTickEvents : Script
    {
        public VariousTickEvents()
        {
            Tick += onTick;
        }
        void onTick(object sender, EventArgs e)
        {
            if (Function.Call<bool>(Hash.IS_WAYPOINT_ACTIVE))
            {
                Main.dest = World.WaypointPosition;
                OutputArgument dir = new OutputArgument();
                OutputArgument dist = new OutputArgument();
                OutputArgument veh = new OutputArgument();
                Function.Call(Hash.GENERATE_DIRECTIONS_TO_COORD, Main.dest.X, Main.dest.Y, Main.dest.Z, false, dir, veh, dist);
                Main.direction = dir.GetResult<int>();
                Main.distance = dist.GetResult<float>();
                if (Main.debug) { GTA.UI.Screen.ShowHelpText("DISTANCE TO NEXT NODE: " + Main.distance + " Direction: " + Main.direction, 2000, false, false); }
            }
        }
    }
}
