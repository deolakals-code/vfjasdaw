// Assembly: System.Data.dll
// Namespace: System.Data
internal class ConstraintEnumerator // TypeDefIndex: 14677
{
	// Fields
	private IEnumerator _tables; // 0x10
	private IEnumerator _constraints; // 0x18
	private Constraint _currentObject; // 0x20

	// Properties
	protected Constraint CurrentObject { get; }

	// Methods

	// RVA: 0x31E1190 Offset: 0x31DD190 VA: 0x31E1190
	public void .ctor(DataSet dataSet) { }

	// RVA: 0x31E11F8 Offset: 0x31DD1F8 VA: 0x31E11F8
	public bool GetNext() { }

	// RVA: 0x31E1524 Offset: 0x31DD524 VA: 0x31E1524
	public Constraint GetConstraint() { }

	// RVA: 0x31E152C Offset: 0x31DD52C VA: 0x31E152C Slot: 4
	protected virtual bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0x31E1534 Offset: 0x31DD534 VA: 0x31E1534
	protected Constraint get_CurrentObject() { }
}
