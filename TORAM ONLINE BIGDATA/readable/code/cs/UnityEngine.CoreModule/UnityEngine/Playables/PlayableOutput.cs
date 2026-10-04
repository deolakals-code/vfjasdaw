// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
public struct PlayableOutput : IEquatable<PlayableOutput> // TypeDefIndex: 16658
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
	private static readonly PlayableOutput m_NullPlayableOutput; // 0x0

	// Methods

	[VisibleToOtherModules]
	// RVA: 0x37FD2C0 Offset: 0x37F92C0 VA: 0x37FD2C0
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x37FD2C8 Offset: 0x37F92C8 VA: 0x37FD2C8 Slot: 5
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x37FD2D4 Offset: 0x37F92D4 VA: 0x37FD2D4 Slot: 4
	public bool Equals(PlayableOutput other) { }

	// RVA: 0x37FD3F4 Offset: 0x37F93F4 VA: 0x37FD3F4
	private static void .cctor() { }
}
