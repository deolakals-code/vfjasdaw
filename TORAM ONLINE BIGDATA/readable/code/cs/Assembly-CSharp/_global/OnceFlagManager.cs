// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OnceFlagManager // TypeDefIndex: 5507
{
	// Fields
	private readonly string PrefVersionKey; // 0x10
	private readonly string PrefBaseKey; // 0x18
	private readonly int CurrentFlagVersion; // 0x20
	private readonly int CurrentFlagCount; // 0x24
	private readonly string DefaultData; // 0x28
	private readonly string ReviewedData; // 0x30
	private readonly string BeginnerItemData; // 0x38
	private readonly string RegisteredLocalPushData; // 0x40
	private bool isNeedInitializeByServer; // 0x48
	private Dictionary<int, string> onceFlags; // 0x50
	private byte savedVersion; // 0x58

	// Properties
	public bool IsInitialized { get; }
	public byte SavedVersion { get; }

	// Methods

	// RVA: 0x1788380 Offset: 0x1784380 VA: 0x1788380
	public bool get_IsInitialized() { }

	// RVA: 0x17883DC Offset: 0x17843DC VA: 0x17883DC
	public byte get_SavedVersion() { }

	// RVA: 0x17883E4 Offset: 0x17843E4 VA: 0x17883E4
	public bool InitializeFromLocal() { }

	// RVA: 0x17889E8 Offset: 0x17849E8 VA: 0x17889E8
	public void InitializeByServer() { }

	// RVA: 0x1788A38 Offset: 0x1784A38 VA: 0x1788A38
	public void UpdateByServer(byte version, GenericFlagData[] flagData) { }

	// RVA: 0x1788C80 Offset: 0x1784C80 VA: 0x1788C80
	private void saveFlags() { }

	// RVA: 0x1788E30 Offset: 0x1784E30 VA: 0x1788E30
	public void DeleteVersionKey() { }

	// RVA: 0x1788E4C Offset: 0x1784E4C VA: 0x1788E4C
	public void SetReviewedIos() { }

	// RVA: 0x1788F0C Offset: 0x1784F0C VA: 0x1788F0C
	public void SetReviewedAndroid() { }

	// RVA: 0x1788FCC Offset: 0x1784FCC VA: 0x1788FCC
	public void SetBeginnerItem() { }

	// RVA: 0x177F0E4 Offset: 0x177B0E4 VA: 0x177F0E4
	public void SetLocalPush() { }

	// RVA: 0x178908C Offset: 0x178508C VA: 0x178908C
	public bool IsReviewedIos() { }

	// RVA: 0x178913C Offset: 0x178513C VA: 0x178913C
	public bool IsReviewedAndroid() { }

	// RVA: 0x17891EC Offset: 0x17851EC VA: 0x17891EC
	public bool IsBeginnerItem() { }

	// RVA: 0x177F034 Offset: 0x177B034 VA: 0x177F034
	public bool IsRegisteredLocalPush() { }

	// RVA: 0x178929C Offset: 0x178529C VA: 0x178929C
	public void .ctor() { }
}
