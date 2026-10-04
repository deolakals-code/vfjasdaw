// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global
public class GlobalChange : OperationRequestBase // TypeDefIndex: 11568
{
	// Fields
	[CompilerGenerated]
	private int <WorldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <AccountWorldType>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <CustomerPlatform>k__BackingField; // 0x26
	[CompilerGenerated]
	private int <GlobalEventId>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <LocationId>k__BackingField; // 0x2C

	// Properties
	public int WorldId { get; set; }
	public byte AccountWorldType { get; set; }
	public short CustomerPlatform { get; set; }
	public int GlobalEventId { get; set; }
	public short LocationId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371C0D0 Offset: 0x37180D0 VA: 0x371C0D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371C0D8 Offset: 0x37180D8 VA: 0x371C0D8
	public int get_WorldId() { }

	[CompilerGenerated]
	// RVA: 0x371C0E0 Offset: 0x37180E0 VA: 0x371C0E0
	public void set_WorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x371C0E8 Offset: 0x37180E8 VA: 0x371C0E8
	public byte get_AccountWorldType() { }

	[CompilerGenerated]
	// RVA: 0x371C0F0 Offset: 0x37180F0 VA: 0x371C0F0
	public void set_AccountWorldType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371C0F8 Offset: 0x37180F8 VA: 0x371C0F8
	public short get_CustomerPlatform() { }

	[CompilerGenerated]
	// RVA: 0x371C100 Offset: 0x3718100 VA: 0x371C100
	public void set_CustomerPlatform(short value) { }

	[CompilerGenerated]
	// RVA: 0x371C108 Offset: 0x3718108 VA: 0x371C108
	public int get_GlobalEventId() { }

	[CompilerGenerated]
	// RVA: 0x371C110 Offset: 0x3718110 VA: 0x371C110
	public void set_GlobalEventId(int value) { }

	[CompilerGenerated]
	// RVA: 0x371C118 Offset: 0x3718118 VA: 0x371C118
	public short get_LocationId() { }

	[CompilerGenerated]
	// RVA: 0x371C120 Offset: 0x3718120 VA: 0x371C120
	public void set_LocationId(short value) { }

	// RVA: 0x371C128 Offset: 0x3718128 VA: 0x371C128 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371C130 Offset: 0x3718130 VA: 0x371C130 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371C138 Offset: 0x3718138 VA: 0x371C138 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x371C3DC Offset: 0x37183DC VA: 0x371C3DC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
