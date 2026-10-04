// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents.Summer
public class SummerRuleChangeEvent : EventSubBase // TypeDefIndex: 12698
{
	// Fields
	[CompilerGenerated]
	private byte <RecruitType>k__BackingField; // 0x20

	// Properties
	public byte RecruitType { get; set; }
	public bool OnlyAcquaintance { get; }
	public bool OnlyParty { get; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x364406C Offset: 0x364006C VA: 0x364406C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3644074 Offset: 0x3640074 VA: 0x3644074
	public byte get_RecruitType() { }

	[CompilerGenerated]
	// RVA: 0x364407C Offset: 0x364007C VA: 0x364407C
	public void set_RecruitType(byte value) { }

	// RVA: 0x3644084 Offset: 0x3640084 VA: 0x3644084
	public bool get_OnlyAcquaintance() { }

	// RVA: 0x3644094 Offset: 0x3640094 VA: 0x3644094
	public bool get_OnlyParty() { }

	// RVA: 0x36440A4 Offset: 0x36400A4 VA: 0x36440A4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36440AC Offset: 0x36400AC VA: 0x36440AC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36440B4 Offset: 0x36400B4 VA: 0x36440B4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3644280 Offset: 0x3640280 VA: 0x3644280 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
