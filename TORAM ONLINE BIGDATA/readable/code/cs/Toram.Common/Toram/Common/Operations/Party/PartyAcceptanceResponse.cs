// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party
public class PartyAcceptanceResponse : PacketBase // TypeDefIndex: 11464
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

	// RVA: 0x370E7F8 Offset: 0x370A7F8 VA: 0x370E7F8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x370E800 Offset: 0x370A800 VA: 0x370E800
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x370E808 Offset: 0x370A808 VA: 0x370E808
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x370E810 Offset: 0x370A810 VA: 0x370E810
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x370E818 Offset: 0x370A818 VA: 0x370E818
	public void set_SenderId(int value) { }

	// RVA: 0x370E820 Offset: 0x370A820 VA: 0x370E820 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370E828 Offset: 0x370A828 VA: 0x370E828 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370E994 Offset: 0x370A994 VA: 0x370E994 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
