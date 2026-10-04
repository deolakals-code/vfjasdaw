// Assembly: System.Data.dll
// Namespace: System.Data
public class MergeFailedEventArgs : EventArgs // TypeDefIndex: 14747
{
	// Fields
	[CompilerGenerated]
	private readonly DataTable <Table>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <Conflict>k__BackingField; // 0x18

	// Properties
	public string Conflict { get; }

	// Methods

	// RVA: 0x3209974 Offset: 0x3205974 VA: 0x3209974
	public void .ctor(DataTable table, string conflict) { }

	[CompilerGenerated]
	// RVA: 0x32099FC Offset: 0x32059FC VA: 0x32099FC
	public string get_Conflict() { }
}
