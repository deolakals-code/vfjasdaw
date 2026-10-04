// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.WaveRaid
public class WaveRaidMinusHateEvent : EventSubBase // TypeDefIndex: 12782
{
	// Fields
	[CompilerGenerated]
	private int[] <TargetId>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 96)]
	public int[] TargetId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3657D08 Offset: 0x3653D08 VA: 0x3657D08
	public int[] get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3657D10 Offset: 0x3653D10 VA: 0x3657D10
	public void set_TargetId(int[] value) { }

	// RVA: 0x3657D18 Offset: 0x3653D18 VA: 0x3657D18 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3657D20 Offset: 0x3653D20 VA: 0x3657D20 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3657D28 Offset: 0x3653D28 VA: 0x3657D28
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3657D30 Offset: 0x3653D30 VA: 0x3657D30 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3657EA0 Offset: 0x3653EA0 VA: 0x3657EA0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3657DC8 Offset: 0x3653DC8 VA: 0x3657DC8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3657ED4 Offset: 0x3653ED4 VA: 0x3657ED4
	private void GetClass(Dictionary<byte, object> parameters) { }
}
