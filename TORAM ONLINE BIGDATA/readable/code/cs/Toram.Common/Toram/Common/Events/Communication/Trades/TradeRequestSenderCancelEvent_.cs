// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Trades
public class TradeRequestSenderCancelEvent_ : EventSubBase // TypeDefIndex: 12895
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <SenderName>k__BackingField; // 0x28

	// Properties
	public int TargetId { get; set; }
	public int SenderId { get; set; }
	public string SenderName { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3671548 Offset: 0x366D548 VA: 0x3671548
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3671550 Offset: 0x366D550 VA: 0x3671550
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3671558 Offset: 0x366D558 VA: 0x3671558
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3671560 Offset: 0x366D560 VA: 0x3671560
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x3671568 Offset: 0x366D568 VA: 0x3671568
	public void set_SenderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3671570 Offset: 0x366D570 VA: 0x3671570
	public string get_SenderName() { }

	[CompilerGenerated]
	// RVA: 0x3671578 Offset: 0x366D578 VA: 0x3671578
	public void set_SenderName(string value) { }

	// RVA: 0x3671580 Offset: 0x366D580 VA: 0x3671580 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3671588 Offset: 0x366D588 VA: 0x3671588 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3671590 Offset: 0x366D590 VA: 0x3671590 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x367166C Offset: 0x366D66C VA: 0x367166C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
