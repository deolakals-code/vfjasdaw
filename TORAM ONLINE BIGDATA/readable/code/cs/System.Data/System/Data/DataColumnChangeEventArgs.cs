// Assembly: System.Data.dll
// Namespace: System.Data
public class DataColumnChangeEventArgs : EventArgs // TypeDefIndex: 14681
{
	// Fields
	private DataColumn _column; // 0x10
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; // 0x18
	[CompilerGenerated]
	private object <ProposedValue>k__BackingField; // 0x20

	// Properties
	public object ProposedValue { get; set; }

	// Methods

	// RVA: 0x31E17B4 Offset: 0x31DD7B4 VA: 0x31E17B4
	internal void .ctor(DataRow row) { }

	// RVA: 0x31E1828 Offset: 0x31DD828 VA: 0x31E1828
	public void .ctor(DataRow row, DataColumn column, object value) { }

	[CompilerGenerated]
	// RVA: 0x31E18CC Offset: 0x31DD8CC VA: 0x31E18CC
	public object get_ProposedValue() { }

	[CompilerGenerated]
	// RVA: 0x31E18D4 Offset: 0x31DD8D4 VA: 0x31E18D4
	public void set_ProposedValue(object value) { }

	// RVA: 0x31E18DC Offset: 0x31DD8DC VA: 0x31E18DC
	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }
}
