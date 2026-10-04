// Assembly: System.Core.dll
// Namespace: 
private class Enumerable.WhereSelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 15187
{
	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private IEnumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D80304 Offset: 0x2D7C304 VA: 0x2D80304
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<byte, object>, byte>..ctor
	|
	|-RVA: 0x2D8075C Offset: 0x2D7C75C VA: 0x2D8075C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<byte, object>, int>..ctor
	|
	|-RVA: 0x2D80BB4 Offset: 0x2D7CBB4 VA: 0x2D80BB4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, bool>..ctor
	|
	|-RVA: 0x2D81010 Offset: 0x2D7D010 VA: 0x2D81010
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, byte>..ctor
	|
	|-RVA: 0x2D81468 Offset: 0x2D7D468 VA: 0x2D81468
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, short>..ctor
	|
	|-RVA: 0x2D818C0 Offset: 0x2D7D8C0 VA: 0x2D818C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, int>..ctor
	|
	|-RVA: 0x2D81D18 Offset: 0x2D7DD18 VA: 0x2D81D18
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, Int32Enum>..ctor
	|
	|-RVA: 0x2D82170 Offset: 0x2D7E170 VA: 0x2D82170
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, long>..ctor
	|
	|-RVA: 0x2D825C8 Offset: 0x2D7E5C8 VA: 0x2D825C8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>..ctor
	|
	|-RVA: 0x2D82A2C Offset: 0x2D7EA2C VA: 0x2D82A2C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, float>..ctor
	|
	|-RVA: 0x2D82E84 Offset: 0x2D7EE84 VA: 0x2D82E84
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, Vector3>..ctor
	|
	|-RVA: 0x2D832E0 Offset: 0x2D7F2E0 VA: 0x2D832E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, EnhanceProperties2>, int>..ctor
	|
	|-RVA: 0x2D83774 Offset: 0x2D7F774 VA: 0x2D83774
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, bool>..ctor
	|
	|-RVA: 0x2D83BC4 Offset: 0x2D7FBC4 VA: 0x2D83BC4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, byte>..ctor
	|
	|-RVA: 0x2D84010 Offset: 0x2D80010 VA: 0x2D84010
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, short>..ctor
	|
	|-RVA: 0x2D8445C Offset: 0x2D8045C VA: 0x2D8445C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, int>..ctor
	|
	|-RVA: 0x2D848A8 Offset: 0x2D808A8 VA: 0x2D848A8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, Int32Enum>..ctor
	|
	|-RVA: 0x2D84CF4 Offset: 0x2D80CF4 VA: 0x2D84CF4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, long>..ctor
	|
	|-RVA: 0x2D85140 Offset: 0x2D81140 VA: 0x2D85140
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, object>..ctor
	|
	|-RVA: 0x2D85598 Offset: 0x2D81598 VA: 0x2D85598
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, float>..ctor
	|
	|-RVA: 0x2D859E4 Offset: 0x2D819E4 VA: 0x2D859E4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, Vector3>..ctor
	|
	|-RVA: 0x2D85E34 Offset: 0x2D81E34 VA: 0x2D85E34
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, object>, int>..ctor
	|
	|-RVA: 0x2D8628C Offset: 0x2D8228C VA: 0x2D8628C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, object>, Int32Enum>..ctor
	|
	|-RVA: 0x2D866E4 Offset: 0x2D826E4 VA: 0x2D866E4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, bool>..ctor
	|
	|-RVA: 0x2D86B40 Offset: 0x2D82B40 VA: 0x2D86B40
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, byte>..ctor
	|
	|-RVA: 0x2D86F98 Offset: 0x2D82F98 VA: 0x2D86F98
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, short>..ctor
	|
	|-RVA: 0x2D873F0 Offset: 0x2D833F0 VA: 0x2D873F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, int>..ctor
	|
	|-RVA: 0x2D87848 Offset: 0x2D83848 VA: 0x2D87848
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, Int32Enum>..ctor
	|
	|-RVA: 0x2D87CA0 Offset: 0x2D83CA0 VA: 0x2D87CA0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, long>..ctor
	|
	|-RVA: 0x2D880F8 Offset: 0x2D840F8 VA: 0x2D880F8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, object>..ctor
	|
	|-RVA: 0x2D8855C Offset: 0x2D8455C VA: 0x2D8855C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, float>..ctor
	|
	|-RVA: 0x2D889B4 Offset: 0x2D849B4 VA: 0x2D889B4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, Vector3>..ctor
	|
	|-RVA: 0x2D88E10 Offset: 0x2D84E10 VA: 0x2D88E10
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, bool>..ctor
	|
	|-RVA: 0x2D8926C Offset: 0x2D8526C VA: 0x2D8926C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, byte>..ctor
	|
	|-RVA: 0x2D896C4 Offset: 0x2D856C4 VA: 0x2D896C4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, short>..ctor
	|
	|-RVA: 0x2D89B1C Offset: 0x2D85B1C VA: 0x2D89B1C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, int>..ctor
	|
	|-RVA: 0x2D89F74 Offset: 0x2D85F74 VA: 0x2D89F74
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, Int32Enum>..ctor
	|
	|-RVA: 0x2D8A3CC Offset: 0x2D863CC VA: 0x2D8A3CC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, long>..ctor
	|
	|-RVA: 0x2D8A824 Offset: 0x2D86824 VA: 0x2D8A824
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, object>..ctor
	|
	|-RVA: 0x2D8AC88 Offset: 0x2D86C88 VA: 0x2D8AC88
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, float>..ctor
	|
	|-RVA: 0x2D8B0E0 Offset: 0x2D870E0 VA: 0x2D8B0E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, Vector3>..ctor
	|
	|-RVA: 0x2D8B53C Offset: 0x2D8753C VA: 0x2D8B53C
	|-Enumerable.WhereSelectEnumerableIterator<Nullable<UIMobPropertyLabel.IconValue>, int>..ctor
	|
	|-RVA: 0x2D8B9B0 Offset: 0x2D879B0 VA: 0x2D8B9B0
	|-Enumerable.WhereSelectEnumerableIterator<byte, int>..ctor
	|
	|-RVA: 0x2D8BDFC Offset: 0x2D87DFC VA: 0x2D8BDFC
	|-Enumerable.WhereSelectEnumerableIterator<int, int>..ctor
	|
	|-RVA: 0x2D8C248 Offset: 0x2D88248 VA: 0x2D8C248
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>..ctor
	|
	|-RVA: 0x2D8C694 Offset: 0x2D88694 VA: 0x2D8C694
	|-Enumerable.WhereSelectEnumerableIterator<long, long>..ctor
	|
	|-RVA: 0x2D8CAE0 Offset: 0x2D88AE0 VA: 0x2D8CAE0
	|-Enumerable.WhereSelectEnumerableIterator<long, TimeSpan>..ctor
	|
	|-RVA: 0x2D8CF2C Offset: 0x2D88F2C VA: 0x2D8CF2C
	|-Enumerable.WhereSelectEnumerableIterator<MobActionTargetData, float>..ctor
	|
	|-RVA: 0x2D8D3C0 Offset: 0x2D893C0 VA: 0x2D8D3C0
	|-Enumerable.WhereSelectEnumerableIterator<MobActionTargetData, Vector3>..ctor
	|
	|-RVA: 0x2D8D858 Offset: 0x2D89858 VA: 0x2D8D858
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>..ctor
	|
	|-RVA: 0x2D8DCA8 Offset: 0x2D89CA8 VA: 0x2D8DCA8
	|-Enumerable.WhereSelectEnumerableIterator<object, byte>..ctor
	|
	|-RVA: 0x2D8E0F4 Offset: 0x2D8A0F4 VA: 0x2D8E0F4
	|-Enumerable.WhereSelectEnumerableIterator<object, short>..ctor
	|
	|-RVA: 0x2D8E540 Offset: 0x2D8A540 VA: 0x2D8E540
	|-Enumerable.WhereSelectEnumerableIterator<object, int>..ctor
	|
	|-RVA: 0x2D8E98C Offset: 0x2D8A98C VA: 0x2D8E98C
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>..ctor
	|
	|-RVA: 0x2D8EDD8 Offset: 0x2D8ADD8 VA: 0x2D8EDD8
	|-Enumerable.WhereSelectEnumerableIterator<object, long>..ctor
	|
	|-RVA: 0x2D8F224 Offset: 0x2D8B224 VA: 0x2D8F224
	|-Enumerable.WhereSelectEnumerableIterator<object, object>..ctor
	|
	|-RVA: 0x2D8F67C Offset: 0x2D8B67C VA: 0x2D8F67C
	|-Enumerable.WhereSelectEnumerableIterator<object, float>..ctor
	|
	|-RVA: 0x2D8FAC8 Offset: 0x2D8BAC8 VA: 0x2D8FAC8
	|-Enumerable.WhereSelectEnumerableIterator<object, TimeSpan>..ctor
	|
	|-RVA: 0x2D8FF14 Offset: 0x2D8BF14 VA: 0x2D8FF14
	|-Enumerable.WhereSelectEnumerableIterator<object, Vector3>..ctor
	|
	|-RVA: 0x2D90364 Offset: 0x2D8C364 VA: 0x2D90364
	|-Enumerable.WhereSelectEnumerableIterator<float, int>..ctor
	|
	|-RVA: 0x2D907B8 Offset: 0x2D8C7B8 VA: 0x2D907B8
	|-Enumerable.WhereSelectEnumerableIterator<TimeSpan, long>..ctor
	|
	|-RVA: 0x2D90C04 Offset: 0x2D8CC04 VA: 0x2D90C04
	|-Enumerable.WhereSelectEnumerableIterator<TimeSpan, TimeSpan>..ctor
	|
	|-RVA: 0x2D91050 Offset: 0x2D8D050 VA: 0x2D91050
	|-Enumerable.WhereSelectEnumerableIterator<Vector3, int>..ctor
	|
	|-RVA: 0x2D914C4 Offset: 0x2D8D4C4 VA: 0x2D914C4
	|-Enumerable.WhereSelectEnumerableIterator<Vector3, float>..ctor
	|
	|-RVA: 0x2D91938 Offset: 0x2D8D938 VA: 0x2D91938
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8036C Offset: 0x2D7C36C VA: 0x2D8036C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<byte, object>, byte>.Clone
	|
	|-RVA: 0x2D807C4 Offset: 0x2D7C7C4 VA: 0x2D807C4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<byte, object>, int>.Clone
	|
	|-RVA: 0x2D80C1C Offset: 0x2D7CC1C VA: 0x2D80C1C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, bool>.Clone
	|
	|-RVA: 0x2D81078 Offset: 0x2D7D078 VA: 0x2D81078
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, byte>.Clone
	|
	|-RVA: 0x2D814D0 Offset: 0x2D7D4D0 VA: 0x2D814D0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, short>.Clone
	|
	|-RVA: 0x2D81928 Offset: 0x2D7D928 VA: 0x2D81928
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, int>.Clone
	|
	|-RVA: 0x2D81D80 Offset: 0x2D7DD80 VA: 0x2D81D80
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, Int32Enum>.Clone
	|
	|-RVA: 0x2D821D8 Offset: 0x2D7E1D8 VA: 0x2D821D8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, long>.Clone
	|
	|-RVA: 0x2D82630 Offset: 0x2D7E630 VA: 0x2D82630
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.Clone
	|
	|-RVA: 0x2D82A94 Offset: 0x2D7EA94 VA: 0x2D82A94
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, float>.Clone
	|
	|-RVA: 0x2D82EEC Offset: 0x2D7EEEC VA: 0x2D82EEC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, Vector3>.Clone
	|
	|-RVA: 0x2D83348 Offset: 0x2D7F348 VA: 0x2D83348
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, EnhanceProperties2>, int>.Clone
	|
	|-RVA: 0x2D837DC Offset: 0x2D7F7DC VA: 0x2D837DC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, bool>.Clone
	|
	|-RVA: 0x2D83C2C Offset: 0x2D7FC2C VA: 0x2D83C2C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, byte>.Clone
	|
	|-RVA: 0x2D84078 Offset: 0x2D80078 VA: 0x2D84078
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, short>.Clone
	|
	|-RVA: 0x2D844C4 Offset: 0x2D804C4 VA: 0x2D844C4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, int>.Clone
	|
	|-RVA: 0x2D84910 Offset: 0x2D80910 VA: 0x2D84910
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, Int32Enum>.Clone
	|
	|-RVA: 0x2D84D5C Offset: 0x2D80D5C VA: 0x2D84D5C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, long>.Clone
	|
	|-RVA: 0x2D851A8 Offset: 0x2D811A8 VA: 0x2D851A8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, object>.Clone
	|
	|-RVA: 0x2D85600 Offset: 0x2D81600 VA: 0x2D85600
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, float>.Clone
	|
	|-RVA: 0x2D85A4C Offset: 0x2D81A4C VA: 0x2D85A4C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, Vector3>.Clone
	|
	|-RVA: 0x2D85E9C Offset: 0x2D81E9C VA: 0x2D85E9C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, object>, int>.Clone
	|
	|-RVA: 0x2D862F4 Offset: 0x2D822F4 VA: 0x2D862F4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, object>, Int32Enum>.Clone
	|
	|-RVA: 0x2D8674C Offset: 0x2D8274C VA: 0x2D8674C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, bool>.Clone
	|
	|-RVA: 0x2D86BA8 Offset: 0x2D82BA8 VA: 0x2D86BA8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, byte>.Clone
	|
	|-RVA: 0x2D87000 Offset: 0x2D83000 VA: 0x2D87000
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, short>.Clone
	|
	|-RVA: 0x2D87458 Offset: 0x2D83458 VA: 0x2D87458
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, int>.Clone
	|
	|-RVA: 0x2D878B0 Offset: 0x2D838B0 VA: 0x2D878B0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, Int32Enum>.Clone
	|
	|-RVA: 0x2D87D08 Offset: 0x2D83D08 VA: 0x2D87D08
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, long>.Clone
	|
	|-RVA: 0x2D88160 Offset: 0x2D84160 VA: 0x2D88160
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, object>.Clone
	|
	|-RVA: 0x2D885C4 Offset: 0x2D845C4 VA: 0x2D885C4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, float>.Clone
	|
	|-RVA: 0x2D88A1C Offset: 0x2D84A1C VA: 0x2D88A1C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, Vector3>.Clone
	|
	|-RVA: 0x2D88E78 Offset: 0x2D84E78 VA: 0x2D88E78
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, bool>.Clone
	|
	|-RVA: 0x2D892D4 Offset: 0x2D852D4 VA: 0x2D892D4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, byte>.Clone
	|
	|-RVA: 0x2D8972C Offset: 0x2D8572C VA: 0x2D8972C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, short>.Clone
	|
	|-RVA: 0x2D89B84 Offset: 0x2D85B84 VA: 0x2D89B84
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, int>.Clone
	|
	|-RVA: 0x2D89FDC Offset: 0x2D85FDC VA: 0x2D89FDC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, Int32Enum>.Clone
	|
	|-RVA: 0x2D8A434 Offset: 0x2D86434 VA: 0x2D8A434
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, long>.Clone
	|
	|-RVA: 0x2D8A88C Offset: 0x2D8688C VA: 0x2D8A88C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, object>.Clone
	|
	|-RVA: 0x2D8ACF0 Offset: 0x2D86CF0 VA: 0x2D8ACF0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, float>.Clone
	|
	|-RVA: 0x2D8B148 Offset: 0x2D87148 VA: 0x2D8B148
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, Vector3>.Clone
	|
	|-RVA: 0x2D8B5A4 Offset: 0x2D875A4 VA: 0x2D8B5A4
	|-Enumerable.WhereSelectEnumerableIterator<Nullable<UIMobPropertyLabel.IconValue>, int>.Clone
	|
	|-RVA: 0x2D8BA18 Offset: 0x2D87A18 VA: 0x2D8BA18
	|-Enumerable.WhereSelectEnumerableIterator<byte, int>.Clone
	|
	|-RVA: 0x2D8BE64 Offset: 0x2D87E64 VA: 0x2D8BE64
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Clone
	|
	|-RVA: 0x2D8C2B0 Offset: 0x2D882B0 VA: 0x2D8C2B0
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Clone
	|
	|-RVA: 0x2D8C6FC Offset: 0x2D886FC VA: 0x2D8C6FC
	|-Enumerable.WhereSelectEnumerableIterator<long, long>.Clone
	|
	|-RVA: 0x2D8CB48 Offset: 0x2D88B48 VA: 0x2D8CB48
	|-Enumerable.WhereSelectEnumerableIterator<long, TimeSpan>.Clone
	|
	|-RVA: 0x2D8CF94 Offset: 0x2D88F94 VA: 0x2D8CF94
	|-Enumerable.WhereSelectEnumerableIterator<MobActionTargetData, float>.Clone
	|
	|-RVA: 0x2D8D428 Offset: 0x2D89428 VA: 0x2D8D428
	|-Enumerable.WhereSelectEnumerableIterator<MobActionTargetData, Vector3>.Clone
	|
	|-RVA: 0x2D8D8C0 Offset: 0x2D898C0 VA: 0x2D8D8C0
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.Clone
	|
	|-RVA: 0x2D8DD10 Offset: 0x2D89D10 VA: 0x2D8DD10
	|-Enumerable.WhereSelectEnumerableIterator<object, byte>.Clone
	|
	|-RVA: 0x2D8E15C Offset: 0x2D8A15C VA: 0x2D8E15C
	|-Enumerable.WhereSelectEnumerableIterator<object, short>.Clone
	|
	|-RVA: 0x2D8E5A8 Offset: 0x2D8A5A8 VA: 0x2D8E5A8
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Clone
	|
	|-RVA: 0x2D8E9F4 Offset: 0x2D8A9F4 VA: 0x2D8E9F4
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Clone
	|
	|-RVA: 0x2D8EE40 Offset: 0x2D8AE40 VA: 0x2D8EE40
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.Clone
	|
	|-RVA: 0x2D8F28C Offset: 0x2D8B28C VA: 0x2D8F28C
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Clone
	|
	|-RVA: 0x2D8F6E4 Offset: 0x2D8B6E4 VA: 0x2D8F6E4
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Clone
	|
	|-RVA: 0x2D8FB30 Offset: 0x2D8BB30 VA: 0x2D8FB30
	|-Enumerable.WhereSelectEnumerableIterator<object, TimeSpan>.Clone
	|
	|-RVA: 0x2D8FF7C Offset: 0x2D8BF7C VA: 0x2D8FF7C
	|-Enumerable.WhereSelectEnumerableIterator<object, Vector3>.Clone
	|
	|-RVA: 0x2D903CC Offset: 0x2D8C3CC VA: 0x2D903CC
	|-Enumerable.WhereSelectEnumerableIterator<float, int>.Clone
	|
	|-RVA: 0x2D90820 Offset: 0x2D8C820 VA: 0x2D90820
	|-Enumerable.WhereSelectEnumerableIterator<TimeSpan, long>.Clone
	|
	|-RVA: 0x2D90C6C Offset: 0x2D8CC6C VA: 0x2D90C6C
	|-Enumerable.WhereSelectEnumerableIterator<TimeSpan, TimeSpan>.Clone
	|
	|-RVA: 0x2D910B8 Offset: 0x2D8D0B8 VA: 0x2D910B8
	|-Enumerable.WhereSelectEnumerableIterator<Vector3, int>.Clone
	|
	|-RVA: 0x2D9152C Offset: 0x2D8D52C VA: 0x2D9152C
	|-Enumerable.WhereSelectEnumerableIterator<Vector3, float>.Clone
	|
	|-RVA: 0x2D919D4 Offset: 0x2D8D9D4 VA: 0x2D919D4
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D803D8 Offset: 0x2D7C3D8 VA: 0x2D803D8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<byte, object>, byte>.Dispose
	|
	|-RVA: 0x2D80830 Offset: 0x2D7C830 VA: 0x2D80830
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<byte, object>, int>.Dispose
	|
	|-RVA: 0x2D80C88 Offset: 0x2D7CC88 VA: 0x2D80C88
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, bool>.Dispose
	|
	|-RVA: 0x2D810E4 Offset: 0x2D7D0E4 VA: 0x2D810E4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, byte>.Dispose
	|
	|-RVA: 0x2D8153C Offset: 0x2D7D53C VA: 0x2D8153C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, short>.Dispose
	|
	|-RVA: 0x2D81994 Offset: 0x2D7D994 VA: 0x2D81994
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, int>.Dispose
	|
	|-RVA: 0x2D81DEC Offset: 0x2D7DDEC VA: 0x2D81DEC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, Int32Enum>.Dispose
	|
	|-RVA: 0x2D82244 Offset: 0x2D7E244 VA: 0x2D82244
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, long>.Dispose
	|
	|-RVA: 0x2D8269C Offset: 0x2D7E69C VA: 0x2D8269C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.Dispose
	|
	|-RVA: 0x2D82B00 Offset: 0x2D7EB00 VA: 0x2D82B00
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, float>.Dispose
	|
	|-RVA: 0x2D82F58 Offset: 0x2D7EF58 VA: 0x2D82F58
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, Vector3>.Dispose
	|
	|-RVA: 0x2D833B4 Offset: 0x2D7F3B4 VA: 0x2D833B4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, EnhanceProperties2>, int>.Dispose
	|
	|-RVA: 0x2D83848 Offset: 0x2D7F848 VA: 0x2D83848
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, bool>.Dispose
	|
	|-RVA: 0x2D83C98 Offset: 0x2D7FC98 VA: 0x2D83C98
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, byte>.Dispose
	|
	|-RVA: 0x2D840E4 Offset: 0x2D800E4 VA: 0x2D840E4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, short>.Dispose
	|
	|-RVA: 0x2D84530 Offset: 0x2D80530 VA: 0x2D84530
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, int>.Dispose
	|
	|-RVA: 0x2D8497C Offset: 0x2D8097C VA: 0x2D8497C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, Int32Enum>.Dispose
	|
	|-RVA: 0x2D84DC8 Offset: 0x2D80DC8 VA: 0x2D84DC8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, long>.Dispose
	|
	|-RVA: 0x2D85214 Offset: 0x2D81214 VA: 0x2D85214
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, object>.Dispose
	|
	|-RVA: 0x2D8566C Offset: 0x2D8166C VA: 0x2D8566C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, float>.Dispose
	|
	|-RVA: 0x2D85AB8 Offset: 0x2D81AB8 VA: 0x2D85AB8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, Vector3>.Dispose
	|
	|-RVA: 0x2D85F08 Offset: 0x2D81F08 VA: 0x2D85F08
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, object>, int>.Dispose
	|
	|-RVA: 0x2D86360 Offset: 0x2D82360 VA: 0x2D86360
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, object>, Int32Enum>.Dispose
	|
	|-RVA: 0x2D867B8 Offset: 0x2D827B8 VA: 0x2D867B8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, bool>.Dispose
	|
	|-RVA: 0x2D86C14 Offset: 0x2D82C14 VA: 0x2D86C14
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, byte>.Dispose
	|
	|-RVA: 0x2D8706C Offset: 0x2D8306C VA: 0x2D8706C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, short>.Dispose
	|
	|-RVA: 0x2D874C4 Offset: 0x2D834C4 VA: 0x2D874C4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, int>.Dispose
	|
	|-RVA: 0x2D8791C Offset: 0x2D8391C VA: 0x2D8791C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, Int32Enum>.Dispose
	|
	|-RVA: 0x2D87D74 Offset: 0x2D83D74 VA: 0x2D87D74
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, long>.Dispose
	|
	|-RVA: 0x2D881CC Offset: 0x2D841CC VA: 0x2D881CC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, object>.Dispose
	|
	|-RVA: 0x2D88630 Offset: 0x2D84630 VA: 0x2D88630
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, float>.Dispose
	|
	|-RVA: 0x2D88A88 Offset: 0x2D84A88 VA: 0x2D88A88
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, Vector3>.Dispose
	|
	|-RVA: 0x2D88EE4 Offset: 0x2D84EE4 VA: 0x2D88EE4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, bool>.Dispose
	|
	|-RVA: 0x2D89340 Offset: 0x2D85340 VA: 0x2D89340
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, byte>.Dispose
	|
	|-RVA: 0x2D89798 Offset: 0x2D85798 VA: 0x2D89798
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, short>.Dispose
	|
	|-RVA: 0x2D89BF0 Offset: 0x2D85BF0 VA: 0x2D89BF0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, int>.Dispose
	|
	|-RVA: 0x2D8A048 Offset: 0x2D86048 VA: 0x2D8A048
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, Int32Enum>.Dispose
	|
	|-RVA: 0x2D8A4A0 Offset: 0x2D864A0 VA: 0x2D8A4A0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, long>.Dispose
	|
	|-RVA: 0x2D8A8F8 Offset: 0x2D868F8 VA: 0x2D8A8F8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, object>.Dispose
	|
	|-RVA: 0x2D8AD5C Offset: 0x2D86D5C VA: 0x2D8AD5C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, float>.Dispose
	|
	|-RVA: 0x2D8B1B4 Offset: 0x2D871B4 VA: 0x2D8B1B4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, Vector3>.Dispose
	|
	|-RVA: 0x2D8B610 Offset: 0x2D87610 VA: 0x2D8B610
	|-Enumerable.WhereSelectEnumerableIterator<Nullable<UIMobPropertyLabel.IconValue>, int>.Dispose
	|
	|-RVA: 0x2D8BA84 Offset: 0x2D87A84 VA: 0x2D8BA84
	|-Enumerable.WhereSelectEnumerableIterator<byte, int>.Dispose
	|
	|-RVA: 0x2D8BED0 Offset: 0x2D87ED0 VA: 0x2D8BED0
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Dispose
	|
	|-RVA: 0x2D8C31C Offset: 0x2D8831C VA: 0x2D8C31C
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x2D8C768 Offset: 0x2D88768 VA: 0x2D8C768
	|-Enumerable.WhereSelectEnumerableIterator<long, long>.Dispose
	|
	|-RVA: 0x2D8CBB4 Offset: 0x2D88BB4 VA: 0x2D8CBB4
	|-Enumerable.WhereSelectEnumerableIterator<long, TimeSpan>.Dispose
	|
	|-RVA: 0x2D8D000 Offset: 0x2D89000 VA: 0x2D8D000
	|-Enumerable.WhereSelectEnumerableIterator<MobActionTargetData, float>.Dispose
	|
	|-RVA: 0x2D8D494 Offset: 0x2D89494 VA: 0x2D8D494
	|-Enumerable.WhereSelectEnumerableIterator<MobActionTargetData, Vector3>.Dispose
	|
	|-RVA: 0x2D8D92C Offset: 0x2D8992C VA: 0x2D8D92C
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.Dispose
	|
	|-RVA: 0x2D8DD7C Offset: 0x2D89D7C VA: 0x2D8DD7C
	|-Enumerable.WhereSelectEnumerableIterator<object, byte>.Dispose
	|
	|-RVA: 0x2D8E1C8 Offset: 0x2D8A1C8 VA: 0x2D8E1C8
	|-Enumerable.WhereSelectEnumerableIterator<object, short>.Dispose
	|
	|-RVA: 0x2D8E614 Offset: 0x2D8A614 VA: 0x2D8E614
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Dispose
	|
	|-RVA: 0x2D8EA60 Offset: 0x2D8AA60 VA: 0x2D8EA60
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Dispose
	|
	|-RVA: 0x2D8EEAC Offset: 0x2D8AEAC VA: 0x2D8EEAC
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.Dispose
	|
	|-RVA: 0x2D8F2F8 Offset: 0x2D8B2F8 VA: 0x2D8F2F8
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Dispose
	|
	|-RVA: 0x2D8F750 Offset: 0x2D8B750 VA: 0x2D8F750
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Dispose
	|
	|-RVA: 0x2D8FB9C Offset: 0x2D8BB9C VA: 0x2D8FB9C
	|-Enumerable.WhereSelectEnumerableIterator<object, TimeSpan>.Dispose
	|
	|-RVA: 0x2D8FFE8 Offset: 0x2D8BFE8 VA: 0x2D8FFE8
	|-Enumerable.WhereSelectEnumerableIterator<object, Vector3>.Dispose
	|
	|-RVA: 0x2D90438 Offset: 0x2D8C438 VA: 0x2D90438
	|-Enumerable.WhereSelectEnumerableIterator<float, int>.Dispose
	|
	|-RVA: 0x2D9088C Offset: 0x2D8C88C VA: 0x2D9088C
	|-Enumerable.WhereSelectEnumerableIterator<TimeSpan, long>.Dispose
	|
	|-RVA: 0x2D90CD8 Offset: 0x2D8CCD8 VA: 0x2D90CD8
	|-Enumerable.WhereSelectEnumerableIterator<TimeSpan, TimeSpan>.Dispose
	|
	|-RVA: 0x2D91124 Offset: 0x2D8D124 VA: 0x2D91124
	|-Enumerable.WhereSelectEnumerableIterator<Vector3, int>.Dispose
	|
	|-RVA: 0x2D91598 Offset: 0x2D8D598 VA: 0x2D91598
	|-Enumerable.WhereSelectEnumerableIterator<Vector3, float>.Dispose
	|
	|-RVA: 0x2D91A98 Offset: 0x2D8DA98 VA: 0x2D91A98
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D804A8 Offset: 0x2D7C4A8 VA: 0x2D804A8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<byte, object>, byte>.MoveNext
	|
	|-RVA: 0x2D80900 Offset: 0x2D7C900 VA: 0x2D80900
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<byte, object>, int>.MoveNext
	|
	|-RVA: 0x2D80D58 Offset: 0x2D7CD58 VA: 0x2D80D58
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, bool>.MoveNext
	|
	|-RVA: 0x2D811B4 Offset: 0x2D7D1B4 VA: 0x2D811B4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, byte>.MoveNext
	|
	|-RVA: 0x2D8160C Offset: 0x2D7D60C VA: 0x2D8160C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, short>.MoveNext
	|
	|-RVA: 0x2D81A64 Offset: 0x2D7DA64 VA: 0x2D81A64
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, int>.MoveNext
	|
	|-RVA: 0x2D81EBC Offset: 0x2D7DEBC VA: 0x2D81EBC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D82314 Offset: 0x2D7E314 VA: 0x2D82314
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, long>.MoveNext
	|
	|-RVA: 0x2D8276C Offset: 0x2D7E76C VA: 0x2D8276C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.MoveNext
	|
	|-RVA: 0x2D82BD0 Offset: 0x2D7EBD0 VA: 0x2D82BD0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, float>.MoveNext
	|
	|-RVA: 0x2D83028 Offset: 0x2D7F028 VA: 0x2D83028
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, Vector3>.MoveNext
	|
	|-RVA: 0x2D83484 Offset: 0x2D7F484 VA: 0x2D83484
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, EnhanceProperties2>, int>.MoveNext
	|
	|-RVA: 0x2D83918 Offset: 0x2D7F918 VA: 0x2D83918
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, bool>.MoveNext
	|
	|-RVA: 0x2D83D68 Offset: 0x2D7FD68 VA: 0x2D83D68
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, byte>.MoveNext
	|
	|-RVA: 0x2D841B4 Offset: 0x2D801B4 VA: 0x2D841B4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, short>.MoveNext
	|
	|-RVA: 0x2D84600 Offset: 0x2D80600 VA: 0x2D84600
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, int>.MoveNext
	|
	|-RVA: 0x2D84A4C Offset: 0x2D80A4C VA: 0x2D84A4C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D84E98 Offset: 0x2D80E98 VA: 0x2D84E98
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, long>.MoveNext
	|
	|-RVA: 0x2D852E4 Offset: 0x2D812E4 VA: 0x2D852E4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, object>.MoveNext
	|
	|-RVA: 0x2D8573C Offset: 0x2D8173C VA: 0x2D8573C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, float>.MoveNext
	|
	|-RVA: 0x2D85B88 Offset: 0x2D81B88 VA: 0x2D85B88
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, Vector3>.MoveNext
	|
	|-RVA: 0x2D85FD8 Offset: 0x2D81FD8 VA: 0x2D85FD8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, object>, int>.MoveNext
	|
	|-RVA: 0x2D86430 Offset: 0x2D82430 VA: 0x2D86430
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, object>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D86888 Offset: 0x2D82888 VA: 0x2D86888
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, bool>.MoveNext
	|
	|-RVA: 0x2D86CE4 Offset: 0x2D82CE4 VA: 0x2D86CE4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, byte>.MoveNext
	|
	|-RVA: 0x2D8713C Offset: 0x2D8313C VA: 0x2D8713C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, short>.MoveNext
	|
	|-RVA: 0x2D87594 Offset: 0x2D83594 VA: 0x2D87594
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, int>.MoveNext
	|
	|-RVA: 0x2D879EC Offset: 0x2D839EC VA: 0x2D879EC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D87E44 Offset: 0x2D83E44 VA: 0x2D87E44
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, long>.MoveNext
	|
	|-RVA: 0x2D8829C Offset: 0x2D8429C VA: 0x2D8829C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, object>.MoveNext
	|
	|-RVA: 0x2D88700 Offset: 0x2D84700 VA: 0x2D88700
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, float>.MoveNext
	|
	|-RVA: 0x2D88B58 Offset: 0x2D84B58 VA: 0x2D88B58
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, Vector3>.MoveNext
	|
	|-RVA: 0x2D88FB4 Offset: 0x2D84FB4 VA: 0x2D88FB4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, bool>.MoveNext
	|
	|-RVA: 0x2D89410 Offset: 0x2D85410 VA: 0x2D89410
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, byte>.MoveNext
	|
	|-RVA: 0x2D89868 Offset: 0x2D85868 VA: 0x2D89868
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, short>.MoveNext
	|
	|-RVA: 0x2D89CC0 Offset: 0x2D85CC0 VA: 0x2D89CC0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, int>.MoveNext
	|
	|-RVA: 0x2D8A118 Offset: 0x2D86118 VA: 0x2D8A118
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D8A570 Offset: 0x2D86570 VA: 0x2D8A570
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, long>.MoveNext
	|
	|-RVA: 0x2D8A9C8 Offset: 0x2D869C8 VA: 0x2D8A9C8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, object>.MoveNext
	|
	|-RVA: 0x2D8AE2C Offset: 0x2D86E2C VA: 0x2D8AE2C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, float>.MoveNext
	|
	|-RVA: 0x2D8B284 Offset: 0x2D87284 VA: 0x2D8B284
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, Vector3>.MoveNext
	|
	|-RVA: 0x2D8B6E0 Offset: 0x2D876E0 VA: 0x2D8B6E0
	|-Enumerable.WhereSelectEnumerableIterator<Nullable<UIMobPropertyLabel.IconValue>, int>.MoveNext
	|
	|-RVA: 0x2D8BB54 Offset: 0x2D87B54 VA: 0x2D8BB54
	|-Enumerable.WhereSelectEnumerableIterator<byte, int>.MoveNext
	|
	|-RVA: 0x2D8BFA0 Offset: 0x2D87FA0 VA: 0x2D8BFA0
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.MoveNext
	|
	|-RVA: 0x2D8C3EC Offset: 0x2D883EC VA: 0x2D8C3EC
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x2D8C838 Offset: 0x2D88838 VA: 0x2D8C838
	|-Enumerable.WhereSelectEnumerableIterator<long, long>.MoveNext
	|
	|-RVA: 0x2D8CC84 Offset: 0x2D88C84 VA: 0x2D8CC84
	|-Enumerable.WhereSelectEnumerableIterator<long, TimeSpan>.MoveNext
	|
	|-RVA: 0x2D8D0D0 Offset: 0x2D890D0 VA: 0x2D8D0D0
	|-Enumerable.WhereSelectEnumerableIterator<MobActionTargetData, float>.MoveNext
	|
	|-RVA: 0x2D8D564 Offset: 0x2D89564 VA: 0x2D8D564
	|-Enumerable.WhereSelectEnumerableIterator<MobActionTargetData, Vector3>.MoveNext
	|
	|-RVA: 0x2D8D9FC Offset: 0x2D899FC VA: 0x2D8D9FC
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.MoveNext
	|
	|-RVA: 0x2D8DE4C Offset: 0x2D89E4C VA: 0x2D8DE4C
	|-Enumerable.WhereSelectEnumerableIterator<object, byte>.MoveNext
	|
	|-RVA: 0x2D8E298 Offset: 0x2D8A298 VA: 0x2D8E298
	|-Enumerable.WhereSelectEnumerableIterator<object, short>.MoveNext
	|
	|-RVA: 0x2D8E6E4 Offset: 0x2D8A6E4 VA: 0x2D8E6E4
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.MoveNext
	|
	|-RVA: 0x2D8EB30 Offset: 0x2D8AB30 VA: 0x2D8EB30
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x2D8EF7C Offset: 0x2D8AF7C VA: 0x2D8EF7C
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.MoveNext
	|
	|-RVA: 0x2D8F3C8 Offset: 0x2D8B3C8 VA: 0x2D8F3C8
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.MoveNext
	|
	|-RVA: 0x2D8F820 Offset: 0x2D8B820 VA: 0x2D8F820
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.MoveNext
	|
	|-RVA: 0x2D8FC6C Offset: 0x2D8BC6C VA: 0x2D8FC6C
	|-Enumerable.WhereSelectEnumerableIterator<object, TimeSpan>.MoveNext
	|
	|-RVA: 0x2D900B8 Offset: 0x2D8C0B8 VA: 0x2D900B8
	|-Enumerable.WhereSelectEnumerableIterator<object, Vector3>.MoveNext
	|
	|-RVA: 0x2D90508 Offset: 0x2D8C508 VA: 0x2D90508
	|-Enumerable.WhereSelectEnumerableIterator<float, int>.MoveNext
	|
	|-RVA: 0x2D9095C Offset: 0x2D8C95C VA: 0x2D9095C
	|-Enumerable.WhereSelectEnumerableIterator<TimeSpan, long>.MoveNext
	|
	|-RVA: 0x2D90DA8 Offset: 0x2D8CDA8 VA: 0x2D90DA8
	|-Enumerable.WhereSelectEnumerableIterator<TimeSpan, TimeSpan>.MoveNext
	|
	|-RVA: 0x2D911F4 Offset: 0x2D8D1F4 VA: 0x2D911F4
	|-Enumerable.WhereSelectEnumerableIterator<Vector3, int>.MoveNext
	|
	|-RVA: 0x2D91668 Offset: 0x2D8D668 VA: 0x2D91668
	|-Enumerable.WhereSelectEnumerableIterator<Vector3, float>.MoveNext
	|
	|-RVA: 0x2D91BB8 Offset: 0x2D8DBB8 VA: 0x2D91BB8
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2683594 Offset: 0x267F594 VA: 0x2683594
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<byte, object>, byte>.Select<int>
	|
	|-RVA: 0x268362C Offset: 0x267F62C VA: 0x268362C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, int>.Select<int>
	|
	|-RVA: 0x26836C4 Offset: 0x267F6C4 VA: 0x26836C4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.Select<bool>
	|
	|-RVA: 0x268375C Offset: 0x267F75C VA: 0x268375C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.Select<byte>
	|
	|-RVA: 0x26837F4 Offset: 0x267F7F4 VA: 0x26837F4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.Select<short>
	|
	|-RVA: 0x268388C Offset: 0x267F88C VA: 0x268388C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.Select<int>
	|
	|-RVA: 0x2683924 Offset: 0x267F924 VA: 0x2683924
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.Select<Int32Enum>
	|
	|-RVA: 0x26839BC Offset: 0x267F9BC VA: 0x26839BC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.Select<long>
	|
	|-RVA: 0x2683A54 Offset: 0x267FA54 VA: 0x2683A54
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.Select<object>
	|
	|-RVA: 0x2683AEC Offset: 0x267FAEC VA: 0x2683AEC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.Select<float>
	|
	|-RVA: 0x2683B84 Offset: 0x267FB84 VA: 0x2683B84
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.Select<Vector3>
	|
	|-RVA: 0x2683C1C Offset: 0x267FC1C VA: 0x2683C1C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, EnhanceProperties2>, int>.Select<int>
	|
	|-RVA: 0x2683CB4 Offset: 0x267FCB4 VA: 0x2683CB4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, int>.Select<int>
	|
	|-RVA: 0x2683D4C Offset: 0x267FD4C VA: 0x2683D4C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, Int32Enum>.Select<int>
	|
	|-RVA: 0x2683DE4 Offset: 0x267FDE4 VA: 0x2683DE4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, object>.Select<bool>
	|
	|-RVA: 0x2683E7C Offset: 0x267FE7C VA: 0x2683E7C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, object>.Select<byte>
	|
	|-RVA: 0x2683F14 Offset: 0x267FF14 VA: 0x2683F14
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, object>.Select<short>
	|
	|-RVA: 0x2683FAC Offset: 0x267FFAC VA: 0x2683FAC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, object>.Select<int>
	|
	|-RVA: 0x2684044 Offset: 0x2680044 VA: 0x2684044
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, object>.Select<Int32Enum>
	|
	|-RVA: 0x26840DC Offset: 0x26800DC VA: 0x26840DC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, object>.Select<long>
	|
	|-RVA: 0x2684174 Offset: 0x2680174 VA: 0x2684174
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, object>.Select<object>
	|
	|-RVA: 0x268420C Offset: 0x268020C VA: 0x268420C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, object>.Select<float>
	|
	|-RVA: 0x26842A4 Offset: 0x26802A4 VA: 0x26842A4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, object>.Select<Vector3>
	|
	|-RVA: 0x268433C Offset: 0x268033C VA: 0x268433C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, object>, Int32Enum>.Select<int>
	|
	|-RVA: 0x26843D4 Offset: 0x26803D4 VA: 0x26843D4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, object>.Select<bool>
	|
	|-RVA: 0x268446C Offset: 0x268046C VA: 0x268446C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, object>.Select<byte>
	|
	|-RVA: 0x2684504 Offset: 0x2680504 VA: 0x2684504
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, object>.Select<short>
	|
	|-RVA: 0x268459C Offset: 0x268059C VA: 0x268459C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, object>.Select<int>
	|
	|-RVA: 0x2684634 Offset: 0x2680634 VA: 0x2684634
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, object>.Select<Int32Enum>
	|
	|-RVA: 0x26846CC Offset: 0x26806CC VA: 0x26846CC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, object>.Select<long>
	|
	|-RVA: 0x2684764 Offset: 0x2680764 VA: 0x2684764
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, object>.Select<object>
	|
	|-RVA: 0x26847FC Offset: 0x26807FC VA: 0x26847FC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, object>.Select<float>
	|
	|-RVA: 0x2684894 Offset: 0x2680894 VA: 0x2684894
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, object>.Select<Vector3>
	|
	|-RVA: 0x268492C Offset: 0x268092C VA: 0x268492C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, object>.Select<bool>
	|
	|-RVA: 0x26849C4 Offset: 0x26809C4 VA: 0x26849C4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, object>.Select<byte>
	|
	|-RVA: 0x2684A5C Offset: 0x2680A5C VA: 0x2684A5C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, object>.Select<short>
	|
	|-RVA: 0x2684AF4 Offset: 0x2680AF4 VA: 0x2684AF4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, object>.Select<int>
	|
	|-RVA: 0x2684B8C Offset: 0x2680B8C VA: 0x2684B8C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, object>.Select<Int32Enum>
	|
	|-RVA: 0x2684C24 Offset: 0x2680C24 VA: 0x2684C24
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, object>.Select<long>
	|
	|-RVA: 0x2684CBC Offset: 0x2680CBC VA: 0x2684CBC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, object>.Select<object>
	|
	|-RVA: 0x2684D54 Offset: 0x2680D54 VA: 0x2684D54
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, object>.Select<float>
	|
	|-RVA: 0x2684DEC Offset: 0x2680DEC VA: 0x2684DEC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, object>.Select<Vector3>
	|
	|-RVA: 0x2684E84 Offset: 0x2680E84 VA: 0x2684E84
	|-Enumerable.WhereSelectEnumerableIterator<Nullable<UIMobPropertyLabel.IconValue>, int>.Select<int>
	|
	|-RVA: 0x2684F1C Offset: 0x2680F1C VA: 0x2684F1C
	|-Enumerable.WhereSelectEnumerableIterator<byte, int>.Select<int>
	|
	|-RVA: 0x2684FB4 Offset: 0x2680FB4 VA: 0x2684FB4
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Select<int>
	|
	|-RVA: 0x268504C Offset: 0x268104C VA: 0x268504C
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Select<int>
	|
	|-RVA: 0x26850E4 Offset: 0x26810E4 VA: 0x26850E4
	|-Enumerable.WhereSelectEnumerableIterator<long, TimeSpan>.Select<long>
	|
	|-RVA: 0x268517C Offset: 0x268117C VA: 0x268517C
	|-Enumerable.WhereSelectEnumerableIterator<MobActionTargetData, Vector3>.Select<float>
	|
	|-RVA: 0x2685214 Offset: 0x2681214 VA: 0x2685214
	|-Enumerable.WhereSelectEnumerableIterator<object, byte>.Select<int>
	|
	|-RVA: 0x26852AC Offset: 0x26812AC VA: 0x26852AC
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Select<int>
	|
	|-RVA: 0x2685344 Offset: 0x2681344 VA: 0x2685344
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Select<int>
	|
	|-RVA: 0x26853DC Offset: 0x26813DC VA: 0x26853DC
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.Select<TimeSpan>
	|
	|-RVA: 0x2685474 Offset: 0x2681474 VA: 0x2685474
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<bool>
	|
	|-RVA: 0x268550C Offset: 0x268150C VA: 0x268550C
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<byte>
	|
	|-RVA: 0x26855A4 Offset: 0x26815A4 VA: 0x26855A4
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<short>
	|
	|-RVA: 0x268563C Offset: 0x268163C VA: 0x268563C
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<int>
	|
	|-RVA: 0x26856D4 Offset: 0x26816D4 VA: 0x26856D4
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<Int32Enum>
	|
	|-RVA: 0x268576C Offset: 0x268176C VA: 0x268576C
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<long>
	|
	|-RVA: 0x2685804 Offset: 0x2681804 VA: 0x2685804
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<object>
	|
	|-RVA: 0x268589C Offset: 0x268189C VA: 0x268589C
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<float>
	|
	|-RVA: 0x2685934 Offset: 0x2681934 VA: 0x2685934
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<Vector3>
	|
	|-RVA: 0x26859CC Offset: 0x26819CC VA: 0x26859CC
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Select<int>
	|
	|-RVA: 0x2685A64 Offset: 0x2681A64 VA: 0x2685A64
	|-Enumerable.WhereSelectEnumerableIterator<object, Vector3>.Select<float>
	|
	|-RVA: 0x2685AFC Offset: 0x2681AFC VA: 0x2685AFC
	|-Enumerable.WhereSelectEnumerableIterator<float, int>.Select<int>
	|
	|-RVA: 0x2685B94 Offset: 0x2681B94 VA: 0x2685B94
	|-Enumerable.WhereSelectEnumerableIterator<TimeSpan, long>.Select<TimeSpan>
	|
	|-RVA: 0x2685C2C Offset: 0x2681C2C VA: 0x2685C2C
	|-Enumerable.WhereSelectEnumerableIterator<Vector3, float>.Select<int>
	|
	|-RVA: 0x2685CC4 Offset: 0x2681CC4 VA: 0x2685CC4
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D806F4 Offset: 0x2D7C6F4 VA: 0x2D806F4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<byte, object>, byte>.Where
	|
	|-RVA: 0x2D80B4C Offset: 0x2D7CB4C VA: 0x2D80B4C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<byte, object>, int>.Where
	|
	|-RVA: 0x2D80FA8 Offset: 0x2D7CFA8 VA: 0x2D80FA8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, bool>.Where
	|
	|-RVA: 0x2D81400 Offset: 0x2D7D400 VA: 0x2D81400
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, byte>.Where
	|
	|-RVA: 0x2D81858 Offset: 0x2D7D858 VA: 0x2D81858
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, short>.Where
	|
	|-RVA: 0x2D81CB0 Offset: 0x2D7DCB0 VA: 0x2D81CB0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, int>.Where
	|
	|-RVA: 0x2D82108 Offset: 0x2D7E108 VA: 0x2D82108
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, Int32Enum>.Where
	|
	|-RVA: 0x2D82560 Offset: 0x2D7E560 VA: 0x2D82560
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, long>.Where
	|
	|-RVA: 0x2D829C4 Offset: 0x2D7E9C4 VA: 0x2D829C4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.Where
	|
	|-RVA: 0x2D82E1C Offset: 0x2D7EE1C VA: 0x2D82E1C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, float>.Where
	|
	|-RVA: 0x2D83278 Offset: 0x2D7F278 VA: 0x2D83278
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, Vector3>.Where
	|
	|-RVA: 0x2D8370C Offset: 0x2D7F70C VA: 0x2D8370C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, EnhanceProperties2>, int>.Where
	|
	|-RVA: 0x2D83B5C Offset: 0x2D7FB5C VA: 0x2D83B5C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, bool>.Where
	|
	|-RVA: 0x2D83FA8 Offset: 0x2D7FFA8 VA: 0x2D83FA8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, byte>.Where
	|
	|-RVA: 0x2D843F4 Offset: 0x2D803F4 VA: 0x2D843F4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, short>.Where
	|
	|-RVA: 0x2D84840 Offset: 0x2D80840 VA: 0x2D84840
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, int>.Where
	|
	|-RVA: 0x2D84C8C Offset: 0x2D80C8C VA: 0x2D84C8C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, Int32Enum>.Where
	|
	|-RVA: 0x2D850D8 Offset: 0x2D810D8 VA: 0x2D850D8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, long>.Where
	|
	|-RVA: 0x2D85530 Offset: 0x2D81530 VA: 0x2D85530
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, object>.Where
	|
	|-RVA: 0x2D8597C Offset: 0x2D8197C VA: 0x2D8597C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, float>.Where
	|
	|-RVA: 0x2D85DCC Offset: 0x2D81DCC VA: 0x2D85DCC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, int>, Vector3>.Where
	|
	|-RVA: 0x2D86224 Offset: 0x2D82224 VA: 0x2D86224
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, object>, int>.Where
	|
	|-RVA: 0x2D8667C Offset: 0x2D8267C VA: 0x2D8667C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<Int32Enum, object>, Int32Enum>.Where
	|
	|-RVA: 0x2D86AD8 Offset: 0x2D82AD8 VA: 0x2D86AD8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, bool>.Where
	|
	|-RVA: 0x2D86F30 Offset: 0x2D82F30 VA: 0x2D86F30
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, byte>.Where
	|
	|-RVA: 0x2D87388 Offset: 0x2D83388 VA: 0x2D87388
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, short>.Where
	|
	|-RVA: 0x2D877E0 Offset: 0x2D837E0 VA: 0x2D877E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, int>.Where
	|
	|-RVA: 0x2D87C38 Offset: 0x2D83C38 VA: 0x2D87C38
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, Int32Enum>.Where
	|
	|-RVA: 0x2D88090 Offset: 0x2D84090 VA: 0x2D88090
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, long>.Where
	|
	|-RVA: 0x2D884F4 Offset: 0x2D844F4 VA: 0x2D884F4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, object>.Where
	|
	|-RVA: 0x2D8894C Offset: 0x2D8494C VA: 0x2D8894C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, float>.Where
	|
	|-RVA: 0x2D88DA8 Offset: 0x2D84DA8 VA: 0x2D88DA8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, int>, Vector3>.Where
	|
	|-RVA: 0x2D89204 Offset: 0x2D85204 VA: 0x2D89204
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, bool>.Where
	|
	|-RVA: 0x2D8965C Offset: 0x2D8565C VA: 0x2D8965C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, byte>.Where
	|
	|-RVA: 0x2D89AB4 Offset: 0x2D85AB4 VA: 0x2D89AB4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, short>.Where
	|
	|-RVA: 0x2D89F0C Offset: 0x2D85F0C VA: 0x2D89F0C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, int>.Where
	|
	|-RVA: 0x2D8A364 Offset: 0x2D86364 VA: 0x2D8A364
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, Int32Enum>.Where
	|
	|-RVA: 0x2D8A7BC Offset: 0x2D867BC VA: 0x2D8A7BC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, long>.Where
	|
	|-RVA: 0x2D8AC20 Offset: 0x2D86C20 VA: 0x2D8AC20
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, object>.Where
	|
	|-RVA: 0x2D8B078 Offset: 0x2D87078 VA: 0x2D8B078
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, float>.Where
	|
	|-RVA: 0x2D8B4D4 Offset: 0x2D874D4 VA: 0x2D8B4D4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, float>, Vector3>.Where
	|
	|-RVA: 0x2D8B948 Offset: 0x2D87948 VA: 0x2D8B948
	|-Enumerable.WhereSelectEnumerableIterator<Nullable<UIMobPropertyLabel.IconValue>, int>.Where
	|
	|-RVA: 0x2D8BD94 Offset: 0x2D87D94 VA: 0x2D8BD94
	|-Enumerable.WhereSelectEnumerableIterator<byte, int>.Where
	|
	|-RVA: 0x2D8C1E0 Offset: 0x2D881E0 VA: 0x2D8C1E0
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Where
	|
	|-RVA: 0x2D8C62C Offset: 0x2D8862C VA: 0x2D8C62C
	|-Enumerable.WhereSelectEnumerableIterator<Int32Enum, int>.Where
	|
	|-RVA: 0x2D8CA78 Offset: 0x2D88A78 VA: 0x2D8CA78
	|-Enumerable.WhereSelectEnumerableIterator<long, long>.Where
	|
	|-RVA: 0x2D8CEC4 Offset: 0x2D88EC4 VA: 0x2D8CEC4
	|-Enumerable.WhereSelectEnumerableIterator<long, TimeSpan>.Where
	|
	|-RVA: 0x2D8D358 Offset: 0x2D89358 VA: 0x2D8D358
	|-Enumerable.WhereSelectEnumerableIterator<MobActionTargetData, float>.Where
	|
	|-RVA: 0x2D8D7F0 Offset: 0x2D897F0 VA: 0x2D8D7F0
	|-Enumerable.WhereSelectEnumerableIterator<MobActionTargetData, Vector3>.Where
	|
	|-RVA: 0x2D8DC40 Offset: 0x2D89C40 VA: 0x2D8DC40
	|-Enumerable.WhereSelectEnumerableIterator<object, bool>.Where
	|
	|-RVA: 0x2D8E08C Offset: 0x2D8A08C VA: 0x2D8E08C
	|-Enumerable.WhereSelectEnumerableIterator<object, byte>.Where
	|
	|-RVA: 0x2D8E4D8 Offset: 0x2D8A4D8 VA: 0x2D8E4D8
	|-Enumerable.WhereSelectEnumerableIterator<object, short>.Where
	|
	|-RVA: 0x2D8E924 Offset: 0x2D8A924 VA: 0x2D8E924
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Where
	|
	|-RVA: 0x2D8ED70 Offset: 0x2D8AD70 VA: 0x2D8ED70
	|-Enumerable.WhereSelectEnumerableIterator<object, Int32Enum>.Where
	|
	|-RVA: 0x2D8F1BC Offset: 0x2D8B1BC VA: 0x2D8F1BC
	|-Enumerable.WhereSelectEnumerableIterator<object, long>.Where
	|
	|-RVA: 0x2D8F614 Offset: 0x2D8B614 VA: 0x2D8F614
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Where
	|
	|-RVA: 0x2D8FA60 Offset: 0x2D8BA60 VA: 0x2D8FA60
	|-Enumerable.WhereSelectEnumerableIterator<object, float>.Where
	|
	|-RVA: 0x2D8FEAC Offset: 0x2D8BEAC VA: 0x2D8FEAC
	|-Enumerable.WhereSelectEnumerableIterator<object, TimeSpan>.Where
	|
	|-RVA: 0x2D902FC Offset: 0x2D8C2FC VA: 0x2D902FC
	|-Enumerable.WhereSelectEnumerableIterator<object, Vector3>.Where
	|
	|-RVA: 0x2D90750 Offset: 0x2D8C750 VA: 0x2D90750
	|-Enumerable.WhereSelectEnumerableIterator<float, int>.Where
	|
	|-RVA: 0x2D90B9C Offset: 0x2D8CB9C VA: 0x2D90B9C
	|-Enumerable.WhereSelectEnumerableIterator<TimeSpan, long>.Where
	|
	|-RVA: 0x2D90FE8 Offset: 0x2D8CFE8 VA: 0x2D90FE8
	|-Enumerable.WhereSelectEnumerableIterator<TimeSpan, TimeSpan>.Where
	|
	|-RVA: 0x2D9145C Offset: 0x2D8D45C VA: 0x2D9145C
	|-Enumerable.WhereSelectEnumerableIterator<Vector3, int>.Where
	|
	|-RVA: 0x2D918D0 Offset: 0x2D8D8D0 VA: 0x2D918D0
	|-Enumerable.WhereSelectEnumerableIterator<Vector3, float>.Where
	|
	|-RVA: 0x2D9202C Offset: 0x2D8E02C VA: 0x2D9202C
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Where
	*/
}
