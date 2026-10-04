// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.TreasureHunt
public class TreasureHuntTreasureData : UnityHashBase // TypeDefIndex: 11337
{
	// Fields
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <TreasureRank>k__BackingField; // 0x1A
	[CompilerGenerated]
	private int <UpdateTime>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short[] <Coordinate>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x28

	// Properties
	[UnityHash(Code = 200)]
	public byte LocalId { get; set; }
	[UnityHash(Code = 195)]
	public byte TreasureRank { get; set; }
	[UnityHash(Code = 172)]
	public int UpdateTime { get; set; }
	[UnityHash(Code = 54)]
	public short[] Coordinate { get; set; }
	[UnityHash(Code = 65)]
	public short Rotation { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36ED7F4 Offset: 0x36E97F4 VA: 0x36ED7F4
	public void .ctor() { }

	// RVA: 0x36ED7FC Offset: 0x36E97FC VA: 0x36ED7FC
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36ED804 Offset: 0x36E9804 VA: 0x36ED804
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36ED80C Offset: 0x36E980C VA: 0x36ED80C
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36ED814 Offset: 0x36E9814 VA: 0x36ED814
	public byte get_TreasureRank() { }

	[CompilerGenerated]
	// RVA: 0x36ED81C Offset: 0x36E981C VA: 0x36ED81C
	public void set_TreasureRank(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36ED824 Offset: 0x36E9824 VA: 0x36ED824
	public int get_UpdateTime() { }

	[CompilerGenerated]
	// RVA: 0x36ED82C Offset: 0x36E982C VA: 0x36ED82C
	public void set_UpdateTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x36ED834 Offset: 0x36E9834 VA: 0x36ED834
	public short[] get_Coordinate() { }

	[CompilerGenerated]
	// RVA: 0x36ED83C Offset: 0x36E983C VA: 0x36ED83C
	public void set_Coordinate(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36ED844 Offset: 0x36E9844 VA: 0x36ED844
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36ED84C Offset: 0x36E984C VA: 0x36ED84C
	public void set_Rotation(short value) { }

	// RVA: 0x36ED854 Offset: 0x36E9854 VA: 0x36ED854 Slot: 3
	public override string ToString() { }

	// RVA: 0x36EDB28 Offset: 0x36E9B28 VA: 0x36EDB28 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36EDB30 Offset: 0x36E9B30 VA: 0x36EDB30 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36EDD34 Offset: 0x36E9D34 VA: 0x36EDD34 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
