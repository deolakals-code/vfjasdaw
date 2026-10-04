// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(ObjectActionManagerBase))]
public class WaveCrystal : MonoBehaviour, IDisposable // TypeDefIndex: 4010
{
	// Fields
	private TransformShake shake; // 0x20
	private float shakeTime; // 0x28
	private float timer; // 0x2C
	private int motionId; // 0x30
	private bool onceShake; // 0x34
	private byte stateFlag; // 0x35
	private int hp; // 0x38
	private int maxHp; // 0x3C
	private WaveCrystal.CrystalState state; // 0x40
	private short popId; // 0x44
	private ObjectActionManagerBase actionManager; // 0x48
	private WaveSymbolModelBase modelData; // 0x50

	// Properties
	public int HP { get; }
	public int MaxHP { get; }
	public int Percent { get; }
	public bool IsBreak { get; }
	public short PopId { get; }
	public ObjectActionManagerBase ActionManager { get; }

	// Methods

	// RVA: 0x246FF08 Offset: 0x246BF08 VA: 0x246FF08
	public int get_HP() { }

	// RVA: 0x246FF10 Offset: 0x246BF10 VA: 0x246FF10
	public int get_MaxHP() { }

	// RVA: 0x246FF18 Offset: 0x246BF18 VA: 0x246FF18
	public int get_Percent() { }

	// RVA: 0x246FF50 Offset: 0x246BF50 VA: 0x246FF50
	public bool get_IsBreak() { }

	// RVA: 0x246FF60 Offset: 0x246BF60 VA: 0x246FF60
	public short get_PopId() { }

	// RVA: 0x246FF68 Offset: 0x246BF68 VA: 0x246FF68
	public ObjectActionManagerBase get_ActionManager() { }

	// RVA: 0x2470010 Offset: 0x246C010 VA: 0x2470010 Slot: 4
	public void Dispose() { }

	// RVA: 0x2470018 Offset: 0x246C018 VA: 0x2470018
	public void Dispose(bool dispose) { }

	// RVA: 0x24700A0 Offset: 0x246C0A0 VA: 0x24700A0
	public void SetHp(int hp, int maxHp) { }

	// RVA: 0x24701A0 Offset: 0x246C1A0 VA: 0x24701A0
	public bool Damage(int damage, int targetHp) { }

	// RVA: 0x247011C Offset: 0x246C11C VA: 0x247011C
	public WaveCrystal.CrystalState NowHpState() { }

	// RVA: 0x2470248 Offset: 0x246C248 VA: 0x2470248
	public static WaveCrystal.CrystalState GetHpState(int percent) { }

	// RVA: 0x2470298 Offset: 0x246C298 VA: 0x2470298
	public void SetShakeTime(float time) { }

	// RVA: 0x247023C Offset: 0x246C23C VA: 0x247023C
	public void SetShake() { }

	// RVA: 0x24702B8 Offset: 0x246C2B8 VA: 0x24702B8
	private void Update() { }

	// RVA: 0x24702E4 Offset: 0x246C2E4 VA: 0x24702E4
	private void Shake() { }

	// RVA: 0x24703B4 Offset: 0x246C3B4 VA: 0x24703B4
	public void SetModel(WaveSymbolModelBase waveSymbolModel) { }

	// RVA: 0x247053C Offset: 0x246C53C VA: 0x247053C
	public bool AddModelEvent(byte hpPercent, WaveSymbolModel.IWaveSymbolEventBase eventData) { }

	// RVA: 0x24709D4 Offset: 0x246C9D4 VA: 0x24709D4
	public void .ctor() { }
}
