// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobSendDataLight : BinaryBase, IMobIdData // TypeDefIndex: 13140
{
	// Fields
	[CompilerGenerated]
	private int <MobId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UniqueId>k__BackingField; // 0x24
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x30

	// Properties
	public int MobId { get; set; }
	public byte LocalId { get; set; }
	public int UniqueId { get; set; }
	public short[] Position { get; set; }
	public short Rotation { get; set; }

	// Methods

	// RVA: 0x36B182C Offset: 0x36AD82C VA: 0x36B182C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36B1834 Offset: 0x36AD834 VA: 0x36B1834 Slot: 8
	public int get_MobId() { }

	[CompilerGenerated]
	// RVA: 0x36B183C Offset: 0x36AD83C VA: 0x36B183C
	public void set_MobId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36B1844 Offset: 0x36AD844 VA: 0x36B1844 Slot: 9
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36B184C Offset: 0x36AD84C VA: 0x36B184C
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B1854 Offset: 0x36AD854 VA: 0x36B1854 Slot: 10
	public int get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x36B185C Offset: 0x36AD85C VA: 0x36B185C
	public void set_UniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36B1864 Offset: 0x36AD864 VA: 0x36B1864
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36B186C Offset: 0x36AD86C VA: 0x36B186C
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36B1874 Offset: 0x36AD874 VA: 0x36B1874
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36B187C Offset: 0x36AD87C VA: 0x36B187C
	public void set_Rotation(short value) { }

	// RVA: 0x36B1884 Offset: 0x36AD884 VA: 0x36B1884 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36B1988 Offset: 0x36AD988 VA: 0x36B1988 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
