// Assembly: UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[StaticAccessor("AnimationPosePlayableBindings", 2)]
[NativeHeader("Modules/Animation/Director/AnimationPosePlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPosePlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
internal struct AnimationPosePlayable : IEquatable<AnimationPosePlayable> // TypeDefIndex: 17694
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationPosePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x37C94DC Offset: 0x37C54DC VA: 0x37C94DC
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x37C95CC Offset: 0x37C55CC VA: 0x37C95CC Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x37C95D8 Offset: 0x37C55D8 VA: 0x37C95D8 Slot: 4
	public bool Equals(AnimationPosePlayable other) { }

	// RVA: 0x37C968C Offset: 0x37C568C VA: 0x37C968C
	private static void .cctor() { }
}
