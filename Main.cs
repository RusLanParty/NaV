using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Math;
using GTA.Native;
using NAudio.Wave;

namespace NaV
{
    public class Main : Script
    {
        public static bool debug = false;
        public static Vector3 dest;
        public static int direction;
        public static float distance;
        bool spamBlock;
        int comp= 0;
        bool first = true;
        bool waypoint = false;
        bool inRange = false;
        bool inRange1 = false;
        bool inRange2 = false;
        bool inRange3 = false;
        
        public Main()
        {
            Tick += onTick;
        }
        
        
        void onTick(object sender, EventArgs e)
        {
            Ped player = Game.Player.Character;
            if (!player.IsInVehicle())
            {
                first = true;
            }
            if (player.IsInVehicle())
            {
                if(!player.IsInHeli && !player.IsInPlane)
                {
                    if (!Function.Call<bool>(Hash.IS_WAYPOINT_ACTIVE) && waypoint)
                    {
                        waypoint = false;
                        spamBlock = false;
                        first = true;
                        Audio.playDir(-1, 0, spamBlock);
                    }
                    if (Function.Call<bool>(Hash.IS_WAYPOINT_ACTIVE))
                    {
                        if (first)
                        {
                            waypoint = true;
                            spamBlock = false;
                            first = false;
                            Audio.playDir(9, 0, spamBlock);
                        }
                        if (distance <= 800 && distance > 500 && !inRange && comp == direction)
                        {
                            if (debug) { GTA.UI.Screen.ShowSubtitle("800 - 500", 2000); }
                            spamBlock = false;
                            Audio.playDir(direction, distance, spamBlock);
                            inRange = true;
                        }
                        if (inRange)
                        {
                            if (distance > 800 || distance < 500)
                            {
                                inRange = false;
                            }
                        }
                        else

                        if (distance <= 500 && distance > 300 && !inRange1 && comp == direction)
                        {
                            if (debug) { GTA.UI.Screen.ShowSubtitle("500 - 300", 2000); }
                            spamBlock = false;
                            Audio.playDir(direction, distance, spamBlock);
                            inRange1 = true;
                        }
                        if (inRange1)
                        {
                            if (distance > 500 || distance < 300)
                            {
                                inRange1 = false;
                            }
                        }
                        else
                        if (distance <= 200 && distance > 100 && !inRange2 && comp == direction)
                        {
                            if (debug) { GTA.UI.Screen.ShowSubtitle("200 - 100", 2000); }
                            spamBlock = false;
                            Audio.playDir(direction, distance, spamBlock);
                            inRange2 = true;
                        }
                        if (inRange2)
                        {
                            if (distance > 200 || distance < 100)
                            {
                                inRange2 = false;
                            }
                        }
                        else
                        if (distance <= 20 && distance > 0 && !inRange3 && comp == direction)
                        {
                            if (debug) { GTA.UI.Screen.ShowSubtitle("100 - 0", 2000); }
                            spamBlock = false;
                            Audio.playDir(direction, distance, spamBlock);
                            inRange3 = true;
                        }
                        if (inRange3)
                        {
                            if (distance > 20 || distance < 0)
                            {
                                inRange3 = false;
                            }
                        }
                        else
                        if (comp != direction)
                        {
                            spamBlock = false;
                            comp = direction;
                            // Wait(1245);
                        }
                    }
                }
            }
        }
       
    }
}
