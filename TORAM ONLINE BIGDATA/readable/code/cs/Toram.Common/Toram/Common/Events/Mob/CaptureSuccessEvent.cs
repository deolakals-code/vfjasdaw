// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Mob
public class CaptureSuccessEvent : EventSubBase // TypeDefIndex: 12641
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x24
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public int ArchetypeId { get; set; }
	public int TargetId { get; set; }
	public ItemDatav2[] ItemList { get; set; }

	// Methods

	// RVA: 0x3637A50 Offset: 0x3633A50 VA: 0x3637A50
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3637A58 Offset: 0x3633A58 VA: 0x3637A58 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3637A60 Offset: 0x3633A60 VA: 0x3637A60 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3637A68 Offset: 0x3633A68 VA: 0x3637A68
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3637A70 Offset: 0x3633A70 VA: 0x3637A70
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3637A78 Offset: 0x3633A78 VA: 0x3637A78
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3637A80 Offset: 0x3633A80 VA: 0x3637A80
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3637A88 Offset: 0x3633A88 VA: 0x3637A88
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x3637A90 Offset: 0x3633A90 VA: 0x3637A90
	public void set_ItemList(ItemDatav2[] value) { }

	// RVA: 0x3637A98 Offset: 0x3633A98 VA: 0x3637A98 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3637CC4 Offset: 0x3633CC4 VA: 0x3637CC4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
