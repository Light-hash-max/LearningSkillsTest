namespace LearningSkillsTest.Features.Skills
{
    using UnityEngine;

    /// <summary>
    /// Условие для изучения навыка.
    /// </summary>
    public abstract class AbstractSkillCondition : ScriptableObject
    {
        [SerializeField]
        protected string _id = string.Empty;
        /// <summary>
        /// Проверить на выполнения условия.
        /// </summary>
        /// <returns></returns>
        public abstract bool CheckCompetedState();
    }
}