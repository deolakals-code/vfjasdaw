// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbTicketExchangeResponse : OperationResponseBase // TypeDefIndex: 11825
{
	// Fields
	[CompilerGenerated]
	private int <ExchangeNum>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <AvatarTicket>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <TicketPiece>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 92)]
	public int ExchangeNum { get; set; }
	[PacketParameter(Code = 246)]
	public int AvatarTicket { get; set; }
	[PacketParameter(Code = 247)]
	public int TicketPiece { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37521E4 Offset: 0x374E1E4 VA: 0x37521E4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37521EC Offset: 0x374E1EC VA: 0x37521EC
	public int get_ExchangeNum() { }

	[CompilerGenerated]
	// RVA: 0x37521F4 Offset: 0x374E1F4 VA: 0x37521F4
	public void set_ExchangeNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x37521FC Offset: 0x374E1FC VA: 0x37521FC
	public int get_AvatarTicket() { }

	[CompilerGenerated]
	// RVA: 0x3752204 Offset: 0x374E204 VA: 0x3752204
	public void set_AvatarTicket(int value) { }

	[CompilerGenerated]
	// RVA: 0x375220C Offset: 0x374E20C VA: 0x375220C
	public int get_TicketPiece() { }

	[CompilerGenerated]
	// RVA: 0x3752214 Offset: 0x374E214 VA: 0x3752214
	public void set_TicketPiece(int value) { }

	// RVA: 0x375221C Offset: 0x374E21C VA: 0x375221C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3752224 Offset: 0x374E224 VA: 0x3752224 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x375222C Offset: 0x374E22C VA: 0x375222C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37523DC Offset: 0x374E3DC VA: 0x37523DC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
