// Assembly: mscorlib.dll
// Namespace: System
[StackTraceHidden]
internal static class ThrowHelper // TypeDefIndex: 9715
{
	// Methods

	// RVA: 0x2FF71DC Offset: 0x2FF31DC VA: 0x2FF71DC
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x30055BC Offset: 0x30015BC VA: 0x30055BC
	private static Exception CreateArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x3005660 Offset: 0x3001660 VA: 0x3005660
	internal static void ThrowArrayTypeMismatchException() { }

	// RVA: 0x3005684 Offset: 0x3001684 VA: 0x3005684
	private static Exception CreateArrayTypeMismatchException() { }

	// RVA: 0x30056D8 Offset: 0x30016D8 VA: 0x30056D8
	internal static void ThrowArgumentException_DestinationTooShort() { }

	// RVA: 0x30056FC Offset: 0x30016FC VA: 0x30056FC
	private static Exception CreateArgumentException_DestinationTooShort() { }

	// RVA: 0x3005768 Offset: 0x3001768 VA: 0x3005768
	internal static void ThrowIndexOutOfRangeException() { }

	// RVA: 0x300578C Offset: 0x300178C VA: 0x300578C
	private static Exception CreateIndexOutOfRangeException() { }

	// RVA: 0x30057E0 Offset: 0x30017E0 VA: 0x30057E0
	internal static void ThrowArgumentOutOfRangeException() { }

	// RVA: 0x3005804 Offset: 0x3001804 VA: 0x3005804
	private static Exception CreateArgumentOutOfRangeException() { }

	// RVA: 0x3005858 Offset: 0x3001858 VA: 0x3005858
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x300587C Offset: 0x300187C VA: 0x300587C
	private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x3005920 Offset: 0x3001920 VA: 0x3005920
	internal static void ThrowNotSupportedException() { }

	// RVA: 0x3005944 Offset: 0x3001944 VA: 0x3005944
	private static Exception CreateThrowNotSupportedException() { }

	// RVA: 0x3005998 Offset: 0x3001998 VA: 0x3005998
	internal static void ThrowWrongKeyTypeArgumentException(object key, Type targetType) { }

	// RVA: 0x3005A6C Offset: 0x3001A6C VA: 0x3005A6C
	internal static void ThrowWrongValueTypeArgumentException(object value, Type targetType) { }

	// RVA: 0x3005B40 Offset: 0x3001B40 VA: 0x3005B40
	internal static void ThrowArgumentException(ExceptionResource resource) { }

	// RVA: 0x3005E1C Offset: 0x3001E1C VA: 0x3005E1C
	internal static void ThrowArgumentException(ExceptionResource resource, ExceptionArgument argument) { }

	// RVA: 0x3006004 Offset: 0x3002004 VA: 0x3006004
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource) { }

	// RVA: 0x30060A0 Offset: 0x30020A0 VA: 0x30060A0
	internal static void ThrowInvalidOperationException(ExceptionResource resource) { }

	// RVA: 0x30060F0 Offset: 0x30020F0 VA: 0x30060F0
	internal static void ThrowSerializationException(ExceptionResource resource) { }

	// RVA: 0x3006140 Offset: 0x3002140 VA: 0x3006140
	internal static void ThrowNotSupportedException(ExceptionResource resource) { }

	// RVA: 0x3006190 Offset: 0x3002190 VA: 0x3006190
	internal static void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion() { }

	// RVA: 0x30061DC Offset: 0x30021DC VA: 0x30061DC
	internal static void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen() { }

	// RVA: 0x3006228 Offset: 0x3002228 VA: 0x3006228
	internal static void ThrowInvalidOperationException_InvalidOperation_EnumNotStarted() { }

	// RVA: 0x3006274 Offset: 0x3002274 VA: 0x3006274
	internal static void ThrowInvalidOperationException_InvalidOperation_EnumEnded() { }

	// RVA: 0x30062C0 Offset: 0x30022C0 VA: 0x30062C0
	internal static void ThrowInvalidOperationException_InvalidOperation_NoValue() { }

	// RVA: 0x300630C Offset: 0x300230C VA: 0x300630C
	private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, string resource) { }

	// RVA: 0x3006388 Offset: 0x3002388 VA: 0x3006388
	internal static void ThrowArgumentOutOfRange_IndexException() { }

	// RVA: 0x30063C0 Offset: 0x30023C0 VA: 0x30063C0
	internal static void ThrowIndexArgumentOutOfRange_NeedNonNegNumException() { }

	// RVA: 0x30063F8 Offset: 0x30023F8 VA: 0x30063F8
	internal static void ThrowArgumentException_Argument_InvalidArrayType() { }

	// RVA: 0x3006444 Offset: 0x3002444 VA: 0x3006444
	private static ArgumentException GetAddingDuplicateWithKeyArgumentException(object key) { }

	// RVA: 0x30064D4 Offset: 0x30024D4 VA: 0x30064D4
	internal static void ThrowAddingDuplicateWithKeyArgumentException(object key) { }

	// RVA: 0x30064F8 Offset: 0x30024F8 VA: 0x30064F8
	private static KeyNotFoundException GetKeyNotFoundException(object key) { }

	// RVA: 0x3006570 Offset: 0x3002570 VA: 0x3006570
	internal static void ThrowKeyNotFoundException(object key) { }

	// RVA: 0x3006578 Offset: 0x3002578 VA: 0x3006578
	internal static void ThrowInvalidTypeWithPointersNotSupported(Type targetType) { }

	// RVA: 0x30065D8 Offset: 0x30025D8 VA: 0x30065D8
	internal static void ThrowInvalidOperationException_ConcurrentOperationsNotSupported() { }

	// RVA: 0x3006608 Offset: 0x3002608 VA: 0x3006608
	internal static InvalidOperationException GetInvalidOperationException(string str) { }

	// RVA: 0x3006664 Offset: 0x3002664 VA: 0x3006664
	internal static void ThrowArraySegmentCtorValidationFailedExceptions(Array array, int offset, int count) { }

	// RVA: 0x3006688 Offset: 0x3002688 VA: 0x3006688
	private static Exception GetArraySegmentCtorValidationFailedException(Array array, int offset, int count) { }

	// RVA: 0x30067DC Offset: 0x30027DC VA: 0x30067DC
	private static ArgumentException GetArgumentException(ExceptionResource resource) { }

	// RVA: 0x30066B8 Offset: 0x30026B8 VA: 0x30066B8
	private static ArgumentNullException GetArgumentNullException(ExceptionArgument argument) { }

	// RVA: -1 Offset: -1
	internal static void IfNullAndNullsAreIllegalThenThrow<T>(object value, ExceptionArgument argName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F6C18 Offset: 0x26F2C18 VA: 0x26F6C18
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<ArchetypeUid, object>>
	|
	|-RVA: 0x26F6C2C Offset: 0x26F2C2C VA: 0x26F6C2C
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<byte, BlackKnightCristaProperty>>
	|
	|-RVA: 0x26F6C40 Offset: 0x26F2C40 VA: 0x26F6C40
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<byte, byte>>
	|
	|-RVA: 0x26F6C54 Offset: 0x26F2C54 VA: 0x26F6C54
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<byte, object>>
	|
	|-RVA: 0x26F6C68 Offset: 0x26F2C68 VA: 0x26F6C68
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<int, short>>
	|
	|-RVA: 0x26F6C7C Offset: 0x26F2C7C VA: 0x26F6C7C
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<int, int>>
	|
	|-RVA: 0x26F6C90 Offset: 0x26F2C90 VA: 0x26F6C90
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<int, object>>
	|
	|-RVA: 0x26F6CA4 Offset: 0x26F2CA4 VA: 0x26F6CA4
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<Int32Enum, byte>>
	|
	|-RVA: 0x26F6CB8 Offset: 0x26F2CB8 VA: 0x26F6CB8
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<Int32Enum, EnhanceProperties2>>
	|
	|-RVA: 0x26F6CCC Offset: 0x26F2CCC VA: 0x26F6CCC
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x26F6CE0 Offset: 0x26F2CE0 VA: 0x26F6CE0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x26F6CF4 Offset: 0x26F2CF4 VA: 0x26F6CF4
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<object, int>>
	|
	|-RVA: 0x26F6D08 Offset: 0x26F2D08 VA: 0x26F6D08
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<object, float>>
	|
	|-RVA: 0x26F6D1C Offset: 0x26F2D1C VA: 0x26F6D1C
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<float, object>>
	|
	|-RVA: 0x26F6D30 Offset: 0x26F2D30 VA: 0x26F6D30
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Nullable<UIMobPropertyLabel.IconValue>>
	|
	|-RVA: 0x26F6D34 Offset: 0x26F2D34 VA: 0x26F6D34
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<StructMultiKey<object, object>>
	|
	|-RVA: 0x26F6D48 Offset: 0x26F2D48 VA: 0x26F6D48
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<short, short>>
	|
	|-RVA: 0x26F6D5C Offset: 0x26F2D5C VA: 0x26F6D5C
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<int, int>>
	|
	|-RVA: 0x26F6D70 Offset: 0x26F2D70 VA: 0x26F6D70
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<int, object>>
	|
	|-RVA: 0x26F6D84 Offset: 0x26F2D84 VA: 0x26F6D84
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<Int32Enum, float>>
	|
	|-RVA: 0x26F6D98 Offset: 0x26F2D98 VA: 0x26F6D98
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<object, byte>>
	|
	|-RVA: 0x26F6DAC Offset: 0x26F2DAC VA: 0x26F6DAC
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<float, object>>
	|
	|-RVA: 0x26F6DC0 Offset: 0x26F2DC0 VA: 0x26F6DC0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<Vector3, Vector3>>
	|
	|-RVA: 0x26F6DD4 Offset: 0x26F2DD4 VA: 0x26F6DD4
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<short, int, int>>
	|
	|-RVA: 0x26F6DE8 Offset: 0x26F2DE8 VA: 0x26F6DE8
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ArchetypeUid>
	|
	|-RVA: 0x26F6DFC Offset: 0x26F2DFC VA: 0x26F6DFC
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BlackKnightAvatarProperty>
	|
	|-RVA: 0x26F6E10 Offset: 0x26F2E10 VA: 0x26F6E10
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BlackKnightCristaProperty>
	|
	|-RVA: 0x26F6E24 Offset: 0x26F2E24 VA: 0x26F6E24
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<bool>
	|
	|-RVA: 0x26F6E38 Offset: 0x26F2E38 VA: 0x26F6E38
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<byte>
	|
	|-RVA: 0x26F6E4C Offset: 0x26F2E4C VA: 0x26F6E4C
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ByteEnum>
	|
	|-RVA: 0x26F6E60 Offset: 0x26F2E60 VA: 0x26F6E60
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CardData>
	|
	|-RVA: 0x26F6E74 Offset: 0x26F2E74 VA: 0x26F6E74
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<char>
	|
	|-RVA: 0x26F6E88 Offset: 0x26F2E88 VA: 0x26F6E88
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Color>
	|
	|-RVA: 0x26F6E9C Offset: 0x26F2E9C VA: 0x26F6E9C
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Color32>
	|
	|-RVA: 0x26F6EB0 Offset: 0x26F2EB0 VA: 0x26F6EB0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DateTime>
	|
	|-RVA: 0x26F6EC4 Offset: 0x26F2EC4 VA: 0x26F6EC4
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DateTimeOffset>
	|
	|-RVA: 0x26F6ED8 Offset: 0x26F2ED8 VA: 0x26F6ED8
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Decimal>
	|
	|-RVA: 0x26F6EEC Offset: 0x26F2EEC VA: 0x26F6EEC
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DefencePoint2>
	|
	|-RVA: 0x26F6F00 Offset: 0x26F2F00 VA: 0x26F6F00
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<double>
	|
	|-RVA: 0x26F6F14 Offset: 0x26F2F14 VA: 0x26F6F14
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<EnhanceProperties2>
	|
	|-RVA: 0x26F6F28 Offset: 0x26F2F28 VA: 0x26F6F28
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<EventSummary>
	|
	|-RVA: 0x26F6F3C Offset: 0x26F2F3C VA: 0x26F6F3C
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<short>
	|
	|-RVA: 0x26F6F50 Offset: 0x26F2F50 VA: 0x26F6F50
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Int16Enum>
	|
	|-RVA: 0x26F6F64 Offset: 0x26F2F64 VA: 0x26F6F64
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<int>
	|
	|-RVA: 0x26F6F78 Offset: 0x26F2F78 VA: 0x26F6F78
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Int32Enum>
	|
	|-RVA: 0x26F6F8C Offset: 0x26F2F8C VA: 0x26F6F8C
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<long>
	|
	|-RVA: 0x26F6FA0 Offset: 0x26F2FA0 VA: 0x26F6FA0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Int64Enum>
	|
	|-RVA: 0x26F6FB4 Offset: 0x26F2FB4 VA: 0x26F6FB4
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InterpretedFrameInfo>
	|
	|-RVA: 0x26F6FC8 Offset: 0x26F2FC8 VA: 0x26F6FC8
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<JsonPosition>
	|
	|-RVA: 0x26F6FDC Offset: 0x26F2FDC VA: 0x26F6FDC
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MaterialSearchData>
	|
	|-RVA: 0x26F6FF0 Offset: 0x26F2FF0 VA: 0x26F6FF0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MobActionTargetData>
	|
	|-RVA: 0x26F7004 Offset: 0x26F3004 VA: 0x26F7004
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MobIconLabelData>
	|
	|-RVA: 0x26F7018 Offset: 0x26F3018 VA: 0x26F7018
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<object>
	|
	|-RVA: 0x26F701C Offset: 0x26F301C VA: 0x26F701C
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlayerLoopSystem>
	|
	|-RVA: 0x26F7030 Offset: 0x26F3030 VA: 0x26F7030
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlayerLoopSystemInternal>
	|
	|-RVA: 0x26F7044 Offset: 0x26F3044 VA: 0x26F7044
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RangePositionInfo>
	|
	|-RVA: 0x26F7058 Offset: 0x26F3058 VA: 0x26F7058
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ReinforceCristaData>
	|
	|-RVA: 0x26F706C Offset: 0x26F306C VA: 0x26F706C
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RenderInstancedDataLayout>
	|
	|-RVA: 0x26F7080 Offset: 0x26F3080 VA: 0x26F7080
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ResourceLocator>
	|
	|-RVA: 0x26F7094 Offset: 0x26F3094 VA: 0x26F7094
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<sbyte>
	|
	|-RVA: 0x26F70A8 Offset: 0x26F30A8 VA: 0x26F70A8
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<float>
	|
	|-RVA: 0x26F70BC Offset: 0x26F30BC VA: 0x26F70BC
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SkillIdData>
	|
	|-RVA: 0x26F70D0 Offset: 0x26F30D0 VA: 0x26F70D0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TimeSpan>
	|
	|-RVA: 0x26F70E4 Offset: 0x26F30E4 VA: 0x26F70E4
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ushort>
	|
	|-RVA: 0x26F70F8 Offset: 0x26F30F8 VA: 0x26F70F8
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<uint>
	|
	|-RVA: 0x26F710C Offset: 0x26F310C VA: 0x26F710C
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ulong>
	|
	|-RVA: 0x26F7120 Offset: 0x26F3120 VA: 0x26F7120
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector2>
	|
	|-RVA: 0x26F7134 Offset: 0x26F3134 VA: 0x26F7134
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector3>
	|
	|-RVA: 0x26F7148 Offset: 0x26F3148 VA: 0x26F7148
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector4>
	|
	|-RVA: 0x26F715C Offset: 0x26F315C VA: 0x26F715C
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<X509ChainStatus>
	|
	|-RVA: 0x26F7170 Offset: 0x26F3170 VA: 0x26F7170
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<XPathNodeRef>
	|
	|-RVA: 0x26F7184 Offset: 0x26F3184 VA: 0x26F7184
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x26F7274 Offset: 0x26F3274 VA: 0x26F7274
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x26F7288 Offset: 0x26F3288 VA: 0x26F7288
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BoneClip.MotionKeyFrame>
	|
	|-RVA: 0x26F729C Offset: 0x26F329C VA: 0x26F729C
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DeathReceptionAction.PoisonTargetData>
	|
	|-RVA: 0x26F72B0 Offset: 0x26F32B0 VA: 0x26F72B0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<HouseRecipeManager.RecipeData>
	|
	|-RVA: 0x26F72C4 Offset: 0x26F32C4 VA: 0x26F72C4
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KadarElexioBuf.SkillIdData>
	|
	|-RVA: 0x26F72D8 Offset: 0x26F32D8 VA: 0x26F72D8
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MasterModelDataManager.ColorListData>
	|
	|-RVA: 0x26F72EC Offset: 0x26F32EC VA: 0x26F72EC
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MasterModelDataManager.ConvertCommonMaterialData>
	|
	|-RVA: 0x26F7300 Offset: 0x26F3300 VA: 0x26F7300
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MissionTextManagerData.CheckIKeywordtemData>
	|
	|-RVA: 0x26F7314 Offset: 0x26F3314 VA: 0x26F7314
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MissionTextManagerData.PickUpFieldData>
	|
	|-RVA: 0x26F7328 Offset: 0x26F3328 VA: 0x26F7328
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MobaRoomData.MobaAbilityMasterData>
	|
	|-RVA: 0x26F733C Offset: 0x26F333C VA: 0x26F733C
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<NewWaveRoomData.Spotlight>
	|
	|-RVA: 0x26F7350 Offset: 0x26F3350 VA: 0x26F7350
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<NguiDynamicFontController.ApplyTextureInfo>
	|
	|-RVA: 0x26F7364 Offset: 0x26F3364 VA: 0x26F7364
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RegexCharClass.SingleRange>
	|
	|-RVA: 0x26F7378 Offset: 0x26F3378 VA: 0x26F7378
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SocialAchievementData.LinkData>
	|
	|-RVA: 0x26F738C Offset: 0x26F338C VA: 0x26F738C
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TrophyManager.TrophyData>
	|
	|-RVA: 0x26F73A0 Offset: 0x26F33A0 VA: 0x26F73A0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UIEventMenuButton.MessageButtonData>
	|
	|-RVA: 0x26F73B4 Offset: 0x26F33B4 VA: 0x26F73B4
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UIFieldMapPanel.PopData>
	|
	|-RVA: 0x26F73C8 Offset: 0x26F33C8 VA: 0x26F73C8
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UIGuildQuestBoardManager.GuildQuestMaseter>
	|
	|-RVA: 0x26F73DC Offset: 0x26F33DC VA: 0x26F73DC
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UIHouseAddressManager.Town>
	|
	|-RVA: 0x26F73F0 Offset: 0x26F33F0 VA: 0x26F73F0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UIInfoWindow.LabelPosition>
	|
	|-RVA: 0x26F7404 Offset: 0x26F3404 VA: 0x26F7404
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UIMainManager.DropItemData>
	|
	|-RVA: 0x26F7418 Offset: 0x26F3418 VA: 0x26F7418
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UIScenarioOrderPanel.MissionData>
	|
	|-RVA: 0x26F742C Offset: 0x26F342C VA: 0x26F742C
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x26F7440 Offset: 0x26F3440 VA: 0x26F7440
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x26F7454 Offset: 0x26F3454 VA: 0x26F7454
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BounceParabolaAttackPattern.TargetData.BoundLineData>
	|
	|-RVA: 0x26F7468 Offset: 0x26F3468 VA: 0x26F7468
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InstructionList.DebugView.InstructionView>
	*/

	// RVA: 0x3005E80 Offset: 0x3001E80 VA: 0x3005E80
	internal static string GetArgumentName(ExceptionArgument argument) { }

	// RVA: 0x3006724 Offset: 0x3002724 VA: 0x3006724
	private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource) { }

	// RVA: 0x3006880 Offset: 0x3002880 VA: 0x3006880
	internal static void ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index() { }

	// RVA: 0x30068AC Offset: 0x30028AC VA: 0x30068AC
	internal static void ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count() { }

	// RVA: 0x3005B90 Offset: 0x3001B90 VA: 0x3005B90
	internal static string GetResourceName(ExceptionResource resource) { }
}
