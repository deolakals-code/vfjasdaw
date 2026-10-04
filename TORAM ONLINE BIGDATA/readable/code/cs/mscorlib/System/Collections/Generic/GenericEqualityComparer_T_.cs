// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
[Serializable]
internal class GenericEqualityComparer<T> : EqualityComparer<T> // TypeDefIndex: 10977
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public override bool Equals(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A0BA80 Offset: 0x2A07A80 VA: 0x2A0BA80
	|-GenericEqualityComparer<StructMultiKey<object, object>>.Equals
	|
	|-RVA: 0x2A0BCC8 Offset: 0x2A07CC8 VA: 0x2A0BCC8
	|-GenericEqualityComparer<ValueTuple<bool>>.Equals
	|
	|-RVA: 0x2A0BEE4 Offset: 0x2A07EE4 VA: 0x2A0BEE4
	|-GenericEqualityComparer<ValueTuple<short, short>>.Equals
	|
	|-RVA: 0x2A0C100 Offset: 0x2A08100 VA: 0x2A0C100
	|-GenericEqualityComparer<ValueTuple<int, int>>.Equals
	|
	|-RVA: 0x2A0C31C Offset: 0x2A0831C VA: 0x2A0C31C
	|-GenericEqualityComparer<ValueTuple<int, object>>.Equals
	|
	|-RVA: 0x2A0C564 Offset: 0x2A08564 VA: 0x2A0C564
	|-GenericEqualityComparer<ValueTuple<Int32Enum, float>>.Equals
	|
	|-RVA: 0x2A0C780 Offset: 0x2A08780 VA: 0x2A0C780
	|-GenericEqualityComparer<ValueTuple<object, byte>>.Equals
	|
	|-RVA: 0x2A0C9C8 Offset: 0x2A089C8 VA: 0x2A0C9C8
	|-GenericEqualityComparer<ValueTuple<object, object>>.Equals
	|
	|-RVA: 0x2A0CC10 Offset: 0x2A08C10 VA: 0x2A0CC10
	|-GenericEqualityComparer<ValueTuple<float, object>>.Equals
	|
	|-RVA: 0x2A0CE58 Offset: 0x2A08E58 VA: 0x2A0CE58
	|-GenericEqualityComparer<ValueTuple<Vector3, Vector3>>.Equals
	|
	|-RVA: 0x2A0D0D4 Offset: 0x2A090D4 VA: 0x2A0D0D4
	|-GenericEqualityComparer<ValueTuple<short, int, int>>.Equals
	|
	|-RVA: 0x2A0D330 Offset: 0x2A09330 VA: 0x2A0D330
	|-GenericEqualityComparer<ValueTuple<object, object, object>>.Equals
	|
	|-RVA: 0x2A0D5AC Offset: 0x2A095AC VA: 0x2A0D5AC
	|-GenericEqualityComparer<ArchetypeUid>.Equals
	|
	|-RVA: 0x2A0D7C8 Offset: 0x2A097C8 VA: 0x2A0D7C8
	|-GenericEqualityComparer<bool>.Equals
	|
	|-RVA: 0x2A0DB24 Offset: 0x2A09B24 VA: 0x2A0DB24
	|-GenericEqualityComparer<byte>.Equals
	|
	|-RVA: 0x2A0DD40 Offset: 0x2A09D40 VA: 0x2A0DD40
	|-GenericEqualityComparer<char>.Equals
	|
	|-RVA: 0x2A0E08C Offset: 0x2A0A08C VA: 0x2A0E08C
	|-GenericEqualityComparer<Color>.Equals
	|
	|-RVA: 0x2A0E408 Offset: 0x2A0A408 VA: 0x2A0E408
	|-GenericEqualityComparer<DateTime>.Equals
	|
	|-RVA: 0x2A0E758 Offset: 0x2A0A758 VA: 0x2A0E758
	|-GenericEqualityComparer<DateTimeOffset>.Equals
	|
	|-RVA: 0x2A0EAD0 Offset: 0x2A0AAD0 VA: 0x2A0EAD0
	|-GenericEqualityComparer<Decimal>.Equals
	|
	|-RVA: 0x2A0EE94 Offset: 0x2A0AE94 VA: 0x2A0EE94
	|-GenericEqualityComparer<DefencePoint2>.Equals
	|
	|-RVA: 0x2A0F0B0 Offset: 0x2A0B0B0 VA: 0x2A0F0B0
	|-GenericEqualityComparer<double>.Equals
	|
	|-RVA: 0x2A0F2CC Offset: 0x2A0B2CC VA: 0x2A0F2CC
	|-GenericEqualityComparer<Guid>.Equals
	|
	|-RVA: 0x2A0F514 Offset: 0x2A0B514 VA: 0x2A0F514
	|-GenericEqualityComparer<short>.Equals
	|
	|-RVA: 0x2A0F730 Offset: 0x2A0B730 VA: 0x2A0F730
	|-GenericEqualityComparer<int>.Equals
	|
	|-RVA: 0x2A0F94C Offset: 0x2A0B94C VA: 0x2A0F94C
	|-GenericEqualityComparer<long>.Equals
	|
	|-RVA: 0x2A0FB68 Offset: 0x2A0BB68 VA: 0x2A0FB68
	|-GenericEqualityComparer<IntPtr>.Equals
	|
	|-RVA: 0x2A0FD84 Offset: 0x2A0BD84 VA: 0x2A0FD84
	|-GenericEqualityComparer<object>.Equals
	|
	|-RVA: 0x2A1017C Offset: 0x2A0C17C VA: 0x2A1017C
	|-GenericEqualityComparer<sbyte>.Equals
	|
	|-RVA: 0x2A10398 Offset: 0x2A0C398 VA: 0x2A10398
	|-GenericEqualityComparer<float>.Equals
	|
	|-RVA: 0x2A105B8 Offset: 0x2A0C5B8 VA: 0x2A105B8
	|-GenericEqualityComparer<TimeSpan>.Equals
	|
	|-RVA: 0x2A10908 Offset: 0x2A0C908 VA: 0x2A10908
	|-GenericEqualityComparer<ushort>.Equals
	|
	|-RVA: 0x2A10B24 Offset: 0x2A0CB24 VA: 0x2A10B24
	|-GenericEqualityComparer<uint>.Equals
	|
	|-RVA: 0x2A10D40 Offset: 0x2A0CD40 VA: 0x2A10D40
	|-GenericEqualityComparer<ulong>.Equals
	|
	|-RVA: 0x2A10F5C Offset: 0x2A0CF5C VA: 0x2A10F5C
	|-GenericEqualityComparer<Vector2>.Equals
	|
	|-RVA: 0x2A11134 Offset: 0x2A0D134 VA: 0x2A11134
	|-GenericEqualityComparer<Vector3>.Equals
	|
	|-RVA: 0x2A1135C Offset: 0x2A0D35C VA: 0x2A1135C
	|-GenericEqualityComparer<Vector4>.Equals
	|
	|-RVA: 0x2A115BC Offset: 0x2A0D5BC VA: 0x2A115BC
	|-GenericEqualityComparer<__Il2CppFullySharedGenericType>.Equals
	|
	|-RVA: 0x2A11EA8 Offset: 0x2A0DEA8 VA: 0x2A11EA8
	|-GenericEqualityComparer<Regex.CachedCodeEntryKey>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override int GetHashCode(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A0BABC Offset: 0x2A07ABC VA: 0x2A0BABC
	|-GenericEqualityComparer<StructMultiKey<object, object>>.GetHashCode
	|
	|-RVA: 0x2A0BCF8 Offset: 0x2A07CF8 VA: 0x2A0BCF8
	|-GenericEqualityComparer<ValueTuple<bool>>.GetHashCode
	|
	|-RVA: 0x2A0BF14 Offset: 0x2A07F14 VA: 0x2A0BF14
	|-GenericEqualityComparer<ValueTuple<short, short>>.GetHashCode
	|
	|-RVA: 0x2A0C130 Offset: 0x2A08130 VA: 0x2A0C130
	|-GenericEqualityComparer<ValueTuple<int, int>>.GetHashCode
	|
	|-RVA: 0x2A0C358 Offset: 0x2A08358 VA: 0x2A0C358
	|-GenericEqualityComparer<ValueTuple<int, object>>.GetHashCode
	|
	|-RVA: 0x2A0C594 Offset: 0x2A08594 VA: 0x2A0C594
	|-GenericEqualityComparer<ValueTuple<Int32Enum, float>>.GetHashCode
	|
	|-RVA: 0x2A0C7BC Offset: 0x2A087BC VA: 0x2A0C7BC
	|-GenericEqualityComparer<ValueTuple<object, byte>>.GetHashCode
	|
	|-RVA: 0x2A0CA04 Offset: 0x2A08A04 VA: 0x2A0CA04
	|-GenericEqualityComparer<ValueTuple<object, object>>.GetHashCode
	|
	|-RVA: 0x2A0CC4C Offset: 0x2A08C4C VA: 0x2A0CC4C
	|-GenericEqualityComparer<ValueTuple<float, object>>.GetHashCode
	|
	|-RVA: 0x2A0CEA0 Offset: 0x2A08EA0 VA: 0x2A0CEA0
	|-GenericEqualityComparer<ValueTuple<Vector3, Vector3>>.GetHashCode
	|
	|-RVA: 0x2A0D114 Offset: 0x2A09114 VA: 0x2A0D114
	|-GenericEqualityComparer<ValueTuple<short, int, int>>.GetHashCode
	|
	|-RVA: 0x2A0D378 Offset: 0x2A09378 VA: 0x2A0D378
	|-GenericEqualityComparer<ValueTuple<object, object, object>>.GetHashCode
	|
	|-RVA: 0x2A0D5DC Offset: 0x2A095DC VA: 0x2A0D5DC
	|-GenericEqualityComparer<ArchetypeUid>.GetHashCode
	|
	|-RVA: 0x2A0D848 Offset: 0x2A09848 VA: 0x2A0D848
	|-GenericEqualityComparer<bool>.GetHashCode
	|
	|-RVA: 0x2A0DB54 Offset: 0x2A09B54 VA: 0x2A0DB54
	|-GenericEqualityComparer<byte>.GetHashCode
	|
	|-RVA: 0x2A0DDBC Offset: 0x2A09DBC VA: 0x2A0DDBC
	|-GenericEqualityComparer<char>.GetHashCode
	|
	|-RVA: 0x2A0E120 Offset: 0x2A0A120 VA: 0x2A0E120
	|-GenericEqualityComparer<Color>.GetHashCode
	|
	|-RVA: 0x2A0E484 Offset: 0x2A0A484 VA: 0x2A0E484
	|-GenericEqualityComparer<DateTime>.GetHashCode
	|
	|-RVA: 0x2A0E7E4 Offset: 0x2A0A7E4 VA: 0x2A0E7E4
	|-GenericEqualityComparer<DateTimeOffset>.GetHashCode
	|
	|-RVA: 0x2A0EB84 Offset: 0x2A0AB84 VA: 0x2A0EB84
	|-GenericEqualityComparer<Decimal>.GetHashCode
	|
	|-RVA: 0x2A0EEC4 Offset: 0x2A0AEC4 VA: 0x2A0EEC4
	|-GenericEqualityComparer<DefencePoint2>.GetHashCode
	|
	|-RVA: 0x2A0F0DC Offset: 0x2A0B0DC VA: 0x2A0F0DC
	|-GenericEqualityComparer<double>.GetHashCode
	|
	|-RVA: 0x2A0F308 Offset: 0x2A0B308 VA: 0x2A0F308
	|-GenericEqualityComparer<Guid>.GetHashCode
	|
	|-RVA: 0x2A0F544 Offset: 0x2A0B544 VA: 0x2A0F544
	|-GenericEqualityComparer<short>.GetHashCode
	|
	|-RVA: 0x2A0F760 Offset: 0x2A0B760 VA: 0x2A0F760
	|-GenericEqualityComparer<int>.GetHashCode
	|
	|-RVA: 0x2A0F97C Offset: 0x2A0B97C VA: 0x2A0F97C
	|-GenericEqualityComparer<long>.GetHashCode
	|
	|-RVA: 0x2A0FB98 Offset: 0x2A0BB98 VA: 0x2A0FB98
	|-GenericEqualityComparer<IntPtr>.GetHashCode
	|
	|-RVA: 0x2A0FE34 Offset: 0x2A0BE34 VA: 0x2A0FE34
	|-GenericEqualityComparer<object>.GetHashCode
	|
	|-RVA: 0x2A101AC Offset: 0x2A0C1AC VA: 0x2A101AC
	|-GenericEqualityComparer<sbyte>.GetHashCode
	|
	|-RVA: 0x2A103C4 Offset: 0x2A0C3C4 VA: 0x2A103C4
	|-GenericEqualityComparer<float>.GetHashCode
	|
	|-RVA: 0x2A10634 Offset: 0x2A0C634 VA: 0x2A10634
	|-GenericEqualityComparer<TimeSpan>.GetHashCode
	|
	|-RVA: 0x2A10938 Offset: 0x2A0C938 VA: 0x2A10938
	|-GenericEqualityComparer<ushort>.GetHashCode
	|
	|-RVA: 0x2A10B54 Offset: 0x2A0CB54 VA: 0x2A10B54
	|-GenericEqualityComparer<uint>.GetHashCode
	|
	|-RVA: 0x2A10D70 Offset: 0x2A0CD70 VA: 0x2A10D70
	|-GenericEqualityComparer<ulong>.GetHashCode
	|
	|-RVA: 0x2A10F74 Offset: 0x2A0CF74 VA: 0x2A10F74
	|-GenericEqualityComparer<Vector2>.GetHashCode
	|
	|-RVA: 0x2A11154 Offset: 0x2A0D154 VA: 0x2A11154
	|-GenericEqualityComparer<Vector3>.GetHashCode
	|
	|-RVA: 0x2A11384 Offset: 0x2A0D384 VA: 0x2A11384
	|-GenericEqualityComparer<Vector4>.GetHashCode
	|
	|-RVA: 0x2A117A8 Offset: 0x2A0D7A8 VA: 0x2A117A8
	|-GenericEqualityComparer<__Il2CppFullySharedGenericType>.GetHashCode
	|
	|-RVA: 0x2A11EE8 Offset: 0x2A0DEE8 VA: 0x2A11EE8
	|-GenericEqualityComparer<Regex.CachedCodeEntryKey>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	internal override int IndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A0BAE8 Offset: 0x2A07AE8 VA: 0x2A0BAE8
	|-GenericEqualityComparer<StructMultiKey<object, object>>.IndexOf
	|
	|-RVA: 0x2A0BD1C Offset: 0x2A07D1C VA: 0x2A0BD1C
	|-GenericEqualityComparer<ValueTuple<bool>>.IndexOf
	|
	|-RVA: 0x2A0BF38 Offset: 0x2A07F38 VA: 0x2A0BF38
	|-GenericEqualityComparer<ValueTuple<short, short>>.IndexOf
	|
	|-RVA: 0x2A0C154 Offset: 0x2A08154 VA: 0x2A0C154
	|-GenericEqualityComparer<ValueTuple<int, int>>.IndexOf
	|
	|-RVA: 0x2A0C384 Offset: 0x2A08384 VA: 0x2A0C384
	|-GenericEqualityComparer<ValueTuple<int, object>>.IndexOf
	|
	|-RVA: 0x2A0C5B8 Offset: 0x2A085B8 VA: 0x2A0C5B8
	|-GenericEqualityComparer<ValueTuple<Int32Enum, float>>.IndexOf
	|
	|-RVA: 0x2A0C7E8 Offset: 0x2A087E8 VA: 0x2A0C7E8
	|-GenericEqualityComparer<ValueTuple<object, byte>>.IndexOf
	|
	|-RVA: 0x2A0CA30 Offset: 0x2A08A30 VA: 0x2A0CA30
	|-GenericEqualityComparer<ValueTuple<object, object>>.IndexOf
	|
	|-RVA: 0x2A0CC78 Offset: 0x2A08C78 VA: 0x2A0CC78
	|-GenericEqualityComparer<ValueTuple<float, object>>.IndexOf
	|
	|-RVA: 0x2A0CEB8 Offset: 0x2A08EB8 VA: 0x2A0CEB8
	|-GenericEqualityComparer<ValueTuple<Vector3, Vector3>>.IndexOf
	|
	|-RVA: 0x2A0D144 Offset: 0x2A09144 VA: 0x2A0D144
	|-GenericEqualityComparer<ValueTuple<short, int, int>>.IndexOf
	|
	|-RVA: 0x2A0D390 Offset: 0x2A09390 VA: 0x2A0D390
	|-GenericEqualityComparer<ValueTuple<object, object, object>>.IndexOf
	|
	|-RVA: 0x2A0D600 Offset: 0x2A09600 VA: 0x2A0D600
	|-GenericEqualityComparer<ArchetypeUid>.IndexOf
	|
	|-RVA: 0x2A0D8BC Offset: 0x2A098BC VA: 0x2A0D8BC
	|-GenericEqualityComparer<bool>.IndexOf
	|
	|-RVA: 0x2A0DB78 Offset: 0x2A09B78 VA: 0x2A0DB78
	|-GenericEqualityComparer<byte>.IndexOf
	|
	|-RVA: 0x2A0DE2C Offset: 0x2A09E2C VA: 0x2A0DE2C
	|-GenericEqualityComparer<char>.IndexOf
	|
	|-RVA: 0x2A0E1A4 Offset: 0x2A0A1A4 VA: 0x2A0E1A4
	|-GenericEqualityComparer<Color>.IndexOf
	|
	|-RVA: 0x2A0E4F4 Offset: 0x2A0A4F4 VA: 0x2A0E4F4
	|-GenericEqualityComparer<DateTime>.IndexOf
	|
	|-RVA: 0x2A0E854 Offset: 0x2A0A854 VA: 0x2A0E854
	|-GenericEqualityComparer<DateTimeOffset>.IndexOf
	|
	|-RVA: 0x2A0EC1C Offset: 0x2A0AC1C VA: 0x2A0EC1C
	|-GenericEqualityComparer<Decimal>.IndexOf
	|
	|-RVA: 0x2A0EEE8 Offset: 0x2A0AEE8 VA: 0x2A0EEE8
	|-GenericEqualityComparer<DefencePoint2>.IndexOf
	|
	|-RVA: 0x2A0F0FC Offset: 0x2A0B0FC VA: 0x2A0F0FC
	|-GenericEqualityComparer<double>.IndexOf
	|
	|-RVA: 0x2A0F334 Offset: 0x2A0B334 VA: 0x2A0F334
	|-GenericEqualityComparer<Guid>.IndexOf
	|
	|-RVA: 0x2A0F568 Offset: 0x2A0B568 VA: 0x2A0F568
	|-GenericEqualityComparer<short>.IndexOf
	|
	|-RVA: 0x2A0F784 Offset: 0x2A0B784 VA: 0x2A0F784
	|-GenericEqualityComparer<int>.IndexOf
	|
	|-RVA: 0x2A0F9A0 Offset: 0x2A0B9A0 VA: 0x2A0F9A0
	|-GenericEqualityComparer<long>.IndexOf
	|
	|-RVA: 0x2A0FBBC Offset: 0x2A0BBBC VA: 0x2A0FBBC
	|-GenericEqualityComparer<IntPtr>.IndexOf
	|
	|-RVA: 0x2A0FE54 Offset: 0x2A0BE54 VA: 0x2A0FE54
	|-GenericEqualityComparer<object>.IndexOf
	|
	|-RVA: 0x2A101D0 Offset: 0x2A0C1D0 VA: 0x2A101D0
	|-GenericEqualityComparer<sbyte>.IndexOf
	|
	|-RVA: 0x2A103E8 Offset: 0x2A0C3E8 VA: 0x2A103E8
	|-GenericEqualityComparer<float>.IndexOf
	|
	|-RVA: 0x2A106A4 Offset: 0x2A0C6A4 VA: 0x2A106A4
	|-GenericEqualityComparer<TimeSpan>.IndexOf
	|
	|-RVA: 0x2A1095C Offset: 0x2A0C95C VA: 0x2A1095C
	|-GenericEqualityComparer<ushort>.IndexOf
	|
	|-RVA: 0x2A10B78 Offset: 0x2A0CB78 VA: 0x2A10B78
	|-GenericEqualityComparer<uint>.IndexOf
	|
	|-RVA: 0x2A10D94 Offset: 0x2A0CD94 VA: 0x2A10D94
	|-GenericEqualityComparer<ulong>.IndexOf
	|
	|-RVA: 0x2A10FB4 Offset: 0x2A0CFB4 VA: 0x2A10FB4
	|-GenericEqualityComparer<Vector2>.IndexOf
	|
	|-RVA: 0x2A111B8 Offset: 0x2A0D1B8 VA: 0x2A111B8
	|-GenericEqualityComparer<Vector3>.IndexOf
	|
	|-RVA: 0x2A11408 Offset: 0x2A0D408 VA: 0x2A11408
	|-GenericEqualityComparer<Vector4>.IndexOf
	|
	|-RVA: 0x2A118F4 Offset: 0x2A0D8F4 VA: 0x2A118F4
	|-GenericEqualityComparer<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x2A11F00 Offset: 0x2A0DF00 VA: 0x2A11F00
	|-GenericEqualityComparer<Regex.CachedCodeEntryKey>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override int LastIndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A0BB8C Offset: 0x2A07B8C VA: 0x2A0BB8C
	|-GenericEqualityComparer<StructMultiKey<object, object>>.LastIndexOf
	|
	|-RVA: 0x2A0BDB8 Offset: 0x2A07DB8 VA: 0x2A0BDB8
	|-GenericEqualityComparer<ValueTuple<bool>>.LastIndexOf
	|
	|-RVA: 0x2A0BFD4 Offset: 0x2A07FD4 VA: 0x2A0BFD4
	|-GenericEqualityComparer<ValueTuple<short, short>>.LastIndexOf
	|
	|-RVA: 0x2A0C1F0 Offset: 0x2A081F0 VA: 0x2A0C1F0
	|-GenericEqualityComparer<ValueTuple<int, int>>.LastIndexOf
	|
	|-RVA: 0x2A0C428 Offset: 0x2A08428 VA: 0x2A0C428
	|-GenericEqualityComparer<ValueTuple<int, object>>.LastIndexOf
	|
	|-RVA: 0x2A0C654 Offset: 0x2A08654 VA: 0x2A0C654
	|-GenericEqualityComparer<ValueTuple<Int32Enum, float>>.LastIndexOf
	|
	|-RVA: 0x2A0C88C Offset: 0x2A0888C VA: 0x2A0C88C
	|-GenericEqualityComparer<ValueTuple<object, byte>>.LastIndexOf
	|
	|-RVA: 0x2A0CAD4 Offset: 0x2A08AD4 VA: 0x2A0CAD4
	|-GenericEqualityComparer<ValueTuple<object, object>>.LastIndexOf
	|
	|-RVA: 0x2A0CD1C Offset: 0x2A08D1C VA: 0x2A0CD1C
	|-GenericEqualityComparer<ValueTuple<float, object>>.LastIndexOf
	|
	|-RVA: 0x2A0CF78 Offset: 0x2A08F78 VA: 0x2A0CF78
	|-GenericEqualityComparer<ValueTuple<Vector3, Vector3>>.LastIndexOf
	|
	|-RVA: 0x2A0D1EC Offset: 0x2A091EC VA: 0x2A0D1EC
	|-GenericEqualityComparer<ValueTuple<short, int, int>>.LastIndexOf
	|
	|-RVA: 0x2A0D450 Offset: 0x2A09450 VA: 0x2A0D450
	|-GenericEqualityComparer<ValueTuple<object, object, object>>.LastIndexOf
	|
	|-RVA: 0x2A0D69C Offset: 0x2A0969C VA: 0x2A0D69C
	|-GenericEqualityComparer<ArchetypeUid>.LastIndexOf
	|
	|-RVA: 0x2A0D9A4 Offset: 0x2A099A4 VA: 0x2A0D9A4
	|-GenericEqualityComparer<bool>.LastIndexOf
	|
	|-RVA: 0x2A0DC14 Offset: 0x2A09C14 VA: 0x2A0DC14
	|-GenericEqualityComparer<byte>.LastIndexOf
	|
	|-RVA: 0x2A0DF10 Offset: 0x2A09F10 VA: 0x2A0DF10
	|-GenericEqualityComparer<char>.LastIndexOf
	|
	|-RVA: 0x2A0E284 Offset: 0x2A0A284 VA: 0x2A0E284
	|-GenericEqualityComparer<Color>.LastIndexOf
	|
	|-RVA: 0x2A0E5D8 Offset: 0x2A0A5D8 VA: 0x2A0E5D8
	|-GenericEqualityComparer<DateTime>.LastIndexOf
	|
	|-RVA: 0x2A0E948 Offset: 0x2A0A948 VA: 0x2A0E948
	|-GenericEqualityComparer<DateTimeOffset>.LastIndexOf
	|
	|-RVA: 0x2A0ED10 Offset: 0x2A0AD10 VA: 0x2A0ED10
	|-GenericEqualityComparer<Decimal>.LastIndexOf
	|
	|-RVA: 0x2A0EF84 Offset: 0x2A0AF84 VA: 0x2A0EF84
	|-GenericEqualityComparer<DefencePoint2>.LastIndexOf
	|
	|-RVA: 0x2A0F198 Offset: 0x2A0B198 VA: 0x2A0F198
	|-GenericEqualityComparer<double>.LastIndexOf
	|
	|-RVA: 0x2A0F3D8 Offset: 0x2A0B3D8 VA: 0x2A0F3D8
	|-GenericEqualityComparer<Guid>.LastIndexOf
	|
	|-RVA: 0x2A0F604 Offset: 0x2A0B604 VA: 0x2A0F604
	|-GenericEqualityComparer<short>.LastIndexOf
	|
	|-RVA: 0x2A0F820 Offset: 0x2A0B820 VA: 0x2A0F820
	|-GenericEqualityComparer<int>.LastIndexOf
	|
	|-RVA: 0x2A0FA3C Offset: 0x2A0BA3C VA: 0x2A0FA3C
	|-GenericEqualityComparer<long>.LastIndexOf
	|
	|-RVA: 0x2A0FC58 Offset: 0x2A0BC58 VA: 0x2A0FC58
	|-GenericEqualityComparer<IntPtr>.LastIndexOf
	|
	|-RVA: 0x2A0FF9C Offset: 0x2A0BF9C VA: 0x2A0FF9C
	|-GenericEqualityComparer<object>.LastIndexOf
	|
	|-RVA: 0x2A1026C Offset: 0x2A0C26C VA: 0x2A1026C
	|-GenericEqualityComparer<sbyte>.LastIndexOf
	|
	|-RVA: 0x2A10484 Offset: 0x2A0C484 VA: 0x2A10484
	|-GenericEqualityComparer<float>.LastIndexOf
	|
	|-RVA: 0x2A10788 Offset: 0x2A0C788 VA: 0x2A10788
	|-GenericEqualityComparer<TimeSpan>.LastIndexOf
	|
	|-RVA: 0x2A109F8 Offset: 0x2A0C9F8 VA: 0x2A109F8
	|-GenericEqualityComparer<ushort>.LastIndexOf
	|
	|-RVA: 0x2A10C14 Offset: 0x2A0CC14 VA: 0x2A10C14
	|-GenericEqualityComparer<uint>.LastIndexOf
	|
	|-RVA: 0x2A10E30 Offset: 0x2A0CE30 VA: 0x2A10E30
	|-GenericEqualityComparer<ulong>.LastIndexOf
	|
	|-RVA: 0x2A11024 Offset: 0x2A0D024 VA: 0x2A11024
	|-GenericEqualityComparer<Vector2>.LastIndexOf
	|
	|-RVA: 0x2A11238 Offset: 0x2A0D238 VA: 0x2A11238
	|-GenericEqualityComparer<Vector3>.LastIndexOf
	|
	|-RVA: 0x2A11490 Offset: 0x2A0D490 VA: 0x2A11490
	|-GenericEqualityComparer<Vector4>.LastIndexOf
	|
	|-RVA: 0x2A11B7C Offset: 0x2A0DB7C VA: 0x2A11B7C
	|-GenericEqualityComparer<__Il2CppFullySharedGenericType>.LastIndexOf
	|
	|-RVA: 0x2A11FB8 Offset: 0x2A0DFB8 VA: 0x2A11FB8
	|-GenericEqualityComparer<Regex.CachedCodeEntryKey>.LastIndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A0BC24 Offset: 0x2A07C24 VA: 0x2A0BC24
	|-GenericEqualityComparer<StructMultiKey<object, object>>.Equals
	|
	|-RVA: 0x2A0BE40 Offset: 0x2A07E40 VA: 0x2A0BE40
	|-GenericEqualityComparer<ValueTuple<bool>>.Equals
	|
	|-RVA: 0x2A0C05C Offset: 0x2A0805C VA: 0x2A0C05C
	|-GenericEqualityComparer<ValueTuple<short, short>>.Equals
	|
	|-RVA: 0x2A0C278 Offset: 0x2A08278 VA: 0x2A0C278
	|-GenericEqualityComparer<ValueTuple<int, int>>.Equals
	|
	|-RVA: 0x2A0C4C0 Offset: 0x2A084C0 VA: 0x2A0C4C0
	|-GenericEqualityComparer<ValueTuple<int, object>>.Equals
	|
	|-RVA: 0x2A0C6DC Offset: 0x2A086DC VA: 0x2A0C6DC
	|-GenericEqualityComparer<ValueTuple<Int32Enum, float>>.Equals
	|
	|-RVA: 0x2A0C924 Offset: 0x2A08924 VA: 0x2A0C924
	|-GenericEqualityComparer<ValueTuple<object, byte>>.Equals
	|
	|-RVA: 0x2A0CB6C Offset: 0x2A08B6C VA: 0x2A0CB6C
	|-GenericEqualityComparer<ValueTuple<object, object>>.Equals
	|
	|-RVA: 0x2A0CDB4 Offset: 0x2A08DB4 VA: 0x2A0CDB4
	|-GenericEqualityComparer<ValueTuple<float, object>>.Equals
	|
	|-RVA: 0x2A0D030 Offset: 0x2A09030 VA: 0x2A0D030
	|-GenericEqualityComparer<ValueTuple<Vector3, Vector3>>.Equals
	|
	|-RVA: 0x2A0D28C Offset: 0x2A0928C VA: 0x2A0D28C
	|-GenericEqualityComparer<ValueTuple<short, int, int>>.Equals
	|
	|-RVA: 0x2A0D508 Offset: 0x2A09508 VA: 0x2A0D508
	|-GenericEqualityComparer<ValueTuple<object, object, object>>.Equals
	|
	|-RVA: 0x2A0D724 Offset: 0x2A09724 VA: 0x2A0D724
	|-GenericEqualityComparer<ArchetypeUid>.Equals
	|
	|-RVA: 0x2A0DA80 Offset: 0x2A09A80 VA: 0x2A0DA80
	|-GenericEqualityComparer<bool>.Equals
	|
	|-RVA: 0x2A0DC9C Offset: 0x2A09C9C VA: 0x2A0DC9C
	|-GenericEqualityComparer<byte>.Equals
	|
	|-RVA: 0x2A0DFE8 Offset: 0x2A09FE8 VA: 0x2A0DFE8
	|-GenericEqualityComparer<char>.Equals
	|
	|-RVA: 0x2A0E364 Offset: 0x2A0A364 VA: 0x2A0E364
	|-GenericEqualityComparer<Color>.Equals
	|
	|-RVA: 0x2A0E6B4 Offset: 0x2A0A6B4 VA: 0x2A0E6B4
	|-GenericEqualityComparer<DateTime>.Equals
	|
	|-RVA: 0x2A0EA2C Offset: 0x2A0AA2C VA: 0x2A0EA2C
	|-GenericEqualityComparer<DateTimeOffset>.Equals
	|
	|-RVA: 0x2A0EDF0 Offset: 0x2A0ADF0 VA: 0x2A0EDF0
	|-GenericEqualityComparer<Decimal>.Equals
	|
	|-RVA: 0x2A0F00C Offset: 0x2A0B00C VA: 0x2A0F00C
	|-GenericEqualityComparer<DefencePoint2>.Equals
	|
	|-RVA: 0x2A0F228 Offset: 0x2A0B228 VA: 0x2A0F228
	|-GenericEqualityComparer<double>.Equals
	|
	|-RVA: 0x2A0F470 Offset: 0x2A0B470 VA: 0x2A0F470
	|-GenericEqualityComparer<Guid>.Equals
	|
	|-RVA: 0x2A0F68C Offset: 0x2A0B68C VA: 0x2A0F68C
	|-GenericEqualityComparer<short>.Equals
	|
	|-RVA: 0x2A0F8A8 Offset: 0x2A0B8A8 VA: 0x2A0F8A8
	|-GenericEqualityComparer<int>.Equals
	|
	|-RVA: 0x2A0FAC4 Offset: 0x2A0BAC4 VA: 0x2A0FAC4
	|-GenericEqualityComparer<long>.Equals
	|
	|-RVA: 0x2A0FCE0 Offset: 0x2A0BCE0 VA: 0x2A0FCE0
	|-GenericEqualityComparer<IntPtr>.Equals
	|
	|-RVA: 0x2A100D8 Offset: 0x2A0C0D8 VA: 0x2A100D8
	|-GenericEqualityComparer<object>.Equals
	|
	|-RVA: 0x2A102F4 Offset: 0x2A0C2F4 VA: 0x2A102F4
	|-GenericEqualityComparer<sbyte>.Equals
	|
	|-RVA: 0x2A10514 Offset: 0x2A0C514 VA: 0x2A10514
	|-GenericEqualityComparer<float>.Equals
	|
	|-RVA: 0x2A10864 Offset: 0x2A0C864 VA: 0x2A10864
	|-GenericEqualityComparer<TimeSpan>.Equals
	|
	|-RVA: 0x2A10A80 Offset: 0x2A0CA80 VA: 0x2A10A80
	|-GenericEqualityComparer<ushort>.Equals
	|
	|-RVA: 0x2A10C9C Offset: 0x2A0CC9C VA: 0x2A10C9C
	|-GenericEqualityComparer<uint>.Equals
	|
	|-RVA: 0x2A10EB8 Offset: 0x2A0CEB8 VA: 0x2A10EB8
	|-GenericEqualityComparer<ulong>.Equals
	|
	|-RVA: 0x2A11090 Offset: 0x2A0D090 VA: 0x2A11090
	|-GenericEqualityComparer<Vector2>.Equals
	|
	|-RVA: 0x2A112B8 Offset: 0x2A0D2B8 VA: 0x2A112B8
	|-GenericEqualityComparer<Vector3>.Equals
	|
	|-RVA: 0x2A11518 Offset: 0x2A0D518 VA: 0x2A11518
	|-GenericEqualityComparer<Vector4>.Equals
	|
	|-RVA: 0x2A11E00 Offset: 0x2A0DE00 VA: 0x2A11E00
	|-GenericEqualityComparer<__Il2CppFullySharedGenericType>.Equals
	|
	|-RVA: 0x2A12068 Offset: 0x2A0E068 VA: 0x2A12068
	|-GenericEqualityComparer<Regex.CachedCodeEntryKey>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A0BC80 Offset: 0x2A07C80 VA: 0x2A0BC80
	|-GenericEqualityComparer<StructMultiKey<object, object>>.GetHashCode
	|
	|-RVA: 0x2A0BE9C Offset: 0x2A07E9C VA: 0x2A0BE9C
	|-GenericEqualityComparer<ValueTuple<bool>>.GetHashCode
	|
	|-RVA: 0x2A0C0B8 Offset: 0x2A080B8 VA: 0x2A0C0B8
	|-GenericEqualityComparer<ValueTuple<short, short>>.GetHashCode
	|
	|-RVA: 0x2A0C2D4 Offset: 0x2A082D4 VA: 0x2A0C2D4
	|-GenericEqualityComparer<ValueTuple<int, int>>.GetHashCode
	|
	|-RVA: 0x2A0C51C Offset: 0x2A0851C VA: 0x2A0C51C
	|-GenericEqualityComparer<ValueTuple<int, object>>.GetHashCode
	|
	|-RVA: 0x2A0C738 Offset: 0x2A08738 VA: 0x2A0C738
	|-GenericEqualityComparer<ValueTuple<Int32Enum, float>>.GetHashCode
	|
	|-RVA: 0x2A0C980 Offset: 0x2A08980 VA: 0x2A0C980
	|-GenericEqualityComparer<ValueTuple<object, byte>>.GetHashCode
	|
	|-RVA: 0x2A0CBC8 Offset: 0x2A08BC8 VA: 0x2A0CBC8
	|-GenericEqualityComparer<ValueTuple<object, object>>.GetHashCode
	|
	|-RVA: 0x2A0CE10 Offset: 0x2A08E10 VA: 0x2A0CE10
	|-GenericEqualityComparer<ValueTuple<float, object>>.GetHashCode
	|
	|-RVA: 0x2A0D08C Offset: 0x2A0908C VA: 0x2A0D08C
	|-GenericEqualityComparer<ValueTuple<Vector3, Vector3>>.GetHashCode
	|
	|-RVA: 0x2A0D2E8 Offset: 0x2A092E8 VA: 0x2A0D2E8
	|-GenericEqualityComparer<ValueTuple<short, int, int>>.GetHashCode
	|
	|-RVA: 0x2A0D564 Offset: 0x2A09564 VA: 0x2A0D564
	|-GenericEqualityComparer<ValueTuple<object, object, object>>.GetHashCode
	|
	|-RVA: 0x2A0D780 Offset: 0x2A09780 VA: 0x2A0D780
	|-GenericEqualityComparer<ArchetypeUid>.GetHashCode
	|
	|-RVA: 0x2A0DADC Offset: 0x2A09ADC VA: 0x2A0DADC
	|-GenericEqualityComparer<bool>.GetHashCode
	|
	|-RVA: 0x2A0DCF8 Offset: 0x2A09CF8 VA: 0x2A0DCF8
	|-GenericEqualityComparer<byte>.GetHashCode
	|
	|-RVA: 0x2A0E044 Offset: 0x2A0A044 VA: 0x2A0E044
	|-GenericEqualityComparer<char>.GetHashCode
	|
	|-RVA: 0x2A0E3C0 Offset: 0x2A0A3C0 VA: 0x2A0E3C0
	|-GenericEqualityComparer<Color>.GetHashCode
	|
	|-RVA: 0x2A0E710 Offset: 0x2A0A710 VA: 0x2A0E710
	|-GenericEqualityComparer<DateTime>.GetHashCode
	|
	|-RVA: 0x2A0EA88 Offset: 0x2A0AA88 VA: 0x2A0EA88
	|-GenericEqualityComparer<DateTimeOffset>.GetHashCode
	|
	|-RVA: 0x2A0EE4C Offset: 0x2A0AE4C VA: 0x2A0EE4C
	|-GenericEqualityComparer<Decimal>.GetHashCode
	|
	|-RVA: 0x2A0F068 Offset: 0x2A0B068 VA: 0x2A0F068
	|-GenericEqualityComparer<DefencePoint2>.GetHashCode
	|
	|-RVA: 0x2A0F284 Offset: 0x2A0B284 VA: 0x2A0F284
	|-GenericEqualityComparer<double>.GetHashCode
	|
	|-RVA: 0x2A0F4CC Offset: 0x2A0B4CC VA: 0x2A0F4CC
	|-GenericEqualityComparer<Guid>.GetHashCode
	|
	|-RVA: 0x2A0F6E8 Offset: 0x2A0B6E8 VA: 0x2A0F6E8
	|-GenericEqualityComparer<short>.GetHashCode
	|
	|-RVA: 0x2A0F904 Offset: 0x2A0B904 VA: 0x2A0F904
	|-GenericEqualityComparer<int>.GetHashCode
	|
	|-RVA: 0x2A0FB20 Offset: 0x2A0BB20 VA: 0x2A0FB20
	|-GenericEqualityComparer<long>.GetHashCode
	|
	|-RVA: 0x2A0FD3C Offset: 0x2A0BD3C VA: 0x2A0FD3C
	|-GenericEqualityComparer<IntPtr>.GetHashCode
	|
	|-RVA: 0x2A10134 Offset: 0x2A0C134 VA: 0x2A10134
	|-GenericEqualityComparer<object>.GetHashCode
	|
	|-RVA: 0x2A10350 Offset: 0x2A0C350 VA: 0x2A10350
	|-GenericEqualityComparer<sbyte>.GetHashCode
	|
	|-RVA: 0x2A10570 Offset: 0x2A0C570 VA: 0x2A10570
	|-GenericEqualityComparer<float>.GetHashCode
	|
	|-RVA: 0x2A108C0 Offset: 0x2A0C8C0 VA: 0x2A108C0
	|-GenericEqualityComparer<TimeSpan>.GetHashCode
	|
	|-RVA: 0x2A10ADC Offset: 0x2A0CADC VA: 0x2A10ADC
	|-GenericEqualityComparer<ushort>.GetHashCode
	|
	|-RVA: 0x2A10CF8 Offset: 0x2A0CCF8 VA: 0x2A10CF8
	|-GenericEqualityComparer<uint>.GetHashCode
	|
	|-RVA: 0x2A10F14 Offset: 0x2A0CF14 VA: 0x2A10F14
	|-GenericEqualityComparer<ulong>.GetHashCode
	|
	|-RVA: 0x2A110EC Offset: 0x2A0D0EC VA: 0x2A110EC
	|-GenericEqualityComparer<Vector2>.GetHashCode
	|
	|-RVA: 0x2A11314 Offset: 0x2A0D314 VA: 0x2A11314
	|-GenericEqualityComparer<Vector3>.GetHashCode
	|
	|-RVA: 0x2A11574 Offset: 0x2A0D574 VA: 0x2A11574
	|-GenericEqualityComparer<Vector4>.GetHashCode
	|
	|-RVA: 0x2A11E5C Offset: 0x2A0DE5C VA: 0x2A11E5C
	|-GenericEqualityComparer<__Il2CppFullySharedGenericType>.GetHashCode
	|
	|-RVA: 0x2A120C4 Offset: 0x2A0E0C4 VA: 0x2A120C4
	|-GenericEqualityComparer<Regex.CachedCodeEntryKey>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A0BCB8 Offset: 0x2A07CB8 VA: 0x2A0BCB8
	|-GenericEqualityComparer<StructMultiKey<object, object>>..ctor
	|
	|-RVA: 0x2A0BED4 Offset: 0x2A07ED4 VA: 0x2A0BED4
	|-GenericEqualityComparer<ValueTuple<bool>>..ctor
	|
	|-RVA: 0x2A0C0F0 Offset: 0x2A080F0 VA: 0x2A0C0F0
	|-GenericEqualityComparer<ValueTuple<short, short>>..ctor
	|
	|-RVA: 0x2A0C30C Offset: 0x2A0830C VA: 0x2A0C30C
	|-GenericEqualityComparer<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2A0C554 Offset: 0x2A08554 VA: 0x2A0C554
	|-GenericEqualityComparer<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x2A0C770 Offset: 0x2A08770 VA: 0x2A0C770
	|-GenericEqualityComparer<ValueTuple<Int32Enum, float>>..ctor
	|
	|-RVA: 0x2A0C9B8 Offset: 0x2A089B8 VA: 0x2A0C9B8
	|-GenericEqualityComparer<ValueTuple<object, byte>>..ctor
	|
	|-RVA: 0x2A0CC00 Offset: 0x2A08C00 VA: 0x2A0CC00
	|-GenericEqualityComparer<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2A0CE48 Offset: 0x2A08E48 VA: 0x2A0CE48
	|-GenericEqualityComparer<ValueTuple<float, object>>..ctor
	|
	|-RVA: 0x2A0D0C4 Offset: 0x2A090C4 VA: 0x2A0D0C4
	|-GenericEqualityComparer<ValueTuple<Vector3, Vector3>>..ctor
	|
	|-RVA: 0x2A0D320 Offset: 0x2A09320 VA: 0x2A0D320
	|-GenericEqualityComparer<ValueTuple<short, int, int>>..ctor
	|
	|-RVA: 0x2A0D59C Offset: 0x2A0959C VA: 0x2A0D59C
	|-GenericEqualityComparer<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x2A0D7B8 Offset: 0x2A097B8 VA: 0x2A0D7B8
	|-GenericEqualityComparer<ArchetypeUid>..ctor
	|
	|-RVA: 0x2A0DB14 Offset: 0x2A09B14 VA: 0x2A0DB14
	|-GenericEqualityComparer<bool>..ctor
	|
	|-RVA: 0x2A0DD30 Offset: 0x2A09D30 VA: 0x2A0DD30
	|-GenericEqualityComparer<byte>..ctor
	|
	|-RVA: 0x2A0E07C Offset: 0x2A0A07C VA: 0x2A0E07C
	|-GenericEqualityComparer<char>..ctor
	|
	|-RVA: 0x2A0E3F8 Offset: 0x2A0A3F8 VA: 0x2A0E3F8
	|-GenericEqualityComparer<Color>..ctor
	|
	|-RVA: 0x2A0E748 Offset: 0x2A0A748 VA: 0x2A0E748
	|-GenericEqualityComparer<DateTime>..ctor
	|
	|-RVA: 0x2A0EAC0 Offset: 0x2A0AAC0 VA: 0x2A0EAC0
	|-GenericEqualityComparer<DateTimeOffset>..ctor
	|
	|-RVA: 0x2A0EE84 Offset: 0x2A0AE84 VA: 0x2A0EE84
	|-GenericEqualityComparer<Decimal>..ctor
	|
	|-RVA: 0x2A0F0A0 Offset: 0x2A0B0A0 VA: 0x2A0F0A0
	|-GenericEqualityComparer<DefencePoint2>..ctor
	|
	|-RVA: 0x2A0F2BC Offset: 0x2A0B2BC VA: 0x2A0F2BC
	|-GenericEqualityComparer<double>..ctor
	|
	|-RVA: 0x2A0F504 Offset: 0x2A0B504 VA: 0x2A0F504
	|-GenericEqualityComparer<Guid>..ctor
	|
	|-RVA: 0x2A0F720 Offset: 0x2A0B720 VA: 0x2A0F720
	|-GenericEqualityComparer<short>..ctor
	|
	|-RVA: 0x2A0F93C Offset: 0x2A0B93C VA: 0x2A0F93C
	|-GenericEqualityComparer<int>..ctor
	|
	|-RVA: 0x2A0FB58 Offset: 0x2A0BB58 VA: 0x2A0FB58
	|-GenericEqualityComparer<long>..ctor
	|
	|-RVA: 0x2A0FD74 Offset: 0x2A0BD74 VA: 0x2A0FD74
	|-GenericEqualityComparer<IntPtr>..ctor
	|
	|-RVA: 0x2A1016C Offset: 0x2A0C16C VA: 0x2A1016C
	|-GenericEqualityComparer<object>..ctor
	|
	|-RVA: 0x2A10388 Offset: 0x2A0C388 VA: 0x2A10388
	|-GenericEqualityComparer<sbyte>..ctor
	|
	|-RVA: 0x2A105A8 Offset: 0x2A0C5A8 VA: 0x2A105A8
	|-GenericEqualityComparer<float>..ctor
	|
	|-RVA: 0x2A108F8 Offset: 0x2A0C8F8 VA: 0x2A108F8
	|-GenericEqualityComparer<TimeSpan>..ctor
	|
	|-RVA: 0x2A10B14 Offset: 0x2A0CB14 VA: 0x2A10B14
	|-GenericEqualityComparer<ushort>..ctor
	|
	|-RVA: 0x2A10D30 Offset: 0x2A0CD30 VA: 0x2A10D30
	|-GenericEqualityComparer<uint>..ctor
	|
	|-RVA: 0x2A10F4C Offset: 0x2A0CF4C VA: 0x2A10F4C
	|-GenericEqualityComparer<ulong>..ctor
	|
	|-RVA: 0x2A11124 Offset: 0x2A0D124 VA: 0x2A11124
	|-GenericEqualityComparer<Vector2>..ctor
	|
	|-RVA: 0x2A1134C Offset: 0x2A0D34C VA: 0x2A1134C
	|-GenericEqualityComparer<Vector3>..ctor
	|
	|-RVA: 0x2A115AC Offset: 0x2A0D5AC VA: 0x2A115AC
	|-GenericEqualityComparer<Vector4>..ctor
	|
	|-RVA: 0x2A11E94 Offset: 0x2A0DE94 VA: 0x2A11E94
	|-GenericEqualityComparer<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2A120FC Offset: 0x2A0E0FC VA: 0x2A120FC
	|-GenericEqualityComparer<Regex.CachedCodeEntryKey>..ctor
	*/
}
