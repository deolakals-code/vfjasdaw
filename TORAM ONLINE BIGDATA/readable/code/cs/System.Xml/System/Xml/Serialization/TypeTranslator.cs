// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
internal class TypeTranslator // TypeDefIndex: 13505
{
	// Fields
	private static Hashtable nameCache; // 0x0
	private static Hashtable primitiveTypes; // 0x8
	private static Hashtable primitiveArrayTypes; // 0x10
	private static Hashtable nullableTypes; // 0x18

	// Methods

	// RVA: 0x33EAA00 Offset: 0x33E6A00 VA: 0x33EAA00
	private static void .cctor() { }

	// RVA: 0x33E7DC4 Offset: 0x33E3DC4 VA: 0x33E7DC4
	public static TypeData GetTypeData(Type type) { }

	// RVA: 0x33ECE94 Offset: 0x33E8E94 VA: 0x33ECE94
	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = False) { }

	// RVA: 0x33ED828 Offset: 0x33E9828 VA: 0x33ED828
	public static TypeData GetPrimitiveTypeData(string typeName) { }

	// RVA: 0x33ED880 Offset: 0x33E9880 VA: 0x33ED880
	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	// RVA: 0x33EDA80 Offset: 0x33E9A80 VA: 0x33EDA80
	public static TypeData FindPrimitiveTypeData(string typeName) { }

	// RVA: 0x33E87D8 Offset: 0x33E47D8 VA: 0x33E87D8
	public static string GetArrayName(string elemName) { }

	// RVA: 0x33EDB40 Offset: 0x33E9B40 VA: 0x33EDB40
	public static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions) { }
}
