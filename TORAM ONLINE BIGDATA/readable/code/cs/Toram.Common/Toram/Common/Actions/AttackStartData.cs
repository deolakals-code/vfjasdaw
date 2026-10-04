// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class AttackStartData : UnityHashBase // TypeDefIndex: 13114
{
	// Fields
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <SkillLv>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x1D
	[CompilerGenerated]
	private MobSendData <Target>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <TargetPosition>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <HitType>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte[] <HitTypeList>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <SkillParamFlag>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <MotionSpeed>k__BackingField; // 0x44
	[CompilerGenerated]
	private byte <LoopCount>k__BackingField; // 0x45
	[CompilerGenerated]
	private short <CastTime>k__BackingField; // 0x46
	[CompilerGenerated]
	private byte <Element>k__BackingField; // 0x48
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x50
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x58
	[CompilerGenerated]
	private int <SkillIndividualFlag>k__BackingField; // 0x5C
	[CompilerGenerated]
	private ActionAppendData <AttackStartAppendData>k__BackingField; // 0x60

	// Properties
	[UnityHash(Code = 39)]
	public short SkillId { get; set; }
	public byte SkillLv { get; set; }
	[UnityHash(Code = 23)]
	public byte LocalId { get; set; }
	[UnityHash(Code = 20)]
	public MobSendData Target { get; set; }
	[UnityHash(Code = 6)]
	public short[] TargetPosition { get; set; }
	[UnityHash(Code = 47, IsOptional = True)]
	public byte HitType { get; set; }
	[UnityHash(Code = 78, IsOptional = True)]
	public byte[] HitTypeList { get; set; }
	[UnityHash(Code = 59, IsOptional = True)]
	public int SkillParamFlag { get; set; }
	[UnityHash(Code = 43, Default = 100, IsOptional = True)]
	public byte MotionSpeed { get; set; }
	[UnityHash(Code = 44, Default = 1, IsOptional = True)]
	public byte LoopCount { get; set; }
	[UnityHash(Code = 45, IsOptional = True)]
	public short CastTime { get; set; }
	[UnityHash(Code = 46, IsOptional = True)]
	public byte Element { get; set; }
	[UnityHash(Code = 10)]
	public short[] Position { get; set; }
	[UnityHash(Code = 11)]
	public short Rotation { get; set; }
	[UnityHash(Code = 55, IsOptional = True)]
	public int SkillIndividualFlag { get; set; }
	[UnityHash(Code = 104, IsOptional = True)]
	public ActionAppendData AttackStartAppendData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36A6584 Offset: 0x36A2584 VA: 0x36A6584
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36A658C Offset: 0x36A258C VA: 0x36A658C
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36A6594 Offset: 0x36A2594 VA: 0x36A6594
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A659C Offset: 0x36A259C VA: 0x36A659C
	public byte get_SkillLv() { }

	[CompilerGenerated]
	// RVA: 0x36A65A4 Offset: 0x36A25A4 VA: 0x36A65A4
	public void set_SkillLv(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A65AC Offset: 0x36A25AC VA: 0x36A65AC
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36A65B4 Offset: 0x36A25B4 VA: 0x36A65B4
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A65BC Offset: 0x36A25BC VA: 0x36A65BC
	public MobSendData get_Target() { }

	[CompilerGenerated]
	// RVA: 0x36A65C4 Offset: 0x36A25C4 VA: 0x36A65C4
	public void set_Target(MobSendData value) { }

	[CompilerGenerated]
	// RVA: 0x36A65CC Offset: 0x36A25CC VA: 0x36A65CC
	public short[] get_TargetPosition() { }

	[CompilerGenerated]
	// RVA: 0x36A65D4 Offset: 0x36A25D4 VA: 0x36A65D4
	public void set_TargetPosition(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A65DC Offset: 0x36A25DC VA: 0x36A65DC
	public byte get_HitType() { }

	[CompilerGenerated]
	// RVA: 0x36A65E4 Offset: 0x36A25E4 VA: 0x36A65E4
	public void set_HitType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A65EC Offset: 0x36A25EC VA: 0x36A65EC
	public byte[] get_HitTypeList() { }

	[CompilerGenerated]
	// RVA: 0x36A65F4 Offset: 0x36A25F4 VA: 0x36A65F4
	public void set_HitTypeList(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A65FC Offset: 0x36A25FC VA: 0x36A65FC
	public int get_SkillParamFlag() { }

	[CompilerGenerated]
	// RVA: 0x36A6604 Offset: 0x36A2604 VA: 0x36A6604
	public void set_SkillParamFlag(int value) { }

	[CompilerGenerated]
	// RVA: 0x36A660C Offset: 0x36A260C VA: 0x36A660C
	public byte get_MotionSpeed() { }

	[CompilerGenerated]
	// RVA: 0x36A6614 Offset: 0x36A2614 VA: 0x36A6614
	public void set_MotionSpeed(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A661C Offset: 0x36A261C VA: 0x36A661C
	public byte get_LoopCount() { }

	[CompilerGenerated]
	// RVA: 0x36A6624 Offset: 0x36A2624 VA: 0x36A6624
	public void set_LoopCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A662C Offset: 0x36A262C VA: 0x36A662C
	public short get_CastTime() { }

	[CompilerGenerated]
	// RVA: 0x36A6634 Offset: 0x36A2634 VA: 0x36A6634
	public void set_CastTime(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A663C Offset: 0x36A263C VA: 0x36A663C
	public byte get_Element() { }

	[CompilerGenerated]
	// RVA: 0x36A6644 Offset: 0x36A2644 VA: 0x36A6644
	public void set_Element(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A664C Offset: 0x36A264C VA: 0x36A664C
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36A6654 Offset: 0x36A2654 VA: 0x36A6654
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A665C Offset: 0x36A265C VA: 0x36A665C
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36A6664 Offset: 0x36A2664 VA: 0x36A6664
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A666C Offset: 0x36A266C VA: 0x36A666C
	public int get_SkillIndividualFlag() { }

	[CompilerGenerated]
	// RVA: 0x36A6674 Offset: 0x36A2674 VA: 0x36A6674
	public void set_SkillIndividualFlag(int value) { }

	[CompilerGenerated]
	// RVA: 0x36A667C Offset: 0x36A267C VA: 0x36A667C
	public ActionAppendData get_AttackStartAppendData() { }

	[CompilerGenerated]
	// RVA: 0x36A6684 Offset: 0x36A2684 VA: 0x36A6684
	public void set_AttackStartAppendData(ActionAppendData value) { }

	// RVA: 0x36A668C Offset: 0x36A268C VA: 0x36A668C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36A6694 Offset: 0x36A2694 VA: 0x36A6694 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36A7078 Offset: 0x36A3078 VA: 0x36A7078 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
