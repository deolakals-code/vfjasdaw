// Assembly: mscorlib.dll
// Namespace: System
[NonVersionable]
[Serializable]
public struct Nullable<T> // TypeDefIndex: 9641
{
	// Fields
	private readonly bool hasValue; // 0x0
	internal T value; // 0x0

	// Properties
	public bool HasValue { get; }
	public T Value { get; }

	// Methods

	[NonVersionable]
	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB466C Offset: 0x2BB066C VA: 0x2BB466C
	|-Nullable<BigInteger>..ctor
	|
	|-RVA: 0x2BB4B6C Offset: 0x2BB0B6C VA: 0x2BB4B6C
	|-Nullable<bool>..ctor
	|
	|-RVA: 0x2BB4FE0 Offset: 0x2BB0FE0 VA: 0x2BB4FE0
	|-Nullable<byte>..ctor
	|
	|-RVA: 0x2BB539C Offset: 0x2BB139C VA: 0x2BB539C
	|-Nullable<char>..ctor
	|
	|-RVA: 0x2BB5808 Offset: 0x2BB1808 VA: 0x2BB5808
	|-Nullable<DataKey>..ctor
	|
	|-RVA: 0x2BB5C24 Offset: 0x2BB1C24 VA: 0x2BB5C24
	|-Nullable<DateTime>..ctor
	|
	|-RVA: 0x2BB6080 Offset: 0x2BB2080 VA: 0x2BB6080
	|-Nullable<DateTimeOffset>..ctor
	|
	|-RVA: 0x2BB6550 Offset: 0x2BB2550 VA: 0x2BB6550
	|-Nullable<Decimal>..ctor
	|
	|-RVA: 0x2BB6A40 Offset: 0x2BB2A40 VA: 0x2BB6A40
	|-Nullable<double>..ctor
	|
	|-RVA: 0x2BB6DEC Offset: 0x2BB2DEC VA: 0x2BB6DEC
	|-Nullable<Guid>..ctor
	|
	|-RVA: 0x2BB7218 Offset: 0x2BB3218 VA: 0x2BB7218
	|-Nullable<short>..ctor
	|
	|-RVA: 0x2BB75D4 Offset: 0x2BB35D4 VA: 0x2BB75D4
	|-Nullable<int>..ctor
	|
	|-RVA: 0x2BB7990 Offset: 0x2BB3990 VA: 0x2BB7990
	|-Nullable<Int32Enum>..ctor
	|
	|-RVA: 0x2BB7D60 Offset: 0x2BB3D60 VA: 0x2BB7D60
	|-Nullable<long>..ctor
	|
	|-RVA: 0x2BB810C Offset: 0x2BB410C VA: 0x2BB810C
	|-Nullable<JsonPosition>..ctor
	|
	|-RVA: 0x2BB8620 Offset: 0x2BB4620 VA: 0x2BB8620
	|-Nullable<LocalDefinition>..ctor
	|
	|-RVA: 0x2BB8A94 Offset: 0x2BB4A94 VA: 0x2BB8A94
	|-Nullable<RegexPrefix>..ctor
	|
	|-RVA: 0x2BB9BB4 Offset: 0x2BB5BB4 VA: 0x2BB9BB4
	|-Nullable<sbyte>..ctor
	|
	|-RVA: 0x2BB9F70 Offset: 0x2BB5F70 VA: 0x2BB9F70
	|-Nullable<float>..ctor
	|
	|-RVA: 0x2BBA324 Offset: 0x2BB6324 VA: 0x2BBA324
	|-Nullable<SkillIdData>..ctor
	|
	|-RVA: 0x2BBA778 Offset: 0x2BB6778 VA: 0x2BBA778
	|-Nullable<SqlBinary>..ctor
	|
	|-RVA: 0x2BBAC24 Offset: 0x2BB6C24 VA: 0x2BBAC24
	|-Nullable<StreamingContext>..ctor
	|
	|-RVA: 0x2BBB088 Offset: 0x2BB7088 VA: 0x2BBB088
	|-Nullable<TimeSpan>..ctor
	|
	|-RVA: 0x2BBB4E4 Offset: 0x2BB74E4 VA: 0x2BBB4E4
	|-Nullable<ushort>..ctor
	|
	|-RVA: 0x2BBB8A0 Offset: 0x2BB78A0 VA: 0x2BBB8A0
	|-Nullable<uint>..ctor
	|
	|-RVA: 0x2BBBC5C Offset: 0x2BB7C5C VA: 0x2BBBC5C
	|-Nullable<ulong>..ctor
	|
	|-RVA: 0x2BBC008 Offset: 0x2BB8008 VA: 0x2BBC008
	|-Nullable<Vector3>..ctor
	|
	|-RVA: 0x2BBC480 Offset: 0x2BB8480 VA: 0x2BBC480
	|-Nullable<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x2BBD3A0 Offset: 0x2BB93A0 VA: 0x2BBD3A0
	|-Nullable<KadarElexioBuf.SkillIdData>..ctor
	|
	|-RVA: 0x2BBD7F4 Offset: 0x2BB97F4 VA: 0x2BBD7F4
	|-Nullable<TimeZoneInfo.TransitionTime>..ctor
	|
	|-RVA: 0x2BBDC80 Offset: 0x2BB9C80 VA: 0x2BBDC80
	|-Nullable<TreasureHuntRoomData.CacheSyncData>..ctor
	|
	|-RVA: 0x2BBE0E8 Offset: 0x2BBA0E8 VA: 0x2BBE0E8
	|-Nullable<TrophyManager.TrophyData>..ctor
	|
	|-RVA: 0x2BBE53C Offset: 0x2BBA53C VA: 0x2BBE53C
	|-Nullable<UIMobPropertyLabel.IconValue>..ctor
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public bool get_HasValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB4694 Offset: 0x2BB0694 VA: 0x2BB4694
	|-Nullable<BigInteger>.get_HasValue
	|
	|-RVA: 0x2BB4B80 Offset: 0x2BB0B80 VA: 0x2BB4B80
	|-Nullable<bool>.get_HasValue
	|
	|-RVA: 0x2BB4FF0 Offset: 0x2BB0FF0 VA: 0x2BB4FF0
	|-Nullable<byte>.get_HasValue
	|
	|-RVA: 0x2BB53AC Offset: 0x2BB13AC VA: 0x2BB53AC
	|-Nullable<char>.get_HasValue
	|
	|-RVA: 0x2BB582C Offset: 0x2BB182C VA: 0x2BB582C
	|-Nullable<DataKey>.get_HasValue
	|
	|-RVA: 0x2BB5C34 Offset: 0x2BB1C34 VA: 0x2BB5C34
	|-Nullable<DateTime>.get_HasValue
	|
	|-RVA: 0x2BB6090 Offset: 0x2BB2090 VA: 0x2BB6090
	|-Nullable<DateTimeOffset>.get_HasValue
	|
	|-RVA: 0x2BB6560 Offset: 0x2BB2560 VA: 0x2BB6560
	|-Nullable<Decimal>.get_HasValue
	|
	|-RVA: 0x2BB6A50 Offset: 0x2BB2A50 VA: 0x2BB6A50
	|-Nullable<double>.get_HasValue
	|
	|-RVA: 0x2BB6E00 Offset: 0x2BB2E00 VA: 0x2BB6E00
	|-Nullable<Guid>.get_HasValue
	|
	|-RVA: 0x2BB7228 Offset: 0x2BB3228 VA: 0x2BB7228
	|-Nullable<short>.get_HasValue
	|
	|-RVA: 0x2BB75E4 Offset: 0x2BB35E4 VA: 0x2BB75E4
	|-Nullable<int>.get_HasValue
	|
	|-RVA: 0x2BB79A0 Offset: 0x2BB39A0 VA: 0x2BB79A0
	|-Nullable<Int32Enum>.get_HasValue
	|
	|-RVA: 0x2BB7D70 Offset: 0x2BB3D70 VA: 0x2BB7D70
	|-Nullable<long>.get_HasValue
	|
	|-RVA: 0x2BB8140 Offset: 0x2BB4140 VA: 0x2BB8140
	|-Nullable<JsonPosition>.get_HasValue
	|
	|-RVA: 0x2BB8648 Offset: 0x2BB4648 VA: 0x2BB8648
	|-Nullable<LocalDefinition>.get_HasValue
	|
	|-RVA: 0x2BB8ABC Offset: 0x2BB4ABC VA: 0x2BB8ABC
	|-Nullable<RegexPrefix>.get_HasValue
	|
	|-RVA: 0x2BB9BC4 Offset: 0x2BB5BC4 VA: 0x2BB9BC4
	|-Nullable<sbyte>.get_HasValue
	|
	|-RVA: 0x2BB9F80 Offset: 0x2BB5F80 VA: 0x2BB9F80
	|-Nullable<float>.get_HasValue
	|
	|-RVA: 0x2BBA334 Offset: 0x2BB6334 VA: 0x2BBA334
	|-Nullable<SkillIdData>.get_HasValue
	|
	|-RVA: 0x2BBA79C Offset: 0x2BB679C VA: 0x2BBA79C
	|-Nullable<SqlBinary>.get_HasValue
	|
	|-RVA: 0x2BBAC4C Offset: 0x2BB6C4C VA: 0x2BBAC4C
	|-Nullable<StreamingContext>.get_HasValue
	|
	|-RVA: 0x2BBB098 Offset: 0x2BB7098 VA: 0x2BBB098
	|-Nullable<TimeSpan>.get_HasValue
	|
	|-RVA: 0x2BBB4F4 Offset: 0x2BB74F4 VA: 0x2BBB4F4
	|-Nullable<ushort>.get_HasValue
	|
	|-RVA: 0x2BBB8B0 Offset: 0x2BB78B0 VA: 0x2BBB8B0
	|-Nullable<uint>.get_HasValue
	|
	|-RVA: 0x2BBBC6C Offset: 0x2BB7C6C VA: 0x2BBBC6C
	|-Nullable<ulong>.get_HasValue
	|
	|-RVA: 0x2BBC01C Offset: 0x2BB801C VA: 0x2BBC01C
	|-Nullable<Vector3>.get_HasValue
	|
	|-RVA: 0x2BBC590 Offset: 0x2BB8590 VA: 0x2BBC590
	|-Nullable<__Il2CppFullySharedGenericStructType>.get_HasValue
	|
	|-RVA: 0x2BBD3B0 Offset: 0x2BB93B0 VA: 0x2BBD3B0
	|-Nullable<KadarElexioBuf.SkillIdData>.get_HasValue
	|
	|-RVA: 0x2BBD810 Offset: 0x2BB9810 VA: 0x2BBD810
	|-Nullable<TimeZoneInfo.TransitionTime>.get_HasValue
	|
	|-RVA: 0x2BBDC98 Offset: 0x2BB9C98 VA: 0x2BBDC98
	|-Nullable<TreasureHuntRoomData.CacheSyncData>.get_HasValue
	|
	|-RVA: 0x2BBE0F8 Offset: 0x2BBA0F8 VA: 0x2BBE0F8
	|-Nullable<TrophyManager.TrophyData>.get_HasValue
	|
	|-RVA: 0x2BBE570 Offset: 0x2BBA570 VA: 0x2BBE570
	|-Nullable<UIMobPropertyLabel.IconValue>.get_HasValue
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB469C Offset: 0x2BB069C VA: 0x2BB469C
	|-Nullable<BigInteger>.get_Value
	|
	|-RVA: 0x2BB4B88 Offset: 0x2BB0B88 VA: 0x2BB4B88
	|-Nullable<bool>.get_Value
	|
	|-RVA: 0x2BB4FF8 Offset: 0x2BB0FF8 VA: 0x2BB4FF8
	|-Nullable<byte>.get_Value
	|
	|-RVA: 0x2BB53B4 Offset: 0x2BB13B4 VA: 0x2BB53B4
	|-Nullable<char>.get_Value
	|
	|-RVA: 0x2BB5834 Offset: 0x2BB1834 VA: 0x2BB5834
	|-Nullable<DataKey>.get_Value
	|
	|-RVA: 0x2BB5C3C Offset: 0x2BB1C3C VA: 0x2BB5C3C
	|-Nullable<DateTime>.get_Value
	|
	|-RVA: 0x2BB6098 Offset: 0x2BB2098 VA: 0x2BB6098
	|-Nullable<DateTimeOffset>.get_Value
	|
	|-RVA: 0x2BB6568 Offset: 0x2BB2568 VA: 0x2BB6568
	|-Nullable<Decimal>.get_Value
	|
	|-RVA: 0x2BB6A58 Offset: 0x2BB2A58 VA: 0x2BB6A58
	|-Nullable<double>.get_Value
	|
	|-RVA: 0x2BB6E08 Offset: 0x2BB2E08 VA: 0x2BB6E08
	|-Nullable<Guid>.get_Value
	|
	|-RVA: 0x2BB7230 Offset: 0x2BB3230 VA: 0x2BB7230
	|-Nullable<short>.get_Value
	|
	|-RVA: 0x2BB75EC Offset: 0x2BB35EC VA: 0x2BB75EC
	|-Nullable<int>.get_Value
	|
	|-RVA: 0x2BB79A8 Offset: 0x2BB39A8 VA: 0x2BB79A8
	|-Nullable<Int32Enum>.get_Value
	|
	|-RVA: 0x2BB7D78 Offset: 0x2BB3D78 VA: 0x2BB7D78
	|-Nullable<long>.get_Value
	|
	|-RVA: 0x2BB8148 Offset: 0x2BB4148 VA: 0x2BB8148
	|-Nullable<JsonPosition>.get_Value
	|
	|-RVA: 0x2BB8650 Offset: 0x2BB4650 VA: 0x2BB8650
	|-Nullable<LocalDefinition>.get_Value
	|
	|-RVA: 0x2BB8AC4 Offset: 0x2BB4AC4 VA: 0x2BB8AC4
	|-Nullable<RegexPrefix>.get_Value
	|
	|-RVA: 0x2BB9BCC Offset: 0x2BB5BCC VA: 0x2BB9BCC
	|-Nullable<sbyte>.get_Value
	|
	|-RVA: 0x2BB9F88 Offset: 0x2BB5F88 VA: 0x2BB9F88
	|-Nullable<float>.get_Value
	|
	|-RVA: 0x2BBA33C Offset: 0x2BB633C VA: 0x2BBA33C
	|-Nullable<SkillIdData>.get_Value
	|
	|-RVA: 0x2BBA7A4 Offset: 0x2BB67A4 VA: 0x2BBA7A4
	|-Nullable<SqlBinary>.get_Value
	|
	|-RVA: 0x2BBAC54 Offset: 0x2BB6C54 VA: 0x2BBAC54
	|-Nullable<StreamingContext>.get_Value
	|
	|-RVA: 0x2BBB0A0 Offset: 0x2BB70A0 VA: 0x2BBB0A0
	|-Nullable<TimeSpan>.get_Value
	|
	|-RVA: 0x2BBB4FC Offset: 0x2BB74FC VA: 0x2BBB4FC
	|-Nullable<ushort>.get_Value
	|
	|-RVA: 0x2BBB8B8 Offset: 0x2BB78B8 VA: 0x2BBB8B8
	|-Nullable<uint>.get_Value
	|
	|-RVA: 0x2BBBC74 Offset: 0x2BB7C74 VA: 0x2BBBC74
	|-Nullable<ulong>.get_Value
	|
	|-RVA: 0x2BBC024 Offset: 0x2BB8024 VA: 0x2BBC024
	|-Nullable<Vector3>.get_Value
	|
	|-RVA: 0x2BBC5D0 Offset: 0x2BB85D0 VA: 0x2BBC5D0
	|-Nullable<__Il2CppFullySharedGenericStructType>.get_Value
	|
	|-RVA: 0x2BBD3B8 Offset: 0x2BB93B8 VA: 0x2BBD3B8
	|-Nullable<KadarElexioBuf.SkillIdData>.get_Value
	|
	|-RVA: 0x2BBD818 Offset: 0x2BB9818 VA: 0x2BBD818
	|-Nullable<TimeZoneInfo.TransitionTime>.get_Value
	|
	|-RVA: 0x2BBDCA0 Offset: 0x2BB9CA0 VA: 0x2BBDCA0
	|-Nullable<TreasureHuntRoomData.CacheSyncData>.get_Value
	|
	|-RVA: 0x2BBE100 Offset: 0x2BBA100 VA: 0x2BBE100
	|-Nullable<TrophyManager.TrophyData>.get_Value
	|
	|-RVA: 0x2BBE578 Offset: 0x2BBA578 VA: 0x2BBE578
	|-Nullable<UIMobPropertyLabel.IconValue>.get_Value
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public T GetValueOrDefault() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB46C0 Offset: 0x2BB06C0 VA: 0x2BB46C0
	|-Nullable<BigInteger>.GetValueOrDefault
	|
	|-RVA: 0x2BB4BAC Offset: 0x2BB0BAC VA: 0x2BB4BAC
	|-Nullable<bool>.GetValueOrDefault
	|
	|-RVA: 0x2BB501C Offset: 0x2BB101C VA: 0x2BB501C
	|-Nullable<byte>.GetValueOrDefault
	|
	|-RVA: 0x2BB53D8 Offset: 0x2BB13D8 VA: 0x2BB53D8
	|-Nullable<char>.GetValueOrDefault
	|
	|-RVA: 0x2BB5858 Offset: 0x2BB1858 VA: 0x2BB5858
	|-Nullable<DataKey>.GetValueOrDefault
	|
	|-RVA: 0x2BB5C60 Offset: 0x2BB1C60 VA: 0x2BB5C60
	|-Nullable<DateTime>.GetValueOrDefault
	|
	|-RVA: 0x2BB60BC Offset: 0x2BB20BC VA: 0x2BB60BC
	|-Nullable<DateTimeOffset>.GetValueOrDefault
	|
	|-RVA: 0x2BB658C Offset: 0x2BB258C VA: 0x2BB658C
	|-Nullable<Decimal>.GetValueOrDefault
	|
	|-RVA: 0x2BB6A7C Offset: 0x2BB2A7C VA: 0x2BB6A7C
	|-Nullable<double>.GetValueOrDefault
	|
	|-RVA: 0x2BB6E30 Offset: 0x2BB2E30 VA: 0x2BB6E30
	|-Nullable<Guid>.GetValueOrDefault
	|
	|-RVA: 0x2BB7254 Offset: 0x2BB3254 VA: 0x2BB7254
	|-Nullable<short>.GetValueOrDefault
	|
	|-RVA: 0x2BB7610 Offset: 0x2BB3610 VA: 0x2BB7610
	|-Nullable<int>.GetValueOrDefault
	|
	|-RVA: 0x2BB79CC Offset: 0x2BB39CC VA: 0x2BB79CC
	|-Nullable<Int32Enum>.GetValueOrDefault
	|
	|-RVA: 0x2BB7D9C Offset: 0x2BB3D9C VA: 0x2BB7D9C
	|-Nullable<long>.GetValueOrDefault
	|
	|-RVA: 0x2BB8184 Offset: 0x2BB4184 VA: 0x2BB8184
	|-Nullable<JsonPosition>.GetValueOrDefault
	|
	|-RVA: 0x2BB8674 Offset: 0x2BB4674 VA: 0x2BB8674
	|-Nullable<LocalDefinition>.GetValueOrDefault
	|
	|-RVA: 0x2BB8AE8 Offset: 0x2BB4AE8 VA: 0x2BB8AE8
	|-Nullable<RegexPrefix>.GetValueOrDefault
	|
	|-RVA: 0x2BB9BF0 Offset: 0x2BB5BF0 VA: 0x2BB9BF0
	|-Nullable<sbyte>.GetValueOrDefault
	|
	|-RVA: 0x2BB9FAC Offset: 0x2BB5FAC VA: 0x2BB9FAC
	|-Nullable<float>.GetValueOrDefault
	|
	|-RVA: 0x2BBA360 Offset: 0x2BB6360 VA: 0x2BBA360
	|-Nullable<SkillIdData>.GetValueOrDefault
	|
	|-RVA: 0x2BBA7C8 Offset: 0x2BB67C8 VA: 0x2BBA7C8
	|-Nullable<SqlBinary>.GetValueOrDefault
	|
	|-RVA: 0x2BBAC78 Offset: 0x2BB6C78 VA: 0x2BBAC78
	|-Nullable<StreamingContext>.GetValueOrDefault
	|
	|-RVA: 0x2BBB0C4 Offset: 0x2BB70C4 VA: 0x2BBB0C4
	|-Nullable<TimeSpan>.GetValueOrDefault
	|
	|-RVA: 0x2BBB520 Offset: 0x2BB7520 VA: 0x2BBB520
	|-Nullable<ushort>.GetValueOrDefault
	|
	|-RVA: 0x2BBB8DC Offset: 0x2BB78DC VA: 0x2BBB8DC
	|-Nullable<uint>.GetValueOrDefault
	|
	|-RVA: 0x2BBBC98 Offset: 0x2BB7C98 VA: 0x2BBBC98
	|-Nullable<ulong>.GetValueOrDefault
	|
	|-RVA: 0x2BBC04C Offset: 0x2BB804C VA: 0x2BBC04C
	|-Nullable<Vector3>.GetValueOrDefault
	|
	|-RVA: 0x2BBC6F4 Offset: 0x2BB86F4 VA: 0x2BBC6F4
	|-Nullable<__Il2CppFullySharedGenericStructType>.GetValueOrDefault
	|
	|-RVA: 0x2BBD3DC Offset: 0x2BB93DC VA: 0x2BBD3DC
	|-Nullable<KadarElexioBuf.SkillIdData>.GetValueOrDefault
	|
	|-RVA: 0x2BBD854 Offset: 0x2BB9854 VA: 0x2BBD854
	|-Nullable<TimeZoneInfo.TransitionTime>.GetValueOrDefault
	|
	|-RVA: 0x2BBDCCC Offset: 0x2BB9CCC VA: 0x2BBDCCC
	|-Nullable<TreasureHuntRoomData.CacheSyncData>.GetValueOrDefault
	|
	|-RVA: 0x2BBE124 Offset: 0x2BBA124 VA: 0x2BBE124
	|-Nullable<TrophyManager.TrophyData>.GetValueOrDefault
	|
	|-RVA: 0x2BBE5B4 Offset: 0x2BBA5B4 VA: 0x2BBE5B4
	|-Nullable<UIMobPropertyLabel.IconValue>.GetValueOrDefault
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public T GetValueOrDefault(T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB46CC Offset: 0x2BB06CC VA: 0x2BB46CC
	|-Nullable<BigInteger>.GetValueOrDefault
	|
	|-RVA: 0x2BB4BB4 Offset: 0x2BB0BB4 VA: 0x2BB4BB4
	|-Nullable<bool>.GetValueOrDefault
	|
	|-RVA: 0x2BB5024 Offset: 0x2BB1024 VA: 0x2BB5024
	|-Nullable<byte>.GetValueOrDefault
	|
	|-RVA: 0x2BB53E0 Offset: 0x2BB13E0 VA: 0x2BB53E0
	|-Nullable<char>.GetValueOrDefault
	|
	|-RVA: 0x2BB5860 Offset: 0x2BB1860 VA: 0x2BB5860
	|-Nullable<DataKey>.GetValueOrDefault
	|
	|-RVA: 0x2BB5C68 Offset: 0x2BB1C68 VA: 0x2BB5C68
	|-Nullable<DateTime>.GetValueOrDefault
	|
	|-RVA: 0x2BB60C8 Offset: 0x2BB20C8 VA: 0x2BB60C8
	|-Nullable<DateTimeOffset>.GetValueOrDefault
	|
	|-RVA: 0x2BB6598 Offset: 0x2BB2598 VA: 0x2BB6598
	|-Nullable<Decimal>.GetValueOrDefault
	|
	|-RVA: 0x2BB6A84 Offset: 0x2BB2A84 VA: 0x2BB6A84
	|-Nullable<double>.GetValueOrDefault
	|
	|-RVA: 0x2BB6E40 Offset: 0x2BB2E40 VA: 0x2BB6E40
	|-Nullable<Guid>.GetValueOrDefault
	|
	|-RVA: 0x2BB725C Offset: 0x2BB325C VA: 0x2BB725C
	|-Nullable<short>.GetValueOrDefault
	|
	|-RVA: 0x2BB7618 Offset: 0x2BB3618 VA: 0x2BB7618
	|-Nullable<int>.GetValueOrDefault
	|
	|-RVA: 0x2BB79D4 Offset: 0x2BB39D4 VA: 0x2BB79D4
	|-Nullable<Int32Enum>.GetValueOrDefault
	|
	|-RVA: 0x2BB7DA4 Offset: 0x2BB3DA4 VA: 0x2BB7DA4
	|-Nullable<long>.GetValueOrDefault
	|
	|-RVA: 0x2BB8198 Offset: 0x2BB4198 VA: 0x2BB8198
	|-Nullable<JsonPosition>.GetValueOrDefault
	|
	|-RVA: 0x2BB8680 Offset: 0x2BB4680 VA: 0x2BB8680
	|-Nullable<LocalDefinition>.GetValueOrDefault
	|
	|-RVA: 0x2BB8AF4 Offset: 0x2BB4AF4 VA: 0x2BB8AF4
	|-Nullable<RegexPrefix>.GetValueOrDefault
	|
	|-RVA: 0x2BB9BF8 Offset: 0x2BB5BF8 VA: 0x2BB9BF8
	|-Nullable<sbyte>.GetValueOrDefault
	|
	|-RVA: 0x2BB9FB4 Offset: 0x2BB5FB4 VA: 0x2BB9FB4
	|-Nullable<float>.GetValueOrDefault
	|
	|-RVA: 0x2BBA368 Offset: 0x2BB6368 VA: 0x2BBA368
	|-Nullable<SkillIdData>.GetValueOrDefault
	|
	|-RVA: 0x2BBA7D0 Offset: 0x2BB67D0 VA: 0x2BBA7D0
	|-Nullable<SqlBinary>.GetValueOrDefault
	|
	|-RVA: 0x2BBAC84 Offset: 0x2BB6C84 VA: 0x2BBAC84
	|-Nullable<StreamingContext>.GetValueOrDefault
	|
	|-RVA: 0x2BBB0CC Offset: 0x2BB70CC VA: 0x2BBB0CC
	|-Nullable<TimeSpan>.GetValueOrDefault
	|
	|-RVA: 0x2BBB528 Offset: 0x2BB7528 VA: 0x2BBB528
	|-Nullable<ushort>.GetValueOrDefault
	|
	|-RVA: 0x2BBB8E4 Offset: 0x2BB78E4 VA: 0x2BBB8E4
	|-Nullable<uint>.GetValueOrDefault
	|
	|-RVA: 0x2BBBCA0 Offset: 0x2BB7CA0 VA: 0x2BBBCA0
	|-Nullable<ulong>.GetValueOrDefault
	|
	|-RVA: 0x2BBC058 Offset: 0x2BB8058 VA: 0x2BBC058
	|-Nullable<Vector3>.GetValueOrDefault
	|
	|-RVA: 0x2BBC7E4 Offset: 0x2BB87E4 VA: 0x2BBC7E4
	|-Nullable<__Il2CppFullySharedGenericStructType>.GetValueOrDefault
	|
	|-RVA: 0x2BBD3E4 Offset: 0x2BB93E4 VA: 0x2BBD3E4
	|-Nullable<KadarElexioBuf.SkillIdData>.GetValueOrDefault
	|
	|-RVA: 0x2BBD868 Offset: 0x2BB9868 VA: 0x2BBD868
	|-Nullable<TimeZoneInfo.TransitionTime>.GetValueOrDefault
	|
	|-RVA: 0x2BBDCDC Offset: 0x2BB9CDC VA: 0x2BBDCDC
	|-Nullable<TreasureHuntRoomData.CacheSyncData>.GetValueOrDefault
	|
	|-RVA: 0x2BBE12C Offset: 0x2BBA12C VA: 0x2BBE12C
	|-Nullable<TrophyManager.TrophyData>.GetValueOrDefault
	|
	|-RVA: 0x2BBE5C8 Offset: 0x2BBA5C8 VA: 0x2BBE5C8
	|-Nullable<UIMobPropertyLabel.IconValue>.GetValueOrDefault
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB46F0 Offset: 0x2BB06F0 VA: 0x2BB46F0
	|-Nullable<BigInteger>.Equals
	|
	|-RVA: 0x2BB4BD0 Offset: 0x2BB0BD0 VA: 0x2BB4BD0
	|-Nullable<bool>.Equals
	|
	|-RVA: 0x2BB503C Offset: 0x2BB103C VA: 0x2BB503C
	|-Nullable<byte>.Equals
	|
	|-RVA: 0x2BB53F8 Offset: 0x2BB13F8 VA: 0x2BB53F8
	|-Nullable<char>.Equals
	|
	|-RVA: 0x2BB5878 Offset: 0x2BB1878 VA: 0x2BB5878
	|-Nullable<DataKey>.Equals
	|
	|-RVA: 0x2BB5C80 Offset: 0x2BB1C80 VA: 0x2BB5C80
	|-Nullable<DateTime>.Equals
	|
	|-RVA: 0x2BB60EC Offset: 0x2BB20EC VA: 0x2BB60EC
	|-Nullable<DateTimeOffset>.Equals
	|
	|-RVA: 0x2BB65BC Offset: 0x2BB25BC VA: 0x2BB65BC
	|-Nullable<Decimal>.Equals
	|
	|-RVA: 0x2BB6A94 Offset: 0x2BB2A94 VA: 0x2BB6A94
	|-Nullable<double>.Equals
	|
	|-RVA: 0x2BB6E64 Offset: 0x2BB2E64 VA: 0x2BB6E64
	|-Nullable<Guid>.Equals
	|
	|-RVA: 0x2BB7274 Offset: 0x2BB3274 VA: 0x2BB7274
	|-Nullable<short>.Equals
	|
	|-RVA: 0x2BB7630 Offset: 0x2BB3630 VA: 0x2BB7630
	|-Nullable<int>.Equals
	|
	|-RVA: 0x2BB79EC Offset: 0x2BB39EC VA: 0x2BB79EC
	|-Nullable<Int32Enum>.Equals
	|
	|-RVA: 0x2BB7DBC Offset: 0x2BB3DBC VA: 0x2BB7DBC
	|-Nullable<long>.Equals
	|
	|-RVA: 0x2BB81B8 Offset: 0x2BB41B8 VA: 0x2BB81B8
	|-Nullable<JsonPosition>.Equals
	|
	|-RVA: 0x2BB86A4 Offset: 0x2BB46A4 VA: 0x2BB86A4
	|-Nullable<LocalDefinition>.Equals
	|
	|-RVA: 0x2BB8B18 Offset: 0x2BB4B18 VA: 0x2BB8B18
	|-Nullable<RegexPrefix>.Equals
	|
	|-RVA: 0x2BB9C10 Offset: 0x2BB5C10 VA: 0x2BB9C10
	|-Nullable<sbyte>.Equals
	|
	|-RVA: 0x2BB9FC4 Offset: 0x2BB5FC4 VA: 0x2BB9FC4
	|-Nullable<float>.Equals
	|
	|-RVA: 0x2BBA380 Offset: 0x2BB6380 VA: 0x2BBA380
	|-Nullable<SkillIdData>.Equals
	|
	|-RVA: 0x2BBA7E8 Offset: 0x2BB67E8 VA: 0x2BBA7E8
	|-Nullable<SqlBinary>.Equals
	|
	|-RVA: 0x2BBACA8 Offset: 0x2BB6CA8 VA: 0x2BBACA8
	|-Nullable<StreamingContext>.Equals
	|
	|-RVA: 0x2BBB0E4 Offset: 0x2BB70E4 VA: 0x2BBB0E4
	|-Nullable<TimeSpan>.Equals
	|
	|-RVA: 0x2BBB540 Offset: 0x2BB7540 VA: 0x2BBB540
	|-Nullable<ushort>.Equals
	|
	|-RVA: 0x2BBB8FC Offset: 0x2BB78FC VA: 0x2BBB8FC
	|-Nullable<uint>.Equals
	|
	|-RVA: 0x2BBBCB8 Offset: 0x2BB7CB8 VA: 0x2BBBCB8
	|-Nullable<ulong>.Equals
	|
	|-RVA: 0x2BBC06C Offset: 0x2BB806C VA: 0x2BBC06C
	|-Nullable<Vector3>.Equals
	|
	|-RVA: 0x2BBC910 Offset: 0x2BB8910 VA: 0x2BBC910
	|-Nullable<__Il2CppFullySharedGenericStructType>.Equals
	|
	|-RVA: 0x2BBD3FC Offset: 0x2BB93FC VA: 0x2BBD3FC
	|-Nullable<KadarElexioBuf.SkillIdData>.Equals
	|
	|-RVA: 0x2BBD888 Offset: 0x2BB9888 VA: 0x2BBD888
	|-Nullable<TimeZoneInfo.TransitionTime>.Equals
	|
	|-RVA: 0x2BBDCF8 Offset: 0x2BB9CF8 VA: 0x2BBDCF8
	|-Nullable<TreasureHuntRoomData.CacheSyncData>.Equals
	|
	|-RVA: 0x2BBE144 Offset: 0x2BBA144 VA: 0x2BBE144
	|-Nullable<TrophyManager.TrophyData>.Equals
	|
	|-RVA: 0x2BBE5E8 Offset: 0x2BBA5E8 VA: 0x2BBE5E8
	|-Nullable<UIMobPropertyLabel.IconValue>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB47A4 Offset: 0x2BB07A4 VA: 0x2BB47A4
	|-Nullable<BigInteger>.GetHashCode
	|
	|-RVA: 0x2BB4C84 Offset: 0x2BB0C84 VA: 0x2BB4C84
	|-Nullable<bool>.GetHashCode
	|
	|-RVA: 0x2BB50AC Offset: 0x2BB10AC VA: 0x2BB50AC
	|-Nullable<byte>.GetHashCode
	|
	|-RVA: 0x2BB54AC Offset: 0x2BB14AC VA: 0x2BB54AC
	|-Nullable<char>.GetHashCode
	|
	|-RVA: 0x2BB58E8 Offset: 0x2BB18E8 VA: 0x2BB58E8
	|-Nullable<DataKey>.GetHashCode
	|
	|-RVA: 0x2BB5D34 Offset: 0x2BB1D34 VA: 0x2BB5D34
	|-Nullable<DateTime>.GetHashCode
	|
	|-RVA: 0x2BB61A0 Offset: 0x2BB21A0 VA: 0x2BB61A0
	|-Nullable<DateTimeOffset>.GetHashCode
	|
	|-RVA: 0x2BB6670 Offset: 0x2BB2670 VA: 0x2BB6670
	|-Nullable<Decimal>.GetHashCode
	|
	|-RVA: 0x2BB6B04 Offset: 0x2BB2B04 VA: 0x2BB6B04
	|-Nullable<double>.GetHashCode
	|
	|-RVA: 0x2BB6ED4 Offset: 0x2BB2ED4 VA: 0x2BB6ED4
	|-Nullable<Guid>.GetHashCode
	|
	|-RVA: 0x2BB72E4 Offset: 0x2BB32E4 VA: 0x2BB72E4
	|-Nullable<short>.GetHashCode
	|
	|-RVA: 0x2BB76A0 Offset: 0x2BB36A0 VA: 0x2BB76A0
	|-Nullable<int>.GetHashCode
	|
	|-RVA: 0x2BB7A78 Offset: 0x2BB3A78 VA: 0x2BB7A78
	|-Nullable<Int32Enum>.GetHashCode
	|
	|-RVA: 0x2BB7E2C Offset: 0x2BB3E2C VA: 0x2BB7E2C
	|-Nullable<long>.GetHashCode
	|
	|-RVA: 0x2BB8250 Offset: 0x2BB4250 VA: 0x2BB8250
	|-Nullable<JsonPosition>.GetHashCode
	|
	|-RVA: 0x2BB8714 Offset: 0x2BB4714 VA: 0x2BB8714
	|-Nullable<LocalDefinition>.GetHashCode
	|
	|-RVA: 0x2BB8BA4 Offset: 0x2BB4BA4 VA: 0x2BB8BA4
	|-Nullable<RegexPrefix>.GetHashCode
	|
	|-RVA: 0x2BB9C80 Offset: 0x2BB5C80 VA: 0x2BB9C80
	|-Nullable<sbyte>.GetHashCode
	|
	|-RVA: 0x2BBA034 Offset: 0x2BB6034 VA: 0x2BBA034
	|-Nullable<float>.GetHashCode
	|
	|-RVA: 0x2BBA40C Offset: 0x2BB640C VA: 0x2BBA40C
	|-Nullable<SkillIdData>.GetHashCode
	|
	|-RVA: 0x2BBA89C Offset: 0x2BB689C VA: 0x2BBA89C
	|-Nullable<SqlBinary>.GetHashCode
	|
	|-RVA: 0x2BBAD18 Offset: 0x2BB6D18 VA: 0x2BBAD18
	|-Nullable<StreamingContext>.GetHashCode
	|
	|-RVA: 0x2BBB198 Offset: 0x2BB7198 VA: 0x2BBB198
	|-Nullable<TimeSpan>.GetHashCode
	|
	|-RVA: 0x2BBB5B0 Offset: 0x2BB75B0 VA: 0x2BBB5B0
	|-Nullable<ushort>.GetHashCode
	|
	|-RVA: 0x2BBB96C Offset: 0x2BB796C VA: 0x2BBB96C
	|-Nullable<uint>.GetHashCode
	|
	|-RVA: 0x2BBBD28 Offset: 0x2BB7D28 VA: 0x2BBBD28
	|-Nullable<ulong>.GetHashCode
	|
	|-RVA: 0x2BBC130 Offset: 0x2BB8130 VA: 0x2BBC130
	|-Nullable<Vector3>.GetHashCode
	|
	|-RVA: 0x2BBCAAC Offset: 0x2BB8AAC VA: 0x2BBCAAC
	|-Nullable<__Il2CppFullySharedGenericStructType>.GetHashCode
	|
	|-RVA: 0x2BBD488 Offset: 0x2BB9488 VA: 0x2BBD488
	|-Nullable<KadarElexioBuf.SkillIdData>.GetHashCode
	|
	|-RVA: 0x2BBD8F8 Offset: 0x2BB98F8 VA: 0x2BBD8F8
	|-Nullable<TimeZoneInfo.TransitionTime>.GetHashCode
	|
	|-RVA: 0x2BBDD8C Offset: 0x2BB9D8C VA: 0x2BBDD8C
	|-Nullable<TreasureHuntRoomData.CacheSyncData>.GetHashCode
	|
	|-RVA: 0x2BBE1D0 Offset: 0x2BBA1D0 VA: 0x2BBE1D0
	|-Nullable<TrophyManager.TrophyData>.GetHashCode
	|
	|-RVA: 0x2BBE680 Offset: 0x2BBA680 VA: 0x2BBE680
	|-Nullable<UIMobPropertyLabel.IconValue>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB4830 Offset: 0x2BB0830 VA: 0x2BB4830
	|-Nullable<BigInteger>.ToString
	|
	|-RVA: 0x2BB4D10 Offset: 0x2BB0D10 VA: 0x2BB4D10
	|-Nullable<bool>.ToString
	|
	|-RVA: 0x2BB50F0 Offset: 0x2BB10F0 VA: 0x2BB50F0
	|-Nullable<byte>.ToString
	|
	|-RVA: 0x2BB5538 Offset: 0x2BB1538 VA: 0x2BB5538
	|-Nullable<char>.ToString
	|
	|-RVA: 0x2BB592C Offset: 0x2BB192C VA: 0x2BB592C
	|-Nullable<DataKey>.ToString
	|
	|-RVA: 0x2BB5DC0 Offset: 0x2BB1DC0 VA: 0x2BB5DC0
	|-Nullable<DateTime>.ToString
	|
	|-RVA: 0x2BB622C Offset: 0x2BB222C VA: 0x2BB622C
	|-Nullable<DateTimeOffset>.ToString
	|
	|-RVA: 0x2BB66FC Offset: 0x2BB26FC VA: 0x2BB66FC
	|-Nullable<Decimal>.ToString
	|
	|-RVA: 0x2BB6B50 Offset: 0x2BB2B50 VA: 0x2BB6B50
	|-Nullable<double>.ToString
	|
	|-RVA: 0x2BB6F18 Offset: 0x2BB2F18 VA: 0x2BB6F18
	|-Nullable<Guid>.ToString
	|
	|-RVA: 0x2BB7328 Offset: 0x2BB3328 VA: 0x2BB7328
	|-Nullable<short>.ToString
	|
	|-RVA: 0x2BB76E4 Offset: 0x2BB36E4 VA: 0x2BB76E4
	|-Nullable<int>.ToString
	|
	|-RVA: 0x2BB7A94 Offset: 0x2BB3A94 VA: 0x2BB7A94
	|-Nullable<Int32Enum>.ToString
	|
	|-RVA: 0x2BB7E70 Offset: 0x2BB3E70 VA: 0x2BB7E70
	|-Nullable<long>.ToString
	|
	|-RVA: 0x2BB82C4 Offset: 0x2BB42C4 VA: 0x2BB82C4
	|-Nullable<JsonPosition>.ToString
	|
	|-RVA: 0x2BB8758 Offset: 0x2BB4758 VA: 0x2BB8758
	|-Nullable<LocalDefinition>.ToString
	|
	|-RVA: 0x2BB8C0C Offset: 0x2BB4C0C VA: 0x2BB8C0C
	|-Nullable<RegexPrefix>.ToString
	|
	|-RVA: 0x2BB9CC4 Offset: 0x2BB5CC4 VA: 0x2BB9CC4
	|-Nullable<sbyte>.ToString
	|
	|-RVA: 0x2BBA078 Offset: 0x2BB6078 VA: 0x2BBA078
	|-Nullable<float>.ToString
	|
	|-RVA: 0x2BBA474 Offset: 0x2BB6474 VA: 0x2BBA474
	|-Nullable<SkillIdData>.ToString
	|
	|-RVA: 0x2BBA928 Offset: 0x2BB6928 VA: 0x2BBA928
	|-Nullable<SqlBinary>.ToString
	|
	|-RVA: 0x2BBAD4C Offset: 0x2BB6D4C VA: 0x2BBAD4C
	|-Nullable<StreamingContext>.ToString
	|
	|-RVA: 0x2BBB224 Offset: 0x2BB7224 VA: 0x2BBB224
	|-Nullable<TimeSpan>.ToString
	|
	|-RVA: 0x2BBB5F4 Offset: 0x2BB75F4 VA: 0x2BBB5F4
	|-Nullable<ushort>.ToString
	|
	|-RVA: 0x2BBB9B0 Offset: 0x2BB79B0 VA: 0x2BBB9B0
	|-Nullable<uint>.ToString
	|
	|-RVA: 0x2BBBD6C Offset: 0x2BB7D6C VA: 0x2BBBD6C
	|-Nullable<ulong>.ToString
	|
	|-RVA: 0x2BBC19C Offset: 0x2BB819C VA: 0x2BBC19C
	|-Nullable<Vector3>.ToString
	|
	|-RVA: 0x2BBCC28 Offset: 0x2BB8C28 VA: 0x2BBCC28
	|-Nullable<__Il2CppFullySharedGenericStructType>.ToString
	|
	|-RVA: 0x2BBD4F0 Offset: 0x2BB94F0 VA: 0x2BBD4F0
	|-Nullable<KadarElexioBuf.SkillIdData>.ToString
	|
	|-RVA: 0x2BBD93C Offset: 0x2BB993C VA: 0x2BBD93C
	|-Nullable<TimeZoneInfo.TransitionTime>.ToString
	|
	|-RVA: 0x2BBDDFC Offset: 0x2BB9DFC VA: 0x2BBDDFC
	|-Nullable<TreasureHuntRoomData.CacheSyncData>.ToString
	|
	|-RVA: 0x2BBE238 Offset: 0x2BBA238 VA: 0x2BBE238
	|-Nullable<TrophyManager.TrophyData>.ToString
	|
	|-RVA: 0x2BBE6F4 Offset: 0x2BBA6F4 VA: 0x2BBE6F4
	|-Nullable<UIMobPropertyLabel.IconValue>.ToString
	*/

	// RVA: -1 Offset: -1
	private static object Box(Nullable<T> o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB48D0 Offset: 0x2BB08D0 VA: 0x2BB48D0
	|-Nullable<BigInteger>.Box
	|
	|-RVA: 0x2BB4DB0 Offset: 0x2BB0DB0 VA: 0x2BB4DB0
	|-Nullable<bool>.Box
	|
	|-RVA: 0x2BB516C Offset: 0x2BB116C VA: 0x2BB516C
	|-Nullable<byte>.Box
	|
	|-RVA: 0x2BB55D8 Offset: 0x2BB15D8 VA: 0x2BB55D8
	|-Nullable<char>.Box
	|
	|-RVA: 0x2BB59C8 Offset: 0x2BB19C8 VA: 0x2BB59C8
	|-Nullable<DataKey>.Box
	|
	|-RVA: 0x2BB5E60 Offset: 0x2BB1E60 VA: 0x2BB5E60
	|-Nullable<DateTime>.Box
	|
	|-RVA: 0x2BB62CC Offset: 0x2BB22CC VA: 0x2BB62CC
	|-Nullable<DateTimeOffset>.Box
	|
	|-RVA: 0x2BB679C Offset: 0x2BB279C VA: 0x2BB679C
	|-Nullable<Decimal>.Box
	|
	|-RVA: 0x2BB6BCC Offset: 0x2BB2BCC VA: 0x2BB6BCC
	|-Nullable<double>.Box
	|
	|-RVA: 0x2BB6F94 Offset: 0x2BB2F94 VA: 0x2BB6F94
	|-Nullable<Guid>.Box
	|
	|-RVA: 0x2BB73A4 Offset: 0x2BB33A4 VA: 0x2BB73A4
	|-Nullable<short>.Box
	|
	|-RVA: 0x2BB7760 Offset: 0x2BB3760 VA: 0x2BB7760
	|-Nullable<int>.Box
	|
	|-RVA: 0x2BB7B30 Offset: 0x2BB3B30 VA: 0x2BB7B30
	|-Nullable<Int32Enum>.Box
	|
	|-RVA: 0x2BB7EEC Offset: 0x2BB3EEC VA: 0x2BB7EEC
	|-Nullable<long>.Box
	|
	|-RVA: 0x2BB836C Offset: 0x2BB436C VA: 0x2BB836C
	|-Nullable<JsonPosition>.Box
	|
	|-RVA: 0x2BB87F8 Offset: 0x2BB47F8 VA: 0x2BB87F8
	|-Nullable<LocalDefinition>.Box
	|
	|-RVA: 0x2BB8CA8 Offset: 0x2BB4CA8 VA: 0x2BB8CA8
	|-Nullable<RegexPrefix>.Box
	|
	|-RVA: 0x2BB9D40 Offset: 0x2BB5D40 VA: 0x2BB9D40
	|-Nullable<sbyte>.Box
	|
	|-RVA: 0x2BBA0F4 Offset: 0x2BB60F4 VA: 0x2BBA0F4
	|-Nullable<float>.Box
	|
	|-RVA: 0x2BBA510 Offset: 0x2BB6510 VA: 0x2BBA510
	|-Nullable<SkillIdData>.Box
	|
	|-RVA: 0x2BBA9C8 Offset: 0x2BB69C8 VA: 0x2BBA9C8
	|-Nullable<SqlBinary>.Box
	|
	|-RVA: 0x2BBADEC Offset: 0x2BB6DEC VA: 0x2BBADEC
	|-Nullable<StreamingContext>.Box
	|
	|-RVA: 0x2BBB2C4 Offset: 0x2BB72C4 VA: 0x2BBB2C4
	|-Nullable<TimeSpan>.Box
	|
	|-RVA: 0x2BBB670 Offset: 0x2BB7670 VA: 0x2BBB670
	|-Nullable<ushort>.Box
	|
	|-RVA: 0x2BBBA2C Offset: 0x2BB7A2C VA: 0x2BBBA2C
	|-Nullable<uint>.Box
	|
	|-RVA: 0x2BBBDE8 Offset: 0x2BB7DE8 VA: 0x2BBBDE8
	|-Nullable<ulong>.Box
	|
	|-RVA: 0x2BBC21C Offset: 0x2BB821C VA: 0x2BBC21C
	|-Nullable<Vector3>.Box
	|
	|-RVA: 0x2BBCDC4 Offset: 0x2BB8DC4 VA: 0x2BBCDC4
	|-Nullable<__Il2CppFullySharedGenericStructType>.Box
	|
	|-RVA: 0x2BBD58C Offset: 0x2BB958C VA: 0x2BBD58C
	|-Nullable<KadarElexioBuf.SkillIdData>.Box
	|
	|-RVA: 0x2BBD9E4 Offset: 0x2BB99E4 VA: 0x2BBD9E4
	|-Nullable<TimeZoneInfo.TransitionTime>.Box
	|
	|-RVA: 0x2BBDEA0 Offset: 0x2BB9EA0 VA: 0x2BBDEA0
	|-Nullable<TreasureHuntRoomData.CacheSyncData>.Box
	|
	|-RVA: 0x2BBE2D4 Offset: 0x2BBA2D4 VA: 0x2BBE2D4
	|-Nullable<TrophyManager.TrophyData>.Box
	|
	|-RVA: 0x2BBE79C Offset: 0x2BBA79C VA: 0x2BBE79C
	|-Nullable<UIMobPropertyLabel.IconValue>.Box
	*/

	// RVA: -1 Offset: -1
	private static Nullable<T> Unbox(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB492C Offset: 0x2BB092C VA: 0x2BB492C
	|-Nullable<BigInteger>.Unbox
	|
	|-RVA: 0x2BB4DF0 Offset: 0x2BB0DF0 VA: 0x2BB4DF0
	|-Nullable<bool>.Unbox
	|
	|-RVA: 0x2BB51AC Offset: 0x2BB11AC VA: 0x2BB51AC
	|-Nullable<byte>.Unbox
	|
	|-RVA: 0x2BB5618 Offset: 0x2BB1618 VA: 0x2BB5618
	|-Nullable<char>.Unbox
	|
	|-RVA: 0x2BB5A04 Offset: 0x2BB1A04 VA: 0x2BB5A04
	|-Nullable<DataKey>.Unbox
	|
	|-RVA: 0x2BB5E9C Offset: 0x2BB1E9C VA: 0x2BB5E9C
	|-Nullable<DateTime>.Unbox
	|
	|-RVA: 0x2BB6328 Offset: 0x2BB2328 VA: 0x2BB6328
	|-Nullable<DateTimeOffset>.Unbox
	|
	|-RVA: 0x2BB6818 Offset: 0x2BB2818 VA: 0x2BB6818
	|-Nullable<Decimal>.Unbox
	|
	|-RVA: 0x2BB6C08 Offset: 0x2BB2C08 VA: 0x2BB6C08
	|-Nullable<double>.Unbox
	|
	|-RVA: 0x2BB6FF0 Offset: 0x2BB2FF0 VA: 0x2BB6FF0
	|-Nullable<Guid>.Unbox
	|
	|-RVA: 0x2BB73E4 Offset: 0x2BB33E4 VA: 0x2BB73E4
	|-Nullable<short>.Unbox
	|
	|-RVA: 0x2BB77A0 Offset: 0x2BB37A0 VA: 0x2BB77A0
	|-Nullable<int>.Unbox
	|
	|-RVA: 0x2BB7B70 Offset: 0x2BB3B70 VA: 0x2BB7B70
	|-Nullable<Int32Enum>.Unbox
	|
	|-RVA: 0x2BB7F28 Offset: 0x2BB3F28 VA: 0x2BB7F28
	|-Nullable<long>.Unbox
	|
	|-RVA: 0x2BB83C8 Offset: 0x2BB43C8 VA: 0x2BB83C8
	|-Nullable<JsonPosition>.Unbox
	|
	|-RVA: 0x2BB8854 Offset: 0x2BB4854 VA: 0x2BB8854
	|-Nullable<LocalDefinition>.Unbox
	|
	|-RVA: 0x2BB8D04 Offset: 0x2BB4D04 VA: 0x2BB8D04
	|-Nullable<RegexPrefix>.Unbox
	|
	|-RVA: 0x2BB9D80 Offset: 0x2BB5D80 VA: 0x2BB9D80
	|-Nullable<sbyte>.Unbox
	|
	|-RVA: 0x2BBA134 Offset: 0x2BB6134 VA: 0x2BBA134
	|-Nullable<float>.Unbox
	|
	|-RVA: 0x2BBA550 Offset: 0x2BB6550 VA: 0x2BBA550
	|-Nullable<SkillIdData>.Unbox
	|
	|-RVA: 0x2BBAA04 Offset: 0x2BB6A04 VA: 0x2BBAA04
	|-Nullable<SqlBinary>.Unbox
	|
	|-RVA: 0x2BBAE48 Offset: 0x2BB6E48 VA: 0x2BBAE48
	|-Nullable<StreamingContext>.Unbox
	|
	|-RVA: 0x2BBB300 Offset: 0x2BB7300 VA: 0x2BBB300
	|-Nullable<TimeSpan>.Unbox
	|
	|-RVA: 0x2BBB6B0 Offset: 0x2BB76B0 VA: 0x2BBB6B0
	|-Nullable<ushort>.Unbox
	|
	|-RVA: 0x2BBBA6C Offset: 0x2BB7A6C VA: 0x2BBBA6C
	|-Nullable<uint>.Unbox
	|
	|-RVA: 0x2BBBE24 Offset: 0x2BB7E24 VA: 0x2BBBE24
	|-Nullable<ulong>.Unbox
	|
	|-RVA: 0x2BBC268 Offset: 0x2BB8268 VA: 0x2BBC268
	|-Nullable<Vector3>.Unbox
	|
	|-RVA: 0x2BBCF58 Offset: 0x2BB8F58 VA: 0x2BBCF58
	|-Nullable<__Il2CppFullySharedGenericStructType>.Unbox
	|
	|-RVA: 0x2BBD5CC Offset: 0x2BB95CC VA: 0x2BBD5CC
	|-Nullable<KadarElexioBuf.SkillIdData>.Unbox
	|
	|-RVA: 0x2BBDA40 Offset: 0x2BB9A40 VA: 0x2BBDA40
	|-Nullable<TimeZoneInfo.TransitionTime>.Unbox
	|
	|-RVA: 0x2BBDEE8 Offset: 0x2BB9EE8 VA: 0x2BBDEE8
	|-Nullable<TreasureHuntRoomData.CacheSyncData>.Unbox
	|
	|-RVA: 0x2BBE314 Offset: 0x2BBA314 VA: 0x2BBE314
	|-Nullable<TrophyManager.TrophyData>.Unbox
	|
	|-RVA: 0x2BBE7F8 Offset: 0x2BBA7F8 VA: 0x2BBE7F8
	|-Nullable<UIMobPropertyLabel.IconValue>.Unbox
	*/

	// RVA: -1 Offset: -1
	private static Nullable<T> UnboxExact(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB49F0 Offset: 0x2BB09F0 VA: 0x2BB49F0
	|-Nullable<BigInteger>.UnboxExact
	|
	|-RVA: 0x2BB4E8C Offset: 0x2BB0E8C VA: 0x2BB4E8C
	|-Nullable<bool>.UnboxExact
	|
	|-RVA: 0x2BB5248 Offset: 0x2BB1248 VA: 0x2BB5248
	|-Nullable<byte>.UnboxExact
	|
	|-RVA: 0x2BB56B4 Offset: 0x2BB16B4 VA: 0x2BB56B4
	|-Nullable<char>.UnboxExact
	|
	|-RVA: 0x2BB5AB4 Offset: 0x2BB1AB4 VA: 0x2BB5AB4
	|-Nullable<DataKey>.UnboxExact
	|
	|-RVA: 0x2BB5F30 Offset: 0x2BB1F30 VA: 0x2BB5F30
	|-Nullable<DateTime>.UnboxExact
	|
	|-RVA: 0x2BB63E0 Offset: 0x2BB23E0 VA: 0x2BB63E0
	|-Nullable<DateTimeOffset>.UnboxExact
	|
	|-RVA: 0x2BB68D0 Offset: 0x2BB28D0 VA: 0x2BB68D0
	|-Nullable<Decimal>.UnboxExact
	|
	|-RVA: 0x2BB6C9C Offset: 0x2BB2C9C VA: 0x2BB6C9C
	|-Nullable<double>.UnboxExact
	|
	|-RVA: 0x2BB70A8 Offset: 0x2BB30A8 VA: 0x2BB70A8
	|-Nullable<Guid>.UnboxExact
	|
	|-RVA: 0x2BB7480 Offset: 0x2BB3480 VA: 0x2BB7480
	|-Nullable<short>.UnboxExact
	|
	|-RVA: 0x2BB783C Offset: 0x2BB383C VA: 0x2BB783C
	|-Nullable<int>.UnboxExact
	|
	|-RVA: 0x2BB7C0C Offset: 0x2BB3C0C VA: 0x2BB7C0C
	|-Nullable<Int32Enum>.UnboxExact
	|
	|-RVA: 0x2BB7FBC Offset: 0x2BB3FBC VA: 0x2BB7FBC
	|-Nullable<long>.UnboxExact
	|
	|-RVA: 0x2BB8498 Offset: 0x2BB4498 VA: 0x2BB8498
	|-Nullable<JsonPosition>.UnboxExact
	|
	|-RVA: 0x2BB8918 Offset: 0x2BB4918 VA: 0x2BB8918
	|-Nullable<LocalDefinition>.UnboxExact
	|
	|-RVA: 0x2BB8DC8 Offset: 0x2BB4DC8 VA: 0x2BB8DC8
	|-Nullable<RegexPrefix>.UnboxExact
	|
	|-RVA: 0x2BB9E1C Offset: 0x2BB5E1C VA: 0x2BB9E1C
	|-Nullable<sbyte>.UnboxExact
	|
	|-RVA: 0x2BBA1D0 Offset: 0x2BB61D0 VA: 0x2BBA1D0
	|-Nullable<float>.UnboxExact
	|
	|-RVA: 0x2BBA604 Offset: 0x2BB6604 VA: 0x2BBA604
	|-Nullable<SkillIdData>.UnboxExact
	|
	|-RVA: 0x2BBAAB4 Offset: 0x2BB6AB4 VA: 0x2BBAAB4
	|-Nullable<SqlBinary>.UnboxExact
	|
	|-RVA: 0x2BBAF0C Offset: 0x2BB6F0C VA: 0x2BBAF0C
	|-Nullable<StreamingContext>.UnboxExact
	|
	|-RVA: 0x2BBB394 Offset: 0x2BB7394 VA: 0x2BBB394
	|-Nullable<TimeSpan>.UnboxExact
	|
	|-RVA: 0x2BBB74C Offset: 0x2BB774C VA: 0x2BBB74C
	|-Nullable<ushort>.UnboxExact
	|
	|-RVA: 0x2BBBB08 Offset: 0x2BB7B08 VA: 0x2BBBB08
	|-Nullable<uint>.UnboxExact
	|
	|-RVA: 0x2BBBEB8 Offset: 0x2BB7EB8 VA: 0x2BBBEB8
	|-Nullable<ulong>.UnboxExact
	|
	|-RVA: 0x2BBC318 Offset: 0x2BB8318 VA: 0x2BBC318
	|-Nullable<Vector3>.UnboxExact
	|
	|-RVA: 0x2BBD124 Offset: 0x2BB9124 VA: 0x2BBD124
	|-Nullable<__Il2CppFullySharedGenericStructType>.UnboxExact
	|
	|-RVA: 0x2BBD680 Offset: 0x2BB9680 VA: 0x2BBD680
	|-Nullable<KadarElexioBuf.SkillIdData>.UnboxExact
	|
	|-RVA: 0x2BBDB04 Offset: 0x2BB9B04 VA: 0x2BBDB04
	|-Nullable<TimeZoneInfo.TransitionTime>.UnboxExact
	|
	|-RVA: 0x2BBDF8C Offset: 0x2BB9F8C VA: 0x2BBDF8C
	|-Nullable<TreasureHuntRoomData.CacheSyncData>.UnboxExact
	|
	|-RVA: 0x2BBE3C8 Offset: 0x2BBA3C8 VA: 0x2BBE3C8
	|-Nullable<TrophyManager.TrophyData>.UnboxExact
	|
	|-RVA: 0x2BBE8C8 Offset: 0x2BBA8C8 VA: 0x2BBE8C8
	|-Nullable<UIMobPropertyLabel.IconValue>.UnboxExact
	*/
}
