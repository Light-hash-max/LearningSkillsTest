namespace LearningSkillsTest.Features.Points
{
    using UnityEngine;

    /// <summary>
    /// Обработчик изменения количества очков.
    /// </summary>
    public sealed class PointsPresenter : MonoBehaviour
    {
        [SerializeField]
        private PointsModel[] _points = default;

        private PointsModel _currentPointsModel = null;

        private PointsModel FindPointsModelById(string id)
        {
            foreach (PointsModel pointsModel in _points)
            {
                if (pointsModel.PointsId == id)
                {
                    return pointsModel;
                }
            }

            return null;
        }

        /// <summary>
        /// Выставить новое количество очков с заданным id.
        /// </summary>
        /// <param name="idPoints"></param>
        /// <param name="value"></param>
        public void SetPoints(string idPoints, int value)
        {
            _currentPointsModel = FindPointsModelById(idPoints);

            if (_currentPointsModel == null)
            {
                return;
            }

            _currentPointsModel.ChangePointsValue(value);
        }

        /// <summary>
        /// Добавить количество очков с заданным id.
        /// </summary>
        /// <param name="idPoints"></param>
        /// <param name="value"></param>
        public void AddPoints(string idPoints, int addValue)
        {
            _currentPointsModel = FindPointsModelById(idPoints);

            if (_currentPointsModel == null)
            {
                return;
            }

            _currentPointsModel.ChangePointsValue(_currentPointsModel.PointsCount + addValue);
        }

        /// <summary>
        /// Убавить количество очков с заданным id.
        /// </summary>
        /// <param name="idPoints"></param>
        /// <param name="value"></param>
        public void RemovePoints(string idPoints, int removeValue)
        {
            _currentPointsModel = FindPointsModelById(idPoints);

            if (_currentPointsModel == null)
            {
                return;
            }

            _currentPointsModel.ChangePointsValue(_currentPointsModel.PointsCount - removeValue);
        }
    }
}