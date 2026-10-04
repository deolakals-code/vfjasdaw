// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldScriptMonitor : MonoBehaviour // TypeDefIndex: 4811
{
	// Fields
	private float currentAlpha; // 0x20
	private float moveAlpha; // 0x24
	private Vector4 currentSlide; // 0x28
	private Vector2 moveSlide; // 0x38
	private float currentTimer; // 0x40
	[CompilerGenerated]
	private bool <IsEffectPlay>k__BackingField; // 0x44
	private readonly Color[] colorPallet; // 0x48
	private int colorPalletId; // 0x50
	private Action<float> monitorAction; // 0x58
	private MeshRenderer meshRenderer; // 0x60
	private Shader slideShader; // 0x68
	private Shader fadeShader; // 0x70
	private const int fadeQueue = 6001;
	private const int fadeMaskQueue = 6000;

	// Properties
	public bool IsEffectPlay { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x25B020C Offset: 0x25AC20C VA: 0x25B020C
	private void set_IsEffectPlay(bool value) { }

	[CompilerGenerated]
	// RVA: 0x25B0218 Offset: 0x25AC218 VA: 0x25B0218
	public bool get_IsEffectPlay() { }

	// RVA: 0x25B0220 Offset: 0x25AC220 VA: 0x25B0220
	public void SetColor(int id) { }

	// RVA: 0x25B03AC Offset: 0x25AC3AC VA: 0x25B03AC
	public void SetColorEx(int id) { }

	// RVA: 0x25B05F0 Offset: 0x25AC5F0 VA: 0x25B05F0
	public void SetShader(Shader shader) { }

	// RVA: 0x25B0720 Offset: 0x25AC720 VA: 0x25B0720
	private void Awake() { }

	// RVA: 0x25B085C Offset: 0x25AC85C VA: 0x25B085C
	private void LateUpdate() { }

	// RVA: 0x25B0948 Offset: 0x25AC948 VA: 0x25B0948
	public void MonitorSlideEffect(byte move, byte colorId, float time) { }

	// RVA: 0x25B0ADC Offset: 0x25ACADC VA: 0x25B0ADC
	private void MonitorSlideAction(float time) { }

	// RVA: 0x25B0BDC Offset: 0x25ACBDC VA: 0x25B0BDC
	public void MonitorFlashEffect(byte startAlpha, short addAlpha, byte colorId) { }

	// RVA: 0x25B0DC8 Offset: 0x25ACDC8 VA: 0x25B0DC8
	private void MonitorAlphaAction(float time) { }

	// RVA: 0x25B0EC4 Offset: 0x25ACEC4 VA: 0x25B0EC4
	private void MonitorMaskAction(byte mask) { }

	// RVA: 0x25B0F98 Offset: 0x25ACF98 VA: 0x25B0F98
	public void MonitorFadeEffect(short time, byte alpha, byte colorId) { }

	// RVA: 0x25B10D0 Offset: 0x25AD0D0 VA: 0x25B10D0
	public void MonitorMaskEffect(byte alpha, byte mask, byte colorId) { }

	// RVA: 0x25B0D00 Offset: 0x25ACD00 VA: 0x25B0D00
	private void SetQueue(int queue) { }

	// RVA: 0x25B1160 Offset: 0x25AD160 VA: 0x25B1160
	public void .ctor() { }
}
