// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContextAttribute // TypeDefIndex: 10241
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetPropertiesForNewContext(IConstructionCallMessage msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsContextOK(Context ctx, IConstructionCallMessage msg);
}
