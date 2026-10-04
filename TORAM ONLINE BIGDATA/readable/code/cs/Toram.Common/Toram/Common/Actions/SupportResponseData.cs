// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SupportResponseData : UnityHashBase // TypeDefIndex: 13206
{
	// Fields
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <SkillLv>k__BackingField; // 0x1C
	[CompilerGenerated]
	private SupportResultData <SupportResultData>k__BackingField; // 0x20

	// Properties
	[UnityHash(Code = 39)]
	public short SkillId { get; set; }
	[UnityHash(Code = 40, IsOptional = True)]
	public byte SkillLv { get; set; }
	[UnityHash(Code = 41, IsOptional = True)]
	public SupportResultData SupportResultData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36C9558 Offset: 0x36C5558 VA: 0x36C9558
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36C9560 Offset: 0x36C5560 VA: 0x36C9560
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36C9568 Offset: 0x36C5568 VA: 0x36C9568
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C9570 Offset: 0x36C5570 VA: 0x36C9570
	public byte get_SkillLv() { }

	[CompilerGenerated]
	// RVA: 0x36C9578 Offset: 0x36C5578 VA: 0x36C9578
	public void set_SkillLv(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C9580 Offset: 0x36C5580 VA: 0x36C9580
	public SupportResultData get_SupportResultData() { }

	[CompilerGenerated]
	// RVA: 0x36C9588 Offset: 0x36C5588 VA: 0x36C9588
	public void set_SupportResultData(SupportResultData value) { }

	// RVA: 0x36C9590 Offset: 0x36C5590 VA: 0x36C9590 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C9598 Offset: 0x36C5598 VA: 0x36C9598 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36C9880 Offset: 0x36C5880 VA: 0x36C9880 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
