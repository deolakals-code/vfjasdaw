// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
[IsReadOnly]
[Serializable]
public struct KeyValuePair<TKey, TValue> // TypeDefIndex: 10947
{
	// Fields
	private readonly TKey key; // 0x0
	private readonly TValue value; // 0x0

	// Properties
	public TKey Key { get; }
	public TValue Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9D31C Offset: 0x2A9931C VA: 0x2A9D31C
	|-KeyValuePair<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2A9D404 Offset: 0x2A99404 VA: 0x2A9D404
	|-KeyValuePair<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x2A9D4E4 Offset: 0x2A994E4 VA: 0x2A9D4E4
	|-KeyValuePair<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x2A9D5C4 Offset: 0x2A995C4 VA: 0x2A9D5C4
	|-KeyValuePair<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0x2A9D6A4 Offset: 0x2A996A4 VA: 0x2A9D6A4
	|-KeyValuePair<ArchetypeUid, int>..ctor
	|
	|-RVA: 0x2A9D790 Offset: 0x2A99790 VA: 0x2A9D790
	|-KeyValuePair<ArchetypeUid, object>..ctor
	|
	|-RVA: 0x2A9D840 Offset: 0x2A99840 VA: 0x2A9D840
	|-KeyValuePair<byte, ValueTuple<short, int, int>>..ctor
	|
	|-RVA: 0x2A9D940 Offset: 0x2A99940 VA: 0x2A9D940
	|-KeyValuePair<byte, BlackKnightAvatarProperty>..ctor
	|
	|-RVA: 0x2A9DA40 Offset: 0x2A99A40 VA: 0x2A9DA40
	|-KeyValuePair<byte, BlackKnightCristaProperty>..ctor
	|
	|-RVA: 0x2A9DB44 Offset: 0x2A99B44 VA: 0x2A9DB44
	|-KeyValuePair<byte, byte>..ctor
	|
	|-RVA: 0x2A9DC30 Offset: 0x2A99C30 VA: 0x2A9DC30
	|-KeyValuePair<byte, CardData>..ctor
	|
	|-RVA: 0x2A9DD30 Offset: 0x2A99D30 VA: 0x2A9DD30
	|-KeyValuePair<byte, short>..ctor
	|
	|-RVA: 0x2A9DE1C Offset: 0x2A99E1C VA: 0x2A9DE1C
	|-KeyValuePair<byte, int>..ctor
	|
	|-RVA: 0x2A9DF08 Offset: 0x2A99F08 VA: 0x2A9DF08
	|-KeyValuePair<byte, long>..ctor
	|
	|-RVA: 0x2A9DFF4 Offset: 0x2A99FF4 VA: 0x2A9DFF4
	|-KeyValuePair<byte, object>..ctor
	|
	|-RVA: 0x2A9E0A4 Offset: 0x2A9A0A4 VA: 0x2A9E0A4
	|-KeyValuePair<byte, float>..ctor
	|
	|-RVA: 0x2A9E190 Offset: 0x2A9A190 VA: 0x2A9E190
	|-KeyValuePair<byte, MasterModelDataManager.ConvertCommonMaterialData>..ctor
	|
	|-RVA: 0x2A9E27C Offset: 0x2A9A27C VA: 0x2A9E27C
	|-KeyValuePair<ByteEnum, object>..ctor
	|
	|-RVA: 0x2A9E32C Offset: 0x2A9A32C VA: 0x2A9E32C
	|-KeyValuePair<char, char>..ctor
	|
	|-RVA: 0x2A9E418 Offset: 0x2A9A418 VA: 0x2A9E418
	|-KeyValuePair<DefencePoint2, byte>..ctor
	|
	|-RVA: 0x2A9E504 Offset: 0x2A9A504 VA: 0x2A9E504
	|-KeyValuePair<double, int>..ctor
	|
	|-RVA: 0x2A9E5F0 Offset: 0x2A9A5F0 VA: 0x2A9E5F0
	|-KeyValuePair<Guid, object>..ctor
	|
	|-RVA: 0x2A9E6AC Offset: 0x2A9A6AC VA: 0x2A9E6AC
	|-KeyValuePair<short, byte>..ctor
	|
	|-RVA: 0x2A9E798 Offset: 0x2A9A798 VA: 0x2A9E798
	|-KeyValuePair<short, short>..ctor
	|
	|-RVA: 0x2A9E884 Offset: 0x2A9A884 VA: 0x2A9E884
	|-KeyValuePair<short, int>..ctor
	|
	|-RVA: 0x2A9E970 Offset: 0x2A9A970 VA: 0x2A9E970
	|-KeyValuePair<short, object>..ctor
	|
	|-RVA: 0x2A9EA20 Offset: 0x2A9AA20 VA: 0x2A9EA20
	|-KeyValuePair<Int16Enum, bool>..ctor
	|
	|-RVA: 0x2A9EB10 Offset: 0x2A9AB10 VA: 0x2A9EB10
	|-KeyValuePair<Int16Enum, int>..ctor
	|
	|-RVA: 0x2A9EBFC Offset: 0x2A9ABFC VA: 0x2A9EBFC
	|-KeyValuePair<Int16Enum, object>..ctor
	|
	|-RVA: 0x2A9ECAC Offset: 0x2A9ACAC VA: 0x2A9ECAC
	|-KeyValuePair<int, bool>..ctor
	|
	|-RVA: 0x2A9ED9C Offset: 0x2A9AD9C VA: 0x2A9ED9C
	|-KeyValuePair<int, byte>..ctor
	|
	|-RVA: 0x2A9EE88 Offset: 0x2A9AE88 VA: 0x2A9EE88
	|-KeyValuePair<int, Color>..ctor
	|
	|-RVA: 0x2A9EF7C Offset: 0x2A9AF7C VA: 0x2A9EF7C
	|-KeyValuePair<int, short>..ctor
	|
	|-RVA: 0x2A9F068 Offset: 0x2A9B068 VA: 0x2A9F068
	|-KeyValuePair<int, int>..ctor
	|
	|-RVA: 0x2A9F150 Offset: 0x2A9B150 VA: 0x2A9F150
	|-KeyValuePair<int, Int32Enum>..ctor
	|
	|-RVA: 0x2A9F238 Offset: 0x2A9B238 VA: 0x2A9F238
	|-KeyValuePair<int, long>..ctor
	|
	|-RVA: 0x2A9F324 Offset: 0x2A9B324 VA: 0x2A9F324
	|-KeyValuePair<int, MaterialSearchData>..ctor
	|
	|-RVA: 0x2A9F420 Offset: 0x2A9B420 VA: 0x2A9F420
	|-KeyValuePair<int, object>..ctor
	|
	|-RVA: 0x2A9F4D0 Offset: 0x2A9B4D0 VA: 0x2A9F4D0
	|-KeyValuePair<int, RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x2A9F5CC Offset: 0x2A9B5CC VA: 0x2A9F5CC
	|-KeyValuePair<int, float>..ctor
	|
	|-RVA: 0x2A9F6B8 Offset: 0x2A9B6B8 VA: 0x2A9F6B8
	|-KeyValuePair<int, Vector2>..ctor
	|
	|-RVA: 0x2A9F7A4 Offset: 0x2A9B7A4 VA: 0x2A9F7A4
	|-KeyValuePair<int, Vector3>..ctor
	|
	|-RVA: 0x2A9F8A0 Offset: 0x2A9B8A0 VA: 0x2A9F8A0
	|-KeyValuePair<int, Vector4>..ctor
	|
	|-RVA: 0x2A9F994 Offset: 0x2A9B994 VA: 0x2A9F994
	|-KeyValuePair<int, HouseRecipeManager.RecipeData>..ctor
	|
	|-RVA: 0x2A9FAAC Offset: 0x2A9BAAC VA: 0x2A9FAAC
	|-KeyValuePair<int, MasterModelDataManager.ColorListData>..ctor
	|
	|-RVA: 0x2A9FBC4 Offset: 0x2A9BBC4 VA: 0x2A9FBC4
	|-KeyValuePair<int, UIGuildQuestBoardManager.GuildQuestMaseter>..ctor
	|
	|-RVA: 0x2A9FCD8 Offset: 0x2A9BCD8 VA: 0x2A9FCD8
	|-KeyValuePair<Int32Enum, ArchetypeUid>..ctor
	|
	|-RVA: 0x2A9FDC4 Offset: 0x2A9BDC4 VA: 0x2A9FDC4
	|-KeyValuePair<Int32Enum, bool>..ctor
	|
	|-RVA: 0x2A9FEB4 Offset: 0x2A9BEB4 VA: 0x2A9FEB4
	|-KeyValuePair<Int32Enum, byte>..ctor
	|
	|-RVA: 0x2A9FFA0 Offset: 0x2A9BFA0 VA: 0x2A9FFA0
	|-KeyValuePair<Int32Enum, Color>..ctor
	|
	|-RVA: 0x2AA0094 Offset: 0x2A9C094 VA: 0x2AA0094
	|-KeyValuePair<Int32Enum, DateTime>..ctor
	|
	|-RVA: 0x2AA0180 Offset: 0x2A9C180 VA: 0x2AA0180
	|-KeyValuePair<Int32Enum, EnhanceProperties2>..ctor
	|
	|-RVA: 0x2AA0298 Offset: 0x2A9C298 VA: 0x2AA0298
	|-KeyValuePair<Int32Enum, short>..ctor
	|
	|-RVA: 0x2AA0384 Offset: 0x2A9C384 VA: 0x2AA0384
	|-KeyValuePair<Int32Enum, int>..ctor
	|
	|-RVA: 0x2AA046C Offset: 0x2A9C46C VA: 0x2AA046C
	|-KeyValuePair<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x2AA0554 Offset: 0x2A9C554 VA: 0x2AA0554
	|-KeyValuePair<Int32Enum, long>..ctor
	|
	|-RVA: 0x2AA0640 Offset: 0x2A9C640 VA: 0x2AA0640
	|-KeyValuePair<Int32Enum, Int64Enum>..ctor
	|
	|-RVA: 0x2AA072C Offset: 0x2A9C72C VA: 0x2AA072C
	|-KeyValuePair<Int32Enum, object>..ctor
	|
	|-RVA: 0x2AA07DC Offset: 0x2A9C7DC VA: 0x2AA07DC
	|-KeyValuePair<Int32Enum, float>..ctor
	|
	|-RVA: 0x2AA08C8 Offset: 0x2A9C8C8 VA: 0x2AA08C8
	|-KeyValuePair<Int32Enum, Vector3>..ctor
	|
	|-RVA: 0x2AA09C4 Offset: 0x2A9C9C4 VA: 0x2AA09C4
	|-KeyValuePair<Int32Enum, MasterModelDataManager.ColorListData>..ctor
	|
	|-RVA: 0x2AA0ADC Offset: 0x2A9CADC VA: 0x2AA0ADC
	|-KeyValuePair<long, bool>..ctor
	|
	|-RVA: 0x2AA0BCC Offset: 0x2A9CBCC VA: 0x2AA0BCC
	|-KeyValuePair<long, byte>..ctor
	|
	|-RVA: 0x2AA0CB8 Offset: 0x2A9CCB8 VA: 0x2AA0CB8
	|-KeyValuePair<long, short>..ctor
	|
	|-RVA: 0x2AA0DA4 Offset: 0x2A9CDA4 VA: 0x2AA0DA4
	|-KeyValuePair<long, object>..ctor
	|
	|-RVA: 0x2AA0E54 Offset: 0x2A9CE54 VA: 0x2AA0E54
	|-KeyValuePair<Int64Enum, Int32Enum>..ctor
	|
	|-RVA: 0x2AA0F40 Offset: 0x2A9CF40 VA: 0x2AA0F40
	|-KeyValuePair<Int64Enum, object>..ctor
	|
	|-RVA: 0x2AA0FF0 Offset: 0x2A9CFF0 VA: 0x2AA0FF0
	|-KeyValuePair<IntPtr, object>..ctor
	|
	|-RVA: 0x2AA10A0 Offset: 0x2A9D0A0 VA: 0x2AA10A0
	|-KeyValuePair<object, ValueTuple<object, byte>>..ctor
	|
	|-RVA: 0x2AA1188 Offset: 0x2A9D188 VA: 0x2AA1188
	|-KeyValuePair<object, ValueTuple<float, object>>..ctor
	|
	|-RVA: 0x2AA1270 Offset: 0x2A9D270 VA: 0x2AA1270
	|-KeyValuePair<object, bool>..ctor
	|
	|-RVA: 0x2AA1344 Offset: 0x2A9D344 VA: 0x2AA1344
	|-KeyValuePair<object, byte>..ctor
	|
	|-RVA: 0x2AA1418 Offset: 0x2A9D418 VA: 0x2AA1418
	|-KeyValuePair<object, short>..ctor
	|
	|-RVA: 0x2AA14EC Offset: 0x2A9D4EC VA: 0x2AA14EC
	|-KeyValuePair<object, int>..ctor
	|
	|-RVA: 0x2AA15C0 Offset: 0x2A9D5C0 VA: 0x2AA15C0
	|-KeyValuePair<object, Int32Enum>..ctor
	|
	|-RVA: 0x2AA1694 Offset: 0x2A9D694 VA: 0x2AA1694
	|-KeyValuePair<object, object>..ctor
	|
	|-RVA: 0x2AA1730 Offset: 0x2A9D730 VA: 0x2AA1730
	|-KeyValuePair<object, ResourceLocator>..ctor
	|
	|-RVA: 0x2AA1818 Offset: 0x2A9D818 VA: 0x2AA1818
	|-KeyValuePair<object, float>..ctor
	|
	|-RVA: 0x2AA18EC Offset: 0x2A9D8EC VA: 0x2AA18EC
	|-KeyValuePair<object, Vector3>..ctor
	|
	|-RVA: 0x2AA19E0 Offset: 0x2A9D9E0 VA: 0x2AA19E0
	|-KeyValuePair<object, DeathReceptionAction.PoisonTargetData>..ctor
	|
	|-RVA: 0x2AA1AC8 Offset: 0x2A9DAC8 VA: 0x2AA1AC8
	|-KeyValuePair<object, UIHouseAddressManager.Town>..ctor
	|
	|-RVA: 0x2AA1B9C Offset: 0x2A9DB9C VA: 0x2AA1B9C
	|-KeyValuePair<float, object>..ctor
	|
	|-RVA: 0x2AA1C48 Offset: 0x2A9DC48 VA: 0x2AA1C48
	|-KeyValuePair<ushort, byte>..ctor
	|
	|-RVA: 0x2AA1D34 Offset: 0x2A9DD34 VA: 0x2AA1D34
	|-KeyValuePair<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x2AA1E58 Offset: 0x2A9DE58 VA: 0x2AA1E58
	|-KeyValuePair<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2AA241C Offset: 0x2A9E41C VA: 0x2AA241C
	|-KeyValuePair<MaterialManager.pair, object>..ctor
	|
	|-RVA: 0x2AA24CC Offset: 0x2A9E4CC VA: 0x2AA24CC
	|-KeyValuePair<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x2AA25C8 Offset: 0x2A9E5C8 VA: 0x2AA25C8
	|-KeyValuePair<PartyManager.PartyData.pair, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9D324 Offset: 0x2A99324 VA: 0x2A9D324
	|-KeyValuePair<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.get_Key
	|
	|-RVA: 0x2A9D438 Offset: 0x2A99438 VA: 0x2A9D438
	|-KeyValuePair<KeyValuePair<object, object>, object>.get_Key
	|
	|-RVA: 0x2A9D518 Offset: 0x2A99518 VA: 0x2A9D518
	|-KeyValuePair<StructMultiKey<object, object>, object>.get_Key
	|
	|-RVA: 0x2A9D5F8 Offset: 0x2A995F8 VA: 0x2A9D5F8
	|-KeyValuePair<ValueTuple<object, object>, object>.get_Key
	|
	|-RVA: 0x2A9D6B0 Offset: 0x2A996B0 VA: 0x2A9D6B0
	|-KeyValuePair<ArchetypeUid, int>.get_Key
	|
	|-RVA: 0x2A9D7A0 Offset: 0x2A997A0 VA: 0x2A9D7A0
	|-KeyValuePair<ArchetypeUid, object>.get_Key
	|
	|-RVA: 0x2A9D850 Offset: 0x2A99850 VA: 0x2A9D850
	|-KeyValuePair<byte, ValueTuple<short, int, int>>.get_Key
	|
	|-RVA: 0x2A9D950 Offset: 0x2A99950 VA: 0x2A9D950
	|-KeyValuePair<byte, BlackKnightAvatarProperty>.get_Key
	|
	|-RVA: 0x2A9DA54 Offset: 0x2A99A54 VA: 0x2A9DA54
	|-KeyValuePair<byte, BlackKnightCristaProperty>.get_Key
	|
	|-RVA: 0x2A9DB50 Offset: 0x2A99B50 VA: 0x2A9DB50
	|-KeyValuePair<byte, byte>.get_Key
	|
	|-RVA: 0x2A9DC40 Offset: 0x2A99C40 VA: 0x2A9DC40
	|-KeyValuePair<byte, CardData>.get_Key
	|
	|-RVA: 0x2A9DD3C Offset: 0x2A99D3C VA: 0x2A9DD3C
	|-KeyValuePair<byte, short>.get_Key
	|
	|-RVA: 0x2A9DE28 Offset: 0x2A99E28 VA: 0x2A9DE28
	|-KeyValuePair<byte, int>.get_Key
	|
	|-RVA: 0x2A9DF14 Offset: 0x2A99F14 VA: 0x2A9DF14
	|-KeyValuePair<byte, long>.get_Key
	|
	|-RVA: 0x2A9E004 Offset: 0x2A9A004 VA: 0x2A9E004
	|-KeyValuePair<byte, object>.get_Key
	|
	|-RVA: 0x2A9E0B0 Offset: 0x2A9A0B0 VA: 0x2A9E0B0
	|-KeyValuePair<byte, float>.get_Key
	|
	|-RVA: 0x2A9E19C Offset: 0x2A9A19C VA: 0x2A9E19C
	|-KeyValuePair<byte, MasterModelDataManager.ConvertCommonMaterialData>.get_Key
	|
	|-RVA: 0x2A9E28C Offset: 0x2A9A28C VA: 0x2A9E28C
	|-KeyValuePair<ByteEnum, object>.get_Key
	|
	|-RVA: 0x2A9E338 Offset: 0x2A9A338 VA: 0x2A9E338
	|-KeyValuePair<char, char>.get_Key
	|
	|-RVA: 0x2A9E424 Offset: 0x2A9A424 VA: 0x2A9E424
	|-KeyValuePair<DefencePoint2, byte>.get_Key
	|
	|-RVA: 0x2A9E510 Offset: 0x2A9A510 VA: 0x2A9E510
	|-KeyValuePair<double, int>.get_Key
	|
	|-RVA: 0x2A9E600 Offset: 0x2A9A600 VA: 0x2A9E600
	|-KeyValuePair<Guid, object>.get_Key
	|
	|-RVA: 0x2A9E6B8 Offset: 0x2A9A6B8 VA: 0x2A9E6B8
	|-KeyValuePair<short, byte>.get_Key
	|
	|-RVA: 0x2A9E7A4 Offset: 0x2A9A7A4 VA: 0x2A9E7A4
	|-KeyValuePair<short, short>.get_Key
	|
	|-RVA: 0x2A9E890 Offset: 0x2A9A890 VA: 0x2A9E890
	|-KeyValuePair<short, int>.get_Key
	|
	|-RVA: 0x2A9E980 Offset: 0x2A9A980 VA: 0x2A9E980
	|-KeyValuePair<short, object>.get_Key
	|
	|-RVA: 0x2A9EA30 Offset: 0x2A9AA30 VA: 0x2A9EA30
	|-KeyValuePair<Int16Enum, bool>.get_Key
	|
	|-RVA: 0x2A9EB1C Offset: 0x2A9AB1C VA: 0x2A9EB1C
	|-KeyValuePair<Int16Enum, int>.get_Key
	|
	|-RVA: 0x2A9EC0C Offset: 0x2A9AC0C VA: 0x2A9EC0C
	|-KeyValuePair<Int16Enum, object>.get_Key
	|
	|-RVA: 0x2A9ECBC Offset: 0x2A9ACBC VA: 0x2A9ECBC
	|-KeyValuePair<int, bool>.get_Key
	|
	|-RVA: 0x2A9EDA8 Offset: 0x2A9ADA8 VA: 0x2A9EDA8
	|-KeyValuePair<int, byte>.get_Key
	|
	|-RVA: 0x2A9EE98 Offset: 0x2A9AE98 VA: 0x2A9EE98
	|-KeyValuePair<int, Color>.get_Key
	|
	|-RVA: 0x2A9EF88 Offset: 0x2A9AF88 VA: 0x2A9EF88
	|-KeyValuePair<int, short>.get_Key
	|
	|-RVA: 0x2A9F070 Offset: 0x2A9B070 VA: 0x2A9F070
	|-KeyValuePair<int, int>.get_Key
	|
	|-RVA: 0x2A9F158 Offset: 0x2A9B158 VA: 0x2A9F158
	|-KeyValuePair<int, Int32Enum>.get_Key
	|
	|-RVA: 0x2A9F244 Offset: 0x2A9B244 VA: 0x2A9F244
	|-KeyValuePair<int, long>.get_Key
	|
	|-RVA: 0x2A9F334 Offset: 0x2A9B334 VA: 0x2A9F334
	|-KeyValuePair<int, MaterialSearchData>.get_Key
	|
	|-RVA: 0x2A9F430 Offset: 0x2A9B430 VA: 0x2A9F430
	|-KeyValuePair<int, object>.get_Key
	|
	|-RVA: 0x2A9F4E0 Offset: 0x2A9B4E0 VA: 0x2A9F4E0
	|-KeyValuePair<int, RenderInstancedDataLayout>.get_Key
	|
	|-RVA: 0x2A9F5D8 Offset: 0x2A9B5D8 VA: 0x2A9F5D8
	|-KeyValuePair<int, float>.get_Key
	|
	|-RVA: 0x2A9F6C4 Offset: 0x2A9B6C4 VA: 0x2A9F6C4
	|-KeyValuePair<int, Vector2>.get_Key
	|
	|-RVA: 0x2A9F7B4 Offset: 0x2A9B7B4 VA: 0x2A9F7B4
	|-KeyValuePair<int, Vector3>.get_Key
	|
	|-RVA: 0x2A9F8B0 Offset: 0x2A9B8B0 VA: 0x2A9F8B0
	|-KeyValuePair<int, Vector4>.get_Key
	|
	|-RVA: 0x2A9F9B0 Offset: 0x2A9B9B0 VA: 0x2A9F9B0
	|-KeyValuePair<int, HouseRecipeManager.RecipeData>.get_Key
	|
	|-RVA: 0x2A9FAC8 Offset: 0x2A9BAC8 VA: 0x2A9FAC8
	|-KeyValuePair<int, MasterModelDataManager.ColorListData>.get_Key
	|
	|-RVA: 0x2A9FBE4 Offset: 0x2A9BBE4 VA: 0x2A9FBE4
	|-KeyValuePair<int, UIGuildQuestBoardManager.GuildQuestMaseter>.get_Key
	|
	|-RVA: 0x2A9FCE4 Offset: 0x2A9BCE4 VA: 0x2A9FCE4
	|-KeyValuePair<Int32Enum, ArchetypeUid>.get_Key
	|
	|-RVA: 0x2A9FDD4 Offset: 0x2A9BDD4 VA: 0x2A9FDD4
	|-KeyValuePair<Int32Enum, bool>.get_Key
	|
	|-RVA: 0x2A9FEC0 Offset: 0x2A9BEC0 VA: 0x2A9FEC0
	|-KeyValuePair<Int32Enum, byte>.get_Key
	|
	|-RVA: 0x2A9FFB0 Offset: 0x2A9BFB0 VA: 0x2A9FFB0
	|-KeyValuePair<Int32Enum, Color>.get_Key
	|
	|-RVA: 0x2AA00A0 Offset: 0x2A9C0A0 VA: 0x2AA00A0
	|-KeyValuePair<Int32Enum, DateTime>.get_Key
	|
	|-RVA: 0x2AA019C Offset: 0x2A9C19C VA: 0x2AA019C
	|-KeyValuePair<Int32Enum, EnhanceProperties2>.get_Key
	|
	|-RVA: 0x2AA02A4 Offset: 0x2A9C2A4 VA: 0x2AA02A4
	|-KeyValuePair<Int32Enum, short>.get_Key
	|
	|-RVA: 0x2AA038C Offset: 0x2A9C38C VA: 0x2AA038C
	|-KeyValuePair<Int32Enum, int>.get_Key
	|
	|-RVA: 0x2AA0474 Offset: 0x2A9C474 VA: 0x2AA0474
	|-KeyValuePair<Int32Enum, Int32Enum>.get_Key
	|
	|-RVA: 0x2AA0560 Offset: 0x2A9C560 VA: 0x2AA0560
	|-KeyValuePair<Int32Enum, long>.get_Key
	|
	|-RVA: 0x2AA064C Offset: 0x2A9C64C VA: 0x2AA064C
	|-KeyValuePair<Int32Enum, Int64Enum>.get_Key
	|
	|-RVA: 0x2AA073C Offset: 0x2A9C73C VA: 0x2AA073C
	|-KeyValuePair<Int32Enum, object>.get_Key
	|
	|-RVA: 0x2AA07E8 Offset: 0x2A9C7E8 VA: 0x2AA07E8
	|-KeyValuePair<Int32Enum, float>.get_Key
	|
	|-RVA: 0x2AA08D8 Offset: 0x2A9C8D8 VA: 0x2AA08D8
	|-KeyValuePair<Int32Enum, Vector3>.get_Key
	|
	|-RVA: 0x2AA09E0 Offset: 0x2A9C9E0 VA: 0x2AA09E0
	|-KeyValuePair<Int32Enum, MasterModelDataManager.ColorListData>.get_Key
	|
	|-RVA: 0x2AA0AEC Offset: 0x2A9CAEC VA: 0x2AA0AEC
	|-KeyValuePair<long, bool>.get_Key
	|
	|-RVA: 0x2AA0BD8 Offset: 0x2A9CBD8 VA: 0x2AA0BD8
	|-KeyValuePair<long, byte>.get_Key
	|
	|-RVA: 0x2AA0CC4 Offset: 0x2A9CCC4 VA: 0x2AA0CC4
	|-KeyValuePair<long, short>.get_Key
	|
	|-RVA: 0x2AA0DB4 Offset: 0x2A9CDB4 VA: 0x2AA0DB4
	|-KeyValuePair<long, object>.get_Key
	|
	|-RVA: 0x2AA0E60 Offset: 0x2A9CE60 VA: 0x2AA0E60
	|-KeyValuePair<Int64Enum, Int32Enum>.get_Key
	|
	|-RVA: 0x2AA0F50 Offset: 0x2A9CF50 VA: 0x2AA0F50
	|-KeyValuePair<Int64Enum, object>.get_Key
	|
	|-RVA: 0x2AA1000 Offset: 0x2A9D000 VA: 0x2AA1000
	|-KeyValuePair<IntPtr, object>.get_Key
	|
	|-RVA: 0x2AA10D8 Offset: 0x2A9D0D8 VA: 0x2AA10D8
	|-KeyValuePair<object, ValueTuple<object, byte>>.get_Key
	|
	|-RVA: 0x2AA11C0 Offset: 0x2A9D1C0 VA: 0x2AA11C0
	|-KeyValuePair<object, ValueTuple<float, object>>.get_Key
	|
	|-RVA: 0x2AA1298 Offset: 0x2A9D298 VA: 0x2AA1298
	|-KeyValuePair<object, bool>.get_Key
	|
	|-RVA: 0x2AA136C Offset: 0x2A9D36C VA: 0x2AA136C
	|-KeyValuePair<object, byte>.get_Key
	|
	|-RVA: 0x2AA1440 Offset: 0x2A9D440 VA: 0x2AA1440
	|-KeyValuePair<object, short>.get_Key
	|
	|-RVA: 0x2AA1514 Offset: 0x2A9D514 VA: 0x2AA1514
	|-KeyValuePair<object, int>.get_Key
	|
	|-RVA: 0x2AA15E8 Offset: 0x2A9D5E8 VA: 0x2AA15E8
	|-KeyValuePair<object, Int32Enum>.get_Key
	|
	|-RVA: 0x2AA16C4 Offset: 0x2A9D6C4 VA: 0x2AA16C4
	|-KeyValuePair<object, object>.get_Key
	|
	|-RVA: 0x2AA1768 Offset: 0x2A9D768 VA: 0x2AA1768
	|-KeyValuePair<object, ResourceLocator>.get_Key
	|
	|-RVA: 0x2AA1840 Offset: 0x2A9D840 VA: 0x2AA1840
	|-KeyValuePair<object, float>.get_Key
	|
	|-RVA: 0x2AA1928 Offset: 0x2A9D928 VA: 0x2AA1928
	|-KeyValuePair<object, Vector3>.get_Key
	|
	|-RVA: 0x2AA1A18 Offset: 0x2A9DA18 VA: 0x2AA1A18
	|-KeyValuePair<object, DeathReceptionAction.PoisonTargetData>.get_Key
	|
	|-RVA: 0x2AA1AF0 Offset: 0x2A9DAF0 VA: 0x2AA1AF0
	|-KeyValuePair<object, UIHouseAddressManager.Town>.get_Key
	|
	|-RVA: 0x2AA1BA8 Offset: 0x2A9DBA8 VA: 0x2AA1BA8
	|-KeyValuePair<float, object>.get_Key
	|
	|-RVA: 0x2AA1C54 Offset: 0x2A9DC54 VA: 0x2AA1C54
	|-KeyValuePair<ushort, byte>.get_Key
	|
	|-RVA: 0x2AA1D70 Offset: 0x2A9DD70 VA: 0x2AA1D70
	|-KeyValuePair<XPathNodeRef, XPathNodeRef>.get_Key
	|
	|-RVA: 0x2AA203C Offset: 0x2A9E03C VA: 0x2AA203C
	|-KeyValuePair<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	|
	|-RVA: 0x2AA242C Offset: 0x2A9E42C VA: 0x2AA242C
	|-KeyValuePair<MaterialManager.pair, object>.get_Key
	|
	|-RVA: 0x2AA250C Offset: 0x2A9E50C VA: 0x2AA250C
	|-KeyValuePair<Regex.CachedCodeEntryKey, object>.get_Key
	|
	|-RVA: 0x2AA25D8 Offset: 0x2A9E5D8 VA: 0x2AA25D8
	|-KeyValuePair<PartyManager.PartyData.pair, object>.get_Key
	*/

	// RVA: -1 Offset: -1
	public TValue get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9D32C Offset: 0x2A9932C VA: 0x2A9D32C
	|-KeyValuePair<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.get_Value
	|
	|-RVA: 0x2A9D444 Offset: 0x2A99444 VA: 0x2A9D444
	|-KeyValuePair<KeyValuePair<object, object>, object>.get_Value
	|
	|-RVA: 0x2A9D524 Offset: 0x2A99524 VA: 0x2A9D524
	|-KeyValuePair<StructMultiKey<object, object>, object>.get_Value
	|
	|-RVA: 0x2A9D604 Offset: 0x2A99604 VA: 0x2A9D604
	|-KeyValuePair<ValueTuple<object, object>, object>.get_Value
	|
	|-RVA: 0x2A9D6B8 Offset: 0x2A996B8 VA: 0x2A9D6B8
	|-KeyValuePair<ArchetypeUid, int>.get_Value
	|
	|-RVA: 0x2A9D7A8 Offset: 0x2A997A8 VA: 0x2A9D7A8
	|-KeyValuePair<ArchetypeUid, object>.get_Value
	|
	|-RVA: 0x2A9D858 Offset: 0x2A99858 VA: 0x2A9D858
	|-KeyValuePair<byte, ValueTuple<short, int, int>>.get_Value
	|
	|-RVA: 0x2A9D958 Offset: 0x2A99958 VA: 0x2A9D958
	|-KeyValuePair<byte, BlackKnightAvatarProperty>.get_Value
	|
	|-RVA: 0x2A9DA5C Offset: 0x2A99A5C VA: 0x2A9DA5C
	|-KeyValuePair<byte, BlackKnightCristaProperty>.get_Value
	|
	|-RVA: 0x2A9DB58 Offset: 0x2A99B58 VA: 0x2A9DB58
	|-KeyValuePair<byte, byte>.get_Value
	|
	|-RVA: 0x2A9DC48 Offset: 0x2A99C48 VA: 0x2A9DC48
	|-KeyValuePair<byte, CardData>.get_Value
	|
	|-RVA: 0x2A9DD44 Offset: 0x2A99D44 VA: 0x2A9DD44
	|-KeyValuePair<byte, short>.get_Value
	|
	|-RVA: 0x2A9DE30 Offset: 0x2A99E30 VA: 0x2A9DE30
	|-KeyValuePair<byte, int>.get_Value
	|
	|-RVA: 0x2A9DF1C Offset: 0x2A99F1C VA: 0x2A9DF1C
	|-KeyValuePair<byte, long>.get_Value
	|
	|-RVA: 0x2A9E00C Offset: 0x2A9A00C VA: 0x2A9E00C
	|-KeyValuePair<byte, object>.get_Value
	|
	|-RVA: 0x2A9E0B8 Offset: 0x2A9A0B8 VA: 0x2A9E0B8
	|-KeyValuePair<byte, float>.get_Value
	|
	|-RVA: 0x2A9E1A4 Offset: 0x2A9A1A4 VA: 0x2A9E1A4
	|-KeyValuePair<byte, MasterModelDataManager.ConvertCommonMaterialData>.get_Value
	|
	|-RVA: 0x2A9E294 Offset: 0x2A9A294 VA: 0x2A9E294
	|-KeyValuePair<ByteEnum, object>.get_Value
	|
	|-RVA: 0x2A9E340 Offset: 0x2A9A340 VA: 0x2A9E340
	|-KeyValuePair<char, char>.get_Value
	|
	|-RVA: 0x2A9E42C Offset: 0x2A9A42C VA: 0x2A9E42C
	|-KeyValuePair<DefencePoint2, byte>.get_Value
	|
	|-RVA: 0x2A9E518 Offset: 0x2A9A518 VA: 0x2A9E518
	|-KeyValuePair<double, int>.get_Value
	|
	|-RVA: 0x2A9E60C Offset: 0x2A9A60C VA: 0x2A9E60C
	|-KeyValuePair<Guid, object>.get_Value
	|
	|-RVA: 0x2A9E6C0 Offset: 0x2A9A6C0 VA: 0x2A9E6C0
	|-KeyValuePair<short, byte>.get_Value
	|
	|-RVA: 0x2A9E7AC Offset: 0x2A9A7AC VA: 0x2A9E7AC
	|-KeyValuePair<short, short>.get_Value
	|
	|-RVA: 0x2A9E898 Offset: 0x2A9A898 VA: 0x2A9E898
	|-KeyValuePair<short, int>.get_Value
	|
	|-RVA: 0x2A9E988 Offset: 0x2A9A988 VA: 0x2A9E988
	|-KeyValuePair<short, object>.get_Value
	|
	|-RVA: 0x2A9EA38 Offset: 0x2A9AA38 VA: 0x2A9EA38
	|-KeyValuePair<Int16Enum, bool>.get_Value
	|
	|-RVA: 0x2A9EB24 Offset: 0x2A9AB24 VA: 0x2A9EB24
	|-KeyValuePair<Int16Enum, int>.get_Value
	|
	|-RVA: 0x2A9EC14 Offset: 0x2A9AC14 VA: 0x2A9EC14
	|-KeyValuePair<Int16Enum, object>.get_Value
	|
	|-RVA: 0x2A9ECC4 Offset: 0x2A9ACC4 VA: 0x2A9ECC4
	|-KeyValuePair<int, bool>.get_Value
	|
	|-RVA: 0x2A9EDB0 Offset: 0x2A9ADB0 VA: 0x2A9EDB0
	|-KeyValuePair<int, byte>.get_Value
	|
	|-RVA: 0x2A9EEA0 Offset: 0x2A9AEA0 VA: 0x2A9EEA0
	|-KeyValuePair<int, Color>.get_Value
	|
	|-RVA: 0x2A9EF90 Offset: 0x2A9AF90 VA: 0x2A9EF90
	|-KeyValuePair<int, short>.get_Value
	|
	|-RVA: 0x2A9F078 Offset: 0x2A9B078 VA: 0x2A9F078
	|-KeyValuePair<int, int>.get_Value
	|
	|-RVA: 0x2A9F160 Offset: 0x2A9B160 VA: 0x2A9F160
	|-KeyValuePair<int, Int32Enum>.get_Value
	|
	|-RVA: 0x2A9F24C Offset: 0x2A9B24C VA: 0x2A9F24C
	|-KeyValuePair<int, long>.get_Value
	|
	|-RVA: 0x2A9F33C Offset: 0x2A9B33C VA: 0x2A9F33C
	|-KeyValuePair<int, MaterialSearchData>.get_Value
	|
	|-RVA: 0x2A9F438 Offset: 0x2A9B438 VA: 0x2A9F438
	|-KeyValuePair<int, object>.get_Value
	|
	|-RVA: 0x2A9F4E8 Offset: 0x2A9B4E8 VA: 0x2A9F4E8
	|-KeyValuePair<int, RenderInstancedDataLayout>.get_Value
	|
	|-RVA: 0x2A9F5E0 Offset: 0x2A9B5E0 VA: 0x2A9F5E0
	|-KeyValuePair<int, float>.get_Value
	|
	|-RVA: 0x2A9F6CC Offset: 0x2A9B6CC VA: 0x2A9F6CC
	|-KeyValuePair<int, Vector2>.get_Value
	|
	|-RVA: 0x2A9F7BC Offset: 0x2A9B7BC VA: 0x2A9F7BC
	|-KeyValuePair<int, Vector3>.get_Value
	|
	|-RVA: 0x2A9F8B8 Offset: 0x2A9B8B8 VA: 0x2A9F8B8
	|-KeyValuePair<int, Vector4>.get_Value
	|
	|-RVA: 0x2A9F9B8 Offset: 0x2A9B9B8 VA: 0x2A9F9B8
	|-KeyValuePair<int, HouseRecipeManager.RecipeData>.get_Value
	|
	|-RVA: 0x2A9FAD0 Offset: 0x2A9BAD0 VA: 0x2A9FAD0
	|-KeyValuePair<int, MasterModelDataManager.ColorListData>.get_Value
	|
	|-RVA: 0x2A9FBEC Offset: 0x2A9BBEC VA: 0x2A9FBEC
	|-KeyValuePair<int, UIGuildQuestBoardManager.GuildQuestMaseter>.get_Value
	|
	|-RVA: 0x2A9FCEC Offset: 0x2A9BCEC VA: 0x2A9FCEC
	|-KeyValuePair<Int32Enum, ArchetypeUid>.get_Value
	|
	|-RVA: 0x2A9FDDC Offset: 0x2A9BDDC VA: 0x2A9FDDC
	|-KeyValuePair<Int32Enum, bool>.get_Value
	|
	|-RVA: 0x2A9FEC8 Offset: 0x2A9BEC8 VA: 0x2A9FEC8
	|-KeyValuePair<Int32Enum, byte>.get_Value
	|
	|-RVA: 0x2A9FFB8 Offset: 0x2A9BFB8 VA: 0x2A9FFB8
	|-KeyValuePair<Int32Enum, Color>.get_Value
	|
	|-RVA: 0x2AA00A8 Offset: 0x2A9C0A8 VA: 0x2AA00A8
	|-KeyValuePair<Int32Enum, DateTime>.get_Value
	|
	|-RVA: 0x2AA01A4 Offset: 0x2A9C1A4 VA: 0x2AA01A4
	|-KeyValuePair<Int32Enum, EnhanceProperties2>.get_Value
	|
	|-RVA: 0x2AA02AC Offset: 0x2A9C2AC VA: 0x2AA02AC
	|-KeyValuePair<Int32Enum, short>.get_Value
	|
	|-RVA: 0x2AA0394 Offset: 0x2A9C394 VA: 0x2AA0394
	|-KeyValuePair<Int32Enum, int>.get_Value
	|
	|-RVA: 0x2AA047C Offset: 0x2A9C47C VA: 0x2AA047C
	|-KeyValuePair<Int32Enum, Int32Enum>.get_Value
	|
	|-RVA: 0x2AA0568 Offset: 0x2A9C568 VA: 0x2AA0568
	|-KeyValuePair<Int32Enum, long>.get_Value
	|
	|-RVA: 0x2AA0654 Offset: 0x2A9C654 VA: 0x2AA0654
	|-KeyValuePair<Int32Enum, Int64Enum>.get_Value
	|
	|-RVA: 0x2AA0744 Offset: 0x2A9C744 VA: 0x2AA0744
	|-KeyValuePair<Int32Enum, object>.get_Value
	|
	|-RVA: 0x2AA07F0 Offset: 0x2A9C7F0 VA: 0x2AA07F0
	|-KeyValuePair<Int32Enum, float>.get_Value
	|
	|-RVA: 0x2AA08E0 Offset: 0x2A9C8E0 VA: 0x2AA08E0
	|-KeyValuePair<Int32Enum, Vector3>.get_Value
	|
	|-RVA: 0x2AA09E8 Offset: 0x2A9C9E8 VA: 0x2AA09E8
	|-KeyValuePair<Int32Enum, MasterModelDataManager.ColorListData>.get_Value
	|
	|-RVA: 0x2AA0AF4 Offset: 0x2A9CAF4 VA: 0x2AA0AF4
	|-KeyValuePair<long, bool>.get_Value
	|
	|-RVA: 0x2AA0BE0 Offset: 0x2A9CBE0 VA: 0x2AA0BE0
	|-KeyValuePair<long, byte>.get_Value
	|
	|-RVA: 0x2AA0CCC Offset: 0x2A9CCCC VA: 0x2AA0CCC
	|-KeyValuePair<long, short>.get_Value
	|
	|-RVA: 0x2AA0DBC Offset: 0x2A9CDBC VA: 0x2AA0DBC
	|-KeyValuePair<long, object>.get_Value
	|
	|-RVA: 0x2AA0E68 Offset: 0x2A9CE68 VA: 0x2AA0E68
	|-KeyValuePair<Int64Enum, Int32Enum>.get_Value
	|
	|-RVA: 0x2AA0F58 Offset: 0x2A9CF58 VA: 0x2AA0F58
	|-KeyValuePair<Int64Enum, object>.get_Value
	|
	|-RVA: 0x2AA1008 Offset: 0x2A9D008 VA: 0x2AA1008
	|-KeyValuePair<IntPtr, object>.get_Value
	|
	|-RVA: 0x2AA10E0 Offset: 0x2A9D0E0 VA: 0x2AA10E0
	|-KeyValuePair<object, ValueTuple<object, byte>>.get_Value
	|
	|-RVA: 0x2AA11C8 Offset: 0x2A9D1C8 VA: 0x2AA11C8
	|-KeyValuePair<object, ValueTuple<float, object>>.get_Value
	|
	|-RVA: 0x2AA12A0 Offset: 0x2A9D2A0 VA: 0x2AA12A0
	|-KeyValuePair<object, bool>.get_Value
	|
	|-RVA: 0x2AA1374 Offset: 0x2A9D374 VA: 0x2AA1374
	|-KeyValuePair<object, byte>.get_Value
	|
	|-RVA: 0x2AA1448 Offset: 0x2A9D448 VA: 0x2AA1448
	|-KeyValuePair<object, short>.get_Value
	|
	|-RVA: 0x2AA151C Offset: 0x2A9D51C VA: 0x2AA151C
	|-KeyValuePair<object, int>.get_Value
	|
	|-RVA: 0x2AA15F0 Offset: 0x2A9D5F0 VA: 0x2AA15F0
	|-KeyValuePair<object, Int32Enum>.get_Value
	|
	|-RVA: 0x2AA16CC Offset: 0x2A9D6CC VA: 0x2AA16CC
	|-KeyValuePair<object, object>.get_Value
	|
	|-RVA: 0x2AA1770 Offset: 0x2A9D770 VA: 0x2AA1770
	|-KeyValuePair<object, ResourceLocator>.get_Value
	|
	|-RVA: 0x2AA1848 Offset: 0x2A9D848 VA: 0x2AA1848
	|-KeyValuePair<object, float>.get_Value
	|
	|-RVA: 0x2AA1930 Offset: 0x2A9D930 VA: 0x2AA1930
	|-KeyValuePair<object, Vector3>.get_Value
	|
	|-RVA: 0x2AA1A20 Offset: 0x2A9DA20 VA: 0x2AA1A20
	|-KeyValuePair<object, DeathReceptionAction.PoisonTargetData>.get_Value
	|
	|-RVA: 0x2AA1AF8 Offset: 0x2A9DAF8 VA: 0x2AA1AF8
	|-KeyValuePair<object, UIHouseAddressManager.Town>.get_Value
	|
	|-RVA: 0x2AA1BB0 Offset: 0x2A9DBB0 VA: 0x2AA1BB0
	|-KeyValuePair<float, object>.get_Value
	|
	|-RVA: 0x2AA1C5C Offset: 0x2A9DC5C VA: 0x2AA1C5C
	|-KeyValuePair<ushort, byte>.get_Value
	|
	|-RVA: 0x2AA1D7C Offset: 0x2A9DD7C VA: 0x2AA1D7C
	|-KeyValuePair<XPathNodeRef, XPathNodeRef>.get_Value
	|
	|-RVA: 0x2AA2128 Offset: 0x2A9E128 VA: 0x2AA2128
	|-KeyValuePair<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Value
	|
	|-RVA: 0x2AA2434 Offset: 0x2A9E434 VA: 0x2AA2434
	|-KeyValuePair<MaterialManager.pair, object>.get_Value
	|
	|-RVA: 0x2AA2520 Offset: 0x2A9E520 VA: 0x2AA2520
	|-KeyValuePair<Regex.CachedCodeEntryKey, object>.get_Value
	|
	|-RVA: 0x2AA25E0 Offset: 0x2A9E5E0 VA: 0x2AA25E0
	|-KeyValuePair<PartyManager.PartyData.pair, object>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9D334 Offset: 0x2A99334 VA: 0x2A9D334
	|-KeyValuePair<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.ToString
	|
	|-RVA: 0x2A9D44C Offset: 0x2A9944C VA: 0x2A9D44C
	|-KeyValuePair<KeyValuePair<object, object>, object>.ToString
	|
	|-RVA: 0x2A9D52C Offset: 0x2A9952C VA: 0x2A9D52C
	|-KeyValuePair<StructMultiKey<object, object>, object>.ToString
	|
	|-RVA: 0x2A9D60C Offset: 0x2A9960C VA: 0x2A9D60C
	|-KeyValuePair<ValueTuple<object, object>, object>.ToString
	|
	|-RVA: 0x2A9D6C0 Offset: 0x2A996C0 VA: 0x2A9D6C0
	|-KeyValuePair<ArchetypeUid, int>.ToString
	|
	|-RVA: 0x2A9D7B0 Offset: 0x2A997B0 VA: 0x2A9D7B0
	|-KeyValuePair<ArchetypeUid, object>.ToString
	|
	|-RVA: 0x2A9D868 Offset: 0x2A99868 VA: 0x2A9D868
	|-KeyValuePair<byte, ValueTuple<short, int, int>>.ToString
	|
	|-RVA: 0x2A9D968 Offset: 0x2A99968 VA: 0x2A9D968
	|-KeyValuePair<byte, BlackKnightAvatarProperty>.ToString
	|
	|-RVA: 0x2A9DA6C Offset: 0x2A99A6C VA: 0x2A9DA6C
	|-KeyValuePair<byte, BlackKnightCristaProperty>.ToString
	|
	|-RVA: 0x2A9DB60 Offset: 0x2A99B60 VA: 0x2A9DB60
	|-KeyValuePair<byte, byte>.ToString
	|
	|-RVA: 0x2A9DC58 Offset: 0x2A99C58 VA: 0x2A9DC58
	|-KeyValuePair<byte, CardData>.ToString
	|
	|-RVA: 0x2A9DD4C Offset: 0x2A99D4C VA: 0x2A9DD4C
	|-KeyValuePair<byte, short>.ToString
	|
	|-RVA: 0x2A9DE38 Offset: 0x2A99E38 VA: 0x2A9DE38
	|-KeyValuePair<byte, int>.ToString
	|
	|-RVA: 0x2A9DF24 Offset: 0x2A99F24 VA: 0x2A9DF24
	|-KeyValuePair<byte, long>.ToString
	|
	|-RVA: 0x2A9E014 Offset: 0x2A9A014 VA: 0x2A9E014
	|-KeyValuePair<byte, object>.ToString
	|
	|-RVA: 0x2A9E0C0 Offset: 0x2A9A0C0 VA: 0x2A9E0C0
	|-KeyValuePair<byte, float>.ToString
	|
	|-RVA: 0x2A9E1AC Offset: 0x2A9A1AC VA: 0x2A9E1AC
	|-KeyValuePair<byte, MasterModelDataManager.ConvertCommonMaterialData>.ToString
	|
	|-RVA: 0x2A9E29C Offset: 0x2A9A29C VA: 0x2A9E29C
	|-KeyValuePair<ByteEnum, object>.ToString
	|
	|-RVA: 0x2A9E348 Offset: 0x2A9A348 VA: 0x2A9E348
	|-KeyValuePair<char, char>.ToString
	|
	|-RVA: 0x2A9E434 Offset: 0x2A9A434 VA: 0x2A9E434
	|-KeyValuePair<DefencePoint2, byte>.ToString
	|
	|-RVA: 0x2A9E520 Offset: 0x2A9A520 VA: 0x2A9E520
	|-KeyValuePair<double, int>.ToString
	|
	|-RVA: 0x2A9E614 Offset: 0x2A9A614 VA: 0x2A9E614
	|-KeyValuePair<Guid, object>.ToString
	|
	|-RVA: 0x2A9E6C8 Offset: 0x2A9A6C8 VA: 0x2A9E6C8
	|-KeyValuePair<short, byte>.ToString
	|
	|-RVA: 0x2A9E7B4 Offset: 0x2A9A7B4 VA: 0x2A9E7B4
	|-KeyValuePair<short, short>.ToString
	|
	|-RVA: 0x2A9E8A0 Offset: 0x2A9A8A0 VA: 0x2A9E8A0
	|-KeyValuePair<short, int>.ToString
	|
	|-RVA: 0x2A9E990 Offset: 0x2A9A990 VA: 0x2A9E990
	|-KeyValuePair<short, object>.ToString
	|
	|-RVA: 0x2A9EA40 Offset: 0x2A9AA40 VA: 0x2A9EA40
	|-KeyValuePair<Int16Enum, bool>.ToString
	|
	|-RVA: 0x2A9EB2C Offset: 0x2A9AB2C VA: 0x2A9EB2C
	|-KeyValuePair<Int16Enum, int>.ToString
	|
	|-RVA: 0x2A9EC1C Offset: 0x2A9AC1C VA: 0x2A9EC1C
	|-KeyValuePair<Int16Enum, object>.ToString
	|
	|-RVA: 0x2A9ECCC Offset: 0x2A9ACCC VA: 0x2A9ECCC
	|-KeyValuePair<int, bool>.ToString
	|
	|-RVA: 0x2A9EDB8 Offset: 0x2A9ADB8 VA: 0x2A9EDB8
	|-KeyValuePair<int, byte>.ToString
	|
	|-RVA: 0x2A9EEAC Offset: 0x2A9AEAC VA: 0x2A9EEAC
	|-KeyValuePair<int, Color>.ToString
	|
	|-RVA: 0x2A9EF98 Offset: 0x2A9AF98 VA: 0x2A9EF98
	|-KeyValuePair<int, short>.ToString
	|
	|-RVA: 0x2A9F080 Offset: 0x2A9B080 VA: 0x2A9F080
	|-KeyValuePair<int, int>.ToString
	|
	|-RVA: 0x2A9F168 Offset: 0x2A9B168 VA: 0x2A9F168
	|-KeyValuePair<int, Int32Enum>.ToString
	|
	|-RVA: 0x2A9F254 Offset: 0x2A9B254 VA: 0x2A9F254
	|-KeyValuePair<int, long>.ToString
	|
	|-RVA: 0x2A9F34C Offset: 0x2A9B34C VA: 0x2A9F34C
	|-KeyValuePair<int, MaterialSearchData>.ToString
	|
	|-RVA: 0x2A9F440 Offset: 0x2A9B440 VA: 0x2A9F440
	|-KeyValuePair<int, object>.ToString
	|
	|-RVA: 0x2A9F4F8 Offset: 0x2A9B4F8 VA: 0x2A9F4F8
	|-KeyValuePair<int, RenderInstancedDataLayout>.ToString
	|
	|-RVA: 0x2A9F5E8 Offset: 0x2A9B5E8 VA: 0x2A9F5E8
	|-KeyValuePair<int, float>.ToString
	|
	|-RVA: 0x2A9F6D4 Offset: 0x2A9B6D4 VA: 0x2A9F6D4
	|-KeyValuePair<int, Vector2>.ToString
	|
	|-RVA: 0x2A9F7C8 Offset: 0x2A9B7C8 VA: 0x2A9F7C8
	|-KeyValuePair<int, Vector3>.ToString
	|
	|-RVA: 0x2A9F8C4 Offset: 0x2A9B8C4 VA: 0x2A9F8C4
	|-KeyValuePair<int, Vector4>.ToString
	|
	|-RVA: 0x2A9F9D0 Offset: 0x2A9B9D0 VA: 0x2A9F9D0
	|-KeyValuePair<int, HouseRecipeManager.RecipeData>.ToString
	|
	|-RVA: 0x2A9FAE8 Offset: 0x2A9BAE8 VA: 0x2A9FAE8
	|-KeyValuePair<int, MasterModelDataManager.ColorListData>.ToString
	|
	|-RVA: 0x2A9FC00 Offset: 0x2A9BC00 VA: 0x2A9FC00
	|-KeyValuePair<int, UIGuildQuestBoardManager.GuildQuestMaseter>.ToString
	|
	|-RVA: 0x2A9FCF4 Offset: 0x2A9BCF4 VA: 0x2A9FCF4
	|-KeyValuePair<Int32Enum, ArchetypeUid>.ToString
	|
	|-RVA: 0x2A9FDE4 Offset: 0x2A9BDE4 VA: 0x2A9FDE4
	|-KeyValuePair<Int32Enum, bool>.ToString
	|
	|-RVA: 0x2A9FED0 Offset: 0x2A9BED0 VA: 0x2A9FED0
	|-KeyValuePair<Int32Enum, byte>.ToString
	|
	|-RVA: 0x2A9FFC4 Offset: 0x2A9BFC4 VA: 0x2A9FFC4
	|-KeyValuePair<Int32Enum, Color>.ToString
	|
	|-RVA: 0x2AA00B0 Offset: 0x2A9C0B0 VA: 0x2AA00B0
	|-KeyValuePair<Int32Enum, DateTime>.ToString
	|
	|-RVA: 0x2AA01BC Offset: 0x2A9C1BC VA: 0x2AA01BC
	|-KeyValuePair<Int32Enum, EnhanceProperties2>.ToString
	|
	|-RVA: 0x2AA02B4 Offset: 0x2A9C2B4 VA: 0x2AA02B4
	|-KeyValuePair<Int32Enum, short>.ToString
	|
	|-RVA: 0x2AA039C Offset: 0x2A9C39C VA: 0x2AA039C
	|-KeyValuePair<Int32Enum, int>.ToString
	|
	|-RVA: 0x2AA0484 Offset: 0x2A9C484 VA: 0x2AA0484
	|-KeyValuePair<Int32Enum, Int32Enum>.ToString
	|
	|-RVA: 0x2AA0570 Offset: 0x2A9C570 VA: 0x2AA0570
	|-KeyValuePair<Int32Enum, long>.ToString
	|
	|-RVA: 0x2AA065C Offset: 0x2A9C65C VA: 0x2AA065C
	|-KeyValuePair<Int32Enum, Int64Enum>.ToString
	|
	|-RVA: 0x2AA074C Offset: 0x2A9C74C VA: 0x2AA074C
	|-KeyValuePair<Int32Enum, object>.ToString
	|
	|-RVA: 0x2AA07F8 Offset: 0x2A9C7F8 VA: 0x2AA07F8
	|-KeyValuePair<Int32Enum, float>.ToString
	|
	|-RVA: 0x2AA08EC Offset: 0x2A9C8EC VA: 0x2AA08EC
	|-KeyValuePair<Int32Enum, Vector3>.ToString
	|
	|-RVA: 0x2AA0A00 Offset: 0x2A9CA00 VA: 0x2AA0A00
	|-KeyValuePair<Int32Enum, MasterModelDataManager.ColorListData>.ToString
	|
	|-RVA: 0x2AA0AFC Offset: 0x2A9CAFC VA: 0x2AA0AFC
	|-KeyValuePair<long, bool>.ToString
	|
	|-RVA: 0x2AA0BE8 Offset: 0x2A9CBE8 VA: 0x2AA0BE8
	|-KeyValuePair<long, byte>.ToString
	|
	|-RVA: 0x2AA0CD4 Offset: 0x2A9CCD4 VA: 0x2AA0CD4
	|-KeyValuePair<long, short>.ToString
	|
	|-RVA: 0x2AA0DC4 Offset: 0x2A9CDC4 VA: 0x2AA0DC4
	|-KeyValuePair<long, object>.ToString
	|
	|-RVA: 0x2AA0E70 Offset: 0x2A9CE70 VA: 0x2AA0E70
	|-KeyValuePair<Int64Enum, Int32Enum>.ToString
	|
	|-RVA: 0x2AA0F60 Offset: 0x2A9CF60 VA: 0x2AA0F60
	|-KeyValuePair<Int64Enum, object>.ToString
	|
	|-RVA: 0x2AA1010 Offset: 0x2A9D010 VA: 0x2AA1010
	|-KeyValuePair<IntPtr, object>.ToString
	|
	|-RVA: 0x2AA10EC Offset: 0x2A9D0EC VA: 0x2AA10EC
	|-KeyValuePair<object, ValueTuple<object, byte>>.ToString
	|
	|-RVA: 0x2AA11D4 Offset: 0x2A9D1D4 VA: 0x2AA11D4
	|-KeyValuePair<object, ValueTuple<float, object>>.ToString
	|
	|-RVA: 0x2AA12A8 Offset: 0x2A9D2A8 VA: 0x2AA12A8
	|-KeyValuePair<object, bool>.ToString
	|
	|-RVA: 0x2AA137C Offset: 0x2A9D37C VA: 0x2AA137C
	|-KeyValuePair<object, byte>.ToString
	|
	|-RVA: 0x2AA1450 Offset: 0x2A9D450 VA: 0x2AA1450
	|-KeyValuePair<object, short>.ToString
	|
	|-RVA: 0x2AA1524 Offset: 0x2A9D524 VA: 0x2AA1524
	|-KeyValuePair<object, int>.ToString
	|
	|-RVA: 0x2AA15F8 Offset: 0x2A9D5F8 VA: 0x2AA15F8
	|-KeyValuePair<object, Int32Enum>.ToString
	|
	|-RVA: 0x2AA16D4 Offset: 0x2A9D6D4 VA: 0x2AA16D4
	|-KeyValuePair<object, object>.ToString
	|
	|-RVA: 0x2AA177C Offset: 0x2A9D77C VA: 0x2AA177C
	|-KeyValuePair<object, ResourceLocator>.ToString
	|
	|-RVA: 0x2AA1850 Offset: 0x2A9D850 VA: 0x2AA1850
	|-KeyValuePair<object, float>.ToString
	|
	|-RVA: 0x2AA193C Offset: 0x2A9D93C VA: 0x2AA193C
	|-KeyValuePair<object, Vector3>.ToString
	|
	|-RVA: 0x2AA1A2C Offset: 0x2A9DA2C VA: 0x2AA1A2C
	|-KeyValuePair<object, DeathReceptionAction.PoisonTargetData>.ToString
	|
	|-RVA: 0x2AA1B00 Offset: 0x2A9DB00 VA: 0x2AA1B00
	|-KeyValuePair<object, UIHouseAddressManager.Town>.ToString
	|
	|-RVA: 0x2AA1BB8 Offset: 0x2A9DBB8 VA: 0x2AA1BB8
	|-KeyValuePair<float, object>.ToString
	|
	|-RVA: 0x2AA1C64 Offset: 0x2A9DC64 VA: 0x2AA1C64
	|-KeyValuePair<ushort, byte>.ToString
	|
	|-RVA: 0x2AA1D88 Offset: 0x2A9DD88 VA: 0x2AA1D88
	|-KeyValuePair<XPathNodeRef, XPathNodeRef>.ToString
	|
	|-RVA: 0x2AA2218 Offset: 0x2A9E218 VA: 0x2AA2218
	|-KeyValuePair<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	|
	|-RVA: 0x2AA243C Offset: 0x2A9E43C VA: 0x2AA243C
	|-KeyValuePair<MaterialManager.pair, object>.ToString
	|
	|-RVA: 0x2AA2528 Offset: 0x2A9E528 VA: 0x2AA2528
	|-KeyValuePair<Regex.CachedCodeEntryKey, object>.ToString
	|
	|-RVA: 0x2AA25E8 Offset: 0x2A9E5E8 VA: 0x2AA25E8
	|-KeyValuePair<PartyManager.PartyData.pair, object>.ToString
	*/
}
