// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle.MobBuff
public class MobBuffEffectEvent : EventSubBase // TypeDefIndex: 12724
{
	// Fields
	[CompilerGenerated]
	private MobResponseData <MobData>k__BackingField; // 0x20
	[CompilerGenerated]
	private MobaMobResponseData <MobaData>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Id>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <HealHp>k__BackingField; // 0x34
	[CompilerGenerated]
	private byte <TargetArchetypeType>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <TargetArchetypeId>k__BackingField; // 0x3C
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <PlayerHealHp>k__BackingField; // 0x48
	[CompilerGenerated]
	private short <PlayerHealMp>k__BackingField; // 0x4C
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x4E
	[CompilerGenerated]
	private int <Value>k__BackingField; // 0x50

	// Properties
	[PacketClass(Code = 29)]
	public MobResponseData MobData { get; set; }
	[PacketClass(Code = 31)]
	public MobaMobResponseData MobaData { get; set; }
	[PacketParameter(Code = 0)]
	public short Id { get; set; }
	[PacketParameter(Code = 10)]
	public int HealHp { get; set; }
	public byte TargetArchetypeType { get; set; }
	public int TargetArchetypeId { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public int PlayerHealHp { get; set; }
	public short PlayerHealMp { get; set; }
	public byte Flag { get; set; }
	public int Value { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x364B094 Offset: 0x3647094 VA: 0x364B094
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364B09C Offset: 0x364709C VA: 0x364B09C
	public MobResponseData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x364B0A4 Offset: 0x36470A4 VA: 0x364B0A4
	public void set_MobData(MobResponseData value) { }

	[CompilerGenerated]
	// RVA: 0x364B0AC Offset: 0x36470AC VA: 0x364B0AC
	public MobaMobResponseData get_MobaData() { }

	[CompilerGenerated]
	// RVA: 0x364B0B4 Offset: 0x36470B4 VA: 0x364B0B4
	public void set_MobaData(MobaMobResponseData value) { }

	[CompilerGenerated]
	// RVA: 0x364B0BC Offset: 0x36470BC VA: 0x364B0BC
	public short get_Id() { }

	[CompilerGenerated]
	// RVA: 0x364B0C4 Offset: 0x36470C4 VA: 0x364B0C4
	public void set_Id(short value) { }

	[CompilerGenerated]
	// RVA: 0x364B0CC Offset: 0x36470CC VA: 0x364B0CC
	public int get_HealHp() { }

	[CompilerGenerated]
	// RVA: 0x364B0D4 Offset: 0x36470D4 VA: 0x364B0D4
	public void set_HealHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x364B0DC Offset: 0x36470DC VA: 0x364B0DC
	public byte get_TargetArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x364B0E4 Offset: 0x36470E4 VA: 0x364B0E4
	public void set_TargetArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x364B0EC Offset: 0x36470EC VA: 0x364B0EC
	public int get_TargetArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x364B0F4 Offset: 0x36470F4 VA: 0x364B0F4
	public void set_TargetArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x364B0FC Offset: 0x36470FC VA: 0x364B0FC
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x364B104 Offset: 0x3647104 VA: 0x364B104
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x364B10C Offset: 0x364710C VA: 0x364B10C
	public int get_PlayerHealHp() { }

	[CompilerGenerated]
	// RVA: 0x364B114 Offset: 0x3647114 VA: 0x364B114
	public void set_PlayerHealHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x364B11C Offset: 0x364711C VA: 0x364B11C
	public short get_PlayerHealMp() { }

	[CompilerGenerated]
	// RVA: 0x364B124 Offset: 0x3647124 VA: 0x364B124
	public void set_PlayerHealMp(short value) { }

	[CompilerGenerated]
	// RVA: 0x364B12C Offset: 0x364712C VA: 0x364B12C
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x364B134 Offset: 0x3647134 VA: 0x364B134
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x364B13C Offset: 0x364713C VA: 0x364B13C
	public int get_Value() { }

	[CompilerGenerated]
	// RVA: 0x364B144 Offset: 0x3647144 VA: 0x364B144
	public void set_Value(int value) { }

	// RVA: 0x364B14C Offset: 0x364714C VA: 0x364B14C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364B154 Offset: 0x3647154 VA: 0x364B154 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x364B15C Offset: 0x364715C VA: 0x364B15C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x364B3E0 Offset: 0x36473E0 VA: 0x364B3E0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
