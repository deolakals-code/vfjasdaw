// Assembly: UnityEngine.CoreModule.dll
// Namespace: Unity.Collections
[NativeContainerSupportsDeferredConvertListToArray]
[NativeContainerSupportsMinMaxWriteRestriction]
[NativeContainerSupportsDeallocateOnJobCompletion]
[DebuggerDisplay("Length = {m_Length}")]
[DebuggerTypeProxy(typeof(NativeArrayDebugView<T>))]
[NativeContainer]
[DefaultMember("Item")]
public struct NativeArray<T> : IDisposable, IEnumerable<T>, IEnumerable, IEquatable<NativeArray<T>> // TypeDefIndex: 16163
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal void* m_Buffer; // 0x0
	internal int m_Length; // 0x0
	internal Allocator m_AllocatorLabel; // 0x0

	// Properties
	public int Length { get; }
	public int Item { set; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB0F4 Offset: 0x2BA70F4 VA: 0x2BAB0F4
	|-NativeArray<BatchCullingOutputDrawCommands>..ctor
	|
	|-RVA: 0x2BAB930 Offset: 0x2BA7930 VA: 0x2BAB930
	|-NativeArray<byte>..ctor
	|
	|-RVA: 0x2BAC0EC Offset: 0x2BA80EC VA: 0x2BAC0EC
	|-NativeArray<ContactPairHeader>..ctor
	|
	|-RVA: 0x2BAC914 Offset: 0x2BA8914 VA: 0x2BAC914
	|-NativeArray<CullingSplit>..ctor
	|
	|-RVA: 0x2BAD174 Offset: 0x2BA9174 VA: 0x2BAD174
	|-NativeArray<int>..ctor
	|
	|-RVA: 0x2BAD948 Offset: 0x2BA9948 VA: 0x2BAD948
	|-NativeArray<LightDataGI>..ctor
	|
	|-RVA: 0x2BAE1A8 Offset: 0x2BAA1A8 VA: 0x2BAE1A8
	|-NativeArray<Matrix4x4>..ctor
	|
	|-RVA: 0x2BAE9D0 Offset: 0x2BAA9D0 VA: 0x2BAE9D0
	|-NativeArray<ModifiableContactPair>..ctor
	|
	|-RVA: 0x2BAF214 Offset: 0x2BAB214 VA: 0x2BAF214
	|-NativeArray<Plane>..ctor
	|
	|-RVA: 0x2BAFA1C Offset: 0x2BABA1C VA: 0x2BAFA1C
	|-NativeArray<Quaternion>..ctor
	|
	|-RVA: 0x2BB0224 Offset: 0x2BAC224 VA: 0x2BB0224
	|-NativeArray<sbyte>..ctor
	|
	|-RVA: 0x2BB09E0 Offset: 0x2BAC9E0 VA: 0x2BB09E0
	|-NativeArray<Vector3>..ctor
	|
	|-RVA: 0x2BB11DC Offset: 0x2BAD1DC VA: 0x2BB11DC
	|-NativeArray<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void Allocate(int length, Allocator allocator, out NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB17C Offset: 0x2BA717C VA: 0x2BAB17C
	|-NativeArray<BatchCullingOutputDrawCommands>.Allocate
	|
	|-RVA: 0x2BAB9B8 Offset: 0x2BA79B8 VA: 0x2BAB9B8
	|-NativeArray<byte>.Allocate
	|
	|-RVA: 0x2BAC174 Offset: 0x2BA8174 VA: 0x2BAC174
	|-NativeArray<ContactPairHeader>.Allocate
	|
	|-RVA: 0x2BAC99C Offset: 0x2BA899C VA: 0x2BAC99C
	|-NativeArray<CullingSplit>.Allocate
	|
	|-RVA: 0x2BAD1FC Offset: 0x2BA91FC VA: 0x2BAD1FC
	|-NativeArray<int>.Allocate
	|
	|-RVA: 0x2BAD9D0 Offset: 0x2BA99D0 VA: 0x2BAD9D0
	|-NativeArray<LightDataGI>.Allocate
	|
	|-RVA: 0x2BAE230 Offset: 0x2BAA230 VA: 0x2BAE230
	|-NativeArray<Matrix4x4>.Allocate
	|
	|-RVA: 0x2BAEA58 Offset: 0x2BAAA58 VA: 0x2BAEA58
	|-NativeArray<ModifiableContactPair>.Allocate
	|
	|-RVA: 0x2BAF29C Offset: 0x2BAB29C VA: 0x2BAF29C
	|-NativeArray<Plane>.Allocate
	|
	|-RVA: 0x2BAFAA4 Offset: 0x2BABAA4 VA: 0x2BAFAA4
	|-NativeArray<Quaternion>.Allocate
	|
	|-RVA: 0x2BB02AC Offset: 0x2BAC2AC VA: 0x2BB02AC
	|-NativeArray<sbyte>.Allocate
	|
	|-RVA: 0x2BB0A68 Offset: 0x2BACA68 VA: 0x2BB0A68
	|-NativeArray<Vector3>.Allocate
	|
	|-RVA: 0x2BB12E4 Offset: 0x2BAD2E4 VA: 0x2BB12E4
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Allocate
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB204 Offset: 0x2BA7204 VA: 0x2BAB204
	|-NativeArray<BatchCullingOutputDrawCommands>.get_Length
	|
	|-RVA: 0x2BABA3C Offset: 0x2BA7A3C VA: 0x2BABA3C
	|-NativeArray<byte>.get_Length
	|
	|-RVA: 0x2BAC1FC Offset: 0x2BA81FC VA: 0x2BAC1FC
	|-NativeArray<ContactPairHeader>.get_Length
	|
	|-RVA: 0x2BACA24 Offset: 0x2BA8A24 VA: 0x2BACA24
	|-NativeArray<CullingSplit>.get_Length
	|
	|-RVA: 0x2BAD280 Offset: 0x2BA9280 VA: 0x2BAD280
	|-NativeArray<int>.get_Length
	|
	|-RVA: 0x2BADA58 Offset: 0x2BA9A58 VA: 0x2BADA58
	|-NativeArray<LightDataGI>.get_Length
	|
	|-RVA: 0x2BAE2B4 Offset: 0x2BAA2B4 VA: 0x2BAE2B4
	|-NativeArray<Matrix4x4>.get_Length
	|
	|-RVA: 0x2BAEAE0 Offset: 0x2BAAAE0 VA: 0x2BAEAE0
	|-NativeArray<ModifiableContactPair>.get_Length
	|
	|-RVA: 0x2BAF320 Offset: 0x2BAB320 VA: 0x2BAF320
	|-NativeArray<Plane>.get_Length
	|
	|-RVA: 0x2BAFB28 Offset: 0x2BABB28 VA: 0x2BAFB28
	|-NativeArray<Quaternion>.get_Length
	|
	|-RVA: 0x2BB0330 Offset: 0x2BAC330 VA: 0x2BB0330
	|-NativeArray<sbyte>.get_Length
	|
	|-RVA: 0x2BB0AF0 Offset: 0x2BACAF0 VA: 0x2BB0AF0
	|-NativeArray<Vector3>.get_Length
	|
	|-RVA: 0x2BB13EC Offset: 0x2BAD3EC VA: 0x2BB13EC
	|-NativeArray<__Il2CppFullySharedGenericStructType>.get_Length
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB20C Offset: 0x2BA720C VA: 0x2BAB20C
	|-NativeArray<BatchCullingOutputDrawCommands>.set_Item
	|
	|-RVA: 0x2BABA44 Offset: 0x2BA7A44 VA: 0x2BABA44
	|-NativeArray<byte>.set_Item
	|
	|-RVA: 0x2BAC204 Offset: 0x2BA8204 VA: 0x2BAC204
	|-NativeArray<ContactPairHeader>.set_Item
	|
	|-RVA: 0x2BACA2C Offset: 0x2BA8A2C VA: 0x2BACA2C
	|-NativeArray<CullingSplit>.set_Item
	|
	|-RVA: 0x2BAD288 Offset: 0x2BA9288 VA: 0x2BAD288
	|-NativeArray<int>.set_Item
	|
	|-RVA: 0x2BADA60 Offset: 0x2BA9A60 VA: 0x2BADA60
	|-NativeArray<LightDataGI>.set_Item
	|
	|-RVA: 0x2BAE2BC Offset: 0x2BAA2BC VA: 0x2BAE2BC
	|-NativeArray<Matrix4x4>.set_Item
	|
	|-RVA: 0x2BAEAE8 Offset: 0x2BAAAE8 VA: 0x2BAEAE8
	|-NativeArray<ModifiableContactPair>.set_Item
	|
	|-RVA: 0x2BAF328 Offset: 0x2BAB328 VA: 0x2BAF328
	|-NativeArray<Plane>.set_Item
	|
	|-RVA: 0x2BAFB30 Offset: 0x2BABB30 VA: 0x2BAFB30
	|-NativeArray<Quaternion>.set_Item
	|
	|-RVA: 0x2BB0338 Offset: 0x2BAC338 VA: 0x2BB0338
	|-NativeArray<sbyte>.set_Item
	|
	|-RVA: 0x2BB0AF8 Offset: 0x2BACAF8 VA: 0x2BB0AF8
	|-NativeArray<Vector3>.set_Item
	|
	|-RVA: 0x2BB13F4 Offset: 0x2BAD3F4 VA: 0x2BB13F4
	|-NativeArray<__Il2CppFullySharedGenericStructType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB284 Offset: 0x2BA7284 VA: 0x2BAB284
	|-NativeArray<BatchCullingOutputDrawCommands>.get_IsCreated
	|
	|-RVA: 0x2BABA7C Offset: 0x2BA7A7C VA: 0x2BABA7C
	|-NativeArray<byte>.get_IsCreated
	|
	|-RVA: 0x2BAC268 Offset: 0x2BA8268 VA: 0x2BAC268
	|-NativeArray<ContactPairHeader>.get_IsCreated
	|
	|-RVA: 0x2BACAA4 Offset: 0x2BA8AA4 VA: 0x2BACAA4
	|-NativeArray<CullingSplit>.get_IsCreated
	|
	|-RVA: 0x2BAD2C0 Offset: 0x2BA92C0 VA: 0x2BAD2C0
	|-NativeArray<int>.get_IsCreated
	|
	|-RVA: 0x2BADAD8 Offset: 0x2BA9AD8 VA: 0x2BADAD8
	|-NativeArray<LightDataGI>.get_IsCreated
	|
	|-RVA: 0x2BAE320 Offset: 0x2BAA320 VA: 0x2BAE320
	|-NativeArray<Matrix4x4>.get_IsCreated
	|
	|-RVA: 0x2BAEB60 Offset: 0x2BAAB60 VA: 0x2BAEB60
	|-NativeArray<ModifiableContactPair>.get_IsCreated
	|
	|-RVA: 0x2BAF384 Offset: 0x2BAB384 VA: 0x2BAF384
	|-NativeArray<Plane>.get_IsCreated
	|
	|-RVA: 0x2BAFB8C Offset: 0x2BABB8C VA: 0x2BAFB8C
	|-NativeArray<Quaternion>.get_IsCreated
	|
	|-RVA: 0x2BB0370 Offset: 0x2BAC370 VA: 0x2BB0370
	|-NativeArray<sbyte>.get_IsCreated
	|
	|-RVA: 0x2BB0B54 Offset: 0x2BACB54 VA: 0x2BB0B54
	|-NativeArray<Vector3>.get_IsCreated
	|
	|-RVA: 0x2BB1520 Offset: 0x2BAD520 VA: 0x2BB1520
	|-NativeArray<__Il2CppFullySharedGenericStructType>.get_IsCreated
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB294 Offset: 0x2BA7294 VA: 0x2BAB294
	|-NativeArray<BatchCullingOutputDrawCommands>.Dispose
	|
	|-RVA: 0x2BABA8C Offset: 0x2BA7A8C VA: 0x2BABA8C
	|-NativeArray<byte>.Dispose
	|
	|-RVA: 0x2BAC278 Offset: 0x2BA8278 VA: 0x2BAC278
	|-NativeArray<ContactPairHeader>.Dispose
	|
	|-RVA: 0x2BACAB4 Offset: 0x2BA8AB4 VA: 0x2BACAB4
	|-NativeArray<CullingSplit>.Dispose
	|
	|-RVA: 0x2BAD2D0 Offset: 0x2BA92D0 VA: 0x2BAD2D0
	|-NativeArray<int>.Dispose
	|
	|-RVA: 0x2BADAE8 Offset: 0x2BA9AE8 VA: 0x2BADAE8
	|-NativeArray<LightDataGI>.Dispose
	|
	|-RVA: 0x2BAE330 Offset: 0x2BAA330 VA: 0x2BAE330
	|-NativeArray<Matrix4x4>.Dispose
	|
	|-RVA: 0x2BAEB70 Offset: 0x2BAAB70 VA: 0x2BAEB70
	|-NativeArray<ModifiableContactPair>.Dispose
	|
	|-RVA: 0x2BAF394 Offset: 0x2BAB394 VA: 0x2BAF394
	|-NativeArray<Plane>.Dispose
	|
	|-RVA: 0x2BAFB9C Offset: 0x2BABB9C VA: 0x2BAFB9C
	|-NativeArray<Quaternion>.Dispose
	|
	|-RVA: 0x2BB0380 Offset: 0x2BAC380 VA: 0x2BB0380
	|-NativeArray<sbyte>.Dispose
	|
	|-RVA: 0x2BB0B64 Offset: 0x2BACB64 VA: 0x2BB0B64
	|-NativeArray<Vector3>.Dispose
	|
	|-RVA: 0x2BB1530 Offset: 0x2BAD530 VA: 0x2BB1530
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB328 Offset: 0x2BA7328 VA: 0x2BAB328
	|-NativeArray<BatchCullingOutputDrawCommands>.ToArray
	|
	|-RVA: 0x2BABB20 Offset: 0x2BA7B20 VA: 0x2BABB20
	|-NativeArray<byte>.ToArray
	|
	|-RVA: 0x2BAC30C Offset: 0x2BA830C VA: 0x2BAC30C
	|-NativeArray<ContactPairHeader>.ToArray
	|
	|-RVA: 0x2BACB48 Offset: 0x2BA8B48 VA: 0x2BACB48
	|-NativeArray<CullingSplit>.ToArray
	|
	|-RVA: 0x2BAD364 Offset: 0x2BA9364 VA: 0x2BAD364
	|-NativeArray<int>.ToArray
	|
	|-RVA: 0x2BADB7C Offset: 0x2BA9B7C VA: 0x2BADB7C
	|-NativeArray<LightDataGI>.ToArray
	|
	|-RVA: 0x2BAE3C4 Offset: 0x2BAA3C4 VA: 0x2BAE3C4
	|-NativeArray<Matrix4x4>.ToArray
	|
	|-RVA: 0x2BAEC04 Offset: 0x2BAAC04 VA: 0x2BAEC04
	|-NativeArray<ModifiableContactPair>.ToArray
	|
	|-RVA: 0x2BAF428 Offset: 0x2BAB428 VA: 0x2BAF428
	|-NativeArray<Plane>.ToArray
	|
	|-RVA: 0x2BAFC30 Offset: 0x2BABC30 VA: 0x2BAFC30
	|-NativeArray<Quaternion>.ToArray
	|
	|-RVA: 0x2BB0414 Offset: 0x2BAC414 VA: 0x2BB0414
	|-NativeArray<sbyte>.ToArray
	|
	|-RVA: 0x2BB0BF8 Offset: 0x2BACBF8 VA: 0x2BB0BF8
	|-NativeArray<Vector3>.ToArray
	|
	|-RVA: 0x2BB1608 Offset: 0x2BAD608 VA: 0x2BB1608
	|-NativeArray<__Il2CppFullySharedGenericStructType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB3B4 Offset: 0x2BA73B4 VA: 0x2BAB3B4
	|-NativeArray<BatchCullingOutputDrawCommands>.GetEnumerator
	|
	|-RVA: 0x2BABBAC Offset: 0x2BA7BAC VA: 0x2BABBAC
	|-NativeArray<byte>.GetEnumerator
	|
	|-RVA: 0x2BAC398 Offset: 0x2BA8398 VA: 0x2BAC398
	|-NativeArray<ContactPairHeader>.GetEnumerator
	|
	|-RVA: 0x2BACBD4 Offset: 0x2BA8BD4 VA: 0x2BACBD4
	|-NativeArray<CullingSplit>.GetEnumerator
	|
	|-RVA: 0x2BAD3F0 Offset: 0x2BA93F0 VA: 0x2BAD3F0
	|-NativeArray<int>.GetEnumerator
	|
	|-RVA: 0x2BADC08 Offset: 0x2BA9C08 VA: 0x2BADC08
	|-NativeArray<LightDataGI>.GetEnumerator
	|
	|-RVA: 0x2BAE450 Offset: 0x2BAA450 VA: 0x2BAE450
	|-NativeArray<Matrix4x4>.GetEnumerator
	|
	|-RVA: 0x2BAEC90 Offset: 0x2BAAC90 VA: 0x2BAEC90
	|-NativeArray<ModifiableContactPair>.GetEnumerator
	|
	|-RVA: 0x2BAF4B4 Offset: 0x2BAB4B4 VA: 0x2BAF4B4
	|-NativeArray<Plane>.GetEnumerator
	|
	|-RVA: 0x2BAFCBC Offset: 0x2BABCBC VA: 0x2BAFCBC
	|-NativeArray<Quaternion>.GetEnumerator
	|
	|-RVA: 0x2BB04A0 Offset: 0x2BAC4A0 VA: 0x2BB04A0
	|-NativeArray<sbyte>.GetEnumerator
	|
	|-RVA: 0x2BB0C84 Offset: 0x2BACC84 VA: 0x2BB0C84
	|-NativeArray<Vector3>.GetEnumerator
	|
	|-RVA: 0x2BB1790 Offset: 0x2BAD790 VA: 0x2BB1790
	|-NativeArray<__Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB42C Offset: 0x2BA742C VA: 0x2BAB42C
	|-NativeArray<BatchCullingOutputDrawCommands>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BABC14 Offset: 0x2BA7C14 VA: 0x2BABC14
	|-NativeArray<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BAC404 Offset: 0x2BA8404 VA: 0x2BAC404
	|-NativeArray<ContactPairHeader>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BACC54 Offset: 0x2BA8C54 VA: 0x2BACC54
	|-NativeArray<CullingSplit>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BAD458 Offset: 0x2BA9458 VA: 0x2BAD458
	|-NativeArray<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BADC88 Offset: 0x2BA9C88 VA: 0x2BADC88
	|-NativeArray<LightDataGI>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BAE4CC Offset: 0x2BAA4CC VA: 0x2BAE4CC
	|-NativeArray<Matrix4x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BAED0C Offset: 0x2BAAD0C VA: 0x2BAED0C
	|-NativeArray<ModifiableContactPair>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BAF520 Offset: 0x2BAB520 VA: 0x2BAF520
	|-NativeArray<Plane>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BAFD28 Offset: 0x2BABD28 VA: 0x2BAFD28
	|-NativeArray<Quaternion>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BB0508 Offset: 0x2BAC508 VA: 0x2BB0508
	|-NativeArray<sbyte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BB0CE0 Offset: 0x2BACCE0 VA: 0x2BB0CE0
	|-NativeArray<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BB18B8 Offset: 0x2BAD8B8 VA: 0x2BB18B8
	|-NativeArray<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB4BC Offset: 0x2BA74BC VA: 0x2BAB4BC
	|-NativeArray<BatchCullingOutputDrawCommands>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BABC98 Offset: 0x2BA7C98 VA: 0x2BABC98
	|-NativeArray<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BAC490 Offset: 0x2BA8490 VA: 0x2BAC490
	|-NativeArray<ContactPairHeader>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BACCF0 Offset: 0x2BA8CF0 VA: 0x2BACCF0
	|-NativeArray<CullingSplit>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BAD4DC Offset: 0x2BA94DC VA: 0x2BAD4DC
	|-NativeArray<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BADD24 Offset: 0x2BA9D24 VA: 0x2BADD24
	|-NativeArray<LightDataGI>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BAE564 Offset: 0x2BAA564 VA: 0x2BAE564
	|-NativeArray<Matrix4x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BAEDA0 Offset: 0x2BAADA0 VA: 0x2BAEDA0
	|-NativeArray<ModifiableContactPair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BAF5AC Offset: 0x2BAB5AC VA: 0x2BAF5AC
	|-NativeArray<Plane>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BAFDB4 Offset: 0x2BABDB4 VA: 0x2BAFDB4
	|-NativeArray<Quaternion>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BB058C Offset: 0x2BAC58C VA: 0x2BB058C
	|-NativeArray<sbyte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BB0D60 Offset: 0x2BACD60 VA: 0x2BB0D60
	|-NativeArray<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BB19A4 Offset: 0x2BAD9A4 VA: 0x2BB19A4
	|-NativeArray<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool Equals(NativeArray<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB53C Offset: 0x2BA753C VA: 0x2BAB53C
	|-NativeArray<BatchCullingOutputDrawCommands>.Equals
	|
	|-RVA: 0x2BABD18 Offset: 0x2BA7D18 VA: 0x2BABD18
	|-NativeArray<byte>.Equals
	|
	|-RVA: 0x2BAC510 Offset: 0x2BA8510 VA: 0x2BAC510
	|-NativeArray<ContactPairHeader>.Equals
	|
	|-RVA: 0x2BACD70 Offset: 0x2BA8D70 VA: 0x2BACD70
	|-NativeArray<CullingSplit>.Equals
	|
	|-RVA: 0x2BAD55C Offset: 0x2BA955C VA: 0x2BAD55C
	|-NativeArray<int>.Equals
	|
	|-RVA: 0x2BADDA4 Offset: 0x2BA9DA4 VA: 0x2BADDA4
	|-NativeArray<LightDataGI>.Equals
	|
	|-RVA: 0x2BAE5E4 Offset: 0x2BAA5E4 VA: 0x2BAE5E4
	|-NativeArray<Matrix4x4>.Equals
	|
	|-RVA: 0x2BAEE20 Offset: 0x2BAAE20 VA: 0x2BAEE20
	|-NativeArray<ModifiableContactPair>.Equals
	|
	|-RVA: 0x2BAF630 Offset: 0x2BAB630 VA: 0x2BAF630
	|-NativeArray<Plane>.Equals
	|
	|-RVA: 0x2BAFE38 Offset: 0x2BABE38 VA: 0x2BAFE38
	|-NativeArray<Quaternion>.Equals
	|
	|-RVA: 0x2BB060C Offset: 0x2BAC60C VA: 0x2BB060C
	|-NativeArray<sbyte>.Equals
	|
	|-RVA: 0x2BB0DD8 Offset: 0x2BACDD8 VA: 0x2BB0DD8
	|-NativeArray<Vector3>.Equals
	|
	|-RVA: 0x2BB1AC8 Offset: 0x2BADAC8 VA: 0x2BB1AC8
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB560 Offset: 0x2BA7560 VA: 0x2BAB560
	|-NativeArray<BatchCullingOutputDrawCommands>.Equals
	|
	|-RVA: 0x2BABD3C Offset: 0x2BA7D3C VA: 0x2BABD3C
	|-NativeArray<byte>.Equals
	|
	|-RVA: 0x2BAC534 Offset: 0x2BA8534 VA: 0x2BAC534
	|-NativeArray<ContactPairHeader>.Equals
	|
	|-RVA: 0x2BACD94 Offset: 0x2BA8D94 VA: 0x2BACD94
	|-NativeArray<CullingSplit>.Equals
	|
	|-RVA: 0x2BAD580 Offset: 0x2BA9580 VA: 0x2BAD580
	|-NativeArray<int>.Equals
	|
	|-RVA: 0x2BADDC8 Offset: 0x2BA9DC8 VA: 0x2BADDC8
	|-NativeArray<LightDataGI>.Equals
	|
	|-RVA: 0x2BAE608 Offset: 0x2BAA608 VA: 0x2BAE608
	|-NativeArray<Matrix4x4>.Equals
	|
	|-RVA: 0x2BAEE44 Offset: 0x2BAAE44 VA: 0x2BAEE44
	|-NativeArray<ModifiableContactPair>.Equals
	|
	|-RVA: 0x2BAF654 Offset: 0x2BAB654 VA: 0x2BAF654
	|-NativeArray<Plane>.Equals
	|
	|-RVA: 0x2BAFE5C Offset: 0x2BABE5C VA: 0x2BAFE5C
	|-NativeArray<Quaternion>.Equals
	|
	|-RVA: 0x2BB0630 Offset: 0x2BAC630 VA: 0x2BB0630
	|-NativeArray<sbyte>.Equals
	|
	|-RVA: 0x2BB0DFC Offset: 0x2BACDFC VA: 0x2BB0DFC
	|-NativeArray<Vector3>.Equals
	|
	|-RVA: 0x2BB1AEC Offset: 0x2BADAEC VA: 0x2BB1AEC
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB638 Offset: 0x2BA7638 VA: 0x2BAB638
	|-NativeArray<BatchCullingOutputDrawCommands>.GetHashCode
	|
	|-RVA: 0x2BABE14 Offset: 0x2BA7E14 VA: 0x2BABE14
	|-NativeArray<byte>.GetHashCode
	|
	|-RVA: 0x2BAC60C Offset: 0x2BA860C VA: 0x2BAC60C
	|-NativeArray<ContactPairHeader>.GetHashCode
	|
	|-RVA: 0x2BACE6C Offset: 0x2BA8E6C VA: 0x2BACE6C
	|-NativeArray<CullingSplit>.GetHashCode
	|
	|-RVA: 0x2BAD658 Offset: 0x2BA9658 VA: 0x2BAD658
	|-NativeArray<int>.GetHashCode
	|
	|-RVA: 0x2BADEA0 Offset: 0x2BA9EA0 VA: 0x2BADEA0
	|-NativeArray<LightDataGI>.GetHashCode
	|
	|-RVA: 0x2BAE6E0 Offset: 0x2BAA6E0 VA: 0x2BAE6E0
	|-NativeArray<Matrix4x4>.GetHashCode
	|
	|-RVA: 0x2BAEF1C Offset: 0x2BAAF1C VA: 0x2BAEF1C
	|-NativeArray<ModifiableContactPair>.GetHashCode
	|
	|-RVA: 0x2BAF72C Offset: 0x2BAB72C VA: 0x2BAF72C
	|-NativeArray<Plane>.GetHashCode
	|
	|-RVA: 0x2BAFF34 Offset: 0x2BABF34 VA: 0x2BAFF34
	|-NativeArray<Quaternion>.GetHashCode
	|
	|-RVA: 0x2BB0708 Offset: 0x2BAC708 VA: 0x2BB0708
	|-NativeArray<sbyte>.GetHashCode
	|
	|-RVA: 0x2BB0ED4 Offset: 0x2BACED4 VA: 0x2BB0ED4
	|-NativeArray<Vector3>.GetHashCode
	|
	|-RVA: 0x2BB1C14 Offset: 0x2BADC14 VA: 0x2BB1C14
	|-NativeArray<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static void Copy(T[] src, NativeArray<T> dst) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB650 Offset: 0x2BA7650 VA: 0x2BAB650
	|-NativeArray<BatchCullingOutputDrawCommands>.Copy
	|
	|-RVA: 0x2BABE2C Offset: 0x2BA7E2C VA: 0x2BABE2C
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x2BAC624 Offset: 0x2BA8624 VA: 0x2BAC624
	|-NativeArray<ContactPairHeader>.Copy
	|
	|-RVA: 0x2BACE84 Offset: 0x2BA8E84 VA: 0x2BACE84
	|-NativeArray<CullingSplit>.Copy
	|
	|-RVA: 0x2BAD670 Offset: 0x2BA9670 VA: 0x2BAD670
	|-NativeArray<int>.Copy
	|
	|-RVA: 0x2BADEB8 Offset: 0x2BA9EB8 VA: 0x2BADEB8
	|-NativeArray<LightDataGI>.Copy
	|
	|-RVA: 0x2BAE6F8 Offset: 0x2BAA6F8 VA: 0x2BAE6F8
	|-NativeArray<Matrix4x4>.Copy
	|
	|-RVA: 0x2BAEF34 Offset: 0x2BAAF34 VA: 0x2BAEF34
	|-NativeArray<ModifiableContactPair>.Copy
	|
	|-RVA: 0x2BAF744 Offset: 0x2BAB744 VA: 0x2BAF744
	|-NativeArray<Plane>.Copy
	|
	|-RVA: 0x2BAFF4C Offset: 0x2BABF4C VA: 0x2BAFF4C
	|-NativeArray<Quaternion>.Copy
	|
	|-RVA: 0x2BB0720 Offset: 0x2BAC720 VA: 0x2BB0720
	|-NativeArray<sbyte>.Copy
	|
	|-RVA: 0x2BB0EEC Offset: 0x2BACEEC VA: 0x2BB0EEC
	|-NativeArray<Vector3>.Copy
	|
	|-RVA: 0x2BB1C2C Offset: 0x2BADC2C VA: 0x2BB1C2C
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Copy
	*/

	// RVA: -1 Offset: -1
	public static void Copy(NativeArray<T> src, T[] dst, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB6B4 Offset: 0x2BA76B4 VA: 0x2BAB6B4
	|-NativeArray<BatchCullingOutputDrawCommands>.Copy
	|
	|-RVA: 0x2BABE90 Offset: 0x2BA7E90 VA: 0x2BABE90
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x2BAC688 Offset: 0x2BA8688 VA: 0x2BAC688
	|-NativeArray<ContactPairHeader>.Copy
	|
	|-RVA: 0x2BACEE8 Offset: 0x2BA8EE8 VA: 0x2BACEE8
	|-NativeArray<CullingSplit>.Copy
	|
	|-RVA: 0x2BAD6D4 Offset: 0x2BA96D4 VA: 0x2BAD6D4
	|-NativeArray<int>.Copy
	|
	|-RVA: 0x2BADF1C Offset: 0x2BA9F1C VA: 0x2BADF1C
	|-NativeArray<LightDataGI>.Copy
	|
	|-RVA: 0x2BAE75C Offset: 0x2BAA75C VA: 0x2BAE75C
	|-NativeArray<Matrix4x4>.Copy
	|
	|-RVA: 0x2BAEF98 Offset: 0x2BAAF98 VA: 0x2BAEF98
	|-NativeArray<ModifiableContactPair>.Copy
	|
	|-RVA: 0x2BAF7A8 Offset: 0x2BAB7A8 VA: 0x2BAF7A8
	|-NativeArray<Plane>.Copy
	|
	|-RVA: 0x2BAFFB0 Offset: 0x2BABFB0 VA: 0x2BAFFB0
	|-NativeArray<Quaternion>.Copy
	|
	|-RVA: 0x2BB0784 Offset: 0x2BAC784 VA: 0x2BB0784
	|-NativeArray<sbyte>.Copy
	|
	|-RVA: 0x2BB0F50 Offset: 0x2BACF50 VA: 0x2BB0F50
	|-NativeArray<Vector3>.Copy
	|
	|-RVA: 0x2BB1CD4 Offset: 0x2BADCD4 VA: 0x2BB1CD4
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Copy
	*/

	// RVA: -1 Offset: -1
	private static void CopySafe(T[] src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB718 Offset: 0x2BA7718 VA: 0x2BAB718
	|-NativeArray<BatchCullingOutputDrawCommands>.CopySafe
	|
	|-RVA: 0x2BABEF4 Offset: 0x2BA7EF4 VA: 0x2BABEF4
	|-NativeArray<byte>.CopySafe
	|
	|-RVA: 0x2BAC6EC Offset: 0x2BA86EC VA: 0x2BAC6EC
	|-NativeArray<ContactPairHeader>.CopySafe
	|
	|-RVA: 0x2BACF4C Offset: 0x2BA8F4C VA: 0x2BACF4C
	|-NativeArray<CullingSplit>.CopySafe
	|
	|-RVA: 0x2BAD738 Offset: 0x2BA9738 VA: 0x2BAD738
	|-NativeArray<int>.CopySafe
	|
	|-RVA: 0x2BADF80 Offset: 0x2BA9F80 VA: 0x2BADF80
	|-NativeArray<LightDataGI>.CopySafe
	|
	|-RVA: 0x2BAE7C0 Offset: 0x2BAA7C0 VA: 0x2BAE7C0
	|-NativeArray<Matrix4x4>.CopySafe
	|
	|-RVA: 0x2BAEFFC Offset: 0x2BAAFFC VA: 0x2BAEFFC
	|-NativeArray<ModifiableContactPair>.CopySafe
	|
	|-RVA: 0x2BAF80C Offset: 0x2BAB80C VA: 0x2BAF80C
	|-NativeArray<Plane>.CopySafe
	|
	|-RVA: 0x2BB0014 Offset: 0x2BAC014 VA: 0x2BB0014
	|-NativeArray<Quaternion>.CopySafe
	|
	|-RVA: 0x2BB07E8 Offset: 0x2BAC7E8 VA: 0x2BB07E8
	|-NativeArray<sbyte>.CopySafe
	|
	|-RVA: 0x2BB0FB4 Offset: 0x2BACFB4 VA: 0x2BB0FB4
	|-NativeArray<Vector3>.CopySafe
	|
	|-RVA: 0x2BB1D7C Offset: 0x2BADD7C VA: 0x2BB1D7C
	|-NativeArray<__Il2CppFullySharedGenericStructType>.CopySafe
	*/

	// RVA: -1 Offset: -1
	private static void CopySafe(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB7F4 Offset: 0x2BA77F4 VA: 0x2BAB7F4
	|-NativeArray<BatchCullingOutputDrawCommands>.CopySafe
	|
	|-RVA: 0x2BABFC0 Offset: 0x2BA7FC0 VA: 0x2BABFC0
	|-NativeArray<byte>.CopySafe
	|
	|-RVA: 0x2BAC7D0 Offset: 0x2BA87D0 VA: 0x2BAC7D0
	|-NativeArray<ContactPairHeader>.CopySafe
	|
	|-RVA: 0x2BAD030 Offset: 0x2BA9030 VA: 0x2BAD030
	|-NativeArray<CullingSplit>.CopySafe
	|
	|-RVA: 0x2BAD810 Offset: 0x2BA9810 VA: 0x2BAD810
	|-NativeArray<int>.CopySafe
	|
	|-RVA: 0x2BAE064 Offset: 0x2BAA064 VA: 0x2BAE064
	|-NativeArray<LightDataGI>.CopySafe
	|
	|-RVA: 0x2BAE898 Offset: 0x2BAA898 VA: 0x2BAE898
	|-NativeArray<Matrix4x4>.CopySafe
	|
	|-RVA: 0x2BAF0D8 Offset: 0x2BAB0D8 VA: 0x2BAF0D8
	|-NativeArray<ModifiableContactPair>.CopySafe
	|
	|-RVA: 0x2BAF8E4 Offset: 0x2BAB8E4 VA: 0x2BAF8E4
	|-NativeArray<Plane>.CopySafe
	|
	|-RVA: 0x2BB00EC Offset: 0x2BAC0EC VA: 0x2BB00EC
	|-NativeArray<Quaternion>.CopySafe
	|
	|-RVA: 0x2BB08B4 Offset: 0x2BAC8B4 VA: 0x2BB08B4
	|-NativeArray<sbyte>.CopySafe
	|
	|-RVA: 0x2BB1098 Offset: 0x2BAD098 VA: 0x2BB1098
	|-NativeArray<Vector3>.CopySafe
	|
	|-RVA: 0x2BB1F1C Offset: 0x2BADF1C VA: 0x2BB1F1C
	|-NativeArray<__Il2CppFullySharedGenericStructType>.CopySafe
	*/

	// RVA: -1 Offset: -1
	public NativeArray.ReadOnly<T> AsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB8DC Offset: 0x2BA78DC VA: 0x2BAB8DC
	|-NativeArray<BatchCullingOutputDrawCommands>.AsReadOnly
	|
	|-RVA: 0x2BAC098 Offset: 0x2BA8098 VA: 0x2BAC098
	|-NativeArray<byte>.AsReadOnly
	|
	|-RVA: 0x2BAC8C0 Offset: 0x2BA88C0 VA: 0x2BAC8C0
	|-NativeArray<ContactPairHeader>.AsReadOnly
	|
	|-RVA: 0x2BAD120 Offset: 0x2BA9120 VA: 0x2BAD120
	|-NativeArray<CullingSplit>.AsReadOnly
	|
	|-RVA: 0x2BAD8F4 Offset: 0x2BA98F4 VA: 0x2BAD8F4
	|-NativeArray<int>.AsReadOnly
	|
	|-RVA: 0x2BAE154 Offset: 0x2BAA154 VA: 0x2BAE154
	|-NativeArray<LightDataGI>.AsReadOnly
	|
	|-RVA: 0x2BAE97C Offset: 0x2BAA97C VA: 0x2BAE97C
	|-NativeArray<Matrix4x4>.AsReadOnly
	|
	|-RVA: 0x2BAF1C0 Offset: 0x2BAB1C0 VA: 0x2BAF1C0
	|-NativeArray<ModifiableContactPair>.AsReadOnly
	|
	|-RVA: 0x2BAF9C8 Offset: 0x2BAB9C8 VA: 0x2BAF9C8
	|-NativeArray<Plane>.AsReadOnly
	|
	|-RVA: 0x2BB01D0 Offset: 0x2BAC1D0 VA: 0x2BB01D0
	|-NativeArray<Quaternion>.AsReadOnly
	|
	|-RVA: 0x2BB098C Offset: 0x2BAC98C VA: 0x2BB098C
	|-NativeArray<sbyte>.AsReadOnly
	|
	|-RVA: 0x2BB1188 Offset: 0x2BAD188 VA: 0x2BB1188
	|-NativeArray<Vector3>.AsReadOnly
	|
	|-RVA: 0x2BB20B8 Offset: 0x2BAE0B8 VA: 0x2BB20B8
	|-NativeArray<__Il2CppFullySharedGenericStructType>.AsReadOnly
	*/
}
