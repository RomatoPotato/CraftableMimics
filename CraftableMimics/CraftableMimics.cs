using Terraria.ModLoader;

namespace CraftableMimics
{
	class CraftableMimics : Mod
	{
		public CraftableMimics()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
