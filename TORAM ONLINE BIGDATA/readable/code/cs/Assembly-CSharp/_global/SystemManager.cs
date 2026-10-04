// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SystemManager : Singleton<SystemManager> // TypeDefIndex: 5585
{
	// Fields
	private string[] downloadUrl; // 0x20
	private SystemManager.BuildTypeS buildType; // 0x28
	[CompilerGenerated]
	private SystemManager.DownloadTypes <DownloadTypeDebug>k__BackingField; // 0x2C
	private SystemManager.ResourcesType resourcesType; // 0x30
	private bool isExResourcesURLFlag; // 0x34
	private string exResourcesURL; // 0x38
	private string[] serverIpS; // 0x40
	private int[] serverPorts; // 0x48
	private int[] serverTCPPorts; // 0x50
	[CompilerGenerated]
	private SystemManager.ServerSelectTypes <SelectServerDebug>k__BackingField; // 0x58
	private string serverIp; // 0x60
	private string[] masterApplicationName; // 0x68
	private string[] gameApplicationName; // 0x70
	private string[] globalApplicationName; // 0x78
	[CompilerGenerated]
	private SystemManager.ApplicationSelectTypes <SelectApplicationDebug>k__BackingField; // 0x80
	private const int AppId = 500;
	private string iteIntegrationApiServerUrl; // 0x88
	[CompilerGenerated]
	private string <WebAPIDomain>k__BackingField; // 0x90

	// Properties
	public SystemManager.BuildTypeS BuildType { get; set; }
	public SystemManager.DownloadTypes DownloadTypeDebug { get; set; }
	public SystemManager.ResourcesType CurrentResourcesType { get; }
	private SystemManager.DownloadTypes DownloadType { get; }
	public SystemManager.ServerSelectTypes SelectServerDebug { get; set; }
	private SystemManager.ServerSelectTypes SelectServer { get; }
	public string ServerIp { get; }
	public int ServerPort { get; }
	public int TCPServerPort { get; }
	public bool IsReleaseServer { get; }
	public SystemManager.ApplicationSelectTypes SelectApplicationDebug { get; set; }
	private SystemManager.ApplicationSelectTypes SelectApplication { get; }
	public string MasterApplicationName { get; }
	public string GameApplicationName { get; }
	public string GlobalApplicationName { get; }
	public string InfomationUrl { get; }
	public string MaintenanceUrl { get; }
	public string OnlyInHouseIpUrl { get; }
	public int MarketType { get; }
	public string PlatformCode { get; }
	public string DistributionCode { get; }
	public string IteIntegrationApiServerUrl { get; set; }
	public string AuthApiServerUrl { get; }
	public bool IsToramAccount { get; }
	public string WebAPIBaseURL { get; }
	public string WebViewBaseURL { get; }
	public string WebAPIDomain { get; set; }
	public string GetUserServiceIdURL { get; }
	public string ReviewInfomationURL { get; }
	public string OpenBrowserURL { get; }
	public string DisplayTitleURL { get; }
	public string AndroidPurchaseRegisterURL { get; }
	public string iOSPurchaseRegisterURL { get; }
	public string ProductListURL { get; }
	public string GachaListURL { get; }
	public string GachaDetailURL { get; }
	public string WebGachaBuyURL { get; }
	public string WebGachaTicketBuyURL { get; }
	public string LuckyBagListURL { get; }
	public string LuckyBagListDetailURL { get; }
	public string WebLuckyBagBuyURL { get; }
	public string GetOrbURL { get; }
	public string GetCurrencyURL { get; }
	public string GetTicketURL { get; }
	public string GetCourseURL { get; }
	public string WebBuyURL { get; }
	public string WebGetCoinRemainLapseNextURL { get; }
	public string WebGetCoinRemainLapseNumberURL { get; }
	public string WebGetCoinRemainLapseListURL { get; }
	public string WebViewLoginURL { get; }
	public string InquiryURL { get; }
	public string RestoreURL { get; }
	public string QuestionnaireURL { get; }
	public string CheckQuestionnaireURL { get; }
	public string SerialCodeURL { get; }
	public string GetCheckAgeURL { get; }
	public string RegistCheckAgeURL { get; }
	public string ProductHistoryCountURL { get; }
	public string GashaHistoryCountURL { get; }
	public string LuckyBagHistoryCountURL { get; }
	public string LotteryProductHistoryCountURL { get; }
	public string ProductHistory { get; }
	public string GashaHistory { get; }
	public string LuckyBagHistory { get; }
	public string CheckTermsDisplay { get; }
	public string AgreementTerms { get; }
	public string PaymentBonusURL { get; }
	public string PaymentBonusReservationURL { get; }
	public string PCPaymentBrowserParameterURL { get; }
	public string PCPaymentShopURL { get; }
	public string PCProductListURL { get; }
	public string SteamProductListURL { get; }
	public string SteamPaymentInitURL { get; }
	public string SteamPaymentCompleteURL { get; }

	// Methods

	// RVA: 0x179E00C Offset: 0x179A00C VA: 0x179E00C
	public SystemManager.BuildTypeS get_BuildType() { }

	// RVA: 0x179E014 Offset: 0x179A014 VA: 0x179E014
	public void set_BuildType(SystemManager.BuildTypeS value) { }

	[CompilerGenerated]
	// RVA: 0x179E01C Offset: 0x179A01C VA: 0x179E01C
	public SystemManager.DownloadTypes get_DownloadTypeDebug() { }

	[CompilerGenerated]
	// RVA: 0x179E024 Offset: 0x179A024 VA: 0x179E024
	public void set_DownloadTypeDebug(SystemManager.DownloadTypes value) { }

	// RVA: 0x179E02C Offset: 0x179A02C VA: 0x179E02C
	public SystemManager.ResourcesType get_CurrentResourcesType() { }

	// RVA: 0x179E034 Offset: 0x179A034 VA: 0x179E034
	private SystemManager.DownloadTypes get_DownloadType() { }

	// RVA: 0x179E054 Offset: 0x179A054 VA: 0x179E054
	public void SetResourcesType(SystemManager.ResourcesType type) { }

	// RVA: 0x179E060 Offset: 0x179A060 VA: 0x179E060
	public SystemManager.ResourcesType GetReleaseResourceType(string type) { }

	// RVA: 0x179E17C Offset: 0x179A17C VA: 0x179E17C
	public bool CheckReleaseResourceType(SystemManager.ResourcesType type) { }

	// RVA: 0x179E18C Offset: 0x179A18C VA: 0x179E18C
	private string getResourcesDir() { }

	// RVA: 0x179E22C Offset: 0x179A22C VA: 0x179E22C
	public void SetExResourcesURL(string url) { }

	// RVA: 0x179E23C Offset: 0x179A23C VA: 0x179E23C
	public string GetDownloadSystemDataURL() { }

	// RVA: 0x179E4E8 Offset: 0x179A4E8 VA: 0x179E4E8
	public string GetDownloadURL() { }

	// RVA: 0x179E3C0 Offset: 0x179A3C0 VA: 0x179E3C0
	private string GetLocalResourcePath(string folder) { }

	// RVA: 0x17918E8 Offset: 0x178D8E8 VA: 0x17918E8
	public string GetOrbShopDownloadURL(string folder) { }

	// RVA: 0x179E720 Offset: 0x179A720 VA: 0x179E720
	public string GetBannerDownloadURL() { }

	// RVA: 0x179E84C Offset: 0x179A84C VA: 0x179E84C
	public string GetExternalNgWordDownloadURL() { }

	[CompilerGenerated]
	// RVA: 0x179E950 Offset: 0x179A950 VA: 0x179E950
	public SystemManager.ServerSelectTypes get_SelectServerDebug() { }

	[CompilerGenerated]
	// RVA: 0x179E958 Offset: 0x179A958 VA: 0x179E958
	public void set_SelectServerDebug(SystemManager.ServerSelectTypes value) { }

	// RVA: 0x179E4C8 Offset: 0x179A4C8 VA: 0x179E4C8
	private SystemManager.ServerSelectTypes get_SelectServer() { }

	// RVA: 0x179E960 Offset: 0x179A960 VA: 0x179E960
	public string get_ServerIp() { }

	// RVA: 0x179E9FC Offset: 0x179A9FC VA: 0x179E9FC
	public int get_ServerPort() { }

	// RVA: 0x179EA40 Offset: 0x179AA40 VA: 0x179EA40
	public int get_TCPServerPort() { }

	// RVA: 0x179EA84 Offset: 0x179AA84 VA: 0x179EA84
	public bool get_IsReleaseServer() { }

	[CompilerGenerated]
	// RVA: 0x179EAA4 Offset: 0x179AAA4 VA: 0x179EAA4
	public SystemManager.ApplicationSelectTypes get_SelectApplicationDebug() { }

	[CompilerGenerated]
	// RVA: 0x179EAAC Offset: 0x179AAAC VA: 0x179EAAC
	public void set_SelectApplicationDebug(SystemManager.ApplicationSelectTypes value) { }

	// RVA: 0x179EAB4 Offset: 0x179AAB4 VA: 0x179EAB4
	private SystemManager.ApplicationSelectTypes get_SelectApplication() { }

	// RVA: 0x179EAD4 Offset: 0x179AAD4 VA: 0x179EAD4
	public string get_MasterApplicationName() { }

	// RVA: 0x179EB18 Offset: 0x179AB18 VA: 0x179EB18
	public string get_GameApplicationName() { }

	// RVA: 0x179EB5C Offset: 0x179AB5C VA: 0x179EB5C
	public string get_GlobalApplicationName() { }

	// RVA: 0x179EBA0 Offset: 0x179ABA0 VA: 0x179EBA0
	private void Awake() { }

	// RVA: 0x179EC0C Offset: 0x179AC0C VA: 0x179EC0C
	public void SetServerIp(string domain) { }

	// RVA: 0x179ECE4 Offset: 0x179ACE4 VA: 0x179ECE4
	public string get_InfomationUrl() { }

	// RVA: 0x17918A8 Offset: 0x178D8A8 VA: 0x17918A8
	public string get_MaintenanceUrl() { }

	// RVA: 0x179EE18 Offset: 0x179AE18 VA: 0x179EE18
	public string get_OnlyInHouseIpUrl() { }

	// RVA: 0x17918A0 Offset: 0x178D8A0 VA: 0x17918A0
	public int get_MarketType() { }

	// RVA: 0x179EE58 Offset: 0x179AE58 VA: 0x179EE58
	public string get_PlatformCode() { }

	// RVA: 0x179EE98 Offset: 0x179AE98 VA: 0x179EE98
	public string get_DistributionCode() { }

	// RVA: 0x179EED8 Offset: 0x179AED8 VA: 0x179EED8
	public string get_IteIntegrationApiServerUrl() { }

	// RVA: 0x179EEE0 Offset: 0x179AEE0 VA: 0x179EEE0
	public void set_IteIntegrationApiServerUrl(string value) { }

	// RVA: 0x179EEE8 Offset: 0x179AEE8 VA: 0x179EEE8
	public string get_AuthApiServerUrl() { }

	// RVA: 0x179EF30 Offset: 0x179AF30 VA: 0x179EF30
	public bool get_IsToramAccount() { }

	// RVA: 0x179EF38 Offset: 0x179AF38 VA: 0x179EF38
	public string get_WebAPIBaseURL() { }

	// RVA: 0x179ED2C Offset: 0x179AD2C VA: 0x179ED2C
	public string get_WebViewBaseURL() { }

	[CompilerGenerated]
	// RVA: 0x179EFD8 Offset: 0x179AFD8 VA: 0x179EFD8
	public string get_WebAPIDomain() { }

	[CompilerGenerated]
	// RVA: 0x179EFE0 Offset: 0x179AFE0 VA: 0x179EFE0
	public void set_WebAPIDomain(string value) { }

	// RVA: 0x179EFE8 Offset: 0x179AFE8 VA: 0x179EFE8
	public string get_GetUserServiceIdURL() { }

	// RVA: 0x179F038 Offset: 0x179B038 VA: 0x179F038
	public string get_ReviewInfomationURL() { }

	// RVA: 0x179F088 Offset: 0x179B088 VA: 0x179F088
	public string get_OpenBrowserURL() { }

	// RVA: 0x179F0D8 Offset: 0x179B0D8 VA: 0x179F0D8
	public string get_DisplayTitleURL() { }

	// RVA: 0x179F128 Offset: 0x179B128 VA: 0x179F128
	public string get_AndroidPurchaseRegisterURL() { }

	// RVA: 0x179F178 Offset: 0x179B178 VA: 0x179F178
	public string get_iOSPurchaseRegisterURL() { }

	// RVA: 0x179F1C8 Offset: 0x179B1C8 VA: 0x179F1C8
	public string get_ProductListURL() { }

	// RVA: 0x179F218 Offset: 0x179B218 VA: 0x179F218
	public string get_GachaListURL() { }

	// RVA: 0x179F268 Offset: 0x179B268 VA: 0x179F268
	public string get_GachaDetailURL() { }

	// RVA: 0x179F2B8 Offset: 0x179B2B8 VA: 0x179F2B8
	public string get_WebGachaBuyURL() { }

	// RVA: 0x179F308 Offset: 0x179B308 VA: 0x179F308
	public string get_WebGachaTicketBuyURL() { }

	// RVA: 0x179F358 Offset: 0x179B358 VA: 0x179F358
	public string get_LuckyBagListURL() { }

	// RVA: 0x179F3A8 Offset: 0x179B3A8 VA: 0x179F3A8
	public string get_LuckyBagListDetailURL() { }

	// RVA: 0x179F3F8 Offset: 0x179B3F8 VA: 0x179F3F8
	public string get_WebLuckyBagBuyURL() { }

	// RVA: 0x179F448 Offset: 0x179B448 VA: 0x179F448
	public string get_GetOrbURL() { }

	// RVA: 0x179F498 Offset: 0x179B498 VA: 0x179F498
	public string get_GetCurrencyURL() { }

	// RVA: 0x179F4E8 Offset: 0x179B4E8 VA: 0x179F4E8
	public string get_GetTicketURL() { }

	// RVA: 0x179F538 Offset: 0x179B538 VA: 0x179F538
	public string get_GetCourseURL() { }

	// RVA: 0x179F588 Offset: 0x179B588 VA: 0x179F588
	public string get_WebBuyURL() { }

	// RVA: 0x179F5D8 Offset: 0x179B5D8 VA: 0x179F5D8
	public string get_WebGetCoinRemainLapseNextURL() { }

	// RVA: 0x179F628 Offset: 0x179B628 VA: 0x179F628
	public string get_WebGetCoinRemainLapseNumberURL() { }

	// RVA: 0x179F678 Offset: 0x179B678 VA: 0x179F678
	public string get_WebGetCoinRemainLapseListURL() { }

	// RVA: 0x179F6C8 Offset: 0x179B6C8 VA: 0x179F6C8
	public string get_WebViewLoginURL() { }

	// RVA: 0x179F718 Offset: 0x179B718 VA: 0x179F718
	public string get_InquiryURL() { }

	// RVA: 0x179F768 Offset: 0x179B768 VA: 0x179F768
	public string get_RestoreURL() { }

	// RVA: 0x179F7A8 Offset: 0x179B7A8 VA: 0x179F7A8
	public string get_QuestionnaireURL() { }

	// RVA: 0x179F7E8 Offset: 0x179B7E8 VA: 0x179F7E8
	public string get_CheckQuestionnaireURL() { }

	// RVA: 0x179F838 Offset: 0x179B838 VA: 0x179F838
	public string get_SerialCodeURL() { }

	// RVA: 0x179F888 Offset: 0x179B888 VA: 0x179F888
	public string get_GetCheckAgeURL() { }

	// RVA: 0x179F8D8 Offset: 0x179B8D8 VA: 0x179F8D8
	public string get_RegistCheckAgeURL() { }

	// RVA: 0x179F928 Offset: 0x179B928 VA: 0x179F928
	public string get_ProductHistoryCountURL() { }

	// RVA: 0x179F978 Offset: 0x179B978 VA: 0x179F978
	public string get_GashaHistoryCountURL() { }

	// RVA: 0x179F9C8 Offset: 0x179B9C8 VA: 0x179F9C8
	public string get_LuckyBagHistoryCountURL() { }

	// RVA: 0x179FA18 Offset: 0x179BA18 VA: 0x179FA18
	public string get_LotteryProductHistoryCountURL() { }

	// RVA: 0x179FA68 Offset: 0x179BA68 VA: 0x179FA68
	public string get_ProductHistory() { }

	// RVA: 0x179FAB8 Offset: 0x179BAB8 VA: 0x179FAB8
	public string get_GashaHistory() { }

	// RVA: 0x179FB08 Offset: 0x179BB08 VA: 0x179FB08
	public string get_LuckyBagHistory() { }

	// RVA: 0x179FB58 Offset: 0x179BB58 VA: 0x179FB58
	public string get_CheckTermsDisplay() { }

	// RVA: 0x179FBA8 Offset: 0x179BBA8 VA: 0x179FBA8
	public string get_AgreementTerms() { }

	// RVA: 0x179FBF8 Offset: 0x179BBF8 VA: 0x179FBF8
	public string get_PaymentBonusURL() { }

	// RVA: 0x179FC48 Offset: 0x179BC48 VA: 0x179FC48
	public string get_PaymentBonusReservationURL() { }

	// RVA: 0x179FC98 Offset: 0x179BC98 VA: 0x179FC98
	public string get_PCPaymentBrowserParameterURL() { }

	// RVA: 0x179FCE8 Offset: 0x179BCE8 VA: 0x179FCE8
	public string get_PCPaymentShopURL() { }

	// RVA: 0x179FD38 Offset: 0x179BD38 VA: 0x179FD38
	public string get_PCProductListURL() { }

	// RVA: 0x179FD88 Offset: 0x179BD88 VA: 0x179FD88
	public string get_SteamProductListURL() { }

	// RVA: 0x179FDD8 Offset: 0x179BDD8 VA: 0x179FDD8
	public string get_SteamPaymentInitURL() { }

	// RVA: 0x179FE28 Offset: 0x179BE28 VA: 0x179FE28
	public string get_SteamPaymentCompleteURL() { }

	// RVA: 0x179FE78 Offset: 0x179BE78 VA: 0x179FE78
	public void .ctor() { }
}
