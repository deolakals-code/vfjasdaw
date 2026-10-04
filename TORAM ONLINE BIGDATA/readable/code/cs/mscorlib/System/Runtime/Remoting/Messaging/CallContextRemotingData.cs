// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class CallContextRemotingData : ICloneable // TypeDefIndex: 10284
{
	// Fields
	private string _logicalCallID; // 0x10

	// Properties
	internal string LogicalCallID { get; set; }
	internal bool HasInfo { get; }

	// Methods

	// RVA: 0x2EED49C Offset: 0x2EE949C VA: 0x2EED49C
	internal string get_LogicalCallID() { }

	// RVA: 0x2EED4A4 Offset: 0x2EE94A4 VA: 0x2EED4A4
	internal void set_LogicalCallID(string value) { }

	// RVA: 0x2EED348 Offset: 0x2EE9348 VA: 0x2EED348
	internal bool get_HasInfo() { }

	// RVA: 0x2EECFD8 Offset: 0x2EE8FD8 VA: 0x2EECFD8 Slot: 4
	public object Clone() { }

	// RVA: 0x2EED4AC Offset: 0x2EE94AC VA: 0x2EED4AC
	public void .ctor() { }
}
