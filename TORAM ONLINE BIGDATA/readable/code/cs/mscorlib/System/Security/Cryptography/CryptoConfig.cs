// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class CryptoConfig // TypeDefIndex: 10160
{
	// Fields
	private static readonly object lockObject; // 0x0
	private static Dictionary<string, Type> algorithms; // 0x8

	// Properties
	[MonoLimitation("nothing is FIPS certified so it never make sense to restrict to this (empty) subset")]
	public static bool AllowOnlyFipsAlgorithms { get; }

	// Methods

	// RVA: 0x2EBC9B0 Offset: 0x2EB89B0 VA: 0x2EBC9B0
	public static object CreateFromName(string name) { }

	// RVA: 0x2EBE17C Offset: 0x2EBA17C VA: 0x2EBE17C
	public static object CreateFromName(string name, object[] args) { }

	// RVA: 0x2EC019C Offset: 0x2EBC19C VA: 0x2EC019C
	public static string MapNameToOID(string name) { }

	// RVA: 0x2EC0970 Offset: 0x2EBC970 VA: 0x2EC0970
	public static byte[] EncodeOID(string str) { }

	// RVA: 0x2EC0D70 Offset: 0x2EBCD70 VA: 0x2EC0D70
	private static byte[] EncodeLongNumber(long x) { }

	// RVA: 0x2EBACFC Offset: 0x2EB6CFC VA: 0x2EBACFC
	public static bool get_AllowOnlyFipsAlgorithms() { }

	// RVA: 0x2EC0ED8 Offset: 0x2EBCED8 VA: 0x2EC0ED8
	private static void .cctor() { }
}
