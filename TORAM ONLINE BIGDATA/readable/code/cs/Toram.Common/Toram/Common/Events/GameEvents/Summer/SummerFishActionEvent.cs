// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents.Summer
public class SummerFishActionEvent : EventSubBase // TypeDefIndex: 12700
{
	// Fields
	[CompilerGenerated]
	private MobData[] <FishList>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public MobData[] FishList { get; set; }

	// Methods

	// RVA: 0x364467C Offset: 0x364067C VA: 0x364467C
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3644684 Offset: 0x3640684 VA: 0x3644684 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364468C Offset: 0x364068C VA: 0x364468C Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3644694 Offset: 0x3640694 VA: 0x3644694
	public MobData[] get_FishList() { }

	[CompilerGenerated]
	// RVA: 0x364469C Offset: 0x364069C VA: 0x364469C
	public void set_FishList(MobData[] value) { }

	// RVA: 0x36446A4 Offset: 0x36406A4 VA: 0x36446A4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3644824 Offset: 0x3640824 VA: 0x3644824 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
