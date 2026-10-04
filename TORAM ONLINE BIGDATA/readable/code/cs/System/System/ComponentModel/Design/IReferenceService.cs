// Assembly: System.dll
// Namespace: System.ComponentModel.Design
public interface IReferenceService // TypeDefIndex: 14283
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetReference(string name);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetName(object reference);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object[] GetReferences(Type baseType);
}
