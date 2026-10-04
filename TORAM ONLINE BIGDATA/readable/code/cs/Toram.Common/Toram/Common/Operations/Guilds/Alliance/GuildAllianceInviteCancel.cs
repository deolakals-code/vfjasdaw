// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Alliance
public class GuildAllianceInviteCancel : OperationRequestBase // TypeDefIndex: 12473
{
	// Fields
	[CompilerGenerated]
	private int <AllianceId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 0)]
	public int AllianceId { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x360D2F4 Offset: 0x36092F4 VA: 0x360D2F4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x360D2FC Offset: 0x36092FC VA: 0x360D2FC
	public int get_AllianceId() { }

	[CompilerGenerated]
	// RVA: 0x360D304 Offset: 0x3609304 VA: 0x360D304
	public void set_AllianceId(int value) { }

	// RVA: 0x360D30C Offset: 0x360930C VA: 0x360D30C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360D314 Offset: 0x3609314 VA: 0x360D314 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360D31C Offset: 0x360931C VA: 0x360D31C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360D3BC Offset: 0x36093BC VA: 0x360D3BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
