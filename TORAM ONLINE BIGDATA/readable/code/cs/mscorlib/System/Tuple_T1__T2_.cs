// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public class Tuple<T1, T2> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple // TypeDefIndex: 9683
{
	// Fields
	private readonly T1 m_Item1; // 0x0
	private readonly T2 m_Item2; // 0x0

	// Properties
	public T1 Item1 { get; }
	public T2 Item2 { get; }
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T1 get_Item1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBCFEC Offset: 0x2CB8FEC VA: 0x2CBCFEC
	|-Tuple<ArchetypeUid, long>.get_Item1
	|
	|-RVA: 0x2CBDA6C Offset: 0x2CB9A6C VA: 0x2CBDA6C
	|-Tuple<byte, byte>.get_Item1
	|
	|-RVA: 0x2CBE4E8 Offset: 0x2CBA4E8 VA: 0x2CBE4E8
	|-Tuple<Guid, object>.get_Item1
	|
	|-RVA: 0x2CBEED0 Offset: 0x2CBAED0 VA: 0x2CBEED0
	|-Tuple<short, short>.get_Item1
	|
	|-RVA: 0x2CBF94C Offset: 0x2CBB94C VA: 0x2CBF94C
	|-Tuple<int, byte>.get_Item1
	|
	|-RVA: 0x2CC03C8 Offset: 0x2CBC3C8 VA: 0x2CC03C8
	|-Tuple<int, short>.get_Item1
	|
	|-RVA: 0x2CC0E44 Offset: 0x2CBCE44 VA: 0x2CC0E44
	|-Tuple<object, object>.get_Item1
	|
	|-RVA: 0x2CC175C Offset: 0x2CBD75C VA: 0x2CC175C
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item1
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBCFF4 Offset: 0x2CB8FF4 VA: 0x2CBCFF4
	|-Tuple<ArchetypeUid, long>.get_Item2
	|
	|-RVA: 0x2CBDA74 Offset: 0x2CB9A74 VA: 0x2CBDA74
	|-Tuple<byte, byte>.get_Item2
	|
	|-RVA: 0x2CBE4F4 Offset: 0x2CBA4F4 VA: 0x2CBE4F4
	|-Tuple<Guid, object>.get_Item2
	|
	|-RVA: 0x2CBEED8 Offset: 0x2CBAED8 VA: 0x2CBEED8
	|-Tuple<short, short>.get_Item2
	|
	|-RVA: 0x2CBF954 Offset: 0x2CBB954 VA: 0x2CBF954
	|-Tuple<int, byte>.get_Item2
	|
	|-RVA: 0x2CC03D0 Offset: 0x2CBC3D0 VA: 0x2CC03D0
	|-Tuple<int, short>.get_Item2
	|
	|-RVA: 0x2CC0E4C Offset: 0x2CBCE4C VA: 0x2CC0E4C
	|-Tuple<object, object>.get_Item2
	|
	|-RVA: 0x2CC17F4 Offset: 0x2CBD7F4 VA: 0x2CC17F4
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item2
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBCFFC Offset: 0x2CB8FFC VA: 0x2CBCFFC
	|-Tuple<ArchetypeUid, long>..ctor
	|
	|-RVA: 0x2CBDA7C Offset: 0x2CB9A7C VA: 0x2CBDA7C
	|-Tuple<byte, byte>..ctor
	|
	|-RVA: 0x2CBE4FC Offset: 0x2CBA4FC VA: 0x2CBE4FC
	|-Tuple<Guid, object>..ctor
	|
	|-RVA: 0x2CBEEE0 Offset: 0x2CBAEE0 VA: 0x2CBEEE0
	|-Tuple<short, short>..ctor
	|
	|-RVA: 0x2CBF95C Offset: 0x2CBB95C VA: 0x2CBF95C
	|-Tuple<int, byte>..ctor
	|
	|-RVA: 0x2CC03D8 Offset: 0x2CBC3D8 VA: 0x2CC03D8
	|-Tuple<int, short>..ctor
	|
	|-RVA: 0x2CC0E54 Offset: 0x2CBCE54 VA: 0x2CC0E54
	|-Tuple<object, object>..ctor
	|
	|-RVA: 0x2CC1894 Offset: 0x2CBD894 VA: 0x2CC1894
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBD028 Offset: 0x2CB9028 VA: 0x2CBD028
	|-Tuple<ArchetypeUid, long>.Equals
	|
	|-RVA: 0x2CBDAAC Offset: 0x2CB9AAC VA: 0x2CBDAAC
	|-Tuple<byte, byte>.Equals
	|
	|-RVA: 0x2CBE540 Offset: 0x2CBA540 VA: 0x2CBE540
	|-Tuple<Guid, object>.Equals
	|
	|-RVA: 0x2CBEF10 Offset: 0x2CBAF10 VA: 0x2CBEF10
	|-Tuple<short, short>.Equals
	|
	|-RVA: 0x2CBF98C Offset: 0x2CBB98C VA: 0x2CBF98C
	|-Tuple<int, byte>.Equals
	|
	|-RVA: 0x2CC0408 Offset: 0x2CBC408 VA: 0x2CC0408
	|-Tuple<int, short>.Equals
	|
	|-RVA: 0x2CC0E98 Offset: 0x2CBCE98 VA: 0x2CC0E98
	|-Tuple<object, object>.Equals
	|
	|-RVA: 0x2CC19D8 Offset: 0x2CBD9D8 VA: 0x2CC19D8
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBD0F8 Offset: 0x2CB90F8 VA: 0x2CBD0F8
	|-Tuple<ArchetypeUid, long>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2CBDB7C Offset: 0x2CB9B7C VA: 0x2CBDB7C
	|-Tuple<byte, byte>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2CBE610 Offset: 0x2CBA610 VA: 0x2CBE610
	|-Tuple<Guid, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2CBEFE0 Offset: 0x2CBAFE0 VA: 0x2CBEFE0
	|-Tuple<short, short>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2CBFA5C Offset: 0x2CBBA5C VA: 0x2CBFA5C
	|-Tuple<int, byte>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2CC04D8 Offset: 0x2CBC4D8 VA: 0x2CC04D8
	|-Tuple<int, short>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2CC0F68 Offset: 0x2CBCF68 VA: 0x2CC0F68
	|-Tuple<object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2CC1AA8 Offset: 0x2CBDAA8 VA: 0x2CC1AA8
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.IComparable.CompareTo(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBD304 Offset: 0x2CB9304 VA: 0x2CBD304
	|-Tuple<ArchetypeUid, long>.System.IComparable.CompareTo
	|
	|-RVA: 0x2CBDD88 Offset: 0x2CB9D88 VA: 0x2CBDD88
	|-Tuple<byte, byte>.System.IComparable.CompareTo
	|
	|-RVA: 0x2CBE7E0 Offset: 0x2CBA7E0 VA: 0x2CBE7E0
	|-Tuple<Guid, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x2CBF1EC Offset: 0x2CBB1EC VA: 0x2CBF1EC
	|-Tuple<short, short>.System.IComparable.CompareTo
	|
	|-RVA: 0x2CBFC68 Offset: 0x2CBBC68 VA: 0x2CBFC68
	|-Tuple<int, byte>.System.IComparable.CompareTo
	|
	|-RVA: 0x2CC06E4 Offset: 0x2CBC6E4 VA: 0x2CC06E4
	|-Tuple<int, short>.System.IComparable.CompareTo
	|
	|-RVA: 0x2CC1100 Offset: 0x2CBD100 VA: 0x2CC1100
	|-Tuple<object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x2CC1DC4 Offset: 0x2CBDDC4 VA: 0x2CC1DC4
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBD3D4 Offset: 0x2CB93D4 VA: 0x2CBD3D4
	|-Tuple<ArchetypeUid, long>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2CBDE58 Offset: 0x2CB9E58 VA: 0x2CBDE58
	|-Tuple<byte, byte>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2CBE8B0 Offset: 0x2CBA8B0 VA: 0x2CBE8B0
	|-Tuple<Guid, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2CBF2BC Offset: 0x2CBB2BC VA: 0x2CBF2BC
	|-Tuple<short, short>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2CBFD38 Offset: 0x2CBBD38 VA: 0x2CBFD38
	|-Tuple<int, byte>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2CC07B4 Offset: 0x2CBC7B4 VA: 0x2CC07B4
	|-Tuple<int, short>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2CC11D0 Offset: 0x2CBD1D0 VA: 0x2CC11D0
	|-Tuple<object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2CC1E94 Offset: 0x2CBDE94 VA: 0x2CC1E94
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBD664 Offset: 0x2CB9664 VA: 0x2CBD664
	|-Tuple<ArchetypeUid, long>.GetHashCode
	|
	|-RVA: 0x2CBE0E8 Offset: 0x2CBA0E8 VA: 0x2CBE0E8
	|-Tuple<byte, byte>.GetHashCode
	|
	|-RVA: 0x2CBEB04 Offset: 0x2CBAB04 VA: 0x2CBEB04
	|-Tuple<Guid, object>.GetHashCode
	|
	|-RVA: 0x2CBF54C Offset: 0x2CBB54C VA: 0x2CBF54C
	|-Tuple<short, short>.GetHashCode
	|
	|-RVA: 0x2CBFFC8 Offset: 0x2CBBFC8 VA: 0x2CBFFC8
	|-Tuple<int, byte>.GetHashCode
	|
	|-RVA: 0x2CC0A44 Offset: 0x2CBCA44 VA: 0x2CC0A44
	|-Tuple<int, short>.GetHashCode
	|
	|-RVA: 0x2CC13F0 Offset: 0x2CBD3F0 VA: 0x2CC13F0
	|-Tuple<object, object>.GetHashCode
	|
	|-RVA: 0x2CC2228 Offset: 0x2CBE228 VA: 0x2CC2228
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBD728 Offset: 0x2CB9728 VA: 0x2CBD728
	|-Tuple<ArchetypeUid, long>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2CBE1AC Offset: 0x2CBA1AC VA: 0x2CBE1AC
	|-Tuple<byte, byte>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2CBEBC8 Offset: 0x2CBABC8 VA: 0x2CBEBC8
	|-Tuple<Guid, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2CBF610 Offset: 0x2CBB610 VA: 0x2CBF610
	|-Tuple<short, short>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2CC008C Offset: 0x2CBC08C VA: 0x2CC008C
	|-Tuple<int, byte>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2CC0B08 Offset: 0x2CBCB08 VA: 0x2CC0B08
	|-Tuple<int, short>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2CC14B4 Offset: 0x2CBD4B4 VA: 0x2CC14B4
	|-Tuple<object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2CC22EC Offset: 0x2CBE2EC VA: 0x2CC22EC
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBD8A0 Offset: 0x2CB98A0 VA: 0x2CBD8A0
	|-Tuple<ArchetypeUid, long>.ToString
	|
	|-RVA: 0x2CBE324 Offset: 0x2CBA324 VA: 0x2CBE324
	|-Tuple<byte, byte>.ToString
	|
	|-RVA: 0x2CBED20 Offset: 0x2CBAD20 VA: 0x2CBED20
	|-Tuple<Guid, object>.ToString
	|
	|-RVA: 0x2CBF788 Offset: 0x2CBB788 VA: 0x2CBF788
	|-Tuple<short, short>.ToString
	|
	|-RVA: 0x2CC0204 Offset: 0x2CBC204 VA: 0x2CC0204
	|-Tuple<int, byte>.ToString
	|
	|-RVA: 0x2CC0C80 Offset: 0x2CBCC80 VA: 0x2CC0C80
	|-Tuple<int, short>.ToString
	|
	|-RVA: 0x2CC15E0 Offset: 0x2CBD5E0 VA: 0x2CC15E0
	|-Tuple<object, object>.ToString
	|
	|-RVA: 0x2CC250C Offset: 0x2CBE50C VA: 0x2CC250C
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private string System.ITupleInternal.ToString(StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBD97C Offset: 0x2CB997C VA: 0x2CBD97C
	|-Tuple<ArchetypeUid, long>.System.ITupleInternal.ToString
	|
	|-RVA: 0x2CBE400 Offset: 0x2CBA400 VA: 0x2CBE400
	|-Tuple<byte, byte>.System.ITupleInternal.ToString
	|
	|-RVA: 0x2CBEDFC Offset: 0x2CBADFC VA: 0x2CBEDFC
	|-Tuple<Guid, object>.System.ITupleInternal.ToString
	|
	|-RVA: 0x2CBF864 Offset: 0x2CBB864 VA: 0x2CBF864
	|-Tuple<short, short>.System.ITupleInternal.ToString
	|
	|-RVA: 0x2CC02E0 Offset: 0x2CBC2E0 VA: 0x2CC02E0
	|-Tuple<int, byte>.System.ITupleInternal.ToString
	|
	|-RVA: 0x2CC0D5C Offset: 0x2CBCD5C VA: 0x2CC0D5C
	|-Tuple<int, short>.System.ITupleInternal.ToString
	|
	|-RVA: 0x2CC16BC Offset: 0x2CBD6BC VA: 0x2CC16BC
	|-Tuple<object, object>.System.ITupleInternal.ToString
	|
	|-RVA: 0x2CC25E8 Offset: 0x2CBE5E8 VA: 0x2CC25E8
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.ITupleInternal.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBDA64 Offset: 0x2CB9A64 VA: 0x2CBDA64
	|-Tuple<ArchetypeUid, long>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2CBE4E0 Offset: 0x2CBA4E0 VA: 0x2CBE4E0
	|-Tuple<byte, byte>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2CBEEC8 Offset: 0x2CBAEC8 VA: 0x2CBEEC8
	|-Tuple<Guid, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2CBF944 Offset: 0x2CBB944 VA: 0x2CBF944
	|-Tuple<short, short>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2CC03C0 Offset: 0x2CBC3C0 VA: 0x2CC03C0
	|-Tuple<int, byte>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2CC0E3C Offset: 0x2CBCE3C VA: 0x2CC0E3C
	|-Tuple<int, short>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2CC1754 Offset: 0x2CBD754 VA: 0x2CC1754
	|-Tuple<object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2CC277C Offset: 0x2CBE77C VA: 0x2CC277C
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}
