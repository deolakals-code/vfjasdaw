// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room
public class RoomAnnihilatedEvent : PacketBase // TypeDefIndex: 12747
{
	// Fields
	[CompilerGenerated]
	private bool <IsAnnihilated>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <RespawnTime>k__BackingField; // 0x22

	// Properties
	[PacketParameter(Code = 43)]
	public bool IsAnnihilated { get; set; }
	[PacketParameter(Code = 119)]
	public short RespawnTime { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x364FED8 Offset: 0x364BED8 VA: 0x364FED8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364FEE0 Offset: 0x364BEE0 VA: 0x364FEE0
	public bool get_IsAnnihilated() { }

	[CompilerGenerated]
	// RVA: 0x364FEE8 Offset: 0x364BEE8 VA: 0x364FEE8
	public void set_IsAnnihilated(bool value) { }

	[CompilerGenerated]
	// RVA: 0x364FEF4 Offset: 0x364BEF4 VA: 0x364FEF4
	public short get_RespawnTime() { }

	[CompilerGenerated]
	// RVA: 0x364FEFC Offset: 0x364BEFC VA: 0x364FEFC
	public void set_RespawnTime(short value) { }

	// RVA: 0x364FF04 Offset: 0x364BF04 VA: 0x364FF04 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364FF0C Offset: 0x364BF0C VA: 0x364FF0C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3650084 Offset: 0x364C084 VA: 0x3650084 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
