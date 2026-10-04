// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIDungeonEnterManager : UIBasePanel // TypeDefIndex: 6605
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x30
	private UIIruna2Anchor mainAnchor; // 0x38
	[SerializeField]
	private GameObject subPanel; // 0x40
	private UIIruna2Anchor subAnchor; // 0x48
	[SerializeField]
	private GameObject partyMessage; // 0x50
	[SerializeField]
	private GameObject lockMessage; // 0x58
	[SerializeField]
	private GameObject npcErrMessage; // 0x60
	[SerializeField]
	private UIImageButton areaLevelButton; // 0x68
	[SerializeField]
	private UILabel areaLevelLabel; // 0x70
	[SerializeField]
	private UILabel dungeonTimeOutLabel; // 0x78
	[SerializeField]
	private UIImageButton itemButton; // 0x80
	[SerializeField]
	private UILabel itemLabel; // 0x88
	[SerializeField]
	private UIImageButton coinItemButton; // 0x90
	[SerializeField]
	private UIImageButton masoButton; // 0x98
	[SerializeField]
	private UILabel manaLabel; // 0xA0
	[SerializeField]
	private UISlider manaSlider; // 0xA8
	private short maxMana; // 0xB0
	private short useMana; // 0xB2
	private short nowMana; // 0xB4
	private int manaChargeType; // 0xB8
	[SerializeField]
	private UIImageButton dungeonEnterButton; // 0xC0
	[SerializeField]
	private UILabel dungeonEnterLabel; // 0xC8
	[SerializeField]
	private UILabel dungeonEnterText; // 0xD0
	[SerializeField]
	private UILabel dungeonMaxAreaLevelLabel; // 0xD8
	[SerializeField]
	private UILabel dungeonTimeLabel; // 0xE0
	[SerializeField]
	private GameObject[] partyMemberObj; // 0xE8
	protected UIPartyMember[] partyMemberData; // 0xF0
	protected TweenPosition[] partyMemberEffect; // 0xF8
	[SerializeField]
	private GameObject manaBar; // 0x100
	[SerializeField]
	private GameObject arrowButton; // 0x108
	private UIPopBaseWindow popWindow; // 0x110
	private UIDungeonEnterBasePanel dungeonEnterBasePanel; // 0x118
	private bool initFlag; // 0x120
	private float connectTimer; // 0x124
	private float countDownTimer; // 0x128
	private PlayerDataManager playerDataManager; // 0x130
	private short maxAreaLevel; // 0x138
	private short maxAreaGuildLevel; // 0x13A
	private short selectAreaLevel; // 0x13C
	private bool cancel; // 0x13E
	private bool close; // 0x13F
	private GameObject shortcutManager; // 0x140
	private bool openShortcut; // 0x148
	private DungeonRoomData roomData; // 0x150
	private bool updateCoinItem; // 0x158
	private OrbManager orbManager; // 0x160
	private bool partyMemberNPCCheck; // 0x168
	private bool isReconnected; // 0x169
	private DungeonRoomData beforeRoomData; // 0x170

	// Properties
	public bool IsCancel { get; }
	public bool IsClose { get; }

	// Methods

	// RVA: 0x1995DF0 Offset: 0x1991DF0 VA: 0x1995DF0
	public bool get_IsCancel() { }

	// RVA: 0x1995DF8 Offset: 0x1991DF8 VA: 0x1995DF8
	public bool get_IsClose() { }

	// RVA: 0x1995E00 Offset: 0x1991E00 VA: 0x1995E00
	private void Awake() { }

	// RVA: 0x1995E08 Offset: 0x1991E08 VA: 0x1995E08
	private void Start() { }

	// RVA: 0x1996390 Offset: 0x1992390 VA: 0x1996390
	private void OnDestroy() { }

	// RVA: 0x1996454 Offset: 0x1992454 VA: 0x1996454
	private void Initialize() { }

	[IteratorStateMachine(typeof(UIDungeonEnterManager.<UpdateOrbItem>d__58))]
	// RVA: 0x1996C94 Offset: 0x1992C94 VA: 0x1996C94
	private IEnumerator UpdateOrbItem() { }

	// RVA: 0x1996D28 Offset: 0x1992D28 VA: 0x1996D28
	private void SetCoinLabel() { }

	// RVA: 0x1996F74 Offset: 0x1992F74 VA: 0x1996F74
	private void Update() { }

	// RVA: 0x1998028 Offset: 0x1994028 VA: 0x1998028
	private void BattleReady() { }

	// RVA: 0x1997EE8 Offset: 0x1993EE8 VA: 0x1997EE8
	private void BattleReadyCancel() { }

	[IteratorStateMachine(typeof(UIDungeonEnterManager.<PopUpEnterWindow>d__63))]
	// RVA: 0x19981F4 Offset: 0x19941F4 VA: 0x19981F4
	private IEnumerator PopUpEnterWindow() { }

	// RVA: 0x1998288 Offset: 0x1994288 VA: 0x1998288
	private void PopUpAreaLevel() { }

	// RVA: 0x199847C Offset: 0x199447C VA: 0x199847C
	private void PopUpAreaLevelData(int param) { }

	// RVA: 0x19985FC Offset: 0x19945FC VA: 0x19985FC
	private void PopUpRecovery(int type) { }

	// RVA: 0x1998914 Offset: 0x1994914 VA: 0x1998914
	private void PopUpInputData(int param) { }

	// RVA: 0x1996268 Offset: 0x1992268 VA: 0x1996268
	private void SetLeftButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x19962FC Offset: 0x19922FC VA: 0x19962FC
	private void SetRightButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x1998B34 Offset: 0x1994B34 VA: 0x1998B34
	public void ForceClose() { }

	// RVA: 0x1998B64 Offset: 0x1994B64 VA: 0x1998B64
	public void CopeGroupNotFound() { }

	// RVA: 0x1997D90 Offset: 0x1993D90 VA: 0x1997D90
	private void CloseShortcutPanel() { }

	// RVA: 0x1998EA0 Offset: 0x1994EA0 VA: 0x1998EA0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1999048 Offset: 0x1995048 VA: 0x1999048 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x199914C Offset: 0x199514C VA: 0x199914C Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x19992DC Offset: 0x19952DC VA: 0x19992DC
	public void .ctor() { }
}
