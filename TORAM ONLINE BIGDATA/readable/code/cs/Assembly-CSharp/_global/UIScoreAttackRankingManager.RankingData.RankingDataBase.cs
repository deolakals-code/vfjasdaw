// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScoreAttackRankingManager.RankingData.RankingDataBase // TypeDefIndex: 6258
{
	// Fields
	public bool isCalculatingPeriod; // 0x10
	public short elapsedMinutes; // 0x12
	public Dictionary<ScoreAttackRankingType, DateTime> updateTimes; // 0x18
	public ScoreAttackMyRankData_Solo myRank_Solo; // 0x20
	public ScoreAttackRankingSendData_Solo[] rankingList_Solo; // 0x28
	public Dictionary<ScoreAttackRankingType, ScoreAttackMyRankData_Roll> myRank_Roll; // 0x30
	public Dictionary<ScoreAttackRankingType, ScoreAttackRankingSendData_Roll[]> rankingList_Roll; // 0x38

	// Methods

	// RVA: 0x18D38A4 Offset: 0x18CF8A4 VA: 0x18D38A4
	public void .ctor() { }
}
