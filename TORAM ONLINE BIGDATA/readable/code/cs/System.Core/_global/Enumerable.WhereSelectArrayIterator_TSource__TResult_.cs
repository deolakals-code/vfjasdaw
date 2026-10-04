// Assembly: System.Core.dll
// Namespace: 
private class Enumerable.WhereSelectArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 15188
{
	// Fields
	private TSource[] source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D77E50 Offset: 0x2D73E50 VA: 0x2D77E50
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<byte, object>, byte>..ctor
	|
	|-RVA: 0x2D7804C Offset: 0x2D7404C VA: 0x2D7804C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<byte, object>, int>..ctor
	|
	|-RVA: 0x2D78248 Offset: 0x2D74248 VA: 0x2D78248
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, bool>..ctor
	|
	|-RVA: 0x2D78448 Offset: 0x2D74448 VA: 0x2D78448
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, byte>..ctor
	|
	|-RVA: 0x2D78644 Offset: 0x2D74644 VA: 0x2D78644
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, short>..ctor
	|
	|-RVA: 0x2D78840 Offset: 0x2D74840 VA: 0x2D78840
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, int>..ctor
	|
	|-RVA: 0x2D78A3C Offset: 0x2D74A3C VA: 0x2D78A3C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, Int32Enum>..ctor
	|
	|-RVA: 0x2D78C38 Offset: 0x2D74C38 VA: 0x2D78C38
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, long>..ctor
	|
	|-RVA: 0x2D78E34 Offset: 0x2D74E34 VA: 0x2D78E34
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>..ctor
	|
	|-RVA: 0x2D7903C Offset: 0x2D7503C VA: 0x2D7903C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, float>..ctor
	|
	|-RVA: 0x2D79238 Offset: 0x2D75238 VA: 0x2D79238
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, Vector3>..ctor
	|
	|-RVA: 0x2D79438 Offset: 0x2D75438 VA: 0x2D79438
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, EnhanceProperties2>, int>..ctor
	|
	|-RVA: 0x2D79674 Offset: 0x2D75674 VA: 0x2D79674
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, bool>..ctor
	|
	|-RVA: 0x2D7986C Offset: 0x2D7586C VA: 0x2D7986C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, byte>..ctor
	|
	|-RVA: 0x2D79A60 Offset: 0x2D75A60 VA: 0x2D79A60
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, short>..ctor
	|
	|-RVA: 0x2D79C54 Offset: 0x2D75C54 VA: 0x2D79C54
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, int>..ctor
	|
	|-RVA: 0x2D79E48 Offset: 0x2D75E48 VA: 0x2D79E48
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, Int32Enum>..ctor
	|
	|-RVA: 0x2D7A03C Offset: 0x2D7603C VA: 0x2D7A03C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, long>..ctor
	|
	|-RVA: 0x2D7A230 Offset: 0x2D76230 VA: 0x2D7A230
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, object>..ctor
	|
	|-RVA: 0x2D7A430 Offset: 0x2D76430 VA: 0x2D7A430
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, float>..ctor
	|
	|-RVA: 0x2D7A624 Offset: 0x2D76624 VA: 0x2D7A624
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, Vector3>..ctor
	|
	|-RVA: 0x2D7A81C Offset: 0x2D7681C VA: 0x2D7A81C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, object>, int>..ctor
	|
	|-RVA: 0x2D7AA18 Offset: 0x2D76A18 VA: 0x2D7AA18
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, object>, Int32Enum>..ctor
	|
	|-RVA: 0x2D7AC14 Offset: 0x2D76C14 VA: 0x2D7AC14
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, bool>..ctor
	|
	|-RVA: 0x2D7AE14 Offset: 0x2D76E14 VA: 0x2D7AE14
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, byte>..ctor
	|
	|-RVA: 0x2D7B010 Offset: 0x2D77010 VA: 0x2D7B010
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, short>..ctor
	|
	|-RVA: 0x2D7B20C Offset: 0x2D7720C VA: 0x2D7B20C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, int>..ctor
	|
	|-RVA: 0x2D7B408 Offset: 0x2D77408 VA: 0x2D7B408
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, Int32Enum>..ctor
	|
	|-RVA: 0x2D7B604 Offset: 0x2D77604 VA: 0x2D7B604
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, long>..ctor
	|
	|-RVA: 0x2D7B800 Offset: 0x2D77800 VA: 0x2D7B800
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, object>..ctor
	|
	|-RVA: 0x2D7BA08 Offset: 0x2D77A08 VA: 0x2D7BA08
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, float>..ctor
	|
	|-RVA: 0x2D7BC04 Offset: 0x2D77C04 VA: 0x2D7BC04
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, Vector3>..ctor
	|
	|-RVA: 0x2D7BE04 Offset: 0x2D77E04 VA: 0x2D7BE04
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, bool>..ctor
	|
	|-RVA: 0x2D7C004 Offset: 0x2D78004 VA: 0x2D7C004
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, byte>..ctor
	|
	|-RVA: 0x2D7C200 Offset: 0x2D78200 VA: 0x2D7C200
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, short>..ctor
	|
	|-RVA: 0x2D7C3FC Offset: 0x2D783FC VA: 0x2D7C3FC
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, int>..ctor
	|
	|-RVA: 0x2D7C5F8 Offset: 0x2D785F8 VA: 0x2D7C5F8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, Int32Enum>..ctor
	|
	|-RVA: 0x2D7C7F4 Offset: 0x2D787F4 VA: 0x2D7C7F4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, long>..ctor
	|
	|-RVA: 0x2D7C9F0 Offset: 0x2D789F0 VA: 0x2D7C9F0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, object>..ctor
	|
	|-RVA: 0x2D7CBF8 Offset: 0x2D78BF8 VA: 0x2D7CBF8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, float>..ctor
	|
	|-RVA: 0x2D7CDF4 Offset: 0x2D78DF4 VA: 0x2D7CDF4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, Vector3>..ctor
	|
	|-RVA: 0x2D7CFF4 Offset: 0x2D78FF4 VA: 0x2D7CFF4
	|-Enumerable.WhereSelectArrayIterator<Nullable<UIMobPropertyLabel.IconValue>, int>..ctor
	|
	|-RVA: 0x2D7D204 Offset: 0x2D79204 VA: 0x2D7D204
	|-Enumerable.WhereSelectArrayIterator<byte, int>..ctor
	|
	|-RVA: 0x2D7D3F8 Offset: 0x2D793F8 VA: 0x2D7D3F8
	|-Enumerable.WhereSelectArrayIterator<int, int>..ctor
	|
	|-RVA: 0x2D7D5EC Offset: 0x2D795EC VA: 0x2D7D5EC
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>..ctor
	|
	|-RVA: 0x2D7D7E0 Offset: 0x2D797E0 VA: 0x2D7D7E0
	|-Enumerable.WhereSelectArrayIterator<long, long>..ctor
	|
	|-RVA: 0x2D7D9D4 Offset: 0x2D799D4 VA: 0x2D7D9D4
	|-Enumerable.WhereSelectArrayIterator<long, TimeSpan>..ctor
	|
	|-RVA: 0x2D7DBC8 Offset: 0x2D79BC8 VA: 0x2D7DBC8
	|-Enumerable.WhereSelectArrayIterator<MobActionTargetData, float>..ctor
	|
	|-RVA: 0x2D7DE04 Offset: 0x2D79E04 VA: 0x2D7DE04
	|-Enumerable.WhereSelectArrayIterator<MobActionTargetData, Vector3>..ctor
	|
	|-RVA: 0x2D7E044 Offset: 0x2D7A044 VA: 0x2D7E044
	|-Enumerable.WhereSelectArrayIterator<object, bool>..ctor
	|
	|-RVA: 0x2D7E23C Offset: 0x2D7A23C VA: 0x2D7E23C
	|-Enumerable.WhereSelectArrayIterator<object, byte>..ctor
	|
	|-RVA: 0x2D7E430 Offset: 0x2D7A430 VA: 0x2D7E430
	|-Enumerable.WhereSelectArrayIterator<object, short>..ctor
	|
	|-RVA: 0x2D7E624 Offset: 0x2D7A624 VA: 0x2D7E624
	|-Enumerable.WhereSelectArrayIterator<object, int>..ctor
	|
	|-RVA: 0x2D7E818 Offset: 0x2D7A818 VA: 0x2D7E818
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>..ctor
	|
	|-RVA: 0x2D7EA0C Offset: 0x2D7AA0C VA: 0x2D7EA0C
	|-Enumerable.WhereSelectArrayIterator<object, long>..ctor
	|
	|-RVA: 0x2D7EC00 Offset: 0x2D7AC00 VA: 0x2D7EC00
	|-Enumerable.WhereSelectArrayIterator<object, object>..ctor
	|
	|-RVA: 0x2D7EE00 Offset: 0x2D7AE00 VA: 0x2D7EE00
	|-Enumerable.WhereSelectArrayIterator<object, float>..ctor
	|
	|-RVA: 0x2D7EFF4 Offset: 0x2D7AFF4 VA: 0x2D7EFF4
	|-Enumerable.WhereSelectArrayIterator<object, TimeSpan>..ctor
	|
	|-RVA: 0x2D7F1E8 Offset: 0x2D7B1E8 VA: 0x2D7F1E8
	|-Enumerable.WhereSelectArrayIterator<object, Vector3>..ctor
	|
	|-RVA: 0x2D7F3E0 Offset: 0x2D7B3E0 VA: 0x2D7F3E0
	|-Enumerable.WhereSelectArrayIterator<float, int>..ctor
	|
	|-RVA: 0x2D7F5D4 Offset: 0x2D7B5D4 VA: 0x2D7F5D4
	|-Enumerable.WhereSelectArrayIterator<TimeSpan, long>..ctor
	|
	|-RVA: 0x2D7F7C8 Offset: 0x2D7B7C8 VA: 0x2D7F7C8
	|-Enumerable.WhereSelectArrayIterator<TimeSpan, TimeSpan>..ctor
	|
	|-RVA: 0x2D7F9BC Offset: 0x2D7B9BC VA: 0x2D7F9BC
	|-Enumerable.WhereSelectArrayIterator<Vector3, int>..ctor
	|
	|-RVA: 0x2D7FBD8 Offset: 0x2D7BBD8 VA: 0x2D7FBD8
	|-Enumerable.WhereSelectArrayIterator<Vector3, float>..ctor
	|
	|-RVA: 0x2D7FDF4 Offset: 0x2D7BDF4 VA: 0x2D7FDF4
	|-Enumerable.WhereSelectArrayIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D77EB8 Offset: 0x2D73EB8 VA: 0x2D77EB8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<byte, object>, byte>.Clone
	|
	|-RVA: 0x2D780B4 Offset: 0x2D740B4 VA: 0x2D780B4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<byte, object>, int>.Clone
	|
	|-RVA: 0x2D782B0 Offset: 0x2D742B0 VA: 0x2D782B0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, bool>.Clone
	|
	|-RVA: 0x2D784B0 Offset: 0x2D744B0 VA: 0x2D784B0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, byte>.Clone
	|
	|-RVA: 0x2D786AC Offset: 0x2D746AC VA: 0x2D786AC
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, short>.Clone
	|
	|-RVA: 0x2D788A8 Offset: 0x2D748A8 VA: 0x2D788A8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, int>.Clone
	|
	|-RVA: 0x2D78AA4 Offset: 0x2D74AA4 VA: 0x2D78AA4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, Int32Enum>.Clone
	|
	|-RVA: 0x2D78CA0 Offset: 0x2D74CA0 VA: 0x2D78CA0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, long>.Clone
	|
	|-RVA: 0x2D78E9C Offset: 0x2D74E9C VA: 0x2D78E9C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>.Clone
	|
	|-RVA: 0x2D790A4 Offset: 0x2D750A4 VA: 0x2D790A4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, float>.Clone
	|
	|-RVA: 0x2D792A0 Offset: 0x2D752A0 VA: 0x2D792A0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, Vector3>.Clone
	|
	|-RVA: 0x2D794A0 Offset: 0x2D754A0 VA: 0x2D794A0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, EnhanceProperties2>, int>.Clone
	|
	|-RVA: 0x2D796DC Offset: 0x2D756DC VA: 0x2D796DC
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, bool>.Clone
	|
	|-RVA: 0x2D798D4 Offset: 0x2D758D4 VA: 0x2D798D4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, byte>.Clone
	|
	|-RVA: 0x2D79AC8 Offset: 0x2D75AC8 VA: 0x2D79AC8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, short>.Clone
	|
	|-RVA: 0x2D79CBC Offset: 0x2D75CBC VA: 0x2D79CBC
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, int>.Clone
	|
	|-RVA: 0x2D79EB0 Offset: 0x2D75EB0 VA: 0x2D79EB0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, Int32Enum>.Clone
	|
	|-RVA: 0x2D7A0A4 Offset: 0x2D760A4 VA: 0x2D7A0A4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, long>.Clone
	|
	|-RVA: 0x2D7A298 Offset: 0x2D76298 VA: 0x2D7A298
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, object>.Clone
	|
	|-RVA: 0x2D7A498 Offset: 0x2D76498 VA: 0x2D7A498
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, float>.Clone
	|
	|-RVA: 0x2D7A68C Offset: 0x2D7668C VA: 0x2D7A68C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, Vector3>.Clone
	|
	|-RVA: 0x2D7A884 Offset: 0x2D76884 VA: 0x2D7A884
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, object>, int>.Clone
	|
	|-RVA: 0x2D7AA80 Offset: 0x2D76A80 VA: 0x2D7AA80
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, object>, Int32Enum>.Clone
	|
	|-RVA: 0x2D7AC7C Offset: 0x2D76C7C VA: 0x2D7AC7C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, bool>.Clone
	|
	|-RVA: 0x2D7AE7C Offset: 0x2D76E7C VA: 0x2D7AE7C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, byte>.Clone
	|
	|-RVA: 0x2D7B078 Offset: 0x2D77078 VA: 0x2D7B078
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, short>.Clone
	|
	|-RVA: 0x2D7B274 Offset: 0x2D77274 VA: 0x2D7B274
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, int>.Clone
	|
	|-RVA: 0x2D7B470 Offset: 0x2D77470 VA: 0x2D7B470
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, Int32Enum>.Clone
	|
	|-RVA: 0x2D7B66C Offset: 0x2D7766C VA: 0x2D7B66C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, long>.Clone
	|
	|-RVA: 0x2D7B868 Offset: 0x2D77868 VA: 0x2D7B868
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, object>.Clone
	|
	|-RVA: 0x2D7BA70 Offset: 0x2D77A70 VA: 0x2D7BA70
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, float>.Clone
	|
	|-RVA: 0x2D7BC6C Offset: 0x2D77C6C VA: 0x2D7BC6C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, Vector3>.Clone
	|
	|-RVA: 0x2D7BE6C Offset: 0x2D77E6C VA: 0x2D7BE6C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, bool>.Clone
	|
	|-RVA: 0x2D7C06C Offset: 0x2D7806C VA: 0x2D7C06C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, byte>.Clone
	|
	|-RVA: 0x2D7C268 Offset: 0x2D78268 VA: 0x2D7C268
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, short>.Clone
	|
	|-RVA: 0x2D7C464 Offset: 0x2D78464 VA: 0x2D7C464
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, int>.Clone
	|
	|-RVA: 0x2D7C660 Offset: 0x2D78660 VA: 0x2D7C660
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, Int32Enum>.Clone
	|
	|-RVA: 0x2D7C85C Offset: 0x2D7885C VA: 0x2D7C85C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, long>.Clone
	|
	|-RVA: 0x2D7CA58 Offset: 0x2D78A58 VA: 0x2D7CA58
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, object>.Clone
	|
	|-RVA: 0x2D7CC60 Offset: 0x2D78C60 VA: 0x2D7CC60
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, float>.Clone
	|
	|-RVA: 0x2D7CE5C Offset: 0x2D78E5C VA: 0x2D7CE5C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, Vector3>.Clone
	|
	|-RVA: 0x2D7D05C Offset: 0x2D7905C VA: 0x2D7D05C
	|-Enumerable.WhereSelectArrayIterator<Nullable<UIMobPropertyLabel.IconValue>, int>.Clone
	|
	|-RVA: 0x2D7D26C Offset: 0x2D7926C VA: 0x2D7D26C
	|-Enumerable.WhereSelectArrayIterator<byte, int>.Clone
	|
	|-RVA: 0x2D7D460 Offset: 0x2D79460 VA: 0x2D7D460
	|-Enumerable.WhereSelectArrayIterator<int, int>.Clone
	|
	|-RVA: 0x2D7D654 Offset: 0x2D79654 VA: 0x2D7D654
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.Clone
	|
	|-RVA: 0x2D7D848 Offset: 0x2D79848 VA: 0x2D7D848
	|-Enumerable.WhereSelectArrayIterator<long, long>.Clone
	|
	|-RVA: 0x2D7DA3C Offset: 0x2D79A3C VA: 0x2D7DA3C
	|-Enumerable.WhereSelectArrayIterator<long, TimeSpan>.Clone
	|
	|-RVA: 0x2D7DC30 Offset: 0x2D79C30 VA: 0x2D7DC30
	|-Enumerable.WhereSelectArrayIterator<MobActionTargetData, float>.Clone
	|
	|-RVA: 0x2D7DE6C Offset: 0x2D79E6C VA: 0x2D7DE6C
	|-Enumerable.WhereSelectArrayIterator<MobActionTargetData, Vector3>.Clone
	|
	|-RVA: 0x2D7E0AC Offset: 0x2D7A0AC VA: 0x2D7E0AC
	|-Enumerable.WhereSelectArrayIterator<object, bool>.Clone
	|
	|-RVA: 0x2D7E2A4 Offset: 0x2D7A2A4 VA: 0x2D7E2A4
	|-Enumerable.WhereSelectArrayIterator<object, byte>.Clone
	|
	|-RVA: 0x2D7E498 Offset: 0x2D7A498 VA: 0x2D7E498
	|-Enumerable.WhereSelectArrayIterator<object, short>.Clone
	|
	|-RVA: 0x2D7E68C Offset: 0x2D7A68C VA: 0x2D7E68C
	|-Enumerable.WhereSelectArrayIterator<object, int>.Clone
	|
	|-RVA: 0x2D7E880 Offset: 0x2D7A880 VA: 0x2D7E880
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.Clone
	|
	|-RVA: 0x2D7EA74 Offset: 0x2D7AA74 VA: 0x2D7EA74
	|-Enumerable.WhereSelectArrayIterator<object, long>.Clone
	|
	|-RVA: 0x2D7EC68 Offset: 0x2D7AC68 VA: 0x2D7EC68
	|-Enumerable.WhereSelectArrayIterator<object, object>.Clone
	|
	|-RVA: 0x2D7EE68 Offset: 0x2D7AE68 VA: 0x2D7EE68
	|-Enumerable.WhereSelectArrayIterator<object, float>.Clone
	|
	|-RVA: 0x2D7F05C Offset: 0x2D7B05C VA: 0x2D7F05C
	|-Enumerable.WhereSelectArrayIterator<object, TimeSpan>.Clone
	|
	|-RVA: 0x2D7F250 Offset: 0x2D7B250 VA: 0x2D7F250
	|-Enumerable.WhereSelectArrayIterator<object, Vector3>.Clone
	|
	|-RVA: 0x2D7F448 Offset: 0x2D7B448 VA: 0x2D7F448
	|-Enumerable.WhereSelectArrayIterator<float, int>.Clone
	|
	|-RVA: 0x2D7F63C Offset: 0x2D7B63C VA: 0x2D7F63C
	|-Enumerable.WhereSelectArrayIterator<TimeSpan, long>.Clone
	|
	|-RVA: 0x2D7F830 Offset: 0x2D7B830 VA: 0x2D7F830
	|-Enumerable.WhereSelectArrayIterator<TimeSpan, TimeSpan>.Clone
	|
	|-RVA: 0x2D7FA24 Offset: 0x2D7BA24 VA: 0x2D7FA24
	|-Enumerable.WhereSelectArrayIterator<Vector3, int>.Clone
	|
	|-RVA: 0x2D7FC40 Offset: 0x2D7BC40 VA: 0x2D7FC40
	|-Enumerable.WhereSelectArrayIterator<Vector3, float>.Clone
	|
	|-RVA: 0x2D7FE90 Offset: 0x2D7BE90 VA: 0x2D7FE90
	|-Enumerable.WhereSelectArrayIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D77F24 Offset: 0x2D73F24 VA: 0x2D77F24
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<byte, object>, byte>.MoveNext
	|
	|-RVA: 0x2D78120 Offset: 0x2D74120 VA: 0x2D78120
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<byte, object>, int>.MoveNext
	|
	|-RVA: 0x2D7831C Offset: 0x2D7431C VA: 0x2D7831C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, bool>.MoveNext
	|
	|-RVA: 0x2D7851C Offset: 0x2D7451C VA: 0x2D7851C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, byte>.MoveNext
	|
	|-RVA: 0x2D78718 Offset: 0x2D74718 VA: 0x2D78718
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, short>.MoveNext
	|
	|-RVA: 0x2D78914 Offset: 0x2D74914 VA: 0x2D78914
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, int>.MoveNext
	|
	|-RVA: 0x2D78B10 Offset: 0x2D74B10 VA: 0x2D78B10
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D78D0C Offset: 0x2D74D0C VA: 0x2D78D0C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, long>.MoveNext
	|
	|-RVA: 0x2D78F08 Offset: 0x2D74F08 VA: 0x2D78F08
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>.MoveNext
	|
	|-RVA: 0x2D79110 Offset: 0x2D75110 VA: 0x2D79110
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, float>.MoveNext
	|
	|-RVA: 0x2D7930C Offset: 0x2D7530C VA: 0x2D7930C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, Vector3>.MoveNext
	|
	|-RVA: 0x2D7950C Offset: 0x2D7550C VA: 0x2D7950C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, EnhanceProperties2>, int>.MoveNext
	|
	|-RVA: 0x2D79748 Offset: 0x2D75748 VA: 0x2D79748
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, bool>.MoveNext
	|
	|-RVA: 0x2D79940 Offset: 0x2D75940 VA: 0x2D79940
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, byte>.MoveNext
	|
	|-RVA: 0x2D79B34 Offset: 0x2D75B34 VA: 0x2D79B34
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, short>.MoveNext
	|
	|-RVA: 0x2D79D28 Offset: 0x2D75D28 VA: 0x2D79D28
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, int>.MoveNext
	|
	|-RVA: 0x2D79F1C Offset: 0x2D75F1C VA: 0x2D79F1C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D7A110 Offset: 0x2D76110 VA: 0x2D7A110
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, long>.MoveNext
	|
	|-RVA: 0x2D7A304 Offset: 0x2D76304 VA: 0x2D7A304
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, object>.MoveNext
	|
	|-RVA: 0x2D7A504 Offset: 0x2D76504 VA: 0x2D7A504
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, float>.MoveNext
	|
	|-RVA: 0x2D7A6F8 Offset: 0x2D766F8 VA: 0x2D7A6F8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, Vector3>.MoveNext
	|
	|-RVA: 0x2D7A8F0 Offset: 0x2D768F0 VA: 0x2D7A8F0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, object>, int>.MoveNext
	|
	|-RVA: 0x2D7AAEC Offset: 0x2D76AEC VA: 0x2D7AAEC
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D7ACE8 Offset: 0x2D76CE8 VA: 0x2D7ACE8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, bool>.MoveNext
	|
	|-RVA: 0x2D7AEE8 Offset: 0x2D76EE8 VA: 0x2D7AEE8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, byte>.MoveNext
	|
	|-RVA: 0x2D7B0E4 Offset: 0x2D770E4 VA: 0x2D7B0E4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, short>.MoveNext
	|
	|-RVA: 0x2D7B2E0 Offset: 0x2D772E0 VA: 0x2D7B2E0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, int>.MoveNext
	|
	|-RVA: 0x2D7B4DC Offset: 0x2D774DC VA: 0x2D7B4DC
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D7B6D8 Offset: 0x2D776D8 VA: 0x2D7B6D8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, long>.MoveNext
	|
	|-RVA: 0x2D7B8D4 Offset: 0x2D778D4 VA: 0x2D7B8D4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, object>.MoveNext
	|
	|-RVA: 0x2D7BADC Offset: 0x2D77ADC VA: 0x2D7BADC
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, float>.MoveNext
	|
	|-RVA: 0x2D7BCD8 Offset: 0x2D77CD8 VA: 0x2D7BCD8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, Vector3>.MoveNext
	|
	|-RVA: 0x2D7BED8 Offset: 0x2D77ED8 VA: 0x2D7BED8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, bool>.MoveNext
	|
	|-RVA: 0x2D7C0D8 Offset: 0x2D780D8 VA: 0x2D7C0D8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, byte>.MoveNext
	|
	|-RVA: 0x2D7C2D4 Offset: 0x2D782D4 VA: 0x2D7C2D4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, short>.MoveNext
	|
	|-RVA: 0x2D7C4D0 Offset: 0x2D784D0 VA: 0x2D7C4D0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, int>.MoveNext
	|
	|-RVA: 0x2D7C6CC Offset: 0x2D786CC VA: 0x2D7C6CC
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D7C8C8 Offset: 0x2D788C8 VA: 0x2D7C8C8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, long>.MoveNext
	|
	|-RVA: 0x2D7CAC4 Offset: 0x2D78AC4 VA: 0x2D7CAC4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, object>.MoveNext
	|
	|-RVA: 0x2D7CCCC Offset: 0x2D78CCC VA: 0x2D7CCCC
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, float>.MoveNext
	|
	|-RVA: 0x2D7CEC8 Offset: 0x2D78EC8 VA: 0x2D7CEC8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, Vector3>.MoveNext
	|
	|-RVA: 0x2D7D0C8 Offset: 0x2D790C8 VA: 0x2D7D0C8
	|-Enumerable.WhereSelectArrayIterator<Nullable<UIMobPropertyLabel.IconValue>, int>.MoveNext
	|
	|-RVA: 0x2D7D2D8 Offset: 0x2D792D8 VA: 0x2D7D2D8
	|-Enumerable.WhereSelectArrayIterator<byte, int>.MoveNext
	|
	|-RVA: 0x2D7D4CC Offset: 0x2D794CC VA: 0x2D7D4CC
	|-Enumerable.WhereSelectArrayIterator<int, int>.MoveNext
	|
	|-RVA: 0x2D7D6C0 Offset: 0x2D796C0 VA: 0x2D7D6C0
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x2D7D8B4 Offset: 0x2D798B4 VA: 0x2D7D8B4
	|-Enumerable.WhereSelectArrayIterator<long, long>.MoveNext
	|
	|-RVA: 0x2D7DAA8 Offset: 0x2D79AA8 VA: 0x2D7DAA8
	|-Enumerable.WhereSelectArrayIterator<long, TimeSpan>.MoveNext
	|
	|-RVA: 0x2D7DC9C Offset: 0x2D79C9C VA: 0x2D7DC9C
	|-Enumerable.WhereSelectArrayIterator<MobActionTargetData, float>.MoveNext
	|
	|-RVA: 0x2D7DED8 Offset: 0x2D79ED8 VA: 0x2D7DED8
	|-Enumerable.WhereSelectArrayIterator<MobActionTargetData, Vector3>.MoveNext
	|
	|-RVA: 0x2D7E118 Offset: 0x2D7A118 VA: 0x2D7E118
	|-Enumerable.WhereSelectArrayIterator<object, bool>.MoveNext
	|
	|-RVA: 0x2D7E310 Offset: 0x2D7A310 VA: 0x2D7E310
	|-Enumerable.WhereSelectArrayIterator<object, byte>.MoveNext
	|
	|-RVA: 0x2D7E504 Offset: 0x2D7A504 VA: 0x2D7E504
	|-Enumerable.WhereSelectArrayIterator<object, short>.MoveNext
	|
	|-RVA: 0x2D7E6F8 Offset: 0x2D7A6F8 VA: 0x2D7E6F8
	|-Enumerable.WhereSelectArrayIterator<object, int>.MoveNext
	|
	|-RVA: 0x2D7E8EC Offset: 0x2D7A8EC VA: 0x2D7E8EC
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D7EAE0 Offset: 0x2D7AAE0 VA: 0x2D7EAE0
	|-Enumerable.WhereSelectArrayIterator<object, long>.MoveNext
	|
	|-RVA: 0x2D7ECD4 Offset: 0x2D7ACD4 VA: 0x2D7ECD4
	|-Enumerable.WhereSelectArrayIterator<object, object>.MoveNext
	|
	|-RVA: 0x2D7EED4 Offset: 0x2D7AED4 VA: 0x2D7EED4
	|-Enumerable.WhereSelectArrayIterator<object, float>.MoveNext
	|
	|-RVA: 0x2D7F0C8 Offset: 0x2D7B0C8 VA: 0x2D7F0C8
	|-Enumerable.WhereSelectArrayIterator<object, TimeSpan>.MoveNext
	|
	|-RVA: 0x2D7F2BC Offset: 0x2D7B2BC VA: 0x2D7F2BC
	|-Enumerable.WhereSelectArrayIterator<object, Vector3>.MoveNext
	|
	|-RVA: 0x2D7F4B4 Offset: 0x2D7B4B4 VA: 0x2D7F4B4
	|-Enumerable.WhereSelectArrayIterator<float, int>.MoveNext
	|
	|-RVA: 0x2D7F6A8 Offset: 0x2D7B6A8 VA: 0x2D7F6A8
	|-Enumerable.WhereSelectArrayIterator<TimeSpan, long>.MoveNext
	|
	|-RVA: 0x2D7F89C Offset: 0x2D7B89C VA: 0x2D7F89C
	|-Enumerable.WhereSelectArrayIterator<TimeSpan, TimeSpan>.MoveNext
	|
	|-RVA: 0x2D7FA90 Offset: 0x2D7BA90 VA: 0x2D7FA90
	|-Enumerable.WhereSelectArrayIterator<Vector3, int>.MoveNext
	|
	|-RVA: 0x2D7FCAC Offset: 0x2D7BCAC VA: 0x2D7FCAC
	|-Enumerable.WhereSelectArrayIterator<Vector3, float>.MoveNext
	|
	|-RVA: 0x2D7FF54 Offset: 0x2D7BF54 VA: 0x2D7FF54
	|-Enumerable.WhereSelectArrayIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2680D70 Offset: 0x267CD70 VA: 0x2680D70
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<byte, object>, byte>.Select<int>
	|
	|-RVA: 0x2680E08 Offset: 0x267CE08 VA: 0x2680E08
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, int>.Select<int>
	|
	|-RVA: 0x2680EA0 Offset: 0x267CEA0 VA: 0x2680EA0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>.Select<bool>
	|
	|-RVA: 0x2680F38 Offset: 0x267CF38 VA: 0x2680F38
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>.Select<byte>
	|
	|-RVA: 0x2680FD0 Offset: 0x267CFD0 VA: 0x2680FD0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>.Select<short>
	|
	|-RVA: 0x2681068 Offset: 0x267D068 VA: 0x2681068
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>.Select<int>
	|
	|-RVA: 0x2681100 Offset: 0x267D100 VA: 0x2681100
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>.Select<Int32Enum>
	|
	|-RVA: 0x2681198 Offset: 0x267D198 VA: 0x2681198
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>.Select<long>
	|
	|-RVA: 0x2681230 Offset: 0x267D230 VA: 0x2681230
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>.Select<object>
	|
	|-RVA: 0x26812C8 Offset: 0x267D2C8 VA: 0x26812C8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>.Select<float>
	|
	|-RVA: 0x2681360 Offset: 0x267D360 VA: 0x2681360
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>.Select<Vector3>
	|
	|-RVA: 0x26813F8 Offset: 0x267D3F8 VA: 0x26813F8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, EnhanceProperties2>, int>.Select<int>
	|
	|-RVA: 0x2681490 Offset: 0x267D490 VA: 0x2681490
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, int>.Select<int>
	|
	|-RVA: 0x2681528 Offset: 0x267D528 VA: 0x2681528
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, Int32Enum>.Select<int>
	|
	|-RVA: 0x26815C0 Offset: 0x267D5C0 VA: 0x26815C0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, object>.Select<bool>
	|
	|-RVA: 0x2681658 Offset: 0x267D658 VA: 0x2681658
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, object>.Select<byte>
	|
	|-RVA: 0x26816F0 Offset: 0x267D6F0 VA: 0x26816F0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, object>.Select<short>
	|
	|-RVA: 0x2681788 Offset: 0x267D788 VA: 0x2681788
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, object>.Select<int>
	|
	|-RVA: 0x2681820 Offset: 0x267D820 VA: 0x2681820
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, object>.Select<Int32Enum>
	|
	|-RVA: 0x26818B8 Offset: 0x267D8B8 VA: 0x26818B8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, object>.Select<long>
	|
	|-RVA: 0x2681950 Offset: 0x267D950 VA: 0x2681950
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, object>.Select<object>
	|
	|-RVA: 0x26819E8 Offset: 0x267D9E8 VA: 0x26819E8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, object>.Select<float>
	|
	|-RVA: 0x2681A80 Offset: 0x267DA80 VA: 0x2681A80
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, object>.Select<Vector3>
	|
	|-RVA: 0x2681B18 Offset: 0x267DB18 VA: 0x2681B18
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, object>, Int32Enum>.Select<int>
	|
	|-RVA: 0x2681BB0 Offset: 0x267DBB0 VA: 0x2681BB0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, object>.Select<bool>
	|
	|-RVA: 0x2681C48 Offset: 0x267DC48 VA: 0x2681C48
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, object>.Select<byte>
	|
	|-RVA: 0x2681CE0 Offset: 0x267DCE0 VA: 0x2681CE0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, object>.Select<short>
	|
	|-RVA: 0x2681D78 Offset: 0x267DD78 VA: 0x2681D78
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, object>.Select<int>
	|
	|-RVA: 0x2681E10 Offset: 0x267DE10 VA: 0x2681E10
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, object>.Select<Int32Enum>
	|
	|-RVA: 0x2681EA8 Offset: 0x267DEA8 VA: 0x2681EA8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, object>.Select<long>
	|
	|-RVA: 0x2681F40 Offset: 0x267DF40 VA: 0x2681F40
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, object>.Select<object>
	|
	|-RVA: 0x2681FD8 Offset: 0x267DFD8 VA: 0x2681FD8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, object>.Select<float>
	|
	|-RVA: 0x2682070 Offset: 0x267E070 VA: 0x2682070
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, object>.Select<Vector3>
	|
	|-RVA: 0x2682108 Offset: 0x267E108 VA: 0x2682108
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, object>.Select<bool>
	|
	|-RVA: 0x26821A0 Offset: 0x267E1A0 VA: 0x26821A0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, object>.Select<byte>
	|
	|-RVA: 0x2682238 Offset: 0x267E238 VA: 0x2682238
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, object>.Select<short>
	|
	|-RVA: 0x26822D0 Offset: 0x267E2D0 VA: 0x26822D0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, object>.Select<int>
	|
	|-RVA: 0x2682368 Offset: 0x267E368 VA: 0x2682368
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, object>.Select<Int32Enum>
	|
	|-RVA: 0x2682400 Offset: 0x267E400 VA: 0x2682400
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, object>.Select<long>
	|
	|-RVA: 0x2682498 Offset: 0x267E498 VA: 0x2682498
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, object>.Select<object>
	|
	|-RVA: 0x2682530 Offset: 0x267E530 VA: 0x2682530
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, object>.Select<float>
	|
	|-RVA: 0x26825C8 Offset: 0x267E5C8 VA: 0x26825C8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, object>.Select<Vector3>
	|
	|-RVA: 0x2682660 Offset: 0x267E660 VA: 0x2682660
	|-Enumerable.WhereSelectArrayIterator<Nullable<UIMobPropertyLabel.IconValue>, int>.Select<int>
	|
	|-RVA: 0x26826F8 Offset: 0x267E6F8 VA: 0x26826F8
	|-Enumerable.WhereSelectArrayIterator<byte, int>.Select<int>
	|
	|-RVA: 0x2682790 Offset: 0x267E790 VA: 0x2682790
	|-Enumerable.WhereSelectArrayIterator<int, int>.Select<int>
	|
	|-RVA: 0x2682828 Offset: 0x267E828 VA: 0x2682828
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.Select<int>
	|
	|-RVA: 0x26828C0 Offset: 0x267E8C0 VA: 0x26828C0
	|-Enumerable.WhereSelectArrayIterator<long, TimeSpan>.Select<long>
	|
	|-RVA: 0x2682958 Offset: 0x267E958 VA: 0x2682958
	|-Enumerable.WhereSelectArrayIterator<MobActionTargetData, Vector3>.Select<float>
	|
	|-RVA: 0x26829F0 Offset: 0x267E9F0 VA: 0x26829F0
	|-Enumerable.WhereSelectArrayIterator<object, byte>.Select<int>
	|
	|-RVA: 0x2682A88 Offset: 0x267EA88 VA: 0x2682A88
	|-Enumerable.WhereSelectArrayIterator<object, int>.Select<int>
	|
	|-RVA: 0x2682B20 Offset: 0x267EB20 VA: 0x2682B20
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.Select<int>
	|
	|-RVA: 0x2682BB8 Offset: 0x267EBB8 VA: 0x2682BB8
	|-Enumerable.WhereSelectArrayIterator<object, long>.Select<TimeSpan>
	|
	|-RVA: 0x2682C50 Offset: 0x267EC50 VA: 0x2682C50
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<bool>
	|
	|-RVA: 0x2682CE8 Offset: 0x267ECE8 VA: 0x2682CE8
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<byte>
	|
	|-RVA: 0x2682D80 Offset: 0x267ED80 VA: 0x2682D80
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<short>
	|
	|-RVA: 0x2682E18 Offset: 0x267EE18 VA: 0x2682E18
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<int>
	|
	|-RVA: 0x2682EB0 Offset: 0x267EEB0 VA: 0x2682EB0
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<Int32Enum>
	|
	|-RVA: 0x2682F48 Offset: 0x267EF48 VA: 0x2682F48
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<long>
	|
	|-RVA: 0x2682FE0 Offset: 0x267EFE0 VA: 0x2682FE0
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<object>
	|
	|-RVA: 0x2683078 Offset: 0x267F078 VA: 0x2683078
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<float>
	|
	|-RVA: 0x2683110 Offset: 0x267F110 VA: 0x2683110
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<Vector3>
	|
	|-RVA: 0x26831A8 Offset: 0x267F1A8 VA: 0x26831A8
	|-Enumerable.WhereSelectArrayIterator<object, float>.Select<int>
	|
	|-RVA: 0x2683240 Offset: 0x267F240 VA: 0x2683240
	|-Enumerable.WhereSelectArrayIterator<object, Vector3>.Select<float>
	|
	|-RVA: 0x26832D8 Offset: 0x267F2D8 VA: 0x26832D8
	|-Enumerable.WhereSelectArrayIterator<float, int>.Select<int>
	|
	|-RVA: 0x2683370 Offset: 0x267F370 VA: 0x2683370
	|-Enumerable.WhereSelectArrayIterator<TimeSpan, long>.Select<TimeSpan>
	|
	|-RVA: 0x2683408 Offset: 0x267F408 VA: 0x2683408
	|-Enumerable.WhereSelectArrayIterator<Vector3, float>.Select<int>
	|
	|-RVA: 0x26834A0 Offset: 0x267F4A0 VA: 0x26834A0
	|-Enumerable.WhereSelectArrayIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D77FE4 Offset: 0x2D73FE4 VA: 0x2D77FE4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<byte, object>, byte>.Where
	|
	|-RVA: 0x2D781E0 Offset: 0x2D741E0 VA: 0x2D781E0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<byte, object>, int>.Where
	|
	|-RVA: 0x2D783E0 Offset: 0x2D743E0 VA: 0x2D783E0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, bool>.Where
	|
	|-RVA: 0x2D785DC Offset: 0x2D745DC VA: 0x2D785DC
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, byte>.Where
	|
	|-RVA: 0x2D787D8 Offset: 0x2D747D8 VA: 0x2D787D8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, short>.Where
	|
	|-RVA: 0x2D789D4 Offset: 0x2D749D4 VA: 0x2D789D4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, int>.Where
	|
	|-RVA: 0x2D78BD0 Offset: 0x2D74BD0 VA: 0x2D78BD0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, Int32Enum>.Where
	|
	|-RVA: 0x2D78DCC Offset: 0x2D74DCC VA: 0x2D78DCC
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, long>.Where
	|
	|-RVA: 0x2D78FD4 Offset: 0x2D74FD4 VA: 0x2D78FD4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>.Where
	|
	|-RVA: 0x2D791D0 Offset: 0x2D751D0 VA: 0x2D791D0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, float>.Where
	|
	|-RVA: 0x2D793D0 Offset: 0x2D753D0 VA: 0x2D793D0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, Vector3>.Where
	|
	|-RVA: 0x2D7960C Offset: 0x2D7560C VA: 0x2D7960C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, EnhanceProperties2>, int>.Where
	|
	|-RVA: 0x2D79804 Offset: 0x2D75804 VA: 0x2D79804
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, bool>.Where
	|
	|-RVA: 0x2D799F8 Offset: 0x2D759F8 VA: 0x2D799F8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, byte>.Where
	|
	|-RVA: 0x2D79BEC Offset: 0x2D75BEC VA: 0x2D79BEC
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, short>.Where
	|
	|-RVA: 0x2D79DE0 Offset: 0x2D75DE0 VA: 0x2D79DE0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, int>.Where
	|
	|-RVA: 0x2D79FD4 Offset: 0x2D75FD4 VA: 0x2D79FD4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, Int32Enum>.Where
	|
	|-RVA: 0x2D7A1C8 Offset: 0x2D761C8 VA: 0x2D7A1C8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, long>.Where
	|
	|-RVA: 0x2D7A3C8 Offset: 0x2D763C8 VA: 0x2D7A3C8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, object>.Where
	|
	|-RVA: 0x2D7A5BC Offset: 0x2D765BC VA: 0x2D7A5BC
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, float>.Where
	|
	|-RVA: 0x2D7A7B4 Offset: 0x2D767B4 VA: 0x2D7A7B4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, int>, Vector3>.Where
	|
	|-RVA: 0x2D7A9B0 Offset: 0x2D769B0 VA: 0x2D7A9B0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, object>, int>.Where
	|
	|-RVA: 0x2D7ABAC Offset: 0x2D76BAC VA: 0x2D7ABAC
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<Int32Enum, object>, Int32Enum>.Where
	|
	|-RVA: 0x2D7ADAC Offset: 0x2D76DAC VA: 0x2D7ADAC
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, bool>.Where
	|
	|-RVA: 0x2D7AFA8 Offset: 0x2D76FA8 VA: 0x2D7AFA8
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, byte>.Where
	|
	|-RVA: 0x2D7B1A4 Offset: 0x2D771A4 VA: 0x2D7B1A4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, short>.Where
	|
	|-RVA: 0x2D7B3A0 Offset: 0x2D773A0 VA: 0x2D7B3A0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, int>.Where
	|
	|-RVA: 0x2D7B59C Offset: 0x2D7759C VA: 0x2D7B59C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, Int32Enum>.Where
	|
	|-RVA: 0x2D7B798 Offset: 0x2D77798 VA: 0x2D7B798
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, long>.Where
	|
	|-RVA: 0x2D7B9A0 Offset: 0x2D779A0 VA: 0x2D7B9A0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, object>.Where
	|
	|-RVA: 0x2D7BB9C Offset: 0x2D77B9C VA: 0x2D7BB9C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, float>.Where
	|
	|-RVA: 0x2D7BD9C Offset: 0x2D77D9C VA: 0x2D7BD9C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, int>, Vector3>.Where
	|
	|-RVA: 0x2D7BF9C Offset: 0x2D77F9C VA: 0x2D7BF9C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, bool>.Where
	|
	|-RVA: 0x2D7C198 Offset: 0x2D78198 VA: 0x2D7C198
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, byte>.Where
	|
	|-RVA: 0x2D7C394 Offset: 0x2D78394 VA: 0x2D7C394
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, short>.Where
	|
	|-RVA: 0x2D7C590 Offset: 0x2D78590 VA: 0x2D7C590
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, int>.Where
	|
	|-RVA: 0x2D7C78C Offset: 0x2D7878C VA: 0x2D7C78C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, Int32Enum>.Where
	|
	|-RVA: 0x2D7C988 Offset: 0x2D78988 VA: 0x2D7C988
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, long>.Where
	|
	|-RVA: 0x2D7CB90 Offset: 0x2D78B90 VA: 0x2D7CB90
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, object>.Where
	|
	|-RVA: 0x2D7CD8C Offset: 0x2D78D8C VA: 0x2D7CD8C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, float>.Where
	|
	|-RVA: 0x2D7CF8C Offset: 0x2D78F8C VA: 0x2D7CF8C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, float>, Vector3>.Where
	|
	|-RVA: 0x2D7D19C Offset: 0x2D7919C VA: 0x2D7D19C
	|-Enumerable.WhereSelectArrayIterator<Nullable<UIMobPropertyLabel.IconValue>, int>.Where
	|
	|-RVA: 0x2D7D390 Offset: 0x2D79390 VA: 0x2D7D390
	|-Enumerable.WhereSelectArrayIterator<byte, int>.Where
	|
	|-RVA: 0x2D7D584 Offset: 0x2D79584 VA: 0x2D7D584
	|-Enumerable.WhereSelectArrayIterator<int, int>.Where
	|
	|-RVA: 0x2D7D778 Offset: 0x2D79778 VA: 0x2D7D778
	|-Enumerable.WhereSelectArrayIterator<Int32Enum, int>.Where
	|
	|-RVA: 0x2D7D96C Offset: 0x2D7996C VA: 0x2D7D96C
	|-Enumerable.WhereSelectArrayIterator<long, long>.Where
	|
	|-RVA: 0x2D7DB60 Offset: 0x2D79B60 VA: 0x2D7DB60
	|-Enumerable.WhereSelectArrayIterator<long, TimeSpan>.Where
	|
	|-RVA: 0x2D7DD9C Offset: 0x2D79D9C VA: 0x2D7DD9C
	|-Enumerable.WhereSelectArrayIterator<MobActionTargetData, float>.Where
	|
	|-RVA: 0x2D7DFDC Offset: 0x2D79FDC VA: 0x2D7DFDC
	|-Enumerable.WhereSelectArrayIterator<MobActionTargetData, Vector3>.Where
	|
	|-RVA: 0x2D7E1D4 Offset: 0x2D7A1D4 VA: 0x2D7E1D4
	|-Enumerable.WhereSelectArrayIterator<object, bool>.Where
	|
	|-RVA: 0x2D7E3C8 Offset: 0x2D7A3C8 VA: 0x2D7E3C8
	|-Enumerable.WhereSelectArrayIterator<object, byte>.Where
	|
	|-RVA: 0x2D7E5BC Offset: 0x2D7A5BC VA: 0x2D7E5BC
	|-Enumerable.WhereSelectArrayIterator<object, short>.Where
	|
	|-RVA: 0x2D7E7B0 Offset: 0x2D7A7B0 VA: 0x2D7E7B0
	|-Enumerable.WhereSelectArrayIterator<object, int>.Where
	|
	|-RVA: 0x2D7E9A4 Offset: 0x2D7A9A4 VA: 0x2D7E9A4
	|-Enumerable.WhereSelectArrayIterator<object, Int32Enum>.Where
	|
	|-RVA: 0x2D7EB98 Offset: 0x2D7AB98 VA: 0x2D7EB98
	|-Enumerable.WhereSelectArrayIterator<object, long>.Where
	|
	|-RVA: 0x2D7ED98 Offset: 0x2D7AD98 VA: 0x2D7ED98
	|-Enumerable.WhereSelectArrayIterator<object, object>.Where
	|
	|-RVA: 0x2D7EF8C Offset: 0x2D7AF8C VA: 0x2D7EF8C
	|-Enumerable.WhereSelectArrayIterator<object, float>.Where
	|
	|-RVA: 0x2D7F180 Offset: 0x2D7B180 VA: 0x2D7F180
	|-Enumerable.WhereSelectArrayIterator<object, TimeSpan>.Where
	|
	|-RVA: 0x2D7F378 Offset: 0x2D7B378 VA: 0x2D7F378
	|-Enumerable.WhereSelectArrayIterator<object, Vector3>.Where
	|
	|-RVA: 0x2D7F56C Offset: 0x2D7B56C VA: 0x2D7F56C
	|-Enumerable.WhereSelectArrayIterator<float, int>.Where
	|
	|-RVA: 0x2D7F760 Offset: 0x2D7B760 VA: 0x2D7F760
	|-Enumerable.WhereSelectArrayIterator<TimeSpan, long>.Where
	|
	|-RVA: 0x2D7F954 Offset: 0x2D7B954 VA: 0x2D7F954
	|-Enumerable.WhereSelectArrayIterator<TimeSpan, TimeSpan>.Where
	|
	|-RVA: 0x2D7FB70 Offset: 0x2D7BB70 VA: 0x2D7FB70
	|-Enumerable.WhereSelectArrayIterator<Vector3, int>.Where
	|
	|-RVA: 0x2D7FD8C Offset: 0x2D7BD8C VA: 0x2D7FD8C
	|-Enumerable.WhereSelectArrayIterator<Vector3, float>.Where
	|
	|-RVA: 0x2D80298 Offset: 0x2D7C298 VA: 0x2D80298
	|-Enumerable.WhereSelectArrayIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Where
	*/
}
