// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.StarGem
public class OrbStarGemBagResponse : OperationResponseBase // TypeDefIndex: 11840
{
	// Fields
	[CompilerGenerated]
	private StarGemData[] <StarGemBag>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <BagCapacity>k__BackingField; // 0x28

	// Properties
	public StarGemData[] StarGemBag { get; set; }
	public int BagCapacity { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3754750 Offset: 0x3750750 VA: 0x3754750
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3754758 Offset: 0x3750758 VA: 0x3754758
	public StarGemData[] get_StarGemBag() { }

	[CompilerGenerated]
	// RVA: 0x3754760 Offset: 0x3750760 VA: 0x3754760
	public void set_StarGemBag(StarGemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3754768 Offset: 0x3750768 VA: 0x3754768
	public int get_BagCapacity() { }

	[CompilerGenerated]
	// RVA: 0x3754770 Offset: 0x3750770 VA: 0x3754770
	public void set_BagCapacity(int value) { }

	// RVA: 0x3754778 Offset: 0x3750778 VA: 0x3754778
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37547E0 Offset: 0x37507E0 VA: 0x37547E0
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x375483C Offset: 0x375083C VA: 0x375483C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3754844 Offset: 0x3750844 VA: 0x3754844 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x375484C Offset: 0x375084C VA: 0x375484C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x375497C Offset: 0x375097C VA: 0x375497C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
