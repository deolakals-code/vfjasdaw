// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room
public class RoomBattleStartEvent : PacketBase // TypeDefIndex: 12750
{
	// Fields
	[CompilerGenerated]
	private int[] <SupportList>k__BackingField; // 0x20
	[CompilerGenerated]
	private int[] <TargetUniqueIds>k__BackingField; // 0x28

	// Properties
	public int[] SupportList { get; set; }
	public int[] TargetUniqueIds { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3650690 Offset: 0x364C690 VA: 0x3650690
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3650698 Offset: 0x364C698 VA: 0x3650698
	public int[] get_SupportList() { }

	[CompilerGenerated]
	// RVA: 0x36506A0 Offset: 0x364C6A0 VA: 0x36506A0
	public void set_SupportList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x36506A8 Offset: 0x364C6A8 VA: 0x36506A8
	public int[] get_TargetUniqueIds() { }

	[CompilerGenerated]
	// RVA: 0x36506B0 Offset: 0x364C6B0 VA: 0x36506B0
	public void set_TargetUniqueIds(int[] value) { }

	// RVA: 0x36506B8 Offset: 0x364C6B8 VA: 0x36506B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36506C0 Offset: 0x364C6C0 VA: 0x36506C0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3650898 Offset: 0x364C898 VA: 0x3650898 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
