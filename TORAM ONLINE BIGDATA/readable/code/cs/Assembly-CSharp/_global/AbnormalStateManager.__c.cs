// Assembly: Assembly-CSharp.dll
// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AbnormalStateManager.<>c // TypeDefIndex: 1655
{
	// Fields
	public static readonly AbnormalStateManager.<>c <>9; // 0x0
	public static Func<AbnormalData, bool> <>9__18_0; // 0x8
	public static Func<AbnormalStateManager.InvincibilityBaseData, bool> <>9__28_0; // 0x10
	public static Func<AbnormalStateManager.InvincibilityBaseData, bool> <>9__28_1; // 0x18
	public static Func<KeyValuePair<AbnormalType, AbnormalData>, bool> <>9__32_0; // 0x20
	public static Func<AbnormalType, bool> <>9__34_0; // 0x28
	public static Func<AbnormalType, bool> <>9__35_0; // 0x30
	public static Func<AbnormalStateManager.InvincibilityBaseData, bool> <>9__80_0; // 0x38
	public static Func<AbnormalStateManager.InvincibilityBaseData, bool> <>9__83_0; // 0x40
	public static Func<AbnormalStateManager.InvincibilityBaseData, bool> <>9__88_0; // 0x48

	// Methods

	// RVA: 0x20A59FC Offset: 0x20A19FC VA: 0x20A59FC
	private static void .cctor() { }

	// RVA: 0x20A5A64 Offset: 0x20A1A64 VA: 0x20A5A64
	public void .ctor() { }

	// RVA: 0x20A5A6C Offset: 0x20A1A6C VA: 0x20A5A6C
	internal bool <get_AbnormalCount>b__18_0(AbnormalData abnormal) { }

	// RVA: 0x20A5AA4 Offset: 0x20A1AA4 VA: 0x20A5AA4
	internal bool <Update>b__28_0(AbnormalStateManager.InvincibilityBaseData d) { }

	// RVA: 0x20A5AC4 Offset: 0x20A1AC4 VA: 0x20A5AC4
	internal bool <Update>b__28_1(AbnormalStateManager.InvincibilityBaseData data) { }

	// RVA: 0x20A5ADC Offset: 0x20A1ADC VA: 0x20A5ADC
	internal bool <HasRecoverable>b__32_0(KeyValuePair<AbnormalType, AbnormalData> ab) { }

	// RVA: 0x20A5B94 Offset: 0x20A1B94 VA: 0x20A5B94
	internal bool <DamagedRecovery>b__34_0(AbnormalType x) { }

	// RVA: 0x20A5C0C Offset: 0x20A1C0C VA: 0x20A5C0C
	internal bool <ActionLockAbnormalRecovery>b__35_0(AbnormalType x) { }

	// RVA: 0x20A5C1C Offset: 0x20A1C1C VA: 0x20A5C1C
	internal bool <RemoveTemporarilyInvincibility>b__80_0(AbnormalStateManager.InvincibilityBaseData x) { }

	// RVA: 0x20A5C34 Offset: 0x20A1C34 VA: 0x20A5C34
	internal bool <RemoveSkillMotionInvincibility>b__83_0(AbnormalStateManager.InvincibilityBaseData x) { }

	// RVA: 0x20A5C4C Offset: 0x20A1C4C VA: 0x20A5C4C
	internal bool <CheckInvincibility>b__88_0(AbnormalStateManager.InvincibilityBaseData x) { }
}
