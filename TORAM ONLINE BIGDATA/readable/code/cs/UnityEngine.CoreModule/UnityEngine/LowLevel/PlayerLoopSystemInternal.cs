// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.LowLevel
[NativeType(Header = "Runtime/Misc/PlayerLoop.h")]
[MovedFrom("UnityEngine.Experimental.LowLevel")]
[RequiredByNativeCode]
internal struct PlayerLoopSystemInternal // TypeDefIndex: 16447
{
	// Fields
	public Type type; // 0x0
	public PlayerLoopSystem.UpdateFunction updateDelegate; // 0x8
	public IntPtr updateFunction; // 0x10
	public IntPtr loopConditionFunction; // 0x18
	public int numSubSystems; // 0x20
}
