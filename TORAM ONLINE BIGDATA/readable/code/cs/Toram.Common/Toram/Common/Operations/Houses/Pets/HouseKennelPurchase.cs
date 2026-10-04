// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseKennelPurchase : OperationRequestBase // TypeDefIndex: 12316
{
	// Fields
	[CompilerGenerated]
	private bool <IsDirect>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x28

	// Properties
	public bool IsDirect { get; set; }
	public int Gold { get; set; }
	public int Orb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F1F88 Offset: 0x35EDF88 VA: 0x35F1F88
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F1F90 Offset: 0x35EDF90 VA: 0x35F1F90
	public bool get_IsDirect() { }

	[CompilerGenerated]
	// RVA: 0x35F1F98 Offset: 0x35EDF98 VA: 0x35F1F98
	public void set_IsDirect(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35F1FA4 Offset: 0x35EDFA4 VA: 0x35F1FA4
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x35F1FAC Offset: 0x35EDFAC VA: 0x35F1FAC
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F1FB4 Offset: 0x35EDFB4 VA: 0x35F1FB4
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x35F1FBC Offset: 0x35EDFBC VA: 0x35F1FBC
	public void set_Orb(int value) { }

	// RVA: 0x35F1FC4 Offset: 0x35EDFC4 VA: 0x35F1FC4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F1FCC Offset: 0x35EDFCC VA: 0x35F1FCC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F1FD4 Offset: 0x35EDFD4 VA: 0x35F1FD4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F2198 Offset: 0x35EE198 VA: 0x35F2198 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
