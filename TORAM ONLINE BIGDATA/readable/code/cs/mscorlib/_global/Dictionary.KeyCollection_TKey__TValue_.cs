// Assembly: mscorlib.dll
// Namespace: 
[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<TKey, TValue>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public sealed class Dictionary.KeyCollection<TKey, TValue> : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey> // TypeDefIndex: 10927
{
	// Fields
	private Dictionary<TKey, TValue> _dictionary; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7A22C Offset: 0x2A7622C VA: 0x2A7A22C
	|-Dictionary.KeyCollection<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2A7A844 Offset: 0x2A76844 VA: 0x2A7A844
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x2A7AE6C Offset: 0x2A76E6C VA: 0x2A7AE6C
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0x2A7B494 Offset: 0x2A77494 VA: 0x2A7B494
	|-Dictionary.KeyCollection<ArchetypeUid, int>..ctor
	|
	|-RVA: 0x2A7BAAC Offset: 0x2A77AAC VA: 0x2A7BAAC
	|-Dictionary.KeyCollection<ArchetypeUid, object>..ctor
	|
	|-RVA: 0x2A7C0C4 Offset: 0x2A780C4 VA: 0x2A7C0C4
	|-Dictionary.KeyCollection<byte, ValueTuple<short, int, int>>..ctor
	|
	|-RVA: 0x2A7C6DC Offset: 0x2A786DC VA: 0x2A7C6DC
	|-Dictionary.KeyCollection<byte, BlackKnightAvatarProperty>..ctor
	|
	|-RVA: 0x2A7CCF4 Offset: 0x2A78CF4 VA: 0x2A7CCF4
	|-Dictionary.KeyCollection<byte, BlackKnightCristaProperty>..ctor
	|
	|-RVA: 0x2A7D30C Offset: 0x2A7930C VA: 0x2A7D30C
	|-Dictionary.KeyCollection<byte, byte>..ctor
	|
	|-RVA: 0x2A7D924 Offset: 0x2A79924 VA: 0x2A7D924
	|-Dictionary.KeyCollection<byte, CardData>..ctor
	|
	|-RVA: 0x2A7DF3C Offset: 0x2A79F3C VA: 0x2A7DF3C
	|-Dictionary.KeyCollection<byte, short>..ctor
	|
	|-RVA: 0x2A7E554 Offset: 0x2A7A554 VA: 0x2A7E554
	|-Dictionary.KeyCollection<byte, int>..ctor
	|
	|-RVA: 0x2A7EB6C Offset: 0x2A7AB6C VA: 0x2A7EB6C
	|-Dictionary.KeyCollection<byte, long>..ctor
	|
	|-RVA: 0x2A7F184 Offset: 0x2A7B184 VA: 0x2A7F184
	|-Dictionary.KeyCollection<byte, object>..ctor
	|
	|-RVA: 0x2A800A0 Offset: 0x2A7C0A0 VA: 0x2A800A0
	|-Dictionary.KeyCollection<byte, float>..ctor
	|
	|-RVA: 0x2A806B8 Offset: 0x2A7C6B8 VA: 0x2A806B8
	|-Dictionary.KeyCollection<byte, MasterModelDataManager.ConvertCommonMaterialData>..ctor
	|
	|-RVA: 0x2A80CD0 Offset: 0x2A7CCD0 VA: 0x2A80CD0
	|-Dictionary.KeyCollection<ByteEnum, object>..ctor
	|
	|-RVA: 0x2A812E8 Offset: 0x2A7D2E8 VA: 0x2A812E8
	|-Dictionary.KeyCollection<char, char>..ctor
	|
	|-RVA: 0x2A81900 Offset: 0x2A7D900 VA: 0x2A81900
	|-Dictionary.KeyCollection<DefencePoint2, byte>..ctor
	|
	|-RVA: 0x2A8281C Offset: 0x2A7E81C VA: 0x2A8281C
	|-Dictionary.KeyCollection<Guid, object>..ctor
	|
	|-RVA: 0x2A82E30 Offset: 0x2A7EE30 VA: 0x2A82E30
	|-Dictionary.KeyCollection<short, byte>..ctor
	|
	|-RVA: 0x2A83448 Offset: 0x2A7F448 VA: 0x2A83448
	|-Dictionary.KeyCollection<short, short>..ctor
	|
	|-RVA: 0x2A83A60 Offset: 0x2A7FA60 VA: 0x2A83A60
	|-Dictionary.KeyCollection<short, int>..ctor
	|
	|-RVA: 0x2A84078 Offset: 0x2A80078 VA: 0x2A84078
	|-Dictionary.KeyCollection<short, object>..ctor
	|
	|-RVA: 0x2A84690 Offset: 0x2A80690 VA: 0x2A84690
	|-Dictionary.KeyCollection<Int16Enum, bool>..ctor
	|
	|-RVA: 0x2A84CA8 Offset: 0x2A80CA8 VA: 0x2A84CA8
	|-Dictionary.KeyCollection<Int16Enum, int>..ctor
	|
	|-RVA: 0x2A852C0 Offset: 0x2A812C0 VA: 0x2A852C0
	|-Dictionary.KeyCollection<Int16Enum, object>..ctor
	|
	|-RVA: 0x2A858D8 Offset: 0x2A818D8 VA: 0x2A858D8
	|-Dictionary.KeyCollection<int, bool>..ctor
	|
	|-RVA: 0x2A85EF0 Offset: 0x2A81EF0 VA: 0x2A85EF0
	|-Dictionary.KeyCollection<int, byte>..ctor
	|
	|-RVA: 0x2A86508 Offset: 0x2A82508 VA: 0x2A86508
	|-Dictionary.KeyCollection<int, Color>..ctor
	|
	|-RVA: 0x2A86B20 Offset: 0x2A82B20 VA: 0x2A86B20
	|-Dictionary.KeyCollection<int, short>..ctor
	|
	|-RVA: 0x2A87138 Offset: 0x2A83138 VA: 0x2A87138
	|-Dictionary.KeyCollection<int, int>..ctor
	|
	|-RVA: 0x2A87750 Offset: 0x2A83750 VA: 0x2A87750
	|-Dictionary.KeyCollection<int, Int32Enum>..ctor
	|
	|-RVA: 0x2A87D68 Offset: 0x2A83D68 VA: 0x2A87D68
	|-Dictionary.KeyCollection<int, long>..ctor
	|
	|-RVA: 0x2A88380 Offset: 0x2A84380 VA: 0x2A88380
	|-Dictionary.KeyCollection<int, MaterialSearchData>..ctor
	|
	|-RVA: 0x2A88998 Offset: 0x2A84998 VA: 0x2A88998
	|-Dictionary.KeyCollection<int, object>..ctor
	|
	|-RVA: 0x2A88FB0 Offset: 0x2A84FB0 VA: 0x2A88FB0
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x2A895C8 Offset: 0x2A855C8 VA: 0x2A895C8
	|-Dictionary.KeyCollection<int, float>..ctor
	|
	|-RVA: 0x2A89BE0 Offset: 0x2A85BE0 VA: 0x2A89BE0
	|-Dictionary.KeyCollection<int, Vector3>..ctor
	|
	|-RVA: 0x2A8A1F8 Offset: 0x2A861F8 VA: 0x2A8A1F8
	|-Dictionary.KeyCollection<int, Vector4>..ctor
	|
	|-RVA: 0x2A8A810 Offset: 0x2A86810 VA: 0x2A8A810
	|-Dictionary.KeyCollection<int, HouseRecipeManager.RecipeData>..ctor
	|
	|-RVA: 0x2A8AE28 Offset: 0x2A86E28 VA: 0x2A8AE28
	|-Dictionary.KeyCollection<int, MasterModelDataManager.ColorListData>..ctor
	|
	|-RVA: 0x2A8B440 Offset: 0x2A87440 VA: 0x2A8B440
	|-Dictionary.KeyCollection<int, UIGuildQuestBoardManager.GuildQuestMaseter>..ctor
	|
	|-RVA: 0x2A8BA58 Offset: 0x2A87A58 VA: 0x2A8BA58
	|-Dictionary.KeyCollection<Int32Enum, ArchetypeUid>..ctor
	|
	|-RVA: 0x2A8C070 Offset: 0x2A88070 VA: 0x2A8C070
	|-Dictionary.KeyCollection<Int32Enum, bool>..ctor
	|
	|-RVA: 0x2A8C688 Offset: 0x2A88688 VA: 0x2A8C688
	|-Dictionary.KeyCollection<Int32Enum, byte>..ctor
	|
	|-RVA: 0x2A8CCA0 Offset: 0x2A88CA0 VA: 0x2A8CCA0
	|-Dictionary.KeyCollection<Int32Enum, Color>..ctor
	|
	|-RVA: 0x2A8D2B8 Offset: 0x2A892B8 VA: 0x2A8D2B8
	|-Dictionary.KeyCollection<Int32Enum, DateTime>..ctor
	|
	|-RVA: 0x2A8D8D0 Offset: 0x2A898D0 VA: 0x2A8D8D0
	|-Dictionary.KeyCollection<Int32Enum, EnhanceProperties2>..ctor
	|
	|-RVA: 0x2A8DEE8 Offset: 0x2A89EE8 VA: 0x2A8DEE8
	|-Dictionary.KeyCollection<Int32Enum, short>..ctor
	|
	|-RVA: 0x2A8E500 Offset: 0x2A8A500 VA: 0x2A8E500
	|-Dictionary.KeyCollection<Int32Enum, int>..ctor
	|
	|-RVA: 0x2A8EB18 Offset: 0x2A8AB18 VA: 0x2A8EB18
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x2A8F130 Offset: 0x2A8B130 VA: 0x2A8F130
	|-Dictionary.KeyCollection<Int32Enum, long>..ctor
	|
	|-RVA: 0x2A8F748 Offset: 0x2A8B748 VA: 0x2A8F748
	|-Dictionary.KeyCollection<Int32Enum, Int64Enum>..ctor
	|
	|-RVA: 0x2A8FD60 Offset: 0x2A8BD60 VA: 0x2A8FD60
	|-Dictionary.KeyCollection<Int32Enum, object>..ctor
	|
	|-RVA: 0x2A90378 Offset: 0x2A8C378 VA: 0x2A90378
	|-Dictionary.KeyCollection<Int32Enum, float>..ctor
	|
	|-RVA: 0x2A90990 Offset: 0x2A8C990 VA: 0x2A90990
	|-Dictionary.KeyCollection<Int32Enum, Vector3>..ctor
	|
	|-RVA: 0x2A90FA8 Offset: 0x2A8CFA8 VA: 0x2A90FA8
	|-Dictionary.KeyCollection<Int32Enum, MasterModelDataManager.ColorListData>..ctor
	|
	|-RVA: 0x2A915C0 Offset: 0x2A8D5C0 VA: 0x2A915C0
	|-Dictionary.KeyCollection<long, bool>..ctor
	|
	|-RVA: 0x2A91BD8 Offset: 0x2A8DBD8 VA: 0x2A91BD8
	|-Dictionary.KeyCollection<long, byte>..ctor
	|
	|-RVA: 0x2A921F0 Offset: 0x2A8E1F0 VA: 0x2A921F0
	|-Dictionary.KeyCollection<long, short>..ctor
	|
	|-RVA: 0x2A92808 Offset: 0x2A8E808 VA: 0x2A92808
	|-Dictionary.KeyCollection<long, object>..ctor
	|
	|-RVA: 0x2A92E20 Offset: 0x2A8EE20 VA: 0x2A92E20
	|-Dictionary.KeyCollection<Int64Enum, Int32Enum>..ctor
	|
	|-RVA: 0x2A93438 Offset: 0x2A8F438 VA: 0x2A93438
	|-Dictionary.KeyCollection<Int64Enum, object>..ctor
	|
	|-RVA: 0x2A93A50 Offset: 0x2A8FA50 VA: 0x2A93A50
	|-Dictionary.KeyCollection<IntPtr, object>..ctor
	|
	|-RVA: 0x2A94068 Offset: 0x2A90068 VA: 0x2A94068
	|-Dictionary.KeyCollection<object, ValueTuple<object, byte>>..ctor
	|
	|-RVA: 0x2A94674 Offset: 0x2A90674 VA: 0x2A94674
	|-Dictionary.KeyCollection<object, ValueTuple<float, object>>..ctor
	|
	|-RVA: 0x2A94C80 Offset: 0x2A90C80 VA: 0x2A94C80
	|-Dictionary.KeyCollection<object, bool>..ctor
	|
	|-RVA: 0x2A9528C Offset: 0x2A9128C VA: 0x2A9528C
	|-Dictionary.KeyCollection<object, byte>..ctor
	|
	|-RVA: 0x2A95898 Offset: 0x2A91898 VA: 0x2A95898
	|-Dictionary.KeyCollection<object, short>..ctor
	|
	|-RVA: 0x2A95EA4 Offset: 0x2A91EA4 VA: 0x2A95EA4
	|-Dictionary.KeyCollection<object, int>..ctor
	|
	|-RVA: 0x2A964B0 Offset: 0x2A924B0 VA: 0x2A964B0
	|-Dictionary.KeyCollection<object, Int32Enum>..ctor
	|
	|-RVA: 0x2A96ABC Offset: 0x2A92ABC VA: 0x2A96ABC
	|-Dictionary.KeyCollection<object, object>..ctor
	|
	|-RVA: 0x2A970C8 Offset: 0x2A930C8 VA: 0x2A970C8
	|-Dictionary.KeyCollection<object, ResourceLocator>..ctor
	|
	|-RVA: 0x2A976D4 Offset: 0x2A936D4 VA: 0x2A976D4
	|-Dictionary.KeyCollection<object, float>..ctor
	|
	|-RVA: 0x2A97CE0 Offset: 0x2A93CE0 VA: 0x2A97CE0
	|-Dictionary.KeyCollection<object, Vector3>..ctor
	|
	|-RVA: 0x2A982EC Offset: 0x2A942EC VA: 0x2A982EC
	|-Dictionary.KeyCollection<object, DeathReceptionAction.PoisonTargetData>..ctor
	|
	|-RVA: 0x2A988F8 Offset: 0x2A948F8 VA: 0x2A988F8
	|-Dictionary.KeyCollection<object, UIHouseAddressManager.Town>..ctor
	|
	|-RVA: 0x2A98F04 Offset: 0x2A94F04 VA: 0x2A98F04
	|-Dictionary.KeyCollection<ushort, byte>..ctor
	|
	|-RVA: 0x2A9951C Offset: 0x2A9551C VA: 0x2A9951C
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x2A99B44 Offset: 0x2A95B44 VA: 0x2A99B44
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2A9B524 Offset: 0x2A97524 VA: 0x2A9B524
	|-Dictionary.KeyCollection<MaterialManager.pair, object>..ctor
	|
	|-RVA: 0x2A9BB3C Offset: 0x2A97B3C VA: 0x2A9BB3C
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x2A9C1E4 Offset: 0x2A981E4 VA: 0x2A9C1E4
	|-Dictionary.KeyCollection<PartyManager.PartyData.pair, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public Dictionary.KeyCollection.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7A26C Offset: 0x2A7626C VA: 0x2A7A26C
	|-Dictionary.KeyCollection<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.GetEnumerator
	|
	|-RVA: 0x2A7A884 Offset: 0x2A76884 VA: 0x2A7A884
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.GetEnumerator
	|
	|-RVA: 0x2A7AEAC Offset: 0x2A76EAC VA: 0x2A7AEAC
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.GetEnumerator
	|
	|-RVA: 0x2A7B4D4 Offset: 0x2A774D4 VA: 0x2A7B4D4
	|-Dictionary.KeyCollection<ArchetypeUid, int>.GetEnumerator
	|
	|-RVA: 0x2A7BAEC Offset: 0x2A77AEC VA: 0x2A7BAEC
	|-Dictionary.KeyCollection<ArchetypeUid, object>.GetEnumerator
	|
	|-RVA: 0x2A7C104 Offset: 0x2A78104 VA: 0x2A7C104
	|-Dictionary.KeyCollection<byte, ValueTuple<short, int, int>>.GetEnumerator
	|
	|-RVA: 0x2A7C71C Offset: 0x2A7871C VA: 0x2A7C71C
	|-Dictionary.KeyCollection<byte, BlackKnightAvatarProperty>.GetEnumerator
	|
	|-RVA: 0x2A7CD34 Offset: 0x2A78D34 VA: 0x2A7CD34
	|-Dictionary.KeyCollection<byte, BlackKnightCristaProperty>.GetEnumerator
	|
	|-RVA: 0x2A7D34C Offset: 0x2A7934C VA: 0x2A7D34C
	|-Dictionary.KeyCollection<byte, byte>.GetEnumerator
	|
	|-RVA: 0x2A7D964 Offset: 0x2A79964 VA: 0x2A7D964
	|-Dictionary.KeyCollection<byte, CardData>.GetEnumerator
	|
	|-RVA: 0x2A7DF7C Offset: 0x2A79F7C VA: 0x2A7DF7C
	|-Dictionary.KeyCollection<byte, short>.GetEnumerator
	|
	|-RVA: 0x2A7E594 Offset: 0x2A7A594 VA: 0x2A7E594
	|-Dictionary.KeyCollection<byte, int>.GetEnumerator
	|
	|-RVA: 0x2A7EBAC Offset: 0x2A7ABAC VA: 0x2A7EBAC
	|-Dictionary.KeyCollection<byte, long>.GetEnumerator
	|
	|-RVA: 0x2A7F1C4 Offset: 0x2A7B1C4 VA: 0x2A7F1C4
	|-Dictionary.KeyCollection<byte, object>.GetEnumerator
	|
	|-RVA: 0x2A800E0 Offset: 0x2A7C0E0 VA: 0x2A800E0
	|-Dictionary.KeyCollection<byte, float>.GetEnumerator
	|
	|-RVA: 0x2A806F8 Offset: 0x2A7C6F8 VA: 0x2A806F8
	|-Dictionary.KeyCollection<byte, MasterModelDataManager.ConvertCommonMaterialData>.GetEnumerator
	|
	|-RVA: 0x2A80D10 Offset: 0x2A7CD10 VA: 0x2A80D10
	|-Dictionary.KeyCollection<ByteEnum, object>.GetEnumerator
	|
	|-RVA: 0x2A81328 Offset: 0x2A7D328 VA: 0x2A81328
	|-Dictionary.KeyCollection<char, char>.GetEnumerator
	|
	|-RVA: 0x2A81940 Offset: 0x2A7D940 VA: 0x2A81940
	|-Dictionary.KeyCollection<DefencePoint2, byte>.GetEnumerator
	|
	|-RVA: 0x2A8285C Offset: 0x2A7E85C VA: 0x2A8285C
	|-Dictionary.KeyCollection<Guid, object>.GetEnumerator
	|
	|-RVA: 0x2A82E70 Offset: 0x2A7EE70 VA: 0x2A82E70
	|-Dictionary.KeyCollection<short, byte>.GetEnumerator
	|
	|-RVA: 0x2A83488 Offset: 0x2A7F488 VA: 0x2A83488
	|-Dictionary.KeyCollection<short, short>.GetEnumerator
	|
	|-RVA: 0x2A83AA0 Offset: 0x2A7FAA0 VA: 0x2A83AA0
	|-Dictionary.KeyCollection<short, int>.GetEnumerator
	|
	|-RVA: 0x2A840B8 Offset: 0x2A800B8 VA: 0x2A840B8
	|-Dictionary.KeyCollection<short, object>.GetEnumerator
	|
	|-RVA: 0x2A846D0 Offset: 0x2A806D0 VA: 0x2A846D0
	|-Dictionary.KeyCollection<Int16Enum, bool>.GetEnumerator
	|
	|-RVA: 0x2A84CE8 Offset: 0x2A80CE8 VA: 0x2A84CE8
	|-Dictionary.KeyCollection<Int16Enum, int>.GetEnumerator
	|
	|-RVA: 0x2A85300 Offset: 0x2A81300 VA: 0x2A85300
	|-Dictionary.KeyCollection<Int16Enum, object>.GetEnumerator
	|
	|-RVA: 0x2A85918 Offset: 0x2A81918 VA: 0x2A85918
	|-Dictionary.KeyCollection<int, bool>.GetEnumerator
	|
	|-RVA: 0x2A85F30 Offset: 0x2A81F30 VA: 0x2A85F30
	|-Dictionary.KeyCollection<int, byte>.GetEnumerator
	|
	|-RVA: 0x2A86548 Offset: 0x2A82548 VA: 0x2A86548
	|-Dictionary.KeyCollection<int, Color>.GetEnumerator
	|
	|-RVA: 0x2A86B60 Offset: 0x2A82B60 VA: 0x2A86B60
	|-Dictionary.KeyCollection<int, short>.GetEnumerator
	|
	|-RVA: 0x2A87178 Offset: 0x2A83178 VA: 0x2A87178
	|-Dictionary.KeyCollection<int, int>.GetEnumerator
	|
	|-RVA: 0x2A87790 Offset: 0x2A83790 VA: 0x2A87790
	|-Dictionary.KeyCollection<int, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2A87DA8 Offset: 0x2A83DA8 VA: 0x2A87DA8
	|-Dictionary.KeyCollection<int, long>.GetEnumerator
	|
	|-RVA: 0x2A883C0 Offset: 0x2A843C0 VA: 0x2A883C0
	|-Dictionary.KeyCollection<int, MaterialSearchData>.GetEnumerator
	|
	|-RVA: 0x2A889D8 Offset: 0x2A849D8 VA: 0x2A889D8
	|-Dictionary.KeyCollection<int, object>.GetEnumerator
	|
	|-RVA: 0x2A88FF0 Offset: 0x2A84FF0 VA: 0x2A88FF0
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.GetEnumerator
	|
	|-RVA: 0x2A89608 Offset: 0x2A85608 VA: 0x2A89608
	|-Dictionary.KeyCollection<int, float>.GetEnumerator
	|
	|-RVA: 0x2A89C20 Offset: 0x2A85C20 VA: 0x2A89C20
	|-Dictionary.KeyCollection<int, Vector3>.GetEnumerator
	|
	|-RVA: 0x2A8A238 Offset: 0x2A86238 VA: 0x2A8A238
	|-Dictionary.KeyCollection<int, Vector4>.GetEnumerator
	|
	|-RVA: 0x2A8A850 Offset: 0x2A86850 VA: 0x2A8A850
	|-Dictionary.KeyCollection<int, HouseRecipeManager.RecipeData>.GetEnumerator
	|
	|-RVA: 0x2A8AE68 Offset: 0x2A86E68 VA: 0x2A8AE68
	|-Dictionary.KeyCollection<int, MasterModelDataManager.ColorListData>.GetEnumerator
	|
	|-RVA: 0x2A8B480 Offset: 0x2A87480 VA: 0x2A8B480
	|-Dictionary.KeyCollection<int, UIGuildQuestBoardManager.GuildQuestMaseter>.GetEnumerator
	|
	|-RVA: 0x2A8BA98 Offset: 0x2A87A98 VA: 0x2A8BA98
	|-Dictionary.KeyCollection<Int32Enum, ArchetypeUid>.GetEnumerator
	|
	|-RVA: 0x2A8C0B0 Offset: 0x2A880B0 VA: 0x2A8C0B0
	|-Dictionary.KeyCollection<Int32Enum, bool>.GetEnumerator
	|
	|-RVA: 0x2A8C6C8 Offset: 0x2A886C8 VA: 0x2A8C6C8
	|-Dictionary.KeyCollection<Int32Enum, byte>.GetEnumerator
	|
	|-RVA: 0x2A8CCE0 Offset: 0x2A88CE0 VA: 0x2A8CCE0
	|-Dictionary.KeyCollection<Int32Enum, Color>.GetEnumerator
	|
	|-RVA: 0x2A8D2F8 Offset: 0x2A892F8 VA: 0x2A8D2F8
	|-Dictionary.KeyCollection<Int32Enum, DateTime>.GetEnumerator
	|
	|-RVA: 0x2A8D910 Offset: 0x2A89910 VA: 0x2A8D910
	|-Dictionary.KeyCollection<Int32Enum, EnhanceProperties2>.GetEnumerator
	|
	|-RVA: 0x2A8DF28 Offset: 0x2A89F28 VA: 0x2A8DF28
	|-Dictionary.KeyCollection<Int32Enum, short>.GetEnumerator
	|
	|-RVA: 0x2A8E540 Offset: 0x2A8A540 VA: 0x2A8E540
	|-Dictionary.KeyCollection<Int32Enum, int>.GetEnumerator
	|
	|-RVA: 0x2A8EB58 Offset: 0x2A8AB58 VA: 0x2A8EB58
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2A8F170 Offset: 0x2A8B170 VA: 0x2A8F170
	|-Dictionary.KeyCollection<Int32Enum, long>.GetEnumerator
	|
	|-RVA: 0x2A8F788 Offset: 0x2A8B788 VA: 0x2A8F788
	|-Dictionary.KeyCollection<Int32Enum, Int64Enum>.GetEnumerator
	|
	|-RVA: 0x2A8FDA0 Offset: 0x2A8BDA0 VA: 0x2A8FDA0
	|-Dictionary.KeyCollection<Int32Enum, object>.GetEnumerator
	|
	|-RVA: 0x2A903B8 Offset: 0x2A8C3B8 VA: 0x2A903B8
	|-Dictionary.KeyCollection<Int32Enum, float>.GetEnumerator
	|
	|-RVA: 0x2A909D0 Offset: 0x2A8C9D0 VA: 0x2A909D0
	|-Dictionary.KeyCollection<Int32Enum, Vector3>.GetEnumerator
	|
	|-RVA: 0x2A90FE8 Offset: 0x2A8CFE8 VA: 0x2A90FE8
	|-Dictionary.KeyCollection<Int32Enum, MasterModelDataManager.ColorListData>.GetEnumerator
	|
	|-RVA: 0x2A91600 Offset: 0x2A8D600 VA: 0x2A91600
	|-Dictionary.KeyCollection<long, bool>.GetEnumerator
	|
	|-RVA: 0x2A91C18 Offset: 0x2A8DC18 VA: 0x2A91C18
	|-Dictionary.KeyCollection<long, byte>.GetEnumerator
	|
	|-RVA: 0x2A92230 Offset: 0x2A8E230 VA: 0x2A92230
	|-Dictionary.KeyCollection<long, short>.GetEnumerator
	|
	|-RVA: 0x2A92848 Offset: 0x2A8E848 VA: 0x2A92848
	|-Dictionary.KeyCollection<long, object>.GetEnumerator
	|
	|-RVA: 0x2A92E60 Offset: 0x2A8EE60 VA: 0x2A92E60
	|-Dictionary.KeyCollection<Int64Enum, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2A93478 Offset: 0x2A8F478 VA: 0x2A93478
	|-Dictionary.KeyCollection<Int64Enum, object>.GetEnumerator
	|
	|-RVA: 0x2A93A90 Offset: 0x2A8FA90 VA: 0x2A93A90
	|-Dictionary.KeyCollection<IntPtr, object>.GetEnumerator
	|
	|-RVA: 0x2A940A8 Offset: 0x2A900A8 VA: 0x2A940A8
	|-Dictionary.KeyCollection<object, ValueTuple<object, byte>>.GetEnumerator
	|
	|-RVA: 0x2A946B4 Offset: 0x2A906B4 VA: 0x2A946B4
	|-Dictionary.KeyCollection<object, ValueTuple<float, object>>.GetEnumerator
	|
	|-RVA: 0x2A94CC0 Offset: 0x2A90CC0 VA: 0x2A94CC0
	|-Dictionary.KeyCollection<object, bool>.GetEnumerator
	|
	|-RVA: 0x2A952CC Offset: 0x2A912CC VA: 0x2A952CC
	|-Dictionary.KeyCollection<object, byte>.GetEnumerator
	|
	|-RVA: 0x2A958D8 Offset: 0x2A918D8 VA: 0x2A958D8
	|-Dictionary.KeyCollection<object, short>.GetEnumerator
	|
	|-RVA: 0x2A95EE4 Offset: 0x2A91EE4 VA: 0x2A95EE4
	|-Dictionary.KeyCollection<object, int>.GetEnumerator
	|
	|-RVA: 0x2A964F0 Offset: 0x2A924F0 VA: 0x2A964F0
	|-Dictionary.KeyCollection<object, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2A96AFC Offset: 0x2A92AFC VA: 0x2A96AFC
	|-Dictionary.KeyCollection<object, object>.GetEnumerator
	|
	|-RVA: 0x2A97108 Offset: 0x2A93108 VA: 0x2A97108
	|-Dictionary.KeyCollection<object, ResourceLocator>.GetEnumerator
	|
	|-RVA: 0x2A97714 Offset: 0x2A93714 VA: 0x2A97714
	|-Dictionary.KeyCollection<object, float>.GetEnumerator
	|
	|-RVA: 0x2A97D20 Offset: 0x2A93D20 VA: 0x2A97D20
	|-Dictionary.KeyCollection<object, Vector3>.GetEnumerator
	|
	|-RVA: 0x2A9832C Offset: 0x2A9432C VA: 0x2A9832C
	|-Dictionary.KeyCollection<object, DeathReceptionAction.PoisonTargetData>.GetEnumerator
	|
	|-RVA: 0x2A98938 Offset: 0x2A94938 VA: 0x2A98938
	|-Dictionary.KeyCollection<object, UIHouseAddressManager.Town>.GetEnumerator
	|
	|-RVA: 0x2A98F44 Offset: 0x2A94F44 VA: 0x2A98F44
	|-Dictionary.KeyCollection<ushort, byte>.GetEnumerator
	|
	|-RVA: 0x2A9955C Offset: 0x2A9555C VA: 0x2A9955C
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.GetEnumerator
	|
	|-RVA: 0x2A99B84 Offset: 0x2A95B84 VA: 0x2A99B84
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	|
	|-RVA: 0x2A9B564 Offset: 0x2A97564 VA: 0x2A9B564
	|-Dictionary.KeyCollection<MaterialManager.pair, object>.GetEnumerator
	|
	|-RVA: 0x2A9BB7C Offset: 0x2A97B7C VA: 0x2A9BB7C
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.GetEnumerator
	|
	|-RVA: 0x2A9C224 Offset: 0x2A98224 VA: 0x2A9C224
	|-Dictionary.KeyCollection<PartyManager.PartyData.pair, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TKey[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7A290 Offset: 0x2A76290 VA: 0x2A7A290
	|-Dictionary.KeyCollection<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.CopyTo
	|
	|-RVA: 0x2A7A8A8 Offset: 0x2A768A8 VA: 0x2A7A8A8
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.CopyTo
	|
	|-RVA: 0x2A7AED0 Offset: 0x2A76ED0 VA: 0x2A7AED0
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.CopyTo
	|
	|-RVA: 0x2A7B4F8 Offset: 0x2A774F8 VA: 0x2A7B4F8
	|-Dictionary.KeyCollection<ArchetypeUid, int>.CopyTo
	|
	|-RVA: 0x2A7BB10 Offset: 0x2A77B10 VA: 0x2A7BB10
	|-Dictionary.KeyCollection<ArchetypeUid, object>.CopyTo
	|
	|-RVA: 0x2A7C128 Offset: 0x2A78128 VA: 0x2A7C128
	|-Dictionary.KeyCollection<byte, ValueTuple<short, int, int>>.CopyTo
	|
	|-RVA: 0x2A7C740 Offset: 0x2A78740 VA: 0x2A7C740
	|-Dictionary.KeyCollection<byte, BlackKnightAvatarProperty>.CopyTo
	|
	|-RVA: 0x2A7CD58 Offset: 0x2A78D58 VA: 0x2A7CD58
	|-Dictionary.KeyCollection<byte, BlackKnightCristaProperty>.CopyTo
	|
	|-RVA: 0x2A7D370 Offset: 0x2A79370 VA: 0x2A7D370
	|-Dictionary.KeyCollection<byte, byte>.CopyTo
	|
	|-RVA: 0x2A7D988 Offset: 0x2A79988 VA: 0x2A7D988
	|-Dictionary.KeyCollection<byte, CardData>.CopyTo
	|
	|-RVA: 0x2A7DFA0 Offset: 0x2A79FA0 VA: 0x2A7DFA0
	|-Dictionary.KeyCollection<byte, short>.CopyTo
	|
	|-RVA: 0x2A7E5B8 Offset: 0x2A7A5B8 VA: 0x2A7E5B8
	|-Dictionary.KeyCollection<byte, int>.CopyTo
	|
	|-RVA: 0x2A7EBD0 Offset: 0x2A7ABD0 VA: 0x2A7EBD0
	|-Dictionary.KeyCollection<byte, long>.CopyTo
	|
	|-RVA: 0x2A7F1E8 Offset: 0x2A7B1E8 VA: 0x2A7F1E8
	|-Dictionary.KeyCollection<byte, object>.CopyTo
	|
	|-RVA: 0x2A80104 Offset: 0x2A7C104 VA: 0x2A80104
	|-Dictionary.KeyCollection<byte, float>.CopyTo
	|
	|-RVA: 0x2A8071C Offset: 0x2A7C71C VA: 0x2A8071C
	|-Dictionary.KeyCollection<byte, MasterModelDataManager.ConvertCommonMaterialData>.CopyTo
	|
	|-RVA: 0x2A80D34 Offset: 0x2A7CD34 VA: 0x2A80D34
	|-Dictionary.KeyCollection<ByteEnum, object>.CopyTo
	|
	|-RVA: 0x2A8134C Offset: 0x2A7D34C VA: 0x2A8134C
	|-Dictionary.KeyCollection<char, char>.CopyTo
	|
	|-RVA: 0x2A81964 Offset: 0x2A7D964 VA: 0x2A81964
	|-Dictionary.KeyCollection<DefencePoint2, byte>.CopyTo
	|
	|-RVA: 0x2A82880 Offset: 0x2A7E880 VA: 0x2A82880
	|-Dictionary.KeyCollection<Guid, object>.CopyTo
	|
	|-RVA: 0x2A82E94 Offset: 0x2A7EE94 VA: 0x2A82E94
	|-Dictionary.KeyCollection<short, byte>.CopyTo
	|
	|-RVA: 0x2A834AC Offset: 0x2A7F4AC VA: 0x2A834AC
	|-Dictionary.KeyCollection<short, short>.CopyTo
	|
	|-RVA: 0x2A83AC4 Offset: 0x2A7FAC4 VA: 0x2A83AC4
	|-Dictionary.KeyCollection<short, int>.CopyTo
	|
	|-RVA: 0x2A840DC Offset: 0x2A800DC VA: 0x2A840DC
	|-Dictionary.KeyCollection<short, object>.CopyTo
	|
	|-RVA: 0x2A846F4 Offset: 0x2A806F4 VA: 0x2A846F4
	|-Dictionary.KeyCollection<Int16Enum, bool>.CopyTo
	|
	|-RVA: 0x2A84D0C Offset: 0x2A80D0C VA: 0x2A84D0C
	|-Dictionary.KeyCollection<Int16Enum, int>.CopyTo
	|
	|-RVA: 0x2A85324 Offset: 0x2A81324 VA: 0x2A85324
	|-Dictionary.KeyCollection<Int16Enum, object>.CopyTo
	|
	|-RVA: 0x2A8593C Offset: 0x2A8193C VA: 0x2A8593C
	|-Dictionary.KeyCollection<int, bool>.CopyTo
	|
	|-RVA: 0x2A85F54 Offset: 0x2A81F54 VA: 0x2A85F54
	|-Dictionary.KeyCollection<int, byte>.CopyTo
	|
	|-RVA: 0x2A8656C Offset: 0x2A8256C VA: 0x2A8656C
	|-Dictionary.KeyCollection<int, Color>.CopyTo
	|
	|-RVA: 0x2A86B84 Offset: 0x2A82B84 VA: 0x2A86B84
	|-Dictionary.KeyCollection<int, short>.CopyTo
	|
	|-RVA: 0x2A8719C Offset: 0x2A8319C VA: 0x2A8719C
	|-Dictionary.KeyCollection<int, int>.CopyTo
	|
	|-RVA: 0x2A877B4 Offset: 0x2A837B4 VA: 0x2A877B4
	|-Dictionary.KeyCollection<int, Int32Enum>.CopyTo
	|
	|-RVA: 0x2A87DCC Offset: 0x2A83DCC VA: 0x2A87DCC
	|-Dictionary.KeyCollection<int, long>.CopyTo
	|
	|-RVA: 0x2A883E4 Offset: 0x2A843E4 VA: 0x2A883E4
	|-Dictionary.KeyCollection<int, MaterialSearchData>.CopyTo
	|
	|-RVA: 0x2A889FC Offset: 0x2A849FC VA: 0x2A889FC
	|-Dictionary.KeyCollection<int, object>.CopyTo
	|
	|-RVA: 0x2A89014 Offset: 0x2A85014 VA: 0x2A89014
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.CopyTo
	|
	|-RVA: 0x2A8962C Offset: 0x2A8562C VA: 0x2A8962C
	|-Dictionary.KeyCollection<int, float>.CopyTo
	|
	|-RVA: 0x2A89C44 Offset: 0x2A85C44 VA: 0x2A89C44
	|-Dictionary.KeyCollection<int, Vector3>.CopyTo
	|
	|-RVA: 0x2A8A25C Offset: 0x2A8625C VA: 0x2A8A25C
	|-Dictionary.KeyCollection<int, Vector4>.CopyTo
	|
	|-RVA: 0x2A8A874 Offset: 0x2A86874 VA: 0x2A8A874
	|-Dictionary.KeyCollection<int, HouseRecipeManager.RecipeData>.CopyTo
	|
	|-RVA: 0x2A8AE8C Offset: 0x2A86E8C VA: 0x2A8AE8C
	|-Dictionary.KeyCollection<int, MasterModelDataManager.ColorListData>.CopyTo
	|
	|-RVA: 0x2A8B4A4 Offset: 0x2A874A4 VA: 0x2A8B4A4
	|-Dictionary.KeyCollection<int, UIGuildQuestBoardManager.GuildQuestMaseter>.CopyTo
	|
	|-RVA: 0x2A8BABC Offset: 0x2A87ABC VA: 0x2A8BABC
	|-Dictionary.KeyCollection<Int32Enum, ArchetypeUid>.CopyTo
	|
	|-RVA: 0x2A8C0D4 Offset: 0x2A880D4 VA: 0x2A8C0D4
	|-Dictionary.KeyCollection<Int32Enum, bool>.CopyTo
	|
	|-RVA: 0x2A8C6EC Offset: 0x2A886EC VA: 0x2A8C6EC
	|-Dictionary.KeyCollection<Int32Enum, byte>.CopyTo
	|
	|-RVA: 0x2A8CD04 Offset: 0x2A88D04 VA: 0x2A8CD04
	|-Dictionary.KeyCollection<Int32Enum, Color>.CopyTo
	|
	|-RVA: 0x2A8D31C Offset: 0x2A8931C VA: 0x2A8D31C
	|-Dictionary.KeyCollection<Int32Enum, DateTime>.CopyTo
	|
	|-RVA: 0x2A8D934 Offset: 0x2A89934 VA: 0x2A8D934
	|-Dictionary.KeyCollection<Int32Enum, EnhanceProperties2>.CopyTo
	|
	|-RVA: 0x2A8DF4C Offset: 0x2A89F4C VA: 0x2A8DF4C
	|-Dictionary.KeyCollection<Int32Enum, short>.CopyTo
	|
	|-RVA: 0x2A8E564 Offset: 0x2A8A564 VA: 0x2A8E564
	|-Dictionary.KeyCollection<Int32Enum, int>.CopyTo
	|
	|-RVA: 0x2A8EB7C Offset: 0x2A8AB7C VA: 0x2A8EB7C
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.CopyTo
	|
	|-RVA: 0x2A8F194 Offset: 0x2A8B194 VA: 0x2A8F194
	|-Dictionary.KeyCollection<Int32Enum, long>.CopyTo
	|
	|-RVA: 0x2A8F7AC Offset: 0x2A8B7AC VA: 0x2A8F7AC
	|-Dictionary.KeyCollection<Int32Enum, Int64Enum>.CopyTo
	|
	|-RVA: 0x2A8FDC4 Offset: 0x2A8BDC4 VA: 0x2A8FDC4
	|-Dictionary.KeyCollection<Int32Enum, object>.CopyTo
	|
	|-RVA: 0x2A903DC Offset: 0x2A8C3DC VA: 0x2A903DC
	|-Dictionary.KeyCollection<Int32Enum, float>.CopyTo
	|
	|-RVA: 0x2A909F4 Offset: 0x2A8C9F4 VA: 0x2A909F4
	|-Dictionary.KeyCollection<Int32Enum, Vector3>.CopyTo
	|
	|-RVA: 0x2A9100C Offset: 0x2A8D00C VA: 0x2A9100C
	|-Dictionary.KeyCollection<Int32Enum, MasterModelDataManager.ColorListData>.CopyTo
	|
	|-RVA: 0x2A91624 Offset: 0x2A8D624 VA: 0x2A91624
	|-Dictionary.KeyCollection<long, bool>.CopyTo
	|
	|-RVA: 0x2A91C3C Offset: 0x2A8DC3C VA: 0x2A91C3C
	|-Dictionary.KeyCollection<long, byte>.CopyTo
	|
	|-RVA: 0x2A92254 Offset: 0x2A8E254 VA: 0x2A92254
	|-Dictionary.KeyCollection<long, short>.CopyTo
	|
	|-RVA: 0x2A9286C Offset: 0x2A8E86C VA: 0x2A9286C
	|-Dictionary.KeyCollection<long, object>.CopyTo
	|
	|-RVA: 0x2A92E84 Offset: 0x2A8EE84 VA: 0x2A92E84
	|-Dictionary.KeyCollection<Int64Enum, Int32Enum>.CopyTo
	|
	|-RVA: 0x2A9349C Offset: 0x2A8F49C VA: 0x2A9349C
	|-Dictionary.KeyCollection<Int64Enum, object>.CopyTo
	|
	|-RVA: 0x2A93AB4 Offset: 0x2A8FAB4 VA: 0x2A93AB4
	|-Dictionary.KeyCollection<IntPtr, object>.CopyTo
	|
	|-RVA: 0x2A940CC Offset: 0x2A900CC VA: 0x2A940CC
	|-Dictionary.KeyCollection<object, ValueTuple<object, byte>>.CopyTo
	|
	|-RVA: 0x2A946D8 Offset: 0x2A906D8 VA: 0x2A946D8
	|-Dictionary.KeyCollection<object, ValueTuple<float, object>>.CopyTo
	|
	|-RVA: 0x2A94CE4 Offset: 0x2A90CE4 VA: 0x2A94CE4
	|-Dictionary.KeyCollection<object, bool>.CopyTo
	|
	|-RVA: 0x2A952F0 Offset: 0x2A912F0 VA: 0x2A952F0
	|-Dictionary.KeyCollection<object, byte>.CopyTo
	|
	|-RVA: 0x2A958FC Offset: 0x2A918FC VA: 0x2A958FC
	|-Dictionary.KeyCollection<object, short>.CopyTo
	|
	|-RVA: 0x2A95F08 Offset: 0x2A91F08 VA: 0x2A95F08
	|-Dictionary.KeyCollection<object, int>.CopyTo
	|
	|-RVA: 0x2A96514 Offset: 0x2A92514 VA: 0x2A96514
	|-Dictionary.KeyCollection<object, Int32Enum>.CopyTo
	|
	|-RVA: 0x2A96B20 Offset: 0x2A92B20 VA: 0x2A96B20
	|-Dictionary.KeyCollection<object, object>.CopyTo
	|
	|-RVA: 0x2A9712C Offset: 0x2A9312C VA: 0x2A9712C
	|-Dictionary.KeyCollection<object, ResourceLocator>.CopyTo
	|
	|-RVA: 0x2A97738 Offset: 0x2A93738 VA: 0x2A97738
	|-Dictionary.KeyCollection<object, float>.CopyTo
	|
	|-RVA: 0x2A97D44 Offset: 0x2A93D44 VA: 0x2A97D44
	|-Dictionary.KeyCollection<object, Vector3>.CopyTo
	|
	|-RVA: 0x2A98350 Offset: 0x2A94350 VA: 0x2A98350
	|-Dictionary.KeyCollection<object, DeathReceptionAction.PoisonTargetData>.CopyTo
	|
	|-RVA: 0x2A9895C Offset: 0x2A9495C VA: 0x2A9895C
	|-Dictionary.KeyCollection<object, UIHouseAddressManager.Town>.CopyTo
	|
	|-RVA: 0x2A98F68 Offset: 0x2A94F68 VA: 0x2A98F68
	|-Dictionary.KeyCollection<ushort, byte>.CopyTo
	|
	|-RVA: 0x2A99580 Offset: 0x2A95580 VA: 0x2A99580
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.CopyTo
	|
	|-RVA: 0x2A99C34 Offset: 0x2A95C34 VA: 0x2A99C34
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	|
	|-RVA: 0x2A9B588 Offset: 0x2A97588 VA: 0x2A9B588
	|-Dictionary.KeyCollection<MaterialManager.pair, object>.CopyTo
	|
	|-RVA: 0x2A9BBA4 Offset: 0x2A97BA4 VA: 0x2A9BBA4
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.CopyTo
	|
	|-RVA: 0x2A9C248 Offset: 0x2A98248 VA: 0x2A9C248
	|-Dictionary.KeyCollection<PartyManager.PartyData.pair, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7A38C Offset: 0x2A7638C VA: 0x2A7A38C
	|-Dictionary.KeyCollection<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.get_Count
	|
	|-RVA: 0x2A7A9B8 Offset: 0x2A769B8 VA: 0x2A7A9B8
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.get_Count
	|
	|-RVA: 0x2A7AFE0 Offset: 0x2A76FE0 VA: 0x2A7AFE0
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.get_Count
	|
	|-RVA: 0x2A7B5F4 Offset: 0x2A775F4 VA: 0x2A7B5F4
	|-Dictionary.KeyCollection<ArchetypeUid, int>.get_Count
	|
	|-RVA: 0x2A7BC0C Offset: 0x2A77C0C VA: 0x2A7BC0C
	|-Dictionary.KeyCollection<ArchetypeUid, object>.get_Count
	|
	|-RVA: 0x2A7C224 Offset: 0x2A78224 VA: 0x2A7C224
	|-Dictionary.KeyCollection<byte, ValueTuple<short, int, int>>.get_Count
	|
	|-RVA: 0x2A7C83C Offset: 0x2A7883C VA: 0x2A7C83C
	|-Dictionary.KeyCollection<byte, BlackKnightAvatarProperty>.get_Count
	|
	|-RVA: 0x2A7CE54 Offset: 0x2A78E54 VA: 0x2A7CE54
	|-Dictionary.KeyCollection<byte, BlackKnightCristaProperty>.get_Count
	|
	|-RVA: 0x2A7D46C Offset: 0x2A7946C VA: 0x2A7D46C
	|-Dictionary.KeyCollection<byte, byte>.get_Count
	|
	|-RVA: 0x2A7DA84 Offset: 0x2A79A84 VA: 0x2A7DA84
	|-Dictionary.KeyCollection<byte, CardData>.get_Count
	|
	|-RVA: 0x2A7E09C Offset: 0x2A7A09C VA: 0x2A7E09C
	|-Dictionary.KeyCollection<byte, short>.get_Count
	|
	|-RVA: 0x2A7E6B4 Offset: 0x2A7A6B4 VA: 0x2A7E6B4
	|-Dictionary.KeyCollection<byte, int>.get_Count
	|
	|-RVA: 0x2A7ECCC Offset: 0x2A7ACCC VA: 0x2A7ECCC
	|-Dictionary.KeyCollection<byte, long>.get_Count
	|
	|-RVA: 0x2A7F2E4 Offset: 0x2A7B2E4 VA: 0x2A7F2E4
	|-Dictionary.KeyCollection<byte, object>.get_Count
	|
	|-RVA: 0x2A80200 Offset: 0x2A7C200 VA: 0x2A80200
	|-Dictionary.KeyCollection<byte, float>.get_Count
	|
	|-RVA: 0x2A80818 Offset: 0x2A7C818 VA: 0x2A80818
	|-Dictionary.KeyCollection<byte, MasterModelDataManager.ConvertCommonMaterialData>.get_Count
	|
	|-RVA: 0x2A80E30 Offset: 0x2A7CE30 VA: 0x2A80E30
	|-Dictionary.KeyCollection<ByteEnum, object>.get_Count
	|
	|-RVA: 0x2A81448 Offset: 0x2A7D448 VA: 0x2A81448
	|-Dictionary.KeyCollection<char, char>.get_Count
	|
	|-RVA: 0x2A81A60 Offset: 0x2A7DA60 VA: 0x2A81A60
	|-Dictionary.KeyCollection<DefencePoint2, byte>.get_Count
	|
	|-RVA: 0x2A8297C Offset: 0x2A7E97C VA: 0x2A8297C
	|-Dictionary.KeyCollection<Guid, object>.get_Count
	|
	|-RVA: 0x2A82F90 Offset: 0x2A7EF90 VA: 0x2A82F90
	|-Dictionary.KeyCollection<short, byte>.get_Count
	|
	|-RVA: 0x2A835A8 Offset: 0x2A7F5A8 VA: 0x2A835A8
	|-Dictionary.KeyCollection<short, short>.get_Count
	|
	|-RVA: 0x2A83BC0 Offset: 0x2A7FBC0 VA: 0x2A83BC0
	|-Dictionary.KeyCollection<short, int>.get_Count
	|
	|-RVA: 0x2A841D8 Offset: 0x2A801D8 VA: 0x2A841D8
	|-Dictionary.KeyCollection<short, object>.get_Count
	|
	|-RVA: 0x2A847F0 Offset: 0x2A807F0 VA: 0x2A847F0
	|-Dictionary.KeyCollection<Int16Enum, bool>.get_Count
	|
	|-RVA: 0x2A84E08 Offset: 0x2A80E08 VA: 0x2A84E08
	|-Dictionary.KeyCollection<Int16Enum, int>.get_Count
	|
	|-RVA: 0x2A85420 Offset: 0x2A81420 VA: 0x2A85420
	|-Dictionary.KeyCollection<Int16Enum, object>.get_Count
	|
	|-RVA: 0x2A85A38 Offset: 0x2A81A38 VA: 0x2A85A38
	|-Dictionary.KeyCollection<int, bool>.get_Count
	|
	|-RVA: 0x2A86050 Offset: 0x2A82050 VA: 0x2A86050
	|-Dictionary.KeyCollection<int, byte>.get_Count
	|
	|-RVA: 0x2A86668 Offset: 0x2A82668 VA: 0x2A86668
	|-Dictionary.KeyCollection<int, Color>.get_Count
	|
	|-RVA: 0x2A86C80 Offset: 0x2A82C80 VA: 0x2A86C80
	|-Dictionary.KeyCollection<int, short>.get_Count
	|
	|-RVA: 0x2A87298 Offset: 0x2A83298 VA: 0x2A87298
	|-Dictionary.KeyCollection<int, int>.get_Count
	|
	|-RVA: 0x2A878B0 Offset: 0x2A838B0 VA: 0x2A878B0
	|-Dictionary.KeyCollection<int, Int32Enum>.get_Count
	|
	|-RVA: 0x2A87EC8 Offset: 0x2A83EC8 VA: 0x2A87EC8
	|-Dictionary.KeyCollection<int, long>.get_Count
	|
	|-RVA: 0x2A884E0 Offset: 0x2A844E0 VA: 0x2A884E0
	|-Dictionary.KeyCollection<int, MaterialSearchData>.get_Count
	|
	|-RVA: 0x2A88AF8 Offset: 0x2A84AF8 VA: 0x2A88AF8
	|-Dictionary.KeyCollection<int, object>.get_Count
	|
	|-RVA: 0x2A89110 Offset: 0x2A85110 VA: 0x2A89110
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.get_Count
	|
	|-RVA: 0x2A89728 Offset: 0x2A85728 VA: 0x2A89728
	|-Dictionary.KeyCollection<int, float>.get_Count
	|
	|-RVA: 0x2A89D40 Offset: 0x2A85D40 VA: 0x2A89D40
	|-Dictionary.KeyCollection<int, Vector3>.get_Count
	|
	|-RVA: 0x2A8A358 Offset: 0x2A86358 VA: 0x2A8A358
	|-Dictionary.KeyCollection<int, Vector4>.get_Count
	|
	|-RVA: 0x2A8A970 Offset: 0x2A86970 VA: 0x2A8A970
	|-Dictionary.KeyCollection<int, HouseRecipeManager.RecipeData>.get_Count
	|
	|-RVA: 0x2A8AF88 Offset: 0x2A86F88 VA: 0x2A8AF88
	|-Dictionary.KeyCollection<int, MasterModelDataManager.ColorListData>.get_Count
	|
	|-RVA: 0x2A8B5A0 Offset: 0x2A875A0 VA: 0x2A8B5A0
	|-Dictionary.KeyCollection<int, UIGuildQuestBoardManager.GuildQuestMaseter>.get_Count
	|
	|-RVA: 0x2A8BBB8 Offset: 0x2A87BB8 VA: 0x2A8BBB8
	|-Dictionary.KeyCollection<Int32Enum, ArchetypeUid>.get_Count
	|
	|-RVA: 0x2A8C1D0 Offset: 0x2A881D0 VA: 0x2A8C1D0
	|-Dictionary.KeyCollection<Int32Enum, bool>.get_Count
	|
	|-RVA: 0x2A8C7E8 Offset: 0x2A887E8 VA: 0x2A8C7E8
	|-Dictionary.KeyCollection<Int32Enum, byte>.get_Count
	|
	|-RVA: 0x2A8CE00 Offset: 0x2A88E00 VA: 0x2A8CE00
	|-Dictionary.KeyCollection<Int32Enum, Color>.get_Count
	|
	|-RVA: 0x2A8D418 Offset: 0x2A89418 VA: 0x2A8D418
	|-Dictionary.KeyCollection<Int32Enum, DateTime>.get_Count
	|
	|-RVA: 0x2A8DA30 Offset: 0x2A89A30 VA: 0x2A8DA30
	|-Dictionary.KeyCollection<Int32Enum, EnhanceProperties2>.get_Count
	|
	|-RVA: 0x2A8E048 Offset: 0x2A8A048 VA: 0x2A8E048
	|-Dictionary.KeyCollection<Int32Enum, short>.get_Count
	|
	|-RVA: 0x2A8E660 Offset: 0x2A8A660 VA: 0x2A8E660
	|-Dictionary.KeyCollection<Int32Enum, int>.get_Count
	|
	|-RVA: 0x2A8EC78 Offset: 0x2A8AC78 VA: 0x2A8EC78
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.get_Count
	|
	|-RVA: 0x2A8F290 Offset: 0x2A8B290 VA: 0x2A8F290
	|-Dictionary.KeyCollection<Int32Enum, long>.get_Count
	|
	|-RVA: 0x2A8F8A8 Offset: 0x2A8B8A8 VA: 0x2A8F8A8
	|-Dictionary.KeyCollection<Int32Enum, Int64Enum>.get_Count
	|
	|-RVA: 0x2A8FEC0 Offset: 0x2A8BEC0 VA: 0x2A8FEC0
	|-Dictionary.KeyCollection<Int32Enum, object>.get_Count
	|
	|-RVA: 0x2A904D8 Offset: 0x2A8C4D8 VA: 0x2A904D8
	|-Dictionary.KeyCollection<Int32Enum, float>.get_Count
	|
	|-RVA: 0x2A90AF0 Offset: 0x2A8CAF0 VA: 0x2A90AF0
	|-Dictionary.KeyCollection<Int32Enum, Vector3>.get_Count
	|
	|-RVA: 0x2A91108 Offset: 0x2A8D108 VA: 0x2A91108
	|-Dictionary.KeyCollection<Int32Enum, MasterModelDataManager.ColorListData>.get_Count
	|
	|-RVA: 0x2A91720 Offset: 0x2A8D720 VA: 0x2A91720
	|-Dictionary.KeyCollection<long, bool>.get_Count
	|
	|-RVA: 0x2A91D38 Offset: 0x2A8DD38 VA: 0x2A91D38
	|-Dictionary.KeyCollection<long, byte>.get_Count
	|
	|-RVA: 0x2A92350 Offset: 0x2A8E350 VA: 0x2A92350
	|-Dictionary.KeyCollection<long, short>.get_Count
	|
	|-RVA: 0x2A92968 Offset: 0x2A8E968 VA: 0x2A92968
	|-Dictionary.KeyCollection<long, object>.get_Count
	|
	|-RVA: 0x2A92F80 Offset: 0x2A8EF80 VA: 0x2A92F80
	|-Dictionary.KeyCollection<Int64Enum, Int32Enum>.get_Count
	|
	|-RVA: 0x2A93598 Offset: 0x2A8F598 VA: 0x2A93598
	|-Dictionary.KeyCollection<Int64Enum, object>.get_Count
	|
	|-RVA: 0x2A93BB0 Offset: 0x2A8FBB0 VA: 0x2A93BB0
	|-Dictionary.KeyCollection<IntPtr, object>.get_Count
	|
	|-RVA: 0x2A941D8 Offset: 0x2A901D8 VA: 0x2A941D8
	|-Dictionary.KeyCollection<object, ValueTuple<object, byte>>.get_Count
	|
	|-RVA: 0x2A947E4 Offset: 0x2A907E4 VA: 0x2A947E4
	|-Dictionary.KeyCollection<object, ValueTuple<float, object>>.get_Count
	|
	|-RVA: 0x2A94DF0 Offset: 0x2A90DF0 VA: 0x2A94DF0
	|-Dictionary.KeyCollection<object, bool>.get_Count
	|
	|-RVA: 0x2A953FC Offset: 0x2A913FC VA: 0x2A953FC
	|-Dictionary.KeyCollection<object, byte>.get_Count
	|
	|-RVA: 0x2A95A08 Offset: 0x2A91A08 VA: 0x2A95A08
	|-Dictionary.KeyCollection<object, short>.get_Count
	|
	|-RVA: 0x2A96014 Offset: 0x2A92014 VA: 0x2A96014
	|-Dictionary.KeyCollection<object, int>.get_Count
	|
	|-RVA: 0x2A96620 Offset: 0x2A92620 VA: 0x2A96620
	|-Dictionary.KeyCollection<object, Int32Enum>.get_Count
	|
	|-RVA: 0x2A96C2C Offset: 0x2A92C2C VA: 0x2A96C2C
	|-Dictionary.KeyCollection<object, object>.get_Count
	|
	|-RVA: 0x2A97238 Offset: 0x2A93238 VA: 0x2A97238
	|-Dictionary.KeyCollection<object, ResourceLocator>.get_Count
	|
	|-RVA: 0x2A97844 Offset: 0x2A93844 VA: 0x2A97844
	|-Dictionary.KeyCollection<object, float>.get_Count
	|
	|-RVA: 0x2A97E50 Offset: 0x2A93E50 VA: 0x2A97E50
	|-Dictionary.KeyCollection<object, Vector3>.get_Count
	|
	|-RVA: 0x2A9845C Offset: 0x2A9445C VA: 0x2A9845C
	|-Dictionary.KeyCollection<object, DeathReceptionAction.PoisonTargetData>.get_Count
	|
	|-RVA: 0x2A98A68 Offset: 0x2A94A68 VA: 0x2A98A68
	|-Dictionary.KeyCollection<object, UIHouseAddressManager.Town>.get_Count
	|
	|-RVA: 0x2A99064 Offset: 0x2A95064 VA: 0x2A99064
	|-Dictionary.KeyCollection<ushort, byte>.get_Count
	|
	|-RVA: 0x2A99690 Offset: 0x2A95690 VA: 0x2A99690
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.get_Count
	|
	|-RVA: 0x2A99E5C Offset: 0x2A95E5C VA: 0x2A99E5C
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	|
	|-RVA: 0x2A9B684 Offset: 0x2A97684 VA: 0x2A9B684
	|-Dictionary.KeyCollection<MaterialManager.pair, object>.get_Count
	|
	|-RVA: 0x2A9BCDC Offset: 0x2A97CDC VA: 0x2A9BCDC
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.get_Count
	|
	|-RVA: 0x2A9C344 Offset: 0x2A98344 VA: 0x2A9C344
	|-Dictionary.KeyCollection<PartyManager.PartyData.pair, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7A3B0 Offset: 0x2A763B0 VA: 0x2A7A3B0
	|-Dictionary.KeyCollection<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A7A9DC Offset: 0x2A769DC VA: 0x2A7A9DC
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A7B004 Offset: 0x2A77004 VA: 0x2A7B004
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A7B618 Offset: 0x2A77618 VA: 0x2A7B618
	|-Dictionary.KeyCollection<ArchetypeUid, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A7BC30 Offset: 0x2A77C30 VA: 0x2A7BC30
	|-Dictionary.KeyCollection<ArchetypeUid, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A7C248 Offset: 0x2A78248 VA: 0x2A7C248
	|-Dictionary.KeyCollection<byte, ValueTuple<short, int, int>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A7C860 Offset: 0x2A78860 VA: 0x2A7C860
	|-Dictionary.KeyCollection<byte, BlackKnightAvatarProperty>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A7CE78 Offset: 0x2A78E78 VA: 0x2A7CE78
	|-Dictionary.KeyCollection<byte, BlackKnightCristaProperty>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A7D490 Offset: 0x2A79490 VA: 0x2A7D490
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A7DAA8 Offset: 0x2A79AA8 VA: 0x2A7DAA8
	|-Dictionary.KeyCollection<byte, CardData>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A7E0C0 Offset: 0x2A7A0C0 VA: 0x2A7E0C0
	|-Dictionary.KeyCollection<byte, short>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A7E6D8 Offset: 0x2A7A6D8 VA: 0x2A7E6D8
	|-Dictionary.KeyCollection<byte, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A7ECF0 Offset: 0x2A7ACF0 VA: 0x2A7ECF0
	|-Dictionary.KeyCollection<byte, long>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A7F308 Offset: 0x2A7B308 VA: 0x2A7F308
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A80224 Offset: 0x2A7C224 VA: 0x2A80224
	|-Dictionary.KeyCollection<byte, float>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8083C Offset: 0x2A7C83C VA: 0x2A8083C
	|-Dictionary.KeyCollection<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A80E54 Offset: 0x2A7CE54 VA: 0x2A80E54
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8146C Offset: 0x2A7D46C VA: 0x2A8146C
	|-Dictionary.KeyCollection<char, char>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A81A84 Offset: 0x2A7DA84 VA: 0x2A81A84
	|-Dictionary.KeyCollection<DefencePoint2, byte>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A829A0 Offset: 0x2A7E9A0 VA: 0x2A829A0
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A82FB4 Offset: 0x2A7EFB4 VA: 0x2A82FB4
	|-Dictionary.KeyCollection<short, byte>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A835CC Offset: 0x2A7F5CC VA: 0x2A835CC
	|-Dictionary.KeyCollection<short, short>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A83BE4 Offset: 0x2A7FBE4 VA: 0x2A83BE4
	|-Dictionary.KeyCollection<short, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A841FC Offset: 0x2A801FC VA: 0x2A841FC
	|-Dictionary.KeyCollection<short, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A84814 Offset: 0x2A80814 VA: 0x2A84814
	|-Dictionary.KeyCollection<Int16Enum, bool>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A84E2C Offset: 0x2A80E2C VA: 0x2A84E2C
	|-Dictionary.KeyCollection<Int16Enum, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A85444 Offset: 0x2A81444 VA: 0x2A85444
	|-Dictionary.KeyCollection<Int16Enum, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A85A5C Offset: 0x2A81A5C VA: 0x2A85A5C
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A86074 Offset: 0x2A82074 VA: 0x2A86074
	|-Dictionary.KeyCollection<int, byte>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8668C Offset: 0x2A8268C VA: 0x2A8668C
	|-Dictionary.KeyCollection<int, Color>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A86CA4 Offset: 0x2A82CA4 VA: 0x2A86CA4
	|-Dictionary.KeyCollection<int, short>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A872BC Offset: 0x2A832BC VA: 0x2A872BC
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A878D4 Offset: 0x2A838D4 VA: 0x2A878D4
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A87EEC Offset: 0x2A83EEC VA: 0x2A87EEC
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A88504 Offset: 0x2A84504 VA: 0x2A88504
	|-Dictionary.KeyCollection<int, MaterialSearchData>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A88B1C Offset: 0x2A84B1C VA: 0x2A88B1C
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A89134 Offset: 0x2A85134 VA: 0x2A89134
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8974C Offset: 0x2A8574C VA: 0x2A8974C
	|-Dictionary.KeyCollection<int, float>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A89D64 Offset: 0x2A85D64 VA: 0x2A89D64
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8A37C Offset: 0x2A8637C VA: 0x2A8A37C
	|-Dictionary.KeyCollection<int, Vector4>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8A994 Offset: 0x2A86994 VA: 0x2A8A994
	|-Dictionary.KeyCollection<int, HouseRecipeManager.RecipeData>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8AFAC Offset: 0x2A86FAC VA: 0x2A8AFAC
	|-Dictionary.KeyCollection<int, MasterModelDataManager.ColorListData>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8B5C4 Offset: 0x2A875C4 VA: 0x2A8B5C4
	|-Dictionary.KeyCollection<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8BBDC Offset: 0x2A87BDC VA: 0x2A8BBDC
	|-Dictionary.KeyCollection<Int32Enum, ArchetypeUid>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8C1F4 Offset: 0x2A881F4 VA: 0x2A8C1F4
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8C80C Offset: 0x2A8880C VA: 0x2A8C80C
	|-Dictionary.KeyCollection<Int32Enum, byte>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8CE24 Offset: 0x2A88E24 VA: 0x2A8CE24
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8D43C Offset: 0x2A8943C VA: 0x2A8D43C
	|-Dictionary.KeyCollection<Int32Enum, DateTime>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8DA54 Offset: 0x2A89A54 VA: 0x2A8DA54
	|-Dictionary.KeyCollection<Int32Enum, EnhanceProperties2>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8E06C Offset: 0x2A8A06C VA: 0x2A8E06C
	|-Dictionary.KeyCollection<Int32Enum, short>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8E684 Offset: 0x2A8A684 VA: 0x2A8E684
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8EC9C Offset: 0x2A8AC9C VA: 0x2A8EC9C
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8F2B4 Offset: 0x2A8B2B4 VA: 0x2A8F2B4
	|-Dictionary.KeyCollection<Int32Enum, long>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8F8CC Offset: 0x2A8B8CC VA: 0x2A8F8CC
	|-Dictionary.KeyCollection<Int32Enum, Int64Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8FEE4 Offset: 0x2A8BEE4 VA: 0x2A8FEE4
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A904FC Offset: 0x2A8C4FC VA: 0x2A904FC
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A90B14 Offset: 0x2A8CB14 VA: 0x2A90B14
	|-Dictionary.KeyCollection<Int32Enum, Vector3>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A9112C Offset: 0x2A8D12C VA: 0x2A9112C
	|-Dictionary.KeyCollection<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A91744 Offset: 0x2A8D744 VA: 0x2A91744
	|-Dictionary.KeyCollection<long, bool>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A91D5C Offset: 0x2A8DD5C VA: 0x2A91D5C
	|-Dictionary.KeyCollection<long, byte>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A92374 Offset: 0x2A8E374 VA: 0x2A92374
	|-Dictionary.KeyCollection<long, short>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A9298C Offset: 0x2A8E98C VA: 0x2A9298C
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A92FA4 Offset: 0x2A8EFA4 VA: 0x2A92FA4
	|-Dictionary.KeyCollection<Int64Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A935BC Offset: 0x2A8F5BC VA: 0x2A935BC
	|-Dictionary.KeyCollection<Int64Enum, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A93BD4 Offset: 0x2A8FBD4 VA: 0x2A93BD4
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A941FC Offset: 0x2A901FC VA: 0x2A941FC
	|-Dictionary.KeyCollection<object, ValueTuple<object, byte>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A94808 Offset: 0x2A90808 VA: 0x2A94808
	|-Dictionary.KeyCollection<object, ValueTuple<float, object>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A94E14 Offset: 0x2A90E14 VA: 0x2A94E14
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A95420 Offset: 0x2A91420 VA: 0x2A95420
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A95A2C Offset: 0x2A91A2C VA: 0x2A95A2C
	|-Dictionary.KeyCollection<object, short>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A96038 Offset: 0x2A92038 VA: 0x2A96038
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A96644 Offset: 0x2A92644 VA: 0x2A96644
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A96C50 Offset: 0x2A92C50 VA: 0x2A96C50
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A9725C Offset: 0x2A9325C VA: 0x2A9725C
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A97868 Offset: 0x2A93868 VA: 0x2A97868
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A97E74 Offset: 0x2A93E74 VA: 0x2A97E74
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A98480 Offset: 0x2A94480 VA: 0x2A98480
	|-Dictionary.KeyCollection<object, DeathReceptionAction.PoisonTargetData>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A98A8C Offset: 0x2A94A8C VA: 0x2A98A8C
	|-Dictionary.KeyCollection<object, UIHouseAddressManager.Town>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A99088 Offset: 0x2A95088 VA: 0x2A99088
	|-Dictionary.KeyCollection<ushort, byte>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A996B4 Offset: 0x2A956B4 VA: 0x2A996B4
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A99E84 Offset: 0x2A95E84 VA: 0x2A99E84
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A9B6A8 Offset: 0x2A976A8 VA: 0x2A9B6A8
	|-Dictionary.KeyCollection<MaterialManager.pair, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A9BD00 Offset: 0x2A97D00 VA: 0x2A9BD00
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A9C368 Offset: 0x2A98368 VA: 0x2A9C368
	|-Dictionary.KeyCollection<PartyManager.PartyData.pair, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7A3B8 Offset: 0x2A763B8 VA: 0x2A7A3B8
	|-Dictionary.KeyCollection<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A7A9E4 Offset: 0x2A769E4 VA: 0x2A7A9E4
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A7B00C Offset: 0x2A7700C VA: 0x2A7B00C
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A7B620 Offset: 0x2A77620 VA: 0x2A7B620
	|-Dictionary.KeyCollection<ArchetypeUid, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A7BC38 Offset: 0x2A77C38 VA: 0x2A7BC38
	|-Dictionary.KeyCollection<ArchetypeUid, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A7C250 Offset: 0x2A78250 VA: 0x2A7C250
	|-Dictionary.KeyCollection<byte, ValueTuple<short, int, int>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A7C868 Offset: 0x2A78868 VA: 0x2A7C868
	|-Dictionary.KeyCollection<byte, BlackKnightAvatarProperty>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A7CE80 Offset: 0x2A78E80 VA: 0x2A7CE80
	|-Dictionary.KeyCollection<byte, BlackKnightCristaProperty>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A7D498 Offset: 0x2A79498 VA: 0x2A7D498
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A7DAB0 Offset: 0x2A79AB0 VA: 0x2A7DAB0
	|-Dictionary.KeyCollection<byte, CardData>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A7E0C8 Offset: 0x2A7A0C8 VA: 0x2A7E0C8
	|-Dictionary.KeyCollection<byte, short>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A7E6E0 Offset: 0x2A7A6E0 VA: 0x2A7E6E0
	|-Dictionary.KeyCollection<byte, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A7ECF8 Offset: 0x2A7ACF8 VA: 0x2A7ECF8
	|-Dictionary.KeyCollection<byte, long>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A7F310 Offset: 0x2A7B310 VA: 0x2A7F310
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8022C Offset: 0x2A7C22C VA: 0x2A8022C
	|-Dictionary.KeyCollection<byte, float>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A80844 Offset: 0x2A7C844 VA: 0x2A80844
	|-Dictionary.KeyCollection<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A80E5C Offset: 0x2A7CE5C VA: 0x2A80E5C
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A81474 Offset: 0x2A7D474 VA: 0x2A81474
	|-Dictionary.KeyCollection<char, char>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A81A8C Offset: 0x2A7DA8C VA: 0x2A81A8C
	|-Dictionary.KeyCollection<DefencePoint2, byte>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A829A8 Offset: 0x2A7E9A8 VA: 0x2A829A8
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A82FBC Offset: 0x2A7EFBC VA: 0x2A82FBC
	|-Dictionary.KeyCollection<short, byte>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A835D4 Offset: 0x2A7F5D4 VA: 0x2A835D4
	|-Dictionary.KeyCollection<short, short>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A83BEC Offset: 0x2A7FBEC VA: 0x2A83BEC
	|-Dictionary.KeyCollection<short, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A84204 Offset: 0x2A80204 VA: 0x2A84204
	|-Dictionary.KeyCollection<short, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8481C Offset: 0x2A8081C VA: 0x2A8481C
	|-Dictionary.KeyCollection<Int16Enum, bool>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A84E34 Offset: 0x2A80E34 VA: 0x2A84E34
	|-Dictionary.KeyCollection<Int16Enum, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8544C Offset: 0x2A8144C VA: 0x2A8544C
	|-Dictionary.KeyCollection<Int16Enum, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A85A64 Offset: 0x2A81A64 VA: 0x2A85A64
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8607C Offset: 0x2A8207C VA: 0x2A8607C
	|-Dictionary.KeyCollection<int, byte>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A86694 Offset: 0x2A82694 VA: 0x2A86694
	|-Dictionary.KeyCollection<int, Color>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A86CAC Offset: 0x2A82CAC VA: 0x2A86CAC
	|-Dictionary.KeyCollection<int, short>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A872C4 Offset: 0x2A832C4 VA: 0x2A872C4
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A878DC Offset: 0x2A838DC VA: 0x2A878DC
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A87EF4 Offset: 0x2A83EF4 VA: 0x2A87EF4
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8850C Offset: 0x2A8450C VA: 0x2A8850C
	|-Dictionary.KeyCollection<int, MaterialSearchData>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A88B24 Offset: 0x2A84B24 VA: 0x2A88B24
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8913C Offset: 0x2A8513C VA: 0x2A8913C
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A89754 Offset: 0x2A85754 VA: 0x2A89754
	|-Dictionary.KeyCollection<int, float>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A89D6C Offset: 0x2A85D6C VA: 0x2A89D6C
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8A384 Offset: 0x2A86384 VA: 0x2A8A384
	|-Dictionary.KeyCollection<int, Vector4>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8A99C Offset: 0x2A8699C VA: 0x2A8A99C
	|-Dictionary.KeyCollection<int, HouseRecipeManager.RecipeData>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8AFB4 Offset: 0x2A86FB4 VA: 0x2A8AFB4
	|-Dictionary.KeyCollection<int, MasterModelDataManager.ColorListData>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8B5CC Offset: 0x2A875CC VA: 0x2A8B5CC
	|-Dictionary.KeyCollection<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8BBE4 Offset: 0x2A87BE4 VA: 0x2A8BBE4
	|-Dictionary.KeyCollection<Int32Enum, ArchetypeUid>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8C1FC Offset: 0x2A881FC VA: 0x2A8C1FC
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8C814 Offset: 0x2A88814 VA: 0x2A8C814
	|-Dictionary.KeyCollection<Int32Enum, byte>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8CE2C Offset: 0x2A88E2C VA: 0x2A8CE2C
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8D444 Offset: 0x2A89444 VA: 0x2A8D444
	|-Dictionary.KeyCollection<Int32Enum, DateTime>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8DA5C Offset: 0x2A89A5C VA: 0x2A8DA5C
	|-Dictionary.KeyCollection<Int32Enum, EnhanceProperties2>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8E074 Offset: 0x2A8A074 VA: 0x2A8E074
	|-Dictionary.KeyCollection<Int32Enum, short>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8E68C Offset: 0x2A8A68C VA: 0x2A8E68C
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8ECA4 Offset: 0x2A8ACA4 VA: 0x2A8ECA4
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8F2BC Offset: 0x2A8B2BC VA: 0x2A8F2BC
	|-Dictionary.KeyCollection<Int32Enum, long>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8F8D4 Offset: 0x2A8B8D4 VA: 0x2A8F8D4
	|-Dictionary.KeyCollection<Int32Enum, Int64Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A8FEEC Offset: 0x2A8BEEC VA: 0x2A8FEEC
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A90504 Offset: 0x2A8C504 VA: 0x2A90504
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A90B1C Offset: 0x2A8CB1C VA: 0x2A90B1C
	|-Dictionary.KeyCollection<Int32Enum, Vector3>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A91134 Offset: 0x2A8D134 VA: 0x2A91134
	|-Dictionary.KeyCollection<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A9174C Offset: 0x2A8D74C VA: 0x2A9174C
	|-Dictionary.KeyCollection<long, bool>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A91D64 Offset: 0x2A8DD64 VA: 0x2A91D64
	|-Dictionary.KeyCollection<long, byte>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A9237C Offset: 0x2A8E37C VA: 0x2A9237C
	|-Dictionary.KeyCollection<long, short>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A92994 Offset: 0x2A8E994 VA: 0x2A92994
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A92FAC Offset: 0x2A8EFAC VA: 0x2A92FAC
	|-Dictionary.KeyCollection<Int64Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A935C4 Offset: 0x2A8F5C4 VA: 0x2A935C4
	|-Dictionary.KeyCollection<Int64Enum, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A93BDC Offset: 0x2A8FBDC VA: 0x2A93BDC
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A94204 Offset: 0x2A90204 VA: 0x2A94204
	|-Dictionary.KeyCollection<object, ValueTuple<object, byte>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A94810 Offset: 0x2A90810 VA: 0x2A94810
	|-Dictionary.KeyCollection<object, ValueTuple<float, object>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A94E1C Offset: 0x2A90E1C VA: 0x2A94E1C
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A95428 Offset: 0x2A91428 VA: 0x2A95428
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A95A34 Offset: 0x2A91A34 VA: 0x2A95A34
	|-Dictionary.KeyCollection<object, short>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A96040 Offset: 0x2A92040 VA: 0x2A96040
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A9664C Offset: 0x2A9264C VA: 0x2A9664C
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A96C58 Offset: 0x2A92C58 VA: 0x2A96C58
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A97264 Offset: 0x2A93264 VA: 0x2A97264
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A97870 Offset: 0x2A93870 VA: 0x2A97870
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A97E7C Offset: 0x2A93E7C VA: 0x2A97E7C
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A98488 Offset: 0x2A94488 VA: 0x2A98488
	|-Dictionary.KeyCollection<object, DeathReceptionAction.PoisonTargetData>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A98A94 Offset: 0x2A94A94 VA: 0x2A98A94
	|-Dictionary.KeyCollection<object, UIHouseAddressManager.Town>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A99090 Offset: 0x2A95090 VA: 0x2A99090
	|-Dictionary.KeyCollection<ushort, byte>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A996BC Offset: 0x2A956BC VA: 0x2A996BC
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A99E8C Offset: 0x2A95E8C VA: 0x2A99E8C
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A9B6B0 Offset: 0x2A976B0 VA: 0x2A9B6B0
	|-Dictionary.KeyCollection<MaterialManager.pair, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A9BD08 Offset: 0x2A97D08 VA: 0x2A9BD08
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A9C370 Offset: 0x2A98370 VA: 0x2A9C370
	|-Dictionary.KeyCollection<PartyManager.PartyData.pair, object>.System.Collections.Generic.ICollection<TKey>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TKey>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7A3C4 Offset: 0x2A763C4 VA: 0x2A7A3C4
	|-Dictionary.KeyCollection<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A7A9F0 Offset: 0x2A769F0 VA: 0x2A7A9F0
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A7B018 Offset: 0x2A77018 VA: 0x2A7B018
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A7B62C Offset: 0x2A7762C VA: 0x2A7B62C
	|-Dictionary.KeyCollection<ArchetypeUid, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A7BC44 Offset: 0x2A77C44 VA: 0x2A7BC44
	|-Dictionary.KeyCollection<ArchetypeUid, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A7C25C Offset: 0x2A7825C VA: 0x2A7C25C
	|-Dictionary.KeyCollection<byte, ValueTuple<short, int, int>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A7C874 Offset: 0x2A78874 VA: 0x2A7C874
	|-Dictionary.KeyCollection<byte, BlackKnightAvatarProperty>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A7CE8C Offset: 0x2A78E8C VA: 0x2A7CE8C
	|-Dictionary.KeyCollection<byte, BlackKnightCristaProperty>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A7D4A4 Offset: 0x2A794A4 VA: 0x2A7D4A4
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A7DABC Offset: 0x2A79ABC VA: 0x2A7DABC
	|-Dictionary.KeyCollection<byte, CardData>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A7E0D4 Offset: 0x2A7A0D4 VA: 0x2A7E0D4
	|-Dictionary.KeyCollection<byte, short>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A7E6EC Offset: 0x2A7A6EC VA: 0x2A7E6EC
	|-Dictionary.KeyCollection<byte, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A7ED04 Offset: 0x2A7AD04 VA: 0x2A7ED04
	|-Dictionary.KeyCollection<byte, long>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A7F31C Offset: 0x2A7B31C VA: 0x2A7F31C
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A80238 Offset: 0x2A7C238 VA: 0x2A80238
	|-Dictionary.KeyCollection<byte, float>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A80850 Offset: 0x2A7C850 VA: 0x2A80850
	|-Dictionary.KeyCollection<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A80E68 Offset: 0x2A7CE68 VA: 0x2A80E68
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A81480 Offset: 0x2A7D480 VA: 0x2A81480
	|-Dictionary.KeyCollection<char, char>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A81A98 Offset: 0x2A7DA98 VA: 0x2A81A98
	|-Dictionary.KeyCollection<DefencePoint2, byte>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A829B4 Offset: 0x2A7E9B4 VA: 0x2A829B4
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A82FC8 Offset: 0x2A7EFC8 VA: 0x2A82FC8
	|-Dictionary.KeyCollection<short, byte>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A835E0 Offset: 0x2A7F5E0 VA: 0x2A835E0
	|-Dictionary.KeyCollection<short, short>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A83BF8 Offset: 0x2A7FBF8 VA: 0x2A83BF8
	|-Dictionary.KeyCollection<short, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A84210 Offset: 0x2A80210 VA: 0x2A84210
	|-Dictionary.KeyCollection<short, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A84828 Offset: 0x2A80828 VA: 0x2A84828
	|-Dictionary.KeyCollection<Int16Enum, bool>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A84E40 Offset: 0x2A80E40 VA: 0x2A84E40
	|-Dictionary.KeyCollection<Int16Enum, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A85458 Offset: 0x2A81458 VA: 0x2A85458
	|-Dictionary.KeyCollection<Int16Enum, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A85A70 Offset: 0x2A81A70 VA: 0x2A85A70
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A86088 Offset: 0x2A82088 VA: 0x2A86088
	|-Dictionary.KeyCollection<int, byte>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A866A0 Offset: 0x2A826A0 VA: 0x2A866A0
	|-Dictionary.KeyCollection<int, Color>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A86CB8 Offset: 0x2A82CB8 VA: 0x2A86CB8
	|-Dictionary.KeyCollection<int, short>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A872D0 Offset: 0x2A832D0 VA: 0x2A872D0
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A878E8 Offset: 0x2A838E8 VA: 0x2A878E8
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A87F00 Offset: 0x2A83F00 VA: 0x2A87F00
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A88518 Offset: 0x2A84518 VA: 0x2A88518
	|-Dictionary.KeyCollection<int, MaterialSearchData>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A88B30 Offset: 0x2A84B30 VA: 0x2A88B30
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A89148 Offset: 0x2A85148 VA: 0x2A89148
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A89760 Offset: 0x2A85760 VA: 0x2A89760
	|-Dictionary.KeyCollection<int, float>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A89D78 Offset: 0x2A85D78 VA: 0x2A89D78
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A8A390 Offset: 0x2A86390 VA: 0x2A8A390
	|-Dictionary.KeyCollection<int, Vector4>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A8A9A8 Offset: 0x2A869A8 VA: 0x2A8A9A8
	|-Dictionary.KeyCollection<int, HouseRecipeManager.RecipeData>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A8AFC0 Offset: 0x2A86FC0 VA: 0x2A8AFC0
	|-Dictionary.KeyCollection<int, MasterModelDataManager.ColorListData>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A8B5D8 Offset: 0x2A875D8 VA: 0x2A8B5D8
	|-Dictionary.KeyCollection<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A8BBF0 Offset: 0x2A87BF0 VA: 0x2A8BBF0
	|-Dictionary.KeyCollection<Int32Enum, ArchetypeUid>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A8C208 Offset: 0x2A88208 VA: 0x2A8C208
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A8C820 Offset: 0x2A88820 VA: 0x2A8C820
	|-Dictionary.KeyCollection<Int32Enum, byte>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A8CE38 Offset: 0x2A88E38 VA: 0x2A8CE38
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A8D450 Offset: 0x2A89450 VA: 0x2A8D450
	|-Dictionary.KeyCollection<Int32Enum, DateTime>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A8DA68 Offset: 0x2A89A68 VA: 0x2A8DA68
	|-Dictionary.KeyCollection<Int32Enum, EnhanceProperties2>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A8E080 Offset: 0x2A8A080 VA: 0x2A8E080
	|-Dictionary.KeyCollection<Int32Enum, short>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A8E698 Offset: 0x2A8A698 VA: 0x2A8E698
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A8ECB0 Offset: 0x2A8ACB0 VA: 0x2A8ECB0
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A8F2C8 Offset: 0x2A8B2C8 VA: 0x2A8F2C8
	|-Dictionary.KeyCollection<Int32Enum, long>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A8F8E0 Offset: 0x2A8B8E0 VA: 0x2A8F8E0
	|-Dictionary.KeyCollection<Int32Enum, Int64Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A8FEF8 Offset: 0x2A8BEF8 VA: 0x2A8FEF8
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A90510 Offset: 0x2A8C510 VA: 0x2A90510
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A90B28 Offset: 0x2A8CB28 VA: 0x2A90B28
	|-Dictionary.KeyCollection<Int32Enum, Vector3>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A91140 Offset: 0x2A8D140 VA: 0x2A91140
	|-Dictionary.KeyCollection<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A91758 Offset: 0x2A8D758 VA: 0x2A91758
	|-Dictionary.KeyCollection<long, bool>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A91D70 Offset: 0x2A8DD70 VA: 0x2A91D70
	|-Dictionary.KeyCollection<long, byte>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A92388 Offset: 0x2A8E388 VA: 0x2A92388
	|-Dictionary.KeyCollection<long, short>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A929A0 Offset: 0x2A8E9A0 VA: 0x2A929A0
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A92FB8 Offset: 0x2A8EFB8 VA: 0x2A92FB8
	|-Dictionary.KeyCollection<Int64Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A935D0 Offset: 0x2A8F5D0 VA: 0x2A935D0
	|-Dictionary.KeyCollection<Int64Enum, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A93BE8 Offset: 0x2A8FBE8 VA: 0x2A93BE8
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A94210 Offset: 0x2A90210 VA: 0x2A94210
	|-Dictionary.KeyCollection<object, ValueTuple<object, byte>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A9481C Offset: 0x2A9081C VA: 0x2A9481C
	|-Dictionary.KeyCollection<object, ValueTuple<float, object>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A94E28 Offset: 0x2A90E28 VA: 0x2A94E28
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A95434 Offset: 0x2A91434 VA: 0x2A95434
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A95A40 Offset: 0x2A91A40 VA: 0x2A95A40
	|-Dictionary.KeyCollection<object, short>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A9604C Offset: 0x2A9204C VA: 0x2A9604C
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A96658 Offset: 0x2A92658 VA: 0x2A96658
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A96C64 Offset: 0x2A92C64 VA: 0x2A96C64
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A97270 Offset: 0x2A93270 VA: 0x2A97270
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A9787C Offset: 0x2A9387C VA: 0x2A9787C
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A97E88 Offset: 0x2A93E88 VA: 0x2A97E88
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A98494 Offset: 0x2A94494 VA: 0x2A98494
	|-Dictionary.KeyCollection<object, DeathReceptionAction.PoisonTargetData>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A98AA0 Offset: 0x2A94AA0 VA: 0x2A98AA0
	|-Dictionary.KeyCollection<object, UIHouseAddressManager.Town>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A9909C Offset: 0x2A9509C VA: 0x2A9909C
	|-Dictionary.KeyCollection<ushort, byte>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A996C8 Offset: 0x2A956C8 VA: 0x2A996C8
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A99E98 Offset: 0x2A95E98 VA: 0x2A99E98
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A9B6BC Offset: 0x2A976BC VA: 0x2A9B6BC
	|-Dictionary.KeyCollection<MaterialManager.pair, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A9BD14 Offset: 0x2A97D14 VA: 0x2A9BD14
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A9C37C Offset: 0x2A9837C VA: 0x2A9C37C
	|-Dictionary.KeyCollection<PartyManager.PartyData.pair, object>.System.Collections.Generic.ICollection<TKey>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7A3D0 Offset: 0x2A763D0 VA: 0x2A7A3D0
	|-Dictionary.KeyCollection<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A7A9FC Offset: 0x2A769FC VA: 0x2A7A9FC
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A7B024 Offset: 0x2A77024 VA: 0x2A7B024
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A7B638 Offset: 0x2A77638 VA: 0x2A7B638
	|-Dictionary.KeyCollection<ArchetypeUid, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A7BC50 Offset: 0x2A77C50 VA: 0x2A7BC50
	|-Dictionary.KeyCollection<ArchetypeUid, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A7C268 Offset: 0x2A78268 VA: 0x2A7C268
	|-Dictionary.KeyCollection<byte, ValueTuple<short, int, int>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A7C880 Offset: 0x2A78880 VA: 0x2A7C880
	|-Dictionary.KeyCollection<byte, BlackKnightAvatarProperty>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A7CE98 Offset: 0x2A78E98 VA: 0x2A7CE98
	|-Dictionary.KeyCollection<byte, BlackKnightCristaProperty>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A7D4B0 Offset: 0x2A794B0 VA: 0x2A7D4B0
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A7DAC8 Offset: 0x2A79AC8 VA: 0x2A7DAC8
	|-Dictionary.KeyCollection<byte, CardData>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A7E0E0 Offset: 0x2A7A0E0 VA: 0x2A7E0E0
	|-Dictionary.KeyCollection<byte, short>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A7E6F8 Offset: 0x2A7A6F8 VA: 0x2A7E6F8
	|-Dictionary.KeyCollection<byte, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A7ED10 Offset: 0x2A7AD10 VA: 0x2A7ED10
	|-Dictionary.KeyCollection<byte, long>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A7F328 Offset: 0x2A7B328 VA: 0x2A7F328
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A80244 Offset: 0x2A7C244 VA: 0x2A80244
	|-Dictionary.KeyCollection<byte, float>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8085C Offset: 0x2A7C85C VA: 0x2A8085C
	|-Dictionary.KeyCollection<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A80E74 Offset: 0x2A7CE74 VA: 0x2A80E74
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8148C Offset: 0x2A7D48C VA: 0x2A8148C
	|-Dictionary.KeyCollection<char, char>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A81AA4 Offset: 0x2A7DAA4 VA: 0x2A81AA4
	|-Dictionary.KeyCollection<DefencePoint2, byte>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A829C0 Offset: 0x2A7E9C0 VA: 0x2A829C0
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A82FD4 Offset: 0x2A7EFD4 VA: 0x2A82FD4
	|-Dictionary.KeyCollection<short, byte>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A835EC Offset: 0x2A7F5EC VA: 0x2A835EC
	|-Dictionary.KeyCollection<short, short>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A83C04 Offset: 0x2A7FC04 VA: 0x2A83C04
	|-Dictionary.KeyCollection<short, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8421C Offset: 0x2A8021C VA: 0x2A8421C
	|-Dictionary.KeyCollection<short, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A84834 Offset: 0x2A80834 VA: 0x2A84834
	|-Dictionary.KeyCollection<Int16Enum, bool>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A84E4C Offset: 0x2A80E4C VA: 0x2A84E4C
	|-Dictionary.KeyCollection<Int16Enum, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A85464 Offset: 0x2A81464 VA: 0x2A85464
	|-Dictionary.KeyCollection<Int16Enum, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A85A7C Offset: 0x2A81A7C VA: 0x2A85A7C
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A86094 Offset: 0x2A82094 VA: 0x2A86094
	|-Dictionary.KeyCollection<int, byte>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A866AC Offset: 0x2A826AC VA: 0x2A866AC
	|-Dictionary.KeyCollection<int, Color>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A86CC4 Offset: 0x2A82CC4 VA: 0x2A86CC4
	|-Dictionary.KeyCollection<int, short>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A872DC Offset: 0x2A832DC VA: 0x2A872DC
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A878F4 Offset: 0x2A838F4 VA: 0x2A878F4
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A87F0C Offset: 0x2A83F0C VA: 0x2A87F0C
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A88524 Offset: 0x2A84524 VA: 0x2A88524
	|-Dictionary.KeyCollection<int, MaterialSearchData>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A88B3C Offset: 0x2A84B3C VA: 0x2A88B3C
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A89154 Offset: 0x2A85154 VA: 0x2A89154
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8976C Offset: 0x2A8576C VA: 0x2A8976C
	|-Dictionary.KeyCollection<int, float>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A89D84 Offset: 0x2A85D84 VA: 0x2A89D84
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8A39C Offset: 0x2A8639C VA: 0x2A8A39C
	|-Dictionary.KeyCollection<int, Vector4>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8A9B4 Offset: 0x2A869B4 VA: 0x2A8A9B4
	|-Dictionary.KeyCollection<int, HouseRecipeManager.RecipeData>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8AFCC Offset: 0x2A86FCC VA: 0x2A8AFCC
	|-Dictionary.KeyCollection<int, MasterModelDataManager.ColorListData>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8B5E4 Offset: 0x2A875E4 VA: 0x2A8B5E4
	|-Dictionary.KeyCollection<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8BBFC Offset: 0x2A87BFC VA: 0x2A8BBFC
	|-Dictionary.KeyCollection<Int32Enum, ArchetypeUid>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8C214 Offset: 0x2A88214 VA: 0x2A8C214
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8C82C Offset: 0x2A8882C VA: 0x2A8C82C
	|-Dictionary.KeyCollection<Int32Enum, byte>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8CE44 Offset: 0x2A88E44 VA: 0x2A8CE44
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8D45C Offset: 0x2A8945C VA: 0x2A8D45C
	|-Dictionary.KeyCollection<Int32Enum, DateTime>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8DA74 Offset: 0x2A89A74 VA: 0x2A8DA74
	|-Dictionary.KeyCollection<Int32Enum, EnhanceProperties2>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8E08C Offset: 0x2A8A08C VA: 0x2A8E08C
	|-Dictionary.KeyCollection<Int32Enum, short>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8E6A4 Offset: 0x2A8A6A4 VA: 0x2A8E6A4
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8ECBC Offset: 0x2A8ACBC VA: 0x2A8ECBC
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8F2D4 Offset: 0x2A8B2D4 VA: 0x2A8F2D4
	|-Dictionary.KeyCollection<Int32Enum, long>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8F8EC Offset: 0x2A8B8EC VA: 0x2A8F8EC
	|-Dictionary.KeyCollection<Int32Enum, Int64Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A8FF04 Offset: 0x2A8BF04 VA: 0x2A8FF04
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A9051C Offset: 0x2A8C51C VA: 0x2A9051C
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A90B34 Offset: 0x2A8CB34 VA: 0x2A90B34
	|-Dictionary.KeyCollection<Int32Enum, Vector3>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A9114C Offset: 0x2A8D14C VA: 0x2A9114C
	|-Dictionary.KeyCollection<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A91764 Offset: 0x2A8D764 VA: 0x2A91764
	|-Dictionary.KeyCollection<long, bool>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A91D7C Offset: 0x2A8DD7C VA: 0x2A91D7C
	|-Dictionary.KeyCollection<long, byte>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A92394 Offset: 0x2A8E394 VA: 0x2A92394
	|-Dictionary.KeyCollection<long, short>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A929AC Offset: 0x2A8E9AC VA: 0x2A929AC
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A92FC4 Offset: 0x2A8EFC4 VA: 0x2A92FC4
	|-Dictionary.KeyCollection<Int64Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A935DC Offset: 0x2A8F5DC VA: 0x2A935DC
	|-Dictionary.KeyCollection<Int64Enum, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A93BF4 Offset: 0x2A8FBF4 VA: 0x2A93BF4
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A9421C Offset: 0x2A9021C VA: 0x2A9421C
	|-Dictionary.KeyCollection<object, ValueTuple<object, byte>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A94828 Offset: 0x2A90828 VA: 0x2A94828
	|-Dictionary.KeyCollection<object, ValueTuple<float, object>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A94E34 Offset: 0x2A90E34 VA: 0x2A94E34
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A95440 Offset: 0x2A91440 VA: 0x2A95440
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A95A4C Offset: 0x2A91A4C VA: 0x2A95A4C
	|-Dictionary.KeyCollection<object, short>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A96058 Offset: 0x2A92058 VA: 0x2A96058
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A96664 Offset: 0x2A92664 VA: 0x2A96664
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A96C70 Offset: 0x2A92C70 VA: 0x2A96C70
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A9727C Offset: 0x2A9327C VA: 0x2A9727C
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A97888 Offset: 0x2A93888 VA: 0x2A97888
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A97E94 Offset: 0x2A93E94 VA: 0x2A97E94
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A984A0 Offset: 0x2A944A0 VA: 0x2A984A0
	|-Dictionary.KeyCollection<object, DeathReceptionAction.PoisonTargetData>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A98AAC Offset: 0x2A94AAC VA: 0x2A98AAC
	|-Dictionary.KeyCollection<object, UIHouseAddressManager.Town>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A990A8 Offset: 0x2A950A8 VA: 0x2A990A8
	|-Dictionary.KeyCollection<ushort, byte>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A996D4 Offset: 0x2A956D4 VA: 0x2A996D4
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A99EA4 Offset: 0x2A95EA4 VA: 0x2A99EA4
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A9B6C8 Offset: 0x2A976C8 VA: 0x2A9B6C8
	|-Dictionary.KeyCollection<MaterialManager.pair, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A9BD20 Offset: 0x2A97D20 VA: 0x2A9BD20
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A9C388 Offset: 0x2A98388 VA: 0x2A9C388
	|-Dictionary.KeyCollection<PartyManager.PartyData.pair, object>.System.Collections.Generic.ICollection<TKey>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7A3F4 Offset: 0x2A763F4 VA: 0x2A7A3F4
	|-Dictionary.KeyCollection<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A7AA20 Offset: 0x2A76A20 VA: 0x2A7AA20
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A7B048 Offset: 0x2A77048 VA: 0x2A7B048
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A7B65C Offset: 0x2A7765C VA: 0x2A7B65C
	|-Dictionary.KeyCollection<ArchetypeUid, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A7BC74 Offset: 0x2A77C74 VA: 0x2A7BC74
	|-Dictionary.KeyCollection<ArchetypeUid, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A7C28C Offset: 0x2A7828C VA: 0x2A7C28C
	|-Dictionary.KeyCollection<byte, ValueTuple<short, int, int>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A7C8A4 Offset: 0x2A788A4 VA: 0x2A7C8A4
	|-Dictionary.KeyCollection<byte, BlackKnightAvatarProperty>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A7CEBC Offset: 0x2A78EBC VA: 0x2A7CEBC
	|-Dictionary.KeyCollection<byte, BlackKnightCristaProperty>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A7D4D4 Offset: 0x2A794D4 VA: 0x2A7D4D4
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A7DAEC Offset: 0x2A79AEC VA: 0x2A7DAEC
	|-Dictionary.KeyCollection<byte, CardData>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A7E104 Offset: 0x2A7A104 VA: 0x2A7E104
	|-Dictionary.KeyCollection<byte, short>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A7E71C Offset: 0x2A7A71C VA: 0x2A7E71C
	|-Dictionary.KeyCollection<byte, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A7ED34 Offset: 0x2A7AD34 VA: 0x2A7ED34
	|-Dictionary.KeyCollection<byte, long>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A7F34C Offset: 0x2A7B34C VA: 0x2A7F34C
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A80268 Offset: 0x2A7C268 VA: 0x2A80268
	|-Dictionary.KeyCollection<byte, float>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A80880 Offset: 0x2A7C880 VA: 0x2A80880
	|-Dictionary.KeyCollection<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A80E98 Offset: 0x2A7CE98 VA: 0x2A80E98
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A814B0 Offset: 0x2A7D4B0 VA: 0x2A814B0
	|-Dictionary.KeyCollection<char, char>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A81AC8 Offset: 0x2A7DAC8 VA: 0x2A81AC8
	|-Dictionary.KeyCollection<DefencePoint2, byte>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A829E4 Offset: 0x2A7E9E4 VA: 0x2A829E4
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A82FF8 Offset: 0x2A7EFF8 VA: 0x2A82FF8
	|-Dictionary.KeyCollection<short, byte>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A83610 Offset: 0x2A7F610 VA: 0x2A83610
	|-Dictionary.KeyCollection<short, short>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A83C28 Offset: 0x2A7FC28 VA: 0x2A83C28
	|-Dictionary.KeyCollection<short, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A84240 Offset: 0x2A80240 VA: 0x2A84240
	|-Dictionary.KeyCollection<short, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A84858 Offset: 0x2A80858 VA: 0x2A84858
	|-Dictionary.KeyCollection<Int16Enum, bool>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A84E70 Offset: 0x2A80E70 VA: 0x2A84E70
	|-Dictionary.KeyCollection<Int16Enum, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A85488 Offset: 0x2A81488 VA: 0x2A85488
	|-Dictionary.KeyCollection<Int16Enum, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A85AA0 Offset: 0x2A81AA0 VA: 0x2A85AA0
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A860B8 Offset: 0x2A820B8 VA: 0x2A860B8
	|-Dictionary.KeyCollection<int, byte>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A866D0 Offset: 0x2A826D0 VA: 0x2A866D0
	|-Dictionary.KeyCollection<int, Color>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A86CE8 Offset: 0x2A82CE8 VA: 0x2A86CE8
	|-Dictionary.KeyCollection<int, short>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A87300 Offset: 0x2A83300 VA: 0x2A87300
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A87918 Offset: 0x2A83918 VA: 0x2A87918
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A87F30 Offset: 0x2A83F30 VA: 0x2A87F30
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A88548 Offset: 0x2A84548 VA: 0x2A88548
	|-Dictionary.KeyCollection<int, MaterialSearchData>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A88B60 Offset: 0x2A84B60 VA: 0x2A88B60
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A89178 Offset: 0x2A85178 VA: 0x2A89178
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A89790 Offset: 0x2A85790 VA: 0x2A89790
	|-Dictionary.KeyCollection<int, float>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A89DA8 Offset: 0x2A85DA8 VA: 0x2A89DA8
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A8A3C0 Offset: 0x2A863C0 VA: 0x2A8A3C0
	|-Dictionary.KeyCollection<int, Vector4>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A8A9D8 Offset: 0x2A869D8 VA: 0x2A8A9D8
	|-Dictionary.KeyCollection<int, HouseRecipeManager.RecipeData>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A8AFF0 Offset: 0x2A86FF0 VA: 0x2A8AFF0
	|-Dictionary.KeyCollection<int, MasterModelDataManager.ColorListData>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A8B608 Offset: 0x2A87608 VA: 0x2A8B608
	|-Dictionary.KeyCollection<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A8BC20 Offset: 0x2A87C20 VA: 0x2A8BC20
	|-Dictionary.KeyCollection<Int32Enum, ArchetypeUid>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A8C238 Offset: 0x2A88238 VA: 0x2A8C238
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A8C850 Offset: 0x2A88850 VA: 0x2A8C850
	|-Dictionary.KeyCollection<Int32Enum, byte>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A8CE68 Offset: 0x2A88E68 VA: 0x2A8CE68
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A8D480 Offset: 0x2A89480 VA: 0x2A8D480
	|-Dictionary.KeyCollection<Int32Enum, DateTime>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A8DA98 Offset: 0x2A89A98 VA: 0x2A8DA98
	|-Dictionary.KeyCollection<Int32Enum, EnhanceProperties2>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A8E0B0 Offset: 0x2A8A0B0 VA: 0x2A8E0B0
	|-Dictionary.KeyCollection<Int32Enum, short>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A8E6C8 Offset: 0x2A8A6C8 VA: 0x2A8E6C8
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A8ECE0 Offset: 0x2A8ACE0 VA: 0x2A8ECE0
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A8F2F8 Offset: 0x2A8B2F8 VA: 0x2A8F2F8
	|-Dictionary.KeyCollection<Int32Enum, long>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A8F910 Offset: 0x2A8B910 VA: 0x2A8F910
	|-Dictionary.KeyCollection<Int32Enum, Int64Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A8FF28 Offset: 0x2A8BF28 VA: 0x2A8FF28
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A90540 Offset: 0x2A8C540 VA: 0x2A90540
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A90B58 Offset: 0x2A8CB58 VA: 0x2A90B58
	|-Dictionary.KeyCollection<Int32Enum, Vector3>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A91170 Offset: 0x2A8D170 VA: 0x2A91170
	|-Dictionary.KeyCollection<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A91788 Offset: 0x2A8D788 VA: 0x2A91788
	|-Dictionary.KeyCollection<long, bool>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A91DA0 Offset: 0x2A8DDA0 VA: 0x2A91DA0
	|-Dictionary.KeyCollection<long, byte>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A923B8 Offset: 0x2A8E3B8 VA: 0x2A923B8
	|-Dictionary.KeyCollection<long, short>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A929D0 Offset: 0x2A8E9D0 VA: 0x2A929D0
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A92FE8 Offset: 0x2A8EFE8 VA: 0x2A92FE8
	|-Dictionary.KeyCollection<Int64Enum, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A93600 Offset: 0x2A8F600 VA: 0x2A93600
	|-Dictionary.KeyCollection<Int64Enum, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A93C18 Offset: 0x2A8FC18 VA: 0x2A93C18
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A94240 Offset: 0x2A90240 VA: 0x2A94240
	|-Dictionary.KeyCollection<object, ValueTuple<object, byte>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A9484C Offset: 0x2A9084C VA: 0x2A9484C
	|-Dictionary.KeyCollection<object, ValueTuple<float, object>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A94E58 Offset: 0x2A90E58 VA: 0x2A94E58
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A95464 Offset: 0x2A91464 VA: 0x2A95464
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A95A70 Offset: 0x2A91A70 VA: 0x2A95A70
	|-Dictionary.KeyCollection<object, short>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A9607C Offset: 0x2A9207C VA: 0x2A9607C
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A96688 Offset: 0x2A92688 VA: 0x2A96688
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A96C94 Offset: 0x2A92C94 VA: 0x2A96C94
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A972A0 Offset: 0x2A932A0 VA: 0x2A972A0
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A978AC Offset: 0x2A938AC VA: 0x2A978AC
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A97EB8 Offset: 0x2A93EB8 VA: 0x2A97EB8
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A984C4 Offset: 0x2A944C4 VA: 0x2A984C4
	|-Dictionary.KeyCollection<object, DeathReceptionAction.PoisonTargetData>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A98AD0 Offset: 0x2A94AD0 VA: 0x2A98AD0
	|-Dictionary.KeyCollection<object, UIHouseAddressManager.Town>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A990CC Offset: 0x2A950CC VA: 0x2A990CC
	|-Dictionary.KeyCollection<ushort, byte>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A996F8 Offset: 0x2A956F8 VA: 0x2A996F8
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A99F74 Offset: 0x2A95F74 VA: 0x2A99F74
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A9B6EC Offset: 0x2A976EC VA: 0x2A9B6EC
	|-Dictionary.KeyCollection<MaterialManager.pair, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A9BD78 Offset: 0x2A97D78 VA: 0x2A9BD78
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A9C3AC Offset: 0x2A983AC VA: 0x2A9C3AC
	|-Dictionary.KeyCollection<PartyManager.PartyData.pair, object>.System.Collections.Generic.ICollection<TKey>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7A410 Offset: 0x2A76410 VA: 0x2A7A410
	|-Dictionary.KeyCollection<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A7AA3C Offset: 0x2A76A3C VA: 0x2A7AA3C
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A7B064 Offset: 0x2A77064 VA: 0x2A7B064
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A7B678 Offset: 0x2A77678 VA: 0x2A7B678
	|-Dictionary.KeyCollection<ArchetypeUid, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A7BC90 Offset: 0x2A77C90 VA: 0x2A7BC90
	|-Dictionary.KeyCollection<ArchetypeUid, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A7C2A8 Offset: 0x2A782A8 VA: 0x2A7C2A8
	|-Dictionary.KeyCollection<byte, ValueTuple<short, int, int>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A7C8C0 Offset: 0x2A788C0 VA: 0x2A7C8C0
	|-Dictionary.KeyCollection<byte, BlackKnightAvatarProperty>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A7CED8 Offset: 0x2A78ED8 VA: 0x2A7CED8
	|-Dictionary.KeyCollection<byte, BlackKnightCristaProperty>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A7D4F0 Offset: 0x2A794F0 VA: 0x2A7D4F0
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A7DB08 Offset: 0x2A79B08 VA: 0x2A7DB08
	|-Dictionary.KeyCollection<byte, CardData>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A7E120 Offset: 0x2A7A120 VA: 0x2A7E120
	|-Dictionary.KeyCollection<byte, short>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A7E738 Offset: 0x2A7A738 VA: 0x2A7E738
	|-Dictionary.KeyCollection<byte, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A7ED50 Offset: 0x2A7AD50 VA: 0x2A7ED50
	|-Dictionary.KeyCollection<byte, long>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A7F368 Offset: 0x2A7B368 VA: 0x2A7F368
	|-Dictionary.KeyCollection<byte, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A80284 Offset: 0x2A7C284 VA: 0x2A80284
	|-Dictionary.KeyCollection<byte, float>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8089C Offset: 0x2A7C89C VA: 0x2A8089C
	|-Dictionary.KeyCollection<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A80EB4 Offset: 0x2A7CEB4 VA: 0x2A80EB4
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A814CC Offset: 0x2A7D4CC VA: 0x2A814CC
	|-Dictionary.KeyCollection<char, char>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A81AE4 Offset: 0x2A7DAE4 VA: 0x2A81AE4
	|-Dictionary.KeyCollection<DefencePoint2, byte>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A82A00 Offset: 0x2A7EA00 VA: 0x2A82A00
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A83014 Offset: 0x2A7F014 VA: 0x2A83014
	|-Dictionary.KeyCollection<short, byte>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8362C Offset: 0x2A7F62C VA: 0x2A8362C
	|-Dictionary.KeyCollection<short, short>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A83C44 Offset: 0x2A7FC44 VA: 0x2A83C44
	|-Dictionary.KeyCollection<short, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8425C Offset: 0x2A8025C VA: 0x2A8425C
	|-Dictionary.KeyCollection<short, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A84874 Offset: 0x2A80874 VA: 0x2A84874
	|-Dictionary.KeyCollection<Int16Enum, bool>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A84E8C Offset: 0x2A80E8C VA: 0x2A84E8C
	|-Dictionary.KeyCollection<Int16Enum, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A854A4 Offset: 0x2A814A4 VA: 0x2A854A4
	|-Dictionary.KeyCollection<Int16Enum, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A85ABC Offset: 0x2A81ABC VA: 0x2A85ABC
	|-Dictionary.KeyCollection<int, bool>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A860D4 Offset: 0x2A820D4 VA: 0x2A860D4
	|-Dictionary.KeyCollection<int, byte>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A866EC Offset: 0x2A826EC VA: 0x2A866EC
	|-Dictionary.KeyCollection<int, Color>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A86D04 Offset: 0x2A82D04 VA: 0x2A86D04
	|-Dictionary.KeyCollection<int, short>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8731C Offset: 0x2A8331C VA: 0x2A8731C
	|-Dictionary.KeyCollection<int, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A87934 Offset: 0x2A83934 VA: 0x2A87934
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A87F4C Offset: 0x2A83F4C VA: 0x2A87F4C
	|-Dictionary.KeyCollection<int, long>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A88564 Offset: 0x2A84564 VA: 0x2A88564
	|-Dictionary.KeyCollection<int, MaterialSearchData>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A88B7C Offset: 0x2A84B7C VA: 0x2A88B7C
	|-Dictionary.KeyCollection<int, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A89194 Offset: 0x2A85194 VA: 0x2A89194
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A897AC Offset: 0x2A857AC VA: 0x2A897AC
	|-Dictionary.KeyCollection<int, float>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A89DC4 Offset: 0x2A85DC4 VA: 0x2A89DC4
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8A3DC Offset: 0x2A863DC VA: 0x2A8A3DC
	|-Dictionary.KeyCollection<int, Vector4>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8A9F4 Offset: 0x2A869F4 VA: 0x2A8A9F4
	|-Dictionary.KeyCollection<int, HouseRecipeManager.RecipeData>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8B00C Offset: 0x2A8700C VA: 0x2A8B00C
	|-Dictionary.KeyCollection<int, MasterModelDataManager.ColorListData>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8B624 Offset: 0x2A87624 VA: 0x2A8B624
	|-Dictionary.KeyCollection<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8BC3C Offset: 0x2A87C3C VA: 0x2A8BC3C
	|-Dictionary.KeyCollection<Int32Enum, ArchetypeUid>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8C254 Offset: 0x2A88254 VA: 0x2A8C254
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8C86C Offset: 0x2A8886C VA: 0x2A8C86C
	|-Dictionary.KeyCollection<Int32Enum, byte>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8CE84 Offset: 0x2A88E84 VA: 0x2A8CE84
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8D49C Offset: 0x2A8949C VA: 0x2A8D49C
	|-Dictionary.KeyCollection<Int32Enum, DateTime>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8DAB4 Offset: 0x2A89AB4 VA: 0x2A8DAB4
	|-Dictionary.KeyCollection<Int32Enum, EnhanceProperties2>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8E0CC Offset: 0x2A8A0CC VA: 0x2A8E0CC
	|-Dictionary.KeyCollection<Int32Enum, short>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8E6E4 Offset: 0x2A8A6E4 VA: 0x2A8E6E4
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8ECFC Offset: 0x2A8ACFC VA: 0x2A8ECFC
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8F314 Offset: 0x2A8B314 VA: 0x2A8F314
	|-Dictionary.KeyCollection<Int32Enum, long>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8F92C Offset: 0x2A8B92C VA: 0x2A8F92C
	|-Dictionary.KeyCollection<Int32Enum, Int64Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A8FF44 Offset: 0x2A8BF44 VA: 0x2A8FF44
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A9055C Offset: 0x2A8C55C VA: 0x2A9055C
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A90B74 Offset: 0x2A8CB74 VA: 0x2A90B74
	|-Dictionary.KeyCollection<Int32Enum, Vector3>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A9118C Offset: 0x2A8D18C VA: 0x2A9118C
	|-Dictionary.KeyCollection<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A917A4 Offset: 0x2A8D7A4 VA: 0x2A917A4
	|-Dictionary.KeyCollection<long, bool>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A91DBC Offset: 0x2A8DDBC VA: 0x2A91DBC
	|-Dictionary.KeyCollection<long, byte>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A923D4 Offset: 0x2A8E3D4 VA: 0x2A923D4
	|-Dictionary.KeyCollection<long, short>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A929EC Offset: 0x2A8E9EC VA: 0x2A929EC
	|-Dictionary.KeyCollection<long, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A93004 Offset: 0x2A8F004 VA: 0x2A93004
	|-Dictionary.KeyCollection<Int64Enum, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A9361C Offset: 0x2A8F61C VA: 0x2A9361C
	|-Dictionary.KeyCollection<Int64Enum, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A93C34 Offset: 0x2A8FC34 VA: 0x2A93C34
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A9425C Offset: 0x2A9025C VA: 0x2A9425C
	|-Dictionary.KeyCollection<object, ValueTuple<object, byte>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A94868 Offset: 0x2A90868 VA: 0x2A94868
	|-Dictionary.KeyCollection<object, ValueTuple<float, object>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A94E74 Offset: 0x2A90E74 VA: 0x2A94E74
	|-Dictionary.KeyCollection<object, bool>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A95480 Offset: 0x2A91480 VA: 0x2A95480
	|-Dictionary.KeyCollection<object, byte>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A95A8C Offset: 0x2A91A8C VA: 0x2A95A8C
	|-Dictionary.KeyCollection<object, short>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A96098 Offset: 0x2A92098 VA: 0x2A96098
	|-Dictionary.KeyCollection<object, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A966A4 Offset: 0x2A926A4 VA: 0x2A966A4
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A96CB0 Offset: 0x2A92CB0 VA: 0x2A96CB0
	|-Dictionary.KeyCollection<object, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A972BC Offset: 0x2A932BC VA: 0x2A972BC
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A978C8 Offset: 0x2A938C8 VA: 0x2A978C8
	|-Dictionary.KeyCollection<object, float>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A97ED4 Offset: 0x2A93ED4 VA: 0x2A97ED4
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A984E0 Offset: 0x2A944E0 VA: 0x2A984E0
	|-Dictionary.KeyCollection<object, DeathReceptionAction.PoisonTargetData>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A98AEC Offset: 0x2A94AEC VA: 0x2A98AEC
	|-Dictionary.KeyCollection<object, UIHouseAddressManager.Town>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A990E8 Offset: 0x2A950E8 VA: 0x2A990E8
	|-Dictionary.KeyCollection<ushort, byte>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A99714 Offset: 0x2A95714 VA: 0x2A99714
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A99F90 Offset: 0x2A95F90 VA: 0x2A99F90
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A9B708 Offset: 0x2A97708 VA: 0x2A9B708
	|-Dictionary.KeyCollection<MaterialManager.pair, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A9BD94 Offset: 0x2A97D94 VA: 0x2A9BD94
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A9C3C8 Offset: 0x2A983C8 VA: 0x2A9C3C8
	|-Dictionary.KeyCollection<PartyManager.PartyData.pair, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7A46C Offset: 0x2A7646C VA: 0x2A7A46C
	|-Dictionary.KeyCollection<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A7AA90 Offset: 0x2A76A90 VA: 0x2A7AA90
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A7B0B8 Offset: 0x2A770B8 VA: 0x2A7B0B8
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A7B6D4 Offset: 0x2A776D4 VA: 0x2A7B6D4
	|-Dictionary.KeyCollection<ArchetypeUid, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A7BCEC Offset: 0x2A77CEC VA: 0x2A7BCEC
	|-Dictionary.KeyCollection<ArchetypeUid, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A7C304 Offset: 0x2A78304 VA: 0x2A7C304
	|-Dictionary.KeyCollection<byte, ValueTuple<short, int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A7C91C Offset: 0x2A7891C VA: 0x2A7C91C
	|-Dictionary.KeyCollection<byte, BlackKnightAvatarProperty>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A7CF34 Offset: 0x2A78F34 VA: 0x2A7CF34
	|-Dictionary.KeyCollection<byte, BlackKnightCristaProperty>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A7D54C Offset: 0x2A7954C VA: 0x2A7D54C
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A7DB64 Offset: 0x2A79B64 VA: 0x2A7DB64
	|-Dictionary.KeyCollection<byte, CardData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A7E17C Offset: 0x2A7A17C VA: 0x2A7E17C
	|-Dictionary.KeyCollection<byte, short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A7E794 Offset: 0x2A7A794 VA: 0x2A7E794
	|-Dictionary.KeyCollection<byte, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A7EDAC Offset: 0x2A7ADAC VA: 0x2A7EDAC
	|-Dictionary.KeyCollection<byte, long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A7F3C4 Offset: 0x2A7B3C4 VA: 0x2A7F3C4
	|-Dictionary.KeyCollection<byte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A802E0 Offset: 0x2A7C2E0 VA: 0x2A802E0
	|-Dictionary.KeyCollection<byte, float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A808F8 Offset: 0x2A7C8F8 VA: 0x2A808F8
	|-Dictionary.KeyCollection<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A80F10 Offset: 0x2A7CF10 VA: 0x2A80F10
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A81528 Offset: 0x2A7D528 VA: 0x2A81528
	|-Dictionary.KeyCollection<char, char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A81B40 Offset: 0x2A7DB40 VA: 0x2A81B40
	|-Dictionary.KeyCollection<DefencePoint2, byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A82A54 Offset: 0x2A7EA54 VA: 0x2A82A54
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A83070 Offset: 0x2A7F070 VA: 0x2A83070
	|-Dictionary.KeyCollection<short, byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A83688 Offset: 0x2A7F688 VA: 0x2A83688
	|-Dictionary.KeyCollection<short, short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A83CA0 Offset: 0x2A7FCA0 VA: 0x2A83CA0
	|-Dictionary.KeyCollection<short, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A842B8 Offset: 0x2A802B8 VA: 0x2A842B8
	|-Dictionary.KeyCollection<short, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A848D0 Offset: 0x2A808D0 VA: 0x2A848D0
	|-Dictionary.KeyCollection<Int16Enum, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A84EE8 Offset: 0x2A80EE8 VA: 0x2A84EE8
	|-Dictionary.KeyCollection<Int16Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A85500 Offset: 0x2A81500 VA: 0x2A85500
	|-Dictionary.KeyCollection<Int16Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A85B18 Offset: 0x2A81B18 VA: 0x2A85B18
	|-Dictionary.KeyCollection<int, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A86130 Offset: 0x2A82130 VA: 0x2A86130
	|-Dictionary.KeyCollection<int, byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A86748 Offset: 0x2A82748 VA: 0x2A86748
	|-Dictionary.KeyCollection<int, Color>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A86D60 Offset: 0x2A82D60 VA: 0x2A86D60
	|-Dictionary.KeyCollection<int, short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A87378 Offset: 0x2A83378 VA: 0x2A87378
	|-Dictionary.KeyCollection<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A87990 Offset: 0x2A83990 VA: 0x2A87990
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A87FA8 Offset: 0x2A83FA8 VA: 0x2A87FA8
	|-Dictionary.KeyCollection<int, long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A885C0 Offset: 0x2A845C0 VA: 0x2A885C0
	|-Dictionary.KeyCollection<int, MaterialSearchData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A88BD8 Offset: 0x2A84BD8 VA: 0x2A88BD8
	|-Dictionary.KeyCollection<int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A891F0 Offset: 0x2A851F0 VA: 0x2A891F0
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A89808 Offset: 0x2A85808 VA: 0x2A89808
	|-Dictionary.KeyCollection<int, float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A89E20 Offset: 0x2A85E20 VA: 0x2A89E20
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8A438 Offset: 0x2A86438 VA: 0x2A8A438
	|-Dictionary.KeyCollection<int, Vector4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8AA50 Offset: 0x2A86A50 VA: 0x2A8AA50
	|-Dictionary.KeyCollection<int, HouseRecipeManager.RecipeData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8B068 Offset: 0x2A87068 VA: 0x2A8B068
	|-Dictionary.KeyCollection<int, MasterModelDataManager.ColorListData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8B680 Offset: 0x2A87680 VA: 0x2A8B680
	|-Dictionary.KeyCollection<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8BC98 Offset: 0x2A87C98 VA: 0x2A8BC98
	|-Dictionary.KeyCollection<Int32Enum, ArchetypeUid>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8C2B0 Offset: 0x2A882B0 VA: 0x2A8C2B0
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8C8C8 Offset: 0x2A888C8 VA: 0x2A8C8C8
	|-Dictionary.KeyCollection<Int32Enum, byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8CEE0 Offset: 0x2A88EE0 VA: 0x2A8CEE0
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8D4F8 Offset: 0x2A894F8 VA: 0x2A8D4F8
	|-Dictionary.KeyCollection<Int32Enum, DateTime>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8DB10 Offset: 0x2A89B10 VA: 0x2A8DB10
	|-Dictionary.KeyCollection<Int32Enum, EnhanceProperties2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8E128 Offset: 0x2A8A128 VA: 0x2A8E128
	|-Dictionary.KeyCollection<Int32Enum, short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8E740 Offset: 0x2A8A740 VA: 0x2A8E740
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8ED58 Offset: 0x2A8AD58 VA: 0x2A8ED58
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8F370 Offset: 0x2A8B370 VA: 0x2A8F370
	|-Dictionary.KeyCollection<Int32Enum, long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8F988 Offset: 0x2A8B988 VA: 0x2A8F988
	|-Dictionary.KeyCollection<Int32Enum, Int64Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8FFA0 Offset: 0x2A8BFA0 VA: 0x2A8FFA0
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A905B8 Offset: 0x2A8C5B8 VA: 0x2A905B8
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A90BD0 Offset: 0x2A8CBD0 VA: 0x2A90BD0
	|-Dictionary.KeyCollection<Int32Enum, Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A911E8 Offset: 0x2A8D1E8 VA: 0x2A911E8
	|-Dictionary.KeyCollection<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A91800 Offset: 0x2A8D800 VA: 0x2A91800
	|-Dictionary.KeyCollection<long, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A91E18 Offset: 0x2A8DE18 VA: 0x2A91E18
	|-Dictionary.KeyCollection<long, byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A92430 Offset: 0x2A8E430 VA: 0x2A92430
	|-Dictionary.KeyCollection<long, short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A92A48 Offset: 0x2A8EA48 VA: 0x2A92A48
	|-Dictionary.KeyCollection<long, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A93060 Offset: 0x2A8F060 VA: 0x2A93060
	|-Dictionary.KeyCollection<Int64Enum, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A93678 Offset: 0x2A8F678 VA: 0x2A93678
	|-Dictionary.KeyCollection<Int64Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A93C90 Offset: 0x2A8FC90 VA: 0x2A93C90
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A942B8 Offset: 0x2A902B8 VA: 0x2A942B8
	|-Dictionary.KeyCollection<object, ValueTuple<object, byte>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A948C4 Offset: 0x2A908C4 VA: 0x2A948C4
	|-Dictionary.KeyCollection<object, ValueTuple<float, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A94ED0 Offset: 0x2A90ED0 VA: 0x2A94ED0
	|-Dictionary.KeyCollection<object, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A954DC Offset: 0x2A914DC VA: 0x2A954DC
	|-Dictionary.KeyCollection<object, byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A95AE8 Offset: 0x2A91AE8 VA: 0x2A95AE8
	|-Dictionary.KeyCollection<object, short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A960F4 Offset: 0x2A920F4 VA: 0x2A960F4
	|-Dictionary.KeyCollection<object, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A96700 Offset: 0x2A92700 VA: 0x2A96700
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A96D0C Offset: 0x2A92D0C VA: 0x2A96D0C
	|-Dictionary.KeyCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A97318 Offset: 0x2A93318 VA: 0x2A97318
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A97924 Offset: 0x2A93924 VA: 0x2A97924
	|-Dictionary.KeyCollection<object, float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A97F30 Offset: 0x2A93F30 VA: 0x2A97F30
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A9853C Offset: 0x2A9453C VA: 0x2A9853C
	|-Dictionary.KeyCollection<object, DeathReceptionAction.PoisonTargetData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A98B48 Offset: 0x2A94B48 VA: 0x2A98B48
	|-Dictionary.KeyCollection<object, UIHouseAddressManager.Town>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A99144 Offset: 0x2A95144 VA: 0x2A99144
	|-Dictionary.KeyCollection<ushort, byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A99768 Offset: 0x2A95768 VA: 0x2A99768
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A9A040 Offset: 0x2A96040 VA: 0x2A9A040
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A9B764 Offset: 0x2A97764 VA: 0x2A9B764
	|-Dictionary.KeyCollection<MaterialManager.pair, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A9BDF4 Offset: 0x2A97DF4 VA: 0x2A9BDF4
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A9C424 Offset: 0x2A98424 VA: 0x2A9C424
	|-Dictionary.KeyCollection<PartyManager.PartyData.pair, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7A4C8 Offset: 0x2A764C8 VA: 0x2A7A4C8
	|-Dictionary.KeyCollection<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A7AAE4 Offset: 0x2A76AE4 VA: 0x2A7AAE4
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A7B10C Offset: 0x2A7710C VA: 0x2A7B10C
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A7B730 Offset: 0x2A77730 VA: 0x2A7B730
	|-Dictionary.KeyCollection<ArchetypeUid, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A7BD48 Offset: 0x2A77D48 VA: 0x2A7BD48
	|-Dictionary.KeyCollection<ArchetypeUid, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A7C360 Offset: 0x2A78360 VA: 0x2A7C360
	|-Dictionary.KeyCollection<byte, ValueTuple<short, int, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A7C978 Offset: 0x2A78978 VA: 0x2A7C978
	|-Dictionary.KeyCollection<byte, BlackKnightAvatarProperty>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A7CF90 Offset: 0x2A78F90 VA: 0x2A7CF90
	|-Dictionary.KeyCollection<byte, BlackKnightCristaProperty>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A7D5A8 Offset: 0x2A795A8 VA: 0x2A7D5A8
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A7DBC0 Offset: 0x2A79BC0 VA: 0x2A7DBC0
	|-Dictionary.KeyCollection<byte, CardData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A7E1D8 Offset: 0x2A7A1D8 VA: 0x2A7E1D8
	|-Dictionary.KeyCollection<byte, short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A7E7F0 Offset: 0x2A7A7F0 VA: 0x2A7E7F0
	|-Dictionary.KeyCollection<byte, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A7EE08 Offset: 0x2A7AE08 VA: 0x2A7EE08
	|-Dictionary.KeyCollection<byte, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A7F420 Offset: 0x2A7B420 VA: 0x2A7F420
	|-Dictionary.KeyCollection<byte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8033C Offset: 0x2A7C33C VA: 0x2A8033C
	|-Dictionary.KeyCollection<byte, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A80954 Offset: 0x2A7C954 VA: 0x2A80954
	|-Dictionary.KeyCollection<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A80F6C Offset: 0x2A7CF6C VA: 0x2A80F6C
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A81584 Offset: 0x2A7D584 VA: 0x2A81584
	|-Dictionary.KeyCollection<char, char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A81B9C Offset: 0x2A7DB9C VA: 0x2A81B9C
	|-Dictionary.KeyCollection<DefencePoint2, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A82AA8 Offset: 0x2A7EAA8 VA: 0x2A82AA8
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A830CC Offset: 0x2A7F0CC VA: 0x2A830CC
	|-Dictionary.KeyCollection<short, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A836E4 Offset: 0x2A7F6E4 VA: 0x2A836E4
	|-Dictionary.KeyCollection<short, short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A83CFC Offset: 0x2A7FCFC VA: 0x2A83CFC
	|-Dictionary.KeyCollection<short, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A84314 Offset: 0x2A80314 VA: 0x2A84314
	|-Dictionary.KeyCollection<short, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8492C Offset: 0x2A8092C VA: 0x2A8492C
	|-Dictionary.KeyCollection<Int16Enum, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A84F44 Offset: 0x2A80F44 VA: 0x2A84F44
	|-Dictionary.KeyCollection<Int16Enum, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8555C Offset: 0x2A8155C VA: 0x2A8555C
	|-Dictionary.KeyCollection<Int16Enum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A85B74 Offset: 0x2A81B74 VA: 0x2A85B74
	|-Dictionary.KeyCollection<int, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8618C Offset: 0x2A8218C VA: 0x2A8618C
	|-Dictionary.KeyCollection<int, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A867A4 Offset: 0x2A827A4 VA: 0x2A867A4
	|-Dictionary.KeyCollection<int, Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A86DBC Offset: 0x2A82DBC VA: 0x2A86DBC
	|-Dictionary.KeyCollection<int, short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A873D4 Offset: 0x2A833D4 VA: 0x2A873D4
	|-Dictionary.KeyCollection<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A879EC Offset: 0x2A839EC VA: 0x2A879EC
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A88004 Offset: 0x2A84004 VA: 0x2A88004
	|-Dictionary.KeyCollection<int, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8861C Offset: 0x2A8461C VA: 0x2A8861C
	|-Dictionary.KeyCollection<int, MaterialSearchData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A88C34 Offset: 0x2A84C34 VA: 0x2A88C34
	|-Dictionary.KeyCollection<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8924C Offset: 0x2A8524C VA: 0x2A8924C
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A89864 Offset: 0x2A85864 VA: 0x2A89864
	|-Dictionary.KeyCollection<int, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A89E7C Offset: 0x2A85E7C VA: 0x2A89E7C
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8A494 Offset: 0x2A86494 VA: 0x2A8A494
	|-Dictionary.KeyCollection<int, Vector4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8AAAC Offset: 0x2A86AAC VA: 0x2A8AAAC
	|-Dictionary.KeyCollection<int, HouseRecipeManager.RecipeData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8B0C4 Offset: 0x2A870C4 VA: 0x2A8B0C4
	|-Dictionary.KeyCollection<int, MasterModelDataManager.ColorListData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8B6DC Offset: 0x2A876DC VA: 0x2A8B6DC
	|-Dictionary.KeyCollection<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8BCF4 Offset: 0x2A87CF4 VA: 0x2A8BCF4
	|-Dictionary.KeyCollection<Int32Enum, ArchetypeUid>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8C30C Offset: 0x2A8830C VA: 0x2A8C30C
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8C924 Offset: 0x2A88924 VA: 0x2A8C924
	|-Dictionary.KeyCollection<Int32Enum, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8CF3C Offset: 0x2A88F3C VA: 0x2A8CF3C
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8D554 Offset: 0x2A89554 VA: 0x2A8D554
	|-Dictionary.KeyCollection<Int32Enum, DateTime>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8DB6C Offset: 0x2A89B6C VA: 0x2A8DB6C
	|-Dictionary.KeyCollection<Int32Enum, EnhanceProperties2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8E184 Offset: 0x2A8A184 VA: 0x2A8E184
	|-Dictionary.KeyCollection<Int32Enum, short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8E79C Offset: 0x2A8A79C VA: 0x2A8E79C
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8EDB4 Offset: 0x2A8ADB4 VA: 0x2A8EDB4
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8F3CC Offset: 0x2A8B3CC VA: 0x2A8F3CC
	|-Dictionary.KeyCollection<Int32Enum, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8F9E4 Offset: 0x2A8B9E4 VA: 0x2A8F9E4
	|-Dictionary.KeyCollection<Int32Enum, Int64Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8FFFC Offset: 0x2A8BFFC VA: 0x2A8FFFC
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A90614 Offset: 0x2A8C614 VA: 0x2A90614
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A90C2C Offset: 0x2A8CC2C VA: 0x2A90C2C
	|-Dictionary.KeyCollection<Int32Enum, Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A91244 Offset: 0x2A8D244 VA: 0x2A91244
	|-Dictionary.KeyCollection<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A9185C Offset: 0x2A8D85C VA: 0x2A9185C
	|-Dictionary.KeyCollection<long, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A91E74 Offset: 0x2A8DE74 VA: 0x2A91E74
	|-Dictionary.KeyCollection<long, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A9248C Offset: 0x2A8E48C VA: 0x2A9248C
	|-Dictionary.KeyCollection<long, short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A92AA4 Offset: 0x2A8EAA4 VA: 0x2A92AA4
	|-Dictionary.KeyCollection<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A930BC Offset: 0x2A8F0BC VA: 0x2A930BC
	|-Dictionary.KeyCollection<Int64Enum, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A936D4 Offset: 0x2A8F6D4 VA: 0x2A936D4
	|-Dictionary.KeyCollection<Int64Enum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A93CEC Offset: 0x2A8FCEC VA: 0x2A93CEC
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A94314 Offset: 0x2A90314 VA: 0x2A94314
	|-Dictionary.KeyCollection<object, ValueTuple<object, byte>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A94920 Offset: 0x2A90920 VA: 0x2A94920
	|-Dictionary.KeyCollection<object, ValueTuple<float, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A94F2C Offset: 0x2A90F2C VA: 0x2A94F2C
	|-Dictionary.KeyCollection<object, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A95538 Offset: 0x2A91538 VA: 0x2A95538
	|-Dictionary.KeyCollection<object, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A95B44 Offset: 0x2A91B44 VA: 0x2A95B44
	|-Dictionary.KeyCollection<object, short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A96150 Offset: 0x2A92150 VA: 0x2A96150
	|-Dictionary.KeyCollection<object, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A9675C Offset: 0x2A9275C VA: 0x2A9675C
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A96D68 Offset: 0x2A92D68 VA: 0x2A96D68
	|-Dictionary.KeyCollection<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A97374 Offset: 0x2A93374 VA: 0x2A97374
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A97980 Offset: 0x2A93980 VA: 0x2A97980
	|-Dictionary.KeyCollection<object, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A97F8C Offset: 0x2A93F8C VA: 0x2A97F8C
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A98598 Offset: 0x2A94598 VA: 0x2A98598
	|-Dictionary.KeyCollection<object, DeathReceptionAction.PoisonTargetData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A98BA4 Offset: 0x2A94BA4 VA: 0x2A98BA4
	|-Dictionary.KeyCollection<object, UIHouseAddressManager.Town>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A991A0 Offset: 0x2A951A0 VA: 0x2A991A0
	|-Dictionary.KeyCollection<ushort, byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A997BC Offset: 0x2A957BC VA: 0x2A997BC
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A9A0F0 Offset: 0x2A960F0 VA: 0x2A9A0F0
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A9B7C0 Offset: 0x2A977C0 VA: 0x2A9B7C0
	|-Dictionary.KeyCollection<MaterialManager.pair, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A9BE54 Offset: 0x2A97E54 VA: 0x2A9BE54
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A9C480 Offset: 0x2A98480 VA: 0x2A9C480
	|-Dictionary.KeyCollection<PartyManager.PartyData.pair, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7A798 Offset: 0x2A76798 VA: 0x2A7A798
	|-Dictionary.KeyCollection<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A7ADC0 Offset: 0x2A76DC0 VA: 0x2A7ADC0
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A7B3E8 Offset: 0x2A773E8 VA: 0x2A7B3E8
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A7BA00 Offset: 0x2A77A00 VA: 0x2A7BA00
	|-Dictionary.KeyCollection<ArchetypeUid, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A7C018 Offset: 0x2A78018 VA: 0x2A7C018
	|-Dictionary.KeyCollection<ArchetypeUid, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A7C630 Offset: 0x2A78630 VA: 0x2A7C630
	|-Dictionary.KeyCollection<byte, ValueTuple<short, int, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A7CC48 Offset: 0x2A78C48 VA: 0x2A7CC48
	|-Dictionary.KeyCollection<byte, BlackKnightAvatarProperty>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A7D260 Offset: 0x2A79260 VA: 0x2A7D260
	|-Dictionary.KeyCollection<byte, BlackKnightCristaProperty>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A7D878 Offset: 0x2A79878 VA: 0x2A7D878
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A7DE90 Offset: 0x2A79E90 VA: 0x2A7DE90
	|-Dictionary.KeyCollection<byte, CardData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A7E4A8 Offset: 0x2A7A4A8 VA: 0x2A7E4A8
	|-Dictionary.KeyCollection<byte, short>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A7EAC0 Offset: 0x2A7AAC0 VA: 0x2A7EAC0
	|-Dictionary.KeyCollection<byte, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A7F0D8 Offset: 0x2A7B0D8 VA: 0x2A7F0D8
	|-Dictionary.KeyCollection<byte, long>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A7F6F0 Offset: 0x2A7B6F0 VA: 0x2A7F6F0
	|-Dictionary.KeyCollection<byte, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8060C Offset: 0x2A7C60C VA: 0x2A8060C
	|-Dictionary.KeyCollection<byte, float>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A80C24 Offset: 0x2A7CC24 VA: 0x2A80C24
	|-Dictionary.KeyCollection<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8123C Offset: 0x2A7D23C VA: 0x2A8123C
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A81854 Offset: 0x2A7D854 VA: 0x2A81854
	|-Dictionary.KeyCollection<char, char>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A81E6C Offset: 0x2A7DE6C VA: 0x2A81E6C
	|-Dictionary.KeyCollection<DefencePoint2, byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A82D84 Offset: 0x2A7ED84 VA: 0x2A82D84
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8339C Offset: 0x2A7F39C VA: 0x2A8339C
	|-Dictionary.KeyCollection<short, byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A839B4 Offset: 0x2A7F9B4 VA: 0x2A839B4
	|-Dictionary.KeyCollection<short, short>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A83FCC Offset: 0x2A7FFCC VA: 0x2A83FCC
	|-Dictionary.KeyCollection<short, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A845E4 Offset: 0x2A805E4 VA: 0x2A845E4
	|-Dictionary.KeyCollection<short, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A84BFC Offset: 0x2A80BFC VA: 0x2A84BFC
	|-Dictionary.KeyCollection<Int16Enum, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A85214 Offset: 0x2A81214 VA: 0x2A85214
	|-Dictionary.KeyCollection<Int16Enum, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8582C Offset: 0x2A8182C VA: 0x2A8582C
	|-Dictionary.KeyCollection<Int16Enum, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A85E44 Offset: 0x2A81E44 VA: 0x2A85E44
	|-Dictionary.KeyCollection<int, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8645C Offset: 0x2A8245C VA: 0x2A8645C
	|-Dictionary.KeyCollection<int, byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A86A74 Offset: 0x2A82A74 VA: 0x2A86A74
	|-Dictionary.KeyCollection<int, Color>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8708C Offset: 0x2A8308C VA: 0x2A8708C
	|-Dictionary.KeyCollection<int, short>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A876A4 Offset: 0x2A836A4 VA: 0x2A876A4
	|-Dictionary.KeyCollection<int, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A87CBC Offset: 0x2A83CBC VA: 0x2A87CBC
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A882D4 Offset: 0x2A842D4 VA: 0x2A882D4
	|-Dictionary.KeyCollection<int, long>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A888EC Offset: 0x2A848EC VA: 0x2A888EC
	|-Dictionary.KeyCollection<int, MaterialSearchData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A88F04 Offset: 0x2A84F04 VA: 0x2A88F04
	|-Dictionary.KeyCollection<int, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8951C Offset: 0x2A8551C VA: 0x2A8951C
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A89B34 Offset: 0x2A85B34 VA: 0x2A89B34
	|-Dictionary.KeyCollection<int, float>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8A14C Offset: 0x2A8614C VA: 0x2A8A14C
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8A764 Offset: 0x2A86764 VA: 0x2A8A764
	|-Dictionary.KeyCollection<int, Vector4>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8AD7C Offset: 0x2A86D7C VA: 0x2A8AD7C
	|-Dictionary.KeyCollection<int, HouseRecipeManager.RecipeData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8B394 Offset: 0x2A87394 VA: 0x2A8B394
	|-Dictionary.KeyCollection<int, MasterModelDataManager.ColorListData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8B9AC Offset: 0x2A879AC VA: 0x2A8B9AC
	|-Dictionary.KeyCollection<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8BFC4 Offset: 0x2A87FC4 VA: 0x2A8BFC4
	|-Dictionary.KeyCollection<Int32Enum, ArchetypeUid>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8C5DC Offset: 0x2A885DC VA: 0x2A8C5DC
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8CBF4 Offset: 0x2A88BF4 VA: 0x2A8CBF4
	|-Dictionary.KeyCollection<Int32Enum, byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8D20C Offset: 0x2A8920C VA: 0x2A8D20C
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8D824 Offset: 0x2A89824 VA: 0x2A8D824
	|-Dictionary.KeyCollection<Int32Enum, DateTime>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8DE3C Offset: 0x2A89E3C VA: 0x2A8DE3C
	|-Dictionary.KeyCollection<Int32Enum, EnhanceProperties2>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8E454 Offset: 0x2A8A454 VA: 0x2A8E454
	|-Dictionary.KeyCollection<Int32Enum, short>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8EA6C Offset: 0x2A8AA6C VA: 0x2A8EA6C
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8F084 Offset: 0x2A8B084 VA: 0x2A8F084
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8F69C Offset: 0x2A8B69C VA: 0x2A8F69C
	|-Dictionary.KeyCollection<Int32Enum, long>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8FCB4 Offset: 0x2A8BCB4 VA: 0x2A8FCB4
	|-Dictionary.KeyCollection<Int32Enum, Int64Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A902CC Offset: 0x2A8C2CC VA: 0x2A902CC
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A908E4 Offset: 0x2A8C8E4 VA: 0x2A908E4
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A90EFC Offset: 0x2A8CEFC VA: 0x2A90EFC
	|-Dictionary.KeyCollection<Int32Enum, Vector3>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A91514 Offset: 0x2A8D514 VA: 0x2A91514
	|-Dictionary.KeyCollection<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A91B2C Offset: 0x2A8DB2C VA: 0x2A91B2C
	|-Dictionary.KeyCollection<long, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A92144 Offset: 0x2A8E144 VA: 0x2A92144
	|-Dictionary.KeyCollection<long, byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A9275C Offset: 0x2A8E75C VA: 0x2A9275C
	|-Dictionary.KeyCollection<long, short>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A92D74 Offset: 0x2A8ED74 VA: 0x2A92D74
	|-Dictionary.KeyCollection<long, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A9338C Offset: 0x2A8F38C VA: 0x2A9338C
	|-Dictionary.KeyCollection<Int64Enum, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A939A4 Offset: 0x2A8F9A4 VA: 0x2A939A4
	|-Dictionary.KeyCollection<Int64Enum, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A93FBC Offset: 0x2A8FFBC VA: 0x2A93FBC
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A945C8 Offset: 0x2A905C8 VA: 0x2A945C8
	|-Dictionary.KeyCollection<object, ValueTuple<object, byte>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A94BD4 Offset: 0x2A90BD4 VA: 0x2A94BD4
	|-Dictionary.KeyCollection<object, ValueTuple<float, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A951E0 Offset: 0x2A911E0 VA: 0x2A951E0
	|-Dictionary.KeyCollection<object, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A957EC Offset: 0x2A917EC VA: 0x2A957EC
	|-Dictionary.KeyCollection<object, byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A95DF8 Offset: 0x2A91DF8 VA: 0x2A95DF8
	|-Dictionary.KeyCollection<object, short>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A96404 Offset: 0x2A92404 VA: 0x2A96404
	|-Dictionary.KeyCollection<object, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A96A10 Offset: 0x2A92A10 VA: 0x2A96A10
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A9701C Offset: 0x2A9301C VA: 0x2A9701C
	|-Dictionary.KeyCollection<object, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A97628 Offset: 0x2A93628 VA: 0x2A97628
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A97C34 Offset: 0x2A93C34 VA: 0x2A97C34
	|-Dictionary.KeyCollection<object, float>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A98240 Offset: 0x2A94240 VA: 0x2A98240
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A9884C Offset: 0x2A9484C VA: 0x2A9884C
	|-Dictionary.KeyCollection<object, DeathReceptionAction.PoisonTargetData>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A98E58 Offset: 0x2A94E58 VA: 0x2A98E58
	|-Dictionary.KeyCollection<object, UIHouseAddressManager.Town>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A99470 Offset: 0x2A95470 VA: 0x2A99470
	|-Dictionary.KeyCollection<ushort, byte>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A99A98 Offset: 0x2A95A98 VA: 0x2A99A98
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A9A480 Offset: 0x2A96480 VA: 0x2A9A480
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A9BA90 Offset: 0x2A97A90 VA: 0x2A9BA90
	|-Dictionary.KeyCollection<MaterialManager.pair, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A9C138 Offset: 0x2A98138 VA: 0x2A9C138
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A9C750 Offset: 0x2A98750 VA: 0x2A9C750
	|-Dictionary.KeyCollection<PartyManager.PartyData.pair, object>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7A7A0 Offset: 0x2A767A0 VA: 0x2A7A7A0
	|-Dictionary.KeyCollection<KeyValuePair<Int32Enum, int>, KeyValuePair<Int32Enum, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A7ADC8 Offset: 0x2A76DC8 VA: 0x2A7ADC8
	|-Dictionary.KeyCollection<KeyValuePair<object, object>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A7B3F0 Offset: 0x2A773F0 VA: 0x2A7B3F0
	|-Dictionary.KeyCollection<ValueTuple<object, object>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A7BA08 Offset: 0x2A77A08 VA: 0x2A7BA08
	|-Dictionary.KeyCollection<ArchetypeUid, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A7C020 Offset: 0x2A78020 VA: 0x2A7C020
	|-Dictionary.KeyCollection<ArchetypeUid, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A7C638 Offset: 0x2A78638 VA: 0x2A7C638
	|-Dictionary.KeyCollection<byte, ValueTuple<short, int, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A7CC50 Offset: 0x2A78C50 VA: 0x2A7CC50
	|-Dictionary.KeyCollection<byte, BlackKnightAvatarProperty>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A7D268 Offset: 0x2A79268 VA: 0x2A7D268
	|-Dictionary.KeyCollection<byte, BlackKnightCristaProperty>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A7D880 Offset: 0x2A79880 VA: 0x2A7D880
	|-Dictionary.KeyCollection<byte, byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A7DE98 Offset: 0x2A79E98 VA: 0x2A7DE98
	|-Dictionary.KeyCollection<byte, CardData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A7E4B0 Offset: 0x2A7A4B0 VA: 0x2A7E4B0
	|-Dictionary.KeyCollection<byte, short>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A7EAC8 Offset: 0x2A7AAC8 VA: 0x2A7EAC8
	|-Dictionary.KeyCollection<byte, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A7F0E0 Offset: 0x2A7B0E0 VA: 0x2A7F0E0
	|-Dictionary.KeyCollection<byte, long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A7F6F8 Offset: 0x2A7B6F8 VA: 0x2A7F6F8
	|-Dictionary.KeyCollection<byte, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A80614 Offset: 0x2A7C614 VA: 0x2A80614
	|-Dictionary.KeyCollection<byte, float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A80C2C Offset: 0x2A7CC2C VA: 0x2A80C2C
	|-Dictionary.KeyCollection<byte, MasterModelDataManager.ConvertCommonMaterialData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A81244 Offset: 0x2A7D244 VA: 0x2A81244
	|-Dictionary.KeyCollection<ByteEnum, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8185C Offset: 0x2A7D85C VA: 0x2A8185C
	|-Dictionary.KeyCollection<char, char>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A81E74 Offset: 0x2A7DE74 VA: 0x2A81E74
	|-Dictionary.KeyCollection<DefencePoint2, byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A82D8C Offset: 0x2A7ED8C VA: 0x2A82D8C
	|-Dictionary.KeyCollection<Guid, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A833A4 Offset: 0x2A7F3A4 VA: 0x2A833A4
	|-Dictionary.KeyCollection<short, byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A839BC Offset: 0x2A7F9BC VA: 0x2A839BC
	|-Dictionary.KeyCollection<short, short>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A83FD4 Offset: 0x2A7FFD4 VA: 0x2A83FD4
	|-Dictionary.KeyCollection<short, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A845EC Offset: 0x2A805EC VA: 0x2A845EC
	|-Dictionary.KeyCollection<short, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A84C04 Offset: 0x2A80C04 VA: 0x2A84C04
	|-Dictionary.KeyCollection<Int16Enum, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8521C Offset: 0x2A8121C VA: 0x2A8521C
	|-Dictionary.KeyCollection<Int16Enum, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A85834 Offset: 0x2A81834 VA: 0x2A85834
	|-Dictionary.KeyCollection<Int16Enum, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A85E4C Offset: 0x2A81E4C VA: 0x2A85E4C
	|-Dictionary.KeyCollection<int, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A86464 Offset: 0x2A82464 VA: 0x2A86464
	|-Dictionary.KeyCollection<int, byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A86A7C Offset: 0x2A82A7C VA: 0x2A86A7C
	|-Dictionary.KeyCollection<int, Color>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A87094 Offset: 0x2A83094 VA: 0x2A87094
	|-Dictionary.KeyCollection<int, short>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A876AC Offset: 0x2A836AC VA: 0x2A876AC
	|-Dictionary.KeyCollection<int, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A87CC4 Offset: 0x2A83CC4 VA: 0x2A87CC4
	|-Dictionary.KeyCollection<int, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A882DC Offset: 0x2A842DC VA: 0x2A882DC
	|-Dictionary.KeyCollection<int, long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A888F4 Offset: 0x2A848F4 VA: 0x2A888F4
	|-Dictionary.KeyCollection<int, MaterialSearchData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A88F0C Offset: 0x2A84F0C VA: 0x2A88F0C
	|-Dictionary.KeyCollection<int, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A89524 Offset: 0x2A85524 VA: 0x2A89524
	|-Dictionary.KeyCollection<int, RenderInstancedDataLayout>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A89B3C Offset: 0x2A85B3C VA: 0x2A89B3C
	|-Dictionary.KeyCollection<int, float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8A154 Offset: 0x2A86154 VA: 0x2A8A154
	|-Dictionary.KeyCollection<int, Vector3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8A76C Offset: 0x2A8676C VA: 0x2A8A76C
	|-Dictionary.KeyCollection<int, Vector4>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8AD84 Offset: 0x2A86D84 VA: 0x2A8AD84
	|-Dictionary.KeyCollection<int, HouseRecipeManager.RecipeData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8B39C Offset: 0x2A8739C VA: 0x2A8B39C
	|-Dictionary.KeyCollection<int, MasterModelDataManager.ColorListData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8B9B4 Offset: 0x2A879B4 VA: 0x2A8B9B4
	|-Dictionary.KeyCollection<int, UIGuildQuestBoardManager.GuildQuestMaseter>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8BFCC Offset: 0x2A87FCC VA: 0x2A8BFCC
	|-Dictionary.KeyCollection<Int32Enum, ArchetypeUid>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8C5E4 Offset: 0x2A885E4 VA: 0x2A8C5E4
	|-Dictionary.KeyCollection<Int32Enum, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8CBFC Offset: 0x2A88BFC VA: 0x2A8CBFC
	|-Dictionary.KeyCollection<Int32Enum, byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8D214 Offset: 0x2A89214 VA: 0x2A8D214
	|-Dictionary.KeyCollection<Int32Enum, Color>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8D82C Offset: 0x2A8982C VA: 0x2A8D82C
	|-Dictionary.KeyCollection<Int32Enum, DateTime>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8DE44 Offset: 0x2A89E44 VA: 0x2A8DE44
	|-Dictionary.KeyCollection<Int32Enum, EnhanceProperties2>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8E45C Offset: 0x2A8A45C VA: 0x2A8E45C
	|-Dictionary.KeyCollection<Int32Enum, short>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8EA74 Offset: 0x2A8AA74 VA: 0x2A8EA74
	|-Dictionary.KeyCollection<Int32Enum, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8F08C Offset: 0x2A8B08C VA: 0x2A8F08C
	|-Dictionary.KeyCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8F6A4 Offset: 0x2A8B6A4 VA: 0x2A8F6A4
	|-Dictionary.KeyCollection<Int32Enum, long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8FCBC Offset: 0x2A8BCBC VA: 0x2A8FCBC
	|-Dictionary.KeyCollection<Int32Enum, Int64Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A902D4 Offset: 0x2A8C2D4 VA: 0x2A902D4
	|-Dictionary.KeyCollection<Int32Enum, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A908EC Offset: 0x2A8C8EC VA: 0x2A908EC
	|-Dictionary.KeyCollection<Int32Enum, float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A90F04 Offset: 0x2A8CF04 VA: 0x2A90F04
	|-Dictionary.KeyCollection<Int32Enum, Vector3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A9151C Offset: 0x2A8D51C VA: 0x2A9151C
	|-Dictionary.KeyCollection<Int32Enum, MasterModelDataManager.ColorListData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A91B34 Offset: 0x2A8DB34 VA: 0x2A91B34
	|-Dictionary.KeyCollection<long, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A9214C Offset: 0x2A8E14C VA: 0x2A9214C
	|-Dictionary.KeyCollection<long, byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A92764 Offset: 0x2A8E764 VA: 0x2A92764
	|-Dictionary.KeyCollection<long, short>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A92D7C Offset: 0x2A8ED7C VA: 0x2A92D7C
	|-Dictionary.KeyCollection<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A93394 Offset: 0x2A8F394 VA: 0x2A93394
	|-Dictionary.KeyCollection<Int64Enum, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A939AC Offset: 0x2A8F9AC VA: 0x2A939AC
	|-Dictionary.KeyCollection<Int64Enum, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A93FC4 Offset: 0x2A8FFC4 VA: 0x2A93FC4
	|-Dictionary.KeyCollection<IntPtr, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A945D0 Offset: 0x2A905D0 VA: 0x2A945D0
	|-Dictionary.KeyCollection<object, ValueTuple<object, byte>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A94BDC Offset: 0x2A90BDC VA: 0x2A94BDC
	|-Dictionary.KeyCollection<object, ValueTuple<float, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A951E8 Offset: 0x2A911E8 VA: 0x2A951E8
	|-Dictionary.KeyCollection<object, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A957F4 Offset: 0x2A917F4 VA: 0x2A957F4
	|-Dictionary.KeyCollection<object, byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A95E00 Offset: 0x2A91E00 VA: 0x2A95E00
	|-Dictionary.KeyCollection<object, short>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A9640C Offset: 0x2A9240C VA: 0x2A9640C
	|-Dictionary.KeyCollection<object, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A96A18 Offset: 0x2A92A18 VA: 0x2A96A18
	|-Dictionary.KeyCollection<object, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A97024 Offset: 0x2A93024 VA: 0x2A97024
	|-Dictionary.KeyCollection<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A97630 Offset: 0x2A93630 VA: 0x2A97630
	|-Dictionary.KeyCollection<object, ResourceLocator>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A97C3C Offset: 0x2A93C3C VA: 0x2A97C3C
	|-Dictionary.KeyCollection<object, float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A98248 Offset: 0x2A94248 VA: 0x2A98248
	|-Dictionary.KeyCollection<object, Vector3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A98854 Offset: 0x2A94854 VA: 0x2A98854
	|-Dictionary.KeyCollection<object, DeathReceptionAction.PoisonTargetData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A98E60 Offset: 0x2A94E60 VA: 0x2A98E60
	|-Dictionary.KeyCollection<object, UIHouseAddressManager.Town>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A99478 Offset: 0x2A95478 VA: 0x2A99478
	|-Dictionary.KeyCollection<ushort, byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A99AA0 Offset: 0x2A95AA0 VA: 0x2A99AA0
	|-Dictionary.KeyCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A9A488 Offset: 0x2A96488 VA: 0x2A9A488
	|-Dictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A9BA98 Offset: 0x2A97A98 VA: 0x2A9BA98
	|-Dictionary.KeyCollection<MaterialManager.pair, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A9C140 Offset: 0x2A98140 VA: 0x2A9C140
	|-Dictionary.KeyCollection<Regex.CachedCodeEntryKey, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A9C758 Offset: 0x2A98758 VA: 0x2A9C758
	|-Dictionary.KeyCollection<PartyManager.PartyData.pair, object>.System.Collections.ICollection.get_SyncRoot
	*/
}
