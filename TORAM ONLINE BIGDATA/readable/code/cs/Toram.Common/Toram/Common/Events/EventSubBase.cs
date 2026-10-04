// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public abstract class EventSubBase : PacketBase // TypeDefIndex: 12626
{
	// Properties
	[PacketParameter(Code = 244)]
	public abstract byte SubCode { get; }

	// Methods

	// RVA: 0x36340D8 Offset: 0x36300D8 VA: 0x36340D8
	public static byte GetSubCode(Dictionary<byte, object> parameters) { }

	// RVA: 0x363419C Offset: 0x363019C VA: 0x363419C
	protected void .ctor() { }

	// RVA: 0x362F220 Offset: 0x362B220 VA: 0x362F220
	protected void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract byte get_SubCode();

	// RVA: 0x36341A4 Offset: 0x36301A4 VA: 0x36341A4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36341AC Offset: 0x36301AC VA: 0x36341AC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
