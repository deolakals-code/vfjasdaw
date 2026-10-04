// Assembly: UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
[StaticAccessor("AnimationOffsetPlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/Director/AnimationOffsetPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationOffsetPlayable.bindings.h")]
internal struct AnimationOffsetPlayable : IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 17692
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x37C9290 Offset: 0x37C5290 VA: 0x37C9290
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x37C9380 Offset: 0x37C5380 VA: 0x37C9380 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x37C938C Offset: 0x37C538C VA: 0x37C938C Slot: 4
	public bool Equals(AnimationOffsetPlayable other) { }

	// RVA: 0x37C9440 Offset: 0x37C5440 VA: 0x37C9440
	private static void .cctor() { }
}
