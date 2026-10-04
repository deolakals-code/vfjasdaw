// Assembly: UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
[NativeType("Modules/Animation/AnimationClip.h")]
public sealed class AnimationClip : Motion // TypeDefIndex: 17673
{
	// Properties
	[NativeProperty("Length", False, 0)]
	public float length { get; }

	// Methods

	// RVA: 0x37C88DC Offset: 0x37C48DC VA: 0x37C88DC
	public void .ctor() { }

	[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
	// RVA: 0x37C8974 Offset: 0x37C4974 VA: 0x37C8974
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	// RVA: 0x37C89B0 Offset: 0x37C49B0 VA: 0x37C89B0
	public float get_length() { }
}
