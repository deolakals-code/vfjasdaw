// Assembly: UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
public enum AnimationCullingType // TypeDefIndex: 17667
{
	// Fields
	public int value__; // 0x0
	public const AnimationCullingType AlwaysAnimate = 0;
	public const AnimationCullingType BasedOnRenderers = 1;
	[Obsolete("Enum member AnimatorCullingMode.BasedOnClipBounds has been deprecated. Use AnimationCullingType.AlwaysAnimate or AnimationCullingType.BasedOnRenderers instead")]
	public const AnimationCullingType BasedOnClipBounds = 2;
	[Obsolete("Enum member AnimatorCullingMode.BasedOnUserBounds has been deprecated. Use AnimationCullingType.AlwaysAnimate or AnimationCullingType.BasedOnRenderers instead")]
	public const AnimationCullingType BasedOnUserBounds = 3;
}
