// Assembly: mscorlib.dll
// Namespace: System.Collections.ObjectModel
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class ReadOnlyCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 10916
{
	// Fields
	private IList<T> list; // 0x0
	private object _syncRoot; // 0x0

	// Properties
	public int Count { get; }
	public T Item { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private T System.Collections.Generic.IList<T>.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04214 Offset: 0x2C00214 VA: 0x2C04214
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>..ctor
	|
	|-RVA: 0x2C04FF8 Offset: 0x2C00FF8 VA: 0x2C04FF8
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>..ctor
	|
	|-RVA: 0x2C05DDC Offset: 0x2C01DDC VA: 0x2C05DDC
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>..ctor
	|
	|-RVA: 0x2C06BC0 Offset: 0x2C02BC0 VA: 0x2C06BC0
	|-ReadOnlyCollection<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x2C079A4 Offset: 0x2C039A4 VA: 0x2C079A4
	|-ReadOnlyCollection<KeyValuePair<int, short>>..ctor
	|
	|-RVA: 0x2C08778 Offset: 0x2C04778 VA: 0x2C08778
	|-ReadOnlyCollection<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x2C0954C Offset: 0x2C0554C VA: 0x2C0954C
	|-ReadOnlyCollection<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2C0A330 Offset: 0x2C06330 VA: 0x2C0A330
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>..ctor
	|
	|-RVA: 0x2C0B104 Offset: 0x2C07104 VA: 0x2C0B104
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>..ctor
	|
	|-RVA: 0x2C0C018 Offset: 0x2C08018 VA: 0x2C0C018
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2C0CDEC Offset: 0x2C08DEC VA: 0x2C0CDEC
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x2C0DBD0 Offset: 0x2C09BD0 VA: 0x2C0DBD0
	|-ReadOnlyCollection<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x2C0E9B4 Offset: 0x2C0A9B4 VA: 0x2C0E9B4
	|-ReadOnlyCollection<KeyValuePair<object, float>>..ctor
	|
	|-RVA: 0x2C0F798 Offset: 0x2C0B798 VA: 0x2C0F798
	|-ReadOnlyCollection<KeyValuePair<float, object>>..ctor
	|
	|-RVA: 0x2C1057C Offset: 0x2C0C57C VA: 0x2C1057C
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>..ctor
	|
	|-RVA: 0x2C1140C Offset: 0x2C0D40C VA: 0x2C1140C
	|-ReadOnlyCollection<StructMultiKey<object, object>>..ctor
	|
	|-RVA: 0x2C121F0 Offset: 0x2C0E1F0 VA: 0x2C121F0
	|-ReadOnlyCollection<ValueTuple<short, short>>..ctor
	|
	|-RVA: 0x2C12FD4 Offset: 0x2C0EFD4 VA: 0x2C12FD4
	|-ReadOnlyCollection<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2C13DA8 Offset: 0x2C0FDA8 VA: 0x2C13DA8
	|-ReadOnlyCollection<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x2C14B8C Offset: 0x2C10B8C VA: 0x2C14B8C
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>..ctor
	|
	|-RVA: 0x2C15960 Offset: 0x2C11960 VA: 0x2C15960
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>..ctor
	|
	|-RVA: 0x2C16864 Offset: 0x2C12864 VA: 0x2C16864
	|-ReadOnlyCollection<ArchetypeUid>..ctor
	|
	|-RVA: 0x2C17638 Offset: 0x2C13638 VA: 0x2C17638
	|-ReadOnlyCollection<bool>..ctor
	|
	|-RVA: 0x2C18414 Offset: 0x2C14414 VA: 0x2C18414
	|-ReadOnlyCollection<byte>..ctor
	|
	|-RVA: 0x2C191E8 Offset: 0x2C151E8 VA: 0x2C191E8
	|-ReadOnlyCollection<ByteEnum>..ctor
	|
	|-RVA: 0x2C1A134 Offset: 0x2C16134 VA: 0x2C1A134
	|-ReadOnlyCollection<char>..ctor
	|
	|-RVA: 0x2C1AF08 Offset: 0x2C16F08 VA: 0x2C1AF08
	|-ReadOnlyCollection<Color>..ctor
	|
	|-RVA: 0x2C1BD2C Offset: 0x2C17D2C VA: 0x2C1BD2C
	|-ReadOnlyCollection<Color32>..ctor
	|
	|-RVA: 0x2C1CB10 Offset: 0x2C18B10 VA: 0x2C1CB10
	|-ReadOnlyCollection<CustomAttributeNamedArgument>..ctor
	|
	|-RVA: 0x2C1DA10 Offset: 0x2C19A10 VA: 0x2C1DA10
	|-ReadOnlyCollection<CustomAttributeTypedArgument>..ctor
	|
	|-RVA: 0x2C1E7F4 Offset: 0x2C1A7F4 VA: 0x2C1E7F4
	|-ReadOnlyCollection<DateTime>..ctor
	|
	|-RVA: 0x2C1F5C8 Offset: 0x2C1B5C8 VA: 0x2C1F5C8
	|-ReadOnlyCollection<DateTimeOffset>..ctor
	|
	|-RVA: 0x2C203AC Offset: 0x2C1C3AC VA: 0x2C203AC
	|-ReadOnlyCollection<Decimal>..ctor
	|
	|-RVA: 0x2C211D0 Offset: 0x2C1D1D0 VA: 0x2C211D0
	|-ReadOnlyCollection<DefencePoint2>..ctor
	|
	|-RVA: 0x2C21FA4 Offset: 0x2C1DFA4 VA: 0x2C21FA4
	|-ReadOnlyCollection<double>..ctor
	|
	|-RVA: 0x2C22D78 Offset: 0x2C1ED78 VA: 0x2C22D78
	|-ReadOnlyCollection<EventSummary>..ctor
	|
	|-RVA: 0x2C23B5C Offset: 0x2C1FB5C VA: 0x2C23B5C
	|-ReadOnlyCollection<short>..ctor
	|
	|-RVA: 0x2C24930 Offset: 0x2C20930 VA: 0x2C24930
	|-ReadOnlyCollection<Int16Enum>..ctor
	|
	|-RVA: 0x2C25704 Offset: 0x2C21704 VA: 0x2C25704
	|-ReadOnlyCollection<int>..ctor
	|
	|-RVA: 0x2C264D8 Offset: 0x2C224D8 VA: 0x2C264D8
	|-ReadOnlyCollection<Int32Enum>..ctor
	|
	|-RVA: 0x2C272AC Offset: 0x2C232AC VA: 0x2C272AC
	|-ReadOnlyCollection<long>..ctor
	|
	|-RVA: 0x2C28080 Offset: 0x2C24080 VA: 0x2C28080
	|-ReadOnlyCollection<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x2C28E64 Offset: 0x2C24E64 VA: 0x2C28E64
	|-ReadOnlyCollection<JsonPosition>..ctor
	|
	|-RVA: 0x2C29D68 Offset: 0x2C25D68 VA: 0x2C29D68
	|-ReadOnlyCollection<MaterialSearchData>..ctor
	|
	|-RVA: 0x2C2AB4C Offset: 0x2C26B4C VA: 0x2C2AB4C
	|-ReadOnlyCollection<MobActionTargetData>..ctor
	|
	|-RVA: 0x2C2BA50 Offset: 0x2C27A50 VA: 0x2C2BA50
	|-ReadOnlyCollection<MobIconLabelData>..ctor
	|
	|-RVA: 0x2C2C954 Offset: 0x2C28954 VA: 0x2C2C954
	|-ReadOnlyCollection<object>..ctor
	|
	|-RVA: 0x2C2D700 Offset: 0x2C29700 VA: 0x2C2D700
	|-ReadOnlyCollection<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x2C2E60C Offset: 0x2C2A60C VA: 0x2C2E60C
	|-ReadOnlyCollection<PlayerLoopSystemInternal>..ctor
	|
	|-RVA: 0x2C2F518 Offset: 0x2C2B518 VA: 0x2C2F518
	|-ReadOnlyCollection<RangePositionInfo>..ctor
	|
	|-RVA: 0x2C302FC Offset: 0x2C2C2FC VA: 0x2C302FC
	|-ReadOnlyCollection<ReinforceCristaData>..ctor
	|
	|-RVA: 0x2C31100 Offset: 0x2C2D100 VA: 0x2C31100
	|-ReadOnlyCollection<sbyte>..ctor
	|
	|-RVA: 0x2C31ED4 Offset: 0x2C2DED4 VA: 0x2C31ED4
	|-ReadOnlyCollection<float>..ctor
	|
	|-RVA: 0x2C32CA8 Offset: 0x2C2ECA8 VA: 0x2C32CA8
	|-ReadOnlyCollection<SkillIdData>..ctor
	|
	|-RVA: 0x2C33A7C Offset: 0x2C2FA7C VA: 0x2C33A7C
	|-ReadOnlyCollection<TimeSpan>..ctor
	|
	|-RVA: 0x2C34850 Offset: 0x2C30850 VA: 0x2C34850
	|-ReadOnlyCollection<ushort>..ctor
	|
	|-RVA: 0x2C35624 Offset: 0x2C31624 VA: 0x2C35624
	|-ReadOnlyCollection<uint>..ctor
	|
	|-RVA: 0x2C363F8 Offset: 0x2C323F8 VA: 0x2C363F8
	|-ReadOnlyCollection<ulong>..ctor
	|
	|-RVA: 0x2C371CC Offset: 0x2C331CC VA: 0x2C371CC
	|-ReadOnlyCollection<Vector2>..ctor
	|
	|-RVA: 0x2C37FB0 Offset: 0x2C33FB0 VA: 0x2C37FB0
	|-ReadOnlyCollection<Vector3>..ctor
	|
	|-RVA: 0x2C38DC4 Offset: 0x2C34DC4 VA: 0x2C38DC4
	|-ReadOnlyCollection<X509ChainStatus>..ctor
	|
	|-RVA: 0x2C39BA8 Offset: 0x2C35BA8 VA: 0x2C39BA8
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2C3AE68 Offset: 0x2C36E68 VA: 0x2C3AE68
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x2C3BC4C Offset: 0x2C37C4C VA: 0x2C3BC4C
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>..ctor
	|
	|-RVA: 0x2C3CB50 Offset: 0x2C38B50 VA: 0x2C3CB50
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>..ctor
	|
	|-RVA: 0x2C3DA5C Offset: 0x2C39A5C VA: 0x2C3DA5C
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>..ctor
	|
	|-RVA: 0x2C3E830 Offset: 0x2C3A830 VA: 0x2C3E830
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>..ctor
	|
	|-RVA: 0x2C3F634 Offset: 0x2C3B634 VA: 0x2C3F634
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>..ctor
	|
	|-RVA: 0x2C40438 Offset: 0x2C3C438 VA: 0x2C40438
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>..ctor
	|
	|-RVA: 0x2C4121C Offset: 0x2C3D21C VA: 0x2C4121C
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>..ctor
	|
	|-RVA: 0x2C420A8 Offset: 0x2C3E0A8 VA: 0x2C420A8
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>..ctor
	|
	|-RVA: 0x2C42E8C Offset: 0x2C3EE8C VA: 0x2C42E8C
	|-ReadOnlyCollection<RegexCharClass.SingleRange>..ctor
	|
	|-RVA: 0x2C43C70 Offset: 0x2C3FC70 VA: 0x2C43C70
	|-ReadOnlyCollection<SocialAchievementData.LinkData>..ctor
	|
	|-RVA: 0x2C44A54 Offset: 0x2C40A54 VA: 0x2C44A54
	|-ReadOnlyCollection<TrophyManager.TrophyData>..ctor
	|
	|-RVA: 0x2C45828 Offset: 0x2C41828 VA: 0x2C45828
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>..ctor
	|
	|-RVA: 0x2C46728 Offset: 0x2C42728 VA: 0x2C46728
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>..ctor
	|
	|-RVA: 0x2C475B4 Offset: 0x2C435B4 VA: 0x2C475B4
	|-ReadOnlyCollection<UIHouseAddressManager.Town>..ctor
	|
	|-RVA: 0x2C48388 Offset: 0x2C44388 VA: 0x2C48388
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>..ctor
	|
	|-RVA: 0x2C49214 Offset: 0x2C45214 VA: 0x2C49214
	|-ReadOnlyCollection<UIMainManager.DropItemData>..ctor
	|
	|-RVA: 0x2C49FE8 Offset: 0x2C45FE8 VA: 0x2C49FE8
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>..ctor
	|
	|-RVA: 0x2C4ADCC Offset: 0x2C46DCC VA: 0x2C4ADCC
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x2C4BCD0 Offset: 0x2C47CD0 VA: 0x2C4BCD0
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0x2C4CAB4 Offset: 0x2C48AB4 VA: 0x2C4CAB4
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>..ctor
	|
	|-RVA: 0x2C4D940 Offset: 0x2C49940 VA: 0x2C4D940
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04254 Offset: 0x2C00254 VA: 0x2C04254
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.get_Count
	|
	|-RVA: 0x2C05038 Offset: 0x2C01038 VA: 0x2C05038
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.get_Count
	|
	|-RVA: 0x2C05E1C Offset: 0x2C01E1C VA: 0x2C05E1C
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.get_Count
	|
	|-RVA: 0x2C06C00 Offset: 0x2C02C00 VA: 0x2C06C00
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.get_Count
	|
	|-RVA: 0x2C079E4 Offset: 0x2C039E4 VA: 0x2C079E4
	|-ReadOnlyCollection<KeyValuePair<int, short>>.get_Count
	|
	|-RVA: 0x2C087B8 Offset: 0x2C047B8 VA: 0x2C087B8
	|-ReadOnlyCollection<KeyValuePair<int, int>>.get_Count
	|
	|-RVA: 0x2C0958C Offset: 0x2C0558C VA: 0x2C0958C
	|-ReadOnlyCollection<KeyValuePair<int, object>>.get_Count
	|
	|-RVA: 0x2C0A370 Offset: 0x2C06370 VA: 0x2C0A370
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.get_Count
	|
	|-RVA: 0x2C0B144 Offset: 0x2C07144 VA: 0x2C0B144
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.get_Count
	|
	|-RVA: 0x2C0C058 Offset: 0x2C08058 VA: 0x2C0C058
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.get_Count
	|
	|-RVA: 0x2C0CE2C Offset: 0x2C08E2C VA: 0x2C0CE2C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.get_Count
	|
	|-RVA: 0x2C0DC10 Offset: 0x2C09C10 VA: 0x2C0DC10
	|-ReadOnlyCollection<KeyValuePair<object, int>>.get_Count
	|
	|-RVA: 0x2C0E9F4 Offset: 0x2C0A9F4 VA: 0x2C0E9F4
	|-ReadOnlyCollection<KeyValuePair<object, float>>.get_Count
	|
	|-RVA: 0x2C0F7D8 Offset: 0x2C0B7D8 VA: 0x2C0F7D8
	|-ReadOnlyCollection<KeyValuePair<float, object>>.get_Count
	|
	|-RVA: 0x2C105BC Offset: 0x2C0C5BC VA: 0x2C105BC
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.get_Count
	|
	|-RVA: 0x2C1144C Offset: 0x2C0D44C VA: 0x2C1144C
	|-ReadOnlyCollection<StructMultiKey<object, object>>.get_Count
	|
	|-RVA: 0x2C12230 Offset: 0x2C0E230 VA: 0x2C12230
	|-ReadOnlyCollection<ValueTuple<short, short>>.get_Count
	|
	|-RVA: 0x2C13014 Offset: 0x2C0F014 VA: 0x2C13014
	|-ReadOnlyCollection<ValueTuple<int, int>>.get_Count
	|
	|-RVA: 0x2C13DE8 Offset: 0x2C0FDE8 VA: 0x2C13DE8
	|-ReadOnlyCollection<ValueTuple<int, object>>.get_Count
	|
	|-RVA: 0x2C14BCC Offset: 0x2C10BCC VA: 0x2C14BCC
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.get_Count
	|
	|-RVA: 0x2C159A0 Offset: 0x2C119A0 VA: 0x2C159A0
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.get_Count
	|
	|-RVA: 0x2C168A4 Offset: 0x2C128A4 VA: 0x2C168A4
	|-ReadOnlyCollection<ArchetypeUid>.get_Count
	|
	|-RVA: 0x2C17678 Offset: 0x2C13678 VA: 0x2C17678
	|-ReadOnlyCollection<bool>.get_Count
	|
	|-RVA: 0x2C18454 Offset: 0x2C14454 VA: 0x2C18454
	|-ReadOnlyCollection<byte>.get_Count
	|
	|-RVA: 0x2C19228 Offset: 0x2C15228 VA: 0x2C19228
	|-ReadOnlyCollection<ByteEnum>.get_Count
	|
	|-RVA: 0x2C1A174 Offset: 0x2C16174 VA: 0x2C1A174
	|-ReadOnlyCollection<char>.get_Count
	|
	|-RVA: 0x2C1AF48 Offset: 0x2C16F48 VA: 0x2C1AF48
	|-ReadOnlyCollection<Color>.get_Count
	|
	|-RVA: 0x2C1BD6C Offset: 0x2C17D6C VA: 0x2C1BD6C
	|-ReadOnlyCollection<Color32>.get_Count
	|
	|-RVA: 0x2C1CB50 Offset: 0x2C18B50 VA: 0x2C1CB50
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.get_Count
	|
	|-RVA: 0x2C1DA50 Offset: 0x2C19A50 VA: 0x2C1DA50
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.get_Count
	|
	|-RVA: 0x2C1E834 Offset: 0x2C1A834 VA: 0x2C1E834
	|-ReadOnlyCollection<DateTime>.get_Count
	|
	|-RVA: 0x2C1F608 Offset: 0x2C1B608 VA: 0x2C1F608
	|-ReadOnlyCollection<DateTimeOffset>.get_Count
	|
	|-RVA: 0x2C203EC Offset: 0x2C1C3EC VA: 0x2C203EC
	|-ReadOnlyCollection<Decimal>.get_Count
	|
	|-RVA: 0x2C21210 Offset: 0x2C1D210 VA: 0x2C21210
	|-ReadOnlyCollection<DefencePoint2>.get_Count
	|
	|-RVA: 0x2C21FE4 Offset: 0x2C1DFE4 VA: 0x2C21FE4
	|-ReadOnlyCollection<double>.get_Count
	|
	|-RVA: 0x2C22DB8 Offset: 0x2C1EDB8 VA: 0x2C22DB8
	|-ReadOnlyCollection<EventSummary>.get_Count
	|
	|-RVA: 0x2C23B9C Offset: 0x2C1FB9C VA: 0x2C23B9C
	|-ReadOnlyCollection<short>.get_Count
	|
	|-RVA: 0x2C24970 Offset: 0x2C20970 VA: 0x2C24970
	|-ReadOnlyCollection<Int16Enum>.get_Count
	|
	|-RVA: 0x2C25744 Offset: 0x2C21744 VA: 0x2C25744
	|-ReadOnlyCollection<int>.get_Count
	|
	|-RVA: 0x2C26518 Offset: 0x2C22518 VA: 0x2C26518
	|-ReadOnlyCollection<Int32Enum>.get_Count
	|
	|-RVA: 0x2C272EC Offset: 0x2C232EC VA: 0x2C272EC
	|-ReadOnlyCollection<long>.get_Count
	|
	|-RVA: 0x2C280C0 Offset: 0x2C240C0 VA: 0x2C280C0
	|-ReadOnlyCollection<InterpretedFrameInfo>.get_Count
	|
	|-RVA: 0x2C28EA4 Offset: 0x2C24EA4 VA: 0x2C28EA4
	|-ReadOnlyCollection<JsonPosition>.get_Count
	|
	|-RVA: 0x2C29DA8 Offset: 0x2C25DA8 VA: 0x2C29DA8
	|-ReadOnlyCollection<MaterialSearchData>.get_Count
	|
	|-RVA: 0x2C2AB8C Offset: 0x2C26B8C VA: 0x2C2AB8C
	|-ReadOnlyCollection<MobActionTargetData>.get_Count
	|
	|-RVA: 0x2C2BA90 Offset: 0x2C27A90 VA: 0x2C2BA90
	|-ReadOnlyCollection<MobIconLabelData>.get_Count
	|
	|-RVA: 0x2C2C994 Offset: 0x2C28994 VA: 0x2C2C994
	|-ReadOnlyCollection<object>.get_Count
	|
	|-RVA: 0x2C2D740 Offset: 0x2C29740 VA: 0x2C2D740
	|-ReadOnlyCollection<PlayerLoopSystem>.get_Count
	|
	|-RVA: 0x2C2E64C Offset: 0x2C2A64C VA: 0x2C2E64C
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.get_Count
	|
	|-RVA: 0x2C2F558 Offset: 0x2C2B558 VA: 0x2C2F558
	|-ReadOnlyCollection<RangePositionInfo>.get_Count
	|
	|-RVA: 0x2C3033C Offset: 0x2C2C33C VA: 0x2C3033C
	|-ReadOnlyCollection<ReinforceCristaData>.get_Count
	|
	|-RVA: 0x2C31140 Offset: 0x2C2D140 VA: 0x2C31140
	|-ReadOnlyCollection<sbyte>.get_Count
	|
	|-RVA: 0x2C31F14 Offset: 0x2C2DF14 VA: 0x2C31F14
	|-ReadOnlyCollection<float>.get_Count
	|
	|-RVA: 0x2C32CE8 Offset: 0x2C2ECE8 VA: 0x2C32CE8
	|-ReadOnlyCollection<SkillIdData>.get_Count
	|
	|-RVA: 0x2C33ABC Offset: 0x2C2FABC VA: 0x2C33ABC
	|-ReadOnlyCollection<TimeSpan>.get_Count
	|
	|-RVA: 0x2C34890 Offset: 0x2C30890 VA: 0x2C34890
	|-ReadOnlyCollection<ushort>.get_Count
	|
	|-RVA: 0x2C35664 Offset: 0x2C31664 VA: 0x2C35664
	|-ReadOnlyCollection<uint>.get_Count
	|
	|-RVA: 0x2C36438 Offset: 0x2C32438 VA: 0x2C36438
	|-ReadOnlyCollection<ulong>.get_Count
	|
	|-RVA: 0x2C3720C Offset: 0x2C3320C VA: 0x2C3720C
	|-ReadOnlyCollection<Vector2>.get_Count
	|
	|-RVA: 0x2C37FF0 Offset: 0x2C33FF0 VA: 0x2C37FF0
	|-ReadOnlyCollection<Vector3>.get_Count
	|
	|-RVA: 0x2C38E04 Offset: 0x2C34E04 VA: 0x2C38E04
	|-ReadOnlyCollection<X509ChainStatus>.get_Count
	|
	|-RVA: 0x2C39BE8 Offset: 0x2C35BE8 VA: 0x2C39BE8
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.get_Count
	|
	|-RVA: 0x2C3AEA8 Offset: 0x2C36EA8 VA: 0x2C3AEA8
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.get_Count
	|
	|-RVA: 0x2C3BC8C Offset: 0x2C37C8C VA: 0x2C3BC8C
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.get_Count
	|
	|-RVA: 0x2C3CB90 Offset: 0x2C38B90 VA: 0x2C3CB90
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.get_Count
	|
	|-RVA: 0x2C3DA9C Offset: 0x2C39A9C VA: 0x2C3DA9C
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.get_Count
	|
	|-RVA: 0x2C3E870 Offset: 0x2C3A870 VA: 0x2C3E870
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.get_Count
	|
	|-RVA: 0x2C3F674 Offset: 0x2C3B674 VA: 0x2C3F674
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.get_Count
	|
	|-RVA: 0x2C40478 Offset: 0x2C3C478 VA: 0x2C40478
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.get_Count
	|
	|-RVA: 0x2C4125C Offset: 0x2C3D25C VA: 0x2C4125C
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.get_Count
	|
	|-RVA: 0x2C420E8 Offset: 0x2C3E0E8 VA: 0x2C420E8
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.get_Count
	|
	|-RVA: 0x2C42ECC Offset: 0x2C3EECC VA: 0x2C42ECC
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.get_Count
	|
	|-RVA: 0x2C43CB0 Offset: 0x2C3FCB0 VA: 0x2C43CB0
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.get_Count
	|
	|-RVA: 0x2C44A94 Offset: 0x2C40A94 VA: 0x2C44A94
	|-ReadOnlyCollection<TrophyManager.TrophyData>.get_Count
	|
	|-RVA: 0x2C45868 Offset: 0x2C41868 VA: 0x2C45868
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.get_Count
	|
	|-RVA: 0x2C46768 Offset: 0x2C42768 VA: 0x2C46768
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.get_Count
	|
	|-RVA: 0x2C475F4 Offset: 0x2C435F4 VA: 0x2C475F4
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.get_Count
	|
	|-RVA: 0x2C483C8 Offset: 0x2C443C8 VA: 0x2C483C8
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.get_Count
	|
	|-RVA: 0x2C49254 Offset: 0x2C45254 VA: 0x2C49254
	|-ReadOnlyCollection<UIMainManager.DropItemData>.get_Count
	|
	|-RVA: 0x2C4A028 Offset: 0x2C46028 VA: 0x2C4A028
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.get_Count
	|
	|-RVA: 0x2C4AE0C Offset: 0x2C46E0C VA: 0x2C4AE0C
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.get_Count
	|
	|-RVA: 0x2C4BD10 Offset: 0x2C47D10 VA: 0x2C4BD10
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Count
	|
	|-RVA: 0x2C4CAF4 Offset: 0x2C48AF4 VA: 0x2C4CAF4
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.get_Count
	|
	|-RVA: 0x2C4D980 Offset: 0x2C49980 VA: 0x2C4D980
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C042DC Offset: 0x2C002DC VA: 0x2C042DC
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.get_Item
	|
	|-RVA: 0x2C050C0 Offset: 0x2C010C0 VA: 0x2C050C0
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.get_Item
	|
	|-RVA: 0x2C05EA4 Offset: 0x2C01EA4 VA: 0x2C05EA4
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.get_Item
	|
	|-RVA: 0x2C06C88 Offset: 0x2C02C88 VA: 0x2C06C88
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.get_Item
	|
	|-RVA: 0x2C07A6C Offset: 0x2C03A6C VA: 0x2C07A6C
	|-ReadOnlyCollection<KeyValuePair<int, short>>.get_Item
	|
	|-RVA: 0x2C08840 Offset: 0x2C04840 VA: 0x2C08840
	|-ReadOnlyCollection<KeyValuePair<int, int>>.get_Item
	|
	|-RVA: 0x2C09614 Offset: 0x2C05614 VA: 0x2C09614
	|-ReadOnlyCollection<KeyValuePair<int, object>>.get_Item
	|
	|-RVA: 0x2C0A3F8 Offset: 0x2C063F8 VA: 0x2C0A3F8
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.get_Item
	|
	|-RVA: 0x2C0B1CC Offset: 0x2C071CC VA: 0x2C0B1CC
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.get_Item
	|
	|-RVA: 0x2C0C0E0 Offset: 0x2C080E0 VA: 0x2C0C0E0
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.get_Item
	|
	|-RVA: 0x2C0CEB4 Offset: 0x2C08EB4 VA: 0x2C0CEB4
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.get_Item
	|
	|-RVA: 0x2C0DC98 Offset: 0x2C09C98 VA: 0x2C0DC98
	|-ReadOnlyCollection<KeyValuePair<object, int>>.get_Item
	|
	|-RVA: 0x2C0EA7C Offset: 0x2C0AA7C VA: 0x2C0EA7C
	|-ReadOnlyCollection<KeyValuePair<object, float>>.get_Item
	|
	|-RVA: 0x2C0F860 Offset: 0x2C0B860 VA: 0x2C0F860
	|-ReadOnlyCollection<KeyValuePair<float, object>>.get_Item
	|
	|-RVA: 0x2C10644 Offset: 0x2C0C644 VA: 0x2C10644
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.get_Item
	|
	|-RVA: 0x2C114D4 Offset: 0x2C0D4D4 VA: 0x2C114D4
	|-ReadOnlyCollection<StructMultiKey<object, object>>.get_Item
	|
	|-RVA: 0x2C122B8 Offset: 0x2C0E2B8 VA: 0x2C122B8
	|-ReadOnlyCollection<ValueTuple<short, short>>.get_Item
	|
	|-RVA: 0x2C1309C Offset: 0x2C0F09C VA: 0x2C1309C
	|-ReadOnlyCollection<ValueTuple<int, int>>.get_Item
	|
	|-RVA: 0x2C13E70 Offset: 0x2C0FE70 VA: 0x2C13E70
	|-ReadOnlyCollection<ValueTuple<int, object>>.get_Item
	|
	|-RVA: 0x2C14C54 Offset: 0x2C10C54 VA: 0x2C14C54
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.get_Item
	|
	|-RVA: 0x2C15A28 Offset: 0x2C11A28 VA: 0x2C15A28
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.get_Item
	|
	|-RVA: 0x2C1692C Offset: 0x2C1292C VA: 0x2C1692C
	|-ReadOnlyCollection<ArchetypeUid>.get_Item
	|
	|-RVA: 0x2C17700 Offset: 0x2C13700 VA: 0x2C17700
	|-ReadOnlyCollection<bool>.get_Item
	|
	|-RVA: 0x2C184DC Offset: 0x2C144DC VA: 0x2C184DC
	|-ReadOnlyCollection<byte>.get_Item
	|
	|-RVA: 0x2C192B0 Offset: 0x2C152B0 VA: 0x2C192B0
	|-ReadOnlyCollection<ByteEnum>.get_Item
	|
	|-RVA: 0x2C1A1FC Offset: 0x2C161FC VA: 0x2C1A1FC
	|-ReadOnlyCollection<char>.get_Item
	|
	|-RVA: 0x2C1AFD0 Offset: 0x2C16FD0 VA: 0x2C1AFD0
	|-ReadOnlyCollection<Color>.get_Item
	|
	|-RVA: 0x2C1BDF4 Offset: 0x2C17DF4 VA: 0x2C1BDF4
	|-ReadOnlyCollection<Color32>.get_Item
	|
	|-RVA: 0x2C1CBD8 Offset: 0x2C18BD8 VA: 0x2C1CBD8
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.get_Item
	|
	|-RVA: 0x2C1DAD8 Offset: 0x2C19AD8 VA: 0x2C1DAD8
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.get_Item
	|
	|-RVA: 0x2C1E8BC Offset: 0x2C1A8BC VA: 0x2C1E8BC
	|-ReadOnlyCollection<DateTime>.get_Item
	|
	|-RVA: 0x2C1F690 Offset: 0x2C1B690 VA: 0x2C1F690
	|-ReadOnlyCollection<DateTimeOffset>.get_Item
	|
	|-RVA: 0x2C20474 Offset: 0x2C1C474 VA: 0x2C20474
	|-ReadOnlyCollection<Decimal>.get_Item
	|
	|-RVA: 0x2C21298 Offset: 0x2C1D298 VA: 0x2C21298
	|-ReadOnlyCollection<DefencePoint2>.get_Item
	|
	|-RVA: 0x2C2206C Offset: 0x2C1E06C VA: 0x2C2206C
	|-ReadOnlyCollection<double>.get_Item
	|
	|-RVA: 0x2C22E40 Offset: 0x2C1EE40 VA: 0x2C22E40
	|-ReadOnlyCollection<EventSummary>.get_Item
	|
	|-RVA: 0x2C23C24 Offset: 0x2C1FC24 VA: 0x2C23C24
	|-ReadOnlyCollection<short>.get_Item
	|
	|-RVA: 0x2C249F8 Offset: 0x2C209F8 VA: 0x2C249F8
	|-ReadOnlyCollection<Int16Enum>.get_Item
	|
	|-RVA: 0x2C257CC Offset: 0x2C217CC VA: 0x2C257CC
	|-ReadOnlyCollection<int>.get_Item
	|
	|-RVA: 0x2C265A0 Offset: 0x2C225A0 VA: 0x2C265A0
	|-ReadOnlyCollection<Int32Enum>.get_Item
	|
	|-RVA: 0x2C27374 Offset: 0x2C23374 VA: 0x2C27374
	|-ReadOnlyCollection<long>.get_Item
	|
	|-RVA: 0x2C28148 Offset: 0x2C24148 VA: 0x2C28148
	|-ReadOnlyCollection<InterpretedFrameInfo>.get_Item
	|
	|-RVA: 0x2C28F2C Offset: 0x2C24F2C VA: 0x2C28F2C
	|-ReadOnlyCollection<JsonPosition>.get_Item
	|
	|-RVA: 0x2C29E30 Offset: 0x2C25E30 VA: 0x2C29E30
	|-ReadOnlyCollection<MaterialSearchData>.get_Item
	|
	|-RVA: 0x2C2AC14 Offset: 0x2C26C14 VA: 0x2C2AC14
	|-ReadOnlyCollection<MobActionTargetData>.get_Item
	|
	|-RVA: 0x2C2BB18 Offset: 0x2C27B18 VA: 0x2C2BB18
	|-ReadOnlyCollection<MobIconLabelData>.get_Item
	|
	|-RVA: 0x2C2CA1C Offset: 0x2C28A1C VA: 0x2C2CA1C
	|-ReadOnlyCollection<object>.get_Item
	|
	|-RVA: 0x2C2D7C8 Offset: 0x2C297C8 VA: 0x2C2D7C8
	|-ReadOnlyCollection<PlayerLoopSystem>.get_Item
	|
	|-RVA: 0x2C2E6D4 Offset: 0x2C2A6D4 VA: 0x2C2E6D4
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.get_Item
	|
	|-RVA: 0x2C2F5E0 Offset: 0x2C2B5E0 VA: 0x2C2F5E0
	|-ReadOnlyCollection<RangePositionInfo>.get_Item
	|
	|-RVA: 0x2C303C4 Offset: 0x2C2C3C4 VA: 0x2C303C4
	|-ReadOnlyCollection<ReinforceCristaData>.get_Item
	|
	|-RVA: 0x2C311C8 Offset: 0x2C2D1C8 VA: 0x2C311C8
	|-ReadOnlyCollection<sbyte>.get_Item
	|
	|-RVA: 0x2C31F9C Offset: 0x2C2DF9C VA: 0x2C31F9C
	|-ReadOnlyCollection<float>.get_Item
	|
	|-RVA: 0x2C32D70 Offset: 0x2C2ED70 VA: 0x2C32D70
	|-ReadOnlyCollection<SkillIdData>.get_Item
	|
	|-RVA: 0x2C33B44 Offset: 0x2C2FB44 VA: 0x2C33B44
	|-ReadOnlyCollection<TimeSpan>.get_Item
	|
	|-RVA: 0x2C34918 Offset: 0x2C30918 VA: 0x2C34918
	|-ReadOnlyCollection<ushort>.get_Item
	|
	|-RVA: 0x2C356EC Offset: 0x2C316EC VA: 0x2C356EC
	|-ReadOnlyCollection<uint>.get_Item
	|
	|-RVA: 0x2C364C0 Offset: 0x2C324C0 VA: 0x2C364C0
	|-ReadOnlyCollection<ulong>.get_Item
	|
	|-RVA: 0x2C37294 Offset: 0x2C33294 VA: 0x2C37294
	|-ReadOnlyCollection<Vector2>.get_Item
	|
	|-RVA: 0x2C38078 Offset: 0x2C34078 VA: 0x2C38078
	|-ReadOnlyCollection<Vector3>.get_Item
	|
	|-RVA: 0x2C38E8C Offset: 0x2C34E8C VA: 0x2C38E8C
	|-ReadOnlyCollection<X509ChainStatus>.get_Item
	|
	|-RVA: 0x2C39C70 Offset: 0x2C35C70 VA: 0x2C39C70
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x2C3AF30 Offset: 0x2C36F30 VA: 0x2C3AF30
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.get_Item
	|
	|-RVA: 0x2C3BD14 Offset: 0x2C37D14 VA: 0x2C3BD14
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.get_Item
	|
	|-RVA: 0x2C3CC18 Offset: 0x2C38C18 VA: 0x2C3CC18
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.get_Item
	|
	|-RVA: 0x2C3DB24 Offset: 0x2C39B24 VA: 0x2C3DB24
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.get_Item
	|
	|-RVA: 0x2C3E8F8 Offset: 0x2C3A8F8 VA: 0x2C3E8F8
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.get_Item
	|
	|-RVA: 0x2C3F6FC Offset: 0x2C3B6FC VA: 0x2C3F6FC
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.get_Item
	|
	|-RVA: 0x2C40500 Offset: 0x2C3C500 VA: 0x2C40500
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.get_Item
	|
	|-RVA: 0x2C412E4 Offset: 0x2C3D2E4 VA: 0x2C412E4
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.get_Item
	|
	|-RVA: 0x2C42170 Offset: 0x2C3E170 VA: 0x2C42170
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.get_Item
	|
	|-RVA: 0x2C42F54 Offset: 0x2C3EF54 VA: 0x2C42F54
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.get_Item
	|
	|-RVA: 0x2C43D38 Offset: 0x2C3FD38 VA: 0x2C43D38
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.get_Item
	|
	|-RVA: 0x2C44B1C Offset: 0x2C40B1C VA: 0x2C44B1C
	|-ReadOnlyCollection<TrophyManager.TrophyData>.get_Item
	|
	|-RVA: 0x2C458F0 Offset: 0x2C418F0 VA: 0x2C458F0
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.get_Item
	|
	|-RVA: 0x2C467F0 Offset: 0x2C427F0 VA: 0x2C467F0
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.get_Item
	|
	|-RVA: 0x2C4767C Offset: 0x2C4367C VA: 0x2C4767C
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.get_Item
	|
	|-RVA: 0x2C48450 Offset: 0x2C44450 VA: 0x2C48450
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.get_Item
	|
	|-RVA: 0x2C492DC Offset: 0x2C452DC VA: 0x2C492DC
	|-ReadOnlyCollection<UIMainManager.DropItemData>.get_Item
	|
	|-RVA: 0x2C4A0B0 Offset: 0x2C460B0 VA: 0x2C4A0B0
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.get_Item
	|
	|-RVA: 0x2C4AE94 Offset: 0x2C46E94 VA: 0x2C4AE94
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.get_Item
	|
	|-RVA: 0x2C4BD98 Offset: 0x2C47D98 VA: 0x2C4BD98
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Item
	|
	|-RVA: 0x2C4CB7C Offset: 0x2C48B7C VA: 0x2C4CB7C
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.get_Item
	|
	|-RVA: 0x2C4DA08 Offset: 0x2C49A08 VA: 0x2C4DA08
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04374 Offset: 0x2C00374 VA: 0x2C04374
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.Contains
	|
	|-RVA: 0x2C05160 Offset: 0x2C01160 VA: 0x2C05160
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.Contains
	|
	|-RVA: 0x2C05F44 Offset: 0x2C01F44 VA: 0x2C05F44
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.Contains
	|
	|-RVA: 0x2C06D20 Offset: 0x2C02D20 VA: 0x2C06D20
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.Contains
	|
	|-RVA: 0x2C07B04 Offset: 0x2C03B04 VA: 0x2C07B04
	|-ReadOnlyCollection<KeyValuePair<int, short>>.Contains
	|
	|-RVA: 0x2C088D8 Offset: 0x2C048D8 VA: 0x2C088D8
	|-ReadOnlyCollection<KeyValuePair<int, int>>.Contains
	|
	|-RVA: 0x2C096AC Offset: 0x2C056AC VA: 0x2C096AC
	|-ReadOnlyCollection<KeyValuePair<int, object>>.Contains
	|
	|-RVA: 0x2C0A490 Offset: 0x2C06490 VA: 0x2C0A490
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.Contains
	|
	|-RVA: 0x2C0B288 Offset: 0x2C07288 VA: 0x2C0B288
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.Contains
	|
	|-RVA: 0x2C0C178 Offset: 0x2C08178 VA: 0x2C0C178
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.Contains
	|
	|-RVA: 0x2C0CF4C Offset: 0x2C08F4C VA: 0x2C0CF4C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.Contains
	|
	|-RVA: 0x2C0DD30 Offset: 0x2C09D30 VA: 0x2C0DD30
	|-ReadOnlyCollection<KeyValuePair<object, int>>.Contains
	|
	|-RVA: 0x2C0EB14 Offset: 0x2C0AB14 VA: 0x2C0EB14
	|-ReadOnlyCollection<KeyValuePair<object, float>>.Contains
	|
	|-RVA: 0x2C0F8F8 Offset: 0x2C0B8F8 VA: 0x2C0F8F8
	|-ReadOnlyCollection<KeyValuePair<float, object>>.Contains
	|
	|-RVA: 0x2C106F8 Offset: 0x2C0C6F8 VA: 0x2C106F8
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.Contains
	|
	|-RVA: 0x2C1156C Offset: 0x2C0D56C VA: 0x2C1156C
	|-ReadOnlyCollection<StructMultiKey<object, object>>.Contains
	|
	|-RVA: 0x2C12358 Offset: 0x2C0E358 VA: 0x2C12358
	|-ReadOnlyCollection<ValueTuple<short, short>>.Contains
	|
	|-RVA: 0x2C13134 Offset: 0x2C0F134 VA: 0x2C13134
	|-ReadOnlyCollection<ValueTuple<int, int>>.Contains
	|
	|-RVA: 0x2C13F08 Offset: 0x2C0FF08 VA: 0x2C13F08
	|-ReadOnlyCollection<ValueTuple<int, object>>.Contains
	|
	|-RVA: 0x2C14CEC Offset: 0x2C10CEC VA: 0x2C14CEC
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.Contains
	|
	|-RVA: 0x2C15AE4 Offset: 0x2C11AE4 VA: 0x2C15AE4
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.Contains
	|
	|-RVA: 0x2C169C4 Offset: 0x2C129C4 VA: 0x2C169C4
	|-ReadOnlyCollection<ArchetypeUid>.Contains
	|
	|-RVA: 0x2C17798 Offset: 0x2C13798 VA: 0x2C17798
	|-ReadOnlyCollection<bool>.Contains
	|
	|-RVA: 0x2C18574 Offset: 0x2C14574 VA: 0x2C18574
	|-ReadOnlyCollection<byte>.Contains
	|
	|-RVA: 0x2C19348 Offset: 0x2C15348 VA: 0x2C19348
	|-ReadOnlyCollection<ByteEnum>.Contains
	|
	|-RVA: 0x2C1A294 Offset: 0x2C16294 VA: 0x2C1A294
	|-ReadOnlyCollection<char>.Contains
	|
	|-RVA: 0x2C1B068 Offset: 0x2C17068 VA: 0x2C1B068
	|-ReadOnlyCollection<Color>.Contains
	|
	|-RVA: 0x2C1BE94 Offset: 0x2C17E94 VA: 0x2C1BE94
	|-ReadOnlyCollection<Color32>.Contains
	|
	|-RVA: 0x2C1CC94 Offset: 0x2C18C94 VA: 0x2C1CC94
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.Contains
	|
	|-RVA: 0x2C1DB70 Offset: 0x2C19B70 VA: 0x2C1DB70
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.Contains
	|
	|-RVA: 0x2C1E954 Offset: 0x2C1A954 VA: 0x2C1E954
	|-ReadOnlyCollection<DateTime>.Contains
	|
	|-RVA: 0x2C1F728 Offset: 0x2C1B728 VA: 0x2C1F728
	|-ReadOnlyCollection<DateTimeOffset>.Contains
	|
	|-RVA: 0x2C2050C Offset: 0x2C1C50C VA: 0x2C2050C
	|-ReadOnlyCollection<Decimal>.Contains
	|
	|-RVA: 0x2C21330 Offset: 0x2C1D330 VA: 0x2C21330
	|-ReadOnlyCollection<DefencePoint2>.Contains
	|
	|-RVA: 0x2C22104 Offset: 0x2C1E104 VA: 0x2C22104
	|-ReadOnlyCollection<double>.Contains
	|
	|-RVA: 0x2C22ED8 Offset: 0x2C1EED8 VA: 0x2C22ED8
	|-ReadOnlyCollection<EventSummary>.Contains
	|
	|-RVA: 0x2C23CBC Offset: 0x2C1FCBC VA: 0x2C23CBC
	|-ReadOnlyCollection<short>.Contains
	|
	|-RVA: 0x2C24A90 Offset: 0x2C20A90 VA: 0x2C24A90
	|-ReadOnlyCollection<Int16Enum>.Contains
	|
	|-RVA: 0x2C25864 Offset: 0x2C21864 VA: 0x2C25864
	|-ReadOnlyCollection<int>.Contains
	|
	|-RVA: 0x2C26638 Offset: 0x2C22638 VA: 0x2C26638
	|-ReadOnlyCollection<Int32Enum>.Contains
	|
	|-RVA: 0x2C2740C Offset: 0x2C2340C VA: 0x2C2740C
	|-ReadOnlyCollection<long>.Contains
	|
	|-RVA: 0x2C281E0 Offset: 0x2C241E0 VA: 0x2C281E0
	|-ReadOnlyCollection<InterpretedFrameInfo>.Contains
	|
	|-RVA: 0x2C28FE8 Offset: 0x2C24FE8 VA: 0x2C28FE8
	|-ReadOnlyCollection<JsonPosition>.Contains
	|
	|-RVA: 0x2C29EC8 Offset: 0x2C25EC8 VA: 0x2C29EC8
	|-ReadOnlyCollection<MaterialSearchData>.Contains
	|
	|-RVA: 0x2C2ACD0 Offset: 0x2C26CD0 VA: 0x2C2ACD0
	|-ReadOnlyCollection<MobActionTargetData>.Contains
	|
	|-RVA: 0x2C2BBD4 Offset: 0x2C27BD4 VA: 0x2C2BBD4
	|-ReadOnlyCollection<MobIconLabelData>.Contains
	|
	|-RVA: 0x2C2CAB4 Offset: 0x2C28AB4 VA: 0x2C2CAB4
	|-ReadOnlyCollection<object>.Contains
	|
	|-RVA: 0x2C2D888 Offset: 0x2C29888 VA: 0x2C2D888
	|-ReadOnlyCollection<PlayerLoopSystem>.Contains
	|
	|-RVA: 0x2C2E794 Offset: 0x2C2A794 VA: 0x2C2E794
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.Contains
	|
	|-RVA: 0x2C2F678 Offset: 0x2C2B678 VA: 0x2C2F678
	|-ReadOnlyCollection<RangePositionInfo>.Contains
	|
	|-RVA: 0x2C30464 Offset: 0x2C2C464 VA: 0x2C30464
	|-ReadOnlyCollection<ReinforceCristaData>.Contains
	|
	|-RVA: 0x2C31260 Offset: 0x2C2D260 VA: 0x2C31260
	|-ReadOnlyCollection<sbyte>.Contains
	|
	|-RVA: 0x2C32034 Offset: 0x2C2E034 VA: 0x2C32034
	|-ReadOnlyCollection<float>.Contains
	|
	|-RVA: 0x2C32E08 Offset: 0x2C2EE08 VA: 0x2C32E08
	|-ReadOnlyCollection<SkillIdData>.Contains
	|
	|-RVA: 0x2C33BDC Offset: 0x2C2FBDC VA: 0x2C33BDC
	|-ReadOnlyCollection<TimeSpan>.Contains
	|
	|-RVA: 0x2C349B0 Offset: 0x2C309B0 VA: 0x2C349B0
	|-ReadOnlyCollection<ushort>.Contains
	|
	|-RVA: 0x2C35784 Offset: 0x2C31784 VA: 0x2C35784
	|-ReadOnlyCollection<uint>.Contains
	|
	|-RVA: 0x2C36558 Offset: 0x2C32558 VA: 0x2C36558
	|-ReadOnlyCollection<ulong>.Contains
	|
	|-RVA: 0x2C3732C Offset: 0x2C3332C VA: 0x2C3732C
	|-ReadOnlyCollection<Vector2>.Contains
	|
	|-RVA: 0x2C38110 Offset: 0x2C34110 VA: 0x2C38110
	|-ReadOnlyCollection<Vector3>.Contains
	|
	|-RVA: 0x2C38F24 Offset: 0x2C34F24 VA: 0x2C38F24
	|-ReadOnlyCollection<X509ChainStatus>.Contains
	|
	|-RVA: 0x2C39D8C Offset: 0x2C35D8C VA: 0x2C39D8C
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.Contains
	|
	|-RVA: 0x2C3AFC8 Offset: 0x2C36FC8 VA: 0x2C3AFC8
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.Contains
	|
	|-RVA: 0x2C3BDD0 Offset: 0x2C37DD0 VA: 0x2C3BDD0
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.Contains
	|
	|-RVA: 0x2C3CCD8 Offset: 0x2C38CD8 VA: 0x2C3CCD8
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.Contains
	|
	|-RVA: 0x2C3DBBC Offset: 0x2C39BBC VA: 0x2C3DBBC
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.Contains
	|
	|-RVA: 0x2C3E998 Offset: 0x2C3A998 VA: 0x2C3E998
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.Contains
	|
	|-RVA: 0x2C3F79C Offset: 0x2C3B79C VA: 0x2C3F79C
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.Contains
	|
	|-RVA: 0x2C40598 Offset: 0x2C3C598 VA: 0x2C40598
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.Contains
	|
	|-RVA: 0x2C41398 Offset: 0x2C3D398 VA: 0x2C41398
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.Contains
	|
	|-RVA: 0x2C42208 Offset: 0x2C3E208 VA: 0x2C42208
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.Contains
	|
	|-RVA: 0x2C42FF4 Offset: 0x2C3EFF4 VA: 0x2C42FF4
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.Contains
	|
	|-RVA: 0x2C43DD0 Offset: 0x2C3FDD0 VA: 0x2C43DD0
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.Contains
	|
	|-RVA: 0x2C44BB4 Offset: 0x2C40BB4 VA: 0x2C44BB4
	|-ReadOnlyCollection<TrophyManager.TrophyData>.Contains
	|
	|-RVA: 0x2C459AC Offset: 0x2C419AC VA: 0x2C459AC
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.Contains
	|
	|-RVA: 0x2C468A4 Offset: 0x2C428A4 VA: 0x2C468A4
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.Contains
	|
	|-RVA: 0x2C47714 Offset: 0x2C43714 VA: 0x2C47714
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.Contains
	|
	|-RVA: 0x2C48504 Offset: 0x2C44504 VA: 0x2C48504
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.Contains
	|
	|-RVA: 0x2C49374 Offset: 0x2C45374 VA: 0x2C49374
	|-ReadOnlyCollection<UIMainManager.DropItemData>.Contains
	|
	|-RVA: 0x2C4A148 Offset: 0x2C46148 VA: 0x2C4A148
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.Contains
	|
	|-RVA: 0x2C4AF50 Offset: 0x2C46F50 VA: 0x2C4AF50
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.Contains
	|
	|-RVA: 0x2C4BE30 Offset: 0x2C47E30 VA: 0x2C4BE30
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Contains
	|
	|-RVA: 0x2C4CC30 Offset: 0x2C48C30 VA: 0x2C4CC30
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.Contains
	|
	|-RVA: 0x2C4DABC Offset: 0x2C49ABC VA: 0x2C4DABC
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04418 Offset: 0x2C00418 VA: 0x2C04418
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.CopyTo
	|
	|-RVA: 0x2C051FC Offset: 0x2C011FC VA: 0x2C051FC
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.CopyTo
	|
	|-RVA: 0x2C05FE0 Offset: 0x2C01FE0 VA: 0x2C05FE0
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.CopyTo
	|
	|-RVA: 0x2C06DC4 Offset: 0x2C02DC4 VA: 0x2C06DC4
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.CopyTo
	|
	|-RVA: 0x2C07BA0 Offset: 0x2C03BA0 VA: 0x2C07BA0
	|-ReadOnlyCollection<KeyValuePair<int, short>>.CopyTo
	|
	|-RVA: 0x2C08974 Offset: 0x2C04974 VA: 0x2C08974
	|-ReadOnlyCollection<KeyValuePair<int, int>>.CopyTo
	|
	|-RVA: 0x2C09750 Offset: 0x2C05750 VA: 0x2C09750
	|-ReadOnlyCollection<KeyValuePair<int, object>>.CopyTo
	|
	|-RVA: 0x2C0A52C Offset: 0x2C0652C VA: 0x2C0A52C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.CopyTo
	|
	|-RVA: 0x2C0B35C Offset: 0x2C0735C VA: 0x2C0B35C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.CopyTo
	|
	|-RVA: 0x2C0C214 Offset: 0x2C08214 VA: 0x2C0C214
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x2C0CFF0 Offset: 0x2C08FF0 VA: 0x2C0CFF0
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.CopyTo
	|
	|-RVA: 0x2C0DDD4 Offset: 0x2C09DD4 VA: 0x2C0DDD4
	|-ReadOnlyCollection<KeyValuePair<object, int>>.CopyTo
	|
	|-RVA: 0x2C0EBB8 Offset: 0x2C0ABB8 VA: 0x2C0EBB8
	|-ReadOnlyCollection<KeyValuePair<object, float>>.CopyTo
	|
	|-RVA: 0x2C0F99C Offset: 0x2C0B99C VA: 0x2C0F99C
	|-ReadOnlyCollection<KeyValuePair<float, object>>.CopyTo
	|
	|-RVA: 0x2C107B4 Offset: 0x2C0C7B4 VA: 0x2C107B4
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.CopyTo
	|
	|-RVA: 0x2C11610 Offset: 0x2C0D610 VA: 0x2C11610
	|-ReadOnlyCollection<StructMultiKey<object, object>>.CopyTo
	|
	|-RVA: 0x2C123F4 Offset: 0x2C0E3F4 VA: 0x2C123F4
	|-ReadOnlyCollection<ValueTuple<short, short>>.CopyTo
	|
	|-RVA: 0x2C131D0 Offset: 0x2C0F1D0 VA: 0x2C131D0
	|-ReadOnlyCollection<ValueTuple<int, int>>.CopyTo
	|
	|-RVA: 0x2C13FAC Offset: 0x2C0FFAC VA: 0x2C13FAC
	|-ReadOnlyCollection<ValueTuple<int, object>>.CopyTo
	|
	|-RVA: 0x2C14D88 Offset: 0x2C10D88 VA: 0x2C14D88
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.CopyTo
	|
	|-RVA: 0x2C15BB8 Offset: 0x2C11BB8 VA: 0x2C15BB8
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.CopyTo
	|
	|-RVA: 0x2C16A60 Offset: 0x2C12A60 VA: 0x2C16A60
	|-ReadOnlyCollection<ArchetypeUid>.CopyTo
	|
	|-RVA: 0x2C17834 Offset: 0x2C13834 VA: 0x2C17834
	|-ReadOnlyCollection<bool>.CopyTo
	|
	|-RVA: 0x2C18610 Offset: 0x2C14610 VA: 0x2C18610
	|-ReadOnlyCollection<byte>.CopyTo
	|
	|-RVA: 0x2C193E4 Offset: 0x2C153E4 VA: 0x2C193E4
	|-ReadOnlyCollection<ByteEnum>.CopyTo
	|
	|-RVA: 0x2C1A330 Offset: 0x2C16330 VA: 0x2C1A330
	|-ReadOnlyCollection<char>.CopyTo
	|
	|-RVA: 0x2C1B124 Offset: 0x2C17124 VA: 0x2C1B124
	|-ReadOnlyCollection<Color>.CopyTo
	|
	|-RVA: 0x2C1BF30 Offset: 0x2C17F30 VA: 0x2C1BF30
	|-ReadOnlyCollection<Color32>.CopyTo
	|
	|-RVA: 0x2C1CD68 Offset: 0x2C18D68 VA: 0x2C1CD68
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.CopyTo
	|
	|-RVA: 0x2C1DC14 Offset: 0x2C19C14 VA: 0x2C1DC14
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.CopyTo
	|
	|-RVA: 0x2C1E9F0 Offset: 0x2C1A9F0 VA: 0x2C1E9F0
	|-ReadOnlyCollection<DateTime>.CopyTo
	|
	|-RVA: 0x2C1F7CC Offset: 0x2C1B7CC VA: 0x2C1F7CC
	|-ReadOnlyCollection<DateTimeOffset>.CopyTo
	|
	|-RVA: 0x2C205B0 Offset: 0x2C1C5B0 VA: 0x2C205B0
	|-ReadOnlyCollection<Decimal>.CopyTo
	|
	|-RVA: 0x2C213CC Offset: 0x2C1D3CC VA: 0x2C213CC
	|-ReadOnlyCollection<DefencePoint2>.CopyTo
	|
	|-RVA: 0x2C221A0 Offset: 0x2C1E1A0 VA: 0x2C221A0
	|-ReadOnlyCollection<double>.CopyTo
	|
	|-RVA: 0x2C22F7C Offset: 0x2C1EF7C VA: 0x2C22F7C
	|-ReadOnlyCollection<EventSummary>.CopyTo
	|
	|-RVA: 0x2C23D58 Offset: 0x2C1FD58 VA: 0x2C23D58
	|-ReadOnlyCollection<short>.CopyTo
	|
	|-RVA: 0x2C24B2C Offset: 0x2C20B2C VA: 0x2C24B2C
	|-ReadOnlyCollection<Int16Enum>.CopyTo
	|
	|-RVA: 0x2C25900 Offset: 0x2C21900 VA: 0x2C25900
	|-ReadOnlyCollection<int>.CopyTo
	|
	|-RVA: 0x2C266D4 Offset: 0x2C226D4 VA: 0x2C266D4
	|-ReadOnlyCollection<Int32Enum>.CopyTo
	|
	|-RVA: 0x2C274A8 Offset: 0x2C234A8 VA: 0x2C274A8
	|-ReadOnlyCollection<long>.CopyTo
	|
	|-RVA: 0x2C28284 Offset: 0x2C24284 VA: 0x2C28284
	|-ReadOnlyCollection<InterpretedFrameInfo>.CopyTo
	|
	|-RVA: 0x2C290BC Offset: 0x2C250BC VA: 0x2C290BC
	|-ReadOnlyCollection<JsonPosition>.CopyTo
	|
	|-RVA: 0x2C29F6C Offset: 0x2C25F6C VA: 0x2C29F6C
	|-ReadOnlyCollection<MaterialSearchData>.CopyTo
	|
	|-RVA: 0x2C2ADA4 Offset: 0x2C26DA4 VA: 0x2C2ADA4
	|-ReadOnlyCollection<MobActionTargetData>.CopyTo
	|
	|-RVA: 0x2C2BCA8 Offset: 0x2C27CA8 VA: 0x2C2BCA8
	|-ReadOnlyCollection<MobIconLabelData>.CopyTo
	|
	|-RVA: 0x2C2CB50 Offset: 0x2C28B50 VA: 0x2C2CB50
	|-ReadOnlyCollection<object>.CopyTo
	|
	|-RVA: 0x2C2D95C Offset: 0x2C2995C VA: 0x2C2D95C
	|-ReadOnlyCollection<PlayerLoopSystem>.CopyTo
	|
	|-RVA: 0x2C2E868 Offset: 0x2C2A868 VA: 0x2C2E868
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.CopyTo
	|
	|-RVA: 0x2C2F71C Offset: 0x2C2B71C VA: 0x2C2F71C
	|-ReadOnlyCollection<RangePositionInfo>.CopyTo
	|
	|-RVA: 0x2C30508 Offset: 0x2C2C508 VA: 0x2C30508
	|-ReadOnlyCollection<ReinforceCristaData>.CopyTo
	|
	|-RVA: 0x2C312FC Offset: 0x2C2D2FC VA: 0x2C312FC
	|-ReadOnlyCollection<sbyte>.CopyTo
	|
	|-RVA: 0x2C320D0 Offset: 0x2C2E0D0 VA: 0x2C320D0
	|-ReadOnlyCollection<float>.CopyTo
	|
	|-RVA: 0x2C32EA4 Offset: 0x2C2EEA4 VA: 0x2C32EA4
	|-ReadOnlyCollection<SkillIdData>.CopyTo
	|
	|-RVA: 0x2C33C78 Offset: 0x2C2FC78 VA: 0x2C33C78
	|-ReadOnlyCollection<TimeSpan>.CopyTo
	|
	|-RVA: 0x2C34A4C Offset: 0x2C30A4C VA: 0x2C34A4C
	|-ReadOnlyCollection<ushort>.CopyTo
	|
	|-RVA: 0x2C35820 Offset: 0x2C31820 VA: 0x2C35820
	|-ReadOnlyCollection<uint>.CopyTo
	|
	|-RVA: 0x2C365F4 Offset: 0x2C325F4 VA: 0x2C365F4
	|-ReadOnlyCollection<ulong>.CopyTo
	|
	|-RVA: 0x2C373D0 Offset: 0x2C333D0 VA: 0x2C373D0
	|-ReadOnlyCollection<Vector2>.CopyTo
	|
	|-RVA: 0x2C381C4 Offset: 0x2C341C4 VA: 0x2C381C4
	|-ReadOnlyCollection<Vector3>.CopyTo
	|
	|-RVA: 0x2C38FC8 Offset: 0x2C34FC8 VA: 0x2C38FC8
	|-ReadOnlyCollection<X509ChainStatus>.CopyTo
	|
	|-RVA: 0x2C39ED4 Offset: 0x2C35ED4 VA: 0x2C39ED4
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.CopyTo
	|
	|-RVA: 0x2C3B06C Offset: 0x2C3706C VA: 0x2C3B06C
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.CopyTo
	|
	|-RVA: 0x2C3BEA4 Offset: 0x2C37EA4 VA: 0x2C3BEA4
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.CopyTo
	|
	|-RVA: 0x2C3CDAC Offset: 0x2C38DAC VA: 0x2C3CDAC
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.CopyTo
	|
	|-RVA: 0x2C3DC58 Offset: 0x2C39C58 VA: 0x2C3DC58
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.CopyTo
	|
	|-RVA: 0x2C3EA3C Offset: 0x2C3AA3C VA: 0x2C3EA3C
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.CopyTo
	|
	|-RVA: 0x2C3F840 Offset: 0x2C3B840 VA: 0x2C3F840
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.CopyTo
	|
	|-RVA: 0x2C4063C Offset: 0x2C3C63C VA: 0x2C4063C
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.CopyTo
	|
	|-RVA: 0x2C41454 Offset: 0x2C3D454 VA: 0x2C41454
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.CopyTo
	|
	|-RVA: 0x2C422AC Offset: 0x2C3E2AC VA: 0x2C422AC
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.CopyTo
	|
	|-RVA: 0x2C43090 Offset: 0x2C3F090 VA: 0x2C43090
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.CopyTo
	|
	|-RVA: 0x2C43E74 Offset: 0x2C3FE74 VA: 0x2C43E74
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.CopyTo
	|
	|-RVA: 0x2C44C50 Offset: 0x2C40C50 VA: 0x2C44C50
	|-ReadOnlyCollection<TrophyManager.TrophyData>.CopyTo
	|
	|-RVA: 0x2C45A80 Offset: 0x2C41A80 VA: 0x2C45A80
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.CopyTo
	|
	|-RVA: 0x2C46960 Offset: 0x2C42960 VA: 0x2C46960
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.CopyTo
	|
	|-RVA: 0x2C477B0 Offset: 0x2C437B0 VA: 0x2C477B0
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.CopyTo
	|
	|-RVA: 0x2C485C0 Offset: 0x2C445C0 VA: 0x2C485C0
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.CopyTo
	|
	|-RVA: 0x2C49410 Offset: 0x2C45410 VA: 0x2C49410
	|-ReadOnlyCollection<UIMainManager.DropItemData>.CopyTo
	|
	|-RVA: 0x2C4A1EC Offset: 0x2C461EC VA: 0x2C4A1EC
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.CopyTo
	|
	|-RVA: 0x2C4B024 Offset: 0x2C47024 VA: 0x2C4B024
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.CopyTo
	|
	|-RVA: 0x2C4BED4 Offset: 0x2C47ED4 VA: 0x2C4BED4
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.CopyTo
	|
	|-RVA: 0x2C4CCEC Offset: 0x2C48CEC VA: 0x2C4CCEC
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.CopyTo
	|
	|-RVA: 0x2C4DB78 Offset: 0x2C49B78 VA: 0x2C4DB78
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C044BC Offset: 0x2C004BC VA: 0x2C044BC
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.GetEnumerator
	|
	|-RVA: 0x2C052A0 Offset: 0x2C012A0 VA: 0x2C052A0
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.GetEnumerator
	|
	|-RVA: 0x2C06084 Offset: 0x2C02084 VA: 0x2C06084
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.GetEnumerator
	|
	|-RVA: 0x2C06E68 Offset: 0x2C02E68 VA: 0x2C06E68
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.GetEnumerator
	|
	|-RVA: 0x2C07C44 Offset: 0x2C03C44 VA: 0x2C07C44
	|-ReadOnlyCollection<KeyValuePair<int, short>>.GetEnumerator
	|
	|-RVA: 0x2C08A18 Offset: 0x2C04A18 VA: 0x2C08A18
	|-ReadOnlyCollection<KeyValuePair<int, int>>.GetEnumerator
	|
	|-RVA: 0x2C097F4 Offset: 0x2C057F4 VA: 0x2C097F4
	|-ReadOnlyCollection<KeyValuePair<int, object>>.GetEnumerator
	|
	|-RVA: 0x2C0A5D0 Offset: 0x2C065D0 VA: 0x2C0A5D0
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.GetEnumerator
	|
	|-RVA: 0x2C0B400 Offset: 0x2C07400 VA: 0x2C0B400
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.GetEnumerator
	|
	|-RVA: 0x2C0C2B8 Offset: 0x2C082B8 VA: 0x2C0C2B8
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.GetEnumerator
	|
	|-RVA: 0x2C0D094 Offset: 0x2C09094 VA: 0x2C0D094
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.GetEnumerator
	|
	|-RVA: 0x2C0DE78 Offset: 0x2C09E78 VA: 0x2C0DE78
	|-ReadOnlyCollection<KeyValuePair<object, int>>.GetEnumerator
	|
	|-RVA: 0x2C0EC5C Offset: 0x2C0AC5C VA: 0x2C0EC5C
	|-ReadOnlyCollection<KeyValuePair<object, float>>.GetEnumerator
	|
	|-RVA: 0x2C0FA40 Offset: 0x2C0BA40 VA: 0x2C0FA40
	|-ReadOnlyCollection<KeyValuePair<float, object>>.GetEnumerator
	|
	|-RVA: 0x2C10858 Offset: 0x2C0C858 VA: 0x2C10858
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.GetEnumerator
	|
	|-RVA: 0x2C116B4 Offset: 0x2C0D6B4 VA: 0x2C116B4
	|-ReadOnlyCollection<StructMultiKey<object, object>>.GetEnumerator
	|
	|-RVA: 0x2C12498 Offset: 0x2C0E498 VA: 0x2C12498
	|-ReadOnlyCollection<ValueTuple<short, short>>.GetEnumerator
	|
	|-RVA: 0x2C13274 Offset: 0x2C0F274 VA: 0x2C13274
	|-ReadOnlyCollection<ValueTuple<int, int>>.GetEnumerator
	|
	|-RVA: 0x2C14050 Offset: 0x2C10050 VA: 0x2C14050
	|-ReadOnlyCollection<ValueTuple<int, object>>.GetEnumerator
	|
	|-RVA: 0x2C14E2C Offset: 0x2C10E2C VA: 0x2C14E2C
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.GetEnumerator
	|
	|-RVA: 0x2C15C5C Offset: 0x2C11C5C VA: 0x2C15C5C
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.GetEnumerator
	|
	|-RVA: 0x2C16B04 Offset: 0x2C12B04 VA: 0x2C16B04
	|-ReadOnlyCollection<ArchetypeUid>.GetEnumerator
	|
	|-RVA: 0x2C178D8 Offset: 0x2C138D8 VA: 0x2C178D8
	|-ReadOnlyCollection<bool>.GetEnumerator
	|
	|-RVA: 0x2C186B4 Offset: 0x2C146B4 VA: 0x2C186B4
	|-ReadOnlyCollection<byte>.GetEnumerator
	|
	|-RVA: 0x2C19488 Offset: 0x2C15488 VA: 0x2C19488
	|-ReadOnlyCollection<ByteEnum>.GetEnumerator
	|
	|-RVA: 0x2C1A3D4 Offset: 0x2C163D4 VA: 0x2C1A3D4
	|-ReadOnlyCollection<char>.GetEnumerator
	|
	|-RVA: 0x2C1B1C8 Offset: 0x2C171C8 VA: 0x2C1B1C8
	|-ReadOnlyCollection<Color>.GetEnumerator
	|
	|-RVA: 0x2C1BFD4 Offset: 0x2C17FD4 VA: 0x2C1BFD4
	|-ReadOnlyCollection<Color32>.GetEnumerator
	|
	|-RVA: 0x2C1CE0C Offset: 0x2C18E0C VA: 0x2C1CE0C
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.GetEnumerator
	|
	|-RVA: 0x2C1DCB8 Offset: 0x2C19CB8 VA: 0x2C1DCB8
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.GetEnumerator
	|
	|-RVA: 0x2C1EA94 Offset: 0x2C1AA94 VA: 0x2C1EA94
	|-ReadOnlyCollection<DateTime>.GetEnumerator
	|
	|-RVA: 0x2C1F870 Offset: 0x2C1B870 VA: 0x2C1F870
	|-ReadOnlyCollection<DateTimeOffset>.GetEnumerator
	|
	|-RVA: 0x2C20654 Offset: 0x2C1C654 VA: 0x2C20654
	|-ReadOnlyCollection<Decimal>.GetEnumerator
	|
	|-RVA: 0x2C21470 Offset: 0x2C1D470 VA: 0x2C21470
	|-ReadOnlyCollection<DefencePoint2>.GetEnumerator
	|
	|-RVA: 0x2C22244 Offset: 0x2C1E244 VA: 0x2C22244
	|-ReadOnlyCollection<double>.GetEnumerator
	|
	|-RVA: 0x2C23020 Offset: 0x2C1F020 VA: 0x2C23020
	|-ReadOnlyCollection<EventSummary>.GetEnumerator
	|
	|-RVA: 0x2C23DFC Offset: 0x2C1FDFC VA: 0x2C23DFC
	|-ReadOnlyCollection<short>.GetEnumerator
	|
	|-RVA: 0x2C24BD0 Offset: 0x2C20BD0 VA: 0x2C24BD0
	|-ReadOnlyCollection<Int16Enum>.GetEnumerator
	|
	|-RVA: 0x2C259A4 Offset: 0x2C219A4 VA: 0x2C259A4
	|-ReadOnlyCollection<int>.GetEnumerator
	|
	|-RVA: 0x2C26778 Offset: 0x2C22778 VA: 0x2C26778
	|-ReadOnlyCollection<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2C2754C Offset: 0x2C2354C VA: 0x2C2754C
	|-ReadOnlyCollection<long>.GetEnumerator
	|
	|-RVA: 0x2C28328 Offset: 0x2C24328 VA: 0x2C28328
	|-ReadOnlyCollection<InterpretedFrameInfo>.GetEnumerator
	|
	|-RVA: 0x2C29160 Offset: 0x2C25160 VA: 0x2C29160
	|-ReadOnlyCollection<JsonPosition>.GetEnumerator
	|
	|-RVA: 0x2C2A010 Offset: 0x2C26010 VA: 0x2C2A010
	|-ReadOnlyCollection<MaterialSearchData>.GetEnumerator
	|
	|-RVA: 0x2C2AE48 Offset: 0x2C26E48 VA: 0x2C2AE48
	|-ReadOnlyCollection<MobActionTargetData>.GetEnumerator
	|
	|-RVA: 0x2C2BD4C Offset: 0x2C27D4C VA: 0x2C2BD4C
	|-ReadOnlyCollection<MobIconLabelData>.GetEnumerator
	|
	|-RVA: 0x2C2CBF4 Offset: 0x2C28BF4 VA: 0x2C2CBF4
	|-ReadOnlyCollection<object>.GetEnumerator
	|
	|-RVA: 0x2C2DA00 Offset: 0x2C29A00 VA: 0x2C2DA00
	|-ReadOnlyCollection<PlayerLoopSystem>.GetEnumerator
	|
	|-RVA: 0x2C2E90C Offset: 0x2C2A90C VA: 0x2C2E90C
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.GetEnumerator
	|
	|-RVA: 0x2C2F7C0 Offset: 0x2C2B7C0 VA: 0x2C2F7C0
	|-ReadOnlyCollection<RangePositionInfo>.GetEnumerator
	|
	|-RVA: 0x2C305AC Offset: 0x2C2C5AC VA: 0x2C305AC
	|-ReadOnlyCollection<ReinforceCristaData>.GetEnumerator
	|
	|-RVA: 0x2C313A0 Offset: 0x2C2D3A0 VA: 0x2C313A0
	|-ReadOnlyCollection<sbyte>.GetEnumerator
	|
	|-RVA: 0x2C32174 Offset: 0x2C2E174 VA: 0x2C32174
	|-ReadOnlyCollection<float>.GetEnumerator
	|
	|-RVA: 0x2C32F48 Offset: 0x2C2EF48 VA: 0x2C32F48
	|-ReadOnlyCollection<SkillIdData>.GetEnumerator
	|
	|-RVA: 0x2C33D1C Offset: 0x2C2FD1C VA: 0x2C33D1C
	|-ReadOnlyCollection<TimeSpan>.GetEnumerator
	|
	|-RVA: 0x2C34AF0 Offset: 0x2C30AF0 VA: 0x2C34AF0
	|-ReadOnlyCollection<ushort>.GetEnumerator
	|
	|-RVA: 0x2C358C4 Offset: 0x2C318C4 VA: 0x2C358C4
	|-ReadOnlyCollection<uint>.GetEnumerator
	|
	|-RVA: 0x2C36698 Offset: 0x2C32698 VA: 0x2C36698
	|-ReadOnlyCollection<ulong>.GetEnumerator
	|
	|-RVA: 0x2C37474 Offset: 0x2C33474 VA: 0x2C37474
	|-ReadOnlyCollection<Vector2>.GetEnumerator
	|
	|-RVA: 0x2C38268 Offset: 0x2C34268 VA: 0x2C38268
	|-ReadOnlyCollection<Vector3>.GetEnumerator
	|
	|-RVA: 0x2C3906C Offset: 0x2C3506C VA: 0x2C3906C
	|-ReadOnlyCollection<X509ChainStatus>.GetEnumerator
	|
	|-RVA: 0x2C39F78 Offset: 0x2C35F78 VA: 0x2C39F78
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.GetEnumerator
	|
	|-RVA: 0x2C3B110 Offset: 0x2C37110 VA: 0x2C3B110
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.GetEnumerator
	|
	|-RVA: 0x2C3BF48 Offset: 0x2C37F48 VA: 0x2C3BF48
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.GetEnumerator
	|
	|-RVA: 0x2C3CE50 Offset: 0x2C38E50 VA: 0x2C3CE50
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.GetEnumerator
	|
	|-RVA: 0x2C3DCFC Offset: 0x2C39CFC VA: 0x2C3DCFC
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.GetEnumerator
	|
	|-RVA: 0x2C3EAE0 Offset: 0x2C3AAE0 VA: 0x2C3EAE0
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.GetEnumerator
	|
	|-RVA: 0x2C3F8E4 Offset: 0x2C3B8E4 VA: 0x2C3F8E4
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.GetEnumerator
	|
	|-RVA: 0x2C406E0 Offset: 0x2C3C6E0 VA: 0x2C406E0
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.GetEnumerator
	|
	|-RVA: 0x2C414F8 Offset: 0x2C3D4F8 VA: 0x2C414F8
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.GetEnumerator
	|
	|-RVA: 0x2C42350 Offset: 0x2C3E350 VA: 0x2C42350
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.GetEnumerator
	|
	|-RVA: 0x2C43134 Offset: 0x2C3F134 VA: 0x2C43134
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.GetEnumerator
	|
	|-RVA: 0x2C43F18 Offset: 0x2C3FF18 VA: 0x2C43F18
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.GetEnumerator
	|
	|-RVA: 0x2C44CF4 Offset: 0x2C40CF4 VA: 0x2C44CF4
	|-ReadOnlyCollection<TrophyManager.TrophyData>.GetEnumerator
	|
	|-RVA: 0x2C45B24 Offset: 0x2C41B24 VA: 0x2C45B24
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.GetEnumerator
	|
	|-RVA: 0x2C46A04 Offset: 0x2C42A04 VA: 0x2C46A04
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.GetEnumerator
	|
	|-RVA: 0x2C47854 Offset: 0x2C43854 VA: 0x2C47854
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.GetEnumerator
	|
	|-RVA: 0x2C48664 Offset: 0x2C44664 VA: 0x2C48664
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.GetEnumerator
	|
	|-RVA: 0x2C494B4 Offset: 0x2C454B4 VA: 0x2C494B4
	|-ReadOnlyCollection<UIMainManager.DropItemData>.GetEnumerator
	|
	|-RVA: 0x2C4A290 Offset: 0x2C46290 VA: 0x2C4A290
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.GetEnumerator
	|
	|-RVA: 0x2C4B0C8 Offset: 0x2C470C8 VA: 0x2C4B0C8
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.GetEnumerator
	|
	|-RVA: 0x2C4BF78 Offset: 0x2C47F78 VA: 0x2C4BF78
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.GetEnumerator
	|
	|-RVA: 0x2C4CD90 Offset: 0x2C48D90 VA: 0x2C4CD90
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.GetEnumerator
	|
	|-RVA: 0x2C4DC1C Offset: 0x2C49C1C VA: 0x2C4DC1C
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04544 Offset: 0x2C00544 VA: 0x2C04544
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.IndexOf
	|
	|-RVA: 0x2C05328 Offset: 0x2C01328 VA: 0x2C05328
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.IndexOf
	|
	|-RVA: 0x2C0610C Offset: 0x2C0210C VA: 0x2C0610C
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.IndexOf
	|
	|-RVA: 0x2C06EF0 Offset: 0x2C02EF0 VA: 0x2C06EF0
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.IndexOf
	|
	|-RVA: 0x2C07CCC Offset: 0x2C03CCC VA: 0x2C07CCC
	|-ReadOnlyCollection<KeyValuePair<int, short>>.IndexOf
	|
	|-RVA: 0x2C08AA0 Offset: 0x2C04AA0 VA: 0x2C08AA0
	|-ReadOnlyCollection<KeyValuePair<int, int>>.IndexOf
	|
	|-RVA: 0x2C0987C Offset: 0x2C0587C VA: 0x2C0987C
	|-ReadOnlyCollection<KeyValuePair<int, object>>.IndexOf
	|
	|-RVA: 0x2C0A658 Offset: 0x2C06658 VA: 0x2C0A658
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.IndexOf
	|
	|-RVA: 0x2C0B488 Offset: 0x2C07488 VA: 0x2C0B488
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.IndexOf
	|
	|-RVA: 0x2C0C340 Offset: 0x2C08340 VA: 0x2C0C340
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x2C0D11C Offset: 0x2C0911C VA: 0x2C0D11C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.IndexOf
	|
	|-RVA: 0x2C0DF00 Offset: 0x2C09F00 VA: 0x2C0DF00
	|-ReadOnlyCollection<KeyValuePair<object, int>>.IndexOf
	|
	|-RVA: 0x2C0ECE4 Offset: 0x2C0ACE4 VA: 0x2C0ECE4
	|-ReadOnlyCollection<KeyValuePair<object, float>>.IndexOf
	|
	|-RVA: 0x2C0FAC8 Offset: 0x2C0BAC8 VA: 0x2C0FAC8
	|-ReadOnlyCollection<KeyValuePair<float, object>>.IndexOf
	|
	|-RVA: 0x2C108E0 Offset: 0x2C0C8E0 VA: 0x2C108E0
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.IndexOf
	|
	|-RVA: 0x2C1173C Offset: 0x2C0D73C VA: 0x2C1173C
	|-ReadOnlyCollection<StructMultiKey<object, object>>.IndexOf
	|
	|-RVA: 0x2C12520 Offset: 0x2C0E520 VA: 0x2C12520
	|-ReadOnlyCollection<ValueTuple<short, short>>.IndexOf
	|
	|-RVA: 0x2C132FC Offset: 0x2C0F2FC VA: 0x2C132FC
	|-ReadOnlyCollection<ValueTuple<int, int>>.IndexOf
	|
	|-RVA: 0x2C140D8 Offset: 0x2C100D8 VA: 0x2C140D8
	|-ReadOnlyCollection<ValueTuple<int, object>>.IndexOf
	|
	|-RVA: 0x2C14EB4 Offset: 0x2C10EB4 VA: 0x2C14EB4
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.IndexOf
	|
	|-RVA: 0x2C15CE4 Offset: 0x2C11CE4 VA: 0x2C15CE4
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.IndexOf
	|
	|-RVA: 0x2C16B8C Offset: 0x2C12B8C VA: 0x2C16B8C
	|-ReadOnlyCollection<ArchetypeUid>.IndexOf
	|
	|-RVA: 0x2C17960 Offset: 0x2C13960 VA: 0x2C17960
	|-ReadOnlyCollection<bool>.IndexOf
	|
	|-RVA: 0x2C1873C Offset: 0x2C1473C VA: 0x2C1873C
	|-ReadOnlyCollection<byte>.IndexOf
	|
	|-RVA: 0x2C19510 Offset: 0x2C15510 VA: 0x2C19510
	|-ReadOnlyCollection<ByteEnum>.IndexOf
	|
	|-RVA: 0x2C1A45C Offset: 0x2C1645C VA: 0x2C1A45C
	|-ReadOnlyCollection<char>.IndexOf
	|
	|-RVA: 0x2C1B250 Offset: 0x2C17250 VA: 0x2C1B250
	|-ReadOnlyCollection<Color>.IndexOf
	|
	|-RVA: 0x2C1C05C Offset: 0x2C1805C VA: 0x2C1C05C
	|-ReadOnlyCollection<Color32>.IndexOf
	|
	|-RVA: 0x2C1CE94 Offset: 0x2C18E94 VA: 0x2C1CE94
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.IndexOf
	|
	|-RVA: 0x2C1DD40 Offset: 0x2C19D40 VA: 0x2C1DD40
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.IndexOf
	|
	|-RVA: 0x2C1EB1C Offset: 0x2C1AB1C VA: 0x2C1EB1C
	|-ReadOnlyCollection<DateTime>.IndexOf
	|
	|-RVA: 0x2C1F8F8 Offset: 0x2C1B8F8 VA: 0x2C1F8F8
	|-ReadOnlyCollection<DateTimeOffset>.IndexOf
	|
	|-RVA: 0x2C206DC Offset: 0x2C1C6DC VA: 0x2C206DC
	|-ReadOnlyCollection<Decimal>.IndexOf
	|
	|-RVA: 0x2C214F8 Offset: 0x2C1D4F8 VA: 0x2C214F8
	|-ReadOnlyCollection<DefencePoint2>.IndexOf
	|
	|-RVA: 0x2C222CC Offset: 0x2C1E2CC VA: 0x2C222CC
	|-ReadOnlyCollection<double>.IndexOf
	|
	|-RVA: 0x2C230A8 Offset: 0x2C1F0A8 VA: 0x2C230A8
	|-ReadOnlyCollection<EventSummary>.IndexOf
	|
	|-RVA: 0x2C23E84 Offset: 0x2C1FE84 VA: 0x2C23E84
	|-ReadOnlyCollection<short>.IndexOf
	|
	|-RVA: 0x2C24C58 Offset: 0x2C20C58 VA: 0x2C24C58
	|-ReadOnlyCollection<Int16Enum>.IndexOf
	|
	|-RVA: 0x2C25A2C Offset: 0x2C21A2C VA: 0x2C25A2C
	|-ReadOnlyCollection<int>.IndexOf
	|
	|-RVA: 0x2C26800 Offset: 0x2C22800 VA: 0x2C26800
	|-ReadOnlyCollection<Int32Enum>.IndexOf
	|
	|-RVA: 0x2C275D4 Offset: 0x2C235D4 VA: 0x2C275D4
	|-ReadOnlyCollection<long>.IndexOf
	|
	|-RVA: 0x2C283B0 Offset: 0x2C243B0 VA: 0x2C283B0
	|-ReadOnlyCollection<InterpretedFrameInfo>.IndexOf
	|
	|-RVA: 0x2C291E8 Offset: 0x2C251E8 VA: 0x2C291E8
	|-ReadOnlyCollection<JsonPosition>.IndexOf
	|
	|-RVA: 0x2C2A098 Offset: 0x2C26098 VA: 0x2C2A098
	|-ReadOnlyCollection<MaterialSearchData>.IndexOf
	|
	|-RVA: 0x2C2AED0 Offset: 0x2C26ED0 VA: 0x2C2AED0
	|-ReadOnlyCollection<MobActionTargetData>.IndexOf
	|
	|-RVA: 0x2C2BDD4 Offset: 0x2C27DD4 VA: 0x2C2BDD4
	|-ReadOnlyCollection<MobIconLabelData>.IndexOf
	|
	|-RVA: 0x2C2CC7C Offset: 0x2C28C7C VA: 0x2C2CC7C
	|-ReadOnlyCollection<object>.IndexOf
	|
	|-RVA: 0x2C2DA88 Offset: 0x2C29A88 VA: 0x2C2DA88
	|-ReadOnlyCollection<PlayerLoopSystem>.IndexOf
	|
	|-RVA: 0x2C2E994 Offset: 0x2C2A994 VA: 0x2C2E994
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.IndexOf
	|
	|-RVA: 0x2C2F848 Offset: 0x2C2B848 VA: 0x2C2F848
	|-ReadOnlyCollection<RangePositionInfo>.IndexOf
	|
	|-RVA: 0x2C30634 Offset: 0x2C2C634 VA: 0x2C30634
	|-ReadOnlyCollection<ReinforceCristaData>.IndexOf
	|
	|-RVA: 0x2C31428 Offset: 0x2C2D428 VA: 0x2C31428
	|-ReadOnlyCollection<sbyte>.IndexOf
	|
	|-RVA: 0x2C321FC Offset: 0x2C2E1FC VA: 0x2C321FC
	|-ReadOnlyCollection<float>.IndexOf
	|
	|-RVA: 0x2C32FD0 Offset: 0x2C2EFD0 VA: 0x2C32FD0
	|-ReadOnlyCollection<SkillIdData>.IndexOf
	|
	|-RVA: 0x2C33DA4 Offset: 0x2C2FDA4 VA: 0x2C33DA4
	|-ReadOnlyCollection<TimeSpan>.IndexOf
	|
	|-RVA: 0x2C34B78 Offset: 0x2C30B78 VA: 0x2C34B78
	|-ReadOnlyCollection<ushort>.IndexOf
	|
	|-RVA: 0x2C3594C Offset: 0x2C3194C VA: 0x2C3594C
	|-ReadOnlyCollection<uint>.IndexOf
	|
	|-RVA: 0x2C36720 Offset: 0x2C32720 VA: 0x2C36720
	|-ReadOnlyCollection<ulong>.IndexOf
	|
	|-RVA: 0x2C374FC Offset: 0x2C334FC VA: 0x2C374FC
	|-ReadOnlyCollection<Vector2>.IndexOf
	|
	|-RVA: 0x2C382F0 Offset: 0x2C342F0 VA: 0x2C382F0
	|-ReadOnlyCollection<Vector3>.IndexOf
	|
	|-RVA: 0x2C390F4 Offset: 0x2C350F4 VA: 0x2C390F4
	|-ReadOnlyCollection<X509ChainStatus>.IndexOf
	|
	|-RVA: 0x2C3A000 Offset: 0x2C36000 VA: 0x2C3A000
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x2C3B198 Offset: 0x2C37198 VA: 0x2C3B198
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.IndexOf
	|
	|-RVA: 0x2C3BFD0 Offset: 0x2C37FD0 VA: 0x2C3BFD0
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.IndexOf
	|
	|-RVA: 0x2C3CED8 Offset: 0x2C38ED8 VA: 0x2C3CED8
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.IndexOf
	|
	|-RVA: 0x2C3DD84 Offset: 0x2C39D84 VA: 0x2C3DD84
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.IndexOf
	|
	|-RVA: 0x2C3EB68 Offset: 0x2C3AB68 VA: 0x2C3EB68
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.IndexOf
	|
	|-RVA: 0x2C3F96C Offset: 0x2C3B96C VA: 0x2C3F96C
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.IndexOf
	|
	|-RVA: 0x2C40768 Offset: 0x2C3C768 VA: 0x2C40768
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.IndexOf
	|
	|-RVA: 0x2C41580 Offset: 0x2C3D580 VA: 0x2C41580
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.IndexOf
	|
	|-RVA: 0x2C423D8 Offset: 0x2C3E3D8 VA: 0x2C423D8
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.IndexOf
	|
	|-RVA: 0x2C431BC Offset: 0x2C3F1BC VA: 0x2C431BC
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.IndexOf
	|
	|-RVA: 0x2C43FA0 Offset: 0x2C3FFA0 VA: 0x2C43FA0
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.IndexOf
	|
	|-RVA: 0x2C44D7C Offset: 0x2C40D7C VA: 0x2C44D7C
	|-ReadOnlyCollection<TrophyManager.TrophyData>.IndexOf
	|
	|-RVA: 0x2C45BAC Offset: 0x2C41BAC VA: 0x2C45BAC
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.IndexOf
	|
	|-RVA: 0x2C46A8C Offset: 0x2C42A8C VA: 0x2C46A8C
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.IndexOf
	|
	|-RVA: 0x2C478DC Offset: 0x2C438DC VA: 0x2C478DC
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.IndexOf
	|
	|-RVA: 0x2C486EC Offset: 0x2C446EC VA: 0x2C486EC
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.IndexOf
	|
	|-RVA: 0x2C4953C Offset: 0x2C4553C VA: 0x2C4953C
	|-ReadOnlyCollection<UIMainManager.DropItemData>.IndexOf
	|
	|-RVA: 0x2C4A318 Offset: 0x2C46318 VA: 0x2C4A318
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.IndexOf
	|
	|-RVA: 0x2C4B150 Offset: 0x2C47150 VA: 0x2C4B150
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.IndexOf
	|
	|-RVA: 0x2C4C000 Offset: 0x2C48000 VA: 0x2C4C000
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IndexOf
	|
	|-RVA: 0x2C4CE18 Offset: 0x2C48E18 VA: 0x2C4CE18
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.IndexOf
	|
	|-RVA: 0x2C4DCA4 Offset: 0x2C49CA4 VA: 0x2C4DCA4
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C045E8 Offset: 0x2C005E8 VA: 0x2C045E8
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C053C4 Offset: 0x2C013C4 VA: 0x2C053C4
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C061A8 Offset: 0x2C021A8 VA: 0x2C061A8
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C06F94 Offset: 0x2C02F94 VA: 0x2C06F94
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C07D68 Offset: 0x2C03D68 VA: 0x2C07D68
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C08B3C Offset: 0x2C04B3C VA: 0x2C08B3C
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C09920 Offset: 0x2C05920 VA: 0x2C09920
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C0A6F4 Offset: 0x2C066F4 VA: 0x2C0A6F4
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C0B558 Offset: 0x2C07558 VA: 0x2C0B558
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C0C3DC Offset: 0x2C083DC VA: 0x2C0C3DC
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C0D1C0 Offset: 0x2C091C0 VA: 0x2C0D1C0
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C0DFA4 Offset: 0x2C09FA4 VA: 0x2C0DFA4
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C0ED88 Offset: 0x2C0AD88 VA: 0x2C0ED88
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C0FB6C Offset: 0x2C0BB6C VA: 0x2C0FB6C
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C10998 Offset: 0x2C0C998 VA: 0x2C10998
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C117E0 Offset: 0x2C0D7E0 VA: 0x2C117E0
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C125BC Offset: 0x2C0E5BC VA: 0x2C125BC
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C13398 Offset: 0x2C0F398 VA: 0x2C13398
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C1417C Offset: 0x2C1017C VA: 0x2C1417C
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C14F50 Offset: 0x2C10F50 VA: 0x2C14F50
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C15DB4 Offset: 0x2C11DB4 VA: 0x2C15DB4
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C16C28 Offset: 0x2C12C28 VA: 0x2C16C28
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C179FC Offset: 0x2C139FC VA: 0x2C179FC
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C187D8 Offset: 0x2C147D8 VA: 0x2C187D8
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C195AC Offset: 0x2C155AC VA: 0x2C195AC
	|-ReadOnlyCollection<ByteEnum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C1A4F8 Offset: 0x2C164F8 VA: 0x2C1A4F8
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C1B30C Offset: 0x2C1730C VA: 0x2C1B30C
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C1C0F8 Offset: 0x2C180F8 VA: 0x2C1C0F8
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C1CF64 Offset: 0x2C18F64 VA: 0x2C1CF64
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C1DDE4 Offset: 0x2C19DE4 VA: 0x2C1DDE4
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C1EBB8 Offset: 0x2C1ABB8 VA: 0x2C1EBB8
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C1F99C Offset: 0x2C1B99C VA: 0x2C1F99C
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C20780 Offset: 0x2C1C780 VA: 0x2C20780
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C21594 Offset: 0x2C1D594 VA: 0x2C21594
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C22368 Offset: 0x2C1E368 VA: 0x2C22368
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C2314C Offset: 0x2C1F14C VA: 0x2C2314C
	|-ReadOnlyCollection<EventSummary>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C23F20 Offset: 0x2C1FF20 VA: 0x2C23F20
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C24CF4 Offset: 0x2C20CF4 VA: 0x2C24CF4
	|-ReadOnlyCollection<Int16Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C25AC8 Offset: 0x2C21AC8 VA: 0x2C25AC8
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C2689C Offset: 0x2C2289C VA: 0x2C2689C
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C27670 Offset: 0x2C23670 VA: 0x2C27670
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C28454 Offset: 0x2C24454 VA: 0x2C28454
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C292B8 Offset: 0x2C252B8 VA: 0x2C292B8
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C2A13C Offset: 0x2C2613C VA: 0x2C2A13C
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C2AFA0 Offset: 0x2C26FA0 VA: 0x2C2AFA0
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C2BEA4 Offset: 0x2C27EA4 VA: 0x2C2BEA4
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C2CD18 Offset: 0x2C28D18 VA: 0x2C2CD18
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C2DB58 Offset: 0x2C29B58 VA: 0x2C2DB58
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C2EA64 Offset: 0x2C2AA64 VA: 0x2C2EA64
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C2F8EC Offset: 0x2C2B8EC VA: 0x2C2F8EC
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C306D8 Offset: 0x2C2C6D8 VA: 0x2C306D8
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C314C4 Offset: 0x2C2D4C4 VA: 0x2C314C4
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C32298 Offset: 0x2C2E298 VA: 0x2C32298
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C3306C Offset: 0x2C2F06C VA: 0x2C3306C
	|-ReadOnlyCollection<SkillIdData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C33E40 Offset: 0x2C2FE40 VA: 0x2C33E40
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C34C14 Offset: 0x2C30C14 VA: 0x2C34C14
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C359E8 Offset: 0x2C319E8 VA: 0x2C359E8
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C367BC Offset: 0x2C327BC VA: 0x2C367BC
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C375A0 Offset: 0x2C335A0 VA: 0x2C375A0
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C383A4 Offset: 0x2C343A4 VA: 0x2C383A4
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C39198 Offset: 0x2C35198 VA: 0x2C39198
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C3A140 Offset: 0x2C36140 VA: 0x2C3A140
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C3B23C Offset: 0x2C3723C VA: 0x2C3B23C
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C3C0A0 Offset: 0x2C380A0 VA: 0x2C3C0A0
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C3CFA8 Offset: 0x2C38FA8 VA: 0x2C3CFA8
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C3DE20 Offset: 0x2C39E20 VA: 0x2C3DE20
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C3EC0C Offset: 0x2C3AC0C VA: 0x2C3EC0C
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C3FA10 Offset: 0x2C3BA10 VA: 0x2C3FA10
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C4080C Offset: 0x2C3C80C VA: 0x2C4080C
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C41638 Offset: 0x2C3D638 VA: 0x2C41638
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C4247C Offset: 0x2C3E47C VA: 0x2C4247C
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C43258 Offset: 0x2C3F258 VA: 0x2C43258
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C44044 Offset: 0x2C40044 VA: 0x2C44044
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C44E18 Offset: 0x2C40E18 VA: 0x2C44E18
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C45C7C Offset: 0x2C41C7C VA: 0x2C45C7C
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C46B44 Offset: 0x2C42B44 VA: 0x2C46B44
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C47978 Offset: 0x2C43978 VA: 0x2C47978
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C487A4 Offset: 0x2C447A4 VA: 0x2C487A4
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C495D8 Offset: 0x2C455D8 VA: 0x2C495D8
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C4A3BC Offset: 0x2C463BC VA: 0x2C4A3BC
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C4B220 Offset: 0x2C47220 VA: 0x2C4B220
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C4C0A4 Offset: 0x2C480A4 VA: 0x2C4C0A4
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C4CED0 Offset: 0x2C48ED0 VA: 0x2C4CED0
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C4DD5C Offset: 0x2C49D5C VA: 0x2C4DD5C
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C045F0 Offset: 0x2C005F0 VA: 0x2C045F0
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C053CC Offset: 0x2C013CC VA: 0x2C053CC
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C061B0 Offset: 0x2C021B0 VA: 0x2C061B0
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C06F9C Offset: 0x2C02F9C VA: 0x2C06F9C
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C07D70 Offset: 0x2C03D70 VA: 0x2C07D70
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C08B44 Offset: 0x2C04B44 VA: 0x2C08B44
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C09928 Offset: 0x2C05928 VA: 0x2C09928
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C0A6FC Offset: 0x2C066FC VA: 0x2C0A6FC
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C0B560 Offset: 0x2C07560 VA: 0x2C0B560
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C0C3E4 Offset: 0x2C083E4 VA: 0x2C0C3E4
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C0D1C8 Offset: 0x2C091C8 VA: 0x2C0D1C8
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C0DFAC Offset: 0x2C09FAC VA: 0x2C0DFAC
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C0ED90 Offset: 0x2C0AD90 VA: 0x2C0ED90
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C0FB74 Offset: 0x2C0BB74 VA: 0x2C0FB74
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C109A0 Offset: 0x2C0C9A0 VA: 0x2C109A0
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C117E8 Offset: 0x2C0D7E8 VA: 0x2C117E8
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C125C4 Offset: 0x2C0E5C4 VA: 0x2C125C4
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C133A0 Offset: 0x2C0F3A0 VA: 0x2C133A0
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C14184 Offset: 0x2C10184 VA: 0x2C14184
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C14F58 Offset: 0x2C10F58 VA: 0x2C14F58
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C15DBC Offset: 0x2C11DBC VA: 0x2C15DBC
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C16C30 Offset: 0x2C12C30 VA: 0x2C16C30
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C17A04 Offset: 0x2C13A04 VA: 0x2C17A04
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C187E0 Offset: 0x2C147E0 VA: 0x2C187E0
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C195B4 Offset: 0x2C155B4 VA: 0x2C195B4
	|-ReadOnlyCollection<ByteEnum>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C1A500 Offset: 0x2C16500 VA: 0x2C1A500
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C1B314 Offset: 0x2C17314 VA: 0x2C1B314
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C1C100 Offset: 0x2C18100 VA: 0x2C1C100
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C1CF6C Offset: 0x2C18F6C VA: 0x2C1CF6C
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C1DDEC Offset: 0x2C19DEC VA: 0x2C1DDEC
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C1EBC0 Offset: 0x2C1ABC0 VA: 0x2C1EBC0
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C1F9A4 Offset: 0x2C1B9A4 VA: 0x2C1F9A4
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C20788 Offset: 0x2C1C788 VA: 0x2C20788
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C2159C Offset: 0x2C1D59C VA: 0x2C2159C
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C22370 Offset: 0x2C1E370 VA: 0x2C22370
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C23154 Offset: 0x2C1F154 VA: 0x2C23154
	|-ReadOnlyCollection<EventSummary>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C23F28 Offset: 0x2C1FF28 VA: 0x2C23F28
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C24CFC Offset: 0x2C20CFC VA: 0x2C24CFC
	|-ReadOnlyCollection<Int16Enum>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C25AD0 Offset: 0x2C21AD0 VA: 0x2C25AD0
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C268A4 Offset: 0x2C228A4 VA: 0x2C268A4
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C27678 Offset: 0x2C23678 VA: 0x2C27678
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C2845C Offset: 0x2C2445C VA: 0x2C2845C
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C292C0 Offset: 0x2C252C0 VA: 0x2C292C0
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C2A144 Offset: 0x2C26144 VA: 0x2C2A144
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C2AFA8 Offset: 0x2C26FA8 VA: 0x2C2AFA8
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C2BEAC Offset: 0x2C27EAC VA: 0x2C2BEAC
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C2CD20 Offset: 0x2C28D20 VA: 0x2C2CD20
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C2DB60 Offset: 0x2C29B60 VA: 0x2C2DB60
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C2EA6C Offset: 0x2C2AA6C VA: 0x2C2EA6C
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C2F8F4 Offset: 0x2C2B8F4 VA: 0x2C2F8F4
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C306E0 Offset: 0x2C2C6E0 VA: 0x2C306E0
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C314CC Offset: 0x2C2D4CC VA: 0x2C314CC
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C322A0 Offset: 0x2C2E2A0 VA: 0x2C322A0
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C33074 Offset: 0x2C2F074 VA: 0x2C33074
	|-ReadOnlyCollection<SkillIdData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C33E48 Offset: 0x2C2FE48 VA: 0x2C33E48
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C34C1C Offset: 0x2C30C1C VA: 0x2C34C1C
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C359F0 Offset: 0x2C319F0 VA: 0x2C359F0
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C367C4 Offset: 0x2C327C4 VA: 0x2C367C4
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C375A8 Offset: 0x2C335A8 VA: 0x2C375A8
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C383AC Offset: 0x2C343AC VA: 0x2C383AC
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C391A0 Offset: 0x2C351A0 VA: 0x2C391A0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C3A148 Offset: 0x2C36148 VA: 0x2C3A148
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C3B244 Offset: 0x2C37244 VA: 0x2C3B244
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C3C0A8 Offset: 0x2C380A8 VA: 0x2C3C0A8
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C3CFB0 Offset: 0x2C38FB0 VA: 0x2C3CFB0
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C3DE28 Offset: 0x2C39E28 VA: 0x2C3DE28
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C3EC14 Offset: 0x2C3AC14 VA: 0x2C3EC14
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C3FA18 Offset: 0x2C3BA18 VA: 0x2C3FA18
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C40814 Offset: 0x2C3C814 VA: 0x2C40814
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C41640 Offset: 0x2C3D640 VA: 0x2C41640
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C42484 Offset: 0x2C3E484 VA: 0x2C42484
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C43260 Offset: 0x2C3F260 VA: 0x2C43260
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C4404C Offset: 0x2C4004C VA: 0x2C4404C
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C44E20 Offset: 0x2C40E20 VA: 0x2C44E20
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C45C84 Offset: 0x2C41C84 VA: 0x2C45C84
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C46B4C Offset: 0x2C42B4C VA: 0x2C46B4C
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C47980 Offset: 0x2C43980 VA: 0x2C47980
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C487AC Offset: 0x2C447AC VA: 0x2C487AC
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C495E0 Offset: 0x2C455E0 VA: 0x2C495E0
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C4A3C4 Offset: 0x2C463C4 VA: 0x2C4A3C4
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C4B228 Offset: 0x2C47228 VA: 0x2C4B228
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C4C0AC Offset: 0x2C480AC VA: 0x2C4C0AC
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C4CED8 Offset: 0x2C48ED8 VA: 0x2C4CED8
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x2C4DD64 Offset: 0x2C49D64 VA: 0x2C4DD64
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.IList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04688 Offset: 0x2C00688 VA: 0x2C04688
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C0546C Offset: 0x2C0146C VA: 0x2C0546C
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C06250 Offset: 0x2C02250 VA: 0x2C06250
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C07034 Offset: 0x2C03034 VA: 0x2C07034
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C07E08 Offset: 0x2C03E08 VA: 0x2C07E08
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C08BDC Offset: 0x2C04BDC VA: 0x2C08BDC
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C099C0 Offset: 0x2C059C0 VA: 0x2C099C0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C0A794 Offset: 0x2C06794 VA: 0x2C0A794
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C0B61C Offset: 0x2C0761C VA: 0x2C0B61C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C0C47C Offset: 0x2C0847C VA: 0x2C0C47C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C0D260 Offset: 0x2C09260 VA: 0x2C0D260
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C0E044 Offset: 0x2C0A044 VA: 0x2C0E044
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C0EE28 Offset: 0x2C0AE28 VA: 0x2C0EE28
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C0FC0C Offset: 0x2C0BC0C VA: 0x2C0FC0C
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C10A54 Offset: 0x2C0CA54 VA: 0x2C10A54
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C11880 Offset: 0x2C0D880 VA: 0x2C11880
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C12664 Offset: 0x2C0E664 VA: 0x2C12664
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C13438 Offset: 0x2C0F438 VA: 0x2C13438
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C1421C Offset: 0x2C1021C VA: 0x2C1421C
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C14FF0 Offset: 0x2C10FF0 VA: 0x2C14FF0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C15E78 Offset: 0x2C11E78 VA: 0x2C15E78
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C16CC8 Offset: 0x2C12CC8 VA: 0x2C16CC8
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C17A9C Offset: 0x2C13A9C VA: 0x2C17A9C
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C18878 Offset: 0x2C14878 VA: 0x2C18878
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C1964C Offset: 0x2C1564C VA: 0x2C1964C
	|-ReadOnlyCollection<ByteEnum>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C1A598 Offset: 0x2C16598 VA: 0x2C1A598
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C1B3AC Offset: 0x2C173AC VA: 0x2C1B3AC
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C1C1A0 Offset: 0x2C181A0 VA: 0x2C1C1A0
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C1D028 Offset: 0x2C19028 VA: 0x2C1D028
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C1DE84 Offset: 0x2C19E84 VA: 0x2C1DE84
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C1EC58 Offset: 0x2C1AC58 VA: 0x2C1EC58
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C1FA3C Offset: 0x2C1BA3C VA: 0x2C1FA3C
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C20820 Offset: 0x2C1C820 VA: 0x2C20820
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C21634 Offset: 0x2C1D634 VA: 0x2C21634
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C22408 Offset: 0x2C1E408 VA: 0x2C22408
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C231EC Offset: 0x2C1F1EC VA: 0x2C231EC
	|-ReadOnlyCollection<EventSummary>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C23FC0 Offset: 0x2C1FFC0 VA: 0x2C23FC0
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C24D94 Offset: 0x2C20D94 VA: 0x2C24D94
	|-ReadOnlyCollection<Int16Enum>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C25B68 Offset: 0x2C21B68 VA: 0x2C25B68
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C2693C Offset: 0x2C2293C VA: 0x2C2693C
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C27710 Offset: 0x2C23710 VA: 0x2C27710
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C284F4 Offset: 0x2C244F4 VA: 0x2C284F4
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C2937C Offset: 0x2C2537C VA: 0x2C2937C
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C2A1DC Offset: 0x2C261DC VA: 0x2C2A1DC
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C2B064 Offset: 0x2C27064 VA: 0x2C2B064
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C2BF68 Offset: 0x2C27F68 VA: 0x2C2BF68
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C2CDB8 Offset: 0x2C28DB8 VA: 0x2C2CDB8
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C2DC20 Offset: 0x2C29C20 VA: 0x2C2DC20
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C2EB2C Offset: 0x2C2AB2C VA: 0x2C2EB2C
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C2F98C Offset: 0x2C2B98C VA: 0x2C2F98C
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C30780 Offset: 0x2C2C780 VA: 0x2C30780
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C31564 Offset: 0x2C2D564 VA: 0x2C31564
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C32338 Offset: 0x2C2E338 VA: 0x2C32338
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C3310C Offset: 0x2C2F10C VA: 0x2C3310C
	|-ReadOnlyCollection<SkillIdData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C33EE0 Offset: 0x2C2FEE0 VA: 0x2C33EE0
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C34CB4 Offset: 0x2C30CB4 VA: 0x2C34CB4
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C35A88 Offset: 0x2C31A88 VA: 0x2C35A88
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C3685C Offset: 0x2C3285C VA: 0x2C3685C
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C37640 Offset: 0x2C33640 VA: 0x2C37640
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C38444 Offset: 0x2C34444 VA: 0x2C38444
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C39238 Offset: 0x2C35238 VA: 0x2C39238
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C3A264 Offset: 0x2C36264 VA: 0x2C3A264
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C3B2DC Offset: 0x2C372DC VA: 0x2C3B2DC
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C3C164 Offset: 0x2C38164 VA: 0x2C3C164
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C3D070 Offset: 0x2C39070 VA: 0x2C3D070
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C3DEC0 Offset: 0x2C39EC0 VA: 0x2C3DEC0
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C3ECB4 Offset: 0x2C3ACB4 VA: 0x2C3ECB4
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C3FAB8 Offset: 0x2C3BAB8 VA: 0x2C3FAB8
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C408AC Offset: 0x2C3C8AC VA: 0x2C408AC
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C416F4 Offset: 0x2C3D6F4 VA: 0x2C416F4
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C4251C Offset: 0x2C3E51C VA: 0x2C4251C
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C43300 Offset: 0x2C3F300 VA: 0x2C43300
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C440E4 Offset: 0x2C400E4 VA: 0x2C440E4
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C44EB8 Offset: 0x2C40EB8 VA: 0x2C44EB8
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C45D40 Offset: 0x2C41D40 VA: 0x2C45D40
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C46C00 Offset: 0x2C42C00 VA: 0x2C46C00
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C47A18 Offset: 0x2C43A18 VA: 0x2C47A18
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C48860 Offset: 0x2C44860 VA: 0x2C48860
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C49678 Offset: 0x2C45678 VA: 0x2C49678
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C4A45C Offset: 0x2C4645C VA: 0x2C4A45C
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C4B2E4 Offset: 0x2C472E4 VA: 0x2C4B2E4
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C4C144 Offset: 0x2C48144 VA: 0x2C4C144
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C4CF8C Offset: 0x2C48F8C VA: 0x2C4CF8C
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x2C4DE18 Offset: 0x2C49E18 VA: 0x2C4DE18
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.IList<T>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<T>.Add(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04694 Offset: 0x2C00694 VA: 0x2C04694
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C05478 Offset: 0x2C01478 VA: 0x2C05478
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C0625C Offset: 0x2C0225C VA: 0x2C0625C
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C07040 Offset: 0x2C03040 VA: 0x2C07040
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C07E14 Offset: 0x2C03E14 VA: 0x2C07E14
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C08BE8 Offset: 0x2C04BE8 VA: 0x2C08BE8
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C099CC Offset: 0x2C059CC VA: 0x2C099CC
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C0A7A0 Offset: 0x2C067A0 VA: 0x2C0A7A0
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C0B628 Offset: 0x2C07628 VA: 0x2C0B628
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C0C488 Offset: 0x2C08488 VA: 0x2C0C488
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C0D26C Offset: 0x2C0926C VA: 0x2C0D26C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C0E050 Offset: 0x2C0A050 VA: 0x2C0E050
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C0EE34 Offset: 0x2C0AE34 VA: 0x2C0EE34
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C0FC18 Offset: 0x2C0BC18 VA: 0x2C0FC18
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C10A60 Offset: 0x2C0CA60 VA: 0x2C10A60
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C1188C Offset: 0x2C0D88C VA: 0x2C1188C
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C12670 Offset: 0x2C0E670 VA: 0x2C12670
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C13444 Offset: 0x2C0F444 VA: 0x2C13444
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C14228 Offset: 0x2C10228 VA: 0x2C14228
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C14FFC Offset: 0x2C10FFC VA: 0x2C14FFC
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C15E84 Offset: 0x2C11E84 VA: 0x2C15E84
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C16CD4 Offset: 0x2C12CD4 VA: 0x2C16CD4
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C17AA8 Offset: 0x2C13AA8 VA: 0x2C17AA8
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C18884 Offset: 0x2C14884 VA: 0x2C18884
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C19658 Offset: 0x2C15658 VA: 0x2C19658
	|-ReadOnlyCollection<ByteEnum>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C1A5A4 Offset: 0x2C165A4 VA: 0x2C1A5A4
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C1B3B8 Offset: 0x2C173B8 VA: 0x2C1B3B8
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C1C1AC Offset: 0x2C181AC VA: 0x2C1C1AC
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C1D034 Offset: 0x2C19034 VA: 0x2C1D034
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C1DE90 Offset: 0x2C19E90 VA: 0x2C1DE90
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C1EC64 Offset: 0x2C1AC64 VA: 0x2C1EC64
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C1FA48 Offset: 0x2C1BA48 VA: 0x2C1FA48
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C2082C Offset: 0x2C1C82C VA: 0x2C2082C
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C21640 Offset: 0x2C1D640 VA: 0x2C21640
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C22414 Offset: 0x2C1E414 VA: 0x2C22414
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C231F8 Offset: 0x2C1F1F8 VA: 0x2C231F8
	|-ReadOnlyCollection<EventSummary>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C23FCC Offset: 0x2C1FFCC VA: 0x2C23FCC
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C24DA0 Offset: 0x2C20DA0 VA: 0x2C24DA0
	|-ReadOnlyCollection<Int16Enum>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C25B74 Offset: 0x2C21B74 VA: 0x2C25B74
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C26948 Offset: 0x2C22948 VA: 0x2C26948
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C2771C Offset: 0x2C2371C VA: 0x2C2771C
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C28500 Offset: 0x2C24500 VA: 0x2C28500
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C29388 Offset: 0x2C25388 VA: 0x2C29388
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C2A1E8 Offset: 0x2C261E8 VA: 0x2C2A1E8
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C2B070 Offset: 0x2C27070 VA: 0x2C2B070
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C2BF74 Offset: 0x2C27F74 VA: 0x2C2BF74
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C2CDC4 Offset: 0x2C28DC4 VA: 0x2C2CDC4
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C2DC2C Offset: 0x2C29C2C VA: 0x2C2DC2C
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C2EB38 Offset: 0x2C2AB38 VA: 0x2C2EB38
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C2F998 Offset: 0x2C2B998 VA: 0x2C2F998
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C3078C Offset: 0x2C2C78C VA: 0x2C3078C
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C31570 Offset: 0x2C2D570 VA: 0x2C31570
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C32344 Offset: 0x2C2E344 VA: 0x2C32344
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C33118 Offset: 0x2C2F118 VA: 0x2C33118
	|-ReadOnlyCollection<SkillIdData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C33EEC Offset: 0x2C2FEEC VA: 0x2C33EEC
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C34CC0 Offset: 0x2C30CC0 VA: 0x2C34CC0
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C35A94 Offset: 0x2C31A94 VA: 0x2C35A94
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C36868 Offset: 0x2C32868 VA: 0x2C36868
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C3764C Offset: 0x2C3364C VA: 0x2C3764C
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C38450 Offset: 0x2C34450 VA: 0x2C38450
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C39244 Offset: 0x2C35244 VA: 0x2C39244
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C3A270 Offset: 0x2C36270 VA: 0x2C3A270
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C3B2E8 Offset: 0x2C372E8 VA: 0x2C3B2E8
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C3C170 Offset: 0x2C38170 VA: 0x2C3C170
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C3D07C Offset: 0x2C3907C VA: 0x2C3D07C
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C3DECC Offset: 0x2C39ECC VA: 0x2C3DECC
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C3ECC0 Offset: 0x2C3ACC0 VA: 0x2C3ECC0
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C3FAC4 Offset: 0x2C3BAC4 VA: 0x2C3FAC4
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C408B8 Offset: 0x2C3C8B8 VA: 0x2C408B8
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C41700 Offset: 0x2C3D700 VA: 0x2C41700
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C42528 Offset: 0x2C3E528 VA: 0x2C42528
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C4330C Offset: 0x2C3F30C VA: 0x2C4330C
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C440F0 Offset: 0x2C400F0 VA: 0x2C440F0
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C44EC4 Offset: 0x2C40EC4 VA: 0x2C44EC4
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C45D4C Offset: 0x2C41D4C VA: 0x2C45D4C
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C46C0C Offset: 0x2C42C0C VA: 0x2C46C0C
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C47A24 Offset: 0x2C43A24 VA: 0x2C47A24
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C4886C Offset: 0x2C4486C VA: 0x2C4886C
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C49684 Offset: 0x2C45684 VA: 0x2C49684
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C4A468 Offset: 0x2C46468 VA: 0x2C4A468
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C4B2F0 Offset: 0x2C472F0 VA: 0x2C4B2F0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C4C150 Offset: 0x2C48150 VA: 0x2C4C150
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C4CF98 Offset: 0x2C48F98 VA: 0x2C4CF98
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C4DE24 Offset: 0x2C49E24 VA: 0x2C4DE24
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C046A0 Offset: 0x2C006A0 VA: 0x2C046A0
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C05484 Offset: 0x2C01484 VA: 0x2C05484
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C06268 Offset: 0x2C02268 VA: 0x2C06268
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C0704C Offset: 0x2C0304C VA: 0x2C0704C
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C07E20 Offset: 0x2C03E20 VA: 0x2C07E20
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C08BF4 Offset: 0x2C04BF4 VA: 0x2C08BF4
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C099D8 Offset: 0x2C059D8 VA: 0x2C099D8
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C0A7AC Offset: 0x2C067AC VA: 0x2C0A7AC
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C0B634 Offset: 0x2C07634 VA: 0x2C0B634
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C0C494 Offset: 0x2C08494 VA: 0x2C0C494
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C0D278 Offset: 0x2C09278 VA: 0x2C0D278
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C0E05C Offset: 0x2C0A05C VA: 0x2C0E05C
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C0EE40 Offset: 0x2C0AE40 VA: 0x2C0EE40
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C0FC24 Offset: 0x2C0BC24 VA: 0x2C0FC24
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C10A6C Offset: 0x2C0CA6C VA: 0x2C10A6C
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C11898 Offset: 0x2C0D898 VA: 0x2C11898
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C1267C Offset: 0x2C0E67C VA: 0x2C1267C
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C13450 Offset: 0x2C0F450 VA: 0x2C13450
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C14234 Offset: 0x2C10234 VA: 0x2C14234
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C15008 Offset: 0x2C11008 VA: 0x2C15008
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C15E90 Offset: 0x2C11E90 VA: 0x2C15E90
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C16CE0 Offset: 0x2C12CE0 VA: 0x2C16CE0
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C17AB4 Offset: 0x2C13AB4 VA: 0x2C17AB4
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C18890 Offset: 0x2C14890 VA: 0x2C18890
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C19664 Offset: 0x2C15664 VA: 0x2C19664
	|-ReadOnlyCollection<ByteEnum>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C1A5B0 Offset: 0x2C165B0 VA: 0x2C1A5B0
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C1B3C4 Offset: 0x2C173C4 VA: 0x2C1B3C4
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C1C1B8 Offset: 0x2C181B8 VA: 0x2C1C1B8
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C1D040 Offset: 0x2C19040 VA: 0x2C1D040
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C1DE9C Offset: 0x2C19E9C VA: 0x2C1DE9C
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C1EC70 Offset: 0x2C1AC70 VA: 0x2C1EC70
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C1FA54 Offset: 0x2C1BA54 VA: 0x2C1FA54
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C20838 Offset: 0x2C1C838 VA: 0x2C20838
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C2164C Offset: 0x2C1D64C VA: 0x2C2164C
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C22420 Offset: 0x2C1E420 VA: 0x2C22420
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C23204 Offset: 0x2C1F204 VA: 0x2C23204
	|-ReadOnlyCollection<EventSummary>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C23FD8 Offset: 0x2C1FFD8 VA: 0x2C23FD8
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C24DAC Offset: 0x2C20DAC VA: 0x2C24DAC
	|-ReadOnlyCollection<Int16Enum>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C25B80 Offset: 0x2C21B80 VA: 0x2C25B80
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C26954 Offset: 0x2C22954 VA: 0x2C26954
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C27728 Offset: 0x2C23728 VA: 0x2C27728
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C2850C Offset: 0x2C2450C VA: 0x2C2850C
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C29394 Offset: 0x2C25394 VA: 0x2C29394
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C2A1F4 Offset: 0x2C261F4 VA: 0x2C2A1F4
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C2B07C Offset: 0x2C2707C VA: 0x2C2B07C
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C2BF80 Offset: 0x2C27F80 VA: 0x2C2BF80
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C2CDD0 Offset: 0x2C28DD0 VA: 0x2C2CDD0
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C2DC38 Offset: 0x2C29C38 VA: 0x2C2DC38
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C2EB44 Offset: 0x2C2AB44 VA: 0x2C2EB44
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C2F9A4 Offset: 0x2C2B9A4 VA: 0x2C2F9A4
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C30798 Offset: 0x2C2C798 VA: 0x2C30798
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C3157C Offset: 0x2C2D57C VA: 0x2C3157C
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C32350 Offset: 0x2C2E350 VA: 0x2C32350
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C33124 Offset: 0x2C2F124 VA: 0x2C33124
	|-ReadOnlyCollection<SkillIdData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C33EF8 Offset: 0x2C2FEF8 VA: 0x2C33EF8
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C34CCC Offset: 0x2C30CCC VA: 0x2C34CCC
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C35AA0 Offset: 0x2C31AA0 VA: 0x2C35AA0
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C36874 Offset: 0x2C32874 VA: 0x2C36874
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C37658 Offset: 0x2C33658 VA: 0x2C37658
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C3845C Offset: 0x2C3445C VA: 0x2C3845C
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C39250 Offset: 0x2C35250 VA: 0x2C39250
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C3A27C Offset: 0x2C3627C VA: 0x2C3A27C
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C3B2F4 Offset: 0x2C372F4 VA: 0x2C3B2F4
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C3C17C Offset: 0x2C3817C VA: 0x2C3C17C
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C3D088 Offset: 0x2C39088 VA: 0x2C3D088
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C3DED8 Offset: 0x2C39ED8 VA: 0x2C3DED8
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C3ECCC Offset: 0x2C3ACCC VA: 0x2C3ECCC
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C3FAD0 Offset: 0x2C3BAD0 VA: 0x2C3FAD0
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C408C4 Offset: 0x2C3C8C4 VA: 0x2C408C4
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C4170C Offset: 0x2C3D70C VA: 0x2C4170C
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C42534 Offset: 0x2C3E534 VA: 0x2C42534
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C43318 Offset: 0x2C3F318 VA: 0x2C43318
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C440FC Offset: 0x2C400FC VA: 0x2C440FC
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C44ED0 Offset: 0x2C40ED0 VA: 0x2C44ED0
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C45D58 Offset: 0x2C41D58 VA: 0x2C45D58
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C46C18 Offset: 0x2C42C18 VA: 0x2C46C18
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C47A30 Offset: 0x2C43A30 VA: 0x2C47A30
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C48878 Offset: 0x2C44878 VA: 0x2C48878
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C49690 Offset: 0x2C45690 VA: 0x2C49690
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C4A474 Offset: 0x2C46474 VA: 0x2C4A474
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C4B2FC Offset: 0x2C472FC VA: 0x2C4B2FC
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C4C15C Offset: 0x2C4815C VA: 0x2C4C15C
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C4CFA4 Offset: 0x2C48FA4 VA: 0x2C4CFA4
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x2C4DE30 Offset: 0x2C49E30 VA: 0x2C4DE30
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.IList<T>.Insert(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C046AC Offset: 0x2C006AC VA: 0x2C046AC
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C05490 Offset: 0x2C01490 VA: 0x2C05490
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C06274 Offset: 0x2C02274 VA: 0x2C06274
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C07058 Offset: 0x2C03058 VA: 0x2C07058
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C07E2C Offset: 0x2C03E2C VA: 0x2C07E2C
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C08C00 Offset: 0x2C04C00 VA: 0x2C08C00
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C099E4 Offset: 0x2C059E4 VA: 0x2C099E4
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C0A7B8 Offset: 0x2C067B8 VA: 0x2C0A7B8
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C0B640 Offset: 0x2C07640 VA: 0x2C0B640
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C0C4A0 Offset: 0x2C084A0 VA: 0x2C0C4A0
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C0D284 Offset: 0x2C09284 VA: 0x2C0D284
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C0E068 Offset: 0x2C0A068 VA: 0x2C0E068
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C0EE4C Offset: 0x2C0AE4C VA: 0x2C0EE4C
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C0FC30 Offset: 0x2C0BC30 VA: 0x2C0FC30
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C10A78 Offset: 0x2C0CA78 VA: 0x2C10A78
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C118A4 Offset: 0x2C0D8A4 VA: 0x2C118A4
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C12688 Offset: 0x2C0E688 VA: 0x2C12688
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C1345C Offset: 0x2C0F45C VA: 0x2C1345C
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C14240 Offset: 0x2C10240 VA: 0x2C14240
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C15014 Offset: 0x2C11014 VA: 0x2C15014
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C15E9C Offset: 0x2C11E9C VA: 0x2C15E9C
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C16CEC Offset: 0x2C12CEC VA: 0x2C16CEC
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C17AC0 Offset: 0x2C13AC0 VA: 0x2C17AC0
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C1889C Offset: 0x2C1489C VA: 0x2C1889C
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C19670 Offset: 0x2C15670 VA: 0x2C19670
	|-ReadOnlyCollection<ByteEnum>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C1A5BC Offset: 0x2C165BC VA: 0x2C1A5BC
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C1B3D0 Offset: 0x2C173D0 VA: 0x2C1B3D0
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C1C1C4 Offset: 0x2C181C4 VA: 0x2C1C1C4
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C1D04C Offset: 0x2C1904C VA: 0x2C1D04C
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C1DEA8 Offset: 0x2C19EA8 VA: 0x2C1DEA8
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C1EC7C Offset: 0x2C1AC7C VA: 0x2C1EC7C
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C1FA60 Offset: 0x2C1BA60 VA: 0x2C1FA60
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C20844 Offset: 0x2C1C844 VA: 0x2C20844
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C21658 Offset: 0x2C1D658 VA: 0x2C21658
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C2242C Offset: 0x2C1E42C VA: 0x2C2242C
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C23210 Offset: 0x2C1F210 VA: 0x2C23210
	|-ReadOnlyCollection<EventSummary>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C23FE4 Offset: 0x2C1FFE4 VA: 0x2C23FE4
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C24DB8 Offset: 0x2C20DB8 VA: 0x2C24DB8
	|-ReadOnlyCollection<Int16Enum>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C25B8C Offset: 0x2C21B8C VA: 0x2C25B8C
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C26960 Offset: 0x2C22960 VA: 0x2C26960
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C27734 Offset: 0x2C23734 VA: 0x2C27734
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C28518 Offset: 0x2C24518 VA: 0x2C28518
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C293A0 Offset: 0x2C253A0 VA: 0x2C293A0
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C2A200 Offset: 0x2C26200 VA: 0x2C2A200
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C2B088 Offset: 0x2C27088 VA: 0x2C2B088
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C2BF8C Offset: 0x2C27F8C VA: 0x2C2BF8C
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C2CDDC Offset: 0x2C28DDC VA: 0x2C2CDDC
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C2DC44 Offset: 0x2C29C44 VA: 0x2C2DC44
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C2EB50 Offset: 0x2C2AB50 VA: 0x2C2EB50
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C2F9B0 Offset: 0x2C2B9B0 VA: 0x2C2F9B0
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C307A4 Offset: 0x2C2C7A4 VA: 0x2C307A4
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C31588 Offset: 0x2C2D588 VA: 0x2C31588
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C3235C Offset: 0x2C2E35C VA: 0x2C3235C
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C33130 Offset: 0x2C2F130 VA: 0x2C33130
	|-ReadOnlyCollection<SkillIdData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C33F04 Offset: 0x2C2FF04 VA: 0x2C33F04
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C34CD8 Offset: 0x2C30CD8 VA: 0x2C34CD8
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C35AAC Offset: 0x2C31AAC VA: 0x2C35AAC
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C36880 Offset: 0x2C32880 VA: 0x2C36880
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C37664 Offset: 0x2C33664 VA: 0x2C37664
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C38468 Offset: 0x2C34468 VA: 0x2C38468
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C3925C Offset: 0x2C3525C VA: 0x2C3925C
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C3A288 Offset: 0x2C36288 VA: 0x2C3A288
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C3B300 Offset: 0x2C37300 VA: 0x2C3B300
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C3C188 Offset: 0x2C38188 VA: 0x2C3C188
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C3D094 Offset: 0x2C39094 VA: 0x2C3D094
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C3DEE4 Offset: 0x2C39EE4 VA: 0x2C3DEE4
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C3ECD8 Offset: 0x2C3ACD8 VA: 0x2C3ECD8
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C3FADC Offset: 0x2C3BADC VA: 0x2C3FADC
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C408D0 Offset: 0x2C3C8D0 VA: 0x2C408D0
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C41718 Offset: 0x2C3D718 VA: 0x2C41718
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C42540 Offset: 0x2C3E540 VA: 0x2C42540
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C43324 Offset: 0x2C3F324 VA: 0x2C43324
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C44108 Offset: 0x2C40108 VA: 0x2C44108
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C44EDC Offset: 0x2C40EDC VA: 0x2C44EDC
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C45D64 Offset: 0x2C41D64 VA: 0x2C45D64
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C46C24 Offset: 0x2C42C24 VA: 0x2C46C24
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C47A3C Offset: 0x2C43A3C VA: 0x2C47A3C
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C48884 Offset: 0x2C44884 VA: 0x2C48884
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C4969C Offset: 0x2C4569C VA: 0x2C4969C
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C4A480 Offset: 0x2C46480 VA: 0x2C4A480
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C4B308 Offset: 0x2C47308 VA: 0x2C4B308
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C4C168 Offset: 0x2C48168 VA: 0x2C4C168
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C4CFB0 Offset: 0x2C48FB0 VA: 0x2C4CFB0
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x2C4DE3C Offset: 0x2C49E3C VA: 0x2C4DE3C
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.IList<T>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<T>.Remove(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C046B8 Offset: 0x2C006B8 VA: 0x2C046B8
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C0549C Offset: 0x2C0149C VA: 0x2C0549C
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C06280 Offset: 0x2C02280 VA: 0x2C06280
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C07064 Offset: 0x2C03064 VA: 0x2C07064
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C07E38 Offset: 0x2C03E38 VA: 0x2C07E38
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C08C0C Offset: 0x2C04C0C VA: 0x2C08C0C
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C099F0 Offset: 0x2C059F0 VA: 0x2C099F0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C0A7C4 Offset: 0x2C067C4 VA: 0x2C0A7C4
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C0B64C Offset: 0x2C0764C VA: 0x2C0B64C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C0C4AC Offset: 0x2C084AC VA: 0x2C0C4AC
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C0D290 Offset: 0x2C09290 VA: 0x2C0D290
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C0E074 Offset: 0x2C0A074 VA: 0x2C0E074
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C0EE58 Offset: 0x2C0AE58 VA: 0x2C0EE58
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C0FC3C Offset: 0x2C0BC3C VA: 0x2C0FC3C
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C10A84 Offset: 0x2C0CA84 VA: 0x2C10A84
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C118B0 Offset: 0x2C0D8B0 VA: 0x2C118B0
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C12694 Offset: 0x2C0E694 VA: 0x2C12694
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C13468 Offset: 0x2C0F468 VA: 0x2C13468
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C1424C Offset: 0x2C1024C VA: 0x2C1424C
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C15020 Offset: 0x2C11020 VA: 0x2C15020
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C15EA8 Offset: 0x2C11EA8 VA: 0x2C15EA8
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C16CF8 Offset: 0x2C12CF8 VA: 0x2C16CF8
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C17ACC Offset: 0x2C13ACC VA: 0x2C17ACC
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C188A8 Offset: 0x2C148A8 VA: 0x2C188A8
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C1967C Offset: 0x2C1567C VA: 0x2C1967C
	|-ReadOnlyCollection<ByteEnum>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C1A5C8 Offset: 0x2C165C8 VA: 0x2C1A5C8
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C1B3DC Offset: 0x2C173DC VA: 0x2C1B3DC
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C1C1D0 Offset: 0x2C181D0 VA: 0x2C1C1D0
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C1D058 Offset: 0x2C19058 VA: 0x2C1D058
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C1DEB4 Offset: 0x2C19EB4 VA: 0x2C1DEB4
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C1EC88 Offset: 0x2C1AC88 VA: 0x2C1EC88
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C1FA6C Offset: 0x2C1BA6C VA: 0x2C1FA6C
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C20850 Offset: 0x2C1C850 VA: 0x2C20850
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C21664 Offset: 0x2C1D664 VA: 0x2C21664
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C22438 Offset: 0x2C1E438 VA: 0x2C22438
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C2321C Offset: 0x2C1F21C VA: 0x2C2321C
	|-ReadOnlyCollection<EventSummary>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C23FF0 Offset: 0x2C1FFF0 VA: 0x2C23FF0
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C24DC4 Offset: 0x2C20DC4 VA: 0x2C24DC4
	|-ReadOnlyCollection<Int16Enum>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C25B98 Offset: 0x2C21B98 VA: 0x2C25B98
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C2696C Offset: 0x2C2296C VA: 0x2C2696C
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C27740 Offset: 0x2C23740 VA: 0x2C27740
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C28524 Offset: 0x2C24524 VA: 0x2C28524
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C293AC Offset: 0x2C253AC VA: 0x2C293AC
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C2A20C Offset: 0x2C2620C VA: 0x2C2A20C
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C2B094 Offset: 0x2C27094 VA: 0x2C2B094
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C2BF98 Offset: 0x2C27F98 VA: 0x2C2BF98
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C2CDE8 Offset: 0x2C28DE8 VA: 0x2C2CDE8
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C2DC50 Offset: 0x2C29C50 VA: 0x2C2DC50
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C2EB5C Offset: 0x2C2AB5C VA: 0x2C2EB5C
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C2F9BC Offset: 0x2C2B9BC VA: 0x2C2F9BC
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C307B0 Offset: 0x2C2C7B0 VA: 0x2C307B0
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C31594 Offset: 0x2C2D594 VA: 0x2C31594
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C32368 Offset: 0x2C2E368 VA: 0x2C32368
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C3313C Offset: 0x2C2F13C VA: 0x2C3313C
	|-ReadOnlyCollection<SkillIdData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C33F10 Offset: 0x2C2FF10 VA: 0x2C33F10
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C34CE4 Offset: 0x2C30CE4 VA: 0x2C34CE4
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C35AB8 Offset: 0x2C31AB8 VA: 0x2C35AB8
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C3688C Offset: 0x2C3288C VA: 0x2C3688C
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C37670 Offset: 0x2C33670 VA: 0x2C37670
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C38474 Offset: 0x2C34474 VA: 0x2C38474
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C39268 Offset: 0x2C35268 VA: 0x2C39268
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C3A294 Offset: 0x2C36294 VA: 0x2C3A294
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C3B30C Offset: 0x2C3730C VA: 0x2C3B30C
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C3C194 Offset: 0x2C38194 VA: 0x2C3C194
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C3D0A0 Offset: 0x2C390A0 VA: 0x2C3D0A0
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C3DEF0 Offset: 0x2C39EF0 VA: 0x2C3DEF0
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C3ECE4 Offset: 0x2C3ACE4 VA: 0x2C3ECE4
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C3FAE8 Offset: 0x2C3BAE8 VA: 0x2C3FAE8
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C408DC Offset: 0x2C3C8DC VA: 0x2C408DC
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C41724 Offset: 0x2C3D724 VA: 0x2C41724
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C4254C Offset: 0x2C3E54C VA: 0x2C4254C
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C43330 Offset: 0x2C3F330 VA: 0x2C43330
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C44114 Offset: 0x2C40114 VA: 0x2C44114
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C44EE8 Offset: 0x2C40EE8 VA: 0x2C44EE8
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C45D70 Offset: 0x2C41D70 VA: 0x2C45D70
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C46C30 Offset: 0x2C42C30 VA: 0x2C46C30
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C47A48 Offset: 0x2C43A48 VA: 0x2C47A48
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C48890 Offset: 0x2C44890 VA: 0x2C48890
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C496A8 Offset: 0x2C456A8 VA: 0x2C496A8
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C4A48C Offset: 0x2C4648C VA: 0x2C4A48C
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C4B314 Offset: 0x2C47314 VA: 0x2C4B314
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C4C174 Offset: 0x2C48174 VA: 0x2C4C174
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C4CFBC Offset: 0x2C48FBC VA: 0x2C4CFBC
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x2C4DE48 Offset: 0x2C49E48 VA: 0x2C4DE48
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C046D4 Offset: 0x2C006D4 VA: 0x2C046D4
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C054B8 Offset: 0x2C014B8 VA: 0x2C054B8
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C0629C Offset: 0x2C0229C VA: 0x2C0629C
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C07080 Offset: 0x2C03080 VA: 0x2C07080
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C07E54 Offset: 0x2C03E54 VA: 0x2C07E54
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C08C28 Offset: 0x2C04C28 VA: 0x2C08C28
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C09A0C Offset: 0x2C05A0C VA: 0x2C09A0C
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C0A7E0 Offset: 0x2C067E0 VA: 0x2C0A7E0
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C0B668 Offset: 0x2C07668 VA: 0x2C0B668
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C0C4C8 Offset: 0x2C084C8 VA: 0x2C0C4C8
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C0D2AC Offset: 0x2C092AC VA: 0x2C0D2AC
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C0E090 Offset: 0x2C0A090 VA: 0x2C0E090
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C0EE74 Offset: 0x2C0AE74 VA: 0x2C0EE74
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C0FC58 Offset: 0x2C0BC58 VA: 0x2C0FC58
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C10AA0 Offset: 0x2C0CAA0 VA: 0x2C10AA0
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C118CC Offset: 0x2C0D8CC VA: 0x2C118CC
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C126B0 Offset: 0x2C0E6B0 VA: 0x2C126B0
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C13484 Offset: 0x2C0F484 VA: 0x2C13484
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C14268 Offset: 0x2C10268 VA: 0x2C14268
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C1503C Offset: 0x2C1103C VA: 0x2C1503C
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C15EC4 Offset: 0x2C11EC4 VA: 0x2C15EC4
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C16D14 Offset: 0x2C12D14 VA: 0x2C16D14
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C17AE8 Offset: 0x2C13AE8 VA: 0x2C17AE8
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C188C4 Offset: 0x2C148C4 VA: 0x2C188C4
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C19698 Offset: 0x2C15698 VA: 0x2C19698
	|-ReadOnlyCollection<ByteEnum>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C1A5E4 Offset: 0x2C165E4 VA: 0x2C1A5E4
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C1B3F8 Offset: 0x2C173F8 VA: 0x2C1B3F8
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C1C1EC Offset: 0x2C181EC VA: 0x2C1C1EC
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C1D074 Offset: 0x2C19074 VA: 0x2C1D074
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C1DED0 Offset: 0x2C19ED0 VA: 0x2C1DED0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C1ECA4 Offset: 0x2C1ACA4 VA: 0x2C1ECA4
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C1FA88 Offset: 0x2C1BA88 VA: 0x2C1FA88
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C2086C Offset: 0x2C1C86C VA: 0x2C2086C
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C21680 Offset: 0x2C1D680 VA: 0x2C21680
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C22454 Offset: 0x2C1E454 VA: 0x2C22454
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C23238 Offset: 0x2C1F238 VA: 0x2C23238
	|-ReadOnlyCollection<EventSummary>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C2400C Offset: 0x2C2000C VA: 0x2C2400C
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C24DE0 Offset: 0x2C20DE0 VA: 0x2C24DE0
	|-ReadOnlyCollection<Int16Enum>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C25BB4 Offset: 0x2C21BB4 VA: 0x2C25BB4
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C26988 Offset: 0x2C22988 VA: 0x2C26988
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C2775C Offset: 0x2C2375C VA: 0x2C2775C
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C28540 Offset: 0x2C24540 VA: 0x2C28540
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C293C8 Offset: 0x2C253C8 VA: 0x2C293C8
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C2A228 Offset: 0x2C26228 VA: 0x2C2A228
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C2B0B0 Offset: 0x2C270B0 VA: 0x2C2B0B0
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C2BFB4 Offset: 0x2C27FB4 VA: 0x2C2BFB4
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C2CE04 Offset: 0x2C28E04 VA: 0x2C2CE04
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C2DC6C Offset: 0x2C29C6C VA: 0x2C2DC6C
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C2EB78 Offset: 0x2C2AB78 VA: 0x2C2EB78
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C2F9D8 Offset: 0x2C2B9D8 VA: 0x2C2F9D8
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C307CC Offset: 0x2C2C7CC VA: 0x2C307CC
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C315B0 Offset: 0x2C2D5B0 VA: 0x2C315B0
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C32384 Offset: 0x2C2E384 VA: 0x2C32384
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C33158 Offset: 0x2C2F158 VA: 0x2C33158
	|-ReadOnlyCollection<SkillIdData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C33F2C Offset: 0x2C2FF2C VA: 0x2C33F2C
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C34D00 Offset: 0x2C30D00 VA: 0x2C34D00
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C35AD4 Offset: 0x2C31AD4 VA: 0x2C35AD4
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C368A8 Offset: 0x2C328A8 VA: 0x2C368A8
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C3768C Offset: 0x2C3368C VA: 0x2C3768C
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C38490 Offset: 0x2C34490 VA: 0x2C38490
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C39284 Offset: 0x2C35284 VA: 0x2C39284
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C3A2B0 Offset: 0x2C362B0 VA: 0x2C3A2B0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C3B328 Offset: 0x2C37328 VA: 0x2C3B328
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C3C1B0 Offset: 0x2C381B0 VA: 0x2C3C1B0
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C3D0BC Offset: 0x2C390BC VA: 0x2C3D0BC
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C3DF0C Offset: 0x2C39F0C VA: 0x2C3DF0C
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C3ED00 Offset: 0x2C3AD00 VA: 0x2C3ED00
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C3FB04 Offset: 0x2C3BB04 VA: 0x2C3FB04
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C408F8 Offset: 0x2C3C8F8 VA: 0x2C408F8
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C41740 Offset: 0x2C3D740 VA: 0x2C41740
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C42568 Offset: 0x2C3E568 VA: 0x2C42568
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C4334C Offset: 0x2C3F34C VA: 0x2C4334C
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C44130 Offset: 0x2C40130 VA: 0x2C44130
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C44F04 Offset: 0x2C40F04 VA: 0x2C44F04
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C45D8C Offset: 0x2C41D8C VA: 0x2C45D8C
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C46C4C Offset: 0x2C42C4C VA: 0x2C46C4C
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C47A64 Offset: 0x2C43A64 VA: 0x2C47A64
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C488AC Offset: 0x2C448AC VA: 0x2C488AC
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C496C4 Offset: 0x2C456C4 VA: 0x2C496C4
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C4A4A8 Offset: 0x2C464A8 VA: 0x2C4A4A8
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C4B330 Offset: 0x2C47330 VA: 0x2C4B330
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C4C190 Offset: 0x2C48190 VA: 0x2C4C190
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C4CFD8 Offset: 0x2C48FD8 VA: 0x2C4CFD8
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x2C4DE64 Offset: 0x2C49E64 VA: 0x2C4DE64
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.IList<T>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C046E0 Offset: 0x2C006E0 VA: 0x2C046E0
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C054C4 Offset: 0x2C014C4 VA: 0x2C054C4
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C062A8 Offset: 0x2C022A8 VA: 0x2C062A8
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C0708C Offset: 0x2C0308C VA: 0x2C0708C
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C07E60 Offset: 0x2C03E60 VA: 0x2C07E60
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C08C34 Offset: 0x2C04C34 VA: 0x2C08C34
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C09A18 Offset: 0x2C05A18 VA: 0x2C09A18
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C0A7EC Offset: 0x2C067EC VA: 0x2C0A7EC
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C0B674 Offset: 0x2C07674 VA: 0x2C0B674
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C0C4D4 Offset: 0x2C084D4 VA: 0x2C0C4D4
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C0D2B8 Offset: 0x2C092B8 VA: 0x2C0D2B8
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C0E09C Offset: 0x2C0A09C VA: 0x2C0E09C
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C0EE80 Offset: 0x2C0AE80 VA: 0x2C0EE80
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C0FC64 Offset: 0x2C0BC64 VA: 0x2C0FC64
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C10AAC Offset: 0x2C0CAAC VA: 0x2C10AAC
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C118D8 Offset: 0x2C0D8D8 VA: 0x2C118D8
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C126BC Offset: 0x2C0E6BC VA: 0x2C126BC
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C13490 Offset: 0x2C0F490 VA: 0x2C13490
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C14274 Offset: 0x2C10274 VA: 0x2C14274
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C15048 Offset: 0x2C11048 VA: 0x2C15048
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C15ED0 Offset: 0x2C11ED0 VA: 0x2C15ED0
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C16D20 Offset: 0x2C12D20 VA: 0x2C16D20
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C17AF4 Offset: 0x2C13AF4 VA: 0x2C17AF4
	|-ReadOnlyCollection<bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C188D0 Offset: 0x2C148D0 VA: 0x2C188D0
	|-ReadOnlyCollection<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C196A4 Offset: 0x2C156A4 VA: 0x2C196A4
	|-ReadOnlyCollection<ByteEnum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C1A5F0 Offset: 0x2C165F0 VA: 0x2C1A5F0
	|-ReadOnlyCollection<char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C1B404 Offset: 0x2C17404 VA: 0x2C1B404
	|-ReadOnlyCollection<Color>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C1C1F8 Offset: 0x2C181F8 VA: 0x2C1C1F8
	|-ReadOnlyCollection<Color32>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C1D080 Offset: 0x2C19080 VA: 0x2C1D080
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C1DEDC Offset: 0x2C19EDC VA: 0x2C1DEDC
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C1ECB0 Offset: 0x2C1ACB0 VA: 0x2C1ECB0
	|-ReadOnlyCollection<DateTime>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C1FA94 Offset: 0x2C1BA94 VA: 0x2C1FA94
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C20878 Offset: 0x2C1C878 VA: 0x2C20878
	|-ReadOnlyCollection<Decimal>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C2168C Offset: 0x2C1D68C VA: 0x2C2168C
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C22460 Offset: 0x2C1E460 VA: 0x2C22460
	|-ReadOnlyCollection<double>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C23244 Offset: 0x2C1F244 VA: 0x2C23244
	|-ReadOnlyCollection<EventSummary>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C24018 Offset: 0x2C20018 VA: 0x2C24018
	|-ReadOnlyCollection<short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C24DEC Offset: 0x2C20DEC VA: 0x2C24DEC
	|-ReadOnlyCollection<Int16Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C25BC0 Offset: 0x2C21BC0 VA: 0x2C25BC0
	|-ReadOnlyCollection<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C26994 Offset: 0x2C22994 VA: 0x2C26994
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C27768 Offset: 0x2C23768 VA: 0x2C27768
	|-ReadOnlyCollection<long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C2854C Offset: 0x2C2454C VA: 0x2C2854C
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C293D4 Offset: 0x2C253D4 VA: 0x2C293D4
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C2A234 Offset: 0x2C26234 VA: 0x2C2A234
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C2B0BC Offset: 0x2C270BC VA: 0x2C2B0BC
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C2BFC0 Offset: 0x2C27FC0 VA: 0x2C2BFC0
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C2CE10 Offset: 0x2C28E10 VA: 0x2C2CE10
	|-ReadOnlyCollection<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C2DC78 Offset: 0x2C29C78 VA: 0x2C2DC78
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C2EB84 Offset: 0x2C2AB84 VA: 0x2C2EB84
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C2F9E4 Offset: 0x2C2B9E4 VA: 0x2C2F9E4
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C307D8 Offset: 0x2C2C7D8 VA: 0x2C307D8
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C315BC Offset: 0x2C2D5BC VA: 0x2C315BC
	|-ReadOnlyCollection<sbyte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C32390 Offset: 0x2C2E390 VA: 0x2C32390
	|-ReadOnlyCollection<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C33164 Offset: 0x2C2F164 VA: 0x2C33164
	|-ReadOnlyCollection<SkillIdData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C33F38 Offset: 0x2C2FF38 VA: 0x2C33F38
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C34D0C Offset: 0x2C30D0C VA: 0x2C34D0C
	|-ReadOnlyCollection<ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C35AE0 Offset: 0x2C31AE0 VA: 0x2C35AE0
	|-ReadOnlyCollection<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C368B4 Offset: 0x2C328B4 VA: 0x2C368B4
	|-ReadOnlyCollection<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C37698 Offset: 0x2C33698 VA: 0x2C37698
	|-ReadOnlyCollection<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C3849C Offset: 0x2C3449C VA: 0x2C3849C
	|-ReadOnlyCollection<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C39290 Offset: 0x2C35290 VA: 0x2C39290
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C3A2BC Offset: 0x2C362BC VA: 0x2C3A2BC
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C3B334 Offset: 0x2C37334 VA: 0x2C3B334
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C3C1BC Offset: 0x2C381BC VA: 0x2C3C1BC
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C3D0C8 Offset: 0x2C390C8 VA: 0x2C3D0C8
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C3DF18 Offset: 0x2C39F18 VA: 0x2C3DF18
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C3ED0C Offset: 0x2C3AD0C VA: 0x2C3ED0C
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C3FB10 Offset: 0x2C3BB10 VA: 0x2C3FB10
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C40904 Offset: 0x2C3C904 VA: 0x2C40904
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C4174C Offset: 0x2C3D74C VA: 0x2C4174C
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C42574 Offset: 0x2C3E574 VA: 0x2C42574
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C43358 Offset: 0x2C3F358 VA: 0x2C43358
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C4413C Offset: 0x2C4013C VA: 0x2C4413C
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C44F10 Offset: 0x2C40F10 VA: 0x2C44F10
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C45D98 Offset: 0x2C41D98 VA: 0x2C45D98
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C46C58 Offset: 0x2C42C58 VA: 0x2C46C58
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C47A70 Offset: 0x2C43A70 VA: 0x2C47A70
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C488B8 Offset: 0x2C448B8 VA: 0x2C488B8
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C496D0 Offset: 0x2C456D0 VA: 0x2C496D0
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C4A4B4 Offset: 0x2C464B4 VA: 0x2C4A4B4
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C4B33C Offset: 0x2C4733C VA: 0x2C4B33C
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C4C19C Offset: 0x2C4819C VA: 0x2C4C19C
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C4CFE4 Offset: 0x2C48FE4 VA: 0x2C4CFE4
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C4DE70 Offset: 0x2C49E70 VA: 0x2C4DE70
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04780 Offset: 0x2C00780 VA: 0x2C04780
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C05564 Offset: 0x2C01564 VA: 0x2C05564
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C06348 Offset: 0x2C02348 VA: 0x2C06348
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C0712C Offset: 0x2C0312C VA: 0x2C0712C
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C07F00 Offset: 0x2C03F00 VA: 0x2C07F00
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C08CD4 Offset: 0x2C04CD4 VA: 0x2C08CD4
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C09AB8 Offset: 0x2C05AB8 VA: 0x2C09AB8
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C0A88C Offset: 0x2C0688C VA: 0x2C0A88C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C0B714 Offset: 0x2C07714 VA: 0x2C0B714
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C0C574 Offset: 0x2C08574 VA: 0x2C0C574
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C0D358 Offset: 0x2C09358 VA: 0x2C0D358
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C0E13C Offset: 0x2C0A13C VA: 0x2C0E13C
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C0EF20 Offset: 0x2C0AF20 VA: 0x2C0EF20
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C0FD04 Offset: 0x2C0BD04 VA: 0x2C0FD04
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C10B4C Offset: 0x2C0CB4C VA: 0x2C10B4C
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C11978 Offset: 0x2C0D978 VA: 0x2C11978
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C1275C Offset: 0x2C0E75C VA: 0x2C1275C
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C13530 Offset: 0x2C0F530 VA: 0x2C13530
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C14314 Offset: 0x2C10314 VA: 0x2C14314
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C150E8 Offset: 0x2C110E8 VA: 0x2C150E8
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C15F70 Offset: 0x2C11F70 VA: 0x2C15F70
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C16DC0 Offset: 0x2C12DC0 VA: 0x2C16DC0
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C17B94 Offset: 0x2C13B94 VA: 0x2C17B94
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C18970 Offset: 0x2C14970 VA: 0x2C18970
	|-ReadOnlyCollection<byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C19744 Offset: 0x2C15744 VA: 0x2C19744
	|-ReadOnlyCollection<ByteEnum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C1A690 Offset: 0x2C16690 VA: 0x2C1A690
	|-ReadOnlyCollection<char>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C1B4A4 Offset: 0x2C174A4 VA: 0x2C1B4A4
	|-ReadOnlyCollection<Color>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C1C298 Offset: 0x2C18298 VA: 0x2C1C298
	|-ReadOnlyCollection<Color32>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C1D120 Offset: 0x2C19120 VA: 0x2C1D120
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C1DF7C Offset: 0x2C19F7C VA: 0x2C1DF7C
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C1ED50 Offset: 0x2C1AD50 VA: 0x2C1ED50
	|-ReadOnlyCollection<DateTime>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C1FB34 Offset: 0x2C1BB34 VA: 0x2C1FB34
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C20918 Offset: 0x2C1C918 VA: 0x2C20918
	|-ReadOnlyCollection<Decimal>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C2172C Offset: 0x2C1D72C VA: 0x2C2172C
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C22500 Offset: 0x2C1E500 VA: 0x2C22500
	|-ReadOnlyCollection<double>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C232E4 Offset: 0x2C1F2E4 VA: 0x2C232E4
	|-ReadOnlyCollection<EventSummary>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C240B8 Offset: 0x2C200B8 VA: 0x2C240B8
	|-ReadOnlyCollection<short>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C24E8C Offset: 0x2C20E8C VA: 0x2C24E8C
	|-ReadOnlyCollection<Int16Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C25C60 Offset: 0x2C21C60 VA: 0x2C25C60
	|-ReadOnlyCollection<int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C26A34 Offset: 0x2C22A34 VA: 0x2C26A34
	|-ReadOnlyCollection<Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C27808 Offset: 0x2C23808 VA: 0x2C27808
	|-ReadOnlyCollection<long>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C285EC Offset: 0x2C245EC VA: 0x2C285EC
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C29474 Offset: 0x2C25474 VA: 0x2C29474
	|-ReadOnlyCollection<JsonPosition>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C2A2D4 Offset: 0x2C262D4 VA: 0x2C2A2D4
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C2B15C Offset: 0x2C2715C VA: 0x2C2B15C
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C2C060 Offset: 0x2C28060 VA: 0x2C2C060
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C2CEB0 Offset: 0x2C28EB0 VA: 0x2C2CEB0
	|-ReadOnlyCollection<object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C2DD18 Offset: 0x2C29D18 VA: 0x2C2DD18
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C2EC24 Offset: 0x2C2AC24 VA: 0x2C2EC24
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C2FA84 Offset: 0x2C2BA84 VA: 0x2C2FA84
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C30878 Offset: 0x2C2C878 VA: 0x2C30878
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C3165C Offset: 0x2C2D65C VA: 0x2C3165C
	|-ReadOnlyCollection<sbyte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C32430 Offset: 0x2C2E430 VA: 0x2C32430
	|-ReadOnlyCollection<float>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C33204 Offset: 0x2C2F204 VA: 0x2C33204
	|-ReadOnlyCollection<SkillIdData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C33FD8 Offset: 0x2C2FFD8 VA: 0x2C33FD8
	|-ReadOnlyCollection<TimeSpan>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C34DAC Offset: 0x2C30DAC VA: 0x2C34DAC
	|-ReadOnlyCollection<ushort>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C35B80 Offset: 0x2C31B80 VA: 0x2C35B80
	|-ReadOnlyCollection<uint>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C36954 Offset: 0x2C32954 VA: 0x2C36954
	|-ReadOnlyCollection<ulong>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C37738 Offset: 0x2C33738 VA: 0x2C37738
	|-ReadOnlyCollection<Vector2>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C3853C Offset: 0x2C3453C VA: 0x2C3853C
	|-ReadOnlyCollection<Vector3>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C39330 Offset: 0x2C35330 VA: 0x2C39330
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C3A35C Offset: 0x2C3635C VA: 0x2C3A35C
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C3B3D4 Offset: 0x2C373D4 VA: 0x2C3B3D4
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C3C25C Offset: 0x2C3825C VA: 0x2C3C25C
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C3D168 Offset: 0x2C39168 VA: 0x2C3D168
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C3DFB8 Offset: 0x2C39FB8 VA: 0x2C3DFB8
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C3EDAC Offset: 0x2C3ADAC VA: 0x2C3EDAC
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C3FBB0 Offset: 0x2C3BBB0 VA: 0x2C3FBB0
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C409A4 Offset: 0x2C3C9A4 VA: 0x2C409A4
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C417EC Offset: 0x2C3D7EC VA: 0x2C417EC
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C42614 Offset: 0x2C3E614 VA: 0x2C42614
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C433F8 Offset: 0x2C3F3F8 VA: 0x2C433F8
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C441DC Offset: 0x2C401DC VA: 0x2C441DC
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C44FB0 Offset: 0x2C40FB0 VA: 0x2C44FB0
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C45E38 Offset: 0x2C41E38 VA: 0x2C45E38
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C46CF8 Offset: 0x2C42CF8 VA: 0x2C46CF8
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C47B10 Offset: 0x2C43B10 VA: 0x2C47B10
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C48958 Offset: 0x2C44958 VA: 0x2C48958
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C49770 Offset: 0x2C45770 VA: 0x2C49770
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C4A554 Offset: 0x2C46554 VA: 0x2C4A554
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C4B3DC Offset: 0x2C473DC VA: 0x2C4B3DC
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C4C23C Offset: 0x2C4823C VA: 0x2C4C23C
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C4D084 Offset: 0x2C49084 VA: 0x2C4D084
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C4DF10 Offset: 0x2C49F10 VA: 0x2C4DF10
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04788 Offset: 0x2C00788 VA: 0x2C04788
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C0556C Offset: 0x2C0156C VA: 0x2C0556C
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C06350 Offset: 0x2C02350 VA: 0x2C06350
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C07134 Offset: 0x2C03134 VA: 0x2C07134
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C07F08 Offset: 0x2C03F08 VA: 0x2C07F08
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C08CDC Offset: 0x2C04CDC VA: 0x2C08CDC
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C09AC0 Offset: 0x2C05AC0 VA: 0x2C09AC0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C0A894 Offset: 0x2C06894 VA: 0x2C0A894
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C0B71C Offset: 0x2C0771C VA: 0x2C0B71C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C0C57C Offset: 0x2C0857C VA: 0x2C0C57C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C0D360 Offset: 0x2C09360 VA: 0x2C0D360
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C0E144 Offset: 0x2C0A144 VA: 0x2C0E144
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C0EF28 Offset: 0x2C0AF28 VA: 0x2C0EF28
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C0FD0C Offset: 0x2C0BD0C VA: 0x2C0FD0C
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C10B54 Offset: 0x2C0CB54 VA: 0x2C10B54
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C11980 Offset: 0x2C0D980 VA: 0x2C11980
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C12764 Offset: 0x2C0E764 VA: 0x2C12764
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C13538 Offset: 0x2C0F538 VA: 0x2C13538
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C1431C Offset: 0x2C1031C VA: 0x2C1431C
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C150F0 Offset: 0x2C110F0 VA: 0x2C150F0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C15F78 Offset: 0x2C11F78 VA: 0x2C15F78
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C16DC8 Offset: 0x2C12DC8 VA: 0x2C16DC8
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C17B9C Offset: 0x2C13B9C VA: 0x2C17B9C
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C18978 Offset: 0x2C14978 VA: 0x2C18978
	|-ReadOnlyCollection<byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C1974C Offset: 0x2C1574C VA: 0x2C1974C
	|-ReadOnlyCollection<ByteEnum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C1A698 Offset: 0x2C16698 VA: 0x2C1A698
	|-ReadOnlyCollection<char>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C1B4AC Offset: 0x2C174AC VA: 0x2C1B4AC
	|-ReadOnlyCollection<Color>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C1C2A0 Offset: 0x2C182A0 VA: 0x2C1C2A0
	|-ReadOnlyCollection<Color32>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C1D128 Offset: 0x2C19128 VA: 0x2C1D128
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C1DF84 Offset: 0x2C19F84 VA: 0x2C1DF84
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C1ED58 Offset: 0x2C1AD58 VA: 0x2C1ED58
	|-ReadOnlyCollection<DateTime>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C1FB3C Offset: 0x2C1BB3C VA: 0x2C1FB3C
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C20920 Offset: 0x2C1C920 VA: 0x2C20920
	|-ReadOnlyCollection<Decimal>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C21734 Offset: 0x2C1D734 VA: 0x2C21734
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C22508 Offset: 0x2C1E508 VA: 0x2C22508
	|-ReadOnlyCollection<double>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C232EC Offset: 0x2C1F2EC VA: 0x2C232EC
	|-ReadOnlyCollection<EventSummary>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C240C0 Offset: 0x2C200C0 VA: 0x2C240C0
	|-ReadOnlyCollection<short>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C24E94 Offset: 0x2C20E94 VA: 0x2C24E94
	|-ReadOnlyCollection<Int16Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C25C68 Offset: 0x2C21C68 VA: 0x2C25C68
	|-ReadOnlyCollection<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C26A3C Offset: 0x2C22A3C VA: 0x2C26A3C
	|-ReadOnlyCollection<Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C27810 Offset: 0x2C23810 VA: 0x2C27810
	|-ReadOnlyCollection<long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C285F4 Offset: 0x2C245F4 VA: 0x2C285F4
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C2947C Offset: 0x2C2547C VA: 0x2C2947C
	|-ReadOnlyCollection<JsonPosition>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C2A2DC Offset: 0x2C262DC VA: 0x2C2A2DC
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C2B164 Offset: 0x2C27164 VA: 0x2C2B164
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C2C068 Offset: 0x2C28068 VA: 0x2C2C068
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C2CEB8 Offset: 0x2C28EB8 VA: 0x2C2CEB8
	|-ReadOnlyCollection<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C2DD20 Offset: 0x2C29D20 VA: 0x2C2DD20
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C2EC2C Offset: 0x2C2AC2C VA: 0x2C2EC2C
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C2FA8C Offset: 0x2C2BA8C VA: 0x2C2FA8C
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C30880 Offset: 0x2C2C880 VA: 0x2C30880
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C31664 Offset: 0x2C2D664 VA: 0x2C31664
	|-ReadOnlyCollection<sbyte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C32438 Offset: 0x2C2E438 VA: 0x2C32438
	|-ReadOnlyCollection<float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C3320C Offset: 0x2C2F20C VA: 0x2C3320C
	|-ReadOnlyCollection<SkillIdData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C33FE0 Offset: 0x2C2FFE0 VA: 0x2C33FE0
	|-ReadOnlyCollection<TimeSpan>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C34DB4 Offset: 0x2C30DB4 VA: 0x2C34DB4
	|-ReadOnlyCollection<ushort>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C35B88 Offset: 0x2C31B88 VA: 0x2C35B88
	|-ReadOnlyCollection<uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C3695C Offset: 0x2C3295C VA: 0x2C3695C
	|-ReadOnlyCollection<ulong>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C37740 Offset: 0x2C33740 VA: 0x2C37740
	|-ReadOnlyCollection<Vector2>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C38544 Offset: 0x2C34544 VA: 0x2C38544
	|-ReadOnlyCollection<Vector3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C39338 Offset: 0x2C35338 VA: 0x2C39338
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C3A364 Offset: 0x2C36364 VA: 0x2C3A364
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C3B3DC Offset: 0x2C373DC VA: 0x2C3B3DC
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C3C264 Offset: 0x2C38264 VA: 0x2C3C264
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C3D170 Offset: 0x2C39170 VA: 0x2C3D170
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C3DFC0 Offset: 0x2C39FC0 VA: 0x2C3DFC0
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C3EDB4 Offset: 0x2C3ADB4 VA: 0x2C3EDB4
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C3FBB8 Offset: 0x2C3BBB8 VA: 0x2C3FBB8
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C409AC Offset: 0x2C3C9AC VA: 0x2C409AC
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C417F4 Offset: 0x2C3D7F4 VA: 0x2C417F4
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C4261C Offset: 0x2C3E61C VA: 0x2C4261C
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C43400 Offset: 0x2C3F400 VA: 0x2C43400
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C441E4 Offset: 0x2C401E4 VA: 0x2C441E4
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C44FB8 Offset: 0x2C40FB8 VA: 0x2C44FB8
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C45E40 Offset: 0x2C41E40 VA: 0x2C45E40
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C46D00 Offset: 0x2C42D00 VA: 0x2C46D00
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C47B18 Offset: 0x2C43B18 VA: 0x2C47B18
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C48960 Offset: 0x2C44960 VA: 0x2C48960
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C49778 Offset: 0x2C45778 VA: 0x2C49778
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C4A55C Offset: 0x2C4655C VA: 0x2C4A55C
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C4B3E4 Offset: 0x2C473E4 VA: 0x2C4B3E4
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C4C244 Offset: 0x2C48244 VA: 0x2C4C244
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C4D08C Offset: 0x2C4908C VA: 0x2C4D08C
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C4DF18 Offset: 0x2C49F18 VA: 0x2C4DF18
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04894 Offset: 0x2C00894 VA: 0x2C04894
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C05678 Offset: 0x2C01678 VA: 0x2C05678
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C0645C Offset: 0x2C0245C VA: 0x2C0645C
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C07240 Offset: 0x2C03240 VA: 0x2C07240
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C08014 Offset: 0x2C04014 VA: 0x2C08014
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C08DE8 Offset: 0x2C04DE8 VA: 0x2C08DE8
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C09BCC Offset: 0x2C05BCC VA: 0x2C09BCC
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C0A9A0 Offset: 0x2C069A0 VA: 0x2C0A9A0
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C0B828 Offset: 0x2C07828 VA: 0x2C0B828
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C0C688 Offset: 0x2C08688 VA: 0x2C0C688
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C0D46C Offset: 0x2C0946C VA: 0x2C0D46C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C0E250 Offset: 0x2C0A250 VA: 0x2C0E250
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C0F034 Offset: 0x2C0B034 VA: 0x2C0F034
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C0FE18 Offset: 0x2C0BE18 VA: 0x2C0FE18
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C10C60 Offset: 0x2C0CC60 VA: 0x2C10C60
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C11A8C Offset: 0x2C0DA8C VA: 0x2C11A8C
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C12870 Offset: 0x2C0E870 VA: 0x2C12870
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C13644 Offset: 0x2C0F644 VA: 0x2C13644
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C14428 Offset: 0x2C10428 VA: 0x2C14428
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C151FC Offset: 0x2C111FC VA: 0x2C151FC
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C16084 Offset: 0x2C12084 VA: 0x2C16084
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C16ED4 Offset: 0x2C12ED4 VA: 0x2C16ED4
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C17CA8 Offset: 0x2C13CA8 VA: 0x2C17CA8
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C18A84 Offset: 0x2C14A84 VA: 0x2C18A84
	|-ReadOnlyCollection<byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C19858 Offset: 0x2C15858 VA: 0x2C19858
	|-ReadOnlyCollection<ByteEnum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C1A7A4 Offset: 0x2C167A4 VA: 0x2C1A7A4
	|-ReadOnlyCollection<char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C1B5B8 Offset: 0x2C175B8 VA: 0x2C1B5B8
	|-ReadOnlyCollection<Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C1C3AC Offset: 0x2C183AC VA: 0x2C1C3AC
	|-ReadOnlyCollection<Color32>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C1D234 Offset: 0x2C19234 VA: 0x2C1D234
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C1E090 Offset: 0x2C1A090 VA: 0x2C1E090
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C1EE64 Offset: 0x2C1AE64 VA: 0x2C1EE64
	|-ReadOnlyCollection<DateTime>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C1FC48 Offset: 0x2C1BC48 VA: 0x2C1FC48
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C20A2C Offset: 0x2C1CA2C VA: 0x2C20A2C
	|-ReadOnlyCollection<Decimal>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C21840 Offset: 0x2C1D840 VA: 0x2C21840
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C22614 Offset: 0x2C1E614 VA: 0x2C22614
	|-ReadOnlyCollection<double>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C233F8 Offset: 0x2C1F3F8 VA: 0x2C233F8
	|-ReadOnlyCollection<EventSummary>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C241CC Offset: 0x2C201CC VA: 0x2C241CC
	|-ReadOnlyCollection<short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C24FA0 Offset: 0x2C20FA0 VA: 0x2C24FA0
	|-ReadOnlyCollection<Int16Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C25D74 Offset: 0x2C21D74 VA: 0x2C25D74
	|-ReadOnlyCollection<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C26B48 Offset: 0x2C22B48 VA: 0x2C26B48
	|-ReadOnlyCollection<Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C2791C Offset: 0x2C2391C VA: 0x2C2791C
	|-ReadOnlyCollection<long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C28700 Offset: 0x2C24700 VA: 0x2C28700
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C29588 Offset: 0x2C25588 VA: 0x2C29588
	|-ReadOnlyCollection<JsonPosition>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C2A3E8 Offset: 0x2C263E8 VA: 0x2C2A3E8
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C2B270 Offset: 0x2C27270 VA: 0x2C2B270
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C2C174 Offset: 0x2C28174 VA: 0x2C2C174
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C2CFC4 Offset: 0x2C28FC4 VA: 0x2C2CFC4
	|-ReadOnlyCollection<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C2DE2C Offset: 0x2C29E2C VA: 0x2C2DE2C
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C2ED38 Offset: 0x2C2AD38 VA: 0x2C2ED38
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C2FB98 Offset: 0x2C2BB98 VA: 0x2C2FB98
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C3098C Offset: 0x2C2C98C VA: 0x2C3098C
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C31770 Offset: 0x2C2D770 VA: 0x2C31770
	|-ReadOnlyCollection<sbyte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C32544 Offset: 0x2C2E544 VA: 0x2C32544
	|-ReadOnlyCollection<float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C33318 Offset: 0x2C2F318 VA: 0x2C33318
	|-ReadOnlyCollection<SkillIdData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C340EC Offset: 0x2C300EC VA: 0x2C340EC
	|-ReadOnlyCollection<TimeSpan>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C34EC0 Offset: 0x2C30EC0 VA: 0x2C34EC0
	|-ReadOnlyCollection<ushort>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C35C94 Offset: 0x2C31C94 VA: 0x2C35C94
	|-ReadOnlyCollection<uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C36A68 Offset: 0x2C32A68 VA: 0x2C36A68
	|-ReadOnlyCollection<ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C3784C Offset: 0x2C3384C VA: 0x2C3784C
	|-ReadOnlyCollection<Vector2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C38650 Offset: 0x2C34650 VA: 0x2C38650
	|-ReadOnlyCollection<Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C39444 Offset: 0x2C35444 VA: 0x2C39444
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C3A470 Offset: 0x2C36470 VA: 0x2C3A470
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C3B4E8 Offset: 0x2C374E8 VA: 0x2C3B4E8
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C3C370 Offset: 0x2C38370 VA: 0x2C3C370
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C3D27C Offset: 0x2C3927C VA: 0x2C3D27C
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C3E0CC Offset: 0x2C3A0CC VA: 0x2C3E0CC
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C3EEC0 Offset: 0x2C3AEC0 VA: 0x2C3EEC0
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C3FCC4 Offset: 0x2C3BCC4 VA: 0x2C3FCC4
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C40AB8 Offset: 0x2C3CAB8 VA: 0x2C40AB8
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C41900 Offset: 0x2C3D900 VA: 0x2C41900
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C42728 Offset: 0x2C3E728 VA: 0x2C42728
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C4350C Offset: 0x2C3F50C VA: 0x2C4350C
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C442F0 Offset: 0x2C402F0 VA: 0x2C442F0
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C450C4 Offset: 0x2C410C4 VA: 0x2C450C4
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C45F4C Offset: 0x2C41F4C VA: 0x2C45F4C
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C46E0C Offset: 0x2C42E0C VA: 0x2C46E0C
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C47C24 Offset: 0x2C43C24 VA: 0x2C47C24
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C48A6C Offset: 0x2C44A6C VA: 0x2C48A6C
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C49884 Offset: 0x2C45884 VA: 0x2C49884
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C4A668 Offset: 0x2C46668 VA: 0x2C4A668
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C4B4F0 Offset: 0x2C474F0 VA: 0x2C4B4F0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C4C350 Offset: 0x2C48350 VA: 0x2C4C350
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C4D198 Offset: 0x2C49198 VA: 0x2C4D198
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C4E024 Offset: 0x2C4A024 VA: 0x2C4E024
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04D34 Offset: 0x2C00D34 VA: 0x2C04D34
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C05B18 Offset: 0x2C01B18 VA: 0x2C05B18
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C068FC Offset: 0x2C028FC VA: 0x2C068FC
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C076E0 Offset: 0x2C036E0 VA: 0x2C076E0
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C084B4 Offset: 0x2C044B4 VA: 0x2C084B4
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C09288 Offset: 0x2C05288 VA: 0x2C09288
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C0A06C Offset: 0x2C0606C VA: 0x2C0A06C
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C0AE40 Offset: 0x2C06E40 VA: 0x2C0AE40
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C0BCE8 Offset: 0x2C07CE8 VA: 0x2C0BCE8
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C0CB28 Offset: 0x2C08B28 VA: 0x2C0CB28
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C0D90C Offset: 0x2C0990C VA: 0x2C0D90C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C0E6F0 Offset: 0x2C0A6F0 VA: 0x2C0E6F0
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C0F4D4 Offset: 0x2C0B4D4 VA: 0x2C0F4D4
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C102B8 Offset: 0x2C0C2B8 VA: 0x2C102B8
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C1110C Offset: 0x2C0D10C VA: 0x2C1110C
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C11F2C Offset: 0x2C0DF2C VA: 0x2C11F2C
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C12D10 Offset: 0x2C0ED10 VA: 0x2C12D10
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C13AE4 Offset: 0x2C0FAE4 VA: 0x2C13AE4
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C148C8 Offset: 0x2C108C8 VA: 0x2C148C8
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C1569C Offset: 0x2C1169C VA: 0x2C1569C
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C1653C Offset: 0x2C1253C VA: 0x2C1653C
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C17374 Offset: 0x2C13374 VA: 0x2C17374
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C1814C Offset: 0x2C1414C VA: 0x2C1814C
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C18F24 Offset: 0x2C14F24 VA: 0x2C18F24
	|-ReadOnlyCollection<byte>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C19CF8 Offset: 0x2C15CF8 VA: 0x2C19CF8
	|-ReadOnlyCollection<ByteEnum>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C1AC44 Offset: 0x2C16C44 VA: 0x2C1AC44
	|-ReadOnlyCollection<char>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C1BA5C Offset: 0x2C17A5C VA: 0x2C1BA5C
	|-ReadOnlyCollection<Color>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C1C84C Offset: 0x2C1884C VA: 0x2C1C84C
	|-ReadOnlyCollection<Color32>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C1D6EC Offset: 0x2C196EC VA: 0x2C1D6EC
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C1E530 Offset: 0x2C1A530 VA: 0x2C1E530
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C1F304 Offset: 0x2C1B304 VA: 0x2C1F304
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C200E8 Offset: 0x2C1C0E8 VA: 0x2C200E8
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C20EE4 Offset: 0x2C1CEE4 VA: 0x2C20EE4
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C21CE0 Offset: 0x2C1DCE0 VA: 0x2C21CE0
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C22AB4 Offset: 0x2C1EAB4 VA: 0x2C22AB4
	|-ReadOnlyCollection<double>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C23898 Offset: 0x2C1F898 VA: 0x2C23898
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C2466C Offset: 0x2C2066C VA: 0x2C2466C
	|-ReadOnlyCollection<short>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C25440 Offset: 0x2C21440 VA: 0x2C25440
	|-ReadOnlyCollection<Int16Enum>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C26214 Offset: 0x2C22214 VA: 0x2C26214
	|-ReadOnlyCollection<int>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C26FE8 Offset: 0x2C22FE8 VA: 0x2C26FE8
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C27DBC Offset: 0x2C23DBC VA: 0x2C27DBC
	|-ReadOnlyCollection<long>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C28BA0 Offset: 0x2C24BA0 VA: 0x2C28BA0
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C29A40 Offset: 0x2C25A40 VA: 0x2C29A40
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C2A888 Offset: 0x2C26888 VA: 0x2C2A888
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C2B728 Offset: 0x2C27728 VA: 0x2C2B728
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C2C62C Offset: 0x2C2862C VA: 0x2C2C62C
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C2D448 Offset: 0x2C29448 VA: 0x2C2D448
	|-ReadOnlyCollection<object>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C2E2E4 Offset: 0x2C2A2E4 VA: 0x2C2E2E4
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C2F1F0 Offset: 0x2C2B1F0 VA: 0x2C2F1F0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C30038 Offset: 0x2C2C038 VA: 0x2C30038
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C30E30 Offset: 0x2C2CE30 VA: 0x2C30E30
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C31C10 Offset: 0x2C2DC10 VA: 0x2C31C10
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C329E4 Offset: 0x2C2E9E4 VA: 0x2C329E4
	|-ReadOnlyCollection<float>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C337B8 Offset: 0x2C2F7B8 VA: 0x2C337B8
	|-ReadOnlyCollection<SkillIdData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C3458C Offset: 0x2C3058C VA: 0x2C3458C
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C35360 Offset: 0x2C31360 VA: 0x2C35360
	|-ReadOnlyCollection<ushort>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C36134 Offset: 0x2C32134 VA: 0x2C36134
	|-ReadOnlyCollection<uint>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C36F08 Offset: 0x2C32F08 VA: 0x2C36F08
	|-ReadOnlyCollection<ulong>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C37CEC Offset: 0x2C33CEC VA: 0x2C37CEC
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C38AF4 Offset: 0x2C34AF4 VA: 0x2C38AF4
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C398E4 Offset: 0x2C358E4 VA: 0x2C398E4
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C3A96C Offset: 0x2C3696C VA: 0x2C3A96C
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C3B988 Offset: 0x2C37988 VA: 0x2C3B988
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C3C828 Offset: 0x2C38828 VA: 0x2C3C828
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C3D734 Offset: 0x2C39734 VA: 0x2C3D734
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C3E56C Offset: 0x2C3A56C VA: 0x2C3E56C
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C3F364 Offset: 0x2C3B364 VA: 0x2C3F364
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C40168 Offset: 0x2C3C168 VA: 0x2C40168
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C40F58 Offset: 0x2C3CF58 VA: 0x2C40F58
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C41DAC Offset: 0x2C3DDAC VA: 0x2C41DAC
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C42BC8 Offset: 0x2C3EBC8 VA: 0x2C42BC8
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C439AC Offset: 0x2C3F9AC VA: 0x2C439AC
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C44790 Offset: 0x2C40790 VA: 0x2C44790
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C45564 Offset: 0x2C41564 VA: 0x2C45564
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C46404 Offset: 0x2C42404 VA: 0x2C46404
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C472B8 Offset: 0x2C432B8 VA: 0x2C472B8
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C480C4 Offset: 0x2C440C4 VA: 0x2C480C4
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C48F18 Offset: 0x2C44F18 VA: 0x2C48F18
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C49D24 Offset: 0x2C45D24 VA: 0x2C49D24
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C4AB08 Offset: 0x2C46B08 VA: 0x2C4AB08
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C4B9A8 Offset: 0x2C479A8 VA: 0x2C4B9A8
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C4C7F0 Offset: 0x2C487F0 VA: 0x2C4C7F0
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C4D644 Offset: 0x2C49644 VA: 0x2C4D644
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C4E4D0 Offset: 0x2C4A4D0 VA: 0x2C4E4D0
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04D3C Offset: 0x2C00D3C VA: 0x2C04D3C
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C05B20 Offset: 0x2C01B20 VA: 0x2C05B20
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C06904 Offset: 0x2C02904 VA: 0x2C06904
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C076E8 Offset: 0x2C036E8 VA: 0x2C076E8
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C084BC Offset: 0x2C044BC VA: 0x2C084BC
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C09290 Offset: 0x2C05290 VA: 0x2C09290
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C0A074 Offset: 0x2C06074 VA: 0x2C0A074
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C0AE48 Offset: 0x2C06E48 VA: 0x2C0AE48
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C0BCF0 Offset: 0x2C07CF0 VA: 0x2C0BCF0
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C0CB30 Offset: 0x2C08B30 VA: 0x2C0CB30
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C0D914 Offset: 0x2C09914 VA: 0x2C0D914
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C0E6F8 Offset: 0x2C0A6F8 VA: 0x2C0E6F8
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C0F4DC Offset: 0x2C0B4DC VA: 0x2C0F4DC
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C102C0 Offset: 0x2C0C2C0 VA: 0x2C102C0
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C11114 Offset: 0x2C0D114 VA: 0x2C11114
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C11F34 Offset: 0x2C0DF34 VA: 0x2C11F34
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C12D18 Offset: 0x2C0ED18 VA: 0x2C12D18
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C13AEC Offset: 0x2C0FAEC VA: 0x2C13AEC
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C148D0 Offset: 0x2C108D0 VA: 0x2C148D0
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C156A4 Offset: 0x2C116A4 VA: 0x2C156A4
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C16544 Offset: 0x2C12544 VA: 0x2C16544
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C1737C Offset: 0x2C1337C VA: 0x2C1737C
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C18154 Offset: 0x2C14154 VA: 0x2C18154
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C18F2C Offset: 0x2C14F2C VA: 0x2C18F2C
	|-ReadOnlyCollection<byte>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C19D00 Offset: 0x2C15D00 VA: 0x2C19D00
	|-ReadOnlyCollection<ByteEnum>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C1AC4C Offset: 0x2C16C4C VA: 0x2C1AC4C
	|-ReadOnlyCollection<char>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C1BA64 Offset: 0x2C17A64 VA: 0x2C1BA64
	|-ReadOnlyCollection<Color>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C1C854 Offset: 0x2C18854 VA: 0x2C1C854
	|-ReadOnlyCollection<Color32>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C1D6F4 Offset: 0x2C196F4 VA: 0x2C1D6F4
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C1E538 Offset: 0x2C1A538 VA: 0x2C1E538
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C1F30C Offset: 0x2C1B30C VA: 0x2C1F30C
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C200F0 Offset: 0x2C1C0F0 VA: 0x2C200F0
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C20EEC Offset: 0x2C1CEEC VA: 0x2C20EEC
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C21CE8 Offset: 0x2C1DCE8 VA: 0x2C21CE8
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C22ABC Offset: 0x2C1EABC VA: 0x2C22ABC
	|-ReadOnlyCollection<double>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C238A0 Offset: 0x2C1F8A0 VA: 0x2C238A0
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C24674 Offset: 0x2C20674 VA: 0x2C24674
	|-ReadOnlyCollection<short>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C25448 Offset: 0x2C21448 VA: 0x2C25448
	|-ReadOnlyCollection<Int16Enum>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C2621C Offset: 0x2C2221C VA: 0x2C2621C
	|-ReadOnlyCollection<int>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C26FF0 Offset: 0x2C22FF0 VA: 0x2C26FF0
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C27DC4 Offset: 0x2C23DC4 VA: 0x2C27DC4
	|-ReadOnlyCollection<long>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C28BA8 Offset: 0x2C24BA8 VA: 0x2C28BA8
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C29A48 Offset: 0x2C25A48 VA: 0x2C29A48
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C2A890 Offset: 0x2C26890 VA: 0x2C2A890
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C2B730 Offset: 0x2C27730 VA: 0x2C2B730
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C2C634 Offset: 0x2C28634 VA: 0x2C2C634
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C2D450 Offset: 0x2C29450 VA: 0x2C2D450
	|-ReadOnlyCollection<object>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C2E2EC Offset: 0x2C2A2EC VA: 0x2C2E2EC
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C2F1F8 Offset: 0x2C2B1F8 VA: 0x2C2F1F8
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C30040 Offset: 0x2C2C040 VA: 0x2C30040
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C30E38 Offset: 0x2C2CE38 VA: 0x2C30E38
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C31C18 Offset: 0x2C2DC18 VA: 0x2C31C18
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C329EC Offset: 0x2C2E9EC VA: 0x2C329EC
	|-ReadOnlyCollection<float>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C337C0 Offset: 0x2C2F7C0 VA: 0x2C337C0
	|-ReadOnlyCollection<SkillIdData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C34594 Offset: 0x2C30594 VA: 0x2C34594
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C35368 Offset: 0x2C31368 VA: 0x2C35368
	|-ReadOnlyCollection<ushort>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C3613C Offset: 0x2C3213C VA: 0x2C3613C
	|-ReadOnlyCollection<uint>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C36F10 Offset: 0x2C32F10 VA: 0x2C36F10
	|-ReadOnlyCollection<ulong>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C37CF4 Offset: 0x2C33CF4 VA: 0x2C37CF4
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C38AFC Offset: 0x2C34AFC VA: 0x2C38AFC
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C398EC Offset: 0x2C358EC VA: 0x2C398EC
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C3A974 Offset: 0x2C36974 VA: 0x2C3A974
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C3B990 Offset: 0x2C37990 VA: 0x2C3B990
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C3C830 Offset: 0x2C38830 VA: 0x2C3C830
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C3D73C Offset: 0x2C3973C VA: 0x2C3D73C
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C3E574 Offset: 0x2C3A574 VA: 0x2C3E574
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C3F36C Offset: 0x2C3B36C VA: 0x2C3F36C
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C40170 Offset: 0x2C3C170 VA: 0x2C40170
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C40F60 Offset: 0x2C3CF60 VA: 0x2C40F60
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C41DB4 Offset: 0x2C3DDB4 VA: 0x2C41DB4
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C42BD0 Offset: 0x2C3EBD0 VA: 0x2C42BD0
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C439B4 Offset: 0x2C3F9B4 VA: 0x2C439B4
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C44798 Offset: 0x2C40798 VA: 0x2C44798
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C4556C Offset: 0x2C4156C VA: 0x2C4556C
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C4640C Offset: 0x2C4240C VA: 0x2C4640C
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C472C0 Offset: 0x2C432C0 VA: 0x2C472C0
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C480CC Offset: 0x2C440CC VA: 0x2C480CC
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C48F20 Offset: 0x2C44F20 VA: 0x2C48F20
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C49D2C Offset: 0x2C45D2C VA: 0x2C49D2C
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C4AB10 Offset: 0x2C46B10 VA: 0x2C4AB10
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C4B9B0 Offset: 0x2C479B0 VA: 0x2C4B9B0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C4C7F8 Offset: 0x2C487F8 VA: 0x2C4C7F8
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C4D64C Offset: 0x2C4964C VA: 0x2C4D64C
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C4E4D8 Offset: 0x2C4A4D8 VA: 0x2C4E4D8
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04D44 Offset: 0x2C00D44 VA: 0x2C04D44
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C05B28 Offset: 0x2C01B28 VA: 0x2C05B28
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C0690C Offset: 0x2C0290C VA: 0x2C0690C
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C076F0 Offset: 0x2C036F0 VA: 0x2C076F0
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C084C4 Offset: 0x2C044C4 VA: 0x2C084C4
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C09298 Offset: 0x2C05298 VA: 0x2C09298
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C0A07C Offset: 0x2C0607C VA: 0x2C0A07C
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C0AE50 Offset: 0x2C06E50 VA: 0x2C0AE50
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C0BCF8 Offset: 0x2C07CF8 VA: 0x2C0BCF8
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C0CB38 Offset: 0x2C08B38 VA: 0x2C0CB38
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C0D91C Offset: 0x2C0991C VA: 0x2C0D91C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C0E700 Offset: 0x2C0A700 VA: 0x2C0E700
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C0F4E4 Offset: 0x2C0B4E4 VA: 0x2C0F4E4
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C102C8 Offset: 0x2C0C2C8 VA: 0x2C102C8
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C1111C Offset: 0x2C0D11C VA: 0x2C1111C
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C11F3C Offset: 0x2C0DF3C VA: 0x2C11F3C
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C12D20 Offset: 0x2C0ED20 VA: 0x2C12D20
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C13AF4 Offset: 0x2C0FAF4 VA: 0x2C13AF4
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C148D8 Offset: 0x2C108D8 VA: 0x2C148D8
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C156AC Offset: 0x2C116AC VA: 0x2C156AC
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C1654C Offset: 0x2C1254C VA: 0x2C1654C
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C17384 Offset: 0x2C13384 VA: 0x2C17384
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C1815C Offset: 0x2C1415C VA: 0x2C1815C
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C18F34 Offset: 0x2C14F34 VA: 0x2C18F34
	|-ReadOnlyCollection<byte>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C19D08 Offset: 0x2C15D08 VA: 0x2C19D08
	|-ReadOnlyCollection<ByteEnum>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C1AC54 Offset: 0x2C16C54 VA: 0x2C1AC54
	|-ReadOnlyCollection<char>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C1BA6C Offset: 0x2C17A6C VA: 0x2C1BA6C
	|-ReadOnlyCollection<Color>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C1C85C Offset: 0x2C1885C VA: 0x2C1C85C
	|-ReadOnlyCollection<Color32>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C1D6FC Offset: 0x2C196FC VA: 0x2C1D6FC
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C1E540 Offset: 0x2C1A540 VA: 0x2C1E540
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C1F314 Offset: 0x2C1B314 VA: 0x2C1F314
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C200F8 Offset: 0x2C1C0F8 VA: 0x2C200F8
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C20EF4 Offset: 0x2C1CEF4 VA: 0x2C20EF4
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C21CF0 Offset: 0x2C1DCF0 VA: 0x2C21CF0
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C22AC4 Offset: 0x2C1EAC4 VA: 0x2C22AC4
	|-ReadOnlyCollection<double>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C238A8 Offset: 0x2C1F8A8 VA: 0x2C238A8
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C2467C Offset: 0x2C2067C VA: 0x2C2467C
	|-ReadOnlyCollection<short>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C25450 Offset: 0x2C21450 VA: 0x2C25450
	|-ReadOnlyCollection<Int16Enum>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C26224 Offset: 0x2C22224 VA: 0x2C26224
	|-ReadOnlyCollection<int>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C26FF8 Offset: 0x2C22FF8 VA: 0x2C26FF8
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C27DCC Offset: 0x2C23DCC VA: 0x2C27DCC
	|-ReadOnlyCollection<long>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C28BB0 Offset: 0x2C24BB0 VA: 0x2C28BB0
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C29A50 Offset: 0x2C25A50 VA: 0x2C29A50
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C2A898 Offset: 0x2C26898 VA: 0x2C2A898
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C2B738 Offset: 0x2C27738 VA: 0x2C2B738
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C2C63C Offset: 0x2C2863C VA: 0x2C2C63C
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C2D458 Offset: 0x2C29458 VA: 0x2C2D458
	|-ReadOnlyCollection<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C2E2F4 Offset: 0x2C2A2F4 VA: 0x2C2E2F4
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C2F200 Offset: 0x2C2B200 VA: 0x2C2F200
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C30048 Offset: 0x2C2C048 VA: 0x2C30048
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C30E40 Offset: 0x2C2CE40 VA: 0x2C30E40
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C31C20 Offset: 0x2C2DC20 VA: 0x2C31C20
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C329F4 Offset: 0x2C2E9F4 VA: 0x2C329F4
	|-ReadOnlyCollection<float>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C337C8 Offset: 0x2C2F7C8 VA: 0x2C337C8
	|-ReadOnlyCollection<SkillIdData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C3459C Offset: 0x2C3059C VA: 0x2C3459C
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C35370 Offset: 0x2C31370 VA: 0x2C35370
	|-ReadOnlyCollection<ushort>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C36144 Offset: 0x2C32144 VA: 0x2C36144
	|-ReadOnlyCollection<uint>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C36F18 Offset: 0x2C32F18 VA: 0x2C36F18
	|-ReadOnlyCollection<ulong>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C37CFC Offset: 0x2C33CFC VA: 0x2C37CFC
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C38B04 Offset: 0x2C34B04 VA: 0x2C38B04
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C398F4 Offset: 0x2C358F4 VA: 0x2C398F4
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C3A97C Offset: 0x2C3697C VA: 0x2C3A97C
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C3B998 Offset: 0x2C37998 VA: 0x2C3B998
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C3C838 Offset: 0x2C38838 VA: 0x2C3C838
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C3D744 Offset: 0x2C39744 VA: 0x2C3D744
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C3E57C Offset: 0x2C3A57C VA: 0x2C3E57C
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C3F374 Offset: 0x2C3B374 VA: 0x2C3F374
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C40178 Offset: 0x2C3C178 VA: 0x2C40178
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C40F68 Offset: 0x2C3CF68 VA: 0x2C40F68
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C41DBC Offset: 0x2C3DDBC VA: 0x2C41DBC
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C42BD8 Offset: 0x2C3EBD8 VA: 0x2C42BD8
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C439BC Offset: 0x2C3F9BC VA: 0x2C439BC
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C447A0 Offset: 0x2C407A0 VA: 0x2C447A0
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C45574 Offset: 0x2C41574 VA: 0x2C45574
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C46414 Offset: 0x2C42414 VA: 0x2C46414
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C472C8 Offset: 0x2C432C8 VA: 0x2C472C8
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C480D4 Offset: 0x2C440D4 VA: 0x2C480D4
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C48F28 Offset: 0x2C44F28 VA: 0x2C48F28
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C49D34 Offset: 0x2C45D34 VA: 0x2C49D34
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C4AB18 Offset: 0x2C46B18 VA: 0x2C4AB18
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C4B9B8 Offset: 0x2C479B8 VA: 0x2C4B9B8
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C4C800 Offset: 0x2C48800 VA: 0x2C4C800
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C4D654 Offset: 0x2C49654 VA: 0x2C4D654
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C4E4E0 Offset: 0x2C4A4E0 VA: 0x2C4E4E0
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04E04 Offset: 0x2C00E04 VA: 0x2C04E04
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C05BE8 Offset: 0x2C01BE8 VA: 0x2C05BE8
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C069CC Offset: 0x2C029CC VA: 0x2C069CC
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C077B0 Offset: 0x2C037B0 VA: 0x2C077B0
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C08584 Offset: 0x2C04584 VA: 0x2C08584
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C09358 Offset: 0x2C05358 VA: 0x2C09358
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C0A13C Offset: 0x2C0613C VA: 0x2C0A13C
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C0AF10 Offset: 0x2C06F10 VA: 0x2C0AF10
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C0BDD8 Offset: 0x2C07DD8 VA: 0x2C0BDD8
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C0CBF8 Offset: 0x2C08BF8 VA: 0x2C0CBF8
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C0D9DC Offset: 0x2C099DC VA: 0x2C0D9DC
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C0E7C0 Offset: 0x2C0A7C0 VA: 0x2C0E7C0
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C0F5A4 Offset: 0x2C0B5A4 VA: 0x2C0F5A4
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C10388 Offset: 0x2C0C388 VA: 0x2C10388
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C111E8 Offset: 0x2C0D1E8 VA: 0x2C111E8
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C11FFC Offset: 0x2C0DFFC VA: 0x2C11FFC
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C12DE0 Offset: 0x2C0EDE0 VA: 0x2C12DE0
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C13BB4 Offset: 0x2C0FBB4 VA: 0x2C13BB4
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C14998 Offset: 0x2C10998 VA: 0x2C14998
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C1576C Offset: 0x2C1176C VA: 0x2C1576C
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C16624 Offset: 0x2C12624 VA: 0x2C16624
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C17444 Offset: 0x2C13444 VA: 0x2C17444
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C18220 Offset: 0x2C14220 VA: 0x2C18220
	|-ReadOnlyCollection<bool>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C18FF4 Offset: 0x2C14FF4 VA: 0x2C18FF4
	|-ReadOnlyCollection<byte>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C19DC8 Offset: 0x2C15DC8 VA: 0x2C19DC8
	|-ReadOnlyCollection<ByteEnum>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C1AD14 Offset: 0x2C16D14 VA: 0x2C1AD14
	|-ReadOnlyCollection<char>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C1BB30 Offset: 0x2C17B30 VA: 0x2C1BB30
	|-ReadOnlyCollection<Color>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C1C91C Offset: 0x2C1891C VA: 0x2C1C91C
	|-ReadOnlyCollection<Color32>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C1D7D0 Offset: 0x2C197D0 VA: 0x2C1D7D0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C1E600 Offset: 0x2C1A600 VA: 0x2C1E600
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C1F3D4 Offset: 0x2C1B3D4 VA: 0x2C1F3D4
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C201B8 Offset: 0x2C1C1B8 VA: 0x2C201B8
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C20FDC Offset: 0x2C1CFDC VA: 0x2C20FDC
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C21DB0 Offset: 0x2C1DDB0 VA: 0x2C21DB0
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C22B84 Offset: 0x2C1EB84 VA: 0x2C22B84
	|-ReadOnlyCollection<double>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C23968 Offset: 0x2C1F968 VA: 0x2C23968
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C2473C Offset: 0x2C2073C VA: 0x2C2473C
	|-ReadOnlyCollection<short>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C25510 Offset: 0x2C21510 VA: 0x2C25510
	|-ReadOnlyCollection<Int16Enum>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C262E4 Offset: 0x2C222E4 VA: 0x2C262E4
	|-ReadOnlyCollection<int>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C270B8 Offset: 0x2C230B8 VA: 0x2C270B8
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C27E8C Offset: 0x2C23E8C VA: 0x2C27E8C
	|-ReadOnlyCollection<long>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C28C70 Offset: 0x2C24C70 VA: 0x2C28C70
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C29B28 Offset: 0x2C25B28 VA: 0x2C29B28
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C2A958 Offset: 0x2C26958 VA: 0x2C2A958
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C2B810 Offset: 0x2C27810 VA: 0x2C2B810
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C2C714 Offset: 0x2C28714 VA: 0x2C2C714
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C2D4F0 Offset: 0x2C294F0 VA: 0x2C2D4F0
	|-ReadOnlyCollection<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C2E3CC Offset: 0x2C2A3CC VA: 0x2C2E3CC
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C2F2D8 Offset: 0x2C2B2D8 VA: 0x2C2F2D8
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C30108 Offset: 0x2C2C108 VA: 0x2C30108
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C30F04 Offset: 0x2C2CF04 VA: 0x2C30F04
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C31CE0 Offset: 0x2C2DCE0 VA: 0x2C31CE0
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C32AB4 Offset: 0x2C2EAB4 VA: 0x2C32AB4
	|-ReadOnlyCollection<float>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C33888 Offset: 0x2C2F888 VA: 0x2C33888
	|-ReadOnlyCollection<SkillIdData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C3465C Offset: 0x2C3065C VA: 0x2C3465C
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C35430 Offset: 0x2C31430 VA: 0x2C35430
	|-ReadOnlyCollection<ushort>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C36204 Offset: 0x2C32204 VA: 0x2C36204
	|-ReadOnlyCollection<uint>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C36FD8 Offset: 0x2C32FD8 VA: 0x2C36FD8
	|-ReadOnlyCollection<ulong>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C37DBC Offset: 0x2C33DBC VA: 0x2C37DBC
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C38BC8 Offset: 0x2C34BC8 VA: 0x2C38BC8
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C399B4 Offset: 0x2C359B4 VA: 0x2C399B4
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C3AA9C Offset: 0x2C36A9C VA: 0x2C3AA9C
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C3BA58 Offset: 0x2C37A58 VA: 0x2C3BA58
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C3C910 Offset: 0x2C38910 VA: 0x2C3C910
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C3D81C Offset: 0x2C3981C VA: 0x2C3D81C
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C3E63C Offset: 0x2C3A63C VA: 0x2C3E63C
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C3F438 Offset: 0x2C3B438 VA: 0x2C3F438
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C4023C Offset: 0x2C3C23C VA: 0x2C4023C
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C41028 Offset: 0x2C3D028 VA: 0x2C41028
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C41E88 Offset: 0x2C3DE88 VA: 0x2C41E88
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C42C98 Offset: 0x2C3EC98 VA: 0x2C42C98
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C43A7C Offset: 0x2C3FA7C VA: 0x2C43A7C
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C44860 Offset: 0x2C40860 VA: 0x2C44860
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C45634 Offset: 0x2C41634 VA: 0x2C45634
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C464E8 Offset: 0x2C424E8 VA: 0x2C464E8
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C47394 Offset: 0x2C43394 VA: 0x2C47394
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C48194 Offset: 0x2C44194 VA: 0x2C48194
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C48FF4 Offset: 0x2C44FF4 VA: 0x2C48FF4
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C49DF4 Offset: 0x2C45DF4 VA: 0x2C49DF4
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C4ABD8 Offset: 0x2C46BD8 VA: 0x2C4ABD8
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C4BA90 Offset: 0x2C47A90 VA: 0x2C4BA90
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C4C8C0 Offset: 0x2C488C0 VA: 0x2C4C8C0
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C4D720 Offset: 0x2C49720 VA: 0x2C4D720
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C4E5AC Offset: 0x2C4A5AC VA: 0x2C4E5AC
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04E10 Offset: 0x2C00E10 VA: 0x2C04E10
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C05BF4 Offset: 0x2C01BF4 VA: 0x2C05BF4
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C069D8 Offset: 0x2C029D8 VA: 0x2C069D8
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C077BC Offset: 0x2C037BC VA: 0x2C077BC
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C08590 Offset: 0x2C04590 VA: 0x2C08590
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C09364 Offset: 0x2C05364 VA: 0x2C09364
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C0A148 Offset: 0x2C06148 VA: 0x2C0A148
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C0AF1C Offset: 0x2C06F1C VA: 0x2C0AF1C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C0BDE4 Offset: 0x2C07DE4 VA: 0x2C0BDE4
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C0CC04 Offset: 0x2C08C04 VA: 0x2C0CC04
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C0D9E8 Offset: 0x2C099E8 VA: 0x2C0D9E8
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C0E7CC Offset: 0x2C0A7CC VA: 0x2C0E7CC
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C0F5B0 Offset: 0x2C0B5B0 VA: 0x2C0F5B0
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C10394 Offset: 0x2C0C394 VA: 0x2C10394
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C111F4 Offset: 0x2C0D1F4 VA: 0x2C111F4
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C12008 Offset: 0x2C0E008 VA: 0x2C12008
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C12DEC Offset: 0x2C0EDEC VA: 0x2C12DEC
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C13BC0 Offset: 0x2C0FBC0 VA: 0x2C13BC0
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C149A4 Offset: 0x2C109A4 VA: 0x2C149A4
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C15778 Offset: 0x2C11778 VA: 0x2C15778
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C16630 Offset: 0x2C12630 VA: 0x2C16630
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.IList.Add
	|
	|-RVA: 0x2C17450 Offset: 0x2C13450 VA: 0x2C17450
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.IList.Add
	|
	|-RVA: 0x2C1822C Offset: 0x2C1422C VA: 0x2C1822C
	|-ReadOnlyCollection<bool>.System.Collections.IList.Add
	|
	|-RVA: 0x2C19000 Offset: 0x2C15000 VA: 0x2C19000
	|-ReadOnlyCollection<byte>.System.Collections.IList.Add
	|
	|-RVA: 0x2C19DD4 Offset: 0x2C15DD4 VA: 0x2C19DD4
	|-ReadOnlyCollection<ByteEnum>.System.Collections.IList.Add
	|
	|-RVA: 0x2C1AD20 Offset: 0x2C16D20 VA: 0x2C1AD20
	|-ReadOnlyCollection<char>.System.Collections.IList.Add
	|
	|-RVA: 0x2C1BB3C Offset: 0x2C17B3C VA: 0x2C1BB3C
	|-ReadOnlyCollection<Color>.System.Collections.IList.Add
	|
	|-RVA: 0x2C1C928 Offset: 0x2C18928 VA: 0x2C1C928
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Add
	|
	|-RVA: 0x2C1D7DC Offset: 0x2C197DC VA: 0x2C1D7DC
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Add
	|
	|-RVA: 0x2C1E60C Offset: 0x2C1A60C VA: 0x2C1E60C
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Add
	|
	|-RVA: 0x2C1F3E0 Offset: 0x2C1B3E0 VA: 0x2C1F3E0
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Add
	|
	|-RVA: 0x2C201C4 Offset: 0x2C1C1C4 VA: 0x2C201C4
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Add
	|
	|-RVA: 0x2C20FE8 Offset: 0x2C1CFE8 VA: 0x2C20FE8
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Add
	|
	|-RVA: 0x2C21DBC Offset: 0x2C1DDBC VA: 0x2C21DBC
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.IList.Add
	|
	|-RVA: 0x2C22B90 Offset: 0x2C1EB90 VA: 0x2C22B90
	|-ReadOnlyCollection<double>.System.Collections.IList.Add
	|
	|-RVA: 0x2C23974 Offset: 0x2C1F974 VA: 0x2C23974
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.Add
	|
	|-RVA: 0x2C24748 Offset: 0x2C20748 VA: 0x2C24748
	|-ReadOnlyCollection<short>.System.Collections.IList.Add
	|
	|-RVA: 0x2C2551C Offset: 0x2C2151C VA: 0x2C2551C
	|-ReadOnlyCollection<Int16Enum>.System.Collections.IList.Add
	|
	|-RVA: 0x2C262F0 Offset: 0x2C222F0 VA: 0x2C262F0
	|-ReadOnlyCollection<int>.System.Collections.IList.Add
	|
	|-RVA: 0x2C270C4 Offset: 0x2C230C4 VA: 0x2C270C4
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Add
	|
	|-RVA: 0x2C27E98 Offset: 0x2C23E98 VA: 0x2C27E98
	|-ReadOnlyCollection<long>.System.Collections.IList.Add
	|
	|-RVA: 0x2C28C7C Offset: 0x2C24C7C VA: 0x2C28C7C
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x2C29B34 Offset: 0x2C25B34 VA: 0x2C29B34
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.Add
	|
	|-RVA: 0x2C2A964 Offset: 0x2C26964 VA: 0x2C2A964
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.IList.Add
	|
	|-RVA: 0x2C2B81C Offset: 0x2C2781C VA: 0x2C2B81C
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.IList.Add
	|
	|-RVA: 0x2C2C720 Offset: 0x2C28720 VA: 0x2C2C720
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.IList.Add
	|
	|-RVA: 0x2C2D4FC Offset: 0x2C294FC VA: 0x2C2D4FC
	|-ReadOnlyCollection<object>.System.Collections.IList.Add
	|
	|-RVA: 0x2C2E3D8 Offset: 0x2C2A3D8 VA: 0x2C2E3D8
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.Add
	|
	|-RVA: 0x2C2F2E4 Offset: 0x2C2B2E4 VA: 0x2C2F2E4
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.Add
	|
	|-RVA: 0x2C30114 Offset: 0x2C2C114 VA: 0x2C30114
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x2C30F10 Offset: 0x2C2CF10 VA: 0x2C30F10
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.IList.Add
	|
	|-RVA: 0x2C31CEC Offset: 0x2C2DCEC VA: 0x2C31CEC
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Add
	|
	|-RVA: 0x2C32AC0 Offset: 0x2C2EAC0 VA: 0x2C32AC0
	|-ReadOnlyCollection<float>.System.Collections.IList.Add
	|
	|-RVA: 0x2C33894 Offset: 0x2C2F894 VA: 0x2C33894
	|-ReadOnlyCollection<SkillIdData>.System.Collections.IList.Add
	|
	|-RVA: 0x2C34668 Offset: 0x2C30668 VA: 0x2C34668
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Add
	|
	|-RVA: 0x2C3543C Offset: 0x2C3143C VA: 0x2C3543C
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Add
	|
	|-RVA: 0x2C36210 Offset: 0x2C32210 VA: 0x2C36210
	|-ReadOnlyCollection<uint>.System.Collections.IList.Add
	|
	|-RVA: 0x2C36FE4 Offset: 0x2C32FE4 VA: 0x2C36FE4
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Add
	|
	|-RVA: 0x2C37DC8 Offset: 0x2C33DC8 VA: 0x2C37DC8
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Add
	|
	|-RVA: 0x2C38BD4 Offset: 0x2C34BD4 VA: 0x2C38BD4
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Add
	|
	|-RVA: 0x2C399C0 Offset: 0x2C359C0 VA: 0x2C399C0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Add
	|
	|-RVA: 0x2C3AAA8 Offset: 0x2C36AA8 VA: 0x2C3AAA8
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	|
	|-RVA: 0x2C3BA64 Offset: 0x2C37A64 VA: 0x2C3BA64
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Add
	|
	|-RVA: 0x2C3C91C Offset: 0x2C3891C VA: 0x2C3C91C
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.IList.Add
	|
	|-RVA: 0x2C3D828 Offset: 0x2C39828 VA: 0x2C3D828
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.IList.Add
	|
	|-RVA: 0x2C3E648 Offset: 0x2C3A648 VA: 0x2C3E648
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.IList.Add
	|
	|-RVA: 0x2C3F444 Offset: 0x2C3B444 VA: 0x2C3F444
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.Add
	|
	|-RVA: 0x2C40248 Offset: 0x2C3C248 VA: 0x2C40248
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.Add
	|
	|-RVA: 0x2C41034 Offset: 0x2C3D034 VA: 0x2C41034
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.Add
	|
	|-RVA: 0x2C41E94 Offset: 0x2C3DE94 VA: 0x2C41E94
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.IList.Add
	|
	|-RVA: 0x2C42CA4 Offset: 0x2C3ECA4 VA: 0x2C42CA4
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.Add
	|
	|-RVA: 0x2C43A88 Offset: 0x2C3FA88 VA: 0x2C43A88
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.Add
	|
	|-RVA: 0x2C4486C Offset: 0x2C4086C VA: 0x2C4486C
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.IList.Add
	|
	|-RVA: 0x2C45640 Offset: 0x2C41640 VA: 0x2C45640
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.IList.Add
	|
	|-RVA: 0x2C464F4 Offset: 0x2C424F4 VA: 0x2C464F4
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.IList.Add
	|
	|-RVA: 0x2C473A0 Offset: 0x2C433A0 VA: 0x2C473A0
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.IList.Add
	|
	|-RVA: 0x2C481A0 Offset: 0x2C441A0 VA: 0x2C481A0
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.IList.Add
	|
	|-RVA: 0x2C49000 Offset: 0x2C45000 VA: 0x2C49000
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.IList.Add
	|
	|-RVA: 0x2C49E00 Offset: 0x2C45E00 VA: 0x2C49E00
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.IList.Add
	|
	|-RVA: 0x2C4ABE4 Offset: 0x2C46BE4 VA: 0x2C4ABE4
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.IList.Add
	|
	|-RVA: 0x2C4BA9C Offset: 0x2C47A9C VA: 0x2C4BA9C
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Add
	|
	|-RVA: 0x2C4C8CC Offset: 0x2C488CC VA: 0x2C4C8CC
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Add
	|
	|-RVA: 0x2C4D72C Offset: 0x2C4972C VA: 0x2C4D72C
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.Add
	|
	|-RVA: 0x2C4E5B8 Offset: 0x2C4A5B8 VA: 0x2C4E5B8
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IList.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04E2C Offset: 0x2C00E2C VA: 0x2C04E2C
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C05C10 Offset: 0x2C01C10 VA: 0x2C05C10
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C069F4 Offset: 0x2C029F4 VA: 0x2C069F4
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C077D8 Offset: 0x2C037D8 VA: 0x2C077D8
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C085AC Offset: 0x2C045AC VA: 0x2C085AC
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C09380 Offset: 0x2C05380 VA: 0x2C09380
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C0A164 Offset: 0x2C06164 VA: 0x2C0A164
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C0AF38 Offset: 0x2C06F38 VA: 0x2C0AF38
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C0BE00 Offset: 0x2C07E00 VA: 0x2C0BE00
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C0CC20 Offset: 0x2C08C20 VA: 0x2C0CC20
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C0DA04 Offset: 0x2C09A04 VA: 0x2C0DA04
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C0E7E8 Offset: 0x2C0A7E8 VA: 0x2C0E7E8
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C0F5CC Offset: 0x2C0B5CC VA: 0x2C0F5CC
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C103B0 Offset: 0x2C0C3B0 VA: 0x2C103B0
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C11210 Offset: 0x2C0D210 VA: 0x2C11210
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C12024 Offset: 0x2C0E024 VA: 0x2C12024
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C12E08 Offset: 0x2C0EE08 VA: 0x2C12E08
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C13BDC Offset: 0x2C0FBDC VA: 0x2C13BDC
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C149C0 Offset: 0x2C109C0 VA: 0x2C149C0
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C15794 Offset: 0x2C11794 VA: 0x2C15794
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C1664C Offset: 0x2C1264C VA: 0x2C1664C
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C1746C Offset: 0x2C1346C VA: 0x2C1746C
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C18248 Offset: 0x2C14248 VA: 0x2C18248
	|-ReadOnlyCollection<bool>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C1901C Offset: 0x2C1501C VA: 0x2C1901C
	|-ReadOnlyCollection<byte>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C19DF0 Offset: 0x2C15DF0 VA: 0x2C19DF0
	|-ReadOnlyCollection<ByteEnum>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C1AD3C Offset: 0x2C16D3C VA: 0x2C1AD3C
	|-ReadOnlyCollection<char>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C1BB58 Offset: 0x2C17B58 VA: 0x2C1BB58
	|-ReadOnlyCollection<Color>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C1C944 Offset: 0x2C18944 VA: 0x2C1C944
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C1D7F8 Offset: 0x2C197F8 VA: 0x2C1D7F8
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C1E628 Offset: 0x2C1A628 VA: 0x2C1E628
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C1F3FC Offset: 0x2C1B3FC VA: 0x2C1F3FC
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C201E0 Offset: 0x2C1C1E0 VA: 0x2C201E0
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C21004 Offset: 0x2C1D004 VA: 0x2C21004
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C21DD8 Offset: 0x2C1DDD8 VA: 0x2C21DD8
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C22BAC Offset: 0x2C1EBAC VA: 0x2C22BAC
	|-ReadOnlyCollection<double>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C23990 Offset: 0x2C1F990 VA: 0x2C23990
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C24764 Offset: 0x2C20764 VA: 0x2C24764
	|-ReadOnlyCollection<short>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C25538 Offset: 0x2C21538 VA: 0x2C25538
	|-ReadOnlyCollection<Int16Enum>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C2630C Offset: 0x2C2230C VA: 0x2C2630C
	|-ReadOnlyCollection<int>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C270E0 Offset: 0x2C230E0 VA: 0x2C270E0
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C27EB4 Offset: 0x2C23EB4 VA: 0x2C27EB4
	|-ReadOnlyCollection<long>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C28C98 Offset: 0x2C24C98 VA: 0x2C28C98
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C29B50 Offset: 0x2C25B50 VA: 0x2C29B50
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C2A980 Offset: 0x2C26980 VA: 0x2C2A980
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C2B838 Offset: 0x2C27838 VA: 0x2C2B838
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C2C73C Offset: 0x2C2873C VA: 0x2C2C73C
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C2D518 Offset: 0x2C29518 VA: 0x2C2D518
	|-ReadOnlyCollection<object>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C2E3F4 Offset: 0x2C2A3F4 VA: 0x2C2E3F4
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C2F300 Offset: 0x2C2B300 VA: 0x2C2F300
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C30130 Offset: 0x2C2C130 VA: 0x2C30130
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C30F2C Offset: 0x2C2CF2C VA: 0x2C30F2C
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C31D08 Offset: 0x2C2DD08 VA: 0x2C31D08
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C32ADC Offset: 0x2C2EADC VA: 0x2C32ADC
	|-ReadOnlyCollection<float>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C338B0 Offset: 0x2C2F8B0 VA: 0x2C338B0
	|-ReadOnlyCollection<SkillIdData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C34684 Offset: 0x2C30684 VA: 0x2C34684
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C35458 Offset: 0x2C31458 VA: 0x2C35458
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C3622C Offset: 0x2C3222C VA: 0x2C3622C
	|-ReadOnlyCollection<uint>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C37000 Offset: 0x2C33000 VA: 0x2C37000
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C37DE4 Offset: 0x2C33DE4 VA: 0x2C37DE4
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C38BF0 Offset: 0x2C34BF0 VA: 0x2C38BF0
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C399DC Offset: 0x2C359DC VA: 0x2C399DC
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C3AAC4 Offset: 0x2C36AC4 VA: 0x2C3AAC4
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C3BA80 Offset: 0x2C37A80 VA: 0x2C3BA80
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C3C938 Offset: 0x2C38938 VA: 0x2C3C938
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C3D844 Offset: 0x2C39844 VA: 0x2C3D844
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C3E664 Offset: 0x2C3A664 VA: 0x2C3E664
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C3F460 Offset: 0x2C3B460 VA: 0x2C3F460
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C40264 Offset: 0x2C3C264 VA: 0x2C40264
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C41050 Offset: 0x2C3D050 VA: 0x2C41050
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C41EB0 Offset: 0x2C3DEB0 VA: 0x2C41EB0
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C42CC0 Offset: 0x2C3ECC0 VA: 0x2C42CC0
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C43AA4 Offset: 0x2C3FAA4 VA: 0x2C43AA4
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C44888 Offset: 0x2C40888 VA: 0x2C44888
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C4565C Offset: 0x2C4165C VA: 0x2C4565C
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C46510 Offset: 0x2C42510 VA: 0x2C46510
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C473BC Offset: 0x2C433BC VA: 0x2C473BC
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C481BC Offset: 0x2C441BC VA: 0x2C481BC
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C4901C Offset: 0x2C4501C VA: 0x2C4901C
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C49E1C Offset: 0x2C45E1C VA: 0x2C49E1C
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C4AC00 Offset: 0x2C46C00 VA: 0x2C4AC00
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C4BAB8 Offset: 0x2C47AB8 VA: 0x2C4BAB8
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C4C8E8 Offset: 0x2C488E8 VA: 0x2C4C8E8
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C4D748 Offset: 0x2C49748 VA: 0x2C4D748
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.Clear
	|
	|-RVA: 0x2C4E5D4 Offset: 0x2C4A5D4 VA: 0x2C4E5D4
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.Clear
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04E38 Offset: 0x2C00E38 VA: 0x2C04E38
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.IsCompatibleObject
	|
	|-RVA: 0x2C05C1C Offset: 0x2C01C1C VA: 0x2C05C1C
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.IsCompatibleObject
	|
	|-RVA: 0x2C06A00 Offset: 0x2C02A00 VA: 0x2C06A00
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.IsCompatibleObject
	|
	|-RVA: 0x2C077E4 Offset: 0x2C037E4 VA: 0x2C077E4
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.IsCompatibleObject
	|
	|-RVA: 0x2C085B8 Offset: 0x2C045B8 VA: 0x2C085B8
	|-ReadOnlyCollection<KeyValuePair<int, short>>.IsCompatibleObject
	|
	|-RVA: 0x2C0938C Offset: 0x2C0538C VA: 0x2C0938C
	|-ReadOnlyCollection<KeyValuePair<int, int>>.IsCompatibleObject
	|
	|-RVA: 0x2C0A170 Offset: 0x2C06170 VA: 0x2C0A170
	|-ReadOnlyCollection<KeyValuePair<int, object>>.IsCompatibleObject
	|
	|-RVA: 0x2C0AF44 Offset: 0x2C06F44 VA: 0x2C0AF44
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.IsCompatibleObject
	|
	|-RVA: 0x2C0BE0C Offset: 0x2C07E0C VA: 0x2C0BE0C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.IsCompatibleObject
	|
	|-RVA: 0x2C0CC2C Offset: 0x2C08C2C VA: 0x2C0CC2C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.IsCompatibleObject
	|
	|-RVA: 0x2C0DA10 Offset: 0x2C09A10 VA: 0x2C0DA10
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.IsCompatibleObject
	|
	|-RVA: 0x2C0E7F4 Offset: 0x2C0A7F4 VA: 0x2C0E7F4
	|-ReadOnlyCollection<KeyValuePair<object, int>>.IsCompatibleObject
	|
	|-RVA: 0x2C0F5D8 Offset: 0x2C0B5D8 VA: 0x2C0F5D8
	|-ReadOnlyCollection<KeyValuePair<object, float>>.IsCompatibleObject
	|
	|-RVA: 0x2C103BC Offset: 0x2C0C3BC VA: 0x2C103BC
	|-ReadOnlyCollection<KeyValuePair<float, object>>.IsCompatibleObject
	|
	|-RVA: 0x2C1121C Offset: 0x2C0D21C VA: 0x2C1121C
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.IsCompatibleObject
	|
	|-RVA: 0x2C12030 Offset: 0x2C0E030 VA: 0x2C12030
	|-ReadOnlyCollection<StructMultiKey<object, object>>.IsCompatibleObject
	|
	|-RVA: 0x2C12E14 Offset: 0x2C0EE14 VA: 0x2C12E14
	|-ReadOnlyCollection<ValueTuple<short, short>>.IsCompatibleObject
	|
	|-RVA: 0x2C13BE8 Offset: 0x2C0FBE8 VA: 0x2C13BE8
	|-ReadOnlyCollection<ValueTuple<int, int>>.IsCompatibleObject
	|
	|-RVA: 0x2C149CC Offset: 0x2C109CC VA: 0x2C149CC
	|-ReadOnlyCollection<ValueTuple<int, object>>.IsCompatibleObject
	|
	|-RVA: 0x2C157A0 Offset: 0x2C117A0 VA: 0x2C157A0
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.IsCompatibleObject
	|
	|-RVA: 0x2C16658 Offset: 0x2C12658 VA: 0x2C16658
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.IsCompatibleObject
	|
	|-RVA: 0x2C17478 Offset: 0x2C13478 VA: 0x2C17478
	|-ReadOnlyCollection<ArchetypeUid>.IsCompatibleObject
	|
	|-RVA: 0x2C18254 Offset: 0x2C14254 VA: 0x2C18254
	|-ReadOnlyCollection<bool>.IsCompatibleObject
	|
	|-RVA: 0x2C19028 Offset: 0x2C15028 VA: 0x2C19028
	|-ReadOnlyCollection<byte>.IsCompatibleObject
	|
	|-RVA: 0x2C19DFC Offset: 0x2C15DFC VA: 0x2C19DFC
	|-ReadOnlyCollection<ByteEnum>.IsCompatibleObject
	|
	|-RVA: 0x2C1AD48 Offset: 0x2C16D48 VA: 0x2C1AD48
	|-ReadOnlyCollection<char>.IsCompatibleObject
	|
	|-RVA: 0x2C1BB64 Offset: 0x2C17B64 VA: 0x2C1BB64
	|-ReadOnlyCollection<Color>.IsCompatibleObject
	|
	|-RVA: 0x2C1C950 Offset: 0x2C18950 VA: 0x2C1C950
	|-ReadOnlyCollection<Color32>.IsCompatibleObject
	|
	|-RVA: 0x2C1D804 Offset: 0x2C19804 VA: 0x2C1D804
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.IsCompatibleObject
	|
	|-RVA: 0x2C1E634 Offset: 0x2C1A634 VA: 0x2C1E634
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.IsCompatibleObject
	|
	|-RVA: 0x2C1F408 Offset: 0x2C1B408 VA: 0x2C1F408
	|-ReadOnlyCollection<DateTime>.IsCompatibleObject
	|
	|-RVA: 0x2C201EC Offset: 0x2C1C1EC VA: 0x2C201EC
	|-ReadOnlyCollection<DateTimeOffset>.IsCompatibleObject
	|
	|-RVA: 0x2C21010 Offset: 0x2C1D010 VA: 0x2C21010
	|-ReadOnlyCollection<Decimal>.IsCompatibleObject
	|
	|-RVA: 0x2C21DE4 Offset: 0x2C1DDE4 VA: 0x2C21DE4
	|-ReadOnlyCollection<DefencePoint2>.IsCompatibleObject
	|
	|-RVA: 0x2C22BB8 Offset: 0x2C1EBB8 VA: 0x2C22BB8
	|-ReadOnlyCollection<double>.IsCompatibleObject
	|
	|-RVA: 0x2C2399C Offset: 0x2C1F99C VA: 0x2C2399C
	|-ReadOnlyCollection<EventSummary>.IsCompatibleObject
	|
	|-RVA: 0x2C24770 Offset: 0x2C20770 VA: 0x2C24770
	|-ReadOnlyCollection<short>.IsCompatibleObject
	|
	|-RVA: 0x2C25544 Offset: 0x2C21544 VA: 0x2C25544
	|-ReadOnlyCollection<Int16Enum>.IsCompatibleObject
	|
	|-RVA: 0x2C26318 Offset: 0x2C22318 VA: 0x2C26318
	|-ReadOnlyCollection<int>.IsCompatibleObject
	|
	|-RVA: 0x2C270EC Offset: 0x2C230EC VA: 0x2C270EC
	|-ReadOnlyCollection<Int32Enum>.IsCompatibleObject
	|
	|-RVA: 0x2C27EC0 Offset: 0x2C23EC0 VA: 0x2C27EC0
	|-ReadOnlyCollection<long>.IsCompatibleObject
	|
	|-RVA: 0x2C28CA4 Offset: 0x2C24CA4 VA: 0x2C28CA4
	|-ReadOnlyCollection<InterpretedFrameInfo>.IsCompatibleObject
	|
	|-RVA: 0x2C29B5C Offset: 0x2C25B5C VA: 0x2C29B5C
	|-ReadOnlyCollection<JsonPosition>.IsCompatibleObject
	|
	|-RVA: 0x2C2A98C Offset: 0x2C2698C VA: 0x2C2A98C
	|-ReadOnlyCollection<MaterialSearchData>.IsCompatibleObject
	|
	|-RVA: 0x2C2B844 Offset: 0x2C27844 VA: 0x2C2B844
	|-ReadOnlyCollection<MobActionTargetData>.IsCompatibleObject
	|
	|-RVA: 0x2C2C748 Offset: 0x2C28748 VA: 0x2C2C748
	|-ReadOnlyCollection<MobIconLabelData>.IsCompatibleObject
	|
	|-RVA: 0x2C2D524 Offset: 0x2C29524 VA: 0x2C2D524
	|-ReadOnlyCollection<object>.IsCompatibleObject
	|
	|-RVA: 0x2C2E400 Offset: 0x2C2A400 VA: 0x2C2E400
	|-ReadOnlyCollection<PlayerLoopSystem>.IsCompatibleObject
	|
	|-RVA: 0x2C2F30C Offset: 0x2C2B30C VA: 0x2C2F30C
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.IsCompatibleObject
	|
	|-RVA: 0x2C3013C Offset: 0x2C2C13C VA: 0x2C3013C
	|-ReadOnlyCollection<RangePositionInfo>.IsCompatibleObject
	|
	|-RVA: 0x2C30F38 Offset: 0x2C2CF38 VA: 0x2C30F38
	|-ReadOnlyCollection<ReinforceCristaData>.IsCompatibleObject
	|
	|-RVA: 0x2C31D14 Offset: 0x2C2DD14 VA: 0x2C31D14
	|-ReadOnlyCollection<sbyte>.IsCompatibleObject
	|
	|-RVA: 0x2C32AE8 Offset: 0x2C2EAE8 VA: 0x2C32AE8
	|-ReadOnlyCollection<float>.IsCompatibleObject
	|
	|-RVA: 0x2C338BC Offset: 0x2C2F8BC VA: 0x2C338BC
	|-ReadOnlyCollection<SkillIdData>.IsCompatibleObject
	|
	|-RVA: 0x2C34690 Offset: 0x2C30690 VA: 0x2C34690
	|-ReadOnlyCollection<TimeSpan>.IsCompatibleObject
	|
	|-RVA: 0x2C35464 Offset: 0x2C31464 VA: 0x2C35464
	|-ReadOnlyCollection<ushort>.IsCompatibleObject
	|
	|-RVA: 0x2C36238 Offset: 0x2C32238 VA: 0x2C36238
	|-ReadOnlyCollection<uint>.IsCompatibleObject
	|
	|-RVA: 0x2C3700C Offset: 0x2C3300C VA: 0x2C3700C
	|-ReadOnlyCollection<ulong>.IsCompatibleObject
	|
	|-RVA: 0x2C37DF0 Offset: 0x2C33DF0 VA: 0x2C37DF0
	|-ReadOnlyCollection<Vector2>.IsCompatibleObject
	|
	|-RVA: 0x2C38BFC Offset: 0x2C34BFC VA: 0x2C38BFC
	|-ReadOnlyCollection<Vector3>.IsCompatibleObject
	|
	|-RVA: 0x2C399E8 Offset: 0x2C359E8 VA: 0x2C399E8
	|-ReadOnlyCollection<X509ChainStatus>.IsCompatibleObject
	|
	|-RVA: 0x2C3AAD0 Offset: 0x2C36AD0 VA: 0x2C3AAD0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.IsCompatibleObject
	|
	|-RVA: 0x2C3BA8C Offset: 0x2C37A8C VA: 0x2C3BA8C
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.IsCompatibleObject
	|
	|-RVA: 0x2C3C944 Offset: 0x2C38944 VA: 0x2C3C944
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.IsCompatibleObject
	|
	|-RVA: 0x2C3D850 Offset: 0x2C39850 VA: 0x2C3D850
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.IsCompatibleObject
	|
	|-RVA: 0x2C3E670 Offset: 0x2C3A670 VA: 0x2C3E670
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.IsCompatibleObject
	|
	|-RVA: 0x2C3F46C Offset: 0x2C3B46C VA: 0x2C3F46C
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.IsCompatibleObject
	|
	|-RVA: 0x2C40270 Offset: 0x2C3C270 VA: 0x2C40270
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.IsCompatibleObject
	|
	|-RVA: 0x2C4105C Offset: 0x2C3D05C VA: 0x2C4105C
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.IsCompatibleObject
	|
	|-RVA: 0x2C41EBC Offset: 0x2C3DEBC VA: 0x2C41EBC
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.IsCompatibleObject
	|
	|-RVA: 0x2C42CCC Offset: 0x2C3ECCC VA: 0x2C42CCC
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.IsCompatibleObject
	|
	|-RVA: 0x2C43AB0 Offset: 0x2C3FAB0 VA: 0x2C43AB0
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.IsCompatibleObject
	|
	|-RVA: 0x2C44894 Offset: 0x2C40894 VA: 0x2C44894
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.IsCompatibleObject
	|
	|-RVA: 0x2C45668 Offset: 0x2C41668 VA: 0x2C45668
	|-ReadOnlyCollection<TrophyManager.TrophyData>.IsCompatibleObject
	|
	|-RVA: 0x2C4651C Offset: 0x2C4251C VA: 0x2C4651C
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.IsCompatibleObject
	|
	|-RVA: 0x2C473C8 Offset: 0x2C433C8 VA: 0x2C473C8
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.IsCompatibleObject
	|
	|-RVA: 0x2C481C8 Offset: 0x2C441C8 VA: 0x2C481C8
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.IsCompatibleObject
	|
	|-RVA: 0x2C49028 Offset: 0x2C45028 VA: 0x2C49028
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.IsCompatibleObject
	|
	|-RVA: 0x2C49E28 Offset: 0x2C45E28 VA: 0x2C49E28
	|-ReadOnlyCollection<UIMainManager.DropItemData>.IsCompatibleObject
	|
	|-RVA: 0x2C4AC0C Offset: 0x2C46C0C VA: 0x2C4AC0C
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.IsCompatibleObject
	|
	|-RVA: 0x2C4BAC4 Offset: 0x2C47AC4 VA: 0x2C4BAC4
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.IsCompatibleObject
	|
	|-RVA: 0x2C4C8F4 Offset: 0x2C488F4 VA: 0x2C4C8F4
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IsCompatibleObject
	|
	|-RVA: 0x2C4D754 Offset: 0x2C49754 VA: 0x2C4D754
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.IsCompatibleObject
	|
	|-RVA: 0x2C4E5E0 Offset: 0x2C4A5E0 VA: 0x2C4E5E0
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04E8C Offset: 0x2C00E8C VA: 0x2C04E8C
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C05C70 Offset: 0x2C01C70 VA: 0x2C05C70
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C06A54 Offset: 0x2C02A54 VA: 0x2C06A54
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C07838 Offset: 0x2C03838 VA: 0x2C07838
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C0860C Offset: 0x2C0460C VA: 0x2C0860C
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C093E0 Offset: 0x2C053E0 VA: 0x2C093E0
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C0A1C4 Offset: 0x2C061C4 VA: 0x2C0A1C4
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C0AF98 Offset: 0x2C06F98 VA: 0x2C0AF98
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C0BE60 Offset: 0x2C07E60 VA: 0x2C0BE60
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C0CC80 Offset: 0x2C08C80 VA: 0x2C0CC80
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C0DA64 Offset: 0x2C09A64 VA: 0x2C0DA64
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C0E848 Offset: 0x2C0A848 VA: 0x2C0E848
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C0F62C Offset: 0x2C0B62C VA: 0x2C0F62C
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C10410 Offset: 0x2C0C410 VA: 0x2C10410
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C1127C Offset: 0x2C0D27C VA: 0x2C1127C
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C12084 Offset: 0x2C0E084 VA: 0x2C12084
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C12E68 Offset: 0x2C0EE68 VA: 0x2C12E68
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C13C3C Offset: 0x2C0FC3C VA: 0x2C13C3C
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C14A20 Offset: 0x2C10A20 VA: 0x2C14A20
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C157F4 Offset: 0x2C117F4 VA: 0x2C157F4
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C166AC Offset: 0x2C126AC VA: 0x2C166AC
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C174CC Offset: 0x2C134CC VA: 0x2C174CC
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C182A8 Offset: 0x2C142A8 VA: 0x2C182A8
	|-ReadOnlyCollection<bool>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C1907C Offset: 0x2C1507C VA: 0x2C1907C
	|-ReadOnlyCollection<byte>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C19E50 Offset: 0x2C15E50 VA: 0x2C19E50
	|-ReadOnlyCollection<ByteEnum>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C1AD9C Offset: 0x2C16D9C VA: 0x2C1AD9C
	|-ReadOnlyCollection<char>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C1BBB8 Offset: 0x2C17BB8 VA: 0x2C1BBB8
	|-ReadOnlyCollection<Color>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C1C9A4 Offset: 0x2C189A4 VA: 0x2C1C9A4
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C1D858 Offset: 0x2C19858 VA: 0x2C1D858
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C1E688 Offset: 0x2C1A688 VA: 0x2C1E688
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C1F45C Offset: 0x2C1B45C VA: 0x2C1F45C
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C20240 Offset: 0x2C1C240 VA: 0x2C20240
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C21064 Offset: 0x2C1D064 VA: 0x2C21064
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C21E38 Offset: 0x2C1DE38 VA: 0x2C21E38
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C22C0C Offset: 0x2C1EC0C VA: 0x2C22C0C
	|-ReadOnlyCollection<double>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C239F0 Offset: 0x2C1F9F0 VA: 0x2C239F0
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C247C4 Offset: 0x2C207C4 VA: 0x2C247C4
	|-ReadOnlyCollection<short>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C25598 Offset: 0x2C21598 VA: 0x2C25598
	|-ReadOnlyCollection<Int16Enum>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C2636C Offset: 0x2C2236C VA: 0x2C2636C
	|-ReadOnlyCollection<int>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C27140 Offset: 0x2C23140 VA: 0x2C27140
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C27F14 Offset: 0x2C23F14 VA: 0x2C27F14
	|-ReadOnlyCollection<long>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C28CF8 Offset: 0x2C24CF8 VA: 0x2C28CF8
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C29BB0 Offset: 0x2C25BB0 VA: 0x2C29BB0
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C2A9E0 Offset: 0x2C269E0 VA: 0x2C2A9E0
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C2B898 Offset: 0x2C27898 VA: 0x2C2B898
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C2C79C Offset: 0x2C2879C VA: 0x2C2C79C
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C2D584 Offset: 0x2C29584 VA: 0x2C2D584
	|-ReadOnlyCollection<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C2E454 Offset: 0x2C2A454 VA: 0x2C2E454
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C2F360 Offset: 0x2C2B360 VA: 0x2C2F360
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C30190 Offset: 0x2C2C190 VA: 0x2C30190
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C30F8C Offset: 0x2C2CF8C VA: 0x2C30F8C
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C31D68 Offset: 0x2C2DD68 VA: 0x2C31D68
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C32B3C Offset: 0x2C2EB3C VA: 0x2C32B3C
	|-ReadOnlyCollection<float>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C33910 Offset: 0x2C2F910 VA: 0x2C33910
	|-ReadOnlyCollection<SkillIdData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C346E4 Offset: 0x2C306E4 VA: 0x2C346E4
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C354B8 Offset: 0x2C314B8 VA: 0x2C354B8
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C3628C Offset: 0x2C3228C VA: 0x2C3628C
	|-ReadOnlyCollection<uint>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C37060 Offset: 0x2C33060 VA: 0x2C37060
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C37E44 Offset: 0x2C33E44 VA: 0x2C37E44
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C38C50 Offset: 0x2C34C50 VA: 0x2C38C50
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C39A3C Offset: 0x2C35A3C VA: 0x2C39A3C
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C3AC2C Offset: 0x2C36C2C VA: 0x2C3AC2C
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C3BAE0 Offset: 0x2C37AE0 VA: 0x2C3BAE0
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C3C998 Offset: 0x2C38998 VA: 0x2C3C998
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C3D8A4 Offset: 0x2C398A4 VA: 0x2C3D8A4
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C3E6C4 Offset: 0x2C3A6C4 VA: 0x2C3E6C4
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C3F4C0 Offset: 0x2C3B4C0 VA: 0x2C3F4C0
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C402C4 Offset: 0x2C3C2C4 VA: 0x2C402C4
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C410B0 Offset: 0x2C3D0B0 VA: 0x2C410B0
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C41F10 Offset: 0x2C3DF10 VA: 0x2C41F10
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C42D20 Offset: 0x2C3ED20 VA: 0x2C42D20
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C43B04 Offset: 0x2C3FB04 VA: 0x2C43B04
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C448E8 Offset: 0x2C408E8 VA: 0x2C448E8
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C456BC Offset: 0x2C416BC VA: 0x2C456BC
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C46570 Offset: 0x2C42570 VA: 0x2C46570
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C4741C Offset: 0x2C4341C VA: 0x2C4741C
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C4821C Offset: 0x2C4421C VA: 0x2C4821C
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C4907C Offset: 0x2C4507C VA: 0x2C4907C
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C49E7C Offset: 0x2C45E7C VA: 0x2C49E7C
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C4AC60 Offset: 0x2C46C60 VA: 0x2C4AC60
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C4BB18 Offset: 0x2C47B18 VA: 0x2C4BB18
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C4C948 Offset: 0x2C48948 VA: 0x2C4C948
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C4D7A8 Offset: 0x2C497A8 VA: 0x2C4D7A8
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C4E634 Offset: 0x2C4A634 VA: 0x2C4E634
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04F30 Offset: 0x2C00F30 VA: 0x2C04F30
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C05D14 Offset: 0x2C01D14 VA: 0x2C05D14
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C06AF8 Offset: 0x2C02AF8 VA: 0x2C06AF8
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C078DC Offset: 0x2C038DC VA: 0x2C078DC
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C086B0 Offset: 0x2C046B0 VA: 0x2C086B0
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C09484 Offset: 0x2C05484 VA: 0x2C09484
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C0A268 Offset: 0x2C06268 VA: 0x2C0A268
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C0B03C Offset: 0x2C0703C VA: 0x2C0B03C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C0BF2C Offset: 0x2C07F2C VA: 0x2C0BF2C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C0CD24 Offset: 0x2C08D24 VA: 0x2C0CD24
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C0DB08 Offset: 0x2C09B08 VA: 0x2C0DB08
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C0E8EC Offset: 0x2C0A8EC VA: 0x2C0E8EC
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C0F6D0 Offset: 0x2C0B6D0 VA: 0x2C0F6D0
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C104B4 Offset: 0x2C0C4B4 VA: 0x2C104B4
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C11334 Offset: 0x2C0D334 VA: 0x2C11334
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C12128 Offset: 0x2C0E128 VA: 0x2C12128
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C12F0C Offset: 0x2C0EF0C VA: 0x2C12F0C
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C13CE0 Offset: 0x2C0FCE0 VA: 0x2C13CE0
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C14AC4 Offset: 0x2C10AC4 VA: 0x2C14AC4
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C15898 Offset: 0x2C11898 VA: 0x2C15898
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C16778 Offset: 0x2C12778 VA: 0x2C16778
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C17570 Offset: 0x2C13570 VA: 0x2C17570
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C1834C Offset: 0x2C1434C VA: 0x2C1834C
	|-ReadOnlyCollection<bool>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C19120 Offset: 0x2C15120 VA: 0x2C19120
	|-ReadOnlyCollection<byte>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C19EF4 Offset: 0x2C15EF4 VA: 0x2C19EF4
	|-ReadOnlyCollection<ByteEnum>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C1AE40 Offset: 0x2C16E40 VA: 0x2C1AE40
	|-ReadOnlyCollection<char>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C1BC60 Offset: 0x2C17C60 VA: 0x2C1BC60
	|-ReadOnlyCollection<Color>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C1CA48 Offset: 0x2C18A48 VA: 0x2C1CA48
	|-ReadOnlyCollection<Color32>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C1D924 Offset: 0x2C19924 VA: 0x2C1D924
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C1E72C Offset: 0x2C1A72C VA: 0x2C1E72C
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C1F500 Offset: 0x2C1B500 VA: 0x2C1F500
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C202E4 Offset: 0x2C1C2E4 VA: 0x2C202E4
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C21108 Offset: 0x2C1D108 VA: 0x2C21108
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C21EDC Offset: 0x2C1DEDC VA: 0x2C21EDC
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C22CB0 Offset: 0x2C1ECB0 VA: 0x2C22CB0
	|-ReadOnlyCollection<double>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C23A94 Offset: 0x2C1FA94 VA: 0x2C23A94
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C24868 Offset: 0x2C20868 VA: 0x2C24868
	|-ReadOnlyCollection<short>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C2563C Offset: 0x2C2163C VA: 0x2C2563C
	|-ReadOnlyCollection<Int16Enum>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C26410 Offset: 0x2C22410 VA: 0x2C26410
	|-ReadOnlyCollection<int>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C271E4 Offset: 0x2C231E4 VA: 0x2C271E4
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C27FB8 Offset: 0x2C23FB8 VA: 0x2C27FB8
	|-ReadOnlyCollection<long>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C28D9C Offset: 0x2C24D9C VA: 0x2C28D9C
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C29C7C Offset: 0x2C25C7C VA: 0x2C29C7C
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C2AA84 Offset: 0x2C26A84 VA: 0x2C2AA84
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C2B964 Offset: 0x2C27964 VA: 0x2C2B964
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C2C868 Offset: 0x2C28868 VA: 0x2C2C868
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C2D630 Offset: 0x2C29630 VA: 0x2C2D630
	|-ReadOnlyCollection<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C2E520 Offset: 0x2C2A520 VA: 0x2C2E520
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C2F42C Offset: 0x2C2B42C VA: 0x2C2F42C
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C30234 Offset: 0x2C2C234 VA: 0x2C30234
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C31034 Offset: 0x2C2D034 VA: 0x2C31034
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C31E0C Offset: 0x2C2DE0C VA: 0x2C31E0C
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C32BE0 Offset: 0x2C2EBE0 VA: 0x2C32BE0
	|-ReadOnlyCollection<float>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C339B4 Offset: 0x2C2F9B4 VA: 0x2C339B4
	|-ReadOnlyCollection<SkillIdData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C34788 Offset: 0x2C30788 VA: 0x2C34788
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C3555C Offset: 0x2C3155C VA: 0x2C3555C
	|-ReadOnlyCollection<ushort>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C36330 Offset: 0x2C32330 VA: 0x2C36330
	|-ReadOnlyCollection<uint>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C37104 Offset: 0x2C33104 VA: 0x2C37104
	|-ReadOnlyCollection<ulong>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C37EE8 Offset: 0x2C33EE8 VA: 0x2C37EE8
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C38CF8 Offset: 0x2C34CF8 VA: 0x2C38CF8
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C39AE0 Offset: 0x2C35AE0 VA: 0x2C39AE0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C3AD3C Offset: 0x2C36D3C VA: 0x2C3AD3C
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C3BB84 Offset: 0x2C37B84 VA: 0x2C3BB84
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C3CA64 Offset: 0x2C38A64 VA: 0x2C3CA64
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C3D970 Offset: 0x2C39970 VA: 0x2C3D970
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C3E768 Offset: 0x2C3A768 VA: 0x2C3E768
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C3F568 Offset: 0x2C3B568 VA: 0x2C3F568
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C4036C Offset: 0x2C3C36C VA: 0x2C4036C
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C41154 Offset: 0x2C3D154 VA: 0x2C41154
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C41FCC Offset: 0x2C3DFCC VA: 0x2C41FCC
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C42DC4 Offset: 0x2C3EDC4 VA: 0x2C42DC4
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C43BA8 Offset: 0x2C3FBA8 VA: 0x2C43BA8
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C4498C Offset: 0x2C4098C VA: 0x2C4498C
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C45760 Offset: 0x2C41760 VA: 0x2C45760
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C4663C Offset: 0x2C4263C VA: 0x2C4663C
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C474D8 Offset: 0x2C434D8 VA: 0x2C474D8
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C482C0 Offset: 0x2C442C0 VA: 0x2C482C0
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C49138 Offset: 0x2C45138 VA: 0x2C49138
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C49F20 Offset: 0x2C45F20 VA: 0x2C49F20
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C4AD04 Offset: 0x2C46D04 VA: 0x2C4AD04
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C4BBE4 Offset: 0x2C47BE4 VA: 0x2C4BBE4
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C4C9EC Offset: 0x2C489EC VA: 0x2C4C9EC
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C4D864 Offset: 0x2C49864 VA: 0x2C4D864
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C4E6F0 Offset: 0x2C4A6F0 VA: 0x2C4E6F0
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04FD4 Offset: 0x2C00FD4 VA: 0x2C04FD4
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C05DB8 Offset: 0x2C01DB8 VA: 0x2C05DB8
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C06B9C Offset: 0x2C02B9C VA: 0x2C06B9C
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C07980 Offset: 0x2C03980 VA: 0x2C07980
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C08754 Offset: 0x2C04754 VA: 0x2C08754
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C09528 Offset: 0x2C05528 VA: 0x2C09528
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C0A30C Offset: 0x2C0630C VA: 0x2C0A30C
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C0B0E0 Offset: 0x2C070E0 VA: 0x2C0B0E0
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C0BFF4 Offset: 0x2C07FF4 VA: 0x2C0BFF4
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C0CDC8 Offset: 0x2C08DC8 VA: 0x2C0CDC8
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C0DBAC Offset: 0x2C09BAC VA: 0x2C0DBAC
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C0E990 Offset: 0x2C0A990 VA: 0x2C0E990
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C0F774 Offset: 0x2C0B774 VA: 0x2C0F774
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C10558 Offset: 0x2C0C558 VA: 0x2C10558
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C113E8 Offset: 0x2C0D3E8 VA: 0x2C113E8
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C121CC Offset: 0x2C0E1CC VA: 0x2C121CC
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C12FB0 Offset: 0x2C0EFB0 VA: 0x2C12FB0
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C13D84 Offset: 0x2C0FD84 VA: 0x2C13D84
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C14B68 Offset: 0x2C10B68 VA: 0x2C14B68
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C1593C Offset: 0x2C1193C VA: 0x2C1593C
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C16840 Offset: 0x2C12840 VA: 0x2C16840
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C17614 Offset: 0x2C13614 VA: 0x2C17614
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C183F0 Offset: 0x2C143F0 VA: 0x2C183F0
	|-ReadOnlyCollection<bool>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C191C4 Offset: 0x2C151C4 VA: 0x2C191C4
	|-ReadOnlyCollection<byte>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C19F98 Offset: 0x2C15F98 VA: 0x2C19F98
	|-ReadOnlyCollection<ByteEnum>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C1AEE4 Offset: 0x2C16EE4 VA: 0x2C1AEE4
	|-ReadOnlyCollection<char>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C1BD08 Offset: 0x2C17D08 VA: 0x2C1BD08
	|-ReadOnlyCollection<Color>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C1CAEC Offset: 0x2C18AEC VA: 0x2C1CAEC
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C1D9EC Offset: 0x2C199EC VA: 0x2C1D9EC
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C1E7D0 Offset: 0x2C1A7D0 VA: 0x2C1E7D0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C1F5A4 Offset: 0x2C1B5A4 VA: 0x2C1F5A4
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C20388 Offset: 0x2C1C388 VA: 0x2C20388
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C211AC Offset: 0x2C1D1AC VA: 0x2C211AC
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C21F80 Offset: 0x2C1DF80 VA: 0x2C21F80
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C22D54 Offset: 0x2C1ED54 VA: 0x2C22D54
	|-ReadOnlyCollection<double>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C23B38 Offset: 0x2C1FB38 VA: 0x2C23B38
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C2490C Offset: 0x2C2090C VA: 0x2C2490C
	|-ReadOnlyCollection<short>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C256E0 Offset: 0x2C216E0 VA: 0x2C256E0
	|-ReadOnlyCollection<Int16Enum>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C264B4 Offset: 0x2C224B4 VA: 0x2C264B4
	|-ReadOnlyCollection<int>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C27288 Offset: 0x2C23288 VA: 0x2C27288
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C2805C Offset: 0x2C2405C VA: 0x2C2805C
	|-ReadOnlyCollection<long>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C28E40 Offset: 0x2C24E40 VA: 0x2C28E40
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C29D44 Offset: 0x2C25D44 VA: 0x2C29D44
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C2AB28 Offset: 0x2C26B28 VA: 0x2C2AB28
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C2BA2C Offset: 0x2C27A2C VA: 0x2C2BA2C
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C2C930 Offset: 0x2C28930 VA: 0x2C2C930
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C2D6DC Offset: 0x2C296DC VA: 0x2C2D6DC
	|-ReadOnlyCollection<object>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C2E5E8 Offset: 0x2C2A5E8 VA: 0x2C2E5E8
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C2F4F4 Offset: 0x2C2B4F4 VA: 0x2C2F4F4
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C302D8 Offset: 0x2C2C2D8 VA: 0x2C302D8
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C310DC Offset: 0x2C2D0DC VA: 0x2C310DC
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C31EB0 Offset: 0x2C2DEB0 VA: 0x2C31EB0
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C32C84 Offset: 0x2C2EC84 VA: 0x2C32C84
	|-ReadOnlyCollection<float>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C33A58 Offset: 0x2C2FA58 VA: 0x2C33A58
	|-ReadOnlyCollection<SkillIdData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C3482C Offset: 0x2C3082C VA: 0x2C3482C
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C35600 Offset: 0x2C31600 VA: 0x2C35600
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C363D4 Offset: 0x2C323D4 VA: 0x2C363D4
	|-ReadOnlyCollection<uint>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C371A8 Offset: 0x2C331A8 VA: 0x2C371A8
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C37F8C Offset: 0x2C33F8C VA: 0x2C37F8C
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C38DA0 Offset: 0x2C34DA0 VA: 0x2C38DA0
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C39B84 Offset: 0x2C35B84 VA: 0x2C39B84
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C3AE44 Offset: 0x2C36E44 VA: 0x2C3AE44
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C3BC28 Offset: 0x2C37C28 VA: 0x2C3BC28
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C3CB2C Offset: 0x2C38B2C VA: 0x2C3CB2C
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C3DA38 Offset: 0x2C39A38 VA: 0x2C3DA38
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C3E80C Offset: 0x2C3A80C VA: 0x2C3E80C
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C3F610 Offset: 0x2C3B610 VA: 0x2C3F610
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C40414 Offset: 0x2C3C414 VA: 0x2C40414
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C411F8 Offset: 0x2C3D1F8 VA: 0x2C411F8
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C42084 Offset: 0x2C3E084 VA: 0x2C42084
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C42E68 Offset: 0x2C3EE68 VA: 0x2C42E68
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C43C4C Offset: 0x2C3FC4C VA: 0x2C43C4C
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C44A30 Offset: 0x2C40A30 VA: 0x2C44A30
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C45804 Offset: 0x2C41804 VA: 0x2C45804
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C46704 Offset: 0x2C42704 VA: 0x2C46704
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C47590 Offset: 0x2C43590 VA: 0x2C47590
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C48364 Offset: 0x2C44364 VA: 0x2C48364
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C491F0 Offset: 0x2C451F0 VA: 0x2C491F0
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C49FC4 Offset: 0x2C45FC4 VA: 0x2C49FC4
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C4ADA8 Offset: 0x2C46DA8 VA: 0x2C4ADA8
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C4BCAC Offset: 0x2C47CAC VA: 0x2C4BCAC
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C4CA90 Offset: 0x2C48A90 VA: 0x2C4CA90
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C4D91C Offset: 0x2C4991C VA: 0x2C4D91C
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C4E7A8 Offset: 0x2C4A7A8 VA: 0x2C4E7A8
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04FE0 Offset: 0x2C00FE0 VA: 0x2C04FE0
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C05DC4 Offset: 0x2C01DC4 VA: 0x2C05DC4
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C06BA8 Offset: 0x2C02BA8 VA: 0x2C06BA8
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C0798C Offset: 0x2C0398C VA: 0x2C0798C
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C08760 Offset: 0x2C04760 VA: 0x2C08760
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C09534 Offset: 0x2C05534 VA: 0x2C09534
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C0A318 Offset: 0x2C06318 VA: 0x2C0A318
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C0B0EC Offset: 0x2C070EC VA: 0x2C0B0EC
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C0C000 Offset: 0x2C08000 VA: 0x2C0C000
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C0CDD4 Offset: 0x2C08DD4 VA: 0x2C0CDD4
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C0DBB8 Offset: 0x2C09BB8 VA: 0x2C0DBB8
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C0E99C Offset: 0x2C0A99C VA: 0x2C0E99C
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C0F780 Offset: 0x2C0B780 VA: 0x2C0F780
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C10564 Offset: 0x2C0C564 VA: 0x2C10564
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C113F4 Offset: 0x2C0D3F4 VA: 0x2C113F4
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C121D8 Offset: 0x2C0E1D8 VA: 0x2C121D8
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C12FBC Offset: 0x2C0EFBC VA: 0x2C12FBC
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C13D90 Offset: 0x2C0FD90 VA: 0x2C13D90
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C14B74 Offset: 0x2C10B74 VA: 0x2C14B74
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C15948 Offset: 0x2C11948 VA: 0x2C15948
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C1684C Offset: 0x2C1284C VA: 0x2C1684C
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C17620 Offset: 0x2C13620 VA: 0x2C17620
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C183FC Offset: 0x2C143FC VA: 0x2C183FC
	|-ReadOnlyCollection<bool>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C191D0 Offset: 0x2C151D0 VA: 0x2C191D0
	|-ReadOnlyCollection<byte>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C19FA4 Offset: 0x2C15FA4 VA: 0x2C19FA4
	|-ReadOnlyCollection<ByteEnum>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C1AEF0 Offset: 0x2C16EF0 VA: 0x2C1AEF0
	|-ReadOnlyCollection<char>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C1BD14 Offset: 0x2C17D14 VA: 0x2C1BD14
	|-ReadOnlyCollection<Color>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C1CAF8 Offset: 0x2C18AF8 VA: 0x2C1CAF8
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C1D9F8 Offset: 0x2C199F8 VA: 0x2C1D9F8
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C1E7DC Offset: 0x2C1A7DC VA: 0x2C1E7DC
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C1F5B0 Offset: 0x2C1B5B0 VA: 0x2C1F5B0
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C20394 Offset: 0x2C1C394 VA: 0x2C20394
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C211B8 Offset: 0x2C1D1B8 VA: 0x2C211B8
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C21F8C Offset: 0x2C1DF8C VA: 0x2C21F8C
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C22D60 Offset: 0x2C1ED60 VA: 0x2C22D60
	|-ReadOnlyCollection<double>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C23B44 Offset: 0x2C1FB44 VA: 0x2C23B44
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C24918 Offset: 0x2C20918 VA: 0x2C24918
	|-ReadOnlyCollection<short>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C256EC Offset: 0x2C216EC VA: 0x2C256EC
	|-ReadOnlyCollection<Int16Enum>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C264C0 Offset: 0x2C224C0 VA: 0x2C264C0
	|-ReadOnlyCollection<int>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C27294 Offset: 0x2C23294 VA: 0x2C27294
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C28068 Offset: 0x2C24068 VA: 0x2C28068
	|-ReadOnlyCollection<long>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C28E4C Offset: 0x2C24E4C VA: 0x2C28E4C
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C29D50 Offset: 0x2C25D50 VA: 0x2C29D50
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C2AB34 Offset: 0x2C26B34 VA: 0x2C2AB34
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C2BA38 Offset: 0x2C27A38 VA: 0x2C2BA38
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C2C93C Offset: 0x2C2893C VA: 0x2C2C93C
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C2D6E8 Offset: 0x2C296E8 VA: 0x2C2D6E8
	|-ReadOnlyCollection<object>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C2E5F4 Offset: 0x2C2A5F4 VA: 0x2C2E5F4
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C2F500 Offset: 0x2C2B500 VA: 0x2C2F500
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C302E4 Offset: 0x2C2C2E4 VA: 0x2C302E4
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C310E8 Offset: 0x2C2D0E8 VA: 0x2C310E8
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C31EBC Offset: 0x2C2DEBC VA: 0x2C31EBC
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C32C90 Offset: 0x2C2EC90 VA: 0x2C32C90
	|-ReadOnlyCollection<float>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C33A64 Offset: 0x2C2FA64 VA: 0x2C33A64
	|-ReadOnlyCollection<SkillIdData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C34838 Offset: 0x2C30838 VA: 0x2C34838
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C3560C Offset: 0x2C3160C VA: 0x2C3560C
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C363E0 Offset: 0x2C323E0 VA: 0x2C363E0
	|-ReadOnlyCollection<uint>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C371B4 Offset: 0x2C331B4 VA: 0x2C371B4
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C37F98 Offset: 0x2C33F98 VA: 0x2C37F98
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C38DAC Offset: 0x2C34DAC VA: 0x2C38DAC
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C39B90 Offset: 0x2C35B90 VA: 0x2C39B90
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C3AE50 Offset: 0x2C36E50 VA: 0x2C3AE50
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C3BC34 Offset: 0x2C37C34 VA: 0x2C3BC34
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C3CB38 Offset: 0x2C38B38 VA: 0x2C3CB38
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C3DA44 Offset: 0x2C39A44 VA: 0x2C3DA44
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C3E818 Offset: 0x2C3A818 VA: 0x2C3E818
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C3F61C Offset: 0x2C3B61C VA: 0x2C3F61C
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C40420 Offset: 0x2C3C420 VA: 0x2C40420
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C41204 Offset: 0x2C3D204 VA: 0x2C41204
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C42090 Offset: 0x2C3E090 VA: 0x2C42090
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C42E74 Offset: 0x2C3EE74 VA: 0x2C42E74
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C43C58 Offset: 0x2C3FC58 VA: 0x2C43C58
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C44A3C Offset: 0x2C40A3C VA: 0x2C44A3C
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C45810 Offset: 0x2C41810 VA: 0x2C45810
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C46710 Offset: 0x2C42710 VA: 0x2C46710
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C4759C Offset: 0x2C4359C VA: 0x2C4759C
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C48370 Offset: 0x2C44370 VA: 0x2C48370
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C491FC Offset: 0x2C451FC VA: 0x2C491FC
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C49FD0 Offset: 0x2C45FD0 VA: 0x2C49FD0
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C4ADB4 Offset: 0x2C46DB4 VA: 0x2C4ADB4
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C4BCB8 Offset: 0x2C47CB8 VA: 0x2C4BCB8
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C4CA9C Offset: 0x2C48A9C VA: 0x2C4CA9C
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C4D928 Offset: 0x2C49928 VA: 0x2C4D928
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C4E7B4 Offset: 0x2C4A7B4 VA: 0x2C4E7B4
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C04FEC Offset: 0x2C00FEC VA: 0x2C04FEC
	|-ReadOnlyCollection<KeyValuePair<ArchetypeUid, object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C05DD0 Offset: 0x2C01DD0 VA: 0x2C05DD0
	|-ReadOnlyCollection<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C06BB4 Offset: 0x2C02BB4 VA: 0x2C06BB4
	|-ReadOnlyCollection<KeyValuePair<byte, byte>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C07998 Offset: 0x2C03998 VA: 0x2C07998
	|-ReadOnlyCollection<KeyValuePair<byte, object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C0876C Offset: 0x2C0476C VA: 0x2C0876C
	|-ReadOnlyCollection<KeyValuePair<int, short>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C09540 Offset: 0x2C05540 VA: 0x2C09540
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C0A324 Offset: 0x2C06324 VA: 0x2C0A324
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C0B0F8 Offset: 0x2C070F8 VA: 0x2C0B0F8
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, byte>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C0C00C Offset: 0x2C0800C VA: 0x2C0C00C
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C0CDE0 Offset: 0x2C08DE0 VA: 0x2C0CDE0
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, int>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C0DBC4 Offset: 0x2C09BC4 VA: 0x2C0DBC4
	|-ReadOnlyCollection<KeyValuePair<Int32Enum, object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C0E9A8 Offset: 0x2C0A9A8 VA: 0x2C0E9A8
	|-ReadOnlyCollection<KeyValuePair<object, int>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C0F78C Offset: 0x2C0B78C VA: 0x2C0F78C
	|-ReadOnlyCollection<KeyValuePair<object, float>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C10570 Offset: 0x2C0C570 VA: 0x2C10570
	|-ReadOnlyCollection<KeyValuePair<float, object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C11400 Offset: 0x2C0D400 VA: 0x2C11400
	|-ReadOnlyCollection<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C121E4 Offset: 0x2C0E1E4 VA: 0x2C121E4
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C12FC8 Offset: 0x2C0EFC8 VA: 0x2C12FC8
	|-ReadOnlyCollection<ValueTuple<short, short>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C13D9C Offset: 0x2C0FD9C VA: 0x2C13D9C
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C14B80 Offset: 0x2C10B80 VA: 0x2C14B80
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C15954 Offset: 0x2C11954 VA: 0x2C15954
	|-ReadOnlyCollection<ValueTuple<Int32Enum, float>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C16858 Offset: 0x2C12858 VA: 0x2C16858
	|-ReadOnlyCollection<ValueTuple<Vector3, Vector3>>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C1762C Offset: 0x2C1362C VA: 0x2C1762C
	|-ReadOnlyCollection<ArchetypeUid>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C18408 Offset: 0x2C14408 VA: 0x2C18408
	|-ReadOnlyCollection<bool>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C191DC Offset: 0x2C151DC VA: 0x2C191DC
	|-ReadOnlyCollection<byte>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C19FB0 Offset: 0x2C15FB0 VA: 0x2C19FB0
	|-ReadOnlyCollection<ByteEnum>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C1AEFC Offset: 0x2C16EFC VA: 0x2C1AEFC
	|-ReadOnlyCollection<char>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C1BD20 Offset: 0x2C17D20 VA: 0x2C1BD20
	|-ReadOnlyCollection<Color>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C1CB04 Offset: 0x2C18B04 VA: 0x2C1CB04
	|-ReadOnlyCollection<Color32>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C1DA04 Offset: 0x2C19A04 VA: 0x2C1DA04
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C1E7E8 Offset: 0x2C1A7E8 VA: 0x2C1E7E8
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C1F5BC Offset: 0x2C1B5BC VA: 0x2C1F5BC
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C203A0 Offset: 0x2C1C3A0 VA: 0x2C203A0
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C211C4 Offset: 0x2C1D1C4 VA: 0x2C211C4
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C21F98 Offset: 0x2C1DF98 VA: 0x2C21F98
	|-ReadOnlyCollection<DefencePoint2>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C22D6C Offset: 0x2C1ED6C VA: 0x2C22D6C
	|-ReadOnlyCollection<double>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C23B50 Offset: 0x2C1FB50 VA: 0x2C23B50
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C24924 Offset: 0x2C20924 VA: 0x2C24924
	|-ReadOnlyCollection<short>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C256F8 Offset: 0x2C216F8 VA: 0x2C256F8
	|-ReadOnlyCollection<Int16Enum>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C264CC Offset: 0x2C224CC VA: 0x2C264CC
	|-ReadOnlyCollection<int>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C272A0 Offset: 0x2C232A0 VA: 0x2C272A0
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C28074 Offset: 0x2C24074 VA: 0x2C28074
	|-ReadOnlyCollection<long>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C28E58 Offset: 0x2C24E58 VA: 0x2C28E58
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C29D5C Offset: 0x2C25D5C VA: 0x2C29D5C
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C2AB40 Offset: 0x2C26B40 VA: 0x2C2AB40
	|-ReadOnlyCollection<MaterialSearchData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C2BA44 Offset: 0x2C27A44 VA: 0x2C2BA44
	|-ReadOnlyCollection<MobActionTargetData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C2C948 Offset: 0x2C28948 VA: 0x2C2C948
	|-ReadOnlyCollection<MobIconLabelData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C2D6F4 Offset: 0x2C296F4 VA: 0x2C2D6F4
	|-ReadOnlyCollection<object>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C2E600 Offset: 0x2C2A600 VA: 0x2C2E600
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C2F50C Offset: 0x2C2B50C VA: 0x2C2F50C
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C302F0 Offset: 0x2C2C2F0 VA: 0x2C302F0
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C310F4 Offset: 0x2C2D0F4 VA: 0x2C310F4
	|-ReadOnlyCollection<ReinforceCristaData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C31EC8 Offset: 0x2C2DEC8 VA: 0x2C31EC8
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C32C9C Offset: 0x2C2EC9C VA: 0x2C32C9C
	|-ReadOnlyCollection<float>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C33A70 Offset: 0x2C2FA70 VA: 0x2C33A70
	|-ReadOnlyCollection<SkillIdData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C34844 Offset: 0x2C30844 VA: 0x2C34844
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C35618 Offset: 0x2C31618 VA: 0x2C35618
	|-ReadOnlyCollection<ushort>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C363EC Offset: 0x2C323EC VA: 0x2C363EC
	|-ReadOnlyCollection<uint>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C371C0 Offset: 0x2C331C0 VA: 0x2C371C0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C37FA4 Offset: 0x2C33FA4 VA: 0x2C37FA4
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C38DB8 Offset: 0x2C34DB8 VA: 0x2C38DB8
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C39B9C Offset: 0x2C35B9C VA: 0x2C39B9C
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C3AE5C Offset: 0x2C36E5C VA: 0x2C3AE5C
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C3BC40 Offset: 0x2C37C40 VA: 0x2C3BC40
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C3CB44 Offset: 0x2C38B44 VA: 0x2C3CB44
	|-ReadOnlyCollection<BoneClip.MotionKeyFrame>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C3DA50 Offset: 0x2C39A50 VA: 0x2C3DA50
	|-ReadOnlyCollection<HouseRecipeManager.RecipeData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C3E824 Offset: 0x2C3A824 VA: 0x2C3E824
	|-ReadOnlyCollection<KadarElexioBuf.SkillIdData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C3F628 Offset: 0x2C3B628 VA: 0x2C3F628
	|-ReadOnlyCollection<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C4042C Offset: 0x2C3C42C VA: 0x2C4042C
	|-ReadOnlyCollection<MissionTextManagerData.PickUpFieldData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C41210 Offset: 0x2C3D210 VA: 0x2C41210
	|-ReadOnlyCollection<MobaRoomData.MobaAbilityMasterData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C4209C Offset: 0x2C3E09C VA: 0x2C4209C
	|-ReadOnlyCollection<NewWaveRoomData.Spotlight>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C42E80 Offset: 0x2C3EE80 VA: 0x2C42E80
	|-ReadOnlyCollection<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C43C64 Offset: 0x2C3FC64 VA: 0x2C43C64
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C44A48 Offset: 0x2C40A48 VA: 0x2C44A48
	|-ReadOnlyCollection<SocialAchievementData.LinkData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C4581C Offset: 0x2C4181C VA: 0x2C4581C
	|-ReadOnlyCollection<TrophyManager.TrophyData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C4671C Offset: 0x2C4271C VA: 0x2C4671C
	|-ReadOnlyCollection<UIEventMenuButton.MessageButtonData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C475A8 Offset: 0x2C435A8 VA: 0x2C475A8
	|-ReadOnlyCollection<UIFieldMapPanel.PopData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C4837C Offset: 0x2C4437C VA: 0x2C4837C
	|-ReadOnlyCollection<UIHouseAddressManager.Town>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C49208 Offset: 0x2C45208 VA: 0x2C49208
	|-ReadOnlyCollection<UIInfoWindow.LabelPosition>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C49FDC Offset: 0x2C45FDC VA: 0x2C49FDC
	|-ReadOnlyCollection<UIMainManager.DropItemData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C4ADC0 Offset: 0x2C46DC0 VA: 0x2C4ADC0
	|-ReadOnlyCollection<UIScenarioOrderPanel.MissionData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C4BCC4 Offset: 0x2C47CC4 VA: 0x2C4BCC4
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C4CAA8 Offset: 0x2C48AA8 VA: 0x2C4CAA8
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C4D934 Offset: 0x2C49934 VA: 0x2C4D934
	|-ReadOnlyCollection<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x2C4E7C0 Offset: 0x2C4A7C0 VA: 0x2C4E7C0
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.RemoveAt
	*/
}
