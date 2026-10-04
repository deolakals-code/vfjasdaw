// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobaFieldMainPanel : MonoBehaviour // TypeDefIndex: 6080
{
	// Fields
	[SerializeField]
	private GameObject fieldBaseViewPanel; // 0x20
	[SerializeField]
	private GameObject fieldMenuViewPanel; // 0x28
	[SerializeField]
	private GameObject itemSlotViewPanel; // 0x30
	[SerializeField]
	private UILabel levelLabel; // 0x38
	[SerializeField]
	private UILabel phaseLabel; // 0x40
	[SerializeField]
	private string phaseLocalizeText; // 0x48
	[SerializeField]
	private TweenScale phasePanelTween; // 0x50
	[SerializeField]
	private UILabel phaseStateLabel; // 0x58
	[SerializeField]
	private UILabel timerLabel; // 0x60
	[SerializeField]
	private UISprite timerBar; // 0x68
	[SerializeField]
	private int timerBarWith; // 0x70
	[SerializeField]
	private UISprite priorityIcon; // 0x78
	[SerializeField]
	private UILabel priorityLabel; // 0x80
	[SerializeField]
	private GameObject warningAraePop; // 0x88
	[SerializeField]
	private GameObject returnLobbyObj; // 0x90
	[SerializeField]
	private GameObject priorityButtonObj; // 0x98
	[SerializeField]
	private GameObject itemSlotWindow; // 0xA0
	[SerializeField]
	private UISprite[] itemIcons; // 0xA8
	[SerializeField]
	private UISprite[] windowItemIcons; // 0xB0
	[SerializeField]
	private UILabel[] windowItemLabels; // 0xB8
	[SerializeField]
	private UILabel[] windowItemPropLabels; // 0xC0
	[SerializeField]
	private GameObject[] windowItemDropIcon; // 0xC8
	[SerializeField]
	private GameObject[] itemBatsuIcons; // 0xD0
	[SerializeField]
	private GameObject[] windowItemBatsuIcons; // 0xD8
	private MobaRoomData mobaRoomData; // 0xE0
	private string phaseLocalize; // 0xE8
	private SystemTextManager systemTextManager; // 0xF0
	private PlayerDataManager playerDataManager; // 0xF8
	private int nowPhase; // 0x100
	private string phaseLocalizeMessage; // 0x108
	private MobaTreasureBonusManager bonusManager; // 0x110
	private int[] itemSlotItemIds; // 0x118
	private bool IsPriorityTargetedPlayer; // 0x120
	private bool IsMobArae; // 0x121
	[CompilerGenerated]
	private UIBattleReport <BattleReport>k__BackingField; // 0x128

	// Properties
	public UIBattleReport BattleReport { get; set; }

	// Methods

	// RVA: 0x187E368 Offset: 0x187A368 VA: 0x187E368
	public static GameObject CreatePane(MobaRoomData roomData) { }

	[CompilerGenerated]
	// RVA: 0x187E5B8 Offset: 0x187A5B8 VA: 0x187E5B8
	public UIBattleReport get_BattleReport() { }

	[CompilerGenerated]
	// RVA: 0x187E5C0 Offset: 0x187A5C0 VA: 0x187E5C0
	private void set_BattleReport(UIBattleReport value) { }

	// RVA: 0x187E5D0 Offset: 0x187A5D0 VA: 0x187E5D0
	private void Start() { }

	// RVA: 0x187E8C8 Offset: 0x187A8C8 VA: 0x187E8C8
	private void Update() { }

	// RVA: 0x187F70C Offset: 0x187B70C VA: 0x187F70C
	private void OnDestroy() { }

	// RVA: 0x187F870 Offset: 0x187B870 VA: 0x187F870
	public void OnClick_ChangePriorityTarget() { }

	// RVA: 0x187F908 Offset: 0x187B908 VA: 0x187F908
	public void OnClick_ItemSlot() { }

	// RVA: 0x187F9BC Offset: 0x187B9BC VA: 0x187F9BC
	public void OnClick_DropItem(int param) { }

	// RVA: 0x187FABC Offset: 0x187BABC VA: 0x187FABC
	public void OnClickReturnLobby() { }

	// RVA: 0x187FA7C Offset: 0x187BA7C VA: 0x187FA7C
	public void CloseItemSlotWindow() { }

	// RVA: 0x187F14C Offset: 0x187B14C VA: 0x187F14C
	public void UpdateItemSlotPanel() { }

	// RVA: 0x187FBFC Offset: 0x187BBFC VA: 0x187FBFC
	private string GetItemPropertyText(MobaTreasureBonusGroup group, int value) { }

	// RVA: 0x187FD54 Offset: 0x187BD54 VA: 0x187FD54
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x187FF30 Offset: 0x187BF30 VA: 0x187FF30
	private void <OnClickReturnLobby>b__45_0() { }
}
