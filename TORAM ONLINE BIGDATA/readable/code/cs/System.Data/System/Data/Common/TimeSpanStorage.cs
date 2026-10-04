// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class TimeSpanStorage : DataStorage // TypeDefIndex: 14862
{
	// Fields
	private static readonly TimeSpan s_defaultValue; // 0x0
	private TimeSpan[] _values; // 0x50

	// Methods

	// RVA: 0x3294690 Offset: 0x3290690 VA: 0x3294690
	public void .ctor(DataColumn column) { }

	// RVA: 0x32947BC Offset: 0x32907BC VA: 0x32947BC Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x32953F0 Offset: 0x32913F0 VA: 0x32953F0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x329556C Offset: 0x329156C VA: 0x329556C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x32956E0 Offset: 0x32916E0 VA: 0x32956E0
	private static TimeSpan ConvertToTimeSpan(object value) { }

	// RVA: 0x3295904 Offset: 0x3291904 VA: 0x3295904 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x32959B0 Offset: 0x32919B0 VA: 0x32959B0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3295A08 Offset: 0x3291A08 VA: 0x3295A08 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x3295B08 Offset: 0x3291B08 VA: 0x3295B08 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x3295BDC Offset: 0x3291BDC VA: 0x3295BDC Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x3295CB0 Offset: 0x3291CB0 VA: 0x3295CB0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x3295D3C Offset: 0x3291D3C VA: 0x3295D3C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x3295DD4 Offset: 0x3291DD4 VA: 0x3295DD4 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x3295E1C Offset: 0x3291E1C VA: 0x3295E1C Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x3295F1C Offset: 0x3291F1C VA: 0x3295F1C Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x3295FE0 Offset: 0x3291FE0 VA: 0x3295FE0
	private static void .cctor() { }
}
