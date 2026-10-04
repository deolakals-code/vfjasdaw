// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRhythmGameTimer : MonoBehaviour // TypeDefIndex: 6233
{
	// Fields
	[SerializeField]
	private UIGLWidget[] uiWidget; // 0x20
	[CompilerGenerated]
	private bool <IsStart>k__BackingField; // 0x28
	private UIGLSpriteSliced barSprite; // 0x30
	private UIGLSpriteSliced barBackSprite; // 0x38
	private UIGLLabel timeSecondLabel; // 0x40
	private UIGLLabel timerTitleLabel; // 0x48
	private UIGLLabel timerDotLabel; // 0x50
	private UIGLLabel timerMilliLabel; // 0x58
	private float attackTimer; // 0x60
	private float attackTime; // 0x64
	private float enabledTimer; // 0x68
	private Color barColor; // 0x6C
	private string attackTimeText; // 0x80
	private SystemTextManager systemTextManager; // 0x88
	private int prevSecond; // 0x90
	private string[] cacheTextList; // 0x98

	// Properties
	public bool IsStart { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18C17C0 Offset: 0x18BD7C0 VA: 0x18C17C0
	public bool get_IsStart() { }

	[CompilerGenerated]
	// RVA: 0x18C17C8 Offset: 0x18BD7C8 VA: 0x18C17C8
	private void set_IsStart(bool value) { }

	// RVA: 0x18C17D4 Offset: 0x18BD7D4 VA: 0x18C17D4
	private void Start() { }

	// RVA: 0x18C1DD0 Offset: 0x18BDDD0 VA: 0x18C1DD0
	private void Update() { }

	// RVA: 0x18C20E4 Offset: 0x18BE0E4 VA: 0x18C20E4
	public void SetGLPanel(UIGLPanel glPanel) { }

	// RVA: 0x18C21D8 Offset: 0x18BE1D8 VA: 0x18C21D8
	public void SetTimer(float timer) { }

	// RVA: 0x18C255C Offset: 0x18BE55C VA: 0x18C255C
	public void StartTimer() { }

	// RVA: 0x18C2568 Offset: 0x18BE568 VA: 0x18C2568
	public void StopTimer() { }

	// RVA: 0x18C1E28 Offset: 0x18BDE28 VA: 0x18C1E28
	private void UpdateTimer() { }

	// RVA: 0x18C2570 Offset: 0x18BE570 VA: 0x18C2570
	public void .ctor() { }
}
