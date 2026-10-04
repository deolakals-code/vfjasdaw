// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
public sealed class ReflectionProbe : Behaviour // TypeDefIndex: 16221
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged; // 0x0
	private static Dictionary<int, Action<Texture>> registeredDefaultReflectionSetActions; // 0x8
	private static List<Action<Texture>> registeredDefaultReflectionTextureActions; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x37CF6C4 Offset: 0x37CB6C4 VA: 0x37CF6C4
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent) { }

	[RequiredByNativeCode]
	// RVA: 0x37CF754 Offset: 0x37CB754 VA: 0x37CF754
	private static void CallSetDefaultReflection(Texture defaultReflectionCubemap) { }

	// RVA: 0x37CF8D8 Offset: 0x37CB8D8 VA: 0x37CF8D8
	private static void .cctor() { }
}
