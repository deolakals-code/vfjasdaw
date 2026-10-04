// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISummerMoFieldSettingManager : UIBasePanel // TypeDefIndex: 6291
{
	// Fields
	[SerializeField]
	private UISprite titleIcon; // 0x30
	[SerializeField]
	private UILabel titleLabel; // 0x38
	[SerializeField]
	private UISprite userIcon; // 0x40
	[SerializeField]
	private UILabel userNumLabel; // 0x48
	[SerializeField]
	private UILabel roomTypeLabel; // 0x50
	[SerializeField]
	private GameObject settingButton; // 0x58
	[SerializeField]
	private UILabel userNameListLabel; // 0x60
	[SerializeField]
	private UIScrollWindow userScrollList; // 0x68
	[SerializeField]
	private UIToggle[] settingObject; // 0x70
	[SerializeField]
	private UIImageButton settingButtonObject; // 0x78
	[SerializeField]
	private GameObject[] panelObject; // 0x80
	private SummerEventMoRoomData roomData; // 0x88
	private SummerEventData summerEventData; // 0x90
	private byte selectType; // 0x98
	private Dictionary<int, GameObject> userDataList; // 0xA0
	private float leaveTimer; // 0xA8
	private SummerRecruitType selectedType; // 0xAC

	// Methods

	// RVA: 0x18DE294 Offset: 0x18DA294 VA: 0x18DE294
	private void Start() { }

	// RVA: 0x18DE734 Offset: 0x18DA734 VA: 0x18DE734
	private void SetWindowTitle(string icon, string text) { }

	// RVA: 0x18DE78C Offset: 0x18DA78C VA: 0x18DE78C
	public void OnClickLeaveField() { }

	// RVA: 0x18DE814 Offset: 0x18DA814 VA: 0x18DE814
	private void UserListPanelActive() { }

	// RVA: 0x18DE8BC Offset: 0x18DA8BC VA: 0x18DE8BC
	private void UpdateUserList() { }

	// RVA: 0x18DE98C Offset: 0x18DA98C VA: 0x18DE98C
	private void ChangeRoomSettingPanelActive() { }

	// RVA: 0x18DEAE8 Offset: 0x18DAAE8 VA: 0x18DEAE8
	public void OnChangeRoomSettingButton() { }

	// RVA: 0x18DEBF0 Offset: 0x18DABF0 VA: 0x18DEBF0
	public void OnClickChangeSetting() { }

	[IteratorStateMachine(typeof(UISummerMoFieldSettingManager.<WaitUpdateTopPanel>d__26))]
	// RVA: 0x18DEC9C Offset: 0x18DAC9C VA: 0x18DEC9C
	private IEnumerator WaitUpdateTopPanel() { }

	// RVA: 0x18DED30 Offset: 0x18DAD30 VA: 0x18DED30
	private void TopPanelActive() { }

	// RVA: 0x18DE5B8 Offset: 0x18DA5B8 VA: 0x18DE5B8
	public void OnSelectPopPanel(int panelType) { }

	// RVA: 0x18DF0BC Offset: 0x18DB0BC VA: 0x18DF0BC
	private void Update() { }

	// RVA: 0x18DF0F0 Offset: 0x18DB0F0 VA: 0x18DF0F0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18DF178 Offset: 0x18DB178 VA: 0x18DF178 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18DF228 Offset: 0x18DB228 VA: 0x18DF228
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x18DF2B0 Offset: 0x18DB2B0 VA: 0x18DF2B0
	private void <UpdateUserList>b__22_0(int x) { }
}
