// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Contents.Moba
public class MobaBattleRecordData : BinaryBase // TypeDefIndex: 11206
{
	// Fields
	[CompilerGenerated]
	private Dictionary<int, byte[]> <Participants>k__BackingField; // 0x20
	[CompilerGenerated]
	private int[] <RoundResults>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Win>k__BackingField; // 0x30

	// Properties
	public Dictionary<int, byte[]> Participants { get; set; }
	public int[] RoundResults { get; set; }
	public int Win { get; set; }

	// Methods

	// RVA: 0x35D9400 Offset: 0x35D5400 VA: 0x35D9400
	public void .ctor() { }

	// RVA: 0x35D9408 Offset: 0x35D5408 VA: 0x35D9408
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35D9410 Offset: 0x35D5410 VA: 0x35D9410
	public Dictionary<int, byte[]> get_Participants() { }

	[CompilerGenerated]
	// RVA: 0x35D9418 Offset: 0x35D5418 VA: 0x35D9418
	protected void set_Participants(Dictionary<int, byte[]> value) { }

	[CompilerGenerated]
	// RVA: 0x35D9420 Offset: 0x35D5420 VA: 0x35D9420
	public int[] get_RoundResults() { }

	[CompilerGenerated]
	// RVA: 0x35D9428 Offset: 0x35D5428 VA: 0x35D9428
	protected void set_RoundResults(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x35D9430 Offset: 0x35D5430 VA: 0x35D9430
	public int get_Win() { }

	[CompilerGenerated]
	// RVA: 0x35D9438 Offset: 0x35D5438 VA: 0x35D9438
	protected void set_Win(int value) { }

	// RVA: 0x35D9440 Offset: 0x35D5440 VA: 0x35D9440 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35D962C Offset: 0x35D562C VA: 0x35D962C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
