// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class Converter // TypeDefIndex: 10410
{
	// Fields
	private static int primitiveTypeEnumLength; // 0x0
	private static Type[] typeA; // 0x8
	private static Type[] arrayTypeA; // 0x10
	private static string[] valueA; // 0x18
	private static TypeCode[] typeCodeA; // 0x20
	private static InternalPrimitiveTypeE[] codeA; // 0x28
	internal static Type typeofISerializable; // 0x30
	internal static Type typeofString; // 0x38
	internal static Type typeofConverter; // 0x40
	internal static Type typeofBoolean; // 0x48
	internal static Type typeofByte; // 0x50
	internal static Type typeofChar; // 0x58
	internal static Type typeofDecimal; // 0x60
	internal static Type typeofDouble; // 0x68
	internal static Type typeofInt16; // 0x70
	internal static Type typeofInt32; // 0x78
	internal static Type typeofInt64; // 0x80
	internal static Type typeofSByte; // 0x88
	internal static Type typeofSingle; // 0x90
	internal static Type typeofTimeSpan; // 0x98
	internal static Type typeofDateTime; // 0xA0
	internal static Type typeofUInt16; // 0xA8
	internal static Type typeofUInt32; // 0xB0
	internal static Type typeofUInt64; // 0xB8
	internal static Type typeofObject; // 0xC0
	internal static Type typeofSystemVoid; // 0xC8
	internal static Assembly urtAssembly; // 0xD0
	internal static string urtAssemblyString; // 0xD8
	internal static Type typeofTypeArray; // 0xE0
	internal static Type typeofObjectArray; // 0xE8
	internal static Type typeofStringArray; // 0xF0
	internal static Type typeofBooleanArray; // 0xF8
	internal static Type typeofByteArray; // 0x100
	internal static Type typeofCharArray; // 0x108
	internal static Type typeofDecimalArray; // 0x110
	internal static Type typeofDoubleArray; // 0x118
	internal static Type typeofInt16Array; // 0x120
	internal static Type typeofInt32Array; // 0x128
	internal static Type typeofInt64Array; // 0x130
	internal static Type typeofSByteArray; // 0x138
	internal static Type typeofSingleArray; // 0x140
	internal static Type typeofTimeSpanArray; // 0x148
	internal static Type typeofDateTimeArray; // 0x150
	internal static Type typeofUInt16Array; // 0x158
	internal static Type typeofUInt32Array; // 0x160
	internal static Type typeofUInt64Array; // 0x168
	internal static Type typeofMarshalByRefObject; // 0x170

	// Methods

	// RVA: 0x2F065B8 Offset: 0x2F025B8 VA: 0x2F065B8
	internal static InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x2F0B248 Offset: 0x2F07248 VA: 0x2F0B248
	internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code) { }

	// RVA: 0x2F0B26C Offset: 0x2F0726C VA: 0x2F0B26C
	internal static int TypeLength(InternalPrimitiveTypeE code) { }

	// RVA: 0x2F070BC Offset: 0x2F030BC VA: 0x2F070BC
	internal static Type ToArrayType(InternalPrimitiveTypeE code) { }

	// RVA: 0x2F0B70C Offset: 0x2F0770C VA: 0x2F0B70C
	private static void InitTypeA() { }

	// RVA: 0x2F0B290 Offset: 0x2F07290 VA: 0x2F0B290
	private static void InitArrayTypeA() { }

	// RVA: 0x2F07004 Offset: 0x2F03004 VA: 0x2F07004
	internal static Type ToType(InternalPrimitiveTypeE code) { }

	// RVA: 0x2F0BB88 Offset: 0x2F07B88 VA: 0x2F0BB88
	internal static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length) { }

	// RVA: 0x2F05FB4 Offset: 0x2F01FB4 VA: 0x2F05FB4
	internal static bool IsPrimitiveArray(Type type, out object typeInformation) { }

	// RVA: 0x2F0BCA8 Offset: 0x2F07CA8 VA: 0x2F0BCA8
	private static void InitValueA() { }

	// RVA: 0x2F06F4C Offset: 0x2F02F4C VA: 0x2F06F4C
	internal static string ToComType(InternalPrimitiveTypeE code) { }

	// RVA: 0x2F0C064 Offset: 0x2F08064 VA: 0x2F0C064
	private static void InitTypeCodeA() { }

	// RVA: 0x2F0C1FC Offset: 0x2F081FC VA: 0x2F0C1FC
	internal static TypeCode ToTypeCode(InternalPrimitiveTypeE code) { }

	// RVA: 0x2F0C2B4 Offset: 0x2F082B4 VA: 0x2F0C2B4
	private static void InitCodeA() { }

	// RVA: 0x2F0B190 Offset: 0x2F07190 VA: 0x2F0B190
	internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode) { }

	// RVA: 0x2F0C460 Offset: 0x2F08460 VA: 0x2F0C460
	internal static object FromString(string value, InternalPrimitiveTypeE code) { }

	// RVA: 0x2F0C54C Offset: 0x2F0854C VA: 0x2F0C54C
	private static void .cctor() { }
}
