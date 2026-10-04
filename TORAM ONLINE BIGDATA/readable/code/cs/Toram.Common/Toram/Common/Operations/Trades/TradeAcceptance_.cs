// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Trades
public class TradeAcceptance_ : OperationRequestBase // TypeDefIndex: 11696
{
	// Fields
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x20

	// Properties
	public int SenderId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3734CB4 Offset: 0x3730CB4 VA: 0x3734CB4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3734CBC Offset: 0x3730CBC VA: 0x3734CBC
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x3734CC4 Offset: 0x3730CC4 VA: 0x3734CC4
	public void set_SenderId(int value) { }

	// RVA: 0x3734CCC Offset: 0x3730CCC VA: 0x3734CCC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3734CD4 Offset: 0x3730CD4 VA: 0x3734CD4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3734CDC Offset: 0x3730CDC VA: 0x3734CDC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3734D7C Offset: 0x3730D7C VA: 0x3734D7C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
