// Assembly: mscorlib.dll
// Namespace: System.Collections
[DefaultMember("Item")]
[Serializable]
public sealed class BitArray : ICollection, IEnumerable, ICloneable // TypeDefIndex: 10894
{
	// Fields
	private int[] m_array; // 0x10
	private int m_length; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public bool Item { get; set; }
	public int Length { get; set; }
	public int Count { get; }
	public object SyncRoot { get; }
	public bool IsSynchronized { get; }

	// Methods

	// RVA: 0x2FBB218 Offset: 0x2FB7218 VA: 0x2FBB218
	public void .ctor(int length) { }

	// RVA: 0x2FBB220 Offset: 0x2FB7220 VA: 0x2FBB220
	public void .ctor(int length, bool defaultValue) { }

	// RVA: 0x2FBB3A8 Offset: 0x2FB73A8 VA: 0x2FBB3A8
	public void .ctor(BitArray bits) { }

	// RVA: 0x2FBB4AC Offset: 0x2FB74AC VA: 0x2FBB4AC
	public bool get_Item(int index) { }

	// RVA: 0x2FBB588 Offset: 0x2FB7588 VA: 0x2FBB588
	public void set_Item(int index, bool value) { }

	// RVA: 0x2FBB4B0 Offset: 0x2FB74B0 VA: 0x2FBB4B0
	public bool Get(int index) { }

	// RVA: 0x2FBB590 Offset: 0x2FB7590 VA: 0x2FBB590
	public void Set(int index, bool value) { }

	// RVA: 0x2FBB688 Offset: 0x2FB7688 VA: 0x2FBB688
	public int get_Length() { }

	// RVA: 0x2FBB690 Offset: 0x2FB7690 VA: 0x2FBB690
	public void set_Length(int value) { }

	// RVA: 0x2FBB858 Offset: 0x2FB7858 VA: 0x2FBB858 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x2FBBD5C Offset: 0x2FB7D5C VA: 0x2FBBD5C Slot: 5
	public int get_Count() { }

	// RVA: 0x2FBBD64 Offset: 0x2FB7D64 VA: 0x2FBBD64 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x2FBBDD4 Offset: 0x2FB7DD4 VA: 0x2FBBDD4 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x2FBBDDC Offset: 0x2FB7DDC VA: 0x2FBBDDC Slot: 9
	public object Clone() { }

	// RVA: 0x2FBBE34 Offset: 0x2FB7E34 VA: 0x2FBBE34 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x2FBB38C Offset: 0x2FB738C VA: 0x2FBB38C
	private static int GetArrayLength(int n, int div) { }
}
