// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Playables
[UsedByNativeCode]
[NativeHeader("Runtime/Export/Director/PlayableOutputHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle> // TypeDefIndex: 16659
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableOutputHandle m_Null; // 0x0

	// Properties
	public static PlayableOutputHandle Null { get; }

	// Methods

	// RVA: 0x37FD464 Offset: 0x37F9464 VA: 0x37FD464
	public static PlayableOutputHandle get_Null() { }

	// RVA: 0x37FD4BC Offset: 0x37F94BC VA: 0x37FD4BC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37FD36C Offset: 0x37F936C VA: 0x37FD36C
	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x37FD524 Offset: 0x37F9524 VA: 0x37FD524 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x37FD5CC Offset: 0x37F95CC VA: 0x37FD5CC Slot: 4
	public bool Equals(PlayableOutputHandle other) { }

	// RVA: 0x37FD4F0 Offset: 0x37F94F0 VA: 0x37FD4F0
	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x37FD64C Offset: 0x37F964C VA: 0x37FD64C
	private static void .cctor() { }
}
