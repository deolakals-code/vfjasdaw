// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json
[NullableContext(1)]
public interface IArrayPool<T> // TypeDefIndex: 15833
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T[] Rent(int minimumLength);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IArrayPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Return(T[] array);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IArrayPool<__Il2CppFullySharedGenericType>.Return
	*/
}
