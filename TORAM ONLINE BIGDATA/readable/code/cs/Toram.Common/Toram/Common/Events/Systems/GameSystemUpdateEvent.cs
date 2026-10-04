// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Systems
public class GameSystemUpdateEvent : PacketBase // TypeDefIndex: 12730
{
	// Fields
	[CompilerGenerated]
	private GameSystemFlagData[] <SystemFlags>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 213, IsOptional = True)]
	public GameSystemFlagData[] SystemFlags { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x364C688 Offset: 0x3648688 VA: 0x364C688
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364C690 Offset: 0x3648690 VA: 0x364C690
	public GameSystemFlagData[] get_SystemFlags() { }

	[CompilerGenerated]
	// RVA: 0x364C698 Offset: 0x3648698 VA: 0x364C698
	public void set_SystemFlags(GameSystemFlagData[] value) { }

	// RVA: 0x364C6A0 Offset: 0x36486A0 VA: 0x364C6A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364C6A8 Offset: 0x36486A8 VA: 0x364C6A8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x364C820 Offset: 0x3648820 VA: 0x364C820 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
