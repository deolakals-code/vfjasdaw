// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public struct ValueTuple<T1, T2, T3, T4, T5> : IEquatable<ValueTuple<T1, T2, T3, T4, T5>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5>>, IValueTupleInternal, ITuple // TypeDefIndex: 9702
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0
	public T5 Item5; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D2A6F0 Offset: 0x2D266F0 VA: 0x2D2A6F0
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>..ctor
	|
	|-RVA: 0x2D2C10C Offset: 0x2D2810C VA: 0x2D2C10C
	|-ValueTuple<object, bool, bool, object, object>..ctor
	|
	|-RVA: 0x2D2D964 Offset: 0x2D29964 VA: 0x2D2D964
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D2A70C Offset: 0x2D2670C VA: 0x2D2A70C
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.Equals
	|
	|-RVA: 0x2D2C168 Offset: 0x2D28168 VA: 0x2D2C168
	|-ValueTuple<object, bool, bool, object, object>.Equals
	|
	|-RVA: 0x2D2DDA8 Offset: 0x2D29DA8 VA: 0x2D2DDA8
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3, T4, T5> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D2A7FC Offset: 0x2D267FC VA: 0x2D2A7FC
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.Equals
	|
	|-RVA: 0x2D2C258 Offset: 0x2D28258 VA: 0x2D2C258
	|-ValueTuple<object, bool, bool, object, object>.Equals
	|
	|-RVA: 0x2D2DEF4 Offset: 0x2D29EF4 VA: 0x2D2DEF4
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D2A94C Offset: 0x2D2694C VA: 0x2D2A94C
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D2C3AC Offset: 0x2D283AC VA: 0x2D2C3AC
	|-ValueTuple<object, bool, bool, object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D2E808 Offset: 0x2D2A808 VA: 0x2D2E808
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D2AE24 Offset: 0x2D26E24 VA: 0x2D2AE24
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D2C780 Offset: 0x2D28780 VA: 0x2D2C780
	|-ValueTuple<object, bool, bool, object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D2F128 Offset: 0x2D2B128 VA: 0x2D2F128
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3, T4, T5> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D2AFA8 Offset: 0x2D26FA8 VA: 0x2D2AFA8
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.CompareTo
	|
	|-RVA: 0x2D2C904 Offset: 0x2D28904 VA: 0x2D2C904
	|-ValueTuple<object, bool, bool, object, object>.CompareTo
	|
	|-RVA: 0x2D2F370 Offset: 0x2D2B370 VA: 0x2D2F370
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D2B0F4 Offset: 0x2D270F4 VA: 0x2D2B0F4
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D2CA54 Offset: 0x2D28A54 VA: 0x2D2CA54
	|-ValueTuple<object, bool, bool, object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D2FC54 Offset: 0x2D2BC54 VA: 0x2D2FC54
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D2B668 Offset: 0x2D27668 VA: 0x2D2B668
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.GetHashCode
	|
	|-RVA: 0x2D2CEC4 Offset: 0x2D28EC4 VA: 0x2D2CEC4
	|-ValueTuple<object, bool, bool, object, object>.GetHashCode
	|
	|-RVA: 0x2D3060C Offset: 0x2D2C60C VA: 0x2D3060C
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D2B7A4 Offset: 0x2D277A4 VA: 0x2D2B7A4
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D2D028 Offset: 0x2D29028 VA: 0x2D2D028
	|-ValueTuple<object, bool, bool, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D310D8 Offset: 0x2D2D0D8 VA: 0x2D310D8
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D2B7E8 Offset: 0x2D277E8 VA: 0x2D2B7E8
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.GetHashCodeCore
	|
	|-RVA: 0x2D2D06C Offset: 0x2D2906C VA: 0x2D2D06C
	|-ValueTuple<object, bool, bool, object, object>.GetHashCodeCore
	|
	|-RVA: 0x2D31160 Offset: 0x2D2D160 VA: 0x2D31160
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D2BB60 Offset: 0x2D27B60 VA: 0x2D2BB60
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D2D354 Offset: 0x2D29354 VA: 0x2D2D354
	|-ValueTuple<object, bool, bool, object, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D3174C Offset: 0x2D2D74C VA: 0x2D3174C
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D2BBA4 Offset: 0x2D27BA4 VA: 0x2D2BBA4
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.ToString
	|
	|-RVA: 0x2D2D398 Offset: 0x2D29398 VA: 0x2D2D398
	|-ValueTuple<object, bool, bool, object, object>.ToString
	|
	|-RVA: 0x2D317D4 Offset: 0x2D2D7D4 VA: 0x2D317D4
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D2BE68 Offset: 0x2D27E68 VA: 0x2D2BE68
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D2D690 Offset: 0x2D29690 VA: 0x2D2D690
	|-ValueTuple<object, bool, bool, object, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D32420 Offset: 0x2D2E420 VA: 0x2D32420
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D2C104 Offset: 0x2D28104 VA: 0x2D2C104
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D2D95C Offset: 0x2D2995C VA: 0x2D2D95C
	|-ValueTuple<object, bool, bool, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D33054 Offset: 0x2D2F054 VA: 0x2D33054
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}
