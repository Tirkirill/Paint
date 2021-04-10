using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public static class StringResources
    {
        static public string NoFrame = "Сначала нужно добавить хотя бы один кадр";
        static public string IncorrectFrameDurationInput = "Введите длительность кадра корректно!";
        static public string IncorrectWidthInputTemplate = "Ширина должна быть от {0} до {1}!";
        static public string IncorrectHeightInputTemplate = "Высота должна быть от {0} до {1}!";
        static public string IncorrectFrameRateInputTemplate = "Частота кадров должна быть от {0} до {1}!";

        static public string FrameNamePrefix = "pb";
        static public string LabelNamePrefix = "lpb";
        static public string BorderNamePrefix = "bpb";
    }
}
