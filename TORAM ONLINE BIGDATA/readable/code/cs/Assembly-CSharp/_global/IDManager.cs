// Assembly: Assembly-CSharp.dll
// Namespace: 
public class IDManager // TypeDefIndex: 5494
{
	// Fields
	private List<int> noneUsedIDList; // 0x10
	private List<int> usedIDList; // 0x18
	private int startNumber; // 0x20
	private int nextID; // 0x24
	[CompilerGenerated]
	private int <MaxNumber>k__BackingField; // 0x28

	// Properties
	public int MaxNumber { get; set; }
	public ReadOnlyCollection<int> IDList { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x177B52C Offset: 0x177752C VA: 0x177B52C
	public int get_MaxNumber() { }

	[CompilerGenerated]
	// RVA: 0x177B534 Offset: 0x1777534 VA: 0x177B534
	private void set_MaxNumber(int value) { }

	// RVA: 0x177B53C Offset: 0x177753C VA: 0x177B53C
	public ReadOnlyCollection<int> get_IDList() { }

	// RVA: 0x177B58C Offset: 0x177758C VA: 0x177B58C
	public void .ctor() { }

	// RVA: 0x177B6B8 Offset: 0x17776B8 VA: 0x177B6B8
	public void .ctor(int max) { }

	// RVA: 0x177B778 Offset: 0x1777778 VA: 0x177B778
	public void .ctor(int start, int max) { }

	// RVA: 0x177B64C Offset: 0x177764C VA: 0x177B64C
	public void Init() { }

	// RVA: 0x177B848 Offset: 0x1777848 VA: 0x177B848
	public bool ExistID(int id) { }

	// RVA: 0x177B8A0 Offset: 0x17778A0 VA: 0x177B8A0
	public bool ValidID(int id) { }

	// RVA: 0x177B930 Offset: 0x1777930 VA: 0x177B930
	public bool ForceBindID(int id) { }

	// RVA: 0x177BA90 Offset: 0x1777A90 VA: 0x177BA90
	public int NextID() { }

	// RVA: 0x177BC1C Offset: 0x1777C1C VA: 0x177BC1C
	public void ReleaseID(int id) { }
}
