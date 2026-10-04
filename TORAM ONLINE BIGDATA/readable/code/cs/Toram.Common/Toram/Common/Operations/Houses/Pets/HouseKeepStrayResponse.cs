// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseKeepStrayResponse : OperationResponseBase // TypeDefIndex: 12315
{
	// Fields
	[CompilerGenerated]
	private int <MonsterUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ModelId>k__BackingField; // 0x24
	[CompilerGenerated]
	private PetInfoData <Pet>k__BackingField; // 0x28

	// Properties
	public int MonsterUuid { get; set; }
	public int ModelId { get; set; }
	public PetInfoData Pet { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F1B50 Offset: 0x35EDB50 VA: 0x35F1B50
	public void .ctor() { }

	// RVA: 0x35F1B58 Offset: 0x35EDB58 VA: 0x35F1B58
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F1B60 Offset: 0x35EDB60 VA: 0x35F1B60
	public int get_MonsterUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F1B68 Offset: 0x35EDB68 VA: 0x35F1B68
	public void set_MonsterUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F1B70 Offset: 0x35EDB70 VA: 0x35F1B70
	public int get_ModelId() { }

	[CompilerGenerated]
	// RVA: 0x35F1B78 Offset: 0x35EDB78 VA: 0x35F1B78
	public void set_ModelId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F1B80 Offset: 0x35EDB80 VA: 0x35F1B80
	public PetInfoData get_Pet() { }

	[CompilerGenerated]
	// RVA: 0x35F1B88 Offset: 0x35EDB88 VA: 0x35F1B88
	public void set_Pet(PetInfoData value) { }

	// RVA: 0x35F1B90 Offset: 0x35EDB90 VA: 0x35F1B90
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F1CAC Offset: 0x35EDCAC VA: 0x35F1CAC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F1D28 Offset: 0x35EDD28 VA: 0x35F1D28 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F1D30 Offset: 0x35EDD30 VA: 0x35F1D30 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F1D38 Offset: 0x35EDD38 VA: 0x35F1D38 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F1EB4 Offset: 0x35EDEB4 VA: 0x35F1EB4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
