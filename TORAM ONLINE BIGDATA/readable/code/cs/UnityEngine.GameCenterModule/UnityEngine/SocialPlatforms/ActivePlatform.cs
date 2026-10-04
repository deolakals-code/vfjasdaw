// Assembly: UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms
internal static class ActivePlatform // TypeDefIndex: 17833
{
	// Fields
	private static ISocialPlatform _active; // 0x0

	// Properties
	internal static ISocialPlatform Instance { get; set; }

	// Methods

	// RVA: 0x38003F8 Offset: 0x37FC3F8 VA: 0x38003F8
	internal static ISocialPlatform get_Instance() { }

	// RVA: 0x3800474 Offset: 0x37FC474 VA: 0x3800474
	internal static void set_Instance(ISocialPlatform value) { }

	// RVA: 0x38009A0 Offset: 0x37FC9A0 VA: 0x38009A0
	private static ISocialPlatform SelectSocialPlatform() { }
}
