// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
[Serializable]
internal class ObjectComparer<T> : Comparer<T> // TypeDefIndex: 10975
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public override int Compare(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BBEA50 Offset: 0x2BBAA50 VA: 0x2BBEA50
	|-ObjectComparer<KeyValuePair<ArchetypeUid, object>>.Compare
	|
	|-RVA: 0x2BBEBCC Offset: 0x2BBABCC VA: 0x2BBEBCC
	|-ObjectComparer<KeyValuePair<byte, BlackKnightCristaProperty>>.Compare
	|
	|-RVA: 0x2BBED38 Offset: 0x2BBAD38 VA: 0x2BBED38
	|-ObjectComparer<KeyValuePair<byte, byte>>.Compare
	|
	|-RVA: 0x2BBEEA4 Offset: 0x2BBAEA4 VA: 0x2BBEEA4
	|-ObjectComparer<KeyValuePair<byte, object>>.Compare
	|
	|-RVA: 0x2BBF020 Offset: 0x2BBB020 VA: 0x2BBF020
	|-ObjectComparer<KeyValuePair<double, int>>.Compare
	|
	|-RVA: 0x2BBF19C Offset: 0x2BBB19C VA: 0x2BBF19C
	|-ObjectComparer<KeyValuePair<int, short>>.Compare
	|
	|-RVA: 0x2BBF308 Offset: 0x2BBB308 VA: 0x2BBF308
	|-ObjectComparer<KeyValuePair<int, int>>.Compare
	|
	|-RVA: 0x2BBF474 Offset: 0x2BBB474 VA: 0x2BBF474
	|-ObjectComparer<KeyValuePair<int, object>>.Compare
	|
	|-RVA: 0x2BBF5F0 Offset: 0x2BBB5F0 VA: 0x2BBF5F0
	|-ObjectComparer<KeyValuePair<Int32Enum, byte>>.Compare
	|
	|-RVA: 0x2BBF75C Offset: 0x2BBB75C VA: 0x2BBF75C
	|-ObjectComparer<KeyValuePair<Int32Enum, EnhanceProperties2>>.Compare
	|
	|-RVA: 0x2BBF8E0 Offset: 0x2BBB8E0 VA: 0x2BBF8E0
	|-ObjectComparer<KeyValuePair<Int32Enum, int>>.Compare
	|
	|-RVA: 0x2BBFA4C Offset: 0x2BBBA4C VA: 0x2BBFA4C
	|-ObjectComparer<KeyValuePair<Int32Enum, object>>.Compare
	|
	|-RVA: 0x2BBFBC8 Offset: 0x2BBBBC8 VA: 0x2BBFBC8
	|-ObjectComparer<KeyValuePair<object, int>>.Compare
	|
	|-RVA: 0x2BBFD44 Offset: 0x2BBBD44 VA: 0x2BBFD44
	|-ObjectComparer<KeyValuePair<object, float>>.Compare
	|
	|-RVA: 0x2BBFEC0 Offset: 0x2BBBEC0 VA: 0x2BBFEC0
	|-ObjectComparer<KeyValuePair<float, object>>.Compare
	|
	|-RVA: 0x2BC003C Offset: 0x2BBC03C VA: 0x2BC003C
	|-ObjectComparer<Nullable<UIMobPropertyLabel.IconValue>>.Compare
	|
	|-RVA: 0x2BC01B0 Offset: 0x2BBC1B0 VA: 0x2BC01B0
	|-ObjectComparer<StructMultiKey<object, object>>.Compare
	|
	|-RVA: 0x2BC032C Offset: 0x2BBC32C VA: 0x2BC032C
	|-ObjectComparer<ValueTuple<bool>>.Compare
	|
	|-RVA: 0x2BC0498 Offset: 0x2BBC498 VA: 0x2BC0498
	|-ObjectComparer<ValueTuple<short, short>>.Compare
	|
	|-RVA: 0x2BC0604 Offset: 0x2BBC604 VA: 0x2BC0604
	|-ObjectComparer<ValueTuple<int, int>>.Compare
	|
	|-RVA: 0x2BC0770 Offset: 0x2BBC770 VA: 0x2BC0770
	|-ObjectComparer<ValueTuple<int, object>>.Compare
	|
	|-RVA: 0x2BC08EC Offset: 0x2BBC8EC VA: 0x2BC08EC
	|-ObjectComparer<ValueTuple<Int32Enum, float>>.Compare
	|
	|-RVA: 0x2BC0A58 Offset: 0x2BBCA58 VA: 0x2BC0A58
	|-ObjectComparer<ValueTuple<Vector3, Vector3>>.Compare
	|
	|-RVA: 0x2BC0BDC Offset: 0x2BBCBDC VA: 0x2BC0BDC
	|-ObjectComparer<ArchetypeUid>.Compare
	|
	|-RVA: 0x2BC0D48 Offset: 0x2BBCD48 VA: 0x2BC0D48
	|-ObjectComparer<bool>.Compare
	|
	|-RVA: 0x2BC0EBC Offset: 0x2BBCEBC VA: 0x2BC0EBC
	|-ObjectComparer<byte>.Compare
	|
	|-RVA: 0x2BC1028 Offset: 0x2BBD028 VA: 0x2BC1028
	|-ObjectComparer<ByteEnum>.Compare
	|
	|-RVA: 0x2BC1194 Offset: 0x2BBD194 VA: 0x2BC1194
	|-ObjectComparer<char>.Compare
	|
	|-RVA: 0x2BC1300 Offset: 0x2BBD300 VA: 0x2BC1300
	|-ObjectComparer<Color>.Compare
	|
	|-RVA: 0x2BC14A4 Offset: 0x2BBD4A4 VA: 0x2BC14A4
	|-ObjectComparer<Color32>.Compare
	|
	|-RVA: 0x2BC1610 Offset: 0x2BBD610 VA: 0x2BC1610
	|-ObjectComparer<DateTime>.Compare
	|
	|-RVA: 0x2BC177C Offset: 0x2BBD77C VA: 0x2BC177C
	|-ObjectComparer<DateTimeOffset>.Compare
	|
	|-RVA: 0x2BC18F8 Offset: 0x2BBD8F8 VA: 0x2BC18F8
	|-ObjectComparer<Decimal>.Compare
	|
	|-RVA: 0x2BC1A9C Offset: 0x2BBDA9C VA: 0x2BC1A9C
	|-ObjectComparer<DefencePoint2>.Compare
	|
	|-RVA: 0x2BC1C08 Offset: 0x2BBDC08 VA: 0x2BC1C08
	|-ObjectComparer<double>.Compare
	|
	|-RVA: 0x2BC1D74 Offset: 0x2BBDD74 VA: 0x2BC1D74
	|-ObjectComparer<EventSummary>.Compare
	|
	|-RVA: 0x2BC1EF0 Offset: 0x2BBDEF0 VA: 0x2BC1EF0
	|-ObjectComparer<short>.Compare
	|
	|-RVA: 0x2BC205C Offset: 0x2BBE05C VA: 0x2BC205C
	|-ObjectComparer<Int16Enum>.Compare
	|
	|-RVA: 0x2BC21C8 Offset: 0x2BBE1C8 VA: 0x2BC21C8
	|-ObjectComparer<int>.Compare
	|
	|-RVA: 0x2BC2334 Offset: 0x2BBE334 VA: 0x2BC2334
	|-ObjectComparer<Int32Enum>.Compare
	|
	|-RVA: 0x2BC24A0 Offset: 0x2BBE4A0 VA: 0x2BC24A0
	|-ObjectComparer<long>.Compare
	|
	|-RVA: 0x2BC260C Offset: 0x2BBE60C VA: 0x2BC260C
	|-ObjectComparer<IntPtr>.Compare
	|
	|-RVA: 0x2BC2778 Offset: 0x2BBE778 VA: 0x2BC2778
	|-ObjectComparer<InterpretedFrameInfo>.Compare
	|
	|-RVA: 0x2BC28F4 Offset: 0x2BBE8F4 VA: 0x2BC28F4
	|-ObjectComparer<JsonPosition>.Compare
	|
	|-RVA: 0x2BC2A78 Offset: 0x2BBEA78 VA: 0x2BC2A78
	|-ObjectComparer<MaterialSearchData>.Compare
	|
	|-RVA: 0x2BC2BF4 Offset: 0x2BBEBF4 VA: 0x2BC2BF4
	|-ObjectComparer<MobActionTargetData>.Compare
	|
	|-RVA: 0x2BC2D78 Offset: 0x2BBED78 VA: 0x2BC2D78
	|-ObjectComparer<MobIconLabelData>.Compare
	|
	|-RVA: 0x2BC2EFC Offset: 0x2BBEEFC VA: 0x2BC2EFC
	|-ObjectComparer<object>.Compare
	|
	|-RVA: 0x2BC301C Offset: 0x2BBF01C VA: 0x2BC301C
	|-ObjectComparer<PlayerLoopSystem>.Compare
	|
	|-RVA: 0x2BC31A0 Offset: 0x2BBF1A0 VA: 0x2BC31A0
	|-ObjectComparer<PlayerLoopSystemInternal>.Compare
	|
	|-RVA: 0x2BC3324 Offset: 0x2BBF324 VA: 0x2BC3324
	|-ObjectComparer<RangePositionInfo>.Compare
	|
	|-RVA: 0x2BC34A0 Offset: 0x2BBF4A0 VA: 0x2BC34A0
	|-ObjectComparer<RaycastHit>.Compare
	|
	|-RVA: 0x2BC3624 Offset: 0x2BBF624 VA: 0x2BC3624
	|-ObjectComparer<ReinforceCristaData>.Compare
	|
	|-RVA: 0x2BC37A8 Offset: 0x2BBF7A8 VA: 0x2BC37A8
	|-ObjectComparer<sbyte>.Compare
	|
	|-RVA: 0x2BC3914 Offset: 0x2BBF914 VA: 0x2BC3914
	|-ObjectComparer<float>.Compare
	|
	|-RVA: 0x2BC3A80 Offset: 0x2BBFA80 VA: 0x2BC3A80
	|-ObjectComparer<SkillIdData>.Compare
	|
	|-RVA: 0x2BC3BEC Offset: 0x2BBFBEC VA: 0x2BC3BEC
	|-ObjectComparer<TimeSpan>.Compare
	|
	|-RVA: 0x2BC3D58 Offset: 0x2BBFD58 VA: 0x2BC3D58
	|-ObjectComparer<ushort>.Compare
	|
	|-RVA: 0x2BC3EC4 Offset: 0x2BBFEC4 VA: 0x2BC3EC4
	|-ObjectComparer<uint>.Compare
	|
	|-RVA: 0x2BC4030 Offset: 0x2BC0030 VA: 0x2BC4030
	|-ObjectComparer<ulong>.Compare
	|
	|-RVA: 0x2BC419C Offset: 0x2BC019C VA: 0x2BC419C
	|-ObjectComparer<Vector2>.Compare
	|
	|-RVA: 0x2BC4318 Offset: 0x2BC0318 VA: 0x2BC4318
	|-ObjectComparer<Vector3>.Compare
	|
	|-RVA: 0x2BC44AC Offset: 0x2BC04AC VA: 0x2BC44AC
	|-ObjectComparer<X509ChainStatus>.Compare
	|
	|-RVA: 0x2BC4628 Offset: 0x2BC0628 VA: 0x2BC4628
	|-ObjectComparer<__Il2CppFullySharedGenericType>.Compare
	|
	|-RVA: 0x2BC4844 Offset: 0x2BC0844 VA: 0x2BC4844
	|-ObjectComparer<BeforeRenderHelper.OrderBlock>.Compare
	|
	|-RVA: 0x2BC49C0 Offset: 0x2BC09C0 VA: 0x2BC49C0
	|-ObjectComparer<BoneClip.MotionKeyFrame>.Compare
	|
	|-RVA: 0x2BC4B44 Offset: 0x2BC0B44 VA: 0x2BC4B44
	|-ObjectComparer<HouseRecipeManager.RecipeData>.Compare
	|
	|-RVA: 0x2BC4CC8 Offset: 0x2BC0CC8 VA: 0x2BC4CC8
	|-ObjectComparer<KadarElexioBuf.SkillIdData>.Compare
	|
	|-RVA: 0x2BC4E34 Offset: 0x2BC0E34 VA: 0x2BC4E34
	|-ObjectComparer<MissionTextManagerData.CheckIKeywordtemData>.Compare
	|
	|-RVA: 0x2BC4FB8 Offset: 0x2BC0FB8 VA: 0x2BC4FB8
	|-ObjectComparer<MissionTextManagerData.PickUpFieldData>.Compare
	|
	|-RVA: 0x2BC513C Offset: 0x2BC113C VA: 0x2BC513C
	|-ObjectComparer<MobaRoomData.MobaAbilityMasterData>.Compare
	|
	|-RVA: 0x2BC52B8 Offset: 0x2BC12B8 VA: 0x2BC52B8
	|-ObjectComparer<NewWaveRoomData.Spotlight>.Compare
	|
	|-RVA: 0x2BC542C Offset: 0x2BC142C VA: 0x2BC542C
	|-ObjectComparer<NguiDynamicFontController.ApplyTextureInfo>.Compare
	|
	|-RVA: 0x2BC55A8 Offset: 0x2BC15A8 VA: 0x2BC55A8
	|-ObjectComparer<RegexCharClass.SingleRange>.Compare
	|
	|-RVA: 0x2BC5714 Offset: 0x2BC1714 VA: 0x2BC5714
	|-ObjectComparer<SocialAchievementData.LinkData>.Compare
	|
	|-RVA: 0x2BC5890 Offset: 0x2BC1890 VA: 0x2BC5890
	|-ObjectComparer<TrophyManager.TrophyData>.Compare
	|
	|-RVA: 0x2BC59FC Offset: 0x2BC19FC VA: 0x2BC59FC
	|-ObjectComparer<UIEventMenuButton.MessageButtonData>.Compare
	|
	|-RVA: 0x2BC5B80 Offset: 0x2BC1B80 VA: 0x2BC5B80
	|-ObjectComparer<UIFieldMapPanel.PopData>.Compare
	|
	|-RVA: 0x2BC5CF4 Offset: 0x2BC1CF4 VA: 0x2BC5CF4
	|-ObjectComparer<UIHouseAddressManager.Town>.Compare
	|
	|-RVA: 0x2BC5E60 Offset: 0x2BC1E60 VA: 0x2BC5E60
	|-ObjectComparer<UIInfoWindow.LabelPosition>.Compare
	|
	|-RVA: 0x2BC5FD4 Offset: 0x2BC1FD4 VA: 0x2BC5FD4
	|-ObjectComparer<UIMainManager.DropItemData>.Compare
	|
	|-RVA: 0x2BC6140 Offset: 0x2BC2140 VA: 0x2BC6140
	|-ObjectComparer<UIScenarioOrderPanel.MissionData>.Compare
	|
	|-RVA: 0x2BC62BC Offset: 0x2BC22BC VA: 0x2BC62BC
	|-ObjectComparer<UnitySynchronizationContext.WorkRequest>.Compare
	|
	|-RVA: 0x2BC6440 Offset: 0x2BC2440 VA: 0x2BC6440
	|-ObjectComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Compare
	|
	|-RVA: 0x2BC65BC Offset: 0x2BC25BC VA: 0x2BC65BC
	|-ObjectComparer<BounceParabolaAttackPattern.TargetData.BoundLineData>.Compare
	|
	|-RVA: 0x2BC6730 Offset: 0x2BC2730 VA: 0x2BC6730
	|-ObjectComparer<InstructionList.DebugView.InstructionView>.Compare
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BBEB28 Offset: 0x2BBAB28 VA: 0x2BBEB28
	|-ObjectComparer<KeyValuePair<ArchetypeUid, object>>.Equals
	|
	|-RVA: 0x2BBEC94 Offset: 0x2BBAC94 VA: 0x2BBEC94
	|-ObjectComparer<KeyValuePair<byte, BlackKnightCristaProperty>>.Equals
	|
	|-RVA: 0x2BBEE00 Offset: 0x2BBAE00 VA: 0x2BBEE00
	|-ObjectComparer<KeyValuePair<byte, byte>>.Equals
	|
	|-RVA: 0x2BBEF7C Offset: 0x2BBAF7C VA: 0x2BBEF7C
	|-ObjectComparer<KeyValuePair<byte, object>>.Equals
	|
	|-RVA: 0x2BBF0F8 Offset: 0x2BBB0F8 VA: 0x2BBF0F8
	|-ObjectComparer<KeyValuePair<double, int>>.Equals
	|
	|-RVA: 0x2BBF264 Offset: 0x2BBB264 VA: 0x2BBF264
	|-ObjectComparer<KeyValuePair<int, short>>.Equals
	|
	|-RVA: 0x2BBF3D0 Offset: 0x2BBB3D0 VA: 0x2BBF3D0
	|-ObjectComparer<KeyValuePair<int, int>>.Equals
	|
	|-RVA: 0x2BBF54C Offset: 0x2BBB54C VA: 0x2BBF54C
	|-ObjectComparer<KeyValuePair<int, object>>.Equals
	|
	|-RVA: 0x2BBF6B8 Offset: 0x2BBB6B8 VA: 0x2BBF6B8
	|-ObjectComparer<KeyValuePair<Int32Enum, byte>>.Equals
	|
	|-RVA: 0x2BBF83C Offset: 0x2BBB83C VA: 0x2BBF83C
	|-ObjectComparer<KeyValuePair<Int32Enum, EnhanceProperties2>>.Equals
	|
	|-RVA: 0x2BBF9A8 Offset: 0x2BBB9A8 VA: 0x2BBF9A8
	|-ObjectComparer<KeyValuePair<Int32Enum, int>>.Equals
	|
	|-RVA: 0x2BBFB24 Offset: 0x2BBBB24 VA: 0x2BBFB24
	|-ObjectComparer<KeyValuePair<Int32Enum, object>>.Equals
	|
	|-RVA: 0x2BBFCA0 Offset: 0x2BBBCA0 VA: 0x2BBFCA0
	|-ObjectComparer<KeyValuePair<object, int>>.Equals
	|
	|-RVA: 0x2BBFE1C Offset: 0x2BBBE1C VA: 0x2BBFE1C
	|-ObjectComparer<KeyValuePair<object, float>>.Equals
	|
	|-RVA: 0x2BBFF98 Offset: 0x2BBBF98 VA: 0x2BBFF98
	|-ObjectComparer<KeyValuePair<float, object>>.Equals
	|
	|-RVA: 0x2BC010C Offset: 0x2BBC10C VA: 0x2BC010C
	|-ObjectComparer<Nullable<UIMobPropertyLabel.IconValue>>.Equals
	|
	|-RVA: 0x2BC0288 Offset: 0x2BBC288 VA: 0x2BC0288
	|-ObjectComparer<StructMultiKey<object, object>>.Equals
	|
	|-RVA: 0x2BC03F4 Offset: 0x2BBC3F4 VA: 0x2BC03F4
	|-ObjectComparer<ValueTuple<bool>>.Equals
	|
	|-RVA: 0x2BC0560 Offset: 0x2BBC560 VA: 0x2BC0560
	|-ObjectComparer<ValueTuple<short, short>>.Equals
	|
	|-RVA: 0x2BC06CC Offset: 0x2BBC6CC VA: 0x2BC06CC
	|-ObjectComparer<ValueTuple<int, int>>.Equals
	|
	|-RVA: 0x2BC0848 Offset: 0x2BBC848 VA: 0x2BC0848
	|-ObjectComparer<ValueTuple<int, object>>.Equals
	|
	|-RVA: 0x2BC09B4 Offset: 0x2BBC9B4 VA: 0x2BC09B4
	|-ObjectComparer<ValueTuple<Int32Enum, float>>.Equals
	|
	|-RVA: 0x2BC0B38 Offset: 0x2BBCB38 VA: 0x2BC0B38
	|-ObjectComparer<ValueTuple<Vector3, Vector3>>.Equals
	|
	|-RVA: 0x2BC0CA4 Offset: 0x2BBCCA4 VA: 0x2BC0CA4
	|-ObjectComparer<ArchetypeUid>.Equals
	|
	|-RVA: 0x2BC0E18 Offset: 0x2BBCE18 VA: 0x2BC0E18
	|-ObjectComparer<bool>.Equals
	|
	|-RVA: 0x2BC0F84 Offset: 0x2BBCF84 VA: 0x2BC0F84
	|-ObjectComparer<byte>.Equals
	|
	|-RVA: 0x2BC10F0 Offset: 0x2BBD0F0 VA: 0x2BC10F0
	|-ObjectComparer<ByteEnum>.Equals
	|
	|-RVA: 0x2BC125C Offset: 0x2BBD25C VA: 0x2BC125C
	|-ObjectComparer<char>.Equals
	|
	|-RVA: 0x2BC1400 Offset: 0x2BBD400 VA: 0x2BC1400
	|-ObjectComparer<Color>.Equals
	|
	|-RVA: 0x2BC156C Offset: 0x2BBD56C VA: 0x2BC156C
	|-ObjectComparer<Color32>.Equals
	|
	|-RVA: 0x2BC16D8 Offset: 0x2BBD6D8 VA: 0x2BC16D8
	|-ObjectComparer<DateTime>.Equals
	|
	|-RVA: 0x2BC1854 Offset: 0x2BBD854 VA: 0x2BC1854
	|-ObjectComparer<DateTimeOffset>.Equals
	|
	|-RVA: 0x2BC19F8 Offset: 0x2BBD9F8 VA: 0x2BC19F8
	|-ObjectComparer<Decimal>.Equals
	|
	|-RVA: 0x2BC1B64 Offset: 0x2BBDB64 VA: 0x2BC1B64
	|-ObjectComparer<DefencePoint2>.Equals
	|
	|-RVA: 0x2BC1CD0 Offset: 0x2BBDCD0 VA: 0x2BC1CD0
	|-ObjectComparer<double>.Equals
	|
	|-RVA: 0x2BC1E4C Offset: 0x2BBDE4C VA: 0x2BC1E4C
	|-ObjectComparer<EventSummary>.Equals
	|
	|-RVA: 0x2BC1FB8 Offset: 0x2BBDFB8 VA: 0x2BC1FB8
	|-ObjectComparer<short>.Equals
	|
	|-RVA: 0x2BC2124 Offset: 0x2BBE124 VA: 0x2BC2124
	|-ObjectComparer<Int16Enum>.Equals
	|
	|-RVA: 0x2BC2290 Offset: 0x2BBE290 VA: 0x2BC2290
	|-ObjectComparer<int>.Equals
	|
	|-RVA: 0x2BC23FC Offset: 0x2BBE3FC VA: 0x2BC23FC
	|-ObjectComparer<Int32Enum>.Equals
	|
	|-RVA: 0x2BC2568 Offset: 0x2BBE568 VA: 0x2BC2568
	|-ObjectComparer<long>.Equals
	|
	|-RVA: 0x2BC26D4 Offset: 0x2BBE6D4 VA: 0x2BC26D4
	|-ObjectComparer<IntPtr>.Equals
	|
	|-RVA: 0x2BC2850 Offset: 0x2BBE850 VA: 0x2BC2850
	|-ObjectComparer<InterpretedFrameInfo>.Equals
	|
	|-RVA: 0x2BC29D4 Offset: 0x2BBE9D4 VA: 0x2BC29D4
	|-ObjectComparer<JsonPosition>.Equals
	|
	|-RVA: 0x2BC2B50 Offset: 0x2BBEB50 VA: 0x2BC2B50
	|-ObjectComparer<MaterialSearchData>.Equals
	|
	|-RVA: 0x2BC2CD4 Offset: 0x2BBECD4 VA: 0x2BC2CD4
	|-ObjectComparer<MobActionTargetData>.Equals
	|
	|-RVA: 0x2BC2E58 Offset: 0x2BBEE58 VA: 0x2BC2E58
	|-ObjectComparer<MobIconLabelData>.Equals
	|
	|-RVA: 0x2BC2F78 Offset: 0x2BBEF78 VA: 0x2BC2F78
	|-ObjectComparer<object>.Equals
	|
	|-RVA: 0x2BC30FC Offset: 0x2BBF0FC VA: 0x2BC30FC
	|-ObjectComparer<PlayerLoopSystem>.Equals
	|
	|-RVA: 0x2BC3280 Offset: 0x2BBF280 VA: 0x2BC3280
	|-ObjectComparer<PlayerLoopSystemInternal>.Equals
	|
	|-RVA: 0x2BC33FC Offset: 0x2BBF3FC VA: 0x2BC33FC
	|-ObjectComparer<RangePositionInfo>.Equals
	|
	|-RVA: 0x2BC3580 Offset: 0x2BBF580 VA: 0x2BC3580
	|-ObjectComparer<RaycastHit>.Equals
	|
	|-RVA: 0x2BC3704 Offset: 0x2BBF704 VA: 0x2BC3704
	|-ObjectComparer<ReinforceCristaData>.Equals
	|
	|-RVA: 0x2BC3870 Offset: 0x2BBF870 VA: 0x2BC3870
	|-ObjectComparer<sbyte>.Equals
	|
	|-RVA: 0x2BC39DC Offset: 0x2BBF9DC VA: 0x2BC39DC
	|-ObjectComparer<float>.Equals
	|
	|-RVA: 0x2BC3B48 Offset: 0x2BBFB48 VA: 0x2BC3B48
	|-ObjectComparer<SkillIdData>.Equals
	|
	|-RVA: 0x2BC3CB4 Offset: 0x2BBFCB4 VA: 0x2BC3CB4
	|-ObjectComparer<TimeSpan>.Equals
	|
	|-RVA: 0x2BC3E20 Offset: 0x2BBFE20 VA: 0x2BC3E20
	|-ObjectComparer<ushort>.Equals
	|
	|-RVA: 0x2BC3F8C Offset: 0x2BBFF8C VA: 0x2BC3F8C
	|-ObjectComparer<uint>.Equals
	|
	|-RVA: 0x2BC40F8 Offset: 0x2BC00F8 VA: 0x2BC40F8
	|-ObjectComparer<ulong>.Equals
	|
	|-RVA: 0x2BC4274 Offset: 0x2BC0274 VA: 0x2BC4274
	|-ObjectComparer<Vector2>.Equals
	|
	|-RVA: 0x2BC4408 Offset: 0x2BC0408 VA: 0x2BC4408
	|-ObjectComparer<Vector3>.Equals
	|
	|-RVA: 0x2BC4584 Offset: 0x2BC0584 VA: 0x2BC4584
	|-ObjectComparer<X509ChainStatus>.Equals
	|
	|-RVA: 0x2BC479C Offset: 0x2BC079C VA: 0x2BC479C
	|-ObjectComparer<__Il2CppFullySharedGenericType>.Equals
	|
	|-RVA: 0x2BC491C Offset: 0x2BC091C VA: 0x2BC491C
	|-ObjectComparer<BeforeRenderHelper.OrderBlock>.Equals
	|
	|-RVA: 0x2BC4AA0 Offset: 0x2BC0AA0 VA: 0x2BC4AA0
	|-ObjectComparer<BoneClip.MotionKeyFrame>.Equals
	|
	|-RVA: 0x2BC4C24 Offset: 0x2BC0C24 VA: 0x2BC4C24
	|-ObjectComparer<HouseRecipeManager.RecipeData>.Equals
	|
	|-RVA: 0x2BC4D90 Offset: 0x2BC0D90 VA: 0x2BC4D90
	|-ObjectComparer<KadarElexioBuf.SkillIdData>.Equals
	|
	|-RVA: 0x2BC4F14 Offset: 0x2BC0F14 VA: 0x2BC4F14
	|-ObjectComparer<MissionTextManagerData.CheckIKeywordtemData>.Equals
	|
	|-RVA: 0x2BC5098 Offset: 0x2BC1098 VA: 0x2BC5098
	|-ObjectComparer<MissionTextManagerData.PickUpFieldData>.Equals
	|
	|-RVA: 0x2BC5214 Offset: 0x2BC1214 VA: 0x2BC5214
	|-ObjectComparer<MobaRoomData.MobaAbilityMasterData>.Equals
	|
	|-RVA: 0x2BC5388 Offset: 0x2BC1388 VA: 0x2BC5388
	|-ObjectComparer<NewWaveRoomData.Spotlight>.Equals
	|
	|-RVA: 0x2BC5504 Offset: 0x2BC1504 VA: 0x2BC5504
	|-ObjectComparer<NguiDynamicFontController.ApplyTextureInfo>.Equals
	|
	|-RVA: 0x2BC5670 Offset: 0x2BC1670 VA: 0x2BC5670
	|-ObjectComparer<RegexCharClass.SingleRange>.Equals
	|
	|-RVA: 0x2BC57EC Offset: 0x2BC17EC VA: 0x2BC57EC
	|-ObjectComparer<SocialAchievementData.LinkData>.Equals
	|
	|-RVA: 0x2BC5958 Offset: 0x2BC1958 VA: 0x2BC5958
	|-ObjectComparer<TrophyManager.TrophyData>.Equals
	|
	|-RVA: 0x2BC5ADC Offset: 0x2BC1ADC VA: 0x2BC5ADC
	|-ObjectComparer<UIEventMenuButton.MessageButtonData>.Equals
	|
	|-RVA: 0x2BC5C50 Offset: 0x2BC1C50 VA: 0x2BC5C50
	|-ObjectComparer<UIFieldMapPanel.PopData>.Equals
	|
	|-RVA: 0x2BC5DBC Offset: 0x2BC1DBC VA: 0x2BC5DBC
	|-ObjectComparer<UIHouseAddressManager.Town>.Equals
	|
	|-RVA: 0x2BC5F30 Offset: 0x2BC1F30 VA: 0x2BC5F30
	|-ObjectComparer<UIInfoWindow.LabelPosition>.Equals
	|
	|-RVA: 0x2BC609C Offset: 0x2BC209C VA: 0x2BC609C
	|-ObjectComparer<UIMainManager.DropItemData>.Equals
	|
	|-RVA: 0x2BC6218 Offset: 0x2BC2218 VA: 0x2BC6218
	|-ObjectComparer<UIScenarioOrderPanel.MissionData>.Equals
	|
	|-RVA: 0x2BC639C Offset: 0x2BC239C VA: 0x2BC639C
	|-ObjectComparer<UnitySynchronizationContext.WorkRequest>.Equals
	|
	|-RVA: 0x2BC6518 Offset: 0x2BC2518 VA: 0x2BC6518
	|-ObjectComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Equals
	|
	|-RVA: 0x2BC668C Offset: 0x2BC268C VA: 0x2BC668C
	|-ObjectComparer<BounceParabolaAttackPattern.TargetData.BoundLineData>.Equals
	|
	|-RVA: 0x2BC6800 Offset: 0x2BC2800 VA: 0x2BC6800
	|-ObjectComparer<InstructionList.DebugView.InstructionView>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BBEB84 Offset: 0x2BBAB84 VA: 0x2BBEB84
	|-ObjectComparer<KeyValuePair<ArchetypeUid, object>>.GetHashCode
	|
	|-RVA: 0x2BBECF0 Offset: 0x2BBACF0 VA: 0x2BBECF0
	|-ObjectComparer<KeyValuePair<byte, BlackKnightCristaProperty>>.GetHashCode
	|
	|-RVA: 0x2BBEE5C Offset: 0x2BBAE5C VA: 0x2BBEE5C
	|-ObjectComparer<KeyValuePair<byte, byte>>.GetHashCode
	|
	|-RVA: 0x2BBEFD8 Offset: 0x2BBAFD8 VA: 0x2BBEFD8
	|-ObjectComparer<KeyValuePair<byte, object>>.GetHashCode
	|
	|-RVA: 0x2BBF154 Offset: 0x2BBB154 VA: 0x2BBF154
	|-ObjectComparer<KeyValuePair<double, int>>.GetHashCode
	|
	|-RVA: 0x2BBF2C0 Offset: 0x2BBB2C0 VA: 0x2BBF2C0
	|-ObjectComparer<KeyValuePair<int, short>>.GetHashCode
	|
	|-RVA: 0x2BBF42C Offset: 0x2BBB42C VA: 0x2BBF42C
	|-ObjectComparer<KeyValuePair<int, int>>.GetHashCode
	|
	|-RVA: 0x2BBF5A8 Offset: 0x2BBB5A8 VA: 0x2BBF5A8
	|-ObjectComparer<KeyValuePair<int, object>>.GetHashCode
	|
	|-RVA: 0x2BBF714 Offset: 0x2BBB714 VA: 0x2BBF714
	|-ObjectComparer<KeyValuePair<Int32Enum, byte>>.GetHashCode
	|
	|-RVA: 0x2BBF898 Offset: 0x2BBB898 VA: 0x2BBF898
	|-ObjectComparer<KeyValuePair<Int32Enum, EnhanceProperties2>>.GetHashCode
	|
	|-RVA: 0x2BBFA04 Offset: 0x2BBBA04 VA: 0x2BBFA04
	|-ObjectComparer<KeyValuePair<Int32Enum, int>>.GetHashCode
	|
	|-RVA: 0x2BBFB80 Offset: 0x2BBBB80 VA: 0x2BBFB80
	|-ObjectComparer<KeyValuePair<Int32Enum, object>>.GetHashCode
	|
	|-RVA: 0x2BBFCFC Offset: 0x2BBBCFC VA: 0x2BBFCFC
	|-ObjectComparer<KeyValuePair<object, int>>.GetHashCode
	|
	|-RVA: 0x2BBFE78 Offset: 0x2BBBE78 VA: 0x2BBFE78
	|-ObjectComparer<KeyValuePair<object, float>>.GetHashCode
	|
	|-RVA: 0x2BBFFF4 Offset: 0x2BBBFF4 VA: 0x2BBFFF4
	|-ObjectComparer<KeyValuePair<float, object>>.GetHashCode
	|
	|-RVA: 0x2BC0168 Offset: 0x2BBC168 VA: 0x2BC0168
	|-ObjectComparer<Nullable<UIMobPropertyLabel.IconValue>>.GetHashCode
	|
	|-RVA: 0x2BC02E4 Offset: 0x2BBC2E4 VA: 0x2BC02E4
	|-ObjectComparer<StructMultiKey<object, object>>.GetHashCode
	|
	|-RVA: 0x2BC0450 Offset: 0x2BBC450 VA: 0x2BC0450
	|-ObjectComparer<ValueTuple<bool>>.GetHashCode
	|
	|-RVA: 0x2BC05BC Offset: 0x2BBC5BC VA: 0x2BC05BC
	|-ObjectComparer<ValueTuple<short, short>>.GetHashCode
	|
	|-RVA: 0x2BC0728 Offset: 0x2BBC728 VA: 0x2BC0728
	|-ObjectComparer<ValueTuple<int, int>>.GetHashCode
	|
	|-RVA: 0x2BC08A4 Offset: 0x2BBC8A4 VA: 0x2BC08A4
	|-ObjectComparer<ValueTuple<int, object>>.GetHashCode
	|
	|-RVA: 0x2BC0A10 Offset: 0x2BBCA10 VA: 0x2BC0A10
	|-ObjectComparer<ValueTuple<Int32Enum, float>>.GetHashCode
	|
	|-RVA: 0x2BC0B94 Offset: 0x2BBCB94 VA: 0x2BC0B94
	|-ObjectComparer<ValueTuple<Vector3, Vector3>>.GetHashCode
	|
	|-RVA: 0x2BC0D00 Offset: 0x2BBCD00 VA: 0x2BC0D00
	|-ObjectComparer<ArchetypeUid>.GetHashCode
	|
	|-RVA: 0x2BC0E74 Offset: 0x2BBCE74 VA: 0x2BC0E74
	|-ObjectComparer<bool>.GetHashCode
	|
	|-RVA: 0x2BC0FE0 Offset: 0x2BBCFE0 VA: 0x2BC0FE0
	|-ObjectComparer<byte>.GetHashCode
	|
	|-RVA: 0x2BC114C Offset: 0x2BBD14C VA: 0x2BC114C
	|-ObjectComparer<ByteEnum>.GetHashCode
	|
	|-RVA: 0x2BC12B8 Offset: 0x2BBD2B8 VA: 0x2BC12B8
	|-ObjectComparer<char>.GetHashCode
	|
	|-RVA: 0x2BC145C Offset: 0x2BBD45C VA: 0x2BC145C
	|-ObjectComparer<Color>.GetHashCode
	|
	|-RVA: 0x2BC15C8 Offset: 0x2BBD5C8 VA: 0x2BC15C8
	|-ObjectComparer<Color32>.GetHashCode
	|
	|-RVA: 0x2BC1734 Offset: 0x2BBD734 VA: 0x2BC1734
	|-ObjectComparer<DateTime>.GetHashCode
	|
	|-RVA: 0x2BC18B0 Offset: 0x2BBD8B0 VA: 0x2BC18B0
	|-ObjectComparer<DateTimeOffset>.GetHashCode
	|
	|-RVA: 0x2BC1A54 Offset: 0x2BBDA54 VA: 0x2BC1A54
	|-ObjectComparer<Decimal>.GetHashCode
	|
	|-RVA: 0x2BC1BC0 Offset: 0x2BBDBC0 VA: 0x2BC1BC0
	|-ObjectComparer<DefencePoint2>.GetHashCode
	|
	|-RVA: 0x2BC1D2C Offset: 0x2BBDD2C VA: 0x2BC1D2C
	|-ObjectComparer<double>.GetHashCode
	|
	|-RVA: 0x2BC1EA8 Offset: 0x2BBDEA8 VA: 0x2BC1EA8
	|-ObjectComparer<EventSummary>.GetHashCode
	|
	|-RVA: 0x2BC2014 Offset: 0x2BBE014 VA: 0x2BC2014
	|-ObjectComparer<short>.GetHashCode
	|
	|-RVA: 0x2BC2180 Offset: 0x2BBE180 VA: 0x2BC2180
	|-ObjectComparer<Int16Enum>.GetHashCode
	|
	|-RVA: 0x2BC22EC Offset: 0x2BBE2EC VA: 0x2BC22EC
	|-ObjectComparer<int>.GetHashCode
	|
	|-RVA: 0x2BC2458 Offset: 0x2BBE458 VA: 0x2BC2458
	|-ObjectComparer<Int32Enum>.GetHashCode
	|
	|-RVA: 0x2BC25C4 Offset: 0x2BBE5C4 VA: 0x2BC25C4
	|-ObjectComparer<long>.GetHashCode
	|
	|-RVA: 0x2BC2730 Offset: 0x2BBE730 VA: 0x2BC2730
	|-ObjectComparer<IntPtr>.GetHashCode
	|
	|-RVA: 0x2BC28AC Offset: 0x2BBE8AC VA: 0x2BC28AC
	|-ObjectComparer<InterpretedFrameInfo>.GetHashCode
	|
	|-RVA: 0x2BC2A30 Offset: 0x2BBEA30 VA: 0x2BC2A30
	|-ObjectComparer<JsonPosition>.GetHashCode
	|
	|-RVA: 0x2BC2BAC Offset: 0x2BBEBAC VA: 0x2BC2BAC
	|-ObjectComparer<MaterialSearchData>.GetHashCode
	|
	|-RVA: 0x2BC2D30 Offset: 0x2BBED30 VA: 0x2BC2D30
	|-ObjectComparer<MobActionTargetData>.GetHashCode
	|
	|-RVA: 0x2BC2EB4 Offset: 0x2BBEEB4 VA: 0x2BC2EB4
	|-ObjectComparer<MobIconLabelData>.GetHashCode
	|
	|-RVA: 0x2BC2FD4 Offset: 0x2BBEFD4 VA: 0x2BC2FD4
	|-ObjectComparer<object>.GetHashCode
	|
	|-RVA: 0x2BC3158 Offset: 0x2BBF158 VA: 0x2BC3158
	|-ObjectComparer<PlayerLoopSystem>.GetHashCode
	|
	|-RVA: 0x2BC32DC Offset: 0x2BBF2DC VA: 0x2BC32DC
	|-ObjectComparer<PlayerLoopSystemInternal>.GetHashCode
	|
	|-RVA: 0x2BC3458 Offset: 0x2BBF458 VA: 0x2BC3458
	|-ObjectComparer<RangePositionInfo>.GetHashCode
	|
	|-RVA: 0x2BC35DC Offset: 0x2BBF5DC VA: 0x2BC35DC
	|-ObjectComparer<RaycastHit>.GetHashCode
	|
	|-RVA: 0x2BC3760 Offset: 0x2BBF760 VA: 0x2BC3760
	|-ObjectComparer<ReinforceCristaData>.GetHashCode
	|
	|-RVA: 0x2BC38CC Offset: 0x2BBF8CC VA: 0x2BC38CC
	|-ObjectComparer<sbyte>.GetHashCode
	|
	|-RVA: 0x2BC3A38 Offset: 0x2BBFA38 VA: 0x2BC3A38
	|-ObjectComparer<float>.GetHashCode
	|
	|-RVA: 0x2BC3BA4 Offset: 0x2BBFBA4 VA: 0x2BC3BA4
	|-ObjectComparer<SkillIdData>.GetHashCode
	|
	|-RVA: 0x2BC3D10 Offset: 0x2BBFD10 VA: 0x2BC3D10
	|-ObjectComparer<TimeSpan>.GetHashCode
	|
	|-RVA: 0x2BC3E7C Offset: 0x2BBFE7C VA: 0x2BC3E7C
	|-ObjectComparer<ushort>.GetHashCode
	|
	|-RVA: 0x2BC3FE8 Offset: 0x2BBFFE8 VA: 0x2BC3FE8
	|-ObjectComparer<uint>.GetHashCode
	|
	|-RVA: 0x2BC4154 Offset: 0x2BC0154 VA: 0x2BC4154
	|-ObjectComparer<ulong>.GetHashCode
	|
	|-RVA: 0x2BC42D0 Offset: 0x2BC02D0 VA: 0x2BC42D0
	|-ObjectComparer<Vector2>.GetHashCode
	|
	|-RVA: 0x2BC4464 Offset: 0x2BC0464 VA: 0x2BC4464
	|-ObjectComparer<Vector3>.GetHashCode
	|
	|-RVA: 0x2BC45E0 Offset: 0x2BC05E0 VA: 0x2BC45E0
	|-ObjectComparer<X509ChainStatus>.GetHashCode
	|
	|-RVA: 0x2BC47F8 Offset: 0x2BC07F8 VA: 0x2BC47F8
	|-ObjectComparer<__Il2CppFullySharedGenericType>.GetHashCode
	|
	|-RVA: 0x2BC4978 Offset: 0x2BC0978 VA: 0x2BC4978
	|-ObjectComparer<BeforeRenderHelper.OrderBlock>.GetHashCode
	|
	|-RVA: 0x2BC4AFC Offset: 0x2BC0AFC VA: 0x2BC4AFC
	|-ObjectComparer<BoneClip.MotionKeyFrame>.GetHashCode
	|
	|-RVA: 0x2BC4C80 Offset: 0x2BC0C80 VA: 0x2BC4C80
	|-ObjectComparer<HouseRecipeManager.RecipeData>.GetHashCode
	|
	|-RVA: 0x2BC4DEC Offset: 0x2BC0DEC VA: 0x2BC4DEC
	|-ObjectComparer<KadarElexioBuf.SkillIdData>.GetHashCode
	|
	|-RVA: 0x2BC4F70 Offset: 0x2BC0F70 VA: 0x2BC4F70
	|-ObjectComparer<MissionTextManagerData.CheckIKeywordtemData>.GetHashCode
	|
	|-RVA: 0x2BC50F4 Offset: 0x2BC10F4 VA: 0x2BC50F4
	|-ObjectComparer<MissionTextManagerData.PickUpFieldData>.GetHashCode
	|
	|-RVA: 0x2BC5270 Offset: 0x2BC1270 VA: 0x2BC5270
	|-ObjectComparer<MobaRoomData.MobaAbilityMasterData>.GetHashCode
	|
	|-RVA: 0x2BC53E4 Offset: 0x2BC13E4 VA: 0x2BC53E4
	|-ObjectComparer<NewWaveRoomData.Spotlight>.GetHashCode
	|
	|-RVA: 0x2BC5560 Offset: 0x2BC1560 VA: 0x2BC5560
	|-ObjectComparer<NguiDynamicFontController.ApplyTextureInfo>.GetHashCode
	|
	|-RVA: 0x2BC56CC Offset: 0x2BC16CC VA: 0x2BC56CC
	|-ObjectComparer<RegexCharClass.SingleRange>.GetHashCode
	|
	|-RVA: 0x2BC5848 Offset: 0x2BC1848 VA: 0x2BC5848
	|-ObjectComparer<SocialAchievementData.LinkData>.GetHashCode
	|
	|-RVA: 0x2BC59B4 Offset: 0x2BC19B4 VA: 0x2BC59B4
	|-ObjectComparer<TrophyManager.TrophyData>.GetHashCode
	|
	|-RVA: 0x2BC5B38 Offset: 0x2BC1B38 VA: 0x2BC5B38
	|-ObjectComparer<UIEventMenuButton.MessageButtonData>.GetHashCode
	|
	|-RVA: 0x2BC5CAC Offset: 0x2BC1CAC VA: 0x2BC5CAC
	|-ObjectComparer<UIFieldMapPanel.PopData>.GetHashCode
	|
	|-RVA: 0x2BC5E18 Offset: 0x2BC1E18 VA: 0x2BC5E18
	|-ObjectComparer<UIHouseAddressManager.Town>.GetHashCode
	|
	|-RVA: 0x2BC5F8C Offset: 0x2BC1F8C VA: 0x2BC5F8C
	|-ObjectComparer<UIInfoWindow.LabelPosition>.GetHashCode
	|
	|-RVA: 0x2BC60F8 Offset: 0x2BC20F8 VA: 0x2BC60F8
	|-ObjectComparer<UIMainManager.DropItemData>.GetHashCode
	|
	|-RVA: 0x2BC6274 Offset: 0x2BC2274 VA: 0x2BC6274
	|-ObjectComparer<UIScenarioOrderPanel.MissionData>.GetHashCode
	|
	|-RVA: 0x2BC63F8 Offset: 0x2BC23F8 VA: 0x2BC63F8
	|-ObjectComparer<UnitySynchronizationContext.WorkRequest>.GetHashCode
	|
	|-RVA: 0x2BC6574 Offset: 0x2BC2574 VA: 0x2BC6574
	|-ObjectComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.GetHashCode
	|
	|-RVA: 0x2BC66E8 Offset: 0x2BC26E8 VA: 0x2BC66E8
	|-ObjectComparer<BounceParabolaAttackPattern.TargetData.BoundLineData>.GetHashCode
	|
	|-RVA: 0x2BC685C Offset: 0x2BC285C VA: 0x2BC685C
	|-ObjectComparer<InstructionList.DebugView.InstructionView>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BBEBBC Offset: 0x2BBABBC VA: 0x2BBEBBC
	|-ObjectComparer<KeyValuePair<ArchetypeUid, object>>..ctor
	|
	|-RVA: 0x2BBED28 Offset: 0x2BBAD28 VA: 0x2BBED28
	|-ObjectComparer<KeyValuePair<byte, BlackKnightCristaProperty>>..ctor
	|
	|-RVA: 0x2BBEE94 Offset: 0x2BBAE94 VA: 0x2BBEE94
	|-ObjectComparer<KeyValuePair<byte, byte>>..ctor
	|
	|-RVA: 0x2BBF010 Offset: 0x2BBB010 VA: 0x2BBF010
	|-ObjectComparer<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x2BBF18C Offset: 0x2BBB18C VA: 0x2BBF18C
	|-ObjectComparer<KeyValuePair<double, int>>..ctor
	|
	|-RVA: 0x2BBF2F8 Offset: 0x2BBB2F8 VA: 0x2BBF2F8
	|-ObjectComparer<KeyValuePair<int, short>>..ctor
	|
	|-RVA: 0x2BBF464 Offset: 0x2BBB464 VA: 0x2BBF464
	|-ObjectComparer<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x2BBF5E0 Offset: 0x2BBB5E0 VA: 0x2BBF5E0
	|-ObjectComparer<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2BBF74C Offset: 0x2BBB74C VA: 0x2BBF74C
	|-ObjectComparer<KeyValuePair<Int32Enum, byte>>..ctor
	|
	|-RVA: 0x2BBF8D0 Offset: 0x2BBB8D0 VA: 0x2BBF8D0
	|-ObjectComparer<KeyValuePair<Int32Enum, EnhanceProperties2>>..ctor
	|
	|-RVA: 0x2BBFA3C Offset: 0x2BBBA3C VA: 0x2BBFA3C
	|-ObjectComparer<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2BBFBB8 Offset: 0x2BBBBB8 VA: 0x2BBFBB8
	|-ObjectComparer<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x2BBFD34 Offset: 0x2BBBD34 VA: 0x2BBFD34
	|-ObjectComparer<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x2BBFEB0 Offset: 0x2BBBEB0 VA: 0x2BBFEB0
	|-ObjectComparer<KeyValuePair<object, float>>..ctor
	|
	|-RVA: 0x2BC002C Offset: 0x2BBC02C VA: 0x2BC002C
	|-ObjectComparer<KeyValuePair<float, object>>..ctor
	|
	|-RVA: 0x2BC01A0 Offset: 0x2BBC1A0 VA: 0x2BC01A0
	|-ObjectComparer<Nullable<UIMobPropertyLabel.IconValue>>..ctor
	|
	|-RVA: 0x2BC031C Offset: 0x2BBC31C VA: 0x2BC031C
	|-ObjectComparer<StructMultiKey<object, object>>..ctor
	|
	|-RVA: 0x2BC0488 Offset: 0x2BBC488 VA: 0x2BC0488
	|-ObjectComparer<ValueTuple<bool>>..ctor
	|
	|-RVA: 0x2BC05F4 Offset: 0x2BBC5F4 VA: 0x2BC05F4
	|-ObjectComparer<ValueTuple<short, short>>..ctor
	|
	|-RVA: 0x2BC0760 Offset: 0x2BBC760 VA: 0x2BC0760
	|-ObjectComparer<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2BC08DC Offset: 0x2BBC8DC VA: 0x2BC08DC
	|-ObjectComparer<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x2BC0A48 Offset: 0x2BBCA48 VA: 0x2BC0A48
	|-ObjectComparer<ValueTuple<Int32Enum, float>>..ctor
	|
	|-RVA: 0x2BC0BCC Offset: 0x2BBCBCC VA: 0x2BC0BCC
	|-ObjectComparer<ValueTuple<Vector3, Vector3>>..ctor
	|
	|-RVA: 0x2BC0D38 Offset: 0x2BBCD38 VA: 0x2BC0D38
	|-ObjectComparer<ArchetypeUid>..ctor
	|
	|-RVA: 0x2BC0EAC Offset: 0x2BBCEAC VA: 0x2BC0EAC
	|-ObjectComparer<bool>..ctor
	|
	|-RVA: 0x2BC1018 Offset: 0x2BBD018 VA: 0x2BC1018
	|-ObjectComparer<byte>..ctor
	|
	|-RVA: 0x2BC1184 Offset: 0x2BBD184 VA: 0x2BC1184
	|-ObjectComparer<ByteEnum>..ctor
	|
	|-RVA: 0x2BC12F0 Offset: 0x2BBD2F0 VA: 0x2BC12F0
	|-ObjectComparer<char>..ctor
	|
	|-RVA: 0x2BC1494 Offset: 0x2BBD494 VA: 0x2BC1494
	|-ObjectComparer<Color>..ctor
	|
	|-RVA: 0x2BC1600 Offset: 0x2BBD600 VA: 0x2BC1600
	|-ObjectComparer<Color32>..ctor
	|
	|-RVA: 0x2BC176C Offset: 0x2BBD76C VA: 0x2BC176C
	|-ObjectComparer<DateTime>..ctor
	|
	|-RVA: 0x2BC18E8 Offset: 0x2BBD8E8 VA: 0x2BC18E8
	|-ObjectComparer<DateTimeOffset>..ctor
	|
	|-RVA: 0x2BC1A8C Offset: 0x2BBDA8C VA: 0x2BC1A8C
	|-ObjectComparer<Decimal>..ctor
	|
	|-RVA: 0x2BC1BF8 Offset: 0x2BBDBF8 VA: 0x2BC1BF8
	|-ObjectComparer<DefencePoint2>..ctor
	|
	|-RVA: 0x2BC1D64 Offset: 0x2BBDD64 VA: 0x2BC1D64
	|-ObjectComparer<double>..ctor
	|
	|-RVA: 0x2BC1EE0 Offset: 0x2BBDEE0 VA: 0x2BC1EE0
	|-ObjectComparer<EventSummary>..ctor
	|
	|-RVA: 0x2BC204C Offset: 0x2BBE04C VA: 0x2BC204C
	|-ObjectComparer<short>..ctor
	|
	|-RVA: 0x2BC21B8 Offset: 0x2BBE1B8 VA: 0x2BC21B8
	|-ObjectComparer<Int16Enum>..ctor
	|
	|-RVA: 0x2BC2324 Offset: 0x2BBE324 VA: 0x2BC2324
	|-ObjectComparer<int>..ctor
	|
	|-RVA: 0x2BC2490 Offset: 0x2BBE490 VA: 0x2BC2490
	|-ObjectComparer<Int32Enum>..ctor
	|
	|-RVA: 0x2BC25FC Offset: 0x2BBE5FC VA: 0x2BC25FC
	|-ObjectComparer<long>..ctor
	|
	|-RVA: 0x2BC2768 Offset: 0x2BBE768 VA: 0x2BC2768
	|-ObjectComparer<IntPtr>..ctor
	|
	|-RVA: 0x2BC28E4 Offset: 0x2BBE8E4 VA: 0x2BC28E4
	|-ObjectComparer<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x2BC2A68 Offset: 0x2BBEA68 VA: 0x2BC2A68
	|-ObjectComparer<JsonPosition>..ctor
	|
	|-RVA: 0x2BC2BE4 Offset: 0x2BBEBE4 VA: 0x2BC2BE4
	|-ObjectComparer<MaterialSearchData>..ctor
	|
	|-RVA: 0x2BC2D68 Offset: 0x2BBED68 VA: 0x2BC2D68
	|-ObjectComparer<MobActionTargetData>..ctor
	|
	|-RVA: 0x2BC2EEC Offset: 0x2BBEEEC VA: 0x2BC2EEC
	|-ObjectComparer<MobIconLabelData>..ctor
	|
	|-RVA: 0x2BC300C Offset: 0x2BBF00C VA: 0x2BC300C
	|-ObjectComparer<object>..ctor
	|
	|-RVA: 0x2BC3190 Offset: 0x2BBF190 VA: 0x2BC3190
	|-ObjectComparer<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x2BC3314 Offset: 0x2BBF314 VA: 0x2BC3314
	|-ObjectComparer<PlayerLoopSystemInternal>..ctor
	|
	|-RVA: 0x2BC3490 Offset: 0x2BBF490 VA: 0x2BC3490
	|-ObjectComparer<RangePositionInfo>..ctor
	|
	|-RVA: 0x2BC3614 Offset: 0x2BBF614 VA: 0x2BC3614
	|-ObjectComparer<RaycastHit>..ctor
	|
	|-RVA: 0x2BC3798 Offset: 0x2BBF798 VA: 0x2BC3798
	|-ObjectComparer<ReinforceCristaData>..ctor
	|
	|-RVA: 0x2BC3904 Offset: 0x2BBF904 VA: 0x2BC3904
	|-ObjectComparer<sbyte>..ctor
	|
	|-RVA: 0x2BC3A70 Offset: 0x2BBFA70 VA: 0x2BC3A70
	|-ObjectComparer<float>..ctor
	|
	|-RVA: 0x2BC3BDC Offset: 0x2BBFBDC VA: 0x2BC3BDC
	|-ObjectComparer<SkillIdData>..ctor
	|
	|-RVA: 0x2BC3D48 Offset: 0x2BBFD48 VA: 0x2BC3D48
	|-ObjectComparer<TimeSpan>..ctor
	|
	|-RVA: 0x2BC3EB4 Offset: 0x2BBFEB4 VA: 0x2BC3EB4
	|-ObjectComparer<ushort>..ctor
	|
	|-RVA: 0x2BC4020 Offset: 0x2BC0020 VA: 0x2BC4020
	|-ObjectComparer<uint>..ctor
	|
	|-RVA: 0x2BC418C Offset: 0x2BC018C VA: 0x2BC418C
	|-ObjectComparer<ulong>..ctor
	|
	|-RVA: 0x2BC4308 Offset: 0x2BC0308 VA: 0x2BC4308
	|-ObjectComparer<Vector2>..ctor
	|
	|-RVA: 0x2BC449C Offset: 0x2BC049C VA: 0x2BC449C
	|-ObjectComparer<Vector3>..ctor
	|
	|-RVA: 0x2BC4618 Offset: 0x2BC0618 VA: 0x2BC4618
	|-ObjectComparer<X509ChainStatus>..ctor
	|
	|-RVA: 0x2BC4830 Offset: 0x2BC0830 VA: 0x2BC4830
	|-ObjectComparer<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2BC49B0 Offset: 0x2BC09B0 VA: 0x2BC49B0
	|-ObjectComparer<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x2BC4B34 Offset: 0x2BC0B34 VA: 0x2BC4B34
	|-ObjectComparer<BoneClip.MotionKeyFrame>..ctor
	|
	|-RVA: 0x2BC4CB8 Offset: 0x2BC0CB8 VA: 0x2BC4CB8
	|-ObjectComparer<HouseRecipeManager.RecipeData>..ctor
	|
	|-RVA: 0x2BC4E24 Offset: 0x2BC0E24 VA: 0x2BC4E24
	|-ObjectComparer<KadarElexioBuf.SkillIdData>..ctor
	|
	|-RVA: 0x2BC4FA8 Offset: 0x2BC0FA8 VA: 0x2BC4FA8
	|-ObjectComparer<MissionTextManagerData.CheckIKeywordtemData>..ctor
	|
	|-RVA: 0x2BC512C Offset: 0x2BC112C VA: 0x2BC512C
	|-ObjectComparer<MissionTextManagerData.PickUpFieldData>..ctor
	|
	|-RVA: 0x2BC52A8 Offset: 0x2BC12A8 VA: 0x2BC52A8
	|-ObjectComparer<MobaRoomData.MobaAbilityMasterData>..ctor
	|
	|-RVA: 0x2BC541C Offset: 0x2BC141C VA: 0x2BC541C
	|-ObjectComparer<NewWaveRoomData.Spotlight>..ctor
	|
	|-RVA: 0x2BC5598 Offset: 0x2BC1598 VA: 0x2BC5598
	|-ObjectComparer<NguiDynamicFontController.ApplyTextureInfo>..ctor
	|
	|-RVA: 0x2BC5704 Offset: 0x2BC1704 VA: 0x2BC5704
	|-ObjectComparer<RegexCharClass.SingleRange>..ctor
	|
	|-RVA: 0x2BC5880 Offset: 0x2BC1880 VA: 0x2BC5880
	|-ObjectComparer<SocialAchievementData.LinkData>..ctor
	|
	|-RVA: 0x2BC59EC Offset: 0x2BC19EC VA: 0x2BC59EC
	|-ObjectComparer<TrophyManager.TrophyData>..ctor
	|
	|-RVA: 0x2BC5B70 Offset: 0x2BC1B70 VA: 0x2BC5B70
	|-ObjectComparer<UIEventMenuButton.MessageButtonData>..ctor
	|
	|-RVA: 0x2BC5CE4 Offset: 0x2BC1CE4 VA: 0x2BC5CE4
	|-ObjectComparer<UIFieldMapPanel.PopData>..ctor
	|
	|-RVA: 0x2BC5E50 Offset: 0x2BC1E50 VA: 0x2BC5E50
	|-ObjectComparer<UIHouseAddressManager.Town>..ctor
	|
	|-RVA: 0x2BC5FC4 Offset: 0x2BC1FC4 VA: 0x2BC5FC4
	|-ObjectComparer<UIInfoWindow.LabelPosition>..ctor
	|
	|-RVA: 0x2BC6130 Offset: 0x2BC2130 VA: 0x2BC6130
	|-ObjectComparer<UIMainManager.DropItemData>..ctor
	|
	|-RVA: 0x2BC62AC Offset: 0x2BC22AC VA: 0x2BC62AC
	|-ObjectComparer<UIScenarioOrderPanel.MissionData>..ctor
	|
	|-RVA: 0x2BC6430 Offset: 0x2BC2430 VA: 0x2BC6430
	|-ObjectComparer<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x2BC65AC Offset: 0x2BC25AC VA: 0x2BC65AC
	|-ObjectComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0x2BC6720 Offset: 0x2BC2720 VA: 0x2BC6720
	|-ObjectComparer<BounceParabolaAttackPattern.TargetData.BoundLineData>..ctor
	|
	|-RVA: 0x2BC6894 Offset: 0x2BC2894 VA: 0x2BC6894
	|-ObjectComparer<InstructionList.DebugView.InstructionView>..ctor
	*/
}
