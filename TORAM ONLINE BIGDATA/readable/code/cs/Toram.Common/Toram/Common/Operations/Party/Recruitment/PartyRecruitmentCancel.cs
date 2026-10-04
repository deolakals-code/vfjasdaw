// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Recruitment
public class PartyRecruitmentCancel : OperationRequestBase // TypeDefIndex: 11482
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

	// RVA: 0x37114C4 Offset: 0x370D4C4 VA: 0x37114C4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37114CC Offset: 0x370D4CC VA: 0x37114CC
	public byte get_FrameNo() { }

	[CompilerGenerated]
	// RVA: 0x37114D4 Offset: 0x370D4D4 VA: 0x37114D4
	public void set_FrameNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37114DC Offset: 0x370D4DC VA: 0x37114DC
	public int get_TargetAvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37114E4 Offset: 0x370D4E4 VA: 0x37114E4
	public void set_TargetAvatarUuid(int value) { }

	// RVA: 0x37114EC Offset: 0x370D4EC VA: 0x37114EC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37114F4 Offset: 0x370D4F4 VA: 0x37114F4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37114FC Offset: 0x370D4FC VA: 0x37114FC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37115D8 Offset: 0x370D5D8 VA: 0x37115D8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
