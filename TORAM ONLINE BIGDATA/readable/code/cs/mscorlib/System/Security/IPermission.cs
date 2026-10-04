// Assembly: mscorlib.dll
// Namespace: System.Security
public interface IPermission : ISecurityEncodable // TypeDefIndex: 10065
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Demand();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsSubsetOf(IPermission target);
}
