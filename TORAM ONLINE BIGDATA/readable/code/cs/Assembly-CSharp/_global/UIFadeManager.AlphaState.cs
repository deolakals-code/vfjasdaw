// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFadeManager.AlphaState // TypeDefIndex: 8913
{
	// Fields
	public const float maxAlpha = 1;
	public const float minAlpha = 0;
	public const float defaultChangeValue = 0.5;
	private float changeValue; // 0x10
	private float timerChangeValue; // 0x14
	private float alpha; // 0x18
	private UIFadeManager.AlphaState.Fade fade; // 0x1C
	private List<UIWidget> widgetList; // 0x20
	private List<UIGLWidget> glWidgetList; // 0x28
	private float fadeOutTimer; // 0x30

	// Properties
	public float FadeOutTimer { get; }
	public UIFadeManager.AlphaState.Fade FadeState { get; set; }
	public float Alpha { get; set; }
	public float ChangeValue { get; set; }
	public float TimerChangeValue { get; set; }

	// Methods

	// RVA: 0x1E542A8 Offset: 0x1E502A8 VA: 0x1E542A8
	public float get_FadeOutTimer() { }

	// RVA: 0x1E542B0 Offset: 0x1E502B0 VA: 0x1E542B0
	public UIFadeManager.AlphaState.Fade get_FadeState() { }

	// RVA: 0x1E527B4 Offset: 0x1E4E7B4 VA: 0x1E527B4
	public void set_FadeState(UIFadeManager.AlphaState.Fade value) { }

	// RVA: 0x1E542B8 Offset: 0x1E502B8 VA: 0x1E542B8
	public float get_Alpha() { }

	// RVA: 0x1E527C4 Offset: 0x1E4E7C4 VA: 0x1E527C4
	public void set_Alpha(float value) { }

	// RVA: 0x1E542C0 Offset: 0x1E502C0 VA: 0x1E542C0
	public float get_ChangeValue() { }

	// RVA: 0x1E542C8 Offset: 0x1E502C8 VA: 0x1E542C8
	public void set_ChangeValue(float value) { }

	// RVA: 0x1E542D0 Offset: 0x1E502D0 VA: 0x1E542D0
	public float get_TimerChangeValue() { }

	// RVA: 0x1E542D8 Offset: 0x1E502D8 VA: 0x1E542D8
	public void set_TimerChangeValue(float value) { }

	// RVA: 0x1E53090 Offset: 0x1E4F090 VA: 0x1E53090
	public void .ctor(bool isFade) { }

	// RVA: 0x1E542E0 Offset: 0x1E502E0 VA: 0x1E542E0
	public void Reset(bool isFade) { }

	// RVA: 0x1E531A4 Offset: 0x1E4F1A4 VA: 0x1E531A4
	public void Add(UIWidget widget) { }

	// RVA: 0x1E5348C Offset: 0x1E4F48C VA: 0x1E5348C
	public void Add(UIGLWidget widget) { }

	// RVA: 0x1E53690 Offset: 0x1E4F690 VA: 0x1E53690
	public bool Remove(UIWidget widget) { }

	// RVA: 0x1E53798 Offset: 0x1E4F798 VA: 0x1E53798
	public bool Remove(UIGLWidget widget) { }

	// RVA: 0x1E52B44 Offset: 0x1E4EB44 VA: 0x1E52B44
	public void Update() { }

	// RVA: 0x1E53B3C Offset: 0x1E4FB3C VA: 0x1E53B3C
	public void StartFadeIn() { }

	// RVA: 0x1E53C34 Offset: 0x1E4FC34 VA: 0x1E53C34
	public void StartFadeOut() { }

	// RVA: 0x1E54304 Offset: 0x1E50304 VA: 0x1E54304
	public void StartFadeOutTimer(float timer) { }
}
