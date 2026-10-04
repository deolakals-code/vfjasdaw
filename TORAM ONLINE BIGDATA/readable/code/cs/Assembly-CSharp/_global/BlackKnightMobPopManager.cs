// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightMobPopManager // TypeDefIndex: 4209
{
	// Fields
	private int mobNum; // 0x10
	[CompilerGenerated]
	private BlackKnightMobObjectManager <MobObjectManager>k__BackingField; // 0x18
	private List<BlackKnightMobPopManager.MobPop> mobPopList; // 0x20
	private BlackKnightPlayerManager targetMng; // 0x28
	private GuideRail guideRail; // 0x30

	// Properties
	private BlackKnightMobObjectManager MobObjectManager { get; set; }
	public int PopPointCount { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x24AB71C Offset: 0x24A771C VA: 0x24AB71C
	private BlackKnightMobObjectManager get_MobObjectManager() { }

	[CompilerGenerated]
	// RVA: 0x24AB724 Offset: 0x24A7724 VA: 0x24AB724
	public void set_MobObjectManager(BlackKnightMobObjectManager value) { }

	// RVA: 0x24AB72C Offset: 0x24A772C VA: 0x24AB72C
	public int get_PopPointCount() { }

	// RVA: 0x24AB774 Offset: 0x24A7774 VA: 0x24AB774
	public void PopDataClear() { }

	// RVA: 0x24AB7E4 Offset: 0x24A77E4 VA: 0x24AB7E4
	public void Initialize(BlackKnightPlayerManager player, BlackKnightMobObjectManager objectManager, GuideRail rail) { }

	// RVA: 0x24AB828 Offset: 0x24A7828 VA: 0x24AB828
	public void .ctor() { }
}
