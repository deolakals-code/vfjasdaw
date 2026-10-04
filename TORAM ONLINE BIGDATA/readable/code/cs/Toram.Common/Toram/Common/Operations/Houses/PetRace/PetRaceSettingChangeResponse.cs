// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.PetRace
public class PetRaceSettingChangeResponse : OperationResponseBase // TypeDefIndex: 12224
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

	// RVA: 0x35E3338 Offset: 0x35DF338 VA: 0x35E3338
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E3340 Offset: 0x35DF340 VA: 0x35E3340
	public int get_CourseId() { }

	[CompilerGenerated]
	// RVA: 0x35E3348 Offset: 0x35DF348 VA: 0x35E3348
	public void set_CourseId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E3350 Offset: 0x35DF350 VA: 0x35E3350
	public short get_SettingBitFlag() { }

	[CompilerGenerated]
	// RVA: 0x35E3358 Offset: 0x35DF358 VA: 0x35E3358
	public void set_SettingBitFlag(short value) { }

	// RVA: 0x35E3360 Offset: 0x35DF360 VA: 0x35E3360 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E3368 Offset: 0x35DF368 VA: 0x35E3368 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E3370 Offset: 0x35DF370 VA: 0x35E3370 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E34E8 Offset: 0x35DF4E8 VA: 0x35E34E8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
