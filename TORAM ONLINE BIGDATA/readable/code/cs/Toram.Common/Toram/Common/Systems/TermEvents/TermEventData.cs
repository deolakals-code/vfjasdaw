// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Systems.TermEvents
public abstract class TermEventData : BinaryBase // TypeDefIndex: 11256
{
	// Fields
	[CompilerGenerated]
	private byte <EventNo>k__BackingField; // 0x19
	[CompilerGenerated]
	private DateTime <StartDate>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <EndDate>k__BackingField; // 0x28

	// Properties
	public byte EventNo { get; set; }
	public abstract int EventId { get; }
	private DateTime StartDate { get; set; }
	private DateTime EndDate { get; set; }

	// Methods

	// RVA: 0x36D034C Offset: 0x36CC34C VA: 0x36D034C
	protected void .ctor() { }

	// RVA: 0x36D0178 Offset: 0x36CC178 VA: 0x36D0178
	protected void .ctor(MemoryStream ms) { }

	[CompilerGenerated]
	// RVA: 0x36D0354 Offset: 0x36CC354 VA: 0x36D0354
	public byte get_EventNo() { }

	[CompilerGenerated]
	// RVA: 0x36D035C Offset: 0x36CC35C VA: 0x36D035C
	public void set_EventNo(byte value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_EventId();

	[CompilerGenerated]
	// RVA: 0x36D0364 Offset: 0x36CC364 VA: 0x36D0364
	private DateTime get_StartDate() { }

	[CompilerGenerated]
	// RVA: 0x36D036C Offset: 0x36CC36C VA: 0x36D036C
	private void set_StartDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x36D0374 Offset: 0x36CC374 VA: 0x36D0374
	private DateTime get_EndDate() { }

	[CompilerGenerated]
	// RVA: 0x36D037C Offset: 0x36CC37C VA: 0x36D037C
	private void set_EndDate(DateTime value) { }

	// RVA: 0x36D0384 Offset: 0x36CC384 VA: 0x36D0384
	public static byte[] GetListBinary(TermEventData[] list) { }

	// RVA: 0x36D0458 Offset: 0x36CC458 VA: 0x36D0458
	public byte[] GetBytes() { }

	// RVA: 0x36D04DC Offset: 0x36CC4DC VA: 0x36D04DC
	public static TermEventData[] CreateList(byte[] data) { }

	// RVA: 0x36D0608 Offset: 0x36CC608 VA: 0x36D0608
	public static TermEventData Create(byte[] data) { }

	// RVA: 0x36D06C8 Offset: 0x36CC6C8 VA: 0x36D06C8 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D07B4 Offset: 0x36CC7B4 VA: 0x36D07B4 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void GetBinaryParams(MemoryStream ms);

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void SetValueParams(MemoryStream ms);
}
