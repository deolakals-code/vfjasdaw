// Assembly: UnityEngine.CoreModule.dll
// Namespace: 
[ExcludeFromDocs]
public struct NativeArray.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 16160
{
	// Fields
	private NativeArray<T> m_Array; // 0x0
	private int m_Index; // 0x0
	private T value; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ref NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296E654 Offset: 0x296A654 VA: 0x296E654
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>..ctor
	|
	|-RVA: 0x296F174 Offset: 0x296B174 VA: 0x296F174
	|-NativeArray.Enumerator<byte>..ctor
	|
	|-RVA: 0x296FB14 Offset: 0x296BB14 VA: 0x296FB14
	|-NativeArray.Enumerator<ContactPairHeader>..ctor
	|
	|-RVA: 0x296FDC4 Offset: 0x296BDC4 VA: 0x296FDC4
	|-NativeArray.Enumerator<CullingSplit>..ctor
	|
	|-RVA: 0x2971744 Offset: 0x296D744 VA: 0x2971744
	|-NativeArray.Enumerator<int>..ctor
	|
	|-RVA: 0x29723E0 Offset: 0x296E3E0 VA: 0x29723E0
	|-NativeArray.Enumerator<LightDataGI>..ctor
	|
	|-RVA: 0x29728C0 Offset: 0x296E8C0 VA: 0x29728C0
	|-NativeArray.Enumerator<Matrix4x4>..ctor
	|
	|-RVA: 0x2972FE8 Offset: 0x296EFE8 VA: 0x2972FE8
	|-NativeArray.Enumerator<ModifiableContactPair>..ctor
	|
	|-RVA: 0x29742F0 Offset: 0x29702F0 VA: 0x29742F0
	|-NativeArray.Enumerator<Plane>..ctor
	|
	|-RVA: 0x2974980 Offset: 0x2970980 VA: 0x2974980
	|-NativeArray.Enumerator<Quaternion>..ctor
	|
	|-RVA: 0x29751A4 Offset: 0x29711A4 VA: 0x29751A4
	|-NativeArray.Enumerator<sbyte>..ctor
	|
	|-RVA: 0x2976300 Offset: 0x2972300 VA: 0x2976300
	|-NativeArray.Enumerator<Vector3>..ctor
	|
	|-RVA: 0x2976754 Offset: 0x2972754 VA: 0x2976754
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296E67C Offset: 0x296A67C VA: 0x296E67C
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>.Dispose
	|
	|-RVA: 0x296F18C Offset: 0x296B18C VA: 0x296F18C
	|-NativeArray.Enumerator<byte>.Dispose
	|
	|-RVA: 0x296FB38 Offset: 0x296BB38 VA: 0x296FB38
	|-NativeArray.Enumerator<ContactPairHeader>.Dispose
	|
	|-RVA: 0x296FDF4 Offset: 0x296BDF4 VA: 0x296FDF4
	|-NativeArray.Enumerator<CullingSplit>.Dispose
	|
	|-RVA: 0x2971758 Offset: 0x296D758 VA: 0x2971758
	|-NativeArray.Enumerator<int>.Dispose
	|
	|-RVA: 0x2972410 Offset: 0x296E410 VA: 0x2972410
	|-NativeArray.Enumerator<LightDataGI>.Dispose
	|
	|-RVA: 0x29728E8 Offset: 0x296E8E8 VA: 0x29728E8
	|-NativeArray.Enumerator<Matrix4x4>.Dispose
	|
	|-RVA: 0x297301C Offset: 0x296F01C VA: 0x297301C
	|-NativeArray.Enumerator<ModifiableContactPair>.Dispose
	|
	|-RVA: 0x297430C Offset: 0x297030C VA: 0x297430C
	|-NativeArray.Enumerator<Plane>.Dispose
	|
	|-RVA: 0x297499C Offset: 0x297099C VA: 0x297499C
	|-NativeArray.Enumerator<Quaternion>.Dispose
	|
	|-RVA: 0x29751BC Offset: 0x29711BC VA: 0x29751BC
	|-NativeArray.Enumerator<sbyte>.Dispose
	|
	|-RVA: 0x297631C Offset: 0x297231C VA: 0x297631C
	|-NativeArray.Enumerator<Vector3>.Dispose
	|
	|-RVA: 0x2976840 Offset: 0x2972840 VA: 0x2976840
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296E680 Offset: 0x296A680 VA: 0x296E680
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>.MoveNext
	|
	|-RVA: 0x296F190 Offset: 0x296B190 VA: 0x296F190
	|-NativeArray.Enumerator<byte>.MoveNext
	|
	|-RVA: 0x296FB3C Offset: 0x296BB3C VA: 0x296FB3C
	|-NativeArray.Enumerator<ContactPairHeader>.MoveNext
	|
	|-RVA: 0x296FDF8 Offset: 0x296BDF8 VA: 0x296FDF8
	|-NativeArray.Enumerator<CullingSplit>.MoveNext
	|
	|-RVA: 0x297175C Offset: 0x296D75C VA: 0x297175C
	|-NativeArray.Enumerator<int>.MoveNext
	|
	|-RVA: 0x2972414 Offset: 0x296E414 VA: 0x2972414
	|-NativeArray.Enumerator<LightDataGI>.MoveNext
	|
	|-RVA: 0x29728EC Offset: 0x296E8EC VA: 0x29728EC
	|-NativeArray.Enumerator<Matrix4x4>.MoveNext
	|
	|-RVA: 0x2973020 Offset: 0x296F020 VA: 0x2973020
	|-NativeArray.Enumerator<ModifiableContactPair>.MoveNext
	|
	|-RVA: 0x2974310 Offset: 0x2970310 VA: 0x2974310
	|-NativeArray.Enumerator<Plane>.MoveNext
	|
	|-RVA: 0x29749A0 Offset: 0x29709A0 VA: 0x29749A0
	|-NativeArray.Enumerator<Quaternion>.MoveNext
	|
	|-RVA: 0x29751C0 Offset: 0x29711C0 VA: 0x29751C0
	|-NativeArray.Enumerator<sbyte>.MoveNext
	|
	|-RVA: 0x2976320 Offset: 0x2972320 VA: 0x2976320
	|-NativeArray.Enumerator<Vector3>.MoveNext
	|
	|-RVA: 0x2976844 Offset: 0x2972844 VA: 0x2976844
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296E724 Offset: 0x296A724 VA: 0x296E724
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>.Reset
	|
	|-RVA: 0x296F1F4 Offset: 0x296B1F4 VA: 0x296F1F4
	|-NativeArray.Enumerator<byte>.Reset
	|
	|-RVA: 0x296FBCC Offset: 0x296BBCC VA: 0x296FBCC
	|-NativeArray.Enumerator<ContactPairHeader>.Reset
	|
	|-RVA: 0x296FE98 Offset: 0x296BE98 VA: 0x296FE98
	|-NativeArray.Enumerator<CullingSplit>.Reset
	|
	|-RVA: 0x29717C0 Offset: 0x296D7C0 VA: 0x29717C0
	|-NativeArray.Enumerator<int>.Reset
	|
	|-RVA: 0x29724B4 Offset: 0x296E4B4 VA: 0x29724B4
	|-NativeArray.Enumerator<LightDataGI>.Reset
	|
	|-RVA: 0x2972988 Offset: 0x296E988 VA: 0x2972988
	|-NativeArray.Enumerator<Matrix4x4>.Reset
	|
	|-RVA: 0x29730C4 Offset: 0x296F0C4 VA: 0x29730C4
	|-NativeArray.Enumerator<ModifiableContactPair>.Reset
	|
	|-RVA: 0x2974378 Offset: 0x2970378 VA: 0x2974378
	|-NativeArray.Enumerator<Plane>.Reset
	|
	|-RVA: 0x2974A08 Offset: 0x2970A08 VA: 0x2974A08
	|-NativeArray.Enumerator<Quaternion>.Reset
	|
	|-RVA: 0x2975224 Offset: 0x2971224 VA: 0x2975224
	|-NativeArray.Enumerator<sbyte>.Reset
	|
	|-RVA: 0x2976398 Offset: 0x2972398 VA: 0x2976398
	|-NativeArray.Enumerator<Vector3>.Reset
	|
	|-RVA: 0x2976ADC Offset: 0x2972ADC VA: 0x2976ADC
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296E730 Offset: 0x296A730 VA: 0x296E730
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>.get_Current
	|
	|-RVA: 0x296F200 Offset: 0x296B200 VA: 0x296F200
	|-NativeArray.Enumerator<byte>.get_Current
	|
	|-RVA: 0x296FBD8 Offset: 0x296BBD8 VA: 0x296FBD8
	|-NativeArray.Enumerator<ContactPairHeader>.get_Current
	|
	|-RVA: 0x296FEA4 Offset: 0x296BEA4 VA: 0x296FEA4
	|-NativeArray.Enumerator<CullingSplit>.get_Current
	|
	|-RVA: 0x29717CC Offset: 0x296D7CC VA: 0x29717CC
	|-NativeArray.Enumerator<int>.get_Current
	|
	|-RVA: 0x29724C0 Offset: 0x296E4C0 VA: 0x29724C0
	|-NativeArray.Enumerator<LightDataGI>.get_Current
	|
	|-RVA: 0x2972994 Offset: 0x296E994 VA: 0x2972994
	|-NativeArray.Enumerator<Matrix4x4>.get_Current
	|
	|-RVA: 0x29730D0 Offset: 0x296F0D0 VA: 0x29730D0
	|-NativeArray.Enumerator<ModifiableContactPair>.get_Current
	|
	|-RVA: 0x2974384 Offset: 0x2970384 VA: 0x2974384
	|-NativeArray.Enumerator<Plane>.get_Current
	|
	|-RVA: 0x2974A14 Offset: 0x2970A14 VA: 0x2974A14
	|-NativeArray.Enumerator<Quaternion>.get_Current
	|
	|-RVA: 0x2975230 Offset: 0x2971230 VA: 0x2975230
	|-NativeArray.Enumerator<sbyte>.get_Current
	|
	|-RVA: 0x29763A4 Offset: 0x29723A4 VA: 0x29763A4
	|-NativeArray.Enumerator<Vector3>.get_Current
	|
	|-RVA: 0x2976B1C Offset: 0x2972B1C VA: 0x2976B1C
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296E750 Offset: 0x296A750 VA: 0x296E750
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296F208 Offset: 0x296B208 VA: 0x296F208
	|-NativeArray.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296FBF0 Offset: 0x296BBF0 VA: 0x296FBF0
	|-NativeArray.Enumerator<ContactPairHeader>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296FEC0 Offset: 0x296BEC0 VA: 0x296FEC0
	|-NativeArray.Enumerator<CullingSplit>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29717D4 Offset: 0x296D7D4 VA: 0x29717D4
	|-NativeArray.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29724DC Offset: 0x296E4DC VA: 0x29724DC
	|-NativeArray.Enumerator<LightDataGI>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29729B0 Offset: 0x296E9B0 VA: 0x29729B0
	|-NativeArray.Enumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29730EC Offset: 0x296F0EC VA: 0x29730EC
	|-NativeArray.Enumerator<ModifiableContactPair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2974390 Offset: 0x2970390 VA: 0x2974390
	|-NativeArray.Enumerator<Plane>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2974A20 Offset: 0x2970A20 VA: 0x2974A20
	|-NativeArray.Enumerator<Quaternion>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2975238 Offset: 0x2971238 VA: 0x2975238
	|-NativeArray.Enumerator<sbyte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29763B0 Offset: 0x29723B0 VA: 0x29763B0
	|-NativeArray.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2976C50 Offset: 0x2972C50 VA: 0x2976C50
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.get_Current
	*/
}
