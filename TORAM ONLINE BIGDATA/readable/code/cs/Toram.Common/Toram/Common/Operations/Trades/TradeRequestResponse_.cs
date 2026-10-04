// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Trades
public class TradeRequestResponse_ : OperationResponseBase // TypeDefIndex: 11700
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <TargetName>k__BackingField; // 0x28

	// Properties
	public int TargetId { get; set; }
	public string TargetName { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3735424 Offset: 0x3731424 VA: 0x3735424
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x373542C Offset: 0x373142C VA: 0x373542C
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3735434 Offset: 0x3731434 VA: 0x3735434
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x373543C Offset: 0x373143C VA: 0x373543C
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0x3735444 Offset: 0x3731444 VA: 0x3735444
	public void set_TargetName(string value) { }

	// RVA: 0x373544C Offset: 0x373144C VA: 0x373544C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3735454 Offset: 0x3731454 VA: 0x3735454 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373545C Offset: 0x373145C VA: 0x373545C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3735510 Offset: 0x3731510 VA: 0x3735510 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
