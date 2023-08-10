namespace LearningSkillsTest.Features.Skills
{
    using UnityEngine;

    /// <summary>
    /// Вьюшка выбора навыка.
    /// </summary>
    public abstract class AbstractChooseSkillView : MonoBehaviour
    {
        protected SkillController _skillController = default;

        protected virtual void Awake() => _skillController = GetComponent<SkillController>();

        /// <summary>
        /// Выбрать навык.
        /// </summary>
        protected abstract void ChooseSkil();
    }
}