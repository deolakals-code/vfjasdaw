// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House
public class HousePartitionEditData : UnityHashBase // TypeDefIndex: 12518
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x19
	[CompilerGenerated]
	private int[] <AddList>k__BackingField; // 0x20
	[CompilerGenerated]
	private int[] <RemoveList>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 245)]
	public byte Type { get; set; }
	[UnityHash(Code = 213, IsOptional = True)]
	public int[] AddList { get; set; }
	[UnityHash(Code = 227, IsOptional = True)]
	public int[] RemoveList { get; set; }

	// Methods

	// RVA: 0x3615850 Offset: 0x3611850 VA: 0x3615850
	public void .ctor() { }

	// RVA: 0x3615858 Offset: 0x3611858 VA: 0x3615858 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3615860 Offset: 0x3611860 VA: 0x3615860
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3615868 Offset: 0x3611868 VA: 0x3615868
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3615870 Offset: 0x3611870 VA: 0x3615870
	public int[] get_AddList() { }

	[CompilerGenerated]
	// RVA: 0x3615878 Offset: 0x3611878 VA: 0x3615878
	public void set_AddList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3615880 Offset: 0x3611880 VA: 0x3615880
	public int[] get_RemoveList() { }

	[CompilerGenerated]
	// RVA: 0x3615888 Offset: 0x3611888 VA: 0x3615888
	public void set_RemoveList(int[] value) { }

	// RVA: 0x3615890 Offset: 0x3611890 VA: 0x3615890 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x3615B3C Offset: 0x3611B3C VA: 0x3615B3C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
