// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaPlayer : PlayerObjectBase, IAutoItemPlayer, IMainPlayer // TypeDefIndex: 1170
{
	// Fields
	private Game engine; // 0x90
	private Coroutine checkStatusCoroutine; // 0x98
	private const float BaseItemDelay = 10;
	private float itemDelay; // 0xA0
	private float nowItemDelayTime; // 0xA4
	private bool isFirstEnterFieldRayCheck; // 0xA8
	private float routineConnectTime; // 0xAC
	private float mobRoutineConnectTime; // 0xB0
	private float routineConnectTimeInterval; // 0xB4
	private readonly float mobRoutineConnectTimeInterval; // 0xB8
	private bool enableRoutineConnect; // 0xBC
	private NewArchetypeProperties serverProperty; // 0xC0
	private float updateStatusTimer; // 0xC8
	private const float updateStatusTime = 3;
	private GhostPlayer ghostPlayer; // 0xD0
	[CompilerGenerated]
	private PlayerStatusBase <PlayerStatus>k__BackingField; // 0xD8
	[CompilerGenerated]
	private MobaItemManager <MobaItemManaer>k__BackingField; // 0xE0
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
	private MobBuffManager <MobBuffManager>k__BackingField; // 0x168
	[CompilerGenerated]
	private MobaTreasureBonusManager <TreasureBonusManager>k__BackingField; // 0x170
	[CompilerGenerated]
	private MobaDuelAbilityManager <DuelAbilityManager>k__BackingField; // 0x178
	[CompilerGenerated]
	private TradeManager <TradeManager>k__BackingField; // 0x180
	[CompilerGenerated]
	private string <PlayerParameterName>k__BackingField; // 0x188
	public bool IsPriorityTargetPlayer; // 0x190
	[CompilerGenerated]
	private bool <IsFieldAction>k__BackingField; // 0x191
	private IPlayerControl _playerControl; // 0x198

	// Properties
	public PlayerStatusBase PlayerStatus { get; set; }
	public MobaItemManager MobaItemManaer { get; set; }
	public ItemManager ItemManager { get; }
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
	public MobBuffManager MobBuffManager { get; set; }
	public MobaTreasureBonusManager TreasureBonusManager { get; set; }
	public MobaDuelAbilityManager DuelAbilityManager { get; set; }
	public TradeManager TradeManager { get; set; }
	public IPlayerControl PlayerControl { get; }
	public override bool IsGhost { get; }
	public byte PlayerParameterId { get; }
	public string PlayerParameterName { get; set; }
	public float ItemDelayTime { get; }
	public float ItemDelayPercent { get; }
	public NewArchetypeProperties Properties { get; }
	public bool IsUseSignBoard { get; }
	public bool IsTargettingSearchPlayer { get; }
	public bool IsFieldAction { get; set; }

	// Methods

	// RVA: 0x1F72F9C Offset: 0x1F6EF9C VA: 0x1F72F9C
	public static MobaPlayer CreatePlayer(Game engine, int id, string userName) { }

	[CompilerGenerated]
	// RVA: 0x1F73B64 Offset: 0x1F6FB64 VA: 0x1F73B64 Slot: 45
	public PlayerStatusBase get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x1F73B6C Offset: 0x1F6FB6C VA: 0x1F73B6C
	private void set_PlayerStatus(PlayerStatusBase value) { }

	[CompilerGenerated]
	// RVA: 0x1F73B74 Offset: 0x1F6FB74 VA: 0x1F73B74
	public MobaItemManager get_MobaItemManaer() { }

	[CompilerGenerated]
	// RVA: 0x1F73B7C Offset: 0x1F6FB7C VA: 0x1F73B7C
	private void set_MobaItemManaer(MobaItemManager value) { }

	// RVA: 0x1F73B84 Offset: 0x1F6FB84 VA: 0x1F73B84 Slot: 46
	public ItemManager get_ItemManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73B8C Offset: 0x1F6FB8C VA: 0x1F73B8C Slot: 47
	public AutoItemManager get_AutoItemManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73B94 Offset: 0x1F6FB94 VA: 0x1F73B94
	private void set_AutoItemManager(AutoItemManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F73B9C Offset: 0x1F6FB9C VA: 0x1F73B9C Slot: 48
	public SkillManager get_SkillManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73BA4 Offset: 0x1F6FBA4 VA: 0x1F73BA4
	private void set_SkillManager(SkillManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F73BAC Offset: 0x1F6FBAC VA: 0x1F73BAC Slot: 49
	public SkillBufferManager get_SkillBufferManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73BB4 Offset: 0x1F6FBB4 VA: 0x1F73BB4
	private void set_SkillBufferManager(SkillBufferManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F73BBC Offset: 0x1F6FBBC VA: 0x1F73BBC Slot: 50
	public BonusManager get_BonusManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73BC4 Offset: 0x1F6FBC4 VA: 0x1F73BC4
	private void set_BonusManager(BonusManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F73BD4 Offset: 0x1F6FBD4 VA: 0x1F73BD4 Slot: 51
	public AbnormalStateManager get_AbnormalStateManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73BDC Offset: 0x1F6FBDC VA: 0x1F73BDC
	private void set_AbnormalStateManager(AbnormalStateManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F73BEC Offset: 0x1F6FBEC VA: 0x1F73BEC Slot: 52
	public BufferEffectManager get_BufferEffectManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73BF4 Offset: 0x1F6FBF4 VA: 0x1F73BF4
	private void set_BufferEffectManager(BufferEffectManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F73C04 Offset: 0x1F6FC04 VA: 0x1F73C04 Slot: 53
	public EquipBuffManager get_EquipBuffManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73C0C Offset: 0x1F6FC0C VA: 0x1F73C0C
	private void set_EquipBuffManager(EquipBuffManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F73C1C Offset: 0x1F6FC1C VA: 0x1F73C1C Slot: 54
	public StarGemManager get_StarGemManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73C24 Offset: 0x1F6FC24 VA: 0x1F73C24
	private void set_StarGemManager(StarGemManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F73C34 Offset: 0x1F6FC34 VA: 0x1F73C34 Slot: 55
	public RegistletManager get_RegistletManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73C3C Offset: 0x1F6FC3C VA: 0x1F73C3C
	private void set_RegistletManager(RegistletManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F73C4C Offset: 0x1F6FC4C VA: 0x1F73C4C Slot: 56
	public GemCartBufferManager get_GemCartBufManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73C54 Offset: 0x1F6FC54 VA: 0x1F73C54
	private void set_GemCartBufManager(GemCartBufferManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F73C64 Offset: 0x1F6FC64 VA: 0x1F73C64 Slot: 57
	public ItemRandomPropertyManager get_ItemRandomPropertyManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73C6C Offset: 0x1F6FC6C VA: 0x1F73C6C
	private void set_ItemRandomPropertyManager(ItemRandomPropertyManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F73C7C Offset: 0x1F6FC7C VA: 0x1F73C7C Slot: 58
	public ProficiencyManager get_ProficiencyManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73C84 Offset: 0x1F6FC84 VA: 0x1F73C84
	private void set_ProficiencyManager(ProficiencyManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F73C94 Offset: 0x1F6FC94 VA: 0x1F73C94 Slot: 59
	public SkillComboManager get_SkillComboManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73C9C Offset: 0x1F6FC9C VA: 0x1F73C9C
	private void set_SkillComboManager(SkillComboManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F73CAC Offset: 0x1F6FCAC VA: 0x1F73CAC Slot: 60
	public EffectPlayer get_EffectPlayer() { }

	[CompilerGenerated]
	// RVA: 0x1F73CB4 Offset: 0x1F6FCB4 VA: 0x1F73CB4
	private void set_EffectPlayer(EffectPlayer value) { }

	[CompilerGenerated]
	// RVA: 0x1F73CC4 Offset: 0x1F6FCC4 VA: 0x1F73CC4 Slot: 61
	public EmotionPlayer get_EmotionPlayer() { }

	[CompilerGenerated]
	// RVA: 0x1F73CCC Offset: 0x1F6FCCC VA: 0x1F73CCC
	private void set_EmotionPlayer(EmotionPlayer value) { }

	[CompilerGenerated]
	// RVA: 0x1F73CDC Offset: 0x1F6FCDC VA: 0x1F73CDC Slot: 63
	public ExSkillManager get_ExSkillManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73CE4 Offset: 0x1F6FCE4 VA: 0x1F73CE4
	private void set_ExSkillManager(ExSkillManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F73CF4 Offset: 0x1F6FCF4 VA: 0x1F73CF4
	public MobBuffManager get_MobBuffManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73CFC Offset: 0x1F6FCFC VA: 0x1F73CFC
	private void set_MobBuffManager(MobBuffManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F73D0C Offset: 0x1F6FD0C VA: 0x1F73D0C
	public MobaTreasureBonusManager get_TreasureBonusManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73D14 Offset: 0x1F6FD14 VA: 0x1F73D14
	private void set_TreasureBonusManager(MobaTreasureBonusManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F73D24 Offset: 0x1F6FD24 VA: 0x1F73D24
	public MobaDuelAbilityManager get_DuelAbilityManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73D2C Offset: 0x1F6FD2C VA: 0x1F73D2C
	private void set_DuelAbilityManager(MobaDuelAbilityManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F73D3C Offset: 0x1F6FD3C VA: 0x1F73D3C Slot: 64
	public TradeManager get_TradeManager() { }

	[CompilerGenerated]
	// RVA: 0x1F73D44 Offset: 0x1F6FD44 VA: 0x1F73D44
	private void set_TradeManager(TradeManager value) { }

	// RVA: 0x1F73D54 Offset: 0x1F6FD54 VA: 0x1F73D54
	public IPlayerControl get_PlayerControl() { }

	// RVA: 0x1F73DE0 Offset: 0x1F6FDE0 VA: 0x1F73DE0 Slot: 38
	public override bool get_IsGhost() { }

	// RVA: 0x1F73DE8 Offset: 0x1F6FDE8 VA: 0x1F73DE8
	public byte get_PlayerParameterId() { }

	[CompilerGenerated]
	// RVA: 0x1F73DF0 Offset: 0x1F6FDF0 VA: 0x1F73DF0
	public string get_PlayerParameterName() { }

	[CompilerGenerated]
	// RVA: 0x1F73DF8 Offset: 0x1F6FDF8 VA: 0x1F73DF8
	private void set_PlayerParameterName(string value) { }

	// RVA: 0x1F73E08 Offset: 0x1F6FE08 VA: 0x1F73E08 Slot: 78
	public float get_ItemDelayTime() { }

	// RVA: 0x1F73E10 Offset: 0x1F6FE10 VA: 0x1F73E10 Slot: 79
	public float get_ItemDelayPercent() { }

	// RVA: 0x1F73E1C Offset: 0x1F6FE1C VA: 0x1F73E1C Slot: 62
	public NewArchetypeProperties get_Properties() { }

	// RVA: 0x1F73E24 Offset: 0x1F6FE24 VA: 0x1F73E24 Slot: 81
	public bool get_IsUseSignBoard() { }

	// RVA: 0x1F73E2C Offset: 0x1F6FE2C VA: 0x1F73E2C
	public bool get_IsTargettingSearchPlayer() { }

	[CompilerGenerated]
	// RVA: 0x1F73EB4 Offset: 0x1F6FEB4 VA: 0x1F73EB4 Slot: 69
	public bool get_IsFieldAction() { }

	[CompilerGenerated]
	// RVA: 0x1F73EBC Offset: 0x1F6FEBC VA: 0x1F73EBC
	private void set_IsFieldAction(bool value) { }

	// RVA: 0x1F730A0 Offset: 0x1F6F0A0 VA: 0x1F730A0
	private void Initialize(int id, string userName) { }

	// RVA: 0x1F7441C Offset: 0x1F7041C VA: 0x1F7441C Slot: 72
	public bool ConnectUpdate(PacketBase updatePacketBaseData) { }

	// RVA: 0x1F75424 Offset: 0x1F71424 VA: 0x1F75424 Slot: 73
	public void ConnectUpdate(int serverFPS, Dictionary<byte, object> newProperties, IItemBagData itemBagData, IStatusData statusData, IGuildBufferData guildBufferData, IParamData paramData, IHouseBufferData houseData) { }

	// RVA: 0x1F75434 Offset: 0x1F71434 VA: 0x1F75434
	private void Update() { }

	// RVA: 0x1F7565C Offset: 0x1F7165C VA: 0x1F7565C
	private void LateUpdate() { }

	// RVA: 0x1F758E8 Offset: 0x1F718E8 VA: 0x1F758E8 Slot: 41
	protected override byte[] GetSignboardBinary() { }

	// RVA: 0x1F75900 Offset: 0x1F71900 VA: 0x1F75900 Slot: 94
	public bool UseItem(int uuid, bool isAutoUse) { }

	// RVA: 0x1F75908 Offset: 0x1F71908 VA: 0x1F75908
	public bool UseMobaItemBuffer(int uuid, int gold) { }

	// RVA: 0x1F76200 Offset: 0x1F72200 VA: 0x1F76200 Slot: 82
	public void CalcItemDelay(float time, bool bonus) { }

	// RVA: 0x1F762A8 Offset: 0x1F722A8 VA: 0x1F762A8 Slot: 83
	public bool ItemInvoke(int uuid) { }

	// RVA: 0x1F762B0 Offset: 0x1F722B0 VA: 0x1F762B0 Slot: 84
	public bool ItemReserveCancel(int uuid) { }

	// RVA: 0x1F762B8 Offset: 0x1F722B8 VA: 0x1F762B8
	private void InvokeBonusData(BonusData bonus, ReflectionBonusParameter bonusData) { }

	// RVA: 0x1F7636C Offset: 0x1F7236C VA: 0x1F7636C Slot: 90
	public bool EquipItem(ItemDBData.EquipType type, int uuid) { }

	// RVA: 0x1F76374 Offset: 0x1F72374 VA: 0x1F76374 Slot: 86
	public bool ClientEquipItem(ItemDBData.EquipType type, int uuid) { }

	// RVA: 0x1F7637C Offset: 0x1F7237C VA: 0x1F7637C Slot: 87
	public bool PushEquipItem() { }

	// RVA: 0x1F76384 Offset: 0x1F72384 VA: 0x1F76384 Slot: 76
	public void OnSetEquipProperties(bool isUpdate, NewArchetypeProperties properties) { }

	// RVA: 0x1F7663C Offset: 0x1F7263C VA: 0x1F7663C
	public void EquipPurgeDisableSkill() { }

	// RVA: 0x1F767D0 Offset: 0x1F727D0 VA: 0x1F767D0 Slot: 97
	public void UpdateClientEquipModel() { }

	// RVA: 0x1F768AC Offset: 0x1F728AC VA: 0x1F768AC
	private void GetItemModel(ItemDBData.EquipType type, out int model, out int color) { }

	// RVA: 0x1F768FC Offset: 0x1F728FC VA: 0x1F768FC
	private void EquipAllPurge() { }

	// RVA: 0x1F76904 Offset: 0x1F72904 VA: 0x1F76904 Slot: 89
	public void EquipAllPurge(bool deadUpdate) { }

	// RVA: 0x1F74DE8 Offset: 0x1F70DE8 VA: 0x1F74DE8 Slot: 95
	public void UpdateStatusEquip() { }

	// RVA: 0x1F76A48 Offset: 0x1F72A48 VA: 0x1F76A48 Slot: 92
	public void OnChangeState(ArchetypeChangeState response) { }

	// RVA: 0x1F76D64 Offset: 0x1F72D64 VA: 0x1F76D64 Slot: 85
	public void OnSetProperties(NewArchetypeProperties properties) { }

	// RVA: 0x1F76DA8 Offset: 0x1F72DA8 VA: 0x1F76DA8 Slot: 101
	public virtual void OnSkillDelayStandbyOk(SkillReusePermissioneEvent response) { }

	// RVA: 0x1F76DAC Offset: 0x1F72DAC VA: 0x1F76DAC Slot: 33
	protected override bool OnPropertyUpdateStart() { }

	// RVA: 0x1F76DC0 Offset: 0x1F72DC0 VA: 0x1F76DC0 Slot: 36
	protected override void OnPropertyUpdateEnd() { }

	[IteratorStateMachine(typeof(MobaPlayer.<CheckStatas>d__162))]
	// RVA: 0x1F753B8 Offset: 0x1F713B8 VA: 0x1F753B8
	private IEnumerator CheckStatas() { }

	// RVA: 0x1F770A4 Offset: 0x1F730A4 VA: 0x1F770A4 Slot: 74
	public void OnEnter() { }

	// RVA: 0x1F771D8 Offset: 0x1F731D8 VA: 0x1F771D8 Slot: 75
	public void OnLeave() { }

	// RVA: 0x1F772FC Offset: 0x1F732FC VA: 0x1F772FC Slot: 100
	public void FieldDummyLeave() { }

	// RVA: 0x1F77300 Offset: 0x1F73300 VA: 0x1F77300 Slot: 27
	public override void StartActionFieldEvent(bool isColl, int actionId) { }

	// RVA: 0x1F775C0 Offset: 0x1F735C0 VA: 0x1F775C0 Slot: 28
	public override void EndActionFieldEvent(int connectionId) { }

	// RVA: 0x1F777A0 Offset: 0x1F737A0 VA: 0x1F777A0
	public bool ConnectionUpdateStatus(PrimaryStatusData data) { }

	// RVA: 0x1F740FC Offset: 0x1F700FC VA: 0x1F740FC Slot: 96
	public void UpdateSkillList(Dictionary<short, byte> skill) { }

	// RVA: 0x1F77B0C Offset: 0x1F73B0C VA: 0x1F77B0C Slot: 99
	public void UpdateServerHP(int hp, int exHp) { }

	// RVA: 0x1F77C20 Offset: 0x1F73C20 VA: 0x1F77C20 Slot: 98
	public void UpdateServerMp(int mp, int exMp) { }

	// RVA: 0x1F74310 Offset: 0x1F70310 VA: 0x1F74310
	private void UpdateServerRespawnTime(float respawnTime, float yellsTime) { }

	// RVA: 0x1F77D30 Offset: 0x1F73D30 VA: 0x1F77D30
	public void PlayerDeadToGhost() { }

	// RVA: 0x1F77E8C Offset: 0x1F73E8C VA: 0x1F77E8C
	public bool PlayerGhostToRevival() { }

	// RVA: 0x1F750EC Offset: 0x1F710EC VA: 0x1F750EC
	private void PlayerDead(bool actDead, int serverHp, int serverMp, int state) { }

	// RVA: 0x1F78004 Offset: 0x1F74004 VA: 0x1F78004 Slot: 93
	public void PlayerRespawn(int hp, int mp, bool orbRespawn) { }

	[IteratorStateMachine(typeof(MobaPlayer.<respawnCheck>d__177))]
	// RVA: 0x1F7819C Offset: 0x1F7419C VA: 0x1F7819C
	private IEnumerator respawnCheck(int hp, int mp) { }

	[IteratorStateMachine(typeof(MobaPlayer.<VsModeRespawn>d__178))]
	// RVA: 0x1F76CE4 Offset: 0x1F72CE4 VA: 0x1F76CE4
	private IEnumerator VsModeRespawn(int hp, int mp) { }

	// RVA: 0x1F7826C Offset: 0x1F7426C VA: 0x1F7826C
	public void .ctor() { }

	// RVA: 0x1F78284 Offset: 0x1F74284 VA: 0x1F78284 Slot: 70
	private GameObject IMainPlayer.get_gameObject() { }

	// RVA: 0x1F7828C Offset: 0x1F7428C VA: 0x1F7828C Slot: 71
	private Transform IMainPlayer.get_transform() { }
}
