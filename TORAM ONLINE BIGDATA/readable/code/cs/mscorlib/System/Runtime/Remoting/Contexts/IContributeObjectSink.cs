// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContributeObjectSink // TypeDefIndex: 10246
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink);
}
