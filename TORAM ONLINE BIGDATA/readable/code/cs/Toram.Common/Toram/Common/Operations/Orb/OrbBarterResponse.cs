// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbBarterResponse : OperationResponseBase // TypeDefIndex: 11804
{
	// Fields
	[CompilerGenerated]
	private int <ExchangeNum>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <OrbShard>k__BackingField; // 0x2C

	// Properties
	[PacketParameter(Code = 92)]
	public int ExchangeNum { get; set; }
	[PacketParameter(Code = 229)]
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	[PacketParameter(Code = 230)]
	public int OrbShard { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374E9CC Offset: 0x374A9CC VA: 0x374E9CC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x374E9D4 Offset: 0x374A9D4 VA: 0x374E9D4
	public int get_ExchangeNum() { }

	[CompilerGenerated]
	// RVA: 0x374E9DC Offset: 0x374A9DC VA: 0x374E9DC
	public void set_ExchangeNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x374E9E4 Offset: 0x374A9E4 VA: 0x374E9E4
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x374E9EC Offset: 0x374A9EC VA: 0x374E9EC
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x374E9F4 Offset: 0x374A9F4 VA: 0x374E9F4
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x374E9FC Offset: 0x374A9FC VA: 0x374E9FC
	public void set_PaidOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x374EA04 Offset: 0x374AA04 VA: 0x374EA04
	public int get_OrbShard() { }

	[CompilerGenerated]
	// RVA: 0x374EA0C Offset: 0x374AA0C VA: 0x374EA0C
	public void set_OrbShard(int value) { }

	// RVA: 0x374EA14 Offset: 0x374AA14 VA: 0x374EA14 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374EA1C Offset: 0x374AA1C VA: 0x374EA1C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374EA24 Offset: 0x374AA24 VA: 0x374EA24 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374EC44 Offset: 0x374AC44 VA: 0x374EC44 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
