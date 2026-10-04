// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room
public class RoomArchetypeManagedEvent : PacketBase // TypeDefIndex: 12748
{
	// Fields
	[CompilerGenerated]
	private int[] <NpcList>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 143, IsOptional = True)]
	public int[] NpcList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3650194 Offset: 0x364C194 VA: 0x3650194
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365019C Offset: 0x364C19C VA: 0x365019C
	public int[] get_NpcList() { }

	[CompilerGenerated]
	// RVA: 0x36501A4 Offset: 0x364C1A4 VA: 0x36501A4
	public void set_NpcList(int[] value) { }

	// RVA: 0x36501AC Offset: 0x364C1AC VA: 0x36501AC
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36501B0 Offset: 0x364C1B0 VA: 0x36501B0
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36501B4 Offset: 0x364C1B4 VA: 0x36501B4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36501BC Offset: 0x364C1BC VA: 0x36501BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3650314 Offset: 0x364C314 VA: 0x3650314 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
