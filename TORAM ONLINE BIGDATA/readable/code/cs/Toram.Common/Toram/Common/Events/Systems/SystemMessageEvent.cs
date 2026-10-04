// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Systems
public class SystemMessageEvent : PacketBase // TypeDefIndex: 12728
{
	// Fields
	[CompilerGenerated]
	private string <LocalizeKey>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x28

	// Properties
	public string LocalizeKey { get; set; }
	public string Message { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x364C144 Offset: 0x3648144 VA: 0x364C144
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364C14C Offset: 0x364814C VA: 0x364C14C
	public string get_LocalizeKey() { }

	[CompilerGenerated]
	// RVA: 0x364C154 Offset: 0x3648154 VA: 0x364C154
	public void set_LocalizeKey(string value) { }

	[CompilerGenerated]
	// RVA: 0x364C15C Offset: 0x364815C VA: 0x364C15C
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x364C164 Offset: 0x3648164 VA: 0x364C164
	public void set_Message(string value) { }

	// RVA: 0x364C16C Offset: 0x364816C VA: 0x364C16C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364C174 Offset: 0x3648174 VA: 0x364C174 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x364C238 Offset: 0x3648238 VA: 0x364C238 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
