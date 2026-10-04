// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Alliance
public class GuildAllianceGetStaffDataResponse : OperationResponseBase // TypeDefIndex: 12477
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <StaffName>k__BackingField; // 0x28
	[CompilerGenerated]
	private NewStyleData <StaffStyleData>k__BackingField; // 0x30
	[CompilerGenerated]
	private GuildStaffEquipData[] <StaffEquipList>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 0)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 6)]
	public string StaffName { get; set; }
	[PacketClass(Code = 2)]
	public NewStyleData StaffStyleData { get; set; }
	[PacketParameter(Code = 15)]
	public GuildStaffEquipData[] StaffEquipList { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x360DA94 Offset: 0x3609A94 VA: 0x360DA94
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x360DA9C Offset: 0x3609A9C VA: 0x360DA9C
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x360DAA4 Offset: 0x3609AA4 VA: 0x360DAA4
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x360DAAC Offset: 0x3609AAC VA: 0x360DAAC
	public string get_StaffName() { }

	[CompilerGenerated]
	// RVA: 0x360DAB4 Offset: 0x3609AB4 VA: 0x360DAB4
	public void set_StaffName(string value) { }

	[CompilerGenerated]
	// RVA: 0x360DABC Offset: 0x3609ABC VA: 0x360DABC
	public NewStyleData get_StaffStyleData() { }

	[CompilerGenerated]
	// RVA: 0x360DAC4 Offset: 0x3609AC4 VA: 0x360DAC4
	public void set_StaffStyleData(NewStyleData value) { }

	[CompilerGenerated]
	// RVA: 0x360DACC Offset: 0x3609ACC VA: 0x360DACC
	public GuildStaffEquipData[] get_StaffEquipList() { }

	[CompilerGenerated]
	// RVA: 0x360DAD4 Offset: 0x3609AD4 VA: 0x360DAD4
	public void set_StaffEquipList(GuildStaffEquipData[] value) { }

	// RVA: 0x360DADC Offset: 0x3609ADC VA: 0x360DADC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360DAE4 Offset: 0x3609AE4 VA: 0x360DAE4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360DAEC Offset: 0x3609AEC VA: 0x360DAEC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360DBFC Offset: 0x3609BFC VA: 0x360DBFC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
