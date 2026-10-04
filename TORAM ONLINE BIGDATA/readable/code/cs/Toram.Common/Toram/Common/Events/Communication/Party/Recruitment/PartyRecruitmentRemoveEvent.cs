// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party.Recruitment
public class PartyRecruitmentRemoveEvent : EventSubBase // TypeDefIndex: 12888
{
	// Fields
	[CompilerGenerated]
	private int <RecruitmentId>k__BackingField; // 0x20

	// Properties
	public int RecruitmentId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3670200 Offset: 0x366C200 VA: 0x3670200
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3670208 Offset: 0x366C208 VA: 0x3670208
	public int get_RecruitmentId() { }

	[CompilerGenerated]
	// RVA: 0x3670210 Offset: 0x366C210 VA: 0x3670210
	public void set_RecruitmentId(int value) { }

	// RVA: 0x3670218 Offset: 0x366C218 VA: 0x3670218 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3670220 Offset: 0x366C220 VA: 0x3670220 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3670228 Offset: 0x366C228 VA: 0x3670228 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36702C8 Offset: 0x366C2C8 VA: 0x36702C8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
