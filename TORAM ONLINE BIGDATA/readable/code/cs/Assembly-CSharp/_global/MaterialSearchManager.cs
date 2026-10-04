// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MaterialSearchManager // TypeDefIndex: 2040
{
	// Fields
	private static MaterialSearchManager instance; // 0x0
	private Dictionary<int, MaterialSearchData> materialData; // 0x10

	// Properties
	public static MaterialSearchManager Instance { get; }

	// Methods

	// RVA: 0x213C1F4 Offset: 0x21381F4 VA: 0x213C1F4
	public static MaterialSearchManager get_Instance() { }

	// RVA: 0x213C278 Offset: 0x2138278 VA: 0x213C278
	private void .ctor() { }

	// RVA: 0x213C300 Offset: 0x2138300 VA: 0x213C300
	public bool Read(byte[] data) { }

	// RVA: 0x213C7D4 Offset: 0x21387D4 VA: 0x213C7D4
	public MaterialSearchData[] GetData(int[] idList) { }

	// RVA: 0x213C958 Offset: 0x2138958 VA: 0x213C958
	public MaterialSearchData GetData(int id) { }
}
