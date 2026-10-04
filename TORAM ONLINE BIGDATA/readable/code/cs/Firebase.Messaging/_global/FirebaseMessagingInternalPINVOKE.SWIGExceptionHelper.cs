// Assembly: Firebase.Messaging.dll
// Namespace: 
protected class FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper // TypeDefIndex: 17711
{
	// Fields
	private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate; // 0x0
	private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate; // 0x8
	private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate; // 0x10
	private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate; // 0x18
	private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate; // 0x20
	private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate; // 0x28
	private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate; // 0x30
	private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate; // 0x38
	private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate; // 0x40
	private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate; // 0x48
	private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate; // 0x50
	private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate; // 0x58
	private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate; // 0x60
	private static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate; // 0x68

	// Methods

	// RVA: 0x2665E78 Offset: 0x2661E78 VA: 0x2665E78
	internal static extern void SWIGRegisterExceptionCallbacks_FirebaseMessagingInternal(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate) { }

	// RVA: 0x2665FE4 Offset: 0x2661FE4 VA: 0x2665FE4
	internal static extern void SWIGRegisterExceptionCallbacksArgument_FirebaseMessagingInternal(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate) { }

	[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x26655E8 Offset: 0x26615E8 VA: 0x26655E8
	private static void SetPendingApplicationException(string message) { }

	[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x2665678 Offset: 0x2661678 VA: 0x2665678
	private static void SetPendingArithmeticException(string message) { }

	[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x2665708 Offset: 0x2661708 VA: 0x2665708
	private static void SetPendingDivideByZeroException(string message) { }

	[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x2665798 Offset: 0x2661798 VA: 0x2665798
	private static void SetPendingIndexOutOfRangeException(string message) { }

	[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x2665828 Offset: 0x2661828 VA: 0x2665828
	private static void SetPendingInvalidCastException(string message) { }

	[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x26658B8 Offset: 0x26618B8 VA: 0x26658B8
	private static void SetPendingInvalidOperationException(string message) { }

	[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x2665948 Offset: 0x2661948 VA: 0x2665948
	private static void SetPendingIOException(string message) { }

	[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x26659D8 Offset: 0x26619D8 VA: 0x26659D8
	private static void SetPendingNullReferenceException(string message) { }

	[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x2665A68 Offset: 0x2661A68 VA: 0x2665A68
	private static void SetPendingOutOfMemoryException(string message) { }

	[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x2665AF8 Offset: 0x2661AF8 VA: 0x2665AF8
	private static void SetPendingOverflowException(string message) { }

	[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
	// RVA: 0x2665B88 Offset: 0x2661B88 VA: 0x2665B88
	private static void SetPendingSystemException(string message) { }

	[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate))]
	// RVA: 0x2665C18 Offset: 0x2661C18 VA: 0x2665C18
	private static void SetPendingArgumentException(string message, string paramName) { }

	[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate))]
	// RVA: 0x2665CB8 Offset: 0x2661CB8 VA: 0x2665CB8
	private static void SetPendingArgumentNullException(string message, string paramName) { }

	[MonoPInvokeCallback(typeof(FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate))]
	// RVA: 0x2665D98 Offset: 0x2661D98 VA: 0x2665D98
	private static void SetPendingArgumentOutOfRangeException(string message, string paramName) { }

	// RVA: 0x2666420 Offset: 0x2662420 VA: 0x2666420
	private static void .cctor() { }

	// RVA: 0x2665374 Offset: 0x2661374 VA: 0x2665374
	public void .ctor() { }
}
