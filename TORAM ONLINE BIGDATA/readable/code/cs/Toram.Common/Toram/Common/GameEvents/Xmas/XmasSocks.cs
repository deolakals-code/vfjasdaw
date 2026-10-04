// Assembly: Toram.Common.dll
// Namespace: Toram.Common.GameEvents.Xmas
public class XmasSocks : BinaryBase // TypeDefIndex: 11182
{
	// Fields
	[CompilerGenerated]
	private byte <Id>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x1A
	[CompilerGenerated]
	private DateTime <Date>k__BackingField; // 0x20

	// Properties
	[BinaryParameter]
	public byte Id { get; set; }
	[BinaryParameter]
	public byte State { get; set; }
	[BinaryParameter]
	public DateTime Date { get; set; }

	// Methods

	// RVA: 0x35D34F0 Offset: 0x35CF4F0 VA: 0x35D34F0
	public void .ctor(byte[] binary) { }

	// RVA: 0x35D34F8 Offset: 0x35CF4F8 VA: 0x35D34F8
	public void .ctor(MemoryStream ms) { }

	[CompilerGenerated]
	// RVA: 0x35D3500 Offset: 0x35CF500 VA: 0x35D3500
	public byte get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35D3508 Offset: 0x35CF508 VA: 0x35D3508
	public void set_Id(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D3510 Offset: 0x35CF510 VA: 0x35D3510
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x35D3518 Offset: 0x35CF518 VA: 0x35D3518
	public void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D3520 Offset: 0x35CF520 VA: 0x35D3520
	public DateTime get_Date() { }

	[CompilerGenerated]
	// RVA: 0x35D3528 Offset: 0x35CF528 VA: 0x35D3528
	public void set_Date(DateTime value) { }

	// RVA: 0x35D3530 Offset: 0x35CF530 VA: 0x35D3530 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35D3674 Offset: 0x35CF674 VA: 0x35D3674 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
