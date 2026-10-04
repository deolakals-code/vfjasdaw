// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room
public class RoomSynchronizationEvent : EventSubBase // TypeDefIndex: 12745
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <RoomType>k__BackingField; // 0x24
	[CompilerGenerated]
	private RoomSetting <RoomSetting>k__BackingField; // 0x28
	[CompilerGenerated]
	private RoomSyncDataBase <SyncData>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 105)]
	public byte RoomType { get; set; }
	[PacketParameter(Code = 187)]
	public RoomSetting RoomSetting { get; set; }
	[PacketClass(Code = 199, IsOptional = True)]
	public RoomSyncDataBase SyncData { get; set; }

	// Methods

	// RVA: 0x364F49C Offset: 0x364B49C VA: 0x364F49C
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x364F4A4 Offset: 0x364B4A4 VA: 0x364F4A4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364F4AC Offset: 0x364B4AC VA: 0x364F4AC Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x364F4B4 Offset: 0x364B4B4 VA: 0x364F4B4
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x364F4BC Offset: 0x364B4BC VA: 0x364F4BC
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x364F4C4 Offset: 0x364B4C4 VA: 0x364F4C4
	public byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x364F4CC Offset: 0x364B4CC VA: 0x364F4CC
	public void set_RoomType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x364F4D4 Offset: 0x364B4D4 VA: 0x364F4D4
	public RoomSetting get_RoomSetting() { }

	[CompilerGenerated]
	// RVA: 0x364F4DC Offset: 0x364B4DC VA: 0x364F4DC
	public void set_RoomSetting(RoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x364F4E4 Offset: 0x364B4E4 VA: 0x364F4E4
	public RoomSyncDataBase get_SyncData() { }

	[CompilerGenerated]
	// RVA: 0x364F4EC Offset: 0x364B4EC VA: 0x364F4EC
	public void set_SyncData(RoomSyncDataBase value) { }

	// RVA: 0x364F4F4 Offset: 0x364B4F4 VA: 0x364F4F4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x364F960 Offset: 0x364B960 VA: 0x364F960
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x364FA08 Offset: 0x364BA08 VA: 0x364FA08 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x364FB90 Offset: 0x364BB90 VA: 0x364FB90 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
