// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SqlMoneyStorage : DataStorage // TypeDefIndex: 14854
{
	// Fields
	private SqlMoney[] _values; // 0x50

	// Methods

	// RVA: 0x328B7A8 Offset: 0x32877A8 VA: 0x328B7A8
	public void .ctor(DataColumn column) { }

	// RVA: 0x328B8E8 Offset: 0x32878E8 VA: 0x328B8E8 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x328C7EC Offset: 0x32887EC VA: 0x328C7EC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x328C894 Offset: 0x3288894 VA: 0x328C894 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x328C950 Offset: 0x3288950 VA: 0x328C950 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x328C9C8 Offset: 0x32889C8 VA: 0x328C9C8 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x328CA04 Offset: 0x3288A04 VA: 0x328CA04 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x328CA88 Offset: 0x3288A88 VA: 0x328CA88 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x328CB04 Offset: 0x3288B04 VA: 0x328CB04 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x328CB50 Offset: 0x3288B50 VA: 0x328CB50 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x328CC10 Offset: 0x3288C10 VA: 0x328CC10 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x328CEF8 Offset: 0x3288EF8 VA: 0x328CEF8 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x328D198 Offset: 0x3289198 VA: 0x328D198 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x328D1E0 Offset: 0x32891E0 VA: 0x328D1E0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x328D2E8 Offset: 0x32892E8 VA: 0x328D2E8 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
