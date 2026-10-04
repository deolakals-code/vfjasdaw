// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbEquipFlagChange : OperationRequestBase // TypeDefIndex: 11807
{
	// Fields
	[CompilerGenerated]
	private int <ItemUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Enable>k__BackingField; // 0x29

	// Properties
	[PacketParameter(Code = 137)]
	public int ItemUuid { get; set; }
	[PacketParameter(Code = 91)]
	public int ItemId { get; set; }
	[PacketParameter(Code = 43)]
	public byte Flag { get; set; }
	[PacketParameter(Code = 78)]
	public byte Enable { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374F184 Offset: 0x374B184 VA: 0x374F184
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x374F18C Offset: 0x374B18C VA: 0x374F18C
	public int get_ItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x374F194 Offset: 0x374B194 VA: 0x374F194
	public void set_ItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x374F19C Offset: 0x374B19C VA: 0x374F19C
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x374F1A4 Offset: 0x374B1A4 VA: 0x374F1A4
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x374F1AC Offset: 0x374B1AC VA: 0x374F1AC
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x374F1B4 Offset: 0x374B1B4 VA: 0x374F1B4
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x374F1BC Offset: 0x374B1BC VA: 0x374F1BC
	public byte get_Enable() { }

	[CompilerGenerated]
	// RVA: 0x374F1C4 Offset: 0x374B1C4 VA: 0x374F1C4
	public void set_Enable(byte value) { }

	// RVA: 0x374F1CC Offset: 0x374B1CC VA: 0x374F1CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374F1D4 Offset: 0x374B1D4 VA: 0x374F1D4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374F1DC Offset: 0x374B1DC VA: 0x374F1DC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374F3E4 Offset: 0x374B3E4 VA: 0x374F3E4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
