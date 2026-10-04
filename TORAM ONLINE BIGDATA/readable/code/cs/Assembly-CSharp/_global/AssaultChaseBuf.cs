// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AssaultChaseBuf : SkillBufferDataBase // TypeDefIndex: 3069
{
	// Fields
	private const int MaxShortRangeRate = 10;
	private readonly bool isShortRangeRateBonus; // 0x1D
	private int avoidConsumptionReductionValue; // 0x20
	private int shortRangeRate; // 0x24

	// Properties
	public override SkillId SkillId { get; }

	// Methods

	// RVA: 0x231DF78 Offset: 0x2319F78 VA: 0x231DF78
	public void .ctor(byte lv, PlayerStatusBase status) { }

	// RVA: 0x231E050 Offset: 0x231A050 VA: 0x231E050 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x231E058 Offset: 0x231A058 VA: 0x231E058 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x231E088 Offset: 0x231A088 VA: 0x231E088 Slot: 11
	public override void Updata() { }

	// RVA: 0x231E0DC Offset: 0x231A0DC VA: 0x231E0DC
	public void AvoidSuccess() { }
}
