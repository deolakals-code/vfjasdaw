// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents
public class MobaGetProfile : OperationRequestBase // TypeDefIndex: 11576
{
	// Fields
	[CompilerGenerated]
	private int <AppliId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <AppNumber>k__BackingField; // 0x28

	// Properties
	public int AppliId { get; set; }
	public string AppNumber { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371DB08 Offset: 0x3719B08 VA: 0x371DB08
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371DB10 Offset: 0x3719B10 VA: 0x371DB10
	public int get_AppliId() { }

	[CompilerGenerated]
	// RVA: 0x371DB18 Offset: 0x3719B18 VA: 0x371DB18
	public void set_AppliId(int value) { }

	[CompilerGenerated]
	// RVA: 0x371DB20 Offset: 0x3719B20 VA: 0x371DB20
	public string get_AppNumber() { }

	[CompilerGenerated]
	// RVA: 0x371DB28 Offset: 0x3719B28 VA: 0x371DB28
	public void set_AppNumber(string value) { }

	// RVA: 0x371DB30 Offset: 0x3719B30 VA: 0x371DB30 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371DB38 Offset: 0x3719B38 VA: 0x371DB38 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371DB40 Offset: 0x3719B40 VA: 0x371DB40 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371DBF4 Offset: 0x3719BF4 VA: 0x371DBF4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
