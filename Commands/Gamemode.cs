using Terraria;
using Terraria.ModLoader;

namespace UsefulCommands.Commands
{
	public class Gamemode : ModCommand
	{
		public override CommandType Type => CommandType.Chat | CommandType.World;
		public override string Command => "gamemode";
		public override string Usage => "/gamemode <expert/normal>";
		public override string Description => "Changes your gamemode.";

		public override void Action(CommandCaller caller, string input, string[] args)
		{
			if (args.Length > 0)
			{
				string name = string.Join(" ", args);
				if (name == "expert")
				{
					Main.expertMode = true;
					Main.NewText("SUCCESS: Expert Mode is now enabled!");
				}
				else if (name == "normal")
				{
					Main.expertMode = false;
					Main.NewText("SUCCESS: Expert Mode is now disabled!");
				}
				else
				{
					Main.NewText("ERROR: You need to use either normal or expert for the command arguments!");
				}
			}
			else
			{
				Main.NewText("ERROR: You have not specified a game mode!");
			}
		}
	}
}