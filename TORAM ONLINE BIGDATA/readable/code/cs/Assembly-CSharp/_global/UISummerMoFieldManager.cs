// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISummerMoFieldManager : UISummerBaseFieldManager // TypeDefIndex: 6286
{
	// Fields
	[SerializeField]
	private UISprite weaponIconSprite; // 0xF0
	[SerializeField]
	private UILabel weaponStackLabel; // 0xF8
	[SerializeField]
	private UILabel waveLabel; // 0x100
	[SerializeField]
	private UILabel pointLabel; // 0x108
	[SerializeField]
	private UILabel memberLabel; // 0x110
	[SerializeField]
	private GameObject bossTelopPanel; // 0x118
	[SerializeField]
	private UILabel bossTelopLabel; // 0x120
	[SerializeField]
	private TweenScale bossTelopTween; // 0x128
	[SerializeField]
	private GameObject giveUpButton; // 0x130
	[SerializeField]
	private GameObject leftTopButton; // 0x138
	[SerializeField]
	private GameObject rightTopButton; // 0x140
	private int harpoonNum; // 0x148
	private string waveLocalize; // 0x150
	private string waveMaxLocalize; // 0x158
	private string pointLocalize; // 0x160
	private string memberLocalize; // 0x168
	private SummerEventMoRoomData moRoom; // 0x170
	private bool isRoomStartFlag; // 0x178
	private float giveUpWaitTimer; // 0x17C
	private InactiveTimer bossTelopPanelTimer; // 0x180
	private bool isBossPopTelop; // 0x188
	private bool isPopreset; // 0x189

	// Methods

	// RVA: 0x18DD0B8 Offset: 0x18D90B8 VA: 0x18DD0B8 Slot: 7
	protected override void Initialize() { }

	// RVA: 0x18DD558 Offset: 0x18D9558 VA: 0x18DD558
	public void StartRoomGame() { }

	// RVA: 0x18DD568 Offset: 0x18D9568 VA: 0x18DD568
	public void BossPopRoomGame() { }

	// RVA: 0x18DD314 Offset: 0x18D9314 VA: 0x18DD314
	private void PopUpTelop(string text) { }

	// RVA: 0x18DD574 Offset: 0x18D9574 VA: 0x18DD574 Slot: 8
	protected override void UpdateData() { }

	// RVA: 0x18DD82C Offset: 0x18D982C VA: 0x18DD82C
	public void OnChangeWeapon() { }

	// RVA: 0x18DD490 Offset: 0x18D9490 VA: 0x18DD490
	private void UpdateUIChangeWeapon() { }

	// RVA: 0x18DD8C4 Offset: 0x18D98C4 VA: 0x18DD8C4
	public void OnClickGiveUpButton() { }

	// RVA: 0x18DD9A0 Offset: 0x18D99A0 VA: 0x18DD9A0 Slot: 9
	protected override void CloseShortcutPanel() { }

	// RVA: 0x18DD9CC Offset: 0x18D99CC VA: 0x18DD9CC Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x18DD9F4 Offset: 0x18D99F4 VA: 0x18DD9F4 Slot: 11
	protected virtual void SetActiveButton(bool isLeft, bool isRight) { }

	// RVA: 0x18DDA38 Offset: 0x18D9A38 VA: 0x18DDA38 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18DDAF8 Offset: 0x18D9AF8 VA: 0x18DDAF8 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18DDAFC Offset: 0x18D9AFC VA: 0x18DDAFC
	public void .ctor() { }
}
