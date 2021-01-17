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

	public class CmdFastFB : Command2 {
		public override string name { get { return "Freebuild"; } }
		public override string shortcut { get { return "FB"; } }
		public override string type { get { return "other"; } }
		public override bool museumUsable { get { return false; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Banned; } }
		
		public override void Use(Player p, string message, CommandData data) {
			Command.Find("goto").Use(p, "freebuild");
		}
		
		public override void Help(Player p) {
			p.Message("%T/Freebuild %for %T/FB");
			p.Message("%HTeleports you to a Freebuild world.");
		}
	}
	
	public class CmdFastPA : Command2 {
		public override string name { get { return "PixelArt"; } }
		public override string shortcut { get { return "PA"; } }
		public override string type { get { return "other"; } }
		public override bool museumUsable { get { return false; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Banned; } }
		
		public override void Use(Player p, string message, CommandData data) {
			Command.Find("goto").Use(p, "pixelart");
		}
		
		public override void Help(Player p) {
			p.Message("%T/PixelArt %for %T/PA");
			p.Message("%HTeleports you to a PixelArt world.");
		}
	}
	
	public class CmdFastGR : Command2 {
		public override string name { get { return "Grief"; } }
		public override string shortcut { get { return "GRF"; } }
		public override string type { get { return "other"; } }
		public override bool museumUsable { get { return false; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Banned; } }
		
		public override void Use(Player p, string message, CommandData data) {
			Command.Find("goto").Use(p, "grief");
		}
		
		public override void Help(Player p) {
			p.Message("%T/Grief %for %T/GRF");
			p.Message("%HTeleports you to a Grief world.");
		}
	}
	
}