// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents.Moba
public class MobaMemberStatusEvent : EventSubBase // TypeDefIndex: 12672
{
	// Fields
	[CompilerGenerated]
	private MobaMemberStatusData[] <Members>k__BackingField; // 0x20

	// Properties
	public MobaMemberStatusData[] Members { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363E528 Offset: 0x363A528 VA: 0x363E528
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363E530 Offset: 0x363A530 VA: 0x363E530
	public MobaMemberStatusData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x363E538 Offset: 0x363A538 VA: 0x363E538
	public void set_Members(MobaMemberStatusData[] value) { }

	// RVA: 0x363E540 Offset: 0x363A540 VA: 0x363E540 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363E548 Offset: 0x363A548 VA: 0x363E548 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363E550 Offset: 0x363A550 VA: 0x363E550 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363E5E8 Offset: 0x363A5E8 VA: 0x363E5E8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
