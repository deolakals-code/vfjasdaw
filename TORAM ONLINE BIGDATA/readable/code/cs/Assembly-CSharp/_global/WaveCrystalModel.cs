// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WaveCrystalModel : WaveSymbolModelBase // TypeDefIndex: 4012
{
	// Fields
	private SkinnedMeshRenderer render; // 0x18
	private Motion motion; // 0x20
	private int motionId; // 0x28

	// Properties
	private bool IsNormal { get; }
	private bool IsDamage { get; }
	private bool IsBreak { get; }

	// Methods

	// RVA: 0x24709DC Offset: 0x246C9DC VA: 0x24709DC
	private bool get_IsNormal() { }

	// RVA: 0x24709EC Offset: 0x246C9EC VA: 0x24709EC
	private bool get_IsDamage() { }

	// RVA: 0x24709FC Offset: 0x246C9FC VA: 0x24709FC
	private bool get_IsBreak() { }

	// RVA: 0x2470A0C Offset: 0x246CA0C VA: 0x2470A0C
	public void .ctor(GameObject modelObject) { }

	// RVA: 0x2470CE4 Offset: 0x246CCE4 VA: 0x2470CE4 Slot: 4
	public override void ChangeMotion(int percent) { }

	// RVA: 0x2470FFC Offset: 0x246CFFC VA: 0x2470FFC Slot: 6
	public override void SetTrans(Transform parent) { }

	// RVA: 0x2470F34 Offset: 0x246CF34 VA: 0x2470F34
	private void PlayMotion(int playId, int fadePlayId) { }

	// RVA: 0x2470C1C Offset: 0x246CC1C VA: 0x2470C1C
	private void SetSurfaceColor(float r, float g, float b) { }

	// RVA: 0x2470B4C Offset: 0x246CB4C VA: 0x2470B4C
	private void SetInsideColor(float r, float g, float b) { }

	// RVA: 0x2471174 Offset: 0x246D174 VA: 0x2471174
	private void SetColor(int matId, MasterModelDataManager.ColorListData color) { }

	// RVA: 0x2470EE4 Offset: 0x246CEE4 VA: 0x2470EE4
	public WaveCrystal.CrystalState NowHpState(int percent) { }
}
