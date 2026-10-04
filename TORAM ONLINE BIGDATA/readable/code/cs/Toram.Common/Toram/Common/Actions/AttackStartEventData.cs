// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class AttackStartEventData : UnityHashBase // TypeDefIndex: 13115
{
	// Fields
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <SkillLevel>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x1D
	[CompilerGenerated]
	private MobResponseData <Target>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <TargetPosition>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <HitType>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte[] <HitTypeList>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <MotionSpeed>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <LoopCount>k__BackingField; // 0x41
	[CompilerGenerated]
	private short <CastTime>k__BackingField; // 0x42
	[CompilerGenerated]
	private byte <Element>k__BackingField; // 0x44
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x48
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <SkillParamFlag>k__BackingField; // 0x54
	[CompilerGenerated]
	private int <Flag>k__BackingField; // 0x58

	// Properties
	[UnityHash(Code = 39)]
	public short SkillId { get; set; }
	public byte SkillLevel { get; set; }
	[UnityHash(Code = 23)]
	public byte LocalId { get; set; }
	[UnityHash(Code = 20)]
	public MobResponseData Target { get; set; }
	[UnityHash(Code = 6)]
	public short[] TargetPosition { get; set; }
	[UnityHash(Code = 47, IsOptional = True)]
	public byte HitType { get; set; }
	[UnityHash(Code = 78, IsOptional = True)]
	public byte[] HitTypeList { get; set; }
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
	[UnityHash(Code = 85, IsOptional = True)]
	public int SkillParamFlag { get; set; }
	[UnityHash(Code = 59, IsOptional = True)]
	public int Flag { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36A756C Offset: 0x36A356C VA: 0x36A756C
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36A7574 Offset: 0x36A3574 VA: 0x36A7574
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36A757C Offset: 0x36A357C VA: 0x36A757C
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A7584 Offset: 0x36A3584 VA: 0x36A7584
	public byte get_SkillLevel() { }

	[CompilerGenerated]
	// RVA: 0x36A758C Offset: 0x36A358C VA: 0x36A758C
	public void set_SkillLevel(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A7594 Offset: 0x36A3594 VA: 0x36A7594
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36A759C Offset: 0x36A359C VA: 0x36A759C
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A75A4 Offset: 0x36A35A4 VA: 0x36A75A4
	public MobResponseData get_Target() { }

	[CompilerGenerated]
	// RVA: 0x36A75AC Offset: 0x36A35AC VA: 0x36A75AC
	public void set_Target(MobResponseData value) { }

	[CompilerGenerated]
	// RVA: 0x36A75B4 Offset: 0x36A35B4 VA: 0x36A75B4
	public short[] get_TargetPosition() { }

	[CompilerGenerated]
	// RVA: 0x36A75BC Offset: 0x36A35BC VA: 0x36A75BC
	public void set_TargetPosition(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A75C4 Offset: 0x36A35C4 VA: 0x36A75C4
	public byte get_HitType() { }

	[CompilerGenerated]
	// RVA: 0x36A75CC Offset: 0x36A35CC VA: 0x36A75CC
	public void set_HitType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A75D4 Offset: 0x36A35D4 VA: 0x36A75D4
	public byte[] get_HitTypeList() { }

	[CompilerGenerated]
	// RVA: 0x36A75DC Offset: 0x36A35DC VA: 0x36A75DC
	public void set_HitTypeList(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A75E4 Offset: 0x36A35E4 VA: 0x36A75E4
	public byte get_MotionSpeed() { }

	[CompilerGenerated]
	// RVA: 0x36A75EC Offset: 0x36A35EC VA: 0x36A75EC
	public void set_MotionSpeed(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A75F4 Offset: 0x36A35F4 VA: 0x36A75F4
	public byte get_LoopCount() { }

	[CompilerGenerated]
	// RVA: 0x36A75FC Offset: 0x36A35FC VA: 0x36A75FC
	public void set_LoopCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A7604 Offset: 0x36A3604 VA: 0x36A7604
	public short get_CastTime() { }

	[CompilerGenerated]
	// RVA: 0x36A760C Offset: 0x36A360C VA: 0x36A760C
	public void set_CastTime(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A7614 Offset: 0x36A3614 VA: 0x36A7614
	public byte get_Element() { }

	[CompilerGenerated]
	// RVA: 0x36A761C Offset: 0x36A361C VA: 0x36A761C
	public void set_Element(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A7624 Offset: 0x36A3624 VA: 0x36A7624
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36A762C Offset: 0x36A362C VA: 0x36A762C
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A7634 Offset: 0x36A3634 VA: 0x36A7634
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36A763C Offset: 0x36A363C VA: 0x36A763C
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A7644 Offset: 0x36A3644 VA: 0x36A7644
	public int get_SkillParamFlag() { }

	[CompilerGenerated]
	// RVA: 0x36A764C Offset: 0x36A364C VA: 0x36A764C
	public void set_SkillParamFlag(int value) { }

	[CompilerGenerated]
	// RVA: 0x36A7654 Offset: 0x36A3654 VA: 0x36A7654
	public int get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36A765C Offset: 0x36A365C VA: 0x36A765C
	public void set_Flag(int value) { }

	// RVA: 0x36A7664 Offset: 0x36A3664 VA: 0x36A7664 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36A766C Offset: 0x36A366C VA: 0x36A766C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36A7F7C Offset: 0x36A3F7C VA: 0x36A7F7C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
