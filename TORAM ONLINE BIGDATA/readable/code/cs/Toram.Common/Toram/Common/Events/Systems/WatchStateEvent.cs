// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Systems
public class WatchStateEvent : PacketBase // TypeDefIndex: 12734
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsWatch>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 43)]
	public bool IsWatch { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x364D328 Offset: 0x3649328 VA: 0x364D328
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364D330 Offset: 0x3649330 VA: 0x364D330
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x364D338 Offset: 0x3649338 VA: 0x364D338
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x364D340 Offset: 0x3649340 VA: 0x364D340
	public bool get_IsWatch() { }

	[CompilerGenerated]
	// RVA: 0x364D348 Offset: 0x3649348 VA: 0x364D348
	public void set_IsWatch(bool value) { }

	// RVA: 0x364D354 Offset: 0x3649354 VA: 0x364D354 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364D35C Offset: 0x364935C VA: 0x364D35C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x364D4D4 Offset: 0x36494D4 VA: 0x364D4D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
