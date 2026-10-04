// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CountSystem : MonoBehaviour // TypeDefIndex: 8320
{
	// Fields
	[SerializeField]
	private CountSystem._variable[] variable; // 0x20
	[CompilerGenerated]
	private Action Callback; // 0x28

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D1DA44 Offset: 0x1D19A44 VA: 0x1D1DA44
	public void add_Callback(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1D1DAE0 Offset: 0x1D19AE0 VA: 0x1D1DAE0
	public void remove_Callback(Action value) { }

	// RVA: 0x1D1DB7C Offset: 0x1D19B7C VA: 0x1D1DB7C
	private void Start() { }

	// RVA: 0x1D1DD48 Offset: 0x1D19D48 VA: 0x1D1DD48
	public void CountUp(int param) { }

	// RVA: 0x1D1DEBC Offset: 0x1D19EBC VA: 0x1D1DEBC
	public void CountUpMax(int param) { }

	// RVA: 0x1D1E018 Offset: 0x1D1A018 VA: 0x1D1E018
	public void CountDown(int param) { }

	// RVA: 0x1D1E18C Offset: 0x1D1A18C VA: 0x1D1E18C
	public void CountDownMax(int param) { }

	// RVA: 0x1D1DBD8 Offset: 0x1D19BD8 VA: 0x1D1DBD8
	private void updateLabel(CountSystem._variable v) { }

	// RVA: 0x1D1E2E8 Offset: 0x1D1A2E8 VA: 0x1D1E2E8
	public int GetCount(int keyParam) { }

	// RVA: 0x1D1E3D8 Offset: 0x1D1A3D8 VA: 0x1D1E3D8
	public int GetCount(string key) { }

	// RVA: 0x1D1E4DC Offset: 0x1D1A4DC VA: 0x1D1E4DC
	public void SetMax(int keyParam, int max) { }

	// RVA: 0x1D1E5C8 Offset: 0x1D1A5C8 VA: 0x1D1E5C8
	public void SetMax(string key, int max) { }

	// RVA: 0x1D1E6C8 Offset: 0x1D1A6C8 VA: 0x1D1E6C8
	public void SetMin(int keyParam, int min) { }

	// RVA: 0x1D1E7B4 Offset: 0x1D1A7B4 VA: 0x1D1E7B4
	public void SetMin(string key, int min) { }

	// RVA: 0x1D1E8B4 Offset: 0x1D1A8B4 VA: 0x1D1E8B4
	public void Reset(int keyParam) { }

	// RVA: 0x1D1E9D4 Offset: 0x1D1A9D4 VA: 0x1D1E9D4
	public void Reset(string key) { }

	// RVA: 0x1D1EB0C Offset: 0x1D1AB0C VA: 0x1D1EB0C
	public void .ctor() { }
}
