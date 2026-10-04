// Assembly: Assembly-CSharp.dll
// Namespace: 
public struct OptionKeyConfig.KeyConfig // TypeDefIndex: 5363
{
	// Fields
	public readonly KeyCode MainKey; // 0x0
	public readonly KeyCode SubKey; // 0x4
	private bool isBeforePush; // 0x8
	public readonly bool IsSave; // 0x9
	private bool isNoLoading; // 0xA

	// Methods

	// RVA: 0x264BE70 Offset: 0x2647E70 VA: 0x264BE70
	public void .ctor(KeyCode mainKey, KeyCode subKey, bool isSave) { }

	// RVA: 0x264CD1C Offset: 0x2648D1C VA: 0x264CD1C
	private bool Push(KeyCode key) { }

	// RVA: 0x264CD34 Offset: 0x2648D34 VA: 0x264CD34
	public void UpdateKey(IKeyButton button) { }

	// RVA: 0x264BE88 Offset: 0x2647E88 VA: 0x264BE88
	public void LoadingLock() { }

	// RVA: 0x264BEE8 Offset: 0x2647EE8 VA: 0x264BEE8
	public bool IsLoading() { }
}
