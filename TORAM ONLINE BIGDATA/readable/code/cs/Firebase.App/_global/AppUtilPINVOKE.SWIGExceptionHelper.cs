// Assembly: Firebase.App.dll
// Namespace: 
protected class AppUtilPINVOKE.SWIGExceptionHelper // TypeDefIndex: 17232
{
	// Fields
	private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate; // 0x0
	private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate; // 0x8
	private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate; // 0x10
	private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate; // 0x18
	private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate; // 0x20
	private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate; // 0x28
	private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate; // 0x30
	private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate; // 0x38
	private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate; // 0x40
	private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate; // 0x48
	private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate; // 0x50
	private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate; // 0x58
	private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate; // 0x60
	private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate; // 0x68

	// Methods

	// RVA: 0x26600E0 Offset: 0x265C0E0 VA: 0x26600E0
	public static extern void SWIGRegisterExceptionCallbacks_AppUtil(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate) { }

	// RVA: 0x266024C Offset: 0x265C24C VA: 0x266024C
	public static extern void SWIGRegisterExceptionCallbacksArgument_AppUtil(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate) { }

	[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x265F850 Offset: 0x265B850 VA: 0x265F850
	private static void SetPendingApplicationException(string message) { }

	[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x265F8E0 Offset: 0x265B8E0 VA: 0x265F8E0
	private static void SetPendingArithmeticException(string message) { }

	[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x265F970 Offset: 0x265B970 VA: 0x265F970
	private static void SetPendingDivideByZeroException(string message) { }

	[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x265FA00 Offset: 0x265BA00 VA: 0x265FA00
	private static void SetPendingIndexOutOfRangeException(string message) { }

	[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x265FA90 Offset: 0x265BA90 VA: 0x265FA90
	private static void SetPendingInvalidCastException(string message) { }

	[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x265FB20 Offset: 0x265BB20 VA: 0x265FB20
	private static void SetPendingInvalidOperationException(string message) { }

	[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x265FBB0 Offset: 0x265BBB0 VA: 0x265FBB0
	private static void SetPendingIOException(string message) { }

	[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x265FC40 Offset: 0x265BC40 VA: 0x265FC40
	private static void SetPendingNullReferenceException(string message) { }

	[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x265FCD0 Offset: 0x265BCD0 VA: 0x265FCD0
	private static void SetPendingOutOfMemoryException(string message) { }

	[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x265FD60 Offset: 0x265BD60 VA: 0x265FD60
	private static void SetPendingOverflowException(string message) { }

	[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x265FDF0 Offset: 0x265BDF0 VA: 0x265FDF0
	private static void SetPendingSystemException(string message) { }

	[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate))]
	// RVA: 0x265FE80 Offset: 0x265BE80 VA: 0x265FE80
	private static void SetPendingArgumentException(string message, string paramName) { }

	[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate))]
	// RVA: 0x265FF20 Offset: 0x265BF20 VA: 0x265FF20
	private static void SetPendingArgumentNullException(string message, string paramName) { }

	[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate))]
	// RVA: 0x2660000 Offset: 0x265C000 VA: 0x2660000
	private static void SetPendingArgumentOutOfRangeException(string message, string paramName) { }

	// RVA: 0x2660504 Offset: 0x265C504 VA: 0x2660504
	private static void .cctor() { }

	// RVA: 0x265F3A0 Offset: 0x265B3A0 VA: 0x265F3A0
	public void .ctor() { }
}
