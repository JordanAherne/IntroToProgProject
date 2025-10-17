using UnrealBuildTool;

public class IP_MainProjectClientTarget : TargetRules
{
	public IP_MainProjectClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("IP_MainProject");
	}
}
