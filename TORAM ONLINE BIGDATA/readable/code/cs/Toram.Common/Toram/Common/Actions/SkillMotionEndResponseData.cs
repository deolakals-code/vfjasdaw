// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SkillMotionEndResponseData : UnityHashBase // TypeDefIndex: 13145
{
	// Fields
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x1D
	[CompilerGenerated]
	private int <SkillIndividualFlag>k__BackingField; // 0x20

	// Properties
	public short SkillId { get; set; }
	public byte LocalId { get; set; }
	public byte Flag { get; set; }
	public int SkillIndividualFlag { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36B29E0 Offset: 0x36AE9E0 VA: 0x36B29E0
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36B29E8 Offset: 0x36AE9E8 VA: 0x36B29E8
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36B29F0 Offset: 0x36AE9F0 VA: 0x36B29F0
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36B29F8 Offset: 0x36AE9F8 VA: 0x36B29F8
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36B2A00 Offset: 0x36AEA00 VA: 0x36B2A00
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B2A08 Offset: 0x36AEA08 VA: 0x36B2A08
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36B2A10 Offset: 0x36AEA10 VA: 0x36B2A10
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B2A18 Offset: 0x36AEA18 VA: 0x36B2A18
	public int get_SkillIndividualFlag() { }

	[CompilerGenerated]
	// RVA: 0x36B2A20 Offset: 0x36AEA20 VA: 0x36B2A20
	public void set_SkillIndividualFlag(int value) { }

	// RVA: 0x36B2A28 Offset: 0x36AEA28 VA: 0x36B2A28 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36B2A30 Offset: 0x36AEA30 VA: 0x36B2A30 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36B2C38 Offset: 0x36AEC38 VA: 0x36B2C38 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
