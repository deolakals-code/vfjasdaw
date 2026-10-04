// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations
public class EnterAvatarPacket : PacketBase, IEnterAvatarPacket, IAccountGameData, IParamData, IStatusData, IAccountUserData, IItemBagData, IHouseBufferData, IGuildGameData, IGuildBufferData, IHouseData // TypeDefIndex: 11370
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <ParamId>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <ParamName>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <ParameterSlot>k__BackingField; // 0x40
	[CompilerGenerated]
	private short <ServerFPS>k__BackingField; // 0x42
	[CompilerGenerated]
	private PositionData <AvatarPosition>k__BackingField; // 0x48
	[CompilerGenerated]
	private PrimaryStatusData <PrimaryStatus>k__BackingField; // 0x50
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x58
	[CompilerGenerated]
	private AvatarGameStatusData <AvatarGameStatus>k__BackingField; // 0x60
	[CompilerGenerated]
	private AvatarEquipData <AvatarEquip>k__BackingField; // 0x68
	[CompilerGenerated]
	private Dictionary<byte, object> <NewProperties>k__BackingField; // 0x70
	[CompilerGenerated]
	private int <PropertiesRevision>k__BackingField; // 0x78
	[CompilerGenerated]
	private short[] <InventoryCapacity>k__BackingField; // 0x80
	[CompilerGenerated]
	private InventoryPackData <ItemBag>k__BackingField; // 0x88
	[CompilerGenerated]
	private WarrantyItemPackData <WarrantyBag>k__BackingField; // 0x90
	[CompilerGenerated]
	private Dictionary<short, byte> <SkillList>k__BackingField; // 0x98
	[CompilerGenerated]
	private MaterialData[] <MaterialList>k__BackingField; // 0xA0
	[CompilerGenerated]
	private ProficiencyData <ProficiencyData>k__BackingField; // 0xA8
	[CompilerGenerated]
	private ScenarioList <ScenarioList>k__BackingField; // 0xB0
	[CompilerGenerated]
	private byte[] <TrophyData>k__BackingField; // 0xB8
	[CompilerGenerated]
	private FieldData <FieldData>k__BackingField; // 0xC0
	[CompilerGenerated]
	private SkillComboData[] <SkillCombo>k__BackingField; // 0xC8
	[CompilerGenerated]
	private OffenderData[] <OffenderList>k__BackingField; // 0xD0
	[CompilerGenerated]
	private LoginTermFlag <LoginTermFlag>k__BackingField; // 0xD8
	[CompilerGenerated]
	private DateTime <BanWordDate>k__BackingField; // 0xE0
	[CompilerGenerated]
	private AreaPopData <AreaPop>k__BackingField; // 0xE8
	[CompilerGenerated]
	private PetEnterData <PetEnterData>k__BackingField; // 0xF0
	[CompilerGenerated]
	private StarGemEquipData[] <StarGemEquips>k__BackingField; // 0xF8
	[CompilerGenerated]
	private short <AccountLevel>k__BackingField; // 0x100
	[CompilerGenerated]
	private byte <GuildStatusBoostType>k__BackingField; // 0x102
	[CompilerGenerated]
	private int <GuildStatusBoostRate>k__BackingField; // 0x104
	[CompilerGenerated]
	private short[] <CuisineBuffId>k__BackingField; // 0x108
	[CompilerGenerated]
	private short[] <CuisineBuffVal>k__BackingField; // 0x110
	[CompilerGenerated]
	private int <CuisineRemainingTime>k__BackingField; // 0x118
	[CompilerGenerated]
	private bool <IsAsobiMarket>k__BackingField; // 0x11C
	[CompilerGenerated]
	private GuildStaffHireData <GuildStaffHireData>k__BackingField; // 0x120
	[CompilerGenerated]
	private MyRoomEventSendData <MyRoomEventData>k__BackingField; // 0x128
	[CompilerGenerated]
	private RegistletData <RegistletData>k__BackingField; // 0x130
	[CompilerGenerated]
	private GemCartData[] <GemCartBag>k__BackingField; // 0x138
	[CompilerGenerated]
	private GemCartEquipData[] <GemCartEquipList>k__BackingField; // 0x140
	[CompilerGenerated]
	private GuildFacilityData[] <GuildFacilityBuffList>k__BackingField; // 0x148
	[CompilerGenerated]
	private RoguelikeRingData[] <RoguelikeRings>k__BackingField; // 0x150
	[CompilerGenerated]
	private RoguelikeRingEquipData[] <RoguelikeRingEquips>k__BackingField; // 0x158
	[CompilerGenerated]
	private AvatarOptionDataBase[] <OptionList>k__BackingField; // 0x160
	[CompilerGenerated]
	private Dictionary<short, byte[]> <ExSkillConfigList>k__BackingField; // 0x168
	[CompilerGenerated]
	private FishingData <FishingData>k__BackingField; // 0x170

	// Properties
	public int AvatarUuid { get; set; }
	public string Name { get; set; }
	public byte ParamId { get; set; }
	public string ParamName { get; set; }
	public byte ParameterSlot { get; set; }
	public short ServerFPS { get; set; }
	public PositionData AvatarPosition { get; set; }
	public PrimaryStatusData PrimaryStatus { get; set; }
	public GameStatusData GameStatus { get; set; }
	public AvatarGameStatusData AvatarGameStatus { get; set; }
	public AvatarEquipData AvatarEquip { get; set; }
	public Dictionary<byte, object> NewProperties { get; set; }
	public int PropertiesRevision { get; set; }
	public short[] InventoryCapacity { get; set; }
	public InventoryPackData ItemBag { get; set; }
	public WarrantyItemPackData WarrantyBag { get; set; }
	public Dictionary<short, byte> SkillList { get; set; }
	public MaterialData[] MaterialList { get; set; }
	public ProficiencyData ProficiencyData { get; set; }
	public ScenarioList ScenarioList { get; set; }
	public byte[] TrophyData { get; set; }
	public FieldData FieldData { get; set; }
	public SkillComboData[] SkillCombo { get; set; }
	public OffenderData[] OffenderList { get; set; }
	public LoginTermFlag LoginTermFlag { get; set; }
	public DateTime BanWordDate { get; set; }
	public AreaPopData AreaPop { get; set; }
	public PetEnterData PetEnterData { get; set; }
	public StarGemEquipData[] StarGemEquips { get; set; }
	public short AccountLevel { get; set; }
	public byte GuildStatusBoostType { get; set; }
	public int GuildStatusBoostRate { get; set; }
	public short[] CuisineBuffId { get; set; }
	public short[] CuisineBuffVal { get; set; }
	public int CuisineRemainingTime { get; set; }
	public bool IsAsobiMarket { get; set; }
	public GuildStaffHireData GuildStaffHireData { get; set; }
	public MyRoomEventSendData MyRoomEventData { get; set; }
	public RegistletData RegistletData { get; set; }
	public GemCartData[] GemCartBag { get; set; }
	public GemCartEquipData[] GemCartEquipList { get; set; }
	public GuildFacilityData[] GuildFacilityBuffList { get; set; }
	public RoguelikeRingData[] RoguelikeRings { get; set; }
	public RoguelikeRingEquipData[] RoguelikeRingEquips { get; set; }
	public AvatarOptionDataBase[] OptionList { get; set; }
	public Dictionary<short, byte[]> ExSkillConfigList { get; set; }
	public FishingData FishingData { get; set; }
	public byte BoostType { get; }
	public int BoostRate { get; }
	public GuildStaffHireData StaffHireData { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36F6260 Offset: 0x36F2260 VA: 0x36F6260
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36F6268 Offset: 0x36F2268 VA: 0x36F6268 Slot: 24
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x36F6270 Offset: 0x36F2270 VA: 0x36F6270 Slot: 43
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36F6278 Offset: 0x36F2278 VA: 0x36F6278 Slot: 25
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x36F6280 Offset: 0x36F2280 VA: 0x36F6280 Slot: 44
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x36F6288 Offset: 0x36F2288 VA: 0x36F6288 Slot: 10
	public byte get_ParamId() { }

	[CompilerGenerated]
	// RVA: 0x36F6290 Offset: 0x36F2290 VA: 0x36F6290 Slot: 45
	public void set_ParamId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36F6298 Offset: 0x36F2298 VA: 0x36F6298 Slot: 11
	public string get_ParamName() { }

	[CompilerGenerated]
	// RVA: 0x36F62A0 Offset: 0x36F22A0 VA: 0x36F62A0 Slot: 46
	public void set_ParamName(string value) { }

	[CompilerGenerated]
	// RVA: 0x36F62A8 Offset: 0x36F22A8 VA: 0x36F62A8 Slot: 12
	public byte get_ParameterSlot() { }

	[CompilerGenerated]
	// RVA: 0x36F62B0 Offset: 0x36F22B0 VA: 0x36F62B0 Slot: 47
	public void set_ParameterSlot(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36F62B8 Offset: 0x36F22B8 VA: 0x36F62B8 Slot: 27
	public short get_ServerFPS() { }

	[CompilerGenerated]
	// RVA: 0x36F62C0 Offset: 0x36F22C0 VA: 0x36F62C0 Slot: 48
	public void set_ServerFPS(short value) { }

	[CompilerGenerated]
	// RVA: 0x36F62C8 Offset: 0x36F22C8 VA: 0x36F62C8 Slot: 49
	public PositionData get_AvatarPosition() { }

	[CompilerGenerated]
	// RVA: 0x36F62D0 Offset: 0x36F22D0 VA: 0x36F62D0 Slot: 50
	public void set_AvatarPosition(PositionData value) { }

	[CompilerGenerated]
	// RVA: 0x36F62D8 Offset: 0x36F22D8 VA: 0x36F62D8 Slot: 13
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x36F62E0 Offset: 0x36F22E0 VA: 0x36F62E0 Slot: 51
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36F62E8 Offset: 0x36F22E8 VA: 0x36F62E8 Slot: 14
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x36F62F0 Offset: 0x36F22F0 VA: 0x36F62F0 Slot: 52
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36F62F8 Offset: 0x36F22F8 VA: 0x36F62F8 Slot: 15
	public AvatarGameStatusData get_AvatarGameStatus() { }

	[CompilerGenerated]
	// RVA: 0x36F6300 Offset: 0x36F2300 VA: 0x36F6300 Slot: 53
	public void set_AvatarGameStatus(AvatarGameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36F6308 Offset: 0x36F2308 VA: 0x36F6308 Slot: 32
	public AvatarEquipData get_AvatarEquip() { }

	[CompilerGenerated]
	// RVA: 0x36F6310 Offset: 0x36F2310 VA: 0x36F6310 Slot: 54
	public void set_AvatarEquip(AvatarEquipData value) { }

	[CompilerGenerated]
	// RVA: 0x36F6318 Offset: 0x36F2318 VA: 0x36F6318 Slot: 55
	public Dictionary<byte, object> get_NewProperties() { }

	[CompilerGenerated]
	// RVA: 0x36F6320 Offset: 0x36F2320 VA: 0x36F6320 Slot: 56
	public void set_NewProperties(Dictionary<byte, object> value) { }

	[CompilerGenerated]
	// RVA: 0x36F6328 Offset: 0x36F2328 VA: 0x36F6328 Slot: 57
	public int get_PropertiesRevision() { }

	[CompilerGenerated]
	// RVA: 0x36F6330 Offset: 0x36F2330 VA: 0x36F6330 Slot: 58
	public void set_PropertiesRevision(int value) { }

	[CompilerGenerated]
	// RVA: 0x36F6338 Offset: 0x36F2338 VA: 0x36F6338 Slot: 33
	public short[] get_InventoryCapacity() { }

	[CompilerGenerated]
	// RVA: 0x36F6340 Offset: 0x36F2340 VA: 0x36F6340 Slot: 59
	public void set_InventoryCapacity(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F6348 Offset: 0x36F2348 VA: 0x36F6348 Slot: 34
	public InventoryPackData get_ItemBag() { }

	[CompilerGenerated]
	// RVA: 0x36F6350 Offset: 0x36F2350 VA: 0x36F6350 Slot: 60
	public void set_ItemBag(InventoryPackData value) { }

	[CompilerGenerated]
	// RVA: 0x36F6358 Offset: 0x36F2358 VA: 0x36F6358 Slot: 35
	public WarrantyItemPackData get_WarrantyBag() { }

	[CompilerGenerated]
	// RVA: 0x36F6360 Offset: 0x36F2360 VA: 0x36F6360 Slot: 61
	public void set_WarrantyBag(WarrantyItemPackData value) { }

	[CompilerGenerated]
	// RVA: 0x36F6368 Offset: 0x36F2368 VA: 0x36F6368 Slot: 16
	public Dictionary<short, byte> get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x36F6370 Offset: 0x36F2370 VA: 0x36F6370 Slot: 62
	public void set_SkillList(Dictionary<short, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x36F6378 Offset: 0x36F2378 VA: 0x36F6378 Slot: 7
	public MaterialData[] get_MaterialList() { }

	[CompilerGenerated]
	// RVA: 0x36F6380 Offset: 0x36F2380 VA: 0x36F6380 Slot: 63
	public void set_MaterialList(MaterialData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F6388 Offset: 0x36F2388 VA: 0x36F6388 Slot: 18
	public ProficiencyData get_ProficiencyData() { }

	[CompilerGenerated]
	// RVA: 0x36F6390 Offset: 0x36F2390 VA: 0x36F6390 Slot: 64
	public void set_ProficiencyData(ProficiencyData value) { }

	[CompilerGenerated]
	// RVA: 0x36F6398 Offset: 0x36F2398 VA: 0x36F6398 Slot: 9
	public ScenarioList get_ScenarioList() { }

	[CompilerGenerated]
	// RVA: 0x36F63A0 Offset: 0x36F23A0 VA: 0x36F63A0 Slot: 65
	public void set_ScenarioList(ScenarioList value) { }

	[CompilerGenerated]
	// RVA: 0x36F63A8 Offset: 0x36F23A8 VA: 0x36F63A8 Slot: 8
	public byte[] get_TrophyData() { }

	[CompilerGenerated]
	// RVA: 0x36F63B0 Offset: 0x36F23B0 VA: 0x36F63B0 Slot: 66
	public void set_TrophyData(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F63B8 Offset: 0x36F23B8 VA: 0x36F63B8 Slot: 67
	public FieldData get_FieldData() { }

	[CompilerGenerated]
	// RVA: 0x36F63C0 Offset: 0x36F23C0 VA: 0x36F63C0 Slot: 68
	public void set_FieldData(FieldData value) { }

	[CompilerGenerated]
	// RVA: 0x36F63C8 Offset: 0x36F23C8 VA: 0x36F63C8 Slot: 17
	public SkillComboData[] get_SkillCombo() { }

	[CompilerGenerated]
	// RVA: 0x36F63D0 Offset: 0x36F23D0 VA: 0x36F63D0 Slot: 69
	public void set_SkillCombo(SkillComboData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F63D8 Offset: 0x36F23D8 VA: 0x36F63D8 Slot: 30
	public OffenderData[] get_OffenderList() { }

	[CompilerGenerated]
	// RVA: 0x36F63E0 Offset: 0x36F23E0 VA: 0x36F63E0 Slot: 70
	public void set_OffenderList(OffenderData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F63E8 Offset: 0x36F23E8 VA: 0x36F63E8 Slot: 28
	public LoginTermFlag get_LoginTermFlag() { }

	[CompilerGenerated]
	// RVA: 0x36F63F0 Offset: 0x36F23F0 VA: 0x36F63F0 Slot: 71
	public void set_LoginTermFlag(LoginTermFlag value) { }

	[CompilerGenerated]
	// RVA: 0x36F63F8 Offset: 0x36F23F8 VA: 0x36F63F8 Slot: 31
	public DateTime get_BanWordDate() { }

	[CompilerGenerated]
	// RVA: 0x36F6400 Offset: 0x36F2400 VA: 0x36F6400 Slot: 72
	public void set_BanWordDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x36F6408 Offset: 0x36F2408 VA: 0x36F6408 Slot: 73
	public AreaPopData get_AreaPop() { }

	[CompilerGenerated]
	// RVA: 0x36F6410 Offset: 0x36F2410 VA: 0x36F6410 Slot: 74
	public void set_AreaPop(AreaPopData value) { }

	[CompilerGenerated]
	// RVA: 0x36F6418 Offset: 0x36F2418 VA: 0x36F6418 Slot: 75
	public PetEnterData get_PetEnterData() { }

	[CompilerGenerated]
	// RVA: 0x36F6420 Offset: 0x36F2420 VA: 0x36F6420 Slot: 76
	public void set_PetEnterData(PetEnterData value) { }

	[CompilerGenerated]
	// RVA: 0x36F6428 Offset: 0x36F2428 VA: 0x36F6428 Slot: 19
	public StarGemEquipData[] get_StarGemEquips() { }

	[CompilerGenerated]
	// RVA: 0x36F6430 Offset: 0x36F2430 VA: 0x36F6430 Slot: 77
	public void set_StarGemEquips(StarGemEquipData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F6438 Offset: 0x36F2438 VA: 0x36F6438 Slot: 26
	public short get_AccountLevel() { }

	[CompilerGenerated]
	// RVA: 0x36F6440 Offset: 0x36F2440 VA: 0x36F6440 Slot: 78
	public void set_AccountLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x36F6448 Offset: 0x36F2448 VA: 0x36F6448 Slot: 79
	public byte get_GuildStatusBoostType() { }

	[CompilerGenerated]
	// RVA: 0x36F6450 Offset: 0x36F2450 VA: 0x36F6450 Slot: 80
	public void set_GuildStatusBoostType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36F6458 Offset: 0x36F2458 VA: 0x36F6458 Slot: 81
	public int get_GuildStatusBoostRate() { }

	[CompilerGenerated]
	// RVA: 0x36F6460 Offset: 0x36F2460 VA: 0x36F6460 Slot: 82
	public void set_GuildStatusBoostRate(int value) { }

	[CompilerGenerated]
	// RVA: 0x36F6468 Offset: 0x36F2468 VA: 0x36F6468 Slot: 36
	public short[] get_CuisineBuffId() { }

	[CompilerGenerated]
	// RVA: 0x36F6470 Offset: 0x36F2470 VA: 0x36F6470 Slot: 83
	public void set_CuisineBuffId(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F6480 Offset: 0x36F2480 VA: 0x36F6480 Slot: 37
	public short[] get_CuisineBuffVal() { }

	[CompilerGenerated]
	// RVA: 0x36F6488 Offset: 0x36F2488 VA: 0x36F6488 Slot: 84
	public void set_CuisineBuffVal(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F6498 Offset: 0x36F2498 VA: 0x36F6498 Slot: 38
	public int get_CuisineRemainingTime() { }

	[CompilerGenerated]
	// RVA: 0x36F64A0 Offset: 0x36F24A0 VA: 0x36F64A0 Slot: 85
	public void set_CuisineRemainingTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x36F64A8 Offset: 0x36F24A8 VA: 0x36F64A8 Slot: 29
	public bool get_IsAsobiMarket() { }

	[CompilerGenerated]
	// RVA: 0x36F64B0 Offset: 0x36F24B0 VA: 0x36F64B0 Slot: 86
	public void set_IsAsobiMarket(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36F64BC Offset: 0x36F24BC VA: 0x36F64BC Slot: 87
	public GuildStaffHireData get_GuildStaffHireData() { }

	[CompilerGenerated]
	// RVA: 0x36F64C4 Offset: 0x36F24C4 VA: 0x36F64C4 Slot: 88
	public void set_GuildStaffHireData(GuildStaffHireData value) { }

	[CompilerGenerated]
	// RVA: 0x36F64D4 Offset: 0x36F24D4 VA: 0x36F64D4 Slot: 42
	public MyRoomEventSendData get_MyRoomEventData() { }

	[CompilerGenerated]
	// RVA: 0x36F64DC Offset: 0x36F24DC VA: 0x36F64DC Slot: 89
	public void set_MyRoomEventData(MyRoomEventSendData value) { }

	[CompilerGenerated]
	// RVA: 0x36F64EC Offset: 0x36F24EC VA: 0x36F64EC Slot: 20
	public RegistletData get_RegistletData() { }

	[CompilerGenerated]
	// RVA: 0x36F64F4 Offset: 0x36F24F4 VA: 0x36F64F4 Slot: 90
	public void set_RegistletData(RegistletData value) { }

	[CompilerGenerated]
	// RVA: 0x36F6504 Offset: 0x36F2504 VA: 0x36F6504 Slot: 21
	public GemCartData[] get_GemCartBag() { }

	[CompilerGenerated]
	// RVA: 0x36F650C Offset: 0x36F250C VA: 0x36F650C Slot: 91
	public void set_GemCartBag(GemCartData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F651C Offset: 0x36F251C VA: 0x36F651C Slot: 22
	public GemCartEquipData[] get_GemCartEquipList() { }

	[CompilerGenerated]
	// RVA: 0x36F6524 Offset: 0x36F2524 VA: 0x36F6524 Slot: 92
	public void set_GemCartEquipList(GemCartEquipData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F6534 Offset: 0x36F2534 VA: 0x36F6534 Slot: 93
	public GuildFacilityData[] get_GuildFacilityBuffList() { }

	[CompilerGenerated]
	// RVA: 0x36F653C Offset: 0x36F253C VA: 0x36F653C Slot: 94
	public void set_GuildFacilityBuffList(GuildFacilityData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F654C Offset: 0x36F254C VA: 0x36F654C Slot: 95
	public RoguelikeRingData[] get_RoguelikeRings() { }

	[CompilerGenerated]
	// RVA: 0x36F6554 Offset: 0x36F2554 VA: 0x36F6554
	public void set_RoguelikeRings(RoguelikeRingData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F6564 Offset: 0x36F2564 VA: 0x36F6564 Slot: 96
	public RoguelikeRingEquipData[] get_RoguelikeRingEquips() { }

	[CompilerGenerated]
	// RVA: 0x36F656C Offset: 0x36F256C VA: 0x36F656C
	public void set_RoguelikeRingEquips(RoguelikeRingEquipData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F657C Offset: 0x36F257C VA: 0x36F657C Slot: 97
	public AvatarOptionDataBase[] get_OptionList() { }

	[CompilerGenerated]
	// RVA: 0x36F6584 Offset: 0x36F2584 VA: 0x36F6584 Slot: 98
	public void set_OptionList(AvatarOptionDataBase[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F6594 Offset: 0x36F2594 VA: 0x36F6594 Slot: 23
	public Dictionary<short, byte[]> get_ExSkillConfigList() { }

	[CompilerGenerated]
	// RVA: 0x36F659C Offset: 0x36F259C VA: 0x36F659C Slot: 99
	public void set_ExSkillConfigList(Dictionary<short, byte[]> value) { }

	[CompilerGenerated]
	// RVA: 0x36F65AC Offset: 0x36F25AC VA: 0x36F65AC Slot: 100
	public FishingData get_FishingData() { }

	[CompilerGenerated]
	// RVA: 0x36F65B4 Offset: 0x36F25B4 VA: 0x36F65B4 Slot: 101
	public void set_FishingData(FishingData value) { }

	// RVA: 0x36F65C4 Offset: 0x36F25C4 VA: 0x36F65C4 Slot: 40
	public byte get_BoostType() { }

	// RVA: 0x36F65CC Offset: 0x36F25CC VA: 0x36F65CC Slot: 41
	public int get_BoostRate() { }

	// RVA: 0x36F65D4 Offset: 0x36F25D4 VA: 0x36F65D4 Slot: 39
	public GuildStaffHireData get_StaffHireData() { }

	// RVA: 0x36F65DC Offset: 0x36F25DC VA: 0x36F65DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36F65E4 Offset: 0x36F25E4 VA: 0x36F65E4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36F7F0C Offset: 0x36F3F0C VA: 0x36F7F0C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
