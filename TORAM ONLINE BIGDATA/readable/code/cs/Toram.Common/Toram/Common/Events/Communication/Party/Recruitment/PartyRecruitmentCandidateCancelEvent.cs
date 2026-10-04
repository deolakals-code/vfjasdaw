// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party.Recruitment
public class PartyRecruitmentCandidateCancelEvent : EventSubBase // TypeDefIndex: 12885
{
	// Fields
	[CompilerGenerated]
	private int <RecruitmentId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <CandidateId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <FrameNo>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsTimeout>k__BackingField; // 0x29

	// Properties
	public int RecruitmentId { get; set; }
	public int CandidateId { get; set; }
	public byte FrameNo { get; set; }
	public bool IsTimeout { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x366F748 Offset: 0x366B748 VA: 0x366F748
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366F750 Offset: 0x366B750 VA: 0x366F750
	public int get_RecruitmentId() { }

	[CompilerGenerated]
	// RVA: 0x366F758 Offset: 0x366B758 VA: 0x366F758
	public void set_RecruitmentId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366F760 Offset: 0x366B760 VA: 0x366F760
	public int get_CandidateId() { }

	[CompilerGenerated]
	// RVA: 0x366F768 Offset: 0x366B768 VA: 0x366F768
	public void set_CandidateId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366F770 Offset: 0x366B770 VA: 0x366F770
	public byte get_FrameNo() { }

	[CompilerGenerated]
	// RVA: 0x366F778 Offset: 0x366B778 VA: 0x366F778
	public void set_FrameNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x366F780 Offset: 0x366B780 VA: 0x366F780
	public bool get_IsTimeout() { }

	[CompilerGenerated]
	// RVA: 0x366F788 Offset: 0x366B788 VA: 0x366F788
	public void set_IsTimeout(bool value) { }

	// RVA: 0x366F794 Offset: 0x366B794 VA: 0x366F794 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366F79C Offset: 0x366B79C VA: 0x366F79C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x366F7A4 Offset: 0x366B7A4 VA: 0x366F7A4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x366F8F4 Offset: 0x366B8F4 VA: 0x366F8F4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
