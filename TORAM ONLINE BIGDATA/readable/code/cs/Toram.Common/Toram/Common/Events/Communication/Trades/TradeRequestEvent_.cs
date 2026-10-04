// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Trades
public class TradeRequestEvent_ : EventSubBase // TypeDefIndex: 12894
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <SenderName>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public int TargetId { get; set; }
	public int SenderId { get; set; }
	public string SenderName { get; set; }

	// Methods

	// RVA: 0x3671260 Offset: 0x366D260 VA: 0x3671260
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3671268 Offset: 0x366D268 VA: 0x3671268 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3671270 Offset: 0x366D270 VA: 0x3671270 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3671278 Offset: 0x366D278 VA: 0x3671278
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3671280 Offset: 0x366D280 VA: 0x3671280
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3671288 Offset: 0x366D288 VA: 0x3671288
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x3671290 Offset: 0x366D290 VA: 0x3671290
	public void set_SenderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3671298 Offset: 0x366D298 VA: 0x3671298
	public string get_SenderName() { }

	[CompilerGenerated]
	// RVA: 0x36712A0 Offset: 0x366D2A0 VA: 0x36712A0
	public void set_SenderName(string value) { }

	// RVA: 0x36712A8 Offset: 0x366D2A8 VA: 0x36712A8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3671384 Offset: 0x366D384 VA: 0x3671384 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
