// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseKennelPurchaseResponse : OperationResponseBase // TypeDefIndex: 12317
{
	// Fields
	[CompilerGenerated]
	private int <KennelNum>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x2C

	// Properties
	public int KennelNum { get; set; }
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F22A4 Offset: 0x35EE2A4 VA: 0x35F22A4
	public void .ctor() { }

	// RVA: 0x35F22AC Offset: 0x35EE2AC VA: 0x35F22AC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F22B4 Offset: 0x35EE2B4 VA: 0x35F22B4
	public int get_KennelNum() { }

	[CompilerGenerated]
	// RVA: 0x35F22BC Offset: 0x35EE2BC VA: 0x35F22BC
	public void set_KennelNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F22C4 Offset: 0x35EE2C4 VA: 0x35F22C4
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x35F22CC Offset: 0x35EE2CC VA: 0x35F22CC
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F22D4 Offset: 0x35EE2D4 VA: 0x35F22D4
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x35F22DC Offset: 0x35EE2DC VA: 0x35F22DC
	public void set_PaidOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F22E4 Offset: 0x35EE2E4 VA: 0x35F22E4
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x35F22EC Offset: 0x35EE2EC VA: 0x35F22EC
	public void set_Gold(int value) { }

	// RVA: 0x35F22F4 Offset: 0x35EE2F4 VA: 0x35F22F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F22FC Offset: 0x35EE2FC VA: 0x35F22FC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F2304 Offset: 0x35EE304 VA: 0x35F2304 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F2524 Offset: 0x35EE524 VA: 0x35F2524 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
