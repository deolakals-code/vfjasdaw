// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.GameEvents
public class GameEventSetFlagResponse : OperationResponseBase // TypeDefIndex: 11630
{
	// Fields
	[CompilerGenerated]
	private byte <EventType>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <FlagId>k__BackingField; // 0x21
	[CompilerGenerated]
	private byte <Value>k__BackingField; // 0x22

	// Properties
	[PacketParameter(Code = 245)]
	public byte EventType { get; set; }
	[PacketParameter(Code = 200)]
	public byte FlagId { get; set; }
	[PacketParameter(Code = 195)]
	public byte Value { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37285A0 Offset: 0x37245A0 VA: 0x37285A0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37285A8 Offset: 0x37245A8 VA: 0x37285A8
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x37285B0 Offset: 0x37245B0 VA: 0x37285B0
	public void set_EventType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37285B8 Offset: 0x37245B8 VA: 0x37285B8
	public byte get_FlagId() { }

	[CompilerGenerated]
	// RVA: 0x37285C0 Offset: 0x37245C0 VA: 0x37285C0
	public void set_FlagId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37285C8 Offset: 0x37245C8 VA: 0x37285C8
	public byte get_Value() { }

	[CompilerGenerated]
	// RVA: 0x37285D0 Offset: 0x37245D0 VA: 0x37285D0
	public void set_Value(byte value) { }

	// RVA: 0x37285D8 Offset: 0x37245D8 VA: 0x37285D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37285E0 Offset: 0x37245E0 VA: 0x37285E0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37285E8 Offset: 0x37245E8 VA: 0x37285E8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3728798 Offset: 0x3724798 VA: 0x3728798 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
