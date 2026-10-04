// Assembly: Assembly-CSharp.dll
// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DefenceMapDataManager.<>c // TypeDefIndex: 3866
{
	// Fields
	public static readonly DefenceMapDataManager.<>c <>9; // 0x0
	public static Predicate<GameObject> <>9__11_0; // 0x8
	public static Func<GameObject, bool> <>9__13_0; // 0x10
	public static Func<GameObject, DefenceSafeRoom> <>9__13_1; // 0x18
	public static Func<GameObject, bool> <>9__15_0; // 0x20
	public static Func<GameObject, DefenceMonsterRoom> <>9__15_1; // 0x28
	public static Func<DefenceSafeRoom, bool> <>9__17_0; // 0x30
	public static Func<DefenceSafeRoom, bool> <>9__19_0; // 0x38
	public static Func<DefenceSafeRoom, int> <>9__21_0; // 0x40
	public static Func<DefenceSafeRoom, int> <>9__23_0; // 0x48
	public static Func<DefenceSafeRoom, int> <>9__23_1; // 0x50
	public static Action<DefenceSafeRoom> <>9__26_0; // 0x58
	public static Action<DefenceMonsterRoom> <>9__26_1; // 0x60
	public static Action<DefenceMonsterRoom> <>9__27_0; // 0x68
	public static Func<DefenceSafeRoom, bool> <>9__38_0; // 0x70

	// Methods

	// RVA: 0x2403730 Offset: 0x23FF730 VA: 0x2403730
	private static void .cctor() { }

	// RVA: 0x2403798 Offset: 0x23FF798 VA: 0x2403798
	public void .ctor() { }

	// RVA: 0x24037A0 Offset: 0x23FF7A0 VA: 0x24037A0
	internal bool <get_StartRoom>b__11_0(GameObject r) { }

	// RVA: 0x2403828 Offset: 0x23FF828 VA: 0x2403828
	internal bool <get_SafeRoomList>b__13_0(GameObject obj) { }

	// RVA: 0x24038C8 Offset: 0x23FF8C8 VA: 0x24038C8
	internal DefenceSafeRoom <get_SafeRoomList>b__13_1(GameObject obj) { }

	// RVA: 0x2403918 Offset: 0x23FF918 VA: 0x2403918
	internal bool <get_MonsterRoomList>b__15_0(GameObject obj) { }

	// RVA: 0x24039B8 Offset: 0x23FF9B8 VA: 0x24039B8
	internal DefenceMonsterRoom <get_MonsterRoomList>b__15_1(GameObject obj) { }

	// RVA: 0x2403A08 Offset: 0x23FFA08 VA: 0x2403A08
	internal bool <get_CrystalCount>b__17_0(DefenceSafeRoom x) { }

	// RVA: 0x2403AB4 Offset: 0x23FFAB4 VA: 0x2403AB4
	internal bool <get_NoDamageCrystalCount>b__19_0(DefenceSafeRoom x) { }

	// RVA: 0x2403B50 Offset: 0x23FFB50 VA: 0x2403B50
	internal int <get_CrystalHP>b__21_0(DefenceSafeRoom x) { }

	// RVA: 0x2403BE4 Offset: 0x23FFBE4 VA: 0x2403BE4
	internal int <get_CrystalHP_percent>b__23_0(DefenceSafeRoom x) { }

	// RVA: 0x2403BF8 Offset: 0x23FFBF8 VA: 0x2403BF8
	internal int <get_CrystalHP_percent>b__23_1(DefenceSafeRoom x) { }

	// RVA: 0x2403C8C Offset: 0x23FFC8C VA: 0x2403C8C
	internal void <Clear>b__26_0(DefenceSafeRoom x) { }

	// RVA: 0x2403CB0 Offset: 0x23FFCB0 VA: 0x2403CB0
	internal void <Clear>b__26_1(DefenceMonsterRoom x) { }

	// RVA: 0x2403CD4 Offset: 0x23FFCD4 VA: 0x2403CD4
	internal void <FadeoutMagicSquare>b__27_0(DefenceMonsterRoom x) { }

	// RVA: 0x2403D14 Offset: 0x23FFD14 VA: 0x2403D14
	internal bool <GetNearSafeRoom>b__38_0(DefenceSafeRoom b) { }
}
