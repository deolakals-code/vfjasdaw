// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Contents.Moba
public class MobaPhaseData : BinaryBase // TypeDefIndex: 11224
{
	// Fields
	[CompilerGenerated]
	private byte <GamePhase>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <PhaseTimeLeft>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <GameTimeLeft>k__BackingField; // 0x20

	// Properties
	public byte GamePhase { get; set; }
	public int PhaseTimeLeft { get; set; }
	public int GameTimeLeft { get; set; }

	// Methods

	// RVA: 0x36CAA00 Offset: 0x36C6A00 VA: 0x36CAA00
	public void .ctor() { }

	// RVA: 0x36CAA08 Offset: 0x36C6A08 VA: 0x36CAA08
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x36CAA10 Offset: 0x36C6A10 VA: 0x36CAA10
	public byte get_GamePhase() { }

	[CompilerGenerated]
	// RVA: 0x36CAA18 Offset: 0x36C6A18 VA: 0x36CAA18
	public void set_GamePhase(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36CAA20 Offset: 0x36C6A20 VA: 0x36CAA20
	public int get_PhaseTimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x36CAA28 Offset: 0x36C6A28 VA: 0x36CAA28
	public void set_PhaseTimeLeft(int value) { }

	[CompilerGenerated]
	// RVA: 0x36CAA30 Offset: 0x36C6A30 VA: 0x36CAA30
	public int get_GameTimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x36CAA38 Offset: 0x36C6A38 VA: 0x36CAA38
	public void set_GameTimeLeft(int value) { }

	// RVA: 0x36CAA40 Offset: 0x36C6A40 VA: 0x36CAA40 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36CAA8C Offset: 0x36C6A8C VA: 0x36CAA8C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
