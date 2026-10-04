// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
public struct Dictionary.KeyCollection.Enumerator<TKey, TValue> : IEnumerator<TKey>, IDisposable, IEnumerator // TypeDefIndex: 10926
{
	// Fields
	private Dictionary<TKey, TValue> _dictionary; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TKey _currentKey; // 0x0

	// Properties
	public TKey Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29811BC Offset: 0x297D1BC VA: 0x29811BC
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x29819FC Offset: 0x297D9FC VA: 0x29819FC
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x2982224 Offset: 0x297E224 VA: 0x2982224
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0x2982AA8 Offset: 0x297EAA8 VA: 0x2982AA8
	|-Dictionary.KeyCollection.Enumerator<ArchetypeUid, int>..ctor
	|
	|-RVA: 0x29832B0 Offset: 0x297F2B0 VA: 0x29832B0
	|-Dictionary.KeyCollection.Enumerator<ArchetypeUid, object>..ctor
	|
	|-RVA: 0x2983B5C Offset: 0x297FB5C VA: 0x2983B5C
	|-Dictionary.KeyCollection.Enumerator<byte, ValueTuple<short, int, int>>..ctor
	|
	|-RVA: 0x2984454 Offset: 0x2980454 VA: 0x2984454
	|-Dictionary.KeyCollection.Enumerator<byte, BlackKnightAvatarProperty>..ctor
	|
	|-RVA: 0x2984D28 Offset: 0x2980D28 VA: 0x2984D28
	|-Dictionary.KeyCollection.Enumerator<byte, BlackKnightCristaProperty>..ctor
	|
	|-RVA: 0x29855D8 Offset: 0x29815D8 VA: 0x29855D8
	|-Dictionary.KeyCollection.Enumerator<byte, byte>..ctor
	|
	|-RVA: 0x2985EA4 Offset: 0x2981EA4 VA: 0x2985EA4
	|-Dictionary.KeyCollection.Enumerator<byte, CardData>..ctor
	|
	|-RVA: 0x2986750 Offset: 0x2982750 VA: 0x2986750
	|-Dictionary.KeyCollection.Enumerator<byte, short>..ctor
	|
	|-RVA: 0x2986FD4 Offset: 0x2982FD4 VA: 0x2986FD4
	|-Dictionary.KeyCollection.Enumerator<byte, int>..ctor
	|
	|-RVA: 0x2987860 Offset: 0x2983860 VA: 0x2987860
	|-Dictionary.KeyCollection.Enumerator<byte, long>..ctor
	|
	|-RVA: 0x29888A4 Offset: 0x29848A4 VA: 0x29888A4
	|-Dictionary.KeyCollection.Enumerator<byte, object>..ctor
	|
	|-RVA: 0x2989554 Offset: 0x2985554 VA: 0x2989554
	|-Dictionary.KeyCollection.Enumerator<byte, float>..ctor
	|
	|-RVA: 0x2989DFC Offset: 0x2985DFC VA: 0x2989DFC
	|-Dictionary.KeyCollection.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>..ctor
	|
	|-RVA: 0x298A608 Offset: 0x2986608 VA: 0x298A608
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, object>..ctor
	|
	|-RVA: 0x298AE68 Offset: 0x2986E68 VA: 0x298AE68
	|-Dictionary.KeyCollection.Enumerator<char, char>..ctor
	|
	|-RVA: 0x298B720 Offset: 0x2987720 VA: 0x298B720
	|-Dictionary.KeyCollection.Enumerator<DefencePoint2, byte>..ctor
	|
	|-RVA: 0x298CC90 Offset: 0x2988C90 VA: 0x298CC90
	|-Dictionary.KeyCollection.Enumerator<Guid, object>..ctor
	|
	|-RVA: 0x298D4E4 Offset: 0x29894E4 VA: 0x298D4E4
	|-Dictionary.KeyCollection.Enumerator<short, byte>..ctor
	|
	|-RVA: 0x298DD64 Offset: 0x2989D64 VA: 0x298DD64
	|-Dictionary.KeyCollection.Enumerator<short, short>..ctor
	|
	|-RVA: 0x298E5E8 Offset: 0x298A5E8 VA: 0x298E5E8
	|-Dictionary.KeyCollection.Enumerator<short, int>..ctor
	|
	|-RVA: 0x298EDE4 Offset: 0x298ADE4 VA: 0x298EDE4
	|-Dictionary.KeyCollection.Enumerator<short, object>..ctor
	|
	|-RVA: 0x298F64C Offset: 0x298B64C VA: 0x298F64C
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, bool>..ctor
	|
	|-RVA: 0x298FED0 Offset: 0x298BED0 VA: 0x298FED0
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, int>..ctor
	|
	|-RVA: 0x29906CC Offset: 0x298C6CC VA: 0x29906CC
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, object>..ctor
	|
	|-RVA: 0x2990F38 Offset: 0x298CF38 VA: 0x2990F38
	|-Dictionary.KeyCollection.Enumerator<int, bool>..ctor
	|
	|-RVA: 0x29917AC Offset: 0x298D7AC VA: 0x29917AC
	|-Dictionary.KeyCollection.Enumerator<int, byte>..ctor
	|
	|-RVA: 0x29920A0 Offset: 0x298E0A0 VA: 0x29920A0
	|-Dictionary.KeyCollection.Enumerator<int, Color>..ctor
	|
	|-RVA: 0x2992930 Offset: 0x298E930 VA: 0x2992930
	|-Dictionary.KeyCollection.Enumerator<int, short>..ctor
	|
	|-RVA: 0x29931A0 Offset: 0x298F1A0 VA: 0x29931A0
	|-Dictionary.KeyCollection.Enumerator<int, int>..ctor
	|
	|-RVA: 0x2993A10 Offset: 0x298FA10 VA: 0x2993A10
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>..ctor
	|
	|-RVA: 0x299429C Offset: 0x299029C VA: 0x299429C
	|-Dictionary.KeyCollection.Enumerator<int, long>..ctor
	|
	|-RVA: 0x2994B84 Offset: 0x2990B84 VA: 0x2994B84
	|-Dictionary.KeyCollection.Enumerator<int, MaterialSearchData>..ctor
	|
	|-RVA: 0x299539C Offset: 0x299139C VA: 0x299539C
	|-Dictionary.KeyCollection.Enumerator<int, object>..ctor
	|
	|-RVA: 0x2995C64 Offset: 0x2991C64 VA: 0x2995C64
	|-Dictionary.KeyCollection.Enumerator<int, RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x29964FC Offset: 0x29924FC VA: 0x29964FC
	|-Dictionary.KeyCollection.Enumerator<int, float>..ctor
	|
	|-RVA: 0x2996DD8 Offset: 0x2992DD8 VA: 0x2996DD8
	|-Dictionary.KeyCollection.Enumerator<int, Vector3>..ctor
	|
	|-RVA: 0x2997704 Offset: 0x2993704 VA: 0x2997704
	|-Dictionary.KeyCollection.Enumerator<int, Vector4>..ctor
	|
	|-RVA: 0x299805C Offset: 0x299405C VA: 0x299805C
	|-Dictionary.KeyCollection.Enumerator<int, HouseRecipeManager.RecipeData>..ctor
	|
	|-RVA: 0x2998A14 Offset: 0x2994A14 VA: 0x2998A14
	|-Dictionary.KeyCollection.Enumerator<int, MasterModelDataManager.ColorListData>..ctor
	|
	|-RVA: 0x2999358 Offset: 0x2995358 VA: 0x2999358
	|-Dictionary.KeyCollection.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>..ctor
	|
	|-RVA: 0x2999C38 Offset: 0x2995C38 VA: 0x2999C38
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ArchetypeUid>..ctor
	|
	|-RVA: 0x299A4C4 Offset: 0x29964C4 VA: 0x299A4C4
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>..ctor
	|
	|-RVA: 0x299AD38 Offset: 0x2996D38 VA: 0x299AD38
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, byte>..ctor
	|
	|-RVA: 0x299B62C Offset: 0x299762C VA: 0x299B62C
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Color>..ctor
	|
	|-RVA: 0x299BED4 Offset: 0x2997ED4 VA: 0x299BED4
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, DateTime>..ctor
	|
	|-RVA: 0x299C814 Offset: 0x2998814 VA: 0x299C814
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, EnhanceProperties2>..ctor
	|
	|-RVA: 0x299D0D8 Offset: 0x29990D8 VA: 0x299D0D8
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, short>..ctor
	|
	|-RVA: 0x299D948 Offset: 0x2999948 VA: 0x299D948
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>..ctor
	|
	|-RVA: 0x299E1B8 Offset: 0x299A1B8 VA: 0x299E1B8
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x299EA44 Offset: 0x299AA44 VA: 0x299EA44
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, long>..ctor
	|
	|-RVA: 0x299F2E0 Offset: 0x299B2E0 VA: 0x299F2E0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int64Enum>..ctor
	|
	|-RVA: 0x299FAEC Offset: 0x299BAEC VA: 0x299FAEC
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>..ctor
	|
	|-RVA: 0x29A0358 Offset: 0x299C358 VA: 0x29A0358
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, float>..ctor
	|
	|-RVA: 0x29A0C34 Offset: 0x299CC34 VA: 0x29A0C34
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Vector3>..ctor
	|
	|-RVA: 0x29A15C4 Offset: 0x299D5C4 VA: 0x29A15C4
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>..ctor
	|
	|-RVA: 0x29A1EA8 Offset: 0x299DEA8 VA: 0x29A1EA8
	|-Dictionary.KeyCollection.Enumerator<long, bool>..ctor
	|
	|-RVA: 0x29A2744 Offset: 0x299E744 VA: 0x29A2744
	|-Dictionary.KeyCollection.Enumerator<long, byte>..ctor
	|
	|-RVA: 0x29A2FE0 Offset: 0x299EFE0 VA: 0x29A2FE0
	|-Dictionary.KeyCollection.Enumerator<long, short>..ctor
	|
	|-RVA: 0x29A37E8 Offset: 0x299F7E8 VA: 0x29A37E8
	|-Dictionary.KeyCollection.Enumerator<long, object>..ctor
	|
	|-RVA: 0x29A4064 Offset: 0x29A0064 VA: 0x29A4064
	|-Dictionary.KeyCollection.Enumerator<Int64Enum, Int32Enum>..ctor
	|
	|-RVA: 0x29A486C Offset: 0x29A086C VA: 0x29A486C
	|-Dictionary.KeyCollection.Enumerator<Int64Enum, object>..ctor
	|
	|-RVA: 0x29A5054 Offset: 0x29A1054 VA: 0x29A5054
	|-Dictionary.KeyCollection.Enumerator<IntPtr, object>..ctor
	|
	|-RVA: 0x29A585C Offset: 0x29A185C VA: 0x29A585C
	|-Dictionary.KeyCollection.Enumerator<object, ValueTuple<object, byte>>..ctor
	|
	|-RVA: 0x29A606C Offset: 0x29A206C VA: 0x29A606C
	|-Dictionary.KeyCollection.Enumerator<object, ValueTuple<float, object>>..ctor
	|
	|-RVA: 0x29A6850 Offset: 0x29A2850 VA: 0x29A6850
	|-Dictionary.KeyCollection.Enumerator<object, bool>..ctor
	|
	|-RVA: 0x29A7024 Offset: 0x29A3024 VA: 0x29A7024
	|-Dictionary.KeyCollection.Enumerator<object, byte>..ctor
	|
	|-RVA: 0x29A77F8 Offset: 0x29A37F8 VA: 0x29A77F8
	|-Dictionary.KeyCollection.Enumerator<object, short>..ctor
	|
	|-RVA: 0x29A7FCC Offset: 0x29A3FCC VA: 0x29A7FCC
	|-Dictionary.KeyCollection.Enumerator<object, int>..ctor
	|
	|-RVA: 0x29A87A0 Offset: 0x29A47A0 VA: 0x29A87A0
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>..ctor
	|
	|-RVA: 0x29A9300 Offset: 0x29A5300 VA: 0x29A9300
	|-Dictionary.KeyCollection.Enumerator<object, object>..ctor
	|
	|-RVA: 0x29A9AE8 Offset: 0x29A5AE8 VA: 0x29A9AE8
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>..ctor
	|
	|-RVA: 0x29AA2CC Offset: 0x29A62CC VA: 0x29AA2CC
	|-Dictionary.KeyCollection.Enumerator<object, float>..ctor
	|
	|-RVA: 0x29AAB0C Offset: 0x29A6B0C VA: 0x29AAB0C
	|-Dictionary.KeyCollection.Enumerator<object, Vector3>..ctor
	|
	|-RVA: 0x29AB324 Offset: 0x29A7324 VA: 0x29AB324
	|-Dictionary.KeyCollection.Enumerator<object, DeathReceptionAction.PoisonTargetData>..ctor
	|
	|-RVA: 0x29ABAFC Offset: 0x29A7AFC VA: 0x29ABAFC
	|-Dictionary.KeyCollection.Enumerator<object, UIHouseAddressManager.Town>..ctor
	|
	|-RVA: 0x29AC35C Offset: 0x29A835C VA: 0x29AC35C
	|-Dictionary.KeyCollection.Enumerator<ushort, byte>..ctor
	|
	|-RVA: 0x29ACC44 Offset: 0x29A8C44 VA: 0x29ACC44
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x29AFA18 Offset: 0x29ABA18 VA: 0x29AFA18
	|-Dictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x29B1AD0 Offset: 0x29ADAD0 VA: 0x29B1AD0
	|-Dictionary.KeyCollection.Enumerator<MaterialManager.pair, object>..ctor
	|
	|-RVA: 0x29B2354 Offset: 0x29AE354 VA: 0x29B2354
	|-Dictionary.KeyCollection.Enumerator<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x29B2B80 Offset: 0x29AEB80 VA: 0x29B2B80
	|-Dictionary.KeyCollection.Enumerator<PartyManager.PartyData.pair, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29811F4 Offset: 0x297D1F4 VA: 0x29811F4
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x2981A34 Offset: 0x297DA34 VA: 0x2981A34
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<object, object>, object>.Dispose
	|
	|-RVA: 0x298225C Offset: 0x297E25C VA: 0x298225C
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, object>, object>.Dispose
	|
	|-RVA: 0x2982AE0 Offset: 0x297EAE0 VA: 0x2982AE0
	|-Dictionary.KeyCollection.Enumerator<ArchetypeUid, int>.Dispose
	|
	|-RVA: 0x29832E8 Offset: 0x297F2E8 VA: 0x29832E8
	|-Dictionary.KeyCollection.Enumerator<ArchetypeUid, object>.Dispose
	|
	|-RVA: 0x2983B94 Offset: 0x297FB94 VA: 0x2983B94
	|-Dictionary.KeyCollection.Enumerator<byte, ValueTuple<short, int, int>>.Dispose
	|
	|-RVA: 0x298448C Offset: 0x298048C VA: 0x298448C
	|-Dictionary.KeyCollection.Enumerator<byte, BlackKnightAvatarProperty>.Dispose
	|
	|-RVA: 0x2984D60 Offset: 0x2980D60 VA: 0x2984D60
	|-Dictionary.KeyCollection.Enumerator<byte, BlackKnightCristaProperty>.Dispose
	|
	|-RVA: 0x2985610 Offset: 0x2981610 VA: 0x2985610
	|-Dictionary.KeyCollection.Enumerator<byte, byte>.Dispose
	|
	|-RVA: 0x2985EDC Offset: 0x2981EDC VA: 0x2985EDC
	|-Dictionary.KeyCollection.Enumerator<byte, CardData>.Dispose
	|
	|-RVA: 0x2986788 Offset: 0x2982788 VA: 0x2986788
	|-Dictionary.KeyCollection.Enumerator<byte, short>.Dispose
	|
	|-RVA: 0x298700C Offset: 0x298300C VA: 0x298700C
	|-Dictionary.KeyCollection.Enumerator<byte, int>.Dispose
	|
	|-RVA: 0x2987898 Offset: 0x2983898 VA: 0x2987898
	|-Dictionary.KeyCollection.Enumerator<byte, long>.Dispose
	|
	|-RVA: 0x29888DC Offset: 0x29848DC VA: 0x29888DC
	|-Dictionary.KeyCollection.Enumerator<byte, object>.Dispose
	|
	|-RVA: 0x298958C Offset: 0x298558C VA: 0x298958C
	|-Dictionary.KeyCollection.Enumerator<byte, float>.Dispose
	|
	|-RVA: 0x2989E34 Offset: 0x2985E34 VA: 0x2989E34
	|-Dictionary.KeyCollection.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.Dispose
	|
	|-RVA: 0x298A640 Offset: 0x2986640 VA: 0x298A640
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, object>.Dispose
	|
	|-RVA: 0x298AEA0 Offset: 0x2986EA0 VA: 0x298AEA0
	|-Dictionary.KeyCollection.Enumerator<char, char>.Dispose
	|
	|-RVA: 0x298B758 Offset: 0x2987758 VA: 0x298B758
	|-Dictionary.KeyCollection.Enumerator<DefencePoint2, byte>.Dispose
	|
	|-RVA: 0x298CCC8 Offset: 0x2988CC8 VA: 0x298CCC8
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.Dispose
	|
	|-RVA: 0x298D51C Offset: 0x298951C VA: 0x298D51C
	|-Dictionary.KeyCollection.Enumerator<short, byte>.Dispose
	|
	|-RVA: 0x298DD9C Offset: 0x2989D9C VA: 0x298DD9C
	|-Dictionary.KeyCollection.Enumerator<short, short>.Dispose
	|
	|-RVA: 0x298E620 Offset: 0x298A620 VA: 0x298E620
	|-Dictionary.KeyCollection.Enumerator<short, int>.Dispose
	|
	|-RVA: 0x298EE1C Offset: 0x298AE1C VA: 0x298EE1C
	|-Dictionary.KeyCollection.Enumerator<short, object>.Dispose
	|
	|-RVA: 0x298F684 Offset: 0x298B684 VA: 0x298F684
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, bool>.Dispose
	|
	|-RVA: 0x298FF08 Offset: 0x298BF08 VA: 0x298FF08
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, int>.Dispose
	|
	|-RVA: 0x2990704 Offset: 0x298C704 VA: 0x2990704
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, object>.Dispose
	|
	|-RVA: 0x2990F70 Offset: 0x298CF70 VA: 0x2990F70
	|-Dictionary.KeyCollection.Enumerator<int, bool>.Dispose
	|
	|-RVA: 0x29917E4 Offset: 0x298D7E4 VA: 0x29917E4
	|-Dictionary.KeyCollection.Enumerator<int, byte>.Dispose
	|
	|-RVA: 0x29920D8 Offset: 0x298E0D8 VA: 0x29920D8
	|-Dictionary.KeyCollection.Enumerator<int, Color>.Dispose
	|
	|-RVA: 0x2992968 Offset: 0x298E968 VA: 0x2992968
	|-Dictionary.KeyCollection.Enumerator<int, short>.Dispose
	|
	|-RVA: 0x29931D8 Offset: 0x298F1D8 VA: 0x29931D8
	|-Dictionary.KeyCollection.Enumerator<int, int>.Dispose
	|
	|-RVA: 0x2993A48 Offset: 0x298FA48 VA: 0x2993A48
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.Dispose
	|
	|-RVA: 0x29942D4 Offset: 0x29902D4 VA: 0x29942D4
	|-Dictionary.KeyCollection.Enumerator<int, long>.Dispose
	|
	|-RVA: 0x2994BBC Offset: 0x2990BBC VA: 0x2994BBC
	|-Dictionary.KeyCollection.Enumerator<int, MaterialSearchData>.Dispose
	|
	|-RVA: 0x29953D4 Offset: 0x29913D4 VA: 0x29953D4
	|-Dictionary.KeyCollection.Enumerator<int, object>.Dispose
	|
	|-RVA: 0x2995C9C Offset: 0x2991C9C VA: 0x2995C9C
	|-Dictionary.KeyCollection.Enumerator<int, RenderInstancedDataLayout>.Dispose
	|
	|-RVA: 0x2996534 Offset: 0x2992534 VA: 0x2996534
	|-Dictionary.KeyCollection.Enumerator<int, float>.Dispose
	|
	|-RVA: 0x2996E10 Offset: 0x2992E10 VA: 0x2996E10
	|-Dictionary.KeyCollection.Enumerator<int, Vector3>.Dispose
	|
	|-RVA: 0x299773C Offset: 0x299373C VA: 0x299773C
	|-Dictionary.KeyCollection.Enumerator<int, Vector4>.Dispose
	|
	|-RVA: 0x2998094 Offset: 0x2994094 VA: 0x2998094
	|-Dictionary.KeyCollection.Enumerator<int, HouseRecipeManager.RecipeData>.Dispose
	|
	|-RVA: 0x2998A4C Offset: 0x2994A4C VA: 0x2998A4C
	|-Dictionary.KeyCollection.Enumerator<int, MasterModelDataManager.ColorListData>.Dispose
	|
	|-RVA: 0x2999390 Offset: 0x2995390 VA: 0x2999390
	|-Dictionary.KeyCollection.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.Dispose
	|
	|-RVA: 0x2999C70 Offset: 0x2995C70 VA: 0x2999C70
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ArchetypeUid>.Dispose
	|
	|-RVA: 0x299A4FC Offset: 0x29964FC VA: 0x299A4FC
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.Dispose
	|
	|-RVA: 0x299AD70 Offset: 0x2996D70 VA: 0x299AD70
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, byte>.Dispose
	|
	|-RVA: 0x299B664 Offset: 0x2997664 VA: 0x299B664
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Color>.Dispose
	|
	|-RVA: 0x299BF0C Offset: 0x2997F0C VA: 0x299BF0C
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, DateTime>.Dispose
	|
	|-RVA: 0x299C84C Offset: 0x299884C VA: 0x299C84C
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, EnhanceProperties2>.Dispose
	|
	|-RVA: 0x299D110 Offset: 0x2999110 VA: 0x299D110
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, short>.Dispose
	|
	|-RVA: 0x299D980 Offset: 0x2999980 VA: 0x299D980
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x299E1F0 Offset: 0x299A1F0 VA: 0x299E1F0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x299EA7C Offset: 0x299AA7C VA: 0x299EA7C
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, long>.Dispose
	|
	|-RVA: 0x299F318 Offset: 0x299B318 VA: 0x299F318
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int64Enum>.Dispose
	|
	|-RVA: 0x299FB24 Offset: 0x299BB24 VA: 0x299FB24
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.Dispose
	|
	|-RVA: 0x29A0390 Offset: 0x299C390 VA: 0x29A0390
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, float>.Dispose
	|
	|-RVA: 0x29A0C6C Offset: 0x299CC6C VA: 0x29A0C6C
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Vector3>.Dispose
	|
	|-RVA: 0x29A15FC Offset: 0x299D5FC VA: 0x29A15FC
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.Dispose
	|
	|-RVA: 0x29A1EE0 Offset: 0x299DEE0 VA: 0x29A1EE0
	|-Dictionary.KeyCollection.Enumerator<long, bool>.Dispose
	|
	|-RVA: 0x29A277C Offset: 0x299E77C VA: 0x29A277C
	|-Dictionary.KeyCollection.Enumerator<long, byte>.Dispose
	|
	|-RVA: 0x29A3018 Offset: 0x299F018 VA: 0x29A3018
	|-Dictionary.KeyCollection.Enumerator<long, short>.Dispose
	|
	|-RVA: 0x29A3820 Offset: 0x299F820 VA: 0x29A3820
	|-Dictionary.KeyCollection.Enumerator<long, object>.Dispose
	|
	|-RVA: 0x29A409C Offset: 0x29A009C VA: 0x29A409C
	|-Dictionary.KeyCollection.Enumerator<Int64Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x29A48A4 Offset: 0x29A08A4 VA: 0x29A48A4
	|-Dictionary.KeyCollection.Enumerator<Int64Enum, object>.Dispose
	|
	|-RVA: 0x29A508C Offset: 0x29A108C VA: 0x29A508C
	|-Dictionary.KeyCollection.Enumerator<IntPtr, object>.Dispose
	|
	|-RVA: 0x29A5894 Offset: 0x29A1894 VA: 0x29A5894
	|-Dictionary.KeyCollection.Enumerator<object, ValueTuple<object, byte>>.Dispose
	|
	|-RVA: 0x29A60A4 Offset: 0x29A20A4 VA: 0x29A60A4
	|-Dictionary.KeyCollection.Enumerator<object, ValueTuple<float, object>>.Dispose
	|
	|-RVA: 0x29A6888 Offset: 0x29A2888 VA: 0x29A6888
	|-Dictionary.KeyCollection.Enumerator<object, bool>.Dispose
	|
	|-RVA: 0x29A705C Offset: 0x29A305C VA: 0x29A705C
	|-Dictionary.KeyCollection.Enumerator<object, byte>.Dispose
	|
	|-RVA: 0x29A7830 Offset: 0x29A3830 VA: 0x29A7830
	|-Dictionary.KeyCollection.Enumerator<object, short>.Dispose
	|
	|-RVA: 0x29A8004 Offset: 0x29A4004 VA: 0x29A8004
	|-Dictionary.KeyCollection.Enumerator<object, int>.Dispose
	|
	|-RVA: 0x29A87D8 Offset: 0x29A47D8 VA: 0x29A87D8
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.Dispose
	|
	|-RVA: 0x29A9338 Offset: 0x29A5338 VA: 0x29A9338
	|-Dictionary.KeyCollection.Enumerator<object, object>.Dispose
	|
	|-RVA: 0x29A9B20 Offset: 0x29A5B20 VA: 0x29A9B20
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.Dispose
	|
	|-RVA: 0x29AA304 Offset: 0x29A6304 VA: 0x29AA304
	|-Dictionary.KeyCollection.Enumerator<object, float>.Dispose
	|
	|-RVA: 0x29AAB44 Offset: 0x29A6B44 VA: 0x29AAB44
	|-Dictionary.KeyCollection.Enumerator<object, Vector3>.Dispose
	|
	|-RVA: 0x29AB35C Offset: 0x29A735C VA: 0x29AB35C
	|-Dictionary.KeyCollection.Enumerator<object, DeathReceptionAction.PoisonTargetData>.Dispose
	|
	|-RVA: 0x29ABB34 Offset: 0x29A7B34 VA: 0x29ABB34
	|-Dictionary.KeyCollection.Enumerator<object, UIHouseAddressManager.Town>.Dispose
	|
	|-RVA: 0x29AC394 Offset: 0x29A8394 VA: 0x29AC394
	|-Dictionary.KeyCollection.Enumerator<ushort, byte>.Dispose
	|
	|-RVA: 0x29ACC7C Offset: 0x29A8C7C VA: 0x29ACC7C
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>.Dispose
	|
	|-RVA: 0x29AFB34 Offset: 0x29ABB34 VA: 0x29AFB34
	|-Dictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	|
	|-RVA: 0x29B1B08 Offset: 0x29ADB08 VA: 0x29B1B08
	|-Dictionary.KeyCollection.Enumerator<MaterialManager.pair, object>.Dispose
	|
	|-RVA: 0x29B2390 Offset: 0x29AE390 VA: 0x29B2390
	|-Dictionary.KeyCollection.Enumerator<Regex.CachedCodeEntryKey, object>.Dispose
	|
	|-RVA: 0x29B2BB8 Offset: 0x29AEBB8 VA: 0x29B2BB8
	|-Dictionary.KeyCollection.Enumerator<PartyManager.PartyData.pair, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29811F8 Offset: 0x297D1F8 VA: 0x29811F8
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x2981A38 Offset: 0x297DA38 VA: 0x2981A38
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x2982260 Offset: 0x297E260 VA: 0x2982260
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, object>, object>.MoveNext
	|
	|-RVA: 0x2982AE4 Offset: 0x297EAE4 VA: 0x2982AE4
	|-Dictionary.KeyCollection.Enumerator<ArchetypeUid, int>.MoveNext
	|
	|-RVA: 0x29832EC Offset: 0x297F2EC VA: 0x29832EC
	|-Dictionary.KeyCollection.Enumerator<ArchetypeUid, object>.MoveNext
	|
	|-RVA: 0x2983B98 Offset: 0x297FB98 VA: 0x2983B98
	|-Dictionary.KeyCollection.Enumerator<byte, ValueTuple<short, int, int>>.MoveNext
	|
	|-RVA: 0x2984490 Offset: 0x2980490 VA: 0x2984490
	|-Dictionary.KeyCollection.Enumerator<byte, BlackKnightAvatarProperty>.MoveNext
	|
	|-RVA: 0x2984D64 Offset: 0x2980D64 VA: 0x2984D64
	|-Dictionary.KeyCollection.Enumerator<byte, BlackKnightCristaProperty>.MoveNext
	|
	|-RVA: 0x2985614 Offset: 0x2981614 VA: 0x2985614
	|-Dictionary.KeyCollection.Enumerator<byte, byte>.MoveNext
	|
	|-RVA: 0x2985EE0 Offset: 0x2981EE0 VA: 0x2985EE0
	|-Dictionary.KeyCollection.Enumerator<byte, CardData>.MoveNext
	|
	|-RVA: 0x298678C Offset: 0x298278C VA: 0x298678C
	|-Dictionary.KeyCollection.Enumerator<byte, short>.MoveNext
	|
	|-RVA: 0x2987010 Offset: 0x2983010 VA: 0x2987010
	|-Dictionary.KeyCollection.Enumerator<byte, int>.MoveNext
	|
	|-RVA: 0x298789C Offset: 0x298389C VA: 0x298789C
	|-Dictionary.KeyCollection.Enumerator<byte, long>.MoveNext
	|
	|-RVA: 0x29888E0 Offset: 0x29848E0 VA: 0x29888E0
	|-Dictionary.KeyCollection.Enumerator<byte, object>.MoveNext
	|
	|-RVA: 0x2989590 Offset: 0x2985590 VA: 0x2989590
	|-Dictionary.KeyCollection.Enumerator<byte, float>.MoveNext
	|
	|-RVA: 0x2989E38 Offset: 0x2985E38 VA: 0x2989E38
	|-Dictionary.KeyCollection.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.MoveNext
	|
	|-RVA: 0x298A644 Offset: 0x2986644 VA: 0x298A644
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, object>.MoveNext
	|
	|-RVA: 0x298AEA4 Offset: 0x2986EA4 VA: 0x298AEA4
	|-Dictionary.KeyCollection.Enumerator<char, char>.MoveNext
	|
	|-RVA: 0x298B75C Offset: 0x298775C VA: 0x298B75C
	|-Dictionary.KeyCollection.Enumerator<DefencePoint2, byte>.MoveNext
	|
	|-RVA: 0x298CCCC Offset: 0x2988CCC VA: 0x298CCCC
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.MoveNext
	|
	|-RVA: 0x298D520 Offset: 0x2989520 VA: 0x298D520
	|-Dictionary.KeyCollection.Enumerator<short, byte>.MoveNext
	|
	|-RVA: 0x298DDA0 Offset: 0x2989DA0 VA: 0x298DDA0
	|-Dictionary.KeyCollection.Enumerator<short, short>.MoveNext
	|
	|-RVA: 0x298E624 Offset: 0x298A624 VA: 0x298E624
	|-Dictionary.KeyCollection.Enumerator<short, int>.MoveNext
	|
	|-RVA: 0x298EE20 Offset: 0x298AE20 VA: 0x298EE20
	|-Dictionary.KeyCollection.Enumerator<short, object>.MoveNext
	|
	|-RVA: 0x298F688 Offset: 0x298B688 VA: 0x298F688
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, bool>.MoveNext
	|
	|-RVA: 0x298FF0C Offset: 0x298BF0C VA: 0x298FF0C
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, int>.MoveNext
	|
	|-RVA: 0x2990708 Offset: 0x298C708 VA: 0x2990708
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, object>.MoveNext
	|
	|-RVA: 0x2990F74 Offset: 0x298CF74 VA: 0x2990F74
	|-Dictionary.KeyCollection.Enumerator<int, bool>.MoveNext
	|
	|-RVA: 0x29917E8 Offset: 0x298D7E8 VA: 0x29917E8
	|-Dictionary.KeyCollection.Enumerator<int, byte>.MoveNext
	|
	|-RVA: 0x29920DC Offset: 0x298E0DC VA: 0x29920DC
	|-Dictionary.KeyCollection.Enumerator<int, Color>.MoveNext
	|
	|-RVA: 0x299296C Offset: 0x298E96C VA: 0x299296C
	|-Dictionary.KeyCollection.Enumerator<int, short>.MoveNext
	|
	|-RVA: 0x29931DC Offset: 0x298F1DC VA: 0x29931DC
	|-Dictionary.KeyCollection.Enumerator<int, int>.MoveNext
	|
	|-RVA: 0x2993A4C Offset: 0x298FA4C VA: 0x2993A4C
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.MoveNext
	|
	|-RVA: 0x29942D8 Offset: 0x29902D8 VA: 0x29942D8
	|-Dictionary.KeyCollection.Enumerator<int, long>.MoveNext
	|
	|-RVA: 0x2994BC0 Offset: 0x2990BC0 VA: 0x2994BC0
	|-Dictionary.KeyCollection.Enumerator<int, MaterialSearchData>.MoveNext
	|
	|-RVA: 0x29953D8 Offset: 0x29913D8 VA: 0x29953D8
	|-Dictionary.KeyCollection.Enumerator<int, object>.MoveNext
	|
	|-RVA: 0x2995CA0 Offset: 0x2991CA0 VA: 0x2995CA0
	|-Dictionary.KeyCollection.Enumerator<int, RenderInstancedDataLayout>.MoveNext
	|
	|-RVA: 0x2996538 Offset: 0x2992538 VA: 0x2996538
	|-Dictionary.KeyCollection.Enumerator<int, float>.MoveNext
	|
	|-RVA: 0x2996E14 Offset: 0x2992E14 VA: 0x2996E14
	|-Dictionary.KeyCollection.Enumerator<int, Vector3>.MoveNext
	|
	|-RVA: 0x2997740 Offset: 0x2993740 VA: 0x2997740
	|-Dictionary.KeyCollection.Enumerator<int, Vector4>.MoveNext
	|
	|-RVA: 0x2998098 Offset: 0x2994098 VA: 0x2998098
	|-Dictionary.KeyCollection.Enumerator<int, HouseRecipeManager.RecipeData>.MoveNext
	|
	|-RVA: 0x2998A50 Offset: 0x2994A50 VA: 0x2998A50
	|-Dictionary.KeyCollection.Enumerator<int, MasterModelDataManager.ColorListData>.MoveNext
	|
	|-RVA: 0x2999394 Offset: 0x2995394 VA: 0x2999394
	|-Dictionary.KeyCollection.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.MoveNext
	|
	|-RVA: 0x2999C74 Offset: 0x2995C74 VA: 0x2999C74
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ArchetypeUid>.MoveNext
	|
	|-RVA: 0x299A500 Offset: 0x2996500 VA: 0x299A500
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x299AD74 Offset: 0x2996D74 VA: 0x299AD74
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, byte>.MoveNext
	|
	|-RVA: 0x299B668 Offset: 0x2997668 VA: 0x299B668
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Color>.MoveNext
	|
	|-RVA: 0x299BF10 Offset: 0x2997F10 VA: 0x299BF10
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, DateTime>.MoveNext
	|
	|-RVA: 0x299C850 Offset: 0x2998850 VA: 0x299C850
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, EnhanceProperties2>.MoveNext
	|
	|-RVA: 0x299D114 Offset: 0x2999114 VA: 0x299D114
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, short>.MoveNext
	|
	|-RVA: 0x299D984 Offset: 0x2999984 VA: 0x299D984
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x299E1F4 Offset: 0x299A1F4 VA: 0x299E1F4
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x299EA80 Offset: 0x299AA80 VA: 0x299EA80
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x299F31C Offset: 0x299B31C VA: 0x299F31C
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int64Enum>.MoveNext
	|
	|-RVA: 0x299FB28 Offset: 0x299BB28 VA: 0x299FB28
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x29A0394 Offset: 0x299C394 VA: 0x29A0394
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x29A0C70 Offset: 0x299CC70 VA: 0x29A0C70
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Vector3>.MoveNext
	|
	|-RVA: 0x29A1600 Offset: 0x299D600 VA: 0x29A1600
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.MoveNext
	|
	|-RVA: 0x29A1EE4 Offset: 0x299DEE4 VA: 0x29A1EE4
	|-Dictionary.KeyCollection.Enumerator<long, bool>.MoveNext
	|
	|-RVA: 0x29A2780 Offset: 0x299E780 VA: 0x29A2780
	|-Dictionary.KeyCollection.Enumerator<long, byte>.MoveNext
	|
	|-RVA: 0x29A301C Offset: 0x299F01C VA: 0x29A301C
	|-Dictionary.KeyCollection.Enumerator<long, short>.MoveNext
	|
	|-RVA: 0x29A3824 Offset: 0x299F824 VA: 0x29A3824
	|-Dictionary.KeyCollection.Enumerator<long, object>.MoveNext
	|
	|-RVA: 0x29A40A0 Offset: 0x29A00A0 VA: 0x29A40A0
	|-Dictionary.KeyCollection.Enumerator<Int64Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x29A48A8 Offset: 0x29A08A8 VA: 0x29A48A8
	|-Dictionary.KeyCollection.Enumerator<Int64Enum, object>.MoveNext
	|
	|-RVA: 0x29A5090 Offset: 0x29A1090 VA: 0x29A5090
	|-Dictionary.KeyCollection.Enumerator<IntPtr, object>.MoveNext
	|
	|-RVA: 0x29A5898 Offset: 0x29A1898 VA: 0x29A5898
	|-Dictionary.KeyCollection.Enumerator<object, ValueTuple<object, byte>>.MoveNext
	|
	|-RVA: 0x29A60A8 Offset: 0x29A20A8 VA: 0x29A60A8
	|-Dictionary.KeyCollection.Enumerator<object, ValueTuple<float, object>>.MoveNext
	|
	|-RVA: 0x29A688C Offset: 0x29A288C VA: 0x29A688C
	|-Dictionary.KeyCollection.Enumerator<object, bool>.MoveNext
	|
	|-RVA: 0x29A7060 Offset: 0x29A3060 VA: 0x29A7060
	|-Dictionary.KeyCollection.Enumerator<object, byte>.MoveNext
	|
	|-RVA: 0x29A7834 Offset: 0x29A3834 VA: 0x29A7834
	|-Dictionary.KeyCollection.Enumerator<object, short>.MoveNext
	|
	|-RVA: 0x29A8008 Offset: 0x29A4008 VA: 0x29A8008
	|-Dictionary.KeyCollection.Enumerator<object, int>.MoveNext
	|
	|-RVA: 0x29A87DC Offset: 0x29A47DC VA: 0x29A87DC
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x29A933C Offset: 0x29A533C VA: 0x29A933C
	|-Dictionary.KeyCollection.Enumerator<object, object>.MoveNext
	|
	|-RVA: 0x29A9B24 Offset: 0x29A5B24 VA: 0x29A9B24
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.MoveNext
	|
	|-RVA: 0x29AA308 Offset: 0x29A6308 VA: 0x29AA308
	|-Dictionary.KeyCollection.Enumerator<object, float>.MoveNext
	|
	|-RVA: 0x29AAB48 Offset: 0x29A6B48 VA: 0x29AAB48
	|-Dictionary.KeyCollection.Enumerator<object, Vector3>.MoveNext
	|
	|-RVA: 0x29AB360 Offset: 0x29A7360 VA: 0x29AB360
	|-Dictionary.KeyCollection.Enumerator<object, DeathReceptionAction.PoisonTargetData>.MoveNext
	|
	|-RVA: 0x29ABB38 Offset: 0x29A7B38 VA: 0x29ABB38
	|-Dictionary.KeyCollection.Enumerator<object, UIHouseAddressManager.Town>.MoveNext
	|
	|-RVA: 0x29AC398 Offset: 0x29A8398 VA: 0x29AC398
	|-Dictionary.KeyCollection.Enumerator<ushort, byte>.MoveNext
	|
	|-RVA: 0x29ACC80 Offset: 0x29A8C80 VA: 0x29ACC80
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>.MoveNext
	|
	|-RVA: 0x29AFB38 Offset: 0x29ABB38 VA: 0x29AFB38
	|-Dictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x29B1B0C Offset: 0x29ADB0C VA: 0x29B1B0C
	|-Dictionary.KeyCollection.Enumerator<MaterialManager.pair, object>.MoveNext
	|
	|-RVA: 0x29B2394 Offset: 0x29AE394 VA: 0x29B2394
	|-Dictionary.KeyCollection.Enumerator<Regex.CachedCodeEntryKey, object>.MoveNext
	|
	|-RVA: 0x29B2BBC Offset: 0x29AEBBC VA: 0x29B2BBC
	|-Dictionary.KeyCollection.Enumerator<PartyManager.PartyData.pair, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29812AC Offset: 0x297D2AC VA: 0x29812AC
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x2981AF4 Offset: 0x297DAF4 VA: 0x2981AF4
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<object, object>, object>.get_Current
	|
	|-RVA: 0x298231C Offset: 0x297E31C VA: 0x298231C
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, object>, object>.get_Current
	|
	|-RVA: 0x2982B98 Offset: 0x297EB98 VA: 0x2982B98
	|-Dictionary.KeyCollection.Enumerator<ArchetypeUid, int>.get_Current
	|
	|-RVA: 0x29833A0 Offset: 0x297F3A0 VA: 0x29833A0
	|-Dictionary.KeyCollection.Enumerator<ArchetypeUid, object>.get_Current
	|
	|-RVA: 0x2983C4C Offset: 0x297FC4C VA: 0x2983C4C
	|-Dictionary.KeyCollection.Enumerator<byte, ValueTuple<short, int, int>>.get_Current
	|
	|-RVA: 0x2984544 Offset: 0x2980544 VA: 0x2984544
	|-Dictionary.KeyCollection.Enumerator<byte, BlackKnightAvatarProperty>.get_Current
	|
	|-RVA: 0x2984E18 Offset: 0x2980E18 VA: 0x2984E18
	|-Dictionary.KeyCollection.Enumerator<byte, BlackKnightCristaProperty>.get_Current
	|
	|-RVA: 0x29856C8 Offset: 0x29816C8 VA: 0x29856C8
	|-Dictionary.KeyCollection.Enumerator<byte, byte>.get_Current
	|
	|-RVA: 0x2985F94 Offset: 0x2981F94 VA: 0x2985F94
	|-Dictionary.KeyCollection.Enumerator<byte, CardData>.get_Current
	|
	|-RVA: 0x2986840 Offset: 0x2982840 VA: 0x2986840
	|-Dictionary.KeyCollection.Enumerator<byte, short>.get_Current
	|
	|-RVA: 0x29870BC Offset: 0x29830BC VA: 0x29870BC
	|-Dictionary.KeyCollection.Enumerator<byte, int>.get_Current
	|
	|-RVA: 0x2987950 Offset: 0x2983950 VA: 0x2987950
	|-Dictionary.KeyCollection.Enumerator<byte, long>.get_Current
	|
	|-RVA: 0x2988994 Offset: 0x2984994 VA: 0x2988994
	|-Dictionary.KeyCollection.Enumerator<byte, object>.get_Current
	|
	|-RVA: 0x298963C Offset: 0x298563C VA: 0x298963C
	|-Dictionary.KeyCollection.Enumerator<byte, float>.get_Current
	|
	|-RVA: 0x2989EEC Offset: 0x2985EEC VA: 0x2989EEC
	|-Dictionary.KeyCollection.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.get_Current
	|
	|-RVA: 0x298A6F8 Offset: 0x29866F8 VA: 0x298A6F8
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, object>.get_Current
	|
	|-RVA: 0x298AF58 Offset: 0x2986F58 VA: 0x298AF58
	|-Dictionary.KeyCollection.Enumerator<char, char>.get_Current
	|
	|-RVA: 0x298B810 Offset: 0x2987810 VA: 0x298B810
	|-Dictionary.KeyCollection.Enumerator<DefencePoint2, byte>.get_Current
	|
	|-RVA: 0x298CD74 Offset: 0x2988D74 VA: 0x298CD74
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.get_Current
	|
	|-RVA: 0x298D5D4 Offset: 0x29895D4 VA: 0x298D5D4
	|-Dictionary.KeyCollection.Enumerator<short, byte>.get_Current
	|
	|-RVA: 0x298DE54 Offset: 0x2989E54 VA: 0x298DE54
	|-Dictionary.KeyCollection.Enumerator<short, short>.get_Current
	|
	|-RVA: 0x298E6D0 Offset: 0x298A6D0 VA: 0x298E6D0
	|-Dictionary.KeyCollection.Enumerator<short, int>.get_Current
	|
	|-RVA: 0x298EED4 Offset: 0x298AED4 VA: 0x298EED4
	|-Dictionary.KeyCollection.Enumerator<short, object>.get_Current
	|
	|-RVA: 0x298F73C Offset: 0x298B73C VA: 0x298F73C
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, bool>.get_Current
	|
	|-RVA: 0x298FFB8 Offset: 0x298BFB8 VA: 0x298FFB8
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, int>.get_Current
	|
	|-RVA: 0x29907BC Offset: 0x298C7BC VA: 0x29907BC
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, object>.get_Current
	|
	|-RVA: 0x2991020 Offset: 0x298D020 VA: 0x2991020
	|-Dictionary.KeyCollection.Enumerator<int, bool>.get_Current
	|
	|-RVA: 0x2991894 Offset: 0x298D894 VA: 0x2991894
	|-Dictionary.KeyCollection.Enumerator<int, byte>.get_Current
	|
	|-RVA: 0x2992190 Offset: 0x298E190 VA: 0x2992190
	|-Dictionary.KeyCollection.Enumerator<int, Color>.get_Current
	|
	|-RVA: 0x2992A18 Offset: 0x298EA18 VA: 0x2992A18
	|-Dictionary.KeyCollection.Enumerator<int, short>.get_Current
	|
	|-RVA: 0x2993288 Offset: 0x298F288 VA: 0x2993288
	|-Dictionary.KeyCollection.Enumerator<int, int>.get_Current
	|
	|-RVA: 0x2993AF8 Offset: 0x298FAF8 VA: 0x2993AF8
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.get_Current
	|
	|-RVA: 0x299438C Offset: 0x299038C VA: 0x299438C
	|-Dictionary.KeyCollection.Enumerator<int, long>.get_Current
	|
	|-RVA: 0x2994C74 Offset: 0x2990C74 VA: 0x2994C74
	|-Dictionary.KeyCollection.Enumerator<int, MaterialSearchData>.get_Current
	|
	|-RVA: 0x299548C Offset: 0x299148C VA: 0x299548C
	|-Dictionary.KeyCollection.Enumerator<int, object>.get_Current
	|
	|-RVA: 0x2995D54 Offset: 0x2991D54 VA: 0x2995D54
	|-Dictionary.KeyCollection.Enumerator<int, RenderInstancedDataLayout>.get_Current
	|
	|-RVA: 0x29965E4 Offset: 0x29925E4 VA: 0x29965E4
	|-Dictionary.KeyCollection.Enumerator<int, float>.get_Current
	|
	|-RVA: 0x2996EC8 Offset: 0x2992EC8 VA: 0x2996EC8
	|-Dictionary.KeyCollection.Enumerator<int, Vector3>.get_Current
	|
	|-RVA: 0x29977F4 Offset: 0x29937F4 VA: 0x29977F4
	|-Dictionary.KeyCollection.Enumerator<int, Vector4>.get_Current
	|
	|-RVA: 0x299814C Offset: 0x299414C VA: 0x299814C
	|-Dictionary.KeyCollection.Enumerator<int, HouseRecipeManager.RecipeData>.get_Current
	|
	|-RVA: 0x2998B04 Offset: 0x2994B04 VA: 0x2998B04
	|-Dictionary.KeyCollection.Enumerator<int, MasterModelDataManager.ColorListData>.get_Current
	|
	|-RVA: 0x2999448 Offset: 0x2995448 VA: 0x2999448
	|-Dictionary.KeyCollection.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.get_Current
	|
	|-RVA: 0x2999D28 Offset: 0x2995D28 VA: 0x2999D28
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ArchetypeUid>.get_Current
	|
	|-RVA: 0x299A5AC Offset: 0x29965AC VA: 0x299A5AC
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.get_Current
	|
	|-RVA: 0x299AE20 Offset: 0x2996E20 VA: 0x299AE20
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, byte>.get_Current
	|
	|-RVA: 0x299B71C Offset: 0x299771C VA: 0x299B71C
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Color>.get_Current
	|
	|-RVA: 0x299BFC4 Offset: 0x2997FC4 VA: 0x299BFC4
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, DateTime>.get_Current
	|
	|-RVA: 0x299C904 Offset: 0x2998904 VA: 0x299C904
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, EnhanceProperties2>.get_Current
	|
	|-RVA: 0x299D1C0 Offset: 0x29991C0 VA: 0x299D1C0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, short>.get_Current
	|
	|-RVA: 0x299DA30 Offset: 0x2999A30 VA: 0x299DA30
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.get_Current
	|
	|-RVA: 0x299E2A0 Offset: 0x299A2A0 VA: 0x299E2A0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.get_Current
	|
	|-RVA: 0x299EB34 Offset: 0x299AB34 VA: 0x299EB34
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, long>.get_Current
	|
	|-RVA: 0x299F3D0 Offset: 0x299B3D0 VA: 0x299F3D0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int64Enum>.get_Current
	|
	|-RVA: 0x299FBDC Offset: 0x299BBDC VA: 0x299FBDC
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.get_Current
	|
	|-RVA: 0x29A0440 Offset: 0x299C440 VA: 0x29A0440
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, float>.get_Current
	|
	|-RVA: 0x29A0D24 Offset: 0x299CD24 VA: 0x29A0D24
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Vector3>.get_Current
	|
	|-RVA: 0x29A16B4 Offset: 0x299D6B4 VA: 0x29A16B4
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.get_Current
	|
	|-RVA: 0x29A1F98 Offset: 0x299DF98 VA: 0x29A1F98
	|-Dictionary.KeyCollection.Enumerator<long, bool>.get_Current
	|
	|-RVA: 0x29A2834 Offset: 0x299E834 VA: 0x29A2834
	|-Dictionary.KeyCollection.Enumerator<long, byte>.get_Current
	|
	|-RVA: 0x29A30D0 Offset: 0x299F0D0 VA: 0x29A30D0
	|-Dictionary.KeyCollection.Enumerator<long, short>.get_Current
	|
	|-RVA: 0x29A38D8 Offset: 0x299F8D8 VA: 0x29A38D8
	|-Dictionary.KeyCollection.Enumerator<long, object>.get_Current
	|
	|-RVA: 0x29A4154 Offset: 0x29A0154 VA: 0x29A4154
	|-Dictionary.KeyCollection.Enumerator<Int64Enum, Int32Enum>.get_Current
	|
	|-RVA: 0x29A495C Offset: 0x29A095C VA: 0x29A495C
	|-Dictionary.KeyCollection.Enumerator<Int64Enum, object>.get_Current
	|
	|-RVA: 0x29A5144 Offset: 0x29A1144 VA: 0x29A5144
	|-Dictionary.KeyCollection.Enumerator<IntPtr, object>.get_Current
	|
	|-RVA: 0x29A5950 Offset: 0x29A1950 VA: 0x29A5950
	|-Dictionary.KeyCollection.Enumerator<object, ValueTuple<object, byte>>.get_Current
	|
	|-RVA: 0x29A6160 Offset: 0x29A2160 VA: 0x29A6160
	|-Dictionary.KeyCollection.Enumerator<object, ValueTuple<float, object>>.get_Current
	|
	|-RVA: 0x29A6950 Offset: 0x29A2950 VA: 0x29A6950
	|-Dictionary.KeyCollection.Enumerator<object, bool>.get_Current
	|
	|-RVA: 0x29A7124 Offset: 0x29A3124 VA: 0x29A7124
	|-Dictionary.KeyCollection.Enumerator<object, byte>.get_Current
	|
	|-RVA: 0x29A78F8 Offset: 0x29A38F8 VA: 0x29A78F8
	|-Dictionary.KeyCollection.Enumerator<object, short>.get_Current
	|
	|-RVA: 0x29A80CC Offset: 0x29A40CC VA: 0x29A80CC
	|-Dictionary.KeyCollection.Enumerator<object, int>.get_Current
	|
	|-RVA: 0x29A88A0 Offset: 0x29A48A0 VA: 0x29A88A0
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.get_Current
	|
	|-RVA: 0x29A9400 Offset: 0x29A5400 VA: 0x29A9400
	|-Dictionary.KeyCollection.Enumerator<object, object>.get_Current
	|
	|-RVA: 0x29A9BDC Offset: 0x29A5BDC VA: 0x29A9BDC
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.get_Current
	|
	|-RVA: 0x29AA3CC Offset: 0x29A63CC VA: 0x29AA3CC
	|-Dictionary.KeyCollection.Enumerator<object, float>.get_Current
	|
	|-RVA: 0x29AAC00 Offset: 0x29A6C00 VA: 0x29AAC00
	|-Dictionary.KeyCollection.Enumerator<object, Vector3>.get_Current
	|
	|-RVA: 0x29AB418 Offset: 0x29A7418 VA: 0x29AB418
	|-Dictionary.KeyCollection.Enumerator<object, DeathReceptionAction.PoisonTargetData>.get_Current
	|
	|-RVA: 0x29ABBFC Offset: 0x29A7BFC VA: 0x29ABBFC
	|-Dictionary.KeyCollection.Enumerator<object, UIHouseAddressManager.Town>.get_Current
	|
	|-RVA: 0x29AC44C Offset: 0x29A844C VA: 0x29AC44C
	|-Dictionary.KeyCollection.Enumerator<ushort, byte>.get_Current
	|
	|-RVA: 0x29ACD48 Offset: 0x29A8D48 VA: 0x29ACD48
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>.get_Current
	|
	|-RVA: 0x29AFE80 Offset: 0x29ABE80 VA: 0x29AFE80
	|-Dictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	|
	|-RVA: 0x29B1BC0 Offset: 0x29ADBC0 VA: 0x29B1BC0
	|-Dictionary.KeyCollection.Enumerator<MaterialManager.pair, object>.get_Current
	|
	|-RVA: 0x29B2468 Offset: 0x29AE468 VA: 0x29B2468
	|-Dictionary.KeyCollection.Enumerator<Regex.CachedCodeEntryKey, object>.get_Current
	|
	|-RVA: 0x29B2C70 Offset: 0x29AEC70 VA: 0x29B2C70
	|-Dictionary.KeyCollection.Enumerator<PartyManager.PartyData.pair, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29812B4 Offset: 0x297D2B4 VA: 0x29812B4
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2981B00 Offset: 0x297DB00 VA: 0x2981B00
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2982328 Offset: 0x297E328 VA: 0x2982328
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, object>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2982BA0 Offset: 0x297EBA0 VA: 0x2982BA0
	|-Dictionary.KeyCollection.Enumerator<ArchetypeUid, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29833A8 Offset: 0x297F3A8 VA: 0x29833A8
	|-Dictionary.KeyCollection.Enumerator<ArchetypeUid, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2983C54 Offset: 0x297FC54 VA: 0x2983C54
	|-Dictionary.KeyCollection.Enumerator<byte, ValueTuple<short, int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298454C Offset: 0x298054C VA: 0x298454C
	|-Dictionary.KeyCollection.Enumerator<byte, BlackKnightAvatarProperty>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2984E20 Offset: 0x2980E20 VA: 0x2984E20
	|-Dictionary.KeyCollection.Enumerator<byte, BlackKnightCristaProperty>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29856D0 Offset: 0x29816D0 VA: 0x29856D0
	|-Dictionary.KeyCollection.Enumerator<byte, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2985F9C Offset: 0x2981F9C VA: 0x2985F9C
	|-Dictionary.KeyCollection.Enumerator<byte, CardData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2986848 Offset: 0x2982848 VA: 0x2986848
	|-Dictionary.KeyCollection.Enumerator<byte, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29870C4 Offset: 0x29830C4 VA: 0x29870C4
	|-Dictionary.KeyCollection.Enumerator<byte, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2987958 Offset: 0x2983958 VA: 0x2987958
	|-Dictionary.KeyCollection.Enumerator<byte, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298899C Offset: 0x298499C VA: 0x298899C
	|-Dictionary.KeyCollection.Enumerator<byte, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2989644 Offset: 0x2985644 VA: 0x2989644
	|-Dictionary.KeyCollection.Enumerator<byte, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2989EF4 Offset: 0x2985EF4 VA: 0x2989EF4
	|-Dictionary.KeyCollection.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298A700 Offset: 0x2986700 VA: 0x298A700
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298AF60 Offset: 0x2986F60 VA: 0x298AF60
	|-Dictionary.KeyCollection.Enumerator<char, char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298B818 Offset: 0x2987818 VA: 0x298B818
	|-Dictionary.KeyCollection.Enumerator<DefencePoint2, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298CD80 Offset: 0x2988D80 VA: 0x298CD80
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298D5DC Offset: 0x29895DC VA: 0x298D5DC
	|-Dictionary.KeyCollection.Enumerator<short, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298DE5C Offset: 0x2989E5C VA: 0x298DE5C
	|-Dictionary.KeyCollection.Enumerator<short, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298E6D8 Offset: 0x298A6D8 VA: 0x298E6D8
	|-Dictionary.KeyCollection.Enumerator<short, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298EEDC Offset: 0x298AEDC VA: 0x298EEDC
	|-Dictionary.KeyCollection.Enumerator<short, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298F744 Offset: 0x298B744 VA: 0x298F744
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298FFC0 Offset: 0x298BFC0 VA: 0x298FFC0
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29907C4 Offset: 0x298C7C4 VA: 0x29907C4
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2991028 Offset: 0x298D028 VA: 0x2991028
	|-Dictionary.KeyCollection.Enumerator<int, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299189C Offset: 0x298D89C VA: 0x299189C
	|-Dictionary.KeyCollection.Enumerator<int, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2992198 Offset: 0x298E198 VA: 0x2992198
	|-Dictionary.KeyCollection.Enumerator<int, Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2992A20 Offset: 0x298EA20 VA: 0x2992A20
	|-Dictionary.KeyCollection.Enumerator<int, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2993290 Offset: 0x298F290 VA: 0x2993290
	|-Dictionary.KeyCollection.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2993B00 Offset: 0x298FB00 VA: 0x2993B00
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2994394 Offset: 0x2990394 VA: 0x2994394
	|-Dictionary.KeyCollection.Enumerator<int, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2994C7C Offset: 0x2990C7C VA: 0x2994C7C
	|-Dictionary.KeyCollection.Enumerator<int, MaterialSearchData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2995494 Offset: 0x2991494 VA: 0x2995494
	|-Dictionary.KeyCollection.Enumerator<int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2995D5C Offset: 0x2991D5C VA: 0x2995D5C
	|-Dictionary.KeyCollection.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29965EC Offset: 0x29925EC VA: 0x29965EC
	|-Dictionary.KeyCollection.Enumerator<int, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2996ED0 Offset: 0x2992ED0 VA: 0x2996ED0
	|-Dictionary.KeyCollection.Enumerator<int, Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29977FC Offset: 0x29937FC VA: 0x29977FC
	|-Dictionary.KeyCollection.Enumerator<int, Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2998154 Offset: 0x2994154 VA: 0x2998154
	|-Dictionary.KeyCollection.Enumerator<int, HouseRecipeManager.RecipeData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2998B0C Offset: 0x2994B0C VA: 0x2998B0C
	|-Dictionary.KeyCollection.Enumerator<int, MasterModelDataManager.ColorListData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2999450 Offset: 0x2995450 VA: 0x2999450
	|-Dictionary.KeyCollection.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2999D30 Offset: 0x2995D30 VA: 0x2999D30
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ArchetypeUid>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299A5B4 Offset: 0x29965B4 VA: 0x299A5B4
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299AE28 Offset: 0x2996E28 VA: 0x299AE28
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299B724 Offset: 0x2997724 VA: 0x299B724
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299BFCC Offset: 0x2997FCC VA: 0x299BFCC
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, DateTime>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299C90C Offset: 0x299890C VA: 0x299C90C
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, EnhanceProperties2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299D1C8 Offset: 0x29991C8 VA: 0x299D1C8
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299DA38 Offset: 0x2999A38 VA: 0x299DA38
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299E2A8 Offset: 0x299A2A8 VA: 0x299E2A8
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299EB3C Offset: 0x299AB3C VA: 0x299EB3C
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299F3D8 Offset: 0x299B3D8 VA: 0x299F3D8
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int64Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299FBE4 Offset: 0x299BBE4 VA: 0x299FBE4
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A0448 Offset: 0x299C448 VA: 0x29A0448
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A0D2C Offset: 0x299CD2C VA: 0x29A0D2C
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A16BC Offset: 0x299D6BC VA: 0x29A16BC
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A1FA0 Offset: 0x299DFA0 VA: 0x29A1FA0
	|-Dictionary.KeyCollection.Enumerator<long, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A283C Offset: 0x299E83C VA: 0x29A283C
	|-Dictionary.KeyCollection.Enumerator<long, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A30D8 Offset: 0x299F0D8 VA: 0x29A30D8
	|-Dictionary.KeyCollection.Enumerator<long, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A38E0 Offset: 0x299F8E0 VA: 0x29A38E0
	|-Dictionary.KeyCollection.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A415C Offset: 0x29A015C VA: 0x29A415C
	|-Dictionary.KeyCollection.Enumerator<Int64Enum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A4964 Offset: 0x29A0964 VA: 0x29A4964
	|-Dictionary.KeyCollection.Enumerator<Int64Enum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A514C Offset: 0x29A114C VA: 0x29A514C
	|-Dictionary.KeyCollection.Enumerator<IntPtr, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A5958 Offset: 0x29A1958 VA: 0x29A5958
	|-Dictionary.KeyCollection.Enumerator<object, ValueTuple<object, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A6168 Offset: 0x29A2168 VA: 0x29A6168
	|-Dictionary.KeyCollection.Enumerator<object, ValueTuple<float, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A6958 Offset: 0x29A2958 VA: 0x29A6958
	|-Dictionary.KeyCollection.Enumerator<object, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A712C Offset: 0x29A312C VA: 0x29A712C
	|-Dictionary.KeyCollection.Enumerator<object, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A7900 Offset: 0x29A3900 VA: 0x29A7900
	|-Dictionary.KeyCollection.Enumerator<object, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A80D4 Offset: 0x29A40D4 VA: 0x29A80D4
	|-Dictionary.KeyCollection.Enumerator<object, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A88A8 Offset: 0x29A48A8 VA: 0x29A88A8
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A9408 Offset: 0x29A5408 VA: 0x29A9408
	|-Dictionary.KeyCollection.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A9BE4 Offset: 0x29A5BE4 VA: 0x29A9BE4
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29AA3D4 Offset: 0x29A63D4 VA: 0x29AA3D4
	|-Dictionary.KeyCollection.Enumerator<object, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29AAC08 Offset: 0x29A6C08 VA: 0x29AAC08
	|-Dictionary.KeyCollection.Enumerator<object, Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29AB420 Offset: 0x29A7420 VA: 0x29AB420
	|-Dictionary.KeyCollection.Enumerator<object, DeathReceptionAction.PoisonTargetData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29ABC04 Offset: 0x29A7C04 VA: 0x29ABC04
	|-Dictionary.KeyCollection.Enumerator<object, UIHouseAddressManager.Town>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29AC454 Offset: 0x29A8454 VA: 0x29AC454
	|-Dictionary.KeyCollection.Enumerator<ushort, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29ACD54 Offset: 0x29A8D54 VA: 0x29ACD54
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29AFF70 Offset: 0x29ABF70 VA: 0x29AFF70
	|-Dictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29B1BC8 Offset: 0x29ADBC8 VA: 0x29B1BC8
	|-Dictionary.KeyCollection.Enumerator<MaterialManager.pair, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29B247C Offset: 0x29AE47C VA: 0x29B247C
	|-Dictionary.KeyCollection.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29B2C78 Offset: 0x29AEC78 VA: 0x29B2C78
	|-Dictionary.KeyCollection.Enumerator<PartyManager.PartyData.pair, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2981324 Offset: 0x297D324 VA: 0x2981324
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2981B78 Offset: 0x297DB78 VA: 0x2981B78
	|-Dictionary.KeyCollection.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29823A0 Offset: 0x297E3A0 VA: 0x29823A0
	|-Dictionary.KeyCollection.Enumerator<ValueTuple<object, object>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2982C10 Offset: 0x297EC10 VA: 0x2982C10
	|-Dictionary.KeyCollection.Enumerator<ArchetypeUid, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2983418 Offset: 0x297F418 VA: 0x2983418
	|-Dictionary.KeyCollection.Enumerator<ArchetypeUid, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2983CC4 Offset: 0x297FCC4 VA: 0x2983CC4
	|-Dictionary.KeyCollection.Enumerator<byte, ValueTuple<short, int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29845BC Offset: 0x29805BC VA: 0x29845BC
	|-Dictionary.KeyCollection.Enumerator<byte, BlackKnightAvatarProperty>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2984E90 Offset: 0x2980E90 VA: 0x2984E90
	|-Dictionary.KeyCollection.Enumerator<byte, BlackKnightCristaProperty>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2985740 Offset: 0x2981740 VA: 0x2985740
	|-Dictionary.KeyCollection.Enumerator<byte, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298600C Offset: 0x298200C VA: 0x298600C
	|-Dictionary.KeyCollection.Enumerator<byte, CardData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29868B8 Offset: 0x29828B8 VA: 0x29868B8
	|-Dictionary.KeyCollection.Enumerator<byte, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2987134 Offset: 0x2983134 VA: 0x2987134
	|-Dictionary.KeyCollection.Enumerator<byte, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29879C8 Offset: 0x29839C8 VA: 0x29879C8
	|-Dictionary.KeyCollection.Enumerator<byte, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2988A0C Offset: 0x2984A0C VA: 0x2988A0C
	|-Dictionary.KeyCollection.Enumerator<byte, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29896B4 Offset: 0x29856B4 VA: 0x29896B4
	|-Dictionary.KeyCollection.Enumerator<byte, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2989F64 Offset: 0x2985F64 VA: 0x2989F64
	|-Dictionary.KeyCollection.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298A770 Offset: 0x2986770 VA: 0x298A770
	|-Dictionary.KeyCollection.Enumerator<ByteEnum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298AFD0 Offset: 0x2986FD0 VA: 0x298AFD0
	|-Dictionary.KeyCollection.Enumerator<char, char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298B888 Offset: 0x2987888 VA: 0x298B888
	|-Dictionary.KeyCollection.Enumerator<DefencePoint2, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298CDF8 Offset: 0x2988DF8 VA: 0x298CDF8
	|-Dictionary.KeyCollection.Enumerator<Guid, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298D64C Offset: 0x298964C VA: 0x298D64C
	|-Dictionary.KeyCollection.Enumerator<short, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298DECC Offset: 0x2989ECC VA: 0x298DECC
	|-Dictionary.KeyCollection.Enumerator<short, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298E748 Offset: 0x298A748 VA: 0x298E748
	|-Dictionary.KeyCollection.Enumerator<short, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298EF4C Offset: 0x298AF4C VA: 0x298EF4C
	|-Dictionary.KeyCollection.Enumerator<short, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298F7B4 Offset: 0x298B7B4 VA: 0x298F7B4
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2990030 Offset: 0x298C030 VA: 0x2990030
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2990834 Offset: 0x298C834 VA: 0x2990834
	|-Dictionary.KeyCollection.Enumerator<Int16Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2991098 Offset: 0x298D098 VA: 0x2991098
	|-Dictionary.KeyCollection.Enumerator<int, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299190C Offset: 0x298D90C VA: 0x299190C
	|-Dictionary.KeyCollection.Enumerator<int, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2992208 Offset: 0x298E208 VA: 0x2992208
	|-Dictionary.KeyCollection.Enumerator<int, Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2992A90 Offset: 0x298EA90 VA: 0x2992A90
	|-Dictionary.KeyCollection.Enumerator<int, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2993300 Offset: 0x298F300 VA: 0x2993300
	|-Dictionary.KeyCollection.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2993B70 Offset: 0x298FB70 VA: 0x2993B70
	|-Dictionary.KeyCollection.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2994404 Offset: 0x2990404 VA: 0x2994404
	|-Dictionary.KeyCollection.Enumerator<int, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2994CEC Offset: 0x2990CEC VA: 0x2994CEC
	|-Dictionary.KeyCollection.Enumerator<int, MaterialSearchData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2995504 Offset: 0x2991504 VA: 0x2995504
	|-Dictionary.KeyCollection.Enumerator<int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2995DCC Offset: 0x2991DCC VA: 0x2995DCC
	|-Dictionary.KeyCollection.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299665C Offset: 0x299265C VA: 0x299665C
	|-Dictionary.KeyCollection.Enumerator<int, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2996F40 Offset: 0x2992F40 VA: 0x2996F40
	|-Dictionary.KeyCollection.Enumerator<int, Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299786C Offset: 0x299386C VA: 0x299786C
	|-Dictionary.KeyCollection.Enumerator<int, Vector4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29981C4 Offset: 0x29941C4 VA: 0x29981C4
	|-Dictionary.KeyCollection.Enumerator<int, HouseRecipeManager.RecipeData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2998B7C Offset: 0x2994B7C VA: 0x2998B7C
	|-Dictionary.KeyCollection.Enumerator<int, MasterModelDataManager.ColorListData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29994C0 Offset: 0x29954C0 VA: 0x29994C0
	|-Dictionary.KeyCollection.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2999DA0 Offset: 0x2995DA0 VA: 0x2999DA0
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, ArchetypeUid>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299A624 Offset: 0x2996624 VA: 0x299A624
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299AE98 Offset: 0x2996E98 VA: 0x299AE98
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299B794 Offset: 0x2997794 VA: 0x299B794
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299C03C Offset: 0x299803C VA: 0x299C03C
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, DateTime>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299C97C Offset: 0x299897C VA: 0x299C97C
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, EnhanceProperties2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299D238 Offset: 0x2999238 VA: 0x299D238
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299DAA8 Offset: 0x2999AA8 VA: 0x299DAA8
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299E318 Offset: 0x299A318 VA: 0x299E318
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299EBAC Offset: 0x299ABAC VA: 0x299EBAC
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299F448 Offset: 0x299B448 VA: 0x299F448
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Int64Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299FC54 Offset: 0x299BC54 VA: 0x299FC54
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A04B8 Offset: 0x299C4B8 VA: 0x29A04B8
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A0D9C Offset: 0x299CD9C VA: 0x29A0D9C
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A172C Offset: 0x299D72C VA: 0x29A172C
	|-Dictionary.KeyCollection.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A2010 Offset: 0x299E010 VA: 0x29A2010
	|-Dictionary.KeyCollection.Enumerator<long, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A28AC Offset: 0x299E8AC VA: 0x29A28AC
	|-Dictionary.KeyCollection.Enumerator<long, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A3148 Offset: 0x299F148 VA: 0x29A3148
	|-Dictionary.KeyCollection.Enumerator<long, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A3950 Offset: 0x299F950 VA: 0x29A3950
	|-Dictionary.KeyCollection.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A41CC Offset: 0x29A01CC VA: 0x29A41CC
	|-Dictionary.KeyCollection.Enumerator<Int64Enum, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A49D4 Offset: 0x29A09D4 VA: 0x29A49D4
	|-Dictionary.KeyCollection.Enumerator<Int64Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A51BC Offset: 0x29A11BC VA: 0x29A51BC
	|-Dictionary.KeyCollection.Enumerator<IntPtr, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A5998 Offset: 0x29A1998 VA: 0x29A5998
	|-Dictionary.KeyCollection.Enumerator<object, ValueTuple<object, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A61A8 Offset: 0x29A21A8 VA: 0x29A61A8
	|-Dictionary.KeyCollection.Enumerator<object, ValueTuple<float, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A6998 Offset: 0x29A2998 VA: 0x29A6998
	|-Dictionary.KeyCollection.Enumerator<object, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A716C Offset: 0x29A316C VA: 0x29A716C
	|-Dictionary.KeyCollection.Enumerator<object, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A7940 Offset: 0x29A3940 VA: 0x29A7940
	|-Dictionary.KeyCollection.Enumerator<object, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A8114 Offset: 0x29A4114 VA: 0x29A8114
	|-Dictionary.KeyCollection.Enumerator<object, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A88E8 Offset: 0x29A48E8 VA: 0x29A88E8
	|-Dictionary.KeyCollection.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A9448 Offset: 0x29A5448 VA: 0x29A9448
	|-Dictionary.KeyCollection.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A9C24 Offset: 0x29A5C24 VA: 0x29A9C24
	|-Dictionary.KeyCollection.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29AA414 Offset: 0x29A6414 VA: 0x29AA414
	|-Dictionary.KeyCollection.Enumerator<object, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29AAC48 Offset: 0x29A6C48 VA: 0x29AAC48
	|-Dictionary.KeyCollection.Enumerator<object, Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29AB460 Offset: 0x29A7460 VA: 0x29AB460
	|-Dictionary.KeyCollection.Enumerator<object, DeathReceptionAction.PoisonTargetData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29ABC44 Offset: 0x29A7C44 VA: 0x29ABC44
	|-Dictionary.KeyCollection.Enumerator<object, UIHouseAddressManager.Town>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29AC4C4 Offset: 0x29A84C4 VA: 0x29AC4C4
	|-Dictionary.KeyCollection.Enumerator<ushort, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29ACDCC Offset: 0x29A8DCC VA: 0x29ACDCC
	|-Dictionary.KeyCollection.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29B0114 Offset: 0x29AC114 VA: 0x29B0114
	|-Dictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29B1C38 Offset: 0x29ADC38 VA: 0x29B1C38
	|-Dictionary.KeyCollection.Enumerator<MaterialManager.pair, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29B24FC Offset: 0x29AE4FC VA: 0x29B24FC
	|-Dictionary.KeyCollection.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29B2CE8 Offset: 0x29AECE8 VA: 0x29B2CE8
	|-Dictionary.KeyCollection.Enumerator<PartyManager.PartyData.pair, object>.System.Collections.IEnumerator.Reset
	*/
}
