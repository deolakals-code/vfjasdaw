// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HouseComponentManager // TypeDefIndex: 1965
{
	// Fields
	public static readonly int[] DefaultItem; // 0x0
	private List<int> houseComponentList; // 0x10
	private List<int> houseComponentEditList; // 0x18
	[CompilerGenerated]
	private int <FloorHeight>k__BackingField; // 0x20
	private int editFloorHeight; // 0x24

	// Properties
	public int FloorHeight { get; set; }
	public int[] HouseComponent { get; }
	public bool IsAllDefault { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x211412C Offset: 0x211012C VA: 0x211412C
	public int get_FloorHeight() { }

	[CompilerGenerated]
	// RVA: 0x2114134 Offset: 0x2110134 VA: 0x2114134
	private void set_FloorHeight(int value) { }

	// RVA: 0x211413C Offset: 0x211013C VA: 0x211413C
	public int[] get_HouseComponent() { }

	// RVA: 0x211418C Offset: 0x211018C VA: 0x211418C
	public bool get_IsAllDefault() { }

	// RVA: 0x2114274 Offset: 0x2110274 VA: 0x2114274
	private byte LoadHeader(MemoryStream ms, Dictionary<byte, long> header) { }

	// RVA: 0x2114330 Offset: 0x2110330 VA: 0x2114330
	public bool LoadHouse(byte[] buf) { }

	// RVA: 0x2114CE0 Offset: 0x2110CE0 VA: 0x2114CE0
	public bool HouseConstruction(byte floorHeight, List<int> item) { }

	// RVA: 0x2114D20 Offset: 0x2110D20 VA: 0x2114D20
	public bool ReceiveHouseConstruction(HouseConstructionResponse response) { }

	// RVA: 0x2114DB0 Offset: 0x2110DB0 VA: 0x2114DB0
	public void OnEnter() { }

	// RVA: 0x2114DB4 Offset: 0x2110DB4 VA: 0x2114DB4
	public void OnLeave() { }

	// RVA: 0x2114E1C Offset: 0x2110E1C VA: 0x2114E1C
	public void .ctor() { }

	// RVA: 0x2114EAC Offset: 0x2110EAC VA: 0x2114EAC
	private static void .cctor() { }
}
