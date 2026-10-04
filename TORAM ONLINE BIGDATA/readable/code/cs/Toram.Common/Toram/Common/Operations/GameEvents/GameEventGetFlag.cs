// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.GameEvents
public class GameEventGetFlag : OperationRequestBase // TypeDefIndex: 11624
{
	// Fields
	[CompilerGenerated]
	private byte <EventType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Version>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <FlagId>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 245)]
	public byte EventType { get; set; }
	[PacketParameter(Code = 215)]
	public int Version { get; set; }
	[PacketParameter(Code = 200)]
	public byte FlagId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3727528 Offset: 0x3723528 VA: 0x3727528
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3727530 Offset: 0x3723530 VA: 0x3727530
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x3727538 Offset: 0x3723538 VA: 0x3727538
	public void set_EventType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3727540 Offset: 0x3723540 VA: 0x3727540
	public int get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3727548 Offset: 0x3723548 VA: 0x3727548
	public void set_Version(int value) { }

	[CompilerGenerated]
	// RVA: 0x3727550 Offset: 0x3723550 VA: 0x3727550
	public byte get_FlagId() { }

	[CompilerGenerated]
	// RVA: 0x3727558 Offset: 0x3723558 VA: 0x3727558
	public void set_FlagId(byte value) { }

	// RVA: 0x3727560 Offset: 0x3723560 VA: 0x3727560 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3727568 Offset: 0x3723568 VA: 0x3727568 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3727570 Offset: 0x3723570 VA: 0x3727570 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3727734 Offset: 0x3723734 VA: 0x3727734 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
