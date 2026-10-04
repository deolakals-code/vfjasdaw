// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public struct ValueTuple : IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple>, IValueTupleInternal, ITuple // TypeDefIndex: 9697
{
	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: 0x3003900 Offset: 0x2FFF900 VA: 0x3003900 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x300395C Offset: 0x2FFF95C VA: 0x300395C Slot: 4
	public bool Equals(ValueTuple other) { }

	// RVA: 0x3003964 Offset: 0x2FFF964 VA: 0x3003964 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	// RVA: 0x30039C0 Offset: 0x2FFF9C0 VA: 0x30039C0 Slot: 8
	private int System.IComparable.CompareTo(object other) { }

	// RVA: 0x3003AD4 Offset: 0x2FFFAD4 VA: 0x3003AD4 Slot: 9
	public int CompareTo(ValueTuple other) { }

	// RVA: 0x3003ADC Offset: 0x2FFFADC VA: 0x3003ADC Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	// RVA: 0x3003BF0 Offset: 0x2FFFBF0 VA: 0x3003BF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3003BF8 Offset: 0x2FFFBF8 VA: 0x3003BF8 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	// RVA: 0x3003C00 Offset: 0x2FFFC00 VA: 0x3003C00 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	// RVA: 0x3003C08 Offset: 0x2FFFC08 VA: 0x3003C08 Slot: 3
	public override string ToString() { }

	// RVA: 0x3003C48 Offset: 0x2FFFC48 VA: 0x3003C48 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }

	// RVA: 0x3003C88 Offset: 0x2FFFC88 VA: 0x3003C88 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }

	// RVA: 0x3003C90 Offset: 0x2FFFC90 VA: 0x3003C90
	internal static int CombineHashCodes(int h1, int h2) { }

	// RVA: 0x3003D0C Offset: 0x2FFFD0C VA: 0x3003D0C
	internal static int CombineHashCodes(int h1, int h2, int h3) { }

	// RVA: 0x3003D8C Offset: 0x2FFFD8C VA: 0x3003D8C
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4) { }

	// RVA: 0x3003E1C Offset: 0x2FFFE1C VA: 0x3003E1C
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5) { }

	// RVA: 0x3003EB4 Offset: 0x2FFFEB4 VA: 0x3003EB4
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6) { }

	// RVA: 0x3003F5C Offset: 0x2FFFF5C VA: 0x3003F5C
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7) { }

	// RVA: 0x300400C Offset: 0x300000C VA: 0x300400C
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8) { }
}
