// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.GameEvents
public class GetEvent : OperationRequestBase // TypeDefIndex: 11631
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

	// RVA: 0x3728890 Offset: 0x3724890 VA: 0x3728890
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3728898 Offset: 0x3724898 VA: 0x3728898
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x37288A0 Offset: 0x37248A0 VA: 0x37288A0
	public void set_EventType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37288A8 Offset: 0x37248A8 VA: 0x37288A8
	public Dictionary<byte, object> get_Parameters() { }

	[CompilerGenerated]
	// RVA: 0x37288B0 Offset: 0x37248B0 VA: 0x37288B0
	public void set_Parameters(Dictionary<byte, object> value) { }

	// RVA: 0x37288B8 Offset: 0x37248B8 VA: 0x37288B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37288C0 Offset: 0x37248C0 VA: 0x37288C0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37288C8 Offset: 0x37248C8 VA: 0x37288C8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3728A88 Offset: 0x3724A88 VA: 0x3728A88 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
