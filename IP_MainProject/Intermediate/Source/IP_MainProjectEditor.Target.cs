using UnrealBuildTool;

public class IP_MainProjectEditorTarget : TargetRules
{
	public IP_MainProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("IP_MainProject");
	}
}
