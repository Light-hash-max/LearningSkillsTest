namespace LearningSkillsTest.Features.Skills
{
    using LearningSkillsTest.Features.Points;
    using System;
    using UnityEngine;

    /// <summary>
    /// Навыки, принаджежащие одному типу очков.
    /// </summary>
    [Serializable]
    public sealed class OneTypePointsSkills
    {
        /// <summary>
        /// Навыки.
        /// </summary>
        public SkillWithCost[] Skills => _skills;

        /// <summary>
        /// Данный об очках.
        /// </summary>
        public PointsModel PointsModel => _pointsModel;

        [SerializeField]
        private SkillWithCost[] _skills = default;
        [SerializeField]
        private PointsModel _pointsModel = default;
    }
}