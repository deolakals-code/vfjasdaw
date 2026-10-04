// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class DateTimeStorage : DataStorage // TypeDefIndex: 14835
{
	// Fields
	private static readonly DateTime s_defaultValue; // 0x0
	private DateTime[] _values; // 0x50

	// Methods

	// RVA: 0x326D464 Offset: 0x3269464 VA: 0x326D464
	internal void .ctor(DataColumn column) { }

	// RVA: 0x326FD10 Offset: 0x326BD10 VA: 0x326FD10 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x32701D8 Offset: 0x326C1D8 VA: 0x32701D8 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3270350 Offset: 0x326C350 VA: 0x3270350 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x32704B4 Offset: 0x326C4B4 VA: 0x32704B4 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x3270604 Offset: 0x326C604 VA: 0x3270604 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3270658 Offset: 0x326C658 VA: 0x3270658 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x3270750 Offset: 0x326C750 VA: 0x3270750 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3270AC4 Offset: 0x326CAC4 VA: 0x3270AC4 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x3270B94 Offset: 0x326CB94 VA: 0x3270B94 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x3270C48 Offset: 0x326CC48 VA: 0x3270C48 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x3270CFC Offset: 0x326CCFC VA: 0x3270CFC Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x3270D44 Offset: 0x326CD44 VA: 0x3270D44 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x3270EA4 Offset: 0x326CEA4 VA: 0x3270EA4 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x32710C0 Offset: 0x326D0C0 VA: 0x32710C0
	private static void .cctor() { }
}
