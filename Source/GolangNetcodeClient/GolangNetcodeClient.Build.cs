// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GolangNetcodeClient : ModuleRules
{
	public GolangNetcodeClient(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
