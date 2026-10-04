// Assembly: UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[StaticAccessor("AnimationRemoveScalePlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
internal struct AnimationRemoveScalePlayable : IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 17695
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x37C9728 Offset: 0x37C5728 VA: 0x37C9728
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x37C9818 Offset: 0x37C5818 VA: 0x37C9818 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x37C9824 Offset: 0x37C5824 VA: 0x37C9824 Slot: 4
	public bool Equals(AnimationRemoveScalePlayable other) { }

	// RVA: 0x37C98D8 Offset: 0x37C58D8 VA: 0x37C98D8
	private static void .cctor() { }
}
