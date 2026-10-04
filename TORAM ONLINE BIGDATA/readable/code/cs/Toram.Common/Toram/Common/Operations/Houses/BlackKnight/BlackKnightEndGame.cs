// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.BlackKnight
public class BlackKnightEndGame : OperationRequestBase // TypeDefIndex: 12240
{
	// Fields
	[CompilerGenerated]
	private byte <EndType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Score>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <Time>k__BackingField; // 0x30

	// Properties
	public byte EndType { get; set; }
	public int Score { get; set; }
	public int Gold { get; set; }
	public DateTime Time { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E5CD0 Offset: 0x35E1CD0 VA: 0x35E5CD0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E5CD8 Offset: 0x35E1CD8 VA: 0x35E5CD8
	public byte get_EndType() { }

	[CompilerGenerated]
	// RVA: 0x35E5CE0 Offset: 0x35E1CE0 VA: 0x35E5CE0
	public void set_EndType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35E5CE8 Offset: 0x35E1CE8 VA: 0x35E5CE8
	public int get_Score() { }

	[CompilerGenerated]
	// RVA: 0x35E5CF0 Offset: 0x35E1CF0 VA: 0x35E5CF0
	public void set_Score(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E5CF8 Offset: 0x35E1CF8 VA: 0x35E5CF8
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x35E5D00 Offset: 0x35E1D00 VA: 0x35E5D00
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E5D08 Offset: 0x35E1D08 VA: 0x35E5D08
	public DateTime get_Time() { }

	[CompilerGenerated]
	// RVA: 0x35E5D10 Offset: 0x35E1D10 VA: 0x35E5D10
	public void set_Time(DateTime value) { }

	// RVA: 0x35E5D18 Offset: 0x35E1D18 VA: 0x35E5D18 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E5D20 Offset: 0x35E1D20 VA: 0x35E5D20 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E5D28 Offset: 0x35E1D28 VA: 0x35E5D28 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35E5EB4 Offset: 0x35E1EB4 VA: 0x35E5EB4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
