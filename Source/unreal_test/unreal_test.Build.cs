// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class unreal_test : ModuleRules
{
	public unreal_test(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"unreal_test",
			"unreal_test/Variant_Platforming",
			"unreal_test/Variant_Platforming/Animation",
			"unreal_test/Variant_Combat",
			"unreal_test/Variant_Combat/AI",
			"unreal_test/Variant_Combat/Animation",
			"unreal_test/Variant_Combat/Gameplay",
			"unreal_test/Variant_Combat/Interfaces",
			"unreal_test/Variant_Combat/UI",
			"unreal_test/Variant_SideScrolling",
			"unreal_test/Variant_SideScrolling/AI",
			"unreal_test/Variant_SideScrolling/Gameplay",
			"unreal_test/Variant_SideScrolling/Interfaces",
			"unreal_test/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
