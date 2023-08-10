namespace LearningSkillsTest.Features.Skills
{
    using UnityEngine;

    /// <summary>
    /// Вьюшка, вызывающая действие "забыть все навыки".
    /// </summary>
    public abstract class AbstractForgetAllSkillsView : MonoBehaviour
    {
        protected AllSkillsController _allSkillsController = null;

        protected virtual void Awake() => _allSkillsController = FindObjectOfType<AllSkillsController>();

        /// <summary>
        /// Забыть все навыки.
        /// </summary>
        protected virtual void ForgetAllSkills() => _allSkillsController.ForgetAllSkills();
    }
}