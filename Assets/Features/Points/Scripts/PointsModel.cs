namespace LearningSkillsTest.Features.Points
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Данные об очках.
    /// </summary>
    [CreateAssetMenu(fileName = "new PointsModel", menuName = "LearningSkillsTest/Features/Points/PointsModel")]
    public sealed class PointsModel : ScriptableObject
    {
        /// <summary>
        /// Изменилось значение очков.
        /// </summary>
        public event Action onValueChanged = delegate { };

        /// <summary>
        /// Количество очков.
        /// </summary>
        public int PointsCount
        {
            get => _pointsCount;

            private set
            {
                if (value != _pointsCount)
                {
                    if (value < 0)
                    {
                        _pointsCount = 0;
                    }
                    else
                    {
                        _pointsCount = value;
                    }
                    onValueChanged();
                }
            }
        }

        /// <summary>
        /// Идентификатор очков.
        /// </summary>
        public string PointsId => _pointsId;

        [SerializeField]
        private string _pointsId = string.Empty;
        private int _pointsCount = 0;

        /// <summary>
        /// Изменить количество очков.
        /// </summary>
        /// <param name="pointsCount"></param>
        public void ChangePointsValue(int pointsCount) => PointsCount = pointsCount;
    }
}