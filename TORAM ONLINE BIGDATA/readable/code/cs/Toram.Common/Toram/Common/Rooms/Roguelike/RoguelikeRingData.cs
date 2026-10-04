// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.Roguelike
public class RoguelikeRingData : BinaryBase // TypeDefIndex: 11348
{
	// Fields
	[CompilerGenerated]
	private long <Uuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <RingNo>k__BackingField; // 0x28
	[CompilerGenerated]
	private short[] <CapId>k__BackingField; // 0x30
	[CompilerGenerated]
	private short[] <CapVal>k__BackingField; // 0x38

	// Properties
	public long Uuid { get; set; }
	public short RingNo { get; set; }
	public short[] CapId { get; set; }
	public short[] CapVal { get; set; }

	// Methods

	// RVA: 0x36F0788 Offset: 0x36EC788 VA: 0x36F0788
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36F0808 Offset: 0x36EC808 VA: 0x36F0808
	public long get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x36F0810 Offset: 0x36EC810 VA: 0x36F0810
	public void set_Uuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x36F0818 Offset: 0x36EC818 VA: 0x36F0818
	public short get_RingNo() { }

	[CompilerGenerated]
	// RVA: 0x36F0820 Offset: 0x36EC820 VA: 0x36F0820
	public void set_RingNo(short value) { }

	[CompilerGenerated]
	// RVA: 0x36F0828 Offset: 0x36EC828 VA: 0x36F0828
	public short[] get_CapId() { }

	[CompilerGenerated]
	// RVA: 0x36F0830 Offset: 0x36EC830 VA: 0x36F0830
	public void set_CapId(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F0838 Offset: 0x36EC838 VA: 0x36F0838
	public short[] get_CapVal() { }

	[CompilerGenerated]
	// RVA: 0x36F0840 Offset: 0x36EC840 VA: 0x36F0840
	public void set_CapVal(short[] value) { }

	// RVA: 0x36F0848 Offset: 0x36EC848 VA: 0x36F0848 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36F0A58 Offset: 0x36ECA58 VA: 0x36F0A58 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
