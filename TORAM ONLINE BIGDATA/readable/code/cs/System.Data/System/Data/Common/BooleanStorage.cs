// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal sealed class BooleanStorage : DataStorage // TypeDefIndex: 14829
{
	// Fields
	private bool[] _values; // 0x50

	// Methods

	// RVA: 0x326961C Offset: 0x326561C VA: 0x326961C
	internal void .ctor(DataColumn column) { }

	// RVA: 0x3269710 Offset: 0x3265710 VA: 0x3269710 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x3269AC0 Offset: 0x3265AC0 VA: 0x3269AC0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x3269B8C Offset: 0x3265B8C VA: 0x3269B8C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x3269CA4 Offset: 0x3265CA4 VA: 0x3269CA4 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x3269DF8 Offset: 0x3265DF8 VA: 0x3269DF8 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x3269E4C Offset: 0x3265E4C VA: 0x3269E4C Slot: 9
	public override object Get(int record) { }

	// RVA: 0x3269EE8 Offset: 0x3265EE8 VA: 0x3269EE8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x326A070 Offset: 0x3266070 VA: 0x326A070 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x326A140 Offset: 0x3266140 VA: 0x326A140 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x326A1D0 Offset: 0x32661D0 VA: 0x326A1D0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x326A268 Offset: 0x3266268 VA: 0x326A268 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x326A2B0 Offset: 0x32662B0 VA: 0x326A2B0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x326A3B0 Offset: 0x32663B0 VA: 0x326A3B0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
