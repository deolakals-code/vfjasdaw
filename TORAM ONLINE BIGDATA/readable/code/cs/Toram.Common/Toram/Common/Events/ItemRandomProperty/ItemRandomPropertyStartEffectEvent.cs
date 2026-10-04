// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.ItemRandomProperty
public class ItemRandomPropertyStartEffectEvent : EventSubBase // TypeDefIndex: 12653
{
	// Fields
	[CompilerGenerated]
	private byte <EquipType>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <PropertyId>k__BackingField; // 0x22
	[CompilerGenerated]
	private short <Stack>k__BackingField; // 0x24
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x28

	// Properties
	public byte EquipType { get; set; }
	public short PropertyId { get; set; }
	public short Stack { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363A4D0 Offset: 0x36364D0 VA: 0x363A4D0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363A4D8 Offset: 0x36364D8 VA: 0x363A4D8
	public byte get_EquipType() { }

	[CompilerGenerated]
	// RVA: 0x363A4E0 Offset: 0x36364E0 VA: 0x363A4E0
	public void set_EquipType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363A4E8 Offset: 0x36364E8 VA: 0x363A4E8
	public short get_PropertyId() { }

	[CompilerGenerated]
	// RVA: 0x363A4F0 Offset: 0x36364F0 VA: 0x363A4F0
	public void set_PropertyId(short value) { }

	[CompilerGenerated]
	// RVA: 0x363A4F8 Offset: 0x36364F8 VA: 0x363A4F8
	public short get_Stack() { }

	[CompilerGenerated]
	// RVA: 0x363A500 Offset: 0x3636500 VA: 0x363A500
	public void set_Stack(short value) { }

	[CompilerGenerated]
	// RVA: 0x363A508 Offset: 0x3636508 VA: 0x363A508
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x363A510 Offset: 0x3636510 VA: 0x363A510
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x363A518 Offset: 0x3636518 VA: 0x363A518 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363A520 Offset: 0x3636520 VA: 0x363A520 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363A528 Offset: 0x3636528 VA: 0x363A528 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363A658 Offset: 0x3636658 VA: 0x363A658 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
