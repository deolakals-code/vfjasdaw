// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms
public class RoomStateData : UnityHashBase // TypeDefIndex: 11293
{
	// Fields
	[CompilerGenerated]
	private int <RoomUuid>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <StartTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<int, string> <Members>k__BackingField; // 0x30

	// Properties
	public int RoomUuid { get; set; }
	public short Level { get; set; }
	public DateTime StartTime { get; set; }
	public Dictionary<int, string> Members { get; set; }
	public override byte Code { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x36D8A24 Offset: 0x36D4A24 VA: 0x36D8A24
	public int get_RoomUuid() { }

	[CompilerGenerated]
	// RVA: 0x36D8A2C Offset: 0x36D4A2C VA: 0x36D8A2C
	private void set_RoomUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36D8A34 Offset: 0x36D4A34 VA: 0x36D8A34
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x36D8A3C Offset: 0x36D4A3C VA: 0x36D8A3C
	private void set_Level(short value) { }

	[CompilerGenerated]
	// RVA: 0x36D8A44 Offset: 0x36D4A44 VA: 0x36D8A44
	public DateTime get_StartTime() { }

	[CompilerGenerated]
	// RVA: 0x36D8A4C Offset: 0x36D4A4C VA: 0x36D8A4C
	private void set_StartTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x36D8A54 Offset: 0x36D4A54 VA: 0x36D8A54
	public Dictionary<int, string> get_Members() { }

	[CompilerGenerated]
	// RVA: 0x36D8A5C Offset: 0x36D4A5C VA: 0x36D8A5C
	public void set_Members(Dictionary<int, string> value) { }

	// RVA: 0x36D8A64 Offset: 0x36D4A64 VA: 0x36D8A64 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36D8A6C Offset: 0x36D4A6C VA: 0x36D8A6C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36D8D8C Offset: 0x36D4D8C VA: 0x36D8D8C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
