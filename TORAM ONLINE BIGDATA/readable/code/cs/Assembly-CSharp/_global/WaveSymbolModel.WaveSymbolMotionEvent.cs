// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WaveSymbolModel.WaveSymbolMotionEvent : WaveSymbolModel.IWaveSymbolEventBase // TypeDefIndex: 4016
{
	// Fields
	private readonly byte bitFlag; // 0x10
	private readonly int playMotion; // 0x14
	private readonly int loopMotion; // 0x18

	// Methods

	// RVA: 0x2471BFC Offset: 0x246DBFC VA: 0x2471BFC
	public void .ctor(byte flag, int playMotion, int loopMotion) { }

	// RVA: 0x2471C38 Offset: 0x246DC38 VA: 0x2471C38 Slot: 4
	public void Start(WaveSymbolModel model) { }

	// RVA: 0x2471C68 Offset: 0x246DC68 VA: 0x2471C68 Slot: 5
	public void Update(WaveSymbolModel model) { }

	// RVA: 0x2471C6C Offset: 0x246DC6C VA: 0x2471C6C Slot: 6
	public void Damage(WaveSymbolModel model) { }
}
