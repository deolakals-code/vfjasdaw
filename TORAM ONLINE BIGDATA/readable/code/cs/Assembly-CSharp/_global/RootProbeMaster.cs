// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RootProbeMaster : MonoBehaviour // TypeDefIndex: 4000
{
	// Fields
	[SerializeField]
	private Transform[] probePoints; // 0x20
	[SerializeField]
	private byte[] probeRoot; // 0x28

	// Properties
	public byte ProbePointNum { get; }

	// Methods

	// RVA: 0x246CFCC Offset: 0x2468FCC VA: 0x246CFCC
	public byte get_ProbePointNum() { }

	// RVA: 0x246D05C Offset: 0x246905C VA: 0x246D05C
	public byte GetNearProbeId(Vector3 pos) { }

	// RVA: 0x246D080 Offset: 0x2469080 VA: 0x246D080
	public bool TryGetNearProbeId(Vector3 pos, float dist, out byte nearId) { }

	// RVA: 0x246D36C Offset: 0x246936C VA: 0x246D36C
	private byte GetTargetProbeId(byte currentProbe, byte goalProbe) { }

	// RVA: 0x246D3B4 Offset: 0x24693B4 VA: 0x246D3B4
	private bool CheckProbeLine(byte aProbe, byte bProbe, Vector3 pos) { }

	// RVA: 0x246D7DC Offset: 0x24697DC VA: 0x246D7DC
	public Vector3 GetProbePosition(int id) { }

	// RVA: 0x246D970 Offset: 0x2469970 VA: 0x246D970
	public void .ctor() { }
}
