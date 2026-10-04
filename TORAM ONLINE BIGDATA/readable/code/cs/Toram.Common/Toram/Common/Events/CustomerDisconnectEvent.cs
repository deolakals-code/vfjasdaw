// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class CustomerDisconnectEvent : PacketBase // TypeDefIndex: 12637
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3636E7C Offset: 0x3632E7C VA: 0x3636E7C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3636E84 Offset: 0x3632E84 VA: 0x3636E84
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3636E8C Offset: 0x3632E8C VA: 0x3636E8C
	public void set_AvatarUuid(int value) { }

	// RVA: 0x3636E94 Offset: 0x3632E94 VA: 0x3636E94
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3636E98 Offset: 0x3632E98 VA: 0x3636E98
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3636E9C Offset: 0x3632E9C VA: 0x3636E9C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3636EA4 Offset: 0x3632EA4 VA: 0x3636EA4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3636FC4 Offset: 0x3632FC4 VA: 0x3636FC4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
