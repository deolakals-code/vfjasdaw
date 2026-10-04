// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SupportData : UnityHashBase // TypeDefIndex: 13201
{
	// Fields
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private TargetPlayerData[] <TargetList>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <TimeStamp>k__BackingField; // 0x28
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x38

	// Properties
	[UnityHash(Code = 39)]
	public short SkillId { get; set; }
	[UnityHash(Code = 23)]
	public byte LocalId { get; set; }
	[UnityHash(Code = 6, IsOptional = True)]
	public TargetPlayerData[] TargetList { get; set; }
	[UnityHash(Code = 42)]
	public int TimeStamp { get; set; }
	[UnityHash(Code = 10)]
	public short[] Position { get; set; }
	[UnityHash(Code = 11)]
	public short Rotation { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36C7954 Offset: 0x36C3954 VA: 0x36C7954
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36C795C Offset: 0x36C395C VA: 0x36C795C
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36C7964 Offset: 0x36C3964 VA: 0x36C7964
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C796C Offset: 0x36C396C VA: 0x36C796C
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36C7974 Offset: 0x36C3974 VA: 0x36C7974
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C797C Offset: 0x36C397C VA: 0x36C797C
	public TargetPlayerData[] get_TargetList() { }

	[CompilerGenerated]
	// RVA: 0x36C7984 Offset: 0x36C3984 VA: 0x36C7984
	public void set_TargetList(TargetPlayerData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C798C Offset: 0x36C398C VA: 0x36C798C
	public int get_TimeStamp() { }

	[CompilerGenerated]
	// RVA: 0x36C7994 Offset: 0x36C3994 VA: 0x36C7994
	public void set_TimeStamp(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C799C Offset: 0x36C399C VA: 0x36C799C
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36C79A4 Offset: 0x36C39A4 VA: 0x36C79A4
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C79AC Offset: 0x36C39AC VA: 0x36C79AC
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36C79B4 Offset: 0x36C39B4 VA: 0x36C79B4
	public void set_Rotation(short value) { }

	// RVA: 0x36C79BC Offset: 0x36C39BC VA: 0x36C79BC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C79C4 Offset: 0x36C39C4 VA: 0x36C79C4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36C7E18 Offset: 0x36C3E18 VA: 0x36C7E18 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
