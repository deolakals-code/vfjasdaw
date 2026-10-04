// Assembly: System.Core.dll
// Namespace: System.Collections.Generic
[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class HashSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ISet<T>, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 15805
{
	// Fields
	private int[] _buckets; // 0x0
	private HashSet.Slot<T>[] _slots; // 0x0
	private int _count; // 0x0
	private int _lastIndex; // 0x0
	private int _freeList; // 0x0
	private IEqualityComparer<T> _comparer; // 0x0
	private int _version; // 0x0
	private SerializationInfo _siInfo; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	public IEqualityComparer<T> Comparer { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A13B80 Offset: 0x2A0FB80 VA: 0x2A13B80
	|-HashSet<KeyValuePair<short, short>>..ctor
	|
	|-RVA: 0x2A15B60 Offset: 0x2A11B60 VA: 0x2A15B60
	|-HashSet<byte>..ctor
	|
	|-RVA: 0x2A17AFC Offset: 0x2A13AFC VA: 0x2A17AFC
	|-HashSet<int>..ctor
	|
	|-RVA: 0x2A19A8C Offset: 0x2A15A8C VA: 0x2A19A8C
	|-HashSet<object>..ctor
	|
	|-RVA: 0x2A1BA64 Offset: 0x2A17A64 VA: 0x2A1BA64
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A13BC4 Offset: 0x2A0FBC4 VA: 0x2A13BC4
	|-HashSet<KeyValuePair<short, short>>..ctor
	|
	|-RVA: 0x2A15BA4 Offset: 0x2A11BA4 VA: 0x2A15BA4
	|-HashSet<byte>..ctor
	|
	|-RVA: 0x2A17B40 Offset: 0x2A13B40 VA: 0x2A17B40
	|-HashSet<int>..ctor
	|
	|-RVA: 0x2A19AD0 Offset: 0x2A15AD0 VA: 0x2A19AD0
	|-HashSet<object>..ctor
	|
	|-RVA: 0x2A1BAB0 Offset: 0x2A17AB0 VA: 0x2A1BAB0
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A13C24 Offset: 0x2A0FC24 VA: 0x2A13C24
	|-HashSet<KeyValuePair<short, short>>..ctor
	|
	|-RVA: 0x2A15C04 Offset: 0x2A11C04 VA: 0x2A15C04
	|-HashSet<byte>..ctor
	|
	|-RVA: 0x2A17BA0 Offset: 0x2A13BA0 VA: 0x2A17BA0
	|-HashSet<int>..ctor
	|
	|-RVA: 0x2A19B30 Offset: 0x2A15B30 VA: 0x2A19B30
	|-HashSet<object>..ctor
	|
	|-RVA: 0x2A1BB14 Offset: 0x2A17B14 VA: 0x2A1BB14
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A13C70 Offset: 0x2A0FC70 VA: 0x2A13C70
	|-HashSet<KeyValuePair<short, short>>..ctor
	|
	|-RVA: 0x2A15C50 Offset: 0x2A11C50 VA: 0x2A15C50
	|-HashSet<byte>..ctor
	|
	|-RVA: 0x2A17BEC Offset: 0x2A13BEC VA: 0x2A17BEC
	|-HashSet<int>..ctor
	|
	|-RVA: 0x2A19B7C Offset: 0x2A15B7C VA: 0x2A19B7C
	|-HashSet<object>..ctor
	|
	|-RVA: 0x2A1BB68 Offset: 0x2A17B68 VA: 0x2A1BB68
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A13E94 Offset: 0x2A0FE94 VA: 0x2A13E94
	|-HashSet<KeyValuePair<short, short>>..ctor
	|
	|-RVA: 0x2A15E74 Offset: 0x2A11E74 VA: 0x2A15E74
	|-HashSet<byte>..ctor
	|
	|-RVA: 0x2A17E10 Offset: 0x2A13E10 VA: 0x2A17E10
	|-HashSet<int>..ctor
	|
	|-RVA: 0x2A19DA0 Offset: 0x2A15DA0 VA: 0x2A19DA0
	|-HashSet<object>..ctor
	|
	|-RVA: 0x2A1BDA4 Offset: 0x2A17DA4 VA: 0x2A1BDA4
	|-HashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void CopyFrom(HashSet<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A13EC4 Offset: 0x2A0FEC4 VA: 0x2A13EC4
	|-HashSet<KeyValuePair<short, short>>.CopyFrom
	|
	|-RVA: 0x2A15EA4 Offset: 0x2A11EA4 VA: 0x2A15EA4
	|-HashSet<byte>.CopyFrom
	|
	|-RVA: 0x2A17E40 Offset: 0x2A13E40 VA: 0x2A17E40
	|-HashSet<int>.CopyFrom
	|
	|-RVA: 0x2A19DD0 Offset: 0x2A15DD0 VA: 0x2A19DD0
	|-HashSet<object>.CopyFrom
	|
	|-RVA: 0x2A1BDD4 Offset: 0x2A17DD4 VA: 0x2A1BDD4
	|-HashSet<__Il2CppFullySharedGenericType>.CopyFrom
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A1411C Offset: 0x2A1011C VA: 0x2A1411C
	|-HashSet<KeyValuePair<short, short>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2A160FC Offset: 0x2A120FC VA: 0x2A160FC
	|-HashSet<byte>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2A18098 Offset: 0x2A14098 VA: 0x2A18098
	|-HashSet<int>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2A1A028 Offset: 0x2A16028 VA: 0x2A1A028
	|-HashSet<object>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2A1C140 Offset: 0x2A18140 VA: 0x2A1C140
	|-HashSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A14130 Offset: 0x2A10130 VA: 0x2A14130
	|-HashSet<KeyValuePair<short, short>>.Clear
	|
	|-RVA: 0x2A1610C Offset: 0x2A1210C VA: 0x2A1610C
	|-HashSet<byte>.Clear
	|
	|-RVA: 0x2A180A8 Offset: 0x2A140A8 VA: 0x2A180A8
	|-HashSet<int>.Clear
	|
	|-RVA: 0x2A1A038 Offset: 0x2A16038 VA: 0x2A1A038
	|-HashSet<object>.Clear
	|
	|-RVA: 0x2A1C200 Offset: 0x2A18200 VA: 0x2A1C200
	|-HashSet<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A14190 Offset: 0x2A10190 VA: 0x2A14190
	|-HashSet<KeyValuePair<short, short>>.Contains
	|
	|-RVA: 0x2A1616C Offset: 0x2A1216C VA: 0x2A1616C
	|-HashSet<byte>.Contains
	|
	|-RVA: 0x2A18108 Offset: 0x2A14108 VA: 0x2A18108
	|-HashSet<int>.Contains
	|
	|-RVA: 0x2A1A098 Offset: 0x2A16098 VA: 0x2A1A098
	|-HashSet<object>.Contains
	|
	|-RVA: 0x2A1C260 Offset: 0x2A18260 VA: 0x2A1C260
	|-HashSet<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A14354 Offset: 0x2A10354 VA: 0x2A14354
	|-HashSet<KeyValuePair<short, short>>.CopyTo
	|
	|-RVA: 0x2A1632C Offset: 0x2A1232C VA: 0x2A1632C
	|-HashSet<byte>.CopyTo
	|
	|-RVA: 0x2A182C8 Offset: 0x2A142C8 VA: 0x2A182C8
	|-HashSet<int>.CopyTo
	|
	|-RVA: 0x2A1A250 Offset: 0x2A16250 VA: 0x2A1A250
	|-HashSet<object>.CopyTo
	|
	|-RVA: 0x2A1C5CC Offset: 0x2A185CC VA: 0x2A1C5CC
	|-HashSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A14368 Offset: 0x2A10368 VA: 0x2A14368
	|-HashSet<KeyValuePair<short, short>>.Remove
	|
	|-RVA: 0x2A16340 Offset: 0x2A12340 VA: 0x2A16340
	|-HashSet<byte>.Remove
	|
	|-RVA: 0x2A182DC Offset: 0x2A142DC VA: 0x2A182DC
	|-HashSet<int>.Remove
	|
	|-RVA: 0x2A1A264 Offset: 0x2A16264 VA: 0x2A1A264
	|-HashSet<object>.Remove
	|
	|-RVA: 0x2A1C5E4 Offset: 0x2A185E4 VA: 0x2A1C5E4
	|-HashSet<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A14618 Offset: 0x2A10618 VA: 0x2A14618
	|-HashSet<KeyValuePair<short, short>>.get_Count
	|
	|-RVA: 0x2A165F0 Offset: 0x2A125F0 VA: 0x2A165F0
	|-HashSet<byte>.get_Count
	|
	|-RVA: 0x2A1858C Offset: 0x2A1458C VA: 0x2A1858C
	|-HashSet<int>.get_Count
	|
	|-RVA: 0x2A1A4FC Offset: 0x2A164FC VA: 0x2A1A4FC
	|-HashSet<object>.get_Count
	|
	|-RVA: 0x2A1CB30 Offset: 0x2A18B30 VA: 0x2A1CB30
	|-HashSet<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A14620 Offset: 0x2A10620 VA: 0x2A14620
	|-HashSet<KeyValuePair<short, short>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2A165F8 Offset: 0x2A125F8 VA: 0x2A165F8
	|-HashSet<byte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2A18594 Offset: 0x2A14594 VA: 0x2A18594
	|-HashSet<int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2A1A504 Offset: 0x2A16504 VA: 0x2A1A504
	|-HashSet<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2A1CB38 Offset: 0x2A18B38 VA: 0x2A1CB38
	|-HashSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1
	public HashSet.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A14628 Offset: 0x2A10628 VA: 0x2A14628
	|-HashSet<KeyValuePair<short, short>>.GetEnumerator
	|
	|-RVA: 0x2A16600 Offset: 0x2A12600 VA: 0x2A16600
	|-HashSet<byte>.GetEnumerator
	|
	|-RVA: 0x2A1859C Offset: 0x2A1459C VA: 0x2A1859C
	|-HashSet<int>.GetEnumerator
	|
	|-RVA: 0x2A1A50C Offset: 0x2A1650C VA: 0x2A1A50C
	|-HashSet<object>.GetEnumerator
	|
	|-RVA: 0x2A1CB40 Offset: 0x2A18B40 VA: 0x2A1CB40
	|-HashSet<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A14648 Offset: 0x2A10648 VA: 0x2A14648
	|-HashSet<KeyValuePair<short, short>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2A16620 Offset: 0x2A12620 VA: 0x2A16620
	|-HashSet<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2A185BC Offset: 0x2A145BC VA: 0x2A185BC
	|-HashSet<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2A1A52C Offset: 0x2A1652C VA: 0x2A1A52C
	|-HashSet<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2A1CBF0 Offset: 0x2A18BF0 VA: 0x2A1CBF0
	|-HashSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A146A4 Offset: 0x2A106A4 VA: 0x2A146A4
	|-HashSet<KeyValuePair<short, short>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A1667C Offset: 0x2A1267C VA: 0x2A1667C
	|-HashSet<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A18618 Offset: 0x2A14618 VA: 0x2A18618
	|-HashSet<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A1A588 Offset: 0x2A16588 VA: 0x2A1A588
	|-HashSet<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A1CCA0 Offset: 0x2A18CA0 VA: 0x2A1CCA0
	|-HashSet<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A14700 Offset: 0x2A10700 VA: 0x2A14700
	|-HashSet<KeyValuePair<short, short>>.GetObjectData
	|
	|-RVA: 0x2A166D8 Offset: 0x2A126D8 VA: 0x2A166D8
	|-HashSet<byte>.GetObjectData
	|
	|-RVA: 0x2A18674 Offset: 0x2A14674 VA: 0x2A18674
	|-HashSet<int>.GetObjectData
	|
	|-RVA: 0x2A1A5E4 Offset: 0x2A165E4 VA: 0x2A1A5E4
	|-HashSet<object>.GetObjectData
	|
	|-RVA: 0x2A1CD50 Offset: 0x2A18D50 VA: 0x2A1CD50
	|-HashSet<__Il2CppFullySharedGenericType>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A1491C Offset: 0x2A1091C VA: 0x2A1491C
	|-HashSet<KeyValuePair<short, short>>.OnDeserialization
	|
	|-RVA: 0x2A168F4 Offset: 0x2A128F4 VA: 0x2A168F4
	|-HashSet<byte>.OnDeserialization
	|
	|-RVA: 0x2A18890 Offset: 0x2A14890 VA: 0x2A18890
	|-HashSet<int>.OnDeserialization
	|
	|-RVA: 0x2A1A800 Offset: 0x2A16800 VA: 0x2A1A800
	|-HashSet<object>.OnDeserialization
	|
	|-RVA: 0x2A1CF5C Offset: 0x2A18F5C VA: 0x2A1CF5C
	|-HashSet<__Il2CppFullySharedGenericType>.OnDeserialization
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A14CA4 Offset: 0x2A10CA4 VA: 0x2A14CA4
	|-HashSet<KeyValuePair<short, short>>.Add
	|
	|-RVA: 0x2A16C7C Offset: 0x2A12C7C VA: 0x2A16C7C
	|-HashSet<byte>.Add
	|
	|-RVA: 0x2A18C18 Offset: 0x2A14C18 VA: 0x2A18C18
	|-HashSet<int>.Add
	|
	|-RVA: 0x2A1AB88 Offset: 0x2A16B88 VA: 0x2A1AB88
	|-HashSet<object>.Add
	|
	|-RVA: 0x2A1D370 Offset: 0x2A19370 VA: 0x2A1D370
	|-HashSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void UnionWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A14CB8 Offset: 0x2A10CB8 VA: 0x2A14CB8
	|-HashSet<KeyValuePair<short, short>>.UnionWith
	|
	|-RVA: 0x2A16C8C Offset: 0x2A12C8C VA: 0x2A16C8C
	|-HashSet<byte>.UnionWith
	|
	|-RVA: 0x2A18C28 Offset: 0x2A14C28 VA: 0x2A18C28
	|-HashSet<int>.UnionWith
	|
	|-RVA: 0x2A1AB98 Offset: 0x2A16B98 VA: 0x2A1AB98
	|-HashSet<object>.UnionWith
	|
	|-RVA: 0x2A1D43C Offset: 0x2A1943C VA: 0x2A1D43C
	|-HashSet<__Il2CppFullySharedGenericType>.UnionWith
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A14FE0 Offset: 0x2A10FE0 VA: 0x2A14FE0
	|-HashSet<KeyValuePair<short, short>>.CopyTo
	|
	|-RVA: 0x2A16FB4 Offset: 0x2A12FB4 VA: 0x2A16FB4
	|-HashSet<byte>.CopyTo
	|
	|-RVA: 0x2A18F50 Offset: 0x2A14F50 VA: 0x2A18F50
	|-HashSet<int>.CopyTo
	|
	|-RVA: 0x2A1AEC0 Offset: 0x2A16EC0 VA: 0x2A1AEC0
	|-HashSet<object>.CopyTo
	|
	|-RVA: 0x2A1D840 Offset: 0x2A19840 VA: 0x2A1D840
	|-HashSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int arrayIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A14FF8 Offset: 0x2A10FF8 VA: 0x2A14FF8
	|-HashSet<KeyValuePair<short, short>>.CopyTo
	|
	|-RVA: 0x2A16FCC Offset: 0x2A12FCC VA: 0x2A16FCC
	|-HashSet<byte>.CopyTo
	|
	|-RVA: 0x2A18F68 Offset: 0x2A14F68 VA: 0x2A18F68
	|-HashSet<int>.CopyTo
	|
	|-RVA: 0x2A1AED8 Offset: 0x2A16ED8 VA: 0x2A1AED8
	|-HashSet<object>.CopyTo
	|
	|-RVA: 0x2A1D85C Offset: 0x2A1985C VA: 0x2A1D85C
	|-HashSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public IEqualityComparer<T> get_Comparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A151E8 Offset: 0x2A111E8 VA: 0x2A151E8
	|-HashSet<KeyValuePair<short, short>>.get_Comparer
	|
	|-RVA: 0x2A171BC Offset: 0x2A131BC VA: 0x2A171BC
	|-HashSet<byte>.get_Comparer
	|
	|-RVA: 0x2A1914C Offset: 0x2A1514C VA: 0x2A1914C
	|-HashSet<int>.get_Comparer
	|
	|-RVA: 0x2A1B0E8 Offset: 0x2A170E8 VA: 0x2A1B0E8
	|-HashSet<object>.get_Comparer
	|
	|-RVA: 0x2A1DB7C Offset: 0x2A19B7C VA: 0x2A1DB7C
	|-HashSet<__Il2CppFullySharedGenericType>.get_Comparer
	*/

	// RVA: -1 Offset: -1
	public void TrimExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A151F0 Offset: 0x2A111F0 VA: 0x2A151F0
	|-HashSet<KeyValuePair<short, short>>.TrimExcess
	|
	|-RVA: 0x2A171C4 Offset: 0x2A131C4 VA: 0x2A171C4
	|-HashSet<byte>.TrimExcess
	|
	|-RVA: 0x2A19154 Offset: 0x2A15154 VA: 0x2A19154
	|-HashSet<int>.TrimExcess
	|
	|-RVA: 0x2A1B0F0 Offset: 0x2A170F0 VA: 0x2A1B0F0
	|-HashSet<object>.TrimExcess
	|
	|-RVA: 0x2A1DB84 Offset: 0x2A19B84 VA: 0x2A1DB84
	|-HashSet<__Il2CppFullySharedGenericType>.TrimExcess
	*/

	// RVA: -1 Offset: -1
	private int Initialize(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A153E8 Offset: 0x2A113E8 VA: 0x2A153E8
	|-HashSet<KeyValuePair<short, short>>.Initialize
	|
	|-RVA: 0x2A173BC Offset: 0x2A133BC VA: 0x2A173BC
	|-HashSet<byte>.Initialize
	|
	|-RVA: 0x2A1934C Offset: 0x2A1534C VA: 0x2A1934C
	|-HashSet<int>.Initialize
	|
	|-RVA: 0x2A1B2F0 Offset: 0x2A172F0 VA: 0x2A1B2F0
	|-HashSet<object>.Initialize
	|
	|-RVA: 0x2A1DF14 Offset: 0x2A19F14 VA: 0x2A1DF14
	|-HashSet<__Il2CppFullySharedGenericType>.Initialize
	*/

	// RVA: -1 Offset: -1
	private void IncreaseCapacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A154C0 Offset: 0x2A114C0 VA: 0x2A154C0
	|-HashSet<KeyValuePair<short, short>>.IncreaseCapacity
	|
	|-RVA: 0x2A17494 Offset: 0x2A13494 VA: 0x2A17494
	|-HashSet<byte>.IncreaseCapacity
	|
	|-RVA: 0x2A19424 Offset: 0x2A15424 VA: 0x2A19424
	|-HashSet<int>.IncreaseCapacity
	|
	|-RVA: 0x2A1B3C8 Offset: 0x2A173C8 VA: 0x2A1B3C8
	|-HashSet<object>.IncreaseCapacity
	|
	|-RVA: 0x2A1DFEC Offset: 0x2A19FEC VA: 0x2A1DFEC
	|-HashSet<__Il2CppFullySharedGenericType>.IncreaseCapacity
	*/

	// RVA: -1 Offset: -1
	private void SetCapacity(int newSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A15588 Offset: 0x2A11588 VA: 0x2A15588
	|-HashSet<KeyValuePair<short, short>>.SetCapacity
	|
	|-RVA: 0x2A1755C Offset: 0x2A1355C VA: 0x2A1755C
	|-HashSet<byte>.SetCapacity
	|
	|-RVA: 0x2A194EC Offset: 0x2A154EC VA: 0x2A194EC
	|-HashSet<int>.SetCapacity
	|
	|-RVA: 0x2A1B490 Offset: 0x2A17490 VA: 0x2A1B490
	|-HashSet<object>.SetCapacity
	|
	|-RVA: 0x2A1E0B8 Offset: 0x2A1A0B8 VA: 0x2A1E0B8
	|-HashSet<__Il2CppFullySharedGenericType>.SetCapacity
	*/

	// RVA: -1 Offset: -1
	private bool AddIfNotPresent(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A156BC Offset: 0x2A116BC VA: 0x2A156BC
	|-HashSet<KeyValuePair<short, short>>.AddIfNotPresent
	|
	|-RVA: 0x2A17690 Offset: 0x2A13690 VA: 0x2A17690
	|-HashSet<byte>.AddIfNotPresent
	|
	|-RVA: 0x2A19620 Offset: 0x2A15620 VA: 0x2A19620
	|-HashSet<int>.AddIfNotPresent
	|
	|-RVA: 0x2A1B5C4 Offset: 0x2A175C4 VA: 0x2A1B5C4
	|-HashSet<object>.AddIfNotPresent
	|
	|-RVA: 0x2A1E268 Offset: 0x2A1A268 VA: 0x2A1E268
	|-HashSet<__Il2CppFullySharedGenericType>.AddIfNotPresent
	*/

	// RVA: -1 Offset: -1
	private void AddValue(int index, int hashCode, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A159C0 Offset: 0x2A119C0 VA: 0x2A159C0
	|-HashSet<KeyValuePair<short, short>>.AddValue
	|
	|-RVA: 0x2A1797C Offset: 0x2A1397C VA: 0x2A1797C
	|-HashSet<byte>.AddValue
	|
	|-RVA: 0x2A1990C Offset: 0x2A1590C VA: 0x2A1990C
	|-HashSet<int>.AddValue
	|
	|-RVA: 0x2A1B89C Offset: 0x2A1789C VA: 0x2A1B89C
	|-HashSet<object>.AddValue
	|
	|-RVA: 0x2A1E7D8 Offset: 0x2A1A7D8 VA: 0x2A1E7D8
	|-HashSet<__Il2CppFullySharedGenericType>.AddValue
	*/

	// RVA: -1 Offset: -1
	private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A15A58 Offset: 0x2A11A58 VA: 0x2A15A58
	|-HashSet<KeyValuePair<short, short>>.AreEqualityComparersEqual
	|
	|-RVA: 0x2A179F4 Offset: 0x2A139F4 VA: 0x2A179F4
	|-HashSet<byte>.AreEqualityComparersEqual
	|
	|-RVA: 0x2A19984 Offset: 0x2A15984 VA: 0x2A19984
	|-HashSet<int>.AreEqualityComparersEqual
	|
	|-RVA: 0x2A1B950 Offset: 0x2A17950 VA: 0x2A1B950
	|-HashSet<object>.AreEqualityComparersEqual
	|
	|-RVA: 0x2A1E9C4 Offset: 0x2A1A9C4 VA: 0x2A1E9C4
	|-HashSet<__Il2CppFullySharedGenericType>.AreEqualityComparersEqual
	*/

	// RVA: -1 Offset: -1
	private int InternalGetHashCode(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A15ABC Offset: 0x2A11ABC VA: 0x2A15ABC
	|-HashSet<KeyValuePair<short, short>>.InternalGetHashCode
	|
	|-RVA: 0x2A17A58 Offset: 0x2A13A58 VA: 0x2A17A58
	|-HashSet<byte>.InternalGetHashCode
	|
	|-RVA: 0x2A199E8 Offset: 0x2A159E8 VA: 0x2A199E8
	|-HashSet<int>.InternalGetHashCode
	|
	|-RVA: 0x2A1B9B4 Offset: 0x2A179B4 VA: 0x2A1B9B4
	|-HashSet<object>.InternalGetHashCode
	|
	|-RVA: 0x2A1EAC0 Offset: 0x2A1AAC0 VA: 0x2A1EAC0
	|-HashSet<__Il2CppFullySharedGenericType>.InternalGetHashCode
	*/
}
