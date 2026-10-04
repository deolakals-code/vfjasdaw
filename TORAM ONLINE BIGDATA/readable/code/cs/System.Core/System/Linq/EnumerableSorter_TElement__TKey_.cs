// Assembly: System.Core.dll
// Namespace: System.Linq
internal class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement> // TypeDefIndex: 15220
{
	// Fields
	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0
	internal EnumerableSorter<TElement> next; // 0x0
	internal TKey[] keys; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2965BF8 Offset: 0x2961BF8 VA: 0x2965BF8
	|-EnumerableSorter<KeyValuePair<byte, byte>, byte>..ctor
	|
	|-RVA: 0x2965E94 Offset: 0x2961E94 VA: 0x2965E94
	|-EnumerableSorter<KeyValuePair<byte, object>, byte>..ctor
	|
	|-RVA: 0x2966134 Offset: 0x2962134 VA: 0x2966134
	|-EnumerableSorter<KeyValuePair<Int16Enum, object>, Int16Enum>..ctor
	|
	|-RVA: 0x29663D4 Offset: 0x29623D4 VA: 0x29663D4
	|-EnumerableSorter<KeyValuePair<int, short>, short>..ctor
	|
	|-RVA: 0x2966670 Offset: 0x2962670 VA: 0x2966670
	|-EnumerableSorter<KeyValuePair<int, int>, int>..ctor
	|
	|-RVA: 0x296690C Offset: 0x296290C VA: 0x296690C
	|-EnumerableSorter<KeyValuePair<int, object>, DateTime>..ctor
	|
	|-RVA: 0x2966BAC Offset: 0x2962BAC VA: 0x2966BAC
	|-EnumerableSorter<KeyValuePair<int, object>, int>..ctor
	|
	|-RVA: 0x2966E4C Offset: 0x2962E4C VA: 0x2966E4C
	|-EnumerableSorter<KeyValuePair<Int32Enum, byte>, int>..ctor
	|
	|-RVA: 0x29670E8 Offset: 0x29630E8 VA: 0x29670E8
	|-EnumerableSorter<KeyValuePair<Int32Enum, object>, int>..ctor
	|
	|-RVA: 0x2967388 Offset: 0x2963388 VA: 0x2967388
	|-EnumerableSorter<KeyValuePair<long, short>, short>..ctor
	|
	|-RVA: 0x2967628 Offset: 0x2963628 VA: 0x2967628
	|-EnumerableSorter<KeyValuePair<object, int>, int>..ctor
	|
	|-RVA: 0x29678C8 Offset: 0x29638C8 VA: 0x29678C8
	|-EnumerableSorter<ValueTuple<int, int>, int>..ctor
	|
	|-RVA: 0x2967B64 Offset: 0x2963B64 VA: 0x2967B64
	|-EnumerableSorter<int, int>..ctor
	|
	|-RVA: 0x2967E00 Offset: 0x2963E00 VA: 0x2967E00
	|-EnumerableSorter<Int32Enum, int>..ctor
	|
	|-RVA: 0x296809C Offset: 0x296409C VA: 0x296809C
	|-EnumerableSorter<object, bool>..ctor
	|
	|-RVA: 0x2968344 Offset: 0x2964344 VA: 0x2968344
	|-EnumerableSorter<object, byte>..ctor
	|
	|-RVA: 0x29685E0 Offset: 0x29645E0 VA: 0x29685E0
	|-EnumerableSorter<object, DateTime>..ctor
	|
	|-RVA: 0x296887C Offset: 0x296487C VA: 0x296887C
	|-EnumerableSorter<object, short>..ctor
	|
	|-RVA: 0x2968B18 Offset: 0x2964B18 VA: 0x2968B18
	|-EnumerableSorter<object, int>..ctor
	|
	|-RVA: 0x2968DB4 Offset: 0x2964DB4 VA: 0x2968DB4
	|-EnumerableSorter<object, Int32Enum>..ctor
	|
	|-RVA: 0x2969050 Offset: 0x2965050 VA: 0x2969050
	|-EnumerableSorter<object, long>..ctor
	|
	|-RVA: 0x29692EC Offset: 0x29652EC VA: 0x29692EC
	|-EnumerableSorter<object, object>..ctor
	|
	|-RVA: 0x2969594 Offset: 0x2965594 VA: 0x2969594
	|-EnumerableSorter<object, float>..ctor
	|
	|-RVA: 0x2969830 Offset: 0x2965830 VA: 0x2969830
	|-EnumerableSorter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2969CB8 Offset: 0x2965CB8 VA: 0x2969CB8
	|-EnumerableSorter<TrophyManager.TrophyData, int>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	internal override void ComputeKeys(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2965C60 Offset: 0x2961C60 VA: 0x2965C60
	|-EnumerableSorter<KeyValuePair<byte, byte>, byte>.ComputeKeys
	|
	|-RVA: 0x2965EFC Offset: 0x2961EFC VA: 0x2965EFC
	|-EnumerableSorter<KeyValuePair<byte, object>, byte>.ComputeKeys
	|
	|-RVA: 0x296619C Offset: 0x296219C VA: 0x296619C
	|-EnumerableSorter<KeyValuePair<Int16Enum, object>, Int16Enum>.ComputeKeys
	|
	|-RVA: 0x296643C Offset: 0x296243C VA: 0x296643C
	|-EnumerableSorter<KeyValuePair<int, short>, short>.ComputeKeys
	|
	|-RVA: 0x29666D8 Offset: 0x29626D8 VA: 0x29666D8
	|-EnumerableSorter<KeyValuePair<int, int>, int>.ComputeKeys
	|
	|-RVA: 0x2966974 Offset: 0x2962974 VA: 0x2966974
	|-EnumerableSorter<KeyValuePair<int, object>, DateTime>.ComputeKeys
	|
	|-RVA: 0x2966C14 Offset: 0x2962C14 VA: 0x2966C14
	|-EnumerableSorter<KeyValuePair<int, object>, int>.ComputeKeys
	|
	|-RVA: 0x2966EB4 Offset: 0x2962EB4 VA: 0x2966EB4
	|-EnumerableSorter<KeyValuePair<Int32Enum, byte>, int>.ComputeKeys
	|
	|-RVA: 0x2967150 Offset: 0x2963150 VA: 0x2967150
	|-EnumerableSorter<KeyValuePair<Int32Enum, object>, int>.ComputeKeys
	|
	|-RVA: 0x29673F0 Offset: 0x29633F0 VA: 0x29673F0
	|-EnumerableSorter<KeyValuePair<long, short>, short>.ComputeKeys
	|
	|-RVA: 0x2967690 Offset: 0x2963690 VA: 0x2967690
	|-EnumerableSorter<KeyValuePair<object, int>, int>.ComputeKeys
	|
	|-RVA: 0x2967930 Offset: 0x2963930 VA: 0x2967930
	|-EnumerableSorter<ValueTuple<int, int>, int>.ComputeKeys
	|
	|-RVA: 0x2967BCC Offset: 0x2963BCC VA: 0x2967BCC
	|-EnumerableSorter<int, int>.ComputeKeys
	|
	|-RVA: 0x2967E68 Offset: 0x2963E68 VA: 0x2967E68
	|-EnumerableSorter<Int32Enum, int>.ComputeKeys
	|
	|-RVA: 0x2968104 Offset: 0x2964104 VA: 0x2968104
	|-EnumerableSorter<object, bool>.ComputeKeys
	|
	|-RVA: 0x29683AC Offset: 0x29643AC VA: 0x29683AC
	|-EnumerableSorter<object, byte>.ComputeKeys
	|
	|-RVA: 0x2968648 Offset: 0x2964648 VA: 0x2968648
	|-EnumerableSorter<object, DateTime>.ComputeKeys
	|
	|-RVA: 0x29688E4 Offset: 0x29648E4 VA: 0x29688E4
	|-EnumerableSorter<object, short>.ComputeKeys
	|
	|-RVA: 0x2968B80 Offset: 0x2964B80 VA: 0x2968B80
	|-EnumerableSorter<object, int>.ComputeKeys
	|
	|-RVA: 0x2968E1C Offset: 0x2964E1C VA: 0x2968E1C
	|-EnumerableSorter<object, Int32Enum>.ComputeKeys
	|
	|-RVA: 0x29690B8 Offset: 0x29650B8 VA: 0x29690B8
	|-EnumerableSorter<object, long>.ComputeKeys
	|
	|-RVA: 0x2969354 Offset: 0x2965354 VA: 0x2969354
	|-EnumerableSorter<object, object>.ComputeKeys
	|
	|-RVA: 0x29695FC Offset: 0x29655FC VA: 0x29695FC
	|-EnumerableSorter<object, float>.ComputeKeys
	|
	|-RVA: 0x29698A4 Offset: 0x29658A4 VA: 0x29698A4
	|-EnumerableSorter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ComputeKeys
	|
	|-RVA: 0x2969D20 Offset: 0x2965D20 VA: 0x2969D20
	|-EnumerableSorter<TrophyManager.TrophyData, int>.ComputeKeys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override int CompareKeys(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2965D68 Offset: 0x2961D68 VA: 0x2965D68
	|-EnumerableSorter<KeyValuePair<byte, byte>, byte>.CompareKeys
	|
	|-RVA: 0x2966008 Offset: 0x2962008 VA: 0x2966008
	|-EnumerableSorter<KeyValuePair<byte, object>, byte>.CompareKeys
	|
	|-RVA: 0x29662A8 Offset: 0x29622A8 VA: 0x29662A8
	|-EnumerableSorter<KeyValuePair<Int16Enum, object>, Int16Enum>.CompareKeys
	|
	|-RVA: 0x2966544 Offset: 0x2962544 VA: 0x2966544
	|-EnumerableSorter<KeyValuePair<int, short>, short>.CompareKeys
	|
	|-RVA: 0x29667E0 Offset: 0x29627E0 VA: 0x29667E0
	|-EnumerableSorter<KeyValuePair<int, int>, int>.CompareKeys
	|
	|-RVA: 0x2966A80 Offset: 0x2962A80 VA: 0x2966A80
	|-EnumerableSorter<KeyValuePair<int, object>, DateTime>.CompareKeys
	|
	|-RVA: 0x2966D20 Offset: 0x2962D20 VA: 0x2966D20
	|-EnumerableSorter<KeyValuePair<int, object>, int>.CompareKeys
	|
	|-RVA: 0x2966FBC Offset: 0x2962FBC VA: 0x2966FBC
	|-EnumerableSorter<KeyValuePair<Int32Enum, byte>, int>.CompareKeys
	|
	|-RVA: 0x296725C Offset: 0x296325C VA: 0x296725C
	|-EnumerableSorter<KeyValuePair<Int32Enum, object>, int>.CompareKeys
	|
	|-RVA: 0x29674FC Offset: 0x29634FC VA: 0x29674FC
	|-EnumerableSorter<KeyValuePair<long, short>, short>.CompareKeys
	|
	|-RVA: 0x296779C Offset: 0x296379C VA: 0x296779C
	|-EnumerableSorter<KeyValuePair<object, int>, int>.CompareKeys
	|
	|-RVA: 0x2967A38 Offset: 0x2963A38 VA: 0x2967A38
	|-EnumerableSorter<ValueTuple<int, int>, int>.CompareKeys
	|
	|-RVA: 0x2967CD4 Offset: 0x2963CD4 VA: 0x2967CD4
	|-EnumerableSorter<int, int>.CompareKeys
	|
	|-RVA: 0x2967F70 Offset: 0x2963F70 VA: 0x2967F70
	|-EnumerableSorter<Int32Enum, int>.CompareKeys
	|
	|-RVA: 0x2968210 Offset: 0x2964210 VA: 0x2968210
	|-EnumerableSorter<object, bool>.CompareKeys
	|
	|-RVA: 0x29684B4 Offset: 0x29644B4 VA: 0x29684B4
	|-EnumerableSorter<object, byte>.CompareKeys
	|
	|-RVA: 0x2968750 Offset: 0x2964750 VA: 0x2968750
	|-EnumerableSorter<object, DateTime>.CompareKeys
	|
	|-RVA: 0x29689EC Offset: 0x29649EC VA: 0x29689EC
	|-EnumerableSorter<object, short>.CompareKeys
	|
	|-RVA: 0x2968C88 Offset: 0x2964C88 VA: 0x2968C88
	|-EnumerableSorter<object, int>.CompareKeys
	|
	|-RVA: 0x2968F24 Offset: 0x2964F24 VA: 0x2968F24
	|-EnumerableSorter<object, Int32Enum>.CompareKeys
	|
	|-RVA: 0x29691C0 Offset: 0x29651C0 VA: 0x29691C0
	|-EnumerableSorter<object, long>.CompareKeys
	|
	|-RVA: 0x2969468 Offset: 0x2965468 VA: 0x2969468
	|-EnumerableSorter<object, object>.CompareKeys
	|
	|-RVA: 0x2969704 Offset: 0x2965704 VA: 0x2969704
	|-EnumerableSorter<object, float>.CompareKeys
	|
	|-RVA: 0x2969AB4 Offset: 0x2965AB4 VA: 0x2969AB4
	|-EnumerableSorter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompareKeys
	|
	|-RVA: 0x2969E28 Offset: 0x2965E28 VA: 0x2969E28
	|-EnumerableSorter<TrophyManager.TrophyData, int>.CompareKeys
	*/
}
