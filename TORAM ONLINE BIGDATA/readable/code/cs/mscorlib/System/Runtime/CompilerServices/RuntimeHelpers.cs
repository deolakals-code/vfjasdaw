// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
public static class RuntimeHelpers // TypeDefIndex: 10547
{
	// Properties
	public static int OffsetToStringData { get; }

	// Methods

	// RVA: 0x2F227D0 Offset: 0x2F1E7D0 VA: 0x2F227D0
	private static void InitializeArray(Array array, IntPtr fldHandle) { }

	// RVA: 0x2F227D4 Offset: 0x2F1E7D4 VA: 0x2F227D4
	public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle) { }

	// RVA: 0x2F1EA60 Offset: 0x2F1AA60 VA: 0x2F1EA60
	public static int get_OffsetToStringData() { }

	// RVA: 0x2F22844 Offset: 0x2F1E844 VA: 0x2F22844
	public static int GetHashCode(object o) { }

	// RVA: 0x2F2284C Offset: 0x2F1E84C VA: 0x2F2284C
	public static object GetObjectValue(object obj) { }

	// RVA: 0x2F22850 Offset: 0x2F1E850 VA: 0x2F22850
	private static bool SufficientExecutionStack() { }

	// RVA: 0x2F22854 Offset: 0x2F1E854 VA: 0x2F22854
	public static bool TryEnsureSufficientExecutionStack() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x2F22858 Offset: 0x2F1E858 VA: 0x2F22858
	public static void PrepareConstrainedRegions() { }

	// RVA: -1 Offset: -1
	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E7654 Offset: 0x26E3654 VA: 0x26E7654
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<ArchetypeUid, object>>
	|
	|-RVA: 0x26E7754 Offset: 0x26E3754 VA: 0x26E7754
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<byte, BlackKnightCristaProperty>>
	|
	|-RVA: 0x26E7854 Offset: 0x26E3854 VA: 0x26E7854
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<byte, byte>>
	|
	|-RVA: 0x26E7954 Offset: 0x26E3954 VA: 0x26E7954
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<byte, object>>
	|
	|-RVA: 0x26E7A54 Offset: 0x26E3A54 VA: 0x26E7A54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<short, short>>
	|
	|-RVA: 0x26E7B54 Offset: 0x26E3B54 VA: 0x26E7B54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<int, short>>
	|
	|-RVA: 0x26E7C54 Offset: 0x26E3C54 VA: 0x26E7C54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<int, int>>
	|
	|-RVA: 0x26E7D54 Offset: 0x26E3D54 VA: 0x26E7D54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<int, object>>
	|
	|-RVA: 0x26E7E54 Offset: 0x26E3E54 VA: 0x26E7E54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<Int32Enum, byte>>
	|
	|-RVA: 0x26E7F54 Offset: 0x26E3F54 VA: 0x26E7F54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<Int32Enum, EnhanceProperties2>>
	|
	|-RVA: 0x26E8054 Offset: 0x26E4054 VA: 0x26E8054
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x26E8154 Offset: 0x26E4154 VA: 0x26E8154
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x26E8254 Offset: 0x26E4254 VA: 0x26E8254
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<object, int>>
	|
	|-RVA: 0x26E8354 Offset: 0x26E4354 VA: 0x26E8354
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<object, object>>
	|
	|-RVA: 0x26E8454 Offset: 0x26E4454 VA: 0x26E8454
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<object, float>>
	|
	|-RVA: 0x26E8554 Offset: 0x26E4554 VA: 0x26E8554
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<float, object>>
	|
	|-RVA: 0x26E8654 Offset: 0x26E4654 VA: 0x26E8654
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Nullable<UIMobPropertyLabel.IconValue>>
	|
	|-RVA: 0x26E8754 Offset: 0x26E4754 VA: 0x26E8754
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StructMultiKey<object, object>>
	|
	|-RVA: 0x26E8854 Offset: 0x26E4854 VA: 0x26E8854
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<short, short>>
	|
	|-RVA: 0x26E8954 Offset: 0x26E4954 VA: 0x26E8954
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<int, int>>
	|
	|-RVA: 0x26E8A54 Offset: 0x26E4A54 VA: 0x26E8A54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<int, object>>
	|
	|-RVA: 0x26E8B54 Offset: 0x26E4B54 VA: 0x26E8B54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<Int32Enum, float>>
	|
	|-RVA: 0x26E8C54 Offset: 0x26E4C54 VA: 0x26E8C54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<object, byte>>
	|
	|-RVA: 0x26E8D54 Offset: 0x26E4D54 VA: 0x26E8D54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<object, object>>
	|
	|-RVA: 0x26E8E54 Offset: 0x26E4E54 VA: 0x26E8E54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<float, object>>
	|
	|-RVA: 0x26E8F54 Offset: 0x26E4F54 VA: 0x26E8F54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<Vector3, Vector3>>
	|
	|-RVA: 0x26E9054 Offset: 0x26E5054 VA: 0x26E9054
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<short, int, int>>
	|
	|-RVA: 0x26E9154 Offset: 0x26E5154 VA: 0x26E9154
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ArchetypeUid>
	|
	|-RVA: 0x26E9254 Offset: 0x26E5254 VA: 0x26E9254
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BlackKnightAvatarProperty>
	|
	|-RVA: 0x26E9354 Offset: 0x26E5354 VA: 0x26E9354
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BlackKnightCristaProperty>
	|
	|-RVA: 0x26E9454 Offset: 0x26E5454 VA: 0x26E9454
	|-RuntimeHelpers.IsReferenceOrContainsReferences<bool>
	|
	|-RVA: 0x26E9554 Offset: 0x26E5554 VA: 0x26E9554
	|-RuntimeHelpers.IsReferenceOrContainsReferences<byte>
	|
	|-RVA: 0x26E9654 Offset: 0x26E5654 VA: 0x26E9654
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ByteEnum>
	|
	|-RVA: 0x26E9754 Offset: 0x26E5754 VA: 0x26E9754
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CardData>
	|
	|-RVA: 0x26E9854 Offset: 0x26E5854 VA: 0x26E9854
	|-RuntimeHelpers.IsReferenceOrContainsReferences<char>
	|
	|-RVA: 0x26E9954 Offset: 0x26E5954 VA: 0x26E9954
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Color>
	|
	|-RVA: 0x26E9A54 Offset: 0x26E5A54 VA: 0x26E9A54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Color32>
	|
	|-RVA: 0x26E9B54 Offset: 0x26E5B54 VA: 0x26E9B54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DateTime>
	|
	|-RVA: 0x26E9C54 Offset: 0x26E5C54 VA: 0x26E9C54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DateTimeOffset>
	|
	|-RVA: 0x26E9D54 Offset: 0x26E5D54 VA: 0x26E9D54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Decimal>
	|
	|-RVA: 0x26E9E54 Offset: 0x26E5E54 VA: 0x26E9E54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DefencePoint2>
	|
	|-RVA: 0x26E9F54 Offset: 0x26E5F54 VA: 0x26E9F54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<double>
	|
	|-RVA: 0x26EA054 Offset: 0x26E6054 VA: 0x26EA054
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EnhanceProperties2>
	|
	|-RVA: 0x26EA154 Offset: 0x26E6154 VA: 0x26EA154
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EventSummary>
	|
	|-RVA: 0x26EA254 Offset: 0x26E6254 VA: 0x26EA254
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Guid>
	|
	|-RVA: 0x26EA354 Offset: 0x26E6354 VA: 0x26EA354
	|-RuntimeHelpers.IsReferenceOrContainsReferences<short>
	|
	|-RVA: 0x26EA454 Offset: 0x26E6454 VA: 0x26EA454
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Int16Enum>
	|
	|-RVA: 0x26EA554 Offset: 0x26E6554 VA: 0x26EA554
	|-RuntimeHelpers.IsReferenceOrContainsReferences<int>
	|
	|-RVA: 0x26EA654 Offset: 0x26E6654 VA: 0x26EA654
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Int32Enum>
	|
	|-RVA: 0x26EA754 Offset: 0x26E6754 VA: 0x26EA754
	|-RuntimeHelpers.IsReferenceOrContainsReferences<long>
	|
	|-RVA: 0x26EA854 Offset: 0x26E6854 VA: 0x26EA854
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Int64Enum>
	|
	|-RVA: 0x26EA954 Offset: 0x26E6954 VA: 0x26EA954
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IntPtr>
	|
	|-RVA: 0x26EAA54 Offset: 0x26E6A54 VA: 0x26EAA54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InterpretedFrameInfo>
	|
	|-RVA: 0x26EAB54 Offset: 0x26E6B54 VA: 0x26EAB54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<JsonPosition>
	|
	|-RVA: 0x26EAC54 Offset: 0x26E6C54 VA: 0x26EAC54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MaterialSearchData>
	|
	|-RVA: 0x26EAD54 Offset: 0x26E6D54 VA: 0x26EAD54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MobActionTargetData>
	|
	|-RVA: 0x26EAE54 Offset: 0x26E6E54 VA: 0x26EAE54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MobIconLabelData>
	|
	|-RVA: 0x26EAF54 Offset: 0x26E6F54 VA: 0x26EAF54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<object>
	|
	|-RVA: 0x26EB054 Offset: 0x26E7054 VA: 0x26EB054
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PlayerLoopSystem>
	|
	|-RVA: 0x26EB154 Offset: 0x26E7154 VA: 0x26EB154
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PlayerLoopSystemInternal>
	|
	|-RVA: 0x26EB254 Offset: 0x26E7254 VA: 0x26EB254
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RangePositionInfo>
	|
	|-RVA: 0x26EB354 Offset: 0x26E7354 VA: 0x26EB354
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ReinforceCristaData>
	|
	|-RVA: 0x26EB454 Offset: 0x26E7454 VA: 0x26EB454
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RenderInstancedDataLayout>
	|
	|-RVA: 0x26EB554 Offset: 0x26E7554 VA: 0x26EB554
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ResourceLocator>
	|
	|-RVA: 0x26EB654 Offset: 0x26E7654 VA: 0x26EB654
	|-RuntimeHelpers.IsReferenceOrContainsReferences<sbyte>
	|
	|-RVA: 0x26EB754 Offset: 0x26E7754 VA: 0x26EB754
	|-RuntimeHelpers.IsReferenceOrContainsReferences<float>
	|
	|-RVA: 0x26EB854 Offset: 0x26E7854 VA: 0x26EB854
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SkillIdData>
	|
	|-RVA: 0x26EB954 Offset: 0x26E7954 VA: 0x26EB954
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TimeSpan>
	|
	|-RVA: 0x26EBA54 Offset: 0x26E7A54 VA: 0x26EBA54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ushort>
	|
	|-RVA: 0x26EBB54 Offset: 0x26E7B54 VA: 0x26EBB54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<uint>
	|
	|-RVA: 0x26EBC54 Offset: 0x26E7C54 VA: 0x26EBC54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ulong>
	|
	|-RVA: 0x26EBD54 Offset: 0x26E7D54 VA: 0x26EBD54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector2>
	|
	|-RVA: 0x26EBE54 Offset: 0x26E7E54 VA: 0x26EBE54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector3>
	|
	|-RVA: 0x26EBF54 Offset: 0x26E7F54 VA: 0x26EBF54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector4>
	|
	|-RVA: 0x26EC054 Offset: 0x26E8054 VA: 0x26EC054
	|-RuntimeHelpers.IsReferenceOrContainsReferences<X509ChainStatus>
	|
	|-RVA: 0x26EC154 Offset: 0x26E8154 VA: 0x26EC154
	|-RuntimeHelpers.IsReferenceOrContainsReferences<XPathNodeRef>
	|
	|-RVA: 0x26EC254 Offset: 0x26E8254 VA: 0x26EC254
	|-RuntimeHelpers.IsReferenceOrContainsReferences<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x26EC354 Offset: 0x26E8354 VA: 0x26EC354
	|-RuntimeHelpers.IsReferenceOrContainsReferences<jvalue>
	|
	|-RVA: 0x26EC454 Offset: 0x26E8454 VA: 0x26EC454
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x26EC554 Offset: 0x26E8554 VA: 0x26EC554
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BoneClip.MotionKeyFrame>
	|
	|-RVA: 0x26EC654 Offset: 0x26E8654 VA: 0x26EC654
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DeathReceptionAction.PoisonTargetData>
	|
	|-RVA: 0x26EC754 Offset: 0x26E8754 VA: 0x26EC754
	|-RuntimeHelpers.IsReferenceOrContainsReferences<HouseRecipeManager.RecipeData>
	|
	|-RVA: 0x26EC854 Offset: 0x26E8854 VA: 0x26EC854
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KadarElexioBuf.SkillIdData>
	|
	|-RVA: 0x26EC954 Offset: 0x26E8954 VA: 0x26EC954
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MasterModelDataManager.ColorListData>
	|
	|-RVA: 0x26ECA54 Offset: 0x26E8A54 VA: 0x26ECA54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MasterModelDataManager.ConvertCommonMaterialData>
	|
	|-RVA: 0x26ECB54 Offset: 0x26E8B54 VA: 0x26ECB54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MaterialManager.pair>
	|
	|-RVA: 0x26ECC54 Offset: 0x26E8C54 VA: 0x26ECC54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MissionTextManagerData.CheckIKeywordtemData>
	|
	|-RVA: 0x26ECD54 Offset: 0x26E8D54 VA: 0x26ECD54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MissionTextManagerData.PickUpFieldData>
	|
	|-RVA: 0x26ECE54 Offset: 0x26E8E54 VA: 0x26ECE54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MobaRoomData.MobaAbilityMasterData>
	|
	|-RVA: 0x26ECF54 Offset: 0x26E8F54 VA: 0x26ECF54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NewWaveRoomData.Spotlight>
	|
	|-RVA: 0x26ED054 Offset: 0x26E9054 VA: 0x26ED054
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NguiDynamicFontController.ApplyTextureInfo>
	|
	|-RVA: 0x26ED154 Offset: 0x26E9154 VA: 0x26ED154
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Regex.CachedCodeEntryKey>
	|
	|-RVA: 0x26ED254 Offset: 0x26E9254 VA: 0x26ED254
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RegexCharClass.SingleRange>
	|
	|-RVA: 0x26ED354 Offset: 0x26E9354 VA: 0x26ED354
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x26ED454 Offset: 0x26E9454 VA: 0x26ED454
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SocialAchievementData.LinkData>
	|
	|-RVA: 0x26ED554 Offset: 0x26E9554 VA: 0x26ED554
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TrophyManager.TrophyData>
	|
	|-RVA: 0x26ED654 Offset: 0x26E9654 VA: 0x26ED654
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIEventMenuButton.MessageButtonData>
	|
	|-RVA: 0x26ED754 Offset: 0x26E9754 VA: 0x26ED754
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIFieldMapPanel.PopData>
	|
	|-RVA: 0x26ED854 Offset: 0x26E9854 VA: 0x26ED854
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIGuildQuestBoardManager.GuildQuestMaseter>
	|
	|-RVA: 0x26ED954 Offset: 0x26E9954 VA: 0x26ED954
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIHouseAddressManager.Town>
	|
	|-RVA: 0x26EDA54 Offset: 0x26E9A54 VA: 0x26EDA54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIInfoWindow.LabelPosition>
	|
	|-RVA: 0x26EDB54 Offset: 0x26E9B54 VA: 0x26EDB54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIMainManager.DropItemData>
	|
	|-RVA: 0x26EDC54 Offset: 0x26E9C54 VA: 0x26EDC54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIScenarioOrderPanel.MissionData>
	|
	|-RVA: 0x26EDD54 Offset: 0x26E9D54 VA: 0x26EDD54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x26EDE54 Offset: 0x26E9E54 VA: 0x26EDE54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x26EDF54 Offset: 0x26E9F54 VA: 0x26EDF54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BindingRestrictions.TestBuilder.AndNode>
	|
	|-RVA: 0x26EE054 Offset: 0x26EA054 VA: 0x26EE054
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BounceParabolaAttackPattern.TargetData.BoundLineData>
	|
	|-RVA: 0x26EE154 Offset: 0x26EA154 VA: 0x26EE154
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InstructionList.DebugView.InstructionView>
	|
	|-RVA: 0x26EE254 Offset: 0x26EA254 VA: 0x26EE254
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PartyManager.PartyData.pair>
	*/
}
