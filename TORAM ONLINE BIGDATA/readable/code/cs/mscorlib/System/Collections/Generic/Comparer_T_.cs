// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
[TypeDependency("System.Collections.Generic.ObjectComparer`1")]
[Serializable]
public abstract class Comparer<T> : IComparer, IComparer<T> // TypeDefIndex: 10972
{
	// Fields
	private static Comparer<T> defaultComparer; // 0x0

	// Properties
	public static Comparer<T> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static Comparer<T> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7E27C Offset: 0x2C7A27C VA: 0x2C7E27C
	|-Comparer<KeyValuePair<ArchetypeUid, object>>.get_Default
	|
	|-RVA: 0x2C7E8B0 Offset: 0x2C7A8B0 VA: 0x2C7E8B0
	|-Comparer<KeyValuePair<byte, BlackKnightCristaProperty>>.get_Default
	|
	|-RVA: 0x2C7EEE0 Offset: 0x2C7AEE0 VA: 0x2C7EEE0
	|-Comparer<KeyValuePair<byte, byte>>.get_Default
	|
	|-RVA: 0x2C7F510 Offset: 0x2C7B510 VA: 0x2C7F510
	|-Comparer<KeyValuePair<byte, object>>.get_Default
	|
	|-RVA: 0x2C7FB44 Offset: 0x2C7BB44 VA: 0x2C7FB44
	|-Comparer<KeyValuePair<double, int>>.get_Default
	|
	|-RVA: 0x2C80178 Offset: 0x2C7C178 VA: 0x2C80178
	|-Comparer<KeyValuePair<int, short>>.get_Default
	|
	|-RVA: 0x2C807A8 Offset: 0x2C7C7A8 VA: 0x2C807A8
	|-Comparer<KeyValuePair<int, int>>.get_Default
	|
	|-RVA: 0x2C80DD8 Offset: 0x2C7CDD8 VA: 0x2C80DD8
	|-Comparer<KeyValuePair<int, object>>.get_Default
	|
	|-RVA: 0x2C8140C Offset: 0x2C7D40C VA: 0x2C8140C
	|-Comparer<KeyValuePair<Int32Enum, byte>>.get_Default
	|
	|-RVA: 0x2C81A3C Offset: 0x2C7DA3C VA: 0x2C81A3C
	|-Comparer<KeyValuePair<Int32Enum, EnhanceProperties2>>.get_Default
	|
	|-RVA: 0x2C820AC Offset: 0x2C7E0AC VA: 0x2C820AC
	|-Comparer<KeyValuePair<Int32Enum, int>>.get_Default
	|
	|-RVA: 0x2C826DC Offset: 0x2C7E6DC VA: 0x2C826DC
	|-Comparer<KeyValuePair<Int32Enum, object>>.get_Default
	|
	|-RVA: 0x2C82D10 Offset: 0x2C7ED10 VA: 0x2C82D10
	|-Comparer<KeyValuePair<object, int>>.get_Default
	|
	|-RVA: 0x2C83344 Offset: 0x2C7F344 VA: 0x2C83344
	|-Comparer<KeyValuePair<object, float>>.get_Default
	|
	|-RVA: 0x2C83978 Offset: 0x2C7F978 VA: 0x2C83978
	|-Comparer<KeyValuePair<float, object>>.get_Default
	|
	|-RVA: 0x2C83FAC Offset: 0x2C7FFAC VA: 0x2C83FAC
	|-Comparer<Nullable<UIMobPropertyLabel.IconValue>>.get_Default
	|
	|-RVA: 0x2C8462C Offset: 0x2C8062C VA: 0x2C8462C
	|-Comparer<StructMultiKey<object, object>>.get_Default
	|
	|-RVA: 0x2C84C60 Offset: 0x2C80C60 VA: 0x2C84C60
	|-Comparer<ValueTuple<bool>>.get_Default
	|
	|-RVA: 0x2C85290 Offset: 0x2C81290 VA: 0x2C85290
	|-Comparer<ValueTuple<short, short>>.get_Default
	|
	|-RVA: 0x2C858C0 Offset: 0x2C818C0 VA: 0x2C858C0
	|-Comparer<ValueTuple<int, int>>.get_Default
	|
	|-RVA: 0x2C85EF0 Offset: 0x2C81EF0 VA: 0x2C85EF0
	|-Comparer<ValueTuple<int, object>>.get_Default
	|
	|-RVA: 0x2C86524 Offset: 0x2C82524 VA: 0x2C86524
	|-Comparer<ValueTuple<Int32Enum, float>>.get_Default
	|
	|-RVA: 0x2C86B54 Offset: 0x2C82B54 VA: 0x2C86B54
	|-Comparer<ValueTuple<Vector3, Vector3>>.get_Default
	|
	|-RVA: 0x2C871C4 Offset: 0x2C831C4 VA: 0x2C871C4
	|-Comparer<ArchetypeUid>.get_Default
	|
	|-RVA: 0x2C877F4 Offset: 0x2C837F4 VA: 0x2C877F4
	|-Comparer<bool>.get_Default
	|
	|-RVA: 0x2C87E34 Offset: 0x2C83E34 VA: 0x2C87E34
	|-Comparer<byte>.get_Default
	|
	|-RVA: 0x2C88464 Offset: 0x2C84464 VA: 0x2C88464
	|-Comparer<ByteEnum>.get_Default
	|
	|-RVA: 0x2C88A94 Offset: 0x2C84A94 VA: 0x2C88A94
	|-Comparer<char>.get_Default
	|
	|-RVA: 0x2C890C4 Offset: 0x2C850C4 VA: 0x2C890C4
	|-Comparer<Color>.get_Default
	|
	|-RVA: 0x2C89720 Offset: 0x2C85720 VA: 0x2C89720
	|-Comparer<Color32>.get_Default
	|
	|-RVA: 0x2C89D50 Offset: 0x2C85D50 VA: 0x2C89D50
	|-Comparer<DateTime>.get_Default
	|
	|-RVA: 0x2C8A380 Offset: 0x2C86380 VA: 0x2C8A380
	|-Comparer<DateTimeOffset>.get_Default
	|
	|-RVA: 0x2C8A9B4 Offset: 0x2C869B4 VA: 0x2C8A9B4
	|-Comparer<Decimal>.get_Default
	|
	|-RVA: 0x2C8AFE8 Offset: 0x2C86FE8 VA: 0x2C8AFE8
	|-Comparer<DefencePoint2>.get_Default
	|
	|-RVA: 0x2C8B618 Offset: 0x2C87618 VA: 0x2C8B618
	|-Comparer<double>.get_Default
	|
	|-RVA: 0x2C8BC54 Offset: 0x2C87C54 VA: 0x2C8BC54
	|-Comparer<EventSummary>.get_Default
	|
	|-RVA: 0x2C8C288 Offset: 0x2C88288 VA: 0x2C8C288
	|-Comparer<short>.get_Default
	|
	|-RVA: 0x2C8C8B8 Offset: 0x2C888B8 VA: 0x2C8C8B8
	|-Comparer<Int16Enum>.get_Default
	|
	|-RVA: 0x2C8CEE8 Offset: 0x2C88EE8 VA: 0x2C8CEE8
	|-Comparer<int>.get_Default
	|
	|-RVA: 0x2C8D518 Offset: 0x2C89518 VA: 0x2C8D518
	|-Comparer<Int32Enum>.get_Default
	|
	|-RVA: 0x2D9D3B8 Offset: 0x2D993B8 VA: 0x2D9D3B8
	|-Comparer<long>.get_Default
	|
	|-RVA: 0x2D9D9E8 Offset: 0x2D999E8 VA: 0x2D9D9E8
	|-Comparer<IntPtr>.get_Default
	|
	|-RVA: 0x2D9E018 Offset: 0x2D9A018 VA: 0x2D9E018
	|-Comparer<InterpretedFrameInfo>.get_Default
	|
	|-RVA: 0x2D9E64C Offset: 0x2D9A64C VA: 0x2D9E64C
	|-Comparer<JsonPosition>.get_Default
	|
	|-RVA: 0x2D9ECBC Offset: 0x2D9ACBC VA: 0x2D9ECBC
	|-Comparer<MaterialSearchData>.get_Default
	|
	|-RVA: 0x2D9F2F0 Offset: 0x2D9B2F0 VA: 0x2D9F2F0
	|-Comparer<MobActionTargetData>.get_Default
	|
	|-RVA: 0x2D9F960 Offset: 0x2D9B960 VA: 0x2D9F960
	|-Comparer<MobIconLabelData>.get_Default
	|
	|-RVA: 0x2D9FFD0 Offset: 0x2D9BFD0 VA: 0x2D9FFD0
	|-Comparer<object>.get_Default
	|
	|-RVA: 0x2DA0608 Offset: 0x2D9C608 VA: 0x2DA0608
	|-Comparer<PlayerLoopSystem>.get_Default
	|
	|-RVA: 0x2DA0C78 Offset: 0x2D9CC78 VA: 0x2DA0C78
	|-Comparer<PlayerLoopSystemInternal>.get_Default
	|
	|-RVA: 0x2DA12E8 Offset: 0x2D9D2E8 VA: 0x2DA12E8
	|-Comparer<RangePositionInfo>.get_Default
	|
	|-RVA: 0x2DA191C Offset: 0x2D9D91C VA: 0x2DA191C
	|-Comparer<RaycastHit>.get_Default
	|
	|-RVA: 0x2DA1F8C Offset: 0x2D9DF8C VA: 0x2DA1F8C
	|-Comparer<ReinforceCristaData>.get_Default
	|
	|-RVA: 0x2DA25C8 Offset: 0x2D9E5C8 VA: 0x2DA25C8
	|-Comparer<sbyte>.get_Default
	|
	|-RVA: 0x2DA2BF8 Offset: 0x2D9EBF8 VA: 0x2DA2BF8
	|-Comparer<float>.get_Default
	|
	|-RVA: 0x2DA3234 Offset: 0x2D9F234 VA: 0x2DA3234
	|-Comparer<SkillIdData>.get_Default
	|
	|-RVA: 0x2DA3864 Offset: 0x2D9F864 VA: 0x2DA3864
	|-Comparer<TimeSpan>.get_Default
	|
	|-RVA: 0x2DA3E94 Offset: 0x2D9FE94 VA: 0x2DA3E94
	|-Comparer<ushort>.get_Default
	|
	|-RVA: 0x2DA44C4 Offset: 0x2DA04C4 VA: 0x2DA44C4
	|-Comparer<uint>.get_Default
	|
	|-RVA: 0x2DA4AF4 Offset: 0x2DA0AF4 VA: 0x2DA4AF4
	|-Comparer<ulong>.get_Default
	|
	|-RVA: 0x2DA5124 Offset: 0x2DA1124 VA: 0x2DA5124
	|-Comparer<Vector2>.get_Default
	|
	|-RVA: 0x2DA5764 Offset: 0x2DA1764 VA: 0x2DA5764
	|-Comparer<Vector3>.get_Default
	|
	|-RVA: 0x2DA5DBC Offset: 0x2DA1DBC VA: 0x2DA5DBC
	|-Comparer<X509ChainStatus>.get_Default
	|
	|-RVA: 0x2DA63F0 Offset: 0x2DA23F0 VA: 0x2DA63F0
	|-Comparer<__Il2CppFullySharedGenericType>.get_Default
	|
	|-RVA: 0x2DA6AE8 Offset: 0x2DA2AE8 VA: 0x2DA6AE8
	|-Comparer<BeforeRenderHelper.OrderBlock>.get_Default
	|
	|-RVA: 0x2DA711C Offset: 0x2DA311C VA: 0x2DA711C
	|-Comparer<BoneClip.MotionKeyFrame>.get_Default
	|
	|-RVA: 0x2DA778C Offset: 0x2DA378C VA: 0x2DA778C
	|-Comparer<HouseRecipeManager.RecipeData>.get_Default
	|
	|-RVA: 0x2DA7DFC Offset: 0x2DA3DFC VA: 0x2DA7DFC
	|-Comparer<KadarElexioBuf.SkillIdData>.get_Default
	|
	|-RVA: 0x2DA842C Offset: 0x2DA442C VA: 0x2DA842C
	|-Comparer<MissionTextManagerData.CheckIKeywordtemData>.get_Default
	|
	|-RVA: 0x2DA8A68 Offset: 0x2DA4A68 VA: 0x2DA8A68
	|-Comparer<MissionTextManagerData.PickUpFieldData>.get_Default
	|
	|-RVA: 0x2DA90A4 Offset: 0x2DA50A4 VA: 0x2DA90A4
	|-Comparer<MobaRoomData.MobaAbilityMasterData>.get_Default
	|
	|-RVA: 0x2DA96D8 Offset: 0x2DA56D8 VA: 0x2DA96D8
	|-Comparer<NewWaveRoomData.Spotlight>.get_Default
	|
	|-RVA: 0x2DA9D28 Offset: 0x2DA5D28 VA: 0x2DA9D28
	|-Comparer<NguiDynamicFontController.ApplyTextureInfo>.get_Default
	|
	|-RVA: 0x2DAA35C Offset: 0x2DA635C VA: 0x2DAA35C
	|-Comparer<RegexCharClass.SingleRange>.get_Default
	|
	|-RVA: 0x2DAA98C Offset: 0x2DA698C VA: 0x2DAA98C
	|-Comparer<SocialAchievementData.LinkData>.get_Default
	|
	|-RVA: 0x2DAAFC0 Offset: 0x2DA6FC0 VA: 0x2DAAFC0
	|-Comparer<TrophyManager.TrophyData>.get_Default
	|
	|-RVA: 0x2DAB5F0 Offset: 0x2DA75F0 VA: 0x2DAB5F0
	|-Comparer<UIEventMenuButton.MessageButtonData>.get_Default
	|
	|-RVA: 0x2DABC58 Offset: 0x2DA7C58 VA: 0x2DABC58
	|-Comparer<UIFieldMapPanel.PopData>.get_Default
	|
	|-RVA: 0x2DAC2A8 Offset: 0x2DA82A8 VA: 0x2DAC2A8
	|-Comparer<UIHouseAddressManager.Town>.get_Default
	|
	|-RVA: 0x2DAC8D8 Offset: 0x2DA88D8 VA: 0x2DAC8D8
	|-Comparer<UIInfoWindow.LabelPosition>.get_Default
	|
	|-RVA: 0x2DACF28 Offset: 0x2DA8F28 VA: 0x2DACF28
	|-Comparer<UIMainManager.DropItemData>.get_Default
	|
	|-RVA: 0x2DAD558 Offset: 0x2DA9558 VA: 0x2DAD558
	|-Comparer<UIScenarioOrderPanel.MissionData>.get_Default
	|
	|-RVA: 0x2DADB8C Offset: 0x2DA9B8C VA: 0x2DADB8C
	|-Comparer<UnitySynchronizationContext.WorkRequest>.get_Default
	|
	|-RVA: 0x2DAE1FC Offset: 0x2DAA1FC VA: 0x2DAE1FC
	|-Comparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Default
	|
	|-RVA: 0x2DAE830 Offset: 0x2DAA830 VA: 0x2DAE830
	|-Comparer<BounceParabolaAttackPattern.TargetData.BoundLineData>.get_Default
	|
	|-RVA: 0x2DAEE80 Offset: 0x2DAAE80 VA: 0x2DAEE80
	|-Comparer<InstructionList.DebugView.InstructionView>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static Comparer<T> CreateComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7E34C Offset: 0x2C7A34C VA: 0x2C7E34C
	|-Comparer<KeyValuePair<ArchetypeUid, object>>.CreateComparer
	|
	|-RVA: 0x2C7E980 Offset: 0x2C7A980 VA: 0x2C7E980
	|-Comparer<KeyValuePair<byte, BlackKnightCristaProperty>>.CreateComparer
	|
	|-RVA: 0x2C7EFB0 Offset: 0x2C7AFB0 VA: 0x2C7EFB0
	|-Comparer<KeyValuePair<byte, byte>>.CreateComparer
	|
	|-RVA: 0x2C7F5E0 Offset: 0x2C7B5E0 VA: 0x2C7F5E0
	|-Comparer<KeyValuePair<byte, object>>.CreateComparer
	|
	|-RVA: 0x2C7FC14 Offset: 0x2C7BC14 VA: 0x2C7FC14
	|-Comparer<KeyValuePair<double, int>>.CreateComparer
	|
	|-RVA: 0x2C80248 Offset: 0x2C7C248 VA: 0x2C80248
	|-Comparer<KeyValuePair<int, short>>.CreateComparer
	|
	|-RVA: 0x2C80878 Offset: 0x2C7C878 VA: 0x2C80878
	|-Comparer<KeyValuePair<int, int>>.CreateComparer
	|
	|-RVA: 0x2C80EA8 Offset: 0x2C7CEA8 VA: 0x2C80EA8
	|-Comparer<KeyValuePair<int, object>>.CreateComparer
	|
	|-RVA: 0x2C814DC Offset: 0x2C7D4DC VA: 0x2C814DC
	|-Comparer<KeyValuePair<Int32Enum, byte>>.CreateComparer
	|
	|-RVA: 0x2C81B0C Offset: 0x2C7DB0C VA: 0x2C81B0C
	|-Comparer<KeyValuePair<Int32Enum, EnhanceProperties2>>.CreateComparer
	|
	|-RVA: 0x2C8217C Offset: 0x2C7E17C VA: 0x2C8217C
	|-Comparer<KeyValuePair<Int32Enum, int>>.CreateComparer
	|
	|-RVA: 0x2C827AC Offset: 0x2C7E7AC VA: 0x2C827AC
	|-Comparer<KeyValuePair<Int32Enum, object>>.CreateComparer
	|
	|-RVA: 0x2C82DE0 Offset: 0x2C7EDE0 VA: 0x2C82DE0
	|-Comparer<KeyValuePair<object, int>>.CreateComparer
	|
	|-RVA: 0x2C83414 Offset: 0x2C7F414 VA: 0x2C83414
	|-Comparer<KeyValuePair<object, float>>.CreateComparer
	|
	|-RVA: 0x2C83A48 Offset: 0x2C7FA48 VA: 0x2C83A48
	|-Comparer<KeyValuePair<float, object>>.CreateComparer
	|
	|-RVA: 0x2C8407C Offset: 0x2C8007C VA: 0x2C8407C
	|-Comparer<Nullable<UIMobPropertyLabel.IconValue>>.CreateComparer
	|
	|-RVA: 0x2C846FC Offset: 0x2C806FC VA: 0x2C846FC
	|-Comparer<StructMultiKey<object, object>>.CreateComparer
	|
	|-RVA: 0x2C84D30 Offset: 0x2C80D30 VA: 0x2C84D30
	|-Comparer<ValueTuple<bool>>.CreateComparer
	|
	|-RVA: 0x2C85360 Offset: 0x2C81360 VA: 0x2C85360
	|-Comparer<ValueTuple<short, short>>.CreateComparer
	|
	|-RVA: 0x2C85990 Offset: 0x2C81990 VA: 0x2C85990
	|-Comparer<ValueTuple<int, int>>.CreateComparer
	|
	|-RVA: 0x2C85FC0 Offset: 0x2C81FC0 VA: 0x2C85FC0
	|-Comparer<ValueTuple<int, object>>.CreateComparer
	|
	|-RVA: 0x2C865F4 Offset: 0x2C825F4 VA: 0x2C865F4
	|-Comparer<ValueTuple<Int32Enum, float>>.CreateComparer
	|
	|-RVA: 0x2C86C24 Offset: 0x2C82C24 VA: 0x2C86C24
	|-Comparer<ValueTuple<Vector3, Vector3>>.CreateComparer
	|
	|-RVA: 0x2C87294 Offset: 0x2C83294 VA: 0x2C87294
	|-Comparer<ArchetypeUid>.CreateComparer
	|
	|-RVA: 0x2C878C4 Offset: 0x2C838C4 VA: 0x2C878C4
	|-Comparer<bool>.CreateComparer
	|
	|-RVA: 0x2C87F04 Offset: 0x2C83F04 VA: 0x2C87F04
	|-Comparer<byte>.CreateComparer
	|
	|-RVA: 0x2C88534 Offset: 0x2C84534 VA: 0x2C88534
	|-Comparer<ByteEnum>.CreateComparer
	|
	|-RVA: 0x2C88B64 Offset: 0x2C84B64 VA: 0x2C88B64
	|-Comparer<char>.CreateComparer
	|
	|-RVA: 0x2C89194 Offset: 0x2C85194 VA: 0x2C89194
	|-Comparer<Color>.CreateComparer
	|
	|-RVA: 0x2C897F0 Offset: 0x2C857F0 VA: 0x2C897F0
	|-Comparer<Color32>.CreateComparer
	|
	|-RVA: 0x2C89E20 Offset: 0x2C85E20 VA: 0x2C89E20
	|-Comparer<DateTime>.CreateComparer
	|
	|-RVA: 0x2C8A450 Offset: 0x2C86450 VA: 0x2C8A450
	|-Comparer<DateTimeOffset>.CreateComparer
	|
	|-RVA: 0x2C8AA84 Offset: 0x2C86A84 VA: 0x2C8AA84
	|-Comparer<Decimal>.CreateComparer
	|
	|-RVA: 0x2C8B0B8 Offset: 0x2C870B8 VA: 0x2C8B0B8
	|-Comparer<DefencePoint2>.CreateComparer
	|
	|-RVA: 0x2C8B6E8 Offset: 0x2C876E8 VA: 0x2C8B6E8
	|-Comparer<double>.CreateComparer
	|
	|-RVA: 0x2C8BD24 Offset: 0x2C87D24 VA: 0x2C8BD24
	|-Comparer<EventSummary>.CreateComparer
	|
	|-RVA: 0x2C8C358 Offset: 0x2C88358 VA: 0x2C8C358
	|-Comparer<short>.CreateComparer
	|
	|-RVA: 0x2C8C988 Offset: 0x2C88988 VA: 0x2C8C988
	|-Comparer<Int16Enum>.CreateComparer
	|
	|-RVA: 0x2C8CFB8 Offset: 0x2C88FB8 VA: 0x2C8CFB8
	|-Comparer<int>.CreateComparer
	|
	|-RVA: 0x2C8D5E8 Offset: 0x2C895E8 VA: 0x2C8D5E8
	|-Comparer<Int32Enum>.CreateComparer
	|
	|-RVA: 0x2D9D488 Offset: 0x2D99488 VA: 0x2D9D488
	|-Comparer<long>.CreateComparer
	|
	|-RVA: 0x2D9DAB8 Offset: 0x2D99AB8 VA: 0x2D9DAB8
	|-Comparer<IntPtr>.CreateComparer
	|
	|-RVA: 0x2D9E0E8 Offset: 0x2D9A0E8 VA: 0x2D9E0E8
	|-Comparer<InterpretedFrameInfo>.CreateComparer
	|
	|-RVA: 0x2D9E71C Offset: 0x2D9A71C VA: 0x2D9E71C
	|-Comparer<JsonPosition>.CreateComparer
	|
	|-RVA: 0x2D9ED8C Offset: 0x2D9AD8C VA: 0x2D9ED8C
	|-Comparer<MaterialSearchData>.CreateComparer
	|
	|-RVA: 0x2D9F3C0 Offset: 0x2D9B3C0 VA: 0x2D9F3C0
	|-Comparer<MobActionTargetData>.CreateComparer
	|
	|-RVA: 0x2D9FA30 Offset: 0x2D9BA30 VA: 0x2D9FA30
	|-Comparer<MobIconLabelData>.CreateComparer
	|
	|-RVA: 0x2DA00A0 Offset: 0x2D9C0A0 VA: 0x2DA00A0
	|-Comparer<object>.CreateComparer
	|
	|-RVA: 0x2DA06D8 Offset: 0x2D9C6D8 VA: 0x2DA06D8
	|-Comparer<PlayerLoopSystem>.CreateComparer
	|
	|-RVA: 0x2DA0D48 Offset: 0x2D9CD48 VA: 0x2DA0D48
	|-Comparer<PlayerLoopSystemInternal>.CreateComparer
	|
	|-RVA: 0x2DA13B8 Offset: 0x2D9D3B8 VA: 0x2DA13B8
	|-Comparer<RangePositionInfo>.CreateComparer
	|
	|-RVA: 0x2DA19EC Offset: 0x2D9D9EC VA: 0x2DA19EC
	|-Comparer<RaycastHit>.CreateComparer
	|
	|-RVA: 0x2DA205C Offset: 0x2D9E05C VA: 0x2DA205C
	|-Comparer<ReinforceCristaData>.CreateComparer
	|
	|-RVA: 0x2DA2698 Offset: 0x2D9E698 VA: 0x2DA2698
	|-Comparer<sbyte>.CreateComparer
	|
	|-RVA: 0x2DA2CC8 Offset: 0x2D9ECC8 VA: 0x2DA2CC8
	|-Comparer<float>.CreateComparer
	|
	|-RVA: 0x2DA3304 Offset: 0x2D9F304 VA: 0x2DA3304
	|-Comparer<SkillIdData>.CreateComparer
	|
	|-RVA: 0x2DA3934 Offset: 0x2D9F934 VA: 0x2DA3934
	|-Comparer<TimeSpan>.CreateComparer
	|
	|-RVA: 0x2DA3F64 Offset: 0x2D9FF64 VA: 0x2DA3F64
	|-Comparer<ushort>.CreateComparer
	|
	|-RVA: 0x2DA4594 Offset: 0x2DA0594 VA: 0x2DA4594
	|-Comparer<uint>.CreateComparer
	|
	|-RVA: 0x2DA4BC4 Offset: 0x2DA0BC4 VA: 0x2DA4BC4
	|-Comparer<ulong>.CreateComparer
	|
	|-RVA: 0x2DA51F4 Offset: 0x2DA11F4 VA: 0x2DA51F4
	|-Comparer<Vector2>.CreateComparer
	|
	|-RVA: 0x2DA5834 Offset: 0x2DA1834 VA: 0x2DA5834
	|-Comparer<Vector3>.CreateComparer
	|
	|-RVA: 0x2DA5E8C Offset: 0x2DA1E8C VA: 0x2DA5E8C
	|-Comparer<X509ChainStatus>.CreateComparer
	|
	|-RVA: 0x2DA64F8 Offset: 0x2DA24F8 VA: 0x2DA64F8
	|-Comparer<__Il2CppFullySharedGenericType>.CreateComparer
	|
	|-RVA: 0x2DA6BB8 Offset: 0x2DA2BB8 VA: 0x2DA6BB8
	|-Comparer<BeforeRenderHelper.OrderBlock>.CreateComparer
	|
	|-RVA: 0x2DA71EC Offset: 0x2DA31EC VA: 0x2DA71EC
	|-Comparer<BoneClip.MotionKeyFrame>.CreateComparer
	|
	|-RVA: 0x2DA785C Offset: 0x2DA385C VA: 0x2DA785C
	|-Comparer<HouseRecipeManager.RecipeData>.CreateComparer
	|
	|-RVA: 0x2DA7ECC Offset: 0x2DA3ECC VA: 0x2DA7ECC
	|-Comparer<KadarElexioBuf.SkillIdData>.CreateComparer
	|
	|-RVA: 0x2DA84FC Offset: 0x2DA44FC VA: 0x2DA84FC
	|-Comparer<MissionTextManagerData.CheckIKeywordtemData>.CreateComparer
	|
	|-RVA: 0x2DA8B38 Offset: 0x2DA4B38 VA: 0x2DA8B38
	|-Comparer<MissionTextManagerData.PickUpFieldData>.CreateComparer
	|
	|-RVA: 0x2DA9174 Offset: 0x2DA5174 VA: 0x2DA9174
	|-Comparer<MobaRoomData.MobaAbilityMasterData>.CreateComparer
	|
	|-RVA: 0x2DA97A8 Offset: 0x2DA57A8 VA: 0x2DA97A8
	|-Comparer<NewWaveRoomData.Spotlight>.CreateComparer
	|
	|-RVA: 0x2DA9DF8 Offset: 0x2DA5DF8 VA: 0x2DA9DF8
	|-Comparer<NguiDynamicFontController.ApplyTextureInfo>.CreateComparer
	|
	|-RVA: 0x2DAA42C Offset: 0x2DA642C VA: 0x2DAA42C
	|-Comparer<RegexCharClass.SingleRange>.CreateComparer
	|
	|-RVA: 0x2DAAA5C Offset: 0x2DA6A5C VA: 0x2DAAA5C
	|-Comparer<SocialAchievementData.LinkData>.CreateComparer
	|
	|-RVA: 0x2DAB090 Offset: 0x2DA7090 VA: 0x2DAB090
	|-Comparer<TrophyManager.TrophyData>.CreateComparer
	|
	|-RVA: 0x2DAB6C0 Offset: 0x2DA76C0 VA: 0x2DAB6C0
	|-Comparer<UIEventMenuButton.MessageButtonData>.CreateComparer
	|
	|-RVA: 0x2DABD28 Offset: 0x2DA7D28 VA: 0x2DABD28
	|-Comparer<UIFieldMapPanel.PopData>.CreateComparer
	|
	|-RVA: 0x2DAC378 Offset: 0x2DA8378 VA: 0x2DAC378
	|-Comparer<UIHouseAddressManager.Town>.CreateComparer
	|
	|-RVA: 0x2DAC9A8 Offset: 0x2DA89A8 VA: 0x2DAC9A8
	|-Comparer<UIInfoWindow.LabelPosition>.CreateComparer
	|
	|-RVA: 0x2DACFF8 Offset: 0x2DA8FF8 VA: 0x2DACFF8
	|-Comparer<UIMainManager.DropItemData>.CreateComparer
	|
	|-RVA: 0x2DAD628 Offset: 0x2DA9628 VA: 0x2DAD628
	|-Comparer<UIScenarioOrderPanel.MissionData>.CreateComparer
	|
	|-RVA: 0x2DADC5C Offset: 0x2DA9C5C VA: 0x2DADC5C
	|-Comparer<UnitySynchronizationContext.WorkRequest>.CreateComparer
	|
	|-RVA: 0x2DAE2CC Offset: 0x2DAA2CC VA: 0x2DAE2CC
	|-Comparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.CreateComparer
	|
	|-RVA: 0x2DAE900 Offset: 0x2DAA900 VA: 0x2DAE900
	|-Comparer<BounceParabolaAttackPattern.TargetData.BoundLineData>.CreateComparer
	|
	|-RVA: 0x2DAEF50 Offset: 0x2DAAF50 VA: 0x2DAEF50
	|-Comparer<InstructionList.DebugView.InstructionView>.CreateComparer
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int Compare(T x, T y);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Comparer<__Il2CppFullySharedGenericType>.Compare
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private int System.Collections.IComparer.Compare(object x, object y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7E750 Offset: 0x2C7A750 VA: 0x2C7E750
	|-Comparer<KeyValuePair<ArchetypeUid, object>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C7ED84 Offset: 0x2C7AD84 VA: 0x2C7ED84
	|-Comparer<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C7F3B4 Offset: 0x2C7B3B4 VA: 0x2C7F3B4
	|-Comparer<KeyValuePair<byte, byte>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C7F9E4 Offset: 0x2C7B9E4 VA: 0x2C7F9E4
	|-Comparer<KeyValuePair<byte, object>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C80018 Offset: 0x2C7C018 VA: 0x2C80018
	|-Comparer<KeyValuePair<double, int>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C8064C Offset: 0x2C7C64C VA: 0x2C8064C
	|-Comparer<KeyValuePair<int, short>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C80C7C Offset: 0x2C7CC7C VA: 0x2C80C7C
	|-Comparer<KeyValuePair<int, int>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C812AC Offset: 0x2C7D2AC VA: 0x2C812AC
	|-Comparer<KeyValuePair<int, object>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C818E0 Offset: 0x2C7D8E0 VA: 0x2C818E0
	|-Comparer<KeyValuePair<Int32Enum, byte>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C81F10 Offset: 0x2C7DF10 VA: 0x2C81F10
	|-Comparer<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C82580 Offset: 0x2C7E580 VA: 0x2C82580
	|-Comparer<KeyValuePair<Int32Enum, int>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C82BB0 Offset: 0x2C7EBB0 VA: 0x2C82BB0
	|-Comparer<KeyValuePair<Int32Enum, object>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C831E4 Offset: 0x2C7F1E4 VA: 0x2C831E4
	|-Comparer<KeyValuePair<object, int>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C83818 Offset: 0x2C7F818 VA: 0x2C83818
	|-Comparer<KeyValuePair<object, float>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C83E4C Offset: 0x2C7FE4C VA: 0x2C83E4C
	|-Comparer<KeyValuePair<float, object>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C84480 Offset: 0x2C80480 VA: 0x2C84480
	|-Comparer<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C84B00 Offset: 0x2C80B00 VA: 0x2C84B00
	|-Comparer<StructMultiKey<object, object>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C85134 Offset: 0x2C81134 VA: 0x2C85134
	|-Comparer<ValueTuple<bool>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C85764 Offset: 0x2C81764 VA: 0x2C85764
	|-Comparer<ValueTuple<short, short>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C85D94 Offset: 0x2C81D94 VA: 0x2C85D94
	|-Comparer<ValueTuple<int, int>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C863C4 Offset: 0x2C823C4 VA: 0x2C863C4
	|-Comparer<ValueTuple<int, object>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C869F8 Offset: 0x2C829F8 VA: 0x2C869F8
	|-Comparer<ValueTuple<Int32Enum, float>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C87028 Offset: 0x2C83028 VA: 0x2C87028
	|-Comparer<ValueTuple<Vector3, Vector3>>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C87698 Offset: 0x2C83698 VA: 0x2C87698
	|-Comparer<ArchetypeUid>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C87CC8 Offset: 0x2C83CC8 VA: 0x2C87CC8
	|-Comparer<bool>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C88308 Offset: 0x2C84308 VA: 0x2C88308
	|-Comparer<byte>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C88938 Offset: 0x2C84938 VA: 0x2C88938
	|-Comparer<ByteEnum>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C88F68 Offset: 0x2C84F68 VA: 0x2C88F68
	|-Comparer<char>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C89598 Offset: 0x2C85598 VA: 0x2C89598
	|-Comparer<Color>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C89BF4 Offset: 0x2C85BF4 VA: 0x2C89BF4
	|-Comparer<Color32>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C8A224 Offset: 0x2C86224 VA: 0x2C8A224
	|-Comparer<DateTime>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C8A854 Offset: 0x2C86854 VA: 0x2C8A854
	|-Comparer<DateTimeOffset>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C8AE88 Offset: 0x2C86E88 VA: 0x2C8AE88
	|-Comparer<Decimal>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C8B4BC Offset: 0x2C874BC VA: 0x2C8B4BC
	|-Comparer<DefencePoint2>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C8BAEC Offset: 0x2C87AEC VA: 0x2C8BAEC
	|-Comparer<double>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C8C128 Offset: 0x2C88128 VA: 0x2C8C128
	|-Comparer<EventSummary>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C8C75C Offset: 0x2C8875C VA: 0x2C8C75C
	|-Comparer<short>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C8CD8C Offset: 0x2C88D8C VA: 0x2C8CD8C
	|-Comparer<Int16Enum>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C8D3BC Offset: 0x2C893BC VA: 0x2C8D3BC
	|-Comparer<int>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2C8D9EC Offset: 0x2C899EC VA: 0x2C8D9EC
	|-Comparer<Int32Enum>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2D9D88C Offset: 0x2D9988C VA: 0x2D9D88C
	|-Comparer<long>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2D9DEBC Offset: 0x2D99EBC VA: 0x2D9DEBC
	|-Comparer<IntPtr>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2D9E4EC Offset: 0x2D9A4EC VA: 0x2D9E4EC
	|-Comparer<InterpretedFrameInfo>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2D9EB20 Offset: 0x2D9AB20 VA: 0x2D9EB20
	|-Comparer<JsonPosition>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2D9F190 Offset: 0x2D9B190 VA: 0x2D9F190
	|-Comparer<MaterialSearchData>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2D9F7C4 Offset: 0x2D9B7C4 VA: 0x2D9F7C4
	|-Comparer<MobActionTargetData>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2D9FE34 Offset: 0x2D9BE34 VA: 0x2D9FE34
	|-Comparer<MobIconLabelData>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA04A4 Offset: 0x2D9C4A4 VA: 0x2DA04A4
	|-Comparer<object>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA0ADC Offset: 0x2D9CADC VA: 0x2DA0ADC
	|-Comparer<PlayerLoopSystem>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA114C Offset: 0x2D9D14C VA: 0x2DA114C
	|-Comparer<PlayerLoopSystemInternal>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA17BC Offset: 0x2D9D7BC VA: 0x2DA17BC
	|-Comparer<RangePositionInfo>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA1DF0 Offset: 0x2D9DDF0 VA: 0x2DA1DF0
	|-Comparer<RaycastHit>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA2460 Offset: 0x2D9E460 VA: 0x2DA2460
	|-Comparer<ReinforceCristaData>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA2A9C Offset: 0x2D9EA9C VA: 0x2DA2A9C
	|-Comparer<sbyte>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA30CC Offset: 0x2D9F0CC VA: 0x2DA30CC
	|-Comparer<float>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA3708 Offset: 0x2D9F708 VA: 0x2DA3708
	|-Comparer<SkillIdData>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA3D38 Offset: 0x2D9FD38 VA: 0x2DA3D38
	|-Comparer<TimeSpan>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA4368 Offset: 0x2DA0368 VA: 0x2DA4368
	|-Comparer<ushort>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA4998 Offset: 0x2DA0998 VA: 0x2DA4998
	|-Comparer<uint>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA4FC8 Offset: 0x2DA0FC8 VA: 0x2DA4FC8
	|-Comparer<ulong>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA55F8 Offset: 0x2DA15F8 VA: 0x2DA55F8
	|-Comparer<Vector2>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA5C38 Offset: 0x2DA1C38 VA: 0x2DA5C38
	|-Comparer<Vector3>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA6290 Offset: 0x2DA2290 VA: 0x2DA6290
	|-Comparer<X509ChainStatus>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA6928 Offset: 0x2DA2928 VA: 0x2DA6928
	|-Comparer<__Il2CppFullySharedGenericType>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA6FBC Offset: 0x2DA2FBC VA: 0x2DA6FBC
	|-Comparer<BeforeRenderHelper.OrderBlock>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA75F0 Offset: 0x2DA35F0 VA: 0x2DA75F0
	|-Comparer<BoneClip.MotionKeyFrame>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA7C60 Offset: 0x2DA3C60 VA: 0x2DA7C60
	|-Comparer<HouseRecipeManager.RecipeData>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA82D0 Offset: 0x2DA42D0 VA: 0x2DA82D0
	|-Comparer<KadarElexioBuf.SkillIdData>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA8900 Offset: 0x2DA4900 VA: 0x2DA8900
	|-Comparer<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA8F3C Offset: 0x2DA4F3C VA: 0x2DA8F3C
	|-Comparer<MissionTextManagerData.PickUpFieldData>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA9578 Offset: 0x2DA5578 VA: 0x2DA9578
	|-Comparer<MobaRoomData.MobaAbilityMasterData>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DA9BAC Offset: 0x2DA5BAC VA: 0x2DA9BAC
	|-Comparer<NewWaveRoomData.Spotlight>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DAA1FC Offset: 0x2DA61FC VA: 0x2DAA1FC
	|-Comparer<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DAA830 Offset: 0x2DA6830 VA: 0x2DAA830
	|-Comparer<RegexCharClass.SingleRange>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DAAE60 Offset: 0x2DA6E60 VA: 0x2DAAE60
	|-Comparer<SocialAchievementData.LinkData>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DAB494 Offset: 0x2DA7494 VA: 0x2DAB494
	|-Comparer<TrophyManager.TrophyData>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DABAC4 Offset: 0x2DA7AC4 VA: 0x2DABAC4
	|-Comparer<UIEventMenuButton.MessageButtonData>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DAC12C Offset: 0x2DA812C VA: 0x2DAC12C
	|-Comparer<UIFieldMapPanel.PopData>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DAC77C Offset: 0x2DA877C VA: 0x2DAC77C
	|-Comparer<UIHouseAddressManager.Town>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DACDAC Offset: 0x2DA8DAC VA: 0x2DACDAC
	|-Comparer<UIInfoWindow.LabelPosition>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DAD3FC Offset: 0x2DA93FC VA: 0x2DAD3FC
	|-Comparer<UIMainManager.DropItemData>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DADA2C Offset: 0x2DA9A2C VA: 0x2DADA2C
	|-Comparer<UIScenarioOrderPanel.MissionData>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DAE060 Offset: 0x2DAA060 VA: 0x2DAE060
	|-Comparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DAE6D0 Offset: 0x2DAA6D0 VA: 0x2DAE6D0
	|-Comparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DAED04 Offset: 0x2DAAD04 VA: 0x2DAED04
	|-Comparer<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IComparer.Compare
	|
	|-RVA: 0x2DAF354 Offset: 0x2DAB354 VA: 0x2DAF354
	|-Comparer<InstructionList.DebugView.InstructionView>.System.Collections.IComparer.Compare
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7E8A8 Offset: 0x2C7A8A8 VA: 0x2C7E8A8
	|-Comparer<KeyValuePair<ArchetypeUid, object>>..ctor
	|
	|-RVA: 0x2C7EED8 Offset: 0x2C7AED8 VA: 0x2C7EED8
	|-Comparer<KeyValuePair<byte, BlackKnightCristaProperty>>..ctor
	|
	|-RVA: 0x2C7F508 Offset: 0x2C7B508 VA: 0x2C7F508
	|-Comparer<KeyValuePair<byte, byte>>..ctor
	|
	|-RVA: 0x2C7FB3C Offset: 0x2C7BB3C VA: 0x2C7FB3C
	|-Comparer<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x2C80170 Offset: 0x2C7C170 VA: 0x2C80170
	|-Comparer<KeyValuePair<double, int>>..ctor
	|
	|-RVA: 0x2C807A0 Offset: 0x2C7C7A0 VA: 0x2C807A0
	|-Comparer<KeyValuePair<int, short>>..ctor
	|
	|-RVA: 0x2C80DD0 Offset: 0x2C7CDD0 VA: 0x2C80DD0
	|-Comparer<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x2C81404 Offset: 0x2C7D404 VA: 0x2C81404
	|-Comparer<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2C81A34 Offset: 0x2C7DA34 VA: 0x2C81A34
	|-Comparer<KeyValuePair<Int32Enum, byte>>..ctor
	|
	|-RVA: 0x2C820A4 Offset: 0x2C7E0A4 VA: 0x2C820A4
	|-Comparer<KeyValuePair<Int32Enum, EnhanceProperties2>>..ctor
	|
	|-RVA: 0x2C826D4 Offset: 0x2C7E6D4 VA: 0x2C826D4
	|-Comparer<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2C82D08 Offset: 0x2C7ED08 VA: 0x2C82D08
	|-Comparer<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x2C8333C Offset: 0x2C7F33C VA: 0x2C8333C
	|-Comparer<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x2C83970 Offset: 0x2C7F970 VA: 0x2C83970
	|-Comparer<KeyValuePair<object, float>>..ctor
	|
	|-RVA: 0x2C83FA4 Offset: 0x2C7FFA4 VA: 0x2C83FA4
	|-Comparer<KeyValuePair<float, object>>..ctor
	|
	|-RVA: 0x2C84624 Offset: 0x2C80624 VA: 0x2C84624
	|-Comparer<Nullable<UIMobPropertyLabel.IconValue>>..ctor
	|
	|-RVA: 0x2C84C58 Offset: 0x2C80C58 VA: 0x2C84C58
	|-Comparer<StructMultiKey<object, object>>..ctor
	|
	|-RVA: 0x2C85288 Offset: 0x2C81288 VA: 0x2C85288
	|-Comparer<ValueTuple<bool>>..ctor
	|
	|-RVA: 0x2C858B8 Offset: 0x2C818B8 VA: 0x2C858B8
	|-Comparer<ValueTuple<short, short>>..ctor
	|
	|-RVA: 0x2C85EE8 Offset: 0x2C81EE8 VA: 0x2C85EE8
	|-Comparer<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2C8651C Offset: 0x2C8251C VA: 0x2C8651C
	|-Comparer<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x2C86B4C Offset: 0x2C82B4C VA: 0x2C86B4C
	|-Comparer<ValueTuple<Int32Enum, float>>..ctor
	|
	|-RVA: 0x2C871BC Offset: 0x2C831BC VA: 0x2C871BC
	|-Comparer<ValueTuple<Vector3, Vector3>>..ctor
	|
	|-RVA: 0x2C877EC Offset: 0x2C837EC VA: 0x2C877EC
	|-Comparer<ArchetypeUid>..ctor
	|
	|-RVA: 0x2C87E2C Offset: 0x2C83E2C VA: 0x2C87E2C
	|-Comparer<bool>..ctor
	|
	|-RVA: 0x2C8845C Offset: 0x2C8445C VA: 0x2C8845C
	|-Comparer<byte>..ctor
	|
	|-RVA: 0x2C88A8C Offset: 0x2C84A8C VA: 0x2C88A8C
	|-Comparer<ByteEnum>..ctor
	|
	|-RVA: 0x2C890BC Offset: 0x2C850BC VA: 0x2C890BC
	|-Comparer<char>..ctor
	|
	|-RVA: 0x2C89718 Offset: 0x2C85718 VA: 0x2C89718
	|-Comparer<Color>..ctor
	|
	|-RVA: 0x2C89D48 Offset: 0x2C85D48 VA: 0x2C89D48
	|-Comparer<Color32>..ctor
	|
	|-RVA: 0x2C8A378 Offset: 0x2C86378 VA: 0x2C8A378
	|-Comparer<DateTime>..ctor
	|
	|-RVA: 0x2C8A9AC Offset: 0x2C869AC VA: 0x2C8A9AC
	|-Comparer<DateTimeOffset>..ctor
	|
	|-RVA: 0x2C8AFE0 Offset: 0x2C86FE0 VA: 0x2C8AFE0
	|-Comparer<Decimal>..ctor
	|
	|-RVA: 0x2C8B610 Offset: 0x2C87610 VA: 0x2C8B610
	|-Comparer<DefencePoint2>..ctor
	|
	|-RVA: 0x2C8BC4C Offset: 0x2C87C4C VA: 0x2C8BC4C
	|-Comparer<double>..ctor
	|
	|-RVA: 0x2C8C280 Offset: 0x2C88280 VA: 0x2C8C280
	|-Comparer<EventSummary>..ctor
	|
	|-RVA: 0x2C8C8B0 Offset: 0x2C888B0 VA: 0x2C8C8B0
	|-Comparer<short>..ctor
	|
	|-RVA: 0x2C8CEE0 Offset: 0x2C88EE0 VA: 0x2C8CEE0
	|-Comparer<Int16Enum>..ctor
	|
	|-RVA: 0x2C8D510 Offset: 0x2C89510 VA: 0x2C8D510
	|-Comparer<int>..ctor
	|
	|-RVA: 0x2C8DB40 Offset: 0x2C89B40 VA: 0x2C8DB40
	|-Comparer<Int32Enum>..ctor
	|
	|-RVA: 0x2D9D9E0 Offset: 0x2D999E0 VA: 0x2D9D9E0
	|-Comparer<long>..ctor
	|
	|-RVA: 0x2D9E010 Offset: 0x2D9A010 VA: 0x2D9E010
	|-Comparer<IntPtr>..ctor
	|
	|-RVA: 0x2D9E644 Offset: 0x2D9A644 VA: 0x2D9E644
	|-Comparer<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x2D9ECB4 Offset: 0x2D9ACB4 VA: 0x2D9ECB4
	|-Comparer<JsonPosition>..ctor
	|
	|-RVA: 0x2D9F2E8 Offset: 0x2D9B2E8 VA: 0x2D9F2E8
	|-Comparer<MaterialSearchData>..ctor
	|
	|-RVA: 0x2D9F958 Offset: 0x2D9B958 VA: 0x2D9F958
	|-Comparer<MobActionTargetData>..ctor
	|
	|-RVA: 0x2D9FFC8 Offset: 0x2D9BFC8 VA: 0x2D9FFC8
	|-Comparer<MobIconLabelData>..ctor
	|
	|-RVA: 0x2DA0600 Offset: 0x2D9C600 VA: 0x2DA0600
	|-Comparer<object>..ctor
	|
	|-RVA: 0x2DA0C70 Offset: 0x2D9CC70 VA: 0x2DA0C70
	|-Comparer<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x2DA12E0 Offset: 0x2D9D2E0 VA: 0x2DA12E0
	|-Comparer<PlayerLoopSystemInternal>..ctor
	|
	|-RVA: 0x2DA1914 Offset: 0x2D9D914 VA: 0x2DA1914
	|-Comparer<RangePositionInfo>..ctor
	|
	|-RVA: 0x2DA1F84 Offset: 0x2D9DF84 VA: 0x2DA1F84
	|-Comparer<RaycastHit>..ctor
	|
	|-RVA: 0x2DA25C0 Offset: 0x2D9E5C0 VA: 0x2DA25C0
	|-Comparer<ReinforceCristaData>..ctor
	|
	|-RVA: 0x2DA2BF0 Offset: 0x2D9EBF0 VA: 0x2DA2BF0
	|-Comparer<sbyte>..ctor
	|
	|-RVA: 0x2DA322C Offset: 0x2D9F22C VA: 0x2DA322C
	|-Comparer<float>..ctor
	|
	|-RVA: 0x2DA385C Offset: 0x2D9F85C VA: 0x2DA385C
	|-Comparer<SkillIdData>..ctor
	|
	|-RVA: 0x2DA3E8C Offset: 0x2D9FE8C VA: 0x2DA3E8C
	|-Comparer<TimeSpan>..ctor
	|
	|-RVA: 0x2DA44BC Offset: 0x2DA04BC VA: 0x2DA44BC
	|-Comparer<ushort>..ctor
	|
	|-RVA: 0x2DA4AEC Offset: 0x2DA0AEC VA: 0x2DA4AEC
	|-Comparer<uint>..ctor
	|
	|-RVA: 0x2DA511C Offset: 0x2DA111C VA: 0x2DA511C
	|-Comparer<ulong>..ctor
	|
	|-RVA: 0x2DA575C Offset: 0x2DA175C VA: 0x2DA575C
	|-Comparer<Vector2>..ctor
	|
	|-RVA: 0x2DA5DB4 Offset: 0x2DA1DB4 VA: 0x2DA5DB4
	|-Comparer<Vector3>..ctor
	|
	|-RVA: 0x2DA63E8 Offset: 0x2DA23E8 VA: 0x2DA63E8
	|-Comparer<X509ChainStatus>..ctor
	|
	|-RVA: 0x2DA6AE0 Offset: 0x2DA2AE0 VA: 0x2DA6AE0
	|-Comparer<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2DA7114 Offset: 0x2DA3114 VA: 0x2DA7114
	|-Comparer<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x2DA7784 Offset: 0x2DA3784 VA: 0x2DA7784
	|-Comparer<BoneClip.MotionKeyFrame>..ctor
	|
	|-RVA: 0x2DA7DF4 Offset: 0x2DA3DF4 VA: 0x2DA7DF4
	|-Comparer<HouseRecipeManager.RecipeData>..ctor
	|
	|-RVA: 0x2DA8424 Offset: 0x2DA4424 VA: 0x2DA8424
	|-Comparer<KadarElexioBuf.SkillIdData>..ctor
	|
	|-RVA: 0x2DA8A60 Offset: 0x2DA4A60 VA: 0x2DA8A60
	|-Comparer<MissionTextManagerData.CheckIKeywordtemData>..ctor
	|
	|-RVA: 0x2DA909C Offset: 0x2DA509C VA: 0x2DA909C
	|-Comparer<MissionTextManagerData.PickUpFieldData>..ctor
	|
	|-RVA: 0x2DA96D0 Offset: 0x2DA56D0 VA: 0x2DA96D0
	|-Comparer<MobaRoomData.MobaAbilityMasterData>..ctor
	|
	|-RVA: 0x2DA9D20 Offset: 0x2DA5D20 VA: 0x2DA9D20
	|-Comparer<NewWaveRoomData.Spotlight>..ctor
	|
	|-RVA: 0x2DAA354 Offset: 0x2DA6354 VA: 0x2DAA354
	|-Comparer<NguiDynamicFontController.ApplyTextureInfo>..ctor
	|
	|-RVA: 0x2DAA984 Offset: 0x2DA6984 VA: 0x2DAA984
	|-Comparer<RegexCharClass.SingleRange>..ctor
	|
	|-RVA: 0x2DAAFB8 Offset: 0x2DA6FB8 VA: 0x2DAAFB8
	|-Comparer<SocialAchievementData.LinkData>..ctor
	|
	|-RVA: 0x2DAB5E8 Offset: 0x2DA75E8 VA: 0x2DAB5E8
	|-Comparer<TrophyManager.TrophyData>..ctor
	|
	|-RVA: 0x2DABC50 Offset: 0x2DA7C50 VA: 0x2DABC50
	|-Comparer<UIEventMenuButton.MessageButtonData>..ctor
	|
	|-RVA: 0x2DAC2A0 Offset: 0x2DA82A0 VA: 0x2DAC2A0
	|-Comparer<UIFieldMapPanel.PopData>..ctor
	|
	|-RVA: 0x2DAC8D0 Offset: 0x2DA88D0 VA: 0x2DAC8D0
	|-Comparer<UIHouseAddressManager.Town>..ctor
	|
	|-RVA: 0x2DACF20 Offset: 0x2DA8F20 VA: 0x2DACF20
	|-Comparer<UIInfoWindow.LabelPosition>..ctor
	|
	|-RVA: 0x2DAD550 Offset: 0x2DA9550 VA: 0x2DAD550
	|-Comparer<UIMainManager.DropItemData>..ctor
	|
	|-RVA: 0x2DADB84 Offset: 0x2DA9B84 VA: 0x2DADB84
	|-Comparer<UIScenarioOrderPanel.MissionData>..ctor
	|
	|-RVA: 0x2DAE1F4 Offset: 0x2DAA1F4 VA: 0x2DAE1F4
	|-Comparer<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x2DAE828 Offset: 0x2DAA828 VA: 0x2DAE828
	|-Comparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0x2DAEE78 Offset: 0x2DAAE78 VA: 0x2DAEE78
	|-Comparer<BounceParabolaAttackPattern.TargetData.BoundLineData>..ctor
	|
	|-RVA: 0x2DAF4C8 Offset: 0x2DAB4C8 VA: 0x2DAF4C8
	|-Comparer<InstructionList.DebugView.InstructionView>..ctor
	*/
}
