using UnrealBuildTool;

public class IP_MainProjectServerTarget : TargetRules
{
	public IP_MainProjectServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("IP_MainProject");
	}
}
