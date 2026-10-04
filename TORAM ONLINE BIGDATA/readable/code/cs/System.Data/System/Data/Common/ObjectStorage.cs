// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class ObjectStorage : DataStorage // TypeDefIndex: 14826
{
	// Fields
	private static readonly object s_defaultValue; // 0x0
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private static readonly object s_tempAssemblyCacheLock; // 0x8
	private static Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache; // 0x10
	private static readonly XmlSerializerFactory s_serializerFactory; // 0x18

	// Methods

	// RVA: 0x3261144 Offset: 0x325D144 VA: 0x3261144
	internal void .ctor(DataColumn column, Type type) { }

	// RVA: 0x3261554 Offset: 0x325D554 VA: 0x3261554 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x3261584 Offset: 0x325D584 VA: 0x3261584 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3261BF8 Offset: 0x325DBF8 VA: 0x3261BF8 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x3261DDC Offset: 0x325DDDC VA: 0x3261DDC
	private int CompareTo(object valueNo1, object valueNo2) { }

	// RVA: 0x3261738 Offset: 0x325D738 VA: 0x3261738
	private int CompareWithFamilies(object valueNo1, object valueNo2) { }

	// RVA: 0x32620C4 Offset: 0x325E0C4 VA: 0x32620C4 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x326213C Offset: 0x325E13C VA: 0x326213C Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x3261FB4 Offset: 0x325DFB4 VA: 0x3261FB4
	private ObjectStorage.Families GetFamily(Type dataType) { }

	// RVA: 0x3262178 Offset: 0x325E178 VA: 0x3262178 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x32621B0 Offset: 0x325E1B0 VA: 0x32621B0 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x3262AA0 Offset: 0x325EAA0 VA: 0x3262AA0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x3262B60 Offset: 0x325EB60 VA: 0x3262B60 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x326312C Offset: 0x325F12C VA: 0x326312C Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x3265C4C Offset: 0x3261C4C VA: 0x3265C4C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x3266320 Offset: 0x3262320 VA: 0x3266320 Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x3266484 Offset: 0x3262484 VA: 0x3266484 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x32664CC Offset: 0x32624CC VA: 0x32664CC Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x32666E0 Offset: 0x32626E0 VA: 0x32666E0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x32668C8 Offset: 0x32628C8 VA: 0x32668C8
	internal static void VerifyIDynamicMetaObjectProvider(Type type) { }

	// RVA: 0x32630B8 Offset: 0x325F0B8 VA: 0x32630B8
	internal static XmlSerializer GetXmlSerializer(Type type) { }

	// RVA: 0x3265654 Offset: 0x3261654 VA: 0x3265654
	internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

	// RVA: 0x3266A80 Offset: 0x3262A80 VA: 0x3266A80
	private static void .cctor() { }
}
