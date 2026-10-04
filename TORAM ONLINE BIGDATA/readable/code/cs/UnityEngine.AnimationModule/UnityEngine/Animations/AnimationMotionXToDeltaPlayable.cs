// Assembly: UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
[StaticAccessor("AnimationMotionXToDeltaPlayableBindings", 2)]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationMotionXToDeltaPlayable.bindings.h")]
[RequiredByNativeCode]
internal struct AnimationMotionXToDeltaPlayable : IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 17691
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x37C905C Offset: 0x37C505C VA: 0x37C905C
	private void .ctor(PlayableHandle handle) { }

	// RVA: 0x37C914C Offset: 0x37C514C VA: 0x37C914C Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x37C9158 Offset: 0x37C5158 VA: 0x37C9158 Slot: 4
	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x37C91F4 Offset: 0x37C51F4 VA: 0x37C91F4
	private static void .cctor() { }
}
