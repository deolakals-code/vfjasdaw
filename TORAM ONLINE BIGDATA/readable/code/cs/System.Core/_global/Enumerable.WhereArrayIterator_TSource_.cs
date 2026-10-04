// Assembly: System.Core.dll
// Namespace: 
private class Enumerable.WhereArrayIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 15185
{
	// Fields
	private TSource[] source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TSource[] source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6C16C Offset: 0x2D6816C VA: 0x2D6C16C
	|-Enumerable.WhereArrayIterator<KeyValuePair<byte, BlackKnightCristaProperty>>..ctor
	|
	|-RVA: 0x2D6C328 Offset: 0x2D68328 VA: 0x2D6C328
	|-Enumerable.WhereArrayIterator<KeyValuePair<byte, byte>>..ctor
	|
	|-RVA: 0x2D6C4E4 Offset: 0x2D684E4 VA: 0x2D6C4E4
	|-Enumerable.WhereArrayIterator<KeyValuePair<int, short>>..ctor
	|
	|-RVA: 0x2D6C6A0 Offset: 0x2D686A0 VA: 0x2D6C6A0
	|-Enumerable.WhereArrayIterator<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2D6C870 Offset: 0x2D68870 VA: 0x2D6C870
	|-Enumerable.WhereArrayIterator<KeyValuePair<Int32Enum, EnhanceProperties2>>..ctor
	|
	|-RVA: 0x2D6CA74 Offset: 0x2D68A74 VA: 0x2D6CA74
	|-Enumerable.WhereArrayIterator<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2D6CC30 Offset: 0x2D68C30 VA: 0x2D6CC30
	|-Enumerable.WhereArrayIterator<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x2D6CE00 Offset: 0x2D68E00 VA: 0x2D6CE00
	|-Enumerable.WhereArrayIterator<Nullable<UIMobPropertyLabel.IconValue>>..ctor
	|
	|-RVA: 0x2D6CFE4 Offset: 0x2D68FE4 VA: 0x2D6CFE4
	|-Enumerable.WhereArrayIterator<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2D6D1A0 Offset: 0x2D691A0 VA: 0x2D6D1A0
	|-Enumerable.WhereArrayIterator<bool>..ctor
	|
	|-RVA: 0x2D6D360 Offset: 0x2D69360 VA: 0x2D6D360
	|-Enumerable.WhereArrayIterator<byte>..ctor
	|
	|-RVA: 0x2D6D51C Offset: 0x2D6951C VA: 0x2D6D51C
	|-Enumerable.WhereArrayIterator<int>..ctor
	|
	|-RVA: 0x2D6D6D8 Offset: 0x2D696D8 VA: 0x2D6D6D8
	|-Enumerable.WhereArrayIterator<Int32Enum>..ctor
	|
	|-RVA: 0x2D6D894 Offset: 0x2D69894 VA: 0x2D6D894
	|-Enumerable.WhereArrayIterator<object>..ctor
	|
	|-RVA: 0x2D6DA5C Offset: 0x2D69A5C VA: 0x2D6DA5C
	|-Enumerable.WhereArrayIterator<SkillIdData>..ctor
	|
	|-RVA: 0x2D6DC18 Offset: 0x2D69C18 VA: 0x2D6DC18
	|-Enumerable.WhereArrayIterator<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2D6E09C Offset: 0x2D6A09C VA: 0x2D6E09C
	|-Enumerable.WhereArrayIterator<HouseRecipeManager.RecipeData>..ctor
	|
	|-RVA: 0x2D6E2A8 Offset: 0x2D6A2A8 VA: 0x2D6E2A8
	|-Enumerable.WhereArrayIterator<KadarElexioBuf.SkillIdData>..ctor
	|
	|-RVA: 0x2D6E464 Offset: 0x2D6A464 VA: 0x2D6E464
	|-Enumerable.WhereArrayIterator<MobaRoomData.MobaAbilityMasterData>..ctor
	|
	|-RVA: 0x2D6E624 Offset: 0x2D6A624 VA: 0x2D6E624
	|-Enumerable.WhereArrayIterator<TrophyManager.TrophyData>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6C1B8 Offset: 0x2D681B8 VA: 0x2D6C1B8
	|-Enumerable.WhereArrayIterator<KeyValuePair<byte, BlackKnightCristaProperty>>.Clone
	|
	|-RVA: 0x2D6C374 Offset: 0x2D68374 VA: 0x2D6C374
	|-Enumerable.WhereArrayIterator<KeyValuePair<byte, byte>>.Clone
	|
	|-RVA: 0x2D6C530 Offset: 0x2D68530 VA: 0x2D6C530
	|-Enumerable.WhereArrayIterator<KeyValuePair<int, short>>.Clone
	|
	|-RVA: 0x2D6C6EC Offset: 0x2D686EC VA: 0x2D6C6EC
	|-Enumerable.WhereArrayIterator<KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x2D6C8BC Offset: 0x2D688BC VA: 0x2D6C8BC
	|-Enumerable.WhereArrayIterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.Clone
	|
	|-RVA: 0x2D6CAC0 Offset: 0x2D68AC0 VA: 0x2D6CAC0
	|-Enumerable.WhereArrayIterator<KeyValuePair<Int32Enum, int>>.Clone
	|
	|-RVA: 0x2D6CC7C Offset: 0x2D68C7C VA: 0x2D6CC7C
	|-Enumerable.WhereArrayIterator<KeyValuePair<Int32Enum, object>>.Clone
	|
	|-RVA: 0x2D6CE4C Offset: 0x2D68E4C VA: 0x2D6CE4C
	|-Enumerable.WhereArrayIterator<Nullable<UIMobPropertyLabel.IconValue>>.Clone
	|
	|-RVA: 0x2D6D030 Offset: 0x2D69030 VA: 0x2D6D030
	|-Enumerable.WhereArrayIterator<ValueTuple<int, int>>.Clone
	|
	|-RVA: 0x2D6D1EC Offset: 0x2D691EC VA: 0x2D6D1EC
	|-Enumerable.WhereArrayIterator<bool>.Clone
	|
	|-RVA: 0x2D6D3AC Offset: 0x2D693AC VA: 0x2D6D3AC
	|-Enumerable.WhereArrayIterator<byte>.Clone
	|
	|-RVA: 0x2D6D568 Offset: 0x2D69568 VA: 0x2D6D568
	|-Enumerable.WhereArrayIterator<int>.Clone
	|
	|-RVA: 0x2D6D724 Offset: 0x2D69724 VA: 0x2D6D724
	|-Enumerable.WhereArrayIterator<Int32Enum>.Clone
	|
	|-RVA: 0x2D6D8E0 Offset: 0x2D698E0 VA: 0x2D6D8E0
	|-Enumerable.WhereArrayIterator<object>.Clone
	|
	|-RVA: 0x2D6DAA8 Offset: 0x2D69AA8 VA: 0x2D6DAA8
	|-Enumerable.WhereArrayIterator<SkillIdData>.Clone
	|
	|-RVA: 0x2D6DC90 Offset: 0x2D69C90 VA: 0x2D6DC90
	|-Enumerable.WhereArrayIterator<__Il2CppFullySharedGenericType>.Clone
	|
	|-RVA: 0x2D6E0E8 Offset: 0x2D6A0E8 VA: 0x2D6E0E8
	|-Enumerable.WhereArrayIterator<HouseRecipeManager.RecipeData>.Clone
	|
	|-RVA: 0x2D6E2F4 Offset: 0x2D6A2F4 VA: 0x2D6E2F4
	|-Enumerable.WhereArrayIterator<KadarElexioBuf.SkillIdData>.Clone
	|
	|-RVA: 0x2D6E4B0 Offset: 0x2D6A4B0 VA: 0x2D6E4B0
	|-Enumerable.WhereArrayIterator<MobaRoomData.MobaAbilityMasterData>.Clone
	|
	|-RVA: 0x2D6E670 Offset: 0x2D6A670 VA: 0x2D6E670
	|-Enumerable.WhereArrayIterator<TrophyManager.TrophyData>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6C214 Offset: 0x2D68214 VA: 0x2D6C214
	|-Enumerable.WhereArrayIterator<KeyValuePair<byte, BlackKnightCristaProperty>>.MoveNext
	|
	|-RVA: 0x2D6C3D0 Offset: 0x2D683D0 VA: 0x2D6C3D0
	|-Enumerable.WhereArrayIterator<KeyValuePair<byte, byte>>.MoveNext
	|
	|-RVA: 0x2D6C58C Offset: 0x2D6858C VA: 0x2D6C58C
	|-Enumerable.WhereArrayIterator<KeyValuePair<int, short>>.MoveNext
	|
	|-RVA: 0x2D6C748 Offset: 0x2D68748 VA: 0x2D6C748
	|-Enumerable.WhereArrayIterator<KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x2D6C918 Offset: 0x2D68918 VA: 0x2D6C918
	|-Enumerable.WhereArrayIterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.MoveNext
	|
	|-RVA: 0x2D6CB1C Offset: 0x2D68B1C VA: 0x2D6CB1C
	|-Enumerable.WhereArrayIterator<KeyValuePair<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x2D6CCD8 Offset: 0x2D68CD8 VA: 0x2D6CCD8
	|-Enumerable.WhereArrayIterator<KeyValuePair<Int32Enum, object>>.MoveNext
	|
	|-RVA: 0x2D6CEA8 Offset: 0x2D68EA8 VA: 0x2D6CEA8
	|-Enumerable.WhereArrayIterator<Nullable<UIMobPropertyLabel.IconValue>>.MoveNext
	|
	|-RVA: 0x2D6D08C Offset: 0x2D6908C VA: 0x2D6D08C
	|-Enumerable.WhereArrayIterator<ValueTuple<int, int>>.MoveNext
	|
	|-RVA: 0x2D6D248 Offset: 0x2D69248 VA: 0x2D6D248
	|-Enumerable.WhereArrayIterator<bool>.MoveNext
	|
	|-RVA: 0x2D6D408 Offset: 0x2D69408 VA: 0x2D6D408
	|-Enumerable.WhereArrayIterator<byte>.MoveNext
	|
	|-RVA: 0x2D6D5C4 Offset: 0x2D695C4 VA: 0x2D6D5C4
	|-Enumerable.WhereArrayIterator<int>.MoveNext
	|
	|-RVA: 0x2D6D780 Offset: 0x2D69780 VA: 0x2D6D780
	|-Enumerable.WhereArrayIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x2D6D93C Offset: 0x2D6993C VA: 0x2D6D93C
	|-Enumerable.WhereArrayIterator<object>.MoveNext
	|
	|-RVA: 0x2D6DB04 Offset: 0x2D69B04 VA: 0x2D6DB04
	|-Enumerable.WhereArrayIterator<SkillIdData>.MoveNext
	|
	|-RVA: 0x2D6DD28 Offset: 0x2D69D28 VA: 0x2D6DD28
	|-Enumerable.WhereArrayIterator<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x2D6E144 Offset: 0x2D6A144 VA: 0x2D6E144
	|-Enumerable.WhereArrayIterator<HouseRecipeManager.RecipeData>.MoveNext
	|
	|-RVA: 0x2D6E350 Offset: 0x2D6A350 VA: 0x2D6E350
	|-Enumerable.WhereArrayIterator<KadarElexioBuf.SkillIdData>.MoveNext
	|
	|-RVA: 0x2D6E50C Offset: 0x2D6A50C VA: 0x2D6E50C
	|-Enumerable.WhereArrayIterator<MobaRoomData.MobaAbilityMasterData>.MoveNext
	|
	|-RVA: 0x2D6E6CC Offset: 0x2D6A6CC VA: 0x2D6E6CC
	|-Enumerable.WhereArrayIterator<TrophyManager.TrophyData>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267EE54 Offset: 0x267AE54 VA: 0x267EE54
	|-Enumerable.WhereArrayIterator<KeyValuePair<int, object>>.Select<int>
	|
	|-RVA: 0x267EEC8 Offset: 0x267AEC8 VA: 0x267EEC8
	|-Enumerable.WhereArrayIterator<KeyValuePair<int, object>>.Select<object>
	|
	|-RVA: 0x267EF3C Offset: 0x267AF3C VA: 0x267EF3C
	|-Enumerable.WhereArrayIterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.Select<int>
	|
	|-RVA: 0x267EFB0 Offset: 0x267AFB0 VA: 0x267EFB0
	|-Enumerable.WhereArrayIterator<KeyValuePair<Int32Enum, int>>.Select<int>
	|
	|-RVA: 0x267F024 Offset: 0x267B024 VA: 0x267F024
	|-Enumerable.WhereArrayIterator<KeyValuePair<Int32Enum, int>>.Select<Int32Enum>
	|
	|-RVA: 0x267F098 Offset: 0x267B098 VA: 0x267F098
	|-Enumerable.WhereArrayIterator<KeyValuePair<Int32Enum, int>>.Select<object>
	|
	|-RVA: 0x267F10C Offset: 0x267B10C VA: 0x267F10C
	|-Enumerable.WhereArrayIterator<KeyValuePair<Int32Enum, object>>.Select<Int32Enum>
	|
	|-RVA: 0x267F180 Offset: 0x267B180 VA: 0x267F180
	|-Enumerable.WhereArrayIterator<Nullable<UIMobPropertyLabel.IconValue>>.Select<int>
	|
	|-RVA: 0x267F1F4 Offset: 0x267B1F4 VA: 0x267F1F4
	|-Enumerable.WhereArrayIterator<byte>.Select<int>
	|
	|-RVA: 0x267F268 Offset: 0x267B268 VA: 0x267F268
	|-Enumerable.WhereArrayIterator<int>.Select<int>
	|
	|-RVA: 0x267F2DC Offset: 0x267B2DC VA: 0x267F2DC
	|-Enumerable.WhereArrayIterator<Int32Enum>.Select<int>
	|
	|-RVA: 0x267F350 Offset: 0x267B350 VA: 0x267F350
	|-Enumerable.WhereArrayIterator<object>.Select<bool>
	|
	|-RVA: 0x267F3C4 Offset: 0x267B3C4 VA: 0x267F3C4
	|-Enumerable.WhereArrayIterator<object>.Select<byte>
	|
	|-RVA: 0x267F438 Offset: 0x267B438 VA: 0x267F438
	|-Enumerable.WhereArrayIterator<object>.Select<short>
	|
	|-RVA: 0x267F4AC Offset: 0x267B4AC VA: 0x267F4AC
	|-Enumerable.WhereArrayIterator<object>.Select<int>
	|
	|-RVA: 0x267F520 Offset: 0x267B520 VA: 0x267F520
	|-Enumerable.WhereArrayIterator<object>.Select<Int32Enum>
	|
	|-RVA: 0x267F594 Offset: 0x267B594 VA: 0x267F594
	|-Enumerable.WhereArrayIterator<object>.Select<long>
	|
	|-RVA: 0x267F608 Offset: 0x267B608 VA: 0x267F608
	|-Enumerable.WhereArrayIterator<object>.Select<object>
	|
	|-RVA: 0x267F67C Offset: 0x267B67C VA: 0x267F67C
	|-Enumerable.WhereArrayIterator<object>.Select<float>
	|
	|-RVA: 0x267F6F0 Offset: 0x267B6F0 VA: 0x267F6F0
	|-Enumerable.WhereArrayIterator<object>.Select<Vector3>
	|
	|-RVA: 0x267F764 Offset: 0x267B764 VA: 0x267F764
	|-Enumerable.WhereArrayIterator<__Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D6C2B0 Offset: 0x2D682B0 VA: 0x2D6C2B0
	|-Enumerable.WhereArrayIterator<KeyValuePair<byte, BlackKnightCristaProperty>>.Where
	|
	|-RVA: 0x2D6C46C Offset: 0x2D6846C VA: 0x2D6C46C
	|-Enumerable.WhereArrayIterator<KeyValuePair<byte, byte>>.Where
	|
	|-RVA: 0x2D6C628 Offset: 0x2D68628 VA: 0x2D6C628
	|-Enumerable.WhereArrayIterator<KeyValuePair<int, short>>.Where
	|
	|-RVA: 0x2D6C7F8 Offset: 0x2D687F8 VA: 0x2D6C7F8
	|-Enumerable.WhereArrayIterator<KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x2D6C9FC Offset: 0x2D689FC VA: 0x2D6C9FC
	|-Enumerable.WhereArrayIterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.Where
	|
	|-RVA: 0x2D6CBB8 Offset: 0x2D68BB8 VA: 0x2D6CBB8
	|-Enumerable.WhereArrayIterator<KeyValuePair<Int32Enum, int>>.Where
	|
	|-RVA: 0x2D6CD88 Offset: 0x2D68D88 VA: 0x2D6CD88
	|-Enumerable.WhereArrayIterator<KeyValuePair<Int32Enum, object>>.Where
	|
	|-RVA: 0x2D6CF6C Offset: 0x2D68F6C VA: 0x2D6CF6C
	|-Enumerable.WhereArrayIterator<Nullable<UIMobPropertyLabel.IconValue>>.Where
	|
	|-RVA: 0x2D6D128 Offset: 0x2D69128 VA: 0x2D6D128
	|-Enumerable.WhereArrayIterator<ValueTuple<int, int>>.Where
	|
	|-RVA: 0x2D6D2E8 Offset: 0x2D692E8 VA: 0x2D6D2E8
	|-Enumerable.WhereArrayIterator<bool>.Where
	|
	|-RVA: 0x2D6D4A4 Offset: 0x2D694A4 VA: 0x2D6D4A4
	|-Enumerable.WhereArrayIterator<byte>.Where
	|
	|-RVA: 0x2D6D660 Offset: 0x2D69660 VA: 0x2D6D660
	|-Enumerable.WhereArrayIterator<int>.Where
	|
	|-RVA: 0x2D6D81C Offset: 0x2D6981C VA: 0x2D6D81C
	|-Enumerable.WhereArrayIterator<Int32Enum>.Where
	|
	|-RVA: 0x2D6D9E4 Offset: 0x2D699E4 VA: 0x2D6D9E4
	|-Enumerable.WhereArrayIterator<object>.Where
	|
	|-RVA: 0x2D6DBA0 Offset: 0x2D69BA0 VA: 0x2D6DBA0
	|-Enumerable.WhereArrayIterator<SkillIdData>.Where
	|
	|-RVA: 0x2D6DFD4 Offset: 0x2D69FD4 VA: 0x2D6DFD4
	|-Enumerable.WhereArrayIterator<__Il2CppFullySharedGenericType>.Where
	|
	|-RVA: 0x2D6E230 Offset: 0x2D6A230 VA: 0x2D6E230
	|-Enumerable.WhereArrayIterator<HouseRecipeManager.RecipeData>.Where
	|
	|-RVA: 0x2D6E3EC Offset: 0x2D6A3EC VA: 0x2D6E3EC
	|-Enumerable.WhereArrayIterator<KadarElexioBuf.SkillIdData>.Where
	|
	|-RVA: 0x2D6E5AC Offset: 0x2D6A5AC VA: 0x2D6E5AC
	|-Enumerable.WhereArrayIterator<MobaRoomData.MobaAbilityMasterData>.Where
	|
	|-RVA: 0x2D6E768 Offset: 0x2D6A768 VA: 0x2D6E768
	|-Enumerable.WhereArrayIterator<TrophyManager.TrophyData>.Where
	*/
}
