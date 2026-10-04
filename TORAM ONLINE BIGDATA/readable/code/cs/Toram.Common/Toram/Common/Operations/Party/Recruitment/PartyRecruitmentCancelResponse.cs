// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Recruitment
public class PartyRecruitmentCancelResponse : OperationResponseBase // TypeDefIndex: 11483
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

	// RVA: 0x3711750 Offset: 0x370D750 VA: 0x3711750
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3711758 Offset: 0x370D758 VA: 0x3711758
	public byte get_FrameNo() { }

	[CompilerGenerated]
	// RVA: 0x3711760 Offset: 0x370D760 VA: 0x3711760
	public void set_FrameNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3711768 Offset: 0x370D768 VA: 0x3711768
	public int get_TargetAvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3711770 Offset: 0x370D770 VA: 0x3711770
	public void set_TargetAvatarUuid(int value) { }

	// RVA: 0x3711778 Offset: 0x370D778 VA: 0x3711778 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3711780 Offset: 0x370D780 VA: 0x3711780 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3711788 Offset: 0x370D788 VA: 0x3711788 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3711864 Offset: 0x370D864 VA: 0x3711864 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
