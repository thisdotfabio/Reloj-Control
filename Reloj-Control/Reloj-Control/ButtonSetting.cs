using Windows.UI;

namespace Reloj_Control
{
    public class ButtonSetting
    {
        public string ButtonLabel
        { get; set; }

        public Color ButtonColor
        { get; set; }

        public string Message
        { get; set; }

        public Color MessageColor
        { get; set; }

        public string TimeFormat
        { get; set; }

        public Position TimePosition
        { get; set; }

        public enum Position
        {
            Left,
            Right
        }
    }
}
