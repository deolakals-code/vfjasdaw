// Assembly: UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[StaticAccessor("AnimationLayerMixerPlayableBindings", 2)]
public struct AnimationLayerMixerPlayable : IEquatable<AnimationLayerMixerPlayable> // TypeDefIndex: 17689
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x37C8B50 Offset: 0x37C4B50 VA: 0x37C8B50
	internal void .ctor(PlayableHandle handle, bool singleLayerOptimization = True) { }

	// RVA: 0x37C8CE0 Offset: 0x37C4CE0 VA: 0x37C8CE0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x37C8CEC Offset: 0x37C4CEC VA: 0x37C8CEC Slot: 4
	public bool Equals(AnimationLayerMixerPlayable other) { }

	[NativeThrows]
	// RVA: 0x37C8C9C Offset: 0x37C4C9C VA: 0x37C8C9C
	private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value) { }

	// RVA: 0x37C8D88 Offset: 0x37C4D88 VA: 0x37C8D88
	private static void .cctor() { }
}
