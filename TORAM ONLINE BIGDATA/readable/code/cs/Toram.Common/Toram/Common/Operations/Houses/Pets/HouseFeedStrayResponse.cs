// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseFeedStrayResponse : OperationResponseBase // TypeDefIndex: 12309
{
	// Fields
	[CompilerGenerated]
	private int <MonsterUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ModelId>k__BackingField; // 0x24
	[CompilerGenerated]
	private PetBreedStatusData <BreedStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x38

	// Properties
	public int MonsterUuid { get; set; }
	public int ModelId { get; set; }
	public PetBreedStatusData BreedStatus { get; set; }
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F09E8 Offset: 0x35EC9E8 VA: 0x35F09E8
	public void .ctor() { }

	// RVA: 0x35F09F0 Offset: 0x35EC9F0 VA: 0x35F09F0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F09F8 Offset: 0x35EC9F8 VA: 0x35F09F8
	public int get_MonsterUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F0A00 Offset: 0x35ECA00 VA: 0x35F0A00
	public void set_MonsterUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F0A08 Offset: 0x35ECA08 VA: 0x35F0A08
	public int get_ModelId() { }

	[CompilerGenerated]
	// RVA: 0x35F0A10 Offset: 0x35ECA10 VA: 0x35F0A10
	public void set_ModelId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F0A18 Offset: 0x35ECA18 VA: 0x35F0A18
	public PetBreedStatusData get_BreedStatus() { }

	[CompilerGenerated]
	// RVA: 0x35F0A20 Offset: 0x35ECA20 VA: 0x35F0A20
	public void set_BreedStatus(PetBreedStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x35F0A28 Offset: 0x35ECA28 VA: 0x35F0A28
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x35F0A30 Offset: 0x35ECA30 VA: 0x35F0A30
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F0A38 Offset: 0x35ECA38 VA: 0x35F0A38
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x35F0A40 Offset: 0x35ECA40 VA: 0x35F0A40
	public void set_PaidOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F0A48 Offset: 0x35ECA48 VA: 0x35F0A48
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x35F0A50 Offset: 0x35ECA50 VA: 0x35F0A50
	public void set_Gold(int value) { }

	// RVA: 0x35F0A58 Offset: 0x35ECA58 VA: 0x35F0A58
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F0B74 Offset: 0x35ECB74 VA: 0x35F0B74
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F0BF0 Offset: 0x35ECBF0 VA: 0x35F0BF0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F0BF8 Offset: 0x35ECBF8 VA: 0x35F0BF8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F0C00 Offset: 0x35ECC00 VA: 0x35F0C00 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F0E74 Offset: 0x35ECE74 VA: 0x35F0E74 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
