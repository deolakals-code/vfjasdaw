// Assembly: Assembly-CSharp.dll
// Namespace: GemCartBuffer
public class PursuitResistBuff : GemCartBufferBase // TypeDefIndex: 9227
{
	// Fields
	private PlayerStatusBase playerStatus; // 0x18

	// Properties
	public override GemCartId Id { get; }

	// Methods

	// RVA: 0x1EB5E18 Offset: 0x1EB1E18 VA: 0x1EB5E18 Slot: 4
	public override GemCartId get_Id() { }

	// RVA: 0x1EB5E20 Offset: 0x1EB1E20 VA: 0x1EB5E20
	public void .ctor(short lv, PlayerStatusBase status) { }

	// RVA: 0x1EB5E50 Offset: 0x1EB1E50 VA: 0x1EB5E50 Slot: 9
	protected override bool CheckTrigger() { }

	// RVA: 0x1EB5E7C Offset: 0x1EB1E7C VA: 0x1EB5E7C Slot: 10
	protected override int OnGetValue(GemCartBufferId id) { }
}
