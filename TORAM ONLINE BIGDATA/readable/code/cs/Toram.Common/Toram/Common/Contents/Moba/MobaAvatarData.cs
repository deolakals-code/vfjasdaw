// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Contents.Moba
public class MobaAvatarData : PacketBase // TypeDefIndex: 11205
{
	// Fields
	[CompilerGenerated]
	private MobaFixedPropertiesData <FixedProperties>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<byte, object> <VariableProperties>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <VariablePropertiesRevision>k__BackingField; // 0x30
	[CompilerGenerated]
	private ContentPositionData <AvatarPosition>k__BackingField; // 0x38
	[CompilerGenerated]
	private PrimaryStatusData <PrimaryStatus>k__BackingField; // 0x40
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x48
	[CompilerGenerated]
	private Dictionary<short, byte> <SkillList>k__BackingField; // 0x50
	[CompilerGenerated]
	private SkillComboData[] <SkillCombo>k__BackingField; // 0x58
	[CompilerGenerated]
	private byte <MaxRegistletSlot>k__BackingField; // 0x60
	[CompilerGenerated]
	private GemCartEquipData[] <GemCartEquipList>k__BackingField; // 0x68
	[CompilerGenerated]
	private GemCartData[] <GemCartBag>k__BackingField; // 0x70
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x78
	[CompilerGenerated]
	private MobaEquipData <Equip>k__BackingField; // 0x80
	[CompilerGenerated]
	private int[] <Abilities>k__BackingField; // 0x88
	[CompilerGenerated]
	private StarGemEquipData[] <StarGemEquips>k__BackingField; // 0x90
	[CompilerGenerated]
	private short <RespawnTime>k__BackingField; // 0x98
	[CompilerGenerated]
	private MobaProfileData <Profile>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Dictionary<int, long> <Chests>k__BackingField; // 0xA8
	[CompilerGenerated]
	private short <OwnerLevel>k__BackingField; // 0xB0
	[CompilerGenerated]
	private byte <PopAreaNo>k__BackingField; // 0xB2
	[CompilerGenerated]
	private int <SecondUntilNextWarp>k__BackingField; // 0xB4
	[CompilerGenerated]
	private Dictionary<short, byte[]> <ExSkillConfigList>k__BackingField; // 0xB8

	// Properties
	public MobaFixedPropertiesData FixedProperties { get; set; }
	public Dictionary<byte, object> VariableProperties { get; set; }
	public int VariablePropertiesRevision { get; set; }
	public ContentPositionData AvatarPosition { get; set; }
	public PrimaryStatusData PrimaryStatus { get; set; }
	public GameStatusData GameStatus { get; set; }
	public Dictionary<short, byte> SkillList { get; set; }
	public SkillComboData[] SkillCombo { get; set; }
	public byte MaxRegistletSlot { get; set; }
	public GemCartEquipData[] GemCartEquipList { get; set; }
	public GemCartData[] GemCartBag { get; set; }
	public int Gold { get; set; }
	public MobaEquipData Equip { get; set; }
	public int[] Abilities { get; set; }
	public StarGemEquipData[] StarGemEquips { get; set; }
	public short RespawnTime { get; set; }
	public MobaProfileData Profile { get; set; }
	public Dictionary<int, long> Chests { get; set; }
	public short OwnerLevel { get; set; }
	public byte PopAreaNo { get; set; }
	public int SecondUntilNextWarp { get; set; }
	public Dictionary<short, byte[]> ExSkillConfigList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35D815C Offset: 0x35D415C VA: 0x35D815C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35D8164 Offset: 0x35D4164 VA: 0x35D8164
	public MobaFixedPropertiesData get_FixedProperties() { }

	[CompilerGenerated]
	// RVA: 0x35D816C Offset: 0x35D416C VA: 0x35D816C
	public void set_FixedProperties(MobaFixedPropertiesData value) { }

	[CompilerGenerated]
	// RVA: 0x35D8174 Offset: 0x35D4174 VA: 0x35D8174
	public Dictionary<byte, object> get_VariableProperties() { }

	[CompilerGenerated]
	// RVA: 0x35D817C Offset: 0x35D417C VA: 0x35D817C
	public void set_VariableProperties(Dictionary<byte, object> value) { }

	[CompilerGenerated]
	// RVA: 0x35D8184 Offset: 0x35D4184 VA: 0x35D8184
	public int get_VariablePropertiesRevision() { }

	[CompilerGenerated]
	// RVA: 0x35D818C Offset: 0x35D418C VA: 0x35D818C
	public void set_VariablePropertiesRevision(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D8194 Offset: 0x35D4194 VA: 0x35D8194
	public ContentPositionData get_AvatarPosition() { }

	[CompilerGenerated]
	// RVA: 0x35D819C Offset: 0x35D419C VA: 0x35D819C
	public void set_AvatarPosition(ContentPositionData value) { }

	[CompilerGenerated]
	// RVA: 0x35D81A4 Offset: 0x35D41A4 VA: 0x35D81A4
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x35D81AC Offset: 0x35D41AC VA: 0x35D81AC
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x35D81B4 Offset: 0x35D41B4 VA: 0x35D81B4
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x35D81BC Offset: 0x35D41BC VA: 0x35D81BC
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x35D81C4 Offset: 0x35D41C4 VA: 0x35D81C4
	public Dictionary<short, byte> get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x35D81CC Offset: 0x35D41CC VA: 0x35D81CC
	public void set_SkillList(Dictionary<short, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x35D81D4 Offset: 0x35D41D4 VA: 0x35D81D4
	public SkillComboData[] get_SkillCombo() { }

	[CompilerGenerated]
	// RVA: 0x35D81DC Offset: 0x35D41DC VA: 0x35D81DC
	public void set_SkillCombo(SkillComboData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35D81E4 Offset: 0x35D41E4 VA: 0x35D81E4
	public byte get_MaxRegistletSlot() { }

	[CompilerGenerated]
	// RVA: 0x35D81EC Offset: 0x35D41EC VA: 0x35D81EC
	public void set_MaxRegistletSlot(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D81F4 Offset: 0x35D41F4 VA: 0x35D81F4
	public GemCartEquipData[] get_GemCartEquipList() { }

	[CompilerGenerated]
	// RVA: 0x35D81FC Offset: 0x35D41FC VA: 0x35D81FC
	public void set_GemCartEquipList(GemCartEquipData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35D8204 Offset: 0x35D4204 VA: 0x35D8204
	public GemCartData[] get_GemCartBag() { }

	[CompilerGenerated]
	// RVA: 0x35D820C Offset: 0x35D420C VA: 0x35D820C
	public void set_GemCartBag(GemCartData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35D8214 Offset: 0x35D4214 VA: 0x35D8214
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x35D821C Offset: 0x35D421C VA: 0x35D821C
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D8224 Offset: 0x35D4224 VA: 0x35D8224
	public MobaEquipData get_Equip() { }

	[CompilerGenerated]
	// RVA: 0x35D822C Offset: 0x35D422C VA: 0x35D822C
	public void set_Equip(MobaEquipData value) { }

	[CompilerGenerated]
	// RVA: 0x35D8234 Offset: 0x35D4234 VA: 0x35D8234
	public int[] get_Abilities() { }

	[CompilerGenerated]
	// RVA: 0x35D823C Offset: 0x35D423C VA: 0x35D823C
	public void set_Abilities(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x35D8244 Offset: 0x35D4244 VA: 0x35D8244
	public StarGemEquipData[] get_StarGemEquips() { }

	[CompilerGenerated]
	// RVA: 0x35D824C Offset: 0x35D424C VA: 0x35D824C
	public void set_StarGemEquips(StarGemEquipData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35D8254 Offset: 0x35D4254 VA: 0x35D8254
	public short get_RespawnTime() { }

	[CompilerGenerated]
	// RVA: 0x35D825C Offset: 0x35D425C VA: 0x35D825C
	public void set_RespawnTime(short value) { }

	[CompilerGenerated]
	// RVA: 0x35D8264 Offset: 0x35D4264 VA: 0x35D8264
	public MobaProfileData get_Profile() { }

	[CompilerGenerated]
	// RVA: 0x35D826C Offset: 0x35D426C VA: 0x35D826C
	public void set_Profile(MobaProfileData value) { }

	[CompilerGenerated]
	// RVA: 0x35D8274 Offset: 0x35D4274 VA: 0x35D8274
	public Dictionary<int, long> get_Chests() { }

	[CompilerGenerated]
	// RVA: 0x35D827C Offset: 0x35D427C VA: 0x35D827C
	public void set_Chests(Dictionary<int, long> value) { }

	[CompilerGenerated]
	// RVA: 0x35D8284 Offset: 0x35D4284 VA: 0x35D8284
	public short get_OwnerLevel() { }

	[CompilerGenerated]
	// RVA: 0x35D828C Offset: 0x35D428C VA: 0x35D828C
	public void set_OwnerLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x35D8294 Offset: 0x35D4294 VA: 0x35D8294
	public byte get_PopAreaNo() { }

	[CompilerGenerated]
	// RVA: 0x35D829C Offset: 0x35D429C VA: 0x35D829C
	public void set_PopAreaNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D82A4 Offset: 0x35D42A4 VA: 0x35D82A4
	public int get_SecondUntilNextWarp() { }

	[CompilerGenerated]
	// RVA: 0x35D82AC Offset: 0x35D42AC VA: 0x35D82AC
	public void set_SecondUntilNextWarp(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D82B4 Offset: 0x35D42B4 VA: 0x35D82B4
	public Dictionary<short, byte[]> get_ExSkillConfigList() { }

	[CompilerGenerated]
	// RVA: 0x35D82BC Offset: 0x35D42BC VA: 0x35D82BC
	public void set_ExSkillConfigList(Dictionary<short, byte[]> value) { }

	// RVA: 0x35D82C4 Offset: 0x35D42C4 VA: 0x35D82C4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35D82CC Offset: 0x35D42CC VA: 0x35D82CC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35D8720 Offset: 0x35D4720 VA: 0x35D8720 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
