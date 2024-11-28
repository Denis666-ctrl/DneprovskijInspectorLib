using System;
using System.Collections.Generic;

namespace InspectorLib
{
    public class FunctionInsp
    {
        private string carInspectionName = "Автоинспекция г. Чита";
        private string chiefInspector = "Васильев Василий Иванович";
        private List<string> workers = new List<string>
        {
            "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И."
        };

        public string GetInspector() => chiefInspector;

        public string GetCarInspection() => carInspectionName;

        public bool SetInspector(string fullname)
        {
            if (workers.Contains(fullname))
            {
                chiefInspector = fullname;
                return true;
            }
            return false;
        }

        public string GenerateNumber(int number, char symbol, int code)
        {
            symbol = char.ToUpper(symbol);
            if (code != 75)
                throw new ArgumentException("Код региона должен быть 75.");
            return $"{symbol}{number:D3}_{code}";
        }

        public List<string> GetWorker() => new List<string>(workers);

        public void AddWorker(string fullname)
        {
            if (!workers.Contains(fullname))
                workers.Add(fullname);
        }
    }
}
