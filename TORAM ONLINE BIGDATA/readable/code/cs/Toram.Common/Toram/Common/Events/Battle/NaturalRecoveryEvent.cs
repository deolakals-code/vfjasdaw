// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class NaturalRecoveryEvent : PacketBase // TypeDefIndex: 12721
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <ExHp>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <ExMp>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <HealHp>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <HealMp>k__BackingField; // 0x3C

	// Properties
	[PacketParameter(Code = 55, IsOptional = True)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 25, IsOptional = True)]
	public int Hp { get; set; }
	[PacketParameter(Code = 26, IsOptional = True)]
	public short Mp { get; set; }
	[PacketParameter(Code = 202, IsOptional = True)]
	public int ExHp { get; set; }
	[PacketParameter(Code = 203, IsOptional = True)]
	public short ExMp { get; set; }
	[PacketParameter(Code = 41, IsOptional = True)]
	public int HealHp { get; set; }
	[PacketParameter(Code = 42, IsOptional = True)]
	public short HealMp { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x364A028 Offset: 0x3646028 VA: 0x364A028
	public void .ctor() { }

	// RVA: 0x364A030 Offset: 0x3646030 VA: 0x364A030
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364A038 Offset: 0x3646038 VA: 0x364A038
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x364A040 Offset: 0x3646040 VA: 0x364A040
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x364A048 Offset: 0x3646048 VA: 0x364A048
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x364A050 Offset: 0x3646050 VA: 0x364A050
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x364A058 Offset: 0x3646058 VA: 0x364A058
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x364A060 Offset: 0x3646060 VA: 0x364A060
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x364A068 Offset: 0x3646068 VA: 0x364A068
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x364A070 Offset: 0x3646070 VA: 0x364A070
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x364A078 Offset: 0x3646078 VA: 0x364A078
	public void set_ExHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x364A080 Offset: 0x3646080 VA: 0x364A080
	public int get_ExHp() { }

	[CompilerGenerated]
	// RVA: 0x364A088 Offset: 0x3646088 VA: 0x364A088
	public void set_ExMp(short value) { }

	[CompilerGenerated]
	// RVA: 0x364A090 Offset: 0x3646090 VA: 0x364A090
	public short get_ExMp() { }

	[CompilerGenerated]
	// RVA: 0x364A098 Offset: 0x3646098 VA: 0x364A098
	public int get_HealHp() { }

	[CompilerGenerated]
	// RVA: 0x364A0A0 Offset: 0x36460A0 VA: 0x364A0A0
	public void set_HealHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x364A0A8 Offset: 0x36460A8 VA: 0x364A0A8
	public short get_HealMp() { }

	[CompilerGenerated]
	// RVA: 0x364A0B0 Offset: 0x36460B0 VA: 0x364A0B0
	public void set_HealMp(short value) { }

	// RVA: 0x364A0B8 Offset: 0x36460B8 VA: 0x364A0B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364A0C0 Offset: 0x36460C0 VA: 0x364A0C0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x364A4B8 Offset: 0x36464B8 VA: 0x364A4B8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
