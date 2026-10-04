// Assembly: Assembly-CSharp.dll
// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MobObjectManager.<>c // TypeDefIndex: 972
{
	// Fields
	public static readonly MobObjectManager.<>c <>9; // 0x0
	public static Func<MobObjectManager.EnemyData, bool> <>9__42_0; // 0x8
	public static Predicate<MobObjectManager.EnemyData> <>9__44_0; // 0x10
	public static Func<MobObjectManager.EnemyData, GameObject> <>9__46_0; // 0x18
	public static Action<MobObjectManager.EnemyData> <>9__50_0; // 0x20
	public static Action<MobObjectManager.EnemyData> <>9__50_1; // 0x28
	public static Action<MobObjectManager.OtherPlayerMobData> <>9__50_2; // 0x30
	public static Func<MobObjectManager.SymbolData, MobActionManagerBase> <>9__57_0; // 0x38
	public static Func<MobActionManagerBase, bool> <>9__57_1; // 0x40
	public static Func<MobObjectManager.EnemyData, MobActionManagerBase> <>9__57_2; // 0x48
	public static Func<MobActionManagerBase, bool> <>9__57_3; // 0x50
	public static Func<MobObjectManager.SymbolData, bool> <>9__58_0; // 0x58
	public static Func<MobObjectManager.SymbolData, MobActionManagerBase> <>9__58_1; // 0x60
	public static Func<MobObjectManager.EnemyData, bool> <>9__58_2; // 0x68
	public static Func<MobObjectManager.EnemyData, MobActionManagerBase> <>9__58_3; // 0x70
	public static Func<MobObjectManager.EnemyData, bool> <>9__72_0; // 0x78
	public static Func<MobObjectManager.EnemyData, bool> <>9__79_0; // 0x80
	public static Predicate<MobObjectManager.EnemyData> <>9__98_0; // 0x88
	public static Predicate<MobObjectManager.EnemyData> <>9__99_0; // 0x90
	public static Func<GameObject, bool> <>9__118_0; // 0x98
	public static Func<AutoMember, bool> <>9__119_0; // 0xA0
	public static Func<AutoMember, bool> <>9__123_0; // 0xA8
	public static Func<MobObjectManager.EnemyData, bool> <>9__137_2; // 0xB0
	public static Func<MobObjectManager.EnemyData, MobActionManagerBase> <>9__137_3; // 0xB8
	public static Func<MobObjectManager.EnemyData, bool> <>9__137_0; // 0xC0
	public static Func<MobObjectManager.EnemyData, MobActionManagerBase> <>9__137_1; // 0xC8
	public static Func<MobObjectManager.EnemyData, bool> <>9__139_0; // 0xD0
	public static Func<MobObjectManager.EnemyData, bool> <>9__147_0; // 0xD8
	public static Func<MobObjectManager.EnemyData, EnemyMobActionManagerBase> <>9__147_1; // 0xE0
	public static Func<MobObjectManager.EnemyData, bool> <>9__147_2; // 0xE8
	public static Func<MobObjectManager.EnemyData, EnemyMobActionManagerBase> <>9__147_3; // 0xF0
	public static Func<MobObjectManager.EnemyData, EnemyMobActionManagerBase> <>9__147_5; // 0xF8
	public static Func<MobObjectManager.EnemyData, bool> <>9__148_0; // 0x100
	public static Func<MobObjectManager.EnemyData, EnemyMobActionManagerBase> <>9__148_1; // 0x108
	public static Func<MobObjectManager.EnemyData, bool> <>9__148_2; // 0x110
	public static Func<MobObjectManager.EnemyData, EnemyMobActionManagerBase> <>9__148_3; // 0x118
	public static Func<MobObjectManager.EnemyData, EnemyMobActionManagerBase> <>9__148_5; // 0x120
	public static Func<MobObjectManager.SymbolData, EnemyMobActionManagerBase> <>9__151_1; // 0x128
	public static Func<MobObjectManager.OtherPlayerMobData, GameObject> <>9__157_0; // 0x130
	public static Func<MobObjectManager.EnemyData, bool> <>9__163_0; // 0x138
	public static Predicate<MobObjectManager.PartyMobId> <>9__167_0; // 0x140

	// Methods

	// RVA: 0x1F313F4 Offset: 0x1F2D3F4 VA: 0x1F313F4
	private static void .cctor() { }

	// RVA: 0x1F3145C Offset: 0x1F2D45C VA: 0x1F3145C
	public void .ctor() { }

	// RVA: 0x1F31464 Offset: 0x1F2D464 VA: 0x1F31464
	internal bool <get_HasEnemy>b__42_0(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F3148C Offset: 0x1F2D48C VA: 0x1F3148C
	internal bool <get_IsRoomEnemyHate>b__44_0(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F314AC Offset: 0x1F2D4AC VA: 0x1F314AC
	internal GameObject <get_RoomEnterEnemyList>b__46_0(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F314C4 Offset: 0x1F2D4C4 VA: 0x1F314C4
	internal void <Clear>b__50_0(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F314DC Offset: 0x1F2D4DC VA: 0x1F314DC
	internal void <Clear>b__50_1(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F314F4 Offset: 0x1F2D4F4 VA: 0x1F314F4
	internal void <Clear>b__50_2(MobObjectManager.OtherPlayerMobData x) { }

	// RVA: 0x1F31514 Offset: 0x1F2D514 VA: 0x1F31514
	internal MobActionManagerBase <GetTargetActionManagerList>b__57_0(MobObjectManager.SymbolData x) { }

	// RVA: 0x1F3152C Offset: 0x1F2D52C VA: 0x1F3152C
	internal bool <GetTargetActionManagerList>b__57_1(MobActionManagerBase x) { }

	// RVA: 0x1F315CC Offset: 0x1F2D5CC VA: 0x1F315CC
	internal MobActionManagerBase <GetTargetActionManagerList>b__57_2(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F315E4 Offset: 0x1F2D5E4 VA: 0x1F315E4
	internal bool <GetTargetActionManagerList>b__57_3(MobActionManagerBase x) { }

	// RVA: 0x1F31684 Offset: 0x1F2D684 VA: 0x1F31684
	internal bool <GetMobActionManagerList>b__58_0(MobObjectManager.SymbolData x) { }

	// RVA: 0x1F316EC Offset: 0x1F2D6EC VA: 0x1F316EC
	internal MobActionManagerBase <GetMobActionManagerList>b__58_1(MobObjectManager.SymbolData x) { }

	// RVA: 0x1F31704 Offset: 0x1F2D704 VA: 0x1F31704
	internal bool <GetMobActionManagerList>b__58_2(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F3176C Offset: 0x1F2D76C VA: 0x1F3176C
	internal MobActionManagerBase <GetMobActionManagerList>b__58_3(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F31784 Offset: 0x1F2D784 VA: 0x1F31784
	internal bool <ReCreateNoneUniqueEnemy>b__72_0(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F317B4 Offset: 0x1F2D7B4 VA: 0x1F317B4
	internal bool <ReleaseAllEnemy>b__79_0(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F317D4 Offset: 0x1F2D7D4 VA: 0x1F317D4
	internal bool <HasHateEnemy>b__98_0(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F317F8 Offset: 0x1F2D7F8 VA: 0x1F317F8
	internal bool <HasRoomHateEnemy>b__99_0(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F31840 Offset: 0x1F2D840 VA: 0x1F31840
	internal bool <UpdateEnemy>b__118_0(GameObject x) { }

	// RVA: 0x1F3189C Offset: 0x1F2D89C VA: 0x1F3189C
	internal bool <UpdateRoomBattleStart>b__119_0(AutoMember x) { }

	// RVA: 0x1F318D4 Offset: 0x1F2D8D4 VA: 0x1F318D4
	internal bool <PlayerDead>b__123_0(AutoMember am) { }

	// RVA: 0x1F31904 Offset: 0x1F2D904 VA: 0x1F31904
	internal bool <GetHateEnemyList>b__137_2(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F319A8 Offset: 0x1F2D9A8 VA: 0x1F319A8
	internal MobActionManagerBase <GetHateEnemyList>b__137_3(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F319C0 Offset: 0x1F2D9C0 VA: 0x1F319C0
	internal bool <GetHateEnemyList>b__137_0(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F31A44 Offset: 0x1F2DA44 VA: 0x1F31A44
	internal MobActionManagerBase <GetHateEnemyList>b__137_1(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F31A5C Offset: 0x1F2DA5C VA: 0x1F31A5C
	internal bool <CheckEnemyBoss>b__139_0(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F31A84 Offset: 0x1F2DA84 VA: 0x1F31A84
	internal bool <RecoveryMember>b__147_0(MobObjectManager.EnemyData m) { }

	// RVA: 0x1F31A9C Offset: 0x1F2DA9C VA: 0x1F31A9C
	internal EnemyMobActionManagerBase <RecoveryMember>b__147_1(MobObjectManager.EnemyData m) { }

	// RVA: 0x1F31AB4 Offset: 0x1F2DAB4 VA: 0x1F31AB4
	internal bool <RecoveryMember>b__147_2(MobObjectManager.EnemyData m) { }

	// RVA: 0x1F31AD4 Offset: 0x1F2DAD4 VA: 0x1F31AD4
	internal EnemyMobActionManagerBase <RecoveryMember>b__147_3(MobObjectManager.EnemyData m) { }

	// RVA: 0x1F31AEC Offset: 0x1F2DAEC VA: 0x1F31AEC
	internal EnemyMobActionManagerBase <RecoveryMember>b__147_5(MobObjectManager.EnemyData m) { }

	// RVA: 0x1F31B04 Offset: 0x1F2DB04 VA: 0x1F31B04
	internal bool <Buffing>b__148_0(MobObjectManager.EnemyData m) { }

	// RVA: 0x1F31B1C Offset: 0x1F2DB1C VA: 0x1F31B1C
	internal EnemyMobActionManagerBase <Buffing>b__148_1(MobObjectManager.EnemyData m) { }

	// RVA: 0x1F31B34 Offset: 0x1F2DB34 VA: 0x1F31B34
	internal bool <Buffing>b__148_2(MobObjectManager.EnemyData m) { }

	// RVA: 0x1F31B54 Offset: 0x1F2DB54 VA: 0x1F31B54
	internal EnemyMobActionManagerBase <Buffing>b__148_3(MobObjectManager.EnemyData m) { }

	// RVA: 0x1F31B6C Offset: 0x1F2DB6C VA: 0x1F31B6C
	internal EnemyMobActionManagerBase <Buffing>b__148_5(MobObjectManager.EnemyData m) { }

	// RVA: 0x1F31B84 Offset: 0x1F2DB84 VA: 0x1F31B84
	internal EnemyMobActionManagerBase <ScriptAction>b__151_1(MobObjectManager.SymbolData x) { }

	// RVA: 0x1F31B9C Offset: 0x1F2DB9C VA: 0x1F31B9C
	internal GameObject <GetOtherPlayerEnemyList>b__157_0(MobObjectManager.OtherPlayerMobData x) { }

	// RVA: 0x1F31BBC Offset: 0x1F2DBBC VA: 0x1F31BBC
	internal bool <CancelUpdateManagerEnemyData>b__163_0(MobObjectManager.EnemyData x) { }

	// RVA: 0x1F31BDC Offset: 0x1F2DBDC VA: 0x1F31BDC
	internal bool <CheckPartyMobId>b__167_0(MobObjectManager.PartyMobId x) { }
}
