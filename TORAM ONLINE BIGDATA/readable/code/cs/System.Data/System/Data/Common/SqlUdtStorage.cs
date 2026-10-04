// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SqlUdtStorage : DataStorage // TypeDefIndex: 14860
{
	// Fields
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private readonly bool _implementsIComparable; // 0x59
	private static readonly ConcurrentDictionary<Type, object> s_typeToNull; // 0x0

	// Methods

	// RVA: 0x3292458 Offset: 0x328E458 VA: 0x3292458
	public void .ctor(DataColumn column, Type type) { }

	// RVA: 0x32925E4 Offset: 0x328E5E4 VA: 0x32925E4
	private void .ctor(DataColumn column, Type type, object nullValue) { }

	// RVA: 0x32924D0 Offset: 0x328E4D0 VA: 0x32924D0
	internal static object GetStaticNullForUdtType(Type type) { }

	// RVA: 0x3292774 Offset: 0x328E774 VA: 0x3292774 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x3292878 Offset: 0x328E878 VA: 0x3292878 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x32928A8 Offset: 0x328E8A8 VA: 0x32928A8 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x32928E0 Offset: 0x328E8E0 VA: 0x32928E0 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x3292B6C Offset: 0x328EB6C VA: 0x3292B6C Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3292BF4 Offset: 0x328EBF4 VA: 0x3292BF4 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x3292C24 Offset: 0x328EC24 VA: 0x3292C24 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x3292D94 Offset: 0x328ED94 VA: 0x3292D94 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x3292E68 Offset: 0x328EE68 VA: 0x3292E68 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x32931B4 Offset: 0x328F1B4 VA: 0x32931B4 Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x3293450 Offset: 0x328F450 VA: 0x3293450 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x329377C Offset: 0x328F77C VA: 0x329377C Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x32938D4 Offset: 0x328F8D4 VA: 0x32938D4 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x329391C Offset: 0x328F91C VA: 0x329391C Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x3293A5C Offset: 0x328FA5C VA: 0x3293A5C Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x3293AF8 Offset: 0x328FAF8 VA: 0x3293AF8
	private static void .cctor() { }
}
