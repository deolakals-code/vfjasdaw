// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public struct ValueTuple<T1, T2> : IEquatable<ValueTuple<T1, T2>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2>>, IValueTupleInternal, ITuple // TypeDefIndex: 9699
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D0A8FC Offset: 0x2D068FC VA: 0x2D0A8FC
	|-ValueTuple<bool, bool>..ctor
	|
	|-RVA: 0x2D0B7E8 Offset: 0x2D077E8 VA: 0x2D0B7E8
	|-ValueTuple<bool, object>..ctor
	|
	|-RVA: 0x2D0C5E0 Offset: 0x2D085E0 VA: 0x2D0C5E0
	|-ValueTuple<byte, byte>..ctor
	|
	|-RVA: 0x2D0D40C Offset: 0x2D0940C VA: 0x2D0D40C
	|-ValueTuple<short, short>..ctor
	|
	|-RVA: 0x2D0E238 Offset: 0x2D0A238 VA: 0x2D0E238
	|-ValueTuple<int, bool>..ctor
	|
	|-RVA: 0x2D0F0D8 Offset: 0x2D0B0D8 VA: 0x2D0F0D8
	|-ValueTuple<int, int>..ctor
	|
	|-RVA: 0x2D0FEF8 Offset: 0x2D0BEF8 VA: 0x2D0FEF8
	|-ValueTuple<int, object>..ctor
	|
	|-RVA: 0x2D10C68 Offset: 0x2D0CC68 VA: 0x2D10C68
	|-ValueTuple<Int32Enum, float>..ctor
	|
	|-RVA: 0x2D11AE4 Offset: 0x2D0DAE4 VA: 0x2D11AE4
	|-ValueTuple<object, bool>..ctor
	|
	|-RVA: 0x2D1290C Offset: 0x2D0E90C VA: 0x2D1290C
	|-ValueTuple<object, byte>..ctor
	|
	|-RVA: 0x2D136AC Offset: 0x2D0F6AC VA: 0x2D136AC
	|-ValueTuple<object, object>..ctor
	|
	|-RVA: 0x2D14364 Offset: 0x2D10364 VA: 0x2D14364
	|-ValueTuple<object, float>..ctor
	|
	|-RVA: 0x2D1511C Offset: 0x2D1111C VA: 0x2D1511C
	|-ValueTuple<float, object>..ctor
	|
	|-RVA: 0x2D15EA0 Offset: 0x2D11EA0 VA: 0x2D15EA0
	|-ValueTuple<float, float>..ctor
	|
	|-RVA: 0x2D16D08 Offset: 0x2D12D08 VA: 0x2D16D08
	|-ValueTuple<Vector3, Vector3>..ctor
	|
	|-RVA: 0x2D17C78 Offset: 0x2D13C78 VA: 0x2D17C78
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D0A910 Offset: 0x2D06910 VA: 0x2D0A910
	|-ValueTuple<bool, bool>.Equals
	|
	|-RVA: 0x2D0B7FC Offset: 0x2D077FC VA: 0x2D0B7FC
	|-ValueTuple<bool, object>.Equals
	|
	|-RVA: 0x2D0C5EC Offset: 0x2D085EC VA: 0x2D0C5EC
	|-ValueTuple<byte, byte>.Equals
	|
	|-RVA: 0x2D0D418 Offset: 0x2D09418 VA: 0x2D0D418
	|-ValueTuple<short, short>.Equals
	|
	|-RVA: 0x2D0E248 Offset: 0x2D0A248 VA: 0x2D0E248
	|-ValueTuple<int, bool>.Equals
	|
	|-RVA: 0x2D0F0E0 Offset: 0x2D0B0E0 VA: 0x2D0F0E0
	|-ValueTuple<int, int>.Equals
	|
	|-RVA: 0x2D0FF08 Offset: 0x2D0BF08 VA: 0x2D0FF08
	|-ValueTuple<int, object>.Equals
	|
	|-RVA: 0x2D10C74 Offset: 0x2D0CC74 VA: 0x2D10C74
	|-ValueTuple<Int32Enum, float>.Equals
	|
	|-RVA: 0x2D11B0C Offset: 0x2D0DB0C VA: 0x2D11B0C
	|-ValueTuple<object, bool>.Equals
	|
	|-RVA: 0x2D12934 Offset: 0x2D0E934 VA: 0x2D12934
	|-ValueTuple<object, byte>.Equals
	|
	|-RVA: 0x2D136DC Offset: 0x2D0F6DC VA: 0x2D136DC
	|-ValueTuple<object, object>.Equals
	|
	|-RVA: 0x2D1438C Offset: 0x2D1038C VA: 0x2D1438C
	|-ValueTuple<object, float>.Equals
	|
	|-RVA: 0x2D15128 Offset: 0x2D11128 VA: 0x2D15128
	|-ValueTuple<float, object>.Equals
	|
	|-RVA: 0x2D15EA8 Offset: 0x2D11EA8 VA: 0x2D15EA8
	|-ValueTuple<float, float>.Equals
	|
	|-RVA: 0x2D16D18 Offset: 0x2D12D18 VA: 0x2D16D18
	|-ValueTuple<Vector3, Vector3>.Equals
	|
	|-RVA: 0x2D17E5C Offset: 0x2D13E5C VA: 0x2D17E5C
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D0A9F0 Offset: 0x2D069F0 VA: 0x2D0A9F0
	|-ValueTuple<bool, bool>.Equals
	|
	|-RVA: 0x2D0B8E0 Offset: 0x2D078E0 VA: 0x2D0B8E0
	|-ValueTuple<bool, object>.Equals
	|
	|-RVA: 0x2D0C6CC Offset: 0x2D086CC VA: 0x2D0C6CC
	|-ValueTuple<byte, byte>.Equals
	|
	|-RVA: 0x2D0D4F8 Offset: 0x2D094F8 VA: 0x2D0D4F8
	|-ValueTuple<short, short>.Equals
	|
	|-RVA: 0x2D0E328 Offset: 0x2D0A328 VA: 0x2D0E328
	|-ValueTuple<int, bool>.Equals
	|
	|-RVA: 0x2D0F1C0 Offset: 0x2D0B1C0 VA: 0x2D0F1C0
	|-ValueTuple<int, int>.Equals
	|
	|-RVA: 0x2D0FFEC Offset: 0x2D0BFEC VA: 0x2D0FFEC
	|-ValueTuple<int, object>.Equals
	|
	|-RVA: 0x2D10D54 Offset: 0x2D0CD54 VA: 0x2D10D54
	|-ValueTuple<Int32Enum, float>.Equals
	|
	|-RVA: 0x2D11BF0 Offset: 0x2D0DBF0 VA: 0x2D11BF0
	|-ValueTuple<object, bool>.Equals
	|
	|-RVA: 0x2D12A18 Offset: 0x2D0EA18 VA: 0x2D12A18
	|-ValueTuple<object, byte>.Equals
	|
	|-RVA: 0x2D137C0 Offset: 0x2D0F7C0 VA: 0x2D137C0
	|-ValueTuple<object, object>.Equals
	|
	|-RVA: 0x2D14470 Offset: 0x2D10470 VA: 0x2D14470
	|-ValueTuple<object, float>.Equals
	|
	|-RVA: 0x2D1520C Offset: 0x2D1120C VA: 0x2D1520C
	|-ValueTuple<float, object>.Equals
	|
	|-RVA: 0x2D15F98 Offset: 0x2D11F98 VA: 0x2D15F98
	|-ValueTuple<float, float>.Equals
	|
	|-RVA: 0x2D16E18 Offset: 0x2D12E18 VA: 0x2D16E18
	|-ValueTuple<Vector3, Vector3>.Equals
	|
	|-RVA: 0x2D17FA8 Offset: 0x2D13FA8 VA: 0x2D17FA8
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D0AA94 Offset: 0x2D06A94 VA: 0x2D0AA94
	|-ValueTuple<bool, bool>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D0B994 Offset: 0x2D07994 VA: 0x2D0B994
	|-ValueTuple<bool, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D0C770 Offset: 0x2D08770 VA: 0x2D0C770
	|-ValueTuple<byte, byte>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D0D59C Offset: 0x2D0959C VA: 0x2D0D59C
	|-ValueTuple<short, short>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D0E3CC Offset: 0x2D0A3CC VA: 0x2D0E3CC
	|-ValueTuple<int, bool>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D0F264 Offset: 0x2D0B264 VA: 0x2D0F264
	|-ValueTuple<int, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D100A0 Offset: 0x2D0C0A0 VA: 0x2D100A0
	|-ValueTuple<int, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D10DFC Offset: 0x2D0CDFC VA: 0x2D10DFC
	|-ValueTuple<Int32Enum, float>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D11CA4 Offset: 0x2D0DCA4 VA: 0x2D11CA4
	|-ValueTuple<object, bool>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D12ACC Offset: 0x2D0EACC VA: 0x2D12ACC
	|-ValueTuple<object, byte>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D13874 Offset: 0x2D0F874 VA: 0x2D13874
	|-ValueTuple<object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D14524 Offset: 0x2D10524 VA: 0x2D14524
	|-ValueTuple<object, float>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D152C0 Offset: 0x2D112C0 VA: 0x2D152C0
	|-ValueTuple<float, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D1604C Offset: 0x2D1204C VA: 0x2D1604C
	|-ValueTuple<float, float>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D16ECC Offset: 0x2D12ECC VA: 0x2D16ECC
	|-ValueTuple<Vector3, Vector3>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2D183A0 Offset: 0x2D143A0 VA: 0x2D183A0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D0AD18 Offset: 0x2D06D18 VA: 0x2D0AD18
	|-ValueTuple<bool, bool>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D0BBB0 Offset: 0x2D07BB0 VA: 0x2D0BBB0
	|-ValueTuple<bool, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D0C9EC Offset: 0x2D089EC VA: 0x2D0C9EC
	|-ValueTuple<byte, byte>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D0D818 Offset: 0x2D09818 VA: 0x2D0D818
	|-ValueTuple<short, short>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D0E648 Offset: 0x2D0A648 VA: 0x2D0E648
	|-ValueTuple<int, bool>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D0F4DC Offset: 0x2D0B4DC VA: 0x2D0F4DC
	|-ValueTuple<int, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D102BC Offset: 0x2D0C2BC VA: 0x2D102BC
	|-ValueTuple<int, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D11080 Offset: 0x2D0D080 VA: 0x2D11080
	|-ValueTuple<Int32Enum, float>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D11EC8 Offset: 0x2D0DEC8 VA: 0x2D11EC8
	|-ValueTuple<object, bool>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D12CEC Offset: 0x2D0ECEC VA: 0x2D12CEC
	|-ValueTuple<object, byte>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D13A3C Offset: 0x2D0FA3C VA: 0x2D13A3C
	|-ValueTuple<object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D14750 Offset: 0x2D10750 VA: 0x2D14750
	|-ValueTuple<object, float>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D154EC Offset: 0x2D114EC VA: 0x2D154EC
	|-ValueTuple<float, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D162C4 Offset: 0x2D122C4 VA: 0x2D162C4
	|-ValueTuple<float, float>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D17188 Offset: 0x2D13188 VA: 0x2D17188
	|-ValueTuple<Vector3, Vector3>.System.IComparable.CompareTo
	|
	|-RVA: 0x2D18834 Offset: 0x2D14834 VA: 0x2D18834
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D0AE9C Offset: 0x2D06E9C VA: 0x2D0AE9C
	|-ValueTuple<bool, bool>.CompareTo
	|
	|-RVA: 0x2D0BD38 Offset: 0x2D07D38 VA: 0x2D0BD38
	|-ValueTuple<bool, object>.CompareTo
	|
	|-RVA: 0x2D0CB70 Offset: 0x2D08B70 VA: 0x2D0CB70
	|-ValueTuple<byte, byte>.CompareTo
	|
	|-RVA: 0x2D0D99C Offset: 0x2D0999C VA: 0x2D0D99C
	|-ValueTuple<short, short>.CompareTo
	|
	|-RVA: 0x2D0E7CC Offset: 0x2D0A7CC VA: 0x2D0E7CC
	|-ValueTuple<int, bool>.CompareTo
	|
	|-RVA: 0x2D0F660 Offset: 0x2D0B660 VA: 0x2D0F660
	|-ValueTuple<int, int>.CompareTo
	|
	|-RVA: 0x2D10444 Offset: 0x2D0C444 VA: 0x2D10444
	|-ValueTuple<int, object>.CompareTo
	|
	|-RVA: 0x2D11204 Offset: 0x2D0D204 VA: 0x2D11204
	|-ValueTuple<Int32Enum, float>.CompareTo
	|
	|-RVA: 0x2D12050 Offset: 0x2D0E050 VA: 0x2D12050
	|-ValueTuple<object, bool>.CompareTo
	|
	|-RVA: 0x2D12E74 Offset: 0x2D0EE74 VA: 0x2D12E74
	|-ValueTuple<object, byte>.CompareTo
	|
	|-RVA: 0x2D13BC4 Offset: 0x2D0FBC4 VA: 0x2D13BC4
	|-ValueTuple<object, object>.CompareTo
	|
	|-RVA: 0x2D148D8 Offset: 0x2D108D8 VA: 0x2D148D8
	|-ValueTuple<object, float>.CompareTo
	|
	|-RVA: 0x2D15674 Offset: 0x2D11674 VA: 0x2D15674
	|-ValueTuple<float, object>.CompareTo
	|
	|-RVA: 0x2D16458 Offset: 0x2D12458 VA: 0x2D16458
	|-ValueTuple<float, float>.CompareTo
	|
	|-RVA: 0x2D17324 Offset: 0x2D13324 VA: 0x2D17324
	|-ValueTuple<Vector3, Vector3>.CompareTo
	|
	|-RVA: 0x2D18A7C Offset: 0x2D14A7C VA: 0x2D18A7C
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D0AF3C Offset: 0x2D06F3C VA: 0x2D0AF3C
	|-ValueTuple<bool, bool>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D0BDE8 Offset: 0x2D07DE8 VA: 0x2D0BDE8
	|-ValueTuple<bool, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D0CC10 Offset: 0x2D08C10 VA: 0x2D0CC10
	|-ValueTuple<byte, byte>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D0DA3C Offset: 0x2D09A3C VA: 0x2D0DA3C
	|-ValueTuple<short, short>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D0E86C Offset: 0x2D0A86C VA: 0x2D0E86C
	|-ValueTuple<int, bool>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D0F700 Offset: 0x2D0B700 VA: 0x2D0F700
	|-ValueTuple<int, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D104F4 Offset: 0x2D0C4F4 VA: 0x2D104F4
	|-ValueTuple<int, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D112A8 Offset: 0x2D0D2A8 VA: 0x2D112A8
	|-ValueTuple<Int32Enum, float>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D12100 Offset: 0x2D0E100 VA: 0x2D12100
	|-ValueTuple<object, bool>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D12F24 Offset: 0x2D0EF24 VA: 0x2D12F24
	|-ValueTuple<object, byte>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D13C74 Offset: 0x2D0FC74 VA: 0x2D13C74
	|-ValueTuple<object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D14988 Offset: 0x2D10988 VA: 0x2D14988
	|-ValueTuple<object, float>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D15724 Offset: 0x2D11724 VA: 0x2D15724
	|-ValueTuple<float, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D16508 Offset: 0x2D12508 VA: 0x2D16508
	|-ValueTuple<float, float>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D173D4 Offset: 0x2D133D4 VA: 0x2D173D4
	|-ValueTuple<Vector3, Vector3>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2D18E68 Offset: 0x2D14E68 VA: 0x2D18E68
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D0B25C Offset: 0x2D0725C VA: 0x2D0B25C
	|-ValueTuple<bool, bool>.GetHashCode
	|
	|-RVA: 0x2D0C0A8 Offset: 0x2D080A8 VA: 0x2D0C0A8
	|-ValueTuple<bool, object>.GetHashCode
	|
	|-RVA: 0x2D0CF28 Offset: 0x2D08F28 VA: 0x2D0CF28
	|-ValueTuple<byte, byte>.GetHashCode
	|
	|-RVA: 0x2D0DD54 Offset: 0x2D09D54 VA: 0x2D0DD54
	|-ValueTuple<short, short>.GetHashCode
	|
	|-RVA: 0x2D0EB84 Offset: 0x2D0AB84 VA: 0x2D0EB84
	|-ValueTuple<int, bool>.GetHashCode
	|
	|-RVA: 0x2D0FA14 Offset: 0x2D0BA14 VA: 0x2D0FA14
	|-ValueTuple<int, int>.GetHashCode
	|
	|-RVA: 0x2D107B4 Offset: 0x2D0C7B4 VA: 0x2D107B4
	|-ValueTuple<int, object>.GetHashCode
	|
	|-RVA: 0x2D115C8 Offset: 0x2D0D5C8 VA: 0x2D115C8
	|-ValueTuple<Int32Enum, float>.GetHashCode
	|
	|-RVA: 0x2D123C0 Offset: 0x2D0E3C0 VA: 0x2D123C0
	|-ValueTuple<object, bool>.GetHashCode
	|
	|-RVA: 0x2D131E0 Offset: 0x2D0F1E0 VA: 0x2D131E0
	|-ValueTuple<object, byte>.GetHashCode
	|
	|-RVA: 0x2D13EEC Offset: 0x2D0FEEC VA: 0x2D13EEC
	|-ValueTuple<object, object>.GetHashCode
	|
	|-RVA: 0x2D14C50 Offset: 0x2D10C50 VA: 0x2D14C50
	|-ValueTuple<object, float>.GetHashCode
	|
	|-RVA: 0x2D159EC Offset: 0x2D119EC VA: 0x2D159EC
	|-ValueTuple<float, object>.GetHashCode
	|
	|-RVA: 0x2D16824 Offset: 0x2D12824 VA: 0x2D16824
	|-ValueTuple<float, float>.GetHashCode
	|
	|-RVA: 0x2D17734 Offset: 0x2D13734 VA: 0x2D17734
	|-ValueTuple<Vector3, Vector3>.GetHashCode
	|
	|-RVA: 0x2D19398 Offset: 0x2D15398 VA: 0x2D19398
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D0B31C Offset: 0x2D0731C VA: 0x2D0B31C
	|-ValueTuple<bool, bool>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D0C160 Offset: 0x2D08160 VA: 0x2D0C160
	|-ValueTuple<bool, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D0CFA4 Offset: 0x2D08FA4 VA: 0x2D0CFA4
	|-ValueTuple<byte, byte>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D0DDD0 Offset: 0x2D09DD0 VA: 0x2D0DDD0
	|-ValueTuple<short, short>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D0EC2C Offset: 0x2D0AC2C VA: 0x2D0EC2C
	|-ValueTuple<int, bool>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D0FA90 Offset: 0x2D0BA90 VA: 0x2D0FA90
	|-ValueTuple<int, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D10830 Offset: 0x2D0C830 VA: 0x2D10830
	|-ValueTuple<int, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D11624 Offset: 0x2D0D624 VA: 0x2D11624
	|-ValueTuple<Int32Enum, float>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D12478 Offset: 0x2D0E478 VA: 0x2D12478
	|-ValueTuple<object, bool>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D13260 Offset: 0x2D0F260 VA: 0x2D13260
	|-ValueTuple<object, byte>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D13F6C Offset: 0x2D0FF6C VA: 0x2D13F6C
	|-ValueTuple<object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D14CD0 Offset: 0x2D10CD0 VA: 0x2D14CD0
	|-ValueTuple<object, float>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D15A68 Offset: 0x2D11A68 VA: 0x2D15A68
	|-ValueTuple<float, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D168A0 Offset: 0x2D128A0 VA: 0x2D168A0
	|-ValueTuple<float, float>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D177F4 Offset: 0x2D137F4 VA: 0x2D177F4
	|-ValueTuple<Vector3, Vector3>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2D197F0 Offset: 0x2D157F0 VA: 0x2D197F0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D0B360 Offset: 0x2D07360 VA: 0x2D0B360
	|-ValueTuple<bool, bool>.GetHashCodeCore
	|
	|-RVA: 0x2D0C1A4 Offset: 0x2D081A4 VA: 0x2D0C1A4
	|-ValueTuple<bool, object>.GetHashCodeCore
	|
	|-RVA: 0x2D0CFE8 Offset: 0x2D08FE8 VA: 0x2D0CFE8
	|-ValueTuple<byte, byte>.GetHashCodeCore
	|
	|-RVA: 0x2D0DE14 Offset: 0x2D09E14 VA: 0x2D0DE14
	|-ValueTuple<short, short>.GetHashCodeCore
	|
	|-RVA: 0x2D0EC70 Offset: 0x2D0AC70 VA: 0x2D0EC70
	|-ValueTuple<int, bool>.GetHashCodeCore
	|
	|-RVA: 0x2D0FAD4 Offset: 0x2D0BAD4 VA: 0x2D0FAD4
	|-ValueTuple<int, int>.GetHashCodeCore
	|
	|-RVA: 0x2D10874 Offset: 0x2D0C874 VA: 0x2D10874
	|-ValueTuple<int, object>.GetHashCodeCore
	|
	|-RVA: 0x2D11668 Offset: 0x2D0D668 VA: 0x2D11668
	|-ValueTuple<Int32Enum, float>.GetHashCodeCore
	|
	|-RVA: 0x2D124BC Offset: 0x2D0E4BC VA: 0x2D124BC
	|-ValueTuple<object, bool>.GetHashCodeCore
	|
	|-RVA: 0x2D132A4 Offset: 0x2D0F2A4 VA: 0x2D132A4
	|-ValueTuple<object, byte>.GetHashCodeCore
	|
	|-RVA: 0x2D13FA4 Offset: 0x2D0FFA4 VA: 0x2D13FA4
	|-ValueTuple<object, object>.GetHashCodeCore
	|
	|-RVA: 0x2D14D14 Offset: 0x2D10D14 VA: 0x2D14D14
	|-ValueTuple<object, float>.GetHashCodeCore
	|
	|-RVA: 0x2D15AAC Offset: 0x2D11AAC VA: 0x2D15AAC
	|-ValueTuple<float, object>.GetHashCodeCore
	|
	|-RVA: 0x2D168E4 Offset: 0x2D128E4 VA: 0x2D168E4
	|-ValueTuple<float, float>.GetHashCodeCore
	|
	|-RVA: 0x2D17838 Offset: 0x2D13838 VA: 0x2D17838
	|-ValueTuple<Vector3, Vector3>.GetHashCodeCore
	|
	|-RVA: 0x2D19878 Offset: 0x2D15878 VA: 0x2D19878
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D0B4F4 Offset: 0x2D074F4 VA: 0x2D0B4F4
	|-ValueTuple<bool, bool>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D0C300 Offset: 0x2D08300 VA: 0x2D0C300
	|-ValueTuple<bool, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D0D17C Offset: 0x2D0917C VA: 0x2D0D17C
	|-ValueTuple<byte, byte>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D0DFA8 Offset: 0x2D09FA8 VA: 0x2D0DFA8
	|-ValueTuple<short, short>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D0EE04 Offset: 0x2D0AE04 VA: 0x2D0EE04
	|-ValueTuple<int, bool>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D0FC68 Offset: 0x2D0BC68 VA: 0x2D0FC68
	|-ValueTuple<int, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D109D0 Offset: 0x2D0C9D0 VA: 0x2D109D0
	|-ValueTuple<int, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D117FC Offset: 0x2D0D7FC VA: 0x2D117FC
	|-ValueTuple<Int32Enum, float>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D12628 Offset: 0x2D0E628 VA: 0x2D12628
	|-ValueTuple<object, bool>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D13410 Offset: 0x2D0F410 VA: 0x2D13410
	|-ValueTuple<object, byte>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D140D0 Offset: 0x2D100D0 VA: 0x2D140D0
	|-ValueTuple<object, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D14E80 Offset: 0x2D10E80 VA: 0x2D14E80
	|-ValueTuple<object, float>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D15C08 Offset: 0x2D11C08 VA: 0x2D15C08
	|-ValueTuple<float, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D16A78 Offset: 0x2D12A78 VA: 0x2D16A78
	|-ValueTuple<float, float>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D179DC Offset: 0x2D139DC VA: 0x2D179DC
	|-ValueTuple<Vector3, Vector3>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x2D19B28 Offset: 0x2D15B28 VA: 0x2D19B28
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D0B538 Offset: 0x2D07538 VA: 0x2D0B538
	|-ValueTuple<bool, bool>.ToString
	|
	|-RVA: 0x2D0C344 Offset: 0x2D08344 VA: 0x2D0C344
	|-ValueTuple<bool, object>.ToString
	|
	|-RVA: 0x2D0D1C0 Offset: 0x2D091C0 VA: 0x2D0D1C0
	|-ValueTuple<byte, byte>.ToString
	|
	|-RVA: 0x2D0DFEC Offset: 0x2D09FEC VA: 0x2D0DFEC
	|-ValueTuple<short, short>.ToString
	|
	|-RVA: 0x2D0EE48 Offset: 0x2D0AE48 VA: 0x2D0EE48
	|-ValueTuple<int, bool>.ToString
	|
	|-RVA: 0x2D0FCAC Offset: 0x2D0BCAC VA: 0x2D0FCAC
	|-ValueTuple<int, int>.ToString
	|
	|-RVA: 0x2D10A14 Offset: 0x2D0CA14 VA: 0x2D10A14
	|-ValueTuple<int, object>.ToString
	|
	|-RVA: 0x2D11840 Offset: 0x2D0D840 VA: 0x2D11840
	|-ValueTuple<Int32Enum, float>.ToString
	|
	|-RVA: 0x2D1266C Offset: 0x2D0E66C VA: 0x2D1266C
	|-ValueTuple<object, bool>.ToString
	|
	|-RVA: 0x2D13454 Offset: 0x2D0F454 VA: 0x2D13454
	|-ValueTuple<object, byte>.ToString
	|
	|-RVA: 0x2D14108 Offset: 0x2D10108 VA: 0x2D14108
	|-ValueTuple<object, object>.ToString
	|
	|-RVA: 0x2D14EC4 Offset: 0x2D10EC4 VA: 0x2D14EC4
	|-ValueTuple<object, float>.ToString
	|
	|-RVA: 0x2D15C4C Offset: 0x2D11C4C VA: 0x2D15C4C
	|-ValueTuple<float, object>.ToString
	|
	|-RVA: 0x2D16ABC Offset: 0x2D12ABC VA: 0x2D16ABC
	|-ValueTuple<float, float>.ToString
	|
	|-RVA: 0x2D17A20 Offset: 0x2D13A20 VA: 0x2D17A20
	|-ValueTuple<Vector3, Vector3>.ToString
	|
	|-RVA: 0x2D19BB0 Offset: 0x2D15BB0 VA: 0x2D19BB0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D0B6EC Offset: 0x2D076EC VA: 0x2D0B6EC
	|-ValueTuple<bool, bool>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D0C4EC Offset: 0x2D084EC VA: 0x2D0C4EC
	|-ValueTuple<bool, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D0D340 Offset: 0x2D09340 VA: 0x2D0D340
	|-ValueTuple<byte, byte>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D0E16C Offset: 0x2D0A16C VA: 0x2D0E16C
	|-ValueTuple<short, short>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D0EFEC Offset: 0x2D0AFEC VA: 0x2D0EFEC
	|-ValueTuple<int, bool>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D0FE2C Offset: 0x2D0BE2C VA: 0x2D0FE2C
	|-ValueTuple<int, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D10B98 Offset: 0x2D0CB98 VA: 0x2D10B98
	|-ValueTuple<int, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D119EC Offset: 0x2D0D9EC VA: 0x2D119EC
	|-ValueTuple<Int32Enum, float>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D12818 Offset: 0x2D0E818 VA: 0x2D12818
	|-ValueTuple<object, bool>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D135DC Offset: 0x2D0F5DC VA: 0x2D135DC
	|-ValueTuple<object, byte>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D14290 Offset: 0x2D10290 VA: 0x2D14290
	|-ValueTuple<object, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D1504C Offset: 0x2D1104C VA: 0x2D1504C
	|-ValueTuple<object, float>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D15DD0 Offset: 0x2D11DD0 VA: 0x2D15DD0
	|-ValueTuple<float, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D16C3C Offset: 0x2D12C3C VA: 0x2D16C3C
	|-ValueTuple<float, float>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D17BA8 Offset: 0x2D13BA8 VA: 0x2D17BA8
	|-ValueTuple<Vector3, Vector3>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x2D1A114 Offset: 0x2D16114 VA: 0x2D1A114
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D0B7E0 Offset: 0x2D077E0 VA: 0x2D0B7E0
	|-ValueTuple<bool, bool>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D0C5D8 Offset: 0x2D085D8 VA: 0x2D0C5D8
	|-ValueTuple<bool, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D0D404 Offset: 0x2D09404 VA: 0x2D0D404
	|-ValueTuple<byte, byte>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D0E230 Offset: 0x2D0A230 VA: 0x2D0E230
	|-ValueTuple<short, short>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D0F0D0 Offset: 0x2D0B0D0 VA: 0x2D0F0D0
	|-ValueTuple<int, bool>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D0FEF0 Offset: 0x2D0BEF0 VA: 0x2D0FEF0
	|-ValueTuple<int, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D10C60 Offset: 0x2D0CC60 VA: 0x2D10C60
	|-ValueTuple<int, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D11ADC Offset: 0x2D0DADC VA: 0x2D11ADC
	|-ValueTuple<Int32Enum, float>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D12904 Offset: 0x2D0E904 VA: 0x2D12904
	|-ValueTuple<object, bool>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D136A4 Offset: 0x2D0F6A4 VA: 0x2D136A4
	|-ValueTuple<object, byte>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D1435C Offset: 0x2D1035C VA: 0x2D1435C
	|-ValueTuple<object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D15114 Offset: 0x2D11114 VA: 0x2D15114
	|-ValueTuple<object, float>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D15E98 Offset: 0x2D11E98 VA: 0x2D15E98
	|-ValueTuple<float, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D16D00 Offset: 0x2D12D00 VA: 0x2D16D00
	|-ValueTuple<float, float>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D17C70 Offset: 0x2D13C70 VA: 0x2D17C70
	|-ValueTuple<Vector3, Vector3>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2D1A5B4 Offset: 0x2D165B4 VA: 0x2D1A5B4
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}
