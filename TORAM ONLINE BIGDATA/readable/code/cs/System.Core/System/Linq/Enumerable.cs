// Assembly: System.Core.dll
// Namespace: System.Linq
[Extension]
public static class Enumerable // TypeDefIndex: 15203
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Where<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26BB5F4 Offset: 0x26B75F4 VA: 0x26BB5F4
	|-Enumerable.Where<KeyValuePair<byte, BlackKnightCristaProperty>>
	|
	|-RVA: 0x26BB8C8 Offset: 0x26B78C8 VA: 0x26BB8C8
	|-Enumerable.Where<KeyValuePair<byte, byte>>
	|
	|-RVA: 0x26BBB9C Offset: 0x26B7B9C VA: 0x26BBB9C
	|-Enumerable.Where<KeyValuePair<int, short>>
	|
	|-RVA: 0x26BBE70 Offset: 0x26B7E70 VA: 0x26BBE70
	|-Enumerable.Where<KeyValuePair<int, object>>
	|
	|-RVA: 0x26BC144 Offset: 0x26B8144 VA: 0x26BC144
	|-Enumerable.Where<KeyValuePair<Int32Enum, EnhanceProperties2>>
	|
	|-RVA: 0x26BC418 Offset: 0x26B8418 VA: 0x26BC418
	|-Enumerable.Where<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x26BC6EC Offset: 0x26B86EC VA: 0x26BC6EC
	|-Enumerable.Where<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x26BC9C0 Offset: 0x26B89C0 VA: 0x26BC9C0
	|-Enumerable.Where<Nullable<UIMobPropertyLabel.IconValue>>
	|
	|-RVA: 0x26BCC94 Offset: 0x26B8C94 VA: 0x26BCC94
	|-Enumerable.Where<ValueTuple<int, int>>
	|
	|-RVA: 0x26BCF68 Offset: 0x26B8F68 VA: 0x26BCF68
	|-Enumerable.Where<bool>
	|
	|-RVA: 0x26BD23C Offset: 0x26B923C VA: 0x26BD23C
	|-Enumerable.Where<byte>
	|
	|-RVA: 0x26BD510 Offset: 0x26B9510 VA: 0x26BD510
	|-Enumerable.Where<int>
	|
	|-RVA: 0x26BD7E4 Offset: 0x26B97E4 VA: 0x26BD7E4
	|-Enumerable.Where<Int32Enum>
	|
	|-RVA: 0x26BDAB8 Offset: 0x26B9AB8 VA: 0x26BDAB8
	|-Enumerable.Where<object>
	|
	|-RVA: 0x26BDD8C Offset: 0x26B9D8C VA: 0x26BDD8C
	|-Enumerable.Where<SkillIdData>
	|
	|-RVA: 0x26BE060 Offset: 0x26BA060 VA: 0x26BE060
	|-Enumerable.Where<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x26BE354 Offset: 0x26BA354 VA: 0x26BE354
	|-Enumerable.Where<HouseRecipeManager.RecipeData>
	|
	|-RVA: 0x26BE628 Offset: 0x26BA628 VA: 0x26BE628
	|-Enumerable.Where<KadarElexioBuf.SkillIdData>
	|
	|-RVA: 0x26BE8FC Offset: 0x26BA8FC VA: 0x26BE8FC
	|-Enumerable.Where<MobaRoomData.MobaAbilityMasterData>
	|
	|-RVA: 0x26BEBD0 Offset: 0x26BABD0 VA: 0x26BEBD0
	|-Enumerable.Where<TrophyManager.TrophyData>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26AEE38 Offset: 0x26AAE38 VA: 0x26AEE38
	|-Enumerable.Select<KeyValuePair<byte, object>, byte>
	|
	|-RVA: 0x26AF12C Offset: 0x26AB12C VA: 0x26AF12C
	|-Enumerable.Select<KeyValuePair<int, object>, int>
	|
	|-RVA: 0x26AF420 Offset: 0x26AB420 VA: 0x26AF420
	|-Enumerable.Select<KeyValuePair<int, object>, object>
	|
	|-RVA: 0x26AF714 Offset: 0x26AB714 VA: 0x26AF714
	|-Enumerable.Select<KeyValuePair<Int32Enum, EnhanceProperties2>, int>
	|
	|-RVA: 0x26AFA08 Offset: 0x26ABA08 VA: 0x26AFA08
	|-Enumerable.Select<KeyValuePair<Int32Enum, int>, int>
	|
	|-RVA: 0x26AFCFC Offset: 0x26ABCFC VA: 0x26AFCFC
	|-Enumerable.Select<KeyValuePair<Int32Enum, int>, Int32Enum>
	|
	|-RVA: 0x26AFFF0 Offset: 0x26ABFF0 VA: 0x26AFFF0
	|-Enumerable.Select<KeyValuePair<Int32Enum, int>, object>
	|
	|-RVA: 0x26B02E4 Offset: 0x26AC2E4 VA: 0x26B02E4
	|-Enumerable.Select<KeyValuePair<Int32Enum, object>, Int32Enum>
	|
	|-RVA: 0x26B05D8 Offset: 0x26AC5D8 VA: 0x26B05D8
	|-Enumerable.Select<KeyValuePair<object, int>, object>
	|
	|-RVA: 0x26B08CC Offset: 0x26AC8CC VA: 0x26B08CC
	|-Enumerable.Select<KeyValuePair<object, float>, object>
	|
	|-RVA: 0x26B0BC0 Offset: 0x26ACBC0 VA: 0x26B0BC0
	|-Enumerable.Select<Nullable<UIMobPropertyLabel.IconValue>, int>
	|
	|-RVA: 0x26B0EB4 Offset: 0x26ACEB4 VA: 0x26B0EB4
	|-Enumerable.Select<byte, int>
	|
	|-RVA: 0x26B11A8 Offset: 0x26AD1A8 VA: 0x26B11A8
	|-Enumerable.Select<int, int>
	|
	|-RVA: 0x26B149C Offset: 0x26AD49C VA: 0x26B149C
	|-Enumerable.Select<Int32Enum, int>
	|
	|-RVA: 0x26B1790 Offset: 0x26AD790 VA: 0x26B1790
	|-Enumerable.Select<long, TimeSpan>
	|
	|-RVA: 0x26B1A84 Offset: 0x26ADA84 VA: 0x26B1A84
	|-Enumerable.Select<MobActionTargetData, Vector3>
	|
	|-RVA: 0x26B1D78 Offset: 0x26ADD78 VA: 0x26B1D78
	|-Enumerable.Select<object, bool>
	|
	|-RVA: 0x26B206C Offset: 0x26AE06C VA: 0x26B206C
	|-Enumerable.Select<object, byte>
	|
	|-RVA: 0x26B2360 Offset: 0x26AE360 VA: 0x26B2360
	|-Enumerable.Select<object, short>
	|
	|-RVA: 0x26B2654 Offset: 0x26AE654 VA: 0x26B2654
	|-Enumerable.Select<object, int>
	|
	|-RVA: 0x26B2948 Offset: 0x26AE948 VA: 0x26B2948
	|-Enumerable.Select<object, Int32Enum>
	|
	|-RVA: 0x26B2C3C Offset: 0x26AEC3C VA: 0x26B2C3C
	|-Enumerable.Select<object, long>
	|
	|-RVA: 0x26B2F30 Offset: 0x26AEF30 VA: 0x26B2F30
	|-Enumerable.Select<object, object>
	|
	|-RVA: 0x26B3294 Offset: 0x26AF294 VA: 0x26B3294
	|-Enumerable.Select<object, float>
	|
	|-RVA: 0x26B3588 Offset: 0x26AF588 VA: 0x26B3588
	|-Enumerable.Select<object, Vector3>
	|
	|-RVA: 0x26B387C Offset: 0x26AF87C VA: 0x26B387C
	|-Enumerable.Select<float, int>
	|
	|-RVA: 0x26B3B70 Offset: 0x26AFB70 VA: 0x26B3B70
	|-Enumerable.Select<TimeSpan, long>
	|
	|-RVA: 0x26B3E64 Offset: 0x26AFE64 VA: 0x26B3E64
	|-Enumerable.Select<Vector3, float>
	|
	|-RVA: 0x26B4158 Offset: 0x26B0158 VA: 0x26B4158
	|-Enumerable.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B3224 Offset: 0x26AF224 VA: 0x26B3224
	|-Enumerable.Select<object, object>
	|
	|-RVA: 0x26B446C Offset: 0x26B046C VA: 0x26B446C
	|-Enumerable.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<SelectIterator>d__5<TSource, TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> SelectIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B44E0 Offset: 0x26B04E0 VA: 0x26B44E0
	|-Enumerable.SelectIterator<object, object>
	|
	|-RVA: 0x26B4568 Offset: 0x26B0568 VA: 0x26B4568
	|-Enumerable.SelectIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27EF528 Offset: 0x27EB528 VA: 0x27EF528
	|-Enumerable.CombinePredicates<KeyValuePair<byte, BlackKnightCristaProperty>>
	|
	|-RVA: 0x27EF5E0 Offset: 0x27EB5E0 VA: 0x27EF5E0
	|-Enumerable.CombinePredicates<KeyValuePair<byte, byte>>
	|
	|-RVA: 0x27EF698 Offset: 0x27EB698 VA: 0x27EF698
	|-Enumerable.CombinePredicates<KeyValuePair<int, short>>
	|
	|-RVA: 0x27EF750 Offset: 0x27EB750 VA: 0x27EF750
	|-Enumerable.CombinePredicates<KeyValuePair<int, object>>
	|
	|-RVA: 0x27EF808 Offset: 0x27EB808 VA: 0x27EF808
	|-Enumerable.CombinePredicates<KeyValuePair<Int32Enum, EnhanceProperties2>>
	|
	|-RVA: 0x27EF8C0 Offset: 0x27EB8C0 VA: 0x27EF8C0
	|-Enumerable.CombinePredicates<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x27EF978 Offset: 0x27EB978 VA: 0x27EF978
	|-Enumerable.CombinePredicates<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x27EFA30 Offset: 0x27EBA30 VA: 0x27EFA30
	|-Enumerable.CombinePredicates<Nullable<UIMobPropertyLabel.IconValue>>
	|
	|-RVA: 0x27EFAE8 Offset: 0x27EBAE8 VA: 0x27EFAE8
	|-Enumerable.CombinePredicates<ValueTuple<int, int>>
	|
	|-RVA: 0x27EFBA0 Offset: 0x27EBBA0 VA: 0x27EFBA0
	|-Enumerable.CombinePredicates<bool>
	|
	|-RVA: 0x27EFC58 Offset: 0x27EBC58 VA: 0x27EFC58
	|-Enumerable.CombinePredicates<byte>
	|
	|-RVA: 0x27EFD10 Offset: 0x27EBD10 VA: 0x27EFD10
	|-Enumerable.CombinePredicates<short>
	|
	|-RVA: 0x27EFDC8 Offset: 0x27EBDC8 VA: 0x27EFDC8
	|-Enumerable.CombinePredicates<int>
	|
	|-RVA: 0x27EFE80 Offset: 0x27EBE80 VA: 0x27EFE80
	|-Enumerable.CombinePredicates<Int32Enum>
	|
	|-RVA: 0x27EFF38 Offset: 0x27EBF38 VA: 0x27EFF38
	|-Enumerable.CombinePredicates<long>
	|
	|-RVA: 0x27EFFF0 Offset: 0x27EBFF0 VA: 0x27EFFF0
	|-Enumerable.CombinePredicates<object>
	|
	|-RVA: 0x27F00A8 Offset: 0x27EC0A8 VA: 0x27F00A8
	|-Enumerable.CombinePredicates<float>
	|
	|-RVA: 0x27F0160 Offset: 0x27EC160 VA: 0x27F0160
	|-Enumerable.CombinePredicates<SkillIdData>
	|
	|-RVA: 0x27F0218 Offset: 0x27EC218 VA: 0x27F0218
	|-Enumerable.CombinePredicates<TimeSpan>
	|
	|-RVA: 0x27F02D0 Offset: 0x27EC2D0 VA: 0x27F02D0
	|-Enumerable.CombinePredicates<Vector3>
	|
	|-RVA: 0x27F0388 Offset: 0x27EC388 VA: 0x27F0388
	|-Enumerable.CombinePredicates<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x27F0448 Offset: 0x27EC448 VA: 0x27F0448
	|-Enumerable.CombinePredicates<HouseRecipeManager.RecipeData>
	|
	|-RVA: 0x27F0500 Offset: 0x27EC500 VA: 0x27F0500
	|-Enumerable.CombinePredicates<KadarElexioBuf.SkillIdData>
	|
	|-RVA: 0x27F05B8 Offset: 0x27EC5B8 VA: 0x27F05B8
	|-Enumerable.CombinePredicates<MobaRoomData.MobaAbilityMasterData>
	|
	|-RVA: 0x27F0670 Offset: 0x27EC670 VA: 0x27F0670
	|-Enumerable.CombinePredicates<TrophyManager.TrophyData>
	*/

	// RVA: -1 Offset: -1
	private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27F0728 Offset: 0x27EC728 VA: 0x27F0728
	|-Enumerable.CombineSelectors<KeyValuePair<byte, object>, byte, int>
	|
	|-RVA: 0x27F07E4 Offset: 0x27EC7E4 VA: 0x27F07E4
	|-Enumerable.CombineSelectors<KeyValuePair<int, object>, int, int>
	|
	|-RVA: 0x27F08A0 Offset: 0x27EC8A0 VA: 0x27F08A0
	|-Enumerable.CombineSelectors<KeyValuePair<int, object>, object, bool>
	|
	|-RVA: 0x27F095C Offset: 0x27EC95C VA: 0x27F095C
	|-Enumerable.CombineSelectors<KeyValuePair<int, object>, object, byte>
	|
	|-RVA: 0x27F0A18 Offset: 0x27ECA18 VA: 0x27F0A18
	|-Enumerable.CombineSelectors<KeyValuePair<int, object>, object, short>
	|
	|-RVA: 0x27F0AD4 Offset: 0x27ECAD4 VA: 0x27F0AD4
	|-Enumerable.CombineSelectors<KeyValuePair<int, object>, object, int>
	|
	|-RVA: 0x27F0B90 Offset: 0x27ECB90 VA: 0x27F0B90
	|-Enumerable.CombineSelectors<KeyValuePair<int, object>, object, Int32Enum>
	|
	|-RVA: 0x27F0C4C Offset: 0x27ECC4C VA: 0x27F0C4C
	|-Enumerable.CombineSelectors<KeyValuePair<int, object>, object, long>
	|
	|-RVA: 0x27F0D08 Offset: 0x27ECD08 VA: 0x27F0D08
	|-Enumerable.CombineSelectors<KeyValuePair<int, object>, object, object>
	|
	|-RVA: 0x27F0DC4 Offset: 0x27ECDC4 VA: 0x27F0DC4
	|-Enumerable.CombineSelectors<KeyValuePair<int, object>, object, float>
	|
	|-RVA: 0x27F0E80 Offset: 0x27ECE80 VA: 0x27F0E80
	|-Enumerable.CombineSelectors<KeyValuePair<int, object>, object, Vector3>
	|
	|-RVA: 0x27F0F3C Offset: 0x27ECF3C VA: 0x27F0F3C
	|-Enumerable.CombineSelectors<KeyValuePair<Int32Enum, EnhanceProperties2>, int, int>
	|
	|-RVA: 0x27F0FF8 Offset: 0x27ECFF8 VA: 0x27F0FF8
	|-Enumerable.CombineSelectors<KeyValuePair<Int32Enum, int>, int, int>
	|
	|-RVA: 0x27F10B4 Offset: 0x27ED0B4 VA: 0x27F10B4
	|-Enumerable.CombineSelectors<KeyValuePair<Int32Enum, int>, Int32Enum, int>
	|
	|-RVA: 0x27F1170 Offset: 0x27ED170 VA: 0x27F1170
	|-Enumerable.CombineSelectors<KeyValuePair<Int32Enum, int>, object, bool>
	|
	|-RVA: 0x27F122C Offset: 0x27ED22C VA: 0x27F122C
	|-Enumerable.CombineSelectors<KeyValuePair<Int32Enum, int>, object, byte>
	|
	|-RVA: 0x27F12E8 Offset: 0x27ED2E8 VA: 0x27F12E8
	|-Enumerable.CombineSelectors<KeyValuePair<Int32Enum, int>, object, short>
	|
	|-RVA: 0x27F13A4 Offset: 0x27ED3A4 VA: 0x27F13A4
	|-Enumerable.CombineSelectors<KeyValuePair<Int32Enum, int>, object, int>
	|
	|-RVA: 0x27F1460 Offset: 0x27ED460 VA: 0x27F1460
	|-Enumerable.CombineSelectors<KeyValuePair<Int32Enum, int>, object, Int32Enum>
	|
	|-RVA: 0x27F151C Offset: 0x27ED51C VA: 0x27F151C
	|-Enumerable.CombineSelectors<KeyValuePair<Int32Enum, int>, object, long>
	|
	|-RVA: 0x27F15D8 Offset: 0x27ED5D8 VA: 0x27F15D8
	|-Enumerable.CombineSelectors<KeyValuePair<Int32Enum, int>, object, object>
	|
	|-RVA: 0x27F1694 Offset: 0x27ED694 VA: 0x27F1694
	|-Enumerable.CombineSelectors<KeyValuePair<Int32Enum, int>, object, float>
	|
	|-RVA: 0x27F1750 Offset: 0x27ED750 VA: 0x27F1750
	|-Enumerable.CombineSelectors<KeyValuePair<Int32Enum, int>, object, Vector3>
	|
	|-RVA: 0x27F180C Offset: 0x27ED80C VA: 0x27F180C
	|-Enumerable.CombineSelectors<KeyValuePair<Int32Enum, object>, Int32Enum, int>
	|
	|-RVA: 0x27F18C8 Offset: 0x27ED8C8 VA: 0x27F18C8
	|-Enumerable.CombineSelectors<KeyValuePair<object, int>, object, bool>
	|
	|-RVA: 0x27F1984 Offset: 0x27ED984 VA: 0x27F1984
	|-Enumerable.CombineSelectors<KeyValuePair<object, int>, object, byte>
	|
	|-RVA: 0x27F1A40 Offset: 0x27EDA40 VA: 0x27F1A40
	|-Enumerable.CombineSelectors<KeyValuePair<object, int>, object, short>
	|
	|-RVA: 0x27F1AFC Offset: 0x27EDAFC VA: 0x27F1AFC
	|-Enumerable.CombineSelectors<KeyValuePair<object, int>, object, int>
	|
	|-RVA: 0x27F1BB8 Offset: 0x27EDBB8 VA: 0x27F1BB8
	|-Enumerable.CombineSelectors<KeyValuePair<object, int>, object, Int32Enum>
	|
	|-RVA: 0x27F1C74 Offset: 0x27EDC74 VA: 0x27F1C74
	|-Enumerable.CombineSelectors<KeyValuePair<object, int>, object, long>
	|
	|-RVA: 0x27F1D30 Offset: 0x27EDD30 VA: 0x27F1D30
	|-Enumerable.CombineSelectors<KeyValuePair<object, int>, object, object>
	|
	|-RVA: 0x27F1DEC Offset: 0x27EDDEC VA: 0x27F1DEC
	|-Enumerable.CombineSelectors<KeyValuePair<object, int>, object, float>
	|
	|-RVA: 0x27F1EA8 Offset: 0x27EDEA8 VA: 0x27F1EA8
	|-Enumerable.CombineSelectors<KeyValuePair<object, int>, object, Vector3>
	|
	|-RVA: 0x27F1F64 Offset: 0x27EDF64 VA: 0x27F1F64
	|-Enumerable.CombineSelectors<KeyValuePair<object, float>, object, bool>
	|
	|-RVA: 0x27F2020 Offset: 0x27EE020 VA: 0x27F2020
	|-Enumerable.CombineSelectors<KeyValuePair<object, float>, object, byte>
	|
	|-RVA: 0x27F20DC Offset: 0x27EE0DC VA: 0x27F20DC
	|-Enumerable.CombineSelectors<KeyValuePair<object, float>, object, short>
	|
	|-RVA: 0x27F2198 Offset: 0x27EE198 VA: 0x27F2198
	|-Enumerable.CombineSelectors<KeyValuePair<object, float>, object, int>
	|
	|-RVA: 0x27F2254 Offset: 0x27EE254 VA: 0x27F2254
	|-Enumerable.CombineSelectors<KeyValuePair<object, float>, object, Int32Enum>
	|
	|-RVA: 0x27F2310 Offset: 0x27EE310 VA: 0x27F2310
	|-Enumerable.CombineSelectors<KeyValuePair<object, float>, object, long>
	|
	|-RVA: 0x27F23CC Offset: 0x27EE3CC VA: 0x27F23CC
	|-Enumerable.CombineSelectors<KeyValuePair<object, float>, object, object>
	|
	|-RVA: 0x27F2488 Offset: 0x27EE488 VA: 0x27F2488
	|-Enumerable.CombineSelectors<KeyValuePair<object, float>, object, float>
	|
	|-RVA: 0x27F2544 Offset: 0x27EE544 VA: 0x27F2544
	|-Enumerable.CombineSelectors<KeyValuePair<object, float>, object, Vector3>
	|
	|-RVA: 0x27F2600 Offset: 0x27EE600 VA: 0x27F2600
	|-Enumerable.CombineSelectors<Nullable<UIMobPropertyLabel.IconValue>, int, int>
	|
	|-RVA: 0x27F26BC Offset: 0x27EE6BC VA: 0x27F26BC
	|-Enumerable.CombineSelectors<byte, int, int>
	|
	|-RVA: 0x27F2778 Offset: 0x27EE778 VA: 0x27F2778
	|-Enumerable.CombineSelectors<int, int, int>
	|
	|-RVA: 0x27F2834 Offset: 0x27EE834 VA: 0x27F2834
	|-Enumerable.CombineSelectors<Int32Enum, int, int>
	|
	|-RVA: 0x27F28F0 Offset: 0x27EE8F0 VA: 0x27F28F0
	|-Enumerable.CombineSelectors<long, TimeSpan, long>
	|
	|-RVA: 0x27F29AC Offset: 0x27EE9AC VA: 0x27F29AC
	|-Enumerable.CombineSelectors<MobActionTargetData, Vector3, float>
	|
	|-RVA: 0x27F2A68 Offset: 0x27EEA68 VA: 0x27F2A68
	|-Enumerable.CombineSelectors<object, byte, int>
	|
	|-RVA: 0x27F2B24 Offset: 0x27EEB24 VA: 0x27F2B24
	|-Enumerable.CombineSelectors<object, int, int>
	|
	|-RVA: 0x27F2BE0 Offset: 0x27EEBE0 VA: 0x27F2BE0
	|-Enumerable.CombineSelectors<object, Int32Enum, int>
	|
	|-RVA: 0x27F2C9C Offset: 0x27EEC9C VA: 0x27F2C9C
	|-Enumerable.CombineSelectors<object, long, TimeSpan>
	|
	|-RVA: 0x27F2D58 Offset: 0x27EED58 VA: 0x27F2D58
	|-Enumerable.CombineSelectors<object, object, bool>
	|
	|-RVA: 0x27F2E14 Offset: 0x27EEE14 VA: 0x27F2E14
	|-Enumerable.CombineSelectors<object, object, byte>
	|
	|-RVA: 0x27F2ED0 Offset: 0x27EEED0 VA: 0x27F2ED0
	|-Enumerable.CombineSelectors<object, object, short>
	|
	|-RVA: 0x27F2F8C Offset: 0x27EEF8C VA: 0x27F2F8C
	|-Enumerable.CombineSelectors<object, object, int>
	|
	|-RVA: 0x27F3048 Offset: 0x27EF048 VA: 0x27F3048
	|-Enumerable.CombineSelectors<object, object, Int32Enum>
	|
	|-RVA: 0x27F3104 Offset: 0x27EF104 VA: 0x27F3104
	|-Enumerable.CombineSelectors<object, object, long>
	|
	|-RVA: 0x27F31C0 Offset: 0x27EF1C0 VA: 0x27F31C0
	|-Enumerable.CombineSelectors<object, object, object>
	|
	|-RVA: 0x27F327C Offset: 0x27EF27C VA: 0x27F327C
	|-Enumerable.CombineSelectors<object, object, float>
	|
	|-RVA: 0x27F3338 Offset: 0x27EF338 VA: 0x27F3338
	|-Enumerable.CombineSelectors<object, object, Vector3>
	|
	|-RVA: 0x27F33F4 Offset: 0x27EF3F4 VA: 0x27F33F4
	|-Enumerable.CombineSelectors<object, float, int>
	|
	|-RVA: 0x27F34B0 Offset: 0x27EF4B0 VA: 0x27F34B0
	|-Enumerable.CombineSelectors<object, Vector3, float>
	|
	|-RVA: 0x27F356C Offset: 0x27EF56C VA: 0x27F356C
	|-Enumerable.CombineSelectors<float, int, int>
	|
	|-RVA: 0x27F3628 Offset: 0x27EF628 VA: 0x27F3628
	|-Enumerable.CombineSelectors<TimeSpan, long, TimeSpan>
	|
	|-RVA: 0x27F36E4 Offset: 0x27EF6E4 VA: 0x27F36E4
	|-Enumerable.CombineSelectors<Vector3, float, int>
	|
	|-RVA: 0x27F37A0 Offset: 0x27EF7A0 VA: 0x27F37A0
	|-Enumerable.CombineSelectors<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> SelectMany<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B4614 Offset: 0x26B0614 VA: 0x26B4614
	|-Enumerable.SelectMany<object, object>
	|
	|-RVA: 0x26B4684 Offset: 0x26B0684 VA: 0x26B4684
	|-Enumerable.SelectMany<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<SelectManyIterator>d__17<TSource, TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B46F8 Offset: 0x26B06F8 VA: 0x26B46F8
	|-Enumerable.SelectManyIterator<object, object>
	|
	|-RVA: 0x26B4780 Offset: 0x26B0780 VA: 0x26B4780
	|-Enumerable.SelectManyIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Take<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B801C Offset: 0x26B401C VA: 0x26B801C
	|-Enumerable.Take<object>
	|
	|-RVA: 0x26B807C Offset: 0x26B407C VA: 0x26B807C
	|-Enumerable.Take<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<TakeIterator>d__25<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> TakeIterator<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B80E0 Offset: 0x26B40E0 VA: 0x26B80E0
	|-Enumerable.TakeIterator<object>
	|
	|-RVA: 0x26B815C Offset: 0x26B415C VA: 0x26B815C
	|-Enumerable.TakeIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26ADAD0 Offset: 0x26A9AD0 VA: 0x26ADAD0
	|-Enumerable.OrderBy<KeyValuePair<byte, byte>, byte>
	|
	|-RVA: 0x26ADB3C Offset: 0x26A9B3C VA: 0x26ADB3C
	|-Enumerable.OrderBy<KeyValuePair<Int16Enum, object>, Int16Enum>
	|
	|-RVA: 0x26ADBA8 Offset: 0x26A9BA8 VA: 0x26ADBA8
	|-Enumerable.OrderBy<KeyValuePair<int, int>, int>
	|
	|-RVA: 0x26ADC14 Offset: 0x26A9C14 VA: 0x26ADC14
	|-Enumerable.OrderBy<KeyValuePair<int, object>, DateTime>
	|
	|-RVA: 0x26ADC80 Offset: 0x26A9C80 VA: 0x26ADC80
	|-Enumerable.OrderBy<KeyValuePair<int, object>, int>
	|
	|-RVA: 0x26ADCEC Offset: 0x26A9CEC VA: 0x26ADCEC
	|-Enumerable.OrderBy<KeyValuePair<Int32Enum, byte>, int>
	|
	|-RVA: 0x26ADD58 Offset: 0x26A9D58 VA: 0x26ADD58
	|-Enumerable.OrderBy<KeyValuePair<Int32Enum, object>, int>
	|
	|-RVA: 0x26ADDC4 Offset: 0x26A9DC4 VA: 0x26ADDC4
	|-Enumerable.OrderBy<KeyValuePair<object, int>, int>
	|
	|-RVA: 0x26ADE30 Offset: 0x26A9E30 VA: 0x26ADE30
	|-Enumerable.OrderBy<int, int>
	|
	|-RVA: 0x26ADE9C Offset: 0x26A9E9C VA: 0x26ADE9C
	|-Enumerable.OrderBy<Int32Enum, int>
	|
	|-RVA: 0x26ADF08 Offset: 0x26A9F08 VA: 0x26ADF08
	|-Enumerable.OrderBy<object, byte>
	|
	|-RVA: 0x26ADF74 Offset: 0x26A9F74 VA: 0x26ADF74
	|-Enumerable.OrderBy<object, DateTime>
	|
	|-RVA: 0x26ADFE0 Offset: 0x26A9FE0 VA: 0x26ADFE0
	|-Enumerable.OrderBy<object, short>
	|
	|-RVA: 0x26AE04C Offset: 0x26AA04C VA: 0x26AE04C
	|-Enumerable.OrderBy<object, int>
	|
	|-RVA: 0x26AE0B8 Offset: 0x26AA0B8 VA: 0x26AE0B8
	|-Enumerable.OrderBy<object, Int32Enum>
	|
	|-RVA: 0x26AE124 Offset: 0x26AA124 VA: 0x26AE124
	|-Enumerable.OrderBy<object, object>
	|
	|-RVA: 0x26AE190 Offset: 0x26AA190 VA: 0x26AE190
	|-Enumerable.OrderBy<object, float>
	|
	|-RVA: 0x26AE1FC Offset: 0x26AA1FC VA: 0x26AE1FC
	|-Enumerable.OrderBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0x26AE26C Offset: 0x26AA26C VA: 0x26AE26C
	|-Enumerable.OrderBy<TrophyManager.TrophyData, int>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26AE2D8 Offset: 0x26AA2D8 VA: 0x26AE2D8
	|-Enumerable.OrderByDescending<KeyValuePair<byte, object>, byte>
	|
	|-RVA: 0x26AE344 Offset: 0x26AA344 VA: 0x26AE344
	|-Enumerable.OrderByDescending<KeyValuePair<int, short>, short>
	|
	|-RVA: 0x26AE3B0 Offset: 0x26AA3B0 VA: 0x26AE3B0
	|-Enumerable.OrderByDescending<KeyValuePair<int, object>, DateTime>
	|
	|-RVA: 0x26AE41C Offset: 0x26AA41C VA: 0x26AE41C
	|-Enumerable.OrderByDescending<KeyValuePair<int, object>, int>
	|
	|-RVA: 0x26AE488 Offset: 0x26AA488 VA: 0x26AE488
	|-Enumerable.OrderByDescending<KeyValuePair<long, short>, short>
	|
	|-RVA: 0x26AE4F4 Offset: 0x26AA4F4 VA: 0x26AE4F4
	|-Enumerable.OrderByDescending<KeyValuePair<object, int>, int>
	|
	|-RVA: 0x26AE560 Offset: 0x26AA560 VA: 0x26AE560
	|-Enumerable.OrderByDescending<ValueTuple<int, int>, int>
	|
	|-RVA: 0x26AE5CC Offset: 0x26AA5CC VA: 0x26AE5CC
	|-Enumerable.OrderByDescending<int, int>
	|
	|-RVA: 0x26AE638 Offset: 0x26AA638 VA: 0x26AE638
	|-Enumerable.OrderByDescending<object, bool>
	|
	|-RVA: 0x26AE6A4 Offset: 0x26AA6A4 VA: 0x26AE6A4
	|-Enumerable.OrderByDescending<object, byte>
	|
	|-RVA: 0x26AE710 Offset: 0x26AA710 VA: 0x26AE710
	|-Enumerable.OrderByDescending<object, DateTime>
	|
	|-RVA: 0x26AE77C Offset: 0x26AA77C VA: 0x26AE77C
	|-Enumerable.OrderByDescending<object, int>
	|
	|-RVA: 0x26AE7E8 Offset: 0x26AA7E8 VA: 0x26AE7E8
	|-Enumerable.OrderByDescending<object, float>
	|
	|-RVA: 0x26AE854 Offset: 0x26AA854 VA: 0x26AE854
	|-Enumerable.OrderByDescending<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B8208 Offset: 0x26B4208 VA: 0x26B8208
	|-Enumerable.ThenBy<object, byte>
	|
	|-RVA: 0x26B82D4 Offset: 0x26B42D4 VA: 0x26B82D4
	|-Enumerable.ThenBy<object, short>
	|
	|-RVA: 0x26B83A0 Offset: 0x26B43A0 VA: 0x26B83A0
	|-Enumerable.ThenBy<object, int>
	|
	|-RVA: 0x26B846C Offset: 0x26B446C VA: 0x26B846C
	|-Enumerable.ThenBy<object, long>
	|
	|-RVA: 0x26B8538 Offset: 0x26B4538 VA: 0x26B8538
	|-Enumerable.ThenBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B8604 Offset: 0x26B4604 VA: 0x26B8604
	|-Enumerable.ThenByDescending<object, short>
	|
	|-RVA: 0x26B86D0 Offset: 0x26B46D0 VA: 0x26B86D0
	|-Enumerable.ThenByDescending<object, int>
	|
	|-RVA: 0x26B879C Offset: 0x26B479C VA: 0x26B879C
	|-Enumerable.ThenByDescending<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28065F0 Offset: 0x28025F0 VA: 0x28065F0
	|-Enumerable.GroupBy<int, int>
	|
	|-RVA: 0x2806680 Offset: 0x2802680 VA: 0x2806680
	|-Enumerable.GroupBy<object, byte>
	|
	|-RVA: 0x2806710 Offset: 0x2802710 VA: 0x2806710
	|-Enumerable.GroupBy<object, object>
	|
	|-RVA: 0x28067A0 Offset: 0x28027A0 VA: 0x28067A0
	|-Enumerable.GroupBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Concat<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27F3864 Offset: 0x27EF864 VA: 0x27F3864
	|-Enumerable.Concat<object>
	|
	|-RVA: 0x27F38D4 Offset: 0x27EF8D4 VA: 0x27F38D4
	|-Enumerable.Concat<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<ConcatIterator>d__59<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27F3948 Offset: 0x27EF948 VA: 0x27F3948
	|-Enumerable.ConcatIterator<object>
	|
	|-RVA: 0x27F39D0 Offset: 0x27EF9D0 VA: 0x27F39D0
	|-Enumerable.ConcatIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Distinct<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27FC138 Offset: 0x27F8138 VA: 0x27FC138
	|-Enumerable.Distinct<byte>
	|
	|-RVA: 0x27FC194 Offset: 0x27F8194 VA: 0x27FC194
	|-Enumerable.Distinct<int>
	|
	|-RVA: 0x27FC1F0 Offset: 0x27F81F0 VA: 0x27FC1F0
	|-Enumerable.Distinct<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<DistinctIterator>d__68<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27FC250 Offset: 0x27F8250 VA: 0x27FC250
	|-Enumerable.DistinctIterator<byte>
	|
	|-RVA: 0x27FC2D8 Offset: 0x27F82D8 VA: 0x27FC2D8
	|-Enumerable.DistinctIterator<int>
	|
	|-RVA: 0x27FC360 Offset: 0x27F8360 VA: 0x27FC360
	|-Enumerable.DistinctIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Union<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26BB398 Offset: 0x26B7398 VA: 0x26BB398
	|-Enumerable.Union<char>
	|
	|-RVA: 0x26BB40C Offset: 0x26B740C VA: 0x26BB40C
	|-Enumerable.Union<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<UnionIterator>d__71<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26BB484 Offset: 0x26B7484 VA: 0x26BB484
	|-Enumerable.UnionIterator<char>
	|
	|-RVA: 0x26BB528 Offset: 0x26B7528 VA: 0x26BB528
	|-Enumerable.UnionIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Except<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27FDB34 Offset: 0x27F9B34 VA: 0x27FDB34
	|-Enumerable.Except<int>
	|
	|-RVA: 0x27FDBA8 Offset: 0x27F9BA8 VA: 0x27FDBA8
	|-Enumerable.Except<Int32Enum>
	|
	|-RVA: 0x27FDC1C Offset: 0x27F9C1C VA: 0x27FDC1C
	|-Enumerable.Except<object>
	|
	|-RVA: 0x27FDC90 Offset: 0x27F9C90 VA: 0x27FDC90
	|-Enumerable.Except<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<ExceptIterator>d__77<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27FDD08 Offset: 0x27F9D08 VA: 0x27FDD08
	|-Enumerable.ExceptIterator<int>
	|
	|-RVA: 0x27FDDAC Offset: 0x27F9DAC VA: 0x27FDDAC
	|-Enumerable.ExceptIterator<Int32Enum>
	|
	|-RVA: 0x27FDE50 Offset: 0x27F9E50 VA: 0x27FDE50
	|-Enumerable.ExceptIterator<object>
	|
	|-RVA: 0x27FDEF4 Offset: 0x27F9EF4 VA: 0x27FDEF4
	|-Enumerable.ExceptIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Reverse<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26AEBC0 Offset: 0x26AABC0 VA: 0x26AEBC0
	|-Enumerable.Reverse<KeyValuePair<int, object>>
	|
	|-RVA: 0x26AEC18 Offset: 0x26AAC18 VA: 0x26AEC18
	|-Enumerable.Reverse<object>
	|
	|-RVA: 0x26AEC70 Offset: 0x26AAC70 VA: 0x26AEC70
	|-Enumerable.Reverse<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<ReverseIterator>d__79<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ReverseIterator<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26AECCC Offset: 0x26AACCC VA: 0x26AECCC
	|-Enumerable.ReverseIterator<KeyValuePair<int, object>>
	|
	|-RVA: 0x26AED40 Offset: 0x26AAD40 VA: 0x26AED40
	|-Enumerable.ReverseIterator<object>
	|
	|-RVA: 0x26AEDB4 Offset: 0x26AADB4 VA: 0x26AEDB4
	|-Enumerable.ReverseIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B482C Offset: 0x26B082C VA: 0x26B482C
	|-Enumerable.SequenceEqual<object>
	|
	|-RVA: 0x26B4870 Offset: 0x26B0870 VA: 0x26B4870
	|-Enumerable.SequenceEqual<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B48B8 Offset: 0x26B08B8 VA: 0x26B48B8
	|-Enumerable.SequenceEqual<object>
	|
	|-RVA: 0x26B4F94 Offset: 0x26B0F94 VA: 0x26B4F94
	|-Enumerable.SequenceEqual<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource[] ToArray<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B8868 Offset: 0x26B4868 VA: 0x26B8868
	|-Enumerable.ToArray<KeyValuePair<int, object>>
	|
	|-RVA: 0x26B88F0 Offset: 0x26B48F0 VA: 0x26B88F0
	|-Enumerable.ToArray<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x26B8978 Offset: 0x26B4978 VA: 0x26B8978
	|-Enumerable.ToArray<ValueTuple<int, object>>
	|
	|-RVA: 0x26B8A00 Offset: 0x26B4A00 VA: 0x26B8A00
	|-Enumerable.ToArray<bool>
	|
	|-RVA: 0x26B8A88 Offset: 0x26B4A88 VA: 0x26B8A88
	|-Enumerable.ToArray<byte>
	|
	|-RVA: 0x26B8B10 Offset: 0x26B4B10 VA: 0x26B8B10
	|-Enumerable.ToArray<char>
	|
	|-RVA: 0x26B8B98 Offset: 0x26B4B98 VA: 0x26B8B98
	|-Enumerable.ToArray<short>
	|
	|-RVA: 0x26B8C20 Offset: 0x26B4C20 VA: 0x26B8C20
	|-Enumerable.ToArray<int>
	|
	|-RVA: 0x26B8CA8 Offset: 0x26B4CA8 VA: 0x26B8CA8
	|-Enumerable.ToArray<Int32Enum>
	|
	|-RVA: 0x26B8D30 Offset: 0x26B4D30 VA: 0x26B8D30
	|-Enumerable.ToArray<long>
	|
	|-RVA: 0x26B8DB8 Offset: 0x26B4DB8 VA: 0x26B8DB8
	|-Enumerable.ToArray<object>
	|
	|-RVA: 0x26B8E40 Offset: 0x26B4E40 VA: 0x26B8E40
	|-Enumerable.ToArray<TimeSpan>
	|
	|-RVA: 0x26B8EC8 Offset: 0x26B4EC8 VA: 0x26B8EC8
	|-Enumerable.ToArray<Vector3>
	|
	|-RVA: 0x26B8F50 Offset: 0x26B4F50 VA: 0x26B8F50
	|-Enumerable.ToArray<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static List<TSource> ToList<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26BADC4 Offset: 0x26B6DC4 VA: 0x26BADC4
	|-Enumerable.ToList<KeyValuePair<ArchetypeUid, object>>
	|
	|-RVA: 0x26BAE40 Offset: 0x26B6E40 VA: 0x26BAE40
	|-Enumerable.ToList<KeyValuePair<int, object>>
	|
	|-RVA: 0x26BAEBC Offset: 0x26B6EBC VA: 0x26BAEBC
	|-Enumerable.ToList<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x26BAF38 Offset: 0x26B6F38 VA: 0x26BAF38
	|-Enumerable.ToList<ValueTuple<int, int>>
	|
	|-RVA: 0x26BAFB4 Offset: 0x26B6FB4 VA: 0x26BAFB4
	|-Enumerable.ToList<byte>
	|
	|-RVA: 0x26BB030 Offset: 0x26B7030 VA: 0x26BB030
	|-Enumerable.ToList<short>
	|
	|-RVA: 0x26BB0AC Offset: 0x26B70AC VA: 0x26BB0AC
	|-Enumerable.ToList<int>
	|
	|-RVA: 0x26BB128 Offset: 0x26B7128 VA: 0x26BB128
	|-Enumerable.ToList<Int32Enum>
	|
	|-RVA: 0x26BB1A4 Offset: 0x26B71A4 VA: 0x26BB1A4
	|-Enumerable.ToList<object>
	|
	|-RVA: 0x26BB220 Offset: 0x26B7220 VA: 0x26BB220
	|-Enumerable.ToList<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x26BB2A0 Offset: 0x26B72A0 VA: 0x26BB2A0
	|-Enumerable.ToList<HouseRecipeManager.RecipeData>
	|
	|-RVA: 0x26BB31C Offset: 0x26B731C VA: 0x26BB31C
	|-Enumerable.ToList<MobaRoomData.MobaAbilityMasterData>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B8FDC Offset: 0x26B4FDC VA: 0x26B8FDC
	|-Enumerable.ToDictionary<KeyValuePair<int, object>, int, object>
	|
	|-RVA: 0x26B9030 Offset: 0x26B5030 VA: 0x26B9030
	|-Enumerable.ToDictionary<KeyValuePair<Int32Enum, byte>, Int32Enum, byte>
	|
	|-RVA: 0x26B9084 Offset: 0x26B5084 VA: 0x26B9084
	|-Enumerable.ToDictionary<KeyValuePair<Int32Enum, object>, Int32Enum, object>
	|
	|-RVA: 0x26B90D8 Offset: 0x26B50D8 VA: 0x26B90D8
	|-Enumerable.ToDictionary<KeyValuePair<object, Int32Enum>, Int32Enum, object>
	|
	|-RVA: 0x26B912C Offset: 0x26B512C VA: 0x26B912C
	|-Enumerable.ToDictionary<KeyValuePair<object, object>, object, object>
	|
	|-RVA: 0x26B9180 Offset: 0x26B5180 VA: 0x26B9180
	|-Enumerable.ToDictionary<object, object, Int32Enum>
	|
	|-RVA: 0x26B91D4 Offset: 0x26B51D4 VA: 0x26B91D4
	|-Enumerable.ToDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B922C Offset: 0x26B522C VA: 0x26B922C
	|-Enumerable.ToDictionary<KeyValuePair<int, object>, int, object>
	|
	|-RVA: 0x26B95EC Offset: 0x26B55EC VA: 0x26B95EC
	|-Enumerable.ToDictionary<KeyValuePair<Int32Enum, byte>, Int32Enum, byte>
	|
	|-RVA: 0x26B99A0 Offset: 0x26B59A0 VA: 0x26B99A0
	|-Enumerable.ToDictionary<KeyValuePair<Int32Enum, object>, Int32Enum, object>
	|
	|-RVA: 0x26B9D60 Offset: 0x26B5D60 VA: 0x26B9D60
	|-Enumerable.ToDictionary<KeyValuePair<object, Int32Enum>, Int32Enum, object>
	|
	|-RVA: 0x26BA120 Offset: 0x26B6120 VA: 0x26BA120
	|-Enumerable.ToDictionary<KeyValuePair<object, object>, object, object>
	|
	|-RVA: 0x26BA4E0 Offset: 0x26B64E0 VA: 0x26BA4E0
	|-Enumerable.ToDictionary<object, object, Int32Enum>
	|
	|-RVA: 0x26BA894 Offset: 0x26B6894 VA: 0x26BA894
	|-Enumerable.ToDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Cast<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27EED14 Offset: 0x27EAD14 VA: 0x27EED14
	|-Enumerable.Cast<Nullable<SkillIdData>>
	|
	|-RVA: 0x27EEDA0 Offset: 0x27EADA0 VA: 0x27EEDA0
	|-Enumerable.Cast<Nullable<KadarElexioBuf.SkillIdData>>
	|
	|-RVA: 0x27EEE2C Offset: 0x27EAE2C VA: 0x27EEE2C
	|-Enumerable.Cast<Nullable<TrophyManager.TrophyData>>
	|
	|-RVA: 0x27EEEB8 Offset: 0x27EAEB8 VA: 0x27EEEB8
	|-Enumerable.Cast<DictionaryEntry>
	|
	|-RVA: 0x27EEF44 Offset: 0x27EAF44 VA: 0x27EEF44
	|-Enumerable.Cast<int>
	|
	|-RVA: 0x27EEFD0 Offset: 0x27EAFD0 VA: 0x27EEFD0
	|-Enumerable.Cast<Int32Enum>
	|
	|-RVA: 0x27EF05C Offset: 0x27EB05C VA: 0x27EF05C
	|-Enumerable.Cast<object>
	|
	|-RVA: 0x27EF0E8 Offset: 0x27EB0E8 VA: 0x27EF0E8
	|-Enumerable.Cast<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<CastIterator>d__99<TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27EF178 Offset: 0x27EB178 VA: 0x27EF178
	|-Enumerable.CastIterator<Nullable<SkillIdData>>
	|
	|-RVA: 0x27EF1EC Offset: 0x27EB1EC VA: 0x27EF1EC
	|-Enumerable.CastIterator<Nullable<KadarElexioBuf.SkillIdData>>
	|
	|-RVA: 0x27EF260 Offset: 0x27EB260 VA: 0x27EF260
	|-Enumerable.CastIterator<Nullable<TrophyManager.TrophyData>>
	|
	|-RVA: 0x27EF2D4 Offset: 0x27EB2D4 VA: 0x27EF2D4
	|-Enumerable.CastIterator<DictionaryEntry>
	|
	|-RVA: 0x27EF348 Offset: 0x27EB348 VA: 0x27EF348
	|-Enumerable.CastIterator<int>
	|
	|-RVA: 0x27EF3BC Offset: 0x27EB3BC VA: 0x27EF3BC
	|-Enumerable.CastIterator<Int32Enum>
	|
	|-RVA: 0x27EF430 Offset: 0x27EB430 VA: 0x27EF430
	|-Enumerable.CastIterator<object>
	|
	|-RVA: 0x27EF4A4 Offset: 0x27EB4A4 VA: 0x27EF4A4
	|-Enumerable.CastIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource First<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27FDFC0 Offset: 0x27F9FC0 VA: 0x27FDFC0
	|-Enumerable.First<KeyValuePair<int, object>>
	|
	|-RVA: 0x27FE428 Offset: 0x27FA428 VA: 0x27FE428
	|-Enumerable.First<KeyValuePair<int, float>>
	|
	|-RVA: 0x27FE878 Offset: 0x27FA878 VA: 0x27FE878
	|-Enumerable.First<object>
	|
	|-RVA: 0x27FECC8 Offset: 0x27FACC8 VA: 0x27FECC8
	|-Enumerable.First<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource First<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27FF1DC Offset: 0x27FB1DC VA: 0x27FF1DC
	|-Enumerable.First<KeyValuePair<int, int>>
	|
	|-RVA: 0x27FF538 Offset: 0x27FB538 VA: 0x27FF538
	|-Enumerable.First<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x27FF8B0 Offset: 0x27FB8B0 VA: 0x27FF8B0
	|-Enumerable.First<KeyValuePair<object, UIHouseAddressManager.Town>>
	|
	|-RVA: 0x27FFC28 Offset: 0x27FBC28 VA: 0x27FFC28
	|-Enumerable.First<object>
	|
	|-RVA: 0x27FFF84 Offset: 0x27FBF84 VA: 0x27FFF84
	|-Enumerable.First<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2800418 Offset: 0x27FC418 VA: 0x2800418
	|-Enumerable.FirstOrDefault<KeyValuePair<byte, byte>>
	|
	|-RVA: 0x280085C Offset: 0x27FC85C VA: 0x280085C
	|-Enumerable.FirstOrDefault<KeyValuePair<int, object>>
	|
	|-RVA: 0x2800CB8 Offset: 0x27FCCB8 VA: 0x2800CB8
	|-Enumerable.FirstOrDefault<KeyValuePair<int, Vector3>>
	|
	|-RVA: 0x2801114 Offset: 0x27FD114 VA: 0x2801114
	|-Enumerable.FirstOrDefault<Nullable<SkillIdData>>
	|
	|-RVA: 0x2801570 Offset: 0x27FD570 VA: 0x2801570
	|-Enumerable.FirstOrDefault<Nullable<KadarElexioBuf.SkillIdData>>
	|
	|-RVA: 0x28019CC Offset: 0x27FD9CC VA: 0x28019CC
	|-Enumerable.FirstOrDefault<Nullable<TrophyManager.TrophyData>>
	|
	|-RVA: 0x2801E28 Offset: 0x27FDE28 VA: 0x2801E28
	|-Enumerable.FirstOrDefault<Int32Enum>
	|
	|-RVA: 0x2802270 Offset: 0x27FE270 VA: 0x2802270
	|-Enumerable.FirstOrDefault<MobActionTargetData>
	|
	|-RVA: 0x28026F4 Offset: 0x27FE6F4 VA: 0x28026F4
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x2802B3C Offset: 0x27FEB3C VA: 0x2802B3C
	|-Enumerable.FirstOrDefault<Vector3>
	|
	|-RVA: 0x2802FAC Offset: 0x27FEFAC VA: 0x2802FAC
	|-Enumerable.FirstOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28034EC Offset: 0x27FF4EC VA: 0x28034EC
	|-Enumerable.FirstOrDefault<KeyValuePair<int, object>>
	|
	|-RVA: 0x2803860 Offset: 0x27FF860 VA: 0x2803860
	|-Enumerable.FirstOrDefault<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x2803BB4 Offset: 0x27FFBB4 VA: 0x2803BB4
	|-Enumerable.FirstOrDefault<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x2803F28 Offset: 0x27FFF28 VA: 0x2803F28
	|-Enumerable.FirstOrDefault<KeyValuePair<object, int>>
	|
	|-RVA: 0x280429C Offset: 0x280029C VA: 0x280429C
	|-Enumerable.FirstOrDefault<byte>
	|
	|-RVA: 0x28045F0 Offset: 0x28005F0 VA: 0x28045F0
	|-Enumerable.FirstOrDefault<EnchantBonusData>
	|
	|-RVA: 0x2804948 Offset: 0x2800948 VA: 0x2804948
	|-Enumerable.FirstOrDefault<int>
	|
	|-RVA: 0x2804C9C Offset: 0x2800C9C VA: 0x2804C9C
	|-Enumerable.FirstOrDefault<Int32Enum>
	|
	|-RVA: 0x2804FF0 Offset: 0x2800FF0 VA: 0x2804FF0
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x2805344 Offset: 0x2801344 VA: 0x2805344
	|-Enumerable.FirstOrDefault<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x2805800 Offset: 0x2801800 VA: 0x2805800
	|-Enumerable.FirstOrDefault<HouseCuisineManager.CuisineRecipeData>
	|
	|-RVA: 0x2805BB4 Offset: 0x2801BB4 VA: 0x2805BB4
	|-Enumerable.FirstOrDefault<MobaRoomData.MobaAbilityMasterData>
	|
	|-RVA: 0x2805F28 Offset: 0x2801F28 VA: 0x2805F28
	|-Enumerable.FirstOrDefault<TrophyManager.TrophyData>
	|
	|-RVA: 0x280627C Offset: 0x280227C VA: 0x280627C
	|-Enumerable.FirstOrDefault<UIScenarioOrderPanel.MissionData>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Last<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2806838 Offset: 0x2802838 VA: 0x2806838
	|-Enumerable.Last<byte>
	|
	|-RVA: 0x26A8358 Offset: 0x26A4358 VA: 0x26A8358
	|-Enumerable.Last<short>
	|
	|-RVA: 0x26A8808 Offset: 0x26A4808 VA: 0x26A8808
	|-Enumerable.Last<int>
	|
	|-RVA: 0x26A8CB8 Offset: 0x26A4CB8 VA: 0x26A8CB8
	|-Enumerable.Last<object>
	|
	|-RVA: 0x26A9168 Offset: 0x26A5168 VA: 0x26A9168
	|-Enumerable.Last<Vector3>
	|
	|-RVA: 0x26A9640 Offset: 0x26A5640 VA: 0x26A9640
	|-Enumerable.Last<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26A9BF0 Offset: 0x26A5BF0 VA: 0x26A9BF0
	|-Enumerable.LastOrDefault<object>
	|
	|-RVA: 0x26AA098 Offset: 0x26A6098 VA: 0x26AA098
	|-Enumerable.LastOrDefault<Vector3>
	|
	|-RVA: 0x26AA568 Offset: 0x26A6568 VA: 0x26AA568
	|-Enumerable.LastOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26AAB44 Offset: 0x26A6B44 VA: 0x26AAB44
	|-Enumerable.LastOrDefault<object>
	|
	|-RVA: 0x26AAE80 Offset: 0x26A6E80 VA: 0x26AAE80
	|-Enumerable.LastOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Single<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B5714 Offset: 0x26B1714 VA: 0x26B5714
	|-Enumerable.Single<object>
	|
	|-RVA: 0x26B5BE0 Offset: 0x26B1BE0 VA: 0x26B5BE0
	|-Enumerable.Single<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Single<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B61B8 Offset: 0x26B21B8 VA: 0x26B61B8
	|-Enumerable.Single<object>
	|
	|-RVA: 0x26B655C Offset: 0x26B255C VA: 0x26B655C
	|-Enumerable.Single<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B6A38 Offset: 0x26B2A38 VA: 0x26B6A38
	|-Enumerable.SingleOrDefault<object>
	|
	|-RVA: 0x26B6F00 Offset: 0x26B2F00 VA: 0x26B6F00
	|-Enumerable.SingleOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B74E4 Offset: 0x26B34E4 VA: 0x26B74E4
	|-Enumerable.SingleOrDefault<object>
	|
	|-RVA: 0x26B7884 Offset: 0x26B3884 VA: 0x26B7884
	|-Enumerable.SingleOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource ElementAt<TSource>(IEnumerable<TSource> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27FC40C Offset: 0x27F840C VA: 0x27FC40C
	|-Enumerable.ElementAt<KeyValuePair<short, byte>>
	|
	|-RVA: 0x27FC810 Offset: 0x27F8810 VA: 0x27FC810
	|-Enumerable.ElementAt<object>
	|
	|-RVA: 0x27FCC00 Offset: 0x27F8C00 VA: 0x27FCC00
	|-Enumerable.ElementAt<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource ElementAtOrDefault<TSource>(IEnumerable<TSource> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27FD0C4 Offset: 0x27F90C4 VA: 0x27FD0C4
	|-Enumerable.ElementAtOrDefault<object>
	|
	|-RVA: 0x27FD520 Offset: 0x27F9520 VA: 0x27FD520
	|-Enumerable.ElementAtOrDefault<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x311538C Offset: 0x311138C VA: 0x311538C
	public static IEnumerable<int> Range(int start, int count) { }

	[IteratorStateMachine(typeof(Enumerable.<RangeIterator>d__115))]
	// RVA: 0x31153D8 Offset: 0x31113D8 VA: 0x31153D8
	private static IEnumerable<int> RangeIterator(int start, int count) { }

	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26AE8C4 Offset: 0x26AA8C4 VA: 0x26AE8C4
	|-Enumerable.Repeat<byte>
	|
	|-RVA: 0x26AE924 Offset: 0x26AA924 VA: 0x26AE924
	|-Enumerable.Repeat<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<RepeatIterator>d__117<TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> RepeatIterator<TResult>(TResult element, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26AEA24 Offset: 0x26AAA24 VA: 0x26AEA24
	|-Enumerable.RepeatIterator<byte>
	|
	|-RVA: 0x26AEA94 Offset: 0x26AAA94 VA: 0x26AEA94
	|-Enumerable.RepeatIterator<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Empty<TResult>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27FDA7C Offset: 0x27F9A7C VA: 0x27FDA7C
	|-Enumerable.Empty<object>
	|
	|-RVA: 0x27FDAD8 Offset: 0x27F9AD8 VA: 0x27FDAD8
	|-Enumerable.Empty<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Any<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27EBAB0 Offset: 0x27E7AB0 VA: 0x27EBAB0
	|-Enumerable.Any<KeyValuePair<Int32Enum, float>>
	|
	|-RVA: 0x27EBD48 Offset: 0x27E7D48 VA: 0x27EBD48
	|-Enumerable.Any<object>
	|
	|-RVA: 0x27EBFE0 Offset: 0x27E7FE0 VA: 0x27EBFE0
	|-Enumerable.Any<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Any<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27EC278 Offset: 0x27E8278 VA: 0x27EC278
	|-Enumerable.Any<KeyValuePair<byte, byte>>
	|
	|-RVA: 0x27EC5AC Offset: 0x27E85AC VA: 0x27EC5AC
	|-Enumerable.Any<KeyValuePair<int, object>>
	|
	|-RVA: 0x27EC8E8 Offset: 0x27E88E8 VA: 0x27EC8E8
	|-Enumerable.Any<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x27ECC24 Offset: 0x27E8C24 VA: 0x27ECC24
	|-Enumerable.Any<ValueTuple<Vector3, Vector3>>
	|
	|-RVA: 0x27ECF80 Offset: 0x27E8F80 VA: 0x27ECF80
	|-Enumerable.Any<bool>
	|
	|-RVA: 0x27ED2B4 Offset: 0x27E92B4 VA: 0x27ED2B4
	|-Enumerable.Any<byte>
	|
	|-RVA: 0x27ED5E4 Offset: 0x27E95E4 VA: 0x27ED5E4
	|-Enumerable.Any<short>
	|
	|-RVA: 0x27ED914 Offset: 0x27E9914 VA: 0x27ED914
	|-Enumerable.Any<int>
	|
	|-RVA: 0x27EDC44 Offset: 0x27E9C44 VA: 0x27EDC44
	|-Enumerable.Any<Int32Enum>
	|
	|-RVA: 0x27EDF74 Offset: 0x27E9F74 VA: 0x27EDF74
	|-Enumerable.Any<object>
	|
	|-RVA: 0x27EE2A4 Offset: 0x27EA2A4 VA: 0x27EE2A4
	|-Enumerable.Any<SkillIdData>
	|
	|-RVA: 0x27EE5D4 Offset: 0x27EA5D4 VA: 0x27EE5D4
	|-Enumerable.Any<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x27EE9E4 Offset: 0x27EA9E4 VA: 0x27EE9E4
	|-Enumerable.Any<KadarElexioBuf.SkillIdData>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool All<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27EB04C Offset: 0x27E704C VA: 0x27EB04C
	|-Enumerable.All<byte>
	|
	|-RVA: 0x27EB378 Offset: 0x27E7378 VA: 0x27EB378
	|-Enumerable.All<object>
	|
	|-RVA: 0x27EB6A4 Offset: 0x27E76A4 VA: 0x27EB6A4
	|-Enumerable.All<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int Count<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27F5D4C Offset: 0x27F1D4C VA: 0x27F5D4C
	|-Enumerable.Count<KeyValuePair<byte, BlackKnightCristaProperty>>
	|
	|-RVA: 0x27F6118 Offset: 0x27F2118 VA: 0x27F6118
	|-Enumerable.Count<KeyValuePair<byte, byte>>
	|
	|-RVA: 0x27F64E4 Offset: 0x27F24E4 VA: 0x27F64E4
	|-Enumerable.Count<KeyValuePair<byte, object>>
	|
	|-RVA: 0x27F68B0 Offset: 0x27F28B0 VA: 0x27F68B0
	|-Enumerable.Count<KeyValuePair<short, byte>>
	|
	|-RVA: 0x27F6C7C Offset: 0x27F2C7C VA: 0x27F6C7C
	|-Enumerable.Count<KeyValuePair<Int16Enum, object>>
	|
	|-RVA: 0x27F7048 Offset: 0x27F3048 VA: 0x27F7048
	|-Enumerable.Count<KeyValuePair<int, object>>
	|
	|-RVA: 0x27F7414 Offset: 0x27F3414 VA: 0x27F7414
	|-Enumerable.Count<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x27F77E0 Offset: 0x27F37E0 VA: 0x27F77E0
	|-Enumerable.Count<KeyValuePair<object, float>>
	|
	|-RVA: 0x27F7BAC Offset: 0x27F3BAC VA: 0x27F7BAC
	|-Enumerable.Count<ValueTuple<int, int>>
	|
	|-RVA: 0x27F7F78 Offset: 0x27F3F78 VA: 0x27F7F78
	|-Enumerable.Count<bool>
	|
	|-RVA: 0x27F8344 Offset: 0x27F4344 VA: 0x27F8344
	|-Enumerable.Count<byte>
	|
	|-RVA: 0x27F8710 Offset: 0x27F4710 VA: 0x27F8710
	|-Enumerable.Count<DefencePoint2>
	|
	|-RVA: 0x27F8ADC Offset: 0x27F4ADC VA: 0x27F8ADC
	|-Enumerable.Count<short>
	|
	|-RVA: 0x27F8EA8 Offset: 0x27F4EA8 VA: 0x27F8EA8
	|-Enumerable.Count<int>
	|
	|-RVA: 0x27F9274 Offset: 0x27F5274 VA: 0x27F9274
	|-Enumerable.Count<Int32Enum>
	|
	|-RVA: 0x27F9640 Offset: 0x27F5640 VA: 0x27F9640
	|-Enumerable.Count<object>
	|
	|-RVA: 0x27F9A0C Offset: 0x27F5A0C VA: 0x27F9A0C
	|-Enumerable.Count<Vector3>
	|
	|-RVA: 0x27F9DD8 Offset: 0x27F5DD8 VA: 0x27F9DD8
	|-Enumerable.Count<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x27FA1A4 Offset: 0x27F61A4 VA: 0x27FA1A4
	|-Enumerable.Count<SocialAchievementData.LinkData>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int Count<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27FA570 Offset: 0x27F6570 VA: 0x27FA570
	|-Enumerable.Count<KeyValuePair<byte, long>>
	|
	|-RVA: 0x27FA8D8 Offset: 0x27F68D8 VA: 0x27FA8D8
	|-Enumerable.Count<bool>
	|
	|-RVA: 0x27FAC38 Offset: 0x27F6C38 VA: 0x27FAC38
	|-Enumerable.Count<byte>
	|
	|-RVA: 0x27FAF94 Offset: 0x27F6F94 VA: 0x27FAF94
	|-Enumerable.Count<short>
	|
	|-RVA: 0x27FB2F0 Offset: 0x27F72F0 VA: 0x27FB2F0
	|-Enumerable.Count<int>
	|
	|-RVA: 0x27FB64C Offset: 0x27F764C VA: 0x27FB64C
	|-Enumerable.Count<Int32Enum>
	|
	|-RVA: 0x27FB9A8 Offset: 0x27F79A8 VA: 0x27FB9A8
	|-Enumerable.Count<object>
	|
	|-RVA: 0x27FBD04 Offset: 0x27F7D04 VA: 0x27FBD04
	|-Enumerable.Count<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27F3A7C Offset: 0x27EFA7C VA: 0x27F3A7C
	|-Enumerable.Contains<byte>
	|
	|-RVA: 0x27F3B78 Offset: 0x27EFB78 VA: 0x27F3B78
	|-Enumerable.Contains<short>
	|
	|-RVA: 0x27F3C74 Offset: 0x27EFC74 VA: 0x27F3C74
	|-Enumerable.Contains<int>
	|
	|-RVA: 0x27F3D70 Offset: 0x27EFD70 VA: 0x27F3D70
	|-Enumerable.Contains<Int32Enum>
	|
	|-RVA: 0x27F3E6C Offset: 0x27EFE6C VA: 0x27F3E6C
	|-Enumerable.Contains<long>
	|
	|-RVA: 0x27F3F68 Offset: 0x27EFF68 VA: 0x27F3F68
	|-Enumerable.Contains<object>
	|
	|-RVA: 0x27F4064 Offset: 0x27F0064 VA: 0x27F4064
	|-Enumerable.Contains<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27F4218 Offset: 0x27F0218 VA: 0x27F4218
	|-Enumerable.Contains<byte>
	|
	|-RVA: 0x27F45D4 Offset: 0x27F05D4 VA: 0x27F45D4
	|-Enumerable.Contains<short>
	|
	|-RVA: 0x27F4990 Offset: 0x27F0990 VA: 0x27F4990
	|-Enumerable.Contains<int>
	|
	|-RVA: 0x27F4D4C Offset: 0x27F0D4C VA: 0x27F4D4C
	|-Enumerable.Contains<Int32Enum>
	|
	|-RVA: 0x27F5108 Offset: 0x27F1108 VA: 0x27F5108
	|-Enumerable.Contains<long>
	|
	|-RVA: 0x27F54C4 Offset: 0x27F14C4 VA: 0x27F54C4
	|-Enumerable.Contains<object>
	|
	|-RVA: 0x27F5880 Offset: 0x27F1880 VA: 0x27F5880
	|-Enumerable.Contains<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x311548C Offset: 0x311148C VA: 0x311548C
	public static int Sum(IEnumerable<int> source) { }

	[Extension]
	// RVA: 0x31157A8 Offset: 0x31117A8 VA: 0x31157A8
	public static long Sum(IEnumerable<long> source) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static int Sum<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B7D8C Offset: 0x26B3D8C VA: 0x26B7D8C
	|-Enumerable.Sum<KeyValuePair<int, object>>
	|
	|-RVA: 0x26B7DD4 Offset: 0x26B3DD4 VA: 0x26B7DD4
	|-Enumerable.Sum<byte>
	|
	|-RVA: 0x26B7E1C Offset: 0x26B3E1C VA: 0x26B7E1C
	|-Enumerable.Sum<int>
	|
	|-RVA: 0x26B7E64 Offset: 0x26B3E64 VA: 0x26B7E64
	|-Enumerable.Sum<Int32Enum>
	|
	|-RVA: 0x26B7EAC Offset: 0x26B3EAC VA: 0x26B7EAC
	|-Enumerable.Sum<object>
	|
	|-RVA: 0x26B7F3C Offset: 0x26B3F3C VA: 0x26B7F3C
	|-Enumerable.Sum<float>
	|
	|-RVA: 0x26B7F84 Offset: 0x26B3F84 VA: 0x26B7F84
	|-Enumerable.Sum<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static long Sum<TSource>(IEnumerable<TSource> source, Func<TSource, long> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26B7EF4 Offset: 0x26B3EF4 VA: 0x26B7EF4
	|-Enumerable.Sum<object>
	|
	|-RVA: 0x26B7FD0 Offset: 0x26B3FD0 VA: 0x26B7FD0
	|-Enumerable.Sum<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x3115AEC Offset: 0x3111AEC VA: 0x3115AEC
	public static long Min(IEnumerable<long> source) { }

	[Extension]
	// RVA: 0x3115E14 Offset: 0x3111E14 VA: 0x3115E14
	public static float Min(IEnumerable<float> source) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Min<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26AC924 Offset: 0x26A8924 VA: 0x26AC924
	|-Enumerable.Min<byte>
	|
	|-RVA: 0x26ACCB0 Offset: 0x26A8CB0 VA: 0x26ACCB0
	|-Enumerable.Min<short>
	|
	|-RVA: 0x26AD03C Offset: 0x26A903C VA: 0x26AD03C
	|-Enumerable.Min<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static long Min<TSource>(IEnumerable<TSource> source, Func<TSource, long> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26AD878 Offset: 0x26A9878 VA: 0x26AD878
	|-Enumerable.Min<object>
	|
	|-RVA: 0x26AD908 Offset: 0x26A9908 VA: 0x26AD908
	|-Enumerable.Min<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static float Min<TSource>(IEnumerable<TSource> source, Func<TSource, float> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26AD8C0 Offset: 0x26A98C0 VA: 0x26AD8C0
	|-Enumerable.Min<object>
	|
	|-RVA: 0x26AD954 Offset: 0x26A9954 VA: 0x26AD954
	|-Enumerable.Min<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TResult Min<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26AD9A0 Offset: 0x26A99A0 VA: 0x26AD9A0
	|-Enumerable.Min<object, short>
	|
	|-RVA: 0x26AD9EC Offset: 0x26A99EC VA: 0x26AD9EC
	|-Enumerable.Min<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x3116178 Offset: 0x3112178 VA: 0x3116178
	public static int Max(IEnumerable<int> source) { }

	[Extension]
	// RVA: 0x31164A0 Offset: 0x31124A0 VA: 0x31164A0
	public static float Max(IEnumerable<float> source) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Max<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26AB304 Offset: 0x26A7304 VA: 0x26AB304
	|-Enumerable.Max<byte>
	|
	|-RVA: 0x26AB690 Offset: 0x26A7690 VA: 0x26AB690
	|-Enumerable.Max<short>
	|
	|-RVA: 0x26ABA1C Offset: 0x26A7A1C VA: 0x26ABA1C
	|-Enumerable.Max<Int32Enum>
	|
	|-RVA: 0x26ABDA8 Offset: 0x26A7DA8 VA: 0x26ABDA8
	|-Enumerable.Max<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int Max<TSource>(IEnumerable<TSource> source, Func<TSource, int> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26AC5EC Offset: 0x26A85EC VA: 0x26AC5EC
	|-Enumerable.Max<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x26AC634 Offset: 0x26A8634 VA: 0x26AC634
	|-Enumerable.Max<object>
	|
	|-RVA: 0x26AC6C4 Offset: 0x26A86C4 VA: 0x26AC6C4
	|-Enumerable.Max<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static float Max<TSource>(IEnumerable<TSource> source, Func<TSource, float> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26AC67C Offset: 0x26A867C VA: 0x26AC67C
	|-Enumerable.Max<Vector3>
	|
	|-RVA: 0x26AC710 Offset: 0x26A8710 VA: 0x26AC710
	|-Enumerable.Max<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TResult Max<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26AC75C Offset: 0x26A875C VA: 0x26AC75C
	|-Enumerable.Max<KeyValuePair<byte, object>, byte>
	|
	|-RVA: 0x26AC7A8 Offset: 0x26A87A8 VA: 0x26AC7A8
	|-Enumerable.Max<KeyValuePair<Int32Enum, int>, Int32Enum>
	|
	|-RVA: 0x26AC7F4 Offset: 0x26A87F4 VA: 0x26AC7F4
	|-Enumerable.Max<object, byte>
	|
	|-RVA: 0x26AC840 Offset: 0x26A8840 VA: 0x26AC840
	|-Enumerable.Max<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}
