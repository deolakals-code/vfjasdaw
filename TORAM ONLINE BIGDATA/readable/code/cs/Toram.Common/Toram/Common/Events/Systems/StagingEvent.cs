// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Systems
public class StagingEvent : PacketBase // TypeDefIndex: 12731
{
	// Fields
	[CompilerGenerated]
	private byte <RestTime>k__BackingField; // 0x20

	// Properties
	public byte RestTime { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x364C8E8 Offset: 0x36488E8 VA: 0x364C8E8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364C8F0 Offset: 0x36488F0 VA: 0x364C8F0
	public byte get_RestTime() { }

	[CompilerGenerated]
	// RVA: 0x364C8F8 Offset: 0x36488F8 VA: 0x364C8F8
	public void set_RestTime(byte value) { }

	// RVA: 0x364C900 Offset: 0x3648900 VA: 0x364C900 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364C908 Offset: 0x3648908 VA: 0x364C908 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x364CA28 Offset: 0x3648A28 VA: 0x364CA28 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
