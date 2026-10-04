// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room
public class RoomManagedMonsterEvent : PacketBase // TypeDefIndex: 12751
{
	// Fields
	[CompilerGenerated]
	private MobData[] <MobList>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 89, IsOptional = True)]
	public MobData[] MobList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x365095C Offset: 0x364C95C VA: 0x365095C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3650964 Offset: 0x364C964 VA: 0x3650964
	public MobData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x365096C Offset: 0x364C96C VA: 0x365096C
	public void set_MobList(MobData[] value) { }

	// RVA: 0x3650974 Offset: 0x364C974 VA: 0x3650974
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3650A74 Offset: 0x364CA74 VA: 0x3650A74
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3650B00 Offset: 0x364CB00 VA: 0x3650B00 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3650B08 Offset: 0x364CB08 VA: 0x3650B08 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3650BA0 Offset: 0x364CBA0 VA: 0x3650BA0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
