// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.GameEvents
public class GameEventGetScenarioResponse : OperationResponseBase // TypeDefIndex: 11627
{
	// Fields
	[CompilerGenerated]
	private byte <EventType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Version>k__BackingField; // 0x24
	[CompilerGenerated]
	private GameEventScenarioData <ScenarioData>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 245)]
	public byte EventType { get; set; }
	[PacketParameter(Code = 215)]
	public int Version { get; set; }
	[PacketClass(Code = 199, IsOptional = True)]
	public GameEventScenarioData ScenarioData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3727DBC Offset: 0x3723DBC VA: 0x3727DBC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3727DC4 Offset: 0x3723DC4 VA: 0x3727DC4
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x3727DCC Offset: 0x3723DCC VA: 0x3727DCC
	public void set_EventType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3727DD4 Offset: 0x3723DD4 VA: 0x3727DD4
	public int get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3727DDC Offset: 0x3723DDC VA: 0x3727DDC
	public void set_Version(int value) { }

	[CompilerGenerated]
	// RVA: 0x3727DE4 Offset: 0x3723DE4 VA: 0x3727DE4
	public GameEventScenarioData get_ScenarioData() { }

	[CompilerGenerated]
	// RVA: 0x3727DEC Offset: 0x3723DEC VA: 0x3727DEC
	public void set_ScenarioData(GameEventScenarioData value) { }

	// RVA: 0x3727DF4 Offset: 0x3723DF4 VA: 0x3727DF4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3727F10 Offset: 0x3723F10 VA: 0x3727F10
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3727F8C Offset: 0x3723F8C VA: 0x3727F8C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3727F94 Offset: 0x3723F94 VA: 0x3727F94 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3727F9C Offset: 0x3723F9C VA: 0x3727F9C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3728124 Offset: 0x3724124 VA: 0x3728124 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
