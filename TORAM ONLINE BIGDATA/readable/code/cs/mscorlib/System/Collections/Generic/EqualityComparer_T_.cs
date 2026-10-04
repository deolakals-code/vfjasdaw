// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
[TypeDependency("System.Collections.Generic.ObjectEqualityComparer`1")]
[Serializable]
public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T> // TypeDefIndex: 10976
{
	// Fields
	private static EqualityComparer<T> defaultComparer; // 0x0

	// Properties
	public static EqualityComparer<T> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static EqualityComparer<T> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29B2EA8 Offset: 0x29AEEA8 VA: 0x29B2EA8
	|-EqualityComparer<KeyValuePair<ArchetypeUid, object>>.get_Default
	|
	|-RVA: 0x29B3918 Offset: 0x29AF918 VA: 0x29B3918
	|-EqualityComparer<KeyValuePair<byte, BlackKnightCristaProperty>>.get_Default
	|
	|-RVA: 0x29B4368 Offset: 0x29B0368 VA: 0x29B4368
	|-EqualityComparer<KeyValuePair<byte, byte>>.get_Default
	|
	|-RVA: 0x29B4DB8 Offset: 0x29B0DB8 VA: 0x29B4DB8
	|-EqualityComparer<KeyValuePair<byte, object>>.get_Default
	|
	|-RVA: 0x29B5828 Offset: 0x29B1828 VA: 0x29B5828
	|-EqualityComparer<KeyValuePair<short, short>>.get_Default
	|
	|-RVA: 0x29B6278 Offset: 0x29B2278 VA: 0x29B6278
	|-EqualityComparer<KeyValuePair<int, short>>.get_Default
	|
	|-RVA: 0x29B6CC8 Offset: 0x29B2CC8 VA: 0x29B6CC8
	|-EqualityComparer<KeyValuePair<int, int>>.get_Default
	|
	|-RVA: 0x29B7718 Offset: 0x29B3718 VA: 0x29B7718
	|-EqualityComparer<KeyValuePair<int, object>>.get_Default
	|
	|-RVA: 0x29B8188 Offset: 0x29B4188 VA: 0x29B8188
	|-EqualityComparer<KeyValuePair<Int32Enum, byte>>.get_Default
	|
	|-RVA: 0x29B8BD8 Offset: 0x29B4BD8 VA: 0x29B8BD8
	|-EqualityComparer<KeyValuePair<Int32Enum, EnhanceProperties2>>.get_Default
	|
	|-RVA: 0x29B973C Offset: 0x29B573C VA: 0x29B973C
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.get_Default
	|
	|-RVA: 0x29BA18C Offset: 0x29B618C VA: 0x29BA18C
	|-EqualityComparer<KeyValuePair<Int32Enum, object>>.get_Default
	|
	|-RVA: 0x29BABFC Offset: 0x29B6BFC VA: 0x29BABFC
	|-EqualityComparer<KeyValuePair<object, int>>.get_Default
	|
	|-RVA: 0x29BB66C Offset: 0x29B766C VA: 0x29BB66C
	|-EqualityComparer<KeyValuePair<object, object>>.get_Default
	|
	|-RVA: 0x29BC0DC Offset: 0x29B80DC VA: 0x29BC0DC
	|-EqualityComparer<KeyValuePair<object, float>>.get_Default
	|
	|-RVA: 0x29BCE1C Offset: 0x29B8E1C VA: 0x29BCE1C
	|-EqualityComparer<KeyValuePair<float, object>>.get_Default
	|
	|-RVA: 0x29BD88C Offset: 0x29B988C VA: 0x29BD88C
	|-EqualityComparer<Nullable<UIMobPropertyLabel.IconValue>>.get_Default
	|
	|-RVA: 0x29BE398 Offset: 0x29BA398 VA: 0x29BE398
	|-EqualityComparer<StructMultiKey<object, object>>.get_Default
	|
	|-RVA: 0x29BEE08 Offset: 0x29BAE08 VA: 0x29BEE08
	|-EqualityComparer<ValueTuple<bool>>.get_Default
	|
	|-RVA: 0x29BF858 Offset: 0x29BB858 VA: 0x29BF858
	|-EqualityComparer<ValueTuple<short, short>>.get_Default
	|
	|-RVA: 0x29C02A8 Offset: 0x29BC2A8 VA: 0x29C02A8
	|-EqualityComparer<ValueTuple<int, int>>.get_Default
	|
	|-RVA: 0x29C0CF8 Offset: 0x29BCCF8 VA: 0x29C0CF8
	|-EqualityComparer<ValueTuple<int, object>>.get_Default
	|
	|-RVA: 0x29C1768 Offset: 0x29BD768 VA: 0x29C1768
	|-EqualityComparer<ValueTuple<Int32Enum, float>>.get_Default
	|
	|-RVA: 0x29C21B8 Offset: 0x29BE1B8 VA: 0x29C21B8
	|-EqualityComparer<ValueTuple<object, byte>>.get_Default
	|
	|-RVA: 0x29C2C28 Offset: 0x29BEC28 VA: 0x29C2C28
	|-EqualityComparer<ValueTuple<object, object>>.get_Default
	|
	|-RVA: 0x29C3698 Offset: 0x29BF698 VA: 0x29C3698
	|-EqualityComparer<ValueTuple<float, object>>.get_Default
	|
	|-RVA: 0x29C4108 Offset: 0x29C0108 VA: 0x29C4108
	|-EqualityComparer<ValueTuple<Vector3, Vector3>>.get_Default
	|
	|-RVA: 0x29C4C5C Offset: 0x29C0C5C VA: 0x29C4C5C
	|-EqualityComparer<ValueTuple<short, int, int>>.get_Default
	|
	|-RVA: 0x29C56E8 Offset: 0x29C16E8 VA: 0x29C56E8
	|-EqualityComparer<ValueTuple<object, object, object>>.get_Default
	|
	|-RVA: 0x29C623C Offset: 0x29C223C VA: 0x29C623C
	|-EqualityComparer<ArchetypeUid>.get_Default
	|
	|-RVA: 0x29C6C8C Offset: 0x29C2C8C VA: 0x29C6C8C
	|-EqualityComparer<BlackKnightAvatarProperty>.get_Default
	|
	|-RVA: 0x29C7718 Offset: 0x29C3718 VA: 0x29C7718
	|-EqualityComparer<BlackKnightCristaProperty>.get_Default
	|
	|-RVA: 0x29C81A8 Offset: 0x29C41A8 VA: 0x29C81A8
	|-EqualityComparer<bool>.get_Default
	|
	|-RVA: 0x29C8C08 Offset: 0x29C4C08 VA: 0x29C8C08
	|-EqualityComparer<byte>.get_Default
	|
	|-RVA: 0x29C9658 Offset: 0x29C5658 VA: 0x29C9658
	|-EqualityComparer<ByteEnum>.get_Default
	|
	|-RVA: 0x29CA0A8 Offset: 0x29C60A8 VA: 0x29CA0A8
	|-EqualityComparer<CardData>.get_Default
	|
	|-RVA: 0x29CAB34 Offset: 0x29C6B34 VA: 0x29CAB34
	|-EqualityComparer<char>.get_Default
	|
	|-RVA: 0x29CB584 Offset: 0x29C7584 VA: 0x29CB584
	|-EqualityComparer<Color>.get_Default
	|
	|-RVA: 0x29CC058 Offset: 0x29C8058 VA: 0x29CC058
	|-EqualityComparer<Color32>.get_Default
	|
	|-RVA: 0x29CCAA8 Offset: 0x29C8AA8 VA: 0x29CCAA8
	|-EqualityComparer<DateTime>.get_Default
	|
	|-RVA: 0x29CD4F8 Offset: 0x29C94F8 VA: 0x29CD4F8
	|-EqualityComparer<DateTimeOffset>.get_Default
	|
	|-RVA: 0x29CDF68 Offset: 0x29C9F68 VA: 0x29CDF68
	|-EqualityComparer<Decimal>.get_Default
	|
	|-RVA: 0x29CE9D8 Offset: 0x29CA9D8 VA: 0x29CE9D8
	|-EqualityComparer<DefencePoint2>.get_Default
	|
	|-RVA: 0x29CF428 Offset: 0x29CB428 VA: 0x29CF428
	|-EqualityComparer<double>.get_Default
	|
	|-RVA: 0x29CFE8C Offset: 0x29CBE8C VA: 0x29CFE8C
	|-EqualityComparer<EnhanceProperties2>.get_Default
	|
	|-RVA: 0x29D09EC Offset: 0x29CC9EC VA: 0x29D09EC
	|-EqualityComparer<EventSummary>.get_Default
	|
	|-RVA: 0x29D145C Offset: 0x29CD45C VA: 0x29D145C
	|-EqualityComparer<Guid>.get_Default
	|
	|-RVA: 0x29D1ECC Offset: 0x29CDECC VA: 0x29D1ECC
	|-EqualityComparer<short>.get_Default
	|
	|-RVA: 0x29D291C Offset: 0x29CE91C VA: 0x29D291C
	|-EqualityComparer<Int16Enum>.get_Default
	|
	|-RVA: 0x29D336C Offset: 0x29CF36C VA: 0x29D336C
	|-EqualityComparer<int>.get_Default
	|
	|-RVA: 0x29D3DBC Offset: 0x29CFDBC VA: 0x29D3DBC
	|-EqualityComparer<Int32Enum>.get_Default
	|
	|-RVA: 0x29D480C Offset: 0x29D080C VA: 0x29D480C
	|-EqualityComparer<long>.get_Default
	|
	|-RVA: 0x29D525C Offset: 0x29D125C VA: 0x29D525C
	|-EqualityComparer<Int64Enum>.get_Default
	|
	|-RVA: 0x29D5CAC Offset: 0x29D1CAC VA: 0x29D5CAC
	|-EqualityComparer<IntPtr>.get_Default
	|
	|-RVA: 0x29D66FC Offset: 0x29D26FC VA: 0x29D66FC
	|-EqualityComparer<InterpretedFrameInfo>.get_Default
	|
	|-RVA: 0x29D716C Offset: 0x29D316C VA: 0x29D716C
	|-EqualityComparer<JsonPosition>.get_Default
	|
	|-RVA: 0x29D7CC0 Offset: 0x29D3CC0 VA: 0x29D7CC0
	|-EqualityComparer<MaterialSearchData>.get_Default
	|
	|-RVA: 0x29D8730 Offset: 0x29D4730 VA: 0x29D8730
	|-EqualityComparer<MobActionTargetData>.get_Default
	|
	|-RVA: 0x29D9284 Offset: 0x29D5284 VA: 0x29D9284
	|-EqualityComparer<MobIconLabelData>.get_Default
	|
	|-RVA: 0x29D9DD8 Offset: 0x29D5DD8 VA: 0x29D9DD8
	|-EqualityComparer<object>.get_Default
	|
	|-RVA: 0x29DA82C Offset: 0x29D682C VA: 0x29DA82C
	|-EqualityComparer<PlayerLoopSystem>.get_Default
	|
	|-RVA: 0x29DB38C Offset: 0x29D738C VA: 0x29DB38C
	|-EqualityComparer<PlayerLoopSystemInternal>.get_Default
	|
	|-RVA: 0x29DBEEC Offset: 0x29D7EEC VA: 0x29DBEEC
	|-EqualityComparer<RangePositionInfo>.get_Default
	|
	|-RVA: 0x29DC95C Offset: 0x29D895C VA: 0x29DC95C
	|-EqualityComparer<ReinforceCristaData>.get_Default
	|
	|-RVA: 0x29DD3E8 Offset: 0x29D93E8 VA: 0x29DD3E8
	|-EqualityComparer<RenderInstancedDataLayout>.get_Default
	|
	|-RVA: 0x29DDE58 Offset: 0x29D9E58 VA: 0x29DDE58
	|-EqualityComparer<ResourceLocator>.get_Default
	|
	|-RVA: 0x29DE8C8 Offset: 0x29DA8C8 VA: 0x29DE8C8
	|-EqualityComparer<sbyte>.get_Default
	|
	|-RVA: 0x29DF318 Offset: 0x29DB318 VA: 0x29DF318
	|-EqualityComparer<float>.get_Default
	|
	|-RVA: 0x29DFD7C Offset: 0x29DBD7C VA: 0x29DFD7C
	|-EqualityComparer<SkillIdData>.get_Default
	|
	|-RVA: 0x29E07CC Offset: 0x29DC7CC VA: 0x29E07CC
	|-EqualityComparer<TimeSpan>.get_Default
	|
	|-RVA: 0x29E121C Offset: 0x29DD21C VA: 0x29E121C
	|-EqualityComparer<ushort>.get_Default
	|
	|-RVA: 0x29E1C6C Offset: 0x29DDC6C VA: 0x29E1C6C
	|-EqualityComparer<uint>.get_Default
	|
	|-RVA: 0x29E26BC Offset: 0x29DE6BC VA: 0x29E26BC
	|-EqualityComparer<ulong>.get_Default
	|
	|-RVA: 0x29E310C Offset: 0x29DF10C VA: 0x29E310C
	|-EqualityComparer<Vector2>.get_Default
	|
	|-RVA: 0x29E3B88 Offset: 0x29DFB88 VA: 0x29E3B88
	|-EqualityComparer<Vector3>.get_Default
	|
	|-RVA: 0x29E4650 Offset: 0x29E0650 VA: 0x29E4650
	|-EqualityComparer<Vector4>.get_Default
	|
	|-RVA: 0x29E5124 Offset: 0x29E1124 VA: 0x29E5124
	|-EqualityComparer<X509ChainStatus>.get_Default
	|
	|-RVA: 0x29E5B94 Offset: 0x29E1B94 VA: 0x29E5B94
	|-EqualityComparer<XPathNodeRef>.get_Default
	|
	|-RVA: 0x29E6604 Offset: 0x29E2604 VA: 0x29E6604
	|-EqualityComparer<__Il2CppFullySharedGenericType>.get_Default
	|
	|-RVA: 0x29E7358 Offset: 0x29E3358 VA: 0x29E7358
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.get_Default
	|
	|-RVA: 0x29E7DC8 Offset: 0x29E3DC8 VA: 0x29E7DC8
	|-EqualityComparer<BoneClip.MotionKeyFrame>.get_Default
	|
	|-RVA: 0x29E891C Offset: 0x29E491C VA: 0x29E891C
	|-EqualityComparer<DeathReceptionAction.PoisonTargetData>.get_Default
	|
	|-RVA: 0x29E938C Offset: 0x29E538C VA: 0x29E938C
	|-EqualityComparer<HouseRecipeManager.RecipeData>.get_Default
	|
	|-RVA: 0x29E9EEC Offset: 0x29E5EEC VA: 0x29E9EEC
	|-EqualityComparer<KadarElexioBuf.SkillIdData>.get_Default
	|
	|-RVA: 0x29EA93C Offset: 0x29E693C VA: 0x29EA93C
	|-EqualityComparer<MasterModelDataManager.ColorListData>.get_Default
	|
	|-RVA: 0x29EB480 Offset: 0x29E7480 VA: 0x29EB480
	|-EqualityComparer<MasterModelDataManager.ConvertCommonMaterialData>.get_Default
	|
	|-RVA: 0x29EBED0 Offset: 0x29E7ED0 VA: 0x29EBED0
	|-EqualityComparer<MaterialManager.pair>.get_Default
	|
	|-RVA: 0x29EC920 Offset: 0x29E8920 VA: 0x29EC920
	|-EqualityComparer<MissionTextManagerData.CheckIKeywordtemData>.get_Default
	|
	|-RVA: 0x29ED3AC Offset: 0x29E93AC VA: 0x29ED3AC
	|-EqualityComparer<MissionTextManagerData.PickUpFieldData>.get_Default
	|
	|-RVA: 0x29EDE38 Offset: 0x29E9E38 VA: 0x29EDE38
	|-EqualityComparer<MobaRoomData.MobaAbilityMasterData>.get_Default
	|
	|-RVA: 0x29EE8A8 Offset: 0x29EA8A8 VA: 0x29EE8A8
	|-EqualityComparer<NewWaveRoomData.Spotlight>.get_Default
	|
	|-RVA: 0x29EF38C Offset: 0x29EB38C VA: 0x29EF38C
	|-EqualityComparer<NguiDynamicFontController.ApplyTextureInfo>.get_Default
	|
	|-RVA: 0x29EFDFC Offset: 0x29EBDFC VA: 0x29EFDFC
	|-EqualityComparer<Regex.CachedCodeEntryKey>.get_Default
	|
	|-RVA: 0x29F0950 Offset: 0x29EC950 VA: 0x29F0950
	|-EqualityComparer<RegexCharClass.SingleRange>.get_Default
	|
	|-RVA: 0x29F13A0 Offset: 0x29ED3A0 VA: 0x29F13A0
	|-EqualityComparer<SocialAchievementData.LinkData>.get_Default
	|
	|-RVA: 0x29F1E10 Offset: 0x29EDE10 VA: 0x29F1E10
	|-EqualityComparer<TrophyManager.TrophyData>.get_Default
	|
	|-RVA: 0x29F2860 Offset: 0x29EE860 VA: 0x29F2860
	|-EqualityComparer<UIEventMenuButton.MessageButtonData>.get_Default
	|
	|-RVA: 0x29F33A4 Offset: 0x29EF3A4 VA: 0x29F33A4
	|-EqualityComparer<UIFieldMapPanel.PopData>.get_Default
	|
	|-RVA: 0x29F3E88 Offset: 0x29EFE88 VA: 0x29F3E88
	|-EqualityComparer<UIGuildQuestBoardManager.GuildQuestMaseter>.get_Default
	|
	|-RVA: 0x29F49EC Offset: 0x29F09EC VA: 0x29F49EC
	|-EqualityComparer<UIHouseAddressManager.Town>.get_Default
	|
	|-RVA: 0x29F543C Offset: 0x29F143C VA: 0x29F543C
	|-EqualityComparer<UIInfoWindow.LabelPosition>.get_Default
	|
	|-RVA: 0x29F5F20 Offset: 0x29F1F20 VA: 0x29F5F20
	|-EqualityComparer<UIMainManager.DropItemData>.get_Default
	|
	|-RVA: 0x29F6970 Offset: 0x29F2970 VA: 0x29F6970
	|-EqualityComparer<UIScenarioOrderPanel.MissionData>.get_Default
	|
	|-RVA: 0x29F73E0 Offset: 0x29F33E0 VA: 0x29F73E0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.get_Default
	|
	|-RVA: 0x29F7F34 Offset: 0x29F3F34 VA: 0x29F7F34
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Default
	|
	|-RVA: 0x29F89A4 Offset: 0x29F49A4 VA: 0x29F89A4
	|-EqualityComparer<BounceParabolaAttackPattern.TargetData.BoundLineData>.get_Default
	|
	|-RVA: 0x29F9488 Offset: 0x29F5488 VA: 0x29F9488
	|-EqualityComparer<InstructionList.DebugView.InstructionView>.get_Default
	|
	|-RVA: 0x29F9F6C Offset: 0x29F5F6C VA: 0x29F9F6C
	|-EqualityComparer<PartyManager.PartyData.pair>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static EqualityComparer<T> CreateComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29B2F78 Offset: 0x29AEF78 VA: 0x29B2F78
	|-EqualityComparer<KeyValuePair<ArchetypeUid, object>>.CreateComparer
	|
	|-RVA: 0x29B39E8 Offset: 0x29AF9E8 VA: 0x29B39E8
	|-EqualityComparer<KeyValuePair<byte, BlackKnightCristaProperty>>.CreateComparer
	|
	|-RVA: 0x29B4438 Offset: 0x29B0438 VA: 0x29B4438
	|-EqualityComparer<KeyValuePair<byte, byte>>.CreateComparer
	|
	|-RVA: 0x29B4E88 Offset: 0x29B0E88 VA: 0x29B4E88
	|-EqualityComparer<KeyValuePair<byte, object>>.CreateComparer
	|
	|-RVA: 0x29B58F8 Offset: 0x29B18F8 VA: 0x29B58F8
	|-EqualityComparer<KeyValuePair<short, short>>.CreateComparer
	|
	|-RVA: 0x29B6348 Offset: 0x29B2348 VA: 0x29B6348
	|-EqualityComparer<KeyValuePair<int, short>>.CreateComparer
	|
	|-RVA: 0x29B6D98 Offset: 0x29B2D98 VA: 0x29B6D98
	|-EqualityComparer<KeyValuePair<int, int>>.CreateComparer
	|
	|-RVA: 0x29B77E8 Offset: 0x29B37E8 VA: 0x29B77E8
	|-EqualityComparer<KeyValuePair<int, object>>.CreateComparer
	|
	|-RVA: 0x29B8258 Offset: 0x29B4258 VA: 0x29B8258
	|-EqualityComparer<KeyValuePair<Int32Enum, byte>>.CreateComparer
	|
	|-RVA: 0x29B8CA8 Offset: 0x29B4CA8 VA: 0x29B8CA8
	|-EqualityComparer<KeyValuePair<Int32Enum, EnhanceProperties2>>.CreateComparer
	|
	|-RVA: 0x29B980C Offset: 0x29B580C VA: 0x29B980C
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.CreateComparer
	|
	|-RVA: 0x29BA25C Offset: 0x29B625C VA: 0x29BA25C
	|-EqualityComparer<KeyValuePair<Int32Enum, object>>.CreateComparer
	|
	|-RVA: 0x29BACCC Offset: 0x29B6CCC VA: 0x29BACCC
	|-EqualityComparer<KeyValuePair<object, int>>.CreateComparer
	|
	|-RVA: 0x29BB73C Offset: 0x29B773C VA: 0x29BB73C
	|-EqualityComparer<KeyValuePair<object, object>>.CreateComparer
	|
	|-RVA: 0x29BC1AC Offset: 0x29B81AC VA: 0x29BC1AC
	|-EqualityComparer<KeyValuePair<object, float>>.CreateComparer
	|
	|-RVA: 0x29BCEEC Offset: 0x29B8EEC VA: 0x29BCEEC
	|-EqualityComparer<KeyValuePair<float, object>>.CreateComparer
	|
	|-RVA: 0x29BD95C Offset: 0x29B995C VA: 0x29BD95C
	|-EqualityComparer<Nullable<UIMobPropertyLabel.IconValue>>.CreateComparer
	|
	|-RVA: 0x29BE468 Offset: 0x29BA468 VA: 0x29BE468
	|-EqualityComparer<StructMultiKey<object, object>>.CreateComparer
	|
	|-RVA: 0x29BEED8 Offset: 0x29BAED8 VA: 0x29BEED8
	|-EqualityComparer<ValueTuple<bool>>.CreateComparer
	|
	|-RVA: 0x29BF928 Offset: 0x29BB928 VA: 0x29BF928
	|-EqualityComparer<ValueTuple<short, short>>.CreateComparer
	|
	|-RVA: 0x29C0378 Offset: 0x29BC378 VA: 0x29C0378
	|-EqualityComparer<ValueTuple<int, int>>.CreateComparer
	|
	|-RVA: 0x29C0DC8 Offset: 0x29BCDC8 VA: 0x29C0DC8
	|-EqualityComparer<ValueTuple<int, object>>.CreateComparer
	|
	|-RVA: 0x29C1838 Offset: 0x29BD838 VA: 0x29C1838
	|-EqualityComparer<ValueTuple<Int32Enum, float>>.CreateComparer
	|
	|-RVA: 0x29C2288 Offset: 0x29BE288 VA: 0x29C2288
	|-EqualityComparer<ValueTuple<object, byte>>.CreateComparer
	|
	|-RVA: 0x29C2CF8 Offset: 0x29BECF8 VA: 0x29C2CF8
	|-EqualityComparer<ValueTuple<object, object>>.CreateComparer
	|
	|-RVA: 0x29C3768 Offset: 0x29BF768 VA: 0x29C3768
	|-EqualityComparer<ValueTuple<float, object>>.CreateComparer
	|
	|-RVA: 0x29C41D8 Offset: 0x29C01D8 VA: 0x29C41D8
	|-EqualityComparer<ValueTuple<Vector3, Vector3>>.CreateComparer
	|
	|-RVA: 0x29C4D2C Offset: 0x29C0D2C VA: 0x29C4D2C
	|-EqualityComparer<ValueTuple<short, int, int>>.CreateComparer
	|
	|-RVA: 0x29C57B8 Offset: 0x29C17B8 VA: 0x29C57B8
	|-EqualityComparer<ValueTuple<object, object, object>>.CreateComparer
	|
	|-RVA: 0x29C630C Offset: 0x29C230C VA: 0x29C630C
	|-EqualityComparer<ArchetypeUid>.CreateComparer
	|
	|-RVA: 0x29C6D5C Offset: 0x29C2D5C VA: 0x29C6D5C
	|-EqualityComparer<BlackKnightAvatarProperty>.CreateComparer
	|
	|-RVA: 0x29C77E8 Offset: 0x29C37E8 VA: 0x29C77E8
	|-EqualityComparer<BlackKnightCristaProperty>.CreateComparer
	|
	|-RVA: 0x29C8278 Offset: 0x29C4278 VA: 0x29C8278
	|-EqualityComparer<bool>.CreateComparer
	|
	|-RVA: 0x29C8CD8 Offset: 0x29C4CD8 VA: 0x29C8CD8
	|-EqualityComparer<byte>.CreateComparer
	|
	|-RVA: 0x29C9728 Offset: 0x29C5728 VA: 0x29C9728
	|-EqualityComparer<ByteEnum>.CreateComparer
	|
	|-RVA: 0x29CA178 Offset: 0x29C6178 VA: 0x29CA178
	|-EqualityComparer<CardData>.CreateComparer
	|
	|-RVA: 0x29CAC04 Offset: 0x29C6C04 VA: 0x29CAC04
	|-EqualityComparer<char>.CreateComparer
	|
	|-RVA: 0x29CB654 Offset: 0x29C7654 VA: 0x29CB654
	|-EqualityComparer<Color>.CreateComparer
	|
	|-RVA: 0x29CC128 Offset: 0x29C8128 VA: 0x29CC128
	|-EqualityComparer<Color32>.CreateComparer
	|
	|-RVA: 0x29CCB78 Offset: 0x29C8B78 VA: 0x29CCB78
	|-EqualityComparer<DateTime>.CreateComparer
	|
	|-RVA: 0x29CD5C8 Offset: 0x29C95C8 VA: 0x29CD5C8
	|-EqualityComparer<DateTimeOffset>.CreateComparer
	|
	|-RVA: 0x29CE038 Offset: 0x29CA038 VA: 0x29CE038
	|-EqualityComparer<Decimal>.CreateComparer
	|
	|-RVA: 0x29CEAA8 Offset: 0x29CAAA8 VA: 0x29CEAA8
	|-EqualityComparer<DefencePoint2>.CreateComparer
	|
	|-RVA: 0x29CF4F8 Offset: 0x29CB4F8 VA: 0x29CF4F8
	|-EqualityComparer<double>.CreateComparer
	|
	|-RVA: 0x29CFF5C Offset: 0x29CBF5C VA: 0x29CFF5C
	|-EqualityComparer<EnhanceProperties2>.CreateComparer
	|
	|-RVA: 0x29D0ABC Offset: 0x29CCABC VA: 0x29D0ABC
	|-EqualityComparer<EventSummary>.CreateComparer
	|
	|-RVA: 0x29D152C Offset: 0x29CD52C VA: 0x29D152C
	|-EqualityComparer<Guid>.CreateComparer
	|
	|-RVA: 0x29D1F9C Offset: 0x29CDF9C VA: 0x29D1F9C
	|-EqualityComparer<short>.CreateComparer
	|
	|-RVA: 0x29D29EC Offset: 0x29CE9EC VA: 0x29D29EC
	|-EqualityComparer<Int16Enum>.CreateComparer
	|
	|-RVA: 0x29D343C Offset: 0x29CF43C VA: 0x29D343C
	|-EqualityComparer<int>.CreateComparer
	|
	|-RVA: 0x29D3E8C Offset: 0x29CFE8C VA: 0x29D3E8C
	|-EqualityComparer<Int32Enum>.CreateComparer
	|
	|-RVA: 0x29D48DC Offset: 0x29D08DC VA: 0x29D48DC
	|-EqualityComparer<long>.CreateComparer
	|
	|-RVA: 0x29D532C Offset: 0x29D132C VA: 0x29D532C
	|-EqualityComparer<Int64Enum>.CreateComparer
	|
	|-RVA: 0x29D5D7C Offset: 0x29D1D7C VA: 0x29D5D7C
	|-EqualityComparer<IntPtr>.CreateComparer
	|
	|-RVA: 0x29D67CC Offset: 0x29D27CC VA: 0x29D67CC
	|-EqualityComparer<InterpretedFrameInfo>.CreateComparer
	|
	|-RVA: 0x29D723C Offset: 0x29D323C VA: 0x29D723C
	|-EqualityComparer<JsonPosition>.CreateComparer
	|
	|-RVA: 0x29D7D90 Offset: 0x29D3D90 VA: 0x29D7D90
	|-EqualityComparer<MaterialSearchData>.CreateComparer
	|
	|-RVA: 0x29D8800 Offset: 0x29D4800 VA: 0x29D8800
	|-EqualityComparer<MobActionTargetData>.CreateComparer
	|
	|-RVA: 0x29D9354 Offset: 0x29D5354 VA: 0x29D9354
	|-EqualityComparer<MobIconLabelData>.CreateComparer
	|
	|-RVA: 0x29D9EA8 Offset: 0x29D5EA8 VA: 0x29D9EA8
	|-EqualityComparer<object>.CreateComparer
	|
	|-RVA: 0x29DA8FC Offset: 0x29D68FC VA: 0x29DA8FC
	|-EqualityComparer<PlayerLoopSystem>.CreateComparer
	|
	|-RVA: 0x29DB45C Offset: 0x29D745C VA: 0x29DB45C
	|-EqualityComparer<PlayerLoopSystemInternal>.CreateComparer
	|
	|-RVA: 0x29DBFBC Offset: 0x29D7FBC VA: 0x29DBFBC
	|-EqualityComparer<RangePositionInfo>.CreateComparer
	|
	|-RVA: 0x29DCA2C Offset: 0x29D8A2C VA: 0x29DCA2C
	|-EqualityComparer<ReinforceCristaData>.CreateComparer
	|
	|-RVA: 0x29DD4B8 Offset: 0x29D94B8 VA: 0x29DD4B8
	|-EqualityComparer<RenderInstancedDataLayout>.CreateComparer
	|
	|-RVA: 0x29DDF28 Offset: 0x29D9F28 VA: 0x29DDF28
	|-EqualityComparer<ResourceLocator>.CreateComparer
	|
	|-RVA: 0x29DE998 Offset: 0x29DA998 VA: 0x29DE998
	|-EqualityComparer<sbyte>.CreateComparer
	|
	|-RVA: 0x29DF3E8 Offset: 0x29DB3E8 VA: 0x29DF3E8
	|-EqualityComparer<float>.CreateComparer
	|
	|-RVA: 0x29DFE4C Offset: 0x29DBE4C VA: 0x29DFE4C
	|-EqualityComparer<SkillIdData>.CreateComparer
	|
	|-RVA: 0x29E089C Offset: 0x29DC89C VA: 0x29E089C
	|-EqualityComparer<TimeSpan>.CreateComparer
	|
	|-RVA: 0x29E12EC Offset: 0x29DD2EC VA: 0x29E12EC
	|-EqualityComparer<ushort>.CreateComparer
	|
	|-RVA: 0x29E1D3C Offset: 0x29DDD3C VA: 0x29E1D3C
	|-EqualityComparer<uint>.CreateComparer
	|
	|-RVA: 0x29E278C Offset: 0x29DE78C VA: 0x29E278C
	|-EqualityComparer<ulong>.CreateComparer
	|
	|-RVA: 0x29E31DC Offset: 0x29DF1DC VA: 0x29E31DC
	|-EqualityComparer<Vector2>.CreateComparer
	|
	|-RVA: 0x29E3C58 Offset: 0x29DFC58 VA: 0x29E3C58
	|-EqualityComparer<Vector3>.CreateComparer
	|
	|-RVA: 0x29E4720 Offset: 0x29E0720 VA: 0x29E4720
	|-EqualityComparer<Vector4>.CreateComparer
	|
	|-RVA: 0x29E51F4 Offset: 0x29E11F4 VA: 0x29E51F4
	|-EqualityComparer<X509ChainStatus>.CreateComparer
	|
	|-RVA: 0x29E5C64 Offset: 0x29E1C64 VA: 0x29E5C64
	|-EqualityComparer<XPathNodeRef>.CreateComparer
	|
	|-RVA: 0x29E670C Offset: 0x29E270C VA: 0x29E670C
	|-EqualityComparer<__Il2CppFullySharedGenericType>.CreateComparer
	|
	|-RVA: 0x29E7428 Offset: 0x29E3428 VA: 0x29E7428
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.CreateComparer
	|
	|-RVA: 0x29E7E98 Offset: 0x29E3E98 VA: 0x29E7E98
	|-EqualityComparer<BoneClip.MotionKeyFrame>.CreateComparer
	|
	|-RVA: 0x29E89EC Offset: 0x29E49EC VA: 0x29E89EC
	|-EqualityComparer<DeathReceptionAction.PoisonTargetData>.CreateComparer
	|
	|-RVA: 0x29E945C Offset: 0x29E545C VA: 0x29E945C
	|-EqualityComparer<HouseRecipeManager.RecipeData>.CreateComparer
	|
	|-RVA: 0x29E9FBC Offset: 0x29E5FBC VA: 0x29E9FBC
	|-EqualityComparer<KadarElexioBuf.SkillIdData>.CreateComparer
	|
	|-RVA: 0x29EAA0C Offset: 0x29E6A0C VA: 0x29EAA0C
	|-EqualityComparer<MasterModelDataManager.ColorListData>.CreateComparer
	|
	|-RVA: 0x29EB550 Offset: 0x29E7550 VA: 0x29EB550
	|-EqualityComparer<MasterModelDataManager.ConvertCommonMaterialData>.CreateComparer
	|
	|-RVA: 0x29EBFA0 Offset: 0x29E7FA0 VA: 0x29EBFA0
	|-EqualityComparer<MaterialManager.pair>.CreateComparer
	|
	|-RVA: 0x29EC9F0 Offset: 0x29E89F0 VA: 0x29EC9F0
	|-EqualityComparer<MissionTextManagerData.CheckIKeywordtemData>.CreateComparer
	|
	|-RVA: 0x29ED47C Offset: 0x29E947C VA: 0x29ED47C
	|-EqualityComparer<MissionTextManagerData.PickUpFieldData>.CreateComparer
	|
	|-RVA: 0x29EDF08 Offset: 0x29E9F08 VA: 0x29EDF08
	|-EqualityComparer<MobaRoomData.MobaAbilityMasterData>.CreateComparer
	|
	|-RVA: 0x29EE978 Offset: 0x29EA978 VA: 0x29EE978
	|-EqualityComparer<NewWaveRoomData.Spotlight>.CreateComparer
	|
	|-RVA: 0x29EF45C Offset: 0x29EB45C VA: 0x29EF45C
	|-EqualityComparer<NguiDynamicFontController.ApplyTextureInfo>.CreateComparer
	|
	|-RVA: 0x29EFECC Offset: 0x29EBECC VA: 0x29EFECC
	|-EqualityComparer<Regex.CachedCodeEntryKey>.CreateComparer
	|
	|-RVA: 0x29F0A20 Offset: 0x29ECA20 VA: 0x29F0A20
	|-EqualityComparer<RegexCharClass.SingleRange>.CreateComparer
	|
	|-RVA: 0x29F1470 Offset: 0x29ED470 VA: 0x29F1470
	|-EqualityComparer<SocialAchievementData.LinkData>.CreateComparer
	|
	|-RVA: 0x29F1EE0 Offset: 0x29EDEE0 VA: 0x29F1EE0
	|-EqualityComparer<TrophyManager.TrophyData>.CreateComparer
	|
	|-RVA: 0x29F2930 Offset: 0x29EE930 VA: 0x29F2930
	|-EqualityComparer<UIEventMenuButton.MessageButtonData>.CreateComparer
	|
	|-RVA: 0x29F3474 Offset: 0x29EF474 VA: 0x29F3474
	|-EqualityComparer<UIFieldMapPanel.PopData>.CreateComparer
	|
	|-RVA: 0x29F3F58 Offset: 0x29EFF58 VA: 0x29F3F58
	|-EqualityComparer<UIGuildQuestBoardManager.GuildQuestMaseter>.CreateComparer
	|
	|-RVA: 0x29F4ABC Offset: 0x29F0ABC VA: 0x29F4ABC
	|-EqualityComparer<UIHouseAddressManager.Town>.CreateComparer
	|
	|-RVA: 0x29F550C Offset: 0x29F150C VA: 0x29F550C
	|-EqualityComparer<UIInfoWindow.LabelPosition>.CreateComparer
	|
	|-RVA: 0x29F5FF0 Offset: 0x29F1FF0 VA: 0x29F5FF0
	|-EqualityComparer<UIMainManager.DropItemData>.CreateComparer
	|
	|-RVA: 0x29F6A40 Offset: 0x29F2A40 VA: 0x29F6A40
	|-EqualityComparer<UIScenarioOrderPanel.MissionData>.CreateComparer
	|
	|-RVA: 0x29F74B0 Offset: 0x29F34B0 VA: 0x29F74B0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.CreateComparer
	|
	|-RVA: 0x29F8004 Offset: 0x29F4004 VA: 0x29F8004
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.CreateComparer
	|
	|-RVA: 0x29F8A74 Offset: 0x29F4A74 VA: 0x29F8A74
	|-EqualityComparer<BounceParabolaAttackPattern.TargetData.BoundLineData>.CreateComparer
	|
	|-RVA: 0x29F9558 Offset: 0x29F5558 VA: 0x29F9558
	|-EqualityComparer<InstructionList.DebugView.InstructionView>.CreateComparer
	|
	|-RVA: 0x29FA03C Offset: 0x29F603C VA: 0x29FA03C
	|-EqualityComparer<PartyManager.PartyData.pair>.CreateComparer
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Equals(T x, T y);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int GetHashCode(T obj);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	internal virtual int IndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29B35BC Offset: 0x29AF5BC VA: 0x29B35BC
	|-EqualityComparer<KeyValuePair<ArchetypeUid, object>>.IndexOf
	|
	|-RVA: 0x29B402C Offset: 0x29B002C VA: 0x29B402C
	|-EqualityComparer<KeyValuePair<byte, BlackKnightCristaProperty>>.IndexOf
	|
	|-RVA: 0x29B4A7C Offset: 0x29B0A7C VA: 0x29B4A7C
	|-EqualityComparer<KeyValuePair<byte, byte>>.IndexOf
	|
	|-RVA: 0x29B54CC Offset: 0x29B14CC VA: 0x29B54CC
	|-EqualityComparer<KeyValuePair<byte, object>>.IndexOf
	|
	|-RVA: 0x29B5F3C Offset: 0x29B1F3C VA: 0x29B5F3C
	|-EqualityComparer<KeyValuePair<short, short>>.IndexOf
	|
	|-RVA: 0x29B698C Offset: 0x29B298C VA: 0x29B698C
	|-EqualityComparer<KeyValuePair<int, short>>.IndexOf
	|
	|-RVA: 0x29B73DC Offset: 0x29B33DC VA: 0x29B73DC
	|-EqualityComparer<KeyValuePair<int, int>>.IndexOf
	|
	|-RVA: 0x29B7E2C Offset: 0x29B3E2C VA: 0x29B7E2C
	|-EqualityComparer<KeyValuePair<int, object>>.IndexOf
	|
	|-RVA: 0x29B889C Offset: 0x29B489C VA: 0x29B889C
	|-EqualityComparer<KeyValuePair<Int32Enum, byte>>.IndexOf
	|
	|-RVA: 0x29B92EC Offset: 0x29B52EC VA: 0x29B92EC
	|-EqualityComparer<KeyValuePair<Int32Enum, EnhanceProperties2>>.IndexOf
	|
	|-RVA: 0x29B9E50 Offset: 0x29B5E50 VA: 0x29B9E50
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x29BA8A0 Offset: 0x29B68A0 VA: 0x29BA8A0
	|-EqualityComparer<KeyValuePair<Int32Enum, object>>.IndexOf
	|
	|-RVA: 0x29BB310 Offset: 0x29B7310 VA: 0x29BB310
	|-EqualityComparer<KeyValuePair<object, int>>.IndexOf
	|
	|-RVA: 0x29BBD80 Offset: 0x29B7D80 VA: 0x29BBD80
	|-EqualityComparer<KeyValuePair<object, object>>.IndexOf
	|
	|-RVA: 0x29BC7F0 Offset: 0x29B87F0 VA: 0x29BC7F0
	|-EqualityComparer<KeyValuePair<object, float>>.IndexOf
	|
	|-RVA: 0x29BD530 Offset: 0x29B9530 VA: 0x29BD530
	|-EqualityComparer<KeyValuePair<float, object>>.IndexOf
	|
	|-RVA: 0x29BDFA0 Offset: 0x29B9FA0 VA: 0x29BDFA0
	|-EqualityComparer<Nullable<UIMobPropertyLabel.IconValue>>.IndexOf
	|
	|-RVA: 0x29BEAAC Offset: 0x29BAAAC VA: 0x29BEAAC
	|-EqualityComparer<StructMultiKey<object, object>>.IndexOf
	|
	|-RVA: 0x29BF51C Offset: 0x29BB51C VA: 0x29BF51C
	|-EqualityComparer<ValueTuple<bool>>.IndexOf
	|
	|-RVA: 0x29BFF6C Offset: 0x29BBF6C VA: 0x29BFF6C
	|-EqualityComparer<ValueTuple<short, short>>.IndexOf
	|
	|-RVA: 0x29C09BC Offset: 0x29BC9BC VA: 0x29C09BC
	|-EqualityComparer<ValueTuple<int, int>>.IndexOf
	|
	|-RVA: 0x29C140C Offset: 0x29BD40C VA: 0x29C140C
	|-EqualityComparer<ValueTuple<int, object>>.IndexOf
	|
	|-RVA: 0x29C1E7C Offset: 0x29BDE7C VA: 0x29C1E7C
	|-EqualityComparer<ValueTuple<Int32Enum, float>>.IndexOf
	|
	|-RVA: 0x29C28CC Offset: 0x29BE8CC VA: 0x29C28CC
	|-EqualityComparer<ValueTuple<object, byte>>.IndexOf
	|
	|-RVA: 0x29C333C Offset: 0x29BF33C VA: 0x29C333C
	|-EqualityComparer<ValueTuple<object, object>>.IndexOf
	|
	|-RVA: 0x29C3DAC Offset: 0x29BFDAC VA: 0x29C3DAC
	|-EqualityComparer<ValueTuple<float, object>>.IndexOf
	|
	|-RVA: 0x29C481C Offset: 0x29C081C VA: 0x29C481C
	|-EqualityComparer<ValueTuple<Vector3, Vector3>>.IndexOf
	|
	|-RVA: 0x29C5370 Offset: 0x29C1370 VA: 0x29C5370
	|-EqualityComparer<ValueTuple<short, int, int>>.IndexOf
	|
	|-RVA: 0x29C5DFC Offset: 0x29C1DFC VA: 0x29C5DFC
	|-EqualityComparer<ValueTuple<object, object, object>>.IndexOf
	|
	|-RVA: 0x29C6950 Offset: 0x29C2950 VA: 0x29C6950
	|-EqualityComparer<ArchetypeUid>.IndexOf
	|
	|-RVA: 0x29C73A0 Offset: 0x29C33A0 VA: 0x29C73A0
	|-EqualityComparer<BlackKnightAvatarProperty>.IndexOf
	|
	|-RVA: 0x29C7E2C Offset: 0x29C3E2C VA: 0x29C7E2C
	|-EqualityComparer<BlackKnightCristaProperty>.IndexOf
	|
	|-RVA: 0x29C88BC Offset: 0x29C48BC VA: 0x29C88BC
	|-EqualityComparer<bool>.IndexOf
	|
	|-RVA: 0x29C931C Offset: 0x29C531C VA: 0x29C931C
	|-EqualityComparer<byte>.IndexOf
	|
	|-RVA: 0x29C9D6C Offset: 0x29C5D6C VA: 0x29C9D6C
	|-EqualityComparer<ByteEnum>.IndexOf
	|
	|-RVA: 0x29CA7BC Offset: 0x29C67BC VA: 0x29CA7BC
	|-EqualityComparer<CardData>.IndexOf
	|
	|-RVA: 0x29CB248 Offset: 0x29C7248 VA: 0x29CB248
	|-EqualityComparer<char>.IndexOf
	|
	|-RVA: 0x29CBC98 Offset: 0x29C7C98 VA: 0x29CBC98
	|-EqualityComparer<Color>.IndexOf
	|
	|-RVA: 0x29CC76C Offset: 0x29C876C VA: 0x29CC76C
	|-EqualityComparer<Color32>.IndexOf
	|
	|-RVA: 0x29CD1BC Offset: 0x29C91BC VA: 0x29CD1BC
	|-EqualityComparer<DateTime>.IndexOf
	|
	|-RVA: 0x29CDC0C Offset: 0x29C9C0C VA: 0x29CDC0C
	|-EqualityComparer<DateTimeOffset>.IndexOf
	|
	|-RVA: 0x29CE67C Offset: 0x29CA67C VA: 0x29CE67C
	|-EqualityComparer<Decimal>.IndexOf
	|
	|-RVA: 0x29CF0EC Offset: 0x29CB0EC VA: 0x29CF0EC
	|-EqualityComparer<DefencePoint2>.IndexOf
	|
	|-RVA: 0x29CFB3C Offset: 0x29CBB3C VA: 0x29CFB3C
	|-EqualityComparer<double>.IndexOf
	|
	|-RVA: 0x29D05A0 Offset: 0x29CC5A0 VA: 0x29D05A0
	|-EqualityComparer<EnhanceProperties2>.IndexOf
	|
	|-RVA: 0x29D1100 Offset: 0x29CD100 VA: 0x29D1100
	|-EqualityComparer<EventSummary>.IndexOf
	|
	|-RVA: 0x29D1B70 Offset: 0x29CDB70 VA: 0x29D1B70
	|-EqualityComparer<Guid>.IndexOf
	|
	|-RVA: 0x29D25E0 Offset: 0x29CE5E0 VA: 0x29D25E0
	|-EqualityComparer<short>.IndexOf
	|
	|-RVA: 0x29D3030 Offset: 0x29CF030 VA: 0x29D3030
	|-EqualityComparer<Int16Enum>.IndexOf
	|
	|-RVA: 0x29D3A80 Offset: 0x29CFA80 VA: 0x29D3A80
	|-EqualityComparer<int>.IndexOf
	|
	|-RVA: 0x29D44D0 Offset: 0x29D04D0 VA: 0x29D44D0
	|-EqualityComparer<Int32Enum>.IndexOf
	|
	|-RVA: 0x29D4F20 Offset: 0x29D0F20 VA: 0x29D4F20
	|-EqualityComparer<long>.IndexOf
	|
	|-RVA: 0x29D5970 Offset: 0x29D1970 VA: 0x29D5970
	|-EqualityComparer<Int64Enum>.IndexOf
	|
	|-RVA: 0x29D63C0 Offset: 0x29D23C0 VA: 0x29D63C0
	|-EqualityComparer<IntPtr>.IndexOf
	|
	|-RVA: 0x29D6E10 Offset: 0x29D2E10 VA: 0x29D6E10
	|-EqualityComparer<InterpretedFrameInfo>.IndexOf
	|
	|-RVA: 0x29D7880 Offset: 0x29D3880 VA: 0x29D7880
	|-EqualityComparer<JsonPosition>.IndexOf
	|
	|-RVA: 0x29D83D4 Offset: 0x29D43D4 VA: 0x29D83D4
	|-EqualityComparer<MaterialSearchData>.IndexOf
	|
	|-RVA: 0x29D8E44 Offset: 0x29D4E44 VA: 0x29D8E44
	|-EqualityComparer<MobActionTargetData>.IndexOf
	|
	|-RVA: 0x29D9998 Offset: 0x29D5998 VA: 0x29D9998
	|-EqualityComparer<MobIconLabelData>.IndexOf
	|
	|-RVA: 0x29DA4EC Offset: 0x29D64EC VA: 0x29DA4EC
	|-EqualityComparer<object>.IndexOf
	|
	|-RVA: 0x29DAF40 Offset: 0x29D6F40 VA: 0x29DAF40
	|-EqualityComparer<PlayerLoopSystem>.IndexOf
	|
	|-RVA: 0x29DBAA0 Offset: 0x29D7AA0 VA: 0x29DBAA0
	|-EqualityComparer<PlayerLoopSystemInternal>.IndexOf
	|
	|-RVA: 0x29DC600 Offset: 0x29D8600 VA: 0x29DC600
	|-EqualityComparer<RangePositionInfo>.IndexOf
	|
	|-RVA: 0x29DD070 Offset: 0x29D9070 VA: 0x29DD070
	|-EqualityComparer<ReinforceCristaData>.IndexOf
	|
	|-RVA: 0x29DDAFC Offset: 0x29D9AFC VA: 0x29DDAFC
	|-EqualityComparer<RenderInstancedDataLayout>.IndexOf
	|
	|-RVA: 0x29DE56C Offset: 0x29DA56C VA: 0x29DE56C
	|-EqualityComparer<ResourceLocator>.IndexOf
	|
	|-RVA: 0x29DEFDC Offset: 0x29DAFDC VA: 0x29DEFDC
	|-EqualityComparer<sbyte>.IndexOf
	|
	|-RVA: 0x29DFA2C Offset: 0x29DBA2C VA: 0x29DFA2C
	|-EqualityComparer<float>.IndexOf
	|
	|-RVA: 0x29E0490 Offset: 0x29DC490 VA: 0x29E0490
	|-EqualityComparer<SkillIdData>.IndexOf
	|
	|-RVA: 0x29E0EE0 Offset: 0x29DCEE0 VA: 0x29E0EE0
	|-EqualityComparer<TimeSpan>.IndexOf
	|
	|-RVA: 0x29E1930 Offset: 0x29DD930 VA: 0x29E1930
	|-EqualityComparer<ushort>.IndexOf
	|
	|-RVA: 0x29E2380 Offset: 0x29DE380 VA: 0x29E2380
	|-EqualityComparer<uint>.IndexOf
	|
	|-RVA: 0x29E2DD0 Offset: 0x29DEDD0 VA: 0x29E2DD0
	|-EqualityComparer<ulong>.IndexOf
	|
	|-RVA: 0x29E3820 Offset: 0x29DF820 VA: 0x29E3820
	|-EqualityComparer<Vector2>.IndexOf
	|
	|-RVA: 0x29E429C Offset: 0x29E029C VA: 0x29E429C
	|-EqualityComparer<Vector3>.IndexOf
	|
	|-RVA: 0x29E4D64 Offset: 0x29E0D64 VA: 0x29E4D64
	|-EqualityComparer<Vector4>.IndexOf
	|
	|-RVA: 0x29E5838 Offset: 0x29E1838 VA: 0x29E5838
	|-EqualityComparer<X509ChainStatus>.IndexOf
	|
	|-RVA: 0x29E62A8 Offset: 0x29E22A8 VA: 0x29E62A8
	|-EqualityComparer<XPathNodeRef>.IndexOf
	|
	|-RVA: 0x29E6D80 Offset: 0x29E2D80 VA: 0x29E6D80
	|-EqualityComparer<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x29E7A6C Offset: 0x29E3A6C VA: 0x29E7A6C
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.IndexOf
	|
	|-RVA: 0x29E84DC Offset: 0x29E44DC VA: 0x29E84DC
	|-EqualityComparer<BoneClip.MotionKeyFrame>.IndexOf
	|
	|-RVA: 0x29E9030 Offset: 0x29E5030 VA: 0x29E9030
	|-EqualityComparer<DeathReceptionAction.PoisonTargetData>.IndexOf
	|
	|-RVA: 0x29E9AA0 Offset: 0x29E5AA0 VA: 0x29E9AA0
	|-EqualityComparer<HouseRecipeManager.RecipeData>.IndexOf
	|
	|-RVA: 0x29EA600 Offset: 0x29E6600 VA: 0x29EA600
	|-EqualityComparer<KadarElexioBuf.SkillIdData>.IndexOf
	|
	|-RVA: 0x29EB050 Offset: 0x29E7050 VA: 0x29EB050
	|-EqualityComparer<MasterModelDataManager.ColorListData>.IndexOf
	|
	|-RVA: 0x29EBB94 Offset: 0x29E7B94 VA: 0x29EBB94
	|-EqualityComparer<MasterModelDataManager.ConvertCommonMaterialData>.IndexOf
	|
	|-RVA: 0x29EC5E4 Offset: 0x29E85E4 VA: 0x29EC5E4
	|-EqualityComparer<MaterialManager.pair>.IndexOf
	|
	|-RVA: 0x29ED034 Offset: 0x29E9034 VA: 0x29ED034
	|-EqualityComparer<MissionTextManagerData.CheckIKeywordtemData>.IndexOf
	|
	|-RVA: 0x29EDAC0 Offset: 0x29E9AC0 VA: 0x29EDAC0
	|-EqualityComparer<MissionTextManagerData.PickUpFieldData>.IndexOf
	|
	|-RVA: 0x29EE54C Offset: 0x29EA54C VA: 0x29EE54C
	|-EqualityComparer<MobaRoomData.MobaAbilityMasterData>.IndexOf
	|
	|-RVA: 0x29EEFBC Offset: 0x29EAFBC VA: 0x29EEFBC
	|-EqualityComparer<NewWaveRoomData.Spotlight>.IndexOf
	|
	|-RVA: 0x29EFAA0 Offset: 0x29EBAA0 VA: 0x29EFAA0
	|-EqualityComparer<NguiDynamicFontController.ApplyTextureInfo>.IndexOf
	|
	|-RVA: 0x29F0510 Offset: 0x29EC510 VA: 0x29F0510
	|-EqualityComparer<Regex.CachedCodeEntryKey>.IndexOf
	|
	|-RVA: 0x29F1064 Offset: 0x29ED064 VA: 0x29F1064
	|-EqualityComparer<RegexCharClass.SingleRange>.IndexOf
	|
	|-RVA: 0x29F1AB4 Offset: 0x29EDAB4 VA: 0x29F1AB4
	|-EqualityComparer<SocialAchievementData.LinkData>.IndexOf
	|
	|-RVA: 0x29F2524 Offset: 0x29EE524 VA: 0x29F2524
	|-EqualityComparer<TrophyManager.TrophyData>.IndexOf
	|
	|-RVA: 0x29F2F74 Offset: 0x29EEF74 VA: 0x29F2F74
	|-EqualityComparer<UIEventMenuButton.MessageButtonData>.IndexOf
	|
	|-RVA: 0x29F3AB8 Offset: 0x29EFAB8 VA: 0x29F3AB8
	|-EqualityComparer<UIFieldMapPanel.PopData>.IndexOf
	|
	|-RVA: 0x29F459C Offset: 0x29F059C VA: 0x29F459C
	|-EqualityComparer<UIGuildQuestBoardManager.GuildQuestMaseter>.IndexOf
	|
	|-RVA: 0x29F5100 Offset: 0x29F1100 VA: 0x29F5100
	|-EqualityComparer<UIHouseAddressManager.Town>.IndexOf
	|
	|-RVA: 0x29F5B50 Offset: 0x29F1B50 VA: 0x29F5B50
	|-EqualityComparer<UIInfoWindow.LabelPosition>.IndexOf
	|
	|-RVA: 0x29F6634 Offset: 0x29F2634 VA: 0x29F6634
	|-EqualityComparer<UIMainManager.DropItemData>.IndexOf
	|
	|-RVA: 0x29F7084 Offset: 0x29F3084 VA: 0x29F7084
	|-EqualityComparer<UIScenarioOrderPanel.MissionData>.IndexOf
	|
	|-RVA: 0x29F7AF4 Offset: 0x29F3AF4 VA: 0x29F7AF4
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.IndexOf
	|
	|-RVA: 0x29F8648 Offset: 0x29F4648 VA: 0x29F8648
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IndexOf
	|
	|-RVA: 0x29F90B8 Offset: 0x29F50B8 VA: 0x29F90B8
	|-EqualityComparer<BounceParabolaAttackPattern.TargetData.BoundLineData>.IndexOf
	|
	|-RVA: 0x29F9B9C Offset: 0x29F5B9C VA: 0x29F9B9C
	|-EqualityComparer<InstructionList.DebugView.InstructionView>.IndexOf
	|
	|-RVA: 0x29FA680 Offset: 0x29F6680 VA: 0x29FA680
	|-EqualityComparer<PartyManager.PartyData.pair>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29B3660 Offset: 0x29AF660 VA: 0x29B3660
	|-EqualityComparer<KeyValuePair<ArchetypeUid, object>>.LastIndexOf
	|
	|-RVA: 0x29B40C8 Offset: 0x29B00C8 VA: 0x29B40C8
	|-EqualityComparer<KeyValuePair<byte, BlackKnightCristaProperty>>.LastIndexOf
	|
	|-RVA: 0x29B4B18 Offset: 0x29B0B18 VA: 0x29B4B18
	|-EqualityComparer<KeyValuePair<byte, byte>>.LastIndexOf
	|
	|-RVA: 0x29B5570 Offset: 0x29B1570 VA: 0x29B5570
	|-EqualityComparer<KeyValuePair<byte, object>>.LastIndexOf
	|
	|-RVA: 0x29B5FD8 Offset: 0x29B1FD8 VA: 0x29B5FD8
	|-EqualityComparer<KeyValuePair<short, short>>.LastIndexOf
	|
	|-RVA: 0x29B6A28 Offset: 0x29B2A28 VA: 0x29B6A28
	|-EqualityComparer<KeyValuePair<int, short>>.LastIndexOf
	|
	|-RVA: 0x29B7478 Offset: 0x29B3478 VA: 0x29B7478
	|-EqualityComparer<KeyValuePair<int, int>>.LastIndexOf
	|
	|-RVA: 0x29B7ED0 Offset: 0x29B3ED0 VA: 0x29B7ED0
	|-EqualityComparer<KeyValuePair<int, object>>.LastIndexOf
	|
	|-RVA: 0x29B8938 Offset: 0x29B4938 VA: 0x29B8938
	|-EqualityComparer<KeyValuePair<Int32Enum, byte>>.LastIndexOf
	|
	|-RVA: 0x29B93D8 Offset: 0x29B53D8 VA: 0x29B93D8
	|-EqualityComparer<KeyValuePair<Int32Enum, EnhanceProperties2>>.LastIndexOf
	|
	|-RVA: 0x29B9EEC Offset: 0x29B5EEC VA: 0x29B9EEC
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x29BA944 Offset: 0x29B6944 VA: 0x29BA944
	|-EqualityComparer<KeyValuePair<Int32Enum, object>>.LastIndexOf
	|
	|-RVA: 0x29BB3B4 Offset: 0x29B73B4 VA: 0x29BB3B4
	|-EqualityComparer<KeyValuePair<object, int>>.LastIndexOf
	|
	|-RVA: 0x29BBE24 Offset: 0x29B7E24 VA: 0x29BBE24
	|-EqualityComparer<KeyValuePair<object, object>>.LastIndexOf
	|
	|-RVA: 0x29BC894 Offset: 0x29B8894 VA: 0x29BC894
	|-EqualityComparer<KeyValuePair<object, float>>.LastIndexOf
	|
	|-RVA: 0x29BD5D4 Offset: 0x29B95D4 VA: 0x29BD5D4
	|-EqualityComparer<KeyValuePair<float, object>>.LastIndexOf
	|
	|-RVA: 0x29BE068 Offset: 0x29BA068 VA: 0x29BE068
	|-EqualityComparer<Nullable<UIMobPropertyLabel.IconValue>>.LastIndexOf
	|
	|-RVA: 0x29BEB50 Offset: 0x29BAB50 VA: 0x29BEB50
	|-EqualityComparer<StructMultiKey<object, object>>.LastIndexOf
	|
	|-RVA: 0x29BF5B8 Offset: 0x29BB5B8 VA: 0x29BF5B8
	|-EqualityComparer<ValueTuple<bool>>.LastIndexOf
	|
	|-RVA: 0x29C0008 Offset: 0x29BC008 VA: 0x29C0008
	|-EqualityComparer<ValueTuple<short, short>>.LastIndexOf
	|
	|-RVA: 0x29C0A58 Offset: 0x29BCA58 VA: 0x29C0A58
	|-EqualityComparer<ValueTuple<int, int>>.LastIndexOf
	|
	|-RVA: 0x29C14B0 Offset: 0x29BD4B0 VA: 0x29C14B0
	|-EqualityComparer<ValueTuple<int, object>>.LastIndexOf
	|
	|-RVA: 0x29C1F18 Offset: 0x29BDF18 VA: 0x29C1F18
	|-EqualityComparer<ValueTuple<Int32Enum, float>>.LastIndexOf
	|
	|-RVA: 0x29C2970 Offset: 0x29BE970 VA: 0x29C2970
	|-EqualityComparer<ValueTuple<object, byte>>.LastIndexOf
	|
	|-RVA: 0x29C33E0 Offset: 0x29BF3E0 VA: 0x29C33E0
	|-EqualityComparer<ValueTuple<object, object>>.LastIndexOf
	|
	|-RVA: 0x29C3E50 Offset: 0x29BFE50 VA: 0x29C3E50
	|-EqualityComparer<ValueTuple<float, object>>.LastIndexOf
	|
	|-RVA: 0x29C4900 Offset: 0x29C0900 VA: 0x29C4900
	|-EqualityComparer<ValueTuple<Vector3, Vector3>>.LastIndexOf
	|
	|-RVA: 0x29C541C Offset: 0x29C141C VA: 0x29C541C
	|-EqualityComparer<ValueTuple<short, int, int>>.LastIndexOf
	|
	|-RVA: 0x29C5EE0 Offset: 0x29C1EE0 VA: 0x29C5EE0
	|-EqualityComparer<ValueTuple<object, object, object>>.LastIndexOf
	|
	|-RVA: 0x29C69EC Offset: 0x29C29EC VA: 0x29C69EC
	|-EqualityComparer<ArchetypeUid>.LastIndexOf
	|
	|-RVA: 0x29C744C Offset: 0x29C344C VA: 0x29C744C
	|-EqualityComparer<BlackKnightAvatarProperty>.LastIndexOf
	|
	|-RVA: 0x29C7ED8 Offset: 0x29C3ED8 VA: 0x29C7ED8
	|-EqualityComparer<BlackKnightCristaProperty>.LastIndexOf
	|
	|-RVA: 0x29C8958 Offset: 0x29C4958 VA: 0x29C8958
	|-EqualityComparer<bool>.LastIndexOf
	|
	|-RVA: 0x29C93B8 Offset: 0x29C53B8 VA: 0x29C93B8
	|-EqualityComparer<byte>.LastIndexOf
	|
	|-RVA: 0x29C9E08 Offset: 0x29C5E08 VA: 0x29C9E08
	|-EqualityComparer<ByteEnum>.LastIndexOf
	|
	|-RVA: 0x29CA868 Offset: 0x29C6868 VA: 0x29CA868
	|-EqualityComparer<CardData>.LastIndexOf
	|
	|-RVA: 0x29CB2E4 Offset: 0x29C72E4 VA: 0x29CB2E4
	|-EqualityComparer<char>.LastIndexOf
	|
	|-RVA: 0x29CBD58 Offset: 0x29C7D58 VA: 0x29CBD58
	|-EqualityComparer<Color>.LastIndexOf
	|
	|-RVA: 0x29CC808 Offset: 0x29C8808 VA: 0x29CC808
	|-EqualityComparer<Color32>.LastIndexOf
	|
	|-RVA: 0x29CD258 Offset: 0x29C9258 VA: 0x29CD258
	|-EqualityComparer<DateTime>.LastIndexOf
	|
	|-RVA: 0x29CDCB0 Offset: 0x29C9CB0 VA: 0x29CDCB0
	|-EqualityComparer<DateTimeOffset>.LastIndexOf
	|
	|-RVA: 0x29CE720 Offset: 0x29CA720 VA: 0x29CE720
	|-EqualityComparer<Decimal>.LastIndexOf
	|
	|-RVA: 0x29CF188 Offset: 0x29CB188 VA: 0x29CF188
	|-EqualityComparer<DefencePoint2>.LastIndexOf
	|
	|-RVA: 0x29CFBD8 Offset: 0x29CBBD8 VA: 0x29CFBD8
	|-EqualityComparer<double>.LastIndexOf
	|
	|-RVA: 0x29D068C Offset: 0x29CC68C VA: 0x29D068C
	|-EqualityComparer<EnhanceProperties2>.LastIndexOf
	|
	|-RVA: 0x29D11A4 Offset: 0x29CD1A4 VA: 0x29D11A4
	|-EqualityComparer<EventSummary>.LastIndexOf
	|
	|-RVA: 0x29D1C14 Offset: 0x29CDC14 VA: 0x29D1C14
	|-EqualityComparer<Guid>.LastIndexOf
	|
	|-RVA: 0x29D267C Offset: 0x29CE67C VA: 0x29D267C
	|-EqualityComparer<short>.LastIndexOf
	|
	|-RVA: 0x29D30CC Offset: 0x29CF0CC VA: 0x29D30CC
	|-EqualityComparer<Int16Enum>.LastIndexOf
	|
	|-RVA: 0x29D3B1C Offset: 0x29CFB1C VA: 0x29D3B1C
	|-EqualityComparer<int>.LastIndexOf
	|
	|-RVA: 0x29D456C Offset: 0x29D056C VA: 0x29D456C
	|-EqualityComparer<Int32Enum>.LastIndexOf
	|
	|-RVA: 0x29D4FBC Offset: 0x29D0FBC VA: 0x29D4FBC
	|-EqualityComparer<long>.LastIndexOf
	|
	|-RVA: 0x29D5A0C Offset: 0x29D1A0C VA: 0x29D5A0C
	|-EqualityComparer<Int64Enum>.LastIndexOf
	|
	|-RVA: 0x29D645C Offset: 0x29D245C VA: 0x29D645C
	|-EqualityComparer<IntPtr>.LastIndexOf
	|
	|-RVA: 0x29D6EB4 Offset: 0x29D2EB4 VA: 0x29D6EB4
	|-EqualityComparer<InterpretedFrameInfo>.LastIndexOf
	|
	|-RVA: 0x29D7964 Offset: 0x29D3964 VA: 0x29D7964
	|-EqualityComparer<JsonPosition>.LastIndexOf
	|
	|-RVA: 0x29D8478 Offset: 0x29D4478 VA: 0x29D8478
	|-EqualityComparer<MaterialSearchData>.LastIndexOf
	|
	|-RVA: 0x29D8F28 Offset: 0x29D4F28 VA: 0x29D8F28
	|-EqualityComparer<MobActionTargetData>.LastIndexOf
	|
	|-RVA: 0x29D9A7C Offset: 0x29D5A7C VA: 0x29D9A7C
	|-EqualityComparer<MobIconLabelData>.LastIndexOf
	|
	|-RVA: 0x29DA588 Offset: 0x29D6588 VA: 0x29DA588
	|-EqualityComparer<object>.LastIndexOf
	|
	|-RVA: 0x29DB02C Offset: 0x29D702C VA: 0x29DB02C
	|-EqualityComparer<PlayerLoopSystem>.LastIndexOf
	|
	|-RVA: 0x29DBB8C Offset: 0x29D7B8C VA: 0x29DBB8C
	|-EqualityComparer<PlayerLoopSystemInternal>.LastIndexOf
	|
	|-RVA: 0x29DC6A4 Offset: 0x29D86A4 VA: 0x29DC6A4
	|-EqualityComparer<RangePositionInfo>.LastIndexOf
	|
	|-RVA: 0x29DD11C Offset: 0x29D911C VA: 0x29DD11C
	|-EqualityComparer<ReinforceCristaData>.LastIndexOf
	|
	|-RVA: 0x29DDBA0 Offset: 0x29D9BA0 VA: 0x29DDBA0
	|-EqualityComparer<RenderInstancedDataLayout>.LastIndexOf
	|
	|-RVA: 0x29DE610 Offset: 0x29DA610 VA: 0x29DE610
	|-EqualityComparer<ResourceLocator>.LastIndexOf
	|
	|-RVA: 0x29DF078 Offset: 0x29DB078 VA: 0x29DF078
	|-EqualityComparer<sbyte>.LastIndexOf
	|
	|-RVA: 0x29DFAC8 Offset: 0x29DBAC8 VA: 0x29DFAC8
	|-EqualityComparer<float>.LastIndexOf
	|
	|-RVA: 0x29E052C Offset: 0x29DC52C VA: 0x29E052C
	|-EqualityComparer<SkillIdData>.LastIndexOf
	|
	|-RVA: 0x29E0F7C Offset: 0x29DCF7C VA: 0x29E0F7C
	|-EqualityComparer<TimeSpan>.LastIndexOf
	|
	|-RVA: 0x29E19CC Offset: 0x29DD9CC VA: 0x29E19CC
	|-EqualityComparer<ushort>.LastIndexOf
	|
	|-RVA: 0x29E241C Offset: 0x29DE41C VA: 0x29E241C
	|-EqualityComparer<uint>.LastIndexOf
	|
	|-RVA: 0x29E2E6C Offset: 0x29DEE6C VA: 0x29E2E6C
	|-EqualityComparer<ulong>.LastIndexOf
	|
	|-RVA: 0x29E38C4 Offset: 0x29DF8C4 VA: 0x29E38C4
	|-EqualityComparer<Vector2>.LastIndexOf
	|
	|-RVA: 0x29E4358 Offset: 0x29E0358 VA: 0x29E4358
	|-EqualityComparer<Vector3>.LastIndexOf
	|
	|-RVA: 0x29E4E24 Offset: 0x29E0E24 VA: 0x29E4E24
	|-EqualityComparer<Vector4>.LastIndexOf
	|
	|-RVA: 0x29E58DC Offset: 0x29E18DC VA: 0x29E58DC
	|-EqualityComparer<X509ChainStatus>.LastIndexOf
	|
	|-RVA: 0x29E634C Offset: 0x29E234C VA: 0x29E634C
	|-EqualityComparer<XPathNodeRef>.LastIndexOf
	|
	|-RVA: 0x29E6EF8 Offset: 0x29E2EF8 VA: 0x29E6EF8
	|-EqualityComparer<__Il2CppFullySharedGenericType>.LastIndexOf
	|
	|-RVA: 0x29E7B10 Offset: 0x29E3B10 VA: 0x29E7B10
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.LastIndexOf
	|
	|-RVA: 0x29E85C0 Offset: 0x29E45C0 VA: 0x29E85C0
	|-EqualityComparer<BoneClip.MotionKeyFrame>.LastIndexOf
	|
	|-RVA: 0x29E90D4 Offset: 0x29E50D4 VA: 0x29E90D4
	|-EqualityComparer<DeathReceptionAction.PoisonTargetData>.LastIndexOf
	|
	|-RVA: 0x29E9B8C Offset: 0x29E5B8C VA: 0x29E9B8C
	|-EqualityComparer<HouseRecipeManager.RecipeData>.LastIndexOf
	|
	|-RVA: 0x29EA69C Offset: 0x29E669C VA: 0x29EA69C
	|-EqualityComparer<KadarElexioBuf.SkillIdData>.LastIndexOf
	|
	|-RVA: 0x29EB130 Offset: 0x29E7130 VA: 0x29EB130
	|-EqualityComparer<MasterModelDataManager.ColorListData>.LastIndexOf
	|
	|-RVA: 0x29EBC30 Offset: 0x29E7C30 VA: 0x29EBC30
	|-EqualityComparer<MasterModelDataManager.ConvertCommonMaterialData>.LastIndexOf
	|
	|-RVA: 0x29EC680 Offset: 0x29E8680 VA: 0x29EC680
	|-EqualityComparer<MaterialManager.pair>.LastIndexOf
	|
	|-RVA: 0x29ED0E0 Offset: 0x29E90E0 VA: 0x29ED0E0
	|-EqualityComparer<MissionTextManagerData.CheckIKeywordtemData>.LastIndexOf
	|
	|-RVA: 0x29EDB6C Offset: 0x29E9B6C VA: 0x29EDB6C
	|-EqualityComparer<MissionTextManagerData.PickUpFieldData>.LastIndexOf
	|
	|-RVA: 0x29EE5F0 Offset: 0x29EA5F0 VA: 0x29EE5F0
	|-EqualityComparer<MobaRoomData.MobaAbilityMasterData>.LastIndexOf
	|
	|-RVA: 0x29EF084 Offset: 0x29EB084 VA: 0x29EF084
	|-EqualityComparer<NewWaveRoomData.Spotlight>.LastIndexOf
	|
	|-RVA: 0x29EFB44 Offset: 0x29EBB44 VA: 0x29EFB44
	|-EqualityComparer<NguiDynamicFontController.ApplyTextureInfo>.LastIndexOf
	|
	|-RVA: 0x29F05F4 Offset: 0x29EC5F4 VA: 0x29F05F4
	|-EqualityComparer<Regex.CachedCodeEntryKey>.LastIndexOf
	|
	|-RVA: 0x29F1100 Offset: 0x29ED100 VA: 0x29F1100
	|-EqualityComparer<RegexCharClass.SingleRange>.LastIndexOf
	|
	|-RVA: 0x29F1B58 Offset: 0x29EDB58 VA: 0x29F1B58
	|-EqualityComparer<SocialAchievementData.LinkData>.LastIndexOf
	|
	|-RVA: 0x29F25C0 Offset: 0x29EE5C0 VA: 0x29F25C0
	|-EqualityComparer<TrophyManager.TrophyData>.LastIndexOf
	|
	|-RVA: 0x29F3054 Offset: 0x29EF054 VA: 0x29F3054
	|-EqualityComparer<UIEventMenuButton.MessageButtonData>.LastIndexOf
	|
	|-RVA: 0x29F3B80 Offset: 0x29EFB80 VA: 0x29F3B80
	|-EqualityComparer<UIFieldMapPanel.PopData>.LastIndexOf
	|
	|-RVA: 0x29F4688 Offset: 0x29F0688 VA: 0x29F4688
	|-EqualityComparer<UIGuildQuestBoardManager.GuildQuestMaseter>.LastIndexOf
	|
	|-RVA: 0x29F519C Offset: 0x29F119C VA: 0x29F519C
	|-EqualityComparer<UIHouseAddressManager.Town>.LastIndexOf
	|
	|-RVA: 0x29F5C18 Offset: 0x29F1C18 VA: 0x29F5C18
	|-EqualityComparer<UIInfoWindow.LabelPosition>.LastIndexOf
	|
	|-RVA: 0x29F66D0 Offset: 0x29F26D0 VA: 0x29F66D0
	|-EqualityComparer<UIMainManager.DropItemData>.LastIndexOf
	|
	|-RVA: 0x29F7128 Offset: 0x29F3128 VA: 0x29F7128
	|-EqualityComparer<UIScenarioOrderPanel.MissionData>.LastIndexOf
	|
	|-RVA: 0x29F7BD8 Offset: 0x29F3BD8 VA: 0x29F7BD8
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.LastIndexOf
	|
	|-RVA: 0x29F86EC Offset: 0x29F46EC VA: 0x29F86EC
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.LastIndexOf
	|
	|-RVA: 0x29F9180 Offset: 0x29F5180 VA: 0x29F9180
	|-EqualityComparer<BounceParabolaAttackPattern.TargetData.BoundLineData>.LastIndexOf
	|
	|-RVA: 0x29F9C64 Offset: 0x29F5C64 VA: 0x29F9C64
	|-EqualityComparer<InstructionList.DebugView.InstructionView>.LastIndexOf
	|
	|-RVA: 0x29FA71C Offset: 0x29F671C VA: 0x29FA71C
	|-EqualityComparer<PartyManager.PartyData.pair>.LastIndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29B36FC Offset: 0x29AF6FC VA: 0x29B36FC
	|-EqualityComparer<KeyValuePair<ArchetypeUid, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29B4150 Offset: 0x29B0150 VA: 0x29B4150
	|-EqualityComparer<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29B4BA0 Offset: 0x29B0BA0 VA: 0x29B4BA0
	|-EqualityComparer<KeyValuePair<byte, byte>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29B560C Offset: 0x29B160C VA: 0x29B560C
	|-EqualityComparer<KeyValuePair<byte, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29B6060 Offset: 0x29B2060 VA: 0x29B6060
	|-EqualityComparer<KeyValuePair<short, short>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29B6AB0 Offset: 0x29B2AB0 VA: 0x29B6AB0
	|-EqualityComparer<KeyValuePair<int, short>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29B7500 Offset: 0x29B3500 VA: 0x29B7500
	|-EqualityComparer<KeyValuePair<int, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29B7F6C Offset: 0x29B3F6C VA: 0x29B7F6C
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29B89C0 Offset: 0x29B49C0 VA: 0x29B89C0
	|-EqualityComparer<KeyValuePair<Int32Enum, byte>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29B94B8 Offset: 0x29B54B8 VA: 0x29B94B8
	|-EqualityComparer<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29B9F74 Offset: 0x29B5F74 VA: 0x29B9F74
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29BA9E0 Offset: 0x29B69E0 VA: 0x29BA9E0
	|-EqualityComparer<KeyValuePair<Int32Enum, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29BB450 Offset: 0x29B7450 VA: 0x29BB450
	|-EqualityComparer<KeyValuePair<object, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29BBEC0 Offset: 0x29B7EC0 VA: 0x29BBEC0
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29BC930 Offset: 0x29B8930 VA: 0x29BC930
	|-EqualityComparer<KeyValuePair<object, float>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29BD670 Offset: 0x29B9670 VA: 0x29BD670
	|-EqualityComparer<KeyValuePair<float, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29BE11C Offset: 0x29BA11C VA: 0x29BE11C
	|-EqualityComparer<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29BEBEC Offset: 0x29BABEC VA: 0x29BEBEC
	|-EqualityComparer<StructMultiKey<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29BF640 Offset: 0x29BB640 VA: 0x29BF640
	|-EqualityComparer<ValueTuple<bool>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29C0090 Offset: 0x29BC090 VA: 0x29C0090
	|-EqualityComparer<ValueTuple<short, short>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29C0AE0 Offset: 0x29BCAE0 VA: 0x29C0AE0
	|-EqualityComparer<ValueTuple<int, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29C154C Offset: 0x29BD54C VA: 0x29C154C
	|-EqualityComparer<ValueTuple<int, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29C1FA0 Offset: 0x29BDFA0 VA: 0x29C1FA0
	|-EqualityComparer<ValueTuple<Int32Enum, float>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29C2A0C Offset: 0x29BEA0C VA: 0x29C2A0C
	|-EqualityComparer<ValueTuple<object, byte>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29C347C Offset: 0x29BF47C VA: 0x29C347C
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29C3EEC Offset: 0x29BFEEC VA: 0x29C3EEC
	|-EqualityComparer<ValueTuple<float, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29C49D8 Offset: 0x29C09D8 VA: 0x29C49D8
	|-EqualityComparer<ValueTuple<Vector3, Vector3>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29C54C0 Offset: 0x29C14C0 VA: 0x29C54C0
	|-EqualityComparer<ValueTuple<short, int, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29C5FB8 Offset: 0x29C1FB8 VA: 0x29C5FB8
	|-EqualityComparer<ValueTuple<object, object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29C6A74 Offset: 0x29C2A74 VA: 0x29C6A74
	|-EqualityComparer<ArchetypeUid>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29C74F0 Offset: 0x29C34F0 VA: 0x29C74F0
	|-EqualityComparer<BlackKnightAvatarProperty>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29C7F70 Offset: 0x29C3F70 VA: 0x29C7F70
	|-EqualityComparer<BlackKnightCristaProperty>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29C89E0 Offset: 0x29C49E0 VA: 0x29C89E0
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29C9440 Offset: 0x29C5440 VA: 0x29C9440
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29C9E90 Offset: 0x29C5E90 VA: 0x29C9E90
	|-EqualityComparer<ByteEnum>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29CA90C Offset: 0x29C690C VA: 0x29CA90C
	|-EqualityComparer<CardData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29CB36C Offset: 0x29C736C VA: 0x29CB36C
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29CBE10 Offset: 0x29C7E10 VA: 0x29CBE10
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29CC890 Offset: 0x29C8890 VA: 0x29CC890
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29CD2E0 Offset: 0x29C92E0 VA: 0x29CD2E0
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29CDD4C Offset: 0x29C9D4C VA: 0x29CDD4C
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29CE7BC Offset: 0x29CA7BC VA: 0x29CE7BC
	|-EqualityComparer<Decimal>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29CF210 Offset: 0x29CB210 VA: 0x29CF210
	|-EqualityComparer<DefencePoint2>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29CFC68 Offset: 0x29CBC68 VA: 0x29CFC68
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29D0768 Offset: 0x29CC768 VA: 0x29D0768
	|-EqualityComparer<EnhanceProperties2>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29D1240 Offset: 0x29CD240 VA: 0x29D1240
	|-EqualityComparer<EventSummary>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29D1CB0 Offset: 0x29CDCB0 VA: 0x29D1CB0
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29D2704 Offset: 0x29CE704 VA: 0x29D2704
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29D3154 Offset: 0x29CF154 VA: 0x29D3154
	|-EqualityComparer<Int16Enum>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29D3BA4 Offset: 0x29CFBA4 VA: 0x29D3BA4
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29D45F4 Offset: 0x29D05F4 VA: 0x29D45F4
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29D5044 Offset: 0x29D1044 VA: 0x29D5044
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29D5A94 Offset: 0x29D1A94 VA: 0x29D5A94
	|-EqualityComparer<Int64Enum>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29D64E4 Offset: 0x29D24E4 VA: 0x29D64E4
	|-EqualityComparer<IntPtr>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29D6F50 Offset: 0x29D2F50 VA: 0x29D6F50
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29D7A3C Offset: 0x29D3A3C VA: 0x29D7A3C
	|-EqualityComparer<JsonPosition>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29D8514 Offset: 0x29D4514 VA: 0x29D8514
	|-EqualityComparer<MaterialSearchData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29D9000 Offset: 0x29D5000 VA: 0x29D9000
	|-EqualityComparer<MobActionTargetData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29D9B54 Offset: 0x29D5B54 VA: 0x29D9B54
	|-EqualityComparer<MobIconLabelData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29DA610 Offset: 0x29D6610 VA: 0x29DA610
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29DB108 Offset: 0x29D7108 VA: 0x29DB108
	|-EqualityComparer<PlayerLoopSystem>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29DBC68 Offset: 0x29D7C68 VA: 0x29DBC68
	|-EqualityComparer<PlayerLoopSystemInternal>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29DC740 Offset: 0x29D8740 VA: 0x29DC740
	|-EqualityComparer<RangePositionInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29DD1C0 Offset: 0x29D91C0 VA: 0x29DD1C0
	|-EqualityComparer<ReinforceCristaData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29DDC3C Offset: 0x29D9C3C VA: 0x29DDC3C
	|-EqualityComparer<RenderInstancedDataLayout>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29DE6AC Offset: 0x29DA6AC VA: 0x29DE6AC
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29DF100 Offset: 0x29DB100 VA: 0x29DF100
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29DFB58 Offset: 0x29DBB58 VA: 0x29DFB58
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29E05B4 Offset: 0x29DC5B4 VA: 0x29E05B4
	|-EqualityComparer<SkillIdData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29E1004 Offset: 0x29DD004 VA: 0x29E1004
	|-EqualityComparer<TimeSpan>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29E1A54 Offset: 0x29DDA54 VA: 0x29E1A54
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29E24A4 Offset: 0x29DE4A4 VA: 0x29E24A4
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29E2EF4 Offset: 0x29DEEF4 VA: 0x29E2EF4
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29E3960 Offset: 0x29DF960 VA: 0x29E3960
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29E440C Offset: 0x29E040C VA: 0x29E440C
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29E4EDC Offset: 0x29E0EDC VA: 0x29E4EDC
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29E5978 Offset: 0x29E1978 VA: 0x29E5978
	|-EqualityComparer<X509ChainStatus>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29E63E8 Offset: 0x29E23E8 VA: 0x29E63E8
	|-EqualityComparer<XPathNodeRef>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29E7078 Offset: 0x29E3078 VA: 0x29E7078
	|-EqualityComparer<__Il2CppFullySharedGenericType>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29E7BAC Offset: 0x29E3BAC VA: 0x29E7BAC
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29E8698 Offset: 0x29E4698 VA: 0x29E8698
	|-EqualityComparer<BoneClip.MotionKeyFrame>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29E9170 Offset: 0x29E5170 VA: 0x29E9170
	|-EqualityComparer<DeathReceptionAction.PoisonTargetData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29E9C68 Offset: 0x29E5C68 VA: 0x29E9C68
	|-EqualityComparer<HouseRecipeManager.RecipeData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29EA724 Offset: 0x29E6724 VA: 0x29EA724
	|-EqualityComparer<KadarElexioBuf.SkillIdData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29EB204 Offset: 0x29E7204 VA: 0x29EB204
	|-EqualityComparer<MasterModelDataManager.ColorListData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29EBCB8 Offset: 0x29E7CB8 VA: 0x29EBCB8
	|-EqualityComparer<MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29EC708 Offset: 0x29E8708 VA: 0x29EC708
	|-EqualityComparer<MaterialManager.pair>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29ED184 Offset: 0x29E9184 VA: 0x29ED184
	|-EqualityComparer<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29EDC10 Offset: 0x29E9C10 VA: 0x29EDC10
	|-EqualityComparer<MissionTextManagerData.PickUpFieldData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29EE68C Offset: 0x29EA68C VA: 0x29EE68C
	|-EqualityComparer<MobaRoomData.MobaAbilityMasterData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29EF138 Offset: 0x29EB138 VA: 0x29EF138
	|-EqualityComparer<NewWaveRoomData.Spotlight>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29EFBE0 Offset: 0x29EBBE0 VA: 0x29EFBE0
	|-EqualityComparer<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29F06CC Offset: 0x29EC6CC VA: 0x29F06CC
	|-EqualityComparer<Regex.CachedCodeEntryKey>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29F1188 Offset: 0x29ED188 VA: 0x29F1188
	|-EqualityComparer<RegexCharClass.SingleRange>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29F1BF4 Offset: 0x29EDBF4 VA: 0x29F1BF4
	|-EqualityComparer<SocialAchievementData.LinkData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29F2648 Offset: 0x29EE648 VA: 0x29F2648
	|-EqualityComparer<TrophyManager.TrophyData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29F3128 Offset: 0x29EF128 VA: 0x29F3128
	|-EqualityComparer<UIEventMenuButton.MessageButtonData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29F3C34 Offset: 0x29EFC34 VA: 0x29F3C34
	|-EqualityComparer<UIFieldMapPanel.PopData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29F4768 Offset: 0x29F0768 VA: 0x29F4768
	|-EqualityComparer<UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29F5224 Offset: 0x29F1224 VA: 0x29F5224
	|-EqualityComparer<UIHouseAddressManager.Town>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29F5CCC Offset: 0x29F1CCC VA: 0x29F5CCC
	|-EqualityComparer<UIInfoWindow.LabelPosition>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29F6758 Offset: 0x29F2758 VA: 0x29F6758
	|-EqualityComparer<UIMainManager.DropItemData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29F71C4 Offset: 0x29F31C4 VA: 0x29F71C4
	|-EqualityComparer<UIScenarioOrderPanel.MissionData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29F7CB0 Offset: 0x29F3CB0 VA: 0x29F7CB0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29F8788 Offset: 0x29F4788 VA: 0x29F8788
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29F9234 Offset: 0x29F5234 VA: 0x29F9234
	|-EqualityComparer<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29F9D18 Offset: 0x29F5D18 VA: 0x29F9D18
	|-EqualityComparer<InstructionList.DebugView.InstructionView>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x29FA7A4 Offset: 0x29F67A4 VA: 0x29FA7A4
	|-EqualityComparer<PartyManager.PartyData.pair>.System.Collections.IEqualityComparer.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object x, object y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29B37B8 Offset: 0x29AF7B8 VA: 0x29B37B8
	|-EqualityComparer<KeyValuePair<ArchetypeUid, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29B420C Offset: 0x29B020C VA: 0x29B420C
	|-EqualityComparer<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29B4C5C Offset: 0x29B0C5C VA: 0x29B4C5C
	|-EqualityComparer<KeyValuePair<byte, byte>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29B56C8 Offset: 0x29B16C8 VA: 0x29B56C8
	|-EqualityComparer<KeyValuePair<byte, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29B611C Offset: 0x29B211C VA: 0x29B611C
	|-EqualityComparer<KeyValuePair<short, short>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29B6B6C Offset: 0x29B2B6C VA: 0x29B6B6C
	|-EqualityComparer<KeyValuePair<int, short>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29B75BC Offset: 0x29B35BC VA: 0x29B75BC
	|-EqualityComparer<KeyValuePair<int, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29B8028 Offset: 0x29B4028 VA: 0x29B8028
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29B8A7C Offset: 0x29B4A7C VA: 0x29B8A7C
	|-EqualityComparer<KeyValuePair<Int32Enum, byte>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29B959C Offset: 0x29B559C VA: 0x29B959C
	|-EqualityComparer<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29BA030 Offset: 0x29B6030 VA: 0x29BA030
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29BAA9C Offset: 0x29B6A9C VA: 0x29BAA9C
	|-EqualityComparer<KeyValuePair<Int32Enum, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29BB50C Offset: 0x29B750C VA: 0x29BB50C
	|-EqualityComparer<KeyValuePair<object, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29BBF7C Offset: 0x29B7F7C VA: 0x29BBF7C
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29BC9EC Offset: 0x29B89EC VA: 0x29BC9EC
	|-EqualityComparer<KeyValuePair<object, float>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29BD72C Offset: 0x29B972C VA: 0x29BD72C
	|-EqualityComparer<KeyValuePair<float, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29BE1F0 Offset: 0x29BA1F0 VA: 0x29BE1F0
	|-EqualityComparer<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29BECA8 Offset: 0x29BACA8 VA: 0x29BECA8
	|-EqualityComparer<StructMultiKey<object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29BF6FC Offset: 0x29BB6FC VA: 0x29BF6FC
	|-EqualityComparer<ValueTuple<bool>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29C014C Offset: 0x29BC14C VA: 0x29C014C
	|-EqualityComparer<ValueTuple<short, short>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29C0B9C Offset: 0x29BCB9C VA: 0x29C0B9C
	|-EqualityComparer<ValueTuple<int, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29C1608 Offset: 0x29BD608 VA: 0x29C1608
	|-EqualityComparer<ValueTuple<int, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29C205C Offset: 0x29BE05C VA: 0x29C205C
	|-EqualityComparer<ValueTuple<Int32Enum, float>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29C2AC8 Offset: 0x29BEAC8 VA: 0x29C2AC8
	|-EqualityComparer<ValueTuple<object, byte>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29C3538 Offset: 0x29BF538 VA: 0x29C3538
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29C3FA8 Offset: 0x29BFFA8 VA: 0x29C3FA8
	|-EqualityComparer<ValueTuple<float, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29C4ABC Offset: 0x29C0ABC VA: 0x29C4ABC
	|-EqualityComparer<ValueTuple<Vector3, Vector3>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29C5580 Offset: 0x29C1580 VA: 0x29C5580
	|-EqualityComparer<ValueTuple<short, int, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29C609C Offset: 0x29C209C VA: 0x29C609C
	|-EqualityComparer<ValueTuple<object, object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29C6B30 Offset: 0x29C2B30 VA: 0x29C6B30
	|-EqualityComparer<ArchetypeUid>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29C75B0 Offset: 0x29C35B0 VA: 0x29C75B0
	|-EqualityComparer<BlackKnightAvatarProperty>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29C8034 Offset: 0x29C4034 VA: 0x29C8034
	|-EqualityComparer<BlackKnightCristaProperty>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29C8A9C Offset: 0x29C4A9C VA: 0x29C8A9C
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29C94FC Offset: 0x29C54FC VA: 0x29C94FC
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29C9F4C Offset: 0x29C5F4C VA: 0x29C9F4C
	|-EqualityComparer<ByteEnum>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29CA9CC Offset: 0x29C69CC VA: 0x29CA9CC
	|-EqualityComparer<CardData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29CB428 Offset: 0x29C7428 VA: 0x29CB428
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29CBED0 Offset: 0x29C7ED0 VA: 0x29CBED0
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29CC94C Offset: 0x29C894C VA: 0x29CC94C
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29CD39C Offset: 0x29C939C VA: 0x29CD39C
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29CDE08 Offset: 0x29C9E08 VA: 0x29CDE08
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29CE878 Offset: 0x29CA878 VA: 0x29CE878
	|-EqualityComparer<Decimal>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29CF2CC Offset: 0x29CB2CC VA: 0x29CF2CC
	|-EqualityComparer<DefencePoint2>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29CFD24 Offset: 0x29CBD24 VA: 0x29CFD24
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29D084C Offset: 0x29CC84C VA: 0x29D084C
	|-EqualityComparer<EnhanceProperties2>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29D12FC Offset: 0x29CD2FC VA: 0x29D12FC
	|-EqualityComparer<EventSummary>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29D1D6C Offset: 0x29CDD6C VA: 0x29D1D6C
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29D27C0 Offset: 0x29CE7C0 VA: 0x29D27C0
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29D3210 Offset: 0x29CF210 VA: 0x29D3210
	|-EqualityComparer<Int16Enum>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29D3C60 Offset: 0x29CFC60 VA: 0x29D3C60
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29D46B0 Offset: 0x29D06B0 VA: 0x29D46B0
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29D5100 Offset: 0x29D1100 VA: 0x29D5100
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29D5B50 Offset: 0x29D1B50 VA: 0x29D5B50
	|-EqualityComparer<Int64Enum>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29D65A0 Offset: 0x29D25A0 VA: 0x29D65A0
	|-EqualityComparer<IntPtr>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29D700C Offset: 0x29D300C VA: 0x29D700C
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29D7B20 Offset: 0x29D3B20 VA: 0x29D7B20
	|-EqualityComparer<JsonPosition>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29D85D0 Offset: 0x29D45D0 VA: 0x29D85D0
	|-EqualityComparer<MaterialSearchData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29D90E4 Offset: 0x29D50E4 VA: 0x29D90E4
	|-EqualityComparer<MobActionTargetData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29D9C38 Offset: 0x29D5C38 VA: 0x29D9C38
	|-EqualityComparer<MobIconLabelData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29DA6C8 Offset: 0x29D66C8 VA: 0x29DA6C8
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29DB1EC Offset: 0x29D71EC VA: 0x29DB1EC
	|-EqualityComparer<PlayerLoopSystem>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29DBD4C Offset: 0x29D7D4C VA: 0x29DBD4C
	|-EqualityComparer<PlayerLoopSystemInternal>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29DC7FC Offset: 0x29D87FC VA: 0x29DC7FC
	|-EqualityComparer<RangePositionInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29DD280 Offset: 0x29D9280 VA: 0x29DD280
	|-EqualityComparer<ReinforceCristaData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29DDCF8 Offset: 0x29D9CF8 VA: 0x29DDCF8
	|-EqualityComparer<RenderInstancedDataLayout>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29DE768 Offset: 0x29DA768 VA: 0x29DE768
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29DF1BC Offset: 0x29DB1BC VA: 0x29DF1BC
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29DFC14 Offset: 0x29DBC14 VA: 0x29DFC14
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29E0670 Offset: 0x29DC670 VA: 0x29E0670
	|-EqualityComparer<SkillIdData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29E10C0 Offset: 0x29DD0C0 VA: 0x29E10C0
	|-EqualityComparer<TimeSpan>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29E1B10 Offset: 0x29DDB10 VA: 0x29E1B10
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29E2560 Offset: 0x29DE560 VA: 0x29E2560
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29E2FB0 Offset: 0x29DEFB0 VA: 0x29E2FB0
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29E3A1C Offset: 0x29DFA1C VA: 0x29E3A1C
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29E44CC Offset: 0x29E04CC VA: 0x29E44CC
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29E4F9C Offset: 0x29E0F9C VA: 0x29E4F9C
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29E5A34 Offset: 0x29E1A34 VA: 0x29E5A34
	|-EqualityComparer<X509ChainStatus>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29E64A4 Offset: 0x29E24A4 VA: 0x29E64A4
	|-EqualityComparer<XPathNodeRef>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29E7198 Offset: 0x29E3198 VA: 0x29E7198
	|-EqualityComparer<__Il2CppFullySharedGenericType>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29E7C68 Offset: 0x29E3C68 VA: 0x29E7C68
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29E877C Offset: 0x29E477C VA: 0x29E877C
	|-EqualityComparer<BoneClip.MotionKeyFrame>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29E922C Offset: 0x29E522C VA: 0x29E922C
	|-EqualityComparer<DeathReceptionAction.PoisonTargetData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29E9D4C Offset: 0x29E5D4C VA: 0x29E9D4C
	|-EqualityComparer<HouseRecipeManager.RecipeData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29EA7E0 Offset: 0x29E67E0 VA: 0x29EA7E0
	|-EqualityComparer<KadarElexioBuf.SkillIdData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29EB2E8 Offset: 0x29E72E8 VA: 0x29EB2E8
	|-EqualityComparer<MasterModelDataManager.ColorListData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29EBD74 Offset: 0x29E7D74 VA: 0x29EBD74
	|-EqualityComparer<MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29EC7C4 Offset: 0x29E87C4 VA: 0x29EC7C4
	|-EqualityComparer<MaterialManager.pair>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29ED244 Offset: 0x29E9244 VA: 0x29ED244
	|-EqualityComparer<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29EDCD0 Offset: 0x29E9CD0 VA: 0x29EDCD0
	|-EqualityComparer<MissionTextManagerData.PickUpFieldData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29EE748 Offset: 0x29EA748 VA: 0x29EE748
	|-EqualityComparer<MobaRoomData.MobaAbilityMasterData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29EF20C Offset: 0x29EB20C VA: 0x29EF20C
	|-EqualityComparer<NewWaveRoomData.Spotlight>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29EFC9C Offset: 0x29EBC9C VA: 0x29EFC9C
	|-EqualityComparer<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29F07B0 Offset: 0x29EC7B0 VA: 0x29F07B0
	|-EqualityComparer<Regex.CachedCodeEntryKey>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29F1244 Offset: 0x29ED244 VA: 0x29F1244
	|-EqualityComparer<RegexCharClass.SingleRange>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29F1CB0 Offset: 0x29EDCB0 VA: 0x29F1CB0
	|-EqualityComparer<SocialAchievementData.LinkData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29F2704 Offset: 0x29EE704 VA: 0x29F2704
	|-EqualityComparer<TrophyManager.TrophyData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29F320C Offset: 0x29EF20C VA: 0x29F320C
	|-EqualityComparer<UIEventMenuButton.MessageButtonData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29F3D08 Offset: 0x29EFD08 VA: 0x29F3D08
	|-EqualityComparer<UIFieldMapPanel.PopData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29F484C Offset: 0x29F084C VA: 0x29F484C
	|-EqualityComparer<UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29F52E0 Offset: 0x29F12E0 VA: 0x29F52E0
	|-EqualityComparer<UIHouseAddressManager.Town>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29F5DA0 Offset: 0x29F1DA0 VA: 0x29F5DA0
	|-EqualityComparer<UIInfoWindow.LabelPosition>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29F6814 Offset: 0x29F2814 VA: 0x29F6814
	|-EqualityComparer<UIMainManager.DropItemData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29F7280 Offset: 0x29F3280 VA: 0x29F7280
	|-EqualityComparer<UIScenarioOrderPanel.MissionData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29F7D94 Offset: 0x29F3D94 VA: 0x29F7D94
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29F8844 Offset: 0x29F4844 VA: 0x29F8844
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29F9308 Offset: 0x29F5308 VA: 0x29F9308
	|-EqualityComparer<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29F9DEC Offset: 0x29F5DEC VA: 0x29F9DEC
	|-EqualityComparer<InstructionList.DebugView.InstructionView>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x29FA860 Offset: 0x29F6860 VA: 0x29FA860
	|-EqualityComparer<PartyManager.PartyData.pair>.System.Collections.IEqualityComparer.Equals
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29B3910 Offset: 0x29AF910 VA: 0x29B3910
	|-EqualityComparer<KeyValuePair<ArchetypeUid, object>>..ctor
	|
	|-RVA: 0x29B4360 Offset: 0x29B0360 VA: 0x29B4360
	|-EqualityComparer<KeyValuePair<byte, BlackKnightCristaProperty>>..ctor
	|
	|-RVA: 0x29B4DB0 Offset: 0x29B0DB0 VA: 0x29B4DB0
	|-EqualityComparer<KeyValuePair<byte, byte>>..ctor
	|
	|-RVA: 0x29B5820 Offset: 0x29B1820 VA: 0x29B5820
	|-EqualityComparer<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x29B6270 Offset: 0x29B2270 VA: 0x29B6270
	|-EqualityComparer<KeyValuePair<short, short>>..ctor
	|
	|-RVA: 0x29B6CC0 Offset: 0x29B2CC0 VA: 0x29B6CC0
	|-EqualityComparer<KeyValuePair<int, short>>..ctor
	|
	|-RVA: 0x29B7710 Offset: 0x29B3710 VA: 0x29B7710
	|-EqualityComparer<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x29B8180 Offset: 0x29B4180 VA: 0x29B8180
	|-EqualityComparer<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x29B8BD0 Offset: 0x29B4BD0 VA: 0x29B8BD0
	|-EqualityComparer<KeyValuePair<Int32Enum, byte>>..ctor
	|
	|-RVA: 0x29B9734 Offset: 0x29B5734 VA: 0x29B9734
	|-EqualityComparer<KeyValuePair<Int32Enum, EnhanceProperties2>>..ctor
	|
	|-RVA: 0x29BA184 Offset: 0x29B6184 VA: 0x29BA184
	|-EqualityComparer<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x29BABF4 Offset: 0x29B6BF4 VA: 0x29BABF4
	|-EqualityComparer<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x29BB664 Offset: 0x29B7664 VA: 0x29BB664
	|-EqualityComparer<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x29BC0D4 Offset: 0x29B80D4 VA: 0x29BC0D4
	|-EqualityComparer<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x29BCB44 Offset: 0x29B8B44 VA: 0x29BCB44
	|-EqualityComparer<KeyValuePair<object, float>>..ctor
	|
	|-RVA: 0x29BD884 Offset: 0x29B9884 VA: 0x29BD884
	|-EqualityComparer<KeyValuePair<float, object>>..ctor
	|
	|-RVA: 0x29BE390 Offset: 0x29BA390 VA: 0x29BE390
	|-EqualityComparer<Nullable<UIMobPropertyLabel.IconValue>>..ctor
	|
	|-RVA: 0x29BEE00 Offset: 0x29BAE00 VA: 0x29BEE00
	|-EqualityComparer<StructMultiKey<object, object>>..ctor
	|
	|-RVA: 0x29BF850 Offset: 0x29BB850 VA: 0x29BF850
	|-EqualityComparer<ValueTuple<bool>>..ctor
	|
	|-RVA: 0x29C02A0 Offset: 0x29BC2A0 VA: 0x29C02A0
	|-EqualityComparer<ValueTuple<short, short>>..ctor
	|
	|-RVA: 0x29C0CF0 Offset: 0x29BCCF0 VA: 0x29C0CF0
	|-EqualityComparer<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x29C1760 Offset: 0x29BD760 VA: 0x29C1760
	|-EqualityComparer<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x29C21B0 Offset: 0x29BE1B0 VA: 0x29C21B0
	|-EqualityComparer<ValueTuple<Int32Enum, float>>..ctor
	|
	|-RVA: 0x29C2C20 Offset: 0x29BEC20 VA: 0x29C2C20
	|-EqualityComparer<ValueTuple<object, byte>>..ctor
	|
	|-RVA: 0x29C3690 Offset: 0x29BF690 VA: 0x29C3690
	|-EqualityComparer<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x29C4100 Offset: 0x29C0100 VA: 0x29C4100
	|-EqualityComparer<ValueTuple<float, object>>..ctor
	|
	|-RVA: 0x29C4C54 Offset: 0x29C0C54 VA: 0x29C4C54
	|-EqualityComparer<ValueTuple<Vector3, Vector3>>..ctor
	|
	|-RVA: 0x29C56E0 Offset: 0x29C16E0 VA: 0x29C56E0
	|-EqualityComparer<ValueTuple<short, int, int>>..ctor
	|
	|-RVA: 0x29C6234 Offset: 0x29C2234 VA: 0x29C6234
	|-EqualityComparer<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x29C6C84 Offset: 0x29C2C84 VA: 0x29C6C84
	|-EqualityComparer<ArchetypeUid>..ctor
	|
	|-RVA: 0x29C7710 Offset: 0x29C3710 VA: 0x29C7710
	|-EqualityComparer<BlackKnightAvatarProperty>..ctor
	|
	|-RVA: 0x29C81A0 Offset: 0x29C41A0 VA: 0x29C81A0
	|-EqualityComparer<BlackKnightCristaProperty>..ctor
	|
	|-RVA: 0x29C8C00 Offset: 0x29C4C00 VA: 0x29C8C00
	|-EqualityComparer<bool>..ctor
	|
	|-RVA: 0x29C9650 Offset: 0x29C5650 VA: 0x29C9650
	|-EqualityComparer<byte>..ctor
	|
	|-RVA: 0x29CA0A0 Offset: 0x29C60A0 VA: 0x29CA0A0
	|-EqualityComparer<ByteEnum>..ctor
	|
	|-RVA: 0x29CAB2C Offset: 0x29C6B2C VA: 0x29CAB2C
	|-EqualityComparer<CardData>..ctor
	|
	|-RVA: 0x29CB57C Offset: 0x29C757C VA: 0x29CB57C
	|-EqualityComparer<char>..ctor
	|
	|-RVA: 0x29CC050 Offset: 0x29C8050 VA: 0x29CC050
	|-EqualityComparer<Color>..ctor
	|
	|-RVA: 0x29CCAA0 Offset: 0x29C8AA0 VA: 0x29CCAA0
	|-EqualityComparer<Color32>..ctor
	|
	|-RVA: 0x29CD4F0 Offset: 0x29C94F0 VA: 0x29CD4F0
	|-EqualityComparer<DateTime>..ctor
	|
	|-RVA: 0x29CDF60 Offset: 0x29C9F60 VA: 0x29CDF60
	|-EqualityComparer<DateTimeOffset>..ctor
	|
	|-RVA: 0x29CE9D0 Offset: 0x29CA9D0 VA: 0x29CE9D0
	|-EqualityComparer<Decimal>..ctor
	|
	|-RVA: 0x29CF420 Offset: 0x29CB420 VA: 0x29CF420
	|-EqualityComparer<DefencePoint2>..ctor
	|
	|-RVA: 0x29CFE84 Offset: 0x29CBE84 VA: 0x29CFE84
	|-EqualityComparer<double>..ctor
	|
	|-RVA: 0x29D09E4 Offset: 0x29CC9E4 VA: 0x29D09E4
	|-EqualityComparer<EnhanceProperties2>..ctor
	|
	|-RVA: 0x29D1454 Offset: 0x29CD454 VA: 0x29D1454
	|-EqualityComparer<EventSummary>..ctor
	|
	|-RVA: 0x29D1EC4 Offset: 0x29CDEC4 VA: 0x29D1EC4
	|-EqualityComparer<Guid>..ctor
	|
	|-RVA: 0x29D2914 Offset: 0x29CE914 VA: 0x29D2914
	|-EqualityComparer<short>..ctor
	|
	|-RVA: 0x29D3364 Offset: 0x29CF364 VA: 0x29D3364
	|-EqualityComparer<Int16Enum>..ctor
	|
	|-RVA: 0x29D3DB4 Offset: 0x29CFDB4 VA: 0x29D3DB4
	|-EqualityComparer<int>..ctor
	|
	|-RVA: 0x29D4804 Offset: 0x29D0804 VA: 0x29D4804
	|-EqualityComparer<Int32Enum>..ctor
	|
	|-RVA: 0x29D5254 Offset: 0x29D1254 VA: 0x29D5254
	|-EqualityComparer<long>..ctor
	|
	|-RVA: 0x29D5CA4 Offset: 0x29D1CA4 VA: 0x29D5CA4
	|-EqualityComparer<Int64Enum>..ctor
	|
	|-RVA: 0x29D66F4 Offset: 0x29D26F4 VA: 0x29D66F4
	|-EqualityComparer<IntPtr>..ctor
	|
	|-RVA: 0x29D7164 Offset: 0x29D3164 VA: 0x29D7164
	|-EqualityComparer<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x29D7CB8 Offset: 0x29D3CB8 VA: 0x29D7CB8
	|-EqualityComparer<JsonPosition>..ctor
	|
	|-RVA: 0x29D8728 Offset: 0x29D4728 VA: 0x29D8728
	|-EqualityComparer<MaterialSearchData>..ctor
	|
	|-RVA: 0x29D927C Offset: 0x29D527C VA: 0x29D927C
	|-EqualityComparer<MobActionTargetData>..ctor
	|
	|-RVA: 0x29D9DD0 Offset: 0x29D5DD0 VA: 0x29D9DD0
	|-EqualityComparer<MobIconLabelData>..ctor
	|
	|-RVA: 0x29DA824 Offset: 0x29D6824 VA: 0x29DA824
	|-EqualityComparer<object>..ctor
	|
	|-RVA: 0x29DB384 Offset: 0x29D7384 VA: 0x29DB384
	|-EqualityComparer<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x29DBEE4 Offset: 0x29D7EE4 VA: 0x29DBEE4
	|-EqualityComparer<PlayerLoopSystemInternal>..ctor
	|
	|-RVA: 0x29DC954 Offset: 0x29D8954 VA: 0x29DC954
	|-EqualityComparer<RangePositionInfo>..ctor
	|
	|-RVA: 0x29DD3E0 Offset: 0x29D93E0 VA: 0x29DD3E0
	|-EqualityComparer<ReinforceCristaData>..ctor
	|
	|-RVA: 0x29DDE50 Offset: 0x29D9E50 VA: 0x29DDE50
	|-EqualityComparer<RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x29DE8C0 Offset: 0x29DA8C0 VA: 0x29DE8C0
	|-EqualityComparer<ResourceLocator>..ctor
	|
	|-RVA: 0x29DF310 Offset: 0x29DB310 VA: 0x29DF310
	|-EqualityComparer<sbyte>..ctor
	|
	|-RVA: 0x29DFD74 Offset: 0x29DBD74 VA: 0x29DFD74
	|-EqualityComparer<float>..ctor
	|
	|-RVA: 0x29E07C4 Offset: 0x29DC7C4 VA: 0x29E07C4
	|-EqualityComparer<SkillIdData>..ctor
	|
	|-RVA: 0x29E1214 Offset: 0x29DD214 VA: 0x29E1214
	|-EqualityComparer<TimeSpan>..ctor
	|
	|-RVA: 0x29E1C64 Offset: 0x29DDC64 VA: 0x29E1C64
	|-EqualityComparer<ushort>..ctor
	|
	|-RVA: 0x29E26B4 Offset: 0x29DE6B4 VA: 0x29E26B4
	|-EqualityComparer<uint>..ctor
	|
	|-RVA: 0x29E3104 Offset: 0x29DF104 VA: 0x29E3104
	|-EqualityComparer<ulong>..ctor
	|
	|-RVA: 0x29E3B80 Offset: 0x29DFB80 VA: 0x29E3B80
	|-EqualityComparer<Vector2>..ctor
	|
	|-RVA: 0x29E4648 Offset: 0x29E0648 VA: 0x29E4648
	|-EqualityComparer<Vector3>..ctor
	|
	|-RVA: 0x29E511C Offset: 0x29E111C VA: 0x29E511C
	|-EqualityComparer<Vector4>..ctor
	|
	|-RVA: 0x29E5B8C Offset: 0x29E1B8C VA: 0x29E5B8C
	|-EqualityComparer<X509ChainStatus>..ctor
	|
	|-RVA: 0x29E65FC Offset: 0x29E25FC VA: 0x29E65FC
	|-EqualityComparer<XPathNodeRef>..ctor
	|
	|-RVA: 0x29E7350 Offset: 0x29E3350 VA: 0x29E7350
	|-EqualityComparer<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x29E7DC0 Offset: 0x29E3DC0 VA: 0x29E7DC0
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x29E8914 Offset: 0x29E4914 VA: 0x29E8914
	|-EqualityComparer<BoneClip.MotionKeyFrame>..ctor
	|
	|-RVA: 0x29E9384 Offset: 0x29E5384 VA: 0x29E9384
	|-EqualityComparer<DeathReceptionAction.PoisonTargetData>..ctor
	|
	|-RVA: 0x29E9EE4 Offset: 0x29E5EE4 VA: 0x29E9EE4
	|-EqualityComparer<HouseRecipeManager.RecipeData>..ctor
	|
	|-RVA: 0x29EA934 Offset: 0x29E6934 VA: 0x29EA934
	|-EqualityComparer<KadarElexioBuf.SkillIdData>..ctor
	|
	|-RVA: 0x29EB478 Offset: 0x29E7478 VA: 0x29EB478
	|-EqualityComparer<MasterModelDataManager.ColorListData>..ctor
	|
	|-RVA: 0x29EBEC8 Offset: 0x29E7EC8 VA: 0x29EBEC8
	|-EqualityComparer<MasterModelDataManager.ConvertCommonMaterialData>..ctor
	|
	|-RVA: 0x29EC918 Offset: 0x29E8918 VA: 0x29EC918
	|-EqualityComparer<MaterialManager.pair>..ctor
	|
	|-RVA: 0x29ED3A4 Offset: 0x29E93A4 VA: 0x29ED3A4
	|-EqualityComparer<MissionTextManagerData.CheckIKeywordtemData>..ctor
	|
	|-RVA: 0x29EDE30 Offset: 0x29E9E30 VA: 0x29EDE30
	|-EqualityComparer<MissionTextManagerData.PickUpFieldData>..ctor
	|
	|-RVA: 0x29EE8A0 Offset: 0x29EA8A0 VA: 0x29EE8A0
	|-EqualityComparer<MobaRoomData.MobaAbilityMasterData>..ctor
	|
	|-RVA: 0x29EF384 Offset: 0x29EB384 VA: 0x29EF384
	|-EqualityComparer<NewWaveRoomData.Spotlight>..ctor
	|
	|-RVA: 0x29EFDF4 Offset: 0x29EBDF4 VA: 0x29EFDF4
	|-EqualityComparer<NguiDynamicFontController.ApplyTextureInfo>..ctor
	|
	|-RVA: 0x29F0948 Offset: 0x29EC948 VA: 0x29F0948
	|-EqualityComparer<Regex.CachedCodeEntryKey>..ctor
	|
	|-RVA: 0x29F1398 Offset: 0x29ED398 VA: 0x29F1398
	|-EqualityComparer<RegexCharClass.SingleRange>..ctor
	|
	|-RVA: 0x29F1E08 Offset: 0x29EDE08 VA: 0x29F1E08
	|-EqualityComparer<SocialAchievementData.LinkData>..ctor
	|
	|-RVA: 0x29F2858 Offset: 0x29EE858 VA: 0x29F2858
	|-EqualityComparer<TrophyManager.TrophyData>..ctor
	|
	|-RVA: 0x29F339C Offset: 0x29EF39C VA: 0x29F339C
	|-EqualityComparer<UIEventMenuButton.MessageButtonData>..ctor
	|
	|-RVA: 0x29F3E80 Offset: 0x29EFE80 VA: 0x29F3E80
	|-EqualityComparer<UIFieldMapPanel.PopData>..ctor
	|
	|-RVA: 0x29F49E4 Offset: 0x29F09E4 VA: 0x29F49E4
	|-EqualityComparer<UIGuildQuestBoardManager.GuildQuestMaseter>..ctor
	|
	|-RVA: 0x29F5434 Offset: 0x29F1434 VA: 0x29F5434
	|-EqualityComparer<UIHouseAddressManager.Town>..ctor
	|
	|-RVA: 0x29F5F18 Offset: 0x29F1F18 VA: 0x29F5F18
	|-EqualityComparer<UIInfoWindow.LabelPosition>..ctor
	|
	|-RVA: 0x29F6968 Offset: 0x29F2968 VA: 0x29F6968
	|-EqualityComparer<UIMainManager.DropItemData>..ctor
	|
	|-RVA: 0x29F73D8 Offset: 0x29F33D8 VA: 0x29F73D8
	|-EqualityComparer<UIScenarioOrderPanel.MissionData>..ctor
	|
	|-RVA: 0x29F7F2C Offset: 0x29F3F2C VA: 0x29F7F2C
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x29F899C Offset: 0x29F499C VA: 0x29F899C
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0x29F9480 Offset: 0x29F5480 VA: 0x29F9480
	|-EqualityComparer<BounceParabolaAttackPattern.TargetData.BoundLineData>..ctor
	|
	|-RVA: 0x29F9F64 Offset: 0x29F5F64 VA: 0x29F9F64
	|-EqualityComparer<InstructionList.DebugView.InstructionView>..ctor
	|
	|-RVA: 0x29FA9B4 Offset: 0x29F69B4 VA: 0x29FA9B4
	|-EqualityComparer<PartyManager.PartyData.pair>..ctor
	*/
}
