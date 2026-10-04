// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankDepositMaterialResponse : OperationResponseBase // TypeDefIndex: 11677
{
	// Fields
	[CompilerGenerated]
	private BankData <Bank>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <DepositType>k__BackingField; // 0x28
	[CompilerGenerated]
	private long <DepositValue>k__BackingField; // 0x30
	[CompilerGenerated]
	private MaterialData <Material>k__BackingField; // 0x38

	// Properties
	public BankData Bank { get; set; }
	public byte DepositType { get; set; }
	public long DepositValue { get; set; }
	public MaterialData Material { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3730854 Offset: 0x372C854 VA: 0x3730854
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x373085C Offset: 0x372C85C VA: 0x373085C
	public BankData get_Bank() { }

	[CompilerGenerated]
	// RVA: 0x3730864 Offset: 0x372C864 VA: 0x3730864
	public void set_Bank(BankData value) { }

	[CompilerGenerated]
	// RVA: 0x373086C Offset: 0x372C86C VA: 0x373086C
	public byte get_DepositType() { }

	[CompilerGenerated]
	// RVA: 0x3730874 Offset: 0x372C874 VA: 0x3730874
	public void set_DepositType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x373087C Offset: 0x372C87C VA: 0x373087C
	public long get_DepositValue() { }

	[CompilerGenerated]
	// RVA: 0x3730884 Offset: 0x372C884 VA: 0x3730884
	public void set_DepositValue(long value) { }

	[CompilerGenerated]
	// RVA: 0x373088C Offset: 0x372C88C VA: 0x373088C
	public MaterialData get_Material() { }

	[CompilerGenerated]
	// RVA: 0x3730894 Offset: 0x372C894 VA: 0x3730894
	public void set_Material(MaterialData value) { }

	// RVA: 0x373089C Offset: 0x372C89C VA: 0x373089C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37308A4 Offset: 0x372C8A4 VA: 0x37308A4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37308AC Offset: 0x372C8AC VA: 0x37308AC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3730BB8 Offset: 0x372CBB8 VA: 0x3730BB8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
