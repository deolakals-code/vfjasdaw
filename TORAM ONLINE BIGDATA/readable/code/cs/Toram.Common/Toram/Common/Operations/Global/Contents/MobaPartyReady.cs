// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents
public class MobaPartyReady : OperationRequestBase // TypeDefIndex: 11580
{
	// Fields
	[CompilerGenerated]
	private byte <PartyGameId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <AppliId>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <AppNumber>k__BackingField; // 0x28

	// Properties
	public byte PartyGameId { get; set; }
	public int AppliId { get; set; }
	public string AppNumber { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371E3A0 Offset: 0x371A3A0 VA: 0x371E3A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371E3A8 Offset: 0x371A3A8 VA: 0x371E3A8
	public byte get_PartyGameId() { }

	[CompilerGenerated]
	// RVA: 0x371E3B0 Offset: 0x371A3B0 VA: 0x371E3B0
	public void set_PartyGameId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371E3B8 Offset: 0x371A3B8 VA: 0x371E3B8
	public int get_AppliId() { }

	[CompilerGenerated]
	// RVA: 0x371E3C0 Offset: 0x371A3C0 VA: 0x371E3C0
	public void set_AppliId(int value) { }

	[CompilerGenerated]
	// RVA: 0x371E3C8 Offset: 0x371A3C8 VA: 0x371E3C8
	public string get_AppNumber() { }

	[CompilerGenerated]
	// RVA: 0x371E3D0 Offset: 0x371A3D0 VA: 0x371E3D0
	public void set_AppNumber(string value) { }

	// RVA: 0x371E3D8 Offset: 0x371A3D8 VA: 0x371E3D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371E3E0 Offset: 0x371A3E0 VA: 0x371E3E0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371E3E8 Offset: 0x371A3E8 VA: 0x371E3E8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371E4D8 Offset: 0x371A4D8 VA: 0x371E4D8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
