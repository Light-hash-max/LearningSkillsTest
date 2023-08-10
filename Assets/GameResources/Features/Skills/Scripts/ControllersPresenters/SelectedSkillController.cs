namespace LearningSkillsTest.Features.Skills
{
    using LearningSkillsTest.Features.Points;
    using System;
    using UnityEngine;

    /// <summary>
    /// Управляет выбором текущего навыка среди всех остальных.
    /// </summary>
    public class SelectedSkillController : MonoBehaviour
    {
        /// <summary>
        /// Изменился выбранный навык.
        /// </summary>
        public event Action onActiveSkillChanged = delegate { };

        /// <summary>
        /// Выбранный навык.
        /// </summary>
        public SkillController CurrentSkill{ get; private set; } = null;

        [SerializeField]
        protected PointsModel[] _points = default;

        protected virtual void Awake()
        {
            foreach (PointsModel pointsModel in _points)
            {
                pointsModel.onValueChanged += UpdateCurrentSkillActiveState;
            }
        }

        protected virtual void OnDestroy()
        {
            foreach (PointsModel pointsModel in _points)
            {
                pointsModel.onValueChanged -= UpdateCurrentSkillActiveState;
            }
        }

        /// <summary>
        /// Выбрать активный навык.
        /// </summary>
        /// <param name="skillController"></param>
        public void SetCurrentSkill(SkillController skillController)
        {
            CurrentSkill = skillController;
            onActiveSkillChanged();
        }

        /// <summary>
        /// Обновить активное состояние выбранного навыка.
        /// </summary>
        public virtual void UpdateCurrentSkillActiveState()
        {
            if (CurrentSkill == null)
            {
                return;
            }

            onActiveSkillChanged();
        }

        /// <summary>
        /// Приобрести выбранный навык.
        /// </summary>
        public virtual void PurchaseCurrentSkill()
        {
            if (CurrentSkill == null)
            {
                return;
            }

            CurrentSkill.PurchaseSkill();
            onActiveSkillChanged();
        }

        /// <summary>
        /// Забыть выбранный навык.
        /// </summary>
        public virtual void ForgetCurrentSkill()
        {
            if (CurrentSkill == null)
            {
                return;
            }

            CurrentSkill.ForgetSkill();
            onActiveSkillChanged();
        }
    }
}