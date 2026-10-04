// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Orbs
public class OrbRelatedEvent : PacketBase // TypeDefIndex: 12649
{
	// Fields
	[CompilerGenerated]
	private OrbBonusData[] <OrbBonus>k__BackingField; // 0x20
	[CompilerGenerated]
	private OrbItemData[] <OrbItems>k__BackingField; // 0x28
	[CompilerGenerated]
	private OrbClosetData <OrbCloset>k__BackingField; // 0x30
	[CompilerGenerated]
	private CourseData[] <Courses>k__BackingField; // 0x38

	// Properties
	[PacketClass(Code = 206, IsOptional = True)]
	public OrbBonusData[] OrbBonus { get; set; }
	[PacketClass(Code = 231, IsOptional = True)]
	public OrbItemData[] OrbItems { get; set; }
	[PacketClass(Code = 80)]
	public OrbClosetData OrbCloset { get; set; }
	public CourseData[] Courses { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3639530 Offset: 0x3635530 VA: 0x3639530
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3639538 Offset: 0x3635538 VA: 0x3639538
	public OrbBonusData[] get_OrbBonus() { }

	[CompilerGenerated]
	// RVA: 0x3639540 Offset: 0x3635540 VA: 0x3639540
	public void set_OrbBonus(OrbBonusData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3639548 Offset: 0x3635548 VA: 0x3639548
	public OrbItemData[] get_OrbItems() { }

	[CompilerGenerated]
	// RVA: 0x3639550 Offset: 0x3635550 VA: 0x3639550
	public void set_OrbItems(OrbItemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3639558 Offset: 0x3635558 VA: 0x3639558
	public OrbClosetData get_OrbCloset() { }

	[CompilerGenerated]
	// RVA: 0x3639560 Offset: 0x3635560 VA: 0x3639560
	public void set_OrbCloset(OrbClosetData value) { }

	[CompilerGenerated]
	// RVA: 0x3639568 Offset: 0x3635568 VA: 0x3639568
	public CourseData[] get_Courses() { }

	[CompilerGenerated]
	// RVA: 0x3639570 Offset: 0x3635570 VA: 0x3639570
	public void set_Courses(CourseData[] value) { }

	// RVA: 0x3639578 Offset: 0x3635578 VA: 0x3639578 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3639580 Offset: 0x3635580 VA: 0x3639580 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3639900 Offset: 0x3635900 VA: 0x3639900 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
