using System;

namespace GroupTaskCalculator
{
    class Calc
    {
        private static string alphabet = "0123456789ABCDEF"; // Допустимый алфавит
        private readonly int _inputNumSyst; // Начальная СС
        private readonly int _outputNumSyst; // Конечная СС
        private string _entry; // Входные данные

        public Calc(int inputNumSyst, int outputNumSyst, string entry)
        {
            _inputNumSyst = inputNumSyst;
            _outputNumSyst = outputNumSyst;
            _entry = entry;
            Check();
        }

        private void Check()
        {
            _entry = _entry.ToUpper(); // В верхний регистр все буквы
            _entry = _entry.Trim(); // Срезаем пробелы с боков
            _entry = _entry.Replace('.', ','); // Заменяем знаки

            if (_entry == "-") // Число не может состоять из минуса
                throw new Exception("Число не может состоять из минуса!");

            if (_entry == ",") // Число не может состоять из запятой
                throw new Exception("Число не может состоять из запятой!");


            if (_entry.IndexOf(',') != _entry.LastIndexOf(',')
            ) // Проверка на то, что есть только одна запятая или её нет вообще
                throw new Exception("Возможен только один разделяющий знак в числе!");

            if (_entry.LastIndexOf('-') != -1) // Проверка на то, что есть только один минус или его нет вообще
                if (_entry.LastIndexOf('-') != 0)
                    throw new Exception("Возможна только один минус в числе и только в начале!");

            if (_entry == "") // Проверка на пустоту
                throw new Exception("Строка пуста!");

            if (_entry[0] == ',') // Проверка на наличие цифры перед запятой
                _entry = "0" + _entry;

            if (_entry.Contains(" ")) // Проверка на несколько чисел
                throw new Exception("Возможно переводить только одно число за раз!");

            foreach (char c in _entry) // Проверка на верную СС
                if ((alphabet.IndexOf(c) > _inputNumSyst - 1 || alphabet.IndexOf(c) == -1) & c != ','& c != '-')
                    throw new Exception("Одна из цифр не соответствует введённой системе счисления (" + c + ")!");

            _entry = _entry.Contains(",") ? _entry.Trim('0').Trim(',') : _entry.TrimStart('0');
            if (_entry.Length == 0) _entry = "0";
        }

        public string Convert()
        {
            return Data.Convert(new Data(_entry, _inputNumSyst), _outputNumSyst).Value;
        }
    }
}