using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Compound
{
	class Compound : Mod
	{
		public Compound()
		{
		}
		
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Dungeon Brick", new int[]
			{
				ItemID.GreenBrick,
				ItemID.BlueBrick,
				ItemID.PinkBrick
			});
			RecipeGroup.RegisterGroup("Compound:Dungeon", group);
			
			RecipeGroup group2 = new RecipeGroup(() => Lang.misc[37] + " Quest Fish", new int[]
			{
				ItemID.AmanitiaFungifin,
				ItemID.Angelfish,
				ItemID.Batfish,
				ItemID.BloodyManowar,
				ItemID.Bonefish,
				ItemID.BumblebeeTuna,
				ItemID.Bunnyfish,
				ItemID.CapnTunabeard,
				ItemID.Catfish,
				ItemID.Cloudfish,
				ItemID.Clownfish,
				ItemID.Cursedfish,
				ItemID.DemonicHellfish,
				ItemID.Derpfish,
				ItemID.Dirtfish,
				ItemID.DynamiteFish,
				ItemID.EaterofPlankton,
				ItemID.FallenStarfish,
				ItemID.TheFishofCthulu,
				ItemID.Fishotron,
				ItemID.Fishron,
				ItemID.GuideVoodooFish,
				ItemID.Harpyfish,
				ItemID.InfectedScabbardfish,
				ItemID.Jewelfish,
				ItemID.MirageFish,
				ItemID.Mudfish,
				ItemID.MutantFlinxfin,
				ItemID.Pengfish,
				ItemID.Pixiefish,
				ItemID.Slimefish,
				ItemID.Spiderfish,
				ItemID.TropicalBarracuda,
				ItemID.TundraTrout,
				ItemID.UnicornFish,
				ItemID.Wyverntail,
				ItemID.ZombieFish
			});
			RecipeGroup.RegisterGroup("Compound:Fishing", group2);
			
			RecipeGroup group3 = new RecipeGroup(() => Lang.misc[37] + " Common Mimic Drop", new int[]
			{
				ItemID.DualHook,
				ItemID.MagicDagger,
				ItemID.TitanGlove,
				ItemID.PhilosophersStone,
				ItemID.CrossNecklace,
				ItemID.StarCloak
			});
			RecipeGroup.RegisterGroup("Compound:NMimic", group3);
			
			RecipeGroup group4 = new RecipeGroup(() => Lang.misc[37] + " Ice Mimic Drops", new int[]
			{
				ItemID.Frostbrand,
				ItemID.IceBow,
				ItemID.FlowerofFrost
			});
			RecipeGroup.RegisterGroup("Compound:IMimic", group4);
			
			RecipeGroup group5 = new RecipeGroup(() => Lang.misc[37] + " Corrupt Mimic Drops", new int[]
			{
				ItemID.DartRifle,
				ItemID.WormHook,
				ItemID.ChainGuillotines,
				ItemID.ClingerStaff,
				ItemID.PutridScent
			});
			RecipeGroup.RegisterGroup("Compound:CoMimic", group5);
			
			RecipeGroup group6 = new RecipeGroup(() => Lang.misc[37] + " Crimson Mimic Drops", new int[]
			{
				ItemID.SoulDrain,
				ItemID.DartPistol,
				ItemID.FetidBaghnakhs,
				ItemID.FleshKnuckles,
				ItemID.TendonHook
			});
			RecipeGroup.RegisterGroup("Compound:CrMimic", group6);
			
			RecipeGroup group7 = new RecipeGroup(() => Lang.misc[37] + " Hallow Mimic Drops", new int[]
			{
				ItemID.DaedalusStormbow,
				ItemID.FlyingKnife,
				ItemID.CrystalVileShard,
				ItemID.IlluminantHook
			});
			RecipeGroup.RegisterGroup("Compound:HMimic", group7);
			
			RecipeGroup group8 = new RecipeGroup(() => Lang.misc[37] + " Martian Saucer Loot", new int[]
			{
				ItemID.Xenopopper,
				ItemID.XenoStaff,
				ItemID.LaserMachinegun,
				ItemID.ElectrosphereLauncher,
				ItemID.ChargedBlasterCannon,
				ItemID.InfluxWaver,
				ItemID.CosmicCarKey,
				ItemID.AntiGravityHook,
				ItemID.MartianSaucerTrophy
			});
			RecipeGroup.RegisterGroup("Compound:MartianS", group8);
			
			RecipeGroup group9 = new RecipeGroup(() => Lang.misc[37] + " Betsy Drop", new int[]
			{
				ItemID.DD2BetsyBow,
				ItemID.MonkStaffT3,
				ItemID.ApprenticeStaffT3,
				ItemID.DD2SquireBetsySword,
				ItemID.BetsyWings
			});
			RecipeGroup.RegisterGroup("Compound:Betsy", group9);
			
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Wood);
			recipe.anyWood = true;
			recipe.AddIngredient(ItemID.SnowBlock,2);
			recipe.SetResult(ItemID.BorealWood);
			recipe.AddRecipe();
			//Wood to Boreal
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Wood);
			recipe.anyWood = true;
			recipe.AddIngredient(ItemID.SandBlock,2);
			recipe.SetResult(ItemID.PalmWood);
			recipe.AddRecipe();
			//Wood to Palm
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Wood);
			recipe.anyWood = true;
			recipe.AddIngredient(ItemID.MudBlock,2);
			recipe.SetResult(ItemID.RichMahogany);
			recipe.AddRecipe();
			//Wood to Rich Mahogany
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Wood);
			recipe.anyWood = true;
			recipe.AddIngredient(ItemID.EbonstoneBlock,2);
			recipe.SetResult(ItemID.Ebonwood);
			recipe.AddRecipe();
			//Wood to Corruption
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Wood);
			recipe.anyWood = true;
			recipe.AddIngredient(ItemID.CrimstoneBlock, 2);
			recipe.SetResult(ItemID.Shadewood);
			recipe.AddRecipe();
			//Wood to Crimson
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Wood);
			recipe.anyWood = true;
			recipe.AddIngredient(ItemID.PearlstoneBlock,2);
			recipe.SetResult(ItemID.Pearlwood);
			recipe.AddRecipe();
			//Wood to Hallow
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Wood);
			recipe.anyWood = true;
			recipe.AddIngredient(ItemID.DirtBlock,2);
			recipe.SetResult(ItemID.Wood);
			recipe.AddRecipe();
			//Wood to Wood
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.RainCloud);
			recipe.AddTile(17);
			recipe.SetResult(ItemID.Cloud);
			recipe.AddRecipe();
			//Rain Cloud to Cloud
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Silk);
			recipe.SetResult(ItemID.Cobweb,7);
			recipe.AddRecipe();
			//Silk to Web
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ActiveStoneBlock);
			recipe.AddIngredient(ItemID.PoisonDart,100);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.DartTrap);
			recipe.AddRecipe();
			//Dart Trap Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.LihzahrdBrick);
			recipe.AddIngredient(ItemID.PoisonDart,100);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SuperDartTrap);
			recipe.AddRecipe();
			//Super Dart Trap Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.LihzahrdBrick);
			recipe.AddIngredient(ItemID.Spear);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SpearTrap);
			recipe.AddRecipe();
			//Spear Trap Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.LihzahrdBrick);
			recipe.AddIngredient(ItemID.SpikyBall, 100);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SpikyBallTrap);
			recipe.AddRecipe();
			//Spiky Ball Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.LihzahrdBrick);
			recipe.AddIngredient(ItemID.MolotovCocktail,100);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FlameTrap);
			recipe.AddRecipe();
			//Flame Trap
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Sawmill);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(ItemID.Spike);
			recipe.AddRecipe();
			//Spike Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.anyWood = true;
			recipe.AddTile(TileID.Sawmill);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(ItemID.WoodenSpike);
			recipe.AddRecipe();
			//Wooden Spike Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Dynamite, 3);
			recipe.AddIngredient(ItemID.Cobweb);
			recipe.SetResult(ItemID.Explosives);
			recipe.AddRecipe();
			//Explosives Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Compound:Dungeon");
			recipe.AddIngredient(ItemID.BlueDye);
			recipe.SetResult(ItemID.BlueBrick);
			recipe.AddRecipe();
			//Green Brick to Blue Brick
			
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Compound:Dungeon");
			recipe.AddIngredient(ItemID.GreenDye);
			recipe.SetResult(ItemID.GreenBrick);
			recipe.AddRecipe();
			//Blue Brick to Green Brick
			
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Compound:Dungeon");
			recipe.AddIngredient(ItemID.PinkDye);
			recipe.SetResult(ItemID.PinkBrick);
			recipe.AddRecipe();
			//Green Brick to Pink Brick
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ZombieBanner);
			recipe.SetResult(ItemID.ZombieArm);
			recipe.AddRecipe();
			//ZombieBanner to ZombieArm
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.RaincoatZombieBanner);
			recipe.SetResult(ItemID.ZombieArm);
			recipe.AddRecipe();
			//RaincoatZombieBanner to ZombieArm
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ZombieEskimoBanner);
			recipe.SetResult(ItemID.ZombieArm);
			recipe.AddRecipe();
			//ZombieEskimoBanner to ZombieArm
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.WalkingAntlionBanner);
			recipe.SetResult(ItemID.AntlionClaw);
			recipe.AddRecipe();
			//WalkingAntlionBanner to Mandible Claw
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SkeletonBanner);
			recipe.SetResult(ItemID.BoneSword);
			recipe.AddRecipe();
			//SkeletonBanner to Bone Sword
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.RottenChunk,5);
			recipe.AddIngredient(ItemID.Rockfish);
			recipe.SetResult(ItemID.PurpleClubberfish);
			recipe.AddRecipe();
			//Purple Clubberfish Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.CandyCaneBlock,60);
			recipe.SetResult(ItemID.CandyCaneSword);
			recipe.AddRecipe();
			//CandyCaneSword Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.GreenCandyCaneBlock,60);
			recipe.SetResult(ItemID.CandyCaneSword);
			recipe.AddRecipe();
			//CandyCaneSword Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.FallenStar,20);
			recipe.AddIngredient(ItemID.ManaCrystal,2);
			recipe.AddIngredient(ItemID.PlatinumBroadsword);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Starfury);
			recipe.AddRecipe();
			//Starfury Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Vertebrae,5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Leather);
			recipe.AddRecipe();
			//Leather Crimson Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Leather,5);
			recipe.AddIngredient(ItemID.IronBar,5);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BladedGlove);
			recipe.AddRecipe();
			//Bladed Glove Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.DynastyWood, 100);
			recipe.AddIngredient(ItemID.IronBar,5);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Katana);
			recipe.AddRecipe();
			//Katana Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.GoldenKey);
			recipe.AddIngredient(ItemID.Katana);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Muramasa);
			recipe.AddRecipe();
			//Muramasa Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ReinforcedFishingPole);
			recipe.AddIngredient(ItemID.Bass, 25);
			recipe.AddIngredient(ItemID.SonarPotion, 5);
			recipe.AddIngredient(ItemID.PlatinumPickaxe, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ReaverShark);
			recipe.AddRecipe();
			//Reavershark Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ReinforcedFishingPole);
			recipe.AddIngredient(ItemID.Bass, 25);
			recipe.AddIngredient(ItemID.SonarPotion, 5);
			recipe.AddIngredient(ItemID.PlatinumAxe, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SawtoothShark);
			recipe.AddRecipe();
			//Sawtooth Shark Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Compound:MartianS");
			recipe.AddIngredient(ItemID.MartianConduitPlating, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LaserDrill);
			recipe.AddRecipe();
			//Laser Drill Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.BeetleHusk, 32);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.Picksaw);
			recipe.AddRecipe();
			//Picksaw Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.TempleKey, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.TheAxe);
			recipe.AddRecipe();
			//The Axe Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ButcherBanner);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ButchersChainsaw);
			recipe.AddRecipe();
			//Butcher's Chainsaw
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Bass, 15);
			recipe.AddIngredient(ItemID.ReinforcedFishingPole);
			recipe.AddIngredient(ItemID.SonarPotion);
			recipe.AddIngredient(ItemID.StoneBlock, 99);
			recipe.AddIngredient(ItemID.PlatinumHammer);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Rockfish);
			recipe.AddRecipe();
			//Rockfish Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Cobweb, 90);
			recipe.AddIngredient(ItemID.IronBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.WebSlinger);
			recipe.AddRecipe();
			//Web Slinger Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SlimeBlock, 100);
			recipe.AddIngredient(ItemID.Solidifier);
			recipe.AddTile(TileID.Solidifier);
			recipe.SetResult(ItemID.SlimeHook);
			recipe.AddRecipe();
			//Slime Hook Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Bone, 100);
			recipe.AddTile(TileID.BoneWelder);
			recipe.SetResult(ItemID.SkeletronHand);
			recipe.AddRecipe();
			//SkeletronHand Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Compound:Fishing", 10);
			recipe.AddIngredient(ItemID.Bass, 20);
			recipe.AddIngredient(ItemID.SonarPotion, 10);
			recipe.SetResult(ItemID.FishHook);
			recipe.AddRecipe();
			//FishHook Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.TempleKey, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ThornHook);
			recipe.AddRecipe();
			//ThornHook Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Compound:NMimic");
			recipe.AddIngredient(ItemID.GoldCoin, 10);
			recipe.SetResult(ItemID.DualHook);
			recipe.AddRecipe();
			//DualHook Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Compound:CoMimic");
			recipe.AddIngredient(ItemID.GoldCoin, 3);
			recipe.SetResult(ItemID.WormHook);
			recipe.AddRecipe();
			//WormHook Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Compound:CrMimic");
			recipe.AddIngredient(ItemID.GoldCoin, 3);
			recipe.SetResult(ItemID.TendonHook);
			recipe.AddRecipe();
			//TendonHook Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Compound:HMimic");
			recipe.AddIngredient(ItemID.GoldCoin, 3);
			recipe.SetResult(ItemID.IlluminantHook);
			recipe.AddRecipe();
			//IlluminantHook Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Compound:MartianS");
			recipe.AddIngredient(ItemID.MartianConduitPlating, 25);
			recipe.SetResult(ItemID.AntiGravityHook);
			recipe.AddRecipe();
			//AntiGravityHook Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Compound:Fishing", 15);
			recipe.AddIngredient(ItemID.Bass, 20);
			recipe.AddIngredient(ItemID.SonarPotion, 10);
			recipe.SetResult(ItemID.HotlineFishingHook);
			recipe.AddRecipe();
			//HotlineFishingHook Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.RecallPotion, 120);
			recipe.AddIngredient(ItemID.Glass, 10);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(ItemID.MagicMirror);
			recipe.AddRecipe();
			//MagicMirror Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.RecallPotion, 120);
			recipe.AddIngredient(ItemID.Glass, 10);
			recipe.AddIngredient(ItemID.IceBlock, 5);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(ItemID.IceMirror);
			recipe.AddRecipe();
			//IceMirror Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.IronBar, 8);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.Cobweb, 24);
			recipe.AddTile(TileID.Anvils);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.BugNet);
			recipe.AddRecipe();
			//BugNet Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Compound:Fishing", 18);
			recipe.AddIngredient(ItemID.Bass, 20);
			recipe.AddIngredient(ItemID.SonarPotion, 12);
			recipe.SetResult(ItemID.GoldenBugNet);
			recipe.AddRecipe();
			//GoldenBugNet Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.BeeWax, 78);
			recipe.SetResult(ItemID.BeeKeeper);
			recipe.AddRecipe();
			//BeeKeeper Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ArmoredSkeletonBanner);
			recipe.SetResult(ItemID.BeamSword);
			recipe.AddRecipe();
			//BeamSword Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Compound:IMimic");
			recipe.AddIngredient(ItemID.GoldCoin, 10);
			recipe.SetResult(ItemID.Frostbrand);
			recipe.AddRecipe();
			//Frostbrand Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ReaperBanner);
			recipe.SetResult(ItemID.DeathSickle);
			recipe.AddRecipe();
			//DeathSickle Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Compound:CrMimic");
			recipe.AddIngredient(ItemID.GoldCoin, 3);
			recipe.SetResult(ItemID.FetidBaghnakhs);
			recipe.AddRecipe();
			//FetidBaghnakhs Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.BlueArmoredBonesBanner);
			recipe.SetResult(ItemID.Keybrand);
			recipe.AddRecipe();
			//Keybrand Recipe 1
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.HellArmoredBonesBanner);
			recipe.SetResult(ItemID.Keybrand);
			recipe.AddRecipe();
			//Keybrand Recipe 2
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.RustyArmoredBonesBanner);
			recipe.SetResult(ItemID.Keybrand);
			recipe.AddRecipe();
			//Keybrand Recipe 3
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.PsychoBanner);
			recipe.SetResult(ItemID.PsychoKnife);
			recipe.AddRecipe();
			//PsychoKnife Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.TempleKey, 4);
			recipe.SetResult(ItemID.Seedler);
			recipe.AddRecipe();
			//Seedler Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Compound:Betsy");
			recipe.SetResult(ItemID.DD2SquireBetsySword);
			recipe.AddRecipe();
			//FlyingDragon Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Compound:MartianS");
			recipe.SetResult(ItemID.InfluxWaver);
			recipe.AddRecipe();
			//InfluxWaver Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.PortalGun, 6);
			recipe.SetResult(ItemID.StarWrath);
			recipe.AddRecipe();
			//StarWrath Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.PortalGun, 6);
			recipe.SetResult(ItemID.Meowmere);
			recipe.AddRecipe();
			//Meowmere Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.IronBar, 15);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.WoodYoyo);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Rally);
			recipe.AddRecipe();
			//Rally Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.JungleYoyo);
			recipe.AddIngredient(ItemID.GoldenKey, 2);
			recipe.SetResult(ItemID.Valor);
			recipe.AddRecipe();
			//Valor Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.GuideVoodooDoll, 2);
			recipe.SetResult(ItemID.Cascade);
			recipe.AddRecipe();
			//Cascade Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Bone, 30);
			recipe.AddIngredient(ItemID.Code1);
			recipe.SetResult(ItemID.FormatC);
			recipe.AddRecipe();
			//Format:C Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Bone, 30);
			recipe.AddIngredient(ItemID.Code1);
			recipe.SetResult(ItemID.Gradient);
			recipe.AddRecipe();
			//Gradient Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Cascade);
			recipe.AddIngredient(ItemID.LivingFireBlock, 200);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(ItemID.HelFire);
			recipe.AddRecipe();
			//Hel-Fire Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.IceBlock, 20);
			recipe.AddIngredient(ItemID.PinkIceBlock, 20);
			recipe.AddIngredient(ItemID.FrostCore);
			recipe.SetResult(ItemID.Amarok);
			recipe.AddRecipe();
			//Amarok Recipe
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Code1);
			recipe.AddIngredient(ItemID.GoldCoin, 25);
			recipe.SetResult(ItemID.Code2);
			recipe.AddRecipe();
			//Code2 Recipe
			
			
		}
	}
}
