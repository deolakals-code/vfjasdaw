// Assembly: Assembly-CSharp.dll
// Namespace: GemCartBuffer
public class MonsterHuntBuff : GemCartBufferBase // TypeDefIndex: 9219
{
	// Fields
	private float coolDownTime; // 0x18

	// Properties
	public override GemCartId Id { get; }
	public override float CoolDownTime { get; }

	// Methods

	// RVA: 0x1EB5BE4 Offset: 0x1EB1BE4 VA: 0x1EB5BE4 Slot: 4
	public override GemCartId get_Id() { }

	// RVA: 0x1EB5BEC Offset: 0x1EB1BEC VA: 0x1EB5BEC Slot: 5
	public override float get_CoolDownTime() { }

	// RVA: 0x1EB5BF4 Offset: 0x1EB1BF4 VA: 0x1EB5BF4
	public void .ctor(short lv) { }

	// RVA: 0x1EB5C28 Offset: 0x1EB1C28 VA: 0x1EB5C28 Slot: 10
	protected override int OnGetValue(GemCartBufferId id) { }
}
