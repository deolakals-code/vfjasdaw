// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobActionStartResponseData : UnityHashBase // TypeDefIndex: 13130
{
	// Fields
	[CompilerGenerated]
	private MobResponseData <MobData>k__BackingField; // 0x20
	[CompilerGenerated]
	private MobaMobResponseData <MobaMobData>k__BackingField; // 0x28

	// Properties
	public MobResponseData MobData { get; set; }
	public MobaMobResponseData MobaMobData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36AD334 Offset: 0x36A9334 VA: 0x36AD334
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36AD33C Offset: 0x36A933C VA: 0x36AD33C
	public MobResponseData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x36AD344 Offset: 0x36A9344 VA: 0x36AD344
	public void set_MobData(MobResponseData value) { }

	[CompilerGenerated]
	// RVA: 0x36AD34C Offset: 0x36A934C VA: 0x36AD34C
	public MobaMobResponseData get_MobaMobData() { }

	[CompilerGenerated]
	// RVA: 0x36AD354 Offset: 0x36A9354 VA: 0x36AD354
	public void set_MobaMobData(MobaMobResponseData value) { }

	// RVA: 0x36AD35C Offset: 0x36A935C VA: 0x36AD35C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36AD364 Offset: 0x36A9364 VA: 0x36AD364 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36AD4AC Offset: 0x36A94AC VA: 0x36AD4AC Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
