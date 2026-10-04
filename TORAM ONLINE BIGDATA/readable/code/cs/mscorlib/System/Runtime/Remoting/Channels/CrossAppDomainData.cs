// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Channels
[Serializable]
internal class CrossAppDomainData // TypeDefIndex: 10251
{
	// Fields
	private object _ContextID; // 0x10
	private int _DomainID; // 0x18
	private string _processGuid; // 0x20

	// Properties
	internal int DomainID { get; }
	internal string ProcessID { get; }

	// Methods

	// RVA: 0x2ECDFCC Offset: 0x2EC9FCC VA: 0x2ECDFCC
	internal void .ctor(int domainId) { }

	// RVA: 0x2EE89CC Offset: 0x2EE49CC VA: 0x2EE89CC
	internal int get_DomainID() { }

	// RVA: 0x2EE89D4 Offset: 0x2EE49D4 VA: 0x2EE89D4
	internal string get_ProcessID() { }
}
