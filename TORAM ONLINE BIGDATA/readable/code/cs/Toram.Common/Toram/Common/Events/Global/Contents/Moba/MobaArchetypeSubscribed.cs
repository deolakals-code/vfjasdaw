// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents.Moba
public class MobaArchetypeSubscribed : EventSubBase // TypeDefIndex: 12665
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x30
	[CompilerGenerated]
	private Dictionary<byte, object> <Properties>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <PropertiesRevision>k__BackingField; // 0x40

	// Properties
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public Dictionary<byte, object> Properties { get; set; }
	public int PropertiesRevision { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363D14C Offset: 0x363914C VA: 0x363D14C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363D154 Offset: 0x3639154 VA: 0x363D154
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x363D15C Offset: 0x363915C VA: 0x363D15C
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363D164 Offset: 0x3639164 VA: 0x363D164
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x363D16C Offset: 0x363916C VA: 0x363D16C
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x363D174 Offset: 0x3639174 VA: 0x363D174
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x363D17C Offset: 0x363917C VA: 0x363D17C
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x363D184 Offset: 0x3639184 VA: 0x363D184
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x363D18C Offset: 0x363918C VA: 0x363D18C
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x363D194 Offset: 0x3639194 VA: 0x363D194
	public Dictionary<byte, object> get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x363D19C Offset: 0x363919C VA: 0x363D19C
	public void set_Properties(Dictionary<byte, object> value) { }

	[CompilerGenerated]
	// RVA: 0x363D1A4 Offset: 0x36391A4 VA: 0x363D1A4
	public int get_PropertiesRevision() { }

	[CompilerGenerated]
	// RVA: 0x363D1AC Offset: 0x36391AC VA: 0x363D1AC
	public void set_PropertiesRevision(int value) { }

	// RVA: 0x363D1B4 Offset: 0x36391B4 VA: 0x363D1B4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363D1BC Offset: 0x36391BC VA: 0x363D1BC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363D1C4 Offset: 0x36391C4 VA: 0x363D1C4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363D334 Offset: 0x3639334 VA: 0x363D334 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
