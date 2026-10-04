// Assembly: System.Core.dll
// Namespace: 
[CompilerGenerated]
private sealed class OrderedEnumerable.<GetEnumerator>d__1<TElement> : IEnumerator<TElement>, IDisposable, IEnumerator // TypeDefIndex: 15216
{
	// Fields
	private int <>1__state; // 0x0
	private TElement <>2__current; // 0x0
	public OrderedEnumerable<TElement> <>4__this; // 0x0
	private Buffer<TElement> <buffer>5__2; // 0x0
	private int[] <map>5__3; // 0x0
	private int <i>5__4; // 0x0

	// Properties
	private TElement System.Collections.Generic.IEnumerator<TElement>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281BFD4 Offset: 0x2817FD4 VA: 0x281BFD4
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<byte, byte>>..ctor
	|
	|-RVA: 0x281C1B8 Offset: 0x28181B8 VA: 0x281C1B8
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x281C3B4 Offset: 0x28183B4 VA: 0x281C3B4
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int16Enum, object>>..ctor
	|
	|-RVA: 0x281C5B0 Offset: 0x28185B0 VA: 0x281C5B0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, short>>..ctor
	|
	|-RVA: 0x281C794 Offset: 0x2818794 VA: 0x281C794
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x281C978 Offset: 0x2818978 VA: 0x281C978
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x281CB74 Offset: 0x2818B74 VA: 0x281CB74
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int32Enum, byte>>..ctor
	|
	|-RVA: 0x281CD58 Offset: 0x2818D58 VA: 0x281CD58
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x281CF54 Offset: 0x2818F54 VA: 0x281CF54
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<long, short>>..ctor
	|
	|-RVA: 0x281D144 Offset: 0x2819144 VA: 0x281D144
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x281D340 Offset: 0x2819340 VA: 0x281D340
	|-OrderedEnumerable.<GetEnumerator>d__1<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x281D524 Offset: 0x2819524 VA: 0x281D524
	|-OrderedEnumerable.<GetEnumerator>d__1<int>..ctor
	|
	|-RVA: 0x281D704 Offset: 0x2819704 VA: 0x281D704
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>..ctor
	|
	|-RVA: 0x281D8E4 Offset: 0x28198E4 VA: 0x281D8E4
	|-OrderedEnumerable.<GetEnumerator>d__1<object>..ctor
	|
	|-RVA: 0x281DAB0 Offset: 0x2819AB0 VA: 0x281DAB0
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x281E010 Offset: 0x281A010 VA: 0x281E010
	|-OrderedEnumerable.<GetEnumerator>d__1<TrophyManager.TrophyData>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281BFFC Offset: 0x2817FFC VA: 0x281BFFC
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<byte, byte>>.System.IDisposable.Dispose
	|
	|-RVA: 0x281C1E0 Offset: 0x28181E0 VA: 0x281C1E0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<byte, object>>.System.IDisposable.Dispose
	|
	|-RVA: 0x281C3DC Offset: 0x28183DC VA: 0x281C3DC
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int16Enum, object>>.System.IDisposable.Dispose
	|
	|-RVA: 0x281C5D8 Offset: 0x28185D8 VA: 0x281C5D8
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, short>>.System.IDisposable.Dispose
	|
	|-RVA: 0x281C7BC Offset: 0x28187BC VA: 0x281C7BC
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, int>>.System.IDisposable.Dispose
	|
	|-RVA: 0x281C9A0 Offset: 0x28189A0 VA: 0x281C9A0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, object>>.System.IDisposable.Dispose
	|
	|-RVA: 0x281CB9C Offset: 0x2818B9C VA: 0x281CB9C
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int32Enum, byte>>.System.IDisposable.Dispose
	|
	|-RVA: 0x281CD80 Offset: 0x2818D80 VA: 0x281CD80
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int32Enum, object>>.System.IDisposable.Dispose
	|
	|-RVA: 0x281CF7C Offset: 0x2818F7C VA: 0x281CF7C
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<long, short>>.System.IDisposable.Dispose
	|
	|-RVA: 0x281D16C Offset: 0x281916C VA: 0x281D16C
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.IDisposable.Dispose
	|
	|-RVA: 0x281D368 Offset: 0x2819368 VA: 0x281D368
	|-OrderedEnumerable.<GetEnumerator>d__1<ValueTuple<int, int>>.System.IDisposable.Dispose
	|
	|-RVA: 0x281D54C Offset: 0x281954C VA: 0x281D54C
	|-OrderedEnumerable.<GetEnumerator>d__1<int>.System.IDisposable.Dispose
	|
	|-RVA: 0x281D72C Offset: 0x281972C VA: 0x281D72C
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.System.IDisposable.Dispose
	|
	|-RVA: 0x281D90C Offset: 0x281990C VA: 0x281D90C
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x281DAF0 Offset: 0x2819AF0 VA: 0x281DAF0
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	|
	|-RVA: 0x281E038 Offset: 0x281A038 VA: 0x281E038
	|-OrderedEnumerable.<GetEnumerator>d__1<TrophyManager.TrophyData>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281C000 Offset: 0x2818000 VA: 0x281C000
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<byte, byte>>.MoveNext
	|
	|-RVA: 0x281C1E4 Offset: 0x28181E4 VA: 0x281C1E4
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<byte, object>>.MoveNext
	|
	|-RVA: 0x281C3E0 Offset: 0x28183E0 VA: 0x281C3E0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int16Enum, object>>.MoveNext
	|
	|-RVA: 0x281C5DC Offset: 0x28185DC VA: 0x281C5DC
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, short>>.MoveNext
	|
	|-RVA: 0x281C7C0 Offset: 0x28187C0 VA: 0x281C7C0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, int>>.MoveNext
	|
	|-RVA: 0x281C9A4 Offset: 0x28189A4 VA: 0x281C9A4
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x281CBA0 Offset: 0x2818BA0 VA: 0x281CBA0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int32Enum, byte>>.MoveNext
	|
	|-RVA: 0x281CD84 Offset: 0x2818D84 VA: 0x281CD84
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int32Enum, object>>.MoveNext
	|
	|-RVA: 0x281CF80 Offset: 0x2818F80 VA: 0x281CF80
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<long, short>>.MoveNext
	|
	|-RVA: 0x281D170 Offset: 0x2819170 VA: 0x281D170
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x281D36C Offset: 0x281936C VA: 0x281D36C
	|-OrderedEnumerable.<GetEnumerator>d__1<ValueTuple<int, int>>.MoveNext
	|
	|-RVA: 0x281D550 Offset: 0x2819550 VA: 0x281D550
	|-OrderedEnumerable.<GetEnumerator>d__1<int>.MoveNext
	|
	|-RVA: 0x281D730 Offset: 0x2819730 VA: 0x281D730
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.MoveNext
	|
	|-RVA: 0x281D910 Offset: 0x2819910 VA: 0x281D910
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.MoveNext
	|
	|-RVA: 0x281DAF4 Offset: 0x2819AF4 VA: 0x281DAF4
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x281E03C Offset: 0x281A03C VA: 0x281E03C
	|-OrderedEnumerable.<GetEnumerator>d__1<TrophyManager.TrophyData>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281C154 Offset: 0x2818154 VA: 0x281C154
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<byte, byte>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x281C344 Offset: 0x2818344 VA: 0x281C344
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<byte, object>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x281C540 Offset: 0x2818540 VA: 0x281C540
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int16Enum, object>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x281C730 Offset: 0x2818730 VA: 0x281C730
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, short>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x281C914 Offset: 0x2818914 VA: 0x281C914
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, int>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x281CB04 Offset: 0x2818B04 VA: 0x281CB04
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, object>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x281CCF4 Offset: 0x2818CF4 VA: 0x281CCF4
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int32Enum, byte>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x281CEE4 Offset: 0x2818EE4 VA: 0x281CEE4
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int32Enum, object>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x281D0D4 Offset: 0x28190D4 VA: 0x281D0D4
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<long, short>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x281D2D0 Offset: 0x28192D0 VA: 0x281D2D0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x281D4C0 Offset: 0x28194C0 VA: 0x281D4C0
	|-OrderedEnumerable.<GetEnumerator>d__1<ValueTuple<int, int>>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x281D6A0 Offset: 0x28196A0 VA: 0x281D6A0
	|-OrderedEnumerable.<GetEnumerator>d__1<int>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x281D880 Offset: 0x2819880 VA: 0x281D880
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x281DA6C Offset: 0x2819A6C VA: 0x281DA6C
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x281DE98 Offset: 0x2819E98 VA: 0x281DE98
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x281E190 Offset: 0x281A190 VA: 0x281E190
	|-OrderedEnumerable.<GetEnumerator>d__1<TrophyManager.TrophyData>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281C15C Offset: 0x281815C VA: 0x281C15C
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<byte, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x281C350 Offset: 0x2818350 VA: 0x281C350
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<byte, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x281C54C Offset: 0x281854C VA: 0x281C54C
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int16Enum, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x281C738 Offset: 0x2818738 VA: 0x281C738
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, short>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x281C91C Offset: 0x281891C VA: 0x281C91C
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x281CB10 Offset: 0x2818B10 VA: 0x281CB10
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x281CCFC Offset: 0x2818CFC VA: 0x281CCFC
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int32Enum, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x281CEF0 Offset: 0x2818EF0 VA: 0x281CEF0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x281D0E0 Offset: 0x28190E0 VA: 0x281D0E0
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<long, short>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x281D2DC Offset: 0x28192DC VA: 0x281D2DC
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x281D4C8 Offset: 0x28194C8 VA: 0x281D4C8
	|-OrderedEnumerable.<GetEnumerator>d__1<ValueTuple<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x281D6A8 Offset: 0x28196A8 VA: 0x281D6A8
	|-OrderedEnumerable.<GetEnumerator>d__1<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x281D888 Offset: 0x2819888 VA: 0x281D888
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x281DA74 Offset: 0x2819A74 VA: 0x281DA74
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x281DF38 Offset: 0x2819F38 VA: 0x281DF38
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x281E198 Offset: 0x281A198 VA: 0x281E198
	|-OrderedEnumerable.<GetEnumerator>d__1<TrophyManager.TrophyData>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281C190 Offset: 0x2818190 VA: 0x281C190
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<byte, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x281C384 Offset: 0x2818384 VA: 0x281C384
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<byte, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x281C580 Offset: 0x2818580 VA: 0x281C580
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int16Enum, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x281C76C Offset: 0x281876C VA: 0x281C76C
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, short>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x281C950 Offset: 0x2818950 VA: 0x281C950
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x281CB44 Offset: 0x2818B44 VA: 0x281CB44
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x281CD30 Offset: 0x2818D30 VA: 0x281CD30
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int32Enum, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x281CF24 Offset: 0x2818F24 VA: 0x281CF24
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x281D114 Offset: 0x2819114 VA: 0x281D114
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<long, short>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x281D310 Offset: 0x2819310 VA: 0x281D310
	|-OrderedEnumerable.<GetEnumerator>d__1<KeyValuePair<object, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x281D4FC Offset: 0x28194FC VA: 0x281D4FC
	|-OrderedEnumerable.<GetEnumerator>d__1<ValueTuple<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x281D6DC Offset: 0x28196DC VA: 0x281D6DC
	|-OrderedEnumerable.<GetEnumerator>d__1<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x281D8BC Offset: 0x28198BC VA: 0x281D8BC
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x281DAA8 Offset: 0x2819AA8 VA: 0x281DAA8
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x281DF6C Offset: 0x2819F6C VA: 0x281DF6C
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x281E1CC Offset: 0x281A1CC VA: 0x281E1CC
	|-OrderedEnumerable.<GetEnumerator>d__1<TrophyManager.TrophyData>.System.Collections.IEnumerator.get_Current
	*/
}
