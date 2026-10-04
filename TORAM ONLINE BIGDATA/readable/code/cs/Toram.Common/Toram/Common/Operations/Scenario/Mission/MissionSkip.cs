// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Mission
public class MissionSkip : OperationBase // TypeDefIndex: 11424
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <MissionId>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 154)]
	public int MissionId { get; set; }

	// Methods

	// RVA: 0x37062D4 Offset: 0x37022D4 VA: 0x37062D4
	public void .ctor() { }

	// RVA: 0x37062DC Offset: 0x37022DC VA: 0x37062DC Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x37062E4 Offset: 0x37022E4 VA: 0x37062E4
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37062EC Offset: 0x37022EC VA: 0x37062EC
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37062F4 Offset: 0x37022F4 VA: 0x37062F4
	public int get_MissionId() { }

	[CompilerGenerated]
	// RVA: 0x37062FC Offset: 0x37022FC VA: 0x37062FC
	public void set_MissionId(int value) { }

	// RVA: 0x3706304 Offset: 0x3702304 VA: 0x3706304 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3706484 Offset: 0x3702484 VA: 0x3706484 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
