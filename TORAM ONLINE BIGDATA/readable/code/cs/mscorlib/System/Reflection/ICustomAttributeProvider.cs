// Assembly: mscorlib.dll
// Namespace: System.Reflection
public interface ICustomAttributeProvider // TypeDefIndex: 10596
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object[] GetCustomAttributes(bool inherit);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsDefined(Type attributeType, bool inherit);
}
