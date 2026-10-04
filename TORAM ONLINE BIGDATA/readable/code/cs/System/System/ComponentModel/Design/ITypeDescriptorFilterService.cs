// Assembly: System.dll
// Namespace: System.ComponentModel.Design
public interface ITypeDescriptorFilterService // TypeDefIndex: 14284
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool FilterAttributes(IComponent component, IDictionary attributes);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool FilterEvents(IComponent component, IDictionary events);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool FilterProperties(IComponent component, IDictionary properties);
}
