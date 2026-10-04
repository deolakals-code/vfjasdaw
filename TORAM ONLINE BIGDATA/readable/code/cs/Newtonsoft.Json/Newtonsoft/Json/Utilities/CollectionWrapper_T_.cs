// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
internal class CollectionWrapper<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IWrappedCollection, IList, ICollection // TypeDefIndex: 15883
{
	// Fields
	[Nullable(2)]
	private readonly IList _list; // 0x0
	[Nullable(new[] { 2, 1 })]
	private readonly ICollection<T> _genericCollection; // 0x0
	[Nullable(2)]
	private object _syncRoot; // 0x0

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	[Nullable(2)]
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public object UnderlyingCollection { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	public virtual void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C77EA8 Offset: 0x2C73EA8 VA: 0x2C77EA8
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public virtual void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C780B4 Offset: 0x2C740B4 VA: 0x2C780B4
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public virtual bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C781C4 Offset: 0x2C741C4 VA: 0x2C781C4
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public virtual void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C783E0 Offset: 0x2C743E0 VA: 0x2C783E0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public virtual int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7850C Offset: 0x2C7450C VA: 0x2C7850C
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public virtual bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C78620 Offset: 0x2C74620 VA: 0x2C78620
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public virtual bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C78730 Offset: 0x2C74730 VA: 0x2C78730
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public virtual IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C78A0C Offset: 0x2C74A0C VA: 0x2C78A0C
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C78AC0 Offset: 0x2C74AC0 VA: 0x2C78AC0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 16
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C78B68 Offset: 0x2C74B68 VA: 0x2C78B68
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 17
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C78C74 Offset: 0x2C74C74 VA: 0x2C78C74
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 21
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C78D80 Offset: 0x2C74D80 VA: 0x2C78D80
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C78F3C Offset: 0x2C74F3C VA: 0x2C78F3C
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.RemoveAt
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C79038 Offset: 0x2C75038 VA: 0x2C79038
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C791F0 Offset: 0x2C751F0 VA: 0x2C791F0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 23
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C79300 Offset: 0x2C75300 VA: 0x2C79300
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 14
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C793F8 Offset: 0x2C753F8 VA: 0x2C793F8
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C794F0 Offset: 0x2C754F0 VA: 0x2C794F0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C796A8 Offset: 0x2C756A8 VA: 0x2C796A8
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7972C Offset: 0x2C7572C VA: 0x2C7972C
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C79734 Offset: 0x2C75734 VA: 0x2C79734
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	private static void VerifyValueType(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C797A8 Offset: 0x2C757A8 VA: 0x2C797A8
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.VerifyValueType
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C798DC Offset: 0x2C758DC VA: 0x2C798DC
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public object get_UnderlyingCollection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C79A24 Offset: 0x2C75A24 VA: 0x2C79A24
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.get_UnderlyingCollection
	*/
}
