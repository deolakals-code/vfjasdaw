// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party.Recruitment
public class PartyRecruitmentUpdateEvent : EventSubBase // TypeDefIndex: 12889
{
	// Fields
	[CompilerGenerated]
	private PartyRecruitmentData <Data>k__BackingField; // 0x20

	// Properties
	public PartyRecruitmentData Data { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36703E8 Offset: 0x366C3E8 VA: 0x36703E8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36703F0 Offset: 0x366C3F0 VA: 0x36703F0
	public PartyRecruitmentData get_Data() { }

	[CompilerGenerated]
	// RVA: 0x36703F8 Offset: 0x366C3F8 VA: 0x36703F8
	public void set_Data(PartyRecruitmentData value) { }

	// RVA: 0x3670400 Offset: 0x366C400 VA: 0x3670400 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3670408 Offset: 0x366C408 VA: 0x3670408 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3670410 Offset: 0x366C410 VA: 0x3670410 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3670498 Offset: 0x366C498 VA: 0x3670498 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
