// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
public struct Dictionary.ValueCollection.Enumerator<TKey, TValue> : IEnumerator<TValue>, IDisposable, IEnumerator // TypeDefIndex: 10928
{
	// Fields
	private Dictionary<TKey, TValue> _dictionary; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TValue _currentValue; // 0x0

	// Properties
	public TValue Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2981360 Offset: 0x297D360 VA: 0x2981360
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2981BB4 Offset: 0x297DBB4 VA: 0x2981BB4
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x29823DC Offset: 0x297E3DC VA: 0x29823DC
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0x2982C4C Offset: 0x297EC4C VA: 0x2982C4C
	|-Dictionary.ValueCollection.Enumerator<ArchetypeUid, int>..ctor
	|
	|-RVA: 0x2983454 Offset: 0x297F454 VA: 0x2983454
	|-Dictionary.ValueCollection.Enumerator<ArchetypeUid, object>..ctor
	|
	|-RVA: 0x2983D00 Offset: 0x297FD00 VA: 0x2983D00
	|-Dictionary.ValueCollection.Enumerator<byte, ValueTuple<short, int, int>>..ctor
	|
	|-RVA: 0x29845F8 Offset: 0x29805F8 VA: 0x29845F8
	|-Dictionary.ValueCollection.Enumerator<byte, BlackKnightAvatarProperty>..ctor
	|
	|-RVA: 0x2984ECC Offset: 0x2980ECC VA: 0x2984ECC
	|-Dictionary.ValueCollection.Enumerator<byte, BlackKnightCristaProperty>..ctor
	|
	|-RVA: 0x298577C Offset: 0x298177C VA: 0x298577C
	|-Dictionary.ValueCollection.Enumerator<byte, byte>..ctor
	|
	|-RVA: 0x2986048 Offset: 0x2982048 VA: 0x2986048
	|-Dictionary.ValueCollection.Enumerator<byte, CardData>..ctor
	|
	|-RVA: 0x29868F4 Offset: 0x29828F4 VA: 0x29868F4
	|-Dictionary.ValueCollection.Enumerator<byte, short>..ctor
	|
	|-RVA: 0x2987170 Offset: 0x2983170 VA: 0x2987170
	|-Dictionary.ValueCollection.Enumerator<byte, int>..ctor
	|
	|-RVA: 0x2987A04 Offset: 0x2983A04 VA: 0x2987A04
	|-Dictionary.ValueCollection.Enumerator<byte, long>..ctor
	|
	|-RVA: 0x2988A48 Offset: 0x2984A48 VA: 0x2988A48
	|-Dictionary.ValueCollection.Enumerator<byte, object>..ctor
	|
	|-RVA: 0x29896F0 Offset: 0x29856F0 VA: 0x29896F0
	|-Dictionary.ValueCollection.Enumerator<byte, float>..ctor
	|
	|-RVA: 0x2989FA0 Offset: 0x2985FA0 VA: 0x2989FA0
	|-Dictionary.ValueCollection.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>..ctor
	|
	|-RVA: 0x298A7AC Offset: 0x29867AC VA: 0x298A7AC
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, object>..ctor
	|
	|-RVA: 0x298B00C Offset: 0x298700C VA: 0x298B00C
	|-Dictionary.ValueCollection.Enumerator<char, char>..ctor
	|
	|-RVA: 0x298B8C4 Offset: 0x29878C4 VA: 0x298B8C4
	|-Dictionary.ValueCollection.Enumerator<DefencePoint2, byte>..ctor
	|
	|-RVA: 0x298CE34 Offset: 0x2988E34 VA: 0x298CE34
	|-Dictionary.ValueCollection.Enumerator<Guid, object>..ctor
	|
	|-RVA: 0x298D688 Offset: 0x2989688 VA: 0x298D688
	|-Dictionary.ValueCollection.Enumerator<short, byte>..ctor
	|
	|-RVA: 0x298DF08 Offset: 0x2989F08 VA: 0x298DF08
	|-Dictionary.ValueCollection.Enumerator<short, short>..ctor
	|
	|-RVA: 0x298E784 Offset: 0x298A784 VA: 0x298E784
	|-Dictionary.ValueCollection.Enumerator<short, int>..ctor
	|
	|-RVA: 0x298EF88 Offset: 0x298AF88 VA: 0x298EF88
	|-Dictionary.ValueCollection.Enumerator<short, object>..ctor
	|
	|-RVA: 0x298F7F0 Offset: 0x298B7F0 VA: 0x298F7F0
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, bool>..ctor
	|
	|-RVA: 0x299006C Offset: 0x298C06C VA: 0x299006C
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, int>..ctor
	|
	|-RVA: 0x2990870 Offset: 0x298C870 VA: 0x2990870
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, object>..ctor
	|
	|-RVA: 0x29910D4 Offset: 0x298D0D4 VA: 0x29910D4
	|-Dictionary.ValueCollection.Enumerator<int, bool>..ctor
	|
	|-RVA: 0x2991948 Offset: 0x298D948 VA: 0x2991948
	|-Dictionary.ValueCollection.Enumerator<int, byte>..ctor
	|
	|-RVA: 0x2992244 Offset: 0x298E244 VA: 0x2992244
	|-Dictionary.ValueCollection.Enumerator<int, Color>..ctor
	|
	|-RVA: 0x2992ACC Offset: 0x298EACC VA: 0x2992ACC
	|-Dictionary.ValueCollection.Enumerator<int, short>..ctor
	|
	|-RVA: 0x299333C Offset: 0x298F33C VA: 0x299333C
	|-Dictionary.ValueCollection.Enumerator<int, int>..ctor
	|
	|-RVA: 0x2993BAC Offset: 0x298FBAC VA: 0x2993BAC
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>..ctor
	|
	|-RVA: 0x2994440 Offset: 0x2990440 VA: 0x2994440
	|-Dictionary.ValueCollection.Enumerator<int, long>..ctor
	|
	|-RVA: 0x2994D28 Offset: 0x2990D28 VA: 0x2994D28
	|-Dictionary.ValueCollection.Enumerator<int, MaterialSearchData>..ctor
	|
	|-RVA: 0x2995540 Offset: 0x2991540 VA: 0x2995540
	|-Dictionary.ValueCollection.Enumerator<int, object>..ctor
	|
	|-RVA: 0x2995E08 Offset: 0x2991E08 VA: 0x2995E08
	|-Dictionary.ValueCollection.Enumerator<int, RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x2996698 Offset: 0x2992698 VA: 0x2996698
	|-Dictionary.ValueCollection.Enumerator<int, float>..ctor
	|
	|-RVA: 0x2996F7C Offset: 0x2992F7C VA: 0x2996F7C
	|-Dictionary.ValueCollection.Enumerator<int, Vector3>..ctor
	|
	|-RVA: 0x29978A8 Offset: 0x29938A8 VA: 0x29978A8
	|-Dictionary.ValueCollection.Enumerator<int, Vector4>..ctor
	|
	|-RVA: 0x2998200 Offset: 0x2994200 VA: 0x2998200
	|-Dictionary.ValueCollection.Enumerator<int, HouseRecipeManager.RecipeData>..ctor
	|
	|-RVA: 0x2998BB8 Offset: 0x2994BB8 VA: 0x2998BB8
	|-Dictionary.ValueCollection.Enumerator<int, MasterModelDataManager.ColorListData>..ctor
	|
	|-RVA: 0x29994FC Offset: 0x29954FC VA: 0x29994FC
	|-Dictionary.ValueCollection.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>..ctor
	|
	|-RVA: 0x2999DDC Offset: 0x2995DDC VA: 0x2999DDC
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ArchetypeUid>..ctor
	|
	|-RVA: 0x299A660 Offset: 0x2996660 VA: 0x299A660
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>..ctor
	|
	|-RVA: 0x299AED4 Offset: 0x2996ED4 VA: 0x299AED4
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, byte>..ctor
	|
	|-RVA: 0x299B7D0 Offset: 0x29977D0 VA: 0x299B7D0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Color>..ctor
	|
	|-RVA: 0x299C078 Offset: 0x2998078 VA: 0x299C078
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, DateTime>..ctor
	|
	|-RVA: 0x299C9B8 Offset: 0x29989B8 VA: 0x299C9B8
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, EnhanceProperties2>..ctor
	|
	|-RVA: 0x299D274 Offset: 0x2999274 VA: 0x299D274
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, short>..ctor
	|
	|-RVA: 0x299DAE4 Offset: 0x2999AE4 VA: 0x299DAE4
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>..ctor
	|
	|-RVA: 0x299E354 Offset: 0x299A354 VA: 0x299E354
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x299EBE8 Offset: 0x299ABE8 VA: 0x299EBE8
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, long>..ctor
	|
	|-RVA: 0x299F484 Offset: 0x299B484 VA: 0x299F484
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int64Enum>..ctor
	|
	|-RVA: 0x299FC90 Offset: 0x299BC90 VA: 0x299FC90
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>..ctor
	|
	|-RVA: 0x29A04F4 Offset: 0x299C4F4 VA: 0x29A04F4
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, float>..ctor
	|
	|-RVA: 0x29A0DD8 Offset: 0x299CDD8 VA: 0x29A0DD8
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Vector3>..ctor
	|
	|-RVA: 0x29A1768 Offset: 0x299D768 VA: 0x29A1768
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>..ctor
	|
	|-RVA: 0x29A204C Offset: 0x299E04C VA: 0x29A204C
	|-Dictionary.ValueCollection.Enumerator<long, bool>..ctor
	|
	|-RVA: 0x29A28E8 Offset: 0x299E8E8 VA: 0x29A28E8
	|-Dictionary.ValueCollection.Enumerator<long, byte>..ctor
	|
	|-RVA: 0x29A3184 Offset: 0x299F184 VA: 0x29A3184
	|-Dictionary.ValueCollection.Enumerator<long, short>..ctor
	|
	|-RVA: 0x29A398C Offset: 0x299F98C VA: 0x29A398C
	|-Dictionary.ValueCollection.Enumerator<long, object>..ctor
	|
	|-RVA: 0x29A4208 Offset: 0x29A0208 VA: 0x29A4208
	|-Dictionary.ValueCollection.Enumerator<Int64Enum, Int32Enum>..ctor
	|
	|-RVA: 0x29A4A10 Offset: 0x29A0A10 VA: 0x29A4A10
	|-Dictionary.ValueCollection.Enumerator<Int64Enum, object>..ctor
	|
	|-RVA: 0x29A51F8 Offset: 0x29A11F8 VA: 0x29A51F8
	|-Dictionary.ValueCollection.Enumerator<IntPtr, object>..ctor
	|
	|-RVA: 0x29A59D4 Offset: 0x29A19D4 VA: 0x29A59D4
	|-Dictionary.ValueCollection.Enumerator<object, ValueTuple<object, byte>>..ctor
	|
	|-RVA: 0x29A61E4 Offset: 0x29A21E4 VA: 0x29A61E4
	|-Dictionary.ValueCollection.Enumerator<object, ValueTuple<float, object>>..ctor
	|
	|-RVA: 0x29A69D4 Offset: 0x29A29D4 VA: 0x29A69D4
	|-Dictionary.ValueCollection.Enumerator<object, bool>..ctor
	|
	|-RVA: 0x29A71A8 Offset: 0x29A31A8 VA: 0x29A71A8
	|-Dictionary.ValueCollection.Enumerator<object, byte>..ctor
	|
	|-RVA: 0x29A797C Offset: 0x29A397C VA: 0x29A797C
	|-Dictionary.ValueCollection.Enumerator<object, short>..ctor
	|
	|-RVA: 0x29A8150 Offset: 0x29A4150 VA: 0x29A8150
	|-Dictionary.ValueCollection.Enumerator<object, int>..ctor
	|
	|-RVA: 0x29A8924 Offset: 0x29A4924 VA: 0x29A8924
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>..ctor
	|
	|-RVA: 0x29A9484 Offset: 0x29A5484 VA: 0x29A9484
	|-Dictionary.ValueCollection.Enumerator<object, object>..ctor
	|
	|-RVA: 0x29A9C60 Offset: 0x29A5C60 VA: 0x29A9C60
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>..ctor
	|
	|-RVA: 0x29AA450 Offset: 0x29A6450 VA: 0x29AA450
	|-Dictionary.ValueCollection.Enumerator<object, float>..ctor
	|
	|-RVA: 0x29AAC84 Offset: 0x29A6C84 VA: 0x29AAC84
	|-Dictionary.ValueCollection.Enumerator<object, Vector3>..ctor
	|
	|-RVA: 0x29AB49C Offset: 0x29A749C VA: 0x29AB49C
	|-Dictionary.ValueCollection.Enumerator<object, DeathReceptionAction.PoisonTargetData>..ctor
	|
	|-RVA: 0x29ABC80 Offset: 0x29A7C80 VA: 0x29ABC80
	|-Dictionary.ValueCollection.Enumerator<object, UIHouseAddressManager.Town>..ctor
	|
	|-RVA: 0x29AC500 Offset: 0x29A8500 VA: 0x29AC500
	|-Dictionary.ValueCollection.Enumerator<ushort, byte>..ctor
	|
	|-RVA: 0x29ACE08 Offset: 0x29A8E08 VA: 0x29ACE08
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x29B0240 Offset: 0x29AC240 VA: 0x29B0240
	|-Dictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x29B1C74 Offset: 0x29ADC74 VA: 0x29B1C74
	|-Dictionary.ValueCollection.Enumerator<MaterialManager.pair, object>..ctor
	|
	|-RVA: 0x29B253C Offset: 0x29AE53C VA: 0x29B253C
	|-Dictionary.ValueCollection.Enumerator<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x29B2D24 Offset: 0x29AED24 VA: 0x29B2D24
	|-Dictionary.ValueCollection.Enumerator<PartyManager.PartyData.pair, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2981398 Offset: 0x297D398 VA: 0x2981398
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x2981BEC Offset: 0x297DBEC VA: 0x2981BEC
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<object, object>, object>.Dispose
	|
	|-RVA: 0x2982414 Offset: 0x297E414 VA: 0x2982414
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, object>, object>.Dispose
	|
	|-RVA: 0x2982C84 Offset: 0x297EC84 VA: 0x2982C84
	|-Dictionary.ValueCollection.Enumerator<ArchetypeUid, int>.Dispose
	|
	|-RVA: 0x298348C Offset: 0x297F48C VA: 0x298348C
	|-Dictionary.ValueCollection.Enumerator<ArchetypeUid, object>.Dispose
	|
	|-RVA: 0x2983D3C Offset: 0x297FD3C VA: 0x2983D3C
	|-Dictionary.ValueCollection.Enumerator<byte, ValueTuple<short, int, int>>.Dispose
	|
	|-RVA: 0x2984634 Offset: 0x2980634 VA: 0x2984634
	|-Dictionary.ValueCollection.Enumerator<byte, BlackKnightAvatarProperty>.Dispose
	|
	|-RVA: 0x2984F08 Offset: 0x2980F08 VA: 0x2984F08
	|-Dictionary.ValueCollection.Enumerator<byte, BlackKnightCristaProperty>.Dispose
	|
	|-RVA: 0x29857B4 Offset: 0x29817B4 VA: 0x29857B4
	|-Dictionary.ValueCollection.Enumerator<byte, byte>.Dispose
	|
	|-RVA: 0x2986084 Offset: 0x2982084 VA: 0x2986084
	|-Dictionary.ValueCollection.Enumerator<byte, CardData>.Dispose
	|
	|-RVA: 0x298692C Offset: 0x298292C VA: 0x298692C
	|-Dictionary.ValueCollection.Enumerator<byte, short>.Dispose
	|
	|-RVA: 0x29871A8 Offset: 0x29831A8 VA: 0x29871A8
	|-Dictionary.ValueCollection.Enumerator<byte, int>.Dispose
	|
	|-RVA: 0x2987A3C Offset: 0x2983A3C VA: 0x2987A3C
	|-Dictionary.ValueCollection.Enumerator<byte, long>.Dispose
	|
	|-RVA: 0x2988A80 Offset: 0x2984A80 VA: 0x2988A80
	|-Dictionary.ValueCollection.Enumerator<byte, object>.Dispose
	|
	|-RVA: 0x2989728 Offset: 0x2985728 VA: 0x2989728
	|-Dictionary.ValueCollection.Enumerator<byte, float>.Dispose
	|
	|-RVA: 0x2989FD8 Offset: 0x2985FD8 VA: 0x2989FD8
	|-Dictionary.ValueCollection.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.Dispose
	|
	|-RVA: 0x298A7E4 Offset: 0x29867E4 VA: 0x298A7E4
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, object>.Dispose
	|
	|-RVA: 0x298B044 Offset: 0x2987044 VA: 0x298B044
	|-Dictionary.ValueCollection.Enumerator<char, char>.Dispose
	|
	|-RVA: 0x298B8FC Offset: 0x29878FC VA: 0x298B8FC
	|-Dictionary.ValueCollection.Enumerator<DefencePoint2, byte>.Dispose
	|
	|-RVA: 0x298CE6C Offset: 0x2988E6C VA: 0x298CE6C
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.Dispose
	|
	|-RVA: 0x298D6C0 Offset: 0x29896C0 VA: 0x298D6C0
	|-Dictionary.ValueCollection.Enumerator<short, byte>.Dispose
	|
	|-RVA: 0x298DF40 Offset: 0x2989F40 VA: 0x298DF40
	|-Dictionary.ValueCollection.Enumerator<short, short>.Dispose
	|
	|-RVA: 0x298E7BC Offset: 0x298A7BC VA: 0x298E7BC
	|-Dictionary.ValueCollection.Enumerator<short, int>.Dispose
	|
	|-RVA: 0x298EFC0 Offset: 0x298AFC0 VA: 0x298EFC0
	|-Dictionary.ValueCollection.Enumerator<short, object>.Dispose
	|
	|-RVA: 0x298F828 Offset: 0x298B828 VA: 0x298F828
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, bool>.Dispose
	|
	|-RVA: 0x29900A4 Offset: 0x298C0A4 VA: 0x29900A4
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, int>.Dispose
	|
	|-RVA: 0x29908A8 Offset: 0x298C8A8 VA: 0x29908A8
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, object>.Dispose
	|
	|-RVA: 0x299110C Offset: 0x298D10C VA: 0x299110C
	|-Dictionary.ValueCollection.Enumerator<int, bool>.Dispose
	|
	|-RVA: 0x2991980 Offset: 0x298D980 VA: 0x2991980
	|-Dictionary.ValueCollection.Enumerator<int, byte>.Dispose
	|
	|-RVA: 0x299227C Offset: 0x298E27C VA: 0x299227C
	|-Dictionary.ValueCollection.Enumerator<int, Color>.Dispose
	|
	|-RVA: 0x2992B04 Offset: 0x298EB04 VA: 0x2992B04
	|-Dictionary.ValueCollection.Enumerator<int, short>.Dispose
	|
	|-RVA: 0x2993374 Offset: 0x298F374 VA: 0x2993374
	|-Dictionary.ValueCollection.Enumerator<int, int>.Dispose
	|
	|-RVA: 0x2993BE4 Offset: 0x298FBE4 VA: 0x2993BE4
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.Dispose
	|
	|-RVA: 0x2994478 Offset: 0x2990478 VA: 0x2994478
	|-Dictionary.ValueCollection.Enumerator<int, long>.Dispose
	|
	|-RVA: 0x2994D60 Offset: 0x2990D60 VA: 0x2994D60
	|-Dictionary.ValueCollection.Enumerator<int, MaterialSearchData>.Dispose
	|
	|-RVA: 0x2995578 Offset: 0x2991578 VA: 0x2995578
	|-Dictionary.ValueCollection.Enumerator<int, object>.Dispose
	|
	|-RVA: 0x2995E40 Offset: 0x2991E40 VA: 0x2995E40
	|-Dictionary.ValueCollection.Enumerator<int, RenderInstancedDataLayout>.Dispose
	|
	|-RVA: 0x29966D0 Offset: 0x29926D0 VA: 0x29966D0
	|-Dictionary.ValueCollection.Enumerator<int, float>.Dispose
	|
	|-RVA: 0x2996FB8 Offset: 0x2992FB8 VA: 0x2996FB8
	|-Dictionary.ValueCollection.Enumerator<int, Vector3>.Dispose
	|
	|-RVA: 0x29978E0 Offset: 0x29938E0 VA: 0x29978E0
	|-Dictionary.ValueCollection.Enumerator<int, Vector4>.Dispose
	|
	|-RVA: 0x2998240 Offset: 0x2994240 VA: 0x2998240
	|-Dictionary.ValueCollection.Enumerator<int, HouseRecipeManager.RecipeData>.Dispose
	|
	|-RVA: 0x2998BF8 Offset: 0x2994BF8 VA: 0x2998BF8
	|-Dictionary.ValueCollection.Enumerator<int, MasterModelDataManager.ColorListData>.Dispose
	|
	|-RVA: 0x299953C Offset: 0x299553C VA: 0x299953C
	|-Dictionary.ValueCollection.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.Dispose
	|
	|-RVA: 0x2999E14 Offset: 0x2995E14 VA: 0x2999E14
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ArchetypeUid>.Dispose
	|
	|-RVA: 0x299A698 Offset: 0x2996698 VA: 0x299A698
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.Dispose
	|
	|-RVA: 0x299AF0C Offset: 0x2996F0C VA: 0x299AF0C
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, byte>.Dispose
	|
	|-RVA: 0x299B808 Offset: 0x2997808 VA: 0x299B808
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Color>.Dispose
	|
	|-RVA: 0x299C0B0 Offset: 0x29980B0 VA: 0x299C0B0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, DateTime>.Dispose
	|
	|-RVA: 0x299C9F8 Offset: 0x29989F8 VA: 0x299C9F8
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, EnhanceProperties2>.Dispose
	|
	|-RVA: 0x299D2AC Offset: 0x29992AC VA: 0x299D2AC
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, short>.Dispose
	|
	|-RVA: 0x299DB1C Offset: 0x2999B1C VA: 0x299DB1C
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x299E38C Offset: 0x299A38C VA: 0x299E38C
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x299EC20 Offset: 0x299AC20 VA: 0x299EC20
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, long>.Dispose
	|
	|-RVA: 0x299F4BC Offset: 0x299B4BC VA: 0x299F4BC
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int64Enum>.Dispose
	|
	|-RVA: 0x299FCC8 Offset: 0x299BCC8 VA: 0x299FCC8
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.Dispose
	|
	|-RVA: 0x29A052C Offset: 0x299C52C VA: 0x29A052C
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, float>.Dispose
	|
	|-RVA: 0x29A0E14 Offset: 0x299CE14 VA: 0x29A0E14
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Vector3>.Dispose
	|
	|-RVA: 0x29A17A8 Offset: 0x299D7A8 VA: 0x29A17A8
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.Dispose
	|
	|-RVA: 0x29A2084 Offset: 0x299E084 VA: 0x29A2084
	|-Dictionary.ValueCollection.Enumerator<long, bool>.Dispose
	|
	|-RVA: 0x29A2920 Offset: 0x299E920 VA: 0x29A2920
	|-Dictionary.ValueCollection.Enumerator<long, byte>.Dispose
	|
	|-RVA: 0x29A31BC Offset: 0x299F1BC VA: 0x29A31BC
	|-Dictionary.ValueCollection.Enumerator<long, short>.Dispose
	|
	|-RVA: 0x29A39C4 Offset: 0x299F9C4 VA: 0x29A39C4
	|-Dictionary.ValueCollection.Enumerator<long, object>.Dispose
	|
	|-RVA: 0x29A4240 Offset: 0x29A0240 VA: 0x29A4240
	|-Dictionary.ValueCollection.Enumerator<Int64Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x29A4A48 Offset: 0x29A0A48 VA: 0x29A4A48
	|-Dictionary.ValueCollection.Enumerator<Int64Enum, object>.Dispose
	|
	|-RVA: 0x29A5230 Offset: 0x29A1230 VA: 0x29A5230
	|-Dictionary.ValueCollection.Enumerator<IntPtr, object>.Dispose
	|
	|-RVA: 0x29A5A0C Offset: 0x29A1A0C VA: 0x29A5A0C
	|-Dictionary.ValueCollection.Enumerator<object, ValueTuple<object, byte>>.Dispose
	|
	|-RVA: 0x29A621C Offset: 0x29A221C VA: 0x29A621C
	|-Dictionary.ValueCollection.Enumerator<object, ValueTuple<float, object>>.Dispose
	|
	|-RVA: 0x29A6A0C Offset: 0x29A2A0C VA: 0x29A6A0C
	|-Dictionary.ValueCollection.Enumerator<object, bool>.Dispose
	|
	|-RVA: 0x29A71E0 Offset: 0x29A31E0 VA: 0x29A71E0
	|-Dictionary.ValueCollection.Enumerator<object, byte>.Dispose
	|
	|-RVA: 0x29A79B4 Offset: 0x29A39B4 VA: 0x29A79B4
	|-Dictionary.ValueCollection.Enumerator<object, short>.Dispose
	|
	|-RVA: 0x29A8188 Offset: 0x29A4188 VA: 0x29A8188
	|-Dictionary.ValueCollection.Enumerator<object, int>.Dispose
	|
	|-RVA: 0x29A895C Offset: 0x29A495C VA: 0x29A895C
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.Dispose
	|
	|-RVA: 0x29A94BC Offset: 0x29A54BC VA: 0x29A94BC
	|-Dictionary.ValueCollection.Enumerator<object, object>.Dispose
	|
	|-RVA: 0x29A9C98 Offset: 0x29A5C98 VA: 0x29A9C98
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.Dispose
	|
	|-RVA: 0x29AA488 Offset: 0x29A6488 VA: 0x29AA488
	|-Dictionary.ValueCollection.Enumerator<object, float>.Dispose
	|
	|-RVA: 0x29AACC0 Offset: 0x29A6CC0 VA: 0x29AACC0
	|-Dictionary.ValueCollection.Enumerator<object, Vector3>.Dispose
	|
	|-RVA: 0x29AB4D4 Offset: 0x29A74D4 VA: 0x29AB4D4
	|-Dictionary.ValueCollection.Enumerator<object, DeathReceptionAction.PoisonTargetData>.Dispose
	|
	|-RVA: 0x29ABCB8 Offset: 0x29A7CB8 VA: 0x29ABCB8
	|-Dictionary.ValueCollection.Enumerator<object, UIHouseAddressManager.Town>.Dispose
	|
	|-RVA: 0x29AC538 Offset: 0x29A8538 VA: 0x29AC538
	|-Dictionary.ValueCollection.Enumerator<ushort, byte>.Dispose
	|
	|-RVA: 0x29ACE40 Offset: 0x29A8E40 VA: 0x29ACE40
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>.Dispose
	|
	|-RVA: 0x29B035C Offset: 0x29AC35C VA: 0x29B035C
	|-Dictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	|
	|-RVA: 0x29B1CAC Offset: 0x29ADCAC VA: 0x29B1CAC
	|-Dictionary.ValueCollection.Enumerator<MaterialManager.pair, object>.Dispose
	|
	|-RVA: 0x29B2574 Offset: 0x29AE574 VA: 0x29B2574
	|-Dictionary.ValueCollection.Enumerator<Regex.CachedCodeEntryKey, object>.Dispose
	|
	|-RVA: 0x29B2D5C Offset: 0x29AED5C VA: 0x29B2D5C
	|-Dictionary.ValueCollection.Enumerator<PartyManager.PartyData.pair, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x298139C Offset: 0x297D39C VA: 0x298139C
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x2981BF0 Offset: 0x297DBF0 VA: 0x2981BF0
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x2982418 Offset: 0x297E418 VA: 0x2982418
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, object>, object>.MoveNext
	|
	|-RVA: 0x2982C88 Offset: 0x297EC88 VA: 0x2982C88
	|-Dictionary.ValueCollection.Enumerator<ArchetypeUid, int>.MoveNext
	|
	|-RVA: 0x2983490 Offset: 0x297F490 VA: 0x2983490
	|-Dictionary.ValueCollection.Enumerator<ArchetypeUid, object>.MoveNext
	|
	|-RVA: 0x2983D40 Offset: 0x297FD40 VA: 0x2983D40
	|-Dictionary.ValueCollection.Enumerator<byte, ValueTuple<short, int, int>>.MoveNext
	|
	|-RVA: 0x2984638 Offset: 0x2980638 VA: 0x2984638
	|-Dictionary.ValueCollection.Enumerator<byte, BlackKnightAvatarProperty>.MoveNext
	|
	|-RVA: 0x2984F0C Offset: 0x2980F0C VA: 0x2984F0C
	|-Dictionary.ValueCollection.Enumerator<byte, BlackKnightCristaProperty>.MoveNext
	|
	|-RVA: 0x29857B8 Offset: 0x29817B8 VA: 0x29857B8
	|-Dictionary.ValueCollection.Enumerator<byte, byte>.MoveNext
	|
	|-RVA: 0x2986088 Offset: 0x2982088 VA: 0x2986088
	|-Dictionary.ValueCollection.Enumerator<byte, CardData>.MoveNext
	|
	|-RVA: 0x2986930 Offset: 0x2982930 VA: 0x2986930
	|-Dictionary.ValueCollection.Enumerator<byte, short>.MoveNext
	|
	|-RVA: 0x29871AC Offset: 0x29831AC VA: 0x29871AC
	|-Dictionary.ValueCollection.Enumerator<byte, int>.MoveNext
	|
	|-RVA: 0x2987A40 Offset: 0x2983A40 VA: 0x2987A40
	|-Dictionary.ValueCollection.Enumerator<byte, long>.MoveNext
	|
	|-RVA: 0x2988A84 Offset: 0x2984A84 VA: 0x2988A84
	|-Dictionary.ValueCollection.Enumerator<byte, object>.MoveNext
	|
	|-RVA: 0x298972C Offset: 0x298572C VA: 0x298972C
	|-Dictionary.ValueCollection.Enumerator<byte, float>.MoveNext
	|
	|-RVA: 0x2989FDC Offset: 0x2985FDC VA: 0x2989FDC
	|-Dictionary.ValueCollection.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.MoveNext
	|
	|-RVA: 0x298A7E8 Offset: 0x29867E8 VA: 0x298A7E8
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, object>.MoveNext
	|
	|-RVA: 0x298B048 Offset: 0x2987048 VA: 0x298B048
	|-Dictionary.ValueCollection.Enumerator<char, char>.MoveNext
	|
	|-RVA: 0x298B900 Offset: 0x2987900 VA: 0x298B900
	|-Dictionary.ValueCollection.Enumerator<DefencePoint2, byte>.MoveNext
	|
	|-RVA: 0x298CE70 Offset: 0x2988E70 VA: 0x298CE70
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.MoveNext
	|
	|-RVA: 0x298D6C4 Offset: 0x29896C4 VA: 0x298D6C4
	|-Dictionary.ValueCollection.Enumerator<short, byte>.MoveNext
	|
	|-RVA: 0x298DF44 Offset: 0x2989F44 VA: 0x298DF44
	|-Dictionary.ValueCollection.Enumerator<short, short>.MoveNext
	|
	|-RVA: 0x298E7C0 Offset: 0x298A7C0 VA: 0x298E7C0
	|-Dictionary.ValueCollection.Enumerator<short, int>.MoveNext
	|
	|-RVA: 0x298EFC4 Offset: 0x298AFC4 VA: 0x298EFC4
	|-Dictionary.ValueCollection.Enumerator<short, object>.MoveNext
	|
	|-RVA: 0x298F82C Offset: 0x298B82C VA: 0x298F82C
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, bool>.MoveNext
	|
	|-RVA: 0x29900A8 Offset: 0x298C0A8 VA: 0x29900A8
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, int>.MoveNext
	|
	|-RVA: 0x29908AC Offset: 0x298C8AC VA: 0x29908AC
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, object>.MoveNext
	|
	|-RVA: 0x2991110 Offset: 0x298D110 VA: 0x2991110
	|-Dictionary.ValueCollection.Enumerator<int, bool>.MoveNext
	|
	|-RVA: 0x2991984 Offset: 0x298D984 VA: 0x2991984
	|-Dictionary.ValueCollection.Enumerator<int, byte>.MoveNext
	|
	|-RVA: 0x2992280 Offset: 0x298E280 VA: 0x2992280
	|-Dictionary.ValueCollection.Enumerator<int, Color>.MoveNext
	|
	|-RVA: 0x2992B08 Offset: 0x298EB08 VA: 0x2992B08
	|-Dictionary.ValueCollection.Enumerator<int, short>.MoveNext
	|
	|-RVA: 0x2993378 Offset: 0x298F378 VA: 0x2993378
	|-Dictionary.ValueCollection.Enumerator<int, int>.MoveNext
	|
	|-RVA: 0x2993BE8 Offset: 0x298FBE8 VA: 0x2993BE8
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.MoveNext
	|
	|-RVA: 0x299447C Offset: 0x299047C VA: 0x299447C
	|-Dictionary.ValueCollection.Enumerator<int, long>.MoveNext
	|
	|-RVA: 0x2994D64 Offset: 0x2990D64 VA: 0x2994D64
	|-Dictionary.ValueCollection.Enumerator<int, MaterialSearchData>.MoveNext
	|
	|-RVA: 0x299557C Offset: 0x299157C VA: 0x299557C
	|-Dictionary.ValueCollection.Enumerator<int, object>.MoveNext
	|
	|-RVA: 0x2995E44 Offset: 0x2991E44 VA: 0x2995E44
	|-Dictionary.ValueCollection.Enumerator<int, RenderInstancedDataLayout>.MoveNext
	|
	|-RVA: 0x29966D4 Offset: 0x29926D4 VA: 0x29966D4
	|-Dictionary.ValueCollection.Enumerator<int, float>.MoveNext
	|
	|-RVA: 0x2996FBC Offset: 0x2992FBC VA: 0x2996FBC
	|-Dictionary.ValueCollection.Enumerator<int, Vector3>.MoveNext
	|
	|-RVA: 0x29978E4 Offset: 0x29938E4 VA: 0x29978E4
	|-Dictionary.ValueCollection.Enumerator<int, Vector4>.MoveNext
	|
	|-RVA: 0x2998244 Offset: 0x2994244 VA: 0x2998244
	|-Dictionary.ValueCollection.Enumerator<int, HouseRecipeManager.RecipeData>.MoveNext
	|
	|-RVA: 0x2998BFC Offset: 0x2994BFC VA: 0x2998BFC
	|-Dictionary.ValueCollection.Enumerator<int, MasterModelDataManager.ColorListData>.MoveNext
	|
	|-RVA: 0x2999540 Offset: 0x2995540 VA: 0x2999540
	|-Dictionary.ValueCollection.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.MoveNext
	|
	|-RVA: 0x2999E18 Offset: 0x2995E18 VA: 0x2999E18
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ArchetypeUid>.MoveNext
	|
	|-RVA: 0x299A69C Offset: 0x299669C VA: 0x299A69C
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x299AF10 Offset: 0x2996F10 VA: 0x299AF10
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, byte>.MoveNext
	|
	|-RVA: 0x299B80C Offset: 0x299780C VA: 0x299B80C
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Color>.MoveNext
	|
	|-RVA: 0x299C0B4 Offset: 0x29980B4 VA: 0x299C0B4
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, DateTime>.MoveNext
	|
	|-RVA: 0x299C9FC Offset: 0x29989FC VA: 0x299C9FC
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, EnhanceProperties2>.MoveNext
	|
	|-RVA: 0x299D2B0 Offset: 0x29992B0 VA: 0x299D2B0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, short>.MoveNext
	|
	|-RVA: 0x299DB20 Offset: 0x2999B20 VA: 0x299DB20
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x299E390 Offset: 0x299A390 VA: 0x299E390
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x299EC24 Offset: 0x299AC24 VA: 0x299EC24
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x299F4C0 Offset: 0x299B4C0 VA: 0x299F4C0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int64Enum>.MoveNext
	|
	|-RVA: 0x299FCCC Offset: 0x299BCCC VA: 0x299FCCC
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x29A0530 Offset: 0x299C530 VA: 0x29A0530
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x29A0E18 Offset: 0x299CE18 VA: 0x29A0E18
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Vector3>.MoveNext
	|
	|-RVA: 0x29A17AC Offset: 0x299D7AC VA: 0x29A17AC
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.MoveNext
	|
	|-RVA: 0x29A2088 Offset: 0x299E088 VA: 0x29A2088
	|-Dictionary.ValueCollection.Enumerator<long, bool>.MoveNext
	|
	|-RVA: 0x29A2924 Offset: 0x299E924 VA: 0x29A2924
	|-Dictionary.ValueCollection.Enumerator<long, byte>.MoveNext
	|
	|-RVA: 0x29A31C0 Offset: 0x299F1C0 VA: 0x29A31C0
	|-Dictionary.ValueCollection.Enumerator<long, short>.MoveNext
	|
	|-RVA: 0x29A39C8 Offset: 0x299F9C8 VA: 0x29A39C8
	|-Dictionary.ValueCollection.Enumerator<long, object>.MoveNext
	|
	|-RVA: 0x29A4244 Offset: 0x29A0244 VA: 0x29A4244
	|-Dictionary.ValueCollection.Enumerator<Int64Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x29A4A4C Offset: 0x29A0A4C VA: 0x29A4A4C
	|-Dictionary.ValueCollection.Enumerator<Int64Enum, object>.MoveNext
	|
	|-RVA: 0x29A5234 Offset: 0x29A1234 VA: 0x29A5234
	|-Dictionary.ValueCollection.Enumerator<IntPtr, object>.MoveNext
	|
	|-RVA: 0x29A5A10 Offset: 0x29A1A10 VA: 0x29A5A10
	|-Dictionary.ValueCollection.Enumerator<object, ValueTuple<object, byte>>.MoveNext
	|
	|-RVA: 0x29A6220 Offset: 0x29A2220 VA: 0x29A6220
	|-Dictionary.ValueCollection.Enumerator<object, ValueTuple<float, object>>.MoveNext
	|
	|-RVA: 0x29A6A10 Offset: 0x29A2A10 VA: 0x29A6A10
	|-Dictionary.ValueCollection.Enumerator<object, bool>.MoveNext
	|
	|-RVA: 0x29A71E4 Offset: 0x29A31E4 VA: 0x29A71E4
	|-Dictionary.ValueCollection.Enumerator<object, byte>.MoveNext
	|
	|-RVA: 0x29A79B8 Offset: 0x29A39B8 VA: 0x29A79B8
	|-Dictionary.ValueCollection.Enumerator<object, short>.MoveNext
	|
	|-RVA: 0x29A818C Offset: 0x29A418C VA: 0x29A818C
	|-Dictionary.ValueCollection.Enumerator<object, int>.MoveNext
	|
	|-RVA: 0x29A8960 Offset: 0x29A4960 VA: 0x29A8960
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x29A94C0 Offset: 0x29A54C0 VA: 0x29A94C0
	|-Dictionary.ValueCollection.Enumerator<object, object>.MoveNext
	|
	|-RVA: 0x29A9C9C Offset: 0x29A5C9C VA: 0x29A9C9C
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.MoveNext
	|
	|-RVA: 0x29AA48C Offset: 0x29A648C VA: 0x29AA48C
	|-Dictionary.ValueCollection.Enumerator<object, float>.MoveNext
	|
	|-RVA: 0x29AACC4 Offset: 0x29A6CC4 VA: 0x29AACC4
	|-Dictionary.ValueCollection.Enumerator<object, Vector3>.MoveNext
	|
	|-RVA: 0x29AB4D8 Offset: 0x29A74D8 VA: 0x29AB4D8
	|-Dictionary.ValueCollection.Enumerator<object, DeathReceptionAction.PoisonTargetData>.MoveNext
	|
	|-RVA: 0x29ABCBC Offset: 0x29A7CBC VA: 0x29ABCBC
	|-Dictionary.ValueCollection.Enumerator<object, UIHouseAddressManager.Town>.MoveNext
	|
	|-RVA: 0x29AC53C Offset: 0x29A853C VA: 0x29AC53C
	|-Dictionary.ValueCollection.Enumerator<ushort, byte>.MoveNext
	|
	|-RVA: 0x29ACE44 Offset: 0x29A8E44 VA: 0x29ACE44
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>.MoveNext
	|
	|-RVA: 0x29B0360 Offset: 0x29AC360 VA: 0x29B0360
	|-Dictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x29B1CB0 Offset: 0x29ADCB0 VA: 0x29B1CB0
	|-Dictionary.ValueCollection.Enumerator<MaterialManager.pair, object>.MoveNext
	|
	|-RVA: 0x29B2578 Offset: 0x29AE578 VA: 0x29B2578
	|-Dictionary.ValueCollection.Enumerator<Regex.CachedCodeEntryKey, object>.MoveNext
	|
	|-RVA: 0x29B2D60 Offset: 0x29AED60 VA: 0x29B2D60
	|-Dictionary.ValueCollection.Enumerator<PartyManager.PartyData.pair, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2981450 Offset: 0x297D450 VA: 0x2981450
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x2981CA8 Offset: 0x297DCA8 VA: 0x2981CA8
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<object, object>, object>.get_Current
	|
	|-RVA: 0x29824D0 Offset: 0x297E4D0 VA: 0x29824D0
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, object>, object>.get_Current
	|
	|-RVA: 0x2982D3C Offset: 0x297ED3C VA: 0x2982D3C
	|-Dictionary.ValueCollection.Enumerator<ArchetypeUid, int>.get_Current
	|
	|-RVA: 0x2983554 Offset: 0x297F554 VA: 0x2983554
	|-Dictionary.ValueCollection.Enumerator<ArchetypeUid, object>.get_Current
	|
	|-RVA: 0x2983E00 Offset: 0x297FE00 VA: 0x2983E00
	|-Dictionary.ValueCollection.Enumerator<byte, ValueTuple<short, int, int>>.get_Current
	|
	|-RVA: 0x29846F8 Offset: 0x29806F8 VA: 0x29846F8
	|-Dictionary.ValueCollection.Enumerator<byte, BlackKnightAvatarProperty>.get_Current
	|
	|-RVA: 0x2984FCC Offset: 0x2980FCC VA: 0x2984FCC
	|-Dictionary.ValueCollection.Enumerator<byte, BlackKnightCristaProperty>.get_Current
	|
	|-RVA: 0x298586C Offset: 0x298186C VA: 0x298586C
	|-Dictionary.ValueCollection.Enumerator<byte, byte>.get_Current
	|
	|-RVA: 0x2986148 Offset: 0x2982148 VA: 0x2986148
	|-Dictionary.ValueCollection.Enumerator<byte, CardData>.get_Current
	|
	|-RVA: 0x29869E4 Offset: 0x29829E4 VA: 0x29869E4
	|-Dictionary.ValueCollection.Enumerator<byte, short>.get_Current
	|
	|-RVA: 0x2987258 Offset: 0x2983258 VA: 0x2987258
	|-Dictionary.ValueCollection.Enumerator<byte, int>.get_Current
	|
	|-RVA: 0x2987AF4 Offset: 0x2983AF4 VA: 0x2987AF4
	|-Dictionary.ValueCollection.Enumerator<byte, long>.get_Current
	|
	|-RVA: 0x2988B48 Offset: 0x2984B48 VA: 0x2988B48
	|-Dictionary.ValueCollection.Enumerator<byte, object>.get_Current
	|
	|-RVA: 0x29897D8 Offset: 0x29857D8 VA: 0x29897D8
	|-Dictionary.ValueCollection.Enumerator<byte, float>.get_Current
	|
	|-RVA: 0x298A090 Offset: 0x2986090 VA: 0x298A090
	|-Dictionary.ValueCollection.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.get_Current
	|
	|-RVA: 0x298A8AC Offset: 0x29868AC VA: 0x298A8AC
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, object>.get_Current
	|
	|-RVA: 0x298B0FC Offset: 0x29870FC VA: 0x298B0FC
	|-Dictionary.ValueCollection.Enumerator<char, char>.get_Current
	|
	|-RVA: 0x298B9B4 Offset: 0x29879B4 VA: 0x298B9B4
	|-Dictionary.ValueCollection.Enumerator<DefencePoint2, byte>.get_Current
	|
	|-RVA: 0x298CF28 Offset: 0x2988F28 VA: 0x298CF28
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.get_Current
	|
	|-RVA: 0x298D778 Offset: 0x2989778 VA: 0x298D778
	|-Dictionary.ValueCollection.Enumerator<short, byte>.get_Current
	|
	|-RVA: 0x298DFF8 Offset: 0x2989FF8 VA: 0x298DFF8
	|-Dictionary.ValueCollection.Enumerator<short, short>.get_Current
	|
	|-RVA: 0x298E86C Offset: 0x298A86C VA: 0x298E86C
	|-Dictionary.ValueCollection.Enumerator<short, int>.get_Current
	|
	|-RVA: 0x298F088 Offset: 0x298B088 VA: 0x298F088
	|-Dictionary.ValueCollection.Enumerator<short, object>.get_Current
	|
	|-RVA: 0x298F8E0 Offset: 0x298B8E0 VA: 0x298F8E0
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, bool>.get_Current
	|
	|-RVA: 0x2990154 Offset: 0x298C154 VA: 0x2990154
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, int>.get_Current
	|
	|-RVA: 0x2990970 Offset: 0x298C970 VA: 0x2990970
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, object>.get_Current
	|
	|-RVA: 0x29911BC Offset: 0x298D1BC VA: 0x29911BC
	|-Dictionary.ValueCollection.Enumerator<int, bool>.get_Current
	|
	|-RVA: 0x2991A30 Offset: 0x298DA30 VA: 0x2991A30
	|-Dictionary.ValueCollection.Enumerator<int, byte>.get_Current
	|
	|-RVA: 0x2992334 Offset: 0x298E334 VA: 0x2992334
	|-Dictionary.ValueCollection.Enumerator<int, Color>.get_Current
	|
	|-RVA: 0x2992BB4 Offset: 0x298EBB4 VA: 0x2992BB4
	|-Dictionary.ValueCollection.Enumerator<int, short>.get_Current
	|
	|-RVA: 0x2993424 Offset: 0x298F424 VA: 0x2993424
	|-Dictionary.ValueCollection.Enumerator<int, int>.get_Current
	|
	|-RVA: 0x2993C94 Offset: 0x298FC94 VA: 0x2993C94
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.get_Current
	|
	|-RVA: 0x2994530 Offset: 0x2990530 VA: 0x2994530
	|-Dictionary.ValueCollection.Enumerator<int, long>.get_Current
	|
	|-RVA: 0x2994E18 Offset: 0x2990E18 VA: 0x2994E18
	|-Dictionary.ValueCollection.Enumerator<int, MaterialSearchData>.get_Current
	|
	|-RVA: 0x2995640 Offset: 0x2991640 VA: 0x2995640
	|-Dictionary.ValueCollection.Enumerator<int, object>.get_Current
	|
	|-RVA: 0x2995EF8 Offset: 0x2991EF8 VA: 0x2995EF8
	|-Dictionary.ValueCollection.Enumerator<int, RenderInstancedDataLayout>.get_Current
	|
	|-RVA: 0x2996780 Offset: 0x2992780 VA: 0x2996780
	|-Dictionary.ValueCollection.Enumerator<int, float>.get_Current
	|
	|-RVA: 0x299707C Offset: 0x299307C VA: 0x299707C
	|-Dictionary.ValueCollection.Enumerator<int, Vector3>.get_Current
	|
	|-RVA: 0x2997998 Offset: 0x2993998 VA: 0x2997998
	|-Dictionary.ValueCollection.Enumerator<int, Vector4>.get_Current
	|
	|-RVA: 0x299831C Offset: 0x299431C VA: 0x299831C
	|-Dictionary.ValueCollection.Enumerator<int, HouseRecipeManager.RecipeData>.get_Current
	|
	|-RVA: 0x2998CC4 Offset: 0x2994CC4 VA: 0x2998CC4
	|-Dictionary.ValueCollection.Enumerator<int, MasterModelDataManager.ColorListData>.get_Current
	|
	|-RVA: 0x299960C Offset: 0x299560C VA: 0x299960C
	|-Dictionary.ValueCollection.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.get_Current
	|
	|-RVA: 0x2999ECC Offset: 0x2995ECC VA: 0x2999ECC
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ArchetypeUid>.get_Current
	|
	|-RVA: 0x299A748 Offset: 0x2996748 VA: 0x299A748
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.get_Current
	|
	|-RVA: 0x299AFBC Offset: 0x2996FBC VA: 0x299AFBC
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, byte>.get_Current
	|
	|-RVA: 0x299B8C0 Offset: 0x29978C0 VA: 0x299B8C0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Color>.get_Current
	|
	|-RVA: 0x299C168 Offset: 0x2998168 VA: 0x299C168
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, DateTime>.get_Current
	|
	|-RVA: 0x299CAC4 Offset: 0x2998AC4 VA: 0x299CAC4
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, EnhanceProperties2>.get_Current
	|
	|-RVA: 0x299D35C Offset: 0x299935C VA: 0x299D35C
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, short>.get_Current
	|
	|-RVA: 0x299DBCC Offset: 0x2999BCC VA: 0x299DBCC
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.get_Current
	|
	|-RVA: 0x299E43C Offset: 0x299A43C VA: 0x299E43C
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.get_Current
	|
	|-RVA: 0x299ECD8 Offset: 0x299ACD8 VA: 0x299ECD8
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, long>.get_Current
	|
	|-RVA: 0x299F574 Offset: 0x299B574 VA: 0x299F574
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int64Enum>.get_Current
	|
	|-RVA: 0x299FD90 Offset: 0x299BD90 VA: 0x299FD90
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.get_Current
	|
	|-RVA: 0x29A05DC Offset: 0x299C5DC VA: 0x29A05DC
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, float>.get_Current
	|
	|-RVA: 0x29A0ED8 Offset: 0x299CED8 VA: 0x29A0ED8
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Vector3>.get_Current
	|
	|-RVA: 0x29A1874 Offset: 0x299D874 VA: 0x29A1874
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.get_Current
	|
	|-RVA: 0x29A213C Offset: 0x299E13C VA: 0x29A213C
	|-Dictionary.ValueCollection.Enumerator<long, bool>.get_Current
	|
	|-RVA: 0x29A29D8 Offset: 0x299E9D8 VA: 0x29A29D8
	|-Dictionary.ValueCollection.Enumerator<long, byte>.get_Current
	|
	|-RVA: 0x29A3274 Offset: 0x299F274 VA: 0x29A3274
	|-Dictionary.ValueCollection.Enumerator<long, short>.get_Current
	|
	|-RVA: 0x29A3A8C Offset: 0x299FA8C VA: 0x29A3A8C
	|-Dictionary.ValueCollection.Enumerator<long, object>.get_Current
	|
	|-RVA: 0x29A42F8 Offset: 0x29A02F8 VA: 0x29A42F8
	|-Dictionary.ValueCollection.Enumerator<Int64Enum, Int32Enum>.get_Current
	|
	|-RVA: 0x29A4B10 Offset: 0x29A0B10 VA: 0x29A4B10
	|-Dictionary.ValueCollection.Enumerator<Int64Enum, object>.get_Current
	|
	|-RVA: 0x29A52F8 Offset: 0x29A12F8 VA: 0x29A52F8
	|-Dictionary.ValueCollection.Enumerator<IntPtr, object>.get_Current
	|
	|-RVA: 0x29A5ACC Offset: 0x29A1ACC VA: 0x29A5ACC
	|-Dictionary.ValueCollection.Enumerator<object, ValueTuple<object, byte>>.get_Current
	|
	|-RVA: 0x29A62DC Offset: 0x29A22DC VA: 0x29A62DC
	|-Dictionary.ValueCollection.Enumerator<object, ValueTuple<float, object>>.get_Current
	|
	|-RVA: 0x29A6AC4 Offset: 0x29A2AC4 VA: 0x29A6AC4
	|-Dictionary.ValueCollection.Enumerator<object, bool>.get_Current
	|
	|-RVA: 0x29A7298 Offset: 0x29A3298 VA: 0x29A7298
	|-Dictionary.ValueCollection.Enumerator<object, byte>.get_Current
	|
	|-RVA: 0x29A7A6C Offset: 0x29A3A6C VA: 0x29A7A6C
	|-Dictionary.ValueCollection.Enumerator<object, short>.get_Current
	|
	|-RVA: 0x29A8240 Offset: 0x29A4240 VA: 0x29A8240
	|-Dictionary.ValueCollection.Enumerator<object, int>.get_Current
	|
	|-RVA: 0x29A8A14 Offset: 0x29A4A14 VA: 0x29A8A14
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.get_Current
	|
	|-RVA: 0x29A9584 Offset: 0x29A5584 VA: 0x29A9584
	|-Dictionary.ValueCollection.Enumerator<object, object>.get_Current
	|
	|-RVA: 0x29A9D58 Offset: 0x29A5D58 VA: 0x29A9D58
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.get_Current
	|
	|-RVA: 0x29AA540 Offset: 0x29A6540 VA: 0x29AA540
	|-Dictionary.ValueCollection.Enumerator<object, float>.get_Current
	|
	|-RVA: 0x29AAD78 Offset: 0x29A6D78 VA: 0x29AAD78
	|-Dictionary.ValueCollection.Enumerator<object, Vector3>.get_Current
	|
	|-RVA: 0x29AB594 Offset: 0x29A7594 VA: 0x29AB594
	|-Dictionary.ValueCollection.Enumerator<object, DeathReceptionAction.PoisonTargetData>.get_Current
	|
	|-RVA: 0x29ABD70 Offset: 0x29A7D70 VA: 0x29ABD70
	|-Dictionary.ValueCollection.Enumerator<object, UIHouseAddressManager.Town>.get_Current
	|
	|-RVA: 0x29AC5F0 Offset: 0x29A85F0 VA: 0x29AC5F0
	|-Dictionary.ValueCollection.Enumerator<ushort, byte>.get_Current
	|
	|-RVA: 0x29ACF0C Offset: 0x29A8F0C VA: 0x29ACF0C
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>.get_Current
	|
	|-RVA: 0x29B06A8 Offset: 0x29AC6A8 VA: 0x29B06A8
	|-Dictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	|
	|-RVA: 0x29B1D74 Offset: 0x29ADD74 VA: 0x29B1D74
	|-Dictionary.ValueCollection.Enumerator<MaterialManager.pair, object>.get_Current
	|
	|-RVA: 0x29B263C Offset: 0x29AE63C VA: 0x29B263C
	|-Dictionary.ValueCollection.Enumerator<Regex.CachedCodeEntryKey, object>.get_Current
	|
	|-RVA: 0x29B2E24 Offset: 0x29AEE24 VA: 0x29B2E24
	|-Dictionary.ValueCollection.Enumerator<PartyManager.PartyData.pair, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2981458 Offset: 0x297D458 VA: 0x2981458
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2981CB0 Offset: 0x297DCB0 VA: 0x2981CB0
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29824D8 Offset: 0x297E4D8 VA: 0x29824D8
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, object>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2982D44 Offset: 0x297ED44 VA: 0x2982D44
	|-Dictionary.ValueCollection.Enumerator<ArchetypeUid, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298355C Offset: 0x297F55C VA: 0x298355C
	|-Dictionary.ValueCollection.Enumerator<ArchetypeUid, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2983E10 Offset: 0x297FE10 VA: 0x2983E10
	|-Dictionary.ValueCollection.Enumerator<byte, ValueTuple<short, int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2984708 Offset: 0x2980708 VA: 0x2984708
	|-Dictionary.ValueCollection.Enumerator<byte, BlackKnightAvatarProperty>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2984FDC Offset: 0x2980FDC VA: 0x2984FDC
	|-Dictionary.ValueCollection.Enumerator<byte, BlackKnightCristaProperty>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2985874 Offset: 0x2981874 VA: 0x2985874
	|-Dictionary.ValueCollection.Enumerator<byte, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2986158 Offset: 0x2982158 VA: 0x2986158
	|-Dictionary.ValueCollection.Enumerator<byte, CardData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29869EC Offset: 0x29829EC VA: 0x29869EC
	|-Dictionary.ValueCollection.Enumerator<byte, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2987260 Offset: 0x2983260 VA: 0x2987260
	|-Dictionary.ValueCollection.Enumerator<byte, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2987AFC Offset: 0x2983AFC VA: 0x2987AFC
	|-Dictionary.ValueCollection.Enumerator<byte, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2988B50 Offset: 0x2984B50 VA: 0x2988B50
	|-Dictionary.ValueCollection.Enumerator<byte, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29897E0 Offset: 0x29857E0 VA: 0x29897E0
	|-Dictionary.ValueCollection.Enumerator<byte, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298A098 Offset: 0x2986098 VA: 0x298A098
	|-Dictionary.ValueCollection.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298A8B4 Offset: 0x29868B4 VA: 0x298A8B4
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298B104 Offset: 0x2987104 VA: 0x298B104
	|-Dictionary.ValueCollection.Enumerator<char, char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298B9BC Offset: 0x29879BC VA: 0x298B9BC
	|-Dictionary.ValueCollection.Enumerator<DefencePoint2, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298CF30 Offset: 0x2988F30 VA: 0x298CF30
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298D780 Offset: 0x2989780 VA: 0x298D780
	|-Dictionary.ValueCollection.Enumerator<short, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298E000 Offset: 0x298A000 VA: 0x298E000
	|-Dictionary.ValueCollection.Enumerator<short, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298E874 Offset: 0x298A874 VA: 0x298E874
	|-Dictionary.ValueCollection.Enumerator<short, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298F090 Offset: 0x298B090 VA: 0x298F090
	|-Dictionary.ValueCollection.Enumerator<short, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298F8E8 Offset: 0x298B8E8 VA: 0x298F8E8
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299015C Offset: 0x298C15C VA: 0x299015C
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2990978 Offset: 0x298C978 VA: 0x2990978
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29911C4 Offset: 0x298D1C4 VA: 0x29911C4
	|-Dictionary.ValueCollection.Enumerator<int, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2991A38 Offset: 0x298DA38 VA: 0x2991A38
	|-Dictionary.ValueCollection.Enumerator<int, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2992340 Offset: 0x298E340 VA: 0x2992340
	|-Dictionary.ValueCollection.Enumerator<int, Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2992BBC Offset: 0x298EBBC VA: 0x2992BBC
	|-Dictionary.ValueCollection.Enumerator<int, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299342C Offset: 0x298F42C VA: 0x299342C
	|-Dictionary.ValueCollection.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2993C9C Offset: 0x298FC9C VA: 0x2993C9C
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2994538 Offset: 0x2990538 VA: 0x2994538
	|-Dictionary.ValueCollection.Enumerator<int, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2994E24 Offset: 0x2990E24 VA: 0x2994E24
	|-Dictionary.ValueCollection.Enumerator<int, MaterialSearchData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2995648 Offset: 0x2991648 VA: 0x2995648
	|-Dictionary.ValueCollection.Enumerator<int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2995F04 Offset: 0x2991F04 VA: 0x2995F04
	|-Dictionary.ValueCollection.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2996788 Offset: 0x2992788 VA: 0x2996788
	|-Dictionary.ValueCollection.Enumerator<int, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2997088 Offset: 0x2993088 VA: 0x2997088
	|-Dictionary.ValueCollection.Enumerator<int, Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29979A4 Offset: 0x29939A4 VA: 0x29979A4
	|-Dictionary.ValueCollection.Enumerator<int, Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2998330 Offset: 0x2994330 VA: 0x2998330
	|-Dictionary.ValueCollection.Enumerator<int, HouseRecipeManager.RecipeData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2998CD8 Offset: 0x2994CD8 VA: 0x2998CD8
	|-Dictionary.ValueCollection.Enumerator<int, MasterModelDataManager.ColorListData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2999620 Offset: 0x2995620 VA: 0x2999620
	|-Dictionary.ValueCollection.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2999ED4 Offset: 0x2995ED4 VA: 0x2999ED4
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ArchetypeUid>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299A750 Offset: 0x2996750 VA: 0x299A750
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299AFC4 Offset: 0x2996FC4 VA: 0x299AFC4
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299B8CC Offset: 0x29978CC VA: 0x299B8CC
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299C170 Offset: 0x2998170 VA: 0x299C170
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, DateTime>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299CAD8 Offset: 0x2998AD8 VA: 0x299CAD8
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, EnhanceProperties2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299D364 Offset: 0x2999364 VA: 0x299D364
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299DBD4 Offset: 0x2999BD4 VA: 0x299DBD4
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299E444 Offset: 0x299A444 VA: 0x299E444
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299ECE0 Offset: 0x299ACE0 VA: 0x299ECE0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299F57C Offset: 0x299B57C VA: 0x299F57C
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int64Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299FD98 Offset: 0x299BD98 VA: 0x299FD98
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A05E4 Offset: 0x299C5E4 VA: 0x29A05E4
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A0EE4 Offset: 0x299CEE4 VA: 0x29A0EE4
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A1888 Offset: 0x299D888 VA: 0x29A1888
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A2144 Offset: 0x299E144 VA: 0x29A2144
	|-Dictionary.ValueCollection.Enumerator<long, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A29E0 Offset: 0x299E9E0 VA: 0x29A29E0
	|-Dictionary.ValueCollection.Enumerator<long, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A327C Offset: 0x299F27C VA: 0x29A327C
	|-Dictionary.ValueCollection.Enumerator<long, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A3A94 Offset: 0x299FA94 VA: 0x29A3A94
	|-Dictionary.ValueCollection.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A4300 Offset: 0x29A0300 VA: 0x29A4300
	|-Dictionary.ValueCollection.Enumerator<Int64Enum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A4B18 Offset: 0x29A0B18 VA: 0x29A4B18
	|-Dictionary.ValueCollection.Enumerator<Int64Enum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A5300 Offset: 0x29A1300 VA: 0x29A5300
	|-Dictionary.ValueCollection.Enumerator<IntPtr, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A5AD8 Offset: 0x29A1AD8 VA: 0x29A5AD8
	|-Dictionary.ValueCollection.Enumerator<object, ValueTuple<object, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A62E8 Offset: 0x29A22E8 VA: 0x29A62E8
	|-Dictionary.ValueCollection.Enumerator<object, ValueTuple<float, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A6ACC Offset: 0x29A2ACC VA: 0x29A6ACC
	|-Dictionary.ValueCollection.Enumerator<object, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A72A0 Offset: 0x29A32A0 VA: 0x29A72A0
	|-Dictionary.ValueCollection.Enumerator<object, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A7A74 Offset: 0x29A3A74 VA: 0x29A7A74
	|-Dictionary.ValueCollection.Enumerator<object, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A8248 Offset: 0x29A4248 VA: 0x29A8248
	|-Dictionary.ValueCollection.Enumerator<object, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A8A1C Offset: 0x29A4A1C VA: 0x29A8A1C
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A958C Offset: 0x29A558C VA: 0x29A958C
	|-Dictionary.ValueCollection.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A9D64 Offset: 0x29A5D64 VA: 0x29A9D64
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29AA548 Offset: 0x29A6548 VA: 0x29AA548
	|-Dictionary.ValueCollection.Enumerator<object, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29AAD84 Offset: 0x29A6D84 VA: 0x29AAD84
	|-Dictionary.ValueCollection.Enumerator<object, Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29AB5A0 Offset: 0x29A75A0 VA: 0x29AB5A0
	|-Dictionary.ValueCollection.Enumerator<object, DeathReceptionAction.PoisonTargetData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29ABD78 Offset: 0x29A7D78 VA: 0x29ABD78
	|-Dictionary.ValueCollection.Enumerator<object, UIHouseAddressManager.Town>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29AC5F8 Offset: 0x29A85F8 VA: 0x29AC5F8
	|-Dictionary.ValueCollection.Enumerator<ushort, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29ACF18 Offset: 0x29A8F18 VA: 0x29ACF18
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29B0798 Offset: 0x29AC798 VA: 0x29B0798
	|-Dictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29B1D7C Offset: 0x29ADD7C VA: 0x29B1D7C
	|-Dictionary.ValueCollection.Enumerator<MaterialManager.pair, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29B2644 Offset: 0x29AE644 VA: 0x29B2644
	|-Dictionary.ValueCollection.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29B2E2C Offset: 0x29AEE2C VA: 0x29B2E2C
	|-Dictionary.ValueCollection.Enumerator<PartyManager.PartyData.pair, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29814C8 Offset: 0x297D4C8 VA: 0x29814C8
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2981CF0 Offset: 0x297DCF0 VA: 0x2981CF0
	|-Dictionary.ValueCollection.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2982518 Offset: 0x297E518 VA: 0x2982518
	|-Dictionary.ValueCollection.Enumerator<ValueTuple<object, object>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2982DB4 Offset: 0x297EDB4 VA: 0x2982DB4
	|-Dictionary.ValueCollection.Enumerator<ArchetypeUid, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298359C Offset: 0x297F59C VA: 0x298359C
	|-Dictionary.ValueCollection.Enumerator<ArchetypeUid, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2983E90 Offset: 0x297FE90 VA: 0x2983E90
	|-Dictionary.ValueCollection.Enumerator<byte, ValueTuple<short, int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2984788 Offset: 0x2980788 VA: 0x2984788
	|-Dictionary.ValueCollection.Enumerator<byte, BlackKnightAvatarProperty>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2985054 Offset: 0x2981054 VA: 0x2985054
	|-Dictionary.ValueCollection.Enumerator<byte, BlackKnightCristaProperty>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29858E4 Offset: 0x29818E4 VA: 0x29858E4
	|-Dictionary.ValueCollection.Enumerator<byte, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29861D8 Offset: 0x29821D8 VA: 0x29861D8
	|-Dictionary.ValueCollection.Enumerator<byte, CardData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2986A5C Offset: 0x2982A5C VA: 0x2986A5C
	|-Dictionary.ValueCollection.Enumerator<byte, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29872D0 Offset: 0x29832D0 VA: 0x29872D0
	|-Dictionary.ValueCollection.Enumerator<byte, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2987B6C Offset: 0x2983B6C VA: 0x2987B6C
	|-Dictionary.ValueCollection.Enumerator<byte, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2988B90 Offset: 0x2984B90 VA: 0x2988B90
	|-Dictionary.ValueCollection.Enumerator<byte, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2989850 Offset: 0x2985850 VA: 0x2989850
	|-Dictionary.ValueCollection.Enumerator<byte, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298A108 Offset: 0x2986108 VA: 0x298A108
	|-Dictionary.ValueCollection.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298A8F4 Offset: 0x29868F4 VA: 0x298A8F4
	|-Dictionary.ValueCollection.Enumerator<ByteEnum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298B174 Offset: 0x2987174 VA: 0x298B174
	|-Dictionary.ValueCollection.Enumerator<char, char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298BA2C Offset: 0x2987A2C VA: 0x298BA2C
	|-Dictionary.ValueCollection.Enumerator<DefencePoint2, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298CF70 Offset: 0x2988F70 VA: 0x298CF70
	|-Dictionary.ValueCollection.Enumerator<Guid, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298D7F0 Offset: 0x29897F0 VA: 0x298D7F0
	|-Dictionary.ValueCollection.Enumerator<short, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298E070 Offset: 0x298A070 VA: 0x298E070
	|-Dictionary.ValueCollection.Enumerator<short, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298E8E4 Offset: 0x298A8E4 VA: 0x298E8E4
	|-Dictionary.ValueCollection.Enumerator<short, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298F0D0 Offset: 0x298B0D0 VA: 0x298F0D0
	|-Dictionary.ValueCollection.Enumerator<short, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298F958 Offset: 0x298B958 VA: 0x298F958
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29901CC Offset: 0x298C1CC VA: 0x29901CC
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29909B8 Offset: 0x298C9B8 VA: 0x29909B8
	|-Dictionary.ValueCollection.Enumerator<Int16Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2991234 Offset: 0x298D234 VA: 0x2991234
	|-Dictionary.ValueCollection.Enumerator<int, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2991AA8 Offset: 0x298DAA8 VA: 0x2991AA8
	|-Dictionary.ValueCollection.Enumerator<int, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29923B8 Offset: 0x298E3B8 VA: 0x29923B8
	|-Dictionary.ValueCollection.Enumerator<int, Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2992C2C Offset: 0x298EC2C VA: 0x2992C2C
	|-Dictionary.ValueCollection.Enumerator<int, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299349C Offset: 0x298F49C VA: 0x299349C
	|-Dictionary.ValueCollection.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2993D0C Offset: 0x298FD0C VA: 0x2993D0C
	|-Dictionary.ValueCollection.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29945A8 Offset: 0x29905A8 VA: 0x29945A8
	|-Dictionary.ValueCollection.Enumerator<int, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2994E9C Offset: 0x2990E9C VA: 0x2994E9C
	|-Dictionary.ValueCollection.Enumerator<int, MaterialSearchData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2995688 Offset: 0x2991688 VA: 0x2995688
	|-Dictionary.ValueCollection.Enumerator<int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2995F7C Offset: 0x2991F7C VA: 0x2995F7C
	|-Dictionary.ValueCollection.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29967F8 Offset: 0x29927F8 VA: 0x29967F8
	|-Dictionary.ValueCollection.Enumerator<int, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2997108 Offset: 0x2993108 VA: 0x2997108
	|-Dictionary.ValueCollection.Enumerator<int, Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2997A1C Offset: 0x2993A1C VA: 0x2997A1C
	|-Dictionary.ValueCollection.Enumerator<int, Vector4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29983B0 Offset: 0x29943B0 VA: 0x29983B0
	|-Dictionary.ValueCollection.Enumerator<int, HouseRecipeManager.RecipeData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2998D58 Offset: 0x2994D58 VA: 0x2998D58
	|-Dictionary.ValueCollection.Enumerator<int, MasterModelDataManager.ColorListData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29996A0 Offset: 0x29956A0 VA: 0x29996A0
	|-Dictionary.ValueCollection.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2999F44 Offset: 0x2995F44 VA: 0x2999F44
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, ArchetypeUid>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299A7C0 Offset: 0x29967C0 VA: 0x299A7C0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299B034 Offset: 0x2997034 VA: 0x299B034
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299B944 Offset: 0x2997944 VA: 0x299B944
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299C1E0 Offset: 0x29981E0 VA: 0x299C1E0
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, DateTime>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299CB58 Offset: 0x2998B58 VA: 0x299CB58
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, EnhanceProperties2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299D3D4 Offset: 0x29993D4 VA: 0x299D3D4
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299DC44 Offset: 0x2999C44 VA: 0x299DC44
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299E4B4 Offset: 0x299A4B4 VA: 0x299E4B4
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299ED50 Offset: 0x299AD50 VA: 0x299ED50
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299F5EC Offset: 0x299B5EC VA: 0x299F5EC
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Int64Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299FDD8 Offset: 0x299BDD8 VA: 0x299FDD8
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A0654 Offset: 0x299C654 VA: 0x29A0654
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A0F64 Offset: 0x299CF64 VA: 0x29A0F64
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A1908 Offset: 0x299D908 VA: 0x29A1908
	|-Dictionary.ValueCollection.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A21B4 Offset: 0x299E1B4 VA: 0x29A21B4
	|-Dictionary.ValueCollection.Enumerator<long, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A2A50 Offset: 0x299EA50 VA: 0x29A2A50
	|-Dictionary.ValueCollection.Enumerator<long, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A32EC Offset: 0x299F2EC VA: 0x29A32EC
	|-Dictionary.ValueCollection.Enumerator<long, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A3AD4 Offset: 0x299FAD4 VA: 0x29A3AD4
	|-Dictionary.ValueCollection.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A4370 Offset: 0x29A0370 VA: 0x29A4370
	|-Dictionary.ValueCollection.Enumerator<Int64Enum, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A4B58 Offset: 0x29A0B58 VA: 0x29A4B58
	|-Dictionary.ValueCollection.Enumerator<Int64Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A5340 Offset: 0x29A1340 VA: 0x29A5340
	|-Dictionary.ValueCollection.Enumerator<IntPtr, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A5B50 Offset: 0x29A1B50 VA: 0x29A5B50
	|-Dictionary.ValueCollection.Enumerator<object, ValueTuple<object, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A6360 Offset: 0x29A2360 VA: 0x29A6360
	|-Dictionary.ValueCollection.Enumerator<object, ValueTuple<float, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A6B3C Offset: 0x29A2B3C VA: 0x29A6B3C
	|-Dictionary.ValueCollection.Enumerator<object, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A7310 Offset: 0x29A3310 VA: 0x29A7310
	|-Dictionary.ValueCollection.Enumerator<object, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A7AE4 Offset: 0x29A3AE4 VA: 0x29A7AE4
	|-Dictionary.ValueCollection.Enumerator<object, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A82B8 Offset: 0x29A42B8 VA: 0x29A82B8
	|-Dictionary.ValueCollection.Enumerator<object, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A8A8C Offset: 0x29A4A8C VA: 0x29A8A8C
	|-Dictionary.ValueCollection.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A95CC Offset: 0x29A55CC VA: 0x29A95CC
	|-Dictionary.ValueCollection.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A9DDC Offset: 0x29A5DDC VA: 0x29A9DDC
	|-Dictionary.ValueCollection.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29AA5B8 Offset: 0x29A65B8 VA: 0x29AA5B8
	|-Dictionary.ValueCollection.Enumerator<object, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29AAE04 Offset: 0x29A6E04 VA: 0x29AAE04
	|-Dictionary.ValueCollection.Enumerator<object, Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29AB618 Offset: 0x29A7618 VA: 0x29AB618
	|-Dictionary.ValueCollection.Enumerator<object, DeathReceptionAction.PoisonTargetData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29ABDE8 Offset: 0x29A7DE8 VA: 0x29ABDE8
	|-Dictionary.ValueCollection.Enumerator<object, UIHouseAddressManager.Town>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29AC668 Offset: 0x29A8668 VA: 0x29AC668
	|-Dictionary.ValueCollection.Enumerator<ushort, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29ACF90 Offset: 0x29A8F90 VA: 0x29ACF90
	|-Dictionary.ValueCollection.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29B093C Offset: 0x29AC93C VA: 0x29B093C
	|-Dictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29B1DBC Offset: 0x29ADDBC VA: 0x29B1DBC
	|-Dictionary.ValueCollection.Enumerator<MaterialManager.pair, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29B2684 Offset: 0x29AE684 VA: 0x29B2684
	|-Dictionary.ValueCollection.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29B2E6C Offset: 0x29AEE6C VA: 0x29B2E6C
	|-Dictionary.ValueCollection.Enumerator<PartyManager.PartyData.pair, object>.System.Collections.IEnumerator.Reset
	*/
}
