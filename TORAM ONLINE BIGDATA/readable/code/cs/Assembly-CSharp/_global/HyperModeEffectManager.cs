// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HyperModeEffectManager : MonoBehaviour // TypeDefIndex: 895
{
	// Fields
	private TakeController controller; // 0x20
	private int AuraEffectUid; // 0x28
	private int IgnitionEffectUid; // 0x2C

	// Properties
	private TakeController takeController { get; }

	// Methods

	// RVA: 0x1EFEDEC Offset: 0x1EFADEC VA: 0x1EFEDEC
	private TakeController get_takeController() { }

	// RVA: 0x1EFEE8C Offset: 0x1EFAE8C VA: 0x1EFEE8C
	public void PlayAuraEfffect(int modelId, int motionId, float scale, Color[] rgb) { }

	// RVA: 0x1EFF028 Offset: 0x1EFB028 VA: 0x1EFF028
	public void StopAuraEffect() { }

	// RVA: 0x1EFF0CC Offset: 0x1EFB0CC VA: 0x1EFF0CC
	public void PlayIgnitionEfffect(int modelId, int motionId, GameObject attacker, float scale, Color[] rgb) { }

	// RVA: 0x1EFF3D4 Offset: 0x1EFB3D4 VA: 0x1EFF3D4
	public void PlayIgnitionEfffect(int modelId, int motionId, float scale, Color[] rgb) { }

	// RVA: 0x1EFF330 Offset: 0x1EFB330 VA: 0x1EFF330
	public void StopIgnitionEffect() { }

	// RVA: 0x1EFF570 Offset: 0x1EFB570 VA: 0x1EFF570
	public void .ctor() { }
}
