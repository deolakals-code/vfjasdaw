// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DebugManager : Singleton<DebugManager> // TypeDefIndex: 5466
{
	// Fields
	[SerializeField]
	private SystemManager.BuildTypeS systemBuild; // 0x20
	[SerializeField]
	private SystemManager.ResourcesType folderType; // 0x24
	[SerializeField]
	private SystemManager.DownloadTypes downloadType; // 0x28
	[SerializeField]
	private SystemManager.ServerSelectTypes serverSelectType; // 0x2C
	[SerializeField]
	private SystemManager.ApplicationSelectTypes applicationSelectType; // 0x30

	// Properties
	[HideInInspector]
	public bool IsGMSkip { get; }
	[HideInInspector]
	public bool IsGMDashLock { get; }
	[HideInInspector]
	public bool IsGMSnowballInfinity { get; }
	public SystemManager.BuildTypeS SystemBuild { get; }

	// Methods

	// RVA: 0x1773ED4 Offset: 0x176FED4 VA: 0x1773ED4
	public bool get_IsGMSkip() { }

	// RVA: 0x1773EDC Offset: 0x176FEDC VA: 0x1773EDC
	public bool get_IsGMDashLock() { }

	// RVA: 0x1773EE4 Offset: 0x176FEE4 VA: 0x1773EE4
	public bool get_IsGMSnowballInfinity() { }

	// RVA: 0x1773EEC Offset: 0x176FEEC VA: 0x1773EEC
	public SystemManager.BuildTypeS get_SystemBuild() { }

	// RVA: 0x1774008 Offset: 0x1770008 VA: 0x1774008
	private void Awake() { }

	// RVA: 0x1774014 Offset: 0x1770014 VA: 0x1774014
	public void .ctor() { }
}
