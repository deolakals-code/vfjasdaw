// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room
public class MobDebugStateEvent : EventSubBase // TypeDefIndex: 12739
{
	// Fields
	[CompilerGenerated]
	private MobDebugData[] <MobDebugStateList>k__BackingField; // 0x20

	// Properties
	public MobDebugData[] MobDebugStateList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x364E07C Offset: 0x364A07C VA: 0x364E07C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364E084 Offset: 0x364A084 VA: 0x364E084
	public MobDebugData[] get_MobDebugStateList() { }

	[CompilerGenerated]
	// RVA: 0x364E08C Offset: 0x364A08C VA: 0x364E08C
	public void set_MobDebugStateList(MobDebugData[] value) { }

	// RVA: 0x364E094 Offset: 0x364A094 VA: 0x364E094 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364E09C Offset: 0x364A09C VA: 0x364E09C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x364E0A4 Offset: 0x364A0A4 VA: 0x364E0A4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x364E138 Offset: 0x364A138 VA: 0x364E138 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
