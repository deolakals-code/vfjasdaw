// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Companions
public class CompanionNewJoinData : PacketBase // TypeDefIndex: 12940
{
	// Fields
	[CompilerGenerated]
	private CompanionData <CompanionData>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x30
	[CompilerGenerated]
	private Dictionary<byte, object> <ArchetypeProperties>k__BackingField; // 0x38

	// Properties
	public CompanionData CompanionData { get; set; }
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public Dictionary<byte, object> ArchetypeProperties { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x367CF74 Offset: 0x3678F74 VA: 0x367CF74
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x367CF7C Offset: 0x3678F7C VA: 0x367CF7C
	public CompanionData get_CompanionData() { }

	[CompilerGenerated]
	// RVA: 0x367CF84 Offset: 0x3678F84 VA: 0x367CF84
	public void set_CompanionData(CompanionData value) { }

	[CompilerGenerated]
	// RVA: 0x367CF8C Offset: 0x3678F8C VA: 0x367CF8C
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x367CF94 Offset: 0x3678F94 VA: 0x367CF94
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x367CF9C Offset: 0x3678F9C VA: 0x367CF9C
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x367CFA4 Offset: 0x3678FA4 VA: 0x367CFA4
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x367CFAC Offset: 0x3678FAC VA: 0x367CFAC
	public Dictionary<byte, object> get_ArchetypeProperties() { }

	[CompilerGenerated]
	// RVA: 0x367CFB4 Offset: 0x3678FB4 VA: 0x367CFB4
	public void set_ArchetypeProperties(Dictionary<byte, object> value) { }

	// RVA: 0x367CFBC Offset: 0x3678FBC VA: 0x367CFBC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367CFC4 Offset: 0x3678FC4 VA: 0x367CFC4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x367D0E4 Offset: 0x36790E4 VA: 0x367D0E4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
