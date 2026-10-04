// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldScriptSubCamera : MonoBehaviour // TypeDefIndex: 4812
{
	// Fields
	private Camera subCamera; // 0x20
	private bool isInit; // 0x28
	private byte cameraId; // 0x29
	private Vector2 viewPos; // 0x2C
	private Vector2 viewArea; // 0x34
	private Vector2 movePoint; // 0x3C
	private float fadeTimer; // 0x44
	private float addTimer; // 0x48
	private static Vector2[] scrollData; // 0x0
	private FieldScriptCameraActionBase actionBase; // 0x50
	private bool isBreak; // 0x58

	// Methods

	// RVA: 0x25B12EC Offset: 0x25AD2EC VA: 0x25B12EC
	private void CreateCamera() { }

	// RVA: 0x25B1484 Offset: 0x25AD484 VA: 0x25B1484
	public void Initialize(byte cameraId, byte viewX, byte viewY, byte viewW, byte viewH, byte flag) { }

	// RVA: 0x25B15A8 Offset: 0x25AD5A8 VA: 0x25B15A8
	public FieldScriptCameraActionBase GetMoveAction(FieldScriptCameraActionBase.ActionType type) { }

	// RVA: 0x25B179C Offset: 0x25AD79C VA: 0x25B179C
	private void SetScrollData(byte type) { }

	// RVA: 0x25B185C Offset: 0x25AD85C VA: 0x25B185C
	public void EnableFadeIn(bool enable, byte type) { }

	// RVA: 0x25B1918 Offset: 0x25AD918 VA: 0x25B1918
	public void BreakFadeOut(byte type) { }

	// RVA: 0x25B19D0 Offset: 0x25AD9D0 VA: 0x25B19D0
	private void Update() { }

	// RVA: 0x25B1AF8 Offset: 0x25ADAF8 VA: 0x25B1AF8
	public void Skip() { }

	// RVA: 0x25B1B10 Offset: 0x25ADB10 VA: 0x25B1B10
	public void .ctor() { }

	// RVA: 0x25B1B68 Offset: 0x25ADB68 VA: 0x25B1B68
	private static void .cctor() { }
}
