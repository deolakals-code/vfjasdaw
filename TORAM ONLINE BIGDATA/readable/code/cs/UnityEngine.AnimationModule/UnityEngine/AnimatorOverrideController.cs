// Assembly: UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[DefaultMember("Item")]
[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
[UsedByNativeCode]
public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 17679
{
	// Fields
	internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Methods

	[RequiredByNativeCode]
	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x37C89EC Offset: 0x37C49EC VA: 0x37C89EC
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }
}
