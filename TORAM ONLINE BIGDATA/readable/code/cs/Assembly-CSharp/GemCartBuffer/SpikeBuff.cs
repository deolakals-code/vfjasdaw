// Assembly: Assembly-CSharp.dll
// Namespace: GemCartBuffer
public class SpikeBuff : GemCartBufferBase // TypeDefIndex: 9233
{
	// Fields
	private PlayerStatusBase playerStatus; // 0x18

	// Properties
	public override GemCartId Id { get; }

	// Methods

	// RVA: 0x1EB63D8 Offset: 0x1EB23D8 VA: 0x1EB63D8 Slot: 4
	public override GemCartId get_Id() { }

	// RVA: 0x1EB63E0 Offset: 0x1EB23E0 VA: 0x1EB63E0
	public void .ctor(short lv, PlayerStatusBase status) { }

	// RVA: 0x1EB6410 Offset: 0x1EB2410 VA: 0x1EB6410 Slot: 9
	protected override bool CheckTrigger() { }

	// RVA: 0x1EB6440 Offset: 0x1EB2440 VA: 0x1EB6440 Slot: 10
	protected override int OnGetValue(GemCartBufferId id) { }
}
