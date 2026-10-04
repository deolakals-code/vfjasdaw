// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.GameEvents
public class GameEventGetFlagResponse : OperationResponseBase // TypeDefIndex: 11625
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

	// RVA: 0x3727840 Offset: 0x3723840 VA: 0x3727840
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3727848 Offset: 0x3723848 VA: 0x3727848
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x3727850 Offset: 0x3723850 VA: 0x3727850
	public void set_EventType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3727858 Offset: 0x3723858 VA: 0x3727858
	public byte get_FlagId() { }

	[CompilerGenerated]
	// RVA: 0x3727860 Offset: 0x3723860 VA: 0x3727860
	public void set_FlagId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3727868 Offset: 0x3723868 VA: 0x3727868
	public byte get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3727870 Offset: 0x3723870 VA: 0x3727870
	public void set_Value(byte value) { }

	// RVA: 0x3727878 Offset: 0x3723878 VA: 0x3727878 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3727880 Offset: 0x3723880 VA: 0x3727880 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3727888 Offset: 0x3723888 VA: 0x3727888 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3727A38 Offset: 0x3723A38 VA: 0x3727A38 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
