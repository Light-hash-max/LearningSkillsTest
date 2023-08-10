namespace LearningSkillsTest.Features.Skills
{
    using UnityEngine;
    using UnityEngine.UI;

    /// <summary>
    /// Отображение выученного состояния навыка через изменение цвета изображения.
    /// </summary>
    public sealed class ImageColorSkillCompleteView : AbstractSkillCompleteView
    {
        [SerializeField]
        private Image _completeImage = default;
        [SerializeField]
        private Color _completeColor = Color.blue;
        [SerializeField]
        private Color _incompleteColor = Color.white;

        protected override void ChangeCompleteView() => _completeImage.color = _currentSkill.IsCompleted ? _completeColor : _incompleteColor;
    }
}