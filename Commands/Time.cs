using Terraria;
using Terraria.ModLoader;

namespace UsefulCommands.Commands
{
	public class Time : ModCommand
	{
		public override CommandType Type => CommandType.Chat | CommandType.World;
		public override string Command => "time";
		public override string Usage => "/time <day/night>";
		public override string Description => "Sets the time.";

		public override void Action(CommandCaller caller, string input, string[] args)
		{
			if (args.Length > 0)
			{
				string name = string.Join(" ", args);
				if (name == "day")
				{
					Main.dayTime = true;
					Main.time = 27000.0;
					Main.NewText("SUCCESS: Time set to day!");
				}
				else if (name == "night")
				{
					Main.dayTime = false;
					Main.time = 0;
					Main.NewText("SUCCESS: Time set to night!");
				}
				else
				{
					Main.NewText("ERROR: You can only set the time to DAY or NIGHT!");
				}
			}
			else
			{
				Main.NewText("ERROR: You have not specified a time!");
			}
		}
	}
}