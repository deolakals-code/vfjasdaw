// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PlayerDataManager : MonoBehaviour, IAvatarListener, ISceneChangeManager // TypeDefIndex: 1458
{
	// Fields
	private static GameObject _mainObj; // 0x0
	private static PlayerDataManager _manager; // 0x8
	[CompilerGenerated]
	private static bool <IsSkillCalc>k__BackingField; // 0x10
	private Game engine; // 0x20
	private int activeParamId; // 0x28
	private bool isControlLock; // 0x2C
	private NewArchetypeProperties clientArchetypeProperties; // 0x30
	private int laodFamiliarServant; // 0x38
	private bool isFirstEnterFieldRayCheck; // 0x3C
	private Vector3 setInitPos; // 0x40
	private float setInitRot; // 0x4C
	private ArchetypeUid archetypeUid; // 0x50
	private string userName; // 0x58
	private IMainPlayer activePlayer; // 0x60
	[CompilerGenerated]
	private string <PlayerParameterName>k__BackingField; // 0x68
	[CompilerGenerated]
	private AutoMemberManager <AutoMemberManager>k__BackingField; // 0x70
	[CompilerGenerated]
	private MobRangeAttackCollection <MobRangeCollection>k__BackingField; // 0x78
	[CompilerGenerated]
	private PetDataManager <PetDataManager>k__BackingField; // 0x80
	[CompilerGenerated]
	private MobaDataManager <MobaDataManager>k__BackingField; // 0x88
	[CompilerGenerated]
	private bool <IsMoDeadLeave>k__BackingField; // 0x90

	// Properties
	public static bool IsSkillCalc { get; set; }
	public GameObject gameObject { get; }
	public Transform transform { get; }
	public ArchetypeUid ArchetypeUid { get; }
	public string UserName { get; }
	public NewArchetypeProperties PlayerProperties { get; }
	public bool IsMan { get; }
	public bool IsManAnimation { get; }
	public bool IsFieldAction { get; }
	public int PlayerArchetypeId { get; }
	public byte PlayerArchetypeType { get; }
	public byte PlayerParameterId { get; }
	public string PlayerParameterName { get; set; }
	public PlayerActionManagerBase PlayerActionManager { get; }
	public EmotionPlayer EmotionPlayer { get; }
	public EffectPlayer EffectPlayer { get; }
	public CharacterMove CharacterMove { get; }
	public bool IsMerging { get; }
	public float PlayerHeight { get; }
	public PlayerStatusBase PlayerStatus { get; }
	public ItemManager ItemManager { get; }
	public AutoItemManager AutoItemManager { get; }
	public SkillManager SkillManager { get; }
	public SkillBufferManager SkillBufferManager { get; }
	public QuestManager QuestManager { get; }
	public BonusManager BonusManager { get; }
	public AbnormalStateManager AbnormalStateManager { get; }
	public BufferEffectManager BufferEffectManager { get; }
	public EquipBuffManager EquipBuffManager { get; }
	public StarGemManager StarGemManager { get; }
	public RegistletManager RegistletManager { get; }
	public GemCartBufferManager GemCartBufManager { get; }
	public ItemRandomPropertyManager RandomPropertyManager { get; }
	public FriendManager FriendManager { get; }
	public GuardActionManager GuardActionManager { get; }
	public AvoidActionManager AvoidActionManager { get; }
	public GuildManager GuildManager { get; }
	public MaterialManager MaterialManager { get; }
	public ProficiencyManager ProficiencyManager { get; }
	public StampManager StampManager { get; }
	public AutoMemberManager AutoMemberManager { get; set; }
	public MobRangeAttackCollection MobRangeCollection { get; set; }
	public SkillComboManager SkillComboManager { get; }
	public BanManager BanManager { get; }
	public bool IsControlLock { get; }
	public float ItemDelayTime { get; }
	public float ItemDelayPercent { get; }
	public MiniMailManager MiniMailManager { get; }
	public PetDataManager PetDataManager { get; set; }
	public WorldTreasureManager WorldTreasureManager { get; }
	public MobaDataManager MobaDataManager { get; set; }
	public ExSkillManager ExSkillManager { get; }
	public TradeManager TradeManager { get; }
	public bool IsGMEventPlayer { get; }
	public bool IsUseSignBoard { get; }
	public bool IsHideUser { get; }
	public bool IsMoDeadLeave { get; set; }

	// Methods

	// RVA: 0x204481C Offset: 0x204081C VA: 0x204481C
	public static GameObject FindPlayer() { }

	// RVA: 0x2044834 Offset: 0x2040834 VA: 0x2044834
	public static PlayerDataManager GetPlayerDataManager() { }

	[CompilerGenerated]
	// RVA: 0x2044A54 Offset: 0x2040A54 VA: 0x2044A54
	public static bool get_IsSkillCalc() { }

	[CompilerGenerated]
	// RVA: 0x2044A9C Offset: 0x2040A9C VA: 0x2044A9C
	public static void set_IsSkillCalc(bool value) { }

	// RVA: 0x20449A4 Offset: 0x20409A4 VA: 0x20449A4
	public GameObject get_gameObject() { }

	// RVA: 0x2044AEC Offset: 0x2040AEC VA: 0x2044AEC
	public Transform get_transform() { }

	// RVA: 0x2044B9C Offset: 0x2040B9C VA: 0x2044B9C
	public GameObject ClonePlayer() { }

	// RVA: 0x2044C40 Offset: 0x2040C40 VA: 0x2044C40
	public ArchetypeUid get_ArchetypeUid() { }

	// RVA: 0x2044C48 Offset: 0x2040C48 VA: 0x2044C48
	public string get_UserName() { }

	// RVA: 0x2044D14 Offset: 0x2040D14 VA: 0x2044D14
	public NewArchetypeProperties get_PlayerProperties() { }

	// RVA: 0x2044DC4 Offset: 0x2040DC4 VA: 0x2044DC4
	public bool get_IsMan() { }

	// RVA: 0x2044E74 Offset: 0x2040E74 VA: 0x2044E74
	public bool get_IsManAnimation() { }

	// RVA: 0x2044F24 Offset: 0x2040F24 VA: 0x2044F24
	public bool get_IsFieldAction() { }

	// RVA: 0x2044FD4 Offset: 0x2040FD4 VA: 0x2044FD4
	public int get_PlayerArchetypeId() { }

	// RVA: 0x2044FF4 Offset: 0x2040FF4 VA: 0x2044FF4
	public byte get_PlayerArchetypeType() { }

	// RVA: 0x2045014 Offset: 0x2041014 VA: 0x2045014
	public byte get_PlayerParameterId() { }

	[CompilerGenerated]
	// RVA: 0x2045024 Offset: 0x2041024 VA: 0x2045024
	public string get_PlayerParameterName() { }

	[CompilerGenerated]
	// RVA: 0x204502C Offset: 0x204102C VA: 0x204502C
	private void set_PlayerParameterName(string value) { }

	// RVA: 0x2045034 Offset: 0x2041034 VA: 0x2045034
	public PlayerActionManagerBase get_PlayerActionManager() { }

	// RVA: 0x20450E0 Offset: 0x20410E0 VA: 0x20450E0
	public EmotionPlayer get_EmotionPlayer() { }

	// RVA: 0x2045190 Offset: 0x2041190 VA: 0x2045190
	public EffectPlayer get_EffectPlayer() { }

	// RVA: 0x2045240 Offset: 0x2041240 VA: 0x2045240
	public CharacterMove get_CharacterMove() { }

	// RVA: 0x20452F0 Offset: 0x20412F0 VA: 0x20452F0
	public bool get_IsMerging() { }

	// RVA: 0x20453A0 Offset: 0x20413A0 VA: 0x20453A0
	public float get_PlayerHeight() { }

	// RVA: 0x2045450 Offset: 0x2041450 VA: 0x2045450
	public PlayerStatusBase get_PlayerStatus() { }

	// RVA: 0x2045500 Offset: 0x2041500 VA: 0x2045500
	public ItemManager get_ItemManager() { }

	// RVA: 0x20455B0 Offset: 0x20415B0 VA: 0x20455B0
	public AutoItemManager get_AutoItemManager() { }

	// RVA: 0x2045660 Offset: 0x2041660 VA: 0x2045660
	public SkillManager get_SkillManager() { }

	// RVA: 0x2045710 Offset: 0x2041710 VA: 0x2045710
	public SkillBufferManager get_SkillBufferManager() { }

	// RVA: 0x20457C0 Offset: 0x20417C0 VA: 0x20457C0
	public QuestManager get_QuestManager() { }

	// RVA: 0x2045810 Offset: 0x2041810 VA: 0x2045810
	public BonusManager get_BonusManager() { }

	// RVA: 0x20458C0 Offset: 0x20418C0 VA: 0x20458C0
	public AbnormalStateManager get_AbnormalStateManager() { }

	// RVA: 0x2045970 Offset: 0x2041970 VA: 0x2045970
	public BufferEffectManager get_BufferEffectManager() { }

	// RVA: 0x2045A20 Offset: 0x2041A20 VA: 0x2045A20
	public EquipBuffManager get_EquipBuffManager() { }

	// RVA: 0x2045AD0 Offset: 0x2041AD0 VA: 0x2045AD0
	public StarGemManager get_StarGemManager() { }

	// RVA: 0x2045B80 Offset: 0x2041B80 VA: 0x2045B80
	public RegistletManager get_RegistletManager() { }

	// RVA: 0x2045C30 Offset: 0x2041C30 VA: 0x2045C30
	public GemCartBufferManager get_GemCartBufManager() { }

	// RVA: 0x2045CE0 Offset: 0x2041CE0 VA: 0x2045CE0
	public ItemRandomPropertyManager get_RandomPropertyManager() { }

	// RVA: 0x2045D90 Offset: 0x2041D90 VA: 0x2045D90
	public FriendManager get_FriendManager() { }

	// RVA: 0x2045DE0 Offset: 0x2041DE0 VA: 0x2045DE0
	public GuardActionManager get_GuardActionManager() { }

	// RVA: 0x2045EB4 Offset: 0x2041EB4 VA: 0x2045EB4
	public AvoidActionManager get_AvoidActionManager() { }

	// RVA: 0x2045F88 Offset: 0x2041F88 VA: 0x2045F88
	public GuildManager get_GuildManager() { }

	// RVA: 0x2045FD8 Offset: 0x2041FD8 VA: 0x2045FD8
	public MaterialManager get_MaterialManager() { }

	// RVA: 0x2046028 Offset: 0x2042028 VA: 0x2046028
	public ProficiencyManager get_ProficiencyManager() { }

	// RVA: 0x20460D8 Offset: 0x20420D8 VA: 0x20460D8
	public StampManager get_StampManager() { }

	[CompilerGenerated]
	// RVA: 0x2046128 Offset: 0x2042128 VA: 0x2046128
	public AutoMemberManager get_AutoMemberManager() { }

	[CompilerGenerated]
	// RVA: 0x2046130 Offset: 0x2042130 VA: 0x2046130
	private void set_AutoMemberManager(AutoMemberManager value) { }

	[CompilerGenerated]
	// RVA: 0x2046138 Offset: 0x2042138 VA: 0x2046138
	public MobRangeAttackCollection get_MobRangeCollection() { }

	[CompilerGenerated]
	// RVA: 0x2046140 Offset: 0x2042140 VA: 0x2046140
	private void set_MobRangeCollection(MobRangeAttackCollection value) { }

	// RVA: 0x2046148 Offset: 0x2042148 VA: 0x2046148
	public SkillComboManager get_SkillComboManager() { }

	// RVA: 0x20461F8 Offset: 0x20421F8 VA: 0x20461F8
	public BanManager get_BanManager() { }

	// RVA: 0x2046248 Offset: 0x2042248 VA: 0x2046248
	public bool get_IsControlLock() { }

	// RVA: 0x2046250 Offset: 0x2042250 VA: 0x2046250
	public float get_ItemDelayTime() { }

	// RVA: 0x2046300 Offset: 0x2042300 VA: 0x2046300
	public float get_ItemDelayPercent() { }

	// RVA: 0x20463B0 Offset: 0x20423B0 VA: 0x20463B0
	public MiniMailManager get_MiniMailManager() { }

	[CompilerGenerated]
	// RVA: 0x2046400 Offset: 0x2042400 VA: 0x2046400
	public PetDataManager get_PetDataManager() { }

	[CompilerGenerated]
	// RVA: 0x2046408 Offset: 0x2042408 VA: 0x2046408
	private void set_PetDataManager(PetDataManager value) { }

	// RVA: 0x2046410 Offset: 0x2042410 VA: 0x2046410
	public WorldTreasureManager get_WorldTreasureManager() { }

	[CompilerGenerated]
	// RVA: 0x2046460 Offset: 0x2042460 VA: 0x2046460
	public MobaDataManager get_MobaDataManager() { }

	[CompilerGenerated]
	// RVA: 0x2046468 Offset: 0x2042468 VA: 0x2046468
	private void set_MobaDataManager(MobaDataManager value) { }

	// RVA: 0x2046470 Offset: 0x2042470 VA: 0x2046470
	public ExSkillManager get_ExSkillManager() { }

	// RVA: 0x2046520 Offset: 0x2042520 VA: 0x2046520
	public TradeManager get_TradeManager() { }

	// RVA: 0x20465D0 Offset: 0x20425D0 VA: 0x20465D0
	public bool get_IsGMEventPlayer() { }

	// RVA: 0x2046680 Offset: 0x2042680 VA: 0x2046680
	public bool get_IsUseSignBoard() { }

	// RVA: 0x2046730 Offset: 0x2042730 VA: 0x2046730
	public bool get_IsHideUser() { }

	[CompilerGenerated]
	// RVA: 0x20467F0 Offset: 0x20427F0 VA: 0x20467F0
	public bool get_IsMoDeadLeave() { }

	[CompilerGenerated]
	// RVA: 0x20467F8 Offset: 0x20427F8 VA: 0x20467F8
	private void set_IsMoDeadLeave(bool value) { }

	// RVA: 0x2046804 Offset: 0x2042804 VA: 0x2046804
	protected void Awake() { }

	// RVA: 0x204699C Offset: 0x204299C VA: 0x204699C
	public void InitPlayerData(Game game, int archetypeId, string userName) { }

	// RVA: 0x2046FC0 Offset: 0x2042FC0 VA: 0x2046FC0
	public SignboardPropertyData GetUpdateSignboard() { }

	// RVA: 0x2047064 Offset: 0x2043064 VA: 0x2047064
	public void Initialize(Game game, MobaAvatarData mobaData) { }

	// RVA: 0x2047110 Offset: 0x2043110 VA: 0x2047110
	public void Initialize(Game game, int id, string userName, int serverFPS, Dictionary<byte, object> newProperties, IItemBagData itemBagData, IStatusData statusData, IGuildBufferData guildBufferData, IParamData paramData, IHouseBufferData houseData) { }

	// RVA: 0x204735C Offset: 0x204335C VA: 0x204735C
	public void CheckItemBagFull(byte itemDataType) { }

	// RVA: 0x20474AC Offset: 0x20434AC VA: 0x20474AC
	public void CheckItemBagFull() { }

	// RVA: 0x204740C Offset: 0x204340C VA: 0x204740C
	public void UpdateItemBag() { }

	// RVA: 0x20474F8 Offset: 0x20434F8 VA: 0x20474F8
	public void SetControlLock(bool flag) { }

	// RVA: 0x2046E1C Offset: 0x2042E1C VA: 0x2046E1C
	public void SetEnterPlayerTransform(Vector3 pos, float rot) { }

	// RVA: 0x2047504 Offset: 0x2043504 VA: 0x2047504 Slot: 21
	public void OnEnter() { }

	// RVA: 0x204761C Offset: 0x204361C VA: 0x204761C
	public void FieldDummyLeave() { }

	// RVA: 0x20476C8 Offset: 0x20436C8 VA: 0x20476C8 Slot: 22
	public void OnLeave() { }

	// RVA: 0x204779C Offset: 0x204379C VA: 0x204779C
	public void EquipAllPurge(bool deadUpdate) { }

	// RVA: 0x2047848 Offset: 0x2043848 VA: 0x2047848
	public void UpdateStatusEquip() { }

	// RVA: 0x20478EC Offset: 0x20438EC VA: 0x20478EC
	public void StatusUp(PrimaryStatusData status) { }

	// RVA: 0x20479AC Offset: 0x20439AC VA: 0x20479AC Slot: 5
	public void OnStatusUp(StatusUpResponse response) { }

	// RVA: 0x2047BCC Offset: 0x2043BCC VA: 0x2047BCC
	public void UpdateGameStatus(GameStatusData gameStatus) { }

	// RVA: 0x2047D4C Offset: 0x2043D4C VA: 0x2047D4C
	public void UpdateSkillList(Dictionary<short, byte> skill) { }

	// RVA: 0x2047DF8 Offset: 0x2043DF8 VA: 0x2047DF8
	public void DeterminePersonality(PersonalityType type) { }

	// RVA: 0x2047EAC Offset: 0x2043EAC VA: 0x2047EAC
	public void CompensationStatusReset(byte num) { }

	// RVA: 0x2047FF4 Offset: 0x2043FF4 VA: 0x2047FF4
	public void CompensationPersonalityReset(byte num) { }

	// RVA: 0x204813C Offset: 0x204413C VA: 0x204813C
	public void UpdateSkillPoint(int point) { }

	// RVA: 0x2048160 Offset: 0x2044160 VA: 0x2048160
	public void UpdateStatusPoint(int point) { }

	// RVA: 0x2047A54 Offset: 0x2043A54 VA: 0x2047A54
	public void UpdateServerHP(int hp, int exHp) { }

	// RVA: 0x2047B10 Offset: 0x2043B10 VA: 0x2047B10
	public void UpdateServerMp(int mp, int exMp) { }

	// RVA: 0x2048184 Offset: 0x2044184 VA: 0x2048184
	public void UpdateServerRespawnTime(float respawnTime, float yellsTime) { }

	// RVA: 0x20481D0 Offset: 0x20441D0 VA: 0x20481D0 Slot: 10
	public void OnChangeState(ArchetypeChangeState response) { }

	// RVA: 0x204827C Offset: 0x204427C VA: 0x204827C
	public void PlayerRespawn(int hp, int mp, bool orbRespawn) { }

	// RVA: 0x2048340 Offset: 0x2044340 VA: 0x2048340
	public bool CheckPlayerAnnihilated() { }

	// RVA: 0x20484F8 Offset: 0x20444F8 VA: 0x20484F8
	public bool UseItem(int uuid, bool isAutoUse) { }

	// RVA: 0x20485B4 Offset: 0x20445B4 VA: 0x20485B4
	public void CalcItemDelay(float time, bool bonus) { }

	// RVA: 0x2048670 Offset: 0x2044670 VA: 0x2048670
	public bool ItemInvoke(int uuid) { }

	// RVA: 0x204871C Offset: 0x204471C VA: 0x204871C
	public bool ItemReserveCancel(int uuid) { }

	// RVA: 0x20487C8 Offset: 0x20447C8 VA: 0x20487C8
	public bool DiscardItem(int uuid) { }

	// RVA: 0x20488A0 Offset: 0x20448A0 VA: 0x20488A0
	public bool LockItem(ItemDataTypev2 type, int uuid, bool lockFlag) { }

	// RVA: 0x2048914 Offset: 0x2044914 VA: 0x2048914
	public bool FavoriteItem(ItemDataTypev2 type, int uuid, bool isFavorite) { }

	// RVA: 0x2048988 Offset: 0x2044988 VA: 0x2048988
	public bool ItemBagSort(byte bagId) { }

	// RVA: 0x2048990 Offset: 0x2044990 VA: 0x2048990
	public bool WarrantyDiscard(int warrantyItemUuid) { }

	// RVA: 0x20489E8 Offset: 0x20449E8 VA: 0x20489E8
	public bool WarrantySwap(int warrantyItemUuid, byte bagType) { }

	// RVA: 0x2048A40 Offset: 0x2044A40 VA: 0x2048A40
	public bool BagSlotRelease(ItemDataTypev2 dataType, int recipeId) { }

	// RVA: 0x2048A9C Offset: 0x2044A9C VA: 0x2048A9C
	public bool EquipItem(ItemDBData.EquipType type, int uuid) { }

	// RVA: 0x2048B58 Offset: 0x2044B58 VA: 0x2048B58
	public bool ClientEquipItem(ItemDBData.EquipType type, int uuid) { }

	// RVA: 0x2048C14 Offset: 0x2044C14 VA: 0x2048C14
	public bool PushEquipItem() { }

	// RVA: 0x2048CB8 Offset: 0x2044CB8 VA: 0x2048CB8 Slot: 4
	public void OnSetEquipProperties(bool isUpdate, NewArchetypeProperties properties) { }

	// RVA: 0x2048D80 Offset: 0x2044D80 VA: 0x2048D80
	public void ConfirmationEquip() { }

	// RVA: 0x2049180 Offset: 0x2045180 VA: 0x2049180
	public void EquipPurgeDisableSkill() { }

	// RVA: 0x204932C Offset: 0x204532C VA: 0x204932C
	public void UpdateClientEquipModel() { }

	// RVA: 0x20493D0 Offset: 0x20453D0 VA: 0x20493D0 Slot: 9
	public void OnSetProperties(NewArchetypeProperties properties) { }

	// RVA: 0x2049484 Offset: 0x2045484 VA: 0x2049484 Slot: 6
	public void OnLevelUp(LevelupEvent response) { }

	// RVA: 0x2049690 Offset: 0x2045690 VA: 0x2049690
	public void MobaLevelUp(MobaLevelupEvent levelup) { }

	// RVA: 0x2049878 Offset: 0x2045878 VA: 0x2049878 Slot: 8
	public void OnNaturalRecovery(NaturalRecoveryEvent response) { }

	// RVA: 0x20498B4 Offset: 0x20458B4 VA: 0x20498B4 Slot: 11
	public void OnMonsterFollowersPop(MonsterFollowersPop response) { }

	// RVA: 0x204995C Offset: 0x204595C VA: 0x204995C Slot: 12
	public void OnAbnormalDamage(AbnormalDamageEvent response) { }

	// RVA: 0x2049C10 Offset: 0x2045C10 VA: 0x2049C10 Slot: 13
	public void OnAbnormalStateEnd(AbnormalStateEndEvent response) { }

	// RVA: 0x2049CE4 Offset: 0x2045CE4 VA: 0x2049CE4 Slot: 14
	public void OnAddAbnormalState(AddAbnormalStateEvent response) { }

	// RVA: 0x204A074 Offset: 0x2046074 VA: 0x204A074 Slot: 17
	public void OnSkillBuffEnd(SkillBuffEndEvent endEvnet) { }

	// RVA: 0x204A400 Offset: 0x2046400 VA: 0x204A400 Slot: 18
	public void OnSkillDelayStandbyOk(SkillReusePermissioneEvent response) { }

	// RVA: 0x204A404 Offset: 0x2046404 VA: 0x204A404 Slot: 7
	public void OnComboPointUp(ComboPointUpEvent response) { }

	// RVA: 0x204A460 Offset: 0x2046460 VA: 0x204A460 Slot: 15
	public void OnStartComboBonus(StartComboBonusEvent response) { }

	// RVA: 0x204A464 Offset: 0x2046464 VA: 0x204A464 Slot: 16
	public void OnEndComboBonus(EndComboBonusEvent response) { }

	// RVA: 0x204A468 Offset: 0x2046468 VA: 0x204A468
	public List<EmotionPlayer.EmotionType> GetUserEmotionList() { }

	// RVA: 0x204A4B8 Offset: 0x20464B8 VA: 0x204A4B8
	public bool CheckPlayUserEmotion(EmotionPlayer.EmotionType emotionType) { }

	// RVA: 0x204A510 Offset: 0x2046510 VA: 0x204A510 Slot: 19
	public void OnUpdateGameStatus(UpdateGameStatusEvent updateEvent) { }

	// RVA: 0x204A6E0 Offset: 0x20466E0 VA: 0x204A6E0 Slot: 20
	public void OnItemDurationEnd(ItemDurationEndEvent endEvent) { }

	// RVA: 0x2047610 Offset: 0x2043610 VA: 0x2047610
	public void SetMoDeadLeaveFlag(bool flag) { }

	// RVA: 0x204A72C Offset: 0x204672C VA: 0x204A72C
	public void .ctor() { }
}
