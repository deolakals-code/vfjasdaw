// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room
public class RoomMonsterManageHateStateEvent : EventSubBase // TypeDefIndex: 12740
{
	// Fields
	[CompilerGenerated]
	private Dictionary<MobIdData, MobHateData> <ManageHateList>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 15, IsOptional = True)]
	public Dictionary<MobIdData, MobHateData> ManageHateList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x364E284 Offset: 0x364A284 VA: 0x364E284
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364E28C Offset: 0x364A28C VA: 0x364E28C
	public Dictionary<MobIdData, MobHateData> get_ManageHateList() { }

	[CompilerGenerated]
	// RVA: 0x364E294 Offset: 0x364A294 VA: 0x364E294
	public void set_ManageHateList(Dictionary<MobIdData, MobHateData> value) { }

	// RVA: 0x364E29C Offset: 0x364A29C VA: 0x364E29C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364E2A4 Offset: 0x364A2A4 VA: 0x364E2A4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x364E2AC Offset: 0x364A2AC VA: 0x364E2AC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x364E5A8 Offset: 0x364A5A8 VA: 0x364E5A8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
