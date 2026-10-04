// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Facility
public class GuildLevelUpFacilityResponse : OperationResponseBase // TypeDefIndex: 12441
{
	// Fields
	[CompilerGenerated]
	private GuildFacilityData <Facility>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildVariableData[] <Variables>k__BackingField; // 0x28
	[CompilerGenerated]
	private GuildItemData[] <Items>k__BackingField; // 0x30
	[CompilerGenerated]
	private GuildFacilityUseElementData <UseElementData>k__BackingField; // 0x38

	// Properties
	[PacketClass(Code = 2)]
	public GuildFacilityData Facility { get; set; }
	[PacketClass(Code = 15)]
	public GuildVariableData[] Variables { get; set; }
	[PacketClass(Code = 16)]
	public GuildItemData[] Items { get; set; }
	[PacketClass(Code = 29)]
	public GuildFacilityUseElementData UseElementData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36089F8 Offset: 0x36049F8 VA: 0x36089F8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3608A00 Offset: 0x3604A00 VA: 0x3608A00
	public GuildFacilityData get_Facility() { }

	[CompilerGenerated]
	// RVA: 0x3608A08 Offset: 0x3604A08 VA: 0x3608A08
	public void set_Facility(GuildFacilityData value) { }

	[CompilerGenerated]
	// RVA: 0x3608A10 Offset: 0x3604A10 VA: 0x3608A10
	public GuildVariableData[] get_Variables() { }

	[CompilerGenerated]
	// RVA: 0x3608A18 Offset: 0x3604A18 VA: 0x3608A18
	public void set_Variables(GuildVariableData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3608A20 Offset: 0x3604A20 VA: 0x3608A20
	public GuildItemData[] get_Items() { }

	[CompilerGenerated]
	// RVA: 0x3608A28 Offset: 0x3604A28 VA: 0x3608A28
	public void set_Items(GuildItemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3608A30 Offset: 0x3604A30 VA: 0x3608A30
	public GuildFacilityUseElementData get_UseElementData() { }

	[CompilerGenerated]
	// RVA: 0x3608A38 Offset: 0x3604A38 VA: 0x3608A38
	public void set_UseElementData(GuildFacilityUseElementData value) { }

	// RVA: 0x3608A40 Offset: 0x3604A40 VA: 0x3608A40 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3608A48 Offset: 0x3604A48 VA: 0x3608A48 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3608A50 Offset: 0x3604A50 VA: 0x3608A50 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3608D9C Offset: 0x3604D9C VA: 0x3608D9C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
