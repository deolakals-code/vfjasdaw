// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents
public class MobaStartMatching : OperationRequestBase // TypeDefIndex: 11585
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

	// RVA: 0x371F0C8 Offset: 0x371B0C8 VA: 0x371F0C8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371F0D0 Offset: 0x371B0D0 VA: 0x371F0D0
	public byte get_GameId() { }

	[CompilerGenerated]
	// RVA: 0x371F0D8 Offset: 0x371B0D8 VA: 0x371F0D8
	public void set_GameId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371F0E0 Offset: 0x371B0E0 VA: 0x371F0E0
	public int get_AppliId() { }

	[CompilerGenerated]
	// RVA: 0x371F0E8 Offset: 0x371B0E8 VA: 0x371F0E8
	public void set_AppliId(int value) { }

	[CompilerGenerated]
	// RVA: 0x371F0F0 Offset: 0x371B0F0 VA: 0x371F0F0
	public string get_AppNumber() { }

	[CompilerGenerated]
	// RVA: 0x371F0F8 Offset: 0x371B0F8 VA: 0x371F0F8
	public void set_AppNumber(string value) { }

	// RVA: 0x371F100 Offset: 0x371B100 VA: 0x371F100 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371F108 Offset: 0x371B108 VA: 0x371F108 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371F110 Offset: 0x371B110 VA: 0x371F110 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371F200 Offset: 0x371B200 VA: 0x371F200 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
