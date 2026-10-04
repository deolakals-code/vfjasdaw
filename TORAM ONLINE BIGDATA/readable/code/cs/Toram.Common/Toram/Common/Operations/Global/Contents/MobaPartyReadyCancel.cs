// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents
public class MobaPartyReadyCancel : OperationRequestBase // TypeDefIndex: 11581
{
	// Fields
	[CompilerGenerated]
	private byte <PartyGameId>k__BackingField; // 0x20

	// Properties
	public byte PartyGameId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371E6F4 Offset: 0x371A6F4 VA: 0x371E6F4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371E6FC Offset: 0x371A6FC VA: 0x371E6FC
	public byte get_PartyGameId() { }

	[CompilerGenerated]
	// RVA: 0x371E704 Offset: 0x371A704 VA: 0x371E704
	public void set_PartyGameId(byte value) { }

	// RVA: 0x371E70C Offset: 0x371A70C VA: 0x371E70C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371E714 Offset: 0x371A714 VA: 0x371E714 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371E71C Offset: 0x371A71C VA: 0x371E71C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371E7BC Offset: 0x371A7BC VA: 0x371E7BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
