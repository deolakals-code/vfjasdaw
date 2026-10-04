// Assembly: System.dll
// Namespace: 
[Serializable]
public struct SortedSet.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback // TypeDefIndex: 14330
{
	// Fields
	private static readonly SortedSet.Node<T> s_dummyNode; // 0x0
	private SortedSet<T> _tree; // 0x0
	private int _version; // 0x0
	private Stack<SortedSet.Node<T>> _stack; // 0x0
	private SortedSet.Node<T> _current; // 0x0
	private bool _reverse; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	internal bool NotStartedOrEnded { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296A728 Offset: 0x2966728 VA: 0x296A728
	|-SortedSet.Enumerator<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x296B048 Offset: 0x2967048 VA: 0x296B048
	|-SortedSet.Enumerator<KeyValuePair<double, int>>..ctor
	|
	|-RVA: 0x297AF48 Offset: 0x2976F48 VA: 0x297AF48
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(SortedSet<T> set, bool reverse) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296A7A4 Offset: 0x29667A4 VA: 0x296A7A4
	|-SortedSet.Enumerator<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x296B0C4 Offset: 0x29670C4 VA: 0x296B0C4
	|-SortedSet.Enumerator<KeyValuePair<double, int>>..ctor
	|
	|-RVA: 0x297B00C Offset: 0x297700C VA: 0x297B00C
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296A920 Offset: 0x2966920 VA: 0x296A920
	|-SortedSet.Enumerator<KeyValuePair<byte, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x296B240 Offset: 0x2967240 VA: 0x296B240
	|-SortedSet.Enumerator<KeyValuePair<double, int>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x297B274 Offset: 0x2977274 VA: 0x297B274
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296A954 Offset: 0x2966954 VA: 0x296A954
	|-SortedSet.Enumerator<KeyValuePair<byte, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x296B274 Offset: 0x2967274 VA: 0x296B274
	|-SortedSet.Enumerator<KeyValuePair<double, int>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x297B2A8 Offset: 0x29772A8 VA: 0x297B2A8
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private void Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296A988 Offset: 0x2966988 VA: 0x296A988
	|-SortedSet.Enumerator<KeyValuePair<byte, object>>.Initialize
	|
	|-RVA: 0x296B2A8 Offset: 0x29672A8 VA: 0x296B2A8
	|-SortedSet.Enumerator<KeyValuePair<double, int>>.Initialize
	|
	|-RVA: 0x297B2DC Offset: 0x29772DC VA: 0x297B2DC
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296AAE0 Offset: 0x2966AE0 VA: 0x296AAE0
	|-SortedSet.Enumerator<KeyValuePair<byte, object>>.MoveNext
	|
	|-RVA: 0x296B400 Offset: 0x2967400 VA: 0x296B400
	|-SortedSet.Enumerator<KeyValuePair<double, int>>.MoveNext
	|
	|-RVA: 0x297B688 Offset: 0x2977688 VA: 0x297B688
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296AD34 Offset: 0x2966D34 VA: 0x296AD34
	|-SortedSet.Enumerator<KeyValuePair<byte, object>>.Dispose
	|
	|-RVA: 0x296B654 Offset: 0x2967654 VA: 0x296B654
	|-SortedSet.Enumerator<KeyValuePair<double, int>>.Dispose
	|
	|-RVA: 0x297BC08 Offset: 0x2977C08 VA: 0x297BC08
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296AD38 Offset: 0x2966D38 VA: 0x296AD38
	|-SortedSet.Enumerator<KeyValuePair<byte, object>>.get_Current
	|
	|-RVA: 0x296B658 Offset: 0x2967658 VA: 0x296B658
	|-SortedSet.Enumerator<KeyValuePair<double, int>>.get_Current
	|
	|-RVA: 0x297BC0C Offset: 0x2977C0C VA: 0x297BC0C
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296AD6C Offset: 0x2966D6C VA: 0x296AD6C
	|-SortedSet.Enumerator<KeyValuePair<byte, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296B68C Offset: 0x296768C VA: 0x296B68C
	|-SortedSet.Enumerator<KeyValuePair<double, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297BD6C Offset: 0x2977D6C VA: 0x297BD6C
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1
	internal bool get_NotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296AE10 Offset: 0x2966E10 VA: 0x296AE10
	|-SortedSet.Enumerator<KeyValuePair<byte, object>>.get_NotStartedOrEnded
	|
	|-RVA: 0x296B730 Offset: 0x2967730 VA: 0x296B730
	|-SortedSet.Enumerator<KeyValuePair<double, int>>.get_NotStartedOrEnded
	|
	|-RVA: 0x297BECC Offset: 0x2977ECC VA: 0x297BECC
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.get_NotStartedOrEnded
	*/

	// RVA: -1 Offset: -1
	internal void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296AE20 Offset: 0x2966E20 VA: 0x296AE20
	|-SortedSet.Enumerator<KeyValuePair<byte, object>>.Reset
	|
	|-RVA: 0x296B740 Offset: 0x2967740 VA: 0x296B740
	|-SortedSet.Enumerator<KeyValuePair<double, int>>.Reset
	|
	|-RVA: 0x297BEDC Offset: 0x2977EDC VA: 0x297BEDC
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296AF08 Offset: 0x2966F08 VA: 0x296AF08
	|-SortedSet.Enumerator<KeyValuePair<byte, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296B828 Offset: 0x2967828 VA: 0x296B828
	|-SortedSet.Enumerator<KeyValuePair<double, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297C044 Offset: 0x2978044 VA: 0x297C044
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296AF78 Offset: 0x2966F78 VA: 0x296AF78
	|-SortedSet.Enumerator<KeyValuePair<byte, object>>..cctor
	|
	|-RVA: 0x296B898 Offset: 0x2967898 VA: 0x296B898
	|-SortedSet.Enumerator<KeyValuePair<double, int>>..cctor
	|
	|-RVA: 0x297C0F4 Offset: 0x29780F4 VA: 0x297C0F4
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>..cctor
	*/
}
