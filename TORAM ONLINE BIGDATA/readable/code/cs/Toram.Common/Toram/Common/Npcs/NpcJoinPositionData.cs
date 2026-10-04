// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Npcs
public class NpcJoinPositionData : BinaryBase // TypeDefIndex: 11152
{
	// Fields
	[CompilerGenerated]
	private int <NpcId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x28

	// Properties
	public int NpcId { get; set; }
	public short[] Position { get; set; }
	public short Rotation { get; set; }

	// Methods

	// RVA: 0x35CA274 Offset: 0x35C6274 VA: 0x35CA274
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35CA27C Offset: 0x35C627C VA: 0x35CA27C
	public int get_NpcId() { }

	[CompilerGenerated]
	// RVA: 0x35CA284 Offset: 0x35C6284 VA: 0x35CA284
	public void set_NpcId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35CA28C Offset: 0x35C628C VA: 0x35CA28C
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x35CA294 Offset: 0x35C6294 VA: 0x35CA294
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x35CA29C Offset: 0x35C629C VA: 0x35CA29C
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x35CA2A4 Offset: 0x35C62A4 VA: 0x35CA2A4
	public void set_Rotation(short value) { }

	// RVA: 0x35CA2AC Offset: 0x35C62AC VA: 0x35CA2AC Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35CA3D8 Offset: 0x35C63D8 VA: 0x35CA3D8 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
