// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetBuy : OperationRequestBase // TypeDefIndex: 12289
{
	// Fields
	[CompilerGenerated]
	private byte <No>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Password>k__BackingField; // 0x24

	// Properties
	public byte No { get; set; }
	public int Password { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35ECB9C Offset: 0x35E8B9C VA: 0x35ECB9C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35ECBA4 Offset: 0x35E8BA4 VA: 0x35ECBA4
	public byte get_No() { }

	[CompilerGenerated]
	// RVA: 0x35ECBAC Offset: 0x35E8BAC VA: 0x35ECBAC
	public void set_No(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35ECBB4 Offset: 0x35E8BB4 VA: 0x35ECBB4
	public int get_Password() { }

	[CompilerGenerated]
	// RVA: 0x35ECBBC Offset: 0x35E8BBC VA: 0x35ECBBC
	public void set_Password(int value) { }

	// RVA: 0x35ECBC4 Offset: 0x35E8BC4 VA: 0x35ECBC4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35ECBCC Offset: 0x35E8BCC VA: 0x35ECBCC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35ECBD4 Offset: 0x35E8BD4 VA: 0x35ECBD4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35ECCB4 Offset: 0x35E8CB4 VA: 0x35ECCB4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
