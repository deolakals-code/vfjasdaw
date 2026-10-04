// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Alliance
public class GuildAllianceInvite : OperationRequestBase // TypeDefIndex: 12474
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 0)]
	public int TargetId { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x360D4DC Offset: 0x36094DC VA: 0x360D4DC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x360D4E4 Offset: 0x36094E4 VA: 0x360D4E4
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x360D4EC Offset: 0x36094EC VA: 0x360D4EC
	public void set_TargetId(int value) { }

	// RVA: 0x360D4F4 Offset: 0x36094F4 VA: 0x360D4F4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360D4FC Offset: 0x36094FC VA: 0x360D4FC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360D504 Offset: 0x3609504 VA: 0x360D504 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360D5A4 Offset: 0x36095A4 VA: 0x360D5A4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
