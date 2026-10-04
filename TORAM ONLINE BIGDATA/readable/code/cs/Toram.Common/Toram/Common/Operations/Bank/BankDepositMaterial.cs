// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankDepositMaterial : OperationRequestBase // TypeDefIndex: 11676
{
	// Fields
	[CompilerGenerated]
	private byte <MaterialId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <MaterialLv>k__BackingField; // 0x21
	[CompilerGenerated]
	private int <MaterialNum>k__BackingField; // 0x24
	[CompilerGenerated]
	private long <BankPoint>k__BackingField; // 0x28

	// Properties
	public byte MaterialId { get; set; }
	public byte MaterialLv { get; set; }
	public int MaterialNum { get; set; }
	public long BankPoint { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3730490 Offset: 0x372C490 VA: 0x3730490
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3730498 Offset: 0x372C498 VA: 0x3730498
	public byte get_MaterialId() { }

	[CompilerGenerated]
	// RVA: 0x37304A0 Offset: 0x372C4A0 VA: 0x37304A0
	public void set_MaterialId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37304A8 Offset: 0x372C4A8 VA: 0x37304A8
	public byte get_MaterialLv() { }

	[CompilerGenerated]
	// RVA: 0x37304B0 Offset: 0x372C4B0 VA: 0x37304B0
	public void set_MaterialLv(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37304B8 Offset: 0x372C4B8 VA: 0x37304B8
	public int get_MaterialNum() { }

	[CompilerGenerated]
	// RVA: 0x37304C0 Offset: 0x372C4C0 VA: 0x37304C0
	public void set_MaterialNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x37304C8 Offset: 0x372C4C8 VA: 0x37304C8
	public long get_BankPoint() { }

	[CompilerGenerated]
	// RVA: 0x37304D0 Offset: 0x372C4D0 VA: 0x37304D0
	public void set_BankPoint(long value) { }

	// RVA: 0x37304D8 Offset: 0x372C4D8 VA: 0x37304D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37304E0 Offset: 0x372C4E0 VA: 0x37304E0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37304E8 Offset: 0x372C4E8 VA: 0x37304E8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3730704 Offset: 0x372C704 VA: 0x3730704 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
