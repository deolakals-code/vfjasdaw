// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class PluginUtil // TypeDefIndex: 5532
{
	// Methods

	[Obsolete("旧バージョンチェック")]
	// RVA: 0x1791AC8 Offset: 0x178DAC8 VA: 0x1791AC8
	public static bool CheckUpdate() { }

	// RVA: 0x1791D40 Offset: 0x178DD40 VA: 0x1791D40
	public static bool CheckUpdate(int serverAppVer) { }

	// RVA: 0x1791FC8 Offset: 0x178DFC8 VA: 0x1791FC8
	public static void UpdateApp(int serverAppVer) { }

	// RVA: 0x17923A0 Offset: 0x178E3A0 VA: 0x17923A0
	public static bool IsFinishedUpdate() { }

	// RVA: 0x17925E4 Offset: 0x178E5E4 VA: 0x17925E4
	public static float GetNewAppDownloadRate() { }

	// RVA: 0x1792830 Offset: 0x178E830 VA: 0x1792830
	public static string GetBundleIdentifier() { }

	// RVA: 0x1792A74 Offset: 0x178EA74 VA: 0x1792A74
	public static int GetSDKInt() { }

	// RVA: 0x1792C54 Offset: 0x178EC54 VA: 0x1792C54
	public static string GetOSVersion() { }

	// RVA: 0x1792E50 Offset: 0x178EE50 VA: 0x1792E50
	public static string GetModelName() { }

	// RVA: 0x179304C Offset: 0x178F04C VA: 0x179304C
	public static long GetFreeDiscSpaceMB() { }

	// RVA: 0x1793050 Offset: 0x178F050 VA: 0x1793050
	private static long GetAvailableStorageByteMB() { }

	// RVA: 0x179329C Offset: 0x178F29C VA: 0x179329C
	public static void RenderToTextureIPhone(Texture2D target, int dst_x, int dst_y, int dst_w, int dst_h, Font font, int fontSize, string text) { }

	// RVA: 0x17932A0 Offset: 0x178F2A0 VA: 0x17932A0
	public static void RenderToTextureIPhone(Texture2D target, int dst_x, int dst_y, int dst_w, int dst_h, Font font, int fontSize, string text, string fontName) { }

	// RVA: 0x17932A4 Offset: 0x178F2A4 VA: 0x17932A4
	public static int[] SystemFontRendererCreateTextRaster(string text, int width, int height, int fontSize) { }

	// RVA: 0x17932E8 Offset: 0x178F2E8 VA: 0x17932E8
	public static int[] SystemFontRendererCreateTextRaster(string text, int width, int height, int fontSize, string fontName) { }

	// RVA: 0x179332C Offset: 0x178F32C VA: 0x179332C
	public static string GetAppliName() { }

	// RVA: 0x179343C Offset: 0x178F43C VA: 0x179343C
	public static string GetVersionName() { }

	// RVA: 0x1793440 Offset: 0x178F440 VA: 0x1793440
	public static float GetBatteryRate() { }

	// RVA: 0x1793448 Offset: 0x178F448 VA: 0x1793448
	public static long GetFreeMemory() { }

	// RVA: 0x179368C Offset: 0x178F68C VA: 0x179368C
	public static long GetRamMemory() { }

	// RVA: 0x17938D0 Offset: 0x178F8D0 VA: 0x17938D0
	public static void WriteImageToAlbum(string path) { }

	// RVA: 0x17938D4 Offset: 0x178F8D4 VA: 0x17938D4
	public static int GetWriteImageToAlbumState() { }

	// RVA: 0x17938DC Offset: 0x178F8DC VA: 0x17938DC
	public static int CheckWarningDevice() { }

	// RVA: 0x17938E4 Offset: 0x178F8E4 VA: 0x17938E4
	public static string GetDeviceModelNumber() { }

	// RVA: 0x179392C Offset: 0x178F92C VA: 0x179392C
	public static DateTime GetDateTimeNow() { }
}
