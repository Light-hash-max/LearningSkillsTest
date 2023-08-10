namespace LearningSkillsTest.Features.Skills
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Сомбинация инофрмации о состоянии изучения навыка с его стоимостью.
    /// </summary>
    [Serializable]
    public sealed class SkillWithCost
    {
        /// <summary>
        /// Состояние изучения навыка.
        /// </summary>
        public SkillCompleteCondition CompleteCondition => _completeCondition;

        /// <summary>
        /// Стоимость навыка.
        /// </summary>
        public CostSkillCondition CostSkillCondition => _costSkillCondition;

        [SerializeField]
        private SkillCompleteCondition _completeCondition = default;
        [SerializeField]
        private CostSkillCondition _costSkillCondition = default;
    }
}