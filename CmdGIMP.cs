using System;
using MCGalaxy;
using MCGalaxy.Commands;
using MCGalaxy.DB;

// Written in: 2020.11.14
// Last Update: 2020.11.26

namespace MCGalaxy {

	public class CmdGIMP : Command2 {
		public override string name { get { return "GIMP"; } }
		//public override string MCGalaxy_Version { get { return "1.9.2.7"; } }
		//public override string creator { get { return "MasterMen"; } }
		public override string shortcut { get { return "gimp"; } }
		public override string type { get { return "other"; } }
		public override bool museumUsable { get { return false; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Banned; } }
		
		public override void Use(Player p, string message, CommandData data) {
			//if (message == "") { Help(p); return; }
			//string shadows = PlayerInfo.FindMatchesPreferOnline(p, message);
			//Player shadows = PlayerInfo.FindExact(name);
			
			//if (shadows == null) return;
			
			//Player shadows = FindMatches(p, shadows);
			//Player shadows = PlayerInfo.FindMatches(p, shadows);
			//shadowsname = PlayerInfo.GetColoredName(p, shadows);
			string shadows = "shadows";
			Chat.MessageGlobal("{0}%7, You are now a %i{1} %7follower! Welcome to the %eGIMP %7gang!", p.ColoredName, shadows);
		}
		
		public override void Help(Player p) {
			p.Message("&e/GIMP");
			p.Message("&eMakes you a GIMP n times!");
		}
	}
}


