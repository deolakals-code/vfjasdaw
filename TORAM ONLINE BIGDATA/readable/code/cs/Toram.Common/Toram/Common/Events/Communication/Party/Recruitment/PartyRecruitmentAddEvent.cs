// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party.Recruitment
public class PartyRecruitmentAddEvent : EventSubBase // TypeDefIndex: 12883
{
	// Fields
	[CompilerGenerated]
	private PartyRecruitmentData <Data>k__BackingField; // 0x20

	// Properties
	public PartyRecruitmentData Data { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x366F298 Offset: 0x366B298 VA: 0x366F298
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366F2A0 Offset: 0x366B2A0 VA: 0x366F2A0
	public PartyRecruitmentData get_Data() { }

	[CompilerGenerated]
	// RVA: 0x366F2A8 Offset: 0x366B2A8 VA: 0x366F2A8
	public void set_Data(PartyRecruitmentData value) { }

	// RVA: 0x366F2B0 Offset: 0x366B2B0 VA: 0x366F2B0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366F2B8 Offset: 0x366B2B8 VA: 0x366F2B8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x366F2C0 Offset: 0x366B2C0 VA: 0x366F2C0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x366F348 Offset: 0x366B348 VA: 0x366F348 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
