// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.PetRace
public class PetRaceSettingChange : OperationRequestBase // TypeDefIndex: 12228
{
	// Fields
	[CompilerGenerated]
	private int <CourseId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <SettingBitFlag>k__BackingField; // 0x24

	// Properties
	public int CourseId { get; set; }
	public short SettingBitFlag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E3C64 Offset: 0x35DFC64 VA: 0x35E3C64
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E3C6C Offset: 0x35DFC6C VA: 0x35E3C6C
	public int get_CourseId() { }

	[CompilerGenerated]
	// RVA: 0x35E3C74 Offset: 0x35DFC74 VA: 0x35E3C74
	public void set_CourseId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E3C7C Offset: 0x35DFC7C VA: 0x35E3C7C
	public short get_SettingBitFlag() { }

	[CompilerGenerated]
	// RVA: 0x35E3C84 Offset: 0x35DFC84 VA: 0x35E3C84
	public void set_SettingBitFlag(short value) { }

	// RVA: 0x35E3C8C Offset: 0x35DFC8C VA: 0x35E3C8C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E3C94 Offset: 0x35DFC94 VA: 0x35E3C94 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E3C9C Offset: 0x35DFC9C VA: 0x35E3C9C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35E3D78 Offset: 0x35DFD78 VA: 0x35E3D78 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
