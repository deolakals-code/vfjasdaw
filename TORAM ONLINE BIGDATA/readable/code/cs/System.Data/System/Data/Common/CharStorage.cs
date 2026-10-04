// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class CharStorage : DataStorage // TypeDefIndex: 14831
{
	// Fields
	private char[] _values; // 0x50

	// Methods

	// RVA: 0x326B668 Offset: 0x3267668 VA: 0x326B668
	internal void .ctor(DataColumn column) { }

	// RVA: 0x326B75C Offset: 0x326775C VA: 0x326B75C Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x326BAE8 Offset: 0x3267AE8 VA: 0x326BAE8 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x326BBB0 Offset: 0x3267BB0 VA: 0x326BBB0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x326BCC8 Offset: 0x3267CC8 VA: 0x326BCC8 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x326BE18 Offset: 0x3267E18 VA: 0x326BE18 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x326BE6C Offset: 0x3267E6C VA: 0x326BE6C Slot: 9
	public override object Get(int record) { }

	// RVA: 0x326BF08 Offset: 0x3267F08 VA: 0x326BF08 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x326C0E8 Offset: 0x32680E8 VA: 0x326C0E8 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x326C1B8 Offset: 0x32681B8 VA: 0x326C1B8 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x326C244 Offset: 0x3268244 VA: 0x326C244 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x326C2DC Offset: 0x32682DC VA: 0x326C2DC Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x326C324 Offset: 0x3268324 VA: 0x326C324 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x326C424 Offset: 0x3268424 VA: 0x326C424 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
