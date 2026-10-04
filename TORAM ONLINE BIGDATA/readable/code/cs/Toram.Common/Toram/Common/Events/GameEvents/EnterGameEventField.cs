// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents
public class EnterGameEventField : PacketBase // TypeDefIndex: 12681
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <EventType>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte[] <EventData>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 245)]
	public byte EventType { get; set; }
	[PacketParameter(Code = 199, IsOptional = True)]
	public byte[] EventData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3640C38 Offset: 0x363CC38 VA: 0x3640C38
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3640C40 Offset: 0x363CC40 VA: 0x3640C40
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3640C48 Offset: 0x363CC48 VA: 0x3640C48
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3640C50 Offset: 0x363CC50 VA: 0x3640C50
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x3640C58 Offset: 0x363CC58 VA: 0x3640C58
	public void set_EventType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3640C60 Offset: 0x363CC60 VA: 0x3640C60
	public byte[] get_EventData() { }

	[CompilerGenerated]
	// RVA: 0x3640C68 Offset: 0x363CC68 VA: 0x3640C68
	public void set_EventData(byte[] value) { }

	// RVA: 0x3640C70 Offset: 0x363CC70 VA: 0x3640C70 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3640C78 Offset: 0x363CC78 VA: 0x3640C78 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3640E80 Offset: 0x363CE80 VA: 0x3640E80 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
