// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Experimental.Rendering
[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
internal class BuiltinRuntimeReflectionSystem : IScriptableRuntimeReflectionSystem, IDisposable // TypeDefIndex: 16683
{
	// Methods

	// RVA: 0x37FF820 Offset: 0x37FB820 VA: 0x37FF820 Slot: 4
	public bool TickRealtimeProbes() { }

	// RVA: 0x37FF870 Offset: 0x37FB870 VA: 0x37FF870 Slot: 5
	public void Dispose() { }

	// RVA: 0x37FF874 Offset: 0x37FB874 VA: 0x37FF874
	private void Dispose(bool disposing) { }

	[StaticAccessor("GetReflectionProbes()", Type = 0)]
	// RVA: 0x37FF848 Offset: 0x37FB848 VA: 0x37FF848
	private static bool BuiltinUpdate() { }

	[RequiredByNativeCode]
	// RVA: 0x37FF878 Offset: 0x37FB878 VA: 0x37FF878
	private static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New() { }

	// RVA: 0x37FF8CC Offset: 0x37FB8CC VA: 0x37FF8CC
	public void .ctor() { }
}
