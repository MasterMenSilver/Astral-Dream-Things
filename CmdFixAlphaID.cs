using System;
using MCGalaxy;
using MCGalaxy.Commands;
using MCGalaxy.DB;

// -------------------------- //
// Made by MasterMen for Astral Dream
// -------------------------- //
// Written in: 2020.12.20
// Last Update: 2020.12.24
// -------------------------- //

namespace MCGalaxy {

	public class CmdFixAlphaID : Command2 {
		public override string name { get { return "FixAlphaID"; } }
		public override string shortcut { get { return "fixaid"; } }
		public override string type { get { return "other"; } }
		public override bool museumUsable { get { return false; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Banned; } }
		
		public override void Use(Player p, string message, CommandData data) {
			
			//                               OldID NewID
			Command.Find("ReplaceAll").Use(p, "180 578"); // PinkPolishedClay
			Command.Find("ReplaceAll").Use(p, "181 571"); // VioletPolishedClay
			Command.Find("ReplaceAll").Use(p, "182 564"); // WhitePolishedClay
			Command.Find("ReplaceAll").Use(p, "183 557"); // YellowPolishedClay
			Command.Find("ReplaceAll").Use(p, "184 550"); // CyanPolishedClay
			Command.Find("ReplaceAll").Use(p, "185 543"); // BeigePolishedClay
			Command.Find("ReplaceAll").Use(p, "186 536"); // LimePolishedClay
			Command.Find("ReplaceAll").Use(p, "187 529"); // LightGreyPolishedClay
			Command.Find("ReplaceAll").Use(p, "188 522"); // OrangePolishedClay
			Command.Find("ReplaceAll").Use(p, "189 515"); // BluePolishedClay
			Command.Find("ReplaceAll").Use(p, "190 508"); // GreyPolishedClay
			Command.Find("ReplaceAll").Use(p, "191 501"); // RedPolishedClay
			
			Command.Find("ReplaceAll").Use(p, "192 494"); // GreenPolishedClay
			Command.Find("ReplaceAll").Use(p, "193 487"); // BrownPolishedClay
			Command.Find("ReplaceAll").Use(p, "194 480"); // DarkGreyPolishedClay
			Command.Find("ReplaceAll").Use(p, "195 473"); // IndigoPolishedClay
			Command.Find("ReplaceAll").Use(p, "196 466"); // DarkPurplePolishedClay
			Command.Find("ReplaceAll").Use(p, "197 459"); // BlackPolishedClay
			
			Command.Find("ReplaceAll").Use(p, "233 332"); // Black Stone slab-D
			Command.Find("ReplaceAll").Use(p, "232 333"); // Black Stone slab-U
			Command.Find("ReplaceAll").Use(p, "252 331"); // Black Stone
			Command.Find("ReplaceAll").Use(p, "251 331"); // Black Stone (Deleted)
			Command.Find("ReplaceAll").Use(p, "250 331"); // Black Stone (Deleted)
			
			Command.Find("ReplaceAll").Use(p, "249 295"); // Concrete Slab-U
			Command.Find("ReplaceAll").Use(p, "248 294"); // Concrete
			Command.Find("ReplaceAll").Use(p, "247 260"); // Sandstone
			Command.Find("ReplaceAll").Use(p, "231 250"); // Diamond
			Command.Find("ReplaceAll").Use(p, "225 249"); // Coal
			Command.Find("ReplaceAll").Use(p, "179 248"); // Mossy Stone Brick
			Command.Find("ReplaceAll").Use(p, "234 247"); // Cobblestone slab-U
			Command.Find("ReplaceAll").Use(p, "223 246"); // Nub
			Command.Find("ReplaceAll").Use(p, "224 245"); // Boulder
			Command.Find("ReplaceAll").Use(p, "243 244"); // Diamond Ore
			Command.Find("ReplaceAll").Use(p, "244 243"); // Gold Ore
			Command.Find("ReplaceAll").Use(p, "245 242"); // Iron Ore
			Command.Find("ReplaceAll").Use(p, "246 241"); // Coal Ore
			Command.Find("ReplaceAll").Use(p, "235 229"); // Snow Block
			Command.Find("ReplaceAll").Use(p, "241 222"); // Pillar-NS
			Command.Find("ReplaceAll").Use(p, "242 221"); // Pillar-WE
			Command.Find("ReplaceAll").Use(p, "218 220"); // Thin Pillar-UD
			Command.Find("ReplaceAll").Use(p, "216 219"); // Thin Pillar-NS
			Command.Find("ReplaceAll").Use(p, "217 218"); // Thin Pillar-WE
			Command.Find("ReplaceAll").Use(p, "215 217"); // Glass Pane-NS
			Command.Find("ReplaceAll").Use(p, "214 216"); // Glass Pane-WE
			Command.Find("ReplaceAll").Use(p, "254 215"); // Rope-NS
			Command.Find("ReplaceAll").Use(p, "253 214"); // Rope-WE
			Command.Find("ReplaceAll").Use(p, "209 203"); // Kitchen Tile
			
			Command.Find("ReplaceAll").Use(p, "255 192"); // Aster
			Command.Find("ReplaceAll").Use(p, "205 185"); // Snowy Grass
			Command.Find("ReplaceAll").Use(p, "238 181"); // Wet Tall Grass
			Command.Find("ReplaceAll").Use(p, "239 179"); // Wet Grass
			Command.Find("ReplaceAll").Use(p, "240 178"); // Tall Grass
			Command.Find("ReplaceAll").Use(p, "198 160"); // Pine Leaves-slab-U
			
			Command.Find("ReplaceAll").Use(p, "199 159"); // Pine Leaves slab-D
			Command.Find("ReplaceAll").Use(p, "200 158"); // Pine Leaves
			Command.Find("ReplaceAll").Use(p, "203 157"); // Pine Log-UD
			Command.Find("ReplaceAll").Use(p, "202 156"); // Pine Log-NS
			Command.Find("ReplaceAll").Use(p, "201 155"); // Pine Log-WE
			Command.Find("ReplaceAll").Use(p, "204 154"); // Pine Gnarly
			Command.Find("ReplaceAll").Use(p, "221 153"); // Birch Leaves slab-U
			Command.Find("ReplaceAll").Use(p, "222 152"); // Birch Leaves slab-D
			Command.Find("ReplaceAll").Use(p, "226 151"); // Birch Leaves
			Command.Find("ReplaceAll").Use(p, "229 150"); // Birch Log-UD
			
			Command.Find("ReplaceAll").Use(p, "228 149"); // Birch Log-NS
			Command.Find("ReplaceAll").Use(p, "227 148"); // Birch Log-WE
			Command.Find("ReplaceAll").Use(p, "230 147"); // Birch Gnarly
			Command.Find("ReplaceAll").Use(p, "219 146"); // Leaves slab-U
			Command.Find("ReplaceAll").Use(p, "220 145"); // Leaves slab-D

			Command.Find("ReplaceAll").Use(p, "176 107"); // Pine Wood slab-U
			Command.Find("ReplaceAll").Use(p, "177 106"); // Pine Wood slab-D
			Command.Find("ReplaceAll").Use(p, "178 105"); // Pine Wood
			Command.Find("ReplaceAll").Use(p, "210 104"); // Birch Door-NS
			Command.Find("ReplaceAll").Use(p, "211 103"); // Birch Door-WE
			
			Command.Find("ReplaceAll").Use(p, "206 87"); // Birch Wood slab-U
			Command.Find("ReplaceAll").Use(p, "207 86"); // Birch Wood slab-D
			Command.Find("ReplaceAll").Use(p, "208 85"); // Birch Wood
			Command.Find("ReplaceAll").Use(p, "212 84"); // Oak Door-NS
			Command.Find("ReplaceAll").Use(p, "213 83"); // Oak Door-WE
			Command.Find("ReplaceAll").Use(p, "236 67"); // Oak Wood slab-U
			Command.Find("ReplaceAll").Use(p, "237 66"); // Oak Wood slab-D
			
			p.Message("%FConvertation Done! If script works the wrong way, report to Staff and use /undo 1m if you want to.");
			p.Message("%FNow you will probably edit the rest of the world because the script just can't normally replace the another blocks because it will change the important ones.");
			
		}
		
		public override void Help(Player p) {
			p.Message("%T/FixAlphaID");
			p.Message("%HConverts Your Alpha Blocks into Beta Blocks (Be careful using this command)");
		}
	}
	
}
