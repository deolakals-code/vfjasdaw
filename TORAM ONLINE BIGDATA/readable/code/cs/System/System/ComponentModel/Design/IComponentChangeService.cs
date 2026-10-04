// Assembly: System.dll
// Namespace: System.ComponentModel.Design
public interface IComponentChangeService // TypeDefIndex: 14278
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnComponentChanging(object component, MemberDescriptor member);
}
