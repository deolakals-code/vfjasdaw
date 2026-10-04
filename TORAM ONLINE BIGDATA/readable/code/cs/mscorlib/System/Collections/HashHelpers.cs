// Assembly: mscorlib.dll
// Namespace: System.Collections
internal static class HashHelpers // TypeDefIndex: 10860
{
	// Fields
	public static readonly int[] primes; // 0x0
	private static ConditionalWeakTable<object, SerializationInfo> s_serializationInfoTable; // 0x8

	// Properties
	internal static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable { get; }

	// Methods

	// RVA: 0x2FB3A00 Offset: 0x2FAFA00 VA: 0x2FB3A00
	public static bool IsPrime(int candidate) { }

	// RVA: 0x2FB3AB8 Offset: 0x2FAFAB8 VA: 0x2FB3AB8
	public static int GetPrime(int min) { }

	// RVA: 0x2FB3C40 Offset: 0x2FAFC40 VA: 0x2FB3C40
	public static int ExpandPrime(int oldSize) { }

	// RVA: 0x2FB3CC4 Offset: 0x2FAFCC4 VA: 0x2FB3CC4
	internal static ConditionalWeakTable<object, SerializationInfo> get_SerializationInfoTable() { }

	// RVA: 0x2FB3D9C Offset: 0x2FAFD9C VA: 0x2FB3D9C
	private static void .cctor() { }
}
