// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildRaidSymbolManager : UIBasePanelConnection, IUIRaidRoomMemberReceive, IUIGuildRaidStaminRecoveryPanelReceiver // TypeDefIndex: 5786
{
	// Fields
	[SerializeField]
	private UIPartyMember[] partyMemberObject; // 0x30
	[SerializeField]
	private UIIruna2Anchor mainBossPanelAnchor; // 0x38
	[SerializeField]
	private UILabel enterButtonLabel; // 0x40
	[SerializeField]
	private UIImageButton enterButton; // 0x48
	[SerializeField]
	private UIImageButton leaveButton; // 0x50
	[SerializeField]
	private UILabel bossBattleLevelLabel; // 0x58
	[SerializeField]
	private UILabel bossNameLabel; // 0x60
	[SerializeField]
	private UIIcon bossElementIcon; // 0x68
	[SerializeField]
	private UISprite bossHpSprite; // 0x70
	[SerializeField]
	private UILabel bossBattleHpGaugeLabel; // 0x78
	[SerializeField]
	private GameObject[] propertyButton; // 0x80
	private UIGuildRaidRandamPropertyLabel[] propertyButtonLabel; // 0x88
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x90
	[SerializeField]
	private GameObject lobbyPanel; // 0x98
	[SerializeField]
	private UIGuildRaidSymbolPartyPanel[] lobbyPartyPanel; // 0xA0
	[SerializeField]
	private UIIruna2Anchor partyLeaderJoinAnchor; // 0xA8
	[SerializeField]
	private UIIruna2Anchor memberJoinCancelAnchor; // 0xB0
	[SerializeField]
	private UIImageButton enterLobbyButton; // 0xB8
	[SerializeField]
	private UISprite[] staminaIcons; // 0xC0
	[SerializeField]
	private GameObject staminaRecoveryButton; // 0xC8
	[SerializeField]
	private GameObject[] practicePanels; // 0xD0
	[SerializeField]
	private GameObject[] playPanels; // 0xD8
	[SerializeField]
	private GameObject baseWindow; // 0xE0
	[SerializeField]
	private GameObject errPanel; // 0xE8
	[SerializeField]
	private GameObject[] errTitleIcon; // 0xF0
	[SerializeField]
	private UILabel errTitleLabel; // 0xF8
	[SerializeField]
	private UILabel errTextLabel; // 0x100
	[SerializeField]
	private UILabel errPartyTextLabel; // 0x108
	[SerializeField]
	private GameObject[] errPartyObject; // 0x110
	[SerializeField]
	private GameObject checkPanel; // 0x118
	[SerializeField]
	private GameObject[] checkPartyObject; // 0x120
	[SerializeField]
	private GameObject randamPropertyOrbPanel; // 0x128
	[SerializeField]
	private GameObject[] randamPropertyOrbActivePanel; // 0x130
	[SerializeField]
	private UILabel selectedRandamPropertyLabel; // 0x138
	[SerializeField]
	private UISprite[] selectedRandamPropertyIcons; // 0x140
	[SerializeField]
	private UILabel randamPropertyOrbPriceLabel; // 0x148
	[SerializeField]
	private UIImageButton randamPropertyDirectButton; // 0x150
	[SerializeField]
	private UISlider randamPropertyWaitSlider; // 0x158
	[SerializeField]
	private UIIruna2Anchor orbPanelAnchor; // 0x160
	[SerializeField]
	private UILabel orbNumLabel; // 0x168
	private PlayerDataManager playerDataManager; // 0x170
	private GuildRaidRoomData guildRaidRoomData; // 0x178
	private bool initCheck; // 0x180
	private GameObject shortcutManager; // 0x188
	private bool openShortcut; // 0x190
	private bool cancel; // 0x191
	private bool close; // 0x192
	private UIGuildRaidSymbolManager.PanelState panelState; // 0x194
	private int enterPartyNum; // 0x198
	private bool enterIsParty; // 0x19C
	private bool enterPartyLeader; // 0x19D
	private int enterRaidRaidId; // 0x1A0
	private Action popWindowReturnCall; // 0x1A8
	private float updateRoomTimer; // 0x1B0
	private byte enterTeamNum; // 0x1B4
	private byte enterTeamFlag; // 0x1B5
	private UIGuildRaidStaminaRecoveryPanel staminaRecoveryPanel; // 0x1B8
	private int popUpWindowOrbState; // 0x1C0
	private bool isErrRoom; // 0x1C4
	private bool isReconnect; // 0x1C5
	private bool isPractice; // 0x1C6

	// Properties
	public bool IsCancel { get; }
	public bool IsClose { get; }

	// Methods

	// RVA: 0x17E8734 Offset: 0x17E4734 VA: 0x17E8734
	public bool get_IsCancel() { }

	// RVA: 0x17E873C Offset: 0x17E473C VA: 0x17E873C
	public bool get_IsClose() { }

	// RVA: 0x17E8744 Offset: 0x17E4744 VA: 0x17E8744
	private void Awake() { }

	[IteratorStateMachine(typeof(UIGuildRaidSymbolManager.<Start>d__69))]
	// RVA: 0x17E8994 Offset: 0x17E4994 VA: 0x17E8994
	private IEnumerator Start() { }

	// RVA: 0x17E8A28 Offset: 0x17E4A28 VA: 0x17E8A28
	private void OnDestroy() { }

	// RVA: 0x17E8AD4 Offset: 0x17E4AD4 VA: 0x17E8AD4
	private void Update() { }

	// RVA: 0x17E94EC Offset: 0x17E54EC VA: 0x17E94EC
	private void CloseShortcutPanel() { }

	// RVA: 0x17E9524 Offset: 0x17E5524 VA: 0x17E9524
	private void OpenMainPanel() { }

	// RVA: 0x17E9FB4 Offset: 0x17E5FB4 VA: 0x17E9FB4
	private void OpenLobbyPanel() { }

	[IteratorStateMachine(typeof(UIGuildRaidSymbolManager.<OpenRandamPropertyOrbPanel>d__75))]
	// RVA: 0x17EA4D4 Offset: 0x17E64D4 VA: 0x17EA4D4
	private IEnumerator OpenRandamPropertyOrbPanel(GuildRaidRandomPropertyData data) { }

	// RVA: 0x17EA1F8 Offset: 0x17E61F8 VA: 0x17EA1F8
	private void ClosePopWindow() { }

	// RVA: 0x17EA584 Offset: 0x17E6584 VA: 0x17EA584 Slot: 8
	public void ReceiveMemberData(RoomMemberData[] members) { }

	// RVA: 0x17EA994 Offset: 0x17E6994 VA: 0x17EA994
	public void ReceiveBattleAreaErr(UIGuildRaidSymbolManager.EnterErr type, RoomMemberData[] members) { }

	// RVA: 0x17EB010 Offset: 0x17E7010 VA: 0x17EB010
	public void ReceiveJoinLobbyMemberLeave() { }

	// RVA: 0x17E0C64 Offset: 0x17DCC64 VA: 0x17E0C64
	public void OnClick_SelectedRemoveRandamProperty(int index) { }

	// RVA: 0x17EB2EC Offset: 0x17E72EC VA: 0x17EB2EC
	public void OnClick_RemoveRandamProperty() { }

	// RVA: 0x17EB304 Offset: 0x17E7304 VA: 0x17EB304
	public void OnClick_RemoveRandamPropertyEnd() { }

	// RVA: 0x17EB380 Offset: 0x17E7380 VA: 0x17EB380
	public void OnClick_RecoveryStamina() { }

	// RVA: 0x17EB5EC Offset: 0x17E75EC VA: 0x17EB5EC
	public void OnClick_EndErrPop() { }

	// RVA: 0x17EB648 Offset: 0x17E7648 VA: 0x17EB648
	public void OnClick_BattleReady() { }

	// RVA: 0x17EB7C0 Offset: 0x17E77C0 VA: 0x17EB7C0
	public void OnClick_PartyBattleReady() { }

	// RVA: 0x17EBBD0 Offset: 0x17E7BD0 VA: 0x17EBBD0
	public void OnClick_GuildRaidRoomLobbyJoin() { }

	// RVA: 0x17EBDDC Offset: 0x17E7DDC VA: 0x17EBDDC
	public void OnClick_BattleReadyCancel() { }

	// RVA: 0x17EBF50 Offset: 0x17E7F50 VA: 0x17EBF50 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x17EC0B8 Offset: 0x17E80B8 VA: 0x17EC0B8 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x17EC218 Offset: 0x17E8218 VA: 0x17EC218 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x17EC3B0 Offset: 0x17E83B0 VA: 0x17EC3B0 Slot: 9
	public void OnUpdatePanel() { }

	// RVA: 0x17EA3A4 Offset: 0x17E63A4 VA: 0x17EA3A4 Slot: 10
	public void SetActiveOrbPanel(bool isEnable) { }

	// RVA: 0x17EC3B4 Offset: 0x17E83B4 VA: 0x17EC3B4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x17EC49C Offset: 0x17E849C VA: 0x17EC49C
	private void <Update>b__71_1() { }

	[CompilerGenerated]
	// RVA: 0x17EC518 Offset: 0x17E8518 VA: 0x17EC518
	private void <OpenRandamPropertyOrbPanel>b__75_0() { }

	[CompilerGenerated]
	// RVA: 0x17EC540 Offset: 0x17E8540 VA: 0x17EC540
	private void <OnClick_BattleReady>b__85_1() { }

	[CompilerGenerated]
	// RVA: 0x17EC8E0 Offset: 0x17E88E0 VA: 0x17EC8E0
	private void <OnClick_BattleReady>b__85_4() { }

	[CompilerGenerated]
	// RVA: 0x17ECB28 Offset: 0x17E8B28 VA: 0x17ECB28
	private void <OnClick_PartyBattleReady>b__86_0() { }

	[CompilerGenerated]
	// RVA: 0x17ECB8C Offset: 0x17E8B8C VA: 0x17ECB8C
	private void <OnClick_GuildRaidRoomLobbyJoin>b__87_1() { }

	[CompilerGenerated]
	// RVA: 0x17ECEEC Offset: 0x17E8EEC VA: 0x17ECEEC
	private void <OnClick_BattleReadyCancel>b__88_1() { }
}
