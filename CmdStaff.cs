using System;

// Written in: 2020.11.XX
// Last Update: 2020.11.26

namespace MCGalaxy {
	
	public class CmdStaff : Command2 {
		public override string name { get { return "Staff"; } }
		//public override string MCGalaxy_Version { get { return "1.9.2.7"; } }
		//public override string creator { get { return "MasterMen"; } }
		public override string shortcut { get { return "st"; } }
		public override bool MessageBlockRestricted { get { return false; } }
		public override string type { get { return "other"; } }
		public override bool museumUsable { get { return false; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Operator; } }
		
		public override void Use(Player p, string message, CommandData data) {
			Command.Find("viewranks").Use(p, "Admin");
			Command.Find("viewranks").Use(p, "Moderator");
			Command.Find("viewranks").Use(p, "Trusted");
		}
		public override void Help(Player p) {
			p.Message("%T/Staff");
            p.Message("%HShows you the staff members.");
		}
	}
	
}