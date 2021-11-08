namespace DesignPattern.Creational.BuilderPattern.SubscriptionPackages.Models
{
    public class SubscriptionPackage
    {
        private SubscriptionPackage()
        {

        }
        public static SubscriptionPackage Create()
        {
            return new SubscriptionPackage();
        }

        #region Properties

        #region Enum Properties

        public DurationType DurationType { get; private set; }
        public PackageType PackageType { get; private set; }

        #endregion

        #region Int Properties

        public int Contacts { get; private set; }
        public int Admins { get; private set; }
        public int EmailSenderNames { get; private set; }

        #endregion

        #region Decimal Properties

        public decimal UnitPrice { get; private set; }
        public decimal TotalPrice { get; private set; }

        public decimal PaymentTransactionRate { get; private set; }
        public decimal PaymentTransactionPrice { get; private set; }

        #endregion

        #region Boolean Properties

        public bool IsDigitalMembership { get; private set; }
        public bool IsMultipleBankAccount { get; private set; }
        public bool IsAPIAccess { get; private set; }

        #endregion

        #region String Properties

        public string Storage { get; private set; }
        public string APILimits { get; private set; }

        #endregion

        #region Get Properties

        public string PaymentTransactionFees
        {
            get
            {
                return PaymentTransactionRate +  "% + $" + PaymentTransactionPrice;
            }
        }

        #endregion

        #endregion

        #region Set Methods

        public void SetIsAPIAccess(bool val)
        {
            IsAPIAccess = val;
        }

        public void SetAPILimits(string val)
        {
            APILimits = val;
        }

        public void SetIsDigitalMembership(bool val)
        {
            IsDigitalMembership = val;
        }

        public void SetIsMultipleBankAccount(bool val)
        {
            IsMultipleBankAccount = val;
        }

        public void SetPackageType(PackageType packageType)
        {
            PackageType = packageType;
        }

        public void SetDurationType(DurationType durationType)
        {
            DurationType = durationType;
        }

        public void SetUnitPrice(decimal val)
        {
            UnitPrice = val;
        }

        public void SetTotalPrice(decimal val)
        {
            TotalPrice = val;
        }

        public void SetStorage(string val)
        {
            Storage = val;
        }

        public void SetAdminCount(int val)
        {
            Admins = val;
        }

        public void SetContactCount(int val)
        {
            Contacts = val;
        }

        public void SetPaymentTransactionRate(decimal val)
        {
            PaymentTransactionRate = val;
        }

        public void SetPaymentTransactionPrice(decimal val)
        {
            PaymentTransactionPrice = val;
        }

        public void SetEmailSenderCount(int val)
        {
            EmailSenderNames = val;
        }

        #endregion
    }
}
