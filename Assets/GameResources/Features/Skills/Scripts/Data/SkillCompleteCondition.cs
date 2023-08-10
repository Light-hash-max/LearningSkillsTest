namespace LearningSkillsTest.Features.Skills
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Условие, отображающее состояние изученного навыка.
    /// </summary>
    [CreateAssetMenu(fileName = "new SkillCompleteCondition", menuName = "LearningSkillsTest/Features/Skills/SkillCompleteCondition")]
    public class SkillCompleteCondition : AbstractSkillCondition
    {
        /// <summary>
        /// Изменилось состояние изученности навыка.
        /// </summary>
        public event Action onComleteStateChanged = delegate { };

        /// <summary>
        /// Изучен ли навык.
        /// </summary>
        public bool IsCompleted
        {
            get => PlayerPrefs.GetInt(_id, 0) == 1;

            set
            {
                PlayerPrefs.SetInt(_id, value ? 1 : 0);
                PlayerPrefs.Save();
                onComleteStateChanged();
            }
        }

        public override bool CheckCompetedState() => IsCompleted;

        /// <summary>
        /// Меняет состояние изучения навыка.
        /// </summary>
        /// <param name="isCompleted"></param>
        public void ChangeComleteState(bool isCompleted) => IsCompleted = isCompleted;
    }
}