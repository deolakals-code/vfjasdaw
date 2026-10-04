// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContextProperty // TypeDefIndex: 10242
{
	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Freeze(Context newContext);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsNewContextOK(Context newCtx);
}
