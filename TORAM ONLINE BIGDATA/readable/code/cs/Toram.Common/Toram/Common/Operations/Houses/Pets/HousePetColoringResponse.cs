// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetColoringResponse : OperationResponseBase // TypeDefIndex: 12294
{
	// Fields
	[CompilerGenerated]
	private PetInfoData <Pet>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <RemoveUuid>k__BackingField; // 0x28
	[CompilerGenerated]
	private ItemDatav2 <RemoveItem>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x3C
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x40

	// Properties
	public PetInfoData Pet { get; set; }
	public long RemoveUuid { get; set; }
	public ItemDatav2 RemoveItem { get; set; }
	public int Gold { get; set; }
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35ED994 Offset: 0x35E9994 VA: 0x35ED994
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35ED99C Offset: 0x35E999C VA: 0x35ED99C
	public PetInfoData get_Pet() { }

	[CompilerGenerated]
	// RVA: 0x35ED9A4 Offset: 0x35E99A4 VA: 0x35ED9A4
	public void set_Pet(PetInfoData value) { }

	[CompilerGenerated]
	// RVA: 0x35ED9AC Offset: 0x35E99AC VA: 0x35ED9AC
	public long get_RemoveUuid() { }

	[CompilerGenerated]
	// RVA: 0x35ED9B4 Offset: 0x35E99B4 VA: 0x35ED9B4
	public void set_RemoveUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35ED9BC Offset: 0x35E99BC VA: 0x35ED9BC
	public ItemDatav2 get_RemoveItem() { }

	[CompilerGenerated]
	// RVA: 0x35ED9C4 Offset: 0x35E99C4 VA: 0x35ED9C4
	public void set_RemoveItem(ItemDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x35ED9CC Offset: 0x35E99CC VA: 0x35ED9CC
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x35ED9D4 Offset: 0x35E99D4 VA: 0x35ED9D4
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x35ED9DC Offset: 0x35E99DC VA: 0x35ED9DC
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x35ED9E4 Offset: 0x35E99E4 VA: 0x35ED9E4
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35ED9EC Offset: 0x35E99EC VA: 0x35ED9EC
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x35ED9F4 Offset: 0x35E99F4 VA: 0x35ED9F4
	public void set_PaidOrb(int value) { }

	// RVA: 0x35ED9FC Offset: 0x35E99FC VA: 0x35ED9FC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EDA04 Offset: 0x35E9A04 VA: 0x35EDA04 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EDA0C Offset: 0x35E9A0C VA: 0x35EDA0C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35EDB94 Offset: 0x35E9B94 VA: 0x35EDB94 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
