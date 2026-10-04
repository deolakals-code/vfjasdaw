// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations
public class EnterAvatarData : UnityHashBase, IEnterAvatarPacket, IAccountGameData, IParamData, IStatusData, IAccountUserData, IItemBagData, IHouseBufferData, IHouseData, IGuildGameData, IGuildBufferData // TypeDefIndex: 11371
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ParamId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <ParamName>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <ParameterSlot>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <ServerFPS>k__BackingField; // 0x3A
	[CompilerGenerated]
	private PositionData <AvatarPosition>k__BackingField; // 0x40
	[CompilerGenerated]
	private PrimaryStatusData <PrimaryStatus>k__BackingField; // 0x48
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x50
	[CompilerGenerated]
	private AvatarGameStatusData <AvatarGameStatus>k__BackingField; // 0x58
	[CompilerGenerated]
	private AvatarEquipData <AvatarEquip>k__BackingField; // 0x60
	[CompilerGenerated]
	private Dictionary<byte, object> <NewProperties>k__BackingField; // 0x68
	[CompilerGenerated]
	private int <PropertiesRevision>k__BackingField; // 0x70
	[CompilerGenerated]
	private short[] <InventoryCapacity>k__BackingField; // 0x78
	[CompilerGenerated]
	private InventoryPackData <ItemBag>k__BackingField; // 0x80
	[CompilerGenerated]
	private WarrantyItemPackData <WarrantyBag>k__BackingField; // 0x88
	[CompilerGenerated]
	private Dictionary<short, byte> <SkillList>k__BackingField; // 0x90
	[CompilerGenerated]
	private MaterialData[] <MaterialList>k__BackingField; // 0x98
	[CompilerGenerated]
	private ProficiencyData <ProficiencyData>k__BackingField; // 0xA0
	[CompilerGenerated]
	private ScenarioList <ScenarioList>k__BackingField; // 0xA8
	[CompilerGenerated]
	private byte[] <TrophyData>k__BackingField; // 0xB0
	[CompilerGenerated]
	private FieldData <FieldData>k__BackingField; // 0xB8
	[CompilerGenerated]
	private SkillComboData[] <SkillCombo>k__BackingField; // 0xC0
	[CompilerGenerated]
	private OffenderData[] <OffenderList>k__BackingField; // 0xC8
	[CompilerGenerated]
	private LoginTermFlag <LoginTermFlag>k__BackingField; // 0xD0
	[CompilerGenerated]
	private DateTime <BanWordDate>k__BackingField; // 0xD8
	[CompilerGenerated]
	private AreaPopData <AreaPop>k__BackingField; // 0xE0
	[CompilerGenerated]
	private PetEnterData <PetEnterData>k__BackingField; // 0xE8
	[CompilerGenerated]
	private StarGemEquipData[] <StarGemEquips>k__BackingField; // 0xF0
	[CompilerGenerated]
	private short <AccountLevel>k__BackingField; // 0xF8
	[CompilerGenerated]
	private byte <GuildStatusBoostType>k__BackingField; // 0xFA
	[CompilerGenerated]
	private int <GuildStatusBoostRate>k__BackingField; // 0xFC
	[CompilerGenerated]
	private short[] <CuisineBuffId>k__BackingField; // 0x100
	[CompilerGenerated]
	private short[] <CuisineBuffVal>k__BackingField; // 0x108
	[CompilerGenerated]
	private int <CuisineRemainingTime>k__BackingField; // 0x110
	[CompilerGenerated]
	private bool <IsAsobiMarket>k__BackingField; // 0x114
	[CompilerGenerated]
	private GuildStaffHireData <GuildStaffHireData>k__BackingField; // 0x118
	[CompilerGenerated]
	private MyRoomEventSendData <MyRoomEventData>k__BackingField; // 0x120
	[CompilerGenerated]
	private RegistletData <RegistletData>k__BackingField; // 0x128
	[CompilerGenerated]
	private GemCartData[] <GemCartBag>k__BackingField; // 0x130
	[CompilerGenerated]
	private GemCartEquipData[] <GemCartEquipList>k__BackingField; // 0x138
	[CompilerGenerated]
	private GuildFacilityData[] <GuildFacilityBuffList>k__BackingField; // 0x140
	[CompilerGenerated]
	private RoguelikeRingData[] <RoguelikeRings>k__BackingField; // 0x148
	[CompilerGenerated]
	private RoguelikeRingEquipData[] <RoguelikeRingEquips>k__BackingField; // 0x150
	[CompilerGenerated]
	private AvatarOptionDataBase[] <OptionList>k__BackingField; // 0x158
	[CompilerGenerated]
	private Dictionary<short, byte[]> <ExSkillConfigList>k__BackingField; // 0x160
	[CompilerGenerated]
	private FishingData <FishingData>k__BackingField; // 0x168

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

	// RVA: 0x36F87E8 Offset: 0x36F47E8 VA: 0x36F87E8
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36F87F0 Offset: 0x36F47F0 VA: 0x36F87F0 Slot: 24
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x36F87F8 Offset: 0x36F47F8 VA: 0x36F87F8 Slot: 43
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36F8800 Offset: 0x36F4800 VA: 0x36F8800 Slot: 25
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x36F8808 Offset: 0x36F4808 VA: 0x36F8808 Slot: 44
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x36F8810 Offset: 0x36F4810 VA: 0x36F8810 Slot: 10
	public byte get_ParamId() { }

	[CompilerGenerated]
	// RVA: 0x36F8818 Offset: 0x36F4818 VA: 0x36F8818 Slot: 45
	public void set_ParamId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36F8820 Offset: 0x36F4820 VA: 0x36F8820 Slot: 11
	public string get_ParamName() { }

	[CompilerGenerated]
	// RVA: 0x36F8828 Offset: 0x36F4828 VA: 0x36F8828 Slot: 46
	public void set_ParamName(string value) { }

	[CompilerGenerated]
	// RVA: 0x36F8830 Offset: 0x36F4830 VA: 0x36F8830 Slot: 12
	public byte get_ParameterSlot() { }

	[CompilerGenerated]
	// RVA: 0x36F8838 Offset: 0x36F4838 VA: 0x36F8838 Slot: 47
	public void set_ParameterSlot(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36F8840 Offset: 0x36F4840 VA: 0x36F8840 Slot: 27
	public short get_ServerFPS() { }

	[CompilerGenerated]
	// RVA: 0x36F8848 Offset: 0x36F4848 VA: 0x36F8848 Slot: 48
	public void set_ServerFPS(short value) { }

	[CompilerGenerated]
	// RVA: 0x36F8850 Offset: 0x36F4850 VA: 0x36F8850 Slot: 49
	public PositionData get_AvatarPosition() { }

	[CompilerGenerated]
	// RVA: 0x36F8858 Offset: 0x36F4858 VA: 0x36F8858 Slot: 50
	public void set_AvatarPosition(PositionData value) { }

	[CompilerGenerated]
	// RVA: 0x36F8860 Offset: 0x36F4860 VA: 0x36F8860 Slot: 13
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x36F8868 Offset: 0x36F4868 VA: 0x36F8868 Slot: 51
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36F8870 Offset: 0x36F4870 VA: 0x36F8870 Slot: 14
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x36F8878 Offset: 0x36F4878 VA: 0x36F8878 Slot: 52
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36F8880 Offset: 0x36F4880 VA: 0x36F8880 Slot: 15
	public AvatarGameStatusData get_AvatarGameStatus() { }

	[CompilerGenerated]
	// RVA: 0x36F8888 Offset: 0x36F4888 VA: 0x36F8888 Slot: 53
	public void set_AvatarGameStatus(AvatarGameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36F8890 Offset: 0x36F4890 VA: 0x36F8890 Slot: 32
	public AvatarEquipData get_AvatarEquip() { }

	[CompilerGenerated]
	// RVA: 0x36F8898 Offset: 0x36F4898 VA: 0x36F8898 Slot: 54
	public void set_AvatarEquip(AvatarEquipData value) { }

	[CompilerGenerated]
	// RVA: 0x36F88A0 Offset: 0x36F48A0 VA: 0x36F88A0 Slot: 55
	public Dictionary<byte, object> get_NewProperties() { }

	[CompilerGenerated]
	// RVA: 0x36F88A8 Offset: 0x36F48A8 VA: 0x36F88A8 Slot: 56
	public void set_NewProperties(Dictionary<byte, object> value) { }

	[CompilerGenerated]
	// RVA: 0x36F88B0 Offset: 0x36F48B0 VA: 0x36F88B0 Slot: 57
	public int get_PropertiesRevision() { }

	[CompilerGenerated]
	// RVA: 0x36F88B8 Offset: 0x36F48B8 VA: 0x36F88B8 Slot: 58
	public void set_PropertiesRevision(int value) { }

	[CompilerGenerated]
	// RVA: 0x36F88C0 Offset: 0x36F48C0 VA: 0x36F88C0 Slot: 33
	public short[] get_InventoryCapacity() { }

	[CompilerGenerated]
	// RVA: 0x36F88C8 Offset: 0x36F48C8 VA: 0x36F88C8 Slot: 59
	public void set_InventoryCapacity(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F88D0 Offset: 0x36F48D0 VA: 0x36F88D0 Slot: 34
	public InventoryPackData get_ItemBag() { }

	[CompilerGenerated]
	// RVA: 0x36F88D8 Offset: 0x36F48D8 VA: 0x36F88D8 Slot: 60
	public void set_ItemBag(InventoryPackData value) { }

	[CompilerGenerated]
	// RVA: 0x36F88E0 Offset: 0x36F48E0 VA: 0x36F88E0 Slot: 35
	public WarrantyItemPackData get_WarrantyBag() { }

	[CompilerGenerated]
	// RVA: 0x36F88E8 Offset: 0x36F48E8 VA: 0x36F88E8 Slot: 61
	public void set_WarrantyBag(WarrantyItemPackData value) { }

	[CompilerGenerated]
	// RVA: 0x36F88F0 Offset: 0x36F48F0 VA: 0x36F88F0 Slot: 16
	public Dictionary<short, byte> get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x36F88F8 Offset: 0x36F48F8 VA: 0x36F88F8 Slot: 62
	public void set_SkillList(Dictionary<short, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x36F8900 Offset: 0x36F4900 VA: 0x36F8900 Slot: 7
	public MaterialData[] get_MaterialList() { }

	[CompilerGenerated]
	// RVA: 0x36F8908 Offset: 0x36F4908 VA: 0x36F8908 Slot: 63
	public void set_MaterialList(MaterialData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F8910 Offset: 0x36F4910 VA: 0x36F8910 Slot: 18
	public ProficiencyData get_ProficiencyData() { }

	[CompilerGenerated]
	// RVA: 0x36F8918 Offset: 0x36F4918 VA: 0x36F8918 Slot: 64
	public void set_ProficiencyData(ProficiencyData value) { }

	[CompilerGenerated]
	// RVA: 0x36F8920 Offset: 0x36F4920 VA: 0x36F8920 Slot: 9
	public ScenarioList get_ScenarioList() { }

	[CompilerGenerated]
	// RVA: 0x36F8928 Offset: 0x36F4928 VA: 0x36F8928 Slot: 65
	public void set_ScenarioList(ScenarioList value) { }

	[CompilerGenerated]
	// RVA: 0x36F8930 Offset: 0x36F4930 VA: 0x36F8930 Slot: 8
	public byte[] get_TrophyData() { }

	[CompilerGenerated]
	// RVA: 0x36F8938 Offset: 0x36F4938 VA: 0x36F8938 Slot: 66
	public void set_TrophyData(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F8940 Offset: 0x36F4940 VA: 0x36F8940 Slot: 67
	public FieldData get_FieldData() { }

	[CompilerGenerated]
	// RVA: 0x36F8948 Offset: 0x36F4948 VA: 0x36F8948 Slot: 68
	public void set_FieldData(FieldData value) { }

	[CompilerGenerated]
	// RVA: 0x36F8950 Offset: 0x36F4950 VA: 0x36F8950 Slot: 17
	public SkillComboData[] get_SkillCombo() { }

	[CompilerGenerated]
	// RVA: 0x36F8958 Offset: 0x36F4958 VA: 0x36F8958 Slot: 69
	public void set_SkillCombo(SkillComboData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F8960 Offset: 0x36F4960 VA: 0x36F8960 Slot: 30
	public OffenderData[] get_OffenderList() { }

	[CompilerGenerated]
	// RVA: 0x36F8968 Offset: 0x36F4968 VA: 0x36F8968 Slot: 70
	public void set_OffenderList(OffenderData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F8970 Offset: 0x36F4970 VA: 0x36F8970 Slot: 28
	public LoginTermFlag get_LoginTermFlag() { }

	[CompilerGenerated]
	// RVA: 0x36F8978 Offset: 0x36F4978 VA: 0x36F8978 Slot: 71
	public void set_LoginTermFlag(LoginTermFlag value) { }

	[CompilerGenerated]
	// RVA: 0x36F8980 Offset: 0x36F4980 VA: 0x36F8980 Slot: 31
	public DateTime get_BanWordDate() { }

	[CompilerGenerated]
	// RVA: 0x36F8988 Offset: 0x36F4988 VA: 0x36F8988 Slot: 72
	public void set_BanWordDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x36F8990 Offset: 0x36F4990 VA: 0x36F8990 Slot: 73
	public AreaPopData get_AreaPop() { }

	[CompilerGenerated]
	// RVA: 0x36F8998 Offset: 0x36F4998 VA: 0x36F8998 Slot: 74
	public void set_AreaPop(AreaPopData value) { }

	[CompilerGenerated]
	// RVA: 0x36F89A0 Offset: 0x36F49A0 VA: 0x36F89A0 Slot: 75
	public PetEnterData get_PetEnterData() { }

	[CompilerGenerated]
	// RVA: 0x36F89A8 Offset: 0x36F49A8 VA: 0x36F89A8 Slot: 76
	public void set_PetEnterData(PetEnterData value) { }

	[CompilerGenerated]
	// RVA: 0x36F89B0 Offset: 0x36F49B0 VA: 0x36F89B0 Slot: 19
	public StarGemEquipData[] get_StarGemEquips() { }

	[CompilerGenerated]
	// RVA: 0x36F89B8 Offset: 0x36F49B8 VA: 0x36F89B8 Slot: 77
	public void set_StarGemEquips(StarGemEquipData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F89C0 Offset: 0x36F49C0 VA: 0x36F89C0 Slot: 26
	public short get_AccountLevel() { }

	[CompilerGenerated]
	// RVA: 0x36F89C8 Offset: 0x36F49C8 VA: 0x36F89C8 Slot: 78
	public void set_AccountLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x36F89D0 Offset: 0x36F49D0 VA: 0x36F89D0 Slot: 79
	public byte get_GuildStatusBoostType() { }

	[CompilerGenerated]
	// RVA: 0x36F89D8 Offset: 0x36F49D8 VA: 0x36F89D8 Slot: 80
	public void set_GuildStatusBoostType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36F89E0 Offset: 0x36F49E0 VA: 0x36F89E0 Slot: 81
	public int get_GuildStatusBoostRate() { }

	[CompilerGenerated]
	// RVA: 0x36F89E8 Offset: 0x36F49E8 VA: 0x36F89E8 Slot: 82
	public void set_GuildStatusBoostRate(int value) { }

	[CompilerGenerated]
	// RVA: 0x36F89F0 Offset: 0x36F49F0 VA: 0x36F89F0 Slot: 36
	public short[] get_CuisineBuffId() { }

	[CompilerGenerated]
	// RVA: 0x36F89F8 Offset: 0x36F49F8 VA: 0x36F89F8 Slot: 83
	public void set_CuisineBuffId(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F8A08 Offset: 0x36F4A08 VA: 0x36F8A08 Slot: 37
	public short[] get_CuisineBuffVal() { }

	[CompilerGenerated]
	// RVA: 0x36F8A10 Offset: 0x36F4A10 VA: 0x36F8A10 Slot: 84
	public void set_CuisineBuffVal(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F8A20 Offset: 0x36F4A20 VA: 0x36F8A20 Slot: 38
	public int get_CuisineRemainingTime() { }

	[CompilerGenerated]
	// RVA: 0x36F8A28 Offset: 0x36F4A28 VA: 0x36F8A28 Slot: 85
	public void set_CuisineRemainingTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x36F8A30 Offset: 0x36F4A30 VA: 0x36F8A30 Slot: 29
	public bool get_IsAsobiMarket() { }

	[CompilerGenerated]
	// RVA: 0x36F8A38 Offset: 0x36F4A38 VA: 0x36F8A38 Slot: 86
	public void set_IsAsobiMarket(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36F8A44 Offset: 0x36F4A44 VA: 0x36F8A44 Slot: 87
	public GuildStaffHireData get_GuildStaffHireData() { }

	[CompilerGenerated]
	// RVA: 0x36F8A4C Offset: 0x36F4A4C VA: 0x36F8A4C Slot: 88
	public void set_GuildStaffHireData(GuildStaffHireData value) { }

	[CompilerGenerated]
	// RVA: 0x36F8A5C Offset: 0x36F4A5C VA: 0x36F8A5C Slot: 39
	public MyRoomEventSendData get_MyRoomEventData() { }

	[CompilerGenerated]
	// RVA: 0x36F8A64 Offset: 0x36F4A64 VA: 0x36F8A64 Slot: 89
	public void set_MyRoomEventData(MyRoomEventSendData value) { }

	[CompilerGenerated]
	// RVA: 0x36F8A74 Offset: 0x36F4A74 VA: 0x36F8A74 Slot: 20
	public RegistletData get_RegistletData() { }

	[CompilerGenerated]
	// RVA: 0x36F8A7C Offset: 0x36F4A7C VA: 0x36F8A7C Slot: 90
	public void set_RegistletData(RegistletData value) { }

	[CompilerGenerated]
	// RVA: 0x36F8A8C Offset: 0x36F4A8C VA: 0x36F8A8C Slot: 21
	public GemCartData[] get_GemCartBag() { }

	[CompilerGenerated]
	// RVA: 0x36F8A94 Offset: 0x36F4A94 VA: 0x36F8A94 Slot: 91
	public void set_GemCartBag(GemCartData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F8AA4 Offset: 0x36F4AA4 VA: 0x36F8AA4 Slot: 22
	public GemCartEquipData[] get_GemCartEquipList() { }

	[CompilerGenerated]
	// RVA: 0x36F8AAC Offset: 0x36F4AAC VA: 0x36F8AAC Slot: 92
	public void set_GemCartEquipList(GemCartEquipData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F8ABC Offset: 0x36F4ABC VA: 0x36F8ABC Slot: 93
	public GuildFacilityData[] get_GuildFacilityBuffList() { }

	[CompilerGenerated]
	// RVA: 0x36F8AC4 Offset: 0x36F4AC4 VA: 0x36F8AC4 Slot: 94
	public void set_GuildFacilityBuffList(GuildFacilityData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F8AD4 Offset: 0x36F4AD4 VA: 0x36F8AD4 Slot: 95
	public RoguelikeRingData[] get_RoguelikeRings() { }

	[CompilerGenerated]
	// RVA: 0x36F8ADC Offset: 0x36F4ADC VA: 0x36F8ADC
	public void set_RoguelikeRings(RoguelikeRingData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F8AEC Offset: 0x36F4AEC VA: 0x36F8AEC Slot: 96
	public RoguelikeRingEquipData[] get_RoguelikeRingEquips() { }

	[CompilerGenerated]
	// RVA: 0x36F8AF4 Offset: 0x36F4AF4 VA: 0x36F8AF4
	public void set_RoguelikeRingEquips(RoguelikeRingEquipData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F8B04 Offset: 0x36F4B04 VA: 0x36F8B04 Slot: 97
	public AvatarOptionDataBase[] get_OptionList() { }

	[CompilerGenerated]
	// RVA: 0x36F8B0C Offset: 0x36F4B0C VA: 0x36F8B0C Slot: 98
	public void set_OptionList(AvatarOptionDataBase[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F8B1C Offset: 0x36F4B1C VA: 0x36F8B1C Slot: 23
	public Dictionary<short, byte[]> get_ExSkillConfigList() { }

	[CompilerGenerated]
	// RVA: 0x36F8B24 Offset: 0x36F4B24 VA: 0x36F8B24 Slot: 99
	public void set_ExSkillConfigList(Dictionary<short, byte[]> value) { }

	[CompilerGenerated]
	// RVA: 0x36F8B34 Offset: 0x36F4B34 VA: 0x36F8B34 Slot: 100
	public FishingData get_FishingData() { }

	[CompilerGenerated]
	// RVA: 0x36F8B3C Offset: 0x36F4B3C VA: 0x36F8B3C Slot: 101
	public void set_FishingData(FishingData value) { }

	// RVA: 0x36F8B4C Offset: 0x36F4B4C VA: 0x36F8B4C Slot: 41
	public byte get_BoostType() { }

	// RVA: 0x36F8B54 Offset: 0x36F4B54 VA: 0x36F8B54 Slot: 42
	public int get_BoostRate() { }

	// RVA: 0x36F8B5C Offset: 0x36F4B5C VA: 0x36F8B5C Slot: 40
	public GuildStaffHireData get_StaffHireData() { }

	// RVA: 0x36F8B64 Offset: 0x36F4B64 VA: 0x36F8B64
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36F9F90 Offset: 0x36F5F90 VA: 0x36F9F90
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36FA9B0 Offset: 0x36F69B0 VA: 0x36FA9B0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36FA9B8 Offset: 0x36F69B8 VA: 0x36FA9B8 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36FB380 Offset: 0x36F7380 VA: 0x36FB380 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
