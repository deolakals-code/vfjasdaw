// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents
public class MobaPartyCancel : OperationRequestBase // TypeDefIndex: 11579
{
	// Fields
	[CompilerGenerated]
	private byte <PartyGameId>k__BackingField; // 0x20

	// Properties
	public byte PartyGameId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371E1B8 Offset: 0x371A1B8 VA: 0x371E1B8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371E1C0 Offset: 0x371A1C0 VA: 0x371E1C0
	public byte get_PartyGameId() { }

	[CompilerGenerated]
	// RVA: 0x371E1C8 Offset: 0x371A1C8 VA: 0x371E1C8
	public void set_PartyGameId(byte value) { }

	// RVA: 0x371E1D0 Offset: 0x371A1D0 VA: 0x371E1D0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371E1D8 Offset: 0x371A1D8 VA: 0x371E1D8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371E1E0 Offset: 0x371A1E0 VA: 0x371E1E0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371E280 Offset: 0x371A280 VA: 0x371E280 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
