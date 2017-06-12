using System;

namespace GroupTaskCalculator
{
    class Calc
    {
        private static string alphabet = "0123456789ABCDEF"; // ���������� �������
        private readonly int _inputNumSyst; // ��������� ��
        private readonly int _outputNumSyst; // �������� ��
        private string _entry; // ������� ������

        public Calc(int inputNumSyst, int outputNumSyst, string entry)
        {
            _inputNumSyst = inputNumSyst;
            _outputNumSyst = outputNumSyst;
            _entry = entry;
            Check();
        }

        private void Check()
        {
            _entry = _entry.ToUpper(); // � ������� ������� ��� �����
            _entry = _entry.Trim(); // ������� ������� � �����
            _entry = _entry.Replace('.', ','); // �������� �����

            if (_entry == "-") // ����� �� ����� �������� �� ������
                throw new Exception("����� �� ����� �������� �� ������!");

            if (_entry == ",") // ����� �� ����� �������� �� �������
                throw new Exception("����� �� ����� �������� �� �������!");


            if (_entry.IndexOf(',') != _entry.LastIndexOf(',')
            ) // �������� �� ��, ��� ���� ������ ���� ������� ��� � ��� ������
                throw new Exception("�������� ������ ���� ����������� ���� � �����!");

            if (_entry.LastIndexOf('-') != -1) // �������� �� ��, ��� ���� ������ ���� ����� ��� ��� ��� ������
                if (_entry.LastIndexOf('-') != 0)
                    throw new Exception("�������� ������ ���� ����� � ����� � ������ � ������!");

            if (_entry == "") // �������� �� �������
                throw new Exception("������ �����!");

            if (_entry[0] == ',') // �������� �� ������� ����� ����� �������
                _entry = "0" + _entry;

            if (_entry.Contains(" ")) // �������� �� ��������� �����
                throw new Exception("�������� ���������� ������ ���� ����� �� ���!");

            foreach (char c in _entry) // �������� �� ������ ��
                if ((alphabet.IndexOf(c) > _inputNumSyst - 1 || alphabet.IndexOf(c) == -1) & c != ','& c != '-')
                    throw new Exception("���� �� ���� �� ������������� �������� ������� ��������� (" + c + ")!");

            _entry = _entry.Contains(",") ? _entry.Trim('0').Trim(',') : _entry.TrimStart('0');
            if (_entry.Length == 0) _entry = "0";
        }

        public string Convert()
        {
            return Data.Convert(new Data(_entry, _inputNumSyst), _outputNumSyst).Value;
        }
    }
}