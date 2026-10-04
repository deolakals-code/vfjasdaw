// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Battle
[Flags]
public enum AttackHitReactionType // TypeDefIndex: 13093
{
	// Fields
	public byte value__; // 0x0
	public const AttackHitReactionType None = 0;
	public const AttackHitReactionType Avoid = 1;
	public const AttackHitReactionType Guard = 2;
	public const AttackHitReactionType JustGuard = 4;
	public const AttackHitReactionType SkillGuard = 8;
	public const AttackHitReactionType GuardCrash = 16;
	public const AttackHitReactionType GuardCrash_Dead = 32;
	public const AttackHitReactionType Invincibility = 64;
}
