// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public struct ValueTuple<T1, T2, T3, T4> : IEquatable<ValueTuple<T1, T2, T3, T4>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4>>, IValueTupleInternal, ITuple // TypeDefIndex: 9701
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D23330 Offset: 0x2D1F330 VA: 0x2D23330
	|-ValueTuple<bool, bool, object, object>..ctor
	|
	|-RVA: 0x2D248C8 Offset: 0x2D208C8 VA: 0x2D248C8
	|-ValueTuple<int, int, int, int>..ctor
	|
	|-RVA: 0x2D25EC0 Offset: 0x2D21EC0 VA: 0x2D25EC0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D23374 Offset: 0x2D1F374 VA: 0x2D23374
	|-ValueTuple<bool, bool, object, object>.Equals
	|
	|-RVA: 0x2D248D4 Offset: 0x2D208D4 VA: 0x2D248D4
	|-ValueTuple<int, int, int, int>.Equals
	|
	|-RVA: 0x2D26238 Offset: 0x2D22238 VA: 0x2D26238
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3, T4> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D23474 Offset: 0x2D1F474 VA: 0x2D23474
	|-ValueTuple<bool, bool, object, object>.Equals
	|
	|-RVA: 0x2D249B8 Offset: 0x2D209B8 VA: 0x2D249B8
	|-ValueTuple<int, int, int, int>.Equals
	|
	|-RVA: 0x2D26384 Offset: 0x2D22384 VA: 0x2D26384
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D23590 Offset: 0x2D1F590 VA: 0x2D23590
	|-ValueTuple<bool, bool, object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D24ADC Offset: 0x2D20ADC VA: 0x2D24ADC
	|-ValueTuple<int, int, int, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D26ADC Offset: 0x2D22ADC VA: 0x2D26ADC
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D238EC Offset: 0x2D1F8EC VA: 0x2D238EC
	|-ValueTuple<bool, bool, object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D24EE0 Offset: 0x2D20EE0 VA: 0x2D24EE0
	|-ValueTuple<int, int, int, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D27278 Offset: 0x2D23278 VA: 0x2D27278
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3, T4> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D23A88 Offset: 0x2D1FA88 VA: 0x2D23A88
	|-ValueTuple<bool, bool, object, object>.CompareTo
	|
	|-RVA: 0x2D25068 Offset: 0x2D21068 VA: 0x2D25068
	|-ValueTuple<int, int, int, int>.CompareTo
	|
	|-RVA: 0x2D274C0 Offset: 0x2D234C0 VA: 0x2D274C0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D23BA0 Offset: 0x2D1FBA0 VA: 0x2D23BA0
	|-ValueTuple<bool, bool, object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D25188 Offset: 0x2D21188 VA: 0x2D25188
	|-ValueTuple<int, int, int, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D27C10 Offset: 0x2D23C10 VA: 0x2D27C10
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D23FA0 Offset: 0x2D1FFA0 VA: 0x2D23FA0
	|-ValueTuple<bool, bool, object, object>.GetHashCode
	|
	|-RVA: 0x2D25628 Offset: 0x2D21628 VA: 0x2D25628
	|-ValueTuple<int, int, int, int>.GetHashCode
	|
	|-RVA: 0x2D28460 Offset: 0x2D24460 VA: 0x2D28460
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D240D0 Offset: 0x2D200D0 VA: 0x2D240D0
	|-ValueTuple<bool, bool, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D25704 Offset: 0x2D21704 VA: 0x2D25704
	|-ValueTuple<int, int, int, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D28D14 Offset: 0x2D24D14 VA: 0x2D28D14
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24114 Offset: 0x2D20114 VA: 0x2D24114
	|-ValueTuple<bool, bool, object, object>.GetHashCodeCore
	|
	|-RVA: 0x2D25748 Offset: 0x2D21748 VA: 0x2D25748
	|-ValueTuple<int, int, int, int>.GetHashCodeCore
	|
	|-RVA: 0x2D28D9C Offset: 0x2D24D9C VA: 0x2D28D9C
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24380 Offset: 0x2D20380 VA: 0x2D24380
	|-ValueTuple<bool, bool, object, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D25A1C Offset: 0x2D21A1C VA: 0x2D25A1C
	|-ValueTuple<int, int, int, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D29278 Offset: 0x2D25278 VA: 0x2D29278
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D243C4 Offset: 0x2D203C4 VA: 0x2D243C4
	|-ValueTuple<bool, bool, object, object>.ToString
	|
	|-RVA: 0x2D25A60 Offset: 0x2D21A60 VA: 0x2D25A60
	|-ValueTuple<int, int, int, int>.ToString
	|
	|-RVA: 0x2D29300 Offset: 0x2D25300 VA: 0x2D29300
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24658 Offset: 0x2D20658 VA: 0x2D24658
	|-ValueTuple<bool, bool, object, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D25CA0 Offset: 0x2D21CA0 VA: 0x2D25CA0
	|-ValueTuple<int, int, int, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D29D10 Offset: 0x2D25D10 VA: 0x2D29D10
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D248C0 Offset: 0x2D208C0 VA: 0x2D248C0
	|-ValueTuple<bool, bool, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D25EB8 Offset: 0x2D21EB8 VA: 0x2D25EB8
	|-ValueTuple<int, int, int, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D2A6E8 Offset: 0x2D266E8 VA: 0x2D2A6E8
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}
