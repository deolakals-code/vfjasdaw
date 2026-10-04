// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SqlInt32Storage : DataStorage // TypeDefIndex: 14852
{
	// Fields
	private SqlInt32[] _values; // 0x50

	// Methods

	// RVA: 0x328814C Offset: 0x328414C VA: 0x328814C
	public void .ctor(DataColumn column) { }

	// RVA: 0x328828C Offset: 0x328428C VA: 0x328828C Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x32890AC Offset: 0x32850AC VA: 0x32890AC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x328914C Offset: 0x328514C VA: 0x328914C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x3289208 Offset: 0x3285208 VA: 0x3289208 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x3289280 Offset: 0x3285280 VA: 0x3289280 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x32892BC Offset: 0x32852BC VA: 0x32892BC Slot: 9
	public override object Get(int record) { }

	// RVA: 0x328933C Offset: 0x328533C VA: 0x328933C Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x32893B8 Offset: 0x32853B8 VA: 0x32893B8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3289400 Offset: 0x3285400 VA: 0x3289400 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x32894C0 Offset: 0x32854C0 VA: 0x32894C0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x32897A8 Offset: 0x32857A8 VA: 0x32897A8 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x3289A48 Offset: 0x3285A48 VA: 0x3289A48 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x3289A90 Offset: 0x3285A90 VA: 0x3289A90 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x3289B90 Offset: 0x3285B90 VA: 0x3289B90 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
