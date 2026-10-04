// Assembly: System.dll
// Namespace: System.Net
[DefaultMember("Item")]
[Serializable]
public class CookieCollection : ICollection, IEnumerable // TypeDefIndex: 14445
{
	// Fields
	internal int m_version; // 0x10
	private ArrayList m_list; // 0x18
	private DateTime m_TimeStamp; // 0x20
	private bool m_has_other_versions; // 0x28
	[OptionalField]
	private bool m_IsReadOnly; // 0x29

	// Properties
	public Cookie Item { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	internal bool IsOtherVersionSeen { get; }

	// Methods

	// RVA: 0x34FBD40 Offset: 0x34F7D40 VA: 0x34FBD40
	public void .ctor() { }

	// RVA: 0x34FBDF4 Offset: 0x34F7DF4 VA: 0x34FBDF4
	public Cookie get_Item(int index) { }

	// RVA: 0x34FBEDC Offset: 0x34F7EDC VA: 0x34FBEDC
	public void Add(Cookie cookie) { }

	// RVA: 0x34FC34C Offset: 0x34F834C VA: 0x34FC34C
	public void Add(CookieCollection cookies) { }

	// RVA: 0x34FC6A0 Offset: 0x34F86A0 VA: 0x34FC6A0 Slot: 5
	public int get_Count() { }

	// RVA: 0x34FC6C4 Offset: 0x34F86C4 VA: 0x34FC6C4 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x34FC6CC Offset: 0x34F86CC VA: 0x34FC6CC Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x34FC6D0 Offset: 0x34F86D0 VA: 0x34FC6D0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x34FC6F4 Offset: 0x34F86F4 VA: 0x34FC6F4
	internal DateTime TimeStamp(CookieCollection.Stamp how) { }

	// RVA: 0x34FC7C4 Offset: 0x34F87C4 VA: 0x34FC7C4
	internal bool get_IsOtherVersionSeen() { }

	// RVA: 0x34FC7CC Offset: 0x34F87CC VA: 0x34FC7CC
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	// RVA: 0x34FBF9C Offset: 0x34F7F9C VA: 0x34FBF9C
	internal int IndexOf(Cookie cookie) { }

	// RVA: 0x34FCC80 Offset: 0x34F8C80 VA: 0x34FCC80
	internal void RemoveAt(int idx) { }

	// RVA: 0x34FC648 Offset: 0x34F8648 VA: 0x34FC648 Slot: 8
	public IEnumerator GetEnumerator() { }
}
