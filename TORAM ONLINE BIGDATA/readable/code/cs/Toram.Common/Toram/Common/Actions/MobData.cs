// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobData : UnityHashBase, IMobIdData // TypeDefIndex: 13171
{
	// Fields
	[CompilerGenerated]
	private int <MobId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UniqueId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <State>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <NowNormalDefExp>k__BackingField; // 0x3A
	[CompilerGenerated]
	private byte <NowPhysicDefExp>k__BackingField; // 0x3B
	[CompilerGenerated]
	private byte <NowMagicDefExp>k__BackingField; // 0x3C
	[CompilerGenerated]
	private MobHateData[] <Hate>k__BackingField; // 0x40
	[CompilerGenerated]
	private AbnormalData[] <AbnormalStateList>k__BackingField; // 0x48
	[CompilerGenerated]
	private MobPartData[] <PartsList>k__BackingField; // 0x50
	[CompilerGenerated]
	private MobBuffData[] <BuffList>k__BackingField; // 0x58
	[CompilerGenerated]
	private byte <ReturnCode>k__BackingField; // 0x60
	[CompilerGenerated]
	private int <AllowDamage>k__BackingField; // 0x64

	// Properties
	[UnityHash(Code = 22, IsOptional = True)]
	public int MobId { get; set; }
	[UnityHash(Code = 23, IsOptional = True)]
	public byte LocalId { get; set; }
	[UnityHash(Code = 24, IsOptional = True)]
	public int UniqueId { get; set; }
	[UnityHash(Code = 12, IsOptional = True)]
	public int Hp { get; set; }
	[UnityHash(Code = 18, IsOptional = True)]
	public int State { get; set; }
	[UnityHash(Code = 10, IsOptional = True)]
	public short[] Position { get; set; }
	[UnityHash(Code = 11, IsOptional = True)]
	public short Rotation { get; set; }
	[UnityHash(Code = 26, Default = 100, IsOptional = True)]
	public byte NowNormalDefExp { get; set; }
	[UnityHash(Code = 27, Default = 100, IsOptional = True)]
	public byte NowPhysicDefExp { get; set; }
	[UnityHash(Code = 28, Default = 100, IsOptional = True)]
	public byte NowMagicDefExp { get; set; }
	[UnityHash(Code = 30, IsOptional = True)]
	public MobHateData[] Hate { get; set; }
	[UnityHash(Code = 52, IsOptional = True)]
	public AbnormalData[] AbnormalStateList { get; set; }
	[UnityHash(Code = 31, IsOptional = True)]
	public MobPartData[] PartsList { get; set; }
	[UnityHash(Code = 86)]
	public MobBuffData[] BuffList { get; set; }
	[UnityHash(Code = 58, IsOptional = True)]
	public byte ReturnCode { get; set; }
	[UnityHash(Code = 55, IsOptional = True)]
	public int AllowDamage { get; set; }
	public MobResponseData MobResponseData { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36B5418 Offset: 0x36B1418 VA: 0x36B5418
	public void .ctor() { }

	// RVA: 0x36B5428 Offset: 0x36B1428 VA: 0x36B5428
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36BCB30 Offset: 0x36B8B30 VA: 0x36BCB30
	public void .ctor(int id, byte localId, int uniqueId) { }

	[CompilerGenerated]
	// RVA: 0x36BCB70 Offset: 0x36B8B70 VA: 0x36BCB70 Slot: 7
	public int get_MobId() { }

	[CompilerGenerated]
	// RVA: 0x36BCB78 Offset: 0x36B8B78 VA: 0x36BCB78
	public void set_MobId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36BCB80 Offset: 0x36B8B80 VA: 0x36BCB80 Slot: 8
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36BCB88 Offset: 0x36B8B88 VA: 0x36BCB88
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BCB90 Offset: 0x36B8B90 VA: 0x36BCB90 Slot: 9
	public int get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x36BCB98 Offset: 0x36B8B98 VA: 0x36BCB98
	public void set_UniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36BCBA0 Offset: 0x36B8BA0 VA: 0x36BCBA0
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x36BCBA8 Offset: 0x36B8BA8 VA: 0x36BCBA8
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x36BCBB0 Offset: 0x36B8BB0 VA: 0x36BCBB0
	public int get_State() { }

	[CompilerGenerated]
	// RVA: 0x36BCBB8 Offset: 0x36B8BB8 VA: 0x36BCBB8
	public void set_State(int value) { }

	[CompilerGenerated]
	// RVA: 0x36BCBC0 Offset: 0x36B8BC0 VA: 0x36BCBC0
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36BCBC8 Offset: 0x36B8BC8 VA: 0x36BCBC8
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36BCBD0 Offset: 0x36B8BD0 VA: 0x36BCBD0
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36BCBD8 Offset: 0x36B8BD8 VA: 0x36BCBD8
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x36BCBE0 Offset: 0x36B8BE0 VA: 0x36BCBE0
	public byte get_NowNormalDefExp() { }

	[CompilerGenerated]
	// RVA: 0x36BCBE8 Offset: 0x36B8BE8 VA: 0x36BCBE8
	public void set_NowNormalDefExp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BCBF0 Offset: 0x36B8BF0 VA: 0x36BCBF0
	public byte get_NowPhysicDefExp() { }

	[CompilerGenerated]
	// RVA: 0x36BCBF8 Offset: 0x36B8BF8 VA: 0x36BCBF8
	public void set_NowPhysicDefExp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BCC00 Offset: 0x36B8C00 VA: 0x36BCC00
	public byte get_NowMagicDefExp() { }

	[CompilerGenerated]
	// RVA: 0x36BCC08 Offset: 0x36B8C08 VA: 0x36BCC08
	public void set_NowMagicDefExp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BCC10 Offset: 0x36B8C10 VA: 0x36BCC10
	public MobHateData[] get_Hate() { }

	[CompilerGenerated]
	// RVA: 0x36BCC18 Offset: 0x36B8C18 VA: 0x36BCC18
	public void set_Hate(MobHateData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36BCC20 Offset: 0x36B8C20 VA: 0x36BCC20
	public AbnormalData[] get_AbnormalStateList() { }

	[CompilerGenerated]
	// RVA: 0x36BCC28 Offset: 0x36B8C28 VA: 0x36BCC28
	public void set_AbnormalStateList(AbnormalData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36BCC30 Offset: 0x36B8C30 VA: 0x36BCC30
	public MobPartData[] get_PartsList() { }

	[CompilerGenerated]
	// RVA: 0x36BCC38 Offset: 0x36B8C38 VA: 0x36BCC38
	public void set_PartsList(MobPartData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36BCC40 Offset: 0x36B8C40 VA: 0x36BCC40
	public MobBuffData[] get_BuffList() { }

	[CompilerGenerated]
	// RVA: 0x36BCC48 Offset: 0x36B8C48 VA: 0x36BCC48
	public void set_BuffList(MobBuffData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36BCC50 Offset: 0x36B8C50 VA: 0x36BCC50
	public byte get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x36BCC58 Offset: 0x36B8C58 VA: 0x36BCC58
	public void set_ReturnCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BCC60 Offset: 0x36B8C60 VA: 0x36BCC60
	public int get_AllowDamage() { }

	[CompilerGenerated]
	// RVA: 0x36BCC68 Offset: 0x36B8C68 VA: 0x36BCC68
	public void set_AllowDamage(int value) { }

	// RVA: 0x36BCC70 Offset: 0x36B8C70 VA: 0x36BCC70
	public MobResponseData get_MobResponseData() { }

	// RVA: 0x36BCDB0 Offset: 0x36B8DB0 VA: 0x36BCDB0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36BCDB8 Offset: 0x36B8DB8 VA: 0x36BCDB8 Slot: 3
	public override string ToString() { }

	// RVA: 0x36B5690 Offset: 0x36B1690 VA: 0x36B5690 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36B636C Offset: 0x36B236C VA: 0x36B636C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
