// Assembly: System.dll
// Namespace: System.ComponentModel
public interface IContainer : IDisposable // TypeDefIndex: 14171
{
	// Properties
	public abstract ComponentCollection Components { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ComponentCollection get_Components();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Remove(IComponent component);
}
