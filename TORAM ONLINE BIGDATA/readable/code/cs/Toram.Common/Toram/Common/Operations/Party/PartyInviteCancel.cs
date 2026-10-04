// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party
public class PartyInviteCancel : PacketBase // TypeDefIndex: 11468
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 94)]
	public int PartyId { get; set; }
	[PacketParameter(Code = 99)]
	public int SenderId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x370F060 Offset: 0x370B060 VA: 0x370F060
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x370F068 Offset: 0x370B068 VA: 0x370F068
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x370F070 Offset: 0x370B070 VA: 0x370F070
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x370F078 Offset: 0x370B078 VA: 0x370F078
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x370F080 Offset: 0x370B080 VA: 0x370F080
	public void set_SenderId(int value) { }

	// RVA: 0x370F088 Offset: 0x370B088 VA: 0x370F088 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370F090 Offset: 0x370B090 VA: 0x370F090 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370F1FC Offset: 0x370B1FC VA: 0x370F1FC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
