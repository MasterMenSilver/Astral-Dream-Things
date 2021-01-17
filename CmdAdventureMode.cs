using System;
using MCGalaxy;
using MCGalaxy.Commands;
using MCGalaxy.DB;

// -------------------------- //
// Made by MasterMen for Astral Dream
// -------------------------- //
// Written in: 2021.01.17
// Last Update: 2021.01.17
// -------------------------- //

namespace MCGalaxy {

	public class CmdAdventureMode : Command2 {
		public override string name { get { return "Adventure"; } }
		public override string shortcut { get { return "ad"; } }
		public override string type { get { return "other"; } }
		public override bool museumUsable { get { return false; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Banned; } }
		
		public override void Use(Player p, string message, CommandData data) {
			
			Command.Find("Overseer").Use(p, "map buildable");
			Command.Find("Overseer").Use(p, "map deletable");
			
		}
		
		public override void Help(Player p) {
			p.Message("%T/Adventure %for %T/AD");
			p.Message("%HActivates or Deactivates your OS Buildable and Deletable settings.");
		}
	}
	
}