// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class U1811_10_DynamicTarget : TargetRules
{
	public U1811_10_DynamicTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "U1811_10_Dynamic" } );
	}
}
