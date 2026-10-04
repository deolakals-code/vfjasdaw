// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Battle
[Flags]
public enum AttackHitType // TypeDefIndex: 13098
{
	// Fields
	public byte value__; // 0x0
	public const AttackHitType Miss = 0;
	public const AttackHitType Hit = 1;
	public const AttackHitType Critical = 2;
	public const AttackHitType SkillGuard = 4;
	public const AttackHitType Guard = 8;
	public const AttackHitType GuardCrash = 16;
	public const AttackHitType GuardCrash_Dead = 32;
	public const AttackHitType JustGuard = 64;
	public const AttackHitType Avoid = 128;
}
