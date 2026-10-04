// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Experimental.Rendering
[NativeHeader("Runtime/Camera/ScriptableRuntimeReflectionSystem.h")]
[RequiredByNativeCode]
public static class ScriptableRuntimeReflectionSystemSettings // TypeDefIndex: 16685
{
	// Fields
	private static ScriptableRuntimeReflectionSystemWrapper s_Instance; // 0x0

	// Properties
	private static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system { set; }
	private static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x37FF8D4 Offset: 0x37FB8D4 VA: 0x37FF8D4
	private static void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(IScriptableRuntimeReflectionSystem value) { }

	[RequiredByNativeCode]
	// RVA: 0x37FFA20 Offset: 0x37FBA20 VA: 0x37FFA20
	private static ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance() { }

	[RuntimeInitializeOnLoadMethod(0)]
	[StaticAccessor("ScriptableRuntimeReflectionSystem", 2)]
	// RVA: 0x37FFA78 Offset: 0x37FBA78 VA: 0x37FFA78
	private static void ScriptingDirtyReflectionSystemInstance() { }

	// RVA: 0x37FFAA0 Offset: 0x37FBAA0 VA: 0x37FFAA0
	private static void .cctor() { }
}
