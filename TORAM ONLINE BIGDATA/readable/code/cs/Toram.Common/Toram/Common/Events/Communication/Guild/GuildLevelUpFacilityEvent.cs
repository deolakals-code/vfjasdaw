// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildLevelUpFacilityEvent : EventSubBase // TypeDefIndex: 12903
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildFacilityData <Facility>k__BackingField; // 0x28
	[CompilerGenerated]
	private GuildVariableData[] <Variables>k__BackingField; // 0x30
	[CompilerGenerated]
	private GuildItemData[] <Items>k__BackingField; // 0x38
	[CompilerGenerated]
	private GuildFacilityUseElementData <UseElementData>k__BackingField; // 0x40

	// Properties
	public int GuildId { get; set; }
	public GuildFacilityData Facility { get; set; }
	public GuildVariableData[] Variables { get; set; }
	public GuildItemData[] Items { get; set; }
	public GuildFacilityUseElementData UseElementData { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3673280 Offset: 0x366F280 VA: 0x3673280
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3673288 Offset: 0x366F288 VA: 0x3673288
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3673290 Offset: 0x366F290 VA: 0x3673290
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3673298 Offset: 0x366F298 VA: 0x3673298
	public GuildFacilityData get_Facility() { }

	[CompilerGenerated]
	// RVA: 0x36732A0 Offset: 0x366F2A0 VA: 0x36732A0
	public void set_Facility(GuildFacilityData value) { }

	[CompilerGenerated]
	// RVA: 0x36732A8 Offset: 0x366F2A8 VA: 0x36732A8
	public GuildVariableData[] get_Variables() { }

	[CompilerGenerated]
	// RVA: 0x36732B0 Offset: 0x366F2B0 VA: 0x36732B0
	public void set_Variables(GuildVariableData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36732B8 Offset: 0x366F2B8 VA: 0x36732B8
	public GuildItemData[] get_Items() { }

	[CompilerGenerated]
	// RVA: 0x36732C0 Offset: 0x366F2C0 VA: 0x36732C0
	public void set_Items(GuildItemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36732C8 Offset: 0x366F2C8 VA: 0x36732C8
	public GuildFacilityUseElementData get_UseElementData() { }

	[CompilerGenerated]
	// RVA: 0x36732D0 Offset: 0x366F2D0 VA: 0x36732D0
	public void set_UseElementData(GuildFacilityUseElementData value) { }

	// RVA: 0x36732D8 Offset: 0x366F2D8 VA: 0x36732D8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36732E0 Offset: 0x366F2E0 VA: 0x36732E0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36732E8 Offset: 0x366F2E8 VA: 0x36732E8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3673448 Offset: 0x366F448 VA: 0x3673448 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
