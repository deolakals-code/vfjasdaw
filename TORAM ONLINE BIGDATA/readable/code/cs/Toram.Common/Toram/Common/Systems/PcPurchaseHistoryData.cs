// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Systems
public class PcPurchaseHistoryData : BinaryBase // TypeDefIndex: 11249
{
	// Fields
	[CompilerGenerated]
	private uint <HistoryId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsSubscribe>k__BackingField; // 0x24

	// Properties
	[CLSCompliant(False)]
	public uint HistoryId { get; set; }
	public int AvatarUuid { get; set; }
	public bool IsSubscribe { get; set; }

	// Methods

	// RVA: 0x36CF4E0 Offset: 0x36CB4E0 VA: 0x36CF4E0
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x36CF4E8 Offset: 0x36CB4E8 VA: 0x36CF4E8
	public uint get_HistoryId() { }

	[CompilerGenerated]
	// RVA: 0x36CF4F0 Offset: 0x36CB4F0 VA: 0x36CF4F0
	public void set_HistoryId(uint value) { }

	[CompilerGenerated]
	// RVA: 0x36CF4F8 Offset: 0x36CB4F8 VA: 0x36CF4F8
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x36CF500 Offset: 0x36CB500 VA: 0x36CF500
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36CF508 Offset: 0x36CB508 VA: 0x36CF508
	public bool get_IsSubscribe() { }

	[CompilerGenerated]
	// RVA: 0x36CF510 Offset: 0x36CB510 VA: 0x36CF510
	public void set_IsSubscribe(bool value) { }

	// RVA: 0x36CF51C Offset: 0x36CB51C VA: 0x36CF51C Slot: 3
	public override string ToString() { }

	// RVA: 0x36CF5D8 Offset: 0x36CB5D8 VA: 0x36CF5D8 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36CF624 Offset: 0x36CB624 VA: 0x36CF624 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
