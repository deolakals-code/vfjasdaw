// Assembly: UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
[StaticAccessor("AnimatorControllerPlayableBindings", 2)]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
public struct AnimatorControllerPlayable : IEquatable<AnimatorControllerPlayable> // TypeDefIndex: 17698
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimatorControllerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x37C9BA8 Offset: 0x37C5BA8 VA: 0x37C9BA8
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x37C9D88 Offset: 0x37C5D88 VA: 0x37C9D88 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x37C9C44 Offset: 0x37C5C44 VA: 0x37C9C44
	public void SetHandle(PlayableHandle handle) { }

	// RVA: 0x37C9D94 Offset: 0x37C5D94 VA: 0x37C9D94 Slot: 4
	public bool Equals(AnimatorControllerPlayable other) { }

	// RVA: 0x37C9E30 Offset: 0x37C5E30 VA: 0x37C9E30
	private static void .cctor() { }
}
