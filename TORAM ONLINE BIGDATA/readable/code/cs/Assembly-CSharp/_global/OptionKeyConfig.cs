// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OptionKeyConfig // TypeDefIndex: 5364
{
	// Fields
	private OptionKeyConfig.KeyConfig[] keyConfigs; // 0x10
	private Dictionary<PCInputKeyMap, List<PCInputKeyMap>> sameCommandKeys; // 0x18

	// Methods

	// RVA: 0x264BB58 Offset: 0x2647B58 VA: 0x264BB58
	public void .ctor() { }

	// RVA: 0x264BC58 Offset: 0x2647C58 VA: 0x264BC58
	private bool IsHitKey(PCInputKeyMap checkAction, PCInputKeyMap action, KeyCode checkKey) { }

	// RVA: 0x264BCBC Offset: 0x2647CBC VA: 0x264BCBC
	private void SetSameKeyAction(PCInputKeyMap action, PCInputKeyMap sameAction) { }

	// RVA: 0x264BE94 Offset: 0x2647E94 VA: 0x264BE94
	private void SetKeyAction(PCInputKeyMap action, KeyCode mainKey, KeyCode subKey = 0) { }

	// RVA: 0x264BEF8 Offset: 0x2647EF8 VA: 0x264BEF8
	public bool CheckFreeKey(PCInputKeyMap action, KeyCode checkKey) { }

	// RVA: 0x264BF78 Offset: 0x2647F78 VA: 0x264BF78
	public bool CheckMoveLockKey(PCInputKeyMap action, KeyCode checkKey) { }

	// RVA: 0x264BF94 Offset: 0x2647F94 VA: 0x264BF94
	public void MainKeyDefault() { }

	// RVA: 0x264C7E8 Offset: 0x26487E8 VA: 0x264C7E8
	public void BlackKnightKeyDefault() { }

	// RVA: 0x264C854 Offset: 0x2648854 VA: 0x264C854
	public void RhythmGameKeyDefault() { }

	// RVA: 0x264BBE8 Offset: 0x2647BE8 VA: 0x264BBE8
	public void AllDefault() { }

	// RVA: 0x264C8D4 Offset: 0x26488D4 VA: 0x264C8D4
	public void Load() { }

	// RVA: 0x264CBE0 Offset: 0x2648BE0 VA: 0x264CBE0
	public void SaveData() { }

	// RVA: 0x264CCD8 Offset: 0x2648CD8 VA: 0x264CCD8
	public OptionKeyConfig.KeyConfig GetKeyConfig(PCInputKeyMap action) { }

	// RVA: 0x264CD14 Offset: 0x2648D14 VA: 0x264CD14
	public OptionKeyConfig.KeyConfig[] GetKeyConfig() { }

	// RVA: 0x264C9B4 Offset: 0x26489B4 VA: 0x264C9B4
	public bool SetKeyConfig(PCInputKeyMap action, KeyCode mainKey, KeyCode subKey) { }
}
