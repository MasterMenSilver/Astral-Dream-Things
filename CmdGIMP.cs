using System;
using MCGalaxy;
using MCGalaxy.Commands;
using MCGalaxy.DB;

// -------------------------- //
// Made by MasterMen for Astral Dream.
// -------------------------- //
// Written in: 2020.11.14
// Last Update: 2020.12.24
// -------------------------- //

namespace MCGalaxy {

	public class CmdGIMP : Command2 {
		public override string name { get { return "GIMP"; } }
		public override string shortcut { get { return "gimp"; } }
		public override string type { get { return "other"; } }
		public override bool museumUsable { get { return false; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Banned; } }
		
		public override void Use(Player p, string message, CommandData data) {
			
			//p.DisplayName
			//p.truename
			//p.name
			//p.ColoredName
			
			Player shad = PlayerInfo.FindMatches(p, "shadows");
			if(p == shad) {
				Chat.MessageGlobal("{0} is a GIMP king! Everybody do /GIMP command and become their slave!", p.ColoredName);
			} else {
				Chat.MessageGlobal("{0}%7, You are now a %i{1} %7follower! Welcome to the %eGIMP %7gang!", p.ColoredName, shad.ColoredName);
			}
		}
		
		public override void Help(Player p) {
			p.Message("%T/GIMP");
			p.Message("%HMakes you a GIMP n times!");
		}
	}
	
}


