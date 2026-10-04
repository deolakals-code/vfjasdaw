// Assembly: UnityEngine.AnimationModule.dll
// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[StaticAccessor("AnimationScriptPlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
public struct AnimationScriptPlayable : IEquatable<AnimationScriptPlayable> // TypeDefIndex: 17696
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x37C9974 Offset: 0x37C5974 VA: 0x37C9974
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x37C9A64 Offset: 0x37C5A64 VA: 0x37C9A64 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x37C9A70 Offset: 0x37C5A70 VA: 0x37C9A70 Slot: 4
	public bool Equals(AnimationScriptPlayable other) { }

	// RVA: 0x37C9B0C Offset: 0x37C5B0C VA: 0x37C9B0C
	private static void .cctor() { }
}
