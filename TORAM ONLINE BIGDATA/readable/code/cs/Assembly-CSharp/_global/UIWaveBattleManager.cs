// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWaveBattleManager // TypeDefIndex: 6423
{
	// Fields
	private UICristalHp cristalHp; // 0x10
	private GameObject cristalHpObj; // 0x18
	private UIBattleTimer battleTimer; // 0x20
	private GameObject battleTimerObj; // 0x28
	private UIBattleReport battleReport; // 0x30
	private GameObject battleReportObj; // 0x38
	private bool isVisible; // 0x40

	// Properties
	public UICristalHp CristaHp { get; }
	public UIBattleTimer BattleTimer { get; }
	public UIBattleReport BattleReport { get; }

	// Methods

	// RVA: 0x192CD64 Offset: 0x1928D64 VA: 0x192CD64
	public UICristalHp get_CristaHp() { }

	// RVA: 0x192CD6C Offset: 0x1928D6C VA: 0x192CD6C
	public UIBattleTimer get_BattleTimer() { }

	// RVA: 0x192CD74 Offset: 0x1928D74 VA: 0x192CD74
	public UIBattleReport get_BattleReport() { }

	// RVA: 0x192CD7C Offset: 0x1928D7C VA: 0x192CD7C
	public void .ctor() { }

	// RVA: 0x192D0F0 Offset: 0x19290F0 VA: 0x192D0F0
	public void .ctor(WaveGameType type) { }

	// RVA: 0x192D2C0 Offset: 0x19292C0 VA: 0x192D2C0
	public bool IsThereDefender(WaveGameType type) { }

	// RVA: 0x192CF3C Offset: 0x1928F3C VA: 0x192CF3C
	public void EnableUpdate() { }

	// RVA: 0x192D3DC Offset: 0x19293DC VA: 0x192D3DC
	public void DestroyObj() { }

	// RVA: 0x192D2D0 Offset: 0x19292D0 VA: 0x192D2D0
	private void SetEnable(bool enable) { }
}
