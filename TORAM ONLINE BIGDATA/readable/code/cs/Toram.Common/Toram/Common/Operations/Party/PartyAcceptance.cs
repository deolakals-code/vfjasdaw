// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party
public class PartyAcceptance : PacketBase // TypeDefIndex: 11463
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

	// RVA: 0x370E560 Offset: 0x370A560 VA: 0x370E560
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x370E568 Offset: 0x370A568 VA: 0x370E568
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x370E570 Offset: 0x370A570 VA: 0x370E570
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x370E578 Offset: 0x370A578 VA: 0x370E578
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x370E580 Offset: 0x370A580 VA: 0x370E580
	public void set_SenderId(int value) { }

	// RVA: 0x370E588 Offset: 0x370A588 VA: 0x370E588 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370E590 Offset: 0x370A590 VA: 0x370E590 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370E6FC Offset: 0x370A6FC VA: 0x370E6FC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
