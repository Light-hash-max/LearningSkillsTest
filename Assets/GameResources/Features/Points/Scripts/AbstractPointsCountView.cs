namespace LearningSkillsTest.Features.Points
{
    using UnityEngine;

    /// <summary>
    /// Абстрактная вьюшка отображения количества очков.
    /// </summary>
    public abstract class AbstractPointsCountView : MonoBehaviour
    {
        [SerializeField]
        protected PointsModel _pointsModel = default;

        protected virtual void Awake() => _pointsModel.onValueChanged += UpdateView;

        protected virtual void OnDestroy() => _pointsModel.onValueChanged -= UpdateView;

        /// <summary>
        /// Обновить вьюшку.
        /// </summary>
        protected abstract void UpdateView();
    }
}