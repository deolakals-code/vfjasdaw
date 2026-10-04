// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildStaff
public class GuildStaffRecoveryPlayerResponse : OperationResponseBase // TypeDefIndex: 12414
{
	// Fields
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ExHp>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <HealHp>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 25)]
	public int Hp { get; set; }
	[PacketParameter(Code = 202)]
	public int ExHp { get; set; }
	[PacketParameter(Code = 41)]
	public int HealHp { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36039CC Offset: 0x35FF9CC VA: 0x36039CC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36039D4 Offset: 0x35FF9D4 VA: 0x36039D4
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x36039DC Offset: 0x35FF9DC VA: 0x36039DC
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x36039E4 Offset: 0x35FF9E4 VA: 0x36039E4
	public int get_ExHp() { }

	[CompilerGenerated]
	// RVA: 0x36039EC Offset: 0x35FF9EC VA: 0x36039EC
	public void set_ExHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x36039F4 Offset: 0x35FF9F4 VA: 0x36039F4
	public int get_HealHp() { }

	[CompilerGenerated]
	// RVA: 0x36039FC Offset: 0x35FF9FC VA: 0x36039FC
	public void set_HealHp(int value) { }

	// RVA: 0x3603A04 Offset: 0x35FFA04 VA: 0x3603A04 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3603A0C Offset: 0x35FFA0C VA: 0x3603A0C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3603A14 Offset: 0x35FFA14 VA: 0x3603A14 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3603B0C Offset: 0x35FFB0C VA: 0x3603B0C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
