using UnrealBuildTool;

public class IP_MainProjectTarget : TargetRules
{
	public IP_MainProjectTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("IP_MainProject");
	}
}
