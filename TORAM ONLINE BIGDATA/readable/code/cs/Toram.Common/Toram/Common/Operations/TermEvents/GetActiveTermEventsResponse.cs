// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.TermEvents
public class GetActiveTermEventsResponse : OperationResponseBase // TypeDefIndex: 11727
{
	// Fields
	[CompilerGenerated]
	private TermEventData[] <List>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 15)]
	public TermEventData[] List { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373D2D4 Offset: 0x37392D4 VA: 0x373D2D4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x373D2DC Offset: 0x37392DC VA: 0x373D2DC
	public TermEventData[] get_List() { }

	[CompilerGenerated]
	// RVA: 0x373D2E4 Offset: 0x37392E4 VA: 0x373D2E4
	public void set_List(TermEventData[] value) { }

	// RVA: 0x373D2EC Offset: 0x37392EC VA: 0x373D2EC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373D2F4 Offset: 0x37392F4 VA: 0x373D2F4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373D2FC Offset: 0x37392FC VA: 0x373D2FC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373D37C Offset: 0x373937C VA: 0x373D37C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
