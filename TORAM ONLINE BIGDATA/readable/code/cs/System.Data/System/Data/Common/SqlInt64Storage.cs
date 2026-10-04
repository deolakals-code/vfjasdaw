// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class SqlInt64Storage : DataStorage // TypeDefIndex: 14853
{
	// Fields
	private SqlInt64[] _values; // 0x50

	// Methods

	// RVA: 0x3289C2C Offset: 0x3285C2C VA: 0x3289C2C
	public void .ctor(DataColumn column) { }

	// RVA: 0x3289D6C Offset: 0x3285D6C VA: 0x3289D6C Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x328AC10 Offset: 0x3286C10 VA: 0x328AC10 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x328ACB8 Offset: 0x3286CB8 VA: 0x328ACB8 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x328AD74 Offset: 0x3286D74 VA: 0x328AD74 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x328ADEC Offset: 0x3286DEC VA: 0x328ADEC Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x328AE28 Offset: 0x3286E28 VA: 0x328AE28 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x328AEAC Offset: 0x3286EAC VA: 0x328AEAC Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x328AF28 Offset: 0x3286F28 VA: 0x328AF28 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x328AF74 Offset: 0x3286F74 VA: 0x328AF74 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x328B034 Offset: 0x3287034 VA: 0x328B034 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x328B31C Offset: 0x328731C VA: 0x328B31C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x328B5BC Offset: 0x32875BC VA: 0x328B5BC Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x328B604 Offset: 0x3287604 VA: 0x328B604 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x328B70C Offset: 0x328770C VA: 0x328B70C Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
