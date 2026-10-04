// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party
public class PartyUnreceivedMessageResponse : OperationResponseBase // TypeDefIndex: 11461
{
	// Fields
	[CompilerGenerated]
	private ChatData[] <PartyMessages>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <PartyLoginTime>k__BackingField; // 0x28

	// Properties
	public ChatData[] PartyMessages { get; set; }
	public DateTime PartyLoginTime { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x370DE00 Offset: 0x3709E00 VA: 0x370DE00
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x370DE08 Offset: 0x3709E08 VA: 0x370DE08
	public ChatData[] get_PartyMessages() { }

	[CompilerGenerated]
	// RVA: 0x370DE10 Offset: 0x3709E10 VA: 0x370DE10
	public void set_PartyMessages(ChatData[] value) { }

	[CompilerGenerated]
	// RVA: 0x370DE18 Offset: 0x3709E18 VA: 0x370DE18
	public DateTime get_PartyLoginTime() { }

	[CompilerGenerated]
	// RVA: 0x370DE20 Offset: 0x3709E20 VA: 0x370DE20
	public void set_PartyLoginTime(DateTime value) { }

	// RVA: 0x370DE28 Offset: 0x3709E28 VA: 0x370DE28 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370DE30 Offset: 0x3709E30 VA: 0x370DE30 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x370DE38 Offset: 0x3709E38 VA: 0x370DE38 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370E030 Offset: 0x370A030 VA: 0x370E030 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
