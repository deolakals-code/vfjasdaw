// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GodSpearHandlingMastary : SkillMasteryBase // TypeDefIndex: 3439
{
	// Fields
	private const float InvincibleIntervalTime = 10;
	private float effectIveinvincibleStartTime; // 0x18

	// Methods

	// RVA: 0x235A84C Offset: 0x235684C VA: 0x235A84C
	public void .ctor(SkillData skillData) { }

	// RVA: 0x235A884 Offset: 0x2356884 VA: 0x235A884 Slot: 4
	public override int GetMasteryParam(MasteryId id) { }

	// RVA: 0x235A8B0 Offset: 0x23568B0 VA: 0x235A8B0
	public int GetParam(SkillBufferId type, PlayerStatusBase status) { }

	// RVA: 0x235A94C Offset: 0x235694C VA: 0x235A94C
	public bool CheckEffectiveIveinvincible(PlayerStatusBase status) { }

	// RVA: 0x235A9F0 Offset: 0x23569F0 VA: 0x235A9F0
	public void EffectiveIveinvincible() { }

	// RVA: 0x235AA0C Offset: 0x2356A0C VA: 0x235AA0C
	public static int[] GetSkill(int level) { }

	// RVA: 0x235ABDC Offset: 0x2356BDC VA: 0x235ABDC
	public static bool CheckAvailable(int skillId, int level) { }

	// RVA: 0x235AC18 Offset: 0x2356C18 VA: 0x235AC18
	public static bool CheckAvailable(SkillId skillId, int level) { }
}
