// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents.Moba
public class MobaMemberStateEvent : EventSubBase // TypeDefIndex: 12671
{
	// Fields
	[CompilerGenerated]
	private MobaMemberData[] <Members>k__BackingField; // 0x20

	// Properties
	public MobaMemberData[] Members { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363E2F0 Offset: 0x363A2F0 VA: 0x363E2F0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363E2F8 Offset: 0x363A2F8 VA: 0x363E2F8
	public MobaMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x363E300 Offset: 0x363A300 VA: 0x363E300
	public void set_Members(MobaMemberData[] value) { }

	// RVA: 0x363E308 Offset: 0x363A308 VA: 0x363E308 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363E310 Offset: 0x363A310 VA: 0x363E310 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363E318 Offset: 0x363A318 VA: 0x363E318 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363E3B0 Offset: 0x363A3B0 VA: 0x363E3B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
