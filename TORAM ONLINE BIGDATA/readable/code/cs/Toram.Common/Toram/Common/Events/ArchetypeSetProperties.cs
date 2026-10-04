// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class ArchetypeSetProperties : PacketBase // TypeDefIndex: 12617
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <PropertiesRevision>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<byte, object> <NewProperties>k__BackingField; // 0x30

	// Properties
	public int ArchetypeId { get; set; }
	public byte ArchetypeType { get; set; }
	public int PropertiesRevision { get; set; }
	public Dictionary<byte, object> NewProperties { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3631E2C Offset: 0x362DE2C VA: 0x3631E2C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3631E34 Offset: 0x362DE34 VA: 0x3631E34
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3631E3C Offset: 0x362DE3C VA: 0x3631E3C
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3631E44 Offset: 0x362DE44 VA: 0x3631E44
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3631E4C Offset: 0x362DE4C VA: 0x3631E4C
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3631E54 Offset: 0x362DE54 VA: 0x3631E54
	public int get_PropertiesRevision() { }

	[CompilerGenerated]
	// RVA: 0x3631E5C Offset: 0x362DE5C VA: 0x3631E5C
	public void set_PropertiesRevision(int value) { }

	[CompilerGenerated]
	// RVA: 0x3631E64 Offset: 0x362DE64 VA: 0x3631E64
	public Dictionary<byte, object> get_NewProperties() { }

	[CompilerGenerated]
	// RVA: 0x3631E6C Offset: 0x362DE6C VA: 0x3631E6C
	public void set_NewProperties(Dictionary<byte, object> value) { }

	// RVA: 0x3631E74 Offset: 0x362DE74 VA: 0x3631E74 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3631E7C Offset: 0x362DE7C VA: 0x3631E7C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36320E0 Offset: 0x362E0E0 VA: 0x36320E0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
