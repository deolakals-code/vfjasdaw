// Assembly: System.Core.dll
// Namespace: System.Linq
internal struct Buffer<TElement> // TypeDefIndex: 15221
{
	// Fields
	internal TElement[] items; // 0x0
	internal int count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IEnumerable<TElement> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C69804 Offset: 0x2C65804 VA: 0x2C69804
	|-Buffer<KeyValuePair<byte, byte>>..ctor
	|
	|-RVA: 0x2C69E8C Offset: 0x2C65E8C VA: 0x2C69E8C
	|-Buffer<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x2C6A534 Offset: 0x2C66534 VA: 0x2C6A534
	|-Buffer<KeyValuePair<Int16Enum, object>>..ctor
	|
	|-RVA: 0x2C6ABDC Offset: 0x2C66BDC VA: 0x2C6ABDC
	|-Buffer<KeyValuePair<int, short>>..ctor
	|
	|-RVA: 0x2C6B264 Offset: 0x2C67264 VA: 0x2C6B264
	|-Buffer<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x2C6B8EC Offset: 0x2C678EC VA: 0x2C6B8EC
	|-Buffer<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2C6BF94 Offset: 0x2C67F94 VA: 0x2C6BF94
	|-Buffer<KeyValuePair<Int32Enum, byte>>..ctor
	|
	|-RVA: 0x2C6C61C Offset: 0x2C6861C VA: 0x2C6C61C
	|-Buffer<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x2C6CCC4 Offset: 0x2C68CC4 VA: 0x2C6CCC4
	|-Buffer<KeyValuePair<long, short>>..ctor
	|
	|-RVA: 0x2C6D35C Offset: 0x2C6935C VA: 0x2C6D35C
	|-Buffer<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x2C6DA04 Offset: 0x2C69A04 VA: 0x2C6DA04
	|-Buffer<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2C6E08C Offset: 0x2C6A08C VA: 0x2C6E08C
	|-Buffer<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x2C6E734 Offset: 0x2C6A734 VA: 0x2C6E734
	|-Buffer<bool>..ctor
	|
	|-RVA: 0x2C6EDC0 Offset: 0x2C6ADC0 VA: 0x2C6EDC0
	|-Buffer<byte>..ctor
	|
	|-RVA: 0x2C6F448 Offset: 0x2C6B448 VA: 0x2C6F448
	|-Buffer<char>..ctor
	|
	|-RVA: 0x2C6FAD0 Offset: 0x2C6BAD0 VA: 0x2C6FAD0
	|-Buffer<short>..ctor
	|
	|-RVA: 0x2C70158 Offset: 0x2C6C158 VA: 0x2C70158
	|-Buffer<int>..ctor
	|
	|-RVA: 0x2C707E0 Offset: 0x2C6C7E0 VA: 0x2C707E0
	|-Buffer<Int32Enum>..ctor
	|
	|-RVA: 0x2C70E68 Offset: 0x2C6CE68 VA: 0x2C70E68
	|-Buffer<long>..ctor
	|
	|-RVA: 0x2C714F0 Offset: 0x2C6D4F0 VA: 0x2C714F0
	|-Buffer<object>..ctor
	|
	|-RVA: 0x2C71B84 Offset: 0x2C6DB84 VA: 0x2C71B84
	|-Buffer<TimeSpan>..ctor
	|
	|-RVA: 0x2C7220C Offset: 0x2C6E20C VA: 0x2C7220C
	|-Buffer<Vector3>..ctor
	|
	|-RVA: 0x2C728B8 Offset: 0x2C6E8B8 VA: 0x2C728B8
	|-Buffer<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2C73098 Offset: 0x2C6F098 VA: 0x2C73098
	|-Buffer<TrophyManager.TrophyData>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TElement[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C69DCC Offset: 0x2C65DCC VA: 0x2C69DCC
	|-Buffer<KeyValuePair<byte, byte>>.ToArray
	|
	|-RVA: 0x2C6A474 Offset: 0x2C66474 VA: 0x2C6A474
	|-Buffer<KeyValuePair<byte, object>>.ToArray
	|
	|-RVA: 0x2C6AB1C Offset: 0x2C66B1C VA: 0x2C6AB1C
	|-Buffer<KeyValuePair<Int16Enum, object>>.ToArray
	|
	|-RVA: 0x2C6B1A4 Offset: 0x2C671A4 VA: 0x2C6B1A4
	|-Buffer<KeyValuePair<int, short>>.ToArray
	|
	|-RVA: 0x2C6B82C Offset: 0x2C6782C VA: 0x2C6B82C
	|-Buffer<KeyValuePair<int, int>>.ToArray
	|
	|-RVA: 0x2C6BED4 Offset: 0x2C67ED4 VA: 0x2C6BED4
	|-Buffer<KeyValuePair<int, object>>.ToArray
	|
	|-RVA: 0x2C6C55C Offset: 0x2C6855C VA: 0x2C6C55C
	|-Buffer<KeyValuePair<Int32Enum, byte>>.ToArray
	|
	|-RVA: 0x2C6CC04 Offset: 0x2C68C04 VA: 0x2C6CC04
	|-Buffer<KeyValuePair<Int32Enum, object>>.ToArray
	|
	|-RVA: 0x2C6D29C Offset: 0x2C6929C VA: 0x2C6D29C
	|-Buffer<KeyValuePair<long, short>>.ToArray
	|
	|-RVA: 0x2C6D944 Offset: 0x2C69944 VA: 0x2C6D944
	|-Buffer<KeyValuePair<object, int>>.ToArray
	|
	|-RVA: 0x2C6DFCC Offset: 0x2C69FCC VA: 0x2C6DFCC
	|-Buffer<ValueTuple<int, int>>.ToArray
	|
	|-RVA: 0x2C6E674 Offset: 0x2C6A674 VA: 0x2C6E674
	|-Buffer<ValueTuple<int, object>>.ToArray
	|
	|-RVA: 0x2C6ED00 Offset: 0x2C6AD00 VA: 0x2C6ED00
	|-Buffer<bool>.ToArray
	|
	|-RVA: 0x2C6F388 Offset: 0x2C6B388 VA: 0x2C6F388
	|-Buffer<byte>.ToArray
	|
	|-RVA: 0x2C6FA10 Offset: 0x2C6BA10 VA: 0x2C6FA10
	|-Buffer<char>.ToArray
	|
	|-RVA: 0x2C70098 Offset: 0x2C6C098 VA: 0x2C70098
	|-Buffer<short>.ToArray
	|
	|-RVA: 0x2C70720 Offset: 0x2C6C720 VA: 0x2C70720
	|-Buffer<int>.ToArray
	|
	|-RVA: 0x2C70DA8 Offset: 0x2C6CDA8 VA: 0x2C70DA8
	|-Buffer<Int32Enum>.ToArray
	|
	|-RVA: 0x2C71430 Offset: 0x2C6D430 VA: 0x2C71430
	|-Buffer<long>.ToArray
	|
	|-RVA: 0x2C71AC4 Offset: 0x2C6DAC4 VA: 0x2C71AC4
	|-Buffer<object>.ToArray
	|
	|-RVA: 0x2C7214C Offset: 0x2C6E14C VA: 0x2C7214C
	|-Buffer<TimeSpan>.ToArray
	|
	|-RVA: 0x2C727F8 Offset: 0x2C6E7F8 VA: 0x2C727F8
	|-Buffer<Vector3>.ToArray
	|
	|-RVA: 0x2C72FD8 Offset: 0x2C6EFD8 VA: 0x2C72FD8
	|-Buffer<__Il2CppFullySharedGenericType>.ToArray
	|
	|-RVA: 0x2C73660 Offset: 0x2C6F660 VA: 0x2C73660
	|-Buffer<TrophyManager.TrophyData>.ToArray
	*/
}
