// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class AttackData : UnityHashBase // TypeDefIndex: 13110
{
	// Fields
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <DamageId>k__BackingField; // 0x1D
	[CompilerGenerated]
	private byte <HitType>k__BackingField; // 0x1E
	[CompilerGenerated]
	private byte[] <HitTypeList>k__BackingField; // 0x20
	[CompilerGenerated]
	private MobDamageData[] <TargetList>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <StatusValue>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <AttackCount>k__BackingField; // 0x34
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x40
	[CompilerGenerated]
	private short <AttackRotation>k__BackingField; // 0x42

	// Properties
	[UnityHash(Code = 39)]
	public short SkillId { get; set; }
	[UnityHash(Code = 23)]
	public byte LocalId { get; set; }
	[UnityHash(Code = 50)]
	public byte DamageId { get; set; }
	[UnityHash(Code = 47, IsOptional = True)]
	public byte HitType { get; set; }
	[UnityHash(Code = 78, IsOptional = True)]
	public byte[] HitTypeList { get; set; }
	[UnityHash(Code = 20)]
	public MobDamageData[] TargetList { get; set; }
	[UnityHash(Code = 55, IsOptional = True)]
	public int StatusValue { get; set; }
	public byte AttackCount { get; set; }
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public short AttackRotation { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36A3F14 Offset: 0x369FF14 VA: 0x36A3F14
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36A3F1C Offset: 0x369FF1C VA: 0x36A3F1C
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36A3F24 Offset: 0x369FF24 VA: 0x36A3F24
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A3F2C Offset: 0x369FF2C VA: 0x36A3F2C
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36A3F34 Offset: 0x369FF34 VA: 0x36A3F34
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A3F3C Offset: 0x369FF3C VA: 0x36A3F3C
	public byte get_DamageId() { }

	[CompilerGenerated]
	// RVA: 0x36A3F44 Offset: 0x369FF44 VA: 0x36A3F44
	public void set_DamageId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A3F4C Offset: 0x369FF4C VA: 0x36A3F4C
	public byte get_HitType() { }

	[CompilerGenerated]
	// RVA: 0x36A3F54 Offset: 0x369FF54 VA: 0x36A3F54
	public void set_HitType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A3F5C Offset: 0x369FF5C VA: 0x36A3F5C
	public byte[] get_HitTypeList() { }

	[CompilerGenerated]
	// RVA: 0x36A3F64 Offset: 0x369FF64 VA: 0x36A3F64
	public void set_HitTypeList(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A3F6C Offset: 0x369FF6C VA: 0x36A3F6C
	public MobDamageData[] get_TargetList() { }

	[CompilerGenerated]
	// RVA: 0x36A3F74 Offset: 0x369FF74 VA: 0x36A3F74
	public void set_TargetList(MobDamageData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A3F7C Offset: 0x369FF7C VA: 0x36A3F7C
	public int get_StatusValue() { }

	[CompilerGenerated]
	// RVA: 0x36A3F84 Offset: 0x369FF84 VA: 0x36A3F84
	public void set_StatusValue(int value) { }

	[CompilerGenerated]
	// RVA: 0x36A3F8C Offset: 0x369FF8C VA: 0x36A3F8C
	public byte get_AttackCount() { }

	[CompilerGenerated]
	// RVA: 0x36A3F94 Offset: 0x369FF94 VA: 0x36A3F94
	public void set_AttackCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A3F9C Offset: 0x369FF9C VA: 0x36A3F9C
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36A3FA4 Offset: 0x369FFA4 VA: 0x36A3FA4
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A3FAC Offset: 0x369FFAC VA: 0x36A3FAC
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36A3FB4 Offset: 0x369FFB4 VA: 0x36A3FB4
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A3FBC Offset: 0x369FFBC VA: 0x36A3FBC
	public short get_AttackRotation() { }

	[CompilerGenerated]
	// RVA: 0x36A3FC4 Offset: 0x369FFC4 VA: 0x36A3FC4
	public void set_AttackRotation(short value) { }

	// RVA: 0x36A3FCC Offset: 0x369FFCC VA: 0x36A3FCC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36A3FD4 Offset: 0x369FFD4 VA: 0x36A3FD4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36A46D4 Offset: 0x36A06D4 VA: 0x36A46D4 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
