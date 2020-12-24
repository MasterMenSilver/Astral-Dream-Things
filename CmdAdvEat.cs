
using System;
using MCGalaxy;
using MCGalaxy.Commands;
using MCGalaxy.DB;

// -------------------------- //
// Made by MasterMen for Astral Dream
// -------------------------- //
// Written in: 2020.11.15
// Last Update: 2020.12.24
// -------------------------- //

namespace MCGalaxy {

	public class CmdAdvEat : Command2 {
		public override string name { get { return "AdvEat"; } }
		//public override string shortcut { get { return "aeat"; } }
		public override string type { get { return "other"; } }
		public override bool museumUsable { get { return true; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Banned; } }
		
		public override void Use(Player p, string message, CommandData data) {
			
			bool send = false;
			
			if (message == "") {
				Help(p); return;
				send = false;
			}
			else if (message == "Bread" || message == "bread") {
				message = "%7took a slice of %~bread%7.";
				send = true;
			}
			else if (message == "Grape" || message == "grape") {
				message = "%7guzzled a %]grape%7.";
				send = true;
			}
			else if (message == "Cherry" || message == "cherry") {
				message = "%7chewed a %mcherry%7.";
				send = true;
			}
			else if (message == "Avocado" || message == "avocado") {
				message = "%7ate an %2avocado%7/";
				send = true;
			}
			else if (message == "Burger" || message == "burger") {
				message = "%7consumed a %ob%au%~rg%ae%or%7.";
				send = true;
			}
			else if (message == "Doritos" || message == "doritos") {
				message = "%7took some %m[%odoritos%m]%7.";
				send = true;
			}
			else if (message == "Something" || message == "something") {
				message = "%7consumed %esomething %7you don't know ;)";
				send = true;
			}
			else if (message == "Jam" || message == "jam") {
				message = "%7ate and drank and licked all the %4raspberry jam %7in a jar%7.";
				send = true;
			}
			else if (message == "Sausage" || message == "sausage") {
				message = "%7ate a cooked %~s%4a%~u%4s%~a%4g%~e%7 and enjoyed it.";
				send = true;
			}
			else if (message == "Paper" || message == "paper") {
				message = "%7crumpled and chewed a piece of %fpaper%7.";
				send = true;
			} else { send = false; }
			
			if (send == true)
				Chat.MessageGlobal("{0}%7 {1}", p.ColoredName, message);
		}
		// This one controls what happens when you use /Help [commandname].
		public override void Help(Player p) {
			p.Message("&e/AdvEat <food>");
			p.Message("&eMakes you eat something exact.");
		}
	}

	public class CmdDrink : Command2 {
		public override string name { get { return "Drink"; } }
		//public override string shortcut { get { return "drn"; } }
		public override string type { get { return "other"; } }
		public override bool museumUsable { get { return true; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Banned; } }
		
		public override void Use(Player p, string message, CommandData data) {
			
			bool send = false;
			
			if (message == "") {
				Help(p); return;
				send = false;
			}
			else if (message == "Water" || message == "water") {
				message = "%7drank some %bwater%7. Good thinking!";
				send = true;
			}
			else if (message == "Mountain Dew" || message == "mountain dew") {
				message = "%7drank a %aMountain Dew%f.";
				send = true;
			}
			else if (message == "Milk Tea" || message == "milk tea") {
				message = "&f%fdrinking a &7Milk &xTea&f.";
				send = true;
			}
			else if (message == "Pennyroyal Tea" || message == "pennyroyal tea") {
				message = "%fsit and drink &uPennyroyal Tea...";
				send = true;
			}
			else if (message == "Coffee" || message == "coffee") {
				message = "%7just drank a &sCoffee&f. &e:lightning: Energizing!!!%7.";
				send = true;
			} else { send = false; }
			
			if (send == true)
				Chat.MessageGlobal("{0}%7 {1}", p.ColoredName, message);
		}
		// This one controls what happens when you use /Help [commandname].
		public override void Help(Player p) {
			p.Message("&e/Drink <drinking>");
			p.Message("&eMakes you drink something exact.");
		}
	}
}
