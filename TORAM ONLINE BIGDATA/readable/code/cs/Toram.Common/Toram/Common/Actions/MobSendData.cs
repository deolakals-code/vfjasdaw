// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobSendData : UnityHashBase, IMobIdData // TypeDefIndex: 13177
{
	// Fields
	[CompilerGenerated]
	private int <MobId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UniqueId>k__BackingField; // 0x24
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x30

	// Properties
	[UnityHash(Code = 22)]
	public int MobId { get; set; }
	[UnityHash(Code = 23)]
	public byte LocalId { get; set; }
	[UnityHash(Code = 24)]
	public int UniqueId { get; set; }
	[UnityHash(Code = 10)]
	public short[] Position { get; set; }
	[UnityHash(Code = 11)]
	public short Rotation { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36BF704 Offset: 0x36BB704 VA: 0x36BF704
	public void .ctor() { }

	// RVA: 0x36B94F0 Offset: 0x36B54F0 VA: 0x36B94F0
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36BF70C Offset: 0x36BB70C VA: 0x36BF70C
	public void .ctor(int mobId, byte localId, int uniqueId, short[] position, short rotation) { }

	[CompilerGenerated]
	// RVA: 0x36BF770 Offset: 0x36BB770 VA: 0x36BF770 Slot: 7
	public int get_MobId() { }

	[CompilerGenerated]
	// RVA: 0x36BF778 Offset: 0x36BB778 VA: 0x36BF778
	public void set_MobId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36BF780 Offset: 0x36BB780 VA: 0x36BF780 Slot: 8
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36BF788 Offset: 0x36BB788 VA: 0x36BF788
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BF790 Offset: 0x36BB790 VA: 0x36BF790 Slot: 9
	public int get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x36BF798 Offset: 0x36BB798 VA: 0x36BF798
	public void set_UniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36BF7A0 Offset: 0x36BB7A0 VA: 0x36BF7A0
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36BF7A8 Offset: 0x36BB7A8 VA: 0x36BF7A8
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36BF7B0 Offset: 0x36BB7B0 VA: 0x36BF7B0
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36BF7B8 Offset: 0x36BB7B8 VA: 0x36BF7B8
	public void set_Rotation(short value) { }

	// RVA: 0x36BF7C0 Offset: 0x36BB7C0 VA: 0x36BF7C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x36BF898 Offset: 0x36BB898 VA: 0x36BF898 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36BF8A0 Offset: 0x36BB8A0 VA: 0x36BF8A0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36BFBA4 Offset: 0x36BBBA4 VA: 0x36BFBA4 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
