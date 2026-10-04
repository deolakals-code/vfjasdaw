// Assembly: Firebase.App.dll
// Namespace: Firebase
[DefaultMember("Item")]
internal class CharVector : IDisposable, IEnumerable, IList<byte>, ICollection<byte>, IEnumerable<byte> // TypeDefIndex: 17212
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Properties
	public bool IsReadOnly { get; }
	public byte Item { get; set; }
	public int Count { get; }

	// Methods

	// RVA: 0x2656658 Offset: 0x2652658 VA: 0x2656658
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x26566B8 Offset: 0x26526B8 VA: 0x26566B8 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x265675C Offset: 0x265275C VA: 0x265675C Slot: 4
	public void Dispose() { }

	// RVA: 0x26567CC Offset: 0x26527CC VA: 0x26567CC Slot: 19
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x2656A04 Offset: 0x2652A04 VA: 0x2656A04 Slot: 12
	public bool get_IsReadOnly() { }

	// RVA: 0x2656A0C Offset: 0x2652A0C VA: 0x2656A0C Slot: 6
	public byte get_Item(int index) { }

	// RVA: 0x2656AE8 Offset: 0x2652AE8 VA: 0x2656AE8 Slot: 7
	public void set_Item(int index, byte value) { }

	// RVA: 0x2656BC0 Offset: 0x2652BC0 VA: 0x2656BC0 Slot: 11
	public int get_Count() { }

	// RVA: 0x2656C8C Offset: 0x2652C8C VA: 0x2656C8C
	public void CopyTo(byte[] array) { }

	// RVA: 0x2656F00 Offset: 0x2652F00 VA: 0x2656F00 Slot: 16
	public void CopyTo(byte[] array, int arrayIndex) { }

	// RVA: 0x2656CC0 Offset: 0x2652CC0 VA: 0x2656CC0
	public void CopyTo(int index, byte[] array, int arrayIndex, int count) { }

	// RVA: 0x2657010 Offset: 0x2653010 VA: 0x2657010 Slot: 18
	private IEnumerator<byte> global::System.Collections.Generic.IEnumerable<System.Byte>.GetEnumerator() { }

	// RVA: 0x26570CC Offset: 0x26530CC VA: 0x26570CC Slot: 5
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2657124 Offset: 0x2653124 VA: 0x2657124 Slot: 14
	public void Clear() { }

	// RVA: 0x265725C Offset: 0x265325C VA: 0x265725C Slot: 13
	public void Add(byte x) { }

	// RVA: 0x2656BC4 Offset: 0x2652BC4 VA: 0x2656BC4
	private uint size() { }

	// RVA: 0x2656F38 Offset: 0x2652F38 VA: 0x2656F38
	private byte getitemcopy(int index) { }

	// RVA: 0x2656A10 Offset: 0x2652A10 VA: 0x2656A10
	private byte getitem(int index) { }

	// RVA: 0x2656AEC Offset: 0x2652AEC VA: 0x2656AEC
	private void setitem(int index, byte val) { }

	// RVA: 0x26575C4 Offset: 0x26535C4 VA: 0x26575C4 Slot: 9
	public void Insert(int index, byte x) { }

	// RVA: 0x265772C Offset: 0x265372C VA: 0x265772C Slot: 10
	public void RemoveAt(int index) { }

	// RVA: 0x265787C Offset: 0x265387C VA: 0x265787C Slot: 15
	public bool Contains(byte value) { }

	// RVA: 0x26579E0 Offset: 0x26539E0 VA: 0x26579E0 Slot: 8
	public int IndexOf(byte value) { }

	// RVA: 0x2657B3C Offset: 0x2653B3C VA: 0x2657B3C Slot: 17
	public bool Remove(byte value) { }
}
