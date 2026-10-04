// Assembly: Firebase.App.dll
// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FirebaseApp.<>c // TypeDefIndex: 17224
{
	// Fields
	public static readonly FirebaseApp.<>c <>9; // 0x0
	public static FirebaseApp.CreateDelegate <>9__15_0; // 0x8
	public static Func<bool> <>9__48_0; // 0x10
	public static Func<DependencyStatus> <>9__56_0; // 0x18
	public static Func<Task, Task<DependencyStatus>> <>9__57_1; // 0x20
	public static Func<Task<DependencyStatus>, Task<DependencyStatus>> <>9__57_0; // 0x28
	public static Action<Task> <>9__60_1; // 0x30

	// Methods

	// RVA: 0x265ECE8 Offset: 0x265ACE8 VA: 0x265ECE8
	private static void .cctor() { }

	// RVA: 0x265ED50 Offset: 0x265AD50 VA: 0x265ED50
	public void .ctor() { }

	// RVA: 0x265ED58 Offset: 0x265AD58 VA: 0x265ED58
	internal FirebaseApp <Create>b__15_0() { }

	// RVA: 0x265EDA4 Offset: 0x265ADA4 VA: 0x265EDA4
	internal bool <CreateAndTrack>b__48_0() { }

	// RVA: 0x265EDF0 Offset: 0x265ADF0 VA: 0x265EDF0
	internal DependencyStatus <CheckDependenciesAsync>b__56_0() { }

	// RVA: 0x265EE70 Offset: 0x265AE70 VA: 0x265EE70
	internal Task<DependencyStatus> <CheckAndFixDependenciesAsync>b__57_0(Task<DependencyStatus> checkTask) { }

	// RVA: 0x265EFFC Offset: 0x265AFFC VA: 0x265EFFC
	internal Task<DependencyStatus> <CheckAndFixDependenciesAsync>b__57_1(Task t) { }

	// RVA: 0x265F048 Offset: 0x265B048 VA: 0x265F048
	internal void <FixDependenciesAsync>b__60_1(Task t) { }
}
