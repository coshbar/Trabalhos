namespace ConsoleApp3
{
    class Sheet
    {
        public string Cpf { get; set; }
        public float Hour_value { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Hour { get; set; }

        public static double Calc_bruto(int hour, float value) => hour * value;
        public static double Calc_ir(int _hour, float _value)
        {
            double _ir, _bruto = _hour * _value;
            switch (_bruto)
            {
                case <= 1372.81:
                    _ir = 0;
                    return _ir;
                case > 1372.81 and <= 2743.25:
                    _ir = _bruto / 100 * 15 - 205.92;
                    return _ir;
                default:
                    _ir = _bruto / 100 * 27.5 - 548.82;
                    return _ir;
            }
        }
        public static double Calc_inss(int _hour, float _value)
        {
            double _inss, _bruto = _hour * _value;
            switch (_bruto)
            {
                case <= 868.28:
                    _inss = _bruto / 100 * 8;
                    return _inss;
                case > 868.28 and <= 1447.14:
                    _inss = _bruto / 100 * 9;
                    return _inss;
                case > 1447.14 and <= 2894.28:
                    _inss = _bruto / 100 * 11;
                    return _inss;
                default:
                    _inss = 318.37;
                    return _inss;
            }
        }
        public static double Calc_fgts(int _hour, float _value) => Calc_bruto(_hour, _value) / 100 * 8;
        public static double Calc_liquid(int _hour, float _value) => Calc_bruto(_hour, _value) - Calc_inss(_hour, _value) - Calc_fgts(_hour, _value);
    }
}
