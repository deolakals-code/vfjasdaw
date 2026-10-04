// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Rhythm
public class RhythmReady : OperationRequestBase // TypeDefIndex: 12215
{
	// Fields
	[CompilerGenerated]
	private RhythmSettingData <Setting>k__BackingField; // 0x20

	// Properties
	public RhythmSettingData Setting { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E2310 Offset: 0x35DE310 VA: 0x35E2310
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E2318 Offset: 0x35DE318 VA: 0x35E2318
	public RhythmSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x35E2320 Offset: 0x35DE320 VA: 0x35E2320
	public void set_Setting(RhythmSettingData value) { }

	// RVA: 0x35E2328 Offset: 0x35DE328 VA: 0x35E2328 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E2330 Offset: 0x35DE330 VA: 0x35E2330 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E2338 Offset: 0x35DE338 VA: 0x35E2338 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E24D4 Offset: 0x35DE4D4 VA: 0x35E24D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
