// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.BBS
public class GuildBBSRejectRequest : OperationRequestBase // TypeDefIndex: 12443
{
	// Fields
	public int TargetId; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36091F4 Offset: 0x36051F4 VA: 0x36091F4
	public void .ctor() { }

	// RVA: 0x36091FC Offset: 0x36051FC VA: 0x36091FC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3609204 Offset: 0x3605204 VA: 0x3609204 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360920C Offset: 0x360520C VA: 0x360920C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x360932C Offset: 0x360532C VA: 0x360932C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
