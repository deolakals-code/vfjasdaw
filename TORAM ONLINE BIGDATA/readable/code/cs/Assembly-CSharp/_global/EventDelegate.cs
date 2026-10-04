// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class EventDelegate // TypeDefIndex: 71
{
	// Fields
	[SerializeField]
	private MonoBehaviour mTarget; // 0x10
	[SerializeField]
	private string mMethodName; // 0x18
	public bool oneShot; // 0x20
	private EventDelegate.Callback mCachedCallback; // 0x28
	private static int s_Hash; // 0x0

	// Properties
	public MonoBehaviour target { get; set; }
	public string methodName { get; set; }
	public bool isValid { get; }
	public bool isEnabled { get; }

	// Methods

	// RVA: 0x172A668 Offset: 0x1726668 VA: 0x172A668
	public MonoBehaviour get_target() { }

	// RVA: 0x172A670 Offset: 0x1726670 VA: 0x172A670
	public void set_target(MonoBehaviour value) { }

	// RVA: 0x172A694 Offset: 0x1726694 VA: 0x172A694
	public string get_methodName() { }

	// RVA: 0x172A69C Offset: 0x172669C VA: 0x172A69C
	public void set_methodName(string value) { }

	// RVA: 0x172A6C0 Offset: 0x17266C0 VA: 0x172A6C0
	public bool get_isValid() { }

	// RVA: 0x172A744 Offset: 0x1726744 VA: 0x172A744
	public bool get_isEnabled() { }

	// RVA: 0x172A7CC Offset: 0x17267CC VA: 0x172A7CC
	public void .ctor() { }

	// RVA: 0x172A7D4 Offset: 0x17267D4 VA: 0x172A7D4
	public void .ctor(EventDelegate.Callback call) { }

	// RVA: 0x172A944 Offset: 0x1726944 VA: 0x172A944
	public void .ctor(MonoBehaviour target, string methodName) { }

	// RVA: 0x172A9B8 Offset: 0x17269B8 VA: 0x172A9B8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x172AB08 Offset: 0x1726B08 VA: 0x172AB08 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x172AB60 Offset: 0x1726B60 VA: 0x172AB60
	private EventDelegate.Callback Get() { }

	// RVA: 0x172A800 Offset: 0x1726800 VA: 0x172A800
	private void Set(EventDelegate.Callback call) { }

	// RVA: 0x172A978 Offset: 0x1726978 VA: 0x172A978
	public void Set(MonoBehaviour target, string methodName) { }

	// RVA: 0x172ACDC Offset: 0x1726CDC VA: 0x172ACDC
	public bool Execute() { }

	// RVA: 0x172AD0C Offset: 0x1726D0C VA: 0x172AD0C Slot: 3
	public override string ToString() { }

	// RVA: 0x1725E6C Offset: 0x1721E6C VA: 0x1725E6C
	public static void Execute(List<EventDelegate> list) { }

	// RVA: 0x1725520 Offset: 0x1721520 VA: 0x1725520
	public static bool IsValid(List<EventDelegate> list) { }

	// RVA: 0x172AE0C Offset: 0x1726E0C VA: 0x172AE0C
	public static void Set(List<EventDelegate> list, EventDelegate.Callback callback) { }

	// RVA: 0x17262F8 Offset: 0x17222F8 VA: 0x17262F8
	public static void Add(List<EventDelegate> list, EventDelegate.Callback callback) { }

	// RVA: 0x172AF34 Offset: 0x1726F34 VA: 0x172AF34
	public static void Add(List<EventDelegate> list, EventDelegate.Callback callback, bool oneShot) { }

	// RVA: 0x172B0E0 Offset: 0x17270E0 VA: 0x172B0E0
	public static void Add(List<EventDelegate> list, EventDelegate ev) { }

	// RVA: 0x172B148 Offset: 0x1727148 VA: 0x172B148
	public static void Add(List<EventDelegate> list, EventDelegate ev, bool oneShot) { }

	// RVA: 0x172B300 Offset: 0x1727300 VA: 0x172B300
	public static bool Remove(List<EventDelegate> list, EventDelegate.Callback callback) { }

	// RVA: 0x172B3D0 Offset: 0x17273D0 VA: 0x172B3D0
	private static void .cctor() { }
}
