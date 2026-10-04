// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.GameEvents
public class GameEventLoginResponse : OperationResponseBase // TypeDefIndex: 11621
{
	// Fields
	[CompilerGenerated]
	private byte <EventType>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<object, object> <Parameters>k__BackingField; // 0x28

	// Properties
	public byte EventType { get; set; }
	public Dictionary<object, object> Parameters { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3726D00 Offset: 0x3722D00 VA: 0x3726D00
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3726D08 Offset: 0x3722D08 VA: 0x3726D08
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x3726D10 Offset: 0x3722D10 VA: 0x3726D10
	public void set_EventType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3726D18 Offset: 0x3722D18 VA: 0x3726D18
	public Dictionary<object, object> get_Parameters() { }

	[CompilerGenerated]
	// RVA: 0x3726D20 Offset: 0x3722D20 VA: 0x3726D20
	public void set_Parameters(Dictionary<object, object> value) { }

	// RVA: 0x3726D28 Offset: 0x3722D28 VA: 0x3726D28 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3726D30 Offset: 0x3722D30 VA: 0x3726D30 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3726D38 Offset: 0x3722D38 VA: 0x3726D38 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3726EF8 Offset: 0x3722EF8 VA: 0x3726EF8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
