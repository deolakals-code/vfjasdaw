// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class DropData : BinaryBase // TypeDefIndex: 13152
{
	// Fields
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <Rare>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsAutoDiscard>k__BackingField; // 0x21

	// Properties
	[BinaryParameter]
	public int ItemId { get; set; }
	[BinaryParameter]
	public byte Rare { get; set; }
	public bool IsAutoDiscard { get; set; }

	// Methods

	// RVA: 0x36B6938 Offset: 0x36B2938 VA: 0x36B6938
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36B6940 Offset: 0x36B2940 VA: 0x36B6940
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x36B6948 Offset: 0x36B2948 VA: 0x36B6948
	protected void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36B6950 Offset: 0x36B2950 VA: 0x36B6950
	public byte get_Rare() { }

	[CompilerGenerated]
	// RVA: 0x36B6958 Offset: 0x36B2958 VA: 0x36B6958
	protected void set_Rare(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B6960 Offset: 0x36B2960 VA: 0x36B6960
	public bool get_IsAutoDiscard() { }

	[CompilerGenerated]
	// RVA: 0x36B6968 Offset: 0x36B2968 VA: 0x36B6968
	private void set_IsAutoDiscard(bool value) { }

	// RVA: 0x36B6974 Offset: 0x36B2974 VA: 0x36B6974 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36B6A98 Offset: 0x36B2A98 VA: 0x36B6A98 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
