// Assembly: UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
internal interface IMemberInfo // TypeDefIndex: 17332
{
	// Properties
	public abstract string Name { get; }
	public abstract bool IsReadOnly { get; }
	public abstract Type ValueType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IEnumerable<Attribute> GetCustomAttributes();
}
