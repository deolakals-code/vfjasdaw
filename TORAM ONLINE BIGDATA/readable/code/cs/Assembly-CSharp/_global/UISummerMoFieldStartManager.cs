// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISummerMoFieldStartManager : UIBasePanel // TypeDefIndex: 6293
{
	// Fields
	[SerializeField]
	private UILabel uiPopTextLabel; // 0x30
	[SerializeField]
	private UISprite userIcon; // 0x38
	[SerializeField]
	private UILabel userNumLabel; // 0x40
	[SerializeField]
	private GameObject leaderPanel; // 0x48
	[SerializeField]
	private GameObject memberPanel; // 0x50
	[SerializeField]
	private GameObject leftTopButton; // 0x58
	[SerializeField]
	private GameObject rightTopButton; // 0x60
	protected Transform playerTrans; // 0x68
	private SummerEventMoRoomData roomData; // 0x70
	private GameObject shortcutManager; // 0x78
	private bool openShortcut; // 0x80
	private bool isWallCheck; // 0x81
	private bool isOptionReverse; // 0x82
	private bool isInit; // 0x83
	public SummerRecruitType recruitType; // 0x84

	// Methods

	[IteratorStateMachine(typeof(UISummerMoFieldStartManager.<Start>d__15))]
	// RVA: 0x18DF6DC Offset: 0x18DB6DC VA: 0x18DF6DC Slot: 7
	protected virtual IEnumerator Start() { }

	// RVA: 0x18DF770 Offset: 0x18DB770 VA: 0x18DF770
	private void OnDestroy() { }

	// RVA: 0x18DF800 Offset: 0x18DB800 VA: 0x18DF800
	private void Update() { }

	// RVA: 0x18DFB90 Offset: 0x18DBB90 VA: 0x18DFB90
	public void OnClickGameStart() { }

	// RVA: 0x18DFA3C Offset: 0x18DBA3C VA: 0x18DFA3C
	private void CloseShortcutPanel() { }

	// RVA: 0x18DFC0C Offset: 0x18DBC0C VA: 0x18DFC0C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18DFD44 Offset: 0x18DBD44 VA: 0x18DFD44 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18DFE5C Offset: 0x18DBE5C VA: 0x18DFE5C Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x18DFF00 Offset: 0x18DBF00 VA: 0x18DFF00 Slot: 8
	protected virtual void SetActiveButton(bool isLeft, bool isRight) { }

	// RVA: 0x18DFF44 Offset: 0x18DBF44 VA: 0x18DFF44
	public void .ctor() { }
}
