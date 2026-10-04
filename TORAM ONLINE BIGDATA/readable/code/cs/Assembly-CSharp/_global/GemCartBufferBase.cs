// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class GemCartBufferBase // TypeDefIndex: 2237
{
	// Fields
	private float coolDownTimer; // 0x10
	[CompilerGenerated]
	private short <Lv>k__BackingField; // 0x14

	// Properties
	public abstract GemCartId Id { get; }
	public short Lv { get; set; }
	public virtual float CoolDownTime { get; }
	public bool IsCoolDown { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract GemCartId get_Id();

	[CompilerGenerated]
	// RVA: 0x2174094 Offset: 0x2170094 VA: 0x2174094
	public short get_Lv() { }

	[CompilerGenerated]
	// RVA: 0x217409C Offset: 0x217009C VA: 0x217409C
	protected void set_Lv(short value) { }

	// RVA: 0x21740A4 Offset: 0x21700A4 VA: 0x21740A4 Slot: 5
	public virtual float get_CoolDownTime() { }

	// RVA: 0x21740AC Offset: 0x21700AC VA: 0x21740AC
	public bool get_IsCoolDown() { }

	// RVA: 0x21740BC Offset: 0x21700BC VA: 0x21740BC
	public void .ctor(short lv) { }

	// RVA: 0x21740E4 Offset: 0x21700E4 VA: 0x21740E4 Slot: 6
	public virtual void Update() { }

	// RVA: 0x2174124 Offset: 0x2170124 VA: 0x2174124
	public int GetValue(GemCartBufferId id) { }

	// RVA: 0x217417C Offset: 0x217017C VA: 0x217417C Slot: 7
	public virtual bool GetBonusData(out short[] id, out short[] val) { }

	// RVA: 0x21741B0 Offset: 0x21701B0 VA: 0x21741B0 Slot: 8
	public virtual void InvokeBufEffect() { }

	// RVA: 0x21741DC Offset: 0x21701DC VA: 0x21741DC
	public void ClearCoolDown() { }

	// RVA: 0x21741E4 Offset: 0x21701E4 VA: 0x21741E4 Slot: 9
	protected virtual bool CheckTrigger() { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract int OnGetValue(GemCartBufferId id);
}
