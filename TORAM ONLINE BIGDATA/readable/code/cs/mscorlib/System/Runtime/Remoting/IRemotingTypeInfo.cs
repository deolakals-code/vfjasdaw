// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public interface IRemotingTypeInfo // TypeDefIndex: 10195
{
	// Properties
	public abstract string TypeName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_TypeName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanCastTo(Type fromType, object o);
}
