// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankMarketDepositMaterial : OperationRequestBase // TypeDefIndex: 11694
{
	// Fields
	[CompilerGenerated]
	private int <MaterialPoint>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <MaterialId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <MaterialLv>k__BackingField; // 0x25
	[CompilerGenerated]
	private long <BankPoint>k__BackingField; // 0x28

	// Properties
	public int MaterialPoint { get; set; }
	public byte MaterialId { get; set; }
	public byte MaterialLv { get; set; }
	public long BankPoint { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3734458 Offset: 0x3730458 VA: 0x3734458
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3734460 Offset: 0x3730460 VA: 0x3734460
	public int get_MaterialPoint() { }

	[CompilerGenerated]
	// RVA: 0x3734468 Offset: 0x3730468 VA: 0x3734468
	public void set_MaterialPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x3734470 Offset: 0x3730470 VA: 0x3734470
	public byte get_MaterialId() { }

	[CompilerGenerated]
	// RVA: 0x3734478 Offset: 0x3730478 VA: 0x3734478
	public void set_MaterialId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3734480 Offset: 0x3730480 VA: 0x3734480
	public byte get_MaterialLv() { }

	[CompilerGenerated]
	// RVA: 0x3734488 Offset: 0x3730488 VA: 0x3734488
	public void set_MaterialLv(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3734490 Offset: 0x3730490 VA: 0x3734490
	public long get_BankPoint() { }

	[CompilerGenerated]
	// RVA: 0x3734498 Offset: 0x3730498 VA: 0x3734498
	public void set_BankPoint(long value) { }

	// RVA: 0x37344A0 Offset: 0x37304A0 VA: 0x37344A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37344A8 Offset: 0x37304A8 VA: 0x37344A8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37344B0 Offset: 0x37304B0 VA: 0x37344B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37346CC Offset: 0x37306CC VA: 0x37346CC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
