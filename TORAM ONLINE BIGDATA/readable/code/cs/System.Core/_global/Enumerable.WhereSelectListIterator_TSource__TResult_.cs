// Assembly: System.Core.dll
// Namespace: 
private class Enumerable.WhereSelectListIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 15189
{
	// Fields
	private List<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private List.Enumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D92098 Offset: 0x2D8E098 VA: 0x2D92098
	|-Enumerable.WhereSelectListIterator<KeyValuePair<byte, object>, byte>..ctor
	|
	|-RVA: 0x2D922DC Offset: 0x2D8E2DC VA: 0x2D922DC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<byte, object>, int>..ctor
	|
	|-RVA: 0x2D92520 Offset: 0x2D8E520 VA: 0x2D92520
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, bool>..ctor
	|
	|-RVA: 0x2D92768 Offset: 0x2D8E768 VA: 0x2D92768
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, byte>..ctor
	|
	|-RVA: 0x2D929AC Offset: 0x2D8E9AC VA: 0x2D929AC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, short>..ctor
	|
	|-RVA: 0x2D92BF0 Offset: 0x2D8EBF0 VA: 0x2D92BF0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, int>..ctor
	|
	|-RVA: 0x2D92E34 Offset: 0x2D8EE34 VA: 0x2D92E34
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, Int32Enum>..ctor
	|
	|-RVA: 0x2D93078 Offset: 0x2D8F078 VA: 0x2D93078
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, long>..ctor
	|
	|-RVA: 0x2D932BC Offset: 0x2D8F2BC VA: 0x2D932BC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>..ctor
	|
	|-RVA: 0x2D9350C Offset: 0x2D8F50C VA: 0x2D9350C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, float>..ctor
	|
	|-RVA: 0x2D93750 Offset: 0x2D8F750 VA: 0x2D93750
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, Vector3>..ctor
	|
	|-RVA: 0x2D93994 Offset: 0x2D8F994 VA: 0x2D93994
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, EnhanceProperties2>, int>..ctor
	|
	|-RVA: 0x2D93C24 Offset: 0x2D8FC24 VA: 0x2D93C24
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, bool>..ctor
	|
	|-RVA: 0x2D93E6C Offset: 0x2D8FE6C VA: 0x2D93E6C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, byte>..ctor
	|
	|-RVA: 0x2D940B0 Offset: 0x2D900B0 VA: 0x2D940B0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, short>..ctor
	|
	|-RVA: 0x2D942F4 Offset: 0x2D902F4 VA: 0x2D942F4
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, int>..ctor
	|
	|-RVA: 0x2D94538 Offset: 0x2D90538 VA: 0x2D94538
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, Int32Enum>..ctor
	|
	|-RVA: 0x2D9477C Offset: 0x2D9077C VA: 0x2D9477C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, long>..ctor
	|
	|-RVA: 0x2D949C0 Offset: 0x2D909C0 VA: 0x2D949C0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, object>..ctor
	|
	|-RVA: 0x2D94C10 Offset: 0x2D90C10 VA: 0x2D94C10
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, float>..ctor
	|
	|-RVA: 0x2D94E54 Offset: 0x2D90E54 VA: 0x2D94E54
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, Vector3>..ctor
	|
	|-RVA: 0x2D9509C Offset: 0x2D9109C VA: 0x2D9509C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, object>, int>..ctor
	|
	|-RVA: 0x2D952E0 Offset: 0x2D912E0 VA: 0x2D952E0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, object>, Int32Enum>..ctor
	|
	|-RVA: 0x2D95524 Offset: 0x2D91524 VA: 0x2D95524
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, bool>..ctor
	|
	|-RVA: 0x2D9576C Offset: 0x2D9176C VA: 0x2D9576C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, byte>..ctor
	|
	|-RVA: 0x2D959B0 Offset: 0x2D919B0 VA: 0x2D959B0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, short>..ctor
	|
	|-RVA: 0x2D95BF4 Offset: 0x2D91BF4 VA: 0x2D95BF4
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, int>..ctor
	|
	|-RVA: 0x2D95E38 Offset: 0x2D91E38 VA: 0x2D95E38
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, Int32Enum>..ctor
	|
	|-RVA: 0x2D9607C Offset: 0x2D9207C VA: 0x2D9607C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, long>..ctor
	|
	|-RVA: 0x2D962C0 Offset: 0x2D922C0 VA: 0x2D962C0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, object>..ctor
	|
	|-RVA: 0x2D96510 Offset: 0x2D92510 VA: 0x2D96510
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, float>..ctor
	|
	|-RVA: 0x2D96754 Offset: 0x2D92754 VA: 0x2D96754
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, Vector3>..ctor
	|
	|-RVA: 0x2D96998 Offset: 0x2D92998 VA: 0x2D96998
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, bool>..ctor
	|
	|-RVA: 0x2D96BE0 Offset: 0x2D92BE0 VA: 0x2D96BE0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, byte>..ctor
	|
	|-RVA: 0x2D96E24 Offset: 0x2D92E24 VA: 0x2D96E24
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, short>..ctor
	|
	|-RVA: 0x2D97068 Offset: 0x2D93068 VA: 0x2D97068
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, int>..ctor
	|
	|-RVA: 0x2D972AC Offset: 0x2D932AC VA: 0x2D972AC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, Int32Enum>..ctor
	|
	|-RVA: 0x2D974F0 Offset: 0x2D934F0 VA: 0x2D974F0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, long>..ctor
	|
	|-RVA: 0x2D97734 Offset: 0x2D93734 VA: 0x2D97734
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, object>..ctor
	|
	|-RVA: 0x2D97984 Offset: 0x2D93984 VA: 0x2D97984
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, float>..ctor
	|
	|-RVA: 0x2D97BC8 Offset: 0x2D93BC8 VA: 0x2D97BC8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, Vector3>..ctor
	|
	|-RVA: 0x2D97E0C Offset: 0x2D93E0C VA: 0x2D97E0C
	|-Enumerable.WhereSelectListIterator<Nullable<UIMobPropertyLabel.IconValue>, int>..ctor
	|
	|-RVA: 0x2D98074 Offset: 0x2D94074 VA: 0x2D98074
	|-Enumerable.WhereSelectListIterator<byte, int>..ctor
	|
	|-RVA: 0x2D982B8 Offset: 0x2D942B8 VA: 0x2D982B8
	|-Enumerable.WhereSelectListIterator<int, int>..ctor
	|
	|-RVA: 0x2D984FC Offset: 0x2D944FC VA: 0x2D984FC
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>..ctor
	|
	|-RVA: 0x2D98740 Offset: 0x2D94740 VA: 0x2D98740
	|-Enumerable.WhereSelectListIterator<long, long>..ctor
	|
	|-RVA: 0x2D98984 Offset: 0x2D94984 VA: 0x2D98984
	|-Enumerable.WhereSelectListIterator<long, TimeSpan>..ctor
	|
	|-RVA: 0x2D98BC8 Offset: 0x2D94BC8 VA: 0x2D98BC8
	|-Enumerable.WhereSelectListIterator<MobActionTargetData, float>..ctor
	|
	|-RVA: 0x2D98E50 Offset: 0x2D94E50 VA: 0x2D98E50
	|-Enumerable.WhereSelectListIterator<MobActionTargetData, Vector3>..ctor
	|
	|-RVA: 0x2D990D8 Offset: 0x2D950D8 VA: 0x2D990D8
	|-Enumerable.WhereSelectListIterator<object, bool>..ctor
	|
	|-RVA: 0x2D99320 Offset: 0x2D95320 VA: 0x2D99320
	|-Enumerable.WhereSelectListIterator<object, byte>..ctor
	|
	|-RVA: 0x2D99564 Offset: 0x2D95564 VA: 0x2D99564
	|-Enumerable.WhereSelectListIterator<object, short>..ctor
	|
	|-RVA: 0x2D997A8 Offset: 0x2D957A8 VA: 0x2D997A8
	|-Enumerable.WhereSelectListIterator<object, int>..ctor
	|
	|-RVA: 0x2D999EC Offset: 0x2D959EC VA: 0x2D999EC
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>..ctor
	|
	|-RVA: 0x2D99C30 Offset: 0x2D95C30 VA: 0x2D99C30
	|-Enumerable.WhereSelectListIterator<object, long>..ctor
	|
	|-RVA: 0x2D99E74 Offset: 0x2D95E74 VA: 0x2D99E74
	|-Enumerable.WhereSelectListIterator<object, object>..ctor
	|
	|-RVA: 0x2D9A0C4 Offset: 0x2D960C4 VA: 0x2D9A0C4
	|-Enumerable.WhereSelectListIterator<object, float>..ctor
	|
	|-RVA: 0x2D9A308 Offset: 0x2D96308 VA: 0x2D9A308
	|-Enumerable.WhereSelectListIterator<object, TimeSpan>..ctor
	|
	|-RVA: 0x2D9A54C Offset: 0x2D9654C VA: 0x2D9A54C
	|-Enumerable.WhereSelectListIterator<object, Vector3>..ctor
	|
	|-RVA: 0x2D9A794 Offset: 0x2D96794 VA: 0x2D9A794
	|-Enumerable.WhereSelectListIterator<float, int>..ctor
	|
	|-RVA: 0x2D9A9D8 Offset: 0x2D969D8 VA: 0x2D9A9D8
	|-Enumerable.WhereSelectListIterator<TimeSpan, long>..ctor
	|
	|-RVA: 0x2D9AC1C Offset: 0x2D96C1C VA: 0x2D9AC1C
	|-Enumerable.WhereSelectListIterator<TimeSpan, TimeSpan>..ctor
	|
	|-RVA: 0x2D9AE60 Offset: 0x2D96E60 VA: 0x2D9AE60
	|-Enumerable.WhereSelectListIterator<Vector3, int>..ctor
	|
	|-RVA: 0x2D9B0B8 Offset: 0x2D970B8 VA: 0x2D9B0B8
	|-Enumerable.WhereSelectListIterator<Vector3, float>..ctor
	|
	|-RVA: 0x2D9B310 Offset: 0x2D97310 VA: 0x2D9B310
	|-Enumerable.WhereSelectListIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D92100 Offset: 0x2D8E100 VA: 0x2D92100
	|-Enumerable.WhereSelectListIterator<KeyValuePair<byte, object>, byte>.Clone
	|
	|-RVA: 0x2D92344 Offset: 0x2D8E344 VA: 0x2D92344
	|-Enumerable.WhereSelectListIterator<KeyValuePair<byte, object>, int>.Clone
	|
	|-RVA: 0x2D92588 Offset: 0x2D8E588 VA: 0x2D92588
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, bool>.Clone
	|
	|-RVA: 0x2D927D0 Offset: 0x2D8E7D0 VA: 0x2D927D0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, byte>.Clone
	|
	|-RVA: 0x2D92A14 Offset: 0x2D8EA14 VA: 0x2D92A14
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, short>.Clone
	|
	|-RVA: 0x2D92C58 Offset: 0x2D8EC58 VA: 0x2D92C58
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, int>.Clone
	|
	|-RVA: 0x2D92E9C Offset: 0x2D8EE9C VA: 0x2D92E9C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, Int32Enum>.Clone
	|
	|-RVA: 0x2D930E0 Offset: 0x2D8F0E0 VA: 0x2D930E0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, long>.Clone
	|
	|-RVA: 0x2D93324 Offset: 0x2D8F324 VA: 0x2D93324
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>.Clone
	|
	|-RVA: 0x2D93574 Offset: 0x2D8F574 VA: 0x2D93574
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, float>.Clone
	|
	|-RVA: 0x2D937B8 Offset: 0x2D8F7B8 VA: 0x2D937B8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, Vector3>.Clone
	|
	|-RVA: 0x2D939FC Offset: 0x2D8F9FC VA: 0x2D939FC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, EnhanceProperties2>, int>.Clone
	|
	|-RVA: 0x2D93C8C Offset: 0x2D8FC8C VA: 0x2D93C8C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, bool>.Clone
	|
	|-RVA: 0x2D93ED4 Offset: 0x2D8FED4 VA: 0x2D93ED4
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, byte>.Clone
	|
	|-RVA: 0x2D94118 Offset: 0x2D90118 VA: 0x2D94118
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, short>.Clone
	|
	|-RVA: 0x2D9435C Offset: 0x2D9035C VA: 0x2D9435C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, int>.Clone
	|
	|-RVA: 0x2D945A0 Offset: 0x2D905A0 VA: 0x2D945A0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, Int32Enum>.Clone
	|
	|-RVA: 0x2D947E4 Offset: 0x2D907E4 VA: 0x2D947E4
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, long>.Clone
	|
	|-RVA: 0x2D94A28 Offset: 0x2D90A28 VA: 0x2D94A28
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, object>.Clone
	|
	|-RVA: 0x2D94C78 Offset: 0x2D90C78 VA: 0x2D94C78
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, float>.Clone
	|
	|-RVA: 0x2D94EBC Offset: 0x2D90EBC VA: 0x2D94EBC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, Vector3>.Clone
	|
	|-RVA: 0x2D95104 Offset: 0x2D91104 VA: 0x2D95104
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, object>, int>.Clone
	|
	|-RVA: 0x2D95348 Offset: 0x2D91348 VA: 0x2D95348
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, object>, Int32Enum>.Clone
	|
	|-RVA: 0x2D9558C Offset: 0x2D9158C VA: 0x2D9558C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, bool>.Clone
	|
	|-RVA: 0x2D957D4 Offset: 0x2D917D4 VA: 0x2D957D4
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, byte>.Clone
	|
	|-RVA: 0x2D95A18 Offset: 0x2D91A18 VA: 0x2D95A18
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, short>.Clone
	|
	|-RVA: 0x2D95C5C Offset: 0x2D91C5C VA: 0x2D95C5C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, int>.Clone
	|
	|-RVA: 0x2D95EA0 Offset: 0x2D91EA0 VA: 0x2D95EA0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, Int32Enum>.Clone
	|
	|-RVA: 0x2D960E4 Offset: 0x2D920E4 VA: 0x2D960E4
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, long>.Clone
	|
	|-RVA: 0x2D96328 Offset: 0x2D92328 VA: 0x2D96328
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, object>.Clone
	|
	|-RVA: 0x2D96578 Offset: 0x2D92578 VA: 0x2D96578
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, float>.Clone
	|
	|-RVA: 0x2D967BC Offset: 0x2D927BC VA: 0x2D967BC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, Vector3>.Clone
	|
	|-RVA: 0x2D96A00 Offset: 0x2D92A00 VA: 0x2D96A00
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, bool>.Clone
	|
	|-RVA: 0x2D96C48 Offset: 0x2D92C48 VA: 0x2D96C48
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, byte>.Clone
	|
	|-RVA: 0x2D96E8C Offset: 0x2D92E8C VA: 0x2D96E8C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, short>.Clone
	|
	|-RVA: 0x2D970D0 Offset: 0x2D930D0 VA: 0x2D970D0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, int>.Clone
	|
	|-RVA: 0x2D97314 Offset: 0x2D93314 VA: 0x2D97314
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, Int32Enum>.Clone
	|
	|-RVA: 0x2D97558 Offset: 0x2D93558 VA: 0x2D97558
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, long>.Clone
	|
	|-RVA: 0x2D9779C Offset: 0x2D9379C VA: 0x2D9779C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, object>.Clone
	|
	|-RVA: 0x2D979EC Offset: 0x2D939EC VA: 0x2D979EC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, float>.Clone
	|
	|-RVA: 0x2D97C30 Offset: 0x2D93C30 VA: 0x2D97C30
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, Vector3>.Clone
	|
	|-RVA: 0x2D97E74 Offset: 0x2D93E74 VA: 0x2D97E74
	|-Enumerable.WhereSelectListIterator<Nullable<UIMobPropertyLabel.IconValue>, int>.Clone
	|
	|-RVA: 0x2D980DC Offset: 0x2D940DC VA: 0x2D980DC
	|-Enumerable.WhereSelectListIterator<byte, int>.Clone
	|
	|-RVA: 0x2D98320 Offset: 0x2D94320 VA: 0x2D98320
	|-Enumerable.WhereSelectListIterator<int, int>.Clone
	|
	|-RVA: 0x2D98564 Offset: 0x2D94564 VA: 0x2D98564
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.Clone
	|
	|-RVA: 0x2D987A8 Offset: 0x2D947A8 VA: 0x2D987A8
	|-Enumerable.WhereSelectListIterator<long, long>.Clone
	|
	|-RVA: 0x2D989EC Offset: 0x2D949EC VA: 0x2D989EC
	|-Enumerable.WhereSelectListIterator<long, TimeSpan>.Clone
	|
	|-RVA: 0x2D98C30 Offset: 0x2D94C30 VA: 0x2D98C30
	|-Enumerable.WhereSelectListIterator<MobActionTargetData, float>.Clone
	|
	|-RVA: 0x2D98EB8 Offset: 0x2D94EB8 VA: 0x2D98EB8
	|-Enumerable.WhereSelectListIterator<MobActionTargetData, Vector3>.Clone
	|
	|-RVA: 0x2D99140 Offset: 0x2D95140 VA: 0x2D99140
	|-Enumerable.WhereSelectListIterator<object, bool>.Clone
	|
	|-RVA: 0x2D99388 Offset: 0x2D95388 VA: 0x2D99388
	|-Enumerable.WhereSelectListIterator<object, byte>.Clone
	|
	|-RVA: 0x2D995CC Offset: 0x2D955CC VA: 0x2D995CC
	|-Enumerable.WhereSelectListIterator<object, short>.Clone
	|
	|-RVA: 0x2D99810 Offset: 0x2D95810 VA: 0x2D99810
	|-Enumerable.WhereSelectListIterator<object, int>.Clone
	|
	|-RVA: 0x2D99A54 Offset: 0x2D95A54 VA: 0x2D99A54
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.Clone
	|
	|-RVA: 0x2D99C98 Offset: 0x2D95C98 VA: 0x2D99C98
	|-Enumerable.WhereSelectListIterator<object, long>.Clone
	|
	|-RVA: 0x2D99EDC Offset: 0x2D95EDC VA: 0x2D99EDC
	|-Enumerable.WhereSelectListIterator<object, object>.Clone
	|
	|-RVA: 0x2D9A12C Offset: 0x2D9612C VA: 0x2D9A12C
	|-Enumerable.WhereSelectListIterator<object, float>.Clone
	|
	|-RVA: 0x2D9A370 Offset: 0x2D96370 VA: 0x2D9A370
	|-Enumerable.WhereSelectListIterator<object, TimeSpan>.Clone
	|
	|-RVA: 0x2D9A5B4 Offset: 0x2D965B4 VA: 0x2D9A5B4
	|-Enumerable.WhereSelectListIterator<object, Vector3>.Clone
	|
	|-RVA: 0x2D9A7FC Offset: 0x2D967FC VA: 0x2D9A7FC
	|-Enumerable.WhereSelectListIterator<float, int>.Clone
	|
	|-RVA: 0x2D9AA40 Offset: 0x2D96A40 VA: 0x2D9AA40
	|-Enumerable.WhereSelectListIterator<TimeSpan, long>.Clone
	|
	|-RVA: 0x2D9AC84 Offset: 0x2D96C84 VA: 0x2D9AC84
	|-Enumerable.WhereSelectListIterator<TimeSpan, TimeSpan>.Clone
	|
	|-RVA: 0x2D9AEC8 Offset: 0x2D96EC8 VA: 0x2D9AEC8
	|-Enumerable.WhereSelectListIterator<Vector3, int>.Clone
	|
	|-RVA: 0x2D9B120 Offset: 0x2D97120 VA: 0x2D9B120
	|-Enumerable.WhereSelectListIterator<Vector3, float>.Clone
	|
	|-RVA: 0x2D9B3AC Offset: 0x2D973AC VA: 0x2D9B3AC
	|-Enumerable.WhereSelectListIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D9216C Offset: 0x2D8E16C VA: 0x2D9216C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<byte, object>, byte>.MoveNext
	|
	|-RVA: 0x2D923B0 Offset: 0x2D8E3B0 VA: 0x2D923B0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<byte, object>, int>.MoveNext
	|
	|-RVA: 0x2D925F4 Offset: 0x2D8E5F4 VA: 0x2D925F4
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, bool>.MoveNext
	|
	|-RVA: 0x2D9283C Offset: 0x2D8E83C VA: 0x2D9283C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, byte>.MoveNext
	|
	|-RVA: 0x2D92A80 Offset: 0x2D8EA80 VA: 0x2D92A80
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, short>.MoveNext
	|
	|-RVA: 0x2D92CC4 Offset: 0x2D8ECC4 VA: 0x2D92CC4
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, int>.MoveNext
	|
	|-RVA: 0x2D92F08 Offset: 0x2D8EF08 VA: 0x2D92F08
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D9314C Offset: 0x2D8F14C VA: 0x2D9314C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, long>.MoveNext
	|
	|-RVA: 0x2D93390 Offset: 0x2D8F390 VA: 0x2D93390
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>.MoveNext
	|
	|-RVA: 0x2D935E0 Offset: 0x2D8F5E0 VA: 0x2D935E0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, float>.MoveNext
	|
	|-RVA: 0x2D93824 Offset: 0x2D8F824 VA: 0x2D93824
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, Vector3>.MoveNext
	|
	|-RVA: 0x2D93A68 Offset: 0x2D8FA68 VA: 0x2D93A68
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, EnhanceProperties2>, int>.MoveNext
	|
	|-RVA: 0x2D93CF8 Offset: 0x2D8FCF8 VA: 0x2D93CF8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, bool>.MoveNext
	|
	|-RVA: 0x2D93F40 Offset: 0x2D8FF40 VA: 0x2D93F40
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, byte>.MoveNext
	|
	|-RVA: 0x2D94184 Offset: 0x2D90184 VA: 0x2D94184
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, short>.MoveNext
	|
	|-RVA: 0x2D943C8 Offset: 0x2D903C8 VA: 0x2D943C8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, int>.MoveNext
	|
	|-RVA: 0x2D9460C Offset: 0x2D9060C VA: 0x2D9460C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D94850 Offset: 0x2D90850 VA: 0x2D94850
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, long>.MoveNext
	|
	|-RVA: 0x2D94A94 Offset: 0x2D90A94 VA: 0x2D94A94
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, object>.MoveNext
	|
	|-RVA: 0x2D94CE4 Offset: 0x2D90CE4 VA: 0x2D94CE4
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, float>.MoveNext
	|
	|-RVA: 0x2D94F28 Offset: 0x2D90F28 VA: 0x2D94F28
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, Vector3>.MoveNext
	|
	|-RVA: 0x2D95170 Offset: 0x2D91170 VA: 0x2D95170
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, object>, int>.MoveNext
	|
	|-RVA: 0x2D953B4 Offset: 0x2D913B4 VA: 0x2D953B4
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D955F8 Offset: 0x2D915F8 VA: 0x2D955F8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, bool>.MoveNext
	|
	|-RVA: 0x2D95840 Offset: 0x2D91840 VA: 0x2D95840
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, byte>.MoveNext
	|
	|-RVA: 0x2D95A84 Offset: 0x2D91A84 VA: 0x2D95A84
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, short>.MoveNext
	|
	|-RVA: 0x2D95CC8 Offset: 0x2D91CC8 VA: 0x2D95CC8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, int>.MoveNext
	|
	|-RVA: 0x2D95F0C Offset: 0x2D91F0C VA: 0x2D95F0C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D96150 Offset: 0x2D92150 VA: 0x2D96150
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, long>.MoveNext
	|
	|-RVA: 0x2D96394 Offset: 0x2D92394 VA: 0x2D96394
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, object>.MoveNext
	|
	|-RVA: 0x2D965E4 Offset: 0x2D925E4 VA: 0x2D965E4
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, float>.MoveNext
	|
	|-RVA: 0x2D96828 Offset: 0x2D92828 VA: 0x2D96828
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, Vector3>.MoveNext
	|
	|-RVA: 0x2D96A6C Offset: 0x2D92A6C VA: 0x2D96A6C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, bool>.MoveNext
	|
	|-RVA: 0x2D96CB4 Offset: 0x2D92CB4 VA: 0x2D96CB4
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, byte>.MoveNext
	|
	|-RVA: 0x2D96EF8 Offset: 0x2D92EF8 VA: 0x2D96EF8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, short>.MoveNext
	|
	|-RVA: 0x2D9713C Offset: 0x2D9313C VA: 0x2D9713C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, int>.MoveNext
	|
	|-RVA: 0x2D97380 Offset: 0x2D93380 VA: 0x2D97380
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D975C4 Offset: 0x2D935C4 VA: 0x2D975C4
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, long>.MoveNext
	|
	|-RVA: 0x2D97808 Offset: 0x2D93808 VA: 0x2D97808
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, object>.MoveNext
	|
	|-RVA: 0x2D97A58 Offset: 0x2D93A58 VA: 0x2D97A58
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, float>.MoveNext
	|
	|-RVA: 0x2D97C9C Offset: 0x2D93C9C VA: 0x2D97C9C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, Vector3>.MoveNext
	|
	|-RVA: 0x2D97EE0 Offset: 0x2D93EE0 VA: 0x2D97EE0
	|-Enumerable.WhereSelectListIterator<Nullable<UIMobPropertyLabel.IconValue>, int>.MoveNext
	|
	|-RVA: 0x2D98148 Offset: 0x2D94148 VA: 0x2D98148
	|-Enumerable.WhereSelectListIterator<byte, int>.MoveNext
	|
	|-RVA: 0x2D9838C Offset: 0x2D9438C VA: 0x2D9838C
	|-Enumerable.WhereSelectListIterator<int, int>.MoveNext
	|
	|-RVA: 0x2D985D0 Offset: 0x2D945D0 VA: 0x2D985D0
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x2D98814 Offset: 0x2D94814 VA: 0x2D98814
	|-Enumerable.WhereSelectListIterator<long, long>.MoveNext
	|
	|-RVA: 0x2D98A58 Offset: 0x2D94A58 VA: 0x2D98A58
	|-Enumerable.WhereSelectListIterator<long, TimeSpan>.MoveNext
	|
	|-RVA: 0x2D98C9C Offset: 0x2D94C9C VA: 0x2D98C9C
	|-Enumerable.WhereSelectListIterator<MobActionTargetData, float>.MoveNext
	|
	|-RVA: 0x2D98F24 Offset: 0x2D94F24 VA: 0x2D98F24
	|-Enumerable.WhereSelectListIterator<MobActionTargetData, Vector3>.MoveNext
	|
	|-RVA: 0x2D991AC Offset: 0x2D951AC VA: 0x2D991AC
	|-Enumerable.WhereSelectListIterator<object, bool>.MoveNext
	|
	|-RVA: 0x2D993F4 Offset: 0x2D953F4 VA: 0x2D993F4
	|-Enumerable.WhereSelectListIterator<object, byte>.MoveNext
	|
	|-RVA: 0x2D99638 Offset: 0x2D95638 VA: 0x2D99638
	|-Enumerable.WhereSelectListIterator<object, short>.MoveNext
	|
	|-RVA: 0x2D9987C Offset: 0x2D9587C VA: 0x2D9987C
	|-Enumerable.WhereSelectListIterator<object, int>.MoveNext
	|
	|-RVA: 0x2D99AC0 Offset: 0x2D95AC0 VA: 0x2D99AC0
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D99D04 Offset: 0x2D95D04 VA: 0x2D99D04
	|-Enumerable.WhereSelectListIterator<object, long>.MoveNext
	|
	|-RVA: 0x2D99F48 Offset: 0x2D95F48 VA: 0x2D99F48
	|-Enumerable.WhereSelectListIterator<object, object>.MoveNext
	|
	|-RVA: 0x2D9A198 Offset: 0x2D96198 VA: 0x2D9A198
	|-Enumerable.WhereSelectListIterator<object, float>.MoveNext
	|
	|-RVA: 0x2D9A3DC Offset: 0x2D963DC VA: 0x2D9A3DC
	|-Enumerable.WhereSelectListIterator<object, TimeSpan>.MoveNext
	|
	|-RVA: 0x2D9A620 Offset: 0x2D96620 VA: 0x2D9A620
	|-Enumerable.WhereSelectListIterator<object, Vector3>.MoveNext
	|
	|-RVA: 0x2D9A868 Offset: 0x2D96868 VA: 0x2D9A868
	|-Enumerable.WhereSelectListIterator<float, int>.MoveNext
	|
	|-RVA: 0x2D9AAAC Offset: 0x2D96AAC VA: 0x2D9AAAC
	|-Enumerable.WhereSelectListIterator<TimeSpan, long>.MoveNext
	|
	|-RVA: 0x2D9ACF0 Offset: 0x2D96CF0 VA: 0x2D9ACF0
	|-Enumerable.WhereSelectListIterator<TimeSpan, TimeSpan>.MoveNext
	|
	|-RVA: 0x2D9AF34 Offset: 0x2D96F34 VA: 0x2D9AF34
	|-Enumerable.WhereSelectListIterator<Vector3, int>.MoveNext
	|
	|-RVA: 0x2D9B18C Offset: 0x2D9718C VA: 0x2D9B18C
	|-Enumerable.WhereSelectListIterator<Vector3, float>.MoveNext
	|
	|-RVA: 0x2D9B470 Offset: 0x2D97470 VA: 0x2D9B470
	|-Enumerable.WhereSelectListIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2685DB8 Offset: 0x2681DB8 VA: 0x2685DB8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<byte, object>, byte>.Select<int>
	|
	|-RVA: 0x2685E50 Offset: 0x2681E50 VA: 0x2685E50
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, int>.Select<int>
	|
	|-RVA: 0x2685EE8 Offset: 0x2681EE8 VA: 0x2685EE8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>.Select<bool>
	|
	|-RVA: 0x2685F80 Offset: 0x2681F80 VA: 0x2685F80
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>.Select<byte>
	|
	|-RVA: 0x2686018 Offset: 0x2682018 VA: 0x2686018
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>.Select<short>
	|
	|-RVA: 0x26860B0 Offset: 0x26820B0 VA: 0x26860B0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>.Select<int>
	|
	|-RVA: 0x2686148 Offset: 0x2682148 VA: 0x2686148
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>.Select<Int32Enum>
	|
	|-RVA: 0x26861E0 Offset: 0x26821E0 VA: 0x26861E0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>.Select<long>
	|
	|-RVA: 0x2686278 Offset: 0x2682278 VA: 0x2686278
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>.Select<object>
	|
	|-RVA: 0x2686310 Offset: 0x2682310 VA: 0x2686310
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>.Select<float>
	|
	|-RVA: 0x26863A8 Offset: 0x26823A8 VA: 0x26863A8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>.Select<Vector3>
	|
	|-RVA: 0x2686440 Offset: 0x2682440 VA: 0x2686440
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, EnhanceProperties2>, int>.Select<int>
	|
	|-RVA: 0x26864D8 Offset: 0x26824D8 VA: 0x26864D8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, int>.Select<int>
	|
	|-RVA: 0x2686570 Offset: 0x2682570 VA: 0x2686570
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, Int32Enum>.Select<int>
	|
	|-RVA: 0x2686608 Offset: 0x2682608 VA: 0x2686608
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, object>.Select<bool>
	|
	|-RVA: 0x26866A0 Offset: 0x26826A0 VA: 0x26866A0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, object>.Select<byte>
	|
	|-RVA: 0x2686738 Offset: 0x2682738 VA: 0x2686738
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, object>.Select<short>
	|
	|-RVA: 0x26867D0 Offset: 0x26827D0 VA: 0x26867D0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, object>.Select<int>
	|
	|-RVA: 0x2686868 Offset: 0x2682868 VA: 0x2686868
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, object>.Select<Int32Enum>
	|
	|-RVA: 0x2686900 Offset: 0x2682900 VA: 0x2686900
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, object>.Select<long>
	|
	|-RVA: 0x2686998 Offset: 0x2682998 VA: 0x2686998
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, object>.Select<object>
	|
	|-RVA: 0x2686A30 Offset: 0x2682A30 VA: 0x2686A30
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, object>.Select<float>
	|
	|-RVA: 0x2686AC8 Offset: 0x2682AC8 VA: 0x2686AC8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, object>.Select<Vector3>
	|
	|-RVA: 0x2686B60 Offset: 0x2682B60 VA: 0x2686B60
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, object>, Int32Enum>.Select<int>
	|
	|-RVA: 0x2686BF8 Offset: 0x2682BF8 VA: 0x2686BF8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, object>.Select<bool>
	|
	|-RVA: 0x2686C90 Offset: 0x2682C90 VA: 0x2686C90
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, object>.Select<byte>
	|
	|-RVA: 0x2686D28 Offset: 0x2682D28 VA: 0x2686D28
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, object>.Select<short>
	|
	|-RVA: 0x2686DC0 Offset: 0x2682DC0 VA: 0x2686DC0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, object>.Select<int>
	|
	|-RVA: 0x2686E58 Offset: 0x2682E58 VA: 0x2686E58
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, object>.Select<Int32Enum>
	|
	|-RVA: 0x2686EF0 Offset: 0x2682EF0 VA: 0x2686EF0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, object>.Select<long>
	|
	|-RVA: 0x2686F88 Offset: 0x2682F88 VA: 0x2686F88
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, object>.Select<object>
	|
	|-RVA: 0x2687020 Offset: 0x2683020 VA: 0x2687020
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, object>.Select<float>
	|
	|-RVA: 0x26870B8 Offset: 0x26830B8 VA: 0x26870B8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, object>.Select<Vector3>
	|
	|-RVA: 0x2687150 Offset: 0x2683150 VA: 0x2687150
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, object>.Select<bool>
	|
	|-RVA: 0x26871E8 Offset: 0x26831E8 VA: 0x26871E8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, object>.Select<byte>
	|
	|-RVA: 0x2687280 Offset: 0x2683280 VA: 0x2687280
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, object>.Select<short>
	|
	|-RVA: 0x2687318 Offset: 0x2683318 VA: 0x2687318
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, object>.Select<int>
	|
	|-RVA: 0x26873B0 Offset: 0x26833B0 VA: 0x26873B0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, object>.Select<Int32Enum>
	|
	|-RVA: 0x2687448 Offset: 0x2683448 VA: 0x2687448
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, object>.Select<long>
	|
	|-RVA: 0x26874E0 Offset: 0x26834E0 VA: 0x26874E0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, object>.Select<object>
	|
	|-RVA: 0x2687578 Offset: 0x2683578 VA: 0x2687578
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, object>.Select<float>
	|
	|-RVA: 0x2687610 Offset: 0x2683610 VA: 0x2687610
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, object>.Select<Vector3>
	|
	|-RVA: 0x26876A8 Offset: 0x26836A8 VA: 0x26876A8
	|-Enumerable.WhereSelectListIterator<Nullable<UIMobPropertyLabel.IconValue>, int>.Select<int>
	|
	|-RVA: 0x2687740 Offset: 0x2683740 VA: 0x2687740
	|-Enumerable.WhereSelectListIterator<byte, int>.Select<int>
	|
	|-RVA: 0x26877D8 Offset: 0x26837D8 VA: 0x26877D8
	|-Enumerable.WhereSelectListIterator<int, int>.Select<int>
	|
	|-RVA: 0x2687870 Offset: 0x2683870 VA: 0x2687870
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.Select<int>
	|
	|-RVA: 0x2687908 Offset: 0x2683908 VA: 0x2687908
	|-Enumerable.WhereSelectListIterator<long, TimeSpan>.Select<long>
	|
	|-RVA: 0x26879A0 Offset: 0x26839A0 VA: 0x26879A0
	|-Enumerable.WhereSelectListIterator<MobActionTargetData, Vector3>.Select<float>
	|
	|-RVA: 0x2687A38 Offset: 0x2683A38 VA: 0x2687A38
	|-Enumerable.WhereSelectListIterator<object, byte>.Select<int>
	|
	|-RVA: 0x2687AD0 Offset: 0x2683AD0 VA: 0x2687AD0
	|-Enumerable.WhereSelectListIterator<object, int>.Select<int>
	|
	|-RVA: 0x2687B68 Offset: 0x2683B68 VA: 0x2687B68
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.Select<int>
	|
	|-RVA: 0x2687C00 Offset: 0x2683C00 VA: 0x2687C00
	|-Enumerable.WhereSelectListIterator<object, long>.Select<TimeSpan>
	|
	|-RVA: 0x2687C98 Offset: 0x2683C98 VA: 0x2687C98
	|-Enumerable.WhereSelectListIterator<object, object>.Select<bool>
	|
	|-RVA: 0x2687D30 Offset: 0x2683D30 VA: 0x2687D30
	|-Enumerable.WhereSelectListIterator<object, object>.Select<byte>
	|
	|-RVA: 0x2687DC8 Offset: 0x2683DC8 VA: 0x2687DC8
	|-Enumerable.WhereSelectListIterator<object, object>.Select<short>
	|
	|-RVA: 0x2687E60 Offset: 0x2683E60 VA: 0x2687E60
	|-Enumerable.WhereSelectListIterator<object, object>.Select<int>
	|
	|-RVA: 0x2687EF8 Offset: 0x2683EF8 VA: 0x2687EF8
	|-Enumerable.WhereSelectListIterator<object, object>.Select<Int32Enum>
	|
	|-RVA: 0x2687F90 Offset: 0x2683F90 VA: 0x2687F90
	|-Enumerable.WhereSelectListIterator<object, object>.Select<long>
	|
	|-RVA: 0x2688028 Offset: 0x2684028 VA: 0x2688028
	|-Enumerable.WhereSelectListIterator<object, object>.Select<object>
	|
	|-RVA: 0x26880C0 Offset: 0x26840C0 VA: 0x26880C0
	|-Enumerable.WhereSelectListIterator<object, object>.Select<float>
	|
	|-RVA: 0x2688158 Offset: 0x2684158 VA: 0x2688158
	|-Enumerable.WhereSelectListIterator<object, object>.Select<Vector3>
	|
	|-RVA: 0x26881F0 Offset: 0x26841F0 VA: 0x26881F0
	|-Enumerable.WhereSelectListIterator<object, float>.Select<int>
	|
	|-RVA: 0x2688288 Offset: 0x2684288 VA: 0x2688288
	|-Enumerable.WhereSelectListIterator<object, Vector3>.Select<float>
	|
	|-RVA: 0x2688320 Offset: 0x2684320 VA: 0x2688320
	|-Enumerable.WhereSelectListIterator<float, int>.Select<int>
	|
	|-RVA: 0x26883B8 Offset: 0x26843B8 VA: 0x26883B8
	|-Enumerable.WhereSelectListIterator<TimeSpan, long>.Select<TimeSpan>
	|
	|-RVA: 0x2688450 Offset: 0x2684450 VA: 0x2688450
	|-Enumerable.WhereSelectListIterator<Vector3, float>.Select<int>
	|
	|-RVA: 0x26884E8 Offset: 0x26844E8 VA: 0x26884E8
	|-Enumerable.WhereSelectListIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D92274 Offset: 0x2D8E274 VA: 0x2D92274
	|-Enumerable.WhereSelectListIterator<KeyValuePair<byte, object>, byte>.Where
	|
	|-RVA: 0x2D924B8 Offset: 0x2D8E4B8 VA: 0x2D924B8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<byte, object>, int>.Where
	|
	|-RVA: 0x2D92700 Offset: 0x2D8E700 VA: 0x2D92700
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, bool>.Where
	|
	|-RVA: 0x2D92944 Offset: 0x2D8E944 VA: 0x2D92944
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, byte>.Where
	|
	|-RVA: 0x2D92B88 Offset: 0x2D8EB88 VA: 0x2D92B88
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, short>.Where
	|
	|-RVA: 0x2D92DCC Offset: 0x2D8EDCC VA: 0x2D92DCC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, int>.Where
	|
	|-RVA: 0x2D93010 Offset: 0x2D8F010 VA: 0x2D93010
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, Int32Enum>.Where
	|
	|-RVA: 0x2D93254 Offset: 0x2D8F254 VA: 0x2D93254
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, long>.Where
	|
	|-RVA: 0x2D934A4 Offset: 0x2D8F4A4 VA: 0x2D934A4
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>.Where
	|
	|-RVA: 0x2D936E8 Offset: 0x2D8F6E8 VA: 0x2D936E8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, float>.Where
	|
	|-RVA: 0x2D9392C Offset: 0x2D8F92C VA: 0x2D9392C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, Vector3>.Where
	|
	|-RVA: 0x2D93BBC Offset: 0x2D8FBBC VA: 0x2D93BBC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, EnhanceProperties2>, int>.Where
	|
	|-RVA: 0x2D93E04 Offset: 0x2D8FE04 VA: 0x2D93E04
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, bool>.Where
	|
	|-RVA: 0x2D94048 Offset: 0x2D90048 VA: 0x2D94048
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, byte>.Where
	|
	|-RVA: 0x2D9428C Offset: 0x2D9028C VA: 0x2D9428C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, short>.Where
	|
	|-RVA: 0x2D944D0 Offset: 0x2D904D0 VA: 0x2D944D0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, int>.Where
	|
	|-RVA: 0x2D94714 Offset: 0x2D90714 VA: 0x2D94714
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, Int32Enum>.Where
	|
	|-RVA: 0x2D94958 Offset: 0x2D90958 VA: 0x2D94958
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, long>.Where
	|
	|-RVA: 0x2D94BA8 Offset: 0x2D90BA8 VA: 0x2D94BA8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, object>.Where
	|
	|-RVA: 0x2D94DEC Offset: 0x2D90DEC VA: 0x2D94DEC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, float>.Where
	|
	|-RVA: 0x2D95034 Offset: 0x2D91034 VA: 0x2D95034
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, int>, Vector3>.Where
	|
	|-RVA: 0x2D95278 Offset: 0x2D91278 VA: 0x2D95278
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, object>, int>.Where
	|
	|-RVA: 0x2D954BC Offset: 0x2D914BC VA: 0x2D954BC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<Int32Enum, object>, Int32Enum>.Where
	|
	|-RVA: 0x2D95704 Offset: 0x2D91704 VA: 0x2D95704
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, bool>.Where
	|
	|-RVA: 0x2D95948 Offset: 0x2D91948 VA: 0x2D95948
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, byte>.Where
	|
	|-RVA: 0x2D95B8C Offset: 0x2D91B8C VA: 0x2D95B8C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, short>.Where
	|
	|-RVA: 0x2D95DD0 Offset: 0x2D91DD0 VA: 0x2D95DD0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, int>.Where
	|
	|-RVA: 0x2D96014 Offset: 0x2D92014 VA: 0x2D96014
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, Int32Enum>.Where
	|
	|-RVA: 0x2D96258 Offset: 0x2D92258 VA: 0x2D96258
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, long>.Where
	|
	|-RVA: 0x2D964A8 Offset: 0x2D924A8 VA: 0x2D964A8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, object>.Where
	|
	|-RVA: 0x2D966EC Offset: 0x2D926EC VA: 0x2D966EC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, float>.Where
	|
	|-RVA: 0x2D96930 Offset: 0x2D92930 VA: 0x2D96930
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, int>, Vector3>.Where
	|
	|-RVA: 0x2D96B78 Offset: 0x2D92B78 VA: 0x2D96B78
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, bool>.Where
	|
	|-RVA: 0x2D96DBC Offset: 0x2D92DBC VA: 0x2D96DBC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, byte>.Where
	|
	|-RVA: 0x2D97000 Offset: 0x2D93000 VA: 0x2D97000
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, short>.Where
	|
	|-RVA: 0x2D97244 Offset: 0x2D93244 VA: 0x2D97244
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, int>.Where
	|
	|-RVA: 0x2D97488 Offset: 0x2D93488 VA: 0x2D97488
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, Int32Enum>.Where
	|
	|-RVA: 0x2D976CC Offset: 0x2D936CC VA: 0x2D976CC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, long>.Where
	|
	|-RVA: 0x2D9791C Offset: 0x2D9391C VA: 0x2D9791C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, object>.Where
	|
	|-RVA: 0x2D97B60 Offset: 0x2D93B60 VA: 0x2D97B60
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, float>.Where
	|
	|-RVA: 0x2D97DA4 Offset: 0x2D93DA4 VA: 0x2D97DA4
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, float>, Vector3>.Where
	|
	|-RVA: 0x2D9800C Offset: 0x2D9400C VA: 0x2D9800C
	|-Enumerable.WhereSelectListIterator<Nullable<UIMobPropertyLabel.IconValue>, int>.Where
	|
	|-RVA: 0x2D98250 Offset: 0x2D94250 VA: 0x2D98250
	|-Enumerable.WhereSelectListIterator<byte, int>.Where
	|
	|-RVA: 0x2D98494 Offset: 0x2D94494 VA: 0x2D98494
	|-Enumerable.WhereSelectListIterator<int, int>.Where
	|
	|-RVA: 0x2D986D8 Offset: 0x2D946D8 VA: 0x2D986D8
	|-Enumerable.WhereSelectListIterator<Int32Enum, int>.Where
	|
	|-RVA: 0x2D9891C Offset: 0x2D9491C VA: 0x2D9891C
	|-Enumerable.WhereSelectListIterator<long, long>.Where
	|
	|-RVA: 0x2D98B60 Offset: 0x2D94B60 VA: 0x2D98B60
	|-Enumerable.WhereSelectListIterator<long, TimeSpan>.Where
	|
	|-RVA: 0x2D98DE8 Offset: 0x2D94DE8 VA: 0x2D98DE8
	|-Enumerable.WhereSelectListIterator<MobActionTargetData, float>.Where
	|
	|-RVA: 0x2D99070 Offset: 0x2D95070 VA: 0x2D99070
	|-Enumerable.WhereSelectListIterator<MobActionTargetData, Vector3>.Where
	|
	|-RVA: 0x2D992B8 Offset: 0x2D952B8 VA: 0x2D992B8
	|-Enumerable.WhereSelectListIterator<object, bool>.Where
	|
	|-RVA: 0x2D994FC Offset: 0x2D954FC VA: 0x2D994FC
	|-Enumerable.WhereSelectListIterator<object, byte>.Where
	|
	|-RVA: 0x2D99740 Offset: 0x2D95740 VA: 0x2D99740
	|-Enumerable.WhereSelectListIterator<object, short>.Where
	|
	|-RVA: 0x2D99984 Offset: 0x2D95984 VA: 0x2D99984
	|-Enumerable.WhereSelectListIterator<object, int>.Where
	|
	|-RVA: 0x2D99BC8 Offset: 0x2D95BC8 VA: 0x2D99BC8
	|-Enumerable.WhereSelectListIterator<object, Int32Enum>.Where
	|
	|-RVA: 0x2D99E0C Offset: 0x2D95E0C VA: 0x2D99E0C
	|-Enumerable.WhereSelectListIterator<object, long>.Where
	|
	|-RVA: 0x2D9A05C Offset: 0x2D9605C VA: 0x2D9A05C
	|-Enumerable.WhereSelectListIterator<object, object>.Where
	|
	|-RVA: 0x2D9A2A0 Offset: 0x2D962A0 VA: 0x2D9A2A0
	|-Enumerable.WhereSelectListIterator<object, float>.Where
	|
	|-RVA: 0x2D9A4E4 Offset: 0x2D964E4 VA: 0x2D9A4E4
	|-Enumerable.WhereSelectListIterator<object, TimeSpan>.Where
	|
	|-RVA: 0x2D9A72C Offset: 0x2D9672C VA: 0x2D9A72C
	|-Enumerable.WhereSelectListIterator<object, Vector3>.Where
	|
	|-RVA: 0x2D9A970 Offset: 0x2D96970 VA: 0x2D9A970
	|-Enumerable.WhereSelectListIterator<float, int>.Where
	|
	|-RVA: 0x2D9ABB4 Offset: 0x2D96BB4 VA: 0x2D9ABB4
	|-Enumerable.WhereSelectListIterator<TimeSpan, long>.Where
	|
	|-RVA: 0x2D9ADF8 Offset: 0x2D96DF8 VA: 0x2D9ADF8
	|-Enumerable.WhereSelectListIterator<TimeSpan, TimeSpan>.Where
	|
	|-RVA: 0x2D9B050 Offset: 0x2D97050 VA: 0x2D9B050
	|-Enumerable.WhereSelectListIterator<Vector3, int>.Where
	|
	|-RVA: 0x2D9B2A8 Offset: 0x2D972A8 VA: 0x2D9B2A8
	|-Enumerable.WhereSelectListIterator<Vector3, float>.Where
	|
	|-RVA: 0x2D9B7E8 Offset: 0x2D977E8 VA: 0x2D9B7E8
	|-Enumerable.WhereSelectListIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Where
	*/
}
