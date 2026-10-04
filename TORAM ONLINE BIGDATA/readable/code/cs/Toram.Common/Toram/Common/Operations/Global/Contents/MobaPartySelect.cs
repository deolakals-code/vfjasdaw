// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents
public class MobaPartySelect : OperationRequestBase // TypeDefIndex: 11582
{
	// Fields
	[CompilerGenerated]
	private byte <GameId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <AppliId>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <AppNumber>k__BackingField; // 0x28

	// Properties
	public byte GameId { get; set; }
	public int AppliId { get; set; }
	public string AppNumber { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371E8DC Offset: 0x371A8DC VA: 0x371E8DC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371E8E4 Offset: 0x371A8E4 VA: 0x371E8E4
	public byte get_GameId() { }

	[CompilerGenerated]
	// RVA: 0x371E8EC Offset: 0x371A8EC VA: 0x371E8EC
	public void set_GameId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371E8F4 Offset: 0x371A8F4 VA: 0x371E8F4
	public int get_AppliId() { }

	[CompilerGenerated]
	// RVA: 0x371E8FC Offset: 0x371A8FC VA: 0x371E8FC
	public void set_AppliId(int value) { }

	[CompilerGenerated]
	// RVA: 0x371E904 Offset: 0x371A904 VA: 0x371E904
	public string get_AppNumber() { }

	[CompilerGenerated]
	// RVA: 0x371E90C Offset: 0x371A90C VA: 0x371E90C
	public void set_AppNumber(string value) { }

	// RVA: 0x371E914 Offset: 0x371A914 VA: 0x371E914 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371E91C Offset: 0x371A91C VA: 0x371E91C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371E924 Offset: 0x371A924 VA: 0x371E924 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371EA14 Offset: 0x371AA14 VA: 0x371EA14 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
