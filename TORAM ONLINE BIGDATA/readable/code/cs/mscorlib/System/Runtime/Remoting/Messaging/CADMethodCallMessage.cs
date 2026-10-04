// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
internal class CADMethodCallMessage : CADMessageBase // TypeDefIndex: 10292
{
	// Fields
	private string _uri; // 0x38

	// Properties
	internal string Uri { get; }
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x2EF02B8 Offset: 0x2EEC2B8 VA: 0x2EF02B8
	internal string get_Uri() { }

	// RVA: 0x2EF02C0 Offset: 0x2EEC2C0 VA: 0x2EF02C0
	internal static CADMethodCallMessage Create(IMessage callMsg) { }

	// RVA: 0x2EF0340 Offset: 0x2EEC340 VA: 0x2EF0340
	internal void .ctor(IMethodCallMessage callMsg) { }

	// RVA: 0x2EF0558 Offset: 0x2EEC558 VA: 0x2EF0558
	internal ArrayList GetArguments() { }

	// RVA: 0x2EF06A0 Offset: 0x2EEC6A0 VA: 0x2EF06A0
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x2EF06B0 Offset: 0x2EEC6B0 VA: 0x2EF06B0
	internal int get_PropertiesCount() { }
}
