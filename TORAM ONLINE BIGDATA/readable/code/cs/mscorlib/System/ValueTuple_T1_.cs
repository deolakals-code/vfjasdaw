// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public struct ValueTuple<T1> : IEquatable<ValueTuple<T1>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1>>, IValueTupleInternal, ITuple // TypeDefIndex: 9698
{
	// Fields
	public T1 Item1; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D08238 Offset: 0x2D04238 VA: 0x2D08238
	|-ValueTuple<bool>..ctor
	|
	|-RVA: 0x2D08D08 Offset: 0x2D04D08 VA: 0x2D08D08
	|-ValueTuple<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D08244 Offset: 0x2D04244 VA: 0x2D08244
	|-ValueTuple<bool>.Equals
	|
	|-RVA: 0x2D08E28 Offset: 0x2D04E28 VA: 0x2D08E28
	|-ValueTuple<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D08324 Offset: 0x2D04324 VA: 0x2D08324
	|-ValueTuple<bool>.Equals
	|
	|-RVA: 0x2D08F74 Offset: 0x2D04F74 VA: 0x2D08F74
	|-ValueTuple<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D0837C Offset: 0x2D0437C VA: 0x2D0837C
	|-ValueTuple<bool>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D091C0 Offset: 0x2D051C0 VA: 0x2D091C0
	|-ValueTuple<__Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D08530 Offset: 0x2D04530 VA: 0x2D08530
	|-ValueTuple<bool>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D094C8 Offset: 0x2D054C8 VA: 0x2D094C8
	|-ValueTuple<__Il2CppFullySharedGenericType>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D086C8 Offset: 0x2D046C8 VA: 0x2D086C8
	|-ValueTuple<bool>.CompareTo
	|
	|-RVA: 0x2D09864 Offset: 0x2D05864 VA: 0x2D09864
	|-ValueTuple<__Il2CppFullySharedGenericType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D08720 Offset: 0x2D04720 VA: 0x2D08720
	|-ValueTuple<bool>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D09AA8 Offset: 0x2D05AA8 VA: 0x2D09AA8
	|-ValueTuple<__Il2CppFullySharedGenericType>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D08970 Offset: 0x2D04970 VA: 0x2D08970
	|-ValueTuple<bool>.GetHashCode
	|
	|-RVA: 0x2D09E54 Offset: 0x2D05E54 VA: 0x2D09E54
	|-ValueTuple<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D089E8 Offset: 0x2D049E8 VA: 0x2D089E8
	|-ValueTuple<bool>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D0A0A8 Offset: 0x2D060A8 VA: 0x2D0A0A8
	|-ValueTuple<__Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D08ACC Offset: 0x2D04ACC VA: 0x2D08ACC
	|-ValueTuple<bool>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D0A238 Offset: 0x2D06238 VA: 0x2D0A238
	|-ValueTuple<__Il2CppFullySharedGenericType>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D08BB0 Offset: 0x2D04BB0 VA: 0x2D08BB0
	|-ValueTuple<bool>.ToString
	|
	|-RVA: 0x2D0A3C8 Offset: 0x2D063C8 VA: 0x2D0A3C8
	|-ValueTuple<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D08C68 Offset: 0x2D04C68 VA: 0x2D08C68
	|-ValueTuple<bool>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D0A66C Offset: 0x2D0666C VA: 0x2D0A66C
	|-ValueTuple<__Il2CppFullySharedGenericType>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D08D00 Offset: 0x2D04D00 VA: 0x2D08D00
	|-ValueTuple<bool>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D0A8F4 Offset: 0x2D068F4 VA: 0x2D0A8F4
	|-ValueTuple<__Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}
