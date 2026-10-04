// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Trades
public class TradeCancelEvent_ : EventSubBase // TypeDefIndex: 12893
{
	// Fields
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x20

	// Properties
	public byte State { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3671078 Offset: 0x366D078 VA: 0x3671078
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3671080 Offset: 0x366D080 VA: 0x3671080
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x3671088 Offset: 0x366D088 VA: 0x3671088
	public void set_State(byte value) { }

	// RVA: 0x3671090 Offset: 0x366D090 VA: 0x3671090 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3671098 Offset: 0x366D098 VA: 0x3671098 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36710A0 Offset: 0x366D0A0 VA: 0x36710A0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3671140 Offset: 0x366D140 VA: 0x3671140 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
