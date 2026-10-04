// Assembly: UnityEngine.CoreModule.dll
// Namespace: 
[DebuggerTypeProxy(typeof(NativeArrayReadOnlyDebugView<T>))]
[NativeContainer]
[DebuggerDisplay("Length = {Length}")]
[DefaultMember("Item")]
[NativeContainerIsReadOnly]
public struct NativeArray.ReadOnly<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 16162
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal void* m_Buffer; // 0x0
	internal int m_Length; // 0x0

	// Properties
	public int Length { get; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(void* buffer, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BFF7E4 Offset: 0x2BFB7E4 VA: 0x2BFF7E4
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>..ctor
	|
	|-RVA: 0x2BFF9E8 Offset: 0x2BFB9E8 VA: 0x2BFF9E8
	|-NativeArray.ReadOnly<byte>..ctor
	|
	|-RVA: 0x2BFFB98 Offset: 0x2BFBB98 VA: 0x2BFFB98
	|-NativeArray.ReadOnly<ContactPairHeader>..ctor
	|
	|-RVA: 0x2BFFD80 Offset: 0x2BFBD80 VA: 0x2BFFD80
	|-NativeArray.ReadOnly<CullingSplit>..ctor
	|
	|-RVA: 0x2BFFF94 Offset: 0x2BFBF94 VA: 0x2BFFF94
	|-NativeArray.ReadOnly<int>..ctor
	|
	|-RVA: 0x2C00144 Offset: 0x2BFC144 VA: 0x2C00144
	|-NativeArray.ReadOnly<LightDataGI>..ctor
	|
	|-RVA: 0x2C00358 Offset: 0x2BFC358 VA: 0x2C00358
	|-NativeArray.ReadOnly<Matrix4x4>..ctor
	|
	|-RVA: 0x2C00550 Offset: 0x2BFC550 VA: 0x2C00550
	|-NativeArray.ReadOnly<ModifiableContactPair>..ctor
	|
	|-RVA: 0x2C00770 Offset: 0x2BFC770 VA: 0x2C00770
	|-NativeArray.ReadOnly<Plane>..ctor
	|
	|-RVA: 0x2C00934 Offset: 0x2BFC934 VA: 0x2C00934
	|-NativeArray.ReadOnly<Quaternion>..ctor
	|
	|-RVA: 0x2C00AF8 Offset: 0x2BFCAF8 VA: 0x2C00AF8
	|-NativeArray.ReadOnly<sbyte>..ctor
	|
	|-RVA: 0x2C00CA8 Offset: 0x2BFCCA8 VA: 0x2C00CA8
	|-NativeArray.ReadOnly<Vector3>..ctor
	|
	|-RVA: 0x2C00E48 Offset: 0x2BFCE48 VA: 0x2C00E48
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BFF7F0 Offset: 0x2BFB7F0 VA: 0x2BFF7F0
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>.get_Length
	|
	|-RVA: 0x2BFF9F4 Offset: 0x2BFB9F4 VA: 0x2BFF9F4
	|-NativeArray.ReadOnly<byte>.get_Length
	|
	|-RVA: 0x2BFFBA4 Offset: 0x2BFBBA4 VA: 0x2BFFBA4
	|-NativeArray.ReadOnly<ContactPairHeader>.get_Length
	|
	|-RVA: 0x2BFFD8C Offset: 0x2BFBD8C VA: 0x2BFFD8C
	|-NativeArray.ReadOnly<CullingSplit>.get_Length
	|
	|-RVA: 0x2BFFFA0 Offset: 0x2BFBFA0 VA: 0x2BFFFA0
	|-NativeArray.ReadOnly<int>.get_Length
	|
	|-RVA: 0x2C00150 Offset: 0x2BFC150 VA: 0x2C00150
	|-NativeArray.ReadOnly<LightDataGI>.get_Length
	|
	|-RVA: 0x2C00364 Offset: 0x2BFC364 VA: 0x2C00364
	|-NativeArray.ReadOnly<Matrix4x4>.get_Length
	|
	|-RVA: 0x2C0055C Offset: 0x2BFC55C VA: 0x2C0055C
	|-NativeArray.ReadOnly<ModifiableContactPair>.get_Length
	|
	|-RVA: 0x2C0077C Offset: 0x2BFC77C VA: 0x2C0077C
	|-NativeArray.ReadOnly<Plane>.get_Length
	|
	|-RVA: 0x2C00940 Offset: 0x2BFC940 VA: 0x2C00940
	|-NativeArray.ReadOnly<Quaternion>.get_Length
	|
	|-RVA: 0x2C00B04 Offset: 0x2BFCB04 VA: 0x2C00B04
	|-NativeArray.ReadOnly<sbyte>.get_Length
	|
	|-RVA: 0x2C00CB4 Offset: 0x2BFCCB4 VA: 0x2C00CB4
	|-NativeArray.ReadOnly<Vector3>.get_Length
	|
	|-RVA: 0x2C00E54 Offset: 0x2BFCE54 VA: 0x2C00E54
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BFF7F8 Offset: 0x2BFB7F8 VA: 0x2BFF7F8
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>.get_Item
	|
	|-RVA: 0x2BFF9FC Offset: 0x2BFB9FC VA: 0x2BFF9FC
	|-NativeArray.ReadOnly<byte>.get_Item
	|
	|-RVA: 0x2BFFBAC Offset: 0x2BFBBAC VA: 0x2BFFBAC
	|-NativeArray.ReadOnly<ContactPairHeader>.get_Item
	|
	|-RVA: 0x2BFFD94 Offset: 0x2BFBD94 VA: 0x2BFFD94
	|-NativeArray.ReadOnly<CullingSplit>.get_Item
	|
	|-RVA: 0x2BFFFA8 Offset: 0x2BFBFA8 VA: 0x2BFFFA8
	|-NativeArray.ReadOnly<int>.get_Item
	|
	|-RVA: 0x2C00158 Offset: 0x2BFC158 VA: 0x2C00158
	|-NativeArray.ReadOnly<LightDataGI>.get_Item
	|
	|-RVA: 0x2C0036C Offset: 0x2BFC36C VA: 0x2C0036C
	|-NativeArray.ReadOnly<Matrix4x4>.get_Item
	|
	|-RVA: 0x2C00564 Offset: 0x2BFC564 VA: 0x2C00564
	|-NativeArray.ReadOnly<ModifiableContactPair>.get_Item
	|
	|-RVA: 0x2C00784 Offset: 0x2BFC784 VA: 0x2C00784
	|-NativeArray.ReadOnly<Plane>.get_Item
	|
	|-RVA: 0x2C00948 Offset: 0x2BFC948 VA: 0x2C00948
	|-NativeArray.ReadOnly<Quaternion>.get_Item
	|
	|-RVA: 0x2C00B0C Offset: 0x2BFCB0C VA: 0x2C00B0C
	|-NativeArray.ReadOnly<sbyte>.get_Item
	|
	|-RVA: 0x2C00CBC Offset: 0x2BFCCBC VA: 0x2C00CBC
	|-NativeArray.ReadOnly<Vector3>.get_Item
	|
	|-RVA: 0x2C00E5C Offset: 0x2BFCE5C VA: 0x2C00E5C
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public NativeArray.ReadOnly.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BFF870 Offset: 0x2BFB870 VA: 0x2BFF870
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>.GetEnumerator
	|
	|-RVA: 0x2BFFA30 Offset: 0x2BFBA30 VA: 0x2BFFA30
	|-NativeArray.ReadOnly<byte>.GetEnumerator
	|
	|-RVA: 0x2BFFC14 Offset: 0x2BFBC14 VA: 0x2BFFC14
	|-NativeArray.ReadOnly<ContactPairHeader>.GetEnumerator
	|
	|-RVA: 0x2BFFE14 Offset: 0x2BFBE14 VA: 0x2BFFE14
	|-NativeArray.ReadOnly<CullingSplit>.GetEnumerator
	|
	|-RVA: 0x2BFFFDC Offset: 0x2BFBFDC VA: 0x2BFFFDC
	|-NativeArray.ReadOnly<int>.GetEnumerator
	|
	|-RVA: 0x2C001D8 Offset: 0x2BFC1D8 VA: 0x2C001D8
	|-NativeArray.ReadOnly<LightDataGI>.GetEnumerator
	|
	|-RVA: 0x2C003D4 Offset: 0x2BFC3D4 VA: 0x2C003D4
	|-NativeArray.ReadOnly<Matrix4x4>.GetEnumerator
	|
	|-RVA: 0x2C005F4 Offset: 0x2BFC5F4 VA: 0x2C005F4
	|-NativeArray.ReadOnly<ModifiableContactPair>.GetEnumerator
	|
	|-RVA: 0x2C007C0 Offset: 0x2BFC7C0 VA: 0x2C007C0
	|-NativeArray.ReadOnly<Plane>.GetEnumerator
	|
	|-RVA: 0x2C00984 Offset: 0x2BFC984 VA: 0x2C00984
	|-NativeArray.ReadOnly<Quaternion>.GetEnumerator
	|
	|-RVA: 0x2C00B40 Offset: 0x2BFCB40 VA: 0x2C00B40
	|-NativeArray.ReadOnly<sbyte>.GetEnumerator
	|
	|-RVA: 0x2C00CFC Offset: 0x2BFCCFC VA: 0x2C00CFC
	|-NativeArray.ReadOnly<Vector3>.GetEnumerator
	|
	|-RVA: 0x2C00FD4 Offset: 0x2BFCFD4 VA: 0x2C00FD4
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BFF8E8 Offset: 0x2BFB8E8 VA: 0x2BFF8E8
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BFFA98 Offset: 0x2BFBA98 VA: 0x2BFFA98
	|-NativeArray.ReadOnly<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BFFC80 Offset: 0x2BFBC80 VA: 0x2BFFC80
	|-NativeArray.ReadOnly<ContactPairHeader>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BFFE94 Offset: 0x2BFBE94 VA: 0x2BFFE94
	|-NativeArray.ReadOnly<CullingSplit>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2C00044 Offset: 0x2BFC044 VA: 0x2C00044
	|-NativeArray.ReadOnly<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2C00258 Offset: 0x2BFC258 VA: 0x2C00258
	|-NativeArray.ReadOnly<LightDataGI>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2C00450 Offset: 0x2BFC450 VA: 0x2C00450
	|-NativeArray.ReadOnly<Matrix4x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2C00670 Offset: 0x2BFC670 VA: 0x2C00670
	|-NativeArray.ReadOnly<ModifiableContactPair>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2C0082C Offset: 0x2BFC82C VA: 0x2C0082C
	|-NativeArray.ReadOnly<Plane>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2C009F0 Offset: 0x2BFC9F0 VA: 0x2C009F0
	|-NativeArray.ReadOnly<Quaternion>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2C00BA8 Offset: 0x2BFCBA8 VA: 0x2C00BA8
	|-NativeArray.ReadOnly<sbyte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2C00D58 Offset: 0x2BFCD58 VA: 0x2C00D58
	|-NativeArray.ReadOnly<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2C010FC Offset: 0x2BFD0FC VA: 0x2C010FC
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BFF968 Offset: 0x2BFB968 VA: 0x2BFF968
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BFFB18 Offset: 0x2BFBB18 VA: 0x2BFFB18
	|-NativeArray.ReadOnly<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BFFD00 Offset: 0x2BFBD00 VA: 0x2BFFD00
	|-NativeArray.ReadOnly<ContactPairHeader>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BFFF14 Offset: 0x2BFBF14 VA: 0x2BFFF14
	|-NativeArray.ReadOnly<CullingSplit>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C000C4 Offset: 0x2BFC0C4 VA: 0x2C000C4
	|-NativeArray.ReadOnly<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C002D8 Offset: 0x2BFC2D8 VA: 0x2C002D8
	|-NativeArray.ReadOnly<LightDataGI>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C004D0 Offset: 0x2BFC4D0 VA: 0x2C004D0
	|-NativeArray.ReadOnly<Matrix4x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C006F0 Offset: 0x2BFC6F0 VA: 0x2C006F0
	|-NativeArray.ReadOnly<ModifiableContactPair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C008B0 Offset: 0x2BFC8B0 VA: 0x2C008B0
	|-NativeArray.ReadOnly<Plane>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C00A74 Offset: 0x2BFCA74 VA: 0x2C00A74
	|-NativeArray.ReadOnly<Quaternion>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C00C28 Offset: 0x2BFCC28 VA: 0x2C00C28
	|-NativeArray.ReadOnly<sbyte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C00DD0 Offset: 0x2BFCDD0 VA: 0x2C00DD0
	|-NativeArray.ReadOnly<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C01220 Offset: 0x2BFD220 VA: 0x2C01220
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
