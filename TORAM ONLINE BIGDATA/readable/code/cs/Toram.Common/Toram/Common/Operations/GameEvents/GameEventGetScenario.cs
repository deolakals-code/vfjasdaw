// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.GameEvents
public class GameEventGetScenario : OperationRequestBase // TypeDefIndex: 11626
{
	// Fields
	[CompilerGenerated]
	private byte <EventType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Version>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 245)]
	public byte EventType { get; set; }
	[PacketParameter(Code = 215)]
	public int Version { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3727B30 Offset: 0x3723B30 VA: 0x3727B30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3727B38 Offset: 0x3723B38 VA: 0x3727B38
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x3727B40 Offset: 0x3723B40 VA: 0x3727B40
	public void set_EventType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3727B48 Offset: 0x3723B48 VA: 0x3727B48
	public int get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3727B50 Offset: 0x3723B50 VA: 0x3727B50
	public void set_Version(int value) { }

	// RVA: 0x3727B58 Offset: 0x3723B58 VA: 0x3727B58 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3727B60 Offset: 0x3723B60 VA: 0x3727B60 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3727B68 Offset: 0x3723B68 VA: 0x3727B68 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3727CE0 Offset: 0x3723CE0 VA: 0x3727CE0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
