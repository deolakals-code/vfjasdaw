// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Systems
public class ServerSettingEvent : PacketBase // TypeDefIndex: 12727
{
	// Fields
	[CompilerGenerated]
	private string <CustomerPlatform>k__BackingField; // 0x20

	// Properties
	public string CustomerPlatform { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x364BF30 Offset: 0x3647F30 VA: 0x364BF30
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364BF38 Offset: 0x3647F38 VA: 0x364BF38
	public string get_CustomerPlatform() { }

	[CompilerGenerated]
	// RVA: 0x364BF40 Offset: 0x3647F40 VA: 0x364BF40
	public void set_CustomerPlatform(string value) { }

	// RVA: 0x364BF48 Offset: 0x3647F48 VA: 0x364BF48 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364BF50 Offset: 0x3647F50 VA: 0x364BF50 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x364BFF8 Offset: 0x3647FF8 VA: 0x364BFF8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
