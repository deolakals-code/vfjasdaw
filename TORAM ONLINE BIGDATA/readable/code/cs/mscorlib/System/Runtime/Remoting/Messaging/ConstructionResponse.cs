// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
[CLSCompliant(False)]
[Serializable]
public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage // TypeDefIndex: 10298
{
	// Properties
	public override IDictionary Properties { get; }

	// Methods

	// RVA: 0x2EEB418 Offset: 0x2EE7418 VA: 0x2EEB418
	internal void .ctor(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x2EF36C8 Offset: 0x2EEF6C8 VA: 0x2EF36C8
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x2EF3818 Offset: 0x2EEF818 VA: 0x2EF3818
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EF38A4 Offset: 0x2EEF8A4 VA: 0x2EF38A4 Slot: 22
	public override IDictionary get_Properties() { }
}
