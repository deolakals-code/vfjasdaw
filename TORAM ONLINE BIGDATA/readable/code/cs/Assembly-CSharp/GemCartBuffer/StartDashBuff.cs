// Assembly: Assembly-CSharp.dll
// Namespace: GemCartBuffer
public class StartDashBuff : GemCartBufferBase // TypeDefIndex: 9235
{
	// Fields
	private float effectTimer; // 0x18
	private float effectTime; // 0x1C
	private float coolDownTime; // 0x20

	// Properties
	public override GemCartId Id { get; }
	public override float CoolDownTime { get; }

	// Methods

	// RVA: 0x1EB65BC Offset: 0x1EB25BC VA: 0x1EB65BC Slot: 4
	public override GemCartId get_Id() { }

	// RVA: 0x1EB65C4 Offset: 0x1EB25C4 VA: 0x1EB65C4 Slot: 5
	public override float get_CoolDownTime() { }

	// RVA: 0x1EB65CC Offset: 0x1EB25CC VA: 0x1EB65CC
	public void .ctor(short lv) { }

	// RVA: 0x1EB6604 Offset: 0x1EB2604 VA: 0x1EB6604 Slot: 6
	public override void Update() { }

	// RVA: 0x1EB6674 Offset: 0x1EB2674 VA: 0x1EB6674 Slot: 9
	protected override bool CheckTrigger() { }

	// RVA: 0x1EB6684 Offset: 0x1EB2684 VA: 0x1EB6684 Slot: 10
	protected override int OnGetValue(GemCartBufferId id) { }

	// RVA: 0x1EB66A8 Offset: 0x1EB26A8 VA: 0x1EB66A8
	public void Synchronization(short serverState) { }
}
