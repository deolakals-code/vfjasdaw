// Assembly: mscorlib.dll
// Namespace: System.Buffers
public abstract class ArrayPool<T> // TypeDefIndex: 10987
{
	// Fields
	[CompilerGenerated]
	private static readonly ArrayPool<T> <Shared>k__BackingField; // 0x0

	// Properties
	public static ArrayPool<T> Shared { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static ArrayPool<T> get_Shared() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2831818 Offset: 0x282D818 VA: 0x2831818
	|-ArrayPool<byte>.get_Shared
	|
	|-RVA: 0x2831950 Offset: 0x282D950 VA: 0x2831950
	|-ArrayPool<char>.get_Shared
	|
	|-RVA: 0x2831A88 Offset: 0x282DA88 VA: 0x2831A88
	|-ArrayPool<int>.get_Shared
	|
	|-RVA: 0x2831BC0 Offset: 0x282DBC0 VA: 0x2831BC0
	|-ArrayPool<__Il2CppFullySharedGenericType>.get_Shared
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract T[] Rent(int minimumLength);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Return(T[] array, bool clearArray = False);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<__Il2CppFullySharedGenericType>.Return
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2831884 Offset: 0x282D884 VA: 0x2831884
	|-ArrayPool<byte>..ctor
	|
	|-RVA: 0x28319BC Offset: 0x282D9BC VA: 0x28319BC
	|-ArrayPool<char>..ctor
	|
	|-RVA: 0x2831AF4 Offset: 0x282DAF4 VA: 0x2831AF4
	|-ArrayPool<int>..ctor
	|
	|-RVA: 0x2831C2C Offset: 0x282DC2C VA: 0x2831C2C
	|-ArrayPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x283188C Offset: 0x282D88C VA: 0x283188C
	|-ArrayPool<byte>..cctor
	|
	|-RVA: 0x28319C4 Offset: 0x282D9C4 VA: 0x28319C4
	|-ArrayPool<char>..cctor
	|
	|-RVA: 0x2831AFC Offset: 0x282DAFC VA: 0x2831AFC
	|-ArrayPool<int>..cctor
	|
	|-RVA: 0x2831C34 Offset: 0x282DC34 VA: 0x2831C34
	|-ArrayPool<__Il2CppFullySharedGenericType>..cctor
	*/
}
