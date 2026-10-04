// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Orbs
public class ExpPotionLevelupEvent : PacketBase // TypeDefIndex: 12647
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <PotionLevel>k__BackingField; // 0x24

	// Properties
	public int AvatarUuid { get; set; }
	public short PotionLevel { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3638FA4 Offset: 0x3634FA4 VA: 0x3638FA4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3638FAC Offset: 0x3634FAC VA: 0x3638FAC
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3638FB4 Offset: 0x3634FB4 VA: 0x3638FB4
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3638FBC Offset: 0x3634FBC VA: 0x3638FBC
	public short get_PotionLevel() { }

	[CompilerGenerated]
	// RVA: 0x3638FC4 Offset: 0x3634FC4 VA: 0x3638FC4
	public void set_PotionLevel(short value) { }

	// RVA: 0x3638FCC Offset: 0x3634FCC VA: 0x3638FCC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3638FD4 Offset: 0x3634FD4 VA: 0x3638FD4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x363914C Offset: 0x363514C VA: 0x363914C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
