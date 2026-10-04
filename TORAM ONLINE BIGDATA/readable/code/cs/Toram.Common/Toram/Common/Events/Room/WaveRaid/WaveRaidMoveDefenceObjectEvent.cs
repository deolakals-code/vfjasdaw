// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.WaveRaid
public class WaveRaidMoveDefenceObjectEvent : EventSubBase // TypeDefIndex: 12783
{
	// Fields
	[CompilerGenerated]
	private WaveTargetData <DefenceObject>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 73, IsOptional = True)]
	public WaveTargetData DefenceObject { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3657F30 Offset: 0x3653F30 VA: 0x3657F30
	public WaveTargetData get_DefenceObject() { }

	[CompilerGenerated]
	// RVA: 0x3657F38 Offset: 0x3653F38 VA: 0x3657F38
	public void set_DefenceObject(WaveTargetData value) { }

	// RVA: 0x3657F40 Offset: 0x3653F40 VA: 0x3657F40 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3657F48 Offset: 0x3653F48 VA: 0x3657F48 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3657F50 Offset: 0x3653F50 VA: 0x3657F50
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3657F58 Offset: 0x3653F58 VA: 0x3657F58 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x365810C Offset: 0x365410C VA: 0x365810C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3657FF0 Offset: 0x3653FF0 VA: 0x3657FF0
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3658140 Offset: 0x3654140 VA: 0x3658140
	private void GetClass(Dictionary<byte, object> parameters) { }
}
