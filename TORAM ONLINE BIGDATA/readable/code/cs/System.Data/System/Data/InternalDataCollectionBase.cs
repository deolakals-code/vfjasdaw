// Assembly: System.Data.dll
// Namespace: System.Data
public class InternalDataCollectionBase : ICollection, IEnumerable // TypeDefIndex: 14671
{
	// Fields
	internal static readonly CollectionChangeEventArgs s_refreshEventArgs; // 0x0

	// Properties
	[Browsable(False)]
	public virtual int Count { get; }
	[Browsable(False)]
	public bool IsSynchronized { get; }
	[Browsable(False)]
	public object SyncRoot { get; }
	protected virtual ArrayList List { get; }

	// Methods

	// RVA: 0x31DC7EC Offset: 0x31D87EC VA: 0x31DC7EC Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x31DC818 Offset: 0x31D8818 VA: 0x31DC818 Slot: 10
	public virtual void CopyTo(Array ar, int index) { }

	// RVA: 0x31DC860 Offset: 0x31D8860 VA: 0x31DC860 Slot: 11
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x31DC88C Offset: 0x31D888C VA: 0x31DC88C Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x31DC894 Offset: 0x31D8894 VA: 0x31DC894
	internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

	// RVA: 0x31DC940 Offset: 0x31D8940 VA: 0x31DC940 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x31DC944 Offset: 0x31D8944 VA: 0x31DC944 Slot: 12
	protected virtual ArrayList get_List() { }

	// RVA: 0x31DC94C Offset: 0x31D894C VA: 0x31DC94C
	public void .ctor() { }

	// RVA: 0x31DC954 Offset: 0x31D8954 VA: 0x31DC954
	private static void .cctor() { }
}
