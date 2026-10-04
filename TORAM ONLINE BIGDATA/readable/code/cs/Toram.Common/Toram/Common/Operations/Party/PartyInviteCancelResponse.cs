// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party
public class PartyInviteCancelResponse : PacketBase // TypeDefIndex: 11469
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

	// RVA: 0x370F2F8 Offset: 0x370B2F8 VA: 0x370F2F8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x370F300 Offset: 0x370B300 VA: 0x370F300
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x370F308 Offset: 0x370B308 VA: 0x370F308
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x370F310 Offset: 0x370B310 VA: 0x370F310
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x370F318 Offset: 0x370B318 VA: 0x370F318
	public void set_SenderId(int value) { }

	// RVA: 0x370F320 Offset: 0x370B320 VA: 0x370F320 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370F328 Offset: 0x370B328 VA: 0x370F328 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370F494 Offset: 0x370B494 VA: 0x370F494 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
