// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.PetSale
public class HousePetSaleData : BinaryBase // TypeDefIndex: 12554
{
	// Fields
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <Sales>k__BackingField; // 0x1C
	[CompilerGenerated]
	private HousePetSaleItemData[] <PetSales>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Slot>k__BackingField; // 0x28

	// Properties
	public byte Flag { get; set; }
	public int Sales { get; set; }
	public HousePetSaleItemData[] PetSales { get; set; }
	public byte Slot { get; set; }

	// Methods

	// RVA: 0x3620F94 Offset: 0x361CF94 VA: 0x3620F94
	public void .ctor() { }

	// RVA: 0x3620F9C Offset: 0x361CF9C VA: 0x3620F9C
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x3620FA4 Offset: 0x361CFA4 VA: 0x3620FA4
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x3620FAC Offset: 0x361CFAC VA: 0x3620FAC
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3620FB4 Offset: 0x361CFB4 VA: 0x3620FB4
	public int get_Sales() { }

	[CompilerGenerated]
	// RVA: 0x3620FBC Offset: 0x361CFBC VA: 0x3620FBC
	public void set_Sales(int value) { }

	[CompilerGenerated]
	// RVA: 0x3620FC4 Offset: 0x361CFC4 VA: 0x3620FC4
	public HousePetSaleItemData[] get_PetSales() { }

	[CompilerGenerated]
	// RVA: 0x3620FCC Offset: 0x361CFCC VA: 0x3620FCC
	public void set_PetSales(HousePetSaleItemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3620FD4 Offset: 0x361CFD4 VA: 0x3620FD4
	public byte get_Slot() { }

	[CompilerGenerated]
	// RVA: 0x3620FDC Offset: 0x361CFDC VA: 0x3620FDC
	public void set_Slot(byte value) { }

	// RVA: 0x3620FE4 Offset: 0x361CFE4 VA: 0x3620FE4 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x3621078 Offset: 0x361D078 VA: 0x3621078 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
