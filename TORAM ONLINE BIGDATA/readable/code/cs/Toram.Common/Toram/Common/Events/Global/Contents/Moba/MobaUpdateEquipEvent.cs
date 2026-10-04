// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents.Moba
public class MobaUpdateEquipEvent : EventSubBase // TypeDefIndex: 12674
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private Dictionary<byte, object> <EquipProperties>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <PropertiesRevision>k__BackingField; // 0x30

	// Properties
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public Dictionary<byte, object> EquipProperties { get; set; }
	public int PropertiesRevision { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363E788 Offset: 0x363A788 VA: 0x363E788
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363E790 Offset: 0x363A790 VA: 0x363E790
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x363E798 Offset: 0x363A798 VA: 0x363E798
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363E7A0 Offset: 0x363A7A0 VA: 0x363E7A0
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x363E7A8 Offset: 0x363A7A8 VA: 0x363E7A8
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x363E7B0 Offset: 0x363A7B0 VA: 0x363E7B0
	public Dictionary<byte, object> get_EquipProperties() { }

	[CompilerGenerated]
	// RVA: 0x363E7B8 Offset: 0x363A7B8 VA: 0x363E7B8
	public void set_EquipProperties(Dictionary<byte, object> value) { }

	[CompilerGenerated]
	// RVA: 0x363E7C0 Offset: 0x363A7C0 VA: 0x363E7C0
	public int get_PropertiesRevision() { }

	[CompilerGenerated]
	// RVA: 0x363E7C8 Offset: 0x363A7C8 VA: 0x363E7C8
	public void set_PropertiesRevision(int value) { }

	// RVA: 0x363E7D0 Offset: 0x363A7D0 VA: 0x363E7D0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363E7D8 Offset: 0x363A7D8 VA: 0x363E7D8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363E7E0 Offset: 0x363A7E0 VA: 0x363E7E0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363E904 Offset: 0x363A904 VA: 0x363E904 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
