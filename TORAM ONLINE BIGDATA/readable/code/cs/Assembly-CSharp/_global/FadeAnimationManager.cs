// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FadeAnimationManager : MonoBehaviour // TypeDefIndex: 568
{
	// Fields
	private float fadeTime; // 0x20
	private IEnumerator saveCoroutine; // 0x28
	[CompilerGenerated]
	private float <StartAlpha>k__BackingField; // 0x30
	[CompilerGenerated]
	private FadeAnimationManager.FadeMode <Mode>k__BackingField; // 0x34
	[SerializeField]
	private bool enableDistFade; // 0x38
	private List<Renderer> allRenderer; // 0x40
	private float currentAlpha; // 0x48
	private Transform camTransform; // 0x50
	private Transform objTransform; // 0x58

	// Properties
	public float StartAlpha { get; set; }
	public FadeAnimationManager.FadeMode Mode { get; set; }
	public float FadeTime { get; set; }
	public bool EnableDistFade { get; set; }
	public float CurrentAlpha { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18FF2F4 Offset: 0x18FB2F4 VA: 0x18FF2F4
	public float get_StartAlpha() { }

	[CompilerGenerated]
	// RVA: 0x18FF2FC Offset: 0x18FB2FC VA: 0x18FF2FC
	public void set_StartAlpha(float value) { }

	[CompilerGenerated]
	// RVA: 0x18FF304 Offset: 0x18FB304 VA: 0x18FF304
	public FadeAnimationManager.FadeMode get_Mode() { }

	[CompilerGenerated]
	// RVA: 0x18FF30C Offset: 0x18FB30C VA: 0x18FF30C
	private void set_Mode(FadeAnimationManager.FadeMode value) { }

	// RVA: 0x18FF314 Offset: 0x18FB314 VA: 0x18FF314
	public float get_FadeTime() { }

	// RVA: 0x18FF31C Offset: 0x18FB31C VA: 0x18FF31C
	public void set_FadeTime(float value) { }

	// RVA: 0x18FF32C Offset: 0x18FB32C VA: 0x18FF32C
	public bool get_EnableDistFade() { }

	// RVA: 0x18FF334 Offset: 0x18FB334 VA: 0x18FF334
	public void set_EnableDistFade(bool value) { }

	// RVA: 0x18FF340 Offset: 0x18FB340 VA: 0x18FF340
	public float get_CurrentAlpha() { }

	// RVA: 0x18FF348 Offset: 0x18FB348 VA: 0x18FF348
	private void Awake() { }

	// RVA: 0x18FF39C Offset: 0x18FB39C VA: 0x18FF39C
	private void Start() { }

	// RVA: 0x18FF7DC Offset: 0x18FB7DC VA: 0x18FF7DC
	private void OnEnable() { }

	// RVA: 0x18FF7F0 Offset: 0x18FB7F0 VA: 0x18FF7F0
	private void Update() { }

	// RVA: 0x18FF930 Offset: 0x18FB930 VA: 0x18FF930
	public void StartFadeAnimation(FadeAnimationManager.FadeMode mode) { }

	// RVA: 0x18FF938 Offset: 0x18FB938 VA: 0x18FF938
	public void StartFadeAnimation(FadeAnimationManager.FadeMode mode, Action endCallback) { }

	// RVA: 0x18FF3A4 Offset: 0x18FB3A4 VA: 0x18FF3A4
	public void SetAllMaterialAlpha(float alpha) { }

	// RVA: 0x18FFAF8 Offset: 0x18FBAF8 VA: 0x18FFAF8
	public void ForceFadeAnimation() { }

	[IteratorStateMachine(typeof(FadeAnimationManager.<FadeInProc>d__32))]
	// RVA: 0x18FF9C8 Offset: 0x18FB9C8 VA: 0x18FF9C8
	private IEnumerator FadeInProc(float time, Action endAction) { }

	[IteratorStateMachine(typeof(FadeAnimationManager.<FadeOutProc>d__33))]
	// RVA: 0x18FFA60 Offset: 0x18FBA60 VA: 0x18FFA60
	private IEnumerator FadeOutProc(float time, Action endAction) { }

	// RVA: 0x18FFB5C Offset: 0x18FBB5C VA: 0x18FFB5C
	public void .ctor() { }
}
