// Assembly: mscorlib.dll
// Namespace: System
[ComVisible(True)]
[Serializable]
public abstract class Enum : ValueType, IComparable, IFormattable, IConvertible // TypeDefIndex: 9753
{
	// Fields
	private static readonly char[] enumSeperatorCharArray; // 0x0
	private const string enumSeperator = ", ";

	// Methods

	// RVA: 0x3017F58 Offset: 0x3013F58 VA: 0x3017F58
	private static Enum.ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames) { }

	// RVA: 0x30180FC Offset: 0x30140FC VA: 0x30180FC
	private static string InternalFormattedHexString(object value) { }

	// RVA: 0x30185A8 Offset: 0x30145A8 VA: 0x30185A8
	private static string InternalFormat(RuntimeType eT, object value) { }

	// RVA: 0x3018790 Offset: 0x3014790 VA: 0x3018790
	private static string InternalFlagsFormat(RuntimeType eT, object value) { }

	// RVA: 0x3018994 Offset: 0x3014994 VA: 0x3018994
	internal static ulong ToUInt64(object value) { }

	// RVA: 0x3018B00 Offset: 0x3014B00 VA: 0x3018B00
	private static int InternalCompareTo(object o1, object o2) { }

	// RVA: 0x3018B04 Offset: 0x3014B04 VA: 0x3018B04
	internal static RuntimeType InternalGetUnderlyingType(RuntimeType enumType) { }

	// RVA: 0x30180B4 Offset: 0x30140B4 VA: 0x30180B4
	private static bool GetEnumValuesAndNames(RuntimeType enumType, out ulong[] values, out string[] names) { }

	// RVA: 0x3018B08 Offset: 0x3014B08 VA: 0x3018B08
	private static object InternalBoxEnum(RuntimeType enumType, long value) { }

	// RVA: -1 Offset: -1
	public static bool TryParse<TEnum>(string value, out TEnum result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27EAC3C Offset: 0x27E6C3C VA: 0x27EAC3C
	|-Enum.TryParse<Int32Enum>
	|
	|-RVA: 0x27EACAC Offset: 0x27E6CAC VA: 0x27EACAC
	|-Enum.TryParse<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27EAD20 Offset: 0x27E6D20 VA: 0x27EAD20
	|-Enum.TryParse<Int32Enum>
	|
	|-RVA: 0x27EAE64 Offset: 0x27E6E64 VA: 0x27EAE64
	|-Enum.TryParse<__Il2CppFullySharedGenericStructType>
	*/

	[ComVisible(True)]
	// RVA: 0x3018B0C Offset: 0x3014B0C VA: 0x3018B0C
	public static object Parse(Type enumType, string value) { }

	[ComVisible(True)]
	// RVA: 0x3018B74 Offset: 0x3014B74 VA: 0x3018B74
	public static object Parse(Type enumType, string value, bool ignoreCase) { }

	// RVA: 0x3018CA8 Offset: 0x3014CA8 VA: 0x3018CA8
	private static bool TryParseEnum(Type enumType, string value, bool ignoreCase, ref Enum.EnumResult parseResult) { }

	[ComVisible(True)]
	// RVA: 0x301956C Offset: 0x301556C VA: 0x301956C
	public static Type GetUnderlyingType(Type enumType) { }

	[ComVisible(True)]
	// RVA: 0x3019D08 Offset: 0x3015D08 VA: 0x3019D08
	public static Array GetValues(Type enumType) { }

	// RVA: 0x3019DCC Offset: 0x3015DCC VA: 0x3019DCC
	internal static ulong[] InternalGetValues(RuntimeType enumType) { }

	[ComVisible(True)]
	// RVA: 0x30186BC Offset: 0x30146BC VA: 0x30186BC
	public static string GetName(Type enumType, object value) { }

	[ComVisible(True)]
	// RVA: 0x3019E34 Offset: 0x3015E34 VA: 0x3019E34
	public static string[] GetNames(Type enumType) { }

	// RVA: 0x3019EF8 Offset: 0x3015EF8 VA: 0x3019EF8
	internal static string[] InternalGetNames(RuntimeType enumType) { }

	[ComVisible(True)]
	// RVA: 0x3019630 Offset: 0x3015630 VA: 0x3019630
	public static object ToObject(Type enumType, object value) { }

	[ComVisible(True)]
	// RVA: 0x301AF8C Offset: 0x3016F8C VA: 0x301AF8C
	public static bool IsDefined(Type enumType, object value) { }

	[ComVisible(True)]
	// RVA: 0x301B060 Offset: 0x3017060 VA: 0x301B060
	public static string Format(Type enumType, object value, string format) { }

	// RVA: 0x301B62C Offset: 0x301762C VA: 0x301B62C
	private object get_value() { }

	// RVA: 0x301B628 Offset: 0x3017628 VA: 0x301B628
	internal object GetValue() { }

	// RVA: 0x301B630 Offset: 0x3017630 VA: 0x301B630
	private bool InternalHasFlag(Enum flags) { }

	// RVA: 0x301B634 Offset: 0x3017634 VA: 0x301B634
	private int get_hashcode() { }

	// RVA: 0x301B638 Offset: 0x3017638 VA: 0x301B638 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x301B640 Offset: 0x3017640 VA: 0x301B640 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x301B644 Offset: 0x3017644 VA: 0x301B644 Slot: 3
	public override string ToString() { }

	[Obsolete("The provider argument is not used. Please use ToString(String).")]
	// RVA: 0x301B710 Offset: 0x3017710 VA: 0x301B710 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x301B964 Offset: 0x3017964 VA: 0x301B964 Slot: 4
	public int CompareTo(object target) { }

	// RVA: 0x301B714 Offset: 0x3017714 VA: 0x301B714
	public string ToString(string format) { }

	[Obsolete("The provider argument is not used. Please use ToString().")]
	// RVA: 0x301BB58 Offset: 0x3017B58 VA: 0x301BB58 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x301BB64 Offset: 0x3017B64 VA: 0x301BB64
	public bool HasFlag(Enum flag) { }

	// RVA: 0x301BCE4 Offset: 0x3017CE4 VA: 0x301BCE4 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x301C0E0 Offset: 0x30180E0 VA: 0x301C0E0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x301C180 Offset: 0x3018180 VA: 0x301C180 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x301C220 Offset: 0x3018220 VA: 0x301C220 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x301C2C0 Offset: 0x30182C0 VA: 0x301C2C0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x301C360 Offset: 0x3018360 VA: 0x301C360 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x301C400 Offset: 0x3018400 VA: 0x301C400 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x301C4A0 Offset: 0x30184A0 VA: 0x301C4A0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x301C540 Offset: 0x3018540 VA: 0x301C540 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x301C5E0 Offset: 0x30185E0 VA: 0x301C5E0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x301C680 Offset: 0x3018680 VA: 0x301C680 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x301C720 Offset: 0x3018720 VA: 0x301C720 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x301C7C0 Offset: 0x30187C0 VA: 0x301C7C0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x301C860 Offset: 0x3018860 VA: 0x301C860 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x301C900 Offset: 0x3018900 VA: 0x301C900 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x301C9E8 Offset: 0x30189E8 VA: 0x301C9E8 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[ComVisible(True)]
	[CLSCompliant(False)]
	// RVA: 0x301A12C Offset: 0x301612C VA: 0x301A12C
	public static object ToObject(Type enumType, sbyte value) { }

	[ComVisible(True)]
	// RVA: 0x301A2F8 Offset: 0x30162F8 VA: 0x301A2F8
	public static object ToObject(Type enumType, short value) { }

	[ComVisible(True)]
	// RVA: 0x3019F60 Offset: 0x3015F60 VA: 0x3019F60
	public static object ToObject(Type enumType, int value) { }

	[ComVisible(True)]
	// RVA: 0x301A85C Offset: 0x301685C VA: 0x301A85C
	public static object ToObject(Type enumType, byte value) { }

	[ComVisible(True)]
	[CLSCompliant(False)]
	// RVA: 0x301AA28 Offset: 0x3016A28 VA: 0x301AA28
	public static object ToObject(Type enumType, ushort value) { }

	[CLSCompliant(False)]
	[ComVisible(True)]
	// RVA: 0x301A690 Offset: 0x3016690 VA: 0x301A690
	public static object ToObject(Type enumType, uint value) { }

	[ComVisible(True)]
	// RVA: 0x301A4C4 Offset: 0x30164C4 VA: 0x301A4C4
	public static object ToObject(Type enumType, long value) { }

	[ComVisible(True)]
	[CLSCompliant(False)]
	// RVA: 0x3019B3C Offset: 0x3015B3C VA: 0x3019B3C
	public static object ToObject(Type enumType, ulong value) { }

	// RVA: 0x301ABF4 Offset: 0x3016BF4 VA: 0x301ABF4
	private static object ToObject(Type enumType, char value) { }

	// RVA: 0x301ADC0 Offset: 0x3016DC0 VA: 0x301ADC0
	private static object ToObject(Type enumType, bool value) { }

	// RVA: 0x301CA58 Offset: 0x3018A58 VA: 0x301CA58
	protected void .ctor() { }

	// RVA: 0x301CA60 Offset: 0x3018A60 VA: 0x301CA60
	private static void .cctor() { }
}
