// Assembly: Assembly-CSharp.dll
// Namespace: GemCartBuffer
public class SavingTechniqueBuff : GemCartBufferBase // TypeDefIndex: 9229
{
	// Fields
	private float coolDownTime; // 0x18

	// Properties
	public override GemCartId Id { get; }
	public override float CoolDownTime { get; }

	// Methods

	// RVA: 0x1EB5EB4 Offset: 0x1EB1EB4 VA: 0x1EB5EB4 Slot: 4
	public override GemCartId get_Id() { }

	// RVA: 0x1EB5EBC Offset: 0x1EB1EBC VA: 0x1EB5EBC Slot: 5
	public override float get_CoolDownTime() { }

	// RVA: 0x1EB5EC4 Offset: 0x1EB1EC4 VA: 0x1EB5EC4
	public void .ctor(short lv) { }

	// RVA: 0x1EB5EF8 Offset: 0x1EB1EF8 VA: 0x1EB5EF8 Slot: 10
	protected override int OnGetValue(GemCartBufferId id) { }
}
