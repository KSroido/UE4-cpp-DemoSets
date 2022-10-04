// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class cppDemoSet : ModuleRules
{
	public cppDemoSet(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
