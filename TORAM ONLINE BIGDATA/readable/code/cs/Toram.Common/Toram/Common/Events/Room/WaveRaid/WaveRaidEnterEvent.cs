// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.WaveRaid
public class WaveRaidEnterEvent : EventSubBase // TypeDefIndex: 12779
{
	// Fields
	[CompilerGenerated]
	private int <TeamId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 1)]
	public int TeamId { get; set; }
	[PacketParameter(Code = 60)]
	public int FieldId { get; set; }
	[PacketParameter(Code = 106)]
	public byte RoomId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3657284 Offset: 0x3653284 VA: 0x3657284
	public int get_TeamId() { }

	[CompilerGenerated]
	// RVA: 0x365728C Offset: 0x365328C VA: 0x365728C
	public void set_TeamId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3657294 Offset: 0x3653294 VA: 0x3657294
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x365729C Offset: 0x365329C VA: 0x365729C
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36572A4 Offset: 0x36532A4 VA: 0x36572A4
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x36572AC Offset: 0x36532AC VA: 0x36572AC
	public void set_RoomId(byte value) { }

	// RVA: 0x36572B4 Offset: 0x36532B4 VA: 0x36572B4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36572BC Offset: 0x36532BC VA: 0x36572BC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36572C4 Offset: 0x36532C4 VA: 0x36572C4
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x36572CC Offset: 0x36532CC VA: 0x36572CC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3657490 Offset: 0x3653490 VA: 0x3657490 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
