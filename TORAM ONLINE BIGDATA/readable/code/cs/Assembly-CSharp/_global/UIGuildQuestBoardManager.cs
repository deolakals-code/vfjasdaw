// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildQuestBoardManager : UIBasePanelConnection, UIGuildStaffBasePanel, IShop // TypeDefIndex: 6664
{
	// Fields
	private readonly byte MaxQuest; // 0x2C
	private readonly byte WeeklyMaxQuest; // 0x2D
	private readonly float RestockTime; // 0x30
	[SerializeField]
	private UILabel titleLabel; // 0x38
	[SerializeField]
	private GameObject[] questButton; // 0x40
	[SerializeField]
	private GameObject questResetButton; // 0x48
	[SerializeField]
	private GameObject nonQuestPopLabelObject; // 0x50
	[SerializeField]
	private UIIruna2AnchorSimple bottomLeftAnchor; // 0x58
	[SerializeField]
	private GameObject stockObject; // 0x60
	[SerializeField]
	private UILabel stockLabel; // 0x68
	[SerializeField]
	private UIIruna2AnchorSimple bottomRightAnchor; // 0x70
	[SerializeField]
	private GameObject nextTimerObject; // 0x78
	[SerializeField]
	private UILabel nextTimerLabel; // 0x80
	[SerializeField]
	private UISprite nextTimerBar; // 0x88
	[SerializeField]
	private UILabel clearCountLabel; // 0x90
	[SerializeField]
	private UILabel clearTimerLabel; // 0x98
	[SerializeField]
	private UISprite clearResetBar; // 0xA0
	[SerializeField]
	private GameObject discardResultPop; // 0xA8
	[SerializeField]
	private UILabel discardResultPopLabel; // 0xB0
	[SerializeField]
	private UIGuildQuestBoradPopQuestPanel popQuestWindowPanel; // 0xB8
	[SerializeField]
	private UIGuildQuestBoradPopDiscardPanel popDiscardQuestWindowPanel; // 0xC0
	[SerializeField]
	private GameObject popReorderQuestWindowObject; // 0xC8
	[SerializeField]
	private GameObject popReorderQuestWindowPanel; // 0xD0
	[SerializeField]
	private UILabel popReorderQuestWindowPanelLabel; // 0xD8
	private UIGuildStaffMainManager manager; // 0xE0
	private ItemManager itemManager; // 0xE8
	private Dictionary<int, UIGuildQuestBoardManager.GuildQuestMaseter> mastaerData; // 0xF0
	private UIGuildQuestBoardManager.GuildQuestDataBase[] questData; // 0xF8
	private int[] questDataButtonId; // 0x100
	private TimeSpan restockTimer; // 0x108
	private byte nextQuestType; // 0x110
	private byte userQuestClearNum; // 0x111
	private TimeSpan nextClearResetTimer; // 0x118
	private DateTime reoderLastUpdateTime; // 0x120
	private TimeSpan reoderLastUpdateTimer; // 0x128
	private byte userQuestStockNum; // 0x130
	private bool isInit; // 0x131
	private bool isIniting; // 0x132
	private int selectedQuestNo; // 0x134
	private ItemSelector itemSelector; // 0x138
	private PlayerDataManager playerDataManager; // 0x140
	private int saveAnimationBitFlag; // 0x148
	private bool isClosed; // 0x14C

	// Properties
	private bool isMainPanel { get; }
	public int ShopId { get; set; }
	public string ShopName { get; set; }
	public bool IsClosed { get; set; }

	// Methods

	// RVA: 0x19A7A4C Offset: 0x19A3A4C VA: 0x19A7A4C
	private bool get_isMainPanel() { }

	// RVA: 0x19A7AA4 Offset: 0x19A3AA4 VA: 0x19A7AA4 Slot: 14
	public int get_ShopId() { }

	// RVA: 0x19A7AAC Offset: 0x19A3AAC VA: 0x19A7AAC Slot: 15
	public void set_ShopId(int value) { }

	// RVA: 0x19A7AB0 Offset: 0x19A3AB0 VA: 0x19A7AB0 Slot: 16
	public string get_ShopName() { }

	// RVA: 0x19A7AF8 Offset: 0x19A3AF8 VA: 0x19A7AF8 Slot: 17
	public void set_ShopName(string value) { }

	// RVA: 0x19A7AFC Offset: 0x19A3AFC VA: 0x19A7AFC Slot: 18
	public bool get_IsClosed() { }

	// RVA: 0x19A7B04 Offset: 0x19A3B04 VA: 0x19A7B04 Slot: 19
	public void set_IsClosed(bool value) { }

	// RVA: 0x19A7B08 Offset: 0x19A3B08 VA: 0x19A7B08
	private void Start() { }

	// RVA: 0x19A7F58 Offset: 0x19A3F58 VA: 0x19A7F58
	private void CreateGuildQuestList() { }

	// RVA: 0x19A8998 Offset: 0x19A4998 VA: 0x19A8998
	private void CloaseGuildQuestList() { }

	[IteratorStateMachine(typeof(UIGuildQuestBoardManager.<InitLoadingData>d__63))]
	// RVA: 0x19A8A40 Offset: 0x19A4A40 VA: 0x19A8A40
	private IEnumerator InitLoadingData() { }

	// RVA: 0x19A8AD4 Offset: 0x19A4AD4 VA: 0x19A8AD4
	private bool LoadMaseterData(byte[] binary) { }

	// RVA: 0x19A9214 Offset: 0x19A5214 VA: 0x19A9214
	private UIGuildQuestBoardManager.GuildQuestDataBase GetQuest(int no) { }

	[IteratorStateMachine(typeof(UIGuildQuestBoardManager.<SelectedDiscardQuest>d__66))]
	// RVA: 0x19A9274 Offset: 0x19A5274 VA: 0x19A9274
	private IEnumerator SelectedDiscardQuest(byte no, int nextQuestType) { }

	[IteratorStateMachine(typeof(UIGuildQuestBoardManager.<SelectedReportQuest>d__67))]
	// RVA: 0x19A9320 Offset: 0x19A5320 VA: 0x19A9320
	private IEnumerator SelectedReportQuest(byte no, UIGuildQuestBoardManager.GuildQuestDataBase quest) { }

	[IteratorStateMachine(typeof(UIGuildQuestBoardManager.<SearchPopUpWindow>d__68))]
	// RVA: 0x19A93D8 Offset: 0x19A53D8 VA: 0x19A93D8
	protected IEnumerator SearchPopUpWindow(UIGuildQuestBoardManager.GuildQuestDataBase quest) { }

	// RVA: 0x19A9488 Offset: 0x19A5488 VA: 0x19A9488
	public void OnClickSelectedPopQuest(byte no) { }

	// RVA: 0x19A9B0C Offset: 0x19A5B0C VA: 0x19A9B0C
	public void OnClickItemSearch() { }

	// RVA: 0x19A9B84 Offset: 0x19A5B84 VA: 0x19A9B84
	public void OnClickSelectedReportQuest() { }

	// RVA: 0x19A9D5C Offset: 0x19A5D5C VA: 0x19A9D5C
	public void OnClickSelectedDiscardQuest() { }

	// RVA: 0x19A9FEC Offset: 0x19A5FEC VA: 0x19A9FEC
	public void OnClickSelectedDiscardQuestConnection(int nextQuestType) { }

	// RVA: 0x19AA0E4 Offset: 0x19A60E4 VA: 0x19AA0E4
	public void OnClickResetQuest() { }

	// RVA: 0x19AA34C Offset: 0x19A634C VA: 0x19AA34C
	public void OnClickSelectedReorederQuest() { }

	// RVA: 0x19AA534 Offset: 0x19A6534 VA: 0x19AA534
	public void SelectedConnectionQuestClear() { }

	// RVA: 0x19AA584 Offset: 0x19A6584 VA: 0x19AA584
	public void ReceiveUpdateGuildQuestData(GuildQuestData data) { }

	// RVA: 0x19AA5E0 Offset: 0x19A65E0 VA: 0x19AA5E0
	public void ReceiveUpdateReorderGuildQuestTimer(int time) { }

	// RVA: 0x19AA5C8 Offset: 0x19A65C8 VA: 0x19AA5C8
	public void ReceiveUpdateNextGuildQuestData(byte type, long time, byte stockNum) { }

	// RVA: 0x19AA66C Offset: 0x19A666C VA: 0x19AA66C
	public void ReceiveUpdateGuildQuestList(GuildOrderQuestData[] quests) { }

	// RVA: 0x19AAB94 Offset: 0x19A6B94 VA: 0x19AAB94 Slot: 8
	public void Initialize(UIGuildStaffMainManager manager, SystemTextManager systemTextManager) { }

	// RVA: 0x19A7E74 Offset: 0x19A3E74 VA: 0x19A7E74 Slot: 12
	public void FadeIn() { }

	[IteratorStateMachine(typeof(UIGuildQuestBoardManager.<FadeOut>d__83))]
	// RVA: 0x19AAB9C Offset: 0x19A6B9C VA: 0x19AAB9C Slot: 13
	public IEnumerator FadeOut() { }

	// RVA: 0x19AAC30 Offset: 0x19A6C30 VA: 0x19AAC30 Slot: 11
	public GameObject Panel() { }

	// RVA: 0x19AAC38 Offset: 0x19A6C38 VA: 0x19AAC38 Slot: 9
	public bool PushLeftTopButton() { }

	// RVA: 0x19AADE8 Offset: 0x19A6DE8 VA: 0x19AADE8 Slot: 10
	public bool PushRightTopButton() { }

	// RVA: 0x19AADF0 Offset: 0x19A6DF0 VA: 0x19AADF0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x19AAE24 Offset: 0x19A6E24 VA: 0x19AAE24 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19AAE44 Offset: 0x19A6E44 VA: 0x19AAE44
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x19AAFF4 Offset: 0x19A6FF4 VA: 0x19AAFF4
	private void <SelectedDiscardQuest>b__66_1() { }

	[CompilerGenerated]
	// RVA: 0x19AB000 Offset: 0x19A7000 VA: 0x19AB000
	private void <SelectedReportQuest>b__67_1() { }

	[CompilerGenerated]
	// RVA: 0x19AB00C Offset: 0x19A700C VA: 0x19AB00C
	private void <OnClickSelectedReorederQuest>b__75_1() { }

	[CompilerGenerated]
	// RVA: 0x19AB3D0 Offset: 0x19A73D0 VA: 0x19AB3D0
	private void <OnClickSelectedReorederQuest>b__75_2() { }
}
