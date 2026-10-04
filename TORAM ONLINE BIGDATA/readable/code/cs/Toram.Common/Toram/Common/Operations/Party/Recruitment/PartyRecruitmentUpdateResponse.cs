// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Recruitment
public class PartyRecruitmentUpdateResponse : OperationResponseBase // TypeDefIndex: 11495
{
	// Fields
	[CompilerGenerated]
	private int <RecruitmentId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte[] <FrameNo>k__BackingField; // 0x28
	[CompilerGenerated]
	private int[] <CandidateIds>k__BackingField; // 0x30

	// Properties
	public int RecruitmentId { get; set; }
	public byte[] FrameNo { get; set; }
	public int[] CandidateIds { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3713484 Offset: 0x370F484 VA: 0x3713484
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371348C Offset: 0x370F48C VA: 0x371348C
	public int get_RecruitmentId() { }

	[CompilerGenerated]
	// RVA: 0x3713494 Offset: 0x370F494 VA: 0x3713494
	public void set_RecruitmentId(int value) { }

	[CompilerGenerated]
	// RVA: 0x371349C Offset: 0x370F49C VA: 0x371349C
	public byte[] get_FrameNo() { }

	[CompilerGenerated]
	// RVA: 0x37134A4 Offset: 0x370F4A4 VA: 0x37134A4
	public void set_FrameNo(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x37134AC Offset: 0x370F4AC VA: 0x37134AC
	public int[] get_CandidateIds() { }

	[CompilerGenerated]
	// RVA: 0x37134B4 Offset: 0x370F4B4 VA: 0x37134B4
	public void set_CandidateIds(int[] value) { }

	// RVA: 0x37134BC Offset: 0x370F4BC VA: 0x37134BC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37134C4 Offset: 0x370F4C4 VA: 0x37134C4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37134CC Offset: 0x370F4CC VA: 0x37134CC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371359C Offset: 0x370F59C VA: 0x371359C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
