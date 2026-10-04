// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum RuntimePlatform // TypeDefIndex: 16205
{
	// Fields
	public int value__; // 0x0
	public const RuntimePlatform OSXEditor = 0;
	public const RuntimePlatform OSXPlayer = 1;
	public const RuntimePlatform WindowsPlayer = 2;
	[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.", True)]
	public const RuntimePlatform OSXWebPlayer = 3;
	[Obsolete("Dashboard widget on Mac OS X export is no longer supported in Unity 5.4+.", True)]
	public const RuntimePlatform OSXDashboardPlayer = 4;
	[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.", True)]
	public const RuntimePlatform WindowsWebPlayer = 5;
	public const RuntimePlatform WindowsEditor = 7;
	public const RuntimePlatform IPhonePlayer = 8;
	[Obsolete("Xbox360 export is no longer supported in Unity 5.5+.")]
	public const RuntimePlatform XBOX360 = 10;
	[Obsolete("PS3 export is no longer supported in Unity >=5.5.")]
	public const RuntimePlatform PS3 = 9;
	public const RuntimePlatform Android = 11;
	[Obsolete("NaCl export is no longer supported in Unity 5.0+.")]
	public const RuntimePlatform NaCl = 12;
	[Obsolete("FlashPlayer export is no longer supported in Unity 5.0+.")]
	public const RuntimePlatform FlashPlayer = 15;
	public const RuntimePlatform LinuxPlayer = 13;
	public const RuntimePlatform LinuxEditor = 16;
	public const RuntimePlatform WebGLPlayer = 17;
	[Obsolete("Use WSAPlayerX86 instead")]
	public const RuntimePlatform MetroPlayerX86 = 18;
	public const RuntimePlatform WSAPlayerX86 = 18;
	[Obsolete("Use WSAPlayerX64 instead")]
	public const RuntimePlatform MetroPlayerX64 = 19;
	public const RuntimePlatform WSAPlayerX64 = 19;
	[Obsolete("Use WSAPlayerARM instead")]
	public const RuntimePlatform MetroPlayerARM = 20;
	public const RuntimePlatform WSAPlayerARM = 20;
	[Obsolete("Windows Phone 8 was removed in 5.3")]
	public const RuntimePlatform WP8Player = 21;
	[Obsolete("BlackBerryPlayer export is no longer supported in Unity 5.4+.")]
	public const RuntimePlatform BlackBerryPlayer = 22;
	[Obsolete("TizenPlayer export is no longer supported in Unity 2017.3+.")]
	public const RuntimePlatform TizenPlayer = 23;
	[Obsolete("PSP2 is no longer supported as of Unity 2018.3")]
	public const RuntimePlatform PSP2 = 24;
	public const RuntimePlatform PS4 = 25;
	[Obsolete("PSM export is no longer supported in Unity >= 5.3")]
	public const RuntimePlatform PSM = 26;
	public const RuntimePlatform XboxOne = 27;
	[Obsolete("SamsungTVPlayer export is no longer supported in Unity 2017.3+.")]
	public const RuntimePlatform SamsungTVPlayer = 28;
	[Obsolete("Wii U is no longer supported in Unity 2018.1+.")]
	public const RuntimePlatform WiiU = 30;
	public const RuntimePlatform tvOS = 31;
	public const RuntimePlatform Switch = 32;
	[Obsolete("Lumin is no longer supported in Unity 2022.2")]
	public const RuntimePlatform Lumin = 33;
	public const RuntimePlatform Stadia = 34;
	[Obsolete("Use LinuxPlayer instead")]
	public const RuntimePlatform CloudRendering = 35;
	[Obsolete("GameCoreScarlett is deprecated, please use GameCoreXboxSeries (UnityUpgradable) -> GameCoreXboxSeries", False)]
	public const RuntimePlatform GameCoreScarlett = -1;
	public const RuntimePlatform GameCoreXboxSeries = 36;
	public const RuntimePlatform GameCoreXboxOne = 37;
	public const RuntimePlatform PS5 = 38;
	public const RuntimePlatform EmbeddedLinuxArm64 = 39;
	public const RuntimePlatform EmbeddedLinuxArm32 = 40;
	public const RuntimePlatform EmbeddedLinuxX64 = 41;
	public const RuntimePlatform EmbeddedLinuxX86 = 42;
	public const RuntimePlatform LinuxServer = 43;
	public const RuntimePlatform WindowsServer = 44;
	public const RuntimePlatform OSXServer = 45;
	public const RuntimePlatform QNXArm32 = 46;
	public const RuntimePlatform QNXArm64 = 47;
	public const RuntimePlatform QNXX64 = 48;
	public const RuntimePlatform QNXX86 = 49;
	public const RuntimePlatform VisionOS = 50;
}
