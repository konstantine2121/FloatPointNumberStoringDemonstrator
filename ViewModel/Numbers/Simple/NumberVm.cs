using System.ComponentModel;
using System.Globalization;
using FloatPointNumberStoringDemonstrator.Model.Numbers;

namespace FloatPointNumberStoringDemonstrator.ViewModel.Numbers.Simple
{
    internal class NumberVm : INotifyPropertyChanged
    {
        #region Fields

        protected readonly string decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Значение
        /// </summary>
        public virtual string Value { get; set; } = string.Empty;

        /// <summary>
        /// Знак
        /// </summary>
        public virtual string Sign { get; } = string.Empty;

        /// <summary>
        /// Порядок
        /// </summary>
        public virtual string Exponent { get; } = string.Empty;

        /// <summary>
        /// Мантисса
        /// </summary>
        public virtual string Fraction { get; } = string.Empty;

        /// <summary>
        /// Длина порядка в битах
        /// </summary>
        public virtual string ExponentLength { get; } = string.Empty;

        /// <summary>
        /// Длина мантиссы в битах
        /// </summary>
        public virtual string FractionLength { get; } = string.Empty;

        public virtual bool IsValid { get; protected set; } = true;

        #endregion Properties

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion Events
    }

    internal class NumberVm<T> : NumberVm where T : struct
    {
        #region Fields

        protected readonly BaseNumber<T> number;

        #endregion Fields

        #region Ctor

        public NumberVm(BaseNumber<T> number)
        {
            this.number = number;
            number.ValueChanged += OnValueChanged;
        }

        #endregion Ctor

        #region Properties

        public override string Value
        {
            get => number.Value.ToString();
            set
            {
                value = value.Replace(".", decimalSeparator).Replace(",", decimalSeparator);
                IsValid = double.TryParse(value, out var doubleValue);                
                number.Value = (IsValid ? doubleValue : 0).Cast<T>();
            }
        }

        public override string Sign => number.Sign.ToString();

        public override string Exponent => number.Exponent.ToString();

        public override string Fraction => number.Fraction.ToString();

        public override string ExponentLength => number.ExponentLength.ToString();

        public override string FractionLength => number.FractionLength.ToString();

        #endregion Properties

        private void OnValueChanged(object sender, EventArgs e)
        {
            RaisePropertyChanged(nameof(Value));
            RaisePropertyChanged(nameof(Sign));
            RaisePropertyChanged(nameof(Exponent));
            RaisePropertyChanged(nameof(Fraction));
            RaisePropertyChanged(nameof(IsValid));
        }
    }
}
