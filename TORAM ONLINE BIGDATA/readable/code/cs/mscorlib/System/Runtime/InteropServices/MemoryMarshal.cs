// Assembly: mscorlib.dll
// Namespace: System.Runtime.InteropServices
public static class MemoryMarshal // TypeDefIndex: 10438
{
	// Methods

	// RVA: -1 Offset: -1
	public static Span<byte> AsBytes<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DA668 Offset: 0x26D6668 VA: 0x26DA668
	|-MemoryMarshal.AsBytes<char>
	|
	|-RVA: 0x26DA8C8 Offset: 0x26D68C8 VA: 0x26DA8C8
	|-MemoryMarshal.AsBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<byte> AsBytes<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DA6D8 Offset: 0x26D66D8 VA: 0x26DA6D8
	|-MemoryMarshal.AsBytes<ushort>
	|
	|-RVA: 0x26DA748 Offset: 0x26D6748 VA: 0x26DA748
	|-MemoryMarshal.AsBytes<uint>
	|
	|-RVA: 0x26DA7B8 Offset: 0x26D67B8 VA: 0x26DA7B8
	|-MemoryMarshal.AsBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> AsMemory<T>(ReadOnlyMemory<T> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DA9D8 Offset: 0x26D69D8 VA: 0x26DA9D8
	|-MemoryMarshal.AsMemory<byte>
	|
	|-RVA: 0x26DA9DC Offset: 0x26D69DC VA: 0x26DA9DC
	|-MemoryMarshal.AsMemory<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DABE8 Offset: 0x26D6BE8 VA: 0x26DABE8
	|-MemoryMarshal.GetReference<byte>
	|
	|-RVA: 0x26DABF0 Offset: 0x26D6BF0 VA: 0x26DABF0
	|-MemoryMarshal.GetReference<char>
	|
	|-RVA: 0x26DAC00 Offset: 0x26D6C00 VA: 0x26DAC00
	|-MemoryMarshal.GetReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DABE4 Offset: 0x26D6BE4 VA: 0x26DABE4
	|-MemoryMarshal.GetReference<byte>
	|
	|-RVA: 0x26DABEC Offset: 0x26D6BEC VA: 0x26DABEC
	|-MemoryMarshal.GetReference<char>
	|
	|-RVA: 0x26DABF4 Offset: 0x26D6BF4 VA: 0x26DABF4
	|-MemoryMarshal.GetReference<ushort>
	|
	|-RVA: 0x26DABF8 Offset: 0x26D6BF8 VA: 0x26DABF8
	|-MemoryMarshal.GetReference<uint>
	|
	|-RVA: 0x26DABFC Offset: 0x26D6BFC VA: 0x26DABFC
	|-MemoryMarshal.GetReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static ref T GetNonNullPinnableReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DAAB0 Offset: 0x26D6AB0 VA: 0x26DAAB0
	|-MemoryMarshal.GetNonNullPinnableReference<byte>
	|
	|-RVA: 0x26DAB18 Offset: 0x26D6B18 VA: 0x26DAB18
	|-MemoryMarshal.GetNonNullPinnableReference<char>
	|
	|-RVA: 0x26DAB98 Offset: 0x26D6B98 VA: 0x26DAB98
	|-MemoryMarshal.GetNonNullPinnableReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static ref T GetNonNullPinnableReference<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DAA7C Offset: 0x26D6A7C VA: 0x26DAA7C
	|-MemoryMarshal.GetNonNullPinnableReference<byte>
	|
	|-RVA: 0x26DAAE4 Offset: 0x26D6AE4 VA: 0x26DAAE4
	|-MemoryMarshal.GetNonNullPinnableReference<char>
	|
	|-RVA: 0x26DAB4C Offset: 0x26D6B4C VA: 0x26DAB4C
	|-MemoryMarshal.GetNonNullPinnableReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<T> CreateReadOnlySpan<T>(ref T reference, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DA9E0 Offset: 0x26D69E0 VA: 0x26DA9E0
	|-MemoryMarshal.CreateReadOnlySpan<char>
	|
	|-RVA: 0x26DAA14 Offset: 0x26D6A14 VA: 0x26DAA14
	|-MemoryMarshal.CreateReadOnlySpan<uint>
	|
	|-RVA: 0x26DAA48 Offset: 0x26D6A48 VA: 0x26DAA48
	|-MemoryMarshal.CreateReadOnlySpan<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetArray<T>(ReadOnlyMemory<T> memory, out ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DAC04 Offset: 0x26D6C04 VA: 0x26DAC04
	|-MemoryMarshal.TryGetArray<byte>
	|
	|-RVA: 0x26DAE40 Offset: 0x26D6E40 VA: 0x26DAE40
	|-MemoryMarshal.TryGetArray<__Il2CppFullySharedGenericType>
	*/
}
