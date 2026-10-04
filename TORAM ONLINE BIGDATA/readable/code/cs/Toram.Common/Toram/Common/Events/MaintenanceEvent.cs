// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class MaintenanceEvent : PacketBase // TypeDefIndex: 12633
{
	// Fields
	[CompilerGenerated]
	private byte <RestTime>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 172)]
	public byte RestTime { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36360D8 Offset: 0x36320D8 VA: 0x36360D8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36360E0 Offset: 0x36320E0 VA: 0x36360E0
	public byte get_RestTime() { }

	[CompilerGenerated]
	// RVA: 0x36360E8 Offset: 0x36320E8 VA: 0x36360E8
	public void set_RestTime(byte value) { }

	// RVA: 0x36360F0 Offset: 0x36320F0 VA: 0x36360F0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36360F8 Offset: 0x36320F8 VA: 0x36360F8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3636218 Offset: 0x3632218 VA: 0x3636218 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
