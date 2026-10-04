// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Mob
public class CaptureFailedEvent : EventSubBase // TypeDefIndex: 12639
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x24
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x28
	[CompilerGenerated]
	private AbnormalData <AbnormalData>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public int ArchetypeId { get; set; }
	public int TargetId { get; set; }
	public ItemDatav2[] ItemList { get; set; }
	public AbnormalData AbnormalData { get; set; }

	// Methods

	// RVA: 0x3637098 Offset: 0x3633098 VA: 0x3637098
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x36370A0 Offset: 0x36330A0 VA: 0x36370A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36370A8 Offset: 0x36330A8 VA: 0x36370A8 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x36370B0 Offset: 0x36330B0 VA: 0x36370B0
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36370B8 Offset: 0x36330B8 VA: 0x36370B8
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36370C0 Offset: 0x36330C0 VA: 0x36370C0
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x36370C8 Offset: 0x36330C8 VA: 0x36370C8
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36370D0 Offset: 0x36330D0 VA: 0x36370D0
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x36370D8 Offset: 0x36330D8 VA: 0x36370D8
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x36370E0 Offset: 0x36330E0 VA: 0x36370E0
	public AbnormalData get_AbnormalData() { }

	[CompilerGenerated]
	// RVA: 0x36370E8 Offset: 0x36330E8 VA: 0x36370E8
	public void set_AbnormalData(AbnormalData value) { }

	// RVA: 0x36370F0 Offset: 0x36330F0 VA: 0x36370F0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36373E4 Offset: 0x36333E4 VA: 0x36373E4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
