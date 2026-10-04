// Assembly: Assembly-CSharp.dll
// Namespace: GemCartBuffer
internal class HealStockpileBuff : GemCartBufferBase // TypeDefIndex: 9253
{
	// Fields
	private PlayerStatusBase status; // 0x18
	private float timer; // 0x20
	private const float stackTime = 3;

	// Properties
	public override GemCartId Id { get; }

	// Methods

	// RVA: 0x1EB6AD4 Offset: 0x1EB2AD4 VA: 0x1EB6AD4 Slot: 4
	public override GemCartId get_Id() { }

	// RVA: 0x1EB6ADC Offset: 0x1EB2ADC VA: 0x1EB6ADC
	public void .ctor(short lv, PlayerStatusBase status) { }

	// RVA: 0x1EB6C10 Offset: 0x1EB2C10 VA: 0x1EB6C10 Slot: 6
	public override void Update() { }

	// RVA: 0x1EB6DF8 Offset: 0x1EB2DF8 VA: 0x1EB6DF8 Slot: 10
	protected override int OnGetValue(GemCartBufferId id) { }
}
