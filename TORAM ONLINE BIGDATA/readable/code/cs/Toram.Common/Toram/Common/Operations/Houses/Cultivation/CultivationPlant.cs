// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cultivation
public class CultivationPlant : OperationRequestBase // TypeDefIndex: 12201
{
	// Fields
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Index>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <Price>k__BackingField; // 0x26
	[CompilerGenerated]
	private byte <Bonus>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 200)]
	public int Id { get; set; }
	[PacketParameter(Code = 153)]
	public short Index { get; set; }
	[PacketParameter(Code = 195)]
	public short Price { get; set; }
	[PacketParameter(Code = 206)]
	public byte Bonus { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35DFD3C Offset: 0x35DBD3C VA: 0x35DFD3C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35DFD44 Offset: 0x35DBD44 VA: 0x35DFD44
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35DFD4C Offset: 0x35DBD4C VA: 0x35DFD4C
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x35DFD54 Offset: 0x35DBD54 VA: 0x35DFD54
	public short get_Index() { }

	[CompilerGenerated]
	// RVA: 0x35DFD5C Offset: 0x35DBD5C VA: 0x35DFD5C
	public void set_Index(short value) { }

	[CompilerGenerated]
	// RVA: 0x35DFD64 Offset: 0x35DBD64 VA: 0x35DFD64
	public short get_Price() { }

	[CompilerGenerated]
	// RVA: 0x35DFD6C Offset: 0x35DBD6C VA: 0x35DFD6C
	public void set_Price(short value) { }

	[CompilerGenerated]
	// RVA: 0x35DFD74 Offset: 0x35DBD74 VA: 0x35DFD74
	public byte get_Bonus() { }

	[CompilerGenerated]
	// RVA: 0x35DFD7C Offset: 0x35DBD7C VA: 0x35DFD7C
	public void set_Bonus(byte value) { }

	// RVA: 0x35DFD84 Offset: 0x35DBD84 VA: 0x35DFD84 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35DFD8C Offset: 0x35DBD8C VA: 0x35DFD8C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35DFD94 Offset: 0x35DBD94 VA: 0x35DFD94 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DFFB0 Offset: 0x35DBFB0 VA: 0x35DFFB0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
