// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class CustomerConnectEvent : PacketBase // TypeDefIndex: 12624
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3633A24 Offset: 0x362FA24 VA: 0x3633A24
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3633A2C Offset: 0x362FA2C VA: 0x3633A2C
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3633A34 Offset: 0x362FA34 VA: 0x3633A34
	public void set_AvatarUuid(int value) { }

	// RVA: 0x3633A3C Offset: 0x362FA3C VA: 0x3633A3C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3633A40 Offset: 0x362FA40 VA: 0x3633A40
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3633A44 Offset: 0x362FA44 VA: 0x3633A44 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3633A4C Offset: 0x362FA4C VA: 0x3633A4C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3633B6C Offset: 0x362FB6C VA: 0x3633B6C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
