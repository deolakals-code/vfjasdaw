// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.GameEvents
public class SetEventResponse : OperationResponseBase // TypeDefIndex: 11634
{
	// Fields
	[CompilerGenerated]
	private byte <EventType>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<byte, object> <Parameters>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 245)]
	public byte EventType { get; set; }
	[PacketParameter(Code = 18, IsOptional = True)]
	public Dictionary<byte, object> Parameters { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37290A0 Offset: 0x37250A0 VA: 0x37290A0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37290A8 Offset: 0x37250A8 VA: 0x37290A8
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x37290B0 Offset: 0x37250B0 VA: 0x37290B0
	public void set_EventType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37290B8 Offset: 0x37250B8 VA: 0x37290B8
	public Dictionary<byte, object> get_Parameters() { }

	[CompilerGenerated]
	// RVA: 0x37290C0 Offset: 0x37250C0 VA: 0x37290C0
	public void set_Parameters(Dictionary<byte, object> value) { }

	// RVA: 0x37290C8 Offset: 0x37250C8 VA: 0x37290C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37290D0 Offset: 0x37250D0 VA: 0x37290D0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37290D8 Offset: 0x37250D8 VA: 0x37290D8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3729298 Offset: 0x3725298 VA: 0x3729298 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
