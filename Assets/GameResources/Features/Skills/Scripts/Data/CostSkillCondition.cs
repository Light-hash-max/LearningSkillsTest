namespace LearningSkillsTest.Features.Skills
{
    using LearningSkillsTest.Features.Points;
    using UnityEngine;

    /// <summary>
    /// Условие изучения навыка по стоимости.
    /// </summary>
    [CreateAssetMenu(fileName = "new CostSkillCondition", menuName = "LearningSkillsTest/Features/Skills/CostSkillCondition")]
    public sealed class CostSkillCondition : AbstractSkillCondition
    {
        /// <summary>
        /// Стоимость навыка.
        /// </summary>
        public int SkillCost => _skillCost;

        /// <summary>
        /// Данные очков.
        /// </summary>
        public PointsModel Points => _pointsModel;

        [SerializeField]
        private int _skillCost = 0;

        [SerializeField]
        private PointsModel _pointsModel = default;

        public override bool CheckCompetedState() => _pointsModel.PointsCount >= SkillCost;
    }
}