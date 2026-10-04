// Assembly: Firebase.App.dll
// Namespace: Firebase
internal class AppUtilPINVOKE // TypeDefIndex: 17236
{
	// Fields
	protected static AppUtilPINVOKE.SWIGExceptionHelper swigExceptionHelper; // 0x0
	protected static AppUtilPINVOKE.SWIGStringHelper swigStringHelper; // 0x8

	// Methods

	// RVA: 0x265F2E0 Offset: 0x265B2E0 VA: 0x265F2E0
	private static void .cctor() { }

	// RVA: 0x26525CC Offset: 0x264E5CC VA: 0x26525CC
	public static extern void delete_FutureBase(HandleRef jarg1) { }

	// RVA: 0x2652710 Offset: 0x264E710 VA: 0x2652710
	public static extern int FutureBase_status(HandleRef jarg1) { }

	// RVA: 0x2652A60 Offset: 0x264EA60 VA: 0x2652A60
	public static extern int FutureBase_error(HandleRef jarg1) { }

	// RVA: 0x2652BA4 Offset: 0x264EBA4 VA: 0x2652BA4
	public static extern string FutureBase_error_message(HandleRef jarg1) { }

	// RVA: 0x2654570 Offset: 0x2650570 VA: 0x2654570
	public static extern IntPtr new_StringStringMap__SWIG_0() { }

	// RVA: 0x26545D8 Offset: 0x26505D8 VA: 0x26545D8
	public static extern uint StringStringMap_size(HandleRef jarg1) { }

	// RVA: 0x2654710 Offset: 0x2650710 VA: 0x2654710
	public static extern void StringStringMap_Clear(HandleRef jarg1) { }

	// RVA: 0x265478C Offset: 0x265078C VA: 0x265478C
	public static extern string StringStringMap_getitem(HandleRef jarg1, string jarg2) { }

	// RVA: 0x265483C Offset: 0x265083C VA: 0x265483C
	public static extern void StringStringMap_setitem(HandleRef jarg1, string jarg2, string jarg3) { }

	// RVA: 0x26548F8 Offset: 0x26508F8 VA: 0x26548F8
	public static extern bool StringStringMap_ContainsKey(HandleRef jarg1, string jarg2) { }

	// RVA: 0x265499C Offset: 0x265099C VA: 0x265499C
	public static extern void StringStringMap_Add(HandleRef jarg1, string jarg2, string jarg3) { }

	// RVA: 0x2654A58 Offset: 0x2650A58 VA: 0x2654A58
	public static extern bool StringStringMap_Remove(HandleRef jarg1, string jarg2) { }

	// RVA: 0x2654AFC Offset: 0x2650AFC VA: 0x2654AFC
	public static extern IntPtr StringStringMap_create_iterator_begin(HandleRef jarg1) { }

	// RVA: 0x2654B78 Offset: 0x2650B78 VA: 0x2654B78
	public static extern string StringStringMap_get_next_key(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x2654C14 Offset: 0x2650C14 VA: 0x2654C14
	public static extern void StringStringMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x2652FAC Offset: 0x264EFAC VA: 0x2652FAC
	public static extern void delete_StringStringMap(HandleRef jarg1) { }

	// RVA: 0x26558B8 Offset: 0x26518B8 VA: 0x26558B8
	public static extern void StringList_Clear(HandleRef jarg1) { }

	// RVA: 0x2655A00 Offset: 0x2651A00 VA: 0x2655A00
	public static extern void StringList_Add(HandleRef jarg1, string jarg2) { }

	// RVA: 0x2655A98 Offset: 0x2651A98 VA: 0x2655A98
	public static extern uint StringList_size(HandleRef jarg1) { }

	// RVA: 0x2655B14 Offset: 0x2651B14 VA: 0x2655B14
	public static extern string StringList_getitemcopy(HandleRef jarg1, int jarg2) { }

	// RVA: 0x2655BB0 Offset: 0x2651BB0 VA: 0x2655BB0
	public static extern string StringList_getitem(HandleRef jarg1, int jarg2) { }

	// RVA: 0x2655C4C Offset: 0x2651C4C VA: 0x2655C4C
	public static extern void StringList_setitem(HandleRef jarg1, int jarg2, string jarg3) { }

	// RVA: 0x2655DC8 Offset: 0x2651DC8 VA: 0x2655DC8
	public static extern void StringList_Insert(HandleRef jarg1, int jarg2, string jarg3) { }

	// RVA: 0x2655F3C Offset: 0x2651F3C VA: 0x2655F3C
	public static extern void StringList_RemoveAt(HandleRef jarg1, int jarg2) { }

	// RVA: 0x2656098 Offset: 0x2652098 VA: 0x2656098
	public static extern bool StringList_Contains(HandleRef jarg1, string jarg2) { }

	// RVA: 0x2656214 Offset: 0x2652214 VA: 0x2656214
	public static extern int StringList_IndexOf(HandleRef jarg1, string jarg2) { }

	// RVA: 0x265638C Offset: 0x265238C VA: 0x265638C
	public static extern bool StringList_Remove(HandleRef jarg1, string jarg2) { }

	// RVA: 0x26550D8 Offset: 0x26510D8 VA: 0x26550D8
	public static extern void delete_StringList(HandleRef jarg1) { }

	// RVA: 0x26571E0 Offset: 0x26531E0 VA: 0x26571E0
	public static extern void CharVector_Clear(HandleRef jarg1) { }

	// RVA: 0x2657328 Offset: 0x2653328 VA: 0x2657328
	public static extern void CharVector_Add(HandleRef jarg1, byte jarg2) { }

	// RVA: 0x26573AC Offset: 0x26533AC VA: 0x26573AC
	public static extern uint CharVector_size(HandleRef jarg1) { }

	// RVA: 0x2657428 Offset: 0x2653428 VA: 0x2657428
	public static extern byte CharVector_getitemcopy(HandleRef jarg1, int jarg2) { }

	// RVA: 0x26574AC Offset: 0x26534AC VA: 0x26574AC
	public static extern byte CharVector_getitem(HandleRef jarg1, int jarg2) { }

	// RVA: 0x2657530 Offset: 0x2653530 VA: 0x2657530
	public static extern void CharVector_setitem(HandleRef jarg1, int jarg2, byte jarg3) { }

	// RVA: 0x2657698 Offset: 0x2653698 VA: 0x2657698
	public static extern void CharVector_Insert(HandleRef jarg1, int jarg2, byte jarg3) { }

	// RVA: 0x26577F8 Offset: 0x26537F8 VA: 0x26577F8
	public static extern void CharVector_RemoveAt(HandleRef jarg1, int jarg2) { }

	// RVA: 0x2657954 Offset: 0x2653954 VA: 0x2657954
	public static extern bool CharVector_Contains(HandleRef jarg1, byte jarg2) { }

	// RVA: 0x2657AB8 Offset: 0x2653AB8 VA: 0x2657AB8
	public static extern int CharVector_IndexOf(HandleRef jarg1, byte jarg2) { }

	// RVA: 0x2657C14 Offset: 0x2653C14 VA: 0x2657C14
	public static extern bool CharVector_Remove(HandleRef jarg1, byte jarg2) { }

	// RVA: 0x2656988 Offset: 0x2652988 VA: 0x2656988
	public static extern void delete_CharVector(HandleRef jarg1) { }

	// RVA: 0x2658E34 Offset: 0x2654E34 VA: 0x2658E34
	public static extern IntPtr FutureString_SWIG_OnCompletion(HandleRef jarg1, FutureString.SWIG_CompletionDelegate jarg2, int jarg3) { }

	// RVA: 0x2658ED0 Offset: 0x2654ED0 VA: 0x2658ED0
	public static extern void FutureString_SWIG_FreeCompletionData(IntPtr jarg1) { }

	// RVA: 0x2659014 Offset: 0x2655014 VA: 0x2659014
	public static extern string FutureString_GetResult(HandleRef jarg1) { }

	// RVA: 0x26585E4 Offset: 0x26545E4 VA: 0x26585E4
	public static extern void delete_FutureString(HandleRef jarg1) { }

	// RVA: 0x265A224 Offset: 0x2656224 VA: 0x265A224
	public static extern IntPtr FutureVoid_SWIG_OnCompletion(HandleRef jarg1, FutureVoid.SWIG_CompletionDelegate jarg2, int jarg3) { }

	// RVA: 0x265A2C0 Offset: 0x26562C0 VA: 0x265A2C0
	public static extern void FutureVoid_SWIG_FreeCompletionData(IntPtr jarg1) { }

	// RVA: 0x26599D4 Offset: 0x26559D4 VA: 0x26599D4
	public static extern void delete_FutureVoid(HandleRef jarg1) { }

	// RVA: 0x265E890 Offset: 0x265A890 VA: 0x265E890
	public static extern string FirebaseApp_NameInternal_get(HandleRef jarg1) { }

	// RVA: 0x265E77C Offset: 0x265A77C VA: 0x265E77C
	public static extern IntPtr FirebaseApp_CreateInternal__SWIG_0() { }

	// RVA: 0x265EA18 Offset: 0x265AA18 VA: 0x265EA18
	internal static extern void FirebaseApp_ReleaseReferenceInternal(HandleRef jarg1) { }

	// RVA: 0x265C224 Offset: 0x2658224 VA: 0x265C224
	internal static extern int FirebaseApp_GetLogLevelInternal() { }

	// RVA: 0x265EA94 Offset: 0x265AA94 VA: 0x265EA94
	internal static extern void FirebaseApp_RegisterLibrariesInternal(HandleRef jarg1) { }

	// RVA: 0x265EB10 Offset: 0x265AB10 VA: 0x265EB10
	internal static extern void FirebaseApp_LogHeartbeatInternal(HandleRef jarg1) { }

	// RVA: 0x265EB8C Offset: 0x265AB8C VA: 0x265EB8C
	public static extern void FirebaseApp_AppSetDefaultConfigPath(string jarg1) { }

	// RVA: 0x265EC18 Offset: 0x265AC18 VA: 0x265EC18
	public static extern string FirebaseApp_DefaultName_get() { }

	// RVA: 0x265F3B0 Offset: 0x265B3B0 VA: 0x265F3B0
	public static extern void PollCallbacks() { }

	// RVA: 0x265F414 Offset: 0x265B414 VA: 0x265F414
	public static extern void AppEnableLogCallback(bool jarg1) { }

	// RVA: 0x265F490 Offset: 0x265B490 VA: 0x265F490
	public static extern void SetEnabledAllAppCallbacks(bool jarg1) { }

	// RVA: 0x265F50C Offset: 0x265B50C VA: 0x265F50C
	public static extern void SetEnabledAppCallbackByName(string jarg1, bool jarg2) { }

	// RVA: 0x265F5A0 Offset: 0x265B5A0 VA: 0x265F5A0
	public static extern bool GetEnabledAppCallbackByName(string jarg1) { }

	// RVA: 0x265F638 Offset: 0x265B638 VA: 0x265F638
	public static extern void SetLogFunction(LogUtil.LogMessageDelegate jarg1) { }

	// RVA: 0x265F6B8 Offset: 0x265B6B8 VA: 0x265F6B8
	public static extern int CheckAndroidDependencies() { }

	// RVA: 0x265F720 Offset: 0x265B720 VA: 0x265F720
	public static extern IntPtr FixAndroidDependencies() { }

	// RVA: 0x265F788 Offset: 0x265B788 VA: 0x265F788
	internal static extern void InitializePlayServicesInternal() { }

	// RVA: 0x265F7EC Offset: 0x265B7EC VA: 0x265F7EC
	internal static extern void TerminatePlayServicesInternal() { }

	// RVA: 0x2658224 Offset: 0x2654224 VA: 0x2658224
	public static extern IntPtr FutureString_SWIGUpcast(IntPtr jarg1) { }

	// RVA: 0x2659614 Offset: 0x2655614 VA: 0x2659614
	public static extern IntPtr FutureVoid_SWIGUpcast(IntPtr jarg1) { }
}
