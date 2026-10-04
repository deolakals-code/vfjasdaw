// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ScreenFadeAnimationManager : MonoBehaviour // TypeDefIndex: 1551
{
	// Fields
	private float fadeTime; // 0x20
	[CompilerGenerated]
	private float <StartAlpha>k__BackingField; // 0x24
	[CompilerGenerated]
	private float <StartMask>k__BackingField; // 0x28
	[CompilerGenerated]
	private ScreenFadeAnimationManager.FadeMode <Mode>k__BackingField; // 0x2C
	private Renderer[] allRenderer; // 0x30
	private float currentAlpha; // 0x38
	private bool distAlphaFlag; // 0x3C
	[CompilerGenerated]
	private float <CurrentMask>k__BackingField; // 0x40

	// Properties
	public float StartAlpha { get; set; }
	public float StartMask { get; set; }
	public ScreenFadeAnimationManager.FadeMode Mode { get; set; }
	public float FadeTime { get; set; }
	public float CurrentAlpha { get; }
	public float CurrentMask { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20891A0 Offset: 0x20851A0 VA: 0x20891A0
	public float get_StartAlpha() { }

	[CompilerGenerated]
	// RVA: 0x20891A8 Offset: 0x20851A8 VA: 0x20891A8
	public void set_StartAlpha(float value) { }

	[CompilerGenerated]
	// RVA: 0x20891B0 Offset: 0x20851B0 VA: 0x20891B0
	public float get_StartMask() { }

	[CompilerGenerated]
	// RVA: 0x20891B8 Offset: 0x20851B8 VA: 0x20891B8
	public void set_StartMask(float value) { }

	[CompilerGenerated]
	// RVA: 0x20891C0 Offset: 0x20851C0 VA: 0x20891C0
	public ScreenFadeAnimationManager.FadeMode get_Mode() { }

	[CompilerGenerated]
	// RVA: 0x20891C8 Offset: 0x20851C8 VA: 0x20891C8
	private void set_Mode(ScreenFadeAnimationManager.FadeMode value) { }

	// RVA: 0x20891D0 Offset: 0x20851D0 VA: 0x20891D0
	public float get_FadeTime() { }

	// RVA: 0x20891D8 Offset: 0x20851D8 VA: 0x20891D8
	public void set_FadeTime(float value) { }

	// RVA: 0x20891E8 Offset: 0x20851E8 VA: 0x20891E8
	public float get_CurrentAlpha() { }

	[CompilerGenerated]
	// RVA: 0x20891F0 Offset: 0x20851F0 VA: 0x20891F0
	private void set_CurrentMask(float value) { }

	[CompilerGenerated]
	// RVA: 0x20891F8 Offset: 0x20851F8 VA: 0x20891F8
	public float get_CurrentMask() { }

	// RVA: 0x2089200 Offset: 0x2085200 VA: 0x2089200
	private void Awake() { }

	// RVA: 0x2089208 Offset: 0x2085208 VA: 0x2089208
	private void Start() { }

	// RVA: 0x2089488 Offset: 0x2085488 VA: 0x2089488
	public void StartFadeAnimation(ScreenFadeAnimationManager.FadeMode mode) { }

	// RVA: 0x2089490 Offset: 0x2085490 VA: 0x2089490
	public void StartFadeAnimation(ScreenFadeAnimationManager.FadeMode mode, Action endCallback) { }

	[IteratorStateMachine(typeof(ScreenFadeAnimationManager.<StartFadeInAnimation>d__30))]
	// RVA: 0x208959C Offset: 0x208559C VA: 0x208959C
	public IEnumerator StartFadeInAnimation(float toAlpha, bool isFadeIn) { }

	// RVA: 0x2089654 Offset: 0x2085654 VA: 0x2089654
	public void StartFadeZoomAnimation(float endMask, float timer, Action endCallback) { }

	// RVA: 0x208966C Offset: 0x208566C VA: 0x208966C
	public void StartFadeZoomAnimation(float startMask, float endMask, float timer, Action endCallback) { }

	// RVA: 0x2089790 Offset: 0x2085790 VA: 0x2089790
	public void SetAllMaterialAlpha(float alpha) { }

	// RVA: 0x2089210 Offset: 0x2085210 VA: 0x2089210
	private void SetAllMaterialAlpha(float alpha, float mask) { }

	[IteratorStateMachine(typeof(ScreenFadeAnimationManager.<FadeProc>d__35))]
	// RVA: 0x2089504 Offset: 0x2085504 VA: 0x2089504
	private IEnumerator FadeProc(float dAlpha, Action endAction) { }

	[IteratorStateMachine(typeof(ScreenFadeAnimationManager.<FadeZoomProc>d__36))]
	// RVA: 0x20896F0 Offset: 0x20856F0 VA: 0x20896F0
	private IEnumerator FadeZoomProc(float dMask, float time, Action endAction) { }

	// RVA: 0x20897E8 Offset: 0x20857E8 VA: 0x20897E8
	public void .ctor() { }
}
