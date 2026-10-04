// Assembly: UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
[StaticAccessor("AnimationMixerPlayableBindings", 2)]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
public struct AnimationMixerPlayable : IEquatable<AnimationMixerPlayable> // TypeDefIndex: 17690
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x37C8E28 Offset: 0x37C4E28 VA: 0x37C8E28
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x37C8F18 Offset: 0x37C4F18 VA: 0x37C8F18 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x37C8F24 Offset: 0x37C4F24 VA: 0x37C8F24 Slot: 4
	public bool Equals(AnimationMixerPlayable other) { }

	// RVA: 0x37C8FC0 Offset: 0x37C4FC0 VA: 0x37C8FC0
	private static void .cctor() { }
}
