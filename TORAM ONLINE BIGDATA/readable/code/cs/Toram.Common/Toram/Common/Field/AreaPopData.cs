// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Field
public class AreaPopData : UnityHashBase // TypeDefIndex: 11199
{
	// Fields
	[CompilerGenerated]
	private int <AreaGauge>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short <BonusGauge>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <BonusMaxGauge>k__BackingField; // 0x22

	// Properties
	[UnityHash(Code = 240)]
	public int AreaGauge { get; set; }
	[UnityHash(Code = 206, IsOptional = True)]
	public short BonusGauge { get; set; }
	[UnityHash(Code = 146)]
	public short BonusMaxGauge { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35D6DD8 Offset: 0x35D2DD8 VA: 0x35D6DD8
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35D6DE0 Offset: 0x35D2DE0 VA: 0x35D6DE0
	public int get_AreaGauge() { }

	[CompilerGenerated]
	// RVA: 0x35D6DE8 Offset: 0x35D2DE8 VA: 0x35D6DE8
	public void set_AreaGauge(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D6DF0 Offset: 0x35D2DF0 VA: 0x35D6DF0
	public short get_BonusGauge() { }

	[CompilerGenerated]
	// RVA: 0x35D6DF8 Offset: 0x35D2DF8 VA: 0x35D6DF8
	public void set_BonusGauge(short value) { }

	[CompilerGenerated]
	// RVA: 0x35D6E00 Offset: 0x35D2E00 VA: 0x35D6E00
	public short get_BonusMaxGauge() { }

	[CompilerGenerated]
	// RVA: 0x35D6E08 Offset: 0x35D2E08 VA: 0x35D6E08
	public void set_BonusMaxGauge(short value) { }

	// RVA: 0x35D6E10 Offset: 0x35D2E10 VA: 0x35D6E10 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35D6E18 Offset: 0x35D2E18 VA: 0x35D6E18 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35D7080 Offset: 0x35D3080 VA: 0x35D7080 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
