// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class BonusDurationEventResponseData : PacketBase // TypeDefIndex: 12602
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <DurationBonusType>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <BonusType>k__BackingField; // 0x29
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <HpHeal>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <MpHeal>k__BackingField; // 0x3C

	// Properties
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public byte DurationBonusType { get; set; }
	public byte BonusType { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public int HpHeal { get; set; }
	public short MpHeal { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x362E4A0 Offset: 0x362A4A0 VA: 0x362E4A0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x362E4A8 Offset: 0x362A4A8 VA: 0x362E4A8
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x362E4B0 Offset: 0x362A4B0 VA: 0x362E4B0
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x362E4B8 Offset: 0x362A4B8 VA: 0x362E4B8
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x362E4C0 Offset: 0x362A4C0 VA: 0x362E4C0
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x362E4C8 Offset: 0x362A4C8 VA: 0x362E4C8
	public byte get_DurationBonusType() { }

	[CompilerGenerated]
	// RVA: 0x362E4D0 Offset: 0x362A4D0 VA: 0x362E4D0
	public void set_DurationBonusType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x362E4D8 Offset: 0x362A4D8 VA: 0x362E4D8
	public byte get_BonusType() { }

	[CompilerGenerated]
	// RVA: 0x362E4E0 Offset: 0x362A4E0 VA: 0x362E4E0
	public void set_BonusType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x362E4E8 Offset: 0x362A4E8 VA: 0x362E4E8
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x362E4F0 Offset: 0x362A4F0 VA: 0x362E4F0
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x362E4F8 Offset: 0x362A4F8 VA: 0x362E4F8
	public int get_HpHeal() { }

	[CompilerGenerated]
	// RVA: 0x362E500 Offset: 0x362A500 VA: 0x362E500
	public void set_HpHeal(int value) { }

	[CompilerGenerated]
	// RVA: 0x362E508 Offset: 0x362A508 VA: 0x362E508
	public short get_MpHeal() { }

	[CompilerGenerated]
	// RVA: 0x362E510 Offset: 0x362A510 VA: 0x362E510
	public void set_MpHeal(short value) { }

	// RVA: 0x362E518 Offset: 0x362A518 VA: 0x362E518 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x362E520 Offset: 0x362A520 VA: 0x362E520 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x362E71C Offset: 0x362A71C VA: 0x362E71C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
