// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
public struct Playable : IEquatable<Playable> // TypeDefIndex: 16651
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly Playable m_NullPlayable; // 0x0

	// Properties
	public static Playable Null { get; }

	// Methods

	// RVA: 0x37FCA18 Offset: 0x37F8A18 VA: 0x37FCA18
	public static Playable get_Null() { }

	[VisibleToOtherModules]
	// RVA: 0x37FCA70 Offset: 0x37F8A70 VA: 0x37FCA70
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x37FCA78 Offset: 0x37F8A78 VA: 0x37FCA78 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x37FCA84 Offset: 0x37F8A84 VA: 0x37FCA84 Slot: 4
	public bool Equals(Playable other) { }

	// RVA: 0x37FCBA4 Offset: 0x37F8BA4 VA: 0x37FCBA4
	private static void .cctor() { }
}
