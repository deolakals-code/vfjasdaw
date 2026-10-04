// Assembly: mscorlib.dll
// Namespace: System.Numerics
[DefaultMember("Item")]
[Intrinsic]
public struct Vector<T> : IEquatable<Vector<T>>, IFormattable // TypeDefIndex: 10681
{
	// Fields
	private Register register; // 0x0
	private static readonly int s_count; // 0x0
	private static readonly Vector<T> s_zero; // 0x0
	private static readonly Vector<T> s_one; // 0x0
	private static readonly Vector<T> s_allOnes; // 0x0

	// Properties
	public static int Count { get; }
	public static Vector<T> Zero { get; }
	public T Item { get; }

	// Methods

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D46450 Offset: 0x2D42450 VA: 0x2D46450
	|-Vector<ushort>.get_Count
	|
	|-RVA: 0x2D522B4 Offset: 0x2D4E2B4 VA: 0x2D522B4
	|-Vector<ulong>.get_Count
	|
	|-RVA: 0x2D5D1C8 Offset: 0x2D591C8 VA: 0x2D5D1C8
	|-Vector<__Il2CppFullySharedGenericStructType>.get_Count
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static Vector<T> get_Zero() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D464BC Offset: 0x2D424BC VA: 0x2D464BC
	|-Vector<ushort>.get_Zero
	|
	|-RVA: 0x2D52320 Offset: 0x2D4E320 VA: 0x2D52320
	|-Vector<ulong>.get_Zero
	|
	|-RVA: 0x2D5D234 Offset: 0x2D59234 VA: 0x2D5D234
	|-Vector<__Il2CppFullySharedGenericStructType>.get_Zero
	*/

	// RVA: -1 Offset: -1
	private static int InitializeCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D46528 Offset: 0x2D42528 VA: 0x2D46528
	|-Vector<ushort>.InitializeCount
	|
	|-RVA: 0x2D5238C Offset: 0x2D4E38C VA: 0x2D5238C
	|-Vector<ulong>.InitializeCount
	|
	|-RVA: 0x2D5D2A0 Offset: 0x2D592A0 VA: 0x2D5D2A0
	|-Vector<__Il2CppFullySharedGenericStructType>.InitializeCount
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D46ACC Offset: 0x2D42ACC VA: 0x2D46ACC
	|-Vector<ushort>..ctor
	|
	|-RVA: 0x2D52930 Offset: 0x2D4E930 VA: 0x2D52930
	|-Vector<ulong>..ctor
	|
	|-RVA: 0x2D5D844 Offset: 0x2D59844 VA: 0x2D5D844
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(void* dataPointer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D48A34 Offset: 0x2D44A34 VA: 0x2D48A34
	|-Vector<ushort>..ctor
	|
	|-RVA: 0x2D54898 Offset: 0x2D50898 VA: 0x2D54898
	|-Vector<ulong>..ctor
	|
	|-RVA: 0x2D5FADC Offset: 0x2D5BADC VA: 0x2D5FADC
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(void* dataPointer, int offset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D48AB0 Offset: 0x2D44AB0 VA: 0x2D48AB0
	|-Vector<ushort>..ctor
	|
	|-RVA: 0x2D54914 Offset: 0x2D50914 VA: 0x2D54914
	|-Vector<ulong>..ctor
	|
	|-RVA: 0x2D5FBA0 Offset: 0x2D5BBA0 VA: 0x2D5FBA0
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(ref Register existingRegister) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D49788 Offset: 0x2D45788 VA: 0x2D49788
	|-Vector<ushort>..ctor
	|
	|-RVA: 0x2D555EC Offset: 0x2D515EC VA: 0x2D555EC
	|-Vector<ulong>..ctor
	|
	|-RVA: 0x2D60738 Offset: 0x2D5C738 VA: 0x2D60738
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D49794 Offset: 0x2D45794 VA: 0x2D49794
	|-Vector<ushort>.get_Item
	|
	|-RVA: 0x2D555F8 Offset: 0x2D515F8 VA: 0x2D555F8
	|-Vector<ulong>.get_Item
	|
	|-RVA: 0x2D60744 Offset: 0x2D5C744 VA: 0x2D60744
	|-Vector<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D49FC0 Offset: 0x2D45FC0 VA: 0x2D49FC0
	|-Vector<ushort>.Equals
	|
	|-RVA: 0x2D55E24 Offset: 0x2D51E24 VA: 0x2D55E24
	|-Vector<ulong>.Equals
	|
	|-RVA: 0x2D60FA0 Offset: 0x2D5CFA0 VA: 0x2D60FA0
	|-Vector<__Il2CppFullySharedGenericStructType>.Equals
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(Vector<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D4A0D4 Offset: 0x2D460D4 VA: 0x2D4A0D4
	|-Vector<ushort>.Equals
	|
	|-RVA: 0x2D55F38 Offset: 0x2D51F38 VA: 0x2D55F38
	|-Vector<ulong>.Equals
	|
	|-RVA: 0x2D61100 Offset: 0x2D5D100 VA: 0x2D61100
	|-Vector<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D4AAA4 Offset: 0x2D46AA4 VA: 0x2D4AAA4
	|-Vector<ushort>.GetHashCode
	|
	|-RVA: 0x2D56908 Offset: 0x2D52908 VA: 0x2D56908
	|-Vector<ulong>.GetHashCode
	|
	|-RVA: 0x2D61BD0 Offset: 0x2D5DBD0 VA: 0x2D61BD0
	|-Vector<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D4CDA0 Offset: 0x2D48DA0 VA: 0x2D4CDA0
	|-Vector<ushort>.ToString
	|
	|-RVA: 0x2D58C04 Offset: 0x2D54C04 VA: 0x2D58C04
	|-Vector<ulong>.ToString
	|
	|-RVA: 0x2D640E8 Offset: 0x2D600E8 VA: 0x2D640E8
	|-Vector<__Il2CppFullySharedGenericStructType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D4CE7C Offset: 0x2D48E7C VA: 0x2D4CE7C
	|-Vector<ushort>.ToString
	|
	|-RVA: 0x2D58CE0 Offset: 0x2D54CE0 VA: 0x2D58CE0
	|-Vector<ulong>.ToString
	|
	|-RVA: 0x2D64204 Offset: 0x2D60204 VA: 0x2D64204
	|-Vector<__Il2CppFullySharedGenericStructType>.ToString
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D4D24C Offset: 0x2D4924C VA: 0x2D4D24C
	|-Vector<ushort>.op_Equality
	|
	|-RVA: 0x2D590B0 Offset: 0x2D550B0 VA: 0x2D590B0
	|-Vector<ulong>.op_Equality
	|
	|-RVA: 0x2D646DC Offset: 0x2D606DC VA: 0x2D646DC
	|-Vector<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D4D2FC Offset: 0x2D492FC VA: 0x2D4D2FC
	|-Vector<ushort>.op_Inequality
	|
	|-RVA: 0x2D59160 Offset: 0x2D55160 VA: 0x2D59160
	|-Vector<ulong>.op_Inequality
	|
	|-RVA: 0x2D647C4 Offset: 0x2D607C4 VA: 0x2D647C4
	|-Vector<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	[CLSCompliant(False)]
	[Intrinsic]
	// RVA: -1 Offset: -1
	public static Vector<ulong> op_Explicit(Vector<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D4D410 Offset: 0x2D49410 VA: 0x2D4D410
	|-Vector<ushort>.op_Explicit
	|
	|-RVA: 0x2D59274 Offset: 0x2D55274 VA: 0x2D59274
	|-Vector<ulong>.op_Explicit
	|
	|-RVA: 0x2D64898 Offset: 0x2D60898 VA: 0x2D64898
	|-Vector<__Il2CppFullySharedGenericStructType>.op_Explicit
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	internal static Vector<T> Equals(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D4D490 Offset: 0x2D49490 VA: 0x2D4D490
	|-Vector<ushort>.Equals
	|
	|-RVA: 0x2D592B8 Offset: 0x2D552B8 VA: 0x2D592B8
	|-Vector<ulong>.Equals
	|
	|-RVA: 0x2D648DC Offset: 0x2D608DC VA: 0x2D648DC
	|-Vector<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	private static bool ScalarEquals(T left, T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D4F914 Offset: 0x2D4B914 VA: 0x2D4F914
	|-Vector<ushort>.ScalarEquals
	|
	|-RVA: 0x2D5B73C Offset: 0x2D5773C VA: 0x2D5B73C
	|-Vector<ulong>.ScalarEquals
	|
	|-RVA: 0x2D6735C Offset: 0x2D6335C VA: 0x2D6735C
	|-Vector<__Il2CppFullySharedGenericStructType>.ScalarEquals
	*/

	// RVA: -1 Offset: -1
	private static T GetOneValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D504A0 Offset: 0x2D4C4A0 VA: 0x2D504A0
	|-Vector<ushort>.GetOneValue
	|
	|-RVA: 0x2D5C2D0 Offset: 0x2D582D0 VA: 0x2D5C2D0
	|-Vector<ulong>.GetOneValue
	|
	|-RVA: 0x2D68020 Offset: 0x2D64020 VA: 0x2D68020
	|-Vector<__Il2CppFullySharedGenericStructType>.GetOneValue
	*/

	// RVA: -1 Offset: -1
	private static T GetAllBitsSetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D50B44 Offset: 0x2D4CB44 VA: 0x2D50B44
	|-Vector<ushort>.GetAllBitsSetValue
	|
	|-RVA: 0x2D5C974 Offset: 0x2D58974 VA: 0x2D5C974
	|-Vector<ulong>.GetAllBitsSetValue
	|
	|-RVA: 0x2D6871C Offset: 0x2D6471C VA: 0x2D6871C
	|-Vector<__Il2CppFullySharedGenericStructType>.GetAllBitsSetValue
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D511D8 Offset: 0x2D4D1D8 VA: 0x2D511D8
	|-Vector<ushort>..cctor
	|
	|-RVA: 0x2D5D008 Offset: 0x2D59008 VA: 0x2D5D008
	|-Vector<ulong>..cctor
	|
	|-RVA: 0x2D68E08 Offset: 0x2D64E08 VA: 0x2D68E08
	|-Vector<__Il2CppFullySharedGenericStructType>..cctor
	*/
}
