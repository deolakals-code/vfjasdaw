// Assembly: Assembly-CSharp.dll
// Namespace: 
private class SummerDivingManager.FishData // TypeDefIndex: 4545
{
	// Fields
	private int max; // 0x10
	private List<DivingMob> fishList; // 0x18
	[CompilerGenerated]
	private int <MobId>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsClient>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IsServer>k__BackingField; // 0x25

	// Properties
	public int MobId { get; set; }
	public bool IsClient { get; set; }
	public bool IsServer { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x25216EC Offset: 0x251D6EC VA: 0x25216EC
	public int get_MobId() { }

	[CompilerGenerated]
	// RVA: 0x25216F4 Offset: 0x251D6F4 VA: 0x25216F4
	private void set_MobId(int value) { }

	[CompilerGenerated]
	// RVA: 0x25216FC Offset: 0x251D6FC VA: 0x25216FC
	public bool get_IsClient() { }

	[CompilerGenerated]
	// RVA: 0x2521704 Offset: 0x251D704 VA: 0x2521704
	private void set_IsClient(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2521710 Offset: 0x251D710 VA: 0x2521710
	public bool get_IsServer() { }

	[CompilerGenerated]
	// RVA: 0x2521718 Offset: 0x251D718 VA: 0x2521718
	private void set_IsServer(bool value) { }

	// RVA: 0x251DF18 Offset: 0x2519F18 VA: 0x251DF18
	public void .ctor(int mobId, int popMax, bool isServer) { }

	// RVA: 0x251F3C0 Offset: 0x251B3C0 VA: 0x251F3C0
	public bool TryGetHitMob(GameObject target, bool bullet, Vector3 pos, float rad, Vector3 vec, out DivingMob mob) { }

	// RVA: 0x251EF74 Offset: 0x251AF74 VA: 0x251EF74
	public bool TryGetHitMob(GameObject target, bool bullet, Vector3 pos, float rad, Vector3 vec, int removeId, out DivingMob mob) { }

	// RVA: 0x251F5C8 Offset: 0x251B5C8 VA: 0x251F5C8
	public bool TryForwardNearMob(Vector3 pos, Vector3 forward, float dotArea, float scopeaDist, out float dot, out DivingMob mob) { }

	// RVA: 0x2520FE0 Offset: 0x251CFE0 VA: 0x2520FE0
	public DivingMob GetMob(int uniqueId) { }

	// RVA: 0x2521734 Offset: 0x251D734 VA: 0x2521734
	public DivingMob GetClientMob(byte localId) { }

	// RVA: 0x2520BAC Offset: 0x251CBAC VA: 0x2520BAC
	public void Add(DivingMob item) { }

	// RVA: 0x2520CF4 Offset: 0x251CCF4 VA: 0x2520CF4
	public void Remove(int mobId, byte localId, int uniqueId, bool destroy) { }

	// RVA: 0x25213F8 Offset: 0x251D3F8 VA: 0x25213F8
	public void AllDead() { }

	// RVA: 0x251E3BC Offset: 0x251A3BC VA: 0x251E3BC
	public void Clear() { }

	// RVA: 0x2521818 Offset: 0x251D818 VA: 0x2521818
	public bool IsMax() { }

	// RVA: 0x252186C Offset: 0x251D86C VA: 0x252186C
	public IEnumerable<DivingMob> GetEnumerable() { }
}
