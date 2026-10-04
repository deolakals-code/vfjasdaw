// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankWithdrawMaterial : OperationRequestBase // TypeDefIndex: 11691
{
	// Fields
	[CompilerGenerated]
	private byte <MaterialId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <MaterialLv>k__BackingField; // 0x21
	[CompilerGenerated]
	private int <MaterialNum>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <ClientFee>k__BackingField; // 0x28
	[CompilerGenerated]
	private long <BankPoint>k__BackingField; // 0x30

	// Properties
	public byte MaterialId { get; set; }
	public byte MaterialLv { get; set; }
	public int MaterialNum { get; set; }
	public int ClientFee { get; set; }
	public long BankPoint { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37337B8 Offset: 0x372F7B8 VA: 0x37337B8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37337C0 Offset: 0x372F7C0 VA: 0x37337C0
	public byte get_MaterialId() { }

	[CompilerGenerated]
	// RVA: 0x37337C8 Offset: 0x372F7C8 VA: 0x37337C8
	public void set_MaterialId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37337D0 Offset: 0x372F7D0 VA: 0x37337D0
	public byte get_MaterialLv() { }

	[CompilerGenerated]
	// RVA: 0x37337D8 Offset: 0x372F7D8 VA: 0x37337D8
	public void set_MaterialLv(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37337E0 Offset: 0x372F7E0 VA: 0x37337E0
	public int get_MaterialNum() { }

	[CompilerGenerated]
	// RVA: 0x37337E8 Offset: 0x372F7E8 VA: 0x37337E8
	public void set_MaterialNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x37337F0 Offset: 0x372F7F0 VA: 0x37337F0
	public int get_ClientFee() { }

	[CompilerGenerated]
	// RVA: 0x37337F8 Offset: 0x372F7F8 VA: 0x37337F8
	public void set_ClientFee(int value) { }

	[CompilerGenerated]
	// RVA: 0x3733800 Offset: 0x372F800 VA: 0x3733800
	public long get_BankPoint() { }

	[CompilerGenerated]
	// RVA: 0x3733808 Offset: 0x372F808 VA: 0x3733808
	public void set_BankPoint(long value) { }

	// RVA: 0x3733810 Offset: 0x372F810 VA: 0x3733810 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3733818 Offset: 0x372F818 VA: 0x3733818 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3733820 Offset: 0x372F820 VA: 0x3733820 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3733A80 Offset: 0x372FA80 VA: 0x3733A80 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
