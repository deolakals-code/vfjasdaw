// Assembly: mscorlib.dll
// Namespace: System.Buffers
public abstract class MemoryManager<T> // TypeDefIndex: 10992
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Span<T> GetSpan();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemoryManager<__Il2CppFullySharedGenericType>.GetSpan
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract MemoryHandle Pin(int elementIndex = 0);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemoryManager<__Il2CppFullySharedGenericType>.Pin
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected internal virtual bool TryGetArray(out ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA59FC Offset: 0x2BA19FC VA: 0x2BA59FC
	|-MemoryManager<byte>.TryGetArray
	|
	|-RVA: 0x2BA5A08 Offset: 0x2BA1A08 VA: 0x2BA5A08
	|-MemoryManager<__Il2CppFullySharedGenericType>.TryGetArray
	*/
}
