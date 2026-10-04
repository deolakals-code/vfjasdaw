// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Trades
public class TradeStateEvent_ : EventSubBase // TypeDefIndex: 12898
{
	// Fields
	[CompilerGenerated]
	private int <MemberId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x24

	// Properties
	public int MemberId { get; set; }
	public byte State { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x367253C Offset: 0x366E53C VA: 0x367253C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3672544 Offset: 0x366E544 VA: 0x3672544
	public int get_MemberId() { }

	[CompilerGenerated]
	// RVA: 0x367254C Offset: 0x366E54C VA: 0x367254C
	public void set_MemberId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3672554 Offset: 0x366E554 VA: 0x3672554
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x367255C Offset: 0x366E55C VA: 0x367255C
	public void set_State(byte value) { }

	// RVA: 0x3672564 Offset: 0x366E564 VA: 0x3672564 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367256C Offset: 0x366E56C VA: 0x367256C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3672574 Offset: 0x366E574 VA: 0x3672574 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3672650 Offset: 0x366E650 VA: 0x3672650 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
