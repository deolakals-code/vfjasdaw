// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public class Tuple<T1, T2, T3, T4> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple // TypeDefIndex: 9685
{
	// Fields
	private readonly T1 m_Item1; // 0x0
	private readonly T2 m_Item2; // 0x0
	private readonly T3 m_Item3; // 0x0
	private readonly T4 m_Item4; // 0x0

	// Properties
	public T1 Item1 { get; }
	public T2 Item2 { get; }
	public T3 Item3 { get; }
	public T4 Item4 { get; }
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T1 get_Item1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC5298 Offset: 0x2CC1298 VA: 0x2CC5298
	|-Tuple<bool, bool, bool, bool>.get_Item1
	|
	|-RVA: 0x2CC617C Offset: 0x2CC217C VA: 0x2CC617C
	|-Tuple<int, int, int, bool>.get_Item1
	|
	|-RVA: 0x2CC765C Offset: 0x2CC365C VA: 0x2CC765C
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item1
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC52A0 Offset: 0x2CC12A0 VA: 0x2CC52A0
	|-Tuple<bool, bool, bool, bool>.get_Item2
	|
	|-RVA: 0x2CC6184 Offset: 0x2CC2184 VA: 0x2CC6184
	|-Tuple<int, int, int, bool>.get_Item2
	|
	|-RVA: 0x2CC76F4 Offset: 0x2CC36F4 VA: 0x2CC76F4
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item2
	*/

	// RVA: -1 Offset: -1
	public T3 get_Item3() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC52A8 Offset: 0x2CC12A8 VA: 0x2CC52A8
	|-Tuple<bool, bool, bool, bool>.get_Item3
	|
	|-RVA: 0x2CC618C Offset: 0x2CC218C VA: 0x2CC618C
	|-Tuple<int, int, int, bool>.get_Item3
	|
	|-RVA: 0x2CC7794 Offset: 0x2CC3794 VA: 0x2CC7794
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item3
	*/

	// RVA: -1 Offset: -1
	public T4 get_Item4() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC52B0 Offset: 0x2CC12B0 VA: 0x2CC52B0
	|-Tuple<bool, bool, bool, bool>.get_Item4
	|
	|-RVA: 0x2CC6194 Offset: 0x2CC2194 VA: 0x2CC6194
	|-Tuple<int, int, int, bool>.get_Item4
	|
	|-RVA: 0x2CC7834 Offset: 0x2CC3834 VA: 0x2CC7834
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item4
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC52B8 Offset: 0x2CC12B8 VA: 0x2CC52B8
	|-Tuple<bool, bool, bool, bool>..ctor
	|
	|-RVA: 0x2CC619C Offset: 0x2CC219C VA: 0x2CC619C
	|-Tuple<int, int, int, bool>..ctor
	|
	|-RVA: 0x2CC78D4 Offset: 0x2CC38D4 VA: 0x2CC78D4
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC5300 Offset: 0x2CC1300 VA: 0x2CC5300
	|-Tuple<bool, bool, bool, bool>.Equals
	|
	|-RVA: 0x2CC61E0 Offset: 0x2CC21E0 VA: 0x2CC61E0
	|-Tuple<int, int, int, bool>.Equals
	|
	|-RVA: 0x2CC7B08 Offset: 0x2CC3B08 VA: 0x2CC7B08
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC53D0 Offset: 0x2CC13D0 VA: 0x2CC53D0
	|-Tuple<bool, bool, bool, bool>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2CC62B0 Offset: 0x2CC22B0 VA: 0x2CC62B0
	|-Tuple<int, int, int, bool>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2CC7BD8 Offset: 0x2CC3BD8 VA: 0x2CC7BD8
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.IComparable.CompareTo(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC572C Offset: 0x2CC172C VA: 0x2CC572C
	|-Tuple<bool, bool, bool, bool>.System.IComparable.CompareTo
	|
	|-RVA: 0x2CC660C Offset: 0x2CC260C VA: 0x2CC660C
	|-Tuple<int, int, int, bool>.System.IComparable.CompareTo
	|
	|-RVA: 0x2CC8180 Offset: 0x2CC4180 VA: 0x2CC8180
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC57FC Offset: 0x2CC17FC VA: 0x2CC57FC
	|-Tuple<bool, bool, bool, bool>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2CC66DC Offset: 0x2CC26DC VA: 0x2CC66DC
	|-Tuple<int, int, int, bool>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2CC8250 Offset: 0x2CC4250 VA: 0x2CC8250
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC5BDC Offset: 0x2CC1BDC VA: 0x2CC5BDC
	|-Tuple<bool, bool, bool, bool>.GetHashCode
	|
	|-RVA: 0x2CC6ABC Offset: 0x2CC2ABC VA: 0x2CC6ABC
	|-Tuple<int, int, int, bool>.GetHashCode
	|
	|-RVA: 0x2CC8834 Offset: 0x2CC4834 VA: 0x2CC8834
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC5CA0 Offset: 0x2CC1CA0 VA: 0x2CC5CA0
	|-Tuple<bool, bool, bool, bool>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2CC6B80 Offset: 0x2CC2B80 VA: 0x2CC6B80
	|-Tuple<int, int, int, bool>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2CC88F8 Offset: 0x2CC48F8 VA: 0x2CC88F8
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC5F38 Offset: 0x2CC1F38 VA: 0x2CC5F38
	|-Tuple<bool, bool, bool, bool>.ToString
	|
	|-RVA: 0x2CC6E18 Offset: 0x2CC2E18 VA: 0x2CC6E18
	|-Tuple<int, int, int, bool>.ToString
	|
	|-RVA: 0x2CC8CB8 Offset: 0x2CC4CB8 VA: 0x2CC8CB8
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private string System.ITupleInternal.ToString(StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC6014 Offset: 0x2CC2014 VA: 0x2CC6014
	|-Tuple<bool, bool, bool, bool>.System.ITupleInternal.ToString
	|
	|-RVA: 0x2CC6EF4 Offset: 0x2CC2EF4 VA: 0x2CC6EF4
	|-Tuple<int, int, int, bool>.System.ITupleInternal.ToString
	|
	|-RVA: 0x2CC8D94 Offset: 0x2CC4D94 VA: 0x2CC8D94
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.ITupleInternal.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC6174 Offset: 0x2CC2174 VA: 0x2CC6174
	|-Tuple<bool, bool, bool, bool>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2CC7054 Offset: 0x2CC3054 VA: 0x2CC7054
	|-Tuple<int, int, int, bool>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2CC9030 Offset: 0x2CC5030 VA: 0x2CC9030
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}
