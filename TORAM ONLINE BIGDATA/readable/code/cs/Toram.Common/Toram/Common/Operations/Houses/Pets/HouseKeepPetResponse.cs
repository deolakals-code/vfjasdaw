// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseKeepPetResponse : OperationResponseBase // TypeDefIndex: 12311
{
	// Fields
	[CompilerGenerated]
	private PetInfoData <Pet>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x28

	// Properties
	public PetInfoData Pet { get; set; }
	public ItemDatav2[] ItemList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F11B0 Offset: 0x35ED1B0 VA: 0x35F11B0
	public void .ctor() { }

	// RVA: 0x35F11B8 Offset: 0x35ED1B8 VA: 0x35F11B8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F11C0 Offset: 0x35ED1C0 VA: 0x35F11C0
	public PetInfoData get_Pet() { }

	[CompilerGenerated]
	// RVA: 0x35F11C8 Offset: 0x35ED1C8 VA: 0x35F11C8
	public void set_Pet(PetInfoData value) { }

	[CompilerGenerated]
	// RVA: 0x35F11D0 Offset: 0x35ED1D0 VA: 0x35F11D0
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x35F11D8 Offset: 0x35ED1D8 VA: 0x35F11D8
	public void set_ItemList(ItemDatav2[] value) { }

	// RVA: 0x35F11E0 Offset: 0x35ED1E0 VA: 0x35F11E0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F11E8 Offset: 0x35ED1E8 VA: 0x35F11E8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F11F0 Offset: 0x35ED1F0 VA: 0x35F11F0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F1434 Offset: 0x35ED434 VA: 0x35F1434 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
