// Assembly: UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
[StaticAccessor("UnsafeUtility", 2)]
[NativeHeader("Runtime/Export/Unsafe/UnsafeUtility.bindings.h")]
public static class UnsafeUtility // TypeDefIndex: 16187
{
	// Methods

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x37CC318 Offset: 0x37C8318 VA: 0x37CC318
	public static void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x37CC0D0 Offset: 0x37C80D0 VA: 0x37CC0D0
	public static void FreeTracked(void* memory, Allocator allocator) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x37CBEA0 Offset: 0x37C7EA0 VA: 0x37CBEA0
	public static void MemCpy(void* destination, void* source, long size) { }

	// RVA: -1 Offset: -1
	public static int AlignOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26FB6E0 Offset: 0x26F76E0 VA: 0x26FB6E0
	|-UnsafeUtility.AlignOf<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0x26FB6FC Offset: 0x26F76FC VA: 0x26FB6FC
	|-UnsafeUtility.AlignOf<byte>
	|
	|-RVA: 0x26FB718 Offset: 0x26F7718 VA: 0x26FB718
	|-UnsafeUtility.AlignOf<ContactPairHeader>
	|
	|-RVA: 0x26FB734 Offset: 0x26F7734 VA: 0x26FB734
	|-UnsafeUtility.AlignOf<CullingSplit>
	|
	|-RVA: 0x26FB750 Offset: 0x26F7750 VA: 0x26FB750
	|-UnsafeUtility.AlignOf<int>
	|
	|-RVA: 0x26FB76C Offset: 0x26F776C VA: 0x26FB76C
	|-UnsafeUtility.AlignOf<LightDataGI>
	|
	|-RVA: 0x26FB788 Offset: 0x26F7788 VA: 0x26FB788
	|-UnsafeUtility.AlignOf<Matrix4x4>
	|
	|-RVA: 0x26FB7A4 Offset: 0x26F77A4 VA: 0x26FB7A4
	|-UnsafeUtility.AlignOf<ModifiableContactPair>
	|
	|-RVA: 0x26FB7C0 Offset: 0x26F77C0 VA: 0x26FB7C0
	|-UnsafeUtility.AlignOf<Plane>
	|
	|-RVA: 0x26FB7DC Offset: 0x26F77DC VA: 0x26FB7DC
	|-UnsafeUtility.AlignOf<Quaternion>
	|
	|-RVA: 0x26FB7F8 Offset: 0x26F77F8 VA: 0x26FB7F8
	|-UnsafeUtility.AlignOf<sbyte>
	|
	|-RVA: 0x26FB814 Offset: 0x26F7814 VA: 0x26FB814
	|-UnsafeUtility.AlignOf<Vector3>
	|
	|-RVA: 0x26FB830 Offset: 0x26F7830 VA: 0x26FB830
	|-UnsafeUtility.AlignOf<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static T ReadArrayElement<T>(void* source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26FB884 Offset: 0x26F7884 VA: 0x26FB884
	|-UnsafeUtility.ReadArrayElement<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0x26FB8A8 Offset: 0x26F78A8 VA: 0x26FB8A8
	|-UnsafeUtility.ReadArrayElement<byte>
	|
	|-RVA: 0x26FB8B0 Offset: 0x26F78B0 VA: 0x26FB8B0
	|-UnsafeUtility.ReadArrayElement<ContactPairHeader>
	|
	|-RVA: 0x26FB8CC Offset: 0x26F78CC VA: 0x26FB8CC
	|-UnsafeUtility.ReadArrayElement<CullingSplit>
	|
	|-RVA: 0x26FB8E0 Offset: 0x26F78E0 VA: 0x26FB8E0
	|-UnsafeUtility.ReadArrayElement<int>
	|
	|-RVA: 0x26FB8E8 Offset: 0x26F78E8 VA: 0x26FB8E8
	|-UnsafeUtility.ReadArrayElement<LightDataGI>
	|
	|-RVA: 0x26FB8FC Offset: 0x26F78FC VA: 0x26FB8FC
	|-UnsafeUtility.ReadArrayElement<Matrix4x4>
	|
	|-RVA: 0x26FB918 Offset: 0x26F7918 VA: 0x26FB918
	|-UnsafeUtility.ReadArrayElement<ModifiableContactPair>
	|
	|-RVA: 0x26FB92C Offset: 0x26F792C VA: 0x26FB92C
	|-UnsafeUtility.ReadArrayElement<Plane>
	|
	|-RVA: 0x26FB93C Offset: 0x26F793C VA: 0x26FB93C
	|-UnsafeUtility.ReadArrayElement<Quaternion>
	|
	|-RVA: 0x26FB94C Offset: 0x26F794C VA: 0x26FB94C
	|-UnsafeUtility.ReadArrayElement<sbyte>
	|
	|-RVA: 0x26FB954 Offset: 0x26F7954 VA: 0x26FB954
	|-UnsafeUtility.ReadArrayElement<Vector3>
	|
	|-RVA: 0x26FB968 Offset: 0x26F7968 VA: 0x26FB968
	|-UnsafeUtility.ReadArrayElement<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void WriteArrayElement<T>(void* destination, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26FBB10 Offset: 0x26F7B10 VA: 0x26FBB10
	|-UnsafeUtility.WriteArrayElement<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0x26FBB34 Offset: 0x26F7B34 VA: 0x26FBB34
	|-UnsafeUtility.WriteArrayElement<byte>
	|
	|-RVA: 0x26FBB3C Offset: 0x26F7B3C VA: 0x26FBB3C
	|-UnsafeUtility.WriteArrayElement<ContactPairHeader>
	|
	|-RVA: 0x26FBB58 Offset: 0x26F7B58 VA: 0x26FBB58
	|-UnsafeUtility.WriteArrayElement<CullingSplit>
	|
	|-RVA: 0x26FBB7C Offset: 0x26F7B7C VA: 0x26FBB7C
	|-UnsafeUtility.WriteArrayElement<int>
	|
	|-RVA: 0x26FBB84 Offset: 0x26F7B84 VA: 0x26FBB84
	|-UnsafeUtility.WriteArrayElement<LightDataGI>
	|
	|-RVA: 0x26FBBA8 Offset: 0x26F7BA8 VA: 0x26FBBA8
	|-UnsafeUtility.WriteArrayElement<Matrix4x4>
	|
	|-RVA: 0x26FBBC4 Offset: 0x26F7BC4 VA: 0x26FBBC4
	|-UnsafeUtility.WriteArrayElement<ModifiableContactPair>
	|
	|-RVA: 0x26FBBE8 Offset: 0x26F7BE8 VA: 0x26FBBE8
	|-UnsafeUtility.WriteArrayElement<Plane>
	|
	|-RVA: 0x26FBBF8 Offset: 0x26F7BF8 VA: 0x26FBBF8
	|-UnsafeUtility.WriteArrayElement<Quaternion>
	|
	|-RVA: 0x26FBC08 Offset: 0x26F7C08 VA: 0x26FBC08
	|-UnsafeUtility.WriteArrayElement<sbyte>
	|
	|-RVA: 0x26FBC10 Offset: 0x26F7C10 VA: 0x26FBC10
	|-UnsafeUtility.WriteArrayElement<Vector3>
	|
	|-RVA: 0x26FBC24 Offset: 0x26F7C24 VA: 0x26FBC24
	|-UnsafeUtility.WriteArrayElement<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26FBA20 Offset: 0x26F7A20 VA: 0x26FBA20
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BatchCullingOutputDrawCommands>>
	|
	|-RVA: 0x26FBA28 Offset: 0x26F7A28 VA: 0x26FBA28
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<byte>>
	|
	|-RVA: 0x26FBA30 Offset: 0x26F7A30 VA: 0x26FBA30
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ContactPairHeader>>
	|
	|-RVA: 0x26FBA38 Offset: 0x26F7A38 VA: 0x26FBA38
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<CullingSplit>>
	|
	|-RVA: 0x26FBA40 Offset: 0x26F7A40 VA: 0x26FBA40
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<int>>
	|
	|-RVA: 0x26FBA48 Offset: 0x26F7A48 VA: 0x26FBA48
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LightDataGI>>
	|
	|-RVA: 0x26FBA50 Offset: 0x26F7A50 VA: 0x26FBA50
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Matrix4x4>>
	|
	|-RVA: 0x26FBA58 Offset: 0x26F7A58 VA: 0x26FBA58
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ModifiableContactPair>>
	|
	|-RVA: 0x26FBA60 Offset: 0x26F7A60 VA: 0x26FBA60
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Plane>>
	|
	|-RVA: 0x26FBA68 Offset: 0x26F7A68 VA: 0x26FBA68
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Quaternion>>
	|
	|-RVA: 0x26FBA70 Offset: 0x26F7A70 VA: 0x26FBA70
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<sbyte>>
	|
	|-RVA: 0x26FBA78 Offset: 0x26F7A78 VA: 0x26FBA78
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector3>>
	|
	|-RVA: 0x26FBA80 Offset: 0x26F7A80 VA: 0x26FBA80
	|-UnsafeUtility.SizeOf<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0x26FBA88 Offset: 0x26F7A88 VA: 0x26FBA88
	|-UnsafeUtility.SizeOf<byte>
	|
	|-RVA: 0x26FBA90 Offset: 0x26F7A90 VA: 0x26FBA90
	|-UnsafeUtility.SizeOf<ContactPairHeader>
	|
	|-RVA: 0x26FBA98 Offset: 0x26F7A98 VA: 0x26FBA98
	|-UnsafeUtility.SizeOf<CullingSplit>
	|
	|-RVA: 0x26FBAA0 Offset: 0x26F7AA0 VA: 0x26FBAA0
	|-UnsafeUtility.SizeOf<int>
	|
	|-RVA: 0x26FBAA8 Offset: 0x26F7AA8 VA: 0x26FBAA8
	|-UnsafeUtility.SizeOf<IntPtr>
	|
	|-RVA: 0x26FBAB0 Offset: 0x26F7AB0 VA: 0x26FBAB0
	|-UnsafeUtility.SizeOf<LightDataGI>
	|
	|-RVA: 0x26FBAB8 Offset: 0x26F7AB8 VA: 0x26FBAB8
	|-UnsafeUtility.SizeOf<Matrix4x4>
	|
	|-RVA: 0x26FBAC0 Offset: 0x26F7AC0 VA: 0x26FBAC0
	|-UnsafeUtility.SizeOf<ModifiableContactPair>
	|
	|-RVA: 0x26FBAC8 Offset: 0x26F7AC8 VA: 0x26FBAC8
	|-UnsafeUtility.SizeOf<Plane>
	|
	|-RVA: 0x26FBAD0 Offset: 0x26F7AD0 VA: 0x26FBAD0
	|-UnsafeUtility.SizeOf<Quaternion>
	|
	|-RVA: 0x26FBAD8 Offset: 0x26F7AD8 VA: 0x26FBAD8
	|-UnsafeUtility.SizeOf<sbyte>
	|
	|-RVA: 0x26FBAE0 Offset: 0x26F7AE0 VA: 0x26FBAE0
	|-UnsafeUtility.SizeOf<Vector3>
	|
	|-RVA: 0x26FBAE8 Offset: 0x26F7AE8 VA: 0x26FBAE8
	|-UnsafeUtility.SizeOf<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(void* ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26FB87C Offset: 0x26F787C VA: 0x26FB87C
	|-UnsafeUtility.AsRef<IntPtr>
	|
	|-RVA: 0x26FB880 Offset: 0x26F7880 VA: 0x26FB880
	|-UnsafeUtility.AsRef<__Il2CppFullySharedGenericStructType>
	*/
}
