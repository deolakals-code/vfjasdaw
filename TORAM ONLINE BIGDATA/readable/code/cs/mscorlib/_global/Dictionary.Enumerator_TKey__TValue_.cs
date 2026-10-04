// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
public struct Dictionary.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator // TypeDefIndex: 10925
{
	// Fields
	private Dictionary<TKey, TValue> _dictionary; // 0x0
	private int _version; // 0x0
	private int _index; // 0x0
	private KeyValuePair<TKey, TValue> _current; // 0x0
	private int _getEnumeratorRetType; // 0x0

	// Properties
	public KeyValuePair<TKey, TValue> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }
	private object System.Collections.IDictionaryEnumerator.Key { get; }
	private object System.Collections.IDictionaryEnumerator.Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980C6C Offset: 0x297CC6C VA: 0x2980C6C
	|-Dictionary.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2981504 Offset: 0x297D504 VA: 0x2981504
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x2981D2C Offset: 0x297DD2C VA: 0x2981D2C
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0x2982554 Offset: 0x297E554 VA: 0x2982554
	|-Dictionary.Enumerator<ArchetypeUid, int>..ctor
	|
	|-RVA: 0x2982DF0 Offset: 0x297EDF0 VA: 0x2982DF0
	|-Dictionary.Enumerator<ArchetypeUid, object>..ctor
	|
	|-RVA: 0x29835D8 Offset: 0x297F5D8 VA: 0x29835D8
	|-Dictionary.Enumerator<byte, ValueTuple<short, int, int>>..ctor
	|
	|-RVA: 0x2983ED0 Offset: 0x297FED0 VA: 0x2983ED0
	|-Dictionary.Enumerator<byte, BlackKnightAvatarProperty>..ctor
	|
	|-RVA: 0x29847C8 Offset: 0x29807C8 VA: 0x29847C8
	|-Dictionary.Enumerator<byte, BlackKnightCristaProperty>..ctor
	|
	|-RVA: 0x2985094 Offset: 0x2981094 VA: 0x2985094
	|-Dictionary.Enumerator<byte, byte>..ctor
	|
	|-RVA: 0x2985920 Offset: 0x2981920 VA: 0x2985920
	|-Dictionary.Enumerator<byte, CardData>..ctor
	|
	|-RVA: 0x2986218 Offset: 0x2982218 VA: 0x2986218
	|-Dictionary.Enumerator<byte, short>..ctor
	|
	|-RVA: 0x2986A98 Offset: 0x2982A98 VA: 0x2986A98
	|-Dictionary.Enumerator<byte, int>..ctor
	|
	|-RVA: 0x298730C Offset: 0x298330C VA: 0x298730C
	|-Dictionary.Enumerator<byte, long>..ctor
	|
	|-RVA: 0x2987BA8 Offset: 0x2983BA8 VA: 0x2987BA8
	|-Dictionary.Enumerator<byte, object>..ctor
	|
	|-RVA: 0x2989010 Offset: 0x2985010 VA: 0x2989010
	|-Dictionary.Enumerator<byte, float>..ctor
	|
	|-RVA: 0x298988C Offset: 0x298588C VA: 0x298988C
	|-Dictionary.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>..ctor
	|
	|-RVA: 0x298A144 Offset: 0x2986144 VA: 0x298A144
	|-Dictionary.Enumerator<ByteEnum, object>..ctor
	|
	|-RVA: 0x298A930 Offset: 0x2986930 VA: 0x298A930
	|-Dictionary.Enumerator<char, char>..ctor
	|
	|-RVA: 0x298B1B0 Offset: 0x29871B0 VA: 0x298B1B0
	|-Dictionary.Enumerator<DefencePoint2, byte>..ctor
	|
	|-RVA: 0x298C798 Offset: 0x2988798 VA: 0x298C798
	|-Dictionary.Enumerator<Guid, object>..ctor
	|
	|-RVA: 0x298CFAC Offset: 0x2988FAC VA: 0x298CFAC
	|-Dictionary.Enumerator<short, byte>..ctor
	|
	|-RVA: 0x298D82C Offset: 0x298982C VA: 0x298D82C
	|-Dictionary.Enumerator<short, short>..ctor
	|
	|-RVA: 0x298E0AC Offset: 0x298A0AC VA: 0x298E0AC
	|-Dictionary.Enumerator<short, int>..ctor
	|
	|-RVA: 0x298E920 Offset: 0x298A920 VA: 0x298E920
	|-Dictionary.Enumerator<short, object>..ctor
	|
	|-RVA: 0x298F10C Offset: 0x298B10C VA: 0x298F10C
	|-Dictionary.Enumerator<Int16Enum, bool>..ctor
	|
	|-RVA: 0x298F994 Offset: 0x298B994 VA: 0x298F994
	|-Dictionary.Enumerator<Int16Enum, int>..ctor
	|
	|-RVA: 0x2990208 Offset: 0x298C208 VA: 0x2990208
	|-Dictionary.Enumerator<Int16Enum, object>..ctor
	|
	|-RVA: 0x29909F4 Offset: 0x298C9F4 VA: 0x29909F4
	|-Dictionary.Enumerator<int, bool>..ctor
	|
	|-RVA: 0x2991270 Offset: 0x298D270 VA: 0x2991270
	|-Dictionary.Enumerator<int, byte>..ctor
	|
	|-RVA: 0x2991AE4 Offset: 0x298DAE4 VA: 0x2991AE4
	|-Dictionary.Enumerator<int, Color>..ctor
	|
	|-RVA: 0x29923F4 Offset: 0x298E3F4 VA: 0x29923F4
	|-Dictionary.Enumerator<int, short>..ctor
	|
	|-RVA: 0x2992C68 Offset: 0x298EC68 VA: 0x2992C68
	|-Dictionary.Enumerator<int, int>..ctor
	|
	|-RVA: 0x29934D8 Offset: 0x298F4D8 VA: 0x29934D8
	|-Dictionary.Enumerator<int, Int32Enum>..ctor
	|
	|-RVA: 0x2993D48 Offset: 0x298FD48 VA: 0x2993D48
	|-Dictionary.Enumerator<int, long>..ctor
	|
	|-RVA: 0x29945E4 Offset: 0x29905E4 VA: 0x29945E4
	|-Dictionary.Enumerator<int, MaterialSearchData>..ctor
	|
	|-RVA: 0x2994ED8 Offset: 0x2990ED8 VA: 0x2994ED8
	|-Dictionary.Enumerator<int, object>..ctor
	|
	|-RVA: 0x29956C4 Offset: 0x29916C4 VA: 0x29956C4
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x2995FB8 Offset: 0x2991FB8 VA: 0x2995FB8
	|-Dictionary.Enumerator<int, float>..ctor
	|
	|-RVA: 0x2996834 Offset: 0x2992834 VA: 0x2996834
	|-Dictionary.Enumerator<int, Vector3>..ctor
	|
	|-RVA: 0x2997148 Offset: 0x2993148 VA: 0x2997148
	|-Dictionary.Enumerator<int, Vector4>..ctor
	|
	|-RVA: 0x2997A58 Offset: 0x2993A58 VA: 0x2997A58
	|-Dictionary.Enumerator<int, HouseRecipeManager.RecipeData>..ctor
	|
	|-RVA: 0x29983F4 Offset: 0x29943F4 VA: 0x29983F4
	|-Dictionary.Enumerator<int, MasterModelDataManager.ColorListData>..ctor
	|
	|-RVA: 0x2998D9C Offset: 0x2994D9C VA: 0x2998D9C
	|-Dictionary.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>..ctor
	|
	|-RVA: 0x29996E4 Offset: 0x29956E4 VA: 0x29996E4
	|-Dictionary.Enumerator<Int32Enum, ArchetypeUid>..ctor
	|
	|-RVA: 0x2999F80 Offset: 0x2995F80 VA: 0x2999F80
	|-Dictionary.Enumerator<Int32Enum, bool>..ctor
	|
	|-RVA: 0x299A7FC Offset: 0x29967FC VA: 0x299A7FC
	|-Dictionary.Enumerator<Int32Enum, byte>..ctor
	|
	|-RVA: 0x299B070 Offset: 0x2997070 VA: 0x299B070
	|-Dictionary.Enumerator<Int32Enum, Color>..ctor
	|
	|-RVA: 0x299B980 Offset: 0x2997980 VA: 0x299B980
	|-Dictionary.Enumerator<Int32Enum, DateTime>..ctor
	|
	|-RVA: 0x299C21C Offset: 0x299821C VA: 0x299C21C
	|-Dictionary.Enumerator<Int32Enum, EnhanceProperties2>..ctor
	|
	|-RVA: 0x299CB9C Offset: 0x2998B9C VA: 0x299CB9C
	|-Dictionary.Enumerator<Int32Enum, short>..ctor
	|
	|-RVA: 0x299D410 Offset: 0x2999410 VA: 0x299D410
	|-Dictionary.Enumerator<Int32Enum, int>..ctor
	|
	|-RVA: 0x299DC80 Offset: 0x2999C80 VA: 0x299DC80
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x299E4F0 Offset: 0x299A4F0 VA: 0x299E4F0
	|-Dictionary.Enumerator<Int32Enum, long>..ctor
	|
	|-RVA: 0x299ED8C Offset: 0x299AD8C VA: 0x299ED8C
	|-Dictionary.Enumerator<Int32Enum, Int64Enum>..ctor
	|
	|-RVA: 0x299F628 Offset: 0x299B628 VA: 0x299F628
	|-Dictionary.Enumerator<Int32Enum, object>..ctor
	|
	|-RVA: 0x299FE14 Offset: 0x299BE14 VA: 0x299FE14
	|-Dictionary.Enumerator<Int32Enum, float>..ctor
	|
	|-RVA: 0x29A0690 Offset: 0x299C690 VA: 0x29A0690
	|-Dictionary.Enumerator<Int32Enum, Vector3>..ctor
	|
	|-RVA: 0x29A0FA4 Offset: 0x299CFA4 VA: 0x29A0FA4
	|-Dictionary.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>..ctor
	|
	|-RVA: 0x29A194C Offset: 0x299D94C VA: 0x29A194C
	|-Dictionary.Enumerator<long, bool>..ctor
	|
	|-RVA: 0x29A21F0 Offset: 0x299E1F0 VA: 0x29A21F0
	|-Dictionary.Enumerator<long, byte>..ctor
	|
	|-RVA: 0x29A2A8C Offset: 0x299EA8C VA: 0x29A2A8C
	|-Dictionary.Enumerator<long, short>..ctor
	|
	|-RVA: 0x29A3328 Offset: 0x299F328 VA: 0x29A3328
	|-Dictionary.Enumerator<long, object>..ctor
	|
	|-RVA: 0x29A3B10 Offset: 0x299FB10 VA: 0x29A3B10
	|-Dictionary.Enumerator<Int64Enum, Int32Enum>..ctor
	|
	|-RVA: 0x29A43AC Offset: 0x29A03AC VA: 0x29A43AC
	|-Dictionary.Enumerator<Int64Enum, object>..ctor
	|
	|-RVA: 0x29A4B94 Offset: 0x29A0B94 VA: 0x29A4B94
	|-Dictionary.Enumerator<IntPtr, object>..ctor
	|
	|-RVA: 0x29A537C Offset: 0x29A137C VA: 0x29A537C
	|-Dictionary.Enumerator<object, ValueTuple<object, byte>>..ctor
	|
	|-RVA: 0x29A5B8C Offset: 0x29A1B8C VA: 0x29A5B8C
	|-Dictionary.Enumerator<object, ValueTuple<float, object>>..ctor
	|
	|-RVA: 0x29A639C Offset: 0x29A239C VA: 0x29A639C
	|-Dictionary.Enumerator<object, bool>..ctor
	|
	|-RVA: 0x29A6B78 Offset: 0x29A2B78 VA: 0x29A6B78
	|-Dictionary.Enumerator<object, byte>..ctor
	|
	|-RVA: 0x29A734C Offset: 0x29A334C VA: 0x29A734C
	|-Dictionary.Enumerator<object, short>..ctor
	|
	|-RVA: 0x29A7B20 Offset: 0x29A3B20 VA: 0x29A7B20
	|-Dictionary.Enumerator<object, int>..ctor
	|
	|-RVA: 0x29A82F4 Offset: 0x29A42F4 VA: 0x29A82F4
	|-Dictionary.Enumerator<object, Int32Enum>..ctor
	|
	|-RVA: 0x29A8ED4 Offset: 0x29A4ED4 VA: 0x29A8ED4
	|-Dictionary.Enumerator<object, object>..ctor
	|
	|-RVA: 0x29A9608 Offset: 0x29A5608 VA: 0x29A9608
	|-Dictionary.Enumerator<object, ResourceLocator>..ctor
	|
	|-RVA: 0x29A9E18 Offset: 0x29A5E18 VA: 0x29A9E18
	|-Dictionary.Enumerator<object, float>..ctor
	|
	|-RVA: 0x29AA5F4 Offset: 0x29A65F4 VA: 0x29AA5F4
	|-Dictionary.Enumerator<object, Vector3>..ctor
	|
	|-RVA: 0x29AAE44 Offset: 0x29A6E44 VA: 0x29AAE44
	|-Dictionary.Enumerator<object, DeathReceptionAction.PoisonTargetData>..ctor
	|
	|-RVA: 0x29AB654 Offset: 0x29A7654 VA: 0x29AB654
	|-Dictionary.Enumerator<object, UIHouseAddressManager.Town>..ctor
	|
	|-RVA: 0x29ABE24 Offset: 0x29A7E24 VA: 0x29ABE24
	|-Dictionary.Enumerator<ushort, byte>..ctor
	|
	|-RVA: 0x29AC6A4 Offset: 0x29A86A4 VA: 0x29AC6A4
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x29ACFCC Offset: 0x29A8FCC VA: 0x29ACFCC
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x29B1610 Offset: 0x29AD610 VA: 0x29B1610
	|-Dictionary.Enumerator<MaterialManager.pair, object>..ctor
	|
	|-RVA: 0x29B1DF8 Offset: 0x29ADDF8 VA: 0x29B1DF8
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x29B26C0 Offset: 0x29AE6C0 VA: 0x29B26C0
	|-Dictionary.Enumerator<PartyManager.PartyData.pair, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980CAC Offset: 0x297CCAC VA: 0x2980CAC
	|-Dictionary.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x2981548 Offset: 0x297D548 VA: 0x2981548
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x2981D70 Offset: 0x297DD70 VA: 0x2981D70
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>.MoveNext
	|
	|-RVA: 0x2982594 Offset: 0x297E594 VA: 0x2982594
	|-Dictionary.Enumerator<ArchetypeUid, int>.MoveNext
	|
	|-RVA: 0x2982E30 Offset: 0x297EE30 VA: 0x2982E30
	|-Dictionary.Enumerator<ArchetypeUid, object>.MoveNext
	|
	|-RVA: 0x2983618 Offset: 0x297F618 VA: 0x2983618
	|-Dictionary.Enumerator<byte, ValueTuple<short, int, int>>.MoveNext
	|
	|-RVA: 0x2983F10 Offset: 0x297FF10 VA: 0x2983F10
	|-Dictionary.Enumerator<byte, BlackKnightAvatarProperty>.MoveNext
	|
	|-RVA: 0x2984804 Offset: 0x2980804 VA: 0x2984804
	|-Dictionary.Enumerator<byte, BlackKnightCristaProperty>.MoveNext
	|
	|-RVA: 0x29850D4 Offset: 0x29810D4 VA: 0x29850D4
	|-Dictionary.Enumerator<byte, byte>.MoveNext
	|
	|-RVA: 0x2985960 Offset: 0x2981960 VA: 0x2985960
	|-Dictionary.Enumerator<byte, CardData>.MoveNext
	|
	|-RVA: 0x2986254 Offset: 0x2982254 VA: 0x2986254
	|-Dictionary.Enumerator<byte, short>.MoveNext
	|
	|-RVA: 0x2986AD8 Offset: 0x2982AD8 VA: 0x2986AD8
	|-Dictionary.Enumerator<byte, int>.MoveNext
	|
	|-RVA: 0x298734C Offset: 0x298334C VA: 0x298734C
	|-Dictionary.Enumerator<byte, long>.MoveNext
	|
	|-RVA: 0x2987BE8 Offset: 0x2983BE8 VA: 0x2987BE8
	|-Dictionary.Enumerator<byte, object>.MoveNext
	|
	|-RVA: 0x2989050 Offset: 0x2985050 VA: 0x2989050
	|-Dictionary.Enumerator<byte, float>.MoveNext
	|
	|-RVA: 0x29898CC Offset: 0x29858CC VA: 0x29898CC
	|-Dictionary.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.MoveNext
	|
	|-RVA: 0x298A184 Offset: 0x2986184 VA: 0x298A184
	|-Dictionary.Enumerator<ByteEnum, object>.MoveNext
	|
	|-RVA: 0x298A96C Offset: 0x298696C VA: 0x298A96C
	|-Dictionary.Enumerator<char, char>.MoveNext
	|
	|-RVA: 0x298B1F0 Offset: 0x29871F0 VA: 0x298B1F0
	|-Dictionary.Enumerator<DefencePoint2, byte>.MoveNext
	|
	|-RVA: 0x298C7DC Offset: 0x29887DC VA: 0x298C7DC
	|-Dictionary.Enumerator<Guid, object>.MoveNext
	|
	|-RVA: 0x298CFE8 Offset: 0x2988FE8 VA: 0x298CFE8
	|-Dictionary.Enumerator<short, byte>.MoveNext
	|
	|-RVA: 0x298D868 Offset: 0x2989868 VA: 0x298D868
	|-Dictionary.Enumerator<short, short>.MoveNext
	|
	|-RVA: 0x298E0EC Offset: 0x298A0EC VA: 0x298E0EC
	|-Dictionary.Enumerator<short, int>.MoveNext
	|
	|-RVA: 0x298E960 Offset: 0x298A960 VA: 0x298E960
	|-Dictionary.Enumerator<short, object>.MoveNext
	|
	|-RVA: 0x298F148 Offset: 0x298B148 VA: 0x298F148
	|-Dictionary.Enumerator<Int16Enum, bool>.MoveNext
	|
	|-RVA: 0x298F9D4 Offset: 0x298B9D4 VA: 0x298F9D4
	|-Dictionary.Enumerator<Int16Enum, int>.MoveNext
	|
	|-RVA: 0x2990248 Offset: 0x298C248 VA: 0x2990248
	|-Dictionary.Enumerator<Int16Enum, object>.MoveNext
	|
	|-RVA: 0x2990A34 Offset: 0x298CA34 VA: 0x2990A34
	|-Dictionary.Enumerator<int, bool>.MoveNext
	|
	|-RVA: 0x29912B0 Offset: 0x298D2B0 VA: 0x29912B0
	|-Dictionary.Enumerator<int, byte>.MoveNext
	|
	|-RVA: 0x2991B24 Offset: 0x298DB24 VA: 0x2991B24
	|-Dictionary.Enumerator<int, Color>.MoveNext
	|
	|-RVA: 0x2992434 Offset: 0x298E434 VA: 0x2992434
	|-Dictionary.Enumerator<int, short>.MoveNext
	|
	|-RVA: 0x2992CA8 Offset: 0x298ECA8 VA: 0x2992CA8
	|-Dictionary.Enumerator<int, int>.MoveNext
	|
	|-RVA: 0x2993518 Offset: 0x298F518 VA: 0x2993518
	|-Dictionary.Enumerator<int, Int32Enum>.MoveNext
	|
	|-RVA: 0x2993D88 Offset: 0x298FD88 VA: 0x2993D88
	|-Dictionary.Enumerator<int, long>.MoveNext
	|
	|-RVA: 0x2994624 Offset: 0x2990624 VA: 0x2994624
	|-Dictionary.Enumerator<int, MaterialSearchData>.MoveNext
	|
	|-RVA: 0x2994F18 Offset: 0x2990F18 VA: 0x2994F18
	|-Dictionary.Enumerator<int, object>.MoveNext
	|
	|-RVA: 0x2995704 Offset: 0x2991704 VA: 0x2995704
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>.MoveNext
	|
	|-RVA: 0x2995FF8 Offset: 0x2991FF8 VA: 0x2995FF8
	|-Dictionary.Enumerator<int, float>.MoveNext
	|
	|-RVA: 0x2996874 Offset: 0x2992874 VA: 0x2996874
	|-Dictionary.Enumerator<int, Vector3>.MoveNext
	|
	|-RVA: 0x2997188 Offset: 0x2993188 VA: 0x2997188
	|-Dictionary.Enumerator<int, Vector4>.MoveNext
	|
	|-RVA: 0x2997AA0 Offset: 0x2993AA0 VA: 0x2997AA0
	|-Dictionary.Enumerator<int, HouseRecipeManager.RecipeData>.MoveNext
	|
	|-RVA: 0x299843C Offset: 0x299443C VA: 0x299843C
	|-Dictionary.Enumerator<int, MasterModelDataManager.ColorListData>.MoveNext
	|
	|-RVA: 0x2998DE0 Offset: 0x2994DE0 VA: 0x2998DE0
	|-Dictionary.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.MoveNext
	|
	|-RVA: 0x2999724 Offset: 0x2995724 VA: 0x2999724
	|-Dictionary.Enumerator<Int32Enum, ArchetypeUid>.MoveNext
	|
	|-RVA: 0x2999FC0 Offset: 0x2995FC0 VA: 0x2999FC0
	|-Dictionary.Enumerator<Int32Enum, bool>.MoveNext
	|
	|-RVA: 0x299A83C Offset: 0x299683C VA: 0x299A83C
	|-Dictionary.Enumerator<Int32Enum, byte>.MoveNext
	|
	|-RVA: 0x299B0B0 Offset: 0x29970B0 VA: 0x299B0B0
	|-Dictionary.Enumerator<Int32Enum, Color>.MoveNext
	|
	|-RVA: 0x299B9C0 Offset: 0x29979C0 VA: 0x299B9C0
	|-Dictionary.Enumerator<Int32Enum, DateTime>.MoveNext
	|
	|-RVA: 0x299C264 Offset: 0x2998264 VA: 0x299C264
	|-Dictionary.Enumerator<Int32Enum, EnhanceProperties2>.MoveNext
	|
	|-RVA: 0x299CBDC Offset: 0x2998BDC VA: 0x299CBDC
	|-Dictionary.Enumerator<Int32Enum, short>.MoveNext
	|
	|-RVA: 0x299D450 Offset: 0x2999450 VA: 0x299D450
	|-Dictionary.Enumerator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x299DCC0 Offset: 0x2999CC0 VA: 0x299DCC0
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x299E530 Offset: 0x299A530 VA: 0x299E530
	|-Dictionary.Enumerator<Int32Enum, long>.MoveNext
	|
	|-RVA: 0x299EDCC Offset: 0x299ADCC VA: 0x299EDCC
	|-Dictionary.Enumerator<Int32Enum, Int64Enum>.MoveNext
	|
	|-RVA: 0x299F668 Offset: 0x299B668 VA: 0x299F668
	|-Dictionary.Enumerator<Int32Enum, object>.MoveNext
	|
	|-RVA: 0x299FE54 Offset: 0x299BE54 VA: 0x299FE54
	|-Dictionary.Enumerator<Int32Enum, float>.MoveNext
	|
	|-RVA: 0x29A06D0 Offset: 0x299C6D0 VA: 0x29A06D0
	|-Dictionary.Enumerator<Int32Enum, Vector3>.MoveNext
	|
	|-RVA: 0x29A0FEC Offset: 0x299CFEC VA: 0x29A0FEC
	|-Dictionary.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.MoveNext
	|
	|-RVA: 0x29A198C Offset: 0x299D98C VA: 0x29A198C
	|-Dictionary.Enumerator<long, bool>.MoveNext
	|
	|-RVA: 0x29A2230 Offset: 0x299E230 VA: 0x29A2230
	|-Dictionary.Enumerator<long, byte>.MoveNext
	|
	|-RVA: 0x29A2ACC Offset: 0x299EACC VA: 0x29A2ACC
	|-Dictionary.Enumerator<long, short>.MoveNext
	|
	|-RVA: 0x29A3368 Offset: 0x299F368 VA: 0x29A3368
	|-Dictionary.Enumerator<long, object>.MoveNext
	|
	|-RVA: 0x29A3B50 Offset: 0x299FB50 VA: 0x29A3B50
	|-Dictionary.Enumerator<Int64Enum, Int32Enum>.MoveNext
	|
	|-RVA: 0x29A43EC Offset: 0x29A03EC VA: 0x29A43EC
	|-Dictionary.Enumerator<Int64Enum, object>.MoveNext
	|
	|-RVA: 0x29A4BD4 Offset: 0x29A0BD4 VA: 0x29A4BD4
	|-Dictionary.Enumerator<IntPtr, object>.MoveNext
	|
	|-RVA: 0x29A53C0 Offset: 0x29A13C0 VA: 0x29A53C0
	|-Dictionary.Enumerator<object, ValueTuple<object, byte>>.MoveNext
	|
	|-RVA: 0x29A5BD0 Offset: 0x29A1BD0 VA: 0x29A5BD0
	|-Dictionary.Enumerator<object, ValueTuple<float, object>>.MoveNext
	|
	|-RVA: 0x29A63DC Offset: 0x29A23DC VA: 0x29A63DC
	|-Dictionary.Enumerator<object, bool>.MoveNext
	|
	|-RVA: 0x29A6BB8 Offset: 0x29A2BB8 VA: 0x29A6BB8
	|-Dictionary.Enumerator<object, byte>.MoveNext
	|
	|-RVA: 0x29A738C Offset: 0x29A338C VA: 0x29A738C
	|-Dictionary.Enumerator<object, short>.MoveNext
	|
	|-RVA: 0x29A7B60 Offset: 0x29A3B60 VA: 0x29A7B60
	|-Dictionary.Enumerator<object, int>.MoveNext
	|
	|-RVA: 0x29A8334 Offset: 0x29A4334 VA: 0x29A8334
	|-Dictionary.Enumerator<object, Int32Enum>.MoveNext
	|
	|-RVA: 0x29A8F14 Offset: 0x29A4F14 VA: 0x29A8F14
	|-Dictionary.Enumerator<object, object>.MoveNext
	|
	|-RVA: 0x29A964C Offset: 0x29A564C VA: 0x29A964C
	|-Dictionary.Enumerator<object, ResourceLocator>.MoveNext
	|
	|-RVA: 0x29A9E58 Offset: 0x29A5E58 VA: 0x29A9E58
	|-Dictionary.Enumerator<object, float>.MoveNext
	|
	|-RVA: 0x29AA638 Offset: 0x29A6638 VA: 0x29AA638
	|-Dictionary.Enumerator<object, Vector3>.MoveNext
	|
	|-RVA: 0x29AAE88 Offset: 0x29A6E88 VA: 0x29AAE88
	|-Dictionary.Enumerator<object, DeathReceptionAction.PoisonTargetData>.MoveNext
	|
	|-RVA: 0x29AB694 Offset: 0x29A7694 VA: 0x29AB694
	|-Dictionary.Enumerator<object, UIHouseAddressManager.Town>.MoveNext
	|
	|-RVA: 0x29ABE60 Offset: 0x29A7E60 VA: 0x29ABE60
	|-Dictionary.Enumerator<ushort, byte>.MoveNext
	|
	|-RVA: 0x29AC6E8 Offset: 0x29A86E8 VA: 0x29AC6E8
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.MoveNext
	|
	|-RVA: 0x29AD118 Offset: 0x29A9118 VA: 0x29AD118
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x29B1650 Offset: 0x29AD650 VA: 0x29B1650
	|-Dictionary.Enumerator<MaterialManager.pair, object>.MoveNext
	|
	|-RVA: 0x29B1E3C Offset: 0x29ADE3C VA: 0x29B1E3C
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>.MoveNext
	|
	|-RVA: 0x29B2700 Offset: 0x29AE700 VA: 0x29B2700
	|-Dictionary.Enumerator<PartyManager.PartyData.pair, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980DB4 Offset: 0x297CDB4 VA: 0x2980DB4
	|-Dictionary.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x2981668 Offset: 0x297D668 VA: 0x2981668
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>.get_Current
	|
	|-RVA: 0x2981E90 Offset: 0x297DE90 VA: 0x2981E90
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>.get_Current
	|
	|-RVA: 0x29826A0 Offset: 0x297E6A0 VA: 0x29826A0
	|-Dictionary.Enumerator<ArchetypeUid, int>.get_Current
	|
	|-RVA: 0x2982F44 Offset: 0x297EF44 VA: 0x2982F44
	|-Dictionary.Enumerator<ArchetypeUid, object>.get_Current
	|
	|-RVA: 0x298372C Offset: 0x297F72C VA: 0x298372C
	|-Dictionary.Enumerator<byte, ValueTuple<short, int, int>>.get_Current
	|
	|-RVA: 0x2984024 Offset: 0x2980024 VA: 0x2984024
	|-Dictionary.Enumerator<byte, BlackKnightAvatarProperty>.get_Current
	|
	|-RVA: 0x298490C Offset: 0x298090C VA: 0x298490C
	|-Dictionary.Enumerator<byte, BlackKnightCristaProperty>.get_Current
	|
	|-RVA: 0x29851D8 Offset: 0x29811D8 VA: 0x29851D8
	|-Dictionary.Enumerator<byte, byte>.get_Current
	|
	|-RVA: 0x2985A74 Offset: 0x2981A74 VA: 0x2985A74
	|-Dictionary.Enumerator<byte, CardData>.get_Current
	|
	|-RVA: 0x2986354 Offset: 0x2982354 VA: 0x2986354
	|-Dictionary.Enumerator<byte, short>.get_Current
	|
	|-RVA: 0x2986BD4 Offset: 0x2982BD4 VA: 0x2986BD4
	|-Dictionary.Enumerator<byte, int>.get_Current
	|
	|-RVA: 0x2987458 Offset: 0x2983458 VA: 0x2987458
	|-Dictionary.Enumerator<byte, long>.get_Current
	|
	|-RVA: 0x2987D00 Offset: 0x2983D00 VA: 0x2987D00
	|-Dictionary.Enumerator<byte, object>.get_Current
	|
	|-RVA: 0x298914C Offset: 0x298514C VA: 0x298914C
	|-Dictionary.Enumerator<byte, float>.get_Current
	|
	|-RVA: 0x29899E8 Offset: 0x29859E8 VA: 0x29899E8
	|-Dictionary.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.get_Current
	|
	|-RVA: 0x298A29C Offset: 0x298629C VA: 0x298A29C
	|-Dictionary.Enumerator<ByteEnum, object>.get_Current
	|
	|-RVA: 0x298AA6C Offset: 0x2986A6C VA: 0x298AA6C
	|-Dictionary.Enumerator<char, char>.get_Current
	|
	|-RVA: 0x298B30C Offset: 0x298730C VA: 0x298B30C
	|-Dictionary.Enumerator<DefencePoint2, byte>.get_Current
	|
	|-RVA: 0x298C8FC Offset: 0x29888FC VA: 0x298C8FC
	|-Dictionary.Enumerator<Guid, object>.get_Current
	|
	|-RVA: 0x298D0E8 Offset: 0x29890E8 VA: 0x298D0E8
	|-Dictionary.Enumerator<short, byte>.get_Current
	|
	|-RVA: 0x298D968 Offset: 0x2989968 VA: 0x298D968
	|-Dictionary.Enumerator<short, short>.get_Current
	|
	|-RVA: 0x298E1E8 Offset: 0x298A1E8 VA: 0x298E1E8
	|-Dictionary.Enumerator<short, int>.get_Current
	|
	|-RVA: 0x298EA78 Offset: 0x298AA78 VA: 0x298EA78
	|-Dictionary.Enumerator<short, object>.get_Current
	|
	|-RVA: 0x298F24C Offset: 0x298B24C VA: 0x298F24C
	|-Dictionary.Enumerator<Int16Enum, bool>.get_Current
	|
	|-RVA: 0x298FAD0 Offset: 0x298BAD0 VA: 0x298FAD0
	|-Dictionary.Enumerator<Int16Enum, int>.get_Current
	|
	|-RVA: 0x2990360 Offset: 0x298C360 VA: 0x2990360
	|-Dictionary.Enumerator<Int16Enum, object>.get_Current
	|
	|-RVA: 0x2990B34 Offset: 0x298CB34 VA: 0x2990B34
	|-Dictionary.Enumerator<int, bool>.get_Current
	|
	|-RVA: 0x29913AC Offset: 0x298D3AC VA: 0x29913AC
	|-Dictionary.Enumerator<int, byte>.get_Current
	|
	|-RVA: 0x2991C58 Offset: 0x298DC58 VA: 0x2991C58
	|-Dictionary.Enumerator<int, Color>.get_Current
	|
	|-RVA: 0x2992530 Offset: 0x298E530 VA: 0x2992530
	|-Dictionary.Enumerator<int, short>.get_Current
	|
	|-RVA: 0x2992DA0 Offset: 0x298EDA0 VA: 0x2992DA0
	|-Dictionary.Enumerator<int, int>.get_Current
	|
	|-RVA: 0x2993610 Offset: 0x298F610 VA: 0x2993610
	|-Dictionary.Enumerator<int, Int32Enum>.get_Current
	|
	|-RVA: 0x2993E94 Offset: 0x298FE94 VA: 0x2993E94
	|-Dictionary.Enumerator<int, long>.get_Current
	|
	|-RVA: 0x2994748 Offset: 0x2990748 VA: 0x2994748
	|-Dictionary.Enumerator<int, MaterialSearchData>.get_Current
	|
	|-RVA: 0x2995030 Offset: 0x2991030 VA: 0x2995030
	|-Dictionary.Enumerator<int, object>.get_Current
	|
	|-RVA: 0x2995828 Offset: 0x2991828 VA: 0x2995828
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>.get_Current
	|
	|-RVA: 0x29960F4 Offset: 0x29920F4 VA: 0x29960F4
	|-Dictionary.Enumerator<int, float>.get_Current
	|
	|-RVA: 0x2996994 Offset: 0x2992994 VA: 0x2996994
	|-Dictionary.Enumerator<int, Vector3>.get_Current
	|
	|-RVA: 0x29972BC Offset: 0x29932BC VA: 0x29972BC
	|-Dictionary.Enumerator<int, Vector4>.get_Current
	|
	|-RVA: 0x2997BE4 Offset: 0x2993BE4 VA: 0x2997BE4
	|-Dictionary.Enumerator<int, HouseRecipeManager.RecipeData>.get_Current
	|
	|-RVA: 0x2998588 Offset: 0x2994588 VA: 0x2998588
	|-Dictionary.Enumerator<int, MasterModelDataManager.ColorListData>.get_Current
	|
	|-RVA: 0x2998F08 Offset: 0x2994F08 VA: 0x2998F08
	|-Dictionary.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.get_Current
	|
	|-RVA: 0x2999830 Offset: 0x2995830 VA: 0x2999830
	|-Dictionary.Enumerator<Int32Enum, ArchetypeUid>.get_Current
	|
	|-RVA: 0x299A0C0 Offset: 0x29960C0 VA: 0x299A0C0
	|-Dictionary.Enumerator<Int32Enum, bool>.get_Current
	|
	|-RVA: 0x299A938 Offset: 0x2996938 VA: 0x299A938
	|-Dictionary.Enumerator<Int32Enum, byte>.get_Current
	|
	|-RVA: 0x299B1E4 Offset: 0x29971E4 VA: 0x299B1E4
	|-Dictionary.Enumerator<Int32Enum, Color>.get_Current
	|
	|-RVA: 0x299BACC Offset: 0x2997ACC VA: 0x299BACC
	|-Dictionary.Enumerator<Int32Enum, DateTime>.get_Current
	|
	|-RVA: 0x299C3A0 Offset: 0x29983A0 VA: 0x299C3A0
	|-Dictionary.Enumerator<Int32Enum, EnhanceProperties2>.get_Current
	|
	|-RVA: 0x299CCD8 Offset: 0x2998CD8 VA: 0x299CCD8
	|-Dictionary.Enumerator<Int32Enum, short>.get_Current
	|
	|-RVA: 0x299D548 Offset: 0x2999548 VA: 0x299D548
	|-Dictionary.Enumerator<Int32Enum, int>.get_Current
	|
	|-RVA: 0x299DDB8 Offset: 0x2999DB8 VA: 0x299DDB8
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.get_Current
	|
	|-RVA: 0x299E63C Offset: 0x299A63C VA: 0x299E63C
	|-Dictionary.Enumerator<Int32Enum, long>.get_Current
	|
	|-RVA: 0x299EED8 Offset: 0x299AED8 VA: 0x299EED8
	|-Dictionary.Enumerator<Int32Enum, Int64Enum>.get_Current
	|
	|-RVA: 0x299F780 Offset: 0x299B780 VA: 0x299F780
	|-Dictionary.Enumerator<Int32Enum, object>.get_Current
	|
	|-RVA: 0x299FF50 Offset: 0x299BF50 VA: 0x299FF50
	|-Dictionary.Enumerator<Int32Enum, float>.get_Current
	|
	|-RVA: 0x29A07F0 Offset: 0x299C7F0 VA: 0x29A07F0
	|-Dictionary.Enumerator<Int32Enum, Vector3>.get_Current
	|
	|-RVA: 0x29A1138 Offset: 0x299D138 VA: 0x29A1138
	|-Dictionary.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.get_Current
	|
	|-RVA: 0x29A1A9C Offset: 0x299DA9C VA: 0x29A1A9C
	|-Dictionary.Enumerator<long, bool>.get_Current
	|
	|-RVA: 0x29A233C Offset: 0x299E33C VA: 0x29A233C
	|-Dictionary.Enumerator<long, byte>.get_Current
	|
	|-RVA: 0x29A2BD8 Offset: 0x299EBD8 VA: 0x29A2BD8
	|-Dictionary.Enumerator<long, short>.get_Current
	|
	|-RVA: 0x29A347C Offset: 0x299F47C VA: 0x29A347C
	|-Dictionary.Enumerator<long, object>.get_Current
	|
	|-RVA: 0x29A3C5C Offset: 0x299FC5C VA: 0x29A3C5C
	|-Dictionary.Enumerator<Int64Enum, Int32Enum>.get_Current
	|
	|-RVA: 0x29A4500 Offset: 0x29A0500 VA: 0x29A4500
	|-Dictionary.Enumerator<Int64Enum, object>.get_Current
	|
	|-RVA: 0x29A4CE8 Offset: 0x29A0CE8 VA: 0x29A4CE8
	|-Dictionary.Enumerator<IntPtr, object>.get_Current
	|
	|-RVA: 0x29A54E0 Offset: 0x29A14E0 VA: 0x29A54E0
	|-Dictionary.Enumerator<object, ValueTuple<object, byte>>.get_Current
	|
	|-RVA: 0x29A5CF0 Offset: 0x29A1CF0 VA: 0x29A5CF0
	|-Dictionary.Enumerator<object, ValueTuple<float, object>>.get_Current
	|
	|-RVA: 0x29A64F8 Offset: 0x29A24F8 VA: 0x29A64F8
	|-Dictionary.Enumerator<object, bool>.get_Current
	|
	|-RVA: 0x29A6CD0 Offset: 0x29A2CD0 VA: 0x29A6CD0
	|-Dictionary.Enumerator<object, byte>.get_Current
	|
	|-RVA: 0x29A74A4 Offset: 0x29A34A4 VA: 0x29A74A4
	|-Dictionary.Enumerator<object, short>.get_Current
	|
	|-RVA: 0x29A7C78 Offset: 0x29A3C78 VA: 0x29A7C78
	|-Dictionary.Enumerator<object, int>.get_Current
	|
	|-RVA: 0x29A844C Offset: 0x29A444C VA: 0x29A844C
	|-Dictionary.Enumerator<object, Int32Enum>.get_Current
	|
	|-RVA: 0x29A9028 Offset: 0x29A5028 VA: 0x29A9028
	|-Dictionary.Enumerator<object, object>.get_Current
	|
	|-RVA: 0x29A976C Offset: 0x29A576C VA: 0x29A976C
	|-Dictionary.Enumerator<object, ResourceLocator>.get_Current
	|
	|-RVA: 0x29A9F70 Offset: 0x29A5F70 VA: 0x29A9F70
	|-Dictionary.Enumerator<object, float>.get_Current
	|
	|-RVA: 0x29AA768 Offset: 0x29A6768 VA: 0x29AA768
	|-Dictionary.Enumerator<object, Vector3>.get_Current
	|
	|-RVA: 0x29AAFA8 Offset: 0x29A6FA8 VA: 0x29AAFA8
	|-Dictionary.Enumerator<object, DeathReceptionAction.PoisonTargetData>.get_Current
	|
	|-RVA: 0x29AB7A8 Offset: 0x29A77A8 VA: 0x29AB7A8
	|-Dictionary.Enumerator<object, UIHouseAddressManager.Town>.get_Current
	|
	|-RVA: 0x29ABF60 Offset: 0x29A7F60 VA: 0x29ABF60
	|-Dictionary.Enumerator<ushort, byte>.get_Current
	|
	|-RVA: 0x29AC818 Offset: 0x29A8818 VA: 0x29AC818
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.get_Current
	|
	|-RVA: 0x29AD600 Offset: 0x29A9600 VA: 0x29AD600
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	|
	|-RVA: 0x29B1764 Offset: 0x29AD764 VA: 0x29B1764
	|-Dictionary.Enumerator<MaterialManager.pair, object>.get_Current
	|
	|-RVA: 0x29B1F6C Offset: 0x29ADF6C VA: 0x29B1F6C
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>.get_Current
	|
	|-RVA: 0x29B2814 Offset: 0x29AE814 VA: 0x29B2814
	|-Dictionary.Enumerator<PartyManager.PartyData.pair, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980DC0 Offset: 0x297CDC0 VA: 0x2980DC0
	|-Dictionary.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x298167C Offset: 0x297D67C VA: 0x298167C
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>.Dispose
	|
	|-RVA: 0x2981EA4 Offset: 0x297DEA4 VA: 0x2981EA4
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>.Dispose
	|
	|-RVA: 0x29826AC Offset: 0x297E6AC VA: 0x29826AC
	|-Dictionary.Enumerator<ArchetypeUid, int>.Dispose
	|
	|-RVA: 0x2982F50 Offset: 0x297EF50 VA: 0x2982F50
	|-Dictionary.Enumerator<ArchetypeUid, object>.Dispose
	|
	|-RVA: 0x2983738 Offset: 0x297F738 VA: 0x2983738
	|-Dictionary.Enumerator<byte, ValueTuple<short, int, int>>.Dispose
	|
	|-RVA: 0x2984030 Offset: 0x2980030 VA: 0x2984030
	|-Dictionary.Enumerator<byte, BlackKnightAvatarProperty>.Dispose
	|
	|-RVA: 0x2984914 Offset: 0x2980914 VA: 0x2984914
	|-Dictionary.Enumerator<byte, BlackKnightCristaProperty>.Dispose
	|
	|-RVA: 0x29851E0 Offset: 0x29811E0 VA: 0x29851E0
	|-Dictionary.Enumerator<byte, byte>.Dispose
	|
	|-RVA: 0x2985A80 Offset: 0x2981A80 VA: 0x2985A80
	|-Dictionary.Enumerator<byte, CardData>.Dispose
	|
	|-RVA: 0x298635C Offset: 0x298235C VA: 0x298635C
	|-Dictionary.Enumerator<byte, short>.Dispose
	|
	|-RVA: 0x2986BDC Offset: 0x2982BDC VA: 0x2986BDC
	|-Dictionary.Enumerator<byte, int>.Dispose
	|
	|-RVA: 0x2987464 Offset: 0x2983464 VA: 0x2987464
	|-Dictionary.Enumerator<byte, long>.Dispose
	|
	|-RVA: 0x2987D0C Offset: 0x2983D0C VA: 0x2987D0C
	|-Dictionary.Enumerator<byte, object>.Dispose
	|
	|-RVA: 0x2989154 Offset: 0x2985154 VA: 0x2989154
	|-Dictionary.Enumerator<byte, float>.Dispose
	|
	|-RVA: 0x29899F8 Offset: 0x29859F8 VA: 0x29899F8
	|-Dictionary.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.Dispose
	|
	|-RVA: 0x298A2A8 Offset: 0x29862A8 VA: 0x298A2A8
	|-Dictionary.Enumerator<ByteEnum, object>.Dispose
	|
	|-RVA: 0x298AA74 Offset: 0x2986A74 VA: 0x298AA74
	|-Dictionary.Enumerator<char, char>.Dispose
	|
	|-RVA: 0x298B31C Offset: 0x298731C VA: 0x298B31C
	|-Dictionary.Enumerator<DefencePoint2, byte>.Dispose
	|
	|-RVA: 0x298C910 Offset: 0x2988910 VA: 0x298C910
	|-Dictionary.Enumerator<Guid, object>.Dispose
	|
	|-RVA: 0x298D0F0 Offset: 0x29890F0 VA: 0x298D0F0
	|-Dictionary.Enumerator<short, byte>.Dispose
	|
	|-RVA: 0x298D970 Offset: 0x2989970 VA: 0x298D970
	|-Dictionary.Enumerator<short, short>.Dispose
	|
	|-RVA: 0x298E1F0 Offset: 0x298A1F0 VA: 0x298E1F0
	|-Dictionary.Enumerator<short, int>.Dispose
	|
	|-RVA: 0x298EA84 Offset: 0x298AA84 VA: 0x298EA84
	|-Dictionary.Enumerator<short, object>.Dispose
	|
	|-RVA: 0x298F254 Offset: 0x298B254 VA: 0x298F254
	|-Dictionary.Enumerator<Int16Enum, bool>.Dispose
	|
	|-RVA: 0x298FAD8 Offset: 0x298BAD8 VA: 0x298FAD8
	|-Dictionary.Enumerator<Int16Enum, int>.Dispose
	|
	|-RVA: 0x299036C Offset: 0x298C36C VA: 0x299036C
	|-Dictionary.Enumerator<Int16Enum, object>.Dispose
	|
	|-RVA: 0x2990B3C Offset: 0x298CB3C VA: 0x2990B3C
	|-Dictionary.Enumerator<int, bool>.Dispose
	|
	|-RVA: 0x29913B4 Offset: 0x298D3B4 VA: 0x29913B4
	|-Dictionary.Enumerator<int, byte>.Dispose
	|
	|-RVA: 0x2991C6C Offset: 0x298DC6C VA: 0x2991C6C
	|-Dictionary.Enumerator<int, Color>.Dispose
	|
	|-RVA: 0x2992538 Offset: 0x298E538 VA: 0x2992538
	|-Dictionary.Enumerator<int, short>.Dispose
	|
	|-RVA: 0x2992DA8 Offset: 0x298EDA8 VA: 0x2992DA8
	|-Dictionary.Enumerator<int, int>.Dispose
	|
	|-RVA: 0x2993618 Offset: 0x298F618 VA: 0x2993618
	|-Dictionary.Enumerator<int, Int32Enum>.Dispose
	|
	|-RVA: 0x2993EA0 Offset: 0x298FEA0 VA: 0x2993EA0
	|-Dictionary.Enumerator<int, long>.Dispose
	|
	|-RVA: 0x299475C Offset: 0x299075C VA: 0x299475C
	|-Dictionary.Enumerator<int, MaterialSearchData>.Dispose
	|
	|-RVA: 0x299503C Offset: 0x299103C VA: 0x299503C
	|-Dictionary.Enumerator<int, object>.Dispose
	|
	|-RVA: 0x299583C Offset: 0x299183C VA: 0x299583C
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>.Dispose
	|
	|-RVA: 0x29960FC Offset: 0x29920FC VA: 0x29960FC
	|-Dictionary.Enumerator<int, float>.Dispose
	|
	|-RVA: 0x29969A0 Offset: 0x29929A0 VA: 0x29969A0
	|-Dictionary.Enumerator<int, Vector3>.Dispose
	|
	|-RVA: 0x29972D0 Offset: 0x29932D0 VA: 0x29972D0
	|-Dictionary.Enumerator<int, Vector4>.Dispose
	|
	|-RVA: 0x2997BF8 Offset: 0x2993BF8 VA: 0x2997BF8
	|-Dictionary.Enumerator<int, HouseRecipeManager.RecipeData>.Dispose
	|
	|-RVA: 0x29985A4 Offset: 0x29945A4 VA: 0x29985A4
	|-Dictionary.Enumerator<int, MasterModelDataManager.ColorListData>.Dispose
	|
	|-RVA: 0x2998F14 Offset: 0x2994F14 VA: 0x2998F14
	|-Dictionary.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.Dispose
	|
	|-RVA: 0x299983C Offset: 0x299583C VA: 0x299983C
	|-Dictionary.Enumerator<Int32Enum, ArchetypeUid>.Dispose
	|
	|-RVA: 0x299A0C8 Offset: 0x29960C8 VA: 0x299A0C8
	|-Dictionary.Enumerator<Int32Enum, bool>.Dispose
	|
	|-RVA: 0x299A940 Offset: 0x2996940 VA: 0x299A940
	|-Dictionary.Enumerator<Int32Enum, byte>.Dispose
	|
	|-RVA: 0x299B1F8 Offset: 0x29971F8 VA: 0x299B1F8
	|-Dictionary.Enumerator<Int32Enum, Color>.Dispose
	|
	|-RVA: 0x299BAD8 Offset: 0x2997AD8 VA: 0x299BAD8
	|-Dictionary.Enumerator<Int32Enum, DateTime>.Dispose
	|
	|-RVA: 0x299C3B4 Offset: 0x29983B4 VA: 0x299C3B4
	|-Dictionary.Enumerator<Int32Enum, EnhanceProperties2>.Dispose
	|
	|-RVA: 0x299CCE0 Offset: 0x2998CE0 VA: 0x299CCE0
	|-Dictionary.Enumerator<Int32Enum, short>.Dispose
	|
	|-RVA: 0x299D550 Offset: 0x2999550 VA: 0x299D550
	|-Dictionary.Enumerator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x299DDC0 Offset: 0x2999DC0 VA: 0x299DDC0
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x299E648 Offset: 0x299A648 VA: 0x299E648
	|-Dictionary.Enumerator<Int32Enum, long>.Dispose
	|
	|-RVA: 0x299EEE4 Offset: 0x299AEE4 VA: 0x299EEE4
	|-Dictionary.Enumerator<Int32Enum, Int64Enum>.Dispose
	|
	|-RVA: 0x299F78C Offset: 0x299B78C VA: 0x299F78C
	|-Dictionary.Enumerator<Int32Enum, object>.Dispose
	|
	|-RVA: 0x299FF58 Offset: 0x299BF58 VA: 0x299FF58
	|-Dictionary.Enumerator<Int32Enum, float>.Dispose
	|
	|-RVA: 0x29A07FC Offset: 0x299C7FC VA: 0x29A07FC
	|-Dictionary.Enumerator<Int32Enum, Vector3>.Dispose
	|
	|-RVA: 0x29A1154 Offset: 0x299D154 VA: 0x29A1154
	|-Dictionary.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.Dispose
	|
	|-RVA: 0x29A1AA8 Offset: 0x299DAA8 VA: 0x29A1AA8
	|-Dictionary.Enumerator<long, bool>.Dispose
	|
	|-RVA: 0x29A2348 Offset: 0x299E348 VA: 0x29A2348
	|-Dictionary.Enumerator<long, byte>.Dispose
	|
	|-RVA: 0x29A2BE4 Offset: 0x299EBE4 VA: 0x29A2BE4
	|-Dictionary.Enumerator<long, short>.Dispose
	|
	|-RVA: 0x29A3488 Offset: 0x299F488 VA: 0x29A3488
	|-Dictionary.Enumerator<long, object>.Dispose
	|
	|-RVA: 0x29A3C68 Offset: 0x299FC68 VA: 0x29A3C68
	|-Dictionary.Enumerator<Int64Enum, Int32Enum>.Dispose
	|
	|-RVA: 0x29A450C Offset: 0x29A050C VA: 0x29A450C
	|-Dictionary.Enumerator<Int64Enum, object>.Dispose
	|
	|-RVA: 0x29A4CF4 Offset: 0x29A0CF4 VA: 0x29A4CF4
	|-Dictionary.Enumerator<IntPtr, object>.Dispose
	|
	|-RVA: 0x29A54F4 Offset: 0x29A14F4 VA: 0x29A54F4
	|-Dictionary.Enumerator<object, ValueTuple<object, byte>>.Dispose
	|
	|-RVA: 0x29A5D04 Offset: 0x29A1D04 VA: 0x29A5D04
	|-Dictionary.Enumerator<object, ValueTuple<float, object>>.Dispose
	|
	|-RVA: 0x29A6504 Offset: 0x29A2504 VA: 0x29A6504
	|-Dictionary.Enumerator<object, bool>.Dispose
	|
	|-RVA: 0x29A6CDC Offset: 0x29A2CDC VA: 0x29A6CDC
	|-Dictionary.Enumerator<object, byte>.Dispose
	|
	|-RVA: 0x29A74B0 Offset: 0x29A34B0 VA: 0x29A74B0
	|-Dictionary.Enumerator<object, short>.Dispose
	|
	|-RVA: 0x29A7C84 Offset: 0x29A3C84 VA: 0x29A7C84
	|-Dictionary.Enumerator<object, int>.Dispose
	|
	|-RVA: 0x29A8458 Offset: 0x29A4458 VA: 0x29A8458
	|-Dictionary.Enumerator<object, Int32Enum>.Dispose
	|
	|-RVA: 0x29A9034 Offset: 0x29A5034 VA: 0x29A9034
	|-Dictionary.Enumerator<object, object>.Dispose
	|
	|-RVA: 0x29A9780 Offset: 0x29A5780 VA: 0x29A9780
	|-Dictionary.Enumerator<object, ResourceLocator>.Dispose
	|
	|-RVA: 0x29A9F7C Offset: 0x29A5F7C VA: 0x29A9F7C
	|-Dictionary.Enumerator<object, float>.Dispose
	|
	|-RVA: 0x29AA77C Offset: 0x29A677C VA: 0x29AA77C
	|-Dictionary.Enumerator<object, Vector3>.Dispose
	|
	|-RVA: 0x29AAFBC Offset: 0x29A6FBC VA: 0x29AAFBC
	|-Dictionary.Enumerator<object, DeathReceptionAction.PoisonTargetData>.Dispose
	|
	|-RVA: 0x29AB7B4 Offset: 0x29A77B4 VA: 0x29AB7B4
	|-Dictionary.Enumerator<object, UIHouseAddressManager.Town>.Dispose
	|
	|-RVA: 0x29ABF68 Offset: 0x29A7F68 VA: 0x29ABF68
	|-Dictionary.Enumerator<ushort, byte>.Dispose
	|
	|-RVA: 0x29AC824 Offset: 0x29A8824 VA: 0x29AC824
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.Dispose
	|
	|-RVA: 0x29AD6F0 Offset: 0x29A96F0 VA: 0x29AD6F0
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	|
	|-RVA: 0x29B1770 Offset: 0x29AD770 VA: 0x29B1770
	|-Dictionary.Enumerator<MaterialManager.pair, object>.Dispose
	|
	|-RVA: 0x29B1F78 Offset: 0x29ADF78 VA: 0x29B1F78
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>.Dispose
	|
	|-RVA: 0x29B2820 Offset: 0x29AE820 VA: 0x29B2820
	|-Dictionary.Enumerator<PartyManager.PartyData.pair, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980DC4 Offset: 0x297CDC4 VA: 0x2980DC4
	|-Dictionary.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2981680 Offset: 0x297D680 VA: 0x2981680
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2981EA8 Offset: 0x297DEA8 VA: 0x2981EA8
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29826B0 Offset: 0x297E6B0 VA: 0x29826B0
	|-Dictionary.Enumerator<ArchetypeUid, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2982F54 Offset: 0x297EF54 VA: 0x2982F54
	|-Dictionary.Enumerator<ArchetypeUid, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298373C Offset: 0x297F73C VA: 0x298373C
	|-Dictionary.Enumerator<byte, ValueTuple<short, int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2984034 Offset: 0x2980034 VA: 0x2984034
	|-Dictionary.Enumerator<byte, BlackKnightAvatarProperty>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2984918 Offset: 0x2980918 VA: 0x2984918
	|-Dictionary.Enumerator<byte, BlackKnightCristaProperty>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29851E4 Offset: 0x29811E4 VA: 0x29851E4
	|-Dictionary.Enumerator<byte, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2985A84 Offset: 0x2981A84 VA: 0x2985A84
	|-Dictionary.Enumerator<byte, CardData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2986360 Offset: 0x2982360 VA: 0x2986360
	|-Dictionary.Enumerator<byte, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2986BE0 Offset: 0x2982BE0 VA: 0x2986BE0
	|-Dictionary.Enumerator<byte, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2987468 Offset: 0x2983468 VA: 0x2987468
	|-Dictionary.Enumerator<byte, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2987D10 Offset: 0x2983D10 VA: 0x2987D10
	|-Dictionary.Enumerator<byte, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2989158 Offset: 0x2985158 VA: 0x2989158
	|-Dictionary.Enumerator<byte, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29899FC Offset: 0x29859FC VA: 0x29899FC
	|-Dictionary.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298A2AC Offset: 0x29862AC VA: 0x298A2AC
	|-Dictionary.Enumerator<ByteEnum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298AA78 Offset: 0x2986A78 VA: 0x298AA78
	|-Dictionary.Enumerator<char, char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298B320 Offset: 0x2987320 VA: 0x298B320
	|-Dictionary.Enumerator<DefencePoint2, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298C914 Offset: 0x2988914 VA: 0x298C914
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298D0F4 Offset: 0x29890F4 VA: 0x298D0F4
	|-Dictionary.Enumerator<short, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298D974 Offset: 0x2989974 VA: 0x298D974
	|-Dictionary.Enumerator<short, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298E1F4 Offset: 0x298A1F4 VA: 0x298E1F4
	|-Dictionary.Enumerator<short, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298EA88 Offset: 0x298AA88 VA: 0x298EA88
	|-Dictionary.Enumerator<short, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298F258 Offset: 0x298B258 VA: 0x298F258
	|-Dictionary.Enumerator<Int16Enum, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298FADC Offset: 0x298BADC VA: 0x298FADC
	|-Dictionary.Enumerator<Int16Enum, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2990370 Offset: 0x298C370 VA: 0x2990370
	|-Dictionary.Enumerator<Int16Enum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2990B40 Offset: 0x298CB40 VA: 0x2990B40
	|-Dictionary.Enumerator<int, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29913B8 Offset: 0x298D3B8 VA: 0x29913B8
	|-Dictionary.Enumerator<int, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2991C70 Offset: 0x298DC70 VA: 0x2991C70
	|-Dictionary.Enumerator<int, Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299253C Offset: 0x298E53C VA: 0x299253C
	|-Dictionary.Enumerator<int, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2992DAC Offset: 0x298EDAC VA: 0x2992DAC
	|-Dictionary.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299361C Offset: 0x298F61C VA: 0x299361C
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2993EA4 Offset: 0x298FEA4 VA: 0x2993EA4
	|-Dictionary.Enumerator<int, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2994760 Offset: 0x2990760 VA: 0x2994760
	|-Dictionary.Enumerator<int, MaterialSearchData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2995040 Offset: 0x2991040 VA: 0x2995040
	|-Dictionary.Enumerator<int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2995840 Offset: 0x2991840 VA: 0x2995840
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2996100 Offset: 0x2992100 VA: 0x2996100
	|-Dictionary.Enumerator<int, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29969A4 Offset: 0x29929A4 VA: 0x29969A4
	|-Dictionary.Enumerator<int, Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29972D4 Offset: 0x29932D4 VA: 0x29972D4
	|-Dictionary.Enumerator<int, Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2997BFC Offset: 0x2993BFC VA: 0x2997BFC
	|-Dictionary.Enumerator<int, HouseRecipeManager.RecipeData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29985A8 Offset: 0x29945A8 VA: 0x29985A8
	|-Dictionary.Enumerator<int, MasterModelDataManager.ColorListData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2998F18 Offset: 0x2994F18 VA: 0x2998F18
	|-Dictionary.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2999840 Offset: 0x2995840 VA: 0x2999840
	|-Dictionary.Enumerator<Int32Enum, ArchetypeUid>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299A0CC Offset: 0x29960CC VA: 0x299A0CC
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299A944 Offset: 0x2996944 VA: 0x299A944
	|-Dictionary.Enumerator<Int32Enum, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299B1FC Offset: 0x29971FC VA: 0x299B1FC
	|-Dictionary.Enumerator<Int32Enum, Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299BADC Offset: 0x2997ADC VA: 0x299BADC
	|-Dictionary.Enumerator<Int32Enum, DateTime>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299C3B8 Offset: 0x29983B8 VA: 0x299C3B8
	|-Dictionary.Enumerator<Int32Enum, EnhanceProperties2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299CCE4 Offset: 0x2998CE4 VA: 0x299CCE4
	|-Dictionary.Enumerator<Int32Enum, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299D554 Offset: 0x2999554 VA: 0x299D554
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299DDC4 Offset: 0x2999DC4 VA: 0x299DDC4
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299E64C Offset: 0x299A64C VA: 0x299E64C
	|-Dictionary.Enumerator<Int32Enum, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299EEE8 Offset: 0x299AEE8 VA: 0x299EEE8
	|-Dictionary.Enumerator<Int32Enum, Int64Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299F790 Offset: 0x299B790 VA: 0x299F790
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x299FF5C Offset: 0x299BF5C VA: 0x299FF5C
	|-Dictionary.Enumerator<Int32Enum, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A0800 Offset: 0x299C800 VA: 0x29A0800
	|-Dictionary.Enumerator<Int32Enum, Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A1158 Offset: 0x299D158 VA: 0x29A1158
	|-Dictionary.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A1AAC Offset: 0x299DAAC VA: 0x29A1AAC
	|-Dictionary.Enumerator<long, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A234C Offset: 0x299E34C VA: 0x29A234C
	|-Dictionary.Enumerator<long, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A2BE8 Offset: 0x299EBE8 VA: 0x29A2BE8
	|-Dictionary.Enumerator<long, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A348C Offset: 0x299F48C VA: 0x29A348C
	|-Dictionary.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A3C6C Offset: 0x299FC6C VA: 0x29A3C6C
	|-Dictionary.Enumerator<Int64Enum, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A4510 Offset: 0x29A0510 VA: 0x29A4510
	|-Dictionary.Enumerator<Int64Enum, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A4CF8 Offset: 0x29A0CF8 VA: 0x29A4CF8
	|-Dictionary.Enumerator<IntPtr, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A54F8 Offset: 0x29A14F8 VA: 0x29A54F8
	|-Dictionary.Enumerator<object, ValueTuple<object, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A5D08 Offset: 0x29A1D08 VA: 0x29A5D08
	|-Dictionary.Enumerator<object, ValueTuple<float, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A6508 Offset: 0x29A2508 VA: 0x29A6508
	|-Dictionary.Enumerator<object, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A6CE0 Offset: 0x29A2CE0 VA: 0x29A6CE0
	|-Dictionary.Enumerator<object, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A74B4 Offset: 0x29A34B4 VA: 0x29A74B4
	|-Dictionary.Enumerator<object, short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A7C88 Offset: 0x29A3C88 VA: 0x29A7C88
	|-Dictionary.Enumerator<object, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A845C Offset: 0x29A445C VA: 0x29A845C
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A9038 Offset: 0x29A5038 VA: 0x29A9038
	|-Dictionary.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A9784 Offset: 0x29A5784 VA: 0x29A9784
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29A9F80 Offset: 0x29A5F80 VA: 0x29A9F80
	|-Dictionary.Enumerator<object, float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29AA780 Offset: 0x29A6780 VA: 0x29AA780
	|-Dictionary.Enumerator<object, Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29AAFC0 Offset: 0x29A6FC0 VA: 0x29AAFC0
	|-Dictionary.Enumerator<object, DeathReceptionAction.PoisonTargetData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29AB7B8 Offset: 0x29A77B8 VA: 0x29AB7B8
	|-Dictionary.Enumerator<object, UIHouseAddressManager.Town>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29ABF6C Offset: 0x29A7F6C VA: 0x29ABF6C
	|-Dictionary.Enumerator<ushort, byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29AC828 Offset: 0x29A8828 VA: 0x29AC828
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29AD6F4 Offset: 0x29A96F4 VA: 0x29AD6F4
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29B1774 Offset: 0x29AD774 VA: 0x29B1774
	|-Dictionary.Enumerator<MaterialManager.pair, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29B1F7C Offset: 0x29ADF7C VA: 0x29B1F7C
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29B2824 Offset: 0x29AE824 VA: 0x29B2824
	|-Dictionary.Enumerator<PartyManager.PartyData.pair, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980F70 Offset: 0x297CF70 VA: 0x2980F70
	|-Dictionary.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2981808 Offset: 0x297D808 VA: 0x2981808
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2982030 Offset: 0x297E030 VA: 0x2982030
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298285C Offset: 0x297E85C VA: 0x298285C
	|-Dictionary.Enumerator<ArchetypeUid, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29830C8 Offset: 0x297F0C8 VA: 0x29830C8
	|-Dictionary.Enumerator<ArchetypeUid, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29838F8 Offset: 0x297F8F8 VA: 0x29838F8
	|-Dictionary.Enumerator<byte, ValueTuple<short, int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29841F0 Offset: 0x29801F0 VA: 0x29841F0
	|-Dictionary.Enumerator<byte, BlackKnightAvatarProperty>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2984AD4 Offset: 0x2980AD4 VA: 0x2984AD4
	|-Dictionary.Enumerator<byte, BlackKnightCristaProperty>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2985390 Offset: 0x2981390 VA: 0x2985390
	|-Dictionary.Enumerator<byte, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2985C40 Offset: 0x2981C40 VA: 0x2985C40
	|-Dictionary.Enumerator<byte, CardData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298650C Offset: 0x298250C VA: 0x298650C
	|-Dictionary.Enumerator<byte, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2986D8C Offset: 0x2982D8C VA: 0x2986D8C
	|-Dictionary.Enumerator<byte, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2987614 Offset: 0x2983614 VA: 0x2987614
	|-Dictionary.Enumerator<byte, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2987E84 Offset: 0x2983E84 VA: 0x2987E84
	|-Dictionary.Enumerator<byte, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298930C Offset: 0x298530C VA: 0x298930C
	|-Dictionary.Enumerator<byte, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2989BB4 Offset: 0x2985BB4 VA: 0x2989BB4
	|-Dictionary.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298A420 Offset: 0x2986420 VA: 0x298A420
	|-Dictionary.Enumerator<ByteEnum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298AC24 Offset: 0x2986C24 VA: 0x298AC24
	|-Dictionary.Enumerator<char, char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298B4D8 Offset: 0x29874D8 VA: 0x298B4D8
	|-Dictionary.Enumerator<DefencePoint2, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298CA9C Offset: 0x2988A9C VA: 0x298CA9C
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298D2A0 Offset: 0x29892A0 VA: 0x298D2A0
	|-Dictionary.Enumerator<short, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298DB20 Offset: 0x2989B20 VA: 0x298DB20
	|-Dictionary.Enumerator<short, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298E3A0 Offset: 0x298A3A0 VA: 0x298E3A0
	|-Dictionary.Enumerator<short, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298EBFC Offset: 0x298ABFC VA: 0x298EBFC
	|-Dictionary.Enumerator<short, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298F408 Offset: 0x298B408 VA: 0x298F408
	|-Dictionary.Enumerator<Int16Enum, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298FC88 Offset: 0x298BC88 VA: 0x298FC88
	|-Dictionary.Enumerator<Int16Enum, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29904E4 Offset: 0x298C4E4 VA: 0x29904E4
	|-Dictionary.Enumerator<Int16Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2990CF0 Offset: 0x298CCF0 VA: 0x2990CF0
	|-Dictionary.Enumerator<int, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2991564 Offset: 0x298D564 VA: 0x2991564
	|-Dictionary.Enumerator<int, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2991E4C Offset: 0x298DE4C VA: 0x2991E4C
	|-Dictionary.Enumerator<int, Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29926E8 Offset: 0x298E6E8 VA: 0x29926E8
	|-Dictionary.Enumerator<int, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2992F58 Offset: 0x298EF58 VA: 0x2992F58
	|-Dictionary.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29937C8 Offset: 0x298F7C8 VA: 0x29937C8
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2994050 Offset: 0x2990050 VA: 0x2994050
	|-Dictionary.Enumerator<int, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2994928 Offset: 0x2990928 VA: 0x2994928
	|-Dictionary.Enumerator<int, MaterialSearchData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29951B4 Offset: 0x29911B4 VA: 0x29951B4
	|-Dictionary.Enumerator<int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2995A08 Offset: 0x2991A08 VA: 0x2995A08
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29962B4 Offset: 0x29922B4 VA: 0x29962B4
	|-Dictionary.Enumerator<int, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2996B74 Offset: 0x2992B74 VA: 0x2996B74
	|-Dictionary.Enumerator<int, Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29974B0 Offset: 0x29934B0 VA: 0x29974B0
	|-Dictionary.Enumerator<int, Vector4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2997DE8 Offset: 0x2993DE8 VA: 0x2997DE8
	|-Dictionary.Enumerator<int, HouseRecipeManager.RecipeData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29987A0 Offset: 0x29947A0 VA: 0x29987A0
	|-Dictionary.Enumerator<int, MasterModelDataManager.ColorListData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29990F0 Offset: 0x29950F0 VA: 0x29990F0
	|-Dictionary.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29999EC Offset: 0x29959EC VA: 0x29999EC
	|-Dictionary.Enumerator<Int32Enum, ArchetypeUid>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299A27C Offset: 0x299627C VA: 0x299A27C
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299AAF0 Offset: 0x2996AF0 VA: 0x299AAF0
	|-Dictionary.Enumerator<Int32Enum, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299B3D8 Offset: 0x29973D8 VA: 0x299B3D8
	|-Dictionary.Enumerator<Int32Enum, Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299BC88 Offset: 0x2997C88 VA: 0x299BC88
	|-Dictionary.Enumerator<Int32Enum, DateTime>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299C5A4 Offset: 0x29985A4 VA: 0x299C5A4
	|-Dictionary.Enumerator<Int32Enum, EnhanceProperties2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299CE90 Offset: 0x2998E90 VA: 0x299CE90
	|-Dictionary.Enumerator<Int32Enum, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299D700 Offset: 0x2999700 VA: 0x299D700
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299DF70 Offset: 0x2999F70 VA: 0x299DF70
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299E7F8 Offset: 0x299A7F8 VA: 0x299E7F8
	|-Dictionary.Enumerator<Int32Enum, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299F094 Offset: 0x299B094 VA: 0x299F094
	|-Dictionary.Enumerator<Int32Enum, Int64Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x299F904 Offset: 0x299B904 VA: 0x299F904
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A0110 Offset: 0x299C110 VA: 0x29A0110
	|-Dictionary.Enumerator<Int32Enum, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A09D0 Offset: 0x299C9D0 VA: 0x29A09D0
	|-Dictionary.Enumerator<Int32Enum, Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A1350 Offset: 0x299D350 VA: 0x29A1350
	|-Dictionary.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A1C5C Offset: 0x299DC5C VA: 0x29A1C5C
	|-Dictionary.Enumerator<long, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A24F8 Offset: 0x299E4F8 VA: 0x29A24F8
	|-Dictionary.Enumerator<long, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A2D94 Offset: 0x299ED94 VA: 0x29A2D94
	|-Dictionary.Enumerator<long, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A3600 Offset: 0x299F600 VA: 0x29A3600
	|-Dictionary.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A3E18 Offset: 0x299FE18 VA: 0x29A3E18
	|-Dictionary.Enumerator<Int64Enum, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A4684 Offset: 0x29A0684 VA: 0x29A4684
	|-Dictionary.Enumerator<Int64Enum, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A4E6C Offset: 0x29A0E6C VA: 0x29A4E6C
	|-Dictionary.Enumerator<IntPtr, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A5668 Offset: 0x29A1668 VA: 0x29A5668
	|-Dictionary.Enumerator<object, ValueTuple<object, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A5E78 Offset: 0x29A1E78 VA: 0x29A5E78
	|-Dictionary.Enumerator<object, ValueTuple<float, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A6668 Offset: 0x29A2668 VA: 0x29A6668
	|-Dictionary.Enumerator<object, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A6E3C Offset: 0x29A2E3C VA: 0x29A6E3C
	|-Dictionary.Enumerator<object, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A7610 Offset: 0x29A3610 VA: 0x29A7610
	|-Dictionary.Enumerator<object, short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A7DE4 Offset: 0x29A3DE4 VA: 0x29A7DE4
	|-Dictionary.Enumerator<object, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A85B8 Offset: 0x29A45B8 VA: 0x29A85B8
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A9170 Offset: 0x29A5170 VA: 0x29A9170
	|-Dictionary.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29A98F4 Offset: 0x29A58F4 VA: 0x29A98F4
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29AA0E4 Offset: 0x29A60E4 VA: 0x29AA0E4
	|-Dictionary.Enumerator<object, float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29AA908 Offset: 0x29A6908 VA: 0x29AA908
	|-Dictionary.Enumerator<object, Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29AB130 Offset: 0x29A7130 VA: 0x29AB130
	|-Dictionary.Enumerator<object, DeathReceptionAction.PoisonTargetData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29AB914 Offset: 0x29A7914 VA: 0x29AB914
	|-Dictionary.Enumerator<object, UIHouseAddressManager.Town>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29AC118 Offset: 0x29A8118 VA: 0x29AC118
	|-Dictionary.Enumerator<ushort, byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29AC9E4 Offset: 0x29A89E4 VA: 0x29AC9E4
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29ADC64 Offset: 0x29A9C64 VA: 0x29ADC64
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29B18E8 Offset: 0x29AD8E8 VA: 0x29B18E8
	|-Dictionary.Enumerator<MaterialManager.pair, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29B2148 Offset: 0x29AE148 VA: 0x29B2148
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29B2998 Offset: 0x29AE998 VA: 0x29B2998
	|-Dictionary.Enumerator<PartyManager.PartyData.pair, object>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980FB0 Offset: 0x297CFB0 VA: 0x2980FB0
	|-Dictionary.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x298184C Offset: 0x297D84C VA: 0x298184C
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2982074 Offset: 0x297E074 VA: 0x2982074
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x298289C Offset: 0x297E89C VA: 0x298289C
	|-Dictionary.Enumerator<ArchetypeUid, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2983108 Offset: 0x297F108 VA: 0x2983108
	|-Dictionary.Enumerator<ArchetypeUid, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2983938 Offset: 0x297F938 VA: 0x2983938
	|-Dictionary.Enumerator<byte, ValueTuple<short, int, int>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2984230 Offset: 0x2980230 VA: 0x2984230
	|-Dictionary.Enumerator<byte, BlackKnightAvatarProperty>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2984B0C Offset: 0x2980B0C VA: 0x2984B0C
	|-Dictionary.Enumerator<byte, BlackKnightCristaProperty>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29853CC Offset: 0x29813CC VA: 0x29853CC
	|-Dictionary.Enumerator<byte, byte>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2985C80 Offset: 0x2981C80 VA: 0x2985C80
	|-Dictionary.Enumerator<byte, CardData>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2986544 Offset: 0x2982544 VA: 0x2986544
	|-Dictionary.Enumerator<byte, short>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2986DC8 Offset: 0x2982DC8 VA: 0x2986DC8
	|-Dictionary.Enumerator<byte, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2987654 Offset: 0x2983654 VA: 0x2987654
	|-Dictionary.Enumerator<byte, long>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2987EC4 Offset: 0x2983EC4 VA: 0x2987EC4
	|-Dictionary.Enumerator<byte, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2989348 Offset: 0x2985348 VA: 0x2989348
	|-Dictionary.Enumerator<byte, float>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2989BF0 Offset: 0x2985BF0 VA: 0x2989BF0
	|-Dictionary.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x298A460 Offset: 0x2986460 VA: 0x298A460
	|-Dictionary.Enumerator<ByteEnum, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x298AC5C Offset: 0x2986C5C VA: 0x298AC5C
	|-Dictionary.Enumerator<char, char>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x298B514 Offset: 0x2987514 VA: 0x298B514
	|-Dictionary.Enumerator<DefencePoint2, byte>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x298CAE0 Offset: 0x2988AE0 VA: 0x298CAE0
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x298D2D8 Offset: 0x29892D8 VA: 0x298D2D8
	|-Dictionary.Enumerator<short, byte>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x298DB58 Offset: 0x2989B58 VA: 0x298DB58
	|-Dictionary.Enumerator<short, short>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x298E3DC Offset: 0x298A3DC VA: 0x298E3DC
	|-Dictionary.Enumerator<short, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x298EC3C Offset: 0x298AC3C VA: 0x298EC3C
	|-Dictionary.Enumerator<short, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x298F440 Offset: 0x298B440 VA: 0x298F440
	|-Dictionary.Enumerator<Int16Enum, bool>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x298FCC4 Offset: 0x298BCC4 VA: 0x298FCC4
	|-Dictionary.Enumerator<Int16Enum, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2990524 Offset: 0x298C524 VA: 0x2990524
	|-Dictionary.Enumerator<Int16Enum, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2990D2C Offset: 0x298CD2C VA: 0x2990D2C
	|-Dictionary.Enumerator<int, bool>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29915A0 Offset: 0x298D5A0 VA: 0x29915A0
	|-Dictionary.Enumerator<int, byte>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2991E8C Offset: 0x298DE8C VA: 0x2991E8C
	|-Dictionary.Enumerator<int, Color>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2992724 Offset: 0x298E724 VA: 0x2992724
	|-Dictionary.Enumerator<int, short>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2992F94 Offset: 0x298EF94 VA: 0x2992F94
	|-Dictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2993804 Offset: 0x298F804 VA: 0x2993804
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2994090 Offset: 0x2990090 VA: 0x2994090
	|-Dictionary.Enumerator<int, long>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2994968 Offset: 0x2990968 VA: 0x2994968
	|-Dictionary.Enumerator<int, MaterialSearchData>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29951F4 Offset: 0x29911F4 VA: 0x29951F4
	|-Dictionary.Enumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2995A48 Offset: 0x2991A48 VA: 0x2995A48
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29962F0 Offset: 0x29922F0 VA: 0x29962F0
	|-Dictionary.Enumerator<int, float>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2996BB4 Offset: 0x2992BB4 VA: 0x2996BB4
	|-Dictionary.Enumerator<int, Vector3>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29974F0 Offset: 0x29934F0 VA: 0x29974F0
	|-Dictionary.Enumerator<int, Vector4>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2997E30 Offset: 0x2993E30 VA: 0x2997E30
	|-Dictionary.Enumerator<int, HouseRecipeManager.RecipeData>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29987E8 Offset: 0x29947E8 VA: 0x29987E8
	|-Dictionary.Enumerator<int, MasterModelDataManager.ColorListData>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2999134 Offset: 0x2995134 VA: 0x2999134
	|-Dictionary.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x2999A2C Offset: 0x2995A2C VA: 0x2999A2C
	|-Dictionary.Enumerator<Int32Enum, ArchetypeUid>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x299A2B8 Offset: 0x29962B8 VA: 0x299A2B8
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x299AB2C Offset: 0x2996B2C VA: 0x299AB2C
	|-Dictionary.Enumerator<Int32Enum, byte>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x299B418 Offset: 0x2997418 VA: 0x299B418
	|-Dictionary.Enumerator<Int32Enum, Color>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x299BCC8 Offset: 0x2997CC8 VA: 0x299BCC8
	|-Dictionary.Enumerator<Int32Enum, DateTime>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x299C5E8 Offset: 0x29985E8 VA: 0x299C5E8
	|-Dictionary.Enumerator<Int32Enum, EnhanceProperties2>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x299CECC Offset: 0x2998ECC VA: 0x299CECC
	|-Dictionary.Enumerator<Int32Enum, short>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x299D73C Offset: 0x299973C VA: 0x299D73C
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x299DFAC Offset: 0x2999FAC VA: 0x299DFAC
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x299E838 Offset: 0x299A838 VA: 0x299E838
	|-Dictionary.Enumerator<Int32Enum, long>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x299F0D4 Offset: 0x299B0D4 VA: 0x299F0D4
	|-Dictionary.Enumerator<Int32Enum, Int64Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x299F944 Offset: 0x299B944 VA: 0x299F944
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A014C Offset: 0x299C14C VA: 0x29A014C
	|-Dictionary.Enumerator<Int32Enum, float>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A0A10 Offset: 0x299CA10 VA: 0x29A0A10
	|-Dictionary.Enumerator<Int32Enum, Vector3>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A1398 Offset: 0x299D398 VA: 0x29A1398
	|-Dictionary.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A1C9C Offset: 0x299DC9C VA: 0x29A1C9C
	|-Dictionary.Enumerator<long, bool>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A2538 Offset: 0x299E538 VA: 0x29A2538
	|-Dictionary.Enumerator<long, byte>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A2DD4 Offset: 0x299EDD4 VA: 0x29A2DD4
	|-Dictionary.Enumerator<long, short>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A3640 Offset: 0x299F640 VA: 0x29A3640
	|-Dictionary.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A3E58 Offset: 0x299FE58 VA: 0x29A3E58
	|-Dictionary.Enumerator<Int64Enum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A46C4 Offset: 0x29A06C4 VA: 0x29A46C4
	|-Dictionary.Enumerator<Int64Enum, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A4EAC Offset: 0x29A0EAC VA: 0x29A4EAC
	|-Dictionary.Enumerator<IntPtr, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A56AC Offset: 0x29A16AC VA: 0x29A56AC
	|-Dictionary.Enumerator<object, ValueTuple<object, byte>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A5EBC Offset: 0x29A1EBC VA: 0x29A5EBC
	|-Dictionary.Enumerator<object, ValueTuple<float, object>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A66A8 Offset: 0x29A26A8 VA: 0x29A66A8
	|-Dictionary.Enumerator<object, bool>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A6E7C Offset: 0x29A2E7C VA: 0x29A6E7C
	|-Dictionary.Enumerator<object, byte>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A7650 Offset: 0x29A3650 VA: 0x29A7650
	|-Dictionary.Enumerator<object, short>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A7E24 Offset: 0x29A3E24 VA: 0x29A7E24
	|-Dictionary.Enumerator<object, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A85F8 Offset: 0x29A45F8 VA: 0x29A85F8
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A91B0 Offset: 0x29A51B0 VA: 0x29A91B0
	|-Dictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29A9938 Offset: 0x29A5938 VA: 0x29A9938
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29AA124 Offset: 0x29A6124 VA: 0x29AA124
	|-Dictionary.Enumerator<object, float>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29AA94C Offset: 0x29A694C VA: 0x29AA94C
	|-Dictionary.Enumerator<object, Vector3>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29AB174 Offset: 0x29A7174 VA: 0x29AB174
	|-Dictionary.Enumerator<object, DeathReceptionAction.PoisonTargetData>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29AB954 Offset: 0x29A7954 VA: 0x29AB954
	|-Dictionary.Enumerator<object, UIHouseAddressManager.Town>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29AC150 Offset: 0x29A8150 VA: 0x29AC150
	|-Dictionary.Enumerator<ushort, byte>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29ACA28 Offset: 0x29A8A28 VA: 0x29ACA28
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29ADD90 Offset: 0x29A9D90 VA: 0x29ADD90
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29B1928 Offset: 0x29AD928 VA: 0x29B1928
	|-Dictionary.Enumerator<MaterialManager.pair, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29B218C Offset: 0x29AE18C VA: 0x29B218C
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29B29D8 Offset: 0x29AE9D8 VA: 0x29B29D8
	|-Dictionary.Enumerator<PartyManager.PartyData.pair, object>.System.Collections.IDictionaryEnumerator.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IDictionaryEnumerator.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29810AC Offset: 0x297D0AC VA: 0x29810AC
	|-Dictionary.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2981910 Offset: 0x297D910 VA: 0x2981910
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2982138 Offset: 0x297E138 VA: 0x2982138
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2982998 Offset: 0x297E998 VA: 0x2982998
	|-Dictionary.Enumerator<ArchetypeUid, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29831CC Offset: 0x297F1CC VA: 0x29831CC
	|-Dictionary.Enumerator<ArchetypeUid, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2983A3C Offset: 0x297FA3C VA: 0x2983A3C
	|-Dictionary.Enumerator<byte, ValueTuple<short, int, int>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2984334 Offset: 0x2980334 VA: 0x2984334
	|-Dictionary.Enumerator<byte, BlackKnightAvatarProperty>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2984C10 Offset: 0x2980C10 VA: 0x2984C10
	|-Dictionary.Enumerator<byte, BlackKnightCristaProperty>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29854C8 Offset: 0x29814C8 VA: 0x29854C8
	|-Dictionary.Enumerator<byte, byte>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2985D84 Offset: 0x2981D84 VA: 0x2985D84
	|-Dictionary.Enumerator<byte, CardData>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2986640 Offset: 0x2982640 VA: 0x2986640
	|-Dictionary.Enumerator<byte, short>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2986EC4 Offset: 0x2982EC4 VA: 0x2986EC4
	|-Dictionary.Enumerator<byte, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2987750 Offset: 0x2983750 VA: 0x2987750
	|-Dictionary.Enumerator<byte, long>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2987F88 Offset: 0x2983F88 VA: 0x2987F88
	|-Dictionary.Enumerator<byte, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2989444 Offset: 0x2985444 VA: 0x2989444
	|-Dictionary.Enumerator<byte, float>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2989CEC Offset: 0x2985CEC VA: 0x2989CEC
	|-Dictionary.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x298A524 Offset: 0x2986524 VA: 0x298A524
	|-Dictionary.Enumerator<ByteEnum, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x298AD58 Offset: 0x2986D58 VA: 0x298AD58
	|-Dictionary.Enumerator<char, char>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x298B610 Offset: 0x2987610 VA: 0x298B610
	|-Dictionary.Enumerator<DefencePoint2, byte>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x298CBA4 Offset: 0x2988BA4 VA: 0x298CBA4
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x298D3D4 Offset: 0x29893D4 VA: 0x298D3D4
	|-Dictionary.Enumerator<short, byte>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x298DC54 Offset: 0x2989C54 VA: 0x298DC54
	|-Dictionary.Enumerator<short, short>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x298E4D8 Offset: 0x298A4D8 VA: 0x298E4D8
	|-Dictionary.Enumerator<short, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x298ED00 Offset: 0x298AD00 VA: 0x298ED00
	|-Dictionary.Enumerator<short, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x298F53C Offset: 0x298B53C VA: 0x298F53C
	|-Dictionary.Enumerator<Int16Enum, bool>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x298FDC0 Offset: 0x298BDC0 VA: 0x298FDC0
	|-Dictionary.Enumerator<Int16Enum, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29905E8 Offset: 0x298C5E8 VA: 0x29905E8
	|-Dictionary.Enumerator<Int16Enum, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2990E28 Offset: 0x298CE28 VA: 0x2990E28
	|-Dictionary.Enumerator<int, bool>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x299169C Offset: 0x298D69C VA: 0x299169C
	|-Dictionary.Enumerator<int, byte>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2991F88 Offset: 0x298DF88 VA: 0x2991F88
	|-Dictionary.Enumerator<int, Color>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2992820 Offset: 0x298E820 VA: 0x2992820
	|-Dictionary.Enumerator<int, short>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2993090 Offset: 0x298F090 VA: 0x2993090
	|-Dictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2993900 Offset: 0x298F900 VA: 0x2993900
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x299418C Offset: 0x299018C VA: 0x299418C
	|-Dictionary.Enumerator<int, long>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2994A68 Offset: 0x2990A68 VA: 0x2994A68
	|-Dictionary.Enumerator<int, MaterialSearchData>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29952B8 Offset: 0x29912B8 VA: 0x29952B8
	|-Dictionary.Enumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2995B48 Offset: 0x2991B48 VA: 0x2995B48
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29963EC Offset: 0x29923EC VA: 0x29963EC
	|-Dictionary.Enumerator<int, float>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2996CB8 Offset: 0x2992CB8 VA: 0x2996CB8
	|-Dictionary.Enumerator<int, Vector3>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29975EC Offset: 0x29935EC VA: 0x29975EC
	|-Dictionary.Enumerator<int, Vector4>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2997F38 Offset: 0x2993F38 VA: 0x2997F38
	|-Dictionary.Enumerator<int, HouseRecipeManager.RecipeData>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29988F0 Offset: 0x29948F0 VA: 0x29988F0
	|-Dictionary.Enumerator<int, MasterModelDataManager.ColorListData>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2999238 Offset: 0x2995238 VA: 0x2999238
	|-Dictionary.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x2999B28 Offset: 0x2995B28 VA: 0x2999B28
	|-Dictionary.Enumerator<Int32Enum, ArchetypeUid>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x299A3B4 Offset: 0x29963B4 VA: 0x299A3B4
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x299AC28 Offset: 0x2996C28 VA: 0x299AC28
	|-Dictionary.Enumerator<Int32Enum, byte>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x299B514 Offset: 0x2997514 VA: 0x299B514
	|-Dictionary.Enumerator<Int32Enum, Color>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x299BDC4 Offset: 0x2997DC4 VA: 0x299BDC4
	|-Dictionary.Enumerator<Int32Enum, DateTime>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x299C6F0 Offset: 0x29986F0 VA: 0x299C6F0
	|-Dictionary.Enumerator<Int32Enum, EnhanceProperties2>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x299CFC8 Offset: 0x2998FC8 VA: 0x299CFC8
	|-Dictionary.Enumerator<Int32Enum, short>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x299D838 Offset: 0x2999838 VA: 0x299D838
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x299E0A8 Offset: 0x299A0A8 VA: 0x299E0A8
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x299E934 Offset: 0x299A934 VA: 0x299E934
	|-Dictionary.Enumerator<Int32Enum, long>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x299F1D0 Offset: 0x299B1D0 VA: 0x299F1D0
	|-Dictionary.Enumerator<Int32Enum, Int64Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x299FA08 Offset: 0x299BA08 VA: 0x299FA08
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A0248 Offset: 0x299C248 VA: 0x29A0248
	|-Dictionary.Enumerator<Int32Enum, float>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A0B14 Offset: 0x299CB14 VA: 0x29A0B14
	|-Dictionary.Enumerator<Int32Enum, Vector3>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A14A0 Offset: 0x299D4A0 VA: 0x29A14A0
	|-Dictionary.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A1D98 Offset: 0x299DD98 VA: 0x29A1D98
	|-Dictionary.Enumerator<long, bool>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A2634 Offset: 0x299E634 VA: 0x29A2634
	|-Dictionary.Enumerator<long, byte>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A2ED0 Offset: 0x299EED0 VA: 0x29A2ED0
	|-Dictionary.Enumerator<long, short>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A3704 Offset: 0x299F704 VA: 0x29A3704
	|-Dictionary.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A3F54 Offset: 0x299FF54 VA: 0x29A3F54
	|-Dictionary.Enumerator<Int64Enum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A4788 Offset: 0x29A0788 VA: 0x29A4788
	|-Dictionary.Enumerator<Int64Enum, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A4F70 Offset: 0x29A0F70 VA: 0x29A4F70
	|-Dictionary.Enumerator<IntPtr, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A5770 Offset: 0x29A1770 VA: 0x29A5770
	|-Dictionary.Enumerator<object, ValueTuple<object, byte>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A5F80 Offset: 0x29A1F80 VA: 0x29A5F80
	|-Dictionary.Enumerator<object, ValueTuple<float, object>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A676C Offset: 0x29A276C VA: 0x29A676C
	|-Dictionary.Enumerator<object, bool>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A6F40 Offset: 0x29A2F40 VA: 0x29A6F40
	|-Dictionary.Enumerator<object, byte>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A7714 Offset: 0x29A3714 VA: 0x29A7714
	|-Dictionary.Enumerator<object, short>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A7EE8 Offset: 0x29A3EE8 VA: 0x29A7EE8
	|-Dictionary.Enumerator<object, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A86BC Offset: 0x29A46BC VA: 0x29A86BC
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A9248 Offset: 0x29A5248 VA: 0x29A9248
	|-Dictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29A99FC Offset: 0x29A59FC VA: 0x29A99FC
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29AA1E8 Offset: 0x29A61E8 VA: 0x29AA1E8
	|-Dictionary.Enumerator<object, float>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29AAA18 Offset: 0x29A6A18 VA: 0x29AAA18
	|-Dictionary.Enumerator<object, Vector3>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29AB238 Offset: 0x29A7238 VA: 0x29AB238
	|-Dictionary.Enumerator<object, DeathReceptionAction.PoisonTargetData>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29ABA18 Offset: 0x29A7A18 VA: 0x29ABA18
	|-Dictionary.Enumerator<object, UIHouseAddressManager.Town>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29AC24C Offset: 0x29A824C VA: 0x29AC24C
	|-Dictionary.Enumerator<ushort, byte>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29ACB24 Offset: 0x29A8B24 VA: 0x29ACB24
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29AE0D4 Offset: 0x29AA0D4 VA: 0x29AE0D4
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29B19EC Offset: 0x29AD9EC VA: 0x29B19EC
	|-Dictionary.Enumerator<MaterialManager.pair, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29B225C Offset: 0x29AE25C VA: 0x29B225C
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29B2A9C Offset: 0x29AEA9C VA: 0x29B2A9C
	|-Dictionary.Enumerator<PartyManager.PartyData.pair, object>.System.Collections.IDictionaryEnumerator.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private object System.Collections.IDictionaryEnumerator.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2981134 Offset: 0x297D134 VA: 0x2981134
	|-Dictionary.Enumerator<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29819A0 Offset: 0x297D9A0 VA: 0x29819A0
	|-Dictionary.Enumerator<KeyValuePair<object, object>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29821C8 Offset: 0x297E1C8 VA: 0x29821C8
	|-Dictionary.Enumerator<ValueTuple<object, object>, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2982A20 Offset: 0x297EA20 VA: 0x2982A20
	|-Dictionary.Enumerator<ArchetypeUid, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2983254 Offset: 0x297F254 VA: 0x2983254
	|-Dictionary.Enumerator<ArchetypeUid, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2983AC4 Offset: 0x297FAC4 VA: 0x2983AC4
	|-Dictionary.Enumerator<byte, ValueTuple<short, int, int>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29843BC Offset: 0x29803BC VA: 0x29843BC
	|-Dictionary.Enumerator<byte, BlackKnightAvatarProperty>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2984C98 Offset: 0x2980C98 VA: 0x2984C98
	|-Dictionary.Enumerator<byte, BlackKnightCristaProperty>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2985550 Offset: 0x2981550 VA: 0x2985550
	|-Dictionary.Enumerator<byte, byte>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2985E0C Offset: 0x2981E0C VA: 0x2985E0C
	|-Dictionary.Enumerator<byte, CardData>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29866C8 Offset: 0x29826C8 VA: 0x29866C8
	|-Dictionary.Enumerator<byte, short>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2986F4C Offset: 0x2982F4C VA: 0x2986F4C
	|-Dictionary.Enumerator<byte, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29877D8 Offset: 0x29837D8 VA: 0x29877D8
	|-Dictionary.Enumerator<byte, long>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2988010 Offset: 0x2984010 VA: 0x2988010
	|-Dictionary.Enumerator<byte, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29894CC Offset: 0x29854CC VA: 0x29894CC
	|-Dictionary.Enumerator<byte, float>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2989D74 Offset: 0x2985D74 VA: 0x2989D74
	|-Dictionary.Enumerator<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x298A5AC Offset: 0x29865AC VA: 0x298A5AC
	|-Dictionary.Enumerator<ByteEnum, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x298ADE0 Offset: 0x2986DE0 VA: 0x298ADE0
	|-Dictionary.Enumerator<char, char>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x298B698 Offset: 0x2987698 VA: 0x298B698
	|-Dictionary.Enumerator<DefencePoint2, byte>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x298CC34 Offset: 0x2988C34 VA: 0x298CC34
	|-Dictionary.Enumerator<Guid, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x298D45C Offset: 0x298945C VA: 0x298D45C
	|-Dictionary.Enumerator<short, byte>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x298DCDC Offset: 0x2989CDC VA: 0x298DCDC
	|-Dictionary.Enumerator<short, short>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x298E560 Offset: 0x298A560 VA: 0x298E560
	|-Dictionary.Enumerator<short, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x298ED88 Offset: 0x298AD88 VA: 0x298ED88
	|-Dictionary.Enumerator<short, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x298F5C4 Offset: 0x298B5C4 VA: 0x298F5C4
	|-Dictionary.Enumerator<Int16Enum, bool>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x298FE48 Offset: 0x298BE48 VA: 0x298FE48
	|-Dictionary.Enumerator<Int16Enum, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2990670 Offset: 0x298C670 VA: 0x2990670
	|-Dictionary.Enumerator<Int16Enum, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2990EB0 Offset: 0x298CEB0 VA: 0x2990EB0
	|-Dictionary.Enumerator<int, bool>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2991724 Offset: 0x298D724 VA: 0x2991724
	|-Dictionary.Enumerator<int, byte>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2992010 Offset: 0x298E010 VA: 0x2992010
	|-Dictionary.Enumerator<int, Color>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29928A8 Offset: 0x298E8A8 VA: 0x29928A8
	|-Dictionary.Enumerator<int, short>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2993118 Offset: 0x298F118 VA: 0x2993118
	|-Dictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2993988 Offset: 0x298F988 VA: 0x2993988
	|-Dictionary.Enumerator<int, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2994214 Offset: 0x2990214 VA: 0x2994214
	|-Dictionary.Enumerator<int, long>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2994AF0 Offset: 0x2990AF0 VA: 0x2994AF0
	|-Dictionary.Enumerator<int, MaterialSearchData>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2995340 Offset: 0x2991340 VA: 0x2995340
	|-Dictionary.Enumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2995BD0 Offset: 0x2991BD0 VA: 0x2995BD0
	|-Dictionary.Enumerator<int, RenderInstancedDataLayout>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2996474 Offset: 0x2992474 VA: 0x2996474
	|-Dictionary.Enumerator<int, float>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2996D40 Offset: 0x2992D40 VA: 0x2996D40
	|-Dictionary.Enumerator<int, Vector3>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2997674 Offset: 0x2993674 VA: 0x2997674
	|-Dictionary.Enumerator<int, Vector4>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2997FC0 Offset: 0x2993FC0 VA: 0x2997FC0
	|-Dictionary.Enumerator<int, HouseRecipeManager.RecipeData>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2998978 Offset: 0x2994978 VA: 0x2998978
	|-Dictionary.Enumerator<int, MasterModelDataManager.ColorListData>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29992C0 Offset: 0x29952C0 VA: 0x29992C0
	|-Dictionary.Enumerator<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x2999BB0 Offset: 0x2995BB0 VA: 0x2999BB0
	|-Dictionary.Enumerator<Int32Enum, ArchetypeUid>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x299A43C Offset: 0x299643C VA: 0x299A43C
	|-Dictionary.Enumerator<Int32Enum, bool>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x299ACB0 Offset: 0x2996CB0 VA: 0x299ACB0
	|-Dictionary.Enumerator<Int32Enum, byte>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x299B59C Offset: 0x299759C VA: 0x299B59C
	|-Dictionary.Enumerator<Int32Enum, Color>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x299BE4C Offset: 0x2997E4C VA: 0x299BE4C
	|-Dictionary.Enumerator<Int32Enum, DateTime>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x299C778 Offset: 0x2998778 VA: 0x299C778
	|-Dictionary.Enumerator<Int32Enum, EnhanceProperties2>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x299D050 Offset: 0x2999050 VA: 0x299D050
	|-Dictionary.Enumerator<Int32Enum, short>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x299D8C0 Offset: 0x29998C0 VA: 0x299D8C0
	|-Dictionary.Enumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x299E130 Offset: 0x299A130 VA: 0x299E130
	|-Dictionary.Enumerator<Int32Enum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x299E9BC Offset: 0x299A9BC VA: 0x299E9BC
	|-Dictionary.Enumerator<Int32Enum, long>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x299F258 Offset: 0x299B258 VA: 0x299F258
	|-Dictionary.Enumerator<Int32Enum, Int64Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x299FA90 Offset: 0x299BA90 VA: 0x299FA90
	|-Dictionary.Enumerator<Int32Enum, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A02D0 Offset: 0x299C2D0 VA: 0x29A02D0
	|-Dictionary.Enumerator<Int32Enum, float>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A0B9C Offset: 0x299CB9C VA: 0x29A0B9C
	|-Dictionary.Enumerator<Int32Enum, Vector3>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A1528 Offset: 0x299D528 VA: 0x29A1528
	|-Dictionary.Enumerator<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A1E20 Offset: 0x299DE20 VA: 0x29A1E20
	|-Dictionary.Enumerator<long, bool>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A26BC Offset: 0x299E6BC VA: 0x29A26BC
	|-Dictionary.Enumerator<long, byte>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A2F58 Offset: 0x299EF58 VA: 0x29A2F58
	|-Dictionary.Enumerator<long, short>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A378C Offset: 0x299F78C VA: 0x29A378C
	|-Dictionary.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A3FDC Offset: 0x299FFDC VA: 0x29A3FDC
	|-Dictionary.Enumerator<Int64Enum, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A4810 Offset: 0x29A0810 VA: 0x29A4810
	|-Dictionary.Enumerator<Int64Enum, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A4FF8 Offset: 0x29A0FF8 VA: 0x29A4FF8
	|-Dictionary.Enumerator<IntPtr, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A57CC Offset: 0x29A17CC VA: 0x29A57CC
	|-Dictionary.Enumerator<object, ValueTuple<object, byte>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A5FDC Offset: 0x29A1FDC VA: 0x29A5FDC
	|-Dictionary.Enumerator<object, ValueTuple<float, object>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A67C8 Offset: 0x29A27C8 VA: 0x29A67C8
	|-Dictionary.Enumerator<object, bool>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A6F9C Offset: 0x29A2F9C VA: 0x29A6F9C
	|-Dictionary.Enumerator<object, byte>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A7770 Offset: 0x29A3770 VA: 0x29A7770
	|-Dictionary.Enumerator<object, short>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A7F44 Offset: 0x29A3F44 VA: 0x29A7F44
	|-Dictionary.Enumerator<object, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A8718 Offset: 0x29A4718 VA: 0x29A8718
	|-Dictionary.Enumerator<object, Int32Enum>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A92A4 Offset: 0x29A52A4 VA: 0x29A92A4
	|-Dictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29A9A58 Offset: 0x29A5A58 VA: 0x29A9A58
	|-Dictionary.Enumerator<object, ResourceLocator>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29AA244 Offset: 0x29A6244 VA: 0x29AA244
	|-Dictionary.Enumerator<object, float>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29AAA74 Offset: 0x29A6A74 VA: 0x29AAA74
	|-Dictionary.Enumerator<object, Vector3>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29AB294 Offset: 0x29A7294 VA: 0x29AB294
	|-Dictionary.Enumerator<object, DeathReceptionAction.PoisonTargetData>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29ABA74 Offset: 0x29A7A74 VA: 0x29ABA74
	|-Dictionary.Enumerator<object, UIHouseAddressManager.Town>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29AC2D4 Offset: 0x29A82D4 VA: 0x29AC2D4
	|-Dictionary.Enumerator<ushort, byte>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29ACBB4 Offset: 0x29A8BB4 VA: 0x29ACBB4
	|-Dictionary.Enumerator<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29AE2E8 Offset: 0x29AA2E8 VA: 0x29AE2E8
	|-Dictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29B1A74 Offset: 0x29ADA74 VA: 0x29B1A74
	|-Dictionary.Enumerator<MaterialManager.pair, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29B22F8 Offset: 0x29AE2F8 VA: 0x29B22F8
	|-Dictionary.Enumerator<Regex.CachedCodeEntryKey, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29B2B24 Offset: 0x29AEB24 VA: 0x29B2B24
	|-Dictionary.Enumerator<PartyManager.PartyData.pair, object>.System.Collections.IDictionaryEnumerator.get_Value
	*/
}
