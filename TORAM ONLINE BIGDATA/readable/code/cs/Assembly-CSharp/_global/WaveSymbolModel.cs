// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WaveSymbolModel : WaveSymbolModelBase // TypeDefIndex: 4017
{
	// Fields
	private Dictionary<byte, List<WaveSymbolModel.IWaveSymbolEventBase>> eventList; // 0x18
	private List<byte> eventActionPercentList; // 0x20
	private List<WaveSymbolModel.IWaveSymbolEventBase> currentEvent; // 0x28
	private AnimationBase animation; // 0x30
	private byte currentEventId; // 0x38

	// Methods

	// RVA: 0x247134C Offset: 0x246D34C VA: 0x247134C
	public void .ctor(GameObject modelObject) { }

	// RVA: 0x24705E4 Offset: 0x246C5E4 VA: 0x24705E4
	public void AddEvent(byte percent, WaveSymbolModel.IWaveSymbolEventBase eventBase) { }

	// RVA: 0x247163C Offset: 0x246D63C VA: 0x247163C Slot: 4
	public override void ChangeMotion(int percent) { }

	// RVA: 0x2471A50 Offset: 0x246DA50 VA: 0x2471A50 Slot: 5
	public override void Update() { }

	// RVA: 0x247148C Offset: 0x246D48C VA: 0x247148C
	public void PlayMotion(int playId, int fadePlayId, WrapMode fadeMode) { }
}
