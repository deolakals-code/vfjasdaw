// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobIdData : UnityHashBase, IMobIdData // TypeDefIndex: 13173
{
	// Fields
	[CompilerGenerated]
	private int <MobId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UniqueId>k__BackingField; // 0x24

	// Properties
	[UnityHash(Code = 22)]
	public int MobId { get; set; }
	[UnityHash(Code = 23)]
	public byte LocalId { get; set; }
	[UnityHash(Code = 24)]
	public int UniqueId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36BD3BC Offset: 0x36B93BC VA: 0x36BD3BC
	public void .ctor() { }

	// RVA: 0x36BD3C4 Offset: 0x36B93C4 VA: 0x36BD3C4
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36BD3CC Offset: 0x36B93CC VA: 0x36BD3CC
	public void .ctor(int mobId, byte localId, int uniqueId) { }

	[CompilerGenerated]
	// RVA: 0x36BD40C Offset: 0x36B940C VA: 0x36BD40C Slot: 7
	public int get_MobId() { }

	[CompilerGenerated]
	// RVA: 0x36BD414 Offset: 0x36B9414 VA: 0x36BD414
	public void set_MobId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36BD41C Offset: 0x36B941C VA: 0x36BD41C Slot: 8
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36BD424 Offset: 0x36B9424 VA: 0x36BD424
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BD42C Offset: 0x36B942C VA: 0x36BD42C Slot: 9
	public int get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x36BD434 Offset: 0x36B9434 VA: 0x36BD434
	public void set_UniqueId(int value) { }

	// RVA: 0x36BD43C Offset: 0x36B943C VA: 0x36BD43C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36BD444 Offset: 0x36B9444 VA: 0x36BD444 Slot: 3
	public override string ToString() { }

	// RVA: 0x36BD51C Offset: 0x36B951C VA: 0x36BD51C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36BD72C Offset: 0x36B972C VA: 0x36BD72C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
