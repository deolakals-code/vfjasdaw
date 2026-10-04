// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ScreenshotManager : Singleton<ScreenshotManager> // TypeDefIndex: 4614
{
	// Fields
	private SystemTextManager stManager; // 0x20
	private bool isSave; // 0x28

	// Properties
	private SystemTextManager systemTextManager { get; }

	// Methods

	// RVA: 0x25395C8 Offset: 0x25355C8 VA: 0x25395C8
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x25396B4 Offset: 0x25356B4 VA: 0x25396B4
	public void Screenshort() { }

	[IteratorStateMachine(typeof(ScreenshotManager.<ScreenshortProc>d__6))]
	// RVA: 0x2539768 Offset: 0x2535768 VA: 0x2539768
	private IEnumerator ScreenshortProc(int type) { }

	// RVA: 0x253980C Offset: 0x253580C VA: 0x253980C
	public void .ctor() { }
}
