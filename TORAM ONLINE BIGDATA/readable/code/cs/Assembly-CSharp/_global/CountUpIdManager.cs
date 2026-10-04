// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CountUpIdManager // TypeDefIndex: 5465
{
	// Fields
	private readonly int startId; // 0x10
	private int nextId; // 0x14
	private List<int> usedIDList; // 0x18
	[CompilerGenerated]
	private int <MaxNumber>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsMax>k__BackingField; // 0x24

	// Properties
	public int MaxNumber { get; set; }
	public bool IsMax { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17739E4 Offset: 0x176F9E4 VA: 0x17739E4
	public int get_MaxNumber() { }

	[CompilerGenerated]
	// RVA: 0x17739EC Offset: 0x176F9EC VA: 0x17739EC
	private void set_MaxNumber(int value) { }

	[CompilerGenerated]
	// RVA: 0x17739F4 Offset: 0x176F9F4 VA: 0x17739F4
	public bool get_IsMax() { }

	[CompilerGenerated]
	// RVA: 0x17739FC Offset: 0x176F9FC VA: 0x17739FC
	private void set_IsMax(bool value) { }

	// RVA: 0x1773A08 Offset: 0x176FA08 VA: 0x1773A08
	public void .ctor(int max) { }

	// RVA: 0x1773AEC Offset: 0x176FAEC VA: 0x1773AEC
	public void .ctor(int start, int max) { }

	// RVA: 0x1773C0C Offset: 0x176FC0C VA: 0x1773C0C
	public int Next() { }

	// RVA: 0x1773D48 Offset: 0x176FD48 VA: 0x1773D48
	public void RandomCurrentId() { }

	// RVA: 0x1773D6C Offset: 0x176FD6C VA: 0x1773D6C
	public bool ReleaseID(int id) { }

	// RVA: 0x1773E24 Offset: 0x176FE24 VA: 0x1773E24
	public void Clear() { }

	// RVA: 0x1773E80 Offset: 0x176FE80 VA: 0x1773E80
	public void CurrentSaveClear() { }
}
