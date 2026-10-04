// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Rhythm
public class RhythmSetting : OperationRequestBase // TypeDefIndex: 12216
{
	// Fields
	[CompilerGenerated]
	private RhythmSettingData <Setting>k__BackingField; // 0x20

	// Properties
	public RhythmSettingData Setting { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E255C Offset: 0x35DE55C VA: 0x35E255C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E2564 Offset: 0x35DE564 VA: 0x35E2564
	public RhythmSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x35E256C Offset: 0x35DE56C VA: 0x35E256C
	public void set_Setting(RhythmSettingData value) { }

	// RVA: 0x35E2574 Offset: 0x35DE574 VA: 0x35E2574 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E257C Offset: 0x35DE57C VA: 0x35E257C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E2584 Offset: 0x35DE584 VA: 0x35E2584 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E2720 Offset: 0x35DE720 VA: 0x35E2720 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
