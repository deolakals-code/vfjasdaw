// Assembly: System.Core.dll
// Namespace: 
private class Enumerable.WhereEnumerableIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 15184
{
	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private IEnumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6E7E0 Offset: 0x2D6A7E0 VA: 0x2D6E7E0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<byte, BlackKnightCristaProperty>>..ctor
	|
	|-RVA: 0x2D6EBF4 Offset: 0x2D6ABF4 VA: 0x2D6EBF4
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<byte, byte>>..ctor
	|
	|-RVA: 0x2D6F008 Offset: 0x2D6B008 VA: 0x2D6F008
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, short>>..ctor
	|
	|-RVA: 0x2D6F41C Offset: 0x2D6B41C VA: 0x2D6F41C
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2D6F848 Offset: 0x2D6B848 VA: 0x2D6F848
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, EnhanceProperties2>>..ctor
	|
	|-RVA: 0x2D6FCA4 Offset: 0x2D6BCA4 VA: 0x2D6FCA4
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2D700B8 Offset: 0x2D6C0B8 VA: 0x2D700B8
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x2D704E4 Offset: 0x2D6C4E4 VA: 0x2D704E4
	|-Enumerable.WhereEnumerableIterator<Nullable<UIMobPropertyLabel.IconValue>>..ctor
	|
	|-RVA: 0x2D70928 Offset: 0x2D6C928 VA: 0x2D70928
	|-Enumerable.WhereEnumerableIterator<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2D70D3C Offset: 0x2D6CD3C VA: 0x2D70D3C
	|-Enumerable.WhereEnumerableIterator<bool>..ctor
	|
	|-RVA: 0x2D71154 Offset: 0x2D6D154 VA: 0x2D71154
	|-Enumerable.WhereEnumerableIterator<byte>..ctor
	|
	|-RVA: 0x2D71568 Offset: 0x2D6D568 VA: 0x2D71568
	|-Enumerable.WhereEnumerableIterator<short>..ctor
	|
	|-RVA: 0x2D7197C Offset: 0x2D6D97C VA: 0x2D7197C
	|-Enumerable.WhereEnumerableIterator<int>..ctor
	|
	|-RVA: 0x2D71D90 Offset: 0x2D6DD90 VA: 0x2D71D90
	|-Enumerable.WhereEnumerableIterator<Int32Enum>..ctor
	|
	|-RVA: 0x2D721A4 Offset: 0x2D6E1A4 VA: 0x2D721A4
	|-Enumerable.WhereEnumerableIterator<long>..ctor
	|
	|-RVA: 0x2D725B8 Offset: 0x2D6E5B8 VA: 0x2D725B8
	|-Enumerable.WhereEnumerableIterator<object>..ctor
	|
	|-RVA: 0x2D729D8 Offset: 0x2D6E9D8 VA: 0x2D729D8
	|-Enumerable.WhereEnumerableIterator<float>..ctor
	|
	|-RVA: 0x2D72DF0 Offset: 0x2D6EDF0 VA: 0x2D72DF0
	|-Enumerable.WhereEnumerableIterator<SkillIdData>..ctor
	|
	|-RVA: 0x2D73204 Offset: 0x2D6F204 VA: 0x2D73204
	|-Enumerable.WhereEnumerableIterator<TimeSpan>..ctor
	|
	|-RVA: 0x2D73618 Offset: 0x2D6F618 VA: 0x2D73618
	|-Enumerable.WhereEnumerableIterator<Vector3>..ctor
	|
	|-RVA: 0x2D73A44 Offset: 0x2D6FA44 VA: 0x2D73A44
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2D74120 Offset: 0x2D70120 VA: 0x2D74120
	|-Enumerable.WhereEnumerableIterator<HouseRecipeManager.RecipeData>..ctor
	|
	|-RVA: 0x2D7457C Offset: 0x2D7057C VA: 0x2D7457C
	|-Enumerable.WhereEnumerableIterator<KadarElexioBuf.SkillIdData>..ctor
	|
	|-RVA: 0x2D74990 Offset: 0x2D70990 VA: 0x2D74990
	|-Enumerable.WhereEnumerableIterator<MobaRoomData.MobaAbilityMasterData>..ctor
	|
	|-RVA: 0x2D74DAC Offset: 0x2D70DAC VA: 0x2D74DAC
	|-Enumerable.WhereEnumerableIterator<TrophyManager.TrophyData>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6E82C Offset: 0x2D6A82C VA: 0x2D6E82C
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<byte, BlackKnightCristaProperty>>.Clone
	|
	|-RVA: 0x2D6EC40 Offset: 0x2D6AC40 VA: 0x2D6EC40
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<byte, byte>>.Clone
	|
	|-RVA: 0x2D6F054 Offset: 0x2D6B054 VA: 0x2D6F054
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, short>>.Clone
	|
	|-RVA: 0x2D6F468 Offset: 0x2D6B468 VA: 0x2D6F468
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x2D6F894 Offset: 0x2D6B894 VA: 0x2D6F894
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.Clone
	|
	|-RVA: 0x2D6FCF0 Offset: 0x2D6BCF0 VA: 0x2D6FCF0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, int>>.Clone
	|
	|-RVA: 0x2D70104 Offset: 0x2D6C104 VA: 0x2D70104
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, object>>.Clone
	|
	|-RVA: 0x2D70530 Offset: 0x2D6C530 VA: 0x2D70530
	|-Enumerable.WhereEnumerableIterator<Nullable<UIMobPropertyLabel.IconValue>>.Clone
	|
	|-RVA: 0x2D70974 Offset: 0x2D6C974 VA: 0x2D70974
	|-Enumerable.WhereEnumerableIterator<ValueTuple<int, int>>.Clone
	|
	|-RVA: 0x2D70D88 Offset: 0x2D6CD88 VA: 0x2D70D88
	|-Enumerable.WhereEnumerableIterator<bool>.Clone
	|
	|-RVA: 0x2D711A0 Offset: 0x2D6D1A0 VA: 0x2D711A0
	|-Enumerable.WhereEnumerableIterator<byte>.Clone
	|
	|-RVA: 0x2D715B4 Offset: 0x2D6D5B4 VA: 0x2D715B4
	|-Enumerable.WhereEnumerableIterator<short>.Clone
	|
	|-RVA: 0x2D719C8 Offset: 0x2D6D9C8 VA: 0x2D719C8
	|-Enumerable.WhereEnumerableIterator<int>.Clone
	|
	|-RVA: 0x2D71DDC Offset: 0x2D6DDDC VA: 0x2D71DDC
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Clone
	|
	|-RVA: 0x2D721F0 Offset: 0x2D6E1F0 VA: 0x2D721F0
	|-Enumerable.WhereEnumerableIterator<long>.Clone
	|
	|-RVA: 0x2D72604 Offset: 0x2D6E604 VA: 0x2D72604
	|-Enumerable.WhereEnumerableIterator<object>.Clone
	|
	|-RVA: 0x2D72A24 Offset: 0x2D6EA24 VA: 0x2D72A24
	|-Enumerable.WhereEnumerableIterator<float>.Clone
	|
	|-RVA: 0x2D72E3C Offset: 0x2D6EE3C VA: 0x2D72E3C
	|-Enumerable.WhereEnumerableIterator<SkillIdData>.Clone
	|
	|-RVA: 0x2D73250 Offset: 0x2D6F250 VA: 0x2D73250
	|-Enumerable.WhereEnumerableIterator<TimeSpan>.Clone
	|
	|-RVA: 0x2D73664 Offset: 0x2D6F664 VA: 0x2D73664
	|-Enumerable.WhereEnumerableIterator<Vector3>.Clone
	|
	|-RVA: 0x2D73ABC Offset: 0x2D6FABC VA: 0x2D73ABC
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>.Clone
	|
	|-RVA: 0x2D7416C Offset: 0x2D7016C VA: 0x2D7416C
	|-Enumerable.WhereEnumerableIterator<HouseRecipeManager.RecipeData>.Clone
	|
	|-RVA: 0x2D745C8 Offset: 0x2D705C8 VA: 0x2D745C8
	|-Enumerable.WhereEnumerableIterator<KadarElexioBuf.SkillIdData>.Clone
	|
	|-RVA: 0x2D749DC Offset: 0x2D709DC VA: 0x2D749DC
	|-Enumerable.WhereEnumerableIterator<MobaRoomData.MobaAbilityMasterData>.Clone
	|
	|-RVA: 0x2D74DF8 Offset: 0x2D70DF8 VA: 0x2D74DF8
	|-Enumerable.WhereEnumerableIterator<TrophyManager.TrophyData>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6E888 Offset: 0x2D6A888 VA: 0x2D6E888
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<byte, BlackKnightCristaProperty>>.Dispose
	|
	|-RVA: 0x2D6EC9C Offset: 0x2D6AC9C VA: 0x2D6EC9C
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<byte, byte>>.Dispose
	|
	|-RVA: 0x2D6F0B0 Offset: 0x2D6B0B0 VA: 0x2D6F0B0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, short>>.Dispose
	|
	|-RVA: 0x2D6F4C4 Offset: 0x2D6B4C4 VA: 0x2D6F4C4
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x2D6F8F0 Offset: 0x2D6B8F0 VA: 0x2D6F8F0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.Dispose
	|
	|-RVA: 0x2D6FD4C Offset: 0x2D6BD4C VA: 0x2D6FD4C
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x2D70160 Offset: 0x2D6C160 VA: 0x2D70160
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, object>>.Dispose
	|
	|-RVA: 0x2D7058C Offset: 0x2D6C58C VA: 0x2D7058C
	|-Enumerable.WhereEnumerableIterator<Nullable<UIMobPropertyLabel.IconValue>>.Dispose
	|
	|-RVA: 0x2D709D0 Offset: 0x2D6C9D0 VA: 0x2D709D0
	|-Enumerable.WhereEnumerableIterator<ValueTuple<int, int>>.Dispose
	|
	|-RVA: 0x2D70DE4 Offset: 0x2D6CDE4 VA: 0x2D70DE4
	|-Enumerable.WhereEnumerableIterator<bool>.Dispose
	|
	|-RVA: 0x2D711FC Offset: 0x2D6D1FC VA: 0x2D711FC
	|-Enumerable.WhereEnumerableIterator<byte>.Dispose
	|
	|-RVA: 0x2D71610 Offset: 0x2D6D610 VA: 0x2D71610
	|-Enumerable.WhereEnumerableIterator<short>.Dispose
	|
	|-RVA: 0x2D71A24 Offset: 0x2D6DA24 VA: 0x2D71A24
	|-Enumerable.WhereEnumerableIterator<int>.Dispose
	|
	|-RVA: 0x2D71E38 Offset: 0x2D6DE38 VA: 0x2D71E38
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Dispose
	|
	|-RVA: 0x2D7224C Offset: 0x2D6E24C VA: 0x2D7224C
	|-Enumerable.WhereEnumerableIterator<long>.Dispose
	|
	|-RVA: 0x2D72660 Offset: 0x2D6E660 VA: 0x2D72660
	|-Enumerable.WhereEnumerableIterator<object>.Dispose
	|
	|-RVA: 0x2D72A80 Offset: 0x2D6EA80 VA: 0x2D72A80
	|-Enumerable.WhereEnumerableIterator<float>.Dispose
	|
	|-RVA: 0x2D72E98 Offset: 0x2D6EE98 VA: 0x2D72E98
	|-Enumerable.WhereEnumerableIterator<SkillIdData>.Dispose
	|
	|-RVA: 0x2D732AC Offset: 0x2D6F2AC VA: 0x2D732AC
	|-Enumerable.WhereEnumerableIterator<TimeSpan>.Dispose
	|
	|-RVA: 0x2D736C0 Offset: 0x2D6F6C0 VA: 0x2D736C0
	|-Enumerable.WhereEnumerableIterator<Vector3>.Dispose
	|
	|-RVA: 0x2D73B54 Offset: 0x2D6FB54 VA: 0x2D73B54
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>.Dispose
	|
	|-RVA: 0x2D741C8 Offset: 0x2D701C8 VA: 0x2D741C8
	|-Enumerable.WhereEnumerableIterator<HouseRecipeManager.RecipeData>.Dispose
	|
	|-RVA: 0x2D74624 Offset: 0x2D70624 VA: 0x2D74624
	|-Enumerable.WhereEnumerableIterator<KadarElexioBuf.SkillIdData>.Dispose
	|
	|-RVA: 0x2D74A38 Offset: 0x2D70A38 VA: 0x2D74A38
	|-Enumerable.WhereEnumerableIterator<MobaRoomData.MobaAbilityMasterData>.Dispose
	|
	|-RVA: 0x2D74E54 Offset: 0x2D70E54 VA: 0x2D74E54
	|-Enumerable.WhereEnumerableIterator<TrophyManager.TrophyData>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6E958 Offset: 0x2D6A958 VA: 0x2D6E958
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<byte, BlackKnightCristaProperty>>.MoveNext
	|
	|-RVA: 0x2D6ED6C Offset: 0x2D6AD6C VA: 0x2D6ED6C
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<byte, byte>>.MoveNext
	|
	|-RVA: 0x2D6F180 Offset: 0x2D6B180 VA: 0x2D6F180
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, short>>.MoveNext
	|
	|-RVA: 0x2D6F594 Offset: 0x2D6B594 VA: 0x2D6F594
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x2D6F9C0 Offset: 0x2D6B9C0 VA: 0x2D6F9C0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.MoveNext
	|
	|-RVA: 0x2D6FE1C Offset: 0x2D6BE1C VA: 0x2D6FE1C
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x2D70230 Offset: 0x2D6C230 VA: 0x2D70230
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, object>>.MoveNext
	|
	|-RVA: 0x2D7065C Offset: 0x2D6C65C VA: 0x2D7065C
	|-Enumerable.WhereEnumerableIterator<Nullable<UIMobPropertyLabel.IconValue>>.MoveNext
	|
	|-RVA: 0x2D70AA0 Offset: 0x2D6CAA0 VA: 0x2D70AA0
	|-Enumerable.WhereEnumerableIterator<ValueTuple<int, int>>.MoveNext
	|
	|-RVA: 0x2D70EB4 Offset: 0x2D6CEB4 VA: 0x2D70EB4
	|-Enumerable.WhereEnumerableIterator<bool>.MoveNext
	|
	|-RVA: 0x2D712CC Offset: 0x2D6D2CC VA: 0x2D712CC
	|-Enumerable.WhereEnumerableIterator<byte>.MoveNext
	|
	|-RVA: 0x2D716E0 Offset: 0x2D6D6E0 VA: 0x2D716E0
	|-Enumerable.WhereEnumerableIterator<short>.MoveNext
	|
	|-RVA: 0x2D71AF4 Offset: 0x2D6DAF4 VA: 0x2D71AF4
	|-Enumerable.WhereEnumerableIterator<int>.MoveNext
	|
	|-RVA: 0x2D71F08 Offset: 0x2D6DF08 VA: 0x2D71F08
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x2D7231C Offset: 0x2D6E31C VA: 0x2D7231C
	|-Enumerable.WhereEnumerableIterator<long>.MoveNext
	|
	|-RVA: 0x2D72730 Offset: 0x2D6E730 VA: 0x2D72730
	|-Enumerable.WhereEnumerableIterator<object>.MoveNext
	|
	|-RVA: 0x2D72B50 Offset: 0x2D6EB50 VA: 0x2D72B50
	|-Enumerable.WhereEnumerableIterator<float>.MoveNext
	|
	|-RVA: 0x2D72F68 Offset: 0x2D6EF68 VA: 0x2D72F68
	|-Enumerable.WhereEnumerableIterator<SkillIdData>.MoveNext
	|
	|-RVA: 0x2D7337C Offset: 0x2D6F37C VA: 0x2D7337C
	|-Enumerable.WhereEnumerableIterator<TimeSpan>.MoveNext
	|
	|-RVA: 0x2D73790 Offset: 0x2D6F790 VA: 0x2D73790
	|-Enumerable.WhereEnumerableIterator<Vector3>.MoveNext
	|
	|-RVA: 0x2D73C74 Offset: 0x2D6FC74 VA: 0x2D73C74
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x2D74298 Offset: 0x2D70298 VA: 0x2D74298
	|-Enumerable.WhereEnumerableIterator<HouseRecipeManager.RecipeData>.MoveNext
	|
	|-RVA: 0x2D746F4 Offset: 0x2D706F4 VA: 0x2D746F4
	|-Enumerable.WhereEnumerableIterator<KadarElexioBuf.SkillIdData>.MoveNext
	|
	|-RVA: 0x2D74B08 Offset: 0x2D70B08 VA: 0x2D74B08
	|-Enumerable.WhereEnumerableIterator<MobaRoomData.MobaAbilityMasterData>.MoveNext
	|
	|-RVA: 0x2D74F24 Offset: 0x2D70F24 VA: 0x2D74F24
	|-Enumerable.WhereEnumerableIterator<TrophyManager.TrophyData>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267F818 Offset: 0x267B818 VA: 0x267F818
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, object>>.Select<int>
	|
	|-RVA: 0x267F88C Offset: 0x267B88C VA: 0x267F88C
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, object>>.Select<object>
	|
	|-RVA: 0x267F900 Offset: 0x267B900 VA: 0x267F900
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.Select<int>
	|
	|-RVA: 0x267F974 Offset: 0x267B974 VA: 0x267F974
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, int>>.Select<int>
	|
	|-RVA: 0x267F9E8 Offset: 0x267B9E8 VA: 0x267F9E8
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, int>>.Select<Int32Enum>
	|
	|-RVA: 0x267FA5C Offset: 0x267BA5C VA: 0x267FA5C
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, int>>.Select<object>
	|
	|-RVA: 0x267FAD0 Offset: 0x267BAD0 VA: 0x267FAD0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, object>>.Select<Int32Enum>
	|
	|-RVA: 0x267FB44 Offset: 0x267BB44 VA: 0x267FB44
	|-Enumerable.WhereEnumerableIterator<Nullable<UIMobPropertyLabel.IconValue>>.Select<int>
	|
	|-RVA: 0x267FBB8 Offset: 0x267BBB8 VA: 0x267FBB8
	|-Enumerable.WhereEnumerableIterator<byte>.Select<int>
	|
	|-RVA: 0x267FC2C Offset: 0x267BC2C VA: 0x267FC2C
	|-Enumerable.WhereEnumerableIterator<int>.Select<int>
	|
	|-RVA: 0x267FCA0 Offset: 0x267BCA0 VA: 0x267FCA0
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Select<int>
	|
	|-RVA: 0x267FD14 Offset: 0x267BD14 VA: 0x267FD14
	|-Enumerable.WhereEnumerableIterator<long>.Select<TimeSpan>
	|
	|-RVA: 0x267FD88 Offset: 0x267BD88 VA: 0x267FD88
	|-Enumerable.WhereEnumerableIterator<object>.Select<bool>
	|
	|-RVA: 0x267FDFC Offset: 0x267BDFC VA: 0x267FDFC
	|-Enumerable.WhereEnumerableIterator<object>.Select<byte>
	|
	|-RVA: 0x267FE70 Offset: 0x267BE70 VA: 0x267FE70
	|-Enumerable.WhereEnumerableIterator<object>.Select<short>
	|
	|-RVA: 0x267FEE4 Offset: 0x267BEE4 VA: 0x267FEE4
	|-Enumerable.WhereEnumerableIterator<object>.Select<int>
	|
	|-RVA: 0x267FF58 Offset: 0x267BF58 VA: 0x267FF58
	|-Enumerable.WhereEnumerableIterator<object>.Select<Int32Enum>
	|
	|-RVA: 0x267FFCC Offset: 0x267BFCC VA: 0x267FFCC
	|-Enumerable.WhereEnumerableIterator<object>.Select<long>
	|
	|-RVA: 0x2680040 Offset: 0x267C040 VA: 0x2680040
	|-Enumerable.WhereEnumerableIterator<object>.Select<object>
	|
	|-RVA: 0x26800B4 Offset: 0x267C0B4 VA: 0x26800B4
	|-Enumerable.WhereEnumerableIterator<object>.Select<float>
	|
	|-RVA: 0x2680128 Offset: 0x267C128 VA: 0x2680128
	|-Enumerable.WhereEnumerableIterator<object>.Select<Vector3>
	|
	|-RVA: 0x268019C Offset: 0x267C19C VA: 0x268019C
	|-Enumerable.WhereEnumerableIterator<float>.Select<int>
	|
	|-RVA: 0x2680210 Offset: 0x267C210 VA: 0x2680210
	|-Enumerable.WhereEnumerableIterator<TimeSpan>.Select<long>
	|
	|-RVA: 0x2680284 Offset: 0x267C284 VA: 0x2680284
	|-Enumerable.WhereEnumerableIterator<Vector3>.Select<float>
	|
	|-RVA: 0x26802F8 Offset: 0x267C2F8 VA: 0x26802F8
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6EB7C Offset: 0x2D6AB7C VA: 0x2D6EB7C
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<byte, BlackKnightCristaProperty>>.Where
	|
	|-RVA: 0x2D6EF90 Offset: 0x2D6AF90 VA: 0x2D6EF90
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<byte, byte>>.Where
	|
	|-RVA: 0x2D6F3A4 Offset: 0x2D6B3A4 VA: 0x2D6F3A4
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, short>>.Where
	|
	|-RVA: 0x2D6F7D0 Offset: 0x2D6B7D0 VA: 0x2D6F7D0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x2D6FC2C Offset: 0x2D6BC2C VA: 0x2D6FC2C
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.Where
	|
	|-RVA: 0x2D70040 Offset: 0x2D6C040 VA: 0x2D70040
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, int>>.Where
	|
	|-RVA: 0x2D7046C Offset: 0x2D6C46C VA: 0x2D7046C
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<Int32Enum, object>>.Where
	|
	|-RVA: 0x2D708B0 Offset: 0x2D6C8B0 VA: 0x2D708B0
	|-Enumerable.WhereEnumerableIterator<Nullable<UIMobPropertyLabel.IconValue>>.Where
	|
	|-RVA: 0x2D70CC4 Offset: 0x2D6CCC4 VA: 0x2D70CC4
	|-Enumerable.WhereEnumerableIterator<ValueTuple<int, int>>.Where
	|
	|-RVA: 0x2D710DC Offset: 0x2D6D0DC VA: 0x2D710DC
	|-Enumerable.WhereEnumerableIterator<bool>.Where
	|
	|-RVA: 0x2D714F0 Offset: 0x2D6D4F0 VA: 0x2D714F0
	|-Enumerable.WhereEnumerableIterator<byte>.Where
	|
	|-RVA: 0x2D71904 Offset: 0x2D6D904 VA: 0x2D71904
	|-Enumerable.WhereEnumerableIterator<short>.Where
	|
	|-RVA: 0x2D71D18 Offset: 0x2D6DD18 VA: 0x2D71D18
	|-Enumerable.WhereEnumerableIterator<int>.Where
	|
	|-RVA: 0x2D7212C Offset: 0x2D6E12C VA: 0x2D7212C
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Where
	|
	|-RVA: 0x2D72540 Offset: 0x2D6E540 VA: 0x2D72540
	|-Enumerable.WhereEnumerableIterator<long>.Where
	|
	|-RVA: 0x2D72960 Offset: 0x2D6E960 VA: 0x2D72960
	|-Enumerable.WhereEnumerableIterator<object>.Where
	|
	|-RVA: 0x2D72D78 Offset: 0x2D6ED78 VA: 0x2D72D78
	|-Enumerable.WhereEnumerableIterator<float>.Where
	|
	|-RVA: 0x2D7318C Offset: 0x2D6F18C VA: 0x2D7318C
	|-Enumerable.WhereEnumerableIterator<SkillIdData>.Where
	|
	|-RVA: 0x2D735A0 Offset: 0x2D6F5A0 VA: 0x2D735A0
	|-Enumerable.WhereEnumerableIterator<TimeSpan>.Where
	|
	|-RVA: 0x2D739CC Offset: 0x2D6F9CC VA: 0x2D739CC
	|-Enumerable.WhereEnumerableIterator<Vector3>.Where
	|
	|-RVA: 0x2D74058 Offset: 0x2D70058 VA: 0x2D74058
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>.Where
	|
	|-RVA: 0x2D74504 Offset: 0x2D70504 VA: 0x2D74504
	|-Enumerable.WhereEnumerableIterator<HouseRecipeManager.RecipeData>.Where
	|
	|-RVA: 0x2D74918 Offset: 0x2D70918 VA: 0x2D74918
	|-Enumerable.WhereEnumerableIterator<KadarElexioBuf.SkillIdData>.Where
	|
	|-RVA: 0x2D74D34 Offset: 0x2D70D34 VA: 0x2D74D34
	|-Enumerable.WhereEnumerableIterator<MobaRoomData.MobaAbilityMasterData>.Where
	|
	|-RVA: 0x2D75148 Offset: 0x2D71148 VA: 0x2D75148
	|-Enumerable.WhereEnumerableIterator<TrophyManager.TrophyData>.Where
	*/
}
