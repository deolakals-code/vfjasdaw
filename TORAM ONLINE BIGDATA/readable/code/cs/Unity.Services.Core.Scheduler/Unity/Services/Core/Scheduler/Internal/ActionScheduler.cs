// Assembly: Unity.Services.Core.Scheduler.dll
// Namespace: Unity.Services.Core.Scheduler.Internal
internal class ActionScheduler : IActionScheduler, IServiceComponent // TypeDefIndex: 17899
{
	// Fields
	internal readonly PlayerLoopSystem SchedulerLoopSystem; // 0x10
	private readonly ITimeProvider m_TimeProvider; // 0x38
	private readonly object m_Lock; // 0x40
	private readonly MinimumBinaryHeap<ScheduledInvocation> m_ScheduledActions; // 0x48
	private readonly Dictionary<long, ScheduledInvocation> m_IdScheduledInvocationMap; // 0x50
	private readonly List<ScheduledInvocation> m_ExpiredActions; // 0x58
	private long m_NextId; // 0x60

	// Methods

	// RVA: 0x37B3750 Offset: 0x37AF750 VA: 0x37B3750
	public void .ctor() { }

	// RVA: 0x37B37B4 Offset: 0x37AF7B4 VA: 0x37B37B4
	public void .ctor(ITimeProvider timeProvider) { }

	// RVA: 0x37B3A5C Offset: 0x37AFA5C VA: 0x37B3A5C
	internal void ExecuteExpiredActions() { }

	// RVA: 0x37B4020 Offset: 0x37B0020 VA: 0x37B4020
	internal static void UpdateCurrentPlayerLoopWith(List<PlayerLoopSystem> subSystemList, PlayerLoopSystem currentPlayerLoop) { }

	// RVA: 0x37B40AC Offset: 0x37B00AC VA: 0x37B40AC
	public void JoinPlayerLoopSystem() { }
}
