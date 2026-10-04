// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobEmergencyMoveEventData : UnityHashBase // TypeDefIndex: 13135
{
	// Fields
	[CompilerGenerated]
	private MobResponseData <MobData>k__BackingField; // 0x20

	// Properties
	[UnityHash(Code = 20)]
	public MobResponseData MobData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36AFC00 Offset: 0x36ABC00 VA: 0x36AFC00
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36AFC08 Offset: 0x36ABC08 VA: 0x36AFC08
	public MobResponseData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x36AFC10 Offset: 0x36ABC10 VA: 0x36AFC10
	public void set_MobData(MobResponseData value) { }

	// RVA: 0x36AFC18 Offset: 0x36ABC18 VA: 0x36AFC18 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36AFC20 Offset: 0x36ABC20 VA: 0x36AFC20 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36AFDC0 Offset: 0x36ABDC0 VA: 0x36AFDC0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
