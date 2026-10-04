// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Recruitment
public class PartyRecruitmentApprove : OperationRequestBase // TypeDefIndex: 11481
{
	// Fields
	[CompilerGenerated]
	private byte <FrameNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <TargetAvatarUuid>k__BackingField; // 0x24

	// Properties
	public byte FrameNo { get; set; }
	public int TargetAvatarUuid { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3711238 Offset: 0x370D238 VA: 0x3711238
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3711240 Offset: 0x370D240 VA: 0x3711240
	public byte get_FrameNo() { }

	[CompilerGenerated]
	// RVA: 0x3711248 Offset: 0x370D248 VA: 0x3711248
	public void set_FrameNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3711250 Offset: 0x370D250 VA: 0x3711250
	public int get_TargetAvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3711258 Offset: 0x370D258 VA: 0x3711258
	public void set_TargetAvatarUuid(int value) { }

	// RVA: 0x3711260 Offset: 0x370D260 VA: 0x3711260 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3711268 Offset: 0x370D268 VA: 0x3711268 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3711270 Offset: 0x370D270 VA: 0x3711270 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371134C Offset: 0x370D34C VA: 0x371134C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
