// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.Dungeon
public class DungeonLoginRoomData : LoginRoomDataBase // TypeDefIndex: 11315
{
	// Fields
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x21
	[CompilerGenerated]
	private byte <Rate>k__BackingField; // 0x22
	[CompilerGenerated]
	private short <AvatarLevel>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <FloorEventType>k__BackingField; // 0x26
	[CompilerGenerated]
	private int[] <LoadMobMaster>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 43, IsOptional = True)]
	public byte Flag { get; set; }
	[PacketParameter(Code = 47)]
	public byte Rate { get; set; }
	[PacketParameter(Code = 29)]
	public short AvatarLevel { get; set; }
	[PacketParameter(Code = 44)]
	public byte FloorEventType { get; set; }
	[PacketParameter(Code = 76, IsOptional = True)]
	public int[] LoadMobMaster { get; set; }

	// Methods

	// RVA: 0x36DE534 Offset: 0x36DA534 VA: 0x36DE534
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36DE53C Offset: 0x36DA53C VA: 0x36DE53C
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36DE544 Offset: 0x36DA544 VA: 0x36DE544
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36DE54C Offset: 0x36DA54C VA: 0x36DE54C
	public byte get_Rate() { }

	[CompilerGenerated]
	// RVA: 0x36DE554 Offset: 0x36DA554 VA: 0x36DE554
	public void set_Rate(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36DE55C Offset: 0x36DA55C VA: 0x36DE55C
	public short get_AvatarLevel() { }

	[CompilerGenerated]
	// RVA: 0x36DE564 Offset: 0x36DA564 VA: 0x36DE564
	public void set_AvatarLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x36DE56C Offset: 0x36DA56C VA: 0x36DE56C
	public byte get_FloorEventType() { }

	[CompilerGenerated]
	// RVA: 0x36DE574 Offset: 0x36DA574 VA: 0x36DE574
	public void set_FloorEventType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36DE57C Offset: 0x36DA57C VA: 0x36DE57C
	public int[] get_LoadMobMaster() { }

	[CompilerGenerated]
	// RVA: 0x36DE584 Offset: 0x36DA584 VA: 0x36DE584
	public void set_LoadMobMaster(int[] value) { }

	// RVA: 0x36DE58C Offset: 0x36DA58C VA: 0x36DE58C
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36DE590 Offset: 0x36DA590 VA: 0x36DE590
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36DE594 Offset: 0x36DA594 VA: 0x36DE594 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36DE900 Offset: 0x36DA900 VA: 0x36DE900 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
