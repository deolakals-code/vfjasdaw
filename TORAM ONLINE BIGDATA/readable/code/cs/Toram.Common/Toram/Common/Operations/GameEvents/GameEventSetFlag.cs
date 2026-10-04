// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.GameEvents
public class GameEventSetFlag : OperationRequestBase // TypeDefIndex: 11629
{
	// Fields
	[CompilerGenerated]
	private byte <EventType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Version>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <FlagId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Value>k__BackingField; // 0x29

	// Properties
	[PacketParameter(Code = 245)]
	public byte EventType { get; set; }
	[PacketParameter(Code = 215)]
	public int Version { get; set; }
	[PacketParameter(Code = 200)]
	public byte FlagId { get; set; }
	[PacketParameter(Code = 195)]
	public byte Value { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372820C Offset: 0x372420C VA: 0x372820C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3728214 Offset: 0x3724214 VA: 0x3728214
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x372821C Offset: 0x372421C VA: 0x372821C
	public void set_EventType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3728224 Offset: 0x3724224 VA: 0x3728224
	public int get_Version() { }

	[CompilerGenerated]
	// RVA: 0x372822C Offset: 0x372422C VA: 0x372822C
	public void set_Version(int value) { }

	[CompilerGenerated]
	// RVA: 0x3728234 Offset: 0x3724234 VA: 0x3728234
	public byte get_FlagId() { }

	[CompilerGenerated]
	// RVA: 0x372823C Offset: 0x372423C VA: 0x372823C
	public void set_FlagId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3728244 Offset: 0x3724244 VA: 0x3728244
	public byte get_Value() { }

	[CompilerGenerated]
	// RVA: 0x372824C Offset: 0x372424C VA: 0x372824C
	public void set_Value(byte value) { }

	// RVA: 0x3728254 Offset: 0x3724254 VA: 0x3728254 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372825C Offset: 0x372425C VA: 0x372825C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3728264 Offset: 0x3724264 VA: 0x3728264 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x372846C Offset: 0x372446C VA: 0x372846C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
