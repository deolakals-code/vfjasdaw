// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public struct ValueTuple<T1, T2, T3> : IEquatable<ValueTuple<T1, T2, T3>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3>>, IValueTupleInternal, ITuple // TypeDefIndex: 9700
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D1A5BC Offset: 0x2D165BC VA: 0x2D1A5BC
	|-ValueTuple<short, int, int>..ctor
	|
	|-RVA: 0x2D1B84C Offset: 0x2D1784C VA: 0x2D1B84C
	|-ValueTuple<object, int, int>..ctor
	|
	|-RVA: 0x2D1CA20 Offset: 0x2D18A20 VA: 0x2D1CA20
	|-ValueTuple<object, object, int>..ctor
	|
	|-RVA: 0x2D1DB48 Offset: 0x2D19B48 VA: 0x2D1DB48
	|-ValueTuple<object, object, object>..ctor
	|
	|-RVA: 0x2D1FA48 Offset: 0x2D1BA48 VA: 0x2D1FA48
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D1A5C8 Offset: 0x2D165C8 VA: 0x2D1A5C8
	|-ValueTuple<short, int, int>.Equals
	|
	|-RVA: 0x2D1B878 Offset: 0x2D17878 VA: 0x2D1B878
	|-ValueTuple<object, int, int>.Equals
	|
	|-RVA: 0x2D1CA5C Offset: 0x2D18A5C VA: 0x2D1CA5C
	|-ValueTuple<object, object, int>.Equals
	|
	|-RVA: 0x2D1DB8C Offset: 0x2D19B8C VA: 0x2D1DB8C
	|-ValueTuple<object, object, object>.Equals
	|
	|-RVA: 0x2D1FCF8 Offset: 0x2D1BCF8 VA: 0x2D1FCF8
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D1A6B0 Offset: 0x2D166B0 VA: 0x2D1A6B0
	|-ValueTuple<short, int, int>.Equals
	|
	|-RVA: 0x2D1B95C Offset: 0x2D1795C VA: 0x2D1B95C
	|-ValueTuple<object, int, int>.Equals
	|
	|-RVA: 0x2D1CB5C Offset: 0x2D18B5C VA: 0x2D1CB5C
	|-ValueTuple<object, object, int>.Equals
	|
	|-RVA: 0x2D1DC8C Offset: 0x2D19C8C VA: 0x2D1DC8C
	|-ValueTuple<object, object, object>.Equals
	|
	|-RVA: 0x2D1FE44 Offset: 0x2D1BE44 VA: 0x2D1FE44
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D1A79C Offset: 0x2D1679C VA: 0x2D1A79C
	|-ValueTuple<short, int, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D1BA48 Offset: 0x2D17A48 VA: 0x2D1BA48
	|-ValueTuple<object, int, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D1CC38 Offset: 0x2D18C38 VA: 0x2D1CC38
	|-ValueTuple<object, object, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D1DD68 Offset: 0x2D19D68 VA: 0x2D1DD68
	|-ValueTuple<object, object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D203F8 Offset: 0x2D1C3F8 VA: 0x2D203F8
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D1AAD8 Offset: 0x2D16AD8 VA: 0x2D1AAD8
	|-ValueTuple<short, int, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D1BD2C Offset: 0x2D17D2C VA: 0x2D1BD2C
	|-ValueTuple<object, int, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D1CEC4 Offset: 0x2D18EC4 VA: 0x2D1CEC4
	|-ValueTuple<object, object, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D1DF9C Offset: 0x2D19F9C VA: 0x2D1DF9C
	|-ValueTuple<object, object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D20A10 Offset: 0x2D1CA10 VA: 0x2D20A10
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D1AC6C Offset: 0x2D16C6C VA: 0x2D1AC6C
	|-ValueTuple<short, int, int>.CompareTo
	|
	|-RVA: 0x2D1BEB4 Offset: 0x2D17EB4 VA: 0x2D1BEB4
	|-ValueTuple<object, int, int>.CompareTo
	|
	|-RVA: 0x2D1D060 Offset: 0x2D19060 VA: 0x2D1D060
	|-ValueTuple<object, object, int>.CompareTo
	|
	|-RVA: 0x2D1E138 Offset: 0x2D1A138 VA: 0x2D1E138
	|-ValueTuple<object, object, object>.CompareTo
	|
	|-RVA: 0x2D20C58 Offset: 0x2D1CC58 VA: 0x2D20C58
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D1AD54 Offset: 0x2D16D54 VA: 0x2D1AD54
	|-ValueTuple<short, int, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D1BF9C Offset: 0x2D17F9C VA: 0x2D1BF9C
	|-ValueTuple<object, int, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D1D138 Offset: 0x2D19138 VA: 0x2D1D138
	|-ValueTuple<object, object, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D1E210 Offset: 0x2D1A210 VA: 0x2D1E210
	|-ValueTuple<object, object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D211F4 Offset: 0x2D1D1F4 VA: 0x2D211F4
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D1B13C Offset: 0x2D1713C VA: 0x2D1B13C
	|-ValueTuple<short, int, int>.GetHashCode
	|
	|-RVA: 0x2D1C324 Offset: 0x2D18324 VA: 0x2D1C324
	|-ValueTuple<object, int, int>.GetHashCode
	|
	|-RVA: 0x2D1D470 Offset: 0x2D19470 VA: 0x2D1D470
	|-ValueTuple<object, object, int>.GetHashCode
	|
	|-RVA: 0x2D1E4FC Offset: 0x2D1A4FC VA: 0x2D1E4FC
	|-ValueTuple<object, object, object>.GetHashCode
	|
	|-RVA: 0x2D218B8 Offset: 0x2D1D8B8 VA: 0x2D218B8
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D1B1EC Offset: 0x2D171EC VA: 0x2D1B1EC
	|-ValueTuple<short, int, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D1C3D8 Offset: 0x2D183D8 VA: 0x2D1C3D8
	|-ValueTuple<object, int, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D1D524 Offset: 0x2D19524 VA: 0x2D1D524
	|-ValueTuple<object, object, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D1E5B0 Offset: 0x2D1A5B0 VA: 0x2D1E5B0
	|-ValueTuple<object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D21F34 Offset: 0x2D1DF34 VA: 0x2D21F34
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D1B230 Offset: 0x2D17230 VA: 0x2D1B230
	|-ValueTuple<short, int, int>.GetHashCodeCore
	|
	|-RVA: 0x2D1C41C Offset: 0x2D1841C VA: 0x2D1C41C
	|-ValueTuple<object, int, int>.GetHashCodeCore
	|
	|-RVA: 0x2D1D568 Offset: 0x2D19568 VA: 0x2D1D568
	|-ValueTuple<object, object, int>.GetHashCodeCore
	|
	|-RVA: 0x2D1E5E8 Offset: 0x2D1A5E8 VA: 0x2D1E5E8
	|-ValueTuple<object, object, object>.GetHashCodeCore
	|
	|-RVA: 0x2D21FBC Offset: 0x2D1DFBC VA: 0x2D21FBC
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D1B468 Offset: 0x2D17468 VA: 0x2D1B468
	|-ValueTuple<short, int, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D1C624 Offset: 0x2D18624 VA: 0x2D1C624
	|-ValueTuple<object, int, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D1D740 Offset: 0x2D19740 VA: 0x2D1D740
	|-ValueTuple<object, object, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D1E780 Offset: 0x2D1A780 VA: 0x2D1E780
	|-ValueTuple<object, object, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D22380 Offset: 0x2D1E380 VA: 0x2D22380
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D1B4AC Offset: 0x2D174AC VA: 0x2D1B4AC
	|-ValueTuple<short, int, int>.ToString
	|
	|-RVA: 0x2D1C668 Offset: 0x2D18668 VA: 0x2D1C668
	|-ValueTuple<object, int, int>.ToString
	|
	|-RVA: 0x2D1D784 Offset: 0x2D19784 VA: 0x2D1D784
	|-ValueTuple<object, object, int>.ToString
	|
	|-RVA: 0x2D1E7B8 Offset: 0x2D1A7B8 VA: 0x2D1E7B8
	|-ValueTuple<object, object, object>.ToString
	|
	|-RVA: 0x2D22408 Offset: 0x2D1E408 VA: 0x2D22408
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D1B68C Offset: 0x2D1768C VA: 0x2D1B68C
	|-ValueTuple<short, int, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D1C858 Offset: 0x2D18858 VA: 0x2D1C858
	|-ValueTuple<object, int, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D1D978 Offset: 0x2D19978 VA: 0x2D1D978
	|-ValueTuple<object, object, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D1E9B0 Offset: 0x2D1A9B0 VA: 0x2D1E9B0
	|-ValueTuple<object, object, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D22BB0 Offset: 0x2D1EBB0 VA: 0x2D22BB0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D1B844 Offset: 0x2D17844 VA: 0x2D1B844
	|-ValueTuple<short, int, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D1CA18 Offset: 0x2D18A18 VA: 0x2D1CA18
	|-ValueTuple<object, int, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D1DB40 Offset: 0x2D19B40 VA: 0x2D1DB40
	|-ValueTuple<object, object, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D1EB7C Offset: 0x2D1AB7C VA: 0x2D1EB7C
	|-ValueTuple<object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D23328 Offset: 0x2D1F328 VA: 0x2D23328
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}
