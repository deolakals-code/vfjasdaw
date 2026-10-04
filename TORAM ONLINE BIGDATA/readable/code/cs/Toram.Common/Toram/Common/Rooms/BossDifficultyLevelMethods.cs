// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms
public static class BossDifficultyLevelMethods // TypeDefIndex: 11280
{
	// Fields
	private static float[] HpRate; // 0x0
	private static float[] StatusRate; // 0x8
	private static float[] AttackRate; // 0x10
	private static int[] LvRate; // 0x18
	private static float[] FlinchResistRate; // 0x20
	private static float[] TumbleResistRate; // 0x28
	private static float[] StunResistRate; // 0x30
	private static float[] ExpRate; // 0x38
	private static float[] PartsExpRate; // 0x40
	private static int[] DropRate; // 0x48

	// Methods

	// RVA: 0x36D6470 Offset: 0x36D2470 VA: 0x36D6470
	private static int CheckDifficulty(int difficulty) { }

	// RVA: 0x36D648C Offset: 0x36D248C VA: 0x36D648C
	public static short GetLevel(short lv, int difficulty) { }

	// RVA: 0x36D6540 Offset: 0x36D2540 VA: 0x36D6540
	public static int GetExp(int exp, int partsExp, int difficulty) { }

	// RVA: 0x36D6630 Offset: 0x36D2630 VA: 0x36D6630
	public static int GetHpRate(int param, int difficulty) { }

	// RVA: 0x36D66F4 Offset: 0x36D26F4 VA: 0x36D66F4
	public static int GetStatusRate(int param, int difficulty) { }

	// RVA: 0x36D67B8 Offset: 0x36D27B8 VA: 0x36D67B8
	public static int GetAttackRate(int param, int difficulty) { }

	// RVA: 0x36D687C Offset: 0x36D287C VA: 0x36D687C
	public static float GetFlinchResistTime(float param, int difficulty) { }

	// RVA: 0x36D695C Offset: 0x36D295C VA: 0x36D695C
	public static float GetTumbleResistTime(float param, int difficulty) { }

	// RVA: 0x36D6A3C Offset: 0x36D2A3C VA: 0x36D6A3C
	public static float GetStunResistTime(float param, int difficulty) { }

	// RVA: 0x36D6B1C Offset: 0x36D2B1C VA: 0x36D6B1C
	private static void .cctor() { }
}
