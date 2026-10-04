// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Operations
public class GmCommandResponse : OperationResponseBase // TypeDefIndex: 17616
{
	// Fields
	private readonly byte subCode; // 0x20
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x28
	[CompilerGenerated]
	private OrbItemData[] <OrbItemList>k__BackingField; // 0x30
	[CompilerGenerated]
	private OrbEquipItemData[] <OrbEquipList>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x44
	[CompilerGenerated]
	private short <StatusPoint>k__BackingField; // 0x48
	[CompilerGenerated]
	private short <SkillPoint>k__BackingField; // 0x4A
	[CompilerGenerated]
	private int <ScenarioProgress>k__BackingField; // 0x4C
	[CompilerGenerated]
	private int <MissionId>k__BackingField; // 0x50
	[CompilerGenerated]
	private Dictionary<short, byte> <SkillList>k__BackingField; // 0x58
	[CompilerGenerated]
	private byte <ComboPoint>k__BackingField; // 0x60
	[CompilerGenerated]
	private int <Value>k__BackingField; // 0x64
	[CompilerGenerated]
	private Dictionary<object, object> <Params>k__BackingField; // 0x68
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x70
	[CompilerGenerated]
	private byte <ChannelId>k__BackingField; // 0x78
	[CompilerGenerated]
	private MaterialData[] <MaterialList>k__BackingField; // 0x80
	[CompilerGenerated]
	private TimeData <ContinuousTime>k__BackingField; // 0x88
	[CompilerGenerated]
	private TimeData <TotalTime>k__BackingField; // 0x90
	[CompilerGenerated]
	private byte[] <TrophyData>k__BackingField; // 0x98
	[CompilerGenerated]
	private ProficiencyData <ProficiencyData>k__BackingField; // 0xA0
	[CompilerGenerated]
	private PetInfoData <Pet>k__BackingField; // 0xA8
	[CompilerGenerated]
	private GemCartData <GemCart>k__BackingField; // 0xB0
	[CompilerGenerated]
	private long <Time>k__BackingField; // 0xB8
	[CompilerGenerated]
	private GuildVariableData[] <GuildVariableList>k__BackingField; // 0xC0
	[CompilerGenerated]
	private FishingFishData[] <FishList>k__BackingField; // 0xC8
	[CompilerGenerated]
	private FishingRodData <Rod>k__BackingField; // 0xD0
	[CompilerGenerated]
	private PaletteData[] <PaletteList>k__BackingField; // 0xD8
	[CompilerGenerated]
	private FishingRandomTargetData[] <RandomTargetList>k__BackingField; // 0xE0
	[CompilerGenerated]
	private int[] <IdList>k__BackingField; // 0xE8
	[CompilerGenerated]
	private OrbBonusData[] <OrbBonusList>k__BackingField; // 0xF0
	[CompilerGenerated]
	private int <AccountProgress>k__BackingField; // 0xF8
	[CompilerGenerated]
	private MissionCommon <MissionData>k__BackingField; // 0x100
	[CompilerGenerated]
	private RoguelikeRingData[] <RoguelikeRings>k__BackingField; // 0x108

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketClass(Code = 148, IsOptional = True)]
	public ItemDatav2[] ItemList { get; set; }
	[PacketClass(Code = 231, IsOptional = True)]
	public OrbItemData[] OrbItemList { get; set; }
	[PacketClass(Code = 71, IsOptional = True)]
	public OrbEquipItemData[] OrbEquipList { get; set; }
	[PacketParameter(Code = 29, IsOptional = True)]
	public short Level { get; set; }
	[PacketParameter(Code = 28, IsOptional = True)]
	public int Gold { get; set; }
	[PacketParameter(Code = 39, IsOptional = True)]
	public short StatusPoint { get; set; }
	[PacketParameter(Code = 40, IsOptional = True)]
	public short SkillPoint { get; set; }
	[PacketParameter(Code = 158, IsOptional = True)]
	public int ScenarioProgress { get; set; }
	[PacketParameter(Code = 154, IsOptional = True)]
	public int MissionId { get; set; }
	[PacketParameter(Code = 102, IsOptional = True)]
	public Dictionary<short, byte> SkillList { get; set; }
	[PacketParameter(Code = 221, IsOptional = True)]
	public byte ComboPoint { get; set; }
	[PacketParameter(Code = 195, IsOptional = True)]
	public int Value { get; set; }
	[PacketParameter(Code = 18, IsOptional = True)]
	public Dictionary<object, object> Params { get; set; }
	[PacketParameter(Code = 54, IsOptional = True)]
	public short[] Position { get; set; }
	[PacketParameter(Code = 177, IsOptional = True)]
	public byte ChannelId { get; set; }
	[PacketParameter(Code = 147, IsOptional = True)]
	public MaterialData[] MaterialList { get; set; }
	[PacketParameter(Code = 191, IsOptional = True)]
	public TimeData ContinuousTime { get; set; }
	[PacketParameter(Code = 192, IsOptional = True)]
	public TimeData TotalTime { get; set; }
	[PacketParameter(Code = 162, IsOptional = True)]
	public byte[] TrophyData { get; set; }
	[PacketClass(Code = 152, IsOptional = True)]
	public ProficiencyData ProficiencyData { get; set; }
	[PacketClass(Code = 199, IsOptional = True)]
	public PetInfoData Pet { get; set; }
	[PacketClass(Code = 213, IsOptional = True)]
	public GemCartData GemCart { get; set; }
	[PacketParameter(Code = 172, IsOptional = True)]
	public long Time { get; set; }
	[PacketClass(Code = 204, IsOptional = True)]
	public GuildVariableData[] GuildVariableList { get; set; }
	[PacketClass(Code = 235, IsOptional = True)]
	public FishingFishData[] FishList { get; set; }
	[PacketClass(Code = 175, IsOptional = True)]
	public FishingRodData Rod { get; set; }
	[PacketClass(Code = 241, IsOptional = True)]
	public PaletteData[] PaletteList { get; set; }
	[PacketClass(Code = 33, IsOptional = True)]
	public FishingRandomTargetData[] RandomTargetList { get; set; }
	[PacketParameter(Code = 34, IsOptional = True)]
	public int[] IdList { get; set; }
	[PacketClass(Code = 36, IsOptional = True)]
	public OrbBonusData[] OrbBonusList { get; set; }
	public int AccountProgress { get; set; }
	public MissionCommon MissionData { get; set; }
	[PacketClass(Code = 52, IsOptional = True)]
	public RoguelikeRingData[] RoguelikeRings { get; set; }

	// Methods

	// RVA: 0x3797010 Offset: 0x3793010 VA: 0x3797010
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3797018 Offset: 0x3793018 VA: 0x3797018 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3797020 Offset: 0x3793020 VA: 0x3797020 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3797028 Offset: 0x3793028 VA: 0x3797028
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3797030 Offset: 0x3793030 VA: 0x3797030
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3797038 Offset: 0x3793038 VA: 0x3797038
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x3797040 Offset: 0x3793040 VA: 0x3797040
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3797048 Offset: 0x3793048 VA: 0x3797048
	public OrbItemData[] get_OrbItemList() { }

	[CompilerGenerated]
	// RVA: 0x3797050 Offset: 0x3793050 VA: 0x3797050
	public void set_OrbItemList(OrbItemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3797058 Offset: 0x3793058 VA: 0x3797058
	public OrbEquipItemData[] get_OrbEquipList() { }

	[CompilerGenerated]
	// RVA: 0x3797060 Offset: 0x3793060 VA: 0x3797060
	public void set_OrbEquipList(OrbEquipItemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3797068 Offset: 0x3793068 VA: 0x3797068
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x3797070 Offset: 0x3793070 VA: 0x3797070
	public void set_Level(short value) { }

	[CompilerGenerated]
	// RVA: 0x3797078 Offset: 0x3793078 VA: 0x3797078
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3797080 Offset: 0x3793080 VA: 0x3797080
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x3797088 Offset: 0x3793088 VA: 0x3797088
	public short get_StatusPoint() { }

	[CompilerGenerated]
	// RVA: 0x3797090 Offset: 0x3793090 VA: 0x3797090
	public void set_StatusPoint(short value) { }

	[CompilerGenerated]
	// RVA: 0x3797098 Offset: 0x3793098 VA: 0x3797098
	public short get_SkillPoint() { }

	[CompilerGenerated]
	// RVA: 0x37970A0 Offset: 0x37930A0 VA: 0x37970A0
	public void set_SkillPoint(short value) { }

	[CompilerGenerated]
	// RVA: 0x37970A8 Offset: 0x37930A8 VA: 0x37970A8
	public int get_ScenarioProgress() { }

	[CompilerGenerated]
	// RVA: 0x37970B0 Offset: 0x37930B0 VA: 0x37970B0
	public void set_ScenarioProgress(int value) { }

	[CompilerGenerated]
	// RVA: 0x37970B8 Offset: 0x37930B8 VA: 0x37970B8
	public int get_MissionId() { }

	[CompilerGenerated]
	// RVA: 0x37970C0 Offset: 0x37930C0 VA: 0x37970C0
	public void set_MissionId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37970C8 Offset: 0x37930C8 VA: 0x37970C8
	public Dictionary<short, byte> get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x37970D0 Offset: 0x37930D0 VA: 0x37970D0
	public void set_SkillList(Dictionary<short, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x37970D8 Offset: 0x37930D8 VA: 0x37970D8
	public byte get_ComboPoint() { }

	[CompilerGenerated]
	// RVA: 0x37970E0 Offset: 0x37930E0 VA: 0x37970E0
	public void set_ComboPoint(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37970E8 Offset: 0x37930E8 VA: 0x37970E8
	public int get_Value() { }

	[CompilerGenerated]
	// RVA: 0x37970F0 Offset: 0x37930F0 VA: 0x37970F0
	public void set_Value(int value) { }

	[CompilerGenerated]
	// RVA: 0x37970F8 Offset: 0x37930F8 VA: 0x37970F8
	public Dictionary<object, object> get_Params() { }

	[CompilerGenerated]
	// RVA: 0x3797100 Offset: 0x3793100 VA: 0x3797100
	public void set_Params(Dictionary<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x3797108 Offset: 0x3793108 VA: 0x3797108
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3797110 Offset: 0x3793110 VA: 0x3797110
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3797118 Offset: 0x3793118 VA: 0x3797118
	public byte get_ChannelId() { }

	[CompilerGenerated]
	// RVA: 0x3797120 Offset: 0x3793120 VA: 0x3797120
	public void set_ChannelId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3797128 Offset: 0x3793128 VA: 0x3797128
	public MaterialData[] get_MaterialList() { }

	[CompilerGenerated]
	// RVA: 0x3797130 Offset: 0x3793130 VA: 0x3797130
	public void set_MaterialList(MaterialData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3797138 Offset: 0x3793138 VA: 0x3797138
	public TimeData get_ContinuousTime() { }

	[CompilerGenerated]
	// RVA: 0x3797140 Offset: 0x3793140 VA: 0x3797140
	public void set_ContinuousTime(TimeData value) { }

	[CompilerGenerated]
	// RVA: 0x3797148 Offset: 0x3793148 VA: 0x3797148
	public TimeData get_TotalTime() { }

	[CompilerGenerated]
	// RVA: 0x3797150 Offset: 0x3793150 VA: 0x3797150
	public void set_TotalTime(TimeData value) { }

	[CompilerGenerated]
	// RVA: 0x3797158 Offset: 0x3793158 VA: 0x3797158
	public byte[] get_TrophyData() { }

	[CompilerGenerated]
	// RVA: 0x3797160 Offset: 0x3793160 VA: 0x3797160
	public void set_TrophyData(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x3797168 Offset: 0x3793168 VA: 0x3797168
	public ProficiencyData get_ProficiencyData() { }

	[CompilerGenerated]
	// RVA: 0x3797170 Offset: 0x3793170 VA: 0x3797170
	public void set_ProficiencyData(ProficiencyData value) { }

	[CompilerGenerated]
	// RVA: 0x3797178 Offset: 0x3793178 VA: 0x3797178
	public PetInfoData get_Pet() { }

	[CompilerGenerated]
	// RVA: 0x3797180 Offset: 0x3793180 VA: 0x3797180
	public void set_Pet(PetInfoData value) { }

	[CompilerGenerated]
	// RVA: 0x3797188 Offset: 0x3793188 VA: 0x3797188
	public GemCartData get_GemCart() { }

	[CompilerGenerated]
	// RVA: 0x3797190 Offset: 0x3793190 VA: 0x3797190
	public void set_GemCart(GemCartData value) { }

	[CompilerGenerated]
	// RVA: 0x3797198 Offset: 0x3793198 VA: 0x3797198
	public long get_Time() { }

	[CompilerGenerated]
	// RVA: 0x37971A0 Offset: 0x37931A0 VA: 0x37971A0
	public void set_Time(long value) { }

	[CompilerGenerated]
	// RVA: 0x37971A8 Offset: 0x37931A8 VA: 0x37971A8
	public GuildVariableData[] get_GuildVariableList() { }

	[CompilerGenerated]
	// RVA: 0x37971B0 Offset: 0x37931B0 VA: 0x37971B0
	public void set_GuildVariableList(GuildVariableData[] value) { }

	[CompilerGenerated]
	// RVA: 0x37971B8 Offset: 0x37931B8 VA: 0x37971B8
	public FishingFishData[] get_FishList() { }

	[CompilerGenerated]
	// RVA: 0x37971C0 Offset: 0x37931C0 VA: 0x37971C0
	public void set_FishList(FishingFishData[] value) { }

	[CompilerGenerated]
	// RVA: 0x37971C8 Offset: 0x37931C8 VA: 0x37971C8
	public FishingRodData get_Rod() { }

	[CompilerGenerated]
	// RVA: 0x37971D0 Offset: 0x37931D0 VA: 0x37971D0
	public void set_Rod(FishingRodData value) { }

	[CompilerGenerated]
	// RVA: 0x37971D8 Offset: 0x37931D8 VA: 0x37971D8
	public PaletteData[] get_PaletteList() { }

	[CompilerGenerated]
	// RVA: 0x37971E0 Offset: 0x37931E0 VA: 0x37971E0
	public void set_PaletteList(PaletteData[] value) { }

	[CompilerGenerated]
	// RVA: 0x37971E8 Offset: 0x37931E8 VA: 0x37971E8
	public FishingRandomTargetData[] get_RandomTargetList() { }

	[CompilerGenerated]
	// RVA: 0x37971F0 Offset: 0x37931F0 VA: 0x37971F0
	public void set_RandomTargetList(FishingRandomTargetData[] value) { }

	[CompilerGenerated]
	// RVA: 0x37971F8 Offset: 0x37931F8 VA: 0x37971F8
	public int[] get_IdList() { }

	[CompilerGenerated]
	// RVA: 0x3797200 Offset: 0x3793200 VA: 0x3797200
	public void set_IdList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3797208 Offset: 0x3793208 VA: 0x3797208
	public OrbBonusData[] get_OrbBonusList() { }

	[CompilerGenerated]
	// RVA: 0x3797210 Offset: 0x3793210 VA: 0x3797210
	public void set_OrbBonusList(OrbBonusData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3797218 Offset: 0x3793218 VA: 0x3797218
	public int get_AccountProgress() { }

	[CompilerGenerated]
	// RVA: 0x3797220 Offset: 0x3793220 VA: 0x3797220
	public void set_AccountProgress(int value) { }

	[CompilerGenerated]
	// RVA: 0x3797228 Offset: 0x3793228 VA: 0x3797228
	public MissionCommon get_MissionData() { }

	[CompilerGenerated]
	// RVA: 0x3797230 Offset: 0x3793230 VA: 0x3797230
	public void set_MissionData(MissionCommon value) { }

	[CompilerGenerated]
	// RVA: 0x3797240 Offset: 0x3793240 VA: 0x3797240
	public RoguelikeRingData[] get_RoguelikeRings() { }

	[CompilerGenerated]
	// RVA: 0x3797248 Offset: 0x3793248 VA: 0x3797248
	public void set_RoguelikeRings(RoguelikeRingData[] value) { }

	// RVA: 0x3797258 Offset: 0x3793258 VA: 0x3797258
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3797C7C Offset: 0x3793C7C VA: 0x3797C7C
	private void GetClass(Dictionary<byte, object> dictionary) { }

	// RVA: 0x3798078 Offset: 0x3794078 VA: 0x3798078 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37988A0 Offset: 0x37948A0 VA: 0x37988A0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
