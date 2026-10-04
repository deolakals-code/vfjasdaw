// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
internal class CADMethodReturnMessage : CADMessageBase // TypeDefIndex: 10293
{
	// Fields
	private object _returnValue; // 0x38
	private CADArgHolder _exception; // 0x40
	private Type[] _sig; // 0x48

	// Properties
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x2EF06B8 Offset: 0x2EEC6B8 VA: 0x2EF06B8
	internal static CADMethodReturnMessage Create(IMessage callMsg) { }

	// RVA: 0x2EF0738 Offset: 0x2EEC738 VA: 0x2EF0738
	internal void .ctor(IMethodReturnMessage retMsg) { }

	// RVA: 0x2EF0AF8 Offset: 0x2EECAF8 VA: 0x2EF0AF8
	internal ArrayList GetArguments() { }

	// RVA: 0x2EF0C40 Offset: 0x2EECC40 VA: 0x2EF0C40
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x2EF0C50 Offset: 0x2EECC50 VA: 0x2EF0C50
	internal object GetReturnValue(ArrayList args) { }

	// RVA: 0x2EF0C60 Offset: 0x2EECC60 VA: 0x2EF0C60
	internal Exception GetException(ArrayList args) { }

	// RVA: 0x2EF0D04 Offset: 0x2EECD04 VA: 0x2EF0D04
	internal int get_PropertiesCount() { }
}
