// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.Rhythm
public class RhythmRecordData : BinaryBase // TypeDefIndex: 12526
{
	// Fields
	[CompilerGenerated]
	private int <MusicId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Score>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x24

	// Properties
	public int MusicId { get; set; }
	public int Score { get; set; }
	public byte State { get; set; }

	// Methods

	// RVA: 0x36185BC Offset: 0x36145BC VA: 0x36185BC
	public void .ctor() { }

	// RVA: 0x36185C4 Offset: 0x36145C4 VA: 0x36185C4
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x36185CC Offset: 0x36145CC VA: 0x36185CC
	public int get_MusicId() { }

	[CompilerGenerated]
	// RVA: 0x36185D4 Offset: 0x36145D4 VA: 0x36185D4
	private void set_MusicId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36185DC Offset: 0x36145DC VA: 0x36185DC
	public int get_Score() { }

	[CompilerGenerated]
	// RVA: 0x36185E4 Offset: 0x36145E4 VA: 0x36185E4
	private void set_Score(int value) { }

	[CompilerGenerated]
	// RVA: 0x36185EC Offset: 0x36145EC VA: 0x36185EC
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x36185F4 Offset: 0x36145F4 VA: 0x36185F4
	private void set_State(byte value) { }

	// RVA: 0x36185FC Offset: 0x36145FC VA: 0x36185FC Slot: 3
	public override string ToString() { }

	// RVA: 0x36186D4 Offset: 0x36146D4 VA: 0x36186D4 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x361884C Offset: 0x361484C VA: 0x361884C Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36188D4 Offset: 0x36148D4 VA: 0x36188D4
	public static byte[] GetClearState(byte state) { }
}
