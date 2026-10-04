// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal abstract class DataStorage // TypeDefIndex: 14833
{
	// Fields
	private static readonly Type[] s_storageClassType; // 0x0
	internal readonly DataColumn _column; // 0x10
	internal readonly DataTable _table; // 0x18
	internal readonly Type _dataType; // 0x20
	internal readonly StorageType _storageTypeCode; // 0x28
	private BitArray _dbNullBits; // 0x30
	private readonly object _defaultValue; // 0x38
	internal readonly object _nullValue; // 0x40
	internal readonly bool _isCloneable; // 0x48
	internal readonly bool _isCustomDefinedType; // 0x49
	internal readonly bool _isStringType; // 0x4A
	internal readonly bool _isValueType; // 0x4B
	private static readonly Func<Type, Tuple<bool, bool, bool, bool>> s_inspectTypeForInterfaces; // 0x8
	private static readonly ConcurrentDictionary<Type, Tuple<bool, bool, bool, bool>> s_typeImplementsInterface; // 0x10

	// Properties
	internal DataSetDateTime DateTimeMode { get; }
	internal IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x3267A60 Offset: 0x3263A60 VA: 0x3267A60
	protected void .ctor(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	// RVA: 0x326C4E8 Offset: 0x32684E8 VA: 0x326C4E8
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	// RVA: 0x3261400 Offset: 0x325D400 VA: 0x3261400
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	// RVA: 0x326C554 Offset: 0x3268554 VA: 0x326C554
	internal DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x32620A8 Offset: 0x325E0A8 VA: 0x32620A8
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x3269AAC Offset: 0x3265AAC VA: 0x3269AAC Slot: 4
	public virtual object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x326C570 Offset: 0x3268570 VA: 0x326C570
	public object AggregateCount(int[] recordNos) { }

	// RVA: 0x3267C3C Offset: 0x3263C3C VA: 0x3267C3C
	protected int CompareBits(int recordNo1, int recordNo2) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int Compare(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int CompareValueTo(int recordNo1, object value);

	// RVA: 0x326C63C Offset: 0x326863C VA: 0x326C63C Slot: 7
	public virtual object ConvertValue(object value) { }

	// RVA: 0x3268E64 Offset: 0x3264E64 VA: 0x3268E64
	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Copy(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract object Get(int recordNo);

	// RVA: 0x3268F60 Offset: 0x3264F60 VA: 0x3268F60
	protected object GetBits(int recordNo) { }

	// RVA: 0x326C644 Offset: 0x3268644 VA: 0x326C644 Slot: 10
	public virtual int GetStringLength(int record) { }

	// RVA: 0x3267DD4 Offset: 0x3263DD4 VA: 0x3267DD4
	protected bool HasValue(int recordNo) { }

	// RVA: 0x326C64C Offset: 0x326864C VA: 0x326C64C Slot: 11
	public virtual bool IsNull(int recordNo) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Set(int recordNo, object value);

	// RVA: 0x32690E8 Offset: 0x32650E8 VA: 0x32690E8
	protected void SetNullBit(int recordNo, bool flag) { }

	// RVA: 0x32691D8 Offset: 0x32651D8 VA: 0x32691D8 Slot: 13
	public virtual void SetCapacity(int capacity) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object ConvertXmlToObject(string s);

	// RVA: 0x326C668 Offset: 0x3268668 VA: 0x326C668 Slot: 15
	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract string ConvertObjectToXml(object value);

	// RVA: 0x326C6A8 Offset: 0x32686A8 VA: 0x326C6A8 Slot: 17
	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x326C6E4 Offset: 0x32686E4 VA: 0x326C6E4
	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	// RVA: 0x32612E4 Offset: 0x325D2E4 VA: 0x32612E4
	internal static StorageType GetStorageType(Type dataType) { }

	// RVA: 0x326D6BC Offset: 0x32696BC VA: 0x326D6BC
	internal static Type GetTypeStorage(StorageType storageType) { }

	// RVA: 0x32662A8 Offset: 0x32622A8 VA: 0x32662A8
	internal static bool IsTypeCustomType(Type type) { }

	// RVA: 0x326C4F4 Offset: 0x32684F4 VA: 0x326C4F4
	internal static bool IsTypeCustomType(StorageType typeCode) { }

	// RVA: 0x326D738 Offset: 0x3269738 VA: 0x326D738
	internal static bool IsSqlType(StorageType storageType) { }

	// RVA: 0x326D744 Offset: 0x3269744 VA: 0x326D744
	public static bool IsSqlType(Type dataType) { }

	// RVA: 0x326C518 Offset: 0x3268518 VA: 0x326C518
	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	// RVA: 0x326D840 Offset: 0x3269840 VA: 0x326D840
	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking) { }

	// RVA: 0x326D994 Offset: 0x3269994 VA: 0x326D994
	private static Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(Type dataType) { }

	// RVA: 0x326DB4C Offset: 0x3269B4C VA: 0x326DB4C
	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	// RVA: 0x326DC20 Offset: 0x3269C20 VA: 0x326DC20
	public static bool IsObjectNull(object value) { }

	// RVA: 0x326DCC0 Offset: 0x3269CC0 VA: 0x326DCC0
	public static bool IsObjectSqlNull(object value) { }

	// RVA: 0x326DD74 Offset: 0x3269D74 VA: 0x326DD74
	internal object GetEmptyStorageInternal(int recordCount) { }

	// RVA: 0x326DD84 Offset: 0x3269D84 VA: 0x326DD84
	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x326DD94 Offset: 0x3269D94 VA: 0x326DD94
	internal void SetStorageInternal(object store, BitArray nullbits) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract object GetEmptyStorage(int recordCount);

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex);

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void SetStorage(object store, BitArray nullbits);

	// RVA: 0x326DDA4 Offset: 0x3269DA4 VA: 0x326DDA4
	protected void SetNullStorage(BitArray nullbits) { }

	// RVA: 0x3263814 Offset: 0x325F814 VA: 0x3263814
	internal static Type GetType(string value) { }

	// RVA: 0x326DDAC Offset: 0x3269DAC VA: 0x326DDAC
	internal static string GetQualifiedName(Type type) { }

	// RVA: 0x326DE1C Offset: 0x3269E1C VA: 0x326DE1C
	private static void .cctor() { }
}
