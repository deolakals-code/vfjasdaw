// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobResponseData : UnityHashBase, IMobIdData // TypeDefIndex: 13175
{
	// Fields
	[CompilerGenerated]
	private byte <ReturnCode>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <MobId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UniqueId>k__BackingField; // 0x24
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <State>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <NormalDefExp>k__BackingField; // 0x3C
	[CompilerGenerated]
	private byte <PhysicsDefExp>k__BackingField; // 0x3D
	[CompilerGenerated]
	private byte <MagicDefExp>k__BackingField; // 0x3E
	[CompilerGenerated]
	private MobHateData[] <MobHateList>k__BackingField; // 0x40
	[CompilerGenerated]
	private AbnormalData[] <AbnormalStateList>k__BackingField; // 0x48
	[CompilerGenerated]
	private AbnormalData <AddAbnormalState>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <AbnormalDamage>k__BackingField; // 0x58
	[CompilerGenerated]
	private MobPartData[] <PartList>k__BackingField; // 0x60
	[CompilerGenerated]
	private MobBuffData[] <BuffList>k__BackingField; // 0x68
	[CompilerGenerated]
	private int <AllowDamage>k__BackingField; // 0x70
	[CompilerGenerated]
	private byte <MaxHpCount>k__BackingField; // 0x74
	[CompilerGenerated]
	private byte <CurrentHpCount>k__BackingField; // 0x75
	[CompilerGenerated]
	private AbnormalHitData[] <AbnormalHitList>k__BackingField; // 0x78
	[CompilerGenerated]
	private MobBuffData <AddMobBufferData>k__BackingField; // 0x80
	[CompilerGenerated]
	private int <ViolationDamage>k__BackingField; // 0x88
	[CompilerGenerated]
	private short <CurrentLv>k__BackingField; // 0x8C

	// Properties
	[UnityHash(Code = 58, IsOptional = True)]
	public byte ReturnCode { get; set; }
	[UnityHash(Code = 22)]
	public int MobId { get; set; }
	[UnityHash(Code = 23)]
	public byte LocalId { get; set; }
	[UnityHash(Code = 24)]
	public int UniqueId { get; set; }
	[UnityHash(Code = 10, IsOptional = True)]
	public short[] Position { get; set; }
	[UnityHash(Code = 11, IsOptional = True)]
	public short Rotation { get; set; }
	[UnityHash(Code = 12, IsOptional = True)]
	public int Hp { get; set; }
	[UnityHash(Code = 18, IsOptional = True)]
	public int State { get; set; }
	[UnityHash(Code = 26, Default = 100, IsOptional = True)]
	public byte NormalDefExp { get; set; }
	[UnityHash(Code = 27, Default = 100, IsOptional = True)]
	public byte PhysicsDefExp { get; set; }
	[UnityHash(Code = 28, Default = 100, IsOptional = True)]
	public byte MagicDefExp { get; set; }
	[UnityHash(Code = 30, IsOptional = True)]
	public MobHateData[] MobHateList { get; set; }
	[UnityHash(Code = 52, IsOptional = True)]
	public AbnormalData[] AbnormalStateList { get; set; }
	[UnityHash(Code = 51, IsOptional = True)]
	public AbnormalData AddAbnormalState { get; set; }
	[UnityHash(Code = 49, IsOptional = True)]
	public int AbnormalDamage { get; set; }
	[UnityHash(Code = 31, IsOptional = True)]
	public MobPartData[] PartList { get; set; }
	[UnityHash(Code = 86, IsOptional = True)]
	public MobBuffData[] BuffList { get; set; }
	[UnityHash(Code = 55)]
	public int AllowDamage { get; set; }
	[UnityHash(Code = 89, IsOptional = True)]
	public byte MaxHpCount { get; set; }
	[UnityHash(Code = 90, IsOptional = True)]
	public byte CurrentHpCount { get; set; }
	[UnityHash(Code = 54, IsOptional = True)]
	public AbnormalHitData[] AbnormalHitList { get; set; }
	public MobBuffData AddMobBufferData { get; set; }
	public int ViolationDamage { get; set; }
	public short CurrentLv { get; set; }
	public override byte Code { get; }
	public MobData MobData { get; }

	// Methods

	// RVA: 0x36BDBD8 Offset: 0x36B9BD8 VA: 0x36BDBD8
	public void .ctor() { }

	// RVA: 0x36B9DAC Offset: 0x36B5DAC VA: 0x36B9DAC
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36BCD70 Offset: 0x36B8D70 VA: 0x36BCD70
	public void .ctor(int mobId, byte localId, int uniqueId) { }

	[CompilerGenerated]
	// RVA: 0x36BDBE0 Offset: 0x36B9BE0 VA: 0x36BDBE0
	public byte get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x36BDBE8 Offset: 0x36B9BE8 VA: 0x36BDBE8
	public void set_ReturnCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BDBF0 Offset: 0x36B9BF0 VA: 0x36BDBF0 Slot: 7
	public int get_MobId() { }

	[CompilerGenerated]
	// RVA: 0x36BDBF8 Offset: 0x36B9BF8 VA: 0x36BDBF8
	public void set_MobId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36BDC00 Offset: 0x36B9C00 VA: 0x36BDC00 Slot: 8
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36BDC08 Offset: 0x36B9C08 VA: 0x36BDC08
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BDC10 Offset: 0x36B9C10 VA: 0x36BDC10 Slot: 9
	public int get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x36BDC18 Offset: 0x36B9C18 VA: 0x36BDC18
	public void set_UniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36BDC20 Offset: 0x36B9C20 VA: 0x36BDC20
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36BDC28 Offset: 0x36B9C28 VA: 0x36BDC28
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36BDC30 Offset: 0x36B9C30 VA: 0x36BDC30
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36BDC38 Offset: 0x36B9C38 VA: 0x36BDC38
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x36BDC40 Offset: 0x36B9C40 VA: 0x36BDC40
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x36BDC48 Offset: 0x36B9C48 VA: 0x36BDC48
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x36BDC50 Offset: 0x36B9C50 VA: 0x36BDC50
	public int get_State() { }

	[CompilerGenerated]
	// RVA: 0x36BDC58 Offset: 0x36B9C58 VA: 0x36BDC58
	public void set_State(int value) { }

	[CompilerGenerated]
	// RVA: 0x36BDC60 Offset: 0x36B9C60 VA: 0x36BDC60
	public byte get_NormalDefExp() { }

	[CompilerGenerated]
	// RVA: 0x36BDC68 Offset: 0x36B9C68 VA: 0x36BDC68
	public void set_NormalDefExp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BDC70 Offset: 0x36B9C70 VA: 0x36BDC70
	public byte get_PhysicsDefExp() { }

	[CompilerGenerated]
	// RVA: 0x36BDC78 Offset: 0x36B9C78 VA: 0x36BDC78
	public void set_PhysicsDefExp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BDC80 Offset: 0x36B9C80 VA: 0x36BDC80
	public byte get_MagicDefExp() { }

	[CompilerGenerated]
	// RVA: 0x36BDC88 Offset: 0x36B9C88 VA: 0x36BDC88
	public void set_MagicDefExp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BDC90 Offset: 0x36B9C90 VA: 0x36BDC90
	public MobHateData[] get_MobHateList() { }

	[CompilerGenerated]
	// RVA: 0x36BDC98 Offset: 0x36B9C98 VA: 0x36BDC98
	public void set_MobHateList(MobHateData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36BDCA0 Offset: 0x36B9CA0 VA: 0x36BDCA0
	public AbnormalData[] get_AbnormalStateList() { }

	[CompilerGenerated]
	// RVA: 0x36BDCA8 Offset: 0x36B9CA8 VA: 0x36BDCA8
	public void set_AbnormalStateList(AbnormalData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36BDCB0 Offset: 0x36B9CB0 VA: 0x36BDCB0
	public AbnormalData get_AddAbnormalState() { }

	[CompilerGenerated]
	// RVA: 0x36BDCB8 Offset: 0x36B9CB8 VA: 0x36BDCB8
	public void set_AddAbnormalState(AbnormalData value) { }

	[CompilerGenerated]
	// RVA: 0x36BDCC0 Offset: 0x36B9CC0 VA: 0x36BDCC0
	public int get_AbnormalDamage() { }

	[CompilerGenerated]
	// RVA: 0x36BDCC8 Offset: 0x36B9CC8 VA: 0x36BDCC8
	public void set_AbnormalDamage(int value) { }

	[CompilerGenerated]
	// RVA: 0x36BDCD0 Offset: 0x36B9CD0 VA: 0x36BDCD0
	public MobPartData[] get_PartList() { }

	[CompilerGenerated]
	// RVA: 0x36BDCD8 Offset: 0x36B9CD8 VA: 0x36BDCD8
	public void set_PartList(MobPartData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36BDCE0 Offset: 0x36B9CE0 VA: 0x36BDCE0
	public MobBuffData[] get_BuffList() { }

	[CompilerGenerated]
	// RVA: 0x36BDCE8 Offset: 0x36B9CE8 VA: 0x36BDCE8
	public void set_BuffList(MobBuffData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36BDCF0 Offset: 0x36B9CF0 VA: 0x36BDCF0
	public int get_AllowDamage() { }

	[CompilerGenerated]
	// RVA: 0x36BDCF8 Offset: 0x36B9CF8 VA: 0x36BDCF8
	public void set_AllowDamage(int value) { }

	[CompilerGenerated]
	// RVA: 0x36BDD00 Offset: 0x36B9D00 VA: 0x36BDD00
	public byte get_MaxHpCount() { }

	[CompilerGenerated]
	// RVA: 0x36BDD08 Offset: 0x36B9D08 VA: 0x36BDD08
	public void set_MaxHpCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BDD10 Offset: 0x36B9D10 VA: 0x36BDD10
	public byte get_CurrentHpCount() { }

	[CompilerGenerated]
	// RVA: 0x36BDD18 Offset: 0x36B9D18 VA: 0x36BDD18
	public void set_CurrentHpCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BDD20 Offset: 0x36B9D20 VA: 0x36BDD20
	public AbnormalHitData[] get_AbnormalHitList() { }

	[CompilerGenerated]
	// RVA: 0x36BDD28 Offset: 0x36B9D28 VA: 0x36BDD28
	public void set_AbnormalHitList(AbnormalHitData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36BDD30 Offset: 0x36B9D30 VA: 0x36BDD30
	public MobBuffData get_AddMobBufferData() { }

	[CompilerGenerated]
	// RVA: 0x36BDD38 Offset: 0x36B9D38 VA: 0x36BDD38
	public void set_AddMobBufferData(MobBuffData value) { }

	[CompilerGenerated]
	// RVA: 0x36BDD40 Offset: 0x36B9D40 VA: 0x36BDD40
	public int get_ViolationDamage() { }

	[CompilerGenerated]
	// RVA: 0x36BDD48 Offset: 0x36B9D48 VA: 0x36BDD48
	public void set_ViolationDamage(int value) { }

	[CompilerGenerated]
	// RVA: 0x36BDD50 Offset: 0x36B9D50 VA: 0x36BDD50
	public short get_CurrentLv() { }

	[CompilerGenerated]
	// RVA: 0x36BDD58 Offset: 0x36B9D58 VA: 0x36BDD58
	public void set_CurrentLv(short value) { }

	// RVA: 0x36BDD60 Offset: 0x36B9D60 VA: 0x36BDD60 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36BDD68 Offset: 0x36B9D68 VA: 0x36BDD68 Slot: 3
	public override string ToString() { }

	// RVA: 0x36BDE40 Offset: 0x36B9E40 VA: 0x36BDE40
	public MobData get_MobData() { }

	// RVA: 0x36BDF40 Offset: 0x36B9F40 VA: 0x36BDF40 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36BEF30 Offset: 0x36BAF30 VA: 0x36BEF30 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
