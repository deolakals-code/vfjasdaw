// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public class Tuple<T1, T2, T3> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple // TypeDefIndex: 9684
{
	// Fields
	private readonly T1 m_Item1; // 0x0
	private readonly T2 m_Item2; // 0x0
	private readonly T3 m_Item3; // 0x0

	// Properties
	public T1 Item1 { get; }
	public T2 Item2 { get; }
	public T3 Item3 { get; }
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T1 get_Item1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC2784 Offset: 0x2CBE784 VA: 0x2CC2784
	|-Tuple<object, Memory<byte>, object>.get_Item1
	|
	|-RVA: 0x2CC3304 Offset: 0x2CBF304 VA: 0x2CC3304
	|-Tuple<object, object, object>.get_Item1
	|
	|-RVA: 0x2CC3DA4 Offset: 0x2CBFDA4 VA: 0x2CC3DA4
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item1
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC278C Offset: 0x2CBE78C VA: 0x2CC278C
	|-Tuple<object, Memory<byte>, object>.get_Item2
	|
	|-RVA: 0x2CC330C Offset: 0x2CBF30C VA: 0x2CC330C
	|-Tuple<object, object, object>.get_Item2
	|
	|-RVA: 0x2CC3E3C Offset: 0x2CBFE3C VA: 0x2CC3E3C
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item2
	*/

	// RVA: -1 Offset: -1
	public T3 get_Item3() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC2798 Offset: 0x2CBE798 VA: 0x2CC2798
	|-Tuple<object, Memory<byte>, object>.get_Item3
	|
	|-RVA: 0x2CC3314 Offset: 0x2CBF314 VA: 0x2CC3314
	|-Tuple<object, object, object>.get_Item3
	|
	|-RVA: 0x2CC3EDC Offset: 0x2CBFEDC VA: 0x2CC3EDC
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item3
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC27A0 Offset: 0x2CBE7A0 VA: 0x2CC27A0
	|-Tuple<object, Memory<byte>, object>..ctor
	|
	|-RVA: 0x2CC331C Offset: 0x2CBF31C VA: 0x2CC331C
	|-Tuple<object, object, object>..ctor
	|
	|-RVA: 0x2CC3F7C Offset: 0x2CBFF7C VA: 0x2CC3F7C
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC2808 Offset: 0x2CBE808 VA: 0x2CC2808
	|-Tuple<object, Memory<byte>, object>.Equals
	|
	|-RVA: 0x2CC337C Offset: 0x2CBF37C VA: 0x2CC337C
	|-Tuple<object, object, object>.Equals
	|
	|-RVA: 0x2CC4138 Offset: 0x2CC0138 VA: 0x2CC4138
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC28D8 Offset: 0x2CBE8D8 VA: 0x2CC28D8
	|-Tuple<object, Memory<byte>, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2CC344C Offset: 0x2CBF44C VA: 0x2CC344C
	|-Tuple<object, object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2CC4208 Offset: 0x2CC0208 VA: 0x2CC4208
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.IComparable.CompareTo(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC2B18 Offset: 0x2CBEB18 VA: 0x2CC2B18
	|-Tuple<object, Memory<byte>, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x2CC3650 Offset: 0x2CBF650 VA: 0x2CC3650
	|-Tuple<object, object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x2CC464C Offset: 0x2CC064C VA: 0x2CC464C
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC2BE8 Offset: 0x2CBEBE8 VA: 0x2CC2BE8
	|-Tuple<object, Memory<byte>, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2CC3720 Offset: 0x2CBF720 VA: 0x2CC3720
	|-Tuple<object, object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2CC471C Offset: 0x2CC071C VA: 0x2CC471C
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC2EA8 Offset: 0x2CBEEA8 VA: 0x2CC2EA8
	|-Tuple<object, Memory<byte>, object>.GetHashCode
	|
	|-RVA: 0x2CC39AC Offset: 0x2CBF9AC VA: 0x2CC39AC
	|-Tuple<object, object, object>.GetHashCode
	|
	|-RVA: 0x2CC4BE8 Offset: 0x2CC0BE8 VA: 0x2CC4BE8
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC2F6C Offset: 0x2CBEF6C VA: 0x2CC2F6C
	|-Tuple<object, Memory<byte>, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2CC3A70 Offset: 0x2CBFA70 VA: 0x2CC3A70
	|-Tuple<object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2CC4CAC Offset: 0x2CC0CAC VA: 0x2CC4CAC
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3134 Offset: 0x2CBF134 VA: 0x2CC3134
	|-Tuple<object, Memory<byte>, object>.ToString
	|
	|-RVA: 0x2CC3C08 Offset: 0x2CBFC08 VA: 0x2CC3C08
	|-Tuple<object, object, object>.ToString
	|
	|-RVA: 0x2CC4F9C Offset: 0x2CC0F9C VA: 0x2CC4F9C
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private string System.ITupleInternal.ToString(StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC3210 Offset: 0x2CBF210 VA: 0x2CC3210
	|-Tuple<object, Memory<byte>, object>.System.ITupleInternal.ToString
	|
	|-RVA: 0x2CC3CE4 Offset: 0x2CBFCE4 VA: 0x2CC3CE4
	|-Tuple<object, object, object>.System.ITupleInternal.ToString
	|
	|-RVA: 0x2CC5078 Offset: 0x2CC1078 VA: 0x2CC5078
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.ITupleInternal.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC32FC Offset: 0x2CBF2FC VA: 0x2CC32FC
	|-Tuple<object, Memory<byte>, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2CC3D9C Offset: 0x2CBFD9C VA: 0x2CC3D9C
	|-Tuple<object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2CC5290 Offset: 0x2CC1290 VA: 0x2CC5290
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}
