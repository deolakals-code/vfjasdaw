// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MainPlayer : PlayerObjectBase, IAutoItemPlayer, IMainPlayer // TypeDefIndex: 602
{
	// Fields
	private Game engine; // 0x90
	private Coroutine checkStatusCoroutine; // 0x98
	private Dictionary<int, Func<bool, int>> itemReserve; // 0xA0
	private const float BaseItemDelay = 10;
	private float itemDelay; // 0xA8
	private float nowItemDelayTime; // 0xAC
	private bool isFirstEnterFieldRayCheck; // 0xB0
	private float routineConnectTime; // 0xB4
	private float mobRoutineConnectTime; // 0xB8
	private float routineConnectTimeInterval; // 0xBC
	private readonly float mobRoutineConnectTimeInterval; // 0xC0
	private bool enableRoutineConnect; // 0xC4
	private NewArchetypeProperties serverProperty; // 0xC8
	private int activeParamId; // 0xD0
	[CompilerGenerated]
	private PlayerStatusBase <PlayerStatus>k__BackingField; // 0xD8
	[CompilerGenerated]
	private ItemManager <ItemManager>k__BackingField; // 0xE0
	[CompilerGenerated]
	private AutoItemManager <AutoItemManager>k__BackingField; // 0xE8
	[CompilerGenerated]
	private SkillManager <SkillManager>k__BackingField; // 0xF0
	[CompilerGenerated]
	private SkillBufferManager <SkillBufferManager>k__BackingField; // 0xF8
	[CompilerGenerated]
	private BonusManager <BonusManager>k__BackingField; // 0x100
	[CompilerGenerated]
	private AbnormalStateManager <AbnormalStateManager>k__BackingField; // 0x108
	[CompilerGenerated]
	private BufferEffectManager <BufferEffectManager>k__BackingField; // 0x110
	[CompilerGenerated]
	private EquipBuffManager <EquipBuffManager>k__BackingField; // 0x118
	[CompilerGenerated]
	private StarGemManager <StarGemManager>k__BackingField; // 0x120
	[CompilerGenerated]
	private RegistletManager <RegistletManager>k__BackingField; // 0x128
	[CompilerGenerated]
	private GemCartBufferManager <GemCartBufManager>k__BackingField; // 0x130
	[CompilerGenerated]
	private ItemRandomPropertyManager <ItemRandomPropertyManager>k__BackingField; // 0x138
	[CompilerGenerated]
	private ProficiencyManager <ProficiencyManager>k__BackingField; // 0x140
	[CompilerGenerated]
	private SkillComboManager <SkillComboManager>k__BackingField; // 0x148
	[CompilerGenerated]
	private EffectPlayer <EffectPlayer>k__BackingField; // 0x150
	[CompilerGenerated]
	private EmotionPlayer <EmotionPlayer>k__BackingField; // 0x158
	[CompilerGenerated]
	private ExSkillManager <ExSkillManager>k__BackingField; // 0x160
	[CompilerGenerated]
	private bool <IsFieldAction>k__BackingField; // 0x168
	[CompilerGenerated]
	private TradeManager <TradeManager>k__BackingField; // 0x170

	// Properties
	public PlayerStatusBase PlayerStatus { get; set; }
	public ItemManager ItemManager { get; set; }
	public AutoItemManager AutoItemManager { get; set; }
	public SkillManager SkillManager { get; set; }
	public SkillBufferManager SkillBufferManager { get; set; }
	public BonusManager BonusManager { get; set; }
	public AbnormalStateManager AbnormalStateManager { get; set; }
	public BufferEffectManager BufferEffectManager { get; set; }
	public EquipBuffManager EquipBuffManager { get; set; }
	public StarGemManager StarGemManager { get; set; }
	public RegistletManager RegistletManager { get; set; }
	public GemCartBufferManager GemCartBufManager { get; set; }
	public ItemRandomPropertyManager ItemRandomPropertyManager { get; set; }
	public ProficiencyManager ProficiencyManager { get; set; }
	public SkillComboManager SkillComboManager { get; set; }
	public EffectPlayer EffectPlayer { get; set; }
	public EmotionPlayer EmotionPlayer { get; set; }
	public ExSkillManager ExSkillManager { get; set; }
	public override bool IsGhost { get; }
	public PlayerActionManager PlayerActionManager { get; }
	public float ItemDelayTime { get; }
	public float ItemDelayPercent { get; }
	public NewArchetypeProperties Properties { get; }
	public override bool IsGMEventPlayer { get; }
	public bool IsUseSignBoard { get; }
	public bool IsFieldAction { get; set; }
	public TradeManager TradeManager { get; set; }

	// Methods

	// RVA: 0x19D7B34 Offset: 0x19D3B34 VA: 0x19D7B34
	public static MainPlayer CreatePlayer(Game engine, int id, string userName) { }

	[CompilerGenerated]
	// RVA: 0x19D858C Offset: 0x19D458C VA: 0x19D858C Slot: 45
	public PlayerStatusBase get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x19D8594 Offset: 0x19D4594 VA: 0x19D8594
	private void set_PlayerStatus(PlayerStatusBase value) { }

	[CompilerGenerated]
	// RVA: 0x19D859C Offset: 0x19D459C VA: 0x19D859C Slot: 46
	public ItemManager get_ItemManager() { }

	[CompilerGenerated]
	// RVA: 0x19D85A4 Offset: 0x19D45A4 VA: 0x19D85A4
	private void set_ItemManager(ItemManager value) { }

	[CompilerGenerated]
	// RVA: 0x19D85AC Offset: 0x19D45AC VA: 0x19D85AC Slot: 47
	public AutoItemManager get_AutoItemManager() { }

	[CompilerGenerated]
	// RVA: 0x19D85B4 Offset: 0x19D45B4 VA: 0x19D85B4
	private void set_AutoItemManager(AutoItemManager value) { }

	[CompilerGenerated]
	// RVA: 0x19D85BC Offset: 0x19D45BC VA: 0x19D85BC Slot: 48
	public SkillManager get_SkillManager() { }

	[CompilerGenerated]
	// RVA: 0x19D85C4 Offset: 0x19D45C4 VA: 0x19D85C4
	private void set_SkillManager(SkillManager value) { }

	[CompilerGenerated]
	// RVA: 0x19D85CC Offset: 0x19D45CC VA: 0x19D85CC Slot: 49
	public SkillBufferManager get_SkillBufferManager() { }

	[CompilerGenerated]
	// RVA: 0x19D85D4 Offset: 0x19D45D4 VA: 0x19D85D4
	private void set_SkillBufferManager(SkillBufferManager value) { }

	[CompilerGenerated]
	// RVA: 0x19D85DC Offset: 0x19D45DC VA: 0x19D85DC Slot: 50
	public BonusManager get_BonusManager() { }

	[CompilerGenerated]
	// RVA: 0x19D85E4 Offset: 0x19D45E4 VA: 0x19D85E4
	private void set_BonusManager(BonusManager value) { }

	[CompilerGenerated]
	// RVA: 0x19D85F4 Offset: 0x19D45F4 VA: 0x19D85F4 Slot: 51
	public AbnormalStateManager get_AbnormalStateManager() { }

	[CompilerGenerated]
	// RVA: 0x19D85FC Offset: 0x19D45FC VA: 0x19D85FC
	private void set_AbnormalStateManager(AbnormalStateManager value) { }

	[CompilerGenerated]
	// RVA: 0x19D860C Offset: 0x19D460C VA: 0x19D860C Slot: 52
	public BufferEffectManager get_BufferEffectManager() { }

	[CompilerGenerated]
	// RVA: 0x19D8614 Offset: 0x19D4614 VA: 0x19D8614
	private void set_BufferEffectManager(BufferEffectManager value) { }

	[CompilerGenerated]
	// RVA: 0x19D8624 Offset: 0x19D4624 VA: 0x19D8624 Slot: 53
	public EquipBuffManager get_EquipBuffManager() { }

	[CompilerGenerated]
	// RVA: 0x19D862C Offset: 0x19D462C VA: 0x19D862C
	private void set_EquipBuffManager(EquipBuffManager value) { }

	[CompilerGenerated]
	// RVA: 0x19D863C Offset: 0x19D463C VA: 0x19D863C Slot: 54
	public StarGemManager get_StarGemManager() { }

	[CompilerGenerated]
	// RVA: 0x19D8644 Offset: 0x19D4644 VA: 0x19D8644
	private void set_StarGemManager(StarGemManager value) { }

	[CompilerGenerated]
	// RVA: 0x19D8654 Offset: 0x19D4654 VA: 0x19D8654 Slot: 55
	public RegistletManager get_RegistletManager() { }

	[CompilerGenerated]
	// RVA: 0x19D865C Offset: 0x19D465C VA: 0x19D865C
	private void set_RegistletManager(RegistletManager value) { }

	[CompilerGenerated]
	// RVA: 0x19D866C Offset: 0x19D466C VA: 0x19D866C Slot: 56
	public GemCartBufferManager get_GemCartBufManager() { }

	[CompilerGenerated]
	// RVA: 0x19D8674 Offset: 0x19D4674 VA: 0x19D8674
	private void set_GemCartBufManager(GemCartBufferManager value) { }

	[CompilerGenerated]
	// RVA: 0x19D8684 Offset: 0x19D4684 VA: 0x19D8684 Slot: 57
	public ItemRandomPropertyManager get_ItemRandomPropertyManager() { }

	[CompilerGenerated]
	// RVA: 0x19D868C Offset: 0x19D468C VA: 0x19D868C
	private void set_ItemRandomPropertyManager(ItemRandomPropertyManager value) { }

	[CompilerGenerated]
	// RVA: 0x19D869C Offset: 0x19D469C VA: 0x19D869C Slot: 58
	public ProficiencyManager get_ProficiencyManager() { }

	[CompilerGenerated]
	// RVA: 0x19D86A4 Offset: 0x19D46A4 VA: 0x19D86A4
	private void set_ProficiencyManager(ProficiencyManager value) { }

	[CompilerGenerated]
	// RVA: 0x19D86B4 Offset: 0x19D46B4 VA: 0x19D86B4 Slot: 59
	public SkillComboManager get_SkillComboManager() { }

	[CompilerGenerated]
	// RVA: 0x19D86BC Offset: 0x19D46BC VA: 0x19D86BC
	private void set_SkillComboManager(SkillComboManager value) { }

	[CompilerGenerated]
	// RVA: 0x19D86CC Offset: 0x19D46CC VA: 0x19D86CC Slot: 60
	public EffectPlayer get_EffectPlayer() { }

	[CompilerGenerated]
	// RVA: 0x19D86D4 Offset: 0x19D46D4 VA: 0x19D86D4
	private void set_EffectPlayer(EffectPlayer value) { }

	[CompilerGenerated]
	// RVA: 0x19D86E4 Offset: 0x19D46E4 VA: 0x19D86E4 Slot: 61
	public EmotionPlayer get_EmotionPlayer() { }

	[CompilerGenerated]
	// RVA: 0x19D86EC Offset: 0x19D46EC VA: 0x19D86EC
	private void set_EmotionPlayer(EmotionPlayer value) { }

	[CompilerGenerated]
	// RVA: 0x19D86FC Offset: 0x19D46FC VA: 0x19D86FC Slot: 63
	public ExSkillManager get_ExSkillManager() { }

	[CompilerGenerated]
	// RVA: 0x19D8704 Offset: 0x19D4704 VA: 0x19D8704
	private void set_ExSkillManager(ExSkillManager value) { }

	// RVA: 0x19D8714 Offset: 0x19D4714 VA: 0x19D8714 Slot: 38
	public override bool get_IsGhost() { }

	// RVA: 0x19D871C Offset: 0x19D471C VA: 0x19D871C
	public PlayerActionManager get_PlayerActionManager() { }

	// RVA: 0x19D879C Offset: 0x19D479C VA: 0x19D879C Slot: 78
	public float get_ItemDelayTime() { }

	// RVA: 0x19D87A4 Offset: 0x19D47A4 VA: 0x19D87A4 Slot: 79
	public float get_ItemDelayPercent() { }

	// RVA: 0x19D87B0 Offset: 0x19D47B0 VA: 0x19D87B0 Slot: 62
	public NewArchetypeProperties get_Properties() { }

	// RVA: 0x19D87B8 Offset: 0x19D47B8 VA: 0x19D87B8 Slot: 18
	public override bool get_IsGMEventPlayer() { }

	// RVA: 0x19D87D4 Offset: 0x19D47D4 VA: 0x19D87D4 Slot: 81
	public bool get_IsUseSignBoard() { }

	[CompilerGenerated]
	// RVA: 0x19D8870 Offset: 0x19D4870 VA: 0x19D8870 Slot: 69
	public bool get_IsFieldAction() { }

	[CompilerGenerated]
	// RVA: 0x19D8878 Offset: 0x19D4878 VA: 0x19D8878
	private void set_IsFieldAction(bool value) { }

	[CompilerGenerated]
	// RVA: 0x19D8884 Offset: 0x19D4884 VA: 0x19D8884 Slot: 64
	public TradeManager get_TradeManager() { }

	[CompilerGenerated]
	// RVA: 0x19D888C Offset: 0x19D488C VA: 0x19D888C
	private void set_TradeManager(TradeManager value) { }

	// RVA: 0x19D7C38 Offset: 0x19D3C38 VA: 0x19D7C38
	private void Initialize(int id, string userName) { }

	// RVA: 0x19D8AB0 Offset: 0x19D4AB0 VA: 0x19D8AB0 Slot: 72
	public bool ConnectUpdate(PacketBase updatePacketBase) { }

	// RVA: 0x19D8AB8 Offset: 0x19D4AB8 VA: 0x19D8AB8 Slot: 73
	public void ConnectUpdate(int serverFPS, Dictionary<byte, object> newProperties, IItemBagData itemBagData, IStatusData statusData, IGuildBufferData guildBufferData, IParamData paramData, IHouseBufferData houseData) { }

	// RVA: 0x19DABB0 Offset: 0x19D6BB0 VA: 0x19DABB0
	private void Update() { }

	// RVA: 0x19DACA0 Offset: 0x19D6CA0 VA: 0x19DACA0
	private void LateUpdate() { }

	// RVA: 0x19DB428 Offset: 0x19D7428 VA: 0x19DB428 Slot: 41
	protected override byte[] GetSignboardBinary() { }

	// RVA: 0x19DB440 Offset: 0x19D7440 VA: 0x19DB440 Slot: 94
	public bool UseItem(int uuid, bool isAutoUse) { }

	// RVA: 0x19DB86C Offset: 0x19D786C VA: 0x19DB86C Slot: 82
	public void CalcItemDelay(float time, bool bonus) { }

	// RVA: 0x19DB914 Offset: 0x19D7914 VA: 0x19DB914 Slot: 83
	public bool ItemInvoke(int uuid) { }

	// RVA: 0x19DBA38 Offset: 0x19D7A38 VA: 0x19DBA38 Slot: 84
	public bool ItemReserveCancel(int uuid) { }

	// RVA: 0x19DB91C Offset: 0x19D791C VA: 0x19DB91C
	private bool ItemInvoke(int uuid, bool valid) { }

	// RVA: 0x19DBA40 Offset: 0x19D7A40 VA: 0x19DBA40
	private BonusData localUseItem(int uuid) { }

	// RVA: 0x19DBC08 Offset: 0x19D7C08 VA: 0x19DBC08
	private void InvokeBonusData(BonusData bonus, ReflectionBonusParameter bonusData) { }

	// RVA: 0x19DBCF8 Offset: 0x19D7CF8 VA: 0x19DBCF8 Slot: 90
	public bool EquipItem(ItemDBData.EquipType type, int uuid) { }

	// RVA: 0x19DBE38 Offset: 0x19D7E38 VA: 0x19DBE38 Slot: 86
	public bool ClientEquipItem(ItemDBData.EquipType type, int uuid) { }

	// RVA: 0x19DC238 Offset: 0x19D8238 VA: 0x19DC238 Slot: 87
	public bool PushEquipItem() { }

	// RVA: 0x19DC27C Offset: 0x19D827C VA: 0x19DC27C Slot: 76
	public void OnSetEquipProperties(bool isUpdate, NewArchetypeProperties properties) { }

	// RVA: 0x19DC530 Offset: 0x19D8530 VA: 0x19DC530
	public void EquipPurgeDisableSkill() { }

	// RVA: 0x19DBF68 Offset: 0x19D7F68 VA: 0x19DBF68 Slot: 97
	public void UpdateClientEquipModel() { }

	// RVA: 0x19DC6C4 Offset: 0x19D86C4 VA: 0x19DC6C4
	private void GetItemModel(ItemDBData.EquipType type, out int model, out int color) { }

	// RVA: 0x19DC714 Offset: 0x19D8714 VA: 0x19DC714
	private bool GetAvaterItemModel(ItemDBData.EquipType type, BodyCustomType check, out int model, out int color) { }

	// RVA: 0x19DC79C Offset: 0x19D879C VA: 0x19DC79C
	private void EquipAllPurge() { }

	// RVA: 0x19DC7A4 Offset: 0x19D87A4 VA: 0x19DC7A4 Slot: 89
	public void EquipAllPurge(bool deadUpdate) { }

	// RVA: 0x19DA264 Offset: 0x19D6264 VA: 0x19DA264 Slot: 95
	public void UpdateStatusEquip() { }

	// RVA: 0x19DC8E4 Offset: 0x19D88E4 VA: 0x19DC8E4 Slot: 92
	public void OnChangeState(ArchetypeChangeState response) { }

	// RVA: 0x19DCB80 Offset: 0x19D8B80 VA: 0x19DCB80 Slot: 85
	public void OnSetProperties(NewArchetypeProperties properties) { }

	// RVA: 0x19DCBC4 Offset: 0x19D8BC4 VA: 0x19DCBC4 Slot: 101
	public virtual void OnSkillDelayStandbyOk(SkillReusePermissioneEvent response) { }

	// RVA: 0x19DCBC8 Offset: 0x19D8BC8 VA: 0x19DCBC8 Slot: 33
	protected override bool OnPropertyUpdateStart() { }

	// RVA: 0x19DCBDC Offset: 0x19D8BDC VA: 0x19DCBDC Slot: 36
	protected override void OnPropertyUpdateEnd() { }

	// RVA: 0x19DCD6C Offset: 0x19D8D6C VA: 0x19DCD6C Slot: 37
	protected override void OnPropertyUpdateEndReCheck() { }

	// RVA: 0x19DCDA8 Offset: 0x19D8DA8 VA: 0x19DCDA8 Slot: 27
	public override void StartActionFieldEvent(bool isColl, int actionId) { }

	// RVA: 0x19DCFE8 Offset: 0x19D8FE8 VA: 0x19DCFE8 Slot: 28
	public override void EndActionFieldEvent(int connectionId) { }

	[IteratorStateMachine(typeof(MainPlayer.<CheckStatas>d__141))]
	// RVA: 0x19DAB44 Offset: 0x19D6B44 VA: 0x19DAB44
	private IEnumerator CheckStatas() { }

	// RVA: 0x19DD11C Offset: 0x19D911C VA: 0x19DD11C Slot: 74
	public void OnEnter() { }

	// RVA: 0x19DD49C Offset: 0x19D949C VA: 0x19DD49C Slot: 75
	public void OnLeave() { }

	// RVA: 0x19DD574 Offset: 0x19D9574 VA: 0x19DD574 Slot: 100
	public void FieldDummyLeave() { }

	// RVA: 0x19D889C Offset: 0x19D489C VA: 0x19D889C Slot: 96
	public void UpdateSkillList(Dictionary<short, byte> skill) { }

	// RVA: 0x19DD640 Offset: 0x19D9640 VA: 0x19DD640 Slot: 99
	public void UpdateServerHP(int hp, int exHp) { }

	// RVA: 0x19DD754 Offset: 0x19D9754 VA: 0x19DD754 Slot: 98
	public void UpdateServerMp(int mp, int exMp) { }

	// RVA: 0x19DCB3C Offset: 0x19D8B3C VA: 0x19DCB3C
	private void UpdateServerRespawnTime(float respawnTime, float yellsTime) { }

	// RVA: 0x19DA4F4 Offset: 0x19D64F4 VA: 0x19DA4F4
	private void PlayerDead(bool actDead, int serverHp, int serverMp) { }

	[IteratorStateMachine(typeof(MainPlayer.<WaitEnable>d__150))]
	// RVA: 0x19DD864 Offset: 0x19D9864 VA: 0x19DD864
	private IEnumerator WaitEnable(bool actDead) { }

	// RVA: 0x19DD90C Offset: 0x19D990C VA: 0x19DD90C Slot: 93
	public void PlayerRespawn(int hp, int mp, bool orbRespawn) { }

	[IteratorStateMachine(typeof(MainPlayer.<respawnCheck>d__152))]
	// RVA: 0x19DDA50 Offset: 0x19D9A50 VA: 0x19DDA50
	private IEnumerator respawnCheck(int hp, int mp) { }

	// RVA: 0x19DDAF8 Offset: 0x19D9AF8 VA: 0x19DDAF8
	public void .ctor() { }

	// RVA: 0x19DDB98 Offset: 0x19D9B98 VA: 0x19DDB98 Slot: 70
	private GameObject IMainPlayer.get_gameObject() { }

	// RVA: 0x19DDBA0 Offset: 0x19D9BA0 VA: 0x19DDBA0 Slot: 71
	private Transform IMainPlayer.get_transform() { }
}
