// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.OurUtils
public class NearbyHelperObject : MonoBehaviour // TypeDefIndex: 16806
{
	// Fields
	private static NearbyHelperObject instance; // 0x0
	private static double mAdvertisingRemaining; // 0x8
	private static double mDiscoveryRemaining; // 0x10
	private static INearbyConnectionClient mClient; // 0x18

	// Methods

	// RVA: 0x2E2453C Offset: 0x2E2053C VA: 0x2E2453C
	public static void CreateObject(INearbyConnectionClient client) { }

	// RVA: 0x2E306D0 Offset: 0x2E2C6D0 VA: 0x2E306D0
	private static double ToSeconds(Nullable<TimeSpan> span) { }

	// RVA: 0x2E29F1C Offset: 0x2E25F1C VA: 0x2E29F1C
	public static void StartAdvertisingTimer(Nullable<TimeSpan> span) { }

	// RVA: 0x2E29F8C Offset: 0x2E25F8C VA: 0x2E29F8C
	public static void StartDiscoveryTimer(Nullable<TimeSpan> span) { }

	// RVA: 0x2E307C4 Offset: 0x2E2C7C4 VA: 0x2E307C4
	public void Awake() { }

	// RVA: 0x2E30830 Offset: 0x2E2C830 VA: 0x2E30830
	public void OnDisable() { }

	// RVA: 0x2E308E4 Offset: 0x2E2C8E4 VA: 0x2E308E4
	public void Update() { }

	// RVA: 0x2E306C8 Offset: 0x2E2C6C8 VA: 0x2E306C8
	public void .ctor() { }
}
