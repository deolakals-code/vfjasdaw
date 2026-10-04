// Assembly: Assembly-CSharp.dll
// Namespace: GemCartBuffer
public class SaviourBuff : GemCartBufferBase // TypeDefIndex: 9230
{
	// Fields
	private PlayerStatusBase playerStatus; // 0x18

	// Properties
	public override GemCartId Id { get; }

	// Methods

	// RVA: 0x1EB5F04 Offset: 0x1EB1F04 VA: 0x1EB5F04 Slot: 4
	public override GemCartId get_Id() { }

	// RVA: 0x1EB5F0C Offset: 0x1EB1F0C VA: 0x1EB5F0C
	public void .ctor(PlayerStatusBase status) { }

	// RVA: 0x1EB5F40 Offset: 0x1EB1F40 VA: 0x1EB5F40 Slot: 9
	protected override bool CheckTrigger() { }

	// RVA: 0x1EB6370 Offset: 0x1EB2370 VA: 0x1EB6370 Slot: 10
	protected override int OnGetValue(GemCartBufferId id) { }
}
