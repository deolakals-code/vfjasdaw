// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IDynamicMessageSink // TypeDefIndex: 10248
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync);
}
