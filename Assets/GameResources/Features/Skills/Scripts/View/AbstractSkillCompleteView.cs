namespace LearningSkillsTest.Features.Skills
{
    using UnityEngine;

    /// <summary>
    /// Вьюшка, отображающая выученное состояние навыка.
    /// </summary>
    public abstract class AbstractSkillCompleteView : MonoBehaviour
    {
        [SerializeField]
        protected SkillCompleteCondition _currentSkill = default;

        protected virtual void Awake()
        {
            _currentSkill.onComleteStateChanged += ChangeCompleteView;
            ChangeCompleteView();
        }

        protected virtual void OnDestroy() => _currentSkill.onComleteStateChanged -= ChangeCompleteView;

        /// <summary>
        /// Изменить вьюшку выученного состояния.
        /// </summary>
        protected abstract void ChangeCompleteView();
    }
}