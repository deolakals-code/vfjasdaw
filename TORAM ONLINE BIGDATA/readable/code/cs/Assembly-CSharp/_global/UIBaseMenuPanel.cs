// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIBaseMenuPanel : UIBasePanel // TypeDefIndex: 8138
{
	// Fields
	protected readonly string scrollWindowPrefabPath; // 0x30
	protected Dictionary<int, UIBaseMenuPanel.MenuListButton> buttonList; // 0x38
	[SerializeField]
	protected GameObject advice; // 0x40
	[SerializeField]
	protected UILabel adviceMessage; // 0x48
	protected int adviceId; // 0x50
	protected string adviceMessageText; // 0x58
	protected UIScrollWindow scrollWindow; // 0x60
	[SerializeField]
	protected GameObject scrollButton; // 0x68
	protected bool cancelCheck; // 0x70
	protected UIMainManager.UIElicitFlag elicitFlag; // 0x74
	protected float buttonPosY; // 0x78

	// Methods

	// RVA: 0x1CD4544 Offset: 0x1CD0544 VA: 0x1CD4544 Slot: 7
	protected virtual void Start() { }

	// RVA: 0x1CD496C Offset: 0x1CD096C VA: 0x1CD496C Slot: 8
	protected virtual void LoadScrollWindos() { }

	// RVA: 0x1CD4A84 Offset: 0x1CD0A84 VA: 0x1CD4A84 Slot: 9
	protected virtual void SetButton(string text, float y, int id) { }

	// RVA: 0x1CD4A94 Offset: 0x1CD0A94 VA: 0x1CD4A94 Slot: 10
	protected virtual GameObject SetButton(string text, float y, int id, UIBaseMenuPanel.SystemLockType lockFlag) { }

	// RVA: 0x1CD4D30 Offset: 0x1CD0D30 VA: 0x1CD4D30
	protected void SetGreenButton(GameObject button) { }

	// RVA: 0x1CD4E64 Offset: 0x1CD0E64 VA: 0x1CD4E64 Slot: 11
	protected virtual void OnClickButton(int id) { }

	// RVA: 0x1CD4F48 Offset: 0x1CD0F48 VA: 0x1CD4F48
	private void OnHoverButton(int id) { }

	// RVA: 0x1CD5008 Offset: 0x1CD1008 VA: 0x1CD5008 Slot: 12
	protected virtual void OnAdviceMessage() { }

	[IteratorStateMachine(typeof(UIBaseMenuPanel.<PopUpAdviceMessage>d__21))]
	// RVA: 0x1CD5090 Offset: 0x1CD1090 VA: 0x1CD5090
	private IEnumerator PopUpAdviceMessage() { }

	// RVA: 0x1CD5124 Offset: 0x1CD1124 VA: 0x1CD5124 Slot: 13
	protected virtual PopUpMessageWindow AdviceMessageData() { }

	// RVA: 0x1CD512C Offset: 0x1CD112C VA: 0x1CD512C Slot: 14
	protected virtual void AdviceMessageButton() { }

	// RVA: 0x1CD5130 Offset: 0x1CD1130 VA: 0x1CD5130
	protected UIBaseMenuPanel.SystemLockType ReviewCheck(UIBaseMenuPanel.SystemLockType set) { }

	// RVA: 0x1CD5138 Offset: 0x1CD1138 VA: 0x1CD5138 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1CD51D8 Offset: 0x1CD11D8 VA: 0x1CD51D8 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1CD525C Offset: 0x1CD125C VA: 0x1CD525C
	protected void .ctor() { }
}
