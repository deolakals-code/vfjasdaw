// Assembly: Assembly-CSharp.dll
// Namespace: GemCartBuffer
public class StandingWithArmsCrossedBuff : GemCartBufferBase // TypeDefIndex: 9234
{
	// Fields
	private PlayerStatusBase playerStatus; // 0x18

	// Properties
	public override GemCartId Id { get; }

	// Methods

	// RVA: 0x1EB645C Offset: 0x1EB245C VA: 0x1EB645C Slot: 4
	public override GemCartId get_Id() { }

	// RVA: 0x1EB6464 Offset: 0x1EB2464 VA: 0x1EB6464
	public void .ctor(short lv, PlayerStatusBase status) { }

	// RVA: 0x1EB6494 Offset: 0x1EB2494 VA: 0x1EB6494 Slot: 9
	protected override bool CheckTrigger() { }

	// RVA: 0x1EB65A0 Offset: 0x1EB25A0 VA: 0x1EB65A0 Slot: 10
	protected override int OnGetValue(GemCartBufferId id) { }
}
