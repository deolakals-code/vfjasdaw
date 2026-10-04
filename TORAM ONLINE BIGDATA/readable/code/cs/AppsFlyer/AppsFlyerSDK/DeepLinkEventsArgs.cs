// Assembly: AppsFlyer.dll
// Namespace: AppsFlyerSDK
public class DeepLinkEventsArgs : EventArgs // TypeDefIndex: 17290
{
	// Fields
	public Dictionary<string, object> deepLink; // 0x10
	[CompilerGenerated]
	private readonly DeepLinkStatus <status>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly DeepLinkError <error>k__BackingField; // 0x1C

	// Properties
	public DeepLinkStatus status { get; }
	public DeepLinkError error { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x16FA3C0 Offset: 0x16F63C0 VA: 0x16FA3C0
	public DeepLinkStatus get_status() { }

	[CompilerGenerated]
	// RVA: 0x16FA3C8 Offset: 0x16F63C8 VA: 0x16FA3C8
	public DeepLinkError get_error() { }

	// RVA: 0x16FA3D0 Offset: 0x16F63D0 VA: 0x16FA3D0
	public string getMatchType() { }

	// RVA: 0x16FA4D4 Offset: 0x16F64D4 VA: 0x16FA4D4
	public string getDeepLinkValue() { }

	// RVA: 0x16FA51C Offset: 0x16F651C VA: 0x16FA51C
	public string getClickHttpReferrer() { }

	// RVA: 0x16FA564 Offset: 0x16F6564 VA: 0x16FA564
	public string getMediaSource() { }

	// RVA: 0x16FA5AC Offset: 0x16F65AC VA: 0x16FA5AC
	public string getCampaign() { }

	// RVA: 0x16FA5F4 Offset: 0x16F65F4 VA: 0x16FA5F4
	public string getCampaignId() { }

	// RVA: 0x16FA63C Offset: 0x16F663C VA: 0x16FA63C
	public string getAfSub1() { }

	// RVA: 0x16FA684 Offset: 0x16F6684 VA: 0x16FA684
	public string getAfSub2() { }

	// RVA: 0x16FA6CC Offset: 0x16F66CC VA: 0x16FA6CC
	public string getAfSub3() { }

	// RVA: 0x16FA714 Offset: 0x16F6714 VA: 0x16FA714
	public string getAfSub4() { }

	// RVA: 0x16FA75C Offset: 0x16F675C VA: 0x16FA75C
	public string getAfSub5() { }

	// RVA: 0x16FA7A4 Offset: 0x16F67A4 VA: 0x16FA7A4
	public bool isDeferred() { }

	// RVA: 0x16FA948 Offset: 0x16F6948 VA: 0x16FA948
	public Dictionary<string, object> getDeepLinkDictionary() { }

	// RVA: 0x16F4CF4 Offset: 0x16F0CF4 VA: 0x16F4CF4
	public void .ctor(string str) { }

	// RVA: 0x16FA418 Offset: 0x16F6418 VA: 0x16FA418
	private string getDeepLinkParameter(string name) { }
}
