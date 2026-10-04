// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class DefenceMobData : MobData // TypeDefIndex: 13151
{
	// Fields
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x68
	[CompilerGenerated]
	private byte <TargetId>k__BackingField; // 0x6A

	// Properties
	[UnityHash(Code = 73, IsOptional = True)]
	public short Level { get; set; }
	[UnityHash(Code = 79, IsOptional = True)]
	public byte TargetId { get; set; }

	// Methods

	// RVA: 0x36B5410 Offset: 0x36B1410 VA: 0x36B5410
	public void .ctor() { }

	// RVA: 0x36B5420 Offset: 0x36B1420 VA: 0x36B5420
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36B5430 Offset: 0x36B1430 VA: 0x36B5430
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x36B5438 Offset: 0x36B1438 VA: 0x36B5438
	public void set_Level(short value) { }

	[CompilerGenerated]
	// RVA: 0x36B5440 Offset: 0x36B1440 VA: 0x36B5440
	public byte get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x36B5448 Offset: 0x36B1448 VA: 0x36B5448
	public void set_TargetId(byte value) { }

	// RVA: 0x36B5450 Offset: 0x36B1450 VA: 0x36B5450 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36B6240 Offset: 0x36B2240 VA: 0x36B6240 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
