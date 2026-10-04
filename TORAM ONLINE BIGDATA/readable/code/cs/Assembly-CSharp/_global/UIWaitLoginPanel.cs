// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWaitLoginPanel : MonoBehaviour // TypeDefIndex: 9059
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[SerializeField]
	private GameObject mainPanel; // 0x28
	[SerializeField]
	private UILabel mainLabel; // 0x30
	[SerializeField]
	private UILabel waitLabel; // 0x38
	private UIWaitLoginPanel.PanelType panelType; // 0x40
	private SystemTextManager systemTextManager; // 0x48
	private float waitTime; // 0x50

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1EA4520 Offset: 0x1EA0520 VA: 0x1EA4520
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x1EA4528 Offset: 0x1EA0528 VA: 0x1EA4528
	private void set_IsOpen(bool value) { }

	// RVA: 0x1EA4534 Offset: 0x1EA0534 VA: 0x1EA4534
	private void Awake() { }

	// RVA: 0x1EA4544 Offset: 0x1EA0544 VA: 0x1EA4544
	private void Update() { }

	// RVA: 0x1EA46B4 Offset: 0x1EA06B4 VA: 0x1EA46B4
	public void OpenWaitTimePanel(float time) { }

	// RVA: 0x1EA4984 Offset: 0x1EA0984 VA: 0x1EA4984
	public void OpenWaitNumPanel(int num) { }

	// RVA: 0x1EA4BC4 Offset: 0x1EA0BC4 VA: 0x1EA4BC4
	public void ClosePanel() { }

	// RVA: 0x1EA4C50 Offset: 0x1EA0C50 VA: 0x1EA4C50
	public void UpdateWaitNum(int num) { }

	[IteratorStateMachine(typeof(UIWaitLoginPanel.<CloseWindow>d__17))]
	// RVA: 0x1EA4BE4 Offset: 0x1EA0BE4 VA: 0x1EA4BE4
	private IEnumerator CloseWindow() { }

	// RVA: 0x1EA4D40 Offset: 0x1EA0D40 VA: 0x1EA4D40
	public void .ctor() { }
}
