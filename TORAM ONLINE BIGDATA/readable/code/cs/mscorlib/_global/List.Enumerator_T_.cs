// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
public struct List.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 10948
{
	// Fields
	private List<T> _list; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2969F54 Offset: 0x2965F54 VA: 0x2969F54
	|-List.Enumerator<KeyValuePair<ArchetypeUid, object>>..ctor
	|
	|-RVA: 0x296A158 Offset: 0x2966158 VA: 0x296A158
	|-List.Enumerator<KeyValuePair<byte, BlackKnightCristaProperty>>..ctor
	|
	|-RVA: 0x296A33C Offset: 0x296633C VA: 0x296A33C
	|-List.Enumerator<KeyValuePair<byte, byte>>..ctor
	|
	|-RVA: 0x296A524 Offset: 0x2966524 VA: 0x296A524
	|-List.Enumerator<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x296BBD0 Offset: 0x2967BD0 VA: 0x296BBD0
	|-List.Enumerator<KeyValuePair<int, short>>..ctor
	|
	|-RVA: 0x296BDB8 Offset: 0x2967DB8 VA: 0x296BDB8
	|-List.Enumerator<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x296BFA0 Offset: 0x2967FA0 VA: 0x296BFA0
	|-List.Enumerator<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x296C1A4 Offset: 0x29681A4 VA: 0x296C1A4
	|-List.Enumerator<KeyValuePair<Int32Enum, byte>>..ctor
	|
	|-RVA: 0x296C38C Offset: 0x296838C VA: 0x296C38C
	|-List.Enumerator<KeyValuePair<Int32Enum, EnhanceProperties2>>..ctor
	|
	|-RVA: 0x296C5BC Offset: 0x29685BC VA: 0x296C5BC
	|-List.Enumerator<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x296C7A4 Offset: 0x29687A4 VA: 0x296C7A4
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x296C9A8 Offset: 0x29689A8 VA: 0x296C9A8
	|-List.Enumerator<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x296CBAC Offset: 0x2968BAC VA: 0x296CBAC
	|-List.Enumerator<KeyValuePair<object, float>>..ctor
	|
	|-RVA: 0x296CDB0 Offset: 0x2968DB0 VA: 0x296CDB0
	|-List.Enumerator<KeyValuePair<float, object>>..ctor
	|
	|-RVA: 0x296CFB4 Offset: 0x2968FB4 VA: 0x296CFB4
	|-List.Enumerator<Nullable<UIMobPropertyLabel.IconValue>>..ctor
	|
	|-RVA: 0x296D1C4 Offset: 0x29691C4 VA: 0x296D1C4
	|-List.Enumerator<StructMultiKey<object, object>>..ctor
	|
	|-RVA: 0x296D3C8 Offset: 0x29693C8 VA: 0x296D3C8
	|-List.Enumerator<ValueTuple<short, short>>..ctor
	|
	|-RVA: 0x296D5AC Offset: 0x29695AC VA: 0x296D5AC
	|-List.Enumerator<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x296D794 Offset: 0x2969794 VA: 0x296D794
	|-List.Enumerator<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x296D998 Offset: 0x2969998 VA: 0x296D998
	|-List.Enumerator<ValueTuple<Int32Enum, float>>..ctor
	|
	|-RVA: 0x296DED8 Offset: 0x2969ED8 VA: 0x296DED8
	|-List.Enumerator<ValueTuple<Vector3, Vector3>>..ctor
	|
	|-RVA: 0x296E46C Offset: 0x296A46C VA: 0x296E46C
	|-List.Enumerator<ArchetypeUid>..ctor
	|
	|-RVA: 0x296E954 Offset: 0x296A954 VA: 0x296E954
	|-List.Enumerator<bool>..ctor
	|
	|-RVA: 0x296EF8C Offset: 0x296AF8C VA: 0x296EF8C
	|-List.Enumerator<byte>..ctor
	|
	|-RVA: 0x296F36C Offset: 0x296B36C VA: 0x296F36C
	|-List.Enumerator<ByteEnum>..ctor
	|
	|-RVA: 0x296F554 Offset: 0x296B554 VA: 0x296F554
	|-List.Enumerator<char>..ctor
	|
	|-RVA: 0x296F73C Offset: 0x296B73C VA: 0x296F73C
	|-List.Enumerator<Color>..ctor
	|
	|-RVA: 0x296F930 Offset: 0x296B930 VA: 0x296F930
	|-List.Enumerator<Color32>..ctor
	|
	|-RVA: 0x29700B0 Offset: 0x296C0B0 VA: 0x29700B0
	|-List.Enumerator<DateTime>..ctor
	|
	|-RVA: 0x2970298 Offset: 0x296C298 VA: 0x2970298
	|-List.Enumerator<DateTimeOffset>..ctor
	|
	|-RVA: 0x297048C Offset: 0x296C48C VA: 0x297048C
	|-List.Enumerator<Decimal>..ctor
	|
	|-RVA: 0x29706A0 Offset: 0x296C6A0 VA: 0x29706A0
	|-List.Enumerator<DefencePoint2>..ctor
	|
	|-RVA: 0x2970B3C Offset: 0x296CB3C VA: 0x2970B3C
	|-List.Enumerator<double>..ctor
	|
	|-RVA: 0x2970D24 Offset: 0x296CD24 VA: 0x2970D24
	|-List.Enumerator<EventSummary>..ctor
	|
	|-RVA: 0x2970F28 Offset: 0x296CF28 VA: 0x2970F28
	|-List.Enumerator<short>..ctor
	|
	|-RVA: 0x2971110 Offset: 0x296D110 VA: 0x2971110
	|-List.Enumerator<Int16Enum>..ctor
	|
	|-RVA: 0x2971560 Offset: 0x296D560 VA: 0x2971560
	|-List.Enumerator<int>..ctor
	|
	|-RVA: 0x2971BE4 Offset: 0x296DBE4 VA: 0x2971BE4
	|-List.Enumerator<Int32Enum>..ctor
	|
	|-RVA: 0x2971DC8 Offset: 0x296DDC8 VA: 0x2971DC8
	|-List.Enumerator<long>..ctor
	|
	|-RVA: 0x2971FB0 Offset: 0x296DFB0 VA: 0x2971FB0
	|-List.Enumerator<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x29721B4 Offset: 0x296E1B4 VA: 0x29721B4
	|-List.Enumerator<JsonPosition>..ctor
	|
	|-RVA: 0x29726CC Offset: 0x296E6CC VA: 0x29726CC
	|-List.Enumerator<MaterialSearchData>..ctor
	|
	|-RVA: 0x2972BA0 Offset: 0x296EBA0 VA: 0x2972BA0
	|-List.Enumerator<MobActionTargetData>..ctor
	|
	|-RVA: 0x2972DBC Offset: 0x296EDBC VA: 0x2972DBC
	|-List.Enumerator<MobIconLabelData>..ctor
	|
	|-RVA: 0x2973854 Offset: 0x296F854 VA: 0x2973854
	|-List.Enumerator<object>..ctor
	|
	|-RVA: 0x2974510 Offset: 0x2970510 VA: 0x2974510
	|-List.Enumerator<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x2974748 Offset: 0x2970748 VA: 0x2974748
	|-List.Enumerator<PlayerLoopSystemInternal>..ctor
	|
	|-RVA: 0x2974BA0 Offset: 0x2970BA0 VA: 0x2974BA0
	|-List.Enumerator<RangePositionInfo>..ctor
	|
	|-RVA: 0x2974DA4 Offset: 0x2970DA4 VA: 0x2974DA4
	|-List.Enumerator<ReinforceCristaData>..ctor
	|
	|-RVA: 0x2974FBC Offset: 0x2970FBC VA: 0x2974FBC
	|-List.Enumerator<sbyte>..ctor
	|
	|-RVA: 0x297539C Offset: 0x297139C VA: 0x297539C
	|-List.Enumerator<float>..ctor
	|
	|-RVA: 0x2975580 Offset: 0x2971580 VA: 0x2975580
	|-List.Enumerator<SkillIdData>..ctor
	|
	|-RVA: 0x2975768 Offset: 0x2971768 VA: 0x2975768
	|-List.Enumerator<TimeSpan>..ctor
	|
	|-RVA: 0x2975950 Offset: 0x2971950 VA: 0x2975950
	|-List.Enumerator<ushort>..ctor
	|
	|-RVA: 0x2975B38 Offset: 0x2971B38 VA: 0x2975B38
	|-List.Enumerator<uint>..ctor
	|
	|-RVA: 0x2975D1C Offset: 0x2971D1C VA: 0x2975D1C
	|-List.Enumerator<ulong>..ctor
	|
	|-RVA: 0x2975F04 Offset: 0x2971F04 VA: 0x2975F04
	|-List.Enumerator<Vector2>..ctor
	|
	|-RVA: 0x29760EC Offset: 0x29720EC VA: 0x29760EC
	|-List.Enumerator<Vector3>..ctor
	|
	|-RVA: 0x2976550 Offset: 0x2972550 VA: 0x2976550
	|-List.Enumerator<X509ChainStatus>..ctor
	|
	|-RVA: 0x2978D00 Offset: 0x2974D00 VA: 0x2978D00
	|-List.Enumerator<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x297CD34 Offset: 0x2978D34 VA: 0x297CD34
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x297CF38 Offset: 0x2978F38 VA: 0x297CF38
	|-List.Enumerator<BoneClip.MotionKeyFrame>..ctor
	|
	|-RVA: 0x297D164 Offset: 0x2979164 VA: 0x297D164
	|-List.Enumerator<HouseRecipeManager.RecipeData>..ctor
	|
	|-RVA: 0x297D39C Offset: 0x297939C VA: 0x297D39C
	|-List.Enumerator<KadarElexioBuf.SkillIdData>..ctor
	|
	|-RVA: 0x297D584 Offset: 0x2979584 VA: 0x297D584
	|-List.Enumerator<MissionTextManagerData.CheckIKeywordtemData>..ctor
	|
	|-RVA: 0x297D79C Offset: 0x297979C VA: 0x297D79C
	|-List.Enumerator<MissionTextManagerData.PickUpFieldData>..ctor
	|
	|-RVA: 0x297D9B4 Offset: 0x29799B4 VA: 0x297D9B4
	|-List.Enumerator<MobaRoomData.MobaAbilityMasterData>..ctor
	|
	|-RVA: 0x297DBA8 Offset: 0x2979BA8 VA: 0x297DBA8
	|-List.Enumerator<NewWaveRoomData.Spotlight>..ctor
	|
	|-RVA: 0x297DDB8 Offset: 0x2979DB8 VA: 0x297DDB8
	|-List.Enumerator<NguiDynamicFontController.ApplyTextureInfo>..ctor
	|
	|-RVA: 0x297DFBC Offset: 0x2979FBC VA: 0x297DFBC
	|-List.Enumerator<RegexCharClass.SingleRange>..ctor
	|
	|-RVA: 0x297F11C Offset: 0x297B11C VA: 0x297F11C
	|-List.Enumerator<SocialAchievementData.LinkData>..ctor
	|
	|-RVA: 0x297F320 Offset: 0x297B320 VA: 0x297F320
	|-List.Enumerator<TrophyManager.TrophyData>..ctor
	|
	|-RVA: 0x297F508 Offset: 0x297B508 VA: 0x297F508
	|-List.Enumerator<UIEventMenuButton.MessageButtonData>..ctor
	|
	|-RVA: 0x297F740 Offset: 0x297B740 VA: 0x297F740
	|-List.Enumerator<UIFieldMapPanel.PopData>..ctor
	|
	|-RVA: 0x297F950 Offset: 0x297B950 VA: 0x297F950
	|-List.Enumerator<UIHouseAddressManager.Town>..ctor
	|
	|-RVA: 0x297FB38 Offset: 0x297BB38 VA: 0x297FB38
	|-List.Enumerator<UIInfoWindow.LabelPosition>..ctor
	|
	|-RVA: 0x297FD48 Offset: 0x297BD48 VA: 0x297FD48
	|-List.Enumerator<UIMainManager.DropItemData>..ctor
	|
	|-RVA: 0x297FF30 Offset: 0x297BF30 VA: 0x297FF30
	|-List.Enumerator<UIScenarioOrderPanel.MissionData>..ctor
	|
	|-RVA: 0x2980134 Offset: 0x297C134 VA: 0x2980134
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x2980360 Offset: 0x297C360 VA: 0x2980360
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0x298085C Offset: 0x297C85C VA: 0x298085C
	|-List.Enumerator<BounceParabolaAttackPattern.TargetData.BoundLineData>..ctor
	|
	|-RVA: 0x2980A5C Offset: 0x297CA5C VA: 0x2980A5C
	|-List.Enumerator<InstructionList.DebugView.InstructionView>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2969F90 Offset: 0x2965F90 VA: 0x2969F90
	|-List.Enumerator<KeyValuePair<ArchetypeUid, object>>.Dispose
	|
	|-RVA: 0x296A190 Offset: 0x2966190 VA: 0x296A190
	|-List.Enumerator<KeyValuePair<byte, BlackKnightCristaProperty>>.Dispose
	|
	|-RVA: 0x296A378 Offset: 0x2966378 VA: 0x296A378
	|-List.Enumerator<KeyValuePair<byte, byte>>.Dispose
	|
	|-RVA: 0x296A560 Offset: 0x2966560 VA: 0x296A560
	|-List.Enumerator<KeyValuePair<byte, object>>.Dispose
	|
	|-RVA: 0x296BC0C Offset: 0x2967C0C VA: 0x296BC0C
	|-List.Enumerator<KeyValuePair<int, short>>.Dispose
	|
	|-RVA: 0x296BDF4 Offset: 0x2967DF4 VA: 0x296BDF4
	|-List.Enumerator<KeyValuePair<int, int>>.Dispose
	|
	|-RVA: 0x296BFDC Offset: 0x2967FDC VA: 0x296BFDC
	|-List.Enumerator<KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x296C1E0 Offset: 0x29681E0 VA: 0x296C1E0
	|-List.Enumerator<KeyValuePair<Int32Enum, byte>>.Dispose
	|
	|-RVA: 0x296C3D0 Offset: 0x29683D0 VA: 0x296C3D0
	|-List.Enumerator<KeyValuePair<Int32Enum, EnhanceProperties2>>.Dispose
	|
	|-RVA: 0x296C5F8 Offset: 0x29685F8 VA: 0x296C5F8
	|-List.Enumerator<KeyValuePair<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x296C7E0 Offset: 0x29687E0 VA: 0x296C7E0
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.Dispose
	|
	|-RVA: 0x296C9E4 Offset: 0x29689E4 VA: 0x296C9E4
	|-List.Enumerator<KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x296CBE8 Offset: 0x2968BE8 VA: 0x296CBE8
	|-List.Enumerator<KeyValuePair<object, float>>.Dispose
	|
	|-RVA: 0x296CDEC Offset: 0x2968DEC VA: 0x296CDEC
	|-List.Enumerator<KeyValuePair<float, object>>.Dispose
	|
	|-RVA: 0x296CFF4 Offset: 0x2968FF4 VA: 0x296CFF4
	|-List.Enumerator<Nullable<UIMobPropertyLabel.IconValue>>.Dispose
	|
	|-RVA: 0x296D200 Offset: 0x2969200 VA: 0x296D200
	|-List.Enumerator<StructMultiKey<object, object>>.Dispose
	|
	|-RVA: 0x296D400 Offset: 0x2969400 VA: 0x296D400
	|-List.Enumerator<ValueTuple<short, short>>.Dispose
	|
	|-RVA: 0x296D5E8 Offset: 0x29695E8 VA: 0x296D5E8
	|-List.Enumerator<ValueTuple<int, int>>.Dispose
	|
	|-RVA: 0x296D7D0 Offset: 0x29697D0 VA: 0x296D7D0
	|-List.Enumerator<ValueTuple<int, object>>.Dispose
	|
	|-RVA: 0x296D9D4 Offset: 0x29699D4 VA: 0x296D9D4
	|-List.Enumerator<ValueTuple<Int32Enum, float>>.Dispose
	|
	|-RVA: 0x296DF18 Offset: 0x2969F18 VA: 0x296DF18
	|-List.Enumerator<ValueTuple<Vector3, Vector3>>.Dispose
	|
	|-RVA: 0x296E4A8 Offset: 0x296A4A8 VA: 0x296E4A8
	|-List.Enumerator<ArchetypeUid>.Dispose
	|
	|-RVA: 0x296E990 Offset: 0x296A990 VA: 0x296E990
	|-List.Enumerator<bool>.Dispose
	|
	|-RVA: 0x296EFC8 Offset: 0x296AFC8 VA: 0x296EFC8
	|-List.Enumerator<byte>.Dispose
	|
	|-RVA: 0x296F3A8 Offset: 0x296B3A8 VA: 0x296F3A8
	|-List.Enumerator<ByteEnum>.Dispose
	|
	|-RVA: 0x296F590 Offset: 0x296B590 VA: 0x296F590
	|-List.Enumerator<char>.Dispose
	|
	|-RVA: 0x296F778 Offset: 0x296B778 VA: 0x296F778
	|-List.Enumerator<Color>.Dispose
	|
	|-RVA: 0x296F968 Offset: 0x296B968 VA: 0x296F968
	|-List.Enumerator<Color32>.Dispose
	|
	|-RVA: 0x29700EC Offset: 0x296C0EC VA: 0x29700EC
	|-List.Enumerator<DateTime>.Dispose
	|
	|-RVA: 0x29702D4 Offset: 0x296C2D4 VA: 0x29702D4
	|-List.Enumerator<DateTimeOffset>.Dispose
	|
	|-RVA: 0x29704C8 Offset: 0x296C4C8 VA: 0x29704C8
	|-List.Enumerator<Decimal>.Dispose
	|
	|-RVA: 0x29706DC Offset: 0x296C6DC VA: 0x29706DC
	|-List.Enumerator<DefencePoint2>.Dispose
	|
	|-RVA: 0x2970B78 Offset: 0x296CB78 VA: 0x2970B78
	|-List.Enumerator<double>.Dispose
	|
	|-RVA: 0x2970D60 Offset: 0x296CD60 VA: 0x2970D60
	|-List.Enumerator<EventSummary>.Dispose
	|
	|-RVA: 0x2970F64 Offset: 0x296CF64 VA: 0x2970F64
	|-List.Enumerator<short>.Dispose
	|
	|-RVA: 0x297114C Offset: 0x296D14C VA: 0x297114C
	|-List.Enumerator<Int16Enum>.Dispose
	|
	|-RVA: 0x2971598 Offset: 0x296D598 VA: 0x2971598
	|-List.Enumerator<int>.Dispose
	|
	|-RVA: 0x2971C1C Offset: 0x296DC1C VA: 0x2971C1C
	|-List.Enumerator<Int32Enum>.Dispose
	|
	|-RVA: 0x2971E04 Offset: 0x296DE04 VA: 0x2971E04
	|-List.Enumerator<long>.Dispose
	|
	|-RVA: 0x2971FEC Offset: 0x296DFEC VA: 0x2971FEC
	|-List.Enumerator<InterpretedFrameInfo>.Dispose
	|
	|-RVA: 0x29721F4 Offset: 0x296E1F4 VA: 0x29721F4
	|-List.Enumerator<JsonPosition>.Dispose
	|
	|-RVA: 0x2972708 Offset: 0x296E708 VA: 0x2972708
	|-List.Enumerator<MaterialSearchData>.Dispose
	|
	|-RVA: 0x2972BE0 Offset: 0x296EBE0 VA: 0x2972BE0
	|-List.Enumerator<MobActionTargetData>.Dispose
	|
	|-RVA: 0x2972DFC Offset: 0x296EDFC VA: 0x2972DFC
	|-List.Enumerator<MobIconLabelData>.Dispose
	|
	|-RVA: 0x2973890 Offset: 0x296F890 VA: 0x2973890
	|-List.Enumerator<object>.Dispose
	|
	|-RVA: 0x2974554 Offset: 0x2970554 VA: 0x2974554
	|-List.Enumerator<PlayerLoopSystem>.Dispose
	|
	|-RVA: 0x297478C Offset: 0x297078C VA: 0x297478C
	|-List.Enumerator<PlayerLoopSystemInternal>.Dispose
	|
	|-RVA: 0x2974BDC Offset: 0x2970BDC VA: 0x2974BDC
	|-List.Enumerator<RangePositionInfo>.Dispose
	|
	|-RVA: 0x2974DE4 Offset: 0x2970DE4 VA: 0x2974DE4
	|-List.Enumerator<ReinforceCristaData>.Dispose
	|
	|-RVA: 0x2974FF8 Offset: 0x2970FF8 VA: 0x2974FF8
	|-List.Enumerator<sbyte>.Dispose
	|
	|-RVA: 0x29753D4 Offset: 0x29713D4 VA: 0x29753D4
	|-List.Enumerator<float>.Dispose
	|
	|-RVA: 0x29755BC Offset: 0x29715BC VA: 0x29755BC
	|-List.Enumerator<SkillIdData>.Dispose
	|
	|-RVA: 0x29757A4 Offset: 0x29717A4 VA: 0x29757A4
	|-List.Enumerator<TimeSpan>.Dispose
	|
	|-RVA: 0x297598C Offset: 0x297198C VA: 0x297598C
	|-List.Enumerator<ushort>.Dispose
	|
	|-RVA: 0x2975B70 Offset: 0x2971B70 VA: 0x2975B70
	|-List.Enumerator<uint>.Dispose
	|
	|-RVA: 0x2975D58 Offset: 0x2971D58 VA: 0x2975D58
	|-List.Enumerator<ulong>.Dispose
	|
	|-RVA: 0x2975F40 Offset: 0x2971F40 VA: 0x2975F40
	|-List.Enumerator<Vector2>.Dispose
	|
	|-RVA: 0x297612C Offset: 0x297212C VA: 0x297612C
	|-List.Enumerator<Vector3>.Dispose
	|
	|-RVA: 0x297658C Offset: 0x297258C VA: 0x297658C
	|-List.Enumerator<X509ChainStatus>.Dispose
	|
	|-RVA: 0x2978E1C Offset: 0x2974E1C VA: 0x2978E1C
	|-List.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	|
	|-RVA: 0x297CD70 Offset: 0x2978D70 VA: 0x297CD70
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.Dispose
	|
	|-RVA: 0x297CF78 Offset: 0x2978F78 VA: 0x297CF78
	|-List.Enumerator<BoneClip.MotionKeyFrame>.Dispose
	|
	|-RVA: 0x297D1A8 Offset: 0x29791A8 VA: 0x297D1A8
	|-List.Enumerator<HouseRecipeManager.RecipeData>.Dispose
	|
	|-RVA: 0x297D3D8 Offset: 0x29793D8 VA: 0x297D3D8
	|-List.Enumerator<KadarElexioBuf.SkillIdData>.Dispose
	|
	|-RVA: 0x297D5C4 Offset: 0x29795C4 VA: 0x297D5C4
	|-List.Enumerator<MissionTextManagerData.CheckIKeywordtemData>.Dispose
	|
	|-RVA: 0x297D7DC Offset: 0x29797DC VA: 0x297D7DC
	|-List.Enumerator<MissionTextManagerData.PickUpFieldData>.Dispose
	|
	|-RVA: 0x297D9F0 Offset: 0x29799F0 VA: 0x297D9F0
	|-List.Enumerator<MobaRoomData.MobaAbilityMasterData>.Dispose
	|
	|-RVA: 0x297DBE8 Offset: 0x2979BE8 VA: 0x297DBE8
	|-List.Enumerator<NewWaveRoomData.Spotlight>.Dispose
	|
	|-RVA: 0x297DDF4 Offset: 0x2979DF4 VA: 0x297DDF4
	|-List.Enumerator<NguiDynamicFontController.ApplyTextureInfo>.Dispose
	|
	|-RVA: 0x297DFF4 Offset: 0x2979FF4 VA: 0x297DFF4
	|-List.Enumerator<RegexCharClass.SingleRange>.Dispose
	|
	|-RVA: 0x297F158 Offset: 0x297B158 VA: 0x297F158
	|-List.Enumerator<SocialAchievementData.LinkData>.Dispose
	|
	|-RVA: 0x297F35C Offset: 0x297B35C VA: 0x297F35C
	|-List.Enumerator<TrophyManager.TrophyData>.Dispose
	|
	|-RVA: 0x297F54C Offset: 0x297B54C VA: 0x297F54C
	|-List.Enumerator<UIEventMenuButton.MessageButtonData>.Dispose
	|
	|-RVA: 0x297F780 Offset: 0x297B780 VA: 0x297F780
	|-List.Enumerator<UIFieldMapPanel.PopData>.Dispose
	|
	|-RVA: 0x297F98C Offset: 0x297B98C VA: 0x297F98C
	|-List.Enumerator<UIHouseAddressManager.Town>.Dispose
	|
	|-RVA: 0x297FB78 Offset: 0x297BB78 VA: 0x297FB78
	|-List.Enumerator<UIInfoWindow.LabelPosition>.Dispose
	|
	|-RVA: 0x297FD84 Offset: 0x297BD84 VA: 0x297FD84
	|-List.Enumerator<UIMainManager.DropItemData>.Dispose
	|
	|-RVA: 0x297FF6C Offset: 0x297BF6C VA: 0x297FF6C
	|-List.Enumerator<UIScenarioOrderPanel.MissionData>.Dispose
	|
	|-RVA: 0x2980174 Offset: 0x297C174 VA: 0x2980174
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.Dispose
	|
	|-RVA: 0x298039C Offset: 0x297C39C VA: 0x298039C
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Dispose
	|
	|-RVA: 0x298089C Offset: 0x297C89C VA: 0x298089C
	|-List.Enumerator<BounceParabolaAttackPattern.TargetData.BoundLineData>.Dispose
	|
	|-RVA: 0x2980A9C Offset: 0x297CA9C VA: 0x2980A9C
	|-List.Enumerator<InstructionList.DebugView.InstructionView>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2969F94 Offset: 0x2965F94 VA: 0x2969F94
	|-List.Enumerator<KeyValuePair<ArchetypeUid, object>>.MoveNext
	|
	|-RVA: 0x296A194 Offset: 0x2966194 VA: 0x296A194
	|-List.Enumerator<KeyValuePair<byte, BlackKnightCristaProperty>>.MoveNext
	|
	|-RVA: 0x296A37C Offset: 0x296637C VA: 0x296A37C
	|-List.Enumerator<KeyValuePair<byte, byte>>.MoveNext
	|
	|-RVA: 0x296A564 Offset: 0x2966564 VA: 0x296A564
	|-List.Enumerator<KeyValuePair<byte, object>>.MoveNext
	|
	|-RVA: 0x296BC10 Offset: 0x2967C10 VA: 0x296BC10
	|-List.Enumerator<KeyValuePair<int, short>>.MoveNext
	|
	|-RVA: 0x296BDF8 Offset: 0x2967DF8 VA: 0x296BDF8
	|-List.Enumerator<KeyValuePair<int, int>>.MoveNext
	|
	|-RVA: 0x296BFE0 Offset: 0x2967FE0 VA: 0x296BFE0
	|-List.Enumerator<KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x296C1E4 Offset: 0x29681E4 VA: 0x296C1E4
	|-List.Enumerator<KeyValuePair<Int32Enum, byte>>.MoveNext
	|
	|-RVA: 0x296C3D4 Offset: 0x29683D4 VA: 0x296C3D4
	|-List.Enumerator<KeyValuePair<Int32Enum, EnhanceProperties2>>.MoveNext
	|
	|-RVA: 0x296C5FC Offset: 0x29685FC VA: 0x296C5FC
	|-List.Enumerator<KeyValuePair<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x296C7E4 Offset: 0x29687E4 VA: 0x296C7E4
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.MoveNext
	|
	|-RVA: 0x296C9E8 Offset: 0x29689E8 VA: 0x296C9E8
	|-List.Enumerator<KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x296CBEC Offset: 0x2968BEC VA: 0x296CBEC
	|-List.Enumerator<KeyValuePair<object, float>>.MoveNext
	|
	|-RVA: 0x296CDF0 Offset: 0x2968DF0 VA: 0x296CDF0
	|-List.Enumerator<KeyValuePair<float, object>>.MoveNext
	|
	|-RVA: 0x296CFF8 Offset: 0x2968FF8 VA: 0x296CFF8
	|-List.Enumerator<Nullable<UIMobPropertyLabel.IconValue>>.MoveNext
	|
	|-RVA: 0x296D204 Offset: 0x2969204 VA: 0x296D204
	|-List.Enumerator<StructMultiKey<object, object>>.MoveNext
	|
	|-RVA: 0x296D404 Offset: 0x2969404 VA: 0x296D404
	|-List.Enumerator<ValueTuple<short, short>>.MoveNext
	|
	|-RVA: 0x296D5EC Offset: 0x29695EC VA: 0x296D5EC
	|-List.Enumerator<ValueTuple<int, int>>.MoveNext
	|
	|-RVA: 0x296D7D4 Offset: 0x29697D4 VA: 0x296D7D4
	|-List.Enumerator<ValueTuple<int, object>>.MoveNext
	|
	|-RVA: 0x296D9D8 Offset: 0x29699D8 VA: 0x296D9D8
	|-List.Enumerator<ValueTuple<Int32Enum, float>>.MoveNext
	|
	|-RVA: 0x296DF1C Offset: 0x2969F1C VA: 0x296DF1C
	|-List.Enumerator<ValueTuple<Vector3, Vector3>>.MoveNext
	|
	|-RVA: 0x296E4AC Offset: 0x296A4AC VA: 0x296E4AC
	|-List.Enumerator<ArchetypeUid>.MoveNext
	|
	|-RVA: 0x296E994 Offset: 0x296A994 VA: 0x296E994
	|-List.Enumerator<bool>.MoveNext
	|
	|-RVA: 0x296EFCC Offset: 0x296AFCC VA: 0x296EFCC
	|-List.Enumerator<byte>.MoveNext
	|
	|-RVA: 0x296F3AC Offset: 0x296B3AC VA: 0x296F3AC
	|-List.Enumerator<ByteEnum>.MoveNext
	|
	|-RVA: 0x296F594 Offset: 0x296B594 VA: 0x296F594
	|-List.Enumerator<char>.MoveNext
	|
	|-RVA: 0x296F77C Offset: 0x296B77C VA: 0x296F77C
	|-List.Enumerator<Color>.MoveNext
	|
	|-RVA: 0x296F96C Offset: 0x296B96C VA: 0x296F96C
	|-List.Enumerator<Color32>.MoveNext
	|
	|-RVA: 0x29700F0 Offset: 0x296C0F0 VA: 0x29700F0
	|-List.Enumerator<DateTime>.MoveNext
	|
	|-RVA: 0x29702D8 Offset: 0x296C2D8 VA: 0x29702D8
	|-List.Enumerator<DateTimeOffset>.MoveNext
	|
	|-RVA: 0x29704CC Offset: 0x296C4CC VA: 0x29704CC
	|-List.Enumerator<Decimal>.MoveNext
	|
	|-RVA: 0x29706E0 Offset: 0x296C6E0 VA: 0x29706E0
	|-List.Enumerator<DefencePoint2>.MoveNext
	|
	|-RVA: 0x2970B7C Offset: 0x296CB7C VA: 0x2970B7C
	|-List.Enumerator<double>.MoveNext
	|
	|-RVA: 0x2970D64 Offset: 0x296CD64 VA: 0x2970D64
	|-List.Enumerator<EventSummary>.MoveNext
	|
	|-RVA: 0x2970F68 Offset: 0x296CF68 VA: 0x2970F68
	|-List.Enumerator<short>.MoveNext
	|
	|-RVA: 0x2971150 Offset: 0x296D150 VA: 0x2971150
	|-List.Enumerator<Int16Enum>.MoveNext
	|
	|-RVA: 0x297159C Offset: 0x296D59C VA: 0x297159C
	|-List.Enumerator<int>.MoveNext
	|
	|-RVA: 0x2971C20 Offset: 0x296DC20 VA: 0x2971C20
	|-List.Enumerator<Int32Enum>.MoveNext
	|
	|-RVA: 0x2971E08 Offset: 0x296DE08 VA: 0x2971E08
	|-List.Enumerator<long>.MoveNext
	|
	|-RVA: 0x2971FF0 Offset: 0x296DFF0 VA: 0x2971FF0
	|-List.Enumerator<InterpretedFrameInfo>.MoveNext
	|
	|-RVA: 0x29721F8 Offset: 0x296E1F8 VA: 0x29721F8
	|-List.Enumerator<JsonPosition>.MoveNext
	|
	|-RVA: 0x297270C Offset: 0x296E70C VA: 0x297270C
	|-List.Enumerator<MaterialSearchData>.MoveNext
	|
	|-RVA: 0x2972BE4 Offset: 0x296EBE4 VA: 0x2972BE4
	|-List.Enumerator<MobActionTargetData>.MoveNext
	|
	|-RVA: 0x2972E00 Offset: 0x296EE00 VA: 0x2972E00
	|-List.Enumerator<MobIconLabelData>.MoveNext
	|
	|-RVA: 0x2973894 Offset: 0x296F894 VA: 0x2973894
	|-List.Enumerator<object>.MoveNext
	|
	|-RVA: 0x2974558 Offset: 0x2970558 VA: 0x2974558
	|-List.Enumerator<PlayerLoopSystem>.MoveNext
	|
	|-RVA: 0x2974790 Offset: 0x2970790 VA: 0x2974790
	|-List.Enumerator<PlayerLoopSystemInternal>.MoveNext
	|
	|-RVA: 0x2974BE0 Offset: 0x2970BE0 VA: 0x2974BE0
	|-List.Enumerator<RangePositionInfo>.MoveNext
	|
	|-RVA: 0x2974DE8 Offset: 0x2970DE8 VA: 0x2974DE8
	|-List.Enumerator<ReinforceCristaData>.MoveNext
	|
	|-RVA: 0x2974FFC Offset: 0x2970FFC VA: 0x2974FFC
	|-List.Enumerator<sbyte>.MoveNext
	|
	|-RVA: 0x29753D8 Offset: 0x29713D8 VA: 0x29753D8
	|-List.Enumerator<float>.MoveNext
	|
	|-RVA: 0x29755C0 Offset: 0x29715C0 VA: 0x29755C0
	|-List.Enumerator<SkillIdData>.MoveNext
	|
	|-RVA: 0x29757A8 Offset: 0x29717A8 VA: 0x29757A8
	|-List.Enumerator<TimeSpan>.MoveNext
	|
	|-RVA: 0x2975990 Offset: 0x2971990 VA: 0x2975990
	|-List.Enumerator<ushort>.MoveNext
	|
	|-RVA: 0x2975B74 Offset: 0x2971B74 VA: 0x2975B74
	|-List.Enumerator<uint>.MoveNext
	|
	|-RVA: 0x2975D5C Offset: 0x2971D5C VA: 0x2975D5C
	|-List.Enumerator<ulong>.MoveNext
	|
	|-RVA: 0x2975F44 Offset: 0x2971F44 VA: 0x2975F44
	|-List.Enumerator<Vector2>.MoveNext
	|
	|-RVA: 0x2976130 Offset: 0x2972130 VA: 0x2976130
	|-List.Enumerator<Vector3>.MoveNext
	|
	|-RVA: 0x2976590 Offset: 0x2972590 VA: 0x2976590
	|-List.Enumerator<X509ChainStatus>.MoveNext
	|
	|-RVA: 0x2978E20 Offset: 0x2974E20 VA: 0x2978E20
	|-List.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x297CD74 Offset: 0x2978D74 VA: 0x297CD74
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.MoveNext
	|
	|-RVA: 0x297CF7C Offset: 0x2978F7C VA: 0x297CF7C
	|-List.Enumerator<BoneClip.MotionKeyFrame>.MoveNext
	|
	|-RVA: 0x297D1AC Offset: 0x29791AC VA: 0x297D1AC
	|-List.Enumerator<HouseRecipeManager.RecipeData>.MoveNext
	|
	|-RVA: 0x297D3DC Offset: 0x29793DC VA: 0x297D3DC
	|-List.Enumerator<KadarElexioBuf.SkillIdData>.MoveNext
	|
	|-RVA: 0x297D5C8 Offset: 0x29795C8 VA: 0x297D5C8
	|-List.Enumerator<MissionTextManagerData.CheckIKeywordtemData>.MoveNext
	|
	|-RVA: 0x297D7E0 Offset: 0x29797E0 VA: 0x297D7E0
	|-List.Enumerator<MissionTextManagerData.PickUpFieldData>.MoveNext
	|
	|-RVA: 0x297D9F4 Offset: 0x29799F4 VA: 0x297D9F4
	|-List.Enumerator<MobaRoomData.MobaAbilityMasterData>.MoveNext
	|
	|-RVA: 0x297DBEC Offset: 0x2979BEC VA: 0x297DBEC
	|-List.Enumerator<NewWaveRoomData.Spotlight>.MoveNext
	|
	|-RVA: 0x297DDF8 Offset: 0x2979DF8 VA: 0x297DDF8
	|-List.Enumerator<NguiDynamicFontController.ApplyTextureInfo>.MoveNext
	|
	|-RVA: 0x297DFF8 Offset: 0x2979FF8 VA: 0x297DFF8
	|-List.Enumerator<RegexCharClass.SingleRange>.MoveNext
	|
	|-RVA: 0x297F15C Offset: 0x297B15C VA: 0x297F15C
	|-List.Enumerator<SocialAchievementData.LinkData>.MoveNext
	|
	|-RVA: 0x297F360 Offset: 0x297B360 VA: 0x297F360
	|-List.Enumerator<TrophyManager.TrophyData>.MoveNext
	|
	|-RVA: 0x297F550 Offset: 0x297B550 VA: 0x297F550
	|-List.Enumerator<UIEventMenuButton.MessageButtonData>.MoveNext
	|
	|-RVA: 0x297F784 Offset: 0x297B784 VA: 0x297F784
	|-List.Enumerator<UIFieldMapPanel.PopData>.MoveNext
	|
	|-RVA: 0x297F990 Offset: 0x297B990 VA: 0x297F990
	|-List.Enumerator<UIHouseAddressManager.Town>.MoveNext
	|
	|-RVA: 0x297FB7C Offset: 0x297BB7C VA: 0x297FB7C
	|-List.Enumerator<UIInfoWindow.LabelPosition>.MoveNext
	|
	|-RVA: 0x297FD88 Offset: 0x297BD88 VA: 0x297FD88
	|-List.Enumerator<UIMainManager.DropItemData>.MoveNext
	|
	|-RVA: 0x297FF70 Offset: 0x297BF70 VA: 0x297FF70
	|-List.Enumerator<UIScenarioOrderPanel.MissionData>.MoveNext
	|
	|-RVA: 0x2980178 Offset: 0x297C178 VA: 0x2980178
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.MoveNext
	|
	|-RVA: 0x29803A0 Offset: 0x297C3A0 VA: 0x29803A0
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.MoveNext
	|
	|-RVA: 0x29808A0 Offset: 0x297C8A0 VA: 0x29808A0
	|-List.Enumerator<BounceParabolaAttackPattern.TargetData.BoundLineData>.MoveNext
	|
	|-RVA: 0x2980AA0 Offset: 0x297CAA0 VA: 0x2980AA0
	|-List.Enumerator<InstructionList.DebugView.InstructionView>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private bool MoveNextRare() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296A030 Offset: 0x2966030 VA: 0x296A030
	|-List.Enumerator<KeyValuePair<ArchetypeUid, object>>.MoveNextRare
	|
	|-RVA: 0x296A220 Offset: 0x2966220 VA: 0x296A220
	|-List.Enumerator<KeyValuePair<byte, BlackKnightCristaProperty>>.MoveNextRare
	|
	|-RVA: 0x296A408 Offset: 0x2966408 VA: 0x296A408
	|-List.Enumerator<KeyValuePair<byte, byte>>.MoveNextRare
	|
	|-RVA: 0x296A600 Offset: 0x2966600 VA: 0x296A600
	|-List.Enumerator<KeyValuePair<byte, object>>.MoveNextRare
	|
	|-RVA: 0x296BC9C Offset: 0x2967C9C VA: 0x296BC9C
	|-List.Enumerator<KeyValuePair<int, short>>.MoveNextRare
	|
	|-RVA: 0x296BE84 Offset: 0x2967E84 VA: 0x296BE84
	|-List.Enumerator<KeyValuePair<int, int>>.MoveNextRare
	|
	|-RVA: 0x296C07C Offset: 0x296807C VA: 0x296C07C
	|-List.Enumerator<KeyValuePair<int, object>>.MoveNextRare
	|
	|-RVA: 0x296C270 Offset: 0x2968270 VA: 0x296C270
	|-List.Enumerator<KeyValuePair<Int32Enum, byte>>.MoveNextRare
	|
	|-RVA: 0x296C474 Offset: 0x2968474 VA: 0x296C474
	|-List.Enumerator<KeyValuePair<Int32Enum, EnhanceProperties2>>.MoveNextRare
	|
	|-RVA: 0x296C688 Offset: 0x2968688 VA: 0x296C688
	|-List.Enumerator<KeyValuePair<Int32Enum, int>>.MoveNextRare
	|
	|-RVA: 0x296C880 Offset: 0x2968880 VA: 0x296C880
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.MoveNextRare
	|
	|-RVA: 0x296CA84 Offset: 0x2968A84 VA: 0x296CA84
	|-List.Enumerator<KeyValuePair<object, int>>.MoveNextRare
	|
	|-RVA: 0x296CC88 Offset: 0x2968C88 VA: 0x296CC88
	|-List.Enumerator<KeyValuePair<object, float>>.MoveNextRare
	|
	|-RVA: 0x296CE8C Offset: 0x2968E8C VA: 0x296CE8C
	|-List.Enumerator<KeyValuePair<float, object>>.MoveNextRare
	|
	|-RVA: 0x296D094 Offset: 0x2969094 VA: 0x296D094
	|-List.Enumerator<Nullable<UIMobPropertyLabel.IconValue>>.MoveNextRare
	|
	|-RVA: 0x296D2A0 Offset: 0x29692A0 VA: 0x296D2A0
	|-List.Enumerator<StructMultiKey<object, object>>.MoveNextRare
	|
	|-RVA: 0x296D490 Offset: 0x2969490 VA: 0x296D490
	|-List.Enumerator<ValueTuple<short, short>>.MoveNextRare
	|
	|-RVA: 0x296D678 Offset: 0x2969678 VA: 0x296D678
	|-List.Enumerator<ValueTuple<int, int>>.MoveNextRare
	|
	|-RVA: 0x296D870 Offset: 0x2969870 VA: 0x296D870
	|-List.Enumerator<ValueTuple<int, object>>.MoveNextRare
	|
	|-RVA: 0x296DA64 Offset: 0x2969A64 VA: 0x296DA64
	|-List.Enumerator<ValueTuple<Int32Enum, float>>.MoveNextRare
	|
	|-RVA: 0x296DFB4 Offset: 0x2969FB4 VA: 0x296DFB4
	|-List.Enumerator<ValueTuple<Vector3, Vector3>>.MoveNextRare
	|
	|-RVA: 0x296E538 Offset: 0x296A538 VA: 0x296E538
	|-List.Enumerator<ArchetypeUid>.MoveNextRare
	|
	|-RVA: 0x296EA20 Offset: 0x296AA20 VA: 0x296EA20
	|-List.Enumerator<bool>.MoveNextRare
	|
	|-RVA: 0x296F058 Offset: 0x296B058 VA: 0x296F058
	|-List.Enumerator<byte>.MoveNextRare
	|
	|-RVA: 0x296F438 Offset: 0x296B438 VA: 0x296F438
	|-List.Enumerator<ByteEnum>.MoveNextRare
	|
	|-RVA: 0x296F620 Offset: 0x296B620 VA: 0x296F620
	|-List.Enumerator<char>.MoveNextRare
	|
	|-RVA: 0x296F808 Offset: 0x296B808 VA: 0x296F808
	|-List.Enumerator<Color>.MoveNextRare
	|
	|-RVA: 0x296F9F8 Offset: 0x296B9F8 VA: 0x296F9F8
	|-List.Enumerator<Color32>.MoveNextRare
	|
	|-RVA: 0x297017C Offset: 0x296C17C VA: 0x297017C
	|-List.Enumerator<DateTime>.MoveNextRare
	|
	|-RVA: 0x2970364 Offset: 0x296C364 VA: 0x2970364
	|-List.Enumerator<DateTimeOffset>.MoveNextRare
	|
	|-RVA: 0x2970558 Offset: 0x296C558 VA: 0x2970558
	|-List.Enumerator<Decimal>.MoveNextRare
	|
	|-RVA: 0x297076C Offset: 0x296C76C VA: 0x297076C
	|-List.Enumerator<DefencePoint2>.MoveNextRare
	|
	|-RVA: 0x2970C08 Offset: 0x296CC08 VA: 0x2970C08
	|-List.Enumerator<double>.MoveNextRare
	|
	|-RVA: 0x2970E00 Offset: 0x296CE00 VA: 0x2970E00
	|-List.Enumerator<EventSummary>.MoveNextRare
	|
	|-RVA: 0x2970FF4 Offset: 0x296CFF4 VA: 0x2970FF4
	|-List.Enumerator<short>.MoveNextRare
	|
	|-RVA: 0x29711DC Offset: 0x296D1DC VA: 0x29711DC
	|-List.Enumerator<Int16Enum>.MoveNextRare
	|
	|-RVA: 0x2971628 Offset: 0x296D628 VA: 0x2971628
	|-List.Enumerator<int>.MoveNextRare
	|
	|-RVA: 0x2971CAC Offset: 0x296DCAC VA: 0x2971CAC
	|-List.Enumerator<Int32Enum>.MoveNextRare
	|
	|-RVA: 0x2971E94 Offset: 0x296DE94 VA: 0x2971E94
	|-List.Enumerator<long>.MoveNextRare
	|
	|-RVA: 0x297208C Offset: 0x296E08C VA: 0x297208C
	|-List.Enumerator<InterpretedFrameInfo>.MoveNextRare
	|
	|-RVA: 0x29722A0 Offset: 0x296E2A0 VA: 0x29722A0
	|-List.Enumerator<JsonPosition>.MoveNextRare
	|
	|-RVA: 0x2972798 Offset: 0x296E798 VA: 0x2972798
	|-List.Enumerator<MaterialSearchData>.MoveNextRare
	|
	|-RVA: 0x2972C7C Offset: 0x296EC7C VA: 0x2972C7C
	|-List.Enumerator<MobActionTargetData>.MoveNextRare
	|
	|-RVA: 0x2972EA8 Offset: 0x296EEA8 VA: 0x2972EA8
	|-List.Enumerator<MobIconLabelData>.MoveNextRare
	|
	|-RVA: 0x297392C Offset: 0x296F92C VA: 0x297392C
	|-List.Enumerator<object>.MoveNextRare
	|
	|-RVA: 0x2974600 Offset: 0x2970600 VA: 0x2974600
	|-List.Enumerator<PlayerLoopSystem>.MoveNextRare
	|
	|-RVA: 0x2974838 Offset: 0x2970838 VA: 0x2974838
	|-List.Enumerator<PlayerLoopSystemInternal>.MoveNextRare
	|
	|-RVA: 0x2974C7C Offset: 0x2970C7C VA: 0x2974C7C
	|-List.Enumerator<RangePositionInfo>.MoveNextRare
	|
	|-RVA: 0x2974E80 Offset: 0x2970E80 VA: 0x2974E80
	|-List.Enumerator<ReinforceCristaData>.MoveNextRare
	|
	|-RVA: 0x2975088 Offset: 0x2971088 VA: 0x2975088
	|-List.Enumerator<sbyte>.MoveNextRare
	|
	|-RVA: 0x2975464 Offset: 0x2971464 VA: 0x2975464
	|-List.Enumerator<float>.MoveNextRare
	|
	|-RVA: 0x297564C Offset: 0x297164C VA: 0x297564C
	|-List.Enumerator<SkillIdData>.MoveNextRare
	|
	|-RVA: 0x2975834 Offset: 0x2971834 VA: 0x2975834
	|-List.Enumerator<TimeSpan>.MoveNextRare
	|
	|-RVA: 0x2975A1C Offset: 0x2971A1C VA: 0x2975A1C
	|-List.Enumerator<ushort>.MoveNextRare
	|
	|-RVA: 0x2975C00 Offset: 0x2971C00 VA: 0x2975C00
	|-List.Enumerator<uint>.MoveNextRare
	|
	|-RVA: 0x2975DE8 Offset: 0x2971DE8 VA: 0x2975DE8
	|-List.Enumerator<ulong>.MoveNextRare
	|
	|-RVA: 0x2975FD0 Offset: 0x2971FD0 VA: 0x2975FD0
	|-List.Enumerator<Vector2>.MoveNextRare
	|
	|-RVA: 0x29761C8 Offset: 0x29721C8 VA: 0x29761C8
	|-List.Enumerator<Vector3>.MoveNextRare
	|
	|-RVA: 0x297662C Offset: 0x297262C VA: 0x297662C
	|-List.Enumerator<X509ChainStatus>.MoveNextRare
	|
	|-RVA: 0x29790CC Offset: 0x29750CC VA: 0x29790CC
	|-List.Enumerator<__Il2CppFullySharedGenericType>.MoveNextRare
	|
	|-RVA: 0x297CE10 Offset: 0x2978E10 VA: 0x297CE10
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.MoveNextRare
	|
	|-RVA: 0x297D024 Offset: 0x2979024 VA: 0x297D024
	|-List.Enumerator<BoneClip.MotionKeyFrame>.MoveNextRare
	|
	|-RVA: 0x297D254 Offset: 0x2979254 VA: 0x297D254
	|-List.Enumerator<HouseRecipeManager.RecipeData>.MoveNextRare
	|
	|-RVA: 0x297D468 Offset: 0x2979468 VA: 0x297D468
	|-List.Enumerator<KadarElexioBuf.SkillIdData>.MoveNextRare
	|
	|-RVA: 0x297D660 Offset: 0x2979660 VA: 0x297D660
	|-List.Enumerator<MissionTextManagerData.CheckIKeywordtemData>.MoveNextRare
	|
	|-RVA: 0x297D878 Offset: 0x2979878 VA: 0x297D878
	|-List.Enumerator<MissionTextManagerData.PickUpFieldData>.MoveNextRare
	|
	|-RVA: 0x297DA80 Offset: 0x2979A80 VA: 0x297DA80
	|-List.Enumerator<MobaRoomData.MobaAbilityMasterData>.MoveNextRare
	|
	|-RVA: 0x297DC88 Offset: 0x2979C88 VA: 0x297DC88
	|-List.Enumerator<NewWaveRoomData.Spotlight>.MoveNextRare
	|
	|-RVA: 0x297DE94 Offset: 0x2979E94 VA: 0x297DE94
	|-List.Enumerator<NguiDynamicFontController.ApplyTextureInfo>.MoveNextRare
	|
	|-RVA: 0x297E084 Offset: 0x297A084 VA: 0x297E084
	|-List.Enumerator<RegexCharClass.SingleRange>.MoveNextRare
	|
	|-RVA: 0x297F1F8 Offset: 0x297B1F8 VA: 0x297F1F8
	|-List.Enumerator<SocialAchievementData.LinkData>.MoveNextRare
	|
	|-RVA: 0x297F3EC Offset: 0x297B3EC VA: 0x297F3EC
	|-List.Enumerator<TrophyManager.TrophyData>.MoveNextRare
	|
	|-RVA: 0x297F5F8 Offset: 0x297B5F8 VA: 0x297F5F8
	|-List.Enumerator<UIEventMenuButton.MessageButtonData>.MoveNextRare
	|
	|-RVA: 0x297F820 Offset: 0x297B820 VA: 0x297F820
	|-List.Enumerator<UIFieldMapPanel.PopData>.MoveNextRare
	|
	|-RVA: 0x297FA1C Offset: 0x297BA1C VA: 0x297FA1C
	|-List.Enumerator<UIHouseAddressManager.Town>.MoveNextRare
	|
	|-RVA: 0x297FC18 Offset: 0x297BC18 VA: 0x297FC18
	|-List.Enumerator<UIInfoWindow.LabelPosition>.MoveNextRare
	|
	|-RVA: 0x297FE14 Offset: 0x297BE14 VA: 0x297FE14
	|-List.Enumerator<UIMainManager.DropItemData>.MoveNextRare
	|
	|-RVA: 0x298000C Offset: 0x297C00C VA: 0x298000C
	|-List.Enumerator<UIScenarioOrderPanel.MissionData>.MoveNextRare
	|
	|-RVA: 0x2980220 Offset: 0x297C220 VA: 0x2980220
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.MoveNextRare
	|
	|-RVA: 0x298043C Offset: 0x297C43C VA: 0x298043C
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.MoveNextRare
	|
	|-RVA: 0x298092C Offset: 0x297C92C VA: 0x298092C
	|-List.Enumerator<BounceParabolaAttackPattern.TargetData.BoundLineData>.MoveNextRare
	|
	|-RVA: 0x2980B3C Offset: 0x297CB3C VA: 0x2980B3C
	|-List.Enumerator<InstructionList.DebugView.InstructionView>.MoveNextRare
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296A080 Offset: 0x2966080 VA: 0x296A080
	|-List.Enumerator<KeyValuePair<ArchetypeUid, object>>.get_Current
	|
	|-RVA: 0x296A270 Offset: 0x2966270 VA: 0x296A270
	|-List.Enumerator<KeyValuePair<byte, BlackKnightCristaProperty>>.get_Current
	|
	|-RVA: 0x296A458 Offset: 0x2966458 VA: 0x296A458
	|-List.Enumerator<KeyValuePair<byte, byte>>.get_Current
	|
	|-RVA: 0x296A650 Offset: 0x2966650 VA: 0x296A650
	|-List.Enumerator<KeyValuePair<byte, object>>.get_Current
	|
	|-RVA: 0x296BCEC Offset: 0x2967CEC VA: 0x296BCEC
	|-List.Enumerator<KeyValuePair<int, short>>.get_Current
	|
	|-RVA: 0x296BED4 Offset: 0x2967ED4 VA: 0x296BED4
	|-List.Enumerator<KeyValuePair<int, int>>.get_Current
	|
	|-RVA: 0x296C0CC Offset: 0x29680CC VA: 0x296C0CC
	|-List.Enumerator<KeyValuePair<int, object>>.get_Current
	|
	|-RVA: 0x296C2C0 Offset: 0x29682C0 VA: 0x296C2C0
	|-List.Enumerator<KeyValuePair<Int32Enum, byte>>.get_Current
	|
	|-RVA: 0x296C4CC Offset: 0x29684CC VA: 0x296C4CC
	|-List.Enumerator<KeyValuePair<Int32Enum, EnhanceProperties2>>.get_Current
	|
	|-RVA: 0x296C6D8 Offset: 0x29686D8 VA: 0x296C6D8
	|-List.Enumerator<KeyValuePair<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x296C8D0 Offset: 0x29688D0 VA: 0x296C8D0
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.get_Current
	|
	|-RVA: 0x296CAD4 Offset: 0x2968AD4 VA: 0x296CAD4
	|-List.Enumerator<KeyValuePair<object, int>>.get_Current
	|
	|-RVA: 0x296CCD8 Offset: 0x2968CD8 VA: 0x296CCD8
	|-List.Enumerator<KeyValuePair<object, float>>.get_Current
	|
	|-RVA: 0x296CEDC Offset: 0x2968EDC VA: 0x296CEDC
	|-List.Enumerator<KeyValuePair<float, object>>.get_Current
	|
	|-RVA: 0x296D0E8 Offset: 0x29690E8 VA: 0x296D0E8
	|-List.Enumerator<Nullable<UIMobPropertyLabel.IconValue>>.get_Current
	|
	|-RVA: 0x296D2F0 Offset: 0x29692F0 VA: 0x296D2F0
	|-List.Enumerator<StructMultiKey<object, object>>.get_Current
	|
	|-RVA: 0x296D4E0 Offset: 0x29694E0 VA: 0x296D4E0
	|-List.Enumerator<ValueTuple<short, short>>.get_Current
	|
	|-RVA: 0x296D6C8 Offset: 0x29696C8 VA: 0x296D6C8
	|-List.Enumerator<ValueTuple<int, int>>.get_Current
	|
	|-RVA: 0x296D8C0 Offset: 0x29698C0 VA: 0x296D8C0
	|-List.Enumerator<ValueTuple<int, object>>.get_Current
	|
	|-RVA: 0x296DAB4 Offset: 0x2969AB4 VA: 0x296DAB4
	|-List.Enumerator<ValueTuple<Int32Enum, float>>.get_Current
	|
	|-RVA: 0x296E008 Offset: 0x296A008 VA: 0x296E008
	|-List.Enumerator<ValueTuple<Vector3, Vector3>>.get_Current
	|
	|-RVA: 0x296E588 Offset: 0x296A588 VA: 0x296E588
	|-List.Enumerator<ArchetypeUid>.get_Current
	|
	|-RVA: 0x296EA70 Offset: 0x296AA70 VA: 0x296EA70
	|-List.Enumerator<bool>.get_Current
	|
	|-RVA: 0x296F0A8 Offset: 0x296B0A8 VA: 0x296F0A8
	|-List.Enumerator<byte>.get_Current
	|
	|-RVA: 0x296F488 Offset: 0x296B488 VA: 0x296F488
	|-List.Enumerator<ByteEnum>.get_Current
	|
	|-RVA: 0x296F670 Offset: 0x296B670 VA: 0x296F670
	|-List.Enumerator<char>.get_Current
	|
	|-RVA: 0x296F858 Offset: 0x296B858 VA: 0x296F858
	|-List.Enumerator<Color>.get_Current
	|
	|-RVA: 0x296FA48 Offset: 0x296BA48 VA: 0x296FA48
	|-List.Enumerator<Color32>.get_Current
	|
	|-RVA: 0x29701CC Offset: 0x296C1CC VA: 0x29701CC
	|-List.Enumerator<DateTime>.get_Current
	|
	|-RVA: 0x29703B4 Offset: 0x296C3B4 VA: 0x29703B4
	|-List.Enumerator<DateTimeOffset>.get_Current
	|
	|-RVA: 0x29705A8 Offset: 0x296C5A8 VA: 0x29705A8
	|-List.Enumerator<Decimal>.get_Current
	|
	|-RVA: 0x29707BC Offset: 0x296C7BC VA: 0x29707BC
	|-List.Enumerator<DefencePoint2>.get_Current
	|
	|-RVA: 0x2970C58 Offset: 0x296CC58 VA: 0x2970C58
	|-List.Enumerator<double>.get_Current
	|
	|-RVA: 0x2970E50 Offset: 0x296CE50 VA: 0x2970E50
	|-List.Enumerator<EventSummary>.get_Current
	|
	|-RVA: 0x2971044 Offset: 0x296D044 VA: 0x2971044
	|-List.Enumerator<short>.get_Current
	|
	|-RVA: 0x297122C Offset: 0x296D22C VA: 0x297122C
	|-List.Enumerator<Int16Enum>.get_Current
	|
	|-RVA: 0x2971678 Offset: 0x296D678 VA: 0x2971678
	|-List.Enumerator<int>.get_Current
	|
	|-RVA: 0x2971CFC Offset: 0x296DCFC VA: 0x2971CFC
	|-List.Enumerator<Int32Enum>.get_Current
	|
	|-RVA: 0x2971EE4 Offset: 0x296DEE4 VA: 0x2971EE4
	|-List.Enumerator<long>.get_Current
	|
	|-RVA: 0x29720DC Offset: 0x296E0DC VA: 0x29720DC
	|-List.Enumerator<InterpretedFrameInfo>.get_Current
	|
	|-RVA: 0x29722F4 Offset: 0x296E2F4 VA: 0x29722F4
	|-List.Enumerator<JsonPosition>.get_Current
	|
	|-RVA: 0x29727E8 Offset: 0x296E7E8 VA: 0x29727E8
	|-List.Enumerator<MaterialSearchData>.get_Current
	|
	|-RVA: 0x2972CD0 Offset: 0x296ECD0 VA: 0x2972CD0
	|-List.Enumerator<MobActionTargetData>.get_Current
	|
	|-RVA: 0x2972EFC Offset: 0x296EEFC VA: 0x2972EFC
	|-List.Enumerator<MobIconLabelData>.get_Current
	|
	|-RVA: 0x297397C Offset: 0x296F97C VA: 0x297397C
	|-List.Enumerator<object>.get_Current
	|
	|-RVA: 0x2974658 Offset: 0x2970658 VA: 0x2974658
	|-List.Enumerator<PlayerLoopSystem>.get_Current
	|
	|-RVA: 0x2974890 Offset: 0x2970890 VA: 0x2974890
	|-List.Enumerator<PlayerLoopSystemInternal>.get_Current
	|
	|-RVA: 0x2974CCC Offset: 0x2970CCC VA: 0x2974CCC
	|-List.Enumerator<RangePositionInfo>.get_Current
	|
	|-RVA: 0x2974ED4 Offset: 0x2970ED4 VA: 0x2974ED4
	|-List.Enumerator<ReinforceCristaData>.get_Current
	|
	|-RVA: 0x29750D8 Offset: 0x29710D8 VA: 0x29750D8
	|-List.Enumerator<sbyte>.get_Current
	|
	|-RVA: 0x29754B4 Offset: 0x29714B4 VA: 0x29754B4
	|-List.Enumerator<float>.get_Current
	|
	|-RVA: 0x297569C Offset: 0x297169C VA: 0x297569C
	|-List.Enumerator<SkillIdData>.get_Current
	|
	|-RVA: 0x2975884 Offset: 0x2971884 VA: 0x2975884
	|-List.Enumerator<TimeSpan>.get_Current
	|
	|-RVA: 0x2975A6C Offset: 0x2971A6C VA: 0x2975A6C
	|-List.Enumerator<ushort>.get_Current
	|
	|-RVA: 0x2975C50 Offset: 0x2971C50 VA: 0x2975C50
	|-List.Enumerator<uint>.get_Current
	|
	|-RVA: 0x2975E38 Offset: 0x2971E38 VA: 0x2975E38
	|-List.Enumerator<ulong>.get_Current
	|
	|-RVA: 0x2976020 Offset: 0x2972020 VA: 0x2976020
	|-List.Enumerator<Vector2>.get_Current
	|
	|-RVA: 0x297621C Offset: 0x297221C VA: 0x297621C
	|-List.Enumerator<Vector3>.get_Current
	|
	|-RVA: 0x297667C Offset: 0x297267C VA: 0x297667C
	|-List.Enumerator<X509ChainStatus>.get_Current
	|
	|-RVA: 0x2979230 Offset: 0x2975230 VA: 0x2979230
	|-List.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	|
	|-RVA: 0x297CE60 Offset: 0x2978E60 VA: 0x297CE60
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.get_Current
	|
	|-RVA: 0x297D078 Offset: 0x2979078 VA: 0x297D078
	|-List.Enumerator<BoneClip.MotionKeyFrame>.get_Current
	|
	|-RVA: 0x297D2AC Offset: 0x29792AC VA: 0x297D2AC
	|-List.Enumerator<HouseRecipeManager.RecipeData>.get_Current
	|
	|-RVA: 0x297D4B8 Offset: 0x29794B8 VA: 0x297D4B8
	|-List.Enumerator<KadarElexioBuf.SkillIdData>.get_Current
	|
	|-RVA: 0x297D6B4 Offset: 0x29796B4 VA: 0x297D6B4
	|-List.Enumerator<MissionTextManagerData.CheckIKeywordtemData>.get_Current
	|
	|-RVA: 0x297D8CC Offset: 0x29798CC VA: 0x297D8CC
	|-List.Enumerator<MissionTextManagerData.PickUpFieldData>.get_Current
	|
	|-RVA: 0x297DAD0 Offset: 0x2979AD0 VA: 0x297DAD0
	|-List.Enumerator<MobaRoomData.MobaAbilityMasterData>.get_Current
	|
	|-RVA: 0x297DCDC Offset: 0x2979CDC VA: 0x297DCDC
	|-List.Enumerator<NewWaveRoomData.Spotlight>.get_Current
	|
	|-RVA: 0x297DEE4 Offset: 0x2979EE4 VA: 0x297DEE4
	|-List.Enumerator<NguiDynamicFontController.ApplyTextureInfo>.get_Current
	|
	|-RVA: 0x297E0D4 Offset: 0x297A0D4 VA: 0x297E0D4
	|-List.Enumerator<RegexCharClass.SingleRange>.get_Current
	|
	|-RVA: 0x297F248 Offset: 0x297B248 VA: 0x297F248
	|-List.Enumerator<SocialAchievementData.LinkData>.get_Current
	|
	|-RVA: 0x297F43C Offset: 0x297B43C VA: 0x297F43C
	|-List.Enumerator<TrophyManager.TrophyData>.get_Current
	|
	|-RVA: 0x297F650 Offset: 0x297B650 VA: 0x297F650
	|-List.Enumerator<UIEventMenuButton.MessageButtonData>.get_Current
	|
	|-RVA: 0x297F874 Offset: 0x297B874 VA: 0x297F874
	|-List.Enumerator<UIFieldMapPanel.PopData>.get_Current
	|
	|-RVA: 0x297FA6C Offset: 0x297BA6C VA: 0x297FA6C
	|-List.Enumerator<UIHouseAddressManager.Town>.get_Current
	|
	|-RVA: 0x297FC6C Offset: 0x297BC6C VA: 0x297FC6C
	|-List.Enumerator<UIInfoWindow.LabelPosition>.get_Current
	|
	|-RVA: 0x297FE64 Offset: 0x297BE64 VA: 0x297FE64
	|-List.Enumerator<UIMainManager.DropItemData>.get_Current
	|
	|-RVA: 0x298005C Offset: 0x297C05C VA: 0x298005C
	|-List.Enumerator<UIScenarioOrderPanel.MissionData>.get_Current
	|
	|-RVA: 0x2980274 Offset: 0x297C274 VA: 0x2980274
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.get_Current
	|
	|-RVA: 0x298048C Offset: 0x297C48C VA: 0x298048C
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Current
	|
	|-RVA: 0x2980980 Offset: 0x297C980 VA: 0x2980980
	|-List.Enumerator<BounceParabolaAttackPattern.TargetData.BoundLineData>.get_Current
	|
	|-RVA: 0x2980B90 Offset: 0x297CB90 VA: 0x2980B90
	|-List.Enumerator<InstructionList.DebugView.InstructionView>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296A08C Offset: 0x296608C VA: 0x296A08C
	|-List.Enumerator<KeyValuePair<ArchetypeUid, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296A278 Offset: 0x2966278 VA: 0x296A278
	|-List.Enumerator<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296A460 Offset: 0x2966460 VA: 0x296A460
	|-List.Enumerator<KeyValuePair<byte, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296A65C Offset: 0x296665C VA: 0x296A65C
	|-List.Enumerator<KeyValuePair<byte, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296BCF4 Offset: 0x2967CF4 VA: 0x296BCF4
	|-List.Enumerator<KeyValuePair<int, short>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296BEDC Offset: 0x2967EDC VA: 0x296BEDC
	|-List.Enumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296C0D8 Offset: 0x29680D8 VA: 0x296C0D8
	|-List.Enumerator<KeyValuePair<int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296C2C8 Offset: 0x29682C8 VA: 0x296C2C8
	|-List.Enumerator<KeyValuePair<Int32Enum, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296C4E0 Offset: 0x29684E0 VA: 0x296C4E0
	|-List.Enumerator<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296C6E0 Offset: 0x29686E0 VA: 0x296C6E0
	|-List.Enumerator<KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296C8DC Offset: 0x29688DC VA: 0x296C8DC
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296CAE0 Offset: 0x2968AE0 VA: 0x296CAE0
	|-List.Enumerator<KeyValuePair<object, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296CCE4 Offset: 0x2968CE4 VA: 0x296CCE4
	|-List.Enumerator<KeyValuePair<object, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296CEE8 Offset: 0x2968EE8 VA: 0x296CEE8
	|-List.Enumerator<KeyValuePair<float, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296D0F4 Offset: 0x29690F4 VA: 0x296D0F4
	|-List.Enumerator<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296D2FC Offset: 0x29692FC VA: 0x296D2FC
	|-List.Enumerator<StructMultiKey<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296D4E8 Offset: 0x29694E8 VA: 0x296D4E8
	|-List.Enumerator<ValueTuple<short, short>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296D6D0 Offset: 0x29696D0 VA: 0x296D6D0
	|-List.Enumerator<ValueTuple<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296D8CC Offset: 0x29698CC VA: 0x296D8CC
	|-List.Enumerator<ValueTuple<int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296DABC Offset: 0x2969ABC VA: 0x296DABC
	|-List.Enumerator<ValueTuple<Int32Enum, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296E01C Offset: 0x296A01C VA: 0x296E01C
	|-List.Enumerator<ValueTuple<Vector3, Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296E590 Offset: 0x296A590 VA: 0x296E590
	|-List.Enumerator<ArchetypeUid>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296EA78 Offset: 0x296AA78 VA: 0x296EA78
	|-List.Enumerator<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296F0B0 Offset: 0x296B0B0 VA: 0x296F0B0
	|-List.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296F490 Offset: 0x296B490 VA: 0x296F490
	|-List.Enumerator<ByteEnum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296F678 Offset: 0x296B678 VA: 0x296F678
	|-List.Enumerator<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296F864 Offset: 0x296B864 VA: 0x296F864
	|-List.Enumerator<Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296FA50 Offset: 0x296BA50 VA: 0x296FA50
	|-List.Enumerator<Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29701D4 Offset: 0x296C1D4 VA: 0x29701D4
	|-List.Enumerator<DateTime>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29703C0 Offset: 0x296C3C0 VA: 0x29703C0
	|-List.Enumerator<DateTimeOffset>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29705B4 Offset: 0x296C5B4 VA: 0x29705B4
	|-List.Enumerator<Decimal>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29707C4 Offset: 0x296C7C4 VA: 0x29707C4
	|-List.Enumerator<DefencePoint2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2970C60 Offset: 0x296CC60 VA: 0x2970C60
	|-List.Enumerator<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2970E5C Offset: 0x296CE5C VA: 0x2970E5C
	|-List.Enumerator<EventSummary>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297104C Offset: 0x296D04C VA: 0x297104C
	|-List.Enumerator<short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2971234 Offset: 0x296D234 VA: 0x2971234
	|-List.Enumerator<Int16Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2971680 Offset: 0x296D680 VA: 0x2971680
	|-List.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2971D04 Offset: 0x296DD04 VA: 0x2971D04
	|-List.Enumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2971EEC Offset: 0x296DEEC VA: 0x2971EEC
	|-List.Enumerator<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29720E8 Offset: 0x296E0E8 VA: 0x29720E8
	|-List.Enumerator<InterpretedFrameInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2972308 Offset: 0x296E308 VA: 0x2972308
	|-List.Enumerator<JsonPosition>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29727F4 Offset: 0x296E7F4 VA: 0x29727F4
	|-List.Enumerator<MaterialSearchData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2972CE4 Offset: 0x296ECE4 VA: 0x2972CE4
	|-List.Enumerator<MobActionTargetData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2972F10 Offset: 0x296EF10 VA: 0x2972F10
	|-List.Enumerator<MobIconLabelData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2973984 Offset: 0x296F984 VA: 0x2973984
	|-List.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297466C Offset: 0x297066C VA: 0x297466C
	|-List.Enumerator<PlayerLoopSystem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29748A4 Offset: 0x29708A4 VA: 0x29748A4
	|-List.Enumerator<PlayerLoopSystemInternal>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2974CD8 Offset: 0x2970CD8 VA: 0x2974CD8
	|-List.Enumerator<RangePositionInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2974EE4 Offset: 0x2970EE4 VA: 0x2974EE4
	|-List.Enumerator<ReinforceCristaData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29750E0 Offset: 0x29710E0 VA: 0x29750E0
	|-List.Enumerator<sbyte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29754BC Offset: 0x29714BC VA: 0x29754BC
	|-List.Enumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29756A4 Offset: 0x29716A4 VA: 0x29756A4
	|-List.Enumerator<SkillIdData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297588C Offset: 0x297188C VA: 0x297588C
	|-List.Enumerator<TimeSpan>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2975A74 Offset: 0x2971A74 VA: 0x2975A74
	|-List.Enumerator<ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2975C58 Offset: 0x2971C58 VA: 0x2975C58
	|-List.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2975E40 Offset: 0x2971E40 VA: 0x2975E40
	|-List.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2976028 Offset: 0x2972028 VA: 0x2976028
	|-List.Enumerator<Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2976228 Offset: 0x2972228 VA: 0x2976228
	|-List.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2976688 Offset: 0x2972688 VA: 0x2976688
	|-List.Enumerator<X509ChainStatus>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2979320 Offset: 0x2975320 VA: 0x2979320
	|-List.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297CE6C Offset: 0x2978E6C VA: 0x297CE6C
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297D08C Offset: 0x297908C VA: 0x297D08C
	|-List.Enumerator<BoneClip.MotionKeyFrame>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297D2C0 Offset: 0x29792C0 VA: 0x297D2C0
	|-List.Enumerator<HouseRecipeManager.RecipeData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297D4C0 Offset: 0x29794C0 VA: 0x297D4C0
	|-List.Enumerator<KadarElexioBuf.SkillIdData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297D6C4 Offset: 0x29796C4 VA: 0x297D6C4
	|-List.Enumerator<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297D8DC Offset: 0x29798DC VA: 0x297D8DC
	|-List.Enumerator<MissionTextManagerData.PickUpFieldData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297DADC Offset: 0x2979ADC VA: 0x297DADC
	|-List.Enumerator<MobaRoomData.MobaAbilityMasterData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297DCE8 Offset: 0x2979CE8 VA: 0x297DCE8
	|-List.Enumerator<NewWaveRoomData.Spotlight>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297DEF0 Offset: 0x2979EF0 VA: 0x297DEF0
	|-List.Enumerator<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297E0DC Offset: 0x297A0DC VA: 0x297E0DC
	|-List.Enumerator<RegexCharClass.SingleRange>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297F254 Offset: 0x297B254 VA: 0x297F254
	|-List.Enumerator<SocialAchievementData.LinkData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297F444 Offset: 0x297B444 VA: 0x297F444
	|-List.Enumerator<TrophyManager.TrophyData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297F664 Offset: 0x297B664 VA: 0x297F664
	|-List.Enumerator<UIEventMenuButton.MessageButtonData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297F880 Offset: 0x297B880 VA: 0x297F880
	|-List.Enumerator<UIFieldMapPanel.PopData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297FA74 Offset: 0x297BA74 VA: 0x297FA74
	|-List.Enumerator<UIHouseAddressManager.Town>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297FC78 Offset: 0x297BC78 VA: 0x297FC78
	|-List.Enumerator<UIInfoWindow.LabelPosition>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297FE6C Offset: 0x297BE6C VA: 0x297FE6C
	|-List.Enumerator<UIMainManager.DropItemData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2980068 Offset: 0x297C068 VA: 0x2980068
	|-List.Enumerator<UIScenarioOrderPanel.MissionData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2980288 Offset: 0x297C288 VA: 0x2980288
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2980498 Offset: 0x297C498 VA: 0x2980498
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298098C Offset: 0x297C98C VA: 0x298098C
	|-List.Enumerator<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2980B9C Offset: 0x297CB9C VA: 0x2980B9C
	|-List.Enumerator<InstructionList.DebugView.InstructionView>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296A11C Offset: 0x296611C VA: 0x296A11C
	|-List.Enumerator<KeyValuePair<ArchetypeUid, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296A300 Offset: 0x2966300 VA: 0x296A300
	|-List.Enumerator<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296A4E8 Offset: 0x29664E8 VA: 0x296A4E8
	|-List.Enumerator<KeyValuePair<byte, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296A6EC Offset: 0x29666EC VA: 0x296A6EC
	|-List.Enumerator<KeyValuePair<byte, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296BD7C Offset: 0x2967D7C VA: 0x296BD7C
	|-List.Enumerator<KeyValuePair<int, short>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296BF64 Offset: 0x2967F64 VA: 0x296BF64
	|-List.Enumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296C168 Offset: 0x2968168 VA: 0x296C168
	|-List.Enumerator<KeyValuePair<int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296C350 Offset: 0x2968350 VA: 0x296C350
	|-List.Enumerator<KeyValuePair<Int32Enum, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296C578 Offset: 0x2968578 VA: 0x296C578
	|-List.Enumerator<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296C768 Offset: 0x2968768 VA: 0x296C768
	|-List.Enumerator<KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296C96C Offset: 0x296896C VA: 0x296C96C
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296CB70 Offset: 0x2968B70 VA: 0x296CB70
	|-List.Enumerator<KeyValuePair<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296CD74 Offset: 0x2968D74 VA: 0x296CD74
	|-List.Enumerator<KeyValuePair<object, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296CF78 Offset: 0x2968F78 VA: 0x296CF78
	|-List.Enumerator<KeyValuePair<float, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296D184 Offset: 0x2969184 VA: 0x296D184
	|-List.Enumerator<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296D38C Offset: 0x296938C VA: 0x296D38C
	|-List.Enumerator<StructMultiKey<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296D570 Offset: 0x2969570 VA: 0x296D570
	|-List.Enumerator<ValueTuple<short, short>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296D758 Offset: 0x2969758 VA: 0x296D758
	|-List.Enumerator<ValueTuple<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296D95C Offset: 0x296995C VA: 0x296D95C
	|-List.Enumerator<ValueTuple<int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296DB44 Offset: 0x2969B44 VA: 0x296DB44
	|-List.Enumerator<ValueTuple<Int32Enum, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296E0B4 Offset: 0x296A0B4 VA: 0x296E0B4
	|-List.Enumerator<ValueTuple<Vector3, Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296E618 Offset: 0x296A618 VA: 0x296E618
	|-List.Enumerator<ArchetypeUid>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296EB00 Offset: 0x296AB00 VA: 0x296EB00
	|-List.Enumerator<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296F138 Offset: 0x296B138 VA: 0x296F138
	|-List.Enumerator<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296F518 Offset: 0x296B518 VA: 0x296F518
	|-List.Enumerator<ByteEnum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296F700 Offset: 0x296B700 VA: 0x296F700
	|-List.Enumerator<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296F8F4 Offset: 0x296B8F4 VA: 0x296F8F4
	|-List.Enumerator<Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296FAD8 Offset: 0x296BAD8 VA: 0x296FAD8
	|-List.Enumerator<Color32>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297025C Offset: 0x296C25C VA: 0x297025C
	|-List.Enumerator<DateTime>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2970450 Offset: 0x296C450 VA: 0x2970450
	|-List.Enumerator<DateTimeOffset>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2970664 Offset: 0x296C664 VA: 0x2970664
	|-List.Enumerator<Decimal>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297084C Offset: 0x296C84C VA: 0x297084C
	|-List.Enumerator<DefencePoint2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2970CE8 Offset: 0x296CCE8 VA: 0x2970CE8
	|-List.Enumerator<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2970EEC Offset: 0x296CEEC VA: 0x2970EEC
	|-List.Enumerator<EventSummary>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29710D4 Offset: 0x296D0D4 VA: 0x29710D4
	|-List.Enumerator<short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29712BC Offset: 0x296D2BC VA: 0x29712BC
	|-List.Enumerator<Int16Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2971708 Offset: 0x296D708 VA: 0x2971708
	|-List.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2971D8C Offset: 0x296DD8C VA: 0x2971D8C
	|-List.Enumerator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2971F74 Offset: 0x296DF74 VA: 0x2971F74
	|-List.Enumerator<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2972178 Offset: 0x296E178 VA: 0x2972178
	|-List.Enumerator<InterpretedFrameInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29723A0 Offset: 0x296E3A0 VA: 0x29723A0
	|-List.Enumerator<JsonPosition>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2972884 Offset: 0x296E884 VA: 0x2972884
	|-List.Enumerator<MaterialSearchData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2972D7C Offset: 0x296ED7C VA: 0x2972D7C
	|-List.Enumerator<MobActionTargetData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2972FA8 Offset: 0x296EFA8 VA: 0x2972FA8
	|-List.Enumerator<MobIconLabelData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29739E0 Offset: 0x296F9E0 VA: 0x29739E0
	|-List.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2974704 Offset: 0x2970704 VA: 0x2974704
	|-List.Enumerator<PlayerLoopSystem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297493C Offset: 0x297093C VA: 0x297493C
	|-List.Enumerator<PlayerLoopSystemInternal>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2974D68 Offset: 0x2970D68 VA: 0x2974D68
	|-List.Enumerator<RangePositionInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2974F7C Offset: 0x2970F7C VA: 0x2974F7C
	|-List.Enumerator<ReinforceCristaData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2975168 Offset: 0x2971168 VA: 0x2975168
	|-List.Enumerator<sbyte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2975544 Offset: 0x2971544 VA: 0x2975544
	|-List.Enumerator<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297572C Offset: 0x297172C VA: 0x297572C
	|-List.Enumerator<SkillIdData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2975914 Offset: 0x2971914 VA: 0x2975914
	|-List.Enumerator<TimeSpan>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2975AFC Offset: 0x2971AFC VA: 0x2975AFC
	|-List.Enumerator<ushort>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2975CE0 Offset: 0x2971CE0 VA: 0x2975CE0
	|-List.Enumerator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2975EC8 Offset: 0x2971EC8 VA: 0x2975EC8
	|-List.Enumerator<ulong>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29760B0 Offset: 0x29720B0 VA: 0x29760B0
	|-List.Enumerator<Vector2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29762C0 Offset: 0x29722C0 VA: 0x29762C0
	|-List.Enumerator<Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2976718 Offset: 0x2972718 VA: 0x2976718
	|-List.Enumerator<X509ChainStatus>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29794F8 Offset: 0x29754F8 VA: 0x29794F8
	|-List.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297CEFC Offset: 0x2978EFC VA: 0x297CEFC
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297D124 Offset: 0x2979124 VA: 0x297D124
	|-List.Enumerator<BoneClip.MotionKeyFrame>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297D358 Offset: 0x2979358 VA: 0x297D358
	|-List.Enumerator<HouseRecipeManager.RecipeData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297D548 Offset: 0x2979548 VA: 0x297D548
	|-List.Enumerator<KadarElexioBuf.SkillIdData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297D75C Offset: 0x297975C VA: 0x297D75C
	|-List.Enumerator<MissionTextManagerData.CheckIKeywordtemData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297D974 Offset: 0x2979974 VA: 0x297D974
	|-List.Enumerator<MissionTextManagerData.PickUpFieldData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297DB6C Offset: 0x2979B6C VA: 0x297DB6C
	|-List.Enumerator<MobaRoomData.MobaAbilityMasterData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297DD78 Offset: 0x2979D78 VA: 0x297DD78
	|-List.Enumerator<NewWaveRoomData.Spotlight>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297DF80 Offset: 0x2979F80 VA: 0x297DF80
	|-List.Enumerator<NguiDynamicFontController.ApplyTextureInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297E164 Offset: 0x297A164 VA: 0x297E164
	|-List.Enumerator<RegexCharClass.SingleRange>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297F2E4 Offset: 0x297B2E4 VA: 0x297F2E4
	|-List.Enumerator<SocialAchievementData.LinkData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297F4CC Offset: 0x297B4CC VA: 0x297F4CC
	|-List.Enumerator<TrophyManager.TrophyData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297F6FC Offset: 0x297B6FC VA: 0x297F6FC
	|-List.Enumerator<UIEventMenuButton.MessageButtonData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297F910 Offset: 0x297B910 VA: 0x297F910
	|-List.Enumerator<UIFieldMapPanel.PopData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297FAFC Offset: 0x297BAFC VA: 0x297FAFC
	|-List.Enumerator<UIHouseAddressManager.Town>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297FD08 Offset: 0x297BD08 VA: 0x297FD08
	|-List.Enumerator<UIInfoWindow.LabelPosition>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297FEF4 Offset: 0x297BEF4 VA: 0x297FEF4
	|-List.Enumerator<UIMainManager.DropItemData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29800F8 Offset: 0x297C0F8 VA: 0x29800F8
	|-List.Enumerator<UIScenarioOrderPanel.MissionData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2980320 Offset: 0x297C320 VA: 0x2980320
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2980528 Offset: 0x297C528 VA: 0x2980528
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2980A1C Offset: 0x297CA1C VA: 0x2980A1C
	|-List.Enumerator<BounceParabolaAttackPattern.TargetData.BoundLineData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2980C2C Offset: 0x297CC2C VA: 0x2980C2C
	|-List.Enumerator<InstructionList.DebugView.InstructionView>.System.Collections.IEnumerator.Reset
	*/
}
