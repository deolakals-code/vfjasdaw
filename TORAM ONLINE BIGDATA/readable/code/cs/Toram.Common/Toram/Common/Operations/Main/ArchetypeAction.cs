// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main
public class ArchetypeAction : PacketBase // TypeDefIndex: 11901
{
	// Fields
	[CompilerGenerated]
	private ActionData <ActionData>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 75)]
	public ActionData ActionData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37617BC Offset: 0x375D7BC VA: 0x37617BC
	public void .ctor() { }

	// RVA: 0x37617C4 Offset: 0x375D7C4 VA: 0x37617C4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37617CC Offset: 0x375D7CC VA: 0x37617CC
	public ActionData get_ActionData() { }

	[CompilerGenerated]
	// RVA: 0x37617D4 Offset: 0x375D7D4 VA: 0x37617D4
	public void set_ActionData(ActionData value) { }

	// RVA: 0x37617DC Offset: 0x375D7DC VA: 0x37617DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37617E4 Offset: 0x375D7E4 VA: 0x37617E4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3761954 Offset: 0x375D954 VA: 0x3761954 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
