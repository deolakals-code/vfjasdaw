// Assembly: System.Core.dll
// Namespace: 
private class Enumerable.WhereListIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 15186
{
	// Fields
	private List<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private List.Enumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(List<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D751C0 Offset: 0x2D711C0 VA: 0x2D751C0
	|-Enumerable.WhereListIterator<KeyValuePair<byte, BlackKnightCristaProperty>>..ctor
	|
	|-RVA: 0x2D753CC Offset: 0x2D713CC VA: 0x2D753CC
	|-Enumerable.WhereListIterator<KeyValuePair<byte, byte>>..ctor
	|
	|-RVA: 0x2D755D8 Offset: 0x2D715D8 VA: 0x2D755D8
	|-Enumerable.WhereListIterator<KeyValuePair<int, short>>..ctor
	|
	|-RVA: 0x2D757E4 Offset: 0x2D717E4 VA: 0x2D757E4
	|-Enumerable.WhereListIterator<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2D759FC Offset: 0x2D719FC VA: 0x2D759FC
	|-Enumerable.WhereListIterator<KeyValuePair<Int32Enum, EnhanceProperties2>>..ctor
	|
	|-RVA: 0x2D75C50 Offset: 0x2D71C50 VA: 0x2D75C50
	|-Enumerable.WhereListIterator<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2D75E5C Offset: 0x2D71E5C VA: 0x2D75E5C
	|-Enumerable.WhereListIterator<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x2D76074 Offset: 0x2D72074 VA: 0x2D76074
	|-Enumerable.WhereListIterator<Nullable<UIMobPropertyLabel.IconValue>>..ctor
	|
	|-RVA: 0x2D762B0 Offset: 0x2D722B0 VA: 0x2D762B0
	|-Enumerable.WhereListIterator<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2D764BC Offset: 0x2D724BC VA: 0x2D764BC
	|-Enumerable.WhereListIterator<bool>..ctor
	|
	|-RVA: 0x2D766CC Offset: 0x2D726CC VA: 0x2D766CC
	|-Enumerable.WhereListIterator<byte>..ctor
	|
	|-RVA: 0x2D768D8 Offset: 0x2D728D8 VA: 0x2D768D8
	|-Enumerable.WhereListIterator<int>..ctor
	|
	|-RVA: 0x2D76AE4 Offset: 0x2D72AE4 VA: 0x2D76AE4
	|-Enumerable.WhereListIterator<Int32Enum>..ctor
	|
	|-RVA: 0x2D76CF0 Offset: 0x2D72CF0 VA: 0x2D76CF0
	|-Enumerable.WhereListIterator<object>..ctor
	|
	|-RVA: 0x2D76F08 Offset: 0x2D72F08 VA: 0x2D76F08
	|-Enumerable.WhereListIterator<SkillIdData>..ctor
	|
	|-RVA: 0x2D77114 Offset: 0x2D73114 VA: 0x2D77114
	|-Enumerable.WhereListIterator<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2D775D0 Offset: 0x2D735D0 VA: 0x2D775D0
	|-Enumerable.WhereListIterator<HouseRecipeManager.RecipeData>..ctor
	|
	|-RVA: 0x2D77830 Offset: 0x2D73830 VA: 0x2D77830
	|-Enumerable.WhereListIterator<KadarElexioBuf.SkillIdData>..ctor
	|
	|-RVA: 0x2D77A3C Offset: 0x2D73A3C VA: 0x2D77A3C
	|-Enumerable.WhereListIterator<MobaRoomData.MobaAbilityMasterData>..ctor
	|
	|-RVA: 0x2D77C44 Offset: 0x2D73C44 VA: 0x2D77C44
	|-Enumerable.WhereListIterator<TrophyManager.TrophyData>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D7520C Offset: 0x2D7120C VA: 0x2D7520C
	|-Enumerable.WhereListIterator<KeyValuePair<byte, BlackKnightCristaProperty>>.Clone
	|
	|-RVA: 0x2D75418 Offset: 0x2D71418 VA: 0x2D75418
	|-Enumerable.WhereListIterator<KeyValuePair<byte, byte>>.Clone
	|
	|-RVA: 0x2D75624 Offset: 0x2D71624 VA: 0x2D75624
	|-Enumerable.WhereListIterator<KeyValuePair<int, short>>.Clone
	|
	|-RVA: 0x2D75830 Offset: 0x2D71830 VA: 0x2D75830
	|-Enumerable.WhereListIterator<KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x2D75A48 Offset: 0x2D71A48 VA: 0x2D75A48
	|-Enumerable.WhereListIterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.Clone
	|
	|-RVA: 0x2D75C9C Offset: 0x2D71C9C VA: 0x2D75C9C
	|-Enumerable.WhereListIterator<KeyValuePair<Int32Enum, int>>.Clone
	|
	|-RVA: 0x2D75EA8 Offset: 0x2D71EA8 VA: 0x2D75EA8
	|-Enumerable.WhereListIterator<KeyValuePair<Int32Enum, object>>.Clone
	|
	|-RVA: 0x2D760C0 Offset: 0x2D720C0 VA: 0x2D760C0
	|-Enumerable.WhereListIterator<Nullable<UIMobPropertyLabel.IconValue>>.Clone
	|
	|-RVA: 0x2D762FC Offset: 0x2D722FC VA: 0x2D762FC
	|-Enumerable.WhereListIterator<ValueTuple<int, int>>.Clone
	|
	|-RVA: 0x2D76508 Offset: 0x2D72508 VA: 0x2D76508
	|-Enumerable.WhereListIterator<bool>.Clone
	|
	|-RVA: 0x2D76718 Offset: 0x2D72718 VA: 0x2D76718
	|-Enumerable.WhereListIterator<byte>.Clone
	|
	|-RVA: 0x2D76924 Offset: 0x2D72924 VA: 0x2D76924
	|-Enumerable.WhereListIterator<int>.Clone
	|
	|-RVA: 0x2D76B30 Offset: 0x2D72B30 VA: 0x2D76B30
	|-Enumerable.WhereListIterator<Int32Enum>.Clone
	|
	|-RVA: 0x2D76D3C Offset: 0x2D72D3C VA: 0x2D76D3C
	|-Enumerable.WhereListIterator<object>.Clone
	|
	|-RVA: 0x2D76F54 Offset: 0x2D72F54 VA: 0x2D76F54
	|-Enumerable.WhereListIterator<SkillIdData>.Clone
	|
	|-RVA: 0x2D7718C Offset: 0x2D7318C VA: 0x2D7718C
	|-Enumerable.WhereListIterator<__Il2CppFullySharedGenericType>.Clone
	|
	|-RVA: 0x2D7761C Offset: 0x2D7361C VA: 0x2D7761C
	|-Enumerable.WhereListIterator<HouseRecipeManager.RecipeData>.Clone
	|
	|-RVA: 0x2D7787C Offset: 0x2D7387C VA: 0x2D7787C
	|-Enumerable.WhereListIterator<KadarElexioBuf.SkillIdData>.Clone
	|
	|-RVA: 0x2D77A88 Offset: 0x2D73A88 VA: 0x2D77A88
	|-Enumerable.WhereListIterator<MobaRoomData.MobaAbilityMasterData>.Clone
	|
	|-RVA: 0x2D77C90 Offset: 0x2D73C90 VA: 0x2D77C90
	|-Enumerable.WhereListIterator<TrophyManager.TrophyData>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D75268 Offset: 0x2D71268 VA: 0x2D75268
	|-Enumerable.WhereListIterator<KeyValuePair<byte, BlackKnightCristaProperty>>.MoveNext
	|
	|-RVA: 0x2D75474 Offset: 0x2D71474 VA: 0x2D75474
	|-Enumerable.WhereListIterator<KeyValuePair<byte, byte>>.MoveNext
	|
	|-RVA: 0x2D75680 Offset: 0x2D71680 VA: 0x2D75680
	|-Enumerable.WhereListIterator<KeyValuePair<int, short>>.MoveNext
	|
	|-RVA: 0x2D7588C Offset: 0x2D7188C VA: 0x2D7588C
	|-Enumerable.WhereListIterator<KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x2D75AA4 Offset: 0x2D71AA4 VA: 0x2D75AA4
	|-Enumerable.WhereListIterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.MoveNext
	|
	|-RVA: 0x2D75CF8 Offset: 0x2D71CF8 VA: 0x2D75CF8
	|-Enumerable.WhereListIterator<KeyValuePair<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x2D75F04 Offset: 0x2D71F04 VA: 0x2D75F04
	|-Enumerable.WhereListIterator<KeyValuePair<Int32Enum, object>>.MoveNext
	|
	|-RVA: 0x2D7611C Offset: 0x2D7211C VA: 0x2D7611C
	|-Enumerable.WhereListIterator<Nullable<UIMobPropertyLabel.IconValue>>.MoveNext
	|
	|-RVA: 0x2D76358 Offset: 0x2D72358 VA: 0x2D76358
	|-Enumerable.WhereListIterator<ValueTuple<int, int>>.MoveNext
	|
	|-RVA: 0x2D76564 Offset: 0x2D72564 VA: 0x2D76564
	|-Enumerable.WhereListIterator<bool>.MoveNext
	|
	|-RVA: 0x2D76774 Offset: 0x2D72774 VA: 0x2D76774
	|-Enumerable.WhereListIterator<byte>.MoveNext
	|
	|-RVA: 0x2D76980 Offset: 0x2D72980 VA: 0x2D76980
	|-Enumerable.WhereListIterator<int>.MoveNext
	|
	|-RVA: 0x2D76B8C Offset: 0x2D72B8C VA: 0x2D76B8C
	|-Enumerable.WhereListIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x2D76D98 Offset: 0x2D72D98 VA: 0x2D76D98
	|-Enumerable.WhereListIterator<object>.MoveNext
	|
	|-RVA: 0x2D76FB0 Offset: 0x2D72FB0 VA: 0x2D76FB0
	|-Enumerable.WhereListIterator<SkillIdData>.MoveNext
	|
	|-RVA: 0x2D77224 Offset: 0x2D73224 VA: 0x2D77224
	|-Enumerable.WhereListIterator<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x2D77678 Offset: 0x2D73678 VA: 0x2D77678
	|-Enumerable.WhereListIterator<HouseRecipeManager.RecipeData>.MoveNext
	|
	|-RVA: 0x2D778D8 Offset: 0x2D738D8 VA: 0x2D778D8
	|-Enumerable.WhereListIterator<KadarElexioBuf.SkillIdData>.MoveNext
	|
	|-RVA: 0x2D77AE4 Offset: 0x2D73AE4 VA: 0x2D77AE4
	|-Enumerable.WhereListIterator<MobaRoomData.MobaAbilityMasterData>.MoveNext
	|
	|-RVA: 0x2D77CEC Offset: 0x2D73CEC VA: 0x2D77CEC
	|-Enumerable.WhereListIterator<TrophyManager.TrophyData>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26803AC Offset: 0x267C3AC VA: 0x26803AC
	|-Enumerable.WhereListIterator<KeyValuePair<int, object>>.Select<int>
	|
	|-RVA: 0x2680420 Offset: 0x267C420 VA: 0x2680420
	|-Enumerable.WhereListIterator<KeyValuePair<int, object>>.Select<object>
	|
	|-RVA: 0x2680494 Offset: 0x267C494 VA: 0x2680494
	|-Enumerable.WhereListIterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.Select<int>
	|
	|-RVA: 0x2680508 Offset: 0x267C508 VA: 0x2680508
	|-Enumerable.WhereListIterator<KeyValuePair<Int32Enum, int>>.Select<int>
	|
	|-RVA: 0x268057C Offset: 0x267C57C VA: 0x268057C
	|-Enumerable.WhereListIterator<KeyValuePair<Int32Enum, int>>.Select<Int32Enum>
	|
	|-RVA: 0x26805F0 Offset: 0x267C5F0 VA: 0x26805F0
	|-Enumerable.WhereListIterator<KeyValuePair<Int32Enum, int>>.Select<object>
	|
	|-RVA: 0x2680664 Offset: 0x267C664 VA: 0x2680664
	|-Enumerable.WhereListIterator<KeyValuePair<Int32Enum, object>>.Select<Int32Enum>
	|
	|-RVA: 0x26806D8 Offset: 0x267C6D8 VA: 0x26806D8
	|-Enumerable.WhereListIterator<Nullable<UIMobPropertyLabel.IconValue>>.Select<int>
	|
	|-RVA: 0x268074C Offset: 0x267C74C VA: 0x268074C
	|-Enumerable.WhereListIterator<byte>.Select<int>
	|
	|-RVA: 0x26807C0 Offset: 0x267C7C0 VA: 0x26807C0
	|-Enumerable.WhereListIterator<int>.Select<int>
	|
	|-RVA: 0x2680834 Offset: 0x267C834 VA: 0x2680834
	|-Enumerable.WhereListIterator<Int32Enum>.Select<int>
	|
	|-RVA: 0x26808A8 Offset: 0x267C8A8 VA: 0x26808A8
	|-Enumerable.WhereListIterator<object>.Select<bool>
	|
	|-RVA: 0x268091C Offset: 0x267C91C VA: 0x268091C
	|-Enumerable.WhereListIterator<object>.Select<byte>
	|
	|-RVA: 0x2680990 Offset: 0x267C990 VA: 0x2680990
	|-Enumerable.WhereListIterator<object>.Select<short>
	|
	|-RVA: 0x2680A04 Offset: 0x267CA04 VA: 0x2680A04
	|-Enumerable.WhereListIterator<object>.Select<int>
	|
	|-RVA: 0x2680A78 Offset: 0x267CA78 VA: 0x2680A78
	|-Enumerable.WhereListIterator<object>.Select<Int32Enum>
	|
	|-RVA: 0x2680AEC Offset: 0x267CAEC VA: 0x2680AEC
	|-Enumerable.WhereListIterator<object>.Select<long>
	|
	|-RVA: 0x2680B60 Offset: 0x267CB60 VA: 0x2680B60
	|-Enumerable.WhereListIterator<object>.Select<object>
	|
	|-RVA: 0x2680BD4 Offset: 0x267CBD4 VA: 0x2680BD4
	|-Enumerable.WhereListIterator<object>.Select<float>
	|
	|-RVA: 0x2680C48 Offset: 0x267CC48 VA: 0x2680C48
	|-Enumerable.WhereListIterator<object>.Select<Vector3>
	|
	|-RVA: 0x2680CBC Offset: 0x267CCBC VA: 0x2680CBC
	|-Enumerable.WhereListIterator<__Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D75354 Offset: 0x2D71354 VA: 0x2D75354
	|-Enumerable.WhereListIterator<KeyValuePair<byte, BlackKnightCristaProperty>>.Where
	|
	|-RVA: 0x2D75560 Offset: 0x2D71560 VA: 0x2D75560
	|-Enumerable.WhereListIterator<KeyValuePair<byte, byte>>.Where
	|
	|-RVA: 0x2D7576C Offset: 0x2D7176C VA: 0x2D7576C
	|-Enumerable.WhereListIterator<KeyValuePair<int, short>>.Where
	|
	|-RVA: 0x2D75984 Offset: 0x2D71984 VA: 0x2D75984
	|-Enumerable.WhereListIterator<KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x2D75BD8 Offset: 0x2D71BD8 VA: 0x2D75BD8
	|-Enumerable.WhereListIterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.Where
	|
	|-RVA: 0x2D75DE4 Offset: 0x2D71DE4 VA: 0x2D75DE4
	|-Enumerable.WhereListIterator<KeyValuePair<Int32Enum, int>>.Where
	|
	|-RVA: 0x2D75FFC Offset: 0x2D71FFC VA: 0x2D75FFC
	|-Enumerable.WhereListIterator<KeyValuePair<Int32Enum, object>>.Where
	|
	|-RVA: 0x2D76238 Offset: 0x2D72238 VA: 0x2D76238
	|-Enumerable.WhereListIterator<Nullable<UIMobPropertyLabel.IconValue>>.Where
	|
	|-RVA: 0x2D76444 Offset: 0x2D72444 VA: 0x2D76444
	|-Enumerable.WhereListIterator<ValueTuple<int, int>>.Where
	|
	|-RVA: 0x2D76654 Offset: 0x2D72654 VA: 0x2D76654
	|-Enumerable.WhereListIterator<bool>.Where
	|
	|-RVA: 0x2D76860 Offset: 0x2D72860 VA: 0x2D76860
	|-Enumerable.WhereListIterator<byte>.Where
	|
	|-RVA: 0x2D76A6C Offset: 0x2D72A6C VA: 0x2D76A6C
	|-Enumerable.WhereListIterator<int>.Where
	|
	|-RVA: 0x2D76C78 Offset: 0x2D72C78 VA: 0x2D76C78
	|-Enumerable.WhereListIterator<Int32Enum>.Where
	|
	|-RVA: 0x2D76E90 Offset: 0x2D72E90 VA: 0x2D76E90
	|-Enumerable.WhereListIterator<object>.Where
	|
	|-RVA: 0x2D7709C Offset: 0x2D7309C VA: 0x2D7709C
	|-Enumerable.WhereListIterator<SkillIdData>.Where
	|
	|-RVA: 0x2D77508 Offset: 0x2D73508 VA: 0x2D77508
	|-Enumerable.WhereListIterator<__Il2CppFullySharedGenericType>.Where
	|
	|-RVA: 0x2D777B8 Offset: 0x2D737B8 VA: 0x2D777B8
	|-Enumerable.WhereListIterator<HouseRecipeManager.RecipeData>.Where
	|
	|-RVA: 0x2D779C4 Offset: 0x2D739C4 VA: 0x2D779C4
	|-Enumerable.WhereListIterator<KadarElexioBuf.SkillIdData>.Where
	|
	|-RVA: 0x2D77BCC Offset: 0x2D73BCC VA: 0x2D77BCC
	|-Enumerable.WhereListIterator<MobaRoomData.MobaAbilityMasterData>.Where
	|
	|-RVA: 0x2D77DD8 Offset: 0x2D73DD8 VA: 0x2D77DD8
	|-Enumerable.WhereListIterator<TrophyManager.TrophyData>.Where
	*/
}
