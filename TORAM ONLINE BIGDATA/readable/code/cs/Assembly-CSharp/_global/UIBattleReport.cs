// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBattleReport : MonoBehaviour // TypeDefIndex: 6374
{
	// Fields
	[SerializeField]
	private GameObject panelObj; // 0x20
	[SerializeField]
	private UILabel reportTitleLabel; // 0x28
	[SerializeField]
	private UILabel reportContentLabel; // 0x30
	[SerializeField]
	private UILabel reportBossAppearLabel; // 0x38
	private bool isActive; // 0x40
	private bool isChangeVisible; // 0x41
	private float printTime; // 0x44
	private float oldPrintTime; // 0x48
	private float titleScale; // 0x4C
	private float contentScale; // 0x50
	private bool bossAppearAlphaFlag; // 0x54
	private SystemTextManager systemTextManager; // 0x58

	// Properties
	public bool IsActiveBossAppear { get; }

	// Methods

	// RVA: 0x1915374 Offset: 0x1911374 VA: 0x1915374
	public bool get_IsActiveBossAppear() { }

	// RVA: 0x1915390 Offset: 0x1911390 VA: 0x1915390
	public static GameObject CreateReport() { }

	// RVA: 0x19154B0 Offset: 0x19114B0 VA: 0x19154B0
	public void SetReportProp(string titleText, string contentText, float pritnTime = 3.5) { }

	// RVA: 0x191554C Offset: 0x191154C VA: 0x191554C
	public void SetEnable(bool enable) { }

	// RVA: 0x191556C Offset: 0x191156C VA: 0x191556C
	public void ChangeActiveBossAppear(bool isActive) { }

	// RVA: 0x19155C8 Offset: 0x19115C8 VA: 0x19155C8
	public void SetBossAppearText(string text) { }

	// RVA: 0x19155E4 Offset: 0x19115E4 VA: 0x19155E4
	private void Start() { }

	// RVA: 0x1915718 Offset: 0x1911718 VA: 0x1915718
	private void Update() { }

	// RVA: 0x1915A40 Offset: 0x1911A40 VA: 0x1915A40
	public void .ctor() { }
}
