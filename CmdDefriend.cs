using System;
using MCGalaxy;
using MCGalaxy.Commands;
using MCGalaxy.DB;

// -------------------------- //
// Made by MasterMen for Astral Dream
// -------------------------- //
// Written in: 2021.07.14
// Last Update: 2021.07.14
// -------------------------- //

namespace MCGalaxy {

	public class CmdDefriend : Command2 {
		public override string name { get { return "Defriend"; } }
		public override string shortcut { get { return "dfnd"; } }
		public override string type { get { return "other"; } }
		public override bool museumUsable { get { return false; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Banned; } }
		
		public override void Use(Player p, string message, CommandData data) {
			if (message.Length == 0) { p.Message("You need to provide a player name and a reason to defriend."); return; }
			
			string[] args = message.SplitSpaces(2);
			
			Command.Find("undoplayer").Use(p, args[0] + " 90d");
			Command.Find("warn").Use(p, args[0] + " &gBlacklisted &7from Freebuild, &xReason:&f " + args[1]);
			Command.Find("perbuild").Use(p, "freebuild -" + args[0]);
			
		}
		
		public override void Help(Player p) {
			p.Message("%T/Defriend <Player> <Reason>");
			p.Message("%HBlacklists a person from the Freebuild with Reason");
		}
	}
	
}
