// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Systems
public class UserWatchEvent : PacketBase // TypeDefIndex: 12733
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsLogout>k__BackingField; // 0x24
	[CompilerGenerated]
	private TouchData[] <Touches>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 43, IsOptional = True)]
	public bool IsLogout { get; set; }
	[PacketParameter(Code = 213, IsOptional = True)]
	public TouchData[] Touches { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x364CE14 Offset: 0x3648E14 VA: 0x364CE14
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364CE1C Offset: 0x3648E1C VA: 0x364CE1C
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x364CE24 Offset: 0x3648E24 VA: 0x364CE24
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x364CE2C Offset: 0x3648E2C VA: 0x364CE2C
	public bool get_IsLogout() { }

	[CompilerGenerated]
	// RVA: 0x364CE34 Offset: 0x3648E34 VA: 0x364CE34
	public void set_IsLogout(bool value) { }

	[CompilerGenerated]
	// RVA: 0x364CE40 Offset: 0x3648E40 VA: 0x364CE40
	public TouchData[] get_Touches() { }

	[CompilerGenerated]
	// RVA: 0x364CE48 Offset: 0x3648E48 VA: 0x364CE48
	public void set_Touches(TouchData[] value) { }

	// RVA: 0x364CE50 Offset: 0x3648E50 VA: 0x364CE50
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x364CF84 Offset: 0x3648F84 VA: 0x364CF84
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x364D048 Offset: 0x3649048 VA: 0x364D048 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364D050 Offset: 0x3649050 VA: 0x364D050 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x364D204 Offset: 0x3649204 VA: 0x364D204 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
