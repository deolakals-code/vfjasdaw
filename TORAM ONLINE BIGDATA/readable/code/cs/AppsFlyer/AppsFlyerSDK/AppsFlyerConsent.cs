// Assembly: AppsFlyer.dll
// Namespace: AppsFlyerSDK
public class AppsFlyerConsent // TypeDefIndex: 17288
{
	// Fields
	[CompilerGenerated]
	private Nullable<bool> <isUserSubjectToGDPR>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<bool> <hasConsentForDataUsage>k__BackingField; // 0x12
	[CompilerGenerated]
	private Nullable<bool> <hasConsentForAdsPersonalization>k__BackingField; // 0x14
	[CompilerGenerated]
	private Nullable<bool> <hasConsentForAdStorage>k__BackingField; // 0x16

	// Properties
	public Nullable<bool> isUserSubjectToGDPR { get; set; }
	public Nullable<bool> hasConsentForDataUsage { get; set; }
	public Nullable<bool> hasConsentForAdsPersonalization { get; set; }
	public Nullable<bool> hasConsentForAdStorage { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x16FA164 Offset: 0x16F6164 VA: 0x16FA164
	public Nullable<bool> get_isUserSubjectToGDPR() { }

	[CompilerGenerated]
	// RVA: 0x16FA16C Offset: 0x16F616C VA: 0x16FA16C
	private void set_isUserSubjectToGDPR(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x16FA174 Offset: 0x16F6174 VA: 0x16FA174
	public Nullable<bool> get_hasConsentForDataUsage() { }

	[CompilerGenerated]
	// RVA: 0x16FA17C Offset: 0x16F617C VA: 0x16FA17C
	private void set_hasConsentForDataUsage(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x16FA184 Offset: 0x16F6184 VA: 0x16FA184
	public Nullable<bool> get_hasConsentForAdsPersonalization() { }

	[CompilerGenerated]
	// RVA: 0x16FA18C Offset: 0x16F618C VA: 0x16FA18C
	private void set_hasConsentForAdsPersonalization(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x16FA194 Offset: 0x16F6194 VA: 0x16FA194
	public Nullable<bool> get_hasConsentForAdStorage() { }

	[CompilerGenerated]
	// RVA: 0x16FA19C Offset: 0x16F619C VA: 0x16FA19C
	private void set_hasConsentForAdStorage(Nullable<bool> value) { }

	// RVA: 0x16FA1A4 Offset: 0x16F61A4 VA: 0x16FA1A4
	public void .ctor(Nullable<bool> isUserSubjectToGDPR, Nullable<bool> hasConsentForDataUsage, Nullable<bool> hasConsentForAdsPersonalization, Nullable<bool> hasConsentForAdStorage) { }

	[Obsolete("Use the new constructor with optional booleans instead.")]
	// RVA: 0x16FA1EC Offset: 0x16F61EC VA: 0x16FA1EC
	private void .ctor(bool isGDPR, bool hasForDataUsage, bool hasForAdsPersonalization) { }

	[Obsolete("Use new AppsFlyerConsent(...) instead.")]
	// RVA: 0x16FA2B0 Offset: 0x16F62B0 VA: 0x16FA2B0
	public static AppsFlyerConsent ForGDPRUser(bool hasConsentForDataUsage, bool hasConsentForAdsPersonalization) { }

	[Obsolete("Use new AppsFlyerConsent(...) instead.")]
	// RVA: 0x16FA31C Offset: 0x16F631C VA: 0x16FA31C
	public static AppsFlyerConsent ForNonGDPRUser() { }
}
