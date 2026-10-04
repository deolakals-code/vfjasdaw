// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
[DefaultMember("Item")]
[Serializable]
public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 10949
{
	// Fields
	private const int DefaultCapacity = 4;
	private T[] _items; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0
	private object _syncRoot; // 0x0
	private static readonly T[] s_emptyArray; // 0x0

	// Properties
	public int Capacity { set; }
	public int Count { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public T Item { get; set; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AACEC0 Offset: 0x2AA8EC0 VA: 0x2AACEC0
	|-List<KeyValuePair<ArchetypeUid, object>>..ctor
	|
	|-RVA: 0x2AAF640 Offset: 0x2AAB640 VA: 0x2AAF640
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>..ctor
	|
	|-RVA: 0x2AB1C88 Offset: 0x2AADC88 VA: 0x2AB1C88
	|-List<KeyValuePair<byte, byte>>..ctor
	|
	|-RVA: 0x2AB464C Offset: 0x2AB064C VA: 0x2AB464C
	|-List<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x2AB6DCC Offset: 0x2AB2DCC VA: 0x2AB6DCC
	|-List<KeyValuePair<int, short>>..ctor
	|
	|-RVA: 0x2AB9404 Offset: 0x2AB5404 VA: 0x2AB9404
	|-List<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x2ABBA3C Offset: 0x2AB7A3C VA: 0x2ABBA3C
	|-List<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2ABE1BC Offset: 0x2ABA1BC VA: 0x2ABE1BC
	|-List<KeyValuePair<Int32Enum, byte>>..ctor
	|
	|-RVA: 0x2AC07F4 Offset: 0x2ABC7F4 VA: 0x2AC07F4
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>..ctor
	|
	|-RVA: 0x2AC32F4 Offset: 0x2ABF2F4 VA: 0x2AC32F4
	|-List<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2AC592C Offset: 0x2AC192C VA: 0x2AC592C
	|-List<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x2AC80AC Offset: 0x2AC40AC VA: 0x2AC80AC
	|-List<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x2ACA82C Offset: 0x2AC682C VA: 0x2ACA82C
	|-List<KeyValuePair<object, float>>..ctor
	|
	|-RVA: 0x2ACCFAC Offset: 0x2AC8FAC VA: 0x2ACCFAC
	|-List<KeyValuePair<float, object>>..ctor
	|
	|-RVA: 0x2ACF72C Offset: 0x2ACB72C VA: 0x2ACF72C
	|-List<Nullable<UIMobPropertyLabel.IconValue>>..ctor
	|
	|-RVA: 0x2AD2158 Offset: 0x2ACE158 VA: 0x2AD2158
	|-List<StructMultiKey<object, object>>..ctor
	|
	|-RVA: 0x2AD48D8 Offset: 0x2AD08D8 VA: 0x2AD48D8
	|-List<ValueTuple<short, short>>..ctor
	|
	|-RVA: 0x2AD6F20 Offset: 0x2AD2F20 VA: 0x2AD6F20
	|-List<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2AD9558 Offset: 0x2AD5558 VA: 0x2AD9558
	|-List<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x2ADBCD8 Offset: 0x2AD7CD8 VA: 0x2ADBCD8
	|-List<ValueTuple<Int32Enum, float>>..ctor
	|
	|-RVA: 0x2ADE310 Offset: 0x2ADA310 VA: 0x2ADE310
	|-List<ValueTuple<Vector3, Vector3>>..ctor
	|
	|-RVA: 0x2AE0DC8 Offset: 0x2ADCDC8 VA: 0x2AE0DC8
	|-List<ArchetypeUid>..ctor
	|
	|-RVA: 0x2AE3400 Offset: 0x2ADF400 VA: 0x2AE3400
	|-List<bool>..ctor
	|
	|-RVA: 0x2AE5A78 Offset: 0x2AE1A78 VA: 0x2AE5A78
	|-List<byte>..ctor
	|
	|-RVA: 0x2AE80B4 Offset: 0x2AE40B4 VA: 0x2AE80B4
	|-List<ByteEnum>..ctor
	|
	|-RVA: 0x2AEA6F0 Offset: 0x2AE66F0 VA: 0x2AEA6F0
	|-List<char>..ctor
	|
	|-RVA: 0x2AECD28 Offset: 0x2AE8D28 VA: 0x2AECD28
	|-List<Color>..ctor
	|
	|-RVA: 0x2AEF468 Offset: 0x2AEB468 VA: 0x2AEF468
	|-List<Color32>..ctor
	|
	|-RVA: 0x2AF1AB0 Offset: 0x2AEDAB0 VA: 0x2AF1AB0
	|-List<DateTime>..ctor
	|
	|-RVA: 0x2AF40E8 Offset: 0x2AF00E8 VA: 0x2AF40E8
	|-List<DateTimeOffset>..ctor
	|
	|-RVA: 0x2AF6780 Offset: 0x2AF2780 VA: 0x2AF6780
	|-List<Decimal>..ctor
	|
	|-RVA: 0x2AF8E90 Offset: 0x2AF4E90 VA: 0x2AF8E90
	|-List<DefencePoint2>..ctor
	|
	|-RVA: 0x2AFB4C8 Offset: 0x2AF74C8 VA: 0x2AFB4C8
	|-List<double>..ctor
	|
	|-RVA: 0x2AFDB0C Offset: 0x2AF9B0C VA: 0x2AFDB0C
	|-List<EventSummary>..ctor
	|
	|-RVA: 0x2B0028C Offset: 0x2AFC28C VA: 0x2B0028C
	|-List<short>..ctor
	|
	|-RVA: 0x2B028C4 Offset: 0x2AFE8C4 VA: 0x2B028C4
	|-List<Int16Enum>..ctor
	|
	|-RVA: 0x2B04EFC Offset: 0x2B00EFC VA: 0x2B04EFC
	|-List<int>..ctor
	|
	|-RVA: 0x2B07530 Offset: 0x2B03530 VA: 0x2B07530
	|-List<Int32Enum>..ctor
	|
	|-RVA: 0x2B09B64 Offset: 0x2B05B64 VA: 0x2B09B64
	|-List<long>..ctor
	|
	|-RVA: 0x2B0C198 Offset: 0x2B08198 VA: 0x2B0C198
	|-List<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x2B0E918 Offset: 0x2B0A918 VA: 0x2B0E918
	|-List<JsonPosition>..ctor
	|
	|-RVA: 0x2B114F4 Offset: 0x2B0D4F4 VA: 0x2B114F4
	|-List<MaterialSearchData>..ctor
	|
	|-RVA: 0x2B13B8C Offset: 0x2B0FB8C VA: 0x2B13B8C
	|-List<MobActionTargetData>..ctor
	|
	|-RVA: 0x2B16644 Offset: 0x2B12644 VA: 0x2B16644
	|-List<MobIconLabelData>..ctor
	|
	|-RVA: 0x2B19220 Offset: 0x2B15220 VA: 0x2B19220
	|-List<object>..ctor
	|
	|-RVA: 0x2B1B8E0 Offset: 0x2B178E0 VA: 0x2B1B8E0
	|-List<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x2B1E4E8 Offset: 0x2B1A4E8 VA: 0x2B1E4E8
	|-List<PlayerLoopSystemInternal>..ctor
	|
	|-RVA: 0x2B210F0 Offset: 0x2B1D0F0 VA: 0x2B210F0
	|-List<RangePositionInfo>..ctor
	|
	|-RVA: 0x2B23870 Offset: 0x2B1F870 VA: 0x2B23870
	|-List<ReinforceCristaData>..ctor
	|
	|-RVA: 0x2B25FD4 Offset: 0x2B21FD4 VA: 0x2B25FD4
	|-List<sbyte>..ctor
	|
	|-RVA: 0x2B28610 Offset: 0x2B24610 VA: 0x2B28610
	|-List<float>..ctor
	|
	|-RVA: 0x2B2AC54 Offset: 0x2B26C54 VA: 0x2B2AC54
	|-List<SkillIdData>..ctor
	|
	|-RVA: 0x2B2D28C Offset: 0x2B2928C VA: 0x2B2D28C
	|-List<TimeSpan>..ctor
	|
	|-RVA: 0x2B53CA4 Offset: 0x2B4FCA4 VA: 0x2B53CA4
	|-List<ushort>..ctor
	|
	|-RVA: 0x2B562DC Offset: 0x2B522DC VA: 0x2B562DC
	|-List<uint>..ctor
	|
	|-RVA: 0x2B58910 Offset: 0x2B54910 VA: 0x2B58910
	|-List<ulong>..ctor
	|
	|-RVA: 0x2B5AF44 Offset: 0x2B56F44 VA: 0x2B5AF44
	|-List<Vector2>..ctor
	|
	|-RVA: 0x2B5D5F0 Offset: 0x2B595F0 VA: 0x2B5D5F0
	|-List<Vector3>..ctor
	|
	|-RVA: 0x2B5FD7C Offset: 0x2B5BD7C VA: 0x2B5FD7C
	|-List<X509ChainStatus>..ctor
	|
	|-RVA: 0x2B624FC Offset: 0x2B5E4FC VA: 0x2B624FC
	|-List<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2B65F08 Offset: 0x2B61F08 VA: 0x2B65F08
	|-List<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x2B68688 Offset: 0x2B64688 VA: 0x2B68688
	|-List<BoneClip.MotionKeyFrame>..ctor
	|
	|-RVA: 0x2B6B240 Offset: 0x2B67240 VA: 0x2B6B240
	|-List<HouseRecipeManager.RecipeData>..ctor
	|
	|-RVA: 0x2B6DE24 Offset: 0x2B69E24 VA: 0x2B6DE24
	|-List<KadarElexioBuf.SkillIdData>..ctor
	|
	|-RVA: 0x2B7045C Offset: 0x2B6C45C VA: 0x2B7045C
	|-List<MissionTextManagerData.CheckIKeywordtemData>..ctor
	|
	|-RVA: 0x2B72BC0 Offset: 0x2B6EBC0 VA: 0x2B72BC0
	|-List<MissionTextManagerData.PickUpFieldData>..ctor
	|
	|-RVA: 0x2B75324 Offset: 0x2B71324 VA: 0x2B75324
	|-List<MobaRoomData.MobaAbilityMasterData>..ctor
	|
	|-RVA: 0x2B779BC Offset: 0x2B739BC VA: 0x2B779BC
	|-List<NewWaveRoomData.Spotlight>..ctor
	|
	|-RVA: 0x2B7A39C Offset: 0x2B7639C VA: 0x2B7A39C
	|-List<NguiDynamicFontController.ApplyTextureInfo>..ctor
	|
	|-RVA: 0x2B7CB1C Offset: 0x2B78B1C VA: 0x2B7CB1C
	|-List<RegexCharClass.SingleRange>..ctor
	|
	|-RVA: 0x2B7F164 Offset: 0x2B7B164 VA: 0x2B7F164
	|-List<SocialAchievementData.LinkData>..ctor
	|
	|-RVA: 0x2B818E4 Offset: 0x2B7D8E4 VA: 0x2B818E4
	|-List<TrophyManager.TrophyData>..ctor
	|
	|-RVA: 0x2B83F1C Offset: 0x2B7FF1C VA: 0x2B83F1C
	|-List<UIEventMenuButton.MessageButtonData>..ctor
	|
	|-RVA: 0x2B86B00 Offset: 0x2B82B00 VA: 0x2B86B00
	|-List<UIFieldMapPanel.PopData>..ctor
	|
	|-RVA: 0x2B894E0 Offset: 0x2B854E0 VA: 0x2B894E0
	|-List<UIHouseAddressManager.Town>..ctor
	|
	|-RVA: 0x2B8BB18 Offset: 0x2B87B18 VA: 0x2B8BB18
	|-List<UIInfoWindow.LabelPosition>..ctor
	|
	|-RVA: 0x2B8E4F8 Offset: 0x2B8A4F8 VA: 0x2B8E4F8
	|-List<UIMainManager.DropItemData>..ctor
	|
	|-RVA: 0x2B90B30 Offset: 0x2B8CB30 VA: 0x2B90B30
	|-List<UIScenarioOrderPanel.MissionData>..ctor
	|
	|-RVA: 0x2B932B0 Offset: 0x2B8F2B0 VA: 0x2B932B0
	|-List<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x2B95E8C Offset: 0x2B91E8C VA: 0x2B95E8C
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0x2B9860C Offset: 0x2B9460C VA: 0x2B9860C
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>..ctor
	|
	|-RVA: 0x2B9AEEC Offset: 0x2B96EEC VA: 0x2B9AEEC
	|-List<InstructionList.DebugView.InstructionView>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AACF30 Offset: 0x2AA8F30 VA: 0x2AACF30
	|-List<KeyValuePair<ArchetypeUid, object>>..ctor
	|
	|-RVA: 0x2AAF6B0 Offset: 0x2AAB6B0 VA: 0x2AAF6B0
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>..ctor
	|
	|-RVA: 0x2AB1CF8 Offset: 0x2AADCF8 VA: 0x2AB1CF8
	|-List<KeyValuePair<byte, byte>>..ctor
	|
	|-RVA: 0x2AB46BC Offset: 0x2AB06BC VA: 0x2AB46BC
	|-List<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x2AB6E3C Offset: 0x2AB2E3C VA: 0x2AB6E3C
	|-List<KeyValuePair<int, short>>..ctor
	|
	|-RVA: 0x2AB9474 Offset: 0x2AB5474 VA: 0x2AB9474
	|-List<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x2ABBAAC Offset: 0x2AB7AAC VA: 0x2ABBAAC
	|-List<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2ABE22C Offset: 0x2ABA22C VA: 0x2ABE22C
	|-List<KeyValuePair<Int32Enum, byte>>..ctor
	|
	|-RVA: 0x2AC0864 Offset: 0x2ABC864 VA: 0x2AC0864
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>..ctor
	|
	|-RVA: 0x2AC3364 Offset: 0x2ABF364 VA: 0x2AC3364
	|-List<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2AC599C Offset: 0x2AC199C VA: 0x2AC599C
	|-List<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x2AC811C Offset: 0x2AC411C VA: 0x2AC811C
	|-List<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x2ACA89C Offset: 0x2AC689C VA: 0x2ACA89C
	|-List<KeyValuePair<object, float>>..ctor
	|
	|-RVA: 0x2ACD01C Offset: 0x2AC901C VA: 0x2ACD01C
	|-List<KeyValuePair<float, object>>..ctor
	|
	|-RVA: 0x2ACF79C Offset: 0x2ACB79C VA: 0x2ACF79C
	|-List<Nullable<UIMobPropertyLabel.IconValue>>..ctor
	|
	|-RVA: 0x2AD21C8 Offset: 0x2ACE1C8 VA: 0x2AD21C8
	|-List<StructMultiKey<object, object>>..ctor
	|
	|-RVA: 0x2AD4948 Offset: 0x2AD0948 VA: 0x2AD4948
	|-List<ValueTuple<short, short>>..ctor
	|
	|-RVA: 0x2AD6F90 Offset: 0x2AD2F90 VA: 0x2AD6F90
	|-List<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2AD95C8 Offset: 0x2AD55C8 VA: 0x2AD95C8
	|-List<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x2ADBD48 Offset: 0x2AD7D48 VA: 0x2ADBD48
	|-List<ValueTuple<Int32Enum, float>>..ctor
	|
	|-RVA: 0x2ADE380 Offset: 0x2ADA380 VA: 0x2ADE380
	|-List<ValueTuple<Vector3, Vector3>>..ctor
	|
	|-RVA: 0x2AE0E38 Offset: 0x2ADCE38 VA: 0x2AE0E38
	|-List<ArchetypeUid>..ctor
	|
	|-RVA: 0x2AE3470 Offset: 0x2ADF470 VA: 0x2AE3470
	|-List<bool>..ctor
	|
	|-RVA: 0x2AE5AE8 Offset: 0x2AE1AE8 VA: 0x2AE5AE8
	|-List<byte>..ctor
	|
	|-RVA: 0x2AE8124 Offset: 0x2AE4124 VA: 0x2AE8124
	|-List<ByteEnum>..ctor
	|
	|-RVA: 0x2AEA760 Offset: 0x2AE6760 VA: 0x2AEA760
	|-List<char>..ctor
	|
	|-RVA: 0x2AECD98 Offset: 0x2AE8D98 VA: 0x2AECD98
	|-List<Color>..ctor
	|
	|-RVA: 0x2AEF4D8 Offset: 0x2AEB4D8 VA: 0x2AEF4D8
	|-List<Color32>..ctor
	|
	|-RVA: 0x2AF1B20 Offset: 0x2AEDB20 VA: 0x2AF1B20
	|-List<DateTime>..ctor
	|
	|-RVA: 0x2AF4158 Offset: 0x2AF0158 VA: 0x2AF4158
	|-List<DateTimeOffset>..ctor
	|
	|-RVA: 0x2AF67F0 Offset: 0x2AF27F0 VA: 0x2AF67F0
	|-List<Decimal>..ctor
	|
	|-RVA: 0x2AF8F00 Offset: 0x2AF4F00 VA: 0x2AF8F00
	|-List<DefencePoint2>..ctor
	|
	|-RVA: 0x2AFB538 Offset: 0x2AF7538 VA: 0x2AFB538
	|-List<double>..ctor
	|
	|-RVA: 0x2AFDB7C Offset: 0x2AF9B7C VA: 0x2AFDB7C
	|-List<EventSummary>..ctor
	|
	|-RVA: 0x2B002FC Offset: 0x2AFC2FC VA: 0x2B002FC
	|-List<short>..ctor
	|
	|-RVA: 0x2B02934 Offset: 0x2AFE934 VA: 0x2B02934
	|-List<Int16Enum>..ctor
	|
	|-RVA: 0x2B04F6C Offset: 0x2B00F6C VA: 0x2B04F6C
	|-List<int>..ctor
	|
	|-RVA: 0x2B075A0 Offset: 0x2B035A0 VA: 0x2B075A0
	|-List<Int32Enum>..ctor
	|
	|-RVA: 0x2B09BD4 Offset: 0x2B05BD4 VA: 0x2B09BD4
	|-List<long>..ctor
	|
	|-RVA: 0x2B0C208 Offset: 0x2B08208 VA: 0x2B0C208
	|-List<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x2B0E988 Offset: 0x2B0A988 VA: 0x2B0E988
	|-List<JsonPosition>..ctor
	|
	|-RVA: 0x2B11564 Offset: 0x2B0D564 VA: 0x2B11564
	|-List<MaterialSearchData>..ctor
	|
	|-RVA: 0x2B13BFC Offset: 0x2B0FBFC VA: 0x2B13BFC
	|-List<MobActionTargetData>..ctor
	|
	|-RVA: 0x2B166B4 Offset: 0x2B126B4 VA: 0x2B166B4
	|-List<MobIconLabelData>..ctor
	|
	|-RVA: 0x2B19290 Offset: 0x2B15290 VA: 0x2B19290
	|-List<object>..ctor
	|
	|-RVA: 0x2B1B950 Offset: 0x2B17950 VA: 0x2B1B950
	|-List<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x2B1E558 Offset: 0x2B1A558 VA: 0x2B1E558
	|-List<PlayerLoopSystemInternal>..ctor
	|
	|-RVA: 0x2B21160 Offset: 0x2B1D160 VA: 0x2B21160
	|-List<RangePositionInfo>..ctor
	|
	|-RVA: 0x2B238E0 Offset: 0x2B1F8E0 VA: 0x2B238E0
	|-List<ReinforceCristaData>..ctor
	|
	|-RVA: 0x2B26044 Offset: 0x2B22044 VA: 0x2B26044
	|-List<sbyte>..ctor
	|
	|-RVA: 0x2B28680 Offset: 0x2B24680 VA: 0x2B28680
	|-List<float>..ctor
	|
	|-RVA: 0x2B2ACC4 Offset: 0x2B26CC4 VA: 0x2B2ACC4
	|-List<SkillIdData>..ctor
	|
	|-RVA: 0x2B2D2FC Offset: 0x2B292FC VA: 0x2B2D2FC
	|-List<TimeSpan>..ctor
	|
	|-RVA: 0x2B53D14 Offset: 0x2B4FD14 VA: 0x2B53D14
	|-List<ushort>..ctor
	|
	|-RVA: 0x2B5634C Offset: 0x2B5234C VA: 0x2B5634C
	|-List<uint>..ctor
	|
	|-RVA: 0x2B58980 Offset: 0x2B54980 VA: 0x2B58980
	|-List<ulong>..ctor
	|
	|-RVA: 0x2B5AFB4 Offset: 0x2B56FB4 VA: 0x2B5AFB4
	|-List<Vector2>..ctor
	|
	|-RVA: 0x2B5D660 Offset: 0x2B59660 VA: 0x2B5D660
	|-List<Vector3>..ctor
	|
	|-RVA: 0x2B5FDEC Offset: 0x2B5BDEC VA: 0x2B5FDEC
	|-List<X509ChainStatus>..ctor
	|
	|-RVA: 0x2B6256C Offset: 0x2B5E56C VA: 0x2B6256C
	|-List<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2B65F78 Offset: 0x2B61F78 VA: 0x2B65F78
	|-List<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x2B686F8 Offset: 0x2B646F8 VA: 0x2B686F8
	|-List<BoneClip.MotionKeyFrame>..ctor
	|
	|-RVA: 0x2B6B2B0 Offset: 0x2B672B0 VA: 0x2B6B2B0
	|-List<HouseRecipeManager.RecipeData>..ctor
	|
	|-RVA: 0x2B6DE94 Offset: 0x2B69E94 VA: 0x2B6DE94
	|-List<KadarElexioBuf.SkillIdData>..ctor
	|
	|-RVA: 0x2B704CC Offset: 0x2B6C4CC VA: 0x2B704CC
	|-List<MissionTextManagerData.CheckIKeywordtemData>..ctor
	|
	|-RVA: 0x2B72C30 Offset: 0x2B6EC30 VA: 0x2B72C30
	|-List<MissionTextManagerData.PickUpFieldData>..ctor
	|
	|-RVA: 0x2B75394 Offset: 0x2B71394 VA: 0x2B75394
	|-List<MobaRoomData.MobaAbilityMasterData>..ctor
	|
	|-RVA: 0x2B77A2C Offset: 0x2B73A2C VA: 0x2B77A2C
	|-List<NewWaveRoomData.Spotlight>..ctor
	|
	|-RVA: 0x2B7A40C Offset: 0x2B7640C VA: 0x2B7A40C
	|-List<NguiDynamicFontController.ApplyTextureInfo>..ctor
	|
	|-RVA: 0x2B7CB8C Offset: 0x2B78B8C VA: 0x2B7CB8C
	|-List<RegexCharClass.SingleRange>..ctor
	|
	|-RVA: 0x2B7F1D4 Offset: 0x2B7B1D4 VA: 0x2B7F1D4
	|-List<SocialAchievementData.LinkData>..ctor
	|
	|-RVA: 0x2B81954 Offset: 0x2B7D954 VA: 0x2B81954
	|-List<TrophyManager.TrophyData>..ctor
	|
	|-RVA: 0x2B83F8C Offset: 0x2B7FF8C VA: 0x2B83F8C
	|-List<UIEventMenuButton.MessageButtonData>..ctor
	|
	|-RVA: 0x2B86B70 Offset: 0x2B82B70 VA: 0x2B86B70
	|-List<UIFieldMapPanel.PopData>..ctor
	|
	|-RVA: 0x2B89550 Offset: 0x2B85550 VA: 0x2B89550
	|-List<UIHouseAddressManager.Town>..ctor
	|
	|-RVA: 0x2B8BB88 Offset: 0x2B87B88 VA: 0x2B8BB88
	|-List<UIInfoWindow.LabelPosition>..ctor
	|
	|-RVA: 0x2B8E568 Offset: 0x2B8A568 VA: 0x2B8E568
	|-List<UIMainManager.DropItemData>..ctor
	|
	|-RVA: 0x2B90BA0 Offset: 0x2B8CBA0 VA: 0x2B90BA0
	|-List<UIScenarioOrderPanel.MissionData>..ctor
	|
	|-RVA: 0x2B93320 Offset: 0x2B8F320 VA: 0x2B93320
	|-List<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x2B95EFC Offset: 0x2B91EFC VA: 0x2B95EFC
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0x2B9867C Offset: 0x2B9467C VA: 0x2B9867C
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>..ctor
	|
	|-RVA: 0x2B9AF5C Offset: 0x2B96F5C VA: 0x2B9AF5C
	|-List<InstructionList.DebugView.InstructionView>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AACFE8 Offset: 0x2AA8FE8 VA: 0x2AACFE8
	|-List<KeyValuePair<ArchetypeUid, object>>..ctor
	|
	|-RVA: 0x2AAF768 Offset: 0x2AAB768 VA: 0x2AAF768
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>..ctor
	|
	|-RVA: 0x2AB1DB0 Offset: 0x2AADDB0 VA: 0x2AB1DB0
	|-List<KeyValuePair<byte, byte>>..ctor
	|
	|-RVA: 0x2AB4774 Offset: 0x2AB0774 VA: 0x2AB4774
	|-List<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x2AB6EF4 Offset: 0x2AB2EF4 VA: 0x2AB6EF4
	|-List<KeyValuePair<int, short>>..ctor
	|
	|-RVA: 0x2AB952C Offset: 0x2AB552C VA: 0x2AB952C
	|-List<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x2ABBB64 Offset: 0x2AB7B64 VA: 0x2ABBB64
	|-List<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2ABE2E4 Offset: 0x2ABA2E4 VA: 0x2ABE2E4
	|-List<KeyValuePair<Int32Enum, byte>>..ctor
	|
	|-RVA: 0x2AC091C Offset: 0x2ABC91C VA: 0x2AC091C
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>..ctor
	|
	|-RVA: 0x2AC341C Offset: 0x2ABF41C VA: 0x2AC341C
	|-List<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2AC5A54 Offset: 0x2AC1A54 VA: 0x2AC5A54
	|-List<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x2AC81D4 Offset: 0x2AC41D4 VA: 0x2AC81D4
	|-List<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x2ACA954 Offset: 0x2AC6954 VA: 0x2ACA954
	|-List<KeyValuePair<object, float>>..ctor
	|
	|-RVA: 0x2ACD0D4 Offset: 0x2AC90D4 VA: 0x2ACD0D4
	|-List<KeyValuePair<float, object>>..ctor
	|
	|-RVA: 0x2ACF854 Offset: 0x2ACB854 VA: 0x2ACF854
	|-List<Nullable<UIMobPropertyLabel.IconValue>>..ctor
	|
	|-RVA: 0x2AD2280 Offset: 0x2ACE280 VA: 0x2AD2280
	|-List<StructMultiKey<object, object>>..ctor
	|
	|-RVA: 0x2AD4A00 Offset: 0x2AD0A00 VA: 0x2AD4A00
	|-List<ValueTuple<short, short>>..ctor
	|
	|-RVA: 0x2AD7048 Offset: 0x2AD3048 VA: 0x2AD7048
	|-List<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2AD9680 Offset: 0x2AD5680 VA: 0x2AD9680
	|-List<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x2ADBE00 Offset: 0x2AD7E00 VA: 0x2ADBE00
	|-List<ValueTuple<Int32Enum, float>>..ctor
	|
	|-RVA: 0x2ADE438 Offset: 0x2ADA438 VA: 0x2ADE438
	|-List<ValueTuple<Vector3, Vector3>>..ctor
	|
	|-RVA: 0x2AE0EF0 Offset: 0x2ADCEF0 VA: 0x2AE0EF0
	|-List<ArchetypeUid>..ctor
	|
	|-RVA: 0x2AE3528 Offset: 0x2ADF528 VA: 0x2AE3528
	|-List<bool>..ctor
	|
	|-RVA: 0x2AE5BA0 Offset: 0x2AE1BA0 VA: 0x2AE5BA0
	|-List<byte>..ctor
	|
	|-RVA: 0x2AE81DC Offset: 0x2AE41DC VA: 0x2AE81DC
	|-List<ByteEnum>..ctor
	|
	|-RVA: 0x2AEA818 Offset: 0x2AE6818 VA: 0x2AEA818
	|-List<char>..ctor
	|
	|-RVA: 0x2AECE50 Offset: 0x2AE8E50 VA: 0x2AECE50
	|-List<Color>..ctor
	|
	|-RVA: 0x2AEF590 Offset: 0x2AEB590 VA: 0x2AEF590
	|-List<Color32>..ctor
	|
	|-RVA: 0x2AF1BD8 Offset: 0x2AEDBD8 VA: 0x2AF1BD8
	|-List<DateTime>..ctor
	|
	|-RVA: 0x2AF4210 Offset: 0x2AF0210 VA: 0x2AF4210
	|-List<DateTimeOffset>..ctor
	|
	|-RVA: 0x2AF68A8 Offset: 0x2AF28A8 VA: 0x2AF68A8
	|-List<Decimal>..ctor
	|
	|-RVA: 0x2AF8FB8 Offset: 0x2AF4FB8 VA: 0x2AF8FB8
	|-List<DefencePoint2>..ctor
	|
	|-RVA: 0x2AFB5F0 Offset: 0x2AF75F0 VA: 0x2AFB5F0
	|-List<double>..ctor
	|
	|-RVA: 0x2AFDC34 Offset: 0x2AF9C34 VA: 0x2AFDC34
	|-List<EventSummary>..ctor
	|
	|-RVA: 0x2B003B4 Offset: 0x2AFC3B4 VA: 0x2B003B4
	|-List<short>..ctor
	|
	|-RVA: 0x2B029EC Offset: 0x2AFE9EC VA: 0x2B029EC
	|-List<Int16Enum>..ctor
	|
	|-RVA: 0x2B05024 Offset: 0x2B01024 VA: 0x2B05024
	|-List<int>..ctor
	|
	|-RVA: 0x2B07658 Offset: 0x2B03658 VA: 0x2B07658
	|-List<Int32Enum>..ctor
	|
	|-RVA: 0x2B09C8C Offset: 0x2B05C8C VA: 0x2B09C8C
	|-List<long>..ctor
	|
	|-RVA: 0x2B0C2C0 Offset: 0x2B082C0 VA: 0x2B0C2C0
	|-List<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x2B0EA40 Offset: 0x2B0AA40 VA: 0x2B0EA40
	|-List<JsonPosition>..ctor
	|
	|-RVA: 0x2B1161C Offset: 0x2B0D61C VA: 0x2B1161C
	|-List<MaterialSearchData>..ctor
	|
	|-RVA: 0x2B13CB4 Offset: 0x2B0FCB4 VA: 0x2B13CB4
	|-List<MobActionTargetData>..ctor
	|
	|-RVA: 0x2B1676C Offset: 0x2B1276C VA: 0x2B1676C
	|-List<MobIconLabelData>..ctor
	|
	|-RVA: 0x2B19348 Offset: 0x2B15348 VA: 0x2B19348
	|-List<object>..ctor
	|
	|-RVA: 0x2B1BA08 Offset: 0x2B17A08 VA: 0x2B1BA08
	|-List<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x2B1E610 Offset: 0x2B1A610 VA: 0x2B1E610
	|-List<PlayerLoopSystemInternal>..ctor
	|
	|-RVA: 0x2B21218 Offset: 0x2B1D218 VA: 0x2B21218
	|-List<RangePositionInfo>..ctor
	|
	|-RVA: 0x2B23998 Offset: 0x2B1F998 VA: 0x2B23998
	|-List<ReinforceCristaData>..ctor
	|
	|-RVA: 0x2B260FC Offset: 0x2B220FC VA: 0x2B260FC
	|-List<sbyte>..ctor
	|
	|-RVA: 0x2B28738 Offset: 0x2B24738 VA: 0x2B28738
	|-List<float>..ctor
	|
	|-RVA: 0x2B2AD7C Offset: 0x2B26D7C VA: 0x2B2AD7C
	|-List<SkillIdData>..ctor
	|
	|-RVA: 0x2B2D3B4 Offset: 0x2B293B4 VA: 0x2B2D3B4
	|-List<TimeSpan>..ctor
	|
	|-RVA: 0x2B53DCC Offset: 0x2B4FDCC VA: 0x2B53DCC
	|-List<ushort>..ctor
	|
	|-RVA: 0x2B56404 Offset: 0x2B52404 VA: 0x2B56404
	|-List<uint>..ctor
	|
	|-RVA: 0x2B58A38 Offset: 0x2B54A38 VA: 0x2B58A38
	|-List<ulong>..ctor
	|
	|-RVA: 0x2B5B06C Offset: 0x2B5706C VA: 0x2B5B06C
	|-List<Vector2>..ctor
	|
	|-RVA: 0x2B5D718 Offset: 0x2B59718 VA: 0x2B5D718
	|-List<Vector3>..ctor
	|
	|-RVA: 0x2B5FEA4 Offset: 0x2B5BEA4 VA: 0x2B5FEA4
	|-List<X509ChainStatus>..ctor
	|
	|-RVA: 0x2B62624 Offset: 0x2B5E624 VA: 0x2B62624
	|-List<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2B66030 Offset: 0x2B62030 VA: 0x2B66030
	|-List<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x2B687B0 Offset: 0x2B647B0 VA: 0x2B687B0
	|-List<BoneClip.MotionKeyFrame>..ctor
	|
	|-RVA: 0x2B6B368 Offset: 0x2B67368 VA: 0x2B6B368
	|-List<HouseRecipeManager.RecipeData>..ctor
	|
	|-RVA: 0x2B6DF4C Offset: 0x2B69F4C VA: 0x2B6DF4C
	|-List<KadarElexioBuf.SkillIdData>..ctor
	|
	|-RVA: 0x2B70584 Offset: 0x2B6C584 VA: 0x2B70584
	|-List<MissionTextManagerData.CheckIKeywordtemData>..ctor
	|
	|-RVA: 0x2B72CE8 Offset: 0x2B6ECE8 VA: 0x2B72CE8
	|-List<MissionTextManagerData.PickUpFieldData>..ctor
	|
	|-RVA: 0x2B7544C Offset: 0x2B7144C VA: 0x2B7544C
	|-List<MobaRoomData.MobaAbilityMasterData>..ctor
	|
	|-RVA: 0x2B77AE4 Offset: 0x2B73AE4 VA: 0x2B77AE4
	|-List<NewWaveRoomData.Spotlight>..ctor
	|
	|-RVA: 0x2B7A4C4 Offset: 0x2B764C4 VA: 0x2B7A4C4
	|-List<NguiDynamicFontController.ApplyTextureInfo>..ctor
	|
	|-RVA: 0x2B7CC44 Offset: 0x2B78C44 VA: 0x2B7CC44
	|-List<RegexCharClass.SingleRange>..ctor
	|
	|-RVA: 0x2B7F28C Offset: 0x2B7B28C VA: 0x2B7F28C
	|-List<SocialAchievementData.LinkData>..ctor
	|
	|-RVA: 0x2B81A0C Offset: 0x2B7DA0C VA: 0x2B81A0C
	|-List<TrophyManager.TrophyData>..ctor
	|
	|-RVA: 0x2B84044 Offset: 0x2B80044 VA: 0x2B84044
	|-List<UIEventMenuButton.MessageButtonData>..ctor
	|
	|-RVA: 0x2B86C28 Offset: 0x2B82C28 VA: 0x2B86C28
	|-List<UIFieldMapPanel.PopData>..ctor
	|
	|-RVA: 0x2B89608 Offset: 0x2B85608 VA: 0x2B89608
	|-List<UIHouseAddressManager.Town>..ctor
	|
	|-RVA: 0x2B8BC40 Offset: 0x2B87C40 VA: 0x2B8BC40
	|-List<UIInfoWindow.LabelPosition>..ctor
	|
	|-RVA: 0x2B8E620 Offset: 0x2B8A620 VA: 0x2B8E620
	|-List<UIMainManager.DropItemData>..ctor
	|
	|-RVA: 0x2B90C58 Offset: 0x2B8CC58 VA: 0x2B90C58
	|-List<UIScenarioOrderPanel.MissionData>..ctor
	|
	|-RVA: 0x2B933D8 Offset: 0x2B8F3D8 VA: 0x2B933D8
	|-List<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x2B95FB4 Offset: 0x2B91FB4 VA: 0x2B95FB4
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0x2B98734 Offset: 0x2B94734 VA: 0x2B98734
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>..ctor
	|
	|-RVA: 0x2B9B014 Offset: 0x2B97014 VA: 0x2B9B014
	|-List<InstructionList.DebugView.InstructionView>..ctor
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD25C Offset: 0x2AA925C VA: 0x2AAD25C
	|-List<KeyValuePair<ArchetypeUid, object>>.set_Capacity
	|
	|-RVA: 0x2AAF9DC Offset: 0x2AAB9DC VA: 0x2AAF9DC
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.set_Capacity
	|
	|-RVA: 0x2AB2024 Offset: 0x2AAE024 VA: 0x2AB2024
	|-List<KeyValuePair<byte, byte>>.set_Capacity
	|
	|-RVA: 0x2AB49E8 Offset: 0x2AB09E8 VA: 0x2AB49E8
	|-List<KeyValuePair<byte, object>>.set_Capacity
	|
	|-RVA: 0x2AB7168 Offset: 0x2AB3168 VA: 0x2AB7168
	|-List<KeyValuePair<int, short>>.set_Capacity
	|
	|-RVA: 0x2AB97A0 Offset: 0x2AB57A0 VA: 0x2AB97A0
	|-List<KeyValuePair<int, int>>.set_Capacity
	|
	|-RVA: 0x2ABBDD8 Offset: 0x2AB7DD8 VA: 0x2ABBDD8
	|-List<KeyValuePair<int, object>>.set_Capacity
	|
	|-RVA: 0x2ABE558 Offset: 0x2ABA558 VA: 0x2ABE558
	|-List<KeyValuePair<Int32Enum, byte>>.set_Capacity
	|
	|-RVA: 0x2AC0B90 Offset: 0x2ABCB90 VA: 0x2AC0B90
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.set_Capacity
	|
	|-RVA: 0x2AC3690 Offset: 0x2ABF690 VA: 0x2AC3690
	|-List<KeyValuePair<Int32Enum, int>>.set_Capacity
	|
	|-RVA: 0x2AC5CC8 Offset: 0x2AC1CC8 VA: 0x2AC5CC8
	|-List<KeyValuePair<Int32Enum, object>>.set_Capacity
	|
	|-RVA: 0x2AC8448 Offset: 0x2AC4448 VA: 0x2AC8448
	|-List<KeyValuePair<object, int>>.set_Capacity
	|
	|-RVA: 0x2ACABC8 Offset: 0x2AC6BC8 VA: 0x2ACABC8
	|-List<KeyValuePair<object, float>>.set_Capacity
	|
	|-RVA: 0x2ACD348 Offset: 0x2AC9348 VA: 0x2ACD348
	|-List<KeyValuePair<float, object>>.set_Capacity
	|
	|-RVA: 0x2ACFAC8 Offset: 0x2ACBAC8 VA: 0x2ACFAC8
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.set_Capacity
	|
	|-RVA: 0x2AD24F4 Offset: 0x2ACE4F4 VA: 0x2AD24F4
	|-List<StructMultiKey<object, object>>.set_Capacity
	|
	|-RVA: 0x2AD4C74 Offset: 0x2AD0C74 VA: 0x2AD4C74
	|-List<ValueTuple<short, short>>.set_Capacity
	|
	|-RVA: 0x2AD72BC Offset: 0x2AD32BC VA: 0x2AD72BC
	|-List<ValueTuple<int, int>>.set_Capacity
	|
	|-RVA: 0x2AD98F4 Offset: 0x2AD58F4 VA: 0x2AD98F4
	|-List<ValueTuple<int, object>>.set_Capacity
	|
	|-RVA: 0x2ADC074 Offset: 0x2AD8074 VA: 0x2ADC074
	|-List<ValueTuple<Int32Enum, float>>.set_Capacity
	|
	|-RVA: 0x2ADE6AC Offset: 0x2ADA6AC VA: 0x2ADE6AC
	|-List<ValueTuple<Vector3, Vector3>>.set_Capacity
	|
	|-RVA: 0x2AE1164 Offset: 0x2ADD164 VA: 0x2AE1164
	|-List<ArchetypeUid>.set_Capacity
	|
	|-RVA: 0x2AE379C Offset: 0x2ADF79C VA: 0x2AE379C
	|-List<bool>.set_Capacity
	|
	|-RVA: 0x2AE5E14 Offset: 0x2AE1E14 VA: 0x2AE5E14
	|-List<byte>.set_Capacity
	|
	|-RVA: 0x2AE8450 Offset: 0x2AE4450 VA: 0x2AE8450
	|-List<ByteEnum>.set_Capacity
	|
	|-RVA: 0x2AEAA8C Offset: 0x2AE6A8C VA: 0x2AEAA8C
	|-List<char>.set_Capacity
	|
	|-RVA: 0x2AED0C4 Offset: 0x2AE90C4 VA: 0x2AED0C4
	|-List<Color>.set_Capacity
	|
	|-RVA: 0x2AEF804 Offset: 0x2AEB804 VA: 0x2AEF804
	|-List<Color32>.set_Capacity
	|
	|-RVA: 0x2AF1E4C Offset: 0x2AEDE4C VA: 0x2AF1E4C
	|-List<DateTime>.set_Capacity
	|
	|-RVA: 0x2AF4484 Offset: 0x2AF0484 VA: 0x2AF4484
	|-List<DateTimeOffset>.set_Capacity
	|
	|-RVA: 0x2AF6B1C Offset: 0x2AF2B1C VA: 0x2AF6B1C
	|-List<Decimal>.set_Capacity
	|
	|-RVA: 0x2AF922C Offset: 0x2AF522C VA: 0x2AF922C
	|-List<DefencePoint2>.set_Capacity
	|
	|-RVA: 0x2AFB864 Offset: 0x2AF7864 VA: 0x2AFB864
	|-List<double>.set_Capacity
	|
	|-RVA: 0x2AFDEA8 Offset: 0x2AF9EA8 VA: 0x2AFDEA8
	|-List<EventSummary>.set_Capacity
	|
	|-RVA: 0x2B00628 Offset: 0x2AFC628 VA: 0x2B00628
	|-List<short>.set_Capacity
	|
	|-RVA: 0x2B02C60 Offset: 0x2AFEC60 VA: 0x2B02C60
	|-List<Int16Enum>.set_Capacity
	|
	|-RVA: 0x2B05298 Offset: 0x2B01298 VA: 0x2B05298
	|-List<int>.set_Capacity
	|
	|-RVA: 0x2B078CC Offset: 0x2B038CC VA: 0x2B078CC
	|-List<Int32Enum>.set_Capacity
	|
	|-RVA: 0x2B09F00 Offset: 0x2B05F00 VA: 0x2B09F00
	|-List<long>.set_Capacity
	|
	|-RVA: 0x2B0C534 Offset: 0x2B08534 VA: 0x2B0C534
	|-List<InterpretedFrameInfo>.set_Capacity
	|
	|-RVA: 0x2B0ECB4 Offset: 0x2B0ACB4 VA: 0x2B0ECB4
	|-List<JsonPosition>.set_Capacity
	|
	|-RVA: 0x2B11890 Offset: 0x2B0D890 VA: 0x2B11890
	|-List<MaterialSearchData>.set_Capacity
	|
	|-RVA: 0x2B13F28 Offset: 0x2B0FF28 VA: 0x2B13F28
	|-List<MobActionTargetData>.set_Capacity
	|
	|-RVA: 0x2B169E0 Offset: 0x2B129E0 VA: 0x2B169E0
	|-List<MobIconLabelData>.set_Capacity
	|
	|-RVA: 0x2B195BC Offset: 0x2B155BC VA: 0x2B195BC
	|-List<object>.set_Capacity
	|
	|-RVA: 0x2B1BC7C Offset: 0x2B17C7C VA: 0x2B1BC7C
	|-List<PlayerLoopSystem>.set_Capacity
	|
	|-RVA: 0x2B1E884 Offset: 0x2B1A884 VA: 0x2B1E884
	|-List<PlayerLoopSystemInternal>.set_Capacity
	|
	|-RVA: 0x2B2148C Offset: 0x2B1D48C VA: 0x2B2148C
	|-List<RangePositionInfo>.set_Capacity
	|
	|-RVA: 0x2B23C0C Offset: 0x2B1FC0C VA: 0x2B23C0C
	|-List<ReinforceCristaData>.set_Capacity
	|
	|-RVA: 0x2B26370 Offset: 0x2B22370 VA: 0x2B26370
	|-List<sbyte>.set_Capacity
	|
	|-RVA: 0x2B289AC Offset: 0x2B249AC VA: 0x2B289AC
	|-List<float>.set_Capacity
	|
	|-RVA: 0x2B2AFF0 Offset: 0x2B26FF0 VA: 0x2B2AFF0
	|-List<SkillIdData>.set_Capacity
	|
	|-RVA: 0x2B2D628 Offset: 0x2B29628 VA: 0x2B2D628
	|-List<TimeSpan>.set_Capacity
	|
	|-RVA: 0x2B54040 Offset: 0x2B50040 VA: 0x2B54040
	|-List<ushort>.set_Capacity
	|
	|-RVA: 0x2B56678 Offset: 0x2B52678 VA: 0x2B56678
	|-List<uint>.set_Capacity
	|
	|-RVA: 0x2B58CAC Offset: 0x2B54CAC VA: 0x2B58CAC
	|-List<ulong>.set_Capacity
	|
	|-RVA: 0x2B5B2E0 Offset: 0x2B572E0 VA: 0x2B5B2E0
	|-List<Vector2>.set_Capacity
	|
	|-RVA: 0x2B5D98C Offset: 0x2B5998C VA: 0x2B5D98C
	|-List<Vector3>.set_Capacity
	|
	|-RVA: 0x2B60118 Offset: 0x2B5C118 VA: 0x2B60118
	|-List<X509ChainStatus>.set_Capacity
	|
	|-RVA: 0x2B6289C Offset: 0x2B5E89C VA: 0x2B6289C
	|-List<__Il2CppFullySharedGenericType>.set_Capacity
	|
	|-RVA: 0x2B662A4 Offset: 0x2B622A4 VA: 0x2B662A4
	|-List<BeforeRenderHelper.OrderBlock>.set_Capacity
	|
	|-RVA: 0x2B68A24 Offset: 0x2B64A24 VA: 0x2B68A24
	|-List<BoneClip.MotionKeyFrame>.set_Capacity
	|
	|-RVA: 0x2B6B5DC Offset: 0x2B675DC VA: 0x2B6B5DC
	|-List<HouseRecipeManager.RecipeData>.set_Capacity
	|
	|-RVA: 0x2B6E1C0 Offset: 0x2B6A1C0 VA: 0x2B6E1C0
	|-List<KadarElexioBuf.SkillIdData>.set_Capacity
	|
	|-RVA: 0x2B707F8 Offset: 0x2B6C7F8 VA: 0x2B707F8
	|-List<MissionTextManagerData.CheckIKeywordtemData>.set_Capacity
	|
	|-RVA: 0x2B72F5C Offset: 0x2B6EF5C VA: 0x2B72F5C
	|-List<MissionTextManagerData.PickUpFieldData>.set_Capacity
	|
	|-RVA: 0x2B756C0 Offset: 0x2B716C0 VA: 0x2B756C0
	|-List<MobaRoomData.MobaAbilityMasterData>.set_Capacity
	|
	|-RVA: 0x2B77D58 Offset: 0x2B73D58 VA: 0x2B77D58
	|-List<NewWaveRoomData.Spotlight>.set_Capacity
	|
	|-RVA: 0x2B7A738 Offset: 0x2B76738 VA: 0x2B7A738
	|-List<NguiDynamicFontController.ApplyTextureInfo>.set_Capacity
	|
	|-RVA: 0x2B7CEB8 Offset: 0x2B78EB8 VA: 0x2B7CEB8
	|-List<RegexCharClass.SingleRange>.set_Capacity
	|
	|-RVA: 0x2B7F500 Offset: 0x2B7B500 VA: 0x2B7F500
	|-List<SocialAchievementData.LinkData>.set_Capacity
	|
	|-RVA: 0x2B81C80 Offset: 0x2B7DC80 VA: 0x2B81C80
	|-List<TrophyManager.TrophyData>.set_Capacity
	|
	|-RVA: 0x2B842B8 Offset: 0x2B802B8 VA: 0x2B842B8
	|-List<UIEventMenuButton.MessageButtonData>.set_Capacity
	|
	|-RVA: 0x2B86E9C Offset: 0x2B82E9C VA: 0x2B86E9C
	|-List<UIFieldMapPanel.PopData>.set_Capacity
	|
	|-RVA: 0x2B8987C Offset: 0x2B8587C VA: 0x2B8987C
	|-List<UIHouseAddressManager.Town>.set_Capacity
	|
	|-RVA: 0x2B8BEB4 Offset: 0x2B87EB4 VA: 0x2B8BEB4
	|-List<UIInfoWindow.LabelPosition>.set_Capacity
	|
	|-RVA: 0x2B8E894 Offset: 0x2B8A894 VA: 0x2B8E894
	|-List<UIMainManager.DropItemData>.set_Capacity
	|
	|-RVA: 0x2B90ECC Offset: 0x2B8CECC VA: 0x2B90ECC
	|-List<UIScenarioOrderPanel.MissionData>.set_Capacity
	|
	|-RVA: 0x2B9364C Offset: 0x2B8F64C VA: 0x2B9364C
	|-List<UnitySynchronizationContext.WorkRequest>.set_Capacity
	|
	|-RVA: 0x2B96228 Offset: 0x2B92228 VA: 0x2B96228
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.set_Capacity
	|
	|-RVA: 0x2B989A8 Offset: 0x2B949A8 VA: 0x2B989A8
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.set_Capacity
	|
	|-RVA: 0x2B9B288 Offset: 0x2B97288 VA: 0x2B9B288
	|-List<InstructionList.DebugView.InstructionView>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD370 Offset: 0x2AA9370 VA: 0x2AAD370
	|-List<KeyValuePair<ArchetypeUid, object>>.get_Count
	|
	|-RVA: 0x2AAFAF0 Offset: 0x2AABAF0 VA: 0x2AAFAF0
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.get_Count
	|
	|-RVA: 0x2AB2138 Offset: 0x2AAE138 VA: 0x2AB2138
	|-List<KeyValuePair<byte, byte>>.get_Count
	|
	|-RVA: 0x2AB4AFC Offset: 0x2AB0AFC VA: 0x2AB4AFC
	|-List<KeyValuePair<byte, object>>.get_Count
	|
	|-RVA: 0x2AB727C Offset: 0x2AB327C VA: 0x2AB727C
	|-List<KeyValuePair<int, short>>.get_Count
	|
	|-RVA: 0x2AB98B4 Offset: 0x2AB58B4 VA: 0x2AB98B4
	|-List<KeyValuePair<int, int>>.get_Count
	|
	|-RVA: 0x2ABBEEC Offset: 0x2AB7EEC VA: 0x2ABBEEC
	|-List<KeyValuePair<int, object>>.get_Count
	|
	|-RVA: 0x2ABE66C Offset: 0x2ABA66C VA: 0x2ABE66C
	|-List<KeyValuePair<Int32Enum, byte>>.get_Count
	|
	|-RVA: 0x2AC0CA4 Offset: 0x2ABCCA4 VA: 0x2AC0CA4
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.get_Count
	|
	|-RVA: 0x2AC37A4 Offset: 0x2ABF7A4 VA: 0x2AC37A4
	|-List<KeyValuePair<Int32Enum, int>>.get_Count
	|
	|-RVA: 0x2AC5DDC Offset: 0x2AC1DDC VA: 0x2AC5DDC
	|-List<KeyValuePair<Int32Enum, object>>.get_Count
	|
	|-RVA: 0x2AC855C Offset: 0x2AC455C VA: 0x2AC855C
	|-List<KeyValuePair<object, int>>.get_Count
	|
	|-RVA: 0x2ACACDC Offset: 0x2AC6CDC VA: 0x2ACACDC
	|-List<KeyValuePair<object, float>>.get_Count
	|
	|-RVA: 0x2ACD45C Offset: 0x2AC945C VA: 0x2ACD45C
	|-List<KeyValuePair<float, object>>.get_Count
	|
	|-RVA: 0x2ACFBDC Offset: 0x2ACBBDC VA: 0x2ACFBDC
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.get_Count
	|
	|-RVA: 0x2AD2608 Offset: 0x2ACE608 VA: 0x2AD2608
	|-List<StructMultiKey<object, object>>.get_Count
	|
	|-RVA: 0x2AD4D88 Offset: 0x2AD0D88 VA: 0x2AD4D88
	|-List<ValueTuple<short, short>>.get_Count
	|
	|-RVA: 0x2AD73D0 Offset: 0x2AD33D0 VA: 0x2AD73D0
	|-List<ValueTuple<int, int>>.get_Count
	|
	|-RVA: 0x2AD9A08 Offset: 0x2AD5A08 VA: 0x2AD9A08
	|-List<ValueTuple<int, object>>.get_Count
	|
	|-RVA: 0x2ADC188 Offset: 0x2AD8188 VA: 0x2ADC188
	|-List<ValueTuple<Int32Enum, float>>.get_Count
	|
	|-RVA: 0x2ADE7C0 Offset: 0x2ADA7C0 VA: 0x2ADE7C0
	|-List<ValueTuple<Vector3, Vector3>>.get_Count
	|
	|-RVA: 0x2AE1278 Offset: 0x2ADD278 VA: 0x2AE1278
	|-List<ArchetypeUid>.get_Count
	|
	|-RVA: 0x2AE38B0 Offset: 0x2ADF8B0 VA: 0x2AE38B0
	|-List<bool>.get_Count
	|
	|-RVA: 0x2AE5F28 Offset: 0x2AE1F28 VA: 0x2AE5F28
	|-List<byte>.get_Count
	|
	|-RVA: 0x2AE8564 Offset: 0x2AE4564 VA: 0x2AE8564
	|-List<ByteEnum>.get_Count
	|
	|-RVA: 0x2AEABA0 Offset: 0x2AE6BA0 VA: 0x2AEABA0
	|-List<char>.get_Count
	|
	|-RVA: 0x2AED1D8 Offset: 0x2AE91D8 VA: 0x2AED1D8
	|-List<Color>.get_Count
	|
	|-RVA: 0x2AEF918 Offset: 0x2AEB918 VA: 0x2AEF918
	|-List<Color32>.get_Count
	|
	|-RVA: 0x2AF1F60 Offset: 0x2AEDF60 VA: 0x2AF1F60
	|-List<DateTime>.get_Count
	|
	|-RVA: 0x2AF4598 Offset: 0x2AF0598 VA: 0x2AF4598
	|-List<DateTimeOffset>.get_Count
	|
	|-RVA: 0x2AF6C30 Offset: 0x2AF2C30 VA: 0x2AF6C30
	|-List<Decimal>.get_Count
	|
	|-RVA: 0x2AF9340 Offset: 0x2AF5340 VA: 0x2AF9340
	|-List<DefencePoint2>.get_Count
	|
	|-RVA: 0x2AFB978 Offset: 0x2AF7978 VA: 0x2AFB978
	|-List<double>.get_Count
	|
	|-RVA: 0x2AFDFBC Offset: 0x2AF9FBC VA: 0x2AFDFBC
	|-List<EventSummary>.get_Count
	|
	|-RVA: 0x2B0073C Offset: 0x2AFC73C VA: 0x2B0073C
	|-List<short>.get_Count
	|
	|-RVA: 0x2B02D74 Offset: 0x2AFED74 VA: 0x2B02D74
	|-List<Int16Enum>.get_Count
	|
	|-RVA: 0x2B053AC Offset: 0x2B013AC VA: 0x2B053AC
	|-List<int>.get_Count
	|
	|-RVA: 0x2B079E0 Offset: 0x2B039E0 VA: 0x2B079E0
	|-List<Int32Enum>.get_Count
	|
	|-RVA: 0x2B0A014 Offset: 0x2B06014 VA: 0x2B0A014
	|-List<long>.get_Count
	|
	|-RVA: 0x2B0C648 Offset: 0x2B08648 VA: 0x2B0C648
	|-List<InterpretedFrameInfo>.get_Count
	|
	|-RVA: 0x2B0EDC8 Offset: 0x2B0ADC8 VA: 0x2B0EDC8
	|-List<JsonPosition>.get_Count
	|
	|-RVA: 0x2B119A4 Offset: 0x2B0D9A4 VA: 0x2B119A4
	|-List<MaterialSearchData>.get_Count
	|
	|-RVA: 0x2B1403C Offset: 0x2B1003C VA: 0x2B1403C
	|-List<MobActionTargetData>.get_Count
	|
	|-RVA: 0x2B16AF4 Offset: 0x2B12AF4 VA: 0x2B16AF4
	|-List<MobIconLabelData>.get_Count
	|
	|-RVA: 0x2B196D0 Offset: 0x2B156D0 VA: 0x2B196D0
	|-List<object>.get_Count
	|
	|-RVA: 0x2B1BD90 Offset: 0x2B17D90 VA: 0x2B1BD90
	|-List<PlayerLoopSystem>.get_Count
	|
	|-RVA: 0x2B1E998 Offset: 0x2B1A998 VA: 0x2B1E998
	|-List<PlayerLoopSystemInternal>.get_Count
	|
	|-RVA: 0x2B215A0 Offset: 0x2B1D5A0 VA: 0x2B215A0
	|-List<RangePositionInfo>.get_Count
	|
	|-RVA: 0x2B23D20 Offset: 0x2B1FD20 VA: 0x2B23D20
	|-List<ReinforceCristaData>.get_Count
	|
	|-RVA: 0x2B26484 Offset: 0x2B22484 VA: 0x2B26484
	|-List<sbyte>.get_Count
	|
	|-RVA: 0x2B28AC0 Offset: 0x2B24AC0 VA: 0x2B28AC0
	|-List<float>.get_Count
	|
	|-RVA: 0x2B2B104 Offset: 0x2B27104 VA: 0x2B2B104
	|-List<SkillIdData>.get_Count
	|
	|-RVA: 0x2B2D73C Offset: 0x2B2973C VA: 0x2B2D73C
	|-List<TimeSpan>.get_Count
	|
	|-RVA: 0x2B54154 Offset: 0x2B50154 VA: 0x2B54154
	|-List<ushort>.get_Count
	|
	|-RVA: 0x2B5678C Offset: 0x2B5278C VA: 0x2B5678C
	|-List<uint>.get_Count
	|
	|-RVA: 0x2B58DC0 Offset: 0x2B54DC0 VA: 0x2B58DC0
	|-List<ulong>.get_Count
	|
	|-RVA: 0x2B5B3F4 Offset: 0x2B573F4 VA: 0x2B5B3F4
	|-List<Vector2>.get_Count
	|
	|-RVA: 0x2B5DAA0 Offset: 0x2B59AA0 VA: 0x2B5DAA0
	|-List<Vector3>.get_Count
	|
	|-RVA: 0x2B6022C Offset: 0x2B5C22C VA: 0x2B6022C
	|-List<X509ChainStatus>.get_Count
	|
	|-RVA: 0x2B629B0 Offset: 0x2B5E9B0 VA: 0x2B629B0
	|-List<__Il2CppFullySharedGenericType>.get_Count
	|
	|-RVA: 0x2B663B8 Offset: 0x2B623B8 VA: 0x2B663B8
	|-List<BeforeRenderHelper.OrderBlock>.get_Count
	|
	|-RVA: 0x2B68B38 Offset: 0x2B64B38 VA: 0x2B68B38
	|-List<BoneClip.MotionKeyFrame>.get_Count
	|
	|-RVA: 0x2B6B6F0 Offset: 0x2B676F0 VA: 0x2B6B6F0
	|-List<HouseRecipeManager.RecipeData>.get_Count
	|
	|-RVA: 0x2B6E2D4 Offset: 0x2B6A2D4 VA: 0x2B6E2D4
	|-List<KadarElexioBuf.SkillIdData>.get_Count
	|
	|-RVA: 0x2B7090C Offset: 0x2B6C90C VA: 0x2B7090C
	|-List<MissionTextManagerData.CheckIKeywordtemData>.get_Count
	|
	|-RVA: 0x2B73070 Offset: 0x2B6F070 VA: 0x2B73070
	|-List<MissionTextManagerData.PickUpFieldData>.get_Count
	|
	|-RVA: 0x2B757D4 Offset: 0x2B717D4 VA: 0x2B757D4
	|-List<MobaRoomData.MobaAbilityMasterData>.get_Count
	|
	|-RVA: 0x2B77E6C Offset: 0x2B73E6C VA: 0x2B77E6C
	|-List<NewWaveRoomData.Spotlight>.get_Count
	|
	|-RVA: 0x2B7A84C Offset: 0x2B7684C VA: 0x2B7A84C
	|-List<NguiDynamicFontController.ApplyTextureInfo>.get_Count
	|
	|-RVA: 0x2B7CFCC Offset: 0x2B78FCC VA: 0x2B7CFCC
	|-List<RegexCharClass.SingleRange>.get_Count
	|
	|-RVA: 0x2B7F614 Offset: 0x2B7B614 VA: 0x2B7F614
	|-List<SocialAchievementData.LinkData>.get_Count
	|
	|-RVA: 0x2B81D94 Offset: 0x2B7DD94 VA: 0x2B81D94
	|-List<TrophyManager.TrophyData>.get_Count
	|
	|-RVA: 0x2B843CC Offset: 0x2B803CC VA: 0x2B843CC
	|-List<UIEventMenuButton.MessageButtonData>.get_Count
	|
	|-RVA: 0x2B86FB0 Offset: 0x2B82FB0 VA: 0x2B86FB0
	|-List<UIFieldMapPanel.PopData>.get_Count
	|
	|-RVA: 0x2B89990 Offset: 0x2B85990 VA: 0x2B89990
	|-List<UIHouseAddressManager.Town>.get_Count
	|
	|-RVA: 0x2B8BFC8 Offset: 0x2B87FC8 VA: 0x2B8BFC8
	|-List<UIInfoWindow.LabelPosition>.get_Count
	|
	|-RVA: 0x2B8E9A8 Offset: 0x2B8A9A8 VA: 0x2B8E9A8
	|-List<UIMainManager.DropItemData>.get_Count
	|
	|-RVA: 0x2B90FE0 Offset: 0x2B8CFE0 VA: 0x2B90FE0
	|-List<UIScenarioOrderPanel.MissionData>.get_Count
	|
	|-RVA: 0x2B93760 Offset: 0x2B8F760 VA: 0x2B93760
	|-List<UnitySynchronizationContext.WorkRequest>.get_Count
	|
	|-RVA: 0x2B9633C Offset: 0x2B9233C VA: 0x2B9633C
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Count
	|
	|-RVA: 0x2B98ABC Offset: 0x2B94ABC VA: 0x2B98ABC
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.get_Count
	|
	|-RVA: 0x2B9B39C Offset: 0x2B9739C VA: 0x2B9B39C
	|-List<InstructionList.DebugView.InstructionView>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD378 Offset: 0x2AA9378 VA: 0x2AAD378
	|-List<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AAFAF8 Offset: 0x2AABAF8 VA: 0x2AAFAF8
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AB2140 Offset: 0x2AAE140 VA: 0x2AB2140
	|-List<KeyValuePair<byte, byte>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AB4B04 Offset: 0x2AB0B04 VA: 0x2AB4B04
	|-List<KeyValuePair<byte, object>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AB7284 Offset: 0x2AB3284 VA: 0x2AB7284
	|-List<KeyValuePair<int, short>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AB98BC Offset: 0x2AB58BC VA: 0x2AB98BC
	|-List<KeyValuePair<int, int>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2ABBEF4 Offset: 0x2AB7EF4 VA: 0x2ABBEF4
	|-List<KeyValuePair<int, object>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2ABE674 Offset: 0x2ABA674 VA: 0x2ABE674
	|-List<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AC0CAC Offset: 0x2ABCCAC VA: 0x2AC0CAC
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AC37AC Offset: 0x2ABF7AC VA: 0x2AC37AC
	|-List<KeyValuePair<Int32Enum, int>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AC5DE4 Offset: 0x2AC1DE4 VA: 0x2AC5DE4
	|-List<KeyValuePair<Int32Enum, object>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AC8564 Offset: 0x2AC4564 VA: 0x2AC8564
	|-List<KeyValuePair<object, int>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2ACACE4 Offset: 0x2AC6CE4 VA: 0x2ACACE4
	|-List<KeyValuePair<object, float>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2ACD464 Offset: 0x2AC9464 VA: 0x2ACD464
	|-List<KeyValuePair<float, object>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2ACFBE4 Offset: 0x2ACBBE4 VA: 0x2ACFBE4
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AD2610 Offset: 0x2ACE610 VA: 0x2AD2610
	|-List<StructMultiKey<object, object>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AD4D90 Offset: 0x2AD0D90 VA: 0x2AD4D90
	|-List<ValueTuple<short, short>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AD73D8 Offset: 0x2AD33D8 VA: 0x2AD73D8
	|-List<ValueTuple<int, int>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AD9A10 Offset: 0x2AD5A10 VA: 0x2AD9A10
	|-List<ValueTuple<int, object>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2ADC190 Offset: 0x2AD8190 VA: 0x2ADC190
	|-List<ValueTuple<Int32Enum, float>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2ADE7C8 Offset: 0x2ADA7C8 VA: 0x2ADE7C8
	|-List<ValueTuple<Vector3, Vector3>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AE1280 Offset: 0x2ADD280 VA: 0x2AE1280
	|-List<ArchetypeUid>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AE38B8 Offset: 0x2ADF8B8 VA: 0x2AE38B8
	|-List<bool>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AE5F30 Offset: 0x2AE1F30 VA: 0x2AE5F30
	|-List<byte>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AE856C Offset: 0x2AE456C VA: 0x2AE856C
	|-List<ByteEnum>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AEABA8 Offset: 0x2AE6BA8 VA: 0x2AEABA8
	|-List<char>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AED1E0 Offset: 0x2AE91E0 VA: 0x2AED1E0
	|-List<Color>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AEF920 Offset: 0x2AEB920 VA: 0x2AEF920
	|-List<Color32>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AF1F68 Offset: 0x2AEDF68 VA: 0x2AF1F68
	|-List<DateTime>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AF45A0 Offset: 0x2AF05A0 VA: 0x2AF45A0
	|-List<DateTimeOffset>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AF6C38 Offset: 0x2AF2C38 VA: 0x2AF6C38
	|-List<Decimal>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AF9348 Offset: 0x2AF5348 VA: 0x2AF9348
	|-List<DefencePoint2>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AFB980 Offset: 0x2AF7980 VA: 0x2AFB980
	|-List<double>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2AFDFC4 Offset: 0x2AF9FC4 VA: 0x2AFDFC4
	|-List<EventSummary>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B00744 Offset: 0x2AFC744 VA: 0x2B00744
	|-List<short>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B02D7C Offset: 0x2AFED7C VA: 0x2B02D7C
	|-List<Int16Enum>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B053B4 Offset: 0x2B013B4 VA: 0x2B053B4
	|-List<int>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B079E8 Offset: 0x2B039E8 VA: 0x2B079E8
	|-List<Int32Enum>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B0A01C Offset: 0x2B0601C VA: 0x2B0A01C
	|-List<long>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B0C650 Offset: 0x2B08650 VA: 0x2B0C650
	|-List<InterpretedFrameInfo>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B0EDD0 Offset: 0x2B0ADD0 VA: 0x2B0EDD0
	|-List<JsonPosition>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B119AC Offset: 0x2B0D9AC VA: 0x2B119AC
	|-List<MaterialSearchData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B14044 Offset: 0x2B10044 VA: 0x2B14044
	|-List<MobActionTargetData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B16AFC Offset: 0x2B12AFC VA: 0x2B16AFC
	|-List<MobIconLabelData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B196D8 Offset: 0x2B156D8 VA: 0x2B196D8
	|-List<object>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B1BD98 Offset: 0x2B17D98 VA: 0x2B1BD98
	|-List<PlayerLoopSystem>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B1E9A0 Offset: 0x2B1A9A0 VA: 0x2B1E9A0
	|-List<PlayerLoopSystemInternal>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B215A8 Offset: 0x2B1D5A8 VA: 0x2B215A8
	|-List<RangePositionInfo>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B23D28 Offset: 0x2B1FD28 VA: 0x2B23D28
	|-List<ReinforceCristaData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B2648C Offset: 0x2B2248C VA: 0x2B2648C
	|-List<sbyte>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B28AC8 Offset: 0x2B24AC8 VA: 0x2B28AC8
	|-List<float>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B2B10C Offset: 0x2B2710C VA: 0x2B2B10C
	|-List<SkillIdData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B2D744 Offset: 0x2B29744 VA: 0x2B2D744
	|-List<TimeSpan>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B5415C Offset: 0x2B5015C VA: 0x2B5415C
	|-List<ushort>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B56794 Offset: 0x2B52794 VA: 0x2B56794
	|-List<uint>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B58DC8 Offset: 0x2B54DC8 VA: 0x2B58DC8
	|-List<ulong>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B5B3FC Offset: 0x2B573FC VA: 0x2B5B3FC
	|-List<Vector2>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B5DAA8 Offset: 0x2B59AA8 VA: 0x2B5DAA8
	|-List<Vector3>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B60234 Offset: 0x2B5C234 VA: 0x2B60234
	|-List<X509ChainStatus>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B629B8 Offset: 0x2B5E9B8 VA: 0x2B629B8
	|-List<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B663C0 Offset: 0x2B623C0 VA: 0x2B663C0
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B68B40 Offset: 0x2B64B40 VA: 0x2B68B40
	|-List<BoneClip.MotionKeyFrame>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B6B6F8 Offset: 0x2B676F8 VA: 0x2B6B6F8
	|-List<HouseRecipeManager.RecipeData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B6E2DC Offset: 0x2B6A2DC VA: 0x2B6E2DC
	|-List<KadarElexioBuf.SkillIdData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B70914 Offset: 0x2B6C914 VA: 0x2B70914
	|-List<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B73078 Offset: 0x2B6F078 VA: 0x2B73078
	|-List<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B757DC Offset: 0x2B717DC VA: 0x2B757DC
	|-List<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B77E74 Offset: 0x2B73E74 VA: 0x2B77E74
	|-List<NewWaveRoomData.Spotlight>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B7A854 Offset: 0x2B76854 VA: 0x2B7A854
	|-List<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B7CFD4 Offset: 0x2B78FD4 VA: 0x2B7CFD4
	|-List<RegexCharClass.SingleRange>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B7F61C Offset: 0x2B7B61C VA: 0x2B7F61C
	|-List<SocialAchievementData.LinkData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B81D9C Offset: 0x2B7DD9C VA: 0x2B81D9C
	|-List<TrophyManager.TrophyData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B843D4 Offset: 0x2B803D4 VA: 0x2B843D4
	|-List<UIEventMenuButton.MessageButtonData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B86FB8 Offset: 0x2B82FB8 VA: 0x2B86FB8
	|-List<UIFieldMapPanel.PopData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B89998 Offset: 0x2B85998 VA: 0x2B89998
	|-List<UIHouseAddressManager.Town>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B8BFD0 Offset: 0x2B87FD0 VA: 0x2B8BFD0
	|-List<UIInfoWindow.LabelPosition>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B8E9B0 Offset: 0x2B8A9B0 VA: 0x2B8E9B0
	|-List<UIMainManager.DropItemData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B90FE8 Offset: 0x2B8CFE8 VA: 0x2B90FE8
	|-List<UIScenarioOrderPanel.MissionData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B93768 Offset: 0x2B8F768 VA: 0x2B93768
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B96344 Offset: 0x2B92344 VA: 0x2B96344
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B98AC4 Offset: 0x2B94AC4 VA: 0x2B98AC4
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2B9B3A4 Offset: 0x2B973A4 VA: 0x2B9B3A4
	|-List<InstructionList.DebugView.InstructionView>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD380 Offset: 0x2AA9380 VA: 0x2AAD380
	|-List<KeyValuePair<ArchetypeUid, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AAFB00 Offset: 0x2AABB00 VA: 0x2AAFB00
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AB2148 Offset: 0x2AAE148 VA: 0x2AB2148
	|-List<KeyValuePair<byte, byte>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AB4B0C Offset: 0x2AB0B0C VA: 0x2AB4B0C
	|-List<KeyValuePair<byte, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AB728C Offset: 0x2AB328C VA: 0x2AB728C
	|-List<KeyValuePair<int, short>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AB98C4 Offset: 0x2AB58C4 VA: 0x2AB98C4
	|-List<KeyValuePair<int, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2ABBEFC Offset: 0x2AB7EFC VA: 0x2ABBEFC
	|-List<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2ABE67C Offset: 0x2ABA67C VA: 0x2ABE67C
	|-List<KeyValuePair<Int32Enum, byte>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AC0CB4 Offset: 0x2ABCCB4 VA: 0x2AC0CB4
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AC37B4 Offset: 0x2ABF7B4 VA: 0x2AC37B4
	|-List<KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AC5DEC Offset: 0x2AC1DEC VA: 0x2AC5DEC
	|-List<KeyValuePair<Int32Enum, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AC856C Offset: 0x2AC456C VA: 0x2AC856C
	|-List<KeyValuePair<object, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2ACACEC Offset: 0x2AC6CEC VA: 0x2ACACEC
	|-List<KeyValuePair<object, float>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2ACD46C Offset: 0x2AC946C VA: 0x2ACD46C
	|-List<KeyValuePair<float, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2ACFBEC Offset: 0x2ACBBEC VA: 0x2ACFBEC
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AD2618 Offset: 0x2ACE618 VA: 0x2AD2618
	|-List<StructMultiKey<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AD4D98 Offset: 0x2AD0D98 VA: 0x2AD4D98
	|-List<ValueTuple<short, short>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AD73E0 Offset: 0x2AD33E0 VA: 0x2AD73E0
	|-List<ValueTuple<int, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AD9A18 Offset: 0x2AD5A18 VA: 0x2AD9A18
	|-List<ValueTuple<int, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2ADC198 Offset: 0x2AD8198 VA: 0x2ADC198
	|-List<ValueTuple<Int32Enum, float>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2ADE7D0 Offset: 0x2ADA7D0 VA: 0x2ADE7D0
	|-List<ValueTuple<Vector3, Vector3>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AE1288 Offset: 0x2ADD288 VA: 0x2AE1288
	|-List<ArchetypeUid>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AE38C0 Offset: 0x2ADF8C0 VA: 0x2AE38C0
	|-List<bool>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AE5F38 Offset: 0x2AE1F38 VA: 0x2AE5F38
	|-List<byte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AE8574 Offset: 0x2AE4574 VA: 0x2AE8574
	|-List<ByteEnum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AEABB0 Offset: 0x2AE6BB0 VA: 0x2AEABB0
	|-List<char>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AED1E8 Offset: 0x2AE91E8 VA: 0x2AED1E8
	|-List<Color>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AEF928 Offset: 0x2AEB928 VA: 0x2AEF928
	|-List<Color32>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AF1F70 Offset: 0x2AEDF70 VA: 0x2AF1F70
	|-List<DateTime>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AF45A8 Offset: 0x2AF05A8 VA: 0x2AF45A8
	|-List<DateTimeOffset>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AF6C40 Offset: 0x2AF2C40 VA: 0x2AF6C40
	|-List<Decimal>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AF9350 Offset: 0x2AF5350 VA: 0x2AF9350
	|-List<DefencePoint2>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AFB988 Offset: 0x2AF7988 VA: 0x2AFB988
	|-List<double>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AFDFCC Offset: 0x2AF9FCC VA: 0x2AFDFCC
	|-List<EventSummary>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B0074C Offset: 0x2AFC74C VA: 0x2B0074C
	|-List<short>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B02D84 Offset: 0x2AFED84 VA: 0x2B02D84
	|-List<Int16Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B053BC Offset: 0x2B013BC VA: 0x2B053BC
	|-List<int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B079F0 Offset: 0x2B039F0 VA: 0x2B079F0
	|-List<Int32Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B0A024 Offset: 0x2B06024 VA: 0x2B0A024
	|-List<long>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B0C658 Offset: 0x2B08658 VA: 0x2B0C658
	|-List<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B0EDD8 Offset: 0x2B0ADD8 VA: 0x2B0EDD8
	|-List<JsonPosition>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B119B4 Offset: 0x2B0D9B4 VA: 0x2B119B4
	|-List<MaterialSearchData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B1404C Offset: 0x2B1004C VA: 0x2B1404C
	|-List<MobActionTargetData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B16B04 Offset: 0x2B12B04 VA: 0x2B16B04
	|-List<MobIconLabelData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B196E0 Offset: 0x2B156E0 VA: 0x2B196E0
	|-List<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B1BDA0 Offset: 0x2B17DA0 VA: 0x2B1BDA0
	|-List<PlayerLoopSystem>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B1E9A8 Offset: 0x2B1A9A8 VA: 0x2B1E9A8
	|-List<PlayerLoopSystemInternal>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B215B0 Offset: 0x2B1D5B0 VA: 0x2B215B0
	|-List<RangePositionInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B23D30 Offset: 0x2B1FD30 VA: 0x2B23D30
	|-List<ReinforceCristaData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B26494 Offset: 0x2B22494 VA: 0x2B26494
	|-List<sbyte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B28AD0 Offset: 0x2B24AD0 VA: 0x2B28AD0
	|-List<float>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B2B114 Offset: 0x2B27114 VA: 0x2B2B114
	|-List<SkillIdData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B2D74C Offset: 0x2B2974C VA: 0x2B2D74C
	|-List<TimeSpan>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B54164 Offset: 0x2B50164 VA: 0x2B54164
	|-List<ushort>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B5679C Offset: 0x2B5279C VA: 0x2B5679C
	|-List<uint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B58DD0 Offset: 0x2B54DD0 VA: 0x2B58DD0
	|-List<ulong>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B5B404 Offset: 0x2B57404 VA: 0x2B5B404
	|-List<Vector2>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B5DAB0 Offset: 0x2B59AB0 VA: 0x2B5DAB0
	|-List<Vector3>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B6023C Offset: 0x2B5C23C VA: 0x2B6023C
	|-List<X509ChainStatus>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B629C0 Offset: 0x2B5E9C0 VA: 0x2B629C0
	|-List<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B663C8 Offset: 0x2B623C8 VA: 0x2B663C8
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B68B48 Offset: 0x2B64B48 VA: 0x2B68B48
	|-List<BoneClip.MotionKeyFrame>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B6B700 Offset: 0x2B67700 VA: 0x2B6B700
	|-List<HouseRecipeManager.RecipeData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B6E2E4 Offset: 0x2B6A2E4 VA: 0x2B6E2E4
	|-List<KadarElexioBuf.SkillIdData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B7091C Offset: 0x2B6C91C VA: 0x2B7091C
	|-List<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B73080 Offset: 0x2B6F080 VA: 0x2B73080
	|-List<MissionTextManagerData.PickUpFieldData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B757E4 Offset: 0x2B717E4 VA: 0x2B757E4
	|-List<MobaRoomData.MobaAbilityMasterData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B77E7C Offset: 0x2B73E7C VA: 0x2B77E7C
	|-List<NewWaveRoomData.Spotlight>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B7A85C Offset: 0x2B7685C VA: 0x2B7A85C
	|-List<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B7CFDC Offset: 0x2B78FDC VA: 0x2B7CFDC
	|-List<RegexCharClass.SingleRange>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B7F624 Offset: 0x2B7B624 VA: 0x2B7F624
	|-List<SocialAchievementData.LinkData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B81DA4 Offset: 0x2B7DDA4 VA: 0x2B81DA4
	|-List<TrophyManager.TrophyData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B843DC Offset: 0x2B803DC VA: 0x2B843DC
	|-List<UIEventMenuButton.MessageButtonData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B86FC0 Offset: 0x2B82FC0 VA: 0x2B86FC0
	|-List<UIFieldMapPanel.PopData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B899A0 Offset: 0x2B859A0 VA: 0x2B899A0
	|-List<UIHouseAddressManager.Town>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B8BFD8 Offset: 0x2B87FD8 VA: 0x2B8BFD8
	|-List<UIInfoWindow.LabelPosition>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B8E9B8 Offset: 0x2B8A9B8 VA: 0x2B8E9B8
	|-List<UIMainManager.DropItemData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B90FF0 Offset: 0x2B8CFF0 VA: 0x2B90FF0
	|-List<UIScenarioOrderPanel.MissionData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B93770 Offset: 0x2B8F770 VA: 0x2B93770
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B9634C Offset: 0x2B9234C VA: 0x2B9634C
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B98ACC Offset: 0x2B94ACC VA: 0x2B98ACC
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2B9B3AC Offset: 0x2B973AC VA: 0x2B9B3AC
	|-List<InstructionList.DebugView.InstructionView>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD388 Offset: 0x2AA9388 VA: 0x2AAD388
	|-List<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AAFB08 Offset: 0x2AABB08 VA: 0x2AAFB08
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AB2150 Offset: 0x2AAE150 VA: 0x2AB2150
	|-List<KeyValuePair<byte, byte>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AB4B14 Offset: 0x2AB0B14 VA: 0x2AB4B14
	|-List<KeyValuePair<byte, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AB7294 Offset: 0x2AB3294 VA: 0x2AB7294
	|-List<KeyValuePair<int, short>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AB98CC Offset: 0x2AB58CC VA: 0x2AB98CC
	|-List<KeyValuePair<int, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2ABBF04 Offset: 0x2AB7F04 VA: 0x2ABBF04
	|-List<KeyValuePair<int, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2ABE684 Offset: 0x2ABA684 VA: 0x2ABE684
	|-List<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AC0CBC Offset: 0x2ABCCBC VA: 0x2AC0CBC
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AC37BC Offset: 0x2ABF7BC VA: 0x2AC37BC
	|-List<KeyValuePair<Int32Enum, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AC5DF4 Offset: 0x2AC1DF4 VA: 0x2AC5DF4
	|-List<KeyValuePair<Int32Enum, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AC8574 Offset: 0x2AC4574 VA: 0x2AC8574
	|-List<KeyValuePair<object, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2ACACF4 Offset: 0x2AC6CF4 VA: 0x2ACACF4
	|-List<KeyValuePair<object, float>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2ACD474 Offset: 0x2AC9474 VA: 0x2ACD474
	|-List<KeyValuePair<float, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2ACFBF4 Offset: 0x2ACBBF4 VA: 0x2ACFBF4
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AD2620 Offset: 0x2ACE620 VA: 0x2AD2620
	|-List<StructMultiKey<object, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AD4DA0 Offset: 0x2AD0DA0 VA: 0x2AD4DA0
	|-List<ValueTuple<short, short>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AD73E8 Offset: 0x2AD33E8 VA: 0x2AD73E8
	|-List<ValueTuple<int, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AD9A20 Offset: 0x2AD5A20 VA: 0x2AD9A20
	|-List<ValueTuple<int, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2ADC1A0 Offset: 0x2AD81A0 VA: 0x2ADC1A0
	|-List<ValueTuple<Int32Enum, float>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2ADE7D8 Offset: 0x2ADA7D8 VA: 0x2ADE7D8
	|-List<ValueTuple<Vector3, Vector3>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AE1290 Offset: 0x2ADD290 VA: 0x2AE1290
	|-List<ArchetypeUid>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AE38C8 Offset: 0x2ADF8C8 VA: 0x2AE38C8
	|-List<bool>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AE5F40 Offset: 0x2AE1F40 VA: 0x2AE5F40
	|-List<byte>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AE857C Offset: 0x2AE457C VA: 0x2AE857C
	|-List<ByteEnum>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AEABB8 Offset: 0x2AE6BB8 VA: 0x2AEABB8
	|-List<char>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AED1F0 Offset: 0x2AE91F0 VA: 0x2AED1F0
	|-List<Color>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AEF930 Offset: 0x2AEB930 VA: 0x2AEF930
	|-List<Color32>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AF1F78 Offset: 0x2AEDF78 VA: 0x2AF1F78
	|-List<DateTime>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AF45B0 Offset: 0x2AF05B0 VA: 0x2AF45B0
	|-List<DateTimeOffset>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AF6C48 Offset: 0x2AF2C48 VA: 0x2AF6C48
	|-List<Decimal>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AF9358 Offset: 0x2AF5358 VA: 0x2AF9358
	|-List<DefencePoint2>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AFB990 Offset: 0x2AF7990 VA: 0x2AFB990
	|-List<double>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2AFDFD4 Offset: 0x2AF9FD4 VA: 0x2AFDFD4
	|-List<EventSummary>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B00754 Offset: 0x2AFC754 VA: 0x2B00754
	|-List<short>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B02D8C Offset: 0x2AFED8C VA: 0x2B02D8C
	|-List<Int16Enum>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B053C4 Offset: 0x2B013C4 VA: 0x2B053C4
	|-List<int>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B079F8 Offset: 0x2B039F8 VA: 0x2B079F8
	|-List<Int32Enum>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B0A02C Offset: 0x2B0602C VA: 0x2B0A02C
	|-List<long>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B0C660 Offset: 0x2B08660 VA: 0x2B0C660
	|-List<InterpretedFrameInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B0EDE0 Offset: 0x2B0ADE0 VA: 0x2B0EDE0
	|-List<JsonPosition>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B119BC Offset: 0x2B0D9BC VA: 0x2B119BC
	|-List<MaterialSearchData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B14054 Offset: 0x2B10054 VA: 0x2B14054
	|-List<MobActionTargetData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B16B0C Offset: 0x2B12B0C VA: 0x2B16B0C
	|-List<MobIconLabelData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B196E8 Offset: 0x2B156E8 VA: 0x2B196E8
	|-List<object>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B1BDA8 Offset: 0x2B17DA8 VA: 0x2B1BDA8
	|-List<PlayerLoopSystem>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B1E9B0 Offset: 0x2B1A9B0 VA: 0x2B1E9B0
	|-List<PlayerLoopSystemInternal>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B215B8 Offset: 0x2B1D5B8 VA: 0x2B215B8
	|-List<RangePositionInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B23D38 Offset: 0x2B1FD38 VA: 0x2B23D38
	|-List<ReinforceCristaData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B2649C Offset: 0x2B2249C VA: 0x2B2649C
	|-List<sbyte>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B28AD8 Offset: 0x2B24AD8 VA: 0x2B28AD8
	|-List<float>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B2B11C Offset: 0x2B2711C VA: 0x2B2B11C
	|-List<SkillIdData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B2D754 Offset: 0x2B29754 VA: 0x2B2D754
	|-List<TimeSpan>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B5416C Offset: 0x2B5016C VA: 0x2B5416C
	|-List<ushort>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B567A4 Offset: 0x2B527A4 VA: 0x2B567A4
	|-List<uint>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B58DD8 Offset: 0x2B54DD8 VA: 0x2B58DD8
	|-List<ulong>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B5B40C Offset: 0x2B5740C VA: 0x2B5B40C
	|-List<Vector2>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B5DAB8 Offset: 0x2B59AB8 VA: 0x2B5DAB8
	|-List<Vector3>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B60244 Offset: 0x2B5C244 VA: 0x2B60244
	|-List<X509ChainStatus>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B629C8 Offset: 0x2B5E9C8 VA: 0x2B629C8
	|-List<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B663D0 Offset: 0x2B623D0 VA: 0x2B663D0
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B68B50 Offset: 0x2B64B50 VA: 0x2B68B50
	|-List<BoneClip.MotionKeyFrame>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B6B708 Offset: 0x2B67708 VA: 0x2B6B708
	|-List<HouseRecipeManager.RecipeData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B6E2EC Offset: 0x2B6A2EC VA: 0x2B6E2EC
	|-List<KadarElexioBuf.SkillIdData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B70924 Offset: 0x2B6C924 VA: 0x2B70924
	|-List<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B73088 Offset: 0x2B6F088 VA: 0x2B73088
	|-List<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B757EC Offset: 0x2B717EC VA: 0x2B757EC
	|-List<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B77E84 Offset: 0x2B73E84 VA: 0x2B77E84
	|-List<NewWaveRoomData.Spotlight>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B7A864 Offset: 0x2B76864 VA: 0x2B7A864
	|-List<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B7CFE4 Offset: 0x2B78FE4 VA: 0x2B7CFE4
	|-List<RegexCharClass.SingleRange>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B7F62C Offset: 0x2B7B62C VA: 0x2B7F62C
	|-List<SocialAchievementData.LinkData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B81DAC Offset: 0x2B7DDAC VA: 0x2B81DAC
	|-List<TrophyManager.TrophyData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B843E4 Offset: 0x2B803E4 VA: 0x2B843E4
	|-List<UIEventMenuButton.MessageButtonData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B86FC8 Offset: 0x2B82FC8 VA: 0x2B86FC8
	|-List<UIFieldMapPanel.PopData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B899A8 Offset: 0x2B859A8 VA: 0x2B899A8
	|-List<UIHouseAddressManager.Town>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B8BFE0 Offset: 0x2B87FE0 VA: 0x2B8BFE0
	|-List<UIInfoWindow.LabelPosition>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B8E9C0 Offset: 0x2B8A9C0 VA: 0x2B8E9C0
	|-List<UIMainManager.DropItemData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B90FF8 Offset: 0x2B8CFF8 VA: 0x2B90FF8
	|-List<UIScenarioOrderPanel.MissionData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B93778 Offset: 0x2B8F778 VA: 0x2B93778
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B96354 Offset: 0x2B92354 VA: 0x2B96354
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B98AD4 Offset: 0x2B94AD4 VA: 0x2B98AD4
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2B9B3B4 Offset: 0x2B973B4 VA: 0x2B9B3B4
	|-List<InstructionList.DebugView.InstructionView>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD390 Offset: 0x2AA9390 VA: 0x2AAD390
	|-List<KeyValuePair<ArchetypeUid, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AAFB10 Offset: 0x2AABB10 VA: 0x2AAFB10
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AB2158 Offset: 0x2AAE158 VA: 0x2AB2158
	|-List<KeyValuePair<byte, byte>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AB4B1C Offset: 0x2AB0B1C VA: 0x2AB4B1C
	|-List<KeyValuePair<byte, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AB729C Offset: 0x2AB329C VA: 0x2AB729C
	|-List<KeyValuePair<int, short>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AB98D4 Offset: 0x2AB58D4 VA: 0x2AB98D4
	|-List<KeyValuePair<int, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2ABBF0C Offset: 0x2AB7F0C VA: 0x2ABBF0C
	|-List<KeyValuePair<int, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2ABE68C Offset: 0x2ABA68C VA: 0x2ABE68C
	|-List<KeyValuePair<Int32Enum, byte>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AC0CC4 Offset: 0x2ABCCC4 VA: 0x2AC0CC4
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AC37C4 Offset: 0x2ABF7C4 VA: 0x2AC37C4
	|-List<KeyValuePair<Int32Enum, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AC5DFC Offset: 0x2AC1DFC VA: 0x2AC5DFC
	|-List<KeyValuePair<Int32Enum, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AC857C Offset: 0x2AC457C VA: 0x2AC857C
	|-List<KeyValuePair<object, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2ACACFC Offset: 0x2AC6CFC VA: 0x2ACACFC
	|-List<KeyValuePair<object, float>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2ACD47C Offset: 0x2AC947C VA: 0x2ACD47C
	|-List<KeyValuePair<float, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2ACFBFC Offset: 0x2ACBBFC VA: 0x2ACFBFC
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AD2628 Offset: 0x2ACE628 VA: 0x2AD2628
	|-List<StructMultiKey<object, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AD4DA8 Offset: 0x2AD0DA8 VA: 0x2AD4DA8
	|-List<ValueTuple<short, short>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AD73F0 Offset: 0x2AD33F0 VA: 0x2AD73F0
	|-List<ValueTuple<int, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AD9A28 Offset: 0x2AD5A28 VA: 0x2AD9A28
	|-List<ValueTuple<int, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2ADC1A8 Offset: 0x2AD81A8 VA: 0x2ADC1A8
	|-List<ValueTuple<Int32Enum, float>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2ADE7E0 Offset: 0x2ADA7E0 VA: 0x2ADE7E0
	|-List<ValueTuple<Vector3, Vector3>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AE1298 Offset: 0x2ADD298 VA: 0x2AE1298
	|-List<ArchetypeUid>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AE38D0 Offset: 0x2ADF8D0 VA: 0x2AE38D0
	|-List<bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AE5F48 Offset: 0x2AE1F48 VA: 0x2AE5F48
	|-List<byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AE8584 Offset: 0x2AE4584 VA: 0x2AE8584
	|-List<ByteEnum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AEABC0 Offset: 0x2AE6BC0 VA: 0x2AEABC0
	|-List<char>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AED1F8 Offset: 0x2AE91F8 VA: 0x2AED1F8
	|-List<Color>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AEF938 Offset: 0x2AEB938 VA: 0x2AEF938
	|-List<Color32>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AF1F80 Offset: 0x2AEDF80 VA: 0x2AF1F80
	|-List<DateTime>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AF45B8 Offset: 0x2AF05B8 VA: 0x2AF45B8
	|-List<DateTimeOffset>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AF6C50 Offset: 0x2AF2C50 VA: 0x2AF6C50
	|-List<Decimal>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AF9360 Offset: 0x2AF5360 VA: 0x2AF9360
	|-List<DefencePoint2>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AFB998 Offset: 0x2AF7998 VA: 0x2AFB998
	|-List<double>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AFDFDC Offset: 0x2AF9FDC VA: 0x2AFDFDC
	|-List<EventSummary>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B0075C Offset: 0x2AFC75C VA: 0x2B0075C
	|-List<short>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B02D94 Offset: 0x2AFED94 VA: 0x2B02D94
	|-List<Int16Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B053CC Offset: 0x2B013CC VA: 0x2B053CC
	|-List<int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B07A00 Offset: 0x2B03A00 VA: 0x2B07A00
	|-List<Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B0A034 Offset: 0x2B06034 VA: 0x2B0A034
	|-List<long>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B0C668 Offset: 0x2B08668 VA: 0x2B0C668
	|-List<InterpretedFrameInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B0EDE8 Offset: 0x2B0ADE8 VA: 0x2B0EDE8
	|-List<JsonPosition>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B119C4 Offset: 0x2B0D9C4 VA: 0x2B119C4
	|-List<MaterialSearchData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B1405C Offset: 0x2B1005C VA: 0x2B1405C
	|-List<MobActionTargetData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B16B14 Offset: 0x2B12B14 VA: 0x2B16B14
	|-List<MobIconLabelData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B196F0 Offset: 0x2B156F0 VA: 0x2B196F0
	|-List<object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B1BDB0 Offset: 0x2B17DB0 VA: 0x2B1BDB0
	|-List<PlayerLoopSystem>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B1E9B8 Offset: 0x2B1A9B8 VA: 0x2B1E9B8
	|-List<PlayerLoopSystemInternal>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B215C0 Offset: 0x2B1D5C0 VA: 0x2B215C0
	|-List<RangePositionInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B23D40 Offset: 0x2B1FD40 VA: 0x2B23D40
	|-List<ReinforceCristaData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B264A4 Offset: 0x2B224A4 VA: 0x2B264A4
	|-List<sbyte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B28AE0 Offset: 0x2B24AE0 VA: 0x2B28AE0
	|-List<float>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B2B124 Offset: 0x2B27124 VA: 0x2B2B124
	|-List<SkillIdData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B2D75C Offset: 0x2B2975C VA: 0x2B2D75C
	|-List<TimeSpan>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B54174 Offset: 0x2B50174 VA: 0x2B54174
	|-List<ushort>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B567AC Offset: 0x2B527AC VA: 0x2B567AC
	|-List<uint>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B58DE0 Offset: 0x2B54DE0 VA: 0x2B58DE0
	|-List<ulong>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B5B414 Offset: 0x2B57414 VA: 0x2B5B414
	|-List<Vector2>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B5DAC0 Offset: 0x2B59AC0 VA: 0x2B5DAC0
	|-List<Vector3>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B6024C Offset: 0x2B5C24C VA: 0x2B6024C
	|-List<X509ChainStatus>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B629D0 Offset: 0x2B5E9D0 VA: 0x2B629D0
	|-List<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B663D8 Offset: 0x2B623D8 VA: 0x2B663D8
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B68B58 Offset: 0x2B64B58 VA: 0x2B68B58
	|-List<BoneClip.MotionKeyFrame>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B6B710 Offset: 0x2B67710 VA: 0x2B6B710
	|-List<HouseRecipeManager.RecipeData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B6E2F4 Offset: 0x2B6A2F4 VA: 0x2B6E2F4
	|-List<KadarElexioBuf.SkillIdData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B7092C Offset: 0x2B6C92C VA: 0x2B7092C
	|-List<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B73090 Offset: 0x2B6F090 VA: 0x2B73090
	|-List<MissionTextManagerData.PickUpFieldData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B757F4 Offset: 0x2B717F4 VA: 0x2B757F4
	|-List<MobaRoomData.MobaAbilityMasterData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B77E8C Offset: 0x2B73E8C VA: 0x2B77E8C
	|-List<NewWaveRoomData.Spotlight>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B7A86C Offset: 0x2B7686C VA: 0x2B7A86C
	|-List<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B7CFEC Offset: 0x2B78FEC VA: 0x2B7CFEC
	|-List<RegexCharClass.SingleRange>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B7F634 Offset: 0x2B7B634 VA: 0x2B7F634
	|-List<SocialAchievementData.LinkData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B81DB4 Offset: 0x2B7DDB4 VA: 0x2B81DB4
	|-List<TrophyManager.TrophyData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B843EC Offset: 0x2B803EC VA: 0x2B843EC
	|-List<UIEventMenuButton.MessageButtonData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B86FD0 Offset: 0x2B82FD0 VA: 0x2B86FD0
	|-List<UIFieldMapPanel.PopData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B899B0 Offset: 0x2B859B0 VA: 0x2B899B0
	|-List<UIHouseAddressManager.Town>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B8BFE8 Offset: 0x2B87FE8 VA: 0x2B8BFE8
	|-List<UIInfoWindow.LabelPosition>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B8E9C8 Offset: 0x2B8A9C8 VA: 0x2B8E9C8
	|-List<UIMainManager.DropItemData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B91000 Offset: 0x2B8D000 VA: 0x2B91000
	|-List<UIScenarioOrderPanel.MissionData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B93780 Offset: 0x2B8F780 VA: 0x2B93780
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B9635C Offset: 0x2B9235C VA: 0x2B9635C
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B98ADC Offset: 0x2B94ADC VA: 0x2B98ADC
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2B9B3BC Offset: 0x2B973BC VA: 0x2B9B3BC
	|-List<InstructionList.DebugView.InstructionView>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD398 Offset: 0x2AA9398 VA: 0x2AAD398
	|-List<KeyValuePair<ArchetypeUid, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AAFB18 Offset: 0x2AABB18 VA: 0x2AAFB18
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AB2160 Offset: 0x2AAE160 VA: 0x2AB2160
	|-List<KeyValuePair<byte, byte>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AB4B24 Offset: 0x2AB0B24 VA: 0x2AB4B24
	|-List<KeyValuePair<byte, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AB72A4 Offset: 0x2AB32A4 VA: 0x2AB72A4
	|-List<KeyValuePair<int, short>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AB98DC Offset: 0x2AB58DC VA: 0x2AB98DC
	|-List<KeyValuePair<int, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2ABBF14 Offset: 0x2AB7F14 VA: 0x2ABBF14
	|-List<KeyValuePair<int, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2ABE694 Offset: 0x2ABA694 VA: 0x2ABE694
	|-List<KeyValuePair<Int32Enum, byte>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AC0CCC Offset: 0x2ABCCCC VA: 0x2AC0CCC
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AC37CC Offset: 0x2ABF7CC VA: 0x2AC37CC
	|-List<KeyValuePair<Int32Enum, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AC5E04 Offset: 0x2AC1E04 VA: 0x2AC5E04
	|-List<KeyValuePair<Int32Enum, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AC8584 Offset: 0x2AC4584 VA: 0x2AC8584
	|-List<KeyValuePair<object, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2ACAD04 Offset: 0x2AC6D04 VA: 0x2ACAD04
	|-List<KeyValuePair<object, float>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2ACD484 Offset: 0x2AC9484 VA: 0x2ACD484
	|-List<KeyValuePair<float, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2ACFC04 Offset: 0x2ACBC04 VA: 0x2ACFC04
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AD2630 Offset: 0x2ACE630 VA: 0x2AD2630
	|-List<StructMultiKey<object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AD4DB0 Offset: 0x2AD0DB0 VA: 0x2AD4DB0
	|-List<ValueTuple<short, short>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AD73F8 Offset: 0x2AD33F8 VA: 0x2AD73F8
	|-List<ValueTuple<int, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AD9A30 Offset: 0x2AD5A30 VA: 0x2AD9A30
	|-List<ValueTuple<int, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2ADC1B0 Offset: 0x2AD81B0 VA: 0x2ADC1B0
	|-List<ValueTuple<Int32Enum, float>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2ADE7E8 Offset: 0x2ADA7E8 VA: 0x2ADE7E8
	|-List<ValueTuple<Vector3, Vector3>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AE12A0 Offset: 0x2ADD2A0 VA: 0x2AE12A0
	|-List<ArchetypeUid>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AE38D8 Offset: 0x2ADF8D8 VA: 0x2AE38D8
	|-List<bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AE5F50 Offset: 0x2AE1F50 VA: 0x2AE5F50
	|-List<byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AE858C Offset: 0x2AE458C VA: 0x2AE858C
	|-List<ByteEnum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AEABC8 Offset: 0x2AE6BC8 VA: 0x2AEABC8
	|-List<char>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AED200 Offset: 0x2AE9200 VA: 0x2AED200
	|-List<Color>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AEF940 Offset: 0x2AEB940 VA: 0x2AEF940
	|-List<Color32>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AF1F88 Offset: 0x2AEDF88 VA: 0x2AF1F88
	|-List<DateTime>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AF45C0 Offset: 0x2AF05C0 VA: 0x2AF45C0
	|-List<DateTimeOffset>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AF6C58 Offset: 0x2AF2C58 VA: 0x2AF6C58
	|-List<Decimal>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AF9368 Offset: 0x2AF5368 VA: 0x2AF9368
	|-List<DefencePoint2>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AFB9A0 Offset: 0x2AF79A0 VA: 0x2AFB9A0
	|-List<double>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AFDFE4 Offset: 0x2AF9FE4 VA: 0x2AFDFE4
	|-List<EventSummary>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B00764 Offset: 0x2AFC764 VA: 0x2B00764
	|-List<short>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B02D9C Offset: 0x2AFED9C VA: 0x2B02D9C
	|-List<Int16Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B053D4 Offset: 0x2B013D4 VA: 0x2B053D4
	|-List<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B07A08 Offset: 0x2B03A08 VA: 0x2B07A08
	|-List<Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B0A03C Offset: 0x2B0603C VA: 0x2B0A03C
	|-List<long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B0C670 Offset: 0x2B08670 VA: 0x2B0C670
	|-List<InterpretedFrameInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B0EDF0 Offset: 0x2B0ADF0 VA: 0x2B0EDF0
	|-List<JsonPosition>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B119CC Offset: 0x2B0D9CC VA: 0x2B119CC
	|-List<MaterialSearchData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B14064 Offset: 0x2B10064 VA: 0x2B14064
	|-List<MobActionTargetData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B16B1C Offset: 0x2B12B1C VA: 0x2B16B1C
	|-List<MobIconLabelData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B196F8 Offset: 0x2B156F8 VA: 0x2B196F8
	|-List<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B1BDB8 Offset: 0x2B17DB8 VA: 0x2B1BDB8
	|-List<PlayerLoopSystem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B1E9C0 Offset: 0x2B1A9C0 VA: 0x2B1E9C0
	|-List<PlayerLoopSystemInternal>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B215C8 Offset: 0x2B1D5C8 VA: 0x2B215C8
	|-List<RangePositionInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B23D48 Offset: 0x2B1FD48 VA: 0x2B23D48
	|-List<ReinforceCristaData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B264AC Offset: 0x2B224AC VA: 0x2B264AC
	|-List<sbyte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B28AE8 Offset: 0x2B24AE8 VA: 0x2B28AE8
	|-List<float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B2B12C Offset: 0x2B2712C VA: 0x2B2B12C
	|-List<SkillIdData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B2D764 Offset: 0x2B29764 VA: 0x2B2D764
	|-List<TimeSpan>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B5417C Offset: 0x2B5017C VA: 0x2B5417C
	|-List<ushort>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B567B4 Offset: 0x2B527B4 VA: 0x2B567B4
	|-List<uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B58DE8 Offset: 0x2B54DE8 VA: 0x2B58DE8
	|-List<ulong>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B5B41C Offset: 0x2B5741C VA: 0x2B5B41C
	|-List<Vector2>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B5DAC8 Offset: 0x2B59AC8 VA: 0x2B5DAC8
	|-List<Vector3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B60254 Offset: 0x2B5C254 VA: 0x2B60254
	|-List<X509ChainStatus>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B629D8 Offset: 0x2B5E9D8 VA: 0x2B629D8
	|-List<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B663E0 Offset: 0x2B623E0 VA: 0x2B663E0
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B68B60 Offset: 0x2B64B60 VA: 0x2B68B60
	|-List<BoneClip.MotionKeyFrame>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B6B718 Offset: 0x2B67718 VA: 0x2B6B718
	|-List<HouseRecipeManager.RecipeData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B6E2FC Offset: 0x2B6A2FC VA: 0x2B6E2FC
	|-List<KadarElexioBuf.SkillIdData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B70934 Offset: 0x2B6C934 VA: 0x2B70934
	|-List<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B73098 Offset: 0x2B6F098 VA: 0x2B73098
	|-List<MissionTextManagerData.PickUpFieldData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B757FC Offset: 0x2B717FC VA: 0x2B757FC
	|-List<MobaRoomData.MobaAbilityMasterData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B77E94 Offset: 0x2B73E94 VA: 0x2B77E94
	|-List<NewWaveRoomData.Spotlight>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B7A874 Offset: 0x2B76874 VA: 0x2B7A874
	|-List<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B7CFF4 Offset: 0x2B78FF4 VA: 0x2B7CFF4
	|-List<RegexCharClass.SingleRange>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B7F63C Offset: 0x2B7B63C VA: 0x2B7F63C
	|-List<SocialAchievementData.LinkData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B81DBC Offset: 0x2B7DDBC VA: 0x2B81DBC
	|-List<TrophyManager.TrophyData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B843F4 Offset: 0x2B803F4 VA: 0x2B843F4
	|-List<UIEventMenuButton.MessageButtonData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B86FD8 Offset: 0x2B82FD8 VA: 0x2B86FD8
	|-List<UIFieldMapPanel.PopData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B899B8 Offset: 0x2B859B8 VA: 0x2B899B8
	|-List<UIHouseAddressManager.Town>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B8BFF0 Offset: 0x2B87FF0 VA: 0x2B8BFF0
	|-List<UIInfoWindow.LabelPosition>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B8E9D0 Offset: 0x2B8A9D0 VA: 0x2B8E9D0
	|-List<UIMainManager.DropItemData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B91008 Offset: 0x2B8D008 VA: 0x2B91008
	|-List<UIScenarioOrderPanel.MissionData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B93788 Offset: 0x2B8F788 VA: 0x2B93788
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B96364 Offset: 0x2B92364 VA: 0x2B96364
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B98AE4 Offset: 0x2B94AE4 VA: 0x2B98AE4
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2B9B3C4 Offset: 0x2B973C4 VA: 0x2B9B3C4
	|-List<InstructionList.DebugView.InstructionView>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD408 Offset: 0x2AA9408 VA: 0x2AAD408
	|-List<KeyValuePair<ArchetypeUid, object>>.get_Item
	|
	|-RVA: 0x2AAFB88 Offset: 0x2AABB88 VA: 0x2AAFB88
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.get_Item
	|
	|-RVA: 0x2AB21D0 Offset: 0x2AAE1D0 VA: 0x2AB21D0
	|-List<KeyValuePair<byte, byte>>.get_Item
	|
	|-RVA: 0x2AB4B94 Offset: 0x2AB0B94 VA: 0x2AB4B94
	|-List<KeyValuePair<byte, object>>.get_Item
	|
	|-RVA: 0x2AB7314 Offset: 0x2AB3314 VA: 0x2AB7314
	|-List<KeyValuePair<int, short>>.get_Item
	|
	|-RVA: 0x2AB994C Offset: 0x2AB594C VA: 0x2AB994C
	|-List<KeyValuePair<int, int>>.get_Item
	|
	|-RVA: 0x2ABBF84 Offset: 0x2AB7F84 VA: 0x2ABBF84
	|-List<KeyValuePair<int, object>>.get_Item
	|
	|-RVA: 0x2ABE704 Offset: 0x2ABA704 VA: 0x2ABE704
	|-List<KeyValuePair<Int32Enum, byte>>.get_Item
	|
	|-RVA: 0x2AC0D3C Offset: 0x2ABCD3C VA: 0x2AC0D3C
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.get_Item
	|
	|-RVA: 0x2AC383C Offset: 0x2ABF83C VA: 0x2AC383C
	|-List<KeyValuePair<Int32Enum, int>>.get_Item
	|
	|-RVA: 0x2AC5E74 Offset: 0x2AC1E74 VA: 0x2AC5E74
	|-List<KeyValuePair<Int32Enum, object>>.get_Item
	|
	|-RVA: 0x2AC85F4 Offset: 0x2AC45F4 VA: 0x2AC85F4
	|-List<KeyValuePair<object, int>>.get_Item
	|
	|-RVA: 0x2ACAD74 Offset: 0x2AC6D74 VA: 0x2ACAD74
	|-List<KeyValuePair<object, float>>.get_Item
	|
	|-RVA: 0x2ACD4F4 Offset: 0x2AC94F4 VA: 0x2ACD4F4
	|-List<KeyValuePair<float, object>>.get_Item
	|
	|-RVA: 0x2ACFC74 Offset: 0x2ACBC74 VA: 0x2ACFC74
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.get_Item
	|
	|-RVA: 0x2AD26A0 Offset: 0x2ACE6A0 VA: 0x2AD26A0
	|-List<StructMultiKey<object, object>>.get_Item
	|
	|-RVA: 0x2AD4E20 Offset: 0x2AD0E20 VA: 0x2AD4E20
	|-List<ValueTuple<short, short>>.get_Item
	|
	|-RVA: 0x2AD7468 Offset: 0x2AD3468 VA: 0x2AD7468
	|-List<ValueTuple<int, int>>.get_Item
	|
	|-RVA: 0x2AD9AA0 Offset: 0x2AD5AA0 VA: 0x2AD9AA0
	|-List<ValueTuple<int, object>>.get_Item
	|
	|-RVA: 0x2ADC220 Offset: 0x2AD8220 VA: 0x2ADC220
	|-List<ValueTuple<Int32Enum, float>>.get_Item
	|
	|-RVA: 0x2ADE858 Offset: 0x2ADA858 VA: 0x2ADE858
	|-List<ValueTuple<Vector3, Vector3>>.get_Item
	|
	|-RVA: 0x2AE1310 Offset: 0x2ADD310 VA: 0x2AE1310
	|-List<ArchetypeUid>.get_Item
	|
	|-RVA: 0x2AE3948 Offset: 0x2ADF948 VA: 0x2AE3948
	|-List<bool>.get_Item
	|
	|-RVA: 0x2AE5FC0 Offset: 0x2AE1FC0 VA: 0x2AE5FC0
	|-List<byte>.get_Item
	|
	|-RVA: 0x2AE85FC Offset: 0x2AE45FC VA: 0x2AE85FC
	|-List<ByteEnum>.get_Item
	|
	|-RVA: 0x2AEAC38 Offset: 0x2AE6C38 VA: 0x2AEAC38
	|-List<char>.get_Item
	|
	|-RVA: 0x2AED270 Offset: 0x2AE9270 VA: 0x2AED270
	|-List<Color>.get_Item
	|
	|-RVA: 0x2AEF9B0 Offset: 0x2AEB9B0 VA: 0x2AEF9B0
	|-List<Color32>.get_Item
	|
	|-RVA: 0x2AF1FF8 Offset: 0x2AEDFF8 VA: 0x2AF1FF8
	|-List<DateTime>.get_Item
	|
	|-RVA: 0x2AF4630 Offset: 0x2AF0630 VA: 0x2AF4630
	|-List<DateTimeOffset>.get_Item
	|
	|-RVA: 0x2AF6CC8 Offset: 0x2AF2CC8 VA: 0x2AF6CC8
	|-List<Decimal>.get_Item
	|
	|-RVA: 0x2AF93D8 Offset: 0x2AF53D8 VA: 0x2AF93D8
	|-List<DefencePoint2>.get_Item
	|
	|-RVA: 0x2AFBA10 Offset: 0x2AF7A10 VA: 0x2AFBA10
	|-List<double>.get_Item
	|
	|-RVA: 0x2AFE054 Offset: 0x2AFA054 VA: 0x2AFE054
	|-List<EventSummary>.get_Item
	|
	|-RVA: 0x2B007D4 Offset: 0x2AFC7D4 VA: 0x2B007D4
	|-List<short>.get_Item
	|
	|-RVA: 0x2B02E0C Offset: 0x2AFEE0C VA: 0x2B02E0C
	|-List<Int16Enum>.get_Item
	|
	|-RVA: 0x2B05444 Offset: 0x2B01444 VA: 0x2B05444
	|-List<int>.get_Item
	|
	|-RVA: 0x2B07A78 Offset: 0x2B03A78 VA: 0x2B07A78
	|-List<Int32Enum>.get_Item
	|
	|-RVA: 0x2B0A0AC Offset: 0x2B060AC VA: 0x2B0A0AC
	|-List<long>.get_Item
	|
	|-RVA: 0x2B0C6E0 Offset: 0x2B086E0 VA: 0x2B0C6E0
	|-List<InterpretedFrameInfo>.get_Item
	|
	|-RVA: 0x2B0EE60 Offset: 0x2B0AE60 VA: 0x2B0EE60
	|-List<JsonPosition>.get_Item
	|
	|-RVA: 0x2B11A3C Offset: 0x2B0DA3C VA: 0x2B11A3C
	|-List<MaterialSearchData>.get_Item
	|
	|-RVA: 0x2B140D4 Offset: 0x2B100D4 VA: 0x2B140D4
	|-List<MobActionTargetData>.get_Item
	|
	|-RVA: 0x2B16B8C Offset: 0x2B12B8C VA: 0x2B16B8C
	|-List<MobIconLabelData>.get_Item
	|
	|-RVA: 0x2B19768 Offset: 0x2B15768 VA: 0x2B19768
	|-List<object>.get_Item
	|
	|-RVA: 0x2B1BE28 Offset: 0x2B17E28 VA: 0x2B1BE28
	|-List<PlayerLoopSystem>.get_Item
	|
	|-RVA: 0x2B1EA30 Offset: 0x2B1AA30 VA: 0x2B1EA30
	|-List<PlayerLoopSystemInternal>.get_Item
	|
	|-RVA: 0x2B21638 Offset: 0x2B1D638 VA: 0x2B21638
	|-List<RangePositionInfo>.get_Item
	|
	|-RVA: 0x2B23DB8 Offset: 0x2B1FDB8 VA: 0x2B23DB8
	|-List<ReinforceCristaData>.get_Item
	|
	|-RVA: 0x2B2651C Offset: 0x2B2251C VA: 0x2B2651C
	|-List<sbyte>.get_Item
	|
	|-RVA: 0x2B28B58 Offset: 0x2B24B58 VA: 0x2B28B58
	|-List<float>.get_Item
	|
	|-RVA: 0x2B2B19C Offset: 0x2B2719C VA: 0x2B2B19C
	|-List<SkillIdData>.get_Item
	|
	|-RVA: 0x2B2D7D4 Offset: 0x2B297D4 VA: 0x2B2D7D4
	|-List<TimeSpan>.get_Item
	|
	|-RVA: 0x2B541EC Offset: 0x2B501EC VA: 0x2B541EC
	|-List<ushort>.get_Item
	|
	|-RVA: 0x2B56824 Offset: 0x2B52824 VA: 0x2B56824
	|-List<uint>.get_Item
	|
	|-RVA: 0x2B58E58 Offset: 0x2B54E58 VA: 0x2B58E58
	|-List<ulong>.get_Item
	|
	|-RVA: 0x2B5B48C Offset: 0x2B5748C VA: 0x2B5B48C
	|-List<Vector2>.get_Item
	|
	|-RVA: 0x2B5DB38 Offset: 0x2B59B38 VA: 0x2B5DB38
	|-List<Vector3>.get_Item
	|
	|-RVA: 0x2B602C4 Offset: 0x2B5C2C4 VA: 0x2B602C4
	|-List<X509ChainStatus>.get_Item
	|
	|-RVA: 0x2B62A48 Offset: 0x2B5EA48 VA: 0x2B62A48
	|-List<__Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x2B66450 Offset: 0x2B62450 VA: 0x2B66450
	|-List<BeforeRenderHelper.OrderBlock>.get_Item
	|
	|-RVA: 0x2B68BD0 Offset: 0x2B64BD0 VA: 0x2B68BD0
	|-List<BoneClip.MotionKeyFrame>.get_Item
	|
	|-RVA: 0x2B6B788 Offset: 0x2B67788 VA: 0x2B6B788
	|-List<HouseRecipeManager.RecipeData>.get_Item
	|
	|-RVA: 0x2B6E36C Offset: 0x2B6A36C VA: 0x2B6E36C
	|-List<KadarElexioBuf.SkillIdData>.get_Item
	|
	|-RVA: 0x2B709A4 Offset: 0x2B6C9A4 VA: 0x2B709A4
	|-List<MissionTextManagerData.CheckIKeywordtemData>.get_Item
	|
	|-RVA: 0x2B73108 Offset: 0x2B6F108 VA: 0x2B73108
	|-List<MissionTextManagerData.PickUpFieldData>.get_Item
	|
	|-RVA: 0x2B7586C Offset: 0x2B7186C VA: 0x2B7586C
	|-List<MobaRoomData.MobaAbilityMasterData>.get_Item
	|
	|-RVA: 0x2B77F04 Offset: 0x2B73F04 VA: 0x2B77F04
	|-List<NewWaveRoomData.Spotlight>.get_Item
	|
	|-RVA: 0x2B7A8E4 Offset: 0x2B768E4 VA: 0x2B7A8E4
	|-List<NguiDynamicFontController.ApplyTextureInfo>.get_Item
	|
	|-RVA: 0x2B7D064 Offset: 0x2B79064 VA: 0x2B7D064
	|-List<RegexCharClass.SingleRange>.get_Item
	|
	|-RVA: 0x2B7F6AC Offset: 0x2B7B6AC VA: 0x2B7F6AC
	|-List<SocialAchievementData.LinkData>.get_Item
	|
	|-RVA: 0x2B81E2C Offset: 0x2B7DE2C VA: 0x2B81E2C
	|-List<TrophyManager.TrophyData>.get_Item
	|
	|-RVA: 0x2B84464 Offset: 0x2B80464 VA: 0x2B84464
	|-List<UIEventMenuButton.MessageButtonData>.get_Item
	|
	|-RVA: 0x2B87048 Offset: 0x2B83048 VA: 0x2B87048
	|-List<UIFieldMapPanel.PopData>.get_Item
	|
	|-RVA: 0x2B89A28 Offset: 0x2B85A28 VA: 0x2B89A28
	|-List<UIHouseAddressManager.Town>.get_Item
	|
	|-RVA: 0x2B8C060 Offset: 0x2B88060 VA: 0x2B8C060
	|-List<UIInfoWindow.LabelPosition>.get_Item
	|
	|-RVA: 0x2B8EA40 Offset: 0x2B8AA40 VA: 0x2B8EA40
	|-List<UIMainManager.DropItemData>.get_Item
	|
	|-RVA: 0x2B91078 Offset: 0x2B8D078 VA: 0x2B91078
	|-List<UIScenarioOrderPanel.MissionData>.get_Item
	|
	|-RVA: 0x2B937F8 Offset: 0x2B8F7F8 VA: 0x2B937F8
	|-List<UnitySynchronizationContext.WorkRequest>.get_Item
	|
	|-RVA: 0x2B963D4 Offset: 0x2B923D4 VA: 0x2B963D4
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Item
	|
	|-RVA: 0x2B98B54 Offset: 0x2B94B54 VA: 0x2B98B54
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.get_Item
	|
	|-RVA: 0x2B9B434 Offset: 0x2B97434 VA: 0x2B9B434
	|-List<InstructionList.DebugView.InstructionView>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD460 Offset: 0x2AA9460 VA: 0x2AAD460
	|-List<KeyValuePair<ArchetypeUid, object>>.set_Item
	|
	|-RVA: 0x2AAFBDC Offset: 0x2AABBDC VA: 0x2AAFBDC
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.set_Item
	|
	|-RVA: 0x2AB2224 Offset: 0x2AAE224 VA: 0x2AB2224
	|-List<KeyValuePair<byte, byte>>.set_Item
	|
	|-RVA: 0x2AB4BEC Offset: 0x2AB0BEC VA: 0x2AB4BEC
	|-List<KeyValuePair<byte, object>>.set_Item
	|
	|-RVA: 0x2AB7368 Offset: 0x2AB3368 VA: 0x2AB7368
	|-List<KeyValuePair<int, short>>.set_Item
	|
	|-RVA: 0x2AB99A0 Offset: 0x2AB59A0 VA: 0x2AB99A0
	|-List<KeyValuePair<int, int>>.set_Item
	|
	|-RVA: 0x2ABBFDC Offset: 0x2AB7FDC VA: 0x2ABBFDC
	|-List<KeyValuePair<int, object>>.set_Item
	|
	|-RVA: 0x2ABE758 Offset: 0x2ABA758 VA: 0x2ABE758
	|-List<KeyValuePair<Int32Enum, byte>>.set_Item
	|
	|-RVA: 0x2AC0DA4 Offset: 0x2ABCDA4 VA: 0x2AC0DA4
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.set_Item
	|
	|-RVA: 0x2AC3890 Offset: 0x2ABF890 VA: 0x2AC3890
	|-List<KeyValuePair<Int32Enum, int>>.set_Item
	|
	|-RVA: 0x2AC5ECC Offset: 0x2AC1ECC VA: 0x2AC5ECC
	|-List<KeyValuePair<Int32Enum, object>>.set_Item
	|
	|-RVA: 0x2AC864C Offset: 0x2AC464C VA: 0x2AC864C
	|-List<KeyValuePair<object, int>>.set_Item
	|
	|-RVA: 0x2ACADCC Offset: 0x2AC6DCC VA: 0x2ACADCC
	|-List<KeyValuePair<object, float>>.set_Item
	|
	|-RVA: 0x2ACD54C Offset: 0x2AC954C VA: 0x2ACD54C
	|-List<KeyValuePair<float, object>>.set_Item
	|
	|-RVA: 0x2ACFCD4 Offset: 0x2ACBCD4 VA: 0x2ACFCD4
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.set_Item
	|
	|-RVA: 0x2AD26F8 Offset: 0x2ACE6F8 VA: 0x2AD26F8
	|-List<StructMultiKey<object, object>>.set_Item
	|
	|-RVA: 0x2AD4E74 Offset: 0x2AD0E74 VA: 0x2AD4E74
	|-List<ValueTuple<short, short>>.set_Item
	|
	|-RVA: 0x2AD74BC Offset: 0x2AD34BC VA: 0x2AD74BC
	|-List<ValueTuple<int, int>>.set_Item
	|
	|-RVA: 0x2AD9AF8 Offset: 0x2AD5AF8 VA: 0x2AD9AF8
	|-List<ValueTuple<int, object>>.set_Item
	|
	|-RVA: 0x2ADC274 Offset: 0x2AD8274 VA: 0x2ADC274
	|-List<ValueTuple<Int32Enum, float>>.set_Item
	|
	|-RVA: 0x2ADE8C0 Offset: 0x2ADA8C0 VA: 0x2ADE8C0
	|-List<ValueTuple<Vector3, Vector3>>.set_Item
	|
	|-RVA: 0x2AE1364 Offset: 0x2ADD364 VA: 0x2AE1364
	|-List<ArchetypeUid>.set_Item
	|
	|-RVA: 0x2AE399C Offset: 0x2ADF99C VA: 0x2AE399C
	|-List<bool>.set_Item
	|
	|-RVA: 0x2AE6014 Offset: 0x2AE2014 VA: 0x2AE6014
	|-List<byte>.set_Item
	|
	|-RVA: 0x2AE8650 Offset: 0x2AE4650 VA: 0x2AE8650
	|-List<ByteEnum>.set_Item
	|
	|-RVA: 0x2AEAC8C Offset: 0x2AE6C8C VA: 0x2AEAC8C
	|-List<char>.set_Item
	|
	|-RVA: 0x2AED2CC Offset: 0x2AE92CC VA: 0x2AED2CC
	|-List<Color>.set_Item
	|
	|-RVA: 0x2AEFA04 Offset: 0x2AEBA04 VA: 0x2AEFA04
	|-List<Color32>.set_Item
	|
	|-RVA: 0x2AF204C Offset: 0x2AEE04C VA: 0x2AF204C
	|-List<DateTime>.set_Item
	|
	|-RVA: 0x2AF4688 Offset: 0x2AF0688 VA: 0x2AF4688
	|-List<DateTimeOffset>.set_Item
	|
	|-RVA: 0x2AF6D20 Offset: 0x2AF2D20 VA: 0x2AF6D20
	|-List<Decimal>.set_Item
	|
	|-RVA: 0x2AF942C Offset: 0x2AF542C VA: 0x2AF942C
	|-List<DefencePoint2>.set_Item
	|
	|-RVA: 0x2AFBA64 Offset: 0x2AF7A64 VA: 0x2AFBA64
	|-List<double>.set_Item
	|
	|-RVA: 0x2AFE0AC Offset: 0x2AFA0AC VA: 0x2AFE0AC
	|-List<EventSummary>.set_Item
	|
	|-RVA: 0x2B00828 Offset: 0x2AFC828 VA: 0x2B00828
	|-List<short>.set_Item
	|
	|-RVA: 0x2B02E60 Offset: 0x2AFEE60 VA: 0x2B02E60
	|-List<Int16Enum>.set_Item
	|
	|-RVA: 0x2B05498 Offset: 0x2B01498 VA: 0x2B05498
	|-List<int>.set_Item
	|
	|-RVA: 0x2B07ACC Offset: 0x2B03ACC VA: 0x2B07ACC
	|-List<Int32Enum>.set_Item
	|
	|-RVA: 0x2B0A100 Offset: 0x2B06100 VA: 0x2B0A100
	|-List<long>.set_Item
	|
	|-RVA: 0x2B0C738 Offset: 0x2B08738 VA: 0x2B0C738
	|-List<InterpretedFrameInfo>.set_Item
	|
	|-RVA: 0x2B0EEC8 Offset: 0x2B0AEC8 VA: 0x2B0EEC8
	|-List<JsonPosition>.set_Item
	|
	|-RVA: 0x2B11A94 Offset: 0x2B0DA94 VA: 0x2B11A94
	|-List<MaterialSearchData>.set_Item
	|
	|-RVA: 0x2B1413C Offset: 0x2B1013C VA: 0x2B1413C
	|-List<MobActionTargetData>.set_Item
	|
	|-RVA: 0x2B16BF4 Offset: 0x2B12BF4 VA: 0x2B16BF4
	|-List<MobIconLabelData>.set_Item
	|
	|-RVA: 0x2B197BC Offset: 0x2B157BC VA: 0x2B197BC
	|-List<object>.set_Item
	|
	|-RVA: 0x2B1BE90 Offset: 0x2B17E90 VA: 0x2B1BE90
	|-List<PlayerLoopSystem>.set_Item
	|
	|-RVA: 0x2B1EA98 Offset: 0x2B1AA98 VA: 0x2B1EA98
	|-List<PlayerLoopSystemInternal>.set_Item
	|
	|-RVA: 0x2B21690 Offset: 0x2B1D690 VA: 0x2B21690
	|-List<RangePositionInfo>.set_Item
	|
	|-RVA: 0x2B23E18 Offset: 0x2B1FE18 VA: 0x2B23E18
	|-List<ReinforceCristaData>.set_Item
	|
	|-RVA: 0x2B26570 Offset: 0x2B22570 VA: 0x2B26570
	|-List<sbyte>.set_Item
	|
	|-RVA: 0x2B28BAC Offset: 0x2B24BAC VA: 0x2B28BAC
	|-List<float>.set_Item
	|
	|-RVA: 0x2B2B1F0 Offset: 0x2B271F0 VA: 0x2B2B1F0
	|-List<SkillIdData>.set_Item
	|
	|-RVA: 0x2B2D828 Offset: 0x2B29828 VA: 0x2B2D828
	|-List<TimeSpan>.set_Item
	|
	|-RVA: 0x2B54240 Offset: 0x2B50240 VA: 0x2B54240
	|-List<ushort>.set_Item
	|
	|-RVA: 0x2B56878 Offset: 0x2B52878 VA: 0x2B56878
	|-List<uint>.set_Item
	|
	|-RVA: 0x2B58EAC Offset: 0x2B54EAC VA: 0x2B58EAC
	|-List<ulong>.set_Item
	|
	|-RVA: 0x2B5B4E4 Offset: 0x2B574E4 VA: 0x2B5B4E4
	|-List<Vector2>.set_Item
	|
	|-RVA: 0x2B5DB98 Offset: 0x2B59B98 VA: 0x2B5DB98
	|-List<Vector3>.set_Item
	|
	|-RVA: 0x2B6031C Offset: 0x2B5C31C VA: 0x2B6031C
	|-List<X509ChainStatus>.set_Item
	|
	|-RVA: 0x2B62B2C Offset: 0x2B5EB2C VA: 0x2B62B2C
	|-List<__Il2CppFullySharedGenericType>.set_Item
	|
	|-RVA: 0x2B664A8 Offset: 0x2B624A8 VA: 0x2B664A8
	|-List<BeforeRenderHelper.OrderBlock>.set_Item
	|
	|-RVA: 0x2B68C38 Offset: 0x2B64C38 VA: 0x2B68C38
	|-List<BoneClip.MotionKeyFrame>.set_Item
	|
	|-RVA: 0x2B6B7F0 Offset: 0x2B677F0 VA: 0x2B6B7F0
	|-List<HouseRecipeManager.RecipeData>.set_Item
	|
	|-RVA: 0x2B6E3C0 Offset: 0x2B6A3C0 VA: 0x2B6E3C0
	|-List<KadarElexioBuf.SkillIdData>.set_Item
	|
	|-RVA: 0x2B70A04 Offset: 0x2B6CA04 VA: 0x2B70A04
	|-List<MissionTextManagerData.CheckIKeywordtemData>.set_Item
	|
	|-RVA: 0x2B73168 Offset: 0x2B6F168 VA: 0x2B73168
	|-List<MissionTextManagerData.PickUpFieldData>.set_Item
	|
	|-RVA: 0x2B758C4 Offset: 0x2B718C4 VA: 0x2B758C4
	|-List<MobaRoomData.MobaAbilityMasterData>.set_Item
	|
	|-RVA: 0x2B77F64 Offset: 0x2B73F64 VA: 0x2B77F64
	|-List<NewWaveRoomData.Spotlight>.set_Item
	|
	|-RVA: 0x2B7A93C Offset: 0x2B7693C VA: 0x2B7A93C
	|-List<NguiDynamicFontController.ApplyTextureInfo>.set_Item
	|
	|-RVA: 0x2B7D0B8 Offset: 0x2B790B8 VA: 0x2B7D0B8
	|-List<RegexCharClass.SingleRange>.set_Item
	|
	|-RVA: 0x2B7F704 Offset: 0x2B7B704 VA: 0x2B7F704
	|-List<SocialAchievementData.LinkData>.set_Item
	|
	|-RVA: 0x2B81E80 Offset: 0x2B7DE80 VA: 0x2B81E80
	|-List<TrophyManager.TrophyData>.set_Item
	|
	|-RVA: 0x2B844CC Offset: 0x2B804CC VA: 0x2B844CC
	|-List<UIEventMenuButton.MessageButtonData>.set_Item
	|
	|-RVA: 0x2B870A8 Offset: 0x2B830A8 VA: 0x2B870A8
	|-List<UIFieldMapPanel.PopData>.set_Item
	|
	|-RVA: 0x2B89A7C Offset: 0x2B85A7C VA: 0x2B89A7C
	|-List<UIHouseAddressManager.Town>.set_Item
	|
	|-RVA: 0x2B8C0C0 Offset: 0x2B880C0 VA: 0x2B8C0C0
	|-List<UIInfoWindow.LabelPosition>.set_Item
	|
	|-RVA: 0x2B8EA94 Offset: 0x2B8AA94 VA: 0x2B8EA94
	|-List<UIMainManager.DropItemData>.set_Item
	|
	|-RVA: 0x2B910D0 Offset: 0x2B8D0D0 VA: 0x2B910D0
	|-List<UIScenarioOrderPanel.MissionData>.set_Item
	|
	|-RVA: 0x2B93860 Offset: 0x2B8F860 VA: 0x2B93860
	|-List<UnitySynchronizationContext.WorkRequest>.set_Item
	|
	|-RVA: 0x2B9642C Offset: 0x2B9242C VA: 0x2B9642C
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.set_Item
	|
	|-RVA: 0x2B98BB4 Offset: 0x2B94BB4 VA: 0x2B98BB4
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.set_Item
	|
	|-RVA: 0x2B9B494 Offset: 0x2B97494 VA: 0x2B9B494
	|-List<InstructionList.DebugView.InstructionView>.set_Item
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD4E0 Offset: 0x2AA94E0 VA: 0x2AAD4E0
	|-List<KeyValuePair<ArchetypeUid, object>>.IsCompatibleObject
	|
	|-RVA: 0x2AAFC40 Offset: 0x2AABC40 VA: 0x2AAFC40
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.IsCompatibleObject
	|
	|-RVA: 0x2AB2288 Offset: 0x2AAE288 VA: 0x2AB2288
	|-List<KeyValuePair<byte, byte>>.IsCompatibleObject
	|
	|-RVA: 0x2AB4C6C Offset: 0x2AB0C6C VA: 0x2AB4C6C
	|-List<KeyValuePair<byte, object>>.IsCompatibleObject
	|
	|-RVA: 0x2AB73CC Offset: 0x2AB33CC VA: 0x2AB73CC
	|-List<KeyValuePair<int, short>>.IsCompatibleObject
	|
	|-RVA: 0x2AB9A04 Offset: 0x2AB5A04 VA: 0x2AB9A04
	|-List<KeyValuePair<int, int>>.IsCompatibleObject
	|
	|-RVA: 0x2ABC05C Offset: 0x2AB805C VA: 0x2ABC05C
	|-List<KeyValuePair<int, object>>.IsCompatibleObject
	|
	|-RVA: 0x2ABE7BC Offset: 0x2ABA7BC VA: 0x2ABE7BC
	|-List<KeyValuePair<Int32Enum, byte>>.IsCompatibleObject
	|
	|-RVA: 0x2AC0E40 Offset: 0x2ABCE40 VA: 0x2AC0E40
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.IsCompatibleObject
	|
	|-RVA: 0x2AC38F4 Offset: 0x2ABF8F4 VA: 0x2AC38F4
	|-List<KeyValuePair<Int32Enum, int>>.IsCompatibleObject
	|
	|-RVA: 0x2AC5F4C Offset: 0x2AC1F4C VA: 0x2AC5F4C
	|-List<KeyValuePair<Int32Enum, object>>.IsCompatibleObject
	|
	|-RVA: 0x2AC86CC Offset: 0x2AC46CC VA: 0x2AC86CC
	|-List<KeyValuePair<object, int>>.IsCompatibleObject
	|
	|-RVA: 0x2ACAE4C Offset: 0x2AC6E4C VA: 0x2ACAE4C
	|-List<KeyValuePair<object, float>>.IsCompatibleObject
	|
	|-RVA: 0x2ACD5CC Offset: 0x2AC95CC VA: 0x2ACD5CC
	|-List<KeyValuePair<float, object>>.IsCompatibleObject
	|
	|-RVA: 0x2ACFD64 Offset: 0x2ACBD64 VA: 0x2ACFD64
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.IsCompatibleObject
	|
	|-RVA: 0x2AD2778 Offset: 0x2ACE778 VA: 0x2AD2778
	|-List<StructMultiKey<object, object>>.IsCompatibleObject
	|
	|-RVA: 0x2AD4ED8 Offset: 0x2AD0ED8 VA: 0x2AD4ED8
	|-List<ValueTuple<short, short>>.IsCompatibleObject
	|
	|-RVA: 0x2AD7520 Offset: 0x2AD3520 VA: 0x2AD7520
	|-List<ValueTuple<int, int>>.IsCompatibleObject
	|
	|-RVA: 0x2AD9B78 Offset: 0x2AD5B78 VA: 0x2AD9B78
	|-List<ValueTuple<int, object>>.IsCompatibleObject
	|
	|-RVA: 0x2ADC2D8 Offset: 0x2AD82D8 VA: 0x2ADC2D8
	|-List<ValueTuple<Int32Enum, float>>.IsCompatibleObject
	|
	|-RVA: 0x2ADE95C Offset: 0x2ADA95C VA: 0x2ADE95C
	|-List<ValueTuple<Vector3, Vector3>>.IsCompatibleObject
	|
	|-RVA: 0x2AE13C8 Offset: 0x2ADD3C8 VA: 0x2AE13C8
	|-List<ArchetypeUid>.IsCompatibleObject
	|
	|-RVA: 0x2AE3A04 Offset: 0x2ADFA04 VA: 0x2AE3A04
	|-List<bool>.IsCompatibleObject
	|
	|-RVA: 0x2AE6078 Offset: 0x2AE2078 VA: 0x2AE6078
	|-List<byte>.IsCompatibleObject
	|
	|-RVA: 0x2AE86B4 Offset: 0x2AE46B4 VA: 0x2AE86B4
	|-List<ByteEnum>.IsCompatibleObject
	|
	|-RVA: 0x2AEACF0 Offset: 0x2AE6CF0 VA: 0x2AEACF0
	|-List<char>.IsCompatibleObject
	|
	|-RVA: 0x2AED354 Offset: 0x2AE9354 VA: 0x2AED354
	|-List<Color>.IsCompatibleObject
	|
	|-RVA: 0x2AEFA68 Offset: 0x2AEBA68 VA: 0x2AEFA68
	|-List<Color32>.IsCompatibleObject
	|
	|-RVA: 0x2AF20B0 Offset: 0x2AEE0B0 VA: 0x2AF20B0
	|-List<DateTime>.IsCompatibleObject
	|
	|-RVA: 0x2AF46FC Offset: 0x2AF06FC VA: 0x2AF46FC
	|-List<DateTimeOffset>.IsCompatibleObject
	|
	|-RVA: 0x2AF6D94 Offset: 0x2AF2D94 VA: 0x2AF6D94
	|-List<Decimal>.IsCompatibleObject
	|
	|-RVA: 0x2AF9490 Offset: 0x2AF5490 VA: 0x2AF9490
	|-List<DefencePoint2>.IsCompatibleObject
	|
	|-RVA: 0x2AFBAD0 Offset: 0x2AF7AD0 VA: 0x2AFBAD0
	|-List<double>.IsCompatibleObject
	|
	|-RVA: 0x2AFE12C Offset: 0x2AFA12C VA: 0x2AFE12C
	|-List<EventSummary>.IsCompatibleObject
	|
	|-RVA: 0x2B0088C Offset: 0x2AFC88C VA: 0x2B0088C
	|-List<short>.IsCompatibleObject
	|
	|-RVA: 0x2B02EC4 Offset: 0x2AFEEC4 VA: 0x2B02EC4
	|-List<Int16Enum>.IsCompatibleObject
	|
	|-RVA: 0x2B054FC Offset: 0x2B014FC VA: 0x2B054FC
	|-List<int>.IsCompatibleObject
	|
	|-RVA: 0x2B07B30 Offset: 0x2B03B30 VA: 0x2B07B30
	|-List<Int32Enum>.IsCompatibleObject
	|
	|-RVA: 0x2B0A164 Offset: 0x2B06164 VA: 0x2B0A164
	|-List<long>.IsCompatibleObject
	|
	|-RVA: 0x2B0C7B8 Offset: 0x2B087B8 VA: 0x2B0C7B8
	|-List<InterpretedFrameInfo>.IsCompatibleObject
	|
	|-RVA: 0x2B0EF74 Offset: 0x2B0AF74 VA: 0x2B0EF74
	|-List<JsonPosition>.IsCompatibleObject
	|
	|-RVA: 0x2B11B08 Offset: 0x2B0DB08 VA: 0x2B11B08
	|-List<MaterialSearchData>.IsCompatibleObject
	|
	|-RVA: 0x2B141D8 Offset: 0x2B101D8 VA: 0x2B141D8
	|-List<MobActionTargetData>.IsCompatibleObject
	|
	|-RVA: 0x2B16CA0 Offset: 0x2B12CA0 VA: 0x2B16CA0
	|-List<MobIconLabelData>.IsCompatibleObject
	|
	|-RVA: 0x2B19828 Offset: 0x2B15828 VA: 0x2B19828
	|-List<object>.IsCompatibleObject
	|
	|-RVA: 0x2B1BF3C Offset: 0x2B17F3C VA: 0x2B1BF3C
	|-List<PlayerLoopSystem>.IsCompatibleObject
	|
	|-RVA: 0x2B1EB44 Offset: 0x2B1AB44 VA: 0x2B1EB44
	|-List<PlayerLoopSystemInternal>.IsCompatibleObject
	|
	|-RVA: 0x2B21710 Offset: 0x2B1D710 VA: 0x2B21710
	|-List<RangePositionInfo>.IsCompatibleObject
	|
	|-RVA: 0x2B23E94 Offset: 0x2B1FE94 VA: 0x2B23E94
	|-List<ReinforceCristaData>.IsCompatibleObject
	|
	|-RVA: 0x2B265D4 Offset: 0x2B225D4 VA: 0x2B265D4
	|-List<sbyte>.IsCompatibleObject
	|
	|-RVA: 0x2B28C18 Offset: 0x2B24C18 VA: 0x2B28C18
	|-List<float>.IsCompatibleObject
	|
	|-RVA: 0x2B2B254 Offset: 0x2B27254 VA: 0x2B2B254
	|-List<SkillIdData>.IsCompatibleObject
	|
	|-RVA: 0x2B2D88C Offset: 0x2B2988C VA: 0x2B2D88C
	|-List<TimeSpan>.IsCompatibleObject
	|
	|-RVA: 0x2B542A4 Offset: 0x2B502A4 VA: 0x2B542A4
	|-List<ushort>.IsCompatibleObject
	|
	|-RVA: 0x2B568DC Offset: 0x2B528DC VA: 0x2B568DC
	|-List<uint>.IsCompatibleObject
	|
	|-RVA: 0x2B58F10 Offset: 0x2B54F10 VA: 0x2B58F10
	|-List<ulong>.IsCompatibleObject
	|
	|-RVA: 0x2B5B558 Offset: 0x2B57558 VA: 0x2B5B558
	|-List<Vector2>.IsCompatibleObject
	|
	|-RVA: 0x2B5DC20 Offset: 0x2B59C20 VA: 0x2B5DC20
	|-List<Vector3>.IsCompatibleObject
	|
	|-RVA: 0x2B6039C Offset: 0x2B5C39C VA: 0x2B6039C
	|-List<X509ChainStatus>.IsCompatibleObject
	|
	|-RVA: 0x2B62C84 Offset: 0x2B5EC84 VA: 0x2B62C84
	|-List<__Il2CppFullySharedGenericType>.IsCompatibleObject
	|
	|-RVA: 0x2B66528 Offset: 0x2B62528 VA: 0x2B66528
	|-List<BeforeRenderHelper.OrderBlock>.IsCompatibleObject
	|
	|-RVA: 0x2B68CE0 Offset: 0x2B64CE0 VA: 0x2B68CE0
	|-List<BoneClip.MotionKeyFrame>.IsCompatibleObject
	|
	|-RVA: 0x2B6B898 Offset: 0x2B67898 VA: 0x2B6B898
	|-List<HouseRecipeManager.RecipeData>.IsCompatibleObject
	|
	|-RVA: 0x2B6E424 Offset: 0x2B6A424 VA: 0x2B6E424
	|-List<KadarElexioBuf.SkillIdData>.IsCompatibleObject
	|
	|-RVA: 0x2B70A80 Offset: 0x2B6CA80 VA: 0x2B70A80
	|-List<MissionTextManagerData.CheckIKeywordtemData>.IsCompatibleObject
	|
	|-RVA: 0x2B731E4 Offset: 0x2B6F1E4 VA: 0x2B731E4
	|-List<MissionTextManagerData.PickUpFieldData>.IsCompatibleObject
	|
	|-RVA: 0x2B75938 Offset: 0x2B71938 VA: 0x2B75938
	|-List<MobaRoomData.MobaAbilityMasterData>.IsCompatibleObject
	|
	|-RVA: 0x2B77FF4 Offset: 0x2B73FF4 VA: 0x2B77FF4
	|-List<NewWaveRoomData.Spotlight>.IsCompatibleObject
	|
	|-RVA: 0x2B7A9BC Offset: 0x2B769BC VA: 0x2B7A9BC
	|-List<NguiDynamicFontController.ApplyTextureInfo>.IsCompatibleObject
	|
	|-RVA: 0x2B7D11C Offset: 0x2B7911C VA: 0x2B7D11C
	|-List<RegexCharClass.SingleRange>.IsCompatibleObject
	|
	|-RVA: 0x2B7F784 Offset: 0x2B7B784 VA: 0x2B7F784
	|-List<SocialAchievementData.LinkData>.IsCompatibleObject
	|
	|-RVA: 0x2B81EE4 Offset: 0x2B7DEE4 VA: 0x2B81EE4
	|-List<TrophyManager.TrophyData>.IsCompatibleObject
	|
	|-RVA: 0x2B84578 Offset: 0x2B80578 VA: 0x2B84578
	|-List<UIEventMenuButton.MessageButtonData>.IsCompatibleObject
	|
	|-RVA: 0x2B87138 Offset: 0x2B83138 VA: 0x2B87138
	|-List<UIFieldMapPanel.PopData>.IsCompatibleObject
	|
	|-RVA: 0x2B89AE0 Offset: 0x2B85AE0 VA: 0x2B89AE0
	|-List<UIHouseAddressManager.Town>.IsCompatibleObject
	|
	|-RVA: 0x2B8C150 Offset: 0x2B88150 VA: 0x2B8C150
	|-List<UIInfoWindow.LabelPosition>.IsCompatibleObject
	|
	|-RVA: 0x2B8EAF8 Offset: 0x2B8AAF8 VA: 0x2B8EAF8
	|-List<UIMainManager.DropItemData>.IsCompatibleObject
	|
	|-RVA: 0x2B91150 Offset: 0x2B8D150 VA: 0x2B91150
	|-List<UIScenarioOrderPanel.MissionData>.IsCompatibleObject
	|
	|-RVA: 0x2B9390C Offset: 0x2B8F90C VA: 0x2B9390C
	|-List<UnitySynchronizationContext.WorkRequest>.IsCompatibleObject
	|
	|-RVA: 0x2B964AC Offset: 0x2B924AC VA: 0x2B964AC
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IsCompatibleObject
	|
	|-RVA: 0x2B98C38 Offset: 0x2B94C38 VA: 0x2B98C38
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.IsCompatibleObject
	|
	|-RVA: 0x2B9B524 Offset: 0x2B97524 VA: 0x2B9B524
	|-List<InstructionList.DebugView.InstructionView>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD534 Offset: 0x2AA9534 VA: 0x2AAD534
	|-List<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AAFC94 Offset: 0x2AABC94 VA: 0x2AAFC94
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AB22DC Offset: 0x2AAE2DC VA: 0x2AB22DC
	|-List<KeyValuePair<byte, byte>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AB4CC0 Offset: 0x2AB0CC0 VA: 0x2AB4CC0
	|-List<KeyValuePair<byte, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AB7420 Offset: 0x2AB3420 VA: 0x2AB7420
	|-List<KeyValuePair<int, short>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AB9A58 Offset: 0x2AB5A58 VA: 0x2AB9A58
	|-List<KeyValuePair<int, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2ABC0B0 Offset: 0x2AB80B0 VA: 0x2ABC0B0
	|-List<KeyValuePair<int, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2ABE810 Offset: 0x2ABA810 VA: 0x2ABE810
	|-List<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AC0E94 Offset: 0x2ABCE94 VA: 0x2AC0E94
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AC3948 Offset: 0x2ABF948 VA: 0x2AC3948
	|-List<KeyValuePair<Int32Enum, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AC5FA0 Offset: 0x2AC1FA0 VA: 0x2AC5FA0
	|-List<KeyValuePair<Int32Enum, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AC8720 Offset: 0x2AC4720 VA: 0x2AC8720
	|-List<KeyValuePair<object, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2ACAEA0 Offset: 0x2AC6EA0 VA: 0x2ACAEA0
	|-List<KeyValuePair<object, float>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2ACD620 Offset: 0x2AC9620 VA: 0x2ACD620
	|-List<KeyValuePair<float, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2ACFDC4 Offset: 0x2ACBDC4 VA: 0x2ACFDC4
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AD27CC Offset: 0x2ACE7CC VA: 0x2AD27CC
	|-List<StructMultiKey<object, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AD4F2C Offset: 0x2AD0F2C VA: 0x2AD4F2C
	|-List<ValueTuple<short, short>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AD7574 Offset: 0x2AD3574 VA: 0x2AD7574
	|-List<ValueTuple<int, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AD9BCC Offset: 0x2AD5BCC VA: 0x2AD9BCC
	|-List<ValueTuple<int, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2ADC32C Offset: 0x2AD832C VA: 0x2ADC32C
	|-List<ValueTuple<Int32Enum, float>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2ADE9B0 Offset: 0x2ADA9B0 VA: 0x2ADE9B0
	|-List<ValueTuple<Vector3, Vector3>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AE141C Offset: 0x2ADD41C VA: 0x2AE141C
	|-List<ArchetypeUid>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AE3A58 Offset: 0x2ADFA58 VA: 0x2AE3A58
	|-List<bool>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AE60CC Offset: 0x2AE20CC VA: 0x2AE60CC
	|-List<byte>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AE8708 Offset: 0x2AE4708 VA: 0x2AE8708
	|-List<ByteEnum>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AEAD44 Offset: 0x2AE6D44 VA: 0x2AEAD44
	|-List<char>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AED3A8 Offset: 0x2AE93A8 VA: 0x2AED3A8
	|-List<Color>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AEFABC Offset: 0x2AEBABC VA: 0x2AEFABC
	|-List<Color32>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AF2104 Offset: 0x2AEE104 VA: 0x2AF2104
	|-List<DateTime>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AF4750 Offset: 0x2AF0750 VA: 0x2AF4750
	|-List<DateTimeOffset>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AF6DE8 Offset: 0x2AF2DE8 VA: 0x2AF6DE8
	|-List<Decimal>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AF94E4 Offset: 0x2AF54E4 VA: 0x2AF94E4
	|-List<DefencePoint2>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AFBB24 Offset: 0x2AF7B24 VA: 0x2AFBB24
	|-List<double>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2AFE180 Offset: 0x2AFA180 VA: 0x2AFE180
	|-List<EventSummary>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B008E0 Offset: 0x2AFC8E0 VA: 0x2B008E0
	|-List<short>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B02F18 Offset: 0x2AFEF18 VA: 0x2B02F18
	|-List<Int16Enum>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B05550 Offset: 0x2B01550 VA: 0x2B05550
	|-List<int>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B07B84 Offset: 0x2B03B84 VA: 0x2B07B84
	|-List<Int32Enum>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B0A1B8 Offset: 0x2B061B8 VA: 0x2B0A1B8
	|-List<long>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B0C80C Offset: 0x2B0880C VA: 0x2B0C80C
	|-List<InterpretedFrameInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B0EFC8 Offset: 0x2B0AFC8 VA: 0x2B0EFC8
	|-List<JsonPosition>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B11B5C Offset: 0x2B0DB5C VA: 0x2B11B5C
	|-List<MaterialSearchData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B1422C Offset: 0x2B1022C VA: 0x2B1422C
	|-List<MobActionTargetData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B16CF4 Offset: 0x2B12CF4 VA: 0x2B16CF4
	|-List<MobIconLabelData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B19888 Offset: 0x2B15888 VA: 0x2B19888
	|-List<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B1BF90 Offset: 0x2B17F90 VA: 0x2B1BF90
	|-List<PlayerLoopSystem>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B1EB98 Offset: 0x2B1AB98 VA: 0x2B1EB98
	|-List<PlayerLoopSystemInternal>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B21764 Offset: 0x2B1D764 VA: 0x2B21764
	|-List<RangePositionInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B23EE8 Offset: 0x2B1FEE8 VA: 0x2B23EE8
	|-List<ReinforceCristaData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B26628 Offset: 0x2B22628 VA: 0x2B26628
	|-List<sbyte>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B28C6C Offset: 0x2B24C6C VA: 0x2B28C6C
	|-List<float>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B2B2A8 Offset: 0x2B272A8 VA: 0x2B2B2A8
	|-List<SkillIdData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B2D8E0 Offset: 0x2B298E0 VA: 0x2B2D8E0
	|-List<TimeSpan>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B542F8 Offset: 0x2B502F8 VA: 0x2B542F8
	|-List<ushort>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B56930 Offset: 0x2B52930 VA: 0x2B56930
	|-List<uint>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B58F64 Offset: 0x2B54F64 VA: 0x2B58F64
	|-List<ulong>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B5B5AC Offset: 0x2B575AC VA: 0x2B5B5AC
	|-List<Vector2>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B5DC74 Offset: 0x2B59C74 VA: 0x2B5DC74
	|-List<Vector3>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B603F0 Offset: 0x2B5C3F0 VA: 0x2B603F0
	|-List<X509ChainStatus>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B62DE0 Offset: 0x2B5EDE0 VA: 0x2B62DE0
	|-List<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B6657C Offset: 0x2B6257C VA: 0x2B6657C
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B68D34 Offset: 0x2B64D34 VA: 0x2B68D34
	|-List<BoneClip.MotionKeyFrame>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B6B8EC Offset: 0x2B678EC VA: 0x2B6B8EC
	|-List<HouseRecipeManager.RecipeData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B6E478 Offset: 0x2B6A478 VA: 0x2B6E478
	|-List<KadarElexioBuf.SkillIdData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B70AD4 Offset: 0x2B6CAD4 VA: 0x2B70AD4
	|-List<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B73238 Offset: 0x2B6F238 VA: 0x2B73238
	|-List<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B7598C Offset: 0x2B7198C VA: 0x2B7598C
	|-List<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B78048 Offset: 0x2B74048 VA: 0x2B78048
	|-List<NewWaveRoomData.Spotlight>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B7AA10 Offset: 0x2B76A10 VA: 0x2B7AA10
	|-List<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B7D170 Offset: 0x2B79170 VA: 0x2B7D170
	|-List<RegexCharClass.SingleRange>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B7F7D8 Offset: 0x2B7B7D8 VA: 0x2B7F7D8
	|-List<SocialAchievementData.LinkData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B81F38 Offset: 0x2B7DF38 VA: 0x2B81F38
	|-List<TrophyManager.TrophyData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B845CC Offset: 0x2B805CC VA: 0x2B845CC
	|-List<UIEventMenuButton.MessageButtonData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B8718C Offset: 0x2B8318C VA: 0x2B8718C
	|-List<UIFieldMapPanel.PopData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B89B34 Offset: 0x2B85B34 VA: 0x2B89B34
	|-List<UIHouseAddressManager.Town>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B8C1A4 Offset: 0x2B881A4 VA: 0x2B8C1A4
	|-List<UIInfoWindow.LabelPosition>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B8EB4C Offset: 0x2B8AB4C VA: 0x2B8EB4C
	|-List<UIMainManager.DropItemData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B911A4 Offset: 0x2B8D1A4 VA: 0x2B911A4
	|-List<UIScenarioOrderPanel.MissionData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B93960 Offset: 0x2B8F960 VA: 0x2B93960
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B96500 Offset: 0x2B92500 VA: 0x2B96500
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B98C8C Offset: 0x2B94C8C VA: 0x2B98C8C
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2B9B578 Offset: 0x2B97578 VA: 0x2B9B578
	|-List<InstructionList.DebugView.InstructionView>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD568 Offset: 0x2AA9568 VA: 0x2AAD568
	|-List<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AAFCC8 Offset: 0x2AABCC8 VA: 0x2AAFCC8
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AB2310 Offset: 0x2AAE310 VA: 0x2AB2310
	|-List<KeyValuePair<byte, byte>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AB4CF4 Offset: 0x2AB0CF4 VA: 0x2AB4CF4
	|-List<KeyValuePair<byte, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AB7454 Offset: 0x2AB3454 VA: 0x2AB7454
	|-List<KeyValuePair<int, short>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AB9A8C Offset: 0x2AB5A8C VA: 0x2AB9A8C
	|-List<KeyValuePair<int, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2ABC0E4 Offset: 0x2AB80E4 VA: 0x2ABC0E4
	|-List<KeyValuePair<int, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2ABE844 Offset: 0x2ABA844 VA: 0x2ABE844
	|-List<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AC0ED8 Offset: 0x2ABCED8 VA: 0x2AC0ED8
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AC397C Offset: 0x2ABF97C VA: 0x2AC397C
	|-List<KeyValuePair<Int32Enum, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AC5FD4 Offset: 0x2AC1FD4 VA: 0x2AC5FD4
	|-List<KeyValuePair<Int32Enum, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AC8754 Offset: 0x2AC4754 VA: 0x2AC8754
	|-List<KeyValuePair<object, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2ACAED4 Offset: 0x2AC6ED4 VA: 0x2ACAED4
	|-List<KeyValuePair<object, float>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2ACD654 Offset: 0x2AC9654 VA: 0x2ACD654
	|-List<KeyValuePair<float, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2ACFE00 Offset: 0x2ACBE00 VA: 0x2ACFE00
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AD2800 Offset: 0x2ACE800 VA: 0x2AD2800
	|-List<StructMultiKey<object, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AD4F60 Offset: 0x2AD0F60 VA: 0x2AD4F60
	|-List<ValueTuple<short, short>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AD75A8 Offset: 0x2AD35A8 VA: 0x2AD75A8
	|-List<ValueTuple<int, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AD9C00 Offset: 0x2AD5C00 VA: 0x2AD9C00
	|-List<ValueTuple<int, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2ADC360 Offset: 0x2AD8360 VA: 0x2ADC360
	|-List<ValueTuple<Int32Enum, float>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2ADE9F4 Offset: 0x2ADA9F4 VA: 0x2ADE9F4
	|-List<ValueTuple<Vector3, Vector3>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AE1450 Offset: 0x2ADD450 VA: 0x2AE1450
	|-List<ArchetypeUid>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AE3A90 Offset: 0x2ADFA90 VA: 0x2AE3A90
	|-List<bool>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AE6100 Offset: 0x2AE2100 VA: 0x2AE6100
	|-List<byte>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AE873C Offset: 0x2AE473C VA: 0x2AE873C
	|-List<ByteEnum>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AEAD78 Offset: 0x2AE6D78 VA: 0x2AEAD78
	|-List<char>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AED3E0 Offset: 0x2AE93E0 VA: 0x2AED3E0
	|-List<Color>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AEFAF0 Offset: 0x2AEBAF0 VA: 0x2AEFAF0
	|-List<Color32>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AF2138 Offset: 0x2AEE138 VA: 0x2AF2138
	|-List<DateTime>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AF4784 Offset: 0x2AF0784 VA: 0x2AF4784
	|-List<DateTimeOffset>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AF6E44 Offset: 0x2AF2E44 VA: 0x2AF6E44
	|-List<Decimal>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AF9518 Offset: 0x2AF5518 VA: 0x2AF9518
	|-List<DefencePoint2>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AFBB58 Offset: 0x2AF7B58 VA: 0x2AFBB58
	|-List<double>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2AFE1B4 Offset: 0x2AFA1B4 VA: 0x2AFE1B4
	|-List<EventSummary>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B00914 Offset: 0x2AFC914 VA: 0x2B00914
	|-List<short>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B02F4C Offset: 0x2AFEF4C VA: 0x2B02F4C
	|-List<Int16Enum>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B05584 Offset: 0x2B01584 VA: 0x2B05584
	|-List<int>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B07BB8 Offset: 0x2B03BB8 VA: 0x2B07BB8
	|-List<Int32Enum>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B0A1EC Offset: 0x2B061EC VA: 0x2B0A1EC
	|-List<long>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B0C840 Offset: 0x2B08840 VA: 0x2B0C840
	|-List<InterpretedFrameInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B0F00C Offset: 0x2B0B00C VA: 0x2B0F00C
	|-List<JsonPosition>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B11B90 Offset: 0x2B0DB90 VA: 0x2B11B90
	|-List<MaterialSearchData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B14270 Offset: 0x2B10270 VA: 0x2B14270
	|-List<MobActionTargetData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B16D38 Offset: 0x2B12D38 VA: 0x2B16D38
	|-List<MobIconLabelData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B1988C Offset: 0x2B1588C VA: 0x2B1988C
	|-List<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B1BFD8 Offset: 0x2B17FD8 VA: 0x2B1BFD8
	|-List<PlayerLoopSystem>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B1EBE0 Offset: 0x2B1ABE0 VA: 0x2B1EBE0
	|-List<PlayerLoopSystemInternal>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B21798 Offset: 0x2B1D798 VA: 0x2B21798
	|-List<RangePositionInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B23F20 Offset: 0x2B1FF20 VA: 0x2B23F20
	|-List<ReinforceCristaData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B2665C Offset: 0x2B2265C VA: 0x2B2665C
	|-List<sbyte>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B28CA0 Offset: 0x2B24CA0 VA: 0x2B28CA0
	|-List<float>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B2B2DC Offset: 0x2B272DC VA: 0x2B2B2DC
	|-List<SkillIdData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B2D914 Offset: 0x2B29914 VA: 0x2B2D914
	|-List<TimeSpan>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B5432C Offset: 0x2B5032C VA: 0x2B5432C
	|-List<ushort>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B56964 Offset: 0x2B52964 VA: 0x2B56964
	|-List<uint>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B58F98 Offset: 0x2B54F98 VA: 0x2B58F98
	|-List<ulong>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B5B5E0 Offset: 0x2B575E0 VA: 0x2B5B5E0
	|-List<Vector2>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B5DCAC Offset: 0x2B59CAC VA: 0x2B5DCAC
	|-List<Vector3>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B60424 Offset: 0x2B5C424 VA: 0x2B60424
	|-List<X509ChainStatus>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B62E8C Offset: 0x2B5EE8C VA: 0x2B62E8C
	|-List<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B665B0 Offset: 0x2B625B0 VA: 0x2B665B0
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B68D78 Offset: 0x2B64D78 VA: 0x2B68D78
	|-List<BoneClip.MotionKeyFrame>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B6B934 Offset: 0x2B67934 VA: 0x2B6B934
	|-List<HouseRecipeManager.RecipeData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B6E4AC Offset: 0x2B6A4AC VA: 0x2B6E4AC
	|-List<KadarElexioBuf.SkillIdData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B70B0C Offset: 0x2B6CB0C VA: 0x2B70B0C
	|-List<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B73270 Offset: 0x2B6F270 VA: 0x2B73270
	|-List<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B759C0 Offset: 0x2B719C0 VA: 0x2B759C0
	|-List<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B78084 Offset: 0x2B74084 VA: 0x2B78084
	|-List<NewWaveRoomData.Spotlight>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B7AA44 Offset: 0x2B76A44 VA: 0x2B7AA44
	|-List<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B7D1A4 Offset: 0x2B791A4 VA: 0x2B7D1A4
	|-List<RegexCharClass.SingleRange>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B7F80C Offset: 0x2B7B80C VA: 0x2B7F80C
	|-List<SocialAchievementData.LinkData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B81F6C Offset: 0x2B7DF6C VA: 0x2B81F6C
	|-List<TrophyManager.TrophyData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B84610 Offset: 0x2B80610 VA: 0x2B84610
	|-List<UIEventMenuButton.MessageButtonData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B871C8 Offset: 0x2B831C8 VA: 0x2B871C8
	|-List<UIFieldMapPanel.PopData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B89B68 Offset: 0x2B85B68 VA: 0x2B89B68
	|-List<UIHouseAddressManager.Town>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B8C1E0 Offset: 0x2B881E0 VA: 0x2B8C1E0
	|-List<UIInfoWindow.LabelPosition>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B8EB80 Offset: 0x2B8AB80 VA: 0x2B8EB80
	|-List<UIMainManager.DropItemData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B911D8 Offset: 0x2B8D1D8 VA: 0x2B911D8
	|-List<UIScenarioOrderPanel.MissionData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B939A4 Offset: 0x2B8F9A4 VA: 0x2B939A4
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B96534 Offset: 0x2B92534 VA: 0x2B96534
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B98CC8 Offset: 0x2B94CC8 VA: 0x2B98CC8
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2B9B5B4 Offset: 0x2B975B4 VA: 0x2B9B5B4
	|-List<InstructionList.DebugView.InstructionView>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD6C0 Offset: 0x2AA96C0 VA: 0x2AAD6C0
	|-List<KeyValuePair<ArchetypeUid, object>>.Add
	|
	|-RVA: 0x2AAFE20 Offset: 0x2AABE20 VA: 0x2AAFE20
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.Add
	|
	|-RVA: 0x2AB2468 Offset: 0x2AAE468 VA: 0x2AB2468
	|-List<KeyValuePair<byte, byte>>.Add
	|
	|-RVA: 0x2AB4E4C Offset: 0x2AB0E4C VA: 0x2AB4E4C
	|-List<KeyValuePair<byte, object>>.Add
	|
	|-RVA: 0x2AB75AC Offset: 0x2AB35AC VA: 0x2AB75AC
	|-List<KeyValuePair<int, short>>.Add
	|
	|-RVA: 0x2AB9BE4 Offset: 0x2AB5BE4 VA: 0x2AB9BE4
	|-List<KeyValuePair<int, int>>.Add
	|
	|-RVA: 0x2ABC23C Offset: 0x2AB823C VA: 0x2ABC23C
	|-List<KeyValuePair<int, object>>.Add
	|
	|-RVA: 0x2ABE99C Offset: 0x2ABA99C VA: 0x2ABE99C
	|-List<KeyValuePair<Int32Enum, byte>>.Add
	|
	|-RVA: 0x2AC104C Offset: 0x2ABD04C VA: 0x2AC104C
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.Add
	|
	|-RVA: 0x2AC3AD4 Offset: 0x2ABFAD4 VA: 0x2AC3AD4
	|-List<KeyValuePair<Int32Enum, int>>.Add
	|
	|-RVA: 0x2AC612C Offset: 0x2AC212C VA: 0x2AC612C
	|-List<KeyValuePair<Int32Enum, object>>.Add
	|
	|-RVA: 0x2AC88AC Offset: 0x2AC48AC VA: 0x2AC88AC
	|-List<KeyValuePair<object, int>>.Add
	|
	|-RVA: 0x2ACB02C Offset: 0x2AC702C VA: 0x2ACB02C
	|-List<KeyValuePair<object, float>>.Add
	|
	|-RVA: 0x2ACD7AC Offset: 0x2AC97AC VA: 0x2ACD7AC
	|-List<KeyValuePair<float, object>>.Add
	|
	|-RVA: 0x2ACFF80 Offset: 0x2ACBF80 VA: 0x2ACFF80
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.Add
	|
	|-RVA: 0x2AD2958 Offset: 0x2ACE958 VA: 0x2AD2958
	|-List<StructMultiKey<object, object>>.Add
	|
	|-RVA: 0x2AD50B8 Offset: 0x2AD10B8 VA: 0x2AD50B8
	|-List<ValueTuple<short, short>>.Add
	|
	|-RVA: 0x2AD7700 Offset: 0x2AD3700 VA: 0x2AD7700
	|-List<ValueTuple<int, int>>.Add
	|
	|-RVA: 0x2AD9D58 Offset: 0x2AD5D58 VA: 0x2AD9D58
	|-List<ValueTuple<int, object>>.Add
	|
	|-RVA: 0x2ADC4B8 Offset: 0x2AD84B8 VA: 0x2ADC4B8
	|-List<ValueTuple<Int32Enum, float>>.Add
	|
	|-RVA: 0x2ADEB68 Offset: 0x2ADAB68 VA: 0x2ADEB68
	|-List<ValueTuple<Vector3, Vector3>>.Add
	|
	|-RVA: 0x2AE15A8 Offset: 0x2ADD5A8 VA: 0x2AE15A8
	|-List<ArchetypeUid>.Add
	|
	|-RVA: 0x2AE3BE8 Offset: 0x2ADFBE8 VA: 0x2AE3BE8
	|-List<bool>.Add
	|
	|-RVA: 0x2AE6258 Offset: 0x2AE2258 VA: 0x2AE6258
	|-List<byte>.Add
	|
	|-RVA: 0x2AE8894 Offset: 0x2AE4894 VA: 0x2AE8894
	|-List<ByteEnum>.Add
	|
	|-RVA: 0x2AEAED0 Offset: 0x2AE6ED0 VA: 0x2AEAED0
	|-List<char>.Add
	|
	|-RVA: 0x2AED53C Offset: 0x2AE953C VA: 0x2AED53C
	|-List<Color>.Add
	|
	|-RVA: 0x2AEFC48 Offset: 0x2AEBC48 VA: 0x2AEFC48
	|-List<Color32>.Add
	|
	|-RVA: 0x2AF2290 Offset: 0x2AEE290 VA: 0x2AF2290
	|-List<DateTime>.Add
	|
	|-RVA: 0x2AF48DC Offset: 0x2AF08DC VA: 0x2AF48DC
	|-List<DateTimeOffset>.Add
	|
	|-RVA: 0x2AF6F9C Offset: 0x2AF2F9C VA: 0x2AF6F9C
	|-List<Decimal>.Add
	|
	|-RVA: 0x2AF9670 Offset: 0x2AF5670 VA: 0x2AF9670
	|-List<DefencePoint2>.Add
	|
	|-RVA: 0x2AFBCB0 Offset: 0x2AF7CB0 VA: 0x2AFBCB0
	|-List<double>.Add
	|
	|-RVA: 0x2AFE30C Offset: 0x2AFA30C VA: 0x2AFE30C
	|-List<EventSummary>.Add
	|
	|-RVA: 0x2B00A6C Offset: 0x2AFCA6C VA: 0x2B00A6C
	|-List<short>.Add
	|
	|-RVA: 0x2B030A4 Offset: 0x2AFF0A4 VA: 0x2B030A4
	|-List<Int16Enum>.Add
	|
	|-RVA: 0x2B056DC Offset: 0x2B016DC VA: 0x2B056DC
	|-List<int>.Add
	|
	|-RVA: 0x2B07D10 Offset: 0x2B03D10 VA: 0x2B07D10
	|-List<Int32Enum>.Add
	|
	|-RVA: 0x2B0A344 Offset: 0x2B06344 VA: 0x2B0A344
	|-List<long>.Add
	|
	|-RVA: 0x2B0C998 Offset: 0x2B08998 VA: 0x2B0C998
	|-List<InterpretedFrameInfo>.Add
	|
	|-RVA: 0x2B0F180 Offset: 0x2B0B180 VA: 0x2B0F180
	|-List<JsonPosition>.Add
	|
	|-RVA: 0x2B11CE8 Offset: 0x2B0DCE8 VA: 0x2B11CE8
	|-List<MaterialSearchData>.Add
	|
	|-RVA: 0x2B143E4 Offset: 0x2B103E4 VA: 0x2B143E4
	|-List<MobActionTargetData>.Add
	|
	|-RVA: 0x2B16EAC Offset: 0x2B12EAC VA: 0x2B16EAC
	|-List<MobIconLabelData>.Add
	|
	|-RVA: 0x2B199DC Offset: 0x2B159DC VA: 0x2B199DC
	|-List<object>.Add
	|
	|-RVA: 0x2B1C14C Offset: 0x2B1814C VA: 0x2B1C14C
	|-List<PlayerLoopSystem>.Add
	|
	|-RVA: 0x2B1ED54 Offset: 0x2B1AD54 VA: 0x2B1ED54
	|-List<PlayerLoopSystemInternal>.Add
	|
	|-RVA: 0x2B218F0 Offset: 0x2B1D8F0 VA: 0x2B218F0
	|-List<RangePositionInfo>.Add
	|
	|-RVA: 0x2B2407C Offset: 0x2B2007C VA: 0x2B2407C
	|-List<ReinforceCristaData>.Add
	|
	|-RVA: 0x2B267B4 Offset: 0x2B227B4 VA: 0x2B267B4
	|-List<sbyte>.Add
	|
	|-RVA: 0x2B28DF8 Offset: 0x2B24DF8 VA: 0x2B28DF8
	|-List<float>.Add
	|
	|-RVA: 0x2B2B434 Offset: 0x2B27434 VA: 0x2B2B434
	|-List<SkillIdData>.Add
	|
	|-RVA: 0x2B2DA6C Offset: 0x2B29A6C VA: 0x2B2DA6C
	|-List<TimeSpan>.Add
	|
	|-RVA: 0x2B54484 Offset: 0x2B50484 VA: 0x2B54484
	|-List<ushort>.Add
	|
	|-RVA: 0x2B56ABC Offset: 0x2B52ABC VA: 0x2B56ABC
	|-List<uint>.Add
	|
	|-RVA: 0x2B590F0 Offset: 0x2B550F0 VA: 0x2B590F0
	|-List<ulong>.Add
	|
	|-RVA: 0x2B5B738 Offset: 0x2B57738 VA: 0x2B5B738
	|-List<Vector2>.Add
	|
	|-RVA: 0x2B5DE08 Offset: 0x2B59E08 VA: 0x2B5DE08
	|-List<Vector3>.Add
	|
	|-RVA: 0x2B6057C Offset: 0x2B5C57C VA: 0x2B6057C
	|-List<X509ChainStatus>.Add
	|
	|-RVA: 0x2B63040 Offset: 0x2B5F040 VA: 0x2B63040
	|-List<__Il2CppFullySharedGenericType>.Add
	|
	|-RVA: 0x2B66708 Offset: 0x2B62708 VA: 0x2B66708
	|-List<BeforeRenderHelper.OrderBlock>.Add
	|
	|-RVA: 0x2B68EEC Offset: 0x2B64EEC VA: 0x2B68EEC
	|-List<BoneClip.MotionKeyFrame>.Add
	|
	|-RVA: 0x2B6BAA8 Offset: 0x2B67AA8 VA: 0x2B6BAA8
	|-List<HouseRecipeManager.RecipeData>.Add
	|
	|-RVA: 0x2B6E604 Offset: 0x2B6A604 VA: 0x2B6E604
	|-List<KadarElexioBuf.SkillIdData>.Add
	|
	|-RVA: 0x2B70C68 Offset: 0x2B6CC68 VA: 0x2B70C68
	|-List<MissionTextManagerData.CheckIKeywordtemData>.Add
	|
	|-RVA: 0x2B733CC Offset: 0x2B6F3CC VA: 0x2B733CC
	|-List<MissionTextManagerData.PickUpFieldData>.Add
	|
	|-RVA: 0x2B75B18 Offset: 0x2B71B18 VA: 0x2B75B18
	|-List<MobaRoomData.MobaAbilityMasterData>.Add
	|
	|-RVA: 0x2B781F0 Offset: 0x2B741F0 VA: 0x2B781F0
	|-List<NewWaveRoomData.Spotlight>.Add
	|
	|-RVA: 0x2B7AB9C Offset: 0x2B76B9C VA: 0x2B7AB9C
	|-List<NguiDynamicFontController.ApplyTextureInfo>.Add
	|
	|-RVA: 0x2B7D2FC Offset: 0x2B792FC VA: 0x2B7D2FC
	|-List<RegexCharClass.SingleRange>.Add
	|
	|-RVA: 0x2B7F964 Offset: 0x2B7B964 VA: 0x2B7F964
	|-List<SocialAchievementData.LinkData>.Add
	|
	|-RVA: 0x2B820C4 Offset: 0x2B7E0C4 VA: 0x2B820C4
	|-List<TrophyManager.TrophyData>.Add
	|
	|-RVA: 0x2B84784 Offset: 0x2B80784 VA: 0x2B84784
	|-List<UIEventMenuButton.MessageButtonData>.Add
	|
	|-RVA: 0x2B87334 Offset: 0x2B83334 VA: 0x2B87334
	|-List<UIFieldMapPanel.PopData>.Add
	|
	|-RVA: 0x2B89CC0 Offset: 0x2B85CC0 VA: 0x2B89CC0
	|-List<UIHouseAddressManager.Town>.Add
	|
	|-RVA: 0x2B8C34C Offset: 0x2B8834C VA: 0x2B8C34C
	|-List<UIInfoWindow.LabelPosition>.Add
	|
	|-RVA: 0x2B8ECD8 Offset: 0x2B8ACD8 VA: 0x2B8ECD8
	|-List<UIMainManager.DropItemData>.Add
	|
	|-RVA: 0x2B91330 Offset: 0x2B8D330 VA: 0x2B91330
	|-List<UIScenarioOrderPanel.MissionData>.Add
	|
	|-RVA: 0x2B93B18 Offset: 0x2B8FB18 VA: 0x2B93B18
	|-List<UnitySynchronizationContext.WorkRequest>.Add
	|
	|-RVA: 0x2B9668C Offset: 0x2B9268C VA: 0x2B9668C
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Add
	|
	|-RVA: 0x2B98E34 Offset: 0x2B94E34 VA: 0x2B98E34
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.Add
	|
	|-RVA: 0x2B9B720 Offset: 0x2B97720 VA: 0x2B9B720
	|-List<InstructionList.DebugView.InstructionView>.Add
	*/

	// RVA: -1 Offset: -1
	private void AddWithResize(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD724 Offset: 0x2AA9724 VA: 0x2AAD724
	|-List<KeyValuePair<ArchetypeUid, object>>.AddWithResize
	|
	|-RVA: 0x2AAFE7C Offset: 0x2AABE7C VA: 0x2AAFE7C
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.AddWithResize
	|
	|-RVA: 0x2AB24C4 Offset: 0x2AAE4C4 VA: 0x2AB24C4
	|-List<KeyValuePair<byte, byte>>.AddWithResize
	|
	|-RVA: 0x2AB4EB0 Offset: 0x2AB0EB0 VA: 0x2AB4EB0
	|-List<KeyValuePair<byte, object>>.AddWithResize
	|
	|-RVA: 0x2AB7604 Offset: 0x2AB3604 VA: 0x2AB7604
	|-List<KeyValuePair<int, short>>.AddWithResize
	|
	|-RVA: 0x2AB9C3C Offset: 0x2AB5C3C VA: 0x2AB9C3C
	|-List<KeyValuePair<int, int>>.AddWithResize
	|
	|-RVA: 0x2ABC2A0 Offset: 0x2AB82A0 VA: 0x2ABC2A0
	|-List<KeyValuePair<int, object>>.AddWithResize
	|
	|-RVA: 0x2ABE9F4 Offset: 0x2ABA9F4 VA: 0x2ABE9F4
	|-List<KeyValuePair<Int32Enum, byte>>.AddWithResize
	|
	|-RVA: 0x2AC10E8 Offset: 0x2ABD0E8 VA: 0x2AC10E8
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.AddWithResize
	|
	|-RVA: 0x2AC3B2C Offset: 0x2ABFB2C VA: 0x2AC3B2C
	|-List<KeyValuePair<Int32Enum, int>>.AddWithResize
	|
	|-RVA: 0x2AC6190 Offset: 0x2AC2190 VA: 0x2AC6190
	|-List<KeyValuePair<Int32Enum, object>>.AddWithResize
	|
	|-RVA: 0x2AC8910 Offset: 0x2AC4910 VA: 0x2AC8910
	|-List<KeyValuePair<object, int>>.AddWithResize
	|
	|-RVA: 0x2ACB090 Offset: 0x2AC7090 VA: 0x2ACB090
	|-List<KeyValuePair<object, float>>.AddWithResize
	|
	|-RVA: 0x2ACD810 Offset: 0x2AC9810 VA: 0x2ACD810
	|-List<KeyValuePair<float, object>>.AddWithResize
	|
	|-RVA: 0x2AD0004 Offset: 0x2ACC004 VA: 0x2AD0004
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.AddWithResize
	|
	|-RVA: 0x2AD29BC Offset: 0x2ACE9BC VA: 0x2AD29BC
	|-List<StructMultiKey<object, object>>.AddWithResize
	|
	|-RVA: 0x2AD5114 Offset: 0x2AD1114 VA: 0x2AD5114
	|-List<ValueTuple<short, short>>.AddWithResize
	|
	|-RVA: 0x2AD7758 Offset: 0x2AD3758 VA: 0x2AD7758
	|-List<ValueTuple<int, int>>.AddWithResize
	|
	|-RVA: 0x2AD9DBC Offset: 0x2AD5DBC VA: 0x2AD9DBC
	|-List<ValueTuple<int, object>>.AddWithResize
	|
	|-RVA: 0x2ADC510 Offset: 0x2AD8510 VA: 0x2ADC510
	|-List<ValueTuple<Int32Enum, float>>.AddWithResize
	|
	|-RVA: 0x2ADEBF4 Offset: 0x2ADABF4 VA: 0x2ADEBF4
	|-List<ValueTuple<Vector3, Vector3>>.AddWithResize
	|
	|-RVA: 0x2AE1600 Offset: 0x2ADD600 VA: 0x2AE1600
	|-List<ArchetypeUid>.AddWithResize
	|
	|-RVA: 0x2AE3C48 Offset: 0x2ADFC48 VA: 0x2AE3C48
	|-List<bool>.AddWithResize
	|
	|-RVA: 0x2AE62B0 Offset: 0x2AE22B0 VA: 0x2AE62B0
	|-List<byte>.AddWithResize
	|
	|-RVA: 0x2AE88EC Offset: 0x2AE48EC VA: 0x2AE88EC
	|-List<ByteEnum>.AddWithResize
	|
	|-RVA: 0x2AEAF28 Offset: 0x2AE6F28 VA: 0x2AEAF28
	|-List<char>.AddWithResize
	|
	|-RVA: 0x2AED598 Offset: 0x2AE9598 VA: 0x2AED598
	|-List<Color>.AddWithResize
	|
	|-RVA: 0x2AEFCA4 Offset: 0x2AEBCA4 VA: 0x2AEFCA4
	|-List<Color32>.AddWithResize
	|
	|-RVA: 0x2AF22E8 Offset: 0x2AEE2E8 VA: 0x2AF22E8
	|-List<DateTime>.AddWithResize
	|
	|-RVA: 0x2AF4934 Offset: 0x2AF0934 VA: 0x2AF4934
	|-List<DateTimeOffset>.AddWithResize
	|
	|-RVA: 0x2AF6FF4 Offset: 0x2AF2FF4 VA: 0x2AF6FF4
	|-List<Decimal>.AddWithResize
	|
	|-RVA: 0x2AF96C8 Offset: 0x2AF56C8 VA: 0x2AF96C8
	|-List<DefencePoint2>.AddWithResize
	|
	|-RVA: 0x2AFBD08 Offset: 0x2AF7D08 VA: 0x2AFBD08
	|-List<double>.AddWithResize
	|
	|-RVA: 0x2AFE370 Offset: 0x2AFA370 VA: 0x2AFE370
	|-List<EventSummary>.AddWithResize
	|
	|-RVA: 0x2B00AC4 Offset: 0x2AFCAC4 VA: 0x2B00AC4
	|-List<short>.AddWithResize
	|
	|-RVA: 0x2B030FC Offset: 0x2AFF0FC VA: 0x2B030FC
	|-List<Int16Enum>.AddWithResize
	|
	|-RVA: 0x2B05734 Offset: 0x2B01734 VA: 0x2B05734
	|-List<int>.AddWithResize
	|
	|-RVA: 0x2B07D68 Offset: 0x2B03D68 VA: 0x2B07D68
	|-List<Int32Enum>.AddWithResize
	|
	|-RVA: 0x2B0A39C Offset: 0x2B0639C VA: 0x2B0A39C
	|-List<long>.AddWithResize
	|
	|-RVA: 0x2B0C9FC Offset: 0x2B089FC VA: 0x2B0C9FC
	|-List<InterpretedFrameInfo>.AddWithResize
	|
	|-RVA: 0x2B0F21C Offset: 0x2B0B21C VA: 0x2B0F21C
	|-List<JsonPosition>.AddWithResize
	|
	|-RVA: 0x2B11D40 Offset: 0x2B0DD40 VA: 0x2B11D40
	|-List<MaterialSearchData>.AddWithResize
	|
	|-RVA: 0x2B14470 Offset: 0x2B10470 VA: 0x2B14470
	|-List<MobActionTargetData>.AddWithResize
	|
	|-RVA: 0x2B16F48 Offset: 0x2B12F48 VA: 0x2B16F48
	|-List<MobIconLabelData>.AddWithResize
	|
	|-RVA: 0x2B19A38 Offset: 0x2B15A38 VA: 0x2B19A38
	|-List<object>.AddWithResize
	|
	|-RVA: 0x2B1C1E8 Offset: 0x2B181E8 VA: 0x2B1C1E8
	|-List<PlayerLoopSystem>.AddWithResize
	|
	|-RVA: 0x2B1EDF0 Offset: 0x2B1ADF0 VA: 0x2B1EDF0
	|-List<PlayerLoopSystemInternal>.AddWithResize
	|
	|-RVA: 0x2B21954 Offset: 0x2B1D954 VA: 0x2B21954
	|-List<RangePositionInfo>.AddWithResize
	|
	|-RVA: 0x2B240E0 Offset: 0x2B200E0 VA: 0x2B240E0
	|-List<ReinforceCristaData>.AddWithResize
	|
	|-RVA: 0x2B2680C Offset: 0x2B2280C VA: 0x2B2680C
	|-List<sbyte>.AddWithResize
	|
	|-RVA: 0x2B28E50 Offset: 0x2B24E50 VA: 0x2B28E50
	|-List<float>.AddWithResize
	|
	|-RVA: 0x2B2B48C Offset: 0x2B2748C VA: 0x2B2B48C
	|-List<SkillIdData>.AddWithResize
	|
	|-RVA: 0x2B2DAC4 Offset: 0x2B29AC4 VA: 0x2B2DAC4
	|-List<TimeSpan>.AddWithResize
	|
	|-RVA: 0x2B544DC Offset: 0x2B504DC VA: 0x2B544DC
	|-List<ushort>.AddWithResize
	|
	|-RVA: 0x2B56B14 Offset: 0x2B52B14 VA: 0x2B56B14
	|-List<uint>.AddWithResize
	|
	|-RVA: 0x2B59148 Offset: 0x2B55148 VA: 0x2B59148
	|-List<ulong>.AddWithResize
	|
	|-RVA: 0x2B5B790 Offset: 0x2B57790 VA: 0x2B5B790
	|-List<Vector2>.AddWithResize
	|
	|-RVA: 0x2B5DE68 Offset: 0x2B59E68 VA: 0x2B5DE68
	|-List<Vector3>.AddWithResize
	|
	|-RVA: 0x2B605E0 Offset: 0x2B5C5E0 VA: 0x2B605E0
	|-List<X509ChainStatus>.AddWithResize
	|
	|-RVA: 0x2B631E0 Offset: 0x2B5F1E0 VA: 0x2B631E0
	|-List<__Il2CppFullySharedGenericType>.AddWithResize
	|
	|-RVA: 0x2B6676C Offset: 0x2B6276C VA: 0x2B6676C
	|-List<BeforeRenderHelper.OrderBlock>.AddWithResize
	|
	|-RVA: 0x2B68F88 Offset: 0x2B64F88 VA: 0x2B68F88
	|-List<BoneClip.MotionKeyFrame>.AddWithResize
	|
	|-RVA: 0x2B6BB44 Offset: 0x2B67B44 VA: 0x2B6BB44
	|-List<HouseRecipeManager.RecipeData>.AddWithResize
	|
	|-RVA: 0x2B6E65C Offset: 0x2B6A65C VA: 0x2B6E65C
	|-List<KadarElexioBuf.SkillIdData>.AddWithResize
	|
	|-RVA: 0x2B70CCC Offset: 0x2B6CCCC VA: 0x2B70CCC
	|-List<MissionTextManagerData.CheckIKeywordtemData>.AddWithResize
	|
	|-RVA: 0x2B73430 Offset: 0x2B6F430 VA: 0x2B73430
	|-List<MissionTextManagerData.PickUpFieldData>.AddWithResize
	|
	|-RVA: 0x2B75B70 Offset: 0x2B71B70 VA: 0x2B75B70
	|-List<MobaRoomData.MobaAbilityMasterData>.AddWithResize
	|
	|-RVA: 0x2B78274 Offset: 0x2B74274 VA: 0x2B78274
	|-List<NewWaveRoomData.Spotlight>.AddWithResize
	|
	|-RVA: 0x2B7AC00 Offset: 0x2B76C00 VA: 0x2B7AC00
	|-List<NguiDynamicFontController.ApplyTextureInfo>.AddWithResize
	|
	|-RVA: 0x2B7D358 Offset: 0x2B79358 VA: 0x2B7D358
	|-List<RegexCharClass.SingleRange>.AddWithResize
	|
	|-RVA: 0x2B7F9C8 Offset: 0x2B7B9C8 VA: 0x2B7F9C8
	|-List<SocialAchievementData.LinkData>.AddWithResize
	|
	|-RVA: 0x2B8211C Offset: 0x2B7E11C VA: 0x2B8211C
	|-List<TrophyManager.TrophyData>.AddWithResize
	|
	|-RVA: 0x2B84820 Offset: 0x2B80820 VA: 0x2B84820
	|-List<UIEventMenuButton.MessageButtonData>.AddWithResize
	|
	|-RVA: 0x2B873B8 Offset: 0x2B833B8 VA: 0x2B873B8
	|-List<UIFieldMapPanel.PopData>.AddWithResize
	|
	|-RVA: 0x2B89D18 Offset: 0x2B85D18 VA: 0x2B89D18
	|-List<UIHouseAddressManager.Town>.AddWithResize
	|
	|-RVA: 0x2B8C3D0 Offset: 0x2B883D0 VA: 0x2B8C3D0
	|-List<UIInfoWindow.LabelPosition>.AddWithResize
	|
	|-RVA: 0x2B8ED30 Offset: 0x2B8AD30 VA: 0x2B8ED30
	|-List<UIMainManager.DropItemData>.AddWithResize
	|
	|-RVA: 0x2B91394 Offset: 0x2B8D394 VA: 0x2B91394
	|-List<UIScenarioOrderPanel.MissionData>.AddWithResize
	|
	|-RVA: 0x2B93BB4 Offset: 0x2B8FBB4 VA: 0x2B93BB4
	|-List<UnitySynchronizationContext.WorkRequest>.AddWithResize
	|
	|-RVA: 0x2B966F0 Offset: 0x2B926F0 VA: 0x2B966F0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.AddWithResize
	|
	|-RVA: 0x2B98EA8 Offset: 0x2B94EA8 VA: 0x2B98EA8
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.AddWithResize
	|
	|-RVA: 0x2B9B7A4 Offset: 0x2B977A4 VA: 0x2B9B7A4
	|-List<InstructionList.DebugView.InstructionView>.AddWithResize
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD798 Offset: 0x2AA9798 VA: 0x2AAD798
	|-List<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x2AAFEE4 Offset: 0x2AABEE4 VA: 0x2AAFEE4
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.Add
	|
	|-RVA: 0x2AB252C Offset: 0x2AAE52C VA: 0x2AB252C
	|-List<KeyValuePair<byte, byte>>.System.Collections.IList.Add
	|
	|-RVA: 0x2AB4F24 Offset: 0x2AB0F24 VA: 0x2AB4F24
	|-List<KeyValuePair<byte, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x2AB766C Offset: 0x2AB366C VA: 0x2AB766C
	|-List<KeyValuePair<int, short>>.System.Collections.IList.Add
	|
	|-RVA: 0x2AB9CA4 Offset: 0x2AB5CA4 VA: 0x2AB9CA4
	|-List<KeyValuePair<int, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x2ABC314 Offset: 0x2AB8314 VA: 0x2ABC314
	|-List<KeyValuePair<int, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x2ABEA5C Offset: 0x2ABAA5C VA: 0x2ABEA5C
	|-List<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.Add
	|
	|-RVA: 0x2AC1188 Offset: 0x2ABD188 VA: 0x2AC1188
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.Add
	|
	|-RVA: 0x2AC3B94 Offset: 0x2ABFB94 VA: 0x2AC3B94
	|-List<KeyValuePair<Int32Enum, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x2AC6204 Offset: 0x2AC2204 VA: 0x2AC6204
	|-List<KeyValuePair<Int32Enum, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x2AC8984 Offset: 0x2AC4984 VA: 0x2AC8984
	|-List<KeyValuePair<object, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x2ACB104 Offset: 0x2AC7104 VA: 0x2ACB104
	|-List<KeyValuePair<object, float>>.System.Collections.IList.Add
	|
	|-RVA: 0x2ACD884 Offset: 0x2AC9884 VA: 0x2ACD884
	|-List<KeyValuePair<float, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x2AD0090 Offset: 0x2ACC090 VA: 0x2AD0090
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.Add
	|
	|-RVA: 0x2AD2A30 Offset: 0x2ACEA30 VA: 0x2AD2A30
	|-List<StructMultiKey<object, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x2AD517C Offset: 0x2AD117C VA: 0x2AD517C
	|-List<ValueTuple<short, short>>.System.Collections.IList.Add
	|
	|-RVA: 0x2AD77C0 Offset: 0x2AD37C0 VA: 0x2AD77C0
	|-List<ValueTuple<int, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x2AD9E30 Offset: 0x2AD5E30 VA: 0x2AD9E30
	|-List<ValueTuple<int, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x2ADC578 Offset: 0x2AD8578 VA: 0x2ADC578
	|-List<ValueTuple<Int32Enum, float>>.System.Collections.IList.Add
	|
	|-RVA: 0x2ADEC94 Offset: 0x2ADAC94 VA: 0x2ADEC94
	|-List<ValueTuple<Vector3, Vector3>>.System.Collections.IList.Add
	|
	|-RVA: 0x2AE1668 Offset: 0x2ADD668 VA: 0x2AE1668
	|-List<ArchetypeUid>.System.Collections.IList.Add
	|
	|-RVA: 0x2AE3CB4 Offset: 0x2ADFCB4 VA: 0x2AE3CB4
	|-List<bool>.System.Collections.IList.Add
	|
	|-RVA: 0x2AE6318 Offset: 0x2AE2318 VA: 0x2AE6318
	|-List<byte>.System.Collections.IList.Add
	|
	|-RVA: 0x2AE8954 Offset: 0x2AE4954 VA: 0x2AE8954
	|-List<ByteEnum>.System.Collections.IList.Add
	|
	|-RVA: 0x2AEAF90 Offset: 0x2AE6F90 VA: 0x2AEAF90
	|-List<char>.System.Collections.IList.Add
	|
	|-RVA: 0x2AED618 Offset: 0x2AE9618 VA: 0x2AED618
	|-List<Color>.System.Collections.IList.Add
	|
	|-RVA: 0x2AEFD0C Offset: 0x2AEBD0C VA: 0x2AEFD0C
	|-List<Color32>.System.Collections.IList.Add
	|
	|-RVA: 0x2AF2350 Offset: 0x2AEE350 VA: 0x2AF2350
	|-List<DateTime>.System.Collections.IList.Add
	|
	|-RVA: 0x2AF49A0 Offset: 0x2AF09A0 VA: 0x2AF49A0
	|-List<DateTimeOffset>.System.Collections.IList.Add
	|
	|-RVA: 0x2AF7060 Offset: 0x2AF3060 VA: 0x2AF7060
	|-List<Decimal>.System.Collections.IList.Add
	|
	|-RVA: 0x2AF9730 Offset: 0x2AF5730 VA: 0x2AF9730
	|-List<DefencePoint2>.System.Collections.IList.Add
	|
	|-RVA: 0x2AFBD70 Offset: 0x2AF7D70 VA: 0x2AFBD70
	|-List<double>.System.Collections.IList.Add
	|
	|-RVA: 0x2AFE3E4 Offset: 0x2AFA3E4 VA: 0x2AFE3E4
	|-List<EventSummary>.System.Collections.IList.Add
	|
	|-RVA: 0x2B00B2C Offset: 0x2AFCB2C VA: 0x2B00B2C
	|-List<short>.System.Collections.IList.Add
	|
	|-RVA: 0x2B03164 Offset: 0x2AFF164 VA: 0x2B03164
	|-List<Int16Enum>.System.Collections.IList.Add
	|
	|-RVA: 0x2B0579C Offset: 0x2B0179C VA: 0x2B0579C
	|-List<int>.System.Collections.IList.Add
	|
	|-RVA: 0x2B07DD0 Offset: 0x2B03DD0 VA: 0x2B07DD0
	|-List<Int32Enum>.System.Collections.IList.Add
	|
	|-RVA: 0x2B0A404 Offset: 0x2B06404 VA: 0x2B0A404
	|-List<long>.System.Collections.IList.Add
	|
	|-RVA: 0x2B0CA70 Offset: 0x2B08A70 VA: 0x2B0CA70
	|-List<InterpretedFrameInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x2B0F2C8 Offset: 0x2B0B2C8 VA: 0x2B0F2C8
	|-List<JsonPosition>.System.Collections.IList.Add
	|
	|-RVA: 0x2B11DAC Offset: 0x2B0DDAC VA: 0x2B11DAC
	|-List<MaterialSearchData>.System.Collections.IList.Add
	|
	|-RVA: 0x2B14510 Offset: 0x2B10510 VA: 0x2B14510
	|-List<MobActionTargetData>.System.Collections.IList.Add
	|
	|-RVA: 0x2B16FF4 Offset: 0x2B12FF4 VA: 0x2B16FF4
	|-List<MobIconLabelData>.System.Collections.IList.Add
	|
	|-RVA: 0x2B19AA4 Offset: 0x2B15AA4 VA: 0x2B19AA4
	|-List<object>.System.Collections.IList.Add
	|
	|-RVA: 0x2B1C294 Offset: 0x2B18294 VA: 0x2B1C294
	|-List<PlayerLoopSystem>.System.Collections.IList.Add
	|
	|-RVA: 0x2B1EE9C Offset: 0x2B1AE9C VA: 0x2B1EE9C
	|-List<PlayerLoopSystemInternal>.System.Collections.IList.Add
	|
	|-RVA: 0x2B219C8 Offset: 0x2B1D9C8 VA: 0x2B219C8
	|-List<RangePositionInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x2B24154 Offset: 0x2B20154 VA: 0x2B24154
	|-List<ReinforceCristaData>.System.Collections.IList.Add
	|
	|-RVA: 0x2B26874 Offset: 0x2B22874 VA: 0x2B26874
	|-List<sbyte>.System.Collections.IList.Add
	|
	|-RVA: 0x2B28EB8 Offset: 0x2B24EB8 VA: 0x2B28EB8
	|-List<float>.System.Collections.IList.Add
	|
	|-RVA: 0x2B2B4F4 Offset: 0x2B274F4 VA: 0x2B2B4F4
	|-List<SkillIdData>.System.Collections.IList.Add
	|
	|-RVA: 0x2B2DB2C Offset: 0x2B29B2C VA: 0x2B2DB2C
	|-List<TimeSpan>.System.Collections.IList.Add
	|
	|-RVA: 0x2B54544 Offset: 0x2B50544 VA: 0x2B54544
	|-List<ushort>.System.Collections.IList.Add
	|
	|-RVA: 0x2B56B7C Offset: 0x2B52B7C VA: 0x2B56B7C
	|-List<uint>.System.Collections.IList.Add
	|
	|-RVA: 0x2B591B0 Offset: 0x2B551B0 VA: 0x2B591B0
	|-List<ulong>.System.Collections.IList.Add
	|
	|-RVA: 0x2B5B7FC Offset: 0x2B577FC VA: 0x2B5B7FC
	|-List<Vector2>.System.Collections.IList.Add
	|
	|-RVA: 0x2B5DEE8 Offset: 0x2B59EE8 VA: 0x2B5DEE8
	|-List<Vector3>.System.Collections.IList.Add
	|
	|-RVA: 0x2B60654 Offset: 0x2B5C654 VA: 0x2B60654
	|-List<X509ChainStatus>.System.Collections.IList.Add
	|
	|-RVA: 0x2B6332C Offset: 0x2B5F32C VA: 0x2B6332C
	|-List<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	|
	|-RVA: 0x2B667E0 Offset: 0x2B627E0 VA: 0x2B667E0
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Add
	|
	|-RVA: 0x2B6902C Offset: 0x2B6502C VA: 0x2B6902C
	|-List<BoneClip.MotionKeyFrame>.System.Collections.IList.Add
	|
	|-RVA: 0x2B6BBE8 Offset: 0x2B67BE8 VA: 0x2B6BBE8
	|-List<HouseRecipeManager.RecipeData>.System.Collections.IList.Add
	|
	|-RVA: 0x2B6E6C4 Offset: 0x2B6A6C4 VA: 0x2B6E6C4
	|-List<KadarElexioBuf.SkillIdData>.System.Collections.IList.Add
	|
	|-RVA: 0x2B70D40 Offset: 0x2B6CD40 VA: 0x2B70D40
	|-List<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.Add
	|
	|-RVA: 0x2B734A4 Offset: 0x2B6F4A4 VA: 0x2B734A4
	|-List<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.Add
	|
	|-RVA: 0x2B75BDC Offset: 0x2B71BDC VA: 0x2B75BDC
	|-List<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.Add
	|
	|-RVA: 0x2B78300 Offset: 0x2B74300 VA: 0x2B78300
	|-List<NewWaveRoomData.Spotlight>.System.Collections.IList.Add
	|
	|-RVA: 0x2B7AC74 Offset: 0x2B76C74 VA: 0x2B7AC74
	|-List<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x2B7D3C0 Offset: 0x2B793C0 VA: 0x2B7D3C0
	|-List<RegexCharClass.SingleRange>.System.Collections.IList.Add
	|
	|-RVA: 0x2B7FA3C Offset: 0x2B7BA3C VA: 0x2B7FA3C
	|-List<SocialAchievementData.LinkData>.System.Collections.IList.Add
	|
	|-RVA: 0x2B82184 Offset: 0x2B7E184 VA: 0x2B82184
	|-List<TrophyManager.TrophyData>.System.Collections.IList.Add
	|
	|-RVA: 0x2B848CC Offset: 0x2B808CC VA: 0x2B848CC
	|-List<UIEventMenuButton.MessageButtonData>.System.Collections.IList.Add
	|
	|-RVA: 0x2B87444 Offset: 0x2B83444 VA: 0x2B87444
	|-List<UIFieldMapPanel.PopData>.System.Collections.IList.Add
	|
	|-RVA: 0x2B89D80 Offset: 0x2B85D80 VA: 0x2B89D80
	|-List<UIHouseAddressManager.Town>.System.Collections.IList.Add
	|
	|-RVA: 0x2B8C45C Offset: 0x2B8845C VA: 0x2B8C45C
	|-List<UIInfoWindow.LabelPosition>.System.Collections.IList.Add
	|
	|-RVA: 0x2B8ED98 Offset: 0x2B8AD98 VA: 0x2B8ED98
	|-List<UIMainManager.DropItemData>.System.Collections.IList.Add
	|
	|-RVA: 0x2B91408 Offset: 0x2B8D408 VA: 0x2B91408
	|-List<UIScenarioOrderPanel.MissionData>.System.Collections.IList.Add
	|
	|-RVA: 0x2B93C60 Offset: 0x2B8FC60 VA: 0x2B93C60
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Add
	|
	|-RVA: 0x2B96764 Offset: 0x2B92764 VA: 0x2B96764
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Add
	|
	|-RVA: 0x2B98F2C Offset: 0x2B94F2C VA: 0x2B98F2C
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.Add
	|
	|-RVA: 0x2B9B830 Offset: 0x2B97830 VA: 0x2B9B830
	|-List<InstructionList.DebugView.InstructionView>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD948 Offset: 0x2AA9948 VA: 0x2AAD948
	|-List<KeyValuePair<ArchetypeUid, object>>.AddRange
	|
	|-RVA: 0x2AB0088 Offset: 0x2AAC088 VA: 0x2AB0088
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.AddRange
	|
	|-RVA: 0x2AB26D0 Offset: 0x2AAE6D0 VA: 0x2AB26D0
	|-List<KeyValuePair<byte, byte>>.AddRange
	|
	|-RVA: 0x2AB50D4 Offset: 0x2AB10D4 VA: 0x2AB50D4
	|-List<KeyValuePair<byte, object>>.AddRange
	|
	|-RVA: 0x2AB7810 Offset: 0x2AB3810 VA: 0x2AB7810
	|-List<KeyValuePair<int, short>>.AddRange
	|
	|-RVA: 0x2AB9E48 Offset: 0x2AB5E48 VA: 0x2AB9E48
	|-List<KeyValuePair<int, int>>.AddRange
	|
	|-RVA: 0x2ABC4C4 Offset: 0x2AB84C4 VA: 0x2ABC4C4
	|-List<KeyValuePair<int, object>>.AddRange
	|
	|-RVA: 0x2ABEC00 Offset: 0x2ABAC00 VA: 0x2ABEC00
	|-List<KeyValuePair<Int32Enum, byte>>.AddRange
	|
	|-RVA: 0x2AC1374 Offset: 0x2ABD374 VA: 0x2AC1374
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.AddRange
	|
	|-RVA: 0x2AC3D38 Offset: 0x2ABFD38 VA: 0x2AC3D38
	|-List<KeyValuePair<Int32Enum, int>>.AddRange
	|
	|-RVA: 0x2AC63B4 Offset: 0x2AC23B4 VA: 0x2AC63B4
	|-List<KeyValuePair<Int32Enum, object>>.AddRange
	|
	|-RVA: 0x2AC8B34 Offset: 0x2AC4B34 VA: 0x2AC8B34
	|-List<KeyValuePair<object, int>>.AddRange
	|
	|-RVA: 0x2ACB2B4 Offset: 0x2AC72B4 VA: 0x2ACB2B4
	|-List<KeyValuePair<object, float>>.AddRange
	|
	|-RVA: 0x2ACDA34 Offset: 0x2AC9A34 VA: 0x2ACDA34
	|-List<KeyValuePair<float, object>>.AddRange
	|
	|-RVA: 0x2AD0280 Offset: 0x2ACC280 VA: 0x2AD0280
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.AddRange
	|
	|-RVA: 0x2AD2BE0 Offset: 0x2ACEBE0 VA: 0x2AD2BE0
	|-List<StructMultiKey<object, object>>.AddRange
	|
	|-RVA: 0x2AD5320 Offset: 0x2AD1320 VA: 0x2AD5320
	|-List<ValueTuple<short, short>>.AddRange
	|
	|-RVA: 0x2AD7964 Offset: 0x2AD3964 VA: 0x2AD7964
	|-List<ValueTuple<int, int>>.AddRange
	|
	|-RVA: 0x2AD9FE0 Offset: 0x2AD5FE0 VA: 0x2AD9FE0
	|-List<ValueTuple<int, object>>.AddRange
	|
	|-RVA: 0x2ADC71C Offset: 0x2AD871C VA: 0x2ADC71C
	|-List<ValueTuple<Int32Enum, float>>.AddRange
	|
	|-RVA: 0x2ADEE78 Offset: 0x2ADAE78 VA: 0x2ADEE78
	|-List<ValueTuple<Vector3, Vector3>>.AddRange
	|
	|-RVA: 0x2AE180C Offset: 0x2ADD80C VA: 0x2AE180C
	|-List<ArchetypeUid>.AddRange
	|
	|-RVA: 0x2AE3E60 Offset: 0x2ADFE60 VA: 0x2AE3E60
	|-List<bool>.AddRange
	|
	|-RVA: 0x2AE64BC Offset: 0x2AE24BC VA: 0x2AE64BC
	|-List<byte>.AddRange
	|
	|-RVA: 0x2AE8AF8 Offset: 0x2AE4AF8 VA: 0x2AE8AF8
	|-List<ByteEnum>.AddRange
	|
	|-RVA: 0x2AEB134 Offset: 0x2AE7134 VA: 0x2AEB134
	|-List<char>.AddRange
	|
	|-RVA: 0x2AED7C4 Offset: 0x2AE97C4 VA: 0x2AED7C4
	|-List<Color>.AddRange
	|
	|-RVA: 0x2AEFEB0 Offset: 0x2AEBEB0 VA: 0x2AEFEB0
	|-List<Color32>.AddRange
	|
	|-RVA: 0x2AF24F4 Offset: 0x2AEE4F4 VA: 0x2AF24F4
	|-List<DateTime>.AddRange
	|
	|-RVA: 0x2AF4B44 Offset: 0x2AF0B44 VA: 0x2AF4B44
	|-List<DateTimeOffset>.AddRange
	|
	|-RVA: 0x2AF7204 Offset: 0x2AF3204 VA: 0x2AF7204
	|-List<Decimal>.AddRange
	|
	|-RVA: 0x2AF98D4 Offset: 0x2AF58D4 VA: 0x2AF98D4
	|-List<DefencePoint2>.AddRange
	|
	|-RVA: 0x2AFBF14 Offset: 0x2AF7F14 VA: 0x2AFBF14
	|-List<double>.AddRange
	|
	|-RVA: 0x2AFE594 Offset: 0x2AFA594 VA: 0x2AFE594
	|-List<EventSummary>.AddRange
	|
	|-RVA: 0x2B00CD0 Offset: 0x2AFCCD0 VA: 0x2B00CD0
	|-List<short>.AddRange
	|
	|-RVA: 0x2B03308 Offset: 0x2AFF308 VA: 0x2B03308
	|-List<Int16Enum>.AddRange
	|
	|-RVA: 0x2B05940 Offset: 0x2B01940 VA: 0x2B05940
	|-List<int>.AddRange
	|
	|-RVA: 0x2B07F74 Offset: 0x2B03F74 VA: 0x2B07F74
	|-List<Int32Enum>.AddRange
	|
	|-RVA: 0x2B0A5A8 Offset: 0x2B065A8 VA: 0x2B0A5A8
	|-List<long>.AddRange
	|
	|-RVA: 0x2B0CC20 Offset: 0x2B08C20 VA: 0x2B0CC20
	|-List<InterpretedFrameInfo>.AddRange
	|
	|-RVA: 0x2B0F4B8 Offset: 0x2B0B4B8 VA: 0x2B0F4B8
	|-List<JsonPosition>.AddRange
	|
	|-RVA: 0x2B11F50 Offset: 0x2B0DF50 VA: 0x2B11F50
	|-List<MaterialSearchData>.AddRange
	|
	|-RVA: 0x2B146F4 Offset: 0x2B106F4 VA: 0x2B146F4
	|-List<MobActionTargetData>.AddRange
	|
	|-RVA: 0x2B171E4 Offset: 0x2B131E4 VA: 0x2B171E4
	|-List<MobIconLabelData>.AddRange
	|
	|-RVA: 0x2B19C44 Offset: 0x2B15C44 VA: 0x2B19C44
	|-List<object>.AddRange
	|
	|-RVA: 0x2B1C484 Offset: 0x2B18484 VA: 0x2B1C484
	|-List<PlayerLoopSystem>.AddRange
	|
	|-RVA: 0x2B1F08C Offset: 0x2B1B08C VA: 0x2B1F08C
	|-List<PlayerLoopSystemInternal>.AddRange
	|
	|-RVA: 0x2B21B78 Offset: 0x2B1DB78 VA: 0x2B21B78
	|-List<RangePositionInfo>.AddRange
	|
	|-RVA: 0x2B24304 Offset: 0x2B20304 VA: 0x2B24304
	|-List<ReinforceCristaData>.AddRange
	|
	|-RVA: 0x2B26A18 Offset: 0x2B22A18 VA: 0x2B26A18
	|-List<sbyte>.AddRange
	|
	|-RVA: 0x2B2905C Offset: 0x2B2505C VA: 0x2B2905C
	|-List<float>.AddRange
	|
	|-RVA: 0x2B2B698 Offset: 0x2B27698 VA: 0x2B2B698
	|-List<SkillIdData>.AddRange
	|
	|-RVA: 0x2B2DCD0 Offset: 0x2B29CD0 VA: 0x2B2DCD0
	|-List<TimeSpan>.AddRange
	|
	|-RVA: 0x2B546E8 Offset: 0x2B506E8 VA: 0x2B546E8
	|-List<ushort>.AddRange
	|
	|-RVA: 0x2B56D20 Offset: 0x2B52D20 VA: 0x2B56D20
	|-List<uint>.AddRange
	|
	|-RVA: 0x2B59354 Offset: 0x2B55354 VA: 0x2B59354
	|-List<ulong>.AddRange
	|
	|-RVA: 0x2B5B9A0 Offset: 0x2B579A0 VA: 0x2B5B9A0
	|-List<Vector2>.AddRange
	|
	|-RVA: 0x2B5E098 Offset: 0x2B5A098 VA: 0x2B5E098
	|-List<Vector3>.AddRange
	|
	|-RVA: 0x2B60804 Offset: 0x2B5C804 VA: 0x2B60804
	|-List<X509ChainStatus>.AddRange
	|
	|-RVA: 0x2B634F0 Offset: 0x2B5F4F0 VA: 0x2B634F0
	|-List<__Il2CppFullySharedGenericType>.AddRange
	|
	|-RVA: 0x2B66990 Offset: 0x2B62990 VA: 0x2B66990
	|-List<BeforeRenderHelper.OrderBlock>.AddRange
	|
	|-RVA: 0x2B69218 Offset: 0x2B65218 VA: 0x2B69218
	|-List<BoneClip.MotionKeyFrame>.AddRange
	|
	|-RVA: 0x2B6BDD4 Offset: 0x2B67DD4 VA: 0x2B6BDD4
	|-List<HouseRecipeManager.RecipeData>.AddRange
	|
	|-RVA: 0x2B6E868 Offset: 0x2B6A868 VA: 0x2B6E868
	|-List<KadarElexioBuf.SkillIdData>.AddRange
	|
	|-RVA: 0x2B70EF0 Offset: 0x2B6CEF0 VA: 0x2B70EF0
	|-List<MissionTextManagerData.CheckIKeywordtemData>.AddRange
	|
	|-RVA: 0x2B73654 Offset: 0x2B6F654 VA: 0x2B73654
	|-List<MissionTextManagerData.PickUpFieldData>.AddRange
	|
	|-RVA: 0x2B75D80 Offset: 0x2B71D80 VA: 0x2B75D80
	|-List<MobaRoomData.MobaAbilityMasterData>.AddRange
	|
	|-RVA: 0x2B784D0 Offset: 0x2B744D0 VA: 0x2B784D0
	|-List<NewWaveRoomData.Spotlight>.AddRange
	|
	|-RVA: 0x2B7AE24 Offset: 0x2B76E24 VA: 0x2B7AE24
	|-List<NguiDynamicFontController.ApplyTextureInfo>.AddRange
	|
	|-RVA: 0x2B7D564 Offset: 0x2B79564 VA: 0x2B7D564
	|-List<RegexCharClass.SingleRange>.AddRange
	|
	|-RVA: 0x2B7FBEC Offset: 0x2B7BBEC VA: 0x2B7FBEC
	|-List<SocialAchievementData.LinkData>.AddRange
	|
	|-RVA: 0x2B82328 Offset: 0x2B7E328 VA: 0x2B82328
	|-List<TrophyManager.TrophyData>.AddRange
	|
	|-RVA: 0x2B84ABC Offset: 0x2B80ABC VA: 0x2B84ABC
	|-List<UIEventMenuButton.MessageButtonData>.AddRange
	|
	|-RVA: 0x2B87614 Offset: 0x2B83614 VA: 0x2B87614
	|-List<UIFieldMapPanel.PopData>.AddRange
	|
	|-RVA: 0x2B89F24 Offset: 0x2B85F24 VA: 0x2B89F24
	|-List<UIHouseAddressManager.Town>.AddRange
	|
	|-RVA: 0x2B8C62C Offset: 0x2B8862C VA: 0x2B8C62C
	|-List<UIInfoWindow.LabelPosition>.AddRange
	|
	|-RVA: 0x2B8EF3C Offset: 0x2B8AF3C VA: 0x2B8EF3C
	|-List<UIMainManager.DropItemData>.AddRange
	|
	|-RVA: 0x2B915B8 Offset: 0x2B8D5B8 VA: 0x2B915B8
	|-List<UIScenarioOrderPanel.MissionData>.AddRange
	|
	|-RVA: 0x2B93E50 Offset: 0x2B8FE50 VA: 0x2B93E50
	|-List<UnitySynchronizationContext.WorkRequest>.AddRange
	|
	|-RVA: 0x2B96914 Offset: 0x2B92914 VA: 0x2B96914
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.AddRange
	|
	|-RVA: 0x2B990F0 Offset: 0x2B950F0 VA: 0x2B990F0
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.AddRange
	|
	|-RVA: 0x2B9BA00 Offset: 0x2B97A00 VA: 0x2B9BA00
	|-List<InstructionList.DebugView.InstructionView>.AddRange
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> AsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD964 Offset: 0x2AA9964 VA: 0x2AAD964
	|-List<KeyValuePair<ArchetypeUid, object>>.AsReadOnly
	|
	|-RVA: 0x2AB00A4 Offset: 0x2AAC0A4 VA: 0x2AB00A4
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.AsReadOnly
	|
	|-RVA: 0x2AB26EC Offset: 0x2AAE6EC VA: 0x2AB26EC
	|-List<KeyValuePair<byte, byte>>.AsReadOnly
	|
	|-RVA: 0x2AB50F0 Offset: 0x2AB10F0 VA: 0x2AB50F0
	|-List<KeyValuePair<byte, object>>.AsReadOnly
	|
	|-RVA: 0x2AB782C Offset: 0x2AB382C VA: 0x2AB782C
	|-List<KeyValuePair<int, short>>.AsReadOnly
	|
	|-RVA: 0x2AB9E64 Offset: 0x2AB5E64 VA: 0x2AB9E64
	|-List<KeyValuePair<int, int>>.AsReadOnly
	|
	|-RVA: 0x2ABC4E0 Offset: 0x2AB84E0 VA: 0x2ABC4E0
	|-List<KeyValuePair<int, object>>.AsReadOnly
	|
	|-RVA: 0x2ABEC1C Offset: 0x2ABAC1C VA: 0x2ABEC1C
	|-List<KeyValuePair<Int32Enum, byte>>.AsReadOnly
	|
	|-RVA: 0x2AC1390 Offset: 0x2ABD390 VA: 0x2AC1390
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.AsReadOnly
	|
	|-RVA: 0x2AC3D54 Offset: 0x2ABFD54 VA: 0x2AC3D54
	|-List<KeyValuePair<Int32Enum, int>>.AsReadOnly
	|
	|-RVA: 0x2AC63D0 Offset: 0x2AC23D0 VA: 0x2AC63D0
	|-List<KeyValuePair<Int32Enum, object>>.AsReadOnly
	|
	|-RVA: 0x2AC8B50 Offset: 0x2AC4B50 VA: 0x2AC8B50
	|-List<KeyValuePair<object, int>>.AsReadOnly
	|
	|-RVA: 0x2ACB2D0 Offset: 0x2AC72D0 VA: 0x2ACB2D0
	|-List<KeyValuePair<object, float>>.AsReadOnly
	|
	|-RVA: 0x2ACDA50 Offset: 0x2AC9A50 VA: 0x2ACDA50
	|-List<KeyValuePair<float, object>>.AsReadOnly
	|
	|-RVA: 0x2AD029C Offset: 0x2ACC29C VA: 0x2AD029C
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.AsReadOnly
	|
	|-RVA: 0x2AD2BFC Offset: 0x2ACEBFC VA: 0x2AD2BFC
	|-List<StructMultiKey<object, object>>.AsReadOnly
	|
	|-RVA: 0x2AD533C Offset: 0x2AD133C VA: 0x2AD533C
	|-List<ValueTuple<short, short>>.AsReadOnly
	|
	|-RVA: 0x2AD7980 Offset: 0x2AD3980 VA: 0x2AD7980
	|-List<ValueTuple<int, int>>.AsReadOnly
	|
	|-RVA: 0x2AD9FFC Offset: 0x2AD5FFC VA: 0x2AD9FFC
	|-List<ValueTuple<int, object>>.AsReadOnly
	|
	|-RVA: 0x2ADC738 Offset: 0x2AD8738 VA: 0x2ADC738
	|-List<ValueTuple<Int32Enum, float>>.AsReadOnly
	|
	|-RVA: 0x2ADEE94 Offset: 0x2ADAE94 VA: 0x2ADEE94
	|-List<ValueTuple<Vector3, Vector3>>.AsReadOnly
	|
	|-RVA: 0x2AE1828 Offset: 0x2ADD828 VA: 0x2AE1828
	|-List<ArchetypeUid>.AsReadOnly
	|
	|-RVA: 0x2AE3E7C Offset: 0x2ADFE7C VA: 0x2AE3E7C
	|-List<bool>.AsReadOnly
	|
	|-RVA: 0x2AE64D8 Offset: 0x2AE24D8 VA: 0x2AE64D8
	|-List<byte>.AsReadOnly
	|
	|-RVA: 0x2AE8B14 Offset: 0x2AE4B14 VA: 0x2AE8B14
	|-List<ByteEnum>.AsReadOnly
	|
	|-RVA: 0x2AEB150 Offset: 0x2AE7150 VA: 0x2AEB150
	|-List<char>.AsReadOnly
	|
	|-RVA: 0x2AED7E0 Offset: 0x2AE97E0 VA: 0x2AED7E0
	|-List<Color>.AsReadOnly
	|
	|-RVA: 0x2AEFECC Offset: 0x2AEBECC VA: 0x2AEFECC
	|-List<Color32>.AsReadOnly
	|
	|-RVA: 0x2AF2510 Offset: 0x2AEE510 VA: 0x2AF2510
	|-List<DateTime>.AsReadOnly
	|
	|-RVA: 0x2AF4B60 Offset: 0x2AF0B60 VA: 0x2AF4B60
	|-List<DateTimeOffset>.AsReadOnly
	|
	|-RVA: 0x2AF7220 Offset: 0x2AF3220 VA: 0x2AF7220
	|-List<Decimal>.AsReadOnly
	|
	|-RVA: 0x2AF98F0 Offset: 0x2AF58F0 VA: 0x2AF98F0
	|-List<DefencePoint2>.AsReadOnly
	|
	|-RVA: 0x2AFBF30 Offset: 0x2AF7F30 VA: 0x2AFBF30
	|-List<double>.AsReadOnly
	|
	|-RVA: 0x2AFE5B0 Offset: 0x2AFA5B0 VA: 0x2AFE5B0
	|-List<EventSummary>.AsReadOnly
	|
	|-RVA: 0x2B00CEC Offset: 0x2AFCCEC VA: 0x2B00CEC
	|-List<short>.AsReadOnly
	|
	|-RVA: 0x2B03324 Offset: 0x2AFF324 VA: 0x2B03324
	|-List<Int16Enum>.AsReadOnly
	|
	|-RVA: 0x2B0595C Offset: 0x2B0195C VA: 0x2B0595C
	|-List<int>.AsReadOnly
	|
	|-RVA: 0x2B07F90 Offset: 0x2B03F90 VA: 0x2B07F90
	|-List<Int32Enum>.AsReadOnly
	|
	|-RVA: 0x2B0A5C4 Offset: 0x2B065C4 VA: 0x2B0A5C4
	|-List<long>.AsReadOnly
	|
	|-RVA: 0x2B0CC3C Offset: 0x2B08C3C VA: 0x2B0CC3C
	|-List<InterpretedFrameInfo>.AsReadOnly
	|
	|-RVA: 0x2B0F4D4 Offset: 0x2B0B4D4 VA: 0x2B0F4D4
	|-List<JsonPosition>.AsReadOnly
	|
	|-RVA: 0x2B11F6C Offset: 0x2B0DF6C VA: 0x2B11F6C
	|-List<MaterialSearchData>.AsReadOnly
	|
	|-RVA: 0x2B14710 Offset: 0x2B10710 VA: 0x2B14710
	|-List<MobActionTargetData>.AsReadOnly
	|
	|-RVA: 0x2B17200 Offset: 0x2B13200 VA: 0x2B17200
	|-List<MobIconLabelData>.AsReadOnly
	|
	|-RVA: 0x2B19C60 Offset: 0x2B15C60 VA: 0x2B19C60
	|-List<object>.AsReadOnly
	|
	|-RVA: 0x2B1C4A0 Offset: 0x2B184A0 VA: 0x2B1C4A0
	|-List<PlayerLoopSystem>.AsReadOnly
	|
	|-RVA: 0x2B1F0A8 Offset: 0x2B1B0A8 VA: 0x2B1F0A8
	|-List<PlayerLoopSystemInternal>.AsReadOnly
	|
	|-RVA: 0x2B21B94 Offset: 0x2B1DB94 VA: 0x2B21B94
	|-List<RangePositionInfo>.AsReadOnly
	|
	|-RVA: 0x2B24320 Offset: 0x2B20320 VA: 0x2B24320
	|-List<ReinforceCristaData>.AsReadOnly
	|
	|-RVA: 0x2B26A34 Offset: 0x2B22A34 VA: 0x2B26A34
	|-List<sbyte>.AsReadOnly
	|
	|-RVA: 0x2B29078 Offset: 0x2B25078 VA: 0x2B29078
	|-List<float>.AsReadOnly
	|
	|-RVA: 0x2B2B6B4 Offset: 0x2B276B4 VA: 0x2B2B6B4
	|-List<SkillIdData>.AsReadOnly
	|
	|-RVA: 0x2B2DCEC Offset: 0x2B29CEC VA: 0x2B2DCEC
	|-List<TimeSpan>.AsReadOnly
	|
	|-RVA: 0x2B54704 Offset: 0x2B50704 VA: 0x2B54704
	|-List<ushort>.AsReadOnly
	|
	|-RVA: 0x2B56D3C Offset: 0x2B52D3C VA: 0x2B56D3C
	|-List<uint>.AsReadOnly
	|
	|-RVA: 0x2B59370 Offset: 0x2B55370 VA: 0x2B59370
	|-List<ulong>.AsReadOnly
	|
	|-RVA: 0x2B5B9BC Offset: 0x2B579BC VA: 0x2B5B9BC
	|-List<Vector2>.AsReadOnly
	|
	|-RVA: 0x2B5E0B4 Offset: 0x2B5A0B4 VA: 0x2B5E0B4
	|-List<Vector3>.AsReadOnly
	|
	|-RVA: 0x2B60820 Offset: 0x2B5C820 VA: 0x2B60820
	|-List<X509ChainStatus>.AsReadOnly
	|
	|-RVA: 0x2B63510 Offset: 0x2B5F510 VA: 0x2B63510
	|-List<__Il2CppFullySharedGenericType>.AsReadOnly
	|
	|-RVA: 0x2B669AC Offset: 0x2B629AC VA: 0x2B669AC
	|-List<BeforeRenderHelper.OrderBlock>.AsReadOnly
	|
	|-RVA: 0x2B69234 Offset: 0x2B65234 VA: 0x2B69234
	|-List<BoneClip.MotionKeyFrame>.AsReadOnly
	|
	|-RVA: 0x2B6BDF0 Offset: 0x2B67DF0 VA: 0x2B6BDF0
	|-List<HouseRecipeManager.RecipeData>.AsReadOnly
	|
	|-RVA: 0x2B6E884 Offset: 0x2B6A884 VA: 0x2B6E884
	|-List<KadarElexioBuf.SkillIdData>.AsReadOnly
	|
	|-RVA: 0x2B70F0C Offset: 0x2B6CF0C VA: 0x2B70F0C
	|-List<MissionTextManagerData.CheckIKeywordtemData>.AsReadOnly
	|
	|-RVA: 0x2B73670 Offset: 0x2B6F670 VA: 0x2B73670
	|-List<MissionTextManagerData.PickUpFieldData>.AsReadOnly
	|
	|-RVA: 0x2B75D9C Offset: 0x2B71D9C VA: 0x2B75D9C
	|-List<MobaRoomData.MobaAbilityMasterData>.AsReadOnly
	|
	|-RVA: 0x2B784EC Offset: 0x2B744EC VA: 0x2B784EC
	|-List<NewWaveRoomData.Spotlight>.AsReadOnly
	|
	|-RVA: 0x2B7AE40 Offset: 0x2B76E40 VA: 0x2B7AE40
	|-List<NguiDynamicFontController.ApplyTextureInfo>.AsReadOnly
	|
	|-RVA: 0x2B7D580 Offset: 0x2B79580 VA: 0x2B7D580
	|-List<RegexCharClass.SingleRange>.AsReadOnly
	|
	|-RVA: 0x2B7FC08 Offset: 0x2B7BC08 VA: 0x2B7FC08
	|-List<SocialAchievementData.LinkData>.AsReadOnly
	|
	|-RVA: 0x2B82344 Offset: 0x2B7E344 VA: 0x2B82344
	|-List<TrophyManager.TrophyData>.AsReadOnly
	|
	|-RVA: 0x2B84AD8 Offset: 0x2B80AD8 VA: 0x2B84AD8
	|-List<UIEventMenuButton.MessageButtonData>.AsReadOnly
	|
	|-RVA: 0x2B87630 Offset: 0x2B83630 VA: 0x2B87630
	|-List<UIFieldMapPanel.PopData>.AsReadOnly
	|
	|-RVA: 0x2B89F40 Offset: 0x2B85F40 VA: 0x2B89F40
	|-List<UIHouseAddressManager.Town>.AsReadOnly
	|
	|-RVA: 0x2B8C648 Offset: 0x2B88648 VA: 0x2B8C648
	|-List<UIInfoWindow.LabelPosition>.AsReadOnly
	|
	|-RVA: 0x2B8EF58 Offset: 0x2B8AF58 VA: 0x2B8EF58
	|-List<UIMainManager.DropItemData>.AsReadOnly
	|
	|-RVA: 0x2B915D4 Offset: 0x2B8D5D4 VA: 0x2B915D4
	|-List<UIScenarioOrderPanel.MissionData>.AsReadOnly
	|
	|-RVA: 0x2B93E6C Offset: 0x2B8FE6C VA: 0x2B93E6C
	|-List<UnitySynchronizationContext.WorkRequest>.AsReadOnly
	|
	|-RVA: 0x2B96930 Offset: 0x2B92930 VA: 0x2B96930
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.AsReadOnly
	|
	|-RVA: 0x2B9910C Offset: 0x2B9510C VA: 0x2B9910C
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.AsReadOnly
	|
	|-RVA: 0x2B9BA1C Offset: 0x2B97A1C VA: 0x2B9BA1C
	|-List<InstructionList.DebugView.InstructionView>.AsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD9C4 Offset: 0x2AA99C4 VA: 0x2AAD9C4
	|-List<KeyValuePair<ArchetypeUid, object>>.Clear
	|
	|-RVA: 0x2AB0104 Offset: 0x2AAC104 VA: 0x2AB0104
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.Clear
	|
	|-RVA: 0x2AB274C Offset: 0x2AAE74C VA: 0x2AB274C
	|-List<KeyValuePair<byte, byte>>.Clear
	|
	|-RVA: 0x2AB5150 Offset: 0x2AB1150 VA: 0x2AB5150
	|-List<KeyValuePair<byte, object>>.Clear
	|
	|-RVA: 0x2AB788C Offset: 0x2AB388C VA: 0x2AB788C
	|-List<KeyValuePair<int, short>>.Clear
	|
	|-RVA: 0x2AB9EC4 Offset: 0x2AB5EC4 VA: 0x2AB9EC4
	|-List<KeyValuePair<int, int>>.Clear
	|
	|-RVA: 0x2ABC540 Offset: 0x2AB8540 VA: 0x2ABC540
	|-List<KeyValuePair<int, object>>.Clear
	|
	|-RVA: 0x2ABEC7C Offset: 0x2ABAC7C VA: 0x2ABEC7C
	|-List<KeyValuePair<Int32Enum, byte>>.Clear
	|
	|-RVA: 0x2AC13F0 Offset: 0x2ABD3F0 VA: 0x2AC13F0
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.Clear
	|
	|-RVA: 0x2AC3DB4 Offset: 0x2ABFDB4 VA: 0x2AC3DB4
	|-List<KeyValuePair<Int32Enum, int>>.Clear
	|
	|-RVA: 0x2AC6430 Offset: 0x2AC2430 VA: 0x2AC6430
	|-List<KeyValuePair<Int32Enum, object>>.Clear
	|
	|-RVA: 0x2AC8BB0 Offset: 0x2AC4BB0 VA: 0x2AC8BB0
	|-List<KeyValuePair<object, int>>.Clear
	|
	|-RVA: 0x2ACB330 Offset: 0x2AC7330 VA: 0x2ACB330
	|-List<KeyValuePair<object, float>>.Clear
	|
	|-RVA: 0x2ACDAB0 Offset: 0x2AC9AB0 VA: 0x2ACDAB0
	|-List<KeyValuePair<float, object>>.Clear
	|
	|-RVA: 0x2AD02FC Offset: 0x2ACC2FC VA: 0x2AD02FC
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.Clear
	|
	|-RVA: 0x2AD2C5C Offset: 0x2ACEC5C VA: 0x2AD2C5C
	|-List<StructMultiKey<object, object>>.Clear
	|
	|-RVA: 0x2AD539C Offset: 0x2AD139C VA: 0x2AD539C
	|-List<ValueTuple<short, short>>.Clear
	|
	|-RVA: 0x2AD79E0 Offset: 0x2AD39E0 VA: 0x2AD79E0
	|-List<ValueTuple<int, int>>.Clear
	|
	|-RVA: 0x2ADA05C Offset: 0x2AD605C VA: 0x2ADA05C
	|-List<ValueTuple<int, object>>.Clear
	|
	|-RVA: 0x2ADC798 Offset: 0x2AD8798 VA: 0x2ADC798
	|-List<ValueTuple<Int32Enum, float>>.Clear
	|
	|-RVA: 0x2ADEEF4 Offset: 0x2ADAEF4 VA: 0x2ADEEF4
	|-List<ValueTuple<Vector3, Vector3>>.Clear
	|
	|-RVA: 0x2AE1888 Offset: 0x2ADD888 VA: 0x2AE1888
	|-List<ArchetypeUid>.Clear
	|
	|-RVA: 0x2AE3EDC Offset: 0x2ADFEDC VA: 0x2AE3EDC
	|-List<bool>.Clear
	|
	|-RVA: 0x2AE6538 Offset: 0x2AE2538 VA: 0x2AE6538
	|-List<byte>.Clear
	|
	|-RVA: 0x2AE8B74 Offset: 0x2AE4B74 VA: 0x2AE8B74
	|-List<ByteEnum>.Clear
	|
	|-RVA: 0x2AEB1B0 Offset: 0x2AE71B0 VA: 0x2AEB1B0
	|-List<char>.Clear
	|
	|-RVA: 0x2AED840 Offset: 0x2AE9840 VA: 0x2AED840
	|-List<Color>.Clear
	|
	|-RVA: 0x2AEFF2C Offset: 0x2AEBF2C VA: 0x2AEFF2C
	|-List<Color32>.Clear
	|
	|-RVA: 0x2AF2570 Offset: 0x2AEE570 VA: 0x2AF2570
	|-List<DateTime>.Clear
	|
	|-RVA: 0x2AF4BC0 Offset: 0x2AF0BC0 VA: 0x2AF4BC0
	|-List<DateTimeOffset>.Clear
	|
	|-RVA: 0x2AF7280 Offset: 0x2AF3280 VA: 0x2AF7280
	|-List<Decimal>.Clear
	|
	|-RVA: 0x2AF9950 Offset: 0x2AF5950 VA: 0x2AF9950
	|-List<DefencePoint2>.Clear
	|
	|-RVA: 0x2AFBF90 Offset: 0x2AF7F90 VA: 0x2AFBF90
	|-List<double>.Clear
	|
	|-RVA: 0x2AFE610 Offset: 0x2AFA610 VA: 0x2AFE610
	|-List<EventSummary>.Clear
	|
	|-RVA: 0x2B00D4C Offset: 0x2AFCD4C VA: 0x2B00D4C
	|-List<short>.Clear
	|
	|-RVA: 0x2B03384 Offset: 0x2AFF384 VA: 0x2B03384
	|-List<Int16Enum>.Clear
	|
	|-RVA: 0x2B059BC Offset: 0x2B019BC VA: 0x2B059BC
	|-List<int>.Clear
	|
	|-RVA: 0x2B07FF0 Offset: 0x2B03FF0 VA: 0x2B07FF0
	|-List<Int32Enum>.Clear
	|
	|-RVA: 0x2B0A624 Offset: 0x2B06624 VA: 0x2B0A624
	|-List<long>.Clear
	|
	|-RVA: 0x2B0CC9C Offset: 0x2B08C9C VA: 0x2B0CC9C
	|-List<InterpretedFrameInfo>.Clear
	|
	|-RVA: 0x2B0F534 Offset: 0x2B0B534 VA: 0x2B0F534
	|-List<JsonPosition>.Clear
	|
	|-RVA: 0x2B11FCC Offset: 0x2B0DFCC VA: 0x2B11FCC
	|-List<MaterialSearchData>.Clear
	|
	|-RVA: 0x2B14770 Offset: 0x2B10770 VA: 0x2B14770
	|-List<MobActionTargetData>.Clear
	|
	|-RVA: 0x2B17260 Offset: 0x2B13260 VA: 0x2B17260
	|-List<MobIconLabelData>.Clear
	|
	|-RVA: 0x2B19CC0 Offset: 0x2B15CC0 VA: 0x2B19CC0
	|-List<object>.Clear
	|
	|-RVA: 0x2B1C500 Offset: 0x2B18500 VA: 0x2B1C500
	|-List<PlayerLoopSystem>.Clear
	|
	|-RVA: 0x2B1F108 Offset: 0x2B1B108 VA: 0x2B1F108
	|-List<PlayerLoopSystemInternal>.Clear
	|
	|-RVA: 0x2B21BF4 Offset: 0x2B1DBF4 VA: 0x2B21BF4
	|-List<RangePositionInfo>.Clear
	|
	|-RVA: 0x2B24380 Offset: 0x2B20380 VA: 0x2B24380
	|-List<ReinforceCristaData>.Clear
	|
	|-RVA: 0x2B26A94 Offset: 0x2B22A94 VA: 0x2B26A94
	|-List<sbyte>.Clear
	|
	|-RVA: 0x2B290D8 Offset: 0x2B250D8 VA: 0x2B290D8
	|-List<float>.Clear
	|
	|-RVA: 0x2B2B714 Offset: 0x2B27714 VA: 0x2B2B714
	|-List<SkillIdData>.Clear
	|
	|-RVA: 0x2B2DD4C Offset: 0x2B29D4C VA: 0x2B2DD4C
	|-List<TimeSpan>.Clear
	|
	|-RVA: 0x2B54764 Offset: 0x2B50764 VA: 0x2B54764
	|-List<ushort>.Clear
	|
	|-RVA: 0x2B56D9C Offset: 0x2B52D9C VA: 0x2B56D9C
	|-List<uint>.Clear
	|
	|-RVA: 0x2B593D0 Offset: 0x2B553D0 VA: 0x2B593D0
	|-List<ulong>.Clear
	|
	|-RVA: 0x2B5BA1C Offset: 0x2B57A1C VA: 0x2B5BA1C
	|-List<Vector2>.Clear
	|
	|-RVA: 0x2B5E114 Offset: 0x2B5A114 VA: 0x2B5E114
	|-List<Vector3>.Clear
	|
	|-RVA: 0x2B60880 Offset: 0x2B5C880 VA: 0x2B60880
	|-List<X509ChainStatus>.Clear
	|
	|-RVA: 0x2B63574 Offset: 0x2B5F574 VA: 0x2B63574
	|-List<__Il2CppFullySharedGenericType>.Clear
	|
	|-RVA: 0x2B66A0C Offset: 0x2B62A0C VA: 0x2B66A0C
	|-List<BeforeRenderHelper.OrderBlock>.Clear
	|
	|-RVA: 0x2B69294 Offset: 0x2B65294 VA: 0x2B69294
	|-List<BoneClip.MotionKeyFrame>.Clear
	|
	|-RVA: 0x2B6BE50 Offset: 0x2B67E50 VA: 0x2B6BE50
	|-List<HouseRecipeManager.RecipeData>.Clear
	|
	|-RVA: 0x2B6E8E4 Offset: 0x2B6A8E4 VA: 0x2B6E8E4
	|-List<KadarElexioBuf.SkillIdData>.Clear
	|
	|-RVA: 0x2B70F6C Offset: 0x2B6CF6C VA: 0x2B70F6C
	|-List<MissionTextManagerData.CheckIKeywordtemData>.Clear
	|
	|-RVA: 0x2B736D0 Offset: 0x2B6F6D0 VA: 0x2B736D0
	|-List<MissionTextManagerData.PickUpFieldData>.Clear
	|
	|-RVA: 0x2B75DFC Offset: 0x2B71DFC VA: 0x2B75DFC
	|-List<MobaRoomData.MobaAbilityMasterData>.Clear
	|
	|-RVA: 0x2B7854C Offset: 0x2B7454C VA: 0x2B7854C
	|-List<NewWaveRoomData.Spotlight>.Clear
	|
	|-RVA: 0x2B7AEA0 Offset: 0x2B76EA0 VA: 0x2B7AEA0
	|-List<NguiDynamicFontController.ApplyTextureInfo>.Clear
	|
	|-RVA: 0x2B7D5E0 Offset: 0x2B795E0 VA: 0x2B7D5E0
	|-List<RegexCharClass.SingleRange>.Clear
	|
	|-RVA: 0x2B7FC68 Offset: 0x2B7BC68 VA: 0x2B7FC68
	|-List<SocialAchievementData.LinkData>.Clear
	|
	|-RVA: 0x2B823A4 Offset: 0x2B7E3A4 VA: 0x2B823A4
	|-List<TrophyManager.TrophyData>.Clear
	|
	|-RVA: 0x2B84B38 Offset: 0x2B80B38 VA: 0x2B84B38
	|-List<UIEventMenuButton.MessageButtonData>.Clear
	|
	|-RVA: 0x2B87690 Offset: 0x2B83690 VA: 0x2B87690
	|-List<UIFieldMapPanel.PopData>.Clear
	|
	|-RVA: 0x2B89FA0 Offset: 0x2B85FA0 VA: 0x2B89FA0
	|-List<UIHouseAddressManager.Town>.Clear
	|
	|-RVA: 0x2B8C6A8 Offset: 0x2B886A8 VA: 0x2B8C6A8
	|-List<UIInfoWindow.LabelPosition>.Clear
	|
	|-RVA: 0x2B8EFB8 Offset: 0x2B8AFB8 VA: 0x2B8EFB8
	|-List<UIMainManager.DropItemData>.Clear
	|
	|-RVA: 0x2B91634 Offset: 0x2B8D634 VA: 0x2B91634
	|-List<UIScenarioOrderPanel.MissionData>.Clear
	|
	|-RVA: 0x2B93ECC Offset: 0x2B8FECC VA: 0x2B93ECC
	|-List<UnitySynchronizationContext.WorkRequest>.Clear
	|
	|-RVA: 0x2B96990 Offset: 0x2B92990 VA: 0x2B96990
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Clear
	|
	|-RVA: 0x2B9916C Offset: 0x2B9516C VA: 0x2B9916C
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.Clear
	|
	|-RVA: 0x2B9BA7C Offset: 0x2B97A7C VA: 0x2B9BA7C
	|-List<InstructionList.DebugView.InstructionView>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAD9EC Offset: 0x2AA99EC VA: 0x2AAD9EC
	|-List<KeyValuePair<ArchetypeUid, object>>.Contains
	|
	|-RVA: 0x2AB0114 Offset: 0x2AAC114 VA: 0x2AB0114
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.Contains
	|
	|-RVA: 0x2AB275C Offset: 0x2AAE75C VA: 0x2AB275C
	|-List<KeyValuePair<byte, byte>>.Contains
	|
	|-RVA: 0x2AB5178 Offset: 0x2AB1178 VA: 0x2AB5178
	|-List<KeyValuePair<byte, object>>.Contains
	|
	|-RVA: 0x2AB789C Offset: 0x2AB389C VA: 0x2AB789C
	|-List<KeyValuePair<int, short>>.Contains
	|
	|-RVA: 0x2AB9ED4 Offset: 0x2AB5ED4 VA: 0x2AB9ED4
	|-List<KeyValuePair<int, int>>.Contains
	|
	|-RVA: 0x2ABC568 Offset: 0x2AB8568 VA: 0x2ABC568
	|-List<KeyValuePair<int, object>>.Contains
	|
	|-RVA: 0x2ABEC8C Offset: 0x2ABAC8C VA: 0x2ABEC8C
	|-List<KeyValuePair<Int32Enum, byte>>.Contains
	|
	|-RVA: 0x2AC1400 Offset: 0x2ABD400 VA: 0x2AC1400
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.Contains
	|
	|-RVA: 0x2AC3DC4 Offset: 0x2ABFDC4 VA: 0x2AC3DC4
	|-List<KeyValuePair<Int32Enum, int>>.Contains
	|
	|-RVA: 0x2AC6458 Offset: 0x2AC2458 VA: 0x2AC6458
	|-List<KeyValuePair<Int32Enum, object>>.Contains
	|
	|-RVA: 0x2AC8BD8 Offset: 0x2AC4BD8 VA: 0x2AC8BD8
	|-List<KeyValuePair<object, int>>.Contains
	|
	|-RVA: 0x2ACB358 Offset: 0x2AC7358 VA: 0x2ACB358
	|-List<KeyValuePair<object, float>>.Contains
	|
	|-RVA: 0x2ACDAD8 Offset: 0x2AC9AD8 VA: 0x2ACDAD8
	|-List<KeyValuePair<float, object>>.Contains
	|
	|-RVA: 0x2AD0324 Offset: 0x2ACC324 VA: 0x2AD0324
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.Contains
	|
	|-RVA: 0x2AD2C84 Offset: 0x2ACEC84 VA: 0x2AD2C84
	|-List<StructMultiKey<object, object>>.Contains
	|
	|-RVA: 0x2AD53AC Offset: 0x2AD13AC VA: 0x2AD53AC
	|-List<ValueTuple<short, short>>.Contains
	|
	|-RVA: 0x2AD79F0 Offset: 0x2AD39F0 VA: 0x2AD79F0
	|-List<ValueTuple<int, int>>.Contains
	|
	|-RVA: 0x2ADA084 Offset: 0x2AD6084 VA: 0x2ADA084
	|-List<ValueTuple<int, object>>.Contains
	|
	|-RVA: 0x2ADC7A8 Offset: 0x2AD87A8 VA: 0x2ADC7A8
	|-List<ValueTuple<Int32Enum, float>>.Contains
	|
	|-RVA: 0x2ADEF04 Offset: 0x2ADAF04 VA: 0x2ADEF04
	|-List<ValueTuple<Vector3, Vector3>>.Contains
	|
	|-RVA: 0x2AE1898 Offset: 0x2ADD898 VA: 0x2AE1898
	|-List<ArchetypeUid>.Contains
	|
	|-RVA: 0x2AE3EEC Offset: 0x2ADFEEC VA: 0x2AE3EEC
	|-List<bool>.Contains
	|
	|-RVA: 0x2AE6548 Offset: 0x2AE2548 VA: 0x2AE6548
	|-List<byte>.Contains
	|
	|-RVA: 0x2AE8B84 Offset: 0x2AE4B84 VA: 0x2AE8B84
	|-List<ByteEnum>.Contains
	|
	|-RVA: 0x2AEB1C0 Offset: 0x2AE71C0 VA: 0x2AEB1C0
	|-List<char>.Contains
	|
	|-RVA: 0x2AED850 Offset: 0x2AE9850 VA: 0x2AED850
	|-List<Color>.Contains
	|
	|-RVA: 0x2AEFF3C Offset: 0x2AEBF3C VA: 0x2AEFF3C
	|-List<Color32>.Contains
	|
	|-RVA: 0x2AF2580 Offset: 0x2AEE580 VA: 0x2AF2580
	|-List<DateTime>.Contains
	|
	|-RVA: 0x2AF4BD0 Offset: 0x2AF0BD0 VA: 0x2AF4BD0
	|-List<DateTimeOffset>.Contains
	|
	|-RVA: 0x2AF7290 Offset: 0x2AF3290 VA: 0x2AF7290
	|-List<Decimal>.Contains
	|
	|-RVA: 0x2AF9960 Offset: 0x2AF5960 VA: 0x2AF9960
	|-List<DefencePoint2>.Contains
	|
	|-RVA: 0x2AFBFA0 Offset: 0x2AF7FA0 VA: 0x2AFBFA0
	|-List<double>.Contains
	|
	|-RVA: 0x2AFE638 Offset: 0x2AFA638 VA: 0x2AFE638
	|-List<EventSummary>.Contains
	|
	|-RVA: 0x2B00D5C Offset: 0x2AFCD5C VA: 0x2B00D5C
	|-List<short>.Contains
	|
	|-RVA: 0x2B03394 Offset: 0x2AFF394 VA: 0x2B03394
	|-List<Int16Enum>.Contains
	|
	|-RVA: 0x2B059CC Offset: 0x2B019CC VA: 0x2B059CC
	|-List<int>.Contains
	|
	|-RVA: 0x2B08000 Offset: 0x2B04000 VA: 0x2B08000
	|-List<Int32Enum>.Contains
	|
	|-RVA: 0x2B0A634 Offset: 0x2B06634 VA: 0x2B0A634
	|-List<long>.Contains
	|
	|-RVA: 0x2B0CCC4 Offset: 0x2B08CC4 VA: 0x2B0CCC4
	|-List<InterpretedFrameInfo>.Contains
	|
	|-RVA: 0x2B0F55C Offset: 0x2B0B55C VA: 0x2B0F55C
	|-List<JsonPosition>.Contains
	|
	|-RVA: 0x2B11FDC Offset: 0x2B0DFDC VA: 0x2B11FDC
	|-List<MaterialSearchData>.Contains
	|
	|-RVA: 0x2B14780 Offset: 0x2B10780 VA: 0x2B14780
	|-List<MobActionTargetData>.Contains
	|
	|-RVA: 0x2B17288 Offset: 0x2B13288 VA: 0x2B17288
	|-List<MobIconLabelData>.Contains
	|
	|-RVA: 0x2B19CE8 Offset: 0x2B15CE8 VA: 0x2B19CE8
	|-List<object>.Contains
	|
	|-RVA: 0x2B1C528 Offset: 0x2B18528 VA: 0x2B1C528
	|-List<PlayerLoopSystem>.Contains
	|
	|-RVA: 0x2B1F130 Offset: 0x2B1B130 VA: 0x2B1F130
	|-List<PlayerLoopSystemInternal>.Contains
	|
	|-RVA: 0x2B21C1C Offset: 0x2B1DC1C VA: 0x2B21C1C
	|-List<RangePositionInfo>.Contains
	|
	|-RVA: 0x2B24390 Offset: 0x2B20390 VA: 0x2B24390
	|-List<ReinforceCristaData>.Contains
	|
	|-RVA: 0x2B26AA4 Offset: 0x2B22AA4 VA: 0x2B26AA4
	|-List<sbyte>.Contains
	|
	|-RVA: 0x2B290E8 Offset: 0x2B250E8 VA: 0x2B290E8
	|-List<float>.Contains
	|
	|-RVA: 0x2B2B724 Offset: 0x2B27724 VA: 0x2B2B724
	|-List<SkillIdData>.Contains
	|
	|-RVA: 0x2B2DD5C Offset: 0x2B29D5C VA: 0x2B2DD5C
	|-List<TimeSpan>.Contains
	|
	|-RVA: 0x2B54774 Offset: 0x2B50774 VA: 0x2B54774
	|-List<ushort>.Contains
	|
	|-RVA: 0x2B56DAC Offset: 0x2B52DAC VA: 0x2B56DAC
	|-List<uint>.Contains
	|
	|-RVA: 0x2B593E0 Offset: 0x2B553E0 VA: 0x2B593E0
	|-List<ulong>.Contains
	|
	|-RVA: 0x2B5BA2C Offset: 0x2B57A2C VA: 0x2B5BA2C
	|-List<Vector2>.Contains
	|
	|-RVA: 0x2B5E124 Offset: 0x2B5A124 VA: 0x2B5E124
	|-List<Vector3>.Contains
	|
	|-RVA: 0x2B608A8 Offset: 0x2B5C8A8 VA: 0x2B608A8
	|-List<X509ChainStatus>.Contains
	|
	|-RVA: 0x2B635CC Offset: 0x2B5F5CC VA: 0x2B635CC
	|-List<__Il2CppFullySharedGenericType>.Contains
	|
	|-RVA: 0x2B66A34 Offset: 0x2B62A34 VA: 0x2B66A34
	|-List<BeforeRenderHelper.OrderBlock>.Contains
	|
	|-RVA: 0x2B692BC Offset: 0x2B652BC VA: 0x2B692BC
	|-List<BoneClip.MotionKeyFrame>.Contains
	|
	|-RVA: 0x2B6BE78 Offset: 0x2B67E78 VA: 0x2B6BE78
	|-List<HouseRecipeManager.RecipeData>.Contains
	|
	|-RVA: 0x2B6E8F4 Offset: 0x2B6A8F4 VA: 0x2B6E8F4
	|-List<KadarElexioBuf.SkillIdData>.Contains
	|
	|-RVA: 0x2B70F7C Offset: 0x2B6CF7C VA: 0x2B70F7C
	|-List<MissionTextManagerData.CheckIKeywordtemData>.Contains
	|
	|-RVA: 0x2B736E0 Offset: 0x2B6F6E0 VA: 0x2B736E0
	|-List<MissionTextManagerData.PickUpFieldData>.Contains
	|
	|-RVA: 0x2B75E0C Offset: 0x2B71E0C VA: 0x2B75E0C
	|-List<MobaRoomData.MobaAbilityMasterData>.Contains
	|
	|-RVA: 0x2B78574 Offset: 0x2B74574 VA: 0x2B78574
	|-List<NewWaveRoomData.Spotlight>.Contains
	|
	|-RVA: 0x2B7AEC8 Offset: 0x2B76EC8 VA: 0x2B7AEC8
	|-List<NguiDynamicFontController.ApplyTextureInfo>.Contains
	|
	|-RVA: 0x2B7D5F0 Offset: 0x2B795F0 VA: 0x2B7D5F0
	|-List<RegexCharClass.SingleRange>.Contains
	|
	|-RVA: 0x2B7FC90 Offset: 0x2B7BC90 VA: 0x2B7FC90
	|-List<SocialAchievementData.LinkData>.Contains
	|
	|-RVA: 0x2B823B4 Offset: 0x2B7E3B4 VA: 0x2B823B4
	|-List<TrophyManager.TrophyData>.Contains
	|
	|-RVA: 0x2B84B60 Offset: 0x2B80B60 VA: 0x2B84B60
	|-List<UIEventMenuButton.MessageButtonData>.Contains
	|
	|-RVA: 0x2B876B8 Offset: 0x2B836B8 VA: 0x2B876B8
	|-List<UIFieldMapPanel.PopData>.Contains
	|
	|-RVA: 0x2B89FB0 Offset: 0x2B85FB0 VA: 0x2B89FB0
	|-List<UIHouseAddressManager.Town>.Contains
	|
	|-RVA: 0x2B8C6D0 Offset: 0x2B886D0 VA: 0x2B8C6D0
	|-List<UIInfoWindow.LabelPosition>.Contains
	|
	|-RVA: 0x2B8EFC8 Offset: 0x2B8AFC8 VA: 0x2B8EFC8
	|-List<UIMainManager.DropItemData>.Contains
	|
	|-RVA: 0x2B9165C Offset: 0x2B8D65C VA: 0x2B9165C
	|-List<UIScenarioOrderPanel.MissionData>.Contains
	|
	|-RVA: 0x2B93EF4 Offset: 0x2B8FEF4 VA: 0x2B93EF4
	|-List<UnitySynchronizationContext.WorkRequest>.Contains
	|
	|-RVA: 0x2B969B8 Offset: 0x2B929B8 VA: 0x2B969B8
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Contains
	|
	|-RVA: 0x2B9917C Offset: 0x2B9517C VA: 0x2B9917C
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.Contains
	|
	|-RVA: 0x2B9BAA4 Offset: 0x2B97AA4 VA: 0x2B9BAA4
	|-List<InstructionList.DebugView.InstructionView>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADA34 Offset: 0x2AA9A34 VA: 0x2AADA34
	|-List<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AB0160 Offset: 0x2AAC160 VA: 0x2AB0160
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AB27A8 Offset: 0x2AAE7A8 VA: 0x2AB27A8
	|-List<KeyValuePair<byte, byte>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AB51C0 Offset: 0x2AB11C0 VA: 0x2AB51C0
	|-List<KeyValuePair<byte, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AB78E4 Offset: 0x2AB38E4 VA: 0x2AB78E4
	|-List<KeyValuePair<int, short>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AB9F1C Offset: 0x2AB5F1C VA: 0x2AB9F1C
	|-List<KeyValuePair<int, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2ABC5B0 Offset: 0x2AB85B0 VA: 0x2ABC5B0
	|-List<KeyValuePair<int, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2ABECD4 Offset: 0x2ABACD4 VA: 0x2ABECD4
	|-List<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AC1474 Offset: 0x2ABD474 VA: 0x2AC1474
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AC3E0C Offset: 0x2ABFE0C VA: 0x2AC3E0C
	|-List<KeyValuePair<Int32Enum, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AC64A0 Offset: 0x2AC24A0 VA: 0x2AC64A0
	|-List<KeyValuePair<Int32Enum, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AC8C20 Offset: 0x2AC4C20 VA: 0x2AC8C20
	|-List<KeyValuePair<object, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2ACB3A0 Offset: 0x2AC73A0 VA: 0x2ACB3A0
	|-List<KeyValuePair<object, float>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2ACDB20 Offset: 0x2AC9B20 VA: 0x2ACDB20
	|-List<KeyValuePair<float, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AD0384 Offset: 0x2ACC384 VA: 0x2AD0384
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AD2CCC Offset: 0x2ACECCC VA: 0x2AD2CCC
	|-List<StructMultiKey<object, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AD53F8 Offset: 0x2AD13F8 VA: 0x2AD53F8
	|-List<ValueTuple<short, short>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AD7A38 Offset: 0x2AD3A38 VA: 0x2AD7A38
	|-List<ValueTuple<int, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2ADA0CC Offset: 0x2AD60CC VA: 0x2ADA0CC
	|-List<ValueTuple<int, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2ADC7F0 Offset: 0x2AD87F0 VA: 0x2ADC7F0
	|-List<ValueTuple<Int32Enum, float>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2ADEF70 Offset: 0x2ADAF70 VA: 0x2ADEF70
	|-List<ValueTuple<Vector3, Vector3>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AE18E0 Offset: 0x2ADD8E0 VA: 0x2AE18E0
	|-List<ArchetypeUid>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AE3F38 Offset: 0x2ADFF38 VA: 0x2AE3F38
	|-List<bool>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AE6590 Offset: 0x2AE2590 VA: 0x2AE6590
	|-List<byte>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AE8BCC Offset: 0x2AE4BCC VA: 0x2AE8BCC
	|-List<ByteEnum>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AEB208 Offset: 0x2AE7208 VA: 0x2AEB208
	|-List<char>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AED898 Offset: 0x2AE9898 VA: 0x2AED898
	|-List<Color>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AEFF88 Offset: 0x2AEBF88 VA: 0x2AEFF88
	|-List<Color32>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AF25C8 Offset: 0x2AEE5C8 VA: 0x2AF25C8
	|-List<DateTime>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AF4C18 Offset: 0x2AF0C18 VA: 0x2AF4C18
	|-List<DateTimeOffset>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AF72D8 Offset: 0x2AF32D8 VA: 0x2AF72D8
	|-List<Decimal>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AF99A8 Offset: 0x2AF59A8 VA: 0x2AF99A8
	|-List<DefencePoint2>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AFBFE8 Offset: 0x2AF7FE8 VA: 0x2AFBFE8
	|-List<double>.System.Collections.IList.Contains
	|
	|-RVA: 0x2AFE680 Offset: 0x2AFA680 VA: 0x2AFE680
	|-List<EventSummary>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B00DA4 Offset: 0x2AFCDA4 VA: 0x2B00DA4
	|-List<short>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B033DC Offset: 0x2AFF3DC VA: 0x2B033DC
	|-List<Int16Enum>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B05A14 Offset: 0x2B01A14 VA: 0x2B05A14
	|-List<int>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B08048 Offset: 0x2B04048 VA: 0x2B08048
	|-List<Int32Enum>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B0A67C Offset: 0x2B0667C VA: 0x2B0A67C
	|-List<long>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B0CD0C Offset: 0x2B08D0C VA: 0x2B0CD0C
	|-List<InterpretedFrameInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B0F5C8 Offset: 0x2B0B5C8 VA: 0x2B0F5C8
	|-List<JsonPosition>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B12024 Offset: 0x2B0E024 VA: 0x2B12024
	|-List<MaterialSearchData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B147EC Offset: 0x2B107EC VA: 0x2B147EC
	|-List<MobActionTargetData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B172F4 Offset: 0x2B132F4 VA: 0x2B172F4
	|-List<MobIconLabelData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B19D30 Offset: 0x2B15D30 VA: 0x2B19D30
	|-List<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B1C594 Offset: 0x2B18594 VA: 0x2B1C594
	|-List<PlayerLoopSystem>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B1F19C Offset: 0x2B1B19C VA: 0x2B1F19C
	|-List<PlayerLoopSystemInternal>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B21C64 Offset: 0x2B1DC64 VA: 0x2B21C64
	|-List<RangePositionInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B243DC Offset: 0x2B203DC VA: 0x2B243DC
	|-List<ReinforceCristaData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B26AEC Offset: 0x2B22AEC VA: 0x2B26AEC
	|-List<sbyte>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B29130 Offset: 0x2B25130 VA: 0x2B29130
	|-List<float>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B2B76C Offset: 0x2B2776C VA: 0x2B2B76C
	|-List<SkillIdData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B2DDA4 Offset: 0x2B29DA4 VA: 0x2B2DDA4
	|-List<TimeSpan>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B547BC Offset: 0x2B507BC VA: 0x2B547BC
	|-List<ushort>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B56DF4 Offset: 0x2B52DF4 VA: 0x2B56DF4
	|-List<uint>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B59428 Offset: 0x2B55428 VA: 0x2B59428
	|-List<ulong>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B5BA74 Offset: 0x2B57A74 VA: 0x2B5BA74
	|-List<Vector2>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B5E16C Offset: 0x2B5A16C VA: 0x2B5E16C
	|-List<Vector3>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B608F0 Offset: 0x2B5C8F0 VA: 0x2B608F0
	|-List<X509ChainStatus>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B636A8 Offset: 0x2B5F6A8 VA: 0x2B636A8
	|-List<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B66A7C Offset: 0x2B62A7C VA: 0x2B66A7C
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B69328 Offset: 0x2B65328 VA: 0x2B69328
	|-List<BoneClip.MotionKeyFrame>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B6BEE4 Offset: 0x2B67EE4 VA: 0x2B6BEE4
	|-List<HouseRecipeManager.RecipeData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B6E93C Offset: 0x2B6A93C VA: 0x2B6E93C
	|-List<KadarElexioBuf.SkillIdData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B70FC8 Offset: 0x2B6CFC8 VA: 0x2B70FC8
	|-List<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B7372C Offset: 0x2B6F72C VA: 0x2B7372C
	|-List<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B75E54 Offset: 0x2B71E54 VA: 0x2B75E54
	|-List<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B785D4 Offset: 0x2B745D4 VA: 0x2B785D4
	|-List<NewWaveRoomData.Spotlight>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B7AF10 Offset: 0x2B76F10 VA: 0x2B7AF10
	|-List<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B7D63C Offset: 0x2B7963C VA: 0x2B7D63C
	|-List<RegexCharClass.SingleRange>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B7FCD8 Offset: 0x2B7BCD8 VA: 0x2B7FCD8
	|-List<SocialAchievementData.LinkData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B823FC Offset: 0x2B7E3FC VA: 0x2B823FC
	|-List<TrophyManager.TrophyData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B84BCC Offset: 0x2B80BCC VA: 0x2B84BCC
	|-List<UIEventMenuButton.MessageButtonData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B87718 Offset: 0x2B83718 VA: 0x2B87718
	|-List<UIFieldMapPanel.PopData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B89FF8 Offset: 0x2B85FF8 VA: 0x2B89FF8
	|-List<UIHouseAddressManager.Town>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B8C730 Offset: 0x2B88730 VA: 0x2B8C730
	|-List<UIInfoWindow.LabelPosition>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B8F010 Offset: 0x2B8B010 VA: 0x2B8F010
	|-List<UIMainManager.DropItemData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B916A4 Offset: 0x2B8D6A4 VA: 0x2B916A4
	|-List<UIScenarioOrderPanel.MissionData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B93F60 Offset: 0x2B8FF60 VA: 0x2B93F60
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B96A00 Offset: 0x2B92A00 VA: 0x2B96A00
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B991DC Offset: 0x2B951DC VA: 0x2B991DC
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2B9BB04 Offset: 0x2B97B04 VA: 0x2B9BB04
	|-List<InstructionList.DebugView.InstructionView>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADB08 Offset: 0x2AA9B08 VA: 0x2AADB08
	|-List<KeyValuePair<ArchetypeUid, object>>.CopyTo
	|
	|-RVA: 0x2AB0234 Offset: 0x2AAC234 VA: 0x2AB0234
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.CopyTo
	|
	|-RVA: 0x2AB287C Offset: 0x2AAE87C VA: 0x2AB287C
	|-List<KeyValuePair<byte, byte>>.CopyTo
	|
	|-RVA: 0x2AB5294 Offset: 0x2AB1294 VA: 0x2AB5294
	|-List<KeyValuePair<byte, object>>.CopyTo
	|
	|-RVA: 0x2AB79B8 Offset: 0x2AB39B8 VA: 0x2AB79B8
	|-List<KeyValuePair<int, short>>.CopyTo
	|
	|-RVA: 0x2AB9FF0 Offset: 0x2AB5FF0 VA: 0x2AB9FF0
	|-List<KeyValuePair<int, int>>.CopyTo
	|
	|-RVA: 0x2ABC684 Offset: 0x2AB8684 VA: 0x2ABC684
	|-List<KeyValuePair<int, object>>.CopyTo
	|
	|-RVA: 0x2ABEDA8 Offset: 0x2ABADA8 VA: 0x2ABEDA8
	|-List<KeyValuePair<Int32Enum, byte>>.CopyTo
	|
	|-RVA: 0x2AC1570 Offset: 0x2ABD570 VA: 0x2AC1570
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.CopyTo
	|
	|-RVA: 0x2AC3EE0 Offset: 0x2ABFEE0 VA: 0x2AC3EE0
	|-List<KeyValuePair<Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x2AC6574 Offset: 0x2AC2574 VA: 0x2AC6574
	|-List<KeyValuePair<Int32Enum, object>>.CopyTo
	|
	|-RVA: 0x2AC8CF4 Offset: 0x2AC4CF4 VA: 0x2AC8CF4
	|-List<KeyValuePair<object, int>>.CopyTo
	|
	|-RVA: 0x2ACB474 Offset: 0x2AC7474 VA: 0x2ACB474
	|-List<KeyValuePair<object, float>>.CopyTo
	|
	|-RVA: 0x2ACDBF4 Offset: 0x2AC9BF4 VA: 0x2ACDBF4
	|-List<KeyValuePair<float, object>>.CopyTo
	|
	|-RVA: 0x2AD046C Offset: 0x2ACC46C VA: 0x2AD046C
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.CopyTo
	|
	|-RVA: 0x2AD2DA0 Offset: 0x2ACEDA0 VA: 0x2AD2DA0
	|-List<StructMultiKey<object, object>>.CopyTo
	|
	|-RVA: 0x2AD54CC Offset: 0x2AD14CC VA: 0x2AD54CC
	|-List<ValueTuple<short, short>>.CopyTo
	|
	|-RVA: 0x2AD7B0C Offset: 0x2AD3B0C VA: 0x2AD7B0C
	|-List<ValueTuple<int, int>>.CopyTo
	|
	|-RVA: 0x2ADA1A0 Offset: 0x2AD61A0 VA: 0x2ADA1A0
	|-List<ValueTuple<int, object>>.CopyTo
	|
	|-RVA: 0x2ADC8C4 Offset: 0x2AD88C4 VA: 0x2ADC8C4
	|-List<ValueTuple<Int32Enum, float>>.CopyTo
	|
	|-RVA: 0x2ADF06C Offset: 0x2ADB06C VA: 0x2ADF06C
	|-List<ValueTuple<Vector3, Vector3>>.CopyTo
	|
	|-RVA: 0x2AE19B4 Offset: 0x2ADD9B4 VA: 0x2AE19B4
	|-List<ArchetypeUid>.CopyTo
	|
	|-RVA: 0x2AE400C Offset: 0x2AE000C VA: 0x2AE400C
	|-List<bool>.CopyTo
	|
	|-RVA: 0x2AE6664 Offset: 0x2AE2664 VA: 0x2AE6664
	|-List<byte>.CopyTo
	|
	|-RVA: 0x2AE8CA0 Offset: 0x2AE4CA0 VA: 0x2AE8CA0
	|-List<ByteEnum>.CopyTo
	|
	|-RVA: 0x2AEB2DC Offset: 0x2AE72DC VA: 0x2AEB2DC
	|-List<char>.CopyTo
	|
	|-RVA: 0x2AED970 Offset: 0x2AE9970 VA: 0x2AED970
	|-List<Color>.CopyTo
	|
	|-RVA: 0x2AF005C Offset: 0x2AEC05C VA: 0x2AF005C
	|-List<Color32>.CopyTo
	|
	|-RVA: 0x2AF269C Offset: 0x2AEE69C VA: 0x2AF269C
	|-List<DateTime>.CopyTo
	|
	|-RVA: 0x2AF4CEC Offset: 0x2AF0CEC VA: 0x2AF4CEC
	|-List<DateTimeOffset>.CopyTo
	|
	|-RVA: 0x2AF73AC Offset: 0x2AF33AC VA: 0x2AF73AC
	|-List<Decimal>.CopyTo
	|
	|-RVA: 0x2AF9A7C Offset: 0x2AF5A7C VA: 0x2AF9A7C
	|-List<DefencePoint2>.CopyTo
	|
	|-RVA: 0x2AFC0BC Offset: 0x2AF80BC VA: 0x2AFC0BC
	|-List<double>.CopyTo
	|
	|-RVA: 0x2AFE754 Offset: 0x2AFA754 VA: 0x2AFE754
	|-List<EventSummary>.CopyTo
	|
	|-RVA: 0x2B00E78 Offset: 0x2AFCE78 VA: 0x2B00E78
	|-List<short>.CopyTo
	|
	|-RVA: 0x2B034B0 Offset: 0x2AFF4B0 VA: 0x2B034B0
	|-List<Int16Enum>.CopyTo
	|
	|-RVA: 0x2B05AE8 Offset: 0x2B01AE8 VA: 0x2B05AE8
	|-List<int>.CopyTo
	|
	|-RVA: 0x2B0811C Offset: 0x2B0411C VA: 0x2B0811C
	|-List<Int32Enum>.CopyTo
	|
	|-RVA: 0x2B0A750 Offset: 0x2B06750 VA: 0x2B0A750
	|-List<long>.CopyTo
	|
	|-RVA: 0x2B0CDE0 Offset: 0x2B08DE0 VA: 0x2B0CDE0
	|-List<InterpretedFrameInfo>.CopyTo
	|
	|-RVA: 0x2B0F6C4 Offset: 0x2B0B6C4 VA: 0x2B0F6C4
	|-List<JsonPosition>.CopyTo
	|
	|-RVA: 0x2B120F8 Offset: 0x2B0E0F8 VA: 0x2B120F8
	|-List<MaterialSearchData>.CopyTo
	|
	|-RVA: 0x2B148E8 Offset: 0x2B108E8 VA: 0x2B148E8
	|-List<MobActionTargetData>.CopyTo
	|
	|-RVA: 0x2B173F0 Offset: 0x2B133F0 VA: 0x2B173F0
	|-List<MobIconLabelData>.CopyTo
	|
	|-RVA: 0x2B19E0C Offset: 0x2B15E0C VA: 0x2B19E0C
	|-List<object>.CopyTo
	|
	|-RVA: 0x2B1C690 Offset: 0x2B18690 VA: 0x2B1C690
	|-List<PlayerLoopSystem>.CopyTo
	|
	|-RVA: 0x2B1F298 Offset: 0x2B1B298 VA: 0x2B1F298
	|-List<PlayerLoopSystemInternal>.CopyTo
	|
	|-RVA: 0x2B21D38 Offset: 0x2B1DD38 VA: 0x2B21D38
	|-List<RangePositionInfo>.CopyTo
	|
	|-RVA: 0x2B244B4 Offset: 0x2B204B4 VA: 0x2B244B4
	|-List<ReinforceCristaData>.CopyTo
	|
	|-RVA: 0x2B26BC0 Offset: 0x2B22BC0 VA: 0x2B26BC0
	|-List<sbyte>.CopyTo
	|
	|-RVA: 0x2B29204 Offset: 0x2B25204 VA: 0x2B29204
	|-List<float>.CopyTo
	|
	|-RVA: 0x2B2B840 Offset: 0x2B27840 VA: 0x2B2B840
	|-List<SkillIdData>.CopyTo
	|
	|-RVA: 0x2B2DE78 Offset: 0x2B29E78 VA: 0x2B2DE78
	|-List<TimeSpan>.CopyTo
	|
	|-RVA: 0x2B54890 Offset: 0x2B50890 VA: 0x2B54890
	|-List<ushort>.CopyTo
	|
	|-RVA: 0x2B56EC8 Offset: 0x2B52EC8 VA: 0x2B56EC8
	|-List<uint>.CopyTo
	|
	|-RVA: 0x2B594FC Offset: 0x2B554FC VA: 0x2B594FC
	|-List<ulong>.CopyTo
	|
	|-RVA: 0x2B5BB48 Offset: 0x2B57B48 VA: 0x2B5BB48
	|-List<Vector2>.CopyTo
	|
	|-RVA: 0x2B5E244 Offset: 0x2B5A244 VA: 0x2B5E244
	|-List<Vector3>.CopyTo
	|
	|-RVA: 0x2B609C4 Offset: 0x2B5C9C4 VA: 0x2B609C4
	|-List<X509ChainStatus>.CopyTo
	|
	|-RVA: 0x2B637DC Offset: 0x2B5F7DC VA: 0x2B637DC
	|-List<__Il2CppFullySharedGenericType>.CopyTo
	|
	|-RVA: 0x2B66B50 Offset: 0x2B62B50 VA: 0x2B66B50
	|-List<BeforeRenderHelper.OrderBlock>.CopyTo
	|
	|-RVA: 0x2B69424 Offset: 0x2B65424 VA: 0x2B69424
	|-List<BoneClip.MotionKeyFrame>.CopyTo
	|
	|-RVA: 0x2B6BFE0 Offset: 0x2B67FE0 VA: 0x2B6BFE0
	|-List<HouseRecipeManager.RecipeData>.CopyTo
	|
	|-RVA: 0x2B6EA10 Offset: 0x2B6AA10 VA: 0x2B6EA10
	|-List<KadarElexioBuf.SkillIdData>.CopyTo
	|
	|-RVA: 0x2B710A0 Offset: 0x2B6D0A0 VA: 0x2B710A0
	|-List<MissionTextManagerData.CheckIKeywordtemData>.CopyTo
	|
	|-RVA: 0x2B73804 Offset: 0x2B6F804 VA: 0x2B73804
	|-List<MissionTextManagerData.PickUpFieldData>.CopyTo
	|
	|-RVA: 0x2B75F28 Offset: 0x2B71F28 VA: 0x2B75F28
	|-List<MobaRoomData.MobaAbilityMasterData>.CopyTo
	|
	|-RVA: 0x2B786C0 Offset: 0x2B746C0 VA: 0x2B786C0
	|-List<NewWaveRoomData.Spotlight>.CopyTo
	|
	|-RVA: 0x2B7AFE4 Offset: 0x2B76FE4 VA: 0x2B7AFE4
	|-List<NguiDynamicFontController.ApplyTextureInfo>.CopyTo
	|
	|-RVA: 0x2B7D710 Offset: 0x2B79710 VA: 0x2B7D710
	|-List<RegexCharClass.SingleRange>.CopyTo
	|
	|-RVA: 0x2B7FDAC Offset: 0x2B7BDAC VA: 0x2B7FDAC
	|-List<SocialAchievementData.LinkData>.CopyTo
	|
	|-RVA: 0x2B824D0 Offset: 0x2B7E4D0 VA: 0x2B824D0
	|-List<TrophyManager.TrophyData>.CopyTo
	|
	|-RVA: 0x2B84CC8 Offset: 0x2B80CC8 VA: 0x2B84CC8
	|-List<UIEventMenuButton.MessageButtonData>.CopyTo
	|
	|-RVA: 0x2B87804 Offset: 0x2B83804 VA: 0x2B87804
	|-List<UIFieldMapPanel.PopData>.CopyTo
	|
	|-RVA: 0x2B8A0CC Offset: 0x2B860CC VA: 0x2B8A0CC
	|-List<UIHouseAddressManager.Town>.CopyTo
	|
	|-RVA: 0x2B8C81C Offset: 0x2B8881C VA: 0x2B8C81C
	|-List<UIInfoWindow.LabelPosition>.CopyTo
	|
	|-RVA: 0x2B8F0E4 Offset: 0x2B8B0E4 VA: 0x2B8F0E4
	|-List<UIMainManager.DropItemData>.CopyTo
	|
	|-RVA: 0x2B91778 Offset: 0x2B8D778 VA: 0x2B91778
	|-List<UIScenarioOrderPanel.MissionData>.CopyTo
	|
	|-RVA: 0x2B9405C Offset: 0x2B9005C VA: 0x2B9405C
	|-List<UnitySynchronizationContext.WorkRequest>.CopyTo
	|
	|-RVA: 0x2B96AD4 Offset: 0x2B92AD4 VA: 0x2B96AD4
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.CopyTo
	|
	|-RVA: 0x2B992C8 Offset: 0x2B952C8 VA: 0x2B992C8
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.CopyTo
	|
	|-RVA: 0x2B9BBF0 Offset: 0x2B97BF0 VA: 0x2B9BBF0
	|-List<InstructionList.DebugView.InstructionView>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADB28 Offset: 0x2AA9B28 VA: 0x2AADB28
	|-List<KeyValuePair<ArchetypeUid, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AB0254 Offset: 0x2AAC254 VA: 0x2AB0254
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AB289C Offset: 0x2AAE89C VA: 0x2AB289C
	|-List<KeyValuePair<byte, byte>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AB52B4 Offset: 0x2AB12B4 VA: 0x2AB52B4
	|-List<KeyValuePair<byte, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AB79D8 Offset: 0x2AB39D8 VA: 0x2AB79D8
	|-List<KeyValuePair<int, short>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2ABA010 Offset: 0x2AB6010 VA: 0x2ABA010
	|-List<KeyValuePair<int, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2ABC6A4 Offset: 0x2AB86A4 VA: 0x2ABC6A4
	|-List<KeyValuePair<int, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2ABEDC8 Offset: 0x2ABADC8 VA: 0x2ABEDC8
	|-List<KeyValuePair<Int32Enum, byte>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AC1590 Offset: 0x2ABD590 VA: 0x2AC1590
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AC3F00 Offset: 0x2ABFF00 VA: 0x2AC3F00
	|-List<KeyValuePair<Int32Enum, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AC6594 Offset: 0x2AC2594 VA: 0x2AC6594
	|-List<KeyValuePair<Int32Enum, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AC8D14 Offset: 0x2AC4D14 VA: 0x2AC8D14
	|-List<KeyValuePair<object, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2ACB494 Offset: 0x2AC7494 VA: 0x2ACB494
	|-List<KeyValuePair<object, float>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2ACDC14 Offset: 0x2AC9C14 VA: 0x2ACDC14
	|-List<KeyValuePair<float, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AD048C Offset: 0x2ACC48C VA: 0x2AD048C
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AD2DC0 Offset: 0x2ACEDC0 VA: 0x2AD2DC0
	|-List<StructMultiKey<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AD54EC Offset: 0x2AD14EC VA: 0x2AD54EC
	|-List<ValueTuple<short, short>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AD7B2C Offset: 0x2AD3B2C VA: 0x2AD7B2C
	|-List<ValueTuple<int, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2ADA1C0 Offset: 0x2AD61C0 VA: 0x2ADA1C0
	|-List<ValueTuple<int, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2ADC8E4 Offset: 0x2AD88E4 VA: 0x2ADC8E4
	|-List<ValueTuple<Int32Enum, float>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2ADF08C Offset: 0x2ADB08C VA: 0x2ADF08C
	|-List<ValueTuple<Vector3, Vector3>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AE19D4 Offset: 0x2ADD9D4 VA: 0x2AE19D4
	|-List<ArchetypeUid>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AE402C Offset: 0x2AE002C VA: 0x2AE402C
	|-List<bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AE6684 Offset: 0x2AE2684 VA: 0x2AE6684
	|-List<byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AE8CC0 Offset: 0x2AE4CC0 VA: 0x2AE8CC0
	|-List<ByteEnum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AEB2FC Offset: 0x2AE72FC VA: 0x2AEB2FC
	|-List<char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AED990 Offset: 0x2AE9990 VA: 0x2AED990
	|-List<Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AF007C Offset: 0x2AEC07C VA: 0x2AF007C
	|-List<Color32>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AF26BC Offset: 0x2AEE6BC VA: 0x2AF26BC
	|-List<DateTime>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AF4D0C Offset: 0x2AF0D0C VA: 0x2AF4D0C
	|-List<DateTimeOffset>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AF73CC Offset: 0x2AF33CC VA: 0x2AF73CC
	|-List<Decimal>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AF9A9C Offset: 0x2AF5A9C VA: 0x2AF9A9C
	|-List<DefencePoint2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AFC0DC Offset: 0x2AF80DC VA: 0x2AFC0DC
	|-List<double>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AFE774 Offset: 0x2AFA774 VA: 0x2AFE774
	|-List<EventSummary>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B00E98 Offset: 0x2AFCE98 VA: 0x2B00E98
	|-List<short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B034D0 Offset: 0x2AFF4D0 VA: 0x2B034D0
	|-List<Int16Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B05B08 Offset: 0x2B01B08 VA: 0x2B05B08
	|-List<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B0813C Offset: 0x2B0413C VA: 0x2B0813C
	|-List<Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B0A770 Offset: 0x2B06770 VA: 0x2B0A770
	|-List<long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B0CE00 Offset: 0x2B08E00 VA: 0x2B0CE00
	|-List<InterpretedFrameInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B0F6E4 Offset: 0x2B0B6E4 VA: 0x2B0F6E4
	|-List<JsonPosition>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B12118 Offset: 0x2B0E118 VA: 0x2B12118
	|-List<MaterialSearchData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B14908 Offset: 0x2B10908 VA: 0x2B14908
	|-List<MobActionTargetData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B17410 Offset: 0x2B13410 VA: 0x2B17410
	|-List<MobIconLabelData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B19E2C Offset: 0x2B15E2C VA: 0x2B19E2C
	|-List<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B1C6B0 Offset: 0x2B186B0 VA: 0x2B1C6B0
	|-List<PlayerLoopSystem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B1F2B8 Offset: 0x2B1B2B8 VA: 0x2B1F2B8
	|-List<PlayerLoopSystemInternal>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B21D58 Offset: 0x2B1DD58 VA: 0x2B21D58
	|-List<RangePositionInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B244D4 Offset: 0x2B204D4 VA: 0x2B244D4
	|-List<ReinforceCristaData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B26BE0 Offset: 0x2B22BE0 VA: 0x2B26BE0
	|-List<sbyte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B29224 Offset: 0x2B25224 VA: 0x2B29224
	|-List<float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B2B860 Offset: 0x2B27860 VA: 0x2B2B860
	|-List<SkillIdData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B2DE98 Offset: 0x2B29E98 VA: 0x2B2DE98
	|-List<TimeSpan>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B548B0 Offset: 0x2B508B0 VA: 0x2B548B0
	|-List<ushort>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B56EE8 Offset: 0x2B52EE8 VA: 0x2B56EE8
	|-List<uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B5951C Offset: 0x2B5551C VA: 0x2B5951C
	|-List<ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B5BB68 Offset: 0x2B57B68 VA: 0x2B5BB68
	|-List<Vector2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B5E264 Offset: 0x2B5A264 VA: 0x2B5E264
	|-List<Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B609E4 Offset: 0x2B5C9E4 VA: 0x2B609E4
	|-List<X509ChainStatus>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B637F4 Offset: 0x2B5F7F4 VA: 0x2B637F4
	|-List<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B66B70 Offset: 0x2B62B70 VA: 0x2B66B70
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B69444 Offset: 0x2B65444 VA: 0x2B69444
	|-List<BoneClip.MotionKeyFrame>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B6C000 Offset: 0x2B68000 VA: 0x2B6C000
	|-List<HouseRecipeManager.RecipeData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B6EA30 Offset: 0x2B6AA30 VA: 0x2B6EA30
	|-List<KadarElexioBuf.SkillIdData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B710C0 Offset: 0x2B6D0C0 VA: 0x2B710C0
	|-List<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B73824 Offset: 0x2B6F824 VA: 0x2B73824
	|-List<MissionTextManagerData.PickUpFieldData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B75F48 Offset: 0x2B71F48 VA: 0x2B75F48
	|-List<MobaRoomData.MobaAbilityMasterData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B786E0 Offset: 0x2B746E0 VA: 0x2B786E0
	|-List<NewWaveRoomData.Spotlight>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B7B004 Offset: 0x2B77004 VA: 0x2B7B004
	|-List<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B7D730 Offset: 0x2B79730 VA: 0x2B7D730
	|-List<RegexCharClass.SingleRange>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B7FDCC Offset: 0x2B7BDCC VA: 0x2B7FDCC
	|-List<SocialAchievementData.LinkData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B824F0 Offset: 0x2B7E4F0 VA: 0x2B824F0
	|-List<TrophyManager.TrophyData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B84CE8 Offset: 0x2B80CE8 VA: 0x2B84CE8
	|-List<UIEventMenuButton.MessageButtonData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B87824 Offset: 0x2B83824 VA: 0x2B87824
	|-List<UIFieldMapPanel.PopData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B8A0EC Offset: 0x2B860EC VA: 0x2B8A0EC
	|-List<UIHouseAddressManager.Town>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B8C83C Offset: 0x2B8883C VA: 0x2B8C83C
	|-List<UIInfoWindow.LabelPosition>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B8F104 Offset: 0x2B8B104 VA: 0x2B8F104
	|-List<UIMainManager.DropItemData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B91798 Offset: 0x2B8D798 VA: 0x2B91798
	|-List<UIScenarioOrderPanel.MissionData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B9407C Offset: 0x2B9007C VA: 0x2B9407C
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B96AF4 Offset: 0x2B92AF4 VA: 0x2B96AF4
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B992E8 Offset: 0x2B952E8 VA: 0x2B992E8
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2B9BC10 Offset: 0x2B97C10 VA: 0x2B9BC10
	|-List<InstructionList.DebugView.InstructionView>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADC04 Offset: 0x2AA9C04 VA: 0x2AADC04
	|-List<KeyValuePair<ArchetypeUid, object>>.CopyTo
	|
	|-RVA: 0x2AB0330 Offset: 0x2AAC330 VA: 0x2AB0330
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.CopyTo
	|
	|-RVA: 0x2AB2978 Offset: 0x2AAE978 VA: 0x2AB2978
	|-List<KeyValuePair<byte, byte>>.CopyTo
	|
	|-RVA: 0x2AB5390 Offset: 0x2AB1390 VA: 0x2AB5390
	|-List<KeyValuePair<byte, object>>.CopyTo
	|
	|-RVA: 0x2AB7AB4 Offset: 0x2AB3AB4 VA: 0x2AB7AB4
	|-List<KeyValuePair<int, short>>.CopyTo
	|
	|-RVA: 0x2ABA0EC Offset: 0x2AB60EC VA: 0x2ABA0EC
	|-List<KeyValuePair<int, int>>.CopyTo
	|
	|-RVA: 0x2ABC780 Offset: 0x2AB8780 VA: 0x2ABC780
	|-List<KeyValuePair<int, object>>.CopyTo
	|
	|-RVA: 0x2ABEEA4 Offset: 0x2ABAEA4 VA: 0x2ABEEA4
	|-List<KeyValuePair<Int32Enum, byte>>.CopyTo
	|
	|-RVA: 0x2AC166C Offset: 0x2ABD66C VA: 0x2AC166C
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.CopyTo
	|
	|-RVA: 0x2AC3FDC Offset: 0x2ABFFDC VA: 0x2AC3FDC
	|-List<KeyValuePair<Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x2AC6670 Offset: 0x2AC2670 VA: 0x2AC6670
	|-List<KeyValuePair<Int32Enum, object>>.CopyTo
	|
	|-RVA: 0x2AC8DF0 Offset: 0x2AC4DF0 VA: 0x2AC8DF0
	|-List<KeyValuePair<object, int>>.CopyTo
	|
	|-RVA: 0x2ACB570 Offset: 0x2AC7570 VA: 0x2ACB570
	|-List<KeyValuePair<object, float>>.CopyTo
	|
	|-RVA: 0x2ACDCF0 Offset: 0x2AC9CF0 VA: 0x2ACDCF0
	|-List<KeyValuePair<float, object>>.CopyTo
	|
	|-RVA: 0x2AD0568 Offset: 0x2ACC568 VA: 0x2AD0568
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.CopyTo
	|
	|-RVA: 0x2AD2E9C Offset: 0x2ACEE9C VA: 0x2AD2E9C
	|-List<StructMultiKey<object, object>>.CopyTo
	|
	|-RVA: 0x2AD55C8 Offset: 0x2AD15C8 VA: 0x2AD55C8
	|-List<ValueTuple<short, short>>.CopyTo
	|
	|-RVA: 0x2AD7C08 Offset: 0x2AD3C08 VA: 0x2AD7C08
	|-List<ValueTuple<int, int>>.CopyTo
	|
	|-RVA: 0x2ADA29C Offset: 0x2AD629C VA: 0x2ADA29C
	|-List<ValueTuple<int, object>>.CopyTo
	|
	|-RVA: 0x2ADC9C0 Offset: 0x2AD89C0 VA: 0x2ADC9C0
	|-List<ValueTuple<Int32Enum, float>>.CopyTo
	|
	|-RVA: 0x2ADF168 Offset: 0x2ADB168 VA: 0x2ADF168
	|-List<ValueTuple<Vector3, Vector3>>.CopyTo
	|
	|-RVA: 0x2AE1AB0 Offset: 0x2ADDAB0 VA: 0x2AE1AB0
	|-List<ArchetypeUid>.CopyTo
	|
	|-RVA: 0x2AE4108 Offset: 0x2AE0108 VA: 0x2AE4108
	|-List<bool>.CopyTo
	|
	|-RVA: 0x2AE6760 Offset: 0x2AE2760 VA: 0x2AE6760
	|-List<byte>.CopyTo
	|
	|-RVA: 0x2AE8D9C Offset: 0x2AE4D9C VA: 0x2AE8D9C
	|-List<ByteEnum>.CopyTo
	|
	|-RVA: 0x2AEB3D8 Offset: 0x2AE73D8 VA: 0x2AEB3D8
	|-List<char>.CopyTo
	|
	|-RVA: 0x2AEDA6C Offset: 0x2AE9A6C VA: 0x2AEDA6C
	|-List<Color>.CopyTo
	|
	|-RVA: 0x2AF0158 Offset: 0x2AEC158 VA: 0x2AF0158
	|-List<Color32>.CopyTo
	|
	|-RVA: 0x2AF2798 Offset: 0x2AEE798 VA: 0x2AF2798
	|-List<DateTime>.CopyTo
	|
	|-RVA: 0x2AF4DE8 Offset: 0x2AF0DE8 VA: 0x2AF4DE8
	|-List<DateTimeOffset>.CopyTo
	|
	|-RVA: 0x2AF74A8 Offset: 0x2AF34A8 VA: 0x2AF74A8
	|-List<Decimal>.CopyTo
	|
	|-RVA: 0x2AF9B78 Offset: 0x2AF5B78 VA: 0x2AF9B78
	|-List<DefencePoint2>.CopyTo
	|
	|-RVA: 0x2AFC1B8 Offset: 0x2AF81B8 VA: 0x2AFC1B8
	|-List<double>.CopyTo
	|
	|-RVA: 0x2AFE850 Offset: 0x2AFA850 VA: 0x2AFE850
	|-List<EventSummary>.CopyTo
	|
	|-RVA: 0x2B00F74 Offset: 0x2AFCF74 VA: 0x2B00F74
	|-List<short>.CopyTo
	|
	|-RVA: 0x2B035AC Offset: 0x2AFF5AC VA: 0x2B035AC
	|-List<Int16Enum>.CopyTo
	|
	|-RVA: 0x2B05BE4 Offset: 0x2B01BE4 VA: 0x2B05BE4
	|-List<int>.CopyTo
	|
	|-RVA: 0x2B08218 Offset: 0x2B04218 VA: 0x2B08218
	|-List<Int32Enum>.CopyTo
	|
	|-RVA: 0x2B0A84C Offset: 0x2B0684C VA: 0x2B0A84C
	|-List<long>.CopyTo
	|
	|-RVA: 0x2B0CEDC Offset: 0x2B08EDC VA: 0x2B0CEDC
	|-List<InterpretedFrameInfo>.CopyTo
	|
	|-RVA: 0x2B0F7C0 Offset: 0x2B0B7C0 VA: 0x2B0F7C0
	|-List<JsonPosition>.CopyTo
	|
	|-RVA: 0x2B121F4 Offset: 0x2B0E1F4 VA: 0x2B121F4
	|-List<MaterialSearchData>.CopyTo
	|
	|-RVA: 0x2B149E4 Offset: 0x2B109E4 VA: 0x2B149E4
	|-List<MobActionTargetData>.CopyTo
	|
	|-RVA: 0x2B174EC Offset: 0x2B134EC VA: 0x2B174EC
	|-List<MobIconLabelData>.CopyTo
	|
	|-RVA: 0x2B19F08 Offset: 0x2B15F08 VA: 0x2B19F08
	|-List<object>.CopyTo
	|
	|-RVA: 0x2B1C78C Offset: 0x2B1878C VA: 0x2B1C78C
	|-List<PlayerLoopSystem>.CopyTo
	|
	|-RVA: 0x2B1F394 Offset: 0x2B1B394 VA: 0x2B1F394
	|-List<PlayerLoopSystemInternal>.CopyTo
	|
	|-RVA: 0x2B21E34 Offset: 0x2B1DE34 VA: 0x2B21E34
	|-List<RangePositionInfo>.CopyTo
	|
	|-RVA: 0x2B245B0 Offset: 0x2B205B0 VA: 0x2B245B0
	|-List<ReinforceCristaData>.CopyTo
	|
	|-RVA: 0x2B26CBC Offset: 0x2B22CBC VA: 0x2B26CBC
	|-List<sbyte>.CopyTo
	|
	|-RVA: 0x2B29300 Offset: 0x2B25300 VA: 0x2B29300
	|-List<float>.CopyTo
	|
	|-RVA: 0x2B2B93C Offset: 0x2B2793C VA: 0x2B2B93C
	|-List<SkillIdData>.CopyTo
	|
	|-RVA: 0x2B2DF74 Offset: 0x2B29F74 VA: 0x2B2DF74
	|-List<TimeSpan>.CopyTo
	|
	|-RVA: 0x2B5498C Offset: 0x2B5098C VA: 0x2B5498C
	|-List<ushort>.CopyTo
	|
	|-RVA: 0x2B56FC4 Offset: 0x2B52FC4 VA: 0x2B56FC4
	|-List<uint>.CopyTo
	|
	|-RVA: 0x2B595F8 Offset: 0x2B555F8 VA: 0x2B595F8
	|-List<ulong>.CopyTo
	|
	|-RVA: 0x2B5BC44 Offset: 0x2B57C44 VA: 0x2B5BC44
	|-List<Vector2>.CopyTo
	|
	|-RVA: 0x2B5E340 Offset: 0x2B5A340 VA: 0x2B5E340
	|-List<Vector3>.CopyTo
	|
	|-RVA: 0x2B60AC0 Offset: 0x2B5CAC0 VA: 0x2B60AC0
	|-List<X509ChainStatus>.CopyTo
	|
	|-RVA: 0x2B638D0 Offset: 0x2B5F8D0 VA: 0x2B638D0
	|-List<__Il2CppFullySharedGenericType>.CopyTo
	|
	|-RVA: 0x2B66C4C Offset: 0x2B62C4C VA: 0x2B66C4C
	|-List<BeforeRenderHelper.OrderBlock>.CopyTo
	|
	|-RVA: 0x2B69520 Offset: 0x2B65520 VA: 0x2B69520
	|-List<BoneClip.MotionKeyFrame>.CopyTo
	|
	|-RVA: 0x2B6C0DC Offset: 0x2B680DC VA: 0x2B6C0DC
	|-List<HouseRecipeManager.RecipeData>.CopyTo
	|
	|-RVA: 0x2B6EB0C Offset: 0x2B6AB0C VA: 0x2B6EB0C
	|-List<KadarElexioBuf.SkillIdData>.CopyTo
	|
	|-RVA: 0x2B7119C Offset: 0x2B6D19C VA: 0x2B7119C
	|-List<MissionTextManagerData.CheckIKeywordtemData>.CopyTo
	|
	|-RVA: 0x2B73900 Offset: 0x2B6F900 VA: 0x2B73900
	|-List<MissionTextManagerData.PickUpFieldData>.CopyTo
	|
	|-RVA: 0x2B76024 Offset: 0x2B72024 VA: 0x2B76024
	|-List<MobaRoomData.MobaAbilityMasterData>.CopyTo
	|
	|-RVA: 0x2B787BC Offset: 0x2B747BC VA: 0x2B787BC
	|-List<NewWaveRoomData.Spotlight>.CopyTo
	|
	|-RVA: 0x2B7B0E0 Offset: 0x2B770E0 VA: 0x2B7B0E0
	|-List<NguiDynamicFontController.ApplyTextureInfo>.CopyTo
	|
	|-RVA: 0x2B7D80C Offset: 0x2B7980C VA: 0x2B7D80C
	|-List<RegexCharClass.SingleRange>.CopyTo
	|
	|-RVA: 0x2B7FEA8 Offset: 0x2B7BEA8 VA: 0x2B7FEA8
	|-List<SocialAchievementData.LinkData>.CopyTo
	|
	|-RVA: 0x2B825CC Offset: 0x2B7E5CC VA: 0x2B825CC
	|-List<TrophyManager.TrophyData>.CopyTo
	|
	|-RVA: 0x2B84DC4 Offset: 0x2B80DC4 VA: 0x2B84DC4
	|-List<UIEventMenuButton.MessageButtonData>.CopyTo
	|
	|-RVA: 0x2B87900 Offset: 0x2B83900 VA: 0x2B87900
	|-List<UIFieldMapPanel.PopData>.CopyTo
	|
	|-RVA: 0x2B8A1C8 Offset: 0x2B861C8 VA: 0x2B8A1C8
	|-List<UIHouseAddressManager.Town>.CopyTo
	|
	|-RVA: 0x2B8C918 Offset: 0x2B88918 VA: 0x2B8C918
	|-List<UIInfoWindow.LabelPosition>.CopyTo
	|
	|-RVA: 0x2B8F1E0 Offset: 0x2B8B1E0 VA: 0x2B8F1E0
	|-List<UIMainManager.DropItemData>.CopyTo
	|
	|-RVA: 0x2B91874 Offset: 0x2B8D874 VA: 0x2B91874
	|-List<UIScenarioOrderPanel.MissionData>.CopyTo
	|
	|-RVA: 0x2B94158 Offset: 0x2B90158 VA: 0x2B94158
	|-List<UnitySynchronizationContext.WorkRequest>.CopyTo
	|
	|-RVA: 0x2B96BD0 Offset: 0x2B92BD0 VA: 0x2B96BD0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.CopyTo
	|
	|-RVA: 0x2B993C4 Offset: 0x2B953C4 VA: 0x2B993C4
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.CopyTo
	|
	|-RVA: 0x2B9BCEC Offset: 0x2B97CEC VA: 0x2B9BCEC
	|-List<InstructionList.DebugView.InstructionView>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADC24 Offset: 0x2AA9C24 VA: 0x2AADC24
	|-List<KeyValuePair<ArchetypeUid, object>>.EnsureCapacity
	|
	|-RVA: 0x2AB0350 Offset: 0x2AAC350 VA: 0x2AB0350
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.EnsureCapacity
	|
	|-RVA: 0x2AB2998 Offset: 0x2AAE998 VA: 0x2AB2998
	|-List<KeyValuePair<byte, byte>>.EnsureCapacity
	|
	|-RVA: 0x2AB53B0 Offset: 0x2AB13B0 VA: 0x2AB53B0
	|-List<KeyValuePair<byte, object>>.EnsureCapacity
	|
	|-RVA: 0x2AB7AD4 Offset: 0x2AB3AD4 VA: 0x2AB7AD4
	|-List<KeyValuePair<int, short>>.EnsureCapacity
	|
	|-RVA: 0x2ABA10C Offset: 0x2AB610C VA: 0x2ABA10C
	|-List<KeyValuePair<int, int>>.EnsureCapacity
	|
	|-RVA: 0x2ABC7A0 Offset: 0x2AB87A0 VA: 0x2ABC7A0
	|-List<KeyValuePair<int, object>>.EnsureCapacity
	|
	|-RVA: 0x2ABEEC4 Offset: 0x2ABAEC4 VA: 0x2ABEEC4
	|-List<KeyValuePair<Int32Enum, byte>>.EnsureCapacity
	|
	|-RVA: 0x2AC168C Offset: 0x2ABD68C VA: 0x2AC168C
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.EnsureCapacity
	|
	|-RVA: 0x2AC3FFC Offset: 0x2ABFFFC VA: 0x2AC3FFC
	|-List<KeyValuePair<Int32Enum, int>>.EnsureCapacity
	|
	|-RVA: 0x2AC6690 Offset: 0x2AC2690 VA: 0x2AC6690
	|-List<KeyValuePair<Int32Enum, object>>.EnsureCapacity
	|
	|-RVA: 0x2AC8E10 Offset: 0x2AC4E10 VA: 0x2AC8E10
	|-List<KeyValuePair<object, int>>.EnsureCapacity
	|
	|-RVA: 0x2ACB590 Offset: 0x2AC7590 VA: 0x2ACB590
	|-List<KeyValuePair<object, float>>.EnsureCapacity
	|
	|-RVA: 0x2ACDD10 Offset: 0x2AC9D10 VA: 0x2ACDD10
	|-List<KeyValuePair<float, object>>.EnsureCapacity
	|
	|-RVA: 0x2AD0588 Offset: 0x2ACC588 VA: 0x2AD0588
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.EnsureCapacity
	|
	|-RVA: 0x2AD2EBC Offset: 0x2ACEEBC VA: 0x2AD2EBC
	|-List<StructMultiKey<object, object>>.EnsureCapacity
	|
	|-RVA: 0x2AD55E8 Offset: 0x2AD15E8 VA: 0x2AD55E8
	|-List<ValueTuple<short, short>>.EnsureCapacity
	|
	|-RVA: 0x2AD7C28 Offset: 0x2AD3C28 VA: 0x2AD7C28
	|-List<ValueTuple<int, int>>.EnsureCapacity
	|
	|-RVA: 0x2ADA2BC Offset: 0x2AD62BC VA: 0x2ADA2BC
	|-List<ValueTuple<int, object>>.EnsureCapacity
	|
	|-RVA: 0x2ADC9E0 Offset: 0x2AD89E0 VA: 0x2ADC9E0
	|-List<ValueTuple<Int32Enum, float>>.EnsureCapacity
	|
	|-RVA: 0x2ADF188 Offset: 0x2ADB188 VA: 0x2ADF188
	|-List<ValueTuple<Vector3, Vector3>>.EnsureCapacity
	|
	|-RVA: 0x2AE1AD0 Offset: 0x2ADDAD0 VA: 0x2AE1AD0
	|-List<ArchetypeUid>.EnsureCapacity
	|
	|-RVA: 0x2AE4128 Offset: 0x2AE0128 VA: 0x2AE4128
	|-List<bool>.EnsureCapacity
	|
	|-RVA: 0x2AE6780 Offset: 0x2AE2780 VA: 0x2AE6780
	|-List<byte>.EnsureCapacity
	|
	|-RVA: 0x2AE8DBC Offset: 0x2AE4DBC VA: 0x2AE8DBC
	|-List<ByteEnum>.EnsureCapacity
	|
	|-RVA: 0x2AEB3F8 Offset: 0x2AE73F8 VA: 0x2AEB3F8
	|-List<char>.EnsureCapacity
	|
	|-RVA: 0x2AEDA8C Offset: 0x2AE9A8C VA: 0x2AEDA8C
	|-List<Color>.EnsureCapacity
	|
	|-RVA: 0x2AF0178 Offset: 0x2AEC178 VA: 0x2AF0178
	|-List<Color32>.EnsureCapacity
	|
	|-RVA: 0x2AF27B8 Offset: 0x2AEE7B8 VA: 0x2AF27B8
	|-List<DateTime>.EnsureCapacity
	|
	|-RVA: 0x2AF4E08 Offset: 0x2AF0E08 VA: 0x2AF4E08
	|-List<DateTimeOffset>.EnsureCapacity
	|
	|-RVA: 0x2AF74C8 Offset: 0x2AF34C8 VA: 0x2AF74C8
	|-List<Decimal>.EnsureCapacity
	|
	|-RVA: 0x2AF9B98 Offset: 0x2AF5B98 VA: 0x2AF9B98
	|-List<DefencePoint2>.EnsureCapacity
	|
	|-RVA: 0x2AFC1D8 Offset: 0x2AF81D8 VA: 0x2AFC1D8
	|-List<double>.EnsureCapacity
	|
	|-RVA: 0x2AFE870 Offset: 0x2AFA870 VA: 0x2AFE870
	|-List<EventSummary>.EnsureCapacity
	|
	|-RVA: 0x2B00F94 Offset: 0x2AFCF94 VA: 0x2B00F94
	|-List<short>.EnsureCapacity
	|
	|-RVA: 0x2B035CC Offset: 0x2AFF5CC VA: 0x2B035CC
	|-List<Int16Enum>.EnsureCapacity
	|
	|-RVA: 0x2B05C04 Offset: 0x2B01C04 VA: 0x2B05C04
	|-List<int>.EnsureCapacity
	|
	|-RVA: 0x2B08238 Offset: 0x2B04238 VA: 0x2B08238
	|-List<Int32Enum>.EnsureCapacity
	|
	|-RVA: 0x2B0A86C Offset: 0x2B0686C VA: 0x2B0A86C
	|-List<long>.EnsureCapacity
	|
	|-RVA: 0x2B0CEFC Offset: 0x2B08EFC VA: 0x2B0CEFC
	|-List<InterpretedFrameInfo>.EnsureCapacity
	|
	|-RVA: 0x2B0F7E0 Offset: 0x2B0B7E0 VA: 0x2B0F7E0
	|-List<JsonPosition>.EnsureCapacity
	|
	|-RVA: 0x2B12214 Offset: 0x2B0E214 VA: 0x2B12214
	|-List<MaterialSearchData>.EnsureCapacity
	|
	|-RVA: 0x2B14A04 Offset: 0x2B10A04 VA: 0x2B14A04
	|-List<MobActionTargetData>.EnsureCapacity
	|
	|-RVA: 0x2B1750C Offset: 0x2B1350C VA: 0x2B1750C
	|-List<MobIconLabelData>.EnsureCapacity
	|
	|-RVA: 0x2B19F28 Offset: 0x2B15F28 VA: 0x2B19F28
	|-List<object>.EnsureCapacity
	|
	|-RVA: 0x2B1C7AC Offset: 0x2B187AC VA: 0x2B1C7AC
	|-List<PlayerLoopSystem>.EnsureCapacity
	|
	|-RVA: 0x2B1F3B4 Offset: 0x2B1B3B4 VA: 0x2B1F3B4
	|-List<PlayerLoopSystemInternal>.EnsureCapacity
	|
	|-RVA: 0x2B21E54 Offset: 0x2B1DE54 VA: 0x2B21E54
	|-List<RangePositionInfo>.EnsureCapacity
	|
	|-RVA: 0x2B245D0 Offset: 0x2B205D0 VA: 0x2B245D0
	|-List<ReinforceCristaData>.EnsureCapacity
	|
	|-RVA: 0x2B26CDC Offset: 0x2B22CDC VA: 0x2B26CDC
	|-List<sbyte>.EnsureCapacity
	|
	|-RVA: 0x2B29320 Offset: 0x2B25320 VA: 0x2B29320
	|-List<float>.EnsureCapacity
	|
	|-RVA: 0x2B2B95C Offset: 0x2B2795C VA: 0x2B2B95C
	|-List<SkillIdData>.EnsureCapacity
	|
	|-RVA: 0x2B2DF94 Offset: 0x2B29F94 VA: 0x2B2DF94
	|-List<TimeSpan>.EnsureCapacity
	|
	|-RVA: 0x2B549AC Offset: 0x2B509AC VA: 0x2B549AC
	|-List<ushort>.EnsureCapacity
	|
	|-RVA: 0x2B56FE4 Offset: 0x2B52FE4 VA: 0x2B56FE4
	|-List<uint>.EnsureCapacity
	|
	|-RVA: 0x2B59618 Offset: 0x2B55618 VA: 0x2B59618
	|-List<ulong>.EnsureCapacity
	|
	|-RVA: 0x2B5BC64 Offset: 0x2B57C64 VA: 0x2B5BC64
	|-List<Vector2>.EnsureCapacity
	|
	|-RVA: 0x2B5E360 Offset: 0x2B5A360 VA: 0x2B5E360
	|-List<Vector3>.EnsureCapacity
	|
	|-RVA: 0x2B60AE0 Offset: 0x2B5CAE0 VA: 0x2B60AE0
	|-List<X509ChainStatus>.EnsureCapacity
	|
	|-RVA: 0x2B638F0 Offset: 0x2B5F8F0 VA: 0x2B638F0
	|-List<__Il2CppFullySharedGenericType>.EnsureCapacity
	|
	|-RVA: 0x2B66C6C Offset: 0x2B62C6C VA: 0x2B66C6C
	|-List<BeforeRenderHelper.OrderBlock>.EnsureCapacity
	|
	|-RVA: 0x2B69540 Offset: 0x2B65540 VA: 0x2B69540
	|-List<BoneClip.MotionKeyFrame>.EnsureCapacity
	|
	|-RVA: 0x2B6C0FC Offset: 0x2B680FC VA: 0x2B6C0FC
	|-List<HouseRecipeManager.RecipeData>.EnsureCapacity
	|
	|-RVA: 0x2B6EB2C Offset: 0x2B6AB2C VA: 0x2B6EB2C
	|-List<KadarElexioBuf.SkillIdData>.EnsureCapacity
	|
	|-RVA: 0x2B711BC Offset: 0x2B6D1BC VA: 0x2B711BC
	|-List<MissionTextManagerData.CheckIKeywordtemData>.EnsureCapacity
	|
	|-RVA: 0x2B73920 Offset: 0x2B6F920 VA: 0x2B73920
	|-List<MissionTextManagerData.PickUpFieldData>.EnsureCapacity
	|
	|-RVA: 0x2B76044 Offset: 0x2B72044 VA: 0x2B76044
	|-List<MobaRoomData.MobaAbilityMasterData>.EnsureCapacity
	|
	|-RVA: 0x2B787DC Offset: 0x2B747DC VA: 0x2B787DC
	|-List<NewWaveRoomData.Spotlight>.EnsureCapacity
	|
	|-RVA: 0x2B7B100 Offset: 0x2B77100 VA: 0x2B7B100
	|-List<NguiDynamicFontController.ApplyTextureInfo>.EnsureCapacity
	|
	|-RVA: 0x2B7D82C Offset: 0x2B7982C VA: 0x2B7D82C
	|-List<RegexCharClass.SingleRange>.EnsureCapacity
	|
	|-RVA: 0x2B7FEC8 Offset: 0x2B7BEC8 VA: 0x2B7FEC8
	|-List<SocialAchievementData.LinkData>.EnsureCapacity
	|
	|-RVA: 0x2B825EC Offset: 0x2B7E5EC VA: 0x2B825EC
	|-List<TrophyManager.TrophyData>.EnsureCapacity
	|
	|-RVA: 0x2B84DE4 Offset: 0x2B80DE4 VA: 0x2B84DE4
	|-List<UIEventMenuButton.MessageButtonData>.EnsureCapacity
	|
	|-RVA: 0x2B87920 Offset: 0x2B83920 VA: 0x2B87920
	|-List<UIFieldMapPanel.PopData>.EnsureCapacity
	|
	|-RVA: 0x2B8A1E8 Offset: 0x2B861E8 VA: 0x2B8A1E8
	|-List<UIHouseAddressManager.Town>.EnsureCapacity
	|
	|-RVA: 0x2B8C938 Offset: 0x2B88938 VA: 0x2B8C938
	|-List<UIInfoWindow.LabelPosition>.EnsureCapacity
	|
	|-RVA: 0x2B8F200 Offset: 0x2B8B200 VA: 0x2B8F200
	|-List<UIMainManager.DropItemData>.EnsureCapacity
	|
	|-RVA: 0x2B91894 Offset: 0x2B8D894 VA: 0x2B91894
	|-List<UIScenarioOrderPanel.MissionData>.EnsureCapacity
	|
	|-RVA: 0x2B94178 Offset: 0x2B90178 VA: 0x2B94178
	|-List<UnitySynchronizationContext.WorkRequest>.EnsureCapacity
	|
	|-RVA: 0x2B96BF0 Offset: 0x2B92BF0 VA: 0x2B96BF0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.EnsureCapacity
	|
	|-RVA: 0x2B993E4 Offset: 0x2B953E4 VA: 0x2B993E4
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.EnsureCapacity
	|
	|-RVA: 0x2B9BD0C Offset: 0x2B97D0C VA: 0x2B9BD0C
	|-List<InstructionList.DebugView.InstructionView>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	public bool Exists(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADC80 Offset: 0x2AA9C80 VA: 0x2AADC80
	|-List<KeyValuePair<ArchetypeUid, object>>.Exists
	|
	|-RVA: 0x2AB03AC Offset: 0x2AAC3AC VA: 0x2AB03AC
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.Exists
	|
	|-RVA: 0x2AB29F4 Offset: 0x2AAE9F4 VA: 0x2AB29F4
	|-List<KeyValuePair<byte, byte>>.Exists
	|
	|-RVA: 0x2AB540C Offset: 0x2AB140C VA: 0x2AB540C
	|-List<KeyValuePair<byte, object>>.Exists
	|
	|-RVA: 0x2AB7B30 Offset: 0x2AB3B30 VA: 0x2AB7B30
	|-List<KeyValuePair<int, short>>.Exists
	|
	|-RVA: 0x2ABA168 Offset: 0x2AB6168 VA: 0x2ABA168
	|-List<KeyValuePair<int, int>>.Exists
	|
	|-RVA: 0x2ABC7FC Offset: 0x2AB87FC VA: 0x2ABC7FC
	|-List<KeyValuePair<int, object>>.Exists
	|
	|-RVA: 0x2ABEF20 Offset: 0x2ABAF20 VA: 0x2ABEF20
	|-List<KeyValuePair<Int32Enum, byte>>.Exists
	|
	|-RVA: 0x2AC16E8 Offset: 0x2ABD6E8 VA: 0x2AC16E8
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.Exists
	|
	|-RVA: 0x2AC4058 Offset: 0x2AC0058 VA: 0x2AC4058
	|-List<KeyValuePair<Int32Enum, int>>.Exists
	|
	|-RVA: 0x2AC66EC Offset: 0x2AC26EC VA: 0x2AC66EC
	|-List<KeyValuePair<Int32Enum, object>>.Exists
	|
	|-RVA: 0x2AC8E6C Offset: 0x2AC4E6C VA: 0x2AC8E6C
	|-List<KeyValuePair<object, int>>.Exists
	|
	|-RVA: 0x2ACB5EC Offset: 0x2AC75EC VA: 0x2ACB5EC
	|-List<KeyValuePair<object, float>>.Exists
	|
	|-RVA: 0x2ACDD6C Offset: 0x2AC9D6C VA: 0x2ACDD6C
	|-List<KeyValuePair<float, object>>.Exists
	|
	|-RVA: 0x2AD05E4 Offset: 0x2ACC5E4 VA: 0x2AD05E4
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.Exists
	|
	|-RVA: 0x2AD2F18 Offset: 0x2ACEF18 VA: 0x2AD2F18
	|-List<StructMultiKey<object, object>>.Exists
	|
	|-RVA: 0x2AD5644 Offset: 0x2AD1644 VA: 0x2AD5644
	|-List<ValueTuple<short, short>>.Exists
	|
	|-RVA: 0x2AD7C84 Offset: 0x2AD3C84 VA: 0x2AD7C84
	|-List<ValueTuple<int, int>>.Exists
	|
	|-RVA: 0x2ADA318 Offset: 0x2AD6318 VA: 0x2ADA318
	|-List<ValueTuple<int, object>>.Exists
	|
	|-RVA: 0x2ADCA3C Offset: 0x2AD8A3C VA: 0x2ADCA3C
	|-List<ValueTuple<Int32Enum, float>>.Exists
	|
	|-RVA: 0x2ADF1E4 Offset: 0x2ADB1E4 VA: 0x2ADF1E4
	|-List<ValueTuple<Vector3, Vector3>>.Exists
	|
	|-RVA: 0x2AE1B2C Offset: 0x2ADDB2C VA: 0x2AE1B2C
	|-List<ArchetypeUid>.Exists
	|
	|-RVA: 0x2AE4184 Offset: 0x2AE0184 VA: 0x2AE4184
	|-List<bool>.Exists
	|
	|-RVA: 0x2AE67DC Offset: 0x2AE27DC VA: 0x2AE67DC
	|-List<byte>.Exists
	|
	|-RVA: 0x2AE8E18 Offset: 0x2AE4E18 VA: 0x2AE8E18
	|-List<ByteEnum>.Exists
	|
	|-RVA: 0x2AEB454 Offset: 0x2AE7454 VA: 0x2AEB454
	|-List<char>.Exists
	|
	|-RVA: 0x2AEDAE8 Offset: 0x2AE9AE8 VA: 0x2AEDAE8
	|-List<Color>.Exists
	|
	|-RVA: 0x2AF01D4 Offset: 0x2AEC1D4 VA: 0x2AF01D4
	|-List<Color32>.Exists
	|
	|-RVA: 0x2AF2814 Offset: 0x2AEE814 VA: 0x2AF2814
	|-List<DateTime>.Exists
	|
	|-RVA: 0x2AF4E64 Offset: 0x2AF0E64 VA: 0x2AF4E64
	|-List<DateTimeOffset>.Exists
	|
	|-RVA: 0x2AF7524 Offset: 0x2AF3524 VA: 0x2AF7524
	|-List<Decimal>.Exists
	|
	|-RVA: 0x2AF9BF4 Offset: 0x2AF5BF4 VA: 0x2AF9BF4
	|-List<DefencePoint2>.Exists
	|
	|-RVA: 0x2AFC234 Offset: 0x2AF8234 VA: 0x2AFC234
	|-List<double>.Exists
	|
	|-RVA: 0x2AFE8CC Offset: 0x2AFA8CC VA: 0x2AFE8CC
	|-List<EventSummary>.Exists
	|
	|-RVA: 0x2B00FF0 Offset: 0x2AFCFF0 VA: 0x2B00FF0
	|-List<short>.Exists
	|
	|-RVA: 0x2B03628 Offset: 0x2AFF628 VA: 0x2B03628
	|-List<Int16Enum>.Exists
	|
	|-RVA: 0x2B05C60 Offset: 0x2B01C60 VA: 0x2B05C60
	|-List<int>.Exists
	|
	|-RVA: 0x2B08294 Offset: 0x2B04294 VA: 0x2B08294
	|-List<Int32Enum>.Exists
	|
	|-RVA: 0x2B0A8C8 Offset: 0x2B068C8 VA: 0x2B0A8C8
	|-List<long>.Exists
	|
	|-RVA: 0x2B0CF58 Offset: 0x2B08F58 VA: 0x2B0CF58
	|-List<InterpretedFrameInfo>.Exists
	|
	|-RVA: 0x2B0F83C Offset: 0x2B0B83C VA: 0x2B0F83C
	|-List<JsonPosition>.Exists
	|
	|-RVA: 0x2B12270 Offset: 0x2B0E270 VA: 0x2B12270
	|-List<MaterialSearchData>.Exists
	|
	|-RVA: 0x2B14A60 Offset: 0x2B10A60 VA: 0x2B14A60
	|-List<MobActionTargetData>.Exists
	|
	|-RVA: 0x2B17568 Offset: 0x2B13568 VA: 0x2B17568
	|-List<MobIconLabelData>.Exists
	|
	|-RVA: 0x2B19F84 Offset: 0x2B15F84 VA: 0x2B19F84
	|-List<object>.Exists
	|
	|-RVA: 0x2B1C808 Offset: 0x2B18808 VA: 0x2B1C808
	|-List<PlayerLoopSystem>.Exists
	|
	|-RVA: 0x2B1F410 Offset: 0x2B1B410 VA: 0x2B1F410
	|-List<PlayerLoopSystemInternal>.Exists
	|
	|-RVA: 0x2B21EB0 Offset: 0x2B1DEB0 VA: 0x2B21EB0
	|-List<RangePositionInfo>.Exists
	|
	|-RVA: 0x2B2462C Offset: 0x2B2062C VA: 0x2B2462C
	|-List<ReinforceCristaData>.Exists
	|
	|-RVA: 0x2B26D38 Offset: 0x2B22D38 VA: 0x2B26D38
	|-List<sbyte>.Exists
	|
	|-RVA: 0x2B2937C Offset: 0x2B2537C VA: 0x2B2937C
	|-List<float>.Exists
	|
	|-RVA: 0x2B2B9B8 Offset: 0x2B279B8 VA: 0x2B2B9B8
	|-List<SkillIdData>.Exists
	|
	|-RVA: 0x2B2DFF0 Offset: 0x2B29FF0 VA: 0x2B2DFF0
	|-List<TimeSpan>.Exists
	|
	|-RVA: 0x2B54A08 Offset: 0x2B50A08 VA: 0x2B54A08
	|-List<ushort>.Exists
	|
	|-RVA: 0x2B57040 Offset: 0x2B53040 VA: 0x2B57040
	|-List<uint>.Exists
	|
	|-RVA: 0x2B59674 Offset: 0x2B55674 VA: 0x2B59674
	|-List<ulong>.Exists
	|
	|-RVA: 0x2B5BCC0 Offset: 0x2B57CC0 VA: 0x2B5BCC0
	|-List<Vector2>.Exists
	|
	|-RVA: 0x2B5E3BC Offset: 0x2B5A3BC VA: 0x2B5E3BC
	|-List<Vector3>.Exists
	|
	|-RVA: 0x2B60B3C Offset: 0x2B5CB3C VA: 0x2B60B3C
	|-List<X509ChainStatus>.Exists
	|
	|-RVA: 0x2B63950 Offset: 0x2B5F950 VA: 0x2B63950
	|-List<__Il2CppFullySharedGenericType>.Exists
	|
	|-RVA: 0x2B66CC8 Offset: 0x2B62CC8 VA: 0x2B66CC8
	|-List<BeforeRenderHelper.OrderBlock>.Exists
	|
	|-RVA: 0x2B6959C Offset: 0x2B6559C VA: 0x2B6959C
	|-List<BoneClip.MotionKeyFrame>.Exists
	|
	|-RVA: 0x2B6C158 Offset: 0x2B68158 VA: 0x2B6C158
	|-List<HouseRecipeManager.RecipeData>.Exists
	|
	|-RVA: 0x2B6EB88 Offset: 0x2B6AB88 VA: 0x2B6EB88
	|-List<KadarElexioBuf.SkillIdData>.Exists
	|
	|-RVA: 0x2B71218 Offset: 0x2B6D218 VA: 0x2B71218
	|-List<MissionTextManagerData.CheckIKeywordtemData>.Exists
	|
	|-RVA: 0x2B7397C Offset: 0x2B6F97C VA: 0x2B7397C
	|-List<MissionTextManagerData.PickUpFieldData>.Exists
	|
	|-RVA: 0x2B760A0 Offset: 0x2B720A0 VA: 0x2B760A0
	|-List<MobaRoomData.MobaAbilityMasterData>.Exists
	|
	|-RVA: 0x2B78838 Offset: 0x2B74838 VA: 0x2B78838
	|-List<NewWaveRoomData.Spotlight>.Exists
	|
	|-RVA: 0x2B7B15C Offset: 0x2B7715C VA: 0x2B7B15C
	|-List<NguiDynamicFontController.ApplyTextureInfo>.Exists
	|
	|-RVA: 0x2B7D888 Offset: 0x2B79888 VA: 0x2B7D888
	|-List<RegexCharClass.SingleRange>.Exists
	|
	|-RVA: 0x2B7FF24 Offset: 0x2B7BF24 VA: 0x2B7FF24
	|-List<SocialAchievementData.LinkData>.Exists
	|
	|-RVA: 0x2B82648 Offset: 0x2B7E648 VA: 0x2B82648
	|-List<TrophyManager.TrophyData>.Exists
	|
	|-RVA: 0x2B84E40 Offset: 0x2B80E40 VA: 0x2B84E40
	|-List<UIEventMenuButton.MessageButtonData>.Exists
	|
	|-RVA: 0x2B8797C Offset: 0x2B8397C VA: 0x2B8797C
	|-List<UIFieldMapPanel.PopData>.Exists
	|
	|-RVA: 0x2B8A244 Offset: 0x2B86244 VA: 0x2B8A244
	|-List<UIHouseAddressManager.Town>.Exists
	|
	|-RVA: 0x2B8C994 Offset: 0x2B88994 VA: 0x2B8C994
	|-List<UIInfoWindow.LabelPosition>.Exists
	|
	|-RVA: 0x2B8F25C Offset: 0x2B8B25C VA: 0x2B8F25C
	|-List<UIMainManager.DropItemData>.Exists
	|
	|-RVA: 0x2B918F0 Offset: 0x2B8D8F0 VA: 0x2B918F0
	|-List<UIScenarioOrderPanel.MissionData>.Exists
	|
	|-RVA: 0x2B941D4 Offset: 0x2B901D4 VA: 0x2B941D4
	|-List<UnitySynchronizationContext.WorkRequest>.Exists
	|
	|-RVA: 0x2B96C4C Offset: 0x2B92C4C VA: 0x2B96C4C
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Exists
	|
	|-RVA: 0x2B99440 Offset: 0x2B95440 VA: 0x2B99440
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.Exists
	|
	|-RVA: 0x2B9BD68 Offset: 0x2B97D68 VA: 0x2B9BD68
	|-List<InstructionList.DebugView.InstructionView>.Exists
	*/

	// RVA: -1 Offset: -1
	public T Find(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADCBC Offset: 0x2AA9CBC VA: 0x2AADCBC
	|-List<KeyValuePair<ArchetypeUid, object>>.Find
	|
	|-RVA: 0x2AB03E8 Offset: 0x2AAC3E8 VA: 0x2AB03E8
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.Find
	|
	|-RVA: 0x2AB2A30 Offset: 0x2AAEA30 VA: 0x2AB2A30
	|-List<KeyValuePair<byte, byte>>.Find
	|
	|-RVA: 0x2AB5448 Offset: 0x2AB1448 VA: 0x2AB5448
	|-List<KeyValuePair<byte, object>>.Find
	|
	|-RVA: 0x2AB7B6C Offset: 0x2AB3B6C VA: 0x2AB7B6C
	|-List<KeyValuePair<int, short>>.Find
	|
	|-RVA: 0x2ABA1A4 Offset: 0x2AB61A4 VA: 0x2ABA1A4
	|-List<KeyValuePair<int, int>>.Find
	|
	|-RVA: 0x2ABC838 Offset: 0x2AB8838 VA: 0x2ABC838
	|-List<KeyValuePair<int, object>>.Find
	|
	|-RVA: 0x2ABEF5C Offset: 0x2ABAF5C VA: 0x2ABEF5C
	|-List<KeyValuePair<Int32Enum, byte>>.Find
	|
	|-RVA: 0x2AC1724 Offset: 0x2ABD724 VA: 0x2AC1724
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.Find
	|
	|-RVA: 0x2AC4094 Offset: 0x2AC0094 VA: 0x2AC4094
	|-List<KeyValuePair<Int32Enum, int>>.Find
	|
	|-RVA: 0x2AC6728 Offset: 0x2AC2728 VA: 0x2AC6728
	|-List<KeyValuePair<Int32Enum, object>>.Find
	|
	|-RVA: 0x2AC8EA8 Offset: 0x2AC4EA8 VA: 0x2AC8EA8
	|-List<KeyValuePair<object, int>>.Find
	|
	|-RVA: 0x2ACB628 Offset: 0x2AC7628 VA: 0x2ACB628
	|-List<KeyValuePair<object, float>>.Find
	|
	|-RVA: 0x2ACDDA8 Offset: 0x2AC9DA8 VA: 0x2ACDDA8
	|-List<KeyValuePair<float, object>>.Find
	|
	|-RVA: 0x2AD0620 Offset: 0x2ACC620 VA: 0x2AD0620
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.Find
	|
	|-RVA: 0x2AD2F54 Offset: 0x2ACEF54 VA: 0x2AD2F54
	|-List<StructMultiKey<object, object>>.Find
	|
	|-RVA: 0x2AD5680 Offset: 0x2AD1680 VA: 0x2AD5680
	|-List<ValueTuple<short, short>>.Find
	|
	|-RVA: 0x2AD7CC0 Offset: 0x2AD3CC0 VA: 0x2AD7CC0
	|-List<ValueTuple<int, int>>.Find
	|
	|-RVA: 0x2ADA354 Offset: 0x2AD6354 VA: 0x2ADA354
	|-List<ValueTuple<int, object>>.Find
	|
	|-RVA: 0x2ADCA78 Offset: 0x2AD8A78 VA: 0x2ADCA78
	|-List<ValueTuple<Int32Enum, float>>.Find
	|
	|-RVA: 0x2ADF220 Offset: 0x2ADB220 VA: 0x2ADF220
	|-List<ValueTuple<Vector3, Vector3>>.Find
	|
	|-RVA: 0x2AE1B68 Offset: 0x2ADDB68 VA: 0x2AE1B68
	|-List<ArchetypeUid>.Find
	|
	|-RVA: 0x2AE41C0 Offset: 0x2AE01C0 VA: 0x2AE41C0
	|-List<bool>.Find
	|
	|-RVA: 0x2AE6818 Offset: 0x2AE2818 VA: 0x2AE6818
	|-List<byte>.Find
	|
	|-RVA: 0x2AE8E54 Offset: 0x2AE4E54 VA: 0x2AE8E54
	|-List<ByteEnum>.Find
	|
	|-RVA: 0x2AEB490 Offset: 0x2AE7490 VA: 0x2AEB490
	|-List<char>.Find
	|
	|-RVA: 0x2AEDB24 Offset: 0x2AE9B24 VA: 0x2AEDB24
	|-List<Color>.Find
	|
	|-RVA: 0x2AF0210 Offset: 0x2AEC210 VA: 0x2AF0210
	|-List<Color32>.Find
	|
	|-RVA: 0x2AF2850 Offset: 0x2AEE850 VA: 0x2AF2850
	|-List<DateTime>.Find
	|
	|-RVA: 0x2AF4EA0 Offset: 0x2AF0EA0 VA: 0x2AF4EA0
	|-List<DateTimeOffset>.Find
	|
	|-RVA: 0x2AF7560 Offset: 0x2AF3560 VA: 0x2AF7560
	|-List<Decimal>.Find
	|
	|-RVA: 0x2AF9C30 Offset: 0x2AF5C30 VA: 0x2AF9C30
	|-List<DefencePoint2>.Find
	|
	|-RVA: 0x2AFC270 Offset: 0x2AF8270 VA: 0x2AFC270
	|-List<double>.Find
	|
	|-RVA: 0x2AFE908 Offset: 0x2AFA908 VA: 0x2AFE908
	|-List<EventSummary>.Find
	|
	|-RVA: 0x2B0102C Offset: 0x2AFD02C VA: 0x2B0102C
	|-List<short>.Find
	|
	|-RVA: 0x2B03664 Offset: 0x2AFF664 VA: 0x2B03664
	|-List<Int16Enum>.Find
	|
	|-RVA: 0x2B05C9C Offset: 0x2B01C9C VA: 0x2B05C9C
	|-List<int>.Find
	|
	|-RVA: 0x2B082D0 Offset: 0x2B042D0 VA: 0x2B082D0
	|-List<Int32Enum>.Find
	|
	|-RVA: 0x2B0A904 Offset: 0x2B06904 VA: 0x2B0A904
	|-List<long>.Find
	|
	|-RVA: 0x2B0CF94 Offset: 0x2B08F94 VA: 0x2B0CF94
	|-List<InterpretedFrameInfo>.Find
	|
	|-RVA: 0x2B0F878 Offset: 0x2B0B878 VA: 0x2B0F878
	|-List<JsonPosition>.Find
	|
	|-RVA: 0x2B122AC Offset: 0x2B0E2AC VA: 0x2B122AC
	|-List<MaterialSearchData>.Find
	|
	|-RVA: 0x2B14A9C Offset: 0x2B10A9C VA: 0x2B14A9C
	|-List<MobActionTargetData>.Find
	|
	|-RVA: 0x2B175A4 Offset: 0x2B135A4 VA: 0x2B175A4
	|-List<MobIconLabelData>.Find
	|
	|-RVA: 0x2B19FC0 Offset: 0x2B15FC0 VA: 0x2B19FC0
	|-List<object>.Find
	|
	|-RVA: 0x2B1C844 Offset: 0x2B18844 VA: 0x2B1C844
	|-List<PlayerLoopSystem>.Find
	|
	|-RVA: 0x2B1F44C Offset: 0x2B1B44C VA: 0x2B1F44C
	|-List<PlayerLoopSystemInternal>.Find
	|
	|-RVA: 0x2B21EEC Offset: 0x2B1DEEC VA: 0x2B21EEC
	|-List<RangePositionInfo>.Find
	|
	|-RVA: 0x2B24668 Offset: 0x2B20668 VA: 0x2B24668
	|-List<ReinforceCristaData>.Find
	|
	|-RVA: 0x2B26D74 Offset: 0x2B22D74 VA: 0x2B26D74
	|-List<sbyte>.Find
	|
	|-RVA: 0x2B293B8 Offset: 0x2B253B8 VA: 0x2B293B8
	|-List<float>.Find
	|
	|-RVA: 0x2B2B9F4 Offset: 0x2B279F4 VA: 0x2B2B9F4
	|-List<SkillIdData>.Find
	|
	|-RVA: 0x2B2E02C Offset: 0x2B2A02C VA: 0x2B2E02C
	|-List<TimeSpan>.Find
	|
	|-RVA: 0x2B54A44 Offset: 0x2B50A44 VA: 0x2B54A44
	|-List<ushort>.Find
	|
	|-RVA: 0x2B5707C Offset: 0x2B5307C VA: 0x2B5707C
	|-List<uint>.Find
	|
	|-RVA: 0x2B596B0 Offset: 0x2B556B0 VA: 0x2B596B0
	|-List<ulong>.Find
	|
	|-RVA: 0x2B5BCFC Offset: 0x2B57CFC VA: 0x2B5BCFC
	|-List<Vector2>.Find
	|
	|-RVA: 0x2B5E3F8 Offset: 0x2B5A3F8 VA: 0x2B5E3F8
	|-List<Vector3>.Find
	|
	|-RVA: 0x2B60B78 Offset: 0x2B5CB78 VA: 0x2B60B78
	|-List<X509ChainStatus>.Find
	|
	|-RVA: 0x2B63978 Offset: 0x2B5F978 VA: 0x2B63978
	|-List<__Il2CppFullySharedGenericType>.Find
	|
	|-RVA: 0x2B66D04 Offset: 0x2B62D04 VA: 0x2B66D04
	|-List<BeforeRenderHelper.OrderBlock>.Find
	|
	|-RVA: 0x2B695D8 Offset: 0x2B655D8 VA: 0x2B695D8
	|-List<BoneClip.MotionKeyFrame>.Find
	|
	|-RVA: 0x2B6C194 Offset: 0x2B68194 VA: 0x2B6C194
	|-List<HouseRecipeManager.RecipeData>.Find
	|
	|-RVA: 0x2B6EBC4 Offset: 0x2B6ABC4 VA: 0x2B6EBC4
	|-List<KadarElexioBuf.SkillIdData>.Find
	|
	|-RVA: 0x2B71254 Offset: 0x2B6D254 VA: 0x2B71254
	|-List<MissionTextManagerData.CheckIKeywordtemData>.Find
	|
	|-RVA: 0x2B739B8 Offset: 0x2B6F9B8 VA: 0x2B739B8
	|-List<MissionTextManagerData.PickUpFieldData>.Find
	|
	|-RVA: 0x2B760DC Offset: 0x2B720DC VA: 0x2B760DC
	|-List<MobaRoomData.MobaAbilityMasterData>.Find
	|
	|-RVA: 0x2B78874 Offset: 0x2B74874 VA: 0x2B78874
	|-List<NewWaveRoomData.Spotlight>.Find
	|
	|-RVA: 0x2B7B198 Offset: 0x2B77198 VA: 0x2B7B198
	|-List<NguiDynamicFontController.ApplyTextureInfo>.Find
	|
	|-RVA: 0x2B7D8C4 Offset: 0x2B798C4 VA: 0x2B7D8C4
	|-List<RegexCharClass.SingleRange>.Find
	|
	|-RVA: 0x2B7FF60 Offset: 0x2B7BF60 VA: 0x2B7FF60
	|-List<SocialAchievementData.LinkData>.Find
	|
	|-RVA: 0x2B82684 Offset: 0x2B7E684 VA: 0x2B82684
	|-List<TrophyManager.TrophyData>.Find
	|
	|-RVA: 0x2B84E7C Offset: 0x2B80E7C VA: 0x2B84E7C
	|-List<UIEventMenuButton.MessageButtonData>.Find
	|
	|-RVA: 0x2B879B8 Offset: 0x2B839B8 VA: 0x2B879B8
	|-List<UIFieldMapPanel.PopData>.Find
	|
	|-RVA: 0x2B8A280 Offset: 0x2B86280 VA: 0x2B8A280
	|-List<UIHouseAddressManager.Town>.Find
	|
	|-RVA: 0x2B8C9D0 Offset: 0x2B889D0 VA: 0x2B8C9D0
	|-List<UIInfoWindow.LabelPosition>.Find
	|
	|-RVA: 0x2B8F298 Offset: 0x2B8B298 VA: 0x2B8F298
	|-List<UIMainManager.DropItemData>.Find
	|
	|-RVA: 0x2B9192C Offset: 0x2B8D92C VA: 0x2B9192C
	|-List<UIScenarioOrderPanel.MissionData>.Find
	|
	|-RVA: 0x2B94210 Offset: 0x2B90210 VA: 0x2B94210
	|-List<UnitySynchronizationContext.WorkRequest>.Find
	|
	|-RVA: 0x2B96C88 Offset: 0x2B92C88 VA: 0x2B96C88
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Find
	|
	|-RVA: 0x2B9947C Offset: 0x2B9547C VA: 0x2B9947C
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.Find
	|
	|-RVA: 0x2B9BDA4 Offset: 0x2B97DA4 VA: 0x2B9BDA4
	|-List<InstructionList.DebugView.InstructionView>.Find
	*/

	// RVA: -1 Offset: -1
	public List<T> FindAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADD78 Offset: 0x2AA9D78 VA: 0x2AADD78
	|-List<KeyValuePair<ArchetypeUid, object>>.FindAll
	|
	|-RVA: 0x2AB0490 Offset: 0x2AAC490 VA: 0x2AB0490
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.FindAll
	|
	|-RVA: 0x2AB2AD8 Offset: 0x2AAEAD8 VA: 0x2AB2AD8
	|-List<KeyValuePair<byte, byte>>.FindAll
	|
	|-RVA: 0x2AB5504 Offset: 0x2AB1504 VA: 0x2AB5504
	|-List<KeyValuePair<byte, object>>.FindAll
	|
	|-RVA: 0x2AB7C14 Offset: 0x2AB3C14 VA: 0x2AB7C14
	|-List<KeyValuePair<int, short>>.FindAll
	|
	|-RVA: 0x2ABA24C Offset: 0x2AB624C VA: 0x2ABA24C
	|-List<KeyValuePair<int, int>>.FindAll
	|
	|-RVA: 0x2ABC8F4 Offset: 0x2AB88F4 VA: 0x2ABC8F4
	|-List<KeyValuePair<int, object>>.FindAll
	|
	|-RVA: 0x2ABF004 Offset: 0x2ABB004 VA: 0x2ABF004
	|-List<KeyValuePair<Int32Enum, byte>>.FindAll
	|
	|-RVA: 0x2AC181C Offset: 0x2ABD81C VA: 0x2AC181C
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.FindAll
	|
	|-RVA: 0x2AC413C Offset: 0x2AC013C VA: 0x2AC413C
	|-List<KeyValuePair<Int32Enum, int>>.FindAll
	|
	|-RVA: 0x2AC67E4 Offset: 0x2AC27E4 VA: 0x2AC67E4
	|-List<KeyValuePair<Int32Enum, object>>.FindAll
	|
	|-RVA: 0x2AC8F64 Offset: 0x2AC4F64 VA: 0x2AC8F64
	|-List<KeyValuePair<object, int>>.FindAll
	|
	|-RVA: 0x2ACB6E4 Offset: 0x2AC76E4 VA: 0x2ACB6E4
	|-List<KeyValuePair<object, float>>.FindAll
	|
	|-RVA: 0x2ACDE64 Offset: 0x2AC9E64 VA: 0x2ACDE64
	|-List<KeyValuePair<float, object>>.FindAll
	|
	|-RVA: 0x2AD06FC Offset: 0x2ACC6FC VA: 0x2AD06FC
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.FindAll
	|
	|-RVA: 0x2AD3010 Offset: 0x2ACF010 VA: 0x2AD3010
	|-List<StructMultiKey<object, object>>.FindAll
	|
	|-RVA: 0x2AD5728 Offset: 0x2AD1728 VA: 0x2AD5728
	|-List<ValueTuple<short, short>>.FindAll
	|
	|-RVA: 0x2AD7D68 Offset: 0x2AD3D68 VA: 0x2AD7D68
	|-List<ValueTuple<int, int>>.FindAll
	|
	|-RVA: 0x2ADA410 Offset: 0x2AD6410 VA: 0x2ADA410
	|-List<ValueTuple<int, object>>.FindAll
	|
	|-RVA: 0x2ADCB20 Offset: 0x2AD8B20 VA: 0x2ADCB20
	|-List<ValueTuple<Int32Enum, float>>.FindAll
	|
	|-RVA: 0x2ADF314 Offset: 0x2ADB314 VA: 0x2ADF314
	|-List<ValueTuple<Vector3, Vector3>>.FindAll
	|
	|-RVA: 0x2AE1C10 Offset: 0x2ADDC10 VA: 0x2AE1C10
	|-List<ArchetypeUid>.FindAll
	|
	|-RVA: 0x2AE4270 Offset: 0x2AE0270 VA: 0x2AE4270
	|-List<bool>.FindAll
	|
	|-RVA: 0x2AE68C0 Offset: 0x2AE28C0 VA: 0x2AE68C0
	|-List<byte>.FindAll
	|
	|-RVA: 0x2AE8EFC Offset: 0x2AE4EFC VA: 0x2AE8EFC
	|-List<ByteEnum>.FindAll
	|
	|-RVA: 0x2AEB538 Offset: 0x2AE7538 VA: 0x2AEB538
	|-List<char>.FindAll
	|
	|-RVA: 0x2AEDBFC Offset: 0x2AE9BFC VA: 0x2AEDBFC
	|-List<Color>.FindAll
	|
	|-RVA: 0x2AF02B8 Offset: 0x2AEC2B8 VA: 0x2AF02B8
	|-List<Color32>.FindAll
	|
	|-RVA: 0x2AF28F8 Offset: 0x2AEE8F8 VA: 0x2AF28F8
	|-List<DateTime>.FindAll
	|
	|-RVA: 0x2AF4F5C Offset: 0x2AF0F5C VA: 0x2AF4F5C
	|-List<DateTimeOffset>.FindAll
	|
	|-RVA: 0x2AF761C Offset: 0x2AF361C VA: 0x2AF761C
	|-List<Decimal>.FindAll
	|
	|-RVA: 0x2AF9CD8 Offset: 0x2AF5CD8 VA: 0x2AF9CD8
	|-List<DefencePoint2>.FindAll
	|
	|-RVA: 0x2AFC324 Offset: 0x2AF8324 VA: 0x2AFC324
	|-List<double>.FindAll
	|
	|-RVA: 0x2AFE9C4 Offset: 0x2AFA9C4 VA: 0x2AFE9C4
	|-List<EventSummary>.FindAll
	|
	|-RVA: 0x2B010D4 Offset: 0x2AFD0D4 VA: 0x2B010D4
	|-List<short>.FindAll
	|
	|-RVA: 0x2B0370C Offset: 0x2AFF70C VA: 0x2B0370C
	|-List<Int16Enum>.FindAll
	|
	|-RVA: 0x2B05D44 Offset: 0x2B01D44 VA: 0x2B05D44
	|-List<int>.FindAll
	|
	|-RVA: 0x2B08378 Offset: 0x2B04378 VA: 0x2B08378
	|-List<Int32Enum>.FindAll
	|
	|-RVA: 0x2B0A9AC Offset: 0x2B069AC VA: 0x2B0A9AC
	|-List<long>.FindAll
	|
	|-RVA: 0x2B0D050 Offset: 0x2B09050 VA: 0x2B0D050
	|-List<InterpretedFrameInfo>.FindAll
	|
	|-RVA: 0x2B0F96C Offset: 0x2B0B96C VA: 0x2B0F96C
	|-List<JsonPosition>.FindAll
	|
	|-RVA: 0x2B12368 Offset: 0x2B0E368 VA: 0x2B12368
	|-List<MaterialSearchData>.FindAll
	|
	|-RVA: 0x2B14B90 Offset: 0x2B10B90 VA: 0x2B14B90
	|-List<MobActionTargetData>.FindAll
	|
	|-RVA: 0x2B17698 Offset: 0x2B13698 VA: 0x2B17698
	|-List<MobIconLabelData>.FindAll
	|
	|-RVA: 0x2B1A068 Offset: 0x2B16068 VA: 0x2B1A068
	|-List<object>.FindAll
	|
	|-RVA: 0x2B1C93C Offset: 0x2B1893C VA: 0x2B1C93C
	|-List<PlayerLoopSystem>.FindAll
	|
	|-RVA: 0x2B1F544 Offset: 0x2B1B544 VA: 0x2B1F544
	|-List<PlayerLoopSystemInternal>.FindAll
	|
	|-RVA: 0x2B21FA8 Offset: 0x2B1DFA8 VA: 0x2B21FA8
	|-List<RangePositionInfo>.FindAll
	|
	|-RVA: 0x2B2472C Offset: 0x2B2072C VA: 0x2B2472C
	|-List<ReinforceCristaData>.FindAll
	|
	|-RVA: 0x2B26E1C Offset: 0x2B22E1C VA: 0x2B26E1C
	|-List<sbyte>.FindAll
	|
	|-RVA: 0x2B2946C Offset: 0x2B2546C VA: 0x2B2946C
	|-List<float>.FindAll
	|
	|-RVA: 0x2B2BA9C Offset: 0x2B27A9C VA: 0x2B2BA9C
	|-List<SkillIdData>.FindAll
	|
	|-RVA: 0x2B2E0D4 Offset: 0x2B2A0D4 VA: 0x2B2E0D4
	|-List<TimeSpan>.FindAll
	|
	|-RVA: 0x2B54AEC Offset: 0x2B50AEC VA: 0x2B54AEC
	|-List<ushort>.FindAll
	|
	|-RVA: 0x2B57124 Offset: 0x2B53124 VA: 0x2B57124
	|-List<uint>.FindAll
	|
	|-RVA: 0x2B59758 Offset: 0x2B55758 VA: 0x2B59758
	|-List<ulong>.FindAll
	|
	|-RVA: 0x2B5BDC4 Offset: 0x2B57DC4 VA: 0x2B5BDC4
	|-List<Vector2>.FindAll
	|
	|-RVA: 0x2B5E4CC Offset: 0x2B5A4CC VA: 0x2B5E4CC
	|-List<Vector3>.FindAll
	|
	|-RVA: 0x2B60C34 Offset: 0x2B5CC34 VA: 0x2B60C34
	|-List<X509ChainStatus>.FindAll
	|
	|-RVA: 0x2B63B3C Offset: 0x2B5FB3C VA: 0x2B63B3C
	|-List<__Il2CppFullySharedGenericType>.FindAll
	|
	|-RVA: 0x2B66DC0 Offset: 0x2B62DC0 VA: 0x2B66DC0
	|-List<BeforeRenderHelper.OrderBlock>.FindAll
	|
	|-RVA: 0x2B696CC Offset: 0x2B656CC VA: 0x2B696CC
	|-List<BoneClip.MotionKeyFrame>.FindAll
	|
	|-RVA: 0x2B6C28C Offset: 0x2B6828C VA: 0x2B6C28C
	|-List<HouseRecipeManager.RecipeData>.FindAll
	|
	|-RVA: 0x2B6EC6C Offset: 0x2B6AC6C VA: 0x2B6EC6C
	|-List<KadarElexioBuf.SkillIdData>.FindAll
	|
	|-RVA: 0x2B71318 Offset: 0x2B6D318 VA: 0x2B71318
	|-List<MissionTextManagerData.CheckIKeywordtemData>.FindAll
	|
	|-RVA: 0x2B73A7C Offset: 0x2B6FA7C VA: 0x2B73A7C
	|-List<MissionTextManagerData.PickUpFieldData>.FindAll
	|
	|-RVA: 0x2B76198 Offset: 0x2B72198 VA: 0x2B76198
	|-List<MobaRoomData.MobaAbilityMasterData>.FindAll
	|
	|-RVA: 0x2B78950 Offset: 0x2B74950 VA: 0x2B78950
	|-List<NewWaveRoomData.Spotlight>.FindAll
	|
	|-RVA: 0x2B7B254 Offset: 0x2B77254 VA: 0x2B7B254
	|-List<NguiDynamicFontController.ApplyTextureInfo>.FindAll
	|
	|-RVA: 0x2B7D96C Offset: 0x2B7996C VA: 0x2B7D96C
	|-List<RegexCharClass.SingleRange>.FindAll
	|
	|-RVA: 0x2B8001C Offset: 0x2B7C01C VA: 0x2B8001C
	|-List<SocialAchievementData.LinkData>.FindAll
	|
	|-RVA: 0x2B8272C Offset: 0x2B7E72C VA: 0x2B8272C
	|-List<TrophyManager.TrophyData>.FindAll
	|
	|-RVA: 0x2B84F74 Offset: 0x2B80F74 VA: 0x2B84F74
	|-List<UIEventMenuButton.MessageButtonData>.FindAll
	|
	|-RVA: 0x2B87A94 Offset: 0x2B83A94 VA: 0x2B87A94
	|-List<UIFieldMapPanel.PopData>.FindAll
	|
	|-RVA: 0x2B8A328 Offset: 0x2B86328 VA: 0x2B8A328
	|-List<UIHouseAddressManager.Town>.FindAll
	|
	|-RVA: 0x2B8CAAC Offset: 0x2B88AAC VA: 0x2B8CAAC
	|-List<UIInfoWindow.LabelPosition>.FindAll
	|
	|-RVA: 0x2B8F340 Offset: 0x2B8B340 VA: 0x2B8F340
	|-List<UIMainManager.DropItemData>.FindAll
	|
	|-RVA: 0x2B919E8 Offset: 0x2B8D9E8 VA: 0x2B919E8
	|-List<UIScenarioOrderPanel.MissionData>.FindAll
	|
	|-RVA: 0x2B94304 Offset: 0x2B90304 VA: 0x2B94304
	|-List<UnitySynchronizationContext.WorkRequest>.FindAll
	|
	|-RVA: 0x2B96D44 Offset: 0x2B92D44 VA: 0x2B96D44
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.FindAll
	|
	|-RVA: 0x2B99558 Offset: 0x2B95558 VA: 0x2B99558
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.FindAll
	|
	|-RVA: 0x2B9BE80 Offset: 0x2B97E80 VA: 0x2B9BE80
	|-List<InstructionList.DebugView.InstructionView>.FindAll
	*/

	// RVA: -1 Offset: -1
	public int FindIndex(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADED0 Offset: 0x2AA9ED0 VA: 0x2AADED0
	|-List<KeyValuePair<ArchetypeUid, object>>.FindIndex
	|
	|-RVA: 0x2AB05D4 Offset: 0x2AAC5D4 VA: 0x2AB05D4
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.FindIndex
	|
	|-RVA: 0x2AB2C1C Offset: 0x2AAEC1C VA: 0x2AB2C1C
	|-List<KeyValuePair<byte, byte>>.FindIndex
	|
	|-RVA: 0x2AB565C Offset: 0x2AB165C VA: 0x2AB565C
	|-List<KeyValuePair<byte, object>>.FindIndex
	|
	|-RVA: 0x2AB7D58 Offset: 0x2AB3D58 VA: 0x2AB7D58
	|-List<KeyValuePair<int, short>>.FindIndex
	|
	|-RVA: 0x2ABA390 Offset: 0x2AB6390 VA: 0x2ABA390
	|-List<KeyValuePair<int, int>>.FindIndex
	|
	|-RVA: 0x2ABCA4C Offset: 0x2AB8A4C VA: 0x2ABCA4C
	|-List<KeyValuePair<int, object>>.FindIndex
	|
	|-RVA: 0x2ABF148 Offset: 0x2ABB148 VA: 0x2ABF148
	|-List<KeyValuePair<Int32Enum, byte>>.FindIndex
	|
	|-RVA: 0x2AC19D4 Offset: 0x2ABD9D4 VA: 0x2AC19D4
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.FindIndex
	|
	|-RVA: 0x2AC4280 Offset: 0x2AC0280 VA: 0x2AC4280
	|-List<KeyValuePair<Int32Enum, int>>.FindIndex
	|
	|-RVA: 0x2AC693C Offset: 0x2AC293C VA: 0x2AC693C
	|-List<KeyValuePair<Int32Enum, object>>.FindIndex
	|
	|-RVA: 0x2AC90BC Offset: 0x2AC50BC VA: 0x2AC90BC
	|-List<KeyValuePair<object, int>>.FindIndex
	|
	|-RVA: 0x2ACB83C Offset: 0x2AC783C VA: 0x2ACB83C
	|-List<KeyValuePair<object, float>>.FindIndex
	|
	|-RVA: 0x2ACDFBC Offset: 0x2AC9FBC VA: 0x2ACDFBC
	|-List<KeyValuePair<float, object>>.FindIndex
	|
	|-RVA: 0x2AD0888 Offset: 0x2ACC888 VA: 0x2AD0888
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.FindIndex
	|
	|-RVA: 0x2AD3168 Offset: 0x2ACF168 VA: 0x2AD3168
	|-List<StructMultiKey<object, object>>.FindIndex
	|
	|-RVA: 0x2AD586C Offset: 0x2AD186C VA: 0x2AD586C
	|-List<ValueTuple<short, short>>.FindIndex
	|
	|-RVA: 0x2AD7EAC Offset: 0x2AD3EAC VA: 0x2AD7EAC
	|-List<ValueTuple<int, int>>.FindIndex
	|
	|-RVA: 0x2ADA568 Offset: 0x2AD6568 VA: 0x2ADA568
	|-List<ValueTuple<int, object>>.FindIndex
	|
	|-RVA: 0x2ADCC64 Offset: 0x2AD8C64 VA: 0x2ADCC64
	|-List<ValueTuple<Int32Enum, float>>.FindIndex
	|
	|-RVA: 0x2ADF4CC Offset: 0x2ADB4CC VA: 0x2ADF4CC
	|-List<ValueTuple<Vector3, Vector3>>.FindIndex
	|
	|-RVA: 0x2AE1D54 Offset: 0x2ADDD54 VA: 0x2AE1D54
	|-List<ArchetypeUid>.FindIndex
	|
	|-RVA: 0x2AE43BC Offset: 0x2AE03BC VA: 0x2AE43BC
	|-List<bool>.FindIndex
	|
	|-RVA: 0x2AE6A04 Offset: 0x2AE2A04 VA: 0x2AE6A04
	|-List<byte>.FindIndex
	|
	|-RVA: 0x2AE9040 Offset: 0x2AE5040 VA: 0x2AE9040
	|-List<ByteEnum>.FindIndex
	|
	|-RVA: 0x2AEB67C Offset: 0x2AE767C VA: 0x2AEB67C
	|-List<char>.FindIndex
	|
	|-RVA: 0x2AEDD54 Offset: 0x2AE9D54 VA: 0x2AEDD54
	|-List<Color>.FindIndex
	|
	|-RVA: 0x2AF03FC Offset: 0x2AEC3FC VA: 0x2AF03FC
	|-List<Color32>.FindIndex
	|
	|-RVA: 0x2AF2A3C Offset: 0x2AEEA3C VA: 0x2AF2A3C
	|-List<DateTime>.FindIndex
	|
	|-RVA: 0x2AF50A8 Offset: 0x2AF10A8 VA: 0x2AF50A8
	|-List<DateTimeOffset>.FindIndex
	|
	|-RVA: 0x2AF7768 Offset: 0x2AF3768 VA: 0x2AF7768
	|-List<Decimal>.FindIndex
	|
	|-RVA: 0x2AF9E1C Offset: 0x2AF5E1C VA: 0x2AF9E1C
	|-List<DefencePoint2>.FindIndex
	|
	|-RVA: 0x2AFC468 Offset: 0x2AF8468 VA: 0x2AFC468
	|-List<double>.FindIndex
	|
	|-RVA: 0x2AFEB1C Offset: 0x2AFAB1C VA: 0x2AFEB1C
	|-List<EventSummary>.FindIndex
	|
	|-RVA: 0x2B01218 Offset: 0x2AFD218 VA: 0x2B01218
	|-List<short>.FindIndex
	|
	|-RVA: 0x2B03850 Offset: 0x2AFF850 VA: 0x2B03850
	|-List<Int16Enum>.FindIndex
	|
	|-RVA: 0x2B05E88 Offset: 0x2B01E88 VA: 0x2B05E88
	|-List<int>.FindIndex
	|
	|-RVA: 0x2B084BC Offset: 0x2B044BC VA: 0x2B084BC
	|-List<Int32Enum>.FindIndex
	|
	|-RVA: 0x2B0AAF0 Offset: 0x2B06AF0 VA: 0x2B0AAF0
	|-List<long>.FindIndex
	|
	|-RVA: 0x2B0D1A8 Offset: 0x2B091A8 VA: 0x2B0D1A8
	|-List<InterpretedFrameInfo>.FindIndex
	|
	|-RVA: 0x2B0FB30 Offset: 0x2B0BB30 VA: 0x2B0FB30
	|-List<JsonPosition>.FindIndex
	|
	|-RVA: 0x2B124B4 Offset: 0x2B0E4B4 VA: 0x2B124B4
	|-List<MaterialSearchData>.FindIndex
	|
	|-RVA: 0x2B14D48 Offset: 0x2B10D48 VA: 0x2B14D48
	|-List<MobActionTargetData>.FindIndex
	|
	|-RVA: 0x2B1785C Offset: 0x2B1385C VA: 0x2B1785C
	|-List<MobIconLabelData>.FindIndex
	|
	|-RVA: 0x2B1A1B0 Offset: 0x2B161B0 VA: 0x2B1A1B0
	|-List<object>.FindIndex
	|
	|-RVA: 0x2B1CB00 Offset: 0x2B18B00 VA: 0x2B1CB00
	|-List<PlayerLoopSystem>.FindIndex
	|
	|-RVA: 0x2B1F708 Offset: 0x2B1B708 VA: 0x2B1F708
	|-List<PlayerLoopSystemInternal>.FindIndex
	|
	|-RVA: 0x2B22100 Offset: 0x2B1E100 VA: 0x2B22100
	|-List<RangePositionInfo>.FindIndex
	|
	|-RVA: 0x2B24888 Offset: 0x2B20888 VA: 0x2B24888
	|-List<ReinforceCristaData>.FindIndex
	|
	|-RVA: 0x2B26F60 Offset: 0x2B22F60 VA: 0x2B26F60
	|-List<sbyte>.FindIndex
	|
	|-RVA: 0x2B295B0 Offset: 0x2B255B0 VA: 0x2B295B0
	|-List<float>.FindIndex
	|
	|-RVA: 0x2B2BBE0 Offset: 0x2B27BE0 VA: 0x2B2BBE0
	|-List<SkillIdData>.FindIndex
	|
	|-RVA: 0x2B2E218 Offset: 0x2B2A218 VA: 0x2B2E218
	|-List<TimeSpan>.FindIndex
	|
	|-RVA: 0x2B54C30 Offset: 0x2B50C30 VA: 0x2B54C30
	|-List<ushort>.FindIndex
	|
	|-RVA: 0x2B57268 Offset: 0x2B53268 VA: 0x2B57268
	|-List<uint>.FindIndex
	|
	|-RVA: 0x2B5989C Offset: 0x2B5589C VA: 0x2B5989C
	|-List<ulong>.FindIndex
	|
	|-RVA: 0x2B5BF10 Offset: 0x2B57F10 VA: 0x2B5BF10
	|-List<Vector2>.FindIndex
	|
	|-RVA: 0x2B5E628 Offset: 0x2B5A628 VA: 0x2B5E628
	|-List<Vector3>.FindIndex
	|
	|-RVA: 0x2B60D8C Offset: 0x2B5CD8C VA: 0x2B60D8C
	|-List<X509ChainStatus>.FindIndex
	|
	|-RVA: 0x2B63D1C Offset: 0x2B5FD1C VA: 0x2B63D1C
	|-List<__Il2CppFullySharedGenericType>.FindIndex
	|
	|-RVA: 0x2B66F18 Offset: 0x2B62F18 VA: 0x2B66F18
	|-List<BeforeRenderHelper.OrderBlock>.FindIndex
	|
	|-RVA: 0x2B6988C Offset: 0x2B6588C VA: 0x2B6988C
	|-List<BoneClip.MotionKeyFrame>.FindIndex
	|
	|-RVA: 0x2B6C44C Offset: 0x2B6844C VA: 0x2B6C44C
	|-List<HouseRecipeManager.RecipeData>.FindIndex
	|
	|-RVA: 0x2B6EDB0 Offset: 0x2B6ADB0 VA: 0x2B6EDB0
	|-List<KadarElexioBuf.SkillIdData>.FindIndex
	|
	|-RVA: 0x2B71474 Offset: 0x2B6D474 VA: 0x2B71474
	|-List<MissionTextManagerData.CheckIKeywordtemData>.FindIndex
	|
	|-RVA: 0x2B73BD8 Offset: 0x2B6FBD8 VA: 0x2B73BD8
	|-List<MissionTextManagerData.PickUpFieldData>.FindIndex
	|
	|-RVA: 0x2B762E4 Offset: 0x2B722E4 VA: 0x2B762E4
	|-List<MobaRoomData.MobaAbilityMasterData>.FindIndex
	|
	|-RVA: 0x2B78ADC Offset: 0x2B74ADC VA: 0x2B78ADC
	|-List<NewWaveRoomData.Spotlight>.FindIndex
	|
	|-RVA: 0x2B7B3AC Offset: 0x2B773AC VA: 0x2B7B3AC
	|-List<NguiDynamicFontController.ApplyTextureInfo>.FindIndex
	|
	|-RVA: 0x2B7DAB0 Offset: 0x2B79AB0 VA: 0x2B7DAB0
	|-List<RegexCharClass.SingleRange>.FindIndex
	|
	|-RVA: 0x2B80174 Offset: 0x2B7C174 VA: 0x2B80174
	|-List<SocialAchievementData.LinkData>.FindIndex
	|
	|-RVA: 0x2B82870 Offset: 0x2B7E870 VA: 0x2B82870
	|-List<TrophyManager.TrophyData>.FindIndex
	|
	|-RVA: 0x2B85138 Offset: 0x2B81138 VA: 0x2B85138
	|-List<UIEventMenuButton.MessageButtonData>.FindIndex
	|
	|-RVA: 0x2B87C20 Offset: 0x2B83C20 VA: 0x2B87C20
	|-List<UIFieldMapPanel.PopData>.FindIndex
	|
	|-RVA: 0x2B8A46C Offset: 0x2B8646C VA: 0x2B8A46C
	|-List<UIHouseAddressManager.Town>.FindIndex
	|
	|-RVA: 0x2B8CC38 Offset: 0x2B88C38 VA: 0x2B8CC38
	|-List<UIInfoWindow.LabelPosition>.FindIndex
	|
	|-RVA: 0x2B8F484 Offset: 0x2B8B484 VA: 0x2B8F484
	|-List<UIMainManager.DropItemData>.FindIndex
	|
	|-RVA: 0x2B91B40 Offset: 0x2B8DB40 VA: 0x2B91B40
	|-List<UIScenarioOrderPanel.MissionData>.FindIndex
	|
	|-RVA: 0x2B944C8 Offset: 0x2B904C8 VA: 0x2B944C8
	|-List<UnitySynchronizationContext.WorkRequest>.FindIndex
	|
	|-RVA: 0x2B96E9C Offset: 0x2B92E9C VA: 0x2B96E9C
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.FindIndex
	|
	|-RVA: 0x2B996D8 Offset: 0x2B956D8 VA: 0x2B996D8
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.FindIndex
	|
	|-RVA: 0x2B9C00C Offset: 0x2B9800C VA: 0x2B9C00C
	|-List<InstructionList.DebugView.InstructionView>.FindIndex
	*/

	// RVA: -1 Offset: -1
	public int FindIndex(int startIndex, int count, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADEEC Offset: 0x2AA9EEC VA: 0x2AADEEC
	|-List<KeyValuePair<ArchetypeUid, object>>.FindIndex
	|
	|-RVA: 0x2AB05F0 Offset: 0x2AAC5F0 VA: 0x2AB05F0
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.FindIndex
	|
	|-RVA: 0x2AB2C38 Offset: 0x2AAEC38 VA: 0x2AB2C38
	|-List<KeyValuePair<byte, byte>>.FindIndex
	|
	|-RVA: 0x2AB5678 Offset: 0x2AB1678 VA: 0x2AB5678
	|-List<KeyValuePair<byte, object>>.FindIndex
	|
	|-RVA: 0x2AB7D74 Offset: 0x2AB3D74 VA: 0x2AB7D74
	|-List<KeyValuePair<int, short>>.FindIndex
	|
	|-RVA: 0x2ABA3AC Offset: 0x2AB63AC VA: 0x2ABA3AC
	|-List<KeyValuePair<int, int>>.FindIndex
	|
	|-RVA: 0x2ABCA68 Offset: 0x2AB8A68 VA: 0x2ABCA68
	|-List<KeyValuePair<int, object>>.FindIndex
	|
	|-RVA: 0x2ABF164 Offset: 0x2ABB164 VA: 0x2ABF164
	|-List<KeyValuePair<Int32Enum, byte>>.FindIndex
	|
	|-RVA: 0x2AC19F0 Offset: 0x2ABD9F0 VA: 0x2AC19F0
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.FindIndex
	|
	|-RVA: 0x2AC429C Offset: 0x2AC029C VA: 0x2AC429C
	|-List<KeyValuePair<Int32Enum, int>>.FindIndex
	|
	|-RVA: 0x2AC6958 Offset: 0x2AC2958 VA: 0x2AC6958
	|-List<KeyValuePair<Int32Enum, object>>.FindIndex
	|
	|-RVA: 0x2AC90D8 Offset: 0x2AC50D8 VA: 0x2AC90D8
	|-List<KeyValuePair<object, int>>.FindIndex
	|
	|-RVA: 0x2ACB858 Offset: 0x2AC7858 VA: 0x2ACB858
	|-List<KeyValuePair<object, float>>.FindIndex
	|
	|-RVA: 0x2ACDFD8 Offset: 0x2AC9FD8 VA: 0x2ACDFD8
	|-List<KeyValuePair<float, object>>.FindIndex
	|
	|-RVA: 0x2AD08A4 Offset: 0x2ACC8A4 VA: 0x2AD08A4
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.FindIndex
	|
	|-RVA: 0x2AD3184 Offset: 0x2ACF184 VA: 0x2AD3184
	|-List<StructMultiKey<object, object>>.FindIndex
	|
	|-RVA: 0x2AD5888 Offset: 0x2AD1888 VA: 0x2AD5888
	|-List<ValueTuple<short, short>>.FindIndex
	|
	|-RVA: 0x2AD7EC8 Offset: 0x2AD3EC8 VA: 0x2AD7EC8
	|-List<ValueTuple<int, int>>.FindIndex
	|
	|-RVA: 0x2ADA584 Offset: 0x2AD6584 VA: 0x2ADA584
	|-List<ValueTuple<int, object>>.FindIndex
	|
	|-RVA: 0x2ADCC80 Offset: 0x2AD8C80 VA: 0x2ADCC80
	|-List<ValueTuple<Int32Enum, float>>.FindIndex
	|
	|-RVA: 0x2ADF4E8 Offset: 0x2ADB4E8 VA: 0x2ADF4E8
	|-List<ValueTuple<Vector3, Vector3>>.FindIndex
	|
	|-RVA: 0x2AE1D70 Offset: 0x2ADDD70 VA: 0x2AE1D70
	|-List<ArchetypeUid>.FindIndex
	|
	|-RVA: 0x2AE43D8 Offset: 0x2AE03D8 VA: 0x2AE43D8
	|-List<bool>.FindIndex
	|
	|-RVA: 0x2AE6A20 Offset: 0x2AE2A20 VA: 0x2AE6A20
	|-List<byte>.FindIndex
	|
	|-RVA: 0x2AE905C Offset: 0x2AE505C VA: 0x2AE905C
	|-List<ByteEnum>.FindIndex
	|
	|-RVA: 0x2AEB698 Offset: 0x2AE7698 VA: 0x2AEB698
	|-List<char>.FindIndex
	|
	|-RVA: 0x2AEDD70 Offset: 0x2AE9D70 VA: 0x2AEDD70
	|-List<Color>.FindIndex
	|
	|-RVA: 0x2AF0418 Offset: 0x2AEC418 VA: 0x2AF0418
	|-List<Color32>.FindIndex
	|
	|-RVA: 0x2AF2A58 Offset: 0x2AEEA58 VA: 0x2AF2A58
	|-List<DateTime>.FindIndex
	|
	|-RVA: 0x2AF50C4 Offset: 0x2AF10C4 VA: 0x2AF50C4
	|-List<DateTimeOffset>.FindIndex
	|
	|-RVA: 0x2AF7784 Offset: 0x2AF3784 VA: 0x2AF7784
	|-List<Decimal>.FindIndex
	|
	|-RVA: 0x2AF9E38 Offset: 0x2AF5E38 VA: 0x2AF9E38
	|-List<DefencePoint2>.FindIndex
	|
	|-RVA: 0x2AFC484 Offset: 0x2AF8484 VA: 0x2AFC484
	|-List<double>.FindIndex
	|
	|-RVA: 0x2AFEB38 Offset: 0x2AFAB38 VA: 0x2AFEB38
	|-List<EventSummary>.FindIndex
	|
	|-RVA: 0x2B01234 Offset: 0x2AFD234 VA: 0x2B01234
	|-List<short>.FindIndex
	|
	|-RVA: 0x2B0386C Offset: 0x2AFF86C VA: 0x2B0386C
	|-List<Int16Enum>.FindIndex
	|
	|-RVA: 0x2B05EA4 Offset: 0x2B01EA4 VA: 0x2B05EA4
	|-List<int>.FindIndex
	|
	|-RVA: 0x2B084D8 Offset: 0x2B044D8 VA: 0x2B084D8
	|-List<Int32Enum>.FindIndex
	|
	|-RVA: 0x2B0AB0C Offset: 0x2B06B0C VA: 0x2B0AB0C
	|-List<long>.FindIndex
	|
	|-RVA: 0x2B0D1C4 Offset: 0x2B091C4 VA: 0x2B0D1C4
	|-List<InterpretedFrameInfo>.FindIndex
	|
	|-RVA: 0x2B0FB4C Offset: 0x2B0BB4C VA: 0x2B0FB4C
	|-List<JsonPosition>.FindIndex
	|
	|-RVA: 0x2B124D0 Offset: 0x2B0E4D0 VA: 0x2B124D0
	|-List<MaterialSearchData>.FindIndex
	|
	|-RVA: 0x2B14D64 Offset: 0x2B10D64 VA: 0x2B14D64
	|-List<MobActionTargetData>.FindIndex
	|
	|-RVA: 0x2B17878 Offset: 0x2B13878 VA: 0x2B17878
	|-List<MobIconLabelData>.FindIndex
	|
	|-RVA: 0x2B1A1CC Offset: 0x2B161CC VA: 0x2B1A1CC
	|-List<object>.FindIndex
	|
	|-RVA: 0x2B1CB1C Offset: 0x2B18B1C VA: 0x2B1CB1C
	|-List<PlayerLoopSystem>.FindIndex
	|
	|-RVA: 0x2B1F724 Offset: 0x2B1B724 VA: 0x2B1F724
	|-List<PlayerLoopSystemInternal>.FindIndex
	|
	|-RVA: 0x2B2211C Offset: 0x2B1E11C VA: 0x2B2211C
	|-List<RangePositionInfo>.FindIndex
	|
	|-RVA: 0x2B248A4 Offset: 0x2B208A4 VA: 0x2B248A4
	|-List<ReinforceCristaData>.FindIndex
	|
	|-RVA: 0x2B26F7C Offset: 0x2B22F7C VA: 0x2B26F7C
	|-List<sbyte>.FindIndex
	|
	|-RVA: 0x2B295CC Offset: 0x2B255CC VA: 0x2B295CC
	|-List<float>.FindIndex
	|
	|-RVA: 0x2B2BBFC Offset: 0x2B27BFC VA: 0x2B2BBFC
	|-List<SkillIdData>.FindIndex
	|
	|-RVA: 0x2B2E234 Offset: 0x2B2A234 VA: 0x2B2E234
	|-List<TimeSpan>.FindIndex
	|
	|-RVA: 0x2B54C4C Offset: 0x2B50C4C VA: 0x2B54C4C
	|-List<ushort>.FindIndex
	|
	|-RVA: 0x2B57284 Offset: 0x2B53284 VA: 0x2B57284
	|-List<uint>.FindIndex
	|
	|-RVA: 0x2B598B8 Offset: 0x2B558B8 VA: 0x2B598B8
	|-List<ulong>.FindIndex
	|
	|-RVA: 0x2B5BF2C Offset: 0x2B57F2C VA: 0x2B5BF2C
	|-List<Vector2>.FindIndex
	|
	|-RVA: 0x2B5E644 Offset: 0x2B5A644 VA: 0x2B5E644
	|-List<Vector3>.FindIndex
	|
	|-RVA: 0x2B60DA8 Offset: 0x2B5CDA8 VA: 0x2B60DA8
	|-List<X509ChainStatus>.FindIndex
	|
	|-RVA: 0x2B63D3C Offset: 0x2B5FD3C VA: 0x2B63D3C
	|-List<__Il2CppFullySharedGenericType>.FindIndex
	|
	|-RVA: 0x2B66F34 Offset: 0x2B62F34 VA: 0x2B66F34
	|-List<BeforeRenderHelper.OrderBlock>.FindIndex
	|
	|-RVA: 0x2B698A8 Offset: 0x2B658A8 VA: 0x2B698A8
	|-List<BoneClip.MotionKeyFrame>.FindIndex
	|
	|-RVA: 0x2B6C468 Offset: 0x2B68468 VA: 0x2B6C468
	|-List<HouseRecipeManager.RecipeData>.FindIndex
	|
	|-RVA: 0x2B6EDCC Offset: 0x2B6ADCC VA: 0x2B6EDCC
	|-List<KadarElexioBuf.SkillIdData>.FindIndex
	|
	|-RVA: 0x2B71490 Offset: 0x2B6D490 VA: 0x2B71490
	|-List<MissionTextManagerData.CheckIKeywordtemData>.FindIndex
	|
	|-RVA: 0x2B73BF4 Offset: 0x2B6FBF4 VA: 0x2B73BF4
	|-List<MissionTextManagerData.PickUpFieldData>.FindIndex
	|
	|-RVA: 0x2B76300 Offset: 0x2B72300 VA: 0x2B76300
	|-List<MobaRoomData.MobaAbilityMasterData>.FindIndex
	|
	|-RVA: 0x2B78AF8 Offset: 0x2B74AF8 VA: 0x2B78AF8
	|-List<NewWaveRoomData.Spotlight>.FindIndex
	|
	|-RVA: 0x2B7B3C8 Offset: 0x2B773C8 VA: 0x2B7B3C8
	|-List<NguiDynamicFontController.ApplyTextureInfo>.FindIndex
	|
	|-RVA: 0x2B7DACC Offset: 0x2B79ACC VA: 0x2B7DACC
	|-List<RegexCharClass.SingleRange>.FindIndex
	|
	|-RVA: 0x2B80190 Offset: 0x2B7C190 VA: 0x2B80190
	|-List<SocialAchievementData.LinkData>.FindIndex
	|
	|-RVA: 0x2B8288C Offset: 0x2B7E88C VA: 0x2B8288C
	|-List<TrophyManager.TrophyData>.FindIndex
	|
	|-RVA: 0x2B85154 Offset: 0x2B81154 VA: 0x2B85154
	|-List<UIEventMenuButton.MessageButtonData>.FindIndex
	|
	|-RVA: 0x2B87C3C Offset: 0x2B83C3C VA: 0x2B87C3C
	|-List<UIFieldMapPanel.PopData>.FindIndex
	|
	|-RVA: 0x2B8A488 Offset: 0x2B86488 VA: 0x2B8A488
	|-List<UIHouseAddressManager.Town>.FindIndex
	|
	|-RVA: 0x2B8CC54 Offset: 0x2B88C54 VA: 0x2B8CC54
	|-List<UIInfoWindow.LabelPosition>.FindIndex
	|
	|-RVA: 0x2B8F4A0 Offset: 0x2B8B4A0 VA: 0x2B8F4A0
	|-List<UIMainManager.DropItemData>.FindIndex
	|
	|-RVA: 0x2B91B5C Offset: 0x2B8DB5C VA: 0x2B91B5C
	|-List<UIScenarioOrderPanel.MissionData>.FindIndex
	|
	|-RVA: 0x2B944E4 Offset: 0x2B904E4 VA: 0x2B944E4
	|-List<UnitySynchronizationContext.WorkRequest>.FindIndex
	|
	|-RVA: 0x2B96EB8 Offset: 0x2B92EB8 VA: 0x2B96EB8
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.FindIndex
	|
	|-RVA: 0x2B996F4 Offset: 0x2B956F4 VA: 0x2B996F4
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.FindIndex
	|
	|-RVA: 0x2B9C028 Offset: 0x2B98028 VA: 0x2B9C028
	|-List<InstructionList.DebugView.InstructionView>.FindIndex
	*/

	// RVA: -1 Offset: -1
	public void ForEach(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADFC4 Offset: 0x2AA9FC4 VA: 0x2AADFC4
	|-List<KeyValuePair<ArchetypeUid, object>>.ForEach
	|
	|-RVA: 0x2AB06C0 Offset: 0x2AAC6C0 VA: 0x2AB06C0
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.ForEach
	|
	|-RVA: 0x2AB2D08 Offset: 0x2AAED08 VA: 0x2AB2D08
	|-List<KeyValuePair<byte, byte>>.ForEach
	|
	|-RVA: 0x2AB5750 Offset: 0x2AB1750 VA: 0x2AB5750
	|-List<KeyValuePair<byte, object>>.ForEach
	|
	|-RVA: 0x2AB7E44 Offset: 0x2AB3E44 VA: 0x2AB7E44
	|-List<KeyValuePair<int, short>>.ForEach
	|
	|-RVA: 0x2ABA47C Offset: 0x2AB647C VA: 0x2ABA47C
	|-List<KeyValuePair<int, int>>.ForEach
	|
	|-RVA: 0x2ABCB40 Offset: 0x2AB8B40 VA: 0x2ABCB40
	|-List<KeyValuePair<int, object>>.ForEach
	|
	|-RVA: 0x2ABF234 Offset: 0x2ABB234 VA: 0x2ABF234
	|-List<KeyValuePair<Int32Enum, byte>>.ForEach
	|
	|-RVA: 0x2AC1AF8 Offset: 0x2ABDAF8 VA: 0x2AC1AF8
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.ForEach
	|
	|-RVA: 0x2AC436C Offset: 0x2AC036C VA: 0x2AC436C
	|-List<KeyValuePair<Int32Enum, int>>.ForEach
	|
	|-RVA: 0x2AC6A30 Offset: 0x2AC2A30 VA: 0x2AC6A30
	|-List<KeyValuePair<Int32Enum, object>>.ForEach
	|
	|-RVA: 0x2AC91B0 Offset: 0x2AC51B0 VA: 0x2AC91B0
	|-List<KeyValuePair<object, int>>.ForEach
	|
	|-RVA: 0x2ACB930 Offset: 0x2AC7930 VA: 0x2ACB930
	|-List<KeyValuePair<object, float>>.ForEach
	|
	|-RVA: 0x2ACE0B0 Offset: 0x2ACA0B0 VA: 0x2ACE0B0
	|-List<KeyValuePair<float, object>>.ForEach
	|
	|-RVA: 0x2AD0998 Offset: 0x2ACC998 VA: 0x2AD0998
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.ForEach
	|
	|-RVA: 0x2AD325C Offset: 0x2ACF25C VA: 0x2AD325C
	|-List<StructMultiKey<object, object>>.ForEach
	|
	|-RVA: 0x2AD5958 Offset: 0x2AD1958 VA: 0x2AD5958
	|-List<ValueTuple<short, short>>.ForEach
	|
	|-RVA: 0x2AD7F98 Offset: 0x2AD3F98 VA: 0x2AD7F98
	|-List<ValueTuple<int, int>>.ForEach
	|
	|-RVA: 0x2ADA65C Offset: 0x2AD665C VA: 0x2ADA65C
	|-List<ValueTuple<int, object>>.ForEach
	|
	|-RVA: 0x2ADCD50 Offset: 0x2AD8D50 VA: 0x2ADCD50
	|-List<ValueTuple<Int32Enum, float>>.ForEach
	|
	|-RVA: 0x2ADF5F0 Offset: 0x2ADB5F0 VA: 0x2ADF5F0
	|-List<ValueTuple<Vector3, Vector3>>.ForEach
	|
	|-RVA: 0x2AE1E40 Offset: 0x2ADDE40 VA: 0x2AE1E40
	|-List<ArchetypeUid>.ForEach
	|
	|-RVA: 0x2AE44A8 Offset: 0x2AE04A8 VA: 0x2AE44A8
	|-List<bool>.ForEach
	|
	|-RVA: 0x2AE6AF0 Offset: 0x2AE2AF0 VA: 0x2AE6AF0
	|-List<byte>.ForEach
	|
	|-RVA: 0x2AE912C Offset: 0x2AE512C VA: 0x2AE912C
	|-List<ByteEnum>.ForEach
	|
	|-RVA: 0x2AEB768 Offset: 0x2AE7768 VA: 0x2AEB768
	|-List<char>.ForEach
	|
	|-RVA: 0x2AEDE4C Offset: 0x2AE9E4C VA: 0x2AEDE4C
	|-List<Color>.ForEach
	|
	|-RVA: 0x2AF04E8 Offset: 0x2AEC4E8 VA: 0x2AF04E8
	|-List<Color32>.ForEach
	|
	|-RVA: 0x2AF2B28 Offset: 0x2AEEB28 VA: 0x2AF2B28
	|-List<DateTime>.ForEach
	|
	|-RVA: 0x2AF519C Offset: 0x2AF119C VA: 0x2AF519C
	|-List<DateTimeOffset>.ForEach
	|
	|-RVA: 0x2AF785C Offset: 0x2AF385C VA: 0x2AF785C
	|-List<Decimal>.ForEach
	|
	|-RVA: 0x2AF9F08 Offset: 0x2AF5F08 VA: 0x2AF9F08
	|-List<DefencePoint2>.ForEach
	|
	|-RVA: 0x2AFC554 Offset: 0x2AF8554 VA: 0x2AFC554
	|-List<double>.ForEach
	|
	|-RVA: 0x2AFEC10 Offset: 0x2AFAC10 VA: 0x2AFEC10
	|-List<EventSummary>.ForEach
	|
	|-RVA: 0x2B01304 Offset: 0x2AFD304 VA: 0x2B01304
	|-List<short>.ForEach
	|
	|-RVA: 0x2B0393C Offset: 0x2AFF93C VA: 0x2B0393C
	|-List<Int16Enum>.ForEach
	|
	|-RVA: 0x2B05F74 Offset: 0x2B01F74 VA: 0x2B05F74
	|-List<int>.ForEach
	|
	|-RVA: 0x2B085A8 Offset: 0x2B045A8 VA: 0x2B085A8
	|-List<Int32Enum>.ForEach
	|
	|-RVA: 0x2B0ABDC Offset: 0x2B06BDC VA: 0x2B0ABDC
	|-List<long>.ForEach
	|
	|-RVA: 0x2B0D29C Offset: 0x2B0929C VA: 0x2B0D29C
	|-List<InterpretedFrameInfo>.ForEach
	|
	|-RVA: 0x2B0FC54 Offset: 0x2B0BC54 VA: 0x2B0FC54
	|-List<JsonPosition>.ForEach
	|
	|-RVA: 0x2B125A8 Offset: 0x2B0E5A8 VA: 0x2B125A8
	|-List<MaterialSearchData>.ForEach
	|
	|-RVA: 0x2B14E6C Offset: 0x2B10E6C VA: 0x2B14E6C
	|-List<MobActionTargetData>.ForEach
	|
	|-RVA: 0x2B17980 Offset: 0x2B13980 VA: 0x2B17980
	|-List<MobIconLabelData>.ForEach
	|
	|-RVA: 0x2B1A29C Offset: 0x2B1629C VA: 0x2B1A29C
	|-List<object>.ForEach
	|
	|-RVA: 0x2B1CC24 Offset: 0x2B18C24 VA: 0x2B1CC24
	|-List<PlayerLoopSystem>.ForEach
	|
	|-RVA: 0x2B1F82C Offset: 0x2B1B82C VA: 0x2B1F82C
	|-List<PlayerLoopSystemInternal>.ForEach
	|
	|-RVA: 0x2B221F4 Offset: 0x2B1E1F4 VA: 0x2B221F4
	|-List<RangePositionInfo>.ForEach
	|
	|-RVA: 0x2B24988 Offset: 0x2B20988 VA: 0x2B24988
	|-List<ReinforceCristaData>.ForEach
	|
	|-RVA: 0x2B2704C Offset: 0x2B2304C VA: 0x2B2704C
	|-List<sbyte>.ForEach
	|
	|-RVA: 0x2B2969C Offset: 0x2B2569C VA: 0x2B2969C
	|-List<float>.ForEach
	|
	|-RVA: 0x2B2BCCC Offset: 0x2B27CCC VA: 0x2B2BCCC
	|-List<SkillIdData>.ForEach
	|
	|-RVA: 0x2B2E304 Offset: 0x2B2A304 VA: 0x2B2E304
	|-List<TimeSpan>.ForEach
	|
	|-RVA: 0x2B54D1C Offset: 0x2B50D1C VA: 0x2B54D1C
	|-List<ushort>.ForEach
	|
	|-RVA: 0x2B57354 Offset: 0x2B53354 VA: 0x2B57354
	|-List<uint>.ForEach
	|
	|-RVA: 0x2B59988 Offset: 0x2B55988 VA: 0x2B59988
	|-List<ulong>.ForEach
	|
	|-RVA: 0x2B5C004 Offset: 0x2B58004 VA: 0x2B5C004
	|-List<Vector2>.ForEach
	|
	|-RVA: 0x2B5E728 Offset: 0x2B5A728 VA: 0x2B5E728
	|-List<Vector3>.ForEach
	|
	|-RVA: 0x2B60E80 Offset: 0x2B5CE80 VA: 0x2B60E80
	|-List<X509ChainStatus>.ForEach
	|
	|-RVA: 0x2B63EB8 Offset: 0x2B5FEB8 VA: 0x2B63EB8
	|-List<__Il2CppFullySharedGenericType>.ForEach
	|
	|-RVA: 0x2B6700C Offset: 0x2B6300C VA: 0x2B6700C
	|-List<BeforeRenderHelper.OrderBlock>.ForEach
	|
	|-RVA: 0x2B699B0 Offset: 0x2B659B0 VA: 0x2B699B0
	|-List<BoneClip.MotionKeyFrame>.ForEach
	|
	|-RVA: 0x2B6C570 Offset: 0x2B68570 VA: 0x2B6C570
	|-List<HouseRecipeManager.RecipeData>.ForEach
	|
	|-RVA: 0x2B6EE9C Offset: 0x2B6AE9C VA: 0x2B6EE9C
	|-List<KadarElexioBuf.SkillIdData>.ForEach
	|
	|-RVA: 0x2B71574 Offset: 0x2B6D574 VA: 0x2B71574
	|-List<MissionTextManagerData.CheckIKeywordtemData>.ForEach
	|
	|-RVA: 0x2B73CD8 Offset: 0x2B6FCD8 VA: 0x2B73CD8
	|-List<MissionTextManagerData.PickUpFieldData>.ForEach
	|
	|-RVA: 0x2B763D8 Offset: 0x2B723D8 VA: 0x2B763D8
	|-List<MobaRoomData.MobaAbilityMasterData>.ForEach
	|
	|-RVA: 0x2B78BEC Offset: 0x2B74BEC VA: 0x2B78BEC
	|-List<NewWaveRoomData.Spotlight>.ForEach
	|
	|-RVA: 0x2B7B4A0 Offset: 0x2B774A0 VA: 0x2B7B4A0
	|-List<NguiDynamicFontController.ApplyTextureInfo>.ForEach
	|
	|-RVA: 0x2B7DB9C Offset: 0x2B79B9C VA: 0x2B7DB9C
	|-List<RegexCharClass.SingleRange>.ForEach
	|
	|-RVA: 0x2B80268 Offset: 0x2B7C268 VA: 0x2B80268
	|-List<SocialAchievementData.LinkData>.ForEach
	|
	|-RVA: 0x2B8295C Offset: 0x2B7E95C VA: 0x2B8295C
	|-List<TrophyManager.TrophyData>.ForEach
	|
	|-RVA: 0x2B8525C Offset: 0x2B8125C VA: 0x2B8525C
	|-List<UIEventMenuButton.MessageButtonData>.ForEach
	|
	|-RVA: 0x2B87D30 Offset: 0x2B83D30 VA: 0x2B87D30
	|-List<UIFieldMapPanel.PopData>.ForEach
	|
	|-RVA: 0x2B8A558 Offset: 0x2B86558 VA: 0x2B8A558
	|-List<UIHouseAddressManager.Town>.ForEach
	|
	|-RVA: 0x2B8CD48 Offset: 0x2B88D48 VA: 0x2B8CD48
	|-List<UIInfoWindow.LabelPosition>.ForEach
	|
	|-RVA: 0x2B8F570 Offset: 0x2B8B570 VA: 0x2B8F570
	|-List<UIMainManager.DropItemData>.ForEach
	|
	|-RVA: 0x2B91C34 Offset: 0x2B8DC34 VA: 0x2B91C34
	|-List<UIScenarioOrderPanel.MissionData>.ForEach
	|
	|-RVA: 0x2B945EC Offset: 0x2B905EC VA: 0x2B945EC
	|-List<UnitySynchronizationContext.WorkRequest>.ForEach
	|
	|-RVA: 0x2B96F90 Offset: 0x2B92F90 VA: 0x2B96F90
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.ForEach
	|
	|-RVA: 0x2B997E8 Offset: 0x2B957E8 VA: 0x2B997E8
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.ForEach
	|
	|-RVA: 0x2B9C11C Offset: 0x2B9811C VA: 0x2B9C11C
	|-List<InstructionList.DebugView.InstructionView>.ForEach
	*/

	// RVA: -1 Offset: -1
	public List.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE084 Offset: 0x2AAA084 VA: 0x2AAE084
	|-List<KeyValuePair<ArchetypeUid, object>>.GetEnumerator
	|
	|-RVA: 0x2AB0778 Offset: 0x2AAC778 VA: 0x2AB0778
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.GetEnumerator
	|
	|-RVA: 0x2AB2DC0 Offset: 0x2AAEDC0 VA: 0x2AB2DC0
	|-List<KeyValuePair<byte, byte>>.GetEnumerator
	|
	|-RVA: 0x2AB5810 Offset: 0x2AB1810 VA: 0x2AB5810
	|-List<KeyValuePair<byte, object>>.GetEnumerator
	|
	|-RVA: 0x2AB7EFC Offset: 0x2AB3EFC VA: 0x2AB7EFC
	|-List<KeyValuePair<int, short>>.GetEnumerator
	|
	|-RVA: 0x2ABA534 Offset: 0x2AB6534 VA: 0x2ABA534
	|-List<KeyValuePair<int, int>>.GetEnumerator
	|
	|-RVA: 0x2ABCC00 Offset: 0x2AB8C00 VA: 0x2ABCC00
	|-List<KeyValuePair<int, object>>.GetEnumerator
	|
	|-RVA: 0x2ABF2EC Offset: 0x2ABB2EC VA: 0x2ABF2EC
	|-List<KeyValuePair<Int32Enum, byte>>.GetEnumerator
	|
	|-RVA: 0x2AC1BD4 Offset: 0x2ABDBD4 VA: 0x2AC1BD4
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.GetEnumerator
	|
	|-RVA: 0x2AC4424 Offset: 0x2AC0424 VA: 0x2AC4424
	|-List<KeyValuePair<Int32Enum, int>>.GetEnumerator
	|
	|-RVA: 0x2AC6AF0 Offset: 0x2AC2AF0 VA: 0x2AC6AF0
	|-List<KeyValuePair<Int32Enum, object>>.GetEnumerator
	|
	|-RVA: 0x2AC9270 Offset: 0x2AC5270 VA: 0x2AC9270
	|-List<KeyValuePair<object, int>>.GetEnumerator
	|
	|-RVA: 0x2ACB9F0 Offset: 0x2AC79F0 VA: 0x2ACB9F0
	|-List<KeyValuePair<object, float>>.GetEnumerator
	|
	|-RVA: 0x2ACE170 Offset: 0x2ACA170 VA: 0x2ACE170
	|-List<KeyValuePair<float, object>>.GetEnumerator
	|
	|-RVA: 0x2AD0A64 Offset: 0x2ACCA64 VA: 0x2AD0A64
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.GetEnumerator
	|
	|-RVA: 0x2AD331C Offset: 0x2ACF31C VA: 0x2AD331C
	|-List<StructMultiKey<object, object>>.GetEnumerator
	|
	|-RVA: 0x2AD5A10 Offset: 0x2AD1A10 VA: 0x2AD5A10
	|-List<ValueTuple<short, short>>.GetEnumerator
	|
	|-RVA: 0x2AD8050 Offset: 0x2AD4050 VA: 0x2AD8050
	|-List<ValueTuple<int, int>>.GetEnumerator
	|
	|-RVA: 0x2ADA71C Offset: 0x2AD671C VA: 0x2ADA71C
	|-List<ValueTuple<int, object>>.GetEnumerator
	|
	|-RVA: 0x2ADCE08 Offset: 0x2AD8E08 VA: 0x2ADCE08
	|-List<ValueTuple<Int32Enum, float>>.GetEnumerator
	|
	|-RVA: 0x2ADF6CC Offset: 0x2ADB6CC VA: 0x2ADF6CC
	|-List<ValueTuple<Vector3, Vector3>>.GetEnumerator
	|
	|-RVA: 0x2AE1EF8 Offset: 0x2ADDEF8 VA: 0x2AE1EF8
	|-List<ArchetypeUid>.GetEnumerator
	|
	|-RVA: 0x2AE4564 Offset: 0x2AE0564 VA: 0x2AE4564
	|-List<bool>.GetEnumerator
	|
	|-RVA: 0x2AE6BAC Offset: 0x2AE2BAC VA: 0x2AE6BAC
	|-List<byte>.GetEnumerator
	|
	|-RVA: 0x2AE91E8 Offset: 0x2AE51E8 VA: 0x2AE91E8
	|-List<ByteEnum>.GetEnumerator
	|
	|-RVA: 0x2AEB820 Offset: 0x2AE7820 VA: 0x2AEB820
	|-List<char>.GetEnumerator
	|
	|-RVA: 0x2AEDF10 Offset: 0x2AE9F10 VA: 0x2AEDF10
	|-List<Color>.GetEnumerator
	|
	|-RVA: 0x2AF05A0 Offset: 0x2AEC5A0 VA: 0x2AF05A0
	|-List<Color32>.GetEnumerator
	|
	|-RVA: 0x2AF2BE0 Offset: 0x2AEEBE0 VA: 0x2AF2BE0
	|-List<DateTime>.GetEnumerator
	|
	|-RVA: 0x2AF525C Offset: 0x2AF125C VA: 0x2AF525C
	|-List<DateTimeOffset>.GetEnumerator
	|
	|-RVA: 0x2AF791C Offset: 0x2AF391C VA: 0x2AF791C
	|-List<Decimal>.GetEnumerator
	|
	|-RVA: 0x2AF9FC0 Offset: 0x2AF5FC0 VA: 0x2AF9FC0
	|-List<DefencePoint2>.GetEnumerator
	|
	|-RVA: 0x2AFC60C Offset: 0x2AF860C VA: 0x2AFC60C
	|-List<double>.GetEnumerator
	|
	|-RVA: 0x2AFECD0 Offset: 0x2AFACD0 VA: 0x2AFECD0
	|-List<EventSummary>.GetEnumerator
	|
	|-RVA: 0x2B013BC Offset: 0x2AFD3BC VA: 0x2B013BC
	|-List<short>.GetEnumerator
	|
	|-RVA: 0x2B039F4 Offset: 0x2AFF9F4 VA: 0x2B039F4
	|-List<Int16Enum>.GetEnumerator
	|
	|-RVA: 0x2B0602C Offset: 0x2B0202C VA: 0x2B0602C
	|-List<int>.GetEnumerator
	|
	|-RVA: 0x2B08660 Offset: 0x2B04660 VA: 0x2B08660
	|-List<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2B0AC94 Offset: 0x2B06C94 VA: 0x2B0AC94
	|-List<long>.GetEnumerator
	|
	|-RVA: 0x2B0D35C Offset: 0x2B0935C VA: 0x2B0D35C
	|-List<InterpretedFrameInfo>.GetEnumerator
	|
	|-RVA: 0x2B0FD30 Offset: 0x2B0BD30 VA: 0x2B0FD30
	|-List<JsonPosition>.GetEnumerator
	|
	|-RVA: 0x2B12668 Offset: 0x2B0E668 VA: 0x2B12668
	|-List<MaterialSearchData>.GetEnumerator
	|
	|-RVA: 0x2B14F48 Offset: 0x2B10F48 VA: 0x2B14F48
	|-List<MobActionTargetData>.GetEnumerator
	|
	|-RVA: 0x2B17A5C Offset: 0x2B13A5C VA: 0x2B17A5C
	|-List<MobIconLabelData>.GetEnumerator
	|
	|-RVA: 0x2B1A354 Offset: 0x2B16354 VA: 0x2B1A354
	|-List<object>.GetEnumerator
	|
	|-RVA: 0x2B1CD00 Offset: 0x2B18D00 VA: 0x2B1CD00
	|-List<PlayerLoopSystem>.GetEnumerator
	|
	|-RVA: 0x2B1F908 Offset: 0x2B1B908 VA: 0x2B1F908
	|-List<PlayerLoopSystemInternal>.GetEnumerator
	|
	|-RVA: 0x2B222B4 Offset: 0x2B1E2B4 VA: 0x2B222B4
	|-List<RangePositionInfo>.GetEnumerator
	|
	|-RVA: 0x2B24A4C Offset: 0x2B20A4C VA: 0x2B24A4C
	|-List<ReinforceCristaData>.GetEnumerator
	|
	|-RVA: 0x2B27108 Offset: 0x2B23108 VA: 0x2B27108
	|-List<sbyte>.GetEnumerator
	|
	|-RVA: 0x2B29754 Offset: 0x2B25754 VA: 0x2B29754
	|-List<float>.GetEnumerator
	|
	|-RVA: 0x2B2BD84 Offset: 0x2B27D84 VA: 0x2B2BD84
	|-List<SkillIdData>.GetEnumerator
	|
	|-RVA: 0x2B2E3BC Offset: 0x2B2A3BC VA: 0x2B2E3BC
	|-List<TimeSpan>.GetEnumerator
	|
	|-RVA: 0x2B54DD4 Offset: 0x2B50DD4 VA: 0x2B54DD4
	|-List<ushort>.GetEnumerator
	|
	|-RVA: 0x2B5740C Offset: 0x2B5340C VA: 0x2B5740C
	|-List<uint>.GetEnumerator
	|
	|-RVA: 0x2B59A40 Offset: 0x2B55A40 VA: 0x2B59A40
	|-List<ulong>.GetEnumerator
	|
	|-RVA: 0x2B5C0C4 Offset: 0x2B580C4 VA: 0x2B5C0C4
	|-List<Vector2>.GetEnumerator
	|
	|-RVA: 0x2B5E7EC Offset: 0x2B5A7EC VA: 0x2B5E7EC
	|-List<Vector3>.GetEnumerator
	|
	|-RVA: 0x2B60F40 Offset: 0x2B5CF40 VA: 0x2B60F40
	|-List<X509ChainStatus>.GetEnumerator
	|
	|-RVA: 0x2B64008 Offset: 0x2B60008 VA: 0x2B64008
	|-List<__Il2CppFullySharedGenericType>.GetEnumerator
	|
	|-RVA: 0x2B670CC Offset: 0x2B630CC VA: 0x2B670CC
	|-List<BeforeRenderHelper.OrderBlock>.GetEnumerator
	|
	|-RVA: 0x2B69A8C Offset: 0x2B65A8C VA: 0x2B69A8C
	|-List<BoneClip.MotionKeyFrame>.GetEnumerator
	|
	|-RVA: 0x2B6C64C Offset: 0x2B6864C VA: 0x2B6C64C
	|-List<HouseRecipeManager.RecipeData>.GetEnumerator
	|
	|-RVA: 0x2B6EF54 Offset: 0x2B6AF54 VA: 0x2B6EF54
	|-List<KadarElexioBuf.SkillIdData>.GetEnumerator
	|
	|-RVA: 0x2B71638 Offset: 0x2B6D638 VA: 0x2B71638
	|-List<MissionTextManagerData.CheckIKeywordtemData>.GetEnumerator
	|
	|-RVA: 0x2B73D9C Offset: 0x2B6FD9C VA: 0x2B73D9C
	|-List<MissionTextManagerData.PickUpFieldData>.GetEnumerator
	|
	|-RVA: 0x2B76498 Offset: 0x2B72498 VA: 0x2B76498
	|-List<MobaRoomData.MobaAbilityMasterData>.GetEnumerator
	|
	|-RVA: 0x2B78CB8 Offset: 0x2B74CB8 VA: 0x2B78CB8
	|-List<NewWaveRoomData.Spotlight>.GetEnumerator
	|
	|-RVA: 0x2B7B560 Offset: 0x2B77560 VA: 0x2B7B560
	|-List<NguiDynamicFontController.ApplyTextureInfo>.GetEnumerator
	|
	|-RVA: 0x2B7DC54 Offset: 0x2B79C54 VA: 0x2B7DC54
	|-List<RegexCharClass.SingleRange>.GetEnumerator
	|
	|-RVA: 0x2B80328 Offset: 0x2B7C328 VA: 0x2B80328
	|-List<SocialAchievementData.LinkData>.GetEnumerator
	|
	|-RVA: 0x2B82A14 Offset: 0x2B7EA14 VA: 0x2B82A14
	|-List<TrophyManager.TrophyData>.GetEnumerator
	|
	|-RVA: 0x2B85338 Offset: 0x2B81338 VA: 0x2B85338
	|-List<UIEventMenuButton.MessageButtonData>.GetEnumerator
	|
	|-RVA: 0x2B87DFC Offset: 0x2B83DFC VA: 0x2B87DFC
	|-List<UIFieldMapPanel.PopData>.GetEnumerator
	|
	|-RVA: 0x2B8A610 Offset: 0x2B86610 VA: 0x2B8A610
	|-List<UIHouseAddressManager.Town>.GetEnumerator
	|
	|-RVA: 0x2B8CE14 Offset: 0x2B88E14 VA: 0x2B8CE14
	|-List<UIInfoWindow.LabelPosition>.GetEnumerator
	|
	|-RVA: 0x2B8F628 Offset: 0x2B8B628 VA: 0x2B8F628
	|-List<UIMainManager.DropItemData>.GetEnumerator
	|
	|-RVA: 0x2B91CF4 Offset: 0x2B8DCF4 VA: 0x2B91CF4
	|-List<UIScenarioOrderPanel.MissionData>.GetEnumerator
	|
	|-RVA: 0x2B946C8 Offset: 0x2B906C8 VA: 0x2B946C8
	|-List<UnitySynchronizationContext.WorkRequest>.GetEnumerator
	|
	|-RVA: 0x2B97050 Offset: 0x2B93050 VA: 0x2B97050
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.GetEnumerator
	|
	|-RVA: 0x2B998B4 Offset: 0x2B958B4 VA: 0x2B998B4
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.GetEnumerator
	|
	|-RVA: 0x2B9C1E8 Offset: 0x2B981E8 VA: 0x2B9C1E8
	|-List<InstructionList.DebugView.InstructionView>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE0A4 Offset: 0x2AAA0A4 VA: 0x2AAE0A4
	|-List<KeyValuePair<ArchetypeUid, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AB0798 Offset: 0x2AAC798 VA: 0x2AB0798
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AB2DE0 Offset: 0x2AAEDE0 VA: 0x2AB2DE0
	|-List<KeyValuePair<byte, byte>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AB5830 Offset: 0x2AB1830 VA: 0x2AB5830
	|-List<KeyValuePair<byte, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AB7F1C Offset: 0x2AB3F1C VA: 0x2AB7F1C
	|-List<KeyValuePair<int, short>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2ABA554 Offset: 0x2AB6554 VA: 0x2ABA554
	|-List<KeyValuePair<int, int>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2ABCC20 Offset: 0x2AB8C20 VA: 0x2ABCC20
	|-List<KeyValuePair<int, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2ABF30C Offset: 0x2ABB30C VA: 0x2ABF30C
	|-List<KeyValuePair<Int32Enum, byte>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AC1BF8 Offset: 0x2ABDBF8 VA: 0x2AC1BF8
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AC4444 Offset: 0x2AC0444 VA: 0x2AC4444
	|-List<KeyValuePair<Int32Enum, int>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AC6B10 Offset: 0x2AC2B10 VA: 0x2AC6B10
	|-List<KeyValuePair<Int32Enum, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AC9290 Offset: 0x2AC5290 VA: 0x2AC9290
	|-List<KeyValuePair<object, int>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2ACBA10 Offset: 0x2AC7A10 VA: 0x2ACBA10
	|-List<KeyValuePair<object, float>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2ACE190 Offset: 0x2ACA190 VA: 0x2ACE190
	|-List<KeyValuePair<float, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AD0A88 Offset: 0x2ACCA88 VA: 0x2AD0A88
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AD333C Offset: 0x2ACF33C VA: 0x2AD333C
	|-List<StructMultiKey<object, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AD5A30 Offset: 0x2AD1A30 VA: 0x2AD5A30
	|-List<ValueTuple<short, short>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AD8070 Offset: 0x2AD4070 VA: 0x2AD8070
	|-List<ValueTuple<int, int>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2ADA73C Offset: 0x2AD673C VA: 0x2ADA73C
	|-List<ValueTuple<int, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2ADCE28 Offset: 0x2AD8E28 VA: 0x2ADCE28
	|-List<ValueTuple<Int32Enum, float>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2ADF6F0 Offset: 0x2ADB6F0 VA: 0x2ADF6F0
	|-List<ValueTuple<Vector3, Vector3>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AE1F18 Offset: 0x2ADDF18 VA: 0x2AE1F18
	|-List<ArchetypeUid>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AE4584 Offset: 0x2AE0584 VA: 0x2AE4584
	|-List<bool>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AE6BCC Offset: 0x2AE2BCC VA: 0x2AE6BCC
	|-List<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AE9208 Offset: 0x2AE5208 VA: 0x2AE9208
	|-List<ByteEnum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AEB840 Offset: 0x2AE7840 VA: 0x2AEB840
	|-List<char>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AEDF30 Offset: 0x2AE9F30 VA: 0x2AEDF30
	|-List<Color>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AF05C0 Offset: 0x2AEC5C0 VA: 0x2AF05C0
	|-List<Color32>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AF2C00 Offset: 0x2AEEC00 VA: 0x2AF2C00
	|-List<DateTime>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AF527C Offset: 0x2AF127C VA: 0x2AF527C
	|-List<DateTimeOffset>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AF793C Offset: 0x2AF393C VA: 0x2AF793C
	|-List<Decimal>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AF9FE0 Offset: 0x2AF5FE0 VA: 0x2AF9FE0
	|-List<DefencePoint2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AFC62C Offset: 0x2AF862C VA: 0x2AFC62C
	|-List<double>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AFECF0 Offset: 0x2AFACF0 VA: 0x2AFECF0
	|-List<EventSummary>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B013DC Offset: 0x2AFD3DC VA: 0x2B013DC
	|-List<short>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B03A14 Offset: 0x2AFFA14 VA: 0x2B03A14
	|-List<Int16Enum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B0604C Offset: 0x2B0204C VA: 0x2B0604C
	|-List<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B08680 Offset: 0x2B04680 VA: 0x2B08680
	|-List<Int32Enum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B0ACB4 Offset: 0x2B06CB4 VA: 0x2B0ACB4
	|-List<long>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B0D37C Offset: 0x2B0937C VA: 0x2B0D37C
	|-List<InterpretedFrameInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B0FD54 Offset: 0x2B0BD54 VA: 0x2B0FD54
	|-List<JsonPosition>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B12688 Offset: 0x2B0E688 VA: 0x2B12688
	|-List<MaterialSearchData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B14F6C Offset: 0x2B10F6C VA: 0x2B14F6C
	|-List<MobActionTargetData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B17A80 Offset: 0x2B13A80 VA: 0x2B17A80
	|-List<MobIconLabelData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B1A374 Offset: 0x2B16374 VA: 0x2B1A374
	|-List<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B1CD28 Offset: 0x2B18D28 VA: 0x2B1CD28
	|-List<PlayerLoopSystem>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B1F930 Offset: 0x2B1B930 VA: 0x2B1F930
	|-List<PlayerLoopSystemInternal>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B222D4 Offset: 0x2B1E2D4 VA: 0x2B222D4
	|-List<RangePositionInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B24A6C Offset: 0x2B20A6C VA: 0x2B24A6C
	|-List<ReinforceCristaData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B27128 Offset: 0x2B23128 VA: 0x2B27128
	|-List<sbyte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B29774 Offset: 0x2B25774 VA: 0x2B29774
	|-List<float>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B2BDA4 Offset: 0x2B27DA4 VA: 0x2B2BDA4
	|-List<SkillIdData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B2E3DC Offset: 0x2B2A3DC VA: 0x2B2E3DC
	|-List<TimeSpan>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B54DF4 Offset: 0x2B50DF4 VA: 0x2B54DF4
	|-List<ushort>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B5742C Offset: 0x2B5342C VA: 0x2B5742C
	|-List<uint>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B59A60 Offset: 0x2B55A60 VA: 0x2B59A60
	|-List<ulong>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B5C0E4 Offset: 0x2B580E4 VA: 0x2B5C0E4
	|-List<Vector2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B5E80C Offset: 0x2B5A80C VA: 0x2B5E80C
	|-List<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B60F60 Offset: 0x2B5CF60 VA: 0x2B60F60
	|-List<X509ChainStatus>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B640B8 Offset: 0x2B600B8 VA: 0x2B640B8
	|-List<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B670EC Offset: 0x2B630EC VA: 0x2B670EC
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B69AB0 Offset: 0x2B65AB0 VA: 0x2B69AB0
	|-List<BoneClip.MotionKeyFrame>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B6C674 Offset: 0x2B68674 VA: 0x2B6C674
	|-List<HouseRecipeManager.RecipeData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B6EF74 Offset: 0x2B6AF74 VA: 0x2B6EF74
	|-List<KadarElexioBuf.SkillIdData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B71658 Offset: 0x2B6D658 VA: 0x2B71658
	|-List<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B73DBC Offset: 0x2B6FDBC VA: 0x2B73DBC
	|-List<MissionTextManagerData.PickUpFieldData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B764B8 Offset: 0x2B724B8 VA: 0x2B764B8
	|-List<MobaRoomData.MobaAbilityMasterData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B78CDC Offset: 0x2B74CDC VA: 0x2B78CDC
	|-List<NewWaveRoomData.Spotlight>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B7B580 Offset: 0x2B77580 VA: 0x2B7B580
	|-List<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B7DC74 Offset: 0x2B79C74 VA: 0x2B7DC74
	|-List<RegexCharClass.SingleRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B80348 Offset: 0x2B7C348 VA: 0x2B80348
	|-List<SocialAchievementData.LinkData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B82A34 Offset: 0x2B7EA34 VA: 0x2B82A34
	|-List<TrophyManager.TrophyData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B8535C Offset: 0x2B8135C VA: 0x2B8535C
	|-List<UIEventMenuButton.MessageButtonData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B87E20 Offset: 0x2B83E20 VA: 0x2B87E20
	|-List<UIFieldMapPanel.PopData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B8A630 Offset: 0x2B86630 VA: 0x2B8A630
	|-List<UIHouseAddressManager.Town>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B8CE38 Offset: 0x2B88E38 VA: 0x2B8CE38
	|-List<UIInfoWindow.LabelPosition>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B8F648 Offset: 0x2B8B648 VA: 0x2B8F648
	|-List<UIMainManager.DropItemData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B91D14 Offset: 0x2B8DD14 VA: 0x2B91D14
	|-List<UIScenarioOrderPanel.MissionData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B946EC Offset: 0x2B906EC VA: 0x2B946EC
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B97070 Offset: 0x2B93070 VA: 0x2B97070
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B998D8 Offset: 0x2B958D8 VA: 0x2B998D8
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2B9C20C Offset: 0x2B9820C VA: 0x2B9C20C
	|-List<InstructionList.DebugView.InstructionView>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE0F8 Offset: 0x2AAA0F8 VA: 0x2AAE0F8
	|-List<KeyValuePair<ArchetypeUid, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AB07F4 Offset: 0x2AAC7F4 VA: 0x2AB07F4
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AB2E3C Offset: 0x2AAEE3C VA: 0x2AB2E3C
	|-List<KeyValuePair<byte, byte>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AB5884 Offset: 0x2AB1884 VA: 0x2AB5884
	|-List<KeyValuePair<byte, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AB7F78 Offset: 0x2AB3F78 VA: 0x2AB7F78
	|-List<KeyValuePair<int, short>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2ABA5B0 Offset: 0x2AB65B0 VA: 0x2ABA5B0
	|-List<KeyValuePair<int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2ABCC74 Offset: 0x2AB8C74 VA: 0x2ABCC74
	|-List<KeyValuePair<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2ABF368 Offset: 0x2ABB368 VA: 0x2ABF368
	|-List<KeyValuePair<Int32Enum, byte>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AC1C58 Offset: 0x2ABDC58 VA: 0x2AC1C58
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AC44A0 Offset: 0x2AC04A0 VA: 0x2AC44A0
	|-List<KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AC6B64 Offset: 0x2AC2B64 VA: 0x2AC6B64
	|-List<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AC92E4 Offset: 0x2AC52E4 VA: 0x2AC92E4
	|-List<KeyValuePair<object, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2ACBA64 Offset: 0x2AC7A64 VA: 0x2ACBA64
	|-List<KeyValuePair<object, float>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2ACE1E4 Offset: 0x2ACA1E4 VA: 0x2ACE1E4
	|-List<KeyValuePair<float, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AD0AE8 Offset: 0x2ACCAE8 VA: 0x2AD0AE8
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AD3390 Offset: 0x2ACF390 VA: 0x2AD3390
	|-List<StructMultiKey<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AD5A8C Offset: 0x2AD1A8C VA: 0x2AD5A8C
	|-List<ValueTuple<short, short>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AD80CC Offset: 0x2AD40CC VA: 0x2AD80CC
	|-List<ValueTuple<int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2ADA790 Offset: 0x2AD6790 VA: 0x2ADA790
	|-List<ValueTuple<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2ADCE84 Offset: 0x2AD8E84 VA: 0x2ADCE84
	|-List<ValueTuple<Int32Enum, float>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2ADF750 Offset: 0x2ADB750 VA: 0x2ADF750
	|-List<ValueTuple<Vector3, Vector3>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AE1F74 Offset: 0x2ADDF74 VA: 0x2AE1F74
	|-List<ArchetypeUid>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AE45E0 Offset: 0x2AE05E0 VA: 0x2AE45E0
	|-List<bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AE6C28 Offset: 0x2AE2C28 VA: 0x2AE6C28
	|-List<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AE9264 Offset: 0x2AE5264 VA: 0x2AE9264
	|-List<ByteEnum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AEB89C Offset: 0x2AE789C VA: 0x2AEB89C
	|-List<char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AEDF84 Offset: 0x2AE9F84 VA: 0x2AEDF84
	|-List<Color>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AF061C Offset: 0x2AEC61C VA: 0x2AF061C
	|-List<Color32>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AF2C5C Offset: 0x2AEEC5C VA: 0x2AF2C5C
	|-List<DateTime>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AF52D0 Offset: 0x2AF12D0 VA: 0x2AF52D0
	|-List<DateTimeOffset>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AF79B8 Offset: 0x2AF39B8 VA: 0x2AF79B8
	|-List<Decimal>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AFA03C Offset: 0x2AF603C VA: 0x2AFA03C
	|-List<DefencePoint2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AFC688 Offset: 0x2AF8688 VA: 0x2AFC688
	|-List<double>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AFED44 Offset: 0x2AFAD44 VA: 0x2AFED44
	|-List<EventSummary>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B01438 Offset: 0x2AFD438 VA: 0x2B01438
	|-List<short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B03A70 Offset: 0x2AFFA70 VA: 0x2B03A70
	|-List<Int16Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B060A8 Offset: 0x2B020A8 VA: 0x2B060A8
	|-List<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B086DC Offset: 0x2B046DC VA: 0x2B086DC
	|-List<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B0AD10 Offset: 0x2B06D10 VA: 0x2B0AD10
	|-List<long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B0D3D0 Offset: 0x2B093D0 VA: 0x2B0D3D0
	|-List<InterpretedFrameInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B0FDB4 Offset: 0x2B0BDB4 VA: 0x2B0FDB4
	|-List<JsonPosition>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B126DC Offset: 0x2B0E6DC VA: 0x2B126DC
	|-List<MaterialSearchData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B14FCC Offset: 0x2B10FCC VA: 0x2B14FCC
	|-List<MobActionTargetData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B17AE0 Offset: 0x2B13AE0 VA: 0x2B17AE0
	|-List<MobIconLabelData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B1A3D0 Offset: 0x2B163D0 VA: 0x2B1A3D0
	|-List<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B1CD94 Offset: 0x2B18D94 VA: 0x2B1CD94
	|-List<PlayerLoopSystem>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B1F99C Offset: 0x2B1B99C VA: 0x2B1F99C
	|-List<PlayerLoopSystemInternal>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B22328 Offset: 0x2B1E328 VA: 0x2B22328
	|-List<RangePositionInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B24AC0 Offset: 0x2B20AC0 VA: 0x2B24AC0
	|-List<ReinforceCristaData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B27184 Offset: 0x2B23184 VA: 0x2B27184
	|-List<sbyte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B297D0 Offset: 0x2B257D0 VA: 0x2B297D0
	|-List<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B2BE00 Offset: 0x2B27E00 VA: 0x2B2BE00
	|-List<SkillIdData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B2E438 Offset: 0x2B2A438 VA: 0x2B2E438
	|-List<TimeSpan>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B54E50 Offset: 0x2B50E50 VA: 0x2B54E50
	|-List<ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B57488 Offset: 0x2B53488 VA: 0x2B57488
	|-List<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B59ABC Offset: 0x2B55ABC VA: 0x2B59ABC
	|-List<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B5C140 Offset: 0x2B58140 VA: 0x2B5C140
	|-List<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B5E860 Offset: 0x2B5A860 VA: 0x2B5E860
	|-List<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B60FB4 Offset: 0x2B5CFB4 VA: 0x2B60FB4
	|-List<X509ChainStatus>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B64168 Offset: 0x2B60168 VA: 0x2B64168
	|-List<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B67140 Offset: 0x2B63140 VA: 0x2B67140
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B69B10 Offset: 0x2B65B10 VA: 0x2B69B10
	|-List<BoneClip.MotionKeyFrame>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B6C6E0 Offset: 0x2B686E0 VA: 0x2B6C6E0
	|-List<HouseRecipeManager.RecipeData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B6EFD0 Offset: 0x2B6AFD0 VA: 0x2B6EFD0
	|-List<KadarElexioBuf.SkillIdData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B716AC Offset: 0x2B6D6AC VA: 0x2B716AC
	|-List<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B73E10 Offset: 0x2B6FE10 VA: 0x2B73E10
	|-List<MissionTextManagerData.PickUpFieldData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B7650C Offset: 0x2B7250C VA: 0x2B7650C
	|-List<MobaRoomData.MobaAbilityMasterData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B78D3C Offset: 0x2B74D3C VA: 0x2B78D3C
	|-List<NewWaveRoomData.Spotlight>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B7B5D4 Offset: 0x2B775D4 VA: 0x2B7B5D4
	|-List<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B7DCD0 Offset: 0x2B79CD0 VA: 0x2B7DCD0
	|-List<RegexCharClass.SingleRange>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B8039C Offset: 0x2B7C39C VA: 0x2B8039C
	|-List<SocialAchievementData.LinkData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B82A90 Offset: 0x2B7EA90 VA: 0x2B82A90
	|-List<TrophyManager.TrophyData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B853BC Offset: 0x2B813BC VA: 0x2B853BC
	|-List<UIEventMenuButton.MessageButtonData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B87E80 Offset: 0x2B83E80 VA: 0x2B87E80
	|-List<UIFieldMapPanel.PopData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B8A68C Offset: 0x2B8668C VA: 0x2B8A68C
	|-List<UIHouseAddressManager.Town>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B8CE98 Offset: 0x2B88E98 VA: 0x2B8CE98
	|-List<UIInfoWindow.LabelPosition>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B8F6A4 Offset: 0x2B8B6A4 VA: 0x2B8F6A4
	|-List<UIMainManager.DropItemData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B91D68 Offset: 0x2B8DD68 VA: 0x2B91D68
	|-List<UIScenarioOrderPanel.MissionData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B9474C Offset: 0x2B9074C VA: 0x2B9474C
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B970C4 Offset: 0x2B930C4 VA: 0x2B970C4
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B99938 Offset: 0x2B95938 VA: 0x2B99938
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B9C26C Offset: 0x2B9826C VA: 0x2B9C26C
	|-List<InstructionList.DebugView.InstructionView>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public List<T> GetRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE14C Offset: 0x2AAA14C VA: 0x2AAE14C
	|-List<KeyValuePair<ArchetypeUid, object>>.GetRange
	|
	|-RVA: 0x2AB0850 Offset: 0x2AAC850 VA: 0x2AB0850
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.GetRange
	|
	|-RVA: 0x2AB2E98 Offset: 0x2AAEE98 VA: 0x2AB2E98
	|-List<KeyValuePair<byte, byte>>.GetRange
	|
	|-RVA: 0x2AB58D8 Offset: 0x2AB18D8 VA: 0x2AB58D8
	|-List<KeyValuePair<byte, object>>.GetRange
	|
	|-RVA: 0x2AB7FD4 Offset: 0x2AB3FD4 VA: 0x2AB7FD4
	|-List<KeyValuePair<int, short>>.GetRange
	|
	|-RVA: 0x2ABA60C Offset: 0x2AB660C VA: 0x2ABA60C
	|-List<KeyValuePair<int, int>>.GetRange
	|
	|-RVA: 0x2ABCCC8 Offset: 0x2AB8CC8 VA: 0x2ABCCC8
	|-List<KeyValuePair<int, object>>.GetRange
	|
	|-RVA: 0x2ABF3C4 Offset: 0x2ABB3C4 VA: 0x2ABF3C4
	|-List<KeyValuePair<Int32Enum, byte>>.GetRange
	|
	|-RVA: 0x2AC1CB8 Offset: 0x2ABDCB8 VA: 0x2AC1CB8
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.GetRange
	|
	|-RVA: 0x2AC44FC Offset: 0x2AC04FC VA: 0x2AC44FC
	|-List<KeyValuePair<Int32Enum, int>>.GetRange
	|
	|-RVA: 0x2AC6BB8 Offset: 0x2AC2BB8 VA: 0x2AC6BB8
	|-List<KeyValuePair<Int32Enum, object>>.GetRange
	|
	|-RVA: 0x2AC9338 Offset: 0x2AC5338 VA: 0x2AC9338
	|-List<KeyValuePair<object, int>>.GetRange
	|
	|-RVA: 0x2ACBAB8 Offset: 0x2AC7AB8 VA: 0x2ACBAB8
	|-List<KeyValuePair<object, float>>.GetRange
	|
	|-RVA: 0x2ACE238 Offset: 0x2ACA238 VA: 0x2ACE238
	|-List<KeyValuePair<float, object>>.GetRange
	|
	|-RVA: 0x2AD0B48 Offset: 0x2ACCB48 VA: 0x2AD0B48
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.GetRange
	|
	|-RVA: 0x2AD33E4 Offset: 0x2ACF3E4 VA: 0x2AD33E4
	|-List<StructMultiKey<object, object>>.GetRange
	|
	|-RVA: 0x2AD5AE8 Offset: 0x2AD1AE8 VA: 0x2AD5AE8
	|-List<ValueTuple<short, short>>.GetRange
	|
	|-RVA: 0x2AD8128 Offset: 0x2AD4128 VA: 0x2AD8128
	|-List<ValueTuple<int, int>>.GetRange
	|
	|-RVA: 0x2ADA7E4 Offset: 0x2AD67E4 VA: 0x2ADA7E4
	|-List<ValueTuple<int, object>>.GetRange
	|
	|-RVA: 0x2ADCEE0 Offset: 0x2AD8EE0 VA: 0x2ADCEE0
	|-List<ValueTuple<Int32Enum, float>>.GetRange
	|
	|-RVA: 0x2ADF7B0 Offset: 0x2ADB7B0 VA: 0x2ADF7B0
	|-List<ValueTuple<Vector3, Vector3>>.GetRange
	|
	|-RVA: 0x2AE1FD0 Offset: 0x2ADDFD0 VA: 0x2AE1FD0
	|-List<ArchetypeUid>.GetRange
	|
	|-RVA: 0x2AE463C Offset: 0x2AE063C VA: 0x2AE463C
	|-List<bool>.GetRange
	|
	|-RVA: 0x2AE6C84 Offset: 0x2AE2C84 VA: 0x2AE6C84
	|-List<byte>.GetRange
	|
	|-RVA: 0x2AE92C0 Offset: 0x2AE52C0 VA: 0x2AE92C0
	|-List<ByteEnum>.GetRange
	|
	|-RVA: 0x2AEB8F8 Offset: 0x2AE78F8 VA: 0x2AEB8F8
	|-List<char>.GetRange
	|
	|-RVA: 0x2AEDFD8 Offset: 0x2AE9FD8 VA: 0x2AEDFD8
	|-List<Color>.GetRange
	|
	|-RVA: 0x2AF0678 Offset: 0x2AEC678 VA: 0x2AF0678
	|-List<Color32>.GetRange
	|
	|-RVA: 0x2AF2CB8 Offset: 0x2AEECB8 VA: 0x2AF2CB8
	|-List<DateTime>.GetRange
	|
	|-RVA: 0x2AF5324 Offset: 0x2AF1324 VA: 0x2AF5324
	|-List<DateTimeOffset>.GetRange
	|
	|-RVA: 0x2AF7A34 Offset: 0x2AF3A34 VA: 0x2AF7A34
	|-List<Decimal>.GetRange
	|
	|-RVA: 0x2AFA098 Offset: 0x2AF6098 VA: 0x2AFA098
	|-List<DefencePoint2>.GetRange
	|
	|-RVA: 0x2AFC6E4 Offset: 0x2AF86E4 VA: 0x2AFC6E4
	|-List<double>.GetRange
	|
	|-RVA: 0x2AFED98 Offset: 0x2AFAD98 VA: 0x2AFED98
	|-List<EventSummary>.GetRange
	|
	|-RVA: 0x2B01494 Offset: 0x2AFD494 VA: 0x2B01494
	|-List<short>.GetRange
	|
	|-RVA: 0x2B03ACC Offset: 0x2AFFACC VA: 0x2B03ACC
	|-List<Int16Enum>.GetRange
	|
	|-RVA: 0x2B06104 Offset: 0x2B02104 VA: 0x2B06104
	|-List<int>.GetRange
	|
	|-RVA: 0x2B08738 Offset: 0x2B04738 VA: 0x2B08738
	|-List<Int32Enum>.GetRange
	|
	|-RVA: 0x2B0AD6C Offset: 0x2B06D6C VA: 0x2B0AD6C
	|-List<long>.GetRange
	|
	|-RVA: 0x2B0D424 Offset: 0x2B09424 VA: 0x2B0D424
	|-List<InterpretedFrameInfo>.GetRange
	|
	|-RVA: 0x2B0FE14 Offset: 0x2B0BE14 VA: 0x2B0FE14
	|-List<JsonPosition>.GetRange
	|
	|-RVA: 0x2B12730 Offset: 0x2B0E730 VA: 0x2B12730
	|-List<MaterialSearchData>.GetRange
	|
	|-RVA: 0x2B1502C Offset: 0x2B1102C VA: 0x2B1502C
	|-List<MobActionTargetData>.GetRange
	|
	|-RVA: 0x2B17B40 Offset: 0x2B13B40 VA: 0x2B17B40
	|-List<MobIconLabelData>.GetRange
	|
	|-RVA: 0x2B1A42C Offset: 0x2B1642C VA: 0x2B1A42C
	|-List<object>.GetRange
	|
	|-RVA: 0x2B1CE00 Offset: 0x2B18E00 VA: 0x2B1CE00
	|-List<PlayerLoopSystem>.GetRange
	|
	|-RVA: 0x2B1FA08 Offset: 0x2B1BA08 VA: 0x2B1FA08
	|-List<PlayerLoopSystemInternal>.GetRange
	|
	|-RVA: 0x2B2237C Offset: 0x2B1E37C VA: 0x2B2237C
	|-List<RangePositionInfo>.GetRange
	|
	|-RVA: 0x2B24B14 Offset: 0x2B20B14 VA: 0x2B24B14
	|-List<ReinforceCristaData>.GetRange
	|
	|-RVA: 0x2B271E0 Offset: 0x2B231E0 VA: 0x2B271E0
	|-List<sbyte>.GetRange
	|
	|-RVA: 0x2B2982C Offset: 0x2B2582C VA: 0x2B2982C
	|-List<float>.GetRange
	|
	|-RVA: 0x2B2BE5C Offset: 0x2B27E5C VA: 0x2B2BE5C
	|-List<SkillIdData>.GetRange
	|
	|-RVA: 0x2B2E494 Offset: 0x2B2A494 VA: 0x2B2E494
	|-List<TimeSpan>.GetRange
	|
	|-RVA: 0x2B54EAC Offset: 0x2B50EAC VA: 0x2B54EAC
	|-List<ushort>.GetRange
	|
	|-RVA: 0x2B574E4 Offset: 0x2B534E4 VA: 0x2B574E4
	|-List<uint>.GetRange
	|
	|-RVA: 0x2B59B18 Offset: 0x2B55B18 VA: 0x2B59B18
	|-List<ulong>.GetRange
	|
	|-RVA: 0x2B5C19C Offset: 0x2B5819C VA: 0x2B5C19C
	|-List<Vector2>.GetRange
	|
	|-RVA: 0x2B5E8B4 Offset: 0x2B5A8B4 VA: 0x2B5E8B4
	|-List<Vector3>.GetRange
	|
	|-RVA: 0x2B61008 Offset: 0x2B5D008 VA: 0x2B61008
	|-List<X509ChainStatus>.GetRange
	|
	|-RVA: 0x2B64218 Offset: 0x2B60218 VA: 0x2B64218
	|-List<__Il2CppFullySharedGenericType>.GetRange
	|
	|-RVA: 0x2B67194 Offset: 0x2B63194 VA: 0x2B67194
	|-List<BeforeRenderHelper.OrderBlock>.GetRange
	|
	|-RVA: 0x2B69B70 Offset: 0x2B65B70 VA: 0x2B69B70
	|-List<BoneClip.MotionKeyFrame>.GetRange
	|
	|-RVA: 0x2B6C74C Offset: 0x2B6874C VA: 0x2B6C74C
	|-List<HouseRecipeManager.RecipeData>.GetRange
	|
	|-RVA: 0x2B6F02C Offset: 0x2B6B02C VA: 0x2B6F02C
	|-List<KadarElexioBuf.SkillIdData>.GetRange
	|
	|-RVA: 0x2B71700 Offset: 0x2B6D700 VA: 0x2B71700
	|-List<MissionTextManagerData.CheckIKeywordtemData>.GetRange
	|
	|-RVA: 0x2B73E64 Offset: 0x2B6FE64 VA: 0x2B73E64
	|-List<MissionTextManagerData.PickUpFieldData>.GetRange
	|
	|-RVA: 0x2B76560 Offset: 0x2B72560 VA: 0x2B76560
	|-List<MobaRoomData.MobaAbilityMasterData>.GetRange
	|
	|-RVA: 0x2B78D9C Offset: 0x2B74D9C VA: 0x2B78D9C
	|-List<NewWaveRoomData.Spotlight>.GetRange
	|
	|-RVA: 0x2B7B628 Offset: 0x2B77628 VA: 0x2B7B628
	|-List<NguiDynamicFontController.ApplyTextureInfo>.GetRange
	|
	|-RVA: 0x2B7DD2C Offset: 0x2B79D2C VA: 0x2B7DD2C
	|-List<RegexCharClass.SingleRange>.GetRange
	|
	|-RVA: 0x2B803F0 Offset: 0x2B7C3F0 VA: 0x2B803F0
	|-List<SocialAchievementData.LinkData>.GetRange
	|
	|-RVA: 0x2B82AEC Offset: 0x2B7EAEC VA: 0x2B82AEC
	|-List<TrophyManager.TrophyData>.GetRange
	|
	|-RVA: 0x2B8541C Offset: 0x2B8141C VA: 0x2B8541C
	|-List<UIEventMenuButton.MessageButtonData>.GetRange
	|
	|-RVA: 0x2B87EE0 Offset: 0x2B83EE0 VA: 0x2B87EE0
	|-List<UIFieldMapPanel.PopData>.GetRange
	|
	|-RVA: 0x2B8A6E8 Offset: 0x2B866E8 VA: 0x2B8A6E8
	|-List<UIHouseAddressManager.Town>.GetRange
	|
	|-RVA: 0x2B8CEF8 Offset: 0x2B88EF8 VA: 0x2B8CEF8
	|-List<UIInfoWindow.LabelPosition>.GetRange
	|
	|-RVA: 0x2B8F700 Offset: 0x2B8B700 VA: 0x2B8F700
	|-List<UIMainManager.DropItemData>.GetRange
	|
	|-RVA: 0x2B91DBC Offset: 0x2B8DDBC VA: 0x2B91DBC
	|-List<UIScenarioOrderPanel.MissionData>.GetRange
	|
	|-RVA: 0x2B947AC Offset: 0x2B907AC VA: 0x2B947AC
	|-List<UnitySynchronizationContext.WorkRequest>.GetRange
	|
	|-RVA: 0x2B97118 Offset: 0x2B93118 VA: 0x2B97118
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.GetRange
	|
	|-RVA: 0x2B99998 Offset: 0x2B95998 VA: 0x2B99998
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.GetRange
	|
	|-RVA: 0x2B9C2CC Offset: 0x2B982CC VA: 0x2B9C2CC
	|-List<InstructionList.DebugView.InstructionView>.GetRange
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE21C Offset: 0x2AAA21C VA: 0x2AAE21C
	|-List<KeyValuePair<ArchetypeUid, object>>.IndexOf
	|
	|-RVA: 0x2AB0920 Offset: 0x2AAC920 VA: 0x2AB0920
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.IndexOf
	|
	|-RVA: 0x2AB2F68 Offset: 0x2AAEF68 VA: 0x2AB2F68
	|-List<KeyValuePair<byte, byte>>.IndexOf
	|
	|-RVA: 0x2AB59A8 Offset: 0x2AB19A8 VA: 0x2AB59A8
	|-List<KeyValuePair<byte, object>>.IndexOf
	|
	|-RVA: 0x2AB80A4 Offset: 0x2AB40A4 VA: 0x2AB80A4
	|-List<KeyValuePair<int, short>>.IndexOf
	|
	|-RVA: 0x2ABA6DC Offset: 0x2AB66DC VA: 0x2ABA6DC
	|-List<KeyValuePair<int, int>>.IndexOf
	|
	|-RVA: 0x2ABCD98 Offset: 0x2AB8D98 VA: 0x2ABCD98
	|-List<KeyValuePair<int, object>>.IndexOf
	|
	|-RVA: 0x2ABF494 Offset: 0x2ABB494 VA: 0x2ABF494
	|-List<KeyValuePair<Int32Enum, byte>>.IndexOf
	|
	|-RVA: 0x2AC1D88 Offset: 0x2ABDD88 VA: 0x2AC1D88
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.IndexOf
	|
	|-RVA: 0x2AC45CC Offset: 0x2AC05CC VA: 0x2AC45CC
	|-List<KeyValuePair<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x2AC6C88 Offset: 0x2AC2C88 VA: 0x2AC6C88
	|-List<KeyValuePair<Int32Enum, object>>.IndexOf
	|
	|-RVA: 0x2AC9408 Offset: 0x2AC5408 VA: 0x2AC9408
	|-List<KeyValuePair<object, int>>.IndexOf
	|
	|-RVA: 0x2ACBB88 Offset: 0x2AC7B88 VA: 0x2ACBB88
	|-List<KeyValuePair<object, float>>.IndexOf
	|
	|-RVA: 0x2ACE308 Offset: 0x2ACA308 VA: 0x2ACE308
	|-List<KeyValuePair<float, object>>.IndexOf
	|
	|-RVA: 0x2AD0C18 Offset: 0x2ACCC18 VA: 0x2AD0C18
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.IndexOf
	|
	|-RVA: 0x2AD34B4 Offset: 0x2ACF4B4 VA: 0x2AD34B4
	|-List<StructMultiKey<object, object>>.IndexOf
	|
	|-RVA: 0x2AD5BB8 Offset: 0x2AD1BB8 VA: 0x2AD5BB8
	|-List<ValueTuple<short, short>>.IndexOf
	|
	|-RVA: 0x2AD81F8 Offset: 0x2AD41F8 VA: 0x2AD81F8
	|-List<ValueTuple<int, int>>.IndexOf
	|
	|-RVA: 0x2ADA8B4 Offset: 0x2AD68B4 VA: 0x2ADA8B4
	|-List<ValueTuple<int, object>>.IndexOf
	|
	|-RVA: 0x2ADCFB0 Offset: 0x2AD8FB0 VA: 0x2ADCFB0
	|-List<ValueTuple<Int32Enum, float>>.IndexOf
	|
	|-RVA: 0x2ADF880 Offset: 0x2ADB880 VA: 0x2ADF880
	|-List<ValueTuple<Vector3, Vector3>>.IndexOf
	|
	|-RVA: 0x2AE20A0 Offset: 0x2ADE0A0 VA: 0x2AE20A0
	|-List<ArchetypeUid>.IndexOf
	|
	|-RVA: 0x2AE470C Offset: 0x2AE070C VA: 0x2AE470C
	|-List<bool>.IndexOf
	|
	|-RVA: 0x2AE6D54 Offset: 0x2AE2D54 VA: 0x2AE6D54
	|-List<byte>.IndexOf
	|
	|-RVA: 0x2AE9390 Offset: 0x2AE5390 VA: 0x2AE9390
	|-List<ByteEnum>.IndexOf
	|
	|-RVA: 0x2AEB9C8 Offset: 0x2AE79C8 VA: 0x2AEB9C8
	|-List<char>.IndexOf
	|
	|-RVA: 0x2AEE0A8 Offset: 0x2AEA0A8 VA: 0x2AEE0A8
	|-List<Color>.IndexOf
	|
	|-RVA: 0x2AF0748 Offset: 0x2AEC748 VA: 0x2AF0748
	|-List<Color32>.IndexOf
	|
	|-RVA: 0x2AF2D88 Offset: 0x2AEED88 VA: 0x2AF2D88
	|-List<DateTime>.IndexOf
	|
	|-RVA: 0x2AF53F4 Offset: 0x2AF13F4 VA: 0x2AF53F4
	|-List<DateTimeOffset>.IndexOf
	|
	|-RVA: 0x2AF7B04 Offset: 0x2AF3B04 VA: 0x2AF7B04
	|-List<Decimal>.IndexOf
	|
	|-RVA: 0x2AFA168 Offset: 0x2AF6168 VA: 0x2AFA168
	|-List<DefencePoint2>.IndexOf
	|
	|-RVA: 0x2AFC7B4 Offset: 0x2AF87B4 VA: 0x2AFC7B4
	|-List<double>.IndexOf
	|
	|-RVA: 0x2AFEE68 Offset: 0x2AFAE68 VA: 0x2AFEE68
	|-List<EventSummary>.IndexOf
	|
	|-RVA: 0x2B01564 Offset: 0x2AFD564 VA: 0x2B01564
	|-List<short>.IndexOf
	|
	|-RVA: 0x2B03B9C Offset: 0x2AFFB9C VA: 0x2B03B9C
	|-List<Int16Enum>.IndexOf
	|
	|-RVA: 0x2B061D4 Offset: 0x2B021D4 VA: 0x2B061D4
	|-List<int>.IndexOf
	|
	|-RVA: 0x2B08808 Offset: 0x2B04808 VA: 0x2B08808
	|-List<Int32Enum>.IndexOf
	|
	|-RVA: 0x2B0AE3C Offset: 0x2B06E3C VA: 0x2B0AE3C
	|-List<long>.IndexOf
	|
	|-RVA: 0x2B0D4F4 Offset: 0x2B094F4 VA: 0x2B0D4F4
	|-List<InterpretedFrameInfo>.IndexOf
	|
	|-RVA: 0x2B0FEE4 Offset: 0x2B0BEE4 VA: 0x2B0FEE4
	|-List<JsonPosition>.IndexOf
	|
	|-RVA: 0x2B12800 Offset: 0x2B0E800 VA: 0x2B12800
	|-List<MaterialSearchData>.IndexOf
	|
	|-RVA: 0x2B150FC Offset: 0x2B110FC VA: 0x2B150FC
	|-List<MobActionTargetData>.IndexOf
	|
	|-RVA: 0x2B17C10 Offset: 0x2B13C10 VA: 0x2B17C10
	|-List<MobIconLabelData>.IndexOf
	|
	|-RVA: 0x2B1A4FC Offset: 0x2B164FC VA: 0x2B1A4FC
	|-List<object>.IndexOf
	|
	|-RVA: 0x2B1CED0 Offset: 0x2B18ED0 VA: 0x2B1CED0
	|-List<PlayerLoopSystem>.IndexOf
	|
	|-RVA: 0x2B1FAD8 Offset: 0x2B1BAD8 VA: 0x2B1FAD8
	|-List<PlayerLoopSystemInternal>.IndexOf
	|
	|-RVA: 0x2B2244C Offset: 0x2B1E44C VA: 0x2B2244C
	|-List<RangePositionInfo>.IndexOf
	|
	|-RVA: 0x2B24BE4 Offset: 0x2B20BE4 VA: 0x2B24BE4
	|-List<ReinforceCristaData>.IndexOf
	|
	|-RVA: 0x2B272B0 Offset: 0x2B232B0 VA: 0x2B272B0
	|-List<sbyte>.IndexOf
	|
	|-RVA: 0x2B298FC Offset: 0x2B258FC VA: 0x2B298FC
	|-List<float>.IndexOf
	|
	|-RVA: 0x2B2BF2C Offset: 0x2B27F2C VA: 0x2B2BF2C
	|-List<SkillIdData>.IndexOf
	|
	|-RVA: 0x2B2E564 Offset: 0x2B2A564 VA: 0x2B2E564
	|-List<TimeSpan>.IndexOf
	|
	|-RVA: 0x2B54F7C Offset: 0x2B50F7C VA: 0x2B54F7C
	|-List<ushort>.IndexOf
	|
	|-RVA: 0x2B575B4 Offset: 0x2B535B4 VA: 0x2B575B4
	|-List<uint>.IndexOf
	|
	|-RVA: 0x2B59BE8 Offset: 0x2B55BE8 VA: 0x2B59BE8
	|-List<ulong>.IndexOf
	|
	|-RVA: 0x2B5C26C Offset: 0x2B5826C VA: 0x2B5C26C
	|-List<Vector2>.IndexOf
	|
	|-RVA: 0x2B5E984 Offset: 0x2B5A984 VA: 0x2B5E984
	|-List<Vector3>.IndexOf
	|
	|-RVA: 0x2B610D8 Offset: 0x2B5D0D8 VA: 0x2B610D8
	|-List<X509ChainStatus>.IndexOf
	|
	|-RVA: 0x2B642EC Offset: 0x2B602EC VA: 0x2B642EC
	|-List<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x2B67264 Offset: 0x2B63264 VA: 0x2B67264
	|-List<BeforeRenderHelper.OrderBlock>.IndexOf
	|
	|-RVA: 0x2B69C40 Offset: 0x2B65C40 VA: 0x2B69C40
	|-List<BoneClip.MotionKeyFrame>.IndexOf
	|
	|-RVA: 0x2B6C81C Offset: 0x2B6881C VA: 0x2B6C81C
	|-List<HouseRecipeManager.RecipeData>.IndexOf
	|
	|-RVA: 0x2B6F0FC Offset: 0x2B6B0FC VA: 0x2B6F0FC
	|-List<KadarElexioBuf.SkillIdData>.IndexOf
	|
	|-RVA: 0x2B717D0 Offset: 0x2B6D7D0 VA: 0x2B717D0
	|-List<MissionTextManagerData.CheckIKeywordtemData>.IndexOf
	|
	|-RVA: 0x2B73F34 Offset: 0x2B6FF34 VA: 0x2B73F34
	|-List<MissionTextManagerData.PickUpFieldData>.IndexOf
	|
	|-RVA: 0x2B76630 Offset: 0x2B72630 VA: 0x2B76630
	|-List<MobaRoomData.MobaAbilityMasterData>.IndexOf
	|
	|-RVA: 0x2B78E6C Offset: 0x2B74E6C VA: 0x2B78E6C
	|-List<NewWaveRoomData.Spotlight>.IndexOf
	|
	|-RVA: 0x2B7B6F8 Offset: 0x2B776F8 VA: 0x2B7B6F8
	|-List<NguiDynamicFontController.ApplyTextureInfo>.IndexOf
	|
	|-RVA: 0x2B7DDFC Offset: 0x2B79DFC VA: 0x2B7DDFC
	|-List<RegexCharClass.SingleRange>.IndexOf
	|
	|-RVA: 0x2B804C0 Offset: 0x2B7C4C0 VA: 0x2B804C0
	|-List<SocialAchievementData.LinkData>.IndexOf
	|
	|-RVA: 0x2B82BBC Offset: 0x2B7EBBC VA: 0x2B82BBC
	|-List<TrophyManager.TrophyData>.IndexOf
	|
	|-RVA: 0x2B854EC Offset: 0x2B814EC VA: 0x2B854EC
	|-List<UIEventMenuButton.MessageButtonData>.IndexOf
	|
	|-RVA: 0x2B87FB0 Offset: 0x2B83FB0 VA: 0x2B87FB0
	|-List<UIFieldMapPanel.PopData>.IndexOf
	|
	|-RVA: 0x2B8A7B8 Offset: 0x2B867B8 VA: 0x2B8A7B8
	|-List<UIHouseAddressManager.Town>.IndexOf
	|
	|-RVA: 0x2B8CFC8 Offset: 0x2B88FC8 VA: 0x2B8CFC8
	|-List<UIInfoWindow.LabelPosition>.IndexOf
	|
	|-RVA: 0x2B8F7D0 Offset: 0x2B8B7D0 VA: 0x2B8F7D0
	|-List<UIMainManager.DropItemData>.IndexOf
	|
	|-RVA: 0x2B91E8C Offset: 0x2B8DE8C VA: 0x2B91E8C
	|-List<UIScenarioOrderPanel.MissionData>.IndexOf
	|
	|-RVA: 0x2B9487C Offset: 0x2B9087C VA: 0x2B9487C
	|-List<UnitySynchronizationContext.WorkRequest>.IndexOf
	|
	|-RVA: 0x2B971E8 Offset: 0x2B931E8 VA: 0x2B971E8
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IndexOf
	|
	|-RVA: 0x2B99A68 Offset: 0x2B95A68 VA: 0x2B99A68
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.IndexOf
	|
	|-RVA: 0x2B9C39C Offset: 0x2B9839C VA: 0x2B9C39C
	|-List<InstructionList.DebugView.InstructionView>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE23C Offset: 0x2AAA23C VA: 0x2AAE23C
	|-List<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AB0944 Offset: 0x2AAC944 VA: 0x2AB0944
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AB2F8C Offset: 0x2AAEF8C VA: 0x2AB2F8C
	|-List<KeyValuePair<byte, byte>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AB59C8 Offset: 0x2AB19C8 VA: 0x2AB59C8
	|-List<KeyValuePair<byte, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AB80C4 Offset: 0x2AB40C4 VA: 0x2AB80C4
	|-List<KeyValuePair<int, short>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2ABA6FC Offset: 0x2AB66FC VA: 0x2ABA6FC
	|-List<KeyValuePair<int, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2ABCDB8 Offset: 0x2AB8DB8 VA: 0x2ABCDB8
	|-List<KeyValuePair<int, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2ABF4B4 Offset: 0x2ABB4B4 VA: 0x2ABF4B4
	|-List<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AC1DE0 Offset: 0x2ABDDE0 VA: 0x2AC1DE0
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AC45EC Offset: 0x2AC05EC VA: 0x2AC45EC
	|-List<KeyValuePair<Int32Enum, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AC6CA8 Offset: 0x2AC2CA8 VA: 0x2AC6CA8
	|-List<KeyValuePair<Int32Enum, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AC9428 Offset: 0x2AC5428 VA: 0x2AC9428
	|-List<KeyValuePair<object, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2ACBBA8 Offset: 0x2AC7BA8 VA: 0x2ACBBA8
	|-List<KeyValuePair<object, float>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2ACE328 Offset: 0x2ACA328 VA: 0x2ACE328
	|-List<KeyValuePair<float, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AD0C5C Offset: 0x2ACCC5C VA: 0x2AD0C5C
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AD34D4 Offset: 0x2ACF4D4 VA: 0x2AD34D4
	|-List<StructMultiKey<object, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AD5BDC Offset: 0x2AD1BDC VA: 0x2AD5BDC
	|-List<ValueTuple<short, short>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AD8218 Offset: 0x2AD4218 VA: 0x2AD8218
	|-List<ValueTuple<int, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2ADA8D4 Offset: 0x2AD68D4 VA: 0x2ADA8D4
	|-List<ValueTuple<int, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2ADCFD0 Offset: 0x2AD8FD0 VA: 0x2ADCFD0
	|-List<ValueTuple<Int32Enum, float>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2ADF8D0 Offset: 0x2ADB8D0 VA: 0x2ADF8D0
	|-List<ValueTuple<Vector3, Vector3>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AE20C0 Offset: 0x2ADE0C0 VA: 0x2AE20C0
	|-List<ArchetypeUid>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AE4730 Offset: 0x2AE0730 VA: 0x2AE4730
	|-List<bool>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AE6D74 Offset: 0x2AE2D74 VA: 0x2AE6D74
	|-List<byte>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AE93B0 Offset: 0x2AE53B0 VA: 0x2AE93B0
	|-List<ByteEnum>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AEB9E8 Offset: 0x2AE79E8 VA: 0x2AEB9E8
	|-List<char>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AEE0C8 Offset: 0x2AEA0C8 VA: 0x2AEE0C8
	|-List<Color>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AF076C Offset: 0x2AEC76C VA: 0x2AF076C
	|-List<Color32>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AF2DA8 Offset: 0x2AEEDA8 VA: 0x2AF2DA8
	|-List<DateTime>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AF5414 Offset: 0x2AF1414 VA: 0x2AF5414
	|-List<DateTimeOffset>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AF7B24 Offset: 0x2AF3B24 VA: 0x2AF7B24
	|-List<Decimal>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AFA188 Offset: 0x2AF6188 VA: 0x2AFA188
	|-List<DefencePoint2>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AFC7D4 Offset: 0x2AF87D4 VA: 0x2AFC7D4
	|-List<double>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2AFEE88 Offset: 0x2AFAE88 VA: 0x2AFEE88
	|-List<EventSummary>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B01584 Offset: 0x2AFD584 VA: 0x2B01584
	|-List<short>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B03BBC Offset: 0x2AFFBBC VA: 0x2B03BBC
	|-List<Int16Enum>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B061F4 Offset: 0x2B021F4 VA: 0x2B061F4
	|-List<int>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B08828 Offset: 0x2B04828 VA: 0x2B08828
	|-List<Int32Enum>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B0AE5C Offset: 0x2B06E5C VA: 0x2B0AE5C
	|-List<long>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B0D514 Offset: 0x2B09514 VA: 0x2B0D514
	|-List<InterpretedFrameInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B0FF34 Offset: 0x2B0BF34 VA: 0x2B0FF34
	|-List<JsonPosition>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B12820 Offset: 0x2B0E820 VA: 0x2B12820
	|-List<MaterialSearchData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B1514C Offset: 0x2B1114C VA: 0x2B1514C
	|-List<MobActionTargetData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B17C60 Offset: 0x2B13C60 VA: 0x2B17C60
	|-List<MobIconLabelData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B1A51C Offset: 0x2B1651C VA: 0x2B1A51C
	|-List<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B1CF20 Offset: 0x2B18F20 VA: 0x2B1CF20
	|-List<PlayerLoopSystem>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B1FB28 Offset: 0x2B1BB28 VA: 0x2B1FB28
	|-List<PlayerLoopSystemInternal>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B2246C Offset: 0x2B1E46C VA: 0x2B2246C
	|-List<RangePositionInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B24C08 Offset: 0x2B20C08 VA: 0x2B24C08
	|-List<ReinforceCristaData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B272D0 Offset: 0x2B232D0 VA: 0x2B272D0
	|-List<sbyte>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B2991C Offset: 0x2B2591C VA: 0x2B2991C
	|-List<float>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B2BF4C Offset: 0x2B27F4C VA: 0x2B2BF4C
	|-List<SkillIdData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B2E584 Offset: 0x2B2A584 VA: 0x2B2E584
	|-List<TimeSpan>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B54F9C Offset: 0x2B50F9C VA: 0x2B54F9C
	|-List<ushort>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B575D4 Offset: 0x2B535D4 VA: 0x2B575D4
	|-List<uint>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B59C08 Offset: 0x2B55C08 VA: 0x2B59C08
	|-List<ulong>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B5C28C Offset: 0x2B5828C VA: 0x2B5C28C
	|-List<Vector2>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B5E9A4 Offset: 0x2B5A9A4 VA: 0x2B5E9A4
	|-List<Vector3>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B610F8 Offset: 0x2B5D0F8 VA: 0x2B610F8
	|-List<X509ChainStatus>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B643D0 Offset: 0x2B603D0 VA: 0x2B643D0
	|-List<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B67284 Offset: 0x2B63284 VA: 0x2B67284
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B69C90 Offset: 0x2B65C90 VA: 0x2B69C90
	|-List<BoneClip.MotionKeyFrame>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B6C86C Offset: 0x2B6886C VA: 0x2B6C86C
	|-List<HouseRecipeManager.RecipeData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B6F11C Offset: 0x2B6B11C VA: 0x2B6F11C
	|-List<KadarElexioBuf.SkillIdData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B717F4 Offset: 0x2B6D7F4 VA: 0x2B717F4
	|-List<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B73F58 Offset: 0x2B6FF58 VA: 0x2B73F58
	|-List<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B76650 Offset: 0x2B72650 VA: 0x2B76650
	|-List<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B78EB0 Offset: 0x2B74EB0 VA: 0x2B78EB0
	|-List<NewWaveRoomData.Spotlight>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B7B718 Offset: 0x2B77718 VA: 0x2B7B718
	|-List<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B7DE20 Offset: 0x2B79E20 VA: 0x2B7DE20
	|-List<RegexCharClass.SingleRange>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B804E0 Offset: 0x2B7C4E0 VA: 0x2B804E0
	|-List<SocialAchievementData.LinkData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B82BDC Offset: 0x2B7EBDC VA: 0x2B82BDC
	|-List<TrophyManager.TrophyData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B8553C Offset: 0x2B8153C VA: 0x2B8553C
	|-List<UIEventMenuButton.MessageButtonData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B87FF4 Offset: 0x2B83FF4 VA: 0x2B87FF4
	|-List<UIFieldMapPanel.PopData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B8A7D8 Offset: 0x2B867D8 VA: 0x2B8A7D8
	|-List<UIHouseAddressManager.Town>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B8D00C Offset: 0x2B8900C VA: 0x2B8D00C
	|-List<UIInfoWindow.LabelPosition>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B8F7F0 Offset: 0x2B8B7F0 VA: 0x2B8F7F0
	|-List<UIMainManager.DropItemData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B91EAC Offset: 0x2B8DEAC VA: 0x2B91EAC
	|-List<UIScenarioOrderPanel.MissionData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B948CC Offset: 0x2B908CC VA: 0x2B948CC
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B97208 Offset: 0x2B93208 VA: 0x2B97208
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B99AAC Offset: 0x2B95AAC VA: 0x2B99AAC
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2B9C3E0 Offset: 0x2B983E0 VA: 0x2B9C3E0
	|-List<InstructionList.DebugView.InstructionView>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE324 Offset: 0x2AAA324 VA: 0x2AAE324
	|-List<KeyValuePair<ArchetypeUid, object>>.Insert
	|
	|-RVA: 0x2AB0A2C Offset: 0x2AACA2C VA: 0x2AB0A2C
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.Insert
	|
	|-RVA: 0x2AB3074 Offset: 0x2AAF074 VA: 0x2AB3074
	|-List<KeyValuePair<byte, byte>>.Insert
	|
	|-RVA: 0x2AB5AB0 Offset: 0x2AB1AB0 VA: 0x2AB5AB0
	|-List<KeyValuePair<byte, object>>.Insert
	|
	|-RVA: 0x2AB81AC Offset: 0x2AB41AC VA: 0x2AB81AC
	|-List<KeyValuePair<int, short>>.Insert
	|
	|-RVA: 0x2ABA7E4 Offset: 0x2AB67E4 VA: 0x2ABA7E4
	|-List<KeyValuePair<int, int>>.Insert
	|
	|-RVA: 0x2ABCEA0 Offset: 0x2AB8EA0 VA: 0x2ABCEA0
	|-List<KeyValuePair<int, object>>.Insert
	|
	|-RVA: 0x2ABF59C Offset: 0x2ABB59C VA: 0x2ABF59C
	|-List<KeyValuePair<Int32Enum, byte>>.Insert
	|
	|-RVA: 0x2AC1EEC Offset: 0x2ABDEEC VA: 0x2AC1EEC
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.Insert
	|
	|-RVA: 0x2AC46D4 Offset: 0x2AC06D4 VA: 0x2AC46D4
	|-List<KeyValuePair<Int32Enum, int>>.Insert
	|
	|-RVA: 0x2AC6D90 Offset: 0x2AC2D90 VA: 0x2AC6D90
	|-List<KeyValuePair<Int32Enum, object>>.Insert
	|
	|-RVA: 0x2AC9510 Offset: 0x2AC5510 VA: 0x2AC9510
	|-List<KeyValuePair<object, int>>.Insert
	|
	|-RVA: 0x2ACBC90 Offset: 0x2AC7C90 VA: 0x2ACBC90
	|-List<KeyValuePair<object, float>>.Insert
	|
	|-RVA: 0x2ACE410 Offset: 0x2ACA410 VA: 0x2ACE410
	|-List<KeyValuePair<float, object>>.Insert
	|
	|-RVA: 0x2AD0D58 Offset: 0x2ACCD58 VA: 0x2AD0D58
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.Insert
	|
	|-RVA: 0x2AD35BC Offset: 0x2ACF5BC VA: 0x2AD35BC
	|-List<StructMultiKey<object, object>>.Insert
	|
	|-RVA: 0x2AD5CC4 Offset: 0x2AD1CC4 VA: 0x2AD5CC4
	|-List<ValueTuple<short, short>>.Insert
	|
	|-RVA: 0x2AD8300 Offset: 0x2AD4300 VA: 0x2AD8300
	|-List<ValueTuple<int, int>>.Insert
	|
	|-RVA: 0x2ADA9BC Offset: 0x2AD69BC VA: 0x2ADA9BC
	|-List<ValueTuple<int, object>>.Insert
	|
	|-RVA: 0x2ADD0B8 Offset: 0x2AD90B8 VA: 0x2ADD0B8
	|-List<ValueTuple<Int32Enum, float>>.Insert
	|
	|-RVA: 0x2ADF9DC Offset: 0x2ADB9DC VA: 0x2ADF9DC
	|-List<ValueTuple<Vector3, Vector3>>.Insert
	|
	|-RVA: 0x2AE21A8 Offset: 0x2ADE1A8 VA: 0x2AE21A8
	|-List<ArchetypeUid>.Insert
	|
	|-RVA: 0x2AE4818 Offset: 0x2AE0818 VA: 0x2AE4818
	|-List<bool>.Insert
	|
	|-RVA: 0x2AE6E60 Offset: 0x2AE2E60 VA: 0x2AE6E60
	|-List<byte>.Insert
	|
	|-RVA: 0x2AE949C Offset: 0x2AE549C VA: 0x2AE949C
	|-List<ByteEnum>.Insert
	|
	|-RVA: 0x2AEBAD4 Offset: 0x2AE7AD4 VA: 0x2AEBAD4
	|-List<char>.Insert
	|
	|-RVA: 0x2AEE1B4 Offset: 0x2AEA1B4 VA: 0x2AEE1B4
	|-List<Color>.Insert
	|
	|-RVA: 0x2AF0854 Offset: 0x2AEC854 VA: 0x2AF0854
	|-List<Color32>.Insert
	|
	|-RVA: 0x2AF2E90 Offset: 0x2AEEE90 VA: 0x2AF2E90
	|-List<DateTime>.Insert
	|
	|-RVA: 0x2AF54FC Offset: 0x2AF14FC VA: 0x2AF54FC
	|-List<DateTimeOffset>.Insert
	|
	|-RVA: 0x2AF7C0C Offset: 0x2AF3C0C VA: 0x2AF7C0C
	|-List<Decimal>.Insert
	|
	|-RVA: 0x2AFA270 Offset: 0x2AF6270 VA: 0x2AFA270
	|-List<DefencePoint2>.Insert
	|
	|-RVA: 0x2AFC8BC Offset: 0x2AF88BC VA: 0x2AFC8BC
	|-List<double>.Insert
	|
	|-RVA: 0x2AFEF70 Offset: 0x2AFAF70 VA: 0x2AFEF70
	|-List<EventSummary>.Insert
	|
	|-RVA: 0x2B01670 Offset: 0x2AFD670 VA: 0x2B01670
	|-List<short>.Insert
	|
	|-RVA: 0x2B03CA8 Offset: 0x2AFFCA8 VA: 0x2B03CA8
	|-List<Int16Enum>.Insert
	|
	|-RVA: 0x2B062DC Offset: 0x2B022DC VA: 0x2B062DC
	|-List<int>.Insert
	|
	|-RVA: 0x2B08910 Offset: 0x2B04910 VA: 0x2B08910
	|-List<Int32Enum>.Insert
	|
	|-RVA: 0x2B0AF44 Offset: 0x2B06F44 VA: 0x2B0AF44
	|-List<long>.Insert
	|
	|-RVA: 0x2B0D5FC Offset: 0x2B095FC VA: 0x2B0D5FC
	|-List<InterpretedFrameInfo>.Insert
	|
	|-RVA: 0x2B10040 Offset: 0x2B0C040 VA: 0x2B10040
	|-List<JsonPosition>.Insert
	|
	|-RVA: 0x2B12908 Offset: 0x2B0E908 VA: 0x2B12908
	|-List<MaterialSearchData>.Insert
	|
	|-RVA: 0x2B15258 Offset: 0x2B11258 VA: 0x2B15258
	|-List<MobActionTargetData>.Insert
	|
	|-RVA: 0x2B17D6C Offset: 0x2B13D6C VA: 0x2B17D6C
	|-List<MobIconLabelData>.Insert
	|
	|-RVA: 0x2B1A60C Offset: 0x2B1660C VA: 0x2B1A60C
	|-List<object>.Insert
	|
	|-RVA: 0x2B1D02C Offset: 0x2B1902C VA: 0x2B1D02C
	|-List<PlayerLoopSystem>.Insert
	|
	|-RVA: 0x2B1FC34 Offset: 0x2B1BC34 VA: 0x2B1FC34
	|-List<PlayerLoopSystemInternal>.Insert
	|
	|-RVA: 0x2B22554 Offset: 0x2B1E554 VA: 0x2B22554
	|-List<RangePositionInfo>.Insert
	|
	|-RVA: 0x2B24CF4 Offset: 0x2B20CF4 VA: 0x2B24CF4
	|-List<ReinforceCristaData>.Insert
	|
	|-RVA: 0x2B273BC Offset: 0x2B233BC VA: 0x2B273BC
	|-List<sbyte>.Insert
	|
	|-RVA: 0x2B29A04 Offset: 0x2B25A04 VA: 0x2B29A04
	|-List<float>.Insert
	|
	|-RVA: 0x2B2C034 Offset: 0x2B28034 VA: 0x2B2C034
	|-List<SkillIdData>.Insert
	|
	|-RVA: 0x2B2E66C Offset: 0x2B2A66C VA: 0x2B2E66C
	|-List<TimeSpan>.Insert
	|
	|-RVA: 0x2B55088 Offset: 0x2B51088 VA: 0x2B55088
	|-List<ushort>.Insert
	|
	|-RVA: 0x2B576BC Offset: 0x2B536BC VA: 0x2B576BC
	|-List<uint>.Insert
	|
	|-RVA: 0x2B59CF0 Offset: 0x2B55CF0 VA: 0x2B59CF0
	|-List<ulong>.Insert
	|
	|-RVA: 0x2B5C374 Offset: 0x2B58374 VA: 0x2B5C374
	|-List<Vector2>.Insert
	|
	|-RVA: 0x2B5EA90 Offset: 0x2B5AA90 VA: 0x2B5EA90
	|-List<Vector3>.Insert
	|
	|-RVA: 0x2B611E0 Offset: 0x2B5D1E0 VA: 0x2B611E0
	|-List<X509ChainStatus>.Insert
	|
	|-RVA: 0x2B644FC Offset: 0x2B604FC VA: 0x2B644FC
	|-List<__Il2CppFullySharedGenericType>.Insert
	|
	|-RVA: 0x2B6736C Offset: 0x2B6336C VA: 0x2B6736C
	|-List<BeforeRenderHelper.OrderBlock>.Insert
	|
	|-RVA: 0x2B69D9C Offset: 0x2B65D9C VA: 0x2B69D9C
	|-List<BoneClip.MotionKeyFrame>.Insert
	|
	|-RVA: 0x2B6C978 Offset: 0x2B68978 VA: 0x2B6C978
	|-List<HouseRecipeManager.RecipeData>.Insert
	|
	|-RVA: 0x2B6F204 Offset: 0x2B6B204 VA: 0x2B6F204
	|-List<KadarElexioBuf.SkillIdData>.Insert
	|
	|-RVA: 0x2B718E0 Offset: 0x2B6D8E0 VA: 0x2B718E0
	|-List<MissionTextManagerData.CheckIKeywordtemData>.Insert
	|
	|-RVA: 0x2B74044 Offset: 0x2B70044 VA: 0x2B74044
	|-List<MissionTextManagerData.PickUpFieldData>.Insert
	|
	|-RVA: 0x2B76738 Offset: 0x2B72738 VA: 0x2B76738
	|-List<MobaRoomData.MobaAbilityMasterData>.Insert
	|
	|-RVA: 0x2B78FAC Offset: 0x2B74FAC VA: 0x2B78FAC
	|-List<NewWaveRoomData.Spotlight>.Insert
	|
	|-RVA: 0x2B7B800 Offset: 0x2B77800 VA: 0x2B7B800
	|-List<NguiDynamicFontController.ApplyTextureInfo>.Insert
	|
	|-RVA: 0x2B7DF08 Offset: 0x2B79F08 VA: 0x2B7DF08
	|-List<RegexCharClass.SingleRange>.Insert
	|
	|-RVA: 0x2B805C8 Offset: 0x2B7C5C8 VA: 0x2B805C8
	|-List<SocialAchievementData.LinkData>.Insert
	|
	|-RVA: 0x2B82CC4 Offset: 0x2B7ECC4 VA: 0x2B82CC4
	|-List<TrophyManager.TrophyData>.Insert
	|
	|-RVA: 0x2B85648 Offset: 0x2B81648 VA: 0x2B85648
	|-List<UIEventMenuButton.MessageButtonData>.Insert
	|
	|-RVA: 0x2B880F0 Offset: 0x2B840F0 VA: 0x2B880F0
	|-List<UIFieldMapPanel.PopData>.Insert
	|
	|-RVA: 0x2B8A8C0 Offset: 0x2B868C0 VA: 0x2B8A8C0
	|-List<UIHouseAddressManager.Town>.Insert
	|
	|-RVA: 0x2B8D108 Offset: 0x2B89108 VA: 0x2B8D108
	|-List<UIInfoWindow.LabelPosition>.Insert
	|
	|-RVA: 0x2B8F8D8 Offset: 0x2B8B8D8 VA: 0x2B8F8D8
	|-List<UIMainManager.DropItemData>.Insert
	|
	|-RVA: 0x2B91F94 Offset: 0x2B8DF94 VA: 0x2B91F94
	|-List<UIScenarioOrderPanel.MissionData>.Insert
	|
	|-RVA: 0x2B949D8 Offset: 0x2B909D8 VA: 0x2B949D8
	|-List<UnitySynchronizationContext.WorkRequest>.Insert
	|
	|-RVA: 0x2B972F0 Offset: 0x2B932F0 VA: 0x2B972F0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Insert
	|
	|-RVA: 0x2B99BA8 Offset: 0x2B95BA8 VA: 0x2B99BA8
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.Insert
	|
	|-RVA: 0x2B9C4DC Offset: 0x2B984DC VA: 0x2B9C4DC
	|-List<InstructionList.DebugView.InstructionView>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE408 Offset: 0x2AAA408 VA: 0x2AAE408
	|-List<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AB0AFC Offset: 0x2AACAFC VA: 0x2AB0AFC
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AB3144 Offset: 0x2AAF144 VA: 0x2AB3144
	|-List<KeyValuePair<byte, byte>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AB5B94 Offset: 0x2AB1B94 VA: 0x2AB5B94
	|-List<KeyValuePair<byte, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AB827C Offset: 0x2AB427C VA: 0x2AB827C
	|-List<KeyValuePair<int, short>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2ABA8B4 Offset: 0x2AB68B4 VA: 0x2ABA8B4
	|-List<KeyValuePair<int, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2ABCF84 Offset: 0x2AB8F84 VA: 0x2ABCF84
	|-List<KeyValuePair<int, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2ABF66C Offset: 0x2ABB66C VA: 0x2ABF66C
	|-List<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AC1FF4 Offset: 0x2ABDFF4 VA: 0x2AC1FF4
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AC47A4 Offset: 0x2AC07A4 VA: 0x2AC47A4
	|-List<KeyValuePair<Int32Enum, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AC6E74 Offset: 0x2AC2E74 VA: 0x2AC6E74
	|-List<KeyValuePair<Int32Enum, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AC95F4 Offset: 0x2AC55F4 VA: 0x2AC95F4
	|-List<KeyValuePair<object, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2ACBD74 Offset: 0x2AC7D74 VA: 0x2ACBD74
	|-List<KeyValuePair<object, float>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2ACE4F4 Offset: 0x2ACA4F4 VA: 0x2ACE4F4
	|-List<KeyValuePair<float, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AD0E54 Offset: 0x2ACCE54 VA: 0x2AD0E54
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AD36A0 Offset: 0x2ACF6A0 VA: 0x2AD36A0
	|-List<StructMultiKey<object, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AD5D94 Offset: 0x2AD1D94 VA: 0x2AD5D94
	|-List<ValueTuple<short, short>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AD83D0 Offset: 0x2AD43D0 VA: 0x2AD83D0
	|-List<ValueTuple<int, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2ADAAA0 Offset: 0x2AD6AA0 VA: 0x2ADAAA0
	|-List<ValueTuple<int, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2ADD188 Offset: 0x2AD9188 VA: 0x2ADD188
	|-List<ValueTuple<Int32Enum, float>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2ADFAE4 Offset: 0x2ADBAE4 VA: 0x2ADFAE4
	|-List<ValueTuple<Vector3, Vector3>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AE2278 Offset: 0x2ADE278 VA: 0x2AE2278
	|-List<ArchetypeUid>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AE48EC Offset: 0x2AE08EC VA: 0x2AE48EC
	|-List<bool>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AE6F30 Offset: 0x2AE2F30 VA: 0x2AE6F30
	|-List<byte>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AE956C Offset: 0x2AE556C VA: 0x2AE956C
	|-List<ByteEnum>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AEBBA4 Offset: 0x2AE7BA4 VA: 0x2AEBBA4
	|-List<char>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AEE2A0 Offset: 0x2AEA2A0 VA: 0x2AEE2A0
	|-List<Color>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AF0924 Offset: 0x2AEC924 VA: 0x2AF0924
	|-List<Color32>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AF2F60 Offset: 0x2AEEF60 VA: 0x2AF2F60
	|-List<DateTime>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AF55D4 Offset: 0x2AF15D4 VA: 0x2AF55D4
	|-List<DateTimeOffset>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AF7CE4 Offset: 0x2AF3CE4 VA: 0x2AF7CE4
	|-List<Decimal>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AFA340 Offset: 0x2AF6340 VA: 0x2AFA340
	|-List<DefencePoint2>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AFC98C Offset: 0x2AF898C VA: 0x2AFC98C
	|-List<double>.System.Collections.IList.Insert
	|
	|-RVA: 0x2AFF054 Offset: 0x2AFB054 VA: 0x2AFF054
	|-List<EventSummary>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B01740 Offset: 0x2AFD740 VA: 0x2B01740
	|-List<short>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B03D78 Offset: 0x2AFFD78 VA: 0x2B03D78
	|-List<Int16Enum>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B063AC Offset: 0x2B023AC VA: 0x2B063AC
	|-List<int>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B089E0 Offset: 0x2B049E0 VA: 0x2B089E0
	|-List<Int32Enum>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B0B014 Offset: 0x2B07014 VA: 0x2B0B014
	|-List<long>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B0D6E0 Offset: 0x2B096E0 VA: 0x2B0D6E0
	|-List<InterpretedFrameInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B10158 Offset: 0x2B0C158 VA: 0x2B10158
	|-List<JsonPosition>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B129E0 Offset: 0x2B0E9E0 VA: 0x2B129E0
	|-List<MaterialSearchData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B15360 Offset: 0x2B11360 VA: 0x2B15360
	|-List<MobActionTargetData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B17E84 Offset: 0x2B13E84 VA: 0x2B17E84
	|-List<MobIconLabelData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B1A6E4 Offset: 0x2B166E4 VA: 0x2B1A6E4
	|-List<object>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B1D144 Offset: 0x2B19144 VA: 0x2B1D144
	|-List<PlayerLoopSystem>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B1FD4C Offset: 0x2B1BD4C VA: 0x2B1FD4C
	|-List<PlayerLoopSystemInternal>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B22638 Offset: 0x2B1E638 VA: 0x2B22638
	|-List<RangePositionInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B24DD4 Offset: 0x2B20DD4 VA: 0x2B24DD4
	|-List<ReinforceCristaData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B2748C Offset: 0x2B2348C VA: 0x2B2748C
	|-List<sbyte>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B29AD4 Offset: 0x2B25AD4 VA: 0x2B29AD4
	|-List<float>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B2C104 Offset: 0x2B28104 VA: 0x2B2C104
	|-List<SkillIdData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B2E73C Offset: 0x2B2A73C VA: 0x2B2E73C
	|-List<TimeSpan>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B55158 Offset: 0x2B51158 VA: 0x2B55158
	|-List<ushort>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B5778C Offset: 0x2B5378C VA: 0x2B5778C
	|-List<uint>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B59DC0 Offset: 0x2B55DC0 VA: 0x2B59DC0
	|-List<ulong>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B5C44C Offset: 0x2B5844C VA: 0x2B5C44C
	|-List<Vector2>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B5EB7C Offset: 0x2B5AB7C VA: 0x2B5EB7C
	|-List<Vector3>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B612C4 Offset: 0x2B5D2C4 VA: 0x2B612C4
	|-List<X509ChainStatus>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B646B8 Offset: 0x2B606B8 VA: 0x2B646B8
	|-List<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B67450 Offset: 0x2B63450 VA: 0x2B67450
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B69EB0 Offset: 0x2B65EB0 VA: 0x2B69EB0
	|-List<BoneClip.MotionKeyFrame>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B6CA8C Offset: 0x2B68A8C VA: 0x2B6CA8C
	|-List<HouseRecipeManager.RecipeData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B6F2D4 Offset: 0x2B6B2D4 VA: 0x2B6F2D4
	|-List<KadarElexioBuf.SkillIdData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B719C0 Offset: 0x2B6D9C0 VA: 0x2B719C0
	|-List<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B74124 Offset: 0x2B70124 VA: 0x2B74124
	|-List<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B76810 Offset: 0x2B72810 VA: 0x2B76810
	|-List<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B790A8 Offset: 0x2B750A8 VA: 0x2B790A8
	|-List<NewWaveRoomData.Spotlight>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B7B8E4 Offset: 0x2B778E4 VA: 0x2B7B8E4
	|-List<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B7DFD8 Offset: 0x2B79FD8 VA: 0x2B7DFD8
	|-List<RegexCharClass.SingleRange>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B806AC Offset: 0x2B7C6AC VA: 0x2B806AC
	|-List<SocialAchievementData.LinkData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B82D94 Offset: 0x2B7ED94 VA: 0x2B82D94
	|-List<TrophyManager.TrophyData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B85760 Offset: 0x2B81760 VA: 0x2B85760
	|-List<UIEventMenuButton.MessageButtonData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B881EC Offset: 0x2B841EC VA: 0x2B881EC
	|-List<UIFieldMapPanel.PopData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B8A990 Offset: 0x2B86990 VA: 0x2B8A990
	|-List<UIHouseAddressManager.Town>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B8D204 Offset: 0x2B89204 VA: 0x2B8D204
	|-List<UIInfoWindow.LabelPosition>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B8F9A8 Offset: 0x2B8B9A8 VA: 0x2B8F9A8
	|-List<UIMainManager.DropItemData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B92078 Offset: 0x2B8E078 VA: 0x2B92078
	|-List<UIScenarioOrderPanel.MissionData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B94AF0 Offset: 0x2B90AF0 VA: 0x2B94AF0
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B973D4 Offset: 0x2B933D4 VA: 0x2B973D4
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B99C98 Offset: 0x2B95C98 VA: 0x2B99C98
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2B9C5D8 Offset: 0x2B985D8 VA: 0x2B9C5D8
	|-List<InstructionList.DebugView.InstructionView>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1
	public void InsertRange(int index, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAE56C Offset: 0x2AAA56C VA: 0x2AAE56C
	|-List<KeyValuePair<ArchetypeUid, object>>.InsertRange
	|
	|-RVA: 0x2AB0C60 Offset: 0x2AACC60 VA: 0x2AB0C60
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.InsertRange
	|
	|-RVA: 0x2AB32A8 Offset: 0x2AAF2A8 VA: 0x2AB32A8
	|-List<KeyValuePair<byte, byte>>.InsertRange
	|
	|-RVA: 0x2AB5CF8 Offset: 0x2AB1CF8 VA: 0x2AB5CF8
	|-List<KeyValuePair<byte, object>>.InsertRange
	|
	|-RVA: 0x2AB83E0 Offset: 0x2AB43E0 VA: 0x2AB83E0
	|-List<KeyValuePair<int, short>>.InsertRange
	|
	|-RVA: 0x2ABAA18 Offset: 0x2AB6A18 VA: 0x2ABAA18
	|-List<KeyValuePair<int, int>>.InsertRange
	|
	|-RVA: 0x2ABD0E8 Offset: 0x2AB90E8 VA: 0x2ABD0E8
	|-List<KeyValuePair<int, object>>.InsertRange
	|
	|-RVA: 0x2ABF7D0 Offset: 0x2ABB7D0 VA: 0x2ABF7D0
	|-List<KeyValuePair<Int32Enum, byte>>.InsertRange
	|
	|-RVA: 0x2AC2184 Offset: 0x2ABE184 VA: 0x2AC2184
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.InsertRange
	|
	|-RVA: 0x2AC4908 Offset: 0x2AC0908 VA: 0x2AC4908
	|-List<KeyValuePair<Int32Enum, int>>.InsertRange
	|
	|-RVA: 0x2AC6FD8 Offset: 0x2AC2FD8 VA: 0x2AC6FD8
	|-List<KeyValuePair<Int32Enum, object>>.InsertRange
	|
	|-RVA: 0x2AC9758 Offset: 0x2AC5758 VA: 0x2AC9758
	|-List<KeyValuePair<object, int>>.InsertRange
	|
	|-RVA: 0x2ACBED8 Offset: 0x2AC7ED8 VA: 0x2ACBED8
	|-List<KeyValuePair<object, float>>.InsertRange
	|
	|-RVA: 0x2ACE658 Offset: 0x2ACA658 VA: 0x2ACE658
	|-List<KeyValuePair<float, object>>.InsertRange
	|
	|-RVA: 0x2AD0FE4 Offset: 0x2ACCFE4 VA: 0x2AD0FE4
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.InsertRange
	|
	|-RVA: 0x2AD3804 Offset: 0x2ACF804 VA: 0x2AD3804
	|-List<StructMultiKey<object, object>>.InsertRange
	|
	|-RVA: 0x2AD5EF8 Offset: 0x2AD1EF8 VA: 0x2AD5EF8
	|-List<ValueTuple<short, short>>.InsertRange
	|
	|-RVA: 0x2AD8534 Offset: 0x2AD4534 VA: 0x2AD8534
	|-List<ValueTuple<int, int>>.InsertRange
	|
	|-RVA: 0x2ADAC04 Offset: 0x2AD6C04 VA: 0x2ADAC04
	|-List<ValueTuple<int, object>>.InsertRange
	|
	|-RVA: 0x2ADD2EC Offset: 0x2AD92EC VA: 0x2ADD2EC
	|-List<ValueTuple<Int32Enum, float>>.InsertRange
	|
	|-RVA: 0x2ADFC6C Offset: 0x2ADBC6C VA: 0x2ADFC6C
	|-List<ValueTuple<Vector3, Vector3>>.InsertRange
	|
	|-RVA: 0x2AE23DC Offset: 0x2ADE3DC VA: 0x2AE23DC
	|-List<ArchetypeUid>.InsertRange
	|
	|-RVA: 0x2AE4A50 Offset: 0x2AE0A50 VA: 0x2AE4A50
	|-List<bool>.InsertRange
	|
	|-RVA: 0x2AE7094 Offset: 0x2AE3094 VA: 0x2AE7094
	|-List<byte>.InsertRange
	|
	|-RVA: 0x2AE96D0 Offset: 0x2AE56D0 VA: 0x2AE96D0
	|-List<ByteEnum>.InsertRange
	|
	|-RVA: 0x2AEBD08 Offset: 0x2AE7D08 VA: 0x2AEBD08
	|-List<char>.InsertRange
	|
	|-RVA: 0x2AEE408 Offset: 0x2AEA408 VA: 0x2AEE408
	|-List<Color>.InsertRange
	|
	|-RVA: 0x2AF0A88 Offset: 0x2AECA88 VA: 0x2AF0A88
	|-List<Color32>.InsertRange
	|
	|-RVA: 0x2AF30C4 Offset: 0x2AEF0C4 VA: 0x2AF30C4
	|-List<DateTime>.InsertRange
	|
	|-RVA: 0x2AF5738 Offset: 0x2AF1738 VA: 0x2AF5738
	|-List<DateTimeOffset>.InsertRange
	|
	|-RVA: 0x2AF7E48 Offset: 0x2AF3E48 VA: 0x2AF7E48
	|-List<Decimal>.InsertRange
	|
	|-RVA: 0x2AFA4A4 Offset: 0x2AF64A4 VA: 0x2AFA4A4
	|-List<DefencePoint2>.InsertRange
	|
	|-RVA: 0x2AFCAF0 Offset: 0x2AF8AF0 VA: 0x2AFCAF0
	|-List<double>.InsertRange
	|
	|-RVA: 0x2AFF1B8 Offset: 0x2AFB1B8 VA: 0x2AFF1B8
	|-List<EventSummary>.InsertRange
	|
	|-RVA: 0x2B018A4 Offset: 0x2AFD8A4 VA: 0x2B018A4
	|-List<short>.InsertRange
	|
	|-RVA: 0x2B03EDC Offset: 0x2AFFEDC VA: 0x2B03EDC
	|-List<Int16Enum>.InsertRange
	|
	|-RVA: 0x2B06510 Offset: 0x2B02510 VA: 0x2B06510
	|-List<int>.InsertRange
	|
	|-RVA: 0x2B08B44 Offset: 0x2B04B44 VA: 0x2B08B44
	|-List<Int32Enum>.InsertRange
	|
	|-RVA: 0x2B0B178 Offset: 0x2B07178 VA: 0x2B0B178
	|-List<long>.InsertRange
	|
	|-RVA: 0x2B0D844 Offset: 0x2B09844 VA: 0x2B0D844
	|-List<InterpretedFrameInfo>.InsertRange
	|
	|-RVA: 0x2B102E0 Offset: 0x2B0C2E0 VA: 0x2B102E0
	|-List<JsonPosition>.InsertRange
	|
	|-RVA: 0x2B12B44 Offset: 0x2B0EB44 VA: 0x2B12B44
	|-List<MaterialSearchData>.InsertRange
	|
	|-RVA: 0x2B154E8 Offset: 0x2B114E8 VA: 0x2B154E8
	|-List<MobActionTargetData>.InsertRange
	|
	|-RVA: 0x2B1800C Offset: 0x2B1400C VA: 0x2B1800C
	|-List<MobIconLabelData>.InsertRange
	|
	|-RVA: 0x2B1A840 Offset: 0x2B16840 VA: 0x2B1A840
	|-List<object>.InsertRange
	|
	|-RVA: 0x2B1D2CC Offset: 0x2B192CC VA: 0x2B1D2CC
	|-List<PlayerLoopSystem>.InsertRange
	|
	|-RVA: 0x2B1FED4 Offset: 0x2B1BED4 VA: 0x2B1FED4
	|-List<PlayerLoopSystemInternal>.InsertRange
	|
	|-RVA: 0x2B2279C Offset: 0x2B1E79C VA: 0x2B2279C
	|-List<RangePositionInfo>.InsertRange
	|
	|-RVA: 0x2B24F3C Offset: 0x2B20F3C VA: 0x2B24F3C
	|-List<ReinforceCristaData>.InsertRange
	|
	|-RVA: 0x2B275F0 Offset: 0x2B235F0 VA: 0x2B275F0
	|-List<sbyte>.InsertRange
	|
	|-RVA: 0x2B29C38 Offset: 0x2B25C38 VA: 0x2B29C38
	|-List<float>.InsertRange
	|
	|-RVA: 0x2B2C268 Offset: 0x2B28268 VA: 0x2B2C268
	|-List<SkillIdData>.InsertRange
	|
	|-RVA: 0x2B2E8A0 Offset: 0x2B2A8A0 VA: 0x2B2E8A0
	|-List<TimeSpan>.InsertRange
	|
	|-RVA: 0x2B552BC Offset: 0x2B512BC VA: 0x2B552BC
	|-List<ushort>.InsertRange
	|
	|-RVA: 0x2B578F0 Offset: 0x2B538F0 VA: 0x2B578F0
	|-List<uint>.InsertRange
	|
	|-RVA: 0x2B59F24 Offset: 0x2B55F24 VA: 0x2B59F24
	|-List<ulong>.InsertRange
	|
	|-RVA: 0x2B5C5B0 Offset: 0x2B585B0 VA: 0x2B5C5B0
	|-List<Vector2>.InsertRange
	|
	|-RVA: 0x2B5ECE4 Offset: 0x2B5ACE4 VA: 0x2B5ECE4
	|-List<Vector3>.InsertRange
	|
	|-RVA: 0x2B61428 Offset: 0x2B5D428 VA: 0x2B61428
	|-List<X509ChainStatus>.InsertRange
	|
	|-RVA: 0x2B6486C Offset: 0x2B6086C VA: 0x2B6486C
	|-List<__Il2CppFullySharedGenericType>.InsertRange
	|
	|-RVA: 0x2B675B4 Offset: 0x2B635B4 VA: 0x2B675B4
	|-List<BeforeRenderHelper.OrderBlock>.InsertRange
	|
	|-RVA: 0x2B6A038 Offset: 0x2B66038 VA: 0x2B6A038
	|-List<BoneClip.MotionKeyFrame>.InsertRange
	|
	|-RVA: 0x2B6CC14 Offset: 0x2B68C14 VA: 0x2B6CC14
	|-List<HouseRecipeManager.RecipeData>.InsertRange
	|
	|-RVA: 0x2B6F438 Offset: 0x2B6B438 VA: 0x2B6F438
	|-List<KadarElexioBuf.SkillIdData>.InsertRange
	|
	|-RVA: 0x2B71B28 Offset: 0x2B6DB28 VA: 0x2B71B28
	|-List<MissionTextManagerData.CheckIKeywordtemData>.InsertRange
	|
	|-RVA: 0x2B7428C Offset: 0x2B7028C VA: 0x2B7428C
	|-List<MissionTextManagerData.PickUpFieldData>.InsertRange
	|
	|-RVA: 0x2B76974 Offset: 0x2B72974 VA: 0x2B76974
	|-List<MobaRoomData.MobaAbilityMasterData>.InsertRange
	|
	|-RVA: 0x2B79224 Offset: 0x2B75224 VA: 0x2B79224
	|-List<NewWaveRoomData.Spotlight>.InsertRange
	|
	|-RVA: 0x2B7BA48 Offset: 0x2B77A48 VA: 0x2B7BA48
	|-List<NguiDynamicFontController.ApplyTextureInfo>.InsertRange
	|
	|-RVA: 0x2B7E13C Offset: 0x2B7A13C VA: 0x2B7E13C
	|-List<RegexCharClass.SingleRange>.InsertRange
	|
	|-RVA: 0x2B80810 Offset: 0x2B7C810 VA: 0x2B80810
	|-List<SocialAchievementData.LinkData>.InsertRange
	|
	|-RVA: 0x2B82EF8 Offset: 0x2B7EEF8 VA: 0x2B82EF8
	|-List<TrophyManager.TrophyData>.InsertRange
	|
	|-RVA: 0x2B858E8 Offset: 0x2B818E8 VA: 0x2B858E8
	|-List<UIEventMenuButton.MessageButtonData>.InsertRange
	|
	|-RVA: 0x2B88368 Offset: 0x2B84368 VA: 0x2B88368
	|-List<UIFieldMapPanel.PopData>.InsertRange
	|
	|-RVA: 0x2B8AAF4 Offset: 0x2B86AF4 VA: 0x2B8AAF4
	|-List<UIHouseAddressManager.Town>.InsertRange
	|
	|-RVA: 0x2B8D380 Offset: 0x2B89380 VA: 0x2B8D380
	|-List<UIInfoWindow.LabelPosition>.InsertRange
	|
	|-RVA: 0x2B8FB0C Offset: 0x2B8BB0C VA: 0x2B8FB0C
	|-List<UIMainManager.DropItemData>.InsertRange
	|
	|-RVA: 0x2B921DC Offset: 0x2B8E1DC VA: 0x2B921DC
	|-List<UIScenarioOrderPanel.MissionData>.InsertRange
	|
	|-RVA: 0x2B94C78 Offset: 0x2B90C78 VA: 0x2B94C78
	|-List<UnitySynchronizationContext.WorkRequest>.InsertRange
	|
	|-RVA: 0x2B97538 Offset: 0x2B93538 VA: 0x2B97538
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.InsertRange
	|
	|-RVA: 0x2B99E14 Offset: 0x2B95E14 VA: 0x2B99E14
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.InsertRange
	|
	|-RVA: 0x2B9C754 Offset: 0x2B98754 VA: 0x2B9C754
	|-List<InstructionList.DebugView.InstructionView>.InsertRange
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAEAB8 Offset: 0x2AAAAB8 VA: 0x2AAEAB8
	|-List<KeyValuePair<ArchetypeUid, object>>.Remove
	|
	|-RVA: 0x2AB11A8 Offset: 0x2AAD1A8 VA: 0x2AB11A8
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.Remove
	|
	|-RVA: 0x2AB37F0 Offset: 0x2AAF7F0 VA: 0x2AB37F0
	|-List<KeyValuePair<byte, byte>>.Remove
	|
	|-RVA: 0x2AB6244 Offset: 0x2AB2244 VA: 0x2AB6244
	|-List<KeyValuePair<byte, object>>.Remove
	|
	|-RVA: 0x2AB8928 Offset: 0x2AB4928 VA: 0x2AB8928
	|-List<KeyValuePair<int, short>>.Remove
	|
	|-RVA: 0x2ABAF60 Offset: 0x2AB6F60 VA: 0x2ABAF60
	|-List<KeyValuePair<int, int>>.Remove
	|
	|-RVA: 0x2ABD634 Offset: 0x2AB9634 VA: 0x2ABD634
	|-List<KeyValuePair<int, object>>.Remove
	|
	|-RVA: 0x2ABFD18 Offset: 0x2ABBD18 VA: 0x2ABFD18
	|-List<KeyValuePair<Int32Enum, byte>>.Remove
	|
	|-RVA: 0x2AC26F4 Offset: 0x2ABE6F4 VA: 0x2AC26F4
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.Remove
	|
	|-RVA: 0x2AC4E50 Offset: 0x2AC0E50 VA: 0x2AC4E50
	|-List<KeyValuePair<Int32Enum, int>>.Remove
	|
	|-RVA: 0x2AC7524 Offset: 0x2AC3524 VA: 0x2AC7524
	|-List<KeyValuePair<Int32Enum, object>>.Remove
	|
	|-RVA: 0x2AC9CA4 Offset: 0x2AC5CA4 VA: 0x2AC9CA4
	|-List<KeyValuePair<object, int>>.Remove
	|
	|-RVA: 0x2ACC424 Offset: 0x2AC8424 VA: 0x2ACC424
	|-List<KeyValuePair<object, float>>.Remove
	|
	|-RVA: 0x2ACEBA4 Offset: 0x2ACABA4 VA: 0x2ACEBA4
	|-List<KeyValuePair<float, object>>.Remove
	|
	|-RVA: 0x2AD1540 Offset: 0x2ACD540 VA: 0x2AD1540
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.Remove
	|
	|-RVA: 0x2AD3D50 Offset: 0x2ACFD50 VA: 0x2AD3D50
	|-List<StructMultiKey<object, object>>.Remove
	|
	|-RVA: 0x2AD6440 Offset: 0x2AD2440 VA: 0x2AD6440
	|-List<ValueTuple<short, short>>.Remove
	|
	|-RVA: 0x2AD8A7C Offset: 0x2AD4A7C VA: 0x2AD8A7C
	|-List<ValueTuple<int, int>>.Remove
	|
	|-RVA: 0x2ADB150 Offset: 0x2AD7150 VA: 0x2ADB150
	|-List<ValueTuple<int, object>>.Remove
	|
	|-RVA: 0x2ADD834 Offset: 0x2AD9834 VA: 0x2ADD834
	|-List<ValueTuple<Int32Enum, float>>.Remove
	|
	|-RVA: 0x2AE01D4 Offset: 0x2ADC1D4 VA: 0x2AE01D4
	|-List<ValueTuple<Vector3, Vector3>>.Remove
	|
	|-RVA: 0x2AE2924 Offset: 0x2ADE924 VA: 0x2AE2924
	|-List<ArchetypeUid>.Remove
	|
	|-RVA: 0x2AE4F94 Offset: 0x2AE0F94 VA: 0x2AE4F94
	|-List<bool>.Remove
	|
	|-RVA: 0x2AE75D8 Offset: 0x2AE35D8 VA: 0x2AE75D8
	|-List<byte>.Remove
	|
	|-RVA: 0x2AE9C14 Offset: 0x2AE5C14 VA: 0x2AE9C14
	|-List<ByteEnum>.Remove
	|
	|-RVA: 0x2AEC24C Offset: 0x2AE824C VA: 0x2AEC24C
	|-List<char>.Remove
	|
	|-RVA: 0x2AEE94C Offset: 0x2AEA94C VA: 0x2AEE94C
	|-List<Color>.Remove
	|
	|-RVA: 0x2AF0FD0 Offset: 0x2AECFD0 VA: 0x2AF0FD0
	|-List<Color32>.Remove
	|
	|-RVA: 0x2AF360C Offset: 0x2AEF60C VA: 0x2AF360C
	|-List<DateTime>.Remove
	|
	|-RVA: 0x2AF5C84 Offset: 0x2AF1C84 VA: 0x2AF5C84
	|-List<DateTimeOffset>.Remove
	|
	|-RVA: 0x2AF8394 Offset: 0x2AF4394 VA: 0x2AF8394
	|-List<Decimal>.Remove
	|
	|-RVA: 0x2AFA9EC Offset: 0x2AF69EC VA: 0x2AFA9EC
	|-List<DefencePoint2>.Remove
	|
	|-RVA: 0x2AFD030 Offset: 0x2AF9030 VA: 0x2AFD030
	|-List<double>.Remove
	|
	|-RVA: 0x2AFF704 Offset: 0x2AFB704 VA: 0x2AFF704
	|-List<EventSummary>.Remove
	|
	|-RVA: 0x2B01DE8 Offset: 0x2AFDDE8 VA: 0x2B01DE8
	|-List<short>.Remove
	|
	|-RVA: 0x2B04420 Offset: 0x2B00420 VA: 0x2B04420
	|-List<Int16Enum>.Remove
	|
	|-RVA: 0x2B06A54 Offset: 0x2B02A54 VA: 0x2B06A54
	|-List<int>.Remove
	|
	|-RVA: 0x2B09088 Offset: 0x2B05088 VA: 0x2B09088
	|-List<Int32Enum>.Remove
	|
	|-RVA: 0x2B0B6BC Offset: 0x2B076BC VA: 0x2B0B6BC
	|-List<long>.Remove
	|
	|-RVA: 0x2B0DD90 Offset: 0x2B09D90 VA: 0x2B0DD90
	|-List<InterpretedFrameInfo>.Remove
	|
	|-RVA: 0x2B10848 Offset: 0x2B0C848 VA: 0x2B10848
	|-List<JsonPosition>.Remove
	|
	|-RVA: 0x2B13090 Offset: 0x2B0F090 VA: 0x2B13090
	|-List<MaterialSearchData>.Remove
	|
	|-RVA: 0x2B15A50 Offset: 0x2B11A50 VA: 0x2B15A50
	|-List<MobActionTargetData>.Remove
	|
	|-RVA: 0x2B18574 Offset: 0x2B14574 VA: 0x2B18574
	|-List<MobIconLabelData>.Remove
	|
	|-RVA: 0x2B1AD84 Offset: 0x2B16D84 VA: 0x2B1AD84
	|-List<object>.Remove
	|
	|-RVA: 0x2B1D834 Offset: 0x2B19834 VA: 0x2B1D834
	|-List<PlayerLoopSystem>.Remove
	|
	|-RVA: 0x2B2043C Offset: 0x2B1C43C VA: 0x2B2043C
	|-List<PlayerLoopSystemInternal>.Remove
	|
	|-RVA: 0x2B22CE8 Offset: 0x2B1ECE8 VA: 0x2B22CE8
	|-List<RangePositionInfo>.Remove
	|
	|-RVA: 0x2B25488 Offset: 0x2B21488 VA: 0x2B25488
	|-List<ReinforceCristaData>.Remove
	|
	|-RVA: 0x2B27B34 Offset: 0x2B23B34 VA: 0x2B27B34
	|-List<sbyte>.Remove
	|
	|-RVA: 0x2B2A178 Offset: 0x2B26178 VA: 0x2B2A178
	|-List<float>.Remove
	|
	|-RVA: 0x2B2C7B0 Offset: 0x2B287B0 VA: 0x2B2C7B0
	|-List<SkillIdData>.Remove
	|
	|-RVA: 0x2B2EDE8 Offset: 0x2B2ADE8 VA: 0x2B2EDE8
	|-List<TimeSpan>.Remove
	|
	|-RVA: 0x2B55800 Offset: 0x2B51800 VA: 0x2B55800
	|-List<ushort>.Remove
	|
	|-RVA: 0x2B57E34 Offset: 0x2B53E34 VA: 0x2B57E34
	|-List<uint>.Remove
	|
	|-RVA: 0x2B5A468 Offset: 0x2B56468 VA: 0x2B5A468
	|-List<ulong>.Remove
	|
	|-RVA: 0x2B5CAF4 Offset: 0x2B58AF4 VA: 0x2B5CAF4
	|-List<Vector2>.Remove
	|
	|-RVA: 0x2B5F228 Offset: 0x2B5B228 VA: 0x2B5F228
	|-List<Vector3>.Remove
	|
	|-RVA: 0x2B61974 Offset: 0x2B5D974 VA: 0x2B61974
	|-List<X509ChainStatus>.Remove
	|
	|-RVA: 0x2B64E48 Offset: 0x2B60E48 VA: 0x2B64E48
	|-List<__Il2CppFullySharedGenericType>.Remove
	|
	|-RVA: 0x2B67B00 Offset: 0x2B63B00 VA: 0x2B67B00
	|-List<BeforeRenderHelper.OrderBlock>.Remove
	|
	|-RVA: 0x2B6A5A0 Offset: 0x2B665A0 VA: 0x2B6A5A0
	|-List<BoneClip.MotionKeyFrame>.Remove
	|
	|-RVA: 0x2B6D17C Offset: 0x2B6917C VA: 0x2B6D17C
	|-List<HouseRecipeManager.RecipeData>.Remove
	|
	|-RVA: 0x2B6F980 Offset: 0x2B6B980 VA: 0x2B6F980
	|-List<KadarElexioBuf.SkillIdData>.Remove
	|
	|-RVA: 0x2B72074 Offset: 0x2B6E074 VA: 0x2B72074
	|-List<MissionTextManagerData.CheckIKeywordtemData>.Remove
	|
	|-RVA: 0x2B747D8 Offset: 0x2B707D8 VA: 0x2B747D8
	|-List<MissionTextManagerData.PickUpFieldData>.Remove
	|
	|-RVA: 0x2B76EC0 Offset: 0x2B72EC0 VA: 0x2B76EC0
	|-List<MobaRoomData.MobaAbilityMasterData>.Remove
	|
	|-RVA: 0x2B79780 Offset: 0x2B75780 VA: 0x2B79780
	|-List<NewWaveRoomData.Spotlight>.Remove
	|
	|-RVA: 0x2B7BF94 Offset: 0x2B77F94 VA: 0x2B7BF94
	|-List<NguiDynamicFontController.ApplyTextureInfo>.Remove
	|
	|-RVA: 0x2B7E684 Offset: 0x2B7A684 VA: 0x2B7E684
	|-List<RegexCharClass.SingleRange>.Remove
	|
	|-RVA: 0x2B80D5C Offset: 0x2B7CD5C VA: 0x2B80D5C
	|-List<SocialAchievementData.LinkData>.Remove
	|
	|-RVA: 0x2B83440 Offset: 0x2B7F440 VA: 0x2B83440
	|-List<TrophyManager.TrophyData>.Remove
	|
	|-RVA: 0x2B85E4C Offset: 0x2B81E4C VA: 0x2B85E4C
	|-List<UIEventMenuButton.MessageButtonData>.Remove
	|
	|-RVA: 0x2B888C4 Offset: 0x2B848C4 VA: 0x2B888C4
	|-List<UIFieldMapPanel.PopData>.Remove
	|
	|-RVA: 0x2B8B03C Offset: 0x2B8703C VA: 0x2B8B03C
	|-List<UIHouseAddressManager.Town>.Remove
	|
	|-RVA: 0x2B8D8DC Offset: 0x2B898DC VA: 0x2B8D8DC
	|-List<UIInfoWindow.LabelPosition>.Remove
	|
	|-RVA: 0x2B90054 Offset: 0x2B8C054 VA: 0x2B90054
	|-List<UIMainManager.DropItemData>.Remove
	|
	|-RVA: 0x2B92728 Offset: 0x2B8E728 VA: 0x2B92728
	|-List<UIScenarioOrderPanel.MissionData>.Remove
	|
	|-RVA: 0x2B951E0 Offset: 0x2B911E0 VA: 0x2B951E0
	|-List<UnitySynchronizationContext.WorkRequest>.Remove
	|
	|-RVA: 0x2B97A84 Offset: 0x2B93A84 VA: 0x2B97A84
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Remove
	|
	|-RVA: 0x2B9A370 Offset: 0x2B96370 VA: 0x2B9A370
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.Remove
	|
	|-RVA: 0x2B9CCB0 Offset: 0x2B98CB0 VA: 0x2B9CCB0
	|-List<InstructionList.DebugView.InstructionView>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAEB14 Offset: 0x2AAAB14 VA: 0x2AAEB14
	|-List<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AB1208 Offset: 0x2AAD208 VA: 0x2AB1208
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AB3850 Offset: 0x2AAF850 VA: 0x2AB3850
	|-List<KeyValuePair<byte, byte>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AB62A0 Offset: 0x2AB22A0 VA: 0x2AB62A0
	|-List<KeyValuePair<byte, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AB8984 Offset: 0x2AB4984 VA: 0x2AB8984
	|-List<KeyValuePair<int, short>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2ABAFBC Offset: 0x2AB6FBC VA: 0x2ABAFBC
	|-List<KeyValuePair<int, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2ABD690 Offset: 0x2AB9690 VA: 0x2ABD690
	|-List<KeyValuePair<int, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2ABFD74 Offset: 0x2ABBD74 VA: 0x2ABFD74
	|-List<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AC277C Offset: 0x2ABE77C VA: 0x2AC277C
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AC4EAC Offset: 0x2AC0EAC VA: 0x2AC4EAC
	|-List<KeyValuePair<Int32Enum, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AC7580 Offset: 0x2AC3580 VA: 0x2AC7580
	|-List<KeyValuePair<Int32Enum, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AC9D00 Offset: 0x2AC5D00 VA: 0x2AC9D00
	|-List<KeyValuePair<object, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2ACC480 Offset: 0x2AC8480 VA: 0x2ACC480
	|-List<KeyValuePair<object, float>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2ACEC00 Offset: 0x2ACAC00 VA: 0x2ACEC00
	|-List<KeyValuePair<float, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AD15B4 Offset: 0x2ACD5B4 VA: 0x2AD15B4
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AD3DAC Offset: 0x2ACFDAC VA: 0x2AD3DAC
	|-List<StructMultiKey<object, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AD64A0 Offset: 0x2AD24A0 VA: 0x2AD64A0
	|-List<ValueTuple<short, short>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AD8AD8 Offset: 0x2AD4AD8 VA: 0x2AD8AD8
	|-List<ValueTuple<int, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2ADB1AC Offset: 0x2AD71AC VA: 0x2ADB1AC
	|-List<ValueTuple<int, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2ADD890 Offset: 0x2AD9890 VA: 0x2ADD890
	|-List<ValueTuple<Int32Enum, float>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AE0254 Offset: 0x2ADC254 VA: 0x2AE0254
	|-List<ValueTuple<Vector3, Vector3>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AE2980 Offset: 0x2ADE980 VA: 0x2AE2980
	|-List<ArchetypeUid>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AE4FF4 Offset: 0x2AE0FF4 VA: 0x2AE4FF4
	|-List<bool>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AE7634 Offset: 0x2AE3634 VA: 0x2AE7634
	|-List<byte>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AE9C70 Offset: 0x2AE5C70 VA: 0x2AE9C70
	|-List<ByteEnum>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AEC2A8 Offset: 0x2AE82A8 VA: 0x2AEC2A8
	|-List<char>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AEE9A8 Offset: 0x2AEA9A8 VA: 0x2AEE9A8
	|-List<Color>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AF1030 Offset: 0x2AED030 VA: 0x2AF1030
	|-List<Color32>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AF3668 Offset: 0x2AEF668 VA: 0x2AF3668
	|-List<DateTime>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AF5CE0 Offset: 0x2AF1CE0 VA: 0x2AF5CE0
	|-List<DateTimeOffset>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AF83F0 Offset: 0x2AF43F0 VA: 0x2AF83F0
	|-List<Decimal>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AFAA48 Offset: 0x2AF6A48 VA: 0x2AFAA48
	|-List<DefencePoint2>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AFD08C Offset: 0x2AF908C VA: 0x2AFD08C
	|-List<double>.System.Collections.IList.Remove
	|
	|-RVA: 0x2AFF760 Offset: 0x2AFB760 VA: 0x2AFF760
	|-List<EventSummary>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B01E44 Offset: 0x2AFDE44 VA: 0x2B01E44
	|-List<short>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B0447C Offset: 0x2B0047C VA: 0x2B0447C
	|-List<Int16Enum>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B06AB0 Offset: 0x2B02AB0 VA: 0x2B06AB0
	|-List<int>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B090E4 Offset: 0x2B050E4 VA: 0x2B090E4
	|-List<Int32Enum>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B0B718 Offset: 0x2B07718 VA: 0x2B0B718
	|-List<long>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B0DDEC Offset: 0x2B09DEC VA: 0x2B0DDEC
	|-List<InterpretedFrameInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B108C8 Offset: 0x2B0C8C8 VA: 0x2B108C8
	|-List<JsonPosition>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B130EC Offset: 0x2B0F0EC VA: 0x2B130EC
	|-List<MaterialSearchData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B15AD0 Offset: 0x2B11AD0 VA: 0x2B15AD0
	|-List<MobActionTargetData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B185F4 Offset: 0x2B145F4 VA: 0x2B185F4
	|-List<MobIconLabelData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B1ADE0 Offset: 0x2B16DE0 VA: 0x2B1ADE0
	|-List<object>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B1D8B4 Offset: 0x2B198B4 VA: 0x2B1D8B4
	|-List<PlayerLoopSystem>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B204BC Offset: 0x2B1C4BC VA: 0x2B204BC
	|-List<PlayerLoopSystemInternal>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B22D44 Offset: 0x2B1ED44 VA: 0x2B22D44
	|-List<RangePositionInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B254E8 Offset: 0x2B214E8 VA: 0x2B254E8
	|-List<ReinforceCristaData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B27B90 Offset: 0x2B23B90 VA: 0x2B27B90
	|-List<sbyte>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B2A1D4 Offset: 0x2B261D4 VA: 0x2B2A1D4
	|-List<float>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B2C80C Offset: 0x2B2880C VA: 0x2B2C80C
	|-List<SkillIdData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B2EE44 Offset: 0x2B2AE44 VA: 0x2B2EE44
	|-List<TimeSpan>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B5585C Offset: 0x2B5185C VA: 0x2B5585C
	|-List<ushort>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B57E90 Offset: 0x2B53E90 VA: 0x2B57E90
	|-List<uint>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B5A4C4 Offset: 0x2B564C4 VA: 0x2B5A4C4
	|-List<ulong>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B5CB50 Offset: 0x2B58B50 VA: 0x2B5CB50
	|-List<Vector2>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B5F284 Offset: 0x2B5B284 VA: 0x2B5F284
	|-List<Vector3>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B619D0 Offset: 0x2B5D9D0 VA: 0x2B619D0
	|-List<X509ChainStatus>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B64F40 Offset: 0x2B60F40 VA: 0x2B64F40
	|-List<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B67B5C Offset: 0x2B63B5C VA: 0x2B67B5C
	|-List<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B6A620 Offset: 0x2B66620 VA: 0x2B6A620
	|-List<BoneClip.MotionKeyFrame>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B6D1FC Offset: 0x2B691FC VA: 0x2B6D1FC
	|-List<HouseRecipeManager.RecipeData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B6F9DC Offset: 0x2B6B9DC VA: 0x2B6F9DC
	|-List<KadarElexioBuf.SkillIdData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B720D4 Offset: 0x2B6E0D4 VA: 0x2B720D4
	|-List<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B74838 Offset: 0x2B70838 VA: 0x2B74838
	|-List<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B76F1C Offset: 0x2B72F1C VA: 0x2B76F1C
	|-List<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B797F4 Offset: 0x2B757F4 VA: 0x2B797F4
	|-List<NewWaveRoomData.Spotlight>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B7BFF0 Offset: 0x2B77FF0 VA: 0x2B7BFF0
	|-List<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B7E6E4 Offset: 0x2B7A6E4 VA: 0x2B7E6E4
	|-List<RegexCharClass.SingleRange>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B80DB8 Offset: 0x2B7CDB8 VA: 0x2B80DB8
	|-List<SocialAchievementData.LinkData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B8349C Offset: 0x2B7F49C VA: 0x2B8349C
	|-List<TrophyManager.TrophyData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B85ECC Offset: 0x2B81ECC VA: 0x2B85ECC
	|-List<UIEventMenuButton.MessageButtonData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B88938 Offset: 0x2B84938 VA: 0x2B88938
	|-List<UIFieldMapPanel.PopData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B8B098 Offset: 0x2B87098 VA: 0x2B8B098
	|-List<UIHouseAddressManager.Town>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B8D950 Offset: 0x2B89950 VA: 0x2B8D950
	|-List<UIInfoWindow.LabelPosition>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B900B0 Offset: 0x2B8C0B0 VA: 0x2B900B0
	|-List<UIMainManager.DropItemData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B92784 Offset: 0x2B8E784 VA: 0x2B92784
	|-List<UIScenarioOrderPanel.MissionData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B95260 Offset: 0x2B91260 VA: 0x2B95260
	|-List<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B97AE0 Offset: 0x2B93AE0 VA: 0x2B97AE0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B9A3E4 Offset: 0x2B963E4 VA: 0x2B9A3E4
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2B9CD24 Offset: 0x2B98D24 VA: 0x2B9CD24
	|-List<InstructionList.DebugView.InstructionView>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1
	public int RemoveAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAEBE4 Offset: 0x2AAABE4 VA: 0x2AAEBE4
	|-List<KeyValuePair<ArchetypeUid, object>>.RemoveAll
	|
	|-RVA: 0x2AB12D8 Offset: 0x2AAD2D8 VA: 0x2AB12D8
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.RemoveAll
	|
	|-RVA: 0x2AB3920 Offset: 0x2AAF920 VA: 0x2AB3920
	|-List<KeyValuePair<byte, byte>>.RemoveAll
	|
	|-RVA: 0x2AB6370 Offset: 0x2AB2370 VA: 0x2AB6370
	|-List<KeyValuePair<byte, object>>.RemoveAll
	|
	|-RVA: 0x2AB8A54 Offset: 0x2AB4A54 VA: 0x2AB8A54
	|-List<KeyValuePair<int, short>>.RemoveAll
	|
	|-RVA: 0x2ABB08C Offset: 0x2AB708C VA: 0x2ABB08C
	|-List<KeyValuePair<int, int>>.RemoveAll
	|
	|-RVA: 0x2ABD760 Offset: 0x2AB9760 VA: 0x2ABD760
	|-List<KeyValuePair<int, object>>.RemoveAll
	|
	|-RVA: 0x2ABFE44 Offset: 0x2ABBE44 VA: 0x2ABFE44
	|-List<KeyValuePair<Int32Enum, byte>>.RemoveAll
	|
	|-RVA: 0x2AC286C Offset: 0x2ABE86C VA: 0x2AC286C
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.RemoveAll
	|
	|-RVA: 0x2AC4F7C Offset: 0x2AC0F7C VA: 0x2AC4F7C
	|-List<KeyValuePair<Int32Enum, int>>.RemoveAll
	|
	|-RVA: 0x2AC7650 Offset: 0x2AC3650 VA: 0x2AC7650
	|-List<KeyValuePair<Int32Enum, object>>.RemoveAll
	|
	|-RVA: 0x2AC9DD0 Offset: 0x2AC5DD0 VA: 0x2AC9DD0
	|-List<KeyValuePair<object, int>>.RemoveAll
	|
	|-RVA: 0x2ACC550 Offset: 0x2AC8550 VA: 0x2ACC550
	|-List<KeyValuePair<object, float>>.RemoveAll
	|
	|-RVA: 0x2ACECD0 Offset: 0x2ACACD0 VA: 0x2ACECD0
	|-List<KeyValuePair<float, object>>.RemoveAll
	|
	|-RVA: 0x2AD1690 Offset: 0x2ACD690 VA: 0x2AD1690
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.RemoveAll
	|
	|-RVA: 0x2AD3E7C Offset: 0x2ACFE7C VA: 0x2AD3E7C
	|-List<StructMultiKey<object, object>>.RemoveAll
	|
	|-RVA: 0x2AD6570 Offset: 0x2AD2570 VA: 0x2AD6570
	|-List<ValueTuple<short, short>>.RemoveAll
	|
	|-RVA: 0x2AD8BA8 Offset: 0x2AD4BA8 VA: 0x2AD8BA8
	|-List<ValueTuple<int, int>>.RemoveAll
	|
	|-RVA: 0x2ADB27C Offset: 0x2AD727C VA: 0x2ADB27C
	|-List<ValueTuple<int, object>>.RemoveAll
	|
	|-RVA: 0x2ADD960 Offset: 0x2AD9960 VA: 0x2ADD960
	|-List<ValueTuple<Int32Enum, float>>.RemoveAll
	|
	|-RVA: 0x2AE0344 Offset: 0x2ADC344 VA: 0x2AE0344
	|-List<ValueTuple<Vector3, Vector3>>.RemoveAll
	|
	|-RVA: 0x2AE2A50 Offset: 0x2ADEA50 VA: 0x2AE2A50
	|-List<ArchetypeUid>.RemoveAll
	|
	|-RVA: 0x2AE50C4 Offset: 0x2AE10C4 VA: 0x2AE50C4
	|-List<bool>.RemoveAll
	|
	|-RVA: 0x2AE7704 Offset: 0x2AE3704 VA: 0x2AE7704
	|-List<byte>.RemoveAll
	|
	|-RVA: 0x2AE9D40 Offset: 0x2AE5D40 VA: 0x2AE9D40
	|-List<ByteEnum>.RemoveAll
	|
	|-RVA: 0x2AEC378 Offset: 0x2AE8378 VA: 0x2AEC378
	|-List<char>.RemoveAll
	|
	|-RVA: 0x2AEEA7C Offset: 0x2AEAA7C VA: 0x2AEEA7C
	|-List<Color>.RemoveAll
	|
	|-RVA: 0x2AF1100 Offset: 0x2AED100 VA: 0x2AF1100
	|-List<Color32>.RemoveAll
	|
	|-RVA: 0x2AF3738 Offset: 0x2AEF738 VA: 0x2AF3738
	|-List<DateTime>.RemoveAll
	|
	|-RVA: 0x2AF5DB0 Offset: 0x2AF1DB0 VA: 0x2AF5DB0
	|-List<DateTimeOffset>.RemoveAll
	|
	|-RVA: 0x2AF84C0 Offset: 0x2AF44C0 VA: 0x2AF84C0
	|-List<Decimal>.RemoveAll
	|
	|-RVA: 0x2AFAB18 Offset: 0x2AF6B18 VA: 0x2AFAB18
	|-List<DefencePoint2>.RemoveAll
	|
	|-RVA: 0x2AFD15C Offset: 0x2AF915C VA: 0x2AFD15C
	|-List<double>.RemoveAll
	|
	|-RVA: 0x2AFF830 Offset: 0x2AFB830 VA: 0x2AFF830
	|-List<EventSummary>.RemoveAll
	|
	|-RVA: 0x2B01F14 Offset: 0x2AFDF14 VA: 0x2B01F14
	|-List<short>.RemoveAll
	|
	|-RVA: 0x2B0454C Offset: 0x2B0054C VA: 0x2B0454C
	|-List<Int16Enum>.RemoveAll
	|
	|-RVA: 0x2B06B80 Offset: 0x2B02B80 VA: 0x2B06B80
	|-List<int>.RemoveAll
	|
	|-RVA: 0x2B091B4 Offset: 0x2B051B4 VA: 0x2B091B4
	|-List<Int32Enum>.RemoveAll
	|
	|-RVA: 0x2B0B7E8 Offset: 0x2B077E8 VA: 0x2B0B7E8
	|-List<long>.RemoveAll
	|
	|-RVA: 0x2B0DEBC Offset: 0x2B09EBC VA: 0x2B0DEBC
	|-List<InterpretedFrameInfo>.RemoveAll
	|
	|-RVA: 0x2B109B8 Offset: 0x2B0C9B8 VA: 0x2B109B8
	|-List<JsonPosition>.RemoveAll
	|
	|-RVA: 0x2B131BC Offset: 0x2B0F1BC VA: 0x2B131BC
	|-List<MaterialSearchData>.RemoveAll
	|
	|-RVA: 0x2B15BC0 Offset: 0x2B11BC0 VA: 0x2B15BC0
	|-List<MobActionTargetData>.RemoveAll
	|
	|-RVA: 0x2B186E4 Offset: 0x2B146E4 VA: 0x2B186E4
	|-List<MobIconLabelData>.RemoveAll
	|
	|-RVA: 0x2B1AEB8 Offset: 0x2B16EB8 VA: 0x2B1AEB8
	|-List<object>.RemoveAll
	|
	|-RVA: 0x2B1D9A4 Offset: 0x2B199A4 VA: 0x2B1D9A4
	|-List<PlayerLoopSystem>.RemoveAll
	|
	|-RVA: 0x2B205AC Offset: 0x2B1C5AC VA: 0x2B205AC
	|-List<PlayerLoopSystemInternal>.RemoveAll
	|
	|-RVA: 0x2B22E14 Offset: 0x2B1EE14 VA: 0x2B22E14
	|-List<RangePositionInfo>.RemoveAll
	|
	|-RVA: 0x2B255BC Offset: 0x2B215BC VA: 0x2B255BC
	|-List<ReinforceCristaData>.RemoveAll
	|
	|-RVA: 0x2B27C60 Offset: 0x2B23C60 VA: 0x2B27C60
	|-List<sbyte>.RemoveAll
	|
	|-RVA: 0x2B2A2A4 Offset: 0x2B262A4 VA: 0x2B2A2A4
	|-List<float>.RemoveAll
	|
	|-RVA: 0x2B2C8DC Offset: 0x2B288DC VA: 0x2B2C8DC
	|-List<SkillIdData>.RemoveAll
	|
	|-RVA: 0x2B2EF14 Offset: 0x2B2AF14 VA: 0x2B2EF14
	|-List<TimeSpan>.RemoveAll
	|
	|-RVA: 0x2B5592C Offset: 0x2B5192C VA: 0x2B5592C
	|-List<ushort>.RemoveAll
	|
	|-RVA: 0x2B57F60 Offset: 0x2B53F60 VA: 0x2B57F60
	|-List<uint>.RemoveAll
	|
	|-RVA: 0x2B5A594 Offset: 0x2B56594 VA: 0x2B5A594
	|-List<ulong>.RemoveAll
	|
	|-RVA: 0x2B5CC20 Offset: 0x2B58C20 VA: 0x2B5CC20
	|-List<Vector2>.RemoveAll
	|
	|-RVA: 0x2B5F358 Offset: 0x2B5B358 VA: 0x2B5F358
	|-List<Vector3>.RemoveAll
	|
	|-RVA: 0x2B61AA0 Offset: 0x2B5DAA0 VA: 0x2B61AA0
	|-List<X509ChainStatus>.RemoveAll
	|
	|-RVA: 0x2B65060 Offset: 0x2B61060 VA: 0x2B65060
	|-List<__Il2CppFullySharedGenericType>.RemoveAll
	|
	|-RVA: 0x2B67C2C Offset: 0x2B63C2C VA: 0x2B67C2C
	|-List<BeforeRenderHelper.OrderBlock>.RemoveAll
	|
	|-RVA: 0x2B6A710 Offset: 0x2B66710 VA: 0x2B6A710
	|-List<BoneClip.MotionKeyFrame>.RemoveAll
	|
	|-RVA: 0x2B6D2EC Offset: 0x2B692EC VA: 0x2B6D2EC
	|-List<HouseRecipeManager.RecipeData>.RemoveAll
	|
	|-RVA: 0x2B6FAAC Offset: 0x2B6BAAC VA: 0x2B6FAAC
	|-List<KadarElexioBuf.SkillIdData>.RemoveAll
	|
	|-RVA: 0x2B721A8 Offset: 0x2B6E1A8 VA: 0x2B721A8
	|-List<MissionTextManagerData.CheckIKeywordtemData>.RemoveAll
	|
	|-RVA: 0x2B7490C Offset: 0x2B7090C VA: 0x2B7490C
	|-List<MissionTextManagerData.PickUpFieldData>.RemoveAll
	|
	|-RVA: 0x2B76FEC Offset: 0x2B72FEC VA: 0x2B76FEC
	|-List<MobaRoomData.MobaAbilityMasterData>.RemoveAll
	|
	|-RVA: 0x2B798D4 Offset: 0x2B758D4 VA: 0x2B798D4
	|-List<NewWaveRoomData.Spotlight>.RemoveAll
	|
	|-RVA: 0x2B7C0C0 Offset: 0x2B780C0 VA: 0x2B7C0C0
	|-List<NguiDynamicFontController.ApplyTextureInfo>.RemoveAll
	|
	|-RVA: 0x2B7E7B4 Offset: 0x2B7A7B4 VA: 0x2B7E7B4
	|-List<RegexCharClass.SingleRange>.RemoveAll
	|
	|-RVA: 0x2B80E88 Offset: 0x2B7CE88 VA: 0x2B80E88
	|-List<SocialAchievementData.LinkData>.RemoveAll
	|
	|-RVA: 0x2B8356C Offset: 0x2B7F56C VA: 0x2B8356C
	|-List<TrophyManager.TrophyData>.RemoveAll
	|
	|-RVA: 0x2B85FBC Offset: 0x2B81FBC VA: 0x2B85FBC
	|-List<UIEventMenuButton.MessageButtonData>.RemoveAll
	|
	|-RVA: 0x2B88A18 Offset: 0x2B84A18 VA: 0x2B88A18
	|-List<UIFieldMapPanel.PopData>.RemoveAll
	|
	|-RVA: 0x2B8B168 Offset: 0x2B87168 VA: 0x2B8B168
	|-List<UIHouseAddressManager.Town>.RemoveAll
	|
	|-RVA: 0x2B8DA30 Offset: 0x2B89A30 VA: 0x2B8DA30
	|-List<UIInfoWindow.LabelPosition>.RemoveAll
	|
	|-RVA: 0x2B90180 Offset: 0x2B8C180 VA: 0x2B90180
	|-List<UIMainManager.DropItemData>.RemoveAll
	|
	|-RVA: 0x2B92854 Offset: 0x2B8E854 VA: 0x2B92854
	|-List<UIScenarioOrderPanel.MissionData>.RemoveAll
	|
	|-RVA: 0x2B95350 Offset: 0x2B91350 VA: 0x2B95350
	|-List<UnitySynchronizationContext.WorkRequest>.RemoveAll
	|
	|-RVA: 0x2B97BB0 Offset: 0x2B93BB0 VA: 0x2B97BB0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.RemoveAll
	|
	|-RVA: 0x2B9A4C4 Offset: 0x2B964C4 VA: 0x2B9A4C4
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.RemoveAll
	|
	|-RVA: 0x2B9CE04 Offset: 0x2B98E04 VA: 0x2B9CE04
	|-List<InstructionList.DebugView.InstructionView>.RemoveAll
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAED7C Offset: 0x2AAAD7C VA: 0x2AAED7C
	|-List<KeyValuePair<ArchetypeUid, object>>.RemoveAt
	|
	|-RVA: 0x2AB1430 Offset: 0x2AAD430 VA: 0x2AB1430
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.RemoveAt
	|
	|-RVA: 0x2AB3A78 Offset: 0x2AAFA78 VA: 0x2AB3A78
	|-List<KeyValuePair<byte, byte>>.RemoveAt
	|
	|-RVA: 0x2AB6508 Offset: 0x2AB2508 VA: 0x2AB6508
	|-List<KeyValuePair<byte, object>>.RemoveAt
	|
	|-RVA: 0x2AB8BAC Offset: 0x2AB4BAC VA: 0x2AB8BAC
	|-List<KeyValuePair<int, short>>.RemoveAt
	|
	|-RVA: 0x2ABB1E4 Offset: 0x2AB71E4 VA: 0x2ABB1E4
	|-List<KeyValuePair<int, int>>.RemoveAt
	|
	|-RVA: 0x2ABD8F8 Offset: 0x2AB98F8 VA: 0x2ABD8F8
	|-List<KeyValuePair<int, object>>.RemoveAt
	|
	|-RVA: 0x2ABFF9C Offset: 0x2ABBF9C VA: 0x2ABFF9C
	|-List<KeyValuePair<Int32Enum, byte>>.RemoveAt
	|
	|-RVA: 0x2AC2A4C Offset: 0x2ABEA4C VA: 0x2AC2A4C
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.RemoveAt
	|
	|-RVA: 0x2AC50D4 Offset: 0x2AC10D4 VA: 0x2AC50D4
	|-List<KeyValuePair<Int32Enum, int>>.RemoveAt
	|
	|-RVA: 0x2AC77E8 Offset: 0x2AC37E8 VA: 0x2AC77E8
	|-List<KeyValuePair<Int32Enum, object>>.RemoveAt
	|
	|-RVA: 0x2AC9F68 Offset: 0x2AC5F68 VA: 0x2AC9F68
	|-List<KeyValuePair<object, int>>.RemoveAt
	|
	|-RVA: 0x2ACC6E8 Offset: 0x2AC86E8 VA: 0x2ACC6E8
	|-List<KeyValuePair<object, float>>.RemoveAt
	|
	|-RVA: 0x2ACEE68 Offset: 0x2ACAE68 VA: 0x2ACEE68
	|-List<KeyValuePair<float, object>>.RemoveAt
	|
	|-RVA: 0x2AD1860 Offset: 0x2ACD860 VA: 0x2AD1860
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.RemoveAt
	|
	|-RVA: 0x2AD4014 Offset: 0x2AD0014 VA: 0x2AD4014
	|-List<StructMultiKey<object, object>>.RemoveAt
	|
	|-RVA: 0x2AD66C8 Offset: 0x2AD26C8 VA: 0x2AD66C8
	|-List<ValueTuple<short, short>>.RemoveAt
	|
	|-RVA: 0x2AD8D00 Offset: 0x2AD4D00 VA: 0x2AD8D00
	|-List<ValueTuple<int, int>>.RemoveAt
	|
	|-RVA: 0x2ADB414 Offset: 0x2AD7414 VA: 0x2ADB414
	|-List<ValueTuple<int, object>>.RemoveAt
	|
	|-RVA: 0x2ADDAB8 Offset: 0x2AD9AB8 VA: 0x2ADDAB8
	|-List<ValueTuple<Int32Enum, float>>.RemoveAt
	|
	|-RVA: 0x2AE0524 Offset: 0x2ADC524 VA: 0x2AE0524
	|-List<ValueTuple<Vector3, Vector3>>.RemoveAt
	|
	|-RVA: 0x2AE2BA8 Offset: 0x2ADEBA8 VA: 0x2AE2BA8
	|-List<ArchetypeUid>.RemoveAt
	|
	|-RVA: 0x2AE521C Offset: 0x2AE121C VA: 0x2AE521C
	|-List<bool>.RemoveAt
	|
	|-RVA: 0x2AE785C Offset: 0x2AE385C VA: 0x2AE785C
	|-List<byte>.RemoveAt
	|
	|-RVA: 0x2AE9E98 Offset: 0x2AE5E98 VA: 0x2AE9E98
	|-List<ByteEnum>.RemoveAt
	|
	|-RVA: 0x2AEC4D0 Offset: 0x2AE84D0 VA: 0x2AEC4D0
	|-List<char>.RemoveAt
	|
	|-RVA: 0x2AEEBF4 Offset: 0x2AEABF4 VA: 0x2AEEBF4
	|-List<Color>.RemoveAt
	|
	|-RVA: 0x2AF1258 Offset: 0x2AED258 VA: 0x2AF1258
	|-List<Color32>.RemoveAt
	|
	|-RVA: 0x2AF3890 Offset: 0x2AEF890 VA: 0x2AF3890
	|-List<DateTime>.RemoveAt
	|
	|-RVA: 0x2AF5F20 Offset: 0x2AF1F20 VA: 0x2AF5F20
	|-List<DateTimeOffset>.RemoveAt
	|
	|-RVA: 0x2AF8630 Offset: 0x2AF4630 VA: 0x2AF8630
	|-List<Decimal>.RemoveAt
	|
	|-RVA: 0x2AFAC70 Offset: 0x2AF6C70 VA: 0x2AFAC70
	|-List<DefencePoint2>.RemoveAt
	|
	|-RVA: 0x2AFD2B4 Offset: 0x2AF92B4 VA: 0x2AFD2B4
	|-List<double>.RemoveAt
	|
	|-RVA: 0x2AFF9C8 Offset: 0x2AFB9C8 VA: 0x2AFF9C8
	|-List<EventSummary>.RemoveAt
	|
	|-RVA: 0x2B0206C Offset: 0x2AFE06C VA: 0x2B0206C
	|-List<short>.RemoveAt
	|
	|-RVA: 0x2B046A4 Offset: 0x2B006A4 VA: 0x2B046A4
	|-List<Int16Enum>.RemoveAt
	|
	|-RVA: 0x2B06CD8 Offset: 0x2B02CD8 VA: 0x2B06CD8
	|-List<int>.RemoveAt
	|
	|-RVA: 0x2B0930C Offset: 0x2B0530C VA: 0x2B0930C
	|-List<Int32Enum>.RemoveAt
	|
	|-RVA: 0x2B0B940 Offset: 0x2B07940 VA: 0x2B0B940
	|-List<long>.RemoveAt
	|
	|-RVA: 0x2B0E054 Offset: 0x2B0A054 VA: 0x2B0E054
	|-List<InterpretedFrameInfo>.RemoveAt
	|
	|-RVA: 0x2B10BBC Offset: 0x2B0CBBC VA: 0x2B10BBC
	|-List<JsonPosition>.RemoveAt
	|
	|-RVA: 0x2B1332C Offset: 0x2B0F32C VA: 0x2B1332C
	|-List<MaterialSearchData>.RemoveAt
	|
	|-RVA: 0x2B15DA0 Offset: 0x2B11DA0 VA: 0x2B15DA0
	|-List<MobActionTargetData>.RemoveAt
	|
	|-RVA: 0x2B188E8 Offset: 0x2B148E8 VA: 0x2B188E8
	|-List<MobIconLabelData>.RemoveAt
	|
	|-RVA: 0x2B1B030 Offset: 0x2B17030 VA: 0x2B1B030
	|-List<object>.RemoveAt
	|
	|-RVA: 0x2B1DBA8 Offset: 0x2B19BA8 VA: 0x2B1DBA8
	|-List<PlayerLoopSystem>.RemoveAt
	|
	|-RVA: 0x2B207B0 Offset: 0x2B1C7B0 VA: 0x2B207B0
	|-List<PlayerLoopSystemInternal>.RemoveAt
	|
	|-RVA: 0x2B22FAC Offset: 0x2B1EFAC VA: 0x2B22FAC
	|-List<RangePositionInfo>.RemoveAt
	|
	|-RVA: 0x2B25764 Offset: 0x2B21764 VA: 0x2B25764
	|-List<ReinforceCristaData>.RemoveAt
	|
	|-RVA: 0x2B27DB8 Offset: 0x2B23DB8 VA: 0x2B27DB8
	|-List<sbyte>.RemoveAt
	|
	|-RVA: 0x2B2A3FC Offset: 0x2B263FC VA: 0x2B2A3FC
	|-List<float>.RemoveAt
	|
	|-RVA: 0x2B2CA34 Offset: 0x2B28A34 VA: 0x2B2CA34
	|-List<SkillIdData>.RemoveAt
	|
	|-RVA: 0x2B2F06C Offset: 0x2B2B06C VA: 0x2B2F06C
	|-List<TimeSpan>.RemoveAt
	|
	|-RVA: 0x2B55A84 Offset: 0x2B51A84 VA: 0x2B55A84
	|-List<ushort>.RemoveAt
	|
	|-RVA: 0x2B580B8 Offset: 0x2B540B8 VA: 0x2B580B8
	|-List<uint>.RemoveAt
	|
	|-RVA: 0x2B5A6EC Offset: 0x2B566EC VA: 0x2B5A6EC
	|-List<ulong>.RemoveAt
	|
	|-RVA: 0x2B5CD90 Offset: 0x2B58D90 VA: 0x2B5CD90
	|-List<Vector2>.RemoveAt
	|
	|-RVA: 0x2B5F500 Offset: 0x2B5B500 VA: 0x2B5F500
	|-List<Vector3>.RemoveAt
	|
	|-RVA: 0x2B61C38 Offset: 0x2B5DC38 VA: 0x2B61C38
	|-List<X509ChainStatus>.RemoveAt
	|
	|-RVA: 0x2B65360 Offset: 0x2B61360 VA: 0x2B65360
	|-List<__Il2CppFullySharedGenericType>.RemoveAt
	|
	|-RVA: 0x2B67DC4 Offset: 0x2B63DC4 VA: 0x2B67DC4
	|-List<BeforeRenderHelper.OrderBlock>.RemoveAt
	|
	|-RVA: 0x2B6A910 Offset: 0x2B66910 VA: 0x2B6A910
	|-List<BoneClip.MotionKeyFrame>.RemoveAt
	|
	|-RVA: 0x2B6D4EC Offset: 0x2B694EC VA: 0x2B6D4EC
	|-List<HouseRecipeManager.RecipeData>.RemoveAt
	|
	|-RVA: 0x2B6FC04 Offset: 0x2B6BC04 VA: 0x2B6FC04
	|-List<KadarElexioBuf.SkillIdData>.RemoveAt
	|
	|-RVA: 0x2B72350 Offset: 0x2B6E350 VA: 0x2B72350
	|-List<MissionTextManagerData.CheckIKeywordtemData>.RemoveAt
	|
	|-RVA: 0x2B74AB4 Offset: 0x2B70AB4 VA: 0x2B74AB4
	|-List<MissionTextManagerData.PickUpFieldData>.RemoveAt
	|
	|-RVA: 0x2B7715C Offset: 0x2B7315C VA: 0x2B7715C
	|-List<MobaRoomData.MobaAbilityMasterData>.RemoveAt
	|
	|-RVA: 0x2B79AA4 Offset: 0x2B75AA4 VA: 0x2B79AA4
	|-List<NewWaveRoomData.Spotlight>.RemoveAt
	|
	|-RVA: 0x2B7C258 Offset: 0x2B78258 VA: 0x2B7C258
	|-List<NguiDynamicFontController.ApplyTextureInfo>.RemoveAt
	|
	|-RVA: 0x2B7E90C Offset: 0x2B7A90C VA: 0x2B7E90C
	|-List<RegexCharClass.SingleRange>.RemoveAt
	|
	|-RVA: 0x2B81020 Offset: 0x2B7D020 VA: 0x2B81020
	|-List<SocialAchievementData.LinkData>.RemoveAt
	|
	|-RVA: 0x2B836C4 Offset: 0x2B7F6C4 VA: 0x2B836C4
	|-List<TrophyManager.TrophyData>.RemoveAt
	|
	|-RVA: 0x2B861C0 Offset: 0x2B821C0 VA: 0x2B861C0
	|-List<UIEventMenuButton.MessageButtonData>.RemoveAt
	|
	|-RVA: 0x2B88BE8 Offset: 0x2B84BE8 VA: 0x2B88BE8
	|-List<UIFieldMapPanel.PopData>.RemoveAt
	|
	|-RVA: 0x2B8B2C0 Offset: 0x2B872C0 VA: 0x2B8B2C0
	|-List<UIHouseAddressManager.Town>.RemoveAt
	|
	|-RVA: 0x2B8DC00 Offset: 0x2B89C00 VA: 0x2B8DC00
	|-List<UIInfoWindow.LabelPosition>.RemoveAt
	|
	|-RVA: 0x2B902D8 Offset: 0x2B8C2D8 VA: 0x2B902D8
	|-List<UIMainManager.DropItemData>.RemoveAt
	|
	|-RVA: 0x2B929EC Offset: 0x2B8E9EC VA: 0x2B929EC
	|-List<UIScenarioOrderPanel.MissionData>.RemoveAt
	|
	|-RVA: 0x2B95554 Offset: 0x2B91554 VA: 0x2B95554
	|-List<UnitySynchronizationContext.WorkRequest>.RemoveAt
	|
	|-RVA: 0x2B97D48 Offset: 0x2B93D48 VA: 0x2B97D48
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.RemoveAt
	|
	|-RVA: 0x2B9A674 Offset: 0x2B96674 VA: 0x2B9A674
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.RemoveAt
	|
	|-RVA: 0x2B9CFD4 Offset: 0x2B98FD4 VA: 0x2B9CFD4
	|-List<InstructionList.DebugView.InstructionView>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAEE1C Offset: 0x2AAAE1C VA: 0x2AAEE1C
	|-List<KeyValuePair<ArchetypeUid, object>>.RemoveRange
	|
	|-RVA: 0x2AB1498 Offset: 0x2AAD498 VA: 0x2AB1498
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.RemoveRange
	|
	|-RVA: 0x2AB3AE0 Offset: 0x2AAFAE0 VA: 0x2AB3AE0
	|-List<KeyValuePair<byte, byte>>.RemoveRange
	|
	|-RVA: 0x2AB65A8 Offset: 0x2AB25A8 VA: 0x2AB65A8
	|-List<KeyValuePair<byte, object>>.RemoveRange
	|
	|-RVA: 0x2AB8C14 Offset: 0x2AB4C14 VA: 0x2AB8C14
	|-List<KeyValuePair<int, short>>.RemoveRange
	|
	|-RVA: 0x2ABB24C Offset: 0x2AB724C VA: 0x2ABB24C
	|-List<KeyValuePair<int, int>>.RemoveRange
	|
	|-RVA: 0x2ABD998 Offset: 0x2AB9998 VA: 0x2ABD998
	|-List<KeyValuePair<int, object>>.RemoveRange
	|
	|-RVA: 0x2AC0004 Offset: 0x2ABC004 VA: 0x2AC0004
	|-List<KeyValuePair<Int32Enum, byte>>.RemoveRange
	|
	|-RVA: 0x2AC2AB4 Offset: 0x2ABEAB4 VA: 0x2AC2AB4
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.RemoveRange
	|
	|-RVA: 0x2AC513C Offset: 0x2AC113C VA: 0x2AC513C
	|-List<KeyValuePair<Int32Enum, int>>.RemoveRange
	|
	|-RVA: 0x2AC7888 Offset: 0x2AC3888 VA: 0x2AC7888
	|-List<KeyValuePair<Int32Enum, object>>.RemoveRange
	|
	|-RVA: 0x2ACA008 Offset: 0x2AC6008 VA: 0x2ACA008
	|-List<KeyValuePair<object, int>>.RemoveRange
	|
	|-RVA: 0x2ACC788 Offset: 0x2AC8788 VA: 0x2ACC788
	|-List<KeyValuePair<object, float>>.RemoveRange
	|
	|-RVA: 0x2ACEF08 Offset: 0x2ACAF08 VA: 0x2ACEF08
	|-List<KeyValuePair<float, object>>.RemoveRange
	|
	|-RVA: 0x2AD191C Offset: 0x2ACD91C VA: 0x2AD191C
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.RemoveRange
	|
	|-RVA: 0x2AD40B4 Offset: 0x2AD00B4 VA: 0x2AD40B4
	|-List<StructMultiKey<object, object>>.RemoveRange
	|
	|-RVA: 0x2AD6730 Offset: 0x2AD2730 VA: 0x2AD6730
	|-List<ValueTuple<short, short>>.RemoveRange
	|
	|-RVA: 0x2AD8D68 Offset: 0x2AD4D68 VA: 0x2AD8D68
	|-List<ValueTuple<int, int>>.RemoveRange
	|
	|-RVA: 0x2ADB4B4 Offset: 0x2AD74B4 VA: 0x2ADB4B4
	|-List<ValueTuple<int, object>>.RemoveRange
	|
	|-RVA: 0x2ADDB20 Offset: 0x2AD9B20 VA: 0x2ADDB20
	|-List<ValueTuple<Int32Enum, float>>.RemoveRange
	|
	|-RVA: 0x2AE058C Offset: 0x2ADC58C VA: 0x2AE058C
	|-List<ValueTuple<Vector3, Vector3>>.RemoveRange
	|
	|-RVA: 0x2AE2C10 Offset: 0x2ADEC10 VA: 0x2AE2C10
	|-List<ArchetypeUid>.RemoveRange
	|
	|-RVA: 0x2AE5284 Offset: 0x2AE1284 VA: 0x2AE5284
	|-List<bool>.RemoveRange
	|
	|-RVA: 0x2AE78C4 Offset: 0x2AE38C4 VA: 0x2AE78C4
	|-List<byte>.RemoveRange
	|
	|-RVA: 0x2AE9F00 Offset: 0x2AE5F00 VA: 0x2AE9F00
	|-List<ByteEnum>.RemoveRange
	|
	|-RVA: 0x2AEC538 Offset: 0x2AE8538 VA: 0x2AEC538
	|-List<char>.RemoveRange
	|
	|-RVA: 0x2AEEC5C Offset: 0x2AEAC5C VA: 0x2AEEC5C
	|-List<Color>.RemoveRange
	|
	|-RVA: 0x2AF12C0 Offset: 0x2AED2C0 VA: 0x2AF12C0
	|-List<Color32>.RemoveRange
	|
	|-RVA: 0x2AF38F8 Offset: 0x2AEF8F8 VA: 0x2AF38F8
	|-List<DateTime>.RemoveRange
	|
	|-RVA: 0x2AF5F88 Offset: 0x2AF1F88 VA: 0x2AF5F88
	|-List<DateTimeOffset>.RemoveRange
	|
	|-RVA: 0x2AF8698 Offset: 0x2AF4698 VA: 0x2AF8698
	|-List<Decimal>.RemoveRange
	|
	|-RVA: 0x2AFACD8 Offset: 0x2AF6CD8 VA: 0x2AFACD8
	|-List<DefencePoint2>.RemoveRange
	|
	|-RVA: 0x2AFD31C Offset: 0x2AF931C VA: 0x2AFD31C
	|-List<double>.RemoveRange
	|
	|-RVA: 0x2AFFA68 Offset: 0x2AFBA68 VA: 0x2AFFA68
	|-List<EventSummary>.RemoveRange
	|
	|-RVA: 0x2B020D4 Offset: 0x2AFE0D4 VA: 0x2B020D4
	|-List<short>.RemoveRange
	|
	|-RVA: 0x2B0470C Offset: 0x2B0070C VA: 0x2B0470C
	|-List<Int16Enum>.RemoveRange
	|
	|-RVA: 0x2B06D40 Offset: 0x2B02D40 VA: 0x2B06D40
	|-List<int>.RemoveRange
	|
	|-RVA: 0x2B09374 Offset: 0x2B05374 VA: 0x2B09374
	|-List<Int32Enum>.RemoveRange
	|
	|-RVA: 0x2B0B9A8 Offset: 0x2B079A8 VA: 0x2B0B9A8
	|-List<long>.RemoveRange
	|
	|-RVA: 0x2B0E0F4 Offset: 0x2B0A0F4 VA: 0x2B0E0F4
	|-List<InterpretedFrameInfo>.RemoveRange
	|
	|-RVA: 0x2B10C8C Offset: 0x2B0CC8C VA: 0x2B10C8C
	|-List<JsonPosition>.RemoveRange
	|
	|-RVA: 0x2B13394 Offset: 0x2B0F394 VA: 0x2B13394
	|-List<MaterialSearchData>.RemoveRange
	|
	|-RVA: 0x2B15E08 Offset: 0x2B11E08 VA: 0x2B15E08
	|-List<MobActionTargetData>.RemoveRange
	|
	|-RVA: 0x2B189B8 Offset: 0x2B149B8 VA: 0x2B189B8
	|-List<MobIconLabelData>.RemoveRange
	|
	|-RVA: 0x2B1B0C8 Offset: 0x2B170C8 VA: 0x2B1B0C8
	|-List<object>.RemoveRange
	|
	|-RVA: 0x2B1DC7C Offset: 0x2B19C7C VA: 0x2B1DC7C
	|-List<PlayerLoopSystem>.RemoveRange
	|
	|-RVA: 0x2B20884 Offset: 0x2B1C884 VA: 0x2B20884
	|-List<PlayerLoopSystemInternal>.RemoveRange
	|
	|-RVA: 0x2B2304C Offset: 0x2B1F04C VA: 0x2B2304C
	|-List<RangePositionInfo>.RemoveRange
	|
	|-RVA: 0x2B257CC Offset: 0x2B217CC VA: 0x2B257CC
	|-List<ReinforceCristaData>.RemoveRange
	|
	|-RVA: 0x2B27E20 Offset: 0x2B23E20 VA: 0x2B27E20
	|-List<sbyte>.RemoveRange
	|
	|-RVA: 0x2B2A464 Offset: 0x2B26464 VA: 0x2B2A464
	|-List<float>.RemoveRange
	|
	|-RVA: 0x2B2CA9C Offset: 0x2B28A9C VA: 0x2B2CA9C
	|-List<SkillIdData>.RemoveRange
	|
	|-RVA: 0x2B2F0D4 Offset: 0x2B2B0D4 VA: 0x2B2F0D4
	|-List<TimeSpan>.RemoveRange
	|
	|-RVA: 0x2B55AEC Offset: 0x2B51AEC VA: 0x2B55AEC
	|-List<ushort>.RemoveRange
	|
	|-RVA: 0x2B58120 Offset: 0x2B54120 VA: 0x2B58120
	|-List<uint>.RemoveRange
	|
	|-RVA: 0x2B5A754 Offset: 0x2B56754 VA: 0x2B5A754
	|-List<ulong>.RemoveRange
	|
	|-RVA: 0x2B5CDF8 Offset: 0x2B58DF8 VA: 0x2B5CDF8
	|-List<Vector2>.RemoveRange
	|
	|-RVA: 0x2B5F568 Offset: 0x2B5B568 VA: 0x2B5F568
	|-List<Vector3>.RemoveRange
	|
	|-RVA: 0x2B61CD8 Offset: 0x2B5DCD8 VA: 0x2B61CD8
	|-List<X509ChainStatus>.RemoveRange
	|
	|-RVA: 0x2B65504 Offset: 0x2B61504 VA: 0x2B65504
	|-List<__Il2CppFullySharedGenericType>.RemoveRange
	|
	|-RVA: 0x2B67E64 Offset: 0x2B63E64 VA: 0x2B67E64
	|-List<BeforeRenderHelper.OrderBlock>.RemoveRange
	|
	|-RVA: 0x2B6A9DC Offset: 0x2B669DC VA: 0x2B6A9DC
	|-List<BoneClip.MotionKeyFrame>.RemoveRange
	|
	|-RVA: 0x2B6D5BC Offset: 0x2B695BC VA: 0x2B6D5BC
	|-List<HouseRecipeManager.RecipeData>.RemoveRange
	|
	|-RVA: 0x2B6FC6C Offset: 0x2B6BC6C VA: 0x2B6FC6C
	|-List<KadarElexioBuf.SkillIdData>.RemoveRange
	|
	|-RVA: 0x2B723B8 Offset: 0x2B6E3B8 VA: 0x2B723B8
	|-List<MissionTextManagerData.CheckIKeywordtemData>.RemoveRange
	|
	|-RVA: 0x2B74B1C Offset: 0x2B70B1C VA: 0x2B74B1C
	|-List<MissionTextManagerData.PickUpFieldData>.RemoveRange
	|
	|-RVA: 0x2B771C4 Offset: 0x2B731C4 VA: 0x2B771C4
	|-List<MobaRoomData.MobaAbilityMasterData>.RemoveRange
	|
	|-RVA: 0x2B79B60 Offset: 0x2B75B60 VA: 0x2B79B60
	|-List<NewWaveRoomData.Spotlight>.RemoveRange
	|
	|-RVA: 0x2B7C2F8 Offset: 0x2B782F8 VA: 0x2B7C2F8
	|-List<NguiDynamicFontController.ApplyTextureInfo>.RemoveRange
	|
	|-RVA: 0x2B7E974 Offset: 0x2B7A974 VA: 0x2B7E974
	|-List<RegexCharClass.SingleRange>.RemoveRange
	|
	|-RVA: 0x2B810C0 Offset: 0x2B7D0C0 VA: 0x2B810C0
	|-List<SocialAchievementData.LinkData>.RemoveRange
	|
	|-RVA: 0x2B8372C Offset: 0x2B7F72C VA: 0x2B8372C
	|-List<TrophyManager.TrophyData>.RemoveRange
	|
	|-RVA: 0x2B86294 Offset: 0x2B82294 VA: 0x2B86294
	|-List<UIEventMenuButton.MessageButtonData>.RemoveRange
	|
	|-RVA: 0x2B88CA4 Offset: 0x2B84CA4 VA: 0x2B88CA4
	|-List<UIFieldMapPanel.PopData>.RemoveRange
	|
	|-RVA: 0x2B8B328 Offset: 0x2B87328 VA: 0x2B8B328
	|-List<UIHouseAddressManager.Town>.RemoveRange
	|
	|-RVA: 0x2B8DCBC Offset: 0x2B89CBC VA: 0x2B8DCBC
	|-List<UIInfoWindow.LabelPosition>.RemoveRange
	|
	|-RVA: 0x2B90340 Offset: 0x2B8C340 VA: 0x2B90340
	|-List<UIMainManager.DropItemData>.RemoveRange
	|
	|-RVA: 0x2B92A8C Offset: 0x2B8EA8C VA: 0x2B92A8C
	|-List<UIScenarioOrderPanel.MissionData>.RemoveRange
	|
	|-RVA: 0x2B95624 Offset: 0x2B91624 VA: 0x2B95624
	|-List<UnitySynchronizationContext.WorkRequest>.RemoveRange
	|
	|-RVA: 0x2B97DE8 Offset: 0x2B93DE8 VA: 0x2B97DE8
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.RemoveRange
	|
	|-RVA: 0x2B9A6DC Offset: 0x2B966DC VA: 0x2B9A6DC
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.RemoveRange
	|
	|-RVA: 0x2B9D090 Offset: 0x2B99090 VA: 0x2B9D090
	|-List<InstructionList.DebugView.InstructionView>.RemoveRange
	*/

	// RVA: -1 Offset: -1
	public void Reverse() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAEEDC Offset: 0x2AAAEDC VA: 0x2AAEEDC
	|-List<KeyValuePair<ArchetypeUid, object>>.Reverse
	|
	|-RVA: 0x2AB153C Offset: 0x2AAD53C VA: 0x2AB153C
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.Reverse
	|
	|-RVA: 0x2AB3B84 Offset: 0x2AAFB84 VA: 0x2AB3B84
	|-List<KeyValuePair<byte, byte>>.Reverse
	|
	|-RVA: 0x2AB6668 Offset: 0x2AB2668 VA: 0x2AB6668
	|-List<KeyValuePair<byte, object>>.Reverse
	|
	|-RVA: 0x2AB8CB8 Offset: 0x2AB4CB8 VA: 0x2AB8CB8
	|-List<KeyValuePair<int, short>>.Reverse
	|
	|-RVA: 0x2ABB2F0 Offset: 0x2AB72F0 VA: 0x2ABB2F0
	|-List<KeyValuePair<int, int>>.Reverse
	|
	|-RVA: 0x2ABDA58 Offset: 0x2AB9A58 VA: 0x2ABDA58
	|-List<KeyValuePair<int, object>>.Reverse
	|
	|-RVA: 0x2AC00A8 Offset: 0x2ABC0A8 VA: 0x2AC00A8
	|-List<KeyValuePair<Int32Enum, byte>>.Reverse
	|
	|-RVA: 0x2AC2B58 Offset: 0x2ABEB58 VA: 0x2AC2B58
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.Reverse
	|
	|-RVA: 0x2AC51E0 Offset: 0x2AC11E0 VA: 0x2AC51E0
	|-List<KeyValuePair<Int32Enum, int>>.Reverse
	|
	|-RVA: 0x2AC7948 Offset: 0x2AC3948 VA: 0x2AC7948
	|-List<KeyValuePair<Int32Enum, object>>.Reverse
	|
	|-RVA: 0x2ACA0C8 Offset: 0x2AC60C8 VA: 0x2ACA0C8
	|-List<KeyValuePair<object, int>>.Reverse
	|
	|-RVA: 0x2ACC848 Offset: 0x2AC8848 VA: 0x2ACC848
	|-List<KeyValuePair<object, float>>.Reverse
	|
	|-RVA: 0x2ACEFC8 Offset: 0x2ACAFC8 VA: 0x2ACEFC8
	|-List<KeyValuePair<float, object>>.Reverse
	|
	|-RVA: 0x2AD19DC Offset: 0x2ACD9DC VA: 0x2AD19DC
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.Reverse
	|
	|-RVA: 0x2AD4174 Offset: 0x2AD0174 VA: 0x2AD4174
	|-List<StructMultiKey<object, object>>.Reverse
	|
	|-RVA: 0x2AD67D4 Offset: 0x2AD27D4 VA: 0x2AD67D4
	|-List<ValueTuple<short, short>>.Reverse
	|
	|-RVA: 0x2AD8E0C Offset: 0x2AD4E0C VA: 0x2AD8E0C
	|-List<ValueTuple<int, int>>.Reverse
	|
	|-RVA: 0x2ADB574 Offset: 0x2AD7574 VA: 0x2ADB574
	|-List<ValueTuple<int, object>>.Reverse
	|
	|-RVA: 0x2ADDBC4 Offset: 0x2AD9BC4 VA: 0x2ADDBC4
	|-List<ValueTuple<Int32Enum, float>>.Reverse
	|
	|-RVA: 0x2AE0630 Offset: 0x2ADC630 VA: 0x2AE0630
	|-List<ValueTuple<Vector3, Vector3>>.Reverse
	|
	|-RVA: 0x2AE2CB4 Offset: 0x2ADECB4 VA: 0x2AE2CB4
	|-List<ArchetypeUid>.Reverse
	|
	|-RVA: 0x2AE5328 Offset: 0x2AE1328 VA: 0x2AE5328
	|-List<bool>.Reverse
	|
	|-RVA: 0x2AE7968 Offset: 0x2AE3968 VA: 0x2AE7968
	|-List<byte>.Reverse
	|
	|-RVA: 0x2AE9FA4 Offset: 0x2AE5FA4 VA: 0x2AE9FA4
	|-List<ByteEnum>.Reverse
	|
	|-RVA: 0x2AEC5DC Offset: 0x2AE85DC VA: 0x2AEC5DC
	|-List<char>.Reverse
	|
	|-RVA: 0x2AEED00 Offset: 0x2AEAD00 VA: 0x2AEED00
	|-List<Color>.Reverse
	|
	|-RVA: 0x2AF1364 Offset: 0x2AED364 VA: 0x2AF1364
	|-List<Color32>.Reverse
	|
	|-RVA: 0x2AF399C Offset: 0x2AEF99C VA: 0x2AF399C
	|-List<DateTime>.Reverse
	|
	|-RVA: 0x2AF602C Offset: 0x2AF202C VA: 0x2AF602C
	|-List<DateTimeOffset>.Reverse
	|
	|-RVA: 0x2AF873C Offset: 0x2AF473C VA: 0x2AF873C
	|-List<Decimal>.Reverse
	|
	|-RVA: 0x2AFAD7C Offset: 0x2AF6D7C VA: 0x2AFAD7C
	|-List<DefencePoint2>.Reverse
	|
	|-RVA: 0x2AFD3C0 Offset: 0x2AF93C0 VA: 0x2AFD3C0
	|-List<double>.Reverse
	|
	|-RVA: 0x2AFFB28 Offset: 0x2AFBB28 VA: 0x2AFFB28
	|-List<EventSummary>.Reverse
	|
	|-RVA: 0x2B02178 Offset: 0x2AFE178 VA: 0x2B02178
	|-List<short>.Reverse
	|
	|-RVA: 0x2B047B0 Offset: 0x2B007B0 VA: 0x2B047B0
	|-List<Int16Enum>.Reverse
	|
	|-RVA: 0x2B06DE4 Offset: 0x2B02DE4 VA: 0x2B06DE4
	|-List<int>.Reverse
	|
	|-RVA: 0x2B09418 Offset: 0x2B05418 VA: 0x2B09418
	|-List<Int32Enum>.Reverse
	|
	|-RVA: 0x2B0BA4C Offset: 0x2B07A4C VA: 0x2B0BA4C
	|-List<long>.Reverse
	|
	|-RVA: 0x2B0E1B4 Offset: 0x2B0A1B4 VA: 0x2B0E1B4
	|-List<InterpretedFrameInfo>.Reverse
	|
	|-RVA: 0x2B10D4C Offset: 0x2B0CD4C VA: 0x2B10D4C
	|-List<JsonPosition>.Reverse
	|
	|-RVA: 0x2B13438 Offset: 0x2B0F438 VA: 0x2B13438
	|-List<MaterialSearchData>.Reverse
	|
	|-RVA: 0x2B15EAC Offset: 0x2B11EAC VA: 0x2B15EAC
	|-List<MobActionTargetData>.Reverse
	|
	|-RVA: 0x2B18A78 Offset: 0x2B14A78 VA: 0x2B18A78
	|-List<MobIconLabelData>.Reverse
	|
	|-RVA: 0x2B1B188 Offset: 0x2B17188 VA: 0x2B1B188
	|-List<object>.Reverse
	|
	|-RVA: 0x2B1DD3C Offset: 0x2B19D3C VA: 0x2B1DD3C
	|-List<PlayerLoopSystem>.Reverse
	|
	|-RVA: 0x2B20944 Offset: 0x2B1C944 VA: 0x2B20944
	|-List<PlayerLoopSystemInternal>.Reverse
	|
	|-RVA: 0x2B2310C Offset: 0x2B1F10C VA: 0x2B2310C
	|-List<RangePositionInfo>.Reverse
	|
	|-RVA: 0x2B25870 Offset: 0x2B21870 VA: 0x2B25870
	|-List<ReinforceCristaData>.Reverse
	|
	|-RVA: 0x2B27EC4 Offset: 0x2B23EC4 VA: 0x2B27EC4
	|-List<sbyte>.Reverse
	|
	|-RVA: 0x2B2A508 Offset: 0x2B26508 VA: 0x2B2A508
	|-List<float>.Reverse
	|
	|-RVA: 0x2B2CB40 Offset: 0x2B28B40 VA: 0x2B2CB40
	|-List<SkillIdData>.Reverse
	|
	|-RVA: 0x2B2F178 Offset: 0x2B2B178 VA: 0x2B2F178
	|-List<TimeSpan>.Reverse
	|
	|-RVA: 0x2B55B90 Offset: 0x2B51B90 VA: 0x2B55B90
	|-List<ushort>.Reverse
	|
	|-RVA: 0x2B581C4 Offset: 0x2B541C4 VA: 0x2B581C4
	|-List<uint>.Reverse
	|
	|-RVA: 0x2B5A7F8 Offset: 0x2B567F8 VA: 0x2B5A7F8
	|-List<ulong>.Reverse
	|
	|-RVA: 0x2B5CE9C Offset: 0x2B58E9C VA: 0x2B5CE9C
	|-List<Vector2>.Reverse
	|
	|-RVA: 0x2B5F60C Offset: 0x2B5B60C VA: 0x2B5F60C
	|-List<Vector3>.Reverse
	|
	|-RVA: 0x2B61D98 Offset: 0x2B5DD98 VA: 0x2B61D98
	|-List<X509ChainStatus>.Reverse
	|
	|-RVA: 0x2B655E8 Offset: 0x2B615E8 VA: 0x2B655E8
	|-List<__Il2CppFullySharedGenericType>.Reverse
	|
	|-RVA: 0x2B67F24 Offset: 0x2B63F24 VA: 0x2B67F24
	|-List<BeforeRenderHelper.OrderBlock>.Reverse
	|
	|-RVA: 0x2B6AA9C Offset: 0x2B66A9C VA: 0x2B6AA9C
	|-List<BoneClip.MotionKeyFrame>.Reverse
	|
	|-RVA: 0x2B6D67C Offset: 0x2B6967C VA: 0x2B6D67C
	|-List<HouseRecipeManager.RecipeData>.Reverse
	|
	|-RVA: 0x2B6FD10 Offset: 0x2B6BD10 VA: 0x2B6FD10
	|-List<KadarElexioBuf.SkillIdData>.Reverse
	|
	|-RVA: 0x2B7245C Offset: 0x2B6E45C VA: 0x2B7245C
	|-List<MissionTextManagerData.CheckIKeywordtemData>.Reverse
	|
	|-RVA: 0x2B74BC0 Offset: 0x2B70BC0 VA: 0x2B74BC0
	|-List<MissionTextManagerData.PickUpFieldData>.Reverse
	|
	|-RVA: 0x2B77268 Offset: 0x2B73268 VA: 0x2B77268
	|-List<MobaRoomData.MobaAbilityMasterData>.Reverse
	|
	|-RVA: 0x2B79C20 Offset: 0x2B75C20 VA: 0x2B79C20
	|-List<NewWaveRoomData.Spotlight>.Reverse
	|
	|-RVA: 0x2B7C3B8 Offset: 0x2B783B8 VA: 0x2B7C3B8
	|-List<NguiDynamicFontController.ApplyTextureInfo>.Reverse
	|
	|-RVA: 0x2B7EA18 Offset: 0x2B7AA18 VA: 0x2B7EA18
	|-List<RegexCharClass.SingleRange>.Reverse
	|
	|-RVA: 0x2B81180 Offset: 0x2B7D180 VA: 0x2B81180
	|-List<SocialAchievementData.LinkData>.Reverse
	|
	|-RVA: 0x2B837D0 Offset: 0x2B7F7D0 VA: 0x2B837D0
	|-List<TrophyManager.TrophyData>.Reverse
	|
	|-RVA: 0x2B86354 Offset: 0x2B82354 VA: 0x2B86354
	|-List<UIEventMenuButton.MessageButtonData>.Reverse
	|
	|-RVA: 0x2B88D64 Offset: 0x2B84D64 VA: 0x2B88D64
	|-List<UIFieldMapPanel.PopData>.Reverse
	|
	|-RVA: 0x2B8B3CC Offset: 0x2B873CC VA: 0x2B8B3CC
	|-List<UIHouseAddressManager.Town>.Reverse
	|
	|-RVA: 0x2B8DD7C Offset: 0x2B89D7C VA: 0x2B8DD7C
	|-List<UIInfoWindow.LabelPosition>.Reverse
	|
	|-RVA: 0x2B903E4 Offset: 0x2B8C3E4 VA: 0x2B903E4
	|-List<UIMainManager.DropItemData>.Reverse
	|
	|-RVA: 0x2B92B4C Offset: 0x2B8EB4C VA: 0x2B92B4C
	|-List<UIScenarioOrderPanel.MissionData>.Reverse
	|
	|-RVA: 0x2B956E4 Offset: 0x2B916E4 VA: 0x2B956E4
	|-List<UnitySynchronizationContext.WorkRequest>.Reverse
	|
	|-RVA: 0x2B97EA8 Offset: 0x2B93EA8 VA: 0x2B97EA8
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Reverse
	|
	|-RVA: 0x2B9A780 Offset: 0x2B96780 VA: 0x2B9A780
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.Reverse
	|
	|-RVA: 0x2B9D150 Offset: 0x2B99150 VA: 0x2B9D150
	|-List<InstructionList.DebugView.InstructionView>.Reverse
	*/

	// RVA: -1 Offset: -1
	public void Reverse(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAEEF4 Offset: 0x2AAAEF4 VA: 0x2AAEEF4
	|-List<KeyValuePair<ArchetypeUid, object>>.Reverse
	|
	|-RVA: 0x2AB1554 Offset: 0x2AAD554 VA: 0x2AB1554
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.Reverse
	|
	|-RVA: 0x2AB3B9C Offset: 0x2AAFB9C VA: 0x2AB3B9C
	|-List<KeyValuePair<byte, byte>>.Reverse
	|
	|-RVA: 0x2AB6680 Offset: 0x2AB2680 VA: 0x2AB6680
	|-List<KeyValuePair<byte, object>>.Reverse
	|
	|-RVA: 0x2AB8CD0 Offset: 0x2AB4CD0 VA: 0x2AB8CD0
	|-List<KeyValuePair<int, short>>.Reverse
	|
	|-RVA: 0x2ABB308 Offset: 0x2AB7308 VA: 0x2ABB308
	|-List<KeyValuePair<int, int>>.Reverse
	|
	|-RVA: 0x2ABDA70 Offset: 0x2AB9A70 VA: 0x2ABDA70
	|-List<KeyValuePair<int, object>>.Reverse
	|
	|-RVA: 0x2AC00C0 Offset: 0x2ABC0C0 VA: 0x2AC00C0
	|-List<KeyValuePair<Int32Enum, byte>>.Reverse
	|
	|-RVA: 0x2AC2B70 Offset: 0x2ABEB70 VA: 0x2AC2B70
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.Reverse
	|
	|-RVA: 0x2AC51F8 Offset: 0x2AC11F8 VA: 0x2AC51F8
	|-List<KeyValuePair<Int32Enum, int>>.Reverse
	|
	|-RVA: 0x2AC7960 Offset: 0x2AC3960 VA: 0x2AC7960
	|-List<KeyValuePair<Int32Enum, object>>.Reverse
	|
	|-RVA: 0x2ACA0E0 Offset: 0x2AC60E0 VA: 0x2ACA0E0
	|-List<KeyValuePair<object, int>>.Reverse
	|
	|-RVA: 0x2ACC860 Offset: 0x2AC8860 VA: 0x2ACC860
	|-List<KeyValuePair<object, float>>.Reverse
	|
	|-RVA: 0x2ACEFE0 Offset: 0x2ACAFE0 VA: 0x2ACEFE0
	|-List<KeyValuePair<float, object>>.Reverse
	|
	|-RVA: 0x2AD19F4 Offset: 0x2ACD9F4 VA: 0x2AD19F4
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.Reverse
	|
	|-RVA: 0x2AD418C Offset: 0x2AD018C VA: 0x2AD418C
	|-List<StructMultiKey<object, object>>.Reverse
	|
	|-RVA: 0x2AD67EC Offset: 0x2AD27EC VA: 0x2AD67EC
	|-List<ValueTuple<short, short>>.Reverse
	|
	|-RVA: 0x2AD8E24 Offset: 0x2AD4E24 VA: 0x2AD8E24
	|-List<ValueTuple<int, int>>.Reverse
	|
	|-RVA: 0x2ADB58C Offset: 0x2AD758C VA: 0x2ADB58C
	|-List<ValueTuple<int, object>>.Reverse
	|
	|-RVA: 0x2ADDBDC Offset: 0x2AD9BDC VA: 0x2ADDBDC
	|-List<ValueTuple<Int32Enum, float>>.Reverse
	|
	|-RVA: 0x2AE0648 Offset: 0x2ADC648 VA: 0x2AE0648
	|-List<ValueTuple<Vector3, Vector3>>.Reverse
	|
	|-RVA: 0x2AE2CCC Offset: 0x2ADECCC VA: 0x2AE2CCC
	|-List<ArchetypeUid>.Reverse
	|
	|-RVA: 0x2AE5340 Offset: 0x2AE1340 VA: 0x2AE5340
	|-List<bool>.Reverse
	|
	|-RVA: 0x2AE7980 Offset: 0x2AE3980 VA: 0x2AE7980
	|-List<byte>.Reverse
	|
	|-RVA: 0x2AE9FBC Offset: 0x2AE5FBC VA: 0x2AE9FBC
	|-List<ByteEnum>.Reverse
	|
	|-RVA: 0x2AEC5F4 Offset: 0x2AE85F4 VA: 0x2AEC5F4
	|-List<char>.Reverse
	|
	|-RVA: 0x2AEED18 Offset: 0x2AEAD18 VA: 0x2AEED18
	|-List<Color>.Reverse
	|
	|-RVA: 0x2AF137C Offset: 0x2AED37C VA: 0x2AF137C
	|-List<Color32>.Reverse
	|
	|-RVA: 0x2AF39B4 Offset: 0x2AEF9B4 VA: 0x2AF39B4
	|-List<DateTime>.Reverse
	|
	|-RVA: 0x2AF6044 Offset: 0x2AF2044 VA: 0x2AF6044
	|-List<DateTimeOffset>.Reverse
	|
	|-RVA: 0x2AF8754 Offset: 0x2AF4754 VA: 0x2AF8754
	|-List<Decimal>.Reverse
	|
	|-RVA: 0x2AFAD94 Offset: 0x2AF6D94 VA: 0x2AFAD94
	|-List<DefencePoint2>.Reverse
	|
	|-RVA: 0x2AFD3D8 Offset: 0x2AF93D8 VA: 0x2AFD3D8
	|-List<double>.Reverse
	|
	|-RVA: 0x2AFFB40 Offset: 0x2AFBB40 VA: 0x2AFFB40
	|-List<EventSummary>.Reverse
	|
	|-RVA: 0x2B02190 Offset: 0x2AFE190 VA: 0x2B02190
	|-List<short>.Reverse
	|
	|-RVA: 0x2B047C8 Offset: 0x2B007C8 VA: 0x2B047C8
	|-List<Int16Enum>.Reverse
	|
	|-RVA: 0x2B06DFC Offset: 0x2B02DFC VA: 0x2B06DFC
	|-List<int>.Reverse
	|
	|-RVA: 0x2B09430 Offset: 0x2B05430 VA: 0x2B09430
	|-List<Int32Enum>.Reverse
	|
	|-RVA: 0x2B0BA64 Offset: 0x2B07A64 VA: 0x2B0BA64
	|-List<long>.Reverse
	|
	|-RVA: 0x2B0E1CC Offset: 0x2B0A1CC VA: 0x2B0E1CC
	|-List<InterpretedFrameInfo>.Reverse
	|
	|-RVA: 0x2B10D64 Offset: 0x2B0CD64 VA: 0x2B10D64
	|-List<JsonPosition>.Reverse
	|
	|-RVA: 0x2B13450 Offset: 0x2B0F450 VA: 0x2B13450
	|-List<MaterialSearchData>.Reverse
	|
	|-RVA: 0x2B15EC4 Offset: 0x2B11EC4 VA: 0x2B15EC4
	|-List<MobActionTargetData>.Reverse
	|
	|-RVA: 0x2B18A90 Offset: 0x2B14A90 VA: 0x2B18A90
	|-List<MobIconLabelData>.Reverse
	|
	|-RVA: 0x2B1B1A0 Offset: 0x2B171A0 VA: 0x2B1B1A0
	|-List<object>.Reverse
	|
	|-RVA: 0x2B1DD54 Offset: 0x2B19D54 VA: 0x2B1DD54
	|-List<PlayerLoopSystem>.Reverse
	|
	|-RVA: 0x2B2095C Offset: 0x2B1C95C VA: 0x2B2095C
	|-List<PlayerLoopSystemInternal>.Reverse
	|
	|-RVA: 0x2B23124 Offset: 0x2B1F124 VA: 0x2B23124
	|-List<RangePositionInfo>.Reverse
	|
	|-RVA: 0x2B25888 Offset: 0x2B21888 VA: 0x2B25888
	|-List<ReinforceCristaData>.Reverse
	|
	|-RVA: 0x2B27EDC Offset: 0x2B23EDC VA: 0x2B27EDC
	|-List<sbyte>.Reverse
	|
	|-RVA: 0x2B2A520 Offset: 0x2B26520 VA: 0x2B2A520
	|-List<float>.Reverse
	|
	|-RVA: 0x2B2CB58 Offset: 0x2B28B58 VA: 0x2B2CB58
	|-List<SkillIdData>.Reverse
	|
	|-RVA: 0x2B2F190 Offset: 0x2B2B190 VA: 0x2B2F190
	|-List<TimeSpan>.Reverse
	|
	|-RVA: 0x2B55BA8 Offset: 0x2B51BA8 VA: 0x2B55BA8
	|-List<ushort>.Reverse
	|
	|-RVA: 0x2B581DC Offset: 0x2B541DC VA: 0x2B581DC
	|-List<uint>.Reverse
	|
	|-RVA: 0x2B5A810 Offset: 0x2B56810 VA: 0x2B5A810
	|-List<ulong>.Reverse
	|
	|-RVA: 0x2B5CEB4 Offset: 0x2B58EB4 VA: 0x2B5CEB4
	|-List<Vector2>.Reverse
	|
	|-RVA: 0x2B5F624 Offset: 0x2B5B624 VA: 0x2B5F624
	|-List<Vector3>.Reverse
	|
	|-RVA: 0x2B61DB0 Offset: 0x2B5DDB0 VA: 0x2B61DB0
	|-List<X509ChainStatus>.Reverse
	|
	|-RVA: 0x2B65634 Offset: 0x2B61634 VA: 0x2B65634
	|-List<__Il2CppFullySharedGenericType>.Reverse
	|
	|-RVA: 0x2B67F3C Offset: 0x2B63F3C VA: 0x2B67F3C
	|-List<BeforeRenderHelper.OrderBlock>.Reverse
	|
	|-RVA: 0x2B6AAB4 Offset: 0x2B66AB4 VA: 0x2B6AAB4
	|-List<BoneClip.MotionKeyFrame>.Reverse
	|
	|-RVA: 0x2B6D694 Offset: 0x2B69694 VA: 0x2B6D694
	|-List<HouseRecipeManager.RecipeData>.Reverse
	|
	|-RVA: 0x2B6FD28 Offset: 0x2B6BD28 VA: 0x2B6FD28
	|-List<KadarElexioBuf.SkillIdData>.Reverse
	|
	|-RVA: 0x2B72474 Offset: 0x2B6E474 VA: 0x2B72474
	|-List<MissionTextManagerData.CheckIKeywordtemData>.Reverse
	|
	|-RVA: 0x2B74BD8 Offset: 0x2B70BD8 VA: 0x2B74BD8
	|-List<MissionTextManagerData.PickUpFieldData>.Reverse
	|
	|-RVA: 0x2B77280 Offset: 0x2B73280 VA: 0x2B77280
	|-List<MobaRoomData.MobaAbilityMasterData>.Reverse
	|
	|-RVA: 0x2B79C38 Offset: 0x2B75C38 VA: 0x2B79C38
	|-List<NewWaveRoomData.Spotlight>.Reverse
	|
	|-RVA: 0x2B7C3D0 Offset: 0x2B783D0 VA: 0x2B7C3D0
	|-List<NguiDynamicFontController.ApplyTextureInfo>.Reverse
	|
	|-RVA: 0x2B7EA30 Offset: 0x2B7AA30 VA: 0x2B7EA30
	|-List<RegexCharClass.SingleRange>.Reverse
	|
	|-RVA: 0x2B81198 Offset: 0x2B7D198 VA: 0x2B81198
	|-List<SocialAchievementData.LinkData>.Reverse
	|
	|-RVA: 0x2B837E8 Offset: 0x2B7F7E8 VA: 0x2B837E8
	|-List<TrophyManager.TrophyData>.Reverse
	|
	|-RVA: 0x2B8636C Offset: 0x2B8236C VA: 0x2B8636C
	|-List<UIEventMenuButton.MessageButtonData>.Reverse
	|
	|-RVA: 0x2B88D7C Offset: 0x2B84D7C VA: 0x2B88D7C
	|-List<UIFieldMapPanel.PopData>.Reverse
	|
	|-RVA: 0x2B8B3E4 Offset: 0x2B873E4 VA: 0x2B8B3E4
	|-List<UIHouseAddressManager.Town>.Reverse
	|
	|-RVA: 0x2B8DD94 Offset: 0x2B89D94 VA: 0x2B8DD94
	|-List<UIInfoWindow.LabelPosition>.Reverse
	|
	|-RVA: 0x2B903FC Offset: 0x2B8C3FC VA: 0x2B903FC
	|-List<UIMainManager.DropItemData>.Reverse
	|
	|-RVA: 0x2B92B64 Offset: 0x2B8EB64 VA: 0x2B92B64
	|-List<UIScenarioOrderPanel.MissionData>.Reverse
	|
	|-RVA: 0x2B956FC Offset: 0x2B916FC VA: 0x2B956FC
	|-List<UnitySynchronizationContext.WorkRequest>.Reverse
	|
	|-RVA: 0x2B97EC0 Offset: 0x2B93EC0 VA: 0x2B97EC0
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Reverse
	|
	|-RVA: 0x2B9A798 Offset: 0x2B96798 VA: 0x2B9A798
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.Reverse
	|
	|-RVA: 0x2B9D168 Offset: 0x2B99168 VA: 0x2B9D168
	|-List<InstructionList.DebugView.InstructionView>.Reverse
	*/

	// RVA: -1 Offset: -1
	public void Sort() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAEF94 Offset: 0x2AAAF94 VA: 0x2AAEF94
	|-List<KeyValuePair<ArchetypeUid, object>>.Sort
	|
	|-RVA: 0x2AB15F4 Offset: 0x2AAD5F4 VA: 0x2AB15F4
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.Sort
	|
	|-RVA: 0x2AB3C3C Offset: 0x2AAFC3C VA: 0x2AB3C3C
	|-List<KeyValuePair<byte, byte>>.Sort
	|
	|-RVA: 0x2AB6720 Offset: 0x2AB2720 VA: 0x2AB6720
	|-List<KeyValuePair<byte, object>>.Sort
	|
	|-RVA: 0x2AB8D70 Offset: 0x2AB4D70 VA: 0x2AB8D70
	|-List<KeyValuePair<int, short>>.Sort
	|
	|-RVA: 0x2ABB3A8 Offset: 0x2AB73A8 VA: 0x2ABB3A8
	|-List<KeyValuePair<int, int>>.Sort
	|
	|-RVA: 0x2ABDB10 Offset: 0x2AB9B10 VA: 0x2ABDB10
	|-List<KeyValuePair<int, object>>.Sort
	|
	|-RVA: 0x2AC0160 Offset: 0x2ABC160 VA: 0x2AC0160
	|-List<KeyValuePair<Int32Enum, byte>>.Sort
	|
	|-RVA: 0x2AC2C10 Offset: 0x2ABEC10 VA: 0x2AC2C10
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.Sort
	|
	|-RVA: 0x2AC5298 Offset: 0x2AC1298 VA: 0x2AC5298
	|-List<KeyValuePair<Int32Enum, int>>.Sort
	|
	|-RVA: 0x2AC7A00 Offset: 0x2AC3A00 VA: 0x2AC7A00
	|-List<KeyValuePair<Int32Enum, object>>.Sort
	|
	|-RVA: 0x2ACA180 Offset: 0x2AC6180 VA: 0x2ACA180
	|-List<KeyValuePair<object, int>>.Sort
	|
	|-RVA: 0x2ACC900 Offset: 0x2AC8900 VA: 0x2ACC900
	|-List<KeyValuePair<object, float>>.Sort
	|
	|-RVA: 0x2ACF080 Offset: 0x2ACB080 VA: 0x2ACF080
	|-List<KeyValuePair<float, object>>.Sort
	|
	|-RVA: 0x2AD1A94 Offset: 0x2ACDA94 VA: 0x2AD1A94
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.Sort
	|
	|-RVA: 0x2AD422C Offset: 0x2AD022C VA: 0x2AD422C
	|-List<StructMultiKey<object, object>>.Sort
	|
	|-RVA: 0x2AD688C Offset: 0x2AD288C VA: 0x2AD688C
	|-List<ValueTuple<short, short>>.Sort
	|
	|-RVA: 0x2AD8EC4 Offset: 0x2AD4EC4 VA: 0x2AD8EC4
	|-List<ValueTuple<int, int>>.Sort
	|
	|-RVA: 0x2ADB62C Offset: 0x2AD762C VA: 0x2ADB62C
	|-List<ValueTuple<int, object>>.Sort
	|
	|-RVA: 0x2ADDC7C Offset: 0x2AD9C7C VA: 0x2ADDC7C
	|-List<ValueTuple<Int32Enum, float>>.Sort
	|
	|-RVA: 0x2AE06E8 Offset: 0x2ADC6E8 VA: 0x2AE06E8
	|-List<ValueTuple<Vector3, Vector3>>.Sort
	|
	|-RVA: 0x2AE2D6C Offset: 0x2ADED6C VA: 0x2AE2D6C
	|-List<ArchetypeUid>.Sort
	|
	|-RVA: 0x2AE53E0 Offset: 0x2AE13E0 VA: 0x2AE53E0
	|-List<bool>.Sort
	|
	|-RVA: 0x2AE7A20 Offset: 0x2AE3A20 VA: 0x2AE7A20
	|-List<byte>.Sort
	|
	|-RVA: 0x2AEA05C Offset: 0x2AE605C VA: 0x2AEA05C
	|-List<ByteEnum>.Sort
	|
	|-RVA: 0x2AEC694 Offset: 0x2AE8694 VA: 0x2AEC694
	|-List<char>.Sort
	|
	|-RVA: 0x2AEEDB8 Offset: 0x2AEADB8 VA: 0x2AEEDB8
	|-List<Color>.Sort
	|
	|-RVA: 0x2AF141C Offset: 0x2AED41C VA: 0x2AF141C
	|-List<Color32>.Sort
	|
	|-RVA: 0x2AF3A54 Offset: 0x2AEFA54 VA: 0x2AF3A54
	|-List<DateTime>.Sort
	|
	|-RVA: 0x2AF60E4 Offset: 0x2AF20E4 VA: 0x2AF60E4
	|-List<DateTimeOffset>.Sort
	|
	|-RVA: 0x2AF87F4 Offset: 0x2AF47F4 VA: 0x2AF87F4
	|-List<Decimal>.Sort
	|
	|-RVA: 0x2AFAE34 Offset: 0x2AF6E34 VA: 0x2AFAE34
	|-List<DefencePoint2>.Sort
	|
	|-RVA: 0x2AFD478 Offset: 0x2AF9478 VA: 0x2AFD478
	|-List<double>.Sort
	|
	|-RVA: 0x2AFFBE0 Offset: 0x2AFBBE0 VA: 0x2AFFBE0
	|-List<EventSummary>.Sort
	|
	|-RVA: 0x2B02230 Offset: 0x2AFE230 VA: 0x2B02230
	|-List<short>.Sort
	|
	|-RVA: 0x2B04868 Offset: 0x2B00868 VA: 0x2B04868
	|-List<Int16Enum>.Sort
	|
	|-RVA: 0x2B06E9C Offset: 0x2B02E9C VA: 0x2B06E9C
	|-List<int>.Sort
	|
	|-RVA: 0x2B094D0 Offset: 0x2B054D0 VA: 0x2B094D0
	|-List<Int32Enum>.Sort
	|
	|-RVA: 0x2B0BB04 Offset: 0x2B07B04 VA: 0x2B0BB04
	|-List<long>.Sort
	|
	|-RVA: 0x2B0E26C Offset: 0x2B0A26C VA: 0x2B0E26C
	|-List<InterpretedFrameInfo>.Sort
	|
	|-RVA: 0x2B10E04 Offset: 0x2B0CE04 VA: 0x2B10E04
	|-List<JsonPosition>.Sort
	|
	|-RVA: 0x2B134F0 Offset: 0x2B0F4F0 VA: 0x2B134F0
	|-List<MaterialSearchData>.Sort
	|
	|-RVA: 0x2B15F64 Offset: 0x2B11F64 VA: 0x2B15F64
	|-List<MobActionTargetData>.Sort
	|
	|-RVA: 0x2B18B30 Offset: 0x2B14B30 VA: 0x2B18B30
	|-List<MobIconLabelData>.Sort
	|
	|-RVA: 0x2B1B240 Offset: 0x2B17240 VA: 0x2B1B240
	|-List<object>.Sort
	|
	|-RVA: 0x2B1DDF4 Offset: 0x2B19DF4 VA: 0x2B1DDF4
	|-List<PlayerLoopSystem>.Sort
	|
	|-RVA: 0x2B209FC Offset: 0x2B1C9FC VA: 0x2B209FC
	|-List<PlayerLoopSystemInternal>.Sort
	|
	|-RVA: 0x2B231C4 Offset: 0x2B1F1C4 VA: 0x2B231C4
	|-List<RangePositionInfo>.Sort
	|
	|-RVA: 0x2B25928 Offset: 0x2B21928 VA: 0x2B25928
	|-List<ReinforceCristaData>.Sort
	|
	|-RVA: 0x2B27F7C Offset: 0x2B23F7C VA: 0x2B27F7C
	|-List<sbyte>.Sort
	|
	|-RVA: 0x2B2A5C0 Offset: 0x2B265C0 VA: 0x2B2A5C0
	|-List<float>.Sort
	|
	|-RVA: 0x2B2CBF8 Offset: 0x2B28BF8 VA: 0x2B2CBF8
	|-List<SkillIdData>.Sort
	|
	|-RVA: 0x2B2F230 Offset: 0x2B2B230 VA: 0x2B2F230
	|-List<TimeSpan>.Sort
	|
	|-RVA: 0x2B55C48 Offset: 0x2B51C48 VA: 0x2B55C48
	|-List<ushort>.Sort
	|
	|-RVA: 0x2B5827C Offset: 0x2B5427C VA: 0x2B5827C
	|-List<uint>.Sort
	|
	|-RVA: 0x2B5A8B0 Offset: 0x2B568B0 VA: 0x2B5A8B0
	|-List<ulong>.Sort
	|
	|-RVA: 0x2B5CF54 Offset: 0x2B58F54 VA: 0x2B5CF54
	|-List<Vector2>.Sort
	|
	|-RVA: 0x2B5F6C4 Offset: 0x2B5B6C4 VA: 0x2B5F6C4
	|-List<Vector3>.Sort
	|
	|-RVA: 0x2B61E50 Offset: 0x2B5DE50 VA: 0x2B61E50
	|-List<X509ChainStatus>.Sort
	|
	|-RVA: 0x2B656D8 Offset: 0x2B616D8 VA: 0x2B656D8
	|-List<__Il2CppFullySharedGenericType>.Sort
	|
	|-RVA: 0x2B67FDC Offset: 0x2B63FDC VA: 0x2B67FDC
	|-List<BeforeRenderHelper.OrderBlock>.Sort
	|
	|-RVA: 0x2B6AB54 Offset: 0x2B66B54 VA: 0x2B6AB54
	|-List<BoneClip.MotionKeyFrame>.Sort
	|
	|-RVA: 0x2B6D734 Offset: 0x2B69734 VA: 0x2B6D734
	|-List<HouseRecipeManager.RecipeData>.Sort
	|
	|-RVA: 0x2B6FDC8 Offset: 0x2B6BDC8 VA: 0x2B6FDC8
	|-List<KadarElexioBuf.SkillIdData>.Sort
	|
	|-RVA: 0x2B72514 Offset: 0x2B6E514 VA: 0x2B72514
	|-List<MissionTextManagerData.CheckIKeywordtemData>.Sort
	|
	|-RVA: 0x2B74C78 Offset: 0x2B70C78 VA: 0x2B74C78
	|-List<MissionTextManagerData.PickUpFieldData>.Sort
	|
	|-RVA: 0x2B77320 Offset: 0x2B73320 VA: 0x2B77320
	|-List<MobaRoomData.MobaAbilityMasterData>.Sort
	|
	|-RVA: 0x2B79CD8 Offset: 0x2B75CD8 VA: 0x2B79CD8
	|-List<NewWaveRoomData.Spotlight>.Sort
	|
	|-RVA: 0x2B7C470 Offset: 0x2B78470 VA: 0x2B7C470
	|-List<NguiDynamicFontController.ApplyTextureInfo>.Sort
	|
	|-RVA: 0x2B7EAD0 Offset: 0x2B7AAD0 VA: 0x2B7EAD0
	|-List<RegexCharClass.SingleRange>.Sort
	|
	|-RVA: 0x2B81238 Offset: 0x2B7D238 VA: 0x2B81238
	|-List<SocialAchievementData.LinkData>.Sort
	|
	|-RVA: 0x2B83888 Offset: 0x2B7F888 VA: 0x2B83888
	|-List<TrophyManager.TrophyData>.Sort
	|
	|-RVA: 0x2B8640C Offset: 0x2B8240C VA: 0x2B8640C
	|-List<UIEventMenuButton.MessageButtonData>.Sort
	|
	|-RVA: 0x2B88E1C Offset: 0x2B84E1C VA: 0x2B88E1C
	|-List<UIFieldMapPanel.PopData>.Sort
	|
	|-RVA: 0x2B8B484 Offset: 0x2B87484 VA: 0x2B8B484
	|-List<UIHouseAddressManager.Town>.Sort
	|
	|-RVA: 0x2B8DE34 Offset: 0x2B89E34 VA: 0x2B8DE34
	|-List<UIInfoWindow.LabelPosition>.Sort
	|
	|-RVA: 0x2B9049C Offset: 0x2B8C49C VA: 0x2B9049C
	|-List<UIMainManager.DropItemData>.Sort
	|
	|-RVA: 0x2B92C04 Offset: 0x2B8EC04 VA: 0x2B92C04
	|-List<UIScenarioOrderPanel.MissionData>.Sort
	|
	|-RVA: 0x2B9579C Offset: 0x2B9179C VA: 0x2B9579C
	|-List<UnitySynchronizationContext.WorkRequest>.Sort
	|
	|-RVA: 0x2B97F60 Offset: 0x2B93F60 VA: 0x2B97F60
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Sort
	|
	|-RVA: 0x2B9A838 Offset: 0x2B96838 VA: 0x2B9A838
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.Sort
	|
	|-RVA: 0x2B9D208 Offset: 0x2B99208 VA: 0x2B9D208
	|-List<InstructionList.DebugView.InstructionView>.Sort
	*/

	// RVA: -1 Offset: -1
	public void Sort(IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAEFB0 Offset: 0x2AAAFB0 VA: 0x2AAEFB0
	|-List<KeyValuePair<ArchetypeUid, object>>.Sort
	|
	|-RVA: 0x2AB1610 Offset: 0x2AAD610 VA: 0x2AB1610
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.Sort
	|
	|-RVA: 0x2AB3C58 Offset: 0x2AAFC58 VA: 0x2AB3C58
	|-List<KeyValuePair<byte, byte>>.Sort
	|
	|-RVA: 0x2AB673C Offset: 0x2AB273C VA: 0x2AB673C
	|-List<KeyValuePair<byte, object>>.Sort
	|
	|-RVA: 0x2AB8D8C Offset: 0x2AB4D8C VA: 0x2AB8D8C
	|-List<KeyValuePair<int, short>>.Sort
	|
	|-RVA: 0x2ABB3C4 Offset: 0x2AB73C4 VA: 0x2ABB3C4
	|-List<KeyValuePair<int, int>>.Sort
	|
	|-RVA: 0x2ABDB2C Offset: 0x2AB9B2C VA: 0x2ABDB2C
	|-List<KeyValuePair<int, object>>.Sort
	|
	|-RVA: 0x2AC017C Offset: 0x2ABC17C VA: 0x2AC017C
	|-List<KeyValuePair<Int32Enum, byte>>.Sort
	|
	|-RVA: 0x2AC2C2C Offset: 0x2ABEC2C VA: 0x2AC2C2C
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.Sort
	|
	|-RVA: 0x2AC52B4 Offset: 0x2AC12B4 VA: 0x2AC52B4
	|-List<KeyValuePair<Int32Enum, int>>.Sort
	|
	|-RVA: 0x2AC7A1C Offset: 0x2AC3A1C VA: 0x2AC7A1C
	|-List<KeyValuePair<Int32Enum, object>>.Sort
	|
	|-RVA: 0x2ACA19C Offset: 0x2AC619C VA: 0x2ACA19C
	|-List<KeyValuePair<object, int>>.Sort
	|
	|-RVA: 0x2ACC91C Offset: 0x2AC891C VA: 0x2ACC91C
	|-List<KeyValuePair<object, float>>.Sort
	|
	|-RVA: 0x2ACF09C Offset: 0x2ACB09C VA: 0x2ACF09C
	|-List<KeyValuePair<float, object>>.Sort
	|
	|-RVA: 0x2AD1AB0 Offset: 0x2ACDAB0 VA: 0x2AD1AB0
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.Sort
	|
	|-RVA: 0x2AD4248 Offset: 0x2AD0248 VA: 0x2AD4248
	|-List<StructMultiKey<object, object>>.Sort
	|
	|-RVA: 0x2AD68A8 Offset: 0x2AD28A8 VA: 0x2AD68A8
	|-List<ValueTuple<short, short>>.Sort
	|
	|-RVA: 0x2AD8EE0 Offset: 0x2AD4EE0 VA: 0x2AD8EE0
	|-List<ValueTuple<int, int>>.Sort
	|
	|-RVA: 0x2ADB648 Offset: 0x2AD7648 VA: 0x2ADB648
	|-List<ValueTuple<int, object>>.Sort
	|
	|-RVA: 0x2ADDC98 Offset: 0x2AD9C98 VA: 0x2ADDC98
	|-List<ValueTuple<Int32Enum, float>>.Sort
	|
	|-RVA: 0x2AE0704 Offset: 0x2ADC704 VA: 0x2AE0704
	|-List<ValueTuple<Vector3, Vector3>>.Sort
	|
	|-RVA: 0x2AE2D88 Offset: 0x2ADED88 VA: 0x2AE2D88
	|-List<ArchetypeUid>.Sort
	|
	|-RVA: 0x2AE53FC Offset: 0x2AE13FC VA: 0x2AE53FC
	|-List<bool>.Sort
	|
	|-RVA: 0x2AE7A3C Offset: 0x2AE3A3C VA: 0x2AE7A3C
	|-List<byte>.Sort
	|
	|-RVA: 0x2AEA078 Offset: 0x2AE6078 VA: 0x2AEA078
	|-List<ByteEnum>.Sort
	|
	|-RVA: 0x2AEC6B0 Offset: 0x2AE86B0 VA: 0x2AEC6B0
	|-List<char>.Sort
	|
	|-RVA: 0x2AEEDD4 Offset: 0x2AEADD4 VA: 0x2AEEDD4
	|-List<Color>.Sort
	|
	|-RVA: 0x2AF1438 Offset: 0x2AED438 VA: 0x2AF1438
	|-List<Color32>.Sort
	|
	|-RVA: 0x2AF3A70 Offset: 0x2AEFA70 VA: 0x2AF3A70
	|-List<DateTime>.Sort
	|
	|-RVA: 0x2AF6100 Offset: 0x2AF2100 VA: 0x2AF6100
	|-List<DateTimeOffset>.Sort
	|
	|-RVA: 0x2AF8810 Offset: 0x2AF4810 VA: 0x2AF8810
	|-List<Decimal>.Sort
	|
	|-RVA: 0x2AFAE50 Offset: 0x2AF6E50 VA: 0x2AFAE50
	|-List<DefencePoint2>.Sort
	|
	|-RVA: 0x2AFD494 Offset: 0x2AF9494 VA: 0x2AFD494
	|-List<double>.Sort
	|
	|-RVA: 0x2AFFBFC Offset: 0x2AFBBFC VA: 0x2AFFBFC
	|-List<EventSummary>.Sort
	|
	|-RVA: 0x2B0224C Offset: 0x2AFE24C VA: 0x2B0224C
	|-List<short>.Sort
	|
	|-RVA: 0x2B04884 Offset: 0x2B00884 VA: 0x2B04884
	|-List<Int16Enum>.Sort
	|
	|-RVA: 0x2B06EB8 Offset: 0x2B02EB8 VA: 0x2B06EB8
	|-List<int>.Sort
	|
	|-RVA: 0x2B094EC Offset: 0x2B054EC VA: 0x2B094EC
	|-List<Int32Enum>.Sort
	|
	|-RVA: 0x2B0BB20 Offset: 0x2B07B20 VA: 0x2B0BB20
	|-List<long>.Sort
	|
	|-RVA: 0x2B0E288 Offset: 0x2B0A288 VA: 0x2B0E288
	|-List<InterpretedFrameInfo>.Sort
	|
	|-RVA: 0x2B10E20 Offset: 0x2B0CE20 VA: 0x2B10E20
	|-List<JsonPosition>.Sort
	|
	|-RVA: 0x2B1350C Offset: 0x2B0F50C VA: 0x2B1350C
	|-List<MaterialSearchData>.Sort
	|
	|-RVA: 0x2B15F80 Offset: 0x2B11F80 VA: 0x2B15F80
	|-List<MobActionTargetData>.Sort
	|
	|-RVA: 0x2B18B4C Offset: 0x2B14B4C VA: 0x2B18B4C
	|-List<MobIconLabelData>.Sort
	|
	|-RVA: 0x2B1B25C Offset: 0x2B1725C VA: 0x2B1B25C
	|-List<object>.Sort
	|
	|-RVA: 0x2B1DE10 Offset: 0x2B19E10 VA: 0x2B1DE10
	|-List<PlayerLoopSystem>.Sort
	|
	|-RVA: 0x2B20A18 Offset: 0x2B1CA18 VA: 0x2B20A18
	|-List<PlayerLoopSystemInternal>.Sort
	|
	|-RVA: 0x2B231E0 Offset: 0x2B1F1E0 VA: 0x2B231E0
	|-List<RangePositionInfo>.Sort
	|
	|-RVA: 0x2B25944 Offset: 0x2B21944 VA: 0x2B25944
	|-List<ReinforceCristaData>.Sort
	|
	|-RVA: 0x2B27F98 Offset: 0x2B23F98 VA: 0x2B27F98
	|-List<sbyte>.Sort
	|
	|-RVA: 0x2B2A5DC Offset: 0x2B265DC VA: 0x2B2A5DC
	|-List<float>.Sort
	|
	|-RVA: 0x2B2CC14 Offset: 0x2B28C14 VA: 0x2B2CC14
	|-List<SkillIdData>.Sort
	|
	|-RVA: 0x2B2F24C Offset: 0x2B2B24C VA: 0x2B2F24C
	|-List<TimeSpan>.Sort
	|
	|-RVA: 0x2B55C64 Offset: 0x2B51C64 VA: 0x2B55C64
	|-List<ushort>.Sort
	|
	|-RVA: 0x2B58298 Offset: 0x2B54298 VA: 0x2B58298
	|-List<uint>.Sort
	|
	|-RVA: 0x2B5A8CC Offset: 0x2B568CC VA: 0x2B5A8CC
	|-List<ulong>.Sort
	|
	|-RVA: 0x2B5CF70 Offset: 0x2B58F70 VA: 0x2B5CF70
	|-List<Vector2>.Sort
	|
	|-RVA: 0x2B5F6E0 Offset: 0x2B5B6E0 VA: 0x2B5F6E0
	|-List<Vector3>.Sort
	|
	|-RVA: 0x2B61E6C Offset: 0x2B5DE6C VA: 0x2B61E6C
	|-List<X509ChainStatus>.Sort
	|
	|-RVA: 0x2B65728 Offset: 0x2B61728 VA: 0x2B65728
	|-List<__Il2CppFullySharedGenericType>.Sort
	|
	|-RVA: 0x2B67FF8 Offset: 0x2B63FF8 VA: 0x2B67FF8
	|-List<BeforeRenderHelper.OrderBlock>.Sort
	|
	|-RVA: 0x2B6AB70 Offset: 0x2B66B70 VA: 0x2B6AB70
	|-List<BoneClip.MotionKeyFrame>.Sort
	|
	|-RVA: 0x2B6D750 Offset: 0x2B69750 VA: 0x2B6D750
	|-List<HouseRecipeManager.RecipeData>.Sort
	|
	|-RVA: 0x2B6FDE4 Offset: 0x2B6BDE4 VA: 0x2B6FDE4
	|-List<KadarElexioBuf.SkillIdData>.Sort
	|
	|-RVA: 0x2B72530 Offset: 0x2B6E530 VA: 0x2B72530
	|-List<MissionTextManagerData.CheckIKeywordtemData>.Sort
	|
	|-RVA: 0x2B74C94 Offset: 0x2B70C94 VA: 0x2B74C94
	|-List<MissionTextManagerData.PickUpFieldData>.Sort
	|
	|-RVA: 0x2B7733C Offset: 0x2B7333C VA: 0x2B7733C
	|-List<MobaRoomData.MobaAbilityMasterData>.Sort
	|
	|-RVA: 0x2B79CF4 Offset: 0x2B75CF4 VA: 0x2B79CF4
	|-List<NewWaveRoomData.Spotlight>.Sort
	|
	|-RVA: 0x2B7C48C Offset: 0x2B7848C VA: 0x2B7C48C
	|-List<NguiDynamicFontController.ApplyTextureInfo>.Sort
	|
	|-RVA: 0x2B7EAEC Offset: 0x2B7AAEC VA: 0x2B7EAEC
	|-List<RegexCharClass.SingleRange>.Sort
	|
	|-RVA: 0x2B81254 Offset: 0x2B7D254 VA: 0x2B81254
	|-List<SocialAchievementData.LinkData>.Sort
	|
	|-RVA: 0x2B838A4 Offset: 0x2B7F8A4 VA: 0x2B838A4
	|-List<TrophyManager.TrophyData>.Sort
	|
	|-RVA: 0x2B86428 Offset: 0x2B82428 VA: 0x2B86428
	|-List<UIEventMenuButton.MessageButtonData>.Sort
	|
	|-RVA: 0x2B88E38 Offset: 0x2B84E38 VA: 0x2B88E38
	|-List<UIFieldMapPanel.PopData>.Sort
	|
	|-RVA: 0x2B8B4A0 Offset: 0x2B874A0 VA: 0x2B8B4A0
	|-List<UIHouseAddressManager.Town>.Sort
	|
	|-RVA: 0x2B8DE50 Offset: 0x2B89E50 VA: 0x2B8DE50
	|-List<UIInfoWindow.LabelPosition>.Sort
	|
	|-RVA: 0x2B904B8 Offset: 0x2B8C4B8 VA: 0x2B904B8
	|-List<UIMainManager.DropItemData>.Sort
	|
	|-RVA: 0x2B92C20 Offset: 0x2B8EC20 VA: 0x2B92C20
	|-List<UIScenarioOrderPanel.MissionData>.Sort
	|
	|-RVA: 0x2B957B8 Offset: 0x2B917B8 VA: 0x2B957B8
	|-List<UnitySynchronizationContext.WorkRequest>.Sort
	|
	|-RVA: 0x2B97F7C Offset: 0x2B93F7C VA: 0x2B97F7C
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Sort
	|
	|-RVA: 0x2B9A854 Offset: 0x2B96854 VA: 0x2B9A854
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.Sort
	|
	|-RVA: 0x2B9D224 Offset: 0x2B99224 VA: 0x2B9D224
	|-List<InstructionList.DebugView.InstructionView>.Sort
	*/

	// RVA: -1 Offset: -1
	public void Sort(int index, int count, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAEFCC Offset: 0x2AAAFCC VA: 0x2AAEFCC
	|-List<KeyValuePair<ArchetypeUid, object>>.Sort
	|
	|-RVA: 0x2AB162C Offset: 0x2AAD62C VA: 0x2AB162C
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.Sort
	|
	|-RVA: 0x2AB3C74 Offset: 0x2AAFC74 VA: 0x2AB3C74
	|-List<KeyValuePair<byte, byte>>.Sort
	|
	|-RVA: 0x2AB6758 Offset: 0x2AB2758 VA: 0x2AB6758
	|-List<KeyValuePair<byte, object>>.Sort
	|
	|-RVA: 0x2AB8DA8 Offset: 0x2AB4DA8 VA: 0x2AB8DA8
	|-List<KeyValuePair<int, short>>.Sort
	|
	|-RVA: 0x2ABB3E0 Offset: 0x2AB73E0 VA: 0x2ABB3E0
	|-List<KeyValuePair<int, int>>.Sort
	|
	|-RVA: 0x2ABDB48 Offset: 0x2AB9B48 VA: 0x2ABDB48
	|-List<KeyValuePair<int, object>>.Sort
	|
	|-RVA: 0x2AC0198 Offset: 0x2ABC198 VA: 0x2AC0198
	|-List<KeyValuePair<Int32Enum, byte>>.Sort
	|
	|-RVA: 0x2AC2C48 Offset: 0x2ABEC48 VA: 0x2AC2C48
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.Sort
	|
	|-RVA: 0x2AC52D0 Offset: 0x2AC12D0 VA: 0x2AC52D0
	|-List<KeyValuePair<Int32Enum, int>>.Sort
	|
	|-RVA: 0x2AC7A38 Offset: 0x2AC3A38 VA: 0x2AC7A38
	|-List<KeyValuePair<Int32Enum, object>>.Sort
	|
	|-RVA: 0x2ACA1B8 Offset: 0x2AC61B8 VA: 0x2ACA1B8
	|-List<KeyValuePair<object, int>>.Sort
	|
	|-RVA: 0x2ACC938 Offset: 0x2AC8938 VA: 0x2ACC938
	|-List<KeyValuePair<object, float>>.Sort
	|
	|-RVA: 0x2ACF0B8 Offset: 0x2ACB0B8 VA: 0x2ACF0B8
	|-List<KeyValuePair<float, object>>.Sort
	|
	|-RVA: 0x2AD1ACC Offset: 0x2ACDACC VA: 0x2AD1ACC
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.Sort
	|
	|-RVA: 0x2AD4264 Offset: 0x2AD0264 VA: 0x2AD4264
	|-List<StructMultiKey<object, object>>.Sort
	|
	|-RVA: 0x2AD68C4 Offset: 0x2AD28C4 VA: 0x2AD68C4
	|-List<ValueTuple<short, short>>.Sort
	|
	|-RVA: 0x2AD8EFC Offset: 0x2AD4EFC VA: 0x2AD8EFC
	|-List<ValueTuple<int, int>>.Sort
	|
	|-RVA: 0x2ADB664 Offset: 0x2AD7664 VA: 0x2ADB664
	|-List<ValueTuple<int, object>>.Sort
	|
	|-RVA: 0x2ADDCB4 Offset: 0x2AD9CB4 VA: 0x2ADDCB4
	|-List<ValueTuple<Int32Enum, float>>.Sort
	|
	|-RVA: 0x2AE0720 Offset: 0x2ADC720 VA: 0x2AE0720
	|-List<ValueTuple<Vector3, Vector3>>.Sort
	|
	|-RVA: 0x2AE2DA4 Offset: 0x2ADEDA4 VA: 0x2AE2DA4
	|-List<ArchetypeUid>.Sort
	|
	|-RVA: 0x2AE5418 Offset: 0x2AE1418 VA: 0x2AE5418
	|-List<bool>.Sort
	|
	|-RVA: 0x2AE7A58 Offset: 0x2AE3A58 VA: 0x2AE7A58
	|-List<byte>.Sort
	|
	|-RVA: 0x2AEA094 Offset: 0x2AE6094 VA: 0x2AEA094
	|-List<ByteEnum>.Sort
	|
	|-RVA: 0x2AEC6CC Offset: 0x2AE86CC VA: 0x2AEC6CC
	|-List<char>.Sort
	|
	|-RVA: 0x2AEEDF0 Offset: 0x2AEADF0 VA: 0x2AEEDF0
	|-List<Color>.Sort
	|
	|-RVA: 0x2AF1454 Offset: 0x2AED454 VA: 0x2AF1454
	|-List<Color32>.Sort
	|
	|-RVA: 0x2AF3A8C Offset: 0x2AEFA8C VA: 0x2AF3A8C
	|-List<DateTime>.Sort
	|
	|-RVA: 0x2AF611C Offset: 0x2AF211C VA: 0x2AF611C
	|-List<DateTimeOffset>.Sort
	|
	|-RVA: 0x2AF882C Offset: 0x2AF482C VA: 0x2AF882C
	|-List<Decimal>.Sort
	|
	|-RVA: 0x2AFAE6C Offset: 0x2AF6E6C VA: 0x2AFAE6C
	|-List<DefencePoint2>.Sort
	|
	|-RVA: 0x2AFD4B0 Offset: 0x2AF94B0 VA: 0x2AFD4B0
	|-List<double>.Sort
	|
	|-RVA: 0x2AFFC18 Offset: 0x2AFBC18 VA: 0x2AFFC18
	|-List<EventSummary>.Sort
	|
	|-RVA: 0x2B02268 Offset: 0x2AFE268 VA: 0x2B02268
	|-List<short>.Sort
	|
	|-RVA: 0x2B048A0 Offset: 0x2B008A0 VA: 0x2B048A0
	|-List<Int16Enum>.Sort
	|
	|-RVA: 0x2B06ED4 Offset: 0x2B02ED4 VA: 0x2B06ED4
	|-List<int>.Sort
	|
	|-RVA: 0x2B09508 Offset: 0x2B05508 VA: 0x2B09508
	|-List<Int32Enum>.Sort
	|
	|-RVA: 0x2B0BB3C Offset: 0x2B07B3C VA: 0x2B0BB3C
	|-List<long>.Sort
	|
	|-RVA: 0x2B0E2A4 Offset: 0x2B0A2A4 VA: 0x2B0E2A4
	|-List<InterpretedFrameInfo>.Sort
	|
	|-RVA: 0x2B10E3C Offset: 0x2B0CE3C VA: 0x2B10E3C
	|-List<JsonPosition>.Sort
	|
	|-RVA: 0x2B13528 Offset: 0x2B0F528 VA: 0x2B13528
	|-List<MaterialSearchData>.Sort
	|
	|-RVA: 0x2B15F9C Offset: 0x2B11F9C VA: 0x2B15F9C
	|-List<MobActionTargetData>.Sort
	|
	|-RVA: 0x2B18B68 Offset: 0x2B14B68 VA: 0x2B18B68
	|-List<MobIconLabelData>.Sort
	|
	|-RVA: 0x2B1B278 Offset: 0x2B17278 VA: 0x2B1B278
	|-List<object>.Sort
	|
	|-RVA: 0x2B1DE2C Offset: 0x2B19E2C VA: 0x2B1DE2C
	|-List<PlayerLoopSystem>.Sort
	|
	|-RVA: 0x2B20A34 Offset: 0x2B1CA34 VA: 0x2B20A34
	|-List<PlayerLoopSystemInternal>.Sort
	|
	|-RVA: 0x2B231FC Offset: 0x2B1F1FC VA: 0x2B231FC
	|-List<RangePositionInfo>.Sort
	|
	|-RVA: 0x2B25960 Offset: 0x2B21960 VA: 0x2B25960
	|-List<ReinforceCristaData>.Sort
	|
	|-RVA: 0x2B27FB4 Offset: 0x2B23FB4 VA: 0x2B27FB4
	|-List<sbyte>.Sort
	|
	|-RVA: 0x2B2A5F8 Offset: 0x2B265F8 VA: 0x2B2A5F8
	|-List<float>.Sort
	|
	|-RVA: 0x2B2CC30 Offset: 0x2B28C30 VA: 0x2B2CC30
	|-List<SkillIdData>.Sort
	|
	|-RVA: 0x2B2F268 Offset: 0x2B2B268 VA: 0x2B2F268
	|-List<TimeSpan>.Sort
	|
	|-RVA: 0x2B55C80 Offset: 0x2B51C80 VA: 0x2B55C80
	|-List<ushort>.Sort
	|
	|-RVA: 0x2B582B4 Offset: 0x2B542B4 VA: 0x2B582B4
	|-List<uint>.Sort
	|
	|-RVA: 0x2B5A8E8 Offset: 0x2B568E8 VA: 0x2B5A8E8
	|-List<ulong>.Sort
	|
	|-RVA: 0x2B5CF8C Offset: 0x2B58F8C VA: 0x2B5CF8C
	|-List<Vector2>.Sort
	|
	|-RVA: 0x2B5F6FC Offset: 0x2B5B6FC VA: 0x2B5F6FC
	|-List<Vector3>.Sort
	|
	|-RVA: 0x2B61E88 Offset: 0x2B5DE88 VA: 0x2B61E88
	|-List<X509ChainStatus>.Sort
	|
	|-RVA: 0x2B6577C Offset: 0x2B6177C VA: 0x2B6577C
	|-List<__Il2CppFullySharedGenericType>.Sort
	|
	|-RVA: 0x2B68014 Offset: 0x2B64014 VA: 0x2B68014
	|-List<BeforeRenderHelper.OrderBlock>.Sort
	|
	|-RVA: 0x2B6AB8C Offset: 0x2B66B8C VA: 0x2B6AB8C
	|-List<BoneClip.MotionKeyFrame>.Sort
	|
	|-RVA: 0x2B6D76C Offset: 0x2B6976C VA: 0x2B6D76C
	|-List<HouseRecipeManager.RecipeData>.Sort
	|
	|-RVA: 0x2B6FE00 Offset: 0x2B6BE00 VA: 0x2B6FE00
	|-List<KadarElexioBuf.SkillIdData>.Sort
	|
	|-RVA: 0x2B7254C Offset: 0x2B6E54C VA: 0x2B7254C
	|-List<MissionTextManagerData.CheckIKeywordtemData>.Sort
	|
	|-RVA: 0x2B74CB0 Offset: 0x2B70CB0 VA: 0x2B74CB0
	|-List<MissionTextManagerData.PickUpFieldData>.Sort
	|
	|-RVA: 0x2B77358 Offset: 0x2B73358 VA: 0x2B77358
	|-List<MobaRoomData.MobaAbilityMasterData>.Sort
	|
	|-RVA: 0x2B79D10 Offset: 0x2B75D10 VA: 0x2B79D10
	|-List<NewWaveRoomData.Spotlight>.Sort
	|
	|-RVA: 0x2B7C4A8 Offset: 0x2B784A8 VA: 0x2B7C4A8
	|-List<NguiDynamicFontController.ApplyTextureInfo>.Sort
	|
	|-RVA: 0x2B7EB08 Offset: 0x2B7AB08 VA: 0x2B7EB08
	|-List<RegexCharClass.SingleRange>.Sort
	|
	|-RVA: 0x2B81270 Offset: 0x2B7D270 VA: 0x2B81270
	|-List<SocialAchievementData.LinkData>.Sort
	|
	|-RVA: 0x2B838C0 Offset: 0x2B7F8C0 VA: 0x2B838C0
	|-List<TrophyManager.TrophyData>.Sort
	|
	|-RVA: 0x2B86444 Offset: 0x2B82444 VA: 0x2B86444
	|-List<UIEventMenuButton.MessageButtonData>.Sort
	|
	|-RVA: 0x2B88E54 Offset: 0x2B84E54 VA: 0x2B88E54
	|-List<UIFieldMapPanel.PopData>.Sort
	|
	|-RVA: 0x2B8B4BC Offset: 0x2B874BC VA: 0x2B8B4BC
	|-List<UIHouseAddressManager.Town>.Sort
	|
	|-RVA: 0x2B8DE6C Offset: 0x2B89E6C VA: 0x2B8DE6C
	|-List<UIInfoWindow.LabelPosition>.Sort
	|
	|-RVA: 0x2B904D4 Offset: 0x2B8C4D4 VA: 0x2B904D4
	|-List<UIMainManager.DropItemData>.Sort
	|
	|-RVA: 0x2B92C3C Offset: 0x2B8EC3C VA: 0x2B92C3C
	|-List<UIScenarioOrderPanel.MissionData>.Sort
	|
	|-RVA: 0x2B957D4 Offset: 0x2B917D4 VA: 0x2B957D4
	|-List<UnitySynchronizationContext.WorkRequest>.Sort
	|
	|-RVA: 0x2B97F98 Offset: 0x2B93F98 VA: 0x2B97F98
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Sort
	|
	|-RVA: 0x2B9A870 Offset: 0x2B96870 VA: 0x2B9A870
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.Sort
	|
	|-RVA: 0x2B9D240 Offset: 0x2B99240 VA: 0x2B9D240
	|-List<InstructionList.DebugView.InstructionView>.Sort
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> comparison) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF074 Offset: 0x2AAB074 VA: 0x2AAF074
	|-List<KeyValuePair<ArchetypeUid, object>>.Sort
	|
	|-RVA: 0x2AB16D4 Offset: 0x2AAD6D4 VA: 0x2AB16D4
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.Sort
	|
	|-RVA: 0x2AB3D1C Offset: 0x2AAFD1C VA: 0x2AB3D1C
	|-List<KeyValuePair<byte, byte>>.Sort
	|
	|-RVA: 0x2AB6800 Offset: 0x2AB2800 VA: 0x2AB6800
	|-List<KeyValuePair<byte, object>>.Sort
	|
	|-RVA: 0x2AB8E50 Offset: 0x2AB4E50 VA: 0x2AB8E50
	|-List<KeyValuePair<int, short>>.Sort
	|
	|-RVA: 0x2ABB488 Offset: 0x2AB7488 VA: 0x2ABB488
	|-List<KeyValuePair<int, int>>.Sort
	|
	|-RVA: 0x2ABDBF0 Offset: 0x2AB9BF0 VA: 0x2ABDBF0
	|-List<KeyValuePair<int, object>>.Sort
	|
	|-RVA: 0x2AC0240 Offset: 0x2ABC240 VA: 0x2AC0240
	|-List<KeyValuePair<Int32Enum, byte>>.Sort
	|
	|-RVA: 0x2AC2CF0 Offset: 0x2ABECF0 VA: 0x2AC2CF0
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.Sort
	|
	|-RVA: 0x2AC5378 Offset: 0x2AC1378 VA: 0x2AC5378
	|-List<KeyValuePair<Int32Enum, int>>.Sort
	|
	|-RVA: 0x2AC7AE0 Offset: 0x2AC3AE0 VA: 0x2AC7AE0
	|-List<KeyValuePair<Int32Enum, object>>.Sort
	|
	|-RVA: 0x2ACA260 Offset: 0x2AC6260 VA: 0x2ACA260
	|-List<KeyValuePair<object, int>>.Sort
	|
	|-RVA: 0x2ACC9E0 Offset: 0x2AC89E0 VA: 0x2ACC9E0
	|-List<KeyValuePair<object, float>>.Sort
	|
	|-RVA: 0x2ACF160 Offset: 0x2ACB160 VA: 0x2ACF160
	|-List<KeyValuePair<float, object>>.Sort
	|
	|-RVA: 0x2AD1B74 Offset: 0x2ACDB74 VA: 0x2AD1B74
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.Sort
	|
	|-RVA: 0x2AD430C Offset: 0x2AD030C VA: 0x2AD430C
	|-List<StructMultiKey<object, object>>.Sort
	|
	|-RVA: 0x2AD696C Offset: 0x2AD296C VA: 0x2AD696C
	|-List<ValueTuple<short, short>>.Sort
	|
	|-RVA: 0x2AD8FA4 Offset: 0x2AD4FA4 VA: 0x2AD8FA4
	|-List<ValueTuple<int, int>>.Sort
	|
	|-RVA: 0x2ADB70C Offset: 0x2AD770C VA: 0x2ADB70C
	|-List<ValueTuple<int, object>>.Sort
	|
	|-RVA: 0x2ADDD5C Offset: 0x2AD9D5C VA: 0x2ADDD5C
	|-List<ValueTuple<Int32Enum, float>>.Sort
	|
	|-RVA: 0x2AE07C8 Offset: 0x2ADC7C8 VA: 0x2AE07C8
	|-List<ValueTuple<Vector3, Vector3>>.Sort
	|
	|-RVA: 0x2AE2E4C Offset: 0x2ADEE4C VA: 0x2AE2E4C
	|-List<ArchetypeUid>.Sort
	|
	|-RVA: 0x2AE54C0 Offset: 0x2AE14C0 VA: 0x2AE54C0
	|-List<bool>.Sort
	|
	|-RVA: 0x2AE7B00 Offset: 0x2AE3B00 VA: 0x2AE7B00
	|-List<byte>.Sort
	|
	|-RVA: 0x2AEA13C Offset: 0x2AE613C VA: 0x2AEA13C
	|-List<ByteEnum>.Sort
	|
	|-RVA: 0x2AEC774 Offset: 0x2AE8774 VA: 0x2AEC774
	|-List<char>.Sort
	|
	|-RVA: 0x2AEEE98 Offset: 0x2AEAE98 VA: 0x2AEEE98
	|-List<Color>.Sort
	|
	|-RVA: 0x2AF14FC Offset: 0x2AED4FC VA: 0x2AF14FC
	|-List<Color32>.Sort
	|
	|-RVA: 0x2AF3B34 Offset: 0x2AEFB34 VA: 0x2AF3B34
	|-List<DateTime>.Sort
	|
	|-RVA: 0x2AF61C4 Offset: 0x2AF21C4 VA: 0x2AF61C4
	|-List<DateTimeOffset>.Sort
	|
	|-RVA: 0x2AF88D4 Offset: 0x2AF48D4 VA: 0x2AF88D4
	|-List<Decimal>.Sort
	|
	|-RVA: 0x2AFAF14 Offset: 0x2AF6F14 VA: 0x2AFAF14
	|-List<DefencePoint2>.Sort
	|
	|-RVA: 0x2AFD558 Offset: 0x2AF9558 VA: 0x2AFD558
	|-List<double>.Sort
	|
	|-RVA: 0x2AFFCC0 Offset: 0x2AFBCC0 VA: 0x2AFFCC0
	|-List<EventSummary>.Sort
	|
	|-RVA: 0x2B02310 Offset: 0x2AFE310 VA: 0x2B02310
	|-List<short>.Sort
	|
	|-RVA: 0x2B04948 Offset: 0x2B00948 VA: 0x2B04948
	|-List<Int16Enum>.Sort
	|
	|-RVA: 0x2B06F7C Offset: 0x2B02F7C VA: 0x2B06F7C
	|-List<int>.Sort
	|
	|-RVA: 0x2B095B0 Offset: 0x2B055B0 VA: 0x2B095B0
	|-List<Int32Enum>.Sort
	|
	|-RVA: 0x2B0BBE4 Offset: 0x2B07BE4 VA: 0x2B0BBE4
	|-List<long>.Sort
	|
	|-RVA: 0x2B0E34C Offset: 0x2B0A34C VA: 0x2B0E34C
	|-List<InterpretedFrameInfo>.Sort
	|
	|-RVA: 0x2B10EE4 Offset: 0x2B0CEE4 VA: 0x2B10EE4
	|-List<JsonPosition>.Sort
	|
	|-RVA: 0x2B135D0 Offset: 0x2B0F5D0 VA: 0x2B135D0
	|-List<MaterialSearchData>.Sort
	|
	|-RVA: 0x2B16044 Offset: 0x2B12044 VA: 0x2B16044
	|-List<MobActionTargetData>.Sort
	|
	|-RVA: 0x2B18C10 Offset: 0x2B14C10 VA: 0x2B18C10
	|-List<MobIconLabelData>.Sort
	|
	|-RVA: 0x2B1B320 Offset: 0x2B17320 VA: 0x2B1B320
	|-List<object>.Sort
	|
	|-RVA: 0x2B1DED4 Offset: 0x2B19ED4 VA: 0x2B1DED4
	|-List<PlayerLoopSystem>.Sort
	|
	|-RVA: 0x2B20ADC Offset: 0x2B1CADC VA: 0x2B20ADC
	|-List<PlayerLoopSystemInternal>.Sort
	|
	|-RVA: 0x2B232A4 Offset: 0x2B1F2A4 VA: 0x2B232A4
	|-List<RangePositionInfo>.Sort
	|
	|-RVA: 0x2B25A08 Offset: 0x2B21A08 VA: 0x2B25A08
	|-List<ReinforceCristaData>.Sort
	|
	|-RVA: 0x2B2805C Offset: 0x2B2405C VA: 0x2B2805C
	|-List<sbyte>.Sort
	|
	|-RVA: 0x2B2A6A0 Offset: 0x2B266A0 VA: 0x2B2A6A0
	|-List<float>.Sort
	|
	|-RVA: 0x2B2CCD8 Offset: 0x2B28CD8 VA: 0x2B2CCD8
	|-List<SkillIdData>.Sort
	|
	|-RVA: 0x2B2F310 Offset: 0x2B2B310 VA: 0x2B2F310
	|-List<TimeSpan>.Sort
	|
	|-RVA: 0x2B55D28 Offset: 0x2B51D28 VA: 0x2B55D28
	|-List<ushort>.Sort
	|
	|-RVA: 0x2B5835C Offset: 0x2B5435C VA: 0x2B5835C
	|-List<uint>.Sort
	|
	|-RVA: 0x2B5A990 Offset: 0x2B56990 VA: 0x2B5A990
	|-List<ulong>.Sort
	|
	|-RVA: 0x2B5D034 Offset: 0x2B59034 VA: 0x2B5D034
	|-List<Vector2>.Sort
	|
	|-RVA: 0x2B5F7A4 Offset: 0x2B5B7A4 VA: 0x2B5F7A4
	|-List<Vector3>.Sort
	|
	|-RVA: 0x2B61F30 Offset: 0x2B5DF30 VA: 0x2B61F30
	|-List<X509ChainStatus>.Sort
	|
	|-RVA: 0x2B65828 Offset: 0x2B61828 VA: 0x2B65828
	|-List<__Il2CppFullySharedGenericType>.Sort
	|
	|-RVA: 0x2B680BC Offset: 0x2B640BC VA: 0x2B680BC
	|-List<BeforeRenderHelper.OrderBlock>.Sort
	|
	|-RVA: 0x2B6AC34 Offset: 0x2B66C34 VA: 0x2B6AC34
	|-List<BoneClip.MotionKeyFrame>.Sort
	|
	|-RVA: 0x2B6D814 Offset: 0x2B69814 VA: 0x2B6D814
	|-List<HouseRecipeManager.RecipeData>.Sort
	|
	|-RVA: 0x2B6FEA8 Offset: 0x2B6BEA8 VA: 0x2B6FEA8
	|-List<KadarElexioBuf.SkillIdData>.Sort
	|
	|-RVA: 0x2B725F4 Offset: 0x2B6E5F4 VA: 0x2B725F4
	|-List<MissionTextManagerData.CheckIKeywordtemData>.Sort
	|
	|-RVA: 0x2B74D58 Offset: 0x2B70D58 VA: 0x2B74D58
	|-List<MissionTextManagerData.PickUpFieldData>.Sort
	|
	|-RVA: 0x2B77400 Offset: 0x2B73400 VA: 0x2B77400
	|-List<MobaRoomData.MobaAbilityMasterData>.Sort
	|
	|-RVA: 0x2B79DB8 Offset: 0x2B75DB8 VA: 0x2B79DB8
	|-List<NewWaveRoomData.Spotlight>.Sort
	|
	|-RVA: 0x2B7C550 Offset: 0x2B78550 VA: 0x2B7C550
	|-List<NguiDynamicFontController.ApplyTextureInfo>.Sort
	|
	|-RVA: 0x2B7EBB0 Offset: 0x2B7ABB0 VA: 0x2B7EBB0
	|-List<RegexCharClass.SingleRange>.Sort
	|
	|-RVA: 0x2B81318 Offset: 0x2B7D318 VA: 0x2B81318
	|-List<SocialAchievementData.LinkData>.Sort
	|
	|-RVA: 0x2B83968 Offset: 0x2B7F968 VA: 0x2B83968
	|-List<TrophyManager.TrophyData>.Sort
	|
	|-RVA: 0x2B864EC Offset: 0x2B824EC VA: 0x2B864EC
	|-List<UIEventMenuButton.MessageButtonData>.Sort
	|
	|-RVA: 0x2B88EFC Offset: 0x2B84EFC VA: 0x2B88EFC
	|-List<UIFieldMapPanel.PopData>.Sort
	|
	|-RVA: 0x2B8B564 Offset: 0x2B87564 VA: 0x2B8B564
	|-List<UIHouseAddressManager.Town>.Sort
	|
	|-RVA: 0x2B8DF14 Offset: 0x2B89F14 VA: 0x2B8DF14
	|-List<UIInfoWindow.LabelPosition>.Sort
	|
	|-RVA: 0x2B9057C Offset: 0x2B8C57C VA: 0x2B9057C
	|-List<UIMainManager.DropItemData>.Sort
	|
	|-RVA: 0x2B92CE4 Offset: 0x2B8ECE4 VA: 0x2B92CE4
	|-List<UIScenarioOrderPanel.MissionData>.Sort
	|
	|-RVA: 0x2B9587C Offset: 0x2B9187C VA: 0x2B9587C
	|-List<UnitySynchronizationContext.WorkRequest>.Sort
	|
	|-RVA: 0x2B98040 Offset: 0x2B94040 VA: 0x2B98040
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Sort
	|
	|-RVA: 0x2B9A918 Offset: 0x2B96918 VA: 0x2B9A918
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.Sort
	|
	|-RVA: 0x2B9D2E8 Offset: 0x2B992E8 VA: 0x2B9D2E8
	|-List<InstructionList.DebugView.InstructionView>.Sort
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF108 Offset: 0x2AAB108 VA: 0x2AAF108
	|-List<KeyValuePair<ArchetypeUid, object>>.ToArray
	|
	|-RVA: 0x2AB1768 Offset: 0x2AAD768 VA: 0x2AB1768
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.ToArray
	|
	|-RVA: 0x2AB3DB0 Offset: 0x2AAFDB0 VA: 0x2AB3DB0
	|-List<KeyValuePair<byte, byte>>.ToArray
	|
	|-RVA: 0x2AB6894 Offset: 0x2AB2894 VA: 0x2AB6894
	|-List<KeyValuePair<byte, object>>.ToArray
	|
	|-RVA: 0x2AB8EE4 Offset: 0x2AB4EE4 VA: 0x2AB8EE4
	|-List<KeyValuePair<int, short>>.ToArray
	|
	|-RVA: 0x2ABB51C Offset: 0x2AB751C VA: 0x2ABB51C
	|-List<KeyValuePair<int, int>>.ToArray
	|
	|-RVA: 0x2ABDC84 Offset: 0x2AB9C84 VA: 0x2ABDC84
	|-List<KeyValuePair<int, object>>.ToArray
	|
	|-RVA: 0x2AC02D4 Offset: 0x2ABC2D4 VA: 0x2AC02D4
	|-List<KeyValuePair<Int32Enum, byte>>.ToArray
	|
	|-RVA: 0x2AC2D84 Offset: 0x2ABED84 VA: 0x2AC2D84
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.ToArray
	|
	|-RVA: 0x2AC540C Offset: 0x2AC140C VA: 0x2AC540C
	|-List<KeyValuePair<Int32Enum, int>>.ToArray
	|
	|-RVA: 0x2AC7B74 Offset: 0x2AC3B74 VA: 0x2AC7B74
	|-List<KeyValuePair<Int32Enum, object>>.ToArray
	|
	|-RVA: 0x2ACA2F4 Offset: 0x2AC62F4 VA: 0x2ACA2F4
	|-List<KeyValuePair<object, int>>.ToArray
	|
	|-RVA: 0x2ACCA74 Offset: 0x2AC8A74 VA: 0x2ACCA74
	|-List<KeyValuePair<object, float>>.ToArray
	|
	|-RVA: 0x2ACF1F4 Offset: 0x2ACB1F4 VA: 0x2ACF1F4
	|-List<KeyValuePair<float, object>>.ToArray
	|
	|-RVA: 0x2AD1C08 Offset: 0x2ACDC08 VA: 0x2AD1C08
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.ToArray
	|
	|-RVA: 0x2AD43A0 Offset: 0x2AD03A0 VA: 0x2AD43A0
	|-List<StructMultiKey<object, object>>.ToArray
	|
	|-RVA: 0x2AD6A00 Offset: 0x2AD2A00 VA: 0x2AD6A00
	|-List<ValueTuple<short, short>>.ToArray
	|
	|-RVA: 0x2AD9038 Offset: 0x2AD5038 VA: 0x2AD9038
	|-List<ValueTuple<int, int>>.ToArray
	|
	|-RVA: 0x2ADB7A0 Offset: 0x2AD77A0 VA: 0x2ADB7A0
	|-List<ValueTuple<int, object>>.ToArray
	|
	|-RVA: 0x2ADDDF0 Offset: 0x2AD9DF0 VA: 0x2ADDDF0
	|-List<ValueTuple<Int32Enum, float>>.ToArray
	|
	|-RVA: 0x2AE085C Offset: 0x2ADC85C VA: 0x2AE085C
	|-List<ValueTuple<Vector3, Vector3>>.ToArray
	|
	|-RVA: 0x2AE2EE0 Offset: 0x2ADEEE0 VA: 0x2AE2EE0
	|-List<ArchetypeUid>.ToArray
	|
	|-RVA: 0x2AE5554 Offset: 0x2AE1554 VA: 0x2AE5554
	|-List<bool>.ToArray
	|
	|-RVA: 0x2AE7B94 Offset: 0x2AE3B94 VA: 0x2AE7B94
	|-List<byte>.ToArray
	|
	|-RVA: 0x2AEA1D0 Offset: 0x2AE61D0 VA: 0x2AEA1D0
	|-List<ByteEnum>.ToArray
	|
	|-RVA: 0x2AEC808 Offset: 0x2AE8808 VA: 0x2AEC808
	|-List<char>.ToArray
	|
	|-RVA: 0x2AEEF2C Offset: 0x2AEAF2C VA: 0x2AEEF2C
	|-List<Color>.ToArray
	|
	|-RVA: 0x2AF1590 Offset: 0x2AED590 VA: 0x2AF1590
	|-List<Color32>.ToArray
	|
	|-RVA: 0x2AF3BC8 Offset: 0x2AEFBC8 VA: 0x2AF3BC8
	|-List<DateTime>.ToArray
	|
	|-RVA: 0x2AF6258 Offset: 0x2AF2258 VA: 0x2AF6258
	|-List<DateTimeOffset>.ToArray
	|
	|-RVA: 0x2AF8968 Offset: 0x2AF4968 VA: 0x2AF8968
	|-List<Decimal>.ToArray
	|
	|-RVA: 0x2AFAFA8 Offset: 0x2AF6FA8 VA: 0x2AFAFA8
	|-List<DefencePoint2>.ToArray
	|
	|-RVA: 0x2AFD5EC Offset: 0x2AF95EC VA: 0x2AFD5EC
	|-List<double>.ToArray
	|
	|-RVA: 0x2AFFD54 Offset: 0x2AFBD54 VA: 0x2AFFD54
	|-List<EventSummary>.ToArray
	|
	|-RVA: 0x2B023A4 Offset: 0x2AFE3A4 VA: 0x2B023A4
	|-List<short>.ToArray
	|
	|-RVA: 0x2B049DC Offset: 0x2B009DC VA: 0x2B049DC
	|-List<Int16Enum>.ToArray
	|
	|-RVA: 0x2B07010 Offset: 0x2B03010 VA: 0x2B07010
	|-List<int>.ToArray
	|
	|-RVA: 0x2B09644 Offset: 0x2B05644 VA: 0x2B09644
	|-List<Int32Enum>.ToArray
	|
	|-RVA: 0x2B0BC78 Offset: 0x2B07C78 VA: 0x2B0BC78
	|-List<long>.ToArray
	|
	|-RVA: 0x2B0E3E0 Offset: 0x2B0A3E0 VA: 0x2B0E3E0
	|-List<InterpretedFrameInfo>.ToArray
	|
	|-RVA: 0x2B10F78 Offset: 0x2B0CF78 VA: 0x2B10F78
	|-List<JsonPosition>.ToArray
	|
	|-RVA: 0x2B13664 Offset: 0x2B0F664 VA: 0x2B13664
	|-List<MaterialSearchData>.ToArray
	|
	|-RVA: 0x2B160D8 Offset: 0x2B120D8 VA: 0x2B160D8
	|-List<MobActionTargetData>.ToArray
	|
	|-RVA: 0x2B18CA4 Offset: 0x2B14CA4 VA: 0x2B18CA4
	|-List<MobIconLabelData>.ToArray
	|
	|-RVA: 0x2B1B3B4 Offset: 0x2B173B4 VA: 0x2B1B3B4
	|-List<object>.ToArray
	|
	|-RVA: 0x2B1DF68 Offset: 0x2B19F68 VA: 0x2B1DF68
	|-List<PlayerLoopSystem>.ToArray
	|
	|-RVA: 0x2B20B70 Offset: 0x2B1CB70 VA: 0x2B20B70
	|-List<PlayerLoopSystemInternal>.ToArray
	|
	|-RVA: 0x2B23338 Offset: 0x2B1F338 VA: 0x2B23338
	|-List<RangePositionInfo>.ToArray
	|
	|-RVA: 0x2B25A9C Offset: 0x2B21A9C VA: 0x2B25A9C
	|-List<ReinforceCristaData>.ToArray
	|
	|-RVA: 0x2B280F0 Offset: 0x2B240F0 VA: 0x2B280F0
	|-List<sbyte>.ToArray
	|
	|-RVA: 0x2B2A734 Offset: 0x2B26734 VA: 0x2B2A734
	|-List<float>.ToArray
	|
	|-RVA: 0x2B2CD6C Offset: 0x2B28D6C VA: 0x2B2CD6C
	|-List<SkillIdData>.ToArray
	|
	|-RVA: 0x2B2F3A4 Offset: 0x2B2B3A4 VA: 0x2B2F3A4
	|-List<TimeSpan>.ToArray
	|
	|-RVA: 0x2B55DBC Offset: 0x2B51DBC VA: 0x2B55DBC
	|-List<ushort>.ToArray
	|
	|-RVA: 0x2B583F0 Offset: 0x2B543F0 VA: 0x2B583F0
	|-List<uint>.ToArray
	|
	|-RVA: 0x2B5AA24 Offset: 0x2B56A24 VA: 0x2B5AA24
	|-List<ulong>.ToArray
	|
	|-RVA: 0x2B5D0C8 Offset: 0x2B590C8 VA: 0x2B5D0C8
	|-List<Vector2>.ToArray
	|
	|-RVA: 0x2B5F838 Offset: 0x2B5B838 VA: 0x2B5F838
	|-List<Vector3>.ToArray
	|
	|-RVA: 0x2B61FC4 Offset: 0x2B5DFC4 VA: 0x2B61FC4
	|-List<X509ChainStatus>.ToArray
	|
	|-RVA: 0x2B658C0 Offset: 0x2B618C0 VA: 0x2B658C0
	|-List<__Il2CppFullySharedGenericType>.ToArray
	|
	|-RVA: 0x2B68150 Offset: 0x2B64150 VA: 0x2B68150
	|-List<BeforeRenderHelper.OrderBlock>.ToArray
	|
	|-RVA: 0x2B6ACC8 Offset: 0x2B66CC8 VA: 0x2B6ACC8
	|-List<BoneClip.MotionKeyFrame>.ToArray
	|
	|-RVA: 0x2B6D8A8 Offset: 0x2B698A8 VA: 0x2B6D8A8
	|-List<HouseRecipeManager.RecipeData>.ToArray
	|
	|-RVA: 0x2B6FF3C Offset: 0x2B6BF3C VA: 0x2B6FF3C
	|-List<KadarElexioBuf.SkillIdData>.ToArray
	|
	|-RVA: 0x2B72688 Offset: 0x2B6E688 VA: 0x2B72688
	|-List<MissionTextManagerData.CheckIKeywordtemData>.ToArray
	|
	|-RVA: 0x2B74DEC Offset: 0x2B70DEC VA: 0x2B74DEC
	|-List<MissionTextManagerData.PickUpFieldData>.ToArray
	|
	|-RVA: 0x2B77494 Offset: 0x2B73494 VA: 0x2B77494
	|-List<MobaRoomData.MobaAbilityMasterData>.ToArray
	|
	|-RVA: 0x2B79E4C Offset: 0x2B75E4C VA: 0x2B79E4C
	|-List<NewWaveRoomData.Spotlight>.ToArray
	|
	|-RVA: 0x2B7C5E4 Offset: 0x2B785E4 VA: 0x2B7C5E4
	|-List<NguiDynamicFontController.ApplyTextureInfo>.ToArray
	|
	|-RVA: 0x2B7EC44 Offset: 0x2B7AC44 VA: 0x2B7EC44
	|-List<RegexCharClass.SingleRange>.ToArray
	|
	|-RVA: 0x2B813AC Offset: 0x2B7D3AC VA: 0x2B813AC
	|-List<SocialAchievementData.LinkData>.ToArray
	|
	|-RVA: 0x2B839FC Offset: 0x2B7F9FC VA: 0x2B839FC
	|-List<TrophyManager.TrophyData>.ToArray
	|
	|-RVA: 0x2B86580 Offset: 0x2B82580 VA: 0x2B86580
	|-List<UIEventMenuButton.MessageButtonData>.ToArray
	|
	|-RVA: 0x2B88F90 Offset: 0x2B84F90 VA: 0x2B88F90
	|-List<UIFieldMapPanel.PopData>.ToArray
	|
	|-RVA: 0x2B8B5F8 Offset: 0x2B875F8 VA: 0x2B8B5F8
	|-List<UIHouseAddressManager.Town>.ToArray
	|
	|-RVA: 0x2B8DFA8 Offset: 0x2B89FA8 VA: 0x2B8DFA8
	|-List<UIInfoWindow.LabelPosition>.ToArray
	|
	|-RVA: 0x2B90610 Offset: 0x2B8C610 VA: 0x2B90610
	|-List<UIMainManager.DropItemData>.ToArray
	|
	|-RVA: 0x2B92D78 Offset: 0x2B8ED78 VA: 0x2B92D78
	|-List<UIScenarioOrderPanel.MissionData>.ToArray
	|
	|-RVA: 0x2B95910 Offset: 0x2B91910 VA: 0x2B95910
	|-List<UnitySynchronizationContext.WorkRequest>.ToArray
	|
	|-RVA: 0x2B980D4 Offset: 0x2B940D4 VA: 0x2B980D4
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.ToArray
	|
	|-RVA: 0x2B9A9AC Offset: 0x2B969AC VA: 0x2B9A9AC
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.ToArray
	|
	|-RVA: 0x2B9D37C Offset: 0x2B9937C VA: 0x2B9D37C
	|-List<InstructionList.DebugView.InstructionView>.ToArray
	*/

	// RVA: -1 Offset: -1
	public void TrimExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF1B4 Offset: 0x2AAB1B4 VA: 0x2AAF1B4
	|-List<KeyValuePair<ArchetypeUid, object>>.TrimExcess
	|
	|-RVA: 0x2AB1814 Offset: 0x2AAD814 VA: 0x2AB1814
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.TrimExcess
	|
	|-RVA: 0x2AB3E5C Offset: 0x2AAFE5C VA: 0x2AB3E5C
	|-List<KeyValuePair<byte, byte>>.TrimExcess
	|
	|-RVA: 0x2AB6940 Offset: 0x2AB2940 VA: 0x2AB6940
	|-List<KeyValuePair<byte, object>>.TrimExcess
	|
	|-RVA: 0x2AB8F90 Offset: 0x2AB4F90 VA: 0x2AB8F90
	|-List<KeyValuePair<int, short>>.TrimExcess
	|
	|-RVA: 0x2ABB5C8 Offset: 0x2AB75C8 VA: 0x2ABB5C8
	|-List<KeyValuePair<int, int>>.TrimExcess
	|
	|-RVA: 0x2ABDD30 Offset: 0x2AB9D30 VA: 0x2ABDD30
	|-List<KeyValuePair<int, object>>.TrimExcess
	|
	|-RVA: 0x2AC0380 Offset: 0x2ABC380 VA: 0x2AC0380
	|-List<KeyValuePair<Int32Enum, byte>>.TrimExcess
	|
	|-RVA: 0x2AC2E30 Offset: 0x2ABEE30 VA: 0x2AC2E30
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.TrimExcess
	|
	|-RVA: 0x2AC54B8 Offset: 0x2AC14B8 VA: 0x2AC54B8
	|-List<KeyValuePair<Int32Enum, int>>.TrimExcess
	|
	|-RVA: 0x2AC7C20 Offset: 0x2AC3C20 VA: 0x2AC7C20
	|-List<KeyValuePair<Int32Enum, object>>.TrimExcess
	|
	|-RVA: 0x2ACA3A0 Offset: 0x2AC63A0 VA: 0x2ACA3A0
	|-List<KeyValuePair<object, int>>.TrimExcess
	|
	|-RVA: 0x2ACCB20 Offset: 0x2AC8B20 VA: 0x2ACCB20
	|-List<KeyValuePair<object, float>>.TrimExcess
	|
	|-RVA: 0x2ACF2A0 Offset: 0x2ACB2A0 VA: 0x2ACF2A0
	|-List<KeyValuePair<float, object>>.TrimExcess
	|
	|-RVA: 0x2AD1CB4 Offset: 0x2ACDCB4 VA: 0x2AD1CB4
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.TrimExcess
	|
	|-RVA: 0x2AD444C Offset: 0x2AD044C VA: 0x2AD444C
	|-List<StructMultiKey<object, object>>.TrimExcess
	|
	|-RVA: 0x2AD6AAC Offset: 0x2AD2AAC VA: 0x2AD6AAC
	|-List<ValueTuple<short, short>>.TrimExcess
	|
	|-RVA: 0x2AD90E4 Offset: 0x2AD50E4 VA: 0x2AD90E4
	|-List<ValueTuple<int, int>>.TrimExcess
	|
	|-RVA: 0x2ADB84C Offset: 0x2AD784C VA: 0x2ADB84C
	|-List<ValueTuple<int, object>>.TrimExcess
	|
	|-RVA: 0x2ADDE9C Offset: 0x2AD9E9C VA: 0x2ADDE9C
	|-List<ValueTuple<Int32Enum, float>>.TrimExcess
	|
	|-RVA: 0x2AE0908 Offset: 0x2ADC908 VA: 0x2AE0908
	|-List<ValueTuple<Vector3, Vector3>>.TrimExcess
	|
	|-RVA: 0x2AE2F8C Offset: 0x2ADEF8C VA: 0x2AE2F8C
	|-List<ArchetypeUid>.TrimExcess
	|
	|-RVA: 0x2AE5600 Offset: 0x2AE1600 VA: 0x2AE5600
	|-List<bool>.TrimExcess
	|
	|-RVA: 0x2AE7C40 Offset: 0x2AE3C40 VA: 0x2AE7C40
	|-List<byte>.TrimExcess
	|
	|-RVA: 0x2AEA27C Offset: 0x2AE627C VA: 0x2AEA27C
	|-List<ByteEnum>.TrimExcess
	|
	|-RVA: 0x2AEC8B4 Offset: 0x2AE88B4 VA: 0x2AEC8B4
	|-List<char>.TrimExcess
	|
	|-RVA: 0x2AEEFD8 Offset: 0x2AEAFD8 VA: 0x2AEEFD8
	|-List<Color>.TrimExcess
	|
	|-RVA: 0x2AF163C Offset: 0x2AED63C VA: 0x2AF163C
	|-List<Color32>.TrimExcess
	|
	|-RVA: 0x2AF3C74 Offset: 0x2AEFC74 VA: 0x2AF3C74
	|-List<DateTime>.TrimExcess
	|
	|-RVA: 0x2AF6304 Offset: 0x2AF2304 VA: 0x2AF6304
	|-List<DateTimeOffset>.TrimExcess
	|
	|-RVA: 0x2AF8A14 Offset: 0x2AF4A14 VA: 0x2AF8A14
	|-List<Decimal>.TrimExcess
	|
	|-RVA: 0x2AFB054 Offset: 0x2AF7054 VA: 0x2AFB054
	|-List<DefencePoint2>.TrimExcess
	|
	|-RVA: 0x2AFD698 Offset: 0x2AF9698 VA: 0x2AFD698
	|-List<double>.TrimExcess
	|
	|-RVA: 0x2AFFE00 Offset: 0x2AFBE00 VA: 0x2AFFE00
	|-List<EventSummary>.TrimExcess
	|
	|-RVA: 0x2B02450 Offset: 0x2AFE450 VA: 0x2B02450
	|-List<short>.TrimExcess
	|
	|-RVA: 0x2B04A88 Offset: 0x2B00A88 VA: 0x2B04A88
	|-List<Int16Enum>.TrimExcess
	|
	|-RVA: 0x2B070BC Offset: 0x2B030BC VA: 0x2B070BC
	|-List<int>.TrimExcess
	|
	|-RVA: 0x2B096F0 Offset: 0x2B056F0 VA: 0x2B096F0
	|-List<Int32Enum>.TrimExcess
	|
	|-RVA: 0x2B0BD24 Offset: 0x2B07D24 VA: 0x2B0BD24
	|-List<long>.TrimExcess
	|
	|-RVA: 0x2B0E48C Offset: 0x2B0A48C VA: 0x2B0E48C
	|-List<InterpretedFrameInfo>.TrimExcess
	|
	|-RVA: 0x2B11024 Offset: 0x2B0D024 VA: 0x2B11024
	|-List<JsonPosition>.TrimExcess
	|
	|-RVA: 0x2B13710 Offset: 0x2B0F710 VA: 0x2B13710
	|-List<MaterialSearchData>.TrimExcess
	|
	|-RVA: 0x2B16184 Offset: 0x2B12184 VA: 0x2B16184
	|-List<MobActionTargetData>.TrimExcess
	|
	|-RVA: 0x2B18D50 Offset: 0x2B14D50 VA: 0x2B18D50
	|-List<MobIconLabelData>.TrimExcess
	|
	|-RVA: 0x2B1B460 Offset: 0x2B17460 VA: 0x2B1B460
	|-List<object>.TrimExcess
	|
	|-RVA: 0x2B1E014 Offset: 0x2B1A014 VA: 0x2B1E014
	|-List<PlayerLoopSystem>.TrimExcess
	|
	|-RVA: 0x2B20C1C Offset: 0x2B1CC1C VA: 0x2B20C1C
	|-List<PlayerLoopSystemInternal>.TrimExcess
	|
	|-RVA: 0x2B233E4 Offset: 0x2B1F3E4 VA: 0x2B233E4
	|-List<RangePositionInfo>.TrimExcess
	|
	|-RVA: 0x2B25B48 Offset: 0x2B21B48 VA: 0x2B25B48
	|-List<ReinforceCristaData>.TrimExcess
	|
	|-RVA: 0x2B2819C Offset: 0x2B2419C VA: 0x2B2819C
	|-List<sbyte>.TrimExcess
	|
	|-RVA: 0x2B2A7E0 Offset: 0x2B267E0 VA: 0x2B2A7E0
	|-List<float>.TrimExcess
	|
	|-RVA: 0x2B2CE18 Offset: 0x2B28E18 VA: 0x2B2CE18
	|-List<SkillIdData>.TrimExcess
	|
	|-RVA: 0x2B2F450 Offset: 0x2B2B450 VA: 0x2B2F450
	|-List<TimeSpan>.TrimExcess
	|
	|-RVA: 0x2B55E68 Offset: 0x2B51E68 VA: 0x2B55E68
	|-List<ushort>.TrimExcess
	|
	|-RVA: 0x2B5849C Offset: 0x2B5449C VA: 0x2B5849C
	|-List<uint>.TrimExcess
	|
	|-RVA: 0x2B5AAD0 Offset: 0x2B56AD0 VA: 0x2B5AAD0
	|-List<ulong>.TrimExcess
	|
	|-RVA: 0x2B5D174 Offset: 0x2B59174 VA: 0x2B5D174
	|-List<Vector2>.TrimExcess
	|
	|-RVA: 0x2B5F8E4 Offset: 0x2B5B8E4 VA: 0x2B5F8E4
	|-List<Vector3>.TrimExcess
	|
	|-RVA: 0x2B62070 Offset: 0x2B5E070 VA: 0x2B62070
	|-List<X509ChainStatus>.TrimExcess
	|
	|-RVA: 0x2B6596C Offset: 0x2B6196C VA: 0x2B6596C
	|-List<__Il2CppFullySharedGenericType>.TrimExcess
	|
	|-RVA: 0x2B681FC Offset: 0x2B641FC VA: 0x2B681FC
	|-List<BeforeRenderHelper.OrderBlock>.TrimExcess
	|
	|-RVA: 0x2B6AD74 Offset: 0x2B66D74 VA: 0x2B6AD74
	|-List<BoneClip.MotionKeyFrame>.TrimExcess
	|
	|-RVA: 0x2B6D954 Offset: 0x2B69954 VA: 0x2B6D954
	|-List<HouseRecipeManager.RecipeData>.TrimExcess
	|
	|-RVA: 0x2B6FFE8 Offset: 0x2B6BFE8 VA: 0x2B6FFE8
	|-List<KadarElexioBuf.SkillIdData>.TrimExcess
	|
	|-RVA: 0x2B72734 Offset: 0x2B6E734 VA: 0x2B72734
	|-List<MissionTextManagerData.CheckIKeywordtemData>.TrimExcess
	|
	|-RVA: 0x2B74E98 Offset: 0x2B70E98 VA: 0x2B74E98
	|-List<MissionTextManagerData.PickUpFieldData>.TrimExcess
	|
	|-RVA: 0x2B77540 Offset: 0x2B73540 VA: 0x2B77540
	|-List<MobaRoomData.MobaAbilityMasterData>.TrimExcess
	|
	|-RVA: 0x2B79EF8 Offset: 0x2B75EF8 VA: 0x2B79EF8
	|-List<NewWaveRoomData.Spotlight>.TrimExcess
	|
	|-RVA: 0x2B7C690 Offset: 0x2B78690 VA: 0x2B7C690
	|-List<NguiDynamicFontController.ApplyTextureInfo>.TrimExcess
	|
	|-RVA: 0x2B7ECF0 Offset: 0x2B7ACF0 VA: 0x2B7ECF0
	|-List<RegexCharClass.SingleRange>.TrimExcess
	|
	|-RVA: 0x2B81458 Offset: 0x2B7D458 VA: 0x2B81458
	|-List<SocialAchievementData.LinkData>.TrimExcess
	|
	|-RVA: 0x2B83AA8 Offset: 0x2B7FAA8 VA: 0x2B83AA8
	|-List<TrophyManager.TrophyData>.TrimExcess
	|
	|-RVA: 0x2B8662C Offset: 0x2B8262C VA: 0x2B8662C
	|-List<UIEventMenuButton.MessageButtonData>.TrimExcess
	|
	|-RVA: 0x2B8903C Offset: 0x2B8503C VA: 0x2B8903C
	|-List<UIFieldMapPanel.PopData>.TrimExcess
	|
	|-RVA: 0x2B8B6A4 Offset: 0x2B876A4 VA: 0x2B8B6A4
	|-List<UIHouseAddressManager.Town>.TrimExcess
	|
	|-RVA: 0x2B8E054 Offset: 0x2B8A054 VA: 0x2B8E054
	|-List<UIInfoWindow.LabelPosition>.TrimExcess
	|
	|-RVA: 0x2B906BC Offset: 0x2B8C6BC VA: 0x2B906BC
	|-List<UIMainManager.DropItemData>.TrimExcess
	|
	|-RVA: 0x2B92E24 Offset: 0x2B8EE24 VA: 0x2B92E24
	|-List<UIScenarioOrderPanel.MissionData>.TrimExcess
	|
	|-RVA: 0x2B959BC Offset: 0x2B919BC VA: 0x2B959BC
	|-List<UnitySynchronizationContext.WorkRequest>.TrimExcess
	|
	|-RVA: 0x2B98180 Offset: 0x2B94180 VA: 0x2B98180
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.TrimExcess
	|
	|-RVA: 0x2B9AA58 Offset: 0x2B96A58 VA: 0x2B9AA58
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.TrimExcess
	|
	|-RVA: 0x2B9D428 Offset: 0x2B99428 VA: 0x2B9D428
	|-List<InstructionList.DebugView.InstructionView>.TrimExcess
	*/

	// RVA: -1 Offset: -1
	private void AddEnumerable(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF21C Offset: 0x2AAB21C VA: 0x2AAF21C
	|-List<KeyValuePair<ArchetypeUid, object>>.AddEnumerable
	|
	|-RVA: 0x2AB187C Offset: 0x2AAD87C VA: 0x2AB187C
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>.AddEnumerable
	|
	|-RVA: 0x2AB3EC4 Offset: 0x2AAFEC4 VA: 0x2AB3EC4
	|-List<KeyValuePair<byte, byte>>.AddEnumerable
	|
	|-RVA: 0x2AB69A8 Offset: 0x2AB29A8 VA: 0x2AB69A8
	|-List<KeyValuePair<byte, object>>.AddEnumerable
	|
	|-RVA: 0x2AB8FF8 Offset: 0x2AB4FF8 VA: 0x2AB8FF8
	|-List<KeyValuePair<int, short>>.AddEnumerable
	|
	|-RVA: 0x2ABB630 Offset: 0x2AB7630 VA: 0x2ABB630
	|-List<KeyValuePair<int, int>>.AddEnumerable
	|
	|-RVA: 0x2ABDD98 Offset: 0x2AB9D98 VA: 0x2ABDD98
	|-List<KeyValuePair<int, object>>.AddEnumerable
	|
	|-RVA: 0x2AC03E8 Offset: 0x2ABC3E8 VA: 0x2AC03E8
	|-List<KeyValuePair<Int32Enum, byte>>.AddEnumerable
	|
	|-RVA: 0x2AC2E98 Offset: 0x2ABEE98 VA: 0x2AC2E98
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>.AddEnumerable
	|
	|-RVA: 0x2AC5520 Offset: 0x2AC1520 VA: 0x2AC5520
	|-List<KeyValuePair<Int32Enum, int>>.AddEnumerable
	|
	|-RVA: 0x2AC7C88 Offset: 0x2AC3C88 VA: 0x2AC7C88
	|-List<KeyValuePair<Int32Enum, object>>.AddEnumerable
	|
	|-RVA: 0x2ACA408 Offset: 0x2AC6408 VA: 0x2ACA408
	|-List<KeyValuePair<object, int>>.AddEnumerable
	|
	|-RVA: 0x2ACCB88 Offset: 0x2AC8B88 VA: 0x2ACCB88
	|-List<KeyValuePair<object, float>>.AddEnumerable
	|
	|-RVA: 0x2ACF308 Offset: 0x2ACB308 VA: 0x2ACF308
	|-List<KeyValuePair<float, object>>.AddEnumerable
	|
	|-RVA: 0x2AD1D1C Offset: 0x2ACDD1C VA: 0x2AD1D1C
	|-List<Nullable<UIMobPropertyLabel.IconValue>>.AddEnumerable
	|
	|-RVA: 0x2AD44B4 Offset: 0x2AD04B4 VA: 0x2AD44B4
	|-List<StructMultiKey<object, object>>.AddEnumerable
	|
	|-RVA: 0x2AD6B14 Offset: 0x2AD2B14 VA: 0x2AD6B14
	|-List<ValueTuple<short, short>>.AddEnumerable
	|
	|-RVA: 0x2AD914C Offset: 0x2AD514C VA: 0x2AD914C
	|-List<ValueTuple<int, int>>.AddEnumerable
	|
	|-RVA: 0x2ADB8B4 Offset: 0x2AD78B4 VA: 0x2ADB8B4
	|-List<ValueTuple<int, object>>.AddEnumerable
	|
	|-RVA: 0x2ADDF04 Offset: 0x2AD9F04 VA: 0x2ADDF04
	|-List<ValueTuple<Int32Enum, float>>.AddEnumerable
	|
	|-RVA: 0x2AE0970 Offset: 0x2ADC970 VA: 0x2AE0970
	|-List<ValueTuple<Vector3, Vector3>>.AddEnumerable
	|
	|-RVA: 0x2AE2FF4 Offset: 0x2ADEFF4 VA: 0x2AE2FF4
	|-List<ArchetypeUid>.AddEnumerable
	|
	|-RVA: 0x2AE5668 Offset: 0x2AE1668 VA: 0x2AE5668
	|-List<bool>.AddEnumerable
	|
	|-RVA: 0x2AE7CA8 Offset: 0x2AE3CA8 VA: 0x2AE7CA8
	|-List<byte>.AddEnumerable
	|
	|-RVA: 0x2AEA2E4 Offset: 0x2AE62E4 VA: 0x2AEA2E4
	|-List<ByteEnum>.AddEnumerable
	|
	|-RVA: 0x2AEC91C Offset: 0x2AE891C VA: 0x2AEC91C
	|-List<char>.AddEnumerable
	|
	|-RVA: 0x2AEF040 Offset: 0x2AEB040 VA: 0x2AEF040
	|-List<Color>.AddEnumerable
	|
	|-RVA: 0x2AF16A4 Offset: 0x2AED6A4 VA: 0x2AF16A4
	|-List<Color32>.AddEnumerable
	|
	|-RVA: 0x2AF3CDC Offset: 0x2AEFCDC VA: 0x2AF3CDC
	|-List<DateTime>.AddEnumerable
	|
	|-RVA: 0x2AF636C Offset: 0x2AF236C VA: 0x2AF636C
	|-List<DateTimeOffset>.AddEnumerable
	|
	|-RVA: 0x2AF8A7C Offset: 0x2AF4A7C VA: 0x2AF8A7C
	|-List<Decimal>.AddEnumerable
	|
	|-RVA: 0x2AFB0BC Offset: 0x2AF70BC VA: 0x2AFB0BC
	|-List<DefencePoint2>.AddEnumerable
	|
	|-RVA: 0x2AFD700 Offset: 0x2AF9700 VA: 0x2AFD700
	|-List<double>.AddEnumerable
	|
	|-RVA: 0x2AFFE68 Offset: 0x2AFBE68 VA: 0x2AFFE68
	|-List<EventSummary>.AddEnumerable
	|
	|-RVA: 0x2B024B8 Offset: 0x2AFE4B8 VA: 0x2B024B8
	|-List<short>.AddEnumerable
	|
	|-RVA: 0x2B04AF0 Offset: 0x2B00AF0 VA: 0x2B04AF0
	|-List<Int16Enum>.AddEnumerable
	|
	|-RVA: 0x2B07124 Offset: 0x2B03124 VA: 0x2B07124
	|-List<int>.AddEnumerable
	|
	|-RVA: 0x2B09758 Offset: 0x2B05758 VA: 0x2B09758
	|-List<Int32Enum>.AddEnumerable
	|
	|-RVA: 0x2B0BD8C Offset: 0x2B07D8C VA: 0x2B0BD8C
	|-List<long>.AddEnumerable
	|
	|-RVA: 0x2B0E4F4 Offset: 0x2B0A4F4 VA: 0x2B0E4F4
	|-List<InterpretedFrameInfo>.AddEnumerable
	|
	|-RVA: 0x2B1108C Offset: 0x2B0D08C VA: 0x2B1108C
	|-List<JsonPosition>.AddEnumerable
	|
	|-RVA: 0x2B13778 Offset: 0x2B0F778 VA: 0x2B13778
	|-List<MaterialSearchData>.AddEnumerable
	|
	|-RVA: 0x2B161EC Offset: 0x2B121EC VA: 0x2B161EC
	|-List<MobActionTargetData>.AddEnumerable
	|
	|-RVA: 0x2B18DB8 Offset: 0x2B14DB8 VA: 0x2B18DB8
	|-List<MobIconLabelData>.AddEnumerable
	|
	|-RVA: 0x2B1B4C8 Offset: 0x2B174C8 VA: 0x2B1B4C8
	|-List<object>.AddEnumerable
	|
	|-RVA: 0x2B1E07C Offset: 0x2B1A07C VA: 0x2B1E07C
	|-List<PlayerLoopSystem>.AddEnumerable
	|
	|-RVA: 0x2B20C84 Offset: 0x2B1CC84 VA: 0x2B20C84
	|-List<PlayerLoopSystemInternal>.AddEnumerable
	|
	|-RVA: 0x2B2344C Offset: 0x2B1F44C VA: 0x2B2344C
	|-List<RangePositionInfo>.AddEnumerable
	|
	|-RVA: 0x2B25BB0 Offset: 0x2B21BB0 VA: 0x2B25BB0
	|-List<ReinforceCristaData>.AddEnumerable
	|
	|-RVA: 0x2B28204 Offset: 0x2B24204 VA: 0x2B28204
	|-List<sbyte>.AddEnumerable
	|
	|-RVA: 0x2B2A848 Offset: 0x2B26848 VA: 0x2B2A848
	|-List<float>.AddEnumerable
	|
	|-RVA: 0x2B2CE80 Offset: 0x2B28E80 VA: 0x2B2CE80
	|-List<SkillIdData>.AddEnumerable
	|
	|-RVA: 0x2B2F4B8 Offset: 0x2B2B4B8 VA: 0x2B2F4B8
	|-List<TimeSpan>.AddEnumerable
	|
	|-RVA: 0x2B55ED0 Offset: 0x2B51ED0 VA: 0x2B55ED0
	|-List<ushort>.AddEnumerable
	|
	|-RVA: 0x2B58504 Offset: 0x2B54504 VA: 0x2B58504
	|-List<uint>.AddEnumerable
	|
	|-RVA: 0x2B5AB38 Offset: 0x2B56B38 VA: 0x2B5AB38
	|-List<ulong>.AddEnumerable
	|
	|-RVA: 0x2B5D1DC Offset: 0x2B591DC VA: 0x2B5D1DC
	|-List<Vector2>.AddEnumerable
	|
	|-RVA: 0x2B5F94C Offset: 0x2B5B94C VA: 0x2B5F94C
	|-List<Vector3>.AddEnumerable
	|
	|-RVA: 0x2B620D8 Offset: 0x2B5E0D8 VA: 0x2B620D8
	|-List<X509ChainStatus>.AddEnumerable
	|
	|-RVA: 0x2B659D8 Offset: 0x2B619D8 VA: 0x2B659D8
	|-List<__Il2CppFullySharedGenericType>.AddEnumerable
	|
	|-RVA: 0x2B68264 Offset: 0x2B64264 VA: 0x2B68264
	|-List<BeforeRenderHelper.OrderBlock>.AddEnumerable
	|
	|-RVA: 0x2B6ADDC Offset: 0x2B66DDC VA: 0x2B6ADDC
	|-List<BoneClip.MotionKeyFrame>.AddEnumerable
	|
	|-RVA: 0x2B6D9BC Offset: 0x2B699BC VA: 0x2B6D9BC
	|-List<HouseRecipeManager.RecipeData>.AddEnumerable
	|
	|-RVA: 0x2B70050 Offset: 0x2B6C050 VA: 0x2B70050
	|-List<KadarElexioBuf.SkillIdData>.AddEnumerable
	|
	|-RVA: 0x2B7279C Offset: 0x2B6E79C VA: 0x2B7279C
	|-List<MissionTextManagerData.CheckIKeywordtemData>.AddEnumerable
	|
	|-RVA: 0x2B74F00 Offset: 0x2B70F00 VA: 0x2B74F00
	|-List<MissionTextManagerData.PickUpFieldData>.AddEnumerable
	|
	|-RVA: 0x2B775A8 Offset: 0x2B735A8 VA: 0x2B775A8
	|-List<MobaRoomData.MobaAbilityMasterData>.AddEnumerable
	|
	|-RVA: 0x2B79F60 Offset: 0x2B75F60 VA: 0x2B79F60
	|-List<NewWaveRoomData.Spotlight>.AddEnumerable
	|
	|-RVA: 0x2B7C6F8 Offset: 0x2B786F8 VA: 0x2B7C6F8
	|-List<NguiDynamicFontController.ApplyTextureInfo>.AddEnumerable
	|
	|-RVA: 0x2B7ED58 Offset: 0x2B7AD58 VA: 0x2B7ED58
	|-List<RegexCharClass.SingleRange>.AddEnumerable
	|
	|-RVA: 0x2B814C0 Offset: 0x2B7D4C0 VA: 0x2B814C0
	|-List<SocialAchievementData.LinkData>.AddEnumerable
	|
	|-RVA: 0x2B83B10 Offset: 0x2B7FB10 VA: 0x2B83B10
	|-List<TrophyManager.TrophyData>.AddEnumerable
	|
	|-RVA: 0x2B86694 Offset: 0x2B82694 VA: 0x2B86694
	|-List<UIEventMenuButton.MessageButtonData>.AddEnumerable
	|
	|-RVA: 0x2B890A4 Offset: 0x2B850A4 VA: 0x2B890A4
	|-List<UIFieldMapPanel.PopData>.AddEnumerable
	|
	|-RVA: 0x2B8B70C Offset: 0x2B8770C VA: 0x2B8B70C
	|-List<UIHouseAddressManager.Town>.AddEnumerable
	|
	|-RVA: 0x2B8E0BC Offset: 0x2B8A0BC VA: 0x2B8E0BC
	|-List<UIInfoWindow.LabelPosition>.AddEnumerable
	|
	|-RVA: 0x2B90724 Offset: 0x2B8C724 VA: 0x2B90724
	|-List<UIMainManager.DropItemData>.AddEnumerable
	|
	|-RVA: 0x2B92E8C Offset: 0x2B8EE8C VA: 0x2B92E8C
	|-List<UIScenarioOrderPanel.MissionData>.AddEnumerable
	|
	|-RVA: 0x2B95A24 Offset: 0x2B91A24 VA: 0x2B95A24
	|-List<UnitySynchronizationContext.WorkRequest>.AddEnumerable
	|
	|-RVA: 0x2B981E8 Offset: 0x2B941E8 VA: 0x2B981E8
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>.AddEnumerable
	|
	|-RVA: 0x2B9AAC0 Offset: 0x2B96AC0 VA: 0x2B9AAC0
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>.AddEnumerable
	|
	|-RVA: 0x2B9D490 Offset: 0x2B99490 VA: 0x2B9D490
	|-List<InstructionList.DebugView.InstructionView>.AddEnumerable
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAF598 Offset: 0x2AAB598 VA: 0x2AAF598
	|-List<KeyValuePair<ArchetypeUid, object>>..cctor
	|
	|-RVA: 0x2AB1BE0 Offset: 0x2AADBE0 VA: 0x2AB1BE0
	|-List<KeyValuePair<byte, BlackKnightCristaProperty>>..cctor
	|
	|-RVA: 0x2AB4228 Offset: 0x2AB0228 VA: 0x2AB4228
	|-List<KeyValuePair<byte, byte>>..cctor
	|
	|-RVA: 0x2AB6D24 Offset: 0x2AB2D24 VA: 0x2AB6D24
	|-List<KeyValuePair<byte, object>>..cctor
	|
	|-RVA: 0x2AB935C Offset: 0x2AB535C VA: 0x2AB935C
	|-List<KeyValuePair<int, short>>..cctor
	|
	|-RVA: 0x2ABB994 Offset: 0x2AB7994 VA: 0x2ABB994
	|-List<KeyValuePair<int, int>>..cctor
	|
	|-RVA: 0x2ABE114 Offset: 0x2ABA114 VA: 0x2ABE114
	|-List<KeyValuePair<int, object>>..cctor
	|
	|-RVA: 0x2AC074C Offset: 0x2ABC74C VA: 0x2AC074C
	|-List<KeyValuePair<Int32Enum, byte>>..cctor
	|
	|-RVA: 0x2AC324C Offset: 0x2ABF24C VA: 0x2AC324C
	|-List<KeyValuePair<Int32Enum, EnhanceProperties2>>..cctor
	|
	|-RVA: 0x2AC5884 Offset: 0x2AC1884 VA: 0x2AC5884
	|-List<KeyValuePair<Int32Enum, int>>..cctor
	|
	|-RVA: 0x2AC8004 Offset: 0x2AC4004 VA: 0x2AC8004
	|-List<KeyValuePair<Int32Enum, object>>..cctor
	|
	|-RVA: 0x2ACA784 Offset: 0x2AC6784 VA: 0x2ACA784
	|-List<KeyValuePair<object, int>>..cctor
	|
	|-RVA: 0x2ACCF04 Offset: 0x2AC8F04 VA: 0x2ACCF04
	|-List<KeyValuePair<object, float>>..cctor
	|
	|-RVA: 0x2ACF684 Offset: 0x2ACB684 VA: 0x2ACF684
	|-List<KeyValuePair<float, object>>..cctor
	|
	|-RVA: 0x2AD20B0 Offset: 0x2ACE0B0 VA: 0x2AD20B0
	|-List<Nullable<UIMobPropertyLabel.IconValue>>..cctor
	|
	|-RVA: 0x2AD4830 Offset: 0x2AD0830 VA: 0x2AD4830
	|-List<StructMultiKey<object, object>>..cctor
	|
	|-RVA: 0x2AD6E78 Offset: 0x2AD2E78 VA: 0x2AD6E78
	|-List<ValueTuple<short, short>>..cctor
	|
	|-RVA: 0x2AD94B0 Offset: 0x2AD54B0 VA: 0x2AD94B0
	|-List<ValueTuple<int, int>>..cctor
	|
	|-RVA: 0x2ADBC30 Offset: 0x2AD7C30 VA: 0x2ADBC30
	|-List<ValueTuple<int, object>>..cctor
	|
	|-RVA: 0x2ADE268 Offset: 0x2ADA268 VA: 0x2ADE268
	|-List<ValueTuple<Int32Enum, float>>..cctor
	|
	|-RVA: 0x2AE0D20 Offset: 0x2ADCD20 VA: 0x2AE0D20
	|-List<ValueTuple<Vector3, Vector3>>..cctor
	|
	|-RVA: 0x2AE3358 Offset: 0x2ADF358 VA: 0x2AE3358
	|-List<ArchetypeUid>..cctor
	|
	|-RVA: 0x2AE59D0 Offset: 0x2AE19D0 VA: 0x2AE59D0
	|-List<bool>..cctor
	|
	|-RVA: 0x2AE800C Offset: 0x2AE400C VA: 0x2AE800C
	|-List<byte>..cctor
	|
	|-RVA: 0x2AEA648 Offset: 0x2AE6648 VA: 0x2AEA648
	|-List<ByteEnum>..cctor
	|
	|-RVA: 0x2AECC80 Offset: 0x2AE8C80 VA: 0x2AECC80
	|-List<char>..cctor
	|
	|-RVA: 0x2AEF3C0 Offset: 0x2AEB3C0 VA: 0x2AEF3C0
	|-List<Color>..cctor
	|
	|-RVA: 0x2AF1A08 Offset: 0x2AEDA08 VA: 0x2AF1A08
	|-List<Color32>..cctor
	|
	|-RVA: 0x2AF4040 Offset: 0x2AF0040 VA: 0x2AF4040
	|-List<DateTime>..cctor
	|
	|-RVA: 0x2AF66D8 Offset: 0x2AF26D8 VA: 0x2AF66D8
	|-List<DateTimeOffset>..cctor
	|
	|-RVA: 0x2AF8DE8 Offset: 0x2AF4DE8 VA: 0x2AF8DE8
	|-List<Decimal>..cctor
	|
	|-RVA: 0x2AFB420 Offset: 0x2AF7420 VA: 0x2AFB420
	|-List<DefencePoint2>..cctor
	|
	|-RVA: 0x2AFDA64 Offset: 0x2AF9A64 VA: 0x2AFDA64
	|-List<double>..cctor
	|
	|-RVA: 0x2B001E4 Offset: 0x2AFC1E4 VA: 0x2B001E4
	|-List<EventSummary>..cctor
	|
	|-RVA: 0x2B0281C Offset: 0x2AFE81C VA: 0x2B0281C
	|-List<short>..cctor
	|
	|-RVA: 0x2B04E54 Offset: 0x2B00E54 VA: 0x2B04E54
	|-List<Int16Enum>..cctor
	|
	|-RVA: 0x2B07488 Offset: 0x2B03488 VA: 0x2B07488
	|-List<int>..cctor
	|
	|-RVA: 0x2B09ABC Offset: 0x2B05ABC VA: 0x2B09ABC
	|-List<Int32Enum>..cctor
	|
	|-RVA: 0x2B0C0F0 Offset: 0x2B080F0 VA: 0x2B0C0F0
	|-List<long>..cctor
	|
	|-RVA: 0x2B0E870 Offset: 0x2B0A870 VA: 0x2B0E870
	|-List<InterpretedFrameInfo>..cctor
	|
	|-RVA: 0x2B1144C Offset: 0x2B0D44C VA: 0x2B1144C
	|-List<JsonPosition>..cctor
	|
	|-RVA: 0x2B13AE4 Offset: 0x2B0FAE4 VA: 0x2B13AE4
	|-List<MaterialSearchData>..cctor
	|
	|-RVA: 0x2B1659C Offset: 0x2B1259C VA: 0x2B1659C
	|-List<MobActionTargetData>..cctor
	|
	|-RVA: 0x2B19178 Offset: 0x2B15178 VA: 0x2B19178
	|-List<MobIconLabelData>..cctor
	|
	|-RVA: 0x2B1B838 Offset: 0x2B17838 VA: 0x2B1B838
	|-List<object>..cctor
	|
	|-RVA: 0x2B1E440 Offset: 0x2B1A440 VA: 0x2B1E440
	|-List<PlayerLoopSystem>..cctor
	|
	|-RVA: 0x2B21048 Offset: 0x2B1D048 VA: 0x2B21048
	|-List<PlayerLoopSystemInternal>..cctor
	|
	|-RVA: 0x2B237C8 Offset: 0x2B1F7C8 VA: 0x2B237C8
	|-List<RangePositionInfo>..cctor
	|
	|-RVA: 0x2B25F2C Offset: 0x2B21F2C VA: 0x2B25F2C
	|-List<ReinforceCristaData>..cctor
	|
	|-RVA: 0x2B28568 Offset: 0x2B24568 VA: 0x2B28568
	|-List<sbyte>..cctor
	|
	|-RVA: 0x2B2ABAC Offset: 0x2B26BAC VA: 0x2B2ABAC
	|-List<float>..cctor
	|
	|-RVA: 0x2B2D1E4 Offset: 0x2B291E4 VA: 0x2B2D1E4
	|-List<SkillIdData>..cctor
	|
	|-RVA: 0x2B2F81C Offset: 0x2B2B81C VA: 0x2B2F81C
	|-List<TimeSpan>..cctor
	|
	|-RVA: 0x2B56234 Offset: 0x2B52234 VA: 0x2B56234
	|-List<ushort>..cctor
	|
	|-RVA: 0x2B58868 Offset: 0x2B54868 VA: 0x2B58868
	|-List<uint>..cctor
	|
	|-RVA: 0x2B5AE9C Offset: 0x2B56E9C VA: 0x2B5AE9C
	|-List<ulong>..cctor
	|
	|-RVA: 0x2B5D548 Offset: 0x2B59548 VA: 0x2B5D548
	|-List<Vector2>..cctor
	|
	|-RVA: 0x2B5FCD4 Offset: 0x2B5BCD4 VA: 0x2B5FCD4
	|-List<Vector3>..cctor
	|
	|-RVA: 0x2B62454 Offset: 0x2B5E454 VA: 0x2B62454
	|-List<X509ChainStatus>..cctor
	|
	|-RVA: 0x2B65E60 Offset: 0x2B61E60 VA: 0x2B65E60
	|-List<__Il2CppFullySharedGenericType>..cctor
	|
	|-RVA: 0x2B685E0 Offset: 0x2B645E0 VA: 0x2B685E0
	|-List<BeforeRenderHelper.OrderBlock>..cctor
	|
	|-RVA: 0x2B6B198 Offset: 0x2B67198 VA: 0x2B6B198
	|-List<BoneClip.MotionKeyFrame>..cctor
	|
	|-RVA: 0x2B6DD7C Offset: 0x2B69D7C VA: 0x2B6DD7C
	|-List<HouseRecipeManager.RecipeData>..cctor
	|
	|-RVA: 0x2B703B4 Offset: 0x2B6C3B4 VA: 0x2B703B4
	|-List<KadarElexioBuf.SkillIdData>..cctor
	|
	|-RVA: 0x2B72B18 Offset: 0x2B6EB18 VA: 0x2B72B18
	|-List<MissionTextManagerData.CheckIKeywordtemData>..cctor
	|
	|-RVA: 0x2B7527C Offset: 0x2B7127C VA: 0x2B7527C
	|-List<MissionTextManagerData.PickUpFieldData>..cctor
	|
	|-RVA: 0x2B77914 Offset: 0x2B73914 VA: 0x2B77914
	|-List<MobaRoomData.MobaAbilityMasterData>..cctor
	|
	|-RVA: 0x2B7A2F4 Offset: 0x2B762F4 VA: 0x2B7A2F4
	|-List<NewWaveRoomData.Spotlight>..cctor
	|
	|-RVA: 0x2B7CA74 Offset: 0x2B78A74 VA: 0x2B7CA74
	|-List<NguiDynamicFontController.ApplyTextureInfo>..cctor
	|
	|-RVA: 0x2B7F0BC Offset: 0x2B7B0BC VA: 0x2B7F0BC
	|-List<RegexCharClass.SingleRange>..cctor
	|
	|-RVA: 0x2B8183C Offset: 0x2B7D83C VA: 0x2B8183C
	|-List<SocialAchievementData.LinkData>..cctor
	|
	|-RVA: 0x2B83E74 Offset: 0x2B7FE74 VA: 0x2B83E74
	|-List<TrophyManager.TrophyData>..cctor
	|
	|-RVA: 0x2B86A58 Offset: 0x2B82A58 VA: 0x2B86A58
	|-List<UIEventMenuButton.MessageButtonData>..cctor
	|
	|-RVA: 0x2B89438 Offset: 0x2B85438 VA: 0x2B89438
	|-List<UIFieldMapPanel.PopData>..cctor
	|
	|-RVA: 0x2B8BA70 Offset: 0x2B87A70 VA: 0x2B8BA70
	|-List<UIHouseAddressManager.Town>..cctor
	|
	|-RVA: 0x2B8E450 Offset: 0x2B8A450 VA: 0x2B8E450
	|-List<UIInfoWindow.LabelPosition>..cctor
	|
	|-RVA: 0x2B90A88 Offset: 0x2B8CA88 VA: 0x2B90A88
	|-List<UIMainManager.DropItemData>..cctor
	|
	|-RVA: 0x2B93208 Offset: 0x2B8F208 VA: 0x2B93208
	|-List<UIScenarioOrderPanel.MissionData>..cctor
	|
	|-RVA: 0x2B95DE4 Offset: 0x2B91DE4 VA: 0x2B95DE4
	|-List<UnitySynchronizationContext.WorkRequest>..cctor
	|
	|-RVA: 0x2B98564 Offset: 0x2B94564 VA: 0x2B98564
	|-List<XmlSchemaObjectTable.XmlSchemaObjectEntry>..cctor
	|
	|-RVA: 0x2B9AE44 Offset: 0x2B96E44 VA: 0x2B9AE44
	|-List<BounceParabolaAttackPattern.TargetData.BoundLineData>..cctor
	|
	|-RVA: 0x2B9D824 Offset: 0x2B99824 VA: 0x2B9D824
	|-List<InstructionList.DebugView.InstructionView>..cctor
	*/
}
