// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: Asobimo.Plugin
public class AsobimoActivityListener : AndroidJavaProxy // TypeDefIndex: 17123
{
	// Fields
	private readonly AndroidPluginManager pluginManager; // 0x20

	// Methods

	// RVA: 0x170DA00 Offset: 0x1709A00 VA: 0x170DA00
	public void .ctor(AndroidPluginManager manager) { }

	// RVA: 0x170FAC4 Offset: 0x170BAC4 VA: 0x170FAC4
	public void onStart() { }

	// RVA: 0x170FAC8 Offset: 0x170BAC8 VA: 0x170FAC8
	public void onPause() { }

	// RVA: 0x170FAE8 Offset: 0x170BAE8 VA: 0x170FAE8
	public void onResume() { }

	// RVA: 0x170FB08 Offset: 0x170BB08 VA: 0x170FB08
	public void onStop() { }

	// RVA: 0x170FB0C Offset: 0x170BB0C VA: 0x170FB0C
	public void onRestart() { }

	// RVA: 0x170FB2C Offset: 0x170BB2C VA: 0x170FB2C
	public void onDestroy() { }

	// RVA: 0x170FB30 Offset: 0x170BB30 VA: 0x170FB30
	public void onActivityResult(int requestCode, int resultCode, AndroidJavaObject intent) { }

	// RVA: 0x170FB50 Offset: 0x170BB50 VA: 0x170FB50
	public void OnHackDetected(int code, string info) { }

	// RVA: 0x170FB68 Offset: 0x170BB68 VA: 0x170FB68
	public void OnLog(string msg) { }

	// RVA: 0x170FB6C Offset: 0x170BB6C VA: 0x170FB6C
	public int SendPacket(byte[] buffer) { }
}
