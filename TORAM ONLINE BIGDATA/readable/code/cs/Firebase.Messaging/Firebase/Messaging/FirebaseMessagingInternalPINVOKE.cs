// Assembly: Firebase.Messaging.dll
// Namespace: Firebase.Messaging
internal class FirebaseMessagingInternalPINVOKE // TypeDefIndex: 17715
{
	// Fields
	protected static FirebaseMessagingInternalPINVOKE.SWIGExceptionHelper swigExceptionHelper; // 0x0
	protected static FirebaseMessagingInternalPINVOKE.SWIGStringHelper swigStringHelper; // 0x8

	// Methods

	// RVA: 0x26652B4 Offset: 0x26612B4 VA: 0x26652B4
	private static void .cctor() { }

	// RVA: 0x2663BF4 Offset: 0x265FBF4 VA: 0x2663BF4
	public static extern string AndroidNotificationParamsInternal_channel_id_get(HandleRef jarg1) { }

	// RVA: 0x2663B78 Offset: 0x265FB78 VA: 0x2663B78
	internal static extern void delete_AndroidNotificationParamsInternal(HandleRef jarg1) { }

	// RVA: 0x2663FB0 Offset: 0x265FFB0 VA: 0x2663FB0
	internal static extern void delete_FirebaseNotificationInternal(HandleRef jarg1) { }

	// RVA: 0x266402C Offset: 0x266002C VA: 0x266402C
	public static extern string FirebaseNotificationInternal_title_get(HandleRef jarg1) { }

	// RVA: 0x26640C0 Offset: 0x26600C0 VA: 0x26640C0
	public static extern string FirebaseNotificationInternal_body_get(HandleRef jarg1) { }

	// RVA: 0x2664154 Offset: 0x2660154 VA: 0x2664154
	public static extern string FirebaseNotificationInternal_icon_get(HandleRef jarg1) { }

	// RVA: 0x26641E8 Offset: 0x26601E8 VA: 0x26641E8
	public static extern string FirebaseNotificationInternal_sound_get(HandleRef jarg1) { }

	// RVA: 0x266427C Offset: 0x266027C VA: 0x266427C
	public static extern string FirebaseNotificationInternal_badge_get(HandleRef jarg1) { }

	// RVA: 0x2664310 Offset: 0x2660310 VA: 0x2664310
	public static extern string FirebaseNotificationInternal_tag_get(HandleRef jarg1) { }

	// RVA: 0x26643A4 Offset: 0x26603A4 VA: 0x26643A4
	public static extern string FirebaseNotificationInternal_color_get(HandleRef jarg1) { }

	// RVA: 0x2664438 Offset: 0x2660438 VA: 0x2664438
	public static extern string FirebaseNotificationInternal_click_action_get(HandleRef jarg1) { }

	// RVA: 0x26644CC Offset: 0x26604CC VA: 0x26644CC
	public static extern string FirebaseNotificationInternal_body_loc_key_get(HandleRef jarg1) { }

	// RVA: 0x2664560 Offset: 0x2660560 VA: 0x2664560
	public static extern IntPtr FirebaseNotificationInternal_body_loc_args_get(HandleRef jarg1) { }

	// RVA: 0x26645DC Offset: 0x26605DC VA: 0x26645DC
	public static extern string FirebaseNotificationInternal_title_loc_key_get(HandleRef jarg1) { }

	// RVA: 0x2664670 Offset: 0x2660670 VA: 0x2664670
	public static extern IntPtr FirebaseNotificationInternal_title_loc_args_get(HandleRef jarg1) { }

	// RVA: 0x26646EC Offset: 0x26606EC VA: 0x26646EC
	public static extern IntPtr FirebaseNotificationInternal_android_get(HandleRef jarg1) { }

	// RVA: 0x2664A90 Offset: 0x2660A90 VA: 0x2664A90
	internal static extern void delete_FirebaseMessageInternal(HandleRef jarg1) { }

	// RVA: 0x2664B0C Offset: 0x2660B0C VA: 0x2664B0C
	public static extern string FirebaseMessageInternal_from_get(HandleRef jarg1) { }

	// RVA: 0x2664BA0 Offset: 0x2660BA0 VA: 0x2664BA0
	public static extern string FirebaseMessageInternal_to_get(HandleRef jarg1) { }

	// RVA: 0x2664C34 Offset: 0x2660C34 VA: 0x2664C34
	public static extern string FirebaseMessageInternal_collapse_key_get(HandleRef jarg1) { }

	// RVA: 0x2664CC8 Offset: 0x2660CC8 VA: 0x2664CC8
	public static extern IntPtr FirebaseMessageInternal_data_get(HandleRef jarg1) { }

	// RVA: 0x2664D44 Offset: 0x2660D44 VA: 0x2664D44
	public static extern IntPtr FirebaseMessageInternal_raw_data_get(HandleRef jarg1) { }

	// RVA: 0x2664DC0 Offset: 0x2660DC0 VA: 0x2664DC0
	public static extern string FirebaseMessageInternal_message_id_get(HandleRef jarg1) { }

	// RVA: 0x2664E54 Offset: 0x2660E54 VA: 0x2664E54
	public static extern string FirebaseMessageInternal_message_type_get(HandleRef jarg1) { }

	// RVA: 0x2664EE8 Offset: 0x2660EE8 VA: 0x2664EE8
	public static extern string FirebaseMessageInternal_priority_get(HandleRef jarg1) { }

	// RVA: 0x2664F7C Offset: 0x2660F7C VA: 0x2664F7C
	public static extern int FirebaseMessageInternal_time_to_live_get(HandleRef jarg1) { }

	// RVA: 0x2664FF8 Offset: 0x2660FF8 VA: 0x2664FF8
	public static extern string FirebaseMessageInternal_error_get(HandleRef jarg1) { }

	// RVA: 0x266508C Offset: 0x266108C VA: 0x266508C
	public static extern string FirebaseMessageInternal_error_description_get(HandleRef jarg1) { }

	// RVA: 0x2665120 Offset: 0x2661120 VA: 0x2665120
	public static extern IntPtr FirebaseMessageInternal_notification_get(HandleRef jarg1) { }

	// RVA: 0x266519C Offset: 0x266119C VA: 0x266519C
	public static extern bool FirebaseMessageInternal_notification_opened_get(HandleRef jarg1) { }

	// RVA: 0x2665220 Offset: 0x2661220 VA: 0x2665220
	public static extern string FirebaseMessageInternal_link_get(HandleRef jarg1) { }

	// RVA: 0x2665384 Offset: 0x2661384 VA: 0x2665384
	public static extern void SetTokenRegistrationOnInitEnabled(bool jarg1) { }

	// RVA: 0x2665400 Offset: 0x2661400 VA: 0x2665400
	public static extern IntPtr GetToken() { }

	// RVA: 0x2665468 Offset: 0x2661468 VA: 0x2665468
	public static extern void SetListenerCallbacks(FirebaseMessagingInternal.Listener.MessageReceivedDelegate jarg1, FirebaseMessagingInternal.Listener.TokenReceivedDelegate jarg2) { }

	// RVA: 0x2665500 Offset: 0x2661500 VA: 0x2665500
	public static extern void SetListenerCallbacksEnabled(bool jarg1, bool jarg2) { }

	// RVA: 0x2665584 Offset: 0x2661584 VA: 0x2665584
	public static extern void SendPendingEvents() { }
}
