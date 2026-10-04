// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents
public class HeldGameEvent : PacketBase // TypeDefIndex: 12682
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte[] <EventType>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 245, IsOptional = True)]
	public byte[] EventType { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3640FA8 Offset: 0x363CFA8 VA: 0x3640FA8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3640FB0 Offset: 0x363CFB0 VA: 0x3640FB0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3640FB8 Offset: 0x363CFB8 VA: 0x3640FB8
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3640FC0 Offset: 0x363CFC0 VA: 0x3640FC0
	public byte[] get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x3640FC8 Offset: 0x363CFC8 VA: 0x3640FC8
	public void set_EventType(byte[] value) { }

	// RVA: 0x3640FD0 Offset: 0x363CFD0 VA: 0x3640FD0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3640FD8 Offset: 0x363CFD8 VA: 0x3640FD8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3641188 Offset: 0x363D188 VA: 0x3641188 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
